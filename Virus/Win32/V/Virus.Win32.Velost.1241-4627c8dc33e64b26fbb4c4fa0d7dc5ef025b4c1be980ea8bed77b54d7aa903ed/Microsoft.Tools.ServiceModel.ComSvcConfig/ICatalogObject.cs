using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Tools.ServiceModel.ComSvcConfig;

[ComImport]
[Guid("6EB22871-8A19-11D0-81B6-00A0C9231C29")]
[SuppressUnmanagedCodeSecurity]
internal interface ICatalogObject
{
	bool Valid
	{
		[DispId(5)]
		[return: MarshalAs(UnmanagedType.VariantBool)]
		get;
	}

	[DispId(1)]
	object GetValue([In][MarshalAs(UnmanagedType.BStr)] string propName);

	[DispId(1)]
	void SetValue([In][MarshalAs(UnmanagedType.BStr)] string propName, [In] object value);

	[DispId(2)]
	object Key();

	[DispId(3)]
	object Name();

	[DispId(4)]
	[return: MarshalAs(UnmanagedType.VariantBool)]
	bool IsPropertyReadOnly([In][MarshalAs(UnmanagedType.BStr)] string bstrPropName);

	[DispId(6)]
	[return: MarshalAs(UnmanagedType.VariantBool)]
	bool IsPropertyWriteOnly([In][MarshalAs(UnmanagedType.BStr)] string bstrPropName);
}
