namespace Renci.SshNet.Common;

public class AuthenticationPasswordChangeEventArgs : AuthenticationEventArgs
{
	public byte[] NewPassword { get; set; }

	public AuthenticationPasswordChangeEventArgs(string username)
		: base(username)
	{
	}
}
