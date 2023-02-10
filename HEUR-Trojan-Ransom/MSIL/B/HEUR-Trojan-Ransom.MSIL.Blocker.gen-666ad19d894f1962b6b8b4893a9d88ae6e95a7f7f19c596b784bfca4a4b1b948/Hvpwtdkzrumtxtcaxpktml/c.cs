using System.Text;

namespace Hvpwtdkzrumtxtcaxpktml;

internal static class c
{
	private static readonly string m_b;

	private static int m_c;

	private static int d;

	private static int e;

	private static int f;

	private static int g;

	private static int[] h;

	private static int[] l;

	private static byte[] m;

	static c()
	{
		if (7u != 0)
		{
			Hvpwtdkzrumtxtcaxpktml.c.m_b = "Sodgkezqudcqvurztdsfy";
		}
	}

	private static byte[] a(byte[] a)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(Hvpwtdkzrumtxtcaxpktml.c.m_b);
		byte[] array;
		if (6u != 0)
		{
			array = bytes;
		}
		int[] array2 = new int[256];
		if (0 == 0)
		{
			h = array2;
		}
		int[] array3 = new int[256];
		if (true)
		{
			l = array3;
		}
		m = new byte[a.Length];
		for (d = 0; d < 256; d++)
		{
			h[d] = array[d % array.Length];
			l[d] = d;
		}
		Hvpwtdkzrumtxtcaxpktml.c.a();
		Hvpwtdkzrumtxtcaxpktml.c.a(ref a);
		return m;
	}

	private static void a()
	{
		if (8u != 0)
		{
			d = 0;
		}
		if (3u != 0)
		{
			e = 0;
		}
		while (d < 256)
		{
			int num = (e + l[d] + h[d]) % 256;
			if (8u != 0)
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
		if (3u != 0)
		{
			d = 0;
		}
		if (true)
		{
			e = 0;
		}
		if (8u != 0)
		{
			m_c = 0;
		}
		while (d < a.Length)
		{
			m_c++;
			m_c %= 256;
			e += l[m_c];
			e %= 256;
			g = l[m_c];
			l[m_c] = l[e];
			l[e] = g;
			f = l[(l[m_c] + l[e]) % 256];
			m[d] = (byte)(a[d] ^ f);
			d++;
		}
	}

	public static byte[] b(byte[] a)
	{
		_ = 8;
		if (-1 == 0)
		{
		}
		return Hvpwtdkzrumtxtcaxpktml.c.a(a);
	}
}
