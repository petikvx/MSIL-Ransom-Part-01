using System;
using System.Net;
using System.Runtime.CompilerServices;

internal class Class44 : Class34
{
	private IPAddress ipaddress_0;

	[SpecialName]
	public IPAddress method_1()
	{
		return ipaddress_0;
	}

	public Class44(string string_0)
	{
		Class51.smethod_0();
		base._002Ector(null);
		ipaddress_0 = IPAddress.Parse(string_0);
	}

	public override WebRequest vmethod_0(out byte[] byte_0)
	{
		throw new NotImplementedException();
	}
}
