using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Tools.ServiceModel.ComSvcConfig;

[ComImport]
[SuppressUnmanagedCodeSecurity]
[Guid("6EB22870-8A19-11D0-81B6-00A0C9231C29")]
internal interface IMtsCatalog
{
	[DispId(1)]
	[return: MarshalAs(UnmanagedType.Interface)]
	object GetCollection([In][MarshalAs(UnmanagedType.BStr)] string bstrCollName);

	[DispId(2)]
	[return: MarshalAs(UnmanagedType.Interface)]
	object Connect([In][MarshalAs(UnmanagedType.BStr)] string connectStr);

	[DispId(3)]
	int MajorVersion();

	[DispId(4)]
	int MinorVersion();
}
