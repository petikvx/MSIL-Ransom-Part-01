namespace Alphaleonis.Win32;

internal static class Win32Errors
{
	public const uint ERROR_INVALID_FILE_SIZE = uint.MaxValue;

	public const uint ERROR_SUCCESS = 0u;

	public const uint NO_ERROR = 0u;

	public const uint ERROR_INVALID_FUNCTION = 1u;

	public const uint ERROR_FILE_NOT_FOUND = 2u;

	public const uint ERROR_PATH_NOT_FOUND = 3u;

	public const uint ERROR_ACCESS_DENIED = 5u;

	public const uint ERROR_INVALID_DATA = 13u;

	public const uint ERROR_INVALID_DRIVE = 15u;

	public const uint ERROR_NOT_SAME_DEVICE = 17u;

	public const uint ERROR_NO_MORE_FILES = 18u;

	public const uint ERROR_NOT_READY = 21u;

	public const uint ERROR_SEEK = 25u;

	public const uint ERROR_SHARING_VIOLATION = 32u;

	public const uint ERROR_LOCK_VIOLATION = 33u;

	public const uint ERROR_HANDLE_EOF = 38u;

	public const uint ERROR_NOT_SUPPORTED = 50u;

	public const uint ERROR_BAD_NETPATH = 53u;

	public const uint ERROR_NETWORK_ACCESS_DENIED = 65u;

	public const uint ERROR_BAD_NET_NAME = 67u;

	public const uint ERROR_FILE_EXISTS = 80u;

	public const uint ERROR_INVALID_PARAMETER = 87u;

	public const uint ERROR_INSUFFICIENT_BUFFER = 122u;

	public const uint ERROR_INVALID_NAME = 123u;

	public const uint ERROR_NEGATIVE_SEEK = 131u;

	public const uint ERROR_SAME_DRIVE = 143u;

	public const uint ERROR_DIR_NOT_EMPTY = 145u;

	public const uint ERROR_ALREADY_EXISTS = 183u;

	public const uint ERROR_MORE_DATA = 234u;

	public const uint ERROR_NO_MORE_ITEMS = 259u;

	public const uint ERROR_DIRECTORY = 267u;

	public const uint ERROR_OPERATION_ABORTED = 995u;

	public const uint ERROR_OLD_WIN_VERSION = 1150u;

	public const uint ERROR_REQUEST_ABORTED = 1235u;

	public const uint ERROR_INVALID_SECURITY_DESCR = 1338u;

	public const uint ERROR_SUCCESS_REBOOT_INITIATED = 1641u;

	public const uint RPC_X_BAD_STUB_DATA = 1783u;

	public const uint ERROR_SUCCESS_REBOOT_REQUIRED = 3010u;

	public const uint ERROR_SUCCESS_RESTART_REQUIRED = 3011u;

	public const uint ERROR_NOT_A_REPARSE_POINT = 4390u;

	public const uint ERROR_INVALID_REPARSE_DATA = 4392u;

	public const uint ERROR_FILE_READ_ONLY = 6009u;

	public const uint ERROR_BAD_RECOVERY_POLICY = 6012u;

	public const uint ERROR_INVALID_TRANSACTION = 6700u;

	public const uint ERROR_TRANSACTION_NOT_ACTIVE = 6701u;

	public const uint ERROR_TRANSACTION_REQUEST_NOT_VALID = 6702u;

	public const uint ERROR_TRANSACTION_NOT_REQUESTED = 6703u;

	public const uint ERROR_TRANSACTION_ALREADY_ABORTED = 6704u;

	public const uint ERROR_TRANSACTION_ALREADY_COMMITTED = 6705u;

	public const uint ERROR_TRANSACTIONAL_CONFLICT = 6800u;

	public const uint ERROR_TRANSACTIONS_UNSUPPORTED_REMOTE = 6805u;

	public const uint E_POINTER = 2147500035u;

	public const uint S_OK = 0u;

	public const uint NERR_Success = 0u;

	public const uint NERR_FileIdNotFound = 2314u;

	public const uint CR_SUCCESS = 0u;

	public static int GetHrFromWin32Error(uint errorCode)
	{
		return (int)(-2147024896L | errorCode);
	}
}
