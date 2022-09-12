using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using Renci.SshNet.Common;
using Renci.SshNet.Security.Cryptography;

namespace Renci.SshNet.Security;

public class EcdsaKey : Key, IDisposable
{
	internal enum KeyBlobMagicNumber
	{
		BCRYPT_ECDSA_PUBLIC_P256_MAGIC = 827540293,
		BCRYPT_ECDSA_PRIVATE_P256_MAGIC = 844317509,
		BCRYPT_ECDSA_PUBLIC_P384_MAGIC = 861094725,
		BCRYPT_ECDSA_PRIVATE_P384_MAGIC = 877871941,
		BCRYPT_ECDSA_PUBLIC_P521_MAGIC = 894649157,
		BCRYPT_ECDSA_PRIVATE_P521_MAGIC = 911426373,
		BCRYPT_ECDH_PUBLIC_P256_MAGIC = 827016005,
		BCRYPT_ECDH_PRIVATE_P256_MAGIC = 843793221,
		BCRYPT_ECDH_PUBLIC_P384_MAGIC = 860570437,
		BCRYPT_ECDH_PRIVATE_P384_MAGIC = 877347653,
		BCRYPT_ECDH_PUBLIC_P521_MAGIC = 894124869,
		BCRYPT_ECDH_PRIVATE_P521_MAGIC = 910902085,
		BCRYPT_ECDH_PUBLIC_GENERIC_MAGIC = 1347109701,
		BCRYPT_ECDH_PRIVATE_GENERIC_MAGIC = 1447772997
	}

	internal struct BCRYPT_ECCKEY_BLOB
	{
		internal KeyBlobMagicNumber Magic;

		internal int cbKey;
	}

	internal const string ECDSA_P256_OID_VALUE = "1.2.840.10045.3.1.7";

	internal const string ECDSA_P384_OID_VALUE = "1.3.132.0.34";

	internal const string ECDSA_P521_OID_VALUE = "1.3.132.0.35";

	private CngKey key;

	private EcdsaDigitalSignature _digitalSignature;

	private bool _isDisposed;

	public CngAlgorithm HashAlgorithm => Ecdsa.KeySize switch
	{
		521 => CngAlgorithm.Sha512, 
		384 => CngAlgorithm.Sha384, 
		256 => CngAlgorithm.Sha256, 
		_ => throw new SshException("Unknown KeySize: " + Ecdsa.KeySize), 
	};

	public override int KeyLength => Ecdsa.KeySize;

	protected override DigitalSignature DigitalSignature
	{
		get
		{
			if (_digitalSignature == null)
			{
				_digitalSignature = new EcdsaDigitalSignature(this);
			}
			return _digitalSignature;
		}
	}

	public override BigInteger[] Public
	{
		get
		{
			KeyBlobMagicNumber keyBlobMagicNumber;
			byte[] array;
			byte[] array2;
			using (BinaryReader binaryReader = new BinaryReader(new MemoryStream(key.Export(CngKeyBlobFormat.EccPublicBlob))))
			{
				keyBlobMagicNumber = (KeyBlobMagicNumber)binaryReader.ReadInt32();
				int count = binaryReader.ReadInt32();
				array = binaryReader.ReadBytes(count);
				array2 = binaryReader.ReadBytes(count);
			}
			byte[] array3 = keyBlobMagicNumber switch
			{
				KeyBlobMagicNumber.BCRYPT_ECDSA_PUBLIC_P521_MAGIC => Encoding.ASCII.GetBytes("nistp521"), 
				KeyBlobMagicNumber.BCRYPT_ECDSA_PUBLIC_P384_MAGIC => Encoding.ASCII.GetBytes("nistp384"), 
				KeyBlobMagicNumber.BCRYPT_ECDSA_PUBLIC_P256_MAGIC => Encoding.ASCII.GetBytes("nistp256"), 
				_ => throw new SshException("Unexpected Curve Magic: " + keyBlobMagicNumber), 
			};
			byte[] array4 = new byte[1 + array.Length + array2.Length];
			Buffer.SetByte(array4, 0, 4);
			Buffer.BlockCopy(array, 0, array4, 1, array.Length);
			Buffer.BlockCopy(array2, 0, array4, array.Length + 1, array2.Length);
			return new BigInteger[2]
			{
				new BigInteger(array3.Reverse()),
				new BigInteger(array4.Reverse())
			};
		}
		set
		{
			string @string = Encoding.ASCII.GetString(value[0].ToByteArray().Reverse());
			string curveOid = GetCurveOid(@string);
			byte[] publickey = value[1].ToByteArray().Reverse();
			Import(curveOid, publickey, null);
		}
	}

	public ECDsa Ecdsa { get; private set; }

	public override string ToString()
	{
		return $"ecdsa-sha2-nistp{KeyLength}";
	}

	public EcdsaKey()
	{
	}

	public EcdsaKey(string curve, byte[] publickey, byte[] privatekey)
	{
		Import(GetCurveOid(curve), publickey, privatekey);
	}

	public EcdsaKey(byte[] data)
	{
		DerData derData = new DerData(data);
		derData.ReadBigInteger();
		byte[] privatekey = derData.ReadOctetString().TrimLeadingZeros();
		byte b = derData.ReadByte();
		if ((b & 0xE0) != 160)
		{
			throw new SshException($"UnexpectedDER: wanted constructed tag (0xa0-0xbf), got: {b:X}");
		}
		int num = b & 0x1F;
		if (num != 0)
		{
			throw new SshException($"expected tag 0 in DER privkey, got: {num}");
		}
		byte[] oid = new DerData(derData.ReadBytes(derData.ReadLength()), construct: true).ReadObject();
		b = derData.ReadByte();
		if ((b & 0xE0) != 160)
		{
			throw new SshException($"UnexpectedDER: wanted constructed tag (0xa0-0xbf), got: {b:X}");
		}
		num = b & 0x1F;
		if (num != 1)
		{
			throw new SshException($"expected tag 1 in DER privkey, got: {num}");
		}
		byte[] publickey = new DerData(derData.ReadBytes(derData.ReadLength()), construct: true).ReadBitString().TrimLeadingZeros();
		Import(OidByteArrayToString(oid), publickey, privatekey);
	}

	private void Import(string curve_oid, byte[] publickey, byte[] privatekey)
	{
		KeyBlobMagicNumber keyBlobMagicNumber = KeyBlobMagicNumber.BCRYPT_ECDH_PRIVATE_GENERIC_MAGIC;
		int num;
		byte[] array;
		byte[] array2;
		int num2;
		byte[] array3;
		switch (GetCurveName(curve_oid))
		{
		case "nistp521":
			keyBlobMagicNumber = ((privatekey == null) ? KeyBlobMagicNumber.BCRYPT_ECDSA_PUBLIC_P521_MAGIC : KeyBlobMagicNumber.BCRYPT_ECDSA_PRIVATE_P521_MAGIC);
			goto IL_007a;
		case "nistp384":
			keyBlobMagicNumber = ((privatekey == null) ? KeyBlobMagicNumber.BCRYPT_ECDSA_PUBLIC_P384_MAGIC : KeyBlobMagicNumber.BCRYPT_ECDSA_PRIVATE_P384_MAGIC);
			goto IL_007a;
		case "nistp256":
			keyBlobMagicNumber = ((privatekey == null) ? KeyBlobMagicNumber.BCRYPT_ECDSA_PUBLIC_P256_MAGIC : KeyBlobMagicNumber.BCRYPT_ECDSA_PRIVATE_P256_MAGIC);
			goto IL_007a;
		default:
			{
				throw new SshException("Unknown: " + curve_oid);
			}
			IL_007a:
			num = (publickey.Length - 1) / 2;
			array = new byte[num];
			Buffer.BlockCopy(publickey, 1, array, 0, array.Length);
			array2 = new byte[num];
			Buffer.BlockCopy(publickey, num + 1, array2, 0, array2.Length);
			if (privatekey != null)
			{
				privatekey = privatekey.Pad(num);
			}
			num2 = Marshal.SizeOf(typeof(BCRYPT_ECCKEY_BLOB)) + array.Length + array2.Length;
			if (privatekey != null)
			{
				num2 += privatekey.Length;
			}
			array3 = new byte[num2];
			using (BinaryWriter binaryWriter = new BinaryWriter(new MemoryStream(array3)))
			{
				binaryWriter.Write((int)keyBlobMagicNumber);
				binaryWriter.Write(num);
				binaryWriter.Write(array);
				binaryWriter.Write(array2);
				if (privatekey != null)
				{
					binaryWriter.Write(privatekey);
				}
			}
			key = CngKey.Import(array3, (privatekey == null) ? CngKeyBlobFormat.EccPublicBlob : CngKeyBlobFormat.EccPrivateBlob);
			Ecdsa = new ECDsaCng(key);
			break;
		}
	}

	private string GetCurveOid(string curve_s)
	{
		return curve_s.ToLower() switch
		{
			"nistp521" => "1.3.132.0.35", 
			"nistp384" => "1.3.132.0.34", 
			"nistp256" => "1.2.840.10045.3.1.7", 
			_ => throw new SshException("Unexpected Curve Name: " + curve_s), 
		};
	}

	private string GetCurveName(string oid)
	{
		return oid switch
		{
			"1.3.132.0.35" => "nistp521", 
			"1.3.132.0.34" => "nistp384", 
			"1.2.840.10045.3.1.7" => "nistp256", 
			_ => throw new SshException("Unexpected OID: " + oid), 
		};
	}

	private string OidByteArrayToString(byte[] oid)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < oid.Length; i++)
		{
			if (i == 0)
			{
				int num = (int)oid[0] % 40;
				int num2 = (oid[0] - num) / 40;
				stringBuilder.AppendFormat("{0}.{1}", num2, num);
			}
			else if (oid[i] < 128)
			{
				stringBuilder.AppendFormat(".{0}", oid[i]);
			}
			else
			{
				stringBuilder.AppendFormat(".{0}", (oid[i] - 128) * 128 + oid[i + 1]);
				i++;
			}
		}
		return stringBuilder.ToString();
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (!_isDisposed && disposing)
		{
			_isDisposed = true;
		}
	}

	~EcdsaKey()
	{
		Dispose(disposing: false);
	}
}
