using System.ComponentModel;
using System.Globalization;
using System.Resources;

namespace MakeExeZip;

internal class Resource1
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
				ResourceManager resourceManager = (resourceMan = new ResourceManager("MakeZipExe", typeof(Resource1).Assembly));
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

	internal static string noOutputPath => ResourceManager.GetString("noOutputPath", resourceCulture);

	internal static string noZipFileSpecified => ResourceManager.GetString("noZipFileSpecified", resourceCulture);

	internal static string usage => ResourceManager.GetString("usage", resourceCulture);

	internal static string unknownArg => ResourceManager.GetString("unknownArg", resourceCulture);

	internal static string inputFileNotFound => ResourceManager.GetString("inputFileNotFound", resourceCulture);

	internal static string couldNotFindStubExe => ResourceManager.GetString("couldNotFindStubExe", resourceCulture);

	internal static string errorReadingZipFile => ResourceManager.GetString("errorReadingZipFile", resourceCulture);

	internal static string success => ResourceManager.GetString("success", resourceCulture);

	internal static string failed => ResourceManager.GetString("failed", resourceCulture);

	internal static string banner => ResourceManager.GetString("banner", resourceCulture);

	internal Resource1()
	{
	}
}
