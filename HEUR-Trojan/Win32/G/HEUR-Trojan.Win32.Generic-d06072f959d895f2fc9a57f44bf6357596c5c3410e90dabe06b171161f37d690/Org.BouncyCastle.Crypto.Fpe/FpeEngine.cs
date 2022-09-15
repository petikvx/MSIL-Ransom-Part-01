using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Fpe;

public abstract class FpeEngine
{
	protected readonly IBlockCipher baseCipher;

	protected bool forEncryption;

	protected FpeParameters fpeParameters;

	protected FpeEngine(IBlockCipher baseCipher)
	{
		this.baseCipher = baseCipher;
	}

	public virtual int ProcessBlock(byte[] inBuf, int inOff, int length, byte[] outBuf, int outOff)
	{
		if (fpeParameters == null)
		{
			throw new InvalidOperationException("FPE engine not initialized");
		}
		if (length < 0)
		{
			throw new ArgumentException("cannot be negative", "length");
		}
		if (inBuf == null)
		{
			throw new ArgumentNullException("inBuf");
		}
		if (outBuf == null)
		{
			throw new ArgumentNullException("outBuf");
		}
		Check.DataLength(inBuf, inOff, length, "input buffer too short");
		Check.OutputLength(outBuf, outOff, length, "output buffer too short");
		if (forEncryption)
		{
			return EncryptBlock(inBuf, inOff, length, outBuf, outOff);
		}
		return DecryptBlock(inBuf, inOff, length, outBuf, outOff);
	}

	protected static bool IsOverrideSet(string propName)
	{
		string environmentVariable = Platform.GetEnvironmentVariable(propName);
		if (environmentVariable != null)
		{
			return Platform.EqualsIgnoreCase("true", environmentVariable);
		}
		return false;
	}

	public abstract void Init(bool forEncryption, ICipherParameters parameters);

	protected abstract int EncryptBlock(byte[] inBuf, int inOff, int length, byte[] outBuf, int outOff);

	protected abstract int DecryptBlock(byte[] inBuf, int inOff, int length, byte[] outBuf, int outOff);
}
