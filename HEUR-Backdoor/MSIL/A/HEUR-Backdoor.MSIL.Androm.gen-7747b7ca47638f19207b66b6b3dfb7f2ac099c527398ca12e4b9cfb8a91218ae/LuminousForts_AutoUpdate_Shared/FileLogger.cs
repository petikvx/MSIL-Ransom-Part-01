using System;
using System.IO;

namespace LuminousForts_AutoUpdate_Shared;

public class FileLogger
{
	private static FileLogger instance;

	private string logFile = "log.txt";

	public static FileLogger Instance
	{
		get
		{
			if (instance == null)
			{
				instance = new FileLogger();
			}
			return instance;
		}
	}

	public FileLogger()
	{
	}

	public FileLogger(string logFile)
	{
		this.logFile = logFile;
	}

	public void Write(string message)
	{
		try
		{
			StreamWriter streamWriter = new StreamWriter(logFile, append: true);
			streamWriter.WriteLine(DateTime.Now.ToString() + ":" + message);
			streamWriter.Close();
		}
		catch (IOException)
		{
			Console.WriteLine(message);
		}
	}
}
