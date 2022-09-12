namespace Gecko;

internal class XULAppInfo : nsIXULAppInfo, nsIXULRuntime
{
	private static nsIXULRuntime backXulRuntime;

	public static void Init()
	{
		backXulRuntime = Xpcom.GetService<nsIXULRuntime>("@mozilla.org/xre/app-info;1");
	}

	public void GetVendorAttribute(nsACStringBase aVendor)
	{
		aVendor.SetData("Mozilla and geckofx contributors");
	}

	public void GetNameAttribute(nsACStringBase aName)
	{
		aName.SetData("geckofx");
	}

	public void GetIDAttribute(nsACStringBase aID)
	{
		aID.SetData("unknown_id");
	}

	public void GetVersionAttribute(nsACStringBase aVersion)
	{
		aVersion.SetData("45");
	}

	public void GetAppBuildIDAttribute(nsACStringBase aAppBuildID)
	{
		aAppBuildID.SetData("unknown_id");
	}

	public void GetPlatformVersionAttribute(nsACStringBase aPlatformVersion)
	{
		aPlatformVersion.SetData("45");
	}

	public void GetPlatformBuildIDAttribute(nsACStringBase aPlatformBuildID)
	{
		aPlatformBuildID.SetData("0");
	}

	public void GetUANameAttribute(nsACStringBase aUAName)
	{
		aUAName.SetData("geckofx");
	}

	public bool GetInSafeModeAttribute()
	{
		return backXulRuntime.GetInSafeModeAttribute();
	}

	public bool GetLogConsoleErrorsAttribute()
	{
		return backXulRuntime.GetLogConsoleErrorsAttribute();
	}

	public void SetLogConsoleErrorsAttribute(bool aLogConsoleErrors)
	{
		backXulRuntime.SetLogConsoleErrorsAttribute(aLogConsoleErrors);
	}

	public void GetOSAttribute(nsAUTF8StringBase aOS)
	{
		backXulRuntime.GetOSAttribute(aOS);
	}

	public void GetXPCOMABIAttribute(nsAUTF8StringBase aXPCOMABI)
	{
		backXulRuntime.GetXPCOMABIAttribute(aXPCOMABI);
	}

	public void GetWidgetToolkitAttribute(nsAUTF8StringBase aWidgetToolkit)
	{
		backXulRuntime.GetWidgetToolkitAttribute(aWidgetToolkit);
	}

	public uint GetProcessTypeAttribute()
	{
		return backXulRuntime.GetProcessTypeAttribute();
	}

	public uint GetProcessIDAttribute()
	{
		return backXulRuntime.GetProcessIDAttribute();
	}

	public bool GetBrowserTabsRemoteAutostartAttribute()
	{
		return backXulRuntime.GetBrowserTabsRemoteAutostartAttribute();
	}

	public bool GetAccessibilityEnabledAttribute()
	{
		return backXulRuntime.GetAccessibilityEnabledAttribute();
	}

	public bool GetAccessibilityIsBlacklistedForE10SAttribute()
	{
		return false;
	}

	public bool GetIs64BitAttribute()
	{
		return backXulRuntime.GetIs64BitAttribute();
	}

	public void InvalidateCachesOnRestart()
	{
		backXulRuntime.InvalidateCachesOnRestart();
	}

	public void EnsureContentProcess()
	{
		backXulRuntime.EnsureContentProcess();
	}

	public long GetReplacedLockTimeAttribute()
	{
		return backXulRuntime.GetReplacedLockTimeAttribute();
	}

	public void GetLastRunCrashIDAttribute(nsAStringBase aLastRunCrashID)
	{
		backXulRuntime.GetLastRunCrashIDAttribute(aLastRunCrashID);
	}

	public bool GetIsReleaseBuildAttribute()
	{
		return backXulRuntime.GetIsReleaseBuildAttribute();
	}

	public bool GetIsOfficialBrandingAttribute()
	{
		return backXulRuntime.GetIsOfficialBrandingAttribute();
	}

	public void GetDefaultUpdateChannelAttribute(nsAUTF8StringBase aDefaultUpdateChannel)
	{
		backXulRuntime.GetDefaultUpdateChannelAttribute(aDefaultUpdateChannel);
	}

	public void GetDistributionIDAttribute(nsAUTF8StringBase aDistributionID)
	{
		backXulRuntime.GetDistributionIDAttribute(aDistributionID);
	}

	public bool GetIsOfficialAttribute()
	{
		return backXulRuntime.GetIsOfficialAttribute();
	}
}
