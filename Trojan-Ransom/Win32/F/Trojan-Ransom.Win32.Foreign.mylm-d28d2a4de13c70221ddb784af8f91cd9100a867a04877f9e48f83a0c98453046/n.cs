using System;
using System.IO;
using System.Reflection;
using System.Text;

internal class n
{
	internal static readonly byte[] a;

	static n()
	{
		if (n.a == null)
		{
			string s = "blB1YiQ=";
			byte[] array = Convert.FromBase64String(s);
			s = Encoding.UTF8.GetString(array, 0, array.Length);
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(s);
			n.a = o.d(97L, manifestResourceStream);
		}
	}

	internal static string a(int int_0)
	{
		int num = 0;
		string text = default(string);
		if ((n.a[int_0] & 0x80) == 0)
		{
			num = n.a[int_0];
			int_0++;
		}
		else if ((n.a[int_0] & 0x40) == 0)
		{
			num = (n.a[int_0] & -129) << 8;
			num |= n.a[int_0 + 1];
			int_0 += 2;
		}
		else
		{
			int num2 = (n.a[int_0] & -193) << 24;
			_003CModule_003E.a = text;
			num = num2;
			num |= n.a[int_0 + 1] << 16;
			int num3 = num;
			byte[] array = n.a;
			int num4 = int_0;
			_003CModule_003E.e = 1957620381;
			byte num5 = array[num4 + 2];
			_003CModule_003E.a = null;
			num = num3 | (num5 << 8);
			num |= n.a[int_0 + 3];
			int num6 = int_0;
			_003CModule_003E.g = null;
			int_0 = num6 + 4;
		}
		if (num < 1)
		{
			_003CModule_003E.e = 1818084011;
			return string.Empty;
		}
		text = Encoding.Unicode.GetString(n.a, int_0, num);
		return string.Intern(text);
	}
}
