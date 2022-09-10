namespace Microsoft.Tools.ServiceModel.WsatConfig;

internal enum WsatAdminErrorCode
{
	SUCCESS,
	UNEXPECTED_ERROR,
	CANNOT_GET_MSDTC_NETWORK_ACCESS_SETTING,
	MSDTC_NETWORK_ACCESS_DENIED,
	MSDTC_NETWORK_ACCESS_DISABLED,
	INVALID_HTTPS_PORT,
	INVALID_OR_MISSING_SSL_CERTIFICATE,
	INVALID_OR_MISSING_CLIENT_CERTIFICATE,
	INVALID_DEF_TIMEOUT,
	INVALID_MAX_TIMEOUT,
	REGISTRY_ACCESS,
	REGISTRY_WRITE,
	CERT_STORE_ACCESS,
	REGISTER_HTTPS_PORT,
	UNREGISTER_HTTPS_PORT,
	REGISTER_HTTPS_PORT_ALREADYEXISTS,
	HTTPS_PORT_SSL_CERT_BINDING,
	HTTPS_PORT_SSL_CERT_UNBINDING,
	HTTPS_PORT_SSL_CERT_BINDING_ALREADYEXISTS,
	DTC_RESTART_ERROR,
	CANNOT_GET_REMOTE_INSTALL_PATH,
	REMOTE_TIMEOUT,
	REMOTE_MISSING_WSAT,
	REMOTE_EXECUTION_ATTEMPT_ERROR,
	REMOTE_EXECUTION_ERROR,
	WMI_IS_NOT_AVAILABLE,
	INVALID_ARGUMENT,
	INVALID_ACCOUNT,
	INVALID_NETWORK_ARGUMENT,
	INVALID_MAXTIMEOUT_ARGUMENT,
	INVALID_DEFTIMEOUT_ARGUMENT,
	INVALID_TRACELEVEL_ARGUMENT,
	INVALID_TRACE_ACTIVITY_ARGUMENT,
	INVALID_TRACE_PROPAGATION_ARGUMENT,
	INVALID_TRACE_PII_ARGUMENT,
	INVALID_CLUSTER_REMOTE_NODE_ARGUMENT,
	INVALID_CLUSTER_VIRTUAL_SERVER_ARGUMENT,
	CANNOT_FIND_MACHINE_CERTIFICATE,
	FIREWALL_ACCESS_DENIED,
	UNEXPECTED_FIREWALL_CONFIG_ERROR,
	CANNOT_UPDATE_PRIVATE_KEY_PERM,
	WRONG_WCF_INSTALLED,
	DUPLICATE_OPTION,
	CANNOT_UPDATE_SETTINGS_WHEN_NETWORK_IS_DISABLED,
	CANNOT_ENABLE_NETWORK_SUPPORT_WHEN_QFE_IS_NOT_INSTALLED,
	CANNOT_FIND_CLUSTER_VIRTUAL_SERVER,
	ETW_SESSION_ERROR,
	ETW_SESSION_ACCESS_DENIED,
	ETW_SESSION_BAD_PATHNAME,
	ETW_SESSION_DISK_FULL,
	ETW_SESSION_ALREADY_EXISTS,
	ETW_SESSION_FILE_NOT_FOUND,
	ETW_SESSION_PATH_NOT_FOUND,
	ETW_SESSION_BACKUPFILE_ERROR,
	ETW_SESSION_INVALID_LOGFILESIZE,
	ETW_SESSION_TOO_LONG_LOGFILE_NAME,
	ETW_SESSION_INVALID_LOGFILE_NAME
}