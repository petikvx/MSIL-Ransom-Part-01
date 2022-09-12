using System.Diagnostics.CodeAnalysis;

namespace Alphaleonis.Win32.Filesystem;

public enum FileEncryptionStatus
{
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Encryptable")]
	Encryptable,
	Encrypted,
	SystemFile,
	RootDirectory,
	SystemDirectory,
	Unknown,
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Filesystem")]
	NoFilesystemSupport,
	UserDisallowed,
	ReadOnly
}
