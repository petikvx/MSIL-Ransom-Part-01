using System;
using System.IO;
using System.Runtime.InteropServices;
using ns12;

namespace S0ueezing;

public static class Outstr1tch1d
{
	private const int Em1n1tors = 511;

	public static void Tro5l5sm(string string_0)
	{
		if (Unst0ck.Oli1odendrocyte)
		{
			Directory.CreateDirectory(string_0);
			return;
		}
		string_0 = Path.GetFullPath(string_0);
		if (Directory.Exists(string_0))
		{
			return;
		}
		int num = Path.GetPathRoot(string_0)!.Length - 1;
		do
		{
			num = string_0.IndexOf(Path.DirectorySeparatorChar, num + 1);
			string text = ((num != -1) ? string_0.Substring(0, num) : string_0);
			if (!Directory.Exists(text))
			{
				Su6geon(text);
			}
		}
		while (num != -1);
	}

	private static void Su6geon(string Th8nkably)
	{
		string text = Path.Combine(Path.GetDirectoryName(Th8nkably), Guid.NewGuid().ToString());
		Directory.CreateDirectory(text);
		if (chmod(text, 511) == -1)
		{
			Colonializin1(text);
			int lastWin32Error = Marshal.GetLastWin32Error();
			throw new InvalidOperationException($"Unable to set permission while creating {Th8nkably}, errno={lastWin32Error}.");
		}
		try
		{
			Directory.Move(text, Th8nkably);
		}
		catch
		{
			Colonializin1(text);
			if (!Directory.Exists(Th8nkably))
			{
				throw;
			}
		}
	}

	private static void Colonializin1(string Aca8emes)
	{
		try
		{
			Directory.Delete(Aca8emes);
		}
		catch
		{
		}
	}

	[DllImport("libc", SetLastError = true)]
	private static extern int chmod(string Backpacke2, int A0ids);
}
