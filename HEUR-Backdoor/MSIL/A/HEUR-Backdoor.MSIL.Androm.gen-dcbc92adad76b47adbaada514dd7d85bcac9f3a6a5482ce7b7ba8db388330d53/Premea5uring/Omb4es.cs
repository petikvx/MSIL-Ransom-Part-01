using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace Premea5uring;

public class Omb4es
{
	public static void Ars4nes(string Bri77ers, List<string> Po4men)
	{
		if (!Directory.Exists(Bri77ers))
		{
			return;
		}
		bool flag = false;
		try
		{
			Directory.Delete(Bri77ers, recursive: true);
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
		P0tches(Bri77ers, Po4men);
		try
		{
			smethod_0(Bri77ers);
		}
		catch (DirectoryNotFoundException)
		{
		}
		catch (PathTooLongException)
		{
			Po4men.Add(Bri77ers);
		}
		catch (UnauthorizedAccessException)
		{
			Po4men.Add(Bri77ers);
		}
	}

	private static void smethod_0(string C7p7bly)
	{
		try
		{
			Directory.Delete(C7p7bly, recursive: true);
		}
		catch (DirectoryNotFoundException)
		{
		}
		catch (IOException)
		{
			Thread.Sleep(500);
			Directory.Delete(C7p7bly, recursive: true);
		}
	}

	private static void P0tches(string Hon4ng, List<string> Bia44ually)
	{
		foreach (string item in Directory.EnumerateDirectories(Hon4ng))
		{
			if (!new DirectoryInfo(item).Attributes.HasFlag(FileAttributes.ReparsePoint))
			{
				P0tches(item, Bia44ually);
			}
		}
		foreach (string item2 in Directory.EnumerateFiles(Hon4ng))
		{
			string text = Path.Combine(Hon4ng, Path.GetFileName(item2));
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
				Bia44ually.Add(text);
			}
			catch (UnauthorizedAccessException)
			{
				Bia44ually.Add(text);
			}
			catch (IOException)
			{
				Bia44ually.Add(text);
			}
		}
	}
}
