using System;
using System.Net;
using Microsoft.ServiceHub.HostLib;

namespace C33A2544C;

internal class B3FA41FD6
{
	[LoaderOptimization(LoaderOptimization.MultiDomain)]
	private static int E45758EA6(string[] E02CA8C11)
	{
		if (ServicePointManager.SecurityProtocol != 0)
		{
			ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12;
		}
		return Program.MainAsync(E02CA8C11).GetAwaiter().GetResult();
	}
}
