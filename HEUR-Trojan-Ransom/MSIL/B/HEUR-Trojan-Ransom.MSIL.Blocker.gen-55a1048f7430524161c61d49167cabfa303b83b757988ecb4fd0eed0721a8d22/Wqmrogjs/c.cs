using System;
using System.Threading;

namespace Wqmrogjs;

internal sealed class c : b
{
	[Serializable]
	private sealed class a
	{
		public static readonly a a;

		public static ThreadStart b;

		public static ThreadStart c;

		static a()
		{
			a obj = new a();
			if (8u != 0)
			{
				Wqmrogjs.c.a.a = obj;
			}
		}

		public a()
		{
			_ = 5;
			if (5 == 0)
			{
			}
			base._002Ector();
		}

		internal void a()
		{
			int num;
			if (true)
			{
				num = 0;
			}
			while (num < 999)
			{
				int value = num;
				if (8u != 0)
				{
					Console.WriteLine(value);
				}
				int num2 = num + 1;
				if (8u != 0)
				{
					num = num2;
				}
			}
		}

		internal void b()
		{
			int num;
			if (6u != 0)
			{
				num = 0;
			}
			while (num < 999)
			{
				int value = num;
				if (true)
				{
					Console.WriteLine(value);
				}
				int num2 = num + 1;
				if (uint.MaxValue != 0)
				{
					num = num2;
				}
			}
		}
	}

	public c()
	{
		_ = 4;
		if (false)
		{
		}
		base._002Ector();
	}

	public void rd4skt2nv3kweq5ln47ll4myrnzrf87rPEa()
	{
		ThreadStart threadStart = a.b;
		if (threadStart == null)
		{
			threadStart = a.a.a;
			ThreadStart obj = threadStart;
			if (7u != 0)
			{
				a.b = obj;
			}
		}
		Thread thread = new Thread(threadStart);
		if (2u != 0)
		{
			thread.Start();
		}
		if (8u != 0)
		{
			Thread.Sleep(22000);
		}
		new Thread(a.a.b).Start();
		if (new Random().Next(1, 3) == 1)
		{
			Console.WriteLine("open the door by the right leg!");
		}
		else
		{
			Console.WriteLine("open the door by the left leg!");
		}
	}
}
