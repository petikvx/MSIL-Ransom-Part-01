using System.Net;
using System.Runtime.CompilerServices;

public class GClass55
{
	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private IPAddress ipaddress_0;

	[CompilerGenerated]
	private ushort ushort_0;

	public string Hostname
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		set
		{
			string_0 = value;
		}
	}

	public IPAddress IpAddress
	{
		[CompilerGenerated]
		get
		{
			return ipaddress_0;
		}
		[CompilerGenerated]
		set
		{
			ipaddress_0 = value;
		}
	}

	public ushort Port
	{
		[CompilerGenerated]
		get
		{
			return ushort_0;
		}
		[CompilerGenerated]
		set
		{
			ushort_0 = value;
		}
	}

	public override string ToString()
	{
		return Hostname + ":" + Port;
	}
}