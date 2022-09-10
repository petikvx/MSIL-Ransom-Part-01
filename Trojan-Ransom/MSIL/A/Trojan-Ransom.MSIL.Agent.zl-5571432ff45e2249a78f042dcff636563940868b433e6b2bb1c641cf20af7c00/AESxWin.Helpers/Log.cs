using System;
using System.IO;

namespace AESxWin.Helpers;

public static class Log
{
	public static object _locker = new object();

	public static void WriteLog(string path, string text)
	{
		try
		{
			lock (_locker)
			{
				File.AppendAllText(path, string.Format("{0}: {1}", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), text + Environment.NewLine));
			}
		}
		catch
		{
		}
	}
}
