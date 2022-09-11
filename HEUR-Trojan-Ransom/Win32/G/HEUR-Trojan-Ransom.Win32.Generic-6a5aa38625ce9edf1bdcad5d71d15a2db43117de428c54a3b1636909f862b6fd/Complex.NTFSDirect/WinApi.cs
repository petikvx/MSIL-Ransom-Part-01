using System;
using System.Runtime.InteropServices;

namespace Complex.NTFSDirect;

public class WinApi
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct BY_HANDLE_FILE_INFORMATION
	{
		public uint FileAttributes;

		public FILETIME CreationTime;

		public FILETIME LastAccessTime;

		public FILETIME LastWriteTime;

		public uint VolumeSerialNumber;

		public uint FileSizeHigh;

		public uint FileSizeLow;

		public uint NumberOfLinks;

		public uint FileIndexHigh;

		public uint FileIndexLow;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct FILETIME
	{
		public uint DateTimeLow;

		public uint DateTimeHigh;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct USN_JOURNAL_DATA
	{
		public ulong UsnJournalID;

		public long FirstUsn;

		public long NextUsn;

		public long LowestValidUsn;

		public long MaxUsn;

		public ulong MaximumSize;

		public ulong AllocationDelta;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct MFT_ENUM_DATA
	{
		public ulong StartFileReferenceNumber;

		public long LowUsn;

		public long HighUsn;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct CREATE_USN_JOURNAL_DATA
	{
		public ulong MaximumSize;

		public ulong AllocationDelta;
	}

	public class USN_RECORD
	{
		private const int FR_OFFSET = 8;

		private const int PFR_OFFSET = 16;

		private const int FA_OFFSET = 52;

		private const int FNL_OFFSET = 56;

		private const int FN_OFFSET = 58;

		public uint FileAttributes;

		public string FileName = string.Empty;

		public int FileNameLength;

		public int FileNameOffset;

		public ulong FileReferenceNumber;

		public ulong ParentFileReferenceNumber;

		public uint RecordLength;

		public USN_RECORD(IntPtr p)
		{
			RecordLength = (uint)Marshal.ReadInt32(p);
			FileReferenceNumber = (ulong)Marshal.ReadInt64(p, 8);
			ParentFileReferenceNumber = (ulong)Marshal.ReadInt64(p, 16);
			FileAttributes = (uint)Marshal.ReadInt32(p, 52);
			FileNameLength = Marshal.ReadInt16(p, 56);
			FileNameOffset = Marshal.ReadInt16(p, 58);
			FileName = Marshal.PtrToStringUni(new IntPtr(p.ToInt32() + FileNameOffset), FileNameLength / 2);
		}
	}

	public const uint GENERIC_READ = 2147483648u;

	public const uint GENERIC_WRITE = 1073741824u;

	public const uint FILE_SHARE_READ = 1u;

	public const uint FILE_SHARE_WRITE = 2u;

	public const uint FILE_ATTRIBUTE_DIRECTORY = 16u;

	public const uint OPEN_EXISTING = 3u;

	public const uint FILE_FLAG_BACKUP_SEMANTICS = 33554432u;

	public const int INVALID_HANDLE_VALUE = -1;

	public const uint FSCTL_QUERY_USN_JOURNAL = 590068u;

	public const uint FSCTL_ENUM_USN_DATA = 590003u;

	public const uint FSCTL_CREATE_USN_JOURNAL = 590055u;

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr CreateFile(string lpFileName, uint dwDesiredAccess, uint dwShareMode, IntPtr lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetFileInformationByHandle(IntPtr hFile, out BY_HANDLE_FILE_INFORMATION lpFileInformation);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(IntPtr hObject);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl(IntPtr hDevice, uint dwIoControlCode, IntPtr lpInBuffer, int nInBufferSize, out USN_JOURNAL_DATA lpOutBuffer, int nOutBufferSize, out uint lpBytesReturned, IntPtr lpOverlapped);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl(IntPtr hDevice, uint dwIoControlCode, IntPtr lpInBuffer, int nInBufferSize, IntPtr lpOutBuffer, int nOutBufferSize, out uint lpBytesReturned, IntPtr lpOverlapped);

	[DllImport("kernel32.dll")]
	public static extern void ZeroMemory(IntPtr ptr, int size);
}
