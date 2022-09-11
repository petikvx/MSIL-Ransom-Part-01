using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MySqlX.Failover;

namespace ns10;

internal abstract class Class105
{
	[CompilerGenerated]
	private List<XServer> list_0;

	protected internal XServer xserver_0;

	protected internal List<XServer> Hosts
	{
		[CompilerGenerated]
		get
		{
			return list_0;
		}
		[CompilerGenerated]
		set
		{
			list_0 = value;
		}
	}

	protected internal XServer ActiveHost
	{
		get
		{
			if (Hosts == null)
			{
				return null;
			}
			if (xserver_0 != null)
			{
				return xserver_0;
			}
			foreach (XServer host in Hosts)
			{
				if (host.IsActive)
				{
					return host;
				}
			}
			return null;
		}
	}

	internal Class105(List<XServer> list_1)
	{
		Hosts = list_1;
		vmethod_0();
	}

	protected internal abstract void vmethod_0();

	protected internal abstract XServer vmethod_1();
}
