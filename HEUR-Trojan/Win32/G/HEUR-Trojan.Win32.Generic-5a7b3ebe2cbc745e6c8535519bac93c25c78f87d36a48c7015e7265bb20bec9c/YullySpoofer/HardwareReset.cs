using System;

namespace YullySpoofer;

internal class HardwareReset
{
	private static string ApplicationName { get; set; }

	private static string CurrentDate { get; set; }

	private static string CurrentUserName { get; set; }

	private static string LastResetDate { get; set; }

	static HardwareReset()
	{
		ApplicationName = "Yully Spoofer";
		CurrentDate = DateTime.Now.ToString("M/d/yyyy");
		LastResetDate = Program.KeyAuthApp.getvar("LastHwid");
		CurrentUserName = Program.KeyAuthApp.user_data.username;
	}

	public static async void ResetUser()
	{
	}
}
