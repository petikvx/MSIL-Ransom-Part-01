using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using K4os.Compression.LZ4.Streams;
using MySql.Data.MySqlClient;
using MySql.Data.X.common;
using MySqlX.Communication;
using Zstandard.Net;

namespace MySql.Data.X.Communication;

internal class XCompressionController
{
	internal const string ALGORITHMS_SUBKEY = "algorithm";

	internal const string COMPRESSION_KEY = "compression";

	internal const int COMPRESSION_THRESHOLD = 1000;

	internal const bool DEFAULT_SERVER_COMBINE_MIXED_MESSAGES_VALUE = true;

	internal const int DEFAULT_SERVER_MAX_COMBINE_MESSAGES_VALUE = 100;

	internal const string DEFLATE_STREAM_COMPRESSION_ALGORITHM = "deflate_stream";

	internal const string LZ4_MESSAGE_COMPRESSION_ALGORITHM = "lz4_message";

	internal const string SERVER_COMBINE_MIXED_MESSAGES_SUBKEY = "server_combine_mixed_messages";

	internal const string SERVER_MAX_COMBINE_MESSAGES_SUBKEY = "server_max_combine_messages";

	internal const string ZSTD_STREAM_COMPRESSION_ALGORITHM = "zstd_stream";

	private MemoryStream _buffer;

	private DeflateStream _deflateCompressStream;

	private DeflateStream _deflateDecompressStream;

	private bool _initializeForCompression;

	private CommunicationPacket _lastCommunicationPacket;

	private static bool? _libzstdLoaded;

	private MemoryStream _multipleMessagesStream;

	private ZstandardStream _zstdDecompressStream;

	internal List<ClientMessageId> ClientSupportedCompressedMessages { get; private set; }

	internal static string[] ClientSupportedCompressionAlgorithms { get; private set; }

	internal string CompressionAlgorithm { get; private set; }

	internal bool IsCompressionEnabled => !string.IsNullOrEmpty(CompressionAlgorithm);

	internal bool LastMessageContainsMultipleMessages { get; private set; }

	static XCompressionController()
	{
		ClientSupportedCompressionAlgorithms = new string[2] { "zstd_stream", "lz4_message" };
	}

	public XCompressionController(string compressionAlgorithm, bool initializeForCompression)
	{
		if (string.IsNullOrEmpty(compressionAlgorithm))
		{
			throw new ArgumentNullException(compressionAlgorithm);
		}
		if (!ClientSupportedCompressionAlgorithms.Contains(compressionAlgorithm))
		{
			throw new NotSupportedException(string.Format(ResourcesX.CompressionAlgorithmNotSupported, compressionAlgorithm));
		}
		CompressionAlgorithm = compressionAlgorithm;
		_initializeForCompression = initializeForCompression;
		ClientSupportedCompressedMessages = new List<ClientMessageId>();
		ClientSupportedCompressedMessages.Add(ClientMessageId.CRUD_DELETE);
		ClientSupportedCompressedMessages.Add(ClientMessageId.CRUD_FIND);
		ClientSupportedCompressedMessages.Add(ClientMessageId.CRUD_INSERT);
		ClientSupportedCompressedMessages.Add(ClientMessageId.CRUD_UPDATE);
		ClientSupportedCompressedMessages.Add(ClientMessageId.SQL_STMT_EXECUTE);
		_buffer = new MemoryStream();
		switch (CompressionAlgorithm)
		{
		case "deflate_stream":
			if (_initializeForCompression)
			{
				_deflateCompressStream = new DeflateStream(_buffer, CompressionMode.Compress, leaveOpen: true);
			}
			else
			{
				_deflateDecompressStream = new DeflateStream(_buffer, CompressionMode.Decompress, leaveOpen: true);
			}
			break;
		case "zstd_stream":
			if (!_initializeForCompression)
			{
				_zstdDecompressStream = new ZstandardStream(_buffer, CompressionMode.Decompress);
			}
			break;
		}
	}

	internal byte[] Compress(byte[] input)
	{
		if (!IsCompressionEnabled)
		{
			throw new Exception(ResourcesX.CompressionNotEnabled);
		}
		return CompressionAlgorithm switch
		{
			"deflate_stream" => CompressUsingDeflateStream(input), 
			"lz4_message" => CompressUsingLz4Message(input), 
			"zstd_stream" => CompressUsingZstdStream(input), 
			_ => throw new NotSupportedException(string.Format(ResourcesX.CompressionAlgorithmNotSupported, CompressionAlgorithm)), 
		};
	}

	public byte[] CompressUsingDeflateStream(byte[] input)
	{
		if (_buffer.Capacity == 0)
		{
			_buffer.WriteByte(120);
			_buffer.WriteByte(156);
		}
		throw new NotSupportedException(string.Format(ResourcesX.CompressionForSpecificAlgorithmNotSupportedInNetFramework, "deflate_stream"));
	}

	private byte[] CompressUsingLz4Message(byte[] input)
	{
		using MemoryStream memoryStream2 = new MemoryStream(input);
		using MemoryStream memoryStream = new MemoryStream();
		using LZ4EncoderStream lZ4EncoderStream = LZ4Stream.Encode(memoryStream);
		memoryStream2.CopyTo(lZ4EncoderStream);
		lZ4EncoderStream.Close();
		return memoryStream.ToArray();
	}

	private byte[] CompressUsingZstdStream(byte[] input)
	{
		using MemoryStream memoryStream = new MemoryStream();
		using ZstandardStream zstandardStream = new ZstandardStream(memoryStream, CompressionMode.Compress);
		zstandardStream.Write(input, 0, input.Length);
		zstandardStream.Close();
		return memoryStream.ToArray();
	}

	internal byte[] Decompress(byte[] input, int length)
	{
		if (!IsCompressionEnabled)
		{
			throw new Exception(ResourcesX.CompressionNotEnabled);
		}
		if (LastMessageContainsMultipleMessages)
		{
			throw new Exception(ResourcesX.CompressionPendingMessagesToProcess);
		}
		byte[] array;
		byte[] array2;
		int num;
		switch (CompressionAlgorithm)
		{
		case "deflate_stream":
			array = DecompressUsingDeflateStream(input, length);
			goto IL_007c;
		case "lz4_message":
			array = DecompressUsingLz4Message(input, length);
			goto IL_007c;
		case "zstd_stream":
			array = DecompressUsingZstdStream(input, length);
			goto IL_007c;
		default:
			{
				throw new NotSupportedException(string.Format(ResourcesX.CompressionAlgorithmNotSupported, CompressionAlgorithm));
			}
			IL_007c:
			if (array == null)
			{
				return null;
			}
			array2 = new byte[4];
			Buffer.BlockCopy(array, 0, array2, 0, array2.Length);
			num = BitConverter.ToInt32(array2, 0) + 4;
			LastMessageContainsMultipleMessages = num < array.Length;
			if (LastMessageContainsMultipleMessages && (_multipleMessagesStream == null || _multipleMessagesStream.Position != _multipleMessagesStream.Length))
			{
				_multipleMessagesStream = new MemoryStream(array);
				return ReadNextBufferedMessage();
			}
			return array;
		}
	}

	private byte[] DecompressUsingDeflateStream(byte[] input, int length)
	{
		if (input[0] == 120 && (input[1] == 156 || input[1] == 94))
		{
			_buffer.Write(input, 2, input.Length - 2);
		}
		else
		{
			_buffer.Write(input, 0, input.Length);
		}
		_buffer.Position = 0L;
		MemoryStream memoryStream = new MemoryStream();
		_deflateDecompressStream.CopyTo(memoryStream, length);
		_deflateDecompressStream.Flush();
		byte[] result = memoryStream.ToArray();
		_buffer.SetLength(0L);
		memoryStream.Dispose();
		return result;
	}

	private byte[] DecompressUsingLz4Message(byte[] input, int length)
	{
		using MemoryStream stream = new MemoryStream(input);
		using LZ4DecoderStream lZ4DecoderStream = LZ4Stream.Decode(stream);
		using MemoryStream memoryStream = new MemoryStream();
		lZ4DecoderStream.CopyTo(memoryStream);
		return memoryStream.ToArray();
	}

	private byte[] DecompressUsingZstdStream(byte[] input, int length)
	{
		_buffer.Write(input, 0, input.Length);
		_buffer.Position -= input.Length;
		MemoryStream memoryStream = new MemoryStream();
		_zstdDecompressStream.CopyTo(memoryStream, length);
		_zstdDecompressStream.Flush();
		byte[] result = memoryStream.ToArray();
		memoryStream.Dispose();
		_buffer.SetLength(0L);
		return result;
	}

	internal void Close()
	{
		_deflateCompressStream?.Dispose();
		_deflateDecompressStream?.Dispose();
		_multipleMessagesStream?.Dispose();
		_zstdDecompressStream?.Dispose();
	}

	internal byte[] ReadNextBufferedMessage()
	{
		if (_multipleMessagesStream == null)
		{
			return null;
		}
		byte[] array = new byte[4];
		_multipleMessagesStream.Read(array, 0, array.Length);
		byte b = (byte)_multipleMessagesStream.ReadByte();
		int num = BitConverter.ToInt32(array, 0);
		byte[] array2 = new byte[num - 1];
		_multipleMessagesStream.Read(array2, 0, array2.Length);
		_lastCommunicationPacket = new CommunicationPacket(b, num - 1, array2);
		byte[] array3 = new byte[array.Length + 1 + array2.Length];
		Buffer.BlockCopy(array, 0, array3, 0, array.Length);
		Buffer.BlockCopy(new byte[1] { b }, 0, array3, array.Length, 1);
		Buffer.BlockCopy(array2, 0, array3, array.Length + 1, array2.Length);
		if (_multipleMessagesStream.Position == _multipleMessagesStream.Length)
		{
			LastMessageContainsMultipleMessages = false;
			_multipleMessagesStream.Close();
			_multipleMessagesStream = null;
		}
		return array3;
	}

	internal CommunicationPacket ReadNextBufferedMessageAsCommunicationPacket()
	{
		ReadNextBufferedMessage();
		return _lastCommunicationPacket;
	}

	internal static void LoadLibzstdLibrary()
	{
		if (_libzstdLoaded.HasValue)
		{
			return;
		}
		_libzstdLoaded = UnmanagedLibraryLoader.LoadUnmanagedLibraryFromEmbeddedResources("MySql.Data", "libzstd.dll");
		if (_libzstdLoaded == false)
		{
			ZstandardInterop.LoadLibzstdLibrary(string.Empty);
			try
			{
				using (new ZstandardStream(new MemoryStream(), CompressionMode.Compress))
				{
				}
				_libzstdLoaded = true;
			}
			catch
			{
			}
		}
		if (_libzstdLoaded == false)
		{
			ClientSupportedCompressionAlgorithms = new string[1] { "lz4_message" };
			MySqlTrace.LogWarning(-1, ResourcesX.CompressionFailedToLoadLibzstdAssembly);
		}
	}
}
