using System.Diagnostics;

namespace LuminousForts_AutoUpdate_Shared;

public class HLDSProcess
{
	private int lastProcessId = 0;

	private Config config;

	private Process process = null;

	public bool HasExited => process == null || process.HasExited;

	public HLDSProcess(Config config)
	{
		this.config = config;
	}

	public bool Start()
	{
		process = new Process();
		process.StartInfo.UseShellExecute = true;
		process.StartInfo.WorkingDirectory = config.HLDSWorkDir;
		string[] array = config.HLDSCommand.Split(new char[1] { ' ' });
		process.StartInfo.FileName = array[0];
		string text = "";
		for (int i = 1; i < array.Length; i++)
		{
			text += array[i];
		}
		process.StartInfo.Arguments = text;
		lastProcessId = process.Id;
		process.Start();
		process.WaitForExit();
		return process.ExitCode == 0;
	}

	public void Stop()
	{
		if (this.process != null)
		{
			this.process.Kill();
		}
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (process.Id == lastProcessId)
			{
				process.Kill();
				break;
			}
		}
		this.process = null;
	}
}
