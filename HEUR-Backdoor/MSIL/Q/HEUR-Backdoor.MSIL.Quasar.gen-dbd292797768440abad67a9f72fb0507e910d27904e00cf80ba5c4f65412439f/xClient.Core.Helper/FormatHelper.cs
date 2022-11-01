using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;

namespace xClient.Core.Helper;

public static class FormatHelper
{
	public static string FormatMacAddress(string macAddress)
	{
		if (macAddress.Length == 12)
		{
			return Regex.Replace(macAddress, "(.{2})(.{2})(.{2})(.{2})(.{2})(.{2})", "$1:$2:$3:$4:$5:$6");
		}
		return "00:00:00:00:00:00";
	}

	public static string DriveTypeName(DriveType type)
	{
		return type switch
		{
			DriveType.Removable => "Removable Drive", 
			DriveType.Fixed => "Local Disk", 
			DriveType.Network => "Network Drive", 
			_ => type.ToString(), 
		};
	}

	public static string FormatScreenResolution(Rectangle resolution)
	{
		return $"{resolution.Width}x{resolution.Height}";
	}

	public static string RemoveEnd(string input)
	{
		if (input.Length > 2)
		{
			input = input.Remove(input.Length - 2);
		}
		return input;
	}
}
