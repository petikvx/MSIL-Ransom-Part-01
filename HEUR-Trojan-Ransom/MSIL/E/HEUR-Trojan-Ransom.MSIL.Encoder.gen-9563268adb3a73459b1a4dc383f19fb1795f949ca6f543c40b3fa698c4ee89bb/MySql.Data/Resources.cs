using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace MySql.Data;

[CompilerGenerated]
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
public class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static ResourceManager ResourceManager
	{
		get
		{
			if (resourceMan == null)
			{
				resourceMan = new ResourceManager("MySql.Data.Resources", typeof(Resources).Assembly);
			}
			return resourceMan;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static CultureInfo Culture
	{
		get
		{
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
		}
	}

	public static string AdapterIsNull => ResourceManager.GetString("AdapterIsNull", resourceCulture);

	public static string AdapterSelectIsNull => ResourceManager.GetString("AdapterSelectIsNull", resourceCulture);

	public static string AttemptToAccessBeforeRead => ResourceManager.GetString("AttemptToAccessBeforeRead", resourceCulture);

	public static string AuthenticationFailed => ResourceManager.GetString("AuthenticationFailed", resourceCulture);

	public static string AuthenticationMethodNotSupported => ResourceManager.GetString("AuthenticationMethodNotSupported", resourceCulture);

	public static string BadVersionFormat => ResourceManager.GetString("BadVersionFormat", resourceCulture);

	public static string BufferCannotBeNull => ResourceManager.GetString("BufferCannotBeNull", resourceCulture);

	public static string BufferNotLargeEnough => ResourceManager.GetString("BufferNotLargeEnough", resourceCulture);

	public static string CancelNeeds50 => ResourceManager.GetString("CancelNeeds50", resourceCulture);

	public static string CancelNotSupported => ResourceManager.GetString("CancelNotSupported", resourceCulture);

	public static string CanNotDeriveParametersForTextCommands => ResourceManager.GetString("CanNotDeriveParametersForTextCommands", resourceCulture);

	public static string CBMultiTableNotSupported => ResourceManager.GetString("CBMultiTableNotSupported", resourceCulture);

	public static string CBNoKeyColumn => ResourceManager.GetString("CBNoKeyColumn", resourceCulture);

	public static string ChaosNotSupported => ResourceManager.GetString("ChaosNotSupported", resourceCulture);

	public static string CommandTextNotInitialized => ResourceManager.GetString("CommandTextNotInitialized", resourceCulture);

	public static string CompressionNotSupported => ResourceManager.GetString("CompressionNotSupported", resourceCulture);

	public static string ConnectionAlreadyOpen => ResourceManager.GetString("ConnectionAlreadyOpen", resourceCulture);

	public static string ConnectionBroken => ResourceManager.GetString("ConnectionBroken", resourceCulture);

	public static string ConnectionMustBeOpen => ResourceManager.GetString("ConnectionMustBeOpen", resourceCulture);

	public static string ConnectionNotOpen => ResourceManager.GetString("ConnectionNotOpen", resourceCulture);

	public static string ConnectionNotSet => ResourceManager.GetString("ConnectionNotSet", resourceCulture);

	public static string CouldNotFindColumnName => ResourceManager.GetString("CouldNotFindColumnName", resourceCulture);

	public static string CountCannotBeNegative => ResourceManager.GetString("CountCannotBeNegative", resourceCulture);

	public static string CSNoSetLength => ResourceManager.GetString("CSNoSetLength", resourceCulture);

	public static string DataNotInSupportedFormat => ResourceManager.GetString("DataNotInSupportedFormat", resourceCulture);

	public static string DataReaderOpen => ResourceManager.GetString("DataReaderOpen", resourceCulture);

	public static string DefaultEncodingNotFound => ResourceManager.GetString("DefaultEncodingNotFound", resourceCulture);

	public static string DeprecatedSshAlgorithm => ResourceManager.GetString("DeprecatedSshAlgorithm", resourceCulture);

	public static string DistributedTxnNotSupported => ResourceManager.GetString("DistributedTxnNotSupported", resourceCulture);

	public static string DnsSrvInvalidConnOptionMultihost => ResourceManager.GetString("DnsSrvInvalidConnOptionMultihost", resourceCulture);

	public static string DnsSrvInvalidConnOptionPort => ResourceManager.GetString("DnsSrvInvalidConnOptionPort", resourceCulture);

	public static string DnsSrvInvalidConnOptionUnixSocket => ResourceManager.GetString("DnsSrvInvalidConnOptionUnixSocket", resourceCulture);

	public static string DnsSrvNoHostsAvailable => ResourceManager.GetString("DnsSrvNoHostsAvailable", resourceCulture);

	public static string DuplicatedConnectionOption => ResourceManager.GetString("DuplicatedConnectionOption", resourceCulture);

	public static string DuplicatedSslConnectionOption => ResourceManager.GetString("DuplicatedSslConnectionOption", resourceCulture);

	public static string EncodingError => ResourceManager.GetString("EncodingError", resourceCulture);

	public static string ErrorCreatingSocket => ResourceManager.GetString("ErrorCreatingSocket", resourceCulture);

	public static string ExecuteProcedureUnauthorized => ResourceManager.GetString("ExecuteProcedureUnauthorized", resourceCulture);

	public static string FatalErrorDuringExecute => ResourceManager.GetString("FatalErrorDuringExecute", resourceCulture);

	public static string FatalErrorDuringRead => ResourceManager.GetString("FatalErrorDuringRead", resourceCulture);

	public static string FatalErrorReadingResult => ResourceManager.GetString("FatalErrorReadingResult", resourceCulture);

	public static string FileBasedCertificateNotSupported => ResourceManager.GetString("FileBasedCertificateNotSupported", resourceCulture);

	public static string FileIsNotACertificate => ResourceManager.GetString("FileIsNotACertificate", resourceCulture);

	public static string FileIsNotAKey => ResourceManager.GetString("FileIsNotAKey", resourceCulture);

	public static string FileNotFound => ResourceManager.GetString("FileNotFound", resourceCulture);

	public static string FilePathNotSet => ResourceManager.GetString("FilePathNotSet", resourceCulture);

	public static string FromAndLengthTooBig => ResourceManager.GetString("FromAndLengthTooBig", resourceCulture);

	public static string FromIndexMustBeValid => ResourceManager.GetString("FromIndexMustBeValid", resourceCulture);

	public static string GetHostEntryFailed => ResourceManager.GetString("GetHostEntryFailed", resourceCulture);

	public static string HardProcQuery => ResourceManager.GetString("HardProcQuery", resourceCulture);

	public static string ImproperValueFormat => ResourceManager.GetString("ImproperValueFormat", resourceCulture);

	public static string IncorrectTransmission => ResourceManager.GetString("IncorrectTransmission", resourceCulture);

	public static string IndexAndLengthTooBig => ResourceManager.GetString("IndexAndLengthTooBig", resourceCulture);

	public static string IndexMustBeValid => ResourceManager.GetString("IndexMustBeValid", resourceCulture);

	public static string InvalidCertificateKey => ResourceManager.GetString("InvalidCertificateKey", resourceCulture);

	public static string InvalidColumnOrdinal => ResourceManager.GetString("InvalidColumnOrdinal", resourceCulture);

	public static string InvalidConnectionStringValue => ResourceManager.GetString("InvalidConnectionStringValue", resourceCulture);

	public static string InvalidHostNameOrAddress => ResourceManager.GetString("InvalidHostNameOrAddress", resourceCulture);

	public static string InvalidMicrosecondValue => ResourceManager.GetString("InvalidMicrosecondValue", resourceCulture);

	public static string InvalidMillisecondValue => ResourceManager.GetString("InvalidMillisecondValue", resourceCulture);

	public static string InvalidOptionWhenSslDisabled => ResourceManager.GetString("InvalidOptionWhenSslDisabled", resourceCulture);

	public static string InvalidProcName => ResourceManager.GetString("InvalidProcName", resourceCulture);

	public static string InvalidSslCertificate => ResourceManager.GetString("InvalidSslCertificate", resourceCulture);

	public static string InvalidSslCertificateSignature => ResourceManager.GetString("InvalidSslCertificateSignature", resourceCulture);

	public static string InvalidSslCertificateSignatureGeneral => ResourceManager.GetString("InvalidSslCertificateSignatureGeneral", resourceCulture);

	public static string InvalidSslMode => ResourceManager.GetString("InvalidSslMode", resourceCulture);

	public static string InvalidTlsVersionAndSslModeOption => ResourceManager.GetString("InvalidTlsVersionAndSslModeOption", resourceCulture);

	public static string InvalidTlsVersionOption => ResourceManager.GetString("InvalidTlsVersionOption", resourceCulture);

	public static string InvalidValueForBoolean => ResourceManager.GetString("InvalidValueForBoolean", resourceCulture);

	public static string KeywordNoNull => ResourceManager.GetString("KeywordNoNull", resourceCulture);

	public static string KeywordNotSupported => ResourceManager.GetString("KeywordNotSupported", resourceCulture);

	public static string keywords => ResourceManager.GetString("keywords", resourceCulture);

	public static string LocalInfileDisabled => ResourceManager.GetString("LocalInfileDisabled", resourceCulture);

	public static string MixedParameterNamingNotAllowed => ResourceManager.GetString("MixedParameterNamingNotAllowed", resourceCulture);

	public static string MoreThanOneOPRow => ResourceManager.GetString("MoreThanOneOPRow", resourceCulture);

	public static string MultipleConnectionsInTransactionNotSupported => ResourceManager.GetString("MultipleConnectionsInTransactionNotSupported", resourceCulture);

	public static string NamedPipeNoSeek => ResourceManager.GetString("NamedPipeNoSeek", resourceCulture);

	public static string NamedPipeNoSetLength => ResourceManager.GetString("NamedPipeNoSetLength", resourceCulture);

	public static string NewValueShouldBeMySqlParameter => ResourceManager.GetString("NewValueShouldBeMySqlParameter", resourceCulture);

	public static string NextResultIsClosed => ResourceManager.GetString("NextResultIsClosed", resourceCulture);

	public static string NoBodiesAndTypeNotSet => ResourceManager.GetString("NoBodiesAndTypeNotSet", resourceCulture);

	public static string NoNestedTransactions => ResourceManager.GetString("NoNestedTransactions", resourceCulture);

	public static string NoServerSSLSupport => ResourceManager.GetString("NoServerSSLSupport", resourceCulture);

	public static string NoUnixSocketsOnWindows => ResourceManager.GetString("NoUnixSocketsOnWindows", resourceCulture);

	public static string NoWindowsIdentity => ResourceManager.GetString("NoWindowsIdentity", resourceCulture);

	public static string ObjectDisposed => ResourceManager.GetString("ObjectDisposed", resourceCulture);

	public static string OffsetCannotBeNegative => ResourceManager.GetString("OffsetCannotBeNegative", resourceCulture);

	public static string OffsetMustBeValid => ResourceManager.GetString("OffsetMustBeValid", resourceCulture);

	public static string OldPasswordsNotSupported => ResourceManager.GetString("OldPasswordsNotSupported", resourceCulture);

	public static string OptionNotCurrentlySupported => ResourceManager.GetString("OptionNotCurrentlySupported", resourceCulture);

	public static string ParameterAlreadyDefined => ResourceManager.GetString("ParameterAlreadyDefined", resourceCulture);

	public static string ParameterCannotBeNegative => ResourceManager.GetString("ParameterCannotBeNegative", resourceCulture);

	public static string ParameterCannotBeNull => ResourceManager.GetString("ParameterCannotBeNull", resourceCulture);

	public static string ParameterCannotBeNullOrEmpty => ResourceManager.GetString("ParameterCannotBeNullOrEmpty", resourceCulture);

	public static string ParameterIndexNotFound => ResourceManager.GetString("ParameterIndexNotFound", resourceCulture);

	public static string ParameterIsInvalid => ResourceManager.GetString("ParameterIsInvalid", resourceCulture);

	public static string ParameterMustBeDefined => ResourceManager.GetString("ParameterMustBeDefined", resourceCulture);

	public static string ParameterNotFoundDuringPrepare => ResourceManager.GetString("ParameterNotFoundDuringPrepare", resourceCulture);

	public static string ParameterNullOrEmpty => ResourceManager.GetString("ParameterNullOrEmpty", resourceCulture);

	public static string PasswordMustHaveLegalChars => ResourceManager.GetString("PasswordMustHaveLegalChars", resourceCulture);

	public static string PerfMonCategoryHelp => ResourceManager.GetString("PerfMonCategoryHelp", resourceCulture);

	public static string PerfMonCategoryName => ResourceManager.GetString("PerfMonCategoryName", resourceCulture);

	public static string PerfMonHardProcHelp => ResourceManager.GetString("PerfMonHardProcHelp", resourceCulture);

	public static string PerfMonHardProcName => ResourceManager.GetString("PerfMonHardProcName", resourceCulture);

	public static string PerfMonSoftProcHelp => ResourceManager.GetString("PerfMonSoftProcHelp", resourceCulture);

	public static string PerfMonSoftProcName => ResourceManager.GetString("PerfMonSoftProcName", resourceCulture);

	public static string ProcAndFuncSameName => ResourceManager.GetString("ProcAndFuncSameName", resourceCulture);

	public static string QueryTooLarge => ResourceManager.GetString("QueryTooLarge", resourceCulture);

	public static string ReadFromStreamFailed => ResourceManager.GetString("ReadFromStreamFailed", resourceCulture);

	public static string ReadingPriorColumnUsingSeqAccess => ResourceManager.GetString("ReadingPriorColumnUsingSeqAccess", resourceCulture);

	public static string ReplicatedConnectionsAllowOnlyReadonlyStatements => ResourceManager.GetString("ReplicatedConnectionsAllowOnlyReadonlyStatements", resourceCulture);

	public static string Replication_ConnectionAttemptFailed => ResourceManager.GetString("Replication_ConnectionAttemptFailed", resourceCulture);

	public static string Replication_NoAvailableServer => ResourceManager.GetString("Replication_NoAvailableServer", resourceCulture);

	public static string ReplicationGroupNotFound => ResourceManager.GetString("ReplicationGroupNotFound", resourceCulture);

	public static string ReplicationServerNotFound => ResourceManager.GetString("ReplicationServerNotFound", resourceCulture);

	public static string RoutineNotFound => ResourceManager.GetString("RoutineNotFound", resourceCulture);

	public static string RoutineRequiresReturnParameter => ResourceManager.GetString("RoutineRequiresReturnParameter", resourceCulture);

	public static string RSAPublicKeyRetrievalNotEnabled => ResourceManager.GetString("RSAPublicKeyRetrievalNotEnabled", resourceCulture);

	public static string ServerTooOld => ResourceManager.GetString("ServerTooOld", resourceCulture);

	public static string SnapshotNotSupported => ResourceManager.GetString("SnapshotNotSupported", resourceCulture);

	public static string SocketNoSeek => ResourceManager.GetString("SocketNoSeek", resourceCulture);

	public static string SoftProcQuery => ResourceManager.GetString("SoftProcQuery", resourceCulture);

	public static string SPNotSupported => ResourceManager.GetString("SPNotSupported", resourceCulture);

	public static string SshAuthenticationModeNotSet => ResourceManager.GetString("SshAuthenticationModeNotSet", resourceCulture);

	public static string SshInvalidPassphrase => ResourceManager.GetString("SshInvalidPassphrase", resourceCulture);

	public static string SslCertificateCAMismatch => ResourceManager.GetString("SslCertificateCAMismatch", resourceCulture);

	public static string SslCertificateHostNameMismatch => ResourceManager.GetString("SslCertificateHostNameMismatch", resourceCulture);

	public static string SslCertificateIsNotCA => ResourceManager.GetString("SslCertificateIsNotCA", resourceCulture);

	public static string SslConnectionError => ResourceManager.GetString("SslConnectionError", resourceCulture);

	public static string StreamAlreadyClosed => ResourceManager.GetString("StreamAlreadyClosed", resourceCulture);

	public static string StreamNoRead => ResourceManager.GetString("StreamNoRead", resourceCulture);

	public static string StreamNoWrite => ResourceManager.GetString("StreamNoWrite", resourceCulture);

	public static string StringEmpty => ResourceManager.GetString("StringEmpty", resourceCulture);

	public static string Timeout => ResourceManager.GetString("Timeout", resourceCulture);

	public static string TimeoutGettingConnection => ResourceManager.GetString("TimeoutGettingConnection", resourceCulture);

	public static string TimeOutMultipleHost => ResourceManager.GetString("TimeOutMultipleHost", resourceCulture);

	public static string Tlsv13NotSupported => ResourceManager.GetString("Tlsv13NotSupported", resourceCulture);

	public static string TlsVersionNotSupported => ResourceManager.GetString("TlsVersionNotSupported", resourceCulture);

	public static string TraceCloseConnection => ResourceManager.GetString("TraceCloseConnection", resourceCulture);

	public static string TraceErrorMoreThanMaxValueConnections => ResourceManager.GetString("TraceErrorMoreThanMaxValueConnections", resourceCulture);

	public static string TraceFetchError => ResourceManager.GetString("TraceFetchError", resourceCulture);

	public static string TraceOpenConnection => ResourceManager.GetString("TraceOpenConnection", resourceCulture);

	public static string TraceOpenResultError => ResourceManager.GetString("TraceOpenResultError", resourceCulture);

	public static string TraceQueryDone => ResourceManager.GetString("TraceQueryDone", resourceCulture);

	public static string TraceQueryNormalized => ResourceManager.GetString("TraceQueryNormalized", resourceCulture);

	public static string TraceQueryOpened => ResourceManager.GetString("TraceQueryOpened", resourceCulture);

	public static string TraceResult => ResourceManager.GetString("TraceResult", resourceCulture);

	public static string TraceResultClosed => ResourceManager.GetString("TraceResultClosed", resourceCulture);

	public static string TraceSetDatabase => ResourceManager.GetString("TraceSetDatabase", resourceCulture);

	public static string TraceStatementClosed => ResourceManager.GetString("TraceStatementClosed", resourceCulture);

	public static string TraceStatementExecuted => ResourceManager.GetString("TraceStatementExecuted", resourceCulture);

	public static string TraceStatementPrepared => ResourceManager.GetString("TraceStatementPrepared", resourceCulture);

	public static string TraceUAWarningBadIndex => ResourceManager.GetString("TraceUAWarningBadIndex", resourceCulture);

	public static string TraceUAWarningFieldConversion => ResourceManager.GetString("TraceUAWarningFieldConversion", resourceCulture);

	public static string TraceUAWarningNoIndex => ResourceManager.GetString("TraceUAWarningNoIndex", resourceCulture);

	public static string TraceUAWarningSkippedColumns => ResourceManager.GetString("TraceUAWarningSkippedColumns", resourceCulture);

	public static string TraceUAWarningSkippedRows => ResourceManager.GetString("TraceUAWarningSkippedRows", resourceCulture);

	public static string TraceWarning => ResourceManager.GetString("TraceWarning", resourceCulture);

	public static string TypeIsNotCommandInterceptor => ResourceManager.GetString("TypeIsNotCommandInterceptor", resourceCulture);

	public static string TypeIsNotExceptionInterceptor => ResourceManager.GetString("TypeIsNotExceptionInterceptor", resourceCulture);

	public static string UnableToConnectToHost => ResourceManager.GetString("UnableToConnectToHost", resourceCulture);

	public static string UnableToCreateAuthPlugin => ResourceManager.GetString("UnableToCreateAuthPlugin", resourceCulture);

	public static string UnableToDeriveParameters => ResourceManager.GetString("UnableToDeriveParameters", resourceCulture);

	public static string UnableToEnableQueryAnalysis => ResourceManager.GetString("UnableToEnableQueryAnalysis", resourceCulture);

	public static string UnableToEnumerateUDF => ResourceManager.GetString("UnableToEnumerateUDF", resourceCulture);

	public static string UnableToExecuteSP => ResourceManager.GetString("UnableToExecuteSP", resourceCulture);

	public static string UnableToParseFK => ResourceManager.GetString("UnableToParseFK", resourceCulture);

	public static string UnableToReadRSAKey => ResourceManager.GetString("UnableToReadRSAKey", resourceCulture);

	public static string UnableToRetrieveParameters => ResourceManager.GetString("UnableToRetrieveParameters", resourceCulture);

	public static string UnableToStartSecondAsyncOp => ResourceManager.GetString("UnableToStartSecondAsyncOp", resourceCulture);

	public static string UnixSocketsNotSupported => ResourceManager.GetString("UnixSocketsNotSupported", resourceCulture);

	public static string UnknownAuthenticationMethod => ResourceManager.GetString("UnknownAuthenticationMethod", resourceCulture);

	public static string UnknownConnectionProtocol => ResourceManager.GetString("UnknownConnectionProtocol", resourceCulture);

	public static string ValueNotCorrectType => ResourceManager.GetString("ValueNotCorrectType", resourceCulture);

	public static string ValueNotSupportedForGuid => ResourceManager.GetString("ValueNotSupportedForGuid", resourceCulture);

	public static string WinAuthNotSupportOnPlatform => ResourceManager.GetString("WinAuthNotSupportOnPlatform", resourceCulture);

	public static string WriteToStreamFailed => ResourceManager.GetString("WriteToStreamFailed", resourceCulture);

	public static string WrongParameterName => ResourceManager.GetString("WrongParameterName", resourceCulture);

	internal Resources()
	{
	}
}
