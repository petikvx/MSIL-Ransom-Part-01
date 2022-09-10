using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Tools.ServiceModel.ComSvcConfig;

[ComImport]
[SuppressUnmanagedCodeSecurity]
[InterfaceType(ComInterfaceType.InterfaceIsDual)]
[Guid("790C6E0B-9194-4cc9-9426-A48A63185696")]
internal interface ICatalog2
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

	[DispId(27)]
	[return: MarshalAs(UnmanagedType.Interface)]
	object GetCollectionByQuery2([In][MarshalAs(UnmanagedType.BStr)] string bstrCollectionName, [In][MarshalAs(UnmanagedType.LPStruct)] object pVarQueryStrings);

	[DispId(28)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string GetApplicationInstanceIDFromProcessID([In][MarshalAs(UnmanagedType.I4)] int lProcessID);

	[DispId(29)]
	void ShutdownApplicationInstances([In][MarshalAs(UnmanagedType.LPStruct)] object pVarApplicationInstanceID);

	[DispId(30)]
	void PauseApplicationInstances([In][MarshalAs(UnmanagedType.LPStruct)] object pVarApplicationInstanceID);

	[DispId(31)]
	void ResumeApplicationInstances([In][MarshalAs(UnmanagedType.LPStruct)] object pVarApplicationInstanceID);

	[DispId(32)]
	void RecycleApplicationInstances([In][MarshalAs(UnmanagedType.LPStruct)] object pVarApplicationInstanceID, [In][MarshalAs(UnmanagedType.I4)] int lReasonCode);

	[DispId(33)]
	[return: MarshalAs(UnmanagedType.VariantBool)]
	bool AreApplicationInstancesPaused([In][MarshalAs(UnmanagedType.LPStruct)] object pVarApplicationInstanceID);

	[DispId(34)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string DumpApplicationInstance([In][MarshalAs(UnmanagedType.BStr)] string bstrApplicationInstanceID, [In][MarshalAs(UnmanagedType.BStr)] string bstrDirectory, [In][MarshalAs(UnmanagedType.I4)] int lMaxImages);

	[DispId(35)]
	[return: MarshalAs(UnmanagedType.VariantBool)]
	bool IsApplicationInstanceDumpSupported();

	[DispId(36)]
	void CreateServiceForApplication([In][MarshalAs(UnmanagedType.BStr)] string bstrApplicationIDOrName, [In][MarshalAs(UnmanagedType.BStr)] string bstrServiceName, [In][MarshalAs(UnmanagedType.BStr)] string bstrStartType, [In][MarshalAs(UnmanagedType.BStr)] string bstrErrorControl, [In][MarshalAs(UnmanagedType.BStr)] string bstrDependencies, [In][MarshalAs(UnmanagedType.BStr)] string bstrRunAs, [In][MarshalAs(UnmanagedType.BStr)] string bstrPassword, [In][MarshalAs(UnmanagedType.VariantBool)] bool bDesktopOk);

	[DispId(37)]
	void DeleteServiceForApplication([In][MarshalAs(UnmanagedType.BStr)] string bstrApplicationIDOrName);

	[DispId(38)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string GetPartitionID([In][MarshalAs(UnmanagedType.BStr)] string bstrApplicationIDOrName);

	[DispId(39)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string GetPartitionName([In][MarshalAs(UnmanagedType.BStr)] string bstrApplicationIDOrName);

	[DispId(40)]
	void CurrentPartition([In][MarshalAs(UnmanagedType.BStr)] string bstrPartitionIDOrName);

	[DispId(41)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string CurrentPartitionID();

	[DispId(42)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string CurrentPartitionName();

	[DispId(43)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string GlobalPartitionID();

	[DispId(44)]
	void FlushPartitionCache();

	[DispId(45)]
	void CopyApplications([In][MarshalAs(UnmanagedType.BStr)] string bstrSourcePartitionIDOrName, [In][MarshalAs(UnmanagedType.LPStruct)] object pVarApplicationID, [In][MarshalAs(UnmanagedType.BStr)] string bstrDestinationPartitionIDOrName);

	[DispId(46)]
	void CopyComponents([In][MarshalAs(UnmanagedType.BStr)] string bstrSourceApplicationIDOrName, [In][MarshalAs(UnmanagedType.LPStruct)] object pVarCLSIDOrProgID, [In][MarshalAs(UnmanagedType.BStr)] string bstrDestinationApplicationIDOrName);

	[DispId(47)]
	void MoveComponents([In][MarshalAs(UnmanagedType.BStr)] string bstrSourceApplicationIDOrName, [In][MarshalAs(UnmanagedType.LPStruct)] object pVarCLSIDOrProgID, [In][MarshalAs(UnmanagedType.BStr)] string bstrDestinationApplicationIDOrName);

	[DispId(48)]
	void AliasComponent([In][MarshalAs(UnmanagedType.BStr)] string bstrSrcApplicationIDOrName, [In][MarshalAs(UnmanagedType.BStr)] string bstrCLSIDOrProgID, [In][MarshalAs(UnmanagedType.BStr)] string bstrDestApplicationIDOrName, [In][MarshalAs(UnmanagedType.BStr)] string bstrNewProgId, [In][MarshalAs(UnmanagedType.BStr)] string bstrNewClsid);

	[DispId(49)]
	[return: MarshalAs(UnmanagedType.Interface)]
	object IsSafeToDelete([In][MarshalAs(UnmanagedType.BStr)] string bstrDllName);

	[DispId(50)]
	void ImportUnconfiguredComponents([In][MarshalAs(UnmanagedType.BStr)] string bstrApplicationIDOrName, [In][MarshalAs(UnmanagedType.LPStruct)] object pVarCLSIDOrProgID, [In][MarshalAs(UnmanagedType.LPStruct)] object pVarComponentType);

	[DispId(51)]
	void PromoteUnconfiguredComponents([In][MarshalAs(UnmanagedType.BStr)] string bstrApplicationIDOrName, [In][MarshalAs(UnmanagedType.LPStruct)] object pVarCLSIDOrProgID, [In][MarshalAs(UnmanagedType.LPStruct)] object pVarComponentType);

	[DispId(52)]
	void ImportComponents([In][MarshalAs(UnmanagedType.BStr)] string bstrApplicationIDOrName, [In][MarshalAs(UnmanagedType.LPStruct)] object pVarCLSIDOrProgID, [In][MarshalAs(UnmanagedType.LPStruct)] object pVarComponentType);

	[DispId(53)]
	[return: MarshalAs(UnmanagedType.VariantBool)]
	bool Is64BitCatalogServer();

	[DispId(54)]
	void ExportPartition([In][MarshalAs(UnmanagedType.BStr)] string bstrPartitionIDOrName, [In][MarshalAs(UnmanagedType.BStr)] string bstrPartitionFileName, [In][MarshalAs(UnmanagedType.I4)] int lOptions);

	[DispId(55)]
	void InstallPartition([In][MarshalAs(UnmanagedType.BStr)] string bstrFileName, [In][MarshalAs(UnmanagedType.BStr)] string bstrDestDirectory, [In][MarshalAs(UnmanagedType.I4)] int lOptions, [In][MarshalAs(UnmanagedType.BStr)] string bstrUserID, [In][MarshalAs(UnmanagedType.BStr)] string bstrPassword, [In][MarshalAs(UnmanagedType.BStr)] string bstrRSN);

	[DispId(56)]
	[return: MarshalAs(UnmanagedType.IDispatch)]
	object QueryApplicationFile2([In][MarshalAs(UnmanagedType.BStr)] string bstrApplicationFile);

	[DispId(57)]
	[return: MarshalAs(UnmanagedType.I4)]
	int GetComponentVersionCount([In][MarshalAs(UnmanagedType.BStr)] string bstrCLSIDOrProgID);
}
