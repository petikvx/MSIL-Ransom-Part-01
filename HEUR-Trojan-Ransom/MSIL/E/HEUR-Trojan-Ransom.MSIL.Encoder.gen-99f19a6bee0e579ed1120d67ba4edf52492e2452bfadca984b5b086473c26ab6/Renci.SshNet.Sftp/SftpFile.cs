using System;
using System.Globalization;
using Renci.SshNet.Common;

namespace Renci.SshNet.Sftp;

public class SftpFile
{
	private readonly ISftpSession _sftpSession;

	public SftpFileAttributes Attributes { get; private set; }

	public string FullName { get; private set; }

	public string Name { get; private set; }

	public DateTime LastAccessTime
	{
		get
		{
			return Attributes.LastAccessTime;
		}
		set
		{
			Attributes.LastAccessTime = value;
		}
	}

	public DateTime LastWriteTime
	{
		get
		{
			return Attributes.LastWriteTime;
		}
		set
		{
			Attributes.LastWriteTime = value;
		}
	}

	public DateTime LastAccessTimeUtc
	{
		get
		{
			return Attributes.LastAccessTime.ToUniversalTime();
		}
		set
		{
			Attributes.LastAccessTime = value.ToLocalTime();
		}
	}

	public DateTime LastWriteTimeUtc
	{
		get
		{
			return Attributes.LastWriteTime.ToUniversalTime();
		}
		set
		{
			Attributes.LastWriteTime = value.ToLocalTime();
		}
	}

	public long Length => Attributes.Size;

	public int UserId
	{
		get
		{
			return Attributes.UserId;
		}
		set
		{
			Attributes.UserId = value;
		}
	}

	public int GroupId
	{
		get
		{
			return Attributes.GroupId;
		}
		set
		{
			Attributes.GroupId = value;
		}
	}

	public bool IsSocket => Attributes.IsSocket;

	public bool IsSymbolicLink => Attributes.IsSymbolicLink;

	public bool IsRegularFile => Attributes.IsRegularFile;

	public bool IsBlockDevice => Attributes.IsBlockDevice;

	public bool IsDirectory => Attributes.IsDirectory;

	public bool IsCharacterDevice => Attributes.IsCharacterDevice;

	public bool IsNamedPipe => Attributes.IsNamedPipe;

	public bool OwnerCanRead
	{
		get
		{
			return Attributes.OwnerCanRead;
		}
		set
		{
			Attributes.OwnerCanRead = value;
		}
	}

	public bool OwnerCanWrite
	{
		get
		{
			return Attributes.OwnerCanWrite;
		}
		set
		{
			Attributes.OwnerCanWrite = value;
		}
	}

	public bool OwnerCanExecute
	{
		get
		{
			return Attributes.OwnerCanExecute;
		}
		set
		{
			Attributes.OwnerCanExecute = value;
		}
	}

	public bool GroupCanRead
	{
		get
		{
			return Attributes.GroupCanRead;
		}
		set
		{
			Attributes.GroupCanRead = value;
		}
	}

	public bool GroupCanWrite
	{
		get
		{
			return Attributes.GroupCanWrite;
		}
		set
		{
			Attributes.GroupCanWrite = value;
		}
	}

	public bool GroupCanExecute
	{
		get
		{
			return Attributes.GroupCanExecute;
		}
		set
		{
			Attributes.GroupCanExecute = value;
		}
	}

	public bool OthersCanRead
	{
		get
		{
			return Attributes.OthersCanRead;
		}
		set
		{
			Attributes.OthersCanRead = value;
		}
	}

	public bool OthersCanWrite
	{
		get
		{
			return Attributes.OthersCanWrite;
		}
		set
		{
			Attributes.OthersCanWrite = value;
		}
	}

	public bool OthersCanExecute
	{
		get
		{
			return Attributes.OthersCanExecute;
		}
		set
		{
			Attributes.OthersCanExecute = value;
		}
	}

	internal SftpFile(ISftpSession sftpSession, string fullName, SftpFileAttributes attributes)
	{
		if (sftpSession == null)
		{
			throw new SshConnectionException("Client not connected.");
		}
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		if (fullName == null)
		{
			throw new ArgumentNullException("fullName");
		}
		_sftpSession = sftpSession;
		Attributes = attributes;
		Name = fullName.Substring(fullName.LastIndexOf('/') + 1);
		FullName = fullName;
	}

	public void SetPermissions(short mode)
	{
		Attributes.SetPermissions(mode);
		UpdateStatus();
	}

	public void Delete()
	{
		if (IsDirectory)
		{
			_sftpSession.RequestRmDir(FullName);
		}
		else
		{
			_sftpSession.RequestRemove(FullName);
		}
	}

	public void MoveTo(string destFileName)
	{
		if (destFileName == null)
		{
			throw new ArgumentNullException("destFileName");
		}
		_sftpSession.RequestRename(FullName, destFileName);
		string canonicalPath = _sftpSession.GetCanonicalPath(destFileName);
		Name = canonicalPath.Substring(canonicalPath.LastIndexOf('/') + 1);
		FullName = canonicalPath;
	}

	public void UpdateStatus()
	{
		_sftpSession.RequestSetStat(FullName, Attributes);
	}

	public override string ToString()
	{
		return string.Format(CultureInfo.CurrentCulture, "Name {0}, Length {1}, User ID {2}, Group ID {3}, Accessed {4}, Modified {5}", Name, Length, UserId, GroupId, LastAccessTime, LastWriteTime);
	}
}
