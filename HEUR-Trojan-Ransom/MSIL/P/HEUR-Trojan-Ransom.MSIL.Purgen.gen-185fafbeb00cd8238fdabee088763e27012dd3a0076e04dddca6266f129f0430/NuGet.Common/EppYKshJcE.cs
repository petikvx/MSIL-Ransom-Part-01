using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace NuGet.Common;

public class EppYKshJcE
{
	public static void NaKEQmuAn2(string _6Su5z4IOX1, List<string> IEqyItK5Se)
	{
		if (!Directory.Exists(_6Su5z4IOX1))
		{
			return;
		}
		bool flag = false;
		try
		{
			Directory.Delete(_6Su5z4IOX1, recursive: true);
		}
		catch (DirectoryNotFoundException)
		{
		}
		catch (IOException)
		{
			flag = true;
		}
		catch (UnauthorizedAccessException)
		{
			flag = true;
		}
		if (!flag)
		{
			return;
		}
		uTcXMYC0Dq(_6Su5z4IOX1, IEqyItK5Se);
		try
		{
			LQb6gfj3Bm(_6Su5z4IOX1);
		}
		catch (DirectoryNotFoundException)
		{
		}
		catch (PathTooLongException)
		{
			IEqyItK5Se.Add(_6Su5z4IOX1);
		}
		catch (UnauthorizedAccessException)
		{
			IEqyItK5Se.Add(_6Su5z4IOX1);
		}
	}

	private static void LQb6gfj3Bm(string nNSDfyEgRu)
	{
		try
		{
			Directory.Delete(nNSDfyEgRu, recursive: true);
		}
		catch (DirectoryNotFoundException)
		{
		}
		catch (IOException)
		{
			Thread.Sleep(500);
			Directory.Delete(nNSDfyEgRu, recursive: true);
		}
	}

	private static void uTcXMYC0Dq(string nW4pe5pHGI, List<string> WbgTobbXiE)
	{
		foreach (string item in Directory.EnumerateDirectories(nW4pe5pHGI))
		{
			if (!new DirectoryInfo(item).Attributes.HasFlag(FileAttributes.ReparsePoint))
			{
				uTcXMYC0Dq(item, WbgTobbXiE);
			}
		}
		foreach (string item2 in Directory.EnumerateFiles(nW4pe5pHGI))
		{
			string text = Path.Combine(nW4pe5pHGI, Path.GetFileName(item2));
			try
			{
				FileAttributes attributes = File.GetAttributes(text);
				if (attributes.HasFlag(FileAttributes.ReadOnly))
				{
					attributes &= ~FileAttributes.ReadOnly;
					File.SetAttributes(text, attributes);
				}
				File.Delete(text);
			}
			catch (PathTooLongException)
			{
				WbgTobbXiE.Add(text);
			}
			catch (UnauthorizedAccessException)
			{
				WbgTobbXiE.Add(text);
			}
			catch (IOException)
			{
				WbgTobbXiE.Add(text);
			}
		}
	}
}
