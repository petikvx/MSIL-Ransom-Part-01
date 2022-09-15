using System;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Generators;

public class KdfFeedbackBytesGenerator : IDerivationFunction, IMacDerivationFunction
{
	private static readonly BigInteger IntegerMax = BigInteger.ValueOf(2147483647L);

	private static readonly BigInteger Two = BigInteger.Two;

	private readonly IMac prf;

	private readonly int h;

	private byte[] fixedInputData;

	private int maxSizeExcl;

	private byte[] ios;

	private byte[] iv;

	private bool useCounter;

	private int generatedBytes;

	private byte[] k;

	public IDigest Digest
	{
		get
		{
			if (!(prf is HMac))
			{
				return null;
			}
			return ((HMac)prf).GetUnderlyingDigest();
		}
	}

	public KdfFeedbackBytesGenerator(IMac prf)
	{
		this.prf = prf;
		h = prf.GetMacSize();
		k = new byte[h];
	}

	public void Init(IDerivationParameters parameters)
	{
		if (!(parameters is KdfFeedbackParameters kdfFeedbackParameters))
		{
			throw new ArgumentException("Wrong type of arguments given");
		}
		prf.Init(new KeyParameter(kdfFeedbackParameters.Ki));
		fixedInputData = kdfFeedbackParameters.FixedInputData;
		int r = kdfFeedbackParameters.R;
		ios = new byte[r / 8];
		if (kdfFeedbackParameters.UseCounter)
		{
			BigInteger bigInteger = Two.Pow(r).Multiply(BigInteger.ValueOf(h));
			maxSizeExcl = ((bigInteger.CompareTo(IntegerMax) == 1) ? int.MaxValue : bigInteger.IntValue);
		}
		else
		{
			maxSizeExcl = int.MaxValue;
		}
		iv = kdfFeedbackParameters.Iv;
		useCounter = kdfFeedbackParameters.UseCounter;
		generatedBytes = 0;
	}

	public int GenerateBytes(byte[] output, int outOff, int length)
	{
		int num = generatedBytes + length;
		if (num >= 0 && num < maxSizeExcl)
		{
			if (generatedBytes % h == 0)
			{
				generateNext();
			}
			int num2 = length;
			int sourceIndex = generatedBytes % h;
			int num3 = System.Math.Min(h - generatedBytes % h, num2);
			Array.Copy(k, sourceIndex, output, outOff, num3);
			generatedBytes += num3;
			num2 -= num3;
			outOff += num3;
			while (num2 > 0)
			{
				generateNext();
				num3 = System.Math.Min(h, num2);
				Array.Copy(k, 0, output, outOff, num3);
				generatedBytes += num3;
				num2 -= num3;
				outOff += num3;
			}
			return length;
		}
		throw new DataLengthException("Current KDFCTR may only be used for " + maxSizeExcl + " bytes");
	}

	private void generateNext()
	{
		if (generatedBytes == 0)
		{
			prf.BlockUpdate(iv, 0, iv.Length);
		}
		else
		{
			prf.BlockUpdate(k, 0, k.Length);
		}
		if (useCounter)
		{
			int num = generatedBytes / h + 1;
			switch (ios.Length)
			{
			default:
				throw new InvalidOperationException("Unsupported size of counter i");
			case 4:
				ios[0] = (byte)(num >> 24);
				goto case 3;
			case 3:
				ios[ios.Length - 3] = (byte)(num >> 16);
				goto case 2;
			case 2:
				ios[ios.Length - 2] = (byte)(num >> 8);
				break;
			case 1:
				break;
			}
			ios[ios.Length - 1] = (byte)num;
			prf.BlockUpdate(ios, 0, ios.Length);
		}
		prf.BlockUpdate(fixedInputData, 0, fixedInputData.Length);
		prf.DoFinal(k, 0);
	}

	public IMac GetMac()
	{
		return prf;
	}
}
