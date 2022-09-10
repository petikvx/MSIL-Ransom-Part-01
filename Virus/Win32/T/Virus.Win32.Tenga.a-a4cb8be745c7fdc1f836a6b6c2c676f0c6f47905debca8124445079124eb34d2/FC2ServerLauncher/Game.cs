using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FC2ServerLauncher;

internal static class Game
{
	public delegate void ConsoleCallback(IntPtr output);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate void ConsoleCallbackDelegate(IntPtr output);

	public delegate void MessageCallback(IntPtr player, IntPtr output);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate void MessageCallbackDelegate(IntPtr player, IntPtr output);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate void MessagePumpCallbackDelegate(bool deferQuit, bool blockRenderer);

	private static ConsoleCallbackDelegate m_delegateConsoleCallback;

	private static MessageCallbackDelegate m_delegateMessageCallback;

	private static IntPtr m_consoleObserver = IntPtr.Zero;

	private static bool m_run = false;

	private static MessagePumpCallbackDelegate m_delegateMessagePumpCallback;

	public static bool Running
	{
		get
		{
			return m_run;
		}
		set
		{
			m_run = value;
		}
	}

	private static void MessagePumpCallback(bool deferQuit, bool blockRenderer)
	{
	}

	private static bool InitEngine(Form mainWindow, Control viewport, string commandLine, ConsoleCallback callback, MessageCallback message)
	{
		m_delegateMessagePumpCallback = MessagePumpCallback;
		if (!InitDuniaEngine(Process.GetCurrentProcess().MainModule!.BaseAddress, ((Control)mainWindow).get_Handle(), viewport.get_Handle(), commandLine, launchGame: true, forceGpuSynchronization: false, m_delegateMessagePumpCallback))
		{
			return false;
		}
		m_consoleObserver = FCS_Server_CreateConsoleObserver();
		m_delegateConsoleCallback = callback.Invoke;
		FCS_Server_Console_Callback(m_delegateConsoleCallback);
		m_delegateMessageCallback = message.Invoke;
		FCS_Server_Message_Callback(m_delegateMessageCallback);
		Running = true;
		return true;
	}

	public static void Run()
	{
		while (!((Control)MainForm.Instance).get_IsDisposed() && Running)
		{
			TickDuniaEngine();
			Application.DoEvents();
		}
		Shutdown();
	}

	public static void ExecuteCommand(string command)
	{
		if (Running)
		{
			FCS_Server_ExecuteConsole(command);
		}
	}

	public static string AutoCompleteCommand(string command, bool reverse)
	{
		if (Running)
		{
			return Marshal.PtrToStringAnsi(FCS_Server_ConsoleAutoComplete(command, reverse));
		}
		return "";
	}

	public static bool CanCallVote(string command)
	{
		if (Running)
		{
			return FCS_Server_CanCallVote(command);
		}
		return true;
	}

	public static bool Start(Form mainWindow, Control viewport, string commandLine, ConsoleCallback callback, MessageCallback message)
	{
		if (Running)
		{
			return SwitchContext(commandLine);
		}
		return InitEngine(mainWindow, viewport, commandLine, callback, message);
	}

	public static bool Stop(string commandLine)
	{
		if (Running)
		{
			return SwitchContext(commandLine);
		}
		return false;
	}

	public static void Shutdown()
	{
		Running = false;
	}

	private static void ShutdownEngine()
	{
		FCS_Server_DeleteConsoleObserver(m_consoleObserver);
		ShutdownDuniaEngine();
	}

	public static string Localize(string text)
	{
		if (Running)
		{
			return Marshal.PtrToStringUni(LocalizeText("MultiMenu", text));
		}
		return text;
	}

	[DllImport("Dunia.dll")]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool InitDuniaEngine(IntPtr hInstance, IntPtr focusWnd, IntPtr renderWnd, [MarshalAs(UnmanagedType.LPStr)] string cmdLine, [MarshalAs(UnmanagedType.U1)] bool launchGame, [MarshalAs(UnmanagedType.U1)] bool forceGpuSynchronization, MessagePumpCallbackDelegate messagePumpCallback);

	[DllImport("Dunia.dll")]
	[return: MarshalAs(UnmanagedType.U1)]
	public static extern bool TickDuniaEngine();

	[DllImport("Dunia.dll")]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool RunDuniaEngine();

	[DllImport("Dunia.dll")]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool ShutdownDuniaEngine();

	[DllImport("Dunia.dll")]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool SwitchContext([MarshalAs(UnmanagedType.LPStr)] string cmdLine);

	[DllImport("Dunia.dll")]
	private static extern IntPtr LocalizeText([MarshalAs(UnmanagedType.LPStr)] string section, [MarshalAs(UnmanagedType.LPStr)] string text);

	[DllImport("Dunia.dll")]
	public static extern int GetCRCFromString([MarshalAs(UnmanagedType.LPStr)] string text);

	[DllImport("Dunia.dll")]
	private static extern IntPtr FCS_Server_CreateConsoleObserver();

	[DllImport("Dunia.dll")]
	private static extern void FCS_Server_DeleteConsoleObserver(IntPtr consoleObserver);

	[DllImport("Dunia.dll")]
	private static extern void FCS_Server_Console_Callback(ConsoleCallbackDelegate consoleCallback);

	[DllImport("Dunia.dll")]
	private static extern void FCS_Server_ExecuteConsole([MarshalAs(UnmanagedType.LPWStr)] string cmdLine);

	[DllImport("Dunia.dll")]
	private static extern void FCS_Server_Message_Callback(MessageCallbackDelegate messageCallback);

	[DllImport("Dunia.dll")]
	private static extern IntPtr FCS_Server_ConsoleAutoComplete([MarshalAs(UnmanagedType.LPStr)] string command, [MarshalAs(UnmanagedType.U1)] bool reverse);

	[DllImport("Dunia.dll")]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool FCS_Server_CanCallVote([MarshalAs(UnmanagedType.LPStr)] string commandName);

	[DllImport("Dunia.dll")]
	public static extern IntPtr FCS_Server_CreatePlayerStats([MarshalAs(UnmanagedType.LPWStr)] string name);

	[DllImport("Dunia.dll")]
	public static extern int FCS_Server_GetPlayerStats_Kills(IntPtr player);

	[DllImport("Dunia.dll")]
	public static extern int FCS_Server_GetPlayerStats_Deaths(IntPtr player);

	[DllImport("Dunia.dll")]
	public static extern int FCS_Server_GetPlayerStats_TeamKills(IntPtr player);

	[DllImport("Dunia.dll")]
	public static extern int FCS_Server_GetPlayerStats_Suicides(IntPtr player);

	[DllImport("Dunia.dll")]
	public static extern int FCS_Server_GetPlayerStats_Revives(IntPtr player);

	[DllImport("Dunia.dll")]
	public static extern int FCS_Server_GetPlayerStats_Wins(IntPtr player);

	[DllImport("Dunia.dll")]
	public static extern int FCS_Server_GetPlayerStats_Losses(IntPtr player);

	[DllImport("Dunia.dll")]
	public static extern int FCS_Server_GetPlayerStats_Xp(IntPtr player);

	[DllImport("Dunia.dll")]
	public static extern int FCS_Server_GetPlayerStats_Rank(IntPtr player);

	[DllImport("Dunia.dll")]
	public static extern void FCS_Server_DeletePlayerStats(IntPtr player);

	[DllImport("Dunia.dll")]
	public static extern IntPtr FCS_Server_CreateMatchStats();

	[DllImport("Dunia.dll")]
	public static extern int FCS_Server_GetMatchStats_PlayersCount(IntPtr match);

	[DllImport("Dunia.dll")]
	public static extern IntPtr FCS_Server_GetMatchStats_PlayerName(IntPtr match, int index);

	[DllImport("Dunia.dll")]
	public static extern int FCS_Server_GetMatchStats_PlayerScore(IntPtr match, int index);

	[DllImport("Dunia.dll")]
	public static extern IntPtr FCS_Server_GetMatchStats_PlayerTeam(IntPtr match, int index);

	[DllImport("Dunia.dll")]
	[return: MarshalAs(UnmanagedType.U1)]
	public static extern bool FCS_Server_GetMatchStats_PlayerVIP(IntPtr match, int index);

	[DllImport("Dunia.dll")]
	public static extern int FCS_Server_GetMatchStats_TeamsCount(IntPtr match);

	[DllImport("Dunia.dll")]
	public static extern IntPtr FCS_Server_GetMatchStats_TeamName(IntPtr match, int index);

	[DllImport("Dunia.dll")]
	public static extern int FCS_Server_GetMatchStats_TeamScore(IntPtr match, int index);

	[DllImport("Dunia.dll")]
	public static extern IntPtr FCS_Server_GetMatchStats_Map(IntPtr match);

	[DllImport("Dunia.dll")]
	public static extern IntPtr FCS_Server_GetMatchStats_Mode(IntPtr match);

	[DllImport("Dunia.dll")]
	public static extern void FCS_Server_DeleteMatchStats(IntPtr match);
}
