using System;

namespace Sage.Peachtree.OnlineUpdate;

internal class ProductVersionChecker
{
	private ProductVersionChecker()
	{
	}

	public static bool IsProductVersionInstalled(string productName, string versionNumber)
	{
		string version = RegistrySettings.ReadStringValue("Software\\Peachtree\\Applications\\" + productName, "Version");
		try
		{
			Version version2 = new Version(version);
			Version value = new Version(versionNumber);
			return version2.CompareTo(value) >= 0;
		}
		catch (ArgumentException)
		{
			return false;
		}
	}

	protected static bool IsDateStringValid(string machineDate, string compareDate)
	{
		try
		{
			DateTime value = Convert.ToDateTime(compareDate);
			return Convert.ToDateTime(machineDate).CompareTo(value) >= 0;
		}
		catch (FormatException)
		{
			return false;
		}
		catch (OverflowException)
		{
			return false;
		}
	}

	public static bool IsTaxUpdateInstalled(string productName, string versionNumber)
	{
		string machineDate = RegistrySettings.ReadStringValue("Software\\Peachtree\\Applications\\" + productName, "Version");
		if (IsDateStringValid(machineDate, versionNumber))
		{
			return true;
		}
		try
		{
			int num = Convert.ToInt32(OnlineUpdateApp.Instance.TaxRegistrationYear.Substring(OnlineUpdateApp.Instance.TaxRegistrationYear.Length - 2, 2));
			int num2 = Convert.ToInt32(productName.Substring(productName.Length - 2, 2));
			if (num < num2)
			{
				return true;
			}
			string text = string.Format("{0}{1}", productName.Substring(0, productName.Length - 2), num.ToString("D2"));
			machineDate = RegistrySettings.ReadStringValue("Software\\Peachtree\\Applications\\" + text, "Version");
			return IsDateStringValid(machineDate, versionNumber);
		}
		catch (FormatException)
		{
			return false;
		}
		catch (OverflowException)
		{
			return false;
		}
	}
}
