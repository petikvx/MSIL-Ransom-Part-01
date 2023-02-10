using System.Text;

namespace Etyaonilbsgqj;

internal static class b
{
	private static readonly string m_b;

	private static int c;

	private static int d;

	private static int e;

	private static int f;

	private static int g;

	private static int[] h;

	private static int[] l;

	private static byte[] m;

	static b()
	{
		if (6u != 0)
		{
			Etyaonilbsgqj.b.m_b = "Rvrsmths";
		}
	}

	private static byte[] a(byte[] a)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(Etyaonilbsgqj.b.m_b);
		byte[] array;
		if (5u != 0)
		{
			array = bytes;
		}
		int[] array2 = new int[256];
		if (6u != 0)
		{
			h = array2;
		}
		int[] array3 = new int[256];
		if (0 == 0)
		{
			l = array3;
		}
		m = new byte[a.Length];
		for (d = 0; d < 256; d++)
		{
			h[d] = array[d % array.Length];
			l[d] = d;
		}
		Etyaonilbsgqj.b.a();
		Etyaonilbsgqj.b.a(ref a);
		return m;
	}

	private static void a()
	{
		if (0 == 0)
		{
			d = 0;
		}
		if (6u != 0)
		{
			e = 0;
		}
		while (d < 256)
		{
			int num = (e + l[d] + h[d]) % 256;
			if (uint.MaxValue != 0)
			{
				e = num;
			}
			g = l[d];
			l[d] = l[e];
			l[e] = g;
			d++;
		}
	}

	private static void a(ref byte[] a)
	{
		if (2u != 0)
		{
			d = 0;
		}
		if (8u != 0)
		{
			e = 0;
		}
		if (5u != 0)
		{
			c = 0;
		}
		while (d < a.Length)
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
			d++;
		}
	}

	public static byte[] b(byte[] a)
	{
		_ = 1;
		if (2 == 0)
		{
		}
		return Etyaonilbsgqj.b.a(a);
	}
}
