using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Tools.ServiceModel.ComSvcConfig;

[ComImport]
[Guid("DD662187-DFC2-11D1-A2CF-00805FC79235")]
[SuppressUnmanagedCodeSecurity]
internal interface ICatalog
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

	[DispId(5)]
	[return: MarshalAs(UnmanagedType.Interface)]
	object GetCollectionByQuery([In][MarshalAs(UnmanagedType.BStr)] string collName, [In][MarshalAs(UnmanagedType.SafeArray)] ref object[] aQuery);

	[DispId(6)]
	void ImportComponent([In][MarshalAs(UnmanagedType.BStr)] string bstrApplIdOrName, [In][MarshalAs(UnmanagedType.BStr)] string bstrCLSIDOrProgId);

	[DispId(7)]
	void InstallComponent([In][MarshalAs(UnmanagedType.BStr)] string bstrApplIdOrName, [In][MarshalAs(UnmanagedType.BStr)] string bstrDLL, [In][MarshalAs(UnmanagedType.BStr)] string bstrTLB, [In][MarshalAs(UnmanagedType.BStr)] string bstrPSDLL);

	[DispId(8)]
	void ShutdownApplication([In][MarshalAs(UnmanagedType.BStr)] string bstrApplIdOrName);

	[DispId(9)]
	void ExportApplication([In][MarshalAs(UnmanagedType.BStr)] string bstrApplIdOrName, [In][MarshalAs(UnmanagedType.BStr)] string bstrApplicationFile, [In] int lOptions);

	[DispId(10)]
	void InstallApplication([In][MarshalAs(UnmanagedType.BStr)] string bstrApplicationFile, [In][MarshalAs(UnmanagedType.BStr)] string bstrDestinationDirectory, [In] int lOptions, [In][MarshalAs(UnmanagedType.BStr)] string bstrUserId, [In][MarshalAs(UnmanagedType.BStr)] string bstrPassword, [In][MarshalAs(UnmanagedType.BStr)] string bstrRSN);

	[DispId(11)]
	void StopRouter();

	[DispId(12)]
	void RefreshRouter();

	[DispId(13)]
	void StartRouter();

	[DispId(14)]
	void Reserved1();

	[DispId(15)]
	void Reserved2();

	[DispId(16)]
	void InstallMultipleComponents([In][MarshalAs(UnmanagedType.BStr)] string bstrApplIdOrName, [In][MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_VARIANT)] ref object[] fileNames, [In][MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_VARIANT)] ref object[] CLSIDS);

	[DispId(17)]
	void GetMultipleComponentsInfo([In][MarshalAs(UnmanagedType.BStr)] string bstrApplIdOrName, [In] object varFileNames, [MarshalAs(UnmanagedType.SafeArray)] out object[] varCLSIDS, [MarshalAs(UnmanagedType.SafeArray)] out object[] varClassNames, [MarshalAs(UnmanagedType.SafeArray)] out object[] varFileFlags, [MarshalAs(UnmanagedType.SafeArray)] out object[] varComponentFlags);

	[DispId(18)]
	void RefreshComponents();

	[DispId(19)]
	void BackupREGDB([In][MarshalAs(UnmanagedType.BStr)] string bstrBackupFilePath);

	[DispId(20)]
	void RestoreREGDB([In][MarshalAs(UnmanagedType.BStr)] string bstrBackupFilePath);

	[DispId(21)]
	void QueryApplicationFile([In][MarshalAs(UnmanagedType.BStr)] string bstrApplicationFile, [MarshalAs(UnmanagedType.BStr)] out string bstrApplicationName, [MarshalAs(UnmanagedType.BStr)] out string bstrApplicationDescription, [MarshalAs(UnmanagedType.VariantBool)] out bool bHasUsers, [MarshalAs(UnmanagedType.VariantBool)] out bool bIsProxy, [MarshalAs(UnmanagedType.SafeArray)] out object[] varFileNames);

	[DispId(22)]
	void StartApplication([In][MarshalAs(UnmanagedType.BStr)] string bstrApplIdOrName);

	[DispId(23)]
	int ServiceCheck([In] int lService);

	[DispId(24)]
	void InstallMultipleEventClasses([In][MarshalAs(UnmanagedType.BStr)] string bstrApplIdOrName, [In][MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_VARIANT)] ref object[] fileNames, [In][MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_VARIANT)] ref object[] CLSIDS);

	[DispId(25)]
	void InstallEventClass([In][MarshalAs(UnmanagedType.BStr)] string bstrApplIdOrName, [In][MarshalAs(UnmanagedType.BStr)] string bstrDLL, [In][MarshalAs(UnmanagedType.BStr)] string bstrTLB, [In][MarshalAs(UnmanagedType.BStr)] string bstrPSDLL);

	[DispId(26)]
	void GetEventClassesForIID([In] string bstrIID, [In][Out][MarshalAs(UnmanagedType.SafeArray)] ref object[] varCLSIDS, [In][Out][MarshalAs(UnmanagedType.SafeArray)] ref object[] varProgIDs, [In][Out][MarshalAs(UnmanagedType.SafeArray)] ref object[] varDescriptions);
}
