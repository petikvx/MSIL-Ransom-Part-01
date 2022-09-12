using System;
using System.Globalization;
using Alphaleonis.Win32.Filesystem;

namespace Alphaleonis.Win32.Network;

[Serializable]
public sealed class OpenResourceInfo
{
	[Obsolete("Use HostName")]
	public string Host { get; private set; }

	public string HostName { get; private set; }

	public long Id { get; private set; }

	public string PathName { get; private set; }

	public AccessPermissions Permissions { get; private set; }

	public long TotalLocks { get; private set; }

	public string UserName { get; private set; }

	internal OpenResourceInfo(string hostName, NativeMethods.FILE_INFO_3 fileInfo)
	{
		HostName = hostName;
		Id = fileInfo.fi3_id;
		Permissions = fileInfo.fi3_permissions;
		TotalLocks = fileInfo.fi3_num_locks;
		PathName = fileInfo.fi3_pathname.Replace(Path.UncPrefix, Path.DirectorySeparator);
		UserName = fileInfo.fi3_username;
	}

	public void Close()
	{
		uint num = NativeMethods.NetFileClose(HostName, (uint)Id);
		if (num != 0 && num != 2314)
		{
			NativeError.ThrowException(num, HostName, PathName);
		}
	}

	public override string ToString()
	{
		return Id.ToString(CultureInfo.InvariantCulture);
	}
}
