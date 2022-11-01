using System.Diagnostics;

namespace YullySpoofer;

internal class HWIDQuery
{
	public static string NewHardwareID { get; set; }

	public static string OldHardwareID { get; set; }

	public static void GetHardwareID(bool type)
	{
		if (type)
		{
			Process process = new Process();
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.FileName = "wmic.exe";
			process.StartInfo.Arguments = "diskdrive get serialnumber";
			process.Start();
			OldHardwareID = process.StandardOutput.ReadToEnd();
			process.WaitForExit();
		}
		else
		{
			Process process2 = new Process();
			process2.StartInfo.UseShellExecute = false;
			process2.StartInfo.RedirectStandardOutput = true;
			process2.StartInfo.FileName = "wmic.exe";
			process2.StartInfo.Arguments = "diskdrive get serialnumber";
			process2.Start();
			NewHardwareID = process2.StandardOutput.ReadToEnd();
			process2.WaitForExit();
		}
	}
}
