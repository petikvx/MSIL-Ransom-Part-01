using System;
using System.IO;
using System.Threading;

namespace ekati;

internal class Logger
{
	private static readonly string workingPath = "";

	private static readonly int maxLogFileSize = 1048576;

	private static ReaderWriterLock locker = new ReaderWriterLock();

	public void AddtoLogFile(string Message)
	{
		try
		{
			locker.AcquireWriterLock(int.MaxValue);
			string text = Path.Combine(workingPath, "ekati.log");
			string path = text;
			if (File.Exists(path))
			{
				if (new FileInfo(text).Length > maxLogFileSize)
				{
					File.WriteAllText(text, string.Empty);
				}
				using StreamWriter streamWriter = new StreamWriter(path, append: true);
				streamWriter.WriteLine(DateTime.Now.ToString() + " - " + Message);
			}
			else
			{
				StreamWriter streamWriter2 = File.CreateText(path);
				streamWriter2.WriteLine(DateTime.Now.ToString() + " - " + Message);
				streamWriter2.Close();
			}
			Console.WriteLine(Message);
		}
		finally
		{
			locker.ReleaseWriterLock();
		}
	}
}
