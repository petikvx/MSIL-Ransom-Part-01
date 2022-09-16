using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Chol2tes;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class Strings
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
				resourceMan = new ResourceManager("NuGet.Common.Strings", typeof(Strings).GetTypeInfo().Assembly);
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

	internal static string AbsolutePathRequired => ResourceManager.GetString("AbsolutePathRequired", resourceCulture);

	internal static string Argument_Must_Be_GreaterThanOrEqualTo => ResourceManager.GetString("Argument_Must_Be_GreaterThanOrEqualTo", resourceCulture);

	internal static string ArgumentNullOrEmpty => ResourceManager.GetString("ArgumentNullOrEmpty", resourceCulture);

	internal static string Error_FailedToCreateRandomFile => ResourceManager.GetString("Error_FailedToCreateRandomFile", resourceCulture);

	internal static string MissingRequiredEnvVar => ResourceManager.GetString("MissingRequiredEnvVar", resourceCulture);

	internal static string MissingRequiredEnvVarsDotnet => ResourceManager.GetString("MissingRequiredEnvVarsDotnet", resourceCulture);

	internal static string NoPackageFoldersFound => ResourceManager.GetString("NoPackageFoldersFound", resourceCulture);

	internal static string PackageFolderNotFound => ResourceManager.GetString("PackageFolderNotFound", resourceCulture);

	internal static string UnableToDetemineClientVersion => ResourceManager.GetString("UnableToDetemineClientVersion", resourceCulture);

	internal static string UnauthorizedLockFail => ResourceManager.GetString("UnauthorizedLockFail", resourceCulture);

	internal static string UnsupportedHashAlgorithm => ResourceManager.GetString("UnsupportedHashAlgorithm", resourceCulture);

	internal static string UnsupportedHashAlgorithmName => ResourceManager.GetString("UnsupportedHashAlgorithmName", resourceCulture);

	internal static string UnsupportedSignatureAlgorithmName => ResourceManager.GetString("UnsupportedSignatureAlgorithmName", resourceCulture);

	internal Strings()
	{
	}
}
