using System;
using DevDefined.OAuth.Framework;

namespace DevDefined.OAuth;

public class GuidNonceGenerator : INonceGenerator
{
	protected Random random = new Random();

	public string GenerateNonce(IOAuthContext context)
	{
		return Guid.NewGuid().ToString();
	}
}
