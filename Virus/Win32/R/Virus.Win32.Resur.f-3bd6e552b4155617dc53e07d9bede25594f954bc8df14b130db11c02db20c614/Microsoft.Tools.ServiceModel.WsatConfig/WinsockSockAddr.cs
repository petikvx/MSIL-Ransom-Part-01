using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

internal class WinsockSockAddr : IDisposable
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct SOCKADDR_IN
	{
		internal short family;

		internal short port;

		internal byte addr00;

		internal byte addr01;

		internal byte addr02;

		internal byte addr03;

		internal int nothing;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct SOCKADDR_IN6
	{
		internal short family;

		internal short port;

		internal int flowInfo;

		internal byte addr00;

		internal byte addr01;

		internal byte addr02;

		internal byte addr03;

		internal byte addr04;

		internal byte addr05;

		internal byte addr06;

		internal byte addr07;

		internal byte addr08;

		internal byte addr09;

		internal byte addr10;

		internal byte addr11;

		internal byte addr12;

		internal byte addr13;

		internal byte addr14;

		internal byte addr15;

		public int scopeID;
	}

	private const short AF_INET = 2;

	private const short AF_INET6 = 23;

	private object address;

	private GCHandle pinnedAddress;

	private IntPtr pAddress;

	internal IntPtr PinnedSockAddr => pAddress;

	internal WinsockSockAddr(IPAddress source, short port)
	{
		pAddress = IntPtr.Zero;
		if (source.AddressFamily == AddressFamily.InterNetwork)
		{
			byte[] addressBytes = source.GetAddressBytes();
			SOCKADDR_IN sOCKADDR_IN = default(SOCKADDR_IN);
			sOCKADDR_IN.family = 2;
			sOCKADDR_IN.port = IPAddress.HostToNetworkOrder(port);
			sOCKADDR_IN.addr00 = addressBytes[0];
			sOCKADDR_IN.addr01 = addressBytes[1];
			sOCKADDR_IN.addr02 = addressBytes[2];
			sOCKADDR_IN.addr03 = addressBytes[3];
			sOCKADDR_IN.nothing = 0;
			address = sOCKADDR_IN;
		}
		else if (source.AddressFamily == AddressFamily.InterNetworkV6)
		{
			byte[] addressBytes2 = source.GetAddressBytes();
			SOCKADDR_IN6 sOCKADDR_IN2 = default(SOCKADDR_IN6);
			sOCKADDR_IN2.family = 23;
			sOCKADDR_IN2.port = IPAddress.HostToNetworkOrder(port);
			sOCKADDR_IN2.flowInfo = 0;
			sOCKADDR_IN2.addr00 = addressBytes2[0];
			sOCKADDR_IN2.addr01 = addressBytes2[1];
			sOCKADDR_IN2.addr02 = addressBytes2[2];
			sOCKADDR_IN2.addr03 = addressBytes2[3];
			sOCKADDR_IN2.addr04 = addressBytes2[4];
			sOCKADDR_IN2.addr05 = addressBytes2[5];
			sOCKADDR_IN2.addr06 = addressBytes2[6];
			sOCKADDR_IN2.addr07 = addressBytes2[7];
			sOCKADDR_IN2.addr08 = addressBytes2[8];
			sOCKADDR_IN2.addr09 = addressBytes2[9];
			sOCKADDR_IN2.addr10 = addressBytes2[10];
			sOCKADDR_IN2.addr11 = addressBytes2[11];
			sOCKADDR_IN2.addr12 = addressBytes2[12];
			sOCKADDR_IN2.addr13 = addressBytes2[13];
			sOCKADDR_IN2.addr14 = addressBytes2[14];
			sOCKADDR_IN2.addr15 = addressBytes2[15];
			sOCKADDR_IN2.scopeID = (int)source.ScopeId;
			address = sOCKADDR_IN2;
		}
		pinnedAddress = GCHandle.Alloc(address, GCHandleType.Pinned);
		pAddress = pinnedAddress.AddrOfPinnedObject();
	}

	public void Dispose()
	{
		Close();
		GC.SuppressFinalize(this);
	}

	private void Close()
	{
		if (pinnedAddress.IsAllocated)
		{
			pinnedAddress.Free();
		}
		address = null;
		pAddress = IntPtr.Zero;
	}

	~WinsockSockAddr()
	{
		Close();
	}
}
