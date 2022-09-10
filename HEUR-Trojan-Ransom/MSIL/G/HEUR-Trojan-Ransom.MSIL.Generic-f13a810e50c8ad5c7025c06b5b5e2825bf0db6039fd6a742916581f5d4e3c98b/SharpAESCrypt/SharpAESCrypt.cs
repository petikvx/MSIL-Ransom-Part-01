using System;
using System.Collections.Generic;
using System.IO;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;

namespace SharpAESCrypt;

public class SharpAESCrypt : Stream
{
	private class Class0 : IDisposable
	{
		private static readonly byte[] byte_0 = new byte[8] { 1, 35, 69, 103, 137, 171, 205, 239 };

		private const string string_0 = "SHA-256";

		private const string string_1 = "Rijndael";

		private const string string_2 = "SHA1PRNG";

		private const string string_3 = "HmacSHA256";

		private const string string_4 = "utf-16";

		private SymmetricAlgorithm symmetricAlgorithm_0;

		private HashAlgorithm hashAlgorithm_0;

		private RandomNumberGenerator randomNumberGenerator_0;

		private HMAC hmac_0;

		private byte[] byte_1;

		private byte[] byte_2;

		private byte[] byte_3;

		private byte[] byte_4;

		public byte[] IV1 => byte_1;

		public Class0(OperationMode mode, string password, byte[] iv)
		{
			symmetricAlgorithm_0 = SymmetricAlgorithm.Create("Rijndael");
			symmetricAlgorithm_0.Padding = PaddingMode.None;
			symmetricAlgorithm_0.Mode = CipherMode.CBC;
			hashAlgorithm_0 = HashAlgorithm.Create("SHA-256");
			randomNumberGenerator_0 = RandomNumberGenerator.Create();
			hmac_0 = HMAC.Create("HmacSHA256");
			if (mode == OperationMode.Encrypt)
			{
				byte_1 = GenerateIv1();
				byte_2 = GenerateAESKey1(EncodePassword(password));
				byte_3 = GenerateIv2();
				byte_4 = GenerateAESKey2();
			}
			else
			{
				byte_1 = iv;
				byte_2 = GenerateAESKey1(EncodePassword(password));
			}
		}

		private byte[] EncodePassword(string password)
		{
			Encoding encoding = Encoding.GetEncoding("utf-16");
			byte[] array = encoding?.GetPreamble();
			if (array == null || array.Length != 2)
			{
				throw new SystemException(Strings.EncodingNotSupported);
			}
			if (array[0] == byte.MaxValue && array[1] == 254)
			{
				return encoding.GetBytes(password);
			}
			if (array[0] == 254 && array[1] == byte.MaxValue)
			{
				byte[] bytes = encoding.GetBytes(password);
				if (bytes.Length % 2 != 0)
				{
					throw new SystemException(Strings.EncodingNotSupported);
				}
				for (int i = 0; i < bytes.Length; i += 2)
				{
					byte b = bytes[i];
					bytes[i] = bytes[i + 1];
					bytes[i + 1] = b;
				}
				return bytes;
			}
			throw new SystemException(Strings.EncodingNotSupported);
		}

		private byte[] GenerateIv1()
		{
			byte[] array = new byte[16];
			long ticks = DateTime.Now.Ticks;
			byte[] array2 = null;
			try
			{
				NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
				for (int i = 0; i < allNetworkInterfaces.Length; i++)
				{
					if (i != NetworkInterface.LoopbackInterfaceIndex)
					{
						array2 = allNetworkInterfaces[i].GetPhysicalAddress().GetAddressBytes();
						break;
					}
				}
			}
			catch
			{
			}
			if (array2 == null)
			{
				array2 = byte_0;
			}
			for (int j = 0; j < 8; j++)
			{
				array[j] = (byte)((ulong)(ticks >> j * 8) & 0xFFuL);
			}
			Array.Copy(array2, 0, array, 8, Math.Min(array2.Length, array.Length - 8));
			return DigestRandomBytes(array, 256);
		}

		private byte[] GenerateAESKey1(byte[] password)
		{
			if (!hashAlgorithm_0.CanReuseTransform)
			{
				throw new CryptographicException(Strings.UnsupportedHashAlgorithmReuse);
			}
			if (!hashAlgorithm_0.CanTransformMultipleBlocks)
			{
				throw new CryptographicException(Strings.UnsupportedHashAlgorithmBlocks);
			}
			if (32 < hashAlgorithm_0.HashSize / 8)
			{
				throw new CryptographicException(string.Format(Strings.UnsupportedHashAlgorithmBlocksize, 32, hashAlgorithm_0.HashSize / 8));
			}
			byte[] array = new byte[32];
			Array.Copy(byte_1, array, byte_1.Length);
			for (int i = 0; i < 8192; i++)
			{
				hashAlgorithm_0.Initialize();
				hashAlgorithm_0.TransformBlock(array, 0, array.Length, array, 0);
				hashAlgorithm_0.TransformFinalBlock(password, 0, password.Length);
				array = hashAlgorithm_0.Hash;
			}
			return array;
		}

		private byte[] GenerateIv2()
		{
			symmetricAlgorithm_0.GenerateIV();
			return DigestRandomBytes(symmetricAlgorithm_0.IV, 256);
		}

		private byte[] GenerateAESKey2()
		{
			symmetricAlgorithm_0.GenerateKey();
			return DigestRandomBytes(symmetricAlgorithm_0.Key, 32);
		}

		public byte[] EncryptAESKey2()
		{
			using MemoryStream memoryStream = new MemoryStream();
			using CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm_0.CreateEncryptor(byte_2, byte_1), CryptoStreamMode.Write);
			cryptoStream.Write(byte_3, 0, byte_3.Length);
			cryptoStream.Write(byte_4, 0, byte_4.Length);
			cryptoStream.FlushFinalBlock();
			return memoryStream.ToArray();
		}

		public byte[] CalculateKeyHmac()
		{
			hmac_0.Initialize();
			hmac_0.Key = byte_2;
			return hmac_0.ComputeHash(EncryptAESKey2());
		}

		private byte[] DigestRandomBytes(byte[] bytes, int repetitions)
		{
			if (bytes.Length > hashAlgorithm_0.HashSize / 8)
			{
				throw new CryptographicException(string.Format(Strings.UnsupportedHashAlgorithmBlocksize, bytes.Length, hashAlgorithm_0.HashSize / 8));
			}
			if (!hashAlgorithm_0.CanReuseTransform)
			{
				throw new CryptographicException(Strings.UnsupportedHashAlgorithmReuse);
			}
			if (!hashAlgorithm_0.CanTransformMultipleBlocks)
			{
				throw new CryptographicException(Strings.UnsupportedHashAlgorithmBlocks);
			}
			hashAlgorithm_0.Initialize();
			hashAlgorithm_0.TransformBlock(bytes, 0, bytes.Length, bytes, 0);
			for (int i = 0; i < repetitions; i++)
			{
				randomNumberGenerator_0.GetBytes(bytes);
				hashAlgorithm_0.TransformBlock(bytes, 0, bytes.Length, bytes, 0);
			}
			hashAlgorithm_0.TransformFinalBlock(bytes, 0, 0);
			Array.Copy(hashAlgorithm_0.Hash, bytes, bytes.Length);
			return bytes;
		}

		public ICryptoTransform CreateCryptoStream(OperationMode mode)
		{
			if (mode == OperationMode.Encrypt)
			{
				return symmetricAlgorithm_0.CreateEncryptor(byte_4, byte_3);
			}
			return symmetricAlgorithm_0.CreateDecryptor(byte_4, byte_3);
		}

		public HMAC GetHMAC()
		{
			HMAC hMAC = HMAC.Create("HmacSHA256");
			hMAC.Key = byte_4;
			return hMAC;
		}

		public byte[] DecryptAESKey2(byte[] data)
		{
			using (MemoryStream stream = new MemoryStream(data))
			{
				using CryptoStream stream2 = new CryptoStream(stream, symmetricAlgorithm_0.CreateDecryptor(byte_2, byte_1), CryptoStreamMode.Read);
				byte_3 = RepeatRead(stream2, 16);
				byte_4 = RepeatRead(stream2, 32);
			}
			hmac_0.Initialize();
			hmac_0.Key = byte_2;
			hmac_0.TransformFinalBlock(data, 0, data.Length);
			return hmac_0.Hash;
		}

		public void SetBulkKeyToKey1()
		{
			byte_3 = byte_1;
			byte_4 = byte_2;
		}

		public void Dispose()
		{
			if (symmetricAlgorithm_0 != null)
			{
				if (byte_2 != null)
				{
					Array.Clear(byte_2, 0, byte_2.Length);
				}
				if (byte_1 != null)
				{
					Array.Clear(byte_1, 0, byte_1.Length);
				}
				if (byte_4 != null)
				{
					Array.Clear(byte_4, 0, byte_4.Length);
				}
				if (byte_3 != null)
				{
					Array.Clear(byte_3, 0, byte_3.Length);
				}
				byte_2 = null;
				byte_1 = null;
				byte_4 = null;
				byte_3 = null;
				hashAlgorithm_0 = null;
				hmac_0 = null;
				randomNumberGenerator_0 = null;
				symmetricAlgorithm_0 = null;
			}
		}
	}

	private class Stream0 : Stream
	{
		private Stream stream_0;

		private int int_0;

		public override bool CanRead => stream_0.CanRead;

		public override bool CanSeek => stream_0.CanSeek;

		public override bool CanWrite => stream_0.CanWrite;

		public override long Length => stream_0.Length;

		public override long Position
		{
			get
			{
				return stream_0.Position;
			}
			set
			{
				stream_0.Position = value;
			}
		}

		public Stream0(Stream stream, int count)
		{
			stream_0 = stream;
			int_0 = count;
		}

		public override void Flush()
		{
			stream_0.Flush();
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			return stream_0.Seek(offset, origin);
		}

		public override void SetLength(long value)
		{
			stream_0.SetLength(value);
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
			stream_0.Write(buffer, offset, count);
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			long num = Math.Max(0L, Math.Min(count, stream_0.Length - (stream_0.Position + int_0)));
			if (num == 0L)
			{
				return 0;
			}
			return stream_0.Read(buffer, offset, (int)num);
		}
	}

	private readonly byte[] byte_0 = Encoding.UTF8.GetBytes("AES");

	public const byte MAX_FILE_VERSION = 2;

	private const int int_0 = 16;

	private const int int_1 = 16;

	private const int int_2 = 32;

	private const int int_3 = 32;

	private Stream stream_0;

	private OperationMode operationMode_0;

	private CryptoStream cryptoStream_0;

	private HMAC hmac_0;

	private int int_4;

	private Class0 class0_0;

	private List<KeyValuePair<string, byte[]>> list_0;

	private byte byte_1 = 2;

	private bool bool_0 = false;

	private bool bool_1 = false;

	private long long_0;

	private long long_1;

	private byte byte_2;

	private bool bool_2 = false;

	public static string Extension_CreatedByIdentifier = $"SharpAESCrypt v{Assembly.GetExecutingAssembly().GetName().Version}";

	public static bool Extension_InsertCreateByIdentifier = true;

	public static bool Extension_InsertTimeStamp = false;

	public static bool Extension_InsertPlaceholder = true;

	public static byte DefaultFileVersion = 2;

	private CryptoStream Crypto
	{
		get
		{
			if (cryptoStream_0 == null)
			{
				WriteEncryptionHeader();
			}
			return cryptoStream_0;
		}
	}

	public byte Version
	{
		get
		{
			return byte_1;
		}
		set
		{
			if (operationMode_0 == OperationMode.Decrypt)
			{
				throw new InvalidOperationException(Strings.VersionReadonlyForDecryption);
			}
			if (operationMode_0 == OperationMode.Encrypt && cryptoStream_0 != null)
			{
				throw new InvalidOperationException(Strings.VersionReadonly);
			}
			if (value > 2)
			{
				throw new ArgumentOutOfRangeException(string.Format(Strings.VersionUnsupported, (byte)2));
			}
			if (value == 0 && !stream_0.CanSeek)
			{
				throw new InvalidOperationException(Strings.StreamMustSupportSeeking);
			}
			byte_1 = value;
		}
	}

	public IList<KeyValuePair<string, byte[]>> Extensions
	{
		get
		{
			if (operationMode_0 == OperationMode.Decrypt || (operationMode_0 == OperationMode.Encrypt && cryptoStream_0 != null))
			{
				return list_0.AsReadOnly();
			}
			return list_0;
		}
	}

	public override bool CanRead => Crypto.CanRead;

	public override bool CanSeek => Crypto.CanSeek;

	public override bool CanWrite => Crypto.CanWrite;

	public override long Length => Crypto.Length;

	public override long Position
	{
		get
		{
			return Crypto.Position;
		}
		set
		{
			Crypto.Position = value;
		}
	}

	private void ReadEncryptionHeader(string password)
	{
		byte[] array = new byte[byte_0.Length + 2];
		if (stream_0.Read(array, 0, array.Length) != array.Length)
		{
			throw new InvalidDataException(Strings.InvalidHeaderMarker);
		}
		int num = 0;
		while (true)
		{
			if (num < byte_0.Length)
			{
				if (byte_0[num] == array[num])
				{
					num++;
					continue;
				}
				throw new InvalidDataException(Strings.InvalidHeaderMarker);
			}
			byte_1 = array[byte_0.Length];
			if (byte_1 > 2)
			{
				throw new InvalidDataException(string.Format(Strings.UnsupportedFileVersion, byte_1));
			}
			if (byte_1 == 0)
			{
				byte_2 = array[byte_0.Length + 1];
				if (byte_2 >= 16)
				{
					throw new InvalidDataException(Strings.InvalidHeaderMarker);
				}
			}
			else if (array[byte_0.Length + 1] != 0)
			{
				throw new InvalidDataException(Strings.InvalidReservedFieldValue);
			}
			if (byte_1 >= 2)
			{
				int num2 = 0;
				do
				{
					byte[] array2 = RepeatRead(stream_0, 2);
					num2 = (array2[0] << 8) | array2[1];
					if (num2 != 0)
					{
						byte[] array3 = RepeatRead(stream_0, num2);
						int num3 = Array.IndexOf(array3, (byte)0);
						if (num3 < 0)
						{
							throw new InvalidDataException(Strings.InvalidExtensionData);
						}
						string @string = Encoding.UTF8.GetString(array3, 0, num3);
						byte[] array4 = new byte[array3.Length - num3 - 1];
						Array.Copy(array3, num3 + 1, array4, 0, array4.Length);
						list_0.Add(new KeyValuePair<string, byte[]>(@string, array4));
					}
				}
				while (num2 > 0);
			}
			byte[] iv = RepeatRead(stream_0, 16);
			class0_0 = new Class0(operationMode_0, password, iv);
			if (byte_1 >= 1)
			{
				byte[] array5 = class0_0.DecryptAESKey2(RepeatRead(stream_0, 48));
				byte[] array6 = RepeatRead(stream_0, array5.Length);
				for (int i = 0; i < array5.Length; i++)
				{
					if (array5[i] != array6[i])
					{
						throw new CryptographicException(Strings.InvalidPassword);
					}
				}
				long_0 = stream_0.Length - stream_0.Position - 33L;
			}
			else
			{
				class0_0.SetBulkKeyToKey1();
				long_0 = stream_0.Length - stream_0.Position - 32L;
			}
			if ((ulong)(long_0 % 16L) > 0uL)
			{
				throw new CryptographicException(Strings.InvalidFileLength);
			}
			break;
		}
	}

	private void WriteEncryptionHeader()
	{
		stream_0.Write(byte_0, 0, byte_0.Length);
		stream_0.WriteByte(byte_1);
		stream_0.WriteByte(0);
		if (byte_1 >= 2)
		{
			foreach (KeyValuePair<string, byte[]> item in list_0)
			{
				WriteExtension(item.Key, item.Value);
			}
			stream_0.Write(new byte[2], 0, 2);
		}
		stream_0.Write(class0_0.IV1, 0, class0_0.IV1.Length);
		if (byte_1 == 0)
		{
			class0_0.SetBulkKeyToKey1();
		}
		else
		{
			byte[] array = class0_0.EncryptAESKey2();
			stream_0.Write(array, 0, array.Length);
			array = class0_0.CalculateKeyHmac();
			stream_0.Write(array, 0, array.Length);
		}
		hmac_0 = class0_0.GetHMAC();
		cryptoStream_0 = new CryptoStream(new CryptoStream(new Stream0(stream_0, 0), hmac_0, CryptoStreamMode.Write), class0_0.CreateCryptoStream(operationMode_0), CryptoStreamMode.Write);
		bool_0 = true;
	}

	private void WriteExtension(string identifier, byte[] value)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(identifier);
		if (value == null)
		{
			value = new byte[0];
		}
		uint num = (uint)(bytes.Length + 1 + value.Length);
		stream_0.WriteByte((byte)((num >> 8) & 0xFFu));
		stream_0.WriteByte((byte)(num & 0xFFu));
		stream_0.Write(bytes, 0, bytes.Length);
		stream_0.WriteByte(0);
		stream_0.Write(value, 0, value.Length);
	}

	internal static byte[] RepeatRead(Stream stream, int count)
	{
		byte[] array = new byte[count];
		while (count > 0)
		{
			int num = stream.Read(array, array.Length - count, count);
			count -= num;
			if (num == 0 && count != 0)
			{
				throw new InvalidDataException(Strings.UnexpectedEndOfStream);
			}
		}
		return array;
	}

	public static void Encrypt(string password, Stream input, Stream output)
	{
		byte[] array = new byte[4096];
		SharpAESCrypt sharpAESCrypt = new SharpAESCrypt(password, output, OperationMode.Encrypt);
		int count;
		while ((count = input.Read(array, 0, array.Length)) != 0)
		{
			sharpAESCrypt.Write(array, 0, count);
		}
		sharpAESCrypt.FlushFinalBlock();
	}

	public static void Decrypt(string password, Stream input, Stream output)
	{
		byte[] array = new byte[4096];
		SharpAESCrypt sharpAESCrypt = new SharpAESCrypt(password, input, OperationMode.Decrypt);
		int count;
		while ((count = sharpAESCrypt.Read(array, 0, array.Length)) != 0)
		{
			output.Write(array, 0, count);
		}
	}

	public static void Encrypt(string password, string inputfile, string outputfile)
	{
		using FileStream input = File.OpenRead(inputfile);
		using FileStream output = File.Create(outputfile);
		Encrypt(password, input, output);
	}

	public static void Decrypt(string password, string inputfile, string outputfile)
	{
		using FileStream input = File.OpenRead(inputfile);
		using FileStream output = File.Create(outputfile);
		Decrypt(password, input, output);
	}

	public SharpAESCrypt(string password, Stream stream, OperationMode mode)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		if (password == null)
		{
			throw new ArgumentNullException("password");
		}
		if (mode != 0 && mode != OperationMode.Decrypt)
		{
			throw new ArgumentException(Strings.InvalidOperationMode, "mode");
		}
		if (mode == OperationMode.Encrypt && !stream.CanWrite)
		{
			throw new ArgumentException(Strings.StreamMustBeWriteAble, "stream");
		}
		if (mode == OperationMode.Decrypt && !stream.CanRead)
		{
			throw new ArgumentException(Strings.StreamMustBeReadAble, "stream");
		}
		operationMode_0 = mode;
		stream_0 = stream;
		list_0 = new List<KeyValuePair<string, byte[]>>();
		if (mode == OperationMode.Encrypt)
		{
			Version = DefaultFileVersion;
			class0_0 = new Class0(mode, password, null);
			if (Extension_InsertCreateByIdentifier)
			{
				list_0.Add(new KeyValuePair<string, byte[]>("CREATED-BY", Encoding.UTF8.GetBytes(Extension_CreatedByIdentifier)));
			}
			if (Extension_InsertTimeStamp)
			{
				list_0.Add(new KeyValuePair<string, byte[]>("CREATED-DATE", Encoding.UTF8.GetBytes(DateTime.Now.ToString("yyyy-MM-dd"))));
				list_0.Add(new KeyValuePair<string, byte[]>("CREATED-TIME", Encoding.UTF8.GetBytes(DateTime.Now.ToUniversalTime().ToString("hh-mm-ss"))));
			}
			if (Extension_InsertPlaceholder)
			{
				list_0.Add(new KeyValuePair<string, byte[]>("", new byte[127]));
			}
			cryptoStream_0 = null;
		}
		else
		{
			ReadEncryptionHeader(password);
			hmac_0 = class0_0.GetHMAC();
			cryptoStream_0 = new CryptoStream(new CryptoStream(new Stream0(stream_0, (byte_1 == 0) ? 32 : 33), hmac_0, CryptoStreamMode.Read), class0_0.CreateCryptoStream(operationMode_0), CryptoStreamMode.Read);
		}
	}

	public override void Flush()
	{
		Crypto.Flush();
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		return Crypto.Seek(offset, origin);
	}

	public override void SetLength(long value)
	{
		Crypto.SetLength(value);
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		if (operationMode_0 != OperationMode.Decrypt)
		{
			throw new InvalidOperationException(Strings.CannotReadWhileEncrypting);
		}
		if (bool_2)
		{
			return 0;
		}
		count = Crypto.Read(buffer, offset, count);
		long_1 += count;
		int_4 = (int_4 + count) % 16;
		if (!bool_2 && long_1 == long_0)
		{
			bool_2 = true;
			if (byte_1 >= 1)
			{
				int num = stream_0.ReadByte();
				if (num < 0)
				{
					throw new InvalidDataException(Strings.UnexpectedEndOfStream);
				}
				byte_2 = (byte)num;
				if (byte_2 > 16)
				{
					throw new InvalidDataException(Strings.InvalidFileLength);
				}
			}
			if (byte_2 > 0)
			{
				count -= 16 - byte_2;
			}
			if (int_4 % 16 != 0 || (ulong)(long_1 % 16L) > 0uL)
			{
				throw new InvalidDataException(Strings.InvalidFileLength);
			}
			Crypto.Close();
			byte[] hash = hmac_0.Hash;
			byte[] array = RepeatRead(stream_0, hash.Length);
			for (int i = 0; i < hash.Length; i++)
			{
				if (hash[i] != array[i])
				{
					throw new InvalidDataException((byte_1 == 0) ? Strings.DataHMACMismatch_v0 : Strings.DataHMACMismatch);
				}
			}
		}
		return count;
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		if (operationMode_0 != 0)
		{
			throw new InvalidOperationException(Strings.CannotWriteWhileDecrypting);
		}
		int_4 = (int_4 + count) % 16;
		Crypto.Write(buffer, offset, count);
	}

	public void FlushFinalBlock()
	{
		if (bool_1 || operationMode_0 != 0)
		{
			return;
		}
		if (!bool_0)
		{
			WriteEncryptionHeader();
		}
		byte b = (byte)(int_4 %= 16);
		if (b != 0)
		{
			byte[] array = new byte[16 - b];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = (byte)array.Length;
			}
			Write(array, 0, array.Length);
		}
		Crypto.FlushFinalBlock();
		Crypto.Close();
		byte[] hash = hmac_0.Hash;
		if (byte_1 == 0)
		{
			stream_0.Write(hash, 0, hash.Length);
			long position = stream_0.Position;
			stream_0.Seek(byte_0.Length + 1, SeekOrigin.Begin);
			stream_0.WriteByte(b);
			stream_0.Seek(position, SeekOrigin.Begin);
			stream_0.Flush();
		}
		else
		{
			stream_0.WriteByte(b);
			stream_0.Write(hash, 0, hash.Length);
			stream_0.Flush();
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (disposing)
		{
			if (operationMode_0 == OperationMode.Encrypt && !bool_1)
			{
				FlushFinalBlock();
			}
			cryptoStream_0.Dispose();
			cryptoStream_0 = null;
			stream_0.Dispose();
			stream_0 = null;
			list_0 = null;
			class0_0.Dispose();
			class0_0 = null;
			hmac_0 = null;
		}
	}

	public static void Main(string[] args)
	{
		if (args.Length < 4)
		{
			Console.WriteLine(Strings.CommandlineUsage);
			return;
		}
		try
		{
			if (args[0].StartsWith("e", StringComparison.InvariantCultureIgnoreCase))
			{
				Encrypt(args[1], args[2], args[3]);
			}
			else if (args[0].StartsWith("d", StringComparison.InvariantCultureIgnoreCase))
			{
				Decrypt(args[1], args[2], args[3]);
			}
			else if (args[0].StartsWith("u"))
			{
				Unittest();
			}
			else
			{
				Console.WriteLine(Strings.CommandlineUnknownMode);
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(string.Format(Strings.CommandlineError, ex.ToString()));
		}
	}

	private static void Unittest()
	{
		bool flag = true;
		Random random = new Random();
		Console.WriteLine("Running unittest");
		for (byte b = 0; b <= 2; b = (byte)(b + 1))
		{
			DefaultFileVersion = b;
			for (int i = 0; i < 5120; i++)
			{
				using MemoryStream memoryStream = new MemoryStream();
				byte[] array = new byte[i];
				random.NextBytes(array);
				memoryStream.Write(array, 0, array.Length);
				flag &= Unittest($"Testing version {b} with length = {memoryStream.Length} => ", memoryStream);
			}
		}
		DefaultFileVersion = 2;
		Console.WriteLine($"Initial tests complete, running bulk tests with v{DefaultFileVersion}");
		for (int j = 0; j < 1000; j++)
		{
			using MemoryStream memoryStream2 = new MemoryStream();
			byte[] array2 = new byte[random.Next(5120, 104857600)];
			random.NextBytes(array2);
			memoryStream2.Write(array2, 0, array2.Length);
			flag |= Unittest($"Testing bulk {j} of {1000} with length = {memoryStream2.Length} => ", memoryStream2);
		}
		if (flag)
		{
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("**** All unittests passed ****");
			Console.WriteLine();
		}
	}

	private static bool Unittest(string message, MemoryStream input)
	{
		Console.Write(message);
		try
		{
			Random random = new Random();
			char[] array = new char[random.Next(1, 25)];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!\"#آ¤%&/()=?`*'^آ\u00a8-_.:,;<>|"[random.Next(0, "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!\"#آ¤%&/()=?`*'^آ\u00a8-_.:,;<>|".Length)];
			}
			input.Position = 0L;
			using MemoryStream memoryStream = new MemoryStream();
			using MemoryStream memoryStream2 = new MemoryStream();
			Encrypt(new string(array), input, memoryStream);
			memoryStream.Position = 0L;
			Decrypt(new string(array), memoryStream, memoryStream2);
			memoryStream2.Position = 0L;
			input.Position = 0L;
			if (memoryStream2.Length != input.Length)
			{
				throw new Exception($"Length differ {memoryStream2.Length} vs {input.Length}");
			}
			for (int j = 0; j < memoryStream2.Length; j++)
			{
				if (memoryStream2.ReadByte() != input.ReadByte())
				{
					throw new Exception($"Streams differ at byte {j}");
				}
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine("FAILED: " + ex.Message);
			return false;
		}
		Console.WriteLine("OK!");
		return true;
	}
}
