using System;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;

namespace Org.BouncyCastle.Crypto.Fpe;

public class FpeFf1Engine : FpeEngine
{
	public FpeFf1Engine()
		: this(new AesEngine())
	{
	}

	public FpeFf1Engine(IBlockCipher baseCipher)
		: base(baseCipher)
	{
		if (FpeEngine.IsOverrideSet(SP80038G.FPE_DISABLED) || FpeEngine.IsOverrideSet(SP80038G.FF1_DISABLED))
		{
			throw new InvalidOperationException("FF1 encryption disabled");
		}
	}

	public override void Init(bool forEncryption, ICipherParameters parameters)
	{
		base.forEncryption = forEncryption;
		fpeParameters = (FpeParameters)parameters;
		baseCipher.Init(!fpeParameters.UseInverseFunction, fpeParameters.Key);
	}

	protected override int EncryptBlock(byte[] inBuf, int inOff, int length, byte[] outBuf, int outOff)
	{
		byte[] sourceArray;
		if (fpeParameters.Radix > 256)
		{
			if (((uint)length & (true ? 1u : 0u)) != 0)
			{
				throw new ArgumentException("input must be an even number of bytes for a wide radix");
			}
			ushort[] array = Pack.BE_To_UInt16(inBuf, inOff, length);
			ushort[] array2 = SP80038G.EncryptFF1w(baseCipher, fpeParameters.Radix, fpeParameters.GetTweak(), array, 0, array.Length);
			sourceArray = Pack.UInt16_To_BE(array2, 0, array2.Length);
		}
		else
		{
			sourceArray = SP80038G.EncryptFF1(baseCipher, fpeParameters.Radix, fpeParameters.GetTweak(), inBuf, inOff, length);
		}
		Array.Copy(sourceArray, 0, outBuf, outOff, length);
		return length;
	}

	protected override int DecryptBlock(byte[] inBuf, int inOff, int length, byte[] outBuf, int outOff)
	{
		byte[] sourceArray;
		if (fpeParameters.Radix > 256)
		{
			if (((uint)length & (true ? 1u : 0u)) != 0)
			{
				throw new ArgumentException("input must be an even number of bytes for a wide radix");
			}
			ushort[] array = Pack.BE_To_UInt16(inBuf, inOff, length);
			ushort[] array2 = SP80038G.DecryptFF1w(baseCipher, fpeParameters.Radix, fpeParameters.GetTweak(), array, 0, array.Length);
			sourceArray = Pack.UInt16_To_BE(array2, 0, array2.Length);
		}
		else
		{
			sourceArray = SP80038G.DecryptFF1(baseCipher, fpeParameters.Radix, fpeParameters.GetTweak(), inBuf, inOff, length);
		}
		Array.Copy(sourceArray, 0, outBuf, outOff, length);
		return length;
	}
}
