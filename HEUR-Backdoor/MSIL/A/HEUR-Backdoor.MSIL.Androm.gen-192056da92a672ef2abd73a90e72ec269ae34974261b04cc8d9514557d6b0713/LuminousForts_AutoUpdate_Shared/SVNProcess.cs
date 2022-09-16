using System.Diagnostics;
using System.IO;
using System.Text;

namespace LuminousForts_AutoUpdate_Shared;

public class SVNProcess
{
	private Process process = null;

	private Config config;

	public bool HasExited => process == null || process.HasExited;

	public SVNProcess(Config config)
	{
		this.config = config;
	}

	public bool Update()
	{
		process = new Process();
		process.StartInfo.UseShellExecute = true;
		process.StartInfo.WorkingDirectory = config.LuminousFortsPath;
		process.StartInfo.FileName = config.SVNPath + "svn";
		process.StartInfo.Arguments = "update";
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.RedirectStandardOutput = true;
		process.Start();
		StringBuilder stringBuilder = new StringBuilder();
		StreamReader standardOutput = process.StandardOutput;
		while (!standardOutput.EndOfStream)
		{
			string value = standardOutput.ReadToEnd();
			stringBuilder.Append(value);
		}
		string text = stringBuilder.ToString();
		FileLogger.Instance.Write("-------SVN OUTPUT-----");
		FileLogger.Instance.Write(text);
		bool flag = false;
		if (text.Split(new char[1] { '\n' }).Length > 2)
		{
			flag = true;
		}
		process.WaitForExit();
		return flag && process.ExitCode == 0;
	}

	public void Stop()
	{
		if (process != null)
		{
			process.Kill();
		}
		process = null;
	}
}
