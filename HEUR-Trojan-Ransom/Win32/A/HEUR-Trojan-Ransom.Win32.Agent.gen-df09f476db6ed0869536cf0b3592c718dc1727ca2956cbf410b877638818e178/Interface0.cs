using System;
using System.Net;
using System.Runtime.CompilerServices;

internal interface Interface0
{
	event EventHandler<GEventArgs0> DeviceFound;

	event EventHandler<GEventArgs0> DeviceLost;

	void imethod_0();

	void imethod_1(IPAddress ipaddress_0, byte[] byte_0, IPEndPoint ipendPoint_0);

	[SpecialName]
	DateTime imethod_2();
}
