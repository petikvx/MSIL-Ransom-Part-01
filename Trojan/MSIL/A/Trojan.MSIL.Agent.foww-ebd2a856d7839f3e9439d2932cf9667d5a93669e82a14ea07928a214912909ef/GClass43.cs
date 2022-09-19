using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;

public static class GClass43
{
	public static string smethod_0(string macAddress)
	{
		if (macAddress.Length == 12)
		{
			return Regex.Replace(macAddress, "(.{2})(.{2})(.{2})(.{2})(.{2})(.{2})", "$1:$2:$3:$4:$5:$6");
		}
		return "00:00:00:00:00:00";
	}

	public static string smethod_1(DriveType type)
	{
		return type switch
		{
			DriveType.Removable => "Removable Drive", 
			DriveType.Fixed => "Local Disk", 
			DriveType.Network => "Network Drive", 
			_ => type.ToString(), 
		};
	}

	public static string smethod_2(Rectangle resolution)
	{
		return $"{resolution.Width}x{resolution.Height}";
	}

	public static string smethod_3(string input)
	{
		if (input.Length > 2)
		{
			input = input.Remove(input.Length - 2);
		}
		return input;
	}
}