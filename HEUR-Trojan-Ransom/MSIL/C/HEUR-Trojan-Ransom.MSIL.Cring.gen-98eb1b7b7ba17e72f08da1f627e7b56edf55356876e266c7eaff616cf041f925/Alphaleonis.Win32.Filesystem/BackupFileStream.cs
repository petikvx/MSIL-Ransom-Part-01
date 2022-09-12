using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using Alphaleonis.Win32.Security;
using Microsoft.Win32.SafeHandles;

namespace Alphaleonis.Win32.Filesystem;

public sealed class BackupFileStream : Stream
{
	private readonly bool _canRead;

	private readonly bool _canWrite;

	private readonly bool _processSecurity;

	[SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources")]
	private IntPtr _context = IntPtr.Zero;

	public override long Length
	{
		get
		{
			throw new NotSupportedException(Resources.No_Stream_Seeking_Support);
		}
	}

	public override long Position
	{
		get
		{
			throw new NotSupportedException(Resources.No_Stream_Seeking_Support);
		}
		set
		{
			throw new NotSupportedException(Resources.No_Stream_Seeking_Support);
		}
	}

	public override bool CanRead => _canRead;

	public override bool CanSeek => false;

	public override bool CanWrite => _canWrite;

	private SafeFileHandle SafeFileHandle { get; set; }

	[SecurityCritical]
	[SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
	public BackupFileStream(string path, FileMode mode)
		: this(File.CreateFileCore(null, false, path, ExtendedFileAttributes.Normal, null, mode, FileSystemRights.Write | FileSystemRights.Read, FileShare.None, checkPath: true, continueOnException: false, PathFormat.RelativePath), FileSystemRights.Write | FileSystemRights.Read)
	{
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
	public BackupFileStream(string path, FileMode mode, FileSystemRights access)
		: this(File.CreateFileCore(null, false, path, ExtendedFileAttributes.Normal, null, mode, access, FileShare.None, checkPath: true, continueOnException: false, PathFormat.RelativePath), access)
	{
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
	public BackupFileStream(string path, FileMode mode, FileSystemRights access, FileShare share)
		: this(File.CreateFileCore(null, false, path, ExtendedFileAttributes.Normal, null, mode, access, share, checkPath: true, continueOnException: false, PathFormat.RelativePath), access)
	{
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
	public BackupFileStream(string path, FileMode mode, FileSystemRights access, FileShare share, ExtendedFileAttributes attributes)
		: this(File.CreateFileCore(null, false, path, attributes, null, mode, access, share, checkPath: true, continueOnException: false, PathFormat.RelativePath), access)
	{
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
	public BackupFileStream(string path, FileMode mode, FileSystemRights access, FileShare share, ExtendedFileAttributes attributes, FileSecurity security)
		: this(File.CreateFileCore(null, false, path, attributes, security, mode, access, share, checkPath: true, continueOnException: false, PathFormat.RelativePath), access)
	{
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
	public BackupFileStream(KernelTransaction transaction, string path, FileMode mode)
		: this(File.CreateFileCore(transaction, false, path, ExtendedFileAttributes.Normal, null, mode, FileSystemRights.Write | FileSystemRights.Read, FileShare.None, checkPath: true, continueOnException: false, PathFormat.RelativePath), FileSystemRights.Write | FileSystemRights.Read)
	{
	}

	[SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
	[SecurityCritical]
	public BackupFileStream(KernelTransaction transaction, string path, FileMode mode, FileSystemRights access)
		: this(File.CreateFileCore(transaction, false, path, ExtendedFileAttributes.Normal, null, mode, access, FileShare.None, checkPath: true, continueOnException: false, PathFormat.RelativePath), access)
	{
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
	public BackupFileStream(KernelTransaction transaction, string path, FileMode mode, FileSystemRights access, FileShare share)
		: this(File.CreateFileCore(transaction, false, path, ExtendedFileAttributes.Normal, null, mode, access, share, checkPath: true, continueOnException: false, PathFormat.RelativePath), access)
	{
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
	public BackupFileStream(KernelTransaction transaction, string path, FileMode mode, FileSystemRights access, FileShare share, ExtendedFileAttributes attributes)
		: this(File.CreateFileCore(transaction, false, path, attributes, null, mode, access, share, checkPath: true, continueOnException: false, PathFormat.RelativePath), access)
	{
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
	public BackupFileStream(KernelTransaction transaction, string path, FileMode mode, FileSystemRights access, FileShare share, ExtendedFileAttributes attributes, FileSecurity security)
		: this(File.CreateFileCore(transaction, false, path, attributes, security, mode, access, share, checkPath: true, continueOnException: false, PathFormat.RelativePath), access)
	{
	}

	[SecurityCritical]
	public BackupFileStream(SafeFileHandle handle, FileSystemRights access)
	{
		NativeMethods.IsValidHandle(handle);
		SafeFileHandle = handle;
		_canRead = (access & FileSystemRights.ListDirectory) != 0;
		_canWrite = (access & FileSystemRights.CreateFiles) != 0;
		_processSecurity = true;
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException(Resources.No_Stream_Seeking_Support);
	}

	public override void SetLength(long value)
	{
		throw new NotSupportedException(Resources.No_Stream_Seeking_Support);
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		return Read(buffer, offset, count, processSecurity: false);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands")]
	public int Read(byte[] buffer, int offset, int count, bool processSecurity)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (!CanRead)
		{
			throw new NotSupportedException("Stream does not support reading");
		}
		if (offset + count > buffer.Length)
		{
			throw new ArgumentException("The sum of offset and count is larger than the size of the buffer.", "offset");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", offset, Resources.Negative_Offset);
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", count, Resources.Negative_Count);
		}
		using SafeGlobalMemoryBufferHandle safeGlobalMemoryBufferHandle = new SafeGlobalMemoryBufferHandle(count);
		uint lpNumberOfBytesRead;
		bool num = NativeMethods.BackupRead(SafeFileHandle, safeGlobalMemoryBufferHandle, (uint)safeGlobalMemoryBufferHandle.Capacity, out lpNumberOfBytesRead, bAbort: false, processSecurity, ref _context);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!num)
		{
			NativeError.ThrowException(lastWin32Error);
		}
		safeGlobalMemoryBufferHandle.CopyTo(buffer, offset, count);
		return (int)lpNumberOfBytesRead;
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		Write(buffer, offset, count, processSecurity: false);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands")]
	public void Write(byte[] buffer, int offset, int count, bool processSecurity)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", offset, Resources.Negative_Offset);
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", count, Resources.Negative_Count);
		}
		if (offset + count > buffer.Length)
		{
			throw new ArgumentException(Resources.Buffer_Not_Large_Enough, "offset");
		}
		using SafeGlobalMemoryBufferHandle safeGlobalMemoryBufferHandle = new SafeGlobalMemoryBufferHandle(count);
		safeGlobalMemoryBufferHandle.CopyFrom(buffer, offset, count);
		uint lpNumberOfBytesWritten;
		bool num = NativeMethods.BackupWrite(SafeFileHandle, safeGlobalMemoryBufferHandle, (uint)safeGlobalMemoryBufferHandle.Capacity, out lpNumberOfBytesWritten, bAbort: false, processSecurity, ref _context);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!num)
		{
			NativeError.ThrowException(lastWin32Error);
		}
	}

	public override void Flush()
	{
		bool num = NativeMethods.FlushFileBuffers(SafeFileHandle);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!num)
		{
			NativeError.ThrowException(lastWin32Error);
		}
	}

	[SecurityCritical]
	public long Skip(long bytes)
	{
		uint lpdwLowBytesSeeked;
		uint lpdwHighBytesSeeked;
		bool num = NativeMethods.BackupSeek(SafeFileHandle, NativeMethods.GetLowOrderDword(bytes), NativeMethods.GetHighOrderDword(bytes), out lpdwLowBytesSeeked, out lpdwHighBytesSeeked, ref _context);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!num && lastWin32Error != 25L)
		{
			NativeError.ThrowException(lastWin32Error);
		}
		return NativeMethods.ToLong(lpdwHighBytesSeeked, lpdwLowBytesSeeked);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
	public FileSecurity GetAccessControl()
	{
		IntPtr pSidOwner;
		IntPtr pSidGroup;
		IntPtr pDacl;
		IntPtr pSacl;
		SafeGlobalMemoryBufferHandle pSecurityDescriptor;
		int securityInfo = (int)Alphaleonis.Win32.Security.NativeMethods.GetSecurityInfo(SafeFileHandle, SE_OBJECT_TYPE.SE_FILE_OBJECT, SECURITY_INFORMATION.OWNER_SECURITY_INFORMATION | SECURITY_INFORMATION.GROUP_SECURITY_INFORMATION | SECURITY_INFORMATION.DACL_SECURITY_INFORMATION | SECURITY_INFORMATION.SACL_SECURITY_INFORMATION | SECURITY_INFORMATION.LABEL_SECURITY_INFORMATION, out pSidOwner, out pSidGroup, out pDacl, out pSacl, out pSecurityDescriptor);
		try
		{
			if (securityInfo != 0L)
			{
				NativeError.ThrowException(securityInfo);
			}
			if (pSecurityDescriptor != null && pSecurityDescriptor.IsInvalid)
			{
				pSecurityDescriptor.Close();
				pSecurityDescriptor = null;
				throw new IOException(new Win32Exception(1338).Message);
			}
			uint securityDescriptorLength = Alphaleonis.Win32.Security.NativeMethods.GetSecurityDescriptorLength(pSecurityDescriptor);
			byte[] array = new byte[securityDescriptorLength];
			pSecurityDescriptor?.CopyTo(array, 0, (int)securityDescriptorLength);
			FileSecurity fileSecurity = new FileSecurity();
			fileSecurity.SetSecurityDescriptorBinaryForm(array);
			return fileSecurity;
		}
		finally
		{
			pSecurityDescriptor?.Close();
		}
	}

	[SecurityCritical]
	public void SetAccessControl(ObjectSecurity fileSecurity)
	{
		File.SetAccessControlCore(null, SafeFileHandle, fileSecurity, AccessControlSections.All, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public void Lock(long position, long length)
	{
		if (position < 0L)
		{
			throw new ArgumentOutOfRangeException("position", position, new Win32Exception(131).Message);
		}
		if (length < 0L)
		{
			throw new ArgumentOutOfRangeException("length", length, Resources.Negative_Lock_Length);
		}
		bool num = NativeMethods.LockFile(SafeFileHandle, NativeMethods.GetLowOrderDword(position), NativeMethods.GetHighOrderDword(position), NativeMethods.GetLowOrderDword(length), NativeMethods.GetHighOrderDword(length));
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!num)
		{
			NativeError.ThrowException(lastWin32Error);
		}
	}

	[SecurityCritical]
	public void Unlock(long position, long length)
	{
		if (position < 0L)
		{
			throw new ArgumentOutOfRangeException("position", position, new Win32Exception(131).Message);
		}
		if (length < 0L)
		{
			throw new ArgumentOutOfRangeException("length", length, Resources.Negative_Lock_Length);
		}
		bool num = NativeMethods.UnlockFile(SafeFileHandle, NativeMethods.GetLowOrderDword(position), NativeMethods.GetHighOrderDword(position), NativeMethods.GetLowOrderDword(length), NativeMethods.GetHighOrderDword(length));
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!num)
		{
			NativeError.ThrowException(lastWin32Error);
		}
	}

	[SecurityCritical]
	public BackupStreamInfo ReadStreamInfo()
	{
		int num = Marshal.SizeOf(typeof(NativeMethods.WIN32_STREAM_ID));
		using SafeGlobalMemoryBufferHandle safeGlobalMemoryBufferHandle = new SafeGlobalMemoryBufferHandle(num);
		uint lpNumberOfBytesRead;
		bool num2 = NativeMethods.BackupRead(SafeFileHandle, safeGlobalMemoryBufferHandle, (uint)num, out lpNumberOfBytesRead, bAbort: false, _processSecurity, ref _context);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!num2)
		{
			NativeError.ThrowException(lastWin32Error);
		}
		if (lpNumberOfBytesRead == 0)
		{
			return null;
		}
		if (lpNumberOfBytesRead < num)
		{
			throw new IOException(Resources.Read_Incomplete_Header);
		}
		NativeMethods.WIN32_STREAM_ID streamID = safeGlobalMemoryBufferHandle.PtrToStructure<NativeMethods.WIN32_STREAM_ID>(0);
		uint num3 = (uint)Math.Min(streamID.dwStreamNameSize, safeGlobalMemoryBufferHandle.Capacity);
		bool num4 = NativeMethods.BackupRead(SafeFileHandle, safeGlobalMemoryBufferHandle, num3, out lpNumberOfBytesRead, bAbort: false, _processSecurity, ref _context);
		lastWin32Error = Marshal.GetLastWin32Error();
		if (!num4)
		{
			NativeError.ThrowException(lastWin32Error);
		}
		return new BackupStreamInfo(name: safeGlobalMemoryBufferHandle.PtrToStringUni(0, (int)num3 / 2), streamID: streamID);
	}

	~BackupFileStream()
	{
		Dispose(disposing: false);
	}

	[SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
	protected override void Dispose(bool disposing)
	{
		if (disposing && SafeFileHandle != null && !SafeFileHandle.IsInvalid && _context != IntPtr.Zero)
		{
			try
			{
				uint lpNumberOfBytesRead;
				bool num = NativeMethods.BackupRead(SafeFileHandle, new SafeGlobalMemoryBufferHandle(), 0u, out lpNumberOfBytesRead, bAbort: true, bProcessSecurity: false, ref _context);
				int lastWin32Error = Marshal.GetLastWin32Error();
				if (!num)
				{
					NativeError.ThrowException(lastWin32Error);
				}
			}
			finally
			{
				_context = IntPtr.Zero;
				SafeFileHandle.Close();
			}
		}
		base.Dispose(disposing);
	}
}
