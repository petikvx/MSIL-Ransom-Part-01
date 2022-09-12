namespace Gecko;

public class nsIXPCScriptableConsts
{
	public const long WANT_PRECREATE = 1L;

	public const long WANT_ADDPROPERTY = 8L;

	public const long WANT_GETPROPERTY = 32L;

	public const long WANT_SETPROPERTY = 64L;

	public const long WANT_ENUMERATE = 128L;

	public const long WANT_NEWENUMERATE = 256L;

	public const long WANT_RESOLVE = 512L;

	public const long WANT_FINALIZE = 2048L;

	public const long WANT_CALL = 8192L;

	public const long WANT_CONSTRUCT = 16384L;

	public const long WANT_HASINSTANCE = 32768L;

	public const long USE_JSSTUB_FOR_ADDPROPERTY = 131072L;

	public const long USE_JSSTUB_FOR_DELPROPERTY = 262144L;

	public const long USE_JSSTUB_FOR_SETPROPERTY = 524288L;

	public const long DONT_ENUM_QUERY_INTERFACE = 2097152L;

	public const long DONT_ASK_INSTANCE_FOR_SCRIPTABLE = 4194304L;

	public const long CLASSINFO_INTERFACES_ONLY = 8388608L;

	public const long ALLOW_PROP_MODS_DURING_RESOLVE = 16777216L;

	public const long ALLOW_PROP_MODS_TO_PROTOTYPE = 33554432L;

	public const long IS_GLOBAL_OBJECT = 67108864L;

	public const long DONT_REFLECT_INTERFACE_NAMES = 134217728L;

	public const long RESERVED = -2147483648L;
}
