using System;
using System.Collections.Generic;
using System.Security;
using System.Security.Permissions;
using Alphaleonis.Win32.Network;

namespace Alphaleonis.Win32.Filesystem;

[Serializable]
[SecurityCritical]
[SecurityPermission(SecurityAction.InheritanceDemand, UnmanagedCode = true)]
public sealed class DeviceInfo
{
	public Guid BaseContainerId { get; internal set; }

	public string DeviceClass { get; internal set; }

	public Guid ClassGuid { get; internal set; }

	public string CompatibleIds { get; internal set; }

	public string DeviceDescription { get; internal set; }

	public string DevicePath { get; internal set; }

	public string Driver { get; internal set; }

	public string EnumeratorName { get; internal set; }

	public string FriendlyName { get; internal set; }

	public string HardwareId { get; internal set; }

	public string HostName { get; internal set; }

	public string InstanceId { get; internal set; }

	public string LocationInformation { get; internal set; }

	public string LocationPaths { get; internal set; }

	public string Manufacturer { get; internal set; }

	public string PhysicalDeviceObjectName { get; internal set; }

	public string Service { get; internal set; }

	[SecurityCritical]
	public DeviceInfo()
	{
		HostName = Host.GetUncName();
	}

	[SecurityCritical]
	public DeviceInfo(string host)
	{
		HostName = Host.GetUncName(host).Replace(Path.UncPrefix, string.Empty);
	}

	[SecurityCritical]
	public IEnumerable<DeviceInfo> EnumerateDevices(DeviceGuid deviceGuid)
	{
		return Device.EnumerateDevicesCore(HostName, deviceGuid, getAllProperties: true);
	}
}
