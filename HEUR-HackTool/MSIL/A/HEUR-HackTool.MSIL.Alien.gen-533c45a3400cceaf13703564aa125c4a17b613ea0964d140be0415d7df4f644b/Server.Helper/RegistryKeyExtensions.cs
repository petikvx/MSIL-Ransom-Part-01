using System;
using Microsoft.Win32;

namespace Server.Helper;

public static class RegistryKeyExtensions
{
	public static string RegistryTypeToString(this RegistryValueKind valueKind, object valueData)
	{
		if (valueData == null)
		{
			return "(value not set)";
		}
		switch (valueKind)
		{
		case RegistryValueKind.String:
		case RegistryValueKind.ExpandString:
			return valueData.ToString();
		case RegistryValueKind.Binary:
			if (((byte[])valueData).Length == 0)
			{
				return "(zero-length binary value)";
			}
			return BitConverter.ToString((byte[])valueData).Replace("-", " ").ToLower();
		case RegistryValueKind.DWord:
			return string.Format("0x{0} ({1})", ((uint)(int)valueData).ToString("x8"), ((uint)(int)valueData).ToString());
		case RegistryValueKind.MultiString:
			return string.Join(" ", (string[])valueData);
		default:
			return string.Empty;
		case RegistryValueKind.QWord:
			return string.Format("0x{0} ({1})", ((ulong)(long)valueData).ToString("x8"), ((ulong)(long)valueData).ToString());
		}
	}

	public static RegistryKey OpenReadonlySubKeySafe(this RegistryKey key, string name)
	{
		try
		{
			return key.OpenSubKey(name, writable: false);
		}
		catch
		{
			return null;
		}
	}

	public static RegistryKey OpenWritableSubKeySafe(this RegistryKey key, string name)
	{
		try
		{
			return key.OpenSubKey(name, writable: true);
		}
		catch
		{
			return null;
		}
	}

	public static string RegistryTypeToString(this RegistryValueKind valueKind)
	{
		return valueKind switch
		{
			RegistryValueKind.Unknown => "(Unknown)", 
			RegistryValueKind.String => "REG_SZ", 
			RegistryValueKind.ExpandString => "REG_EXPAND_SZ", 
			RegistryValueKind.Binary => "REG_BINARY", 
			RegistryValueKind.DWord => "REG_DWORD", 
			RegistryValueKind.MultiString => "REG_MULTI_SZ", 
			RegistryValueKind.QWord => "REG_QWORD", 
			_ => "REG_NONE", 
		};
	}
}
