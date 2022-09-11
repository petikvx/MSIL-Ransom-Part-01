using System;
using System.IO;

namespace Trinet.Networking;

public class Share
{
	private string string_0;

	private string string_1;

	private string string_2;

	private ShareType shareType_0;

	private string string_3;

	public string Server => string_0;

	public string NetName => string_1;

	public string Path => string_2;

	public ShareType ShareType => shareType_0;

	public string Remark => string_3;

	public bool IsFileSystem
	{
		get
		{
			if ((shareType_0 & ShareType.Device) != 0)
			{
				return false;
			}
			if ((shareType_0 & ShareType.IPC) != 0)
			{
				return false;
			}
			if ((shareType_0 & ShareType.Printer) != 0)
			{
				return false;
			}
			if ((shareType_0 & ShareType.Special) == 0)
			{
				return true;
			}
			if (ShareType.Special == shareType_0 && string_1 != null && string_1.Length != 0)
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
				if (string_0 != null && string_0.Length != 0)
				{
					return new DirectoryInfo(ToString());
				}
				if (string_2 != null && string_2.Length != 0)
				{
					return new DirectoryInfo(string_2);
				}
				return new DirectoryInfo(ToString());
			}
			return null;
		}
	}

	public Share(string server, string netName, string path, ShareType shareType, string remark)
	{
		Class3.QNpOt4wzFfcSE();
		base._002Ector();
		if (ShareType.Special == shareType && "IPC$" == netName)
		{
			shareType |= ShareType.IPC;
		}
		string_0 = server;
		string_1 = netName;
		string_2 = path;
		shareType_0 = shareType;
		string_3 = remark;
	}

	public override string ToString()
	{
		if (string_0 != null && string_0.Length != 0)
		{
			return $"\\\\{string_0}\\{string_1}";
		}
		return $"\\\\{Environment.MachineName}\\{string_1}";
	}

	public bool MatchesPath(string path)
	{
		if (!IsFileSystem)
		{
			return false;
		}
		if (path != null && path.Length != 0)
		{
			return path.ToLower().StartsWith(string_2.ToLower());
		}
		return true;
	}
}
