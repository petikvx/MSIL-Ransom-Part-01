using System;

namespace Renci.SshNet.Sftp;

[Flags]
internal enum Flags
{
	None = 0,
	Read = 1,
	Write = 2,
	Append = 4,
	CreateNewOrOpen = 8,
	Truncate = 0x10,
	CreateNew = 0x28
}
