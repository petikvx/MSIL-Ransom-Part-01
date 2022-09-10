using System;
using System.Collections;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using _003CPrivateImplementationDetails_003E_007B18A11B1C_002D3AA7_002D4357_002DAAD9_002DCC83BB5216E3_007D;

namespace MOISHE.Core;

public class EncryptionMetadata
{
	private static byte[] m_A = new byte[8] { 222, 254, 120, 252, 138, 126, 234, 249 };

	public const int METADATA_VERSION = 1;

	[CompilerGenerated]
	private byte[] a;

	[CompilerGenerated]
	private byte[] B;

	[CompilerGenerated]
	private byte[] b;

	[CompilerGenerated]
	private int m_A;

	public byte[] MagicValue => EncryptionMetadata.m_A;

	public byte[] EncryptedKey
	{
		[CompilerGenerated]
		get
		{
			return a;
		}
		[CompilerGenerated]
		set
		{
			a = value;
		}
	}

	public byte[] EncryptedIV
	{
		[CompilerGenerated]
		get
		{
			return B;
		}
		[CompilerGenerated]
		set
		{
			B = value;
		}
	}

	public byte[] PublicKey
	{
		[CompilerGenerated]
		get
		{
			return b;
		}
		[CompilerGenerated]
		set
		{
			b = value;
		}
	}

	public int EncryptedKeySize
	{
		get
		{
			byte[] encryptedKey = EncryptedKey;
			if (encryptedKey == null)
			{
				return 0;
			}
			return encryptedKey.Length;
		}
	}

	public int EncryptedIvSize
	{
		get
		{
			byte[] encryptedIV = EncryptedIV;
			if (encryptedIV == null)
			{
				return 0;
			}
			return encryptedIV.Length;
		}
	}

	public int PublicKeySize
	{
		get
		{
			byte[] publicKey = PublicKey;
			if (publicKey == null)
			{
				return 0;
			}
			return publicKey.Length;
		}
	}

	public int Limit
	{
		[CompilerGenerated]
		get
		{
			return this.m_A;
		}
		[CompilerGenerated]
		set
		{
			this.m_A = value;
		}
	}

	public int Version => 1;

	public int BufferSize => EncryptionMetadata.m_A.Length + 20 + EncryptedKeySize + EncryptedIvSize + PublicKeySize;

	public byte[] Serialized()
	{
		if (EncryptedKeySize != 0 && EncryptedIvSize != 0 && PublicKeySize != 0)
		{
			if (EncryptedIvSize != EncryptedKeySize)
			{
				throw new SerializationException(Class0.aM());
			}
			if (PublicKeySize < 256)
			{
				throw new SerializationException(Class0.am());
			}
			int num = EncryptionMetadata.m_A.Length + 20 + EncryptedKeySize + EncryptedIvSize + PublicKeySize;
			byte[] array = new byte[num];
			int num2 = 0;
			Array.Copy(EncryptionMetadata.m_A, 0, array, 0, EncryptionMetadata.m_A.Length);
			num2 = 0 + EncryptionMetadata.m_A.Length;
			num2 = A(1, array, num2);
			num2 = A(Limit, array, num2);
			num2 = A(EncryptedIvSize, array, num2);
			num2 = A(EncryptedKeySize, array, num2);
			num2 = A(PublicKeySize, array, num2);
			Array.Copy(EncryptedIV, 0, array, num2, EncryptedIvSize);
			num2 += EncryptedIvSize;
			Array.Copy(EncryptedKey, 0, array, num2, EncryptedKeySize);
			num2 += EncryptedKeySize;
			Array.Copy(PublicKey, 0, array, num2, PublicKeySize);
			return array;
		}
		throw new SerializationException(Class0.al());
	}

	private int A(int int_0, byte[] byte_0, int int_1)
	{
		byte[] bytes = BitConverter.GetBytes(int_0);
		int num = bytes.Length;
		Array.Copy(bytes, 0, byte_0, int_1, bytes.Length);
		return int_1 + num;
	}

	public static EncryptionMetadata Deserialize(byte[] buffer)
	{
		int num = EncryptionMetadata.m_A.Length + 20;
		if (buffer == null)
		{
			throw new SerializationException(Class0.aN());
		}
		if (buffer.Length <= num)
		{
			throw new SerializationException(Class0.an());
		}
		byte[] destinationArray = new byte[num];
		Array.Copy(buffer, destinationArray, num);
		if (!IsContainsMagic(buffer, 0))
		{
			throw new SerializationException(Class0.aO());
		}
		int num2 = EncryptionMetadata.m_A.Length;
		if (!IsVersionMatched(buffer, num2))
		{
			throw new SerializationException(Class0.ao());
		}
		num2 += 4;
		int limit = BitConverter.ToInt32(buffer, num2);
		num2 += 4;
		int num3 = A(buffer, num2);
		num2 += 4;
		int num4 = A(buffer, num2);
		num2 += 4;
		int num5 = A(buffer, num2);
		num2 += 4;
		byte[] array = new byte[num3];
		byte[] array2 = new byte[num4];
		byte[] array3 = new byte[num5];
		Array.Copy(buffer, num2, array, 0, num3);
		num2 += num3;
		Array.Copy(buffer, num2, array2, 0, num4);
		num2 += num4;
		Array.Copy(buffer, num2, array3, 0, num5);
		EncryptionMetadata encryptionMetadata = new EncryptionMetadata();
		encryptionMetadata.EncryptedKey = array2;
		encryptionMetadata.EncryptedIV = array;
		encryptionMetadata.PublicKey = array3;
		encryptionMetadata.Limit = limit;
		return encryptionMetadata;
	}

	public static bool IsContainsMagic(byte[] buffer, int offset)
	{
		int num = 0;
		while (true)
		{
			if (num < EncryptionMetadata.m_A.Length)
			{
				if (buffer[offset + num] != EncryptionMetadata.m_A[num])
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	public static bool IsVersionMatched(byte[] buffer, int offset)
	{
		int num = BitConverter.ToInt32(buffer, offset);
		return num == 1;
	}

	private static int A(byte[] byte_0, int int_0)
	{
		return BitConverter.ToInt32(byte_0, int_0);
	}

	public Session DecryptSession(byte[] PrivateKeyBuffer, int offset, int length)
	{
		byte[] array = new byte[length];
		Array.Copy(PrivateKeyBuffer, offset, array, 0, length);
		RSAParameters rSAParameters = ImportPrivateKey(array);
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
		rSACryptoServiceProvider.ImportParameters(rSAParameters);
		Session session = new Session(rSAParameters);
		session.IV = rSACryptoServiceProvider.Decrypt(EncryptedIV, fOAEP: false);
		session.DEK = rSACryptoServiceProvider.Decrypt(EncryptedKey, fOAEP: false);
		return session;
	}

	public bool IsPrivateKeyMatched(byte[] PrivateKeyBuffer, int offset, int length)
	{
		byte[] array = new byte[length];
		Array.Copy(PrivateKeyBuffer, offset, array, 0, length);
		RSAParameters rSAParameters = ImportPrivateKey(array);
		new RSACryptoServiceProvider();
		RSAParameters rSAParameters2 = KeyGenerator.ImportPublicKey(PublicKey);
		IStructuralEquatable exponent = rSAParameters2.Exponent;
		IStructuralEquatable exponent2 = rSAParameters.Exponent;
		IStructuralEquatable modulus = rSAParameters2.Modulus;
		IStructuralEquatable modulus2 = rSAParameters.Modulus;
		bool flag = exponent.Equals(exponent2, StructuralComparisons.StructuralEqualityComparer);
		bool flag2 = modulus.Equals(modulus2, StructuralComparisons.StructuralEqualityComparer);
		return flag && flag2;
	}

	public static RSAParameters ImportPrivateKey(byte[] der)
	{
		MemoryStream input = new MemoryStream(der);
		BinaryReader binaryReader = new BinaryReader(input);
		byte b = 0;
		ushort num = 0;
		int num2 = 0;
		try
		{
			num = binaryReader.ReadUInt16();
			if (num == 33072)
			{
				binaryReader.ReadByte();
			}
			else
			{
				if (num != 33328)
				{
					throw new CryptographicException(Class0.aP());
				}
				binaryReader.ReadInt16();
			}
			num = binaryReader.ReadUInt16();
			if (num != 258)
			{
				throw new CryptographicException(Class0.aP());
			}
			if (binaryReader.ReadByte() != 0)
			{
				throw new CryptographicException(Class0.aP());
			}
			num2 = A(binaryReader);
			byte[] modulus = binaryReader.ReadBytes(num2);
			num2 = A(binaryReader);
			byte[] exponent = binaryReader.ReadBytes(num2);
			num2 = A(binaryReader);
			byte[] d = binaryReader.ReadBytes(num2);
			num2 = A(binaryReader);
			byte[] p = binaryReader.ReadBytes(num2);
			num2 = A(binaryReader);
			byte[] q = binaryReader.ReadBytes(num2);
			num2 = A(binaryReader);
			byte[] dP = binaryReader.ReadBytes(num2);
			num2 = A(binaryReader);
			byte[] dQ = binaryReader.ReadBytes(num2);
			num2 = A(binaryReader);
			byte[] inverseQ = binaryReader.ReadBytes(num2);
			RSAParameters result = default(RSAParameters);
			result.Modulus = modulus;
			result.Exponent = exponent;
			result.D = d;
			result.P = p;
			result.Q = q;
			result.DP = dP;
			result.DQ = dQ;
			result.InverseQ = inverseQ;
			return result;
		}
		finally
		{
			binaryReader.Close();
		}
	}

	private static int A(BinaryReader binaryReader_0)
	{
		byte b = 0;
		byte b2 = 0;
		byte b3 = 0;
		int num = 0;
		b = binaryReader_0.ReadByte();
		if (b != 2)
		{
			return 0;
		}
		b = binaryReader_0.ReadByte();
		switch (b)
		{
		case 129:
			num = binaryReader_0.ReadByte();
			break;
		case 130:
		{
			b3 = binaryReader_0.ReadByte();
			b2 = binaryReader_0.ReadByte();
			byte[] value = new byte[4] { b2, b3, 0, 0 };
			num = BitConverter.ToInt32(value, 0);
			break;
		}
		default:
			num = b;
			break;
		}
		while (binaryReader_0.ReadByte() == 0)
		{
			num--;
		}
		binaryReader_0.BaseStream.Seek(-1L, SeekOrigin.Current);
		return num;
	}
}
