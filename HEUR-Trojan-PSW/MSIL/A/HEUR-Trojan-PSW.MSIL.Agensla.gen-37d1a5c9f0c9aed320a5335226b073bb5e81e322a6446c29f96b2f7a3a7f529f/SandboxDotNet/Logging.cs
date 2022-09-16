using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using SandboxDotNet.UserInterface;

namespace SandboxDotNet;

public class Logging
{
	public enum Severity
	{
		DEBUG,
		INFO,
		WARN,
		ERROR
	}

	private List<string> _buffer;

	public string LogFilePath { get; set; }

	public DevConsole DeveloperConsole { get; set; }

	public bool UseMainConsole { get; set; }

	public Logging()
	{
		LogFilePath = "";
		DeveloperConsole = null;
		UseMainConsole = false;
	}

	public void Log(string message, Severity severity = Severity.INFO)
	{
		string arg = DateTime.Now.ToString("hh:mm:ss tt");
		switch (severity)
		{
		case Severity.DEBUG:
			if (DFHGUYV.IsDevModeEnabled())
			{
				RawLog($"[{arg}] [DEBUG] {message}");
			}
			break;
		case Severity.INFO:
			RawLog($"[{arg}] [INFO] {message}");
			break;
		case Severity.WARN:
			RawLog($"[{arg}] [WARN] {message}");
			break;
		case Severity.ERROR:
			RawLog($"[{arg}] [ERROR] {message}");
			break;
		}
	}

	private void BufferConsoleWrite(string message)
	{
		if (_buffer == null)
		{
			_buffer = new List<string>();
		}
		_buffer.Add(message);
	}

	private void DumpBufferToLog()
	{
		foreach (string item in _buffer)
		{
			RawLog(item, bypassBufferCheck: true);
		}
		_buffer = null;
	}

	private void RawLog(string message, bool bypassBufferCheck = false)
	{
		if (UseMainConsole || DeveloperConsole != null || !string.IsNullOrWhiteSpace(LogFilePath))
		{
			if (!bypassBufferCheck && _buffer != null && _buffer.Count > 0)
			{
				DumpBufferToLog();
			}
			if (UseMainConsole)
			{
				WriteToMainConsole(message);
			}
			if (!string.IsNullOrWhiteSpace(LogFilePath))
			{
				WriteToLogFile(message);
			}
			if (DeveloperConsole != null)
			{
				WriteToDevConsole(message);
			}
		}
		else
		{
			BufferConsoleWrite(message);
		}
	}

	private void WriteToMainConsole(string message)
	{
		Console.WriteLine("[SandboxDotNet] {0}", message);
	}

	private void WriteToDevConsole(string message)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		((Control)DeveloperConsole).BeginInvoke((Delegate)(MethodInvoker)delegate
		{
			DeveloperConsole.AppendToConsole(message);
		});
	}

	private void WriteToLogFile(string message)
	{
		File.AppendAllText(LogFilePath, message + Environment.NewLine);
	}
}
