using System;
using System.Globalization;
using Alphaleonis.Win32.Filesystem;

namespace Alphaleonis.Win32.Network;

[Serializable]
public sealed class ShareInfo
{
	private DirectoryInfo _directoryInfo;

	private ShareResourceTypes _shareResourceType;

	public long CurrentUses { get; private set; }

	public DirectoryInfo DirectoryInfo => _directoryInfo ?? (_directoryInfo = new DirectoryInfo(null, NetFullPath, PathFormat.FullPath));

	public string NetFullPath { get; internal set; }

	public long MaxUses { get; private set; }

	public string NetName { get; private set; }

	public string Password { get; private set; }

	public string Path { get; private set; }

	public AccessPermissions Permissions { get; private set; }

	public string Remark { get; private set; }

	public IntPtr SecurityDescriptor { get; private set; }

	public string ServerName { get; private set; }

	public ShareType ShareType { get; private set; }

	public ShareResourceTypes ResourceType
	{
		get
		{
			if (_shareResourceType == ShareResourceTypes.None && !Utils.IsNullOrWhiteSpace(NetName))
			{
				_shareResourceType = Host.GetShareInfoCore(ShareInfoLevel.Info1005, ServerName, NetName, continueOnException: true).ResourceType;
			}
			return _shareResourceType;
		}
		private set
		{
			_shareResourceType = value;
		}
	}

	public ShareInfoLevel ShareLevel { get; private set; }

	internal ShareInfo(string host, ShareInfoLevel shareLevel, object shareInfo)
	{
		host = host ?? Environment.MachineName;
		switch (shareLevel)
		{
		case ShareInfoLevel.Info2:
		{
			NativeMethods.SHARE_INFO_2 sHARE_INFO_4 = (NativeMethods.SHARE_INFO_2)shareInfo;
			CurrentUses = sHARE_INFO_4.shi2_current_uses;
			MaxUses = sHARE_INFO_4.shi2_max_uses;
			NetName = sHARE_INFO_4.shi2_netname;
			Password = sHARE_INFO_4.shi2_passwd;
			Path = (Utils.IsNullOrWhiteSpace(sHARE_INFO_4.shi2_path) ? null : sHARE_INFO_4.shi2_path);
			Permissions = sHARE_INFO_4.shi2_permissions;
			Remark = sHARE_INFO_4.shi2_remark;
			ServerName = host;
			ShareType = sHARE_INFO_4.shi2_type;
			break;
		}
		case ShareInfoLevel.Info1:
		{
			NativeMethods.SHARE_INFO_1 sHARE_INFO_3 = (NativeMethods.SHARE_INFO_1)shareInfo;
			CurrentUses = 0L;
			MaxUses = 0L;
			NetName = sHARE_INFO_3.shi1_netname;
			Password = null;
			Path = null;
			Permissions = AccessPermissions.None;
			Remark = sHARE_INFO_3.shi1_remark;
			ServerName = host;
			ShareType = sHARE_INFO_3.shi1_type;
			break;
		}
		case ShareInfoLevel.Info1005:
		{
			NativeMethods.SHARE_INFO_1005 sHARE_INFO_2 = (NativeMethods.SHARE_INFO_1005)shareInfo;
			ServerName = host;
			ResourceType = sHARE_INFO_2.shi1005_flags;
			break;
		}
		case ShareInfoLevel.Info503:
		{
			NativeMethods.SHARE_INFO_503 sHARE_INFO_5 = (NativeMethods.SHARE_INFO_503)shareInfo;
			CurrentUses = sHARE_INFO_5.shi503_current_uses;
			MaxUses = sHARE_INFO_5.shi503_max_uses;
			NetName = sHARE_INFO_5.shi503_netname;
			Password = sHARE_INFO_5.shi503_passwd;
			Path = (Utils.IsNullOrWhiteSpace(sHARE_INFO_5.shi503_path) ? null : sHARE_INFO_5.shi503_path);
			Permissions = sHARE_INFO_5.shi503_permissions;
			Remark = sHARE_INFO_5.shi503_remark;
			ServerName = ((sHARE_INFO_5.shi503_servername == "*") ? host : sHARE_INFO_5.shi503_servername);
			ShareType = sHARE_INFO_5.shi503_type;
			SecurityDescriptor = sHARE_INFO_5.shi503_security_descriptor;
			break;
		}
		case ShareInfoLevel.Info502:
		{
			NativeMethods.SHARE_INFO_502 sHARE_INFO_ = (NativeMethods.SHARE_INFO_502)shareInfo;
			CurrentUses = sHARE_INFO_.shi502_current_uses;
			MaxUses = sHARE_INFO_.shi502_max_uses;
			NetName = sHARE_INFO_.shi502_netname;
			Password = sHARE_INFO_.shi502_passwd;
			Path = (Utils.IsNullOrWhiteSpace(sHARE_INFO_.shi502_path) ? null : sHARE_INFO_.shi502_path);
			Permissions = sHARE_INFO_.shi502_permissions;
			Remark = sHARE_INFO_.shi502_remark;
			ServerName = host;
			ShareType = sHARE_INFO_.shi502_type;
			SecurityDescriptor = sHARE_INFO_.shi502_security_descriptor;
			break;
		}
		}
		NetFullPath = string.Format(CultureInfo.InvariantCulture, "{0}{1}{2}{3}", Alphaleonis.Win32.Filesystem.Path.UncPrefix, ServerName, Alphaleonis.Win32.Filesystem.Path.DirectorySeparatorChar, NetName);
		ShareLevel = shareLevel;
	}

	public override string ToString()
	{
		return NetFullPath;
	}
}
