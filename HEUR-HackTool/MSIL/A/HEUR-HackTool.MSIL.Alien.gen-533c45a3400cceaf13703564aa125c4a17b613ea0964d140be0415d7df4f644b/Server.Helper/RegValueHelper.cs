using System;
using Microsoft.Win32;

namespace Server.Helper;

public class RegValueHelper
{
	private static string DEFAULT_REG_VALUE = "(Default)";

	public static bool IsDefaultValue(string valueName)
	{
		return string.IsNullOrEmpty(valueName);
	}

	public static string GetName(string valueName)
	{
		if (!IsDefaultValue(valueName))
		{
			return valueName;
		}
		return DEFAULT_REG_VALUE;
	}

	public static string RegistryValueToString(RegistrySeeker.RegValueData value)
	{
		switch (value.Kind)
		{
		case RegistryValueKind.String:
		case RegistryValueKind.ExpandString:
			return ByteConverter.ToString(value.Data);
		case RegistryValueKind.Binary:
			if (value.Data.Length == 0)
			{
				return "(zero-length binary value)";
			}
			return BitConverter.ToString(value.Data).Replace("-", " ").ToLower();
		case RegistryValueKind.DWord:
		{
			uint num2 = ByteConverter.ToUInt32(value.Data);
			return $"0x{num2:x8} ({num2})";
		}
		case RegistryValueKind.MultiString:
			return string.Join(" ", ByteConverter.ToStringArray(value.Data));
		default:
			return string.Empty;
		case RegistryValueKind.QWord:
		{
			ulong num = ByteConverter.ToUInt64(value.Data);
			return $"0x{num:x8} ({num})";
		}
		}
	}
}
