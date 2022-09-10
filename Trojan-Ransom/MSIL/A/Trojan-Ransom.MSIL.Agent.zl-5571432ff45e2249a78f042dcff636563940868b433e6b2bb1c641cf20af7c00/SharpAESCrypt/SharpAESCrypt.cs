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
	private class SetupHelper : IDisposable
	{
		private static readonly byte[] DEFAULT_MAC = new byte[8] { 1, 35, 69, 103, 137, 171, 205, 239 };

		private const string HASH_ALGORITHM = "SHA-256";

		private const string CRYPT_ALGORITHM = "Rijndael";

		private const string RAND_ALGORITHM = "SHA1PRNG";

		private const string HMAC_ALGORITHM = "HmacSHA256";

		private const string PASSWORD_ENCODING = "utf-16";

		private SymmetricAlgorithm m_crypt;

		private HashAlgorithm m_hash;

		private RandomNumberGenerator m_rand;

		private HMAC m_hmac;

		private byte[] m_iv1;

		private byte[] m_aesKey1;

		private byte[] m_iv2;

		private byte[] m_aesKey2;

		public byte[] IV1 => m_iv1;

		public SetupHelper(OperationMode mode, string password, byte[] iv)
		{
			m_crypt = SymmetricAlgorithm.Create("Rijndael");
			m_crypt.Padding = PaddingMode.None;
			m_crypt.Mode = CipherMode.CBC;
			m_hash = HashAlgorithm.Create("SHA-256");
			m_rand = RandomNumberGenerator.Create();
			m_hmac = HMAC.Create("HmacSHA256");
			if (mode == OperationMode.Encrypt)
			{
				m_iv1 = GenerateIv1();
				m_aesKey1 = GenerateAESKey1(EncodePassword(password));
				m_iv2 = GenerateIv2();
				m_aesKey2 = GenerateAESKey2();
			}
			else
			{
				m_iv1 = iv;
				m_aesKey1 = GenerateAESKey1(EncodePassword(password));
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
				array2 = DEFAULT_MAC;
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
			if (!m_hash.CanReuseTransform)
			{
				throw new CryptographicException(Strings.UnsupportedHashAlgorithmReuse);
			}
			if (!m_hash.CanTransformMultipleBlocks)
			{
				throw new CryptographicException(Strings.UnsupportedHashAlgorithmBlocks);
			}
			if (32 < m_hash.HashSize / 8)
			{
				throw new CryptographicException(string.Format(Strings.UnsupportedHashAlgorithmBlocksize, 32, m_hash.HashSize / 8));
			}
			byte[] array = new byte[32];
			Array.Copy(m_iv1, array, m_iv1.Length);
			for (int i = 0; i < 8192; i++)
			{
				m_hash.Initialize();
				m_hash.TransformBlock(array, 0, array.Length, array, 0);
				m_hash.TransformFinalBlock(password, 0, password.Length);
				array = m_hash.Hash;
			}
			return array;
		}

		private byte[] GenerateIv2()
		{
			m_crypt.GenerateIV();
			return DigestRandomBytes(m_crypt.IV, 256);
		}

		private byte[] GenerateAESKey2()
		{
			m_crypt.GenerateKey();
			return DigestRandomBytes(m_crypt.Key, 32);
		}

		public byte[] EncryptAESKey2()
		{
			using MemoryStream memoryStream = new MemoryStream();
			using CryptoStream cryptoStream = new CryptoStream(memoryStream, m_crypt.CreateEncryptor(m_aesKey1, m_iv1), CryptoStreamMode.Write);
			cryptoStream.Write(m_iv2, 0, m_iv2.Length);
			cryptoStream.Write(m_aesKey2, 0, m_aesKey2.Length);
			cryptoStream.FlushFinalBlock();
			return memoryStream.ToArray();
		}

		public byte[] CalculateKeyHmac()
		{
			m_hmac.Initialize();
			m_hmac.Key = m_aesKey1;
			return m_hmac.ComputeHash(EncryptAESKey2());
		}

		private byte[] DigestRandomBytes(byte[] bytes, int repetitions)
		{
			if (bytes.Length > m_hash.HashSize / 8)
			{
				throw new CryptographicException(string.Format(Strings.UnsupportedHashAlgorithmBlocksize, bytes.Length, m_hash.HashSize / 8));
			}
			if (!m_hash.CanReuseTransform)
			{
				throw new CryptographicException(Strings.UnsupportedHashAlgorithmReuse);
			}
			if (!m_hash.CanTransformMultipleBlocks)
			{
				throw new CryptographicException(Strings.UnsupportedHashAlgorithmBlocks);
			}
			m_hash.Initialize();
			m_hash.TransformBlock(bytes, 0, bytes.Length, bytes, 0);
			for (int i = 0; i < repetitions; i++)
			{
				m_rand.GetBytes(bytes);
				m_hash.TransformBlock(bytes, 0, bytes.Length, bytes, 0);
			}
			m_hash.TransformFinalBlock(bytes, 0, 0);
			Array.Copy(m_hash.Hash, bytes, bytes.Length);
			return bytes;
		}

		public ICryptoTransform CreateCryptoStream(OperationMode mode)
		{
			if (mode == OperationMode.Encrypt)
			{
				return m_crypt.CreateEncryptor(m_aesKey2, m_iv2);
			}
			return m_crypt.CreateDecryptor(m_aesKey2, m_iv2);
		}

		public HMAC GetHMAC()
		{
			HMAC hMAC = HMAC.Create("HmacSHA256");
			hMAC.Key = m_aesKey2;
			return hMAC;
		}

		public byte[] DecryptAESKey2(byte[] data)
		{
			using (MemoryStream stream = new MemoryStream(data))
			{
				using CryptoStream stream2 = new CryptoStream(stream, m_crypt.CreateDecryptor(m_aesKey1, m_iv1), CryptoStreamMode.Read);
				m_iv2 = RepeatRead(stream2, 16);
				m_aesKey2 = RepeatRead(stream2, 32);
			}
			m_hmac.Initialize();
			m_hmac.Key = m_aesKey1;
			m_hmac.TransformFinalBlock(data, 0, data.Length);
			return m_hmac.Hash;
		}

		public void SetBulkKeyToKey1()
		{
			m_iv2 = m_iv1;
			m_aesKey2 = m_aesKey1;
		}

		public void Dispose()
		{
			if (m_crypt != null)
			{
				if (m_aesKey1 != null)
				{
					Array.Clear(m_aesKey1, 0, m_aesKey1.Length);
				}
				if (m_iv1 != null)
				{
					Array.Clear(m_iv1, 0, m_iv1.Length);
				}
				if (m_aesKey2 != null)
				{
					Array.Clear(m_aesKey2, 0, m_aesKey2.Length);
				}
				if (m_iv2 != null)
				{
					Array.Clear(m_iv2, 0, m_iv2.Length);
				}
				m_aesKey1 = null;
				m_iv1 = null;
				m_aesKey2 = null;
				m_iv2 = null;
				m_hash = null;
				m_hmac = null;
				m_rand = null;
				m_crypt = null;
			}
		}
	}

	private class StreamHider : Stream
	{
		private Stream m_stream;

		private int m_hiddenByteCount;

		public override bool CanRead => m_stream.CanRead;

		public override bool CanSeek => m_stream.CanSeek;

		public override bool CanWrite => m_stream.CanWrite;

		public override long Length => m_stream.Length;

		public override long Position
		{
			get
			{
				return m_stream.Position;
			}
			set
			{
				m_stream.Position = value;
			}
		}

		public StreamHider(Stream stream, int count)
		{
			m_stream = stream;
			m_hiddenByteCount = count;
		}

		public override void Flush()
		{
			m_stream.Flush();
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			return m_stream.Seek(offset, origin);
		}

		public override void SetLength(long value)
		{
			m_stream.SetLength(value);
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
			m_stream.Write(buffer, offset, count);
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			long num = Math.Max(0L, Math.Min(count, m_stream.Length - (m_stream.Position + m_hiddenByteCount)));
			if (num == 0L)
			{
				return 0;
			}
			return m_stream.Read(buffer, offset, (int)num);
		}
	}

	private readonly byte[] MAGIC_HEADER = Encoding.UTF8.GetBytes("AES");

	public const byte MAX_FILE_VERSION = 2;

	private const int BLOCK_SIZE = 16;

	private const int IV_SIZE = 16;

	private const int KEY_SIZE = 32;

	private const int HASH_SIZE = 32;

	private Stream m_stream;

	private OperationMode m_mode;

	private CryptoStream m_crypto;

	private HMAC m_hmac;

	private int m_length;

	private SetupHelper m_helper;

	private List<KeyValuePair<string, byte[]>> m_extensions;

	private byte m_version = 2;

	private bool m_hasWrittenHeader = false;

	private bool m_hasFlushedFinalBlock = false;

	private long m_payloadLength;

	private long m_readcount;

	private byte m_paddingSize;

	private bool m_hasReadFooter = false;

	public static string Extension_CreatedByIdentifier = $"SharpAESCrypt v{Assembly.GetExecutingAssembly().GetName().Version}";

	public static bool Extension_InsertCreateByIdentifier = true;

	public static bool Extension_InsertTimeStamp = false;

	public static bool Extension_InsertPlaceholder = true;

	public static byte DefaultFileVersion = 2;

	private CryptoStream Crypto
	{
		get
		{
			if (m_crypto == null)
			{
				WriteEncryptionHeader();
			}
			return m_crypto;
		}
	}

	public byte Version
	{
		get
		{
			return m_version;
		}
		set
		{
			if (m_mode == OperationMode.Decrypt)
			{
				throw new InvalidOperationException(Strings.VersionReadonlyForDecryption);
			}
			if (m_mode == OperationMode.Encrypt && m_crypto != null)
			{
				throw new InvalidOperationException(Strings.VersionReadonly);
			}
			if (value > 2)
			{
				throw new ArgumentOutOfRangeException(string.Format(Strings.VersionUnsupported, (byte)2));
			}
			if (value == 0 && !m_stream.CanSeek)
			{
				throw new InvalidOperationException(Strings.StreamMustSupportSeeking);
			}
			m_version = value;
		}
	}

	public IList<KeyValuePair<string, byte[]>> Extensions
	{
		get
		{
			if (m_mode == OperationMode.Decrypt || (m_mode == OperationMode.Encrypt && m_crypto != null))
			{
				return m_extensions.AsReadOnly();
			}
			return m_extensions;
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
		byte[] array = new byte[MAGIC_HEADER.Length + 2];
		if (m_stream.Read(array, 0, array.Length) != array.Length)
		{
			throw new InvalidDataException(Strings.InvalidHeaderMarker);
		}
		int num = 0;
		while (true)
		{
			if (num < MAGIC_HEADER.Length)
			{
				if (MAGIC_HEADER[num] == array[num])
				{
					num++;
					continue;
				}
				throw new InvalidDataException(Strings.InvalidHeaderMarker);
			}
			m_version = array[MAGIC_HEADER.Length];
			if (m_version > 2)
			{
				throw new InvalidDataException(string.Format(Strings.UnsupportedFileVersion, m_version));
			}
			if (m_version == 0)
			{
				m_paddingSize = array[MAGIC_HEADER.Length + 1];
				if (m_paddingSize >= 16)
				{
					throw new InvalidDataException(Strings.InvalidHeaderMarker);
				}
			}
			else if (array[MAGIC_HEADER.Length + 1] != 0)
			{
				throw new InvalidDataException(Strings.InvalidReservedFieldValue);
			}
			if (m_version >= 2)
			{
				int num2 = 0;
				do
				{
					byte[] array2 = RepeatRead(m_stream, 2);
					num2 = (array2[0] << 8) | array2[1];
					if (num2 != 0)
					{
						byte[] array3 = RepeatRead(m_stream, num2);
						int num3 = Array.IndexOf(array3, (byte)0);
						if (num3 < 0)
						{
							throw new InvalidDataException(Strings.InvalidExtensionData);
						}
						string @string = Encoding.UTF8.GetString(array3, 0, num3);
						byte[] array4 = new byte[array3.Length - num3 - 1];
						Array.Copy(array3, num3 + 1, array4, 0, array4.Length);
						m_extensions.Add(new KeyValuePair<string, byte[]>(@string, array4));
					}
				}
				while (num2 > 0);
			}
			byte[] iv = RepeatRead(m_stream, 16);
			m_helper = new SetupHelper(m_mode, password, iv);
			if (m_version >= 1)
			{
				byte[] array5 = m_helper.DecryptAESKey2(RepeatRead(m_stream, 48));
				byte[] array6 = RepeatRead(m_stream, array5.Length);
				for (int i = 0; i < array5.Length; i++)
				{
					if (array5[i] != array6[i])
					{
						throw new CryptographicException(Strings.InvalidPassword);
					}
				}
				m_payloadLength = m_stream.Length - m_stream.Position - 33L;
			}
			else
			{
				m_helper.SetBulkKeyToKey1();
				m_payloadLength = m_stream.Length - m_stream.Position - 32L;
			}
			if ((ulong)(m_payloadLength % 16L) > 0uL)
			{
				throw new CryptographicException(Strings.InvalidFileLength);
			}
			break;
		}
	}

	private void WriteEncryptionHeader()
	{
		m_stream.Write(MAGIC_HEADER, 0, MAGIC_HEADER.Length);
		m_stream.WriteByte(m_version);
		m_stream.WriteByte(0);
		if (m_version >= 2)
		{
			foreach (KeyValuePair<string, byte[]> extension in m_extensions)
			{
				WriteExtension(extension.Key, extension.Value);
			}
			m_stream.Write(new byte[2], 0, 2);
		}
		m_stream.Write(m_helper.IV1, 0, m_helper.IV1.Length);
		if (m_version == 0)
		{
			m_helper.SetBulkKeyToKey1();
		}
		else
		{
			byte[] array = m_helper.EncryptAESKey2();
			m_stream.Write(array, 0, array.Length);
			array = m_helper.CalculateKeyHmac();
			m_stream.Write(array, 0, array.Length);
		}
		m_hmac = m_helper.GetHMAC();
		m_crypto = new CryptoStream(new CryptoStream(new StreamHider(m_stream, 0), m_hmac, CryptoStreamMode.Write), m_helper.CreateCryptoStream(m_mode), CryptoStreamMode.Write);
		m_hasWrittenHeader = true;
	}

	private void WriteExtension(string identifier, byte[] value)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(identifier);
		if (value == null)
		{
			value = new byte[0];
		}
		uint num = (uint)(bytes.Length + 1 + value.Length);
		m_stream.WriteByte((byte)((num >> 8) & 0xFFu));
		m_stream.WriteByte((byte)(num & 0xFFu));
		m_stream.Write(bytes, 0, bytes.Length);
		m_stream.WriteByte(0);
		m_stream.Write(value, 0, value.Length);
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
		m_mode = mode;
		m_stream = stream;
		m_extensions = new List<KeyValuePair<string, byte[]>>();
		if (mode == OperationMode.Encrypt)
		{
			Version = DefaultFileVersion;
			m_helper = new SetupHelper(mode, password, null);
			if (Extension_InsertCreateByIdentifier)
			{
				m_extensions.Add(new KeyValuePair<string, byte[]>("CREATED-BY", Encoding.UTF8.GetBytes(Extension_CreatedByIdentifier)));
			}
			if (Extension_InsertTimeStamp)
			{
				m_extensions.Add(new KeyValuePair<string, byte[]>("CREATED-DATE", Encoding.UTF8.GetBytes(DateTime.Now.ToString("yyyy-MM-dd"))));
				m_extensions.Add(new KeyValuePair<string, byte[]>("CREATED-TIME", Encoding.UTF8.GetBytes(DateTime.Now.ToUniversalTime().ToString("hh-mm-ss"))));
			}
			if (Extension_InsertPlaceholder)
			{
				m_extensions.Add(new KeyValuePair<string, byte[]>("", new byte[127]));
			}
			m_crypto = null;
		}
		else
		{
			ReadEncryptionHeader(password);
			m_hmac = m_helper.GetHMAC();
			m_crypto = new CryptoStream(new CryptoStream(new StreamHider(m_stream, (m_version == 0) ? 32 : 33), m_hmac, CryptoStreamMode.Read), m_helper.CreateCryptoStream(m_mode), CryptoStreamMode.Read);
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
		if (m_mode != OperationMode.Decrypt)
		{
			throw new InvalidOperationException(Strings.CannotReadWhileEncrypting);
		}
		if (m_hasReadFooter)
		{
			return 0;
		}
		count = Crypto.Read(buffer, offset, count);
		m_readcount += count;
		m_length = (m_length + count) % 16;
		if (!m_hasReadFooter && m_readcount == m_payloadLength)
		{
			m_hasReadFooter = true;
			if (m_version >= 1)
			{
				int num = m_stream.ReadByte();
				if (num < 0)
				{
					throw new InvalidDataException(Strings.UnexpectedEndOfStream);
				}
				m_paddingSize = (byte)num;
				if (m_paddingSize > 16)
				{
					throw new InvalidDataException(Strings.InvalidFileLength);
				}
			}
			if (m_paddingSize > 0)
			{
				count -= 16 - m_paddingSize;
			}
			if (m_length % 16 != 0 || (ulong)(m_readcount % 16L) > 0uL)
			{
				throw new InvalidDataException(Strings.InvalidFileLength);
			}
			Crypto.Close();
			byte[] hash = m_hmac.Hash;
			byte[] array = RepeatRead(m_stream, hash.Length);
			for (int i = 0; i < hash.Length; i++)
			{
				if (hash[i] != array[i])
				{
					throw new InvalidDataException((m_version == 0) ? Strings.DataHMACMismatch_v0 : Strings.DataHMACMismatch);
				}
			}
		}
		return count;
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		if (m_mode != 0)
		{
			throw new InvalidOperationException(Strings.CannotWriteWhileDecrypting);
		}
		m_length = (m_length + count) % 16;
		Crypto.Write(buffer, offset, count);
	}

	public void FlushFinalBlock()
	{
		if (m_hasFlushedFinalBlock || m_mode != 0)
		{
			return;
		}
		if (!m_hasWrittenHeader)
		{
			WriteEncryptionHeader();
		}
		byte b = (byte)(m_length %= 16);
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
		byte[] hash = m_hmac.Hash;
		if (m_version == 0)
		{
			m_stream.Write(hash, 0, hash.Length);
			long position = m_stream.Position;
			m_stream.Seek(MAGIC_HEADER.Length + 1, SeekOrigin.Begin);
			m_stream.WriteByte(b);
			m_stream.Seek(position, SeekOrigin.Begin);
			m_stream.Flush();
		}
		else
		{
			m_stream.WriteByte(b);
			m_stream.Write(hash, 0, hash.Length);
			m_stream.Flush();
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (disposing)
		{
			if (m_mode == OperationMode.Encrypt && !m_hasFlushedFinalBlock)
			{
				FlushFinalBlock();
			}
			m_crypto.Dispose();
			m_crypto = null;
			m_stream.Dispose();
			m_stream = null;
			m_extensions = null;
			m_helper.Dispose();
			m_helper = null;
			m_hmac = null;
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
