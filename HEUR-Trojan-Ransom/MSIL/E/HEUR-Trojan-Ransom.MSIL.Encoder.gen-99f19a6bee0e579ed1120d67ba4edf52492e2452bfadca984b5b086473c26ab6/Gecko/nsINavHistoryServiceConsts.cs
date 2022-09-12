namespace Gecko;

public class nsINavHistoryServiceConsts
{
	public const ulong TRANSITION_LINK = 1uL;

	public const ulong TRANSITION_TYPED = 2uL;

	public const ulong TRANSITION_BOOKMARK = 3uL;

	public const ulong TRANSITION_EMBED = 4uL;

	public const ulong TRANSITION_REDIRECT_PERMANENT = 5uL;

	public const ulong TRANSITION_REDIRECT_TEMPORARY = 6uL;

	public const ulong TRANSITION_DOWNLOAD = 7uL;

	public const ulong TRANSITION_FRAMED_LINK = 8uL;

	public const ushort DATABASE_STATUS_OK = 0;

	public const ushort DATABASE_STATUS_CREATE = 1;

	public const ushort DATABASE_STATUS_CORRUPT = 2;

	public const ushort DATABASE_STATUS_UPGRADED = 3;
}
