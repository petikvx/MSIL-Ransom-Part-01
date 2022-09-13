using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Ionic.Crc;
using Ionic.Zlib;

namespace Ionic.Zip;

[Guid("ebc25cf6-9120-4283-b972-0e5520d00004")]
[ComVisible(true)]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
public class ZipEntry
{
	private class CopyHelper
	{
		private static Regex re;

		private static int callCount;

		internal static extern string AppendCopyToFileName(string f);

		public extern CopyHelper();
	}

	private delegate T Func<T>();

	private short _VersionMadeBy;

	private short _InternalFileAttrs;

	private int _ExternalFileAttrs;

	private short _filenameLength;

	private short _extraFieldLength;

	private short _commentLength;

	private ZipCrypto _zipCrypto_forExtract;

	private ZipCrypto _zipCrypto_forWrite;

	internal DateTime _LastModified;

	private DateTime _Mtime;

	private DateTime _Atime;

	private DateTime _Ctime;

	private bool _ntfsTimesAreSet;

	private bool _emitNtfsTimes;

	private bool _emitUnixTimes;

	private bool _TrimVolumeFromFullyQualifiedPaths;

	internal string _LocalFileName;

	private string _FileNameInArchive;

	internal short _VersionNeeded;

	internal short _BitField;

	internal short _CompressionMethod;

	private short _CompressionMethod_FromZipFile;

	private CompressionLevel _CompressionLevel;

	internal string _Comment;

	private bool _IsDirectory;

	private byte[] _CommentBytes;

	internal long _CompressedSize;

	internal long _CompressedFileDataSize;

	internal long _UncompressedSize;

	internal int _TimeBlob;

	private bool _crcCalculated;

	internal int _Crc32;

	internal byte[] _Extra;

	private bool _metadataChanged;

	private bool _restreamRequiredOnSave;

	private bool _sourceIsEncrypted;

	private bool _skippedDuringSave;

	private uint _diskNumber;

	private static Encoding ibm437;

	private Encoding _actualEncoding;

	internal ZipContainer _container;

	private long __FileDataPosition;

	private byte[] _EntryHeader;

	internal long _RelativeOffsetOfLocalHeader;

	private long _future_ROLH;

	private long _TotalEntrySize;

	private int _LengthOfHeader;

	private int _LengthOfTrailer;

	internal bool _InputUsesZip64;

	private uint _UnsupportedAlgorithmId;

	internal string _Password;

	internal ZipEntrySource _Source;

	internal EncryptionAlgorithm _Encryption;

	internal EncryptionAlgorithm _Encryption_FromZipFile;

	internal byte[] _WeakEncryptionHeader;

	internal Stream _archiveStream;

	private Stream _sourceStream;

	private long? _sourceStreamOriginalPosition;

	private bool _sourceWasJitProvided;

	private bool _ioOperationCanceled;

	private bool _presumeZip64;

	private bool? _entryRequiresZip64;

	private bool? _OutputUsesZip64;

	private bool _IsText;

	private ZipEntryTimestamp _timestamp;

	private static DateTime _unixEpoch;

	private static DateTime _win32Epoch;

	private static DateTime _zeroHour;

	private WriteDelegate _WriteDelegate;

	private OpenDelegate _OpenDelegate;

	private CloseDelegate _CloseDelegate;

	private Stream _inputDecryptorStream;

	private int _readExtraDepth;

	private object _outputLock;

	internal extern bool AttributesIndicateDirectory { get; }

	public extern string Info { get; }

	public extern DateTime LastModified { get; set; }

	private extern int BufferSize { get; }

	public extern DateTime ModifiedTime { get; set; }

	public DateTime AccessedTime
	{
		get; set
		{
			//Discarded unreachable code: IL_0005, IL_000b, IL_0011, IL_0017
			//IL_0006: Invalid comparison between Unknown and I4
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Incompatible stack heights: 0 vs 1
			/*Error: Invalid metadata token*/;
		}
	}

	public extern DateTime CreationTime { get; set; }

	public bool EmitTimesInWindowsFormatWhenSaving
	{
		get
		{
			//Discarded unreachable code: IL_0006, IL_000b, IL_0015, IL_001a, IL_001b, IL_0029
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected I4, but got O
			//IL_0024: Invalid comparison between Unknown and I4
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected F8, but got Unknown
			((float[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (float)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}
		set
		{
			//Discarded unreachable code: IL_0005, IL_000d, IL_0012, IL_0013, IL_0021, IL_0029
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Expected I4, but got O
			//IL_001c: Invalid comparison between Unknown and I4
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected F8, but got Unknown
			/*Error: Invalid metadata token*/;
		}
	}

	public extern bool EmitTimesInUnixFormatWhenSaving { get; set; }

	public extern ZipEntryTimestamp Timestamp { get; }

	public extern FileAttributes Attributes { get; set; }

	internal extern string LocalFileName { get; }

	public extern string FileName { get; set; }

	public Stream InputStream
	{
		get; set
		{
			//Discarded unreachable code: IL_0001, IL_000d
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Expected O, but got Unknown
			/*Error: Unknown opcode: 0xF9*/;
		}
	}

	public extern bool InputStreamWasJitProvided { get; }

	public extern ZipEntrySource Source { get; }

	public extern short VersionNeeded { get; }

	public string Comment
	{
		get; set
		{
			//Discarded unreachable code: IL_000f, IL_0015, IL_001e
			//IL_0010: Invalid comparison between Unknown and I4
			_ = 5L;
			/*Error near IL_000a: Invalid metadata token*/;
		}
	}

	public extern bool? RequiresZip64 { get; }

	public extern bool? OutputUsedZip64 { get; }

	public extern short BitField { get; }

	public unsafe CompressionMethod CompressionMethod
	{
		get
		{
			//Discarded unreachable code: IL_0004, IL_0009, IL_000e, IL_0013, IL_001b, IL_002c, IL_0031
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Invalid comparison between Unknown and I4
			//IL_0027: Invalid comparison between I4 and F8
			nuint num = (nuint)/*Error near IL_0001: Stack underflow*/;
			*(nuint*)(nint)/*Error near IL_0002: Stack underflow*/ = num;
			_ = /*Error near IL_0003: Stack underflow*// /*Error near IL_0003: Stack underflow*/;
			/*Error near IL_0003: Unknown opcode: 0xFB*/;
		}
		set
		{
			//Discarded unreachable code: IL_0006, IL_000b, IL_0013
			//IL_000e: Invalid comparison between Unknown and I4
			/*Error near IL_0001: Invalid metadata token*/;
		}
	}

	public CompressionLevel CompressionLevel
	{
		get; set
		{
			while (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
			{
			}
			_ = ((uint[])/*Error near IL_0006: Stack underflow*/)[/*Error near IL_0006: Stack underflow*/];
			/*Error: Unexpected end of block*/;
		}
	}

	public long CompressedSize => (long)/*Error near IL_0002: Stack underflow*/;

	public extern long UncompressedSize { get; }

	public extern double CompressionRatio { get; }

	public extern int Crc { get; }

	public extern bool IsDirectory { get; }

	public extern bool UsesEncryption { get; }

	public EncryptionAlgorithm Encryption
	{
		get; set
		{
			//Discarded unreachable code: IL_0016, IL_001e
			//IL_0019: Invalid comparison between Unknown and I
			while (true)
			{
				if (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0006: Stack underflow*/)
				{
					_ = (short)/*Error near IL_0007: Stack underflow*/;
					/*Error near IL_0008: stloc 0 (out-of-bounds)*/;
					if (3u != 0)
					{
					}
				}
			}
		}
	}

	public string Password
	{
		private get
		{
			//Discarded unreachable code: IL_0008
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected F4, but got I4
			((IntPtr[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = (IntPtr)/*Error near IL_0002: Stack underflow*/;
			checked
			{
				_ = /*Error near IL_0003: Stack underflow*/- /*Error near IL_0003: Stack underflow*/;
				/*Error near IL_0003: Invalid metadata token*/;
			}
		}
		set; }

	internal extern bool IsChanged { get; }

	public extern ExtractExistingFileAction ExtractExistingFile
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern ZipErrorAction ZipErrorAction
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern bool IncludedInMostRecentSave { get; }

	public extern SetCompressionCallback SetCompression
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[Obsolete("Beginning with v1.9.1.6 of DotNetZip, this property is obsolete.  It will be removed in a future version of the library. Your applications should  use AlternateEncoding and AlternateEncodingUsage instead.")]
	public extern bool UseUnicodeAsNecessary { get; set; }

	[Obsolete("This property is obsolete since v1.9.1.6. Use AlternateEncoding and AlternateEncodingUsage instead.", true)]
	public extern Encoding ProvisionalAlternateEncoding
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern Encoding AlternateEncoding
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern ZipOption AlternateEncodingUsage
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public bool IsText
	{
		get
		{
			_ = (double)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 3 (out-of-bounds)*/;
			return (byte)(int)/*OpCode not supported: Nop*/ != 0;
		}
		set; }

	internal extern Stream ArchiveStream { get; }

	internal extern long FileDataPosition { get; }

	private int LengthOfHeader
	{
		get
		{
			//Discarded unreachable code: IL_0005
			/*Error: Invalid metadata token*/;
		}
	}

	private extern string UnsupportedAlgorithm { get; }

	private extern string UnsupportedCompressionMethod { get; }

	internal extern void ResetDirEntry();

	internal static extern ZipEntry ReadDirEntry(ZipFile zf, Dictionary<string, object> previouslySeen);

	internal static extern bool IsNotValidZipDirEntrySig(int signature);

	public extern ZipEntry();

	public extern void SetEntryTimes(DateTime created, DateTime accessed, DateTime modified);

	internal static extern string NameInArchive(string filename, string directoryPathInArchive);

	internal static extern ZipEntry CreateFromNothing(string nameInArchive);

	internal static ZipEntry CreateFromFile(string filename, string nameInArchive)
	{
		//Discarded unreachable code: IL_0001, IL_000b, IL_0012, IL_0018, IL_0025
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got I
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Unknown opcode: 0xFA*/;
	}

	internal static extern ZipEntry CreateForStream(string entryName, Stream s);

	internal static extern ZipEntry CreateForWriter(string entryName, WriteDelegate d);

	internal static extern ZipEntry CreateForJitStreamProvider(string nameInArchive, OpenDelegate opener, CloseDelegate closer);

	internal static ZipEntry CreateForZipOutputStream(string nameInArchive)
	{
		//Discarded unreachable code: IL_0006, IL_0018, IL_001a, IL_001f, IL_0025, IL_002a, IL_0035
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got I4
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0001: Stack underflow*/% /*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	private static extern ZipEntry Create(string nameInArchive, ZipEntrySource source, object arg1, object arg2);

	internal extern void MarkAsDirectory();

	public override extern string ToString();

	private void SetFdpLoh()
	{
		//Discarded unreachable code: IL_0019, IL_0022, IL_0027
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Incompatible stack heights: 0 vs 2
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Invalid comparison between Unknown and I
		do
		{
			_ = 0;
		}
		while (checked(/*Error near IL_0002: ldloc 0 (out-of-bounds)*/ + (sbyte)(object)this) == 0 || /*Error near IL_0014: Stack underflow*/> /*Error near IL_0014: Stack underflow*/);
		/*Error near IL_0014: Invalid metadata token*/;
	}

	internal static extern int GetLengthOfCryptoHeaderBytes(EncryptionAlgorithm a);

	public extern void Extract();

	public void Extract(ExtractExistingFileAction extractExistingFile)
	{
	}

	public extern void Extract(Stream stream);

	public extern void Extract(string baseDirectory);

	public extern void Extract(string baseDirectory, ExtractExistingFileAction extractExistingFile);

	public extern void ExtractWithPassword(string password);

	public extern void ExtractWithPassword(string baseDirectory, string password);

	public extern void ExtractWithPassword(ExtractExistingFileAction extractExistingFile, string password);

	public extern void ExtractWithPassword(string baseDirectory, ExtractExistingFileAction extractExistingFile, string password);

	public extern void ExtractWithPassword(Stream stream, string password);

	public unsafe CrcCalculatorStream OpenReader()
	{
		//Discarded unreachable code: IL_0018
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected I8, but got Unknown
		int num2;
		checked
		{
			while (true)
			{
				byte num = (byte)/*Error near IL_0001: Stack underflow*/;
				/*OpCode not supported: Ckfinite*/;
				_003F val = /*Error near IL_0003: Stack underflow*/- num;
				if (/*Error near IL_0008: Stack underflow*/ <= val)
				{
					((float[])/*Error near IL_0009: Stack underflow*/)[/*Error near IL_0009: Stack underflow*/] = (float)/*Error near IL_0009: Stack underflow*/;
					if (/*Error near IL_000e: Stack underflow*/ > /*Error near IL_000e: Stack underflow*/)
					{
						break;
					}
				}
			}
			num2 = (int)/*Error near IL_000f: Stack underflow*/;
		}
		_003F val2 = /*Error near IL_0010: Stack underflow*/% num2;
		_003F val3 = /*Error near IL_0012: Stack underflow*/- val2;
		*(long*)(nint)/*Error near IL_0013: Stack underflow*/ = (long)val3;
		/*Error near IL_0013: Invalid metadata token*/;
	}

	public CrcCalculatorStream OpenReader(string password)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0027: Invalid comparison between Unknown and I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			_003F val = checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
			if (/*Error near IL_0006: Stack underflow*/ > val)
			{
				continue;
			}
			_003F val2 = ~/*Error near IL_0007: Stack underflow*/;
			if (/*Error near IL_000c: Stack underflow*/ > val2 || /*Error near IL_0012: Stack underflow*/== /*Error near IL_0012: Stack underflow*/|| (int)/*Error near IL_0017: Stack underflow*/ != 0)
			{
				continue;
			}
			byte num = ((byte[])/*Error near IL_001d: Stack underflow*/)[4.252668E-32f];
			if ((int)/*Error near IL_0023: Stack underflow*/ <= (int)num)
			{
				((sbyte[])/*Error near IL_0024: Stack underflow*/)[/*Error near IL_0024: Stack underflow*/] = (sbyte)/*Error near IL_0024: Stack underflow*/;
				/*Error near IL_0025: stloc 0 (out-of-bounds)*/;
				byte num2 = checked((byte)/*Error near IL_0027: Stack underflow*/);
				if ((int)/*Error near IL_002c: Stack underflow*/ == num2)
				{
					break;
				}
			}
		}
		checked
		{
			_ = /*Error near IL_0032: Stack underflow*/* -182885040f;
			/*Error near IL_0032: Invalid metadata token*/;
		}
	}

	internal CrcCalculatorStream InternalOpenReader(string password)
	{
		//Discarded unreachable code: IL_000b, IL_001a, IL_001f
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected I8, but got F8
		checked
		{
			_ = /*Error near IL_0006: Stack underflow*/* -182885040f;
			/*Error near IL_0006: Invalid metadata token*/;
		}
	}

	private extern void OnExtractProgress(long bytesWritten, long totalBytesToWrite);

	private void OnBeforeExtract(string path)
	{
		//Discarded unreachable code: IL_0006, IL_0017, IL_0023, IL_0029, IL_002a
		//IL_0012: Incompatible stack heights: 0 vs 1
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		/*Error near IL_0001: Invalid metadata token*/;
	}

	private extern void OnAfterExtract(string path);

	private extern void OnExtractExisting(string path);

	private static void ReallyDelete(string fileName)
	{
		//Discarded unreachable code: IL_0005, IL_0012
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected I4, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	private extern void WriteStatus(string format, params object[] args);

	private extern void InternalExtract(string baseDir, Stream outstream, string password);

	internal void VerifyCrcAfterExtract(int actualCrc32)
	{
		//Discarded unreachable code: IL_0005, IL_000a, IL_0012
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected I4, but got Unknown
		/*Error: Invalid metadata token*/;
	}

	private extern int CheckExtractExistingFile(string baseDir, string targetFileName);

	private void _CheckRead(int nbytes)
	{
		//Discarded unreachable code: IL_0005, IL_000f, IL_0016, IL_001b, IL_0021, IL_0033
		//IL_0007: Expected native int or pointer, but got O
		//IL_0026: Expected I4, but got I8
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	private extern int ExtractOne(Stream output);

	internal extern Stream GetExtractDecompressor(Stream input2);

	internal unsafe Stream GetExtractDecryptor(Stream input)
	{
		//IL_0003: Invalid comparison between Unknown and I
		IntPtr intPtr;
		do
		{
			/*Error near IL_0001: stloc 0 (out-of-bounds)*/;
			intPtr = *(IntPtr*)(nint)/*Error near IL_0003: Stack underflow*/;
		}
		while ((nint)/*Error near IL_0008: Stack underflow*/ > (nint)intPtr);
		_ = (uint)(*(float*)(nint)/*Error near IL_0009: Stack underflow*/);
		/*Error near IL_000a: Invalid metadata token*/;
	}

	internal extern void _SetTimes(string fileOrDirectory, bool isFile);

	internal void ValidateEncryption()
	{
		/*Error: ldloc 0 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	private void ValidateCompression()
	{
		//Discarded unreachable code: IL_0007, IL_0010, IL_0019
		//IL_0012: Expected O, but got I4
		//IL_0014: Expected O, but got I4
		/*Error near IL_0002: Invalid metadata token*/;
	}

	private unsafe void SetupCryptoForExtract(string password)
	{
		//Discarded unreachable code: IL_000e
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		while ((int)/*Error near IL_0005: Stack underflow*/ != 0)
		{
		}
		int num = *(int*)(*(short*)(nint)/*Error near IL_0006: Stack underflow*/);
		_ = /*Error near IL_0008: Stack underflow*/* num;
		/*Error near IL_0009: Invalid metadata token*/;
	}

	private unsafe bool ValidateOutput(string basedir, Stream outstream, out string outFileName)
	{
		//IL_0010: Expected I4, but got O
		while (/*Error near IL_0005: Stack underflow*/ != /*Error near IL_0005: Stack underflow*/)
		{
		}
		/*Error near IL_0005: stloc 2 (out-of-bounds)*/;
		/*Error near IL_0006: stloc 2 (out-of-bounds)*/;
		switch ((int)(*(object*)(nint)/*Error near IL_000b: Stack underflow*/))
		{
		default:
			;
			break;
		}
		/*Error: Unexpected end of block*/;
	}

	private extern void ReadExtraField();

	private static extern bool ReadHeader(ZipEntry ze, Encoding defaultEncoding);

	internal static extern int ReadWeakEncryptionHeader(Stream s, byte[] buffer);

	private static extern bool IsNotValidSig(int signature);

	internal unsafe static ZipEntry ReadEntry(ZipContainer zc, bool first)
	{
		//Discarded unreachable code: IL_000b, IL_0010, IL_0023
		//IL_0015: Expected F4, but got I4
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Incompatible stack heights: 0 vs 1
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		*(_003F*)(nint)/*Error near IL_0002: Stack underflow*/ = /*Error near IL_0002: Stack underflow*/;
		/*Error near IL_0006: Invalid metadata token*/;
	}

	internal static extern void HandlePK00Prefix(Stream s);

	private static extern void HandleUnexpectedDataDescriptor(ZipEntry entry);

	internal static extern int FindExtraFieldSegment(byte[] extra, int offx, ushort targetHeaderId);

	internal extern int ProcessExtraField(Stream s, short extraFieldLength);

	private extern int ProcessExtraFieldPkwareStrongEncryption(byte[] Buffer, int j);

	private extern int ProcessExtraFieldZip64(byte[] buffer, int j, short dataSize, long posn);

	private unsafe int ProcessExtraFieldInfoZipTimes(byte[] buffer, int j, short dataSize, long posn)
	{
		//Discarded unreachable code: IL_0009, IL_0010, IL_001b, IL_001c, IL_0020
		//IL_000b: Invalid comparison between Unknown and F4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected I8, but got Unknown
		*(sbyte*)(nint)/*Error near IL_0003: Stack underflow*/ = 5;
		checked
		{
			_ = (long)/*Error near IL_0007: Stack underflow*/;
			/*Error near IL_0008: Unknown opcode: 0xFB*/;
		}
	}

	private extern int ProcessExtraFieldUnixTimes(byte[] buffer, int j, short dataSize, long posn);

	private extern int ProcessExtraFieldWindowsTimes(byte[] buffer, int j, short dataSize, long posn);

	internal extern void WriteCentralDirectoryEntry(Stream s);

	private byte[] ConstructExtraField(bool forCentralDirectory)
	{
		/*Error: Invalid metadata token*/;
	}

	private extern string NormalizeFileName();

	private extern byte[] GetEncodedFileNameBytes();

	private extern bool WantReadAgain();

	private extern void MaybeUnsetCompressionMethodForWriting(int cycle);

	internal extern void WriteHeader(Stream s, int cycle);

	private int FigureCrc32()
	{
		//Discarded unreachable code: IL_0009, IL_0010, IL_0013, IL_001f
		//IL_0020: Invalid comparison between Unknown and I4
		_ = 117;
		/*Error near IL_0004: Invalid metadata token*/;
	}

	private extern void PrepSourceStream();

	internal void CopyMetaData(ZipEntry source)
	{
		//Discarded unreachable code: IL_0007
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unsupported input type for neg.
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		long num = ((long[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		((long[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = num;
		/*Error near IL_0006: Unknown opcode: 0xFA*/;
	}

	private extern void OnWriteBlock(long bytesXferred, long totalBytesToXfer);

	private unsafe void _WriteEntryData(Stream s)
	{
		//Discarded unreachable code: IL_0002, IL_000a, IL_000d, IL_0010, IL_001c
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xFD*/;
	}

	private extern long SetInputAndFigureFileLength(ref Stream input);

	internal extern void FinishOutputStream(Stream s, CountingStream entryCounter, Stream encryptor, Stream compressor, CrcCalculatorStream output);

	internal extern void PostProcessOutput(Stream s);

	private extern void SetZip64Flags();

	internal extern void PrepOutputStream(Stream s, long streamLength, out CountingStream outputCounter, out Stream encryptor, out Stream compressor, out CrcCalculatorStream output);

	private extern Stream MaybeApplyCompression(Stream s, long streamLength);

	private unsafe Stream MaybeApplyEncryption(Stream s)
	{
		//Discarded unreachable code: IL_000c, IL_000d, IL_0015, IL_0017
		//IL_0010: Invalid comparison between Unknown and I4
		_ = *(double*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: stloc 2 (out-of-bounds)*/;
		*(_003F*)(nint)/*Error near IL_0003: Stack underflow*/ = /*Error near IL_0003: Stack underflow*/;
		/*Error near IL_0007: Invalid metadata token*/;
	}

	private extern void OnZipErrorWhileSaving(Exception e);

	internal extern void Write(Stream s);

	internal void StoreRelativeOffset()
	{
		while (/*Error near IL_0005: Stack underflow*/ != /*Error near IL_0005: Stack underflow*/)
		{
		}
		_ = -2.04684785594641E+261;
		/*Error near IL_000e: Invalid metadata token*/;
	}

	internal unsafe void NotifySaveComplete()
	{
		//Discarded unreachable code: IL_000c
		int num = *(int*)(nint)/*Error near IL_0001: Stack underflow*/;
		byte num2 = ((byte[])/*Error near IL_0002: Stack underflow*/)[num];
		/*OpCode not supported: Ckfinite*/;
		*(int*)(nint)/*Error near IL_0006: Stack underflow*/ = num2;
		/*Error near IL_0006: stloc 3 (out-of-bounds)*/;
		/*Error near IL_0007: Invalid metadata token*/;
	}

	internal void WriteSecurityMetadata(Stream outstream)
	{
		//Discarded unreachable code: IL_0006
		/*Error near IL_0001: Invalid metadata token*/;
	}

	private extern void CopyThroughOneEntry(Stream outStream);

	private extern void CopyThroughWithRecompute(Stream outstream);

	private void CopyThroughWithNoChange(Stream outstream)
	{
		//Discarded unreachable code: IL_0006, IL_0010
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		_003F val = /*Error near IL_0001: Stack underflow*/% /*Error near IL_0001: Stack underflow*/;
		_003F val2 = /*Error near IL_0003: Stack underflow*/* ~val;
		_ = ((double[])/*Error near IL_0005: Stack underflow*/)[val2];
		/*Error near IL_0005: Unknown opcode: 0xF8*/;
	}

	[Conditional("Trace")]
	private extern void TraceWriteLine(string format, object[] varParams);
}
