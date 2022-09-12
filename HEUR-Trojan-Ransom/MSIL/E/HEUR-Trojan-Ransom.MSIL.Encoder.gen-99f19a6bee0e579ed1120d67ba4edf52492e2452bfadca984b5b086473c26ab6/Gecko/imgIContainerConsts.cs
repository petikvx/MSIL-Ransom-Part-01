namespace Gecko;

public class imgIContainerConsts
{
	public const ushort TYPE_RASTER = 0;

	public const ushort TYPE_VECTOR = 1;

	public const ulong FLAG_NONE = 0uL;

	public const ulong FLAG_SYNC_DECODE = 1uL;

	public const ulong FLAG_SYNC_DECODE_IF_FAST = 2uL;

	public const ulong FLAG_ASYNC_NOTIFY = 4uL;

	public const ulong FLAG_DECODE_NO_PREMULTIPLY_ALPHA = 8uL;

	public const ulong FLAG_DECODE_NO_COLORSPACE_CONVERSION = 16uL;

	public const ulong FLAG_CLAMP = 32uL;

	public const ulong FLAG_HIGH_QUALITY_SCALING = 64uL;

	public const ulong FLAG_WANT_DATA_SURFACE = 128uL;

	public const ulong FLAG_BYPASS_SURFACE_CACHE = 256uL;

	public const ulong DECODE_FLAGS_DEFAULT = 0uL;

	public const ulong FRAME_FIRST = 0uL;

	public const ulong FRAME_CURRENT = 1uL;

	public const ulong FRAME_MAX_VALUE = 1uL;

	public const short kNormalAnimMode = 0;

	public const short kDontAnimMode = 1;

	public const short kLoopOnceAnimMode = 2;
}
