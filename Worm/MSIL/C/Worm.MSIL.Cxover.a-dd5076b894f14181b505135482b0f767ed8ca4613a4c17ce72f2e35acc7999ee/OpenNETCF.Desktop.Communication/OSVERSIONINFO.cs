namespace OpenNETCF.Desktop.Communication;

public struct OSVERSIONINFO
{
	internal int dwOSVersionInfoSize;

	public int dwMajorVersion;

	public int dwMinorVersion;

	public int dwBuildNumber;

	public PlatformType dwPlatformId;
}
