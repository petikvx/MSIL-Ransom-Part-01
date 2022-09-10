using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Security.Principal;
using System.Text;
using Microsoft.Win32;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

internal class ClusterRegistryConfigurationProvider : ConfigurationProvider
{
	private SafeHKey hKey;

	private RegistryExceptionHelper registryExceptionHelper;

	private string registryKey;

	[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
	internal ClusterRegistryConfigurationProvider(SafeHResource hResource, string key)
	{
		SafeHKey clusterResourceKey = SafeNativeMethods.GetClusterResourceKey(hResource, RegistryRights.ExecuteKey);
		if (clusterResourceKey.IsInvalid)
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			throw new WsatAdminException(WsatAdminErrorCode.REGISTRY_ACCESS, SR.GetString("CannotOpenClusterRegistry", lastWin32Error));
		}
		if (string.IsNullOrEmpty(key))
		{
			hKey = clusterResourceKey;
		}
		else
		{
			using (clusterResourceKey)
			{
				int lpdwDisposition;
				int num = SafeNativeMethods.ClusterRegCreateKey(clusterResourceKey, key, 0u, RegistryRights.FullControl, IntPtr.Zero, out hKey, out lpdwDisposition);
				if (num != 0L)
				{
					throw new WsatAdminException(WsatAdminErrorCode.REGISTRY_ACCESS, SR.GetString("CannotOpenClusterRegistry", num));
				}
			}
		}
		registryExceptionHelper = new RegistryExceptionHelper(key);
		registryKey = key;
		RegistryExceptionHelper.EnsureEndsWithSlash(ref registryKey);
	}

	private ClusterRegistryConfigurationProvider(SafeHKey key, string registryKey)
	{
		hKey = key;
		registryExceptionHelper = new RegistryExceptionHelper(registryKey);
		this.registryKey = registryKey;
		RegistryExceptionHelper.EnsureEndsWithSlash(ref registryKey);
	}

	public override void Dispose()
	{
		hKey = null;
		GC.SuppressFinalize(this);
	}

	internal override ConfigurationProvider OpenKey(string subKey)
	{
		SafeHKey phkResult;
		int lpdwDisposition;
		int num = SafeNativeMethods.ClusterRegCreateKey(hKey, subKey, 0u, RegistryRights.FullControl, IntPtr.Zero, out phkResult, out lpdwDisposition);
		if (num != 0L)
		{
			throw new WsatAdminException(WsatAdminErrorCode.REGISTRY_ACCESS, SR.GetString("CannotOpenClusterRegistry", num));
		}
		return new ClusterRegistryConfigurationProvider(phkResult, registryKey + subKey);
	}

	private byte[] QueryValue(string name, RegistryValueKind valueType)
	{
		if (hKey != null && !hKey.IsInvalid)
		{
			uint lpcbData = 0u;
			int num = SafeNativeMethods.ClusterRegQueryValue(hKey, name, out var lpdwValueType, null, ref lpcbData);
			Utilities.Log("ClusterRegQueryValue [" + name + "], returned [" + num + "]");
			if (num == 0L || num == 234L)
			{
				if (valueType != lpdwValueType)
				{
					return null;
				}
				byte[] array = new byte[lpcbData];
				num = SafeNativeMethods.ClusterRegQueryValue(hKey, name, out lpdwValueType, array, ref lpcbData);
				if (num == 0L)
				{
					if (valueType != lpdwValueType)
					{
						return null;
					}
					return array;
				}
			}
			return null;
		}
		return null;
	}

	private void WriteValue(string name, byte[] value, RegistryValueKind valueType)
	{
		if (hKey != null && !hKey.IsInvalid)
		{
			int num = SafeNativeMethods.ClusterRegSetValue(hKey, name, valueType, value, (uint)value.Length);
			if (num == 0L)
			{
				return;
			}
		}
		throw registryExceptionHelper.CreateRegistryWriteException(name, null);
	}

	internal override uint ReadUInt32(string name, uint defaultValue)
	{
		byte[] array = QueryValue(name, RegistryValueKind.DWord);
		if (array == null)
		{
			return defaultValue;
		}
		return BitConverter.ToUInt32(array, 0);
	}

	internal override void WriteUInt32(string name, uint value)
	{
		byte[] bytes = BitConverter.GetBytes(value);
		WriteValue(name, bytes, RegistryValueKind.DWord);
	}

	internal override string ReadString(string value, string defaultValue)
	{
		byte[] array = QueryValue(value, RegistryValueKind.String);
		if (array != null && array.Length >= 2)
		{
			return Encoding.Unicode.GetString(array, 0, array.Length - 2);
		}
		return defaultValue;
	}

	private byte[] GetByteArrayFromString(string s)
	{
		if (s == null)
		{
			s = string.Empty;
		}
		byte[] bytes = Encoding.Unicode.GetBytes(s);
		byte[] array = new byte[bytes.Length + 2];
		Array.Copy(bytes, array, bytes.Length);
		array[bytes.Length] = 0;
		array[bytes.Length + 1] = 0;
		return array;
	}

	internal override void WriteString(string name, string value)
	{
		byte[] byteArrayFromString = GetByteArrayFromString(value);
		WriteValue(name, byteArrayFromString, RegistryValueKind.String);
	}

	internal override string[] ReadMultiString(string value, string[] defaultValue)
	{
		byte[] array = QueryValue(value, RegistryValueKind.MultiString);
		if (array == null)
		{
			return defaultValue;
		}
		List<string> list = new List<string>(5);
		int index = 0;
		string stringFromMultiSz;
		while ((stringFromMultiSz = GetStringFromMultiSz(value, array, ref index)) != null)
		{
			list.Add(stringFromMultiSz);
		}
		return list.ToArray();
	}

	internal override void WriteMultiString(string name, string[] value)
	{
		int num = 0;
		foreach (string text in value)
		{
			if (!string.IsNullOrEmpty(text))
			{
				num += text.Length;
			}
		}
		byte[] array = new byte[(num + value.Length + 1) * 2];
		int num2 = 0;
		foreach (string s in value)
		{
			byte[] byteArrayFromString = GetByteArrayFromString(s);
			Array.Copy(byteArrayFromString, 0, array, num2, byteArrayFromString.Length);
			num2 += byteArrayFromString.Length;
		}
		array[num2++] = 0;
		array[num2++] = 0;
		WriteValue(name, array, RegistryValueKind.MultiString);
	}

	private string GetStringFromMultiSz(string value, byte[] buffer, ref int index)
	{
		int num = index;
		while (index < buffer.Length - 1 && BitConverter.ToChar(buffer, index) != 0)
		{
			index += 2;
		}
		if (num == index)
		{
			return null;
		}
		index += 2;
		return Encoding.Unicode.GetString(buffer, num, index - num - 2);
	}

	internal override void AdjustRegKeyPermission()
	{
		CommonSecurityDescriptor commonSecurityDescriptor = null;
		uint lpcbSecurityDescriptor = 256u;
		byte[] array;
		int num;
		do
		{
			array = new byte[lpcbSecurityDescriptor];
			num = SafeNativeMethods.ClusterRegGetKeySecurity(hKey, SecurityInfos.DiscretionaryAcl, array, ref lpcbSecurityDescriptor);
			if (num == 0L)
			{
				break;
			}
			if (num == 122L)
			{
				lpcbSecurityDescriptor *= 2;
				continue;
			}
			throw registryExceptionHelper.CreateRegistryWriteException(null);
		}
		while (lpcbSecurityDescriptor <= 40960);
		if (lpcbSecurityDescriptor > 40960)
		{
			throw registryExceptionHelper.CreateRegistryWriteException(null);
		}
		try
		{
			commonSecurityDescriptor = new CommonSecurityDescriptor(isContainer: false, isDS: false, array, 0);
			DiscretionaryAcl discretionaryAcl = commonSecurityDescriptor.DiscretionaryAcl;
			if (discretionaryAcl.Count == 1)
			{
				CommonAce commonAce = discretionaryAcl[0] as CommonAce;
				if (commonAce != null && commonAce.AceType == AceType.AccessAllowed && commonAce.SecurityIdentifier.IsWellKnown(WellKnownSidType.WorldSid))
				{
					discretionaryAcl.Purge(new SecurityIdentifier(WellKnownSidType.WorldSid, null));
				}
			}
			discretionaryAcl.AddAccess(AccessControlType.Allow, new SecurityIdentifier(WellKnownSidType.AuthenticatedUserSid, null), int.MinValue, InheritanceFlags.None, PropagationFlags.None);
			discretionaryAcl.AddAccess(AccessControlType.Allow, new SecurityIdentifier(WellKnownSidType.NetworkServiceSid, null), int.MinValue, InheritanceFlags.None, PropagationFlags.None);
		}
		catch (Exception ex)
		{
			if (Utilities.IsCriticalException(ex))
			{
				throw;
			}
			throw registryExceptionHelper.CreateRegistryWriteException(ex);
		}
		int binaryLength = commonSecurityDescriptor.BinaryLength;
		byte[] array2 = new byte[binaryLength];
		commonSecurityDescriptor.GetBinaryForm(array2, 0);
		num = SafeNativeMethods.ClusterRegSetKeySecurity(hKey, SecurityInfos.DiscretionaryAcl, array2);
		if (num != 0L)
		{
			throw registryExceptionHelper.CreateRegistryWriteException(null);
		}
	}
}
