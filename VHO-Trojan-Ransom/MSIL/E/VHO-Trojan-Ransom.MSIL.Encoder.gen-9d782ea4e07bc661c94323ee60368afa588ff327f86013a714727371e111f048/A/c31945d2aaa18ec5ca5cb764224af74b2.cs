using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace A;

internal class c31945d2aaa18ec5ca5cb764224af74b2
{
	internal static readonly byte[] cab8ac4c80d2f87670a064a63b6044a87;

	static c31945d2aaa18ec5ca5cb764224af74b2()
	{
		if (cab8ac4c80d2f87670a064a63b6044a87 == null)
		{
			string s = "UHJveHlzY3JhYiQ=";
			byte[] array = Convert.FromBase64String(s);
			s = Encoding.UTF8.GetString(array, 0, array.Length);
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(s);
			cab8ac4c80d2f87670a064a63b6044a87 = c152a8b3f5c1726278fb392a3e63b26de.c35529615ba4c81daae3d0364107e364a(97L, manifestResourceStream);
		}
	}

	internal static string cb3d61e6ddbc94a218c98dc11d6c8ee40(int cff48761c870dcd74491b9275142c51a2)
	{
		int num = 0;
		if ((cab8ac4c80d2f87670a064a63b6044a87[cff48761c870dcd74491b9275142c51a2] & 0x80) == 0)
		{
			num = cab8ac4c80d2f87670a064a63b6044a87[cff48761c870dcd74491b9275142c51a2];
			cff48761c870dcd74491b9275142c51a2++;
		}
		else if ((cab8ac4c80d2f87670a064a63b6044a87[cff48761c870dcd74491b9275142c51a2] & 0x40) == 0)
		{
			num = (cab8ac4c80d2f87670a064a63b6044a87[cff48761c870dcd74491b9275142c51a2] & -129) << 8;
			num |= cab8ac4c80d2f87670a064a63b6044a87[cff48761c870dcd74491b9275142c51a2 + 1];
			cff48761c870dcd74491b9275142c51a2 += 2;
		}
		else
		{
			num = (cab8ac4c80d2f87670a064a63b6044a87[cff48761c870dcd74491b9275142c51a2] & -193) << 24;
			num |= cab8ac4c80d2f87670a064a63b6044a87[cff48761c870dcd74491b9275142c51a2 + 1] << 16;
			num |= cab8ac4c80d2f87670a064a63b6044a87[cff48761c870dcd74491b9275142c51a2 + 2] << 8;
			num |= cab8ac4c80d2f87670a064a63b6044a87[cff48761c870dcd74491b9275142c51a2 + 3];
			cff48761c870dcd74491b9275142c51a2 += 4;
		}
		if (num < 1)
		{
			return string.Empty;
		}
		string @string = Encoding.Unicode.GetString(cab8ac4c80d2f87670a064a63b6044a87, cff48761c870dcd74491b9275142c51a2, num);
		return string.Intern(@string);
	}
}
