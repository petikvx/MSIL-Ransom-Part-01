using System.Runtime.InteropServices;

namespace ns0;

public abstract class GClass1
{
	[MarshalAs(UnmanagedType.LPStr)]
	public const string PST_CONFIGDATA_TYPE_STRING = "Configuration Data";

	[MarshalAs(UnmanagedType.LPStr)]
	public const string PST_PROTECTEDSTORAGE_SUBTYPE_STRING = "Protected Storage";

	[MarshalAs(UnmanagedType.LPStr)]
	public const string PST_PSTORE_PROVIDERS_SUBTYPE_STRING = "Protected Storage Provider List";

	public GClass1()
	{
	}
}
