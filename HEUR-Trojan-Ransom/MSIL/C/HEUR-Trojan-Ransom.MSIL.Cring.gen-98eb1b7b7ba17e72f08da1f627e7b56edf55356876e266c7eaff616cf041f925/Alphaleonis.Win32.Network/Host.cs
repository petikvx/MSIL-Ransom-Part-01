using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using Alphaleonis.Win32.Filesystem;

namespace Alphaleonis.Win32.Network;

public static class Host
{
	internal delegate uint EnumerateNetworkObjectDelegate(FunctionData functionData, out SafeGlobalMemoryBufferHandle netApiBuffer, [MarshalAs(UnmanagedType.I4)] int prefMaxLen, [MarshalAs(UnmanagedType.U4)] out uint entriesRead, [MarshalAs(UnmanagedType.U4)] out uint totalEntries, [MarshalAs(UnmanagedType.U4)] out uint resumeHandle);

	internal struct FunctionData
	{
		public int EnumType;

		public string ExtraData1;

		public string ExtraData2;
	}

	internal struct ConnectDisconnectArguments
	{
		public IntPtr WinOwner;

		public string LocalName;

		public string RemoteName;

		public NetworkCredential Credential;

		public string UserName;

		public string Password;

		public bool Prompt;

		public bool UpdateProfile;

		public bool SaveCredentials;

		public bool IsDeviceMap;

		public bool IsDisconnect;
	}

	private static readonly NetworkListManager Manager = new NetworkListManager();

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "ID")]
	public static NetworkConnectionInfo GetNetworkConnection(Guid networkConnectionID)
	{
		IEnumerable<NetworkConnectionInfo> enumerable = EnumerateNetworkConnectionsCore(networkConnectionID);
		if (enumerable == null)
		{
			return null;
		}
		return enumerable.ToArray()[0];
	}

	[SecurityCritical]
	public static IEnumerable<NetworkConnectionInfo> EnumerateNetworkConnections()
	{
		return EnumerateNetworkConnectionsCore(null);
	}

	[SecurityCritical]
	internal static IEnumerable<NetworkConnectionInfo> EnumerateNetworkConnectionsCore(Guid? networkConnectionID)
	{
		if (networkConnectionID.HasValue)
		{
			yield return new NetworkConnectionInfo(Manager.GetNetworkConnection(networkConnectionID.Value));
			yield break;
		}
		foreach (INetworkConnection networkConnection in Manager.GetNetworkConnections())
		{
			yield return new NetworkConnectionInfo(networkConnection);
		}
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "ID")]
	public static NetworkInfo GetNetwork(Guid networkID)
	{
		IEnumerable<NetworkInfo> enumerable = EnumerateNetworksCore(networkID, NetworkConnectivityLevels.None);
		if (enumerable == null)
		{
			return null;
		}
		return enumerable.ToArray()[0];
	}

	[SecurityCritical]
	public static IEnumerable<NetworkInfo> EnumerateNetworks()
	{
		return EnumerateNetworksCore(null, NetworkConnectivityLevels.All);
	}

	[SecurityCritical]
	public static IEnumerable<NetworkInfo> EnumerateNetworks(NetworkConnectivityLevels networkConnectivityLevels)
	{
		return EnumerateNetworksCore(null, networkConnectivityLevels);
	}

	[SecurityCritical]
	internal static IEnumerable<NetworkInfo> EnumerateNetworksCore(Guid? networkID, NetworkConnectivityLevels networkConnectivityLevels)
	{
		if (networkID.HasValue)
		{
			yield return new NetworkInfo(Manager.GetNetwork(networkID.Value));
			yield break;
		}
		foreach (INetwork network in Manager.GetNetworks(networkConnectivityLevels))
		{
			yield return new NetworkInfo(network);
		}
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dfs")]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "dfs")]
	public static DfsInfo GetDfsClientInfo(string dfsName)
	{
		return GetDfsInfoCore(getFromClient: true, dfsName, null, null);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "dfs")]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dfs")]
	public static DfsInfo GetDfsClientInfo(string dfsName, string serverName, string shareName)
	{
		return GetDfsInfoCore(getFromClient: true, dfsName, serverName, shareName);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dfs")]
	public static IEnumerable<string> EnumerateDomainDfsRoot()
	{
		return EnumerateDomainDfsRootCore(null, continueOnException: false);
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dfs")]
	[SecurityCritical]
	public static IEnumerable<string> EnumerateDomainDfsRoot(string domain, bool continueOnException)
	{
		return EnumerateDomainDfsRootCore(domain, continueOnException);
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dfs")]
	[SecurityCritical]
	internal static IEnumerable<string> EnumerateDomainDfsRootCore(string domain, bool continueOnException)
	{
		if (!Alphaleonis.Win32.Filesystem.NativeMethods.IsAtLeastWindowsVista)
		{
			throw new PlatformNotSupportedException(new Win32Exception(1150).Message);
		}
		return from dfs in EnumerateNetworkObjectCore(default(FunctionData), (NativeMethods.DFS_INFO_200 structure, SafeGlobalMemoryBufferHandle buffer) => new DfsInfo
			{
				EntryPath = string.Format(CultureInfo.InvariantCulture, "{0}{1}{2}{3}", Path.UncPrefix, (!Utils.IsNullOrWhiteSpace(domain)) ? domain : NativeMethods.ComputerDomain, Path.DirectorySeparatorChar, structure.FtDfsName)
			}, delegate(FunctionData functionData, out SafeGlobalMemoryBufferHandle buffer, int prefMaxLen, out uint entriesRead, out uint totalEntries, out uint resumeHandle)
			{
				totalEntries = 0u;
				return NativeMethods.NetDfsEnum((!Utils.IsNullOrWhiteSpace(domain)) ? Path.GetRegularPathCore(domain, GetFullPathOptions.CheckInvalidPathChars, allowEmpty: false).Replace(Path.UncPrefix, string.Empty) : NativeMethods.ComputerDomain, 200u, prefMaxLen, out buffer, out entriesRead, out resumeHandle);
			}, continueOnException)
			select dfs.EntryPath;
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dfs")]
	public static IEnumerable<string> EnumerateDfsRoot()
	{
		return EnumerateDfsRootCore(null, continueOnException: false);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dfs")]
	public static IEnumerable<string> EnumerateDfsRoot(string host, bool continueOnException)
	{
		return EnumerateDfsRootCore(host, continueOnException);
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dfs")]
	[SecurityCritical]
	internal static IEnumerable<string> EnumerateDfsRootCore(string host, bool continueOnException)
	{
		if (!Alphaleonis.Win32.Filesystem.NativeMethods.IsAtLeastWindowsVista)
		{
			throw new PlatformNotSupportedException(new Win32Exception(1150).Message);
		}
		return from dfs in EnumerateNetworkObjectCore(default(FunctionData), (NativeMethods.DFS_INFO_300 structure, SafeGlobalMemoryBufferHandle buffer) => new DfsInfo
			{
				EntryPath = structure.DfsName
			}, delegate(FunctionData functionData, out SafeGlobalMemoryBufferHandle buffer, int prefMaxLen, out uint entriesRead, out uint totalEntries, out uint resumeHandle)
			{
				totalEntries = 0u;
				return NativeMethods.NetDfsEnum((!Utils.IsNullOrWhiteSpace(host)) ? Path.GetRegularPathCore(host, GetFullPathOptions.CheckInvalidPathChars, allowEmpty: false).Replace(Path.UncPrefix, string.Empty) : Environment.MachineName, 300u, prefMaxLen, out buffer, out entriesRead, out resumeHandle);
			}, continueOnException)
			select dfs.EntryPath;
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dfs")]
	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "dfs")]
	public static IEnumerable<DfsInfo> EnumerateDfsLinks(string dfsName)
	{
		if (!Alphaleonis.Win32.Filesystem.NativeMethods.IsAtLeastWindowsVista)
		{
			throw new PlatformNotSupportedException(new Win32Exception(1150).Message);
		}
		if (Utils.IsNullOrWhiteSpace(dfsName))
		{
			throw new ArgumentNullException("dfsName");
		}
		return EnumerateNetworkObjectCore(default(FunctionData), (NativeMethods.DFS_INFO_9 structure, SafeGlobalMemoryBufferHandle buffer) => new DfsInfo(structure), delegate(FunctionData functionData, out SafeGlobalMemoryBufferHandle buffer, int prefMaxLen, out uint entriesRead, out uint totalEntries, out uint resumeHandle1)
		{
			totalEntries = 0u;
			return NativeMethods.NetDfsEnum(dfsName, 9u, prefMaxLen, out buffer, out entriesRead, out resumeHandle1);
		}, continueOnException: false);
	}

	[SecurityCritical]
	public static string GetUncName()
	{
		return string.Format(CultureInfo.InvariantCulture, "{0}{1}", new object[2]
		{
			Path.UncPrefix,
			Environment.MachineName
		});
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0")]
	public static string GetUncName(string computerName)
	{
		if (!Utils.IsNullOrWhiteSpace(computerName))
		{
			if (!computerName.StartsWith(Path.UncPrefix, StringComparison.Ordinal))
			{
				return Path.UncPrefix + computerName.Trim();
			}
			return computerName.Trim();
		}
		return GetUncName();
	}

	[SecurityCritical]
	public static IEnumerable<OpenResourceInfo> EnumerateOpenResources()
	{
		return EnumerateOpenResourcesCore(null, null, null, continueOnException: false);
	}

	[SecurityCritical]
	public static IEnumerable<OpenResourceInfo> EnumerateOpenResources(string host, string basePath, string typeName, bool continueOnException)
	{
		return EnumerateOpenResourcesCore(host, basePath, typeName, continueOnException);
	}

	[SecurityCritical]
	internal static IEnumerable<OpenResourceInfo> EnumerateOpenResourcesCore(string host, string basePath, string typeName, bool continueOnException)
	{
		basePath = (Utils.IsNullOrWhiteSpace(basePath) ? null : Path.GetRegularPathCore(basePath, GetFullPathOptions.CheckInvalidPathChars, allowEmpty: false));
		typeName = (Utils.IsNullOrWhiteSpace(typeName) ? null : typeName);
		FunctionData fd = new FunctionData
		{
			ExtraData1 = basePath,
			ExtraData2 = typeName
		};
		return EnumerateNetworkObjectCore(fd, (NativeMethods.FILE_INFO_3 structure, SafeGlobalMemoryBufferHandle buffer) => new OpenResourceInfo(host, structure), delegate(FunctionData functionData, out SafeGlobalMemoryBufferHandle buffer, int prefMaxLen, out uint entriesRead, out uint totalEntries, out uint resumeHandle)
		{
			return NativeMethods.NetFileEnum(Utils.IsNullOrWhiteSpace(host) ? Environment.MachineName : Path.GetRegularPathCore(host, GetFullPathOptions.CheckInvalidPathChars, allowEmpty: false).Replace(Path.UncPrefix, string.Empty), fd.ExtraData1, fd.ExtraData2, 3u, out buffer, -1, out entriesRead, out totalEntries, out resumeHandle);
		}, continueOnException);
	}

	[SecurityCritical]
	public static IEnumerable<DriveInfo> EnumerateDrives()
	{
		return EnumerateDrives(Environment.MachineName, continueOnException: false);
	}

	[SecurityCritical]
	public static IEnumerable<DriveInfo> EnumerateDrives(string host, bool continueOnException)
	{
		return from drive in EnumerateDrivesCore(host, continueOnException)
			select string.Format(CultureInfo.InvariantCulture, "{0}{1}{2}{3}{4}", Path.UncPrefix, host, Path.DirectorySeparator, drive[0], Path.NetworkDriveSeparator) into uncDrive
			select new DriveInfo(uncDrive);
	}

	[SecurityCritical]
	internal static IEnumerable<string> EnumerateDrivesCore(string host, bool continueOnException)
	{
		FunctionData functionData2 = default(FunctionData);
		functionData2.EnumType = 1;
		return EnumerateNetworkObjectCore(functionData2, (string structure, SafeGlobalMemoryBufferHandle buffer) => structure, delegate(FunctionData functionData, out SafeGlobalMemoryBufferHandle buffer, int prefMaxLen, out uint entriesRead, out uint totalEntries, out uint resume)
		{
			return NativeMethods.NetServerDiskEnum(Utils.IsNullOrWhiteSpace(host) ? Environment.MachineName : Path.GetRegularPathCore(host, GetFullPathOptions.CheckInvalidPathChars, allowEmpty: false).Replace(Path.UncPrefix, string.Empty), 0u, out buffer, -1, out entriesRead, out totalEntries, out resume);
		}, continueOnException);
	}

	[SecurityCritical]
	public static IEnumerable<OpenConnectionInfo> EnumerateOpenConnections()
	{
		return EnumerateOpenConnectionsCore(null, null, continueOnException: false);
	}

	[SecurityCritical]
	public static IEnumerable<OpenConnectionInfo> EnumerateOpenConnections(string host, string share, bool continueOnException)
	{
		return EnumerateOpenConnectionsCore(host, share, continueOnException);
	}

	[SecurityCritical]
	internal static IEnumerable<OpenConnectionInfo> EnumerateOpenConnectionsCore(string host, string share, bool continueOnException)
	{
		if (Utils.IsNullOrWhiteSpace(share))
		{
			throw new ArgumentNullException("share");
		}
		FunctionData functionData2 = default(FunctionData);
		functionData2.ExtraData1 = share;
		return EnumerateNetworkObjectCore(functionData2, (NativeMethods.CONNECTION_INFO_1 structure, SafeGlobalMemoryBufferHandle buffer) => new OpenConnectionInfo(host, structure), delegate(FunctionData functionData, out SafeGlobalMemoryBufferHandle buffer, int prefMaxLen, out uint entriesRead, out uint totalEntries, out uint resumeHandle)
		{
			return NativeMethods.NetConnectionEnum(Utils.IsNullOrWhiteSpace(host) ? Environment.MachineName : Path.GetRegularPathCore(host, GetFullPathOptions.CheckInvalidPathChars, allowEmpty: false).Replace(Path.UncPrefix, string.Empty), functionData.ExtraData1, 1u, out buffer, -1, out entriesRead, out totalEntries, out resumeHandle);
		}, continueOnException);
	}

	[SecurityCritical]
	public static IEnumerable<SessionInfo> EnumerateSessions()
	{
		return EnumerateSessionsCore(Environment.MachineName, null, null);
	}

	[SecurityCritical]
	public static IEnumerable<SessionInfo> EnumerateSessions(string hostName)
	{
		return EnumerateSessionsCore(hostName, null, null);
	}

	[SecurityCritical]
	public static IEnumerable<SessionInfo> EnumerateSessions(string hostName, string clientName)
	{
		return EnumerateSessionsCore(hostName, clientName, null);
	}

	[SecurityCritical]
	public static IEnumerable<SessionInfo> EnumerateSessions(string hostName, string clientName, string userName)
	{
		return EnumerateSessionsCore(hostName, clientName, userName);
	}

	[SecurityCritical]
	internal static IEnumerable<SessionInfo> EnumerateSessionsCore(string hostName, string clientName, string userName)
	{
		FunctionData fd = default(FunctionData);
		bool flag = false;
		string stripUnc = ((!Utils.IsNullOrWhiteSpace(hostName)) ? Path.GetRegularPathCore(hostName, GetFullPathOptions.CheckInvalidPathChars, allowEmpty: false).Replace(Path.UncPrefix, string.Empty) : null);
		foreach (SessionInfo item in EnumerateNetworkObjectCore(fd, (NativeMethods.SESSION_INFO_502 structure, SafeGlobalMemoryBufferHandle buffer) => new SessionInfo(stripUnc, SessionInfoLevel.Info502, structure), delegate(FunctionData functionData, out SafeGlobalMemoryBufferHandle buffer, int prefMaxLen, out uint entriesRead, out uint totalEntries, out uint resumeHandle)
		{
			return NativeMethods.NetSessionEnum(stripUnc, clientName, userName, SessionInfoLevel.Info502, out buffer, -1, out entriesRead, out totalEntries, out resumeHandle);
		}, continueOnException: true))
		{
			yield return item;
			flag = true;
		}
		if (flag)
		{
			yield break;
		}
		foreach (SessionInfo item2 in EnumerateNetworkObjectCore(fd, (NativeMethods.SESSION_INFO_2 structure, SafeGlobalMemoryBufferHandle buffer) => new SessionInfo(stripUnc, SessionInfoLevel.Info2, structure), delegate(FunctionData functionData, out SafeGlobalMemoryBufferHandle buffer, int prefMaxLen, out uint entriesRead, out uint totalEntries, out uint resumeHandle)
		{
			return NativeMethods.NetSessionEnum(stripUnc, clientName, userName, SessionInfoLevel.Info2, out buffer, -1, out entriesRead, out totalEntries, out resumeHandle);
		}, continueOnException: true))
		{
			yield return item2;
			flag = true;
		}
		if (flag)
		{
			yield break;
		}
		foreach (SessionInfo item3 in EnumerateNetworkObjectCore(fd, (NativeMethods.SHARE_INFO_1 structure, SafeGlobalMemoryBufferHandle buffer) => new SessionInfo(stripUnc, SessionInfoLevel.Info1, structure), delegate(FunctionData functionData, out SafeGlobalMemoryBufferHandle buffer, int prefMaxLen, out uint entriesRead, out uint totalEntries, out uint resumeHandle)
		{
			return NativeMethods.NetSessionEnum(stripUnc, clientName, userName, SessionInfoLevel.Info1, out buffer, -1, out entriesRead, out totalEntries, out resumeHandle);
		}, continueOnException: true))
		{
			yield return item3;
			flag = true;
		}
		if (flag)
		{
			yield break;
		}
		foreach (SessionInfo item4 in EnumerateNetworkObjectCore(fd, (NativeMethods.SESSION_INFO_10 structure, SafeGlobalMemoryBufferHandle buffer) => new SessionInfo(stripUnc, SessionInfoLevel.Info10, structure), delegate(FunctionData functionData, out SafeGlobalMemoryBufferHandle buffer, int prefMaxLen, out uint entriesRead, out uint totalEntries, out uint resumeHandle)
		{
			return NativeMethods.NetSessionEnum(stripUnc, clientName, userName, SessionInfoLevel.Info10, out buffer, -1, out entriesRead, out totalEntries, out resumeHandle);
		}, continueOnException: true))
		{
			yield return item4;
			flag = true;
		}
		if (flag)
		{
			yield break;
		}
		foreach (SessionInfo item5 in EnumerateNetworkObjectCore(fd, (NativeMethods.SESSION_INFO_0 structure, SafeGlobalMemoryBufferHandle buffer) => new SessionInfo(stripUnc, SessionInfoLevel.Info0, structure), delegate(FunctionData functionData, out SafeGlobalMemoryBufferHandle buffer, int prefMaxLen, out uint entriesRead, out uint totalEntries, out uint resumeHandle)
		{
			return NativeMethods.NetSessionEnum(stripUnc, clientName, userName, SessionInfoLevel.Info0, out buffer, -1, out entriesRead, out totalEntries, out resumeHandle);
		}, continueOnException: true))
		{
			yield return item5;
		}
	}

	[SecurityCritical]
	public static IEnumerable<ShareInfo> EnumerateShares()
	{
		return EnumerateSharesCore(null, ShareType.All, continueOnException: false);
	}

	[SecurityCritical]
	public static IEnumerable<ShareInfo> EnumerateShares(bool continueOnException)
	{
		return EnumerateSharesCore(null, ShareType.All, continueOnException);
	}

	[SecurityCritical]
	public static IEnumerable<ShareInfo> EnumerateShares(ShareType shareType, bool continueOnException)
	{
		return EnumerateSharesCore(null, shareType, continueOnException);
	}

	[SecurityCritical]
	public static IEnumerable<ShareInfo> EnumerateShares(string host)
	{
		return EnumerateSharesCore(host, ShareType.All, continueOnException: false);
	}

	[SecurityCritical]
	public static IEnumerable<ShareInfo> EnumerateShares(string host, bool continueOnException)
	{
		return EnumerateSharesCore(host, ShareType.All, continueOnException);
	}

	[SecurityCritical]
	public static IEnumerable<ShareInfo> EnumerateShares(string host, ShareType shareType, bool continueOnException)
	{
		return EnumerateSharesCore(host, shareType, continueOnException);
	}

	[SecurityCritical]
	internal static IEnumerable<ShareInfo> EnumerateSharesCore(string host, ShareType shareType, bool continueOnException)
	{
		FunctionData fd = default(FunctionData);
		bool flag = false;
		bool yieldAll = shareType == ShareType.All;
		string stripUnc = (Utils.IsNullOrWhiteSpace(host) ? Environment.MachineName : Path.GetRegularPathCore(host, GetFullPathOptions.CheckInvalidPathChars, allowEmpty: false).Replace(Path.UncPrefix, string.Empty));
		foreach (ShareInfo item in from si in EnumerateNetworkObjectCore(fd, (NativeMethods.SHARE_INFO_503 structure, SafeGlobalMemoryBufferHandle buffer) => new ShareInfo(stripUnc, ShareInfoLevel.Info503, structure), delegate(FunctionData functionData, out SafeGlobalMemoryBufferHandle buffer, int prefMaxLen, out uint entriesRead, out uint totalEntries, out uint resumeHandle)
			{
				return NativeMethods.NetShareEnum(stripUnc, 503u, out buffer, -1, out entriesRead, out totalEntries, out resumeHandle);
			}, continueOnException)
			where yieldAll || si.ShareType == shareType
			select si)
		{
			yield return item;
			flag = true;
		}
		if (flag)
		{
			yield break;
		}
		foreach (ShareInfo item2 in from si in EnumerateNetworkObjectCore(fd, (NativeMethods.SHARE_INFO_2 structure, SafeGlobalMemoryBufferHandle buffer) => new ShareInfo(stripUnc, ShareInfoLevel.Info2, structure), delegate(FunctionData functionData, out SafeGlobalMemoryBufferHandle buffer, int prefMaxLen, out uint entriesRead, out uint totalEntries, out uint resumeHandle)
			{
				return NativeMethods.NetShareEnum(stripUnc, 2u, out buffer, -1, out entriesRead, out totalEntries, out resumeHandle);
			}, continueOnException)
			where yieldAll || si.ShareType == shareType
			select si)
		{
			yield return item2;
			flag = true;
		}
		if (flag)
		{
			yield break;
		}
		foreach (ShareInfo item3 in from si in EnumerateNetworkObjectCore(fd, (NativeMethods.SHARE_INFO_1 structure, SafeGlobalMemoryBufferHandle buffer) => new ShareInfo(stripUnc, ShareInfoLevel.Info1, structure), delegate(FunctionData functionData, out SafeGlobalMemoryBufferHandle buffer, int prefMaxLen, out uint entriesRead, out uint totalEntries, out uint resumeHandle)
			{
				return NativeMethods.NetShareEnum(stripUnc, 1u, out buffer, -1, out entriesRead, out totalEntries, out resumeHandle);
			}, continueOnException)
			where yieldAll || si.ShareType == shareType
			select si)
		{
			yield return item3;
		}
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Justification = "Utils.IsNullOrWhiteSpace validates arguments.")]
	public static string[] GetHostShareFromPath(string uncPath)
	{
		if (Utils.IsNullOrWhiteSpace(uncPath))
		{
			return null;
		}
		if (Uri.TryCreate(Path.GetRegularPathCore(uncPath, GetFullPathOptions.None, allowEmpty: false), UriKind.Absolute, out var result) && result.IsUnc)
		{
			return new string[2]
			{
				result.Host,
				result.GetComponents(UriComponents.Path, UriFormat.Unescaped).Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar)
			};
		}
		return null;
	}

	[SecurityCritical]
	public static ServerStatisticsInfo GetServerStatistics()
	{
		return (ServerStatisticsInfo)GetNetStatisticsCore(isServer: true, Environment.MachineName);
	}

	[SecurityCritical]
	public static ServerStatisticsInfo GetServerStatistics(string hostName)
	{
		return (ServerStatisticsInfo)GetNetStatisticsCore(isServer: true, hostName);
	}

	[SecurityCritical]
	public static WorkstationStatisticsInfo GetWorkstationStatistics()
	{
		return (WorkstationStatisticsInfo)GetNetStatisticsCore(isServer: false, Environment.MachineName);
	}

	[SecurityCritical]
	public static WorkstationStatisticsInfo GetWorkstationStatistics(string hostName)
	{
		return (WorkstationStatisticsInfo)GetNetStatisticsCore(isServer: false, hostName);
	}

	[SecurityCritical]
	internal static object GetNetStatisticsCore(bool isServer, string hostName)
	{
		if (!isServer)
		{
			return new WorkstationStatisticsInfo(hostName, null);
		}
		return new ServerStatisticsInfo(hostName, null);
	}

	[SecurityCritical]
	internal static T GetNetStatisticsNative<T>(bool isServer, string hostName)
	{
		SafeGlobalMemoryBufferHandle bufptr;
		uint num = NativeMethods.NetStatisticsGet((!Utils.IsNullOrWhiteSpace(hostName)) ? Path.GetRegularPathCore(hostName, GetFullPathOptions.CheckInvalidPathChars, allowEmpty: false).Replace(Path.UncPrefix, string.Empty) : null, isServer ? "LanmanServer" : "LanmanWorkstation", 0u, 0u, out bufptr);
		using (bufptr)
		{
			if (num != 0)
			{
				throw new NetworkInformationException((int)num);
			}
			return bufptr.PtrToStructure<T>(0);
		}
	}

	[SecurityCritical]
	public static ShareInfo GetShareInfo(string uncPath, bool continueOnException)
	{
		string[] hostShareFromPath = GetHostShareFromPath(uncPath);
		return GetShareInfoCore(ShareInfoLevel.Info503, hostShareFromPath[0], hostShareFromPath[1], continueOnException);
	}

	[SecurityCritical]
	public static ShareInfo GetShareInfo(ShareInfoLevel shareLevel, string uncPath, bool continueOnException)
	{
		string[] hostShareFromPath = GetHostShareFromPath(uncPath);
		return GetShareInfoCore(shareLevel, hostShareFromPath[0], hostShareFromPath[1], continueOnException);
	}

	[SecurityCritical]
	public static ShareInfo GetShareInfo(string host, string share, bool continueOnException)
	{
		return GetShareInfoCore(ShareInfoLevel.Info503, host, share, continueOnException);
	}

	[SecurityCritical]
	public static ShareInfo GetShareInfo(ShareInfoLevel shareLevel, string host, string share, bool continueOnException)
	{
		return GetShareInfoCore(shareLevel, host, share, continueOnException);
	}

	[SecurityCritical]
	internal static ShareInfo GetShareInfoCore(ShareInfoLevel shareLevel, string host, string share, bool continueOnException)
	{
		if (Utils.IsNullOrWhiteSpace(share))
		{
			return null;
		}
		string text = (Utils.IsNullOrWhiteSpace(host) ? Environment.MachineName : Path.GetRegularPathCore(host, GetFullPathOptions.CheckInvalidPathChars, allowEmpty: false).Replace(Path.UncPrefix, string.Empty));
		bool flag = false;
		while (true)
		{
			uint level = Convert.ToUInt16(shareLevel, CultureInfo.InvariantCulture);
			SafeGlobalMemoryBufferHandle lpBuffer;
			uint num = NativeMethods.NetShareGetInfo(text, share, level, out lpBuffer);
			using (lpBuffer)
			{
				switch (num)
				{
				default:
					if (!continueOnException)
					{
						throw new NetworkInformationException((int)num);
					}
					break;
				case 5u:
				case 1783u:
					if (flag || shareLevel == ShareInfoLevel.Info2)
					{
						break;
					}
					shareLevel = ShareInfoLevel.Info2;
					flag = true;
					goto end_IL_0039;
				case 0u:
					switch (shareLevel)
					{
					case ShareInfoLevel.Info2:
						return new ShareInfo(text, shareLevel, lpBuffer.PtrToStructure<NativeMethods.SHARE_INFO_2>(0));
					case ShareInfoLevel.Info1:
						return new ShareInfo(text, shareLevel, lpBuffer.PtrToStructure<NativeMethods.SHARE_INFO_1>(0));
					case ShareInfoLevel.Info1005:
					{
						ShareInfo shareInfo = new ShareInfo(text, shareLevel, lpBuffer.PtrToStructure<NativeMethods.SHARE_INFO_1005>(0));
						shareInfo.NetFullPath = Path.CombineCore(false, Path.UncPrefix + text, share);
						return shareInfo;
					}
					case ShareInfoLevel.Info503:
						return new ShareInfo(text, shareLevel, lpBuffer.PtrToStructure<NativeMethods.SHARE_INFO_503>(0));
					}
					break;
				}
				return null;
				end_IL_0039:;
			}
		}
	}

	[SecurityCritical]
	public static void DisconnectFrom(string remoteName)
	{
		ConnectDisconnectArguments arguments = default(ConnectDisconnectArguments);
		arguments.RemoteName = remoteName;
		arguments.IsDisconnect = true;
		ConnectDisconnectCore(arguments);
	}

	[SecurityCritical]
	public static void DisconnectFrom(string remoteName, bool force, bool updateProfile)
	{
		ConnectDisconnectArguments arguments = default(ConnectDisconnectArguments);
		arguments.RemoteName = remoteName;
		arguments.Prompt = force;
		arguments.UpdateProfile = updateProfile;
		arguments.IsDisconnect = true;
		ConnectDisconnectCore(arguments);
	}

	[SecurityCritical]
	public static void DisconnectDrive(string localName)
	{
		ConnectDisconnectArguments arguments = default(ConnectDisconnectArguments);
		arguments.LocalName = localName;
		arguments.IsDeviceMap = true;
		arguments.IsDisconnect = true;
		ConnectDisconnectCore(arguments);
	}

	[SecurityCritical]
	public static void DisconnectDrive(string localName, bool force, bool updateProfile)
	{
		ConnectDisconnectArguments arguments = default(ConnectDisconnectArguments);
		arguments.LocalName = localName;
		arguments.Prompt = force;
		arguments.UpdateProfile = updateProfile;
		arguments.IsDeviceMap = true;
		arguments.IsDisconnect = true;
		ConnectDisconnectCore(arguments);
	}

	[SecurityCritical]
	public static void ConnectTo(string remoteName)
	{
		ConnectDisconnectArguments arguments = default(ConnectDisconnectArguments);
		arguments.RemoteName = remoteName;
		ConnectDisconnectCore(arguments);
	}

	[SecurityCritical]
	public static void ConnectTo(string remoteName, string userName, string password, bool prompt, bool updateProfile, bool saveCredentials)
	{
		ConnectDisconnectArguments arguments = default(ConnectDisconnectArguments);
		arguments.RemoteName = remoteName;
		arguments.UserName = userName;
		arguments.Password = password;
		arguments.Prompt = prompt;
		arguments.UpdateProfile = updateProfile;
		arguments.SaveCredentials = saveCredentials;
		ConnectDisconnectCore(arguments);
	}

	[SecurityCritical]
	public static void ConnectTo(string remoteName, NetworkCredential credentials, bool prompt, bool updateProfile, bool saveCredentials)
	{
		ConnectDisconnectArguments arguments = default(ConnectDisconnectArguments);
		arguments.RemoteName = remoteName;
		arguments.Credential = credentials;
		arguments.Prompt = prompt;
		arguments.UpdateProfile = updateProfile;
		arguments.SaveCredentials = saveCredentials;
		ConnectDisconnectCore(arguments);
	}

	[SecurityCritical]
	public static void ConnectTo(IntPtr winOwner, string remoteName, string userName, string password, bool prompt, bool updateProfile, bool saveCredentials)
	{
		ConnectDisconnectArguments arguments = default(ConnectDisconnectArguments);
		arguments.WinOwner = winOwner;
		arguments.RemoteName = remoteName;
		arguments.UserName = userName;
		arguments.Password = password;
		arguments.Prompt = prompt;
		arguments.UpdateProfile = updateProfile;
		arguments.SaveCredentials = saveCredentials;
		ConnectDisconnectCore(arguments);
	}

	[SecurityCritical]
	public static void ConnectTo(IntPtr winOwner, string remoteName, NetworkCredential credentials, bool prompt, bool updateProfile, bool saveCredentials)
	{
		ConnectDisconnectArguments arguments = default(ConnectDisconnectArguments);
		arguments.WinOwner = winOwner;
		arguments.RemoteName = remoteName;
		arguments.Credential = credentials;
		arguments.Prompt = prompt;
		arguments.UpdateProfile = updateProfile;
		arguments.SaveCredentials = saveCredentials;
		ConnectDisconnectCore(arguments);
	}

	[SecurityCritical]
	public static string ConnectDrive(string localName, string remoteName)
	{
		ConnectDisconnectArguments arguments = default(ConnectDisconnectArguments);
		arguments.LocalName = localName;
		arguments.RemoteName = remoteName;
		arguments.IsDeviceMap = true;
		return ConnectDisconnectCore(arguments);
	}

	[SecurityCritical]
	public static string ConnectDrive(string localName, string remoteName, string userName, string password, bool prompt, bool updateProfile, bool saveCredentials)
	{
		ConnectDisconnectArguments arguments = default(ConnectDisconnectArguments);
		arguments.LocalName = localName;
		arguments.RemoteName = remoteName;
		arguments.UserName = userName;
		arguments.Password = password;
		arguments.Prompt = prompt;
		arguments.UpdateProfile = updateProfile;
		arguments.SaveCredentials = saveCredentials;
		arguments.IsDeviceMap = true;
		return ConnectDisconnectCore(arguments);
	}

	[SecurityCritical]
	public static string ConnectDrive(string localName, string remoteName, NetworkCredential credentials, bool prompt, bool updateProfile, bool saveCredentials)
	{
		ConnectDisconnectArguments arguments = default(ConnectDisconnectArguments);
		arguments.LocalName = localName;
		arguments.RemoteName = remoteName;
		arguments.Credential = credentials;
		arguments.Prompt = prompt;
		arguments.UpdateProfile = updateProfile;
		arguments.SaveCredentials = saveCredentials;
		arguments.IsDeviceMap = true;
		return ConnectDisconnectCore(arguments);
	}

	[SecurityCritical]
	public static string ConnectDrive(IntPtr winOwner, string localName, string remoteName, string userName, string password, bool prompt, bool updateProfile, bool saveCredentials)
	{
		ConnectDisconnectArguments arguments = default(ConnectDisconnectArguments);
		arguments.WinOwner = winOwner;
		arguments.LocalName = localName;
		arguments.RemoteName = remoteName;
		arguments.UserName = userName;
		arguments.Password = password;
		arguments.Prompt = prompt;
		arguments.UpdateProfile = updateProfile;
		arguments.SaveCredentials = saveCredentials;
		arguments.IsDeviceMap = true;
		return ConnectDisconnectCore(arguments);
	}

	[SecurityCritical]
	public static string ConnectDrive(IntPtr winOwner, string localName, string remoteName, NetworkCredential credentials, bool prompt, bool updateProfile, bool saveCredentials)
	{
		ConnectDisconnectArguments arguments = default(ConnectDisconnectArguments);
		arguments.WinOwner = winOwner;
		arguments.LocalName = localName;
		arguments.RemoteName = remoteName;
		arguments.Credential = credentials;
		arguments.Prompt = prompt;
		arguments.UpdateProfile = updateProfile;
		arguments.SaveCredentials = saveCredentials;
		arguments.IsDeviceMap = true;
		return ConnectDisconnectCore(arguments);
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "dfs")]
	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dfs")]
	public static DfsInfo GetDfsInfo(string dfsName)
	{
		return GetDfsInfoCore(getFromClient: false, dfsName, null, null);
	}

	[SecurityCritical]
	internal static DfsInfo GetDfsInfoCore(bool getFromClient, string dfsName, string serverName, string shareName)
	{
		if (!Alphaleonis.Win32.Filesystem.NativeMethods.IsAtLeastWindowsVista)
		{
			throw new PlatformNotSupportedException(new Win32Exception(1150).Message);
		}
		if (Utils.IsNullOrWhiteSpace(dfsName))
		{
			throw new ArgumentNullException("dfsName");
		}
		serverName = ((!Utils.IsNullOrWhiteSpace(serverName)) ? serverName : null);
		shareName = ((!Utils.IsNullOrWhiteSpace(shareName)) ? shareName : null);
		SafeGlobalMemoryBufferHandle buffer;
		uint num = (getFromClient ? NativeMethods.NetDfsGetClientInfo(dfsName, serverName, shareName, 9u, out buffer) : NativeMethods.NetDfsGetInfo(dfsName, null, null, 9u, out buffer));
		if (num != 0)
		{
			throw new NetworkInformationException((int)num);
		}
		return new DfsInfo(buffer.PtrToStructure<NativeMethods.DFS_INFO_9>(0));
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly")]
	internal static string ConnectDisconnectCore(ConnectDisconnectArguments arguments)
	{
		if (!Utils.IsNullOrWhiteSpace(arguments.LocalName))
		{
			arguments.LocalName = Path.RemoveTrailingDirectorySeparator(arguments.LocalName).ToUpperInvariant();
		}
		if (!Utils.IsNullOrWhiteSpace(arguments.RemoteName))
		{
			if (!arguments.RemoteName.StartsWith(Path.UncPrefix, StringComparison.Ordinal))
			{
				arguments.RemoteName = Path.UncPrefix + arguments.RemoteName;
			}
			if (!Utils.IsNullOrWhiteSpace(arguments.RemoteName))
			{
				arguments.RemoteName = Path.RemoveTrailingDirectorySeparator(arguments.RemoteName);
			}
		}
		if (arguments.IsDisconnect)
		{
			bool prompt = arguments.Prompt;
			string obj = (arguments.IsDeviceMap ? arguments.LocalName : arguments.RemoteName);
			if (Utils.IsNullOrWhiteSpace(obj))
			{
				throw new ArgumentNullException(arguments.IsDeviceMap ? "localName" : "remoteName");
			}
			uint num = NativeMethods.WNetCancelConnection2W(obj, arguments.UpdateProfile ? NativeMethods.Connect.UpdateProfile : NativeMethods.Connect.None, prompt);
			if (num != 0)
			{
				throw new NetworkInformationException((int)num);
			}
			return null;
		}
		if (Utils.IsNullOrWhiteSpace(arguments.RemoteName) && !arguments.IsDeviceMap)
		{
			throw new ArgumentNullException("arguments.RemoteName");
		}
		if (arguments.Credential != null)
		{
			arguments.UserName = (Utils.IsNullOrWhiteSpace(arguments.Credential.Domain) ? arguments.Credential.UserName : string.Format(CultureInfo.InvariantCulture, "{0}\\{1}", new object[2]
			{
				arguments.Credential.Domain,
				arguments.Credential.UserName
			}));
			arguments.Password = arguments.Credential.Password;
		}
		NativeMethods.Connect connect = NativeMethods.Connect.None;
		if (arguments.IsDeviceMap)
		{
			connect |= NativeMethods.Connect.Redirect;
		}
		if (arguments.Prompt)
		{
			connect = connect | NativeMethods.Connect.Prompt | NativeMethods.Connect.Interactive;
		}
		if (arguments.UpdateProfile)
		{
			connect |= NativeMethods.Connect.UpdateProfile;
		}
		if (arguments.SaveCredentials)
		{
			connect |= NativeMethods.Connect.SaveCredentialManager;
		}
		NativeMethods.NETRESOURCE nETRESOURCE = default(NativeMethods.NETRESOURCE);
		nETRESOURCE.lpLocalName = arguments.LocalName;
		nETRESOURCE.lpRemoteName = arguments.RemoteName;
		nETRESOURCE.dwType = NativeMethods.ResourceType.Disk;
		NativeMethods.NETRESOURCE lpNetResource = nETRESOURCE;
		uint lpBufferSize = 3u;
		while (true)
		{
			StringBuilder stringBuilder = new StringBuilder((int)lpBufferSize);
			uint lpResult;
			uint num = NativeMethods.WNetUseConnectionW(arguments.WinOwner, ref lpNetResource, arguments.Password, arguments.UserName, connect, stringBuilder, out lpBufferSize, out lpResult);
			if (num != 0 && num == 234)
			{
				lpBufferSize *= 2;
			}
			switch (num)
			{
			case 234u:
				break;
			default:
				throw new NetworkInformationException((int)num);
			case 0u:
				if (!arguments.IsDeviceMap)
				{
					return null;
				}
				return stringBuilder.ToString();
			}
		}
	}

	[SecurityCritical]
	internal static IEnumerable<TStruct> EnumerateNetworkObjectCore<TStruct, TNative>(FunctionData functionData, Func<TNative, SafeGlobalMemoryBufferHandle, TStruct> createTStruct, EnumerateNetworkObjectDelegate enumerateNetworkObject, bool continueOnException)
	{
		int enumType = functionData.EnumType;
		bool isString;
		int objectSize;
		if (enumType == 1)
		{
			isString = true;
			objectSize = 6;
		}
		else
		{
			Type typeFromHandle = typeof(TNative);
			isString = (object)typeFromHandle == typeof(string);
			objectSize = ((!isString) ? Marshal.SizeOf(typeFromHandle) : 0);
		}
		while (true)
		{
			SafeGlobalMemoryBufferHandle buffer;
			uint entriesRead;
			uint totalEntries;
			uint resumeHandle;
			uint lastError = enumerateNetworkObject(functionData, out buffer, -1, out entriesRead, out totalEntries, out resumeHandle);
			using (buffer)
			{
				switch (lastError)
				{
				case 0u:
				case 234u:
					if (entriesRead != 0)
					{
						int i = 0;
						int itemOffset = 0;
						while (i < entriesRead)
						{
							yield return (TStruct)(isString ? buffer.PtrToStringUni(itemOffset, 2) : ((object)createTStruct(buffer.PtrToStructure<TNative>(itemOffset), buffer)));
							i++;
							itemOffset += objectSize;
						}
					}
					break;
				case 50u:
				case 1783u:
					yield break;
				}
			}
			buffer = null;
			switch (lastError)
			{
			case 234u:
				continue;
			case 0u:
				yield break;
			}
			if (!continueOnException)
			{
				throw new NetworkInformationException((int)lastError);
			}
			yield break;
		}
	}

	[SecurityCritical]
	internal static NativeMethods.REMOTE_NAME_INFO GetRemoteNameInfoCore(string path, bool continueOnException)
	{
		if (Utils.IsNullOrWhiteSpace(path))
		{
			throw new ArgumentNullException("path");
		}
		path = Path.GetRegularPathCore(path, GetFullPathOptions.CheckInvalidPathChars, allowEmpty: false);
		uint lpBufferSize = 1024u;
		uint num;
		do
		{
			using SafeGlobalMemoryBufferHandle safeGlobalMemoryBufferHandle = new SafeGlobalMemoryBufferHandle((int)lpBufferSize);
			num = NativeMethods.WNetGetUniversalNameW(path, 2u, safeGlobalMemoryBufferHandle, out lpBufferSize);
			if (num == 0)
			{
				return safeGlobalMemoryBufferHandle.PtrToStructure<NativeMethods.REMOTE_NAME_INFO>(0);
			}
		}
		while (num == 234);
		if (num != 0 && !continueOnException)
		{
			throw new NetworkInformationException((int)num);
		}
		return default(NativeMethods.REMOTE_NAME_INFO);
	}
}
