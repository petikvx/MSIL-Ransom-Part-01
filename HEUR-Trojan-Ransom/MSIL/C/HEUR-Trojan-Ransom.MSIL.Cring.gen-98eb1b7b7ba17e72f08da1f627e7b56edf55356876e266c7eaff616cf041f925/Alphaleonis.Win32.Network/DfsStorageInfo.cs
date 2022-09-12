using System.Diagnostics.CodeAnalysis;

namespace Alphaleonis.Win32.Network;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dfs")]
public sealed class DfsStorageInfo
{
	public string ServerName { get; private set; }

	public string ShareName { get; private set; }

	public DfsStorageStates State { get; private set; }

	public DfsTargetPriorityClass TargetPriorityClass { get; private set; }

	public int TargetPriorityRank { get; private set; }

	public DfsStorageInfo()
	{
	}

	internal DfsStorageInfo(NativeMethods.DFS_STORAGE_INFO_1 structure)
	{
		ServerName = structure.ServerName;
		ShareName = structure.ShareName;
		State = structure.State;
		TargetPriorityClass = structure.TargetPriority.TargetPriorityClass;
		TargetPriorityRank = structure.TargetPriority.TargetPriorityRank;
	}

	public override string ToString()
	{
		return ShareName;
	}
}
