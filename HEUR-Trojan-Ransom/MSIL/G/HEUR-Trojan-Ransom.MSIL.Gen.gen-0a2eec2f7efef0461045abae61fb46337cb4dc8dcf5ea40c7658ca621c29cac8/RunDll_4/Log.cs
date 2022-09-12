using System;
using System.IO;
using System.Reflection;

namespace RunDll_4;

public static class Log
{
	private static readonly object locker;

	private static string path { get; set; }

	static Log()
	{
		locker = new object();
		path = Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location);
	}

	public static void Write(string message)
	{
		string fileName = Path.Combine(path, "log.txt");
		lock (locker)
		{
			FileInfo fileInfo = new FileInfo(fileName);
			if (fileInfo.Exists && fileInfo.Length > 5242880L)
			{
				string destFileName = Path.Combine(path, "log.txt.old");
				if (File.Exists(destFileName))
				{
					File.Delete(destFileName);
				}
				fileInfo.MoveTo(destFileName);
			}
			using StreamWriter streamWriter = new StreamWriter(fileName, append: true);
			streamWriter.WriteLine("[" + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss") + "] " + message);
			streamWriter.Flush();
		}
	}

	public static void Write(Exception ex)
	{
		Write(ex.Message);
		Write(ex.StackTrace);
		Exception innerException = ex.InnerException;
		if (innerException != null)
		{
			Write("==== InnerException ====");
			Write(innerException.Message);
			Write(innerException.StackTrace);
		}
	}
}
