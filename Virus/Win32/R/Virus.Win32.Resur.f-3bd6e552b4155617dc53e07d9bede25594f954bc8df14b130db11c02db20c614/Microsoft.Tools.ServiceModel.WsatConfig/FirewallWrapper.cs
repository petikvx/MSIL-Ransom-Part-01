using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

internal class FirewallWrapper
{
	private const string FwMgrClassId = "{304CE942-6E39-40D8-943A-B913C40C9CD4}";

	private const string FwOpenPortClassId = "{0CA545C6-37AD-4A6C-BF92-9F7610067EF5}";

	private INetFirewallMgr manager;

	private INetFirewallOpenPortsCollection openPorts;

	private INetFirewallPolicy localPolicy;

	private INetFirewallProfile currentProfile;

	[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
	internal FirewallWrapper()
	{
		try
		{
			manager = (INetFirewallMgr)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("{304CE942-6E39-40D8-943A-B913C40C9CD4}")));
			localPolicy = manager.LocalPolicy;
			currentProfile = localPolicy.CurrentProfile;
			openPorts = currentProfile.GloballyOpenPorts;
		}
		catch (COMException)
		{
			manager = null;
			localPolicy = null;
			currentProfile = null;
			openPorts = null;
		}
		catch (MethodAccessException innerException)
		{
			throw new WsatAdminException(WsatAdminErrorCode.FIREWALL_ACCESS_DENIED, SR.GetString("FirewallAccessDenied"), innerException);
		}
	}

	private bool IsHttpsPortOpened(int port)
	{
		foreach (INetFirewallOpenPort openPort in openPorts)
		{
			if (openPort.Port == port)
			{
				return true;
			}
		}
		return false;
	}

	internal void AddHttpsPort(int portToAdd)
	{
		if (portToAdd >= 0 && openPorts != null && !IsHttpsPortOpened(portToAdd))
		{
			try
			{
				INetFirewallOpenPort netFirewallOpenPort = (INetFirewallOpenPort)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("{0CA545C6-37AD-4A6C-BF92-9F7610067EF5}")));
				netFirewallOpenPort.Enabled = true;
				netFirewallOpenPort.IPVersion = NetFirewallIPVersion.Any;
				netFirewallOpenPort.Name = SR.GetString("HTTPSPortName");
				netFirewallOpenPort.Port = portToAdd;
				netFirewallOpenPort.Protocol = NetFirewallIPProtocol.Tcp;
				netFirewallOpenPort.Scope = NetFirewallScope.All;
				openPorts.Add(netFirewallOpenPort);
			}
			catch (COMException ex)
			{
				throw new WsatAdminException(WsatAdminErrorCode.UNEXPECTED_FIREWALL_CONFIG_ERROR, SR.GetString("UnexpectedFirewallError", ex.Message), ex);
			}
			catch (MethodAccessException innerException)
			{
				throw new WsatAdminException(WsatAdminErrorCode.FIREWALL_ACCESS_DENIED, SR.GetString("FirewallAccessDenied"), innerException);
			}
			catch (UnauthorizedAccessException innerException2)
			{
				throw new WsatAdminException(WsatAdminErrorCode.FIREWALL_ACCESS_DENIED, SR.GetString("FirewallAccessDenied"), innerException2);
			}
		}
	}

	internal void RemoveHttpsPort(int portToRemove)
	{
		if (portToRemove < 0 || openPorts == null)
		{
			return;
		}
		List<INetFirewallOpenPort> list = new List<INetFirewallOpenPort>();
		foreach (INetFirewallOpenPort openPort in openPorts)
		{
			if (openPort.Port == portToRemove && Utilities.SafeCompare(openPort.Name, SR.GetString("HTTPSPortName")))
			{
				list.Add(openPort);
			}
		}
		bool flag = false;
		foreach (INetFirewallOpenPort item in list)
		{
			try
			{
				openPorts.Remove(item.Port, item.Protocol);
			}
			catch (UnauthorizedAccessException)
			{
				flag = true;
			}
		}
		if (flag)
		{
			throw new WsatAdminException(WsatAdminErrorCode.FIREWALL_ACCESS_DENIED, SR.GetString("FirewallAccessDenied"));
		}
	}
}
