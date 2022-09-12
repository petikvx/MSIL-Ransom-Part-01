using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Text;
using Alphaleonis.Win32.Security;
using Microsoft.Win32.SafeHandles;

namespace Alphaleonis.Win32.Filesystem;

internal static class NativeMethods
{
	[Flags]
	internal enum EncryptedFileRawMode
	{
		CreateForExport = 0,
		CreateForImport = 1,
		CreateForDir = 2,
		OverwriteHidden = 4
	}

	internal enum FINDEX_SEARCH_OPS
	{
		SearchNameMatch,
		SearchLimitToDirectories,
		SearchLimitToDevices
	}

	internal enum STREAM_INFO_LEVELS
	{
		FindStreamInfoStandard,
		FindStreamInfoMaxInfoLevel
	}

	[Flags]
	internal enum SetupDiGetClassDevsExFlags
	{
		Default = 1,
		Present = 2,
		AllClasses = 4,
		Profile = 8,
		DeviceInterface = 0x10
	}

	internal enum FILE_INFO_BY_HANDLE_CLASS
	{
		FILE_BASIC_INFO = 0,
		FILE_ID_BOTH_DIR_INFO = 10,
		FILE_ID_INFO = 18
	}

	[Flags]
	internal enum FIND_FIRST_EX_FLAGS
	{
		NONE = 0,
		CASE_SENSITIVE = 1,
		LARGE_FETCH = 2
	}

	internal enum FINDEX_INFO_LEVELS
	{
		Standard,
		Basic
	}

	[Flags]
	internal enum ErrorMode
	{
		SystemDefault = 0,
		FailCriticalErrors = 1,
		NoGpfaultErrorbox = 2,
		NoAlignmentFaultExcept = 4,
		NoOpenFileErrorbox = 0x8000
	}

	internal enum SetupDiGetDeviceRegistryPropertyEnum
	{
		DeviceDescription = 0,
		HardwareId = 1,
		CompatibleIds = 2,
		Service = 4,
		Class = 7,
		ClassGuid = 8,
		Driver = 9,
		Manufacturer = 11,
		FriendlyName = 12,
		LocationInformation = 13,
		PhysicalDeviceObjectName = 14,
		EnumeratorName = 22,
		LocationPaths = 35,
		BaseContainerId = 36
	}

	[Flags]
	internal enum VOLUME_INFO_FLAGS
	{
		FILE_CASE_SENSITIVE_SEARCH = 1,
		FILE_CASE_PRESERVED_NAMES = 2,
		FILE_UNICODE_ON_DISK = 4,
		FILE_PERSISTENT_ACLS = 8,
		FILE_FILE_COMPRESSION = 0x10,
		FILE_VOLUME_QUOTAS = 0x20,
		FILE_SUPPORTS_SPARSE_FILES = 0x40,
		FILE_SUPPORTS_REPARSE_POINTS = 0x80,
		FILE_SUPPORTS_REMOTE_STORAGE = 0x100,
		FILE_VOLUME_IS_COMPRESSED = 0x8000,
		FILE_SUPPORTS_OBJECT_IDS = 0x10000,
		FILE_SUPPORTS_ENCRYPTION = 0x20000,
		FILE_NAMED_STREAMS = 0x40000,
		FILE_READ_ONLY_VOLUME = 0x80000,
		FILE_SEQUENTIAL_WRITE_ONCE = 0x100000,
		FILE_SUPPORTS_TRANSACTIONS = 0x200000,
		FILE_SUPPORTS_HARD_LINKS = 0x400000,
		FILE_SUPPORTS_EXTENDED_ATTRIBUTES = 0x800000,
		FILE_SUPPORTS_OPEN_BY_FILE_ID = 0x1000000,
		FILE_SUPPORTS_USN_JOURNAL = 0x2000000,
		FILE_DAX_VOLUME = 0x20000000
	}

	public enum GET_FILEEX_INFO_LEVELS
	{
		GetFileExInfoStandard
	}

	[SuppressUnmanagedCodeSecurity]
	internal delegate int EncryptedFileRawExportCallback(IntPtr pbData, IntPtr pvCallbackContext, uint ulLength);

	[SuppressUnmanagedCodeSecurity]
	internal delegate int EncryptedFileRawImportCallback(IntPtr pbData, IntPtr pvCallbackContext, ref uint ulLength);

	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("C46CA590-3C3F-11D2-BEE6-0000F805CA57")]
	[SuppressUnmanagedCodeSecurity]
	internal interface IQueryAssociations
	{
		void Init(Shell32.AssociationAttributes flags, [MarshalAs(UnmanagedType.LPWStr)] string pszAssoc, IntPtr hkProgid, IntPtr hwnd);

		void GetString(Shell32.AssociationAttributes flags, Shell32.AssociationString str, [MarshalAs(UnmanagedType.LPWStr)] string pwszExtra, StringBuilder pwszOut, [MarshalAs(UnmanagedType.I4)] out int pcchOut);
	}

	[SuppressUnmanagedCodeSecurity]
	internal delegate CopyMoveProgressResult NativeCopyMoveProgressRoutine([MarshalAs(UnmanagedType.I8)] long totalFileSize, [MarshalAs(UnmanagedType.I8)] long totalBytesTransferred, [MarshalAs(UnmanagedType.I8)] long streamSize, [MarshalAs(UnmanagedType.I8)] long streamBytesTransferred, [MarshalAs(UnmanagedType.U4)] uint dwStreamNumber, [MarshalAs(UnmanagedType.U4)] CopyMoveProgressCallbackReason dwCallbackReason, IntPtr hSourceFile, IntPtr hDestinationFile, IntPtr lpData);

	internal enum RM_APP_TYPE
	{
		RmUnknownApp = 0,
		RmMainWindow = 1,
		RmOtherWindow = 2,
		RmService = 3,
		RmExplorer = 4,
		RmConsole = 5,
		RmCritical = 1000
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct RM_UNIQUE_PROCESS
	{
		[MarshalAs(UnmanagedType.I4)]
		public readonly int dwProcessId;

		[MarshalAs(UnmanagedType.Struct)]
		public readonly FILETIME ProcessStartTime;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct RM_PROCESS_INFO
	{
		[MarshalAs(UnmanagedType.Struct)]
		public RM_UNIQUE_PROCESS Process;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public readonly string strAppName;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
		public readonly string strServiceShortName;

		[MarshalAs(UnmanagedType.I4)]
		public readonly RM_APP_TYPE ApplicationType;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint AppStatus;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint TSSessionId;

		[MarshalAs(UnmanagedType.Bool)]
		public readonly bool bRestartable;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct FILE_ID_INFO
	{
		public readonly long VolumeSerialNumber;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
		public readonly byte[] FileId;
	}

	public enum MOVE_FILE_FLAGS
	{
		None = 0,
		MOVE_FILE_REPLACE_EXISTSING = 1,
		MOVE_FILE_COPY_ALLOWED = 2,
		MOVE_FILE_DELAY_UNTIL_REBOOT = 4,
		MOVE_FILE_WRITE_THROUGH = 8,
		MOVE_FILE_CREATE_HARDLINK = 0x10,
		MOVE_FILE_FAIL_IF_NOT_TRACKABLE = 0x20
	}

	public enum COPY_FILE_FLAGS
	{
		COPY_FILE_FAIL_IF_EXISTS = 1,
		COPY_FILE_RESTARTABLE = 2,
		COPY_FILE_OPEN_SOURCE_FOR_WRITE = 4,
		COPY_FILE_ALLOW_DECRYPTED_DESTINATION = 8,
		COPY_FILE_COPY_SYMLINK = 0x800,
		COPY_FILE_NO_BUFFERING = 0x1000
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct FILE_BASIC_INFO
	{
		public FILETIME CreationTime;

		public FILETIME LastAccessTime;

		public FILETIME LastWriteTime;

		public FILETIME ChangeTime;

		public FileAttributes FileAttributes;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct REPARSE_DATA_BUFFER
	{
		public ReparsePointTag ReparseTag;

		public ushort ReparseDataLength;

		public ushort Reserved;

		public ushort SubstituteNameOffset;

		public ushort SubstituteNameLength;

		public ushort PrintNameOffset;

		public ushort PrintNameLength;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16368)]
		public byte[] PathBuffer;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct WIN32_FIND_STREAM_DATA
	{
		public long StreamSize;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 296)]
		public string cStreamName;
	}

	[SecurityCritical]
	public sealed class SafeSetupDiClassDevsExHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		public SafeSetupDiClassDevsExHandle()
			: base(ownsHandle: true)
		{
		}

		protected override bool ReleaseHandle()
		{
			return SetupDiDestroyDeviceInfoList(handle);
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct BY_HANDLE_FILE_INFORMATION
	{
		public readonly FileAttributes dwFileAttributes;

		public readonly FILETIME ftCreationTime;

		public readonly FILETIME ftLastAccessTime;

		public readonly FILETIME ftLastWriteTime;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint dwVolumeSerialNumber;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint nFileSizeHigh;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint nFileSizeLow;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint nNumberOfLinks;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint nFileIndexHigh;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint nFileIndexLow;
	}

	public sealed class ChangeErrorMode : IDisposable
	{
		private readonly ErrorMode _oldMode;

		public ChangeErrorMode(ErrorMode mode)
		{
			if (IsAtLeastWindows7)
			{
				SetThreadErrorMode(mode, out _oldMode);
			}
			else
			{
				_oldMode = SetErrorMode(mode);
			}
		}

		void IDisposable.Dispose()
		{
			if (IsAtLeastWindows7)
			{
				SetThreadErrorMode(_oldMode, out var _);
			}
			else
			{
				SetErrorMode(_oldMode);
			}
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct FILE_ID_BOTH_DIR_INFO
	{
		[MarshalAs(UnmanagedType.U4)]
		public readonly int NextEntryOffset;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint FileIndex;

		public FILETIME CreationTime;

		public FILETIME LastAccessTime;

		public FILETIME LastWriteTime;

		public FILETIME ChangeTime;

		public readonly long EndOfFile;

		public readonly long AllocationSize;

		public readonly FileAttributes FileAttributes;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint FileNameLength;

		[MarshalAs(UnmanagedType.U4)]
		public readonly int EaSize;

		[MarshalAs(UnmanagedType.U1)]
		public readonly byte ShortNameLength;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.U2)]
		public readonly char[] ShortName;

		public readonly long FileId;

		public IntPtr FileName;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct FILETIME
	{
		private readonly uint dwLowDateTime;

		private readonly uint dwHighDateTime;

		public static implicit operator long(FILETIME ft)
		{
			return ft.ToLong();
		}

		[SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "long")]
		public long ToLong()
		{
			return NativeMethods.ToLong(dwHighDateTime, dwLowDateTime);
		}

		public override bool Equals(object obj)
		{
			if (obj != null && (object)GetType() == obj.GetType())
			{
				FILETIME fILETIME = (obj as FILETIME?) ?? default(FILETIME);
				uint num = fILETIME.dwHighDateTime;
				if (num.Equals(dwHighDateTime))
				{
					num = fILETIME.dwLowDateTime;
					return num.Equals(dwLowDateTime);
				}
				return false;
			}
			return false;
		}

		public override int GetHashCode()
		{
			uint num = dwHighDateTime;
			int num2 = (391 + num.GetHashCode()) * 11;
			num = dwLowDateTime;
			return num2 + num.GetHashCode();
		}

		public static bool operator ==(FILETIME left, FILETIME right)
		{
			return left.Equals(right);
		}

		public static bool operator !=(FILETIME left, FILETIME right)
		{
			return !(left == right);
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct MountPointReparseBuffer
	{
		public ushort SubstituteNameOffset;

		public ushort SubstituteNameLength;

		public ushort PrintNameOffset;

		public ushort PrintNameLength;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
		public byte[] data;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct ReparseDataBufferHeader
	{
		[MarshalAs(UnmanagedType.U4)]
		public ReparsePointTag ReparseTag;

		public ushort ReparseDataLength;

		public ushort Reserved;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
		public byte[] data;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct SP_DEVINFO_DATA
	{
		[MarshalAs(UnmanagedType.U4)]
		public uint cbSize;

		public readonly Guid ClassGuid;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint DevInst;

		private readonly IntPtr Reserved;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct SP_DEVICE_INTERFACE_DATA
	{
		[MarshalAs(UnmanagedType.U4)]
		public uint cbSize;

		public readonly Guid InterfaceClassGuid;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint Flags;

		private readonly IntPtr Reserved;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct SP_DEVICE_INTERFACE_DETAIL_DATA
	{
		[MarshalAs(UnmanagedType.U4)]
		public uint cbSize;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public readonly string DevicePath;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct SymbolicLinkReparseBuffer
	{
		public ushort SubstituteNameOffset;

		public ushort SubstituteNameLength;

		public ushort PrintNameOffset;

		public ushort PrintNameLength;

		public SymbolicLinkType Flags;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
		public byte[] data;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct WIN32_FILE_ATTRIBUTE_DATA
	{
		[MarshalAs(UnmanagedType.I4)]
		public FileAttributes dwFileAttributes;

		public readonly FILETIME ftCreationTime;

		public readonly FILETIME ftLastAccessTime;

		public readonly FILETIME ftLastWriteTime;

		public readonly uint nFileSizeHigh;

		public readonly uint nFileSizeLow;

		public long FileSize => ToLong(nFileSizeHigh, nFileSizeLow);

		public WIN32_FILE_ATTRIBUTE_DATA(WIN32_FIND_DATA findData)
		{
			dwFileAttributes = findData.dwFileAttributes;
			ftCreationTime = findData.ftCreationTime;
			ftLastAccessTime = findData.ftLastAccessTime;
			ftLastWriteTime = findData.ftLastWriteTime;
			nFileSizeHigh = findData.nFileSizeHigh;
			nFileSizeLow = findData.nFileSizeLow;
		}
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct WIN32_FIND_DATA
	{
		public FileAttributes dwFileAttributes;

		public FILETIME ftCreationTime;

		public FILETIME ftLastAccessTime;

		public FILETIME ftLastWriteTime;

		public uint nFileSizeHigh;

		public uint nFileSizeLow;

		public readonly ReparsePointTag dwReserved0;

		private readonly uint dwReserved1;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string cFileName;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
		public readonly string cAlternateFileName;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
	internal struct WIN32_STREAM_ID
	{
		[MarshalAs(UnmanagedType.U4)]
		public readonly STREAM_ID dwStreamId;

		[MarshalAs(UnmanagedType.U4)]
		public readonly STREAM_ATTRIBUTES dwStreamAttributes;

		[MarshalAs(UnmanagedType.U8)]
		public readonly ulong Size;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint dwStreamNameSize;
	}

	internal static readonly Guid ClsidQueryAssociations = new Guid("A07034FD-6CAA-4954-AC3F-97A27216F98A");

	internal const string QueryAssociationsGuid = "C46CA590-3C3F-11D2-BEE6-0000F805CA57";

	private const int CCH_RM_MAX_APP_NAME = 255;

	private const int CCH_RM_MAX_SVC_NAME = 63;

	public static readonly bool IsAtLeastWindows8 = OperatingSystem.IsAtLeast(OperatingSystem.EnumOsName.Windows8);

	public static readonly bool IsAtLeastWindows7 = OperatingSystem.IsAtLeast(OperatingSystem.EnumOsName.Windows7);

	public static readonly bool IsAtLeastWindowsVista = OperatingSystem.IsAtLeast(OperatingSystem.EnumOsName.WindowsVista);

	public static readonly FINDEX_INFO_LEVELS FindexInfoLevel = (IsAtLeastWindows7 ? FINDEX_INFO_LEVELS.Basic : FINDEX_INFO_LEVELS.Standard);

	public static readonly FIND_FIRST_EX_FLAGS UseLargeCache = (IsAtLeastWindows7 ? FIND_FIRST_EX_FLAGS.LARGE_FETCH : FIND_FIRST_EX_FLAGS.NONE);

	public const int DefaultFileBufferSize = 4096;

	public static readonly Encoding DefaultFileEncoding = Encoding.UTF8;

	internal const int MaxDirectoryLength = 255;

	internal const int MaxPath = 260;

	internal const int MaxPathUnicode = 32700;

	internal const int OverflowExceptionBitShift = 65535;

	internal const FileAttributes InvalidFileAttributes = (FileAttributes)(-1);

	internal const int MAXIMUM_REPARSE_DATA_BUFFER_SIZE = 16384;

	internal const int REPARSE_DATA_BUFFER_HEADER_SIZE = 8;

	private const int DeviceIoControlMethodBuffered = 0;

	private const int DeviceIoControlFileDeviceFileSystem = 9;

	internal const int FSCTL_SET_COMPRESSION = 639040;

	internal const int FSCTL_SET_REPARSE_POINT = 589988;

	internal const int FSCTL_DELETE_REPARSE_POINT = 589996;

	internal const int FSCTL_GET_REPARSE_POINT = 589992;

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.U4)]
	internal static extern uint OpenEncryptedFileRawW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, EncryptedFileRawMode ulFlags, out SafeEncryptedFileRawHandle pvContext);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	internal static extern void CloseEncryptedFileRaw(IntPtr pvContext);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.U4)]
	internal static extern uint ReadEncryptedFileRaw([MarshalAs(UnmanagedType.FunctionPtr)] EncryptedFileRawExportCallback pfExportCallback, IntPtr pvCallbackContext, SafeEncryptedFileRawHandle pvContext);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.U4)]
	internal static extern uint WriteEncryptedFileRaw([MarshalAs(UnmanagedType.FunctionPtr)] EncryptedFileRawImportCallback pfExportCallback, IntPtr pvCallbackContext, SafeEncryptedFileRawHandle pvContext);

	[DllImport("shlwapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[return: MarshalAs(UnmanagedType.U4)]
	internal static extern uint AssocCreate(Guid clsid, ref Guid riid, [MarshalAs(UnmanagedType.Interface)] out IQueryAssociations ppv);

	[DllImport("shlwapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.U4)]
	internal static extern uint AssocQueryStringW(Shell32.AssociationAttributes flags, Shell32.AssociationString str, [MarshalAs(UnmanagedType.LPWStr)] string pszAssoc, [MarshalAs(UnmanagedType.LPWStr)] string pszExtra, StringBuilder pszOut, [MarshalAs(UnmanagedType.U4)] out uint pcchOut);

	[DllImport("shlwapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool PathFileExistsW([MarshalAs(UnmanagedType.LPWStr)] string pszPath);

	[DllImport("shlwapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[return: MarshalAs(UnmanagedType.U4)]
	internal static extern uint PathCreateFromUrlW([MarshalAs(UnmanagedType.LPWStr)] string pszUrl, StringBuilder pszPath, [MarshalAs(UnmanagedType.U4)] ref uint pcchPath, [MarshalAs(UnmanagedType.U4)] uint dwFlags);

	[DllImport("shlwapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.U4)]
	internal static extern uint PathCreateFromUrlAlloc([MarshalAs(UnmanagedType.LPWStr)] string pszIn, out StringBuilder pszPath, [MarshalAs(UnmanagedType.U4)] uint dwFlags);

	[DllImport("shlwapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.U4)]
	internal static extern uint UrlCreateFromPathW([MarshalAs(UnmanagedType.LPWStr)] string pszPath, StringBuilder pszUrl, ref uint pcchUrl, [MarshalAs(UnmanagedType.U4)] uint dwFlags);

	[DllImport("shlwapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool UrlIsW([MarshalAs(UnmanagedType.LPWStr)] string pszUrl, Shell32.UrlType urlIs);

	[DllImport("user32.dll")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool DestroyIcon(IntPtr hIcon);

	[DllImport("shell32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	internal static extern IntPtr SHGetFileInfoW([MarshalAs(UnmanagedType.LPWStr)] string pszPath, FileAttributes dwFileAttributes, [MarshalAs(UnmanagedType.Struct)] out Shell32.FileInfo psfi, [MarshalAs(UnmanagedType.U4)] uint cbFileInfo, [MarshalAs(UnmanagedType.U4)] Shell32.FileAttributes uFlags);

	[DllImport("ktmw32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressUnmanagedCodeSecurity]
	internal static extern SafeKernelTransactionHandle CreateTransaction([MarshalAs(UnmanagedType.LPStruct)] Alphaleonis.Win32.Security.NativeMethods.SecurityAttributes lpTransactionAttributes, IntPtr uow, [MarshalAs(UnmanagedType.U4)] uint createOptions, [MarshalAs(UnmanagedType.U4)] uint isolationLevel, [MarshalAs(UnmanagedType.U4)] uint isolationFlags, [MarshalAs(UnmanagedType.U4)] int timeout, [MarshalAs(UnmanagedType.LPWStr)] string description);

	[DllImport("ktmw32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool CommitTransaction(SafeHandle hTrans);

	[DllImport("ktmw32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool RollbackTransaction(SafeHandle hTrans);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool CloseHandle(IntPtr hObject);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool CopyFileExW([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, NativeCopyMoveProgressRoutine lpProgressRoutine, IntPtr lpData, [MarshalAs(UnmanagedType.Bool)] out bool pbCancel, CopyOptions dwCopyFlags);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool CopyFileTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, NativeCopyMoveProgressRoutine lpProgressRoutine, IntPtr lpData, [MarshalAs(UnmanagedType.Bool)] out bool pbCancel, CopyOptions dwCopyFlags, SafeHandle hTransaction);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	internal static extern SafeFileHandle CreateFileW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.U4)] FileSystemRights dwDesiredAccess, [MarshalAs(UnmanagedType.U4)] FileShare dwShareMode, [MarshalAs(UnmanagedType.LPStruct)] Alphaleonis.Win32.Security.NativeMethods.SecurityAttributes lpSecurityAttributes, [MarshalAs(UnmanagedType.U4)] FileMode dwCreationDisposition, [MarshalAs(UnmanagedType.U4)] ExtendedFileAttributes dwFlagsAndAttributes, IntPtr hTemplateFile);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	internal static extern SafeFileHandle CreateFileTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.U4)] FileSystemRights dwDesiredAccess, [MarshalAs(UnmanagedType.U4)] FileShare dwShareMode, [MarshalAs(UnmanagedType.LPStruct)] Alphaleonis.Win32.Security.NativeMethods.SecurityAttributes lpSecurityAttributes, [MarshalAs(UnmanagedType.U4)] FileMode dwCreationDisposition, [MarshalAs(UnmanagedType.U4)] ExtendedFileAttributes dwFlagsAndAttributes, IntPtr hTemplateFile, SafeHandle hTransaction, IntPtr pusMiniVersion, IntPtr pExtendedParameter);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	internal static extern SafeFileHandle CreateFileMappingW(SafeFileHandle hFile, SafeHandle lpSecurityAttributes, [MarshalAs(UnmanagedType.U4)] uint flProtect, [MarshalAs(UnmanagedType.U4)] uint dwMaximumSizeHigh, [MarshalAs(UnmanagedType.U4)] uint dwMaximumSizeLow, [MarshalAs(UnmanagedType.LPWStr)] string lpName);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool CreateHardLinkW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, IntPtr lpSecurityAttributes);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool CreateHardLinkTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, IntPtr lpSecurityAttributes, SafeHandle hTransaction);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[return: MarshalAs(UnmanagedType.I1)]
	internal static extern bool CreateSymbolicLinkW([MarshalAs(UnmanagedType.LPWStr)] string lpSymlinkFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpTargetFileName, [MarshalAs(UnmanagedType.U4)] SymbolicLinkTarget dwFlags);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.I1)]
	internal static extern bool CreateSymbolicLinkTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpSymlinkFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpTargetFileName, [MarshalAs(UnmanagedType.U4)] SymbolicLinkTarget dwFlags, SafeHandle hTransaction);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool DecryptFileW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.U4)] uint dwReserved);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool DeleteFileW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool DeleteFileTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, SafeHandle hTransaction);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool EncryptFileW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool EncryptionDisable([MarshalAs(UnmanagedType.LPWStr)] string dirPath, [MarshalAs(UnmanagedType.Bool)] bool disable);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool FileEncryptionStatusW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, out FileEncryptionStatus lpStatus);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressUnmanagedCodeSecurity]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool FindClose(IntPtr hFindFile);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressUnmanagedCodeSecurity]
	internal static extern SafeFindFileHandle FindFirstFileExW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, FINDEX_INFO_LEVELS fInfoLevelId, out WIN32_FIND_DATA lpFindFileData, FINDEX_SEARCH_OPS fSearchOp, IntPtr lpSearchFilter, FIND_FIRST_EX_FLAGS dwAdditionalFlags);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	internal static extern SafeFindFileHandle FindFirstFileTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, FINDEX_INFO_LEVELS fInfoLevelId, out WIN32_FIND_DATA lpFindFileData, FINDEX_SEARCH_OPS fSearchOp, IntPtr lpSearchFilter, FIND_FIRST_EX_FLAGS dwAdditionalFlags, SafeHandle hTransaction);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressUnmanagedCodeSecurity]
	internal static extern SafeFindFileHandle FindFirstFileNameW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.U4)] uint dwFlags, [MarshalAs(UnmanagedType.U4)] out uint stringLength, StringBuilder linkName);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressUnmanagedCodeSecurity]
	internal static extern SafeFindFileHandle FindFirstFileNameTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.U4)] uint dwFlags, [MarshalAs(UnmanagedType.U4)] out uint stringLength, StringBuilder linkName, SafeHandle hTransaction);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool FindNextFileW(SafeFindFileHandle hFindFile, out WIN32_FIND_DATA lpFindFileData);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool FindNextFileNameW(SafeFindFileHandle hFindStream, [MarshalAs(UnmanagedType.U4)] out uint stringLength, StringBuilder linkName);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool FlushFileBuffers(SafeFileHandle hFile);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.U4)]
	internal static extern uint GetCompressedFileSizeW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.U4)] out uint lpFileSizeHigh);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[return: MarshalAs(UnmanagedType.U4)]
	internal static extern uint GetCompressedFileSizeTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.U4)] out uint lpFileSizeHigh, SafeHandle hTransaction);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool GetFileAttributesExW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.U4)] GET_FILEEX_INFO_LEVELS fInfoLevelId, out WIN32_FILE_ATTRIBUTE_DATA lpFileInformation);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool GetFileAttributesTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.U4)] GET_FILEEX_INFO_LEVELS fInfoLevelId, out WIN32_FILE_ATTRIBUTE_DATA lpFileInformation, SafeHandle hTransaction);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool GetFileInformationByHandle(SafeFileHandle hFile, [MarshalAs(UnmanagedType.Struct)] out BY_HANDLE_FILE_INFORMATION lpByHandleFileInformation);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool GetFileInformationByHandleEx(SafeFileHandle hFile, [MarshalAs(UnmanagedType.I4)] FILE_INFO_BY_HANDLE_CLASS fileInfoByHandleClass, SafeGlobalMemoryBufferHandle lpFileInformation, [MarshalAs(UnmanagedType.U4)] uint dwBufferSize);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, EntryPoint = "GetFileInformationByHandleEx", SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool GetFileInformationByHandleEx_1(SafeFileHandle hFile, [MarshalAs(UnmanagedType.I4)] FILE_INFO_BY_HANDLE_CLASS fileInfoByHandleClass, [MarshalAs(UnmanagedType.Struct)] out FILE_BASIC_INFO lpFileInformation, [MarshalAs(UnmanagedType.U4)] uint dwBufferSize);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool GetFileSizeEx(SafeFileHandle hFile, out long lpFileSize);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[return: MarshalAs(UnmanagedType.U4)]
	internal static extern uint GetFinalPathNameByHandleW(SafeFileHandle hFile, StringBuilder lpszFilePath, [MarshalAs(UnmanagedType.U4)] uint cchFilePath, FinalPathFormats dwFlags);

	[DllImport("psapi.dll", CharSet = CharSet.Unicode)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool GetMappedFileNameW(IntPtr hProcess, SafeLocalMemoryBufferHandle lpv, StringBuilder lpFilename, [MarshalAs(UnmanagedType.U4)] uint nSize);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool LockFile(SafeFileHandle hFile, [MarshalAs(UnmanagedType.U4)] uint dwFileOffsetLow, [MarshalAs(UnmanagedType.U4)] uint dwFileOffsetHigh, [MarshalAs(UnmanagedType.U4)] uint nNumberOfBytesToLockLow, [MarshalAs(UnmanagedType.U4)] uint nNumberOfBytesToLockHigh);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	internal static extern SafeLocalMemoryBufferHandle MapViewOfFile(SafeFileHandle hFileMappingObject, [MarshalAs(UnmanagedType.U4)] uint dwDesiredAccess, [MarshalAs(UnmanagedType.U4)] uint dwFileOffsetHigh, [MarshalAs(UnmanagedType.U4)] uint dwFileOffsetLow, UIntPtr dwNumberOfBytesToMap);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool MoveFileWithProgressW([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, NativeCopyMoveProgressRoutine lpProgressRoutine, IntPtr lpData, [MarshalAs(UnmanagedType.U4)] MoveOptions dwFlags);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool MoveFileTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, NativeCopyMoveProgressRoutine lpProgressRoutine, IntPtr lpData, [MarshalAs(UnmanagedType.U4)] MoveOptions dwCopyFlags, SafeHandle hTransaction);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool ReplaceFileW([MarshalAs(UnmanagedType.LPWStr)] string lpReplacedFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpReplacementFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpBackupFileName, FileSystemRights dwReplaceFlags, IntPtr lpExclude, IntPtr lpReserved);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Usage", "CA2205:UseManagedEquivalentsOfWin32Api")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool SetFileAttributesW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.U4)] FileAttributes dwFileAttributes);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool SetFileAttributesTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.U4)] FileAttributes dwFileAttributes, SafeHandle hTransaction);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool SetFilePointerEx(SafeFileHandle hFile, [MarshalAs(UnmanagedType.U8)] ulong liDistanceToMove, IntPtr lpNewFilePointer, [MarshalAs(UnmanagedType.U4)] SeekOrigin dwMoveMethod);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool SetFileTime(SafeFileHandle hFile, SafeGlobalMemoryBufferHandle lpCreationTime, SafeGlobalMemoryBufferHandle lpLastAccessTime, SafeGlobalMemoryBufferHandle lpLastWriteTime);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool UnlockFile(SafeFileHandle hFile, [MarshalAs(UnmanagedType.U4)] uint dwFileOffsetLow, [MarshalAs(UnmanagedType.U4)] uint dwFileOffsetHigh, [MarshalAs(UnmanagedType.U4)] uint nNumberOfBytesToUnlockLow, [MarshalAs(UnmanagedType.U4)] uint nNumberOfBytesToUnlockHigh);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool UnmapViewOfFile(SafeLocalMemoryBufferHandle lpBaseAddress);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	internal static extern SafeFindFileHandle FindFirstStreamW(string lpFileName, STREAM_INFO_LEVELS infoLevel, SafeGlobalMemoryBufferHandle lpFindStreamData, int dwFlags);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressUnmanagedCodeSecurity]
	internal static extern SafeFindFileHandle FindFirstStreamTransactedW(string lpFileName, STREAM_INFO_LEVELS infoLevel, SafeGlobalMemoryBufferHandle lpFindStreamData, int dwFlags, SafeHandle hTransaction);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool FindNextStreamW(SafeFindFileHandle handle, SafeGlobalMemoryBufferHandle lpFindStreamData);

	[DllImport("rstrtmgr.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.I4)]
	internal static extern int RmEndSession([MarshalAs(UnmanagedType.U4)] uint pSessionHandle);

	[DllImport("rstrtmgr.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.I4)]
	internal static extern int RmGetList([MarshalAs(UnmanagedType.U4)] uint dwSessionHandle, [MarshalAs(UnmanagedType.U4)] out uint pnProcInfoNeeded, [MarshalAs(UnmanagedType.U4)] ref uint pnProcInfo, [In][Out][MarshalAs(UnmanagedType.LPArray)] RM_PROCESS_INFO[] rgAffectedApps, [MarshalAs(UnmanagedType.U4)] ref uint lpdwRebootReasons);

	[DllImport("rstrtmgr.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.I4)]
	internal static extern int RmRegisterResources([MarshalAs(UnmanagedType.U4)] uint pSessionHandle, [MarshalAs(UnmanagedType.U4)] uint nFiles, [MarshalAs(UnmanagedType.LPArray)] string[] rgsFilenames, [MarshalAs(UnmanagedType.U4)] uint nApplications, [In] RM_UNIQUE_PROCESS[] rgApplications, [MarshalAs(UnmanagedType.U4)] uint nServices, [MarshalAs(UnmanagedType.LPArray)] string[] rgsServiceNames);

	[DllImport("rstrtmgr.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.I4)]
	internal static extern int RmStartSession([MarshalAs(UnmanagedType.U4)] out uint pSessionHandle, [MarshalAs(UnmanagedType.I4)] int dwSessionFlags, [MarshalAs(UnmanagedType.LPWStr)] string strSessionKey);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool GetDiskFreeSpaceW([MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, [MarshalAs(UnmanagedType.U4)] out int lpSectorsPerCluster, [MarshalAs(UnmanagedType.U4)] out int lpBytesPerSector, [MarshalAs(UnmanagedType.U4)] out int lpNumberOfFreeClusters, [MarshalAs(UnmanagedType.U4)] out uint lpTotalNumberOfClusters);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool GetDiskFreeSpaceExW([MarshalAs(UnmanagedType.LPWStr)] string lpDirectoryName, [MarshalAs(UnmanagedType.U8)] out long lpFreeBytesAvailable, [MarshalAs(UnmanagedType.U8)] out long lpTotalNumberOfBytes, [MarshalAs(UnmanagedType.U8)] out long lpTotalNumberOfFreeBytes);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool CreateDirectoryW([MarshalAs(UnmanagedType.LPWStr)] string lpPathName, [MarshalAs(UnmanagedType.LPStruct)] Alphaleonis.Win32.Security.NativeMethods.SecurityAttributes lpSecurityAttributes);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool CreateDirectoryExW([MarshalAs(UnmanagedType.LPWStr)] string lpTemplateDirectory, [MarshalAs(UnmanagedType.LPWStr)] string lpPathName, [MarshalAs(UnmanagedType.LPStruct)] Alphaleonis.Win32.Security.NativeMethods.SecurityAttributes lpSecurityAttributes);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool CreateDirectoryTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpTemplateDirectory, [MarshalAs(UnmanagedType.LPWStr)] string lpNewDirectory, [MarshalAs(UnmanagedType.LPStruct)] Alphaleonis.Win32.Security.NativeMethods.SecurityAttributes lpSecurityAttributes, SafeHandle hTransaction);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Usage", "CA2205:UseManagedEquivalentsOfWin32Api")]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.U4)]
	internal static extern uint GetCurrentDirectoryW([MarshalAs(UnmanagedType.U4)] uint nBufferLength, StringBuilder lpBuffer);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool RemoveDirectoryW([MarshalAs(UnmanagedType.LPWStr)] string lpPathName);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool RemoveDirectoryTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpPathName, SafeHandle hTransaction);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Usage", "CA2205:UseManagedEquivalentsOfWin32Api")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool SetCurrentDirectoryW([MarshalAs(UnmanagedType.LPWStr)] string lpPathName);

	[DllImport("setupapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.I4)]
	public static extern int CM_Connect_MachineW([MarshalAs(UnmanagedType.LPWStr)] string uncServerName, out SafeCmConnectMachineHandle phMachine);

	[DllImport("setupapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.I4)]
	public static extern int CM_Get_Device_ID_ExW([MarshalAs(UnmanagedType.U4)] uint dnDevInst, SafeGlobalMemoryBufferHandle buffer, [MarshalAs(UnmanagedType.U4)] uint bufferLen, [MarshalAs(UnmanagedType.U4)] uint ulFlags, SafeCmConnectMachineHandle hMachine);

	[DllImport("setupapi.dll", CharSet = CharSet.Unicode)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.I4)]
	internal static extern int CM_Disconnect_Machine(IntPtr hMachine);

	[DllImport("setupapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.I4)]
	internal static extern int CM_Get_Parent_Ex([MarshalAs(UnmanagedType.U4)] out uint pdnDevInst, [MarshalAs(UnmanagedType.U4)] uint dnDevInst, [MarshalAs(UnmanagedType.U4)] uint ulFlags, SafeCmConnectMachineHandle hMachine);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool DeviceIoControl(SafeFileHandle hDevice, [MarshalAs(UnmanagedType.U4)] uint dwIoControlCode, IntPtr lpInBuffer, [MarshalAs(UnmanagedType.U4)] uint nInBufferSize, SafeGlobalMemoryBufferHandle lpOutBuffer, [MarshalAs(UnmanagedType.U4)] uint nOutBufferSize, [MarshalAs(UnmanagedType.U4)] out uint lpBytesReturned, IntPtr lpOverlapped);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, EntryPoint = "DeviceIoControl", SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool DeviceIoControl_1(SafeFileHandle hDevice, [MarshalAs(UnmanagedType.U4)] uint dwIoControlCode, SafeGlobalMemoryBufferHandle lpInBuffer, [MarshalAs(UnmanagedType.U4)] uint nInBufferSize, IntPtr lpOutBuffer, [MarshalAs(UnmanagedType.U4)] uint nOutBufferSize, [MarshalAs(UnmanagedType.U4)] out uint lpBytesReturned, IntPtr lpOverlapped);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, EntryPoint = "DeviceIoControl", SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool DeviceIoControl_2(SafeFileHandle hDevice, [MarshalAs(UnmanagedType.U4)] uint dwIoControlCode, [MarshalAs(UnmanagedType.AsAny)] object lpInBuffer, [MarshalAs(UnmanagedType.U4)] uint nInBufferSize, [Out][MarshalAs(UnmanagedType.AsAny)] object lpOutBuffer, [MarshalAs(UnmanagedType.U4)] uint nOutBufferSize, [MarshalAs(UnmanagedType.U4)] out uint lpBytesReturned, IntPtr lpOverlapped);

	[DllImport("setupapi.dll", CharSet = CharSet.Unicode)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool SetupDiDestroyDeviceInfoList(IntPtr hDevInfo);

	[DllImport("setupapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool SetupDiEnumDeviceInterfaces(SafeHandle hDevInfo, IntPtr devInfo, ref Guid interfaceClassGuid, [MarshalAs(UnmanagedType.U4)] uint memberIndex, ref SP_DEVICE_INTERFACE_DATA deviceInterfaceData);

	[DllImport("setupapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	internal static extern SafeSetupDiClassDevsExHandle SetupDiGetClassDevsEx(ref Guid classGuid, IntPtr enumerator, IntPtr hwndParent, [MarshalAs(UnmanagedType.U4)] SetupDiGetClassDevsExFlags devsExFlags, IntPtr deviceInfoSet, [MarshalAs(UnmanagedType.LPWStr)] string machineName, IntPtr reserved);

	[DllImport("setupapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool SetupDiGetDeviceInterfaceDetail(SafeHandle hDevInfo, ref SP_DEVICE_INTERFACE_DATA deviceInterfaceData, ref SP_DEVICE_INTERFACE_DETAIL_DATA deviceInterfaceDetailData, [MarshalAs(UnmanagedType.U4)] uint deviceInterfaceDetailDataSize, IntPtr requiredSize, ref SP_DEVINFO_DATA deviceInfoData);

	[DllImport("setupapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool SetupDiGetDeviceRegistryProperty(SafeHandle deviceInfoSet, ref SP_DEVINFO_DATA deviceInfoData, SetupDiGetDeviceRegistryPropertyEnum property, IntPtr propertyRegDataType, SafeGlobalMemoryBufferHandle propertyBuffer, [MarshalAs(UnmanagedType.U4)] uint propertyBufferSize, IntPtr requiredSize);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool BackupRead(SafeFileHandle hFile, SafeGlobalMemoryBufferHandle lpBuffer, [MarshalAs(UnmanagedType.U4)] uint nNumberOfBytesToRead, [MarshalAs(UnmanagedType.U4)] out uint lpNumberOfBytesRead, [MarshalAs(UnmanagedType.Bool)] bool bAbort, [MarshalAs(UnmanagedType.Bool)] bool bProcessSecurity, ref IntPtr lpContext);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool BackupSeek(SafeFileHandle hFile, [MarshalAs(UnmanagedType.U4)] uint dwLowBytesToSeek, [MarshalAs(UnmanagedType.U4)] uint dwHighBytesToSeek, [MarshalAs(UnmanagedType.U4)] out uint lpdwLowBytesSeeked, [MarshalAs(UnmanagedType.U4)] out uint lpdwHighBytesSeeked, ref IntPtr lpContext);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool BackupWrite(SafeFileHandle hFile, SafeGlobalMemoryBufferHandle lpBuffer, [MarshalAs(UnmanagedType.U4)] uint nNumberOfBytesToWrite, [MarshalAs(UnmanagedType.U4)] out uint lpNumberOfBytesWritten, [MarshalAs(UnmanagedType.Bool)] bool bAbort, [MarshalAs(UnmanagedType.Bool)] bool bProcessSecurity, ref IntPtr lpContext);

	internal static uint GetHighOrderDword(long highPart)
	{
		return (uint)((ulong)(highPart >> 32) & 0xFFFFFFFFuL);
	}

	internal static uint GetLowOrderDword(long lowPart)
	{
		return (uint)((ulong)lowPart & 0xFFFFFFFFuL);
	}

	internal static long LuidToLong(LUID luid)
	{
		ulong num = (ulong)luid.HighPart << 32;
		ulong num2 = luid.LowPart & 0xFFFFFFFFuL;
		return (long)(num | num2);
	}

	internal static LUID LongToLuid(long lluid)
	{
		LUID result = default(LUID);
		result.HighPart = (uint)(lluid >> 32);
		result.LowPart = (uint)((ulong)lluid & 0xFFFFFFFFuL);
		return result;
	}

	internal static long ToLong(uint highPart, uint lowPart)
	{
		return (long)((ulong)highPart << 32) | ((long)lowPart & 0xFFFFFFFFL);
	}

	internal static bool IsValidHandle(SafeHandle handle, bool throwException = true)
	{
		if (handle != null && !handle.IsClosed && !handle.IsInvalid)
		{
			return true;
		}
		handle?.Close();
		if (throwException)
		{
			throw new ArgumentException(Resources.Handle_Is_Invalid, "handle");
		}
		return false;
	}

	internal static bool IsValidHandle(SafeHandle handle, int lastError, bool throwException = true)
	{
		if (handle != null && !handle.IsClosed && !handle.IsInvalid)
		{
			return true;
		}
		handle?.Close();
		if (throwException)
		{
			throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, Resources.Handle_Is_Invalid_Win32Error, new object[1] { lastError }), "handle");
		}
		return false;
	}

	internal static bool IsValidHandle(SafeHandle handle, int lastError, string path, bool throwException = true)
	{
		if (handle != null && !handle.IsClosed && !handle.IsInvalid)
		{
			return true;
		}
		handle?.Close();
		if (throwException)
		{
			NativeError.ThrowException(lastError, path);
		}
		return false;
	}

	internal static bool CloseHandleAndPossiblyThrowException(SafeHandle handle, int lastError, bool? isFolder, string path, bool throwException = true)
	{
		if (handle != null && !handle.IsClosed && !handle.IsInvalid)
		{
			return true;
		}
		CloseSafeHandle(handle);
		if (throwException)
		{
			NativeError.ThrowException(lastError, isFolder, path);
		}
		return false;
	}

	internal static void CloseSafeHandle(SafeHandle handle)
	{
		if (handle != null && !handle.IsClosed)
		{
			handle.Close();
		}
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[return: MarshalAs(UnmanagedType.U4)]
	private static extern ErrorMode SetErrorMode(ErrorMode uMode);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool SetThreadErrorMode(ErrorMode dwNewMode, [MarshalAs(UnmanagedType.U4)] out ErrorMode lpOldMode);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.U4)]
	internal static extern uint GetFullPathNameW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.U4)] uint nBufferLength, StringBuilder lpBuffer, IntPtr lpFilePart);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.U4)]
	internal static extern uint GetFullPathNameTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.U4)] uint nBufferLength, StringBuilder lpBuffer, IntPtr lpFilePart, SafeHandle hTransaction);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.U4)]
	internal static extern uint GetLongPathNameW([MarshalAs(UnmanagedType.LPWStr)] string lpszShortPath, StringBuilder lpszLongPath, [MarshalAs(UnmanagedType.U4)] uint cchBuffer);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.U4)]
	internal static extern uint GetLongPathNameTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpszShortPath, StringBuilder lpszLongPath, [MarshalAs(UnmanagedType.U4)] uint cchBuffer, SafeHandle hTransaction);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.U4)]
	internal static extern uint GetShortPathNameW([MarshalAs(UnmanagedType.LPWStr)] string lpszLongPath, StringBuilder lpszShortPath, [MarshalAs(UnmanagedType.U4)] uint cchBuffer);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool DefineDosDeviceW(DosDeviceAttributes dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpDeviceName, [MarshalAs(UnmanagedType.LPWStr)] string lpTargetPath);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool DeleteVolumeMountPointW([MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeMountPoint);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	internal static extern SafeFindVolumeHandle FindFirstVolumeW(StringBuilder lpszVolumeName, [MarshalAs(UnmanagedType.U4)] uint cchBufferLength);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	internal static extern SafeFindVolumeMountPointHandle FindFirstVolumeMountPointW([MarshalAs(UnmanagedType.LPWStr)] string lpszRootPathName, StringBuilder lpszVolumeMountPoint, [MarshalAs(UnmanagedType.U4)] uint cchBufferLength);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool FindNextVolumeW(SafeFindVolumeHandle hFindVolume, StringBuilder lpszVolumeName, [MarshalAs(UnmanagedType.U4)] uint cchBufferLength);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool FindNextVolumeMountPointW(SafeFindVolumeMountPointHandle hFindVolume, StringBuilder lpszVolumeName, [MarshalAs(UnmanagedType.U4)] uint cchBufferLength);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool FindVolumeClose(IntPtr hFindVolume);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool FindVolumeMountPointClose(IntPtr hFindVolume);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.U4)]
	internal static extern DriveType GetDriveTypeW([MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.U4)]
	internal static extern uint GetLogicalDrives();

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool GetVolumeInformationW([MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, StringBuilder lpVolumeNameBuffer, [MarshalAs(UnmanagedType.U4)] uint nVolumeNameSize, [MarshalAs(UnmanagedType.U4)] out uint lpVolumeSerialNumber, [MarshalAs(UnmanagedType.U4)] out int lpMaximumComponentLength, [MarshalAs(UnmanagedType.U4)] out VOLUME_INFO_FLAGS lpFileSystemAttributes, StringBuilder lpFileSystemNameBuffer, [MarshalAs(UnmanagedType.U4)] uint nFileSystemNameSize);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool GetVolumeInformationByHandleW(SafeFileHandle hFile, StringBuilder lpVolumeNameBuffer, [MarshalAs(UnmanagedType.U4)] uint nVolumeNameSize, [MarshalAs(UnmanagedType.U4)] out uint lpVolumeSerialNumber, [MarshalAs(UnmanagedType.U4)] out int lpMaximumComponentLength, out VOLUME_INFO_FLAGS lpFileSystemAttributes, StringBuilder lpFileSystemNameBuffer, [MarshalAs(UnmanagedType.U4)] uint nFileSystemNameSize);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool GetVolumeNameForVolumeMountPointW([MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeMountPoint, StringBuilder lpszVolumeName, [MarshalAs(UnmanagedType.U4)] uint cchBufferLength);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool GetVolumePathNameW([MarshalAs(UnmanagedType.LPWStr)] string lpszFileName, StringBuilder lpszVolumePathName, [MarshalAs(UnmanagedType.U4)] uint cchBufferLength);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool GetVolumePathNamesForVolumeNameW([MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeName, char[] lpszVolumePathNames, [MarshalAs(UnmanagedType.U4)] uint cchBuferLength, [MarshalAs(UnmanagedType.U4)] out uint lpcchReturnLength);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool SetVolumeLabelW([MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, [MarshalAs(UnmanagedType.LPWStr)] string lpVolumeName);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool SetVolumeMountPointW([MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeMountPoint, [MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeName);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[return: MarshalAs(UnmanagedType.U4)]
	internal static extern uint QueryDosDeviceW([MarshalAs(UnmanagedType.LPWStr)] string lpDeviceName, char[] lpTargetPath, [MarshalAs(UnmanagedType.U4)] uint ucchMax);
}
