using System;
using System.IO;

namespace Sony.Vegas.NetRender;

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
			if (0 != (_shareType & ShareType.Device))
			{
				return false;
			}
			if (0 != (_shareType & ShareType.IPC))
			{
				return false;
			}
			if (0 != (_shareType & ShareType.Printer))
			{
				return false;
			}
			if (0 == (_shareType & ShareType.Special))
			{
				return true;
			}
			if (ShareType.Special == _shareType && _netName != null && 0 != _netName.Length)
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
				if (_server == null || 0 == _server.Length)
				{
					if (_path == null || 0 == _path.Length)
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
		if (_server == null || 0 == _server.Length)
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
		if (path == null || 0 == path.Length)
		{
			return true;
		}
		return path.ToLower().StartsWith(_path.ToLower());
	}
}
