using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using Microsoft.Win32.SafeHandles;

namespace Alphaleonis.Win32.Filesystem;

[Serializable]
[SecurityCritical]
public sealed class VolumeInfo
{
	[NonSerialized]
	private readonly bool _continueOnAccessError;

	[NonSerialized]
	private readonly SafeFileHandle _volumeHandle;

	[NonSerialized]
	private NativeMethods.VOLUME_INFO_FLAGS _volumeInfoAttributes;

	private string _guid;

	public bool CasePreservedNames => (_volumeInfoAttributes & NativeMethods.VOLUME_INFO_FLAGS.FILE_CASE_PRESERVED_NAMES) != 0;

	public bool CaseSensitiveSearch => (_volumeInfoAttributes & NativeMethods.VOLUME_INFO_FLAGS.FILE_CASE_SENSITIVE_SEARCH) != 0;

	public bool Compression => (_volumeInfoAttributes & NativeMethods.VOLUME_INFO_FLAGS.FILE_FILE_COMPRESSION) != 0;

	public bool DirectAccess => (_volumeInfoAttributes & NativeMethods.VOLUME_INFO_FLAGS.FILE_DAX_VOLUME) != 0;

	public string FileSystemName { get; private set; }

	public string FullPath { get; private set; }

	public string Guid
	{
		get
		{
			if (Utils.IsNullOrWhiteSpace(_guid))
			{
				_guid = ((!Utils.IsNullOrWhiteSpace(FullPath)) ? Volume.GetUniqueVolumeNameForPath(FullPath) : null);
			}
			return _guid;
		}
	}

	public int MaximumComponentLength { get; set; }

	public string Name { get; private set; }

	public bool NamedStreams => (_volumeInfoAttributes & NativeMethods.VOLUME_INFO_FLAGS.FILE_NAMED_STREAMS) != 0;

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Acls")]
	public bool PersistentAcls => (_volumeInfoAttributes & NativeMethods.VOLUME_INFO_FLAGS.FILE_PERSISTENT_ACLS) != 0;

	public bool ReadOnlyVolume => (_volumeInfoAttributes & NativeMethods.VOLUME_INFO_FLAGS.FILE_READ_ONLY_VOLUME) != 0;

	public bool SequentialWriteOnce => (_volumeInfoAttributes & NativeMethods.VOLUME_INFO_FLAGS.FILE_SEQUENTIAL_WRITE_ONCE) != 0;

	public long SerialNumber { get; private set; }

	public bool SupportsEncryption => (_volumeInfoAttributes & NativeMethods.VOLUME_INFO_FLAGS.FILE_SUPPORTS_ENCRYPTION) != 0;

	public bool SupportsExtendedAttributes => (_volumeInfoAttributes & NativeMethods.VOLUME_INFO_FLAGS.FILE_SUPPORTS_EXTENDED_ATTRIBUTES) != 0;

	public bool SupportsHardLinks => (_volumeInfoAttributes & NativeMethods.VOLUME_INFO_FLAGS.FILE_SUPPORTS_HARD_LINKS) != 0;

	public bool SupportsObjectIds => (_volumeInfoAttributes & NativeMethods.VOLUME_INFO_FLAGS.FILE_SUPPORTS_OBJECT_IDS) != 0;

	public bool SupportsOpenByFileId => (_volumeInfoAttributes & NativeMethods.VOLUME_INFO_FLAGS.FILE_SUPPORTS_OPEN_BY_FILE_ID) != 0;

	public bool SupportsRemoteStorage => (_volumeInfoAttributes & NativeMethods.VOLUME_INFO_FLAGS.FILE_SUPPORTS_REMOTE_STORAGE) != 0;

	public bool SupportsReparsePoints => (_volumeInfoAttributes & NativeMethods.VOLUME_INFO_FLAGS.FILE_SUPPORTS_REPARSE_POINTS) != 0;

	public bool SupportsSparseFiles => (_volumeInfoAttributes & NativeMethods.VOLUME_INFO_FLAGS.FILE_SUPPORTS_SPARSE_FILES) != 0;

	public bool SupportsTransactions => (_volumeInfoAttributes & NativeMethods.VOLUME_INFO_FLAGS.FILE_SUPPORTS_TRANSACTIONS) != 0;

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Usn")]
	public bool SupportsUsnJournal => (_volumeInfoAttributes & NativeMethods.VOLUME_INFO_FLAGS.FILE_SUPPORTS_USN_JOURNAL) != 0;

	public bool UnicodeOnDisk => (_volumeInfoAttributes & NativeMethods.VOLUME_INFO_FLAGS.FILE_UNICODE_ON_DISK) != 0;

	public bool VolumeIsCompressed => (_volumeInfoAttributes & NativeMethods.VOLUME_INFO_FLAGS.FILE_VOLUME_IS_COMPRESSED) != 0;

	public bool VolumeQuotas => (_volumeInfoAttributes & NativeMethods.VOLUME_INFO_FLAGS.FILE_VOLUME_QUOTAS) != 0;

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Justification = "Utils.IsNullOrWhiteSpace validates arguments.")]
	public VolumeInfo(string volumeName)
	{
		if (Utils.IsNullOrWhiteSpace(volumeName))
		{
			throw new ArgumentNullException("volumeName");
		}
		if (!volumeName.StartsWith(Path.LongPathPrefix, StringComparison.Ordinal))
		{
			volumeName = (Path.IsUncPathCore(volumeName, isRegularPath: false, checkInvalidPathChars: false) ? Path.GetLongPathCore(volumeName, GetFullPathOptions.None) : (Path.LongPathPrefix + volumeName));
		}
		else
		{
			string text;
			if (volumeName.Length != 1)
			{
				text = Path.GetPathRoot(volumeName, checkInvalidPathChars: false);
			}
			else
			{
				string text2 = volumeName;
				char volumeSeparatorChar = Path.VolumeSeparatorChar;
				text = text2 + volumeSeparatorChar;
			}
			volumeName = text;
			if (!volumeName.StartsWith(Path.GlobalRootPrefix, StringComparison.OrdinalIgnoreCase))
			{
				volumeName = Path.GetPathRoot(volumeName, checkInvalidPathChars: false);
			}
		}
		if (Utils.IsNullOrWhiteSpace(volumeName))
		{
			throw new ArgumentException(Resources.InvalidDriveLetterArgument, "volumeName");
		}
		Name = Path.AddTrailingDirectorySeparator(volumeName, addAlternateSeparator: false);
		_volumeHandle = null;
	}

	[SecurityCritical]
	public VolumeInfo(string driveName, bool refresh, bool continueOnException)
		: this(driveName)
	{
		_continueOnAccessError = continueOnException;
		if (refresh)
		{
			Refresh();
		}
	}

	[SecurityCritical]
	public VolumeInfo(SafeFileHandle volumeHandle)
	{
		_volumeHandle = volumeHandle;
	}

	[SecurityCritical]
	public VolumeInfo(SafeFileHandle volumeHandle, bool refresh, bool continueOnException)
		: this(volumeHandle)
	{
		_continueOnAccessError = continueOnException;
		if (refresh)
		{
			Refresh();
		}
	}

	public void Refresh()
	{
		StringBuilder stringBuilder = new StringBuilder(261);
		StringBuilder stringBuilder2 = new StringBuilder(261);
		uint lpVolumeSerialNumber;
		int lpMaximumComponentLength;
		using (new NativeMethods.ChangeErrorMode(NativeMethods.ErrorMode.FailCriticalErrors))
		{
			while (true)
			{
				bool num = ((_volumeHandle == null || !NativeMethods.IsAtLeastWindowsVista) ? NativeMethods.GetVolumeInformationW(Path.AddTrailingDirectorySeparator(Name, addAlternateSeparator: false), stringBuilder, (uint)stringBuilder.Capacity, out lpVolumeSerialNumber, out lpMaximumComponentLength, out _volumeInfoAttributes, stringBuilder2, (uint)stringBuilder2.Capacity) : NativeMethods.GetVolumeInformationByHandleW(_volumeHandle, stringBuilder, (uint)stringBuilder.Capacity, out lpVolumeSerialNumber, out lpMaximumComponentLength, out _volumeInfoAttributes, stringBuilder2, (uint)stringBuilder2.Capacity));
				uint lastWin32Error = (uint)Marshal.GetLastWin32Error();
				if (num)
				{
					break;
				}
				switch (lastWin32Error)
				{
				default:
					if (!_continueOnAccessError)
					{
						NativeError.ThrowException(lastWin32Error, Name);
					}
					goto IL_00cf;
				case 234u:
					stringBuilder.Capacity *= 2;
					stringBuilder2.Capacity *= 2;
					goto IL_00cf;
				case 21u:
					{
						if (!_continueOnAccessError)
						{
							throw new DeviceNotReadyException(Name, isPath: true);
						}
						goto IL_00cf;
					}
					IL_00cf:
					if (lastWin32Error == 234)
					{
						break;
					}
					goto end_IL_001d;
				}
				continue;
				end_IL_001d:
				break;
			}
		}
		FullPath = Path.GetRegularPathCore(Name, GetFullPathOptions.None, allowEmpty: false);
		Name = stringBuilder.ToString();
		FileSystemName = stringBuilder2.ToString();
		FileSystemName = ((!Utils.IsNullOrWhiteSpace(FileSystemName)) ? FileSystemName : null);
		MaximumComponentLength = lpMaximumComponentLength;
		SerialNumber = lpVolumeSerialNumber;
	}

	public override string ToString()
	{
		return Guid;
	}
}
