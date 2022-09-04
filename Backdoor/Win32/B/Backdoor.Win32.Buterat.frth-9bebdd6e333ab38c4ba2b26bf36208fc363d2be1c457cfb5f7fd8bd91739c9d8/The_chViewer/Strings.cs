using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace The_chViewer;

[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
public class Strings
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static ResourceManager ResourceManager
	{
		get
		{
			if (resourceMan == null)
			{
				resourceMan = new ResourceManager("The_chViewer.Strings", typeof(Strings).Assembly);
			}
			return resourceMan;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static CultureInfo Culture
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

	public static string GetGpsRecs => ResourceManager.GetString("GetGpsRecs", resourceCulture);

	public static string GetHeader => ResourceManager.GetString("GetHeader", resourceCulture);

	public static string GetId => ResourceManager.GetString("GetId", resourceCulture);

	public static string PORT_ALREADY_OPEN => ResourceManager.GetString("PORT_ALREADY_OPEN", resourceCulture);

	public static string PORT_BLOCKED => ResourceManager.GetString("PORT_BLOCKED", resourceCulture);

	public static string PORT_OPENED_SUCCESSFULLY => ResourceManager.GetString("PORT_OPENED_SUCCESSFULLY", resourceCulture);

	public static string TRACK_LOADED => ResourceManager.GetString("TRACK_LOADED", resourceCulture);

	internal Strings()
	{
	}
}
