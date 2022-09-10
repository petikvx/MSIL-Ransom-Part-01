using System.Diagnostics;
using System.IO;

namespace TBOT;

internal class reg
{
	public static void dll()
	{
		if (File.Exists("MSNMessengerAPI.dll"))
		{
			FileInfo fileInfo = new FileInfo("MSNMessengerAPI.dll");
			if (fileInfo.Length == 57344L)
			{
				return;
			}
			try
			{
				File.Delete("MSNMessengerAPI.dll");
			}
			catch
			{
			}
		}
		try
		{
			string arguments = "/s \\MSNMessengerAPI.dll\"";
			Process process = new Process();
			process.StartInfo.FileName = "regsvr32.exe";
			process.StartInfo.Arguments = arguments;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.RedirectStandardOutput = true;
			process.Start();
			process.WaitForExit();
			process.Close();
		}
		catch
		{
		}
	}
}
