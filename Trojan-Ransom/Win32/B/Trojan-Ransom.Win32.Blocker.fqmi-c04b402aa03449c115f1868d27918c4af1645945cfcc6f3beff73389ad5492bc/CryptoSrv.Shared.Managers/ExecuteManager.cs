using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace CryptoSrv.Shared.Managers;

public class ExecuteManager
{
	private readonly string _file;

	private readonly string _arguments;

	private readonly ProcessPriorityClass _priority;

	private int _waitInterval = 60000;

	public DataReceivedEventHandler OnOutput { get; set; }

	public DataReceivedEventHandler OnError { get; set; }

	public int WaitInterval
	{
		set
		{
			_waitInterval = value;
		}
	}

	public ExecuteManager()
	{
	}

	public ExecuteManager(string file, string arguments = "", ProcessPriorityClass priority = ProcessPriorityClass.BelowNormal)
	{
		_file = file;
		_arguments = arguments;
		_priority = priority;
	}

	public virtual bool Run(out string outMessage, bool waitExist = true)
	{
		try
		{
			if (!File.Exists(_file))
			{
				outMessage = "File not exist";
				return false;
			}
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				FileName = _file,
				UseShellExecute = false,
				RedirectStandardOutput = true,
				RedirectStandardError = true,
				CreateNoWindow = true,
				WindowStyle = ProcessWindowStyle.Hidden,
				Arguments = _arguments
			};
			Process process2 = process;
			process2.Start();
			process2.PriorityClass = _priority;
			if (waitExist)
			{
				if (OnOutput != null)
				{
					process2.OutputDataReceived += OnOutput;
				}
				StringBuilder outError = new StringBuilder();
				process2.ErrorDataReceived += delegate(object sender, DataReceivedEventArgs e)
				{
					if (!string.IsNullOrEmpty(e.Data))
					{
						outError.AppendLine(e.Data);
						if (OnError != null)
						{
							OnError(sender, e);
						}
					}
				};
				process2.BeginErrorReadLine();
				process2.BeginOutputReadLine();
				process2.WaitForExit(_waitInterval);
				outMessage = outError.ToString();
				return outError.Length == 0;
			}
			outMessage = null;
			return true;
		}
		catch (Exception ex)
		{
			outMessage = ex.Message + ex.StackTrace;
			return false;
		}
	}
}
