using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;

namespace System.Data.SQLite;

[DebuggerNonUserCode]
internal class SR
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
				ResourceManager resourceManager = (resourceMan = new ResourceManager("System.Data.SQLite.SR", typeof(SR).Assembly));
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

	internal static string DataTypes => ResourceManager.GetString("DataTypes", resourceCulture);

	internal static string Keywords => ResourceManager.GetString("Keywords", resourceCulture);

	internal static string MetaDataCollections => ResourceManager.GetString("MetaDataCollections", resourceCulture);

	internal SR()
	{
	}
}
