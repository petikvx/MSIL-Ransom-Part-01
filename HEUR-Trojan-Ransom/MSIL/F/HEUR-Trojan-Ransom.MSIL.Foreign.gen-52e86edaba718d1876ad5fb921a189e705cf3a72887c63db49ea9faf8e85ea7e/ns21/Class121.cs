using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ns21;

[DebuggerNonUserCode]
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
internal sealed class Class121
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[NonSerialized]
	internal static GetString getString_0;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static ResourceManager ResourceManager
	{
		get
		{
			if (resourceManager_0 == null)
			{
				resourceManager_0 = new ResourceManager(getString_0(107365397), typeof(Class121).GetTypeInfo().Assembly);
			}
			return resourceManager_0;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static CultureInfo Culture
	{
		get
		{
			return cultureInfo_0;
		}
		set
		{
			cultureInfo_0 = value;
		}
	}

	public static string AdapterIsNull => ResourceManager.GetString(getString_0(107365392), cultureInfo_0);

	public static string AdapterSelectIsNull => ResourceManager.GetString(getString_0(107365339), cultureInfo_0);

	public static string AttemptToAccessBeforeRead => ResourceManager.GetString(getString_0(107364798), cultureInfo_0);

	public static string AuthenticationFailed => ResourceManager.GetString(getString_0(107364761), cultureInfo_0);

	public static string AuthenticationMethodNotSupported => ResourceManager.GetString(getString_0(107364732), cultureInfo_0);

	public static string BadVersionFormat => ResourceManager.GetString(getString_0(107364719), cultureInfo_0);

	public static string BufferCannotBeNull => ResourceManager.GetString(getString_0(107364694), cultureInfo_0);

	public static string BufferNotLargeEnough => ResourceManager.GetString(getString_0(107364637), cultureInfo_0);

	public static string CancelNeeds50 => ResourceManager.GetString(getString_0(107364608), cultureInfo_0);

	public static string CancelNotSupported => ResourceManager.GetString(getString_0(107364619), cultureInfo_0);

	public static string CanNotDeriveParametersForTextCommands => ResourceManager.GetString(getString_0(107364594), cultureInfo_0);

	public static string CBMultiTableNotSupported => ResourceManager.GetString(getString_0(107365021), cultureInfo_0);

	public static string CBNoKeyColumn => ResourceManager.GetString(getString_0(107364988), cultureInfo_0);

	public static string ChaosNotSupported => ResourceManager.GetString(getString_0(107364967), cultureInfo_0);

	public static string CommandTextNotInitialized => ResourceManager.GetString(getString_0(107364974), cultureInfo_0);

	public static string CompressionNotSupported => ResourceManager.GetString(getString_0(107364937), cultureInfo_0);

	public static string ConnectionAlreadyOpen => ResourceManager.GetString(getString_0(107364904), cultureInfo_0);

	public static string ConnectionBroken => ResourceManager.GetString(getString_0(107364875), cultureInfo_0);

	public static string ConnectionMustBeOpen => ResourceManager.GetString(getString_0(107364850), cultureInfo_0);

	public static string ConnectionNotOpen => ResourceManager.GetString(getString_0(107364309), cultureInfo_0);

	public static string ConnectionNotSet => ResourceManager.GetString(getString_0(107364252), cultureInfo_0);

	public static string CouldNotFindColumnName => ResourceManager.GetString(getString_0(107364227), cultureInfo_0);

	public static string CountCannotBeNegative => ResourceManager.GetString(getString_0(107364194), cultureInfo_0);

	public static string CSNoSetLength => ResourceManager.GetString(getString_0(107364165), cultureInfo_0);

	public static string DataNotInSupportedFormat => ResourceManager.GetString(getString_0(107364176), cultureInfo_0);

	public static string DataReaderOpen => ResourceManager.GetString(getString_0(107364143), cultureInfo_0);

	public static string DefaultEncodingNotFound => ResourceManager.GetString(getString_0(107364090), cultureInfo_0);

	public static string DistributedTxnNotSupported => ResourceManager.GetString(getString_0(107364057), cultureInfo_0);

	public static string DuplicatedSslConnectionOption => ResourceManager.GetString(getString_0(107364564), cultureInfo_0);

	public static string ErrorCreatingSocket => ResourceManager.GetString(getString_0(107364523), cultureInfo_0);

	public static string FatalErrorDuringExecute => ResourceManager.GetString(getString_0(107364494), cultureInfo_0);

	public static string FatalErrorDuringRead => ResourceManager.GetString(getString_0(107364461), cultureInfo_0);

	public static string FatalErrorReadingResult => ResourceManager.GetString(getString_0(107364432), cultureInfo_0);

	public static string FileBasedCertificateNotSupported => ResourceManager.GetString(getString_0(107364399), cultureInfo_0);

	public static string FromAndLengthTooBig => ResourceManager.GetString(getString_0(107364322), cultureInfo_0);

	public static string FromIndexMustBeValid => ResourceManager.GetString(getString_0(107363781), cultureInfo_0);

	public static string GetHostEntryFailed => ResourceManager.GetString(getString_0(107363784), cultureInfo_0);

	public static string HardProcQuery => ResourceManager.GetString(getString_0(107363759), cultureInfo_0);

	public static string ImproperValueFormat => ResourceManager.GetString(getString_0(107363706), cultureInfo_0);

	public static string IncorrectTransmission => ResourceManager.GetString(getString_0(107363677), cultureInfo_0);

	public static string IndexAndLengthTooBig => ResourceManager.GetString(getString_0(107363648), cultureInfo_0);

	public static string IndexMustBeValid => ResourceManager.GetString(getString_0(107363619), cultureInfo_0);

	public static string InvalidColumnOrdinal => ResourceManager.GetString(getString_0(107363626), cultureInfo_0);

	public static string InvalidConnectionStringValue => ResourceManager.GetString(getString_0(107363597), cultureInfo_0);

	public static string InvalidMicrosecondValue => ResourceManager.GetString(getString_0(107364036), cultureInfo_0);

	public static string InvalidMillisecondValue => ResourceManager.GetString(getString_0(107364003), cultureInfo_0);

	public static string InvalidOptionWhenSslDisabled => ResourceManager.GetString(getString_0(107363970), cultureInfo_0);

	public static string InvalidProcName => ResourceManager.GetString(getString_0(107363929), cultureInfo_0);

	public static string InvalidValueForBoolean => ResourceManager.GetString(getString_0(107363908), cultureInfo_0);

	public static string KeywordNoNull => ResourceManager.GetString(getString_0(107363875), cultureInfo_0);

	public static string KeywordNotSupported => ResourceManager.GetString(getString_0(107363886), cultureInfo_0);

	public static string keywords => ResourceManager.GetString(getString_0(107363857), cultureInfo_0);

	public static string MixedParameterNamingNotAllowed => ResourceManager.GetString(getString_0(107363812), cultureInfo_0);

	public static string MoreThanOneOPRow => ResourceManager.GetString(getString_0(107363259), cultureInfo_0);

	public static string MultipleConnectionsInTransactionNotSupported => ResourceManager.GetString(getString_0(107363234), cultureInfo_0);

	public static string NamedPipeNoSeek => ResourceManager.GetString(getString_0(107363173), cultureInfo_0);

	public static string NamedPipeNoSetLength => ResourceManager.GetString(getString_0(107363184), cultureInfo_0);

	public static string NewValueShouldBeMySqlParameter => ResourceManager.GetString(getString_0(107363155), cultureInfo_0);

	public static string NextResultIsClosed => ResourceManager.GetString(getString_0(107363114), cultureInfo_0);

	public static string NoBodiesAndTypeNotSet => ResourceManager.GetString(getString_0(107363089), cultureInfo_0);

	public static string NoNestedTransactions => ResourceManager.GetString(getString_0(107363060), cultureInfo_0);

	public static string NoServerSSLSupport => ResourceManager.GetString(getString_0(107363543), cultureInfo_0);

	public static string NoUnixSocketsOnWindows => ResourceManager.GetString(getString_0(107363486), cultureInfo_0);

	public static string NoWindowsIdentity => ResourceManager.GetString(getString_0(107363453), cultureInfo_0);

	public static string ObjectDisposed => ResourceManager.GetString(getString_0(107363428), cultureInfo_0);

	public static string OffsetCannotBeNegative => ResourceManager.GetString(getString_0(107363439), cultureInfo_0);

	public static string OffsetMustBeValid => ResourceManager.GetString(getString_0(107363406), cultureInfo_0);

	public static string OldPasswordsNotSupported => ResourceManager.GetString(getString_0(107363381), cultureInfo_0);

	public static string OptionNotCurrentlySupported => ResourceManager.GetString(getString_0(107363348), cultureInfo_0);

	public static string ParameterAlreadyDefined => ResourceManager.GetString(getString_0(107363311), cultureInfo_0);

	public static string ParameterCannotBeNegative => ResourceManager.GetString(getString_0(107362766), cultureInfo_0);

	public static string ParameterCannotBeNull => ResourceManager.GetString(getString_0(107362729), cultureInfo_0);

	public static string ParameterIndexNotFound => ResourceManager.GetString(getString_0(107362700), cultureInfo_0);

	public static string ParameterIsInvalid => ResourceManager.GetString(getString_0(107362667), cultureInfo_0);

	public static string ParameterMustBeDefined => ResourceManager.GetString(getString_0(107362642), cultureInfo_0);

	public static string ParameterNotFoundDuringPrepare => ResourceManager.GetString(getString_0(107362609), cultureInfo_0);

	public static string ParameterNullOrEmpty => ResourceManager.GetString(getString_0(107362568), cultureInfo_0);

	public static string PasswordMustHaveLegalChars => ResourceManager.GetString(getString_0(107362539), cultureInfo_0);

	public static string PerfMonCategoryHelp => ResourceManager.GetString(getString_0(107362982), cultureInfo_0);

	public static string PerfMonCategoryName => ResourceManager.GetString(getString_0(107362985), cultureInfo_0);

	public static string PerfMonHardProcHelp => ResourceManager.GetString(getString_0(107362956), cultureInfo_0);

	public static string PerfMonHardProcName => ResourceManager.GetString(getString_0(107362927), cultureInfo_0);

	public static string PerfMonSoftProcHelp => ResourceManager.GetString(getString_0(107362898), cultureInfo_0);

	public static string PerfMonSoftProcName => ResourceManager.GetString(getString_0(107362869), cultureInfo_0);

	public static string ProcAndFuncSameName => ResourceManager.GetString(getString_0(107362808), cultureInfo_0);

	public static string QueryTooLarge => ResourceManager.GetString(getString_0(107362779), cultureInfo_0);

	public static string ReadFromStreamFailed => ResourceManager.GetString(getString_0(107362246), cultureInfo_0);

	public static string ReadingPriorColumnUsingSeqAccess => ResourceManager.GetString(getString_0(107362249), cultureInfo_0);

	public static string ReplicatedConnectionsAllowOnlyReadonlyStatements => ResourceManager.GetString(getString_0(107362172), cultureInfo_0);

	public static string Replication_ConnectionAttemptFailed => ResourceManager.GetString(getString_0(107362107), cultureInfo_0);

	public static string Replication_NoAvailableServer => ResourceManager.GetString(getString_0(107362090), cultureInfo_0);

	public static string ReplicationGroupNotFound => ResourceManager.GetString(getString_0(107362017), cultureInfo_0);

	public static string ReplicationServerNotFound => ResourceManager.GetString(getString_0(107362496), cultureInfo_0);

	public static string RoutineNotFound => ResourceManager.GetString(getString_0(107362459), cultureInfo_0);

	public static string RoutineRequiresReturnParameter => ResourceManager.GetString(getString_0(107362438), cultureInfo_0);

	public static string RSAPublicKeyRetrievalNotEnabled => ResourceManager.GetString(getString_0(107362397), cultureInfo_0);

	public static string ServerTooOld => ResourceManager.GetString(getString_0(107362384), cultureInfo_0);

	public static string SnapshotNotSupported => ResourceManager.GetString(getString_0(107362335), cultureInfo_0);

	public static string SocketNoSeek => ResourceManager.GetString(getString_0(107362306), cultureInfo_0);

	public static string SoftProcQuery => ResourceManager.GetString(getString_0(107362321), cultureInfo_0);

	public static string SPNotSupported => ResourceManager.GetString(getString_0(107362268), cultureInfo_0);

	public static string SslConnectionError => ResourceManager.GetString(getString_0(107361735), cultureInfo_0);

	public static string StreamAlreadyClosed => ResourceManager.GetString(getString_0(107361742), cultureInfo_0);

	public static string StreamNoRead => ResourceManager.GetString(getString_0(107361713), cultureInfo_0);

	public static string StreamNoWrite => ResourceManager.GetString(getString_0(107361664), cultureInfo_0);

	public static string Timeout => ResourceManager.GetString(getString_0(107361675), cultureInfo_0);

	public static string TimeoutGettingConnection => ResourceManager.GetString(getString_0(107361630), cultureInfo_0);

	public static string TraceCloseConnection => ResourceManager.GetString(getString_0(107361597), cultureInfo_0);

	public static string TraceErrorMoreThanMaxValueConnections => ResourceManager.GetString(getString_0(107361568), cultureInfo_0);

	public static string TraceFetchError => ResourceManager.GetString(getString_0(107361547), cultureInfo_0);

	public static string TraceOpenConnection => ResourceManager.GetString(getString_0(107361526), cultureInfo_0);

	public static string TraceOpenResultError => ResourceManager.GetString(getString_0(107361977), cultureInfo_0);

	public static string TraceQueryDone => ResourceManager.GetString(getString_0(107361948), cultureInfo_0);

	public static string TraceQueryNormalized => ResourceManager.GetString(getString_0(107361927), cultureInfo_0);

	public static string TraceQueryOpened => ResourceManager.GetString(getString_0(107361930), cultureInfo_0);

	public static string TraceResult => ResourceManager.GetString(getString_0(107361905), cultureInfo_0);

	public static string TraceResultClosed => ResourceManager.GetString(getString_0(107361856), cultureInfo_0);

	public static string TraceSetDatabase => ResourceManager.GetString(getString_0(107361831), cultureInfo_0);

	public static string TraceStatementClosed => ResourceManager.GetString(getString_0(107361838), cultureInfo_0);

	public static string TraceStatementExecuted => ResourceManager.GetString(getString_0(107361809), cultureInfo_0);

	public static string TraceStatementPrepared => ResourceManager.GetString(getString_0(107361776), cultureInfo_0);

	public static string TraceUAWarningBadIndex => ResourceManager.GetString(getString_0(107361231), cultureInfo_0);

	public static string TraceUAWarningFieldConversion => ResourceManager.GetString(getString_0(107361198), cultureInfo_0);

	public static string TraceUAWarningNoIndex => ResourceManager.GetString(getString_0(107361125), cultureInfo_0);

	public static string TraceUAWarningSkippedColumns => ResourceManager.GetString(getString_0(107361128), cultureInfo_0);

	public static string TraceUAWarningSkippedRows => ResourceManager.GetString(getString_0(107361055), cultureInfo_0);

	public static string TraceWarning => ResourceManager.GetString(getString_0(107361018), cultureInfo_0);

	public static string TypeIsNotCommandInterceptor => ResourceManager.GetString(getString_0(107361033), cultureInfo_0);

	public static string TypeIsNotExceptionInterceptor => ResourceManager.GetString(getString_0(107361476), cultureInfo_0);

	public static string UnableToConnectToHost => ResourceManager.GetString(getString_0(107361435), cultureInfo_0);

	public static string UnableToCreateAuthPlugin => ResourceManager.GetString(getString_0(107361406), cultureInfo_0);

	public static string UnableToDeriveParameters => ResourceManager.GetString(getString_0(107361373), cultureInfo_0);

	public static string UnableToEnableQueryAnalysis => ResourceManager.GetString(getString_0(107361340), cultureInfo_0);

	public static string UnableToEnumerateUDF => ResourceManager.GetString(getString_0(107361335), cultureInfo_0);

	public static string UnableToExecuteSP => ResourceManager.GetString(getString_0(107361274), cultureInfo_0);

	public static string UnableToParseFK => ResourceManager.GetString(getString_0(107361249), cultureInfo_0);

	public static string UnableToReadRSAKey => ResourceManager.GetString(getString_0(107361260), cultureInfo_0);

	public static string UnableToRetrieveParameters => ResourceManager.GetString(getString_0(107360723), cultureInfo_0);

	public static string UnableToStartSecondAsyncOp => ResourceManager.GetString(getString_0(107360686), cultureInfo_0);

	public static string UnixSocketsNotSupported => ResourceManager.GetString(getString_0(107360649), cultureInfo_0);

	public static string UnknownAuthenticationMethod => ResourceManager.GetString(getString_0(107360616), cultureInfo_0);

	public static string UnknownConnectionProtocol => ResourceManager.GetString(getString_0(107360547), cultureInfo_0);

	public static string ValueNotCorrectType => ResourceManager.GetString(getString_0(107360510), cultureInfo_0);

	public static string ValueNotSupportedForGuid => ResourceManager.GetString(getString_0(107360481), cultureInfo_0);

	public static string WinAuthNotSupportOnPlatform => ResourceManager.GetString(getString_0(107360960), cultureInfo_0);

	public static string WriteToStreamFailed => ResourceManager.GetString(getString_0(107360923), cultureInfo_0);

	public static string WrongParameterName => ResourceManager.GetString(getString_0(107360894), cultureInfo_0);

	internal Class121()
	{
	}

	static Class121()
	{
		Strings.CreateGetStringDelegate(typeof(Class121));
	}
}
