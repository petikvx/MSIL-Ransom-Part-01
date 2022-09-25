using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Ionic.Zlib;

namespace Ionic.Zip;

[Guid("ebc25cf6-9120-4283-b972-0e5520d00005")]
[ComVisible(true)]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
public class ZipFile : IEnumerable<ZipEntry>, IDisposable, IEnumerable
{
	private TextWriter _StatusMessageTextWriter;

	private bool _CaseSensitiveRetrieval;

	private bool _IgnoreDuplicateFiles;

	private Stream _readstream;

	private Stream _writestream;

	private ushort _versionMadeBy;

	private ushort _versionNeededToExtract;

	private uint _diskNumberWithCd;

	private long _maxOutputSegmentSize;

	private uint _numberOfSegmentsForMostRecentSave;

	private ZipErrorAction _zipErrorAction;

	private bool _disposed;

	private Dictionary<string, ZipEntry> _entries;

	private Dictionary<string, ZipEntry> _entriesInsensitive;

	private List<ZipEntry> _zipEntriesAsList;

	private string _name;

	private string _readName;

	private string _Comment;

	internal string _Password;

	private bool _emitNtfsTimes = true;

	private bool _emitUnixTimes;

	private CompressionStrategy _Strategy;

	private CompressionMethod _compressionMethod = CompressionMethod.Deflate;

	private bool _fileAlreadyExists;

	private string _temporaryFileName;

	private bool _contentsChanged;

	private bool _hasBeenSaved;

	private string _TempFileFolder;

	private bool _ReadStreamIsOurs = true;

	private object LOCK = new object();

	private bool _saveOperationCanceled;

	private bool _addOperationCanceled;

	private EncryptionAlgorithm _Encryption;

	private bool _JustSaved;

	private long _locEndOfCDS = -1L;

	private uint _OffsetOfCentralDirectory;

	private long _OffsetOfCentralDirectory64;

	private bool? _OutputUsesZip64;

	private Encoding _alternateEncoding;

	private ZipOption _alternateEncodingUsage;

	private int _BufferSize = BufferSizeDefault;

	internal ParallelDeflateOutputStream ParallelDeflater;

	private long _ParallelDeflateThreshold;

	private int _maxBufferPairs = 16;

	internal Zip64Option _zip64;

	private bool _SavingSfx;

	public static readonly int BufferSizeDefault = 32768;

	private long _lengthOfReadStream = -99L;

	private static Encoding _defaultEncoding = null;

	private static bool _defaultEncodingInitialized = false;

	public bool FullScan { get; set; }

	public bool SortEntriesBeforeSaving { get; set; }

	public bool AddDirectoryWillTraverseReparsePoints { get; set; }

	public int BufferSize
	{
		get
		{
			return _BufferSize;
		}
		set
		{
			_BufferSize = value;
		}
	}

	public int CodecBufferSize { get; set; }

	public CompressionStrategy Strategy
	{
		get
		{
			return _Strategy;
		}
		set
		{
			_Strategy = value;
		}
	}

	public string Name
	{
		get
		{
			return _name;
		}
		set
		{
			_name = value;
		}
	}

	public CompressionLevel CompressionLevel { get; set; }

	public CompressionMethod CompressionMethod
	{
		get
		{
			return _compressionMethod;
		}
		set
		{
			_compressionMethod = value;
		}
	}

	public string Comment
	{
		get
		{
			return _Comment;
		}
		set
		{
			_Comment = value;
			_contentsChanged = true;
		}
	}

	internal bool Verbose => _StatusMessageTextWriter != null;

	public bool CaseSensitiveRetrieval
	{
		get
		{
			return _CaseSensitiveRetrieval;
		}
		set
		{
			_CaseSensitiveRetrieval = value;
		}
	}

	private Dictionary<string, ZipEntry> RetrievalEntries
	{
		get
		{
			if (!CaseSensitiveRetrieval)
			{
				return _entriesInsensitive;
			}
			return _entries;
		}
	}

	public bool IgnoreDuplicateFiles
	{
		get
		{
			return _IgnoreDuplicateFiles;
		}
		set
		{
			_IgnoreDuplicateFiles = value;
		}
	}

	public Zip64Option UseZip64WhenSaving
	{
		get
		{
			return _zip64;
		}
		set
		{
			_zip64 = value;
		}
	}

	public Encoding AlternateEncoding
	{
		get
		{
			return _alternateEncoding;
		}
		set
		{
			_alternateEncoding = value;
		}
	}

	public ZipOption AlternateEncodingUsage
	{
		get
		{
			return _alternateEncodingUsage;
		}
		set
		{
			_alternateEncodingUsage = value;
		}
	}

	public TextWriter StatusMessageTextWriter
	{
		get
		{
			return _StatusMessageTextWriter;
		}
		set
		{
			_StatusMessageTextWriter = value;
		}
	}

	public string TempFileFolder
	{
		get
		{
			return _TempFileFolder;
		}
		set
		{
			_TempFileFolder = value;
			if (value == null || Directory.Exists(value))
			{
				return;
			}
			throw new FileNotFoundException($"That directory ({value}) does not exist.");
		}
	}

	public ZipErrorAction ZipErrorAction
	{
		get
		{
			if (this.ZipError != null)
			{
				_zipErrorAction = ZipErrorAction.InvokeErrorEvent;
			}
			return _zipErrorAction;
		}
		set
		{
			_zipErrorAction = value;
			if (_zipErrorAction != ZipErrorAction.InvokeErrorEvent && this.ZipError != null)
			{
				this.ZipError = null;
			}
		}
	}

	public EncryptionAlgorithm Encryption
	{
		get
		{
			return _Encryption;
		}
		set
		{
			if (value == EncryptionAlgorithm.Unsupported)
			{
				throw new InvalidOperationException("You may not set Encryption to that value.");
			}
			_Encryption = value;
		}
	}

	public SetCompressionCallback SetCompression { get; set; }

	public long MaxOutputSegmentSize64
	{
		get
		{
			return _maxOutputSegmentSize;
		}
		set
		{
			if (value < 65536L && value != 0L)
			{
				throw new ZipException("The minimum acceptable segment size is 65536.");
			}
			_maxOutputSegmentSize = value;
		}
	}

	public long ParallelDeflateThreshold
	{
		get
		{
			return _ParallelDeflateThreshold;
		}
		set
		{
			if (value != 0L && value != -1L && value < 65536L)
			{
				throw new ArgumentOutOfRangeException("ParallelDeflateThreshold should be -1, 0, or > 65536");
			}
			_ParallelDeflateThreshold = value;
		}
	}

	public int ParallelDeflateMaxBufferPairs
	{
		get
		{
			return _maxBufferPairs;
		}
		set
		{
			if (value < 4)
			{
				throw new ArgumentOutOfRangeException("ParallelDeflateMaxBufferPairs", "Value must be 4 or greater.");
			}
			_maxBufferPairs = value;
		}
	}

	public ZipEntry this[string fileName]
	{
		get
		{
			Dictionary<string, ZipEntry> retrievalEntries = RetrievalEntries;
			string text = SharedUtilities.NormalizePathForUseInZipFile(fileName);
			if (retrievalEntries.ContainsKey(text))
			{
				return retrievalEntries[text];
			}
			text = text.Replace("/", "\\");
			if (retrievalEntries.ContainsKey(text))
			{
				return retrievalEntries[text];
			}
			return null;
		}
	}

	public ICollection<ZipEntry> Entries => _entries.Values;

	public ICollection<ZipEntry> EntriesSorted
	{
		get
		{
			List<ZipEntry> list = new List<ZipEntry>();
			foreach (ZipEntry entry in Entries)
			{
				list.Add(entry);
			}
			StringComparison sc = (CaseSensitiveRetrieval ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase);
			list.Sort((ZipEntry x, ZipEntry y) => string.Compare(x.FileName, y.FileName, sc));
			return list.AsReadOnly();
		}
	}

	internal Stream ReadStream
	{
		get
		{
			if (_readstream == null && (_readName != null || _name != null))
			{
				_readstream = File.Open(_readName ?? _name, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				_ReadStreamIsOurs = true;
			}
			return _readstream;
		}
	}

	private Stream WriteStream
	{
		get
		{
			if (_writestream != null)
			{
				return _writestream;
			}
			if (_name == null)
			{
				return _writestream;
			}
			if (_maxOutputSegmentSize != 0L)
			{
				_writestream = ZipSegmentedStream.ForWriting(_name, _maxOutputSegmentSize);
				return _writestream;
			}
			SharedUtilities.CreateAndOpenUniqueTempFile(TempFileFolder ?? Path.GetDirectoryName(_name), out _writestream, out _temporaryFileName);
			return _writestream;
		}
		set
		{
			if (value != null)
			{
				throw new ZipException("Cannot set the stream to a non-null value.");
			}
			_writestream = null;
		}
	}

	private string ArchiveNameForEvent
	{
		get
		{
			if (_name == null)
			{
				return "(stream)";
			}
			return _name;
		}
	}

	private long LengthOfReadStream
	{
		get
		{
			if (_lengthOfReadStream == -99L)
			{
				_lengthOfReadStream = (_ReadStreamIsOurs ? SharedUtilities.GetFileLength(_name) : (-1L));
			}
			return _lengthOfReadStream;
		}
	}

	public static Encoding DefaultEncoding
	{
		get
		{
			return _defaultEncoding;
		}
		set
		{
			if (!_defaultEncodingInitialized)
			{
				_defaultEncoding = value;
				_defaultEncodingInitialized = true;
			}
		}
	}

	public event EventHandler<SaveProgressEventArgs> SaveProgress;

	public event EventHandler<ReadProgressEventArgs> ReadProgress;

	public event EventHandler<AddProgressEventArgs> AddProgress;

	public event EventHandler<ZipErrorEventArgs> ZipError;

	public ZipEntry AddFile(string fileName, string directoryPathInArchive)
	{
		string nameInArchive = ZipEntry.NameInArchive(fileName, directoryPathInArchive);
		ZipEntry ze = ZipEntry.CreateFromFile(fileName, nameInArchive);
		if (Verbose)
		{
			StatusMessageTextWriter.WriteLine("adding {0}...", fileName);
		}
		return _InternalAddEntry(ze);
	}

	public ZipEntry UpdateFile(string fileName, string directoryPathInArchive)
	{
		string fileName2 = ZipEntry.NameInArchive(fileName, directoryPathInArchive);
		if (this[fileName2] != null)
		{
			RemoveEntry(fileName2);
		}
		return AddFile(fileName, directoryPathInArchive);
	}

	public ZipEntry AddEntry(string entryName, Stream stream)
	{
		ZipEntry zipEntry = ZipEntry.CreateForStream(entryName, stream);
		zipEntry.SetEntryTimes(DateTime.Now, DateTime.Now, DateTime.Now);
		if (Verbose)
		{
			StatusMessageTextWriter.WriteLine("adding {0}...", entryName);
		}
		return _InternalAddEntry(zipEntry);
	}

	private ZipEntry _InternalAddEntry(ZipEntry ze)
	{
		ze._container = new ZipContainer(this);
		ze.CompressionMethod = CompressionMethod;
		ze.CompressionLevel = CompressionLevel;
		ze.ZipErrorAction = ZipErrorAction;
		ze.SetCompression = SetCompression;
		ze.AlternateEncoding = AlternateEncoding;
		ze.AlternateEncodingUsage = AlternateEncodingUsage;
		ze.Password = _Password;
		ze.Encryption = Encryption;
		ze.EmitTimesInWindowsFormatWhenSaving = _emitNtfsTimes;
		ze.EmitTimesInUnixFormatWhenSaving = _emitUnixTimes;
		InternalAddEntry(ze.FileName, ze);
		AfterAddEntry(ze);
		return ze;
	}

	public ZipEntry AddDirectory(string directoryName)
	{
		return AddDirectory(directoryName, null);
	}

	public ZipEntry AddDirectory(string directoryName, string directoryPathInArchive)
	{
		return AddOrUpdateDirectoryImpl(directoryName, directoryPathInArchive, AddOrUpdateAction.AddOnly);
	}

	private ZipEntry AddOrUpdateDirectoryImpl(string directoryName, string rootDirectoryPathInArchive, AddOrUpdateAction action)
	{
		if (rootDirectoryPathInArchive == null)
		{
			rootDirectoryPathInArchive = "";
		}
		return AddOrUpdateDirectoryImpl(directoryName, rootDirectoryPathInArchive, action, recurse: true, 0);
	}

	internal void InternalAddEntry(string name, ZipEntry entry)
	{
		_entries.Add(name, entry);
		if (!_entriesInsensitive.ContainsKey(name))
		{
			_entriesInsensitive.Add(name, entry);
		}
		_contentsChanged = true;
	}

	private ZipEntry AddOrUpdateDirectoryImpl(string directoryName, string rootDirectoryPathInArchive, AddOrUpdateAction action, bool recurse, int level)
	{
		if (Verbose)
		{
			StatusMessageTextWriter.WriteLine("{0} {1}...", (action == AddOrUpdateAction.AddOnly) ? "adding" : "Adding or updating", directoryName);
		}
		if (level == 0)
		{
			_addOperationCanceled = false;
			OnAddStarted();
		}
		if (_addOperationCanceled)
		{
			return null;
		}
		string text = rootDirectoryPathInArchive;
		ZipEntry zipEntry = null;
		if (level > 0)
		{
			int num = directoryName.Length;
			for (int num2 = level; num2 > 0; num2--)
			{
				num = directoryName.LastIndexOfAny("/\\".ToCharArray(), num - 1, num - 1);
			}
			text = directoryName.Substring(num + 1);
			text = Path.Combine(rootDirectoryPathInArchive, text);
		}
		if (level > 0 || rootDirectoryPathInArchive != "")
		{
			zipEntry = ZipEntry.CreateFromFile(directoryName, text);
			zipEntry._container = new ZipContainer(this);
			zipEntry.AlternateEncoding = AlternateEncoding;
			zipEntry.AlternateEncodingUsage = AlternateEncodingUsage;
			zipEntry.MarkAsDirectory();
			zipEntry.EmitTimesInWindowsFormatWhenSaving = _emitNtfsTimes;
			zipEntry.EmitTimesInUnixFormatWhenSaving = _emitUnixTimes;
			if (!_entries.ContainsKey(zipEntry.FileName))
			{
				InternalAddEntry(zipEntry.FileName, zipEntry);
				AfterAddEntry(zipEntry);
			}
			text = zipEntry.FileName;
		}
		if (!_addOperationCanceled)
		{
			string[] files = Directory.GetFiles(directoryName);
			if (recurse)
			{
				string[] array = files;
				foreach (string fileName in array)
				{
					if (_addOperationCanceled)
					{
						break;
					}
					if (action == AddOrUpdateAction.AddOnly)
					{
						AddFile(fileName, text);
					}
					else
					{
						UpdateFile(fileName, text);
					}
				}
				if (!_addOperationCanceled)
				{
					array = Directory.GetDirectories(directoryName);
					foreach (string text2 in array)
					{
						FileAttributes attributes = File.GetAttributes(text2);
						if (AddDirectoryWillTraverseReparsePoints || (attributes & FileAttributes.ReparsePoint) == 0)
						{
							AddOrUpdateDirectoryImpl(text2, rootDirectoryPathInArchive, action, recurse, level + 1);
						}
					}
				}
			}
		}
		if (level == 0)
		{
			OnAddCompleted();
		}
		return zipEntry;
	}

	public override string ToString()
	{
		return $"ZipFile::{Name}";
	}

	internal void NotifyEntryChanged()
	{
		_contentsChanged = true;
	}

	internal Stream StreamForDiskNumber(uint diskNumber)
	{
		if (diskNumber + 1 != _diskNumberWithCd && (diskNumber != 0 || _diskNumberWithCd != 0))
		{
			return ZipSegmentedStream.ForReading(_readName ?? _name, diskNumber, _diskNumberWithCd);
		}
		return ReadStream;
	}

	internal void Reset(bool whileSaving)
	{
		if (!_JustSaved)
		{
			return;
		}
		using (ZipFile zipFile = new ZipFile())
		{
			if (File.Exists(_readName ?? _name))
			{
				zipFile._readName = (zipFile._name = (whileSaving ? (_readName ?? _name) : _name));
			}
			else
			{
				if (_readstream.CanSeek)
				{
					_readstream.Seek(0L, SeekOrigin.Begin);
				}
				zipFile._readstream = _readstream;
			}
			zipFile.AlternateEncoding = AlternateEncoding;
			zipFile.AlternateEncodingUsage = AlternateEncodingUsage;
			ReadIntoInstance(zipFile);
			foreach (ZipEntry item in zipFile)
			{
				ZipEntry zipEntry = this[item.FileName];
				if (zipEntry != null && !zipEntry.IsChanged)
				{
					zipEntry.CopyMetaData(item);
				}
			}
		}
		_JustSaved = false;
	}

	public ZipFile()
	{
		if (DefaultEncoding == null)
		{
			_alternateEncoding = Encoding.UTF8;
			AlternateEncodingUsage = ZipOption.Always;
		}
		else
		{
			_alternateEncoding = DefaultEncoding;
		}
		_InitInstance(null, null);
	}

	public ZipFile(Encoding encoding)
	{
		AlternateEncoding = encoding;
		AlternateEncodingUsage = ZipOption.Always;
		_InitInstance(null, null);
	}

	private void _InitInstance(string zipFileName, TextWriter statusMessageWriter)
	{
		_name = zipFileName;
		_StatusMessageTextWriter = statusMessageWriter;
		_contentsChanged = true;
		AddDirectoryWillTraverseReparsePoints = true;
		CompressionLevel = CompressionLevel.Default;
		ParallelDeflateThreshold = 524288L;
		_entries = new Dictionary<string, ZipEntry>(StringComparer.Ordinal);
		_entriesInsensitive = new Dictionary<string, ZipEntry>(StringComparer.OrdinalIgnoreCase);
		if (File.Exists(_name))
		{
			if (FullScan)
			{
				ReadIntoInstance_Orig(this);
			}
			else
			{
				ReadIntoInstance(this);
			}
			_fileAlreadyExists = true;
		}
	}

	public void RemoveEntry(ZipEntry entry)
	{
		if (entry == null)
		{
			throw new ArgumentNullException("entry");
		}
		string text = SharedUtilities.NormalizePathForUseInZipFile(entry.FileName);
		_entries.Remove(text);
		if (!AnyCaseInsensitiveMatches(text))
		{
			_entriesInsensitive.Remove(text);
		}
		_zipEntriesAsList = null;
		_contentsChanged = true;
	}

	private bool AnyCaseInsensitiveMatches(string path)
	{
		foreach (ZipEntry value in _entries.Values)
		{
			if (string.Equals(value.FileName, path, StringComparison.OrdinalIgnoreCase))
			{
				return true;
			}
		}
		return false;
	}

	public void RemoveEntry(string fileName)
	{
		string fileName2 = ZipEntry.NameInArchive(fileName, null);
		ZipEntry zipEntry = this[fileName2];
		if (zipEntry == null)
		{
			throw new ArgumentException("The entry you specified was not found in the zip archive.");
		}
		RemoveEntry(zipEntry);
	}

	public void Dispose()
	{
		Dispose(disposeManagedResources: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposeManagedResources)
	{
		if (_disposed)
		{
			return;
		}
		if (disposeManagedResources)
		{
			if (_ReadStreamIsOurs && _readstream != null)
			{
				_readstream.Dispose();
				_readstream = null;
			}
			if (_temporaryFileName != null && _name != null && _writestream != null)
			{
				_writestream.Dispose();
				_writestream = null;
			}
			if (ParallelDeflater != null)
			{
				ParallelDeflater.Dispose();
				ParallelDeflater = null;
			}
		}
		_disposed = true;
	}

	internal bool OnSaveBlock(ZipEntry entry, long bytesXferred, long totalBytesToXfer)
	{
		EventHandler<SaveProgressEventArgs> saveProgress = this.SaveProgress;
		if (saveProgress != null)
		{
			SaveProgressEventArgs saveProgressEventArgs = SaveProgressEventArgs.ByteUpdate(ArchiveNameForEvent, entry, bytesXferred, totalBytesToXfer);
			saveProgress(this, saveProgressEventArgs);
			if (saveProgressEventArgs.Cancel)
			{
				_saveOperationCanceled = true;
			}
		}
		return _saveOperationCanceled;
	}

	private void OnSaveEntry(int current, ZipEntry entry, bool before)
	{
		EventHandler<SaveProgressEventArgs> saveProgress = this.SaveProgress;
		if (saveProgress != null)
		{
			SaveProgressEventArgs saveProgressEventArgs = new SaveProgressEventArgs(ArchiveNameForEvent, before, _entries.Count, current, entry);
			saveProgress(this, saveProgressEventArgs);
			if (saveProgressEventArgs.Cancel)
			{
				_saveOperationCanceled = true;
			}
		}
	}

	private void OnSaveEvent(ZipProgressEventType eventFlavor)
	{
		EventHandler<SaveProgressEventArgs> saveProgress = this.SaveProgress;
		if (saveProgress != null)
		{
			SaveProgressEventArgs saveProgressEventArgs = new SaveProgressEventArgs(ArchiveNameForEvent, eventFlavor);
			saveProgress(this, saveProgressEventArgs);
			if (saveProgressEventArgs.Cancel)
			{
				_saveOperationCanceled = true;
			}
		}
	}

	private void OnSaveStarted()
	{
		EventHandler<SaveProgressEventArgs> saveProgress = this.SaveProgress;
		if (saveProgress != null)
		{
			SaveProgressEventArgs saveProgressEventArgs = SaveProgressEventArgs.Started(ArchiveNameForEvent);
			saveProgress(this, saveProgressEventArgs);
			if (saveProgressEventArgs.Cancel)
			{
				_saveOperationCanceled = true;
			}
		}
	}

	private void OnSaveCompleted()
	{
		EventHandler<SaveProgressEventArgs> saveProgress = this.SaveProgress;
		if (saveProgress != null)
		{
			SaveProgressEventArgs e = SaveProgressEventArgs.Completed(ArchiveNameForEvent);
			saveProgress(this, e);
		}
	}

	private void OnReadStarted()
	{
		EventHandler<ReadProgressEventArgs> readProgress = this.ReadProgress;
		if (readProgress != null)
		{
			ReadProgressEventArgs e = ReadProgressEventArgs.Started(ArchiveNameForEvent);
			readProgress(this, e);
		}
	}

	private void OnReadCompleted()
	{
		EventHandler<ReadProgressEventArgs> readProgress = this.ReadProgress;
		if (readProgress != null)
		{
			ReadProgressEventArgs e = ReadProgressEventArgs.Completed(ArchiveNameForEvent);
			readProgress(this, e);
		}
	}

	internal void OnReadBytes(ZipEntry entry)
	{
		EventHandler<ReadProgressEventArgs> readProgress = this.ReadProgress;
		if (readProgress != null)
		{
			ReadProgressEventArgs e = ReadProgressEventArgs.ByteUpdate(ArchiveNameForEvent, entry, ReadStream.Position, LengthOfReadStream);
			readProgress(this, e);
		}
	}

	internal void OnReadEntry(bool before, ZipEntry entry)
	{
		EventHandler<ReadProgressEventArgs> readProgress = this.ReadProgress;
		if (readProgress != null)
		{
			ReadProgressEventArgs e = (before ? ReadProgressEventArgs.Before(ArchiveNameForEvent, _entries.Count) : ReadProgressEventArgs.After(ArchiveNameForEvent, entry, _entries.Count));
			readProgress(this, e);
		}
	}

	private void OnAddStarted()
	{
		EventHandler<AddProgressEventArgs> addProgress = this.AddProgress;
		if (addProgress != null)
		{
			AddProgressEventArgs addProgressEventArgs = AddProgressEventArgs.Started(ArchiveNameForEvent);
			addProgress(this, addProgressEventArgs);
			if (addProgressEventArgs.Cancel)
			{
				_addOperationCanceled = true;
			}
		}
	}

	private void OnAddCompleted()
	{
		EventHandler<AddProgressEventArgs> addProgress = this.AddProgress;
		if (addProgress != null)
		{
			AddProgressEventArgs e = AddProgressEventArgs.Completed(ArchiveNameForEvent);
			addProgress(this, e);
		}
	}

	internal void AfterAddEntry(ZipEntry entry)
	{
		EventHandler<AddProgressEventArgs> addProgress = this.AddProgress;
		if (addProgress != null)
		{
			AddProgressEventArgs addProgressEventArgs = AddProgressEventArgs.AfterEntry(ArchiveNameForEvent, entry, _entries.Count);
			addProgress(this, addProgressEventArgs);
			if (addProgressEventArgs.Cancel)
			{
				_addOperationCanceled = true;
			}
		}
	}

	internal bool OnZipErrorSaving(ZipEntry entry, Exception exc)
	{
		if (this.ZipError != null)
		{
			lock (LOCK)
			{
				ZipErrorEventArgs zipErrorEventArgs = ZipErrorEventArgs.Saving(Name, entry, exc);
				this.ZipError(this, zipErrorEventArgs);
				if (zipErrorEventArgs.Cancel)
				{
					_saveOperationCanceled = true;
				}
			}
		}
		return _saveOperationCanceled;
	}

	private static void ReadIntoInstance(ZipFile zf)
	{
		Stream readStream = zf.ReadStream;
		try
		{
			zf._readName = zf._name;
			if (!readStream.CanSeek)
			{
				ReadIntoInstance_Orig(zf);
				return;
			}
			zf.OnReadStarted();
			if (ReadFirstFourBytes(readStream) == 101010256)
			{
				return;
			}
			int num = 0;
			bool flag = false;
			long num2 = readStream.Length - 64L;
			long num3 = Math.Max(readStream.Length - 16384L, 10L);
			do
			{
				if (num2 < 0L)
				{
					num2 = 0L;
				}
				readStream.Seek(num2, SeekOrigin.Begin);
				if (SharedUtilities.FindSignature(readStream, 101010256) != -1L)
				{
					flag = true;
					continue;
				}
				if (num2 == 0L)
				{
					break;
				}
				num++;
				num2 -= 32 * (num + 1) * num;
			}
			while (!flag && num2 > num3);
			if (flag)
			{
				zf._locEndOfCDS = readStream.Position - 4L;
				byte[] array = new byte[16];
				readStream.Read(array, 0, array.Length);
				zf._diskNumberWithCd = BitConverter.ToUInt16(array, 2);
				if (zf._diskNumberWithCd == 65535)
				{
					throw new ZipException("Spanned archives with more than 65534 segments are not supported at this time.");
				}
				zf._diskNumberWithCd++;
				uint num4 = BitConverter.ToUInt32(array, 12);
				if (num4 == uint.MaxValue)
				{
					Zip64SeekToCentralDirectory(zf);
				}
				else
				{
					zf._OffsetOfCentralDirectory = num4;
					readStream.Seek(num4, SeekOrigin.Begin);
				}
				ReadCentralDirectory(zf);
			}
			else
			{
				readStream.Seek(0L, SeekOrigin.Begin);
				ReadIntoInstance_Orig(zf);
			}
		}
		catch (Exception innerException)
		{
			if (zf._ReadStreamIsOurs && zf._readstream != null)
			{
				zf._readstream.Dispose();
				zf._readstream = null;
			}
			throw new ZipException("Cannot read that as a ZipFile", innerException);
		}
		zf._contentsChanged = false;
	}

	private static void Zip64SeekToCentralDirectory(ZipFile zf)
	{
		Stream readStream = zf.ReadStream;
		byte[] array = new byte[16];
		readStream.Seek(-40L, SeekOrigin.Current);
		readStream.Read(array, 0, 16);
		long num = BitConverter.ToInt64(array, 8);
		zf._OffsetOfCentralDirectory = uint.MaxValue;
		zf._OffsetOfCentralDirectory64 = num;
		readStream.Seek(num, SeekOrigin.Begin);
		uint num2 = (uint)SharedUtilities.ReadInt(readStream);
		if (num2 != 101075792)
		{
			throw new BadReadException($"  Bad signature (0x{num2:X8}) looking for ZIP64 EoCD Record at position 0x{readStream.Position:X8}");
		}
		readStream.Read(array, 0, 8);
		array = new byte[BitConverter.ToInt64(array, 0)];
		readStream.Read(array, 0, array.Length);
		num = BitConverter.ToInt64(array, 36);
		readStream.Seek(num, SeekOrigin.Begin);
	}

	private static uint ReadFirstFourBytes(Stream s)
	{
		return (uint)SharedUtilities.ReadInt(s);
	}

	private static void ReadCentralDirectory(ZipFile zf)
	{
		bool flag = false;
		Dictionary<string, object> dictionary = new Dictionary<string, object>(StringComparer.Ordinal);
		ZipEntry zipEntry;
		while ((zipEntry = ZipEntry.ReadDirEntry(zf, dictionary)) != null)
		{
			zipEntry.ResetDirEntry();
			zf.OnReadEntry(before: true, null);
			if (zf.Verbose)
			{
				zf.StatusMessageTextWriter.WriteLine("entry {0}", zipEntry.FileName);
			}
			zf._entries.Add(zipEntry.FileName, zipEntry);
			if (!zf._entriesInsensitive.ContainsKey(zipEntry.FileName))
			{
				zf._entriesInsensitive.Add(zipEntry.FileName, zipEntry);
			}
			if (zipEntry._InputUsesZip64)
			{
				flag = true;
			}
			dictionary.Add(zipEntry.FileName, null);
		}
		if (flag)
		{
			zf.UseZip64WhenSaving = Zip64Option.Always;
		}
		if (zf._locEndOfCDS > 0L)
		{
			zf.ReadStream.Seek(zf._locEndOfCDS, SeekOrigin.Begin);
		}
		ReadCentralDirectoryFooter(zf);
		if (zf.Verbose && !string.IsNullOrEmpty(zf.Comment))
		{
			zf.StatusMessageTextWriter.WriteLine("Zip file Comment: {0}", zf.Comment);
		}
		if (zf.Verbose)
		{
			zf.StatusMessageTextWriter.WriteLine("read in {0} entries.", zf._entries.Count);
		}
		zf.OnReadCompleted();
	}

	private static void ReadIntoInstance_Orig(ZipFile zf)
	{
		zf.OnReadStarted();
		zf._entries.Clear();
		zf._entriesInsensitive.Clear();
		if (zf.Verbose)
		{
			if (zf.Name == null)
			{
				zf.StatusMessageTextWriter.WriteLine("Reading zip from stream...");
			}
			else
			{
				zf.StatusMessageTextWriter.WriteLine("Reading zip {0}...", zf.Name);
			}
		}
		bool first = true;
		ZipContainer zc = new ZipContainer(zf);
		ZipEntry zipEntry;
		while ((zipEntry = ZipEntry.ReadEntry(zc, first)) != null)
		{
			if (zf.Verbose)
			{
				zf.StatusMessageTextWriter.WriteLine("  {0}", zipEntry.FileName);
			}
			zf._entries.Add(zipEntry.FileName, zipEntry);
			if (!zf._entriesInsensitive.ContainsKey(zipEntry.FileName))
			{
				zf._entriesInsensitive.Add(zipEntry.FileName, zipEntry);
			}
			first = false;
		}
		try
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>(StringComparer.Ordinal);
			ZipEntry zipEntry2;
			while ((zipEntry2 = ZipEntry.ReadDirEntry(zf, dictionary)) != null)
			{
				ZipEntry zipEntry3 = zf._entries[zipEntry2.FileName];
				if (zipEntry3 != null)
				{
					zipEntry3._Comment = zipEntry2.Comment;
					if (zipEntry2.IsDirectory)
					{
						zipEntry3.MarkAsDirectory();
					}
				}
				dictionary.Add(zipEntry2.FileName, null);
			}
			if (zf._locEndOfCDS > 0L)
			{
				zf.ReadStream.Seek(zf._locEndOfCDS, SeekOrigin.Begin);
			}
			ReadCentralDirectoryFooter(zf);
			if (zf.Verbose && !string.IsNullOrEmpty(zf.Comment))
			{
				zf.StatusMessageTextWriter.WriteLine("Zip file Comment: {0}", zf.Comment);
			}
		}
		catch (ZipException)
		{
		}
		catch (IOException)
		{
		}
		zf.OnReadCompleted();
	}

	private static void ReadCentralDirectoryFooter(ZipFile zf)
	{
		Stream readStream = zf.ReadStream;
		int num = SharedUtilities.ReadSignature(readStream);
		byte[] array = null;
		int num2 = 0;
		if (num == 101075792L)
		{
			array = new byte[52];
			readStream.Read(array, 0, array.Length);
			long num3 = BitConverter.ToInt64(array, 0);
			if (num3 < 44L)
			{
				throw new ZipException("Bad size in the ZIP64 Central Directory.");
			}
			zf._versionMadeBy = BitConverter.ToUInt16(array, num2);
			num2 += 2;
			zf._versionNeededToExtract = BitConverter.ToUInt16(array, num2);
			num2 += 2;
			zf._diskNumberWithCd = BitConverter.ToUInt32(array, num2);
			num2 += 2;
			array = new byte[num3 - 44L];
			readStream.Read(array, 0, array.Length);
			num = SharedUtilities.ReadSignature(readStream);
			if (num != 117853008L)
			{
				throw new ZipException("Inconsistent metadata in the ZIP64 Central Directory.");
			}
			array = new byte[16];
			readStream.Read(array, 0, array.Length);
			num = SharedUtilities.ReadSignature(readStream);
		}
		if (num != 101010256L)
		{
			readStream.Seek(-4L, SeekOrigin.Current);
			throw new BadReadException($"Bad signature ({num:X8}) at position 0x{readStream.Position:X8}");
		}
		array = new byte[16];
		zf.ReadStream.Read(array, 0, array.Length);
		if (zf._diskNumberWithCd == 0)
		{
			zf._diskNumberWithCd = BitConverter.ToUInt16(array, 2);
		}
		ReadZipFileComment(zf);
	}

	private static void ReadZipFileComment(ZipFile zf)
	{
		byte[] array = new byte[2];
		zf.ReadStream.Read(array, 0, array.Length);
		short num = (short)(array[0] + array[1] * 256);
		if (num > 0)
		{
			array = new byte[num];
			zf.ReadStream.Read(array, 0, array.Length);
			string text = (zf.Comment = zf.AlternateEncoding.GetString(array, 0, array.Length));
		}
	}

	private void DeleteFileWithRetry(string filename)
	{
		bool flag = false;
		int num = 3;
		for (int i = 0; i < num; i++)
		{
			if (flag)
			{
				break;
			}
			try
			{
				File.Delete(filename);
				flag = true;
			}
			catch (UnauthorizedAccessException)
			{
				Console.WriteLine("************************************************** Retry delete.");
				Thread.Sleep(200 + i * 200);
			}
		}
	}

	public void Save()
	{
		try
		{
			bool flag = false;
			_saveOperationCanceled = false;
			_numberOfSegmentsForMostRecentSave = 0u;
			OnSaveStarted();
			if (WriteStream == null)
			{
				throw new BadStateException("You haven't specified where to save the zip.");
			}
			if (_name != null && _name.EndsWith(".exe") && !_SavingSfx)
			{
				throw new BadStateException("You specified an EXE for a plain zip file.");
			}
			if (!_contentsChanged)
			{
				OnSaveCompleted();
				if (Verbose)
				{
					StatusMessageTextWriter.WriteLine("No save is necessary....");
				}
				return;
			}
			Reset(whileSaving: true);
			if (Verbose)
			{
				StatusMessageTextWriter.WriteLine("saving....");
			}
			if (_entries.Count >= 65535 && _zip64 == Zip64Option.Default)
			{
				throw new ZipException("The number of entries is 65535 or greater. Consider setting the UseZip64WhenSaving property on the ZipFile instance.");
			}
			int num = 0;
			ICollection<ZipEntry> collection = (SortEntriesBeforeSaving ? EntriesSorted : Entries);
			foreach (ZipEntry item in collection)
			{
				OnSaveEntry(num, item, before: true);
				item.Write(WriteStream);
				if (!_saveOperationCanceled)
				{
					num++;
					OnSaveEntry(num, item, before: false);
					if (!_saveOperationCanceled)
					{
						if (item.IncludedInMostRecentSave)
						{
							flag |= item.OutputUsedZip64.Value;
						}
						continue;
					}
					break;
				}
				break;
			}
			if (_saveOperationCanceled)
			{
				return;
			}
			ZipSegmentedStream zipSegmentedStream = WriteStream as ZipSegmentedStream;
			_numberOfSegmentsForMostRecentSave = zipSegmentedStream?.CurrentSegment ?? 1;
			bool flag2 = ZipOutput.WriteCentralDirectoryStructure(WriteStream, collection, _numberOfSegmentsForMostRecentSave, _zip64, Comment, new ZipContainer(this));
			OnSaveEvent(ZipProgressEventType.Saving_AfterSaveTempArchive);
			_hasBeenSaved = true;
			_contentsChanged = false;
			flag = flag || flag2;
			_OutputUsesZip64 = flag;
			if (_fileAlreadyExists && _readstream != null)
			{
				_readstream.Close();
				_readstream = null;
			}
			foreach (ZipEntry item2 in collection)
			{
				if (item2._archiveStream is ZipSegmentedStream zipSegmentedStream2)
				{
					zipSegmentedStream2.Dispose();
				}
				item2._archiveStream = null;
			}
			if (_name != null && (_temporaryFileName != null || zipSegmentedStream != null))
			{
				WriteStream.Dispose();
				if (_saveOperationCanceled)
				{
					return;
				}
				string text = null;
				if (File.Exists(_name))
				{
					text = _name + "." + Path.GetRandomFileName();
					if (File.Exists(text))
					{
						DeleteFileWithRetry(text);
					}
					File.Move(_name, text);
				}
				OnSaveEvent(ZipProgressEventType.Saving_BeforeRenameTempArchive);
				File.Move((zipSegmentedStream != null) ? zipSegmentedStream.CurrentTempName : _temporaryFileName, _name);
				OnSaveEvent(ZipProgressEventType.Saving_AfterRenameTempArchive);
				if (text != null)
				{
					try
					{
						if (File.Exists(text))
						{
							File.Delete(text);
						}
					}
					catch
					{
					}
				}
				_fileAlreadyExists = true;
			}
			_readName = _name;
			NotifyEntriesSaveComplete(collection);
			OnSaveCompleted();
			_JustSaved = true;
		}
		finally
		{
			CleanupAfterSaveOperation();
		}
	}

	private static void NotifyEntriesSaveComplete(ICollection<ZipEntry> c)
	{
		foreach (ZipEntry item in c)
		{
			item.NotifySaveComplete();
		}
	}

	private void RemoveTempFile()
	{
		try
		{
			if (File.Exists(_temporaryFileName))
			{
				File.Delete(_temporaryFileName);
			}
		}
		catch (IOException ex)
		{
			if (Verbose)
			{
				StatusMessageTextWriter.WriteLine("ZipFile::Save: could not delete temp file: {0}.", ex.Message);
			}
		}
	}

	private void CleanupAfterSaveOperation()
	{
		if (_name == null)
		{
			return;
		}
		if (_writestream != null)
		{
			try
			{
				_writestream.Dispose();
			}
			catch (IOException)
			{
			}
		}
		_writestream = null;
		if (_temporaryFileName != null)
		{
			RemoveTempFile();
			_temporaryFileName = null;
		}
	}

	public void Save(string fileName)
	{
		if (_name == null)
		{
			_writestream = null;
		}
		else
		{
			_readName = _name;
		}
		_name = fileName;
		if (Directory.Exists(_name))
		{
			throw new ZipException("Bad Directory", new ArgumentException("That name specifies an existing directory. Please specify a filename.", "fileName"));
		}
		_contentsChanged = true;
		_fileAlreadyExists = File.Exists(_readName);
		Save();
	}

	public void AddSelectedFiles(string selectionCriteria, string directoryOnDisk, string directoryPathInArchive, bool recurseDirectories)
	{
		_AddOrUpdateSelectedFiles(selectionCriteria, directoryOnDisk, directoryPathInArchive, recurseDirectories, wantUpdate: false);
	}

	private void _AddOrUpdateSelectedFiles(string selectionCriteria, string directoryOnDisk, string directoryPathInArchive, bool recurseDirectories, bool wantUpdate)
	{
		if (directoryOnDisk == null && Directory.Exists(selectionCriteria))
		{
			directoryOnDisk = selectionCriteria;
			selectionCriteria = "*.*";
		}
		else if (string.IsNullOrEmpty(directoryOnDisk))
		{
			directoryOnDisk = ".";
		}
		while (directoryOnDisk.EndsWith("\\"))
		{
			directoryOnDisk = directoryOnDisk.Substring(0, directoryOnDisk.Length - 1);
		}
		if (Verbose)
		{
			StatusMessageTextWriter.WriteLine("adding selection '{0}' from dir '{1}'...", selectionCriteria, directoryOnDisk);
		}
		ReadOnlyCollection<string> readOnlyCollection = new FileSelector(selectionCriteria, AddDirectoryWillTraverseReparsePoints).SelectFiles(directoryOnDisk, recurseDirectories);
		if (Verbose)
		{
			StatusMessageTextWriter.WriteLine("found {0} files...", readOnlyCollection.Count);
		}
		OnAddStarted();
		AddOrUpdateAction action = (wantUpdate ? AddOrUpdateAction.AddOrUpdate : AddOrUpdateAction.AddOnly);
		foreach (string item in readOnlyCollection)
		{
			string text = ((directoryPathInArchive == null) ? null : ReplaceLeadingDirectory(Path.GetDirectoryName(item), directoryOnDisk, directoryPathInArchive));
			if (File.Exists(item))
			{
				if (wantUpdate)
				{
					UpdateFile(item, text);
				}
				else
				{
					AddFile(item, text);
				}
			}
			else
			{
				AddOrUpdateDirectoryImpl(item, text, action, recurse: false, 0);
			}
		}
		OnAddCompleted();
	}

	private static string ReplaceLeadingDirectory(string original, string pattern, string replacement)
	{
		string text = original.ToUpper();
		string text2 = pattern.ToUpper();
		if (text.IndexOf(text2) != 0)
		{
			return original;
		}
		return replacement + original.Substring(text2.Length);
	}

	public ICollection<ZipEntry> SelectEntries(string selectionCriteria)
	{
		return new FileSelector(selectionCriteria, AddDirectoryWillTraverseReparsePoints).SelectEntries(this);
	}

	public IEnumerator<ZipEntry> GetEnumerator()
	{
		foreach (ZipEntry value in _entries.Values)
		{
			yield return value;
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}
