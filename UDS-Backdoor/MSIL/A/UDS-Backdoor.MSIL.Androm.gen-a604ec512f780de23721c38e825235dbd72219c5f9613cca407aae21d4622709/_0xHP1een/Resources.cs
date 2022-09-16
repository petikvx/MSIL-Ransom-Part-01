using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace _0xHP1een;

[CompilerGenerated]
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
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
				resourceMan = new ResourceManager("Microsoft.VisualStudio.Azure.Common.PaaSExtensions.Resources", typeof(Resources).Assembly);
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

	internal static string AddExtensionFailed => ResourceManager.GetString("AddExtensionFailed", resourceCulture);

	internal static string ExtensionNotFoundError => ResourceManager.GetString("ExtensionNotFoundError", resourceCulture);

	internal static string FailedToCreateEncryptionCertificateForExtensions => ResourceManager.GetString("FailedToCreateEncryptionCertificateForExtensions", resourceCulture);

	internal static string FailedToUploadEncryptionCertificateForExtensions => ResourceManager.GetString("FailedToUploadEncryptionCertificateForExtensions", resourceCulture);

	internal static string GetDeploymentFailed => ResourceManager.GetString("GetDeploymentFailed", resourceCulture);

	internal static string PrivateConfigValidationFailure => ResourceManager.GetString("PrivateConfigValidationFailure", resourceCulture);

	internal static string PublicConfigValidationFailure => ResourceManager.GetString("PublicConfigValidationFailure", resourceCulture);

	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
	internal Resources()
	{
	}
}
