using System.Text;

namespace Oihinlybjnot;

internal static class e
{
	private static readonly string m_b;

	private static int c;

	private static int d;

	private static int m_e;

	private static int f;

	private static int g;

	private static int[] h;

	private static int[] l;

	private static byte[] m;

	static e()
	{
		if (7u != 0)
		{
			Oihinlybjnot.e.m_b = "Phcbjnqxshubtvlgjuajuhby";
		}
	}

	private static byte[] a(byte[] a)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(Oihinlybjnot.e.m_b);
		byte[] array;
		if (true)
		{
			array = bytes;
		}
		int[] array2 = new int[256];
		if (3u != 0)
		{
			h = array2;
		}
		int[] array3 = new int[256];
		if (4u != 0)
		{
			l = array3;
		}
		m = new byte[a.Length];
		for (d = 0; d < 256; d++)
		{
			h[d] = array[d % array.Length];
			l[d] = d;
		}
		Oihinlybjnot.e.a();
		Oihinlybjnot.e.a(ref a);
		return m;
	}

	private static void a()
	{
		if (7u != 0)
		{
			d = 0;
		}
		if (5u != 0)
		{
			m_e = 0;
		}
		while (d < 256)
		{
			int num = (m_e + l[d] + h[d]) % 256;
			if (3u != 0)
			{
				m_e = num;
			}
			g = l[d];
			l[d] = l[m_e];
			l[m_e] = g;
			d++;
		}
	}

	private static void a(ref byte[] a)
	{
		if (uint.MaxValue != 0)
		{
			d = 0;
		}
		if (2u != 0)
		{
			m_e = 0;
		}
		if (5u != 0)
		{
			c = 0;
		}
		while (d < a.Length)
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
			d++;
		}
	}

	public static byte[] b(byte[] a)
	{
		_ = -1;
		if (8 == 0)
		{
		}
		return Oihinlybjnot.e.a(a);
	}
}
