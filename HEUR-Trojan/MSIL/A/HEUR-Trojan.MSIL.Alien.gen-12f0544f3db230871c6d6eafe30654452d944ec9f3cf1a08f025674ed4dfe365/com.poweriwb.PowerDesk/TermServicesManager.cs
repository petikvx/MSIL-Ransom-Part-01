using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace com.poweriwb.PowerDesk;

public class TermServicesManager
{
	private struct WTS_SESSION_INFO
	{
		public int SessionID;

		[MarshalAs(UnmanagedType.LPStr)]
		public string pWinStationName;

		public WTS_CONNECTSTATE_CLASS State;
	}

	public struct WTS_CLIENT_ADDRESS
	{
		public uint AddressFamily;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
		public byte[] Address;
	}

	public struct WTS_CLIENT_DISPLAY
	{
		public uint HorizontalResolution;

		public uint VerticalResolution;

		public uint ColorDepth;
	}

	public enum WTS_CONNECTSTATE_CLASS
	{
		Active,
		Connected,
		ConnectQuery,
		Shadow,
		Disconnected,
		Idle,
		Listen,
		Reset,
		Down,
		Init
	}

	public enum WTS_INFO_CLASS
	{
		InitialProgram,
		ApplicationName,
		WorkingDirectory,
		OEMId,
		SessionId,
		UserName,
		WinStationName,
		DomainName,
		ConnectState,
		ClientBuildNumber,
		ClientName,
		ClientDirectory,
		ClientProductId,
		ClientHardwareId,
		ClientAddress,
		ClientDisplay,
		ClientProtocolType
	}

	[DllImport("wtsapi32.dll")]
	private static extern IntPtr WTSOpenServer([MarshalAs(UnmanagedType.LPStr)] string pServerName);

	[DllImport("wtsapi32.dll")]
	private static extern void WTSCloseServer(IntPtr hServer);

	[DllImport("Wtsapi32.dll")]
	public static extern bool WTSQuerySessionInformation(IntPtr hServer, int sessionId, WTS_INFO_CLASS wtsInfoClass, out IntPtr ppBuffer, out uint pBytesReturned);

	[DllImport("wtsapi32.dll")]
	private static extern int WTSEnumerateSessions(IntPtr hServer, [MarshalAs(UnmanagedType.U4)] int Reserved, [MarshalAs(UnmanagedType.U4)] int Version, ref IntPtr ppSessionInfo, [MarshalAs(UnmanagedType.U4)] ref int pCount);

	[DllImport("wtsapi32.dll")]
	private static extern void WTSFreeMemory(IntPtr pMemory);

	private static IntPtr OpenServer(string Name)
	{
		return WTSOpenServer(Name);
	}

	private static void CloseServer(IntPtr ServerHandle)
	{
		WTSCloseServer(ServerHandle);
	}

	public static List<TerminalSessionData> ListSessions(string ServerName)
	{
		IntPtr zero = IntPtr.Zero;
		List<TerminalSessionData> list = new List<TerminalSessionData>();
		zero = OpenServer(ServerName);
		try
		{
			IntPtr ppSessionInfo = IntPtr.Zero;
			int pCount = 0;
			int num = WTSEnumerateSessions(zero, 0, 1, ref ppSessionInfo, ref pCount);
			int num2 = Marshal.SizeOf(typeof(WTS_SESSION_INFO));
			long num3 = (int)ppSessionInfo;
			if (num != 0)
			{
				for (int i = 0; i < pCount; i++)
				{
					WTS_SESSION_INFO wTS_SESSION_INFO = (WTS_SESSION_INFO)Marshal.PtrToStructure((IntPtr)num3, typeof(WTS_SESSION_INFO));
					num3 += num2;
					if (wTS_SESSION_INFO.SessionID != 0 && wTS_SESSION_INFO.SessionID != 65536)
					{
						list.Add(new TerminalSessionData(wTS_SESSION_INFO.SessionID, wTS_SESSION_INFO.State, wTS_SESSION_INFO.pWinStationName));
					}
				}
				WTSFreeMemory(ppSessionInfo);
			}
		}
		finally
		{
			CloseServer(zero);
		}
		return list;
	}

	public static TerminalSessionInfo GetSessionInfo(string ServerName, int SessionId)
	{
		IntPtr zero = IntPtr.Zero;
		zero = OpenServer(ServerName);
		IntPtr ppBuffer = IntPtr.Zero;
		TerminalSessionInfo terminalSessionInfo = new TerminalSessionInfo();
		try
		{
			if (!WTSQuerySessionInformation(zero, SessionId, WTS_INFO_CLASS.ApplicationName, out ppBuffer, out var pBytesReturned))
			{
				return terminalSessionInfo;
			}
			string text = (terminalSessionInfo.ApplicationName = Marshal.PtrToStringAnsi(ppBuffer));
			if (!WTSQuerySessionInformation(zero, SessionId, WTS_INFO_CLASS.ClientAddress, out ppBuffer, out pBytesReturned))
			{
				return terminalSessionInfo;
			}
			WTS_CLIENT_ADDRESS wTS_CLIENT_ADDRESS = (terminalSessionInfo.ClientAddress = (WTS_CLIENT_ADDRESS)Marshal.PtrToStructure(ppBuffer, typeof(WTS_CLIENT_ADDRESS)));
			if (!WTSQuerySessionInformation(zero, SessionId, WTS_INFO_CLASS.ClientBuildNumber, out ppBuffer, out pBytesReturned))
			{
				return terminalSessionInfo;
			}
			int num = (terminalSessionInfo.ClientBuildNumber = Marshal.ReadInt32(ppBuffer));
			if (!WTSQuerySessionInformation(zero, SessionId, WTS_INFO_CLASS.ClientDirectory, out ppBuffer, out pBytesReturned))
			{
				return terminalSessionInfo;
			}
			text = (terminalSessionInfo.ClientDirectory = Marshal.PtrToStringAnsi(ppBuffer));
			if (!WTSQuerySessionInformation(zero, SessionId, WTS_INFO_CLASS.ClientDisplay, out ppBuffer, out pBytesReturned))
			{
				return terminalSessionInfo;
			}
			WTS_CLIENT_DISPLAY wTS_CLIENT_DISPLAY = (terminalSessionInfo.ClientDisplay = (WTS_CLIENT_DISPLAY)Marshal.PtrToStructure(ppBuffer, typeof(WTS_CLIENT_DISPLAY)));
			if (!WTSQuerySessionInformation(zero, SessionId, WTS_INFO_CLASS.ClientHardwareId, out ppBuffer, out pBytesReturned))
			{
				return terminalSessionInfo;
			}
			num = (terminalSessionInfo.ClientHardwareId = Marshal.ReadInt32(ppBuffer));
			WTSQuerySessionInformation(zero, SessionId, WTS_INFO_CLASS.ClientName, out ppBuffer, out pBytesReturned);
			text = (terminalSessionInfo.ClientName = Marshal.PtrToStringAnsi(ppBuffer));
			WTSQuerySessionInformation(zero, SessionId, WTS_INFO_CLASS.ClientProductId, out ppBuffer, out pBytesReturned);
			short num2 = (short)(terminalSessionInfo.ClientProductId = Marshal.ReadInt16(ppBuffer));
			WTSQuerySessionInformation(zero, SessionId, WTS_INFO_CLASS.ClientProtocolType, out ppBuffer, out pBytesReturned);
			num2 = (short)(terminalSessionInfo.ClientProtocolType = Marshal.ReadInt16(ppBuffer));
			WTSQuerySessionInformation(zero, SessionId, WTS_INFO_CLASS.ConnectState, out ppBuffer, out pBytesReturned);
			num = Marshal.ReadInt32(ppBuffer);
			terminalSessionInfo.ConnectState = (WTS_CONNECTSTATE_CLASS)Enum.ToObject(typeof(WTS_CONNECTSTATE_CLASS), num);
			WTSQuerySessionInformation(zero, SessionId, WTS_INFO_CLASS.DomainName, out ppBuffer, out pBytesReturned);
			text = (terminalSessionInfo.DomainName = Marshal.PtrToStringAnsi(ppBuffer));
			WTSQuerySessionInformation(zero, SessionId, WTS_INFO_CLASS.InitialProgram, out ppBuffer, out pBytesReturned);
			text = (terminalSessionInfo.InitialProgram = Marshal.PtrToStringAnsi(ppBuffer));
			WTSQuerySessionInformation(zero, SessionId, WTS_INFO_CLASS.OEMId, out ppBuffer, out pBytesReturned);
			text = (terminalSessionInfo.OEMId = Marshal.PtrToStringAnsi(ppBuffer));
			WTSQuerySessionInformation(zero, SessionId, WTS_INFO_CLASS.SessionId, out ppBuffer, out pBytesReturned);
			num = (terminalSessionInfo.SessionId = Marshal.ReadInt32(ppBuffer));
			WTSQuerySessionInformation(zero, SessionId, WTS_INFO_CLASS.UserName, out ppBuffer, out pBytesReturned);
			text = (terminalSessionInfo.UserName = Marshal.PtrToStringAnsi(ppBuffer));
			WTSQuerySessionInformation(zero, SessionId, WTS_INFO_CLASS.WinStationName, out ppBuffer, out pBytesReturned);
			text = (terminalSessionInfo.WinStationName = Marshal.PtrToStringAnsi(ppBuffer));
			WTSQuerySessionInformation(zero, SessionId, WTS_INFO_CLASS.WorkingDirectory, out ppBuffer, out pBytesReturned);
			text = (terminalSessionInfo.WorkingDirectory = Marshal.PtrToStringAnsi(ppBuffer));
		}
		finally
		{
			WTSFreeMemory(ppBuffer);
			ppBuffer = IntPtr.Zero;
			CloseServer(zero);
		}
		return terminalSessionInfo;
	}
}
