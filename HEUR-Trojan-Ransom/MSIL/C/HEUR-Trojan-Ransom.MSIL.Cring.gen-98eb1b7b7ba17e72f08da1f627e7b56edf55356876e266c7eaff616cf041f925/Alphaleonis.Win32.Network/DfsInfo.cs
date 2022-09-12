using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using Alphaleonis.Win32.Filesystem;

namespace Alphaleonis.Win32.Network;

[Serializable]
[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dfs")]
public sealed class DfsInfo
{
	private DirectoryInfo _directoryInfo;

	private readonly List<DfsStorageInfo> _storageInfoCollection = new List<DfsStorageInfo>();

	public DirectoryInfo DirectoryInfo => _directoryInfo ?? (_directoryInfo = new DirectoryInfo(null, EntryPath, PathFormat.FullPath));

	public string Comment { get; internal set; }

	public string EntryPath { get; internal set; }

	public Guid Guid { get; internal set; }

	public IEnumerable<DfsStorageInfo> StorageInfoCollection => _storageInfoCollection;

	public DfsVolumeStates State { get; internal set; }

	public long Timeout { get; internal set; }

	[SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "Flags")]
	public DfsPropertyFlags PropertyFlags { get; internal set; }

	public long MetadataSize { get; internal set; }

	public IntPtr SecurityDescriptor { get; internal set; }

	public DfsInfo()
	{
	}

	internal DfsInfo(NativeMethods.DFS_INFO_9 structure)
	{
		Comment = structure.Comment;
		EntryPath = structure.EntryPath;
		State = structure.State;
		Timeout = structure.Timeout;
		Guid = structure.Guid;
		MetadataSize = structure.MetadataSize;
		PropertyFlags = structure.PropertyFlags;
		SecurityDescriptor = structure.pSecurityDescriptor;
		if (structure.NumberOfStorages != 0)
		{
			Type typeFromHandle = typeof(NativeMethods.DFS_STORAGE_INFO_1);
			int num = Marshal.SizeOf(typeFromHandle);
			for (int i = 0; i < structure.NumberOfStorages; i++)
			{
				List<DfsStorageInfo> storageInfoCollection = _storageInfoCollection;
				IntPtr storage = structure.Storage;
				storageInfoCollection.Add(new DfsStorageInfo((NativeMethods.DFS_STORAGE_INFO_1)Marshal.PtrToStructure(new IntPtr(storage.ToInt64() + i * num), typeFromHandle)));
			}
		}
	}

	public override string ToString()
	{
		return EntryPath;
	}
}
