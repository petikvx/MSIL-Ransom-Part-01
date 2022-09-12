namespace Renci.SshNet;

public static class RemotePathTransformation
{
	private static readonly IRemotePathTransformation ShellQuoteTransformation = new RemotePathShellQuoteTransformation();

	private static readonly IRemotePathTransformation NoneTransformation = new RemotePathNoneTransformation();

	private static readonly IRemotePathTransformation DoubleQuoteTransformation = new RemotePathDoubleQuoteTransformation();

	public static IRemotePathTransformation ShellQuote => ShellQuoteTransformation;

	public static IRemotePathTransformation None => NoneTransformation;

	public static IRemotePathTransformation DoubleQuote => DoubleQuoteTransformation;
}
