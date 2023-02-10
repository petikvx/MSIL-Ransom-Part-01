using System.Text;

namespace Nqonesmskmkmbumex;

internal static class d
{
	private static readonly string m_b;

	private static int c;

	private static int m_d;

	private static int e;

	private static int f;

	private static int g;

	private static int[] h;

	private static int[] l;

	private static byte[] m;

	static d()
	{
		if (6u != 0)
		{
			Nqonesmskmkmbumex.d.m_b = "Nkbykejmptzljebkbkv";
		}
	}

	private static byte[] a(byte[] a)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(Nqonesmskmkmbumex.d.m_b);
		byte[] array;
		if (true)
		{
			array = bytes;
		}
		int[] array2 = new int[256];
		if (7u != 0)
		{
			h = array2;
		}
		int[] array3 = new int[256];
		if (0 == 0)
		{
			l = array3;
		}
		m = new byte[a.Length];
		for (m_d = 0; m_d < 256; m_d++)
		{
			h[m_d] = array[m_d % array.Length];
			l[m_d] = m_d;
		}
		Nqonesmskmkmbumex.d.a();
		Nqonesmskmkmbumex.d.a(ref a);
		return m;
	}

	private static void a()
	{
		if (3u != 0)
		{
			m_d = 0;
		}
		if (3u != 0)
		{
			e = 0;
		}
		while (m_d < 256)
		{
			int num = (e + l[m_d] + h[m_d]) % 256;
			if (6u != 0)
			{
				e = num;
			}
			g = l[m_d];
			l[m_d] = l[e];
			l[e] = g;
			m_d++;
		}
	}

	private static void a(ref byte[] a)
	{
		if (0 == 0)
		{
			m_d = 0;
		}
		if (2u != 0)
		{
			e = 0;
		}
		if (5u != 0)
		{
			c = 0;
		}
		while (m_d < a.Length)
		{
			c++;
			c %= 256;
			e += l[c];
			e %= 256;
			g = l[c];
			l[c] = l[e];
			l[e] = g;
			f = l[(l[c] + l[e]) % 256];
			m[m_d] = (byte)(a[m_d] ^ f);
			m_d++;
		}
	}

	public static byte[] b(byte[] a)
	{
		_ = 5;
		if (8 == 0)
		{
		}
		return Nqonesmskmkmbumex.d.a(a);
	}
}
