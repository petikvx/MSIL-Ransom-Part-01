namespace Orcus.Native.Display;

public struct DISPLAYCONFIG_DEVICE_INFO_HEADER
{
	public DISPLAYCONFIG_DEVICE_INFO_TYPE type;

	public uint size;

	public LUID adapterId;

	public uint id;
}
