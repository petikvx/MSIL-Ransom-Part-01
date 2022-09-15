using System;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Encodings;

public class OaepEncoding : IAsymmetricBlockCipher
{
	private byte[] defHash;

	private IDigest mgf1Hash;

	private IAsymmetricBlockCipher engine;

	private SecureRandom random;

	private bool forEncryption;

	public string AlgorithmName => engine.AlgorithmName + "/OAEPPadding";

	public OaepEncoding(IAsymmetricBlockCipher cipher)
		: this(cipher, new Sha1Digest(), null)
	{
	}

	public OaepEncoding(IAsymmetricBlockCipher cipher, IDigest hash)
		: this(cipher, hash, null)
	{
	}

	public OaepEncoding(IAsymmetricBlockCipher cipher, IDigest hash, byte[] encodingParams)
		: this(cipher, hash, hash, encodingParams)
	{
	}

	public OaepEncoding(IAsymmetricBlockCipher cipher, IDigest hash, IDigest mgf1Hash, byte[] encodingParams)
	{
		engine = cipher;
		this.mgf1Hash = mgf1Hash;
		defHash = new byte[hash.GetDigestSize()];
		hash.Reset();
		if (encodingParams != null)
		{
			hash.BlockUpdate(encodingParams, 0, encodingParams.Length);
		}
		hash.DoFinal(defHash, 0);
	}

	public IAsymmetricBlockCipher GetUnderlyingCipher()
	{
		return engine;
	}

	public void Init(bool forEncryption, ICipherParameters param)
	{
		if (param is ParametersWithRandom)
		{
			ParametersWithRandom parametersWithRandom = (ParametersWithRandom)param;
			random = parametersWithRandom.Random;
		}
		else
		{
			random = new SecureRandom();
		}
		engine.Init(forEncryption, param);
		this.forEncryption = forEncryption;
	}

	public int GetInputBlockSize()
	{
		int inputBlockSize = engine.GetInputBlockSize();
		if (forEncryption)
		{
			return inputBlockSize - 1 - 2 * defHash.Length;
		}
		return inputBlockSize;
	}

	public int GetOutputBlockSize()
	{
		int outputBlockSize = engine.GetOutputBlockSize();
		if (forEncryption)
		{
			return outputBlockSize;
		}
		return outputBlockSize - 1 - 2 * defHash.Length;
	}

	public byte[] ProcessBlock(byte[] inBytes, int inOff, int inLen)
	{
		if (forEncryption)
		{
			return EncodeBlock(inBytes, inOff, inLen);
		}
		return DecodeBlock(inBytes, inOff, inLen);
	}

	private byte[] EncodeBlock(byte[] inBytes, int inOff, int inLen)
	{
		Check.DataLength(inLen > GetInputBlockSize(), "input data too long");
		byte[] array = new byte[GetInputBlockSize() + 1 + 2 * defHash.Length];
		Array.Copy(inBytes, inOff, array, array.Length - inLen, inLen);
		array[array.Length - inLen - 1] = 1;
		Array.Copy(defHash, 0, array, defHash.Length, defHash.Length);
		byte[] nextBytes = SecureRandom.GetNextBytes(random, defHash.Length);
		byte[] array2 = MaskGeneratorFunction(nextBytes, 0, nextBytes.Length, array.Length - defHash.Length);
		for (int i = defHash.Length; i != array.Length; i++)
		{
			array[i] ^= array2[i - defHash.Length];
		}
		Array.Copy(nextBytes, 0, array, 0, defHash.Length);
		array2 = MaskGeneratorFunction(array, defHash.Length, array.Length - defHash.Length, defHash.Length);
		for (int j = 0; j != defHash.Length; j++)
		{
			array[j] ^= array2[j];
		}
		return engine.ProcessBlock(array, 0, array.Length);
	}

	private byte[] DecodeBlock(byte[] inBytes, int inOff, int inLen)
	{
		byte[] array = engine.ProcessBlock(inBytes, inOff, inLen);
		byte[] array2 = new byte[engine.GetOutputBlockSize()];
		bool flag = array2.Length < 2 * defHash.Length + 1;
		if (array.Length <= array2.Length)
		{
			Array.Copy(array, 0, array2, array2.Length - array.Length, array.Length);
		}
		else
		{
			Array.Copy(array, 0, array2, 0, array2.Length);
			flag = true;
		}
		byte[] array3 = MaskGeneratorFunction(array2, defHash.Length, array2.Length - defHash.Length, defHash.Length);
		for (int i = 0; i != defHash.Length; i++)
		{
			array2[i] ^= array3[i];
		}
		array3 = MaskGeneratorFunction(array2, 0, defHash.Length, array2.Length - defHash.Length);
		for (int j = defHash.Length; j != array2.Length; j++)
		{
			array2[j] ^= array3[j - defHash.Length];
		}
		bool flag2 = false;
		for (int k = 0; k != defHash.Length; k++)
		{
			if (defHash[k] != array2[defHash.Length + k])
			{
				flag2 = true;
			}
		}
		int num = array2.Length;
		for (int l = 2 * defHash.Length; l != array2.Length; l++)
		{
			if ((array2[l] != 0) & (num == array2.Length))
			{
				num = l;
			}
		}
		bool flag3 = (num > array2.Length - 1) | (array2[num] != 1);
		num++;
		if (flag2 || flag || flag3)
		{
			Arrays.Fill(array2, 0);
			throw new InvalidCipherTextException("data wrong");
		}
		byte[] array4 = new byte[array2.Length - num];
		Array.Copy(array2, num, array4, 0, array4.Length);
		Array.Clear(array2, 0, array2.Length);
		return array4;
	}

	private byte[] MaskGeneratorFunction(byte[] Z, int zOff, int zLen, int length)
	{
		if (mgf1Hash is IXof)
		{
			byte[] array = new byte[length];
			mgf1Hash.BlockUpdate(Z, zOff, zLen);
			((IXof)mgf1Hash).DoFinal(array, 0, array.Length);
			return array;
		}
		return MaskGeneratorFunction1(Z, zOff, zLen, length);
	}

	private byte[] MaskGeneratorFunction1(byte[] Z, int zOff, int zLen, int length)
	{
		byte[] array = new byte[length];
		byte[] array2 = new byte[mgf1Hash.GetDigestSize()];
		byte[] array3 = new byte[4];
		int i = 0;
		mgf1Hash.Reset();
		for (; i < length / array2.Length; i++)
		{
			Pack.UInt32_To_BE((uint)i, array3);
			mgf1Hash.BlockUpdate(Z, zOff, zLen);
			mgf1Hash.BlockUpdate(array3, 0, array3.Length);
			mgf1Hash.DoFinal(array2, 0);
			Array.Copy(array2, 0, array, i * array2.Length, array2.Length);
		}
		if (i * array2.Length < length)
		{
			Pack.UInt32_To_BE((uint)i, array3);
			mgf1Hash.BlockUpdate(Z, zOff, zLen);
			mgf1Hash.BlockUpdate(array3, 0, array3.Length);
			mgf1Hash.DoFinal(array2, 0);
			Array.Copy(array2, 0, array, i * array2.Length, array.Length - i * array2.Length);
		}
		return array;
	}
}
