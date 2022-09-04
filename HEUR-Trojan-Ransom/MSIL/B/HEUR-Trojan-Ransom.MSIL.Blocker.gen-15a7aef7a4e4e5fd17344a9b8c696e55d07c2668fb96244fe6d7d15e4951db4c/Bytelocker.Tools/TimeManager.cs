using System;
using Bytelocker.Settings;

namespace Bytelocker.Tools;

internal class TimeManager
{
	private DateTime due_date;

	private RegistryManager rm;

	public void ReadFromRegistry()
	{
		rm = new RegistryManager();
		due_date = DateTime.Parse(B64Manager.Base64ToString(rm.ReadStringValue(RegistryManager.SETTINGS_KEY_NAME, "t"))).AddHours(Bytelocker.TIME_TILL_REMOVAL_HOURS);
	}

	public double DetermineRemainingTimeInSeconds()
	{
		return Math.Round(due_date.Subtract(DateTime.Now).TotalSeconds);
	}
}
