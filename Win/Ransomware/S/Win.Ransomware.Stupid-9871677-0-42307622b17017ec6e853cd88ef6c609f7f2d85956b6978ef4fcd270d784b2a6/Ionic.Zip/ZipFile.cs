using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Ionic.Zlib;

namespace Ionic.Zip;

[Guid("ebc25cf6-9120-4283-b972-0e5520d00005")]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class ZipFile : IEnumerable<ZipEntry>, IDisposable, IEnumerable
{
	private class ExtractorSettings
	{
		public SelfExtractorFlavor Flavor;

		public List<string> ReferencedAssemblies;

		public List<string> CopyThroughResources;

		public List<string> ResourcesToCompile;

		public extern ExtractorSettings();
	}

	private TextWriter _StatusMessageTextWriter;

	private bool _CaseSensitiveRetrieval;

	private Stream _readstream;

	private Stream _writestream;

	private ushort _versionMadeBy;

	private ushort _versionNeededToExtract;

	private uint _diskNumberWithCd;

	private int _maxOutputSegmentSize;

	private uint _numberOfSegmentsForMostRecentSave;

	private ZipErrorAction _zipErrorAction;

	private bool _disposed;

	private Dictionary<string, ZipEntry> _entries;

	private List<ZipEntry> _zipEntriesAsList;

	private string _name;

	private string _readName;

	private string _Comment;

	internal string _Password;

	private bool _emitNtfsTimes;

	private bool _emitUnixTimes;

	private CompressionStrategy _Strategy;

	private CompressionMethod _compressionMethod;

	private bool _fileAlreadyExists;

	private string _temporaryFileName;

	private bool _contentsChanged;

	private bool _hasBeenSaved;

	private string _TempFileFolder;

	private bool _ReadStreamIsOurs;

	private object LOCK;

	private bool _saveOperationCanceled;

	private bool _extractOperationCanceled;

	private bool _addOperationCanceled;

	private EncryptionAlgorithm _Encryption;

	private bool _JustSaved;

	private long _locEndOfCDS;

	private uint _OffsetOfCentralDirectory;

	private long _OffsetOfCentralDirectory64;

	private bool? _OutputUsesZip64;

	internal bool _inExtractAll;

	private Encoding _alternateEncoding;

	private ZipOption _alternateEncodingUsage;

	private static Encoding _defaultEncoding;

	private int _BufferSize;

	internal ParallelDeflateOutputStream ParallelDeflater;

	private long _ParallelDeflateThreshold;

	private int _maxBufferPairs;

	internal Zip64Option _zip64;

	private bool _SavingSfx;

	public static readonly int BufferSizeDefault;

	private long _lengthOfReadStream;

	private static ExtractorSettings[] SettingsList;

	public extern string Info { get; }

	public unsafe bool FullScan
	{
		[CompilerGenerated]
		get
		{
			//Discarded unreachable code: IL_0010
			//IL_0001: Invalid comparison between Unknown and I4
			//IL_0003: Incompatible stack heights: 0 vs 1
			do
			{
				int num = checked((int)/*Error near IL_0001: Stack underflow*/);
				if ((int)/*Error near IL_0003: Stack underflow*/ < num)
				{
					_ = (double)/*Error near IL_0004: Stack underflow*/;
				}
			}
			while (/*Error near IL_0009: Stack underflow*/ <= /*Error near IL_0009: Stack underflow*/);
			*(_003F*)(nint)/*Error near IL_000a: Stack underflow*/ = /*Error near IL_000a: Stack underflow*/;
			/*Error near IL_000b: Invalid metadata token*/;
		}
		[CompilerGenerated]
		set;
	}

	public extern bool SortEntriesBeforeSaving
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public bool AddDirectoryWillTraverseReparsePoints
	{
		[CompilerGenerated]
		get
		{
			//Discarded unreachable code: IL_0008
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
				_ = 2;
				/*Error near IL_0003: Invalid metadata token*/;
			}
		}
		[CompilerGenerated]
		set;
	}

	public unsafe int BufferSize
	{
		get; set
		{
			//Discarded unreachable code: IL_0010, IL_0015, IL_002a, IL_002f, IL_003b
			//IL_0002: Invalid comparison between Unknown and F8
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Incompatible stack heights: 0 vs 2
			((float[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (float)/*Error near IL_0001: Stack underflow*/;
			double num = ((double[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/];
			if (!((double)/*Error near IL_0004: Stack underflow*/ > num))
			{
				/*OpCode not supported: DebugBreak*/;
				long num2 = *(long*)(int)((ushort[])checked((ulong)/*Error near IL_0006: Stack underflow*/))[(object)this];
				_ = /*Error near IL_000d: Stack underflow*/- num2;
				/*Error near IL_000e: Unknown opcode: 0xFF*/;
			}
			/*Error near IL_000f: Unknown opcode: 0xFF*/;
		}
	}

	public extern int CodecBufferSize
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern bool FlattenFoldersOnExtract
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern CompressionStrategy Strategy { get; set; }

	public extern string Name { get; set; }

	public extern CompressionLevel CompressionLevel
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public CompressionMethod CompressionMethod
	{
		get
		{
			//Discarded unreachable code: IL_000f, IL_0017, IL_0020, IL_0029
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Invalid comparison between Unknown and I4
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			while ((int)/*Error near IL_0005: Stack underflow*/ == 0)
			{
			}
			_ = ((float[])/*Error near IL_0006: Stack underflow*/)[/*Error near IL_0006: Stack underflow*/];
			/*OpCode not supported: Ckfinite*/;
			checked
			{
				_ = (nint)(object)null;
				/*Error near IL_000a: Invalid metadata token*/;
			}
		}
		set; }

	public extern string Comment { get; set; }

	public extern bool EmitTimesInWindowsFormatWhenSaving { get; set; }

	public bool EmitTimesInUnixFormatWhenSaving
	{
		get
		{
			//Discarded unreachable code: IL_0010, IL_0016, IL_001c
			//IL_0000: Unsupported input type for neg.
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0003: Invalid comparison between Unknown and I4
			_003F val;
			do
			{
				val = 0 - /*Error near IL_0001: Stack underflow*/;
			}
			while ((int)/*Error near IL_0008: Stack underflow*/ >= (int)val);
			_003F val2 = /*Error near IL_0008: ldarg 3 (out-of-bounds)*/;
			_ = ((object[])/*Error near IL_000b: Stack underflow*/)[val2];
			/*Error near IL_000b: Invalid metadata token*/;
		}
		set; }

	internal extern bool Verbose { get; }

	public unsafe bool CaseSensitiveRetrieval
	{
		get; set
		{
			//Discarded unreachable code: IL_0012, IL_001c
			//IL_000a: Expected O, but got I4
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			if (*(short*)(nint)/*Error near IL_0001: Stack underflow*/ == 0)
			{
				IntPtr intPtr = (nint)((Array)0).LongLength;
				((IntPtr[])/*Error near IL_000b: Stack underflow*/)[/*Error near IL_000b: Stack underflow*/] = intPtr;
				_ = ((ushort[])/*Error near IL_000d: Stack underflow*/)[3];
				/*Error near IL_000d: Invalid metadata token*/;
			}
			_ = /*Error near IL_0018: Stack underflow*/>> (int)/*Error near IL_0018: Stack underflow*/;
			/*Error near IL_0018: ldloc 2 (out-of-bounds)*/;
			/*Error near IL_001b: Unknown opcode: 0xF9*/;
		}
	}

	[Obsolete("Beginning with v1.9.1.6 of DotNetZip, this property is obsolete.  It will be removed in a future version of the library. Your applications should  use AlternateEncoding and AlternateEncodingUsage instead.")]
	public extern bool UseUnicodeAsNecessary { get; set; }

	public extern Zip64Option UseZip64WhenSaving { get; set; }

	public extern bool? RequiresZip64 { get; }

	public extern bool? OutputUsedZip64 { get; }

	public unsafe bool? InputUsesZip64
	{
		get
		{
			//Discarded unreachable code: IL_0009, IL_001c
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Invalid comparison between Unknown and I4
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
			nint num = checked((nint)/*Error near IL_0002: Stack underflow*/);
			((int[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = (int)num;
			/*Error near IL_0003: ldarg 3 (out-of-bounds)*/;
			/*Error near IL_0004: Invalid metadata token*/;
		}
	}

	[Obsolete("use AlternateEncoding instead.")]
	public Encoding ProvisionalAlternateEncoding
	{
		get
		{
			//Discarded unreachable code: IL_0005, IL_000b, IL_0011, IL_0018, IL_0024, IL_0026, IL_002d
			//IL_000f: Expected I8, but got I4
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Invalid comparison between Unknown and F4
			//IL_001f: Expected I4, but got O
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Expected native int or pointer, but got O
			/*Error: Invalid metadata token*/;
		}
		set; }

	public extern Encoding AlternateEncoding { get; set; }

	public extern ZipOption AlternateEncodingUsage { get; set; }

	public static extern Encoding DefaultEncoding { get; }

	public extern TextWriter StatusMessageTextWriter { get; set; }

	public extern string TempFileFolder { get; set; }

	public extern string Password { private get; set; }

	public ExtractExistingFileAction ExtractExistingFile
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set
		{
			checked
			{
				_ = (sbyte)/*Error near IL_0001: Stack underflow*/;
				/*Error near IL_0001: Invalid metadata token*/;
			}
		}
	}

	public ZipErrorAction ZipErrorAction
	{
		get
		{
			//Discarded unreachable code: IL_0005
			while (true)
			{
			}
		}
		set; }

	public extern EncryptionAlgorithm Encryption { get; set; }

	public extern SetCompressionCallback SetCompression
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern int MaxOutputSegmentSize { get; set; }

	public extern int NumberOfSegmentsForMostRecentSave { get; }

	public long ParallelDeflateThreshold
	{
		get; set
		{
			/*Error: Invalid metadata token*/;
		}
	}

	public extern int ParallelDeflateMaxBufferPairs { get; set; }

	public static extern Version LibraryVersion { get; }

	private extern List<ZipEntry> ZipEntriesAsList { get; }

	public extern ZipEntry this[int ix] { get; }

	public unsafe ZipEntry this[string fileName]
	{
		get
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Invalid comparison between Unknown and I4
			while (true)
			{
				IntPtr intPtr = *(IntPtr*)1;
				sbyte num;
				checked
				{
					num = (sbyte)(/*Error near IL_0005: Stack underflow*/ | unchecked((nint)intPtr));
				}
				if ((int)/*Error near IL_000c: Stack underflow*/ <= (int)num)
				{
					_003F val = /*Error near IL_000d: Stack underflow*/<< (int)/*Error near IL_000d: Stack underflow*/;
					double num2 = *(double*)(nint)(/*Error near IL_000e: Stack underflow*/ % val);
					int num3;
					checked
					{
						num3 = (int)unchecked(/*Error near IL_0010: Stack underflow*/ / num2);
					}
					if ((int)/*Error near IL_0016: Stack underflow*/ > num3)
					{
						/*Error: Could not find block for branch target IL_0016*/;
					}
				}
			}
		}
	}

	public extern ICollection<string> EntryFileNames { get; }

	public extern ICollection<ZipEntry> Entries { get; }

	public extern ICollection<ZipEntry> EntriesSorted { get; }

	public extern int Count { get; }

	internal unsafe Stream ReadStream
	{
		get
		{
			//Discarded unreachable code: IL_0008, IL_000d, IL_0015, IL_001a, IL_0020, IL_0025
			//IL_0002: Expected I4, but got F8
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			double num = *(double*)(nint)/*Error near IL_0001: Stack underflow*/;
			((sbyte[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = (sbyte)(int)num;
			_ = /*Error near IL_0003: Stack underflow*/<< (int)/*Error near IL_0003: Stack underflow*/;
			/*Error near IL_0003: Invalid metadata token*/;
		}
	}

	private unsafe Stream WriteStream
	{
		get
		{
			//Discarded unreachable code: IL_000e
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Invalid comparison between Unknown and I4
			while (true)
			{
				if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
				{
					ushort num = *(ushort*)(nint)(/*Error near IL_0007: Stack underflow*/ / /*Error near IL_0007: Stack underflow*/);
					if ((int)/*Error near IL_000d: Stack underflow*/ <= (int)num)
					{
						break;
					}
				}
			}
			/*Error near IL_000d: Unknown opcode: 0xFA*/;
		}
		set; }

	private extern string ArchiveNameForEvent { get; }

	private extern long LengthOfReadStream { get; }

	public extern event EventHandler<SaveProgressEventArgs> SaveProgress;

	public extern event EventHandler<ReadProgressEventArgs> ReadProgress;

	public event EventHandler<ExtractProgressEventArgs> ExtractProgress
	{
		[CompilerGenerated]
		add
		{
			//Discarded unreachable code: IL_0009
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			sbyte num = (sbyte)/*Error near IL_0001: Stack underflow*/;
			checked
			{
				_ = unchecked((uint)num) + unchecked((uint)num);
				/*Error near IL_0004: Invalid metadata token*/;
			}
		}
		[CompilerGenerated]
		remove;
	}

	public event EventHandler<AddProgressEventArgs> AddProgress
	{
		[CompilerGenerated]
		add;
		[CompilerGenerated]
		remove
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			_ = /*Error near IL_0001: Stack underflow*/- /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0003: Invalid metadata token*/;
		}
	}

	public event EventHandler<ZipErrorEventArgs> ZipError
	{
		[CompilerGenerated]
		add
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			while (true)
			{
				_003F val = /*Error near IL_0001: Stack underflow*/& /*Error near IL_0001: Stack underflow*/;
				if (/*Error near IL_0006: Stack underflow*/ > val)
				{
					/*Error: Could not find block for branch target IL_0006*/;
				}
			}
		}
		[CompilerGenerated]
		remove;
	}

	public extern ZipEntry AddItem(string fileOrDirectoryName);

	public ZipEntry AddItem(string fileOrDirectoryName, string directoryPathInArchive)
	{
		//Discarded unreachable code: IL_0001, IL_0009, IL_000b, IL_0010, IL_0013, IL_0016
		//IL_0004: Expected F8, but got I4
		//IL_0011: Invalid comparison between Unknown and I4
		/*Error: Unknown opcode: 0xFD*/;
	}

	public extern ZipEntry AddFile(string fileName);

	public ZipEntry AddFile(string fileName, string directoryPathInArchive)
	{
		while (true)
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
			{
				((float[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (float)/*Error near IL_0008: Stack underflow*/;
			}
		}
	}

	public unsafe void RemoveEntries(ICollection<ZipEntry> entriesToRemove)
	{
		//Discarded unreachable code: IL_0009, IL_0011, IL_0019
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		_ = -checked((short)(*unchecked((uint*)(nint)/*Error near IL_0001: Stack underflow*/)));
		/*Error near IL_0004: Invalid metadata token*/;
	}

	public extern void RemoveEntries(ICollection<string> entriesToRemove);

	public void AddFiles(IEnumerable<string> fileNames)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0002: ldloc 0 (out-of-bounds)*/;
			/*Error near IL_0003: Invalid metadata token*/;
		}
	}

	public extern void UpdateFiles(IEnumerable<string> fileNames);

	public extern void AddFiles(IEnumerable<string> fileNames, string directoryPathInArchive);

	public extern void AddFiles(IEnumerable<string> fileNames, bool preserveDirHierarchy, string directoryPathInArchive);

	public extern void UpdateFiles(IEnumerable<string> fileNames, string directoryPathInArchive);

	public extern ZipEntry UpdateFile(string fileName);

	public extern ZipEntry UpdateFile(string fileName, string directoryPathInArchive);

	public extern ZipEntry UpdateDirectory(string directoryName);

	public extern ZipEntry UpdateDirectory(string directoryName, string directoryPathInArchive);

	public extern void UpdateItem(string itemName);

	public extern void UpdateItem(string itemName, string directoryPathInArchive);

	public ZipEntry AddEntry(string entryName, string content)
	{
		//Discarded unreachable code: IL_000f, IL_0015, IL_001a, IL_0020
		//IL_0002: Invalid comparison between Unknown and I
		//IL_0026: Expected I8, but got I4
		IntPtr intPtr;
		do
		{
			intPtr = (nint)((Array)/*Error near IL_0001: Stack underflow*/).LongLength;
		}
		while ((nint)/*Error near IL_0007: Stack underflow*/ == (nint)intPtr);
		/*Error near IL_0007: stloc 2 (out-of-bounds)*/;
		_ = 3;
		/*Error near IL_000a: Invalid metadata token*/;
	}

	public extern ZipEntry AddEntry(string entryName, string content, Encoding encoding);

	public extern ZipEntry AddEntry(string entryName, Stream stream);

	public extern ZipEntry AddEntry(string entryName, WriteDelegate writer);

	public extern ZipEntry AddEntry(string entryName, OpenDelegate opener, CloseDelegate closer);

	private extern ZipEntry _InternalAddEntry(ZipEntry ze);

	public extern ZipEntry UpdateEntry(string entryName, string content);

	public extern ZipEntry UpdateEntry(string entryName, string content, Encoding encoding);

	public extern ZipEntry UpdateEntry(string entryName, WriteDelegate writer);

	public extern ZipEntry UpdateEntry(string entryName, OpenDelegate opener, CloseDelegate closer);

	public extern ZipEntry UpdateEntry(string entryName, Stream stream);

	private extern void RemoveEntryForUpdate(string entryName);

	public extern ZipEntry AddEntry(string entryName, byte[] byteContent);

	public extern ZipEntry UpdateEntry(string entryName, byte[] byteContent);

	public extern ZipEntry AddDirectory(string directoryName);

	public extern ZipEntry AddDirectory(string directoryName, string directoryPathInArchive);

	public unsafe ZipEntry AddDirectoryByName(string directoryNameInArchive)
	{
		//Discarded unreachable code: IL_0016
		//IL_000b: Expected F8, but got I
		//IL_0015: Expected F8, but got I
		//IL_0014: Expected native int or pointer, but got F8
		//IL_001a: Expected O, but got I4
		while ((int)/*Error near IL_0005: Stack underflow*/ == 0)
		{
		}
		/*Error near IL_0005: stloc 0 (out-of-bounds)*/;
		short num = (short)/*Error near IL_0007: Stack underflow*/;
		((sbyte[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (sbyte)num;
		IntPtr intPtr = (nint)((Array)/*Error near IL_000a: Stack underflow*/).LongLength;
		((double[])/*Error near IL_000b: Stack underflow*/)[/*Error near IL_000b: Stack underflow*/] = (nint)intPtr;
		ulong num2 = (ulong)/*Error near IL_000c: Stack underflow*/;
		*(double*)(nint)((double[])/*Error near IL_000d: Stack underflow*/)[num2] = unchecked((nint)4243782818u);
		/*Error near IL_0015: Unknown opcode: 0xF8*/;
	}

	private extern ZipEntry AddOrUpdateDirectoryImpl(string directoryName, string rootDirectoryPathInArchive, AddOrUpdateAction action);

	internal extern void InternalAddEntry(string name, ZipEntry entry);

	private extern ZipEntry AddOrUpdateDirectoryImpl(string directoryName, string rootDirectoryPathInArchive, AddOrUpdateAction action, bool recurse, int level);

	public static extern bool CheckZip(string zipFileName);

	public unsafe static bool CheckZip(string zipFileName, bool fixIfNecessary, TextWriter writer)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got F8
		/*Error: stloc 3 (out-of-bounds)*/;
		_ = /*Error near IL_0002: Stack underflow*/^ /*Error near IL_0002: Stack underflow*/;
		zipFileName = (string)(-5.403046123548577E+221);
		_ = *(sbyte*)(nint)/*Error near IL_000e: ldloca 0 (out-of-bounds)*/;
		/*Error near IL_0011: Unknown opcode: 0xFB*/;
	}

	public static extern void FixZipDirectory(string zipFileName);

	public static extern bool CheckZipPassword(string zipFileName, string password);

	public extern bool ContainsEntry(string name);

	public override extern string ToString();

	internal unsafe void NotifyEntryChanged()
	{
		//Discarded unreachable code: IL_0012, IL_0018, IL_001d
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Incompatible stack heights: 0 vs 1
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		_003F val;
		do
		{
			*(IntPtr*)(nint)/*Error near IL_0002: Stack underflow*/ = (IntPtr)3;
			checked
			{
				_ = /*Error near IL_0004: Stack underflow*/* /*Error near IL_0004: Stack underflow*/;
				val = /*Error near IL_0004: ldloc 3 (out-of-bounds)*/;
				/*OpCode not supported: Ckfinite*/;
			}
		}
		while ((int)val != 0);
		_ = (byte)(/*Error near IL_000f: Stack underflow*/ >> (int)/*Error near IL_000f: Stack underflow*/);
		/*Error near IL_0011: Unknown opcode: 0xFC*/;
	}

	internal Stream StreamForDiskNumber(uint diskNumber)
	{
		//Discarded unreachable code: IL_0009, IL_000f, IL_0014, IL_001c, IL_0025, IL_002c
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		while ((int)/*Error near IL_0005: Stack underflow*/ != 0)
		{
		}
		_ = (byte)(/*Error near IL_0006: Stack underflow*/ >> (int)/*Error near IL_0006: Stack underflow*/);
		/*Error near IL_0008: Unknown opcode: 0xFC*/;
	}

	internal void Reset(bool whileSaving)
	{
		//Discarded unreachable code: IL_0006
		//IL_0015: Expected I4, but got Unknown
		while (true)
		{
			/*Error: stloc 0 (out-of-bounds)*/;
		}
	}

	public unsafe ZipFile(string fileName)
	{
		//Discarded unreachable code: IL_0013, IL_0018, IL_002c, IL_0031, IL_0037
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected O, but got Unknown
		//IL_0024: Expected F8, but got I8
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Incompatible stack heights: 0 vs 1
		do
		{
			short num = checked((short)/*Error near IL_0001: Stack underflow*/);
			_003F val = /*Error near IL_0002: Stack underflow*/% num;
			*(_003F*)(nint)/*Error near IL_0003: Stack underflow*/ = val;
			*(_003F*)(nint)/*Error near IL_0004: Stack underflow*/ = /*Error near IL_0004: Stack underflow*/;
			/*Error near IL_0004: stloc 0 (out-of-bounds)*/;
			*(_003F*)(nint)/*Error near IL_0008: Stack underflow*/ = /*Error near IL_0008: Stack underflow*/;
		}
		while (/*Error near IL_000d: Stack underflow*/ > /*Error near IL_000d: Stack underflow*/);
		/*Error near IL_000e: Invalid metadata token*/;
	}

	public extern ZipFile(string fileName, Encoding encoding);

	public extern ZipFile();

	public ZipFile(Encoding encoding)
	{
		//IL_0002: Expected F8, but got I8
		ulong num = checked((ulong)/*Error near IL_0001: Stack underflow*/);
		((double[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = (long)num;
		/*Error: Unexpected end of block*/;
	}

	public extern ZipFile(string fileName, TextWriter statusMessageWriter);

	public extern ZipFile(string fileName, TextWriter statusMessageWriter, Encoding encoding);

	public extern void Initialize(string fileName);

	private void _initEntriesDictionary()
	{
		//Discarded unreachable code: IL_0005, IL_000a, IL_0015, IL_001c, IL_0027
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
		}
	}

	private extern void _InitInstance(string zipFileName, TextWriter statusMessageWriter);

	public extern void RemoveEntry(ZipEntry entry);

	public extern void RemoveEntry(string fileName);

	public extern void Dispose();

	protected virtual extern void Dispose(bool disposeManagedResources);

	internal extern bool OnSaveBlock(ZipEntry entry, long bytesXferred, long totalBytesToXfer);

	private extern void OnSaveEntry(int current, ZipEntry entry, bool before);

	private extern void OnSaveEvent(ZipProgressEventType eventFlavor);

	private extern void OnSaveStarted();

	private unsafe void OnSaveCompleted()
	{
		//Discarded unreachable code: IL_001d, IL_0025, IL_002c, IL_0031, IL_0039, IL_003e
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected I4, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Invalid comparison between Unknown and I4
		while (true)
		{
			_003F val = /*Error: ldloc 2 (out-of-bounds)*/;
			if (/*Error near IL_0002: Stack underflow*/ >> (int)val != 0 && checked((uint)unchecked((nuint)checked((nint)/*Error near IL_000a: Stack underflow*/))) != 0)
			{
				_003F val2 = /*Error near IL_0010: ldarg 3 (out-of-bounds)*/;
				((int[])/*Error near IL_0012: Stack underflow*/)[/*Error near IL_0012: Stack underflow*/] = (int)val2;
				if (/*Error near IL_0017: Stack underflow*/ > /*Error near IL_0017: Stack underflow*/)
				{
					break;
				}
			}
		}
		long num = checked((long)/*Error near IL_0018: Stack underflow*/);
		int num2 = *(int*)(nint)/*Error near IL_0018: ldloc 0 (out-of-bounds)*/;
		((IntPtr[])/*Error near IL_001c: Stack underflow*/)[num] = (IntPtr)num2;
		/*Error near IL_001c: Unknown opcode: 0xFF*/;
	}

	private extern void OnReadStarted();

	private extern void OnReadCompleted();

	internal extern void OnReadBytes(ZipEntry entry);

	internal extern void OnReadEntry(bool before, ZipEntry entry);

	private extern void OnExtractEntry(int current, bool before, ZipEntry currentEntry, string path);

	internal extern bool OnExtractBlock(ZipEntry entry, long bytesWritten, long totalBytesToWrite);

	internal extern bool OnSingleEntryExtract(ZipEntry entry, string path, bool before);

	internal extern bool OnExtractExisting(ZipEntry entry, string path);

	private extern void OnExtractAllCompleted(string path);

	private extern void OnExtractAllStarted(string path);

	private extern void OnAddStarted();

	private extern void OnAddCompleted();

	internal extern void AfterAddEntry(ZipEntry entry);

	internal extern bool OnZipErrorSaving(ZipEntry entry, Exception exc);

	public extern void ExtractAll(string path);

	public unsafe void ExtractAll(string path, ExtractExistingFileAction extractExistingFile)
	{
		//Discarded unreachable code: IL_0014, IL_0019, IL_0024
		//IL_0005: Invalid comparison between Unknown and I
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		nint num;
		do
		{
			num = (nint)8;
		}
		while ((nint)/*Error near IL_000a: Stack underflow*/ < num);
		_ = *(ushort*)(nint)/*Error near IL_000b: Stack underflow*/ ^ this;
		/*Error near IL_000f: Invalid metadata token*/;
	}

	private extern void _InternalExtractAll(string path, bool overrideExtractExistingProperty);

	public static extern ZipFile Read(string fileName);

	public static extern ZipFile Read(string fileName, ReadOptions options);

	private unsafe static ZipFile Read(string fileName, TextWriter statusMessageWriter, Encoding encoding, EventHandler<ReadProgressEventArgs> readProgress)
	{
		//Discarded unreachable code: IL_0019, IL_001e, IL_0023
		//IL_001d: Expected F8, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
			short num = ((short[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/];
			if ((ulong)(int)((uint[])/*Error near IL_0004: Stack underflow*/)[num] < 4uL)
			{
				*(_003F*)(nint)/*Error near IL_0013: Stack underflow*/ = /*Error near IL_0013: Stack underflow*/;
			}
		}
	}

	public static extern ZipFile Read(Stream zipStream);

	public static extern ZipFile Read(Stream zipStream, ReadOptions options);

	private static ZipFile Read(Stream zipStream, TextWriter statusMessageWriter, Encoding encoding, EventHandler<ReadProgressEventArgs> readProgress)
	{
		//Discarded unreachable code: IL_000f, IL_0016, IL_001c, IL_0022, IL_0027, IL_002c, IL_0032, IL_003b
		//IL_0017: Invalid comparison between Unknown and I4
		//IL_002d: Invalid comparison between Unknown and I
		//IL_0035: Expected I8, but got O
		while (/*Error near IL_0005: Stack underflow*/ <= /*Error near IL_0005: Stack underflow*/|| /*Error near IL_000a: Stack underflow*/!= /*Error near IL_000a: Stack underflow*/)
		{
		}
		/*Error near IL_000a: Invalid metadata token*/;
	}

	private static extern void ReadIntoInstance(ZipFile zf);

	private static extern void Zip64SeekToCentralDirectory(ZipFile zf);

	private static extern uint ReadFirstFourBytes(Stream s);

	private static extern void ReadCentralDirectory(ZipFile zf);

	private static extern void ReadIntoInstance_Orig(ZipFile zf);

	private static extern void ReadCentralDirectoryFooter(ZipFile zf);

	private static extern void ReadZipFileComment(ZipFile zf);

	public static extern bool IsZipFile(string fileName);

	public static bool IsZipFile(string fileName, bool testExtract)
	{
		//Discarded unreachable code: IL_0007, IL_000d, IL_0013
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0002: Stack underflow*/>> 2;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	public static bool IsZipFile(Stream stream, bool testExtract)
	{
		//Discarded unreachable code: IL_000d, IL_0015, IL_001c
		//IL_0004: Expected O, but got F8
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Invalid comparison between Unknown and I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and O
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected F4, but got I
		//IL_0027: Expected F8, but got I
		/*Error near IL_0001: stloc 3 (out-of-bounds)*/;
		double num = ((double[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/];
		((object[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/] = num;
		ulong num2;
		checked
		{
			num2 = (ulong)unchecked((int)/*Error near IL_0006: Stack underflow*/);
		}
		_ = /*Error near IL_0008: Stack underflow*// num2;
		/*Error near IL_0008: Invalid metadata token*/;
	}

	private void DeleteFileWithRetry(string filename)
	{
		//IL_0003: Invalid comparison between Unknown and I8
		ulong num;
		do
		{
			num = (uint)(int)/*Error near IL_0001: Stack underflow*/;
		}
		while ((long)/*Error near IL_0008: Stack underflow*/ != (long)num);
		_ = ((byte[])/*Error near IL_0013: Stack underflow*/)[1.6885682131964345E-46];
		/*Error: Unexpected end of block*/;
	}

	public extern void Save();

	private static extern void NotifyEntriesSaveComplete(ICollection<ZipEntry> c);

	private unsafe void RemoveTempFile()
	{
		//Discarded unreachable code: IL_0013, IL_0016, IL_001e, IL_0026
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected O, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between Unknown and I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		do
		{
			_003F val = /*Error near IL_0001: Stack underflow*/>> (int)/*Error near IL_0001: Stack underflow*/;
			*(_003F*)(nint)/*Error near IL_0003: Stack underflow*/ = val;
			/*OpCode not supported: Ckfinite*/;
		}
		while (/*Error near IL_000a: Stack underflow*/ < /*Error near IL_000a: Stack underflow*/);
		((object[])/*Error near IL_000b: Stack underflow*/)[/*Error near IL_000b: Stack underflow*/] = (object)/*Error near IL_000b: Stack underflow*/;
		checked
		{
			_ = (nuint)unchecked(/*Error near IL_000c: Stack underflow*/ * /*Error near IL_000c: Stack underflow*/);
			/*Error near IL_000e: Invalid metadata token*/;
		}
	}

	private extern void CleanupAfterSaveOperation();

	public extern void Save(string fileName);

	public void Save(Stream outputStream)
	{
		//Discarded unreachable code: IL_000b, IL_0015
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (nuint)/*Error near IL_0001: Stack underflow*/;
			_ = -229620720;
			/*Error near IL_0006: Invalid metadata token*/;
		}
	}

	public extern void SaveSelfExtractor(string exeToGenerate, SelfExtractorFlavor flavor);

	public extern void SaveSelfExtractor(string exeToGenerate, SelfExtractorSaveOptions options);

	private static extern void ExtractResourceToFile(Assembly a, string resourceName, string filename);

	private extern void _SaveSfxStub(string exeToGenerate, SelfExtractorSaveOptions options);

	internal static extern string GenerateTempPathname(string dir, string extension);

	public extern void AddSelectedFiles(string selectionCriteria);

	public extern void AddSelectedFiles(string selectionCriteria, bool recurseDirectories);

	public unsafe void AddSelectedFiles(string selectionCriteria, string directoryOnDisk)
	{
		//IL_0004: Invalid comparison between Unknown and I4
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Incompatible stack heights: 0 vs 1
		//IL_0012: Expected F4, but got I8
		while (true)
		{
			sbyte num = ((sbyte[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
			byte num2 = *(byte*)((int[])/*Error near IL_0002: Stack underflow*/)[num];
			if ((int)/*Error near IL_0009: Stack underflow*/ >= (int)num2)
			{
				_ = /*Error near IL_000a: Stack underflow*/>> (int)/*Error near IL_000a: Stack underflow*/;
				if (1 == 0)
				{
					break;
				}
			}
		}
		ulong num3 = checked((ulong)/*Error near IL_0011: Stack underflow*/);
		*(float*)(nint)/*Error near IL_0012: Stack underflow*/ = (long)num3;
		/*Error near IL_0013: Invalid metadata token*/;
	}

	public extern void AddSelectedFiles(string selectionCriteria, string directoryOnDisk, bool recurseDirectories);

	public void AddSelectedFiles(string selectionCriteria, string directoryOnDisk, string directoryPathInArchive)
	{
		//Discarded unreachable code: IL_000a
		//IL_0013: Expected I4, but got Unknown
		checked
		{
			_ = (long)/*Error near IL_0001: Stack underflow*/;
			_ = (sbyte)/*Error near IL_0001: ldloc 2 (out-of-bounds)*/;
			/*Error near IL_0005: Invalid metadata token*/;
		}
	}

	public void AddSelectedFiles(string selectionCriteria, string directoryOnDisk, string directoryPathInArchive, bool recurseDirectories)
	{
		//IL_0008: Expected I4, but got Unknown
		checked
		{
			_ = (ushort)/*Error near IL_0001: Stack underflow*/;
		}
		switch ((int)/*Error near IL_0001: ldloc 0 (out-of-bounds)*/)
		{
		default:
			;
			break;
		}
		/*Error: Unexpected end of block*/;
	}

	public extern void UpdateSelectedFiles(string selectionCriteria, string directoryOnDisk, string directoryPathInArchive, bool recurseDirectories);

	private extern string EnsureendInSlash(string s);

	private extern void _AddOrUpdateSelectedFiles(string selectionCriteria, string directoryOnDisk, string directoryPathInArchive, bool recurseDirectories, bool wantUpdate);

	private static extern string ReplaceLeadingDirectory(string original, string pattern, string replacement);

	public extern ICollection<ZipEntry> SelectEntries(string selectionCriteria);

	public ICollection<ZipEntry> SelectEntries(string selectionCriteria, string directoryPathInArchive)
	{
		//Discarded unreachable code: IL_0009, IL_000e, IL_0015, IL_001d, IL_001e, IL_0029, IL_0037, IL_003c, IL_0041, IL_0043
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_0010: Invalid comparison between Unknown and I4
		//IL_0017: Expected F8, but got O
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected F8, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unsupported input type for neg.
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		uint num;
		do
		{
			num = checked((uint)/*Error near IL_0002: Stack underflow*/);
		}
		while ((int)/*Error near IL_0008: Stack underflow*/ >= (int)num);
		/*Error near IL_0008: Unknown opcode: 0xFB*/;
	}

	public unsafe int RemoveSelectedEntries(string selectionCriteria)
	{
		//Discarded unreachable code: IL_0005
		sbyte num = *(sbyte*)null;
		*(short*)(nint)/*Error near IL_0004: Stack underflow*/ = num;
		/*Error near IL_0004: Unknown opcode: 0xF8*/;
	}

	public extern int RemoveSelectedEntries(string selectionCriteria, string directoryPathInArchive);

	public extern void ExtractSelectedEntries(string selectionCriteria);

	public extern void ExtractSelectedEntries(string selectionCriteria, ExtractExistingFileAction extractExistingFile);

	public extern void ExtractSelectedEntries(string selectionCriteria, string directoryPathInArchive);

	public extern void ExtractSelectedEntries(string selectionCriteria, string directoryInArchive, string extractDirectory);

	public unsafe void ExtractSelectedEntries(string selectionCriteria, string directoryPathInArchive, string extractDirectory, ExtractExistingFileAction extractExistingFile)
	{
		//Discarded unreachable code: IL_0019, IL_002f, IL_0034
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected F8, but got I4
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected F8, but got Unknown
		//IL_002a: Invalid comparison between Unknown and I
		do
		{
			_003F val = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			object obj = ((object[])/*Error near IL_0003: Stack underflow*/)[val];
			*(short*)(nint)/*Error near IL_0005: Stack underflow*/ = (short)(nint)obj;
			((double[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = -95.0;
		}
		while ((int)/*Error near IL_000d: Stack underflow*/ != 0);
		byte num = *(byte*)(nint)/*Error near IL_0011: Stack underflow*/;
		double num2 = ((double[])/*Error near IL_0012: Stack underflow*/)[num];
		_ = ((float[])/*Error near IL_0014: Stack underflow*/)[num2];
		/*Error near IL_0014: Invalid metadata token*/;
	}

	public IEnumerator<ZipEntry> GetEnumerator()
	{
		//Discarded unreachable code: IL_0007, IL_000b, IL_0013, IL_001c
		//IL_0002: Incompatible stack heights: 0 vs 1
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Invalid comparison between Unknown and I4
		checked
		{
			while (true)
			{
				_ = (sbyte)/*Error near IL_0001: Stack underflow*/;
			}
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		//Discarded unreachable code: IL_0005, IL_000d
		/*Error: Invalid metadata token*/;
	}

	[DispId(-4)]
	public extern IEnumerator GetNewEnum();
}
