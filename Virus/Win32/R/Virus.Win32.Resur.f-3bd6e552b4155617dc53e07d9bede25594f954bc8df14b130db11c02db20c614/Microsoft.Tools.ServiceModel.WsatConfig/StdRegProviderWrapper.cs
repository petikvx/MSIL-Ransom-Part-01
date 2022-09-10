using System;
using System.Management;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

internal class StdRegProviderWrapper : IDisposable
{
	private static class StdRegProvMethods
	{
		public const string GetDwordValue = "GetDWORDValue";

		public const string GetStringValue = "GetStringValue";

		public const string GetMultiStringValue = "GetMultiStringValue";

		public const string SetDwordValue = "SetDWORDValue";

		public const string SetStringValue = "SetStringValue";

		public const string SetMultiStringValue = "SetMultiStringValue";

		public const string EnumKey = "EnumKey";

		public const string CreateRegistryKey = "CreateKey";

		public const string CheckAccess = "CheckAccess";
	}

	private static class InputParameters
	{
		public const string DefKey = "hDefKey";

		public const string SubKeyName = "sSubKeyName";

		public const string ValueName = "sValueName";

		public const string AccessPermission = "uRequired";

		public const string DwordValueKey = "uValue";

		public const string StringValueKey = "sValue";
	}

	private static class OutputParameters
	{
		public const string IsAccessGranted = "bGranted";

		public const string SubKeyNames = "sNames";

		public const string ReturnValue = "ReturnValue";
	}

	private const uint ERROR_ACCESS_DENIED = 5u;

	private const uint KEY_QUERY_VALUE = 1u;

	private const uint KEY_SET_VALUE = 2u;

	private ManagementClass regClassInstance;

	private string subKey;

	private uint hiveValue;

	private bool ensuredSubKeyExists;

	private bool ensuredReadAccess;

	private bool ensuredWriteAccess;

	private RegistryExceptionHelper registryExceptionHelper;

	public StdRegProviderWrapper(RegistryHive registryHive, string subKey, string machineName)
	{
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00dc: Expected O, but got Unknown
		switch (registryHive)
		{
		default:
			throw new ArgumentException("remoteHive");
		case RegistryHive.ClassesRoot:
			hiveValue = 2147483648u;
			break;
		case RegistryHive.CurrentUser:
			hiveValue = 2147483649u;
			break;
		case RegistryHive.LocalMachine:
			hiveValue = 2147483650u;
			break;
		}
		registryExceptionHelper = new RegistryExceptionHelper(machineName, registryHive, subKey);
		try
		{
			ConnectionOptions val = null;
			if (Utilities.IsLocalMachineName(machineName))
			{
				machineName = "localhost";
			}
			else
			{
				val = new ConnectionOptions();
				val.set_Authentication((AuthenticationLevel)6);
				val.set_Impersonation((ImpersonationLevel)3);
			}
			ManagementScope val2 = new ManagementScope("\\\\" + machineName + "\\root\\DEFAULT", val);
			ManagementPath val3 = new ManagementPath("StdRegProv");
			ObjectGetOptions val4 = new ObjectGetOptions(new ManagementNamedValueCollection(), TimeSpan.FromSeconds(15.0), false);
			regClassInstance = new ManagementClass(val2, val3, val4);
			this.subKey = subKey;
		}
		catch (ManagementException val5)
		{
			ManagementException innerException = val5;
			throw registryExceptionHelper.CreateRegistryAccessException((Exception)(object)innerException);
		}
		catch (COMException innerException2)
		{
			throw registryExceptionHelper.CreateRegistryAccessException(innerException2);
		}
	}

	private StdRegProviderWrapper(uint hiveValue, string subKey, ManagementClass regClassInstance)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		this.hiveValue = hiveValue;
		this.subKey = subKey;
		registryExceptionHelper = new RegistryExceptionHelper(subKey);
		this.regClassInstance = new ManagementClass(((ManagementObject)regClassInstance).get_Path(), ((ManagementObject)regClassInstance).get_Options());
	}

	internal StdRegProviderWrapper OpenKey(string subKey)
	{
		string str = this.subKey;
		RegistryExceptionHelper.EnsureEndsWithSlash(ref str);
		str += subKey;
		return new StdRegProviderWrapper(hiveValue, str, regClassInstance);
	}

	internal uint ReadUInt32(string name, uint defaultValue)
	{
		return (uint)DoReadData(name, "uValue", defaultValue, "GetDWORDValue");
	}

	internal string ReadString(string name, string defaultValue)
	{
		return (string)DoReadData(name, "sValue", defaultValue, "GetStringValue");
	}

	internal string[] ReadMultiString(string name, string[] defaultValue)
	{
		return (string[])DoReadData(name, "sValue", defaultValue, "GetMultiStringValue");
	}

	internal void WriteUInt32(string name, uint value)
	{
		DoWriteData(name, "uValue", value, "SetDWORDValue");
	}

	internal void WriteString(string name, string value)
	{
		DoWriteData(name, "sValue", value, "SetStringValue");
	}

	internal void WriteMultiString(string name, string[] value)
	{
		DoWriteData(name, "sValue", value, "SetMultiStringValue");
	}

	public string[] GetSubKeyNames()
	{
		EnsureReadAccess();
		try
		{
			ManagementBaseObject methodParameters = ((ManagementObject)regClassInstance).GetMethodParameters("EnumKey");
			methodParameters.set_Item("hDefKey", (object)hiveValue);
			methodParameters.set_Item("sSubKeyName", (object)subKey);
			ManagementBaseObject val = ((ManagementObject)regClassInstance).InvokeMethod("EnumKey", methodParameters, (InvokeMethodOptions)null);
			if ((uint)val.get_Item("ReturnValue") == 0)
			{
				return (string[])val.get_Item("sNames");
			}
			return new string[0];
		}
		catch (Exception ex)
		{
			if (Utilities.IsCriticalException(ex))
			{
				throw;
			}
			throw registryExceptionHelper.CreateRegistryAccessException(ex);
		}
	}

	private object DoReadData(string name, string valueKey, object defaultValue, string readMethod)
	{
		EnsureReadAccess();
		try
		{
			ManagementBaseObject methodParameters = ((ManagementObject)regClassInstance).GetMethodParameters(readMethod);
			methodParameters.set_Item("hDefKey", (object)hiveValue);
			methodParameters.set_Item("sSubKeyName", (object)subKey);
			methodParameters.set_Item("sValueName", (object)name);
			ManagementBaseObject val = ((ManagementObject)regClassInstance).InvokeMethod(readMethod, methodParameters, (InvokeMethodOptions)null);
			if ((uint)val.get_Item("ReturnValue") == 0)
			{
				return val.get_Item(valueKey);
			}
			return defaultValue;
		}
		catch (Exception ex)
		{
			if (Utilities.IsCriticalException(ex))
			{
				throw;
			}
			throw registryExceptionHelper.CreateRegistryAccessException(name, ex);
		}
	}

	private void DoWriteData(string name, string valueKey, object value, string writeMethod)
	{
		EnsureSubKeyExists();
		EnsureWriteAccess();
		try
		{
			ManagementBaseObject methodParameters = ((ManagementObject)regClassInstance).GetMethodParameters(writeMethod);
			methodParameters.set_Item("hDefKey", (object)hiveValue);
			methodParameters.set_Item("sSubKeyName", (object)subKey);
			methodParameters.set_Item("sValueName", (object)name);
			methodParameters.set_Item(valueKey, value);
			ManagementBaseObject val = ((ManagementObject)regClassInstance).InvokeMethod(writeMethod, methodParameters, (InvokeMethodOptions)null);
			if ((uint)val.get_Item("ReturnValue") != 0)
			{
				string str = subKey;
				RegistryExceptionHelper.EnsureEndsWithSlash(ref str);
				str += name;
				registryExceptionHelper.CreateRegistryWriteException(str, null);
			}
		}
		catch (Exception ex)
		{
			if (Utilities.IsCriticalException(ex))
			{
				throw;
			}
			throw registryExceptionHelper.CreateRegistryAccessException(name, ex);
		}
	}

	private void EnsureSubKeyExists()
	{
		try
		{
			if (!ensuredSubKeyExists)
			{
				ManagementBaseObject methodParameters = ((ManagementObject)regClassInstance).GetMethodParameters("CreateKey");
				methodParameters.set_Item("hDefKey", (object)hiveValue);
				methodParameters.set_Item("sSubKeyName", (object)subKey);
				ManagementBaseObject val = ((ManagementObject)regClassInstance).InvokeMethod("CreateKey", methodParameters, (InvokeMethodOptions)null);
				uint num = (uint)val.get_Item("ReturnValue");
				if (num != 0)
				{
					throw registryExceptionHelper.CreateRegistryAccessException(num);
				}
				ensuredSubKeyExists = true;
			}
		}
		catch (Exception ex)
		{
			if (Utilities.IsCriticalException(ex))
			{
				throw;
			}
			throw registryExceptionHelper.CreateRegistryAccessException(ex);
		}
	}

	private bool CheckRegistryAccess(uint accessPermission, out bool isAccessGranted)
	{
		ManagementBaseObject val = null;
		try
		{
			val = ((ManagementObject)regClassInstance).GetMethodParameters("CheckAccess");
		}
		catch (Exception ex)
		{
			if (Utilities.IsCriticalException(ex))
			{
				throw;
			}
			throw registryExceptionHelper.CreateRegistryAccessException(ex);
		}
		val.set_Item("hDefKey", (object)hiveValue);
		val.set_Item("sSubKeyName", (object)subKey);
		val.set_Item("uRequired", (object)accessPermission);
		ManagementBaseObject val2 = ((ManagementObject)regClassInstance).InvokeMethod("CheckAccess", val, (InvokeMethodOptions)null);
		uint num = (uint)val2.get_Item("ReturnValue");
		isAccessGranted = (bool)val2.get_Item("bGranted");
		if (num != 0)
		{
			return num == 5;
		}
		return true;
	}

	private void EnsureReadAccess()
	{
		if (ensuredReadAccess)
		{
			return;
		}
		bool isAccessGranted = false;
		if (CheckRegistryAccess(1u, out isAccessGranted))
		{
			if (!isAccessGranted)
			{
				throw registryExceptionHelper.CreateRegistryAccessException(null);
			}
			ensuredReadAccess = true;
		}
	}

	private void EnsureWriteAccess()
	{
		if (ensuredWriteAccess)
		{
			return;
		}
		bool isAccessGranted = false;
		if (CheckRegistryAccess(3u, out isAccessGranted))
		{
			if (!isAccessGranted)
			{
				throw registryExceptionHelper.CreateRegistryWriteException(null);
			}
			ensuredWriteAccess = true;
		}
	}

	internal void AdjustRegKeyPermission()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\WSAT\\3.0\\", RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl);
			if (registryKey != null)
			{
				using (registryKey)
				{
					RegistryAccessRule rule = new RegistryAccessRule(new SecurityIdentifier(WellKnownSidType.NetworkServiceSid, null), RegistryRights.ExecuteKey, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow);
					RegistryAccessRule rule2 = new RegistryAccessRule(new SecurityIdentifier(WellKnownSidType.AuthenticatedUserSid, null), RegistryRights.ExecuteKey, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow);
					RegistrySecurity accessControl = registryKey.GetAccessControl();
					accessControl.AddAccessRule(rule);
					accessControl.AddAccessRule(rule2);
					registryKey.SetAccessControl(accessControl);
					return;
				}
			}
		}
		catch (SecurityException innerException)
		{
			throw registryExceptionHelper.CreateRegistryWriteException(innerException);
		}
		catch (ObjectDisposedException innerException2)
		{
			throw registryExceptionHelper.CreateRegistryWriteException(innerException2);
		}
		catch (ArgumentNullException innerException3)
		{
			throw registryExceptionHelper.CreateRegistryWriteException(innerException3);
		}
		catch (ArgumentException innerException4)
		{
			throw registryExceptionHelper.CreateRegistryWriteException(innerException4);
		}
		catch (UnauthorizedAccessException innerException5)
		{
			throw registryExceptionHelper.CreateRegistryWriteException(innerException5);
		}
	}

	public void Dispose()
	{
		if (regClassInstance != null)
		{
			((ManagementObject)regClassInstance).Dispose();
			regClassInstance = null;
		}
	}
}
