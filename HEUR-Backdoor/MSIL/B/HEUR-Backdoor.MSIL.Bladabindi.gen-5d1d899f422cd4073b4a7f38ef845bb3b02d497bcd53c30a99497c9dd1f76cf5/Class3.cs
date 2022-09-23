using System.IO;
using System.Text;

internal class Class3
{
	public static int PsYjkc_a(int a, int b)
	{
		return (int)((uint)a >> b);
	}

	public static int PsYjkc_b(TextReader a, byte[] b, int c, int d)
	{
		if (b.Length == 0)
		{
			return 0;
		}
		char[] array = new char[b.Length];
		int num = a.Read(array, c, d);
		if (num == 0)
		{
			return -1;
		}
		for (int i = c; i < c + num; i++)
		{
			b[i] = (byte)array[i];
		}
		return num;
	}

	internal static byte[] PsYjkc_c(string a)
	{
		return Encoding.UTF8.GetBytes(a);
	}

	internal static char[] PsYjkc_d(byte[] a)
	{
		return Encoding.UTF8.GetChars(a);
	}
}
