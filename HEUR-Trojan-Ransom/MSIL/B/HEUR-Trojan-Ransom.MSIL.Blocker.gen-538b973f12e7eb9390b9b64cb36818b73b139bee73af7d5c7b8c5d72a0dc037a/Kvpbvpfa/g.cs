using System.Text;

namespace Kvpbvpfa;

internal static class g
{
	private static readonly string m_b = "Peufaesna";

	private static int c;

	private static int d;

	private static int e;

	private static int f;

	private static int g;

	private static int[] h;

	private static int[] l;

	private static byte[] m;

	private static byte[] a(byte[] a)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(Kvpbvpfa.g.m_b);
		h = new int[256];
		l = new int[256];
		m = new byte[a.Length];
		for (d = 0; d < 256; d++)
		{
			h[d] = bytes[d % bytes.Length];
			l[d] = d;
		}
		Kvpbvpfa.g.a();
		Kvpbvpfa.g.a(ref a);
		return m;
	}

	private static void a()
	{
		d = 0;
		for (e = 0; d < 256; d++)
		{
			e = (e + l[d] + h[d]) % 256;
			g = l[d];
			l[d] = l[e];
			l[e] = g;
		}
	}

	private static void a(ref byte[] a)
	{
		d = 0;
		e = 0;
		for (c = 0; d < a.Length; d++)
		{
			c++;
			c %= 256;
			e += l[c];
			e %= 256;
			g = l[c];
			l[c] = l[e];
			l[e] = g;
			f = l[(l[c] + l[e]) % 256];
			m[d] = (byte)(a[d] ^ f);
		}
	}

	public static byte[] b(byte[] a)
	{
		return Kvpbvpfa.g.a(a);
	}
}
