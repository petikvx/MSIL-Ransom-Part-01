using System.Collections.Generic;
using System.Configuration;
using System.Security.Principal;
using System.ServiceModel.Activation.Configuration;

namespace System.ServiceModel.Activation;

internal class NetTcpSectionData
{
	private int listenBacklog;

	private int maxPendingConnections;

	private int maxPendingAccepts;

	private TimeSpan receiveTimeout;

	private bool teredoEnabled;

	private List<SecurityIdentifier> allowAccounts;

	public int ListenBacklog => listenBacklog;

	public int MaxPendingConnections => maxPendingConnections;

	public int MaxPendingAccepts => maxPendingAccepts;

	public TimeSpan ReceiveTimeout => receiveTimeout;

	public bool TeredoEnabled => teredoEnabled;

	public List<SecurityIdentifier> AllowAccounts => allowAccounts;

	public NetTcpSectionData()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		NetTcpSection val = (NetTcpSection)ConfigurationManager.GetSection(ConfigurationStrings.get_NetTcpSectionPath());
		if (val == null)
		{
			throw DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)new InvalidOperationException());
		}
		listenBacklog = val.get_ListenBacklog();
		maxPendingConnections = val.get_MaxPendingConnections();
		maxPendingAccepts = val.get_MaxPendingAccepts();
		receiveTimeout = val.get_ReceiveTimeout();
		teredoEnabled = val.get_TeredoEnabled();
		allowAccounts = new List<SecurityIdentifier>();
		foreach (SecurityIdentifierElement item in (ConfigurationElementCollection)val.get_AllowAccounts())
		{
			SecurityIdentifierElement val2 = item;
			allowAccounts.Add(val2.get_SecurityIdentifier());
		}
	}
}
