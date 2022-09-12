using System.Collections.Generic;
using Renci.SshNet.Messages.Authentication;

namespace Renci.SshNet;

internal interface IConnectionInfoInternal : IConnectionInfo
{
	IList<IAuthenticationMethod> AuthenticationMethods { get; }

	void UserAuthenticationBannerReceived(object sender, MessageEventArgs<BannerMessage> e);

	IAuthenticationMethod CreateNoneAuthenticationMethod();
}
