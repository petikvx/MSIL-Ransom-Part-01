using System;

namespace Alphaleonis.Win32.Network;

[Flags]
public enum NetworkConnectivityLevels
{
	None = 0,
	Connected = 1,
	Disconnected = 2,
	All = 3
}
