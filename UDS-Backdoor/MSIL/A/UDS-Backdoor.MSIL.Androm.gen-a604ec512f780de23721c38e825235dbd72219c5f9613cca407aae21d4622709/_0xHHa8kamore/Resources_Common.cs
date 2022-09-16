using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace _0xHHa8kamore;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[CompilerGenerated]
[DebuggerNonUserCode]
internal class Resources_Common
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
				resourceMan = new ResourceManager("Microsoft.VisualStudio.Azure.Common.Resources.Common", typeof(Resources_Common).Assembly);
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

	internal static string AzureSubscriptionNotCompatibleError => ResourceManager.GetString("AzureSubscriptionNotCompatibleError", resourceCulture);

	internal static string CloudServicesNotAvailable => ResourceManager.GetString("CloudServicesNotAvailable", resourceCulture);

	internal static string DebugStatus_InitDevStorage => ResourceManager.GetString("DebugStatus_InitDevStorage", resourceCulture);

	internal static string DebugStatus_Ready => ResourceManager.GetString("DebugStatus_Ready", resourceCulture);

	internal static string DeveloperPortal => ResourceManager.GetString("DeveloperPortal", resourceCulture);

	internal static string ErrorRetrievingCommonService => ResourceManager.GetString("ErrorRetrievingCommonService", resourceCulture);

	internal static string FailedToGetLoginResult => ResourceManager.GetString("FailedToGetLoginResult", resourceCulture);

	internal static string FailedToLogin => ResourceManager.GetString("FailedToLogin", resourceCulture);

	internal static string LoadingText => ResourceManager.GetString("LoadingText", resourceCulture);

	internal static string MissingTools => ResourceManager.GetString("MissingTools", resourceCulture);

	internal static string OfficialName => ResourceManager.GetString("OfficialName", resourceCulture);

	internal static string PackageOfficialName => ResourceManager.GetString("PackageOfficialName", resourceCulture);

	internal static string ServiceManagementErrorAuthenticationFailure => ResourceManager.GetString("ServiceManagementErrorAuthenticationFailure", resourceCulture);

	internal static string ServiceManagementErrorNetworkIssue => ResourceManager.GetString("ServiceManagementErrorNetworkIssue", resourceCulture);

	internal static string ServiceManagementErrorResourceNotFound => ResourceManager.GetString("ServiceManagementErrorResourceNotFound", resourceCulture);

	internal static string ServiceManagementErrorUnknownError => ResourceManager.GetString("ServiceManagementErrorUnknownError", resourceCulture);

	internal static string SolutionFullPathMustBeOpen => ResourceManager.GetString("SolutionFullPathMustBeOpen", resourceCulture);

	internal static string SubscriptionContextNotSupported => ResourceManager.GetString("SubscriptionContextNotSupported", resourceCulture);

	internal static string VirtualMachineOperationFailure => ResourceManager.GetString("VirtualMachineOperationFailure", resourceCulture);

	internal static string VisualStudioProductName => ResourceManager.GetString("VisualStudioProductName", resourceCulture);

	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
	internal Resources_Common()
	{
	}
}
