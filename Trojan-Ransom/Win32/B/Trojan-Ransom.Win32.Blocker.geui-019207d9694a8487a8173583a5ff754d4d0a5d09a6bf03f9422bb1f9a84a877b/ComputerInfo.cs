using System;
using System.Globalization;
using System.Security.Principal;
using System.Text;

internal class ComputerInfo
{
	public static string FullName()
	{
		return $"{Environment.MachineName}\\{Environment.UserName}";
	}

	public static bool IsAdministrator()
	{
		using (WindowsIdentity windowsIdentity = WindowsIdentity.GetCurrent())
		{
			if (windowsIdentity.IsAuthenticated)
			{
				WindowsPrincipal windowsPrincipal = new WindowsPrincipal(windowsIdentity);
				return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
			}
		}
		return false;
	}

	public static string TwoLetterCountryName()
	{
		return CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
	}

	public static string ProcessorId()
	{
		return Misc.ExecuteWMIQuery("processor", "processorId");
	}

	public static string MACAddress()
	{
		return Misc.ExecuteWMIQuery("NetworkAdapterConfiguration", "MacAddress");
	}

	public static string VolumeSerial(string letter = "C")
	{
		return Misc.ExecuteWMIQuery("LogicalDisk", "VolumeSerialNumber", $"WHERE DeviceID='{letter}:'");
	}

	public static string UniqueID()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(ProcessorId());
		stringBuilder.Append(MACAddress());
		stringBuilder.Append(VolumeSerial());
		return Cryptography.GetGUID(stringBuilder.ToString());
	}
}
