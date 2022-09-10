namespace Orcus.Native.Display;

public enum DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY : uint
{
	DISPLAYCONFIG_OUTPUT_TECHNOLOGY_OTHER = uint.MaxValue,
	DISPLAYCONFIG_OUTPUT_TECHNOLOGY_HD15 = 0u,
	DISPLAYCONFIG_OUTPUT_TECHNOLOGY_SVIDEO = 1u,
	DISPLAYCONFIG_OUTPUT_TECHNOLOGY_COMPOSITE_VIDEO = 2u,
	DISPLAYCONFIG_OUTPUT_TECHNOLOGY_COMPONENT_VIDEO = 3u,
	DISPLAYCONFIG_OUTPUT_TECHNOLOGY_DVI = 4u,
	DISPLAYCONFIG_OUTPUT_TECHNOLOGY_HDMI = 5u,
	DISPLAYCONFIG_OUTPUT_TECHNOLOGY_LVDS = 6u,
	DISPLAYCONFIG_OUTPUT_TECHNOLOGY_D_JPN = 8u,
	DISPLAYCONFIG_OUTPUT_TECHNOLOGY_SDI = 9u,
	DISPLAYCONFIG_OUTPUT_TECHNOLOGY_DISPLAYPORT_EXTERNAL = 10u,
	DISPLAYCONFIG_OUTPUT_TECHNOLOGY_DISPLAYPORT_EMBEDDED = 11u,
	DISPLAYCONFIG_OUTPUT_TECHNOLOGY_UDI_EXTERNAL = 12u,
	DISPLAYCONFIG_OUTPUT_TECHNOLOGY_UDI_EMBEDDED = 13u,
	DISPLAYCONFIG_OUTPUT_TECHNOLOGY_SDTVDONGLE = 14u,
	DISPLAYCONFIG_OUTPUT_TECHNOLOGY_MIRACAST = 15u,
	DISPLAYCONFIG_OUTPUT_TECHNOLOGY_INTERNAL = 2147483648u,
	DISPLAYCONFIG_OUTPUT_TECHNOLOGY_FORCE_UINT32 = uint.MaxValue
}