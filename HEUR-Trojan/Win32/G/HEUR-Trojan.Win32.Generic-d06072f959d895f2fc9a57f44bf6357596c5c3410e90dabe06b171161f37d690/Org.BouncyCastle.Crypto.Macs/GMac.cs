using System;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Macs;

public class GMac : IMac
{
	private readonly GcmBlockCipher cipher;

	private readonly int macSizeBits;

	public string AlgorithmName => cipher.GetUnderlyingCipher().AlgorithmName + "-GMAC";

	public GMac(GcmBlockCipher cipher)
		: this(cipher, 128)
	{
	}

	public GMac(GcmBlockCipher cipher, int macSizeBits)
	{
		this.cipher = cipher;
		this.macSizeBits = macSizeBits;
	}

	public void Init(ICipherParameters parameters)
	{
		if (!(parameters is ParametersWithIV))
		{
			throw new ArgumentException("GMAC requires ParametersWithIV");
		}
		ParametersWithIV obj = (ParametersWithIV)parameters;
		byte[] iV = obj.GetIV();
		KeyParameter key = (KeyParameter)obj.Parameters;
		cipher.Init(forEncryption: true, new AeadParameters(key, macSizeBits, iV));
	}

	public int GetMacSize()
	{
		return macSizeBits / 8;
	}

	public void Update(byte input)
	{
		cipher.ProcessAadByte(input);
	}

	public void BlockUpdate(byte[] input, int inOff, int len)
	{
		cipher.ProcessAadBytes(input, inOff, len);
	}

	public int DoFinal(byte[] output, int outOff)
	{
		try
		{
			return cipher.DoFinal(output, outOff);
		}
		catch (InvalidCipherTextException ex)
		{
			throw new InvalidOperationException(ex.ToString());
		}
	}

	public void Reset()
	{
		cipher.Reset();
	}
}
