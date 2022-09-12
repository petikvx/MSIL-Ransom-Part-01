using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Net;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace Alphaleonis.Win32.Network;

internal static class NativeMethods
{
	[Flags]
	internal enum ResourceUsage
	{
		Connectable = 1,
		Container = 2,
		NoLocalDevice = 4,
		Sibling = 8,
		Attached = 0x10,
		All = 0x13
	}

	internal enum ResourceType
	{
		Any,
		Disk,
		Print
	}

	internal enum ResourceScope
	{
		Connected = 1,
		GlobalNet,
		Remembered,
		Recent,
		Context
	}

	internal enum ResourceDisplayType
	{
		Generic,
		Domain,
		Server,
		Share,
		File,
		Group,
		Network,
		Root,
		ShareAdmin,
		Directory,
		Tree,
		NdsContainer
	}

	[Flags]
	internal enum Connect
	{
		None = 0,
		UpdateProfile = 1,
		Interactive = 8,
		Prompt = 0x10,
		Redirect = 0x80,
		SaveCredentialManager = 0x1000
	}

	[Flags]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dfs")]
	internal enum DfsNamespaceFlavors
	{
		Unknown = 0,
		Standalone = 0x100,
		AdBlob = 0x200,
		All = 0x300
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct SESSION_INFO_10
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public readonly string sesi10_cname;

		[MarshalAs(UnmanagedType.LPWStr)]
		public readonly string sesi10_username;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint sesi10_time;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint sesi10_idle_time;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct SESSION_INFO_502
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public readonly string sesi502_cname;

		[MarshalAs(UnmanagedType.LPWStr)]
		public readonly string sesi502_username;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint sesi502_num_opens;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint sesi502_time;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint sesi502_idle_time;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint sesi502_user_flags;

		[MarshalAs(UnmanagedType.LPWStr)]
		public readonly string sesi502_cltype_name;

		[MarshalAs(UnmanagedType.LPWStr)]
		public readonly string sesi502_transport;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct SESSION_INFO_2
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public readonly string sesi2_cname;

		[MarshalAs(UnmanagedType.LPWStr)]
		public readonly string sesi2_username;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint sesi2_num_opens;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint sesi2_time;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint sesi2_idle_time;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint sesi2_user_flags;

		[MarshalAs(UnmanagedType.LPWStr)]
		public readonly string sesi2_cltype_name;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct SESSION_INFO_1
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public readonly string sesi1_cname;

		[MarshalAs(UnmanagedType.LPWStr)]
		public readonly string sesi1_username;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint sesi1_num_opens;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint sesi1_time;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint sesi1_idle_time;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint sesi1_user_flags;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct SESSION_INFO_0
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public readonly string sesi0_cname;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dfs")]
	internal struct DFS_INFO_9
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public readonly string EntryPath;

		[MarshalAs(UnmanagedType.LPWStr)]
		public readonly string Comment;

		[MarshalAs(UnmanagedType.U4)]
		public readonly DfsVolumeStates State;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint Timeout;

		public readonly Guid Guid;

		[MarshalAs(UnmanagedType.U4)]
		public readonly DfsPropertyFlags PropertyFlags;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint MetadataSize;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint SdLengthReserved;

		public IntPtr pSecurityDescriptor;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint NumberOfStorages;

		public readonly IntPtr Storage;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct DFS_TARGET_PRIORITY
	{
		[MarshalAs(UnmanagedType.I4)]
		public readonly DfsTargetPriorityClass TargetPriorityClass;

		public readonly ushort TargetPriorityRank;

		public readonly ushort Reserved;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct DFS_STORAGE_INFO_1
	{
		[MarshalAs(UnmanagedType.U4)]
		public readonly DfsStorageStates State;

		[MarshalAs(UnmanagedType.LPWStr)]
		public readonly string ServerName;

		[MarshalAs(UnmanagedType.LPWStr)]
		public readonly string ShareName;

		[MarshalAs(UnmanagedType.Struct)]
		public readonly DFS_TARGET_PRIORITY TargetPriority;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct STAT_WORKSTATION_0
	{
		[MarshalAs(UnmanagedType.U8)]
		public readonly long StatisticsStartTime;

		[MarshalAs(UnmanagedType.U8)]
		public readonly long BytesReceived;

		[MarshalAs(UnmanagedType.U8)]
		public readonly long SmbsReceived;

		[MarshalAs(UnmanagedType.U8)]
		public readonly long PagingReadBytesRequested;

		[MarshalAs(UnmanagedType.U8)]
		public readonly long NonPagingReadBytesRequested;

		[MarshalAs(UnmanagedType.U8)]
		public readonly long CacheReadBytesRequested;

		[MarshalAs(UnmanagedType.U8)]
		public readonly long NetworkReadBytesRequested;

		[MarshalAs(UnmanagedType.U8)]
		public readonly long BytesTransmitted;

		[MarshalAs(UnmanagedType.U8)]
		public readonly long SmbsTransmitted;

		[MarshalAs(UnmanagedType.U8)]
		public readonly long PagingWriteBytesRequested;

		[MarshalAs(UnmanagedType.U8)]
		public readonly long NonPagingWriteBytesRequested;

		[MarshalAs(UnmanagedType.U8)]
		public readonly long CacheWriteBytesRequested;

		[MarshalAs(UnmanagedType.U8)]
		public readonly long NetworkWriteBytesRequested;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint InitiallyFailedOperations;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint FailedCompletionOperations;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint ReadOperations;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint RandomReadOperations;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint ReadSmbs;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint LargeReadSmbs;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint SmallReadSmbs;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint WriteOperations;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint RandomWriteOperations;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint WriteSmbs;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint LargeWriteSmbs;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint SmallWriteSmbs;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint RawReadsDenied;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint RawWritesDenied;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint NetworkErrors;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint Sessions;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint FailedSessions;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint Reconnects;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint CoreConnects;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint Lanman20Connects;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint Lanman21Connects;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint LanmanNtConnects;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint ServerDisconnects;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint HungSessions;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint UseCount;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint FailedUseCount;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint CurrentCommands;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct STAT_SERVER_0
	{
		[MarshalAs(UnmanagedType.U4)]
		public readonly uint sts0_start;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint sts0_fopens;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint sts0_devopens;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint sts0_jobsqueued;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint sts0_sopens;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint sts0_stimedout;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint sts0_serrorout;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint sts0_pwerrors;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint sts0_permerrors;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint sts0_syserrors;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint sts0_bytessent_low;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint sts0_bytessent_high;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint sts0_bytesrcvd_low;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint sts0_bytesrcvd_high;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint sts0_avresponse;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint sts0_reqbufneed;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint sts0_bigbufneed;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct SHARE_INFO_502
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public readonly string shi502_netname;

		[MarshalAs(UnmanagedType.U4)]
		public readonly ShareType shi502_type;

		[MarshalAs(UnmanagedType.LPWStr)]
		public readonly string shi502_remark;

		[MarshalAs(UnmanagedType.U4)]
		public readonly AccessPermissions shi502_permissions;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint shi502_max_uses;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint shi502_current_uses;

		[MarshalAs(UnmanagedType.LPWStr)]
		public readonly string shi502_path;

		[MarshalAs(UnmanagedType.LPWStr)]
		public readonly string shi502_passwd;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint shi502_reserved;

		public IntPtr shi502_security_descriptor;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct NETRESOURCE
	{
		[MarshalAs(UnmanagedType.U4)]
		public readonly ResourceScope dwScope;

		[MarshalAs(UnmanagedType.U4)]
		public ResourceType dwType;

		[MarshalAs(UnmanagedType.U4)]
		public readonly ResourceDisplayType dwDisplayType;

		[MarshalAs(UnmanagedType.U4)]
		public readonly ResourceUsage dwUsage;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string lpLocalName;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string lpRemoteName;

		[MarshalAs(UnmanagedType.LPWStr)]
		public readonly string lpComment;

		[MarshalAs(UnmanagedType.LPWStr)]
		public readonly string lpProvider;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct FILE_INFO_3
	{
		[MarshalAs(UnmanagedType.U4)]
		public readonly uint fi3_id;

		[MarshalAs(UnmanagedType.U4)]
		public readonly AccessPermissions fi3_permissions;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint fi3_num_locks;

		[MarshalAs(UnmanagedType.LPWStr)]
		public readonly string fi3_pathname;

		[MarshalAs(UnmanagedType.LPWStr)]
		public readonly string fi3_username;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct DFS_INFO_200
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public readonly string FtDfsName;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dfs")]
	internal struct DFS_INFO_300
	{
		[MarshalAs(UnmanagedType.U4)]
		[SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "Flags")]
		public readonly DfsNamespaceFlavors Flags;

		[MarshalAs(UnmanagedType.LPWStr)]
		[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dfs")]
		public readonly string DfsName;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct REMOTE_NAME_INFO
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		[SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
		public readonly string lpUniversalName;

		[MarshalAs(UnmanagedType.LPWStr)]
		[SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
		public readonly string lpConnectionName;

		[MarshalAs(UnmanagedType.LPWStr)]
		[SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
		public readonly string lpRemainingPath;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CONNECTION_INFO_1
	{
		[MarshalAs(UnmanagedType.U4)]
		public readonly uint coni1_id;

		[MarshalAs(UnmanagedType.U4)]
		public readonly ShareType coni1_type;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint coni1_num_opens;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint coni1_num_users;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint coni1_time;

		[MarshalAs(UnmanagedType.LPWStr)]
		public readonly string coni1_username;

		[MarshalAs(UnmanagedType.LPWStr)]
		public readonly string oni1_netname;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct SHARE_INFO_1005
	{
		[MarshalAs(UnmanagedType.U4)]
		public readonly ShareResourceTypes shi1005_flags;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct SHARE_INFO_1
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public readonly string shi1_netname;

		[MarshalAs(UnmanagedType.U4)]
		public readonly ShareType shi1_type;

		[MarshalAs(UnmanagedType.LPWStr)]
		public readonly string shi1_remark;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct SHARE_INFO_2
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public readonly string shi2_netname;

		[MarshalAs(UnmanagedType.U4)]
		public readonly ShareType shi2_type;

		[MarshalAs(UnmanagedType.LPWStr)]
		public readonly string shi2_remark;

		[MarshalAs(UnmanagedType.U4)]
		public readonly AccessPermissions shi2_permissions;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint shi2_max_uses;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint shi2_current_uses;

		[MarshalAs(UnmanagedType.LPWStr)]
		public readonly string shi2_path;

		[MarshalAs(UnmanagedType.LPWStr)]
		public readonly string shi2_passwd;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct SHARE_INFO_503
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public readonly string shi503_netname;

		[MarshalAs(UnmanagedType.U4)]
		public readonly ShareType shi503_type;

		[MarshalAs(UnmanagedType.LPWStr)]
		public readonly string shi503_remark;

		[MarshalAs(UnmanagedType.U4)]
		public readonly AccessPermissions shi503_permissions;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint shi503_max_uses;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint shi503_current_uses;

		[MarshalAs(UnmanagedType.LPWStr)]
		public readonly string shi503_path;

		[MarshalAs(UnmanagedType.LPWStr)]
		public readonly string shi503_passwd;

		[MarshalAs(UnmanagedType.LPWStr)]
		public readonly string shi503_servername;

		[MarshalAs(UnmanagedType.U4)]
		public readonly uint shi503_reserved;

		public IntPtr shi503_security_descriptor;
	}

	internal const int MaxPreferredLength = -1;

	internal static readonly string ComputerDomain = GetComputerDomain();

	[DllImport("mpr.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.U4)]
	internal static extern uint WNetCancelConnection2W([MarshalAs(UnmanagedType.LPWStr)] string lpName, Connect dwFlags, [MarshalAs(UnmanagedType.Bool)] bool fForce);

	[DllImport("mpr.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.U4)]
	internal static extern uint WNetGetUniversalNameW([MarshalAs(UnmanagedType.LPWStr)] string lpLocalPath, [MarshalAs(UnmanagedType.U4)] uint dwInfoLevel, SafeGlobalMemoryBufferHandle lpBuffer, [MarshalAs(UnmanagedType.U4)] out uint lpBufferSize);

	[DllImport("mpr.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.U4)]
	internal static extern uint WNetUseConnectionW(IntPtr hwndOwner, [MarshalAs(UnmanagedType.Struct)] ref NETRESOURCE lpNetResource, [MarshalAs(UnmanagedType.LPWStr)] string lpPassword, [MarshalAs(UnmanagedType.LPWStr)] string lpUserId, [MarshalAs(UnmanagedType.U4)] Connect dwFlags, StringBuilder lpAccessName, [MarshalAs(UnmanagedType.U4)] out uint lpBufferSize, [MarshalAs(UnmanagedType.U4)] out uint lpResult);

	[DllImport("netapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.U4)]
	internal static extern uint NetConnectionEnum([MarshalAs(UnmanagedType.LPWStr)] string serverName, [MarshalAs(UnmanagedType.LPWStr)] string qualifier, [MarshalAs(UnmanagedType.U4)] uint level, out SafeGlobalMemoryBufferHandle bufPtr, [MarshalAs(UnmanagedType.I4)] int prefMaxLen, [MarshalAs(UnmanagedType.U4)] out uint entriesRead, [MarshalAs(UnmanagedType.U4)] out uint totalEntries, [MarshalAs(UnmanagedType.U4)] out uint resumeHandle);

	[DllImport("netapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.U4)]
	internal static extern uint NetFileClose([MarshalAs(UnmanagedType.LPWStr)] string serverName, [MarshalAs(UnmanagedType.U4)] uint fileid);

	[DllImport("netapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.U4)]
	internal static extern uint NetFileEnum([MarshalAs(UnmanagedType.LPWStr)] string serverName, [MarshalAs(UnmanagedType.LPWStr)] string basepath, [MarshalAs(UnmanagedType.LPWStr)] string username, [MarshalAs(UnmanagedType.U4)] uint level, out SafeGlobalMemoryBufferHandle buffer, [MarshalAs(UnmanagedType.I4)] int prefmaxlen, [MarshalAs(UnmanagedType.U4)] out uint entriesRead, [MarshalAs(UnmanagedType.U4)] out uint totalentries, [MarshalAs(UnmanagedType.U4)] out uint resumeHandle);

	[DllImport("netapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[return: MarshalAs(UnmanagedType.U4)]
	internal static extern uint NetSessionEnum([MarshalAs(UnmanagedType.LPWStr)] string serverName, [MarshalAs(UnmanagedType.LPWStr)] string uncClientName, [MarshalAs(UnmanagedType.LPWStr)] string userName, [MarshalAs(UnmanagedType.U4)] SessionInfoLevel level, out SafeGlobalMemoryBufferHandle bufPtr, [MarshalAs(UnmanagedType.I4)] int prefMaxLen, [MarshalAs(UnmanagedType.U4)] out uint entriesRead, [MarshalAs(UnmanagedType.U4)] out uint totalEntries, [MarshalAs(UnmanagedType.U4)] out uint resumeHandle);

	[DllImport("netapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.U4)]
	internal static extern uint NetShareEnum([MarshalAs(UnmanagedType.LPWStr)] string serverName, [MarshalAs(UnmanagedType.U4)] uint level, out SafeGlobalMemoryBufferHandle bufPtr, [MarshalAs(UnmanagedType.I4)] int prefMaxLen, [MarshalAs(UnmanagedType.U4)] out uint entriesRead, [MarshalAs(UnmanagedType.U4)] out uint totalEntries, [MarshalAs(UnmanagedType.U4)] out uint resumeHandle);

	[DllImport("netapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.U4)]
	internal static extern uint NetShareGetInfo([MarshalAs(UnmanagedType.LPWStr)] string serverName, [MarshalAs(UnmanagedType.LPWStr)] string netName, [MarshalAs(UnmanagedType.U4)] uint level, out SafeGlobalMemoryBufferHandle lpBuffer);

	[DllImport("netapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	internal static extern uint NetStatisticsGet([MarshalAs(UnmanagedType.LPWStr)] string server, [MarshalAs(UnmanagedType.LPWStr)] string service, [MarshalAs(UnmanagedType.U4)] uint level, [MarshalAs(UnmanagedType.U4)] uint options, out SafeGlobalMemoryBufferHandle bufptr);

	[DllImport("netapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.U4)]
	internal static extern uint NetServerDiskEnum([MarshalAs(UnmanagedType.LPWStr)] string serverName, [MarshalAs(UnmanagedType.U4)] uint level, out SafeGlobalMemoryBufferHandle bufPtr, [MarshalAs(UnmanagedType.I4)] int prefMaxLen, [MarshalAs(UnmanagedType.U4)] out uint entriesRead, [MarshalAs(UnmanagedType.U4)] out uint totalEntries, [MarshalAs(UnmanagedType.U4)] out uint resumeHandle);

	[DllImport("netapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.U4)]
	internal static extern uint NetDfsEnum([MarshalAs(UnmanagedType.LPWStr)] string dfsName, [MarshalAs(UnmanagedType.U4)] uint level, [MarshalAs(UnmanagedType.U4)] int prefMaxLen, out SafeGlobalMemoryBufferHandle buffer, [MarshalAs(UnmanagedType.U4)] out uint entriesRead, [MarshalAs(UnmanagedType.U4)] out uint resumeHandle);

	[DllImport("netapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.U4)]
	internal static extern uint NetDfsGetClientInfo([MarshalAs(UnmanagedType.LPWStr)] string dfsEntryPath, [MarshalAs(UnmanagedType.LPWStr)] string serverName, [MarshalAs(UnmanagedType.LPWStr)] string shareName, [MarshalAs(UnmanagedType.U4)] uint level, out SafeGlobalMemoryBufferHandle buffer);

	[DllImport("netapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[return: MarshalAs(UnmanagedType.U4)]
	internal static extern uint NetDfsGetInfo([MarshalAs(UnmanagedType.LPWStr)] string dfsEntryPath, [MarshalAs(UnmanagedType.LPWStr)] string serverName, [MarshalAs(UnmanagedType.LPWStr)] string shareName, [MarshalAs(UnmanagedType.U4)] uint level, out SafeGlobalMemoryBufferHandle buffer);

	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	private static string GetComputerDomain(bool fdqn = false)
	{
		string text = Environment.UserDomainName;
		string text2 = Environment.MachineName.ToUpper(CultureInfo.InvariantCulture);
		try
		{
			if (fdqn)
			{
				text = Dns.GetHostEntry("LocalHost").HostName.ToUpper(CultureInfo.InvariantCulture).Replace(text2 + ".", string.Empty);
				text = text.Replace(text2, string.Empty);
				return text;
			}
			return text;
		}
		catch
		{
			return text;
		}
	}
}
