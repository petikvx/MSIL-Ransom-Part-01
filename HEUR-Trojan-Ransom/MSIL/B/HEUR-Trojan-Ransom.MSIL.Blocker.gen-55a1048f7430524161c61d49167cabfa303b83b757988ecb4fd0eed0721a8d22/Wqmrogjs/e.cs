using System;
using System.Threading;
using Onbjqormmjsglpfdfozbdkmz;

namespace Wqmrogjs;

internal sealed class e : b
{
	[Serializable]
	private sealed class a
	{
		public static readonly a a;

		public static ThreadStart b;

		static a()
		{
			a obj = new a();
			if (8u != 0)
			{
				e.a.a = obj;
			}
		}

		public a()
		{
			_ = 1;
			if (7 == 0)
			{
			}
			base._002Ector();
		}

		internal void a()
		{
			int num;
			if (5u != 0)
			{
				num = 0;
			}
			while (num < 999)
			{
				int value = num;
				if (uint.MaxValue != 0)
				{
					Console.WriteLine(value);
				}
				int num2 = num + 1;
				if (2u != 0)
				{
					num = num2;
				}
			}
		}
	}

	public e()
	{
		_ = -1;
		if (3 == 0)
		{
		}
		base._002Ector();
	}

	public void rd4skt2nv3kweq5ln47ll4myrnzrf87rPEa()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
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
		if (3u != 0)
		{
			thread.Start();
		}
		new ClassLibrary().Data();
	}
}
