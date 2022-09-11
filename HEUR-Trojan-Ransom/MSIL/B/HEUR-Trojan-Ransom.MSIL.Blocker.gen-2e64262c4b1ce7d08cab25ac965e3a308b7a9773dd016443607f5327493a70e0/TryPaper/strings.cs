using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace TryPaper;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[CompilerGenerated]
[DebuggerNonUserCode]
internal class strings
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (object.ReferenceEquals(resourceMan, null))
			{
				ResourceManager resourceManager = (resourceMan = new ResourceManager("TryPaper.strings", typeof(strings).Assembly));
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

	internal static string AccountAddressSegment => ResourceManager.GetString("AccountAddressSegment", resourceCulture);

	internal static string BatchIdWasEmpty => ResourceManager.GetString("BatchIdWasEmpty", resourceCulture);

	internal static string BatchSpecifiedEmptyBatchId => ResourceManager.GetString("BatchSpecifiedEmptyBatchId", resourceCulture);

	internal static string mailing => ResourceManager.GetString("mailing", resourceCulture);

	internal static string MailingRecipientRequiredFields => ResourceManager.GetString("MailingRecipientRequiredFields", resourceCulture);

	internal static string NullMailingContent => ResourceManager.GetString("NullMailingContent", resourceCulture);

	internal static string PageUriFormat => ResourceManager.GetString("PageUriFormat", resourceCulture);

	internal static string ProductionApiEndpoint => ResourceManager.GetString("ProductionApiEndpoint", resourceCulture);

	internal static string SpoolUriSegment => ResourceManager.GetString("SpoolUriSegment", resourceCulture);

	internal static string TryPaperClientUserAgentFormat => ResourceManager.GetString("TryPaperClientUserAgentFormat", resourceCulture);

	internal strings()
	{
	}
}
