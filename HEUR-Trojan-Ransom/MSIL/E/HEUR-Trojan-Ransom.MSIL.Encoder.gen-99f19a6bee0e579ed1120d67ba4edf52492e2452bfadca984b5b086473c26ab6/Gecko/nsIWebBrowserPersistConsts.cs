namespace Gecko;

public class nsIWebBrowserPersistConsts
{
	public const ulong PERSIST_FLAGS_NONE = 0uL;

	public const ulong PERSIST_FLAGS_FROM_CACHE = 1uL;

	public const ulong PERSIST_FLAGS_BYPASS_CACHE = 2uL;

	public const ulong PERSIST_FLAGS_IGNORE_REDIRECTED_DATA = 4uL;

	public const ulong PERSIST_FLAGS_IGNORE_IFRAMES = 8uL;

	public const ulong PERSIST_FLAGS_NO_CONVERSION = 16uL;

	public const ulong PERSIST_FLAGS_REPLACE_EXISTING_FILES = 32uL;

	public const ulong PERSIST_FLAGS_NO_BASE_TAG_MODIFICATIONS = 64uL;

	public const ulong PERSIST_FLAGS_FIXUP_ORIGINAL_DOM = 128uL;

	public const ulong PERSIST_FLAGS_FIXUP_LINKS_TO_DESTINATION = 256uL;

	public const ulong PERSIST_FLAGS_DONT_FIXUP_LINKS = 512uL;

	public const ulong PERSIST_FLAGS_SERIALIZE_OUTPUT = 1024uL;

	public const ulong PERSIST_FLAGS_DONT_CHANGE_FILENAMES = 2048uL;

	public const ulong PERSIST_FLAGS_FAIL_ON_BROKEN_LINKS = 4096uL;

	public const ulong PERSIST_FLAGS_CLEANUP_ON_FAILURE = 8192uL;

	public const ulong PERSIST_FLAGS_AUTODETECT_APPLY_CONVERSION = 16384uL;

	public const ulong PERSIST_FLAGS_APPEND_TO_FILE = 32768uL;

	public const ulong PERSIST_FLAGS_FORCE_ALLOW_COOKIES = 65536uL;

	public const ulong PERSIST_STATE_READY = 1uL;

	public const ulong PERSIST_STATE_SAVING = 2uL;

	public const ulong PERSIST_STATE_FINISHED = 3uL;

	public const ulong ENCODE_FLAGS_SELECTION_ONLY = 1uL;

	public const ulong ENCODE_FLAGS_FORMATTED = 2uL;

	public const ulong ENCODE_FLAGS_RAW = 4uL;

	public const ulong ENCODE_FLAGS_BODY_ONLY = 8uL;

	public const ulong ENCODE_FLAGS_PREFORMATTED = 16uL;

	public const ulong ENCODE_FLAGS_WRAP = 32uL;

	public const ulong ENCODE_FLAGS_FORMAT_FLOWED = 64uL;

	public const ulong ENCODE_FLAGS_ABSOLUTE_LINKS = 128uL;

	public const ulong ENCODE_FLAGS_ENCODE_W3C_ENTITIES = 256uL;

	public const ulong ENCODE_FLAGS_CR_LINEBREAKS = 512uL;

	public const ulong ENCODE_FLAGS_LF_LINEBREAKS = 1024uL;

	public const ulong ENCODE_FLAGS_NOSCRIPT_CONTENT = 2048uL;

	public const ulong ENCODE_FLAGS_NOFRAMES_CONTENT = 4096uL;

	public const ulong ENCODE_FLAGS_ENCODE_BASIC_ENTITIES = 8192uL;

	public const ulong ENCODE_FLAGS_ENCODE_LATIN1_ENTITIES = 16384uL;

	public const ulong ENCODE_FLAGS_ENCODE_HTML_ENTITIES = 32768uL;
}
