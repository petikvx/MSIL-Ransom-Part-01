using System;
using Renci.SshNet.Security.Org.BouncyCastle.Security;

namespace Renci.SshNet.Security.Org.BouncyCastle.Crypto;

internal class KeyGenerationParameters
{
	private SecureRandom random;

	private int strength;

	public SecureRandom Random => random;

	public int Strength => strength;

	public KeyGenerationParameters(SecureRandom random, int strength)
	{
		if (random == null)
		{
			throw new ArgumentNullException("random");
		}
		if (strength < 1)
		{
			throw new ArgumentException("strength must be a positive value", "strength");
		}
		this.random = random;
		this.strength = strength;
	}
}
