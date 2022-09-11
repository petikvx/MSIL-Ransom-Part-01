using System;
using System.IO;

namespace winapp;

public class Share
{
	private string _server;

	private string _netName;

	private string _path;

	private ShareType _shareType;

	private string _remark;

	public string Server => _server;

	public string NetName => _netName;

	public string Path => _path;

	public ShareType ShareType => _shareType;

	public string Remark => _remark;

	public bool IsFileSystem
	{
		get
		{
			if ((_shareType & ShareType.Device) != 0)
			{
				return false;
			}
			if ((_shareType & ShareType.IPC) != 0)
			{
				return false;
			}
			if ((_shareType & ShareType.Printer) != 0)
			{
				return false;
			}
			if ((_shareType & ShareType.Special) == 0)
			{
				return true;
			}
			if (ShareType.Special == _shareType && _netName != null && _netName.Length != 0)
			{
				return true;
			}
			return false;
		}
	}

	public DirectoryInfo Root
	{
		get
		{
			if (IsFileSystem)
			{
				if (_server == null || _server.Length == 0)
				{
					if (_path == null || _path.Length == 0)
					{
						return new DirectoryInfo(ToString());
					}
					return new DirectoryInfo(_path);
				}
				return new DirectoryInfo(ToString());
			}
			return null;
		}
	}

	public Share(string server, string netName, string path, ShareType shareType, string remark)
	{
		if (ShareType.Special == shareType && "IPC$" == netName)
		{
			shareType |= ShareType.IPC;
		}
		_server = server;
		_netName = netName;
		_path = path;
		_shareType = shareType;
		_remark = remark;
	}

	public override string ToString()
	{
		if (_server == null || _server.Length == 0)
		{
			return $"\\\\{Environment.MachineName}\\{_netName}";
		}
		return $"\\\\{_server}\\{_netName}";
	}

	public bool MatchesPath(string path)
	{
		if (!IsFileSystem)
		{
			return false;
		}
		if (path == null || path.Length == 0)
		{
			return true;
		}
		return path.ToLower().StartsWith(_path.ToLower());
	}
}
