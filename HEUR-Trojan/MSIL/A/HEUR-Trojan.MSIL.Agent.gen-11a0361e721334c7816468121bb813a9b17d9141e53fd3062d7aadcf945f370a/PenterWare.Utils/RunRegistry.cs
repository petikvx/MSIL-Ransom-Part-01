using PenterWare.Crypt.CipherProviders;
using PenterWare.Filesystem.FilesystemTarget;
using PenterWare.Network;

namespace PenterWare.Utils;

internal class RunRegistry
{
	public static CipherProvider Cipher { get; set; }

	public static Session Session { get; set; }

	public static BaseFilesystem Filesystem { get; set; }
}
