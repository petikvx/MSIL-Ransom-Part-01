namespace Vestris.ResourceLib;

public abstract class Winver
{
	public enum FileFlags : uint
	{
		VS_FF_DEBUG = 1u,
		VS_FF_PRERELEASE = 2u,
		VS_FF_PATCHED = 4u,
		VS_FF_PRIVATEBUILD = 8u,
		VS_FF_INFOINFERRED = 0x10u,
		VS_FF_SPECIALBUILD = 0x20u
	}

	public enum FileOs : uint
	{
		VOS_UNKNOWN = 0u,
		VOS_DOS = 65536u,
		VOS_OS216 = 131072u,
		VOS_OS232 = 196608u,
		VOS_NT = 262144u,
		VOS_WINCE = 327680u,
		VOS__WINDOWS16 = 1u,
		VOS__PM16 = 2u,
		VOS__PM32 = 3u,
		VOS__WINDOWS32 = 4u,
		VOS_DOS_WINDOWS16 = 65537u,
		VOS_DOS_WINDOWS32 = 65540u,
		VOS_OS216_PM16 = 131074u,
		VOS_OS232_PM32 = 196611u,
		VOS_NT_WINDOWS32 = 262148u
	}

	public enum FileType : uint
	{
		VFT_UNKNOWN = 0u,
		VFT_APP = 1u,
		VFT_DLL = 2u,
		VFT_DRV = 3u,
		VFT_FONT = 4u,
		VFT_VXD = 5u,
		VFT_STATIC_LIB = 7u
	}

	public enum FileSubType : uint
	{
		VFT2_UNKNOWN = 0u,
		VFT2_DRV_PRINTER = 1u,
		VFT2_DRV_KEYBOARD = 2u,
		VFT2_DRV_LANGUAGE = 3u,
		VFT2_DRV_DISPLAY = 4u,
		VFT2_DRV_MOUSE = 5u,
		VFT2_DRV_NETWORK = 6u,
		VFT2_DRV_SYSTEM = 7u,
		VFT2_DRV_INSTALLABLE = 8u,
		VFT2_DRV_SOUND = 9u,
		VFT2_DRV_COMM = 10u,
		VFT2_DRV_INPUTMETHOD = 11u,
		VFT2_DRV_VERSIONED_PRINTER = 12u,
		VFT2_FONT_RASTER = 1u,
		VFT2_FONT_VECTOR = 2u,
		VFT2_FONT_TRUETYPE = 3u
	}

	public const uint VS_FFI_SIGNATURE = 4277077181u;

	public const uint VS_FFI_STRUCVERSION = 65536u;

	public const uint VS_FFI_FILEFLAGSMASK = 63u;
}
