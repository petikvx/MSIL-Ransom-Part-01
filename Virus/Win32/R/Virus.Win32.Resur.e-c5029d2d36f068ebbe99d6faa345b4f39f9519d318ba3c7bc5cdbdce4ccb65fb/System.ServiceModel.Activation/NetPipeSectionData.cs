using System.Collections.Generic;
using System.Configuration;
using System.Security.Principal;
using System.ServiceModel.Activation.Configuration;

namespace System.ServiceModel.Activation;

internal class NetPipeSectionData
{
	private int maxPendingConnections;

	private int maxPendingAccepts;

	private TimeSpan receiveTimeout;

	private List<SecurityIdentifier> allowAccounts;

	public int MaxPendingConnections => maxPendingConnections;

	public int MaxPendingAccepts => maxPendingAccepts;

	public TimeSpan ReceiveTimeout => receiveTimeout;

	public List<SecurityIdentifier> AllowAccounts => allowAccounts;

	public NetPipeSectionData()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		NetPipeSection val = (NetPipeSection)ConfigurationManager.GetSection(ConfigurationStrings.get_NetPipeSectionPath());
		if (val == null)
		{
			throw DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)new InvalidOperationException());
		}
		maxPendingConnections = val.get_MaxPendingConnections();
		maxPendingAccepts = val.get_MaxPendingAccepts();
		receiveTimeout = val.get_ReceiveTimeout();
		allowAccounts = new List<SecurityIdentifier>();
		foreach (SecurityIdentifierElement item in (ConfigurationElementCollection)val.get_AllowAccounts())
		{
			SecurityIdentifierElement val2 = item;
			allowAccounts.Add(val2.get_SecurityIdentifier());
		}
	}
}
