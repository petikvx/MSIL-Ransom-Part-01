using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Renci.SshNet.Common;

namespace Renci.SshNet.Sftp;

public class SftpFileAttributes
{
	private const uint S_IFMT = 61440u;

	private const uint S_IFSOCK = 49152u;

	private const uint S_IFLNK = 40960u;

	private const uint S_IFREG = 32768u;

	private const uint S_IFBLK = 24576u;

	private const uint S_IFDIR = 16384u;

	private const uint S_IFCHR = 8192u;

	private const uint S_IFIFO = 4096u;

	private const uint S_ISUID = 2048u;

	private const uint S_ISGID = 1024u;

	private const uint S_ISVTX = 512u;

	private const uint S_IRUSR = 256u;

	private const uint S_IWUSR = 128u;

	private const uint S_IXUSR = 64u;

	private const uint S_IRGRP = 32u;

	private const uint S_IWGRP = 16u;

	private const uint S_IXGRP = 8u;

	private const uint S_IROTH = 4u;

	private const uint S_IWOTH = 2u;

	private const uint S_IXOTH = 1u;

	private bool _isBitFiledsBitSet;

	private bool _isUIDBitSet;

	private bool _isGroupIDBitSet;

	private bool _isStickyBitSet;

	private readonly DateTime _originalLastAccessTime;

	private readonly DateTime _originalLastWriteTime;

	private readonly long _originalSize;

	private readonly int _originalUserId;

	private readonly int _originalGroupId;

	private readonly uint _originalPermissions;

	private readonly IDictionary<string, string> _originalExtensions;

	internal static readonly SftpFileAttributes Empty = new SftpFileAttributes();

	internal bool IsLastAccessTimeChanged => _originalLastAccessTime != LastAccessTime;

	internal bool IsLastWriteTimeChanged => _originalLastWriteTime != LastWriteTime;

	internal bool IsSizeChanged => _originalSize != Size;

	internal bool IsUserIdChanged => _originalUserId != UserId;

	internal bool IsGroupIdChanged => _originalGroupId != GroupId;

	internal bool IsPermissionsChanged => _originalPermissions != Permissions;

	internal bool IsExtensionsChanged
	{
		get
		{
			if (_originalExtensions != null && Extensions != null)
			{
				return !_originalExtensions.SequenceEqual(Extensions);
			}
			return false;
		}
	}

	public DateTime LastAccessTime { get; set; }

	public DateTime LastWriteTime { get; set; }

	public long Size { get; set; }

	public int UserId { get; set; }

	public int GroupId { get; set; }

	public bool IsSocket { get; private set; }

	public bool IsSymbolicLink { get; private set; }

	public bool IsRegularFile { get; private set; }

	public bool IsBlockDevice { get; private set; }

	public bool IsDirectory { get; private set; }

	public bool IsCharacterDevice { get; private set; }

	public bool IsNamedPipe { get; private set; }

	public bool OwnerCanRead { get; set; }

	public bool OwnerCanWrite { get; set; }

	public bool OwnerCanExecute { get; set; }

	public bool GroupCanRead { get; set; }

	public bool GroupCanWrite { get; set; }

	public bool GroupCanExecute { get; set; }

	public bool OthersCanRead { get; set; }

	public bool OthersCanWrite { get; set; }

	public bool OthersCanExecute { get; set; }

	public IDictionary<string, string> Extensions { get; private set; }

	internal uint Permissions
	{
		get
		{
			uint num = 0u;
			if (_isBitFiledsBitSet)
			{
				num |= 0xF000u;
			}
			if (IsSocket)
			{
				num |= 0xC000u;
			}
			if (IsSymbolicLink)
			{
				num |= 0xA000u;
			}
			if (IsRegularFile)
			{
				num |= 0x8000u;
			}
			if (IsBlockDevice)
			{
				num |= 0x6000u;
			}
			if (IsDirectory)
			{
				num |= 0x4000u;
			}
			if (IsCharacterDevice)
			{
				num |= 0x2000u;
			}
			if (IsNamedPipe)
			{
				num |= 0x1000u;
			}
			if (_isUIDBitSet)
			{
				num |= 0x800u;
			}
			if (_isGroupIDBitSet)
			{
				num |= 0x400u;
			}
			if (_isStickyBitSet)
			{
				num |= 0x200u;
			}
			if (OwnerCanRead)
			{
				num |= 0x100u;
			}
			if (OwnerCanWrite)
			{
				num |= 0x80u;
			}
			if (OwnerCanExecute)
			{
				num |= 0x40u;
			}
			if (GroupCanRead)
			{
				num |= 0x20u;
			}
			if (GroupCanWrite)
			{
				num |= 0x10u;
			}
			if (GroupCanExecute)
			{
				num |= 8u;
			}
			if (OthersCanRead)
			{
				num |= 4u;
			}
			if (OthersCanWrite)
			{
				num |= 2u;
			}
			if (OthersCanExecute)
			{
				num |= 1u;
			}
			return num;
		}
		private set
		{
			_isBitFiledsBitSet = (value & 0xF000) == 61440;
			IsSocket = (value & 0xC000) == 49152;
			IsSymbolicLink = (value & 0xA000) == 40960;
			IsRegularFile = (value & 0x8000) == 32768;
			IsBlockDevice = (value & 0x6000) == 24576;
			IsDirectory = (value & 0x4000) == 16384;
			IsCharacterDevice = (value & 0x2000) == 8192;
			IsNamedPipe = (value & 0x1000) == 4096;
			_isUIDBitSet = (value & 0x800) == 2048;
			_isGroupIDBitSet = (value & 0x400) == 1024;
			_isStickyBitSet = (value & 0x200) == 512;
			OwnerCanRead = (value & 0x100) == 256;
			OwnerCanWrite = (value & 0x80) == 128;
			OwnerCanExecute = (value & 0x40) == 64;
			GroupCanRead = (value & 0x20) == 32;
			GroupCanWrite = (value & 0x10) == 16;
			GroupCanExecute = (value & 8) == 8;
			OthersCanRead = (value & 4) == 4;
			OthersCanWrite = (value & 2) == 2;
			OthersCanExecute = (value & 1) == 1;
		}
	}

	private SftpFileAttributes()
	{
	}

	internal SftpFileAttributes(DateTime lastAccessTime, DateTime lastWriteTime, long size, int userId, int groupId, uint permissions, IDictionary<string, string> extensions)
	{
		LastAccessTime = (_originalLastAccessTime = lastAccessTime);
		LastWriteTime = (_originalLastWriteTime = lastWriteTime);
		Size = (_originalSize = size);
		UserId = (_originalUserId = userId);
		GroupId = (_originalGroupId = groupId);
		Permissions = (_originalPermissions = permissions);
		Extensions = (_originalExtensions = extensions);
	}

	public void SetPermissions(short mode)
	{
		if (mode < 0 || mode > 999)
		{
			throw new ArgumentOutOfRangeException("mode");
		}
		char[] array = mode.ToString(CultureInfo.InvariantCulture).PadLeft(3, '0').ToCharArray();
		int num = (array[0] & 0xF) * 8 * 8 + (array[1] & 0xF) * 8 + (array[2] & 0xF);
		OwnerCanRead = (num & 0x100L) == 256L;
		OwnerCanWrite = (num & 0x80L) == 128L;
		OwnerCanExecute = (num & 0x40L) == 64L;
		GroupCanRead = (num & 0x20L) == 32L;
		GroupCanWrite = (num & 0x10L) == 16L;
		GroupCanExecute = (num & 8L) == 8L;
		OthersCanRead = (num & 4L) == 4L;
		OthersCanWrite = (num & 2L) == 2L;
		OthersCanExecute = (num & 1L) == 1L;
	}

	public byte[] GetBytes()
	{
		SshDataStream sshDataStream = new SshDataStream(4);
		uint num = 0u;
		if (IsSizeChanged && IsRegularFile)
		{
			num |= 1u;
		}
		if (IsUserIdChanged || IsGroupIdChanged)
		{
			num |= 2u;
		}
		if (IsPermissionsChanged)
		{
			num |= 4u;
		}
		if (IsLastAccessTimeChanged || IsLastWriteTimeChanged)
		{
			num |= 8u;
		}
		if (IsExtensionsChanged)
		{
			num |= 0x80000000u;
		}
		sshDataStream.Write(num);
		if (IsSizeChanged && IsRegularFile)
		{
			sshDataStream.Write((ulong)Size);
		}
		if (IsUserIdChanged || IsGroupIdChanged)
		{
			sshDataStream.Write((uint)UserId);
			sshDataStream.Write((uint)GroupId);
		}
		if (IsPermissionsChanged)
		{
			sshDataStream.Write(Permissions);
		}
		if (IsLastAccessTimeChanged || IsLastWriteTimeChanged)
		{
			uint value = (uint)(LastAccessTime.ToFileTime() / 10000000L - 11644473600L);
			sshDataStream.Write(value);
			value = (uint)(LastWriteTime.ToFileTime() / 10000000L - 11644473600L);
			sshDataStream.Write(value);
		}
		if (IsExtensionsChanged)
		{
			foreach (KeyValuePair<string, string> extension in Extensions)
			{
				sshDataStream.Write(extension.Key, SshData.Ascii);
				sshDataStream.Write(extension.Value, SshData.Ascii);
			}
		}
		return sshDataStream.ToArray();
	}

	internal static SftpFileAttributes FromBytes(SshDataStream stream)
	{
		uint num = stream.ReadUInt32();
		long size = -1L;
		int userId = -1;
		int groupId = -1;
		uint permissions = 0u;
		DateTime lastAccessTime = DateTime.MinValue;
		DateTime lastWriteTime = DateTime.MinValue;
		IDictionary<string, string> dictionary = null;
		if ((num & 1) == 1)
		{
			size = (long)stream.ReadUInt64();
		}
		if ((num & 2) == 2)
		{
			userId = (int)stream.ReadUInt32();
			groupId = (int)stream.ReadUInt32();
		}
		if ((num & 4) == 4)
		{
			permissions = stream.ReadUInt32();
		}
		if ((num & 8) == 8)
		{
			lastAccessTime = DateTime.FromFileTime(((long)stream.ReadUInt32() + 11644473600L) * 10000000L);
			lastWriteTime = DateTime.FromFileTime(((long)stream.ReadUInt32() + 11644473600L) * 10000000L);
		}
		if ((num & 0x80000000u) == 2147483648u)
		{
			int num2 = (int)stream.ReadUInt32();
			dictionary = new Dictionary<string, string>(num2);
			for (int i = 0; i < num2; i++)
			{
				string key = stream.ReadString(SshData.Utf8);
				string value = stream.ReadString(SshData.Utf8);
				dictionary.Add(key, value);
			}
		}
		return new SftpFileAttributes(lastAccessTime, lastWriteTime, size, userId, groupId, permissions, dictionary);
	}

	internal static SftpFileAttributes FromBytes(byte[] buffer)
	{
		using SshDataStream stream = new SshDataStream(buffer);
		return FromBytes(stream);
	}
}
