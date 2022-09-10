using System;
using Microsoft.Win32;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

internal class RegistryExceptionHelper
{
	private string registryKey;

	public RegistryExceptionHelper(string registryKey)
	{
		this.registryKey = registryKey;
		EnsureEndsWithSlash(ref this.registryKey);
	}

	public RegistryExceptionHelper(string machineName, RegistryHive registryHive, string registryKeyRelativeToHive)
		: this(GetRegistryKeyBase(machineName, registryHive) + registryKeyRelativeToHive)
	{
	}

	public static void EnsureEndsWithSlash(ref string str)
	{
		if (!string.IsNullOrEmpty(str) && !str.EndsWith("\\", StringComparison.OrdinalIgnoreCase))
		{
			str += '\\';
		}
	}

	private static string GetRegistryKeyBase(string machineName, RegistryHive registryHive)
	{
		string str = (Utilities.IsLocalMachineName(machineName) ? string.Empty : SR.GetString("RemoteRegistryFormat", machineName));
		switch (registryHive)
		{
		case RegistryHive.ClassesRoot:
			str += Registry.ClassesRoot.Name;
			break;
		case RegistryHive.CurrentUser:
			str += Registry.CurrentUser.Name;
			break;
		case RegistryHive.LocalMachine:
			str += Registry.LocalMachine.Name;
			break;
		}
		EnsureEndsWithSlash(ref str);
		return str;
	}

	public WsatAdminException CreateRegistryAccessException(int errorCode)
	{
		return CreateRegistryAccessException((uint)errorCode);
	}

	public WsatAdminException CreateRegistryAccessException(uint errorCode)
	{
		return new WsatAdminException(WsatAdminErrorCode.REGISTRY_ACCESS, SR.GetString("ErrorRegistryAccess", registryKey, errorCode));
	}

	public WsatAdminException CreateRegistryAccessException(Exception innerException)
	{
		return DoCreateRegistryAccessException(registryKey, innerException);
	}

	public WsatAdminException CreateRegistryAccessException(string subRegistryKey, Exception innerException)
	{
		return DoCreateRegistryAccessException(registryKey + subRegistryKey, innerException);
	}

	private static WsatAdminException DoCreateRegistryAccessException(string regKey, Exception innerException)
	{
		if (innerException == null)
		{
			return new WsatAdminException(WsatAdminErrorCode.REGISTRY_ACCESS, SR.GetString("ErrorRegistryAccessNoErrorCode", regKey));
		}
		return new WsatAdminException(WsatAdminErrorCode.REGISTRY_ACCESS, SR.GetString("ErrorRegistryAccessNoErrorCode", regKey), innerException);
	}

	public WsatAdminException CreateRegistryWriteException(Exception innerException)
	{
		return DoCreateRegistryWriteException(registryKey, innerException);
	}

	public WsatAdminException CreateRegistryWriteException(string subRegistryKey, Exception innerException)
	{
		return DoCreateRegistryWriteException(registryKey + subRegistryKey, innerException);
	}

	private static WsatAdminException DoCreateRegistryWriteException(string regKey, Exception innerException)
	{
		if (innerException == null)
		{
			return new WsatAdminException(WsatAdminErrorCode.REGISTRY_WRITE, SR.GetString("ErrorRegistryWrite", regKey));
		}
		return new WsatAdminException(WsatAdminErrorCode.REGISTRY_WRITE, SR.GetString("ErrorRegistryWrite", regKey), innerException);
	}
}
