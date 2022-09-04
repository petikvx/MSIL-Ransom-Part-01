using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

public static class GClass2
{
	[CompilerGenerated]
	private sealed class Class0
	{
		public List<string> list_0;

		public List<string> list_1;

		public void method_0(object sender, DataReceivedEventArgs e)
		{
			if (!string.IsNullOrEmpty(e.Data))
			{
				list_0.Add(e.Data);
			}
		}

		public void method_1(object sender, DataReceivedEventArgs e)
		{
			if (!string.IsNullOrEmpty(e.Data))
			{
				list_1.Add(e.Data);
			}
		}
	}

	public static bool smethod_0(string string_0)
	{
		if (!File.Exists(string_0))
		{
			return false;
		}
		string string_ = "del /s /q \"" + string_0 + "\"";
		return smethod_5(string_);
	}

	public static bool smethod_1(string string_0, string string_1)
	{
		if (!Directory.Exists(string_0))
		{
			return false;
		}
		string_0 = Path.Combine(string_0, string_1);
		string string_2 = "del /s /q \"" + string_0 + "\"";
		return smethod_5(string_2);
	}

	public static bool smethod_2(string string_0)
	{
		if (!File.Exists(string_0))
		{
			return false;
		}
		string string_ = "\"" + string_0 + "\"";
		return smethod_5(string_);
	}

	public static bool smethod_3(string string_0, string string_1, bool bool_0)
	{
		if (File.Exists(string_0) && File.Exists(string_1))
		{
			string string_2 = "copy /Y \"" + string_0 + "\" \"" + string_1 + "\"";
			if (!smethod_5(string_2) && bool_0)
			{
				string fileName = Path.GetFileName(string_1);
				smethod_4(fileName);
				return smethod_5(string_2);
			}
			return true;
		}
		return false;
	}

	public static bool smethod_4(string string_0)
	{
		string string_ = "taskkill /F /IM \"" + string_0 + "\"";
		return smethod_5(string_);
	}

	private static bool smethod_5(string string_0)
	{
		try
		{
			Process process = new Process();
			process.StartInfo.RedirectStandardError = true;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.Arguments = "/r " + string_0;
			List<string> list_0 = new List<string>();
			List<string> list_1 = new List<string>();
			process.ErrorDataReceived += delegate(object sender, DataReceivedEventArgs e)
			{
				if (!string.IsNullOrEmpty(e.Data))
				{
					list_0.Add(e.Data);
				}
			};
			process.OutputDataReceived += delegate(object sender, DataReceivedEventArgs e)
			{
				if (!string.IsNullOrEmpty(e.Data))
				{
					list_1.Add(e.Data);
				}
			};
			process.Start();
			process.BeginErrorReadLine();
			process.BeginOutputReadLine();
			process.WaitForExit();
			process.CancelOutputRead();
			process.CancelErrorRead();
			if (list_0.Count > 0)
			{
				return false;
			}
			return true;
		}
		catch
		{
			return false;
		}
	}
}
