using Renci.SshNet.Messages.Authentication;

namespace Renci.SshNet.Compression;

public class ZlibOpenSsh : Compressor
{
	public override string Name => "zlib@openssh.org";

	public override void Init(Session session)
	{
		base.Init(session);
		session.UserAuthenticationSuccessReceived += Session_UserAuthenticationSuccessReceived;
	}

	private void Session_UserAuthenticationSuccessReceived(object sender, MessageEventArgs<SuccessMessage> e)
	{
		base.IsActive = true;
		base.Session.UserAuthenticationSuccessReceived -= Session_UserAuthenticationSuccessReceived;
	}
}
