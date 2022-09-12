using System;

namespace Renci.SshNet.Security;

public class CertificateHostAlgorithm : HostAlgorithm
{
	public override byte[] Data
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public CertificateHostAlgorithm(string name)
		: base(name)
	{
	}

	public override byte[] Sign(byte[] data)
	{
		throw new NotImplementedException();
	}

	public override bool VerifySignature(byte[] data, byte[] signature)
	{
		throw new NotImplementedException();
	}
}
