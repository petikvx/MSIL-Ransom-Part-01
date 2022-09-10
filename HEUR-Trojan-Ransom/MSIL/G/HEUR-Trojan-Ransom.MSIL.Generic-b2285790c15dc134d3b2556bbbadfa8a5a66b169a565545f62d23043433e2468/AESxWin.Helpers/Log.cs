using System;
using System.IO;

namespace AESxWin.Helpers;

public static class Log
{
	public static object _locker = new object();

	public static void WriteLog(string string_0, string string_1)
	{
		try
		{
			lock (_locker)
			{
				File.AppendAllText(string_0, string.Format("{0}: {1}", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), string_1 + Environment.NewLine));
			}
		}
		catch
		{
		}
	}
}
