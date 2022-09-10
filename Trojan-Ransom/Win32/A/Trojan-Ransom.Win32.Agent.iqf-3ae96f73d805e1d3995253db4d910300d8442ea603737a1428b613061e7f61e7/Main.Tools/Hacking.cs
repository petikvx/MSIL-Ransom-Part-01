using System.Runtime.InteropServices;

namespace Main.Tools;

internal static class Hacking
{
	internal static extern void InitSoftware(Config.StartModeType startMode, string arg);

	internal static extern bool ExeSmartCopy(string targetExePath, bool overwrite);

	internal static extern bool ShouldActivate();

	internal static void RemoveItself()
	{
		_ = 5;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	[DllImport("kernel32.dll")]
	public static extern uint WinExec(string lpCmdLine, uint uCmdShow);
}
