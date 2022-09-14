using System.Diagnostics;

namespace ns14;

internal sealed class Class61
{
	public static string smethod_0(string string_0, bool bool_0 = true)
	{
		string text = "";
		using Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			UseShellExecute = false,
			CreateNoWindow = true,
			WindowStyle = ProcessWindowStyle.Hidden,
			FileName = "cmd.exe",
			Arguments = string_0,
			RedirectStandardError = true,
			RedirectStandardOutput = true
		};
		process.Start();
		text = process.StandardOutput.ReadToEnd();
		if (bool_0)
		{
			process.WaitForExit();
			return text;
		}
		return text;
	}
}
