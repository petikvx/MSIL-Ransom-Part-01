namespace Re5w5ke;

internal interface IAuthenticationTelemetryModel
{
	string AuthenticationType { get; }

	string AuthenticationSubType { get; }

	bool? AllowDirectoryAccess { get; }
}
