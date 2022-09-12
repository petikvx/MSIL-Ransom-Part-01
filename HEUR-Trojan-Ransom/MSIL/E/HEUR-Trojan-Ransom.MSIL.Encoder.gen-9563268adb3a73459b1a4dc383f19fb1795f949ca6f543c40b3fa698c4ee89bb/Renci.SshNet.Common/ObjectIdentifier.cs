using System;

namespace Renci.SshNet.Common;

public struct ObjectIdentifier
{
	public ulong[] Identifiers { get; private set; }

	public ObjectIdentifier(params ulong[] identifiers)
	{
		this = default(ObjectIdentifier);
		if (identifiers.Length < 2)
		{
			throw new ArgumentException("identifiers");
		}
		Identifiers = identifiers;
	}
}
