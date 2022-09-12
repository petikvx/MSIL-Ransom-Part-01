using System;
using System.Collections.Generic;
using System.Text;
using Renci.SshNet.Common;
using Renci.SshNet.Messages.Connection;

namespace Renci.SshNet;

internal interface IConnectionInfo
{
	IDictionary<string, RequestInfo> ChannelRequests { get; }

	Encoding Encoding { get; }

	int RetryAttempts { get; }

	TimeSpan Timeout { get; }

	event EventHandler<AuthenticationBannerEventArgs> AuthenticationBanner;
}
