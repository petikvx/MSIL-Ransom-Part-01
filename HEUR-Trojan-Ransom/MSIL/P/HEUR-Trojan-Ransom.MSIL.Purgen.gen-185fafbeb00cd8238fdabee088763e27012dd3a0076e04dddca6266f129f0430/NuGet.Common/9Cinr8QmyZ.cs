using System;
using System.IO;
using System.Runtime.InteropServices;

namespace NuGet.Common;

public static class _9Cinr8QmyZ
{
	private const int tAjlbVY8Fq = 511;

	public static void _84vHHOeo02(string mdBXGykHG9)
	{
		if (l6BkPTcFbv.ooEPhgvzVK)
		{
			Directory.CreateDirectory(mdBXGykHG9);
			return;
		}
		mdBXGykHG9 = Path.GetFullPath(mdBXGykHG9);
		if (Directory.Exists(mdBXGykHG9))
		{
			return;
		}
		int num = Path.GetPathRoot(mdBXGykHG9)!.Length - 1;
		do
		{
			num = mdBXGykHG9.IndexOf(Path.DirectorySeparatorChar, num + 1);
			string text = ((num == -1) ? mdBXGykHG9 : mdBXGykHG9.Substring(0, num));
			if (!Directory.Exists(text))
			{
				b9CdavmxgG(text);
			}
		}
		while (num != -1);
	}

	private static void b9CdavmxgG(string rPt4XckjH8)
	{
		string text = Path.Combine(Path.GetDirectoryName(rPt4XckjH8), Guid.NewGuid().ToString());
		Directory.CreateDirectory(text);
		if (rb9lKewweG(text, 511) == -1)
		{
			k7hecNmDxf(text);
			int lastWin32Error = Marshal.GetLastWin32Error();
			throw new InvalidOperationException($"Unable to set permission while creating {rPt4XckjH8}, errno={lastWin32Error}.");
		}
		try
		{
			Directory.Move(text, rPt4XckjH8);
		}
		catch
		{
			k7hecNmDxf(text);
			if (Directory.Exists(rPt4XckjH8))
			{
				return;
			}
			throw;
		}
	}

	private static void k7hecNmDxf(string _9PI0gYkdZq)
	{
		try
		{
			Directory.Delete(_9PI0gYkdZq);
		}
		catch
		{
		}
	}

	[DllImport("libc", EntryPoint = "chmod", SetLastError = true)]
	private static extern int rb9lKewweG(string oJ8WW9CXnd, int _4FduhvHvG6);
}
