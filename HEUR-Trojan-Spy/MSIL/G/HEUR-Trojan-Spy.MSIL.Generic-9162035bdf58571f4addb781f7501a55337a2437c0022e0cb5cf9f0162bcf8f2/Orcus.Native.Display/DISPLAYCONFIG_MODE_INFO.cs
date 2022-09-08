namespace Orcus.Native.Display;

public struct DISPLAYCONFIG_MODE_INFO
{
	public DISPLAYCONFIG_MODE_INFO_TYPE infoType;

	public uint id;

	public LUID adapterId;

	public DISPLAYCONFIG_MODE_INFO_UNION modeInfo;
}
