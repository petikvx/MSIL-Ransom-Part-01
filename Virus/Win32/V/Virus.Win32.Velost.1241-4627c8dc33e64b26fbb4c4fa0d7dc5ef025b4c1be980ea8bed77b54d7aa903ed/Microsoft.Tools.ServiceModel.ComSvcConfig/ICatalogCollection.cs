using System.Collections;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Tools.ServiceModel.ComSvcConfig;

[ComImport]
[SuppressUnmanagedCodeSecurity]
[InterfaceType(ComInterfaceType.InterfaceIsDual)]
[Guid("6EB22872-8A19-11D0-81B6-00A0C9231C29")]
internal interface ICatalogCollection
{
	bool IsAddEnabled
	{
		[DispId(7)]
		[return: MarshalAs(UnmanagedType.VariantBool)]
		get;
	}

	bool IsRemoveEnabled
	{
		[DispId(8)]
		[return: MarshalAs(UnmanagedType.VariantBool)]
		get;
	}

	int DataStoreMajorVersion
	{
		[DispId(10)]
		get;
	}

	int DataStoreMinorVersion
	{
		[DispId(11)]
		get;
	}

	[DispId(-4)]
	void GetEnumerator(out IEnumerator pEnum);

	[DispId(1)]
	[return: MarshalAs(UnmanagedType.Interface)]
	object Item([In] int lIndex);

	[DispId(1610743810)]
	int Count();

	[DispId(1610743811)]
	void Remove([In] int lIndex);

	[DispId(1610743812)]
	[return: MarshalAs(UnmanagedType.Interface)]
	object Add();

	[DispId(2)]
	void Populate();

	[DispId(3)]
	int SaveChanges();

	[DispId(4)]
	[return: MarshalAs(UnmanagedType.Interface)]
	object GetCollection([In][MarshalAs(UnmanagedType.BStr)] string bstrCollName, [In] object varObjectKey);

	[DispId(6)]
	object Name();

	[DispId(9)]
	[return: MarshalAs(UnmanagedType.Interface)]
	object GetUtilInterface();

	void PopulateByKey([In][MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_VARIANT)] object[] aKeys);

	[DispId(13)]
	void PopulateByQuery([In][MarshalAs(UnmanagedType.BStr)] string bstrQueryString, [In] int lQueryType);
}
