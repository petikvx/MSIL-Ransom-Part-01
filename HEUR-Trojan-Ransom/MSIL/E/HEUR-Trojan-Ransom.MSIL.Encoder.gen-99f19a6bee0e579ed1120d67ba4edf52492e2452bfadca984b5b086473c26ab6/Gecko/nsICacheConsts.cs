namespace Gecko;

public class nsICacheConsts
{
	public const long ACCESS_NONE = 0L;

	public const long ACCESS_READ = 1L;

	public const long ACCESS_WRITE = 2L;

	public const long ACCESS_READ_WRITE = 3L;

	public const long STORE_ANYWHERE = 0L;

	public const long STORE_IN_MEMORY = 1L;

	public const long STORE_ON_DISK = 2L;

	public const long STORE_OFFLINE = 4L;

	public const long NOT_STREAM_BASED = 0L;

	public const long STREAM_BASED = 1L;

	public const long NON_BLOCKING = 0L;

	public const long BLOCKING = 1L;

	public const ulong NO_EXPIRATION_TIME = 4294967295uL;
}
