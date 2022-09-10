using System;
using System.Runtime.InteropServices;
using System.Security;

namespace MS.Internal.FontCache.Service;

[SecurityCritical(SecurityCriticalScope.Everything)]
internal static class FontCacheAdapter
{
	private static int _instanceCapacity = 1000;

	private static int _maxDataSize = 256;

	private static int _maxMessageSize = 256;

	internal static int GetServerInstanceCapacity()
	{
		return _instanceCapacity;
	}

	internal static int GetMaxDataSize()
	{
		return _maxDataSize;
	}

	internal static int GetMaxMessageSize()
	{
		return _maxMessageSize;
	}

	internal static bool ShouldAccept(LPCServer server, LPCMessage msg)
	{
		return true;
	}

	internal unsafe static LPCMessage ProcessRequestData(LPCServer server, LPCMessage msg, ClientInfo clientInfo)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		byte[] data = msg.get_Data();
		if (data.Length < 4)
		{
			return null;
		}
		switch (Marshal.ReadInt32(data, 0))
		{
		case 1:
			try
			{
				try
				{
					fixed (byte* ptr = &data[0])
					{
						CheckedPointer val = default(CheckedPointer);
						((CheckedPointer)(ref val))._002Ector((void*)ptr, data.Length);
						val += 4;
						ServiceCacheManager.HandleMissReport(val);
					}
				}
				finally
				{
				}
			}
			catch (ArgumentException)
			{
			}
			return null;
		case 0:
		{
			string cacheName = ServiceCacheManager.GetCacheName();
			byte[] array = Util2.StringToByteArray(cacheName);
			return new LPCMessage(array);
		}
		case 2:
			if (msg.get_ClientProcessId() == GetCurrentProcessId())
			{
				server.SetLastMessage();
				return null;
			}
			break;
		}
		return null;
	}

	internal static void SendShutdownMessage(Protocol protocol, ConnectionInstance conn, out int errorCode)
	{
		byte[] array = new byte[4];
		Marshal.WriteInt32(array, 0, 2);
		protocol.TrySendRequest(conn, array, 0, array.Length, (byte[])null, 0, 0, -1, ref errorCode);
		if (errorCode == 0)
		{
		}
	}

	internal static SecurityDescriptor GetFontCacheSecurityDescriptor()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		int num = 0;
		ExplicitAccessList val = new ExplicitAccessList(1);
		val.AddAccessAllowedAce(0, (AccessPermissions)1, (AceFlags)0, (Sid)new WellKnownSid((WellKnownSidType)1), ref num);
		if (num != 0)
		{
			return null;
		}
		return new SecurityDescriptor(val);
	}

	[DllImport("kernel32.dll")]
	private static extern int GetCurrentProcessId();
}
