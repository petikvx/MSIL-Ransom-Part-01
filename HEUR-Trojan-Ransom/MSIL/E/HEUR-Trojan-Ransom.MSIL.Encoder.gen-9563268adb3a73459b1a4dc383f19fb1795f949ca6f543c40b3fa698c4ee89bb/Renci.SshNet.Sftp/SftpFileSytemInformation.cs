using Renci.SshNet.Common;

namespace Renci.SshNet.Sftp;

public class SftpFileSytemInformation
{
	internal const ulong SSH_FXE_STATVFS_ST_RDONLY = 1uL;

	internal const ulong SSH_FXE_STATVFS_ST_NOSUID = 2uL;

	private readonly ulong _flag;

	public ulong FileSystemBlockSize { get; private set; }

	public ulong BlockSize { get; private set; }

	public ulong TotalBlocks { get; private set; }

	public ulong FreeBlocks { get; private set; }

	public ulong AvailableBlocks { get; private set; }

	public ulong TotalNodes { get; private set; }

	public ulong FreeNodes { get; private set; }

	public ulong AvailableNodes { get; private set; }

	public ulong Sid { get; private set; }

	public bool IsReadOnly => (_flag & 1L) == 1L;

	public bool SupportsSetUid => (_flag & 2L) == 0L;

	public ulong MaxNameLenght { get; private set; }

	internal SftpFileSytemInformation(ulong bsize, ulong frsize, ulong blocks, ulong bfree, ulong bavail, ulong files, ulong ffree, ulong favail, ulong sid, ulong flag, ulong namemax)
	{
		FileSystemBlockSize = bsize;
		BlockSize = frsize;
		TotalBlocks = blocks;
		FreeBlocks = bfree;
		AvailableBlocks = bavail;
		TotalNodes = files;
		FreeNodes = ffree;
		AvailableNodes = favail;
		Sid = sid;
		_flag = flag;
		MaxNameLenght = namemax;
	}

	internal void SaveData(SshDataStream stream)
	{
		stream.Write(FileSystemBlockSize);
		stream.Write(BlockSize);
		stream.Write(TotalBlocks);
		stream.Write(FreeBlocks);
		stream.Write(AvailableBlocks);
		stream.Write(TotalNodes);
		stream.Write(FreeNodes);
		stream.Write(AvailableNodes);
		stream.Write(Sid);
		stream.Write(_flag);
		stream.Write(MaxNameLenght);
	}
}
