namespace Gecko;

public class nsINetUtilConsts
{
	public const ulong ESCAPE_ALL = 0uL;

	public const ulong ESCAPE_XALPHAS = 1uL;

	public const ulong ESCAPE_XPALPHAS = 2uL;

	public const ulong ESCAPE_URL_PATH = 4uL;

	public const ulong ESCAPE_URL_SCHEME = 1uL;

	public const ulong ESCAPE_URL_USERNAME = 2uL;

	public const ulong ESCAPE_URL_PASSWORD = 4uL;

	public const ulong ESCAPE_URL_HOST = 8uL;

	public const ulong ESCAPE_URL_DIRECTORY = 16uL;

	public const ulong ESCAPE_URL_FILE_BASENAME = 32uL;

	public const ulong ESCAPE_URL_FILE_EXTENSION = 64uL;

	public const ulong ESCAPE_URL_PARAM = 128uL;

	public const ulong ESCAPE_URL_QUERY = 256uL;

	public const ulong ESCAPE_URL_REF = 512uL;

	public const ulong ESCAPE_URL_FILEPATH = 112uL;

	public const ulong ESCAPE_URL_MINIMAL = 1023uL;

	public const ulong ESCAPE_URL_FORCED = 1024uL;

	public const ulong ESCAPE_URL_ONLY_ASCII = 2048uL;

	public const ulong ESCAPE_URL_ONLY_NONASCII = 4096uL;

	public const ulong ESCAPE_URL_COLON = 16384uL;

	public const ulong ESCAPE_URL_SKIP_CONTROL = 32768uL;
}
