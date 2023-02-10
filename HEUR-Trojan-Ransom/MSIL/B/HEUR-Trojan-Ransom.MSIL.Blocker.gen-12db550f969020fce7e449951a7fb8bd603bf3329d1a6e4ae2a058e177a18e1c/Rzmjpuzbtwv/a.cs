using System.Text;

namespace Rzmjpuzbtwv;

internal static class a
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

	static a()
	{
		if (8u != 0)
		{
			Rzmjpuzbtwv.a.m_b = "Zklgylawvqcxiinkcodxmw";
		}
	}

	private static byte[] a(byte[] a)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(Rzmjpuzbtwv.a.m_b);
		byte[] array;
		if (8u != 0)
		{
			array = bytes;
		}
		int[] array2 = new int[256];
		if (3u != 0)
		{
			h = array2;
		}
		int[] array3 = new int[256];
		if (3u != 0)
		{
			l = array3;
		}
		m = new byte[a.Length];
		for (d = 0; d < 256; d++)
		{
			h[d] = array[d % array.Length];
			l[d] = d;
		}
		Rzmjpuzbtwv.a.a();
		Rzmjpuzbtwv.a.a(ref a);
		return m;
	}

	private static void a()
	{
		if (5u != 0)
		{
			d = 0;
		}
		if (uint.MaxValue != 0)
		{
			e = 0;
		}
		while (d < 256)
		{
			int num = (e + l[d] + h[d]) % 256;
			if (4u != 0)
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
		if (true)
		{
			d = 0;
		}
		if (8u != 0)
		{
			e = 0;
		}
		if (0 == 0)
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
		if (false)
		{
		}
		return Rzmjpuzbtwv.a.a(a);
	}
}
