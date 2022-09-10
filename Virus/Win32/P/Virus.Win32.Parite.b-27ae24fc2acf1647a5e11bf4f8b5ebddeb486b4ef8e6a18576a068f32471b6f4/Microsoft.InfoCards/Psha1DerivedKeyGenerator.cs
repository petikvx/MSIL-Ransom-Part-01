using System;
using System.Security.Cryptography;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal sealed class Psha1DerivedKeyGenerator
{
	private sealed class ManagedPsha1
	{
		private byte[] aValue;

		private byte[] buffer;

		private byte[] chunk;

		private KeyedHashAlgorithm hmac;

		private int index;

		private int position;

		private byte[] secret;

		private byte[] seed;

		public ManagedPsha1(byte[] secret, byte[] label, byte[] seed)
		{
			this.secret = secret;
			checked
			{
				this.seed = new byte[label.Length + seed.Length];
				label.CopyTo(this.seed, 0);
				seed.CopyTo(this.seed, label.Length);
				aValue = this.seed;
				chunk = new byte[0];
				index = 0;
				position = 0;
				hmac = new HMACSHA1(secret, useManagedSha1: true);
				buffer = new byte[unchecked(hmac.HashSize / 8) + this.seed.Length];
			}
		}

		public byte[] GetDerivedKey(int derivedKeySize, int position)
		{
			if (derivedKeySize < 0)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)new ArgumentOutOfRangeException("derivedKeySize", SR.GetString("ValueMustBeNonNegative")));
			}
			if (this.position > position)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)new ArgumentOutOfRangeException("position", SR.GetString("ValueMustBeInRange", new object[2] { 0, this.position })));
			}
			while (this.position < position)
			{
				GetByte();
			}
			int num = derivedKeySize / 8;
			byte[] array = new byte[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = GetByte();
			}
			return array;
		}

		private byte GetByte()
		{
			if (index >= chunk.Length)
			{
				hmac.Initialize();
				aValue = hmac.ComputeHash(aValue);
				aValue.CopyTo(buffer, 0);
				seed.CopyTo(buffer, aValue.Length);
				hmac.Initialize();
				chunk = hmac.ComputeHash(buffer);
				index = 0;
			}
			position++;
			return chunk[index++];
		}
	}

	private byte[] key;

	public Psha1DerivedKeyGenerator(byte[] key)
	{
		if (key == null)
		{
			throw InfoCardTrace.ThrowHelperArgumentNull("key");
		}
		this.key = key;
	}

	public byte[] GenerateDerivedKey(byte[] label, byte[] nonce, int derivedKeySize, int position)
	{
		if (label == null)
		{
			throw InfoCardTrace.ThrowHelperArgumentNull("label");
		}
		if (nonce == null)
		{
			throw InfoCardTrace.ThrowHelperArgumentNull("nonce");
		}
		ManagedPsha1 managedPsha = new ManagedPsha1(key, label, nonce);
		return managedPsha.GetDerivedKey(derivedKeySize, position);
	}
}
