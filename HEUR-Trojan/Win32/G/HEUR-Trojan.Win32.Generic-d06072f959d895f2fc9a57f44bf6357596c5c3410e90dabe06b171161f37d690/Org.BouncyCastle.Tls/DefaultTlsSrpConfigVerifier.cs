using System.Collections;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls;

public class DefaultTlsSrpConfigVerifier : TlsSrpConfigVerifier
{
	private static readonly IList DefaultGroups;

	protected readonly IList m_groups;

	static DefaultTlsSrpConfigVerifier()
	{
		DefaultGroups = Platform.CreateArrayList();
		DefaultGroups.Add(Srp6StandardGroups.rfc5054_1024);
		DefaultGroups.Add(Srp6StandardGroups.rfc5054_1536);
		DefaultGroups.Add(Srp6StandardGroups.rfc5054_2048);
		DefaultGroups.Add(Srp6StandardGroups.rfc5054_3072);
		DefaultGroups.Add(Srp6StandardGroups.rfc5054_4096);
		DefaultGroups.Add(Srp6StandardGroups.rfc5054_6144);
		DefaultGroups.Add(Srp6StandardGroups.rfc5054_8192);
	}

	public DefaultTlsSrpConfigVerifier()
		: this(DefaultGroups)
	{
	}

	public DefaultTlsSrpConfigVerifier(IList groups)
	{
		m_groups = Platform.CreateArrayList(groups);
	}

	public virtual bool Accept(TlsSrpConfig srpConfig)
	{
		foreach (Srp6Group group in m_groups)
		{
			if (AreGroupsEqual(srpConfig, group))
			{
				return true;
			}
		}
		return false;
	}

	protected virtual bool AreGroupsEqual(TlsSrpConfig a, Srp6Group b)
	{
		BigInteger[] explicitNG = a.GetExplicitNG();
		if (AreParametersEqual(explicitNG[0], b.N))
		{
			return AreParametersEqual(explicitNG[1], b.G);
		}
		return false;
	}

	protected virtual bool AreParametersEqual(BigInteger a, BigInteger b)
	{
		if (a != b)
		{
			return a.Equals(b);
		}
		return true;
	}
}
